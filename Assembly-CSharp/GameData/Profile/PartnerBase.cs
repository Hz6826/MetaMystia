using System;
using Common.CharacterUtility;
using DayScene.Input;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using NightScene.Tiles;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x0200032F RID: 815
	public class PartnerBase : Il2CppSystem.Object
	{
		// Token: 0x06005FB6 RID: 24502 RVA: 0x001DD16C File Offset: 0x001DB36C
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerBase()
		{
			Il2CppClassPointerStore<PartnerBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr);
			PartnerBase.NativeFieldInfoPtr_SPECIAL_EVENT_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "SPECIAL_EVENT_KEY");
			PartnerBase.NativeFieldInfoPtr_PARTNER_STATUS_IDLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "PARTNER_STATUS_IDLE");
			PartnerBase.NativeFieldInfoPtr_PARTNER_STATUS_STORING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "PARTNER_STATUS_STORING");
			PartnerBase.NativeFieldInfoPtr_PARTNER_STATUS_SLEEPING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "PARTNER_STATUS_SLEEPING");
			PartnerBase.NativeFieldInfoPtr_EXTRA_STORAGE_MOVEMENT_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "EXTRA_STORAGE_MOVEMENT_OFFSET");
			PartnerBase.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "buffer");
			PartnerBase.NativeFieldInfoPtr_controlledCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "controlledCharacter");
			PartnerBase.NativeFieldInfoPtr_focusingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "focusingOrder");
			PartnerBase.NativeFieldInfoPtr_idlePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "idlePosition");
			PartnerBase.NativeFieldInfoPtr_m_PartnerAdditionalData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "m_PartnerAdditionalData");
			PartnerBase.NativeFieldInfoPtr_moveCharacterAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "moveCharacterAction");
			PartnerBase.NativeFieldInfoPtr_OnStartIdleExtraCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "OnStartIdleExtraCallback");
			PartnerBase.NativeFieldInfoPtr_OnStartWorkingExtraCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "OnStartWorkingExtraCallback");
			PartnerBase.NativeFieldInfoPtr_partnerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "partnerData");
			PartnerBase.NativeFieldInfoPtr_partnerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "partnerIndex");
			PartnerBase.NativeFieldInfoPtr_partnerMovementAdditionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "partnerMovementAdditionData");
			PartnerBase.NativeFieldInfoPtr_partnerSleepStateProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "partnerSleepStateProgress");
			PartnerBase.NativeFieldInfoPtr_partnerStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "partnerStatus");
			PartnerBase.NativeFieldInfoPtr_partnerWorkingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "partnerWorkingState");
			PartnerBase.NativeFieldInfoPtr_shouldNotMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "shouldNotMove");
			PartnerBase.NativeFieldInfoPtr__OnSystemStatusChangedShouldInterruptCurrentStateCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "<OnSystemStatusChangedShouldInterruptCurrentStateCallback>k__BackingField");
			PartnerBase.NativeFieldInfoPtr__CurrentStateInterrupt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "<CurrentStateInterrupt>k__BackingField");
			PartnerBase.NativeFieldInfoPtr__CompanionPartnerIndexs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "<CompanionPartnerIndexs>k__BackingField");
			PartnerBase.NativeMethodInfoPtr_get_FocusingOrderBase_Protected_get_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682968);
			PartnerBase.NativeMethodInfoPtr_set_FocusingOrderBase_Protected_set_Void_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682969);
			PartnerBase.NativeMethodInfoPtr_get_FocusingOrderNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682970);
			PartnerBase.NativeMethodInfoPtr_get_OnSystemStatusChangedShouldInterruptCurrentStateCallback_Private_get_Func_4_OrderChangeContext_OrderBase_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682971);
			PartnerBase.NativeMethodInfoPtr_set_OnSystemStatusChangedShouldInterruptCurrentStateCallback_Protected_set_Void_Func_4_OrderChangeContext_OrderBase_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682972);
			PartnerBase.NativeMethodInfoPtr_get_CurrentStateInterrupt_Private_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682973);
			PartnerBase.NativeMethodInfoPtr_set_CurrentStateInterrupt_Protected_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682974);
			PartnerBase.NativeMethodInfoPtr_get_TileManager_Protected_get_TileManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682975);
			PartnerBase.NativeMethodInfoPtr_get_Manager_Protected_get_PartnerManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682976);
			PartnerBase.NativeMethodInfoPtr_get_CharacterPosition_Protected_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682977);
			PartnerBase.NativeMethodInfoPtr_get_ControlledCharacter_Public_get_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682978);
			PartnerBase.NativeMethodInfoPtr_get_IdlePosition_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682979);
			PartnerBase.NativeMethodInfoPtr_get_PartnerIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682980);
			PartnerBase.NativeMethodInfoPtr_get_PartnerData_Public_get_PartnerInfoBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682981);
			PartnerBase.NativeMethodInfoPtr_get_PartnerWorkingState_Public_get_WorkState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682982);
			PartnerBase.NativeMethodInfoPtr_get_PartnerSleepStateProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682983);
			PartnerBase.NativeMethodInfoPtr_get_PartnerStatusEnum_Public_get_PartnerStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682984);
			PartnerBase.NativeMethodInfoPtr_get_ExtraWorkSpeedRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682985);
			PartnerBase.NativeMethodInfoPtr_get_CompanionPartnerIndexs_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682986);
			PartnerBase.NativeMethodInfoPtr_get_ExtraOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682987);
			PartnerBase.NativeMethodInfoPtr_ForceInterrupt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682988);
			PartnerBase.NativeMethodInfoPtr_Initialize_Public_Void_Vector3Int_AStarInputGeneratorComponent_PartnerInfoBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682989);
			PartnerBase.NativeMethodInfoPtr_SetAdditionalData_Public_Void_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682990);
			PartnerBase.NativeMethodInfoPtr_UpdateStatus_Public_Void_WorkState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682991);
			PartnerBase.NativeMethodInfoPtr_UpdateSleepingStatus_Private_Void_WorkState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682992);
			PartnerBase.NativeMethodInfoPtr_UpdateCurrentWorkStateProgress_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682993);
			PartnerBase.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682994);
			PartnerBase.NativeMethodInfoPtr_OnPlayIdleState_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682995);
			PartnerBase.NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682996);
			PartnerBase.NativeMethodInfoPtr_ResetStatus_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682997);
			PartnerBase.NativeMethodInfoPtr_TryAddCompanionPartnerBaseIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682998);
			PartnerBase.NativeMethodInfoPtr_NotifyOrderStatusChanged_Public_Void_Int32_OrderChangeContext_OrderBase_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100682999);
			PartnerBase.NativeMethodInfoPtr_GetControlledTransform_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683000);
			PartnerBase.NativeMethodInfoPtr_GetPartnerType_Public_Abstract_Virtual_New_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683001);
			PartnerBase.NativeMethodInfoPtr_PartnerLog_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683002);
			PartnerBase.NativeMethodInfoPtr_GetPartnerRevenueCut_Public_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683003);
			PartnerBase.NativeMethodInfoPtr_Take_Protected_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683004);
			PartnerBase.NativeMethodInfoPtr_Send_Protected_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683005);
			PartnerBase.NativeMethodInfoPtr_InspectBuffer_Public_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683006);
			PartnerBase.NativeMethodInfoPtr_SetUIStatus_Protected_Void_Nullable_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683007);
			PartnerBase.NativeMethodInfoPtr_IngredientInRange_Protected_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683008);
			PartnerBase.NativeMethodInfoPtr_IngredientOutRange_Protected_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683009);
			PartnerBase.NativeMethodInfoPtr_PlayIdleState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683010);
			PartnerBase.NativeMethodInfoPtr_OnMoveToIdlePositionCompelete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683011);
			PartnerBase.NativeMethodInfoPtr_OnStartSleeping_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683012);
			PartnerBase.NativeMethodInfoPtr_OnStartWorking_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683013);
			PartnerBase.NativeMethodInfoPtr_PlayMoveToReturnInventoryState_Protected_Void_InventoryType_Nullable_1_Int32_Nullable_1_Vector3Int_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683014);
			PartnerBase.NativeMethodInfoPtr_PlayReturnToInventoryState_Protected_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683015);
			PartnerBase.NativeMethodInfoPtr_MoveCharacter_Public_Void_Vector3Int_Vector3_CharacterRotation_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683016);
			PartnerBase.NativeMethodInfoPtr_StopCharacter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683017);
			PartnerBase.NativeMethodInfoPtr_TryStopCharacterAndRecordAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683018);
			PartnerBase.NativeMethodInfoPtr_TryToMoveAgain_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683019);
			PartnerBase.NativeMethodInfoPtr_PlayAudio_Protected_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683020);
			PartnerBase.NativeMethodInfoPtr_Dispose_Public_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683021);
			PartnerBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683022);
			PartnerBase.NativeMethodInfoPtr__PlayIdleState_b__84_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, 100683024);
		}

		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x06005FB7 RID: 24503 RVA: 0x001DD7C8 File Offset: 0x001DB9C8
		// (set) Token: 0x06005FB8 RID: 24504 RVA: 0x001DD808 File Offset: 0x001DBA08
		public unsafe GuestsManager.OrderBase FocusingOrderBase
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_FocusingOrderBase_Protected_get_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_set_FocusingOrderBase_Protected_set_Void_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x06005FB9 RID: 24505 RVA: 0x001DD84C File Offset: 0x001DBA4C
		public unsafe int FocusingOrderNum
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 236042, RefRangeEnd = 236043, XrefRangeStart = 236042, XrefRangeEnd = 236042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_FocusingOrderNum_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x06005FBA RID: 24506 RVA: 0x001DD888 File Offset: 0x001DBA88
		// (set) Token: 0x06005FBB RID: 24507 RVA: 0x001DD8C8 File Offset: 0x001DBAC8
		public unsafe Func<PartnerManager.OrderChangeContext, GuestsManager.OrderBase, Il2CppSystem.Object, bool> OnSystemStatusChangedShouldInterruptCurrentStateCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_OnSystemStatusChangedShouldInterruptCurrentStateCallback_Private_get_Func_4_OrderChangeContext_OrderBase_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<PartnerManager.OrderChangeContext, GuestsManager.OrderBase, Il2CppSystem.Object, bool>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_set_OnSystemStatusChangedShouldInterruptCurrentStateCallback_Protected_set_Void_Func_4_OrderChangeContext_OrderBase_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x06005FBC RID: 24508 RVA: 0x001DD90C File Offset: 0x001DBB0C
		// (set) Token: 0x06005FBD RID: 24509 RVA: 0x001DD94C File Offset: 0x001DBB4C
		public unsafe Action CurrentStateInterrupt
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_CurrentStateInterrupt_Private_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_set_CurrentStateInterrupt_Protected_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x06005FBE RID: 24510 RVA: 0x001DD990 File Offset: 0x001DBB90
		public unsafe TileManager TileManager
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 236046, RefRangeEnd = 236052, XrefRangeStart = 236043, XrefRangeEnd = 236046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_TileManager_Protected_get_TileManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TileManager>(intPtr3) : null;
			}
		}

		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x06005FBF RID: 24511 RVA: 0x001DD9D0 File Offset: 0x001DBBD0
		public unsafe PartnerManager Manager
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 236055, RefRangeEnd = 236089, XrefRangeStart = 236052, XrefRangeEnd = 236055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_Manager_Protected_get_PartnerManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr3) : null;
			}
		}

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x06005FC0 RID: 24512 RVA: 0x001DDA10 File Offset: 0x001DBC10
		public unsafe Vector3 CharacterPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 236091, RefRangeEnd = 236092, XrefRangeStart = 236089, XrefRangeEnd = 236091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_CharacterPosition_Protected_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x06005FC1 RID: 24513 RVA: 0x001DDA4C File Offset: 0x001DBC4C
		public unsafe AStarInputGeneratorComponent ControlledCharacter
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_ControlledCharacter_Public_get_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr3) : null;
			}
		}

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x06005FC2 RID: 24514 RVA: 0x001DDA8C File Offset: 0x001DBC8C
		public unsafe Vector3Int IdlePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_IdlePosition_Public_get_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x06005FC3 RID: 24515 RVA: 0x001DDAC8 File Offset: 0x001DBCC8
		public unsafe int PartnerIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_PartnerIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002131 RID: 8497
		// (get) Token: 0x06005FC4 RID: 24516 RVA: 0x001DDB04 File Offset: 0x001DBD04
		public unsafe PartnerInfoBase PartnerData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_PartnerData_Public_get_PartnerInfoBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PartnerInfoBase>(intPtr3) : null;
			}
		}

		// Token: 0x17002132 RID: 8498
		// (get) Token: 0x06005FC5 RID: 24517 RVA: 0x001DDB44 File Offset: 0x001DBD44
		public unsafe PartnerInfoBase.WorkState PartnerWorkingState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_PartnerWorkingState_Public_get_WorkState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002133 RID: 8499
		// (get) Token: 0x06005FC6 RID: 24518 RVA: 0x001DDB80 File Offset: 0x001DBD80
		public unsafe float PartnerSleepStateProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_PartnerSleepStateProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002134 RID: 8500
		// (get) Token: 0x06005FC7 RID: 24519 RVA: 0x001DDBBC File Offset: 0x001DBDBC
		public unsafe PartnerBase.PartnerStatus PartnerStatusEnum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_PartnerStatusEnum_Public_get_PartnerStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002135 RID: 8501
		// (get) Token: 0x06005FC8 RID: 24520 RVA: 0x001DDBF8 File Offset: 0x001DBDF8
		public unsafe float ExtraWorkSpeedRate
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 236096, RefRangeEnd = 236102, XrefRangeStart = 236092, XrefRangeEnd = 236096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_ExtraWorkSpeedRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002136 RID: 8502
		// (get) Token: 0x06005FC9 RID: 24521 RVA: 0x001DDC34 File Offset: 0x001DBE34
		public unsafe List<int> CompanionPartnerIndexs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_CompanionPartnerIndexs_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17002137 RID: 8503
		// (get) Token: 0x06005FCA RID: 24522 RVA: 0x001DDC74 File Offset: 0x001DBE74
		public unsafe Vector3 ExtraOffset
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 236102, RefRangeEnd = 236104, XrefRangeStart = 236102, XrefRangeEnd = 236102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_get_ExtraOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005FCB RID: 24523 RVA: 0x001DDCB0 File Offset: 0x001DBEB0
		[CallerCount(0)]
		public unsafe void ForceInterrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_ForceInterrupt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FCC RID: 24524 RVA: 0x001DDCE4 File Offset: 0x001DBEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236149, RefRangeEnd = 236150, XrefRangeStart = 236104, XrefRangeEnd = 236149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Vector3Int idlePosition, AStarInputGeneratorComponent controlledCharacter, PartnerInfoBase partnerData, int partnerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref idlePosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controlledCharacter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref partnerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_Initialize_Public_Void_Vector3Int_AStarInputGeneratorComponent_PartnerInfoBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FCD RID: 24525 RVA: 0x001DDD54 File Offset: 0x001DBF54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236162, RefRangeEnd = 236164, XrefRangeStart = 236150, XrefRangeEnd = 236162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAdditionalData<T>(T extraData, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = extraData;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref extraData;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PartnerBase.MethodInfoStoreGeneric_SetAdditionalData_Public_Void_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06005FCE RID: 24526 RVA: 0x001DDDDC File Offset: 0x001DBFDC
		[CallerCount(0)]
		public unsafe void UpdateStatus(PartnerInfoBase.WorkState currentWorkState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentWorkState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_UpdateStatus_Public_Void_WorkState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x001DDE1C File Offset: 0x001DC01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236164, XrefRangeEnd = 236166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSleepingStatus(PartnerInfoBase.WorkState currentWorkState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentWorkState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_UpdateSleepingStatus_Private_Void_WorkState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x001DDE5C File Offset: 0x001DC05C
		[CallerCount(0)]
		public unsafe void UpdateCurrentWorkStateProgress(float progressToFinishState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progressToFinishState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_UpdateCurrentWorkStateProgress_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x001DDE9C File Offset: 0x001DC09C
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBase.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x001DDED8 File Offset: 0x001DC0D8
		[CallerCount(0)]
		public unsafe virtual void OnPlayIdleState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBase.NativeMethodInfoPtr_OnPlayIdleState_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x001DDF14 File Offset: 0x001DC114
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBase.NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x001DDF50 File Offset: 0x001DC150
		[CallerCount(0)]
		public unsafe virtual void ResetStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBase.NativeMethodInfoPtr_ResetStatus_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD5 RID: 24533 RVA: 0x001DDF8C File Offset: 0x001DC18C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236168, RefRangeEnd = 236169, XrefRangeStart = 236166, XrefRangeEnd = 236168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryAddCompanionPartnerBaseIndex(int companionBaseIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref companionBaseIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_TryAddCompanionPartnerBaseIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD6 RID: 24534 RVA: 0x001DDFCC File Offset: 0x001DC1CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 236175, RefRangeEnd = 236180, XrefRangeStart = 236169, XrefRangeEnd = 236175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyOrderStatusChanged(int senderIndex, PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, Il2CppSystem.Object additionalInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref senderIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref orderChangeContext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalInformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_NotifyOrderStatusChanged_Public_Void_Int32_OrderChangeContext_OrderBase_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FD7 RID: 24535 RVA: 0x001DE040 File Offset: 0x001DC240
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 236182, RefRangeEnd = 236186, XrefRangeStart = 236180, XrefRangeEnd = 236182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetControlledTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_GetControlledTransform_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x001DE080 File Offset: 0x001DC280
		[CallerCount(0)]
		public unsafe virtual PartnerBase.PartnerType GetPartnerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBase.NativeMethodInfoPtr_GetPartnerType_Public_Abstract_Virtual_New_PartnerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FD9 RID: 24537 RVA: 0x001DE0C8 File Offset: 0x001DC2C8
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 236213, RefRangeEnd = 236254, XrefRangeStart = 236186, XrefRangeEnd = 236213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PartnerLog(string args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_PartnerLog_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FDA RID: 24538 RVA: 0x001DE10C File Offset: 0x001DC30C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236260, RefRangeEnd = 236261, XrefRangeStart = 236254, XrefRangeEnd = 236260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPartnerRevenueCut(float multiplyingPower = 1f, bool ignoreTewiLuck = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplyingPower;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTewiLuck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_GetPartnerRevenueCut_Public_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x001DE164 File Offset: 0x001DC364
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Take(Sellable sellable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_Take_Protected_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FDC RID: 24540 RVA: 0x001DE1A8 File Offset: 0x001DC3A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 236262, RefRangeEnd = 236265, XrefRangeStart = 236261, XrefRangeEnd = 236262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sellable Send()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_Send_Protected_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x06005FDD RID: 24541 RVA: 0x001DE1E8 File Offset: 0x001DC3E8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sellable InspectBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_InspectBuffer_Public_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x06005FDE RID: 24542 RVA: 0x001DE228 File Offset: 0x001DC428
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 236270, RefRangeEnd = 236281, XrefRangeStart = 236265, XrefRangeEnd = 236270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUIStatus(Nullable<int> targetDeskCode, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(targetDeskCode));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_SetUIStatus_Protected_Void_Nullable_1_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FDF RID: 24543 RVA: 0x001DE284 File Offset: 0x001DC484
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236292, RefRangeEnd = 236294, XrefRangeStart = 236281, XrefRangeEnd = 236292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IngredientInRange(IEnumerable<int> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_IngredientInRange_Protected_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x001DE2C8 File Offset: 0x001DC4C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236309, RefRangeEnd = 236310, XrefRangeStart = 236294, XrefRangeEnd = 236309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IngredientOutRange(IEnumerable<int> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_IngredientOutRange_Protected_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE1 RID: 24545 RVA: 0x001DE30C File Offset: 0x001DC50C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 236332, RefRangeEnd = 236337, XrefRangeStart = 236310, XrefRangeEnd = 236332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayIdleState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_PlayIdleState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE2 RID: 24546 RVA: 0x001DE340 File Offset: 0x001DC540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236337, XrefRangeEnd = 236341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMoveToIdlePositionCompelete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_OnMoveToIdlePositionCompelete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE3 RID: 24547 RVA: 0x001DE374 File Offset: 0x001DC574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236346, RefRangeEnd = 236347, XrefRangeStart = 236341, XrefRangeEnd = 236346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStartSleeping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_OnStartSleeping_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE4 RID: 24548 RVA: 0x001DE3A8 File Offset: 0x001DC5A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236349, RefRangeEnd = 236350, XrefRangeStart = 236347, XrefRangeEnd = 236349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStartWorking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_OnStartWorking_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x001DE3DC File Offset: 0x001DC5DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 236392, RefRangeEnd = 236400, XrefRangeStart = 236350, XrefRangeEnd = 236392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMoveToReturnInventoryState(PartnerBase.InventoryType inventoryType, Nullable<int> targetDeskCode, Nullable<Vector3Int> overridePosition, Action onReturnFinish = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inventoryType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(targetDeskCode));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overridePosition));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onReturnFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_PlayMoveToReturnInventoryState_Protected_Void_InventoryType_Nullable_1_Int32_Nullable_1_Vector3Int_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x001DE45C File Offset: 0x001DC65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236400, XrefRangeEnd = 236421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayReturnToInventoryState(Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBase.NativeMethodInfoPtr_PlayReturnToInventoryState_Protected_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE7 RID: 24551 RVA: 0x001DE4AC File Offset: 0x001DC6AC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 236452, RefRangeEnd = 236461, XrefRangeStart = 236421, XrefRangeEnd = 236452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveCharacter(Vector3Int dest, Vector3 extraOffset, DayScenePlayerInputGenerator.CharacterRotation onArrivalRotation, Action onArrivalCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dest;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onArrivalRotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onArrivalCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_MoveCharacter_Public_Void_Vector3Int_Vector3_CharacterRotation_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x001DE51C File Offset: 0x001DC71C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 236464, RefRangeEnd = 236472, XrefRangeStart = 236461, XrefRangeEnd = 236464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCharacter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_StopCharacter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x001DE550 File Offset: 0x001DC750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236478, RefRangeEnd = 236480, XrefRangeStart = 236472, XrefRangeEnd = 236478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStopCharacterAndRecordAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_TryStopCharacterAndRecordAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x001DE584 File Offset: 0x001DC784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236501, RefRangeEnd = 236502, XrefRangeStart = 236480, XrefRangeEnd = 236501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryToMoveAgain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_TryToMoveAgain_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x001DE5B8 File Offset: 0x001DC7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236502, XrefRangeEnd = 236507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAudio(AudioClip audioClip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioClip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_PlayAudio_Protected_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FEC RID: 24556 RVA: 0x001DE5FC File Offset: 0x001DC7FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236515, RefRangeEnd = 236516, XrefRangeStart = 236507, XrefRangeEnd = 236515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AStarInputGeneratorComponent Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr_Dispose_Public_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr3) : null;
		}

		// Token: 0x06005FED RID: 24557 RVA: 0x001DE63C File Offset: 0x001DC83C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 236525, RefRangeEnd = 236528, XrefRangeStart = 236516, XrefRangeEnd = 236525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FEE RID: 24558 RVA: 0x001DE678 File Offset: 0x001DC878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236528, XrefRangeEnd = 236531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _PlayIdleState_b__84_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.NativeMethodInfoPtr__PlayIdleState_b__84_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FEF RID: 24559 RVA: 0x00034172 File Offset: 0x00032372
		public PartnerBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x06005FF0 RID: 24560 RVA: 0x001DE6AC File Offset: 0x001DC8AC
		// (set) Token: 0x06005FF1 RID: 24561 RVA: 0x0003417B File Offset: 0x0003237B
		public unsafe static string SPECIAL_EVENT_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PartnerBase.NativeFieldInfoPtr_SPECIAL_EVENT_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerBase.NativeFieldInfoPtr_SPECIAL_EVENT_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x06005FF2 RID: 24562 RVA: 0x001DE6CC File Offset: 0x001DC8CC
		// (set) Token: 0x06005FF3 RID: 24563 RVA: 0x0003418D File Offset: 0x0003238D
		public unsafe static string PARTNER_STATUS_IDLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PartnerBase.NativeFieldInfoPtr_PARTNER_STATUS_IDLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerBase.NativeFieldInfoPtr_PARTNER_STATUS_IDLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x06005FF4 RID: 24564 RVA: 0x001DE6EC File Offset: 0x001DC8EC
		// (set) Token: 0x06005FF5 RID: 24565 RVA: 0x0003419F File Offset: 0x0003239F
		public unsafe static string PARTNER_STATUS_STORING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PartnerBase.NativeFieldInfoPtr_PARTNER_STATUS_STORING, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerBase.NativeFieldInfoPtr_PARTNER_STATUS_STORING, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x06005FF6 RID: 24566 RVA: 0x001DE70C File Offset: 0x001DC90C
		// (set) Token: 0x06005FF7 RID: 24567 RVA: 0x000341B1 File Offset: 0x000323B1
		public unsafe static string PARTNER_STATUS_SLEEPING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PartnerBase.NativeFieldInfoPtr_PARTNER_STATUS_SLEEPING, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerBase.NativeFieldInfoPtr_PARTNER_STATUS_SLEEPING, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x06005FF8 RID: 24568 RVA: 0x001DE72C File Offset: 0x001DC92C
		// (set) Token: 0x06005FF9 RID: 24569 RVA: 0x000341C3 File Offset: 0x000323C3
		public unsafe static Vector3 EXTRA_STORAGE_MOVEMENT_OFFSET
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(PartnerBase.NativeFieldInfoPtr_EXTRA_STORAGE_MOVEMENT_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerBase.NativeFieldInfoPtr_EXTRA_STORAGE_MOVEMENT_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x06005FFA RID: 24570 RVA: 0x001DE748 File Offset: 0x001DC948
		// (set) Token: 0x06005FFB RID: 24571 RVA: 0x000341D1 File Offset: 0x000323D1
		public unsafe Sellable buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x06005FFC RID: 24572 RVA: 0x001DE778 File Offset: 0x001DC978
		// (set) Token: 0x06005FFD RID: 24573 RVA: 0x000341F0 File Offset: 0x000323F0
		public unsafe AStarInputGeneratorComponent controlledCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_controlledCharacter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_controlledCharacter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x06005FFE RID: 24574 RVA: 0x001DE7A8 File Offset: 0x001DC9A8
		// (set) Token: 0x06005FFF RID: 24575 RVA: 0x0003420F File Offset: 0x0003240F
		public unsafe GuestsManager.OrderBase focusingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_focusingOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_focusingOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x06006000 RID: 24576 RVA: 0x001DE7D8 File Offset: 0x001DC9D8
		// (set) Token: 0x06006001 RID: 24577 RVA: 0x0003422E File Offset: 0x0003242E
		public unsafe Vector3Int idlePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_idlePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_idlePosition)) = value;
			}
		}

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x06006002 RID: 24578 RVA: 0x001DE800 File Offset: 0x001DCA00
		// (set) Token: 0x06006003 RID: 24579 RVA: 0x00034249 File Offset: 0x00032449
		public unsafe Il2CppReferenceArray<Il2CppSystem.Object> m_PartnerAdditionalData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_m_PartnerAdditionalData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_m_PartnerAdditionalData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x06006004 RID: 24580 RVA: 0x001DE830 File Offset: 0x001DCA30
		// (set) Token: 0x06006005 RID: 24581 RVA: 0x00034268 File Offset: 0x00032468
		public unsafe Action moveCharacterAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_moveCharacterAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_moveCharacterAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x06006006 RID: 24582 RVA: 0x001DE860 File Offset: 0x001DCA60
		// (set) Token: 0x06006007 RID: 24583 RVA: 0x00034287 File Offset: 0x00032487
		public unsafe Action OnStartIdleExtraCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_OnStartIdleExtraCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_OnStartIdleExtraCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x06006008 RID: 24584 RVA: 0x001DE890 File Offset: 0x001DCA90
		// (set) Token: 0x06006009 RID: 24585 RVA: 0x000342A6 File Offset: 0x000324A6
		public unsafe Action OnStartWorkingExtraCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_OnStartWorkingExtraCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_OnStartWorkingExtraCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x0600600A RID: 24586 RVA: 0x001DE8C0 File Offset: 0x001DCAC0
		// (set) Token: 0x0600600B RID: 24587 RVA: 0x000342C5 File Offset: 0x000324C5
		public unsafe PartnerInfoBase partnerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_partnerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_partnerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x0600600C RID: 24588 RVA: 0x001DE8F0 File Offset: 0x001DCAF0
		// (set) Token: 0x0600600D RID: 24589 RVA: 0x000342E4 File Offset: 0x000324E4
		public unsafe int partnerIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_partnerIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_partnerIndex)) = value;
			}
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x0600600E RID: 24590 RVA: 0x001DE918 File Offset: 0x001DCB18
		// (set) Token: 0x0600600F RID: 24591 RVA: 0x000342FF File Offset: 0x000324FF
		public unsafe Il2CppSystem.Object partnerMovementAdditionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_partnerMovementAdditionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_partnerMovementAdditionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x06006010 RID: 24592 RVA: 0x001DE948 File Offset: 0x001DCB48
		// (set) Token: 0x06006011 RID: 24593 RVA: 0x0003431E File Offset: 0x0003251E
		public unsafe float partnerSleepStateProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_partnerSleepStateProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_partnerSleepStateProgress)) = value;
			}
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x06006012 RID: 24594 RVA: 0x001DE970 File Offset: 0x001DCB70
		// (set) Token: 0x06006013 RID: 24595 RVA: 0x00034339 File Offset: 0x00032539
		public unsafe PartnerBase.PartnerStatus partnerStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_partnerStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_partnerStatus)) = value;
			}
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x06006014 RID: 24596 RVA: 0x001DE998 File Offset: 0x001DCB98
		// (set) Token: 0x06006015 RID: 24597 RVA: 0x00034354 File Offset: 0x00032554
		public unsafe PartnerInfoBase.WorkState partnerWorkingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_partnerWorkingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_partnerWorkingState)) = value;
			}
		}

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x06006016 RID: 24598 RVA: 0x001DE9C0 File Offset: 0x001DCBC0
		// (set) Token: 0x06006017 RID: 24599 RVA: 0x0003436F File Offset: 0x0003256F
		public unsafe List<bool> shouldNotMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_shouldNotMove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr_shouldNotMove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x06006018 RID: 24600 RVA: 0x001DE9F0 File Offset: 0x001DCBF0
		// (set) Token: 0x06006019 RID: 24601 RVA: 0x0003438E File Offset: 0x0003258E
		public unsafe Func<PartnerManager.OrderChangeContext, GuestsManager.OrderBase, Il2CppSystem.Object, bool> _OnSystemStatusChangedShouldInterruptCurrentStateCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr__OnSystemStatusChangedShouldInterruptCurrentStateCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartnerManager.OrderChangeContext, GuestsManager.OrderBase, Il2CppSystem.Object, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr__OnSystemStatusChangedShouldInterruptCurrentStateCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x0600601A RID: 24602 RVA: 0x001DEA20 File Offset: 0x001DCC20
		// (set) Token: 0x0600601B RID: 24603 RVA: 0x000343AD File Offset: 0x000325AD
		public unsafe Action _CurrentStateInterrupt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr__CurrentStateInterrupt_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr__CurrentStateInterrupt_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x0600601C RID: 24604 RVA: 0x001DEA50 File Offset: 0x001DCC50
		// (set) Token: 0x0600601D RID: 24605 RVA: 0x000343CC File Offset: 0x000325CC
		public unsafe List<int> _CompanionPartnerIndexs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr__CompanionPartnerIndexs_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.NativeFieldInfoPtr__CompanionPartnerIndexs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003F48 RID: 16200
		private static readonly IntPtr NativeFieldInfoPtr_SPECIAL_EVENT_KEY;

		// Token: 0x04003F49 RID: 16201
		private static readonly IntPtr NativeFieldInfoPtr_PARTNER_STATUS_IDLE;

		// Token: 0x04003F4A RID: 16202
		private static readonly IntPtr NativeFieldInfoPtr_PARTNER_STATUS_STORING;

		// Token: 0x04003F4B RID: 16203
		private static readonly IntPtr NativeFieldInfoPtr_PARTNER_STATUS_SLEEPING;

		// Token: 0x04003F4C RID: 16204
		private static readonly IntPtr NativeFieldInfoPtr_EXTRA_STORAGE_MOVEMENT_OFFSET;

		// Token: 0x04003F4D RID: 16205
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04003F4E RID: 16206
		private static readonly IntPtr NativeFieldInfoPtr_controlledCharacter;

		// Token: 0x04003F4F RID: 16207
		private static readonly IntPtr NativeFieldInfoPtr_focusingOrder;

		// Token: 0x04003F50 RID: 16208
		private static readonly IntPtr NativeFieldInfoPtr_idlePosition;

		// Token: 0x04003F51 RID: 16209
		private static readonly IntPtr NativeFieldInfoPtr_m_PartnerAdditionalData;

		// Token: 0x04003F52 RID: 16210
		private static readonly IntPtr NativeFieldInfoPtr_moveCharacterAction;

		// Token: 0x04003F53 RID: 16211
		private static readonly IntPtr NativeFieldInfoPtr_OnStartIdleExtraCallback;

		// Token: 0x04003F54 RID: 16212
		private static readonly IntPtr NativeFieldInfoPtr_OnStartWorkingExtraCallback;

		// Token: 0x04003F55 RID: 16213
		private static readonly IntPtr NativeFieldInfoPtr_partnerData;

		// Token: 0x04003F56 RID: 16214
		private static readonly IntPtr NativeFieldInfoPtr_partnerIndex;

		// Token: 0x04003F57 RID: 16215
		private static readonly IntPtr NativeFieldInfoPtr_partnerMovementAdditionData;

		// Token: 0x04003F58 RID: 16216
		private static readonly IntPtr NativeFieldInfoPtr_partnerSleepStateProgress;

		// Token: 0x04003F59 RID: 16217
		private static readonly IntPtr NativeFieldInfoPtr_partnerStatus;

		// Token: 0x04003F5A RID: 16218
		private static readonly IntPtr NativeFieldInfoPtr_partnerWorkingState;

		// Token: 0x04003F5B RID: 16219
		private static readonly IntPtr NativeFieldInfoPtr_shouldNotMove;

		// Token: 0x04003F5C RID: 16220
		private static readonly IntPtr NativeFieldInfoPtr__OnSystemStatusChangedShouldInterruptCurrentStateCallback_k__BackingField;

		// Token: 0x04003F5D RID: 16221
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStateInterrupt_k__BackingField;

		// Token: 0x04003F5E RID: 16222
		private static readonly IntPtr NativeFieldInfoPtr__CompanionPartnerIndexs_k__BackingField;

		// Token: 0x04003F5F RID: 16223
		private static readonly IntPtr NativeMethodInfoPtr_get_FocusingOrderBase_Protected_get_OrderBase_0;

		// Token: 0x04003F60 RID: 16224
		private static readonly IntPtr NativeMethodInfoPtr_set_FocusingOrderBase_Protected_set_Void_OrderBase_0;

		// Token: 0x04003F61 RID: 16225
		private static readonly IntPtr NativeMethodInfoPtr_get_FocusingOrderNum_Public_get_Int32_0;

		// Token: 0x04003F62 RID: 16226
		private static readonly IntPtr NativeMethodInfoPtr_get_OnSystemStatusChangedShouldInterruptCurrentStateCallback_Private_get_Func_4_OrderChangeContext_OrderBase_Object_Boolean_0;

		// Token: 0x04003F63 RID: 16227
		private static readonly IntPtr NativeMethodInfoPtr_set_OnSystemStatusChangedShouldInterruptCurrentStateCallback_Protected_set_Void_Func_4_OrderChangeContext_OrderBase_Object_Boolean_0;

		// Token: 0x04003F64 RID: 16228
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStateInterrupt_Private_get_Action_0;

		// Token: 0x04003F65 RID: 16229
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStateInterrupt_Protected_set_Void_Action_0;

		// Token: 0x04003F66 RID: 16230
		private static readonly IntPtr NativeMethodInfoPtr_get_TileManager_Protected_get_TileManager_0;

		// Token: 0x04003F67 RID: 16231
		private static readonly IntPtr NativeMethodInfoPtr_get_Manager_Protected_get_PartnerManager_0;

		// Token: 0x04003F68 RID: 16232
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterPosition_Protected_get_Vector3_0;

		// Token: 0x04003F69 RID: 16233
		private static readonly IntPtr NativeMethodInfoPtr_get_ControlledCharacter_Public_get_AStarInputGeneratorComponent_0;

		// Token: 0x04003F6A RID: 16234
		private static readonly IntPtr NativeMethodInfoPtr_get_IdlePosition_Public_get_Vector3Int_0;

		// Token: 0x04003F6B RID: 16235
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerIndex_Public_get_Int32_0;

		// Token: 0x04003F6C RID: 16236
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerData_Public_get_PartnerInfoBase_0;

		// Token: 0x04003F6D RID: 16237
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerWorkingState_Public_get_WorkState_0;

		// Token: 0x04003F6E RID: 16238
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerSleepStateProgress_Public_get_Single_0;

		// Token: 0x04003F6F RID: 16239
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerStatusEnum_Public_get_PartnerStatus_0;

		// Token: 0x04003F70 RID: 16240
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraWorkSpeedRate_Public_get_Single_0;

		// Token: 0x04003F71 RID: 16241
		private static readonly IntPtr NativeMethodInfoPtr_get_CompanionPartnerIndexs_Public_get_List_1_Int32_0;

		// Token: 0x04003F72 RID: 16242
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraOffset_Public_get_Vector3_0;

		// Token: 0x04003F73 RID: 16243
		private static readonly IntPtr NativeMethodInfoPtr_ForceInterrupt_Public_Void_0;

		// Token: 0x04003F74 RID: 16244
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Vector3Int_AStarInputGeneratorComponent_PartnerInfoBase_Int32_0;

		// Token: 0x04003F75 RID: 16245
		private static readonly IntPtr NativeMethodInfoPtr_SetAdditionalData_Public_Void_T_Int32_0;

		// Token: 0x04003F76 RID: 16246
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStatus_Public_Void_WorkState_0;

		// Token: 0x04003F77 RID: 16247
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSleepingStatus_Private_Void_WorkState_0;

		// Token: 0x04003F78 RID: 16248
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentWorkStateProgress_Private_Void_Single_0;

		// Token: 0x04003F79 RID: 16249
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_New_Void_0;

		// Token: 0x04003F7A RID: 16250
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayIdleState_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04003F7B RID: 16251
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0;

		// Token: 0x04003F7C RID: 16252
		private static readonly IntPtr NativeMethodInfoPtr_ResetStatus_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04003F7D RID: 16253
		private static readonly IntPtr NativeMethodInfoPtr_TryAddCompanionPartnerBaseIndex_Public_Void_Int32_0;

		// Token: 0x04003F7E RID: 16254
		private static readonly IntPtr NativeMethodInfoPtr_NotifyOrderStatusChanged_Public_Void_Int32_OrderChangeContext_OrderBase_Object_0;

		// Token: 0x04003F7F RID: 16255
		private static readonly IntPtr NativeMethodInfoPtr_GetControlledTransform_Public_Transform_0;

		// Token: 0x04003F80 RID: 16256
		private static readonly IntPtr NativeMethodInfoPtr_GetPartnerType_Public_Abstract_Virtual_New_PartnerType_0;

		// Token: 0x04003F81 RID: 16257
		private static readonly IntPtr NativeMethodInfoPtr_PartnerLog_Protected_Void_String_0;

		// Token: 0x04003F82 RID: 16258
		private static readonly IntPtr NativeMethodInfoPtr_GetPartnerRevenueCut_Public_Single_Single_Boolean_0;

		// Token: 0x04003F83 RID: 16259
		private static readonly IntPtr NativeMethodInfoPtr_Take_Protected_Void_Sellable_0;

		// Token: 0x04003F84 RID: 16260
		private static readonly IntPtr NativeMethodInfoPtr_Send_Protected_Sellable_0;

		// Token: 0x04003F85 RID: 16261
		private static readonly IntPtr NativeMethodInfoPtr_InspectBuffer_Public_Sellable_0;

		// Token: 0x04003F86 RID: 16262
		private static readonly IntPtr NativeMethodInfoPtr_SetUIStatus_Protected_Void_Nullable_1_Int32_String_0;

		// Token: 0x04003F87 RID: 16263
		private static readonly IntPtr NativeMethodInfoPtr_IngredientInRange_Protected_Void_IEnumerable_1_Int32_0;

		// Token: 0x04003F88 RID: 16264
		private static readonly IntPtr NativeMethodInfoPtr_IngredientOutRange_Protected_Void_IEnumerable_1_Int32_0;

		// Token: 0x04003F89 RID: 16265
		private static readonly IntPtr NativeMethodInfoPtr_PlayIdleState_Public_Void_0;

		// Token: 0x04003F8A RID: 16266
		private static readonly IntPtr NativeMethodInfoPtr_OnMoveToIdlePositionCompelete_Private_Void_0;

		// Token: 0x04003F8B RID: 16267
		private static readonly IntPtr NativeMethodInfoPtr_OnStartSleeping_Private_Void_0;

		// Token: 0x04003F8C RID: 16268
		private static readonly IntPtr NativeMethodInfoPtr_OnStartWorking_Protected_Void_0;

		// Token: 0x04003F8D RID: 16269
		private static readonly IntPtr NativeMethodInfoPtr_PlayMoveToReturnInventoryState_Protected_Void_InventoryType_Nullable_1_Int32_Nullable_1_Vector3Int_Action_0;

		// Token: 0x04003F8E RID: 16270
		private static readonly IntPtr NativeMethodInfoPtr_PlayReturnToInventoryState_Protected_Virtual_New_Void_Action_0;

		// Token: 0x04003F8F RID: 16271
		private static readonly IntPtr NativeMethodInfoPtr_MoveCharacter_Public_Void_Vector3Int_Vector3_CharacterRotation_Action_0;

		// Token: 0x04003F90 RID: 16272
		private static readonly IntPtr NativeMethodInfoPtr_StopCharacter_Public_Void_0;

		// Token: 0x04003F91 RID: 16273
		private static readonly IntPtr NativeMethodInfoPtr_TryStopCharacterAndRecordAction_Public_Void_0;

		// Token: 0x04003F92 RID: 16274
		private static readonly IntPtr NativeMethodInfoPtr_TryToMoveAgain_Public_Void_0;

		// Token: 0x04003F93 RID: 16275
		private static readonly IntPtr NativeMethodInfoPtr_PlayAudio_Protected_Void_AudioClip_0;

		// Token: 0x04003F94 RID: 16276
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_AStarInputGeneratorComponent_0;

		// Token: 0x04003F95 RID: 16277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003F96 RID: 16278
		private static readonly IntPtr NativeMethodInfoPtr__PlayIdleState_b__84_0_Private_Void_0;

		// Token: 0x02000D65 RID: 3429
		public enum PartnerStatus : byte
		{
			// Token: 0x04009C48 RID: 40008
			Idle,
			// Token: 0x04009C49 RID: 40009
			CompletelyIdle,
			// Token: 0x04009C4A RID: 40010
			Working
		}

		// Token: 0x02000D66 RID: 3430
		public enum PartnerType : byte
		{
			// Token: 0x04009C4C RID: 40012
			Cook,
			// Token: 0x04009C4D RID: 40013
			Waitress,
			// Token: 0x04009C4E RID: 40014
			Barmaid,
			// Token: 0x04009C4F RID: 40015
			None,
			// Token: 0x04009C50 RID: 40016
			Boss
		}

		// Token: 0x02000D67 RID: 3431
		public enum InventoryType : byte
		{
			// Token: 0x04009C52 RID: 40018
			Food,
			// Token: 0x04009C53 RID: 40019
			Beverage
		}

		// Token: 0x02000D68 RID: 3432
		[ObfuscatedName("GameData.Profile.PartnerBase+<>c__DisplayClass88_0")]
		public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F570 RID: 62832 RVA: 0x0039F8DC File Offset: 0x0039DADC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass88_0()
			{
				Il2CppClassPointerStore<PartnerBase.__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "<>c__DisplayClass88_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass88_0>.NativeClassPtr);
				PartnerBase.__c__DisplayClass88_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass88_0>.NativeClassPtr, "<>4__this");
				PartnerBase.__c__DisplayClass88_0.NativeFieldInfoPtr_onReturnFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass88_0>.NativeClassPtr, "onReturnFinish");
				PartnerBase.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass88_0>.NativeClassPtr, 100683025);
				PartnerBase.__c__DisplayClass88_0.NativeMethodInfoPtr__PlayMoveToReturnInventoryState_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass88_0>.NativeClassPtr, 100683026);
			}

			// Token: 0x0600F571 RID: 62833 RVA: 0x0039F958 File Offset: 0x0039DB58
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass88_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass88_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F572 RID: 62834 RVA: 0x0039F994 File Offset: 0x0039DB94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PlayMoveToReturnInventoryState_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c__DisplayClass88_0.NativeMethodInfoPtr__PlayMoveToReturnInventoryState_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F573 RID: 62835 RVA: 0x00083DB5 File Offset: 0x00081FB5
			public __c__DisplayClass88_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FCB RID: 20427
			// (get) Token: 0x0600F574 RID: 62836 RVA: 0x0039F9C8 File Offset: 0x0039DBC8
			// (set) Token: 0x0600F575 RID: 62837 RVA: 0x00083DBE File Offset: 0x00081FBE
			public unsafe PartnerBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass88_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass88_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FCC RID: 20428
			// (get) Token: 0x0600F576 RID: 62838 RVA: 0x0039F9F8 File Offset: 0x0039DBF8
			// (set) Token: 0x0600F577 RID: 62839 RVA: 0x00083DDD File Offset: 0x00081FDD
			public unsafe Action onReturnFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass88_0.NativeFieldInfoPtr_onReturnFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass88_0.NativeFieldInfoPtr_onReturnFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C54 RID: 40020
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C55 RID: 40021
			private static readonly IntPtr NativeFieldInfoPtr_onReturnFinish;

			// Token: 0x04009C56 RID: 40022
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C57 RID: 40023
			private static readonly IntPtr NativeMethodInfoPtr__PlayMoveToReturnInventoryState_b__0_Internal_Void_0;
		}

		// Token: 0x02000D69 RID: 3433
		[ObfuscatedName("GameData.Profile.PartnerBase+<>c__DisplayClass89_0")]
		public sealed class __c__DisplayClass89_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F578 RID: 62840 RVA: 0x0039FA28 File Offset: 0x0039DC28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass89_0()
			{
				Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "<>c__DisplayClass89_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0>.NativeClassPtr);
				PartnerBase.__c__DisplayClass89_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0>.NativeClassPtr, "<>4__this");
				PartnerBase.__c__DisplayClass89_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0>.NativeClassPtr, "onFinish");
				PartnerBase.__c__DisplayClass89_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0>.NativeClassPtr, 100683027);
				PartnerBase.__c__DisplayClass89_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0>.NativeClassPtr, 100683028);
			}

			// Token: 0x0600F579 RID: 62841 RVA: 0x0039FAA4 File Offset: 0x0039DCA4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass89_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c__DisplayClass89_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F57A RID: 62842 RVA: 0x0039FAE0 File Offset: 0x0039DCE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236030, XrefRangeEnd = 236035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c__DisplayClass89_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F57B RID: 62843 RVA: 0x00083DFC File Offset: 0x00081FFC
			public __c__DisplayClass89_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FCD RID: 20429
			// (get) Token: 0x0600F57C RID: 62844 RVA: 0x0039FB20 File Offset: 0x0039DD20
			// (set) Token: 0x0600F57D RID: 62845 RVA: 0x00083E05 File Offset: 0x00082005
			public unsafe PartnerBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass89_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass89_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FCE RID: 20430
			// (get) Token: 0x0600F57E RID: 62846 RVA: 0x0039FB50 File Offset: 0x0039DD50
			// (set) Token: 0x0600F57F RID: 62847 RVA: 0x00083E24 File Offset: 0x00082024
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass89_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass89_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C58 RID: 40024
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C59 RID: 40025
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04009C5A RID: 40026
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C5B RID: 40027
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200109D RID: 4253
			[ObfuscatedName("GameData.Profile.PartnerBase+<>c__DisplayClass89_0+<<PlayReturnToInventoryState>g__EmployeeAddToInventoryCoroutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060121DA RID: 74202 RVA: 0x00422360 File Offset: 0x00420560
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0>.NativeClassPtr, "<<PlayReturnToInventoryState>g__EmployeeAddToInventoryCoroutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683029);
					PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683030);
					PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683031);
					PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683032);
					PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683033);
					PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683034);
				}

				// Token: 0x060121DB RID: 74203 RVA: 0x00422440 File Offset: 0x00420640
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060121DC RID: 74204 RVA: 0x00422488 File Offset: 0x00420688
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060121DD RID: 74205 RVA: 0x004224BC File Offset: 0x004206BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235998, XrefRangeEnd = 236024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005EA1 RID: 24225
				// (get) Token: 0x060121DE RID: 74206 RVA: 0x004224F8 File Offset: 0x004206F8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060121DF RID: 74207 RVA: 0x00422538 File Offset: 0x00420738
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236024, XrefRangeEnd = 236030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005EA2 RID: 24226
				// (get) Token: 0x060121E0 RID: 74208 RVA: 0x0042256C File Offset: 0x0042076C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060121E1 RID: 74209 RVA: 0x0009D690 File Offset: 0x0009B890
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E9E RID: 24222
				// (get) Token: 0x060121E2 RID: 74210 RVA: 0x004225AC File Offset: 0x004207AC
				// (set) Token: 0x060121E3 RID: 74211 RVA: 0x0009D699 File Offset: 0x0009B899
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E9F RID: 24223
				// (get) Token: 0x060121E4 RID: 74212 RVA: 0x004225D4 File Offset: 0x004207D4
				// (set) Token: 0x060121E5 RID: 74213 RVA: 0x0009D6B4 File Offset: 0x0009B8B4
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EA0 RID: 24224
				// (get) Token: 0x060121E6 RID: 74214 RVA: 0x00422604 File Offset: 0x00420804
				// (set) Token: 0x060121E7 RID: 74215 RVA: 0x0009D6D3 File Offset: 0x0009B8D3
				public unsafe PartnerBase.__c__DisplayClass89_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase.__c__DisplayClass89_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B78B RID: 46987
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B78C RID: 46988
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B78D RID: 46989
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B78E RID: 46990
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B78F RID: 46991
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B790 RID: 46992
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B791 RID: 46993
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B792 RID: 46994
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B793 RID: 46995
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D6A RID: 3434
		[ObfuscatedName("GameData.Profile.PartnerBase+<>c__DisplayClass90_0")]
		public sealed class __c__DisplayClass90_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F580 RID: 62848 RVA: 0x0039FB80 File Offset: 0x0039DD80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass90_0()
			{
				Il2CppClassPointerStore<PartnerBase.__c__DisplayClass90_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "<>c__DisplayClass90_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass90_0>.NativeClassPtr);
				PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass90_0>.NativeClassPtr, "<>4__this");
				PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass90_0>.NativeClassPtr, "dest");
				PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr_extraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass90_0>.NativeClassPtr, "extraOffset");
				PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr_onArrivalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass90_0>.NativeClassPtr, "onArrivalRotation");
				PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr_onArrivalCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass90_0>.NativeClassPtr, "onArrivalCallback");
				PartnerBase.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass90_0>.NativeClassPtr, 100683035);
				PartnerBase.__c__DisplayClass90_0.NativeMethodInfoPtr__MoveCharacter_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass90_0>.NativeClassPtr, 100683036);
			}

			// Token: 0x0600F581 RID: 62849 RVA: 0x0039FC38 File Offset: 0x0039DE38
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass90_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBase.__c__DisplayClass90_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F582 RID: 62850 RVA: 0x0039FC74 File Offset: 0x0039DE74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236035, XrefRangeEnd = 236042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MoveCharacter_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c__DisplayClass90_0.NativeMethodInfoPtr__MoveCharacter_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F583 RID: 62851 RVA: 0x00083E43 File Offset: 0x00082043
			public __c__DisplayClass90_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FCF RID: 20431
			// (get) Token: 0x0600F584 RID: 62852 RVA: 0x0039FCA8 File Offset: 0x0039DEA8
			// (set) Token: 0x0600F585 RID: 62853 RVA: 0x00083E4C File Offset: 0x0008204C
			public unsafe PartnerBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FD0 RID: 20432
			// (get) Token: 0x0600F586 RID: 62854 RVA: 0x0039FCD8 File Offset: 0x0039DED8
			// (set) Token: 0x0600F587 RID: 62855 RVA: 0x00083E6B File Offset: 0x0008206B
			public unsafe Vector3Int dest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr_dest);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr_dest)) = value;
				}
			}

			// Token: 0x17004FD1 RID: 20433
			// (get) Token: 0x0600F588 RID: 62856 RVA: 0x0039FD00 File Offset: 0x0039DF00
			// (set) Token: 0x0600F589 RID: 62857 RVA: 0x00083E86 File Offset: 0x00082086
			public unsafe Vector3 extraOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr_extraOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr_extraOffset)) = value;
				}
			}

			// Token: 0x17004FD2 RID: 20434
			// (get) Token: 0x0600F58A RID: 62858 RVA: 0x0039FD28 File Offset: 0x0039DF28
			// (set) Token: 0x0600F58B RID: 62859 RVA: 0x00083EA1 File Offset: 0x000820A1
			public unsafe DayScenePlayerInputGenerator.CharacterRotation onArrivalRotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr_onArrivalRotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr_onArrivalRotation)) = value;
				}
			}

			// Token: 0x17004FD3 RID: 20435
			// (get) Token: 0x0600F58C RID: 62860 RVA: 0x0039FD50 File Offset: 0x0039DF50
			// (set) Token: 0x0600F58D RID: 62861 RVA: 0x00083EBC File Offset: 0x000820BC
			public unsafe Action onArrivalCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr_onArrivalCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBase.__c__DisplayClass90_0.NativeFieldInfoPtr_onArrivalCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C5C RID: 40028
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C5D RID: 40029
			private static readonly IntPtr NativeFieldInfoPtr_dest;

			// Token: 0x04009C5E RID: 40030
			private static readonly IntPtr NativeFieldInfoPtr_extraOffset;

			// Token: 0x04009C5F RID: 40031
			private static readonly IntPtr NativeFieldInfoPtr_onArrivalRotation;

			// Token: 0x04009C60 RID: 40032
			private static readonly IntPtr NativeFieldInfoPtr_onArrivalCallback;

			// Token: 0x04009C61 RID: 40033
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C62 RID: 40034
			private static readonly IntPtr NativeMethodInfoPtr__MoveCharacter_b__0_Internal_Void_0;
		}

		// Token: 0x02000D6B RID: 3435
		[ObfuscatedName("GameData.Profile.PartnerBase+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F58E RID: 62862 RVA: 0x0039FD80 File Offset: 0x0039DF80
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PartnerBase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBase.__c>.NativeClassPtr);
				PartnerBase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c>.NativeClassPtr, "<>9");
				PartnerBase.__c.NativeFieldInfoPtr___9__90_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c>.NativeClassPtr, "<>9__90_1");
				PartnerBase.__c.NativeFieldInfoPtr___9__93_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBase.__c>.NativeClassPtr, "<>9__93_0");
				PartnerBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c>.NativeClassPtr, 100683038);
				PartnerBase.__c.NativeMethodInfoPtr__MoveCharacter_b__90_1_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c>.NativeClassPtr, 100683039);
				PartnerBase.__c.NativeMethodInfoPtr__TryToMoveAgain_b__93_0_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBase.__c>.NativeClassPtr, 100683040);
			}

			// Token: 0x0600F58F RID: 62863 RVA: 0x0039FE24 File Offset: 0x0039E024
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F590 RID: 62864 RVA: 0x0039FE60 File Offset: 0x0039E060
			[CallerCount(0)]
			public unsafe bool _MoveCharacter_b__90_1(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c.NativeMethodInfoPtr__MoveCharacter_b__90_1_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F591 RID: 62865 RVA: 0x0039FEAC File Offset: 0x0039E0AC
			[CallerCount(0)]
			public unsafe bool _TryToMoveAgain_b__93_0(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBase.__c.NativeMethodInfoPtr__TryToMoveAgain_b__93_0_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F592 RID: 62866 RVA: 0x00083EDB File Offset: 0x000820DB
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004FD4 RID: 20436
			// (get) Token: 0x0600F593 RID: 62867 RVA: 0x0039FEF8 File Offset: 0x0039E0F8
			// (set) Token: 0x0600F594 RID: 62868 RVA: 0x00083EE4 File Offset: 0x000820E4
			public unsafe static PartnerBase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FD5 RID: 20437
			// (get) Token: 0x0600F595 RID: 62869 RVA: 0x0039FF20 File Offset: 0x0039E120
			// (set) Token: 0x0600F596 RID: 62870 RVA: 0x00083EF6 File Offset: 0x000820F6
			public unsafe static Func<bool, bool> __9__90_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBase.__c.NativeFieldInfoPtr___9__90_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBase.__c.NativeFieldInfoPtr___9__90_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004FD6 RID: 20438
			// (get) Token: 0x0600F597 RID: 62871 RVA: 0x0039FF48 File Offset: 0x0039E148
			// (set) Token: 0x0600F598 RID: 62872 RVA: 0x00083F08 File Offset: 0x00082108
			public unsafe static Func<bool, bool> __9__93_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBase.__c.NativeFieldInfoPtr___9__93_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBase.__c.NativeFieldInfoPtr___9__93_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C63 RID: 40035
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009C64 RID: 40036
			private static readonly IntPtr NativeFieldInfoPtr___9__90_1;

			// Token: 0x04009C65 RID: 40037
			private static readonly IntPtr NativeFieldInfoPtr___9__93_0;

			// Token: 0x04009C66 RID: 40038
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C67 RID: 40039
			private static readonly IntPtr NativeMethodInfoPtr__MoveCharacter_b__90_1_Internal_Boolean_Boolean_0;

			// Token: 0x04009C68 RID: 40040
			private static readonly IntPtr NativeMethodInfoPtr__TryToMoveAgain_b__93_0_Internal_Boolean_Boolean_0;
		}

		// Token: 0x02000D6C RID: 3436
		private sealed class MethodInfoStoreGeneric_SetAdditionalData_Public_Void_T_Int32_0<T>
		{
			// Token: 0x04009C69 RID: 40041
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PartnerBase.NativeMethodInfoPtr_SetAdditionalData_Public_Void_T_Int32_0, Il2CppClassPointerStore<PartnerBase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
