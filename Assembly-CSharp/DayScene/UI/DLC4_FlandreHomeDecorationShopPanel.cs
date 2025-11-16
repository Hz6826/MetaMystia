using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020000D3 RID: 211
	public class DLC4_FlandreHomeDecorationShopPanel : UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>
	{
		// Token: 0x060019B3 RID: 6579 RVA: 0x000F3AA4 File Offset: 0x000F1CA4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_FlandreHomeDecorationShopPanel()
		{
			Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DLC4_FlandreHomeDecorationShopPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr);
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_CONTENT_WIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "CONTENT_WIDTH");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_CONTENT_SPACING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "CONTENT_SPACING");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_CartObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "m_CartObject");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_CartRowObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "m_CartRowObject");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_CartTransformField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "m_CartTransformField");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_LeftPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "m_LeftPrice");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_TotalPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "m_TotalPrice");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "m_ConfirmButton");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_FurnitureArrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "m_FurnitureArrays");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_scrollerLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "scrollerLeft");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_scrollerRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "scrollerRight");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_allInCartColumnInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "allInCartColumnInstances");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_allInCartInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "allInCartInstances");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_furnituresInCart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "furnituresInCart");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_furnituresInCartOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "furnituresInCartOrder");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_furnituresInCartRowIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "furnituresInCartRowIndex");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_CartGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "m_CartGroup");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_ShelfGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "m_ShelfGroup");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_currentPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "currentPrice");
			DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_AllGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "m_AllGroups");
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667850);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_CloseAndBack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667851);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667852);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667853);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_UpdateVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667854);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_ProcessPerCartVisualColum_Private_Void_RectTransform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667855);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_ProcessPerRowObject_Private_Void_UIButtonSimple_FlandreHomeFurniture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667856);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_CalculateRowIndex_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667857);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_AddToCart_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667858);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_RemoveFromCart_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667859);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_SetPrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667860);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_Buy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667861);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667862);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667863);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr__OnPanelInitialize_b__20_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667864);
			DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr__OnPanelInitialize_b__20_1_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, 100667865);
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x000F3DA4 File Offset: 0x000F1FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69185, XrefRangeEnd = 69269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x000F3DE0 File Offset: 0x000F1FE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69274, RefRangeEnd = 69277, XrefRangeStart = 69269, XrefRangeEnd = 69274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseAndBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_CloseAndBack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x000F3E14 File Offset: 0x000F2014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69277, XrefRangeEnd = 69280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x000F3E50 File Offset: 0x000F2050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69280, XrefRangeEnd = 69286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x000F3E8C File Offset: 0x000F208C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69307, RefRangeEnd = 69310, XrefRangeStart = 69286, XrefRangeEnd = 69307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_UpdateVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x000F3EC0 File Offset: 0x000F20C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69310, XrefRangeEnd = 69340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPerCartVisualColum(RectTransform field, int rowIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rowIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_ProcessPerCartVisualColum_Private_Void_RectTransform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x000F3F10 File Offset: 0x000F2110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69340, XrefRangeEnd = 69395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPerRowObject(UIButtonSimple button, FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_ProcessPerRowObject_Private_Void_UIButtonSimple_FlandreHomeFurniture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x000F3F6C File Offset: 0x000F216C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69431, RefRangeEnd = 69432, XrefRangeStart = 69395, XrefRangeEnd = 69431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateRowIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_CalculateRowIndex_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x000F3FA0 File Offset: 0x000F21A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69453, RefRangeEnd = 69454, XrefRangeStart = 69432, XrefRangeEnd = 69453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToCart(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_AddToCart_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x000F3FE0 File Offset: 0x000F21E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69479, RefRangeEnd = 69480, XrefRangeStart = 69454, XrefRangeEnd = 69479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromCart(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_RemoveFromCart_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x000F4020 File Offset: 0x000F2220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69541, RefRangeEnd = 69542, XrefRangeStart = 69480, XrefRangeEnd = 69541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_SetPrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x000F4054 File Offset: 0x000F2254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69542, XrefRangeEnd = 69570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Buy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_Buy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x000F4088 File Offset: 0x000F2288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69570, XrefRangeEnd = 69596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x000F40C4 File Offset: 0x000F22C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69596, XrefRangeEnd = 69647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_FlandreHomeDecorationShopPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x000F4100 File Offset: 0x000F2300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69647, XrefRangeEnd = 69648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__20_0(InputAction.CallbackContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr__OnPanelInitialize_b__20_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x000F4148 File Offset: 0x000F2348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__20_1(InputAction.CallbackContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.NativeMethodInfoPtr__OnPanelInitialize_b__20_1_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00010009 File Offset: 0x0000E209
		public DLC4_FlandreHomeDecorationShopPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x000F4190 File Offset: 0x000F2390
		// (set) Token: 0x060019C6 RID: 6598 RVA: 0x00010012 File Offset: 0x0000E212
		public unsafe static float CONTENT_WIDTH
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_CONTENT_WIDTH, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_CONTENT_WIDTH, (void*)(&value));
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x000F41AC File Offset: 0x000F23AC
		// (set) Token: 0x060019C8 RID: 6600 RVA: 0x00010020 File Offset: 0x0000E220
		public unsafe static float CONTENT_SPACING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_CONTENT_SPACING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_CONTENT_SPACING, (void*)(&value));
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x000F41C8 File Offset: 0x000F23C8
		// (set) Token: 0x060019CA RID: 6602 RVA: 0x0001002E File Offset: 0x0000E22E
		public unsafe GameObject m_CartObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_CartObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_CartObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x000F41F8 File Offset: 0x000F23F8
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x0001004D File Offset: 0x0000E24D
		public unsafe GameObject m_CartRowObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_CartRowObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_CartRowObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x000F4228 File Offset: 0x000F2428
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x0001006C File Offset: 0x0000E26C
		public unsafe RectTransform m_CartTransformField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_CartTransformField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_CartTransformField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x000F4258 File Offset: 0x000F2458
		// (set) Token: 0x060019D0 RID: 6608 RVA: 0x0001008B File Offset: 0x0000E28B
		public unsafe TextMeshProUGUI m_LeftPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_LeftPrice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_LeftPrice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x000F4288 File Offset: 0x000F2488
		// (set) Token: 0x060019D2 RID: 6610 RVA: 0x000100AA File Offset: 0x0000E2AA
		public unsafe TextMeshProUGUI m_TotalPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_TotalPrice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_TotalPrice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x000F42B8 File Offset: 0x000F24B8
		// (set) Token: 0x060019D4 RID: 6612 RVA: 0x000100C9 File Offset: 0x0000E2C9
		public unsafe UIButtonHold m_ConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_ConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x000F42E8 File Offset: 0x000F24E8
		// (set) Token: 0x060019D6 RID: 6614 RVA: 0x000100E8 File Offset: 0x0000E2E8
		public unsafe Il2CppReferenceArray<FlandreFurnitureUIComponent> m_FurnitureArrays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_FurnitureArrays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FlandreFurnitureUIComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_FurnitureArrays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x000F4318 File Offset: 0x000F2518
		// (set) Token: 0x060019D8 RID: 6616 RVA: 0x00010107 File Offset: 0x0000E307
		public unsafe AdpScrollListAdaptiveComponent scrollerLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_scrollerLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpScrollListAdaptiveComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_scrollerLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x000F4348 File Offset: 0x000F2548
		// (set) Token: 0x060019DA RID: 6618 RVA: 0x00010126 File Offset: 0x0000E326
		public unsafe AdpScrollListAdaptiveComponent scrollerRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_scrollerRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpScrollListAdaptiveComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_scrollerRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x000F4378 File Offset: 0x000F2578
		// (set) Token: 0x060019DC RID: 6620 RVA: 0x00010145 File Offset: 0x0000E345
		public unsafe List<GameObject> allInCartColumnInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_allInCartColumnInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_allInCartColumnInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x000F43A8 File Offset: 0x000F25A8
		// (set) Token: 0x060019DE RID: 6622 RVA: 0x00010164 File Offset: 0x0000E364
		public unsafe Dictionary<int, List<GameObject>> allInCartInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_allInCartInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_allInCartInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x000F43D8 File Offset: 0x000F25D8
		// (set) Token: 0x060019E0 RID: 6624 RVA: 0x00010183 File Offset: 0x0000E383
		public unsafe Dictionary<int, int> furnituresInCart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_furnituresInCart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_furnituresInCart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x000F4408 File Offset: 0x000F2608
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x000101A2 File Offset: 0x0000E3A2
		public unsafe List<int> furnituresInCartOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_furnituresInCartOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_furnituresInCartOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x000F4438 File Offset: 0x000F2638
		// (set) Token: 0x060019E4 RID: 6628 RVA: 0x000101C1 File Offset: 0x0000E3C1
		public unsafe Dictionary<int, List<FlandreHomeFurnitureProfile.FlandreHomeFurniture>> furnituresInCartRowIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_furnituresInCartRowIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<FlandreHomeFurnitureProfile.FlandreHomeFurniture>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_furnituresInCartRowIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x000F4468 File Offset: 0x000F2668
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x000101E0 File Offset: 0x0000E3E0
		public unsafe UILogicalGroupT<int> m_CartGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_CartGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_CartGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x000F4498 File Offset: 0x000F2698
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x000101FF File Offset: 0x0000E3FF
		public unsafe UILogicalGroupT<int> m_ShelfGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_ShelfGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_ShelfGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x000F44C8 File Offset: 0x000F26C8
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x0001021E File Offset: 0x0000E41E
		public unsafe int currentPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_currentPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_currentPrice)) = value;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x000F44F0 File Offset: 0x000F26F0
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x00010239 File Offset: 0x0000E439
		public unsafe GroupedUILogicalGroup m_AllGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_AllGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GroupedUILogicalGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.NativeFieldInfoPtr_m_AllGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeFieldInfoPtr_CONTENT_WIDTH;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeFieldInfoPtr_CONTENT_SPACING;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeFieldInfoPtr_m_CartObject;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeFieldInfoPtr_m_CartRowObject;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeFieldInfoPtr_m_CartTransformField;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeFieldInfoPtr_m_LeftPrice;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeFieldInfoPtr_m_TotalPrice;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeFieldInfoPtr_m_ConfirmButton;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeFieldInfoPtr_m_FurnitureArrays;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeFieldInfoPtr_scrollerLeft;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeFieldInfoPtr_scrollerRight;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeFieldInfoPtr_allInCartColumnInstances;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeFieldInfoPtr_allInCartInstances;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeFieldInfoPtr_furnituresInCart;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeFieldInfoPtr_furnituresInCartOrder;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeFieldInfoPtr_furnituresInCartRowIndex;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeFieldInfoPtr_m_CartGroup;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeFieldInfoPtr_m_ShelfGroup;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeFieldInfoPtr_currentPrice;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeFieldInfoPtr_m_AllGroups;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr_CloseAndBack_Private_Void_0;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPerCartVisualColum_Private_Void_RectTransform_Int32_0;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPerRowObject_Private_Void_UIButtonSimple_FlandreHomeFurniture_0;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr_CalculateRowIndex_Private_Void_0;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr_AddToCart_Private_Void_Int32_0;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromCart_Private_Void_Int32_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_SetPrice_Private_Void_0;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr_Buy_Private_Void_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__20_0_Private_Void_CallbackContext_0;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__20_1_Private_Void_CallbackContext_0;

		// Token: 0x02000688 RID: 1672
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationShopPanel+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x06009649 RID: 38473 RVA: 0x00285910 File Offset: 0x00283B10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0>.NativeClassPtr);
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeFieldInfoPtr_thisId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0>.NativeClassPtr, "thisId");
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0>.NativeClassPtr, "button");
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0>.NativeClassPtr, 100667866);
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0>.NativeClassPtr, 100667867);
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0>.NativeClassPtr, 100667868);
			}

			// Token: 0x0600964A RID: 38474 RVA: 0x002859B4 File Offset: 0x00283BB4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600964B RID: 38475 RVA: 0x002859F0 File Offset: 0x00283BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69167, XrefRangeEnd = 69169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600964C RID: 38476 RVA: 0x00285A24 File Offset: 0x00283C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69169, XrefRangeEnd = 69172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600964D RID: 38477 RVA: 0x00051435 File Offset: 0x0004F635
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031EC RID: 12780
			// (get) Token: 0x0600964E RID: 38478 RVA: 0x00285A58 File Offset: 0x00283C58
			// (set) Token: 0x0600964F RID: 38479 RVA: 0x0005143E File Offset: 0x0004F63E
			public unsafe int thisId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeFieldInfoPtr_thisId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeFieldInfoPtr_thisId)) = value;
				}
			}

			// Token: 0x170031ED RID: 12781
			// (get) Token: 0x06009650 RID: 38480 RVA: 0x00285A80 File Offset: 0x00283C80
			// (set) Token: 0x06009651 RID: 38481 RVA: 0x00051459 File Offset: 0x0004F659
			public unsafe UIButtonSimple button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeFieldInfoPtr_button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031EE RID: 12782
			// (get) Token: 0x06009652 RID: 38482 RVA: 0x00285AB0 File Offset: 0x00283CB0
			// (set) Token: 0x06009653 RID: 38483 RVA: 0x00051478 File Offset: 0x0004F678
			public unsafe DLC4_FlandreHomeDecorationShopPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationShopPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006176 RID: 24950
			private static readonly IntPtr NativeFieldInfoPtr_thisId;

			// Token: 0x04006177 RID: 24951
			private static readonly IntPtr NativeFieldInfoPtr_button;

			// Token: 0x04006178 RID: 24952
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006179 RID: 24953
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400617A RID: 24954
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_0;

			// Token: 0x0400617B RID: 24955
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_0;
		}

		// Token: 0x02000689 RID: 1673
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationShopPanel+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x06009654 RID: 38484 RVA: 0x00285AE0 File Offset: 0x00283CE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0>.NativeClassPtr);
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeFieldInfoPtr_thisFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0>.NativeClassPtr, "thisFurniture");
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0>.NativeClassPtr, "button");
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0>.NativeClassPtr, 100667869);
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeMethodInfoPtr__ProcessPerRowObject_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0>.NativeClassPtr, 100667870);
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeMethodInfoPtr__ProcessPerRowObject_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0>.NativeClassPtr, 100667871);
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeMethodInfoPtr__ProcessPerRowObject_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0>.NativeClassPtr, 100667872);
				DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeMethodInfoPtr__ProcessPerRowObject_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0>.NativeClassPtr, 100667873);
			}

			// Token: 0x06009655 RID: 38485 RVA: 0x00285BAC File Offset: 0x00283DAC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009656 RID: 38486 RVA: 0x00285BE8 File Offset: 0x00283DE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69172, XrefRangeEnd = 69174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessPerRowObject_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeMethodInfoPtr__ProcessPerRowObject_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009657 RID: 38487 RVA: 0x00285C2C File Offset: 0x00283E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessPerRowObject_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeMethodInfoPtr__ProcessPerRowObject_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009658 RID: 38488 RVA: 0x00285C70 File Offset: 0x00283E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69174, XrefRangeEnd = 69176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessPerRowObject_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeMethodInfoPtr__ProcessPerRowObject_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009659 RID: 38489 RVA: 0x00285CA4 File Offset: 0x00283EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69176, XrefRangeEnd = 69179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessPerRowObject_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeMethodInfoPtr__ProcessPerRowObject_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600965A RID: 38490 RVA: 0x00051497 File Offset: 0x0004F697
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031EF RID: 12783
			// (get) Token: 0x0600965B RID: 38491 RVA: 0x00285CD8 File Offset: 0x00283ED8
			// (set) Token: 0x0600965C RID: 38492 RVA: 0x000514A0 File Offset: 0x0004F6A0
			public FlandreHomeFurnitureProfile.FlandreHomeFurniture thisFurniture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeFieldInfoPtr_thisFurniture);
					return new FlandreHomeFurnitureProfile.FlandreHomeFurniture(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeFieldInfoPtr_thisFurniture), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170031F0 RID: 12784
			// (get) Token: 0x0600965D RID: 38493 RVA: 0x00285D08 File Offset: 0x00283F08
			// (set) Token: 0x0600965E RID: 38494 RVA: 0x000514CE File Offset: 0x0004F6CE
			public unsafe DLC4_FlandreHomeDecorationShopPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationShopPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031F1 RID: 12785
			// (get) Token: 0x0600965F RID: 38495 RVA: 0x00285D38 File Offset: 0x00283F38
			// (set) Token: 0x06009660 RID: 38496 RVA: 0x000514ED File Offset: 0x0004F6ED
			public unsafe UIButtonSimple button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeFieldInfoPtr_button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationShopPanel.__c__DisplayClass26_0.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400617C RID: 24956
			private static readonly IntPtr NativeFieldInfoPtr_thisFurniture;

			// Token: 0x0400617D RID: 24957
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400617E RID: 24958
			private static readonly IntPtr NativeFieldInfoPtr_button;

			// Token: 0x0400617F RID: 24959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006180 RID: 24960
			private static readonly IntPtr NativeMethodInfoPtr__ProcessPerRowObject_b__0_Internal_Void_Image_0;

			// Token: 0x04006181 RID: 24961
			private static readonly IntPtr NativeMethodInfoPtr__ProcessPerRowObject_b__1_Internal_Void_Image_0;

			// Token: 0x04006182 RID: 24962
			private static readonly IntPtr NativeMethodInfoPtr__ProcessPerRowObject_b__2_Internal_Void_0;

			// Token: 0x04006183 RID: 24963
			private static readonly IntPtr NativeMethodInfoPtr__ProcessPerRowObject_b__3_Internal_Void_0;
		}

		// Token: 0x0200068A RID: 1674
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationShopPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009661 RID: 38497 RVA: 0x00285D68 File Offset: 0x00283F68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c>.NativeClassPtr);
				DLC4_FlandreHomeDecorationShopPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c>.NativeClassPtr, "<>9");
				DLC4_FlandreHomeDecorationShopPanel.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c>.NativeClassPtr, "<>9__30_0");
				DLC4_FlandreHomeDecorationShopPanel.__c.NativeFieldInfoPtr___9__30_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c>.NativeClassPtr, "<>9__30_1");
				DLC4_FlandreHomeDecorationShopPanel.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c>.NativeClassPtr, "<>9__31_0");
				DLC4_FlandreHomeDecorationShopPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c>.NativeClassPtr, 100667875);
				DLC4_FlandreHomeDecorationShopPanel.__c.NativeMethodInfoPtr__SetPrice_b__30_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c>.NativeClassPtr, 100667876);
				DLC4_FlandreHomeDecorationShopPanel.__c.NativeMethodInfoPtr__SetPrice_b__30_1_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c>.NativeClassPtr, 100667877);
				DLC4_FlandreHomeDecorationShopPanel.__c.NativeMethodInfoPtr__Buy_b__31_0_Internal_Void_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c>.NativeClassPtr, 100667878);
			}

			// Token: 0x06009662 RID: 38498 RVA: 0x00285E34 File Offset: 0x00284034
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationShopPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009663 RID: 38499 RVA: 0x00285E70 File Offset: 0x00284070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69179, XrefRangeEnd = 69182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SetPrice_b__30_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.__c.NativeMethodInfoPtr__SetPrice_b__30_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009664 RID: 38500 RVA: 0x00285EC4 File Offset: 0x002840C4
			[CallerCount(0)]
			public unsafe int _SetPrice_b__30_1(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.__c.NativeMethodInfoPtr__SetPrice_b__30_1_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009665 RID: 38501 RVA: 0x00285F1C File Offset: 0x0028411C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69182, XrefRangeEnd = 69185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Buy_b__31_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationShopPanel.__c.NativeMethodInfoPtr__Buy_b__31_0_Internal_Void_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009666 RID: 38502 RVA: 0x0005150C File Offset: 0x0004F70C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031F2 RID: 12786
			// (get) Token: 0x06009667 RID: 38503 RVA: 0x00285F64 File Offset: 0x00284164
			// (set) Token: 0x06009668 RID: 38504 RVA: 0x00051515 File Offset: 0x0004F715
			public unsafe static DLC4_FlandreHomeDecorationShopPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationShopPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationShopPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationShopPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031F3 RID: 12787
			// (get) Token: 0x06009669 RID: 38505 RVA: 0x00285F8C File Offset: 0x0028418C
			// (set) Token: 0x0600966A RID: 38506 RVA: 0x00051527 File Offset: 0x0004F727
			public unsafe static Func<KeyValuePair<int, int>, int> __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationShopPanel.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationShopPanel.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031F4 RID: 12788
			// (get) Token: 0x0600966B RID: 38507 RVA: 0x00285FB4 File Offset: 0x002841B4
			// (set) Token: 0x0600966C RID: 38508 RVA: 0x00051539 File Offset: 0x0004F739
			public unsafe static Func<int, int, int> __9__30_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationShopPanel.__c.NativeFieldInfoPtr___9__30_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationShopPanel.__c.NativeFieldInfoPtr___9__30_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031F5 RID: 12789
			// (get) Token: 0x0600966D RID: 38509 RVA: 0x00285FDC File Offset: 0x002841DC
			// (set) Token: 0x0600966E RID: 38510 RVA: 0x0005154B File Offset: 0x0004F74B
			public unsafe static Action<KeyValuePair<int, int>> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationShopPanel.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationShopPanel.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006184 RID: 24964
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006185 RID: 24965
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x04006186 RID: 24966
			private static readonly IntPtr NativeFieldInfoPtr___9__30_1;

			// Token: 0x04006187 RID: 24967
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x04006188 RID: 24968
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006189 RID: 24969
			private static readonly IntPtr NativeMethodInfoPtr__SetPrice_b__30_0_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x0400618A RID: 24970
			private static readonly IntPtr NativeMethodInfoPtr__SetPrice_b__30_1_Internal_Int32_Int32_Int32_0;

			// Token: 0x0400618B RID: 24971
			private static readonly IntPtr NativeMethodInfoPtr__Buy_b__31_0_Internal_Void_KeyValuePair_2_Int32_Int32_0;
		}
	}
}
