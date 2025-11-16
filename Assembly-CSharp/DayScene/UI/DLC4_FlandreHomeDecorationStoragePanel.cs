using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020000D4 RID: 212
	public class DLC4_FlandreHomeDecorationStoragePanel : UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>
	{
		// Token: 0x060019ED RID: 6637 RVA: 0x000F4520 File Offset: 0x000F2720
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_FlandreHomeDecorationStoragePanel()
		{
			Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DLC4_FlandreHomeDecorationStoragePanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr);
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_furnitureElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "furnitureElement");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_furnitureContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "furnitureContent");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_m_GotoPrevious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "m_GotoPrevious");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_m_GotoNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "m_GotoNext");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_allInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "allInstances");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_furnitureDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "furnitureDic");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_contentWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "contentWidth");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_currentFurnitureList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "currentFurnitureList");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_currentPageFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "currentPageFurniture");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_currentPageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "currentPageIndex");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_currentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "currentType");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_m_LogicalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "m_LogicalGroup");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_maxPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "maxPage");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_nextArrowButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "nextArrowButton");
			DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_previousArrowButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "previousArrowButton");
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667879);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667880);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667881);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667882);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_RefreshPanel_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667883);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_RefreshPage_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667884);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_ProcessFurnitureElement_Private_Void_UIButtonSimple_FlandreHomeFurniture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667885);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_OnSecondaryInput_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667886);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_GoToNext_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667887);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_BackToPrevious_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667888);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667889);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667890);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667891);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667892);
			DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_Method_Private_Boolean_FlandreHomeFurniture_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, 100667893);
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x000F47A8 File Offset: 0x000F29A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69664, XrefRangeEnd = 69706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x000F47E4 File Offset: 0x000F29E4
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x000F482C File Offset: 0x000F2A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69706, XrefRangeEnd = 69714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x000F4868 File Offset: 0x000F2A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69714, XrefRangeEnd = 69722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x000F48A4 File Offset: 0x000F2AA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69770, RefRangeEnd = 69771, XrefRangeStart = 69722, XrefRangeEnd = 69770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPanel(bool shouldRefreshPageNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shouldRefreshPageNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_RefreshPanel_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x000F48E4 File Offset: 0x000F2AE4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 69843, RefRangeEnd = 69857, XrefRangeStart = 69771, XrefRangeEnd = 69843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPage(bool goToFirstElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref goToFirstElement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_RefreshPage_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x000F4924 File Offset: 0x000F2B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69857, XrefRangeEnd = 69932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessFurnitureElement(UIButtonSimple button, FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_ProcessFurnitureElement_Private_Void_UIButtonSimple_FlandreHomeFurniture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x000F4980 File Offset: 0x000F2B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69932, XrefRangeEnd = 69939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSecondaryInput(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_OnSecondaryInput_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x000F49C8 File Offset: 0x000F2BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69939, XrefRangeEnd = 69941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToNext(bool goToFirst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref goToFirst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_GoToNext_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x000F4A08 File Offset: 0x000F2C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69941, XrefRangeEnd = 69943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackToPrevious(bool goToFirst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref goToFirst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_BackToPrevious_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x000F4A48 File Offset: 0x000F2C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69943, XrefRangeEnd = 69959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x000F4A84 File Offset: 0x000F2C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69959, XrefRangeEnd = 69998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_FlandreHomeDecorationStoragePanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x000F4AC0 File Offset: 0x000F2CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69998, XrefRangeEnd = 70000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__15_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x000F4AF4 File Offset: 0x000F2CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70000, XrefRangeEnd = 70002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__15_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr__OnPanelInitialize_b__15_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x000F4B28 File Offset: 0x000F2D28
		[CallerCount(0)]
		public unsafe bool Method_Private_Boolean_FlandreHomeFurniture_PDM_0(FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.NativeMethodInfoPtr_Method_Private_Boolean_FlandreHomeFurniture_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x00010258 File Offset: 0x0000E458
		public DLC4_FlandreHomeDecorationStoragePanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x000F4B7C File Offset: 0x000F2D7C
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x00010261 File Offset: 0x0000E461
		public unsafe GameObject furnitureElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_furnitureElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_furnitureElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x000F4BAC File Offset: 0x000F2DAC
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x00010280 File Offset: 0x0000E480
		public unsafe HorizontalLayoutGroup furnitureContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_furnitureContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HorizontalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_furnitureContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x000F4BDC File Offset: 0x000F2DDC
		// (set) Token: 0x06001A03 RID: 6659 RVA: 0x0001029F File Offset: 0x0000E49F
		public unsafe UIButtonSimple m_GotoPrevious
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_m_GotoPrevious);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_m_GotoPrevious), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x000F4C0C File Offset: 0x000F2E0C
		// (set) Token: 0x06001A05 RID: 6661 RVA: 0x000102BE File Offset: 0x0000E4BE
		public unsafe UIButtonSimple m_GotoNext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_m_GotoNext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_m_GotoNext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x000F4C3C File Offset: 0x000F2E3C
		// (set) Token: 0x06001A07 RID: 6663 RVA: 0x000102DD File Offset: 0x0000E4DD
		public unsafe List<GameObject> allInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_allInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_allInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x000F4C6C File Offset: 0x000F2E6C
		// (set) Token: 0x06001A09 RID: 6665 RVA: 0x000102FC File Offset: 0x0000E4FC
		public unsafe Dictionary<int, List<FlandreHomeFurnitureProfile.FlandreHomeFurniture>> furnitureDic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_furnitureDic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<FlandreHomeFurnitureProfile.FlandreHomeFurniture>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_furnitureDic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x000F4C9C File Offset: 0x000F2E9C
		// (set) Token: 0x06001A0B RID: 6667 RVA: 0x0001031B File Offset: 0x0000E51B
		public unsafe int contentWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_contentWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_contentWidth)) = value;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x000F4CC4 File Offset: 0x000F2EC4
		// (set) Token: 0x06001A0D RID: 6669 RVA: 0x00010336 File Offset: 0x0000E536
		public unsafe List<int> currentFurnitureList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_currentFurnitureList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_currentFurnitureList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x000F4CF4 File Offset: 0x000F2EF4
		// (set) Token: 0x06001A0F RID: 6671 RVA: 0x00010355 File Offset: 0x0000E555
		public unsafe List<FlandreHomeFurnitureProfile.FlandreHomeFurniture> currentPageFurniture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_currentPageFurniture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FlandreHomeFurnitureProfile.FlandreHomeFurniture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_currentPageFurniture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x000F4D24 File Offset: 0x000F2F24
		// (set) Token: 0x06001A11 RID: 6673 RVA: 0x00010374 File Offset: 0x0000E574
		public unsafe int currentPageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_currentPageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_currentPageIndex)) = value;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x000F4D4C File Offset: 0x000F2F4C
		// (set) Token: 0x06001A13 RID: 6675 RVA: 0x0001038F File Offset: 0x0000E58F
		public unsafe DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType currentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_currentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_currentType)) = value;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x000F4D74 File Offset: 0x000F2F74
		// (set) Token: 0x06001A15 RID: 6677 RVA: 0x000103AA File Offset: 0x0000E5AA
		public unsafe UILogicalGroupT<int> m_LogicalGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_m_LogicalGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_m_LogicalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x000F4DA4 File Offset: 0x000F2FA4
		// (set) Token: 0x06001A17 RID: 6679 RVA: 0x000103C9 File Offset: 0x0000E5C9
		public unsafe int maxPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_maxPage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_maxPage)) = value;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x000F4DCC File Offset: 0x000F2FCC
		// (set) Token: 0x06001A19 RID: 6681 RVA: 0x000103E4 File Offset: 0x0000E5E4
		public unsafe CanvasGroup nextArrowButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_nextArrowButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_nextArrowButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x000F4DFC File Offset: 0x000F2FFC
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x00010403 File Offset: 0x0000E603
		public unsafe CanvasGroup previousArrowButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_previousArrowButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.NativeFieldInfoPtr_previousArrowButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeFieldInfoPtr_furnitureElement;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeFieldInfoPtr_furnitureContent;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoPrevious;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoNext;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeFieldInfoPtr_allInstances;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeFieldInfoPtr_furnitureDic;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeFieldInfoPtr_contentWidth;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeFieldInfoPtr_currentFurnitureList;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeFieldInfoPtr_currentPageFurniture;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeFieldInfoPtr_currentPageIndex;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeFieldInfoPtr_currentType;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeFieldInfoPtr_m_LogicalGroup;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeFieldInfoPtr_maxPage;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeFieldInfoPtr_nextArrowButton;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeFieldInfoPtr_previousArrowButton;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPanel_Private_Void_Boolean_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPage_Private_Void_Boolean_0;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr_ProcessFurnitureElement_Private_Void_UIButtonSimple_FlandreHomeFurniture_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_OnSecondaryInput_Private_Void_CallbackContext_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_GoToNext_Private_Void_Boolean_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_BackToPrevious_Private_Void_Boolean_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_0_Private_Void_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_1_Private_Void_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Boolean_FlandreHomeFurniture_PDM_0;

		// Token: 0x0200068B RID: 1675
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationStoragePanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600966F RID: 38511 RVA: 0x00286004 File Offset: 0x00284204
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c>.NativeClassPtr);
				DLC4_FlandreHomeDecorationStoragePanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c>.NativeClassPtr, "<>9");
				DLC4_FlandreHomeDecorationStoragePanel.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c>.NativeClassPtr, "<>9__20_0");
				DLC4_FlandreHomeDecorationStoragePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c>.NativeClassPtr, 100667895);
				DLC4_FlandreHomeDecorationStoragePanel.__c.NativeMethodInfoPtr__RefreshPage_b__20_0_Internal_Int32_FlandreHomeFurniture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c>.NativeClassPtr, 100667896);
			}

			// Token: 0x06009670 RID: 38512 RVA: 0x00286080 File Offset: 0x00284280
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009671 RID: 38513 RVA: 0x002860BC File Offset: 0x002842BC
			[CallerCount(0)]
			public unsafe int _RefreshPage_b__20_0(FlandreHomeFurnitureProfile.FlandreHomeFurniture x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.__c.NativeMethodInfoPtr__RefreshPage_b__20_0_Internal_Int32_FlandreHomeFurniture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009672 RID: 38514 RVA: 0x0005155D File Offset: 0x0004F75D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031F6 RID: 12790
			// (get) Token: 0x06009673 RID: 38515 RVA: 0x00286110 File Offset: 0x00284310
			// (set) Token: 0x06009674 RID: 38516 RVA: 0x00051566 File Offset: 0x0004F766
			public unsafe static DLC4_FlandreHomeDecorationStoragePanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationStoragePanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationStoragePanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationStoragePanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031F7 RID: 12791
			// (get) Token: 0x06009675 RID: 38517 RVA: 0x00286138 File Offset: 0x00284338
			// (set) Token: 0x06009676 RID: 38518 RVA: 0x00051578 File Offset: 0x0004F778
			public unsafe static Func<FlandreHomeFurnitureProfile.FlandreHomeFurniture, int> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationStoragePanel.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FlandreHomeFurnitureProfile.FlandreHomeFurniture, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationStoragePanel.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400618C RID: 24972
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400618D RID: 24973
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x0400618E RID: 24974
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400618F RID: 24975
			private static readonly IntPtr NativeMethodInfoPtr__RefreshPage_b__20_0_Internal_Int32_FlandreHomeFurniture_0;
		}

		// Token: 0x0200068C RID: 1676
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationStoragePanel+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x06009677 RID: 38519 RVA: 0x00286160 File Offset: 0x00284360
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0>.NativeClassPtr);
				DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeFieldInfoPtr_thisFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0>.NativeClassPtr, "thisFurniture");
				DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0>.NativeClassPtr, 100667897);
				DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ProcessFurnitureElement_b__0_Internal_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0>.NativeClassPtr, 100667898);
				DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ProcessFurnitureElement_b__1_Internal_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0>.NativeClassPtr, 100667899);
				DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ProcessFurnitureElement_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0>.NativeClassPtr, 100667900);
				DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ProcessFurnitureElement_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0>.NativeClassPtr, 100667901);
				DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ProcessFurnitureElement_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0>.NativeClassPtr, 100667902);
			}

			// Token: 0x06009678 RID: 38520 RVA: 0x0028622C File Offset: 0x0028442C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009679 RID: 38521 RVA: 0x00286268 File Offset: 0x00284468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69648, XrefRangeEnd = 69650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessFurnitureElement_b__0(MoveDirection direction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ProcessFurnitureElement_b__0_Internal_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600967A RID: 38522 RVA: 0x002862A8 File Offset: 0x002844A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69650, XrefRangeEnd = 69652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessFurnitureElement_b__1(MoveDirection direction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ProcessFurnitureElement_b__1_Internal_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600967B RID: 38523 RVA: 0x002862E8 File Offset: 0x002844E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69652, XrefRangeEnd = 69654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessFurnitureElement_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ProcessFurnitureElement_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600967C RID: 38524 RVA: 0x0028632C File Offset: 0x0028452C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessFurnitureElement_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ProcessFurnitureElement_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600967D RID: 38525 RVA: 0x00286370 File Offset: 0x00284570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69654, XrefRangeEnd = 69664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessFurnitureElement_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ProcessFurnitureElement_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600967E RID: 38526 RVA: 0x0005158A File Offset: 0x0004F78A
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031F8 RID: 12792
			// (get) Token: 0x0600967F RID: 38527 RVA: 0x002863A4 File Offset: 0x002845A4
			// (set) Token: 0x06009680 RID: 38528 RVA: 0x00051593 File Offset: 0x0004F793
			public unsafe DLC4_FlandreHomeDecorationStoragePanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationStoragePanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031F9 RID: 12793
			// (get) Token: 0x06009681 RID: 38529 RVA: 0x002863D4 File Offset: 0x002845D4
			// (set) Token: 0x06009682 RID: 38530 RVA: 0x000515B2 File Offset: 0x0004F7B2
			public FlandreHomeFurnitureProfile.FlandreHomeFurniture thisFurniture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeFieldInfoPtr_thisFurniture);
					return new FlandreHomeFurnitureProfile.FlandreHomeFurniture(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationStoragePanel.__c__DisplayClass21_0.NativeFieldInfoPtr_thisFurniture), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006190 RID: 24976
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006191 RID: 24977
			private static readonly IntPtr NativeFieldInfoPtr_thisFurniture;

			// Token: 0x04006192 RID: 24978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006193 RID: 24979
			private static readonly IntPtr NativeMethodInfoPtr__ProcessFurnitureElement_b__0_Internal_Void_MoveDirection_0;

			// Token: 0x04006194 RID: 24980
			private static readonly IntPtr NativeMethodInfoPtr__ProcessFurnitureElement_b__1_Internal_Void_MoveDirection_0;

			// Token: 0x04006195 RID: 24981
			private static readonly IntPtr NativeMethodInfoPtr__ProcessFurnitureElement_b__2_Internal_Void_Image_0;

			// Token: 0x04006196 RID: 24982
			private static readonly IntPtr NativeMethodInfoPtr__ProcessFurnitureElement_b__3_Internal_Void_Image_0;

			// Token: 0x04006197 RID: 24983
			private static readonly IntPtr NativeMethodInfoPtr__ProcessFurnitureElement_b__4_Internal_Void_0;
		}
	}
}
