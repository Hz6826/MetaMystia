using System;
using System.Runtime.InteropServices;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace GameData.RunTime.Common.AchievementSystem
{
	// Token: 0x02000232 RID: 562
	public static class DataBaseAchievement : Object
	{
		// Token: 0x06004646 RID: 17990 RVA: 0x00191478 File Offset: 0x0018F678
		// Note: this type is marked as 'beforefieldinit'.
		static DataBaseAchievement()
		{
			Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.Common.AchievementSystem", "DataBaseAchievement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr);
			DataBaseAchievement.NativeFieldInfoPtr_achievementsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, "achievementsId");
			DataBaseAchievement.NativeFieldInfoPtr_achievementCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, "achievementCollection");
			DataBaseAchievement.NativeFieldInfoPtr_stringBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, "stringBuffer");
			DataBaseAchievement.NativeFieldInfoPtr_intBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, "intBuffer");
			DataBaseAchievement.NativeFieldInfoPtr_intListBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, "intListBuffer");
			DataBaseAchievement.NativeFieldInfoPtr_stringListBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, "stringListBuffer");
			DataBaseAchievement.NativeMethodInfoPtr_OnEnterGame_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677207);
			DataBaseAchievement.NativeMethodInfoPtr_OnAllCollectionPointsAreCollected_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677208);
			DataBaseAchievement.NativeMethodInfoPtr_OnCollectionPointInteraction_Public_Static_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677209);
			DataBaseAchievement.NativeMethodInfoPtr_OnFinishEvent_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677210);
			DataBaseAchievement.NativeMethodInfoPtr_OnFinishEventStart_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677211);
			DataBaseAchievement.NativeMethodInfoPtr_OnGetAnyRecipe_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677212);
			DataBaseAchievement.NativeMethodInfoPtr_OnSell10GreenTeas_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677213);
			DataBaseAchievement.NativeMethodInfoPtr_OnOnlySell30RiceballsAndAllSatisfied_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677214);
			DataBaseAchievement.NativeMethodInfoPtr_OnUnsatisfiedTagFood_Public_Static_Void_Int32_Int32_Action_1_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677215);
			DataBaseAchievement.NativeMethodInfoPtr_OnEvictGuests_Public_Static_Void_Int32_Action_1_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677216);
			DataBaseAchievement.NativeMethodInfoPtr_OnPreMadeFoodCompletelySold_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677217);
			DataBaseAchievement.NativeMethodInfoPtr_OnCooking_Public_Static_Void_Int32_Int32_Action_1_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677218);
			DataBaseAchievement.NativeMethodInfoPtr_OnWithIngredientsAndHighestRating_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677219);
			DataBaseAchievement.NativeMethodInfoPtr_OnWithIngredientsAndHighestRatingAndTriggerRewardSpell_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677220);
			DataBaseAchievement.NativeMethodInfoPtr_OnTriggerRewardSpell_Public_Static_Void_Int32_Action_1_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677221);
			DataBaseAchievement.NativeMethodInfoPtr_OnTriggerPunishmentSpell_Public_Static_Void_Int32_Action_1_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677222);
			DataBaseAchievement.NativeMethodInfoPtr_OnTriggerRewardSpell_Public_Static_Void_String_Action_1_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677223);
			DataBaseAchievement.NativeMethodInfoPtr_OnTriggerPunishmentSpell_Public_Static_Void_String_Action_1_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677224);
			DataBaseAchievement.NativeMethodInfoPtr_OnNightQueuing_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677225);
			DataBaseAchievement.NativeMethodInfoPtr_OnReceiveTip_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677226);
			DataBaseAchievement.NativeMethodInfoPtr_OnTipSettlement_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677227);
			DataBaseAchievement.NativeMethodInfoPtr_OnProfitSettlement_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677228);
			DataBaseAchievement.NativeMethodInfoPtr_OnAnyKizunaLevelUpgrade_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677229);
			DataBaseAchievement.NativeMethodInfoPtr_OnGetItem_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677230);
			DataBaseAchievement.NativeMethodInfoPtr_OnGetIngredientsFromResourcePt_Public_Static_Void_Int32_Int32_Int32_Action_1_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677231);
			DataBaseAchievement.NativeMethodInfoPtr_OnFinishSideMission_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677232);
			DataBaseAchievement.NativeMethodInfoPtr_OnKaguyaWin_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677233);
			DataBaseAchievement.NativeMethodInfoPtr_OnMokouWin_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677234);
			DataBaseAchievement.NativeMethodInfoPtr_OnConcertEnd_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677235);
			DataBaseAchievement.NativeMethodInfoPtr_OnConcertGetAllKizuna_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677236);
			DataBaseAchievement.NativeMethodInfoPtr_OnStrongBuyAndSell_Public_Static_Void_Int32_Action_1_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677237);
			DataBaseAchievement.NativeMethodInfoPtr_OnSellCharacter_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677238);
			DataBaseAchievement.NativeMethodInfoPtr_OnFinishEvents_Public_Static_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677239);
			DataBaseAchievement.NativeMethodInfoPtr_Initialize_Public_Static_Void_Il2CppReferenceArray_1_AchievementData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677240);
			DataBaseAchievement.NativeMethodInfoPtr_CheckAllAchievement_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677241);
			DataBaseAchievement.NativeMethodInfoPtr_NotifyAchievement_Private_Static_AchievementNotifyResult_AchievementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677242);
			DataBaseAchievement.NativeMethodInfoPtr_HasAchievementFinished_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677243);
			DataBaseAchievement.NativeMethodInfoPtr_FinishAndCheckAchievement_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677244);
			DataBaseAchievement.NativeMethodInfoPtr_FinishAchievement_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677245);
			DataBaseAchievement.NativeMethodInfoPtr_SetAchievementValue_Private_Static_Int32_String_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677246);
			DataBaseAchievement.NativeMethodInfoPtr_SetAchievementValue_IncrementByOne_Private_Static_Int32_String_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677247);
			DataBaseAchievement.NativeMethodInfoPtr_GetAchievementValueFromSteamDatabase_Private_Static_Boolean_String_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677248);
			DataBaseAchievement.NativeMethodInfoPtr_TestLog_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, 100677249);
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x0019187C File Offset: 0x0018FA7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185078, RefRangeEnd = 185079, XrefRangeStart = 185074, XrefRangeEnd = 185078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnEnterGame()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnEnterGame_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x001918A4 File Offset: 0x0018FAA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185086, RefRangeEnd = 185087, XrefRangeStart = 185079, XrefRangeEnd = 185086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnAllCollectionPointsAreCollected(string stringData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(stringData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnAllCollectionPointsAreCollected_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x001918DC File Offset: 0x0018FADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185106, RefRangeEnd = 185108, XrefRangeStart = 185087, XrefRangeEnd = 185106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnCollectionPointInteraction(Il2CppStringArray stringData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stringData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnCollectionPointInteraction_Public_Static_Void_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x00191914 File Offset: 0x0018FB14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185115, RefRangeEnd = 185119, XrefRangeStart = 185108, XrefRangeEnd = 185115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnFinishEvent(string stringData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(stringData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnFinishEvent_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x0019194C File Offset: 0x0018FB4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185126, RefRangeEnd = 185129, XrefRangeStart = 185119, XrefRangeEnd = 185126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnFinishEventStart(string stringData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(stringData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnFinishEventStart_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x00191984 File Offset: 0x0018FB84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185134, RefRangeEnd = 185135, XrefRangeStart = 185129, XrefRangeEnd = 185134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnGetAnyRecipe()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnGetAnyRecipe_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x001919AC File Offset: 0x0018FBAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185139, RefRangeEnd = 185140, XrefRangeStart = 185135, XrefRangeEnd = 185139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnSell10GreenTeas()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnSell10GreenTeas_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x001919D4 File Offset: 0x0018FBD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185144, RefRangeEnd = 185145, XrefRangeStart = 185140, XrefRangeEnd = 185144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnOnlySell30RiceballsAndAllSatisfied()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnOnlySell30RiceballsAndAllSatisfied_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x001919FC File Offset: 0x0018FBFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185176, RefRangeEnd = 185177, XrefRangeStart = 185145, XrefRangeEnd = 185176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnUnsatisfiedTagFood(int tagId, int count, Action<AchievementNotifyResult> resultCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tagId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnUnsatisfiedTagFood_Public_Static_Void_Int32_Int32_Action_1_AchievementNotifyResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x00191A50 File Offset: 0x0018FC50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185191, RefRangeEnd = 185193, XrefRangeStart = 185177, XrefRangeEnd = 185191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnEvictGuests(int count, Action<AchievementNotifyResult> resultCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnEvictGuests_Public_Static_Void_Int32_Action_1_AchievementNotifyResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x00191A94 File Offset: 0x0018FC94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185197, RefRangeEnd = 185198, XrefRangeStart = 185193, XrefRangeEnd = 185197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnPreMadeFoodCompletelySold()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnPreMadeFoodCompletelySold_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x00191ABC File Offset: 0x0018FCBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185229, RefRangeEnd = 185231, XrefRangeStart = 185198, XrefRangeEnd = 185229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnCooking(int foodId, int count, Action<AchievementNotifyResult> resultCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref foodId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnCooking_Public_Static_Void_Int32_Int32_Action_1_AchievementNotifyResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x00191B10 File Offset: 0x0018FD10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185235, RefRangeEnd = 185237, XrefRangeStart = 185231, XrefRangeEnd = 185235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnWithIngredientsAndHighestRating()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnWithIngredientsAndHighestRating_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x00191B38 File Offset: 0x0018FD38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185241, RefRangeEnd = 185242, XrefRangeStart = 185237, XrefRangeEnd = 185241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnWithIngredientsAndHighestRatingAndTriggerRewardSpell()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnWithIngredientsAndHighestRatingAndTriggerRewardSpell_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x00191B60 File Offset: 0x0018FD60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185256, RefRangeEnd = 185259, XrefRangeStart = 185242, XrefRangeEnd = 185256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnTriggerRewardSpell(int count, Action<AchievementNotifyResult> resultCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnTriggerRewardSpell_Public_Static_Void_Int32_Action_1_AchievementNotifyResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x00191BA4 File Offset: 0x0018FDA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185273, RefRangeEnd = 185276, XrefRangeStart = 185259, XrefRangeEnd = 185273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnTriggerPunishmentSpell(int count, Action<AchievementNotifyResult> resultCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnTriggerPunishmentSpell_Public_Static_Void_Int32_Action_1_AchievementNotifyResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x00191BE8 File Offset: 0x0018FDE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185315, RefRangeEnd = 185318, XrefRangeStart = 185276, XrefRangeEnd = 185315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnTriggerRewardSpell(string characterId, Action<AchievementNotifyResult> resultCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnTriggerRewardSpell_Public_Static_Void_String_Action_1_AchievementNotifyResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x00191C30 File Offset: 0x0018FE30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185360, RefRangeEnd = 185361, XrefRangeStart = 185318, XrefRangeEnd = 185360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnTriggerPunishmentSpell(string characterId, Action<AchievementNotifyResult> resultCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnTriggerPunishmentSpell_Public_Static_Void_String_Action_1_AchievementNotifyResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x00191C78 File Offset: 0x0018FE78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185366, RefRangeEnd = 185367, XrefRangeStart = 185361, XrefRangeEnd = 185366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnNightQueuing(int intData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnNightQueuing_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x00191CAC File Offset: 0x0018FEAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185372, RefRangeEnd = 185373, XrefRangeStart = 185367, XrefRangeEnd = 185372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnReceiveTip(int intData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnReceiveTip_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x00191CE0 File Offset: 0x0018FEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185373, XrefRangeEnd = 185378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnTipSettlement(int intData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnTipSettlement_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x00191D14 File Offset: 0x0018FF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185378, XrefRangeEnd = 185383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnProfitSettlement(int intData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnProfitSettlement_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x00191D48 File Offset: 0x0018FF48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185414, RefRangeEnd = 185417, XrefRangeStart = 185383, XrefRangeEnd = 185414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnAnyKizunaLevelUpgrade(int level, int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnAnyKizunaLevelUpgrade_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x00191D88 File Offset: 0x0018FF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185417, XrefRangeEnd = 185422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnGetItem(int itemId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnGetItem_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x00191DBC File Offset: 0x0018FFBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185457, RefRangeEnd = 185459, XrefRangeStart = 185422, XrefRangeEnd = 185457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnGetIngredientsFromResourcePt(int id, int amount, int wholeAmount, Action<AchievementNotifyResult> resultCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wholeAmount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnGetIngredientsFromResourcePt_Public_Static_Void_Int32_Int32_Int32_Action_1_AchievementNotifyResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x00191E1C File Offset: 0x0019001C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185464, RefRangeEnd = 185465, XrefRangeStart = 185459, XrefRangeEnd = 185464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnFinishSideMission(int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnFinishSideMission_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x00191E50 File Offset: 0x00190050
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185469, RefRangeEnd = 185472, XrefRangeStart = 185465, XrefRangeEnd = 185469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnKaguyaWin()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnKaguyaWin_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x00191E78 File Offset: 0x00190078
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185476, RefRangeEnd = 185479, XrefRangeStart = 185472, XrefRangeEnd = 185476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnMokouWin()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnMokouWin_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x00191EA0 File Offset: 0x001900A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185483, RefRangeEnd = 185485, XrefRangeStart = 185479, XrefRangeEnd = 185483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnConcertEnd()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnConcertEnd_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x00191EC8 File Offset: 0x001900C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185489, RefRangeEnd = 185490, XrefRangeStart = 185485, XrefRangeEnd = 185489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnConcertGetAllKizuna()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnConcertGetAllKizuna_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004665 RID: 18021 RVA: 0x00191EF0 File Offset: 0x001900F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185504, RefRangeEnd = 185506, XrefRangeStart = 185490, XrefRangeEnd = 185504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnStrongBuyAndSell(int count, Action<AchievementNotifyResult> resultCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnStrongBuyAndSell_Public_Static_Void_Int32_Action_1_AchievementNotifyResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x00191F34 File Offset: 0x00190134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185510, RefRangeEnd = 185511, XrefRangeStart = 185506, XrefRangeEnd = 185510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnSellCharacter()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnSellCharacter_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00191F5C File Offset: 0x0019015C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185524, RefRangeEnd = 185525, XrefRangeStart = 185511, XrefRangeEnd = 185524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnFinishEvents(string stringData, Il2CppStringArray allFinsihedData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(stringData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allFinsihedData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_OnFinishEvents_Public_Static_Void_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x00191FA4 File Offset: 0x001901A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185641, RefRangeEnd = 185642, XrefRangeStart = 185525, XrefRangeEnd = 185641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(Il2CppReferenceArray<AchievementData> allAchievements)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(allAchievements);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_Initialize_Public_Static_Void_Il2CppReferenceArray_1_AchievementData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x00191FDC File Offset: 0x001901DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185664, RefRangeEnd = 185668, XrefRangeStart = 185642, XrefRangeEnd = 185664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckAllAchievement()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_CheckAllAchievement_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x00192004 File Offset: 0x00190204
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 185676, RefRangeEnd = 185716, XrefRangeStart = 185668, XrefRangeEnd = 185676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AchievementNotifyResult NotifyAchievement(AchievementType achievementType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref achievementType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_NotifyAchievement_Private_Static_AchievementNotifyResult_AchievementType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x00192044 File Offset: 0x00190244
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185718, RefRangeEnd = 185722, XrefRangeStart = 185716, XrefRangeEnd = 185718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasAchievementFinished(string achievementId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_HasAchievementFinished_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600466C RID: 18028 RVA: 0x00192088 File Offset: 0x00190288
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 185748, RefRangeEnd = 185757, XrefRangeStart = 185722, XrefRangeEnd = 185748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FinishAndCheckAchievement(string achievementId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_FinishAndCheckAchievement_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x001920C0 File Offset: 0x001902C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185761, RefRangeEnd = 185764, XrefRangeStart = 185757, XrefRangeEnd = 185761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FinishAchievement(string achievementId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_FinishAchievement_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x001920F8 File Offset: 0x001902F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185772, RefRangeEnd = 185776, XrefRangeStart = 185764, XrefRangeEnd = 185772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SetAchievementValue(string achievementId, string streamVariable, int value, int min, int max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(streamVariable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_SetAchievementValue_Private_Static_Int32_String_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x00192178 File Offset: 0x00190378
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185784, RefRangeEnd = 185787, XrefRangeStart = 185776, XrefRangeEnd = 185784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SetAchievementValue_IncrementByOne(string achievementId, string streamVariable, int value, int min, int max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(streamVariable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_SetAchievementValue_IncrementByOne_Private_Static_Int32_String_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x001921F8 File Offset: 0x001903F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185791, RefRangeEnd = 185793, XrefRangeStart = 185787, XrefRangeEnd = 185791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAchievementValueFromSteamDatabase(string achievementId, string streamVariable, out int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(streamVariable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_GetAchievementValueFromSteamDatabase_Private_Static_Boolean_String_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x0019225C File Offset: 0x0019045C
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestLog(string title, [Optional] Il2CppReferenceArray<Object> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.NativeMethodInfoPtr_TestLog_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x000249E2 File Offset: 0x00022BE2
		public static void TestLog(string title, params Object[] values)
		{
			DataBaseAchievement.TestLog(title, new Il2CppReferenceArray<Object>(values));
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x000249F0 File Offset: 0x00022BF0
		public DataBaseAchievement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x06004674 RID: 18036 RVA: 0x001922B4 File Offset: 0x001904B4
		// (set) Token: 0x06004675 RID: 18037 RVA: 0x000249F9 File Offset: 0x00022BF9
		public unsafe static List<string> achievementsId
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseAchievement.NativeFieldInfoPtr_achievementsId, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseAchievement.NativeFieldInfoPtr_achievementsId, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x06004676 RID: 18038 RVA: 0x001922DC File Offset: 0x001904DC
		// (set) Token: 0x06004677 RID: 18039 RVA: 0x00024A0B File Offset: 0x00022C0B
		public unsafe static Dictionary<AchievementType, Func<AchievementNotifyResult>> achievementCollection
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseAchievement.NativeFieldInfoPtr_achievementCollection, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AchievementType, Func<AchievementNotifyResult>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseAchievement.NativeFieldInfoPtr_achievementCollection, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x06004678 RID: 18040 RVA: 0x00192304 File Offset: 0x00190504
		// (set) Token: 0x06004679 RID: 18041 RVA: 0x00024A1D File Offset: 0x00022C1D
		public unsafe static string stringBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseAchievement.NativeFieldInfoPtr_stringBuffer, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseAchievement.NativeFieldInfoPtr_stringBuffer, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x0600467A RID: 18042 RVA: 0x00192324 File Offset: 0x00190524
		// (set) Token: 0x0600467B RID: 18043 RVA: 0x00024A2F File Offset: 0x00022C2F
		public unsafe static int intBuffer
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DataBaseAchievement.NativeFieldInfoPtr_intBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseAchievement.NativeFieldInfoPtr_intBuffer, (void*)(&value));
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x0600467C RID: 18044 RVA: 0x00192340 File Offset: 0x00190540
		// (set) Token: 0x0600467D RID: 18045 RVA: 0x00024A3D File Offset: 0x00022C3D
		public unsafe static List<int> intListBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseAchievement.NativeFieldInfoPtr_intListBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseAchievement.NativeFieldInfoPtr_intListBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x0600467E RID: 18046 RVA: 0x00192368 File Offset: 0x00190568
		// (set) Token: 0x0600467F RID: 18047 RVA: 0x00024A4F File Offset: 0x00022C4F
		public unsafe static List<string> stringListBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataBaseAchievement.NativeFieldInfoPtr_stringListBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataBaseAchievement.NativeFieldInfoPtr_stringListBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FF7 RID: 12279
		private static readonly IntPtr NativeFieldInfoPtr_achievementsId;

		// Token: 0x04002FF8 RID: 12280
		private static readonly IntPtr NativeFieldInfoPtr_achievementCollection;

		// Token: 0x04002FF9 RID: 12281
		private static readonly IntPtr NativeFieldInfoPtr_stringBuffer;

		// Token: 0x04002FFA RID: 12282
		private static readonly IntPtr NativeFieldInfoPtr_intBuffer;

		// Token: 0x04002FFB RID: 12283
		private static readonly IntPtr NativeFieldInfoPtr_intListBuffer;

		// Token: 0x04002FFC RID: 12284
		private static readonly IntPtr NativeFieldInfoPtr_stringListBuffer;

		// Token: 0x04002FFD RID: 12285
		private static readonly IntPtr NativeMethodInfoPtr_OnEnterGame_Public_Static_Void_0;

		// Token: 0x04002FFE RID: 12286
		private static readonly IntPtr NativeMethodInfoPtr_OnAllCollectionPointsAreCollected_Public_Static_Void_String_0;

		// Token: 0x04002FFF RID: 12287
		private static readonly IntPtr NativeMethodInfoPtr_OnCollectionPointInteraction_Public_Static_Void_Il2CppStringArray_0;

		// Token: 0x04003000 RID: 12288
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishEvent_Public_Static_Void_String_0;

		// Token: 0x04003001 RID: 12289
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishEventStart_Public_Static_Void_String_0;

		// Token: 0x04003002 RID: 12290
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAnyRecipe_Public_Static_Void_0;

		// Token: 0x04003003 RID: 12291
		private static readonly IntPtr NativeMethodInfoPtr_OnSell10GreenTeas_Public_Static_Void_0;

		// Token: 0x04003004 RID: 12292
		private static readonly IntPtr NativeMethodInfoPtr_OnOnlySell30RiceballsAndAllSatisfied_Public_Static_Void_0;

		// Token: 0x04003005 RID: 12293
		private static readonly IntPtr NativeMethodInfoPtr_OnUnsatisfiedTagFood_Public_Static_Void_Int32_Int32_Action_1_AchievementNotifyResult_0;

		// Token: 0x04003006 RID: 12294
		private static readonly IntPtr NativeMethodInfoPtr_OnEvictGuests_Public_Static_Void_Int32_Action_1_AchievementNotifyResult_0;

		// Token: 0x04003007 RID: 12295
		private static readonly IntPtr NativeMethodInfoPtr_OnPreMadeFoodCompletelySold_Public_Static_Void_0;

		// Token: 0x04003008 RID: 12296
		private static readonly IntPtr NativeMethodInfoPtr_OnCooking_Public_Static_Void_Int32_Int32_Action_1_AchievementNotifyResult_0;

		// Token: 0x04003009 RID: 12297
		private static readonly IntPtr NativeMethodInfoPtr_OnWithIngredientsAndHighestRating_Public_Static_Void_0;

		// Token: 0x0400300A RID: 12298
		private static readonly IntPtr NativeMethodInfoPtr_OnWithIngredientsAndHighestRatingAndTriggerRewardSpell_Public_Static_Void_0;

		// Token: 0x0400300B RID: 12299
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerRewardSpell_Public_Static_Void_Int32_Action_1_AchievementNotifyResult_0;

		// Token: 0x0400300C RID: 12300
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerPunishmentSpell_Public_Static_Void_Int32_Action_1_AchievementNotifyResult_0;

		// Token: 0x0400300D RID: 12301
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerRewardSpell_Public_Static_Void_String_Action_1_AchievementNotifyResult_0;

		// Token: 0x0400300E RID: 12302
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerPunishmentSpell_Public_Static_Void_String_Action_1_AchievementNotifyResult_0;

		// Token: 0x0400300F RID: 12303
		private static readonly IntPtr NativeMethodInfoPtr_OnNightQueuing_Public_Static_Void_Int32_0;

		// Token: 0x04003010 RID: 12304
		private static readonly IntPtr NativeMethodInfoPtr_OnReceiveTip_Public_Static_Void_Int32_0;

		// Token: 0x04003011 RID: 12305
		private static readonly IntPtr NativeMethodInfoPtr_OnTipSettlement_Public_Static_Void_Int32_0;

		// Token: 0x04003012 RID: 12306
		private static readonly IntPtr NativeMethodInfoPtr_OnProfitSettlement_Public_Static_Void_Int32_0;

		// Token: 0x04003013 RID: 12307
		private static readonly IntPtr NativeMethodInfoPtr_OnAnyKizunaLevelUpgrade_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04003014 RID: 12308
		private static readonly IntPtr NativeMethodInfoPtr_OnGetItem_Public_Static_Void_Int32_0;

		// Token: 0x04003015 RID: 12309
		private static readonly IntPtr NativeMethodInfoPtr_OnGetIngredientsFromResourcePt_Public_Static_Void_Int32_Int32_Int32_Action_1_AchievementNotifyResult_0;

		// Token: 0x04003016 RID: 12310
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishSideMission_Public_Static_Void_Int32_0;

		// Token: 0x04003017 RID: 12311
		private static readonly IntPtr NativeMethodInfoPtr_OnKaguyaWin_Public_Static_Void_0;

		// Token: 0x04003018 RID: 12312
		private static readonly IntPtr NativeMethodInfoPtr_OnMokouWin_Public_Static_Void_0;

		// Token: 0x04003019 RID: 12313
		private static readonly IntPtr NativeMethodInfoPtr_OnConcertEnd_Public_Static_Void_0;

		// Token: 0x0400301A RID: 12314
		private static readonly IntPtr NativeMethodInfoPtr_OnConcertGetAllKizuna_Public_Static_Void_0;

		// Token: 0x0400301B RID: 12315
		private static readonly IntPtr NativeMethodInfoPtr_OnStrongBuyAndSell_Public_Static_Void_Int32_Action_1_AchievementNotifyResult_0;

		// Token: 0x0400301C RID: 12316
		private static readonly IntPtr NativeMethodInfoPtr_OnSellCharacter_Public_Static_Void_0;

		// Token: 0x0400301D RID: 12317
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishEvents_Public_Static_Void_String_Il2CppStringArray_0;

		// Token: 0x0400301E RID: 12318
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Il2CppReferenceArray_1_AchievementData_0;

		// Token: 0x0400301F RID: 12319
		private static readonly IntPtr NativeMethodInfoPtr_CheckAllAchievement_Public_Static_Void_0;

		// Token: 0x04003020 RID: 12320
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAchievement_Private_Static_AchievementNotifyResult_AchievementType_0;

		// Token: 0x04003021 RID: 12321
		private static readonly IntPtr NativeMethodInfoPtr_HasAchievementFinished_Private_Static_Boolean_String_0;

		// Token: 0x04003022 RID: 12322
		private static readonly IntPtr NativeMethodInfoPtr_FinishAndCheckAchievement_Private_Static_Void_String_0;

		// Token: 0x04003023 RID: 12323
		private static readonly IntPtr NativeMethodInfoPtr_FinishAchievement_Private_Static_Void_String_0;

		// Token: 0x04003024 RID: 12324
		private static readonly IntPtr NativeMethodInfoPtr_SetAchievementValue_Private_Static_Int32_String_String_Int32_Int32_Int32_0;

		// Token: 0x04003025 RID: 12325
		private static readonly IntPtr NativeMethodInfoPtr_SetAchievementValue_IncrementByOne_Private_Static_Int32_String_String_Int32_Int32_Int32_0;

		// Token: 0x04003026 RID: 12326
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementValueFromSteamDatabase_Private_Static_Boolean_String_String_byref_Int32_0;

		// Token: 0x04003027 RID: 12327
		private static readonly IntPtr NativeMethodInfoPtr_TestLog_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x02000A9F RID: 2719
		[ObfuscatedName("GameData.RunTime.Common.AchievementSystem.DataBaseAchievement+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Object
		{
			// Token: 0x0600CC01 RID: 52225 RVA: 0x00325868 File Offset: 0x00323A68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_0>.NativeClassPtr);
				DataBaseAchievement.__c__DisplayClass39_0.NativeFieldInfoPtr_mokouAchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_0>.NativeClassPtr, "mokouAchievementId");
				DataBaseAchievement.__c__DisplayClass39_0.NativeFieldInfoPtr_kaguyaAndMokouStoryLineAchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_0>.NativeClassPtr, "kaguyaAndMokouStoryLineAchievementId");
				DataBaseAchievement.__c__DisplayClass39_0.NativeFieldInfoPtr_kaguyaAchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_0>.NativeClassPtr, "kaguyaAchievementId");
				DataBaseAchievement.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_0>.NativeClassPtr, 100677251);
			}

			// Token: 0x0600CC02 RID: 52226 RVA: 0x003258E4 File Offset: 0x00323AE4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC03 RID: 52227 RVA: 0x0006D818 File Offset: 0x0006BA18
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004234 RID: 16948
			// (get) Token: 0x0600CC04 RID: 52228 RVA: 0x00325920 File Offset: 0x00323B20
			// (set) Token: 0x0600CC05 RID: 52229 RVA: 0x0006D821 File Offset: 0x0006BA21
			public unsafe string mokouAchievementId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_0.NativeFieldInfoPtr_mokouAchievementId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_0.NativeFieldInfoPtr_mokouAchievementId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004235 RID: 16949
			// (get) Token: 0x0600CC06 RID: 52230 RVA: 0x00325948 File Offset: 0x00323B48
			// (set) Token: 0x0600CC07 RID: 52231 RVA: 0x0006D840 File Offset: 0x0006BA40
			public unsafe string kaguyaAndMokouStoryLineAchievementId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_0.NativeFieldInfoPtr_kaguyaAndMokouStoryLineAchievementId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_0.NativeFieldInfoPtr_kaguyaAndMokouStoryLineAchievementId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004236 RID: 16950
			// (get) Token: 0x0600CC08 RID: 52232 RVA: 0x00325970 File Offset: 0x00323B70
			// (set) Token: 0x0600CC09 RID: 52233 RVA: 0x0006D85F File Offset: 0x0006BA5F
			public unsafe string kaguyaAchievementId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_0.NativeFieldInfoPtr_kaguyaAchievementId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_0.NativeFieldInfoPtr_kaguyaAchievementId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008305 RID: 33541
			private static readonly IntPtr NativeFieldInfoPtr_mokouAchievementId;

			// Token: 0x04008306 RID: 33542
			private static readonly IntPtr NativeFieldInfoPtr_kaguyaAndMokouStoryLineAchievementId;

			// Token: 0x04008307 RID: 33543
			private static readonly IntPtr NativeFieldInfoPtr_kaguyaAchievementId;

			// Token: 0x04008308 RID: 33544
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AA0 RID: 2720
		[ObfuscatedName("GameData.RunTime.Common.AchievementSystem.DataBaseAchievement+<>c__DisplayClass39_1")]
		public sealed class __c__DisplayClass39_1 : Object
		{
			// Token: 0x0600CC0A RID: 52234 RVA: 0x00325998 File Offset: 0x00323B98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_1()
			{
				Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, "<>c__DisplayClass39_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr);
				DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr_achievementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, "achievementType");
				DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr_achievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, "achievement");
				DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr_field_Public___c__DisplayClass39_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, "CS$<>8__locals1");
				DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr___9__17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, "<>9__17");
				DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr___9__19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, "<>9__19");
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677252);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr_Method_Internal_Void_Func_1_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677253);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__1_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677254);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__2_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677255);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__3_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677256);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__4_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677257);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__5_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677258);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__17_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677259);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__6_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677260);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__19_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677261);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__7_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677262);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__8_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677263);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__9_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677264);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__10_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677265);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__11_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677266);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__12_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677267);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__13_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677268);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__14_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677269);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__15_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677270);
				DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__16_Internal_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr, 100677271);
			}

			// Token: 0x0600CC0B RID: 52235 RVA: 0x00325BB8 File Offset: 0x00323DB8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseAchievement.__c__DisplayClass39_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC0C RID: 52236 RVA: 0x00325BF4 File Offset: 0x00323DF4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 184787, RefRangeEnd = 184788, XrefRangeStart = 184759, XrefRangeEnd = 184787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Func_1_AchievementNotifyResult_0(Func<AchievementNotifyResult> execusionHandle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(execusionHandle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr_Method_Internal_Void_Func_1_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC0D RID: 52237 RVA: 0x00325C38 File Offset: 0x00323E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184788, XrefRangeEnd = 184792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__1_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC0E RID: 52238 RVA: 0x00325C78 File Offset: 0x00323E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184792, XrefRangeEnd = 184800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__2_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC0F RID: 52239 RVA: 0x00325CB8 File Offset: 0x00323EB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184800, XrefRangeEnd = 184804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__3_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC10 RID: 52240 RVA: 0x00325CF8 File Offset: 0x00323EF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184804, XrefRangeEnd = 184821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__4_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC11 RID: 52241 RVA: 0x00325D38 File Offset: 0x00323F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184821, XrefRangeEnd = 184868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__5_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC12 RID: 52242 RVA: 0x00325D78 File Offset: 0x00323F78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184868, XrefRangeEnd = 184872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialize_b__17(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__17_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC13 RID: 52243 RVA: 0x00325DC4 File Offset: 0x00323FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184872, XrefRangeEnd = 184919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__6_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC14 RID: 52244 RVA: 0x00325E04 File Offset: 0x00324004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184919, XrefRangeEnd = 184921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialize_b__19(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__19_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC15 RID: 52245 RVA: 0x00325E50 File Offset: 0x00324050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184921, XrefRangeEnd = 184951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__7_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC16 RID: 52246 RVA: 0x00325E90 File Offset: 0x00324090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184951, XrefRangeEnd = 184973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__8_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC17 RID: 52247 RVA: 0x00325ED0 File Offset: 0x003240D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184973, XrefRangeEnd = 185008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__9_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC18 RID: 52248 RVA: 0x00325F10 File Offset: 0x00324110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185008, XrefRangeEnd = 185014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__10_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC19 RID: 52249 RVA: 0x00325F50 File Offset: 0x00324150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185014, XrefRangeEnd = 185019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__11_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC1A RID: 52250 RVA: 0x00325F90 File Offset: 0x00324190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185019, XrefRangeEnd = 185032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__12_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC1B RID: 52251 RVA: 0x00325FD0 File Offset: 0x003241D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185032, XrefRangeEnd = 185040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__13()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__13_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC1C RID: 52252 RVA: 0x00326010 File Offset: 0x00324210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185040, XrefRangeEnd = 185048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__14()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__14_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC1D RID: 52253 RVA: 0x00326050 File Offset: 0x00324250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185048, XrefRangeEnd = 185055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__15()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__15_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC1E RID: 52254 RVA: 0x00326090 File Offset: 0x00324290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185055, XrefRangeEnd = 185074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AchievementNotifyResult _Initialize_b__16()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c__DisplayClass39_1.NativeMethodInfoPtr__Initialize_b__16_Internal_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementNotifyResult>(intPtr3) : null;
			}

			// Token: 0x0600CC1F RID: 52255 RVA: 0x0006D87E File Offset: 0x0006BA7E
			public __c__DisplayClass39_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004237 RID: 16951
			// (get) Token: 0x0600CC20 RID: 52256 RVA: 0x003260D0 File Offset: 0x003242D0
			// (set) Token: 0x0600CC21 RID: 52257 RVA: 0x0006D887 File Offset: 0x0006BA87
			public unsafe AchievementType achievementType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr_achievementType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr_achievementType)) = value;
				}
			}

			// Token: 0x17004238 RID: 16952
			// (get) Token: 0x0600CC22 RID: 52258 RVA: 0x003260F8 File Offset: 0x003242F8
			// (set) Token: 0x0600CC23 RID: 52259 RVA: 0x0006D8A2 File Offset: 0x0006BAA2
			public AchievementData achievement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr_achievement);
					return new AchievementData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr_achievement), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AchievementData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004239 RID: 16953
			// (get) Token: 0x0600CC24 RID: 52260 RVA: 0x00326128 File Offset: 0x00324328
			// (set) Token: 0x0600CC25 RID: 52261 RVA: 0x0006D8D0 File Offset: 0x0006BAD0
			public unsafe DataBaseAchievement.__c__DisplayClass39_0 field_Public___c__DisplayClass39_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr_field_Public___c__DisplayClass39_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseAchievement.__c__DisplayClass39_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr_field_Public___c__DisplayClass39_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700423A RID: 16954
			// (get) Token: 0x0600CC26 RID: 52262 RVA: 0x00326158 File Offset: 0x00324358
			// (set) Token: 0x0600CC27 RID: 52263 RVA: 0x0006D8EF File Offset: 0x0006BAEF
			public unsafe Func<int, bool> __9__17
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr___9__17);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr___9__17), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700423B RID: 16955
			// (get) Token: 0x0600CC28 RID: 52264 RVA: 0x00326188 File Offset: 0x00324388
			// (set) Token: 0x0600CC29 RID: 52265 RVA: 0x0006D90E File Offset: 0x0006BB0E
			public unsafe Func<int, bool> __9__19
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr___9__19);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataBaseAchievement.__c__DisplayClass39_1.NativeFieldInfoPtr___9__19), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008309 RID: 33545
			private static readonly IntPtr NativeFieldInfoPtr_achievementType;

			// Token: 0x0400830A RID: 33546
			private static readonly IntPtr NativeFieldInfoPtr_achievement;

			// Token: 0x0400830B RID: 33547
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass39_0_0;

			// Token: 0x0400830C RID: 33548
			private static readonly IntPtr NativeFieldInfoPtr___9__17;

			// Token: 0x0400830D RID: 33549
			private static readonly IntPtr NativeFieldInfoPtr___9__19;

			// Token: 0x0400830E RID: 33550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400830F RID: 33551
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Func_1_AchievementNotifyResult_0;

			// Token: 0x04008310 RID: 33552
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__1_Internal_AchievementNotifyResult_0;

			// Token: 0x04008311 RID: 33553
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__2_Internal_AchievementNotifyResult_0;

			// Token: 0x04008312 RID: 33554
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__3_Internal_AchievementNotifyResult_0;

			// Token: 0x04008313 RID: 33555
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__4_Internal_AchievementNotifyResult_0;

			// Token: 0x04008314 RID: 33556
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__5_Internal_AchievementNotifyResult_0;

			// Token: 0x04008315 RID: 33557
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_Internal_Boolean_Int32_0;

			// Token: 0x04008316 RID: 33558
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__6_Internal_AchievementNotifyResult_0;

			// Token: 0x04008317 RID: 33559
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__19_Internal_Boolean_Int32_0;

			// Token: 0x04008318 RID: 33560
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__7_Internal_AchievementNotifyResult_0;

			// Token: 0x04008319 RID: 33561
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__8_Internal_AchievementNotifyResult_0;

			// Token: 0x0400831A RID: 33562
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__9_Internal_AchievementNotifyResult_0;

			// Token: 0x0400831B RID: 33563
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__10_Internal_AchievementNotifyResult_0;

			// Token: 0x0400831C RID: 33564
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__11_Internal_AchievementNotifyResult_0;

			// Token: 0x0400831D RID: 33565
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__12_Internal_AchievementNotifyResult_0;

			// Token: 0x0400831E RID: 33566
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__13_Internal_AchievementNotifyResult_0;

			// Token: 0x0400831F RID: 33567
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__14_Internal_AchievementNotifyResult_0;

			// Token: 0x04008320 RID: 33568
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__15_Internal_AchievementNotifyResult_0;

			// Token: 0x04008321 RID: 33569
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__16_Internal_AchievementNotifyResult_0;
		}

		// Token: 0x02000AA1 RID: 2721
		[ObfuscatedName("GameData.RunTime.Common.AchievementSystem.DataBaseAchievement+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CC2A RID: 52266 RVA: 0x003261B8 File Offset: 0x003243B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DataBaseAchievement.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataBaseAchievement>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataBaseAchievement.__c>.NativeClassPtr);
				DataBaseAchievement.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement.__c>.NativeClassPtr, "<>9");
				DataBaseAchievement.__c.NativeFieldInfoPtr___9__39_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement.__c>.NativeClassPtr, "<>9__39_18");
				DataBaseAchievement.__c.NativeFieldInfoPtr___9__39_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataBaseAchievement.__c>.NativeClassPtr, "<>9__39_20");
				DataBaseAchievement.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c>.NativeClassPtr, 100677273);
				DataBaseAchievement.__c.NativeMethodInfoPtr__Initialize_b__39_18_Internal_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c>.NativeClassPtr, 100677274);
				DataBaseAchievement.__c.NativeMethodInfoPtr__Initialize_b__39_20_Internal_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataBaseAchievement.__c>.NativeClassPtr, 100677275);
			}

			// Token: 0x0600CC2B RID: 52267 RVA: 0x0032625C File Offset: 0x0032445C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataBaseAchievement.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CC2C RID: 52268 RVA: 0x00326298 File Offset: 0x00324498
			[CallerCount(0)]
			public unsafe int _Initialize_b__39_18(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c.NativeMethodInfoPtr__Initialize_b__39_18_Internal_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC2D RID: 52269 RVA: 0x003262E8 File Offset: 0x003244E8
			[CallerCount(0)]
			public unsafe int _Initialize_b__39_20(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataBaseAchievement.__c.NativeMethodInfoPtr__Initialize_b__39_20_Internal_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CC2E RID: 52270 RVA: 0x0006D92D File Offset: 0x0006BB2D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700423C RID: 16956
			// (get) Token: 0x0600CC2F RID: 52271 RVA: 0x00326338 File Offset: 0x00324538
			// (set) Token: 0x0600CC30 RID: 52272 RVA: 0x0006D936 File Offset: 0x0006BB36
			public unsafe static DataBaseAchievement.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseAchievement.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataBaseAchievement.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseAchievement.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700423D RID: 16957
			// (get) Token: 0x0600CC31 RID: 52273 RVA: 0x00326360 File Offset: 0x00324560
			// (set) Token: 0x0600CC32 RID: 52274 RVA: 0x0006D948 File Offset: 0x0006BB48
			public unsafe static Func<Recipe, int> __9__39_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseAchievement.__c.NativeFieldInfoPtr___9__39_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseAchievement.__c.NativeFieldInfoPtr___9__39_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700423E RID: 16958
			// (get) Token: 0x0600CC33 RID: 52275 RVA: 0x00326388 File Offset: 0x00324588
			// (set) Token: 0x0600CC34 RID: 52276 RVA: 0x0006D95A File Offset: 0x0006BB5A
			public unsafe static Func<Recipe, int> __9__39_20
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DataBaseAchievement.__c.NativeFieldInfoPtr___9__39_20, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DataBaseAchievement.__c.NativeFieldInfoPtr___9__39_20, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008322 RID: 33570
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008323 RID: 33571
			private static readonly IntPtr NativeFieldInfoPtr___9__39_18;

			// Token: 0x04008324 RID: 33572
			private static readonly IntPtr NativeFieldInfoPtr___9__39_20;

			// Token: 0x04008325 RID: 33573
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008326 RID: 33574
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__39_18_Internal_Int32_Recipe_0;

			// Token: 0x04008327 RID: 33575
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__39_20_Internal_Int32_Recipe_0;
		}
	}
}
