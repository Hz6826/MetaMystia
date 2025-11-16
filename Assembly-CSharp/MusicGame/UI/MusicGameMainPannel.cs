using System;
using Common.UI.QTEUtility;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Profile;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace MusicGame.UI
{
	// Token: 0x02000021 RID: 33
	public class MusicGameMainPannel : UISubPanel<MusicSelectorPannel>
	{
		// Token: 0x06000298 RID: 664 RVA: 0x000A7414 File Offset: 0x000A5614
		// Note: this type is marked as 'beforefieldinit'.
		static MusicGameMainPannel()
		{
			Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicGameMainPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr);
			MusicGameMainPannel.NativeFieldInfoPtr_PlayerPortrayal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "PlayerPortrayal");
			MusicGameMainPannel.NativeFieldInfoPtr_CG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "CG");
			MusicGameMainPannel.NativeFieldInfoPtr_MusicGameQTEPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "MusicGameQTEPannel");
			MusicGameMainPannel.NativeFieldInfoPtr_MusicGameQTEPannelCleanMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "MusicGameQTEPannelCleanMode");
			MusicGameMainPannel.NativeFieldInfoPtr_CountDownPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "CountDownPannel");
			MusicGameMainPannel.NativeFieldInfoPtr_PausePannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "PausePannel");
			MusicGameMainPannel.NativeFieldInfoPtr_QTEPannelField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "QTEPannelField");
			MusicGameMainPannel.NativeFieldInfoPtr_PauseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "PauseButton");
			MusicGameMainPannel.NativeFieldInfoPtr_cgPicDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "cgPicDuration");
			MusicGameMainPannel.NativeFieldInfoPtr_cgExceptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "cgExceptionLabel");
			MusicGameMainPannel.NativeFieldInfoPtr_transitDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "transitDuration");
			MusicGameMainPannel.NativeFieldInfoPtr_m_NormalModePortrayalY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "m_NormalModePortrayalY");
			MusicGameMainPannel.NativeFieldInfoPtr_m_CleanModePortrayalY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "m_CleanModePortrayalY");
			MusicGameMainPannel.NativeFieldInfoPtr_m_PlayerPortrayalFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "m_PlayerPortrayalFrame");
			MusicGameMainPannel.NativeFieldInfoPtr_m_ElementToHideOnCleanMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "m_ElementToHideOnCleanMode");
			MusicGameMainPannel.NativeFieldInfoPtr_mystiaCharacterElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "mystiaCharacterElement");
			MusicGameMainPannel.NativeFieldInfoPtr_dancingCharacterElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "dancingCharacterElement");
			MusicGameMainPannel.NativeFieldInfoPtr_characterAnimtionField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "characterAnimtionField");
			MusicGameMainPannel.NativeFieldInfoPtr_cheerGuestTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "cheerGuestTransform");
			MusicGameMainPannel.NativeFieldInfoPtr_targetCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "targetCombo");
			MusicGameMainPannel.NativeFieldInfoPtr_BottomRightComboAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "BottomRightComboAnim");
			MusicGameMainPannel.NativeFieldInfoPtr_TopLeftComboAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "TopLeftComboAnim");
			MusicGameMainPannel.NativeFieldInfoPtr_TopRightComboAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "TopRightComboAnim");
			MusicGameMainPannel.NativeFieldInfoPtr_cheerGuestImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "cheerGuestImage");
			MusicGameMainPannel.NativeFieldInfoPtr_dancingCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "dancingCharacters");
			MusicGameMainPannel.NativeFieldInfoPtr_m_LoadedHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "m_LoadedHandle");
			MusicGameMainPannel.NativeFieldInfoPtr_m_LoadedHandleCG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "m_LoadedHandleCG");
			MusicGameMainPannel.NativeFieldInfoPtr_accumulatedCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "accumulatedCombo");
			MusicGameMainPannel.NativeFieldInfoPtr_CGPictures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "CGPictures");
			MusicGameMainPannel.NativeFieldInfoPtr_cheeringGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "cheeringGuests");
			MusicGameMainPannel.NativeFieldInfoPtr_currentScoreProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "currentScoreProgress");
			MusicGameMainPannel.NativeFieldInfoPtr_firstElementFloated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "firstElementFloated");
			MusicGameMainPannel.NativeFieldInfoPtr_haveSpawnedGuestNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "haveSpawnedGuestNum");
			MusicGameMainPannel.NativeFieldInfoPtr_lastCornerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "lastCornerId");
			MusicGameMainPannel.NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "m_AnimatedPortrayalCoroutine");
			MusicGameMainPannel.NativeFieldInfoPtr_m_PauseQTETimerCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "m_PauseQTETimerCallback");
			MusicGameMainPannel.NativeFieldInfoPtr_m_PlayCGCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "m_PlayCGCoroutine");
			MusicGameMainPannel.NativeFieldInfoPtr_m_QTEPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "m_QTEPannel");
			MusicGameMainPannel.NativeFieldInfoPtr_m_ResumeQTETimerCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "m_ResumeQTETimerCallback");
			MusicGameMainPannel.NativeFieldInfoPtr_targetScoreProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "targetScoreProgress");
			MusicGameMainPannel.NativeFieldInfoPtr__PannelOpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "<PannelOpenContext>k__BackingField");
			MusicGameMainPannel.NativeFieldInfoPtr__PannelCloseContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "<PannelCloseContext>k__BackingField");
			MusicGameMainPannel.NativeFieldInfoPtr__CloseMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "<CloseMode>k__BackingField");
			MusicGameMainPannel.NativeMethodInfoPtr_get_PannelOpenContext_Private_get_MusicGameMainPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663684);
			MusicGameMainPannel.NativeMethodInfoPtr_set_PannelOpenContext_Public_set_Void_MusicGameMainPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663685);
			MusicGameMainPannel.NativeMethodInfoPtr_set_PannelCloseContext_Private_set_Void_Nullable_1_MusicFinalScoreOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663686);
			MusicGameMainPannel.NativeMethodInfoPtr_get_PannelCloseContext_Public_get_Nullable_1_MusicFinalScoreOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663687);
			MusicGameMainPannel.NativeMethodInfoPtr_get_CloseMode_Public_get_PannelCloseMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663688);
			MusicGameMainPannel.NativeMethodInfoPtr_set_CloseMode_Public_set_Void_PannelCloseMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663689);
			MusicGameMainPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663690);
			MusicGameMainPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663691);
			MusicGameMainPannel.NativeMethodInfoPtr_Pause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663692);
			MusicGameMainPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663693);
			MusicGameMainPannel.NativeMethodInfoPtr_OnPausePannelClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663694);
			MusicGameMainPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663695);
			MusicGameMainPannel.NativeMethodInfoPtr_GetCGAssetReference_Private_AssetReference_MultiLanguageCGPic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663696);
			MusicGameMainPannel.NativeMethodInfoPtr_SpawnDancingCharacter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663697);
			MusicGameMainPannel.NativeMethodInfoPtr_CheckScoreProgress_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663698);
			MusicGameMainPannel.NativeMethodInfoPtr_AddDancingCharacter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663699);
			MusicGameMainPannel.NativeMethodInfoPtr_TryChangeCharacterStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663700);
			MusicGameMainPannel.NativeMethodInfoPtr_ClearExsitedCharacter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663701);
			MusicGameMainPannel.NativeMethodInfoPtr_CheckCurrentCombo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663702);
			MusicGameMainPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663703);
			MusicGameMainPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663704);
			MusicGameMainPannel.NativeMethodInfoPtr__OnPausePannelClose_b__57_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663705);
			MusicGameMainPannel.NativeMethodInfoPtr__CheckCurrentCombo_b__65_0_Private_Boolean_ValueTuple_2_Int32_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663706);
			MusicGameMainPannel.NativeMethodInfoPtr__CheckCurrentCombo_b__65_1_Private_Boolean_ValueTuple_2_Int32_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, 100663707);
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000A7980 File Offset: 0x000A5B80
		// (set) Token: 0x0600029A RID: 666 RVA: 0x000A79B8 File Offset: 0x000A5BB8
		public unsafe MusicGameMainPannelOpenContext PannelOpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_get_PannelOpenContext_Private_get_MusicGameMainPannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new MusicGameMainPannelOpenContext(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20800, XrefRangeEnd = 20801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_set_PannelOpenContext_Public_set_Void_MusicGameMainPannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600029C RID: 668 RVA: 0x000A7A48 File Offset: 0x000A5C48
		// (set) Token: 0x0600029B RID: 667 RVA: 0x000A7A00 File Offset: 0x000A5C00
		public unsafe Nullable<MusicResultPannel.MusicFinalScoreOpenContext> PannelCloseContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_get_PannelCloseContext_Public_get_Nullable_1_MusicFinalScoreOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<MusicResultPannel.MusicFinalScoreOpenContext>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20801, XrefRangeEnd = 20802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_set_PannelCloseContext_Private_set_Void_Nullable_1_MusicFinalScoreOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600029D RID: 669 RVA: 0x000A7A80 File Offset: 0x000A5C80
		// (set) Token: 0x0600029E RID: 670 RVA: 0x000A7ABC File Offset: 0x000A5CBC
		public unsafe MusicSelectorPannel.PannelCloseMode CloseMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_get_CloseMode_Public_get_PannelCloseMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_set_CloseMode_Public_set_Void_PannelCloseMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600029F RID: 671 RVA: 0x000A7AFC File Offset: 0x000A5CFC
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMainPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000A7B44 File Offset: 0x000A5D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20802, XrefRangeEnd = 20820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMainPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000A7B80 File Offset: 0x000A5D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20820, XrefRangeEnd = 20843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_Pause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000A7BB4 File Offset: 0x000A5DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20843, XrefRangeEnd = 20881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMainPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000A7BF0 File Offset: 0x000A5DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20881, XrefRangeEnd = 20897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPausePannelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_OnPausePannelClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000A7C24 File Offset: 0x000A5E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20897, XrefRangeEnd = 21095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMainPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000A7C60 File Offset: 0x000A5E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21095, XrefRangeEnd = 21096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetReference GetCGAssetReference(RunTimeScheduler.CGPicture.MultiLanguageCGPic multiLanguageCGPic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(multiLanguageCGPic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_GetCGAssetReference_Private_AssetReference_MultiLanguageCGPic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000A7CB0 File Offset: 0x000A5EB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21182, RefRangeEnd = 21183, XrefRangeStart = 21096, XrefRangeEnd = 21182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnDancingCharacter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_SpawnDancingCharacter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000A7CE4 File Offset: 0x000A5EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21183, XrefRangeEnd = 21185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckScoreProgress(float currentScoreProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentScoreProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_CheckScoreProgress_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000A7D24 File Offset: 0x000A5F24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21211, RefRangeEnd = 21212, XrefRangeStart = 21185, XrefRangeEnd = 21211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDancingCharacter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_AddDancingCharacter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000A7D58 File Offset: 0x000A5F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21212, XrefRangeEnd = 21218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryChangeCharacterStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_TryChangeCharacterStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000A7D8C File Offset: 0x000A5F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21218, XrefRangeEnd = 21226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearExsitedCharacter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_ClearExsitedCharacter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000A7DC0 File Offset: 0x000A5FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21226, XrefRangeEnd = 21267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCurrentCombo(int currentCombo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentCombo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr_CheckCurrentCombo_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000A7E00 File Offset: 0x000A6000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21267, XrefRangeEnd = 21303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicGameMainPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000A7E3C File Offset: 0x000A603C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21303, XrefRangeEnd = 21335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicGameMainPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000A7E78 File Offset: 0x000A6078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21335, XrefRangeEnd = 21344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPausePannelClose_b__57_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr__OnPausePannelClose_b__57_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000A7EAC File Offset: 0x000A60AC
		[CallerCount(0)]
		public unsafe bool _CheckCurrentCombo_b__65_0(ValueTuple<int, Sprite> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr__CheckCurrentCombo_b__65_0_Private_Boolean_ValueTuple_2_Int32_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000A7F00 File Offset: 0x000A6100
		[CallerCount(0)]
		public unsafe bool _CheckCurrentCombo_b__65_1(ValueTuple<int, Sprite> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.NativeMethodInfoPtr__CheckCurrentCombo_b__65_1_Private_Boolean_ValueTuple_2_Int32_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000035C8 File Offset: 0x000017C8
		public MusicGameMainPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x000A7F54 File Offset: 0x000A6154
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x000035D1 File Offset: 0x000017D1
		public unsafe Image PlayerPortrayal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_PlayerPortrayal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_PlayerPortrayal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x000A7F84 File Offset: 0x000A6184
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000035F0 File Offset: 0x000017F0
		public unsafe Image CG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_CG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_CG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x000A7FB4 File Offset: 0x000A61B4
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x0000360F File Offset: 0x0000180F
		public unsafe QTEPannel MusicGameQTEPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_MusicGameQTEPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_MusicGameQTEPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x000A7FE4 File Offset: 0x000A61E4
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0000362E File Offset: 0x0000182E
		public unsafe QTEPannel MusicGameQTEPannelCleanMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_MusicGameQTEPannelCleanMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_MusicGameQTEPannelCleanMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002BA RID: 698 RVA: 0x000A8014 File Offset: 0x000A6214
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000364D File Offset: 0x0000184D
		public unsafe MusicGameCountDownPannel CountDownPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_CountDownPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameCountDownPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_CountDownPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000A8044 File Offset: 0x000A6244
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0000366C File Offset: 0x0000186C
		public unsafe MusicGamePausePannel PausePannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_PausePannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGamePausePannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_PausePannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000A8074 File Offset: 0x000A6274
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000368B File Offset: 0x0000188B
		public unsafe RectTransform QTEPannelField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_QTEPannelField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_QTEPannelField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000A80A4 File Offset: 0x000A62A4
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x000036AA File Offset: 0x000018AA
		public unsafe UIButtonSimple PauseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_PauseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_PauseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x000A80D4 File Offset: 0x000A62D4
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x000036C9 File Offset: 0x000018C9
		public unsafe float cgPicDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_cgPicDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_cgPicDuration)) = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x000A80FC File Offset: 0x000A62FC
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x000036E4 File Offset: 0x000018E4
		public unsafe Il2CppStringArray cgExceptionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_cgExceptionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_cgExceptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x000A812C File Offset: 0x000A632C
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00003703 File Offset: 0x00001903
		public unsafe float transitDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_transitDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_transitDuration)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000A8154 File Offset: 0x000A6354
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0000371E File Offset: 0x0000191E
		public unsafe float m_NormalModePortrayalY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_NormalModePortrayalY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_NormalModePortrayalY)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002CA RID: 714 RVA: 0x000A817C File Offset: 0x000A637C
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00003739 File Offset: 0x00001939
		public unsafe float m_CleanModePortrayalY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_CleanModePortrayalY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_CleanModePortrayalY)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002CC RID: 716 RVA: 0x000A81A4 File Offset: 0x000A63A4
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00003754 File Offset: 0x00001954
		public unsafe RectTransform m_PlayerPortrayalFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_PlayerPortrayalFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_PlayerPortrayalFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000A81D4 File Offset: 0x000A63D4
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00003773 File Offset: 0x00001973
		public unsafe Il2CppReferenceArray<GameObject> m_ElementToHideOnCleanMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_ElementToHideOnCleanMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_ElementToHideOnCleanMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x000A8204 File Offset: 0x000A6404
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00003792 File Offset: 0x00001992
		public unsafe GameObject mystiaCharacterElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_mystiaCharacterElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_mystiaCharacterElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x000A8234 File Offset: 0x000A6434
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x000037B1 File Offset: 0x000019B1
		public unsafe GameObject dancingCharacterElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_dancingCharacterElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_dancingCharacterElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x000A8264 File Offset: 0x000A6464
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x000037D0 File Offset: 0x000019D0
		public unsafe RectTransform characterAnimtionField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_characterAnimtionField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_characterAnimtionField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x000A8294 File Offset: 0x000A6494
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x000037EF File Offset: 0x000019EF
		public unsafe Transform cheerGuestTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_cheerGuestTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_cheerGuestTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x000A82C4 File Offset: 0x000A64C4
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0000380E File Offset: 0x00001A0E
		public unsafe int targetCombo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_targetCombo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_targetCombo)) = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000A82EC File Offset: 0x000A64EC
		// (set) Token: 0x060002DB RID: 731 RVA: 0x00003829 File Offset: 0x00001A29
		public unsafe GameObject BottomRightComboAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_BottomRightComboAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_BottomRightComboAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000A831C File Offset: 0x000A651C
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00003848 File Offset: 0x00001A48
		public unsafe GameObject TopLeftComboAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_TopLeftComboAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_TopLeftComboAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002DE RID: 734 RVA: 0x000A834C File Offset: 0x000A654C
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00003867 File Offset: 0x00001A67
		public unsafe GameObject TopRightComboAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_TopRightComboAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_TopRightComboAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x000A837C File Offset: 0x000A657C
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00003886 File Offset: 0x00001A86
		public unsafe Il2CppReferenceArray<CheerGuestSpawnMode> cheerGuestImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_cheerGuestImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CheerGuestSpawnMode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_cheerGuestImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x000A83AC File Offset: 0x000A65AC
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x000038A5 File Offset: 0x00001AA5
		public unsafe List<MusicGameMainDancingCharacterElement> dancingCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_dancingCharacters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MusicGameMainDancingCharacterElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_dancingCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x000A83DC File Offset: 0x000A65DC
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x000038C4 File Offset: 0x00001AC4
		public unsafe HashSet<AsyncOperationHandle<Sprite>> m_LoadedHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_LoadedHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<AsyncOperationHandle<Sprite>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_LoadedHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x000A840C File Offset: 0x000A660C
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x000038E3 File Offset: 0x00001AE3
		public unsafe HashSet<AsyncOperationHandle> m_LoadedHandleCG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_LoadedHandleCG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_LoadedHandleCG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x000A843C File Offset: 0x000A663C
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00003902 File Offset: 0x00001B02
		public unsafe int accumulatedCombo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_accumulatedCombo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_accumulatedCombo)) = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002EA RID: 746 RVA: 0x000A8464 File Offset: 0x000A6664
		// (set) Token: 0x060002EB RID: 747 RVA: 0x0000391D File Offset: 0x00001B1D
		public unsafe List<Sprite> CGPictures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_CGPictures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_CGPictures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002EC RID: 748 RVA: 0x000A8494 File Offset: 0x000A6694
		// (set) Token: 0x060002ED RID: 749 RVA: 0x0000393C File Offset: 0x00001B3C
		public unsafe List<ValueTuple<int, Sprite>> cheeringGuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_cheeringGuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<int, Sprite>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_cheeringGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002EE RID: 750 RVA: 0x000A84C4 File Offset: 0x000A66C4
		// (set) Token: 0x060002EF RID: 751 RVA: 0x0000395B File Offset: 0x00001B5B
		public unsafe float currentScoreProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_currentScoreProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_currentScoreProgress)) = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x000A84EC File Offset: 0x000A66EC
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00003976 File Offset: 0x00001B76
		public unsafe bool firstElementFloated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_firstElementFloated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_firstElementFloated)) = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x000A8514 File Offset: 0x000A6714
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00003991 File Offset: 0x00001B91
		public unsafe int haveSpawnedGuestNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_haveSpawnedGuestNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_haveSpawnedGuestNum)) = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x000A853C File Offset: 0x000A673C
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x000039AC File Offset: 0x00001BAC
		public unsafe int lastCornerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_lastCornerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_lastCornerId)) = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x000A8564 File Offset: 0x000A6764
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x000039C7 File Offset: 0x00001BC7
		public unsafe Coroutine m_AnimatedPortrayalCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x000A8594 File Offset: 0x000A6794
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x000039E6 File Offset: 0x00001BE6
		public unsafe Action m_PauseQTETimerCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_PauseQTETimerCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_PauseQTETimerCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002FA RID: 762 RVA: 0x000A85C4 File Offset: 0x000A67C4
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00003A05 File Offset: 0x00001C05
		public unsafe Coroutine m_PlayCGCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_PlayCGCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_PlayCGCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002FC RID: 764 RVA: 0x000A85F4 File Offset: 0x000A67F4
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00003A24 File Offset: 0x00001C24
		public unsafe QTEPannel m_QTEPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_QTEPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_QTEPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002FE RID: 766 RVA: 0x000A8624 File Offset: 0x000A6824
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00003A43 File Offset: 0x00001C43
		public unsafe Action m_ResumeQTETimerCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_ResumeQTETimerCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_m_ResumeQTETimerCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000300 RID: 768 RVA: 0x000A8654 File Offset: 0x000A6854
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00003A62 File Offset: 0x00001C62
		public unsafe int targetScoreProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_targetScoreProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr_targetScoreProgress)) = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000302 RID: 770 RVA: 0x000A867C File Offset: 0x000A687C
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00003A7D File Offset: 0x00001C7D
		public MusicGameMainPannelOpenContext _PannelOpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr__PannelOpenContext_k__BackingField);
				return new MusicGameMainPannelOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicGameMainPannelOpenContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr__PannelOpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MusicGameMainPannelOpenContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000304 RID: 772 RVA: 0x000A86AC File Offset: 0x000A68AC
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00003AAB File Offset: 0x00001CAB
		public Nullable<MusicResultPannel.MusicFinalScoreOpenContext> _PannelCloseContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr__PannelCloseContext_k__BackingField);
				return new Nullable<MusicResultPannel.MusicFinalScoreOpenContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<MusicResultPannel.MusicFinalScoreOpenContext>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr__PannelCloseContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<MusicResultPannel.MusicFinalScoreOpenContext>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000A86DC File Offset: 0x000A68DC
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00003AD9 File Offset: 0x00001CD9
		public unsafe MusicSelectorPannel.PannelCloseMode _CloseMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr__CloseMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.NativeFieldInfoPtr__CloseMode_k__BackingField)) = value;
			}
		}

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr_PlayerPortrayal;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeFieldInfoPtr_CG;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeFieldInfoPtr_MusicGameQTEPannel;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeFieldInfoPtr_MusicGameQTEPannelCleanMode;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeFieldInfoPtr_CountDownPannel;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr_PausePannel;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr_QTEPannelField;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr_PauseButton;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr_cgPicDuration;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr_cgExceptionLabel;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr_transitDuration;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalModePortrayalY;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_m_CleanModePortrayalY;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerPortrayalFrame;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementToHideOnCleanMode;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr_mystiaCharacterElement;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeFieldInfoPtr_dancingCharacterElement;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeFieldInfoPtr_characterAnimtionField;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeFieldInfoPtr_cheerGuestTransform;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeFieldInfoPtr_targetCombo;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_BottomRightComboAnim;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_TopLeftComboAnim;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_TopRightComboAnim;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_cheerGuestImage;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_dancingCharacters;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedHandle;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedHandleCG;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_accumulatedCombo;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr_CGPictures;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr_cheeringGuests;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_currentScoreProgress;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr_firstElementFloated;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_haveSpawnedGuestNum;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_lastCornerId;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatedPortrayalCoroutine;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr_m_PauseQTETimerCallback;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayCGCoroutine;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr_m_QTEPannel;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr_m_ResumeQTETimerCallback;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr_targetScoreProgress;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr__PannelOpenContext_k__BackingField;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr__PannelCloseContext_k__BackingField;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr__CloseMode_k__BackingField;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_get_PannelOpenContext_Private_get_MusicGameMainPannelOpenContext_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_set_PannelOpenContext_Public_set_Void_MusicGameMainPannelOpenContext_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_set_PannelCloseContext_Private_set_Void_Nullable_1_MusicFinalScoreOpenContext_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_get_PannelCloseContext_Public_get_Nullable_1_MusicFinalScoreOpenContext_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseMode_Public_get_PannelCloseMode_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseMode_Public_set_Void_PannelCloseMode_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Private_Void_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_OnPausePannelClose_Private_Void_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_GetCGAssetReference_Private_AssetReference_MultiLanguageCGPic_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_SpawnDancingCharacter_Private_Void_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_CheckScoreProgress_Private_Void_Single_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_AddDancingCharacter_Private_Void_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_TryChangeCharacterStatus_Private_Void_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_ClearExsitedCharacter_Public_Void_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_CheckCurrentCombo_Public_Void_Int32_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr__OnPausePannelClose_b__57_0_Private_Void_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr__CheckCurrentCombo_b__65_0_Private_Boolean_ValueTuple_2_Int32_Sprite_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr__CheckCurrentCombo_b__65_1_Private_Boolean_ValueTuple_2_Int32_Sprite_0;

		// Token: 0x02000490 RID: 1168
		[ObfuscatedName("MusicGame.UI.MusicGameMainPannel+<>c__DisplayClass58_0")]
		public sealed class __c__DisplayClass58_0 : Il2CppSystem.Object
		{
			// Token: 0x06007DA4 RID: 32164 RVA: 0x0023E440 File Offset: 0x0023C640
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_0()
			{
				Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "<>c__DisplayClass58_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr);
				MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_cleanMusicGameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, "cleanMusicGameMode");
				MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, "<>4__this");
				MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_loadCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, "loadCount");
				MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_musicDataPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, "musicDataPack");
				MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, "<>9__6");
				MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, 100663708);
				MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, 100663709);
				MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Boolean_CGPicture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, 100663710);
				MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_AsyncOperationHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, 100663711);
				MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_AsyncOperationHandle_1_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, 100663712);
				MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_AsyncOperationHandle_1_LoopedBGMPackage_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, 100663713);
				MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, 100663714);
				MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__13_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, 100663715);
				MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, 100663716);
				MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, 100663717);
			}

			// Token: 0x06007DA5 RID: 32165 RVA: 0x0023E598 File Offset: 0x0023C798
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DA6 RID: 32166 RVA: 0x0023E5D4 File Offset: 0x0023C7D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20687, XrefRangeEnd = 20689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DA7 RID: 32167 RVA: 0x0023E618 File Offset: 0x0023C818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20689, XrefRangeEnd = 20692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__4(RunTimeScheduler.CGPicture x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Boolean_CGPicture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007DA8 RID: 32168 RVA: 0x0023E66C File Offset: 0x0023C86C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20692, XrefRangeEnd = 20704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__6(AsyncOperationHandle<Sprite> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_AsyncOperationHandle_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DA9 RID: 32169 RVA: 0x0023E6B4 File Offset: 0x0023C8B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20704, XrefRangeEnd = 20712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__1(AsyncOperationHandle<LoopedBGMPackage> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_AsyncOperationHandle_1_LoopedBGMPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DAA RID: 32170 RVA: 0x0023E6FC File Offset: 0x0023C8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20712, XrefRangeEnd = 20718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_AsyncOperationHandle_1_LoopedBGMPackage_PDM_0(AsyncOperationHandle<LoopedBGMPackage> loadedPackage)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(loadedPackage));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_AsyncOperationHandle_1_LoopedBGMPackage_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007DAB RID: 32171 RVA: 0x0023E754 File Offset: 0x0023C954
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007DAC RID: 32172 RVA: 0x0023E790 File Offset: 0x0023C990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20718, XrefRangeEnd = 20720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__13()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__13_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DAD RID: 32173 RVA: 0x0023E7C4 File Offset: 0x0023C9C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20720, XrefRangeEnd = 20725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007DAE RID: 32174 RVA: 0x0023E804 File Offset: 0x0023CA04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20725, XrefRangeEnd = 20732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Single_PDM_0(float alpha)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref alpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DAF RID: 32175 RVA: 0x00043A41 File Offset: 0x00041C41
			public __c__DisplayClass58_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A7D RID: 10877
			// (get) Token: 0x06007DB0 RID: 32176 RVA: 0x0023E844 File Offset: 0x0023CA44
			// (set) Token: 0x06007DB1 RID: 32177 RVA: 0x00043A4A File Offset: 0x00041C4A
			public unsafe bool cleanMusicGameMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_cleanMusicGameMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_cleanMusicGameMode)) = value;
				}
			}

			// Token: 0x17002A7E RID: 10878
			// (get) Token: 0x06007DB2 RID: 32178 RVA: 0x0023E86C File Offset: 0x0023CA6C
			// (set) Token: 0x06007DB3 RID: 32179 RVA: 0x00043A65 File Offset: 0x00041C65
			public unsafe MusicGameMainPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMainPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A7F RID: 10879
			// (get) Token: 0x06007DB4 RID: 32180 RVA: 0x0023E89C File Offset: 0x0023CA9C
			// (set) Token: 0x06007DB5 RID: 32181 RVA: 0x00043A84 File Offset: 0x00041C84
			public unsafe int loadCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_loadCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_loadCount)) = value;
				}
			}

			// Token: 0x17002A80 RID: 10880
			// (get) Token: 0x06007DB6 RID: 32182 RVA: 0x0023E8C4 File Offset: 0x0023CAC4
			// (set) Token: 0x06007DB7 RID: 32183 RVA: 0x00043A9F File Offset: 0x00041C9F
			public MusicGameChapterProfile.MusicChapter musicDataPack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_musicDataPack);
					return new MusicGameChapterProfile.MusicChapter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_musicDataPack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MusicGameChapterProfile.MusicChapter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002A81 RID: 10881
			// (get) Token: 0x06007DB8 RID: 32184 RVA: 0x0023E8F4 File Offset: 0x0023CAF4
			// (set) Token: 0x06007DB9 RID: 32185 RVA: 0x00043ACD File Offset: 0x00041CCD
			public unsafe Action<AsyncOperationHandle<Sprite>> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<Sprite>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040052A6 RID: 21158
			private static readonly IntPtr NativeFieldInfoPtr_cleanMusicGameMode;

			// Token: 0x040052A7 RID: 21159
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040052A8 RID: 21160
			private static readonly IntPtr NativeFieldInfoPtr_loadCount;

			// Token: 0x040052A9 RID: 21161
			private static readonly IntPtr NativeFieldInfoPtr_musicDataPack;

			// Token: 0x040052AA RID: 21162
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x040052AB RID: 21163
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040052AC RID: 21164
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_GameObject_0;

			// Token: 0x040052AD RID: 21165
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Boolean_CGPicture_0;

			// Token: 0x040052AE RID: 21166
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_AsyncOperationHandle_1_Sprite_0;

			// Token: 0x040052AF RID: 21167
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_AsyncOperationHandle_1_LoopedBGMPackage_0;

			// Token: 0x040052B0 RID: 21168
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_AsyncOperationHandle_1_LoopedBGMPackage_PDM_0;

			// Token: 0x040052B1 RID: 21169
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Boolean_0;

			// Token: 0x040052B2 RID: 21170
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__13_Internal_Void_0;

			// Token: 0x040052B3 RID: 21171
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040052B4 RID: 21172
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Single_PDM_0;

			// Token: 0x02000FA5 RID: 4005
			[ObfuscatedName("MusicGame.UI.MusicGameMainPannel+<>c__DisplayClass58_0+<<OnPanelOpen>g__OnLoadFinish|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601146F RID: 70767 RVA: 0x003FA10C File Offset: 0x003F830C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique()
				{
					Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, "<<OnPanelOpen>g__OnLoadFinish|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr);
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr, "<>1__state");
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr, "<>2__current");
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr, "<>4__this");
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr_loadedPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr, "loadedPackage");
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr, "<>8__1");
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr, 100663718);
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr, 100663719);
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr, 100663720);
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr, 100663721);
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr, 100663722);
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr, 100663723);
				}

				// Token: 0x06011470 RID: 70768 RVA: 0x003FA214 File Offset: 0x003F8414
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011471 RID: 70769 RVA: 0x003FA25C File Offset: 0x003F845C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011472 RID: 70770 RVA: 0x003FA290 File Offset: 0x003F8490
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20495, XrefRangeEnd = 20637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170059CF RID: 22991
				// (get) Token: 0x06011473 RID: 70771 RVA: 0x003FA2CC File Offset: 0x003F84CC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011474 RID: 70772 RVA: 0x003FA30C File Offset: 0x003F850C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20637, XrefRangeEnd = 20643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170059D0 RID: 22992
				// (get) Token: 0x06011475 RID: 70773 RVA: 0x003FA340 File Offset: 0x003F8540
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011476 RID: 70774 RVA: 0x000964E1 File Offset: 0x000946E1
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170059CA RID: 22986
				// (get) Token: 0x06011477 RID: 70775 RVA: 0x003FA380 File Offset: 0x003F8580
				// (set) Token: 0x06011478 RID: 70776 RVA: 0x000964EA File Offset: 0x000946EA
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170059CB RID: 22987
				// (get) Token: 0x06011479 RID: 70777 RVA: 0x003FA3A8 File Offset: 0x003F85A8
				// (set) Token: 0x0601147A RID: 70778 RVA: 0x00096505 File Offset: 0x00094705
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059CC RID: 22988
				// (get) Token: 0x0601147B RID: 70779 RVA: 0x003FA3D8 File Offset: 0x003F85D8
				// (set) Token: 0x0601147C RID: 70780 RVA: 0x00096524 File Offset: 0x00094724
				public unsafe MusicGameMainPannel.__c__DisplayClass58_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMainPannel.__c__DisplayClass58_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059CD RID: 22989
				// (get) Token: 0x0601147D RID: 70781 RVA: 0x003FA408 File Offset: 0x003F8608
				// (set) Token: 0x0601147E RID: 70782 RVA: 0x00096543 File Offset: 0x00094743
				public AsyncOperationHandle<LoopedBGMPackage> loadedPackage
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr_loadedPackage);
						return new AsyncOperationHandle<LoopedBGMPackage>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<LoopedBGMPackage>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr_loadedPackage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<LoopedBGMPackage>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x170059CE RID: 22990
				// (get) Token: 0x0601147F RID: 70783 RVA: 0x003FA438 File Offset: 0x003F8638
				// (set) Token: 0x06011480 RID: 70784 RVA: 0x00096571 File Offset: 0x00094771
				public unsafe MusicGameMainPannel.__c__DisplayClass58_2 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMainPannel.__c__DisplayClass58_2>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1LoloObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AEA5 RID: 44709
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AEA6 RID: 44710
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AEA7 RID: 44711
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AEA8 RID: 44712
				private static readonly IntPtr NativeFieldInfoPtr_loadedPackage;

				// Token: 0x0400AEA9 RID: 44713
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400AEAA RID: 44714
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AEAB RID: 44715
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEAC RID: 44716
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AEAD RID: 44717
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AEAE RID: 44718
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEAF RID: 44719
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02000FA6 RID: 4006
			[ObfuscatedName("MusicGame.UI.MusicGameMainPannel+<>c__DisplayClass58_0+<<OnPanelOpen>g__ShowCG|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011481 RID: 70785 RVA: 0x003FA468 File Offset: 0x003F8668
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique()
				{
					Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0>.NativeClassPtr, "<<OnPanelOpen>g__ShowCG|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr);
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr, "<>1__state");
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr, "<>2__current");
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr, "<>4__this");
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr, "<>8__1");
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr__currentCGPic_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr, "<currentCGPic>5__2");
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr, 100663724);
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr, 100663725);
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr, 100663726);
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr, 100663727);
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr, 100663728);
					MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr, 100663729);
				}

				// Token: 0x06011482 RID: 70786 RVA: 0x003FA570 File Offset: 0x003F8770
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011483 RID: 70787 RVA: 0x003FA5B8 File Offset: 0x003F87B8
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011484 RID: 70788 RVA: 0x003FA5EC File Offset: 0x003F87EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20643, XrefRangeEnd = 20681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170059D6 RID: 22998
				// (get) Token: 0x06011485 RID: 70789 RVA: 0x003FA628 File Offset: 0x003F8828
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011486 RID: 70790 RVA: 0x003FA668 File Offset: 0x003F8868
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20681, XrefRangeEnd = 20687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170059D7 RID: 22999
				// (get) Token: 0x06011487 RID: 70791 RVA: 0x003FA69C File Offset: 0x003F889C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011488 RID: 70792 RVA: 0x00096590 File Offset: 0x00094790
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170059D1 RID: 22993
				// (get) Token: 0x06011489 RID: 70793 RVA: 0x003FA6DC File Offset: 0x003F88DC
				// (set) Token: 0x0601148A RID: 70794 RVA: 0x00096599 File Offset: 0x00094799
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170059D2 RID: 22994
				// (get) Token: 0x0601148B RID: 70795 RVA: 0x003FA704 File Offset: 0x003F8904
				// (set) Token: 0x0601148C RID: 70796 RVA: 0x000965B4 File Offset: 0x000947B4
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059D3 RID: 22995
				// (get) Token: 0x0601148D RID: 70797 RVA: 0x003FA734 File Offset: 0x003F8934
				// (set) Token: 0x0601148E RID: 70798 RVA: 0x000965D3 File Offset: 0x000947D3
				public unsafe MusicGameMainPannel.__c__DisplayClass58_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMainPannel.__c__DisplayClass58_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059D4 RID: 22996
				// (get) Token: 0x0601148F RID: 70799 RVA: 0x003FA764 File Offset: 0x003F8964
				// (set) Token: 0x06011490 RID: 70800 RVA: 0x000965F2 File Offset: 0x000947F2
				public unsafe MusicGameMainPannel.__c__DisplayClass58_3 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMainPannel.__c__DisplayClass58_3>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059D5 RID: 22997
				// (get) Token: 0x06011491 RID: 70801 RVA: 0x003FA794 File Offset: 0x003F8994
				// (set) Token: 0x06011492 RID: 70802 RVA: 0x00096611 File Offset: 0x00094811
				public unsafe Sprite _currentCGPic_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr__currentCGPic_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpObObUnique.NativeFieldInfoPtr__currentCGPic_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AEB0 RID: 44720
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AEB1 RID: 44721
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AEB2 RID: 44722
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AEB3 RID: 44723
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400AEB4 RID: 44724
				private static readonly IntPtr NativeFieldInfoPtr__currentCGPic_5__2;

				// Token: 0x0400AEB5 RID: 44725
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AEB6 RID: 44726
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEB7 RID: 44727
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AEB8 RID: 44728
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AEB9 RID: 44729
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEBA RID: 44730
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000491 RID: 1169
		[ObfuscatedName("MusicGame.UI.MusicGameMainPannel+<>c__DisplayClass58_1")]
		public sealed class __c__DisplayClass58_1 : Il2CppSystem.Object
		{
			// Token: 0x06007DBA RID: 32186 RVA: 0x0023E924 File Offset: 0x0023CB24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_1()
			{
				Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "<>c__DisplayClass58_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_1>.NativeClassPtr);
				MusicGameMainPannel.__c__DisplayClass58_1.NativeFieldInfoPtr_cornerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_1>.NativeClassPtr, "cornerId");
				MusicGameMainPannel.__c__DisplayClass58_1.NativeFieldInfoPtr_field_Public___c__DisplayClass58_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_1>.NativeClassPtr, "CS$<>8__locals1");
				MusicGameMainPannel.__c__DisplayClass58_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_1>.NativeClassPtr, 100663730);
				MusicGameMainPannel.__c__DisplayClass58_1.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_AsyncOperationHandle_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_1>.NativeClassPtr, 100663731);
			}

			// Token: 0x06007DBB RID: 32187 RVA: 0x0023E9A0 File Offset: 0x0023CBA0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DBC RID: 32188 RVA: 0x0023E9DC File Offset: 0x0023CBDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20732, XrefRangeEnd = 20745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__7(AsyncOperationHandle<Sprite> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_1.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_AsyncOperationHandle_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DBD RID: 32189 RVA: 0x00043AEC File Offset: 0x00041CEC
			public __c__DisplayClass58_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A82 RID: 10882
			// (get) Token: 0x06007DBE RID: 32190 RVA: 0x0023EA24 File Offset: 0x0023CC24
			// (set) Token: 0x06007DBF RID: 32191 RVA: 0x00043AF5 File Offset: 0x00041CF5
			public unsafe CheerGuestSpawnMode.CornerType cornerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_1.NativeFieldInfoPtr_cornerId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_1.NativeFieldInfoPtr_cornerId)) = value;
				}
			}

			// Token: 0x17002A83 RID: 10883
			// (get) Token: 0x06007DC0 RID: 32192 RVA: 0x0023EA4C File Offset: 0x0023CC4C
			// (set) Token: 0x06007DC1 RID: 32193 RVA: 0x00043B10 File Offset: 0x00041D10
			public unsafe MusicGameMainPannel.__c__DisplayClass58_0 field_Public___c__DisplayClass58_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_1.NativeFieldInfoPtr_field_Public___c__DisplayClass58_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMainPannel.__c__DisplayClass58_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_1.NativeFieldInfoPtr_field_Public___c__DisplayClass58_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040052B5 RID: 21173
			private static readonly IntPtr NativeFieldInfoPtr_cornerId;

			// Token: 0x040052B6 RID: 21174
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass58_0_0;

			// Token: 0x040052B7 RID: 21175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040052B8 RID: 21176
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_AsyncOperationHandle_1_Sprite_0;
		}

		// Token: 0x02000492 RID: 1170
		[ObfuscatedName("MusicGame.UI.MusicGameMainPannel+<>c__DisplayClass58_2")]
		public sealed class __c__DisplayClass58_2 : Il2CppSystem.Object
		{
			// Token: 0x06007DC2 RID: 32194 RVA: 0x0023EA7C File Offset: 0x0023CC7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_2()
			{
				Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "<>c__DisplayClass58_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr);
				MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_isPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, "isPaused");
				MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_pausedDSPTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, "pausedDSPTime");
				MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_dspOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, "dspOffset");
				MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_openTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, "openTime");
				MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_hasFadeAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, "hasFadeAudio");
				MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_loadedPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, "loadedPackage");
				MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_field_Public___c__DisplayClass58_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, "CS$<>8__locals2");
				MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr___9__15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, "<>9__15");
				MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, 100663732);
				MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr_Method_Internal_Int64_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, 100663733);
				MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, 100663734);
				MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, 100663735);
				MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr__OnPanelOpen_b__12_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, 100663736);
				MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr__OnPanelOpen_b__15_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, 100663737);
				MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr, 100663738);
			}

			// Token: 0x06007DC3 RID: 32195 RVA: 0x0023EBD4 File Offset: 0x0023CDD4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DC4 RID: 32196 RVA: 0x0023EC10 File Offset: 0x0023CE10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20745, XrefRangeEnd = 20747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe long Method_Internal_Int64_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr_Method_Internal_Int64_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007DC5 RID: 32197 RVA: 0x0023EC4C File Offset: 0x0023CE4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20747, XrefRangeEnd = 20748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DC6 RID: 32198 RVA: 0x0023EC80 File Offset: 0x0023CE80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20748, XrefRangeEnd = 20749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DC7 RID: 32199 RVA: 0x0023ECB4 File Offset: 0x0023CEB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20749, XrefRangeEnd = 20762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr__OnPanelOpen_b__12_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DC8 RID: 32200 RVA: 0x0023ECE8 File Offset: 0x0023CEE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20762, XrefRangeEnd = 20766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__15()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr__OnPanelOpen_b__15_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DC9 RID: 32201 RVA: 0x0023ED1C File Offset: 0x0023CF1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20766, XrefRangeEnd = 20796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DCA RID: 32202 RVA: 0x00043B2F File Offset: 0x00041D2F
			public __c__DisplayClass58_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A84 RID: 10884
			// (get) Token: 0x06007DCB RID: 32203 RVA: 0x0023ED50 File Offset: 0x0023CF50
			// (set) Token: 0x06007DCC RID: 32204 RVA: 0x00043B38 File Offset: 0x00041D38
			public unsafe bool isPaused
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_isPaused);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_isPaused)) = value;
				}
			}

			// Token: 0x17002A85 RID: 10885
			// (get) Token: 0x06007DCD RID: 32205 RVA: 0x0023ED78 File Offset: 0x0023CF78
			// (set) Token: 0x06007DCE RID: 32206 RVA: 0x00043B53 File Offset: 0x00041D53
			public unsafe double pausedDSPTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_pausedDSPTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_pausedDSPTime)) = value;
				}
			}

			// Token: 0x17002A86 RID: 10886
			// (get) Token: 0x06007DCF RID: 32207 RVA: 0x0023EDA0 File Offset: 0x0023CFA0
			// (set) Token: 0x06007DD0 RID: 32208 RVA: 0x00043B6E File Offset: 0x00041D6E
			public unsafe double dspOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_dspOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_dspOffset)) = value;
				}
			}

			// Token: 0x17002A87 RID: 10887
			// (get) Token: 0x06007DD1 RID: 32209 RVA: 0x0023EDC8 File Offset: 0x0023CFC8
			// (set) Token: 0x06007DD2 RID: 32210 RVA: 0x00043B89 File Offset: 0x00041D89
			public unsafe double openTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_openTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_openTime)) = value;
				}
			}

			// Token: 0x17002A88 RID: 10888
			// (get) Token: 0x06007DD3 RID: 32211 RVA: 0x0023EDF0 File Offset: 0x0023CFF0
			// (set) Token: 0x06007DD4 RID: 32212 RVA: 0x00043BA4 File Offset: 0x00041DA4
			public unsafe bool hasFadeAudio
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_hasFadeAudio);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_hasFadeAudio)) = value;
				}
			}

			// Token: 0x17002A89 RID: 10889
			// (get) Token: 0x06007DD5 RID: 32213 RVA: 0x0023EE18 File Offset: 0x0023D018
			// (set) Token: 0x06007DD6 RID: 32214 RVA: 0x00043BBF File Offset: 0x00041DBF
			public AsyncOperationHandle<LoopedBGMPackage> loadedPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_loadedPackage);
					return new AsyncOperationHandle<LoopedBGMPackage>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<LoopedBGMPackage>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_loadedPackage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<LoopedBGMPackage>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002A8A RID: 10890
			// (get) Token: 0x06007DD7 RID: 32215 RVA: 0x0023EE48 File Offset: 0x0023D048
			// (set) Token: 0x06007DD8 RID: 32216 RVA: 0x00043BED File Offset: 0x00041DED
			public unsafe MusicGameMainPannel.__c__DisplayClass58_0 field_Public___c__DisplayClass58_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_field_Public___c__DisplayClass58_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMainPannel.__c__DisplayClass58_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr_field_Public___c__DisplayClass58_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A8B RID: 10891
			// (get) Token: 0x06007DD9 RID: 32217 RVA: 0x0023EE78 File Offset: 0x0023D078
			// (set) Token: 0x06007DDA RID: 32218 RVA: 0x00043C0C File Offset: 0x00041E0C
			public unsafe Action __9__15
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr___9__15);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_2.NativeFieldInfoPtr___9__15), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040052B9 RID: 21177
			private static readonly IntPtr NativeFieldInfoPtr_isPaused;

			// Token: 0x040052BA RID: 21178
			private static readonly IntPtr NativeFieldInfoPtr_pausedDSPTime;

			// Token: 0x040052BB RID: 21179
			private static readonly IntPtr NativeFieldInfoPtr_dspOffset;

			// Token: 0x040052BC RID: 21180
			private static readonly IntPtr NativeFieldInfoPtr_openTime;

			// Token: 0x040052BD RID: 21181
			private static readonly IntPtr NativeFieldInfoPtr_hasFadeAudio;

			// Token: 0x040052BE RID: 21182
			private static readonly IntPtr NativeFieldInfoPtr_loadedPackage;

			// Token: 0x040052BF RID: 21183
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass58_0_0;

			// Token: 0x040052C0 RID: 21184
			private static readonly IntPtr NativeFieldInfoPtr___9__15;

			// Token: 0x040052C1 RID: 21185
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040052C2 RID: 21186
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Int64_PDM_0;

			// Token: 0x040052C3 RID: 21187
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040052C4 RID: 21188
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;

			// Token: 0x040052C5 RID: 21189
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__12_Internal_Void_0;

			// Token: 0x040052C6 RID: 21190
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__15_Internal_Void_0;

			// Token: 0x040052C7 RID: 21191
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_2;
		}

		// Token: 0x02000493 RID: 1171
		[ObfuscatedName("MusicGame.UI.MusicGameMainPannel+<>c__DisplayClass58_3")]
		public sealed class __c__DisplayClass58_3 : Il2CppSystem.Object
		{
			// Token: 0x06007DDB RID: 32219 RVA: 0x0023EEA8 File Offset: 0x0023D0A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_3()
			{
				Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "<>c__DisplayClass58_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_3>.NativeClassPtr);
				MusicGameMainPannel.__c__DisplayClass58_3.NativeFieldInfoPtr_spawnAnotherPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_3>.NativeClassPtr, "spawnAnotherPic");
				MusicGameMainPannel.__c__DisplayClass58_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_3>.NativeClassPtr, 100663739);
				MusicGameMainPannel.__c__DisplayClass58_3.NativeMethodInfoPtr__OnPanelOpen_b__16_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_3>.NativeClassPtr, 100663740);
				MusicGameMainPannel.__c__DisplayClass58_3.NativeMethodInfoPtr__OnPanelOpen_b__17_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_3>.NativeClassPtr, 100663741);
				MusicGameMainPannel.__c__DisplayClass58_3.NativeMethodInfoPtr__OnPanelOpen_b__18_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_3>.NativeClassPtr, 100663742);
				MusicGameMainPannel.__c__DisplayClass58_3.NativeMethodInfoPtr__OnPanelOpen_b__19_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_3>.NativeClassPtr, 100663743);
			}

			// Token: 0x06007DDC RID: 32220 RVA: 0x0023EF4C File Offset: 0x0023D14C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainPannel.__c__DisplayClass58_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DDD RID: 32221 RVA: 0x0023EF88 File Offset: 0x0023D188
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20796, RefRangeEnd = 20797, XrefRangeStart = 20796, XrefRangeEnd = 20796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__16()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_3.NativeMethodInfoPtr__OnPanelOpen_b__16_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007DDE RID: 32222 RVA: 0x0023EFC4 File Offset: 0x0023D1C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__17()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_3.NativeMethodInfoPtr__OnPanelOpen_b__17_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DDF RID: 32223 RVA: 0x0023EFF8 File Offset: 0x0023D1F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__18()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_3.NativeMethodInfoPtr__OnPanelOpen_b__18_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007DE0 RID: 32224 RVA: 0x0023F034 File Offset: 0x0023D234
			[CallerCount(0)]
			public unsafe void _OnPanelOpen_b__19()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c__DisplayClass58_3.NativeMethodInfoPtr__OnPanelOpen_b__19_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DE1 RID: 32225 RVA: 0x00043C2B File Offset: 0x00041E2B
			public __c__DisplayClass58_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A8C RID: 10892
			// (get) Token: 0x06007DE2 RID: 32226 RVA: 0x0023F068 File Offset: 0x0023D268
			// (set) Token: 0x06007DE3 RID: 32227 RVA: 0x00043C34 File Offset: 0x00041E34
			public unsafe bool spawnAnotherPic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_3.NativeFieldInfoPtr_spawnAnotherPic);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainPannel.__c__DisplayClass58_3.NativeFieldInfoPtr_spawnAnotherPic)) = value;
				}
			}

			// Token: 0x040052C8 RID: 21192
			private static readonly IntPtr NativeFieldInfoPtr_spawnAnotherPic;

			// Token: 0x040052C9 RID: 21193
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040052CA RID: 21194
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__16_Internal_Boolean_0;

			// Token: 0x040052CB RID: 21195
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__17_Internal_Void_0;

			// Token: 0x040052CC RID: 21196
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__18_Internal_Boolean_0;

			// Token: 0x040052CD RID: 21197
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__19_Internal_Void_0;
		}

		// Token: 0x02000494 RID: 1172
		[ObfuscatedName("MusicGame.UI.MusicGameMainPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06007DE4 RID: 32228 RVA: 0x0023F090 File Offset: 0x0023D290
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MusicGameMainPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMainPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainPannel.__c>.NativeClassPtr);
				MusicGameMainPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c>.NativeClassPtr, "<>9");
				MusicGameMainPannel.__c.NativeFieldInfoPtr___9__58_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c>.NativeClassPtr, "<>9__58_5");
				MusicGameMainPannel.__c.NativeFieldInfoPtr___9__60_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c>.NativeClassPtr, "<>9__60_0");
				MusicGameMainPannel.__c.NativeFieldInfoPtr___9__60_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainPannel.__c>.NativeClassPtr, "<>9__60_1");
				MusicGameMainPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c>.NativeClassPtr, 100663745);
				MusicGameMainPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__58_5_Internal_Boolean_MultiLanguageCGPic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c>.NativeClassPtr, 100663746);
				MusicGameMainPannel.__c.NativeMethodInfoPtr__SpawnDancingCharacter_b__60_0_Internal_String_NPCMusicRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c>.NativeClassPtr, 100663747);
				MusicGameMainPannel.__c.NativeMethodInfoPtr__SpawnDancingCharacter_b__60_1_Internal_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainPannel.__c>.NativeClassPtr, 100663748);
			}

			// Token: 0x06007DE5 RID: 32229 RVA: 0x0023F15C File Offset: 0x0023D35C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007DE6 RID: 32230 RVA: 0x0023F198 File Offset: 0x0023D398
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__58_5(RunTimeScheduler.CGPicture.MultiLanguageCGPic multiLanguageCGPic)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(multiLanguageCGPic);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__58_5_Internal_Boolean_MultiLanguageCGPic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007DE7 RID: 32231 RVA: 0x0023F1E8 File Offset: 0x0023D3E8
			[CallerCount(0)]
			public unsafe string _SpawnDancingCharacter_b__60_0(MusicGameChapterProfile.NPCMusicRank x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c.NativeMethodInfoPtr__SpawnDancingCharacter_b__60_0_Internal_String_NPCMusicRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06007DE8 RID: 32232 RVA: 0x0023F238 File Offset: 0x0023D438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20799, XrefRangeEnd = 20800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Guid _SpawnDancingCharacter_b__60_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainPannel.__c.NativeMethodInfoPtr__SpawnDancingCharacter_b__60_1_Internal_Guid_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06007DE9 RID: 32233 RVA: 0x00043C4F File Offset: 0x00041E4F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A8D RID: 10893
			// (get) Token: 0x06007DEA RID: 32234 RVA: 0x0023F288 File Offset: 0x0023D488
			// (set) Token: 0x06007DEB RID: 32235 RVA: 0x00043C58 File Offset: 0x00041E58
			public unsafe static MusicGameMainPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMainPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMainPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMainPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A8E RID: 10894
			// (get) Token: 0x06007DEC RID: 32236 RVA: 0x0023F2B0 File Offset: 0x0023D4B0
			// (set) Token: 0x06007DED RID: 32237 RVA: 0x00043C6A File Offset: 0x00041E6A
			public unsafe static Func<RunTimeScheduler.CGPicture.MultiLanguageCGPic, bool> __9__58_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMainPannel.__c.NativeFieldInfoPtr___9__58_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RunTimeScheduler.CGPicture.MultiLanguageCGPic, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMainPannel.__c.NativeFieldInfoPtr___9__58_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A8F RID: 10895
			// (get) Token: 0x06007DEE RID: 32238 RVA: 0x0023F2D8 File Offset: 0x0023D4D8
			// (set) Token: 0x06007DEF RID: 32239 RVA: 0x00043C7C File Offset: 0x00041E7C
			public unsafe static Func<MusicGameChapterProfile.NPCMusicRank, string> __9__60_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMainPannel.__c.NativeFieldInfoPtr___9__60_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MusicGameChapterProfile.NPCMusicRank, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMainPannel.__c.NativeFieldInfoPtr___9__60_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A90 RID: 10896
			// (get) Token: 0x06007DF0 RID: 32240 RVA: 0x0023F300 File Offset: 0x0023D500
			// (set) Token: 0x06007DF1 RID: 32241 RVA: 0x00043C8E File Offset: 0x00041E8E
			public unsafe static Func<string, Guid> __9__60_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMainPannel.__c.NativeFieldInfoPtr___9__60_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, Guid>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMainPannel.__c.NativeFieldInfoPtr___9__60_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040052CE RID: 21198
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040052CF RID: 21199
			private static readonly IntPtr NativeFieldInfoPtr___9__58_5;

			// Token: 0x040052D0 RID: 21200
			private static readonly IntPtr NativeFieldInfoPtr___9__60_0;

			// Token: 0x040052D1 RID: 21201
			private static readonly IntPtr NativeFieldInfoPtr___9__60_1;

			// Token: 0x040052D2 RID: 21202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040052D3 RID: 21203
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__58_5_Internal_Boolean_MultiLanguageCGPic_0;

			// Token: 0x040052D4 RID: 21204
			private static readonly IntPtr NativeMethodInfoPtr__SpawnDancingCharacter_b__60_0_Internal_String_NPCMusicRank_0;

			// Token: 0x040052D5 RID: 21205
			private static readonly IntPtr NativeMethodInfoPtr__SpawnDancingCharacter_b__60_1_Internal_Guid_String_0;
		}
	}
}
