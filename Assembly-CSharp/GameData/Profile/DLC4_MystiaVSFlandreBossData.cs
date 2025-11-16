using System;
using System.Runtime.InteropServices;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
using GameData.RunTime.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Night.BossBattle.DLC4_BossBattle;
using NightScene;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using NightScene.Tiles;
using NightScene.UI;
using NightScene.UI.HUDUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002F9 RID: 761
	public class DLC4_MystiaVSFlandreBossData : BossData
	{
		// Token: 0x06005B4C RID: 23372 RVA: 0x001CF678 File Offset: 0x001CD878
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_MystiaVSFlandreBossData()
		{
			Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DLC4_MystiaVSFlandreBossData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr);
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_StartFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_StartFund");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_GuardMappingDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_GuardMappingDic");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_CardSelectorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_CardSelectorPanel");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_DLC4BossBattleShopPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_DLC4BossBattleShopPanel");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_DLC4BossBattlePatchouliSpellPanelPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_DLC4BossBattlePatchouliSpellPanelPanel");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_flagLevel1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "flagLevel1");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_flagLevel2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "flagLevel2");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_levelUpTo2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "levelUpTo2");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_levelUpAndSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "levelUpAndSkill");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_level2Vfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "level2Vfx");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_flagOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "flagOffset");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_PatchouliSpellMaxNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_PatchouliSpellMaxNum");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_PatchouliSpellCoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_PatchouliSpellCoolDown");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_PatchouliSpellPCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_PatchouliSpellPCost");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_PartnerMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_PartnerMapping");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_FlandreController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_FlandreController");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BrokenTablePic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_BrokenTablePic");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_LockTableDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_LockTableDuration");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_poisonVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "poisonVFX");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_GuardManualTxt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_GuardManualTxt");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellManualTxt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_SpellManualTxt");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_LastLineXPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_LastLineXPosition");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_FirstRefreshEnemyNeedToWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_FirstRefreshEnemyNeedToWait");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_DamageCheckingPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_DamageCheckingPercentage");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_MinWaitTimeToNextWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_MinWaitTimeToNextWave");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_WaitTimeToNextWaveDueToDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_WaitTimeToNextWaveDueToDamage");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_ToRefreshNextWaveLeastWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_ToRefreshNextWaveLeastWait");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_ToRefreshNextBigWaveLeastWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_ToRefreshNextBigWaveLeastWait");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BigWaveProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_BigWaveProperty");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BigWavePropertyNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_BigWavePropertyNormal");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BigWavePropertyHard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_BigWavePropertyHard");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BigWavePropertyLunatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_BigWavePropertyLunatic");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_defaultTeamBulletHitSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "defaultTeamBulletHitSfx");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_level2Sfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "level2Sfx");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_skillSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "skillSfx");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_onChallengeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "onChallengeEnd");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellMetal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_SpellMetal");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellWood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_SpellWood");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_SpellWater");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_SpellFire");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellEarth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_SpellEarth");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellSun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_SpellSun");
			DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellMoon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "m_SpellMoon");
			DLC4_MystiaVSFlandreBossData.NativeMethodInfoPtr_GetWaveData_Private_Il2CppReferenceArray_1_BigWaveProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, 100681939);
			DLC4_MystiaVSFlandreBossData.NativeMethodInfoPtr_OnPreloadGeneralChallenge_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, 100681940);
			DLC4_MystiaVSFlandreBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, 100681941);
			DLC4_MystiaVSFlandreBossData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, 100681942);
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x001CFA54 File Offset: 0x001CDC54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226649, RefRangeEnd = 226650, XrefRangeStart = 226625, XrefRangeEnd = 226649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.BigWaveProperty> GetWaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.NativeMethodInfoPtr_GetWaveData_Private_Il2CppReferenceArray_1_BigWaveProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.BigWaveProperty>>(intPtr3) : null;
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x001CFA94 File Offset: 0x001CDC94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226663, RefRangeEnd = 226664, XrefRangeStart = 226650, XrefRangeEnd = 226663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPreloadGeneralChallenge()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.NativeMethodInfoPtr_OnPreloadGeneralChallenge_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B4F RID: 23375 RVA: 0x001CFAC8 File Offset: 0x001CDCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226664, XrefRangeEnd = 226670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_MystiaVSFlandreBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005B50 RID: 23376 RVA: 0x001CFB28 File Offset: 0x001CDD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226670, XrefRangeEnd = 226671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_MystiaVSFlandreBossData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x0003193B File Offset: 0x0002FB3B
		public DLC4_MystiaVSFlandreBossData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x06005B52 RID: 23378 RVA: 0x001CFB64 File Offset: 0x001CDD64
		// (set) Token: 0x06005B53 RID: 23379 RVA: 0x00031944 File Offset: 0x0002FB44
		public unsafe int m_StartFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_StartFund);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_StartFund)) = value;
			}
		}

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x06005B54 RID: 23380 RVA: 0x001CFB8C File Offset: 0x001CDD8C
		// (set) Token: 0x06005B55 RID: 23381 RVA: 0x0003195F File Offset: 0x0002FB5F
		public unsafe Il2CppReferenceArray<GuestGuardMapping> m_GuardMappingDic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_GuardMappingDic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GuestGuardMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_GuardMappingDic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x06005B56 RID: 23382 RVA: 0x001CFBBC File Offset: 0x001CDDBC
		// (set) Token: 0x06005B57 RID: 23383 RVA: 0x0003197E File Offset: 0x0002FB7E
		public unsafe DLC4_ChallengeCardSelectorPanel m_CardSelectorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_CardSelectorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_ChallengeCardSelectorPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_CardSelectorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x06005B58 RID: 23384 RVA: 0x001CFBEC File Offset: 0x001CDDEC
		// (set) Token: 0x06005B59 RID: 23385 RVA: 0x0003199D File Offset: 0x0002FB9D
		public unsafe DLC4_BossBattleShopPanel m_DLC4BossBattleShopPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_DLC4BossBattleShopPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BossBattleShopPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_DLC4BossBattleShopPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x06005B5A RID: 23386 RVA: 0x001CFC1C File Offset: 0x001CDE1C
		// (set) Token: 0x06005B5B RID: 23387 RVA: 0x000319BC File Offset: 0x0002FBBC
		public unsafe DLC4_BossBattlePatchouliSpellPanel m_DLC4BossBattlePatchouliSpellPanelPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_DLC4BossBattlePatchouliSpellPanelPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BossBattlePatchouliSpellPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_DLC4BossBattlePatchouliSpellPanelPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x06005B5C RID: 23388 RVA: 0x001CFC4C File Offset: 0x001CDE4C
		// (set) Token: 0x06005B5D RID: 23389 RVA: 0x000319DB File Offset: 0x0002FBDB
		public VFXPrefab flagLevel1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_flagLevel1);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_flagLevel1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x06005B5E RID: 23390 RVA: 0x001CFC7C File Offset: 0x001CDE7C
		// (set) Token: 0x06005B5F RID: 23391 RVA: 0x00031A09 File Offset: 0x0002FC09
		public VFXPrefab flagLevel2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_flagLevel2);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_flagLevel2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x06005B60 RID: 23392 RVA: 0x001CFCAC File Offset: 0x001CDEAC
		// (set) Token: 0x06005B61 RID: 23393 RVA: 0x00031A37 File Offset: 0x0002FC37
		public VFXPrefab levelUpTo2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_levelUpTo2);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_levelUpTo2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x06005B62 RID: 23394 RVA: 0x001CFCDC File Offset: 0x001CDEDC
		// (set) Token: 0x06005B63 RID: 23395 RVA: 0x00031A65 File Offset: 0x0002FC65
		public VFXPrefab levelUpAndSkill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_levelUpAndSkill);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_levelUpAndSkill), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x06005B64 RID: 23396 RVA: 0x001CFD0C File Offset: 0x001CDF0C
		// (set) Token: 0x06005B65 RID: 23397 RVA: 0x00031A93 File Offset: 0x0002FC93
		public VFXPrefab level2Vfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_level2Vfx);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_level2Vfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x06005B66 RID: 23398 RVA: 0x001CFD3C File Offset: 0x001CDF3C
		// (set) Token: 0x06005B67 RID: 23399 RVA: 0x00031AC1 File Offset: 0x0002FCC1
		public unsafe Vector3 flagOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_flagOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_flagOffset)) = value;
			}
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x06005B68 RID: 23400 RVA: 0x001CFD64 File Offset: 0x001CDF64
		// (set) Token: 0x06005B69 RID: 23401 RVA: 0x00031ADC File Offset: 0x0002FCDC
		public unsafe int m_PatchouliSpellMaxNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_PatchouliSpellMaxNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_PatchouliSpellMaxNum)) = value;
			}
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x06005B6A RID: 23402 RVA: 0x001CFD8C File Offset: 0x001CDF8C
		// (set) Token: 0x06005B6B RID: 23403 RVA: 0x00031AF7 File Offset: 0x0002FCF7
		public unsafe float m_PatchouliSpellCoolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_PatchouliSpellCoolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_PatchouliSpellCoolDown)) = value;
			}
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x06005B6C RID: 23404 RVA: 0x001CFDB4 File Offset: 0x001CDFB4
		// (set) Token: 0x06005B6D RID: 23405 RVA: 0x00031B12 File Offset: 0x0002FD12
		public unsafe int m_PatchouliSpellPCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_PatchouliSpellPCost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_PatchouliSpellPCost)) = value;
			}
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x06005B6E RID: 23406 RVA: 0x001CFDDC File Offset: 0x001CDFDC
		// (set) Token: 0x06005B6F RID: 23407 RVA: 0x00031B2D File Offset: 0x0002FD2D
		public unsafe Il2CppStructArray<DLC4_MystiaVSFlandreBossData.PartnerMapping> m_PartnerMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_PartnerMapping);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DLC4_MystiaVSFlandreBossData.PartnerMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_PartnerMapping), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x06005B70 RID: 23408 RVA: 0x001CFE0C File Offset: 0x001CE00C
		// (set) Token: 0x06005B71 RID: 23409 RVA: 0x00031B4C File Offset: 0x0002FD4C
		public unsafe Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.EnemyMapping> m_FlandreController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_FlandreController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.EnemyMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_FlandreController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x06005B72 RID: 23410 RVA: 0x001CFE3C File Offset: 0x001CE03C
		// (set) Token: 0x06005B73 RID: 23411 RVA: 0x00031B6B File Offset: 0x0002FD6B
		public VFXPrefab m_BrokenTablePic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BrokenTablePic);
				return new VFXPrefab(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BrokenTablePic), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VFXPrefab>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x06005B74 RID: 23412 RVA: 0x001CFE6C File Offset: 0x001CE06C
		// (set) Token: 0x06005B75 RID: 23413 RVA: 0x00031B99 File Offset: 0x0002FD99
		public unsafe int m_LockTableDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_LockTableDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_LockTableDuration)) = value;
			}
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06005B76 RID: 23414 RVA: 0x001CFE94 File Offset: 0x001CE094
		// (set) Token: 0x06005B77 RID: 23415 RVA: 0x00031BB4 File Offset: 0x0002FDB4
		public unsafe GameObject poisonVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_poisonVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_poisonVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x06005B78 RID: 23416 RVA: 0x001CFEC4 File Offset: 0x001CE0C4
		// (set) Token: 0x06005B79 RID: 23417 RVA: 0x00031BD3 File Offset: 0x0002FDD3
		public unsafe MultiLanguageTextMesh.MultiLanguageTextAsset m_GuardManualTxt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_GuardManualTxt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageTextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_GuardManualTxt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x06005B7A RID: 23418 RVA: 0x001CFEF4 File Offset: 0x001CE0F4
		// (set) Token: 0x06005B7B RID: 23419 RVA: 0x00031BF2 File Offset: 0x0002FDF2
		public unsafe MultiLanguageTextMesh.MultiLanguageTextAsset m_SpellManualTxt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellManualTxt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageTextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellManualTxt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x06005B7C RID: 23420 RVA: 0x001CFF24 File Offset: 0x001CE124
		// (set) Token: 0x06005B7D RID: 23421 RVA: 0x00031C11 File Offset: 0x0002FE11
		public unsafe float m_LastLineXPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_LastLineXPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_LastLineXPosition)) = value;
			}
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x06005B7E RID: 23422 RVA: 0x001CFF4C File Offset: 0x001CE14C
		// (set) Token: 0x06005B7F RID: 23423 RVA: 0x00031C2C File Offset: 0x0002FE2C
		public unsafe float m_FirstRefreshEnemyNeedToWait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_FirstRefreshEnemyNeedToWait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_FirstRefreshEnemyNeedToWait)) = value;
			}
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06005B80 RID: 23424 RVA: 0x001CFF74 File Offset: 0x001CE174
		// (set) Token: 0x06005B81 RID: 23425 RVA: 0x00031C47 File Offset: 0x0002FE47
		public unsafe float m_DamageCheckingPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_DamageCheckingPercentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_DamageCheckingPercentage)) = value;
			}
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06005B82 RID: 23426 RVA: 0x001CFF9C File Offset: 0x001CE19C
		// (set) Token: 0x06005B83 RID: 23427 RVA: 0x00031C62 File Offset: 0x0002FE62
		public unsafe float m_MinWaitTimeToNextWave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_MinWaitTimeToNextWave);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_MinWaitTimeToNextWave)) = value;
			}
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x06005B84 RID: 23428 RVA: 0x001CFFC4 File Offset: 0x001CE1C4
		// (set) Token: 0x06005B85 RID: 23429 RVA: 0x00031C7D File Offset: 0x0002FE7D
		public unsafe float m_WaitTimeToNextWaveDueToDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_WaitTimeToNextWaveDueToDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_WaitTimeToNextWaveDueToDamage)) = value;
			}
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x06005B86 RID: 23430 RVA: 0x001CFFEC File Offset: 0x001CE1EC
		// (set) Token: 0x06005B87 RID: 23431 RVA: 0x00031C98 File Offset: 0x0002FE98
		public unsafe Vector2 m_ToRefreshNextWaveLeastWait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_ToRefreshNextWaveLeastWait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_ToRefreshNextWaveLeastWait)) = value;
			}
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x06005B88 RID: 23432 RVA: 0x001D0014 File Offset: 0x001CE214
		// (set) Token: 0x06005B89 RID: 23433 RVA: 0x00031CB3 File Offset: 0x0002FEB3
		public unsafe float m_ToRefreshNextBigWaveLeastWait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_ToRefreshNextBigWaveLeastWait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_ToRefreshNextBigWaveLeastWait)) = value;
			}
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x06005B8A RID: 23434 RVA: 0x001D003C File Offset: 0x001CE23C
		// (set) Token: 0x06005B8B RID: 23435 RVA: 0x00031CCE File Offset: 0x0002FECE
		public unsafe Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.BigWaveProperty> m_BigWaveProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BigWaveProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.BigWaveProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BigWaveProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06005B8C RID: 23436 RVA: 0x001D006C File Offset: 0x001CE26C
		// (set) Token: 0x06005B8D RID: 23437 RVA: 0x00031CED File Offset: 0x0002FEED
		public unsafe Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.BigWaveProperty> m_BigWavePropertyNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BigWavePropertyNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.BigWaveProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BigWavePropertyNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x06005B8E RID: 23438 RVA: 0x001D009C File Offset: 0x001CE29C
		// (set) Token: 0x06005B8F RID: 23439 RVA: 0x00031D0C File Offset: 0x0002FF0C
		public unsafe Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.BigWaveProperty> m_BigWavePropertyHard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BigWavePropertyHard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.BigWaveProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BigWavePropertyHard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x06005B90 RID: 23440 RVA: 0x001D00CC File Offset: 0x001CE2CC
		// (set) Token: 0x06005B91 RID: 23441 RVA: 0x00031D2B File Offset: 0x0002FF2B
		public unsafe Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.BigWaveProperty> m_BigWavePropertyLunatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BigWavePropertyLunatic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.BigWaveProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_BigWavePropertyLunatic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x06005B92 RID: 23442 RVA: 0x001D00FC File Offset: 0x001CE2FC
		// (set) Token: 0x06005B93 RID: 23443 RVA: 0x00031D4A File Offset: 0x0002FF4A
		public unsafe AudioClip defaultTeamBulletHitSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_defaultTeamBulletHitSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_defaultTeamBulletHitSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x06005B94 RID: 23444 RVA: 0x001D012C File Offset: 0x001CE32C
		// (set) Token: 0x06005B95 RID: 23445 RVA: 0x00031D69 File Offset: 0x0002FF69
		public unsafe AudioClip level2Sfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_level2Sfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_level2Sfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x06005B96 RID: 23446 RVA: 0x001D015C File Offset: 0x001CE35C
		// (set) Token: 0x06005B97 RID: 23447 RVA: 0x00031D88 File Offset: 0x0002FF88
		public unsafe AudioClip skillSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_skillSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_skillSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x06005B98 RID: 23448 RVA: 0x001D018C File Offset: 0x001CE38C
		// (set) Token: 0x06005B99 RID: 23449 RVA: 0x00031DA7 File Offset: 0x0002FFA7
		public unsafe Action onChallengeEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_onChallengeEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_onChallengeEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x06005B9A RID: 23450 RVA: 0x001D01BC File Offset: 0x001CE3BC
		// (set) Token: 0x06005B9B RID: 23451 RVA: 0x00031DC6 File Offset: 0x0002FFC6
		public unsafe SpellMetal m_SpellMetal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellMetal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellMetal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellMetal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x06005B9C RID: 23452 RVA: 0x001D01EC File Offset: 0x001CE3EC
		// (set) Token: 0x06005B9D RID: 23453 RVA: 0x00031DE5 File Offset: 0x0002FFE5
		public unsafe SpellWood m_SpellWood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellWood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellWood>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellWood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x06005B9E RID: 23454 RVA: 0x001D021C File Offset: 0x001CE41C
		// (set) Token: 0x06005B9F RID: 23455 RVA: 0x00031E04 File Offset: 0x00030004
		public unsafe SpellWater m_SpellWater
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellWater);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellWater>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellWater), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x06005BA0 RID: 23456 RVA: 0x001D024C File Offset: 0x001CE44C
		// (set) Token: 0x06005BA1 RID: 23457 RVA: 0x00031E23 File Offset: 0x00030023
		public unsafe SpellFire m_SpellFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellFire);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellFire>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellFire), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x06005BA2 RID: 23458 RVA: 0x001D027C File Offset: 0x001CE47C
		// (set) Token: 0x06005BA3 RID: 23459 RVA: 0x00031E42 File Offset: 0x00030042
		public unsafe SpellEarth m_SpellEarth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellEarth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellEarth>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellEarth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x06005BA4 RID: 23460 RVA: 0x001D02AC File Offset: 0x001CE4AC
		// (set) Token: 0x06005BA5 RID: 23461 RVA: 0x00031E61 File Offset: 0x00030061
		public unsafe SpellSun m_SpellSun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellSun);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellSun>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellSun), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x06005BA6 RID: 23462 RVA: 0x001D02DC File Offset: 0x001CE4DC
		// (set) Token: 0x06005BA7 RID: 23463 RVA: 0x00031E80 File Offset: 0x00030080
		public unsafe SpellMoon m_SpellMoon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellMoon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellMoon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.NativeFieldInfoPtr_m_SpellMoon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CA5 RID: 15525
		private static readonly IntPtr NativeFieldInfoPtr_m_StartFund;

		// Token: 0x04003CA6 RID: 15526
		private static readonly IntPtr NativeFieldInfoPtr_m_GuardMappingDic;

		// Token: 0x04003CA7 RID: 15527
		private static readonly IntPtr NativeFieldInfoPtr_m_CardSelectorPanel;

		// Token: 0x04003CA8 RID: 15528
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC4BossBattleShopPanel;

		// Token: 0x04003CA9 RID: 15529
		private static readonly IntPtr NativeFieldInfoPtr_m_DLC4BossBattlePatchouliSpellPanelPanel;

		// Token: 0x04003CAA RID: 15530
		private static readonly IntPtr NativeFieldInfoPtr_flagLevel1;

		// Token: 0x04003CAB RID: 15531
		private static readonly IntPtr NativeFieldInfoPtr_flagLevel2;

		// Token: 0x04003CAC RID: 15532
		private static readonly IntPtr NativeFieldInfoPtr_levelUpTo2;

		// Token: 0x04003CAD RID: 15533
		private static readonly IntPtr NativeFieldInfoPtr_levelUpAndSkill;

		// Token: 0x04003CAE RID: 15534
		private static readonly IntPtr NativeFieldInfoPtr_level2Vfx;

		// Token: 0x04003CAF RID: 15535
		private static readonly IntPtr NativeFieldInfoPtr_flagOffset;

		// Token: 0x04003CB0 RID: 15536
		private static readonly IntPtr NativeFieldInfoPtr_m_PatchouliSpellMaxNum;

		// Token: 0x04003CB1 RID: 15537
		private static readonly IntPtr NativeFieldInfoPtr_m_PatchouliSpellCoolDown;

		// Token: 0x04003CB2 RID: 15538
		private static readonly IntPtr NativeFieldInfoPtr_m_PatchouliSpellPCost;

		// Token: 0x04003CB3 RID: 15539
		private static readonly IntPtr NativeFieldInfoPtr_m_PartnerMapping;

		// Token: 0x04003CB4 RID: 15540
		private static readonly IntPtr NativeFieldInfoPtr_m_FlandreController;

		// Token: 0x04003CB5 RID: 15541
		private static readonly IntPtr NativeFieldInfoPtr_m_BrokenTablePic;

		// Token: 0x04003CB6 RID: 15542
		private static readonly IntPtr NativeFieldInfoPtr_m_LockTableDuration;

		// Token: 0x04003CB7 RID: 15543
		private static readonly IntPtr NativeFieldInfoPtr_poisonVFX;

		// Token: 0x04003CB8 RID: 15544
		private static readonly IntPtr NativeFieldInfoPtr_m_GuardManualTxt;

		// Token: 0x04003CB9 RID: 15545
		private static readonly IntPtr NativeFieldInfoPtr_m_SpellManualTxt;

		// Token: 0x04003CBA RID: 15546
		private static readonly IntPtr NativeFieldInfoPtr_m_LastLineXPosition;

		// Token: 0x04003CBB RID: 15547
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstRefreshEnemyNeedToWait;

		// Token: 0x04003CBC RID: 15548
		private static readonly IntPtr NativeFieldInfoPtr_m_DamageCheckingPercentage;

		// Token: 0x04003CBD RID: 15549
		private static readonly IntPtr NativeFieldInfoPtr_m_MinWaitTimeToNextWave;

		// Token: 0x04003CBE RID: 15550
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitTimeToNextWaveDueToDamage;

		// Token: 0x04003CBF RID: 15551
		private static readonly IntPtr NativeFieldInfoPtr_m_ToRefreshNextWaveLeastWait;

		// Token: 0x04003CC0 RID: 15552
		private static readonly IntPtr NativeFieldInfoPtr_m_ToRefreshNextBigWaveLeastWait;

		// Token: 0x04003CC1 RID: 15553
		private static readonly IntPtr NativeFieldInfoPtr_m_BigWaveProperty;

		// Token: 0x04003CC2 RID: 15554
		private static readonly IntPtr NativeFieldInfoPtr_m_BigWavePropertyNormal;

		// Token: 0x04003CC3 RID: 15555
		private static readonly IntPtr NativeFieldInfoPtr_m_BigWavePropertyHard;

		// Token: 0x04003CC4 RID: 15556
		private static readonly IntPtr NativeFieldInfoPtr_m_BigWavePropertyLunatic;

		// Token: 0x04003CC5 RID: 15557
		private static readonly IntPtr NativeFieldInfoPtr_defaultTeamBulletHitSfx;

		// Token: 0x04003CC6 RID: 15558
		private static readonly IntPtr NativeFieldInfoPtr_level2Sfx;

		// Token: 0x04003CC7 RID: 15559
		private static readonly IntPtr NativeFieldInfoPtr_skillSfx;

		// Token: 0x04003CC8 RID: 15560
		private static readonly IntPtr NativeFieldInfoPtr_onChallengeEnd;

		// Token: 0x04003CC9 RID: 15561
		private static readonly IntPtr NativeFieldInfoPtr_m_SpellMetal;

		// Token: 0x04003CCA RID: 15562
		private static readonly IntPtr NativeFieldInfoPtr_m_SpellWood;

		// Token: 0x04003CCB RID: 15563
		private static readonly IntPtr NativeFieldInfoPtr_m_SpellWater;

		// Token: 0x04003CCC RID: 15564
		private static readonly IntPtr NativeFieldInfoPtr_m_SpellFire;

		// Token: 0x04003CCD RID: 15565
		private static readonly IntPtr NativeFieldInfoPtr_m_SpellEarth;

		// Token: 0x04003CCE RID: 15566
		private static readonly IntPtr NativeFieldInfoPtr_m_SpellSun;

		// Token: 0x04003CCF RID: 15567
		private static readonly IntPtr NativeFieldInfoPtr_m_SpellMoon;

		// Token: 0x04003CD0 RID: 15568
		private static readonly IntPtr NativeMethodInfoPtr_GetWaveData_Private_Il2CppReferenceArray_1_BigWaveProperty_0;

		// Token: 0x04003CD1 RID: 15569
		private static readonly IntPtr NativeMethodInfoPtr_OnPreloadGeneralChallenge_Private_Void_0;

		// Token: 0x04003CD2 RID: 15570
		private static readonly IntPtr NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0;

		// Token: 0x04003CD3 RID: 15571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CEE RID: 3310
		[Serializable]
		[StructLayout(2)]
		public struct PartnerMapping
		{
			// Token: 0x0600EDF5 RID: 60917 RVA: 0x0038A1FC File Offset: 0x003883FC
			// Note: this type is marked as 'beforefieldinit'.
			static PartnerMapping()
			{
				Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.PartnerMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "PartnerMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.PartnerMapping>.NativeClassPtr);
				DLC4_MystiaVSFlandreBossData.PartnerMapping.NativeFieldInfoPtr_PartnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.PartnerMapping>.NativeClassPtr, "PartnerId");
				DLC4_MystiaVSFlandreBossData.PartnerMapping.NativeFieldInfoPtr_PartnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.PartnerMapping>.NativeClassPtr, "PartnerType");
			}

			// Token: 0x0600EDF6 RID: 60918 RVA: 0x0007F7C7 File Offset: 0x0007D9C7
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.PartnerMapping>.NativeClassPtr, ref this));
			}

			// Token: 0x040097A3 RID: 38819
			private static readonly IntPtr NativeFieldInfoPtr_PartnerId;

			// Token: 0x040097A4 RID: 38820
			private static readonly IntPtr NativeFieldInfoPtr_PartnerType;

			// Token: 0x040097A5 RID: 38821
			[FieldOffset(0)]
			public int PartnerId;

			// Token: 0x040097A6 RID: 38822
			[FieldOffset(4)]
			public PartnerBase.PartnerType PartnerType;
		}

		// Token: 0x02000CEF RID: 3311
		[Serializable]
		public sealed class EnemyMapping : ValueType
		{
			// Token: 0x0600EDF7 RID: 60919 RVA: 0x0038A250 File Offset: 0x00388450
			// Note: this type is marked as 'beforefieldinit'.
			static EnemyMapping()
			{
				Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.EnemyMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "EnemyMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.EnemyMapping>.NativeClassPtr);
				DLC4_MystiaVSFlandreBossData.EnemyMapping.NativeFieldInfoPtr_EnemyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.EnemyMapping>.NativeClassPtr, "EnemyType");
				DLC4_MystiaVSFlandreBossData.EnemyMapping.NativeFieldInfoPtr_FlandreController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.EnemyMapping>.NativeClassPtr, "FlandreController");
			}

			// Token: 0x0600EDF8 RID: 60920 RVA: 0x0007F7D9 File Offset: 0x0007D9D9
			public EnemyMapping(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600EDF9 RID: 60921 RVA: 0x0007F7E2 File Offset: 0x0007D9E2
			public EnemyMapping() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.EnemyMapping>.NativeClassPtr))
			{
			}

			// Token: 0x17004D64 RID: 19812
			// (get) Token: 0x0600EDFA RID: 60922 RVA: 0x0038A2A4 File Offset: 0x003884A4
			// (set) Token: 0x0600EDFB RID: 60923 RVA: 0x0007F7F4 File Offset: 0x0007D9F4
			public unsafe FlandreTypeIndex EnemyType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.EnemyMapping.NativeFieldInfoPtr_EnemyType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.EnemyMapping.NativeFieldInfoPtr_EnemyType)) = value;
				}
			}

			// Token: 0x17004D65 RID: 19813
			// (get) Token: 0x0600EDFC RID: 60924 RVA: 0x0038A2CC File Offset: 0x003884CC
			// (set) Token: 0x0600EDFD RID: 60925 RVA: 0x0007F80F File Offset: 0x0007DA0F
			public unsafe GameObject FlandreController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.EnemyMapping.NativeFieldInfoPtr_FlandreController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.EnemyMapping.NativeFieldInfoPtr_FlandreController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097A7 RID: 38823
			private static readonly IntPtr NativeFieldInfoPtr_EnemyType;

			// Token: 0x040097A8 RID: 38824
			private static readonly IntPtr NativeFieldInfoPtr_FlandreController;
		}

		// Token: 0x02000CF0 RID: 3312
		[Serializable]
		public sealed class BigWaveProperty : ValueType
		{
			// Token: 0x0600EDFE RID: 60926 RVA: 0x0007F82E File Offset: 0x0007DA2E
			// Note: this type is marked as 'beforefieldinit'.
			static BigWaveProperty()
			{
				Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.BigWaveProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "BigWaveProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.BigWaveProperty>.NativeClassPtr);
				DLC4_MystiaVSFlandreBossData.BigWaveProperty.NativeFieldInfoPtr_WaveProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.BigWaveProperty>.NativeClassPtr, "WaveProperties");
			}

			// Token: 0x0600EDFF RID: 60927 RVA: 0x0007F862 File Offset: 0x0007DA62
			public BigWaveProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600EE00 RID: 60928 RVA: 0x0007F86B File Offset: 0x0007DA6B
			public BigWaveProperty() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.BigWaveProperty>.NativeClassPtr))
			{
			}

			// Token: 0x17004D66 RID: 19814
			// (get) Token: 0x0600EE01 RID: 60929 RVA: 0x0038A2FC File Offset: 0x003884FC
			// (set) Token: 0x0600EE02 RID: 60930 RVA: 0x0007F87D File Offset: 0x0007DA7D
			public unsafe List<DLC4_MystiaVSFlandreBossData.WaveProperty> WaveProperties
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.BigWaveProperty.NativeFieldInfoPtr_WaveProperties);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC4_MystiaVSFlandreBossData.WaveProperty>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.BigWaveProperty.NativeFieldInfoPtr_WaveProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097A9 RID: 38825
			private static readonly IntPtr NativeFieldInfoPtr_WaveProperties;
		}

		// Token: 0x02000CF1 RID: 3313
		[Serializable]
		public sealed class WaveProperty : ValueType
		{
			// Token: 0x0600EE03 RID: 60931 RVA: 0x0038A32C File Offset: 0x0038852C
			// Note: this type is marked as 'beforefieldinit'.
			static WaveProperty()
			{
				Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.WaveProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "WaveProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.WaveProperty>.NativeClassPtr);
				DLC4_MystiaVSFlandreBossData.WaveProperty.NativeFieldInfoPtr_EventDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.WaveProperty>.NativeClassPtr, "EventDialog");
				DLC4_MystiaVSFlandreBossData.WaveProperty.NativeFieldInfoPtr_EnemyRefreshProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.WaveProperty>.NativeClassPtr, "EnemyRefreshProperties");
			}

			// Token: 0x0600EE04 RID: 60932 RVA: 0x0007F89C File Offset: 0x0007DA9C
			public WaveProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600EE05 RID: 60933 RVA: 0x0007F8A5 File Offset: 0x0007DAA5
			public WaveProperty() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.WaveProperty>.NativeClassPtr))
			{
			}

			// Token: 0x17004D67 RID: 19815
			// (get) Token: 0x0600EE06 RID: 60934 RVA: 0x0038A380 File Offset: 0x00388580
			// (set) Token: 0x0600EE07 RID: 60935 RVA: 0x0007F8B7 File Offset: 0x0007DAB7
			public unsafe DialogPackage EventDialog
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.WaveProperty.NativeFieldInfoPtr_EventDialog);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.WaveProperty.NativeFieldInfoPtr_EventDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D68 RID: 19816
			// (get) Token: 0x0600EE08 RID: 60936 RVA: 0x0038A3B0 File Offset: 0x003885B0
			// (set) Token: 0x0600EE09 RID: 60937 RVA: 0x0007F8D6 File Offset: 0x0007DAD6
			public unsafe List<DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty> EnemyRefreshProperties
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.WaveProperty.NativeFieldInfoPtr_EnemyRefreshProperties);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.WaveProperty.NativeFieldInfoPtr_EnemyRefreshProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097AA RID: 38826
			private static readonly IntPtr NativeFieldInfoPtr_EventDialog;

			// Token: 0x040097AB RID: 38827
			private static readonly IntPtr NativeFieldInfoPtr_EnemyRefreshProperties;
		}

		// Token: 0x02000CF2 RID: 3314
		[Serializable]
		[StructLayout(2)]
		public struct EnemyRefreshProperty
		{
			// Token: 0x0600EE0A RID: 60938 RVA: 0x0038A3E0 File Offset: 0x003885E0
			// Note: this type is marked as 'beforefieldinit'.
			static EnemyRefreshProperty()
			{
				Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "EnemyRefreshProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty>.NativeClassPtr);
				DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.NativeFieldInfoPtr_EnemyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty>.NativeClassPtr, "EnemyType");
				DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.NativeFieldInfoPtr_EnemySpawnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty>.NativeClassPtr, "EnemySpawnType");
				DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.NativeFieldInfoPtr_EnemyRefreshNextWaveType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty>.NativeClassPtr, "EnemyRefreshNextWaveType");
				DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.NativeFieldInfoPtr_Num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty>.NativeClassPtr, "Num");
			}

			// Token: 0x0600EE0B RID: 60939 RVA: 0x0007F8F5 File Offset: 0x0007DAF5
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty>.NativeClassPtr, ref this));
			}

			// Token: 0x040097AC RID: 38828
			private static readonly IntPtr NativeFieldInfoPtr_EnemyType;

			// Token: 0x040097AD RID: 38829
			private static readonly IntPtr NativeFieldInfoPtr_EnemySpawnType;

			// Token: 0x040097AE RID: 38830
			private static readonly IntPtr NativeFieldInfoPtr_EnemyRefreshNextWaveType;

			// Token: 0x040097AF RID: 38831
			private static readonly IntPtr NativeFieldInfoPtr_Num;

			// Token: 0x040097B0 RID: 38832
			[FieldOffset(0)]
			public FlandreTypeIndex EnemyType;

			// Token: 0x040097B1 RID: 38833
			[FieldOffset(4)]
			public DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.SpawnType EnemySpawnType;

			// Token: 0x040097B2 RID: 38834
			[FieldOffset(8)]
			public DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.RefreshNextWaveType EnemyRefreshNextWaveType;

			// Token: 0x040097B3 RID: 38835
			[FieldOffset(12)]
			public int Num;

			// Token: 0x0200107E RID: 4222
			public enum RefreshNextWaveType
			{
				// Token: 0x0400B64D RID: 46669
				Normal,
				// Token: 0x0400B64E RID: 46670
				WaitUntilDie,
				// Token: 0x0400B64F RID: 46671
				None
			}

			// Token: 0x0200107F RID: 4223
			public enum SpawnType
			{
				// Token: 0x0400B651 RID: 46673
				NormalDistribution,
				// Token: 0x0400B652 RID: 46674
				Random,
				// Token: 0x0400B653 RID: 46675
				FindMinimum,
				// Token: 0x0400B654 RID: 46676
				None
			}
		}

		// Token: 0x02000CF3 RID: 3315
		public class FlandreData : Il2CppSystem.Object
		{
			// Token: 0x0600EE0C RID: 60940 RVA: 0x0038A45C File Offset: 0x0038865C
			// Note: this type is marked as 'beforefieldinit'.
			static FlandreData()
			{
				Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.FlandreData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "FlandreData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.FlandreData>.NativeClassPtr);
				DLC4_MystiaVSFlandreBossData.FlandreData.NativeFieldInfoPtr_use = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.FlandreData>.NativeClassPtr, "use");
				DLC4_MystiaVSFlandreBossData.FlandreData.NativeFieldInfoPtr__m_BigWaveProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.FlandreData>.NativeClassPtr, "<m_BigWaveProperty>k__BackingField");
				DLC4_MystiaVSFlandreBossData.FlandreData.NativeMethodInfoPtr_get_m_BigWaveProperty_Public_get_List_1_BigWaveProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.FlandreData>.NativeClassPtr, 100681943);
				DLC4_MystiaVSFlandreBossData.FlandreData.NativeMethodInfoPtr_set_m_BigWaveProperty_Public_set_Void_List_1_BigWaveProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.FlandreData>.NativeClassPtr, 100681944);
				DLC4_MystiaVSFlandreBossData.FlandreData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.FlandreData>.NativeClassPtr, 100681945);
			}

			// Token: 0x17004D6B RID: 19819
			// (get) Token: 0x0600EE0D RID: 60941 RVA: 0x0038A4EC File Offset: 0x003886EC
			// (set) Token: 0x0600EE0E RID: 60942 RVA: 0x0038A52C File Offset: 0x0038872C
			public unsafe List<DLC4_MystiaVSFlandreBossData.BigWaveProperty> m_BigWaveProperty
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.FlandreData.NativeMethodInfoPtr_get_m_BigWaveProperty_Public_get_List_1_BigWaveProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DLC4_MystiaVSFlandreBossData.BigWaveProperty>>(intPtr3) : null;
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.FlandreData.NativeMethodInfoPtr_set_m_BigWaveProperty_Public_set_Void_List_1_BigWaveProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600EE0F RID: 60943 RVA: 0x0038A570 File Offset: 0x00388770
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FlandreData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.FlandreData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.FlandreData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE10 RID: 60944 RVA: 0x0007F907 File Offset: 0x0007DB07
			public FlandreData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D69 RID: 19817
			// (get) Token: 0x0600EE11 RID: 60945 RVA: 0x0038A5AC File Offset: 0x003887AC
			// (set) Token: 0x0600EE12 RID: 60946 RVA: 0x0007F910 File Offset: 0x0007DB10
			public unsafe bool use
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.FlandreData.NativeFieldInfoPtr_use);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.FlandreData.NativeFieldInfoPtr_use)) = value;
				}
			}

			// Token: 0x17004D6A RID: 19818
			// (get) Token: 0x0600EE13 RID: 60947 RVA: 0x0038A5D4 File Offset: 0x003887D4
			// (set) Token: 0x0600EE14 RID: 60948 RVA: 0x0007F92B File Offset: 0x0007DB2B
			public unsafe List<DLC4_MystiaVSFlandreBossData.BigWaveProperty> _m_BigWaveProperty_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.FlandreData.NativeFieldInfoPtr__m_BigWaveProperty_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC4_MystiaVSFlandreBossData.BigWaveProperty>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.FlandreData.NativeFieldInfoPtr__m_BigWaveProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097B4 RID: 38836
			private static readonly IntPtr NativeFieldInfoPtr_use;

			// Token: 0x040097B5 RID: 38837
			private static readonly IntPtr NativeFieldInfoPtr__m_BigWaveProperty_k__BackingField;

			// Token: 0x040097B6 RID: 38838
			private static readonly IntPtr NativeMethodInfoPtr_get_m_BigWaveProperty_Public_get_List_1_BigWaveProperty_0;

			// Token: 0x040097B7 RID: 38839
			private static readonly IntPtr NativeMethodInfoPtr_set_m_BigWaveProperty_Public_set_Void_List_1_BigWaveProperty_0;

			// Token: 0x040097B8 RID: 38840
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000CF4 RID: 3316
		[ObfuscatedName("GameData.Profile.DLC4_MystiaVSFlandreBossData+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EE15 RID: 60949 RVA: 0x0038A604 File Offset: 0x00388804
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0>.NativeClassPtr);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0.NativeFieldInfoPtr_foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0>.NativeClassPtr, "foods");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0.NativeFieldInfoPtr_bevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0>.NativeClassPtr, "bevs");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0.NativeFieldInfoPtr_ings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0>.NativeClassPtr, "ings");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0>.NativeClassPtr, 100681946);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0>.NativeClassPtr, 100681947);
			}

			// Token: 0x0600EE16 RID: 60950 RVA: 0x0038A694 File Offset: 0x00388894
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE17 RID: 60951 RVA: 0x0038A6D0 File Offset: 0x003888D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPreloadGeneralChallenge_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0.NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE18 RID: 60952 RVA: 0x0007F94A File Offset: 0x0007DB4A
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D6C RID: 19820
			// (get) Token: 0x0600EE19 RID: 60953 RVA: 0x0038A704 File Offset: 0x00388904
			// (set) Token: 0x0600EE1A RID: 60954 RVA: 0x0007F953 File Offset: 0x0007DB53
			public unsafe IEnumerable<KeyValuePair<int, int>> foods
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0.NativeFieldInfoPtr_foods);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0.NativeFieldInfoPtr_foods), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D6D RID: 19821
			// (get) Token: 0x0600EE1B RID: 60955 RVA: 0x0038A734 File Offset: 0x00388934
			// (set) Token: 0x0600EE1C RID: 60956 RVA: 0x0007F972 File Offset: 0x0007DB72
			public unsafe IEnumerable<KeyValuePair<int, int>> bevs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0.NativeFieldInfoPtr_bevs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0.NativeFieldInfoPtr_bevs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D6E RID: 19822
			// (get) Token: 0x0600EE1D RID: 60957 RVA: 0x0038A764 File Offset: 0x00388964
			// (set) Token: 0x0600EE1E RID: 60958 RVA: 0x0007F991 File Offset: 0x0007DB91
			public unsafe IEnumerable<KeyValuePair<int, int>> ings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0.NativeFieldInfoPtr_ings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass37_0.NativeFieldInfoPtr_ings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097B9 RID: 38841
			private static readonly IntPtr NativeFieldInfoPtr_foods;

			// Token: 0x040097BA RID: 38842
			private static readonly IntPtr NativeFieldInfoPtr_bevs;

			// Token: 0x040097BB RID: 38843
			private static readonly IntPtr NativeFieldInfoPtr_ings;

			// Token: 0x040097BC RID: 38844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097BD RID: 38845
			private static readonly IntPtr NativeMethodInfoPtr__OnPreloadGeneralChallenge_b__0_Internal_Void_0;
		}

		// Token: 0x02000CF5 RID: 3317
		[ObfuscatedName("GameData.Profile.DLC4_MystiaVSFlandreBossData+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EE1F RID: 60959 RVA: 0x0038A794 File Offset: 0x00388994
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_pachiSpellTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "pachiSpellTexts");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_hasLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "hasLoaded");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_izakayaConfigure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "izakayaConfigure");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_bossBattleManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "bossBattleManager");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "canContinue");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_eachWaveProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "eachWaveProgress");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_eachBigWaveProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "eachBigWaveProgress");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_progressPerSecAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "progressPerSecAdd");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_currentProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "currentProgress");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_thisWaveStartProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "thisWaveStartProgress");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "eventManager");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_statusDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "statusDisplayer");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_checkFinalWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "checkFinalWave");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "<>4__this");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_flandreData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "flandreData");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_eachBigWavePassion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "eachBigWavePassion");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_shouldTimeFlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "shouldTimeFlow");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_isFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "isFailed");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_giveBadge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "giveBadge");
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681948);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_LanguageBase_PatchouliMagicSpellCardIndex_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681949);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681950);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681951);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__7_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681952);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__8_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681953);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Void_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681954);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681955);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681956);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681957);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681958);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681959);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681960);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681961);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681962);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681963);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681964);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__20_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681965);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__21_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681966);
				DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, 100681967);
			}

			// Token: 0x0600EE20 RID: 60960 RVA: 0x0038AACC File Offset: 0x00388CCC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE21 RID: 60961 RVA: 0x0038AB08 File Offset: 0x00388D08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226010, XrefRangeEnd = 226026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LanguageBase Method_Internal_LanguageBase_PatchouliMagicSpellCardIndex_PDM_0(PatchouliMagicSpellCardIndex index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_LanguageBase_PatchouliMagicSpellCardIndex_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr3) : null;
			}

			// Token: 0x0600EE22 RID: 60962 RVA: 0x0038AB54 File Offset: 0x00388D54
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EE23 RID: 60963 RVA: 0x0038AB90 File Offset: 0x00388D90
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EE24 RID: 60964 RVA: 0x0038ABCC File Offset: 0x00388DCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226026, XrefRangeEnd = 226028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__7(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__7_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE25 RID: 60965 RVA: 0x0038AC0C File Offset: 0x00388E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226028, XrefRangeEnd = 226030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__8(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__8_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE26 RID: 60966 RVA: 0x0038AC4C File Offset: 0x00388E4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226030, XrefRangeEnd = 226031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__9(ValueTuple<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Void_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE27 RID: 60967 RVA: 0x0038AC94 File Offset: 0x00388E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226031, XrefRangeEnd = 226132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Method_Internal_String_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EE28 RID: 60968 RVA: 0x0038ACCC File Offset: 0x00388ECC
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EE29 RID: 60969 RVA: 0x0038AD08 File Offset: 0x00388F08
			[CallerCount(0)]
			public unsafe void Method_Internal_Void_Int32_Single_PDM_0(int thisBigWaveWaveNum, float refreshTime)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref thisBigWaveWaveNum;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref refreshTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE2A RID: 60970 RVA: 0x0038AD54 File Offset: 0x00388F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226132, XrefRangeEnd = 226141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_PDM_0(bool isFinalWave)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref isFinalWave;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE2B RID: 60971 RVA: 0x0038AD94 File Offset: 0x00388F94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226141, XrefRangeEnd = 226146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EE2C RID: 60972 RVA: 0x0038ADD4 File Offset: 0x00388FD4
			[CallerCount(0)]
			public unsafe void Method_Internal_Void_Int32_PDM_0(int thisBigWaveWaveNum)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref thisBigWaveWaveNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE2D RID: 60973 RVA: 0x0038AE14 File Offset: 0x00389014
			[CallerCount(0)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE2E RID: 60974 RVA: 0x0038AE48 File Offset: 0x00389048
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 226149, RefRangeEnd = 226150, XrefRangeStart = 226146, XrefRangeEnd = 226149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE2F RID: 60975 RVA: 0x0038AE7C File Offset: 0x0038907C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 226155, RefRangeEnd = 226156, XrefRangeStart = 226150, XrefRangeEnd = 226155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EE30 RID: 60976 RVA: 0x0038AEBC File Offset: 0x003890BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226156, XrefRangeEnd = 226157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EE31 RID: 60977 RVA: 0x0038AEF8 File Offset: 0x003890F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226157, XrefRangeEnd = 226158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__20()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__20_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EE32 RID: 60978 RVA: 0x0038AF34 File Offset: 0x00389134
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__21()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr__MainChallengeLoop_b__21_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE33 RID: 60979 RVA: 0x0038AF68 File Offset: 0x00389168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226158, XrefRangeEnd = 226168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE34 RID: 60980 RVA: 0x0007F9B0 File Offset: 0x0007DBB0
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D6F RID: 19823
			// (get) Token: 0x0600EE35 RID: 60981 RVA: 0x0038AF9C File Offset: 0x0038919C
			// (set) Token: 0x0600EE36 RID: 60982 RVA: 0x0007F9B9 File Offset: 0x0007DBB9
			public unsafe Dictionary<string, LanguageBase> pachiSpellTexts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_pachiSpellTexts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LanguageBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_pachiSpellTexts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D70 RID: 19824
			// (get) Token: 0x0600EE37 RID: 60983 RVA: 0x0038AFCC File Offset: 0x003891CC
			// (set) Token: 0x0600EE38 RID: 60984 RVA: 0x0007F9D8 File Offset: 0x0007DBD8
			public unsafe int hasLoaded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_hasLoaded);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_hasLoaded)) = value;
				}
			}

			// Token: 0x17004D71 RID: 19825
			// (get) Token: 0x0600EE39 RID: 60985 RVA: 0x0038AFF4 File Offset: 0x003891F4
			// (set) Token: 0x0600EE3A RID: 60986 RVA: 0x0007F9F3 File Offset: 0x0007DBF3
			public unsafe IzakayaConfigure izakayaConfigure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_izakayaConfigure);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigure>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_izakayaConfigure), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D72 RID: 19826
			// (get) Token: 0x0600EE3B RID: 60987 RVA: 0x0038B024 File Offset: 0x00389224
			// (set) Token: 0x0600EE3C RID: 60988 RVA: 0x0007FA12 File Offset: 0x0007DC12
			public unsafe DLC4_BossBattleManager bossBattleManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_bossBattleManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BossBattleManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_bossBattleManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D73 RID: 19827
			// (get) Token: 0x0600EE3D RID: 60989 RVA: 0x0038B054 File Offset: 0x00389254
			// (set) Token: 0x0600EE3E RID: 60990 RVA: 0x0007FA31 File Offset: 0x0007DC31
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x17004D74 RID: 19828
			// (get) Token: 0x0600EE3F RID: 60991 RVA: 0x0038B07C File Offset: 0x0038927C
			// (set) Token: 0x0600EE40 RID: 60992 RVA: 0x0007FA4C File Offset: 0x0007DC4C
			public unsafe float eachWaveProgress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_eachWaveProgress);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_eachWaveProgress)) = value;
				}
			}

			// Token: 0x17004D75 RID: 19829
			// (get) Token: 0x0600EE41 RID: 60993 RVA: 0x0038B0A4 File Offset: 0x003892A4
			// (set) Token: 0x0600EE42 RID: 60994 RVA: 0x0007FA67 File Offset: 0x0007DC67
			public unsafe float eachBigWaveProgress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_eachBigWaveProgress);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_eachBigWaveProgress)) = value;
				}
			}

			// Token: 0x17004D76 RID: 19830
			// (get) Token: 0x0600EE43 RID: 60995 RVA: 0x0038B0CC File Offset: 0x003892CC
			// (set) Token: 0x0600EE44 RID: 60996 RVA: 0x0007FA82 File Offset: 0x0007DC82
			public unsafe float progressPerSecAdd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_progressPerSecAdd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_progressPerSecAdd)) = value;
				}
			}

			// Token: 0x17004D77 RID: 19831
			// (get) Token: 0x0600EE45 RID: 60997 RVA: 0x0038B0F4 File Offset: 0x003892F4
			// (set) Token: 0x0600EE46 RID: 60998 RVA: 0x0007FA9D File Offset: 0x0007DC9D
			public unsafe float currentProgress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_currentProgress);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_currentProgress)) = value;
				}
			}

			// Token: 0x17004D78 RID: 19832
			// (get) Token: 0x0600EE47 RID: 60999 RVA: 0x0038B11C File Offset: 0x0038931C
			// (set) Token: 0x0600EE48 RID: 61000 RVA: 0x0007FAB8 File Offset: 0x0007DCB8
			public unsafe float thisWaveStartProgress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_thisWaveStartProgress);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_thisWaveStartProgress)) = value;
				}
			}

			// Token: 0x17004D79 RID: 19833
			// (get) Token: 0x0600EE49 RID: 61001 RVA: 0x0038B144 File Offset: 0x00389344
			// (set) Token: 0x0600EE4A RID: 61002 RVA: 0x0007FAD3 File Offset: 0x0007DCD3
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D7A RID: 19834
			// (get) Token: 0x0600EE4B RID: 61003 RVA: 0x0038B174 File Offset: 0x00389374
			// (set) Token: 0x0600EE4C RID: 61004 RVA: 0x0007FAF2 File Offset: 0x0007DCF2
			public unsafe IncomeControllerFlandre statusDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_statusDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerFlandre>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_statusDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D7B RID: 19835
			// (get) Token: 0x0600EE4D RID: 61005 RVA: 0x0038B1A4 File Offset: 0x003893A4
			// (set) Token: 0x0600EE4E RID: 61006 RVA: 0x0007FB11 File Offset: 0x0007DD11
			public unsafe bool checkFinalWave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_checkFinalWave);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_checkFinalWave)) = value;
				}
			}

			// Token: 0x17004D7C RID: 19836
			// (get) Token: 0x0600EE4F RID: 61007 RVA: 0x0038B1CC File Offset: 0x003893CC
			// (set) Token: 0x0600EE50 RID: 61008 RVA: 0x0007FB2C File Offset: 0x0007DD2C
			public unsafe DLC4_MystiaVSFlandreBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_MystiaVSFlandreBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D7D RID: 19837
			// (get) Token: 0x0600EE51 RID: 61009 RVA: 0x0038B1FC File Offset: 0x003893FC
			// (set) Token: 0x0600EE52 RID: 61010 RVA: 0x0007FB4B File Offset: 0x0007DD4B
			public unsafe SpecialGuest flandreData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_flandreData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_flandreData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D7E RID: 19838
			// (get) Token: 0x0600EE53 RID: 61011 RVA: 0x0038B22C File Offset: 0x0038942C
			// (set) Token: 0x0600EE54 RID: 61012 RVA: 0x0007FB6A File Offset: 0x0007DD6A
			public unsafe int eachBigWavePassion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_eachBigWavePassion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_eachBigWavePassion)) = value;
				}
			}

			// Token: 0x17004D7F RID: 19839
			// (get) Token: 0x0600EE55 RID: 61013 RVA: 0x0038B254 File Offset: 0x00389454
			// (set) Token: 0x0600EE56 RID: 61014 RVA: 0x0007FB85 File Offset: 0x0007DD85
			public unsafe bool shouldTimeFlow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_shouldTimeFlow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_shouldTimeFlow)) = value;
				}
			}

			// Token: 0x17004D80 RID: 19840
			// (get) Token: 0x0600EE57 RID: 61015 RVA: 0x0038B27C File Offset: 0x0038947C
			// (set) Token: 0x0600EE58 RID: 61016 RVA: 0x0007FBA0 File Offset: 0x0007DDA0
			public unsafe bool isFailed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_isFailed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_isFailed)) = value;
				}
			}

			// Token: 0x17004D81 RID: 19841
			// (get) Token: 0x0600EE59 RID: 61017 RVA: 0x0038B2A4 File Offset: 0x003894A4
			// (set) Token: 0x0600EE5A RID: 61018 RVA: 0x0007FBBB File Offset: 0x0007DDBB
			public unsafe Stack<int> giveBadge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_giveBadge);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.NativeFieldInfoPtr_giveBadge), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097BE RID: 38846
			private static readonly IntPtr NativeFieldInfoPtr_pachiSpellTexts;

			// Token: 0x040097BF RID: 38847
			private static readonly IntPtr NativeFieldInfoPtr_hasLoaded;

			// Token: 0x040097C0 RID: 38848
			private static readonly IntPtr NativeFieldInfoPtr_izakayaConfigure;

			// Token: 0x040097C1 RID: 38849
			private static readonly IntPtr NativeFieldInfoPtr_bossBattleManager;

			// Token: 0x040097C2 RID: 38850
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x040097C3 RID: 38851
			private static readonly IntPtr NativeFieldInfoPtr_eachWaveProgress;

			// Token: 0x040097C4 RID: 38852
			private static readonly IntPtr NativeFieldInfoPtr_eachBigWaveProgress;

			// Token: 0x040097C5 RID: 38853
			private static readonly IntPtr NativeFieldInfoPtr_progressPerSecAdd;

			// Token: 0x040097C6 RID: 38854
			private static readonly IntPtr NativeFieldInfoPtr_currentProgress;

			// Token: 0x040097C7 RID: 38855
			private static readonly IntPtr NativeFieldInfoPtr_thisWaveStartProgress;

			// Token: 0x040097C8 RID: 38856
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x040097C9 RID: 38857
			private static readonly IntPtr NativeFieldInfoPtr_statusDisplayer;

			// Token: 0x040097CA RID: 38858
			private static readonly IntPtr NativeFieldInfoPtr_checkFinalWave;

			// Token: 0x040097CB RID: 38859
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097CC RID: 38860
			private static readonly IntPtr NativeFieldInfoPtr_flandreData;

			// Token: 0x040097CD RID: 38861
			private static readonly IntPtr NativeFieldInfoPtr_eachBigWavePassion;

			// Token: 0x040097CE RID: 38862
			private static readonly IntPtr NativeFieldInfoPtr_shouldTimeFlow;

			// Token: 0x040097CF RID: 38863
			private static readonly IntPtr NativeFieldInfoPtr_isFailed;

			// Token: 0x040097D0 RID: 38864
			private static readonly IntPtr NativeFieldInfoPtr_giveBadge;

			// Token: 0x040097D1 RID: 38865
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097D2 RID: 38866
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_LanguageBase_PatchouliMagicSpellCardIndex_PDM_0;

			// Token: 0x040097D3 RID: 38867
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__3_Internal_Boolean_0;

			// Token: 0x040097D4 RID: 38868
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__4_Internal_Boolean_0;

			// Token: 0x040097D5 RID: 38869
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__7_Internal_Void_Int32_0;

			// Token: 0x040097D6 RID: 38870
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__8_Internal_Void_Int32_0;

			// Token: 0x040097D7 RID: 38871
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Void_ValueTuple_2_Int32_Int32_0;

			// Token: 0x040097D8 RID: 38872
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_String_PDM_0;

			// Token: 0x040097D9 RID: 38873
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Boolean_0;

			// Token: 0x040097DA RID: 38874
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_Single_PDM_0;

			// Token: 0x040097DB RID: 38875
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;

			// Token: 0x040097DC RID: 38876
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040097DD RID: 38877
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0;

			// Token: 0x040097DE RID: 38878
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040097DF RID: 38879
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x040097E0 RID: 38880
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x040097E1 RID: 38881
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_PDM_0;

			// Token: 0x040097E2 RID: 38882
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__20_Internal_Boolean_0;

			// Token: 0x040097E3 RID: 38883
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__21_Internal_Void_1;

			// Token: 0x040097E4 RID: 38884
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;

			// Token: 0x02001080 RID: 4224
			[ObfuscatedName("GameData.Profile.DLC4_MystiaVSFlandreBossData+<>c__DisplayClass38_0+<<MainChallengeLoop>g__OnBigWaveStart|14>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0 : Il2CppSystem.Object
			{
				// Token: 0x06011FDD RID: 73693 RVA: 0x0041C4E4 File Offset: 0x0041A6E4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0()
				{
					Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "<<MainChallengeLoop>g__OnBigWaveStart|14>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr);
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>1__state");
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>2__current");
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>4__this");
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681968);
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681969);
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681970);
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681971);
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681972);
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681973);
				}

				// Token: 0x06011FDE RID: 73694 RVA: 0x0041C5C4 File Offset: 0x0041A7C4
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011FDF RID: 73695 RVA: 0x0041C60C File Offset: 0x0041A80C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011FE0 RID: 73696 RVA: 0x0041C640 File Offset: 0x0041A840
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225981, XrefRangeEnd = 225987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DDD RID: 24029
				// (get) Token: 0x06011FE1 RID: 73697 RVA: 0x0041C67C File Offset: 0x0041A87C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011FE2 RID: 73698 RVA: 0x0041C6BC File Offset: 0x0041A8BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225987, XrefRangeEnd = 225993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DDE RID: 24030
				// (get) Token: 0x06011FE3 RID: 73699 RVA: 0x0041C6F0 File Offset: 0x0041A8F0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011FE4 RID: 73700 RVA: 0x0009C4ED File Offset: 0x0009A6ED
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DDA RID: 24026
				// (get) Token: 0x06011FE5 RID: 73701 RVA: 0x0041C730 File Offset: 0x0041A930
				// (set) Token: 0x06011FE6 RID: 73702 RVA: 0x0009C4F6 File Offset: 0x0009A6F6
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DDB RID: 24027
				// (get) Token: 0x06011FE7 RID: 73703 RVA: 0x0041C758 File Offset: 0x0041A958
				// (set) Token: 0x06011FE8 RID: 73704 RVA: 0x0009C511 File Offset: 0x0009A711
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DDC RID: 24028
				// (get) Token: 0x06011FE9 RID: 73705 RVA: 0x0041C788 File Offset: 0x0041A988
				// (set) Token: 0x06011FEA RID: 73706 RVA: 0x0009C530 File Offset: 0x0009A730
				public unsafe DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B655 RID: 46677
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B656 RID: 46678
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B657 RID: 46679
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B658 RID: 46680
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B659 RID: 46681
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B65A RID: 46682
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B65B RID: 46683
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B65C RID: 46684
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B65D RID: 46685
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001081 RID: 4225
			[ObfuscatedName("GameData.Profile.DLC4_MystiaVSFlandreBossData+<>c__DisplayClass38_0+<<MainChallengeLoop>g__Timing|18>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1 : Il2CppSystem.Object
			{
				// Token: 0x06011FEB RID: 73707 RVA: 0x0041C7B8 File Offset: 0x0041A9B8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1()
				{
					Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>.NativeClassPtr, "<<MainChallengeLoop>g__Timing|18>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr);
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>1__state");
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>2__current");
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>4__this");
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681974);
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681975);
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681976);
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681977);
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681978);
					DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681979);
				}

				// Token: 0x06011FEC RID: 73708 RVA: 0x0041C898 File Offset: 0x0041AA98
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011FED RID: 73709 RVA: 0x0041C8E0 File Offset: 0x0041AAE0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011FEE RID: 73710 RVA: 0x0041C914 File Offset: 0x0041AB14
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225993, XrefRangeEnd = 226004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DE2 RID: 24034
				// (get) Token: 0x06011FEF RID: 73711 RVA: 0x0041C950 File Offset: 0x0041AB50
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011FF0 RID: 73712 RVA: 0x0041C990 File Offset: 0x0041AB90
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226004, XrefRangeEnd = 226010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DE3 RID: 24035
				// (get) Token: 0x06011FF1 RID: 73713 RVA: 0x0041C9C4 File Offset: 0x0041ABC4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011FF2 RID: 73714 RVA: 0x0009C54F File Offset: 0x0009A74F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DDF RID: 24031
				// (get) Token: 0x06011FF3 RID: 73715 RVA: 0x0041CA04 File Offset: 0x0041AC04
				// (set) Token: 0x06011FF4 RID: 73716 RVA: 0x0009C558 File Offset: 0x0009A758
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DE0 RID: 24032
				// (get) Token: 0x06011FF5 RID: 73717 RVA: 0x0041CA2C File Offset: 0x0041AC2C
				// (set) Token: 0x06011FF6 RID: 73718 RVA: 0x0009C573 File Offset: 0x0009A773
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DE1 RID: 24033
				// (get) Token: 0x06011FF7 RID: 73719 RVA: 0x0041CA5C File Offset: 0x0041AC5C
				// (set) Token: 0x06011FF8 RID: 73720 RVA: 0x0009C592 File Offset: 0x0009A792
				public unsafe DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B65E RID: 46686
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B65F RID: 46687
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B660 RID: 46688
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B661 RID: 46689
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B662 RID: 46690
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B663 RID: 46691
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B664 RID: 46692
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B665 RID: 46693
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B666 RID: 46694
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000CF6 RID: 3318
		[ObfuscatedName("GameData.Profile.DLC4_MystiaVSFlandreBossData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EE5B RID: 61019 RVA: 0x0038B2D4 File Offset: 0x003894D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr);
				DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr, "<>9");
				DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr, "<>9__38_0");
				DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr, "<>9__38_1");
				DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr, "<>9__38_5");
				DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr, "<>9__38_6");
				DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr, "<>9__38_23");
				DLC4_MystiaVSFlandreBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr, 100681981);
				DLC4_MystiaVSFlandreBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__38_0_Internal_KeyValuePair_2_Int32_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr, 100681982);
				DLC4_MystiaVSFlandreBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__38_1_Internal_KeyValuePair_2_String_LanguageBase_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr, 100681983);
				DLC4_MystiaVSFlandreBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__38_5_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr, 100681984);
				DLC4_MystiaVSFlandreBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__38_6_Internal_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr, 100681985);
				DLC4_MystiaVSFlandreBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__38_23_Internal_String_KeyValuePair_2_Int32_DLC4_GuardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr, 100681986);
			}

			// Token: 0x0600EE5C RID: 61020 RVA: 0x0038B3F0 File Offset: 0x003895F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE5D RID: 61021 RVA: 0x0038B42C File Offset: 0x0038962C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226168, XrefRangeEnd = 226181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<int, Il2CppStringArray> _MainChallengeLoop_b__38_0(Il2CppStringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__38_0_Internal_KeyValuePair_2_Int32_Il2CppStringArray_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<int, Il2CppStringArray>(pointer);
			}

			// Token: 0x0600EE5E RID: 61022 RVA: 0x0038B474 File Offset: 0x00389674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226181, XrefRangeEnd = 226188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<string, LanguageBase> _MainChallengeLoop_b__38_1(Il2CppStringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__38_1_Internal_KeyValuePair_2_String_LanguageBase_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<string, LanguageBase>(pointer);
			}

			// Token: 0x0600EE5F RID: 61023 RVA: 0x0038B4BC File Offset: 0x003896BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226188, XrefRangeEnd = 226193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__38_5(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__38_5_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EE60 RID: 61024 RVA: 0x0038B50C File Offset: 0x0038970C
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__38_6(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__38_6_Internal_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EE61 RID: 61025 RVA: 0x0038B55C File Offset: 0x0038975C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226193, XrefRangeEnd = 226202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__38_23(KeyValuePair<int, DLC4_GuardController> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__38_23_Internal_String_KeyValuePair_2_Int32_DLC4_GuardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EE62 RID: 61026 RVA: 0x0007FBDA File Offset: 0x0007DDDA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D82 RID: 19842
			// (get) Token: 0x0600EE63 RID: 61027 RVA: 0x0038B5AC File Offset: 0x003897AC
			// (set) Token: 0x0600EE64 RID: 61028 RVA: 0x0007FBE3 File Offset: 0x0007DDE3
			public unsafe static DLC4_MystiaVSFlandreBossData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_MystiaVSFlandreBossData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D83 RID: 19843
			// (get) Token: 0x0600EE65 RID: 61029 RVA: 0x0038B5D4 File Offset: 0x003897D4
			// (set) Token: 0x0600EE66 RID: 61030 RVA: 0x0007FBF5 File Offset: 0x0007DDF5
			public unsafe static Func<Il2CppStringArray, KeyValuePair<int, Il2CppStringArray>> __9__38_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStringArray, KeyValuePair<int, Il2CppStringArray>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D84 RID: 19844
			// (get) Token: 0x0600EE67 RID: 61031 RVA: 0x0038B5FC File Offset: 0x003897FC
			// (set) Token: 0x0600EE68 RID: 61032 RVA: 0x0007FC07 File Offset: 0x0007DE07
			public unsafe static Func<Il2CppStringArray, KeyValuePair<string, LanguageBase>> __9__38_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStringArray, KeyValuePair<string, LanguageBase>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D85 RID: 19845
			// (get) Token: 0x0600EE69 RID: 61033 RVA: 0x0038B624 File Offset: 0x00389824
			// (set) Token: 0x0600EE6A RID: 61034 RVA: 0x0007FC19 File Offset: 0x0007DE19
			public unsafe static Func<Recipe, bool> __9__38_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D86 RID: 19846
			// (get) Token: 0x0600EE6B RID: 61035 RVA: 0x0038B64C File Offset: 0x0038984C
			// (set) Token: 0x0600EE6C RID: 61036 RVA: 0x0007FC2B File Offset: 0x0007DE2B
			public unsafe static Func<Recipe, int> __9__38_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D87 RID: 19847
			// (get) Token: 0x0600EE6D RID: 61037 RVA: 0x0038B674 File Offset: 0x00389874
			// (set) Token: 0x0600EE6E RID: 61038 RVA: 0x0007FC3D File Offset: 0x0007DE3D
			public unsafe static Func<KeyValuePair<int, DLC4_GuardController>, string> __9__38_23
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_23, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, DLC4_GuardController>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_MystiaVSFlandreBossData.__c.NativeFieldInfoPtr___9__38_23, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097E5 RID: 38885
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040097E6 RID: 38886
			private static readonly IntPtr NativeFieldInfoPtr___9__38_0;

			// Token: 0x040097E7 RID: 38887
			private static readonly IntPtr NativeFieldInfoPtr___9__38_1;

			// Token: 0x040097E8 RID: 38888
			private static readonly IntPtr NativeFieldInfoPtr___9__38_5;

			// Token: 0x040097E9 RID: 38889
			private static readonly IntPtr NativeFieldInfoPtr___9__38_6;

			// Token: 0x040097EA RID: 38890
			private static readonly IntPtr NativeFieldInfoPtr___9__38_23;

			// Token: 0x040097EB RID: 38891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097EC RID: 38892
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__38_0_Internal_KeyValuePair_2_Int32_Il2CppStringArray_Il2CppStringArray_0;

			// Token: 0x040097ED RID: 38893
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__38_1_Internal_KeyValuePair_2_String_LanguageBase_Il2CppStringArray_0;

			// Token: 0x040097EE RID: 38894
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__38_5_Internal_Boolean_Recipe_0;

			// Token: 0x040097EF RID: 38895
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__38_6_Internal_Int32_Recipe_0;

			// Token: 0x040097F0 RID: 38896
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__38_23_Internal_String_KeyValuePair_2_Int32_DLC4_GuardController_0;
		}

		// Token: 0x02000CF7 RID: 3319
		[ObfuscatedName("GameData.Profile.DLC4_MystiaVSFlandreBossData+<MainChallengeLoop>d__38")]
		public sealed class _MainChallengeLoop_d__38 : Il2CppSystem.Object
		{
			// Token: 0x0600EE6F RID: 61039 RVA: 0x0038B69C File Offset: 0x0038989C
			// Note: this type is marked as 'beforefieldinit'.
			static _MainChallengeLoop_d__38()
			{
				Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData>.NativeClassPtr, "<MainChallengeLoop>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr);
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<>1__state");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<>2__current");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<>4__this");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "bossDataContext");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<>8__1");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__uiManager_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<uiManager>5__2");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__guestsManager_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<guestsManager>5__3");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__cookSystemManagerInstance_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<cookSystemManagerInstance>5__4");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__partnerManager_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<partnerManager>5__5");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__tileManager_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<tileManager>5__6");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__sceneManager_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<sceneManager>5__7");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__qteManager_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<qteManager>5__8");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__data_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<data>5__9");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__flandreDic_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<flandreDic>5__10");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__enabledLetterId_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<enabledLetterId>5__11");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__canContinueYieldInstruction_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<canContinueYieldInstruction>5__12");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__mainLoop_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<mainLoop>5__13");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__timing_5__14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, "<timing>5__14");
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, 100681987);
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, 100681988);
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, 100681989);
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, 100681990);
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, 100681991);
				DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr, 100681992);
			}

			// Token: 0x0600EE70 RID: 61040 RVA: 0x0038B8A8 File Offset: 0x00389AA8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MainChallengeLoop_d__38(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE71 RID: 61041 RVA: 0x0038B8F0 File Offset: 0x00389AF0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE72 RID: 61042 RVA: 0x0038B924 File Offset: 0x00389B24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226202, XrefRangeEnd = 226619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004D9A RID: 19866
			// (get) Token: 0x0600EE73 RID: 61043 RVA: 0x0038B960 File Offset: 0x00389B60
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE74 RID: 61044 RVA: 0x0038B9A0 File Offset: 0x00389BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226619, XrefRangeEnd = 226625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004D9B RID: 19867
			// (get) Token: 0x0600EE75 RID: 61045 RVA: 0x0038B9D4 File Offset: 0x00389BD4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE76 RID: 61046 RVA: 0x0007FC4F File Offset: 0x0007DE4F
			public _MainChallengeLoop_d__38(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004D88 RID: 19848
			// (get) Token: 0x0600EE77 RID: 61047 RVA: 0x0038BA14 File Offset: 0x00389C14
			// (set) Token: 0x0600EE78 RID: 61048 RVA: 0x0007FC58 File Offset: 0x0007DE58
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004D89 RID: 19849
			// (get) Token: 0x0600EE79 RID: 61049 RVA: 0x0038BA3C File Offset: 0x00389C3C
			// (set) Token: 0x0600EE7A RID: 61050 RVA: 0x0007FC73 File Offset: 0x0007DE73
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D8A RID: 19850
			// (get) Token: 0x0600EE7B RID: 61051 RVA: 0x0038BA6C File Offset: 0x00389C6C
			// (set) Token: 0x0600EE7C RID: 61052 RVA: 0x0007FC92 File Offset: 0x0007DE92
			public unsafe DLC4_MystiaVSFlandreBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_MystiaVSFlandreBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D8B RID: 19851
			// (get) Token: 0x0600EE7D RID: 61053 RVA: 0x0038BA9C File Offset: 0x00389C9C
			// (set) Token: 0x0600EE7E RID: 61054 RVA: 0x0007FCB1 File Offset: 0x0007DEB1
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004D8C RID: 19852
			// (get) Token: 0x0600EE7F RID: 61055 RVA: 0x0038BACC File Offset: 0x00389CCC
			// (set) Token: 0x0600EE80 RID: 61056 RVA: 0x0007FCDF File Offset: 0x0007DEDF
			public unsafe DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_MystiaVSFlandreBossData.__c__DisplayClass38_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D8D RID: 19853
			// (get) Token: 0x0600EE81 RID: 61057 RVA: 0x0038BAFC File Offset: 0x00389CFC
			// (set) Token: 0x0600EE82 RID: 61058 RVA: 0x0007FCFE File Offset: 0x0007DEFE
			public unsafe UIManager _uiManager_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__uiManager_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__uiManager_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D8E RID: 19854
			// (get) Token: 0x0600EE83 RID: 61059 RVA: 0x0038BB2C File Offset: 0x00389D2C
			// (set) Token: 0x0600EE84 RID: 61060 RVA: 0x0007FD1D File Offset: 0x0007DF1D
			public unsafe GuestsManager _guestsManager_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__guestsManager_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__guestsManager_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D8F RID: 19855
			// (get) Token: 0x0600EE85 RID: 61061 RVA: 0x0038BB5C File Offset: 0x00389D5C
			// (set) Token: 0x0600EE86 RID: 61062 RVA: 0x0007FD3C File Offset: 0x0007DF3C
			public unsafe CookSystemManager _cookSystemManagerInstance_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__cookSystemManagerInstance_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookSystemManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__cookSystemManagerInstance_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D90 RID: 19856
			// (get) Token: 0x0600EE87 RID: 61063 RVA: 0x0038BB8C File Offset: 0x00389D8C
			// (set) Token: 0x0600EE88 RID: 61064 RVA: 0x0007FD5B File Offset: 0x0007DF5B
			public unsafe PartnerManager _partnerManager_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__partnerManager_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__partnerManager_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D91 RID: 19857
			// (get) Token: 0x0600EE89 RID: 61065 RVA: 0x0038BBBC File Offset: 0x00389DBC
			// (set) Token: 0x0600EE8A RID: 61066 RVA: 0x0007FD7A File Offset: 0x0007DF7A
			public unsafe TileManager _tileManager_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__tileManager_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__tileManager_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D92 RID: 19858
			// (get) Token: 0x0600EE8B RID: 61067 RVA: 0x0038BBEC File Offset: 0x00389DEC
			// (set) Token: 0x0600EE8C RID: 61068 RVA: 0x0007FD99 File Offset: 0x0007DF99
			public unsafe SceneManager _sceneManager_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__sceneManager_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__sceneManager_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D93 RID: 19859
			// (get) Token: 0x0600EE8D RID: 61069 RVA: 0x0038BC1C File Offset: 0x00389E1C
			// (set) Token: 0x0600EE8E RID: 61070 RVA: 0x0007FDB8 File Offset: 0x0007DFB8
			public unsafe QTERewardManager _qteManager_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__qteManager_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QTERewardManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__qteManager_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D94 RID: 19860
			// (get) Token: 0x0600EE8F RID: 61071 RVA: 0x0038BC4C File Offset: 0x00389E4C
			// (set) Token: 0x0600EE90 RID: 61072 RVA: 0x0007FDD7 File Offset: 0x0007DFD7
			public unsafe Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.BigWaveProperty> _data_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__data_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC4_MystiaVSFlandreBossData.BigWaveProperty>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__data_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D95 RID: 19861
			// (get) Token: 0x0600EE91 RID: 61073 RVA: 0x0038BC7C File Offset: 0x00389E7C
			// (set) Token: 0x0600EE92 RID: 61074 RVA: 0x0007FDF6 File Offset: 0x0007DFF6
			public unsafe Dictionary<FlandreTypeIndex, DLC4_FlandreEnemyCharacterController> _flandreDic_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__flandreDic_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FlandreTypeIndex, DLC4_FlandreEnemyCharacterController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__flandreDic_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D96 RID: 19862
			// (get) Token: 0x0600EE93 RID: 61075 RVA: 0x0038BCAC File Offset: 0x00389EAC
			// (set) Token: 0x0600EE94 RID: 61076 RVA: 0x0007FE15 File Offset: 0x0007E015
			public unsafe List<int> _enabledLetterId_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__enabledLetterId_5__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__enabledLetterId_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D97 RID: 19863
			// (get) Token: 0x0600EE95 RID: 61077 RVA: 0x0038BCDC File Offset: 0x00389EDC
			// (set) Token: 0x0600EE96 RID: 61078 RVA: 0x0007FE34 File Offset: 0x0007E034
			public unsafe WaitUntil _canContinueYieldInstruction_5__12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__canContinueYieldInstruction_5__12);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitUntil>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__canContinueYieldInstruction_5__12), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D98 RID: 19864
			// (get) Token: 0x0600EE97 RID: 61079 RVA: 0x0038BD0C File Offset: 0x00389F0C
			// (set) Token: 0x0600EE98 RID: 61080 RVA: 0x0007FE53 File Offset: 0x0007E053
			public unsafe Coroutine _mainLoop_5__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__mainLoop_5__13);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__mainLoop_5__13), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004D99 RID: 19865
			// (get) Token: 0x0600EE99 RID: 61081 RVA: 0x0038BD3C File Offset: 0x00389F3C
			// (set) Token: 0x0600EE9A RID: 61082 RVA: 0x0007FE72 File Offset: 0x0007E072
			public unsafe Coroutine _timing_5__14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__timing_5__14);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_MystiaVSFlandreBossData._MainChallengeLoop_d__38.NativeFieldInfoPtr__timing_5__14), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097F1 RID: 38897
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040097F2 RID: 38898
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040097F3 RID: 38899
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097F4 RID: 38900
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x040097F5 RID: 38901
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040097F6 RID: 38902
			private static readonly IntPtr NativeFieldInfoPtr__uiManager_5__2;

			// Token: 0x040097F7 RID: 38903
			private static readonly IntPtr NativeFieldInfoPtr__guestsManager_5__3;

			// Token: 0x040097F8 RID: 38904
			private static readonly IntPtr NativeFieldInfoPtr__cookSystemManagerInstance_5__4;

			// Token: 0x040097F9 RID: 38905
			private static readonly IntPtr NativeFieldInfoPtr__partnerManager_5__5;

			// Token: 0x040097FA RID: 38906
			private static readonly IntPtr NativeFieldInfoPtr__tileManager_5__6;

			// Token: 0x040097FB RID: 38907
			private static readonly IntPtr NativeFieldInfoPtr__sceneManager_5__7;

			// Token: 0x040097FC RID: 38908
			private static readonly IntPtr NativeFieldInfoPtr__qteManager_5__8;

			// Token: 0x040097FD RID: 38909
			private static readonly IntPtr NativeFieldInfoPtr__data_5__9;

			// Token: 0x040097FE RID: 38910
			private static readonly IntPtr NativeFieldInfoPtr__flandreDic_5__10;

			// Token: 0x040097FF RID: 38911
			private static readonly IntPtr NativeFieldInfoPtr__enabledLetterId_5__11;

			// Token: 0x04009800 RID: 38912
			private static readonly IntPtr NativeFieldInfoPtr__canContinueYieldInstruction_5__12;

			// Token: 0x04009801 RID: 38913
			private static readonly IntPtr NativeFieldInfoPtr__mainLoop_5__13;

			// Token: 0x04009802 RID: 38914
			private static readonly IntPtr NativeFieldInfoPtr__timing_5__14;

			// Token: 0x04009803 RID: 38915
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009804 RID: 38916
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009805 RID: 38917
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009806 RID: 38918
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009807 RID: 38919
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009808 RID: 38920
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
