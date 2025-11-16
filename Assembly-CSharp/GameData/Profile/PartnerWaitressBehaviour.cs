using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000332 RID: 818
	public class PartnerWaitressBehaviour : PartnerBase
	{
		// Token: 0x060060A4 RID: 24740 RVA: 0x001E0E1C File Offset: 0x001DF01C
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerWaitressBehaviour()
		{
			Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerWaitressBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr);
			PartnerWaitressBehaviour.NativeFieldInfoPtr_checkOrderCompletionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "checkOrderCompletionCallback");
			PartnerWaitressBehaviour.NativeFieldInfoPtr_executeServeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "executeServeCallback");
			PartnerWaitressBehaviour.NativeFieldInfoPtr_focusingSellable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "focusingSellable");
			PartnerWaitressBehaviour.NativeFieldInfoPtr_getInventoryPositionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "getInventoryPositionCallback");
			PartnerWaitressBehaviour.NativeFieldInfoPtr_getRequestedFromInventoryCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "getRequestedFromInventoryCallback");
			PartnerWaitressBehaviour.NativeFieldInfoPtr_inventoryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "inventoryType");
			PartnerWaitressBehaviour.NativeFieldInfoPtr_waitressType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "waitressType");
			PartnerWaitressBehaviour.NativeFieldInfoPtr_workingCorouinte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "workingCorouinte");
			PartnerWaitressBehaviour.NativeMethodInfoPtr__ctor_Public_Void_WaitressType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683219);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_get_FocusingOrder_Private_get_NormalOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683220);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_set_FocusingOrder_Private_set_Void_NormalOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683221);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_GetPartnerType_Public_Virtual_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683222);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683223);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_TryFetchOrder_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683224);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_TryFetchSameOrder_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683225);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_TryAcceptOrder_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683226);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_TryAcceptOrderForBuffer_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683227);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_HasInventorySufficientForTargetOrder_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683228);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_HasBufferSufficientForTargetOrder_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683229);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_OnWaitressMoveOrExtractReceiveSystemChangeInternal_Private_Boolean_OrderChangeContext_OrderBase_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683230);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_OnWaitressMoveOrExtractReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683231);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_ResetStatus_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683232);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_OnPlayIdleState_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683233);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_OnWaitressIdleReceiveSystemChange_Public_Boolean_OrderChangeContext_OrderBase_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683234);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_PlayMoveToExtractFromInventoryState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683235);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_OnWaitressMoveToExtractInterrupt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683236);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_PlayExtractFromInventoryState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683237);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_EmployeeExtractFromInventoryCoroutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683238);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_OnWaitressExtractFromInventoryStateInterrupt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683239);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_StartDeliver_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683240);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_PlayMoveToDeliverState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683241);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_OnMoveToDeliverReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683242);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_OnMoveToDeliverInterrupt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683243);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_PlayInterruptDeliverAndFetchSameOrderState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683244);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_PlayDeliverState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683245);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_OnDeliverInterrupt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683246);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_EmployeeDeliver_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683247);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_PlayThrowDeliverState_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683248);
			PartnerWaitressBehaviour.NativeMethodInfoPtr_ExecuteThrowDeliver_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683249);
			PartnerWaitressBehaviour.NativeMethodInfoPtr__OnInitialize_b__14_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683250);
			PartnerWaitressBehaviour.NativeMethodInfoPtr__OnInitialize_b__14_2_Private_Void_GuestTableDisplayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683251);
			PartnerWaitressBehaviour.NativeMethodInfoPtr__OnInitialize_b__14_3_Private_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683252);
			PartnerWaitressBehaviour.NativeMethodInfoPtr__OnInitialize_b__14_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683253);
			PartnerWaitressBehaviour.NativeMethodInfoPtr__OnInitialize_b__14_6_Private_Void_GuestTableDisplayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683254);
			PartnerWaitressBehaviour.NativeMethodInfoPtr__OnInitialize_b__14_7_Private_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683255);
			PartnerWaitressBehaviour.NativeMethodInfoPtr__TryFetchOrder_b__15_0_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683256);
			PartnerWaitressBehaviour.NativeMethodInfoPtr__TryFetchSameOrder_b__16_0_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683257);
			PartnerWaitressBehaviour.NativeMethodInfoPtr__EmployeeDeliver_b__39_0_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683258);
			PartnerWaitressBehaviour.NativeMethodInfoPtr__ExecuteThrowDeliver_b__41_0_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, 100683259);
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x001E1220 File Offset: 0x001DF420
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 239262, RefRangeEnd = 239270, XrefRangeStart = 239258, XrefRangeEnd = 239262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerWaitressBehaviour(PartnerWaitressBehaviour.WaitressType waitressType) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref waitressType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr__ctor_Public_Void_WaitressType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x060060A6 RID: 24742 RVA: 0x001E1268 File Offset: 0x001DF468
		// (set) Token: 0x060060A7 RID: 24743 RVA: 0x001E12A8 File Offset: 0x001DF4A8
		public unsafe GuestsManager.NormalOrder FocusingOrder
		{
			[CallerCount(70)]
			[CachedScanResults(RefRangeStart = 239271, RefRangeEnd = 239341, XrefRangeStart = 239270, XrefRangeEnd = 239271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_get_FocusingOrder_Private_get_NormalOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestsManager.NormalOrder>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_set_FocusingOrder_Private_set_Void_NormalOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x001E12EC File Offset: 0x001DF4EC
		[CallerCount(0)]
		public unsafe override PartnerBase.PartnerType GetPartnerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerWaitressBehaviour.NativeMethodInfoPtr_GetPartnerType_Public_Virtual_PartnerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x001E1334 File Offset: 0x001DF534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239341, XrefRangeEnd = 239409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerWaitressBehaviour.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x001E1370 File Offset: 0x001DF570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239414, RefRangeEnd = 239415, XrefRangeStart = 239409, XrefRangeEnd = 239414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFetchOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_TryFetchOrder_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x001E13AC File Offset: 0x001DF5AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 239420, RefRangeEnd = 239422, XrefRangeStart = 239415, XrefRangeEnd = 239420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFetchSameOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_TryFetchSameOrder_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x001E13E8 File Offset: 0x001DF5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239422, XrefRangeEnd = 239433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAcceptOrder(GuestsManager.OrderBase targetOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_TryAcceptOrder_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x001E1438 File Offset: 0x001DF638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239433, XrefRangeEnd = 239444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAcceptOrderForBuffer(GuestsManager.OrderBase targetOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_TryAcceptOrderForBuffer_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x001E1488 File Offset: 0x001DF688
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239479, RefRangeEnd = 239482, XrefRangeStart = 239444, XrefRangeEnd = 239479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasInventorySufficientForTargetOrder(GuestsManager.OrderBase baseTargetOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseTargetOrder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_HasInventorySufficientForTargetOrder_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x001E14D8 File Offset: 0x001DF6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239482, XrefRangeEnd = 239487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasBufferSufficientForTargetOrder(GuestsManager.OrderBase baseTargetOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseTargetOrder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_HasBufferSufficientForTargetOrder_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x001E1528 File Offset: 0x001DF728
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 239509, RefRangeEnd = 239511, XrefRangeStart = 239487, XrefRangeEnd = 239509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnWaitressMoveOrExtractReceiveSystemChangeInternal(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, Il2CppSystem.Object additionalInformation, bool bypassInventoryCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orderChangeContext;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalInformation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bypassInventoryCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_OnWaitressMoveOrExtractReceiveSystemChangeInternal_Private_Boolean_OrderChangeContext_OrderBase_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x001E15A4 File Offset: 0x001DF7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239511, XrefRangeEnd = 239512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnWaitressMoveOrExtractReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, Il2CppSystem.Object additionalInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orderChangeContext;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalInformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_OnWaitressMoveOrExtractReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x001E1614 File Offset: 0x001DF814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239512, XrefRangeEnd = 239522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerWaitressBehaviour.NativeMethodInfoPtr_ResetStatus_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x001E1650 File Offset: 0x001DF850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239522, XrefRangeEnd = 239530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayIdleState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerWaitressBehaviour.NativeMethodInfoPtr_OnPlayIdleState_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x001E168C File Offset: 0x001DF88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239530, XrefRangeEnd = 239535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnWaitressIdleReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, Il2CppSystem.Object additionalInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orderChangeContext;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalInformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_OnWaitressIdleReceiveSystemChange_Public_Boolean_OrderChangeContext_OrderBase_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x001E16FC File Offset: 0x001DF8FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239580, RefRangeEnd = 239581, XrefRangeStart = 239535, XrefRangeEnd = 239580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMoveToExtractFromInventoryState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_PlayMoveToExtractFromInventoryState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x001E1730 File Offset: 0x001DF930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239581, XrefRangeEnd = 239592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWaitressMoveToExtractInterrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_OnWaitressMoveToExtractInterrupt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x001E1764 File Offset: 0x001DF964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239592, XrefRangeEnd = 239618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayExtractFromInventoryState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_PlayExtractFromInventoryState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x001E1798 File Offset: 0x001DF998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239618, XrefRangeEnd = 239623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator EmployeeExtractFromInventoryCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_EmployeeExtractFromInventoryCoroutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x001E17D8 File Offset: 0x001DF9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239623, XrefRangeEnd = 239636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWaitressExtractFromInventoryStateInterrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_OnWaitressExtractFromInventoryStateInterrupt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x001E180C File Offset: 0x001DFA0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 239642, RefRangeEnd = 239644, XrefRangeStart = 239636, XrefRangeEnd = 239642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDeliver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_StartDeliver_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x001E1840 File Offset: 0x001DFA40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239684, RefRangeEnd = 239685, XrefRangeStart = 239644, XrefRangeEnd = 239684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMoveToDeliverState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_PlayMoveToDeliverState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060BC RID: 24764 RVA: 0x001E1874 File Offset: 0x001DFA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239685, XrefRangeEnd = 239686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnMoveToDeliverReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, Il2CppSystem.Object additionalInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orderChangeContext;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalInformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_OnMoveToDeliverReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060BD RID: 24765 RVA: 0x001E18E4 File Offset: 0x001DFAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239686, XrefRangeEnd = 239697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMoveToDeliverInterrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_OnMoveToDeliverInterrupt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x001E1918 File Offset: 0x001DFB18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 239727, RefRangeEnd = 239729, XrefRangeStart = 239697, XrefRangeEnd = 239727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayInterruptDeliverAndFetchSameOrderState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_PlayInterruptDeliverAndFetchSameOrderState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x001E194C File Offset: 0x001DFB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239729, XrefRangeEnd = 239755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayDeliverState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_PlayDeliverState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060C0 RID: 24768 RVA: 0x001E1980 File Offset: 0x001DFB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239755, XrefRangeEnd = 239769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeliverInterrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_OnDeliverInterrupt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x001E19B4 File Offset: 0x001DFBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239769, XrefRangeEnd = 239774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator EmployeeDeliver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_EmployeeDeliver_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x001E19F4 File Offset: 0x001DFBF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239799, RefRangeEnd = 239800, XrefRangeStart = 239774, XrefRangeEnd = 239799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayThrowDeliverState(bool isSpecial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isSpecial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_PlayThrowDeliverState_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x001E1A34 File Offset: 0x001DFC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239800, XrefRangeEnd = 239805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExecuteThrowDeliver(bool isSpecial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isSpecial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr_ExecuteThrowDeliver_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x001E1A80 File Offset: 0x001DFC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239805, XrefRangeEnd = 239830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInitialize_b__14_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr__OnInitialize_b__14_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x001E1AB4 File Offset: 0x001DFCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239830, XrefRangeEnd = 239848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInitialize_b__14_2(GuestTableDisplayer tableDisplayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tableDisplayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr__OnInitialize_b__14_2_Private_Void_GuestTableDisplayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x001E1AF8 File Offset: 0x001DFCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239848, XrefRangeEnd = 239854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Int _OnInitialize_b__14_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr__OnInitialize_b__14_3_Private_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060C7 RID: 24775 RVA: 0x001E1B34 File Offset: 0x001DFD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239854, XrefRangeEnd = 239862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInitialize_b__14_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr__OnInitialize_b__14_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x001E1B68 File Offset: 0x001DFD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239862, XrefRangeEnd = 239898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInitialize_b__14_6(GuestTableDisplayer tableDisplayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tableDisplayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr__OnInitialize_b__14_6_Private_Void_GuestTableDisplayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060C9 RID: 24777 RVA: 0x001E1BAC File Offset: 0x001DFDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239898, XrefRangeEnd = 239904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Int _OnInitialize_b__14_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr__OnInitialize_b__14_7_Private_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x001E1BE8 File Offset: 0x001DFDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239904, XrefRangeEnd = 239905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _TryFetchOrder_b__15_0(GuestsManager.OrderBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr__TryFetchOrder_b__15_0_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x001E1C38 File Offset: 0x001DFE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239905, XrefRangeEnd = 239921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _TryFetchSameOrder_b__16_0(GuestsManager.OrderBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr__TryFetchSameOrder_b__16_0_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x001E1C88 File Offset: 0x001DFE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239921, XrefRangeEnd = 239924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _EmployeeDeliver_b__39_0(GuestGroupController guest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr__EmployeeDeliver_b__39_0_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060CD RID: 24781 RVA: 0x001E1CCC File Offset: 0x001DFECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ExecuteThrowDeliver_b__41_0(GuestGroupController guest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.NativeMethodInfoPtr__ExecuteThrowDeliver_b__41_0_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x000346DD File Offset: 0x000328DD
		public PartnerWaitressBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x060060CF RID: 24783 RVA: 0x001E1D10 File Offset: 0x001DFF10
		// (set) Token: 0x060060D0 RID: 24784 RVA: 0x000346E6 File Offset: 0x000328E6
		public unsafe Func<GuestsManager.OrderBase, bool> checkOrderCompletionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_checkOrderCompletionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestsManager.OrderBase, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_checkOrderCompletionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x060060D1 RID: 24785 RVA: 0x001E1D40 File Offset: 0x001DFF40
		// (set) Token: 0x060060D2 RID: 24786 RVA: 0x00034705 File Offset: 0x00032905
		public unsafe Action<GuestTableDisplayer> executeServeCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_executeServeCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestTableDisplayer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_executeServeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x060060D3 RID: 24787 RVA: 0x001E1D70 File Offset: 0x001DFF70
		// (set) Token: 0x060060D4 RID: 24788 RVA: 0x00034724 File Offset: 0x00032924
		public unsafe Sellable.SellableType focusingSellable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_focusingSellable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_focusingSellable)) = value;
			}
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x060060D5 RID: 24789 RVA: 0x001E1D98 File Offset: 0x001DFF98
		// (set) Token: 0x060060D6 RID: 24790 RVA: 0x0003473F File Offset: 0x0003293F
		public unsafe Func<Vector3Int> getInventoryPositionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_getInventoryPositionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_getInventoryPositionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x060060D7 RID: 24791 RVA: 0x001E1DC8 File Offset: 0x001DFFC8
		// (set) Token: 0x060060D8 RID: 24792 RVA: 0x0003475E File Offset: 0x0003295E
		public unsafe Action getRequestedFromInventoryCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_getRequestedFromInventoryCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_getRequestedFromInventoryCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x060060D9 RID: 24793 RVA: 0x001E1DF8 File Offset: 0x001DFFF8
		// (set) Token: 0x060060DA RID: 24794 RVA: 0x0003477D File Offset: 0x0003297D
		public unsafe PartnerBase.InventoryType inventoryType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_inventoryType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_inventoryType)) = value;
			}
		}

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x060060DB RID: 24795 RVA: 0x001E1E20 File Offset: 0x001E0020
		// (set) Token: 0x060060DC RID: 24796 RVA: 0x00034798 File Offset: 0x00032998
		public unsafe PartnerWaitressBehaviour.WaitressType waitressType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_waitressType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_waitressType)) = value;
			}
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x060060DD RID: 24797 RVA: 0x001E1E48 File Offset: 0x001E0048
		// (set) Token: 0x060060DE RID: 24798 RVA: 0x000347B3 File Offset: 0x000329B3
		public unsafe Coroutine workingCorouinte
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_workingCorouinte);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.NativeFieldInfoPtr_workingCorouinte), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FFE RID: 16382
		private static readonly IntPtr NativeFieldInfoPtr_checkOrderCompletionCallback;

		// Token: 0x04003FFF RID: 16383
		private static readonly IntPtr NativeFieldInfoPtr_executeServeCallback;

		// Token: 0x04004000 RID: 16384
		private static readonly IntPtr NativeFieldInfoPtr_focusingSellable;

		// Token: 0x04004001 RID: 16385
		private static readonly IntPtr NativeFieldInfoPtr_getInventoryPositionCallback;

		// Token: 0x04004002 RID: 16386
		private static readonly IntPtr NativeFieldInfoPtr_getRequestedFromInventoryCallback;

		// Token: 0x04004003 RID: 16387
		private static readonly IntPtr NativeFieldInfoPtr_inventoryType;

		// Token: 0x04004004 RID: 16388
		private static readonly IntPtr NativeFieldInfoPtr_waitressType;

		// Token: 0x04004005 RID: 16389
		private static readonly IntPtr NativeFieldInfoPtr_workingCorouinte;

		// Token: 0x04004006 RID: 16390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WaitressType_0;

		// Token: 0x04004007 RID: 16391
		private static readonly IntPtr NativeMethodInfoPtr_get_FocusingOrder_Private_get_NormalOrder_0;

		// Token: 0x04004008 RID: 16392
		private static readonly IntPtr NativeMethodInfoPtr_set_FocusingOrder_Private_set_Void_NormalOrder_0;

		// Token: 0x04004009 RID: 16393
		private static readonly IntPtr NativeMethodInfoPtr_GetPartnerType_Public_Virtual_PartnerType_0;

		// Token: 0x0400400A RID: 16394
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400400B RID: 16395
		private static readonly IntPtr NativeMethodInfoPtr_TryFetchOrder_Private_Boolean_0;

		// Token: 0x0400400C RID: 16396
		private static readonly IntPtr NativeMethodInfoPtr_TryFetchSameOrder_Private_Boolean_0;

		// Token: 0x0400400D RID: 16397
		private static readonly IntPtr NativeMethodInfoPtr_TryAcceptOrder_Private_Boolean_OrderBase_0;

		// Token: 0x0400400E RID: 16398
		private static readonly IntPtr NativeMethodInfoPtr_TryAcceptOrderForBuffer_Private_Boolean_OrderBase_0;

		// Token: 0x0400400F RID: 16399
		private static readonly IntPtr NativeMethodInfoPtr_HasInventorySufficientForTargetOrder_Private_Boolean_OrderBase_0;

		// Token: 0x04004010 RID: 16400
		private static readonly IntPtr NativeMethodInfoPtr_HasBufferSufficientForTargetOrder_Private_Boolean_OrderBase_0;

		// Token: 0x04004011 RID: 16401
		private static readonly IntPtr NativeMethodInfoPtr_OnWaitressMoveOrExtractReceiveSystemChangeInternal_Private_Boolean_OrderChangeContext_OrderBase_Object_Boolean_0;

		// Token: 0x04004012 RID: 16402
		private static readonly IntPtr NativeMethodInfoPtr_OnWaitressMoveOrExtractReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0;

		// Token: 0x04004013 RID: 16403
		private static readonly IntPtr NativeMethodInfoPtr_ResetStatus_Protected_Virtual_Void_0;

		// Token: 0x04004014 RID: 16404
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayIdleState_Protected_Virtual_Void_0;

		// Token: 0x04004015 RID: 16405
		private static readonly IntPtr NativeMethodInfoPtr_OnWaitressIdleReceiveSystemChange_Public_Boolean_OrderChangeContext_OrderBase_Object_0;

		// Token: 0x04004016 RID: 16406
		private static readonly IntPtr NativeMethodInfoPtr_PlayMoveToExtractFromInventoryState_Private_Void_0;

		// Token: 0x04004017 RID: 16407
		private static readonly IntPtr NativeMethodInfoPtr_OnWaitressMoveToExtractInterrupt_Private_Void_0;

		// Token: 0x04004018 RID: 16408
		private static readonly IntPtr NativeMethodInfoPtr_PlayExtractFromInventoryState_Private_Void_0;

		// Token: 0x04004019 RID: 16409
		private static readonly IntPtr NativeMethodInfoPtr_EmployeeExtractFromInventoryCoroutine_Private_IEnumerator_0;

		// Token: 0x0400401A RID: 16410
		private static readonly IntPtr NativeMethodInfoPtr_OnWaitressExtractFromInventoryStateInterrupt_Private_Void_0;

		// Token: 0x0400401B RID: 16411
		private static readonly IntPtr NativeMethodInfoPtr_StartDeliver_Private_Void_0;

		// Token: 0x0400401C RID: 16412
		private static readonly IntPtr NativeMethodInfoPtr_PlayMoveToDeliverState_Private_Void_0;

		// Token: 0x0400401D RID: 16413
		private static readonly IntPtr NativeMethodInfoPtr_OnMoveToDeliverReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0;

		// Token: 0x0400401E RID: 16414
		private static readonly IntPtr NativeMethodInfoPtr_OnMoveToDeliverInterrupt_Private_Void_0;

		// Token: 0x0400401F RID: 16415
		private static readonly IntPtr NativeMethodInfoPtr_PlayInterruptDeliverAndFetchSameOrderState_Private_Void_0;

		// Token: 0x04004020 RID: 16416
		private static readonly IntPtr NativeMethodInfoPtr_PlayDeliverState_Private_Void_0;

		// Token: 0x04004021 RID: 16417
		private static readonly IntPtr NativeMethodInfoPtr_OnDeliverInterrupt_Private_Void_0;

		// Token: 0x04004022 RID: 16418
		private static readonly IntPtr NativeMethodInfoPtr_EmployeeDeliver_Private_IEnumerator_0;

		// Token: 0x04004023 RID: 16419
		private static readonly IntPtr NativeMethodInfoPtr_PlayThrowDeliverState_Private_Void_Boolean_0;

		// Token: 0x04004024 RID: 16420
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteThrowDeliver_Private_IEnumerator_Boolean_0;

		// Token: 0x04004025 RID: 16421
		private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__14_1_Private_Void_0;

		// Token: 0x04004026 RID: 16422
		private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__14_2_Private_Void_GuestTableDisplayer_0;

		// Token: 0x04004027 RID: 16423
		private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__14_3_Private_Vector3Int_0;

		// Token: 0x04004028 RID: 16424
		private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__14_5_Private_Void_0;

		// Token: 0x04004029 RID: 16425
		private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__14_6_Private_Void_GuestTableDisplayer_0;

		// Token: 0x0400402A RID: 16426
		private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__14_7_Private_Vector3Int_0;

		// Token: 0x0400402B RID: 16427
		private static readonly IntPtr NativeMethodInfoPtr__TryFetchOrder_b__15_0_Private_Boolean_OrderBase_0;

		// Token: 0x0400402C RID: 16428
		private static readonly IntPtr NativeMethodInfoPtr__TryFetchSameOrder_b__16_0_Private_Boolean_OrderBase_0;

		// Token: 0x0400402D RID: 16429
		private static readonly IntPtr NativeMethodInfoPtr__EmployeeDeliver_b__39_0_Private_Void_GuestGroupController_0;

		// Token: 0x0400402E RID: 16430
		private static readonly IntPtr NativeMethodInfoPtr__ExecuteThrowDeliver_b__41_0_Private_Void_GuestGroupController_0;

		// Token: 0x02000D82 RID: 3458
		public enum WaitressType : byte
		{
			// Token: 0x04009D11 RID: 40209
			Waitress = 1,
			// Token: 0x04009D12 RID: 40210
			Barmaid
		}

		// Token: 0x02000D83 RID: 3459
		public enum DeliverType : byte
		{
			// Token: 0x04009D14 RID: 40212
			Default,
			// Token: 0x04009D15 RID: 40213
			ThrowDeliver
		}

		// Token: 0x02000D84 RID: 3460
		[ObfuscatedName("GameData.Profile.PartnerWaitressBehaviour+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F6A3 RID: 63139 RVA: 0x003A3268 File Offset: 0x003A1468
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<PartnerWaitressBehaviour.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c__DisplayClass14_0>.NativeClassPtr);
				PartnerWaitressBehaviour.__c__DisplayClass14_0.NativeFieldInfoPtr_requestedId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c__DisplayClass14_0>.NativeClassPtr, "requestedId");
				PartnerWaitressBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c__DisplayClass14_0>.NativeClassPtr, 100683260);
				PartnerWaitressBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__OnInitialize_b__8_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c__DisplayClass14_0>.NativeClassPtr, 100683261);
			}

			// Token: 0x0600F6A4 RID: 63140 RVA: 0x003A32D0 File Offset: 0x003A14D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6A5 RID: 63141 RVA: 0x003A330C File Offset: 0x003A150C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnInitialize_b__8(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__OnInitialize_b__8_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F6A6 RID: 63142 RVA: 0x000846E7 File Offset: 0x000828E7
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005025 RID: 20517
			// (get) Token: 0x0600F6A7 RID: 63143 RVA: 0x003A335C File Offset: 0x003A155C
			// (set) Token: 0x0600F6A8 RID: 63144 RVA: 0x000846F0 File Offset: 0x000828F0
			public unsafe int requestedId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.__c__DisplayClass14_0.NativeFieldInfoPtr_requestedId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.__c__DisplayClass14_0.NativeFieldInfoPtr_requestedId)) = value;
				}
			}

			// Token: 0x04009D16 RID: 40214
			private static readonly IntPtr NativeFieldInfoPtr_requestedId;

			// Token: 0x04009D17 RID: 40215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D18 RID: 40216
			private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__8_Internal_Boolean_Sellable_0;
		}

		// Token: 0x02000D85 RID: 3461
		[ObfuscatedName("GameData.Profile.PartnerWaitressBehaviour+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F6A9 RID: 63145 RVA: 0x003A3384 File Offset: 0x003A1584
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PartnerWaitressBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c>.NativeClassPtr);
				PartnerWaitressBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c>.NativeClassPtr, "<>9");
				PartnerWaitressBehaviour.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c>.NativeClassPtr, "<>9__14_0");
				PartnerWaitressBehaviour.__c.NativeFieldInfoPtr___9__14_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c>.NativeClassPtr, "<>9__14_4");
				PartnerWaitressBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c>.NativeClassPtr, 100683263);
				PartnerWaitressBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__14_0_Internal_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c>.NativeClassPtr, 100683264);
				PartnerWaitressBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__14_4_Internal_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c>.NativeClassPtr, 100683265);
			}

			// Token: 0x0600F6AA RID: 63146 RVA: 0x003A3428 File Offset: 0x003A1628
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6AB RID: 63147 RVA: 0x003A3464 File Offset: 0x003A1664
			[CallerCount(0)]
			public unsafe bool _OnInitialize_b__14_0(GuestsManager.OrderBase orderData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__14_0_Internal_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F6AC RID: 63148 RVA: 0x003A34B4 File Offset: 0x003A16B4
			[CallerCount(0)]
			public unsafe bool _OnInitialize_b__14_4(GuestsManager.OrderBase orderData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.__c.NativeMethodInfoPtr__OnInitialize_b__14_4_Internal_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F6AD RID: 63149 RVA: 0x0008470B File Offset: 0x0008290B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005026 RID: 20518
			// (get) Token: 0x0600F6AE RID: 63150 RVA: 0x003A3504 File Offset: 0x003A1704
			// (set) Token: 0x0600F6AF RID: 63151 RVA: 0x00084714 File Offset: 0x00082914
			public unsafe static PartnerWaitressBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerWaitressBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerWaitressBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerWaitressBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005027 RID: 20519
			// (get) Token: 0x0600F6B0 RID: 63152 RVA: 0x003A352C File Offset: 0x003A172C
			// (set) Token: 0x0600F6B1 RID: 63153 RVA: 0x00084726 File Offset: 0x00082926
			public unsafe static Func<GuestsManager.OrderBase, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerWaitressBehaviour.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestsManager.OrderBase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerWaitressBehaviour.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005028 RID: 20520
			// (get) Token: 0x0600F6B2 RID: 63154 RVA: 0x003A3554 File Offset: 0x003A1754
			// (set) Token: 0x0600F6B3 RID: 63155 RVA: 0x00084738 File Offset: 0x00082938
			public unsafe static Func<GuestsManager.OrderBase, bool> __9__14_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerWaitressBehaviour.__c.NativeFieldInfoPtr___9__14_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestsManager.OrderBase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerWaitressBehaviour.__c.NativeFieldInfoPtr___9__14_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D19 RID: 40217
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009D1A RID: 40218
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04009D1B RID: 40219
			private static readonly IntPtr NativeFieldInfoPtr___9__14_4;

			// Token: 0x04009D1C RID: 40220
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D1D RID: 40221
			private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__14_0_Internal_Boolean_OrderBase_0;

			// Token: 0x04009D1E RID: 40222
			private static readonly IntPtr NativeMethodInfoPtr__OnInitialize_b__14_4_Internal_Boolean_OrderBase_0;
		}

		// Token: 0x02000D86 RID: 3462
		[ObfuscatedName("GameData.Profile.PartnerWaitressBehaviour+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F6B4 RID: 63156 RVA: 0x003A357C File Offset: 0x003A177C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<PartnerWaitressBehaviour.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c__DisplayClass19_0>.NativeClassPtr);
				PartnerWaitressBehaviour.__c__DisplayClass19_0.NativeFieldInfoPtr_requestedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c__DisplayClass19_0>.NativeClassPtr, "requestedData");
				PartnerWaitressBehaviour.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c__DisplayClass19_0>.NativeClassPtr, 100683266);
				PartnerWaitressBehaviour.__c__DisplayClass19_0.NativeMethodInfoPtr__HasInventorySufficientForTargetOrder_b__0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c__DisplayClass19_0>.NativeClassPtr, 100683267);
				PartnerWaitressBehaviour.__c__DisplayClass19_0.NativeMethodInfoPtr__HasInventorySufficientForTargetOrder_b__1_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c__DisplayClass19_0>.NativeClassPtr, 100683268);
			}

			// Token: 0x0600F6B5 RID: 63157 RVA: 0x003A35F8 File Offset: 0x003A17F8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerWaitressBehaviour.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6B6 RID: 63158 RVA: 0x003A3634 File Offset: 0x003A1834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239046, XrefRangeEnd = 239047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasInventorySufficientForTargetOrder_b__0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.__c__DisplayClass19_0.NativeMethodInfoPtr__HasInventorySufficientForTargetOrder_b__0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F6B7 RID: 63159 RVA: 0x003A3688 File Offset: 0x003A1888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasInventorySufficientForTargetOrder_b__1(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour.__c__DisplayClass19_0.NativeMethodInfoPtr__HasInventorySufficientForTargetOrder_b__1_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F6B8 RID: 63160 RVA: 0x0008474A File Offset: 0x0008294A
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005029 RID: 20521
			// (get) Token: 0x0600F6B9 RID: 63161 RVA: 0x003A36D8 File Offset: 0x003A18D8
			// (set) Token: 0x0600F6BA RID: 63162 RVA: 0x00084753 File Offset: 0x00082953
			public unsafe int requestedData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.__c__DisplayClass19_0.NativeFieldInfoPtr_requestedData);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour.__c__DisplayClass19_0.NativeFieldInfoPtr_requestedData)) = value;
				}
			}

			// Token: 0x04009D1F RID: 40223
			private static readonly IntPtr NativeFieldInfoPtr_requestedData;

			// Token: 0x04009D20 RID: 40224
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D21 RID: 40225
			private static readonly IntPtr NativeMethodInfoPtr__HasInventorySufficientForTargetOrder_b__0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04009D22 RID: 40226
			private static readonly IntPtr NativeMethodInfoPtr__HasInventorySufficientForTargetOrder_b__1_Internal_Boolean_Sellable_0;
		}

		// Token: 0x02000D87 RID: 3463
		[ObfuscatedName("GameData.Profile.PartnerWaitressBehaviour+<EmployeeExtractFromInventoryCoroutine>d__30")]
		public sealed class _EmployeeExtractFromInventoryCoroutine_d__30 : Il2CppSystem.Object
		{
			// Token: 0x0600F6BB RID: 63163 RVA: 0x003A3700 File Offset: 0x003A1900
			// Note: this type is marked as 'beforefieldinit'.
			static _EmployeeExtractFromInventoryCoroutine_d__30()
			{
				Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "<EmployeeExtractFromInventoryCoroutine>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30>.NativeClassPtr);
				PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30>.NativeClassPtr, "<>1__state");
				PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30>.NativeClassPtr, "<>2__current");
				PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30>.NativeClassPtr, "<>4__this");
				PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30>.NativeClassPtr, 100683269);
				PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30>.NativeClassPtr, 100683270);
				PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30>.NativeClassPtr, 100683271);
				PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30>.NativeClassPtr, 100683272);
				PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30>.NativeClassPtr, 100683273);
				PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30>.NativeClassPtr, 100683274);
			}

			// Token: 0x0600F6BC RID: 63164 RVA: 0x003A37E0 File Offset: 0x003A19E0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EmployeeExtractFromInventoryCoroutine_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6BD RID: 63165 RVA: 0x003A3828 File Offset: 0x003A1A28
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6BE RID: 63166 RVA: 0x003A385C File Offset: 0x003A1A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239047, XrefRangeEnd = 239065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700502D RID: 20525
			// (get) Token: 0x0600F6BF RID: 63167 RVA: 0x003A3898 File Offset: 0x003A1A98
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F6C0 RID: 63168 RVA: 0x003A38D8 File Offset: 0x003A1AD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239065, XrefRangeEnd = 239071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700502E RID: 20526
			// (get) Token: 0x0600F6C1 RID: 63169 RVA: 0x003A390C File Offset: 0x003A1B0C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F6C2 RID: 63170 RVA: 0x0008476E File Offset: 0x0008296E
			public _EmployeeExtractFromInventoryCoroutine_d__30(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700502A RID: 20522
			// (get) Token: 0x0600F6C3 RID: 63171 RVA: 0x003A394C File Offset: 0x003A1B4C
			// (set) Token: 0x0600F6C4 RID: 63172 RVA: 0x00084777 File Offset: 0x00082977
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700502B RID: 20523
			// (get) Token: 0x0600F6C5 RID: 63173 RVA: 0x003A3974 File Offset: 0x003A1B74
			// (set) Token: 0x0600F6C6 RID: 63174 RVA: 0x00084792 File Offset: 0x00082992
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700502C RID: 20524
			// (get) Token: 0x0600F6C7 RID: 63175 RVA: 0x003A39A4 File Offset: 0x003A1BA4
			// (set) Token: 0x0600F6C8 RID: 63176 RVA: 0x000847B1 File Offset: 0x000829B1
			public unsafe PartnerWaitressBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerWaitressBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._EmployeeExtractFromInventoryCoroutine_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D23 RID: 40227
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009D24 RID: 40228
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009D25 RID: 40229
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009D26 RID: 40230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009D27 RID: 40231
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D28 RID: 40232
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009D29 RID: 40233
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009D2A RID: 40234
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D2B RID: 40235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D88 RID: 3464
		[ObfuscatedName("GameData.Profile.PartnerWaitressBehaviour+<EmployeeDeliver>d__39")]
		public sealed class _EmployeeDeliver_d__39 : Il2CppSystem.Object
		{
			// Token: 0x0600F6C9 RID: 63177 RVA: 0x003A39D4 File Offset: 0x003A1BD4
			// Note: this type is marked as 'beforefieldinit'.
			static _EmployeeDeliver_d__39()
			{
				Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeDeliver_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "<EmployeeDeliver>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeDeliver_d__39>.NativeClassPtr);
				PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeDeliver_d__39>.NativeClassPtr, "<>1__state");
				PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeDeliver_d__39>.NativeClassPtr, "<>2__current");
				PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeDeliver_d__39>.NativeClassPtr, "<>4__this");
				PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeDeliver_d__39>.NativeClassPtr, 100683275);
				PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeDeliver_d__39>.NativeClassPtr, 100683276);
				PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeDeliver_d__39>.NativeClassPtr, 100683277);
				PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeDeliver_d__39>.NativeClassPtr, 100683278);
				PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeDeliver_d__39>.NativeClassPtr, 100683279);
				PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeDeliver_d__39>.NativeClassPtr, 100683280);
			}

			// Token: 0x0600F6CA RID: 63178 RVA: 0x003A3AB4 File Offset: 0x003A1CB4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EmployeeDeliver_d__39(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerWaitressBehaviour._EmployeeDeliver_d__39>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6CB RID: 63179 RVA: 0x003A3AFC File Offset: 0x003A1CFC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6CC RID: 63180 RVA: 0x003A3B30 File Offset: 0x003A1D30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239071, XrefRangeEnd = 239116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005032 RID: 20530
			// (get) Token: 0x0600F6CD RID: 63181 RVA: 0x003A3B6C File Offset: 0x003A1D6C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F6CE RID: 63182 RVA: 0x003A3BAC File Offset: 0x003A1DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239116, XrefRangeEnd = 239122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005033 RID: 20531
			// (get) Token: 0x0600F6CF RID: 63183 RVA: 0x003A3BE0 File Offset: 0x003A1DE0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F6D0 RID: 63184 RVA: 0x000847D0 File Offset: 0x000829D0
			public _EmployeeDeliver_d__39(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700502F RID: 20527
			// (get) Token: 0x0600F6D1 RID: 63185 RVA: 0x003A3C20 File Offset: 0x003A1E20
			// (set) Token: 0x0600F6D2 RID: 63186 RVA: 0x000847D9 File Offset: 0x000829D9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005030 RID: 20528
			// (get) Token: 0x0600F6D3 RID: 63187 RVA: 0x003A3C48 File Offset: 0x003A1E48
			// (set) Token: 0x0600F6D4 RID: 63188 RVA: 0x000847F4 File Offset: 0x000829F4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005031 RID: 20529
			// (get) Token: 0x0600F6D5 RID: 63189 RVA: 0x003A3C78 File Offset: 0x003A1E78
			// (set) Token: 0x0600F6D6 RID: 63190 RVA: 0x00084813 File Offset: 0x00082A13
			public unsafe PartnerWaitressBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerWaitressBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._EmployeeDeliver_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D2C RID: 40236
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009D2D RID: 40237
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009D2E RID: 40238
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009D2F RID: 40239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009D30 RID: 40240
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D31 RID: 40241
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009D32 RID: 40242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009D33 RID: 40243
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D34 RID: 40244
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D89 RID: 3465
		[ObfuscatedName("GameData.Profile.PartnerWaitressBehaviour+<ExecuteThrowDeliver>d__41")]
		public sealed class _ExecuteThrowDeliver_d__41 : Il2CppSystem.Object
		{
			// Token: 0x0600F6D7 RID: 63191 RVA: 0x003A3CA8 File Offset: 0x003A1EA8
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteThrowDeliver_d__41()
			{
				Il2CppClassPointerStore<PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerWaitressBehaviour>.NativeClassPtr, "<ExecuteThrowDeliver>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41>.NativeClassPtr);
				PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41>.NativeClassPtr, "<>1__state");
				PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41>.NativeClassPtr, "<>2__current");
				PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41>.NativeClassPtr, "<>4__this");
				PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeFieldInfoPtr_isSpecial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41>.NativeClassPtr, "isSpecial");
				PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41>.NativeClassPtr, 100683281);
				PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41>.NativeClassPtr, 100683282);
				PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41>.NativeClassPtr, 100683283);
				PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41>.NativeClassPtr, 100683284);
				PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41>.NativeClassPtr, 100683285);
				PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41>.NativeClassPtr, 100683286);
			}

			// Token: 0x0600F6D8 RID: 63192 RVA: 0x003A3D9C File Offset: 0x003A1F9C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteThrowDeliver_d__41(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6D9 RID: 63193 RVA: 0x003A3DE4 File Offset: 0x003A1FE4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6DA RID: 63194 RVA: 0x003A3E18 File Offset: 0x003A2018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239122, XrefRangeEnd = 239252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005038 RID: 20536
			// (get) Token: 0x0600F6DB RID: 63195 RVA: 0x003A3E54 File Offset: 0x003A2054
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F6DC RID: 63196 RVA: 0x003A3E94 File Offset: 0x003A2094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239252, XrefRangeEnd = 239258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005039 RID: 20537
			// (get) Token: 0x0600F6DD RID: 63197 RVA: 0x003A3EC8 File Offset: 0x003A20C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F6DE RID: 63198 RVA: 0x00084832 File Offset: 0x00082A32
			public _ExecuteThrowDeliver_d__41(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005034 RID: 20532
			// (get) Token: 0x0600F6DF RID: 63199 RVA: 0x003A3F08 File Offset: 0x003A2108
			// (set) Token: 0x0600F6E0 RID: 63200 RVA: 0x0008483B File Offset: 0x00082A3B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005035 RID: 20533
			// (get) Token: 0x0600F6E1 RID: 63201 RVA: 0x003A3F30 File Offset: 0x003A2130
			// (set) Token: 0x0600F6E2 RID: 63202 RVA: 0x00084856 File Offset: 0x00082A56
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005036 RID: 20534
			// (get) Token: 0x0600F6E3 RID: 63203 RVA: 0x003A3F60 File Offset: 0x003A2160
			// (set) Token: 0x0600F6E4 RID: 63204 RVA: 0x00084875 File Offset: 0x00082A75
			public unsafe PartnerWaitressBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerWaitressBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005037 RID: 20535
			// (get) Token: 0x0600F6E5 RID: 63205 RVA: 0x003A3F90 File Offset: 0x003A2190
			// (set) Token: 0x0600F6E6 RID: 63206 RVA: 0x00084894 File Offset: 0x00082A94
			public unsafe bool isSpecial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeFieldInfoPtr_isSpecial);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerWaitressBehaviour._ExecuteThrowDeliver_d__41.NativeFieldInfoPtr_isSpecial)) = value;
				}
			}

			// Token: 0x04009D35 RID: 40245
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009D36 RID: 40246
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009D37 RID: 40247
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009D38 RID: 40248
			private static readonly IntPtr NativeFieldInfoPtr_isSpecial;

			// Token: 0x04009D39 RID: 40249
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009D3A RID: 40250
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D3B RID: 40251
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009D3C RID: 40252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009D3D RID: 40253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D3E RID: 40254
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
