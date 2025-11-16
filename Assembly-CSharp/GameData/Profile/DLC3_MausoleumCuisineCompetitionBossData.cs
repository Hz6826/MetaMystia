using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AssetHandleUtility;
using GameData.Core.Collections;
using GameData.RunTime.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Il2CppSystem.Runtime.CompilerServices;
using NightScene;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using NightScene.UI;
using NightScene.UI.HUDUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002F8 RID: 760
	public class DLC3_MausoleumCuisineCompetitionBossData : BossData
	{
		// Token: 0x06005AE3 RID: 23267 RVA: 0x001CE5B4 File Offset: 0x001CC7B4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC3_MausoleumCuisineCompetitionBossData()
		{
			Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DLC3_MausoleumCuisineCompetitionBossData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr);
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_P1TrackedInteractableKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "P1TrackedInteractableKey");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_P2TrackedInteractableKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "P2TrackedInteractableKey");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_finalMissionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "finalMissionKey");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_singleRoundDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "singleRoundDuration");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_izakayaIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "izakayaIndexes");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_baseFundRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "baseFundRange");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_normalGuestInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "normalGuestInterval");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_specialGuestGachaInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "specialGuestGachaInterval");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_allBosses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "allBosses");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_mystiaIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "mystiaIcon");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "offset");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_allPartnerQTERewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "allPartnerQTERewards");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_CharSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase1_CharSelect");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase1_Start");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Succeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase1_Succeed");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Succeed_Char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase1_Succeed_Char");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Failed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase1_Failed");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Failed_Char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase1_Failed_Char");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_NextEventLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase1_NextEventLabel");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_CharSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase2_CharSelect");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase2_Start");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Succeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase2_Succeed");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Succeed_Char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase2_Succeed_Char");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Failed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase2_Failed");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Failed_Char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase2_Failed_Char");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_DoubleSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase2_DoubleSucceed");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_DoubleFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase2_DoubleFailed");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_DoubleSucceed_EventLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase2_DoubleSucceed_EventLabel");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_DoubleFailed_EventLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase2_DoubleFailed_EventLabel");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_NextEventLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase2_NextEventLabel");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_CharSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase3_CharSelect");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase3_Start");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_SucceedA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase3_SucceedA");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_SucceedB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase3_SucceedB");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Add_FailedA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase3_Add_FailedA");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Add_FailedB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase3_Add_FailedB");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Failed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase3_Failed");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Failed_Char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase3_Failed_Char");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Add_Failed_Char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "m_Phase3_Add_Failed_Char");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_bossBattleEmployeeSelectorPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "bossBattleEmployeeSelectorPannel");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_bossBattleResultPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "bossBattleResultPannel");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_springMovementSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "springMovementSpeedMultiplier");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_iconDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "iconDic");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_bossMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "bossMapping");
			DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_onChallengeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "onChallengeEnd");
			DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_get_challengeTime_Private_get_ChallengeTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, 100681824);
			DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_OnPreloadGeneralChallenge_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, 100681825);
			DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_GotoBossChallengeScene_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, 100681826);
			DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_OnChallengeEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, 100681827);
			DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_P1Start_Private_IEnumerator_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, 100681828);
			DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_P1End_Private_IEnumerator_Boolean_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, 100681829);
			DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_P2Start_Private_IEnumerator_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, 100681830);
			DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_P2End_Private_IEnumerator_Boolean_Boolean_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, 100681831);
			DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_P3Start_Private_IEnumerator_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, 100681832);
			DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_P3End_Private_IEnumerator_Boolean_Boolean_Boolean_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, 100681833);
			DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_PhaseStart_Private_IEnumerator_PartnerType_CharacterSpecificDialogPackage_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, 100681834);
			DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, 100681835);
			DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, 100681836);
		}

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x06005AE4 RID: 23268 RVA: 0x001CEA6C File Offset: 0x001CCC6C
		public unsafe DLC3_MausoleumCuisineCompetitionBossData.ChallengeTime challengeTime
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 225847, RefRangeEnd = 225850, XrefRangeStart = 225845, XrefRangeEnd = 225847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_get_challengeTime_Private_get_ChallengeTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x001CEAA8 File Offset: 0x001CCCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225850, XrefRangeEnd = 225864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreloadGeneralChallenge()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_OnPreloadGeneralChallenge_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x001CEADC File Offset: 0x001CCCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225864, XrefRangeEnd = 225920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GotoBossChallengeScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_GotoBossChallengeScene_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x001CEB18 File Offset: 0x001CCD18
		[CallerCount(0)]
		public unsafe void OnChallengeEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_OnChallengeEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x001CEB4C File Offset: 0x001CCD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225920, XrefRangeEnd = 225925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator P1Start(DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectedPartnerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_P1Start_Private_IEnumerator_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x001CEB98 File Offset: 0x001CCD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225925, XrefRangeEnd = 225930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator P1End(bool isSucceed, DLC3_MausoleumCuisineCompetitionBossData.PartnerType partnerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isSucceed;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partnerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_P1End_Private_IEnumerator_Boolean_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005AEA RID: 23274 RVA: 0x001CEBF4 File Offset: 0x001CCDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225930, XrefRangeEnd = 225935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator P2Start(DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectedPartnerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_P2Start_Private_IEnumerator_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005AEB RID: 23275 RVA: 0x001CEC40 File Offset: 0x001CCE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225935, XrefRangeEnd = 225940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator P2End(bool previousSucceed, bool currentSucceed, DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref previousSucceed;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentSucceed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectedPartnerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_P2End_Private_IEnumerator_Boolean_Boolean_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x001CECA8 File Offset: 0x001CCEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225940, XrefRangeEnd = 225945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator P3Start(DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectedPartnerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_P3Start_Private_IEnumerator_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005AED RID: 23277 RVA: 0x001CECF4 File Offset: 0x001CCEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225945, XrefRangeEnd = 225950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator P3End(bool firstSucceed, bool secondSucceed, bool currentSucceed, DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref firstSucceed;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondSucceed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentSucceed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectedPartnerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_P3End_Private_IEnumerator_Boolean_Boolean_Boolean_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005AEE RID: 23278 RVA: 0x001CED6C File Offset: 0x001CCF6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 225956, RefRangeEnd = 225959, XrefRangeStart = 225950, XrefRangeEnd = 225956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PhaseStart(DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType, DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage characterSelectDialog, DialogPackage startPackage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectedPartnerType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(characterSelectDialog));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startPackage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_PhaseStart_Private_IEnumerator_PartnerType_CharacterSpecificDialogPackage_DialogPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x001CEDE4 File Offset: 0x001CCFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225959, XrefRangeEnd = 225965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x001CEE44 File Offset: 0x001CD044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225965, XrefRangeEnd = 225981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC3_MausoleumCuisineCompetitionBossData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x0003136A File Offset: 0x0002F56A
		public DLC3_MausoleumCuisineCompetitionBossData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x06005AF2 RID: 23282 RVA: 0x001CEE80 File Offset: 0x001CD080
		// (set) Token: 0x06005AF3 RID: 23283 RVA: 0x00031373 File Offset: 0x0002F573
		public unsafe static string P1TrackedInteractableKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_P1TrackedInteractableKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_P1TrackedInteractableKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x06005AF4 RID: 23284 RVA: 0x001CEEA0 File Offset: 0x001CD0A0
		// (set) Token: 0x06005AF5 RID: 23285 RVA: 0x00031385 File Offset: 0x0002F585
		public unsafe static string P2TrackedInteractableKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_P2TrackedInteractableKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_P2TrackedInteractableKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x06005AF6 RID: 23286 RVA: 0x001CEEC0 File Offset: 0x001CD0C0
		// (set) Token: 0x06005AF7 RID: 23287 RVA: 0x00031397 File Offset: 0x0002F597
		public unsafe string finalMissionKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_finalMissionKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_finalMissionKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x06005AF8 RID: 23288 RVA: 0x001CEEE8 File Offset: 0x001CD0E8
		// (set) Token: 0x06005AF9 RID: 23289 RVA: 0x000313B6 File Offset: 0x0002F5B6
		public unsafe int singleRoundDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_singleRoundDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_singleRoundDuration)) = value;
			}
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x06005AFA RID: 23290 RVA: 0x001CEF10 File Offset: 0x001CD110
		// (set) Token: 0x06005AFB RID: 23291 RVA: 0x000313D1 File Offset: 0x0002F5D1
		public unsafe Il2CppStructArray<int> izakayaIndexes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_izakayaIndexes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_izakayaIndexes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x06005AFC RID: 23292 RVA: 0x001CEF40 File Offset: 0x001CD140
		// (set) Token: 0x06005AFD RID: 23293 RVA: 0x000313F0 File Offset: 0x0002F5F0
		public unsafe Vector2Int baseFundRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_baseFundRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_baseFundRange)) = value;
			}
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x06005AFE RID: 23294 RVA: 0x001CEF68 File Offset: 0x001CD168
		// (set) Token: 0x06005AFF RID: 23295 RVA: 0x0003140B File Offset: 0x0002F60B
		public unsafe Vector2Int normalGuestInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_normalGuestInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_normalGuestInterval)) = value;
			}
		}

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x06005B00 RID: 23296 RVA: 0x001CEF90 File Offset: 0x001CD190
		// (set) Token: 0x06005B01 RID: 23297 RVA: 0x00031426 File Offset: 0x0002F626
		public unsafe float specialGuestGachaInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_specialGuestGachaInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_specialGuestGachaInterval)) = value;
			}
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x06005B02 RID: 23298 RVA: 0x001CEFB8 File Offset: 0x001CD1B8
		// (set) Token: 0x06005B03 RID: 23299 RVA: 0x00031441 File Offset: 0x0002F641
		public unsafe Il2CppReferenceArray<DLC3_MausoleumCuisineCompetitionBossData.BossMapping> allBosses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_allBosses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC3_MausoleumCuisineCompetitionBossData.BossMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_allBosses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x06005B04 RID: 23300 RVA: 0x001CEFE8 File Offset: 0x001CD1E8
		// (set) Token: 0x06005B05 RID: 23301 RVA: 0x00031460 File Offset: 0x0002F660
		public unsafe GameObject mystiaIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_mystiaIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_mystiaIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x06005B06 RID: 23302 RVA: 0x001CF018 File Offset: 0x001CD218
		// (set) Token: 0x06005B07 RID: 23303 RVA: 0x0003147F File Offset: 0x0002F67F
		public unsafe Vector2 offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x06005B08 RID: 23304 RVA: 0x001CF040 File Offset: 0x001CD240
		// (set) Token: 0x06005B09 RID: 23305 RVA: 0x0003149A File Offset: 0x0002F69A
		public unsafe Il2CppReferenceArray<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping> allPartnerQTERewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_allPartnerQTERewards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_allPartnerQTERewards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x06005B0A RID: 23306 RVA: 0x001CF070 File Offset: 0x001CD270
		// (set) Token: 0x06005B0B RID: 23307 RVA: 0x000314B9 File Offset: 0x0002F6B9
		public DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase1_CharSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_CharSelect);
				return new DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_CharSelect), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x06005B0C RID: 23308 RVA: 0x001CF0A0 File Offset: 0x001CD2A0
		// (set) Token: 0x06005B0D RID: 23309 RVA: 0x000314E7 File Offset: 0x0002F6E7
		public unsafe DialogPackage m_Phase1_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Start);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Start), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x06005B0E RID: 23310 RVA: 0x001CF0D0 File Offset: 0x001CD2D0
		// (set) Token: 0x06005B0F RID: 23311 RVA: 0x00031506 File Offset: 0x0002F706
		public unsafe DialogPackage m_Phase1_Succeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Succeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Succeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x06005B10 RID: 23312 RVA: 0x001CF100 File Offset: 0x001CD300
		// (set) Token: 0x06005B11 RID: 23313 RVA: 0x00031525 File Offset: 0x0002F725
		public DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase1_Succeed_Char
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Succeed_Char);
				return new DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Succeed_Char), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x06005B12 RID: 23314 RVA: 0x001CF130 File Offset: 0x001CD330
		// (set) Token: 0x06005B13 RID: 23315 RVA: 0x00031553 File Offset: 0x0002F753
		public unsafe DialogPackage m_Phase1_Failed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Failed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Failed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x06005B14 RID: 23316 RVA: 0x001CF160 File Offset: 0x001CD360
		// (set) Token: 0x06005B15 RID: 23317 RVA: 0x00031572 File Offset: 0x0002F772
		public DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase1_Failed_Char
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Failed_Char);
				return new DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_Failed_Char), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x06005B16 RID: 23318 RVA: 0x001CF190 File Offset: 0x001CD390
		// (set) Token: 0x06005B17 RID: 23319 RVA: 0x000315A0 File Offset: 0x0002F7A0
		public unsafe string m_Phase1_NextEventLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_NextEventLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase1_NextEventLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x06005B18 RID: 23320 RVA: 0x001CF1B8 File Offset: 0x001CD3B8
		// (set) Token: 0x06005B19 RID: 23321 RVA: 0x000315BF File Offset: 0x0002F7BF
		public DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase2_CharSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_CharSelect);
				return new DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_CharSelect), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x06005B1A RID: 23322 RVA: 0x001CF1E8 File Offset: 0x001CD3E8
		// (set) Token: 0x06005B1B RID: 23323 RVA: 0x000315ED File Offset: 0x0002F7ED
		public unsafe DialogPackage m_Phase2_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Start);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Start), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x06005B1C RID: 23324 RVA: 0x001CF218 File Offset: 0x001CD418
		// (set) Token: 0x06005B1D RID: 23325 RVA: 0x0003160C File Offset: 0x0002F80C
		public unsafe DialogPackage m_Phase2_Succeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Succeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Succeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x06005B1E RID: 23326 RVA: 0x001CF248 File Offset: 0x001CD448
		// (set) Token: 0x06005B1F RID: 23327 RVA: 0x0003162B File Offset: 0x0002F82B
		public DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase2_Succeed_Char
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Succeed_Char);
				return new DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Succeed_Char), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x06005B20 RID: 23328 RVA: 0x001CF278 File Offset: 0x001CD478
		// (set) Token: 0x06005B21 RID: 23329 RVA: 0x00031659 File Offset: 0x0002F859
		public unsafe DialogPackage m_Phase2_Failed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Failed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Failed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06005B22 RID: 23330 RVA: 0x001CF2A8 File Offset: 0x001CD4A8
		// (set) Token: 0x06005B23 RID: 23331 RVA: 0x00031678 File Offset: 0x0002F878
		public DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase2_Failed_Char
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Failed_Char);
				return new DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_Failed_Char), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x06005B24 RID: 23332 RVA: 0x001CF2D8 File Offset: 0x001CD4D8
		// (set) Token: 0x06005B25 RID: 23333 RVA: 0x000316A6 File Offset: 0x0002F8A6
		public unsafe DialogPackage m_Phase2_DoubleSucceed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_DoubleSucceed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_DoubleSucceed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x06005B26 RID: 23334 RVA: 0x001CF308 File Offset: 0x001CD508
		// (set) Token: 0x06005B27 RID: 23335 RVA: 0x000316C5 File Offset: 0x0002F8C5
		public unsafe DialogPackage m_Phase2_DoubleFailed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_DoubleFailed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_DoubleFailed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x06005B28 RID: 23336 RVA: 0x001CF338 File Offset: 0x001CD538
		// (set) Token: 0x06005B29 RID: 23337 RVA: 0x000316E4 File Offset: 0x0002F8E4
		public unsafe string m_Phase2_DoubleSucceed_EventLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_DoubleSucceed_EventLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_DoubleSucceed_EventLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x06005B2A RID: 23338 RVA: 0x001CF360 File Offset: 0x001CD560
		// (set) Token: 0x06005B2B RID: 23339 RVA: 0x00031703 File Offset: 0x0002F903
		public unsafe string m_Phase2_DoubleFailed_EventLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_DoubleFailed_EventLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_DoubleFailed_EventLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x06005B2C RID: 23340 RVA: 0x001CF388 File Offset: 0x001CD588
		// (set) Token: 0x06005B2D RID: 23341 RVA: 0x00031722 File Offset: 0x0002F922
		public unsafe string m_Phase2_NextEventLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_NextEventLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase2_NextEventLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x06005B2E RID: 23342 RVA: 0x001CF3B0 File Offset: 0x001CD5B0
		// (set) Token: 0x06005B2F RID: 23343 RVA: 0x00031741 File Offset: 0x0002F941
		public DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase3_CharSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_CharSelect);
				return new DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_CharSelect), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x06005B30 RID: 23344 RVA: 0x001CF3E0 File Offset: 0x001CD5E0
		// (set) Token: 0x06005B31 RID: 23345 RVA: 0x0003176F File Offset: 0x0002F96F
		public unsafe DialogPackage m_Phase3_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Start);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Start), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x06005B32 RID: 23346 RVA: 0x001CF410 File Offset: 0x001CD610
		// (set) Token: 0x06005B33 RID: 23347 RVA: 0x0003178E File Offset: 0x0002F98E
		public unsafe DialogPackage m_Phase3_SucceedA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_SucceedA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_SucceedA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x06005B34 RID: 23348 RVA: 0x001CF440 File Offset: 0x001CD640
		// (set) Token: 0x06005B35 RID: 23349 RVA: 0x000317AD File Offset: 0x0002F9AD
		public unsafe DialogPackage m_Phase3_SucceedB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_SucceedB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_SucceedB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x06005B36 RID: 23350 RVA: 0x001CF470 File Offset: 0x001CD670
		// (set) Token: 0x06005B37 RID: 23351 RVA: 0x000317CC File Offset: 0x0002F9CC
		public unsafe DialogPackage m_Phase3_Add_FailedA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Add_FailedA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Add_FailedA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x06005B38 RID: 23352 RVA: 0x001CF4A0 File Offset: 0x001CD6A0
		// (set) Token: 0x06005B39 RID: 23353 RVA: 0x000317EB File Offset: 0x0002F9EB
		public unsafe DialogPackage m_Phase3_Add_FailedB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Add_FailedB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Add_FailedB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x06005B3A RID: 23354 RVA: 0x001CF4D0 File Offset: 0x001CD6D0
		// (set) Token: 0x06005B3B RID: 23355 RVA: 0x0003180A File Offset: 0x0002FA0A
		public unsafe DialogPackage m_Phase3_Failed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Failed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Failed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x06005B3C RID: 23356 RVA: 0x001CF500 File Offset: 0x001CD700
		// (set) Token: 0x06005B3D RID: 23357 RVA: 0x00031829 File Offset: 0x0002FA29
		public DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase3_Failed_Char
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Failed_Char);
				return new DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Failed_Char), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06005B3E RID: 23358 RVA: 0x001CF530 File Offset: 0x001CD730
		// (set) Token: 0x06005B3F RID: 23359 RVA: 0x00031857 File Offset: 0x0002FA57
		public DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase3_Add_Failed_Char
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Add_Failed_Char);
				return new DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_m_Phase3_Add_Failed_Char), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x06005B40 RID: 23360 RVA: 0x001CF560 File Offset: 0x001CD760
		// (set) Token: 0x06005B41 RID: 23361 RVA: 0x00031885 File Offset: 0x0002FA85
		public unsafe DLC3_BossBattleEmployeeSelectorPannel bossBattleEmployeeSelectorPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_bossBattleEmployeeSelectorPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_BossBattleEmployeeSelectorPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_bossBattleEmployeeSelectorPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x06005B42 RID: 23362 RVA: 0x001CF590 File Offset: 0x001CD790
		// (set) Token: 0x06005B43 RID: 23363 RVA: 0x000318A4 File Offset: 0x0002FAA4
		public unsafe DLC3_BossBattleResultPannel bossBattleResultPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_bossBattleResultPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_BossBattleResultPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_bossBattleResultPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x06005B44 RID: 23364 RVA: 0x001CF5C0 File Offset: 0x001CD7C0
		// (set) Token: 0x06005B45 RID: 23365 RVA: 0x000318C3 File Offset: 0x0002FAC3
		public unsafe float springMovementSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_springMovementSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_springMovementSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x06005B46 RID: 23366 RVA: 0x001CF5E8 File Offset: 0x001CD7E8
		// (set) Token: 0x06005B47 RID: 23367 RVA: 0x000318DE File Offset: 0x0002FADE
		public unsafe Dictionary<int, ValueTuple<int, GameObject>> iconDic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_iconDic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<int, GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_iconDic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x06005B48 RID: 23368 RVA: 0x001CF618 File Offset: 0x001CD818
		// (set) Token: 0x06005B49 RID: 23369 RVA: 0x000318FD File Offset: 0x0002FAFD
		public unsafe Dictionary<NightSceneDirector.ChallengeType, DLC3_MausoleumCuisineCompetitionBossData.BossMapping> bossMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_bossMapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NightSceneDirector.ChallengeType, DLC3_MausoleumCuisineCompetitionBossData.BossMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_bossMapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x06005B4A RID: 23370 RVA: 0x001CF648 File Offset: 0x001CD848
		// (set) Token: 0x06005B4B RID: 23371 RVA: 0x0003191C File Offset: 0x0002FB1C
		public unsafe Action onChallengeEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_onChallengeEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.NativeFieldInfoPtr_onChallengeEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C6B RID: 15467
		private static readonly IntPtr NativeFieldInfoPtr_P1TrackedInteractableKey;

		// Token: 0x04003C6C RID: 15468
		private static readonly IntPtr NativeFieldInfoPtr_P2TrackedInteractableKey;

		// Token: 0x04003C6D RID: 15469
		private static readonly IntPtr NativeFieldInfoPtr_finalMissionKey;

		// Token: 0x04003C6E RID: 15470
		private static readonly IntPtr NativeFieldInfoPtr_singleRoundDuration;

		// Token: 0x04003C6F RID: 15471
		private static readonly IntPtr NativeFieldInfoPtr_izakayaIndexes;

		// Token: 0x04003C70 RID: 15472
		private static readonly IntPtr NativeFieldInfoPtr_baseFundRange;

		// Token: 0x04003C71 RID: 15473
		private static readonly IntPtr NativeFieldInfoPtr_normalGuestInterval;

		// Token: 0x04003C72 RID: 15474
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestGachaInterval;

		// Token: 0x04003C73 RID: 15475
		private static readonly IntPtr NativeFieldInfoPtr_allBosses;

		// Token: 0x04003C74 RID: 15476
		private static readonly IntPtr NativeFieldInfoPtr_mystiaIcon;

		// Token: 0x04003C75 RID: 15477
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x04003C76 RID: 15478
		private static readonly IntPtr NativeFieldInfoPtr_allPartnerQTERewards;

		// Token: 0x04003C77 RID: 15479
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase1_CharSelect;

		// Token: 0x04003C78 RID: 15480
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase1_Start;

		// Token: 0x04003C79 RID: 15481
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase1_Succeed;

		// Token: 0x04003C7A RID: 15482
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase1_Succeed_Char;

		// Token: 0x04003C7B RID: 15483
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase1_Failed;

		// Token: 0x04003C7C RID: 15484
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase1_Failed_Char;

		// Token: 0x04003C7D RID: 15485
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase1_NextEventLabel;

		// Token: 0x04003C7E RID: 15486
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase2_CharSelect;

		// Token: 0x04003C7F RID: 15487
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase2_Start;

		// Token: 0x04003C80 RID: 15488
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase2_Succeed;

		// Token: 0x04003C81 RID: 15489
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase2_Succeed_Char;

		// Token: 0x04003C82 RID: 15490
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase2_Failed;

		// Token: 0x04003C83 RID: 15491
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase2_Failed_Char;

		// Token: 0x04003C84 RID: 15492
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase2_DoubleSucceed;

		// Token: 0x04003C85 RID: 15493
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase2_DoubleFailed;

		// Token: 0x04003C86 RID: 15494
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase2_DoubleSucceed_EventLabel;

		// Token: 0x04003C87 RID: 15495
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase2_DoubleFailed_EventLabel;

		// Token: 0x04003C88 RID: 15496
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase2_NextEventLabel;

		// Token: 0x04003C89 RID: 15497
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase3_CharSelect;

		// Token: 0x04003C8A RID: 15498
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase3_Start;

		// Token: 0x04003C8B RID: 15499
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase3_SucceedA;

		// Token: 0x04003C8C RID: 15500
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase3_SucceedB;

		// Token: 0x04003C8D RID: 15501
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase3_Add_FailedA;

		// Token: 0x04003C8E RID: 15502
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase3_Add_FailedB;

		// Token: 0x04003C8F RID: 15503
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase3_Failed;

		// Token: 0x04003C90 RID: 15504
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase3_Failed_Char;

		// Token: 0x04003C91 RID: 15505
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase3_Add_Failed_Char;

		// Token: 0x04003C92 RID: 15506
		private static readonly IntPtr NativeFieldInfoPtr_bossBattleEmployeeSelectorPannel;

		// Token: 0x04003C93 RID: 15507
		private static readonly IntPtr NativeFieldInfoPtr_bossBattleResultPannel;

		// Token: 0x04003C94 RID: 15508
		private static readonly IntPtr NativeFieldInfoPtr_springMovementSpeedMultiplier;

		// Token: 0x04003C95 RID: 15509
		private static readonly IntPtr NativeFieldInfoPtr_iconDic;

		// Token: 0x04003C96 RID: 15510
		private static readonly IntPtr NativeFieldInfoPtr_bossMapping;

		// Token: 0x04003C97 RID: 15511
		private static readonly IntPtr NativeFieldInfoPtr_onChallengeEnd;

		// Token: 0x04003C98 RID: 15512
		private static readonly IntPtr NativeMethodInfoPtr_get_challengeTime_Private_get_ChallengeTime_0;

		// Token: 0x04003C99 RID: 15513
		private static readonly IntPtr NativeMethodInfoPtr_OnPreloadGeneralChallenge_Private_Void_0;

		// Token: 0x04003C9A RID: 15514
		private static readonly IntPtr NativeMethodInfoPtr_GotoBossChallengeScene_Public_Virtual_Void_0;

		// Token: 0x04003C9B RID: 15515
		private static readonly IntPtr NativeMethodInfoPtr_OnChallengeEnd_Private_Void_0;

		// Token: 0x04003C9C RID: 15516
		private static readonly IntPtr NativeMethodInfoPtr_P1Start_Private_IEnumerator_PartnerType_0;

		// Token: 0x04003C9D RID: 15517
		private static readonly IntPtr NativeMethodInfoPtr_P1End_Private_IEnumerator_Boolean_PartnerType_0;

		// Token: 0x04003C9E RID: 15518
		private static readonly IntPtr NativeMethodInfoPtr_P2Start_Private_IEnumerator_PartnerType_0;

		// Token: 0x04003C9F RID: 15519
		private static readonly IntPtr NativeMethodInfoPtr_P2End_Private_IEnumerator_Boolean_Boolean_PartnerType_0;

		// Token: 0x04003CA0 RID: 15520
		private static readonly IntPtr NativeMethodInfoPtr_P3Start_Private_IEnumerator_PartnerType_0;

		// Token: 0x04003CA1 RID: 15521
		private static readonly IntPtr NativeMethodInfoPtr_P3End_Private_IEnumerator_Boolean_Boolean_Boolean_PartnerType_0;

		// Token: 0x04003CA2 RID: 15522
		private static readonly IntPtr NativeMethodInfoPtr_PhaseStart_Private_IEnumerator_PartnerType_CharacterSpecificDialogPackage_DialogPackage_0;

		// Token: 0x04003CA3 RID: 15523
		private static readonly IntPtr NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0;

		// Token: 0x04003CA4 RID: 15524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CDC RID: 3292
		public enum ChallengeTime
		{
			// Token: 0x040096DB RID: 38619
			First,
			// Token: 0x040096DC RID: 38620
			Second,
			// Token: 0x040096DD RID: 38621
			Third
		}

		// Token: 0x02000CDD RID: 3293
		public enum PartnerType
		{
			// Token: 0x040096DF RID: 38623
			Mystia = -1,
			// Token: 0x040096E0 RID: 38624
			Kyouko = 14,
			// Token: 0x040096E1 RID: 38625
			Kosuzu = 18,
			// Token: 0x040096E2 RID: 38626
			Aunn
		}

		// Token: 0x02000CDE RID: 3294
		[Serializable]
		public sealed class BossMapping : ValueType
		{
			// Token: 0x0600ECAF RID: 60591 RVA: 0x003867A4 File Offset: 0x003849A4
			// Note: this type is marked as 'beforefieldinit'.
			static BossMapping()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.BossMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "BossMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.BossMapping>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData.BossMapping.NativeFieldInfoPtr_challengType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.BossMapping>.NativeClassPtr, "challengType");
				DLC3_MausoleumCuisineCompetitionBossData.BossMapping.NativeFieldInfoPtr_targetBossId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.BossMapping>.NativeClassPtr, "targetBossId");
				DLC3_MausoleumCuisineCompetitionBossData.BossMapping.NativeFieldInfoPtr_bossDeskIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.BossMapping>.NativeClassPtr, "bossDeskIcon");
				DLC3_MausoleumCuisineCompetitionBossData.BossMapping.NativeFieldInfoPtr_lockPassion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.BossMapping>.NativeClassPtr, "lockPassion");
			}

			// Token: 0x0600ECB0 RID: 60592 RVA: 0x0007EC2D File Offset: 0x0007CE2D
			public BossMapping(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600ECB1 RID: 60593 RVA: 0x0007EC36 File Offset: 0x0007CE36
			public BossMapping() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.BossMapping>.NativeClassPtr))
			{
			}

			// Token: 0x17004CF1 RID: 19697
			// (get) Token: 0x0600ECB2 RID: 60594 RVA: 0x00386820 File Offset: 0x00384A20
			// (set) Token: 0x0600ECB3 RID: 60595 RVA: 0x0007EC48 File Offset: 0x0007CE48
			public unsafe NightSceneDirector.ChallengeType challengType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.BossMapping.NativeFieldInfoPtr_challengType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.BossMapping.NativeFieldInfoPtr_challengType)) = value;
				}
			}

			// Token: 0x17004CF2 RID: 19698
			// (get) Token: 0x0600ECB4 RID: 60596 RVA: 0x00386848 File Offset: 0x00384A48
			// (set) Token: 0x0600ECB5 RID: 60597 RVA: 0x0007EC63 File Offset: 0x0007CE63
			public unsafe int targetBossId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.BossMapping.NativeFieldInfoPtr_targetBossId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.BossMapping.NativeFieldInfoPtr_targetBossId)) = value;
				}
			}

			// Token: 0x17004CF3 RID: 19699
			// (get) Token: 0x0600ECB6 RID: 60598 RVA: 0x00386870 File Offset: 0x00384A70
			// (set) Token: 0x0600ECB7 RID: 60599 RVA: 0x0007EC7E File Offset: 0x0007CE7E
			public unsafe GameObject bossDeskIcon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.BossMapping.NativeFieldInfoPtr_bossDeskIcon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.BossMapping.NativeFieldInfoPtr_bossDeskIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CF4 RID: 19700
			// (get) Token: 0x0600ECB8 RID: 60600 RVA: 0x003868A0 File Offset: 0x00384AA0
			// (set) Token: 0x0600ECB9 RID: 60601 RVA: 0x0007EC9D File Offset: 0x0007CE9D
			public unsafe int lockPassion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.BossMapping.NativeFieldInfoPtr_lockPassion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.BossMapping.NativeFieldInfoPtr_lockPassion)) = value;
				}
			}

			// Token: 0x040096E3 RID: 38627
			private static readonly IntPtr NativeFieldInfoPtr_challengType;

			// Token: 0x040096E4 RID: 38628
			private static readonly IntPtr NativeFieldInfoPtr_targetBossId;

			// Token: 0x040096E5 RID: 38629
			private static readonly IntPtr NativeFieldInfoPtr_bossDeskIcon;

			// Token: 0x040096E6 RID: 38630
			private static readonly IntPtr NativeFieldInfoPtr_lockPassion;
		}

		// Token: 0x02000CDF RID: 3295
		[Serializable]
		public sealed class PartnerAbilityMapping : ValueType
		{
			// Token: 0x0600ECBA RID: 60602 RVA: 0x003868C8 File Offset: 0x00384AC8
			// Note: this type is marked as 'beforefieldinit'.
			static PartnerAbilityMapping()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "PartnerAbilityMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_partnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>.NativeClassPtr, "partnerId");
				DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_overridePortrayal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>.NativeClassPtr, "overridePortrayal");
				DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_speedMultipier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>.NativeClassPtr, "speedMultipier");
				DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_cookSpeedMultipier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>.NativeClassPtr, "cookSpeedMultipier");
				DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_partnerAbilityReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>.NativeClassPtr, "partnerAbilityReward");
				DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>.NativeClassPtr, "offset");
				DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_partnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>.NativeClassPtr, "partnerType");
			}

			// Token: 0x0600ECBB RID: 60603 RVA: 0x0007ECB8 File Offset: 0x0007CEB8
			public PartnerAbilityMapping(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600ECBC RID: 60604 RVA: 0x0007ECC1 File Offset: 0x0007CEC1
			public PartnerAbilityMapping() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>.NativeClassPtr))
			{
			}

			// Token: 0x17004CF5 RID: 19701
			// (get) Token: 0x0600ECBD RID: 60605 RVA: 0x00386980 File Offset: 0x00384B80
			// (set) Token: 0x0600ECBE RID: 60606 RVA: 0x0007ECD3 File Offset: 0x0007CED3
			public unsafe int partnerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_partnerId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_partnerId)) = value;
				}
			}

			// Token: 0x17004CF6 RID: 19702
			// (get) Token: 0x0600ECBF RID: 60607 RVA: 0x003869A8 File Offset: 0x00384BA8
			// (set) Token: 0x0600ECC0 RID: 60608 RVA: 0x0007ECEE File Offset: 0x0007CEEE
			public unsafe Sprite overridePortrayal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_overridePortrayal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_overridePortrayal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CF7 RID: 19703
			// (get) Token: 0x0600ECC1 RID: 60609 RVA: 0x003869D8 File Offset: 0x00384BD8
			// (set) Token: 0x0600ECC2 RID: 60610 RVA: 0x0007ED0D File Offset: 0x0007CF0D
			public unsafe float speedMultipier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_speedMultipier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_speedMultipier)) = value;
				}
			}

			// Token: 0x17004CF8 RID: 19704
			// (get) Token: 0x0600ECC3 RID: 60611 RVA: 0x00386A00 File Offset: 0x00384C00
			// (set) Token: 0x0600ECC4 RID: 60612 RVA: 0x0007ED28 File Offset: 0x0007CF28
			public unsafe float cookSpeedMultipier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_cookSpeedMultipier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_cookSpeedMultipier)) = value;
				}
			}

			// Token: 0x17004CF9 RID: 19705
			// (get) Token: 0x0600ECC5 RID: 60613 RVA: 0x00386A28 File Offset: 0x00384C28
			// (set) Token: 0x0600ECC6 RID: 60614 RVA: 0x0007ED43 File Offset: 0x0007CF43
			public unsafe QTEBuffReward partnerAbilityReward
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_partnerAbilityReward);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTEBuffReward>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_partnerAbilityReward), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CFA RID: 19706
			// (get) Token: 0x0600ECC7 RID: 60615 RVA: 0x00386A58 File Offset: 0x00384C58
			// (set) Token: 0x0600ECC8 RID: 60616 RVA: 0x0007ED62 File Offset: 0x0007CF62
			public unsafe Vector2 offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17004CFB RID: 19707
			// (get) Token: 0x0600ECC9 RID: 60617 RVA: 0x00386A80 File Offset: 0x00384C80
			// (set) Token: 0x0600ECCA RID: 60618 RVA: 0x0007ED7D File Offset: 0x0007CF7D
			public unsafe DLC3_MausoleumCuisineCompetitionBossData.PartnerType partnerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_partnerType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping.NativeFieldInfoPtr_partnerType)) = value;
				}
			}

			// Token: 0x040096E7 RID: 38631
			private static readonly IntPtr NativeFieldInfoPtr_partnerId;

			// Token: 0x040096E8 RID: 38632
			private static readonly IntPtr NativeFieldInfoPtr_overridePortrayal;

			// Token: 0x040096E9 RID: 38633
			private static readonly IntPtr NativeFieldInfoPtr_speedMultipier;

			// Token: 0x040096EA RID: 38634
			private static readonly IntPtr NativeFieldInfoPtr_cookSpeedMultipier;

			// Token: 0x040096EB RID: 38635
			private static readonly IntPtr NativeFieldInfoPtr_partnerAbilityReward;

			// Token: 0x040096EC RID: 38636
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040096ED RID: 38637
			private static readonly IntPtr NativeFieldInfoPtr_partnerType;
		}

		// Token: 0x02000CE0 RID: 3296
		[Serializable]
		public sealed class CharacterSpecificDialogPackage : ValueType
		{
			// Token: 0x0600ECCB RID: 60619 RVA: 0x00386AA8 File Offset: 0x00384CA8
			// Note: this type is marked as 'beforefieldinit'.
			static CharacterSpecificDialogPackage()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "CharacterSpecificDialogPackage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage.NativeFieldInfoPtr_Mystia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, "Mystia");
				DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage.NativeFieldInfoPtr_Kosuzu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, "Kosuzu");
				DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage.NativeFieldInfoPtr_Aunn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, "Aunn");
				DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage.NativeMethodInfoPtr_PlayDialog_Public_IEnumerator_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, 100681837);
			}

			// Token: 0x0600ECCC RID: 60620 RVA: 0x00386B24 File Offset: 0x00384D24
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 224670, RefRangeEnd = 224671, XrefRangeStart = 224665, XrefRangeEnd = 224670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator PlayDialog(DLC3_MausoleumCuisineCompetitionBossData.PartnerType partnerType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref partnerType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage.NativeMethodInfoPtr_PlayDialog_Public_IEnumerator_PartnerType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600ECCD RID: 60621 RVA: 0x0007ED98 File Offset: 0x0007CF98
			public CharacterSpecificDialogPackage(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600ECCE RID: 60622 RVA: 0x0007EDA1 File Offset: 0x0007CFA1
			public CharacterSpecificDialogPackage() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr))
			{
			}

			// Token: 0x17004CFC RID: 19708
			// (get) Token: 0x0600ECCF RID: 60623 RVA: 0x00386B78 File Offset: 0x00384D78
			// (set) Token: 0x0600ECD0 RID: 60624 RVA: 0x0007EDB3 File Offset: 0x0007CFB3
			public unsafe DialogPackage Mystia
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage.NativeFieldInfoPtr_Mystia);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage.NativeFieldInfoPtr_Mystia), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CFD RID: 19709
			// (get) Token: 0x0600ECD1 RID: 60625 RVA: 0x00386BA8 File Offset: 0x00384DA8
			// (set) Token: 0x0600ECD2 RID: 60626 RVA: 0x0007EDD2 File Offset: 0x0007CFD2
			public unsafe DialogPackage Kosuzu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage.NativeFieldInfoPtr_Kosuzu);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage.NativeFieldInfoPtr_Kosuzu), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CFE RID: 19710
			// (get) Token: 0x0600ECD3 RID: 60627 RVA: 0x00386BD8 File Offset: 0x00384DD8
			// (set) Token: 0x0600ECD4 RID: 60628 RVA: 0x0007EDF1 File Offset: 0x0007CFF1
			public unsafe DialogPackage Aunn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage.NativeFieldInfoPtr_Aunn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage.NativeFieldInfoPtr_Aunn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096EE RID: 38638
			private static readonly IntPtr NativeFieldInfoPtr_Mystia;

			// Token: 0x040096EF RID: 38639
			private static readonly IntPtr NativeFieldInfoPtr_Kosuzu;

			// Token: 0x040096F0 RID: 38640
			private static readonly IntPtr NativeFieldInfoPtr_Aunn;

			// Token: 0x040096F1 RID: 38641
			private static readonly IntPtr NativeMethodInfoPtr_PlayDialog_Public_IEnumerator_PartnerType_0;

			// Token: 0x0200107C RID: 4220
			[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+CharacterSpecificDialogPackage+<PlayDialog>d__3")]
			public sealed class _PlayDialog_d__3 : Il2CppSystem.Object
			{
				// Token: 0x06011FBA RID: 73658 RVA: 0x0041BF34 File Offset: 0x0041A134
				// Note: this type is marked as 'beforefieldinit'.
				static _PlayDialog_d__3()
				{
					Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, "<PlayDialog>d__3");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3>.NativeClassPtr);
					DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3>.NativeClassPtr, "<>1__state");
					DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3>.NativeClassPtr, "<>2__current");
					DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeFieldInfoPtr_partnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3>.NativeClassPtr, "partnerType");
					DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3>.NativeClassPtr, "<>4__this");
					DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3>.NativeClassPtr, 100681838);
					DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3>.NativeClassPtr, 100681839);
					DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3>.NativeClassPtr, 100681840);
					DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3>.NativeClassPtr, 100681841);
					DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3>.NativeClassPtr, 100681842);
					DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3>.NativeClassPtr, 100681843);
				}

				// Token: 0x06011FBB RID: 73659 RVA: 0x0041C028 File Offset: 0x0041A228
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _PlayDialog_d__3(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011FBC RID: 73660 RVA: 0x0041C070 File Offset: 0x0041A270
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011FBD RID: 73661 RVA: 0x0041C0A4 File Offset: 0x0041A2A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224658, XrefRangeEnd = 224659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DD1 RID: 24017
				// (get) Token: 0x06011FBE RID: 73662 RVA: 0x0041C0E0 File Offset: 0x0041A2E0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011FBF RID: 73663 RVA: 0x0041C120 File Offset: 0x0041A320
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224659, XrefRangeEnd = 224665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DD2 RID: 24018
				// (get) Token: 0x06011FC0 RID: 73664 RVA: 0x0041C154 File Offset: 0x0041A354
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011FC1 RID: 73665 RVA: 0x0009C339 File Offset: 0x0009A539
				public _PlayDialog_d__3(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DCD RID: 24013
				// (get) Token: 0x06011FC2 RID: 73666 RVA: 0x0041C194 File Offset: 0x0041A394
				// (set) Token: 0x06011FC3 RID: 73667 RVA: 0x0009C342 File Offset: 0x0009A542
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DCE RID: 24014
				// (get) Token: 0x06011FC4 RID: 73668 RVA: 0x0041C1BC File Offset: 0x0041A3BC
				// (set) Token: 0x06011FC5 RID: 73669 RVA: 0x0009C35D File Offset: 0x0009A55D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DCF RID: 24015
				// (get) Token: 0x06011FC6 RID: 73670 RVA: 0x0041C1EC File Offset: 0x0041A3EC
				// (set) Token: 0x06011FC7 RID: 73671 RVA: 0x0009C37C File Offset: 0x0009A57C
				public unsafe DLC3_MausoleumCuisineCompetitionBossData.PartnerType partnerType
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeFieldInfoPtr_partnerType);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeFieldInfoPtr_partnerType)) = value;
					}
				}

				// Token: 0x17005DD0 RID: 24016
				// (get) Token: 0x06011FC8 RID: 73672 RVA: 0x0041C214 File Offset: 0x0041A414
				// (set) Token: 0x06011FC9 RID: 73673 RVA: 0x0009C397 File Offset: 0x0009A597
				public DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeFieldInfoPtr___4__this);
						return new DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage._PlayDialog_d__3.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B639 RID: 46649
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B63A RID: 46650
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B63B RID: 46651
				private static readonly IntPtr NativeFieldInfoPtr_partnerType;

				// Token: 0x0400B63C RID: 46652
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B63D RID: 46653
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B63E RID: 46654
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B63F RID: 46655
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B640 RID: 46656
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B641 RID: 46657
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B642 RID: 46658
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000CE1 RID: 3297
		[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<>c__DisplayClass49_0")]
		public sealed class __c__DisplayClass49_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ECD5 RID: 60629 RVA: 0x00386C08 File Offset: 0x00384E08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass49_0()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "<>c__DisplayClass49_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0.NativeFieldInfoPtr_foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0>.NativeClassPtr, "foods");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0.NativeFieldInfoPtr_bevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0>.NativeClassPtr, "bevs");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0.NativeFieldInfoPtr_ings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0>.NativeClassPtr, "ings");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0>.NativeClassPtr, 100681844);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0>.NativeClassPtr, 100681845);
			}

			// Token: 0x0600ECD6 RID: 60630 RVA: 0x00386C98 File Offset: 0x00384E98
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass49_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECD7 RID: 60631 RVA: 0x00386CD4 File Offset: 0x00384ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPreloadGeneralChallenge_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECD8 RID: 60632 RVA: 0x0007EE10 File Offset: 0x0007D010
			public __c__DisplayClass49_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CFF RID: 19711
			// (get) Token: 0x0600ECD9 RID: 60633 RVA: 0x00386D08 File Offset: 0x00384F08
			// (set) Token: 0x0600ECDA RID: 60634 RVA: 0x0007EE19 File Offset: 0x0007D019
			public unsafe IEnumerable<KeyValuePair<int, int>> foods
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0.NativeFieldInfoPtr_foods);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0.NativeFieldInfoPtr_foods), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D00 RID: 19712
			// (get) Token: 0x0600ECDB RID: 60635 RVA: 0x00386D38 File Offset: 0x00384F38
			// (set) Token: 0x0600ECDC RID: 60636 RVA: 0x0007EE38 File Offset: 0x0007D038
			public unsafe IEnumerable<KeyValuePair<int, int>> bevs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0.NativeFieldInfoPtr_bevs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0.NativeFieldInfoPtr_bevs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D01 RID: 19713
			// (get) Token: 0x0600ECDD RID: 60637 RVA: 0x00386D68 File Offset: 0x00384F68
			// (set) Token: 0x0600ECDE RID: 60638 RVA: 0x0007EE57 File Offset: 0x0007D057
			public unsafe IEnumerable<KeyValuePair<int, int>> ings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0.NativeFieldInfoPtr_ings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass49_0.NativeFieldInfoPtr_ings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096F2 RID: 38642
			private static readonly IntPtr NativeFieldInfoPtr_foods;

			// Token: 0x040096F3 RID: 38643
			private static readonly IntPtr NativeFieldInfoPtr_bevs;

			// Token: 0x040096F4 RID: 38644
			private static readonly IntPtr NativeFieldInfoPtr_ings;

			// Token: 0x040096F5 RID: 38645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096F6 RID: 38646
			private static readonly IntPtr NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__0_Internal_Void_0;
		}

		// Token: 0x02000CE2 RID: 3298
		[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600ECDF RID: 60639 RVA: 0x00386D98 File Offset: 0x00384F98
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__50_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__50_0");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_0");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_33");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_8");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_9");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_10");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_11");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_12");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_16");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_17");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_18");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_19");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_20");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_21");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_22");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, "<>9__59_23");
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681847);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__GotoBossChallengeScene_b__50_0_Internal_ChallengeType_BossMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681848);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_0_Internal_ChallengeType_BossMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681849);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_33_Internal_Int32_BossMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681850);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_8_Internal_Int32_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681851);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_9_Internal_SpecialGuestGroup_IGrouping_2_Int32_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681852);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_10_Internal_IEnumerable_1_NormalGuestGroup_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681853);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_11_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681854);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_12_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681855);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_16_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681856);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_17_Internal_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681857);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_18_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681858);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_19_Internal_KeyValuePair_2_Int32_Int32_IGrouping_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681859);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_20_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681860);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_21_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681861);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_22_Internal_KeyValuePair_2_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681862);
				DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_23_Internal_Int32_PartnerAbilityMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr, 100681863);
			}

			// Token: 0x0600ECE0 RID: 60640 RVA: 0x0038706C File Offset: 0x0038526C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECE1 RID: 60641 RVA: 0x003870A8 File Offset: 0x003852A8
			[CallerCount(0)]
			public unsafe NightSceneDirector.ChallengeType _GotoBossChallengeScene_b__50_0(DLC3_MausoleumCuisineCompetitionBossData.BossMapping x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__GotoBossChallengeScene_b__50_0_Internal_ChallengeType_BossMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ECE2 RID: 60642 RVA: 0x003870FC File Offset: 0x003852FC
			[CallerCount(0)]
			public unsafe NightSceneDirector.ChallengeType _MainChallengeLoop_b__59_0(DLC3_MausoleumCuisineCompetitionBossData.BossMapping x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_0_Internal_ChallengeType_BossMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ECE3 RID: 60643 RVA: 0x00387150 File Offset: 0x00385350
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__59_33(DLC3_MausoleumCuisineCompetitionBossData.BossMapping z)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(z));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_33_Internal_Int32_BossMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ECE4 RID: 60644 RVA: 0x003871A4 File Offset: 0x003853A4
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__59_8(Izakaya.SpecialGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_8_Internal_Int32_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ECE5 RID: 60645 RVA: 0x003871F4 File Offset: 0x003853F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224671, XrefRangeEnd = 224674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Izakaya.SpecialGuestGroup _MainChallengeLoop_b__59_9(IGrouping<int, Izakaya.SpecialGuestGroup> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_9_Internal_SpecialGuestGroup_IGrouping_2_Int32_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Izakaya.SpecialGuestGroup>(intPtr3) : null;
			}

			// Token: 0x0600ECE6 RID: 60646 RVA: 0x00387244 File Offset: 0x00385444
			[CallerCount(0)]
			public unsafe IEnumerable<Izakaya.NormalGuestGroup> _MainChallengeLoop_b__59_10(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_10_Internal_IEnumerable_1_NormalGuestGroup_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Izakaya.NormalGuestGroup>>(intPtr3) : null;
			}

			// Token: 0x0600ECE7 RID: 60647 RVA: 0x00387294 File Offset: 0x00385494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224674, XrefRangeEnd = 224678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__59_11(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_11_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ECE8 RID: 60648 RVA: 0x003872E0 File Offset: 0x003854E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224678, XrefRangeEnd = 224682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__59_12(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_12_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ECE9 RID: 60649 RVA: 0x0038732C File Offset: 0x0038552C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__59_16(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_16_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ECEA RID: 60650 RVA: 0x00387378 File Offset: 0x00385578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224682, XrefRangeEnd = 224685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _MainChallengeLoop_b__59_17(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_17_Internal_IEnumerable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600ECEB RID: 60651 RVA: 0x003873C4 File Offset: 0x003855C4
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__59_18(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_18_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ECEC RID: 60652 RVA: 0x00387410 File Offset: 0x00385610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224685, XrefRangeEnd = 224694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<int, int> _MainChallengeLoop_b__59_19(IGrouping<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_19_Internal_KeyValuePair_2_Int32_Int32_IGrouping_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<int, int>(pointer);
			}

			// Token: 0x0600ECED RID: 60653 RVA: 0x00387458 File Offset: 0x00385658
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__59_20(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_20_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ECEE RID: 60654 RVA: 0x003874A8 File Offset: 0x003856A8
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__59_21(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_21_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ECEF RID: 60655 RVA: 0x003874F4 File Offset: 0x003856F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224694, XrefRangeEnd = 224697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<int, int> _MainChallengeLoop_b__59_22(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_22_Internal_KeyValuePair_2_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<int, int>(pointer);
			}

			// Token: 0x0600ECF0 RID: 60656 RVA: 0x00387538 File Offset: 0x00385738
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__59_23(DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__59_23_Internal_Int32_PartnerAbilityMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600ECF1 RID: 60657 RVA: 0x0007EE76 File Offset: 0x0007D076
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D02 RID: 19714
			// (get) Token: 0x0600ECF2 RID: 60658 RVA: 0x0038758C File Offset: 0x0038578C
			// (set) Token: 0x0600ECF3 RID: 60659 RVA: 0x0007EE7F File Offset: 0x0007D07F
			public unsafe static DLC3_MausoleumCuisineCompetitionBossData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MausoleumCuisineCompetitionBossData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D03 RID: 19715
			// (get) Token: 0x0600ECF4 RID: 60660 RVA: 0x003875B4 File Offset: 0x003857B4
			// (set) Token: 0x0600ECF5 RID: 60661 RVA: 0x0007EE91 File Offset: 0x0007D091
			public unsafe static Func<DLC3_MausoleumCuisineCompetitionBossData.BossMapping, NightSceneDirector.ChallengeType> __9__50_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__50_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC3_MausoleumCuisineCompetitionBossData.BossMapping, NightSceneDirector.ChallengeType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__50_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D04 RID: 19716
			// (get) Token: 0x0600ECF6 RID: 60662 RVA: 0x003875DC File Offset: 0x003857DC
			// (set) Token: 0x0600ECF7 RID: 60663 RVA: 0x0007EEA3 File Offset: 0x0007D0A3
			public unsafe static Func<DLC3_MausoleumCuisineCompetitionBossData.BossMapping, NightSceneDirector.ChallengeType> __9__59_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC3_MausoleumCuisineCompetitionBossData.BossMapping, NightSceneDirector.ChallengeType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D05 RID: 19717
			// (get) Token: 0x0600ECF8 RID: 60664 RVA: 0x00387604 File Offset: 0x00385804
			// (set) Token: 0x0600ECF9 RID: 60665 RVA: 0x0007EEB5 File Offset: 0x0007D0B5
			public unsafe static Func<DLC3_MausoleumCuisineCompetitionBossData.BossMapping, int> __9__59_33
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_33, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC3_MausoleumCuisineCompetitionBossData.BossMapping, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_33, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D06 RID: 19718
			// (get) Token: 0x0600ECFA RID: 60666 RVA: 0x0038762C File Offset: 0x0038582C
			// (set) Token: 0x0600ECFB RID: 60667 RVA: 0x0007EEC7 File Offset: 0x0007D0C7
			public unsafe static Func<Izakaya.SpecialGuestGroup, int> __9__59_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.SpecialGuestGroup, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D07 RID: 19719
			// (get) Token: 0x0600ECFC RID: 60668 RVA: 0x00387654 File Offset: 0x00385854
			// (set) Token: 0x0600ECFD RID: 60669 RVA: 0x0007EED9 File Offset: 0x0007D0D9
			public unsafe static Func<IGrouping<int, Izakaya.SpecialGuestGroup>, Izakaya.SpecialGuestGroup> __9__59_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, Izakaya.SpecialGuestGroup>, Izakaya.SpecialGuestGroup>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D08 RID: 19720
			// (get) Token: 0x0600ECFE RID: 60670 RVA: 0x0038767C File Offset: 0x0038587C
			// (set) Token: 0x0600ECFF RID: 60671 RVA: 0x0007EEEB File Offset: 0x0007D0EB
			public unsafe static Func<Izakaya, IEnumerable<Izakaya.NormalGuestGroup>> __9__59_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya, IEnumerable<Izakaya.NormalGuestGroup>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D09 RID: 19721
			// (get) Token: 0x0600ED00 RID: 60672 RVA: 0x003876A4 File Offset: 0x003858A4
			// (set) Token: 0x0600ED01 RID: 60673 RVA: 0x0007EEFD File Offset: 0x0007D0FD
			public unsafe static Func<int, bool> __9__59_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D0A RID: 19722
			// (get) Token: 0x0600ED02 RID: 60674 RVA: 0x003876CC File Offset: 0x003858CC
			// (set) Token: 0x0600ED03 RID: 60675 RVA: 0x0007EF0F File Offset: 0x0007D10F
			public unsafe static Func<int, bool> __9__59_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D0B RID: 19723
			// (get) Token: 0x0600ED04 RID: 60676 RVA: 0x003876F4 File Offset: 0x003858F4
			// (set) Token: 0x0600ED05 RID: 60677 RVA: 0x0007EF21 File Offset: 0x0007D121
			public unsafe static Func<int, bool> __9__59_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D0C RID: 19724
			// (get) Token: 0x0600ED06 RID: 60678 RVA: 0x0038771C File Offset: 0x0038591C
			// (set) Token: 0x0600ED07 RID: 60679 RVA: 0x0007EF33 File Offset: 0x0007D133
			public unsafe static Func<int, IEnumerable<int>> __9__59_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D0D RID: 19725
			// (get) Token: 0x0600ED08 RID: 60680 RVA: 0x00387744 File Offset: 0x00385944
			// (set) Token: 0x0600ED09 RID: 60681 RVA: 0x0007EF45 File Offset: 0x0007D145
			public unsafe static Func<int, int> __9__59_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D0E RID: 19726
			// (get) Token: 0x0600ED0A RID: 60682 RVA: 0x0038776C File Offset: 0x0038596C
			// (set) Token: 0x0600ED0B RID: 60683 RVA: 0x0007EF57 File Offset: 0x0007D157
			public unsafe static Func<IGrouping<int, int>, KeyValuePair<int, int>> __9__59_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<int, int>, KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D0F RID: 19727
			// (get) Token: 0x0600ED0C RID: 60684 RVA: 0x00387794 File Offset: 0x00385994
			// (set) Token: 0x0600ED0D RID: 60685 RVA: 0x0007EF69 File Offset: 0x0007D169
			public unsafe static Func<Sellable, int> __9__59_20
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_20, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_20, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D10 RID: 19728
			// (get) Token: 0x0600ED0E RID: 60686 RVA: 0x003877BC File Offset: 0x003859BC
			// (set) Token: 0x0600ED0F RID: 60687 RVA: 0x0007EF7B File Offset: 0x0007D17B
			public unsafe static Func<int, bool> __9__59_21
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_21, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_21, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D11 RID: 19729
			// (get) Token: 0x0600ED10 RID: 60688 RVA: 0x003877E4 File Offset: 0x003859E4
			// (set) Token: 0x0600ED11 RID: 60689 RVA: 0x0007EF8D File Offset: 0x0007D18D
			public unsafe static Func<int, KeyValuePair<int, int>> __9__59_22
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_22, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_22, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D12 RID: 19730
			// (get) Token: 0x0600ED12 RID: 60690 RVA: 0x0038780C File Offset: 0x00385A0C
			// (set) Token: 0x0600ED13 RID: 60691 RVA: 0x0007EF9F File Offset: 0x0007D19F
			public unsafe static Func<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping, int> __9__59_23
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_23, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC3_MausoleumCuisineCompetitionBossData.__c.NativeFieldInfoPtr___9__59_23, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096F7 RID: 38647
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040096F8 RID: 38648
			private static readonly IntPtr NativeFieldInfoPtr___9__50_0;

			// Token: 0x040096F9 RID: 38649
			private static readonly IntPtr NativeFieldInfoPtr___9__59_0;

			// Token: 0x040096FA RID: 38650
			private static readonly IntPtr NativeFieldInfoPtr___9__59_33;

			// Token: 0x040096FB RID: 38651
			private static readonly IntPtr NativeFieldInfoPtr___9__59_8;

			// Token: 0x040096FC RID: 38652
			private static readonly IntPtr NativeFieldInfoPtr___9__59_9;

			// Token: 0x040096FD RID: 38653
			private static readonly IntPtr NativeFieldInfoPtr___9__59_10;

			// Token: 0x040096FE RID: 38654
			private static readonly IntPtr NativeFieldInfoPtr___9__59_11;

			// Token: 0x040096FF RID: 38655
			private static readonly IntPtr NativeFieldInfoPtr___9__59_12;

			// Token: 0x04009700 RID: 38656
			private static readonly IntPtr NativeFieldInfoPtr___9__59_16;

			// Token: 0x04009701 RID: 38657
			private static readonly IntPtr NativeFieldInfoPtr___9__59_17;

			// Token: 0x04009702 RID: 38658
			private static readonly IntPtr NativeFieldInfoPtr___9__59_18;

			// Token: 0x04009703 RID: 38659
			private static readonly IntPtr NativeFieldInfoPtr___9__59_19;

			// Token: 0x04009704 RID: 38660
			private static readonly IntPtr NativeFieldInfoPtr___9__59_20;

			// Token: 0x04009705 RID: 38661
			private static readonly IntPtr NativeFieldInfoPtr___9__59_21;

			// Token: 0x04009706 RID: 38662
			private static readonly IntPtr NativeFieldInfoPtr___9__59_22;

			// Token: 0x04009707 RID: 38663
			private static readonly IntPtr NativeFieldInfoPtr___9__59_23;

			// Token: 0x04009708 RID: 38664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009709 RID: 38665
			private static readonly IntPtr NativeMethodInfoPtr__GotoBossChallengeScene_b__50_0_Internal_ChallengeType_BossMapping_0;

			// Token: 0x0400970A RID: 38666
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_0_Internal_ChallengeType_BossMapping_0;

			// Token: 0x0400970B RID: 38667
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_33_Internal_Int32_BossMapping_0;

			// Token: 0x0400970C RID: 38668
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_8_Internal_Int32_SpecialGuestGroup_0;

			// Token: 0x0400970D RID: 38669
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_9_Internal_SpecialGuestGroup_IGrouping_2_Int32_SpecialGuestGroup_0;

			// Token: 0x0400970E RID: 38670
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_10_Internal_IEnumerable_1_NormalGuestGroup_Izakaya_0;

			// Token: 0x0400970F RID: 38671
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_11_Internal_Boolean_Int32_0;

			// Token: 0x04009710 RID: 38672
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_12_Internal_Boolean_Int32_0;

			// Token: 0x04009711 RID: 38673
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_16_Internal_Boolean_Int32_0;

			// Token: 0x04009712 RID: 38674
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_17_Internal_IEnumerable_1_Int32_Int32_0;

			// Token: 0x04009713 RID: 38675
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_18_Internal_Int32_Int32_0;

			// Token: 0x04009714 RID: 38676
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_19_Internal_KeyValuePair_2_Int32_Int32_IGrouping_2_Int32_Int32_0;

			// Token: 0x04009715 RID: 38677
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_20_Internal_Int32_Sellable_0;

			// Token: 0x04009716 RID: 38678
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_21_Internal_Boolean_Int32_0;

			// Token: 0x04009717 RID: 38679
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_22_Internal_KeyValuePair_2_Int32_Int32_Int32_0;

			// Token: 0x04009718 RID: 38680
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_23_Internal_Int32_PartnerAbilityMapping_0;
		}

		// Token: 0x02000CE3 RID: 3299
		[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<P1Start>d__52")]
		public sealed class _P1Start_d__52 : Il2CppSystem.Object
		{
			// Token: 0x0600ED14 RID: 60692 RVA: 0x00387834 File Offset: 0x00385A34
			// Note: this type is marked as 'beforefieldinit'.
			static _P1Start_d__52()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "<P1Start>d__52");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52>.NativeClassPtr, "<>1__state");
				DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52>.NativeClassPtr, "<>2__current");
				DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52>.NativeClassPtr, "<>4__this");
				DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeFieldInfoPtr_selectedPartnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52>.NativeClassPtr, "selectedPartnerType");
				DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52>.NativeClassPtr, 100681864);
				DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52>.NativeClassPtr, 100681865);
				DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52>.NativeClassPtr, 100681866);
				DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52>.NativeClassPtr, 100681867);
				DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52>.NativeClassPtr, 100681868);
				DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52>.NativeClassPtr, 100681869);
			}

			// Token: 0x0600ED15 RID: 60693 RVA: 0x00387928 File Offset: 0x00385B28
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _P1Start_d__52(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED16 RID: 60694 RVA: 0x00387970 File Offset: 0x00385B70
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED17 RID: 60695 RVA: 0x003879A4 File Offset: 0x00385BA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224697, XrefRangeEnd = 224701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004D17 RID: 19735
			// (get) Token: 0x0600ED18 RID: 60696 RVA: 0x003879E0 File Offset: 0x00385BE0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED19 RID: 60697 RVA: 0x00387A20 File Offset: 0x00385C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224701, XrefRangeEnd = 224707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004D18 RID: 19736
			// (get) Token: 0x0600ED1A RID: 60698 RVA: 0x00387A54 File Offset: 0x00385C54
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED1B RID: 60699 RVA: 0x0007EFB1 File Offset: 0x0007D1B1
			public _P1Start_d__52(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D13 RID: 19731
			// (get) Token: 0x0600ED1C RID: 60700 RVA: 0x00387A94 File Offset: 0x00385C94
			// (set) Token: 0x0600ED1D RID: 60701 RVA: 0x0007EFBA File Offset: 0x0007D1BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004D14 RID: 19732
			// (get) Token: 0x0600ED1E RID: 60702 RVA: 0x00387ABC File Offset: 0x00385CBC
			// (set) Token: 0x0600ED1F RID: 60703 RVA: 0x0007EFD5 File Offset: 0x0007D1D5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D15 RID: 19733
			// (get) Token: 0x0600ED20 RID: 60704 RVA: 0x00387AEC File Offset: 0x00385CEC
			// (set) Token: 0x0600ED21 RID: 60705 RVA: 0x0007EFF4 File Offset: 0x0007D1F4
			public unsafe DLC3_MausoleumCuisineCompetitionBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MausoleumCuisineCompetitionBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D16 RID: 19734
			// (get) Token: 0x0600ED22 RID: 60706 RVA: 0x00387B1C File Offset: 0x00385D1C
			// (set) Token: 0x0600ED23 RID: 60707 RVA: 0x0007F013 File Offset: 0x0007D213
			public unsafe DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeFieldInfoPtr_selectedPartnerType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1Start_d__52.NativeFieldInfoPtr_selectedPartnerType)) = value;
				}
			}

			// Token: 0x04009719 RID: 38681
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400971A RID: 38682
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400971B RID: 38683
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400971C RID: 38684
			private static readonly IntPtr NativeFieldInfoPtr_selectedPartnerType;

			// Token: 0x0400971D RID: 38685
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400971E RID: 38686
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400971F RID: 38687
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009720 RID: 38688
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009721 RID: 38689
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009722 RID: 38690
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CE4 RID: 3300
		[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<P1End>d__53")]
		public sealed class _P1End_d__53 : Il2CppSystem.Object
		{
			// Token: 0x0600ED24 RID: 60708 RVA: 0x00387B44 File Offset: 0x00385D44
			// Note: this type is marked as 'beforefieldinit'.
			static _P1End_d__53()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "<P1End>d__53");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr, "<>1__state");
				DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr, "<>2__current");
				DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr_isSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr, "isSucceed");
				DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr, "<>4__this");
				DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr_partnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr, "partnerType");
				DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr, 100681870);
				DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr, 100681871);
				DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr, 100681872);
				DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr, 100681873);
				DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr, 100681874);
				DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr, 100681875);
			}

			// Token: 0x0600ED25 RID: 60709 RVA: 0x00387C4C File Offset: 0x00385E4C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _P1End_d__53(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED26 RID: 60710 RVA: 0x00387C94 File Offset: 0x00385E94
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED27 RID: 60711 RVA: 0x00387CC8 File Offset: 0x00385EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224707, XrefRangeEnd = 224709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004D1E RID: 19742
			// (get) Token: 0x0600ED28 RID: 60712 RVA: 0x00387D04 File Offset: 0x00385F04
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED29 RID: 60713 RVA: 0x00387D44 File Offset: 0x00385F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224709, XrefRangeEnd = 224715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004D1F RID: 19743
			// (get) Token: 0x0600ED2A RID: 60714 RVA: 0x00387D78 File Offset: 0x00385F78
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED2B RID: 60715 RVA: 0x0007F02E File Offset: 0x0007D22E
			public _P1End_d__53(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D19 RID: 19737
			// (get) Token: 0x0600ED2C RID: 60716 RVA: 0x00387DB8 File Offset: 0x00385FB8
			// (set) Token: 0x0600ED2D RID: 60717 RVA: 0x0007F037 File Offset: 0x0007D237
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004D1A RID: 19738
			// (get) Token: 0x0600ED2E RID: 60718 RVA: 0x00387DE0 File Offset: 0x00385FE0
			// (set) Token: 0x0600ED2F RID: 60719 RVA: 0x0007F052 File Offset: 0x0007D252
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D1B RID: 19739
			// (get) Token: 0x0600ED30 RID: 60720 RVA: 0x00387E10 File Offset: 0x00386010
			// (set) Token: 0x0600ED31 RID: 60721 RVA: 0x0007F071 File Offset: 0x0007D271
			public unsafe bool isSucceed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr_isSucceed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr_isSucceed)) = value;
				}
			}

			// Token: 0x17004D1C RID: 19740
			// (get) Token: 0x0600ED32 RID: 60722 RVA: 0x00387E38 File Offset: 0x00386038
			// (set) Token: 0x0600ED33 RID: 60723 RVA: 0x0007F08C File Offset: 0x0007D28C
			public unsafe DLC3_MausoleumCuisineCompetitionBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MausoleumCuisineCompetitionBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D1D RID: 19741
			// (get) Token: 0x0600ED34 RID: 60724 RVA: 0x00387E68 File Offset: 0x00386068
			// (set) Token: 0x0600ED35 RID: 60725 RVA: 0x0007F0AB File Offset: 0x0007D2AB
			public unsafe DLC3_MausoleumCuisineCompetitionBossData.PartnerType partnerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr_partnerType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P1End_d__53.NativeFieldInfoPtr_partnerType)) = value;
				}
			}

			// Token: 0x04009723 RID: 38691
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009724 RID: 38692
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009725 RID: 38693
			private static readonly IntPtr NativeFieldInfoPtr_isSucceed;

			// Token: 0x04009726 RID: 38694
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009727 RID: 38695
			private static readonly IntPtr NativeFieldInfoPtr_partnerType;

			// Token: 0x04009728 RID: 38696
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009729 RID: 38697
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400972A RID: 38698
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400972B RID: 38699
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400972C RID: 38700
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400972D RID: 38701
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CE5 RID: 3301
		[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<P2Start>d__54")]
		public sealed class _P2Start_d__54 : Il2CppSystem.Object
		{
			// Token: 0x0600ED36 RID: 60726 RVA: 0x00387E90 File Offset: 0x00386090
			// Note: this type is marked as 'beforefieldinit'.
			static _P2Start_d__54()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "<P2Start>d__54");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54>.NativeClassPtr, "<>1__state");
				DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54>.NativeClassPtr, "<>2__current");
				DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54>.NativeClassPtr, "<>4__this");
				DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeFieldInfoPtr_selectedPartnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54>.NativeClassPtr, "selectedPartnerType");
				DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54>.NativeClassPtr, 100681876);
				DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54>.NativeClassPtr, 100681877);
				DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54>.NativeClassPtr, 100681878);
				DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54>.NativeClassPtr, 100681879);
				DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54>.NativeClassPtr, 100681880);
				DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54>.NativeClassPtr, 100681881);
			}

			// Token: 0x0600ED37 RID: 60727 RVA: 0x00387F84 File Offset: 0x00386184
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _P2Start_d__54(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED38 RID: 60728 RVA: 0x00387FCC File Offset: 0x003861CC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED39 RID: 60729 RVA: 0x00388000 File Offset: 0x00386200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224715, XrefRangeEnd = 224719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004D24 RID: 19748
			// (get) Token: 0x0600ED3A RID: 60730 RVA: 0x0038803C File Offset: 0x0038623C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED3B RID: 60731 RVA: 0x0038807C File Offset: 0x0038627C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224719, XrefRangeEnd = 224725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004D25 RID: 19749
			// (get) Token: 0x0600ED3C RID: 60732 RVA: 0x003880B0 File Offset: 0x003862B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED3D RID: 60733 RVA: 0x0007F0C6 File Offset: 0x0007D2C6
			public _P2Start_d__54(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D20 RID: 19744
			// (get) Token: 0x0600ED3E RID: 60734 RVA: 0x003880F0 File Offset: 0x003862F0
			// (set) Token: 0x0600ED3F RID: 60735 RVA: 0x0007F0CF File Offset: 0x0007D2CF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004D21 RID: 19745
			// (get) Token: 0x0600ED40 RID: 60736 RVA: 0x00388118 File Offset: 0x00386318
			// (set) Token: 0x0600ED41 RID: 60737 RVA: 0x0007F0EA File Offset: 0x0007D2EA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D22 RID: 19746
			// (get) Token: 0x0600ED42 RID: 60738 RVA: 0x00388148 File Offset: 0x00386348
			// (set) Token: 0x0600ED43 RID: 60739 RVA: 0x0007F109 File Offset: 0x0007D309
			public unsafe DLC3_MausoleumCuisineCompetitionBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MausoleumCuisineCompetitionBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D23 RID: 19747
			// (get) Token: 0x0600ED44 RID: 60740 RVA: 0x00388178 File Offset: 0x00386378
			// (set) Token: 0x0600ED45 RID: 60741 RVA: 0x0007F128 File Offset: 0x0007D328
			public unsafe DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeFieldInfoPtr_selectedPartnerType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2Start_d__54.NativeFieldInfoPtr_selectedPartnerType)) = value;
				}
			}

			// Token: 0x0400972E RID: 38702
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400972F RID: 38703
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009730 RID: 38704
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009731 RID: 38705
			private static readonly IntPtr NativeFieldInfoPtr_selectedPartnerType;

			// Token: 0x04009732 RID: 38706
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009733 RID: 38707
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009734 RID: 38708
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009735 RID: 38709
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009736 RID: 38710
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009737 RID: 38711
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CE6 RID: 3302
		[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<>c__DisplayClass55_0")]
		public sealed class __c__DisplayClass55_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ED46 RID: 60742 RVA: 0x003881A0 File Offset: 0x003863A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "<>c__DisplayClass55_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0.NativeFieldInfoPtr_exitCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0>.NativeClassPtr, "exitCode");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0>.NativeClassPtr, 100681882);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0.NativeMethodInfoPtr__P2End_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0>.NativeClassPtr, 100681883);
			}

			// Token: 0x0600ED47 RID: 60743 RVA: 0x00388208 File Offset: 0x00386408
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED48 RID: 60744 RVA: 0x00388244 File Offset: 0x00386444
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 138385, RefRangeEnd = 138389, XrefRangeStart = 138385, XrefRangeEnd = 138389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _P2End_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0.NativeMethodInfoPtr__P2End_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED49 RID: 60745 RVA: 0x0007F143 File Offset: 0x0007D343
			public __c__DisplayClass55_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D26 RID: 19750
			// (get) Token: 0x0600ED4A RID: 60746 RVA: 0x00388284 File Offset: 0x00386484
			// (set) Token: 0x0600ED4B RID: 60747 RVA: 0x0007F14C File Offset: 0x0007D34C
			public unsafe int exitCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0.NativeFieldInfoPtr_exitCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0.NativeFieldInfoPtr_exitCode)) = value;
				}
			}

			// Token: 0x04009738 RID: 38712
			private static readonly IntPtr NativeFieldInfoPtr_exitCode;

			// Token: 0x04009739 RID: 38713
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400973A RID: 38714
			private static readonly IntPtr NativeMethodInfoPtr__P2End_b__0_Internal_Void_Int32_0;
		}

		// Token: 0x02000CE7 RID: 3303
		[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<P2End>d__55")]
		public sealed class _P2End_d__55 : Il2CppSystem.Object
		{
			// Token: 0x0600ED4C RID: 60748 RVA: 0x003882AC File Offset: 0x003864AC
			// Note: this type is marked as 'beforefieldinit'.
			static _P2End_d__55()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "<P2End>d__55");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr, "<>1__state");
				DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr, "<>2__current");
				DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr_previousSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr, "previousSucceed");
				DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr_currentSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr, "currentSucceed");
				DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr, "<>4__this");
				DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr_selectedPartnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr, "selectedPartnerType");
				DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr, "<>8__1");
				DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr, 100681884);
				DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr, 100681885);
				DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr, 100681886);
				DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr, 100681887);
				DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr, 100681888);
				DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr, 100681889);
			}

			// Token: 0x0600ED4D RID: 60749 RVA: 0x003883DC File Offset: 0x003865DC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _P2End_d__55(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED4E RID: 60750 RVA: 0x00388424 File Offset: 0x00386624
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED4F RID: 60751 RVA: 0x00388458 File Offset: 0x00386658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224725, XrefRangeEnd = 224766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004D2E RID: 19758
			// (get) Token: 0x0600ED50 RID: 60752 RVA: 0x00388494 File Offset: 0x00386694
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED51 RID: 60753 RVA: 0x003884D4 File Offset: 0x003866D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224766, XrefRangeEnd = 224772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004D2F RID: 19759
			// (get) Token: 0x0600ED52 RID: 60754 RVA: 0x00388508 File Offset: 0x00386708
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED53 RID: 60755 RVA: 0x0007F167 File Offset: 0x0007D367
			public _P2End_d__55(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D27 RID: 19751
			// (get) Token: 0x0600ED54 RID: 60756 RVA: 0x00388548 File Offset: 0x00386748
			// (set) Token: 0x0600ED55 RID: 60757 RVA: 0x0007F170 File Offset: 0x0007D370
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004D28 RID: 19752
			// (get) Token: 0x0600ED56 RID: 60758 RVA: 0x00388570 File Offset: 0x00386770
			// (set) Token: 0x0600ED57 RID: 60759 RVA: 0x0007F18B File Offset: 0x0007D38B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D29 RID: 19753
			// (get) Token: 0x0600ED58 RID: 60760 RVA: 0x003885A0 File Offset: 0x003867A0
			// (set) Token: 0x0600ED59 RID: 60761 RVA: 0x0007F1AA File Offset: 0x0007D3AA
			public unsafe bool previousSucceed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr_previousSucceed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr_previousSucceed)) = value;
				}
			}

			// Token: 0x17004D2A RID: 19754
			// (get) Token: 0x0600ED5A RID: 60762 RVA: 0x003885C8 File Offset: 0x003867C8
			// (set) Token: 0x0600ED5B RID: 60763 RVA: 0x0007F1C5 File Offset: 0x0007D3C5
			public unsafe bool currentSucceed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr_currentSucceed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr_currentSucceed)) = value;
				}
			}

			// Token: 0x17004D2B RID: 19755
			// (get) Token: 0x0600ED5C RID: 60764 RVA: 0x003885F0 File Offset: 0x003867F0
			// (set) Token: 0x0600ED5D RID: 60765 RVA: 0x0007F1E0 File Offset: 0x0007D3E0
			public unsafe DLC3_MausoleumCuisineCompetitionBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MausoleumCuisineCompetitionBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D2C RID: 19756
			// (get) Token: 0x0600ED5E RID: 60766 RVA: 0x00388620 File Offset: 0x00386820
			// (set) Token: 0x0600ED5F RID: 60767 RVA: 0x0007F1FF File Offset: 0x0007D3FF
			public unsafe DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr_selectedPartnerType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr_selectedPartnerType)) = value;
				}
			}

			// Token: 0x17004D2D RID: 19757
			// (get) Token: 0x0600ED60 RID: 60768 RVA: 0x00388648 File Offset: 0x00386848
			// (set) Token: 0x0600ED61 RID: 60769 RVA: 0x0007F21A File Offset: 0x0007D41A
			public unsafe DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass55_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P2End_d__55.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400973B RID: 38715
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400973C RID: 38716
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400973D RID: 38717
			private static readonly IntPtr NativeFieldInfoPtr_previousSucceed;

			// Token: 0x0400973E RID: 38718
			private static readonly IntPtr NativeFieldInfoPtr_currentSucceed;

			// Token: 0x0400973F RID: 38719
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009740 RID: 38720
			private static readonly IntPtr NativeFieldInfoPtr_selectedPartnerType;

			// Token: 0x04009741 RID: 38721
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04009742 RID: 38722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009743 RID: 38723
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009744 RID: 38724
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009745 RID: 38725
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009746 RID: 38726
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009747 RID: 38727
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CE8 RID: 3304
		[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<P3Start>d__56")]
		public sealed class _P3Start_d__56 : Il2CppSystem.Object
		{
			// Token: 0x0600ED62 RID: 60770 RVA: 0x00388678 File Offset: 0x00386878
			// Note: this type is marked as 'beforefieldinit'.
			static _P3Start_d__56()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "<P3Start>d__56");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56>.NativeClassPtr, "<>1__state");
				DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56>.NativeClassPtr, "<>2__current");
				DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56>.NativeClassPtr, "<>4__this");
				DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeFieldInfoPtr_selectedPartnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56>.NativeClassPtr, "selectedPartnerType");
				DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56>.NativeClassPtr, 100681890);
				DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56>.NativeClassPtr, 100681891);
				DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56>.NativeClassPtr, 100681892);
				DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56>.NativeClassPtr, 100681893);
				DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56>.NativeClassPtr, 100681894);
				DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56>.NativeClassPtr, 100681895);
			}

			// Token: 0x0600ED63 RID: 60771 RVA: 0x0038876C File Offset: 0x0038696C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _P3Start_d__56(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED64 RID: 60772 RVA: 0x003887B4 File Offset: 0x003869B4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED65 RID: 60773 RVA: 0x003887E8 File Offset: 0x003869E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224772, XrefRangeEnd = 224776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004D34 RID: 19764
			// (get) Token: 0x0600ED66 RID: 60774 RVA: 0x00388824 File Offset: 0x00386A24
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED67 RID: 60775 RVA: 0x00388864 File Offset: 0x00386A64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224776, XrefRangeEnd = 224782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004D35 RID: 19765
			// (get) Token: 0x0600ED68 RID: 60776 RVA: 0x00388898 File Offset: 0x00386A98
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED69 RID: 60777 RVA: 0x0007F239 File Offset: 0x0007D439
			public _P3Start_d__56(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D30 RID: 19760
			// (get) Token: 0x0600ED6A RID: 60778 RVA: 0x003888D8 File Offset: 0x00386AD8
			// (set) Token: 0x0600ED6B RID: 60779 RVA: 0x0007F242 File Offset: 0x0007D442
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004D31 RID: 19761
			// (get) Token: 0x0600ED6C RID: 60780 RVA: 0x00388900 File Offset: 0x00386B00
			// (set) Token: 0x0600ED6D RID: 60781 RVA: 0x0007F25D File Offset: 0x0007D45D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D32 RID: 19762
			// (get) Token: 0x0600ED6E RID: 60782 RVA: 0x00388930 File Offset: 0x00386B30
			// (set) Token: 0x0600ED6F RID: 60783 RVA: 0x0007F27C File Offset: 0x0007D47C
			public unsafe DLC3_MausoleumCuisineCompetitionBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MausoleumCuisineCompetitionBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D33 RID: 19763
			// (get) Token: 0x0600ED70 RID: 60784 RVA: 0x00388960 File Offset: 0x00386B60
			// (set) Token: 0x0600ED71 RID: 60785 RVA: 0x0007F29B File Offset: 0x0007D49B
			public unsafe DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeFieldInfoPtr_selectedPartnerType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3Start_d__56.NativeFieldInfoPtr_selectedPartnerType)) = value;
				}
			}

			// Token: 0x04009748 RID: 38728
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009749 RID: 38729
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400974A RID: 38730
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400974B RID: 38731
			private static readonly IntPtr NativeFieldInfoPtr_selectedPartnerType;

			// Token: 0x0400974C RID: 38732
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400974D RID: 38733
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400974E RID: 38734
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400974F RID: 38735
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009750 RID: 38736
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009751 RID: 38737
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CE9 RID: 3305
		[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<P3End>d__57")]
		public sealed class _P3End_d__57 : Il2CppSystem.Object
		{
			// Token: 0x0600ED72 RID: 60786 RVA: 0x00388988 File Offset: 0x00386B88
			// Note: this type is marked as 'beforefieldinit'.
			static _P3End_d__57()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "<P3End>d__57");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr, "<>1__state");
				DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr, "<>2__current");
				DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr_firstSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr, "firstSucceed");
				DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr_secondSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr, "secondSucceed");
				DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr_currentSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr, "currentSucceed");
				DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr, "<>4__this");
				DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr_selectedPartnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr, "selectedPartnerType");
				DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr, 100681896);
				DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr, 100681897);
				DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr, 100681898);
				DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr, 100681899);
				DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr, 100681900);
				DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr, 100681901);
			}

			// Token: 0x0600ED73 RID: 60787 RVA: 0x00388AB8 File Offset: 0x00386CB8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _P3End_d__57(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED74 RID: 60788 RVA: 0x00388B00 File Offset: 0x00386D00
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED75 RID: 60789 RVA: 0x00388B34 File Offset: 0x00386D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224782, XrefRangeEnd = 224789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004D3D RID: 19773
			// (get) Token: 0x0600ED76 RID: 60790 RVA: 0x00388B70 File Offset: 0x00386D70
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED77 RID: 60791 RVA: 0x00388BB0 File Offset: 0x00386DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224789, XrefRangeEnd = 224795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004D3E RID: 19774
			// (get) Token: 0x0600ED78 RID: 60792 RVA: 0x00388BE4 File Offset: 0x00386DE4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED79 RID: 60793 RVA: 0x0007F2B6 File Offset: 0x0007D4B6
			public _P3End_d__57(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D36 RID: 19766
			// (get) Token: 0x0600ED7A RID: 60794 RVA: 0x00388C24 File Offset: 0x00386E24
			// (set) Token: 0x0600ED7B RID: 60795 RVA: 0x0007F2BF File Offset: 0x0007D4BF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004D37 RID: 19767
			// (get) Token: 0x0600ED7C RID: 60796 RVA: 0x00388C4C File Offset: 0x00386E4C
			// (set) Token: 0x0600ED7D RID: 60797 RVA: 0x0007F2DA File Offset: 0x0007D4DA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D38 RID: 19768
			// (get) Token: 0x0600ED7E RID: 60798 RVA: 0x00388C7C File Offset: 0x00386E7C
			// (set) Token: 0x0600ED7F RID: 60799 RVA: 0x0007F2F9 File Offset: 0x0007D4F9
			public unsafe bool firstSucceed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr_firstSucceed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr_firstSucceed)) = value;
				}
			}

			// Token: 0x17004D39 RID: 19769
			// (get) Token: 0x0600ED80 RID: 60800 RVA: 0x00388CA4 File Offset: 0x00386EA4
			// (set) Token: 0x0600ED81 RID: 60801 RVA: 0x0007F314 File Offset: 0x0007D514
			public unsafe bool secondSucceed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr_secondSucceed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr_secondSucceed)) = value;
				}
			}

			// Token: 0x17004D3A RID: 19770
			// (get) Token: 0x0600ED82 RID: 60802 RVA: 0x00388CCC File Offset: 0x00386ECC
			// (set) Token: 0x0600ED83 RID: 60803 RVA: 0x0007F32F File Offset: 0x0007D52F
			public unsafe bool currentSucceed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr_currentSucceed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr_currentSucceed)) = value;
				}
			}

			// Token: 0x17004D3B RID: 19771
			// (get) Token: 0x0600ED84 RID: 60804 RVA: 0x00388CF4 File Offset: 0x00386EF4
			// (set) Token: 0x0600ED85 RID: 60805 RVA: 0x0007F34A File Offset: 0x0007D54A
			public unsafe DLC3_MausoleumCuisineCompetitionBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MausoleumCuisineCompetitionBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D3C RID: 19772
			// (get) Token: 0x0600ED86 RID: 60806 RVA: 0x00388D24 File Offset: 0x00386F24
			// (set) Token: 0x0600ED87 RID: 60807 RVA: 0x0007F369 File Offset: 0x0007D569
			public unsafe DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr_selectedPartnerType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._P3End_d__57.NativeFieldInfoPtr_selectedPartnerType)) = value;
				}
			}

			// Token: 0x04009752 RID: 38738
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009753 RID: 38739
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009754 RID: 38740
			private static readonly IntPtr NativeFieldInfoPtr_firstSucceed;

			// Token: 0x04009755 RID: 38741
			private static readonly IntPtr NativeFieldInfoPtr_secondSucceed;

			// Token: 0x04009756 RID: 38742
			private static readonly IntPtr NativeFieldInfoPtr_currentSucceed;

			// Token: 0x04009757 RID: 38743
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009758 RID: 38744
			private static readonly IntPtr NativeFieldInfoPtr_selectedPartnerType;

			// Token: 0x04009759 RID: 38745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400975A RID: 38746
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400975B RID: 38747
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400975C RID: 38748
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400975D RID: 38749
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400975E RID: 38750
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CEA RID: 3306
		[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<PhaseStart>d__58")]
		public sealed class _PhaseStart_d__58 : Il2CppSystem.Object
		{
			// Token: 0x0600ED88 RID: 60808 RVA: 0x00388D4C File Offset: 0x00386F4C
			// Note: this type is marked as 'beforefieldinit'.
			static _PhaseStart_d__58()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "<PhaseStart>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr, "<>1__state");
				DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr, "<>2__current");
				DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr_characterSelectDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr, "characterSelectDialog");
				DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr_selectedPartnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr, "selectedPartnerType");
				DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr_startPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr, "startPackage");
				DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr, 100681902);
				DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr, 100681903);
				DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr, 100681904);
				DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr, 100681905);
				DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr, 100681906);
				DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr, 100681907);
			}

			// Token: 0x0600ED89 RID: 60809 RVA: 0x00388E54 File Offset: 0x00387054
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PhaseStart_d__58(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED8A RID: 60810 RVA: 0x00388E9C File Offset: 0x0038709C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED8B RID: 60811 RVA: 0x00388ED0 File Offset: 0x003870D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224795, XrefRangeEnd = 224796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004D44 RID: 19780
			// (get) Token: 0x0600ED8C RID: 60812 RVA: 0x00388F0C File Offset: 0x0038710C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED8D RID: 60813 RVA: 0x00388F4C File Offset: 0x0038714C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224796, XrefRangeEnd = 224802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004D45 RID: 19781
			// (get) Token: 0x0600ED8E RID: 60814 RVA: 0x00388F80 File Offset: 0x00387180
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600ED8F RID: 60815 RVA: 0x0007F384 File Offset: 0x0007D584
			public _PhaseStart_d__58(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D3F RID: 19775
			// (get) Token: 0x0600ED90 RID: 60816 RVA: 0x00388FC0 File Offset: 0x003871C0
			// (set) Token: 0x0600ED91 RID: 60817 RVA: 0x0007F38D File Offset: 0x0007D58D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004D40 RID: 19776
			// (get) Token: 0x0600ED92 RID: 60818 RVA: 0x00388FE8 File Offset: 0x003871E8
			// (set) Token: 0x0600ED93 RID: 60819 RVA: 0x0007F3A8 File Offset: 0x0007D5A8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D41 RID: 19777
			// (get) Token: 0x0600ED94 RID: 60820 RVA: 0x00389018 File Offset: 0x00387218
			// (set) Token: 0x0600ED95 RID: 60821 RVA: 0x0007F3C7 File Offset: 0x0007D5C7
			public DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage characterSelectDialog
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr_characterSelectDialog);
					return new DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr_characterSelectDialog), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004D42 RID: 19778
			// (get) Token: 0x0600ED96 RID: 60822 RVA: 0x00389048 File Offset: 0x00387248
			// (set) Token: 0x0600ED97 RID: 60823 RVA: 0x0007F3F5 File Offset: 0x0007D5F5
			public unsafe DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr_selectedPartnerType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr_selectedPartnerType)) = value;
				}
			}

			// Token: 0x17004D43 RID: 19779
			// (get) Token: 0x0600ED98 RID: 60824 RVA: 0x00389070 File Offset: 0x00387270
			// (set) Token: 0x0600ED99 RID: 60825 RVA: 0x0007F410 File Offset: 0x0007D610
			public unsafe DialogPackage startPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr_startPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._PhaseStart_d__58.NativeFieldInfoPtr_startPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400975F RID: 38751
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009760 RID: 38752
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009761 RID: 38753
			private static readonly IntPtr NativeFieldInfoPtr_characterSelectDialog;

			// Token: 0x04009762 RID: 38754
			private static readonly IntPtr NativeFieldInfoPtr_selectedPartnerType;

			// Token: 0x04009763 RID: 38755
			private static readonly IntPtr NativeFieldInfoPtr_startPackage;

			// Token: 0x04009764 RID: 38756
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009765 RID: 38757
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009766 RID: 38758
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009767 RID: 38759
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009768 RID: 38760
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009769 RID: 38761
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CEB RID: 3307
		[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<>c__DisplayClass59_0")]
		public sealed class __c__DisplayClass59_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ED9A RID: 60826 RVA: 0x003890A0 File Offset: 0x003872A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass59_0()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "<>c__DisplayClass59_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_incomeControllerChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "incomeControllerChallenge");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "<>4__this");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_currentBoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "currentBoss");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_partnerManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "partnerManager");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_bossMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "bossMapping");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_izakayaConfigure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "izakayaConfigure");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_pannelInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "pannelInstance");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_partnerProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "partnerProperty");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_partnerDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "partnerDic");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_potentialAssetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "potentialAssetHandle");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_uiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "uiManager");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_partnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "partnerType");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "eventManager");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_canContiue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "canContiue");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_playerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "playerTransform");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "startPosition");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_guestsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "guestsManager");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr___9__34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "<>9__34");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr___9__35 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "<>9__35");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681908);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681909);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__2_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681910);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681911);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__4_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681912);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681913);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681914);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__31_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681915);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__7_Internal_IEnumerable_1_SpecialGuestGroup_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681916);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__13_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681917);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__14_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681918);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__15_Internal_Void_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681919);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__24_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681920);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr_Method_Internal_UniTaskVoid_PartnerProperty_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681921);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__26_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681922);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__27_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681923);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__34_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681924);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__35_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681925);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__28_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681926);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__29_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681927);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__30_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, 100681928);
			}

			// Token: 0x0600ED9B RID: 60827 RVA: 0x003893EC File Offset: 0x003875EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass59_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED9C RID: 60828 RVA: 0x00389428 File Offset: 0x00387628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224897, XrefRangeEnd = 224899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED9D RID: 60829 RVA: 0x00389468 File Offset: 0x00387668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224899, XrefRangeEnd = 224939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__2(int x, int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__2_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED9E RID: 60830 RVA: 0x003894B4 File Offset: 0x003876B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224939, XrefRangeEnd = 224959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ED9F RID: 60831 RVA: 0x003894F4 File Offset: 0x003876F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224959, XrefRangeEnd = 224999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__4_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDA0 RID: 60832 RVA: 0x00389534 File Offset: 0x00387734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224999, XrefRangeEnd = 225019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDA1 RID: 60833 RVA: 0x00389574 File Offset: 0x00387774
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225019, XrefRangeEnd = 225031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController guestGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDA2 RID: 60834 RVA: 0x003895B8 File Offset: 0x003877B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225031, XrefRangeEnd = 225033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__31(GuestGroupController guestGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__31_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDA3 RID: 60835 RVA: 0x003895FC File Offset: 0x003877FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225033, XrefRangeEnd = 225049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Izakaya.SpecialGuestGroup> _MainChallengeLoop_b__7(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__7_Internal_IEnumerable_1_SpecialGuestGroup_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Izakaya.SpecialGuestGroup>>(intPtr3) : null;
			}

			// Token: 0x0600EDA4 RID: 60836 RVA: 0x0038964C File Offset: 0x0038784C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225049, XrefRangeEnd = 225051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__13(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__13_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDA5 RID: 60837 RVA: 0x0038968C File Offset: 0x0038788C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225051, XrefRangeEnd = 225053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__14(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__14_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDA6 RID: 60838 RVA: 0x003896CC File Offset: 0x003878CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225053, XrefRangeEnd = 225054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__15(ValueTuple<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__15_Internal_Void_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDA7 RID: 60839 RVA: 0x00389714 File Offset: 0x00387914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225054, XrefRangeEnd = 225061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__24()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__24_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDA8 RID: 60840 RVA: 0x00389748 File Offset: 0x00387948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225061, XrefRangeEnd = 225067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTaskVoid Method_Internal_UniTaskVoid_PartnerProperty_PDM_0(DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty selectedPartner)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(selectedPartner));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr_Method_Internal_UniTaskVoid_PartnerProperty_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EDA9 RID: 60841 RVA: 0x0038979C File Offset: 0x0038799C
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__26()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__26_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EDAA RID: 60842 RVA: 0x003897D8 File Offset: 0x003879D8
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__27()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__27_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EDAB RID: 60843 RVA: 0x00389814 File Offset: 0x00387A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225067, XrefRangeEnd = 225068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__34(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__34_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDAC RID: 60844 RVA: 0x00389858 File Offset: 0x00387A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__35(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__35_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDAD RID: 60845 RVA: 0x0038989C File Offset: 0x00387A9C
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__28()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__28_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDAE RID: 60846 RVA: 0x003898D0 File Offset: 0x00387AD0
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__29()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__29_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EDAF RID: 60847 RVA: 0x0038990C File Offset: 0x00387B0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225068, XrefRangeEnd = 225073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__30()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeMethodInfoPtr__MainChallengeLoop_b__30_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDB0 RID: 60848 RVA: 0x0007F42F File Offset: 0x0007D62F
			public __c__DisplayClass59_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D46 RID: 19782
			// (get) Token: 0x0600EDB1 RID: 60849 RVA: 0x00389940 File Offset: 0x00387B40
			// (set) Token: 0x0600EDB2 RID: 60850 RVA: 0x0007F438 File Offset: 0x0007D638
			public unsafe IncomeControllerMausoleumCuisineCompetition incomeControllerChallenge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_incomeControllerChallenge);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerMausoleumCuisineCompetition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_incomeControllerChallenge), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D47 RID: 19783
			// (get) Token: 0x0600EDB3 RID: 60851 RVA: 0x00389970 File Offset: 0x00387B70
			// (set) Token: 0x0600EDB4 RID: 60852 RVA: 0x0007F457 File Offset: 0x0007D657
			public unsafe DLC3_MausoleumCuisineCompetitionBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MausoleumCuisineCompetitionBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D48 RID: 19784
			// (get) Token: 0x0600EDB5 RID: 60853 RVA: 0x003899A0 File Offset: 0x00387BA0
			// (set) Token: 0x0600EDB6 RID: 60854 RVA: 0x0007F476 File Offset: 0x0007D676
			public DLC3_MausoleumCuisineCompetitionBossData.BossMapping currentBoss
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_currentBoss);
					return new DLC3_MausoleumCuisineCompetitionBossData.BossMapping(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.BossMapping>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_currentBoss), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.BossMapping>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004D49 RID: 19785
			// (get) Token: 0x0600EDB7 RID: 60855 RVA: 0x003899D0 File Offset: 0x00387BD0
			// (set) Token: 0x0600EDB8 RID: 60856 RVA: 0x0007F4A4 File Offset: 0x0007D6A4
			public unsafe PartnerManager partnerManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_partnerManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_partnerManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D4A RID: 19786
			// (get) Token: 0x0600EDB9 RID: 60857 RVA: 0x00389A00 File Offset: 0x00387C00
			// (set) Token: 0x0600EDBA RID: 60858 RVA: 0x0007F4C3 File Offset: 0x0007D6C3
			public unsafe Dictionary<NightSceneDirector.ChallengeType, DLC3_MausoleumCuisineCompetitionBossData.BossMapping> bossMapping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_bossMapping);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NightSceneDirector.ChallengeType, DLC3_MausoleumCuisineCompetitionBossData.BossMapping>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_bossMapping), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D4B RID: 19787
			// (get) Token: 0x0600EDBB RID: 60859 RVA: 0x00389A30 File Offset: 0x00387C30
			// (set) Token: 0x0600EDBC RID: 60860 RVA: 0x0007F4E2 File Offset: 0x0007D6E2
			public unsafe IzakayaConfigure izakayaConfigure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_izakayaConfigure);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigure>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_izakayaConfigure), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D4C RID: 19788
			// (get) Token: 0x0600EDBD RID: 60861 RVA: 0x00389A60 File Offset: 0x00387C60
			// (set) Token: 0x0600EDBE RID: 60862 RVA: 0x0007F501 File Offset: 0x0007D701
			public unsafe DLC3_BossBattleEmployeeSelectorPannel pannelInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_pannelInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_BossBattleEmployeeSelectorPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_pannelInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D4D RID: 19789
			// (get) Token: 0x0600EDBF RID: 60863 RVA: 0x00389A90 File Offset: 0x00387C90
			// (set) Token: 0x0600EDC0 RID: 60864 RVA: 0x0007F520 File Offset: 0x0007D720
			public DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty partnerProperty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_partnerProperty);
					return new DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_partnerProperty), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004D4E RID: 19790
			// (get) Token: 0x0600EDC1 RID: 60865 RVA: 0x00389AC0 File Offset: 0x00387CC0
			// (set) Token: 0x0600EDC2 RID: 60866 RVA: 0x0007F54E File Offset: 0x0007D74E
			public unsafe Dictionary<int, DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping> partnerDic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_partnerDic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_partnerDic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D4F RID: 19791
			// (get) Token: 0x0600EDC3 RID: 60867 RVA: 0x00389AF0 File Offset: 0x00387CF0
			// (set) Token: 0x0600EDC4 RID: 60868 RVA: 0x0007F56D File Offset: 0x0007D76D
			public unsafe IAssetHandle<Sprite> potentialAssetHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_potentialAssetHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_potentialAssetHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D50 RID: 19792
			// (get) Token: 0x0600EDC5 RID: 60869 RVA: 0x00389B20 File Offset: 0x00387D20
			// (set) Token: 0x0600EDC6 RID: 60870 RVA: 0x0007F58C File Offset: 0x0007D78C
			public unsafe UIManager uiManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_uiManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_uiManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D51 RID: 19793
			// (get) Token: 0x0600EDC7 RID: 60871 RVA: 0x00389B50 File Offset: 0x00387D50
			// (set) Token: 0x0600EDC8 RID: 60872 RVA: 0x0007F5AB File Offset: 0x0007D7AB
			public unsafe DLC3_MausoleumCuisineCompetitionBossData.PartnerType partnerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_partnerType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_partnerType)) = value;
				}
			}

			// Token: 0x17004D52 RID: 19794
			// (get) Token: 0x0600EDC9 RID: 60873 RVA: 0x00389B78 File Offset: 0x00387D78
			// (set) Token: 0x0600EDCA RID: 60874 RVA: 0x0007F5C6 File Offset: 0x0007D7C6
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D53 RID: 19795
			// (get) Token: 0x0600EDCB RID: 60875 RVA: 0x00389BA8 File Offset: 0x00387DA8
			// (set) Token: 0x0600EDCC RID: 60876 RVA: 0x0007F5E5 File Offset: 0x0007D7E5
			public unsafe bool canContiue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_canContiue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_canContiue)) = value;
				}
			}

			// Token: 0x17004D54 RID: 19796
			// (get) Token: 0x0600EDCD RID: 60877 RVA: 0x00389BD0 File Offset: 0x00387DD0
			// (set) Token: 0x0600EDCE RID: 60878 RVA: 0x0007F600 File Offset: 0x0007D800
			public unsafe Transform playerTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_playerTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_playerTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D55 RID: 19797
			// (get) Token: 0x0600EDCF RID: 60879 RVA: 0x00389C00 File Offset: 0x00387E00
			// (set) Token: 0x0600EDD0 RID: 60880 RVA: 0x0007F61F File Offset: 0x0007D81F
			public unsafe Vector3 startPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_startPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_startPosition)) = value;
				}
			}

			// Token: 0x17004D56 RID: 19798
			// (get) Token: 0x0600EDD1 RID: 60881 RVA: 0x00389C28 File Offset: 0x00387E28
			// (set) Token: 0x0600EDD2 RID: 60882 RVA: 0x0007F63A File Offset: 0x0007D83A
			public unsafe GuestsManager guestsManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_guestsManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr_guestsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D57 RID: 19799
			// (get) Token: 0x0600EDD3 RID: 60883 RVA: 0x00389C58 File Offset: 0x00387E58
			// (set) Token: 0x0600EDD4 RID: 60884 RVA: 0x0007F659 File Offset: 0x0007D859
			public unsafe Action<GuestGroupController> __9__34
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr___9__34);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr___9__34), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D58 RID: 19800
			// (get) Token: 0x0600EDD5 RID: 60885 RVA: 0x00389C88 File Offset: 0x00387E88
			// (set) Token: 0x0600EDD6 RID: 60886 RVA: 0x0007F678 File Offset: 0x0007D878
			public unsafe Action<GuestGroupController> __9__35
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr___9__35);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.NativeFieldInfoPtr___9__35), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400976A RID: 38762
			private static readonly IntPtr NativeFieldInfoPtr_incomeControllerChallenge;

			// Token: 0x0400976B RID: 38763
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400976C RID: 38764
			private static readonly IntPtr NativeFieldInfoPtr_currentBoss;

			// Token: 0x0400976D RID: 38765
			private static readonly IntPtr NativeFieldInfoPtr_partnerManager;

			// Token: 0x0400976E RID: 38766
			private static readonly IntPtr NativeFieldInfoPtr_bossMapping;

			// Token: 0x0400976F RID: 38767
			private static readonly IntPtr NativeFieldInfoPtr_izakayaConfigure;

			// Token: 0x04009770 RID: 38768
			private static readonly IntPtr NativeFieldInfoPtr_pannelInstance;

			// Token: 0x04009771 RID: 38769
			private static readonly IntPtr NativeFieldInfoPtr_partnerProperty;

			// Token: 0x04009772 RID: 38770
			private static readonly IntPtr NativeFieldInfoPtr_partnerDic;

			// Token: 0x04009773 RID: 38771
			private static readonly IntPtr NativeFieldInfoPtr_potentialAssetHandle;

			// Token: 0x04009774 RID: 38772
			private static readonly IntPtr NativeFieldInfoPtr_uiManager;

			// Token: 0x04009775 RID: 38773
			private static readonly IntPtr NativeFieldInfoPtr_partnerType;

			// Token: 0x04009776 RID: 38774
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009777 RID: 38775
			private static readonly IntPtr NativeFieldInfoPtr_canContiue;

			// Token: 0x04009778 RID: 38776
			private static readonly IntPtr NativeFieldInfoPtr_playerTransform;

			// Token: 0x04009779 RID: 38777
			private static readonly IntPtr NativeFieldInfoPtr_startPosition;

			// Token: 0x0400977A RID: 38778
			private static readonly IntPtr NativeFieldInfoPtr_guestsManager;

			// Token: 0x0400977B RID: 38779
			private static readonly IntPtr NativeFieldInfoPtr___9__34;

			// Token: 0x0400977C RID: 38780
			private static readonly IntPtr NativeFieldInfoPtr___9__35;

			// Token: 0x0400977D RID: 38781
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400977E RID: 38782
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__1_Internal_Void_Int32_0;

			// Token: 0x0400977F RID: 38783
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__2_Internal_Void_Int32_Int32_0;

			// Token: 0x04009780 RID: 38784
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__3_Internal_Void_Int32_0;

			// Token: 0x04009781 RID: 38785
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__4_Internal_Void_Int32_0;

			// Token: 0x04009782 RID: 38786
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Void_Int32_0;

			// Token: 0x04009783 RID: 38787
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x04009784 RID: 38788
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__31_Internal_Void_GuestGroupController_0;

			// Token: 0x04009785 RID: 38789
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__7_Internal_IEnumerable_1_SpecialGuestGroup_Izakaya_0;

			// Token: 0x04009786 RID: 38790
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_Internal_Void_Int32_0;

			// Token: 0x04009787 RID: 38791
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__14_Internal_Void_Int32_0;

			// Token: 0x04009788 RID: 38792
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__15_Internal_Void_ValueTuple_2_Int32_Int32_0;

			// Token: 0x04009789 RID: 38793
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__24_Internal_Void_0;

			// Token: 0x0400978A RID: 38794
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_UniTaskVoid_PartnerProperty_PDM_0;

			// Token: 0x0400978B RID: 38795
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_Internal_Boolean_0;

			// Token: 0x0400978C RID: 38796
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__27_Internal_Int32_0;

			// Token: 0x0400978D RID: 38797
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__34_Internal_Void_GuestGroupController_0;

			// Token: 0x0400978E RID: 38798
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__35_Internal_Void_GuestGroupController_0;

			// Token: 0x0400978F RID: 38799
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__28_Internal_Void_0;

			// Token: 0x04009790 RID: 38800
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__29_Internal_Boolean_0;

			// Token: 0x04009791 RID: 38801
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__30_Internal_Void_0;

			// Token: 0x0200107D RID: 4221
			[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<>c__DisplayClass59_0+<<MainChallengeLoop>g__AfterSelect|25>d")]
			public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique : ValueType
			{
				// Token: 0x06011FCA RID: 73674 RVA: 0x0041C244 File Offset: 0x0041A444
				// Note: this type is marked as 'beforefieldinit'.
				static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique()
				{
					Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>.NativeClassPtr, "<<MainChallengeLoop>g__AfterSelect|25>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique>.NativeClassPtr);
					DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique>.NativeClassPtr, "<>1__state");
					DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique>.NativeClassPtr, "<>t__builder");
					DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique>.NativeClassPtr, "<>4__this");
					DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr_selectedPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique>.NativeClassPtr, "selectedPartner");
					DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr__selected_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique>.NativeClassPtr, "<selected>5__2");
					DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr__thisPartner_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique>.NativeClassPtr, "<thisPartner>5__3");
					DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique>.NativeClassPtr, "<>u__1");
					DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique>.NativeClassPtr, 100681929);
					DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique>.NativeClassPtr, 100681930);
				}

				// Token: 0x06011FCB RID: 73675 RVA: 0x0041C324 File Offset: 0x0041A524
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 224895, RefRangeEnd = 224897, XrefRangeStart = 224802, XrefRangeEnd = 224895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011FCC RID: 73676 RVA: 0x0041C35C File Offset: 0x0041A55C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011FCD RID: 73677 RVA: 0x0009C3C5 File Offset: 0x0009A5C5
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x06011FCE RID: 73678 RVA: 0x0009C3CE File Offset: 0x0009A5CE
				public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique>.NativeClassPtr))
				{
				}

				// Token: 0x17005DD3 RID: 24019
				// (get) Token: 0x06011FCF RID: 73679 RVA: 0x0041C3A4 File Offset: 0x0041A5A4
				// (set) Token: 0x06011FD0 RID: 73680 RVA: 0x0009C3E0 File Offset: 0x0009A5E0
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DD4 RID: 24020
				// (get) Token: 0x06011FD1 RID: 73681 RVA: 0x0041C3CC File Offset: 0x0041A5CC
				// (set) Token: 0x06011FD2 RID: 73682 RVA: 0x0009C3FB File Offset: 0x0009A5FB
				public AsyncUniTaskVoidMethodBuilder __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005DD5 RID: 24021
				// (get) Token: 0x06011FD3 RID: 73683 RVA: 0x0041C3FC File Offset: 0x0041A5FC
				// (set) Token: 0x06011FD4 RID: 73684 RVA: 0x0009C429 File Offset: 0x0009A629
				public unsafe DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DD6 RID: 24022
				// (get) Token: 0x06011FD5 RID: 73685 RVA: 0x0041C42C File Offset: 0x0041A62C
				// (set) Token: 0x06011FD6 RID: 73686 RVA: 0x0009C448 File Offset: 0x0009A648
				public DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty selectedPartner
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr_selectedPartner);
						return new DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr_selectedPartner), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005DD7 RID: 24023
				// (get) Token: 0x06011FD7 RID: 73687 RVA: 0x0041C45C File Offset: 0x0041A65C
				// (set) Token: 0x06011FD8 RID: 73688 RVA: 0x0009C476 File Offset: 0x0009A676
				public unsafe int _selected_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr__selected_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr__selected_5__2)) = value;
					}
				}

				// Token: 0x17005DD8 RID: 24024
				// (get) Token: 0x06011FD9 RID: 73689 RVA: 0x0041C484 File Offset: 0x0041A684
				// (set) Token: 0x06011FDA RID: 73690 RVA: 0x0009C491 File Offset: 0x0009A691
				public DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping _thisPartner_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr__thisPartner_5__3);
						return new DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr__thisPartner_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005DD9 RID: 24025
				// (get) Token: 0x06011FDB RID: 73691 RVA: 0x0041C4B4 File Offset: 0x0041A6B4
				// (set) Token: 0x06011FDC RID: 73692 RVA: 0x0009C4BF File Offset: 0x0009A6BF
				public UniTask<IAssetHandle<Sprite>>.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr___u__1);
						return new UniTask<IAssetHandle<Sprite>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<Sprite>>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsPaseAwInPa1IASpUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<Sprite>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B643 RID: 46659
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B644 RID: 46660
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400B645 RID: 46661
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B646 RID: 46662
				private static readonly IntPtr NativeFieldInfoPtr_selectedPartner;

				// Token: 0x0400B647 RID: 46663
				private static readonly IntPtr NativeFieldInfoPtr__selected_5__2;

				// Token: 0x0400B648 RID: 46664
				private static readonly IntPtr NativeFieldInfoPtr__thisPartner_5__3;

				// Token: 0x0400B649 RID: 46665
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400B64A RID: 46666
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B64B RID: 46667
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x02000CEC RID: 3308
		[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<>c__DisplayClass59_1")]
		public sealed class __c__DisplayClass59_1 : Il2CppSystem.Object
		{
			// Token: 0x0600EDD7 RID: 60887 RVA: 0x00389CB8 File Offset: 0x00387EB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass59_1()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "<>c__DisplayClass59_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1>.NativeClassPtr, "x");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1.NativeFieldInfoPtr_field_Public___c__DisplayClass59_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1>.NativeClassPtr, 100681931);
				DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1.NativeMethodInfoPtr__MainChallengeLoop_b__32_Internal_Boolean_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1>.NativeClassPtr, 100681932);
			}

			// Token: 0x0600EDD8 RID: 60888 RVA: 0x00389D34 File Offset: 0x00387F34
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass59_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDD9 RID: 60889 RVA: 0x00389D70 File Offset: 0x00387F70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225073, XrefRangeEnd = 225114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__32(Izakaya.SpecialGuestGroup y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1.NativeMethodInfoPtr__MainChallengeLoop_b__32_Internal_Boolean_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EDDA RID: 60890 RVA: 0x0007F697 File Offset: 0x0007D897
			public __c__DisplayClass59_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D59 RID: 19801
			// (get) Token: 0x0600EDDB RID: 60891 RVA: 0x00389DC0 File Offset: 0x00387FC0
			// (set) Token: 0x0600EDDC RID: 60892 RVA: 0x0007F6A0 File Offset: 0x0007D8A0
			public unsafe Izakaya x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Izakaya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D5A RID: 19802
			// (get) Token: 0x0600EDDD RID: 60893 RVA: 0x00389DF0 File Offset: 0x00387FF0
			// (set) Token: 0x0600EDDE RID: 60894 RVA: 0x0007F6BF File Offset: 0x0007D8BF
			public unsafe DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0 field_Public___c__DisplayClass59_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1.NativeFieldInfoPtr_field_Public___c__DisplayClass59_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_1.NativeFieldInfoPtr_field_Public___c__DisplayClass59_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009792 RID: 38802
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04009793 RID: 38803
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass59_0_0;

			// Token: 0x04009794 RID: 38804
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009795 RID: 38805
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__32_Internal_Boolean_SpecialGuestGroup_0;
		}

		// Token: 0x02000CED RID: 3309
		[ObfuscatedName("GameData.Profile.DLC3_MausoleumCuisineCompetitionBossData+<MainChallengeLoop>d__59")]
		public sealed class _MainChallengeLoop_d__59 : Il2CppSystem.Object
		{
			// Token: 0x0600EDDF RID: 60895 RVA: 0x00389E20 File Offset: 0x00388020
			// Note: this type is marked as 'beforefieldinit'.
			static _MainChallengeLoop_d__59()
			{
				Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData>.NativeClassPtr, "<MainChallengeLoop>d__59");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr);
				DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr, "<>1__state");
				DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr, "<>2__current");
				DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr, "<>4__this");
				DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr, "bossDataContext");
				DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr, "<>8__1");
				DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr__cookSystemManagerInstance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr, "<cookSystemManagerInstance>5__2");
				DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr__currentSucceed_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr, "<currentSucceed>5__3");
				DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr, 100681933);
				DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr, 100681934);
				DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr, 100681935);
				DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr, 100681936);
				DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr, 100681937);
				DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr, 100681938);
			}

			// Token: 0x0600EDE0 RID: 60896 RVA: 0x00389F50 File Offset: 0x00388150
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MainChallengeLoop_d__59(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDE1 RID: 60897 RVA: 0x00389F98 File Offset: 0x00388198
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDE2 RID: 60898 RVA: 0x00389FCC File Offset: 0x003881CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225114, XrefRangeEnd = 225839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004D62 RID: 19810
			// (get) Token: 0x0600EDE3 RID: 60899 RVA: 0x0038A008 File Offset: 0x00388208
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EDE4 RID: 60900 RVA: 0x0038A048 File Offset: 0x00388248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225839, XrefRangeEnd = 225845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004D63 RID: 19811
			// (get) Token: 0x0600EDE5 RID: 60901 RVA: 0x0038A07C File Offset: 0x0038827C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EDE6 RID: 60902 RVA: 0x0007F6DE File Offset: 0x0007D8DE
			public _MainChallengeLoop_d__59(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D5B RID: 19803
			// (get) Token: 0x0600EDE7 RID: 60903 RVA: 0x0038A0BC File Offset: 0x003882BC
			// (set) Token: 0x0600EDE8 RID: 60904 RVA: 0x0007F6E7 File Offset: 0x0007D8E7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004D5C RID: 19804
			// (get) Token: 0x0600EDE9 RID: 60905 RVA: 0x0038A0E4 File Offset: 0x003882E4
			// (set) Token: 0x0600EDEA RID: 60906 RVA: 0x0007F702 File Offset: 0x0007D902
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D5D RID: 19805
			// (get) Token: 0x0600EDEB RID: 60907 RVA: 0x0038A114 File Offset: 0x00388314
			// (set) Token: 0x0600EDEC RID: 60908 RVA: 0x0007F721 File Offset: 0x0007D921
			public unsafe DLC3_MausoleumCuisineCompetitionBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MausoleumCuisineCompetitionBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D5E RID: 19806
			// (get) Token: 0x0600EDED RID: 60909 RVA: 0x0038A144 File Offset: 0x00388344
			// (set) Token: 0x0600EDEE RID: 60910 RVA: 0x0007F740 File Offset: 0x0007D940
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004D5F RID: 19807
			// (get) Token: 0x0600EDEF RID: 60911 RVA: 0x0038A174 File Offset: 0x00388374
			// (set) Token: 0x0600EDF0 RID: 60912 RVA: 0x0007F76E File Offset: 0x0007D96E
			public unsafe DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MausoleumCuisineCompetitionBossData.__c__DisplayClass59_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D60 RID: 19808
			// (get) Token: 0x0600EDF1 RID: 60913 RVA: 0x0038A1A4 File Offset: 0x003883A4
			// (set) Token: 0x0600EDF2 RID: 60914 RVA: 0x0007F78D File Offset: 0x0007D98D
			public unsafe CookSystemManager _cookSystemManagerInstance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr__cookSystemManagerInstance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookSystemManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr__cookSystemManagerInstance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D61 RID: 19809
			// (get) Token: 0x0600EDF3 RID: 60915 RVA: 0x0038A1D4 File Offset: 0x003883D4
			// (set) Token: 0x0600EDF4 RID: 60916 RVA: 0x0007F7AC File Offset: 0x0007D9AC
			public unsafe bool _currentSucceed_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr__currentSucceed_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MausoleumCuisineCompetitionBossData._MainChallengeLoop_d__59.NativeFieldInfoPtr__currentSucceed_5__3)) = value;
				}
			}

			// Token: 0x04009796 RID: 38806
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009797 RID: 38807
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009798 RID: 38808
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009799 RID: 38809
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x0400979A RID: 38810
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400979B RID: 38811
			private static readonly IntPtr NativeFieldInfoPtr__cookSystemManagerInstance_5__2;

			// Token: 0x0400979C RID: 38812
			private static readonly IntPtr NativeFieldInfoPtr__currentSucceed_5__3;

			// Token: 0x0400979D RID: 38813
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400979E RID: 38814
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400979F RID: 38815
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040097A0 RID: 38816
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040097A1 RID: 38817
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040097A2 RID: 38818
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
