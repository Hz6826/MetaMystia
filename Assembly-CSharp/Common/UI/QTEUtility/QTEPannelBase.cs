using System;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using GameData.Core.MusicUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace Common.UI.QTEUtility
{
	// Token: 0x02000392 RID: 914
	public class QTEPannelBase : UIPanel
	{
		// Token: 0x06006CE8 RID: 27880 RVA: 0x00209AE8 File Offset: 0x00207CE8
		// Note: this type is marked as 'beforefieldinit'.
		static QTEPannelBase()
		{
			Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.QTEUtility", "QTEPannelBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr);
			QTEPannelBase.NativeFieldInfoPtr_FULL_SCORE_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "FULL_SCORE_VALUE");
			QTEPannelBase.NativeFieldInfoPtr_COMBO_DEDUCT_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "COMBO_DEDUCT_VALUE");
			QTEPannelBase.NativeFieldInfoPtr_PRELOAD_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "PRELOAD_COUNT");
			QTEPannelBase.NativeFieldInfoPtr_Shine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "Shine");
			QTEPannelBase.NativeFieldInfoPtr_m_NoteStartUpdateOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_NoteStartUpdateOffset");
			QTEPannelBase.NativeFieldInfoPtr_m_MidiNotePreGoodLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_MidiNotePreGoodLength");
			QTEPannelBase.NativeFieldInfoPtr_m_MidiNotePrePerfectLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_MidiNotePrePerfectLength");
			QTEPannelBase.NativeFieldInfoPtr_m_MidiNotePostPerfectLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_MidiNotePostPerfectLength");
			QTEPannelBase.NativeFieldInfoPtr_m_CloseOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_CloseOffset");
			QTEPannelBase.NativeFieldInfoPtr_m_SingleClickNoteParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_SingleClickNoteParent");
			QTEPannelBase.NativeFieldInfoPtr_m_SingleHoldNoteParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_SingleHoldNoteParent");
			QTEPannelBase.NativeFieldInfoPtr_m_HoldNoteStartParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_HoldNoteStartParent");
			QTEPannelBase.NativeFieldInfoPtr_m_HoldNoteEndParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_HoldNoteEndParent");
			QTEPannelBase.NativeFieldInfoPtr_m_ScoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_ScoreText");
			QTEPannelBase.NativeFieldInfoPtr_m_ScoreText2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_ScoreText2");
			QTEPannelBase.NativeFieldInfoPtr_m_ProgressText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_ProgressText");
			QTEPannelBase.NativeFieldInfoPtr_m_ProgressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_ProgressBar");
			QTEPannelBase.NativeFieldInfoPtr_m_NoteSucceedAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_NoteSucceedAnimation");
			QTEPannelBase.NativeFieldInfoPtr_m_NoteFailedAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_NoteFailedAnimation");
			QTEPannelBase.NativeFieldInfoPtr_m_NoteAnimationField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_NoteAnimationField");
			QTEPannelBase.NativeFieldInfoPtr_m_PerfectSingleSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_PerfectSingleSFX");
			QTEPannelBase.NativeFieldInfoPtr_m_GoodSingleSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_GoodSingleSFX");
			QTEPannelBase.NativeFieldInfoPtr_m_MissSingleSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_MissSingleSFX");
			QTEPannelBase.NativeFieldInfoPtr_m_PerfectLeftSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_PerfectLeftSFX");
			QTEPannelBase.NativeFieldInfoPtr_m_GoodLeftSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_GoodLeftSFX");
			QTEPannelBase.NativeFieldInfoPtr_m_PerfectRightSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_PerfectRightSFX");
			QTEPannelBase.NativeFieldInfoPtr_m_GoodRightSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_GoodRightSFX");
			QTEPannelBase.NativeFieldInfoPtr_perfectAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "perfectAnimator");
			QTEPannelBase.NativeFieldInfoPtr_goodAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "goodAnimator");
			QTEPannelBase.NativeFieldInfoPtr_missAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "missAnimator");
			QTEPannelBase.NativeFieldInfoPtr_comboAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "comboAnimator");
			QTEPannelBase.NativeFieldInfoPtr_scoreAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "scoreAnimator");
			QTEPannelBase.NativeFieldInfoPtr_OnComboUpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "OnComboUpdateCallback");
			QTEPannelBase.NativeFieldInfoPtr_OnPerfectNumberUpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "OnPerfectNumberUpdateCallback");
			QTEPannelBase.NativeFieldInfoPtr_OnGoodNumberUpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "OnGoodNumberUpdateCallback");
			QTEPannelBase.NativeFieldInfoPtr_OnMissNumberUpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "OnMissNumberUpdateCallback");
			QTEPannelBase.NativeFieldInfoPtr_m_ActiveAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_ActiveAnimations");
			QTEPannelBase.NativeFieldInfoPtr_m_CurrentInputCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_CurrentInputCollection");
			QTEPannelBase.NativeFieldInfoPtr_m_FocusingNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_FocusingNotes");
			QTEPannelBase.NativeFieldInfoPtr_m_UpdatingNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_UpdatingNotes");
			QTEPannelBase.NativeFieldInfoPtr_m_ComboScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_ComboScore");
			QTEPannelBase.NativeFieldInfoPtr_m_FinalScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_FinalScore");
			QTEPannelBase.NativeFieldInfoPtr_m_HoldNoteEndPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_HoldNoteEndPool");
			QTEPannelBase.NativeFieldInfoPtr_m_HoldNoteStartPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_HoldNoteStartPool");
			QTEPannelBase.NativeFieldInfoPtr_m_LastMidiNoteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_LastMidiNoteCount");
			QTEPannelBase.NativeFieldInfoPtr_m_NoteFailedAnimationPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_NoteFailedAnimationPool");
			QTEPannelBase.NativeFieldInfoPtr_m_NoteSucceedAnimationPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_NoteSucceedAnimationPool");
			QTEPannelBase.NativeFieldInfoPtr_m_PerNoteScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_PerNoteScore");
			QTEPannelBase.NativeFieldInfoPtr_m_SingleClickNotePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_SingleClickNotePool");
			QTEPannelBase.NativeFieldInfoPtr_m_SingleHoldNotePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_SingleHoldNotePool");
			QTEPannelBase.NativeFieldInfoPtr_m_TotalMidiNoteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_TotalMidiNoteCount");
			QTEPannelBase.NativeFieldInfoPtr_m_WorkSceneMidiNoteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_WorkSceneMidiNoteCount");
			QTEPannelBase.NativeFieldInfoPtr_m_WorkSceneSucceededMidiNoteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "m_WorkSceneSucceededMidiNoteCount");
			QTEPannelBase.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "<OpenContext>k__BackingField");
			QTEPannelBase.NativeFieldInfoPtr__NoteStartUpdateOffsetMiliseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "<NoteStartUpdateOffsetMiliseconds>k__BackingField");
			QTEPannelBase.NativeFieldInfoPtr__WorldToLocalMatrix_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "<WorldToLocalMatrix>k__BackingField");
			QTEPannelBase.NativeFieldInfoPtr__CurrentComboValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "<CurrentComboValue>k__BackingField");
			QTEPannelBase.NativeFieldInfoPtr__CurrentPerfectValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "<CurrentPerfectValue>k__BackingField");
			QTEPannelBase.NativeFieldInfoPtr__CurrentGoodValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "<CurrentGoodValue>k__BackingField");
			QTEPannelBase.NativeFieldInfoPtr__CurrentMissValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "<CurrentMissValue>k__BackingField");
			QTEPannelBase.NativeFieldInfoPtr__queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "_queue");
			QTEPannelBase.NativeMethodInfoPtr_get_OpenContext_Protected_get_Nullable_1_PannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685710);
			QTEPannelBase.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685711);
			QTEPannelBase.NativeMethodInfoPtr_get_IsDemoMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685712);
			QTEPannelBase.NativeMethodInfoPtr_get_CurrentTime_Protected_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685713);
			QTEPannelBase.NativeMethodInfoPtr_get_WorkMode_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685714);
			QTEPannelBase.NativeMethodInfoPtr_get_ActiveNoteField_Protected_Abstract_Virtual_New_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685715);
			QTEPannelBase.NativeMethodInfoPtr_get_NoteStartUpdateOffsetMiliseconds_Protected_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685716);
			QTEPannelBase.NativeMethodInfoPtr_set_NoteStartUpdateOffsetMiliseconds_Private_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685717);
			QTEPannelBase.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685718);
			QTEPannelBase.NativeMethodInfoPtr_set_WorldToLocalMatrix_Private_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685719);
			QTEPannelBase.NativeMethodInfoPtr_get_WorldToLocalMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685720);
			QTEPannelBase.NativeMethodInfoPtr_get_CurrentComboValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685721);
			QTEPannelBase.NativeMethodInfoPtr_set_CurrentComboValue_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685722);
			QTEPannelBase.NativeMethodInfoPtr_get_CurrentPerfectValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685723);
			QTEPannelBase.NativeMethodInfoPtr_set_CurrentPerfectValue_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685724);
			QTEPannelBase.NativeMethodInfoPtr_get_CurrentGoodValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685725);
			QTEPannelBase.NativeMethodInfoPtr_set_CurrentGoodValue_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685726);
			QTEPannelBase.NativeMethodInfoPtr_get_CurrentMissValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685727);
			QTEPannelBase.NativeMethodInfoPtr_set_CurrentMissValue_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685728);
			QTEPannelBase.NativeMethodInfoPtr_set_CurrentCombo_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685729);
			QTEPannelBase.NativeMethodInfoPtr_get_CurrentCombo_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685730);
			QTEPannelBase.NativeMethodInfoPtr_set_CurrentPerfect_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685731);
			QTEPannelBase.NativeMethodInfoPtr_get_CurrentPerfect_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685732);
			QTEPannelBase.NativeMethodInfoPtr_set_CurrentGood_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685733);
			QTEPannelBase.NativeMethodInfoPtr_get_CurrentGood_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685734);
			QTEPannelBase.NativeMethodInfoPtr_set_CurrentMiss_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685735);
			QTEPannelBase.NativeMethodInfoPtr_get_CurrentMiss_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685736);
			QTEPannelBase.NativeMethodInfoPtr_get_CurrentInput_Public_get_NotePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685737);
			QTEPannelBase.NativeMethodInfoPtr_get_FinalScore_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685738);
			QTEPannelBase.NativeMethodInfoPtr_set_FinalScore_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685739);
			QTEPannelBase.NativeMethodInfoPtr_AnimatorPlay_Public_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685740);
			QTEPannelBase.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685741);
			QTEPannelBase.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685742);
			QTEPannelBase.NativeMethodInfoPtr_InverseLerp_Protected_Static_Double_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685743);
			QTEPannelBase.NativeMethodInfoPtr_Lerp_Protected_Static_Single_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685744);
			QTEPannelBase.NativeMethodInfoPtr_Clamp01_Private_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685745);
			QTEPannelBase.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685746);
			QTEPannelBase.NativeMethodInfoPtr_TryPlayNoteL_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685747);
			QTEPannelBase.NativeMethodInfoPtr_TryReleaseNoteL_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685748);
			QTEPannelBase.NativeMethodInfoPtr_TryPlayNoteR_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685749);
			QTEPannelBase.NativeMethodInfoPtr_TryReleaseNoteR_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685750);
			QTEPannelBase.NativeMethodInfoPtr_TryClickCurrentNote_Private_Void_NotePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685751);
			QTEPannelBase.NativeMethodInfoPtr_TryReleaseCurrentNote_Private_Void_NotePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685752);
			QTEPannelBase.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685753);
			QTEPannelBase.NativeMethodInfoPtr_CalculateScore_Public_Static_ValueTuple_2_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685754);
			QTEPannelBase.NativeMethodInfoPtr_UpdateScore_Public_Static_Void_NoteStatus_Single_Single_byref_Int32_byref_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685755);
			QTEPannelBase.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685756);
			QTEPannelBase.NativeMethodInfoPtr_PlayCorrectAudio_Public_Void_Boolean_NotePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685757);
			QTEPannelBase.NativeMethodInfoPtr_ReleaseNote_Public_Void_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685758);
			QTEPannelBase.NativeMethodInfoPtr_GetNoteCount_Protected_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685759);
			QTEPannelBase.NativeMethodInfoPtr_UpdateProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685760);
			QTEPannelBase.NativeMethodInfoPtr_PlayNoteSucceedAnimation_Protected_Void_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685761);
			QTEPannelBase.NativeMethodInfoPtr_PlayNoteFailedAnimation_Protected_Void_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685762);
			QTEPannelBase.NativeMethodInfoPtr_EvaluateAndReleaseNote_Public_Void_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685763);
			QTEPannelBase.NativeMethodInfoPtr_OnNoteEvaluated_Protected_Virtual_New_Void_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685764);
			QTEPannelBase.NativeMethodInfoPtr_GetFocusingNote_Protected_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685765);
			QTEPannelBase.NativeMethodInfoPtr_UpdateFocusingNote_Protected_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685766);
			QTEPannelBase.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685767);
			QTEPannelBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685768);
			QTEPannelBase.NativeMethodInfoPtr_Method_Private_T_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685770);
			QTEPannelBase.NativeMethodInfoPtr_Method_Internal_Static_Void_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685771);
			QTEPannelBase.NativeMethodInfoPtr_Method_Private_NoteHeadFinishAnimationController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685772);
			QTEPannelBase.NativeMethodInfoPtr_Method_Private_NoteHeadFinishAnimationController_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685773);
			QTEPannelBase.NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685774);
			QTEPannelBase.NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685775);
			QTEPannelBase.NativeMethodInfoPtr_Method_Private_T_T_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685776);
			QTEPannelBase.NativeMethodInfoPtr_Method_Private_NoteHeadBase_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685777);
			QTEPannelBase.NativeMethodInfoPtr_Method_Private_NoteHeadBase_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685778);
			QTEPannelBase.NativeMethodInfoPtr_Method_Private_NoteHeadBase_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685779);
			QTEPannelBase.NativeMethodInfoPtr_Method_Private_NoteHeadBase_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685780);
			QTEPannelBase.NativeMethodInfoPtr_Method_Private_Void_NoteHeadBase_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685781);
			QTEPannelBase.NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadBase_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685782);
			QTEPannelBase.NativeMethodInfoPtr_Method_Internal_Static_Void_ObjectPool_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685783);
			QTEPannelBase.NativeMethodInfoPtr__UpdateProgress_b__128_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685784);
			QTEPannelBase.NativeMethodInfoPtr_Method_Private_Void_NotePosition_byref___c__DisplayClass133_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685785);
			QTEPannelBase.NativeMethodInfoPtr_Method_Private_Void_NoteHeadBase_byref___c__DisplayClass135_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, 100685786);
		}

		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x06006CE9 RID: 27881 RVA: 0x0020A5CC File Offset: 0x002087CC
		// (set) Token: 0x06006CEA RID: 27882 RVA: 0x0020A604 File Offset: 0x00208804
		public unsafe Nullable<QTEPannel.PannelOpenContext> OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_OpenContext_Protected_get_Nullable_1_PannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<QTEPannel.PannelOpenContext>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274444, XrefRangeEnd = 274445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x06006CEB RID: 27883 RVA: 0x0020A64C File Offset: 0x0020884C
		public unsafe bool IsDemoMode
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 274448, RefRangeEnd = 274455, XrefRangeStart = 274445, XrefRangeEnd = 274448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_IsDemoMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x06006CEC RID: 27884 RVA: 0x0020A688 File Offset: 0x00208888
		public unsafe long CurrentTime
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 274458, RefRangeEnd = 274460, XrefRangeStart = 274455, XrefRangeEnd = 274458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_CurrentTime_Protected_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x06006CED RID: 27885 RVA: 0x0020A6C4 File Offset: 0x002088C4
		public unsafe virtual bool WorkMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274460, XrefRangeEnd = 274463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannelBase.NativeMethodInfoPtr_get_WorkMode_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x06006CEE RID: 27886 RVA: 0x0020A70C File Offset: 0x0020890C
		public unsafe virtual RectTransform ActiveNoteField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannelBase.NativeMethodInfoPtr_get_ActiveNoteField_Protected_Abstract_Virtual_New_get_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x06006CEF RID: 27887 RVA: 0x0020A758 File Offset: 0x00208958
		// (set) Token: 0x06006CF0 RID: 27888 RVA: 0x0020A794 File Offset: 0x00208994
		public unsafe long NoteStartUpdateOffsetMiliseconds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_NoteStartUpdateOffsetMiliseconds_Protected_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_set_NoteStartUpdateOffsetMiliseconds_Private_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x06006CF1 RID: 27889 RVA: 0x0020A7D4 File Offset: 0x002089D4
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannelBase.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x06006CF3 RID: 27891 RVA: 0x0020A85C File Offset: 0x00208A5C
		// (set) Token: 0x06006CF2 RID: 27890 RVA: 0x0020A81C File Offset: 0x00208A1C
		public unsafe Matrix4x4 WorldToLocalMatrix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_WorldToLocalMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_set_WorldToLocalMatrix_Private_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x06006CF4 RID: 27892 RVA: 0x0020A898 File Offset: 0x00208A98
		// (set) Token: 0x06006CF5 RID: 27893 RVA: 0x0020A8D4 File Offset: 0x00208AD4
		public unsafe int CurrentComboValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_CurrentComboValue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_set_CurrentComboValue_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002584 RID: 9604
		// (get) Token: 0x06006CF6 RID: 27894 RVA: 0x0020A914 File Offset: 0x00208B14
		// (set) Token: 0x06006CF7 RID: 27895 RVA: 0x0020A950 File Offset: 0x00208B50
		public unsafe int CurrentPerfectValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_CurrentPerfectValue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_set_CurrentPerfectValue_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002585 RID: 9605
		// (get) Token: 0x06006CF8 RID: 27896 RVA: 0x0020A990 File Offset: 0x00208B90
		// (set) Token: 0x06006CF9 RID: 27897 RVA: 0x0020A9CC File Offset: 0x00208BCC
		public unsafe int CurrentGoodValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_CurrentGoodValue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_set_CurrentGoodValue_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002586 RID: 9606
		// (get) Token: 0x06006CFA RID: 27898 RVA: 0x0020AA0C File Offset: 0x00208C0C
		// (set) Token: 0x06006CFB RID: 27899 RVA: 0x0020AA48 File Offset: 0x00208C48
		public unsafe int CurrentMissValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_CurrentMissValue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_set_CurrentMissValue_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002587 RID: 9607
		// (get) Token: 0x06006CFD RID: 27901 RVA: 0x0020AAC8 File Offset: 0x00208CC8
		// (set) Token: 0x06006CFC RID: 27900 RVA: 0x0020AA88 File Offset: 0x00208C88
		public unsafe int CurrentCombo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_CurrentCombo_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 274479, RefRangeEnd = 274483, XrefRangeStart = 274463, XrefRangeEnd = 274479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_set_CurrentCombo_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x06006CFF RID: 27903 RVA: 0x0020AB44 File Offset: 0x00208D44
		// (set) Token: 0x06006CFE RID: 27902 RVA: 0x0020AB04 File Offset: 0x00208D04
		public unsafe int CurrentPerfect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_CurrentPerfect_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 274496, RefRangeEnd = 274498, XrefRangeStart = 274483, XrefRangeEnd = 274496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_set_CurrentPerfect_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002589 RID: 9609
		// (get) Token: 0x06006D01 RID: 27905 RVA: 0x0020ABC0 File Offset: 0x00208DC0
		// (set) Token: 0x06006D00 RID: 27904 RVA: 0x0020AB80 File Offset: 0x00208D80
		public unsafe int CurrentGood
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_CurrentGood_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 274511, RefRangeEnd = 274513, XrefRangeStart = 274498, XrefRangeEnd = 274511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_set_CurrentGood_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700258A RID: 9610
		// (get) Token: 0x06006D03 RID: 27907 RVA: 0x0020AC3C File Offset: 0x00208E3C
		// (set) Token: 0x06006D02 RID: 27906 RVA: 0x0020ABFC File Offset: 0x00208DFC
		public unsafe int CurrentMiss
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_CurrentMiss_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 274526, RefRangeEnd = 274528, XrefRangeStart = 274513, XrefRangeEnd = 274526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_set_CurrentMiss_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700258B RID: 9611
		// (get) Token: 0x06006D04 RID: 27908 RVA: 0x0020AC78 File Offset: 0x00208E78
		public unsafe IzakayaMusic.SingleNote.NotePosition CurrentInput
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 274542, RefRangeEnd = 274544, XrefRangeStart = 274528, XrefRangeEnd = 274542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_CurrentInput_Public_get_NotePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700258C RID: 9612
		// (get) Token: 0x06006D05 RID: 27909 RVA: 0x0020ACB4 File Offset: 0x00208EB4
		// (set) Token: 0x06006D06 RID: 27910 RVA: 0x0020ACF0 File Offset: 0x00208EF0
		public unsafe float FinalScore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_get_FinalScore_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 274571, RefRangeEnd = 274573, XrefRangeStart = 274544, XrefRangeEnd = 274571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_set_FinalScore_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006D07 RID: 27911 RVA: 0x0020AD30 File Offset: 0x00208F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274573, XrefRangeEnd = 274582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AnimatorPlay(Animator animator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_AnimatorPlay_Public_Void_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D08 RID: 27912 RVA: 0x0020AD74 File Offset: 0x00208F74
		[CallerCount(0)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannelBase.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D09 RID: 27913 RVA: 0x0020ADB0 File Offset: 0x00208FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274582, XrefRangeEnd = 274587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannelBase.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D0A RID: 27914 RVA: 0x0020ADEC File Offset: 0x00208FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274590, RefRangeEnd = 274591, XrefRangeStart = 274587, XrefRangeEnd = 274590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double InverseLerp(long a, long b, long value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_InverseLerp_Protected_Static_Double_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006D0B RID: 27915 RVA: 0x0020AE48 File Offset: 0x00209048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274591, XrefRangeEnd = 274594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Lerp(double a, double b, double t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Lerp_Protected_Static_Single_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x0020AEA4 File Offset: 0x002090A4
		[CallerCount(0)]
		public unsafe static double Clamp01(double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Clamp01_Private_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006D0D RID: 27917 RVA: 0x0020AEE4 File Offset: 0x002090E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 274848, RefRangeEnd = 274850, XrefRangeStart = 274594, XrefRangeEnd = 274848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannelBase.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D0E RID: 27918 RVA: 0x0020AF20 File Offset: 0x00209120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274850, XrefRangeEnd = 274855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryPlayNoteL(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_TryPlayNoteL_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D0F RID: 27919 RVA: 0x0020AF68 File Offset: 0x00209168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274855, XrefRangeEnd = 274865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryReleaseNoteL(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_TryReleaseNoteL_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D10 RID: 27920 RVA: 0x0020AFB0 File Offset: 0x002091B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274865, XrefRangeEnd = 274870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryPlayNoteR(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_TryPlayNoteR_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D11 RID: 27921 RVA: 0x0020AFF8 File Offset: 0x002091F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274870, XrefRangeEnd = 274880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryReleaseNoteR(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_TryReleaseNoteR_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D12 RID: 27922 RVA: 0x0020B040 File Offset: 0x00209240
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 274919, RefRangeEnd = 274923, XrefRangeStart = 274880, XrefRangeEnd = 274919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryClickCurrentNote(IzakayaMusic.SingleNote.NotePosition notePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref notePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_TryClickCurrentNote_Private_Void_NotePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D13 RID: 27923 RVA: 0x0020B080 File Offset: 0x00209280
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 274962, RefRangeEnd = 274964, XrefRangeStart = 274923, XrefRangeEnd = 274962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryReleaseCurrentNote(IzakayaMusic.SingleNote.NotePosition notePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref notePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_TryReleaseCurrentNote_Private_Void_NotePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D14 RID: 27924 RVA: 0x0020B0C0 File Offset: 0x002092C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275007, RefRangeEnd = 275009, XrefRangeStart = 274964, XrefRangeEnd = 275007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannelBase.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D15 RID: 27925 RVA: 0x0020B0FC File Offset: 0x002092FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275013, RefRangeEnd = 275014, XrefRangeStart = 275009, XrefRangeEnd = 275013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ValueTuple<float, float> CalculateScore(int allNotesLength)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref allNotesLength;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_CalculateScore_Public_Static_ValueTuple_2_Single_Single_Int32_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<float, float>(pointer);
		}

		// Token: 0x06006D16 RID: 27926 RVA: 0x0020B134 File Offset: 0x00209334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275014, RefRangeEnd = 275015, XrefRangeStart = 275014, XrefRangeEnd = 275014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateScore(NoteHeadBase.NoteStatus noteStatus, float perNoteScore, float comboScore, ref int currentMiss, ref int currentCombo, ref float currentScore)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref noteStatus;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perNoteScore;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comboScore;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentMiss;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentCombo;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentScore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_UpdateScore_Public_Static_Void_NoteStatus_Single_Single_byref_Int32_byref_Int32_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D17 RID: 27927 RVA: 0x0020B1B0 File Offset: 0x002093B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275102, RefRangeEnd = 275104, XrefRangeStart = 275015, XrefRangeEnd = 275102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannelBase.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D18 RID: 27928 RVA: 0x0020B1EC File Offset: 0x002093EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275114, RefRangeEnd = 275116, XrefRangeStart = 275104, XrefRangeEnd = 275114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCorrectAudio(bool isPerfect, IzakayaMusic.SingleNote.NotePosition notePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isPerfect;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_PlayCorrectAudio_Public_Void_Boolean_NotePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D19 RID: 27929 RVA: 0x0020B238 File Offset: 0x00209438
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 275137, RefRangeEnd = 275140, XrefRangeStart = 275116, XrefRangeEnd = 275137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseNote(NoteHeadBase noteHeadBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(noteHeadBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_ReleaseNote_Public_Void_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D1A RID: 27930 RVA: 0x0020B27C File Offset: 0x0020947C
		[CallerCount(0)]
		public unsafe virtual int GetNoteCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannelBase.NativeMethodInfoPtr_GetNoteCount_Protected_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006D1B RID: 27931 RVA: 0x0020B2C4 File Offset: 0x002094C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275140, XrefRangeEnd = 275154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_UpdateProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D1C RID: 27932 RVA: 0x0020B2F8 File Offset: 0x002094F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275165, RefRangeEnd = 275166, XrefRangeStart = 275154, XrefRangeEnd = 275165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayNoteSucceedAnimation(NoteHeadBase noteHeadBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(noteHeadBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_PlayNoteSucceedAnimation_Protected_Void_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D1D RID: 27933 RVA: 0x0020B33C File Offset: 0x0020953C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275166, XrefRangeEnd = 275177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayNoteFailedAnimation(NoteHeadBase noteHeadBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(noteHeadBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_PlayNoteFailedAnimation_Protected_Void_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D1E RID: 27934 RVA: 0x0020B380 File Offset: 0x00209580
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 275217, RefRangeEnd = 275223, XrefRangeStart = 275177, XrefRangeEnd = 275217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateAndReleaseNote(NoteHeadBase noteHeadBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(noteHeadBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_EvaluateAndReleaseNote_Public_Void_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D1F RID: 27935 RVA: 0x0020B3C4 File Offset: 0x002095C4
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnNoteEvaluated(NoteHeadBase noteHeadBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(noteHeadBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannelBase.NativeMethodInfoPtr_OnNoteEvaluated_Protected_Virtual_New_Void_NoteHeadBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D20 RID: 27936 RVA: 0x0020B414 File Offset: 0x00209614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275227, RefRangeEnd = 275228, XrefRangeStart = 275223, XrefRangeEnd = 275227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetFocusingNote(long currentTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_GetFocusingNote_Protected_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D21 RID: 27937 RVA: 0x0020B454 File Offset: 0x00209654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275296, RefRangeEnd = 275297, XrefRangeStart = 275228, XrefRangeEnd = 275296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFocusingNote(long currentTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_UpdateFocusingNote_Protected_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D22 RID: 27938 RVA: 0x0020B494 File Offset: 0x00209694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275346, RefRangeEnd = 275348, XrefRangeStart = 275297, XrefRangeEnd = 275346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QTEPannelBase.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x0020B4D0 File Offset: 0x002096D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275425, RefRangeEnd = 275427, XrefRangeStart = 275348, XrefRangeEnd = 275425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QTEPannelBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D24 RID: 27940 RVA: 0x0020B50C File Offset: 0x0020970C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275435, RefRangeEnd = 275437, XrefRangeStart = 275427, XrefRangeEnd = 275435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Method_Private_T_T_PDM_0<T>(T parent) where T : Component
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = parent;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref parent;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.MethodInfoStoreGeneric_Method_Private_T_T_PDM_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06006D25 RID: 27941 RVA: 0x0020B58C File Offset: 0x0020978C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275437, XrefRangeEnd = 275443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_T_PDM_0<T>(T instance) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = instance;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref instance;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.MethodInfoStoreGeneric_Method_Internal_Static_Void_T_PDM_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06006D26 RID: 27942 RVA: 0x0020B5F8 File Offset: 0x002097F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275443, XrefRangeEnd = 275446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadFinishAnimationController Method_Private_NoteHeadFinishAnimationController_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Method_Private_NoteHeadFinishAnimationController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NoteHeadFinishAnimationController>(intPtr3) : null;
		}

		// Token: 0x06006D27 RID: 27943 RVA: 0x0020B638 File Offset: 0x00209838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275446, XrefRangeEnd = 275449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadFinishAnimationController Method_Private_NoteHeadFinishAnimationController_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Method_Private_NoteHeadFinishAnimationController_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NoteHeadFinishAnimationController>(intPtr3) : null;
		}

		// Token: 0x06006D28 RID: 27944 RVA: 0x0020B678 File Offset: 0x00209878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275449, XrefRangeEnd = 275453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_0(NoteHeadFinishAnimationController animator)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D29 RID: 27945 RVA: 0x0020B6B0 File Offset: 0x002098B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275453, XrefRangeEnd = 275457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_1(NoteHeadFinishAnimationController animator)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_1, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D2A RID: 27946 RVA: 0x0020B6E8 File Offset: 0x002098E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 275465, RefRangeEnd = 275469, XrefRangeStart = 275457, XrefRangeEnd = 275465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Method_Private_T_T_PDM_1<T>(T parent) where T : Component
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = parent;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref parent;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.MethodInfoStoreGeneric_Method_Private_T_T_PDM_1<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x0020B768 File Offset: 0x00209968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275469, XrefRangeEnd = 275472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadBase Method_Private_NoteHeadBase_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Method_Private_NoteHeadBase_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NoteHeadBase>(intPtr3) : null;
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x0020B7A8 File Offset: 0x002099A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275472, XrefRangeEnd = 275475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadBase Method_Private_NoteHeadBase_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Method_Private_NoteHeadBase_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NoteHeadBase>(intPtr3) : null;
		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x0020B7E8 File Offset: 0x002099E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275475, XrefRangeEnd = 275478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadBase Method_Private_NoteHeadBase_PDM_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Method_Private_NoteHeadBase_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NoteHeadBase>(intPtr3) : null;
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x0020B828 File Offset: 0x00209A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275478, XrefRangeEnd = 275481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadBase Method_Private_NoteHeadBase_PDM_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Method_Private_NoteHeadBase_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NoteHeadBase>(intPtr3) : null;
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x0020B868 File Offset: 0x00209A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275481, XrefRangeEnd = 275494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_NoteHeadBase_PDM_0(NoteHeadBase noteHeadBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(noteHeadBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Method_Private_Void_NoteHeadBase_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D30 RID: 27952 RVA: 0x0020B8AC File Offset: 0x00209AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275494, XrefRangeEnd = 275498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_NoteHeadBase_PDM_0(NoteHeadBase noteHeadBase)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(noteHeadBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadBase_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D31 RID: 27953 RVA: 0x0020B8E4 File Offset: 0x00209AE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 275502, RefRangeEnd = 275508, XrefRangeStart = 275498, XrefRangeEnd = 275502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_ObjectPool_1_T_0<T>(ObjectPool<T> objectPool) where T : class
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectPool);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.MethodInfoStoreGeneric_Method_Internal_Static_Void_ObjectPool_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D32 RID: 27954 RVA: 0x0020B91C File Offset: 0x00209B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275508, XrefRangeEnd = 275510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateProgress_b__128_0(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr__UpdateProgress_b__128_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D33 RID: 27955 RVA: 0x0020B95C File Offset: 0x00209B5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 275534, RefRangeEnd = 275537, XrefRangeStart = 275510, XrefRangeEnd = 275534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_NotePosition_byref___c__DisplayClass133_0_0(IzakayaMusic.SingleNote.NotePosition channelId, ref QTEPannelBase.__c__DisplayClass133_0 A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channelId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Method_Private_Void_NotePosition_byref___c__DisplayClass133_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D34 RID: 27956 RVA: 0x0020B9B0 File Offset: 0x00209BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275537, XrefRangeEnd = 275542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_NoteHeadBase_byref___c__DisplayClass135_0_PDM_0(NoteHeadBase focusingNote, ref QTEPannelBase.__c__DisplayClass135_0 A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusingNote);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.NativeMethodInfoPtr_Method_Private_Void_NoteHeadBase_byref___c__DisplayClass135_0_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D35 RID: 27957 RVA: 0x0003ADEF File Offset: 0x00038FEF
		public QTEPannelBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700253E RID: 9534
		// (get) Token: 0x06006D36 RID: 27958 RVA: 0x0020BA08 File Offset: 0x00209C08
		// (set) Token: 0x06006D37 RID: 27959 RVA: 0x0003ADF8 File Offset: 0x00038FF8
		public unsafe static int FULL_SCORE_VALUE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.NativeFieldInfoPtr_FULL_SCORE_VALUE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.NativeFieldInfoPtr_FULL_SCORE_VALUE, (void*)(&value));
			}
		}

		// Token: 0x1700253F RID: 9535
		// (get) Token: 0x06006D38 RID: 27960 RVA: 0x0020BA24 File Offset: 0x00209C24
		// (set) Token: 0x06006D39 RID: 27961 RVA: 0x0003AE06 File Offset: 0x00039006
		public unsafe static int COMBO_DEDUCT_VALUE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.NativeFieldInfoPtr_COMBO_DEDUCT_VALUE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.NativeFieldInfoPtr_COMBO_DEDUCT_VALUE, (void*)(&value));
			}
		}

		// Token: 0x17002540 RID: 9536
		// (get) Token: 0x06006D3A RID: 27962 RVA: 0x0020BA40 File Offset: 0x00209C40
		// (set) Token: 0x06006D3B RID: 27963 RVA: 0x0003AE14 File Offset: 0x00039014
		public unsafe static int PRELOAD_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.NativeFieldInfoPtr_PRELOAD_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.NativeFieldInfoPtr_PRELOAD_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17002541 RID: 9537
		// (get) Token: 0x06006D3C RID: 27964 RVA: 0x0020BA5C File Offset: 0x00209C5C
		// (set) Token: 0x06006D3D RID: 27965 RVA: 0x0003AE22 File Offset: 0x00039022
		public unsafe static int Shine
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.NativeFieldInfoPtr_Shine, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.NativeFieldInfoPtr_Shine, (void*)(&value));
			}
		}

		// Token: 0x17002542 RID: 9538
		// (get) Token: 0x06006D3E RID: 27966 RVA: 0x0020BA78 File Offset: 0x00209C78
		// (set) Token: 0x06006D3F RID: 27967 RVA: 0x0003AE30 File Offset: 0x00039030
		public unsafe float m_NoteStartUpdateOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_NoteStartUpdateOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_NoteStartUpdateOffset)) = value;
			}
		}

		// Token: 0x17002543 RID: 9539
		// (get) Token: 0x06006D40 RID: 27968 RVA: 0x0020BAA0 File Offset: 0x00209CA0
		// (set) Token: 0x06006D41 RID: 27969 RVA: 0x0003AE4B File Offset: 0x0003904B
		public unsafe long m_MidiNotePreGoodLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_MidiNotePreGoodLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_MidiNotePreGoodLength)) = value;
			}
		}

		// Token: 0x17002544 RID: 9540
		// (get) Token: 0x06006D42 RID: 27970 RVA: 0x0020BAC8 File Offset: 0x00209CC8
		// (set) Token: 0x06006D43 RID: 27971 RVA: 0x0003AE66 File Offset: 0x00039066
		public unsafe long m_MidiNotePrePerfectLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_MidiNotePrePerfectLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_MidiNotePrePerfectLength)) = value;
			}
		}

		// Token: 0x17002545 RID: 9541
		// (get) Token: 0x06006D44 RID: 27972 RVA: 0x0020BAF0 File Offset: 0x00209CF0
		// (set) Token: 0x06006D45 RID: 27973 RVA: 0x0003AE81 File Offset: 0x00039081
		public unsafe long m_MidiNotePostPerfectLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_MidiNotePostPerfectLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_MidiNotePostPerfectLength)) = value;
			}
		}

		// Token: 0x17002546 RID: 9542
		// (get) Token: 0x06006D46 RID: 27974 RVA: 0x0020BB18 File Offset: 0x00209D18
		// (set) Token: 0x06006D47 RID: 27975 RVA: 0x0003AE9C File Offset: 0x0003909C
		public unsafe float m_CloseOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_CloseOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_CloseOffset)) = value;
			}
		}

		// Token: 0x17002547 RID: 9543
		// (get) Token: 0x06006D48 RID: 27976 RVA: 0x0020BB40 File Offset: 0x00209D40
		// (set) Token: 0x06006D49 RID: 27977 RVA: 0x0003AEB7 File Offset: 0x000390B7
		public unsafe NoteHeadBase m_SingleClickNoteParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_SingleClickNoteParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_SingleClickNoteParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002548 RID: 9544
		// (get) Token: 0x06006D4A RID: 27978 RVA: 0x0020BB70 File Offset: 0x00209D70
		// (set) Token: 0x06006D4B RID: 27979 RVA: 0x0003AED6 File Offset: 0x000390D6
		public unsafe NoteHeadBase m_SingleHoldNoteParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_SingleHoldNoteParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_SingleHoldNoteParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002549 RID: 9545
		// (get) Token: 0x06006D4C RID: 27980 RVA: 0x0020BBA0 File Offset: 0x00209DA0
		// (set) Token: 0x06006D4D RID: 27981 RVA: 0x0003AEF5 File Offset: 0x000390F5
		public unsafe NoteHeadBase m_HoldNoteStartParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_HoldNoteStartParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_HoldNoteStartParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254A RID: 9546
		// (get) Token: 0x06006D4E RID: 27982 RVA: 0x0020BBD0 File Offset: 0x00209DD0
		// (set) Token: 0x06006D4F RID: 27983 RVA: 0x0003AF14 File Offset: 0x00039114
		public unsafe NoteHeadBase m_HoldNoteEndParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_HoldNoteEndParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_HoldNoteEndParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254B RID: 9547
		// (get) Token: 0x06006D50 RID: 27984 RVA: 0x0020BC00 File Offset: 0x00209E00
		// (set) Token: 0x06006D51 RID: 27985 RVA: 0x0003AF33 File Offset: 0x00039133
		public unsafe TextMeshProUGUI m_ScoreText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_ScoreText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_ScoreText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254C RID: 9548
		// (get) Token: 0x06006D52 RID: 27986 RVA: 0x0020BC30 File Offset: 0x00209E30
		// (set) Token: 0x06006D53 RID: 27987 RVA: 0x0003AF52 File Offset: 0x00039152
		public unsafe TextMeshProUGUI m_ScoreText2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_ScoreText2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_ScoreText2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254D RID: 9549
		// (get) Token: 0x06006D54 RID: 27988 RVA: 0x0020BC60 File Offset: 0x00209E60
		// (set) Token: 0x06006D55 RID: 27989 RVA: 0x0003AF71 File Offset: 0x00039171
		public unsafe TextMeshProUGUI m_ProgressText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_ProgressText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_ProgressText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254E RID: 9550
		// (get) Token: 0x06006D56 RID: 27990 RVA: 0x0020BC90 File Offset: 0x00209E90
		// (set) Token: 0x06006D57 RID: 27991 RVA: 0x0003AF90 File Offset: 0x00039190
		public unsafe Image m_ProgressBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_ProgressBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_ProgressBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700254F RID: 9551
		// (get) Token: 0x06006D58 RID: 27992 RVA: 0x0020BCC0 File Offset: 0x00209EC0
		// (set) Token: 0x06006D59 RID: 27993 RVA: 0x0003AFAF File Offset: 0x000391AF
		public unsafe NoteHeadFinishAnimationController m_NoteSucceedAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_NoteSucceedAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadFinishAnimationController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_NoteSucceedAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002550 RID: 9552
		// (get) Token: 0x06006D5A RID: 27994 RVA: 0x0020BCF0 File Offset: 0x00209EF0
		// (set) Token: 0x06006D5B RID: 27995 RVA: 0x0003AFCE File Offset: 0x000391CE
		public unsafe NoteHeadFinishAnimationController m_NoteFailedAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_NoteFailedAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadFinishAnimationController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_NoteFailedAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002551 RID: 9553
		// (get) Token: 0x06006D5C RID: 27996 RVA: 0x0020BD20 File Offset: 0x00209F20
		// (set) Token: 0x06006D5D RID: 27997 RVA: 0x0003AFED File Offset: 0x000391ED
		public unsafe RectTransform m_NoteAnimationField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_NoteAnimationField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_NoteAnimationField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x06006D5E RID: 27998 RVA: 0x0020BD50 File Offset: 0x00209F50
		// (set) Token: 0x06006D5F RID: 27999 RVA: 0x0003B00C File Offset: 0x0003920C
		public unsafe AudioClip m_PerfectSingleSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_PerfectSingleSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_PerfectSingleSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x06006D60 RID: 28000 RVA: 0x0020BD80 File Offset: 0x00209F80
		// (set) Token: 0x06006D61 RID: 28001 RVA: 0x0003B02B File Offset: 0x0003922B
		public unsafe AudioClip m_GoodSingleSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_GoodSingleSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_GoodSingleSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x06006D62 RID: 28002 RVA: 0x0020BDB0 File Offset: 0x00209FB0
		// (set) Token: 0x06006D63 RID: 28003 RVA: 0x0003B04A File Offset: 0x0003924A
		public unsafe AudioClip m_MissSingleSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_MissSingleSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_MissSingleSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002555 RID: 9557
		// (get) Token: 0x06006D64 RID: 28004 RVA: 0x0020BDE0 File Offset: 0x00209FE0
		// (set) Token: 0x06006D65 RID: 28005 RVA: 0x0003B069 File Offset: 0x00039269
		public unsafe AudioClip m_PerfectLeftSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_PerfectLeftSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_PerfectLeftSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002556 RID: 9558
		// (get) Token: 0x06006D66 RID: 28006 RVA: 0x0020BE10 File Offset: 0x0020A010
		// (set) Token: 0x06006D67 RID: 28007 RVA: 0x0003B088 File Offset: 0x00039288
		public unsafe AudioClip m_GoodLeftSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_GoodLeftSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_GoodLeftSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002557 RID: 9559
		// (get) Token: 0x06006D68 RID: 28008 RVA: 0x0020BE40 File Offset: 0x0020A040
		// (set) Token: 0x06006D69 RID: 28009 RVA: 0x0003B0A7 File Offset: 0x000392A7
		public unsafe AudioClip m_PerfectRightSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_PerfectRightSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_PerfectRightSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002558 RID: 9560
		// (get) Token: 0x06006D6A RID: 28010 RVA: 0x0020BE70 File Offset: 0x0020A070
		// (set) Token: 0x06006D6B RID: 28011 RVA: 0x0003B0C6 File Offset: 0x000392C6
		public unsafe AudioClip m_GoodRightSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_GoodRightSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_GoodRightSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002559 RID: 9561
		// (get) Token: 0x06006D6C RID: 28012 RVA: 0x0020BEA0 File Offset: 0x0020A0A0
		// (set) Token: 0x06006D6D RID: 28013 RVA: 0x0003B0E5 File Offset: 0x000392E5
		public unsafe Animator perfectAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_perfectAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_perfectAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255A RID: 9562
		// (get) Token: 0x06006D6E RID: 28014 RVA: 0x0020BED0 File Offset: 0x0020A0D0
		// (set) Token: 0x06006D6F RID: 28015 RVA: 0x0003B104 File Offset: 0x00039304
		public unsafe Animator goodAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_goodAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_goodAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255B RID: 9563
		// (get) Token: 0x06006D70 RID: 28016 RVA: 0x0020BF00 File Offset: 0x0020A100
		// (set) Token: 0x06006D71 RID: 28017 RVA: 0x0003B123 File Offset: 0x00039323
		public unsafe Animator missAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_missAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_missAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255C RID: 9564
		// (get) Token: 0x06006D72 RID: 28018 RVA: 0x0020BF30 File Offset: 0x0020A130
		// (set) Token: 0x06006D73 RID: 28019 RVA: 0x0003B142 File Offset: 0x00039342
		public unsafe Animator comboAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_comboAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_comboAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255D RID: 9565
		// (get) Token: 0x06006D74 RID: 28020 RVA: 0x0020BF60 File Offset: 0x0020A160
		// (set) Token: 0x06006D75 RID: 28021 RVA: 0x0003B161 File Offset: 0x00039361
		public unsafe Animator scoreAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_scoreAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_scoreAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255E RID: 9566
		// (get) Token: 0x06006D76 RID: 28022 RVA: 0x0020BF90 File Offset: 0x0020A190
		// (set) Token: 0x06006D77 RID: 28023 RVA: 0x0003B180 File Offset: 0x00039380
		public unsafe AdpUISystemUtils.UnityEvent_String OnComboUpdateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_OnComboUpdateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpUISystemUtils.UnityEvent_String>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_OnComboUpdateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700255F RID: 9567
		// (get) Token: 0x06006D78 RID: 28024 RVA: 0x0020BFC0 File Offset: 0x0020A1C0
		// (set) Token: 0x06006D79 RID: 28025 RVA: 0x0003B19F File Offset: 0x0003939F
		public unsafe AdpUISystemUtils.UnityEvent_String OnPerfectNumberUpdateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_OnPerfectNumberUpdateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpUISystemUtils.UnityEvent_String>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_OnPerfectNumberUpdateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002560 RID: 9568
		// (get) Token: 0x06006D7A RID: 28026 RVA: 0x0020BFF0 File Offset: 0x0020A1F0
		// (set) Token: 0x06006D7B RID: 28027 RVA: 0x0003B1BE File Offset: 0x000393BE
		public unsafe AdpUISystemUtils.UnityEvent_String OnGoodNumberUpdateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_OnGoodNumberUpdateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpUISystemUtils.UnityEvent_String>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_OnGoodNumberUpdateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002561 RID: 9569
		// (get) Token: 0x06006D7C RID: 28028 RVA: 0x0020C020 File Offset: 0x0020A220
		// (set) Token: 0x06006D7D RID: 28029 RVA: 0x0003B1DD File Offset: 0x000393DD
		public unsafe AdpUISystemUtils.UnityEvent_String OnMissNumberUpdateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_OnMissNumberUpdateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpUISystemUtils.UnityEvent_String>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_OnMissNumberUpdateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002562 RID: 9570
		// (get) Token: 0x06006D7E RID: 28030 RVA: 0x0020C050 File Offset: 0x0020A250
		// (set) Token: 0x06006D7F RID: 28031 RVA: 0x0003B1FC File Offset: 0x000393FC
		public unsafe HashSet<NoteHeadFinishAnimationController> m_ActiveAnimations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_ActiveAnimations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<NoteHeadFinishAnimationController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_ActiveAnimations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002563 RID: 9571
		// (get) Token: 0x06006D80 RID: 28032 RVA: 0x0020C080 File Offset: 0x0020A280
		// (set) Token: 0x06006D81 RID: 28033 RVA: 0x0003B21B File Offset: 0x0003941B
		public unsafe List<IzakayaMusic.SingleNote.NotePosition> m_CurrentInputCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_CurrentInputCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IzakayaMusic.SingleNote.NotePosition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_CurrentInputCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002564 RID: 9572
		// (get) Token: 0x06006D82 RID: 28034 RVA: 0x0020C0B0 File Offset: 0x0020A2B0
		// (set) Token: 0x06006D83 RID: 28035 RVA: 0x0003B23A File Offset: 0x0003943A
		public unsafe Dictionary<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>> m_FocusingNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_FocusingNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_FocusingNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002565 RID: 9573
		// (get) Token: 0x06006D84 RID: 28036 RVA: 0x0020C0E0 File Offset: 0x0020A2E0
		// (set) Token: 0x06006D85 RID: 28037 RVA: 0x0003B259 File Offset: 0x00039459
		public unsafe Dictionary<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>> m_UpdatingNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_UpdatingNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_UpdatingNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x06006D86 RID: 28038 RVA: 0x0020C110 File Offset: 0x0020A310
		// (set) Token: 0x06006D87 RID: 28039 RVA: 0x0003B278 File Offset: 0x00039478
		public unsafe float m_ComboScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_ComboScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_ComboScore)) = value;
			}
		}

		// Token: 0x17002567 RID: 9575
		// (get) Token: 0x06006D88 RID: 28040 RVA: 0x0020C138 File Offset: 0x0020A338
		// (set) Token: 0x06006D89 RID: 28041 RVA: 0x0003B293 File Offset: 0x00039493
		public unsafe float m_FinalScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_FinalScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_FinalScore)) = value;
			}
		}

		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x06006D8A RID: 28042 RVA: 0x0020C160 File Offset: 0x0020A360
		// (set) Token: 0x06006D8B RID: 28043 RVA: 0x0003B2AE File Offset: 0x000394AE
		public unsafe ObjectPool<NoteHeadBase> m_HoldNoteEndPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_HoldNoteEndPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<NoteHeadBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_HoldNoteEndPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x06006D8C RID: 28044 RVA: 0x0020C190 File Offset: 0x0020A390
		// (set) Token: 0x06006D8D RID: 28045 RVA: 0x0003B2CD File Offset: 0x000394CD
		public unsafe ObjectPool<NoteHeadBase> m_HoldNoteStartPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_HoldNoteStartPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<NoteHeadBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_HoldNoteStartPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x06006D8E RID: 28046 RVA: 0x0020C1C0 File Offset: 0x0020A3C0
		// (set) Token: 0x06006D8F RID: 28047 RVA: 0x0003B2EC File Offset: 0x000394EC
		public unsafe int m_LastMidiNoteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_LastMidiNoteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_LastMidiNoteCount)) = value;
			}
		}

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x06006D90 RID: 28048 RVA: 0x0020C1E8 File Offset: 0x0020A3E8
		// (set) Token: 0x06006D91 RID: 28049 RVA: 0x0003B307 File Offset: 0x00039507
		public unsafe ObjectPool<NoteHeadFinishAnimationController> m_NoteFailedAnimationPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_NoteFailedAnimationPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<NoteHeadFinishAnimationController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_NoteFailedAnimationPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x06006D92 RID: 28050 RVA: 0x0020C218 File Offset: 0x0020A418
		// (set) Token: 0x06006D93 RID: 28051 RVA: 0x0003B326 File Offset: 0x00039526
		public unsafe ObjectPool<NoteHeadFinishAnimationController> m_NoteSucceedAnimationPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_NoteSucceedAnimationPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<NoteHeadFinishAnimationController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_NoteSucceedAnimationPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x06006D94 RID: 28052 RVA: 0x0020C248 File Offset: 0x0020A448
		// (set) Token: 0x06006D95 RID: 28053 RVA: 0x0003B345 File Offset: 0x00039545
		public unsafe float m_PerNoteScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_PerNoteScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_PerNoteScore)) = value;
			}
		}

		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x06006D96 RID: 28054 RVA: 0x0020C270 File Offset: 0x0020A470
		// (set) Token: 0x06006D97 RID: 28055 RVA: 0x0003B360 File Offset: 0x00039560
		public unsafe ObjectPool<NoteHeadBase> m_SingleClickNotePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_SingleClickNotePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<NoteHeadBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_SingleClickNotePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x06006D98 RID: 28056 RVA: 0x0020C2A0 File Offset: 0x0020A4A0
		// (set) Token: 0x06006D99 RID: 28057 RVA: 0x0003B37F File Offset: 0x0003957F
		public unsafe ObjectPool<NoteHeadBase> m_SingleHoldNotePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_SingleHoldNotePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<NoteHeadBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_SingleHoldNotePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x06006D9A RID: 28058 RVA: 0x0020C2D0 File Offset: 0x0020A4D0
		// (set) Token: 0x06006D9B RID: 28059 RVA: 0x0003B39E File Offset: 0x0003959E
		public unsafe int m_TotalMidiNoteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_TotalMidiNoteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_TotalMidiNoteCount)) = value;
			}
		}

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x06006D9C RID: 28060 RVA: 0x0020C2F8 File Offset: 0x0020A4F8
		// (set) Token: 0x06006D9D RID: 28061 RVA: 0x0003B3B9 File Offset: 0x000395B9
		public unsafe int m_WorkSceneMidiNoteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_WorkSceneMidiNoteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_WorkSceneMidiNoteCount)) = value;
			}
		}

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x06006D9E RID: 28062 RVA: 0x0020C320 File Offset: 0x0020A520
		// (set) Token: 0x06006D9F RID: 28063 RVA: 0x0003B3D4 File Offset: 0x000395D4
		public unsafe int m_WorkSceneSucceededMidiNoteCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_WorkSceneSucceededMidiNoteCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr_m_WorkSceneSucceededMidiNoteCount)) = value;
			}
		}

		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x06006DA0 RID: 28064 RVA: 0x0020C348 File Offset: 0x0020A548
		// (set) Token: 0x06006DA1 RID: 28065 RVA: 0x0003B3EF File Offset: 0x000395EF
		public Nullable<QTEPannel.PannelOpenContext> _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new Nullable<QTEPannel.PannelOpenContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<QTEPannel.PannelOpenContext>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<QTEPannel.PannelOpenContext>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17002574 RID: 9588
		// (get) Token: 0x06006DA2 RID: 28066 RVA: 0x0020C378 File Offset: 0x0020A578
		// (set) Token: 0x06006DA3 RID: 28067 RVA: 0x0003B41D File Offset: 0x0003961D
		public unsafe long _NoteStartUpdateOffsetMiliseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__NoteStartUpdateOffsetMiliseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__NoteStartUpdateOffsetMiliseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x06006DA4 RID: 28068 RVA: 0x0020C3A0 File Offset: 0x0020A5A0
		// (set) Token: 0x06006DA5 RID: 28069 RVA: 0x0003B438 File Offset: 0x00039638
		public unsafe Matrix4x4 _WorldToLocalMatrix_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__WorldToLocalMatrix_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__WorldToLocalMatrix_k__BackingField)) = value;
			}
		}

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x06006DA6 RID: 28070 RVA: 0x0020C3C8 File Offset: 0x0020A5C8
		// (set) Token: 0x06006DA7 RID: 28071 RVA: 0x0003B453 File Offset: 0x00039653
		public unsafe int _CurrentComboValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__CurrentComboValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__CurrentComboValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x06006DA8 RID: 28072 RVA: 0x0020C3F0 File Offset: 0x0020A5F0
		// (set) Token: 0x06006DA9 RID: 28073 RVA: 0x0003B46E File Offset: 0x0003966E
		public unsafe int _CurrentPerfectValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__CurrentPerfectValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__CurrentPerfectValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x06006DAA RID: 28074 RVA: 0x0020C418 File Offset: 0x0020A618
		// (set) Token: 0x06006DAB RID: 28075 RVA: 0x0003B489 File Offset: 0x00039689
		public unsafe int _CurrentGoodValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__CurrentGoodValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__CurrentGoodValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17002579 RID: 9593
		// (get) Token: 0x06006DAC RID: 28076 RVA: 0x0020C440 File Offset: 0x0020A640
		// (set) Token: 0x06006DAD RID: 28077 RVA: 0x0003B4A4 File Offset: 0x000396A4
		public unsafe int _CurrentMissValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__CurrentMissValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__CurrentMissValue_k__BackingField)) = value;
			}
		}

		// Token: 0x1700257A RID: 9594
		// (get) Token: 0x06006DAE RID: 28078 RVA: 0x0020C468 File Offset: 0x0020A668
		// (set) Token: 0x06006DAF RID: 28079 RVA: 0x0003B4BF File Offset: 0x000396BF
		public unsafe Queue<NoteHeadBase> _queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<NoteHeadBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.NativeFieldInfoPtr__queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004835 RID: 18485
		private static readonly IntPtr NativeFieldInfoPtr_FULL_SCORE_VALUE;

		// Token: 0x04004836 RID: 18486
		private static readonly IntPtr NativeFieldInfoPtr_COMBO_DEDUCT_VALUE;

		// Token: 0x04004837 RID: 18487
		private static readonly IntPtr NativeFieldInfoPtr_PRELOAD_COUNT;

		// Token: 0x04004838 RID: 18488
		private static readonly IntPtr NativeFieldInfoPtr_Shine;

		// Token: 0x04004839 RID: 18489
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteStartUpdateOffset;

		// Token: 0x0400483A RID: 18490
		private static readonly IntPtr NativeFieldInfoPtr_m_MidiNotePreGoodLength;

		// Token: 0x0400483B RID: 18491
		private static readonly IntPtr NativeFieldInfoPtr_m_MidiNotePrePerfectLength;

		// Token: 0x0400483C RID: 18492
		private static readonly IntPtr NativeFieldInfoPtr_m_MidiNotePostPerfectLength;

		// Token: 0x0400483D RID: 18493
		private static readonly IntPtr NativeFieldInfoPtr_m_CloseOffset;

		// Token: 0x0400483E RID: 18494
		private static readonly IntPtr NativeFieldInfoPtr_m_SingleClickNoteParent;

		// Token: 0x0400483F RID: 18495
		private static readonly IntPtr NativeFieldInfoPtr_m_SingleHoldNoteParent;

		// Token: 0x04004840 RID: 18496
		private static readonly IntPtr NativeFieldInfoPtr_m_HoldNoteStartParent;

		// Token: 0x04004841 RID: 18497
		private static readonly IntPtr NativeFieldInfoPtr_m_HoldNoteEndParent;

		// Token: 0x04004842 RID: 18498
		private static readonly IntPtr NativeFieldInfoPtr_m_ScoreText;

		// Token: 0x04004843 RID: 18499
		private static readonly IntPtr NativeFieldInfoPtr_m_ScoreText2;

		// Token: 0x04004844 RID: 18500
		private static readonly IntPtr NativeFieldInfoPtr_m_ProgressText;

		// Token: 0x04004845 RID: 18501
		private static readonly IntPtr NativeFieldInfoPtr_m_ProgressBar;

		// Token: 0x04004846 RID: 18502
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteSucceedAnimation;

		// Token: 0x04004847 RID: 18503
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteFailedAnimation;

		// Token: 0x04004848 RID: 18504
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteAnimationField;

		// Token: 0x04004849 RID: 18505
		private static readonly IntPtr NativeFieldInfoPtr_m_PerfectSingleSFX;

		// Token: 0x0400484A RID: 18506
		private static readonly IntPtr NativeFieldInfoPtr_m_GoodSingleSFX;

		// Token: 0x0400484B RID: 18507
		private static readonly IntPtr NativeFieldInfoPtr_m_MissSingleSFX;

		// Token: 0x0400484C RID: 18508
		private static readonly IntPtr NativeFieldInfoPtr_m_PerfectLeftSFX;

		// Token: 0x0400484D RID: 18509
		private static readonly IntPtr NativeFieldInfoPtr_m_GoodLeftSFX;

		// Token: 0x0400484E RID: 18510
		private static readonly IntPtr NativeFieldInfoPtr_m_PerfectRightSFX;

		// Token: 0x0400484F RID: 18511
		private static readonly IntPtr NativeFieldInfoPtr_m_GoodRightSFX;

		// Token: 0x04004850 RID: 18512
		private static readonly IntPtr NativeFieldInfoPtr_perfectAnimator;

		// Token: 0x04004851 RID: 18513
		private static readonly IntPtr NativeFieldInfoPtr_goodAnimator;

		// Token: 0x04004852 RID: 18514
		private static readonly IntPtr NativeFieldInfoPtr_missAnimator;

		// Token: 0x04004853 RID: 18515
		private static readonly IntPtr NativeFieldInfoPtr_comboAnimator;

		// Token: 0x04004854 RID: 18516
		private static readonly IntPtr NativeFieldInfoPtr_scoreAnimator;

		// Token: 0x04004855 RID: 18517
		private static readonly IntPtr NativeFieldInfoPtr_OnComboUpdateCallback;

		// Token: 0x04004856 RID: 18518
		private static readonly IntPtr NativeFieldInfoPtr_OnPerfectNumberUpdateCallback;

		// Token: 0x04004857 RID: 18519
		private static readonly IntPtr NativeFieldInfoPtr_OnGoodNumberUpdateCallback;

		// Token: 0x04004858 RID: 18520
		private static readonly IntPtr NativeFieldInfoPtr_OnMissNumberUpdateCallback;

		// Token: 0x04004859 RID: 18521
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveAnimations;

		// Token: 0x0400485A RID: 18522
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentInputCollection;

		// Token: 0x0400485B RID: 18523
		private static readonly IntPtr NativeFieldInfoPtr_m_FocusingNotes;

		// Token: 0x0400485C RID: 18524
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdatingNotes;

		// Token: 0x0400485D RID: 18525
		private static readonly IntPtr NativeFieldInfoPtr_m_ComboScore;

		// Token: 0x0400485E RID: 18526
		private static readonly IntPtr NativeFieldInfoPtr_m_FinalScore;

		// Token: 0x0400485F RID: 18527
		private static readonly IntPtr NativeFieldInfoPtr_m_HoldNoteEndPool;

		// Token: 0x04004860 RID: 18528
		private static readonly IntPtr NativeFieldInfoPtr_m_HoldNoteStartPool;

		// Token: 0x04004861 RID: 18529
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMidiNoteCount;

		// Token: 0x04004862 RID: 18530
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteFailedAnimationPool;

		// Token: 0x04004863 RID: 18531
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteSucceedAnimationPool;

		// Token: 0x04004864 RID: 18532
		private static readonly IntPtr NativeFieldInfoPtr_m_PerNoteScore;

		// Token: 0x04004865 RID: 18533
		private static readonly IntPtr NativeFieldInfoPtr_m_SingleClickNotePool;

		// Token: 0x04004866 RID: 18534
		private static readonly IntPtr NativeFieldInfoPtr_m_SingleHoldNotePool;

		// Token: 0x04004867 RID: 18535
		private static readonly IntPtr NativeFieldInfoPtr_m_TotalMidiNoteCount;

		// Token: 0x04004868 RID: 18536
		private static readonly IntPtr NativeFieldInfoPtr_m_WorkSceneMidiNoteCount;

		// Token: 0x04004869 RID: 18537
		private static readonly IntPtr NativeFieldInfoPtr_m_WorkSceneSucceededMidiNoteCount;

		// Token: 0x0400486A RID: 18538
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x0400486B RID: 18539
		private static readonly IntPtr NativeFieldInfoPtr__NoteStartUpdateOffsetMiliseconds_k__BackingField;

		// Token: 0x0400486C RID: 18540
		private static readonly IntPtr NativeFieldInfoPtr__WorldToLocalMatrix_k__BackingField;

		// Token: 0x0400486D RID: 18541
		private static readonly IntPtr NativeFieldInfoPtr__CurrentComboValue_k__BackingField;

		// Token: 0x0400486E RID: 18542
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPerfectValue_k__BackingField;

		// Token: 0x0400486F RID: 18543
		private static readonly IntPtr NativeFieldInfoPtr__CurrentGoodValue_k__BackingField;

		// Token: 0x04004870 RID: 18544
		private static readonly IntPtr NativeFieldInfoPtr__CurrentMissValue_k__BackingField;

		// Token: 0x04004871 RID: 18545
		private static readonly IntPtr NativeFieldInfoPtr__queue;

		// Token: 0x04004872 RID: 18546
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Protected_get_Nullable_1_PannelOpenContext_0;

		// Token: 0x04004873 RID: 18547
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0;

		// Token: 0x04004874 RID: 18548
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDemoMode_Public_get_Boolean_0;

		// Token: 0x04004875 RID: 18549
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTime_Protected_get_Int64_0;

		// Token: 0x04004876 RID: 18550
		private static readonly IntPtr NativeMethodInfoPtr_get_WorkMode_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04004877 RID: 18551
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveNoteField_Protected_Abstract_Virtual_New_get_RectTransform_0;

		// Token: 0x04004878 RID: 18552
		private static readonly IntPtr NativeMethodInfoPtr_get_NoteStartUpdateOffsetMiliseconds_Protected_get_Int64_0;

		// Token: 0x04004879 RID: 18553
		private static readonly IntPtr NativeMethodInfoPtr_set_NoteStartUpdateOffsetMiliseconds_Private_set_Void_Int64_0;

		// Token: 0x0400487A RID: 18554
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x0400487B RID: 18555
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldToLocalMatrix_Private_set_Void_Matrix4x4_0;

		// Token: 0x0400487C RID: 18556
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldToLocalMatrix_Public_get_Matrix4x4_0;

		// Token: 0x0400487D RID: 18557
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentComboValue_Public_get_Int32_0;

		// Token: 0x0400487E RID: 18558
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentComboValue_Private_set_Void_Int32_0;

		// Token: 0x0400487F RID: 18559
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPerfectValue_Public_get_Int32_0;

		// Token: 0x04004880 RID: 18560
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPerfectValue_Private_set_Void_Int32_0;

		// Token: 0x04004881 RID: 18561
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGoodValue_Public_get_Int32_0;

		// Token: 0x04004882 RID: 18562
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentGoodValue_Private_set_Void_Int32_0;

		// Token: 0x04004883 RID: 18563
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentMissValue_Public_get_Int32_0;

		// Token: 0x04004884 RID: 18564
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentMissValue_Private_set_Void_Int32_0;

		// Token: 0x04004885 RID: 18565
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentCombo_Private_set_Void_Int32_0;

		// Token: 0x04004886 RID: 18566
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCombo_Private_get_Int32_0;

		// Token: 0x04004887 RID: 18567
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPerfect_Private_set_Void_Int32_0;

		// Token: 0x04004888 RID: 18568
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPerfect_Private_get_Int32_0;

		// Token: 0x04004889 RID: 18569
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentGood_Private_set_Void_Int32_0;

		// Token: 0x0400488A RID: 18570
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGood_Private_get_Int32_0;

		// Token: 0x0400488B RID: 18571
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentMiss_Private_set_Void_Int32_0;

		// Token: 0x0400488C RID: 18572
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentMiss_Private_get_Int32_0;

		// Token: 0x0400488D RID: 18573
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentInput_Public_get_NotePosition_0;

		// Token: 0x0400488E RID: 18574
		private static readonly IntPtr NativeMethodInfoPtr_get_FinalScore_Public_get_Single_0;

		// Token: 0x0400488F RID: 18575
		private static readonly IntPtr NativeMethodInfoPtr_set_FinalScore_Protected_set_Void_Single_0;

		// Token: 0x04004890 RID: 18576
		private static readonly IntPtr NativeMethodInfoPtr_AnimatorPlay_Public_Void_Animator_0;

		// Token: 0x04004891 RID: 18577
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04004892 RID: 18578
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x04004893 RID: 18579
		private static readonly IntPtr NativeMethodInfoPtr_InverseLerp_Protected_Static_Double_Int64_Int64_Int64_0;

		// Token: 0x04004894 RID: 18580
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Protected_Static_Single_Double_Double_Double_0;

		// Token: 0x04004895 RID: 18581
		private static readonly IntPtr NativeMethodInfoPtr_Clamp01_Private_Static_Double_Double_0;

		// Token: 0x04004896 RID: 18582
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004897 RID: 18583
		private static readonly IntPtr NativeMethodInfoPtr_TryPlayNoteL_Private_Void_CallbackContext_0;

		// Token: 0x04004898 RID: 18584
		private static readonly IntPtr NativeMethodInfoPtr_TryReleaseNoteL_Private_Void_CallbackContext_0;

		// Token: 0x04004899 RID: 18585
		private static readonly IntPtr NativeMethodInfoPtr_TryPlayNoteR_Private_Void_CallbackContext_0;

		// Token: 0x0400489A RID: 18586
		private static readonly IntPtr NativeMethodInfoPtr_TryReleaseNoteR_Private_Void_CallbackContext_0;

		// Token: 0x0400489B RID: 18587
		private static readonly IntPtr NativeMethodInfoPtr_TryClickCurrentNote_Private_Void_NotePosition_0;

		// Token: 0x0400489C RID: 18588
		private static readonly IntPtr NativeMethodInfoPtr_TryReleaseCurrentNote_Private_Void_NotePosition_0;

		// Token: 0x0400489D RID: 18589
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400489E RID: 18590
		private static readonly IntPtr NativeMethodInfoPtr_CalculateScore_Public_Static_ValueTuple_2_Single_Single_Int32_0;

		// Token: 0x0400489F RID: 18591
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScore_Public_Static_Void_NoteStatus_Single_Single_byref_Int32_byref_Int32_byref_Single_0;

		// Token: 0x040048A0 RID: 18592
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040048A1 RID: 18593
		private static readonly IntPtr NativeMethodInfoPtr_PlayCorrectAudio_Public_Void_Boolean_NotePosition_0;

		// Token: 0x040048A2 RID: 18594
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseNote_Public_Void_NoteHeadBase_0;

		// Token: 0x040048A3 RID: 18595
		private static readonly IntPtr NativeMethodInfoPtr_GetNoteCount_Protected_Abstract_Virtual_New_Int32_0;

		// Token: 0x040048A4 RID: 18596
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProgress_Private_Void_0;

		// Token: 0x040048A5 RID: 18597
		private static readonly IntPtr NativeMethodInfoPtr_PlayNoteSucceedAnimation_Protected_Void_NoteHeadBase_0;

		// Token: 0x040048A6 RID: 18598
		private static readonly IntPtr NativeMethodInfoPtr_PlayNoteFailedAnimation_Protected_Void_NoteHeadBase_0;

		// Token: 0x040048A7 RID: 18599
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAndReleaseNote_Public_Void_NoteHeadBase_0;

		// Token: 0x040048A8 RID: 18600
		private static readonly IntPtr NativeMethodInfoPtr_OnNoteEvaluated_Protected_Virtual_New_Void_NoteHeadBase_0;

		// Token: 0x040048A9 RID: 18601
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusingNote_Protected_Void_Int64_0;

		// Token: 0x040048AA RID: 18602
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFocusingNote_Protected_Void_Int64_0;

		// Token: 0x040048AB RID: 18603
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040048AC RID: 18604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040048AD RID: 18605
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_T_T_PDM_0;

		// Token: 0x040048AE RID: 18606
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_T_PDM_0;

		// Token: 0x040048AF RID: 18607
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_NoteHeadFinishAnimationController_PDM_0;

		// Token: 0x040048B0 RID: 18608
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_NoteHeadFinishAnimationController_PDM_1;

		// Token: 0x040048B1 RID: 18609
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_0;

		// Token: 0x040048B2 RID: 18610
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_1;

		// Token: 0x040048B3 RID: 18611
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_T_T_PDM_1;

		// Token: 0x040048B4 RID: 18612
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_NoteHeadBase_PDM_0;

		// Token: 0x040048B5 RID: 18613
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_NoteHeadBase_PDM_1;

		// Token: 0x040048B6 RID: 18614
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_NoteHeadBase_PDM_2;

		// Token: 0x040048B7 RID: 18615
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_NoteHeadBase_PDM_3;

		// Token: 0x040048B8 RID: 18616
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_NoteHeadBase_PDM_0;

		// Token: 0x040048B9 RID: 18617
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadBase_PDM_0;

		// Token: 0x040048BA RID: 18618
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_ObjectPool_1_T_0;

		// Token: 0x040048BB RID: 18619
		private static readonly IntPtr NativeMethodInfoPtr__UpdateProgress_b__128_0_Private_Void_Single_0;

		// Token: 0x040048BC RID: 18620
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_NotePosition_byref___c__DisplayClass133_0_0;

		// Token: 0x040048BD RID: 18621
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_NoteHeadBase_byref___c__DisplayClass135_0_PDM_0;

		// Token: 0x02000EBD RID: 3773
		[ObfuscatedName("Common.UI.QTEUtility.QTEPannelBase+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010A63 RID: 68195 RVA: 0x003DABA8 File Offset: 0x003D8DA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr);
				QTEPannelBase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, "<>9");
				QTEPannelBase.__c.NativeFieldInfoPtr___9__119_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, "<>9__119_0");
				QTEPannelBase.__c.NativeFieldInfoPtr___9__119_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, "<>9__119_1");
				QTEPannelBase.__c.NativeFieldInfoPtr___9__120_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, "<>9__120_0");
				QTEPannelBase.__c.NativeFieldInfoPtr___9__120_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, "<>9__120_1");
				QTEPannelBase.__c.NativeFieldInfoPtr___9__121_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, "<>9__121_0");
				QTEPannelBase.__c.NativeFieldInfoPtr___9__124_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, "<>9__124_4");
				QTEPannelBase.__c.NativeFieldInfoPtr___9__124_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, "<>9__124_0");
				QTEPannelBase.__c.NativeFieldInfoPtr___9__124_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, "<>9__124_5");
				QTEPannelBase.__c.NativeFieldInfoPtr___9__124_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, "<>9__124_1");
				QTEPannelBase.__c.NativeFieldInfoPtr___9__124_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, "<>9__124_2");
				QTEPannelBase.__c.NativeFieldInfoPtr___9__124_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, "<>9__124_3");
				QTEPannelBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, 100685788);
				QTEPannelBase.__c.NativeMethodInfoPtr__TryClickCurrentNote_b__119_0_Internal_Void_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, 100685789);
				QTEPannelBase.__c.NativeMethodInfoPtr__TryClickCurrentNote_b__119_1_Internal_Void_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, 100685790);
				QTEPannelBase.__c.NativeMethodInfoPtr__TryReleaseCurrentNote_b__120_0_Internal_Void_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, 100685791);
				QTEPannelBase.__c.NativeMethodInfoPtr__TryReleaseCurrentNote_b__120_1_Internal_Void_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, 100685792);
				QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelOpen_b__121_0_Internal_Int32_SingleNote_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, 100685793);
				QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelClose_b__124_0_Internal_Void_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, 100685794);
				QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelClose_b__124_4_Internal_Void_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, 100685795);
				QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelClose_b__124_1_Internal_Void_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, 100685796);
				QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelClose_b__124_5_Internal_Void_NoteHeadBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, 100685797);
				QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelClose_b__124_2_Internal_Void_NoteHeadFinishAnimationController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, 100685798);
				QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelClose_b__124_3_Internal_Void_NoteHeadFinishAnimationController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr, 100685799);
			}

			// Token: 0x06010A64 RID: 68196 RVA: 0x003DADB4 File Offset: 0x003D8FB4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QTEPannelBase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A65 RID: 68197 RVA: 0x003DADF0 File Offset: 0x003D8FF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274392, XrefRangeEnd = 274394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryClickCurrentNote_b__119_0(NoteHeadBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.__c.NativeMethodInfoPtr__TryClickCurrentNote_b__119_0_Internal_Void_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A66 RID: 68198 RVA: 0x003DAE34 File Offset: 0x003D9034
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryClickCurrentNote_b__119_1(NoteHeadBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.__c.NativeMethodInfoPtr__TryClickCurrentNote_b__119_1_Internal_Void_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A67 RID: 68199 RVA: 0x003DAE78 File Offset: 0x003D9078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274394, XrefRangeEnd = 274396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryReleaseCurrentNote_b__120_0(NoteHeadBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.__c.NativeMethodInfoPtr__TryReleaseCurrentNote_b__120_0_Internal_Void_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A68 RID: 68200 RVA: 0x003DAEBC File Offset: 0x003D90BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryReleaseCurrentNote_b__120_1(NoteHeadBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.__c.NativeMethodInfoPtr__TryReleaseCurrentNote_b__120_1_Internal_Void_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A69 RID: 68201 RVA: 0x003DAF00 File Offset: 0x003D9100
			[CallerCount(0)]
			public unsafe int _OnPanelOpen_b__121_0(IzakayaMusic.SingleNote x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelOpen_b__121_0_Internal_Int32_SingleNote_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010A6A RID: 68202 RVA: 0x003DAF4C File Offset: 0x003D914C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274396, XrefRangeEnd = 274419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelClose_b__124_0(KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelClose_b__124_0_Internal_Void_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A6B RID: 68203 RVA: 0x003DAF94 File Offset: 0x003D9194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274419, XrefRangeEnd = 274421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelClose_b__124_4(NoteHeadBase y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelClose_b__124_4_Internal_Void_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A6C RID: 68204 RVA: 0x003DAFD8 File Offset: 0x003D91D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274421, XrefRangeEnd = 274442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelClose_b__124_1(KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelClose_b__124_1_Internal_Void_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A6D RID: 68205 RVA: 0x003DB020 File Offset: 0x003D9220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelClose_b__124_5(NoteHeadBase y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelClose_b__124_5_Internal_Void_NoteHeadBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A6E RID: 68206 RVA: 0x003DB064 File Offset: 0x003D9264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274442, XrefRangeEnd = 274444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelClose_b__124_2(NoteHeadFinishAnimationController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelClose_b__124_2_Internal_Void_NoteHeadFinishAnimationController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A6F RID: 68207 RVA: 0x003DB0A8 File Offset: 0x003D92A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelClose_b__124_3(NoteHeadFinishAnimationController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QTEPannelBase.__c.NativeMethodInfoPtr__OnPanelClose_b__124_3_Internal_Void_NoteHeadFinishAnimationController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010A70 RID: 68208 RVA: 0x00091480 File Offset: 0x0008F680
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170056D5 RID: 22229
			// (get) Token: 0x06010A71 RID: 68209 RVA: 0x003DB0EC File Offset: 0x003D92EC
			// (set) Token: 0x06010A72 RID: 68210 RVA: 0x00091489 File Offset: 0x0008F689
			public unsafe static QTEPannelBase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEPannelBase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056D6 RID: 22230
			// (get) Token: 0x06010A73 RID: 68211 RVA: 0x003DB114 File Offset: 0x003D9314
			// (set) Token: 0x06010A74 RID: 68212 RVA: 0x0009149B File Offset: 0x0008F69B
			public unsafe static Action<NoteHeadBase> __9__119_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__119_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NoteHeadBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__119_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056D7 RID: 22231
			// (get) Token: 0x06010A75 RID: 68213 RVA: 0x003DB13C File Offset: 0x003D933C
			// (set) Token: 0x06010A76 RID: 68214 RVA: 0x000914AD File Offset: 0x0008F6AD
			public unsafe static Action<NoteHeadBase> __9__119_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__119_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NoteHeadBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__119_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056D8 RID: 22232
			// (get) Token: 0x06010A77 RID: 68215 RVA: 0x003DB164 File Offset: 0x003D9364
			// (set) Token: 0x06010A78 RID: 68216 RVA: 0x000914BF File Offset: 0x0008F6BF
			public unsafe static Action<NoteHeadBase> __9__120_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__120_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NoteHeadBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__120_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056D9 RID: 22233
			// (get) Token: 0x06010A79 RID: 68217 RVA: 0x003DB18C File Offset: 0x003D938C
			// (set) Token: 0x06010A7A RID: 68218 RVA: 0x000914D1 File Offset: 0x0008F6D1
			public unsafe static Action<NoteHeadBase> __9__120_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__120_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NoteHeadBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__120_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056DA RID: 22234
			// (get) Token: 0x06010A7B RID: 68219 RVA: 0x003DB1B4 File Offset: 0x003D93B4
			// (set) Token: 0x06010A7C RID: 68220 RVA: 0x000914E3 File Offset: 0x0008F6E3
			public unsafe static Func<IzakayaMusic.SingleNote, int> __9__121_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__121_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IzakayaMusic.SingleNote, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__121_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056DB RID: 22235
			// (get) Token: 0x06010A7D RID: 68221 RVA: 0x003DB1DC File Offset: 0x003D93DC
			// (set) Token: 0x06010A7E RID: 68222 RVA: 0x000914F5 File Offset: 0x0008F6F5
			public unsafe static Action<NoteHeadBase> __9__124_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__124_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NoteHeadBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__124_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056DC RID: 22236
			// (get) Token: 0x06010A7F RID: 68223 RVA: 0x003DB204 File Offset: 0x003D9404
			// (set) Token: 0x06010A80 RID: 68224 RVA: 0x00091507 File Offset: 0x0008F707
			public unsafe static Action<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>>> __9__124_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__124_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__124_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056DD RID: 22237
			// (get) Token: 0x06010A81 RID: 68225 RVA: 0x003DB22C File Offset: 0x003D942C
			// (set) Token: 0x06010A82 RID: 68226 RVA: 0x00091519 File Offset: 0x0008F719
			public unsafe static Action<NoteHeadBase> __9__124_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__124_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NoteHeadBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__124_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056DE RID: 22238
			// (get) Token: 0x06010A83 RID: 68227 RVA: 0x003DB254 File Offset: 0x003D9454
			// (set) Token: 0x06010A84 RID: 68228 RVA: 0x0009152B File Offset: 0x0008F72B
			public unsafe static Action<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>>> __9__124_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__124_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__124_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056DF RID: 22239
			// (get) Token: 0x06010A85 RID: 68229 RVA: 0x003DB27C File Offset: 0x003D947C
			// (set) Token: 0x06010A86 RID: 68230 RVA: 0x0009153D File Offset: 0x0008F73D
			public unsafe static Action<NoteHeadFinishAnimationController> __9__124_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__124_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NoteHeadFinishAnimationController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__124_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056E0 RID: 22240
			// (get) Token: 0x06010A87 RID: 68231 RVA: 0x003DB2A4 File Offset: 0x003D94A4
			// (set) Token: 0x06010A88 RID: 68232 RVA: 0x0009154F File Offset: 0x0008F74F
			public unsafe static Action<NoteHeadFinishAnimationController> __9__124_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__124_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NoteHeadFinishAnimationController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QTEPannelBase.__c.NativeFieldInfoPtr___9__124_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A874 RID: 43124
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A875 RID: 43125
			private static readonly IntPtr NativeFieldInfoPtr___9__119_0;

			// Token: 0x0400A876 RID: 43126
			private static readonly IntPtr NativeFieldInfoPtr___9__119_1;

			// Token: 0x0400A877 RID: 43127
			private static readonly IntPtr NativeFieldInfoPtr___9__120_0;

			// Token: 0x0400A878 RID: 43128
			private static readonly IntPtr NativeFieldInfoPtr___9__120_1;

			// Token: 0x0400A879 RID: 43129
			private static readonly IntPtr NativeFieldInfoPtr___9__121_0;

			// Token: 0x0400A87A RID: 43130
			private static readonly IntPtr NativeFieldInfoPtr___9__124_4;

			// Token: 0x0400A87B RID: 43131
			private static readonly IntPtr NativeFieldInfoPtr___9__124_0;

			// Token: 0x0400A87C RID: 43132
			private static readonly IntPtr NativeFieldInfoPtr___9__124_5;

			// Token: 0x0400A87D RID: 43133
			private static readonly IntPtr NativeFieldInfoPtr___9__124_1;

			// Token: 0x0400A87E RID: 43134
			private static readonly IntPtr NativeFieldInfoPtr___9__124_2;

			// Token: 0x0400A87F RID: 43135
			private static readonly IntPtr NativeFieldInfoPtr___9__124_3;

			// Token: 0x0400A880 RID: 43136
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A881 RID: 43137
			private static readonly IntPtr NativeMethodInfoPtr__TryClickCurrentNote_b__119_0_Internal_Void_NoteHeadBase_0;

			// Token: 0x0400A882 RID: 43138
			private static readonly IntPtr NativeMethodInfoPtr__TryClickCurrentNote_b__119_1_Internal_Void_NoteHeadBase_0;

			// Token: 0x0400A883 RID: 43139
			private static readonly IntPtr NativeMethodInfoPtr__TryReleaseCurrentNote_b__120_0_Internal_Void_NoteHeadBase_0;

			// Token: 0x0400A884 RID: 43140
			private static readonly IntPtr NativeMethodInfoPtr__TryReleaseCurrentNote_b__120_1_Internal_Void_NoteHeadBase_0;

			// Token: 0x0400A885 RID: 43141
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__121_0_Internal_Int32_SingleNote_0;

			// Token: 0x0400A886 RID: 43142
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelClose_b__124_0_Internal_Void_KeyValuePair_2_NotePosition_Queue_1_NoteHeadBase_0;

			// Token: 0x0400A887 RID: 43143
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelClose_b__124_4_Internal_Void_NoteHeadBase_0;

			// Token: 0x0400A888 RID: 43144
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelClose_b__124_1_Internal_Void_KeyValuePair_2_NotePosition_List_1_NoteHeadBase_0;

			// Token: 0x0400A889 RID: 43145
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelClose_b__124_5_Internal_Void_NoteHeadBase_0;

			// Token: 0x0400A88A RID: 43146
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelClose_b__124_2_Internal_Void_NoteHeadFinishAnimationController_0;

			// Token: 0x0400A88B RID: 43147
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelClose_b__124_3_Internal_Void_NoteHeadFinishAnimationController_0;
		}

		// Token: 0x02000EBE RID: 3774
		[ObfuscatedName("Common.UI.QTEUtility.QTEPannelBase+<>c__DisplayClass133_0")]
		public sealed class __c__DisplayClass133_0 : ValueType
		{
			// Token: 0x06010A89 RID: 68233 RVA: 0x003DB2CC File Offset: 0x003D94CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass133_0()
			{
				Il2CppClassPointerStore<QTEPannelBase.__c__DisplayClass133_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "<>c__DisplayClass133_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QTEPannelBase.__c__DisplayClass133_0>.NativeClassPtr);
				QTEPannelBase.__c__DisplayClass133_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c__DisplayClass133_0>.NativeClassPtr, "<>4__this");
				QTEPannelBase.__c__DisplayClass133_0.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c__DisplayClass133_0>.NativeClassPtr, "currentTime");
			}

			// Token: 0x06010A8A RID: 68234 RVA: 0x00091561 File Offset: 0x0008F761
			public __c__DisplayClass133_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010A8B RID: 68235 RVA: 0x0009156A File Offset: 0x0008F76A
			public __c__DisplayClass133_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QTEPannelBase.__c__DisplayClass133_0>.NativeClassPtr))
			{
			}

			// Token: 0x170056E1 RID: 22241
			// (get) Token: 0x06010A8C RID: 68236 RVA: 0x003DB320 File Offset: 0x003D9520
			// (set) Token: 0x06010A8D RID: 68237 RVA: 0x0009157C File Offset: 0x0008F77C
			public unsafe QTEPannelBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.__c__DisplayClass133_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEPannelBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.__c__DisplayClass133_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056E2 RID: 22242
			// (get) Token: 0x06010A8E RID: 68238 RVA: 0x003DB350 File Offset: 0x003D9550
			// (set) Token: 0x06010A8F RID: 68239 RVA: 0x0009159B File Offset: 0x0008F79B
			public unsafe long currentTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.__c__DisplayClass133_0.NativeFieldInfoPtr_currentTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.__c__DisplayClass133_0.NativeFieldInfoPtr_currentTime)) = value;
				}
			}

			// Token: 0x0400A88C RID: 43148
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A88D RID: 43149
			private static readonly IntPtr NativeFieldInfoPtr_currentTime;
		}

		// Token: 0x02000EBF RID: 3775
		[ObfuscatedName("Common.UI.QTEUtility.QTEPannelBase+<>c__DisplayClass135_0")]
		public sealed class __c__DisplayClass135_0 : ValueType
		{
			// Token: 0x06010A90 RID: 68240 RVA: 0x003DB378 File Offset: 0x003D9578
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass135_0()
			{
				Il2CppClassPointerStore<QTEPannelBase.__c__DisplayClass135_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr, "<>c__DisplayClass135_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QTEPannelBase.__c__DisplayClass135_0>.NativeClassPtr);
				QTEPannelBase.__c__DisplayClass135_0.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c__DisplayClass135_0>.NativeClassPtr, "currentTime");
				QTEPannelBase.__c__DisplayClass135_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QTEPannelBase.__c__DisplayClass135_0>.NativeClassPtr, "<>4__this");
			}

			// Token: 0x06010A91 RID: 68241 RVA: 0x000915B6 File Offset: 0x0008F7B6
			public __c__DisplayClass135_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010A92 RID: 68242 RVA: 0x000915BF File Offset: 0x0008F7BF
			public __c__DisplayClass135_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QTEPannelBase.__c__DisplayClass135_0>.NativeClassPtr))
			{
			}

			// Token: 0x170056E3 RID: 22243
			// (get) Token: 0x06010A93 RID: 68243 RVA: 0x003DB3CC File Offset: 0x003D95CC
			// (set) Token: 0x06010A94 RID: 68244 RVA: 0x000915D1 File Offset: 0x0008F7D1
			public unsafe long currentTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.__c__DisplayClass135_0.NativeFieldInfoPtr_currentTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.__c__DisplayClass135_0.NativeFieldInfoPtr_currentTime)) = value;
				}
			}

			// Token: 0x170056E4 RID: 22244
			// (get) Token: 0x06010A95 RID: 68245 RVA: 0x003DB3F4 File Offset: 0x003D95F4
			// (set) Token: 0x06010A96 RID: 68246 RVA: 0x000915EC File Offset: 0x0008F7EC
			public unsafe QTEPannelBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.__c__DisplayClass135_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEPannelBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QTEPannelBase.__c__DisplayClass135_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A88E RID: 43150
			private static readonly IntPtr NativeFieldInfoPtr_currentTime;

			// Token: 0x0400A88F RID: 43151
			private static readonly IntPtr NativeFieldInfoPtr___4__this;
		}

		// Token: 0x02000EC0 RID: 3776
		private sealed class MethodInfoStoreGeneric_Method_Private_T_T_PDM_0<T>
		{
			// Token: 0x0400A890 RID: 43152
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(QTEPannelBase.NativeMethodInfoPtr_Method_Private_T_T_PDM_0, Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000EC1 RID: 3777
		private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Void_T_PDM_0<T>
		{
			// Token: 0x0400A891 RID: 43153
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(QTEPannelBase.NativeMethodInfoPtr_Method_Internal_Static_Void_T_PDM_0, Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000EC2 RID: 3778
		private sealed class MethodInfoStoreGeneric_Method_Private_T_T_PDM_1<T>
		{
			// Token: 0x0400A892 RID: 43154
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(QTEPannelBase.NativeMethodInfoPtr_Method_Private_T_T_PDM_1, Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000EC3 RID: 3779
		private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Void_ObjectPool_1_T_0<T>
		{
			// Token: 0x0400A893 RID: 43155
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(QTEPannelBase.NativeMethodInfoPtr_Method_Internal_Static_Void_ObjectPool_1_T_0, Il2CppClassPointerStore<QTEPannelBase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
