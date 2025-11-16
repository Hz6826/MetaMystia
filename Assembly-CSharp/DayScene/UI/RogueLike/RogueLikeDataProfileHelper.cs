using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.Managers;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Il2CppSystem.Runtime.CompilerServices;
using NightScene;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000131 RID: 305
	public static class RogueLikeDataProfileHelper : Il2CppSystem.Object
	{
		// Token: 0x060023A8 RID: 9128 RVA: 0x00115624 File Offset: 0x00113824
		// Note: this type is marked as 'beforefieldinit'.
		static RogueLikeDataProfileHelper()
		{
			Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RogueLikeDataProfileHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRoundSetup_Public_Static_RogueLikeRoundSetup_IRogueLikeData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669622);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRoundIncomeRequirement_Public_Static_Int32_IRogueLikeData_Int32_Difficulty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669623);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetBevLevelTable_Public_Static_Dictionary_2_Int32_Int32_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669624);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetMapSetup_Public_Static_Dictionary_2_String_MapSetup_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669625);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetCookerPrices_Public_Static_Dictionary_2_CookerSeries_Int32_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669626);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRogueLikeCardTriggerCondition_Public_Static_Dictionary_2_TriggerCardCondition_TriggerCardData_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669627);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRogueLikeCardRewardPairData_Public_Static_Dictionary_2_Int32_Il2CppStructArray_1_RogueLikeCardRewardRate_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669628);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRounds_Public_Static_Int32_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669629);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRogueLikeCards_Public_Static_Dictionary_2_CardType_RogueLikeCard_IRogueLikeData_byref_Dictionary_2_Rarity_List_1_RogueLikeCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669630);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRogueLikePersistentCards_Public_Static_Dictionary_2_CardType_RogueLikeCardPersistent_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669631);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetCardDescriptionLang_Public_Static_Dictionary_2_CardType_Il2CppStringArray_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669632);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetPartnerPrice_Public_Static_Dictionary_2_Int32_Int32_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669633);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRogueLikeAchievement_Public_Static_Dictionary_2_RogueLikeAchievementType_RogueLikeAchievement_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669634);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRogueLikeAchievementByTriggerType_Public_Static_Dictionary_2_RogueLikeAchievementTriggerType_Il2CppReferenceArray_1_RogueLikeAchievement_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669635);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GiveBadge_Public_Static_Void_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669636);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetEliteChallengeData_Public_Static_Dictionary_2_EliteChallengeType_EliteChallengeBase_IRogueLikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669637);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_OpenTutorialPanel_Public_Static_Void_IRogueLikeData_Boolean_Action_PanelVisualMode_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669638);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_OpenTutorialPanelInternalAsync_Private_Static_UniTask_IRogueLikeData_Boolean_Action_PanelVisualMode_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669639);
			RogueLikeDataProfileHelper.NativeMethodInfoPtr_Method_Internal_Static_Void_Rarity_RogueLikeCard_byref___c__DisplayClass8_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, 100669640);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x001157D0 File Offset: 0x001139D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84563, RefRangeEnd = 84564, XrefRangeStart = 84544, XrefRangeEnd = 84563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DLC5_RogueLikeDataProfile.RogueLikeRoundSetup GetRoundSetup(this IRogueLikeData profile, int currentRoundNum)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentRoundNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRoundSetup_Public_Static_RogueLikeRoundSetup_IRogueLikeData_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>(intPtr3) : null;
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x00115828 File Offset: 0x00113A28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 84582, RefRangeEnd = 84586, XrefRangeStart = 84564, XrefRangeEnd = 84582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRoundIncomeRequirement(this IRogueLikeData profile, int currentRoundNum, NightSceneDirector.Difficulty difficulty)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentRoundNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref difficulty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRoundIncomeRequirement_Public_Static_Int32_IRogueLikeData_Int32_Difficulty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x0011588C File Offset: 0x00113A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84586, XrefRangeEnd = 84619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, int> GetBevLevelTable(this IRogueLikeData profile)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetBevLevelTable_Public_Static_Dictionary_2_Int32_Int32_IRogueLikeData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x001158D8 File Offset: 0x00113AD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84641, RefRangeEnd = 84643, XrefRangeStart = 84619, XrefRangeEnd = 84641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, DLC5_RogueLikeDataProfile.MapSetup> GetMapSetup(this IRogueLikeData profile)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetMapSetup_Public_Static_Dictionary_2_String_MapSetup_IRogueLikeData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, DLC5_RogueLikeDataProfile.MapSetup>>(intPtr3) : null;
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x00115924 File Offset: 0x00113B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84679, RefRangeEnd = 84680, XrefRangeStart = 84643, XrefRangeEnd = 84679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<Cooker.CookerSeries, int> GetCookerPrices(this IRogueLikeData profile)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetCookerPrices_Public_Static_Dictionary_2_CookerSeries_Int32_IRogueLikeData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<Cooker.CookerSeries, int>>(intPtr3) : null;
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x00115970 File Offset: 0x00113B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84716, RefRangeEnd = 84717, XrefRangeStart = 84680, XrefRangeEnd = 84716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TriggerCardCondition, TriggerCardData> GetRogueLikeCardTriggerCondition(this IRogueLikeData profile)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRogueLikeCardTriggerCondition_Public_Static_Dictionary_2_TriggerCardCondition_TriggerCardData_IRogueLikeData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TriggerCardCondition, TriggerCardData>>(intPtr3) : null;
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x001159BC File Offset: 0x00113BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84753, RefRangeEnd = 84754, XrefRangeStart = 84717, XrefRangeEnd = 84753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, Il2CppStructArray<RogueLikeCardRewardRate>> GetRogueLikeCardRewardPairData(this IRogueLikeData profile)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRogueLikeCardRewardPairData_Public_Static_Dictionary_2_Int32_Il2CppStructArray_1_RogueLikeCardRewardRate_IRogueLikeData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppStructArray<RogueLikeCardRewardRate>>>(intPtr3) : null;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00115A08 File Offset: 0x00113C08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 84761, RefRangeEnd = 84765, XrefRangeStart = 84754, XrefRangeEnd = 84761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRounds(this IRogueLikeData profile)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRounds_Public_Static_Int32_IRogueLikeData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00115A50 File Offset: 0x00113C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84837, RefRangeEnd = 84838, XrefRangeStart = 84765, XrefRangeEnd = 84837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<RogueLikeCardBase.CardType, RogueLikeCard> GetRogueLikeCards(this IRogueLikeData profile, out Dictionary<RogueLikeCardBase.Rarity, List<RogueLikeCard>> dictionaryByRarity)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRogueLikeCards_Public_Static_Dictionary_2_CardType_RogueLikeCard_IRogueLikeData_byref_Dictionary_2_Rarity_List_1_RogueLikeCard_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			dictionaryByRarity = ((intPtr4 == 0) ? null : new Dictionary<RogueLikeCardBase.Rarity, List<RogueLikeCard>>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Dictionary<RogueLikeCardBase.CardType, RogueLikeCard>>(intPtr5) : null;
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x00115ABC File Offset: 0x00113CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84838, XrefRangeEnd = 84871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<RogueLikeCardBase.CardType, RogueLikeCardPersistent> GetRogueLikePersistentCards(this IRogueLikeData profile)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRogueLikePersistentCards_Public_Static_Dictionary_2_CardType_RogueLikeCardPersistent_IRogueLikeData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<RogueLikeCardBase.CardType, RogueLikeCardPersistent>>(intPtr3) : null;
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x00115B08 File Offset: 0x00113D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84871, XrefRangeEnd = 84900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<RogueLikeCardBase.CardType, Il2CppStringArray> GetCardDescriptionLang(this IRogueLikeData profile)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetCardDescriptionLang_Public_Static_Dictionary_2_CardType_Il2CppStringArray_IRogueLikeData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<RogueLikeCardBase.CardType, Il2CppStringArray>>(intPtr3) : null;
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00115B54 File Offset: 0x00113D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84900, XrefRangeEnd = 84932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, int> GetPartnerPrice(this IRogueLikeData profile)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetPartnerPrice_Public_Static_Dictionary_2_Int32_Int32_IRogueLikeData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr3) : null;
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x00115BA0 File Offset: 0x00113DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84932, XrefRangeEnd = 84965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, DLC5_RogueLikeDataProfile.RogueLikeAchievement> GetRogueLikeAchievement(this IRogueLikeData profile)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRogueLikeAchievement_Public_Static_Dictionary_2_RogueLikeAchievementType_RogueLikeAchievement_IRogueLikeData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, DLC5_RogueLikeDataProfile.RogueLikeAchievement>>(intPtr3) : null;
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00115BEC File Offset: 0x00113DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85015, RefRangeEnd = 85016, XrefRangeStart = 84965, XrefRangeEnd = 85015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement>> GetRogueLikeAchievementByTriggerType(this IRogueLikeData profile)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetRogueLikeAchievementByTriggerType_Public_Static_Dictionary_2_RogueLikeAchievementTriggerType_Il2CppReferenceArray_1_RogueLikeAchievement_IRogueLikeData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement>>>(intPtr3) : null;
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00115C38 File Offset: 0x00113E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85020, RefRangeEnd = 85021, XrefRangeStart = 85016, XrefRangeEnd = 85020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GiveBadge(this DLC5_RogueLikeDataProfile.RogueLikeAchievement rogueLikeAchievement)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rogueLikeAchievement));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GiveBadge_Public_Static_Void_RogueLikeAchievement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x00115C74 File Offset: 0x00113E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85021, XrefRangeEnd = 85054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<RogueLikeRunTimeData.EliteChallengeType, RogueLikeRunTimeData.EliteChallengeBase> GetEliteChallengeData(this IRogueLikeData profile)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_GetEliteChallengeData_Public_Static_Dictionary_2_EliteChallengeType_EliteChallengeBase_IRogueLikeData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<RogueLikeRunTimeData.EliteChallengeType, RogueLikeRunTimeData.EliteChallengeBase>>(intPtr3) : null;
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x00115CC0 File Offset: 0x00113EC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 85063, RefRangeEnd = 85065, XrefRangeStart = 85054, XrefRangeEnd = 85063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenTutorialPanel(this IRogueLikeData profile, bool isFirstTutorial, Action onTutorialEndCallback, AdpUIPanelManager.PanelVisualMode lastPanelVisualMode = AdpUIPanelManager.PanelVisualMode.PreserveVisual, Action<Action> beforeOpen = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFirstTutorial;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onTutorialEndCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastPanelVisualMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beforeOpen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_OpenTutorialPanel_Public_Static_Void_IRogueLikeData_Boolean_Action_PanelVisualMode_Action_1_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x00115D3C File Offset: 0x00113F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85065, XrefRangeEnd = 85073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask OpenTutorialPanelInternalAsync(this IRogueLikeData profile, bool isFirstTutorial, Action onTutorialEndCallback, AdpUIPanelManager.PanelVisualMode lastPanelVisualMode = AdpUIPanelManager.PanelVisualMode.PreserveVisual, Action<Action> beforeOpen = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profile));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFirstTutorial;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onTutorialEndCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastPanelVisualMode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beforeOpen);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_OpenTutorialPanelInternalAsync_Private_Static_UniTask_IRogueLikeData_Boolean_Action_PanelVisualMode_Action_1_Action_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x00115DC0 File Offset: 0x00113FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85073, XrefRangeEnd = 85082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_Rarity_RogueLikeCard_byref___c__DisplayClass8_0_PDM_0(RogueLikeCardBase.Rarity rarity, RogueLikeCard card, ref RogueLikeDataProfileHelper.__c__DisplayClass8_0 A_2)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rarity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.NativeMethodInfoPtr_Method_Internal_Static_Void_Rarity_RogueLikeCard_byref___c__DisplayClass8_0_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x000155EB File Offset: 0x000137EB
		public RogueLikeDataProfileHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeMethodInfoPtr_GetRoundSetup_Public_Static_RogueLikeRoundSetup_IRogueLikeData_Int32_0;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeMethodInfoPtr_GetRoundIncomeRequirement_Public_Static_Int32_IRogueLikeData_Int32_Difficulty_0;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeMethodInfoPtr_GetBevLevelTable_Public_Static_Dictionary_2_Int32_Int32_IRogueLikeData_0;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeMethodInfoPtr_GetMapSetup_Public_Static_Dictionary_2_String_MapSetup_IRogueLikeData_0;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeMethodInfoPtr_GetCookerPrices_Public_Static_Dictionary_2_CookerSeries_Int32_IRogueLikeData_0;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeMethodInfoPtr_GetRogueLikeCardTriggerCondition_Public_Static_Dictionary_2_TriggerCardCondition_TriggerCardData_IRogueLikeData_0;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeMethodInfoPtr_GetRogueLikeCardRewardPairData_Public_Static_Dictionary_2_Int32_Il2CppStructArray_1_RogueLikeCardRewardRate_IRogueLikeData_0;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeMethodInfoPtr_GetRounds_Public_Static_Int32_IRogueLikeData_0;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeMethodInfoPtr_GetRogueLikeCards_Public_Static_Dictionary_2_CardType_RogueLikeCard_IRogueLikeData_byref_Dictionary_2_Rarity_List_1_RogueLikeCard_0;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeMethodInfoPtr_GetRogueLikePersistentCards_Public_Static_Dictionary_2_CardType_RogueLikeCardPersistent_IRogueLikeData_0;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeMethodInfoPtr_GetCardDescriptionLang_Public_Static_Dictionary_2_CardType_Il2CppStringArray_IRogueLikeData_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeMethodInfoPtr_GetPartnerPrice_Public_Static_Dictionary_2_Int32_Int32_IRogueLikeData_0;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeMethodInfoPtr_GetRogueLikeAchievement_Public_Static_Dictionary_2_RogueLikeAchievementType_RogueLikeAchievement_IRogueLikeData_0;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeMethodInfoPtr_GetRogueLikeAchievementByTriggerType_Public_Static_Dictionary_2_RogueLikeAchievementTriggerType_Il2CppReferenceArray_1_RogueLikeAchievement_IRogueLikeData_0;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeMethodInfoPtr_GiveBadge_Public_Static_Void_RogueLikeAchievement_0;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeMethodInfoPtr_GetEliteChallengeData_Public_Static_Dictionary_2_EliteChallengeType_EliteChallengeBase_IRogueLikeData_0;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeMethodInfoPtr_OpenTutorialPanel_Public_Static_Void_IRogueLikeData_Boolean_Action_PanelVisualMode_Action_1_Action_0;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeMethodInfoPtr_OpenTutorialPanelInternalAsync_Private_Static_UniTask_IRogueLikeData_Boolean_Action_PanelVisualMode_Action_1_Action_0;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Rarity_RogueLikeCard_byref___c__DisplayClass8_0_PDM_0;

		// Token: 0x02000754 RID: 1876
		[ObfuscatedName("DayScene.UI.RogueLike.RogueLikeDataProfileHelper+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009FA4 RID: 40868 RVA: 0x002A2208 File Offset: 0x002A0408
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr);
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__2_0");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__2_1");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__3_0");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__4_0");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__4_1");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__5_0");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__5_1");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__6_0");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__6_1");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__9_0");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__9_1");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__10_0");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__11_0");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__11_1");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__12_0");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__12_1");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__13_0");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__13_1");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__13_2");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__15_0");
				RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, "<>9__15_1");
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669642);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetBevLevelTable_b__2_0_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669643);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetBevLevelTable_b__2_1_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669644);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetMapSetup_b__3_0_Internal_String_MapSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669645);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetCookerPrices_b__4_0_Internal_CookerSeries_CookerPriceSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669646);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetCookerPrices_b__4_1_Internal_Int32_CookerPriceSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669647);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeCardTriggerCondition_b__5_0_Internal_TriggerCardCondition_TriggerCardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669648);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeCardTriggerCondition_b__5_1_Internal_TriggerCardData_TriggerCardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669649);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeCardRewardPairData_b__6_0_Internal_Int32_RogueLikeCardRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669650);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeCardRewardPairData_b__6_1_Internal_Il2CppStructArray_1_RogueLikeCardRewardRate_RogueLikeCardRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669651);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikePersistentCards_b__9_0_Internal_CardType_RogueLikeCardPersistent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669652);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikePersistentCards_b__9_1_Internal_RogueLikeCardPersistent_RogueLikeCardPersistent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669653);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetCardDescriptionLang_b__10_0_Internal_KeyValuePair_2_CardType_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669654);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetPartnerPrice_b__11_0_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669655);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetPartnerPrice_b__11_1_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669656);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeAchievement_b__12_0_Internal_RogueLikeAchievementType_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669657);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeAchievement_b__12_1_Internal_RogueLikeAchievement_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669658);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeAchievementByTriggerType_b__13_0_Internal_RogueLikeAchievementTriggerType_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669659);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeAchievementByTriggerType_b__13_1_Internal_RogueLikeAchievementTriggerType_IGrouping_2_RogueLikeAchievementTriggerType_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669660);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeAchievementByTriggerType_b__13_2_Internal_Il2CppReferenceArray_1_RogueLikeAchievement_IGrouping_2_RogueLikeAchievementTriggerType_RogueLikeAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669661);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetEliteChallengeData_b__15_0_Internal_EliteChallengeType_EliteChallengeBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669662);
				RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetEliteChallengeData_b__15_1_Internal_EliteChallengeBase_EliteChallengeBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr, 100669663);
			}

			// Token: 0x06009FA5 RID: 40869 RVA: 0x002A25A4 File Offset: 0x002A07A4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009FA6 RID: 40870 RVA: 0x002A25E0 File Offset: 0x002A07E0
			[CallerCount(0)]
			public unsafe int _GetBevLevelTable_b__2_0(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetBevLevelTable_b__2_0_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FA7 RID: 40871 RVA: 0x002A262C File Offset: 0x002A082C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2790, RefRangeEnd = 2793, XrefRangeStart = 2790, XrefRangeEnd = 2793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetBevLevelTable_b__2_1(Vector2Int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetBevLevelTable_b__2_1_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FA8 RID: 40872 RVA: 0x002A2678 File Offset: 0x002A0878
			[CallerCount(0)]
			public unsafe string _GetMapSetup_b__3_0(DLC5_RogueLikeDataProfile.MapSetup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetMapSetup_b__3_0_Internal_String_MapSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009FA9 RID: 40873 RVA: 0x002A26C8 File Offset: 0x002A08C8
			[CallerCount(0)]
			public unsafe Cooker.CookerSeries _GetCookerPrices_b__4_0(DLC5_RogueLikeDataProfile.CookerPriceSetup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetCookerPrices_b__4_0_Internal_CookerSeries_CookerPriceSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FAA RID: 40874 RVA: 0x002A2714 File Offset: 0x002A0914
			[CallerCount(0)]
			public unsafe int _GetCookerPrices_b__4_1(DLC5_RogueLikeDataProfile.CookerPriceSetup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetCookerPrices_b__4_1_Internal_Int32_CookerPriceSetup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FAB RID: 40875 RVA: 0x002A2760 File Offset: 0x002A0960
			[CallerCount(0)]
			public unsafe TriggerCardCondition _GetRogueLikeCardTriggerCondition_b__5_0(TriggerCardData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeCardTriggerCondition_b__5_0_Internal_TriggerCardCondition_TriggerCardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FAC RID: 40876 RVA: 0x002A27AC File Offset: 0x002A09AC
			[CallerCount(0)]
			public unsafe TriggerCardData _GetRogueLikeCardTriggerCondition_b__5_1(TriggerCardData y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeCardTriggerCondition_b__5_1_Internal_TriggerCardData_TriggerCardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FAD RID: 40877 RVA: 0x002A27F8 File Offset: 0x002A09F8
			[CallerCount(0)]
			public unsafe int _GetRogueLikeCardRewardPairData_b__6_0(RogueLikeCardRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeCardRewardPairData_b__6_0_Internal_Int32_RogueLikeCardRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FAE RID: 40878 RVA: 0x002A284C File Offset: 0x002A0A4C
			[CallerCount(0)]
			public unsafe Il2CppStructArray<RogueLikeCardRewardRate> _GetRogueLikeCardRewardPairData_b__6_1(RogueLikeCardRewardPair y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeCardRewardPairData_b__6_1_Internal_Il2CppStructArray_1_RogueLikeCardRewardRate_RogueLikeCardRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RogueLikeCardRewardRate>>(intPtr3) : null;
			}

			// Token: 0x06009FAF RID: 40879 RVA: 0x002A28A4 File Offset: 0x002A0AA4
			[CallerCount(0)]
			public unsafe RogueLikeCardBase.CardType _GetRogueLikePersistentCards_b__9_0(RogueLikeCardPersistent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikePersistentCards_b__9_0_Internal_CardType_RogueLikeCardPersistent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FB0 RID: 40880 RVA: 0x002A28F4 File Offset: 0x002A0AF4
			[CallerCount(0)]
			public unsafe RogueLikeCardPersistent _GetRogueLikePersistentCards_b__9_1(RogueLikeCardPersistent y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikePersistentCards_b__9_1_Internal_RogueLikeCardPersistent_RogueLikeCardPersistent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeCardPersistent>(intPtr3) : null;
			}

			// Token: 0x06009FB1 RID: 40881 RVA: 0x002A2944 File Offset: 0x002A0B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84411, XrefRangeEnd = 84440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<RogueLikeCardBase.CardType, Il2CppStringArray> _GetCardDescriptionLang_b__10_0(Il2CppStringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetCardDescriptionLang_b__10_0_Internal_KeyValuePair_2_CardType_Il2CppStringArray_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<RogueLikeCardBase.CardType, Il2CppStringArray>(pointer);
			}

			// Token: 0x06009FB2 RID: 40882 RVA: 0x002A298C File Offset: 0x002A0B8C
			[CallerCount(0)]
			public unsafe int _GetPartnerPrice_b__11_0(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetPartnerPrice_b__11_0_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FB3 RID: 40883 RVA: 0x002A29D8 File Offset: 0x002A0BD8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2790, RefRangeEnd = 2793, XrefRangeStart = 2790, XrefRangeEnd = 2793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetPartnerPrice_b__11_1(Vector2Int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetPartnerPrice_b__11_1_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FB4 RID: 40884 RVA: 0x002A2A24 File Offset: 0x002A0C24
			[CallerCount(0)]
			public unsafe DLC5_RogueLikeDataProfile.RogueLikeAchievementType _GetRogueLikeAchievement_b__12_0(DLC5_RogueLikeDataProfile.RogueLikeAchievement x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeAchievement_b__12_0_Internal_RogueLikeAchievementType_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FB5 RID: 40885 RVA: 0x002A2A78 File Offset: 0x002A0C78
			[CallerCount(0)]
			public unsafe DLC5_RogueLikeDataProfile.RogueLikeAchievement _GetRogueLikeAchievement_b__12_1(DLC5_RogueLikeDataProfile.RogueLikeAchievement y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeAchievement_b__12_1_Internal_RogueLikeAchievement_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC5_RogueLikeDataProfile.RogueLikeAchievement(pointer);
			}

			// Token: 0x06009FB6 RID: 40886 RVA: 0x002A2AC8 File Offset: 0x002A0CC8
			[CallerCount(0)]
			public unsafe DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType _GetRogueLikeAchievementByTriggerType_b__13_0(DLC5_RogueLikeDataProfile.RogueLikeAchievement x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeAchievementByTriggerType_b__13_0_Internal_RogueLikeAchievementTriggerType_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FB7 RID: 40887 RVA: 0x002A2B1C File Offset: 0x002A0D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84440, XrefRangeEnd = 84444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType _GetRogueLikeAchievementByTriggerType_b__13_1(IGrouping<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, DLC5_RogueLikeDataProfile.RogueLikeAchievement> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeAchievementByTriggerType_b__13_1_Internal_RogueLikeAchievementTriggerType_IGrouping_2_RogueLikeAchievementTriggerType_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FB8 RID: 40888 RVA: 0x002A2B6C File Offset: 0x002A0D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84444, XrefRangeEnd = 84447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement> _GetRogueLikeAchievementByTriggerType_b__13_2(IGrouping<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, DLC5_RogueLikeDataProfile.RogueLikeAchievement> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetRogueLikeAchievementByTriggerType_b__13_2_Internal_Il2CppReferenceArray_1_RogueLikeAchievement_IGrouping_2_RogueLikeAchievementTriggerType_RogueLikeAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement>>(intPtr3) : null;
			}

			// Token: 0x06009FB9 RID: 40889 RVA: 0x002A2BBC File Offset: 0x002A0DBC
			[CallerCount(0)]
			public unsafe RogueLikeRunTimeData.EliteChallengeType _GetEliteChallengeData_b__15_0(RogueLikeRunTimeData.EliteChallengeBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetEliteChallengeData_b__15_0_Internal_EliteChallengeType_EliteChallengeBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009FBA RID: 40890 RVA: 0x002A2C0C File Offset: 0x002A0E0C
			[CallerCount(0)]
			public unsafe RogueLikeRunTimeData.EliteChallengeBase _GetEliteChallengeData_b__15_1(RogueLikeRunTimeData.EliteChallengeBase y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c.NativeMethodInfoPtr__GetEliteChallengeData_b__15_1_Internal_EliteChallengeBase_EliteChallengeBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData.EliteChallengeBase>(intPtr3) : null;
			}

			// Token: 0x06009FBB RID: 40891 RVA: 0x00056459 File Offset: 0x00054659
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170034B7 RID: 13495
			// (get) Token: 0x06009FBC RID: 40892 RVA: 0x002A2C5C File Offset: 0x002A0E5C
			// (set) Token: 0x06009FBD RID: 40893 RVA: 0x00056462 File Offset: 0x00054662
			public unsafe static RogueLikeDataProfileHelper.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeDataProfileHelper.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034B8 RID: 13496
			// (get) Token: 0x06009FBE RID: 40894 RVA: 0x002A2C84 File Offset: 0x002A0E84
			// (set) Token: 0x06009FBF RID: 40895 RVA: 0x00056474 File Offset: 0x00054674
			public unsafe static Func<Vector2Int, int> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034B9 RID: 13497
			// (get) Token: 0x06009FC0 RID: 40896 RVA: 0x002A2CAC File Offset: 0x002A0EAC
			// (set) Token: 0x06009FC1 RID: 40897 RVA: 0x00056486 File Offset: 0x00054686
			public unsafe static Func<Vector2Int, int> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034BA RID: 13498
			// (get) Token: 0x06009FC2 RID: 40898 RVA: 0x002A2CD4 File Offset: 0x002A0ED4
			// (set) Token: 0x06009FC3 RID: 40899 RVA: 0x00056498 File Offset: 0x00054698
			public unsafe static Func<DLC5_RogueLikeDataProfile.MapSetup, string> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.MapSetup, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034BB RID: 13499
			// (get) Token: 0x06009FC4 RID: 40900 RVA: 0x002A2CFC File Offset: 0x002A0EFC
			// (set) Token: 0x06009FC5 RID: 40901 RVA: 0x000564AA File Offset: 0x000546AA
			public unsafe static Func<DLC5_RogueLikeDataProfile.CookerPriceSetup, Cooker.CookerSeries> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.CookerPriceSetup, Cooker.CookerSeries>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034BC RID: 13500
			// (get) Token: 0x06009FC6 RID: 40902 RVA: 0x002A2D24 File Offset: 0x002A0F24
			// (set) Token: 0x06009FC7 RID: 40903 RVA: 0x000564BC File Offset: 0x000546BC
			public unsafe static Func<DLC5_RogueLikeDataProfile.CookerPriceSetup, int> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.CookerPriceSetup, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034BD RID: 13501
			// (get) Token: 0x06009FC8 RID: 40904 RVA: 0x002A2D4C File Offset: 0x002A0F4C
			// (set) Token: 0x06009FC9 RID: 40905 RVA: 0x000564CE File Offset: 0x000546CE
			public unsafe static Func<TriggerCardData, TriggerCardCondition> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TriggerCardData, TriggerCardCondition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034BE RID: 13502
			// (get) Token: 0x06009FCA RID: 40906 RVA: 0x002A2D74 File Offset: 0x002A0F74
			// (set) Token: 0x06009FCB RID: 40907 RVA: 0x000564E0 File Offset: 0x000546E0
			public unsafe static Func<TriggerCardData, TriggerCardData> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TriggerCardData, TriggerCardData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034BF RID: 13503
			// (get) Token: 0x06009FCC RID: 40908 RVA: 0x002A2D9C File Offset: 0x002A0F9C
			// (set) Token: 0x06009FCD RID: 40909 RVA: 0x000564F2 File Offset: 0x000546F2
			public unsafe static Func<RogueLikeCardRewardPair, int> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardRewardPair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C0 RID: 13504
			// (get) Token: 0x06009FCE RID: 40910 RVA: 0x002A2DC4 File Offset: 0x002A0FC4
			// (set) Token: 0x06009FCF RID: 40911 RVA: 0x00056504 File Offset: 0x00054704
			public unsafe static Func<RogueLikeCardRewardPair, Il2CppStructArray<RogueLikeCardRewardRate>> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardRewardPair, Il2CppStructArray<RogueLikeCardRewardRate>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C1 RID: 13505
			// (get) Token: 0x06009FD0 RID: 40912 RVA: 0x002A2DEC File Offset: 0x002A0FEC
			// (set) Token: 0x06009FD1 RID: 40913 RVA: 0x00056516 File Offset: 0x00054716
			public unsafe static Func<RogueLikeCardPersistent, RogueLikeCardBase.CardType> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardPersistent, RogueLikeCardBase.CardType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C2 RID: 13506
			// (get) Token: 0x06009FD2 RID: 40914 RVA: 0x002A2E14 File Offset: 0x002A1014
			// (set) Token: 0x06009FD3 RID: 40915 RVA: 0x00056528 File Offset: 0x00054728
			public unsafe static Func<RogueLikeCardPersistent, RogueLikeCardPersistent> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardPersistent, RogueLikeCardPersistent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C3 RID: 13507
			// (get) Token: 0x06009FD4 RID: 40916 RVA: 0x002A2E3C File Offset: 0x002A103C
			// (set) Token: 0x06009FD5 RID: 40917 RVA: 0x0005653A File Offset: 0x0005473A
			public unsafe static Func<Il2CppStringArray, KeyValuePair<RogueLikeCardBase.CardType, Il2CppStringArray>> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStringArray, KeyValuePair<RogueLikeCardBase.CardType, Il2CppStringArray>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C4 RID: 13508
			// (get) Token: 0x06009FD6 RID: 40918 RVA: 0x002A2E64 File Offset: 0x002A1064
			// (set) Token: 0x06009FD7 RID: 40919 RVA: 0x0005654C File Offset: 0x0005474C
			public unsafe static Func<Vector2Int, int> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C5 RID: 13509
			// (get) Token: 0x06009FD8 RID: 40920 RVA: 0x002A2E8C File Offset: 0x002A108C
			// (set) Token: 0x06009FD9 RID: 40921 RVA: 0x0005655E File Offset: 0x0005475E
			public unsafe static Func<Vector2Int, int> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C6 RID: 13510
			// (get) Token: 0x06009FDA RID: 40922 RVA: 0x002A2EB4 File Offset: 0x002A10B4
			// (set) Token: 0x06009FDB RID: 40923 RVA: 0x00056570 File Offset: 0x00054770
			public unsafe static Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, DLC5_RogueLikeDataProfile.RogueLikeAchievementType> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, DLC5_RogueLikeDataProfile.RogueLikeAchievementType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C7 RID: 13511
			// (get) Token: 0x06009FDC RID: 40924 RVA: 0x002A2EDC File Offset: 0x002A10DC
			// (set) Token: 0x06009FDD RID: 40925 RVA: 0x00056582 File Offset: 0x00054782
			public unsafe static Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, DLC5_RogueLikeDataProfile.RogueLikeAchievement> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, DLC5_RogueLikeDataProfile.RogueLikeAchievement>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C8 RID: 13512
			// (get) Token: 0x06009FDE RID: 40926 RVA: 0x002A2F04 File Offset: 0x002A1104
			// (set) Token: 0x06009FDF RID: 40927 RVA: 0x00056594 File Offset: 0x00054794
			public unsafe static Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.RogueLikeAchievement, DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034C9 RID: 13513
			// (get) Token: 0x06009FE0 RID: 40928 RVA: 0x002A2F2C File Offset: 0x002A112C
			// (set) Token: 0x06009FE1 RID: 40929 RVA: 0x000565A6 File Offset: 0x000547A6
			public unsafe static Func<IGrouping<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, DLC5_RogueLikeDataProfile.RogueLikeAchievement>, DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, DLC5_RogueLikeDataProfile.RogueLikeAchievement>, DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034CA RID: 13514
			// (get) Token: 0x06009FE2 RID: 40930 RVA: 0x002A2F54 File Offset: 0x002A1154
			// (set) Token: 0x06009FE3 RID: 40931 RVA: 0x000565B8 File Offset: 0x000547B8
			public unsafe static Func<IGrouping<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, DLC5_RogueLikeDataProfile.RogueLikeAchievement>, Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement>> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType, DLC5_RogueLikeDataProfile.RogueLikeAchievement>, Il2CppReferenceArray<DLC5_RogueLikeDataProfile.RogueLikeAchievement>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034CB RID: 13515
			// (get) Token: 0x06009FE4 RID: 40932 RVA: 0x002A2F7C File Offset: 0x002A117C
			// (set) Token: 0x06009FE5 RID: 40933 RVA: 0x000565CA File Offset: 0x000547CA
			public unsafe static Func<RogueLikeRunTimeData.EliteChallengeBase, RogueLikeRunTimeData.EliteChallengeType> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeRunTimeData.EliteChallengeBase, RogueLikeRunTimeData.EliteChallengeType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034CC RID: 13516
			// (get) Token: 0x06009FE6 RID: 40934 RVA: 0x002A2FA4 File Offset: 0x002A11A4
			// (set) Token: 0x06009FE7 RID: 40935 RVA: 0x000565DC File Offset: 0x000547DC
			public unsafe static Func<RogueLikeRunTimeData.EliteChallengeBase, RogueLikeRunTimeData.EliteChallengeBase> __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeRunTimeData.EliteChallengeBase, RogueLikeRunTimeData.EliteChallengeBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RogueLikeDataProfileHelper.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006780 RID: 26496
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006781 RID: 26497
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04006782 RID: 26498
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04006783 RID: 26499
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04006784 RID: 26500
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04006785 RID: 26501
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04006786 RID: 26502
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04006787 RID: 26503
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x04006788 RID: 26504
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04006789 RID: 26505
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x0400678A RID: 26506
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400678B RID: 26507
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x0400678C RID: 26508
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400678D RID: 26509
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400678E RID: 26510
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x0400678F RID: 26511
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04006790 RID: 26512
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04006791 RID: 26513
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04006792 RID: 26514
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x04006793 RID: 26515
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x04006794 RID: 26516
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04006795 RID: 26517
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x04006796 RID: 26518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006797 RID: 26519
			private static readonly IntPtr NativeMethodInfoPtr__GetBevLevelTable_b__2_0_Internal_Int32_Vector2Int_0;

			// Token: 0x04006798 RID: 26520
			private static readonly IntPtr NativeMethodInfoPtr__GetBevLevelTable_b__2_1_Internal_Int32_Vector2Int_0;

			// Token: 0x04006799 RID: 26521
			private static readonly IntPtr NativeMethodInfoPtr__GetMapSetup_b__3_0_Internal_String_MapSetup_0;

			// Token: 0x0400679A RID: 26522
			private static readonly IntPtr NativeMethodInfoPtr__GetCookerPrices_b__4_0_Internal_CookerSeries_CookerPriceSetup_0;

			// Token: 0x0400679B RID: 26523
			private static readonly IntPtr NativeMethodInfoPtr__GetCookerPrices_b__4_1_Internal_Int32_CookerPriceSetup_0;

			// Token: 0x0400679C RID: 26524
			private static readonly IntPtr NativeMethodInfoPtr__GetRogueLikeCardTriggerCondition_b__5_0_Internal_TriggerCardCondition_TriggerCardData_0;

			// Token: 0x0400679D RID: 26525
			private static readonly IntPtr NativeMethodInfoPtr__GetRogueLikeCardTriggerCondition_b__5_1_Internal_TriggerCardData_TriggerCardData_0;

			// Token: 0x0400679E RID: 26526
			private static readonly IntPtr NativeMethodInfoPtr__GetRogueLikeCardRewardPairData_b__6_0_Internal_Int32_RogueLikeCardRewardPair_0;

			// Token: 0x0400679F RID: 26527
			private static readonly IntPtr NativeMethodInfoPtr__GetRogueLikeCardRewardPairData_b__6_1_Internal_Il2CppStructArray_1_RogueLikeCardRewardRate_RogueLikeCardRewardPair_0;

			// Token: 0x040067A0 RID: 26528
			private static readonly IntPtr NativeMethodInfoPtr__GetRogueLikePersistentCards_b__9_0_Internal_CardType_RogueLikeCardPersistent_0;

			// Token: 0x040067A1 RID: 26529
			private static readonly IntPtr NativeMethodInfoPtr__GetRogueLikePersistentCards_b__9_1_Internal_RogueLikeCardPersistent_RogueLikeCardPersistent_0;

			// Token: 0x040067A2 RID: 26530
			private static readonly IntPtr NativeMethodInfoPtr__GetCardDescriptionLang_b__10_0_Internal_KeyValuePair_2_CardType_Il2CppStringArray_Il2CppStringArray_0;

			// Token: 0x040067A3 RID: 26531
			private static readonly IntPtr NativeMethodInfoPtr__GetPartnerPrice_b__11_0_Internal_Int32_Vector2Int_0;

			// Token: 0x040067A4 RID: 26532
			private static readonly IntPtr NativeMethodInfoPtr__GetPartnerPrice_b__11_1_Internal_Int32_Vector2Int_0;

			// Token: 0x040067A5 RID: 26533
			private static readonly IntPtr NativeMethodInfoPtr__GetRogueLikeAchievement_b__12_0_Internal_RogueLikeAchievementType_RogueLikeAchievement_0;

			// Token: 0x040067A6 RID: 26534
			private static readonly IntPtr NativeMethodInfoPtr__GetRogueLikeAchievement_b__12_1_Internal_RogueLikeAchievement_RogueLikeAchievement_0;

			// Token: 0x040067A7 RID: 26535
			private static readonly IntPtr NativeMethodInfoPtr__GetRogueLikeAchievementByTriggerType_b__13_0_Internal_RogueLikeAchievementTriggerType_RogueLikeAchievement_0;

			// Token: 0x040067A8 RID: 26536
			private static readonly IntPtr NativeMethodInfoPtr__GetRogueLikeAchievementByTriggerType_b__13_1_Internal_RogueLikeAchievementTriggerType_IGrouping_2_RogueLikeAchievementTriggerType_RogueLikeAchievement_0;

			// Token: 0x040067A9 RID: 26537
			private static readonly IntPtr NativeMethodInfoPtr__GetRogueLikeAchievementByTriggerType_b__13_2_Internal_Il2CppReferenceArray_1_RogueLikeAchievement_IGrouping_2_RogueLikeAchievementTriggerType_RogueLikeAchievement_0;

			// Token: 0x040067AA RID: 26538
			private static readonly IntPtr NativeMethodInfoPtr__GetEliteChallengeData_b__15_0_Internal_EliteChallengeType_EliteChallengeBase_0;

			// Token: 0x040067AB RID: 26539
			private static readonly IntPtr NativeMethodInfoPtr__GetEliteChallengeData_b__15_1_Internal_EliteChallengeBase_EliteChallengeBase_0;
		}

		// Token: 0x02000755 RID: 1877
		[ObfuscatedName("DayScene.UI.RogueLike.RogueLikeDataProfileHelper+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : ValueType
		{
			// Token: 0x06009FE8 RID: 40936 RVA: 0x002A2FCC File Offset: 0x002A11CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass8_0>.NativeClassPtr);
				RogueLikeDataProfileHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_greenCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass8_0>.NativeClassPtr, "greenCards");
				RogueLikeDataProfileHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_blueCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass8_0>.NativeClassPtr, "blueCards");
				RogueLikeDataProfileHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_purpleCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass8_0>.NativeClassPtr, "purpleCards");
				RogueLikeDataProfileHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_goldCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass8_0>.NativeClassPtr, "goldCards");
			}

			// Token: 0x06009FE9 RID: 40937 RVA: 0x000565EE File Offset: 0x000547EE
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009FEA RID: 40938 RVA: 0x000565F7 File Offset: 0x000547F7
			public __c__DisplayClass8_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass8_0>.NativeClassPtr))
			{
			}

			// Token: 0x170034CD RID: 13517
			// (get) Token: 0x06009FEB RID: 40939 RVA: 0x002A3048 File Offset: 0x002A1248
			// (set) Token: 0x06009FEC RID: 40940 RVA: 0x00056609 File Offset: 0x00054809
			public unsafe List<RogueLikeCard> greenCards
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_greenCards);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RogueLikeCard>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_greenCards), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034CE RID: 13518
			// (get) Token: 0x06009FED RID: 40941 RVA: 0x002A3078 File Offset: 0x002A1278
			// (set) Token: 0x06009FEE RID: 40942 RVA: 0x00056628 File Offset: 0x00054828
			public unsafe List<RogueLikeCard> blueCards
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_blueCards);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RogueLikeCard>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_blueCards), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034CF RID: 13519
			// (get) Token: 0x06009FEF RID: 40943 RVA: 0x002A30A8 File Offset: 0x002A12A8
			// (set) Token: 0x06009FF0 RID: 40944 RVA: 0x00056647 File Offset: 0x00054847
			public unsafe List<RogueLikeCard> purpleCards
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_purpleCards);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RogueLikeCard>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_purpleCards), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034D0 RID: 13520
			// (get) Token: 0x06009FF1 RID: 40945 RVA: 0x002A30D8 File Offset: 0x002A12D8
			// (set) Token: 0x06009FF2 RID: 40946 RVA: 0x00056666 File Offset: 0x00054866
			public unsafe List<RogueLikeCard> goldCards
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_goldCards);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RogueLikeCard>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass8_0.NativeFieldInfoPtr_goldCards), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040067AC RID: 26540
			private static readonly IntPtr NativeFieldInfoPtr_greenCards;

			// Token: 0x040067AD RID: 26541
			private static readonly IntPtr NativeFieldInfoPtr_blueCards;

			// Token: 0x040067AE RID: 26542
			private static readonly IntPtr NativeFieldInfoPtr_purpleCards;

			// Token: 0x040067AF RID: 26543
			private static readonly IntPtr NativeFieldInfoPtr_goldCards;
		}

		// Token: 0x02000756 RID: 1878
		[ObfuscatedName("DayScene.UI.RogueLike.RogueLikeDataProfileHelper+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x06009FF3 RID: 40947 RVA: 0x002A3108 File Offset: 0x002A1308
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0>.NativeClassPtr);
				RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0>.NativeClassPtr, "profile");
				RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_tutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0>.NativeClassPtr, "tutorial");
				RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_isFirstTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0>.NativeClassPtr, "isFirstTutorial");
				RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_lastPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0>.NativeClassPtr, "lastPanelVisualMode");
				RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_onTutorialEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0>.NativeClassPtr, "onTutorialEndCallback");
				RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0>.NativeClassPtr, 100669664);
				RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeMethodInfoPtr__OpenTutorialPanelInternalAsync_b__1_Internal_UniTask_1_DLC5_RogueLikeTutorialPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0>.NativeClassPtr, 100669665);
				RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeMethodInfoPtr__OpenTutorialPanelInternalAsync_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0>.NativeClassPtr, 100669666);
			}

			// Token: 0x06009FF4 RID: 40948 RVA: 0x002A31D4 File Offset: 0x002A13D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009FF5 RID: 40949 RVA: 0x002A3210 File Offset: 0x002A1410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84465, XrefRangeEnd = 84474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask<DLC5_RogueLikeTutorialPanel> _OpenTutorialPanelInternalAsync_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeMethodInfoPtr__OpenTutorialPanelInternalAsync_b__1_Internal_UniTask_1_DLC5_RogueLikeTutorialPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask<DLC5_RogueLikeTutorialPanel>(pointer);
			}

			// Token: 0x06009FF6 RID: 40950 RVA: 0x002A3248 File Offset: 0x002A1448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84474, XrefRangeEnd = 84480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenTutorialPanelInternalAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeMethodInfoPtr__OpenTutorialPanelInternalAsync_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009FF7 RID: 40951 RVA: 0x00056685 File Offset: 0x00054885
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170034D1 RID: 13521
			// (get) Token: 0x06009FF8 RID: 40952 RVA: 0x002A327C File Offset: 0x002A147C
			// (set) Token: 0x06009FF9 RID: 40953 RVA: 0x0005668E File Offset: 0x0005488E
			public IRogueLikeData profile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_profile);
					return new IRogueLikeData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_profile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170034D2 RID: 13522
			// (get) Token: 0x06009FFA RID: 40954 RVA: 0x002A32AC File Offset: 0x002A14AC
			// (set) Token: 0x06009FFB RID: 40955 RVA: 0x000566BC File Offset: 0x000548BC
			public unsafe DLC5_RogueLikeTutorialPanel tutorial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_tutorial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeTutorialPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_tutorial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034D3 RID: 13523
			// (get) Token: 0x06009FFC RID: 40956 RVA: 0x002A32DC File Offset: 0x002A14DC
			// (set) Token: 0x06009FFD RID: 40957 RVA: 0x000566DB File Offset: 0x000548DB
			public unsafe bool isFirstTutorial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_isFirstTutorial);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_isFirstTutorial)) = value;
				}
			}

			// Token: 0x170034D4 RID: 13524
			// (get) Token: 0x06009FFE RID: 40958 RVA: 0x002A3304 File Offset: 0x002A1504
			// (set) Token: 0x06009FFF RID: 40959 RVA: 0x000566F6 File Offset: 0x000548F6
			public unsafe AdpUIPanelManager.PanelVisualMode lastPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_lastPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_lastPanelVisualMode)) = value;
				}
			}

			// Token: 0x170034D5 RID: 13525
			// (get) Token: 0x0600A000 RID: 40960 RVA: 0x002A332C File Offset: 0x002A152C
			// (set) Token: 0x0600A001 RID: 40961 RVA: 0x00056711 File Offset: 0x00054911
			public unsafe Action onTutorialEndCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_onTutorialEndCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.NativeFieldInfoPtr_onTutorialEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040067B0 RID: 26544
			private static readonly IntPtr NativeFieldInfoPtr_profile;

			// Token: 0x040067B1 RID: 26545
			private static readonly IntPtr NativeFieldInfoPtr_tutorial;

			// Token: 0x040067B2 RID: 26546
			private static readonly IntPtr NativeFieldInfoPtr_isFirstTutorial;

			// Token: 0x040067B3 RID: 26547
			private static readonly IntPtr NativeFieldInfoPtr_lastPanelVisualMode;

			// Token: 0x040067B4 RID: 26548
			private static readonly IntPtr NativeFieldInfoPtr_onTutorialEndCallback;

			// Token: 0x040067B5 RID: 26549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040067B6 RID: 26550
			private static readonly IntPtr NativeMethodInfoPtr__OpenTutorialPanelInternalAsync_b__1_Internal_UniTask_1_DLC5_RogueLikeTutorialPanel_0;

			// Token: 0x040067B7 RID: 26551
			private static readonly IntPtr NativeMethodInfoPtr__OpenTutorialPanelInternalAsync_b__0_Internal_Void_0;

			// Token: 0x02000FDA RID: 4058
			[ObfuscatedName("DayScene.UI.RogueLike.RogueLikeDataProfileHelper+<>c__DisplayClass17_0+<<OpenTutorialPanelInternalAsync>b__1>d")]
			public sealed class __OpenTutorialPanelInternalAsync_b__1_d : ValueType
			{
				// Token: 0x060116E8 RID: 71400 RVA: 0x00401604 File Offset: 0x003FF804
				// Note: this type is marked as 'beforefieldinit'.
				static __OpenTutorialPanelInternalAsync_b__1_d()
				{
					Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0>.NativeClassPtr, "<<OpenTutorialPanelInternalAsync>b__1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d>.NativeClassPtr);
					RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d>.NativeClassPtr, "<>1__state");
					RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d>.NativeClassPtr, "<>t__builder");
					RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d>.NativeClassPtr, "<>4__this");
					RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d>.NativeClassPtr, "<>u__1");
					RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d>.NativeClassPtr, 100669667);
					RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d>.NativeClassPtr, 100669668);
				}

				// Token: 0x060116E9 RID: 71401 RVA: 0x004016A8 File Offset: 0x003FF8A8
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 84460, RefRangeEnd = 84462, XrefRangeStart = 84447, XrefRangeEnd = 84460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060116EA RID: 71402 RVA: 0x004016E0 File Offset: 0x003FF8E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84462, XrefRangeEnd = 84465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060116EB RID: 71403 RVA: 0x00097AD2 File Offset: 0x00095CD2
				public __OpenTutorialPanelInternalAsync_b__1_d(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x060116EC RID: 71404 RVA: 0x00097ADB File Offset: 0x00095CDB
				public __OpenTutorialPanelInternalAsync_b__1_d() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d>.NativeClassPtr))
				{
				}

				// Token: 0x17005A9B RID: 23195
				// (get) Token: 0x060116ED RID: 71405 RVA: 0x00401728 File Offset: 0x003FF928
				// (set) Token: 0x060116EE RID: 71406 RVA: 0x00097AED File Offset: 0x00095CED
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005A9C RID: 23196
				// (get) Token: 0x060116EF RID: 71407 RVA: 0x00401750 File Offset: 0x003FF950
				// (set) Token: 0x060116F0 RID: 71408 RVA: 0x00097B08 File Offset: 0x00095D08
				public AsyncUniTaskMethodBuilder<DLC5_RogueLikeTutorialPanel> __t__builder
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeFieldInfoPtr___t__builder);
						return new AsyncUniTaskMethodBuilder<DLC5_RogueLikeTutorialPanel>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<DLC5_RogueLikeTutorialPanel>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<DLC5_RogueLikeTutorialPanel>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A9D RID: 23197
				// (get) Token: 0x060116F1 RID: 71409 RVA: 0x00401780 File Offset: 0x003FF980
				// (set) Token: 0x060116F2 RID: 71410 RVA: 0x00097B36 File Offset: 0x00095D36
				public unsafe RogueLikeDataProfileHelper.__c__DisplayClass17_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeDataProfileHelper.__c__DisplayClass17_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A9E RID: 23198
				// (get) Token: 0x060116F3 RID: 71411 RVA: 0x004017B0 File Offset: 0x003FF9B0
				// (set) Token: 0x060116F4 RID: 71412 RVA: 0x00097B55 File Offset: 0x00095D55
				public UniTask<DLC5_RogueLikeTutorialPanel>.Awaiter __u__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeFieldInfoPtr___u__1);
						return new UniTask<DLC5_RogueLikeTutorialPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeTutorialPanel>.Awaiter>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper.__c__DisplayClass17_0.__OpenTutorialPanelInternalAsync_b__1_d.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeTutorialPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x0400B01F RID: 45087
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B020 RID: 45088
				private static readonly IntPtr NativeFieldInfoPtr___t__builder;

				// Token: 0x0400B021 RID: 45089
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B022 RID: 45090
				private static readonly IntPtr NativeFieldInfoPtr___u__1;

				// Token: 0x0400B023 RID: 45091
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B024 RID: 45092
				private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
			}
		}

		// Token: 0x02000757 RID: 1879
		[ObfuscatedName("DayScene.UI.RogueLike.RogueLikeDataProfileHelper+<OpenTutorialPanelInternalAsync>d__17")]
		public sealed class _OpenTutorialPanelInternalAsync_d__17 : ValueType
		{
			// Token: 0x0600A002 RID: 40962 RVA: 0x002A335C File Offset: 0x002A155C
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenTutorialPanelInternalAsync_d__17()
			{
				Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RogueLikeDataProfileHelper>.NativeClassPtr, "<OpenTutorialPanelInternalAsync>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr);
				RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr, "<>1__state");
				RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr, "<>t__builder");
				RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr, "profile");
				RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_isFirstTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr, "isFirstTutorial");
				RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_lastPanelVisualMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr, "lastPanelVisualMode");
				RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_onTutorialEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr, "onTutorialEndCallback");
				RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr, "<>8__1");
				RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_beforeOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr, "beforeOpen");
				RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr, "<>u__1");
				RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr, 100669669);
				RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr, 100669670);
			}

			// Token: 0x0600A003 RID: 40963 RVA: 0x002A3464 File Offset: 0x002A1664
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 84541, RefRangeEnd = 84544, XrefRangeStart = 84480, XrefRangeEnd = 84541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A004 RID: 40964 RVA: 0x002A349C File Offset: 0x002A169C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A005 RID: 40965 RVA: 0x00056730 File Offset: 0x00054930
			public _OpenTutorialPanelInternalAsync_d__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A006 RID: 40966 RVA: 0x00056739 File Offset: 0x00054939
			public _OpenTutorialPanelInternalAsync_d__17() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17>.NativeClassPtr))
			{
			}

			// Token: 0x170034D6 RID: 13526
			// (get) Token: 0x0600A007 RID: 40967 RVA: 0x002A34E4 File Offset: 0x002A16E4
			// (set) Token: 0x0600A008 RID: 40968 RVA: 0x0005674B File Offset: 0x0005494B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170034D7 RID: 13527
			// (get) Token: 0x0600A009 RID: 40969 RVA: 0x002A350C File Offset: 0x002A170C
			// (set) Token: 0x0600A00A RID: 40970 RVA: 0x00056766 File Offset: 0x00054966
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170034D8 RID: 13528
			// (get) Token: 0x0600A00B RID: 40971 RVA: 0x002A353C File Offset: 0x002A173C
			// (set) Token: 0x0600A00C RID: 40972 RVA: 0x00056794 File Offset: 0x00054994
			public IRogueLikeData profile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_profile);
					return new IRogueLikeData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_profile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<IRogueLikeData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170034D9 RID: 13529
			// (get) Token: 0x0600A00D RID: 40973 RVA: 0x002A356C File Offset: 0x002A176C
			// (set) Token: 0x0600A00E RID: 40974 RVA: 0x000567C2 File Offset: 0x000549C2
			public unsafe bool isFirstTutorial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_isFirstTutorial);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_isFirstTutorial)) = value;
				}
			}

			// Token: 0x170034DA RID: 13530
			// (get) Token: 0x0600A00F RID: 40975 RVA: 0x002A3594 File Offset: 0x002A1794
			// (set) Token: 0x0600A010 RID: 40976 RVA: 0x000567DD File Offset: 0x000549DD
			public unsafe AdpUIPanelManager.PanelVisualMode lastPanelVisualMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_lastPanelVisualMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_lastPanelVisualMode)) = value;
				}
			}

			// Token: 0x170034DB RID: 13531
			// (get) Token: 0x0600A011 RID: 40977 RVA: 0x002A35BC File Offset: 0x002A17BC
			// (set) Token: 0x0600A012 RID: 40978 RVA: 0x000567F8 File Offset: 0x000549F8
			public unsafe Action onTutorialEndCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_onTutorialEndCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_onTutorialEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034DC RID: 13532
			// (get) Token: 0x0600A013 RID: 40979 RVA: 0x002A35EC File Offset: 0x002A17EC
			// (set) Token: 0x0600A014 RID: 40980 RVA: 0x00056817 File Offset: 0x00054A17
			public unsafe RogueLikeDataProfileHelper.__c__DisplayClass17_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeDataProfileHelper.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034DD RID: 13533
			// (get) Token: 0x0600A015 RID: 40981 RVA: 0x002A361C File Offset: 0x002A181C
			// (set) Token: 0x0600A016 RID: 40982 RVA: 0x00056836 File Offset: 0x00054A36
			public unsafe Action<Action> beforeOpen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_beforeOpen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr_beforeOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170034DE RID: 13534
			// (get) Token: 0x0600A017 RID: 40983 RVA: 0x002A364C File Offset: 0x002A184C
			// (set) Token: 0x0600A018 RID: 40984 RVA: 0x00056855 File Offset: 0x00054A55
			public UniTask<DLC5_RogueLikeTutorialPanel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr___u__1);
					return new UniTask<DLC5_RogueLikeTutorialPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeTutorialPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeDataProfileHelper._OpenTutorialPanelInternalAsync_d__17.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DLC5_RogueLikeTutorialPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040067B8 RID: 26552
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040067B9 RID: 26553
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040067BA RID: 26554
			private static readonly IntPtr NativeFieldInfoPtr_profile;

			// Token: 0x040067BB RID: 26555
			private static readonly IntPtr NativeFieldInfoPtr_isFirstTutorial;

			// Token: 0x040067BC RID: 26556
			private static readonly IntPtr NativeFieldInfoPtr_lastPanelVisualMode;

			// Token: 0x040067BD RID: 26557
			private static readonly IntPtr NativeFieldInfoPtr_onTutorialEndCallback;

			// Token: 0x040067BE RID: 26558
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040067BF RID: 26559
			private static readonly IntPtr NativeFieldInfoPtr_beforeOpen;

			// Token: 0x040067C0 RID: 26560
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040067C1 RID: 26561
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040067C2 RID: 26562
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
