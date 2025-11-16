using System;
using System.Runtime.InteropServices;
using DEYU.Singletons;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace NightScene.PartnerUtility
{
	// Token: 0x0200019F RID: 415
	public class PartnerManager : MonoSingleton<PartnerManager>
	{
		// Token: 0x06002CF3 RID: 11507 RVA: 0x00133978 File Offset: 0x00131B78
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerManager()
		{
			Il2CppClassPointerStore<PartnerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.PartnerUtility", "PartnerManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr);
			PartnerManager.NativeFieldInfoPtr_ANONYMOUS_SYSTEM_CHANGE_SENDER_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "ANONYMOUS_SYSTEM_CHANGE_SENDER_INDEX");
			PartnerManager.NativeFieldInfoPtr_afterInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "afterInitialize");
			PartnerManager.NativeFieldInfoPtr_allOrders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "allOrders");
			PartnerManager.NativeFieldInfoPtr_availableCookers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "availableCookers");
			PartnerManager.NativeFieldInfoPtr_occupiedOrderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "occupiedOrderData");
			PartnerManager.NativeFieldInfoPtr_allOrdersCookHasFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "allOrdersCookHasFinish");
			PartnerManager.NativeFieldInfoPtr_partnerInfoCoroutines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "partnerInfoCoroutines");
			PartnerManager.NativeFieldInfoPtr_partners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "partners");
			PartnerManager.NativeFieldInfoPtr_partnersByIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "partnersByIndex");
			PartnerManager.NativeFieldInfoPtr_stunedPartners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "stunedPartners");
			PartnerManager.NativeFieldInfoPtr_setPartnerOrderDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "setPartnerOrderDataCallback");
			PartnerManager.NativeFieldInfoPtr_setPartnerStateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "setPartnerStateCallback");
			PartnerManager.NativeFieldInfoPtr__HaveInitialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "<HaveInitialized>k__BackingField");
			PartnerManager.NativeFieldInfoPtr__CanAddAvailableCooker_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "<CanAddAvailableCooker>k__BackingField");
			PartnerManager.NativeFieldInfoPtr_bossGetScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "bossGetScore");
			PartnerManager.NativeFieldInfoPtr_BossOccupiedDeskCodeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "BossOccupiedDeskCodeList");
			PartnerManager.NativeFieldInfoPtr_PlayerOccupiedDeskCodeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "PlayerOccupiedDeskCodeList");
			PartnerManager.NativeFieldInfoPtr_BossPartnerMatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "BossPartnerMatching");
			PartnerManager.NativeFieldInfoPtr_GetLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "GetLabel");
			PartnerManager.NativeFieldInfoPtr_setBossScoreCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "setBossScoreCallback");
			PartnerManager.NativeFieldInfoPtr_partnerOccupyDeskCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "partnerOccupyDeskCallback");
			PartnerManager.NativeFieldInfoPtr_partnerReleaseDeskCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "partnerReleaseDeskCallback");
			PartnerManager.NativeFieldInfoPtr_playerOccupyDeskCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "playerOccupyDeskCallback");
			PartnerManager.NativeFieldInfoPtr_playerReleaseDeskCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "playerReleaseDeskCallback");
			PartnerManager.NativeFieldInfoPtr__BossGetCombo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "<BossGetCombo>k__BackingField");
			PartnerManager.NativeMethodInfoPtr_get_AllProcessingOrders_Public_get_IEnumerable_1_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671155);
			PartnerManager.NativeMethodInfoPtr_get_AllAvailableCookerCanUseByPartner_Public_get_IEnumerable_1_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671156);
			PartnerManager.NativeMethodInfoPtr_get_AllStunedPartners_Public_get_IEnumerable_1_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671157);
			PartnerManager.NativeMethodInfoPtr_get_AllOrdersCookHasFinish_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671158);
			PartnerManager.NativeMethodInfoPtr_get_HaveInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671159);
			PartnerManager.NativeMethodInfoPtr_set_HaveInitialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671160);
			PartnerManager.NativeMethodInfoPtr_GetAllPartnersAndType_Public_IEnumerable_1_KeyValuePair_2_PartnerType_IEnumerable_1_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671161);
			PartnerManager.NativeMethodInfoPtr_GetAllPartners_Public_IEnumerable_1_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671162);
			PartnerManager.NativeMethodInfoPtr_GetTargetPartner_Public_Boolean_Int32_byref_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671163);
			PartnerManager.NativeMethodInfoPtr_GetTargetPartnerByIndex_Public_Boolean_Int32_byref_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671164);
			PartnerManager.NativeMethodInfoPtr_MarkForOccupied_Public_Void_PartnerType_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671165);
			PartnerManager.NativeMethodInfoPtr_HasOccupied_Public_Boolean_PartnerType_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671166);
			PartnerManager.NativeMethodInfoPtr_ReleaseFromOccupied_Public_Void_PartnerType_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671167);
			PartnerManager.NativeMethodInfoPtr_GetOrderedAwaitingOrder_Public_Boolean_PartnerType_byref_IEnumerable_1_OrderBase_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671168);
			PartnerManager.NativeMethodInfoPtr_TryGetCookerForOrder_Public_GetCookerInfo_Sellable_byref_CookController_byref_Recipe_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671169);
			PartnerManager.NativeMethodInfoPtr_get_CanAddAvailableCooker_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671170);
			PartnerManager.NativeMethodInfoPtr_set_CanAddAvailableCooker_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671171);
			PartnerManager.NativeMethodInfoPtr_AddToAvailableCooker_Public_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671172);
			PartnerManager.NativeMethodInfoPtr_RemoveFromAvailableCooker_Public_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671173);
			PartnerManager.NativeMethodInfoPtr_ResetAvailableCooker_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671174);
			PartnerManager.NativeMethodInfoPtr_SetTargetDeskOrderHasMadeByCook_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671175);
			PartnerManager.NativeMethodInfoPtr_GetAllPartnersTransform_Public_IEnumerable_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671176);
			PartnerManager.NativeMethodInfoPtr_GetBufferCount_Public_Int32_Int32_SellableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671177);
			PartnerManager.NativeMethodInfoPtr_CheckStunedStatus_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671178);
			PartnerManager.NativeMethodInfoPtr_AddStunedStatus_Public_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671179);
			PartnerManager.NativeMethodInfoPtr_ResetStunedStatus_Public_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671180);
			PartnerManager.NativeMethodInfoPtr_Initialize_Public_Void_IEnumerable_1_ValueTuple_2_Int32_PartnerBase_IEnumerable_1_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671181);
			PartnerManager.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671182);
			PartnerManager.NativeMethodInfoPtr_StopPartnerCoroutines_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671183);
			PartnerManager.NativeMethodInfoPtr_StartPartnerCoroutine_Public_Void_PartnerInfoBase_String_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671184);
			PartnerManager.NativeMethodInfoPtr_TryStopPartnerCoroutine_Public_Void_PartnerInfoBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671185);
			PartnerManager.NativeMethodInfoPtr_SetPartnerOrderData_Public_Void_Int32_Nullable_1_PartnerType_SellableType_String_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671186);
			PartnerManager.NativeMethodInfoPtr_UpdateStatus_Public_Void_Nullable_1_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671187);
			PartnerManager.NativeMethodInfoPtr_NotifySystemChanged_Public_Void_Int32_OrderChangeContext_OrderBase_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671188);
			PartnerManager.NativeMethodInfoPtr_OnOrderBaseAdd_Public_Void_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671189);
			PartnerManager.NativeMethodInfoPtr_OnThrowDeliverStart_Public_Void_OrderBase_Il2CppReferenceArray_1_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671190);
			PartnerManager.NativeMethodInfoPtr_OnOrderBaseStatusUpdate_Public_Void_OrderBase_OrderChangeContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671191);
			PartnerManager.NativeMethodInfoPtr_OnInventoryRefresh_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671192);
			PartnerManager.NativeMethodInfoPtr_OnPlayerRefreshInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671193);
			PartnerManager.NativeMethodInfoPtr_OnPlayerStartCooker_Public_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671194);
			PartnerManager.NativeMethodInfoPtr_OnCookerAvailabilityUpdate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671195);
			PartnerManager.NativeMethodInfoPtr_OnPartnerWakeUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671196);
			PartnerManager.NativeMethodInfoPtr_OnPartnerStunBegin_Public_Void_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671197);
			PartnerManager.NativeMethodInfoPtr_OnPartnerStunEnd_Public_Void_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671198);
			PartnerManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671199);
			PartnerManager.NativeMethodInfoPtr_AddBossPartner_Public_Void_PartnerBossInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671200);
			PartnerManager.NativeMethodInfoPtr_get_BossGetScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671201);
			PartnerManager.NativeMethodInfoPtr_set_BossGetScore_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671202);
			PartnerManager.NativeMethodInfoPtr_get_BossGetCombo_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671203);
			PartnerManager.NativeMethodInfoPtr_set_BossGetCombo_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671204);
			PartnerManager.NativeMethodInfoPtr_AddBossCombo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671205);
			PartnerManager.NativeMethodInfoPtr_SetBossCombo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671206);
			PartnerManager.NativeMethodInfoPtr_TryAddBossOccupiedDeskCode_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671207);
			PartnerManager.NativeMethodInfoPtr_ReleaseBossOccupiedDeskCode_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671208);
			PartnerManager.NativeMethodInfoPtr_TryAddPlayerOccupiedDeskCode_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671209);
			PartnerManager.NativeMethodInfoPtr_ReleasePlayerOccupiedDeskCode_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671210);
			PartnerManager.NativeMethodInfoPtr_CheckThisDeskHaveOccupiedByBoss_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671211);
			PartnerManager.NativeMethodInfoPtr_CheckThisDeskHaveOccupiedByPlayer_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671212);
			PartnerManager.NativeMethodInfoPtr_CheckThisDeskHaveOccupiedByAnyone_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671213);
			PartnerManager.NativeMethodInfoPtr_GetBossTipRate_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671214);
			PartnerManager.NativeMethodInfoPtr_AddBossGetScore_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671215);
			PartnerManager.NativeMethodInfoPtr_InitializeBossPartnerModeManager_Public_Void_Action_1_Int32_Action_2_Int32_Int32_Action_1_Int32_Action_1_Int32_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671216);
			PartnerManager.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671217);
			PartnerManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671218);
			PartnerManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671219);
			PartnerManager.NativeMethodInfoPtr__get_AllStunedPartners_b__19_1_Private_PartnerBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671220);
			PartnerManager.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_1_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671221);
			PartnerManager.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_3_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671222);
			PartnerManager.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_6_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671223);
			PartnerManager.NativeMethodInfoPtr__AddStunedStatus_b__46_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671224);
			PartnerManager.NativeMethodInfoPtr__ResetStunedStatus_b__47_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, 100671225);
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x00134128 File Offset: 0x00132328
		public unsafe IEnumerable<GuestsManager.OrderBase> AllProcessingOrders
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_get_AllProcessingOrders_Public_get_IEnumerable_1_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<GuestsManager.OrderBase>>(intPtr3) : null;
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x00134168 File Offset: 0x00132368
		public unsafe IEnumerable<CookController> AllAvailableCookerCanUseByPartner
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 100927, RefRangeEnd = 100935, XrefRangeStart = 100908, XrefRangeEnd = 100927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_get_AllAvailableCookerCanUseByPartner_Public_get_IEnumerable_1_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<CookController>>(intPtr3) : null;
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x001341A8 File Offset: 0x001323A8
		public unsafe IEnumerable<PartnerBase> AllStunedPartners
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100935, XrefRangeEnd = 100966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_get_AllStunedPartners_Public_get_IEnumerable_1_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PartnerBase>>(intPtr3) : null;
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x001341E8 File Offset: 0x001323E8
		public unsafe IEnumerable<int> AllOrdersCookHasFinish
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_get_AllOrdersCookHasFinish_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x00134228 File Offset: 0x00132428
		// (set) Token: 0x06002CF9 RID: 11513 RVA: 0x00134264 File Offset: 0x00132464
		public unsafe bool HaveInitialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_get_HaveInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_set_HaveInitialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x001342A4 File Offset: 0x001324A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100972, RefRangeEnd = 100974, XrefRangeStart = 100966, XrefRangeEnd = 100972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>>> GetAllPartnersAndType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_GetAllPartnersAndType_Public_IEnumerable_1_KeyValuePair_2_PartnerType_IEnumerable_1_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>>>>(intPtr3) : null;
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x001342E4 File Offset: 0x001324E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 100993, RefRangeEnd = 100999, XrefRangeStart = 100974, XrefRangeEnd = 100993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<PartnerBase> GetAllPartners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_GetAllPartners_Public_IEnumerable_1_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PartnerBase>>(intPtr3) : null;
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00134324 File Offset: 0x00132524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100999, XrefRangeEnd = 101031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetTargetPartner(int partnerId, out PartnerBase partnerBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref partnerId;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_GetTargetPartner_Public_Boolean_Int32_byref_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			partnerBase = ((intPtr4 == 0) ? null : new PartnerBase(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00134390 File Offset: 0x00132590
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 101035, RefRangeEnd = 101038, XrefRangeStart = 101031, XrefRangeEnd = 101035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetTargetPartnerByIndex(int partnerIndex, out PartnerBase partnerBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref partnerIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_GetTargetPartnerByIndex_Public_Boolean_Int32_byref_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			partnerBase = ((intPtr4 == 0) ? null : new PartnerBase(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x001343FC File Offset: 0x001325FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 101100, RefRangeEnd = 101106, XrefRangeStart = 101038, XrefRangeEnd = 101100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkForOccupied(PartnerBase.PartnerType partnerType, GuestsManager.OrderBase orderBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref partnerType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orderBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_MarkForOccupied_Public_Void_PartnerType_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x0013444C File Offset: 0x0013264C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101113, RefRangeEnd = 101115, XrefRangeStart = 101106, XrefRangeEnd = 101113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasOccupied(PartnerBase.PartnerType partnerType, GuestsManager.OrderBase orderBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref partnerType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orderBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_HasOccupied_Public_Boolean_PartnerType_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x001344A8 File Offset: 0x001326A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 101135, RefRangeEnd = 101139, XrefRangeStart = 101115, XrefRangeEnd = 101135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseFromOccupied(PartnerBase.PartnerType partnerType, GuestsManager.OrderBase orderBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref partnerType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orderBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_ReleaseFromOccupied_Public_Void_PartnerType_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x001344F8 File Offset: 0x001326F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 101271, RefRangeEnd = 101277, XrefRangeStart = 101139, XrefRangeEnd = 101271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetOrderedAwaitingOrder(PartnerBase.PartnerType partnerType, out IEnumerable<GuestsManager.OrderBase> awaitingOrderBases, bool bossMode, float normalGuestServeWeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref partnerType;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bossMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalGuestServeWeight;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_GetOrderedAwaitingOrder_Public_Boolean_PartnerType_byref_IEnumerable_1_OrderBase_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			awaitingOrderBases = ((intPtr4 == 0) ? null : new IEnumerable<GuestsManager.OrderBase>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x00134580 File Offset: 0x00132780
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 101331, RefRangeEnd = 101335, XrefRangeStart = 101277, XrefRangeEnd = 101331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerManager.GetCookerInfo TryGetCookerForOrder(Sellable food, out CookController cookController, out Recipe targetRecipe, [Optional] Il2CppStructArray<int> canUsedCooker)
		{
			if (canUsedCooker == null)
			{
				canUsedCooker = new Il2CppStructArray<int>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(food);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canUsedCooker);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_TryGetCookerForOrder_Public_GetCookerInfo_Sellable_byref_CookController_byref_Recipe_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			cookController = ((intPtr5 == 0) ? null : new CookController(intPtr5));
			IntPtr intPtr6 = intPtr2;
			targetRecipe = ((intPtr6 == 0) ? null : new Recipe(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06002D03 RID: 11523 RVA: 0x00134634 File Offset: 0x00132834
		// (set) Token: 0x06002D04 RID: 11524 RVA: 0x00134670 File Offset: 0x00132870
		public unsafe bool CanAddAvailableCooker
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_get_CanAddAvailableCooker_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_set_CanAddAvailableCooker_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x001346B0 File Offset: 0x001328B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 101338, RefRangeEnd = 101345, XrefRangeStart = 101335, XrefRangeEnd = 101338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToAvailableCooker(CookController cooker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_AddToAvailableCooker_Public_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x001346F4 File Offset: 0x001328F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 101349, RefRangeEnd = 101352, XrefRangeStart = 101345, XrefRangeEnd = 101349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromAvailableCooker(CookController cooker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_RemoveFromAvailableCooker_Public_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x00134738 File Offset: 0x00132938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101356, RefRangeEnd = 101357, XrefRangeStart = 101352, XrefRangeEnd = 101356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAvailableCooker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_ResetAvailableCooker_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x0013476C File Offset: 0x0013296C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101370, RefRangeEnd = 101372, XrefRangeStart = 101357, XrefRangeEnd = 101370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetDeskOrderHasMadeByCook(int orderDeskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orderDeskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_SetTargetDeskOrderHasMadeByCook_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x001347AC File Offset: 0x001329AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101391, RefRangeEnd = 101393, XrefRangeStart = 101372, XrefRangeEnd = 101391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Transform> GetAllPartnersTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_GetAllPartnersTransform_Public_IEnumerable_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Transform>>(intPtr3) : null;
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x001347EC File Offset: 0x001329EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101425, RefRangeEnd = 101426, XrefRangeStart = 101393, XrefRangeEnd = 101425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetBufferCount(int targetSellableId, Sellable.SellableType sellableType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetSellableId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sellableType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_GetBufferCount_Public_Int32_Int32_SellableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x00134844 File Offset: 0x00132A44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 101448, RefRangeEnd = 101452, XrefRangeStart = 101426, XrefRangeEnd = 101448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckStunedStatus(int partnerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref partnerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_CheckStunedStatus_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x00134890 File Offset: 0x00132A90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101465, RefRangeEnd = 101466, XrefRangeStart = 101452, XrefRangeEnd = 101465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStunedStatus(List<int> partnerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_AddStunedStatus_Public_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x001348D4 File Offset: 0x00132AD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101479, RefRangeEnd = 101480, XrefRangeStart = 101466, XrefRangeEnd = 101479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetStunedStatus(List<int> partnerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_ResetStunedStatus_Public_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x00134918 File Offset: 0x00132B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101755, RefRangeEnd = 101756, XrefRangeStart = 101480, XrefRangeEnd = 101755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(IEnumerable<ValueTuple<int, PartnerBase>> employeeData, IEnumerable<CookController> cookers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(employeeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_Initialize_Public_Void_IEnumerable_1_ValueTuple_2_Int32_PartnerBase_IEnumerable_1_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x0013496C File Offset: 0x00132B6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101801, RefRangeEnd = 101803, XrefRangeStart = 101756, XrefRangeEnd = 101801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x001349A0 File Offset: 0x00132BA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101808, RefRangeEnd = 101809, XrefRangeStart = 101803, XrefRangeEnd = 101808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopPartnerCoroutines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_StopPartnerCoroutines_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x001349D4 File Offset: 0x00132BD4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 101828, RefRangeEnd = 101837, XrefRangeStart = 101809, XrefRangeEnd = 101828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPartnerCoroutine(PartnerInfoBase partnerInfoBase, string name, IEnumerator enumerator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerInfoBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_StartPartnerCoroutine_Public_Void_PartnerInfoBase_String_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x00134A3C File Offset: 0x00132C3C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 101853, RefRangeEnd = 101859, XrefRangeStart = 101837, XrefRangeEnd = 101853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStopPartnerCoroutine(PartnerInfoBase partnerInfoBase, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerInfoBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_TryStopPartnerCoroutine_Public_Void_PartnerInfoBase_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00134A90 File Offset: 0x00132C90
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 101863, RefRangeEnd = 101877, XrefRangeStart = 101859, XrefRangeEnd = 101863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPartnerOrderData(int deskCode, Nullable<PartnerBase.PartnerType> targetPartnerTypeOnUI, Sellable.SellableType sellableType, string debugMessage, GuestsManager.OrderBase orderInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(targetPartnerTypeOnUI));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sellableType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugMessage);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orderInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_SetPartnerOrderData_Public_Void_Int32_Nullable_1_PartnerType_SellableType_String_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x00134B1C File Offset: 0x00132D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101877, RefRangeEnd = 101878, XrefRangeStart = 101877, XrefRangeEnd = 101877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStatus(Nullable<int> deskCode, string data, int partnerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(deskCode));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partnerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_UpdateStatus_Public_Void_Nullable_1_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x00134B84 File Offset: 0x00132D84
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 101896, RefRangeEnd = 101907, XrefRangeStart = 101878, XrefRangeEnd = 101896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifySystemChanged(int senderIndex, PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, Il2CppSystem.Object additionalInformation = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref senderIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orderChangeContext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalInformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_NotifySystemChanged_Public_Void_Int32_OrderChangeContext_OrderBase_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x00134BF8 File Offset: 0x00132DF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101911, RefRangeEnd = 101912, XrefRangeStart = 101907, XrefRangeEnd = 101911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOrderBaseAdd(GuestsManager.OrderBase orderBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_OnOrderBaseAdd_Public_Void_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x00134C3C File Offset: 0x00132E3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 101946, RefRangeEnd = 101950, XrefRangeStart = 101912, XrefRangeEnd = 101946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnThrowDeliverStart(GuestsManager.OrderBase targetOrder, Il2CppReferenceArray<Sellable> additionalSellableData, int senderIndex = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalSellableData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref senderIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_OnThrowDeliverStart_Public_Void_OrderBase_Il2CppReferenceArray_1_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00134CA0 File Offset: 0x00132EA0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 101957, RefRangeEnd = 101966, XrefRangeStart = 101950, XrefRangeEnd = 101957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOrderBaseStatusUpdate(GuestsManager.OrderBase orderBase, PartnerManager.OrderChangeContext updateContext, int senderIndex = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateContext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref senderIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_OnOrderBaseStatusUpdate_Public_Void_OrderBase_OrderChangeContext_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00134D00 File Offset: 0x00132F00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 101967, RefRangeEnd = 101972, XrefRangeStart = 101966, XrefRangeEnd = 101967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInventoryRefresh(int senderIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref senderIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_OnInventoryRefresh_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x00134D40 File Offset: 0x00132F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101973, RefRangeEnd = 101974, XrefRangeStart = 101972, XrefRangeEnd = 101973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPlayerRefreshInventory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_OnPlayerRefreshInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00134D74 File Offset: 0x00132F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101975, RefRangeEnd = 101976, XrefRangeStart = 101974, XrefRangeEnd = 101975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPlayerStartCooker(CookController cookController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_OnPlayerStartCooker_Public_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x00134DB8 File Offset: 0x00132FB8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 101977, RefRangeEnd = 101985, XrefRangeStart = 101976, XrefRangeEnd = 101977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCookerAvailabilityUpdate(int senderIndex = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref senderIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_OnCookerAvailabilityUpdate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00134DF8 File Offset: 0x00132FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101985, XrefRangeEnd = 101986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPartnerWakeUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_OnPartnerWakeUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x00134E2C File Offset: 0x0013302C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101986, XrefRangeEnd = 101987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPartnerStunBegin(PartnerBase target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_OnPartnerStunBegin_Public_Void_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x00134E70 File Offset: 0x00133070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101987, XrefRangeEnd = 101988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPartnerStunEnd(PartnerBase target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_OnPartnerStunEnd_Public_Void_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x00134EB4 File Offset: 0x001330B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101988, XrefRangeEnd = 102038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00134EF0 File Offset: 0x001330F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102042, RefRangeEnd = 102043, XrefRangeStart = 102038, XrefRangeEnd = 102042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBossPartner(PartnerBossInfo partnerBossInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBossInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_AddBossPartner_Public_Void_PartnerBossInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x00134F34 File Offset: 0x00133134
		// (set) Token: 0x06002D23 RID: 11555 RVA: 0x00134F70 File Offset: 0x00133170
		public unsafe int BossGetScore
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73521, RefRangeEnd = 73522, XrefRangeStart = 73521, XrefRangeEnd = 73522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_get_BossGetScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102043, XrefRangeEnd = 102047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_set_BossGetScore_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06002D24 RID: 11556 RVA: 0x00134FB0 File Offset: 0x001331B0
		// (set) Token: 0x06002D25 RID: 11557 RVA: 0x00134FEC File Offset: 0x001331EC
		public unsafe int BossGetCombo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_get_BossGetCombo_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_set_BossGetCombo_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x0013502C File Offset: 0x0013322C
		[CallerCount(0)]
		public unsafe void AddBossCombo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_AddBossCombo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x00135060 File Offset: 0x00133260
		[CallerCount(0)]
		public unsafe void SetBossCombo(int combo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref combo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_SetBossCombo_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x001350A0 File Offset: 0x001332A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 102051, RefRangeEnd = 102055, XrefRangeStart = 102047, XrefRangeEnd = 102051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryAddBossOccupiedDeskCode(int deskCode, int partnerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partnerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_TryAddBossOccupiedDeskCode_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x001350EC File Offset: 0x001332EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 102058, RefRangeEnd = 102062, XrefRangeStart = 102055, XrefRangeEnd = 102058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseBossOccupiedDeskCode(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_ReleaseBossOccupiedDeskCode_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x0013512C File Offset: 0x0013332C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102067, RefRangeEnd = 102068, XrefRangeStart = 102062, XrefRangeEnd = 102067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryAddPlayerOccupiedDeskCode(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_TryAddPlayerOccupiedDeskCode_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x0013516C File Offset: 0x0013336C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102071, RefRangeEnd = 102072, XrefRangeStart = 102068, XrefRangeEnd = 102071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleasePlayerOccupiedDeskCode(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_ReleasePlayerOccupiedDeskCode_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x001351AC File Offset: 0x001333AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 102076, RefRangeEnd = 102080, XrefRangeStart = 102072, XrefRangeEnd = 102076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckThisDeskHaveOccupiedByBoss(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_CheckThisDeskHaveOccupiedByBoss_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x001351F8 File Offset: 0x001333F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 102084, RefRangeEnd = 102087, XrefRangeStart = 102080, XrefRangeEnd = 102084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckThisDeskHaveOccupiedByPlayer(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_CheckThisDeskHaveOccupiedByPlayer_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x00135244 File Offset: 0x00133444
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102090, RefRangeEnd = 102092, XrefRangeStart = 102087, XrefRangeEnd = 102090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckThisDeskHaveOccupiedByAnyone(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_CheckThisDeskHaveOccupiedByAnyone_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00135290 File Offset: 0x00133490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102092, XrefRangeEnd = 102094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetBossTipRate(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_GetBossTipRate_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x001352DC File Offset: 0x001334DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102094, XrefRangeEnd = 102098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBossGetScore(int fund)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fund;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_AddBossGetScore_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x0013531C File Offset: 0x0013351C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102103, RefRangeEnd = 102104, XrefRangeStart = 102098, XrefRangeEnd = 102103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeBossPartnerModeManager(Action<int> setBossScoreCallback, Action<int, int> partnerOccupyDeskCallback, Action<int> partnerReleaseDeskCallback, Action<int> playerOccupyDeskCallback, Action<int> playerReleaseDeskCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(setBossScoreCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerOccupyDeskCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerReleaseDeskCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerOccupyDeskCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerReleaseDeskCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_InitializeBossPartnerModeManager_Public_Void_Action_1_Int32_Action_2_Int32_Int32_Action_1_Int32_Action_1_Int32_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x001353A8 File Offset: 0x001335A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102104, XrefRangeEnd = 102135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x001353DC File Offset: 0x001335DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102135, XrefRangeEnd = 102177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x00135418 File Offset: 0x00133618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102177, XrefRangeEnd = 102258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x00135454 File Offset: 0x00133654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102258, XrefRangeEnd = 102262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerBase _get_AllStunedPartners_b__19_1(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr__get_AllStunedPartners_b__19_1_Private_PartnerBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr3) : null;
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x001354A0 File Offset: 0x001336A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102262, XrefRangeEnd = 102265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetOrderedAwaitingOrder_b__33_1(GuestsManager.OrderBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_1_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x001354F0 File Offset: 0x001336F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102265, XrefRangeEnd = 102268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetOrderedAwaitingOrder_b__33_3(GuestsManager.OrderBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_3_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x00135540 File Offset: 0x00133740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetOrderedAwaitingOrder_b__33_6(GuestsManager.OrderBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_6_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00135590 File Offset: 0x00133790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102268, XrefRangeEnd = 102274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddStunedStatus_b__46_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr__AddStunedStatus_b__46_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x001355D0 File Offset: 0x001337D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102274, XrefRangeEnd = 102280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ResetStunedStatus_b__47_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.NativeMethodInfoPtr__ResetStunedStatus_b__47_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x0001A18B File Offset: 0x0001838B
		public PartnerManager.GetCookerInfo TryGetCookerForOrder(Sellable food, out CookController cookController, out Recipe targetRecipe, params int[] canUsedCooker)
		{
			return this.TryGetCookerForOrder(food, out cookController, out targetRecipe, new Il2CppStructArray<int>(canUsedCooker));
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x0001A19D File Offset: 0x0001839D
		public PartnerManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x00135610 File Offset: 0x00133810
		// (set) Token: 0x06002D3E RID: 11582 RVA: 0x0001A1A6 File Offset: 0x000183A6
		public unsafe static int ANONYMOUS_SYSTEM_CHANGE_SENDER_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PartnerManager.NativeFieldInfoPtr_ANONYMOUS_SYSTEM_CHANGE_SENDER_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerManager.NativeFieldInfoPtr_ANONYMOUS_SYSTEM_CHANGE_SENDER_INDEX, (void*)(&value));
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x0013562C File Offset: 0x0013382C
		// (set) Token: 0x06002D40 RID: 11584 RVA: 0x0001A1B4 File Offset: 0x000183B4
		public unsafe Action afterInitialize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_afterInitialize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_afterInitialize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x0013565C File Offset: 0x0013385C
		// (set) Token: 0x06002D42 RID: 11586 RVA: 0x0001A1D3 File Offset: 0x000183D3
		public unsafe HashSet<GuestsManager.OrderBase> allOrders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_allOrders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GuestsManager.OrderBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_allOrders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x0013568C File Offset: 0x0013388C
		// (set) Token: 0x06002D44 RID: 11588 RVA: 0x0001A1F2 File Offset: 0x000183F2
		public unsafe HashSet<CookController> availableCookers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_availableCookers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<CookController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_availableCookers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x001356BC File Offset: 0x001338BC
		// (set) Token: 0x06002D46 RID: 11590 RVA: 0x0001A211 File Offset: 0x00018411
		public unsafe Dictionary<PartnerBase.PartnerType, HashSet<GuestsManager.OrderBase>> occupiedOrderData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_occupiedOrderData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PartnerBase.PartnerType, HashSet<GuestsManager.OrderBase>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_occupiedOrderData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06002D47 RID: 11591 RVA: 0x001356EC File Offset: 0x001338EC
		// (set) Token: 0x06002D48 RID: 11592 RVA: 0x0001A230 File Offset: 0x00018430
		public unsafe HashSet<int> allOrdersCookHasFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_allOrdersCookHasFinish);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_allOrdersCookHasFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06002D49 RID: 11593 RVA: 0x0013571C File Offset: 0x0013391C
		// (set) Token: 0x06002D4A RID: 11594 RVA: 0x0001A24F File Offset: 0x0001844F
		public unsafe Dictionary<PartnerInfoBase, Dictionary<string, Coroutine>> partnerInfoCoroutines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_partnerInfoCoroutines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PartnerInfoBase, Dictionary<string, Coroutine>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_partnerInfoCoroutines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06002D4B RID: 11595 RVA: 0x0013574C File Offset: 0x0013394C
		// (set) Token: 0x06002D4C RID: 11596 RVA: 0x0001A26E File Offset: 0x0001846E
		public unsafe Dictionary<PartnerBase.PartnerType, HashSet<PartnerBase>> partners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_partners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PartnerBase.PartnerType, HashSet<PartnerBase>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_partners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06002D4D RID: 11597 RVA: 0x0013577C File Offset: 0x0013397C
		// (set) Token: 0x06002D4E RID: 11598 RVA: 0x0001A28D File Offset: 0x0001848D
		public unsafe Dictionary<int, PartnerBase> partnersByIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_partnersByIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PartnerBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_partnersByIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x001357AC File Offset: 0x001339AC
		// (set) Token: 0x06002D50 RID: 11600 RVA: 0x0001A2AC File Offset: 0x000184AC
		public unsafe List<List<int>> stunedPartners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_stunedPartners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<List<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_stunedPartners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x001357DC File Offset: 0x001339DC
		// (set) Token: 0x06002D52 RID: 11602 RVA: 0x0001A2CB File Offset: 0x000184CB
		public unsafe Action<int, Nullable<PartnerBase.PartnerType>, Sellable.SellableType, string> setPartnerOrderDataCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_setPartnerOrderDataCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, Nullable<PartnerBase.PartnerType>, Sellable.SellableType, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_setPartnerOrderDataCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x0013580C File Offset: 0x00133A0C
		// (set) Token: 0x06002D54 RID: 11604 RVA: 0x0001A2EA File Offset: 0x000184EA
		public unsafe Action<Nullable<int>, string, int> setPartnerStateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_setPartnerStateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Nullable<int>, string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_setPartnerStateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06002D55 RID: 11605 RVA: 0x0013583C File Offset: 0x00133A3C
		// (set) Token: 0x06002D56 RID: 11606 RVA: 0x0001A309 File Offset: 0x00018509
		public unsafe bool _HaveInitialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr__HaveInitialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr__HaveInitialized_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06002D57 RID: 11607 RVA: 0x00135864 File Offset: 0x00133A64
		// (set) Token: 0x06002D58 RID: 11608 RVA: 0x0001A324 File Offset: 0x00018524
		public unsafe bool _CanAddAvailableCooker_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr__CanAddAvailableCooker_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr__CanAddAvailableCooker_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x0013588C File Offset: 0x00133A8C
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x0001A33F File Offset: 0x0001853F
		public unsafe int bossGetScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_bossGetScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_bossGetScore)) = value;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06002D5B RID: 11611 RVA: 0x001358B4 File Offset: 0x00133AB4
		// (set) Token: 0x06002D5C RID: 11612 RVA: 0x0001A35A File Offset: 0x0001855A
		public unsafe Dictionary<int, int> BossOccupiedDeskCodeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_BossOccupiedDeskCodeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_BossOccupiedDeskCodeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x001358E4 File Offset: 0x00133AE4
		// (set) Token: 0x06002D5E RID: 11614 RVA: 0x0001A379 File Offset: 0x00018579
		public unsafe List<int> PlayerOccupiedDeskCodeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_PlayerOccupiedDeskCodeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_PlayerOccupiedDeskCodeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x00135914 File Offset: 0x00133B14
		// (set) Token: 0x06002D60 RID: 11616 RVA: 0x0001A398 File Offset: 0x00018598
		public unsafe Dictionary<int, PartnerBossInfo> BossPartnerMatching
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_BossPartnerMatching);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, PartnerBossInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_BossPartnerMatching), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x00135944 File Offset: 0x00133B44
		// (set) Token: 0x06002D62 RID: 11618 RVA: 0x0001A3B7 File Offset: 0x000185B7
		public unsafe Func<string> GetLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_GetLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_GetLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x00135974 File Offset: 0x00133B74
		// (set) Token: 0x06002D64 RID: 11620 RVA: 0x0001A3D6 File Offset: 0x000185D6
		public unsafe Action<int> setBossScoreCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_setBossScoreCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_setBossScoreCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x001359A4 File Offset: 0x00133BA4
		// (set) Token: 0x06002D66 RID: 11622 RVA: 0x0001A3F5 File Offset: 0x000185F5
		public unsafe Action<int, int> partnerOccupyDeskCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_partnerOccupyDeskCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_partnerOccupyDeskCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06002D67 RID: 11623 RVA: 0x001359D4 File Offset: 0x00133BD4
		// (set) Token: 0x06002D68 RID: 11624 RVA: 0x0001A414 File Offset: 0x00018614
		public unsafe Action<int> partnerReleaseDeskCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_partnerReleaseDeskCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_partnerReleaseDeskCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x00135A04 File Offset: 0x00133C04
		// (set) Token: 0x06002D6A RID: 11626 RVA: 0x0001A433 File Offset: 0x00018633
		public unsafe Action<int> playerOccupyDeskCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_playerOccupyDeskCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_playerOccupyDeskCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06002D6B RID: 11627 RVA: 0x00135A34 File Offset: 0x00133C34
		// (set) Token: 0x06002D6C RID: 11628 RVA: 0x0001A452 File Offset: 0x00018652
		public unsafe Action<int> playerReleaseDeskCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_playerReleaseDeskCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr_playerReleaseDeskCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06002D6D RID: 11629 RVA: 0x00135A64 File Offset: 0x00133C64
		// (set) Token: 0x06002D6E RID: 11630 RVA: 0x0001A471 File Offset: 0x00018671
		public unsafe int _BossGetCombo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr__BossGetCombo_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.NativeFieldInfoPtr__BossGetCombo_k__BackingField)) = value;
			}
		}

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeFieldInfoPtr_ANONYMOUS_SYSTEM_CHANGE_SENDER_INDEX;

		// Token: 0x04001DC7 RID: 7623
		private static readonly IntPtr NativeFieldInfoPtr_afterInitialize;

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeFieldInfoPtr_allOrders;

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeFieldInfoPtr_availableCookers;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeFieldInfoPtr_occupiedOrderData;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeFieldInfoPtr_allOrdersCookHasFinish;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeFieldInfoPtr_partnerInfoCoroutines;

		// Token: 0x04001DCD RID: 7629
		private static readonly IntPtr NativeFieldInfoPtr_partners;

		// Token: 0x04001DCE RID: 7630
		private static readonly IntPtr NativeFieldInfoPtr_partnersByIndex;

		// Token: 0x04001DCF RID: 7631
		private static readonly IntPtr NativeFieldInfoPtr_stunedPartners;

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeFieldInfoPtr_setPartnerOrderDataCallback;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeFieldInfoPtr_setPartnerStateCallback;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeFieldInfoPtr__HaveInitialized_k__BackingField;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeFieldInfoPtr__CanAddAvailableCooker_k__BackingField;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeFieldInfoPtr_bossGetScore;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeFieldInfoPtr_BossOccupiedDeskCodeList;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeFieldInfoPtr_PlayerOccupiedDeskCodeList;

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeFieldInfoPtr_BossPartnerMatching;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeFieldInfoPtr_GetLabel;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeFieldInfoPtr_setBossScoreCallback;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeFieldInfoPtr_partnerOccupyDeskCallback;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeFieldInfoPtr_partnerReleaseDeskCallback;

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeFieldInfoPtr_playerOccupyDeskCallback;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeFieldInfoPtr_playerReleaseDeskCallback;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeFieldInfoPtr__BossGetCombo_k__BackingField;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeMethodInfoPtr_get_AllProcessingOrders_Public_get_IEnumerable_1_OrderBase_0;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeMethodInfoPtr_get_AllAvailableCookerCanUseByPartner_Public_get_IEnumerable_1_CookController_0;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeMethodInfoPtr_get_AllStunedPartners_Public_get_IEnumerable_1_PartnerBase_0;

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeMethodInfoPtr_get_AllOrdersCookHasFinish_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeMethodInfoPtr_get_HaveInitialized_Public_get_Boolean_0;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeMethodInfoPtr_set_HaveInitialized_Private_set_Void_Boolean_0;

		// Token: 0x04001DE5 RID: 7653
		private static readonly IntPtr NativeMethodInfoPtr_GetAllPartnersAndType_Public_IEnumerable_1_KeyValuePair_2_PartnerType_IEnumerable_1_PartnerBase_0;

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeMethodInfoPtr_GetAllPartners_Public_IEnumerable_1_PartnerBase_0;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetPartner_Public_Boolean_Int32_byref_PartnerBase_0;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetPartnerByIndex_Public_Boolean_Int32_byref_PartnerBase_0;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeMethodInfoPtr_MarkForOccupied_Public_Void_PartnerType_OrderBase_0;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeMethodInfoPtr_HasOccupied_Public_Boolean_PartnerType_OrderBase_0;

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseFromOccupied_Public_Void_PartnerType_OrderBase_0;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderedAwaitingOrder_Public_Boolean_PartnerType_byref_IEnumerable_1_OrderBase_Boolean_Single_0;

		// Token: 0x04001DED RID: 7661
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCookerForOrder_Public_GetCookerInfo_Sellable_byref_CookController_byref_Recipe_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001DEE RID: 7662
		private static readonly IntPtr NativeMethodInfoPtr_get_CanAddAvailableCooker_Private_get_Boolean_0;

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeMethodInfoPtr_set_CanAddAvailableCooker_Public_set_Void_Boolean_0;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeMethodInfoPtr_AddToAvailableCooker_Public_Void_CookController_0;

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromAvailableCooker_Public_Void_CookController_0;

		// Token: 0x04001DF2 RID: 7666
		private static readonly IntPtr NativeMethodInfoPtr_ResetAvailableCooker_Public_Void_0;

		// Token: 0x04001DF3 RID: 7667
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetDeskOrderHasMadeByCook_Public_Void_Int32_0;

		// Token: 0x04001DF4 RID: 7668
		private static readonly IntPtr NativeMethodInfoPtr_GetAllPartnersTransform_Public_IEnumerable_1_Transform_0;

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeMethodInfoPtr_GetBufferCount_Public_Int32_Int32_SellableType_0;

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeMethodInfoPtr_CheckStunedStatus_Public_Boolean_Int32_0;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeMethodInfoPtr_AddStunedStatus_Public_Void_List_1_Int32_0;

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeMethodInfoPtr_ResetStunedStatus_Public_Void_List_1_Int32_0;

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_IEnumerable_1_ValueTuple_2_Int32_PartnerBase_IEnumerable_1_CookController_0;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeMethodInfoPtr_StopPartnerCoroutines_Public_Void_0;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeMethodInfoPtr_StartPartnerCoroutine_Public_Void_PartnerInfoBase_String_IEnumerator_0;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeMethodInfoPtr_TryStopPartnerCoroutine_Public_Void_PartnerInfoBase_String_0;

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeMethodInfoPtr_SetPartnerOrderData_Public_Void_Int32_Nullable_1_PartnerType_SellableType_String_OrderBase_0;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStatus_Public_Void_Nullable_1_Int32_String_Int32_0;

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeMethodInfoPtr_NotifySystemChanged_Public_Void_Int32_OrderChangeContext_OrderBase_Object_0;

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeMethodInfoPtr_OnOrderBaseAdd_Public_Void_OrderBase_0;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeMethodInfoPtr_OnThrowDeliverStart_Public_Void_OrderBase_Il2CppReferenceArray_1_Sellable_Int32_0;

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeMethodInfoPtr_OnOrderBaseStatusUpdate_Public_Void_OrderBase_OrderChangeContext_Int32_0;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeMethodInfoPtr_OnInventoryRefresh_Public_Void_Int32_0;

		// Token: 0x04001E05 RID: 7685
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerRefreshInventory_Public_Void_0;

		// Token: 0x04001E06 RID: 7686
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerStartCooker_Public_Void_CookController_0;

		// Token: 0x04001E07 RID: 7687
		private static readonly IntPtr NativeMethodInfoPtr_OnCookerAvailabilityUpdate_Public_Void_Int32_0;

		// Token: 0x04001E08 RID: 7688
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerWakeUp_Public_Void_0;

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerStunBegin_Public_Void_PartnerBase_0;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerStunEnd_Public_Void_PartnerBase_0;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeMethodInfoPtr_AddBossPartner_Public_Void_PartnerBossInfo_0;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeMethodInfoPtr_get_BossGetScore_Public_get_Int32_0;

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeMethodInfoPtr_set_BossGetScore_Public_set_Void_Int32_0;

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeMethodInfoPtr_get_BossGetCombo_Public_get_Int32_0;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeMethodInfoPtr_set_BossGetCombo_Public_set_Void_Int32_0;

		// Token: 0x04001E11 RID: 7697
		private static readonly IntPtr NativeMethodInfoPtr_AddBossCombo_Public_Void_0;

		// Token: 0x04001E12 RID: 7698
		private static readonly IntPtr NativeMethodInfoPtr_SetBossCombo_Public_Void_Int32_0;

		// Token: 0x04001E13 RID: 7699
		private static readonly IntPtr NativeMethodInfoPtr_TryAddBossOccupiedDeskCode_Public_Void_Int32_Int32_0;

		// Token: 0x04001E14 RID: 7700
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseBossOccupiedDeskCode_Public_Void_Int32_0;

		// Token: 0x04001E15 RID: 7701
		private static readonly IntPtr NativeMethodInfoPtr_TryAddPlayerOccupiedDeskCode_Public_Void_Int32_0;

		// Token: 0x04001E16 RID: 7702
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePlayerOccupiedDeskCode_Public_Void_Int32_0;

		// Token: 0x04001E17 RID: 7703
		private static readonly IntPtr NativeMethodInfoPtr_CheckThisDeskHaveOccupiedByBoss_Public_Boolean_Int32_0;

		// Token: 0x04001E18 RID: 7704
		private static readonly IntPtr NativeMethodInfoPtr_CheckThisDeskHaveOccupiedByPlayer_Public_Boolean_Int32_0;

		// Token: 0x04001E19 RID: 7705
		private static readonly IntPtr NativeMethodInfoPtr_CheckThisDeskHaveOccupiedByAnyone_Public_Boolean_Int32_0;

		// Token: 0x04001E1A RID: 7706
		private static readonly IntPtr NativeMethodInfoPtr_GetBossTipRate_Public_Single_Int32_0;

		// Token: 0x04001E1B RID: 7707
		private static readonly IntPtr NativeMethodInfoPtr_AddBossGetScore_Public_Void_Int32_0;

		// Token: 0x04001E1C RID: 7708
		private static readonly IntPtr NativeMethodInfoPtr_InitializeBossPartnerModeManager_Public_Void_Action_1_Int32_Action_2_Int32_Int32_Action_1_Int32_Action_1_Int32_Action_1_Int32_0;

		// Token: 0x04001E1D RID: 7709
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x04001E1E RID: 7710
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001E1F RID: 7711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E20 RID: 7712
		private static readonly IntPtr NativeMethodInfoPtr__get_AllStunedPartners_b__19_1_Private_PartnerBase_Int32_0;

		// Token: 0x04001E21 RID: 7713
		private static readonly IntPtr NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_1_Private_Boolean_OrderBase_0;

		// Token: 0x04001E22 RID: 7714
		private static readonly IntPtr NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_3_Private_Boolean_OrderBase_0;

		// Token: 0x04001E23 RID: 7715
		private static readonly IntPtr NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_6_Private_Boolean_OrderBase_0;

		// Token: 0x04001E24 RID: 7716
		private static readonly IntPtr NativeMethodInfoPtr__AddStunedStatus_b__46_0_Private_Void_Int32_0;

		// Token: 0x04001E25 RID: 7717
		private static readonly IntPtr NativeMethodInfoPtr__ResetStunedStatus_b__47_0_Private_Void_Int32_0;

		// Token: 0x020007FE RID: 2046
		public enum GetCookerInfo
		{
			// Token: 0x04006CB2 RID: 27826
			AllCookerBusy,
			// Token: 0x04006CB3 RID: 27827
			NoMatchingRecipes,
			// Token: 0x04006CB4 RID: 27828
			NoMatchingCooker,
			// Token: 0x04006CB5 RID: 27829
			Succeed
		}

		// Token: 0x020007FF RID: 2047
		public enum OrderChangeContext
		{
			// Token: 0x04006CB7 RID: 27831
			Null,
			// Token: 0x04006CB8 RID: 27832
			OrderAdd,
			// Token: 0x04006CB9 RID: 27833
			OrderRemove,
			// Token: 0x04006CBA RID: 27834
			FoodDelivered,
			// Token: 0x04006CBB RID: 27835
			BeverageDelivered,
			// Token: 0x04006CBC RID: 27836
			InventoryUpdate,
			// Token: 0x04006CBD RID: 27837
			CookerStart,
			// Token: 0x04006CBE RID: 27838
			OnCookerAvailabilityUpdate,
			// Token: 0x04006CBF RID: 27839
			WakeUp,
			// Token: 0x04006CC0 RID: 27840
			PlayerOccupyDesk,
			// Token: 0x04006CC1 RID: 27841
			PartnerGetStuned,
			// Token: 0x04006CC2 RID: 27842
			PartnerStunEnd
		}

		// Token: 0x02000800 RID: 2048
		[ObfuscatedName("NightScene.PartnerUtility.PartnerManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600A844 RID: 43076 RVA: 0x002BB3FC File Offset: 0x002B95FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr);
				PartnerManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9");
				PartnerManager.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__17_0");
				PartnerManager.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__19_0");
				PartnerManager.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__27_0");
				PartnerManager.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__33_0");
				PartnerManager.__c.NativeFieldInfoPtr___9__33_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__33_2");
				PartnerManager.__c.NativeFieldInfoPtr___9__33_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__33_4");
				PartnerManager.__c.NativeFieldInfoPtr___9__33_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__33_5");
				PartnerManager.__c.NativeFieldInfoPtr___9__33_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__33_7");
				PartnerManager.__c.NativeFieldInfoPtr___9__33_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__33_8");
				PartnerManager.__c.NativeFieldInfoPtr___9__43_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__43_1");
				PartnerManager.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__43_0");
				PartnerManager.__c.NativeFieldInfoPtr___9__44_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__44_1");
				PartnerManager.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__45_0");
				PartnerManager.__c.NativeFieldInfoPtr___9__48_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__48_0");
				PartnerManager.__c.NativeFieldInfoPtr___9__48_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__48_1");
				PartnerManager.__c.NativeFieldInfoPtr___9__48_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__48_2");
				PartnerManager.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__49_0");
				PartnerManager.__c.NativeFieldInfoPtr___9__57_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__57_0");
				PartnerManager.__c.NativeFieldInfoPtr___9__57_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__57_1");
				PartnerManager.__c.NativeFieldInfoPtr___9__66_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__66_1");
				PartnerManager.__c.NativeFieldInfoPtr___9__66_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, "<>9__66_0");
				PartnerManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671227);
				PartnerManager.__c.NativeMethodInfoPtr__get_AllAvailableCookerCanUseByPartner_b__17_0_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671228);
				PartnerManager.__c.NativeMethodInfoPtr__get_AllStunedPartners_b__19_0_Internal_IEnumerable_1_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671229);
				PartnerManager.__c.NativeMethodInfoPtr__GetAllPartners_b__27_0_Internal_IEnumerable_1_PartnerBase_KeyValuePair_2_PartnerType_HashSet_1_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671230);
				PartnerManager.__c.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_0_Internal_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671231);
				PartnerManager.__c.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_2_Internal_Int32_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671232);
				PartnerManager.__c.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_4_Internal_OrderType_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671233);
				PartnerManager.__c.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_5_Internal_Int32_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671234);
				PartnerManager.__c.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_7_Internal_OrderType_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671235);
				PartnerManager.__c.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_8_Internal_Int32_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671236);
				PartnerManager.__c.NativeMethodInfoPtr__GetAllPartnersTransform_b__43_0_Internal_IEnumerable_1_Transform_KeyValuePair_2_PartnerType_HashSet_1_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671237);
				PartnerManager.__c.NativeMethodInfoPtr__GetAllPartnersTransform_b__43_1_Internal_Transform_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671238);
				PartnerManager.__c.NativeMethodInfoPtr__GetBufferCount_b__44_1_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671239);
				PartnerManager.__c.NativeMethodInfoPtr__CheckStunedStatus_b__45_0_Internal_IEnumerable_1_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671240);
				PartnerManager.__c.NativeMethodInfoPtr__Initialize_b__48_0_Internal_Boolean_ValueTuple_4_Int32_PartnerBase_Int32_Nullable_1_CompanionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671241);
				PartnerManager.__c.NativeMethodInfoPtr__Initialize_b__48_1_Internal_ValueTuple_3_Int32_Int32_PartnerBase_ValueTuple_4_Int32_PartnerBase_Int32_Nullable_1_CompanionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671242);
				PartnerManager.__c.NativeMethodInfoPtr__Initialize_b__48_2_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671243);
				PartnerManager.__c.NativeMethodInfoPtr__Dispose_b__49_0_Internal_IEnumerable_1_PartnerBase_KeyValuePair_2_PartnerType_HashSet_1_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671244);
				PartnerManager.__c.NativeMethodInfoPtr__OnThrowDeliverStart_b__57_0_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671245);
				PartnerManager.__c.NativeMethodInfoPtr__OnThrowDeliverStart_b__57_1_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671246);
				PartnerManager.__c.NativeMethodInfoPtr__OnInstanceDestroyed_b__66_0_Internal_Void_HashSet_1_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671247);
				PartnerManager.__c.NativeMethodInfoPtr__OnInstanceDestroyed_b__66_1_Internal_Void_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr, 100671248);
			}

			// Token: 0x0600A845 RID: 43077 RVA: 0x002BB798 File Offset: 0x002B9998
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A846 RID: 43078 RVA: 0x002BB7D4 File Offset: 0x002B99D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100749, XrefRangeEnd = 100750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_AllAvailableCookerCanUseByPartner_b__17_0(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__get_AllAvailableCookerCanUseByPartner_b__17_0_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A847 RID: 43079 RVA: 0x002BB824 File Offset: 0x002B9A24
			[CallerCount(0)]
			public unsafe IEnumerable<int> _get_AllStunedPartners_b__19_0(List<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__get_AllStunedPartners_b__19_0_Internal_IEnumerable_1_Int32_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600A848 RID: 43080 RVA: 0x002BB874 File Offset: 0x002B9A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100750, XrefRangeEnd = 100751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<PartnerBase> _GetAllPartners_b__27_0(KeyValuePair<PartnerBase.PartnerType, HashSet<PartnerBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__GetAllPartners_b__27_0_Internal_IEnumerable_1_PartnerBase_KeyValuePair_2_PartnerType_HashSet_1_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PartnerBase>>(intPtr3) : null;
			}

			// Token: 0x0600A849 RID: 43081 RVA: 0x002BB8CC File Offset: 0x002B9ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100751, XrefRangeEnd = 100756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetOrderedAwaitingOrder_b__33_0(GuestsManager.OrderBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_0_Internal_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A84A RID: 43082 RVA: 0x002BB91C File Offset: 0x002B9B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100756, XrefRangeEnd = 100760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetOrderedAwaitingOrder_b__33_2(GuestsManager.OrderBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_2_Internal_Int32_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A84B RID: 43083 RVA: 0x002BB96C File Offset: 0x002B9B6C
			[CallerCount(0)]
			public unsafe GuestsManager.OrderBase.OrderType _GetOrderedAwaitingOrder_b__33_4(GuestsManager.OrderBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_4_Internal_OrderType_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A84C RID: 43084 RVA: 0x002BB9BC File Offset: 0x002B9BBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100760, XrefRangeEnd = 100764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetOrderedAwaitingOrder_b__33_5(GuestsManager.OrderBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_5_Internal_Int32_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A84D RID: 43085 RVA: 0x002BBA0C File Offset: 0x002B9C0C
			[CallerCount(0)]
			public unsafe GuestsManager.OrderBase.OrderType _GetOrderedAwaitingOrder_b__33_7(GuestsManager.OrderBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_7_Internal_OrderType_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A84E RID: 43086 RVA: 0x002BBA5C File Offset: 0x002B9C5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100764, XrefRangeEnd = 100768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetOrderedAwaitingOrder_b__33_8(GuestsManager.OrderBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_8_Internal_Int32_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A84F RID: 43087 RVA: 0x002BBAAC File Offset: 0x002B9CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100768, XrefRangeEnd = 100788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Transform> _GetAllPartnersTransform_b__43_0(KeyValuePair<PartnerBase.PartnerType, HashSet<PartnerBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__GetAllPartnersTransform_b__43_0_Internal_IEnumerable_1_Transform_KeyValuePair_2_PartnerType_HashSet_1_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Transform>>(intPtr3) : null;
			}

			// Token: 0x0600A850 RID: 43088 RVA: 0x002BBB04 File Offset: 0x002B9D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100788, XrefRangeEnd = 100790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Transform _GetAllPartnersTransform_b__43_1(PartnerBase y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__GetAllPartnersTransform_b__43_1_Internal_Transform_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}

			// Token: 0x0600A851 RID: 43089 RVA: 0x002BBB54 File Offset: 0x002B9D54
			[CallerCount(0)]
			public unsafe int _GetBufferCount_b__44_1(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__GetBufferCount_b__44_1_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A852 RID: 43090 RVA: 0x002BBBAC File Offset: 0x002B9DAC
			[CallerCount(0)]
			public unsafe IEnumerable<int> _CheckStunedStatus_b__45_0(List<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__CheckStunedStatus_b__45_0_Internal_IEnumerable_1_Int32_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600A853 RID: 43091 RVA: 0x002BBBFC File Offset: 0x002B9DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100790, XrefRangeEnd = 100791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialize_b__48_0(ValueTuple<int, PartnerBase, int, Nullable<PartnerInfoBase.CompanionProperty>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__Initialize_b__48_0_Internal_Boolean_ValueTuple_4_Int32_PartnerBase_Int32_Nullable_1_CompanionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A854 RID: 43092 RVA: 0x002BBC50 File Offset: 0x002B9E50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100791, XrefRangeEnd = 100794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, int, PartnerBase> _Initialize_b__48_1(ValueTuple<int, PartnerBase, int, Nullable<PartnerInfoBase.CompanionProperty>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__Initialize_b__48_1_Internal_ValueTuple_3_Int32_Int32_PartnerBase_ValueTuple_4_Int32_PartnerBase_Int32_Nullable_1_CompanionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, int, PartnerBase>(pointer);
			}

			// Token: 0x0600A855 RID: 43093 RVA: 0x002BBCA0 File Offset: 0x002B9EA0
			[CallerCount(0)]
			public unsafe bool _Initialize_b__48_2(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__Initialize_b__48_2_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A856 RID: 43094 RVA: 0x002BBCF0 File Offset: 0x002B9EF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100794, XrefRangeEnd = 100795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<PartnerBase> _Dispose_b__49_0(KeyValuePair<PartnerBase.PartnerType, HashSet<PartnerBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__Dispose_b__49_0_Internal_IEnumerable_1_PartnerBase_KeyValuePair_2_PartnerType_HashSet_1_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PartnerBase>>(intPtr3) : null;
			}

			// Token: 0x0600A857 RID: 43095 RVA: 0x002BBD48 File Offset: 0x002B9F48
			[CallerCount(0)]
			public unsafe bool _OnThrowDeliverStart_b__57_0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__OnThrowDeliverStart_b__57_0_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A858 RID: 43096 RVA: 0x002BBD98 File Offset: 0x002B9F98
			[CallerCount(0)]
			public unsafe bool _OnThrowDeliverStart_b__57_1(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__OnThrowDeliverStart_b__57_1_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A859 RID: 43097 RVA: 0x002BBDE8 File Offset: 0x002B9FE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100795, XrefRangeEnd = 100814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInstanceDestroyed_b__66_0(HashSet<PartnerBase> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__OnInstanceDestroyed_b__66_0_Internal_Void_HashSet_1_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A85A RID: 43098 RVA: 0x002BBE2C File Offset: 0x002BA02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100814, XrefRangeEnd = 100815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInstanceDestroyed_b__66_1(PartnerBase yx)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(yx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c.NativeMethodInfoPtr__OnInstanceDestroyed_b__66_1_Internal_Void_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A85B RID: 43099 RVA: 0x0005AE6A File Offset: 0x0005906A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700374E RID: 14158
			// (get) Token: 0x0600A85C RID: 43100 RVA: 0x002BBE70 File Offset: 0x002BA070
			// (set) Token: 0x0600A85D RID: 43101 RVA: 0x0005AE73 File Offset: 0x00059073
			public unsafe static PartnerManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700374F RID: 14159
			// (get) Token: 0x0600A85E RID: 43102 RVA: 0x002BBE98 File Offset: 0x002BA098
			// (set) Token: 0x0600A85F RID: 43103 RVA: 0x0005AE85 File Offset: 0x00059085
			public unsafe static Func<CookController, bool> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CookController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003750 RID: 14160
			// (get) Token: 0x0600A860 RID: 43104 RVA: 0x002BBEC0 File Offset: 0x002BA0C0
			// (set) Token: 0x0600A861 RID: 43105 RVA: 0x0005AE97 File Offset: 0x00059097
			public unsafe static Func<List<int>, IEnumerable<int>> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003751 RID: 14161
			// (get) Token: 0x0600A862 RID: 43106 RVA: 0x002BBEE8 File Offset: 0x002BA0E8
			// (set) Token: 0x0600A863 RID: 43107 RVA: 0x0005AEA9 File Offset: 0x000590A9
			public unsafe static Func<KeyValuePair<PartnerBase.PartnerType, HashSet<PartnerBase>>, IEnumerable<PartnerBase>> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<PartnerBase.PartnerType, HashSet<PartnerBase>>, IEnumerable<PartnerBase>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003752 RID: 14162
			// (get) Token: 0x0600A864 RID: 43108 RVA: 0x002BBF10 File Offset: 0x002BA110
			// (set) Token: 0x0600A865 RID: 43109 RVA: 0x0005AEBB File Offset: 0x000590BB
			public unsafe static Func<GuestsManager.OrderBase, bool> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestsManager.OrderBase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003753 RID: 14163
			// (get) Token: 0x0600A866 RID: 43110 RVA: 0x002BBF38 File Offset: 0x002BA138
			// (set) Token: 0x0600A867 RID: 43111 RVA: 0x0005AECD File Offset: 0x000590CD
			public unsafe static Func<GuestsManager.OrderBase, int> __9__33_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__33_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestsManager.OrderBase, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__33_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003754 RID: 14164
			// (get) Token: 0x0600A868 RID: 43112 RVA: 0x002BBF60 File Offset: 0x002BA160
			// (set) Token: 0x0600A869 RID: 43113 RVA: 0x0005AEDF File Offset: 0x000590DF
			public unsafe static Func<GuestsManager.OrderBase, GuestsManager.OrderBase.OrderType> __9__33_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__33_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestsManager.OrderBase, GuestsManager.OrderBase.OrderType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__33_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003755 RID: 14165
			// (get) Token: 0x0600A86A RID: 43114 RVA: 0x002BBF88 File Offset: 0x002BA188
			// (set) Token: 0x0600A86B RID: 43115 RVA: 0x0005AEF1 File Offset: 0x000590F1
			public unsafe static Func<GuestsManager.OrderBase, int> __9__33_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__33_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestsManager.OrderBase, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__33_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003756 RID: 14166
			// (get) Token: 0x0600A86C RID: 43116 RVA: 0x002BBFB0 File Offset: 0x002BA1B0
			// (set) Token: 0x0600A86D RID: 43117 RVA: 0x0005AF03 File Offset: 0x00059103
			public unsafe static Func<GuestsManager.OrderBase, GuestsManager.OrderBase.OrderType> __9__33_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__33_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestsManager.OrderBase, GuestsManager.OrderBase.OrderType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__33_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003757 RID: 14167
			// (get) Token: 0x0600A86E RID: 43118 RVA: 0x002BBFD8 File Offset: 0x002BA1D8
			// (set) Token: 0x0600A86F RID: 43119 RVA: 0x0005AF15 File Offset: 0x00059115
			public unsafe static Func<GuestsManager.OrderBase, int> __9__33_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__33_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestsManager.OrderBase, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__33_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003758 RID: 14168
			// (get) Token: 0x0600A870 RID: 43120 RVA: 0x002BC000 File Offset: 0x002BA200
			// (set) Token: 0x0600A871 RID: 43121 RVA: 0x0005AF27 File Offset: 0x00059127
			public unsafe static Func<PartnerBase, Transform> __9__43_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__43_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerBase, Transform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__43_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003759 RID: 14169
			// (get) Token: 0x0600A872 RID: 43122 RVA: 0x002BC028 File Offset: 0x002BA228
			// (set) Token: 0x0600A873 RID: 43123 RVA: 0x0005AF39 File Offset: 0x00059139
			public unsafe static Func<KeyValuePair<PartnerBase.PartnerType, HashSet<PartnerBase>>, IEnumerable<Transform>> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<PartnerBase.PartnerType, HashSet<PartnerBase>>, IEnumerable<Transform>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700375A RID: 14170
			// (get) Token: 0x0600A874 RID: 43124 RVA: 0x002BC050 File Offset: 0x002BA250
			// (set) Token: 0x0600A875 RID: 43125 RVA: 0x0005AF4B File Offset: 0x0005914B
			public unsafe static Func<int, int, int> __9__44_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__44_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__44_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700375B RID: 14171
			// (get) Token: 0x0600A876 RID: 43126 RVA: 0x002BC078 File Offset: 0x002BA278
			// (set) Token: 0x0600A877 RID: 43127 RVA: 0x0005AF5D File Offset: 0x0005915D
			public unsafe static Func<List<int>, IEnumerable<int>> __9__45_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700375C RID: 14172
			// (get) Token: 0x0600A878 RID: 43128 RVA: 0x002BC0A0 File Offset: 0x002BA2A0
			// (set) Token: 0x0600A879 RID: 43129 RVA: 0x0005AF6F File Offset: 0x0005916F
			public unsafe static Func<ValueTuple<int, PartnerBase, int, Nullable<PartnerInfoBase.CompanionProperty>>, bool> __9__48_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__48_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, PartnerBase, int, Nullable<PartnerInfoBase.CompanionProperty>>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__48_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700375D RID: 14173
			// (get) Token: 0x0600A87A RID: 43130 RVA: 0x002BC0C8 File Offset: 0x002BA2C8
			// (set) Token: 0x0600A87B RID: 43131 RVA: 0x0005AF81 File Offset: 0x00059181
			public unsafe static Func<ValueTuple<int, PartnerBase, int, Nullable<PartnerInfoBase.CompanionProperty>>, ValueTuple<int, int, PartnerBase>> __9__48_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__48_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, PartnerBase, int, Nullable<PartnerInfoBase.CompanionProperty>>, ValueTuple<int, int, PartnerBase>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__48_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700375E RID: 14174
			// (get) Token: 0x0600A87C RID: 43132 RVA: 0x002BC0F0 File Offset: 0x002BA2F0
			// (set) Token: 0x0600A87D RID: 43133 RVA: 0x0005AF93 File Offset: 0x00059193
			public unsafe static Func<CookController, bool> __9__48_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__48_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CookController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__48_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700375F RID: 14175
			// (get) Token: 0x0600A87E RID: 43134 RVA: 0x002BC118 File Offset: 0x002BA318
			// (set) Token: 0x0600A87F RID: 43135 RVA: 0x0005AFA5 File Offset: 0x000591A5
			public unsafe static Func<KeyValuePair<PartnerBase.PartnerType, HashSet<PartnerBase>>, IEnumerable<PartnerBase>> __9__49_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<PartnerBase.PartnerType, HashSet<PartnerBase>>, IEnumerable<PartnerBase>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__49_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003760 RID: 14176
			// (get) Token: 0x0600A880 RID: 43136 RVA: 0x002BC140 File Offset: 0x002BA340
			// (set) Token: 0x0600A881 RID: 43137 RVA: 0x0005AFB7 File Offset: 0x000591B7
			public unsafe static Func<Sellable, bool> __9__57_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__57_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__57_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003761 RID: 14177
			// (get) Token: 0x0600A882 RID: 43138 RVA: 0x002BC168 File Offset: 0x002BA368
			// (set) Token: 0x0600A883 RID: 43139 RVA: 0x0005AFC9 File Offset: 0x000591C9
			public unsafe static Func<Sellable, bool> __9__57_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__57_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__57_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003762 RID: 14178
			// (get) Token: 0x0600A884 RID: 43140 RVA: 0x002BC190 File Offset: 0x002BA390
			// (set) Token: 0x0600A885 RID: 43141 RVA: 0x0005AFDB File Offset: 0x000591DB
			public unsafe static Action<PartnerBase> __9__66_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__66_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PartnerBase>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__66_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003763 RID: 14179
			// (get) Token: 0x0600A886 RID: 43142 RVA: 0x002BC1B8 File Offset: 0x002BA3B8
			// (set) Token: 0x0600A887 RID: 43143 RVA: 0x0005AFED File Offset: 0x000591ED
			public unsafe static Action<HashSet<PartnerBase>> __9__66_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerManager.__c.NativeFieldInfoPtr___9__66_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<HashSet<PartnerBase>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerManager.__c.NativeFieldInfoPtr___9__66_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006CC3 RID: 27843
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006CC4 RID: 27844
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04006CC5 RID: 27845
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04006CC6 RID: 27846
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x04006CC7 RID: 27847
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x04006CC8 RID: 27848
			private static readonly IntPtr NativeFieldInfoPtr___9__33_2;

			// Token: 0x04006CC9 RID: 27849
			private static readonly IntPtr NativeFieldInfoPtr___9__33_4;

			// Token: 0x04006CCA RID: 27850
			private static readonly IntPtr NativeFieldInfoPtr___9__33_5;

			// Token: 0x04006CCB RID: 27851
			private static readonly IntPtr NativeFieldInfoPtr___9__33_7;

			// Token: 0x04006CCC RID: 27852
			private static readonly IntPtr NativeFieldInfoPtr___9__33_8;

			// Token: 0x04006CCD RID: 27853
			private static readonly IntPtr NativeFieldInfoPtr___9__43_1;

			// Token: 0x04006CCE RID: 27854
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x04006CCF RID: 27855
			private static readonly IntPtr NativeFieldInfoPtr___9__44_1;

			// Token: 0x04006CD0 RID: 27856
			private static readonly IntPtr NativeFieldInfoPtr___9__45_0;

			// Token: 0x04006CD1 RID: 27857
			private static readonly IntPtr NativeFieldInfoPtr___9__48_0;

			// Token: 0x04006CD2 RID: 27858
			private static readonly IntPtr NativeFieldInfoPtr___9__48_1;

			// Token: 0x04006CD3 RID: 27859
			private static readonly IntPtr NativeFieldInfoPtr___9__48_2;

			// Token: 0x04006CD4 RID: 27860
			private static readonly IntPtr NativeFieldInfoPtr___9__49_0;

			// Token: 0x04006CD5 RID: 27861
			private static readonly IntPtr NativeFieldInfoPtr___9__57_0;

			// Token: 0x04006CD6 RID: 27862
			private static readonly IntPtr NativeFieldInfoPtr___9__57_1;

			// Token: 0x04006CD7 RID: 27863
			private static readonly IntPtr NativeFieldInfoPtr___9__66_1;

			// Token: 0x04006CD8 RID: 27864
			private static readonly IntPtr NativeFieldInfoPtr___9__66_0;

			// Token: 0x04006CD9 RID: 27865
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006CDA RID: 27866
			private static readonly IntPtr NativeMethodInfoPtr__get_AllAvailableCookerCanUseByPartner_b__17_0_Internal_Boolean_CookController_0;

			// Token: 0x04006CDB RID: 27867
			private static readonly IntPtr NativeMethodInfoPtr__get_AllStunedPartners_b__19_0_Internal_IEnumerable_1_Int32_List_1_Int32_0;

			// Token: 0x04006CDC RID: 27868
			private static readonly IntPtr NativeMethodInfoPtr__GetAllPartners_b__27_0_Internal_IEnumerable_1_PartnerBase_KeyValuePair_2_PartnerType_HashSet_1_PartnerBase_0;

			// Token: 0x04006CDD RID: 27869
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_0_Internal_Boolean_OrderBase_0;

			// Token: 0x04006CDE RID: 27870
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_2_Internal_Int32_OrderBase_0;

			// Token: 0x04006CDF RID: 27871
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_4_Internal_OrderType_OrderBase_0;

			// Token: 0x04006CE0 RID: 27872
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_5_Internal_Int32_OrderBase_0;

			// Token: 0x04006CE1 RID: 27873
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_7_Internal_OrderType_OrderBase_0;

			// Token: 0x04006CE2 RID: 27874
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedAwaitingOrder_b__33_8_Internal_Int32_OrderBase_0;

			// Token: 0x04006CE3 RID: 27875
			private static readonly IntPtr NativeMethodInfoPtr__GetAllPartnersTransform_b__43_0_Internal_IEnumerable_1_Transform_KeyValuePair_2_PartnerType_HashSet_1_PartnerBase_0;

			// Token: 0x04006CE4 RID: 27876
			private static readonly IntPtr NativeMethodInfoPtr__GetAllPartnersTransform_b__43_1_Internal_Transform_PartnerBase_0;

			// Token: 0x04006CE5 RID: 27877
			private static readonly IntPtr NativeMethodInfoPtr__GetBufferCount_b__44_1_Internal_Int32_Int32_Int32_0;

			// Token: 0x04006CE6 RID: 27878
			private static readonly IntPtr NativeMethodInfoPtr__CheckStunedStatus_b__45_0_Internal_IEnumerable_1_Int32_List_1_Int32_0;

			// Token: 0x04006CE7 RID: 27879
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__48_0_Internal_Boolean_ValueTuple_4_Int32_PartnerBase_Int32_Nullable_1_CompanionProperty_0;

			// Token: 0x04006CE8 RID: 27880
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__48_1_Internal_ValueTuple_3_Int32_Int32_PartnerBase_ValueTuple_4_Int32_PartnerBase_Int32_Nullable_1_CompanionProperty_0;

			// Token: 0x04006CE9 RID: 27881
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__48_2_Internal_Boolean_CookController_0;

			// Token: 0x04006CEA RID: 27882
			private static readonly IntPtr NativeMethodInfoPtr__Dispose_b__49_0_Internal_IEnumerable_1_PartnerBase_KeyValuePair_2_PartnerType_HashSet_1_PartnerBase_0;

			// Token: 0x04006CEB RID: 27883
			private static readonly IntPtr NativeMethodInfoPtr__OnThrowDeliverStart_b__57_0_Internal_Boolean_Sellable_0;

			// Token: 0x04006CEC RID: 27884
			private static readonly IntPtr NativeMethodInfoPtr__OnThrowDeliverStart_b__57_1_Internal_Boolean_Sellable_0;

			// Token: 0x04006CED RID: 27885
			private static readonly IntPtr NativeMethodInfoPtr__OnInstanceDestroyed_b__66_0_Internal_Void_HashSet_1_PartnerBase_0;

			// Token: 0x04006CEE RID: 27886
			private static readonly IntPtr NativeMethodInfoPtr__OnInstanceDestroyed_b__66_1_Internal_Void_PartnerBase_0;
		}

		// Token: 0x02000801 RID: 2049
		[ObfuscatedName("NightScene.PartnerUtility.PartnerManager+<GetAllPartnersAndType>d__26")]
		public sealed class _GetAllPartnersAndType_d__26 : Il2CppSystem.Object
		{
			// Token: 0x0600A888 RID: 43144 RVA: 0x002BC1E0 File Offset: 0x002BA3E0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAllPartnersAndType_d__26()
			{
				Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "<GetAllPartnersAndType>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr);
				PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, "<>1__state");
				PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, "<>2__current");
				PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, "<>l__initialThreadId");
				PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, "<>4__this");
				PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, "<>7__wrap1");
				PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, 100671249);
				PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, 100671250);
				PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, 100671251);
				PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, 100671252);
				PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_PartnerType_IEnumerable_1_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, 100671253);
				PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, 100671254);
				PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, 100671255);
				PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_PartnerType_IEnumerable_1_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, 100671256);
				PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr, 100671257);
			}

			// Token: 0x0600A889 RID: 43145 RVA: 0x002BC324 File Offset: 0x002BA524
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 78341, RefRangeEnd = 78342, XrefRangeStart = 78341, XrefRangeEnd = 78342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetAllPartnersAndType_d__26(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerManager._GetAllPartnersAndType_d__26>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A88A RID: 43146 RVA: 0x002BC36C File Offset: 0x002BA56C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100815, XrefRangeEnd = 100820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A88B RID: 43147 RVA: 0x002BC3A0 File Offset: 0x002BA5A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100820, XrefRangeEnd = 100841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A88C RID: 43148 RVA: 0x002BC3DC File Offset: 0x002BA5DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100841, XrefRangeEnd = 100844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003769 RID: 14185
			// (get) Token: 0x0600A88D RID: 43149 RVA: 0x002BC410 File Offset: 0x002BA610
			public unsafe KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>> prop_KeyValuePair_2_PartnerType_IEnumerable_1_PartnerBase_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_PartnerType_IEnumerable_1_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>>(pointer);
				}
			}

			// Token: 0x0600A88E RID: 43150 RVA: 0x002BC448 File Offset: 0x002BA648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100844, XrefRangeEnd = 100850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700376A RID: 14186
			// (get) Token: 0x0600A88F RID: 43151 RVA: 0x002BC47C File Offset: 0x002BA67C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100850, XrefRangeEnd = 100853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A890 RID: 43152 RVA: 0x002BC4BC File Offset: 0x002BA6BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100853, XrefRangeEnd = 100855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_PartnerType_IEnumerable_1_PartnerBase_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_PartnerType_IEnumerable_1_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>>>>(intPtr3) : null;
			}

			// Token: 0x0600A891 RID: 43153 RVA: 0x002BC4FC File Offset: 0x002BA6FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager._GetAllPartnersAndType_d__26.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A892 RID: 43154 RVA: 0x0005AFFF File Offset: 0x000591FF
			public _GetAllPartnersAndType_d__26(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003764 RID: 14180
			// (get) Token: 0x0600A893 RID: 43155 RVA: 0x002BC53C File Offset: 0x002BA73C
			// (set) Token: 0x0600A894 RID: 43156 RVA: 0x0005B008 File Offset: 0x00059208
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003765 RID: 14181
			// (get) Token: 0x0600A895 RID: 43157 RVA: 0x002BC564 File Offset: 0x002BA764
			// (set) Token: 0x0600A896 RID: 43158 RVA: 0x0005B023 File Offset: 0x00059223
			public KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003766 RID: 14182
			// (get) Token: 0x0600A897 RID: 43159 RVA: 0x002BC594 File Offset: 0x002BA794
			// (set) Token: 0x0600A898 RID: 43160 RVA: 0x0005B051 File Offset: 0x00059251
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003767 RID: 14183
			// (get) Token: 0x0600A899 RID: 43161 RVA: 0x002BC5BC File Offset: 0x002BA7BC
			// (set) Token: 0x0600A89A RID: 43162 RVA: 0x0005B06C File Offset: 0x0005926C
			public unsafe PartnerManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003768 RID: 14184
			// (get) Token: 0x0600A89B RID: 43163 RVA: 0x002BC5EC File Offset: 0x002BA7EC
			// (set) Token: 0x0600A89C RID: 43164 RVA: 0x0005B08B File Offset: 0x0005928B
			public Dictionary<PartnerBase.PartnerType, HashSet<PartnerBase>>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<PartnerBase.PartnerType, HashSet<PartnerBase>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<PartnerBase.PartnerType, HashSet<PartnerBase>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager._GetAllPartnersAndType_d__26.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<PartnerBase.PartnerType, HashSet<PartnerBase>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006CEF RID: 27887
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006CF0 RID: 27888
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006CF1 RID: 27889
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006CF2 RID: 27890
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006CF3 RID: 27891
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04006CF4 RID: 27892
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006CF5 RID: 27893
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006CF6 RID: 27894
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006CF7 RID: 27895
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04006CF8 RID: 27896
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_PartnerType_IEnumerable_1_PartnerBase_0;

			// Token: 0x04006CF9 RID: 27897
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006CFA RID: 27898
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006CFB RID: 27899
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_PartnerType_IEnumerable_1_PartnerBase_0;

			// Token: 0x04006CFC RID: 27900
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000802 RID: 2050
		[ObfuscatedName("NightScene.PartnerUtility.PartnerManager+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A89D RID: 43165 RVA: 0x002BC61C File Offset: 0x002BA81C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<PartnerManager.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass28_0>.NativeClassPtr);
				PartnerManager.__c__DisplayClass28_0.NativeFieldInfoPtr_partnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass28_0>.NativeClassPtr, "partnerId");
				PartnerManager.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass28_0>.NativeClassPtr, 100671258);
				PartnerManager.__c__DisplayClass28_0.NativeMethodInfoPtr__GetTargetPartner_b__0_Internal_Boolean_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass28_0>.NativeClassPtr, 100671259);
			}

			// Token: 0x0600A89E RID: 43166 RVA: 0x002BC684 File Offset: 0x002BA884
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A89F RID: 43167 RVA: 0x002BC6C0 File Offset: 0x002BA8C0
			[CallerCount(0)]
			public unsafe bool _GetTargetPartner_b__0(PartnerBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass28_0.NativeMethodInfoPtr__GetTargetPartner_b__0_Internal_Boolean_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A8A0 RID: 43168 RVA: 0x0005B0B9 File Offset: 0x000592B9
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700376B RID: 14187
			// (get) Token: 0x0600A8A1 RID: 43169 RVA: 0x002BC710 File Offset: 0x002BA910
			// (set) Token: 0x0600A8A2 RID: 43170 RVA: 0x0005B0C2 File Offset: 0x000592C2
			public unsafe int partnerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass28_0.NativeFieldInfoPtr_partnerId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass28_0.NativeFieldInfoPtr_partnerId)) = value;
				}
			}

			// Token: 0x04006CFD RID: 27901
			private static readonly IntPtr NativeFieldInfoPtr_partnerId;

			// Token: 0x04006CFE RID: 27902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006CFF RID: 27903
			private static readonly IntPtr NativeMethodInfoPtr__GetTargetPartner_b__0_Internal_Boolean_PartnerBase_0;
		}

		// Token: 0x02000803 RID: 2051
		[ObfuscatedName("NightScene.PartnerUtility.PartnerManager+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A8A3 RID: 43171 RVA: 0x002BC738 File Offset: 0x002BA938
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_0>.NativeClassPtr);
				PartnerManager.__c__DisplayClass34_0.NativeFieldInfoPtr_canUsedCooker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_0>.NativeClassPtr, "canUsedCooker");
				PartnerManager.__c__DisplayClass34_0.NativeFieldInfoPtr_allAvailableCookerCanUseByPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_0>.NativeClassPtr, "allAvailableCookerCanUseByPartner");
				PartnerManager.__c__DisplayClass34_0.NativeFieldInfoPtr_selectedRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_0>.NativeClassPtr, "selectedRecipe");
				PartnerManager.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_0>.NativeClassPtr, 100671260);
				PartnerManager.__c__DisplayClass34_0.NativeMethodInfoPtr__TryGetCookerForOrder_b__0_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_0>.NativeClassPtr, 100671261);
				PartnerManager.__c__DisplayClass34_0.NativeMethodInfoPtr__TryGetCookerForOrder_b__1_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_0>.NativeClassPtr, 100671262);
				PartnerManager.__c__DisplayClass34_0.NativeMethodInfoPtr__TryGetCookerForOrder_b__2_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_0>.NativeClassPtr, 100671263);
			}

			// Token: 0x0600A8A4 RID: 43172 RVA: 0x002BC7F0 File Offset: 0x002BA9F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8A5 RID: 43173 RVA: 0x002BC82C File Offset: 0x002BAA2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100855, XrefRangeEnd = 100859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetCookerForOrder_b__0(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass34_0.NativeMethodInfoPtr__TryGetCookerForOrder_b__0_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A8A6 RID: 43174 RVA: 0x002BC87C File Offset: 0x002BAA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100859, XrefRangeEnd = 100874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetCookerForOrder_b__1(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass34_0.NativeMethodInfoPtr__TryGetCookerForOrder_b__1_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A8A7 RID: 43175 RVA: 0x002BC8CC File Offset: 0x002BAACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100874, XrefRangeEnd = 100879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetCookerForOrder_b__2(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass34_0.NativeMethodInfoPtr__TryGetCookerForOrder_b__2_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A8A8 RID: 43176 RVA: 0x0005B0DD File Offset: 0x000592DD
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700376C RID: 14188
			// (get) Token: 0x0600A8A9 RID: 43177 RVA: 0x002BC91C File Offset: 0x002BAB1C
			// (set) Token: 0x0600A8AA RID: 43178 RVA: 0x0005B0E6 File Offset: 0x000592E6
			public unsafe Il2CppStructArray<int> canUsedCooker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass34_0.NativeFieldInfoPtr_canUsedCooker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass34_0.NativeFieldInfoPtr_canUsedCooker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700376D RID: 14189
			// (get) Token: 0x0600A8AB RID: 43179 RVA: 0x002BC94C File Offset: 0x002BAB4C
			// (set) Token: 0x0600A8AC RID: 43180 RVA: 0x0005B105 File Offset: 0x00059305
			public unsafe List<CookController> allAvailableCookerCanUseByPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass34_0.NativeFieldInfoPtr_allAvailableCookerCanUseByPartner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CookController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass34_0.NativeFieldInfoPtr_allAvailableCookerCanUseByPartner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700376E RID: 14190
			// (get) Token: 0x0600A8AD RID: 43181 RVA: 0x002BC97C File Offset: 0x002BAB7C
			// (set) Token: 0x0600A8AE RID: 43182 RVA: 0x0005B124 File Offset: 0x00059324
			public unsafe Recipe selectedRecipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass34_0.NativeFieldInfoPtr_selectedRecipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass34_0.NativeFieldInfoPtr_selectedRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D00 RID: 27904
			private static readonly IntPtr NativeFieldInfoPtr_canUsedCooker;

			// Token: 0x04006D01 RID: 27905
			private static readonly IntPtr NativeFieldInfoPtr_allAvailableCookerCanUseByPartner;

			// Token: 0x04006D02 RID: 27906
			private static readonly IntPtr NativeFieldInfoPtr_selectedRecipe;

			// Token: 0x04006D03 RID: 27907
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006D04 RID: 27908
			private static readonly IntPtr NativeMethodInfoPtr__TryGetCookerForOrder_b__0_Internal_Boolean_CookController_0;

			// Token: 0x04006D05 RID: 27909
			private static readonly IntPtr NativeMethodInfoPtr__TryGetCookerForOrder_b__1_Internal_Boolean_Recipe_0;

			// Token: 0x04006D06 RID: 27910
			private static readonly IntPtr NativeMethodInfoPtr__TryGetCookerForOrder_b__2_Internal_Boolean_CookController_0;
		}

		// Token: 0x02000804 RID: 2052
		[ObfuscatedName("NightScene.PartnerUtility.PartnerManager+<>c__DisplayClass34_1")]
		public sealed class __c__DisplayClass34_1 : Il2CppSystem.Object
		{
			// Token: 0x0600A8AF RID: 43183 RVA: 0x002BC9AC File Offset: 0x002BABAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_1()
			{
				Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "<>c__DisplayClass34_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_1>.NativeClassPtr);
				PartnerManager.__c__DisplayClass34_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_1>.NativeClassPtr, "x");
				PartnerManager.__c__DisplayClass34_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_1>.NativeClassPtr, 100671264);
				PartnerManager.__c__DisplayClass34_1.NativeMethodInfoPtr__TryGetCookerForOrder_b__3_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_1>.NativeClassPtr, 100671265);
			}

			// Token: 0x0600A8B0 RID: 43184 RVA: 0x002BCA14 File Offset: 0x002BAC14
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass34_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass34_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8B1 RID: 43185 RVA: 0x002BCA50 File Offset: 0x002BAC50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100879, XrefRangeEnd = 100884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetCookerForOrder_b__3(CookController y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass34_1.NativeMethodInfoPtr__TryGetCookerForOrder_b__3_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A8B2 RID: 43186 RVA: 0x0005B143 File Offset: 0x00059343
			public __c__DisplayClass34_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700376F RID: 14191
			// (get) Token: 0x0600A8B3 RID: 43187 RVA: 0x002BCAA0 File Offset: 0x002BACA0
			// (set) Token: 0x0600A8B4 RID: 43188 RVA: 0x0005B14C File Offset: 0x0005934C
			public unsafe Recipe x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass34_1.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass34_1.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D07 RID: 27911
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04006D08 RID: 27912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006D09 RID: 27913
			private static readonly IntPtr NativeMethodInfoPtr__TryGetCookerForOrder_b__3_Internal_Boolean_CookController_0;
		}

		// Token: 0x02000805 RID: 2053
		[ObfuscatedName("NightScene.PartnerUtility.PartnerManager+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A8B5 RID: 43189 RVA: 0x002BCAD0 File Offset: 0x002BACD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<PartnerManager.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass44_0>.NativeClassPtr);
				PartnerManager.__c__DisplayClass44_0.NativeFieldInfoPtr_sellableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass44_0>.NativeClassPtr, "sellableType");
				PartnerManager.__c__DisplayClass44_0.NativeFieldInfoPtr_targetSellableId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass44_0>.NativeClassPtr, "targetSellableId");
				PartnerManager.__c__DisplayClass44_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass44_0>.NativeClassPtr, "<>9__2");
				PartnerManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass44_0>.NativeClassPtr, 100671266);
				PartnerManager.__c__DisplayClass44_0.NativeMethodInfoPtr__GetBufferCount_b__0_Internal_Int32_KeyValuePair_2_PartnerType_HashSet_1_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass44_0>.NativeClassPtr, 100671267);
				PartnerManager.__c__DisplayClass44_0.NativeMethodInfoPtr__GetBufferCount_b__2_Internal_Boolean_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass44_0>.NativeClassPtr, 100671268);
			}

			// Token: 0x0600A8B6 RID: 43190 RVA: 0x002BCB74 File Offset: 0x002BAD74
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8B7 RID: 43191 RVA: 0x002BCBB0 File Offset: 0x002BADB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100884, XrefRangeEnd = 100896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetBufferCount_b__0(KeyValuePair<PartnerBase.PartnerType, HashSet<PartnerBase>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass44_0.NativeMethodInfoPtr__GetBufferCount_b__0_Internal_Int32_KeyValuePair_2_PartnerType_HashSet_1_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A8B8 RID: 43192 RVA: 0x002BCC04 File Offset: 0x002BAE04
			[CallerCount(0)]
			public unsafe bool _GetBufferCount_b__2(PartnerBase y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass44_0.NativeMethodInfoPtr__GetBufferCount_b__2_Internal_Boolean_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A8B9 RID: 43193 RVA: 0x0005B16B File Offset: 0x0005936B
			public __c__DisplayClass44_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003770 RID: 14192
			// (get) Token: 0x0600A8BA RID: 43194 RVA: 0x002BCC54 File Offset: 0x002BAE54
			// (set) Token: 0x0600A8BB RID: 43195 RVA: 0x0005B174 File Offset: 0x00059374
			public unsafe Sellable.SellableType sellableType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass44_0.NativeFieldInfoPtr_sellableType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass44_0.NativeFieldInfoPtr_sellableType)) = value;
				}
			}

			// Token: 0x17003771 RID: 14193
			// (get) Token: 0x0600A8BC RID: 43196 RVA: 0x002BCC7C File Offset: 0x002BAE7C
			// (set) Token: 0x0600A8BD RID: 43197 RVA: 0x0005B18F File Offset: 0x0005938F
			public unsafe int targetSellableId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass44_0.NativeFieldInfoPtr_targetSellableId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass44_0.NativeFieldInfoPtr_targetSellableId)) = value;
				}
			}

			// Token: 0x17003772 RID: 14194
			// (get) Token: 0x0600A8BE RID: 43198 RVA: 0x002BCCA4 File Offset: 0x002BAEA4
			// (set) Token: 0x0600A8BF RID: 43199 RVA: 0x0005B1AA File Offset: 0x000593AA
			public unsafe Func<PartnerBase, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass44_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerBase, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass44_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D0A RID: 27914
			private static readonly IntPtr NativeFieldInfoPtr_sellableType;

			// Token: 0x04006D0B RID: 27915
			private static readonly IntPtr NativeFieldInfoPtr_targetSellableId;

			// Token: 0x04006D0C RID: 27916
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04006D0D RID: 27917
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006D0E RID: 27918
			private static readonly IntPtr NativeMethodInfoPtr__GetBufferCount_b__0_Internal_Int32_KeyValuePair_2_PartnerType_HashSet_1_PartnerBase_0;

			// Token: 0x04006D0F RID: 27919
			private static readonly IntPtr NativeMethodInfoPtr__GetBufferCount_b__2_Internal_Boolean_PartnerBase_0;
		}

		// Token: 0x02000806 RID: 2054
		[ObfuscatedName("NightScene.PartnerUtility.PartnerManager+<>c__DisplayClass55_0")]
		public sealed class __c__DisplayClass55_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A8C0 RID: 43200 RVA: 0x002BCCD4 File Offset: 0x002BAED4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<PartnerManager.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerManager>.NativeClassPtr, "<>c__DisplayClass55_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass55_0>.NativeClassPtr);
				PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr_senderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass55_0>.NativeClassPtr, "senderIndex");
				PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr_orderChangeContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass55_0>.NativeClassPtr, "orderChangeContext");
				PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr_targetOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass55_0>.NativeClassPtr, "targetOrder");
				PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr_additionalInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass55_0>.NativeClassPtr, "additionalInformation");
				PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass55_0>.NativeClassPtr, "<>9__1");
				PartnerManager.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass55_0>.NativeClassPtr, 100671269);
				PartnerManager.__c__DisplayClass55_0.NativeMethodInfoPtr__NotifySystemChanged_b__0_Internal_Void_HashSet_1_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass55_0>.NativeClassPtr, 100671270);
				PartnerManager.__c__DisplayClass55_0.NativeMethodInfoPtr__NotifySystemChanged_b__1_Internal_Void_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass55_0>.NativeClassPtr, 100671271);
			}

			// Token: 0x0600A8C1 RID: 43201 RVA: 0x002BCDA0 File Offset: 0x002BAFA0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerManager.__c__DisplayClass55_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8C2 RID: 43202 RVA: 0x002BCDDC File Offset: 0x002BAFDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100896, XrefRangeEnd = 100907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifySystemChanged_b__0(HashSet<PartnerBase> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass55_0.NativeMethodInfoPtr__NotifySystemChanged_b__0_Internal_Void_HashSet_1_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8C3 RID: 43203 RVA: 0x002BCE20 File Offset: 0x002BB020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100907, XrefRangeEnd = 100908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _NotifySystemChanged_b__1(PartnerBase y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerManager.__c__DisplayClass55_0.NativeMethodInfoPtr__NotifySystemChanged_b__1_Internal_Void_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8C4 RID: 43204 RVA: 0x0005B1C9 File Offset: 0x000593C9
			public __c__DisplayClass55_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003773 RID: 14195
			// (get) Token: 0x0600A8C5 RID: 43205 RVA: 0x002BCE64 File Offset: 0x002BB064
			// (set) Token: 0x0600A8C6 RID: 43206 RVA: 0x0005B1D2 File Offset: 0x000593D2
			public unsafe int senderIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr_senderIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr_senderIndex)) = value;
				}
			}

			// Token: 0x17003774 RID: 14196
			// (get) Token: 0x0600A8C7 RID: 43207 RVA: 0x002BCE8C File Offset: 0x002BB08C
			// (set) Token: 0x0600A8C8 RID: 43208 RVA: 0x0005B1ED File Offset: 0x000593ED
			public unsafe PartnerManager.OrderChangeContext orderChangeContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr_orderChangeContext);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr_orderChangeContext)) = value;
				}
			}

			// Token: 0x17003775 RID: 14197
			// (get) Token: 0x0600A8C9 RID: 43209 RVA: 0x002BCEB4 File Offset: 0x002BB0B4
			// (set) Token: 0x0600A8CA RID: 43210 RVA: 0x0005B208 File Offset: 0x00059408
			public unsafe GuestsManager.OrderBase targetOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr_targetOrder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr_targetOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003776 RID: 14198
			// (get) Token: 0x0600A8CB RID: 43211 RVA: 0x002BCEE4 File Offset: 0x002BB0E4
			// (set) Token: 0x0600A8CC RID: 43212 RVA: 0x0005B227 File Offset: 0x00059427
			public unsafe Il2CppSystem.Object additionalInformation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr_additionalInformation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr_additionalInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003777 RID: 14199
			// (get) Token: 0x0600A8CD RID: 43213 RVA: 0x002BCF14 File Offset: 0x002BB114
			// (set) Token: 0x0600A8CE RID: 43214 RVA: 0x0005B246 File Offset: 0x00059446
			public unsafe Action<PartnerBase> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PartnerBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerManager.__c__DisplayClass55_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D10 RID: 27920
			private static readonly IntPtr NativeFieldInfoPtr_senderIndex;

			// Token: 0x04006D11 RID: 27921
			private static readonly IntPtr NativeFieldInfoPtr_orderChangeContext;

			// Token: 0x04006D12 RID: 27922
			private static readonly IntPtr NativeFieldInfoPtr_targetOrder;

			// Token: 0x04006D13 RID: 27923
			private static readonly IntPtr NativeFieldInfoPtr_additionalInformation;

			// Token: 0x04006D14 RID: 27924
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04006D15 RID: 27925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006D16 RID: 27926
			private static readonly IntPtr NativeMethodInfoPtr__NotifySystemChanged_b__0_Internal_Void_HashSet_1_PartnerBase_0;

			// Token: 0x04006D17 RID: 27927
			private static readonly IntPtr NativeMethodInfoPtr__NotifySystemChanged_b__1_Internal_Void_PartnerBase_0;
		}
	}
}
