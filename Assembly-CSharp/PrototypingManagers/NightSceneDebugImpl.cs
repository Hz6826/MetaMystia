using System;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;

namespace PrototypingManagers
{
	// Token: 0x0200004E RID: 78
	public static class NightSceneDebugImpl : Object
	{
		// Token: 0x06000971 RID: 2417 RVA: 0x000BBA44 File Offset: 0x000B9C44
		// Note: this type is marked as 'beforefieldinit'.
		static NightSceneDebugImpl()
		{
			Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrototypingManagers", "NightSceneDebugImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr);
			NightSceneDebugImpl.NativeFieldInfoPtr_GIVE_AMOUNT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, "GIVE_AMOUNT_MIN");
			NightSceneDebugImpl.NativeFieldInfoPtr_GIVE_AMOUNT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, "GIVE_AMOUNT_MAX");
			NightSceneDebugImpl.NativeMethodInfoPtr_RegisterMethod_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664823);
			NightSceneDebugImpl.NativeMethodInfoPtr_UnRegisterMethod_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664824);
			NightSceneDebugImpl.NativeMethodInfoPtr_SetWorkIncome_Public_Static_Void_Int32_MathOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664825);
			NightSceneDebugImpl.NativeMethodInfoPtr_SetWorkCombo_Public_Static_Void_Int32_MathOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664826);
			NightSceneDebugImpl.NativeMethodInfoPtr_ModifyWorkTime_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664827);
			NightSceneDebugImpl.NativeMethodInfoPtr_SupplementaryBeverages_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664828);
			NightSceneDebugImpl.NativeMethodInfoPtr_SupplementaryIngredients_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664829);
			NightSceneDebugImpl.NativeMethodInfoPtr_SupplementaryFoods_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664830);
			NightSceneDebugImpl.NativeMethodInfoPtr_TriggerRandomQTEBuff_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664831);
			NightSceneDebugImpl.NativeMethodInfoPtr_TriggerThrowServingQTEBuff_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664832);
			NightSceneDebugImpl.NativeMethodInfoPtr_TriggerPatientQTEBuff_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664833);
			NightSceneDebugImpl.NativeMethodInfoPtr_TriggerFinishEatingImmediatelyQTEBuff_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664834);
			NightSceneDebugImpl.NativeMethodInfoPtr_SetPassionLevelOverrideActive_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664835);
			NightSceneDebugImpl.NativeMethodInfoPtr_IncreasePassionLevel_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664836);
			NightSceneDebugImpl.NativeMethodInfoPtr_DecreasePassionLevel_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664837);
			NightSceneDebugImpl.NativeMethodInfoPtr_ClearSpecialGuestAlbum_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664838);
			NightSceneDebugImpl.NativeMethodInfoPtr_SpawnNormalGuest_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664839);
			NightSceneDebugImpl.NativeMethodInfoPtr_SpawnSpecialGuest_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664840);
			NightSceneDebugImpl.NativeMethodInfoPtr_SpawnNormalGuest_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664841);
			NightSceneDebugImpl.NativeMethodInfoPtr_SpawnSpecialGuest_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664842);
			NightSceneDebugImpl.NativeMethodInfoPtr_RepellGuestAndPay_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664843);
			NightSceneDebugImpl.NativeMethodInfoPtr_RepellGuestAndPay_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664844);
			NightSceneDebugImpl.NativeMethodInfoPtr_RepellGuestAndPayByMoodValue_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664845);
			NightSceneDebugImpl.NativeMethodInfoPtr_TriggerPositiveBuff_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664846);
			NightSceneDebugImpl.NativeMethodInfoPtr_TriggerNegativeBuff_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664847);
			NightSceneDebugImpl.NativeMethodInfoPtr_PatientDeplete_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664848);
			NightSceneDebugImpl.NativeMethodInfoPtr_RemoveAllRegisteredTimedBuff_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664849);
			NightSceneDebugImpl.NativeMethodInfoPtr_RegisteredCheatedBuff_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664850);
			NightSceneDebugImpl.NativeMethodInfoPtr_RegisteredEternityFever_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664851);
			NightSceneDebugImpl.NativeMethodInfoPtr_GetSpecialGuestsController_Private_Static_SpecialGuestsController_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664852);
			NightSceneDebugImpl.NativeMethodInfoPtr_GetAllNormalGuestsMapping_Private_Static_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664853);
			NightSceneDebugImpl.NativeMethodInfoPtr_GetAllSpecialGuestsMapping_Private_Static_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664854);
			NightSceneDebugImpl.NativeMethodInfoPtr_GetAllFoodsMapping_Private_Static_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664855);
			NightSceneDebugImpl.NativeMethodInfoPtr_AddWorkTip_Private_Static_Void_Int32_ServeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664856);
			NightSceneDebugImpl.NativeMethodInfoPtr_SetPassionValue_Private_Static_Void_Single_MathOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664857);
			NightSceneDebugImpl.NativeMethodInfoPtr_SetComboValue_Private_Static_Void_Single_MathOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664858);
			NightSceneDebugImpl.NativeMethodInfoPtr_ResetCombo_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664859);
			NightSceneDebugImpl.NativeMethodInfoPtr_SetWorkExp_Private_Static_Void_Single_MathOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664860);
			NightSceneDebugImpl.NativeMethodInfoPtr_AddPassionPerTime_Private_Static_Void_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664861);
			NightSceneDebugImpl.NativeMethodInfoPtr_SetFreeCook_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664862);
			NightSceneDebugImpl.NativeMethodInfoPtr_LockDailyRecipes_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664863);
			NightSceneDebugImpl.NativeMethodInfoPtr_CookTimeAndOrderRateEditByTag_Private_Static_Void_Int32_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664864);
			NightSceneDebugImpl.NativeMethodInfoPtr_CookTimeAndOrderRateEditByCookerType_Private_Static_Void_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664865);
			NightSceneDebugImpl.NativeMethodInfoPtr_ForcedOverrideFoodProbably_Private_Static_Void_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664866);
			NightSceneDebugImpl.NativeMethodInfoPtr_SetFreeCookRate_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664867);
			NightSceneDebugImpl.NativeMethodInfoPtr_UnlockInfo_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664868);
			NightSceneDebugImpl.NativeMethodInfoPtr_Stun_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664869);
			NightSceneDebugImpl.NativeMethodInfoPtr_ChangeMoveSpeedByBuff_Private_Static_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664870);
			NightSceneDebugImpl.NativeMethodInfoPtr_SetPartnerExtraWage_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664871);
			NightSceneDebugImpl.NativeMethodInfoPtr_RemovePartnerExtraWage_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664872);
			NightSceneDebugImpl.NativeMethodInfoPtr_SetGuestNotLeaveWhenIzakayaClose_Private_Static_Void_Int32_BuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664873);
			NightSceneDebugImpl.NativeMethodInfoPtr_GuestMoodExtraAddEdit_Private_Static_Void_Int32_Int32_BuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664874);
			NightSceneDebugImpl.NativeMethodInfoPtr_OrderCycleRateEdit_Private_Static_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664875);
			NightSceneDebugImpl.NativeMethodInfoPtr_EatTimeEdit_Private_Static_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664876);
			NightSceneDebugImpl.NativeMethodInfoPtr_GuestPatientEdit_Youmu_Private_Static_Void_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664877);
			NightSceneDebugImpl.NativeMethodInfoPtr_SpawnRateEdit_Private_Static_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664878);
			NightSceneDebugImpl.NativeMethodInfoPtr_WriggleSpawnRateEdit_Private_Static_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664879);
			NightSceneDebugImpl.NativeMethodInfoPtr_ChenSpawnRateEdit_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664880);
			NightSceneDebugImpl.NativeMethodInfoPtr_MomiziSpawnRateEdit_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664881);
			NightSceneDebugImpl.NativeMethodInfoPtr_GuestInstantEvaluate_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664882);
			NightSceneDebugImpl.NativeMethodInfoPtr_GuestInstantEvaluate_Yuyuko_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664883);
			NightSceneDebugImpl.NativeMethodInfoPtr_GuestPatientFreeze_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664884);
			NightSceneDebugImpl.NativeMethodInfoPtr_ThrowDeliver_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664885);
			NightSceneDebugImpl.NativeMethodInfoPtr_PartnerThrowDeliver_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664886);
			NightSceneDebugImpl.NativeMethodInfoPtr_Fever_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664887);
			NightSceneDebugImpl.NativeMethodInfoPtr_SpawnNormalGuests_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664888);
			NightSceneDebugImpl.NativeMethodInfoPtr_SpawnTargetNormalGuests_Private_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664889);
			NightSceneDebugImpl.NativeMethodInfoPtr_MakeGuestsPayTipsNormal_Private_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664890);
			NightSceneDebugImpl.NativeMethodInfoPtr_MakeGuestsPayTipsKasen_Private_Static_Void_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664891);
			NightSceneDebugImpl.NativeMethodInfoPtr_UnambitiousGuests_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664892);
			NightSceneDebugImpl.NativeMethodInfoPtr_ExtraFee_Private_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664893);
			NightSceneDebugImpl.NativeMethodInfoPtr_ExtraFeeForever_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664894);
			NightSceneDebugImpl.NativeMethodInfoPtr_MinEvalLevelSet_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664895);
			NightSceneDebugImpl.NativeMethodInfoPtr_MaxEvalLevelSet_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664896);
			NightSceneDebugImpl.NativeMethodInfoPtr_MaxEvalLevelSet_Yuyuko_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664897);
			NightSceneDebugImpl.NativeMethodInfoPtr_RandomEval_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664898);
			NightSceneDebugImpl.NativeMethodInfoPtr_SetBestEvalRate_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, 100664899);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000BC0A0 File Offset: 0x000BA2A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38596, RefRangeEnd = 38597, XrefRangeStart = 38586, XrefRangeEnd = 38596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_RegisterMethod_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000BC0C8 File Offset: 0x000BA2C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38607, RefRangeEnd = 38608, XrefRangeStart = 38597, XrefRangeEnd = 38607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_UnRegisterMethod_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x000BC0F0 File Offset: 0x000BA2F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38613, RefRangeEnd = 38614, XrefRangeStart = 38608, XrefRangeEnd = 38613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWorkIncome(int value, EventManager.MathOperation mathOperation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mathOperation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SetWorkIncome_Public_Static_Void_Int32_MathOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000BC130 File Offset: 0x000BA330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38619, RefRangeEnd = 38620, XrefRangeStart = 38614, XrefRangeEnd = 38619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWorkCombo(int value, EventManager.MathOperation mathOperation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mathOperation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SetWorkCombo_Public_Static_Void_Int32_MathOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000BC170 File Offset: 0x000BA370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38625, RefRangeEnd = 38626, XrefRangeStart = 38620, XrefRangeEnd = 38625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ModifyWorkTime(int time)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_ModifyWorkTime_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000BC1A4 File Offset: 0x000BA3A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38649, RefRangeEnd = 38650, XrefRangeStart = 38626, XrefRangeEnd = 38649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SupplementaryBeverages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SupplementaryBeverages_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000BC1CC File Offset: 0x000BA3CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38673, RefRangeEnd = 38674, XrefRangeStart = 38650, XrefRangeEnd = 38673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SupplementaryIngredients()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SupplementaryIngredients_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000BC1F4 File Offset: 0x000BA3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38697, RefRangeEnd = 38698, XrefRangeStart = 38674, XrefRangeEnd = 38697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SupplementaryFoods()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SupplementaryFoods_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000BC21C File Offset: 0x000BA41C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 38703, RefRangeEnd = 38705, XrefRangeStart = 38698, XrefRangeEnd = 38703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerRandomQTEBuff(bool mustTrigger)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mustTrigger;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_TriggerRandomQTEBuff_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x000BC250 File Offset: 0x000BA450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38710, RefRangeEnd = 38711, XrefRangeStart = 38705, XrefRangeEnd = 38710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerThrowServingQTEBuff()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_TriggerThrowServingQTEBuff_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x000BC278 File Offset: 0x000BA478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38716, RefRangeEnd = 38717, XrefRangeStart = 38711, XrefRangeEnd = 38716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerPatientQTEBuff()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_TriggerPatientQTEBuff_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x000BC2A0 File Offset: 0x000BA4A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38722, RefRangeEnd = 38723, XrefRangeStart = 38717, XrefRangeEnd = 38722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerFinishEatingImmediatelyQTEBuff()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_TriggerFinishEatingImmediatelyQTEBuff_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x000BC2C8 File Offset: 0x000BA4C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38733, RefRangeEnd = 38734, XrefRangeStart = 38723, XrefRangeEnd = 38733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPassionLevelOverrideActive(bool active)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SetPassionLevelOverrideActive_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x000BC2FC File Offset: 0x000BA4FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38740, RefRangeEnd = 38741, XrefRangeStart = 38734, XrefRangeEnd = 38740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IncreasePassionLevel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_IncreasePassionLevel_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x000BC324 File Offset: 0x000BA524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38747, RefRangeEnd = 38748, XrefRangeStart = 38741, XrefRangeEnd = 38747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DecreasePassionLevel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_DecreasePassionLevel_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x000BC34C File Offset: 0x000BA54C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38752, RefRangeEnd = 38753, XrefRangeStart = 38748, XrefRangeEnd = 38752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearSpecialGuestAlbum()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_ClearSpecialGuestAlbum_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000BC374 File Offset: 0x000BA574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38758, RefRangeEnd = 38759, XrefRangeStart = 38753, XrefRangeEnd = 38758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpawnNormalGuest()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SpawnNormalGuest_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x000BC39C File Offset: 0x000BA59C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38766, RefRangeEnd = 38767, XrefRangeStart = 38759, XrefRangeEnd = 38766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpawnSpecialGuest()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SpawnSpecialGuest_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000BC3C4 File Offset: 0x000BA5C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38778, RefRangeEnd = 38779, XrefRangeStart = 38767, XrefRangeEnd = 38778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpawnNormalGuest(int normalGuestId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalGuestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SpawnNormalGuest_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000BC3F8 File Offset: 0x000BA5F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38783, RefRangeEnd = 38784, XrefRangeStart = 38779, XrefRangeEnd = 38783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpawnSpecialGuest(int specialGuestId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref specialGuestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SpawnSpecialGuest_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000BC42C File Offset: 0x000BA62C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38792, RefRangeEnd = 38793, XrefRangeStart = 38784, XrefRangeEnd = 38792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RepellGuestAndPay()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_RepellGuestAndPay_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x000BC454 File Offset: 0x000BA654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38804, RefRangeEnd = 38805, XrefRangeStart = 38793, XrefRangeEnd = 38804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RepellGuestAndPay(int deskCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_RepellGuestAndPay_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x000BC488 File Offset: 0x000BA688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38812, RefRangeEnd = 38813, XrefRangeStart = 38805, XrefRangeEnd = 38812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RepellGuestAndPayByMoodValue(int deskCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_RepellGuestAndPayByMoodValue_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000BC4BC File Offset: 0x000BA6BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38819, RefRangeEnd = 38820, XrefRangeStart = 38813, XrefRangeEnd = 38819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerPositiveBuff(int deskCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_TriggerPositiveBuff_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000BC4F0 File Offset: 0x000BA6F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38826, RefRangeEnd = 38827, XrefRangeStart = 38820, XrefRangeEnd = 38826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerNegativeBuff(int deskCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_TriggerNegativeBuff_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x000BC524 File Offset: 0x000BA724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38836, RefRangeEnd = 38837, XrefRangeStart = 38827, XrefRangeEnd = 38836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PatientDeplete(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_PatientDeplete_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x000BC558 File Offset: 0x000BA758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38842, RefRangeEnd = 38843, XrefRangeStart = 38837, XrefRangeEnd = 38842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveAllRegisteredTimedBuff()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_RemoveAllRegisteredTimedBuff_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000BC580 File Offset: 0x000BA780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38847, RefRangeEnd = 38848, XrefRangeStart = 38843, XrefRangeEnd = 38847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisteredCheatedBuff()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_RegisteredCheatedBuff_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000BC5A8 File Offset: 0x000BA7A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38856, RefRangeEnd = 38857, XrefRangeStart = 38848, XrefRangeEnd = 38856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisteredEternityFever()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_RegisteredEternityFever_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000BC5D0 File Offset: 0x000BA7D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 38877, RefRangeEnd = 38879, XrefRangeStart = 38857, XrefRangeEnd = 38877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SpecialGuestsController GetSpecialGuestsController(int deskCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_GetSpecialGuestsController_Private_Static_SpecialGuestsController_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr3) : null;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000BC610 File Offset: 0x000BA810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38879, XrefRangeEnd = 38916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Object> GetAllNormalGuestsMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_GetAllNormalGuestsMapping_Private_Static_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x000BC644 File Offset: 0x000BA844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38916, XrefRangeEnd = 38953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Object> GetAllSpecialGuestsMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_GetAllSpecialGuestsMapping_Private_Static_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x000BC678 File Offset: 0x000BA878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38953, XrefRangeEnd = 38987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Object> GetAllFoodsMapping()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_GetAllFoodsMapping_Private_Static_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000BC6AC File Offset: 0x000BA8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38987, XrefRangeEnd = 38991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddWorkTip(int value, EventManager.ServeType serveType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serveType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_AddWorkTip_Private_Static_Void_Int32_ServeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x000BC6EC File Offset: 0x000BA8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38991, XrefRangeEnd = 38996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPassionValue(float value, EventManager.MathOperation mathOperation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mathOperation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SetPassionValue_Private_Static_Void_Single_MathOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000BC72C File Offset: 0x000BA92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38996, XrefRangeEnd = 39001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetComboValue(float value, EventManager.MathOperation mathOperation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mathOperation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SetComboValue_Private_Static_Void_Single_MathOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x000BC76C File Offset: 0x000BA96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39001, XrefRangeEnd = 39006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetCombo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_ResetCombo_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x000BC794 File Offset: 0x000BA994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39006, XrefRangeEnd = 39011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWorkExp(float value, EventManager.MathOperation mathOperation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mathOperation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SetWorkExp_Private_Static_Void_Single_MathOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000BC7D4 File Offset: 0x000BA9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39011, XrefRangeEnd = 39015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddPassionPerTime(float value, float timeInterval, int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeInterval;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_AddPassionPerTime_Private_Static_Void_Single_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x000BC824 File Offset: 0x000BAA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39015, XrefRangeEnd = 39019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetFreeCook(int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SetFreeCook_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x000BC858 File Offset: 0x000BAA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39019, XrefRangeEnd = 39023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LockDailyRecipes(int amount, int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_LockDailyRecipes_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x000BC898 File Offset: 0x000BAA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39023, XrefRangeEnd = 39027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CookTimeAndOrderRateEditByTag(int foodTag, float cookTimeMultiplier, float additiveContinueProbability, int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref foodTag;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cookTimeMultiplier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additiveContinueProbability;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_CookTimeAndOrderRateEditByTag_Private_Static_Void_Int32_Single_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000BC8F4 File Offset: 0x000BAAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39027, XrefRangeEnd = 39034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CookTimeAndOrderRateEditByCookerType(float multiplier, float additiveContinueProbability, int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additiveContinueProbability;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_CookTimeAndOrderRateEditByCookerType_Private_Static_Void_Single_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000BC944 File Offset: 0x000BAB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39034, XrefRangeEnd = 39038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForcedOverrideFoodProbably(float rate, int durationSeconds, int foodId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rate;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref foodId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_ForcedOverrideFoodProbably_Private_Static_Void_Single_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000BC994 File Offset: 0x000BAB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39038, XrefRangeEnd = 39042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetFreeCookRate(float rate)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SetFreeCookRate_Private_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000BC9C8 File Offset: 0x000BABC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39042, XrefRangeEnd = 39047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnlockInfo(int amount, int specialGuestId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref specialGuestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_UnlockInfo_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000BCA08 File Offset: 0x000BAC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39047, XrefRangeEnd = 39051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stun(int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_Stun_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000BCA3C File Offset: 0x000BAC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39051, XrefRangeEnd = 39055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChangeMoveSpeedByBuff(float multiplier, int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_ChangeMoveSpeedByBuff_Private_Static_Void_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000BCA7C File Offset: 0x000BAC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39055, XrefRangeEnd = 39060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPartnerExtraWage(float multiplier)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SetPartnerExtraWage_Private_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x000BCAB0 File Offset: 0x000BACB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39060, XrefRangeEnd = 39065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemovePartnerExtraWage(float multiplier)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_RemovePartnerExtraWage_Private_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000BCAE4 File Offset: 0x000BACE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39065, XrefRangeEnd = 39069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGuestNotLeaveWhenIzakayaClose(int durationSeconds, EventManager.BuffType buffType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SetGuestNotLeaveWhenIzakayaClose_Private_Static_Void_Int32_BuffType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000BCB24 File Offset: 0x000BAD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39069, XrefRangeEnd = 39073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GuestMoodExtraAddEdit(int mood, int durationSeconds, EventManager.BuffType buffType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mood;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_GuestMoodExtraAddEdit_Private_Static_Void_Int32_Int32_BuffType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000BCB74 File Offset: 0x000BAD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39073, XrefRangeEnd = 39077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OrderCycleRateEdit(float multiplier, int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_OrderCycleRateEdit_Private_Static_Void_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x000BCBB4 File Offset: 0x000BADB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39077, XrefRangeEnd = 39081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EatTimeEdit(float multiplier, int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_EatTimeEdit_Private_Static_Void_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000BCBF4 File Offset: 0x000BADF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39081, XrefRangeEnd = 39085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GuestPatientEdit_Youmu(float value, float timeInterval, float multiplier, int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeInterval;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiplier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_GuestPatientEdit_Youmu_Private_Static_Void_Single_Single_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x000BCC50 File Offset: 0x000BAE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39085, XrefRangeEnd = 39089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpawnRateEdit(float multiplier, int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SpawnRateEdit_Private_Static_Void_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000BCC90 File Offset: 0x000BAE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39089, XrefRangeEnd = 39093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriggleSpawnRateEdit(float multiplier, int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_WriggleSpawnRateEdit_Private_Static_Void_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x000BCCD0 File Offset: 0x000BAED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39093, XrefRangeEnd = 39097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChenSpawnRateEdit(float multiplier)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_ChenSpawnRateEdit_Private_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x000BCD04 File Offset: 0x000BAF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39097, XrefRangeEnd = 39101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MomiziSpawnRateEdit(int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_MomiziSpawnRateEdit_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x000BCD38 File Offset: 0x000BAF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39101, XrefRangeEnd = 39105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GuestInstantEvaluate(int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_GuestInstantEvaluate_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000BCD6C File Offset: 0x000BAF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39105, XrefRangeEnd = 39109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GuestInstantEvaluate_Yuyuko()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_GuestInstantEvaluate_Yuyuko_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x000BCD94 File Offset: 0x000BAF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39109, XrefRangeEnd = 39113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GuestPatientFreeze(int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_GuestPatientFreeze_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x000BCDC8 File Offset: 0x000BAFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39113, XrefRangeEnd = 39117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowDeliver(int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_ThrowDeliver_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x000BCDFC File Offset: 0x000BAFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39117, XrefRangeEnd = 39121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PartnerThrowDeliver(int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_PartnerThrowDeliver_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000BCE30 File Offset: 0x000BB030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39121, XrefRangeEnd = 39125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Fever(int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_Fever_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x000BCE64 File Offset: 0x000BB064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39125, XrefRangeEnd = 39129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpawnNormalGuests(int amount, int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SpawnNormalGuests_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x000BCEA4 File Offset: 0x000BB0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39129, XrefRangeEnd = 39133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpawnTargetNormalGuests(int amount, int durationSeconds, int normalGuestId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalGuestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SpawnTargetNormalGuests_Private_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x000BCEF4 File Offset: 0x000BB0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39133, XrefRangeEnd = 39137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MakeGuestsPayTipsNormal(int minAmount, int maxAmount, int timeInterval)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minAmount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxAmount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeInterval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_MakeGuestsPayTipsNormal_Private_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x000BCF44 File Offset: 0x000BB144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39137, XrefRangeEnd = 39141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MakeGuestsPayTipsKasen(int minAmount, int maxAmount, int minTimeInterval, int maxTimeInterval, int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minAmount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxAmount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minTimeInterval;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxTimeInterval;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_MakeGuestsPayTipsKasen_Private_Static_Void_Int32_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000BCFB0 File Offset: 0x000BB1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39141, XrefRangeEnd = 39145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnambitiousGuests(int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_UnambitiousGuests_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x000BCFE4 File Offset: 0x000BB1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39145, XrefRangeEnd = 39149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtraFee(int durationSeconds, float extraFeePercentage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraFeePercentage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_ExtraFee_Private_Static_Void_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x000BD024 File Offset: 0x000BB224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39149, XrefRangeEnd = 39153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtraFeeForever(float extraFeePercentage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref extraFeePercentage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_ExtraFeeForever_Private_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x000BD058 File Offset: 0x000BB258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39153, XrefRangeEnd = 39157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MinEvalLevelSet(int durationSeconds, int baseEval)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseEval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_MinEvalLevelSet_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x000BD098 File Offset: 0x000BB298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39157, XrefRangeEnd = 39161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MaxEvalLevelSet(int durationSeconds, int maxEval)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxEval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_MaxEvalLevelSet_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x000BD0D8 File Offset: 0x000BB2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39161, XrefRangeEnd = 39165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MaxEvalLevelSet_Yuyuko(int maxEval)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxEval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_MaxEvalLevelSet_Yuyuko_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000BD10C File Offset: 0x000BB30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39165, XrefRangeEnd = 39169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RandomEval(int durationSeconds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_RandomEval_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000BD140 File Offset: 0x000BB340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39169, XrefRangeEnd = 39173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBestEvalRate(float rate)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.NativeMethodInfoPtr_SetBestEvalRate_Private_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00007714 File Offset: 0x00005914
		public NightSceneDebugImpl(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x000BD174 File Offset: 0x000BB374
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x0000771D File Offset: 0x0000591D
		public unsafe static int GIVE_AMOUNT_MIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NightSceneDebugImpl.NativeFieldInfoPtr_GIVE_AMOUNT_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NightSceneDebugImpl.NativeFieldInfoPtr_GIVE_AMOUNT_MIN, (void*)(&value));
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x000BD190 File Offset: 0x000BB390
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x0000772B File Offset: 0x0000592B
		public unsafe static int GIVE_AMOUNT_MAX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NightSceneDebugImpl.NativeFieldInfoPtr_GIVE_AMOUNT_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NightSceneDebugImpl.NativeFieldInfoPtr_GIVE_AMOUNT_MAX, (void*)(&value));
			}
		}

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeFieldInfoPtr_GIVE_AMOUNT_MIN;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr_GIVE_AMOUNT_MAX;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_RegisterMethod_Public_Static_Void_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterMethod_Public_Static_Void_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_SetWorkIncome_Public_Static_Void_Int32_MathOperation_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_SetWorkCombo_Public_Static_Void_Int32_MathOperation_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_ModifyWorkTime_Public_Static_Void_Int32_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_SupplementaryBeverages_Public_Static_Void_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_SupplementaryIngredients_Public_Static_Void_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_SupplementaryFoods_Public_Static_Void_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_TriggerRandomQTEBuff_Public_Static_Void_Boolean_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_TriggerThrowServingQTEBuff_Public_Static_Void_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_TriggerPatientQTEBuff_Public_Static_Void_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_TriggerFinishEatingImmediatelyQTEBuff_Public_Static_Void_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_SetPassionLevelOverrideActive_Public_Static_Void_Boolean_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_IncreasePassionLevel_Public_Static_Void_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_DecreasePassionLevel_Public_Static_Void_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_ClearSpecialGuestAlbum_Public_Static_Void_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_SpawnNormalGuest_Public_Static_Void_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_SpawnSpecialGuest_Public_Static_Void_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_SpawnNormalGuest_Public_Static_Void_Int32_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_SpawnSpecialGuest_Public_Static_Void_Int32_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_RepellGuestAndPay_Public_Static_Void_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_RepellGuestAndPay_Public_Static_Void_Int32_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_RepellGuestAndPayByMoodValue_Public_Static_Void_Int32_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_TriggerPositiveBuff_Public_Static_Void_Int32_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_TriggerNegativeBuff_Public_Static_Void_Int32_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_PatientDeplete_Public_Static_Void_Int32_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllRegisteredTimedBuff_Public_Static_Void_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_RegisteredCheatedBuff_Public_Static_Void_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_RegisteredEternityFever_Public_Static_Void_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestsController_Private_Static_SpecialGuestsController_Int32_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_GetAllNormalGuestsMapping_Private_Static_Dictionary_2_String_Object_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_GetAllSpecialGuestsMapping_Private_Static_Dictionary_2_String_Object_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_GetAllFoodsMapping_Private_Static_Dictionary_2_String_Object_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_AddWorkTip_Private_Static_Void_Int32_ServeType_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_SetPassionValue_Private_Static_Void_Single_MathOperation_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_SetComboValue_Private_Static_Void_Single_MathOperation_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_ResetCombo_Private_Static_Void_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_SetWorkExp_Private_Static_Void_Single_MathOperation_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_AddPassionPerTime_Private_Static_Void_Single_Single_Int32_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_SetFreeCook_Private_Static_Void_Int32_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_LockDailyRecipes_Private_Static_Void_Int32_Int32_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_CookTimeAndOrderRateEditByTag_Private_Static_Void_Int32_Single_Single_Int32_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_CookTimeAndOrderRateEditByCookerType_Private_Static_Void_Single_Single_Int32_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_ForcedOverrideFoodProbably_Private_Static_Void_Single_Int32_Int32_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_SetFreeCookRate_Private_Static_Void_Single_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_UnlockInfo_Private_Static_Void_Int32_Int32_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_Stun_Private_Static_Void_Int32_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_ChangeMoveSpeedByBuff_Private_Static_Void_Single_Int32_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_SetPartnerExtraWage_Private_Static_Void_Single_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_RemovePartnerExtraWage_Private_Static_Void_Single_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_SetGuestNotLeaveWhenIzakayaClose_Private_Static_Void_Int32_BuffType_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_GuestMoodExtraAddEdit_Private_Static_Void_Int32_Int32_BuffType_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_OrderCycleRateEdit_Private_Static_Void_Single_Int32_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_EatTimeEdit_Private_Static_Void_Single_Int32_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_GuestPatientEdit_Youmu_Private_Static_Void_Single_Single_Single_Int32_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_SpawnRateEdit_Private_Static_Void_Single_Int32_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_WriggleSpawnRateEdit_Private_Static_Void_Single_Int32_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_ChenSpawnRateEdit_Private_Static_Void_Single_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_MomiziSpawnRateEdit_Private_Static_Void_Int32_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_GuestInstantEvaluate_Private_Static_Void_Int32_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_GuestInstantEvaluate_Yuyuko_Private_Static_Void_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_GuestPatientFreeze_Private_Static_Void_Int32_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_ThrowDeliver_Private_Static_Void_Int32_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_PartnerThrowDeliver_Private_Static_Void_Int32_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_Fever_Private_Static_Void_Int32_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_SpawnNormalGuests_Private_Static_Void_Int32_Int32_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_SpawnTargetNormalGuests_Private_Static_Void_Int32_Int32_Int32_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_MakeGuestsPayTipsNormal_Private_Static_Void_Int32_Int32_Int32_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_MakeGuestsPayTipsKasen_Private_Static_Void_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_UnambitiousGuests_Private_Static_Void_Int32_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_ExtraFee_Private_Static_Void_Int32_Single_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_ExtraFeeForever_Private_Static_Void_Single_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_MinEvalLevelSet_Private_Static_Void_Int32_Int32_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_MaxEvalLevelSet_Private_Static_Void_Int32_Int32_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_MaxEvalLevelSet_Yuyuko_Private_Static_Void_Int32_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_RandomEval_Private_Static_Void_Int32_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_SetBestEvalRate_Private_Static_Void_Single_0;

		// Token: 0x02000511 RID: 1297
		[ObfuscatedName("PrototypingManagers.NightSceneDebugImpl+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06008461 RID: 33889 RVA: 0x002520EC File Offset: 0x002502EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NightSceneDebugImpl>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr);
				NightSceneDebugImpl.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, "<>9");
				NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, "<>9__32_0");
				NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, "<>9__32_1");
				NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, "<>9__33_0");
				NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, "<>9__33_1");
				NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, "<>9__34_0");
				NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__34_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, "<>9__34_1");
				NightSceneDebugImpl.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, 100664901);
				NightSceneDebugImpl.__c.NativeMethodInfoPtr__GetAllNormalGuestsMapping_b__32_0_Internal_String_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, 100664902);
				NightSceneDebugImpl.__c.NativeMethodInfoPtr__GetAllNormalGuestsMapping_b__32_1_Internal_Object_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, 100664903);
				NightSceneDebugImpl.__c.NativeMethodInfoPtr__GetAllSpecialGuestsMapping_b__33_0_Internal_String_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, 100664904);
				NightSceneDebugImpl.__c.NativeMethodInfoPtr__GetAllSpecialGuestsMapping_b__33_1_Internal_Object_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, 100664905);
				NightSceneDebugImpl.__c.NativeMethodInfoPtr__GetAllFoodsMapping_b__34_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, 100664906);
				NightSceneDebugImpl.__c.NativeMethodInfoPtr__GetAllFoodsMapping_b__34_1_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr, 100664907);
			}

			// Token: 0x06008462 RID: 33890 RVA: 0x00252230 File Offset: 0x00250430
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NightSceneDebugImpl.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008463 RID: 33891 RVA: 0x0025226C File Offset: 0x0025046C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38559, XrefRangeEnd = 38566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllNormalGuestsMapping_b__32_0(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.__c.NativeMethodInfoPtr__GetAllNormalGuestsMapping_b__32_0_Internal_String_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008464 RID: 33892 RVA: 0x002522B4 File Offset: 0x002504B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38566, XrefRangeEnd = 38569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _GetAllNormalGuestsMapping_b__32_1(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.__c.NativeMethodInfoPtr__GetAllNormalGuestsMapping_b__32_1_Internal_Object_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06008465 RID: 33893 RVA: 0x00252304 File Offset: 0x00250504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38569, XrefRangeEnd = 38576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllSpecialGuestsMapping_b__33_0(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.__c.NativeMethodInfoPtr__GetAllSpecialGuestsMapping_b__33_0_Internal_String_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008466 RID: 33894 RVA: 0x0025234C File Offset: 0x0025054C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38576, XrefRangeEnd = 38579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _GetAllSpecialGuestsMapping_b__33_1(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.__c.NativeMethodInfoPtr__GetAllSpecialGuestsMapping_b__33_1_Internal_Object_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06008467 RID: 33895 RVA: 0x0025239C File Offset: 0x0025059C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38579, XrefRangeEnd = 38583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetAllFoodsMapping_b__34_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.__c.NativeMethodInfoPtr__GetAllFoodsMapping_b__34_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008468 RID: 33896 RVA: 0x002523E0 File Offset: 0x002505E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38583, XrefRangeEnd = 38586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _GetAllFoodsMapping_b__34_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NightSceneDebugImpl.__c.NativeMethodInfoPtr__GetAllFoodsMapping_b__34_1_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06008469 RID: 33897 RVA: 0x00047496 File Offset: 0x00045696
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C7B RID: 11387
			// (get) Token: 0x0600846A RID: 33898 RVA: 0x0025242C File Offset: 0x0025062C
			// (set) Token: 0x0600846B RID: 33899 RVA: 0x0004749F File Offset: 0x0004569F
			public unsafe static NightSceneDebugImpl.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NightSceneDebugImpl.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C7C RID: 11388
			// (get) Token: 0x0600846C RID: 33900 RVA: 0x00252454 File Offset: 0x00250654
			// (set) Token: 0x0600846D RID: 33901 RVA: 0x000474B1 File Offset: 0x000456B1
			public unsafe static Func<NormalGuest, string> __9__32_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__32_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__32_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C7D RID: 11389
			// (get) Token: 0x0600846E RID: 33902 RVA: 0x0025247C File Offset: 0x0025067C
			// (set) Token: 0x0600846F RID: 33903 RVA: 0x000474C3 File Offset: 0x000456C3
			public unsafe static Func<NormalGuest, Object> __9__32_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__32_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__32_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C7E RID: 11390
			// (get) Token: 0x06008470 RID: 33904 RVA: 0x002524A4 File Offset: 0x002506A4
			// (set) Token: 0x06008471 RID: 33905 RVA: 0x000474D5 File Offset: 0x000456D5
			public unsafe static Func<SpecialGuest, string> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C7F RID: 11391
			// (get) Token: 0x06008472 RID: 33906 RVA: 0x002524CC File Offset: 0x002506CC
			// (set) Token: 0x06008473 RID: 33907 RVA: 0x000474E7 File Offset: 0x000456E7
			public unsafe static Func<SpecialGuest, Object> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C80 RID: 11392
			// (get) Token: 0x06008474 RID: 33908 RVA: 0x002524F4 File Offset: 0x002506F4
			// (set) Token: 0x06008475 RID: 33909 RVA: 0x000474F9 File Offset: 0x000456F9
			public unsafe static Func<int, string> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C81 RID: 11393
			// (get) Token: 0x06008476 RID: 33910 RVA: 0x0025251C File Offset: 0x0025071C
			// (set) Token: 0x06008477 RID: 33911 RVA: 0x0004750B File Offset: 0x0004570B
			public unsafe static Func<int, Object> __9__34_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__34_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NightSceneDebugImpl.__c.NativeFieldInfoPtr___9__34_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005713 RID: 22291
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005714 RID: 22292
			private static readonly IntPtr NativeFieldInfoPtr___9__32_0;

			// Token: 0x04005715 RID: 22293
			private static readonly IntPtr NativeFieldInfoPtr___9__32_1;

			// Token: 0x04005716 RID: 22294
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x04005717 RID: 22295
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x04005718 RID: 22296
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x04005719 RID: 22297
			private static readonly IntPtr NativeFieldInfoPtr___9__34_1;

			// Token: 0x0400571A RID: 22298
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400571B RID: 22299
			private static readonly IntPtr NativeMethodInfoPtr__GetAllNormalGuestsMapping_b__32_0_Internal_String_NormalGuest_0;

			// Token: 0x0400571C RID: 22300
			private static readonly IntPtr NativeMethodInfoPtr__GetAllNormalGuestsMapping_b__32_1_Internal_Object_NormalGuest_0;

			// Token: 0x0400571D RID: 22301
			private static readonly IntPtr NativeMethodInfoPtr__GetAllSpecialGuestsMapping_b__33_0_Internal_String_SpecialGuest_0;

			// Token: 0x0400571E RID: 22302
			private static readonly IntPtr NativeMethodInfoPtr__GetAllSpecialGuestsMapping_b__33_1_Internal_Object_SpecialGuest_0;

			// Token: 0x0400571F RID: 22303
			private static readonly IntPtr NativeMethodInfoPtr__GetAllFoodsMapping_b__34_0_Internal_String_Int32_0;

			// Token: 0x04005720 RID: 22304
			private static readonly IntPtr NativeMethodInfoPtr__GetAllFoodsMapping_b__34_1_Internal_Object_Int32_0;
		}
	}
}
