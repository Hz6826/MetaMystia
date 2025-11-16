using System;
using Common.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using GameData.RunTime.Common;
using GameData.RunTime.Common.AchievementSystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x020001AB RID: 427
	public class SpecialGuestsController : GuestGroupController
	{
		// Token: 0x060030E3 RID: 12515 RVA: 0x001428A4 File Offset: 0x00140AA4
		// Note: this type is marked as 'beforefieldinit'.
		static SpecialGuestsController()
		{
			Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.GuestManagementUtility", "SpecialGuestsController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr);
			SpecialGuestsController.NativeFieldInfoPtr_KEINE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "KEINE_ID");
			SpecialGuestsController.NativeFieldInfoPtr_TEWI_HARD_SELL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "TEWI_HARD_SELL");
			SpecialGuestsController.NativeFieldInfoPtr_TEWI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "TEWI");
			SpecialGuestsController.NativeFieldInfoPtr_MEILING_BUFF_EXTRA_KIZUNA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "MEILING_BUFF_EXTRA_KIZUNA");
			SpecialGuestsController.NativeFieldInfoPtr_ratingBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "ratingBuffer");
			SpecialGuestsController.NativeFieldInfoPtr_KOISHI_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "KOISHI_ID");
			SpecialGuestsController.NativeFieldInfoPtr__OnPostLeaveSpellCardCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "<OnPostLeaveSpellCardCallback>k__BackingField");
			SpecialGuestsController.NativeFieldInfoPtr__CheckCanUseSpellCardCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "<CheckCanUseSpellCardCallback>k__BackingField");
			SpecialGuestsController.NativeFieldInfoPtr__SpecialGuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "<SpecialGuest>k__BackingField");
			SpecialGuestsController.NativeFieldInfoPtr__GuestControllerSpawnType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "<GuestControllerSpawnType>k__BackingField");
			SpecialGuestsController.NativeFieldInfoPtr__IsControlled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "<IsControlled>k__BackingField");
			SpecialGuestsController.NativeFieldInfoPtr__OrderFoodTextOverrideCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "<OrderFoodTextOverrideCallback>k__BackingField");
			SpecialGuestsController.NativeFieldInfoPtr__OrderBevTextOverrideCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "<OrderBevTextOverrideCallback>k__BackingField");
			SpecialGuestsController.NativeMethodInfoPtr__ctor_Public_Void_SpecialGuest_Nullable_1_Vector3_Action_1_AStarInputGeneratorComponent_LeaveType_GuestSpawnType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672127);
			SpecialGuestsController.NativeMethodInfoPtr__ctor_Public_Void_SpecialGuest_Action_1_AStarInputGeneratorComponent_LeaveType_GuestSpawnType_Il2CppReferenceArray_1_AStarInputGeneratorComponent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672128);
			SpecialGuestsController.NativeMethodInfoPtr_get_OnPostLeaveSpellCardCallback_Public_get_Action_2_SpecialGuestsController_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672129);
			SpecialGuestsController.NativeMethodInfoPtr_set_OnPostLeaveSpellCardCallback_Public_set_Void_Action_2_SpecialGuestsController_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672130);
			SpecialGuestsController.NativeMethodInfoPtr_get_CheckCanUseSpellCardCallback_Public_get_CanUseSpellCardDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672131);
			SpecialGuestsController.NativeMethodInfoPtr_set_CheckCanUseSpellCardCallback_Public_set_Void_CanUseSpellCardDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672132);
			SpecialGuestsController.NativeMethodInfoPtr_get_SpecialGuest_Public_get_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672133);
			SpecialGuestsController.NativeMethodInfoPtr_set_SpecialGuest_Public_set_Void_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672134);
			SpecialGuestsController.NativeMethodInfoPtr_get_GuestControllerSpawnType_Public_get_GuestSpawnType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672135);
			SpecialGuestsController.NativeMethodInfoPtr_set_GuestControllerSpawnType_Private_set_Void_GuestSpawnType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672136);
			SpecialGuestsController.NativeMethodInfoPtr_get_IsHerself_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672137);
			SpecialGuestsController.NativeMethodInfoPtr_get_IsControlled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672138);
			SpecialGuestsController.NativeMethodInfoPtr_get_EvaluateLikeFoodTags_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672139);
			SpecialGuestsController.NativeMethodInfoPtr_get_EvaluateHateFoodTags_Public_Virtual_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672140);
			SpecialGuestsController.NativeMethodInfoPtr_get_OrderFoodTextOverrideCallback_Public_get_Func_3_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672141);
			SpecialGuestsController.NativeMethodInfoPtr_set_OrderFoodTextOverrideCallback_Public_set_Void_Func_3_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672142);
			SpecialGuestsController.NativeMethodInfoPtr_get_OrderBevTextOverrideCallback_Public_get_Func_3_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672143);
			SpecialGuestsController.NativeMethodInfoPtr_set_OrderBevTextOverrideCallback_Public_set_Void_Func_3_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672144);
			SpecialGuestsController.NativeMethodInfoPtr_GetAllGuests_Public_Virtual_IEnumerable_1_GuestBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672145);
			SpecialGuestsController.NativeMethodInfoPtr_OnGetGuestName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672146);
			SpecialGuestsController.NativeMethodInfoPtr_OnRequestIdleDialog_Public_Virtual_String_byref_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672147);
			SpecialGuestsController.NativeMethodInfoPtr_GetNoMoneyDialogIndex_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672148);
			SpecialGuestsController.NativeMethodInfoPtr_GetNoMoneyAngryDialogIndex_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672149);
			SpecialGuestsController.NativeMethodInfoPtr_GetRepellDialogIndex_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672150);
			SpecialGuestsController.NativeMethodInfoPtr_GetSeenRepellDialogIndex_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672151);
			SpecialGuestsController.NativeMethodInfoPtr_GetEvaluationDialog_Protected_Virtual_String_Int32_byref_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672152);
			SpecialGuestsController.NativeMethodInfoPtr_PostGenerateOrder_Public_Virtual_OrderBase_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672153);
			SpecialGuestsController.NativeMethodInfoPtr_FillterTags_Private_Boolean_Int32_Func_2_PopType_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672154);
			SpecialGuestsController.NativeMethodInfoPtr_GetOrderFoodText_Public_String_SpecialOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672155);
			SpecialGuestsController.NativeMethodInfoPtr_GetOrderBevText_Public_String_SpecialOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672156);
			SpecialGuestsController.NativeMethodInfoPtr_TriggerPositiveBuff_Public_Void_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672157);
			SpecialGuestsController.NativeMethodInfoPtr_GetSpellExecutionContext_Private_SpellExecutionContext_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672158);
			SpecialGuestsController.NativeMethodInfoPtr_get_GuestSpellBase_Private_get_SpellBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672159);
			SpecialGuestsController.NativeMethodInfoPtr_TriggerNegativeBuff_Public_Void_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672160);
			SpecialGuestsController.NativeMethodInfoPtr_TriggerLeaveBuff_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672161);
			SpecialGuestsController.NativeMethodInfoPtr_TriggerPostLeaveCallback_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672162);
			SpecialGuestsController.NativeMethodInfoPtr_IfCanUseSpellCard_Private_Boolean_SpellType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672163);
			SpecialGuestsController.NativeMethodInfoPtr_PostEvaluation_Public_Virtual_Void_EvaluationResult_Action_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672164);
			SpecialGuestsController.NativeMethodInfoPtr_TryAlterKizunaValue_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, 100672165);
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x00142CE4 File Offset: 0x00140EE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111655, RefRangeEnd = 111656, XrefRangeStart = 111614, XrefRangeEnd = 111655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialGuestsController(SpecialGuest specialGuests, Nullable<Vector3> overrideSpawnPosition, Action<AStarInputGeneratorComponent> postprocessCharacterCallback, GuestGroupController.LeaveType leaveType, SpecialGuestsController.GuestSpawnType guestSpawnType) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuests);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideSpawnPosition));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postprocessCharacterCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guestSpawnType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr__ctor_Public_Void_SpecialGuest_Nullable_1_Vector3_Action_1_AStarInputGeneratorComponent_LeaveType_GuestSpawnType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x00142D74 File Offset: 0x00140F74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111682, RefRangeEnd = 111684, XrefRangeStart = 111656, XrefRangeEnd = 111682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialGuestsController(SpecialGuest specialGuests, Action<AStarInputGeneratorComponent> postprocessCharacterCallback, GuestGroupController.LeaveType leaveType, SpecialGuestsController.GuestSpawnType guestSpawnType, Il2CppReferenceArray<AStarInputGeneratorComponent> guestInstances, bool isDominated = false) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialGuests);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postprocessCharacterCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guestSpawnType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestInstances);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDominated;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr__ctor_Public_Void_SpecialGuest_Action_1_AStarInputGeneratorComponent_LeaveType_GuestSpawnType_Il2CppReferenceArray_1_AStarInputGeneratorComponent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x060030E6 RID: 12518 RVA: 0x00142E10 File Offset: 0x00141010
		// (set) Token: 0x060030E7 RID: 12519 RVA: 0x00142E50 File Offset: 0x00141050
		public unsafe Action<SpecialGuestsController, Action> OnPostLeaveSpellCardCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_get_OnPostLeaveSpellCardCallback_Public_get_Action_2_SpecialGuestsController_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<SpecialGuestsController, Action>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111684, XrefRangeEnd = 111685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_set_OnPostLeaveSpellCardCallback_Public_set_Void_Action_2_SpecialGuestsController_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x060030E8 RID: 12520 RVA: 0x00142E94 File Offset: 0x00141094
		// (set) Token: 0x060030E9 RID: 12521 RVA: 0x00142ED4 File Offset: 0x001410D4
		public unsafe SpecialGuestsController.CanUseSpellCardDelegate CheckCanUseSpellCardCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_get_CheckCanUseSpellCardCallback_Public_get_CanUseSpellCardDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController.CanUseSpellCardDelegate>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111685, XrefRangeEnd = 111686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_set_CheckCanUseSpellCardCallback_Public_set_Void_CanUseSpellCardDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x060030EA RID: 12522 RVA: 0x00142F18 File Offset: 0x00141118
		// (set) Token: 0x060030EB RID: 12523 RVA: 0x00142F58 File Offset: 0x00141158
		public unsafe SpecialGuest SpecialGuest
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_get_SpecialGuest_Public_get_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_set_SpecialGuest_Public_set_Void_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x060030EC RID: 12524 RVA: 0x00142F9C File Offset: 0x0014119C
		// (set) Token: 0x060030ED RID: 12525 RVA: 0x00142FD8 File Offset: 0x001411D8
		public unsafe SpecialGuestsController.GuestSpawnType GuestControllerSpawnType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_get_GuestControllerSpawnType_Public_get_GuestSpawnType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_set_GuestControllerSpawnType_Private_set_Void_GuestSpawnType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x00143018 File Offset: 0x00141218
		public unsafe bool IsHerself
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 111686, RefRangeEnd = 111690, XrefRangeStart = 111686, XrefRangeEnd = 111686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_get_IsHerself_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x00143054 File Offset: 0x00141254
		public unsafe bool IsControlled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_get_IsControlled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x00143090 File Offset: 0x00141290
		public unsafe override Il2CppStructArray<int> EvaluateLikeFoodTags
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111690, XrefRangeEnd = 111693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestsController.NativeMethodInfoPtr_get_EvaluateLikeFoodTags_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x001430DC File Offset: 0x001412DC
		public unsafe override Il2CppStructArray<int> EvaluateHateFoodTags
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111693, XrefRangeEnd = 111696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestsController.NativeMethodInfoPtr_get_EvaluateHateFoodTags_Public_Virtual_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x00143128 File Offset: 0x00141328
		// (set) Token: 0x060030F3 RID: 12531 RVA: 0x00143168 File Offset: 0x00141368
		public unsafe Func<int, string, string> OrderFoodTextOverrideCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_get_OrderFoodTextOverrideCallback_Public_get_Func_3_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111696, XrefRangeEnd = 111697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_set_OrderFoodTextOverrideCallback_Public_set_Void_Func_3_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x001431AC File Offset: 0x001413AC
		// (set) Token: 0x060030F5 RID: 12533 RVA: 0x001431EC File Offset: 0x001413EC
		public unsafe Func<int, string, string> OrderBevTextOverrideCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_get_OrderBevTextOverrideCallback_Public_get_Func_3_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_set_OrderBevTextOverrideCallback_Public_set_Void_Func_3_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x00143230 File Offset: 0x00141430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111697, XrefRangeEnd = 111702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<GuestBase> GetAllGuests()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestsController.NativeMethodInfoPtr_GetAllGuests_Public_Virtual_IEnumerable_1_GuestBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<GuestBase>>(intPtr3) : null;
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x0014327C File Offset: 0x0014147C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111702, XrefRangeEnd = 111704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGetGuestName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestsController.NativeMethodInfoPtr_OnGetGuestName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x001432C0 File Offset: 0x001414C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111704, XrefRangeEnd = 111721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnRequestIdleDialog(out Transform speaker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestsController.NativeMethodInfoPtr_OnRequestIdleDialog_Public_Virtual_String_byref_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			speaker = ((intPtr4 == 0) ? null : new Transform(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x00143324 File Offset: 0x00141524
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48412, RefRangeEnd = 48414, XrefRangeStart = 48412, XrefRangeEnd = 48414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetNoMoneyDialogIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestsController.NativeMethodInfoPtr_GetNoMoneyDialogIndex_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x0014336C File Offset: 0x0014156C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48392, RefRangeEnd = 48393, XrefRangeStart = 48392, XrefRangeEnd = 48393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetNoMoneyAngryDialogIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestsController.NativeMethodInfoPtr_GetNoMoneyAngryDialogIndex_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x001433B4 File Offset: 0x001415B4
		[CallerCount(0)]
		public unsafe override int GetRepellDialogIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestsController.NativeMethodInfoPtr_GetRepellDialogIndex_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x001433FC File Offset: 0x001415FC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 111721, RefRangeEnd = 111742, XrefRangeStart = 111721, XrefRangeEnd = 111721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetSeenRepellDialogIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestsController.NativeMethodInfoPtr_GetSeenRepellDialogIndex_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x00143444 File Offset: 0x00141644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111742, XrefRangeEnd = 111751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEvaluationDialog(int evalulationIndex, out Transform speaker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evalulationIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestsController.NativeMethodInfoPtr_GetEvaluationDialog_Protected_Virtual_String_Int32_byref_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			speaker = ((intPtr4 == 0) ? null : new Transform(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x001434B8 File Offset: 0x001416B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111751, XrefRangeEnd = 111822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GuestsManager.OrderBase PostGenerateOrder(bool isFreeOrder, out string orderGenerationMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isFreeOrder;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestsController.NativeMethodInfoPtr_PostGenerateOrder_Public_Virtual_OrderBase_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			orderGenerationMessage = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr4) : null;
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x0014352C File Offset: 0x0014172C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111822, XrefRangeEnd = 111830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FillterTags(int tagId, Func<RunTimePlayerData.PopType, Il2CppStructArray<int>> onGetPopSystemDataCallback, Il2CppStructArray<int> popTags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tagId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onGetPopSystemDataCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(popTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_FillterTags_Private_Boolean_Int32_Func_2_PopType_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x0014359C File Offset: 0x0014179C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111831, RefRangeEnd = 111832, XrefRangeStart = 111830, XrefRangeEnd = 111831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetOrderFoodText(GuestsManager.SpecialOrder specialOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialOrder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_GetOrderFoodText_Public_String_SpecialOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x001435E4 File Offset: 0x001417E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111833, RefRangeEnd = 111834, XrefRangeStart = 111832, XrefRangeEnd = 111833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetOrderBevText(GuestsManager.SpecialOrder specialOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialOrder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_GetOrderBevText_Public_String_SpecialOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x0014362C File Offset: 0x0014182C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 111880, RefRangeEnd = 111883, XrefRangeStart = 111834, XrefRangeEnd = 111880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerPositiveBuff(Action onFinish = null, bool realSpawn = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref realSpawn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_TriggerPositiveBuff_Public_Void_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x0014367C File Offset: 0x0014187C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 111888, RefRangeEnd = 111891, XrefRangeStart = 111883, XrefRangeEnd = 111888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpellExecutionContext GetSpellExecutionContext(Action onFinish, bool shouldRecordSpellNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldRecordSpellNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_GetSpellExecutionContext_Private_SpellExecutionContext_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr3) : null;
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x001436DC File Offset: 0x001418DC
		public unsafe SpellBase GuestSpellBase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111891, XrefRangeEnd = 111893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_get_GuestSpellBase_Private_get_SpellBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr3) : null;
			}
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x0014371C File Offset: 0x0014191C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111916, RefRangeEnd = 111918, XrefRangeStart = 111893, XrefRangeEnd = 111916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerNegativeBuff(Action onFinish = null, bool realSpawn = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref realSpawn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_TriggerNegativeBuff_Public_Void_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x0014376C File Offset: 0x0014196C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111934, RefRangeEnd = 111935, XrefRangeStart = 111918, XrefRangeEnd = 111934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerLeaveBuff(Action onFinish = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_TriggerLeaveBuff_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x001437B0 File Offset: 0x001419B0
		[CallerCount(0)]
		public unsafe void TriggerPostLeaveCallback(Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_TriggerPostLeaveCallback_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x001437F4 File Offset: 0x001419F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 111945, RefRangeEnd = 111948, XrefRangeStart = 111935, XrefRangeEnd = 111945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IfCanUseSpellCard(SpecialGuestsController.SpellType spellType, Action onFinish = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spellType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_IfCanUseSpellCard_Private_Boolean_SpellType_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x00143850 File Offset: 0x00141A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111948, XrefRangeEnd = 111973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostEvaluation(GuestGroupController.EvaluationResult evaluationType, Action onFinish, bool finishedByPartner, bool obtainedExGoodRatingWithModifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evaluationType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finishedByPartner;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref obtainedExGoodRatingWithModifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestsController.NativeMethodInfoPtr_PostEvaluation_Public_Virtual_Void_EvaluationResult_Action_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x001438C8 File Offset: 0x00141AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111994, RefRangeEnd = 111995, XrefRangeStart = 111973, XrefRangeEnd = 111994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryAlterKizunaValue(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.NativeMethodInfoPtr_TryAlterKizunaValue_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x0001BC78 File Offset: 0x00019E78
		public SpecialGuestsController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x00143908 File Offset: 0x00141B08
		// (set) Token: 0x0600310D RID: 12557 RVA: 0x0001BC81 File Offset: 0x00019E81
		public unsafe static int KEINE_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SpecialGuestsController.NativeFieldInfoPtr_KEINE_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpecialGuestsController.NativeFieldInfoPtr_KEINE_ID, (void*)(&value));
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x00143924 File Offset: 0x00141B24
		// (set) Token: 0x0600310F RID: 12559 RVA: 0x0001BC8F File Offset: 0x00019E8F
		public unsafe static int TEWI_HARD_SELL
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SpecialGuestsController.NativeFieldInfoPtr_TEWI_HARD_SELL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpecialGuestsController.NativeFieldInfoPtr_TEWI_HARD_SELL, (void*)(&value));
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x00143940 File Offset: 0x00141B40
		// (set) Token: 0x06003111 RID: 12561 RVA: 0x0001BC9D File Offset: 0x00019E9D
		public unsafe static int TEWI
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SpecialGuestsController.NativeFieldInfoPtr_TEWI, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpecialGuestsController.NativeFieldInfoPtr_TEWI, (void*)(&value));
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06003112 RID: 12562 RVA: 0x0014395C File Offset: 0x00141B5C
		// (set) Token: 0x06003113 RID: 12563 RVA: 0x0001BCAB File Offset: 0x00019EAB
		public unsafe static float MEILING_BUFF_EXTRA_KIZUNA
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpecialGuestsController.NativeFieldInfoPtr_MEILING_BUFF_EXTRA_KIZUNA, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpecialGuestsController.NativeFieldInfoPtr_MEILING_BUFF_EXTRA_KIZUNA, (void*)(&value));
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06003114 RID: 12564 RVA: 0x00143978 File Offset: 0x00141B78
		// (set) Token: 0x06003115 RID: 12565 RVA: 0x0001BCB9 File Offset: 0x00019EB9
		public unsafe bool ratingBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr_ratingBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr_ratingBuffer)) = value;
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x001439A0 File Offset: 0x00141BA0
		// (set) Token: 0x06003117 RID: 12567 RVA: 0x0001BCD4 File Offset: 0x00019ED4
		public unsafe static int KOISHI_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SpecialGuestsController.NativeFieldInfoPtr_KOISHI_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpecialGuestsController.NativeFieldInfoPtr_KOISHI_ID, (void*)(&value));
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x06003118 RID: 12568 RVA: 0x001439BC File Offset: 0x00141BBC
		// (set) Token: 0x06003119 RID: 12569 RVA: 0x0001BCE2 File Offset: 0x00019EE2
		public unsafe Action<SpecialGuestsController, Action> _OnPostLeaveSpellCardCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__OnPostLeaveSpellCardCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpecialGuestsController, Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__OnPostLeaveSpellCardCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x0600311A RID: 12570 RVA: 0x001439EC File Offset: 0x00141BEC
		// (set) Token: 0x0600311B RID: 12571 RVA: 0x0001BD01 File Offset: 0x00019F01
		public unsafe SpecialGuestsController.CanUseSpellCardDelegate _CheckCanUseSpellCardCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__CheckCanUseSpellCardCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController.CanUseSpellCardDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__CheckCanUseSpellCardCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x0600311C RID: 12572 RVA: 0x00143A1C File Offset: 0x00141C1C
		// (set) Token: 0x0600311D RID: 12573 RVA: 0x0001BD20 File Offset: 0x00019F20
		public unsafe SpecialGuest _SpecialGuest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__SpecialGuest_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__SpecialGuest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x0600311E RID: 12574 RVA: 0x00143A4C File Offset: 0x00141C4C
		// (set) Token: 0x0600311F RID: 12575 RVA: 0x0001BD3F File Offset: 0x00019F3F
		public unsafe SpecialGuestsController.GuestSpawnType _GuestControllerSpawnType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__GuestControllerSpawnType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__GuestControllerSpawnType_k__BackingField)) = value;
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06003120 RID: 12576 RVA: 0x00143A74 File Offset: 0x00141C74
		// (set) Token: 0x06003121 RID: 12577 RVA: 0x0001BD5A File Offset: 0x00019F5A
		public unsafe bool _IsControlled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__IsControlled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__IsControlled_k__BackingField)) = value;
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x00143A9C File Offset: 0x00141C9C
		// (set) Token: 0x06003123 RID: 12579 RVA: 0x0001BD75 File Offset: 0x00019F75
		public unsafe Func<int, string, string> _OrderFoodTextOverrideCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__OrderFoodTextOverrideCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__OrderFoodTextOverrideCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x00143ACC File Offset: 0x00141CCC
		// (set) Token: 0x06003125 RID: 12581 RVA: 0x0001BD94 File Offset: 0x00019F94
		public unsafe Func<int, string, string> _OrderBevTextOverrideCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__OrderBevTextOverrideCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.NativeFieldInfoPtr__OrderBevTextOverrideCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020AD RID: 8365
		private static readonly IntPtr NativeFieldInfoPtr_KEINE_ID;

		// Token: 0x040020AE RID: 8366
		private static readonly IntPtr NativeFieldInfoPtr_TEWI_HARD_SELL;

		// Token: 0x040020AF RID: 8367
		private static readonly IntPtr NativeFieldInfoPtr_TEWI;

		// Token: 0x040020B0 RID: 8368
		private static readonly IntPtr NativeFieldInfoPtr_MEILING_BUFF_EXTRA_KIZUNA;

		// Token: 0x040020B1 RID: 8369
		private static readonly IntPtr NativeFieldInfoPtr_ratingBuffer;

		// Token: 0x040020B2 RID: 8370
		private static readonly IntPtr NativeFieldInfoPtr_KOISHI_ID;

		// Token: 0x040020B3 RID: 8371
		private static readonly IntPtr NativeFieldInfoPtr__OnPostLeaveSpellCardCallback_k__BackingField;

		// Token: 0x040020B4 RID: 8372
		private static readonly IntPtr NativeFieldInfoPtr__CheckCanUseSpellCardCallback_k__BackingField;

		// Token: 0x040020B5 RID: 8373
		private static readonly IntPtr NativeFieldInfoPtr__SpecialGuest_k__BackingField;

		// Token: 0x040020B6 RID: 8374
		private static readonly IntPtr NativeFieldInfoPtr__GuestControllerSpawnType_k__BackingField;

		// Token: 0x040020B7 RID: 8375
		private static readonly IntPtr NativeFieldInfoPtr__IsControlled_k__BackingField;

		// Token: 0x040020B8 RID: 8376
		private static readonly IntPtr NativeFieldInfoPtr__OrderFoodTextOverrideCallback_k__BackingField;

		// Token: 0x040020B9 RID: 8377
		private static readonly IntPtr NativeFieldInfoPtr__OrderBevTextOverrideCallback_k__BackingField;

		// Token: 0x040020BA RID: 8378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SpecialGuest_Nullable_1_Vector3_Action_1_AStarInputGeneratorComponent_LeaveType_GuestSpawnType_0;

		// Token: 0x040020BB RID: 8379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SpecialGuest_Action_1_AStarInputGeneratorComponent_LeaveType_GuestSpawnType_Il2CppReferenceArray_1_AStarInputGeneratorComponent_Boolean_0;

		// Token: 0x040020BC RID: 8380
		private static readonly IntPtr NativeMethodInfoPtr_get_OnPostLeaveSpellCardCallback_Public_get_Action_2_SpecialGuestsController_Action_0;

		// Token: 0x040020BD RID: 8381
		private static readonly IntPtr NativeMethodInfoPtr_set_OnPostLeaveSpellCardCallback_Public_set_Void_Action_2_SpecialGuestsController_Action_0;

		// Token: 0x040020BE RID: 8382
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckCanUseSpellCardCallback_Public_get_CanUseSpellCardDelegate_0;

		// Token: 0x040020BF RID: 8383
		private static readonly IntPtr NativeMethodInfoPtr_set_CheckCanUseSpellCardCallback_Public_set_Void_CanUseSpellCardDelegate_0;

		// Token: 0x040020C0 RID: 8384
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuest_Public_get_SpecialGuest_0;

		// Token: 0x040020C1 RID: 8385
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuest_Public_set_Void_SpecialGuest_0;

		// Token: 0x040020C2 RID: 8386
		private static readonly IntPtr NativeMethodInfoPtr_get_GuestControllerSpawnType_Public_get_GuestSpawnType_0;

		// Token: 0x040020C3 RID: 8387
		private static readonly IntPtr NativeMethodInfoPtr_set_GuestControllerSpawnType_Private_set_Void_GuestSpawnType_0;

		// Token: 0x040020C4 RID: 8388
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHerself_Public_get_Boolean_0;

		// Token: 0x040020C5 RID: 8389
		private static readonly IntPtr NativeMethodInfoPtr_get_IsControlled_Public_get_Boolean_0;

		// Token: 0x040020C6 RID: 8390
		private static readonly IntPtr NativeMethodInfoPtr_get_EvaluateLikeFoodTags_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040020C7 RID: 8391
		private static readonly IntPtr NativeMethodInfoPtr_get_EvaluateHateFoodTags_Public_Virtual_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040020C8 RID: 8392
		private static readonly IntPtr NativeMethodInfoPtr_get_OrderFoodTextOverrideCallback_Public_get_Func_3_Int32_String_String_0;

		// Token: 0x040020C9 RID: 8393
		private static readonly IntPtr NativeMethodInfoPtr_set_OrderFoodTextOverrideCallback_Public_set_Void_Func_3_Int32_String_String_0;

		// Token: 0x040020CA RID: 8394
		private static readonly IntPtr NativeMethodInfoPtr_get_OrderBevTextOverrideCallback_Public_get_Func_3_Int32_String_String_0;

		// Token: 0x040020CB RID: 8395
		private static readonly IntPtr NativeMethodInfoPtr_set_OrderBevTextOverrideCallback_Public_set_Void_Func_3_Int32_String_String_0;

		// Token: 0x040020CC RID: 8396
		private static readonly IntPtr NativeMethodInfoPtr_GetAllGuests_Public_Virtual_IEnumerable_1_GuestBase_0;

		// Token: 0x040020CD RID: 8397
		private static readonly IntPtr NativeMethodInfoPtr_OnGetGuestName_Public_Virtual_String_0;

		// Token: 0x040020CE RID: 8398
		private static readonly IntPtr NativeMethodInfoPtr_OnRequestIdleDialog_Public_Virtual_String_byref_Transform_0;

		// Token: 0x040020CF RID: 8399
		private static readonly IntPtr NativeMethodInfoPtr_GetNoMoneyDialogIndex_Protected_Virtual_Int32_0;

		// Token: 0x040020D0 RID: 8400
		private static readonly IntPtr NativeMethodInfoPtr_GetNoMoneyAngryDialogIndex_Protected_Virtual_Int32_0;

		// Token: 0x040020D1 RID: 8401
		private static readonly IntPtr NativeMethodInfoPtr_GetRepellDialogIndex_Protected_Virtual_Int32_0;

		// Token: 0x040020D2 RID: 8402
		private static readonly IntPtr NativeMethodInfoPtr_GetSeenRepellDialogIndex_Protected_Virtual_Int32_0;

		// Token: 0x040020D3 RID: 8403
		private static readonly IntPtr NativeMethodInfoPtr_GetEvaluationDialog_Protected_Virtual_String_Int32_byref_Transform_0;

		// Token: 0x040020D4 RID: 8404
		private static readonly IntPtr NativeMethodInfoPtr_PostGenerateOrder_Public_Virtual_OrderBase_Boolean_byref_String_0;

		// Token: 0x040020D5 RID: 8405
		private static readonly IntPtr NativeMethodInfoPtr_FillterTags_Private_Boolean_Int32_Func_2_PopType_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x040020D6 RID: 8406
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderFoodText_Public_String_SpecialOrder_0;

		// Token: 0x040020D7 RID: 8407
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderBevText_Public_String_SpecialOrder_0;

		// Token: 0x040020D8 RID: 8408
		private static readonly IntPtr NativeMethodInfoPtr_TriggerPositiveBuff_Public_Void_Action_Boolean_0;

		// Token: 0x040020D9 RID: 8409
		private static readonly IntPtr NativeMethodInfoPtr_GetSpellExecutionContext_Private_SpellExecutionContext_Action_Boolean_0;

		// Token: 0x040020DA RID: 8410
		private static readonly IntPtr NativeMethodInfoPtr_get_GuestSpellBase_Private_get_SpellBase_0;

		// Token: 0x040020DB RID: 8411
		private static readonly IntPtr NativeMethodInfoPtr_TriggerNegativeBuff_Public_Void_Action_Boolean_0;

		// Token: 0x040020DC RID: 8412
		private static readonly IntPtr NativeMethodInfoPtr_TriggerLeaveBuff_Public_Void_Action_0;

		// Token: 0x040020DD RID: 8413
		private static readonly IntPtr NativeMethodInfoPtr_TriggerPostLeaveCallback_Private_Void_Action_0;

		// Token: 0x040020DE RID: 8414
		private static readonly IntPtr NativeMethodInfoPtr_IfCanUseSpellCard_Private_Boolean_SpellType_Action_0;

		// Token: 0x040020DF RID: 8415
		private static readonly IntPtr NativeMethodInfoPtr_PostEvaluation_Public_Virtual_Void_EvaluationResult_Action_Boolean_Boolean_0;

		// Token: 0x040020E0 RID: 8416
		private static readonly IntPtr NativeMethodInfoPtr_TryAlterKizunaValue_Private_Void_Int32_0;

		// Token: 0x02000858 RID: 2136
		public sealed class CanUseSpellCardDelegate : MulticastDelegate
		{
			// Token: 0x0600AD8A RID: 44426 RVA: 0x002CB28C File Offset: 0x002C948C
			// Note: this type is marked as 'beforefieldinit'.
			static CanUseSpellCardDelegate()
			{
				Il2CppClassPointerStore<SpecialGuestsController.CanUseSpellCardDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "CanUseSpellCardDelegate");
				SpecialGuestsController.CanUseSpellCardDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.CanUseSpellCardDelegate>.NativeClassPtr, 100672166);
				SpecialGuestsController.CanUseSpellCardDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SpecialGuestsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.CanUseSpellCardDelegate>.NativeClassPtr, 100672167);
				SpecialGuestsController.CanUseSpellCardDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpecialGuestsController_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.CanUseSpellCardDelegate>.NativeClassPtr, 100672168);
				SpecialGuestsController.CanUseSpellCardDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.CanUseSpellCardDelegate>.NativeClassPtr, 100672169);
			}

			// Token: 0x0600AD8B RID: 44427 RVA: 0x002CB300 File Offset: 0x002C9500
			[CallerCount(532)]
			[CachedScanResults(RefRangeStart = 111037, RefRangeEnd = 111569, XrefRangeStart = 111025, XrefRangeEnd = 111037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CanUseSpellCardDelegate(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestsController.CanUseSpellCardDelegate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.CanUseSpellCardDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD8C RID: 44428 RVA: 0x002CB35C File Offset: 0x002C955C
			[CallerCount(0)]
			public unsafe bool Invoke(SpecialGuestsController guestGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.CanUseSpellCardDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SpecialGuestsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD8D RID: 44429 RVA: 0x002CB3AC File Offset: 0x002C95AC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58240, RefRangeEnd = 58242, XrefRangeStart = 58240, XrefRangeEnd = 58242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(SpecialGuestsController guestGroup, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.CanUseSpellCardDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpecialGuestsController_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600AD8E RID: 44430 RVA: 0x002CB420 File Offset: 0x002C9620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111569, XrefRangeEnd = 111571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.CanUseSpellCardDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD8F RID: 44431 RVA: 0x0005D7C5 File Offset: 0x0005B9C5
			public CanUseSpellCardDelegate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600AD90 RID: 44432 RVA: 0x0005D7CE File Offset: 0x0005B9CE
			public static implicit operator SpecialGuestsController.CanUseSpellCardDelegate(Func<SpecialGuestsController, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<SpecialGuestsController.CanUseSpellCardDelegate>(A_0);
			}

			// Token: 0x0600AD91 RID: 44433 RVA: 0x0005D7D6 File Offset: 0x0005B9D6
			public static SpecialGuestsController.CanUseSpellCardDelegate operator +(SpecialGuestsController.CanUseSpellCardDelegate A_0, SpecialGuestsController.CanUseSpellCardDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SpecialGuestsController.CanUseSpellCardDelegate>();
			}

			// Token: 0x0600AD92 RID: 44434 RVA: 0x0005D7E4 File Offset: 0x0005B9E4
			public static SpecialGuestsController.CanUseSpellCardDelegate operator -(SpecialGuestsController.CanUseSpellCardDelegate A_0, SpecialGuestsController.CanUseSpellCardDelegate A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<SpecialGuestsController.CanUseSpellCardDelegate>();
				}
				return result;
			}

			// Token: 0x04006FFA RID: 28666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04006FFB RID: 28667
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_SpecialGuestsController_0;

			// Token: 0x04006FFC RID: 28668
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpecialGuestsController_AsyncCallback_Object_0;

			// Token: 0x04006FFD RID: 28669
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
		}

		// Token: 0x02000859 RID: 2137
		public enum GuestSpawnType
		{
			// Token: 0x04006FFF RID: 28671
			Normal,
			// Token: 0x04007000 RID: 28672
			GhostInChallenge,
			// Token: 0x04007001 RID: 28673
			OrinGhost,
			// Token: 0x04007002 RID: 28674
			MamizouBrother,
			// Token: 0x04007003 RID: 28675
			LuizePhoto,
			// Token: 0x04007004 RID: 28676
			HakureiMoneyBoxReimu,
			// Token: 0x04007005 RID: 28677
			Manual
		}

		// Token: 0x0200085A RID: 2138
		public enum SpellType
		{
			// Token: 0x04007007 RID: 28679
			Positive,
			// Token: 0x04007008 RID: 28680
			Negative,
			// Token: 0x04007009 RID: 28681
			Leave
		}

		// Token: 0x0200085B RID: 2139
		[ObfuscatedName("NightScene.GuestManagementUtility.SpecialGuestsController+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x0600AD93 RID: 44435 RVA: 0x002CB470 File Offset: 0x002C9670
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass51_0>.NativeClassPtr);
				SpecialGuestsController.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass51_0>.NativeClassPtr, "<>4__this");
				SpecialGuestsController.__c__DisplayClass51_0.NativeFieldInfoPtr_popTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass51_0>.NativeClassPtr, "popTags");
				SpecialGuestsController.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass51_0>.NativeClassPtr, 100672170);
				SpecialGuestsController.__c__DisplayClass51_0.NativeMethodInfoPtr__PostGenerateOrder_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass51_0>.NativeClassPtr, 100672171);
				SpecialGuestsController.__c__DisplayClass51_0.NativeMethodInfoPtr__PostGenerateOrder_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass51_0>.NativeClassPtr, 100672172);
			}

			// Token: 0x0600AD94 RID: 44436 RVA: 0x002CB500 File Offset: 0x002C9700
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD95 RID: 44437 RVA: 0x002CB53C File Offset: 0x002C973C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111571, XrefRangeEnd = 111582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PostGenerateOrder_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.__c__DisplayClass51_0.NativeMethodInfoPtr__PostGenerateOrder_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD96 RID: 44438 RVA: 0x002CB588 File Offset: 0x002C9788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111582, XrefRangeEnd = 111593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PostGenerateOrder_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.__c__DisplayClass51_0.NativeMethodInfoPtr__PostGenerateOrder_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600AD97 RID: 44439 RVA: 0x0005D7F5 File Offset: 0x0005B9F5
			public __c__DisplayClass51_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038F9 RID: 14585
			// (get) Token: 0x0600AD98 RID: 44440 RVA: 0x002CB5D4 File Offset: 0x002C97D4
			// (set) Token: 0x0600AD99 RID: 44441 RVA: 0x0005D7FE File Offset: 0x0005B9FE
			public unsafe SpecialGuestsController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038FA RID: 14586
			// (get) Token: 0x0600AD9A RID: 44442 RVA: 0x002CB604 File Offset: 0x002C9804
			// (set) Token: 0x0600AD9B RID: 44443 RVA: 0x0005D81D File Offset: 0x0005BA1D
			public unsafe Il2CppStructArray<int> popTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass51_0.NativeFieldInfoPtr_popTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass51_0.NativeFieldInfoPtr_popTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400700A RID: 28682
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400700B RID: 28683
			private static readonly IntPtr NativeFieldInfoPtr_popTags;

			// Token: 0x0400700C RID: 28684
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400700D RID: 28685
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__0_Internal_Boolean_Int32_0;

			// Token: 0x0400700E RID: 28686
			private static readonly IntPtr NativeMethodInfoPtr__PostGenerateOrder_b__1_Internal_Boolean_Int32_0;
		}

		// Token: 0x0200085C RID: 2140
		[ObfuscatedName("NightScene.GuestManagementUtility.SpecialGuestsController+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600AD9C RID: 44444 RVA: 0x002CB634 File Offset: 0x002C9834
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SpecialGuestsController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestsController.__c>.NativeClassPtr);
				SpecialGuestsController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController.__c>.NativeClassPtr, "<>9");
				SpecialGuestsController.__c.NativeFieldInfoPtr___9__55_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController.__c>.NativeClassPtr, "<>9__55_0");
				SpecialGuestsController.__c.NativeFieldInfoPtr___9__55_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController.__c>.NativeClassPtr, "<>9__55_1");
				SpecialGuestsController.__c.NativeFieldInfoPtr___9__59_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController.__c>.NativeClassPtr, "<>9__59_0");
				SpecialGuestsController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.__c>.NativeClassPtr, 100672174);
				SpecialGuestsController.__c.NativeMethodInfoPtr__TriggerPositiveBuff_b__55_0_Internal_Void_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.__c>.NativeClassPtr, 100672175);
				SpecialGuestsController.__c.NativeMethodInfoPtr__TriggerPositiveBuff_b__55_1_Internal_Void_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.__c>.NativeClassPtr, 100672176);
				SpecialGuestsController.__c.NativeMethodInfoPtr__TriggerNegativeBuff_b__59_0_Internal_Void_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.__c>.NativeClassPtr, 100672177);
			}

			// Token: 0x0600AD9D RID: 44445 RVA: 0x002CB700 File Offset: 0x002C9900
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestsController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD9E RID: 44446 RVA: 0x002CB73C File Offset: 0x002C993C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111593, XrefRangeEnd = 111600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TriggerPositiveBuff_b__55_0(AchievementNotifyResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.__c.NativeMethodInfoPtr__TriggerPositiveBuff_b__55_0_Internal_Void_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AD9F RID: 44447 RVA: 0x002CB780 File Offset: 0x002C9980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111600, XrefRangeEnd = 111607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TriggerPositiveBuff_b__55_1(AchievementNotifyResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.__c.NativeMethodInfoPtr__TriggerPositiveBuff_b__55_1_Internal_Void_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ADA0 RID: 44448 RVA: 0x002CB7C4 File Offset: 0x002C99C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111607, XrefRangeEnd = 111614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TriggerNegativeBuff_b__59_0(AchievementNotifyResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.__c.NativeMethodInfoPtr__TriggerNegativeBuff_b__59_0_Internal_Void_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ADA1 RID: 44449 RVA: 0x0005D83C File Offset: 0x0005BA3C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038FB RID: 14587
			// (get) Token: 0x0600ADA2 RID: 44450 RVA: 0x002CB808 File Offset: 0x002C9A08
			// (set) Token: 0x0600ADA3 RID: 44451 RVA: 0x0005D845 File Offset: 0x0005BA45
			public unsafe static SpecialGuestsController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestsController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestsController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038FC RID: 14588
			// (get) Token: 0x0600ADA4 RID: 44452 RVA: 0x002CB830 File Offset: 0x002C9A30
			// (set) Token: 0x0600ADA5 RID: 44453 RVA: 0x0005D857 File Offset: 0x0005BA57
			public unsafe static Action<AchievementNotifyResult> __9__55_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestsController.__c.NativeFieldInfoPtr___9__55_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AchievementNotifyResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestsController.__c.NativeFieldInfoPtr___9__55_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038FD RID: 14589
			// (get) Token: 0x0600ADA6 RID: 44454 RVA: 0x002CB858 File Offset: 0x002C9A58
			// (set) Token: 0x0600ADA7 RID: 44455 RVA: 0x0005D869 File Offset: 0x0005BA69
			public unsafe static Action<AchievementNotifyResult> __9__55_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestsController.__c.NativeFieldInfoPtr___9__55_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AchievementNotifyResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestsController.__c.NativeFieldInfoPtr___9__55_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038FE RID: 14590
			// (get) Token: 0x0600ADA8 RID: 44456 RVA: 0x002CB880 File Offset: 0x002C9A80
			// (set) Token: 0x0600ADA9 RID: 44457 RVA: 0x0005D87B File Offset: 0x0005BA7B
			public unsafe static Action<AchievementNotifyResult> __9__59_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpecialGuestsController.__c.NativeFieldInfoPtr___9__59_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AchievementNotifyResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpecialGuestsController.__c.NativeFieldInfoPtr___9__59_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400700F RID: 28687
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007010 RID: 28688
			private static readonly IntPtr NativeFieldInfoPtr___9__55_0;

			// Token: 0x04007011 RID: 28689
			private static readonly IntPtr NativeFieldInfoPtr___9__55_1;

			// Token: 0x04007012 RID: 28690
			private static readonly IntPtr NativeFieldInfoPtr___9__59_0;

			// Token: 0x04007013 RID: 28691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007014 RID: 28692
			private static readonly IntPtr NativeMethodInfoPtr__TriggerPositiveBuff_b__55_0_Internal_Void_AchievementNotifyResult_0;

			// Token: 0x04007015 RID: 28693
			private static readonly IntPtr NativeMethodInfoPtr__TriggerPositiveBuff_b__55_1_Internal_Void_AchievementNotifyResult_0;

			// Token: 0x04007016 RID: 28694
			private static readonly IntPtr NativeMethodInfoPtr__TriggerNegativeBuff_b__59_0_Internal_Void_AchievementNotifyResult_0;
		}

		// Token: 0x0200085D RID: 2141
		[ObfuscatedName("NightScene.GuestManagementUtility.SpecialGuestsController+<>c__DisplayClass60_0")]
		public sealed class __c__DisplayClass60_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ADAA RID: 44458 RVA: 0x002CB8A8 File Offset: 0x002C9AA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass60_0()
			{
				Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "<>c__DisplayClass60_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass60_0>.NativeClassPtr);
				SpecialGuestsController.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass60_0>.NativeClassPtr, "<>4__this");
				SpecialGuestsController.__c__DisplayClass60_0.NativeFieldInfoPtr_thisOnFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass60_0>.NativeClassPtr, "thisOnFinish");
				SpecialGuestsController.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass60_0>.NativeClassPtr, 100672178);
				SpecialGuestsController.__c__DisplayClass60_0.NativeMethodInfoPtr__TriggerLeaveBuff_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass60_0>.NativeClassPtr, 100672179);
			}

			// Token: 0x0600ADAB RID: 44459 RVA: 0x002CB924 File Offset: 0x002C9B24
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass60_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass60_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ADAC RID: 44460 RVA: 0x002CB960 File Offset: 0x002C9B60
			[CallerCount(0)]
			public unsafe void _TriggerLeaveBuff_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.__c__DisplayClass60_0.NativeMethodInfoPtr__TriggerLeaveBuff_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ADAD RID: 44461 RVA: 0x0005D88D File Offset: 0x0005BA8D
			public __c__DisplayClass60_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170038FF RID: 14591
			// (get) Token: 0x0600ADAE RID: 44462 RVA: 0x002CB994 File Offset: 0x002C9B94
			// (set) Token: 0x0600ADAF RID: 44463 RVA: 0x0005D896 File Offset: 0x0005BA96
			public unsafe SpecialGuestsController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003900 RID: 14592
			// (get) Token: 0x0600ADB0 RID: 44464 RVA: 0x002CB9C4 File Offset: 0x002C9BC4
			// (set) Token: 0x0600ADB1 RID: 44465 RVA: 0x0005D8B5 File Offset: 0x0005BAB5
			public unsafe Action thisOnFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass60_0.NativeFieldInfoPtr_thisOnFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass60_0.NativeFieldInfoPtr_thisOnFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007017 RID: 28695
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007018 RID: 28696
			private static readonly IntPtr NativeFieldInfoPtr_thisOnFinish;

			// Token: 0x04007019 RID: 28697
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400701A RID: 28698
			private static readonly IntPtr NativeMethodInfoPtr__TriggerLeaveBuff_b__0_Internal_Void_0;
		}

		// Token: 0x0200085E RID: 2142
		[ObfuscatedName("NightScene.GuestManagementUtility.SpecialGuestsController+<>c__DisplayClass64_0")]
		public sealed class __c__DisplayClass64_0 : Il2CppSystem.Object
		{
			// Token: 0x0600ADB2 RID: 44466 RVA: 0x002CB9F4 File Offset: 0x002C9BF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass64_0()
			{
				Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpecialGuestsController>.NativeClassPtr, "<>c__DisplayClass64_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass64_0>.NativeClassPtr);
				SpecialGuestsController.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass64_0>.NativeClassPtr, "<>4__this");
				SpecialGuestsController.__c__DisplayClass64_0.NativeFieldInfoPtr_evaluationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass64_0>.NativeClassPtr, "evaluationType");
				SpecialGuestsController.__c__DisplayClass64_0.NativeFieldInfoPtr_finishedByPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass64_0>.NativeClassPtr, "finishedByPartner");
				SpecialGuestsController.__c__DisplayClass64_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass64_0>.NativeClassPtr, "onFinish");
				SpecialGuestsController.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass64_0>.NativeClassPtr, 100672180);
				SpecialGuestsController.__c__DisplayClass64_0.NativeMethodInfoPtr__PostEvaluation_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass64_0>.NativeClassPtr, 100672181);
				SpecialGuestsController.__c__DisplayClass64_0.NativeMethodInfoPtr__PostEvaluation_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass64_0>.NativeClassPtr, 100672182);
			}

			// Token: 0x0600ADB3 RID: 44467 RVA: 0x002CBAAC File Offset: 0x002C9CAC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass64_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestsController.__c__DisplayClass64_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ADB4 RID: 44468 RVA: 0x002CBAE8 File Offset: 0x002C9CE8
			[CallerCount(0)]
			public unsafe void _PostEvaluation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.__c__DisplayClass64_0.NativeMethodInfoPtr__PostEvaluation_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ADB5 RID: 44469 RVA: 0x002CBB1C File Offset: 0x002C9D1C
			[CallerCount(0)]
			public unsafe void _PostEvaluation_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestsController.__c__DisplayClass64_0.NativeMethodInfoPtr__PostEvaluation_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ADB6 RID: 44470 RVA: 0x0005D8D4 File Offset: 0x0005BAD4
			public __c__DisplayClass64_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003901 RID: 14593
			// (get) Token: 0x0600ADB7 RID: 44471 RVA: 0x002CBB50 File Offset: 0x002C9D50
			// (set) Token: 0x0600ADB8 RID: 44472 RVA: 0x0005D8DD File Offset: 0x0005BADD
			public unsafe SpecialGuestsController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003902 RID: 14594
			// (get) Token: 0x0600ADB9 RID: 44473 RVA: 0x002CBB80 File Offset: 0x002C9D80
			// (set) Token: 0x0600ADBA RID: 44474 RVA: 0x0005D8FC File Offset: 0x0005BAFC
			public unsafe GuestGroupController.EvaluationResult evaluationType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass64_0.NativeFieldInfoPtr_evaluationType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass64_0.NativeFieldInfoPtr_evaluationType)) = value;
				}
			}

			// Token: 0x17003903 RID: 14595
			// (get) Token: 0x0600ADBB RID: 44475 RVA: 0x002CBBA8 File Offset: 0x002C9DA8
			// (set) Token: 0x0600ADBC RID: 44476 RVA: 0x0005D917 File Offset: 0x0005BB17
			public unsafe bool finishedByPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass64_0.NativeFieldInfoPtr_finishedByPartner);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass64_0.NativeFieldInfoPtr_finishedByPartner)) = value;
				}
			}

			// Token: 0x17003904 RID: 14596
			// (get) Token: 0x0600ADBD RID: 44477 RVA: 0x002CBBD0 File Offset: 0x002C9DD0
			// (set) Token: 0x0600ADBE RID: 44478 RVA: 0x0005D932 File Offset: 0x0005BB32
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass64_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestsController.__c__DisplayClass64_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400701B RID: 28699
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400701C RID: 28700
			private static readonly IntPtr NativeFieldInfoPtr_evaluationType;

			// Token: 0x0400701D RID: 28701
			private static readonly IntPtr NativeFieldInfoPtr_finishedByPartner;

			// Token: 0x0400701E RID: 28702
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x0400701F RID: 28703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007020 RID: 28704
			private static readonly IntPtr NativeMethodInfoPtr__PostEvaluation_b__0_Internal_Void_0;

			// Token: 0x04007021 RID: 28705
			private static readonly IntPtr NativeMethodInfoPtr__PostEvaluation_b__1_Internal_Void_0;
		}
	}
}
