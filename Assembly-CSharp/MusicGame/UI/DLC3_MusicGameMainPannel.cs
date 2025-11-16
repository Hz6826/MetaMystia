using System;
using Common.UI.QTEUtility;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using GameData.Core.MusicUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace MusicGame.UI
{
	// Token: 0x02000030 RID: 48
	public class DLC3_MusicGameMainPannel : UISubPanel<DLC3_MusicGameStartPannel>
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x000AD890 File Offset: 0x000ABA90
		// Note: this type is marked as 'beforefieldinit'.
		static DLC3_MusicGameMainPannel()
		{
			Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "DLC3_MusicGameMainPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr);
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_PlayerPortrayal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "PlayerPortrayal");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_MusicGameQTEPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "MusicGameQTEPannel");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_CountDownPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "CountDownPannel");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_PausePannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "PausePannel");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_QTEPannelField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "QTEPannelField");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_PauseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "PauseButton");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_NormalModePortrayalY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "m_NormalModePortrayalY");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_PlayerPortrayalFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "m_PlayerPortrayalFrame");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_mystiaCharacterElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "mystiaCharacterElement");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_dancingCharacterElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "dancingCharacterElement");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_characterAnimtionField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "characterAnimtionField");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "cluster");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_playerRockImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "playerRockImage");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossRockImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "bossRockImage");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_AnimatorSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "AnimatorSucceed");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_AnimatorFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "AnimatorFail");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "offset");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_AnimationField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "AnimationField");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_playerLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "playerLight");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "bossLight");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_frameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "frameTime");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_dancingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "dancingCharacters");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_ActiveAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "m_ActiveAnimations");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_AvailableActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "m_AvailableActions");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossGetCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "bossGetCombo");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossGetScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "bossGetScore");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_comboScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "comboScore");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_currentGetCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "currentGetCombo");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_currentNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "currentNote");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_currentScoreProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "currentScoreProgress");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_firstElementFloated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "firstElementFloated");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_haveSpawnedGuestNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "haveSpawnedGuestNum");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "m_AnimatedPortrayalCoroutine");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_hasStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "m_hasStarted");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_NoteFailedAnimationPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "m_NoteFailedAnimationPool");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_NoteSucceedAnimationPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "m_NoteSucceedAnimationPool");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_PauseQTETimerCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "m_PauseQTETimerCallback");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_PlayCGCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "m_PlayCGCoroutine");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_QTEPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "m_QTEPannel");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_ResumeQTETimerCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "m_ResumeQTETimerCallback");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_maxGetCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "maxGetCombo");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_missedNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "missedNotes");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_noteHashSetBoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "noteHashSetBoss");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_noteHashSetPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "noteHashSetPlayer");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_noteStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "noteStatus");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_perNoteScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "perNoteScore");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_playerStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "playerStatus");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "bossStatus");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_rockCorotine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "rockCorotine");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr_targetScoreProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "targetScoreProgress");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr__PannelOpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "<PannelOpenContext>k__BackingField");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr__PannelCloseContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "<PannelCloseContext>k__BackingField");
			DLC3_MusicGameMainPannel.NativeFieldInfoPtr__CloseMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "<CloseMode>k__BackingField");
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663945);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_get_PannelOpenContext_Private_get_DLC3_MusicGameMainPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663946);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_set_PannelOpenContext_Public_set_Void_DLC3_MusicGameMainPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663947);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_set_PannelCloseContext_Private_set_Void_Nullable_1_BossBattleResultPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663948);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_get_PannelCloseContext_Public_get_Nullable_1_BossBattleResultPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663949);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_get_CloseMode_Public_get_PannelCloseMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663950);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_set_CloseMode_Public_set_Void_PannelCloseMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663951);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663952);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Pause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663953);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663954);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_OnPausePannelClose_Private_Void_MusicGamePausePannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663955);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_SetPlayerRockImage_Private_Void_RockStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663956);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_SetBossRockImage_Private_Void_RockStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663957);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663958);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_OnPlayerNoteProcess_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663959);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_OnBossNoteProcess_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663960);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_SpawnDancingCharacter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663961);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_CheckScoreProgress_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663962);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_GetDancingRange_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663963);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_AddDancingCharacter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663964);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_TryChangeCharacterStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663965);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_PlayNoteSucceedAnimation_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663966);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_PlayNoteFailedAnimation_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663967);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663968);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663969);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Private_T_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663970);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Internal_Static_Void_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663971);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Private_NoteHeadFinishAnimationController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663972);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Private_NoteHeadFinishAnimationController_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663973);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663974);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663975);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr__OnPausePannelClose_b__67_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663976);
			DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Internal_Static_Void_Image_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, 100663977);
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x000ADF78 File Offset: 0x000AC178
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_MusicGameMainPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x000ADFC0 File Offset: 0x000AC1C0
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x000ADFF8 File Offset: 0x000AC1F8
		public unsafe DLC3_MusicGameMainPannelOpenContext PannelOpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_get_PannelOpenContext_Private_get_DLC3_MusicGameMainPannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC3_MusicGameMainPannelOpenContext(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23301, XrefRangeEnd = 23302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_set_PannelOpenContext_Public_set_Void_DLC3_MusicGameMainPannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x000AE088 File Offset: 0x000AC288
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x000AE040 File Offset: 0x000AC240
		public unsafe Nullable<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext> PannelCloseContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_get_PannelCloseContext_Public_get_Nullable_1_BossBattleResultPannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_set_PannelCloseContext_Private_set_Void_Nullable_1_BossBattleResultPannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x000AE0C0 File Offset: 0x000AC2C0
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x000AE0FC File Offset: 0x000AC2FC
		public unsafe MusicSelectorPannel.PannelCloseMode CloseMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_get_CloseMode_Public_get_PannelCloseMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_set_CloseMode_Public_set_Void_PannelCloseMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000AE13C File Offset: 0x000AC33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23302, XrefRangeEnd = 23379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_MusicGameMainPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000AE178 File Offset: 0x000AC378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23379, XrefRangeEnd = 23416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Pause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000AE1AC File Offset: 0x000AC3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23416, XrefRangeEnd = 23430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_MusicGameMainPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000AE1E8 File Offset: 0x000AC3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23430, XrefRangeEnd = 23440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPausePannelClose(MusicGamePausePannel musicGamePausePannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(musicGamePausePannel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_OnPausePannelClose_Private_Void_MusicGamePausePannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x000AE22C File Offset: 0x000AC42C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23448, RefRangeEnd = 23449, XrefRangeStart = 23440, XrefRangeEnd = 23448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerRockImage(DLC3_MusicGameMainPannel.RockStatus rockStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rockStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_SetPlayerRockImage_Private_Void_RockStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000AE26C File Offset: 0x000AC46C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23457, RefRangeEnd = 23458, XrefRangeStart = 23449, XrefRangeEnd = 23457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBossRockImage(DLC3_MusicGameMainPannel.RockStatus rockStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rockStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_SetBossRockImage_Private_Void_RockStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000AE2AC File Offset: 0x000AC4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23458, XrefRangeEnd = 23507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_MusicGameMainPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000AE2E8 File Offset: 0x000AC4E8
		[CallerCount(0)]
		public unsafe void OnPlayerNoteProcess(int combo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref combo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_OnPlayerNoteProcess_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x000AE328 File Offset: 0x000AC528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23507, XrefRangeEnd = 23592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBossNoteProcess(long startTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_OnBossNoteProcess_Private_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000AE368 File Offset: 0x000AC568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23677, RefRangeEnd = 23678, XrefRangeStart = 23592, XrefRangeEnd = 23677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnDancingCharacter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_SpawnDancingCharacter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000AE39C File Offset: 0x000AC59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23678, XrefRangeEnd = 23687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckScoreProgress(float currentScoreProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentScoreProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_CheckScoreProgress_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x000AE3DC File Offset: 0x000AC5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23687, XrefRangeEnd = 23695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDancingRange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_GetDancingRange_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000AE414 File Offset: 0x000AC614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23695, XrefRangeEnd = 23703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDancingCharacter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_AddDancingCharacter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000AE448 File Offset: 0x000AC648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23703, XrefRangeEnd = 23709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryChangeCharacterStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_TryChangeCharacterStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000AE47C File Offset: 0x000AC67C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 23720, RefRangeEnd = 23724, XrefRangeStart = 23709, XrefRangeEnd = 23720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayNoteSucceedAnimation(bool isPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_PlayNoteSucceedAnimation_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000AE4BC File Offset: 0x000AC6BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 23735, RefRangeEnd = 23739, XrefRangeStart = 23724, XrefRangeEnd = 23735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayNoteFailedAnimation(bool isPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_PlayNoteFailedAnimation_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000AE4FC File Offset: 0x000AC6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23739, XrefRangeEnd = 23776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000AE538 File Offset: 0x000AC738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23776, XrefRangeEnd = 23899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC3_MusicGameMainPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000AE574 File Offset: 0x000AC774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 23907, RefRangeEnd = 23909, XrefRangeStart = 23899, XrefRangeEnd = 23907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.MethodInfoStoreGeneric_Method_Private_T_T_PDM_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000AE5F4 File Offset: 0x000AC7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23909, XrefRangeEnd = 23915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.MethodInfoStoreGeneric_Method_Internal_Static_Void_T_PDM_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000AE660 File Offset: 0x000AC860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23915, XrefRangeEnd = 23918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadFinishAnimationController Method_Private_NoteHeadFinishAnimationController_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Private_NoteHeadFinishAnimationController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NoteHeadFinishAnimationController>(intPtr3) : null;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000AE6A0 File Offset: 0x000AC8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23918, XrefRangeEnd = 23921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadFinishAnimationController Method_Private_NoteHeadFinishAnimationController_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Private_NoteHeadFinishAnimationController_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NoteHeadFinishAnimationController>(intPtr3) : null;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000AE6E0 File Offset: 0x000AC8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23921, XrefRangeEnd = 23925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_0(NoteHeadFinishAnimationController animator)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000AE718 File Offset: 0x000AC918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23925, XrefRangeEnd = 23929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_1(NoteHeadFinishAnimationController animator)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_1, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000AE750 File Offset: 0x000AC950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23929, XrefRangeEnd = 23938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPausePannelClose_b__67_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr__OnPausePannelClose_b__67_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000AE784 File Offset: 0x000AC984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 23951, RefRangeEnd = 23953, XrefRangeStart = 23938, XrefRangeEnd = 23951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_Image_Single_0(Image image, float target)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Internal_Static_Void_Image_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00004A2B File Offset: 0x00002C2B
		public DLC3_MusicGameMainPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x000AE7C8 File Offset: 0x000AC9C8
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00004A34 File Offset: 0x00002C34
		public unsafe Image PlayerPortrayal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_PlayerPortrayal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_PlayerPortrayal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x000AE7F8 File Offset: 0x000AC9F8
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00004A53 File Offset: 0x00002C53
		public unsafe QTEPannel MusicGameQTEPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_MusicGameQTEPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_MusicGameQTEPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x000AE828 File Offset: 0x000ACA28
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00004A72 File Offset: 0x00002C72
		public unsafe MusicGameCountDownPannel CountDownPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_CountDownPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameCountDownPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_CountDownPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x000AE858 File Offset: 0x000ACA58
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00004A91 File Offset: 0x00002C91
		public unsafe MusicGamePausePannel PausePannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_PausePannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGamePausePannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_PausePannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x000AE888 File Offset: 0x000ACA88
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00004AB0 File Offset: 0x00002CB0
		public unsafe RectTransform QTEPannelField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_QTEPannelField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_QTEPannelField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x000AE8B8 File Offset: 0x000ACAB8
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00004ACF File Offset: 0x00002CCF
		public unsafe UIButtonSimple PauseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_PauseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_PauseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x000AE8E8 File Offset: 0x000ACAE8
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00004AEE File Offset: 0x00002CEE
		public unsafe float m_NormalModePortrayalY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_NormalModePortrayalY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_NormalModePortrayalY)) = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x000AE910 File Offset: 0x000ACB10
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00004B09 File Offset: 0x00002D09
		public unsafe RectTransform m_PlayerPortrayalFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_PlayerPortrayalFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_PlayerPortrayalFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x000AE940 File Offset: 0x000ACB40
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00004B28 File Offset: 0x00002D28
		public unsafe GameObject mystiaCharacterElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_mystiaCharacterElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_mystiaCharacterElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x000AE970 File Offset: 0x000ACB70
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00004B47 File Offset: 0x00002D47
		public unsafe GameObject dancingCharacterElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_dancingCharacterElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_dancingCharacterElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x000AE9A0 File Offset: 0x000ACBA0
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00004B66 File Offset: 0x00002D66
		public unsafe RectTransform characterAnimtionField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_characterAnimtionField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_characterAnimtionField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x000AE9D0 File Offset: 0x000ACBD0
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00004B85 File Offset: 0x00002D85
		public unsafe UIElementCluster cluster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_cluster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_cluster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x000AEA00 File Offset: 0x000ACC00
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x00004BA4 File Offset: 0x00002DA4
		public unsafe Image playerRockImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_playerRockImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_playerRockImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x000AEA30 File Offset: 0x000ACC30
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00004BC3 File Offset: 0x00002DC3
		public unsafe Image bossRockImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossRockImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossRockImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x000AEA60 File Offset: 0x000ACC60
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00004BE2 File Offset: 0x00002DE2
		public unsafe NoteHeadFinishAnimationController AnimatorSucceed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_AnimatorSucceed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadFinishAnimationController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_AnimatorSucceed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x000AEA90 File Offset: 0x000ACC90
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00004C01 File Offset: 0x00002E01
		public unsafe NoteHeadFinishAnimationController AnimatorFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_AnimatorFail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteHeadFinishAnimationController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_AnimatorFail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x000AEAC0 File Offset: 0x000ACCC0
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00004C20 File Offset: 0x00002E20
		public unsafe Vector3 offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x000AEAE8 File Offset: 0x000ACCE8
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00004C3B File Offset: 0x00002E3B
		public unsafe RectTransform AnimationField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_AnimationField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_AnimationField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x000AEB18 File Offset: 0x000ACD18
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00004C5A File Offset: 0x00002E5A
		public unsafe Image playerLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_playerLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_playerLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x000AEB48 File Offset: 0x000ACD48
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00004C79 File Offset: 0x00002E79
		public unsafe Image bossLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x000AEB78 File Offset: 0x000ACD78
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00004C98 File Offset: 0x00002E98
		public unsafe float frameTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_frameTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_frameTime)) = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x000AEBA0 File Offset: 0x000ACDA0
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00004CB3 File Offset: 0x00002EB3
		public unsafe List<MusicGameMainDancingCharacterElement> dancingCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_dancingCharacters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MusicGameMainDancingCharacterElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_dancingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x000AEBD0 File Offset: 0x000ACDD0
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00004CD2 File Offset: 0x00002ED2
		public unsafe HashSet<NoteHeadFinishAnimationController> m_ActiveAnimations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_ActiveAnimations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<NoteHeadFinishAnimationController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_ActiveAnimations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x000AEC00 File Offset: 0x000ACE00
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00004CF1 File Offset: 0x00002EF1
		public unsafe Il2CppStringArray m_AvailableActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_AvailableActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_AvailableActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x000AEC30 File Offset: 0x000ACE30
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00004D10 File Offset: 0x00002F10
		public unsafe int bossGetCombo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossGetCombo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossGetCombo)) = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x000AEC58 File Offset: 0x000ACE58
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00004D2B File Offset: 0x00002F2B
		public unsafe float bossGetScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossGetScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossGetScore)) = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x000AEC80 File Offset: 0x000ACE80
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00004D46 File Offset: 0x00002F46
		public unsafe float comboScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_comboScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_comboScore)) = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x000AECA8 File Offset: 0x000ACEA8
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00004D61 File Offset: 0x00002F61
		public unsafe int currentGetCombo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_currentGetCombo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_currentGetCombo)) = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000AECD0 File Offset: 0x000ACED0
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00004D7C File Offset: 0x00002F7C
		public unsafe int currentNote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_currentNote);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_currentNote)) = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x000AECF8 File Offset: 0x000ACEF8
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00004D97 File Offset: 0x00002F97
		public unsafe float currentScoreProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_currentScoreProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_currentScoreProgress)) = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x000AED20 File Offset: 0x000ACF20
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00004DB2 File Offset: 0x00002FB2
		public unsafe bool firstElementFloated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_firstElementFloated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_firstElementFloated)) = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x000AED48 File Offset: 0x000ACF48
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00004DCD File Offset: 0x00002FCD
		public unsafe int haveSpawnedGuestNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_haveSpawnedGuestNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_haveSpawnedGuestNum)) = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x000AED70 File Offset: 0x000ACF70
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00004DE8 File Offset: 0x00002FE8
		public unsafe Coroutine m_AnimatedPortrayalCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x000AEDA0 File Offset: 0x000ACFA0
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00004E07 File Offset: 0x00003007
		public unsafe bool m_hasStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_hasStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_hasStarted)) = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x000AEDC8 File Offset: 0x000ACFC8
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00004E22 File Offset: 0x00003022
		public unsafe ObjectPool<NoteHeadFinishAnimationController> m_NoteFailedAnimationPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_NoteFailedAnimationPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<NoteHeadFinishAnimationController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_NoteFailedAnimationPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x000AEDF8 File Offset: 0x000ACFF8
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00004E41 File Offset: 0x00003041
		public unsafe ObjectPool<NoteHeadFinishAnimationController> m_NoteSucceedAnimationPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_NoteSucceedAnimationPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<NoteHeadFinishAnimationController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_NoteSucceedAnimationPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x000AEE28 File Offset: 0x000AD028
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00004E60 File Offset: 0x00003060
		public unsafe Action m_PauseQTETimerCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_PauseQTETimerCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_PauseQTETimerCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x000AEE58 File Offset: 0x000AD058
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00004E7F File Offset: 0x0000307F
		public unsafe Coroutine m_PlayCGCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_PlayCGCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_PlayCGCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x000AEE88 File Offset: 0x000AD088
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00004E9E File Offset: 0x0000309E
		public unsafe QTEPannel m_QTEPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_QTEPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_QTEPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x000AEEB8 File Offset: 0x000AD0B8
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00004EBD File Offset: 0x000030BD
		public unsafe Action m_ResumeQTETimerCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_ResumeQTETimerCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_m_ResumeQTETimerCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x000AEEE8 File Offset: 0x000AD0E8
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00004EDC File Offset: 0x000030DC
		public unsafe int maxGetCombo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_maxGetCombo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_maxGetCombo)) = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x000AEF10 File Offset: 0x000AD110
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00004EF7 File Offset: 0x000030F7
		public unsafe List<int> missedNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_missedNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_missedNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x000AEF40 File Offset: 0x000AD140
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00004F16 File Offset: 0x00003116
		public unsafe HashSet<long> noteHashSetBoss
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_noteHashSetBoss);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_noteHashSetBoss), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x000AEF70 File Offset: 0x000AD170
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00004F35 File Offset: 0x00003135
		public unsafe HashSet<long> noteHashSetPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_noteHashSetPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_noteHashSetPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x000AEFA0 File Offset: 0x000AD1A0
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00004F54 File Offset: 0x00003154
		public unsafe DLC3_MusicGameMainPannel.NoteStatus noteStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_noteStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_noteStatus)) = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x000AEFC8 File Offset: 0x000AD1C8
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00004F6F File Offset: 0x0000316F
		public unsafe float perNoteScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_perNoteScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_perNoteScore)) = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x000AEFF0 File Offset: 0x000AD1F0
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00004F8A File Offset: 0x0000318A
		public unsafe DLC3_MusicGameMainPannel.RockStatus playerStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_playerStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_playerStatus)) = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x000AF018 File Offset: 0x000AD218
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00004FA5 File Offset: 0x000031A5
		public unsafe DLC3_MusicGameMainPannel.RockStatus bossStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_bossStatus)) = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x000AF040 File Offset: 0x000AD240
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00004FC0 File Offset: 0x000031C0
		public unsafe Coroutine rockCorotine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_rockCorotine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_rockCorotine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x000AF070 File Offset: 0x000AD270
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00004FDF File Offset: 0x000031DF
		public unsafe int targetScoreProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_targetScoreProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr_targetScoreProgress)) = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x000AF098 File Offset: 0x000AD298
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00004FFA File Offset: 0x000031FA
		public DLC3_MusicGameMainPannelOpenContext _PannelOpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr__PannelOpenContext_k__BackingField);
				return new DLC3_MusicGameMainPannelOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MusicGameMainPannelOpenContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr__PannelOpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MusicGameMainPannelOpenContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x000AF0C8 File Offset: 0x000AD2C8
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00005028 File Offset: 0x00003228
		public Nullable<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext> _PannelCloseContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr__PannelCloseContext_k__BackingField);
				return new Nullable<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr__PannelCloseContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x000AF0F8 File Offset: 0x000AD2F8
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00005056 File Offset: 0x00003256
		public unsafe MusicSelectorPannel.PannelCloseMode _CloseMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr__CloseMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.NativeFieldInfoPtr__CloseMode_k__BackingField)) = value;
			}
		}

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeFieldInfoPtr_PlayerPortrayal;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr_MusicGameQTEPannel;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr_CountDownPannel;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeFieldInfoPtr_PausePannel;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeFieldInfoPtr_QTEPannelField;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeFieldInfoPtr_PauseButton;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalModePortrayalY;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerPortrayalFrame;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_mystiaCharacterElement;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_dancingCharacterElement;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_characterAnimtionField;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_cluster;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_playerRockImage;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr_bossRockImage;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeFieldInfoPtr_AnimatorSucceed;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeFieldInfoPtr_AnimatorFail;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr_AnimationField;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeFieldInfoPtr_playerLight;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeFieldInfoPtr_bossLight;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeFieldInfoPtr_frameTime;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeFieldInfoPtr_dancingCharacters;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveAnimations;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeFieldInfoPtr_m_AvailableActions;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeFieldInfoPtr_bossGetCombo;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeFieldInfoPtr_bossGetScore;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeFieldInfoPtr_comboScore;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeFieldInfoPtr_currentGetCombo;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeFieldInfoPtr_currentNote;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeFieldInfoPtr_currentScoreProgress;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeFieldInfoPtr_firstElementFloated;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeFieldInfoPtr_haveSpawnedGuestNum;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeFieldInfoPtr_m_hasStarted;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteFailedAnimationPool;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeFieldInfoPtr_m_NoteSucceedAnimationPool;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeFieldInfoPtr_m_PauseQTETimerCallback;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayCGCoroutine;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_m_QTEPannel;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_m_ResumeQTETimerCallback;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_maxGetCombo;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_missedNotes;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr_noteHashSetBoss;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr_noteHashSetPlayer;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr_noteStatus;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeFieldInfoPtr_perNoteScore;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr_playerStatus;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeFieldInfoPtr_bossStatus;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeFieldInfoPtr_rockCorotine;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr_targetScoreProgress;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeFieldInfoPtr__PannelOpenContext_k__BackingField;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr__PannelCloseContext_k__BackingField;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr__CloseMode_k__BackingField;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_get_PannelOpenContext_Private_get_DLC3_MusicGameMainPannelOpenContext_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_set_PannelOpenContext_Public_set_Void_DLC3_MusicGameMainPannelOpenContext_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_set_PannelCloseContext_Private_set_Void_Nullable_1_BossBattleResultPannelOpenContext_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_get_PannelCloseContext_Public_get_Nullable_1_BossBattleResultPannelOpenContext_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseMode_Public_get_PannelCloseMode_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseMode_Public_set_Void_PannelCloseMode_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Private_Void_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_OnPausePannelClose_Private_Void_MusicGamePausePannel_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerRockImage_Private_Void_RockStatus_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_SetBossRockImage_Private_Void_RockStatus_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerNoteProcess_Private_Void_Int32_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_OnBossNoteProcess_Private_Void_Int64_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_SpawnDancingCharacter_Private_Void_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_CheckScoreProgress_Private_Void_Single_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_GetDancingRange_Private_String_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_AddDancingCharacter_Private_Void_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_TryChangeCharacterStatus_Private_Void_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_PlayNoteSucceedAnimation_Protected_Void_Boolean_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_PlayNoteFailedAnimation_Protected_Void_Boolean_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_T_T_PDM_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_T_PDM_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_NoteHeadFinishAnimationController_PDM_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_NoteHeadFinishAnimationController_PDM_1;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_NoteHeadFinishAnimationController_PDM_1;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr__OnPausePannelClose_b__67_0_Private_Void_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Image_Single_0;

		// Token: 0x020004A4 RID: 1188
		public enum RockStatus
		{
			// Token: 0x0400532E RID: 21294
			Wait,
			// Token: 0x0400532F RID: 21295
			Rock,
			// Token: 0x04005330 RID: 21296
			Rock2,
			// Token: 0x04005331 RID: 21297
			Fail
		}

		// Token: 0x020004A5 RID: 1189
		public enum NoteStatus
		{
			// Token: 0x04005333 RID: 21299
			Up,
			// Token: 0x04005334 RID: 21300
			Down
		}

		// Token: 0x020004A6 RID: 1190
		[ObfuscatedName("MusicGame.UI.DLC3_MusicGameMainPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06007E82 RID: 32386 RVA: 0x00240D28 File Offset: 0x0023EF28
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr);
				DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, "<>9");
				DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__65_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, "<>9__65_0");
				DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__70_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, "<>9__70_3");
				DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__70_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, "<>9__70_4");
				DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__72_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, "<>9__72_2");
				DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__72_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, "<>9__72_3");
				DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__73_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, "<>9__73_0");
				DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__73_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, "<>9__73_1");
				DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, 100663979);
				DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__Pause_b__65_0_Internal_Void_MusicGamePausePannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, 100663980);
				DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__70_3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, 100663981);
				DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__70_4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, 100663982);
				DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__OnBossNoteProcess_b__72_2_Internal_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, 100663983);
				DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__OnBossNoteProcess_b__72_3_Internal_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, 100663984);
				DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__SpawnDancingCharacter_b__73_0_Internal_String_NPCMusicRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, 100663985);
				DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__SpawnDancingCharacter_b__73_1_Internal_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr, 100663986);
			}

			// Token: 0x06007E83 RID: 32387 RVA: 0x00240E94 File Offset: 0x0023F094
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E84 RID: 32388 RVA: 0x00240ED0 File Offset: 0x0023F0D0
			[CallerCount(0)]
			public unsafe void _Pause_b__65_0(MusicGamePausePannel x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__Pause_b__65_0_Internal_Void_MusicGamePausePannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E85 RID: 32389 RVA: 0x00240F14 File Offset: 0x0023F114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23032, XrefRangeEnd = 23033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__70_3(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__70_3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E86 RID: 32390 RVA: 0x00240F58 File Offset: 0x0023F158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__70_4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__70_4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E87 RID: 32391 RVA: 0x00240F9C File Offset: 0x0023F19C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23033, XrefRangeEnd = 23037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBossNoteProcess_b__72_2(Animator x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__OnBossNoteProcess_b__72_2_Internal_Void_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E88 RID: 32392 RVA: 0x00240FE0 File Offset: 0x0023F1E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23037, XrefRangeEnd = 23041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBossNoteProcess_b__72_3(Animator x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__OnBossNoteProcess_b__72_3_Internal_Void_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E89 RID: 32393 RVA: 0x00241024 File Offset: 0x0023F224
			[CallerCount(0)]
			public unsafe string _SpawnDancingCharacter_b__73_0(MusicGameChapterProfile.NPCMusicRank x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__SpawnDancingCharacter_b__73_0_Internal_String_NPCMusicRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06007E8A RID: 32394 RVA: 0x00241074 File Offset: 0x0023F274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Guid _SpawnDancingCharacter_b__73_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c.NativeMethodInfoPtr__SpawnDancingCharacter_b__73_1_Internal_Guid_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007E8B RID: 32395 RVA: 0x00044125 File Offset: 0x00042325
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002ABA RID: 10938
			// (get) Token: 0x06007E8C RID: 32396 RVA: 0x002410C4 File Offset: 0x0023F2C4
			// (set) Token: 0x06007E8D RID: 32397 RVA: 0x0004412E File Offset: 0x0004232E
			public unsafe static DLC3_MusicGameMainPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MusicGameMainPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ABB RID: 10939
			// (get) Token: 0x06007E8E RID: 32398 RVA: 0x002410EC File Offset: 0x0023F2EC
			// (set) Token: 0x06007E8F RID: 32399 RVA: 0x00044140 File Offset: 0x00042340
			public unsafe static Action<MusicGamePausePannel> __9__65_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__65_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MusicGamePausePannel>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__65_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ABC RID: 10940
			// (get) Token: 0x06007E90 RID: 32400 RVA: 0x00241114 File Offset: 0x0023F314
			// (set) Token: 0x06007E91 RID: 32401 RVA: 0x00044152 File Offset: 0x00042352
			public unsafe static Action<TextMeshProUGUI> __9__70_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__70_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__70_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ABD RID: 10941
			// (get) Token: 0x06007E92 RID: 32402 RVA: 0x0024113C File Offset: 0x0023F33C
			// (set) Token: 0x06007E93 RID: 32403 RVA: 0x00044164 File Offset: 0x00042364
			public unsafe static Action<TextMeshProUGUI> __9__70_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__70_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__70_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ABE RID: 10942
			// (get) Token: 0x06007E94 RID: 32404 RVA: 0x00241164 File Offset: 0x0023F364
			// (set) Token: 0x06007E95 RID: 32405 RVA: 0x00044176 File Offset: 0x00042376
			public unsafe static Action<Animator> __9__72_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__72_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Animator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__72_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002ABF RID: 10943
			// (get) Token: 0x06007E96 RID: 32406 RVA: 0x0024118C File Offset: 0x0023F38C
			// (set) Token: 0x06007E97 RID: 32407 RVA: 0x00044188 File Offset: 0x00042388
			public unsafe static Action<Animator> __9__72_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__72_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Animator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__72_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AC0 RID: 10944
			// (get) Token: 0x06007E98 RID: 32408 RVA: 0x002411B4 File Offset: 0x0023F3B4
			// (set) Token: 0x06007E99 RID: 32409 RVA: 0x0004419A File Offset: 0x0004239A
			public unsafe static Func<MusicGameChapterProfile.NPCMusicRank, string> __9__73_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__73_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MusicGameChapterProfile.NPCMusicRank, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__73_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AC1 RID: 10945
			// (get) Token: 0x06007E9A RID: 32410 RVA: 0x002411DC File Offset: 0x0023F3DC
			// (set) Token: 0x06007E9B RID: 32411 RVA: 0x000441AC File Offset: 0x000423AC
			public unsafe static Func<string, Guid> __9__73_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__73_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, Guid>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MusicGameMainPannel.__c.NativeFieldInfoPtr___9__73_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005335 RID: 21301
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005336 RID: 21302
			private static readonly IntPtr NativeFieldInfoPtr___9__65_0;

			// Token: 0x04005337 RID: 21303
			private static readonly IntPtr NativeFieldInfoPtr___9__70_3;

			// Token: 0x04005338 RID: 21304
			private static readonly IntPtr NativeFieldInfoPtr___9__70_4;

			// Token: 0x04005339 RID: 21305
			private static readonly IntPtr NativeFieldInfoPtr___9__72_2;

			// Token: 0x0400533A RID: 21306
			private static readonly IntPtr NativeFieldInfoPtr___9__72_3;

			// Token: 0x0400533B RID: 21307
			private static readonly IntPtr NativeFieldInfoPtr___9__73_0;

			// Token: 0x0400533C RID: 21308
			private static readonly IntPtr NativeFieldInfoPtr___9__73_1;

			// Token: 0x0400533D RID: 21309
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400533E RID: 21310
			private static readonly IntPtr NativeMethodInfoPtr__Pause_b__65_0_Internal_Void_MusicGamePausePannel_0;

			// Token: 0x0400533F RID: 21311
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__70_3_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04005340 RID: 21312
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__70_4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04005341 RID: 21313
			private static readonly IntPtr NativeMethodInfoPtr__OnBossNoteProcess_b__72_2_Internal_Void_Animator_0;

			// Token: 0x04005342 RID: 21314
			private static readonly IntPtr NativeMethodInfoPtr__OnBossNoteProcess_b__72_3_Internal_Void_Animator_0;

			// Token: 0x04005343 RID: 21315
			private static readonly IntPtr NativeMethodInfoPtr__SpawnDancingCharacter_b__73_0_Internal_String_NPCMusicRank_0;

			// Token: 0x04005344 RID: 21316
			private static readonly IntPtr NativeMethodInfoPtr__SpawnDancingCharacter_b__73_1_Internal_Guid_String_0;
		}

		// Token: 0x020004A7 RID: 1191
		[ObfuscatedName("MusicGame.UI.DLC3_MusicGameMainPannel+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
		{
			// Token: 0x06007E9C RID: 32412 RVA: 0x00241204 File Offset: 0x0023F404
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>.NativeClassPtr);
				DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>.NativeClassPtr, "<>4__this");
				DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeFieldInfoPtr_musicDataPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>.NativeClassPtr, "musicDataPack");
				DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>.NativeClassPtr, 100663987);
				DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_AsyncOperationHandle_1_LoopedBGMPackage_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>.NativeClassPtr, 100663988);
				DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>.NativeClassPtr, 100663989);
				DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_Void_AsyncOperationHandle_1_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>.NativeClassPtr, 100663990);
				DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>.NativeClassPtr, 100663991);
				DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>.NativeClassPtr, 100663992);
			}

			// Token: 0x06007E9D RID: 32413 RVA: 0x002412D0 File Offset: 0x0023F4D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E9E RID: 32414 RVA: 0x0024130C File Offset: 0x0023F50C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23053, XrefRangeEnd = 23054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__0(AsyncOperationHandle<LoopedBGMPackage> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_AsyncOperationHandle_1_LoopedBGMPackage_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007E9F RID: 32415 RVA: 0x00241354 File Offset: 0x0023F554
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 23059, RefRangeEnd = 23061, XrefRangeStart = 23054, XrefRangeEnd = 23059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007EA0 RID: 32416 RVA: 0x00241394 File Offset: 0x0023F594
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23234, RefRangeEnd = 23235, XrefRangeStart = 23061, XrefRangeEnd = 23234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_AsyncOperationHandle_1_LoopedBGMPackage_0(AsyncOperationHandle<LoopedBGMPackage> loadedPackage)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(loadedPackage));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_Void_AsyncOperationHandle_1_LoopedBGMPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EA1 RID: 32417 RVA: 0x002413DC File Offset: 0x0023F5DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23235, XrefRangeEnd = 23241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EA2 RID: 32418 RVA: 0x00241410 File Offset: 0x0023F610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23241, XrefRangeEnd = 23247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EA3 RID: 32419 RVA: 0x000441BE File Offset: 0x000423BE
			public __c__DisplayClass70_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AC2 RID: 10946
			// (get) Token: 0x06007EA4 RID: 32420 RVA: 0x00241444 File Offset: 0x0023F644
			// (set) Token: 0x06007EA5 RID: 32421 RVA: 0x000441C7 File Offset: 0x000423C7
			public unsafe DLC3_MusicGameMainPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MusicGameMainPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AC3 RID: 10947
			// (get) Token: 0x06007EA6 RID: 32422 RVA: 0x00241474 File Offset: 0x0023F674
			// (set) Token: 0x06007EA7 RID: 32423 RVA: 0x000441E6 File Offset: 0x000423E6
			public MusicGameChapterProfile.MusicChapter musicDataPack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeFieldInfoPtr_musicDataPack);
					return new MusicGameChapterProfile.MusicChapter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.NativeFieldInfoPtr_musicDataPack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005345 RID: 21317
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005346 RID: 21318
			private static readonly IntPtr NativeFieldInfoPtr_musicDataPack;

			// Token: 0x04005347 RID: 21319
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005348 RID: 21320
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_AsyncOperationHandle_1_LoopedBGMPackage_1;

			// Token: 0x04005349 RID: 21321
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x0400534A RID: 21322
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_AsyncOperationHandle_1_LoopedBGMPackage_0;

			// Token: 0x0400534B RID: 21323
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Void_0;

			// Token: 0x0400534C RID: 21324
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_0;

			// Token: 0x02000FA9 RID: 4009
			[ObfuscatedName("MusicGame.UI.DLC3_MusicGameMainPannel+<>c__DisplayClass70_0+<<OnPanelOpen>g__StartRock|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060114B7 RID: 70839 RVA: 0x003FAE64 File Offset: 0x003F9064
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique()
				{
					Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>.NativeClassPtr, "<<OnPanelOpen>g__StartRock|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr);
					DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>1__state");
					DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>2__current");
					DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>4__this");
					DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__wait_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<wait>5__2");
					DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100663993);
					DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100663994);
					DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100663995);
					DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100663996);
					DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100663997);
					DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100663998);
				}

				// Token: 0x060114B8 RID: 70840 RVA: 0x003FAF58 File Offset: 0x003F9158
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114B9 RID: 70841 RVA: 0x003FAFA0 File Offset: 0x003F91A0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114BA RID: 70842 RVA: 0x003FAFD4 File Offset: 0x003F91D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23041, XrefRangeEnd = 23047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170059EA RID: 23018
				// (get) Token: 0x060114BB RID: 70843 RVA: 0x003FB010 File Offset: 0x003F9210
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060114BC RID: 70844 RVA: 0x003FB050 File Offset: 0x003F9250
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23047, XrefRangeEnd = 23053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170059EB RID: 23019
				// (get) Token: 0x060114BD RID: 70845 RVA: 0x003FB084 File Offset: 0x003F9284
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060114BE RID: 70846 RVA: 0x00096764 File Offset: 0x00094964
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170059E6 RID: 23014
				// (get) Token: 0x060114BF RID: 70847 RVA: 0x003FB0C4 File Offset: 0x003F92C4
				// (set) Token: 0x060114C0 RID: 70848 RVA: 0x0009676D File Offset: 0x0009496D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170059E7 RID: 23015
				// (get) Token: 0x060114C1 RID: 70849 RVA: 0x003FB0EC File Offset: 0x003F92EC
				// (set) Token: 0x060114C2 RID: 70850 RVA: 0x00096788 File Offset: 0x00094988
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059E8 RID: 23016
				// (get) Token: 0x060114C3 RID: 70851 RVA: 0x003FB11C File Offset: 0x003F931C
				// (set) Token: 0x060114C4 RID: 70852 RVA: 0x000967A7 File Offset: 0x000949A7
				public unsafe DLC3_MusicGameMainPannel.__c__DisplayClass70_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059E9 RID: 23017
				// (get) Token: 0x060114C5 RID: 70853 RVA: 0x003FB14C File Offset: 0x003F934C
				// (set) Token: 0x060114C6 RID: 70854 RVA: 0x000967C6 File Offset: 0x000949C6
				public unsafe WaitForSeconds _wait_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__wait_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__wait_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AED1 RID: 44753
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AED2 RID: 44754
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AED3 RID: 44755
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AED4 RID: 44756
				private static readonly IntPtr NativeFieldInfoPtr__wait_5__2;

				// Token: 0x0400AED5 RID: 44757
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AED6 RID: 44758
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AED7 RID: 44759
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AED8 RID: 44760
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AED9 RID: 44761
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEDA RID: 44762
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020004A8 RID: 1192
		[ObfuscatedName("MusicGame.UI.DLC3_MusicGameMainPannel+<>c__DisplayClass70_1")]
		public sealed class __c__DisplayClass70_1 : Il2CppSystem.Object
		{
			// Token: 0x06007EA8 RID: 32424 RVA: 0x002414A4 File Offset: 0x0023F6A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_1()
			{
				Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "<>c__DisplayClass70_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr);
				DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_isPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr, "isPaused");
				DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_pausedDSPTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr, "pausedDSPTime");
				DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_dspOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr, "dspOffset");
				DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_openTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr, "openTime");
				DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_noteArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr, "noteArray");
				DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_loadedPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr, "loadedPackage");
				DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr, 100663999);
				DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeMethodInfoPtr_Method_Internal_Int64_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr, 100664000);
				DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr, 100664001);
				DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr, 100664002);
				DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr, 100664003);
				DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr, 100664004);
			}

			// Token: 0x06007EA9 RID: 32425 RVA: 0x002415D4 File Offset: 0x0023F7D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass70_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EAA RID: 32426 RVA: 0x00241610 File Offset: 0x0023F810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe long Method_Internal_Int64_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeMethodInfoPtr_Method_Internal_Int64_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007EAB RID: 32427 RVA: 0x0024164C File Offset: 0x0023F84C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23247, XrefRangeEnd = 23251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EAC RID: 32428 RVA: 0x00241680 File Offset: 0x0023F880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23251, XrefRangeEnd = 23253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EAD RID: 32429 RVA: 0x002416B4 File Offset: 0x0023F8B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23260, RefRangeEnd = 23261, XrefRangeStart = 23253, XrefRangeEnd = 23260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EAE RID: 32430 RVA: 0x002416E8 File Offset: 0x0023F8E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23261, XrefRangeEnd = 23292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EAF RID: 32431 RVA: 0x00044214 File Offset: 0x00042414
			public __c__DisplayClass70_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002AC4 RID: 10948
			// (get) Token: 0x06007EB0 RID: 32432 RVA: 0x0024171C File Offset: 0x0023F91C
			// (set) Token: 0x06007EB1 RID: 32433 RVA: 0x0004421D File Offset: 0x0004241D
			public unsafe bool isPaused
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_isPaused);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_isPaused)) = value;
				}
			}

			// Token: 0x17002AC5 RID: 10949
			// (get) Token: 0x06007EB2 RID: 32434 RVA: 0x00241744 File Offset: 0x0023F944
			// (set) Token: 0x06007EB3 RID: 32435 RVA: 0x00044238 File Offset: 0x00042438
			public unsafe double pausedDSPTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_pausedDSPTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_pausedDSPTime)) = value;
				}
			}

			// Token: 0x17002AC6 RID: 10950
			// (get) Token: 0x06007EB4 RID: 32436 RVA: 0x0024176C File Offset: 0x0023F96C
			// (set) Token: 0x06007EB5 RID: 32437 RVA: 0x00044253 File Offset: 0x00042453
			public unsafe double dspOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_dspOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_dspOffset)) = value;
				}
			}

			// Token: 0x17002AC7 RID: 10951
			// (get) Token: 0x06007EB6 RID: 32438 RVA: 0x00241794 File Offset: 0x0023F994
			// (set) Token: 0x06007EB7 RID: 32439 RVA: 0x0004426E File Offset: 0x0004246E
			public unsafe double openTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_openTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_openTime)) = value;
				}
			}

			// Token: 0x17002AC8 RID: 10952
			// (get) Token: 0x06007EB8 RID: 32440 RVA: 0x002417BC File Offset: 0x0023F9BC
			// (set) Token: 0x06007EB9 RID: 32441 RVA: 0x00044289 File Offset: 0x00042489
			public unsafe Il2CppStructArray<IzakayaMusic.SingleNote> noteArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_noteArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IzakayaMusic.SingleNote>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_noteArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AC9 RID: 10953
			// (get) Token: 0x06007EBA RID: 32442 RVA: 0x002417EC File Offset: 0x0023F9EC
			// (set) Token: 0x06007EBB RID: 32443 RVA: 0x000442A8 File Offset: 0x000424A8
			public AsyncOperationHandle<LoopedBGMPackage> loadedPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_loadedPackage);
					return new AsyncOperationHandle<LoopedBGMPackage>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<LoopedBGMPackage>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_loadedPackage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<LoopedBGMPackage>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002ACA RID: 10954
			// (get) Token: 0x06007EBC RID: 32444 RVA: 0x0024181C File Offset: 0x0023FA1C
			// (set) Token: 0x06007EBD RID: 32445 RVA: 0x000442D6 File Offset: 0x000424D6
			public unsafe DLC3_MusicGameMainPannel.__c__DisplayClass70_0 field_Public___c__DisplayClass70_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MusicGameMainPannel.__c__DisplayClass70_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400534D RID: 21325
			private static readonly IntPtr NativeFieldInfoPtr_isPaused;

			// Token: 0x0400534E RID: 21326
			private static readonly IntPtr NativeFieldInfoPtr_pausedDSPTime;

			// Token: 0x0400534F RID: 21327
			private static readonly IntPtr NativeFieldInfoPtr_dspOffset;

			// Token: 0x04005350 RID: 21328
			private static readonly IntPtr NativeFieldInfoPtr_openTime;

			// Token: 0x04005351 RID: 21329
			private static readonly IntPtr NativeFieldInfoPtr_noteArray;

			// Token: 0x04005352 RID: 21330
			private static readonly IntPtr NativeFieldInfoPtr_loadedPackage;

			// Token: 0x04005353 RID: 21331
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0;

			// Token: 0x04005354 RID: 21332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005355 RID: 21333
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Int64_PDM_0;

			// Token: 0x04005356 RID: 21334
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04005357 RID: 21335
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;

			// Token: 0x04005358 RID: 21336
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04005359 RID: 21337
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_2;
		}

		// Token: 0x020004A9 RID: 1193
		[ObfuscatedName("MusicGame.UI.DLC3_MusicGameMainPannel+<>c__DisplayClass72_0")]
		public sealed class __c__DisplayClass72_0 : Il2CppSystem.Object
		{
			// Token: 0x06007EBE RID: 32446 RVA: 0x0024184C File Offset: 0x0023FA4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass72_0()
			{
				Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "<>c__DisplayClass72_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_0>.NativeClassPtr);
				DLC3_MusicGameMainPannel.__c__DisplayClass72_0.NativeFieldInfoPtr_BossScoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_0>.NativeClassPtr, "BossScoreText");
				DLC3_MusicGameMainPannel.__c__DisplayClass72_0.NativeFieldInfoPtr_BossComboText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_0>.NativeClassPtr, "BossComboText");
				DLC3_MusicGameMainPannel.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_0>.NativeClassPtr, 100664005);
				DLC3_MusicGameMainPannel.__c__DisplayClass72_0.NativeMethodInfoPtr__OnBossNoteProcess_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_0>.NativeClassPtr, 100664006);
				DLC3_MusicGameMainPannel.__c__DisplayClass72_0.NativeMethodInfoPtr__OnBossNoteProcess_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_0>.NativeClassPtr, 100664007);
			}

			// Token: 0x06007EBF RID: 32447 RVA: 0x002418DC File Offset: 0x0023FADC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass72_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EC0 RID: 32448 RVA: 0x00241918 File Offset: 0x0023FB18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23292, XrefRangeEnd = 23293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBossNoteProcess_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass72_0.NativeMethodInfoPtr__OnBossNoteProcess_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EC1 RID: 32449 RVA: 0x0024195C File Offset: 0x0023FB5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23293, XrefRangeEnd = 23294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBossNoteProcess_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass72_0.NativeMethodInfoPtr__OnBossNoteProcess_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EC2 RID: 32450 RVA: 0x000442F5 File Offset: 0x000424F5
			public __c__DisplayClass72_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002ACB RID: 10955
			// (get) Token: 0x06007EC3 RID: 32451 RVA: 0x002419A0 File Offset: 0x0023FBA0
			// (set) Token: 0x06007EC4 RID: 32452 RVA: 0x000442FE File Offset: 0x000424FE
			public unsafe string BossScoreText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass72_0.NativeFieldInfoPtr_BossScoreText);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass72_0.NativeFieldInfoPtr_BossScoreText), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002ACC RID: 10956
			// (get) Token: 0x06007EC5 RID: 32453 RVA: 0x002419C8 File Offset: 0x0023FBC8
			// (set) Token: 0x06007EC6 RID: 32454 RVA: 0x0004431D File Offset: 0x0004251D
			public unsafe string BossComboText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass72_0.NativeFieldInfoPtr_BossComboText);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass72_0.NativeFieldInfoPtr_BossComboText), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400535A RID: 21338
			private static readonly IntPtr NativeFieldInfoPtr_BossScoreText;

			// Token: 0x0400535B RID: 21339
			private static readonly IntPtr NativeFieldInfoPtr_BossComboText;

			// Token: 0x0400535C RID: 21340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400535D RID: 21341
			private static readonly IntPtr NativeMethodInfoPtr__OnBossNoteProcess_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400535E RID: 21342
			private static readonly IntPtr NativeMethodInfoPtr__OnBossNoteProcess_b__1_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x020004AA RID: 1194
		[ObfuscatedName("MusicGame.UI.DLC3_MusicGameMainPannel+<>c__DisplayClass72_1")]
		public sealed class __c__DisplayClass72_1 : Il2CppSystem.Object
		{
			// Token: 0x06007EC7 RID: 32455 RVA: 0x002419F0 File Offset: 0x0023FBF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass72_1()
			{
				Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr, "<>c__DisplayClass72_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_1>.NativeClassPtr);
				DLC3_MusicGameMainPannel.__c__DisplayClass72_1.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_1>.NativeClassPtr, "image");
				DLC3_MusicGameMainPannel.__c__DisplayClass72_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_1>.NativeClassPtr, 100664008);
				DLC3_MusicGameMainPannel.__c__DisplayClass72_1.NativeMethodInfoPtr__OnBossNoteProcess_b__5_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_1>.NativeClassPtr, 100664009);
			}

			// Token: 0x06007EC8 RID: 32456 RVA: 0x00241A58 File Offset: 0x0023FC58
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass72_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameMainPannel.__c__DisplayClass72_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass72_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007EC9 RID: 32457 RVA: 0x00241A94 File Offset: 0x0023FC94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23294, XrefRangeEnd = 23301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBossNoteProcess_b__5(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameMainPannel.__c__DisplayClass72_1.NativeMethodInfoPtr__OnBossNoteProcess_b__5_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007ECA RID: 32458 RVA: 0x0004433C File Offset: 0x0004253C
			public __c__DisplayClass72_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002ACD RID: 10957
			// (get) Token: 0x06007ECB RID: 32459 RVA: 0x00241AD4 File Offset: 0x0023FCD4
			// (set) Token: 0x06007ECC RID: 32460 RVA: 0x00044345 File Offset: 0x00042545
			public unsafe Image image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass72_1.NativeFieldInfoPtr_image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameMainPannel.__c__DisplayClass72_1.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400535F RID: 21343
			private static readonly IntPtr NativeFieldInfoPtr_image;

			// Token: 0x04005360 RID: 21344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005361 RID: 21345
			private static readonly IntPtr NativeMethodInfoPtr__OnBossNoteProcess_b__5_Internal_Void_Single_0;
		}

		// Token: 0x020004AB RID: 1195
		private sealed class MethodInfoStoreGeneric_Method_Private_T_T_PDM_0<T>
		{
			// Token: 0x04005362 RID: 21346
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Private_T_T_PDM_0, Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020004AC RID: 1196
		private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Void_T_PDM_0<T>
		{
			// Token: 0x04005363 RID: 21347
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DLC3_MusicGameMainPannel.NativeMethodInfoPtr_Method_Internal_Static_Void_T_PDM_0, Il2CppClassPointerStore<DLC3_MusicGameMainPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
