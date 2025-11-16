using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000330 RID: 816
	public class PartnerBossBehaviour : PartnerBase
	{
		// Token: 0x0600601E RID: 24606 RVA: 0x001DEA80 File Offset: 0x001DCC80
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerBossBehaviour()
		{
			Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerBossBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr);
			PartnerBossBehaviour.NativeFieldInfoPtr_NORMAL_EVAL_TARGET_SCORE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "NORMAL_EVAL_TARGET_SCORE");
			PartnerBossBehaviour.NativeFieldInfoPtr_GOOD_EVAL_TARGET_SCORE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "GOOD_EVAL_TARGET_SCORE");
			PartnerBossBehaviour.NativeFieldInfoPtr_EXGOOD_EVAL_TARGET_SCORE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "EXGOOD_EVAL_TARGET_SCORE");
			PartnerBossBehaviour.NativeFieldInfoPtr_EXTRA_COOKER_MOVEMENT_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "EXTRA_COOKER_MOVEMENT_OFFSET");
			PartnerBossBehaviour.NativeFieldInfoPtr_BevList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "BevList");
			PartnerBossBehaviour.NativeFieldInfoPtr_currentCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "currentCondition");
			PartnerBossBehaviour.NativeFieldInfoPtr_currentWorkingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "currentWorkingMode");
			PartnerBossBehaviour.NativeFieldInfoPtr_evalConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "evalConditions");
			PartnerBossBehaviour.NativeFieldInfoPtr_haveInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "haveInitialize");
			PartnerBossBehaviour.NativeFieldInfoPtr_partnerCanUseCookerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "partnerCanUseCookerId");
			PartnerBossBehaviour.NativeFieldInfoPtr_PartnerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "PartnerData");
			PartnerBossBehaviour.NativeFieldInfoPtr_privatePartnerStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "privatePartnerStorage");
			PartnerBossBehaviour.NativeFieldInfoPtr_RecipeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "RecipeList");
			PartnerBossBehaviour.NativeFieldInfoPtr_selectedRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "selectedRecipe");
			PartnerBossBehaviour.NativeFieldInfoPtr_targetBev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "targetBev");
			PartnerBossBehaviour.NativeFieldInfoPtr_targetFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "targetFood");
			PartnerBossBehaviour.NativeFieldInfoPtr_workingCorotine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "workingCorotine");
			PartnerBossBehaviour.NativeFieldInfoPtr__TargetCooker_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<TargetCooker>k__BackingField");
			PartnerBossBehaviour.NativeFieldInfoPtr_getRequestedFromInventoryCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "getRequestedFromInventoryCallback");
			PartnerBossBehaviour.NativeFieldInfoPtr_executeServeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "executeServeCallback");
			PartnerBossBehaviour.NativeFieldInfoPtr_getInventoryPositionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "getInventoryPositionCallback");
			PartnerBossBehaviour.NativeMethodInfoPtr_get_TargetCooker_Private_get_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683041);
			PartnerBossBehaviour.NativeMethodInfoPtr_set_TargetCooker_Private_set_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683042);
			PartnerBossBehaviour.NativeMethodInfoPtr_get_FocusingOrder_Private_get_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683043);
			PartnerBossBehaviour.NativeMethodInfoPtr_set_FocusingOrder_Private_set_Void_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683044);
			PartnerBossBehaviour.NativeMethodInfoPtr_get_AllAvailableCookerCanUseByPartner_Private_get_IEnumerable_1_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683045);
			PartnerBossBehaviour.NativeMethodInfoPtr_GetPartnerType_Public_Virtual_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683046);
			PartnerBossBehaviour.NativeMethodInfoPtr_DrawOnGUI_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683047);
			PartnerBossBehaviour.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683048);
			PartnerBossBehaviour.NativeMethodInfoPtr_TryAcceptOrder_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683049);
			PartnerBossBehaviour.NativeMethodInfoPtr_ResetStatus_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683050);
			PartnerBossBehaviour.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683051);
			PartnerBossBehaviour.NativeMethodInfoPtr_OnPlayIdleState_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683052);
			PartnerBossBehaviour.NativeMethodInfoPtr_OnCookIdleReceiveSystemChange_Public_Boolean_OrderChangeContext_OrderBase_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683053);
			PartnerBossBehaviour.NativeMethodInfoPtr_PlayMoveToCookerState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683054);
			PartnerBossBehaviour.NativeMethodInfoPtr_OnMoveToCookerReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683055);
			PartnerBossBehaviour.NativeMethodInfoPtr_OnMoveToCookerStateInterrupt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683056);
			PartnerBossBehaviour.NativeMethodInfoPtr_PlayCookState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683057);
			PartnerBossBehaviour.NativeMethodInfoPtr_OnCookingReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683058);
			PartnerBossBehaviour.NativeMethodInfoPtr_OnCookingStateInterrupt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683059);
			PartnerBossBehaviour.NativeMethodInfoPtr_EmployeeCookingCoroutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683060);
			PartnerBossBehaviour.NativeMethodInfoPtr_get_WaitressOrBarmaid_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683061);
			PartnerBossBehaviour.NativeMethodInfoPtr_GetTargetPosition_Private_Vector3Int_InventoryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683062);
			PartnerBossBehaviour.NativeMethodInfoPtr_PlayMoveToExtractFromInventoryState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683063);
			PartnerBossBehaviour.NativeMethodInfoPtr_PlayExtractFromInventoryState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683064);
			PartnerBossBehaviour.NativeMethodInfoPtr_EmployeeExtractFromInventoryCoroutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683065);
			PartnerBossBehaviour.NativeMethodInfoPtr_PlayMoveToDeliverState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683066);
			PartnerBossBehaviour.NativeMethodInfoPtr_PlayDeliverState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683067);
			PartnerBossBehaviour.NativeMethodInfoPtr_EmployeeDeliver_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683068);
			PartnerBossBehaviour.NativeMethodInfoPtr_PlayThrowDeliverState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683069);
			PartnerBossBehaviour.NativeMethodInfoPtr_ExecuteThrowDeliver_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683070);
			PartnerBossBehaviour.NativeMethodInfoPtr_PlayReturnToInventoryState_Protected_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683071);
			PartnerBossBehaviour.NativeMethodInfoPtr_OnPlayerOccupyADesk_Private_Boolean_OrderChangeContext_OrderBase_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683072);
			PartnerBossBehaviour.NativeMethodInfoPtr_OnPlayerOccupyCauseInterruptAndReset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683073);
			PartnerBossBehaviour.NativeMethodInfoPtr_OnPlayerOccupyCauseInterruptAndReturnToFoodStorage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683074);
			PartnerBossBehaviour.NativeMethodInfoPtr_OnPlayerOccupyCauseInterruptAndReturnToBeverageShelf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683075);
			PartnerBossBehaviour.NativeMethodInfoPtr_TryGetCooker_Private_GetCookerInfo_NormalOrder_byref_CookController_byref_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683076);
			PartnerBossBehaviour.NativeMethodInfoPtr_TryGetCooker_Private_GetCookerInfo_SpecialOrder_byref_CookController_byref_Recipe_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Boolean_EvalCondition_byref_EvalCondition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683077);
			PartnerBossBehaviour.NativeMethodInfoPtr_CheckFoodCanSatisfyGuest_Private_Boolean_Sellable_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_Boolean_Boolean_Nullable_1_EvalCondition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683078);
			PartnerBossBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683079);
			PartnerBossBehaviour.NativeMethodInfoPtr__get_AllAvailableCookerCanUseByPartner_b__25_0_Private_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683081);
			PartnerBossBehaviour.NativeMethodInfoPtr_Method_Internal_Static_String_Sellable_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683082);
			PartnerBossBehaviour.NativeMethodInfoPtr_Method_Private_Boolean_Recipe_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683083);
			PartnerBossBehaviour.NativeMethodInfoPtr__OnInitialize_b__28_8_Private_Void_CurrentWorkingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683084);
			PartnerBossBehaviour.NativeMethodInfoPtr__OnInitialize_b__28_9_Private_Void_GuestTableDisplayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683085);
			PartnerBossBehaviour.NativeMethodInfoPtr__OnInitialize_b__28_10_Private_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683086);
			PartnerBossBehaviour.NativeMethodInfoPtr__OnCookIdleReceiveSystemChange_b__34_0_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683087);
			PartnerBossBehaviour.NativeMethodInfoPtr__OnMoveToCookerReceiveSystemChange_b__36_0_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683088);
			PartnerBossBehaviour.NativeMethodInfoPtr__EmployeeDeliver_b__53_0_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683089);
			PartnerBossBehaviour.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_Coroutine_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683090);
			PartnerBossBehaviour.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_Int32_Nullable_1_EvalCondition_byref___c__DisplayClass63_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683091);
			PartnerBossBehaviour.NativeMethodInfoPtr_Method_Internal_Static_Int32_Nullable_1_EvalCondition_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683092);
			PartnerBossBehaviour.NativeMethodInfoPtr_Method_Internal_Static_Boolean_byref___c__DisplayClass63_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, 100683093);
		}

		// Token: 0x1700214D RID: 8525
		// (get) Token: 0x0600601F RID: 24607 RVA: 0x001DF064 File Offset: 0x001DD264
		// (set) Token: 0x06006020 RID: 24608 RVA: 0x001DF0A4 File Offset: 0x001DD2A4
		public unsafe CookController TargetCooker
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_get_TargetCooker_Private_get_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_set_TargetCooker_Private_set_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700214E RID: 8526
		// (get) Token: 0x06006021 RID: 24609 RVA: 0x001DF0E8 File Offset: 0x001DD2E8
		// (set) Token: 0x06006022 RID: 24610 RVA: 0x001DF128 File Offset: 0x001DD328
		public unsafe GuestsManager.OrderBase FocusingOrder
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_get_FocusingOrder_Private_get_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_set_FocusingOrder_Private_set_Void_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700214F RID: 8527
		// (get) Token: 0x06006023 RID: 24611 RVA: 0x001DF16C File Offset: 0x001DD36C
		public unsafe IEnumerable<CookController> AllAvailableCookerCanUseByPartner
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 237077, RefRangeEnd = 237080, XrefRangeStart = 237056, XrefRangeEnd = 237077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_get_AllAvailableCookerCanUseByPartner_Private_get_IEnumerable_1_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<CookController>>(intPtr3) : null;
			}
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x001DF1AC File Offset: 0x001DD3AC
		[CallerCount(0)]
		public unsafe override PartnerBase.PartnerType GetPartnerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossBehaviour.NativeMethodInfoPtr_GetPartnerType_Public_Virtual_PartnerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x001DF1F4 File Offset: 0x001DD3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237080, XrefRangeEnd = 237162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DrawOnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_DrawOnGUI_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x001DF22C File Offset: 0x001DD42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237162, XrefRangeEnd = 237408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossBehaviour.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x001DF268 File Offset: 0x001DD468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237581, RefRangeEnd = 237583, XrefRangeStart = 237408, XrefRangeEnd = 237581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAcceptOrder(GuestsManager.OrderBase targetOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_TryAcceptOrder_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x001DF2B8 File Offset: 0x001DD4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237583, XrefRangeEnd = 237603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossBehaviour.NativeMethodInfoPtr_ResetStatus_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x001DF2F4 File Offset: 0x001DD4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237603, XrefRangeEnd = 237604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossBehaviour.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x001DF330 File Offset: 0x001DD530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237604, XrefRangeEnd = 237611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayIdleState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossBehaviour.NativeMethodInfoPtr_OnPlayIdleState_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x001DF36C File Offset: 0x001DD56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237611, XrefRangeEnd = 237621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnCookIdleReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, Il2CppSystem.Object additionalInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orderChangeContext;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalInformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_OnCookIdleReceiveSystemChange_Public_Boolean_OrderChangeContext_OrderBase_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x001DF3DC File Offset: 0x001DD5DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237657, RefRangeEnd = 237658, XrefRangeStart = 237621, XrefRangeEnd = 237657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMoveToCookerState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_PlayMoveToCookerState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x001DF410 File Offset: 0x001DD610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237658, XrefRangeEnd = 237687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnMoveToCookerReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, Il2CppSystem.Object additionalInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orderChangeContext;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalInformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_OnMoveToCookerReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x001DF480 File Offset: 0x001DD680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237687, XrefRangeEnd = 237701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMoveToCookerStateInterrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_OnMoveToCookerStateInterrupt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x001DF4B4 File Offset: 0x001DD6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237701, XrefRangeEnd = 237729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCookState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_PlayCookState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006030 RID: 24624 RVA: 0x001DF4E8 File Offset: 0x001DD6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237729, XrefRangeEnd = 237757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnCookingReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, Il2CppSystem.Object additionalInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orderChangeContext;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalInformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_OnCookingReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x001DF558 File Offset: 0x001DD758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237757, XrefRangeEnd = 237779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCookingStateInterrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_OnCookingStateInterrupt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x001DF58C File Offset: 0x001DD78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237779, XrefRangeEnd = 237784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator EmployeeCookingCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_EmployeeCookingCoroutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x06006033 RID: 24627 RVA: 0x001DF5CC File Offset: 0x001DD7CC
		public unsafe bool WaitressOrBarmaid
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 237784, RefRangeEnd = 237787, XrefRangeStart = 237784, XrefRangeEnd = 237784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_get_WaitressOrBarmaid_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x001DF608 File Offset: 0x001DD808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237787, XrefRangeEnd = 237797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Int GetTargetPosition(PartnerBase.InventoryType inventoryType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inventoryType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_GetTargetPosition_Private_Vector3Int_InventoryType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x001DF654 File Offset: 0x001DD854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237830, RefRangeEnd = 237831, XrefRangeStart = 237797, XrefRangeEnd = 237830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMoveToExtractFromInventoryState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_PlayMoveToExtractFromInventoryState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x001DF688 File Offset: 0x001DD888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237831, XrefRangeEnd = 237845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayExtractFromInventoryState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_PlayExtractFromInventoryState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x001DF6BC File Offset: 0x001DD8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237845, XrefRangeEnd = 237850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator EmployeeExtractFromInventoryCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_EmployeeExtractFromInventoryCoroutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x001DF6FC File Offset: 0x001DD8FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237876, RefRangeEnd = 237877, XrefRangeStart = 237850, XrefRangeEnd = 237876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMoveToDeliverState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_PlayMoveToDeliverState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006039 RID: 24633 RVA: 0x001DF730 File Offset: 0x001DD930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237877, XrefRangeEnd = 237898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayDeliverState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_PlayDeliverState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600603A RID: 24634 RVA: 0x001DF764 File Offset: 0x001DD964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237898, XrefRangeEnd = 237903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator EmployeeDeliver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_EmployeeDeliver_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x001DF7A4 File Offset: 0x001DD9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237903, XrefRangeEnd = 237920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayThrowDeliverState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_PlayThrowDeliverState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600603C RID: 24636 RVA: 0x001DF7D8 File Offset: 0x001DD9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237920, XrefRangeEnd = 237925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExecuteThrowDeliver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_ExecuteThrowDeliver_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x001DF818 File Offset: 0x001DDA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237925, XrefRangeEnd = 237946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayReturnToInventoryState(Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossBehaviour.NativeMethodInfoPtr_PlayReturnToInventoryState_Protected_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x001DF868 File Offset: 0x001DDA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237946, XrefRangeEnd = 237956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnPlayerOccupyADesk(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, Il2CppSystem.Object additionalInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orderChangeContext;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalInformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_OnPlayerOccupyADesk_Private_Boolean_OrderChangeContext_OrderBase_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600603F RID: 24639 RVA: 0x001DF8D8 File Offset: 0x001DDAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237956, XrefRangeEnd = 237965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPlayerOccupyCauseInterruptAndReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_OnPlayerOccupyCauseInterruptAndReset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006040 RID: 24640 RVA: 0x001DF90C File Offset: 0x001DDB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237965, XrefRangeEnd = 237984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPlayerOccupyCauseInterruptAndReturnToFoodStorage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_OnPlayerOccupyCauseInterruptAndReturnToFoodStorage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006041 RID: 24641 RVA: 0x001DF940 File Offset: 0x001DDB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237984, XrefRangeEnd = 238003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPlayerOccupyCauseInterruptAndReturnToBeverageShelf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_OnPlayerOccupyCauseInterruptAndReturnToBeverageShelf_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006042 RID: 24642 RVA: 0x001DF974 File Offset: 0x001DDB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238003, XrefRangeEnd = 238008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerManager.GetCookerInfo TryGetCooker(GuestsManager.NormalOrder focusingOrder, out CookController cookController, out Recipe targetRecipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusingOrder);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_TryGetCooker_Private_GetCookerInfo_NormalOrder_byref_CookController_byref_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			cookController = ((intPtr5 == 0) ? null : new CookController(intPtr5));
			IntPtr intPtr6 = intPtr2;
			targetRecipe = ((intPtr6 == 0) ? null : new Recipe(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06006043 RID: 24643 RVA: 0x001DFA08 File Offset: 0x001DDC08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238066, RefRangeEnd = 238067, XrefRangeStart = 238008, XrefRangeEnd = 238066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerManager.GetCookerInfo TryGetCooker(GuestsManager.SpecialOrder focusingOrder, out CookController cookController, out Recipe targetRecipe, Il2CppStructArray<int> specGuestLikeTag, Il2CppStructArray<int> specGuestHateTag, int bevScore, bool haveBevSatisfy, PartnerBossInfo.EvalCondition evalCondition, out PartnerBossInfo.EvalCondition finalCondition, int maxPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusingOrder);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specGuestLikeTag);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specGuestHateTag);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bevScore;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref haveBevSatisfy;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evalCondition;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &finalCondition;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPrice;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_TryGetCooker_Private_GetCookerInfo_SpecialOrder_byref_CookController_byref_Recipe_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Boolean_EvalCondition_byref_EvalCondition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			cookController = ((intPtr5 == 0) ? null : new CookController(intPtr5));
			IntPtr intPtr6 = intPtr2;
			targetRecipe = ((intPtr6 == 0) ? null : new Recipe(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06006044 RID: 24644 RVA: 0x001DFB0C File Offset: 0x001DDD0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238100, RefRangeEnd = 238103, XrefRangeStart = 238067, XrefRangeEnd = 238100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckFoodCanSatisfyGuest(Sellable food, Il2CppStructArray<int> specGuestLikeTag, Il2CppStructArray<int> specGuestHateTag, int bevScore, int requestedFoodId, bool haveBevSatisfy, bool canCook, Nullable<PartnerBossInfo.EvalCondition> targetCondition, int remainMoney)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(food);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specGuestLikeTag);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specGuestHateTag);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bevScore;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedFoodId;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref haveBevSatisfy;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canCook;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(targetCondition));
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remainMoney;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_CheckFoodCanSatisfyGuest_Private_Boolean_Sellable_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_Boolean_Boolean_Nullable_1_EvalCondition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x001DFBDC File Offset: 0x001DDDDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238114, RefRangeEnd = 238117, XrefRangeStart = 238103, XrefRangeEnd = 238114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerBossBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x001DFC18 File Offset: 0x001DDE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238117, XrefRangeEnd = 238125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_AllAvailableCookerCanUseByPartner_b__25_0(CookController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr__get_AllAvailableCookerCanUseByPartner_b__25_0_Private_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x001DFC68 File Offset: 0x001DDE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238125, XrefRangeEnd = 238127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Method_Internal_Static_String_Sellable_PDM_0(Sellable sellable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_Method_Internal_Static_String_Sellable_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x001DFCA4 File Offset: 0x001DDEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238127, XrefRangeEnd = 238138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Method_Private_Boolean_Recipe_PDM_0(Recipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_Method_Private_Boolean_Recipe_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006049 RID: 24649 RVA: 0x001DFCF4 File Offset: 0x001DDEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238138, XrefRangeEnd = 238158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInitialize_b__28_8(PartnerBossBehaviour.CurrentWorkingMode workingMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref workingMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr__OnInitialize_b__28_8_Private_Void_CurrentWorkingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600604A RID: 24650 RVA: 0x001DFD34 File Offset: 0x001DDF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238158, XrefRangeEnd = 238171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInitialize_b__28_9(GuestTableDisplayer tableDisplayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tableDisplayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr__OnInitialize_b__28_9_Private_Void_GuestTableDisplayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x001DFD78 File Offset: 0x001DDF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238171, XrefRangeEnd = 238184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Int _OnInitialize_b__28_10()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr__OnInitialize_b__28_10_Private_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x001DFDB4 File Offset: 0x001DDFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238184, XrefRangeEnd = 238185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnCookIdleReceiveSystemChange_b__34_0(GuestsManager.OrderBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr__OnCookIdleReceiveSystemChange_b__34_0_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x001DFE04 File Offset: 0x001DE004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238185, XrefRangeEnd = 238189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnMoveToCookerReceiveSystemChange_b__36_0(GuestsManager.OrderBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr__OnMoveToCookerReceiveSystemChange_b__36_0_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x001DFE54 File Offset: 0x001DE054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238189, XrefRangeEnd = 238194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _EmployeeDeliver_b__53_0(GuestGroupController guest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr__EmployeeDeliver_b__53_0_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x001DFE98 File Offset: 0x001DE098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238200, RefRangeEnd = 238202, XrefRangeStart = 238194, XrefRangeEnd = 238200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Method_Internal_Static_IEnumerator_Coroutine_Action_0(Coroutine coroutine, Action onFinish)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coroutine);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_Coroutine_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006050 RID: 24656 RVA: 0x001DFEF0 File Offset: 0x001DE0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238202, XrefRangeEnd = 238212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_Int32_Int32_Nullable_1_EvalCondition_byref___c__DisplayClass63_0_PDM_0(int num, int target, Nullable<PartnerBossInfo.EvalCondition> evalCondition, ref PartnerBossBehaviour.__c__DisplayClass63_0 A_3)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref num;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(evalCondition));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_Int32_Nullable_1_EvalCondition_byref___c__DisplayClass63_0_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x001DFF68 File Offset: 0x001DE168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238212, XrefRangeEnd = 238215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Method_Internal_Static_Int32_Nullable_1_EvalCondition_PDM_0(Nullable<PartnerBossInfo.EvalCondition> evalCondition)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(evalCondition));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_Method_Internal_Static_Int32_Nullable_1_EvalCondition_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006052 RID: 24658 RVA: 0x001DFFB0 File Offset: 0x001DE1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238215, XrefRangeEnd = 238217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_byref___c__DisplayClass63_0_PDM_0(ref PartnerBossBehaviour.__c__DisplayClass63_0 A_0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.NativeMethodInfoPtr_Method_Internal_Static_Boolean_byref___c__DisplayClass63_0_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006053 RID: 24659 RVA: 0x000343EB File Offset: 0x000325EB
		public PartnerBossBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x06006054 RID: 24660 RVA: 0x001DFFF4 File Offset: 0x001DE1F4
		// (set) Token: 0x06006055 RID: 24661 RVA: 0x000343F4 File Offset: 0x000325F4
		public unsafe static int NORMAL_EVAL_TARGET_SCORE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PartnerBossBehaviour.NativeFieldInfoPtr_NORMAL_EVAL_TARGET_SCORE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerBossBehaviour.NativeFieldInfoPtr_NORMAL_EVAL_TARGET_SCORE, (void*)(&value));
			}
		}

		// Token: 0x17002139 RID: 8505
		// (get) Token: 0x06006056 RID: 24662 RVA: 0x001E0010 File Offset: 0x001DE210
		// (set) Token: 0x06006057 RID: 24663 RVA: 0x00034402 File Offset: 0x00032602
		public unsafe static int GOOD_EVAL_TARGET_SCORE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PartnerBossBehaviour.NativeFieldInfoPtr_GOOD_EVAL_TARGET_SCORE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerBossBehaviour.NativeFieldInfoPtr_GOOD_EVAL_TARGET_SCORE, (void*)(&value));
			}
		}

		// Token: 0x1700213A RID: 8506
		// (get) Token: 0x06006058 RID: 24664 RVA: 0x001E002C File Offset: 0x001DE22C
		// (set) Token: 0x06006059 RID: 24665 RVA: 0x00034410 File Offset: 0x00032610
		public unsafe static int EXGOOD_EVAL_TARGET_SCORE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PartnerBossBehaviour.NativeFieldInfoPtr_EXGOOD_EVAL_TARGET_SCORE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerBossBehaviour.NativeFieldInfoPtr_EXGOOD_EVAL_TARGET_SCORE, (void*)(&value));
			}
		}

		// Token: 0x1700213B RID: 8507
		// (get) Token: 0x0600605A RID: 24666 RVA: 0x001E0048 File Offset: 0x001DE248
		// (set) Token: 0x0600605B RID: 24667 RVA: 0x0003441E File Offset: 0x0003261E
		public unsafe static Vector3 EXTRA_COOKER_MOVEMENT_OFFSET
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(PartnerBossBehaviour.NativeFieldInfoPtr_EXTRA_COOKER_MOVEMENT_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerBossBehaviour.NativeFieldInfoPtr_EXTRA_COOKER_MOVEMENT_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x1700213C RID: 8508
		// (get) Token: 0x0600605C RID: 24668 RVA: 0x001E0064 File Offset: 0x001DE264
		// (set) Token: 0x0600605D RID: 24669 RVA: 0x0003442C File Offset: 0x0003262C
		public unsafe List<Sellable> BevList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_BevList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_BevList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700213D RID: 8509
		// (get) Token: 0x0600605E RID: 24670 RVA: 0x001E0094 File Offset: 0x001DE294
		// (set) Token: 0x0600605F RID: 24671 RVA: 0x0003444B File Offset: 0x0003264B
		public unsafe PartnerBossInfo.EvalCondition currentCondition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_currentCondition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_currentCondition)) = value;
			}
		}

		// Token: 0x1700213E RID: 8510
		// (get) Token: 0x06006060 RID: 24672 RVA: 0x001E00BC File Offset: 0x001DE2BC
		// (set) Token: 0x06006061 RID: 24673 RVA: 0x00034466 File Offset: 0x00032666
		public unsafe PartnerBossBehaviour.CurrentWorkingMode currentWorkingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_currentWorkingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_currentWorkingMode)) = value;
			}
		}

		// Token: 0x1700213F RID: 8511
		// (get) Token: 0x06006062 RID: 24674 RVA: 0x001E00E4 File Offset: 0x001DE2E4
		// (set) Token: 0x06006063 RID: 24675 RVA: 0x00034481 File Offset: 0x00032681
		public unsafe List<PartnerBossInfo.EvalCondition> evalConditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_evalConditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PartnerBossInfo.EvalCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_evalConditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002140 RID: 8512
		// (get) Token: 0x06006064 RID: 24676 RVA: 0x001E0114 File Offset: 0x001DE314
		// (set) Token: 0x06006065 RID: 24677 RVA: 0x000344A0 File Offset: 0x000326A0
		public unsafe bool haveInitialize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_haveInitialize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_haveInitialize)) = value;
			}
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x06006066 RID: 24678 RVA: 0x001E013C File Offset: 0x001DE33C
		// (set) Token: 0x06006067 RID: 24679 RVA: 0x000344BB File Offset: 0x000326BB
		public unsafe Il2CppStructArray<int> partnerCanUseCookerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_partnerCanUseCookerId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_partnerCanUseCookerId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x06006068 RID: 24680 RVA: 0x001E016C File Offset: 0x001DE36C
		// (set) Token: 0x06006069 RID: 24681 RVA: 0x000344DA File Offset: 0x000326DA
		public new unsafe PartnerBossInfo PartnerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_PartnerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_PartnerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x0600606A RID: 24682 RVA: 0x001E019C File Offset: 0x001DE39C
		// (set) Token: 0x0600606B RID: 24683 RVA: 0x000344F9 File Offset: 0x000326F9
		public unsafe List<Sellable> privatePartnerStorage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_privatePartnerStorage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_privatePartnerStorage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x0600606C RID: 24684 RVA: 0x001E01CC File Offset: 0x001DE3CC
		// (set) Token: 0x0600606D RID: 24685 RVA: 0x00034518 File Offset: 0x00032718
		public unsafe List<Recipe> RecipeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_RecipeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_RecipeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x0600606E RID: 24686 RVA: 0x001E01FC File Offset: 0x001DE3FC
		// (set) Token: 0x0600606F RID: 24687 RVA: 0x00034537 File Offset: 0x00032737
		public unsafe Recipe selectedRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_selectedRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_selectedRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x06006070 RID: 24688 RVA: 0x001E022C File Offset: 0x001DE42C
		// (set) Token: 0x06006071 RID: 24689 RVA: 0x00034556 File Offset: 0x00032756
		public unsafe Sellable targetBev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_targetBev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_targetBev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x06006072 RID: 24690 RVA: 0x001E025C File Offset: 0x001DE45C
		// (set) Token: 0x06006073 RID: 24691 RVA: 0x00034575 File Offset: 0x00032775
		public unsafe Sellable targetFood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_targetFood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_targetFood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x06006074 RID: 24692 RVA: 0x001E028C File Offset: 0x001DE48C
		// (set) Token: 0x06006075 RID: 24693 RVA: 0x00034594 File Offset: 0x00032794
		public unsafe Coroutine workingCorotine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_workingCorotine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_workingCorotine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002149 RID: 8521
		// (get) Token: 0x06006076 RID: 24694 RVA: 0x001E02BC File Offset: 0x001DE4BC
		// (set) Token: 0x06006077 RID: 24695 RVA: 0x000345B3 File Offset: 0x000327B3
		public unsafe CookController _TargetCooker_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr__TargetCooker_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr__TargetCooker_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700214A RID: 8522
		// (get) Token: 0x06006078 RID: 24696 RVA: 0x001E02EC File Offset: 0x001DE4EC
		// (set) Token: 0x06006079 RID: 24697 RVA: 0x000345D2 File Offset: 0x000327D2
		public unsafe Action<PartnerBossBehaviour.CurrentWorkingMode> getRequestedFromInventoryCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_getRequestedFromInventoryCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PartnerBossBehaviour.CurrentWorkingMode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_getRequestedFromInventoryCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700214B RID: 8523
		// (get) Token: 0x0600607A RID: 24698 RVA: 0x001E031C File Offset: 0x001DE51C
		// (set) Token: 0x0600607B RID: 24699 RVA: 0x000345F1 File Offset: 0x000327F1
		public unsafe Action<GuestTableDisplayer> executeServeCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_executeServeCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestTableDisplayer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_executeServeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700214C RID: 8524
		// (get) Token: 0x0600607C RID: 24700 RVA: 0x001E034C File Offset: 0x001DE54C
		// (set) Token: 0x0600607D RID: 24701 RVA: 0x00034610 File Offset: 0x00032810
		public unsafe Func<Vector3Int> getInventoryPositionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_getInventoryPositionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.NativeFieldInfoPtr_getInventoryPositionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003F97 RID: 16279
		private static readonly IntPtr NativeFieldInfoPtr_NORMAL_EVAL_TARGET_SCORE;

		// Token: 0x04003F98 RID: 16280
		private static readonly IntPtr NativeFieldInfoPtr_GOOD_EVAL_TARGET_SCORE;

		// Token: 0x04003F99 RID: 16281
		private static readonly IntPtr NativeFieldInfoPtr_EXGOOD_EVAL_TARGET_SCORE;

		// Token: 0x04003F9A RID: 16282
		private static readonly IntPtr NativeFieldInfoPtr_EXTRA_COOKER_MOVEMENT_OFFSET;

		// Token: 0x04003F9B RID: 16283
		private static readonly IntPtr NativeFieldInfoPtr_BevList;

		// Token: 0x04003F9C RID: 16284
		private static readonly IntPtr NativeFieldInfoPtr_currentCondition;

		// Token: 0x04003F9D RID: 16285
		private static readonly IntPtr NativeFieldInfoPtr_currentWorkingMode;

		// Token: 0x04003F9E RID: 16286
		private static readonly IntPtr NativeFieldInfoPtr_evalConditions;

		// Token: 0x04003F9F RID: 16287
		private static readonly IntPtr NativeFieldInfoPtr_haveInitialize;

		// Token: 0x04003FA0 RID: 16288
		private static readonly IntPtr NativeFieldInfoPtr_partnerCanUseCookerId;

		// Token: 0x04003FA1 RID: 16289
		private static readonly IntPtr NativeFieldInfoPtr_PartnerData;

		// Token: 0x04003FA2 RID: 16290
		private static readonly IntPtr NativeFieldInfoPtr_privatePartnerStorage;

		// Token: 0x04003FA3 RID: 16291
		private static readonly IntPtr NativeFieldInfoPtr_RecipeList;

		// Token: 0x04003FA4 RID: 16292
		private static readonly IntPtr NativeFieldInfoPtr_selectedRecipe;

		// Token: 0x04003FA5 RID: 16293
		private static readonly IntPtr NativeFieldInfoPtr_targetBev;

		// Token: 0x04003FA6 RID: 16294
		private static readonly IntPtr NativeFieldInfoPtr_targetFood;

		// Token: 0x04003FA7 RID: 16295
		private static readonly IntPtr NativeFieldInfoPtr_workingCorotine;

		// Token: 0x04003FA8 RID: 16296
		private static readonly IntPtr NativeFieldInfoPtr__TargetCooker_k__BackingField;

		// Token: 0x04003FA9 RID: 16297
		private static readonly IntPtr NativeFieldInfoPtr_getRequestedFromInventoryCallback;

		// Token: 0x04003FAA RID: 16298
		private static readonly IntPtr NativeFieldInfoPtr_executeServeCallback;

		// Token: 0x04003FAB RID: 16299
		private static readonly IntPtr NativeFieldInfoPtr_getInventoryPositionCallback;

		// Token: 0x04003FAC RID: 16300
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetCooker_Private_get_CookController_0;

		// Token: 0x04003FAD RID: 16301
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetCooker_Private_set_Void_CookController_0;

		// Token: 0x04003FAE RID: 16302
		private static readonly IntPtr NativeMethodInfoPtr_get_FocusingOrder_Private_get_OrderBase_0;

		// Token: 0x04003FAF RID: 16303
		private static readonly IntPtr NativeMethodInfoPtr_set_FocusingOrder_Private_set_Void_OrderBase_0;

		// Token: 0x04003FB0 RID: 16304
		private static readonly IntPtr NativeMethodInfoPtr_get_AllAvailableCookerCanUseByPartner_Private_get_IEnumerable_1_CookController_0;

		// Token: 0x04003FB1 RID: 16305
		private static readonly IntPtr NativeMethodInfoPtr_GetPartnerType_Public_Virtual_PartnerType_0;

		// Token: 0x04003FB2 RID: 16306
		private static readonly IntPtr NativeMethodInfoPtr_DrawOnGUI_Private_String_0;

		// Token: 0x04003FB3 RID: 16307
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

		// Token: 0x04003FB4 RID: 16308
		private static readonly IntPtr NativeMethodInfoPtr_TryAcceptOrder_Private_Boolean_OrderBase_0;

		// Token: 0x04003FB5 RID: 16309
		private static readonly IntPtr NativeMethodInfoPtr_ResetStatus_Protected_Virtual_Void_0;

		// Token: 0x04003FB6 RID: 16310
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0;

		// Token: 0x04003FB7 RID: 16311
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayIdleState_Protected_Virtual_Void_0;

		// Token: 0x04003FB8 RID: 16312
		private static readonly IntPtr NativeMethodInfoPtr_OnCookIdleReceiveSystemChange_Public_Boolean_OrderChangeContext_OrderBase_Object_0;

		// Token: 0x04003FB9 RID: 16313
		private static readonly IntPtr NativeMethodInfoPtr_PlayMoveToCookerState_Private_Void_0;

		// Token: 0x04003FBA RID: 16314
		private static readonly IntPtr NativeMethodInfoPtr_OnMoveToCookerReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0;

		// Token: 0x04003FBB RID: 16315
		private static readonly IntPtr NativeMethodInfoPtr_OnMoveToCookerStateInterrupt_Private_Void_0;

		// Token: 0x04003FBC RID: 16316
		private static readonly IntPtr NativeMethodInfoPtr_PlayCookState_Private_Void_0;

		// Token: 0x04003FBD RID: 16317
		private static readonly IntPtr NativeMethodInfoPtr_OnCookingReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0;

		// Token: 0x04003FBE RID: 16318
		private static readonly IntPtr NativeMethodInfoPtr_OnCookingStateInterrupt_Private_Void_0;

		// Token: 0x04003FBF RID: 16319
		private static readonly IntPtr NativeMethodInfoPtr_EmployeeCookingCoroutine_Private_IEnumerator_0;

		// Token: 0x04003FC0 RID: 16320
		private static readonly IntPtr NativeMethodInfoPtr_get_WaitressOrBarmaid_Private_get_Boolean_0;

		// Token: 0x04003FC1 RID: 16321
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetPosition_Private_Vector3Int_InventoryType_0;

		// Token: 0x04003FC2 RID: 16322
		private static readonly IntPtr NativeMethodInfoPtr_PlayMoveToExtractFromInventoryState_Private_Void_0;

		// Token: 0x04003FC3 RID: 16323
		private static readonly IntPtr NativeMethodInfoPtr_PlayExtractFromInventoryState_Private_Void_0;

		// Token: 0x04003FC4 RID: 16324
		private static readonly IntPtr NativeMethodInfoPtr_EmployeeExtractFromInventoryCoroutine_Private_IEnumerator_0;

		// Token: 0x04003FC5 RID: 16325
		private static readonly IntPtr NativeMethodInfoPtr_PlayMoveToDeliverState_Private_Void_0;

		// Token: 0x04003FC6 RID: 16326
		private static readonly IntPtr NativeMethodInfoPtr_PlayDeliverState_Private_Void_0;

		// Token: 0x04003FC7 RID: 16327
		private static readonly IntPtr NativeMethodInfoPtr_EmployeeDeliver_Private_IEnumerator_0;

		// Token: 0x04003FC8 RID: 16328
		private static readonly IntPtr NativeMethodInfoPtr_PlayThrowDeliverState_Private_Void_0;

		// Token: 0x04003FC9 RID: 16329
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteThrowDeliver_Private_IEnumerator_0;

		// Token: 0x04003FCA RID: 16330
		private static readonly IntPtr NativeMethodInfoPtr_PlayReturnToInventoryState_Protected_Virtual_Void_Action_0;

		// Token: 0x04003FCB RID: 16331
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerOccupyADesk_Private_Boolean_OrderChangeContext_OrderBase_Object_0;

		// Token: 0x04003FCC RID: 16332
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerOccupyCauseInterruptAndReset_Private_Void_0;

		// Token: 0x04003FCD RID: 16333
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerOccupyCauseInterruptAndReturnToFoodStorage_Private_Void_0;

		// Token: 0x04003FCE RID: 16334
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerOccupyCauseInterruptAndReturnToBeverageShelf_Private_Void_0;

		// Token: 0x04003FCF RID: 16335
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCooker_Private_GetCookerInfo_NormalOrder_byref_CookController_byref_Recipe_0;

		// Token: 0x04003FD0 RID: 16336
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCooker_Private_GetCookerInfo_SpecialOrder_byref_CookController_byref_Recipe_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Boolean_EvalCondition_byref_EvalCondition_Int32_0;

		// Token: 0x04003FD1 RID: 16337
		private static readonly IntPtr NativeMethodInfoPtr_CheckFoodCanSatisfyGuest_Private_Boolean_Sellable_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_Boolean_Boolean_Nullable_1_EvalCondition_Int32_0;

		// Token: 0x04003FD2 RID: 16338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003FD3 RID: 16339
		private static readonly IntPtr NativeMethodInfoPtr__get_AllAvailableCookerCanUseByPartner_b__25_0_Private_Boolean_CookController_0;

		// Token: 0x04003FD4 RID: 16340
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_Sellable_PDM_0;

		// Token: 0x04003FD5 RID: 16341
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Boolean_Recipe_PDM_0;

		// Token: 0x04003FD6 RID: 16342
		private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__28_8_Private_Void_CurrentWorkingMode_0;

		// Token: 0x04003FD7 RID: 16343
		private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__28_9_Private_Void_GuestTableDisplayer_0;

		// Token: 0x04003FD8 RID: 16344
		private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__28_10_Private_Vector3Int_0;

		// Token: 0x04003FD9 RID: 16345
		private static readonly IntPtr NativeMethodInfoPtr__OnCookIdleReceiveSystemChange_b__34_0_Private_Boolean_OrderBase_0;

		// Token: 0x04003FDA RID: 16346
		private static readonly IntPtr NativeMethodInfoPtr__OnMoveToCookerReceiveSystemChange_b__36_0_Private_Boolean_OrderBase_0;

		// Token: 0x04003FDB RID: 16347
		private static readonly IntPtr NativeMethodInfoPtr__EmployeeDeliver_b__53_0_Private_Void_GuestGroupController_0;

		// Token: 0x04003FDC RID: 16348
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_Coroutine_Action_0;

		// Token: 0x04003FDD RID: 16349
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_Int32_Nullable_1_EvalCondition_byref___c__DisplayClass63_0_PDM_0;

		// Token: 0x04003FDE RID: 16350
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_Nullable_1_EvalCondition_PDM_0;

		// Token: 0x04003FDF RID: 16351
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_byref___c__DisplayClass63_0_PDM_0;

		// Token: 0x02000D6D RID: 3437
		public enum CurrentWorkingMode
		{
			// Token: 0x04009C6B RID: 40043
			Cook,
			// Token: 0x04009C6C RID: 40044
			TryGetFood,
			// Token: 0x04009C6D RID: 40045
			TryGetBev,
			// Token: 0x04009C6E RID: 40046
			Waitress,
			// Token: 0x04009C6F RID: 40047
			BackAndTurnBev,
			// Token: 0x04009C70 RID: 40048
			BackAndTurnFood,
			// Token: 0x04009C71 RID: 40049
			Idle
		}

		// Token: 0x02000D6E RID: 3438
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F59A RID: 62874 RVA: 0x0039FFC4 File Offset: 0x0039E1C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr);
				PartnerBossBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, "<>9");
				PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, "<>9__27_1");
				PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, "<>9__28_0");
				PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, "<>9__28_1");
				PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, "<>9__28_2");
				PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, "<>9__28_3");
				PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, "<>9__28_4");
				PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, "<>9__28_5");
				PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, "<>9__28_6");
				PartnerBossBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, 100683095);
				PartnerBossBehaviour.__c.NativeMethodInfoPtr__DrawOnGUI_b__27_1_Internal_String_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, 100683096);
				PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_0_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, 100683097);
				PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_1_Internal_ValueTuple_2_Recipe_Single_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, 100683098);
				PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_2_Internal_Single_ValueTuple_2_Recipe_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, 100683099);
				PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_3_Internal_Recipe_ValueTuple_2_Recipe_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, 100683100);
				PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_4_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, 100683101);
				PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_5_Internal_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, 100683102);
				PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_6_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr, 100683103);
			}

			// Token: 0x0600F59B RID: 62875 RVA: 0x003A0158 File Offset: 0x0039E358
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F59C RID: 62876 RVA: 0x003A0194 File Offset: 0x0039E394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _DrawOnGUI_b__27_1(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c.NativeMethodInfoPtr__DrawOnGUI_b__27_1_Internal_String_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F59D RID: 62877 RVA: 0x003A01DC File Offset: 0x0039E3DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236531, XrefRangeEnd = 236536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnInitialize_b__28_0(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_0_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F59E RID: 62878 RVA: 0x003A022C File Offset: 0x0039E42C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236536, XrefRangeEnd = 236541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<Recipe, float> _OnInitialize_b__28_1(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_1_Internal_ValueTuple_2_Recipe_Single_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<Recipe, float>(pointer);
			}

			// Token: 0x0600F59F RID: 62879 RVA: 0x003A0274 File Offset: 0x0039E474
			[CallerCount(0)]
			public unsafe float _OnInitialize_b__28_2(ValueTuple<Recipe, float> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_2_Internal_Single_ValueTuple_2_Recipe_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F5A0 RID: 62880 RVA: 0x003A02C8 File Offset: 0x0039E4C8
			[CallerCount(0)]
			public unsafe Recipe _OnInitialize_b__28_3(ValueTuple<Recipe, float> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_3_Internal_Recipe_ValueTuple_2_Recipe_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
			}

			// Token: 0x0600F5A1 RID: 62881 RVA: 0x003A0320 File Offset: 0x0039E520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236541, XrefRangeEnd = 236546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnInitialize_b__28_4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_4_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F5A2 RID: 62882 RVA: 0x003A036C File Offset: 0x0039E56C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _OnInitialize_b__28_5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_5_Internal_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0600F5A3 RID: 62883 RVA: 0x003A03B8 File Offset: 0x0039E5B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnInitialize_b__28_6(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__28_6_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F5A4 RID: 62884 RVA: 0x00083F1A File Offset: 0x0008211A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FD7 RID: 20439
			// (get) Token: 0x0600F5A5 RID: 62885 RVA: 0x003A0408 File Offset: 0x0039E608
			// (set) Token: 0x0600F5A6 RID: 62886 RVA: 0x00083F23 File Offset: 0x00082123
			public unsafe static PartnerBossBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FD8 RID: 20440
			// (get) Token: 0x0600F5A7 RID: 62887 RVA: 0x003A0430 File Offset: 0x0039E630
			// (set) Token: 0x0600F5A8 RID: 62888 RVA: 0x00083F35 File Offset: 0x00082135
			public unsafe static Func<Sellable, string> __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FD9 RID: 20441
			// (get) Token: 0x0600F5A9 RID: 62889 RVA: 0x003A0458 File Offset: 0x0039E658
			// (set) Token: 0x0600F5AA RID: 62890 RVA: 0x00083F47 File Offset: 0x00082147
			public unsafe static Func<Recipe, bool> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FDA RID: 20442
			// (get) Token: 0x0600F5AB RID: 62891 RVA: 0x003A0480 File Offset: 0x0039E680
			// (set) Token: 0x0600F5AC RID: 62892 RVA: 0x00083F59 File Offset: 0x00082159
			public unsafe static Func<Recipe, ValueTuple<Recipe, float>> __9__28_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, ValueTuple<Recipe, float>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FDB RID: 20443
			// (get) Token: 0x0600F5AD RID: 62893 RVA: 0x003A04A8 File Offset: 0x0039E6A8
			// (set) Token: 0x0600F5AE RID: 62894 RVA: 0x00083F6B File Offset: 0x0008216B
			public unsafe static Func<ValueTuple<Recipe, float>, float> __9__28_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<Recipe, float>, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FDC RID: 20444
			// (get) Token: 0x0600F5AF RID: 62895 RVA: 0x003A04D0 File Offset: 0x0039E6D0
			// (set) Token: 0x0600F5B0 RID: 62896 RVA: 0x00083F7D File Offset: 0x0008217D
			public unsafe static Func<ValueTuple<Recipe, float>, Recipe> __9__28_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<Recipe, float>, Recipe>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FDD RID: 20445
			// (get) Token: 0x0600F5B1 RID: 62897 RVA: 0x003A04F8 File Offset: 0x0039E6F8
			// (set) Token: 0x0600F5B2 RID: 62898 RVA: 0x00083F8F File Offset: 0x0008218F
			public unsafe static Func<int, bool> __9__28_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FDE RID: 20446
			// (get) Token: 0x0600F5B3 RID: 62899 RVA: 0x003A0520 File Offset: 0x0039E720
			// (set) Token: 0x0600F5B4 RID: 62900 RVA: 0x00083FA1 File Offset: 0x000821A1
			public unsafe static Func<int, Sellable> __9__28_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FDF RID: 20447
			// (get) Token: 0x0600F5B5 RID: 62901 RVA: 0x003A0548 File Offset: 0x0039E748
			// (set) Token: 0x0600F5B6 RID: 62902 RVA: 0x00083FB3 File Offset: 0x000821B3
			public unsafe static Func<Sellable, int> __9__28_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossBehaviour.__c.NativeFieldInfoPtr___9__28_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C72 RID: 40050
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009C73 RID: 40051
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x04009C74 RID: 40052
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x04009C75 RID: 40053
			private static readonly IntPtr NativeFieldInfoPtr___9__28_1;

			// Token: 0x04009C76 RID: 40054
			private static readonly IntPtr NativeFieldInfoPtr___9__28_2;

			// Token: 0x04009C77 RID: 40055
			private static readonly IntPtr NativeFieldInfoPtr___9__28_3;

			// Token: 0x04009C78 RID: 40056
			private static readonly IntPtr NativeFieldInfoPtr___9__28_4;

			// Token: 0x04009C79 RID: 40057
			private static readonly IntPtr NativeFieldInfoPtr___9__28_5;

			// Token: 0x04009C7A RID: 40058
			private static readonly IntPtr NativeFieldInfoPtr___9__28_6;

			// Token: 0x04009C7B RID: 40059
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C7C RID: 40060
			private static readonly IntPtr NativeMethodInfoPtr__DrawOnGUI_b__27_1_Internal_String_Sellable_0;

			// Token: 0x04009C7D RID: 40061
			private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__28_0_Internal_Boolean_Recipe_0;

			// Token: 0x04009C7E RID: 40062
			private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__28_1_Internal_ValueTuple_2_Recipe_Single_Recipe_0;

			// Token: 0x04009C7F RID: 40063
			private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__28_2_Internal_Single_ValueTuple_2_Recipe_Single_0;

			// Token: 0x04009C80 RID: 40064
			private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__28_3_Internal_Recipe_ValueTuple_2_Recipe_Single_0;

			// Token: 0x04009C81 RID: 40065
			private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__28_4_Internal_Boolean_Int32_0;

			// Token: 0x04009C82 RID: 40066
			private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__28_5_Internal_Sellable_Int32_0;

			// Token: 0x04009C83 RID: 40067
			private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__28_6_Internal_Int32_Sellable_0;
		}

		// Token: 0x02000D6F RID: 3439
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F5B7 RID: 62903 RVA: 0x003A0570 File Offset: 0x0039E770
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass28_0>.NativeClassPtr);
				PartnerBossBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_requestedId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass28_0>.NativeClassPtr, "requestedId");
				PartnerBossBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100683104);
				PartnerBossBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__OnInitialize_b__11_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100683105);
			}

			// Token: 0x0600F5B8 RID: 62904 RVA: 0x003A05D8 File Offset: 0x0039E7D8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5B9 RID: 62905 RVA: 0x003A0614 File Offset: 0x0039E814
			[CallerCount(0)]
			public unsafe bool _OnInitialize_b__11(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__OnInitialize_b__11_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F5BA RID: 62906 RVA: 0x00083FC5 File Offset: 0x000821C5
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FE0 RID: 20448
			// (get) Token: 0x0600F5BB RID: 62907 RVA: 0x003A0664 File Offset: 0x0039E864
			// (set) Token: 0x0600F5BC RID: 62908 RVA: 0x00083FCE File Offset: 0x000821CE
			public unsafe int requestedId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_requestedId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_requestedId)) = value;
				}
			}

			// Token: 0x04009C84 RID: 40068
			private static readonly IntPtr NativeFieldInfoPtr_requestedId;

			// Token: 0x04009C85 RID: 40069
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C86 RID: 40070
			private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__11_Internal_Boolean_Sellable_0;
		}

		// Token: 0x02000D70 RID: 3440
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F5BD RID: 62909 RVA: 0x003A068C File Offset: 0x0039E88C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_0>.NativeClassPtr);
				PartnerBossBehaviour.__c__DisplayClass29_0.NativeFieldInfoPtr_normalOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_0>.NativeClassPtr, "normalOrder");
				PartnerBossBehaviour.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_0>.NativeClassPtr, 100683106);
				PartnerBossBehaviour.__c__DisplayClass29_0.NativeMethodInfoPtr__TryAcceptOrder_b__0_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_0>.NativeClassPtr, 100683107);
			}

			// Token: 0x0600F5BE RID: 62910 RVA: 0x003A06F4 File Offset: 0x0039E8F4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5BF RID: 62911 RVA: 0x003A0730 File Offset: 0x0039E930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236546, XrefRangeEnd = 236547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryAcceptOrder_b__0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass29_0.NativeMethodInfoPtr__TryAcceptOrder_b__0_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F5C0 RID: 62912 RVA: 0x00083FE9 File Offset: 0x000821E9
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FE1 RID: 20449
			// (get) Token: 0x0600F5C1 RID: 62913 RVA: 0x003A0780 File Offset: 0x0039E980
			// (set) Token: 0x0600F5C2 RID: 62914 RVA: 0x00083FF2 File Offset: 0x000821F2
			public unsafe GuestsManager.NormalOrder normalOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass29_0.NativeFieldInfoPtr_normalOrder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.NormalOrder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass29_0.NativeFieldInfoPtr_normalOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C87 RID: 40071
			private static readonly IntPtr NativeFieldInfoPtr_normalOrder;

			// Token: 0x04009C88 RID: 40072
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C89 RID: 40073
			private static readonly IntPtr NativeMethodInfoPtr__TryAcceptOrder_b__0_Internal_Boolean_Sellable_0;
		}

		// Token: 0x02000D71 RID: 3441
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<>c__DisplayClass29_1")]
		public sealed class __c__DisplayClass29_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F5C3 RID: 62915 RVA: 0x003A07B0 File Offset: 0x0039E9B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_1()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<>c__DisplayClass29_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_1>.NativeClassPtr);
				PartnerBossBehaviour.__c__DisplayClass29_1.NativeFieldInfoPtr_specialOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_1>.NativeClassPtr, "specialOrder");
				PartnerBossBehaviour.__c__DisplayClass29_1.NativeFieldInfoPtr_budget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_1>.NativeClassPtr, "budget");
				PartnerBossBehaviour.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_1>.NativeClassPtr, 100683108);
				PartnerBossBehaviour.__c__DisplayClass29_1.NativeMethodInfoPtr__TryAcceptOrder_b__1_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_1>.NativeClassPtr, 100683109);
				PartnerBossBehaviour.__c__DisplayClass29_1.NativeMethodInfoPtr__TryAcceptOrder_b__2_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_1>.NativeClassPtr, 100683110);
				PartnerBossBehaviour.__c__DisplayClass29_1.NativeMethodInfoPtr__TryAcceptOrder_b__3_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_1>.NativeClassPtr, 100683111);
			}

			// Token: 0x0600F5C4 RID: 62916 RVA: 0x003A0854 File Offset: 0x0039EA54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass29_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5C5 RID: 62917 RVA: 0x003A0890 File Offset: 0x0039EA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236547, XrefRangeEnd = 236551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryAcceptOrder_b__1(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass29_1.NativeMethodInfoPtr__TryAcceptOrder_b__1_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F5C6 RID: 62918 RVA: 0x003A08E0 File Offset: 0x0039EAE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236551, XrefRangeEnd = 236552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryAcceptOrder_b__2(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass29_1.NativeMethodInfoPtr__TryAcceptOrder_b__2_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F5C7 RID: 62919 RVA: 0x003A0930 File Offset: 0x0039EB30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryAcceptOrder_b__3(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass29_1.NativeMethodInfoPtr__TryAcceptOrder_b__3_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F5C8 RID: 62920 RVA: 0x00084011 File Offset: 0x00082211
			public __c__DisplayClass29_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FE2 RID: 20450
			// (get) Token: 0x0600F5C9 RID: 62921 RVA: 0x003A0980 File Offset: 0x0039EB80
			// (set) Token: 0x0600F5CA RID: 62922 RVA: 0x0008401A File Offset: 0x0008221A
			public unsafe GuestsManager.SpecialOrder specialOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass29_1.NativeFieldInfoPtr_specialOrder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.SpecialOrder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass29_1.NativeFieldInfoPtr_specialOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FE3 RID: 20451
			// (get) Token: 0x0600F5CB RID: 62923 RVA: 0x003A09B0 File Offset: 0x0039EBB0
			// (set) Token: 0x0600F5CC RID: 62924 RVA: 0x00084039 File Offset: 0x00082239
			public unsafe int budget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass29_1.NativeFieldInfoPtr_budget);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass29_1.NativeFieldInfoPtr_budget)) = value;
				}
			}

			// Token: 0x04009C8A RID: 40074
			private static readonly IntPtr NativeFieldInfoPtr_specialOrder;

			// Token: 0x04009C8B RID: 40075
			private static readonly IntPtr NativeFieldInfoPtr_budget;

			// Token: 0x04009C8C RID: 40076
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C8D RID: 40077
			private static readonly IntPtr NativeMethodInfoPtr__TryAcceptOrder_b__1_Internal_Boolean_Sellable_0;

			// Token: 0x04009C8E RID: 40078
			private static readonly IntPtr NativeMethodInfoPtr__TryAcceptOrder_b__2_Internal_Boolean_Sellable_0;

			// Token: 0x04009C8F RID: 40079
			private static readonly IntPtr NativeMethodInfoPtr__TryAcceptOrder_b__3_Internal_Boolean_Sellable_0;
		}

		// Token: 0x02000D72 RID: 3442
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F5CD RID: 62925 RVA: 0x003A09D8 File Offset: 0x0039EBD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass41_0>.NativeClassPtr);
				PartnerBossBehaviour.__c__DisplayClass41_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass41_0>.NativeClassPtr, "canContinue");
				PartnerBossBehaviour.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass41_0>.NativeClassPtr, 100683112);
				PartnerBossBehaviour.__c__DisplayClass41_0.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass41_0>.NativeClassPtr, 100683113);
				PartnerBossBehaviour.__c__DisplayClass41_0.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass41_0>.NativeClassPtr, 100683114);
			}

			// Token: 0x0600F5CE RID: 62926 RVA: 0x003A0A54 File Offset: 0x0039EC54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5CF RID: 62927 RVA: 0x003A0A90 File Offset: 0x0039EC90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EmployeeCookingCoroutine_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass41_0.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5D0 RID: 62928 RVA: 0x003A0AC4 File Offset: 0x0039ECC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EmployeeCookingCoroutine_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass41_0.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F5D1 RID: 62929 RVA: 0x00084054 File Offset: 0x00082254
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FE4 RID: 20452
			// (get) Token: 0x0600F5D2 RID: 62930 RVA: 0x003A0B00 File Offset: 0x0039ED00
			// (set) Token: 0x0600F5D3 RID: 62931 RVA: 0x0008405D File Offset: 0x0008225D
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass41_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass41_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x04009C90 RID: 40080
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x04009C91 RID: 40081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C92 RID: 40082
			private static readonly IntPtr NativeMethodInfoPtr__EmployeeCookingCoroutine_b__0_Internal_Void_0;

			// Token: 0x04009C93 RID: 40083
			private static readonly IntPtr NativeMethodInfoPtr__EmployeeCookingCoroutine_b__1_Internal_Boolean_0;
		}

		// Token: 0x02000D73 RID: 3443
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<EmployeeCookingCoroutine>d__41")]
		public sealed class _EmployeeCookingCoroutine_d__41 : Il2CppSystem.Object
		{
			// Token: 0x0600F5D4 RID: 62932 RVA: 0x003A0B28 File Offset: 0x0039ED28
			// Note: this type is marked as 'beforefieldinit'.
			static _EmployeeCookingCoroutine_d__41()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeCookingCoroutine_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<EmployeeCookingCoroutine>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeCookingCoroutine_d__41>.NativeClassPtr);
				PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeCookingCoroutine_d__41>.NativeClassPtr, "<>1__state");
				PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeCookingCoroutine_d__41>.NativeClassPtr, "<>2__current");
				PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeCookingCoroutine_d__41>.NativeClassPtr, "<>4__this");
				PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeFieldInfoPtr__result_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeCookingCoroutine_d__41>.NativeClassPtr, "<result>5__2");
				PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeCookingCoroutine_d__41>.NativeClassPtr, 100683115);
				PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeCookingCoroutine_d__41>.NativeClassPtr, 100683116);
				PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeCookingCoroutine_d__41>.NativeClassPtr, 100683117);
				PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeCookingCoroutine_d__41>.NativeClassPtr, 100683118);
				PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeCookingCoroutine_d__41>.NativeClassPtr, 100683119);
				PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeCookingCoroutine_d__41>.NativeClassPtr, 100683120);
			}

			// Token: 0x0600F5D5 RID: 62933 RVA: 0x003A0C1C File Offset: 0x0039EE1C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EmployeeCookingCoroutine_d__41(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeCookingCoroutine_d__41>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5D6 RID: 62934 RVA: 0x003A0C64 File Offset: 0x0039EE64
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5D7 RID: 62935 RVA: 0x003A0C98 File Offset: 0x0039EE98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236552, XrefRangeEnd = 236651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004FE9 RID: 20457
			// (get) Token: 0x0600F5D8 RID: 62936 RVA: 0x003A0CD4 File Offset: 0x0039EED4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5D9 RID: 62937 RVA: 0x003A0D14 File Offset: 0x0039EF14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236651, XrefRangeEnd = 236657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004FEA RID: 20458
			// (get) Token: 0x0600F5DA RID: 62938 RVA: 0x003A0D48 File Offset: 0x0039EF48
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5DB RID: 62939 RVA: 0x00084078 File Offset: 0x00082278
			public _EmployeeCookingCoroutine_d__41(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FE5 RID: 20453
			// (get) Token: 0x0600F5DC RID: 62940 RVA: 0x003A0D88 File Offset: 0x0039EF88
			// (set) Token: 0x0600F5DD RID: 62941 RVA: 0x00084081 File Offset: 0x00082281
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004FE6 RID: 20454
			// (get) Token: 0x0600F5DE RID: 62942 RVA: 0x003A0DB0 File Offset: 0x0039EFB0
			// (set) Token: 0x0600F5DF RID: 62943 RVA: 0x0008409C File Offset: 0x0008229C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FE7 RID: 20455
			// (get) Token: 0x0600F5E0 RID: 62944 RVA: 0x003A0DE0 File Offset: 0x0039EFE0
			// (set) Token: 0x0600F5E1 RID: 62945 RVA: 0x000840BB File Offset: 0x000822BB
			public unsafe PartnerBossBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FE8 RID: 20456
			// (get) Token: 0x0600F5E2 RID: 62946 RVA: 0x003A0E10 File Offset: 0x0039F010
			// (set) Token: 0x0600F5E3 RID: 62947 RVA: 0x000840DA File Offset: 0x000822DA
			public unsafe Sellable _result_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeFieldInfoPtr__result_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeCookingCoroutine_d__41.NativeFieldInfoPtr__result_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C94 RID: 40084
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009C95 RID: 40085
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009C96 RID: 40086
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C97 RID: 40087
			private static readonly IntPtr NativeFieldInfoPtr__result_5__2;

			// Token: 0x04009C98 RID: 40088
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009C99 RID: 40089
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009C9A RID: 40090
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009C9B RID: 40091
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009C9C RID: 40092
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009C9D RID: 40093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D74 RID: 3444
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<EmployeeExtractFromInventoryCoroutine>d__50")]
		public sealed class _EmployeeExtractFromInventoryCoroutine_d__50 : Il2CppSystem.Object
		{
			// Token: 0x0600F5E4 RID: 62948 RVA: 0x003A0E40 File Offset: 0x0039F040
			// Note: this type is marked as 'beforefieldinit'.
			static _EmployeeExtractFromInventoryCoroutine_d__50()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<EmployeeExtractFromInventoryCoroutine>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50>.NativeClassPtr);
				PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50>.NativeClassPtr, "<>1__state");
				PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50>.NativeClassPtr, "<>2__current");
				PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50>.NativeClassPtr, "<>4__this");
				PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50>.NativeClassPtr, 100683121);
				PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50>.NativeClassPtr, 100683122);
				PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50>.NativeClassPtr, 100683123);
				PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50>.NativeClassPtr, 100683124);
				PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50>.NativeClassPtr, 100683125);
				PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50>.NativeClassPtr, 100683126);
			}

			// Token: 0x0600F5E5 RID: 62949 RVA: 0x003A0F20 File Offset: 0x0039F120
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EmployeeExtractFromInventoryCoroutine_d__50(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5E6 RID: 62950 RVA: 0x003A0F68 File Offset: 0x0039F168
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5E7 RID: 62951 RVA: 0x003A0F9C File Offset: 0x0039F19C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236657, XrefRangeEnd = 236666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004FEE RID: 20462
			// (get) Token: 0x0600F5E8 RID: 62952 RVA: 0x003A0FD8 File Offset: 0x0039F1D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5E9 RID: 62953 RVA: 0x003A1018 File Offset: 0x0039F218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236666, XrefRangeEnd = 236672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004FEF RID: 20463
			// (get) Token: 0x0600F5EA RID: 62954 RVA: 0x003A104C File Offset: 0x0039F24C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5EB RID: 62955 RVA: 0x000840F9 File Offset: 0x000822F9
			public _EmployeeExtractFromInventoryCoroutine_d__50(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FEB RID: 20459
			// (get) Token: 0x0600F5EC RID: 62956 RVA: 0x003A108C File Offset: 0x0039F28C
			// (set) Token: 0x0600F5ED RID: 62957 RVA: 0x00084102 File Offset: 0x00082302
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004FEC RID: 20460
			// (get) Token: 0x0600F5EE RID: 62958 RVA: 0x003A10B4 File Offset: 0x0039F2B4
			// (set) Token: 0x0600F5EF RID: 62959 RVA: 0x0008411D File Offset: 0x0008231D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FED RID: 20461
			// (get) Token: 0x0600F5F0 RID: 62960 RVA: 0x003A10E4 File Offset: 0x0039F2E4
			// (set) Token: 0x0600F5F1 RID: 62961 RVA: 0x0008413C File Offset: 0x0008233C
			public unsafe PartnerBossBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeExtractFromInventoryCoroutine_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C9E RID: 40094
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009C9F RID: 40095
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009CA0 RID: 40096
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009CA1 RID: 40097
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009CA2 RID: 40098
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009CA3 RID: 40099
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009CA4 RID: 40100
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009CA5 RID: 40101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009CA6 RID: 40102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D75 RID: 3445
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<EmployeeDeliver>d__53")]
		public sealed class _EmployeeDeliver_d__53 : Il2CppSystem.Object
		{
			// Token: 0x0600F5F2 RID: 62962 RVA: 0x003A1114 File Offset: 0x0039F314
			// Note: this type is marked as 'beforefieldinit'.
			static _EmployeeDeliver_d__53()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeDeliver_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<EmployeeDeliver>d__53");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeDeliver_d__53>.NativeClassPtr);
				PartnerBossBehaviour._EmployeeDeliver_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeDeliver_d__53>.NativeClassPtr, "<>1__state");
				PartnerBossBehaviour._EmployeeDeliver_d__53.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeDeliver_d__53>.NativeClassPtr, "<>2__current");
				PartnerBossBehaviour._EmployeeDeliver_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeDeliver_d__53>.NativeClassPtr, "<>4__this");
				PartnerBossBehaviour._EmployeeDeliver_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeDeliver_d__53>.NativeClassPtr, 100683127);
				PartnerBossBehaviour._EmployeeDeliver_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeDeliver_d__53>.NativeClassPtr, 100683128);
				PartnerBossBehaviour._EmployeeDeliver_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeDeliver_d__53>.NativeClassPtr, 100683129);
				PartnerBossBehaviour._EmployeeDeliver_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeDeliver_d__53>.NativeClassPtr, 100683130);
				PartnerBossBehaviour._EmployeeDeliver_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeDeliver_d__53>.NativeClassPtr, 100683131);
				PartnerBossBehaviour._EmployeeDeliver_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeDeliver_d__53>.NativeClassPtr, 100683132);
			}

			// Token: 0x0600F5F3 RID: 62963 RVA: 0x003A11F4 File Offset: 0x0039F3F4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EmployeeDeliver_d__53(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour._EmployeeDeliver_d__53>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeDeliver_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5F4 RID: 62964 RVA: 0x003A123C File Offset: 0x0039F43C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeDeliver_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F5F5 RID: 62965 RVA: 0x003A1270 File Offset: 0x0039F470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236672, XrefRangeEnd = 236713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeDeliver_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004FF3 RID: 20467
			// (get) Token: 0x0600F5F6 RID: 62966 RVA: 0x003A12AC File Offset: 0x0039F4AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeDeliver_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5F7 RID: 62967 RVA: 0x003A12EC File Offset: 0x0039F4EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236713, XrefRangeEnd = 236719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeDeliver_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004FF4 RID: 20468
			// (get) Token: 0x0600F5F8 RID: 62968 RVA: 0x003A1320 File Offset: 0x0039F520
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._EmployeeDeliver_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F5F9 RID: 62969 RVA: 0x0008415B File Offset: 0x0008235B
			public _EmployeeDeliver_d__53(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FF0 RID: 20464
			// (get) Token: 0x0600F5FA RID: 62970 RVA: 0x003A1360 File Offset: 0x0039F560
			// (set) Token: 0x0600F5FB RID: 62971 RVA: 0x00084164 File Offset: 0x00082364
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeDeliver_d__53.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeDeliver_d__53.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004FF1 RID: 20465
			// (get) Token: 0x0600F5FC RID: 62972 RVA: 0x003A1388 File Offset: 0x0039F588
			// (set) Token: 0x0600F5FD RID: 62973 RVA: 0x0008417F File Offset: 0x0008237F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeDeliver_d__53.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeDeliver_d__53.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FF2 RID: 20466
			// (get) Token: 0x0600F5FE RID: 62974 RVA: 0x003A13B8 File Offset: 0x0039F5B8
			// (set) Token: 0x0600F5FF RID: 62975 RVA: 0x0008419E File Offset: 0x0008239E
			public unsafe PartnerBossBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeDeliver_d__53.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._EmployeeDeliver_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CA7 RID: 40103
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009CA8 RID: 40104
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009CA9 RID: 40105
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009CAA RID: 40106
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009CAB RID: 40107
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009CAC RID: 40108
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009CAD RID: 40109
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009CAE RID: 40110
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009CAF RID: 40111
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D76 RID: 3446
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<>c__DisplayClass55_0")]
		public sealed class __c__DisplayClass55_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F600 RID: 62976 RVA: 0x003A13E8 File Offset: 0x0039F5E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<>c__DisplayClass55_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr);
				PartnerBossBehaviour.__c__DisplayClass55_0.NativeFieldInfoPtr_throwFoodFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr, "throwFoodFinish");
				PartnerBossBehaviour.__c__DisplayClass55_0.NativeFieldInfoPtr_throwBevFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr, "throwBevFinish");
				PartnerBossBehaviour.__c__DisplayClass55_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr, "<>4__this");
				PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr, 100683133);
				PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ExecuteThrowDeliver_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr, 100683134);
				PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ExecuteThrowDeliver_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr, 100683135);
				PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ExecuteThrowDeliver_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr, 100683136);
				PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ExecuteThrowDeliver_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr, 100683137);
				PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ExecuteThrowDeliver_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr, 100683138);
				PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr, 100683139);
				PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ExecuteThrowDeliver_b__7_Internal_Void_GuestGroupController_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr, 100683140);
			}

			// Token: 0x0600F601 RID: 62977 RVA: 0x003A14F0 File Offset: 0x0039F6F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass55_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F602 RID: 62978 RVA: 0x003A152C File Offset: 0x0039F72C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ExecuteThrowDeliver_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ExecuteThrowDeliver_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F603 RID: 62979 RVA: 0x003A1560 File Offset: 0x0039F760
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ExecuteThrowDeliver_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ExecuteThrowDeliver_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F604 RID: 62980 RVA: 0x003A1594 File Offset: 0x0039F794
			[CallerCount(0)]
			public unsafe void _ExecuteThrowDeliver_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ExecuteThrowDeliver_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F605 RID: 62981 RVA: 0x003A15C8 File Offset: 0x0039F7C8
			[CallerCount(0)]
			public unsafe void _ExecuteThrowDeliver_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ExecuteThrowDeliver_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F606 RID: 62982 RVA: 0x003A15FC File Offset: 0x0039F7FC
			[CallerCount(0)]
			public unsafe bool _ExecuteThrowDeliver_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ExecuteThrowDeliver_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F607 RID: 62983 RVA: 0x003A1638 File Offset: 0x0039F838
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 236737, RefRangeEnd = 236738, XrefRangeStart = 236719, XrefRangeEnd = 236737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_0(GuestGroupController guestControllerGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestControllerGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F608 RID: 62984 RVA: 0x003A167C File Offset: 0x0039F87C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236738, XrefRangeEnd = 236743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ExecuteThrowDeliver_b__7(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass55_0.NativeMethodInfoPtr__ExecuteThrowDeliver_b__7_Internal_Void_GuestGroupController_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F609 RID: 62985 RVA: 0x000841BD File Offset: 0x000823BD
			public __c__DisplayClass55_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FF5 RID: 20469
			// (get) Token: 0x0600F60A RID: 62986 RVA: 0x003A16C0 File Offset: 0x0039F8C0
			// (set) Token: 0x0600F60B RID: 62987 RVA: 0x000841C6 File Offset: 0x000823C6
			public unsafe bool throwFoodFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass55_0.NativeFieldInfoPtr_throwFoodFinish);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass55_0.NativeFieldInfoPtr_throwFoodFinish)) = value;
				}
			}

			// Token: 0x17004FF6 RID: 20470
			// (get) Token: 0x0600F60C RID: 62988 RVA: 0x003A16E8 File Offset: 0x0039F8E8
			// (set) Token: 0x0600F60D RID: 62989 RVA: 0x000841E1 File Offset: 0x000823E1
			public unsafe bool throwBevFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass55_0.NativeFieldInfoPtr_throwBevFinish);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass55_0.NativeFieldInfoPtr_throwBevFinish)) = value;
				}
			}

			// Token: 0x17004FF7 RID: 20471
			// (get) Token: 0x0600F60E RID: 62990 RVA: 0x003A1710 File Offset: 0x0039F910
			// (set) Token: 0x0600F60F RID: 62991 RVA: 0x000841FC File Offset: 0x000823FC
			public unsafe PartnerBossBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass55_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass55_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CB0 RID: 40112
			private static readonly IntPtr NativeFieldInfoPtr_throwFoodFinish;

			// Token: 0x04009CB1 RID: 40113
			private static readonly IntPtr NativeFieldInfoPtr_throwBevFinish;

			// Token: 0x04009CB2 RID: 40114
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009CB3 RID: 40115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CB4 RID: 40116
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteThrowDeliver_b__0_Internal_Void_0;

			// Token: 0x04009CB5 RID: 40117
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteThrowDeliver_b__1_Internal_Void_0;

			// Token: 0x04009CB6 RID: 40118
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteThrowDeliver_b__2_Internal_Void_0;

			// Token: 0x04009CB7 RID: 40119
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteThrowDeliver_b__3_Internal_Void_0;

			// Token: 0x04009CB8 RID: 40120
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteThrowDeliver_b__4_Internal_Boolean_0;

			// Token: 0x04009CB9 RID: 40121
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_0;

			// Token: 0x04009CBA RID: 40122
			private static readonly IntPtr NativeMethodInfoPtr__ExecuteThrowDeliver_b__7_Internal_Void_GuestGroupController_1;
		}

		// Token: 0x02000D77 RID: 3447
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<ExecuteThrowDeliver>d__55")]
		public sealed class _ExecuteThrowDeliver_d__55 : Il2CppSystem.Object
		{
			// Token: 0x0600F610 RID: 62992 RVA: 0x003A1740 File Offset: 0x0039F940
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteThrowDeliver_d__55()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour._ExecuteThrowDeliver_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<ExecuteThrowDeliver>d__55");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour._ExecuteThrowDeliver_d__55>.NativeClassPtr);
				PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._ExecuteThrowDeliver_d__55>.NativeClassPtr, "<>1__state");
				PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._ExecuteThrowDeliver_d__55>.NativeClassPtr, "<>2__current");
				PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._ExecuteThrowDeliver_d__55>.NativeClassPtr, "<>4__this");
				PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour._ExecuteThrowDeliver_d__55>.NativeClassPtr, "<>8__1");
				PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._ExecuteThrowDeliver_d__55>.NativeClassPtr, 100683141);
				PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._ExecuteThrowDeliver_d__55>.NativeClassPtr, 100683142);
				PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._ExecuteThrowDeliver_d__55>.NativeClassPtr, 100683143);
				PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._ExecuteThrowDeliver_d__55>.NativeClassPtr, 100683144);
				PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._ExecuteThrowDeliver_d__55>.NativeClassPtr, 100683145);
				PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour._ExecuteThrowDeliver_d__55>.NativeClassPtr, 100683146);
			}

			// Token: 0x0600F611 RID: 62993 RVA: 0x003A1834 File Offset: 0x0039FA34
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteThrowDeliver_d__55(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour._ExecuteThrowDeliver_d__55>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F612 RID: 62994 RVA: 0x003A187C File Offset: 0x0039FA7C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F613 RID: 62995 RVA: 0x003A18B0 File Offset: 0x0039FAB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236743, XrefRangeEnd = 236906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004FFC RID: 20476
			// (get) Token: 0x0600F614 RID: 62996 RVA: 0x003A18EC File Offset: 0x0039FAEC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F615 RID: 62997 RVA: 0x003A192C File Offset: 0x0039FB2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236906, XrefRangeEnd = 236912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004FFD RID: 20477
			// (get) Token: 0x0600F616 RID: 62998 RVA: 0x003A1960 File Offset: 0x0039FB60
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F617 RID: 62999 RVA: 0x0008421B File Offset: 0x0008241B
			public _ExecuteThrowDeliver_d__55(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FF8 RID: 20472
			// (get) Token: 0x0600F618 RID: 63000 RVA: 0x003A19A0 File Offset: 0x0039FBA0
			// (set) Token: 0x0600F619 RID: 63001 RVA: 0x00084224 File Offset: 0x00082424
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004FF9 RID: 20473
			// (get) Token: 0x0600F61A RID: 63002 RVA: 0x003A19C8 File Offset: 0x0039FBC8
			// (set) Token: 0x0600F61B RID: 63003 RVA: 0x0008423F File Offset: 0x0008243F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FFA RID: 20474
			// (get) Token: 0x0600F61C RID: 63004 RVA: 0x003A19F8 File Offset: 0x0039FBF8
			// (set) Token: 0x0600F61D RID: 63005 RVA: 0x0008425E File Offset: 0x0008245E
			public unsafe PartnerBossBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FFB RID: 20475
			// (get) Token: 0x0600F61E RID: 63006 RVA: 0x003A1A28 File Offset: 0x0039FC28
			// (set) Token: 0x0600F61F RID: 63007 RVA: 0x0008427D File Offset: 0x0008247D
			public unsafe PartnerBossBehaviour.__c__DisplayClass55_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossBehaviour.__c__DisplayClass55_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour._ExecuteThrowDeliver_d__55.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CBB RID: 40123
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009CBC RID: 40124
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009CBD RID: 40125
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009CBE RID: 40126
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04009CBF RID: 40127
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009CC0 RID: 40128
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009CC1 RID: 40129
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009CC2 RID: 40130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009CC3 RID: 40131
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009CC4 RID: 40132
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D78 RID: 3448
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F620 RID: 63008 RVA: 0x003A1A58 File Offset: 0x0039FC58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0>.NativeClassPtr);
				PartnerBossBehaviour.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0>.NativeClassPtr, "<>4__this");
				PartnerBossBehaviour.__c__DisplayClass56_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0>.NativeClassPtr, "onFinish");
				PartnerBossBehaviour.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0>.NativeClassPtr, 100683147);
				PartnerBossBehaviour.__c__DisplayClass56_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0>.NativeClassPtr, 100683148);
			}

			// Token: 0x0600F621 RID: 63009 RVA: 0x003A1AD4 File Offset: 0x0039FCD4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F622 RID: 63010 RVA: 0x003A1B10 File Offset: 0x0039FD10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236936, XrefRangeEnd = 236941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass56_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F623 RID: 63011 RVA: 0x0008429C File Offset: 0x0008249C
			public __c__DisplayClass56_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FFE RID: 20478
			// (get) Token: 0x0600F624 RID: 63012 RVA: 0x003A1B50 File Offset: 0x0039FD50
			// (set) Token: 0x0600F625 RID: 63013 RVA: 0x000842A5 File Offset: 0x000824A5
			public unsafe PartnerBossBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FFF RID: 20479
			// (get) Token: 0x0600F626 RID: 63014 RVA: 0x003A1B80 File Offset: 0x0039FD80
			// (set) Token: 0x0600F627 RID: 63015 RVA: 0x000842C4 File Offset: 0x000824C4
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass56_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass56_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CC5 RID: 40133
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009CC6 RID: 40134
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04009CC7 RID: 40135
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CC8 RID: 40136
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200109E RID: 4254
			[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<>c__DisplayClass56_0+<<PlayReturnToInventoryState>g__EmployeeAddToInventoryCoroutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060121E8 RID: 74216 RVA: 0x00422634 File Offset: 0x00420834
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0>.NativeClassPtr, "<<PlayReturnToInventoryState>g__EmployeeAddToInventoryCoroutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683149);
					PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683150);
					PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683151);
					PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683152);
					PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683153);
					PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683154);
				}

				// Token: 0x060121E9 RID: 74217 RVA: 0x00422714 File Offset: 0x00420914
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060121EA RID: 74218 RVA: 0x0042275C File Offset: 0x0042095C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060121EB RID: 74219 RVA: 0x00422790 File Offset: 0x00420990
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236912, XrefRangeEnd = 236930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005EA6 RID: 24230
				// (get) Token: 0x060121EC RID: 74220 RVA: 0x004227CC File Offset: 0x004209CC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060121ED RID: 74221 RVA: 0x0042280C File Offset: 0x00420A0C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236930, XrefRangeEnd = 236936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005EA7 RID: 24231
				// (get) Token: 0x060121EE RID: 74222 RVA: 0x00422840 File Offset: 0x00420A40
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060121EF RID: 74223 RVA: 0x0009D6F2 File Offset: 0x0009B8F2
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005EA3 RID: 24227
				// (get) Token: 0x060121F0 RID: 74224 RVA: 0x00422880 File Offset: 0x00420A80
				// (set) Token: 0x060121F1 RID: 74225 RVA: 0x0009D6FB File Offset: 0x0009B8FB
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005EA4 RID: 24228
				// (get) Token: 0x060121F2 RID: 74226 RVA: 0x004228A8 File Offset: 0x00420AA8
				// (set) Token: 0x060121F3 RID: 74227 RVA: 0x0009D716 File Offset: 0x0009B916
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EA5 RID: 24229
				// (get) Token: 0x060121F4 RID: 74228 RVA: 0x004228D8 File Offset: 0x00420AD8
				// (set) Token: 0x060121F5 RID: 74229 RVA: 0x0009D735 File Offset: 0x0009B935
				public unsafe PartnerBossBehaviour.__c__DisplayClass56_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossBehaviour.__c__DisplayClass56_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass56_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B794 RID: 46996
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B795 RID: 46997
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B796 RID: 46998
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B797 RID: 46999
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B798 RID: 47000
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B799 RID: 47001
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B79A RID: 47002
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B79B RID: 47003
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B79C RID: 47004
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D79 RID: 3449
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<>c__DisplayClass62_0")]
		public sealed class __c__DisplayClass62_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F628 RID: 63016 RVA: 0x003A1BB0 File Offset: 0x0039FDB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_0()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<>c__DisplayClass62_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr);
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_finalRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, "finalRecipe");
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_haveTriedConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, "haveTriedConditions");
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_haveBevSatisfy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, "haveBevSatisfy");
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, "<>4__this");
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_specGuestLikeTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, "specGuestLikeTag");
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_specGuestHateTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, "specGuestHateTag");
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_bevScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, "bevScore");
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_focusingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, "focusingOrder");
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_maxPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, "maxPrice");
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, 100683155);
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeMethodInfoPtr__TryGetCooker_b__0_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, 100683156);
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeMethodInfoPtr__TryGetCooker_b__1_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, 100683157);
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeMethodInfoPtr_Method_Internal_Nullable_1_EvalCondition_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, 100683158);
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeMethodInfoPtr__TryGetCooker_b__4_Internal_Boolean_EvalCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, 100683159);
				PartnerBossBehaviour.__c__DisplayClass62_0.NativeMethodInfoPtr_Method_Internal_Recipe_Nullable_1_EvalCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr, 100683160);
			}

			// Token: 0x0600F629 RID: 63017 RVA: 0x003A1D08 File Offset: 0x0039FF08
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F62A RID: 63018 RVA: 0x003A1D44 File Offset: 0x0039FF44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236941, XrefRangeEnd = 236946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetCooker_b__0(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass62_0.NativeMethodInfoPtr__TryGetCooker_b__0_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F62B RID: 63019 RVA: 0x003A1D94 File Offset: 0x0039FF94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236946, XrefRangeEnd = 236951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetCooker_b__1(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass62_0.NativeMethodInfoPtr__TryGetCooker_b__1_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F62C RID: 63020 RVA: 0x003A1DE4 File Offset: 0x0039FFE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236951, XrefRangeEnd = 236963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<PartnerBossInfo.EvalCondition> Method_Internal_Nullable_1_EvalCondition_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass62_0.NativeMethodInfoPtr_Method_Internal_Nullable_1_EvalCondition_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<PartnerBossInfo.EvalCondition>(pointer);
			}

			// Token: 0x0600F62D RID: 63021 RVA: 0x003A1E1C File Offset: 0x003A001C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236963, XrefRangeEnd = 236966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetCooker_b__4(PartnerBossInfo.EvalCondition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass62_0.NativeMethodInfoPtr__TryGetCooker_b__4_Internal_Boolean_EvalCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F62E RID: 63022 RVA: 0x003A1E68 File Offset: 0x003A0068
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 237042, RefRangeEnd = 237044, XrefRangeStart = 236966, XrefRangeEnd = 237042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Recipe Method_Internal_Recipe_Nullable_1_EvalCondition_0(Nullable<PartnerBossInfo.EvalCondition> targetCondition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(targetCondition));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass62_0.NativeMethodInfoPtr_Method_Internal_Recipe_Nullable_1_EvalCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
			}

			// Token: 0x0600F62F RID: 63023 RVA: 0x000842E3 File Offset: 0x000824E3
			public __c__DisplayClass62_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005000 RID: 20480
			// (get) Token: 0x0600F630 RID: 63024 RVA: 0x003A1EC0 File Offset: 0x003A00C0
			// (set) Token: 0x0600F631 RID: 63025 RVA: 0x000842EC File Offset: 0x000824EC
			public unsafe Recipe finalRecipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_finalRecipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_finalRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005001 RID: 20481
			// (get) Token: 0x0600F632 RID: 63026 RVA: 0x003A1EF0 File Offset: 0x003A00F0
			// (set) Token: 0x0600F633 RID: 63027 RVA: 0x0008430B File Offset: 0x0008250B
			public unsafe Stack<PartnerBossInfo.EvalCondition> haveTriedConditions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_haveTriedConditions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<PartnerBossInfo.EvalCondition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_haveTriedConditions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005002 RID: 20482
			// (get) Token: 0x0600F634 RID: 63028 RVA: 0x003A1F20 File Offset: 0x003A0120
			// (set) Token: 0x0600F635 RID: 63029 RVA: 0x0008432A File Offset: 0x0008252A
			public unsafe bool haveBevSatisfy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_haveBevSatisfy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_haveBevSatisfy)) = value;
				}
			}

			// Token: 0x17005003 RID: 20483
			// (get) Token: 0x0600F636 RID: 63030 RVA: 0x003A1F48 File Offset: 0x003A0148
			// (set) Token: 0x0600F637 RID: 63031 RVA: 0x00084345 File Offset: 0x00082545
			public unsafe PartnerBossBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005004 RID: 20484
			// (get) Token: 0x0600F638 RID: 63032 RVA: 0x003A1F78 File Offset: 0x003A0178
			// (set) Token: 0x0600F639 RID: 63033 RVA: 0x00084364 File Offset: 0x00082564
			public unsafe Il2CppStructArray<int> specGuestLikeTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_specGuestLikeTag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_specGuestLikeTag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005005 RID: 20485
			// (get) Token: 0x0600F63A RID: 63034 RVA: 0x003A1FA8 File Offset: 0x003A01A8
			// (set) Token: 0x0600F63B RID: 63035 RVA: 0x00084383 File Offset: 0x00082583
			public unsafe Il2CppStructArray<int> specGuestHateTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_specGuestHateTag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_specGuestHateTag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005006 RID: 20486
			// (get) Token: 0x0600F63C RID: 63036 RVA: 0x003A1FD8 File Offset: 0x003A01D8
			// (set) Token: 0x0600F63D RID: 63037 RVA: 0x000843A2 File Offset: 0x000825A2
			public unsafe int bevScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_bevScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_bevScore)) = value;
				}
			}

			// Token: 0x17005007 RID: 20487
			// (get) Token: 0x0600F63E RID: 63038 RVA: 0x003A2000 File Offset: 0x003A0200
			// (set) Token: 0x0600F63F RID: 63039 RVA: 0x000843BD File Offset: 0x000825BD
			public unsafe GuestsManager.SpecialOrder focusingOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_focusingOrder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.SpecialOrder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_focusingOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005008 RID: 20488
			// (get) Token: 0x0600F640 RID: 63040 RVA: 0x003A2030 File Offset: 0x003A0230
			// (set) Token: 0x0600F641 RID: 63041 RVA: 0x000843DC File Offset: 0x000825DC
			public unsafe int maxPrice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_maxPrice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_0.NativeFieldInfoPtr_maxPrice)) = value;
				}
			}

			// Token: 0x04009CC9 RID: 40137
			private static readonly IntPtr NativeFieldInfoPtr_finalRecipe;

			// Token: 0x04009CCA RID: 40138
			private static readonly IntPtr NativeFieldInfoPtr_haveTriedConditions;

			// Token: 0x04009CCB RID: 40139
			private static readonly IntPtr NativeFieldInfoPtr_haveBevSatisfy;

			// Token: 0x04009CCC RID: 40140
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009CCD RID: 40141
			private static readonly IntPtr NativeFieldInfoPtr_specGuestLikeTag;

			// Token: 0x04009CCE RID: 40142
			private static readonly IntPtr NativeFieldInfoPtr_specGuestHateTag;

			// Token: 0x04009CCF RID: 40143
			private static readonly IntPtr NativeFieldInfoPtr_bevScore;

			// Token: 0x04009CD0 RID: 40144
			private static readonly IntPtr NativeFieldInfoPtr_focusingOrder;

			// Token: 0x04009CD1 RID: 40145
			private static readonly IntPtr NativeFieldInfoPtr_maxPrice;

			// Token: 0x04009CD2 RID: 40146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CD3 RID: 40147
			private static readonly IntPtr NativeMethodInfoPtr__TryGetCooker_b__0_Internal_Boolean_CookController_0;

			// Token: 0x04009CD4 RID: 40148
			private static readonly IntPtr NativeMethodInfoPtr__TryGetCooker_b__1_Internal_Boolean_CookController_0;

			// Token: 0x04009CD5 RID: 40149
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Nullable_1_EvalCondition_PDM_0;

			// Token: 0x04009CD6 RID: 40150
			private static readonly IntPtr NativeMethodInfoPtr__TryGetCooker_b__4_Internal_Boolean_EvalCondition_0;

			// Token: 0x04009CD7 RID: 40151
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Recipe_Nullable_1_EvalCondition_0;
		}

		// Token: 0x02000D7A RID: 3450
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<>c__DisplayClass62_1")]
		public sealed class __c__DisplayClass62_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F642 RID: 63042 RVA: 0x003A2058 File Offset: 0x003A0258
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_1()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<>c__DisplayClass62_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_1>.NativeClassPtr);
				PartnerBossBehaviour.__c__DisplayClass62_1.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_1>.NativeClassPtr, "recipe");
				PartnerBossBehaviour.__c__DisplayClass62_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_1>.NativeClassPtr, 100683161);
				PartnerBossBehaviour.__c__DisplayClass62_1.NativeMethodInfoPtr__TryGetCooker_b__5_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_1>.NativeClassPtr, 100683162);
			}

			// Token: 0x0600F643 RID: 63043 RVA: 0x003A20C0 File Offset: 0x003A02C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass62_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass62_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F644 RID: 63044 RVA: 0x003A20FC File Offset: 0x003A02FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237044, XrefRangeEnd = 237049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetCooker_b__5(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.__c__DisplayClass62_1.NativeMethodInfoPtr__TryGetCooker_b__5_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F645 RID: 63045 RVA: 0x000843F7 File Offset: 0x000825F7
			public __c__DisplayClass62_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005009 RID: 20489
			// (get) Token: 0x0600F646 RID: 63046 RVA: 0x003A214C File Offset: 0x003A034C
			// (set) Token: 0x0600F647 RID: 63047 RVA: 0x00084400 File Offset: 0x00082600
			public unsafe Recipe recipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_1.NativeFieldInfoPtr_recipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass62_1.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CD8 RID: 40152
			private static readonly IntPtr NativeFieldInfoPtr_recipe;

			// Token: 0x04009CD9 RID: 40153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CDA RID: 40154
			private static readonly IntPtr NativeMethodInfoPtr__TryGetCooker_b__5_Internal_Boolean_CookController_0;
		}

		// Token: 0x02000D7B RID: 3451
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<>c__DisplayClass63_0")]
		public sealed class __c__DisplayClass63_0 : ValueType
		{
			// Token: 0x0600F648 RID: 63048 RVA: 0x003A217C File Offset: 0x003A037C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass63_0>.NativeClassPtr);
				PartnerBossBehaviour.__c__DisplayClass63_0.NativeFieldInfoPtr_haveBevSatisfy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass63_0>.NativeClassPtr, "haveBevSatisfy");
				PartnerBossBehaviour.__c__DisplayClass63_0.NativeFieldInfoPtr_haveFoodSatisfy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass63_0>.NativeClassPtr, "haveFoodSatisfy");
				PartnerBossBehaviour.__c__DisplayClass63_0.NativeFieldInfoPtr_bevScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass63_0>.NativeClassPtr, "bevScore");
				PartnerBossBehaviour.__c__DisplayClass63_0.NativeFieldInfoPtr_targetCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass63_0>.NativeClassPtr, "targetCondition");
			}

			// Token: 0x0600F649 RID: 63049 RVA: 0x0008441F File Offset: 0x0008261F
			public __c__DisplayClass63_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600F64A RID: 63050 RVA: 0x00084428 File Offset: 0x00082628
			public __c__DisplayClass63_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour.__c__DisplayClass63_0>.NativeClassPtr))
			{
			}

			// Token: 0x1700500A RID: 20490
			// (get) Token: 0x0600F64B RID: 63051 RVA: 0x003A21F8 File Offset: 0x003A03F8
			// (set) Token: 0x0600F64C RID: 63052 RVA: 0x0008443A File Offset: 0x0008263A
			public unsafe bool haveBevSatisfy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass63_0.NativeFieldInfoPtr_haveBevSatisfy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass63_0.NativeFieldInfoPtr_haveBevSatisfy)) = value;
				}
			}

			// Token: 0x1700500B RID: 20491
			// (get) Token: 0x0600F64D RID: 63053 RVA: 0x003A2220 File Offset: 0x003A0420
			// (set) Token: 0x0600F64E RID: 63054 RVA: 0x00084455 File Offset: 0x00082655
			public unsafe bool haveFoodSatisfy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass63_0.NativeFieldInfoPtr_haveFoodSatisfy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass63_0.NativeFieldInfoPtr_haveFoodSatisfy)) = value;
				}
			}

			// Token: 0x1700500C RID: 20492
			// (get) Token: 0x0600F64F RID: 63055 RVA: 0x003A2248 File Offset: 0x003A0448
			// (set) Token: 0x0600F650 RID: 63056 RVA: 0x00084470 File Offset: 0x00082670
			public unsafe int bevScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass63_0.NativeFieldInfoPtr_bevScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass63_0.NativeFieldInfoPtr_bevScore)) = value;
				}
			}

			// Token: 0x1700500D RID: 20493
			// (get) Token: 0x0600F651 RID: 63057 RVA: 0x003A2270 File Offset: 0x003A0470
			// (set) Token: 0x0600F652 RID: 63058 RVA: 0x0008448B File Offset: 0x0008268B
			public Nullable<PartnerBossInfo.EvalCondition> targetCondition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass63_0.NativeFieldInfoPtr_targetCondition);
					return new Nullable<PartnerBossInfo.EvalCondition>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<PartnerBossInfo.EvalCondition>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.__c__DisplayClass63_0.NativeFieldInfoPtr_targetCondition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<PartnerBossInfo.EvalCondition>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04009CDB RID: 40155
			private static readonly IntPtr NativeFieldInfoPtr_haveBevSatisfy;

			// Token: 0x04009CDC RID: 40156
			private static readonly IntPtr NativeFieldInfoPtr_haveFoodSatisfy;

			// Token: 0x04009CDD RID: 40157
			private static readonly IntPtr NativeFieldInfoPtr_bevScore;

			// Token: 0x04009CDE RID: 40158
			private static readonly IntPtr NativeFieldInfoPtr_targetCondition;
		}

		// Token: 0x02000D7C RID: 3452
		[ObfuscatedName("GameData.Profile.PartnerBossBehaviour+<<ExecuteThrowDeliver>g__Schedule|55_5>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F653 RID: 63059 RVA: 0x003A22A0 File Offset: 0x003A04A0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique()
			{
				Il2CppClassPointerStore<PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossBehaviour>.NativeClassPtr, "<<ExecuteThrowDeliver>g__Schedule|55_5>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique>.NativeClassPtr);
				PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique>.NativeClassPtr, "<>1__state");
				PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique>.NativeClassPtr, "<>2__current");
				PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique>.NativeClassPtr, "coroutine");
				PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique>.NativeClassPtr, "onFinish");
				PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique>.NativeClassPtr, 100683163);
				PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique>.NativeClassPtr, 100683164);
				PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique>.NativeClassPtr, 100683165);
				PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique>.NativeClassPtr, 100683166);
				PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique>.NativeClassPtr, 100683167);
				PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique>.NativeClassPtr, 100683168);
			}

			// Token: 0x0600F654 RID: 63060 RVA: 0x003A2394 File Offset: 0x003A0594
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F655 RID: 63061 RVA: 0x003A23DC File Offset: 0x003A05DC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F656 RID: 63062 RVA: 0x003A2410 File Offset: 0x003A0610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237049, XrefRangeEnd = 237050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005012 RID: 20498
			// (get) Token: 0x0600F657 RID: 63063 RVA: 0x003A244C File Offset: 0x003A064C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F658 RID: 63064 RVA: 0x003A248C File Offset: 0x003A068C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237050, XrefRangeEnd = 237056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005013 RID: 20499
			// (get) Token: 0x0600F659 RID: 63065 RVA: 0x003A24C0 File Offset: 0x003A06C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F65A RID: 63066 RVA: 0x000844B9 File Offset: 0x000826B9
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700500E RID: 20494
			// (get) Token: 0x0600F65B RID: 63067 RVA: 0x003A2500 File Offset: 0x003A0700
			// (set) Token: 0x0600F65C RID: 63068 RVA: 0x000844C2 File Offset: 0x000826C2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700500F RID: 20495
			// (get) Token: 0x0600F65D RID: 63069 RVA: 0x003A2528 File Offset: 0x003A0728
			// (set) Token: 0x0600F65E RID: 63070 RVA: 0x000844DD File Offset: 0x000826DD
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005010 RID: 20496
			// (get) Token: 0x0600F65F RID: 63071 RVA: 0x003A2558 File Offset: 0x003A0758
			// (set) Token: 0x0600F660 RID: 63072 RVA: 0x000844FC File Offset: 0x000826FC
			public unsafe Coroutine coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005011 RID: 20497
			// (get) Token: 0x0600F661 RID: 63073 RVA: 0x003A2588 File Offset: 0x003A0788
			// (set) Token: 0x0600F662 RID: 63074 RVA: 0x0008451B File Offset: 0x0008271B
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCocoAconObObUnique.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CDF RID: 40159
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009CE0 RID: 40160
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009CE1 RID: 40161
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x04009CE2 RID: 40162
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04009CE3 RID: 40163
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009CE4 RID: 40164
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009CE5 RID: 40165
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009CE6 RID: 40166
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009CE7 RID: 40167
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009CE8 RID: 40168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
