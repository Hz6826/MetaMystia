using System;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using NightScene.GuestManagementUtility;
using NightScene.UI.GuestManagementUtility;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Night.UI.HUD.Ordering
{
	// Token: 0x02000051 RID: 81
	public class OrderController : MonoBehaviour
	{
		// Token: 0x06000A55 RID: 2645 RVA: 0x000BEE9C File Offset: 0x000BD09C
		// Note: this type is marked as 'beforefieldinit'.
		static OrderController()
		{
			Il2CppClassPointerStore<OrderController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.UI.HUD.Ordering", "OrderController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderController>.NativeClassPtr);
			OrderController.NativeFieldInfoPtr_m_UniqueInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "m_UniqueInstance");
			OrderController.NativeFieldInfoPtr_m_Orders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "m_Orders");
			OrderController.NativeFieldInfoPtr_m_SelectionIndexHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "m_SelectionIndexHandler");
			OrderController.NativeFieldInfoPtr_m_OrderField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "m_OrderField");
			OrderController.NativeFieldInfoPtr_m_GhostField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "m_GhostField");
			OrderController.NativeFieldInfoPtr_m_CookerSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "m_CookerSprite");
			OrderController.NativeFieldInfoPtr_m_WaitressSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "m_WaitressSprite");
			OrderController.NativeFieldInfoPtr_m_BarmaidSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "m_BarmaidSprite");
			OrderController.NativeFieldInfoPtr_m_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "m_CanvasGroup");
			OrderController.NativeFieldInfoPtr_m_StringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "m_StringBuilder");
			OrderController.NativeMethodInfoPtr_get_Instance_Private_Static_get_OrderController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100664990);
			OrderController.NativeMethodInfoPtr_add_OnFocusingDeskCodeChanged_Public_Static_add_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100664991);
			OrderController.NativeMethodInfoPtr_remove_OnFocusingDeskCodeChanged_Public_Static_rem_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100664992);
			OrderController.NativeMethodInfoPtr_HasValidOrder_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100664993);
			OrderController.NativeMethodInfoPtr_AddOrder_Public_Static_Void_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100664994);
			OrderController.NativeMethodInfoPtr_RemoveOrder_Public_Static_Void_Predicate_1_OrderBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100664995);
			OrderController.NativeMethodInfoPtr_TryFocusToOrder_Public_Static_Void_Predicate_1_OrderBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100664996);
			OrderController.NativeMethodInfoPtr_MoveActionPerformed_Public_Static_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100664997);
			OrderController.NativeMethodInfoPtr_SetPartnerOrderData_Public_Static_Void_Int32_Nullable_1_PartnerType_SellableType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100664998);
			OrderController.NativeMethodInfoPtr_TryGetCurrentSelectedDeskCode_Public_Static_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100664999);
			OrderController.NativeMethodInfoPtr_GetShowInUIOrders_Public_Static_IEnumerable_1_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665000);
			OrderController.NativeMethodInfoPtr_TryUpdateToCurrentOrder_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665001);
			OrderController.NativeMethodInfoPtr_IsOrderOpen_Public_Static_Boolean_OrderingElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665002);
			OrderController.NativeMethodInfoPtr_IsOrderOpen_Public_Static_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665003);
			OrderController.NativeMethodInfoPtr_get_CanvasGroup_Public_Static_get_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665004);
			OrderController.NativeMethodInfoPtr_get_OrderField_Public_Static_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665005);
			OrderController.NativeMethodInfoPtr_get_GhostField_Public_Static_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665006);
			OrderController.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665007);
			OrderController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665008);
			OrderController.NativeMethodInfoPtr_get_CurrentSelectionIndex_Private_get_CurrentSelectionIndexHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665009);
			OrderController.NativeMethodInfoPtr_HasOrderImpl_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665010);
			OrderController.NativeMethodInfoPtr_HasValidOrderImpl_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665011);
			OrderController.NativeMethodInfoPtr_AddOrderImpl_Private_Void_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665012);
			OrderController.NativeMethodInfoPtr_RemoveOrderImpl_Private_Void_Predicate_1_OrderBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665013);
			OrderController.NativeMethodInfoPtr_TryFocusToOrderImpl_Private_Void_Predicate_1_OrderBase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665014);
			OrderController.NativeMethodInfoPtr_TryUpdateToCurrentOrderImpl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665015);
			OrderController.NativeMethodInfoPtr_MoveActionPerformedImpl_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665016);
			OrderController.NativeMethodInfoPtr_SetPartnerOrderDataImpl_Private_Void_Int32_Nullable_1_PartnerType_SellableType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665017);
			OrderController.NativeMethodInfoPtr_TryGetCurrentSelectedDeskCodeImpl_Private_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665018);
			OrderController.NativeMethodInfoPtr_GetShowInUIOrdersImpl_Private_IEnumerable_1_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665019);
			OrderController.NativeMethodInfoPtr_CreateOrderingElement_Private_OrderingElement_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665020);
			OrderController.NativeMethodInfoPtr_SetHighlight_Private_Void_OrderingElement_Nullable_1_PartnerType_SellableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665021);
			OrderController.NativeMethodInfoPtr_MapElement_Private_Static_OrderBase_OrderingElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665022);
			OrderController.NativeMethodInfoPtr_PrintOrderContent_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665023);
			OrderController.NativeMethodInfoPtr_Match_Private_Static_Boolean_IList_1_TListElement_Func_2_TListElement_TPredicateElement_Predicate_1_TPredicateElement_byref_TListElement_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665024);
			OrderController.NativeMethodInfoPtr_FindValidIndex_Private_Int32_Int32_FindType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665025);
			OrderController.NativeMethodInfoPtr_IsSelectionIndexValid_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665026);
			OrderController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665027);
			OrderController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController>.NativeClassPtr, 100665028);
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x000BF2A0 File Offset: 0x000BD4A0
		public unsafe static OrderController Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39863, XrefRangeEnd = 39865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_get_Instance_Private_Static_get_OrderController_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OrderController>(intPtr3) : null;
			}
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x000BF2D4 File Offset: 0x000BD4D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39873, RefRangeEnd = 39874, XrefRangeStart = 39865, XrefRangeEnd = 39873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnFocusingDeskCodeChanged(Action<int> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_add_OnFocusingDeskCodeChanged_Public_Static_add_Void_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x000BF30C File Offset: 0x000BD50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39874, XrefRangeEnd = 39882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnFocusingDeskCodeChanged(Action<int> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_remove_OnFocusingDeskCodeChanged_Public_Static_rem_Void_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x000BF344 File Offset: 0x000BD544
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 39886, RefRangeEnd = 39889, XrefRangeStart = 39882, XrefRangeEnd = 39886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasValidOrder()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_HasValidOrder_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x000BF374 File Offset: 0x000BD574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39889, XrefRangeEnd = 39893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddOrder(GuestsManager.OrderBase orderBase)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_AddOrder_Public_Static_Void_OrderBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x000BF3AC File Offset: 0x000BD5AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39897, RefRangeEnd = 39898, XrefRangeStart = 39893, XrefRangeEnd = 39897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveOrder(Predicate<GuestsManager.OrderBase> selector, string debugMessage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_RemoveOrder_Public_Static_Void_Predicate_1_OrderBase_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x000BF3F4 File Offset: 0x000BD5F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39914, RefRangeEnd = 39915, XrefRangeStart = 39898, XrefRangeEnd = 39914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryFocusToOrder(Predicate<GuestsManager.OrderBase> selector, string debugMessage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_TryFocusToOrder_Public_Static_Void_Predicate_1_OrderBase_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000BF43C File Offset: 0x000BD63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39915, XrefRangeEnd = 39925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveActionPerformed(InputAction.CallbackContext callbackContext)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_MoveActionPerformed_Public_Static_Void_CallbackContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x000BF478 File Offset: 0x000BD678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39925, XrefRangeEnd = 39928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPartnerOrderData(int deskCode, Nullable<PartnerBase.PartnerType> partnerType, Sellable.SellableType sellableType, string debugMessage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(partnerType));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sellableType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_SetPartnerOrderData_Public_Static_Void_Int32_Nullable_1_PartnerType_SellableType_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x000BF4E4 File Offset: 0x000BD6E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 39937, RefRangeEnd = 39940, XrefRangeStart = 39928, XrefRangeEnd = 39937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetCurrentSelectedDeskCode(out int deskCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_TryGetCurrentSelectedDeskCode_Public_Static_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000BF524 File Offset: 0x000BD724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39948, RefRangeEnd = 39949, XrefRangeStart = 39940, XrefRangeEnd = 39948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<GuestsManager.OrderBase> GetShowInUIOrders()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_GetShowInUIOrders_Public_Static_IEnumerable_1_OrderBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<GuestsManager.OrderBase>>(intPtr3) : null;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000BF558 File Offset: 0x000BD758
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 39955, RefRangeEnd = 39960, XrefRangeStart = 39949, XrefRangeEnd = 39955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TryUpdateToCurrentOrder()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_TryUpdateToCurrentOrder_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x000BF580 File Offset: 0x000BD780
		[CallerCount(0)]
		public unsafe static bool IsOrderOpen(OrderingElement element)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_IsOrderOpen_Public_Static_Boolean_OrderingElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x000BF5C4 File Offset: 0x000BD7C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39960, RefRangeEnd = 39961, XrefRangeStart = 39960, XrefRangeEnd = 39960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOrderOpen(GuestsManager.OrderBase order)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(order);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_IsOrderOpen_Public_Static_Boolean_OrderBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x000BF608 File Offset: 0x000BD808
		public unsafe static CanvasGroup CanvasGroup
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39963, RefRangeEnd = 39964, XrefRangeStart = 39961, XrefRangeEnd = 39963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_get_CanvasGroup_Public_Static_get_CanvasGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr3) : null;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x000BF63C File Offset: 0x000BD83C
		public unsafe static RectTransform OrderField
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39966, RefRangeEnd = 39967, XrefRangeStart = 39964, XrefRangeEnd = 39966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_get_OrderField_Public_Static_get_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x000BF670 File Offset: 0x000BD870
		public unsafe static RectTransform GhostField
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39969, RefRangeEnd = 39970, XrefRangeStart = 39967, XrefRangeEnd = 39969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_get_GhostField_Public_Static_get_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000BF6A4 File Offset: 0x000BD8A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39978, RefRangeEnd = 39979, XrefRangeStart = 39970, XrefRangeEnd = 39978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000BF6D8 File Offset: 0x000BD8D8
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x000BF70C File Offset: 0x000BD90C
		public unsafe OrderController.CurrentSelectionIndexHandler CurrentSelectionIndex
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 39985, RefRangeEnd = 40006, XrefRangeStart = 39979, XrefRangeEnd = 39985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_get_CurrentSelectionIndex_Private_get_CurrentSelectionIndexHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OrderController.CurrentSelectionIndexHandler>(intPtr3) : null;
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x000BF74C File Offset: 0x000BD94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40006, XrefRangeEnd = 40007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasOrderImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_HasOrderImpl_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x000BF788 File Offset: 0x000BD988
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 40017, RefRangeEnd = 40022, XrefRangeStart = 40007, XrefRangeEnd = 40017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasValidOrderImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_HasValidOrderImpl_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x000BF7C4 File Offset: 0x000BD9C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40086, RefRangeEnd = 40087, XrefRangeStart = 40022, XrefRangeEnd = 40086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOrderImpl(GuestsManager.OrderBase orderBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_AddOrderImpl_Private_Void_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x000BF808 File Offset: 0x000BDA08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40122, RefRangeEnd = 40123, XrefRangeStart = 40087, XrefRangeEnd = 40122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOrderImpl(Predicate<GuestsManager.OrderBase> selector, string debugMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_RemoveOrderImpl_Private_Void_Predicate_1_OrderBase_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x000BF85C File Offset: 0x000BDA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40123, XrefRangeEnd = 40137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryFocusToOrderImpl(Predicate<GuestsManager.OrderBase> selector, string debugMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_TryFocusToOrderImpl_Private_Void_Predicate_1_OrderBase_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000BF8B0 File Offset: 0x000BDAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40137, XrefRangeEnd = 40141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryUpdateToCurrentOrderImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_TryUpdateToCurrentOrderImpl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x000BF8E4 File Offset: 0x000BDAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40141, XrefRangeEnd = 40149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveActionPerformedImpl(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_MoveActionPerformedImpl_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x000BF92C File Offset: 0x000BDB2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40178, RefRangeEnd = 40179, XrefRangeStart = 40149, XrefRangeEnd = 40178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPartnerOrderDataImpl(int deskCode, Nullable<PartnerBase.PartnerType> partnerType, Sellable.SellableType sellableType, string debugMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(partnerType));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sellableType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_SetPartnerOrderDataImpl_Private_Void_Int32_Nullable_1_PartnerType_SellableType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x000BF9A4 File Offset: 0x000BDBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40179, XrefRangeEnd = 40185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetCurrentSelectedDeskCodeImpl(out int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_TryGetCurrentSelectedDeskCodeImpl_Private_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x000BF9F0 File Offset: 0x000BDBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40185, XrefRangeEnd = 40191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<GuestsManager.OrderBase> GetShowInUIOrdersImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_GetShowInUIOrdersImpl_Private_IEnumerable_1_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<GuestsManager.OrderBase>>(intPtr3) : null;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x000BFA30 File Offset: 0x000BDC30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40217, RefRangeEnd = 40218, XrefRangeStart = 40191, XrefRangeEnd = 40217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrderingElement CreateOrderingElement(GuestsManager.OrderBase orderBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_CreateOrderingElement_Private_OrderingElement_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OrderingElement>(intPtr3) : null;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x000BFA80 File Offset: 0x000BDC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40218, XrefRangeEnd = 40227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHighlight(OrderingElement orderingElement, Nullable<PartnerBase.PartnerType> partnerType, Sellable.SellableType sellableType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderingElement);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(partnerType));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sellableType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_SetHighlight_Private_Void_OrderingElement_Nullable_1_PartnerType_SellableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x000BFAE8 File Offset: 0x000BDCE8
		[CallerCount(0)]
		public unsafe static GuestsManager.OrderBase MapElement(OrderingElement orderingElement)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderingElement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_MapElement_Private_Static_OrderBase_OrderingElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr3) : null;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x000BFB2C File Offset: 0x000BDD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40227, XrefRangeEnd = 40254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PrintOrderContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_PrintOrderContent_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000BFB64 File Offset: 0x000BDD64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 40260, RefRangeEnd = 40264, XrefRangeStart = 40254, XrefRangeEnd = 40260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Match<TListElement, TPredicateElement>(IList<TListElement> list, Func<TListElement, TPredicateElement> mapHandler, Predicate<TPredicateElement> selector, out TListElement matchResult, out int index) where TListElement : class
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mapHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TListElement).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref matchResult;
			}
			ptr2 = intPtr2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(OrderController.MethodInfoStoreGeneric_Match_Private_Static_Boolean_IList_1_TListElement_Func_2_TListElement_TPredicateElement_Predicate_1_TPredicateElement_byref_TListElement_byref_Int32_0<TListElement, TPredicateElement>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TListElement).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				matchResult = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TListElement>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x000BFC28 File Offset: 0x000BDE28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 40273, RefRangeEnd = 40277, XrefRangeStart = 40264, XrefRangeEnd = 40273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindValidIndex(int currentIndex, OrderController.FindType findType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref findType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_FindValidIndex_Private_Int32_Int32_FindType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x000BFC80 File Offset: 0x000BDE80
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 40281, RefRangeEnd = 40291, XrefRangeStart = 40277, XrefRangeEnd = 40281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSelectionIndexValid(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr_IsSelectionIndexValid_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x000BFCCC File Offset: 0x000BDECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40291, XrefRangeEnd = 40306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrderController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x000BFD08 File Offset: 0x000BDF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40306, XrefRangeEnd = 40315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrderController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00007C78 File Offset: 0x00005E78
		public OrderController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x000BFD44 File Offset: 0x000BDF44
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x00007C81 File Offset: 0x00005E81
		public unsafe static OrderController m_UniqueInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OrderController.NativeFieldInfoPtr_m_UniqueInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrderController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrderController.NativeFieldInfoPtr_m_UniqueInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x000BFD6C File Offset: 0x000BDF6C
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x00007C93 File Offset: 0x00005E93
		public unsafe List<OrderingElement> m_Orders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_Orders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<OrderingElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_Orders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x000BFD9C File Offset: 0x000BDF9C
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x00007CB2 File Offset: 0x00005EB2
		public unsafe OrderController.CurrentSelectionIndexHandler m_SelectionIndexHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_SelectionIndexHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrderController.CurrentSelectionIndexHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_SelectionIndexHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x000BFDCC File Offset: 0x000BDFCC
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x00007CD1 File Offset: 0x00005ED1
		public unsafe RectTransform m_OrderField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_OrderField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_OrderField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x000BFDFC File Offset: 0x000BDFFC
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x00007CF0 File Offset: 0x00005EF0
		public unsafe RectTransform m_GhostField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_GhostField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_GhostField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x000BFE2C File Offset: 0x000BE02C
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x00007D0F File Offset: 0x00005F0F
		public unsafe Sprite m_CookerSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_CookerSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_CookerSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x000BFE5C File Offset: 0x000BE05C
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x00007D2E File Offset: 0x00005F2E
		public unsafe Sprite m_WaitressSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_WaitressSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_WaitressSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x000BFE8C File Offset: 0x000BE08C
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x00007D4D File Offset: 0x00005F4D
		public unsafe Sprite m_BarmaidSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_BarmaidSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_BarmaidSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x000BFEBC File Offset: 0x000BE0BC
		// (set) Token: 0x06000A8F RID: 2703 RVA: 0x00007D6C File Offset: 0x00005F6C
		public unsafe CanvasGroup m_CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000A90 RID: 2704 RVA: 0x000BFEEC File Offset: 0x000BE0EC
		// (set) Token: 0x06000A91 RID: 2705 RVA: 0x00007D8B File Offset: 0x00005F8B
		public unsafe StringBuilder m_StringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_StringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.NativeFieldInfoPtr_m_StringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr_m_UniqueInstance;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeFieldInfoPtr_m_Orders;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionIndexHandler;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeFieldInfoPtr_m_OrderField;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr_m_GhostField;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerSprite;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitressSprite;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_m_BarmaidSprite;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasGroup;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeFieldInfoPtr_m_StringBuilder;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Private_Static_get_OrderController_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_add_OnFocusingDeskCodeChanged_Public_Static_add_Void_Action_1_Int32_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnFocusingDeskCodeChanged_Public_Static_rem_Void_Action_1_Int32_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_HasValidOrder_Public_Static_Boolean_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_AddOrder_Public_Static_Void_OrderBase_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOrder_Public_Static_Void_Predicate_1_OrderBase_String_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_TryFocusToOrder_Public_Static_Void_Predicate_1_OrderBase_String_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_MoveActionPerformed_Public_Static_Void_CallbackContext_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_SetPartnerOrderData_Public_Static_Void_Int32_Nullable_1_PartnerType_SellableType_String_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCurrentSelectedDeskCode_Public_Static_Boolean_byref_Int32_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_GetShowInUIOrders_Public_Static_IEnumerable_1_OrderBase_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateToCurrentOrder_Public_Static_Void_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr_IsOrderOpen_Public_Static_Boolean_OrderingElement_0;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeMethodInfoPtr_IsOrderOpen_Public_Static_Boolean_OrderBase_0;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr_get_CanvasGroup_Public_Static_get_CanvasGroup_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr_get_OrderField_Public_Static_get_RectTransform_0;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_get_GhostField_Public_Static_get_RectTransform_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSelectionIndex_Private_get_CurrentSelectionIndexHandler_0;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_HasOrderImpl_Private_Boolean_0;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_HasValidOrderImpl_Private_Boolean_0;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_AddOrderImpl_Private_Void_OrderBase_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOrderImpl_Private_Void_Predicate_1_OrderBase_String_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_TryFocusToOrderImpl_Private_Void_Predicate_1_OrderBase_String_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateToCurrentOrderImpl_Private_Void_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_MoveActionPerformedImpl_Private_Void_CallbackContext_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_SetPartnerOrderDataImpl_Private_Void_Int32_Nullable_1_PartnerType_SellableType_String_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCurrentSelectedDeskCodeImpl_Private_Boolean_byref_Int32_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_GetShowInUIOrdersImpl_Private_IEnumerable_1_OrderBase_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_CreateOrderingElement_Private_OrderingElement_OrderBase_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_SetHighlight_Private_Void_OrderingElement_Nullable_1_PartnerType_SellableType_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_MapElement_Private_Static_OrderBase_OrderingElement_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_PrintOrderContent_Private_String_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_Match_Private_Static_Boolean_IList_1_TListElement_Func_2_TListElement_TPredicateElement_Predicate_1_TPredicateElement_byref_TListElement_byref_Int32_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_FindValidIndex_Private_Int32_Int32_FindType_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_IsSelectionIndexValid_Private_Boolean_Int32_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000518 RID: 1304
		public class OrderingElementDeskCodeComparer : Il2CppSystem.Object
		{
			// Token: 0x060084CA RID: 33994 RVA: 0x002534E8 File Offset: 0x002516E8
			// Note: this type is marked as 'beforefieldinit'.
			static OrderingElementDeskCodeComparer()
			{
				Il2CppClassPointerStore<OrderController.OrderingElementDeskCodeComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "OrderingElementDeskCodeComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderController.OrderingElementDeskCodeComparer>.NativeClassPtr);
				OrderController.OrderingElementDeskCodeComparer.NativeFieldInfoPtr__Default_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController.OrderingElementDeskCodeComparer>.NativeClassPtr, "<Default>k__BackingField");
				OrderController.OrderingElementDeskCodeComparer.NativeMethodInfoPtr_get_Default_Public_Static_get_OrderingElementDeskCodeComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.OrderingElementDeskCodeComparer>.NativeClassPtr, 100665029);
				OrderController.OrderingElementDeskCodeComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_OrderingElement_OrderingElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.OrderingElementDeskCodeComparer>.NativeClassPtr, 100665030);
				OrderController.OrderingElementDeskCodeComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.OrderingElementDeskCodeComparer>.NativeClassPtr, 100665031);
			}

			// Token: 0x17002C9B RID: 11419
			// (get) Token: 0x060084CB RID: 33995 RVA: 0x00253564 File Offset: 0x00251764
			public unsafe static OrderController.OrderingElementDeskCodeComparer Default
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39789, XrefRangeEnd = 39793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.OrderingElementDeskCodeComparer.NativeMethodInfoPtr_get_Default_Public_Static_get_OrderingElementDeskCodeComparer_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<OrderController.OrderingElementDeskCodeComparer>(intPtr3) : null;
				}
			}

			// Token: 0x060084CC RID: 33996 RVA: 0x00253598 File Offset: 0x00251798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39793, XrefRangeEnd = 39805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(OrderingElement x, OrderingElement y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.OrderingElementDeskCodeComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_OrderingElement_OrderingElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060084CD RID: 33997 RVA: 0x002535F8 File Offset: 0x002517F8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrderingElementDeskCodeComparer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderController.OrderingElementDeskCodeComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.OrderingElementDeskCodeComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084CE RID: 33998 RVA: 0x0004775A File Offset: 0x0004595A
			public OrderingElementDeskCodeComparer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C9A RID: 11418
			// (get) Token: 0x060084CF RID: 33999 RVA: 0x00253634 File Offset: 0x00251834
			// (set) Token: 0x060084D0 RID: 34000 RVA: 0x00047763 File Offset: 0x00045963
			public unsafe static OrderController.OrderingElementDeskCodeComparer _Default_k__BackingField
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OrderController.OrderingElementDeskCodeComparer.NativeFieldInfoPtr__Default_k__BackingField, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrderController.OrderingElementDeskCodeComparer>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OrderController.OrderingElementDeskCodeComparer.NativeFieldInfoPtr__Default_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005752 RID: 22354
			private static readonly IntPtr NativeFieldInfoPtr__Default_k__BackingField;

			// Token: 0x04005753 RID: 22355
			private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_OrderingElementDeskCodeComparer_0;

			// Token: 0x04005754 RID: 22356
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_OrderingElement_OrderingElement_0;

			// Token: 0x04005755 RID: 22357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000519 RID: 1305
		public enum FindType
		{
			// Token: 0x04005757 RID: 22359
			Next,
			// Token: 0x04005758 RID: 22360
			Previous
		}

		// Token: 0x0200051A RID: 1306
		public class CurrentSelectionIndexHandler : Il2CppSystem.Object
		{
			// Token: 0x060084D1 RID: 34001 RVA: 0x0025365C File Offset: 0x0025185C
			// Note: this type is marked as 'beforefieldinit'.
			static CurrentSelectionIndexHandler()
			{
				Il2CppClassPointerStore<OrderController.CurrentSelectionIndexHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "CurrentSelectionIndexHandler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderController.CurrentSelectionIndexHandler>.NativeClassPtr);
				OrderController.CurrentSelectionIndexHandler.NativeFieldInfoPtr_OnFocusingDeskCodeChangedImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController.CurrentSelectionIndexHandler>.NativeClassPtr, "OnFocusingDeskCodeChangedImpl");
				OrderController.CurrentSelectionIndexHandler.NativeFieldInfoPtr_m_Orders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController.CurrentSelectionIndexHandler>.NativeClassPtr, "m_Orders");
				OrderController.CurrentSelectionIndexHandler.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController.CurrentSelectionIndexHandler>.NativeClassPtr, "<Value>k__BackingField");
				OrderController.CurrentSelectionIndexHandler.NativeMethodInfoPtr_add_OnFocusingDeskCodeChangedImpl_Public_add_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.CurrentSelectionIndexHandler>.NativeClassPtr, 100665033);
				OrderController.CurrentSelectionIndexHandler.NativeMethodInfoPtr_remove_OnFocusingDeskCodeChangedImpl_Public_rem_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.CurrentSelectionIndexHandler>.NativeClassPtr, 100665034);
				OrderController.CurrentSelectionIndexHandler.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_OrderingElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.CurrentSelectionIndexHandler>.NativeClassPtr, 100665035);
				OrderController.CurrentSelectionIndexHandler.NativeMethodInfoPtr_get_Value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.CurrentSelectionIndexHandler>.NativeClassPtr, 100665036);
				OrderController.CurrentSelectionIndexHandler.NativeMethodInfoPtr_set_Value_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.CurrentSelectionIndexHandler>.NativeClassPtr, 100665037);
				OrderController.CurrentSelectionIndexHandler.NativeMethodInfoPtr_UpdateSelectionIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.CurrentSelectionIndexHandler>.NativeClassPtr, 100665038);
			}

			// Token: 0x060084D2 RID: 34002 RVA: 0x0025373C File Offset: 0x0025193C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39805, XrefRangeEnd = 39810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void add_OnFocusingDeskCodeChangedImpl(Action<int> value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.CurrentSelectionIndexHandler.NativeMethodInfoPtr_add_OnFocusingDeskCodeChangedImpl_Public_add_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084D3 RID: 34003 RVA: 0x00253780 File Offset: 0x00251980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39810, XrefRangeEnd = 39815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void remove_OnFocusingDeskCodeChangedImpl(Action<int> value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.CurrentSelectionIndexHandler.NativeMethodInfoPtr_remove_OnFocusingDeskCodeChangedImpl_Public_rem_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084D4 RID: 34004 RVA: 0x002537C4 File Offset: 0x002519C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39815, XrefRangeEnd = 39817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CurrentSelectionIndexHandler(IReadOnlyList<OrderingElement> orders) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderController.CurrentSelectionIndexHandler>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orders);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.CurrentSelectionIndexHandler.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_OrderingElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002C9F RID: 11423
			// (get) Token: 0x060084D5 RID: 34005 RVA: 0x00253810 File Offset: 0x00251A10
			// (set) Token: 0x060084D6 RID: 34006 RVA: 0x0025384C File Offset: 0x00251A4C
			public unsafe int Value
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 39817, RefRangeEnd = 39820, XrefRangeStart = 39817, XrefRangeEnd = 39817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.CurrentSelectionIndexHandler.NativeMethodInfoPtr_get_Value_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.CurrentSelectionIndexHandler.NativeMethodInfoPtr_set_Value_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060084D7 RID: 34007 RVA: 0x0025388C File Offset: 0x00251A8C
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 39832, RefRangeEnd = 39840, XrefRangeStart = 39820, XrefRangeEnd = 39832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateSelectionIndex(int newIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref newIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.CurrentSelectionIndexHandler.NativeMethodInfoPtr_UpdateSelectionIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084D8 RID: 34008 RVA: 0x00047775 File Offset: 0x00045975
			public CurrentSelectionIndexHandler(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002C9C RID: 11420
			// (get) Token: 0x060084D9 RID: 34009 RVA: 0x002538CC File Offset: 0x00251ACC
			// (set) Token: 0x060084DA RID: 34010 RVA: 0x0004777E File Offset: 0x0004597E
			public unsafe Action<int> OnFocusingDeskCodeChangedImpl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.CurrentSelectionIndexHandler.NativeFieldInfoPtr_OnFocusingDeskCodeChangedImpl);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.CurrentSelectionIndexHandler.NativeFieldInfoPtr_OnFocusingDeskCodeChangedImpl), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C9D RID: 11421
			// (get) Token: 0x060084DB RID: 34011 RVA: 0x002538FC File Offset: 0x00251AFC
			// (set) Token: 0x060084DC RID: 34012 RVA: 0x0004779D File Offset: 0x0004599D
			public unsafe IReadOnlyList<OrderingElement> m_Orders
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.CurrentSelectionIndexHandler.NativeFieldInfoPtr_m_Orders);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<OrderingElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.CurrentSelectionIndexHandler.NativeFieldInfoPtr_m_Orders), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C9E RID: 11422
			// (get) Token: 0x060084DD RID: 34013 RVA: 0x0025392C File Offset: 0x00251B2C
			// (set) Token: 0x060084DE RID: 34014 RVA: 0x000477BC File Offset: 0x000459BC
			public unsafe int _Value_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.CurrentSelectionIndexHandler.NativeFieldInfoPtr__Value_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.CurrentSelectionIndexHandler.NativeFieldInfoPtr__Value_k__BackingField)) = value;
				}
			}

			// Token: 0x04005759 RID: 22361
			private static readonly IntPtr NativeFieldInfoPtr_OnFocusingDeskCodeChangedImpl;

			// Token: 0x0400575A RID: 22362
			private static readonly IntPtr NativeFieldInfoPtr_m_Orders;

			// Token: 0x0400575B RID: 22363
			private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

			// Token: 0x0400575C RID: 22364
			private static readonly IntPtr NativeMethodInfoPtr_add_OnFocusingDeskCodeChangedImpl_Public_add_Void_Action_1_Int32_0;

			// Token: 0x0400575D RID: 22365
			private static readonly IntPtr NativeMethodInfoPtr_remove_OnFocusingDeskCodeChangedImpl_Public_rem_Void_Action_1_Int32_0;

			// Token: 0x0400575E RID: 22366
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_OrderingElement_0;

			// Token: 0x0400575F RID: 22367
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int32_0;

			// Token: 0x04005760 RID: 22368
			private static readonly IntPtr NativeMethodInfoPtr_set_Value_Private_set_Void_Int32_0;

			// Token: 0x04005761 RID: 22369
			private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionIndex_Public_Void_Int32_0;
		}

		// Token: 0x0200051B RID: 1307
		[ObfuscatedName("Night.UI.HUD.Ordering.OrderController+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x060084DF RID: 34015 RVA: 0x00253954 File Offset: 0x00251B54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<OrderController.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderController.__c__DisplayClass31_0>.NativeClassPtr);
				OrderController.__c__DisplayClass31_0.NativeFieldInfoPtr_orderBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController.__c__DisplayClass31_0>.NativeClassPtr, "orderBase");
				OrderController.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.__c__DisplayClass31_0>.NativeClassPtr, 100665039);
				OrderController.__c__DisplayClass31_0.NativeMethodInfoPtr__AddOrderImpl_b__0_Internal_Boolean_OrderingElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.__c__DisplayClass31_0>.NativeClassPtr, 100665040);
			}

			// Token: 0x060084E0 RID: 34016 RVA: 0x002539BC File Offset: 0x00251BBC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderController.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084E1 RID: 34017 RVA: 0x002539F8 File Offset: 0x00251BF8
			[CallerCount(0)]
			public unsafe bool _AddOrderImpl_b__0(OrderingElement order)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(order);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.__c__DisplayClass31_0.NativeMethodInfoPtr__AddOrderImpl_b__0_Internal_Boolean_OrderingElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060084E2 RID: 34018 RVA: 0x000477D7 File Offset: 0x000459D7
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002CA0 RID: 11424
			// (get) Token: 0x060084E3 RID: 34019 RVA: 0x00253A48 File Offset: 0x00251C48
			// (set) Token: 0x060084E4 RID: 34020 RVA: 0x000477E0 File Offset: 0x000459E0
			public unsafe GuestsManager.OrderBase orderBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass31_0.NativeFieldInfoPtr_orderBase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass31_0.NativeFieldInfoPtr_orderBase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005762 RID: 22370
			private static readonly IntPtr NativeFieldInfoPtr_orderBase;

			// Token: 0x04005763 RID: 22371
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005764 RID: 22372
			private static readonly IntPtr NativeMethodInfoPtr__AddOrderImpl_b__0_Internal_Boolean_OrderingElement_0;
		}

		// Token: 0x0200051C RID: 1308
		[ObfuscatedName("Night.UI.HUD.Ordering.OrderController+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x060084E5 RID: 34021 RVA: 0x00253A78 File Offset: 0x00251C78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<OrderController.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderController.__c__DisplayClass36_0>.NativeClassPtr);
				OrderController.__c__DisplayClass36_0.NativeFieldInfoPtr_deskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController.__c__DisplayClass36_0>.NativeClassPtr, "deskCode");
				OrderController.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.__c__DisplayClass36_0>.NativeClassPtr, 100665041);
				OrderController.__c__DisplayClass36_0.NativeMethodInfoPtr__SetPartnerOrderDataImpl_b__0_Internal_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.__c__DisplayClass36_0>.NativeClassPtr, 100665042);
			}

			// Token: 0x060084E6 RID: 34022 RVA: 0x00253AE0 File Offset: 0x00251CE0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderController.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084E7 RID: 34023 RVA: 0x00253B1C File Offset: 0x00251D1C
			[CallerCount(0)]
			public unsafe bool _SetPartnerOrderDataImpl_b__0(GuestsManager.OrderBase order)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(order);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.__c__DisplayClass36_0.NativeMethodInfoPtr__SetPartnerOrderDataImpl_b__0_Internal_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060084E8 RID: 34024 RVA: 0x000477FF File Offset: 0x000459FF
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002CA1 RID: 11425
			// (get) Token: 0x060084E9 RID: 34025 RVA: 0x00253B6C File Offset: 0x00251D6C
			// (set) Token: 0x060084EA RID: 34026 RVA: 0x00047808 File Offset: 0x00045A08
			public unsafe int deskCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass36_0.NativeFieldInfoPtr_deskCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass36_0.NativeFieldInfoPtr_deskCode)) = value;
				}
			}

			// Token: 0x04005765 RID: 22373
			private static readonly IntPtr NativeFieldInfoPtr_deskCode;

			// Token: 0x04005766 RID: 22374
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005767 RID: 22375
			private static readonly IntPtr NativeMethodInfoPtr__SetPartnerOrderDataImpl_b__0_Internal_Boolean_OrderBase_0;
		}

		// Token: 0x0200051D RID: 1309
		[ObfuscatedName("Night.UI.HUD.Ordering.OrderController+<GetShowInUIOrdersImpl>d__38")]
		public sealed class _GetShowInUIOrdersImpl_d__38 : Il2CppSystem.Object
		{
			// Token: 0x060084EB RID: 34027 RVA: 0x00253B94 File Offset: 0x00251D94
			// Note: this type is marked as 'beforefieldinit'.
			static _GetShowInUIOrdersImpl_d__38()
			{
				Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "<GetShowInUIOrdersImpl>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr);
				OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr, "<>1__state");
				OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr, "<>2__current");
				OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr, "<>l__initialThreadId");
				OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr, "<>4__this");
				OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr__index_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr, "<index>5__2");
				OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr, 100665043);
				OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr, 100665044);
				OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr, 100665045);
				OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_NightScene_GuestManagementUtility_GuestsManager_OrderBase__get_Current_Private_Virtual_Final_New_get_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr, 100665046);
				OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr, 100665047);
				OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr, 100665048);
				OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_NightScene_GuestManagementUtility_GuestsManager_OrderBase__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr, 100665049);
				OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr, 100665050);
			}

			// Token: 0x060084EC RID: 34028 RVA: 0x00253CC4 File Offset: 0x00251EC4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 39842, RefRangeEnd = 39844, XrefRangeStart = 39840, XrefRangeEnd = 39842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetShowInUIOrdersImpl_d__38(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderController._GetShowInUIOrdersImpl_d__38>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084ED RID: 34029 RVA: 0x00253D0C File Offset: 0x00251F0C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060084EE RID: 34030 RVA: 0x00253D40 File Offset: 0x00251F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39844, XrefRangeEnd = 39850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002CA7 RID: 11431
			// (get) Token: 0x060084EF RID: 34031 RVA: 0x00253D7C File Offset: 0x00251F7C
			public unsafe GuestsManager.OrderBase Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_NightScene_GuestManagementUtility_GuestsManager_OrderBase__get_Current_Private_Virtual_Final_New_get_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr3) : null;
				}
			}

			// Token: 0x060084F0 RID: 34032 RVA: 0x00253DBC File Offset: 0x00251FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39850, XrefRangeEnd = 39856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002CA8 RID: 11432
			// (get) Token: 0x060084F1 RID: 34033 RVA: 0x00253DF0 File Offset: 0x00251FF0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060084F2 RID: 34034 RVA: 0x00253E30 File Offset: 0x00252030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39856, XrefRangeEnd = 39858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<GuestsManager.OrderBase> System_Collections_Generic_IEnumerable_NightScene_GuestManagementUtility_GuestsManager_OrderBase__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_NightScene_GuestManagementUtility_GuestsManager_OrderBase__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<GuestsManager.OrderBase>>(intPtr3) : null;
			}

			// Token: 0x060084F3 RID: 34035 RVA: 0x00253E70 File Offset: 0x00252070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController._GetShowInUIOrdersImpl_d__38.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060084F4 RID: 34036 RVA: 0x00047823 File Offset: 0x00045A23
			public _GetShowInUIOrdersImpl_d__38(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002CA2 RID: 11426
			// (get) Token: 0x060084F5 RID: 34037 RVA: 0x00253EB0 File Offset: 0x002520B0
			// (set) Token: 0x060084F6 RID: 34038 RVA: 0x0004782C File Offset: 0x00045A2C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002CA3 RID: 11427
			// (get) Token: 0x060084F7 RID: 34039 RVA: 0x00253ED8 File Offset: 0x002520D8
			// (set) Token: 0x060084F8 RID: 34040 RVA: 0x00047847 File Offset: 0x00045A47
			public unsafe GuestsManager.OrderBase __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CA4 RID: 11428
			// (get) Token: 0x060084F9 RID: 34041 RVA: 0x00253F08 File Offset: 0x00252108
			// (set) Token: 0x060084FA RID: 34042 RVA: 0x00047866 File Offset: 0x00045A66
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002CA5 RID: 11429
			// (get) Token: 0x060084FB RID: 34043 RVA: 0x00253F30 File Offset: 0x00252130
			// (set) Token: 0x060084FC RID: 34044 RVA: 0x00047881 File Offset: 0x00045A81
			public unsafe OrderController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrderController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CA6 RID: 11430
			// (get) Token: 0x060084FD RID: 34045 RVA: 0x00253F60 File Offset: 0x00252160
			// (set) Token: 0x060084FE RID: 34046 RVA: 0x000478A0 File Offset: 0x00045AA0
			public unsafe int _index_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr__index_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController._GetShowInUIOrdersImpl_d__38.NativeFieldInfoPtr__index_5__2)) = value;
				}
			}

			// Token: 0x04005768 RID: 22376
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005769 RID: 22377
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400576A RID: 22378
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400576B RID: 22379
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400576C RID: 22380
			private static readonly IntPtr NativeFieldInfoPtr__index_5__2;

			// Token: 0x0400576D RID: 22381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400576E RID: 22382
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400576F RID: 22383
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005770 RID: 22384
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_NightScene_GuestManagementUtility_GuestsManager_OrderBase__get_Current_Private_Virtual_Final_New_get_OrderBase_0;

			// Token: 0x04005771 RID: 22385
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005772 RID: 22386
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005773 RID: 22387
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_NightScene_GuestManagementUtility_GuestsManager_OrderBase__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_OrderBase_0;

			// Token: 0x04005774 RID: 22388
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200051E RID: 1310
		[ObfuscatedName("Night.UI.HUD.Ordering.OrderController+<>c__DisplayClass45_0")]
		public sealed class __c__DisplayClass45_0 : Il2CppSystem.Object
		{
			// Token: 0x060084FF RID: 34047 RVA: 0x00253F88 File Offset: 0x00252188
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_0()
			{
				Il2CppClassPointerStore<OrderController.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrderController>.NativeClassPtr, "<>c__DisplayClass45_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderController.__c__DisplayClass45_0>.NativeClassPtr);
				OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr_pushCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController.__c__DisplayClass45_0>.NativeClassPtr, "pushCallback");
				OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr_orderingElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController.__c__DisplayClass45_0>.NativeClassPtr, "orderingElement");
				OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr_ghostPushCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController.__c__DisplayClass45_0>.NativeClassPtr, "ghostPushCallback");
				OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr_ghostOrderingElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController.__c__DisplayClass45_0>.NativeClassPtr, "ghostOrderingElement");
				OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderController.__c__DisplayClass45_0>.NativeClassPtr, "<>4__this");
				OrderController.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.__c__DisplayClass45_0>.NativeClassPtr, 100665051);
				OrderController.__c__DisplayClass45_0.NativeMethodInfoPtr__CreateOrderingElement_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderController.__c__DisplayClass45_0>.NativeClassPtr, 100665052);
			}

			// Token: 0x06008500 RID: 34048 RVA: 0x00254040 File Offset: 0x00252240
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderController.__c__DisplayClass45_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008501 RID: 34049 RVA: 0x0025407C File Offset: 0x0025227C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39858, XrefRangeEnd = 39863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOrderingElement_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderController.__c__DisplayClass45_0.NativeMethodInfoPtr__CreateOrderingElement_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008502 RID: 34050 RVA: 0x000478BB File Offset: 0x00045ABB
			public __c__DisplayClass45_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002CA9 RID: 11433
			// (get) Token: 0x06008503 RID: 34051 RVA: 0x002540B0 File Offset: 0x002522B0
			// (set) Token: 0x06008504 RID: 34052 RVA: 0x000478C4 File Offset: 0x00045AC4
			public unsafe Action<OrderingElement> pushCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr_pushCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<OrderingElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr_pushCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CAA RID: 11434
			// (get) Token: 0x06008505 RID: 34053 RVA: 0x002540E0 File Offset: 0x002522E0
			// (set) Token: 0x06008506 RID: 34054 RVA: 0x000478E3 File Offset: 0x00045AE3
			public unsafe OrderingElement orderingElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr_orderingElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrderingElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr_orderingElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CAB RID: 11435
			// (get) Token: 0x06008507 RID: 34055 RVA: 0x00254110 File Offset: 0x00252310
			// (set) Token: 0x06008508 RID: 34056 RVA: 0x00047902 File Offset: 0x00045B02
			public unsafe Action<Transform> ghostPushCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr_ghostPushCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Transform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr_ghostPushCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CAC RID: 11436
			// (get) Token: 0x06008509 RID: 34057 RVA: 0x00254140 File Offset: 0x00252340
			// (set) Token: 0x0600850A RID: 34058 RVA: 0x00047921 File Offset: 0x00045B21
			public unsafe Transform ghostOrderingElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr_ghostOrderingElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr_ghostOrderingElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CAD RID: 11437
			// (get) Token: 0x0600850B RID: 34059 RVA: 0x00254170 File Offset: 0x00252370
			// (set) Token: 0x0600850C RID: 34060 RVA: 0x00047940 File Offset: 0x00045B40
			public unsafe OrderController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrderController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderController.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005775 RID: 22389
			private static readonly IntPtr NativeFieldInfoPtr_pushCallback;

			// Token: 0x04005776 RID: 22390
			private static readonly IntPtr NativeFieldInfoPtr_orderingElement;

			// Token: 0x04005777 RID: 22391
			private static readonly IntPtr NativeFieldInfoPtr_ghostPushCallback;

			// Token: 0x04005778 RID: 22392
			private static readonly IntPtr NativeFieldInfoPtr_ghostOrderingElement;

			// Token: 0x04005779 RID: 22393
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400577A RID: 22394
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400577B RID: 22395
			private static readonly IntPtr NativeMethodInfoPtr__CreateOrderingElement_b__0_Internal_Void_0;
		}

		// Token: 0x0200051F RID: 1311
		private sealed class MethodInfoStoreGeneric_Match_Private_Static_Boolean_IList_1_TListElement_Func_2_TListElement_TPredicateElement_Predicate_1_TPredicateElement_byref_TListElement_byref_Int32_0<TListElement, TPredicateElement>
		{
			// Token: 0x0400577C RID: 22396
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OrderController.NativeMethodInfoPtr_Match_Private_Static_Boolean_IList_1_TListElement_Func_2_TListElement_TPredicateElement_Predicate_1_TPredicateElement_byref_TListElement_byref_Int32_0, Il2CppClassPointerStore<OrderController>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TListElement>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPredicateElement>.NativeClassPtr))
			}))));
		}
	}
}
