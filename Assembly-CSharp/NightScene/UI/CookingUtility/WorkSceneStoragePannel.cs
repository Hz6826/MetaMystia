using System;
using System.Runtime.InteropServices;
using Common.UI;
using Common.UI.Filter;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.RunTime.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace NightScene.UI.CookingUtility
{
	// Token: 0x020001D9 RID: 473
	public class WorkSceneStoragePannel : UIPanelExtern
	{
		// Token: 0x06003BB5 RID: 15285 RVA: 0x00169D34 File Offset: 0x00167F34
		// Note: this type is marked as 'beforefieldinit'.
		static WorkSceneStoragePannel()
		{
			Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.CookingUtility", "WorkSceneStoragePannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr);
			WorkSceneStoragePannel.NativeFieldInfoPtr_m_Scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "m_Scheduler");
			WorkSceneStoragePannel.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "title");
			WorkSceneStoragePannel.NativeFieldInfoPtr_scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "scroller");
			WorkSceneStoragePannel.NativeFieldInfoPtr_describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "describer");
			WorkSceneStoragePannel.NativeFieldInfoPtr_describerPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "describerPannel");
			WorkSceneStoragePannel.NativeFieldInfoPtr_describerSubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "describerSubPannel");
			WorkSceneStoragePannel.NativeFieldInfoPtr_itemParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "itemParent");
			WorkSceneStoragePannel.NativeFieldInfoPtr_foodField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "foodField");
			WorkSceneStoragePannel.NativeFieldInfoPtr_bevField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "bevField");
			WorkSceneStoragePannel.NativeFieldInfoPtr_foodCanvasField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "foodCanvasField");
			WorkSceneStoragePannel.NativeFieldInfoPtr_bevCanvasField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "bevCanvasField");
			WorkSceneStoragePannel.NativeFieldInfoPtr_contentBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "contentBG");
			WorkSceneStoragePannel.NativeFieldInfoPtr_foodContentBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "foodContentBG");
			WorkSceneStoragePannel.NativeFieldInfoPtr_beverageContentBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "beverageContentBG");
			WorkSceneStoragePannel.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "open");
			WorkSceneStoragePannel.NativeFieldInfoPtr_close = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "close");
			WorkSceneStoragePannel.NativeFieldInfoPtr_noTransparentColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "noTransparentColor");
			WorkSceneStoragePannel.NativeFieldInfoPtr_highLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "highLightColor");
			WorkSceneStoragePannel.NativeFieldInfoPtr_filterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "filterButton");
			WorkSceneStoragePannel.NativeFieldInfoPtr_OpenContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "OpenContext");
			WorkSceneStoragePannel.NativeFieldInfoPtr_m_Beverages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "m_Beverages");
			WorkSceneStoragePannel.NativeFieldInfoPtr_m_BeveragesFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "m_BeveragesFilter");
			WorkSceneStoragePannel.NativeFieldInfoPtr_m_Foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "m_Foods");
			WorkSceneStoragePannel.NativeFieldInfoPtr_m_FoodsFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "m_FoodsFilter");
			WorkSceneStoragePannel.NativeFieldInfoPtr_canOpenFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "canOpenFilter");
			WorkSceneStoragePannel.NativeFieldInfoPtr_describeObjectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "describeObjectCallback");
			WorkSceneStoragePannel.NativeFieldInfoPtr_getGroupCountCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "getGroupCountCallback");
			WorkSceneStoragePannel.NativeFieldInfoPtr_getPinnedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "getPinnedCallback");
			WorkSceneStoragePannel.NativeFieldInfoPtr_m_BevsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "m_BevsGroup");
			WorkSceneStoragePannel.NativeFieldInfoPtr_m_CurrentSwitchAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "m_CurrentSwitchAction");
			WorkSceneStoragePannel.NativeFieldInfoPtr_m_CurrentTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "m_CurrentTray");
			WorkSceneStoragePannel.NativeFieldInfoPtr_m_FoodsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "m_FoodsGroup");
			WorkSceneStoragePannel.NativeMethodInfoPtr_get_openType_Private_get_SellableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674400);
			WorkSceneStoragePannel.NativeMethodInfoPtr_get_ActiveInStorageGroup_Private_get_StaticVerticalGridScrollListUILogicalGroupT_3_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674401);
			WorkSceneStoragePannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674402);
			WorkSceneStoragePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674403);
			WorkSceneStoragePannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674404);
			WorkSceneStoragePannel.NativeMethodInfoPtr_ResetFilter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674405);
			WorkSceneStoragePannel.NativeMethodInfoPtr_OnTertiarySwtichPressed_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674406);
			WorkSceneStoragePannel.NativeMethodInfoPtr_OnTertiarySwitchPresed_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674407);
			WorkSceneStoragePannel.NativeMethodInfoPtr_OpenFilterPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674408);
			WorkSceneStoragePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674409);
			WorkSceneStoragePannel.NativeMethodInfoPtr_OnTrayUpDownLoop_Private_Void_MoveDirection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674410);
			WorkSceneStoragePannel.NativeMethodInfoPtr_SetParamValue_Private_Void_Func_2_Int32_Boolean_Func_1_Boolean_Action_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674411);
			WorkSceneStoragePannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674412);
			WorkSceneStoragePannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674413);
			WorkSceneStoragePannel.NativeMethodInfoPtr_UpdateFoodField_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674414);
			WorkSceneStoragePannel.NativeMethodInfoPtr_UpdateBevField_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674415);
			WorkSceneStoragePannel.NativeMethodInfoPtr_OnInvalidTrayElementSelect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674416);
			WorkSceneStoragePannel.NativeMethodInfoPtr_OnTrayElementSelect_Private_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674417);
			WorkSceneStoragePannel.NativeMethodInfoPtr_ReturnTrayToStorage_Private_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674418);
			WorkSceneStoragePannel.NativeMethodInfoPtr_TryNavigateToTrayElement_Private_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674419);
			WorkSceneStoragePannel.NativeMethodInfoPtr_TryNavigateToFirstStorageElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674420);
			WorkSceneStoragePannel.NativeMethodInfoPtr_Extract_Private_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674421);
			WorkSceneStoragePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674422);
			WorkSceneStoragePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674423);
			WorkSceneStoragePannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674424);
			WorkSceneStoragePannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674425);
			WorkSceneStoragePannel.NativeMethodInfoPtr__OpenFilterPanel_b__42_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674426);
			WorkSceneStoragePannel.NativeMethodInfoPtr__OpenFilterPanel_b__42_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, 100674427);
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x0016A214 File Offset: 0x00168414
		public unsafe Sellable.SellableType openType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 135746, RefRangeEnd = 135747, XrefRangeStart = 135743, XrefRangeEnd = 135746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_get_openType_Private_get_SellableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06003BB7 RID: 15287 RVA: 0x0016A250 File Offset: 0x00168450
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> ActiveInStorageGroup
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 135750, RefRangeEnd = 135755, XrefRangeStart = 135747, XrefRangeEnd = 135750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_get_ActiveInStorageGroup_Private_get_StaticVerticalGridScrollListUILogicalGroupT_3_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple>>(intPtr3) : null;
			}
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x0016A290 File Offset: 0x00168490
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneStoragePannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x0016A2CC File Offset: 0x001684CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135755, XrefRangeEnd = 135800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneStoragePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x0016A308 File Offset: 0x00168508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135800, XrefRangeEnd = 135812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneStoragePannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x0016A344 File Offset: 0x00168544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135812, XrefRangeEnd = 135815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_ResetFilter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x0016A378 File Offset: 0x00168578
		[CallerCount(0)]
		public unsafe void OnTertiarySwtichPressed(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_OnTertiarySwtichPressed_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x0016A3C0 File Offset: 0x001685C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135815, XrefRangeEnd = 135819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTertiarySwitchPresed(InputAction.CallbackContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_OnTertiarySwitchPresed_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x0016A408 File Offset: 0x00168608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135850, RefRangeEnd = 135851, XrefRangeStart = 135819, XrefRangeEnd = 135850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenFilterPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_OpenFilterPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x0016A43C File Offset: 0x0016863C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135851, XrefRangeEnd = 136142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneStoragePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x0016A478 File Offset: 0x00168678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136142, XrefRangeEnd = 136147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTrayUpDownLoop(MoveDirection direction, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_OnTrayUpDownLoop_Private_Void_MoveDirection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x0016A4C4 File Offset: 0x001686C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136147, XrefRangeEnd = 136150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParamValue(Func<int, bool> getPinnedCallback, Func<bool> getGroupCountCallback, Action<Sellable> describeObjectCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(getPinnedCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getGroupCountCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describeObjectCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_SetParamValue_Private_Void_Func_2_Int32_Boolean_Func_1_Boolean_Action_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x0016A52C File Offset: 0x0016872C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136150, XrefRangeEnd = 136209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementEnabled(KeyValuePair<Sellable, int> objectBase, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(objectBase));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x0016A598 File Offset: 0x00168798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136209, XrefRangeEnd = 136231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementSelected(KeyValuePair<Sellable, int> value, UIElementCluster uiElementCluster, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x0016A604 File Offset: 0x00168804
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 136296, RefRangeEnd = 136301, XrefRangeStart = 136231, XrefRangeEnd = 136296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFoodField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_UpdateFoodField_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x0016A638 File Offset: 0x00168838
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 136363, RefRangeEnd = 136367, XrefRangeStart = 136301, XrefRangeEnd = 136363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBevField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_UpdateBevField_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x0016A66C File Offset: 0x0016886C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136367, XrefRangeEnd = 136376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInvalidTrayElementSelect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_OnInvalidTrayElementSelect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x0016A6A0 File Offset: 0x001688A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136376, XrefRangeEnd = 136390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTrayElementSelect(Sellable sellable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_OnTrayElementSelect_Private_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x0016A6E4 File Offset: 0x001688E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136390, XrefRangeEnd = 136455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnTrayToStorage(Sellable sellable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_ReturnTrayToStorage_Private_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x0016A728 File Offset: 0x00168928
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 136482, RefRangeEnd = 136485, XrefRangeStart = 136455, XrefRangeEnd = 136482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryNavigateToTrayElement(Nullable<int> columnIndex = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(columnIndex));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_TryNavigateToTrayElement_Private_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x0016A770 File Offset: 0x00168970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136485, XrefRangeEnd = 136492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryNavigateToFirstStorageElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_TryNavigateToFirstStorageElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x0016A7A4 File Offset: 0x001689A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136561, RefRangeEnd = 136562, XrefRangeStart = 136492, XrefRangeEnd = 136561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Extract(Sellable toExtract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toExtract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_Extract_Private_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x0016A7E8 File Offset: 0x001689E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136562, XrefRangeEnd = 136584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneStoragePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x0016A824 File Offset: 0x00168A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136584, XrefRangeEnd = 136619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneStoragePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x0016A860 File Offset: 0x00168A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136619, XrefRangeEnd = 136645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSceneStoragePannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x0016A89C File Offset: 0x00168A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Common_UI_IExternalPanel_CloseExternPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x0016A8D0 File Offset: 0x00168AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136645, XrefRangeEnd = 136650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenFilterPanel_b__42_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr__OpenFilterPanel_b__42_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x0016A904 File Offset: 0x00168B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136650, XrefRangeEnd = 136655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenFilterPanel_b__42_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.NativeMethodInfoPtr__OpenFilterPanel_b__42_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x000217D5 File Offset: 0x0001F9D5
		public WorkSceneStoragePannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06003BD3 RID: 15315 RVA: 0x0016A938 File Offset: 0x00168B38
		// (set) Token: 0x06003BD4 RID: 15316 RVA: 0x000217DE File Offset: 0x0001F9DE
		public unsafe ActionExecutionScheduler m_Scheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_Scheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_Scheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06003BD5 RID: 15317 RVA: 0x0016A968 File Offset: 0x00168B68
		// (set) Token: 0x06003BD6 RID: 15318 RVA: 0x000217FD File Offset: 0x0001F9FD
		public unsafe TextMeshProUGUI title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06003BD7 RID: 15319 RVA: 0x0016A998 File Offset: 0x00168B98
		// (set) Token: 0x06003BD8 RID: 15320 RVA: 0x0002181C File Offset: 0x0001FA1C
		public unsafe AdpProgressIndicatorComponent scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06003BD9 RID: 15321 RVA: 0x0016A9C8 File Offset: 0x00168BC8
		// (set) Token: 0x06003BDA RID: 15322 RVA: 0x0002183B File Offset: 0x0001FA3B
		public unsafe SellableDescriber describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06003BDB RID: 15323 RVA: 0x0016A9F8 File Offset: 0x00168BF8
		// (set) Token: 0x06003BDC RID: 15324 RVA: 0x0002185A File Offset: 0x0001FA5A
		public unsafe CanvasGroup describerPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_describerPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_describerPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06003BDD RID: 15325 RVA: 0x0016AA28 File Offset: 0x00168C28
		// (set) Token: 0x06003BDE RID: 15326 RVA: 0x00021879 File Offset: 0x0001FA79
		public unsafe CanvasGroup describerSubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_describerSubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_describerSubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x0016AA58 File Offset: 0x00168C58
		// (set) Token: 0x06003BE0 RID: 15328 RVA: 0x00021898 File Offset: 0x0001FA98
		public unsafe GameObject itemParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_itemParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_itemParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001495 RID: 5269
		// (get) Token: 0x06003BE1 RID: 15329 RVA: 0x0016AA88 File Offset: 0x00168C88
		// (set) Token: 0x06003BE2 RID: 15330 RVA: 0x000218B7 File Offset: 0x0001FAB7
		public unsafe GridLayoutGroup foodField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_foodField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_foodField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001496 RID: 5270
		// (get) Token: 0x06003BE3 RID: 15331 RVA: 0x0016AAB8 File Offset: 0x00168CB8
		// (set) Token: 0x06003BE4 RID: 15332 RVA: 0x000218D6 File Offset: 0x0001FAD6
		public unsafe GridLayoutGroup bevField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_bevField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_bevField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001497 RID: 5271
		// (get) Token: 0x06003BE5 RID: 15333 RVA: 0x0016AAE8 File Offset: 0x00168CE8
		// (set) Token: 0x06003BE6 RID: 15334 RVA: 0x000218F5 File Offset: 0x0001FAF5
		public unsafe CanvasGroup foodCanvasField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_foodCanvasField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_foodCanvasField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x06003BE7 RID: 15335 RVA: 0x0016AB18 File Offset: 0x00168D18
		// (set) Token: 0x06003BE8 RID: 15336 RVA: 0x00021914 File Offset: 0x0001FB14
		public unsafe CanvasGroup bevCanvasField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_bevCanvasField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_bevCanvasField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001499 RID: 5273
		// (get) Token: 0x06003BE9 RID: 15337 RVA: 0x0016AB48 File Offset: 0x00168D48
		// (set) Token: 0x06003BEA RID: 15338 RVA: 0x00021933 File Offset: 0x0001FB33
		public unsafe Image contentBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_contentBG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_contentBG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x0016AB78 File Offset: 0x00168D78
		// (set) Token: 0x06003BEC RID: 15340 RVA: 0x00021952 File Offset: 0x0001FB52
		public unsafe Sprite foodContentBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_foodContentBG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_foodContentBG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x0016ABA8 File Offset: 0x00168DA8
		// (set) Token: 0x06003BEE RID: 15342 RVA: 0x00021971 File Offset: 0x0001FB71
		public unsafe Sprite beverageContentBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_beverageContentBG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_beverageContentBG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06003BEF RID: 15343 RVA: 0x0016ABD8 File Offset: 0x00168DD8
		// (set) Token: 0x06003BF0 RID: 15344 RVA: 0x00021990 File Offset: 0x0001FB90
		public unsafe AudioClip open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_open);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_open), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x0016AC08 File Offset: 0x00168E08
		// (set) Token: 0x06003BF2 RID: 15346 RVA: 0x000219AF File Offset: 0x0001FBAF
		public unsafe AudioClip close
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_close);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_close), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x0016AC38 File Offset: 0x00168E38
		// (set) Token: 0x06003BF4 RID: 15348 RVA: 0x000219CE File Offset: 0x0001FBCE
		public unsafe Color noTransparentColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_noTransparentColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_noTransparentColor)) = value;
			}
		}

		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x06003BF5 RID: 15349 RVA: 0x0016AC60 File Offset: 0x00168E60
		// (set) Token: 0x06003BF6 RID: 15350 RVA: 0x000219E9 File Offset: 0x0001FBE9
		public unsafe Color highLightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_highLightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_highLightColor)) = value;
			}
		}

		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x06003BF7 RID: 15351 RVA: 0x0016AC88 File Offset: 0x00168E88
		// (set) Token: 0x06003BF8 RID: 15352 RVA: 0x00021A04 File Offset: 0x0001FC04
		public unsafe UIButtonSimple filterButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_filterButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_filterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A1 RID: 5281
		// (get) Token: 0x06003BF9 RID: 15353 RVA: 0x0016ACB8 File Offset: 0x00168EB8
		// (set) Token: 0x06003BFA RID: 15354 RVA: 0x00021A23 File Offset: 0x0001FC23
		public Nullable<WorkSceneStoragePannel.PannelOpenContext> OpenContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_OpenContext);
				return new Nullable<WorkSceneStoragePannel.PannelOpenContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<WorkSceneStoragePannel.PannelOpenContext>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_OpenContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<WorkSceneStoragePannel.PannelOpenContext>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x06003BFB RID: 15355 RVA: 0x0016ACE8 File Offset: 0x00168EE8
		// (set) Token: 0x06003BFC RID: 15356 RVA: 0x00021A51 File Offset: 0x0001FC51
		public unsafe List<KeyValuePair<Sellable, int>> m_Beverages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_Beverages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Sellable, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_Beverages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x06003BFD RID: 15357 RVA: 0x0016AD18 File Offset: 0x00168F18
		// (set) Token: 0x06003BFE RID: 15358 RVA: 0x00021A70 File Offset: 0x0001FC70
		public unsafe List<IFilterConfig> m_BeveragesFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_BeveragesFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_BeveragesFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06003BFF RID: 15359 RVA: 0x0016AD48 File Offset: 0x00168F48
		// (set) Token: 0x06003C00 RID: 15360 RVA: 0x00021A8F File Offset: 0x0001FC8F
		public unsafe List<KeyValuePair<Sellable, int>> m_Foods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_Foods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Sellable, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_Foods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x06003C01 RID: 15361 RVA: 0x0016AD78 File Offset: 0x00168F78
		// (set) Token: 0x06003C02 RID: 15362 RVA: 0x00021AAE File Offset: 0x0001FCAE
		public unsafe List<IFilterConfig> m_FoodsFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_FoodsFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_FoodsFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06003C03 RID: 15363 RVA: 0x0016ADA8 File Offset: 0x00168FA8
		// (set) Token: 0x06003C04 RID: 15364 RVA: 0x00021ACD File Offset: 0x0001FCCD
		public unsafe bool canOpenFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_canOpenFilter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_canOpenFilter)) = value;
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x06003C05 RID: 15365 RVA: 0x0016ADD0 File Offset: 0x00168FD0
		// (set) Token: 0x06003C06 RID: 15366 RVA: 0x00021AE8 File Offset: 0x0001FCE8
		public unsafe Action<Sellable> describeObjectCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_describeObjectCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_describeObjectCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x0016AE00 File Offset: 0x00169000
		// (set) Token: 0x06003C08 RID: 15368 RVA: 0x00021B07 File Offset: 0x0001FD07
		public unsafe Func<bool> getGroupCountCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_getGroupCountCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_getGroupCountCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x06003C09 RID: 15369 RVA: 0x0016AE30 File Offset: 0x00169030
		// (set) Token: 0x06003C0A RID: 15370 RVA: 0x00021B26 File Offset: 0x0001FD26
		public unsafe Func<int, bool> getPinnedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_getPinnedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_getPinnedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06003C0B RID: 15371 RVA: 0x0016AE60 File Offset: 0x00169060
		// (set) Token: 0x06003C0C RID: 15372 RVA: 0x00021B45 File Offset: 0x0001FD45
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> m_BevsGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_BevsGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_BevsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06003C0D RID: 15373 RVA: 0x0016AE90 File Offset: 0x00169090
		// (set) Token: 0x06003C0E RID: 15374 RVA: 0x00021B64 File Offset: 0x0001FD64
		public unsafe Action m_CurrentSwitchAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_CurrentSwitchAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_CurrentSwitchAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06003C0F RID: 15375 RVA: 0x0016AEC0 File Offset: 0x001690C0
		// (set) Token: 0x06003C10 RID: 15376 RVA: 0x00021B83 File Offset: 0x0001FD83
		public unsafe WorkSceneTrayPannel m_CurrentTray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_CurrentTray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneTrayPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_CurrentTray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06003C11 RID: 15377 RVA: 0x0016AEF0 File Offset: 0x001690F0
		// (set) Token: 0x06003C12 RID: 15378 RVA: 0x00021BA2 File Offset: 0x0001FDA2
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> m_FoodsGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_FoodsGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.NativeFieldInfoPtr_m_FoodsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400281F RID: 10271
		private static readonly IntPtr NativeFieldInfoPtr_m_Scheduler;

		// Token: 0x04002820 RID: 10272
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x04002821 RID: 10273
		private static readonly IntPtr NativeFieldInfoPtr_scroller;

		// Token: 0x04002822 RID: 10274
		private static readonly IntPtr NativeFieldInfoPtr_describer;

		// Token: 0x04002823 RID: 10275
		private static readonly IntPtr NativeFieldInfoPtr_describerPannel;

		// Token: 0x04002824 RID: 10276
		private static readonly IntPtr NativeFieldInfoPtr_describerSubPannel;

		// Token: 0x04002825 RID: 10277
		private static readonly IntPtr NativeFieldInfoPtr_itemParent;

		// Token: 0x04002826 RID: 10278
		private static readonly IntPtr NativeFieldInfoPtr_foodField;

		// Token: 0x04002827 RID: 10279
		private static readonly IntPtr NativeFieldInfoPtr_bevField;

		// Token: 0x04002828 RID: 10280
		private static readonly IntPtr NativeFieldInfoPtr_foodCanvasField;

		// Token: 0x04002829 RID: 10281
		private static readonly IntPtr NativeFieldInfoPtr_bevCanvasField;

		// Token: 0x0400282A RID: 10282
		private static readonly IntPtr NativeFieldInfoPtr_contentBG;

		// Token: 0x0400282B RID: 10283
		private static readonly IntPtr NativeFieldInfoPtr_foodContentBG;

		// Token: 0x0400282C RID: 10284
		private static readonly IntPtr NativeFieldInfoPtr_beverageContentBG;

		// Token: 0x0400282D RID: 10285
		private static readonly IntPtr NativeFieldInfoPtr_open;

		// Token: 0x0400282E RID: 10286
		private static readonly IntPtr NativeFieldInfoPtr_close;

		// Token: 0x0400282F RID: 10287
		private static readonly IntPtr NativeFieldInfoPtr_noTransparentColor;

		// Token: 0x04002830 RID: 10288
		private static readonly IntPtr NativeFieldInfoPtr_highLightColor;

		// Token: 0x04002831 RID: 10289
		private static readonly IntPtr NativeFieldInfoPtr_filterButton;

		// Token: 0x04002832 RID: 10290
		private static readonly IntPtr NativeFieldInfoPtr_OpenContext;

		// Token: 0x04002833 RID: 10291
		private static readonly IntPtr NativeFieldInfoPtr_m_Beverages;

		// Token: 0x04002834 RID: 10292
		private static readonly IntPtr NativeFieldInfoPtr_m_BeveragesFilter;

		// Token: 0x04002835 RID: 10293
		private static readonly IntPtr NativeFieldInfoPtr_m_Foods;

		// Token: 0x04002836 RID: 10294
		private static readonly IntPtr NativeFieldInfoPtr_m_FoodsFilter;

		// Token: 0x04002837 RID: 10295
		private static readonly IntPtr NativeFieldInfoPtr_canOpenFilter;

		// Token: 0x04002838 RID: 10296
		private static readonly IntPtr NativeFieldInfoPtr_describeObjectCallback;

		// Token: 0x04002839 RID: 10297
		private static readonly IntPtr NativeFieldInfoPtr_getGroupCountCallback;

		// Token: 0x0400283A RID: 10298
		private static readonly IntPtr NativeFieldInfoPtr_getPinnedCallback;

		// Token: 0x0400283B RID: 10299
		private static readonly IntPtr NativeFieldInfoPtr_m_BevsGroup;

		// Token: 0x0400283C RID: 10300
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSwitchAction;

		// Token: 0x0400283D RID: 10301
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentTray;

		// Token: 0x0400283E RID: 10302
		private static readonly IntPtr NativeFieldInfoPtr_m_FoodsGroup;

		// Token: 0x0400283F RID: 10303
		private static readonly IntPtr NativeMethodInfoPtr_get_openType_Private_get_SellableType_0;

		// Token: 0x04002840 RID: 10304
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveInStorageGroup_Private_get_StaticVerticalGridScrollListUILogicalGroupT_3_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04002841 RID: 10305
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x04002842 RID: 10306
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04002843 RID: 10307
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04002844 RID: 10308
		private static readonly IntPtr NativeMethodInfoPtr_ResetFilter_Private_Void_0;

		// Token: 0x04002845 RID: 10309
		private static readonly IntPtr NativeMethodInfoPtr_OnTertiarySwtichPressed_Private_Void_CallbackContext_0;

		// Token: 0x04002846 RID: 10310
		private static readonly IntPtr NativeMethodInfoPtr_OnTertiarySwitchPresed_Private_Void_CallbackContext_0;

		// Token: 0x04002847 RID: 10311
		private static readonly IntPtr NativeMethodInfoPtr_OpenFilterPanel_Private_Void_0;

		// Token: 0x04002848 RID: 10312
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04002849 RID: 10313
		private static readonly IntPtr NativeMethodInfoPtr_OnTrayUpDownLoop_Private_Void_MoveDirection_Int32_0;

		// Token: 0x0400284A RID: 10314
		private static readonly IntPtr NativeMethodInfoPtr_SetParamValue_Private_Void_Func_2_Int32_Boolean_Func_1_Boolean_Action_1_Sellable_0;

		// Token: 0x0400284B RID: 10315
		private static readonly IntPtr NativeMethodInfoPtr_OnElementEnabled_Private_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x0400284C RID: 10316
		private static readonly IntPtr NativeMethodInfoPtr_OnElementSelected_Private_Void_KeyValuePair_2_Sellable_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x0400284D RID: 10317
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFoodField_Private_Void_0;

		// Token: 0x0400284E RID: 10318
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBevField_Private_Void_0;

		// Token: 0x0400284F RID: 10319
		private static readonly IntPtr NativeMethodInfoPtr_OnInvalidTrayElementSelect_Private_Void_0;

		// Token: 0x04002850 RID: 10320
		private static readonly IntPtr NativeMethodInfoPtr_OnTrayElementSelect_Private_Void_Sellable_0;

		// Token: 0x04002851 RID: 10321
		private static readonly IntPtr NativeMethodInfoPtr_ReturnTrayToStorage_Private_Void_Sellable_0;

		// Token: 0x04002852 RID: 10322
		private static readonly IntPtr NativeMethodInfoPtr_TryNavigateToTrayElement_Private_Void_Nullable_1_Int32_0;

		// Token: 0x04002853 RID: 10323
		private static readonly IntPtr NativeMethodInfoPtr_TryNavigateToFirstStorageElement_Private_Void_0;

		// Token: 0x04002854 RID: 10324
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Private_Void_Sellable_0;

		// Token: 0x04002855 RID: 10325
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04002856 RID: 10326
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04002857 RID: 10327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002858 RID: 10328
		private static readonly IntPtr NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0;

		// Token: 0x04002859 RID: 10329
		private static readonly IntPtr NativeMethodInfoPtr__OpenFilterPanel_b__42_0_Private_Void_0;

		// Token: 0x0400285A RID: 10330
		private static readonly IntPtr NativeMethodInfoPtr__OpenFilterPanel_b__42_1_Private_Void_0;

		// Token: 0x02000975 RID: 2421
		[StructLayout(2)]
		public struct PannelOpenContext
		{
			// Token: 0x0600BBFE RID: 48126 RVA: 0x002F4B80 File Offset: 0x002F2D80
			// Note: this type is marked as 'beforefieldinit'.
			static PannelOpenContext()
			{
				Il2CppClassPointerStore<WorkSceneStoragePannel.PannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "PannelOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneStoragePannel.PannelOpenContext>.NativeClassPtr);
				WorkSceneStoragePannel.PannelOpenContext.NativeFieldInfoPtr_SetFoodAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.PannelOpenContext>.NativeClassPtr, "SetFoodAlpha");
				WorkSceneStoragePannel.PannelOpenContext.NativeFieldInfoPtr_SetBevAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.PannelOpenContext>.NativeClassPtr, "SetBevAlpha");
				WorkSceneStoragePannel.PannelOpenContext.NativeFieldInfoPtr_OpenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.PannelOpenContext>.NativeClassPtr, "OpenType");
				WorkSceneStoragePannel.PannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_SellableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.PannelOpenContext>.NativeClassPtr, 100674428);
			}

			// Token: 0x0600BBFF RID: 48127 RVA: 0x002F4BFC File Offset: 0x002F2DFC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 135674, RefRangeEnd = 135675, XrefRangeStart = 135674, XrefRangeEnd = 135674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PannelOpenContext(float setFoodAlpha, float setBevAlpha, Sellable.SellableType openType)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref setFoodAlpha;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setBevAlpha;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.PannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_SellableType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC00 RID: 48128 RVA: 0x000655EB File Offset: 0x000637EB
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorkSceneStoragePannel.PannelOpenContext>.NativeClassPtr, ref this));
			}

			// Token: 0x04007968 RID: 31080
			private static readonly IntPtr NativeFieldInfoPtr_SetFoodAlpha;

			// Token: 0x04007969 RID: 31081
			private static readonly IntPtr NativeFieldInfoPtr_SetBevAlpha;

			// Token: 0x0400796A RID: 31082
			private static readonly IntPtr NativeFieldInfoPtr_OpenType;

			// Token: 0x0400796B RID: 31083
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_SellableType_0;

			// Token: 0x0400796C RID: 31084
			[FieldOffset(0)]
			public readonly float SetFoodAlpha;

			// Token: 0x0400796D RID: 31085
			[FieldOffset(4)]
			public readonly float SetBevAlpha;

			// Token: 0x0400796E RID: 31086
			[FieldOffset(8)]
			public readonly Sellable.SellableType OpenType;
		}

		// Token: 0x02000976 RID: 2422
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneStoragePannel+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BC01 RID: 48129 RVA: 0x002F4C4C File Offset: 0x002F2E4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr);
				WorkSceneStoragePannel.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr, "<>4__this");
				WorkSceneStoragePannel.__c__DisplayClass43_0.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr, "instance");
				WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr, 100674429);
				WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr, 100674430);
				WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr, 100674431);
				WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr, 100674432);
				WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__11_Internal_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr, 100674433);
				WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr, 100674434);
				WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr, 100674435);
				WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr, 100674436);
				WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr, 100674437);
			}

			// Token: 0x0600BC02 RID: 48130 RVA: 0x002F4D54 File Offset: 0x002F2F54
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC03 RID: 48131 RVA: 0x002F4D90 File Offset: 0x002F2F90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135675, XrefRangeEnd = 135680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__10(int columnIndex, MoveDirection moveDirection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref columnIndex;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveDirection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC04 RID: 48132 RVA: 0x002F4DDC File Offset: 0x002F2FDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135680, XrefRangeEnd = 135681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC05 RID: 48133 RVA: 0x002F4E18 File Offset: 0x002F3018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135681, XrefRangeEnd = 135683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__3(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC06 RID: 48134 RVA: 0x002F4E5C File Offset: 0x002F305C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135683, XrefRangeEnd = 135688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__11(int columnIndex, MoveDirection moveDirection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref columnIndex;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveDirection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__11_Internal_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC07 RID: 48135 RVA: 0x002F4EA8 File Offset: 0x002F30A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135688, XrefRangeEnd = 135689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC08 RID: 48136 RVA: 0x002F4EE4 File Offset: 0x002F30E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__7(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC09 RID: 48137 RVA: 0x002F4F28 File Offset: 0x002F3128
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__8(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC0A RID: 48138 RVA: 0x002F4F78 File Offset: 0x002F3178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135689, XrefRangeEnd = 135692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__9(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC0B RID: 48139 RVA: 0x000655FD File Offset: 0x000637FD
			public __c__DisplayClass43_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D77 RID: 15735
			// (get) Token: 0x0600BC0C RID: 48140 RVA: 0x002F4FC4 File Offset: 0x002F31C4
			// (set) Token: 0x0600BC0D RID: 48141 RVA: 0x00065606 File Offset: 0x00063806
			public unsafe WorkSceneStoragePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneStoragePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D78 RID: 15736
			// (get) Token: 0x0600BC0E RID: 48142 RVA: 0x002F4FF4 File Offset: 0x002F31F4
			// (set) Token: 0x0600BC0F RID: 48143 RVA: 0x00065625 File Offset: 0x00063825
			public unsafe IzakayaTray instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass43_0.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaTray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass43_0.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400796F RID: 31087
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007970 RID: 31088
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x04007971 RID: 31089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007972 RID: 31090
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_Int32_MoveDirection_0;

			// Token: 0x04007973 RID: 31091
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Boolean_0;

			// Token: 0x04007974 RID: 31092
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_Sellable_0;

			// Token: 0x04007975 RID: 31093
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__11_Internal_Void_Int32_MoveDirection_0;

			// Token: 0x04007976 RID: 31094
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Boolean_0;

			// Token: 0x04007977 RID: 31095
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_Sellable_0;

			// Token: 0x04007978 RID: 31096
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__8_Internal_Boolean_Sellable_0;

			// Token: 0x04007979 RID: 31097
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__9_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000977 RID: 2423
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneStoragePannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600BC10 RID: 48144 RVA: 0x002F5024 File Offset: 0x002F3224
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr);
				WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, "<>9");
				WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, "<>9__43_0");
				WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__43_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, "<>9__43_1");
				WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__43_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, "<>9__43_4");
				WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__43_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, "<>9__43_5");
				WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__48_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, "<>9__48_0");
				WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__48_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, "<>9__48_1");
				WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__48_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, "<>9__48_2");
				WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, "<>9__49_0");
				WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__49_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, "<>9__49_1");
				WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__49_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, "<>9__49_2");
				WorkSceneStoragePannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, 100674439);
				WorkSceneStoragePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, 100674440);
				WorkSceneStoragePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, 100674441);
				WorkSceneStoragePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, 100674442);
				WorkSceneStoragePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_5_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, 100674443);
				WorkSceneStoragePannel.__c.NativeMethodInfoPtr__UpdateFoodField_b__48_0_Internal_Int32_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, 100674444);
				WorkSceneStoragePannel.__c.NativeMethodInfoPtr__UpdateFoodField_b__48_1_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, 100674445);
				WorkSceneStoragePannel.__c.NativeMethodInfoPtr__UpdateFoodField_b__48_2_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, 100674446);
				WorkSceneStoragePannel.__c.NativeMethodInfoPtr__UpdateBevField_b__49_0_Internal_Int32_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, 100674447);
				WorkSceneStoragePannel.__c.NativeMethodInfoPtr__UpdateBevField_b__49_1_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, 100674448);
				WorkSceneStoragePannel.__c.NativeMethodInfoPtr__UpdateBevField_b__49_2_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr, 100674449);
			}

			// Token: 0x0600BC11 RID: 48145 RVA: 0x002F5208 File Offset: 0x002F3408
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneStoragePannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC12 RID: 48146 RVA: 0x002F5244 File Offset: 0x002F3444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135692, XrefRangeEnd = 135695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__43_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC13 RID: 48147 RVA: 0x002F5280 File Offset: 0x002F3480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135695, XrefRangeEnd = 135701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__43_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC14 RID: 48148 RVA: 0x002F52CC File Offset: 0x002F34CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135701, XrefRangeEnd = 135702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__43_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC15 RID: 48149 RVA: 0x002F5308 File Offset: 0x002F3508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135702, XrefRangeEnd = 135706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__43_5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_5_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC16 RID: 48150 RVA: 0x002F5354 File Offset: 0x002F3554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135706, XrefRangeEnd = 135707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _UpdateFoodField_b__48_0(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c.NativeMethodInfoPtr__UpdateFoodField_b__48_0_Internal_Int32_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC17 RID: 48151 RVA: 0x002F53A8 File Offset: 0x002F35A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135707, XrefRangeEnd = 135708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _UpdateFoodField_b__48_1(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c.NativeMethodInfoPtr__UpdateFoodField_b__48_1_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0600BC18 RID: 48152 RVA: 0x002F5400 File Offset: 0x002F3600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135708, XrefRangeEnd = 135715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateFoodField_b__48_2(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c.NativeMethodInfoPtr__UpdateFoodField_b__48_2_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC19 RID: 48153 RVA: 0x002F5454 File Offset: 0x002F3654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135715, XrefRangeEnd = 135716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _UpdateBevField_b__49_0(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c.NativeMethodInfoPtr__UpdateBevField_b__49_0_Internal_Int32_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC1A RID: 48154 RVA: 0x002F54A8 File Offset: 0x002F36A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135716, XrefRangeEnd = 135717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _UpdateBevField_b__49_1(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c.NativeMethodInfoPtr__UpdateBevField_b__49_1_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0600BC1B RID: 48155 RVA: 0x002F5500 File Offset: 0x002F3700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135717, XrefRangeEnd = 135723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateBevField_b__49_2(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c.NativeMethodInfoPtr__UpdateBevField_b__49_2_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC1C RID: 48156 RVA: 0x00065644 File Offset: 0x00063844
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D79 RID: 15737
			// (get) Token: 0x0600BC1D RID: 48157 RVA: 0x002F5554 File Offset: 0x002F3754
			// (set) Token: 0x0600BC1E RID: 48158 RVA: 0x0006564D File Offset: 0x0006384D
			public unsafe static WorkSceneStoragePannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneStoragePannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7A RID: 15738
			// (get) Token: 0x0600BC1F RID: 48159 RVA: 0x002F557C File Offset: 0x002F377C
			// (set) Token: 0x0600BC20 RID: 48160 RVA: 0x0006565F File Offset: 0x0006385F
			public unsafe static Func<bool> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7B RID: 15739
			// (get) Token: 0x0600BC21 RID: 48161 RVA: 0x002F55A4 File Offset: 0x002F37A4
			// (set) Token: 0x0600BC22 RID: 48162 RVA: 0x00065671 File Offset: 0x00063871
			public unsafe static Func<int, bool> __9__43_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__43_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__43_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7C RID: 15740
			// (get) Token: 0x0600BC23 RID: 48163 RVA: 0x002F55CC File Offset: 0x002F37CC
			// (set) Token: 0x0600BC24 RID: 48164 RVA: 0x00065683 File Offset: 0x00063883
			public unsafe static Func<bool> __9__43_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__43_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__43_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7D RID: 15741
			// (get) Token: 0x0600BC25 RID: 48165 RVA: 0x002F55F4 File Offset: 0x002F37F4
			// (set) Token: 0x0600BC26 RID: 48166 RVA: 0x00065695 File Offset: 0x00063895
			public unsafe static Func<int, bool> __9__43_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__43_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__43_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7E RID: 15742
			// (get) Token: 0x0600BC27 RID: 48167 RVA: 0x002F561C File Offset: 0x002F381C
			// (set) Token: 0x0600BC28 RID: 48168 RVA: 0x000656A7 File Offset: 0x000638A7
			public unsafe static Func<KeyValuePair<Sellable, int>, int> __9__48_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__48_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__48_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D7F RID: 15743
			// (get) Token: 0x0600BC29 RID: 48169 RVA: 0x002F5644 File Offset: 0x002F3844
			// (set) Token: 0x0600BC2A RID: 48170 RVA: 0x000656B9 File Offset: 0x000638B9
			public unsafe static Func<KeyValuePair<Sellable, int>, Sellable> __9__48_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__48_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__48_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D80 RID: 15744
			// (get) Token: 0x0600BC2B RID: 48171 RVA: 0x002F566C File Offset: 0x002F386C
			// (set) Token: 0x0600BC2C RID: 48172 RVA: 0x000656CB File Offset: 0x000638CB
			public unsafe static Func<KeyValuePair<Sellable, int>, bool> __9__48_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__48_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__48_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D81 RID: 15745
			// (get) Token: 0x0600BC2D RID: 48173 RVA: 0x002F5694 File Offset: 0x002F3894
			// (set) Token: 0x0600BC2E RID: 48174 RVA: 0x000656DD File Offset: 0x000638DD
			public unsafe static Func<KeyValuePair<Sellable, int>, int> __9__49_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__49_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D82 RID: 15746
			// (get) Token: 0x0600BC2F RID: 48175 RVA: 0x002F56BC File Offset: 0x002F38BC
			// (set) Token: 0x0600BC30 RID: 48176 RVA: 0x000656EF File Offset: 0x000638EF
			public unsafe static Func<KeyValuePair<Sellable, int>, Sellable> __9__49_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__49_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__49_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D83 RID: 15747
			// (get) Token: 0x0600BC31 RID: 48177 RVA: 0x002F56E4 File Offset: 0x002F38E4
			// (set) Token: 0x0600BC32 RID: 48178 RVA: 0x00065701 File Offset: 0x00063901
			public unsafe static Func<KeyValuePair<Sellable, int>, bool> __9__49_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__49_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneStoragePannel.__c.NativeFieldInfoPtr___9__49_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400797A RID: 31098
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400797B RID: 31099
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x0400797C RID: 31100
			private static readonly IntPtr NativeFieldInfoPtr___9__43_1;

			// Token: 0x0400797D RID: 31101
			private static readonly IntPtr NativeFieldInfoPtr___9__43_4;

			// Token: 0x0400797E RID: 31102
			private static readonly IntPtr NativeFieldInfoPtr___9__43_5;

			// Token: 0x0400797F RID: 31103
			private static readonly IntPtr NativeFieldInfoPtr___9__48_0;

			// Token: 0x04007980 RID: 31104
			private static readonly IntPtr NativeFieldInfoPtr___9__48_1;

			// Token: 0x04007981 RID: 31105
			private static readonly IntPtr NativeFieldInfoPtr___9__48_2;

			// Token: 0x04007982 RID: 31106
			private static readonly IntPtr NativeFieldInfoPtr___9__49_0;

			// Token: 0x04007983 RID: 31107
			private static readonly IntPtr NativeFieldInfoPtr___9__49_1;

			// Token: 0x04007984 RID: 31108
			private static readonly IntPtr NativeFieldInfoPtr___9__49_2;

			// Token: 0x04007985 RID: 31109
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007986 RID: 31110
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_0_Internal_Boolean_0;

			// Token: 0x04007987 RID: 31111
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_1_Internal_Boolean_Int32_0;

			// Token: 0x04007988 RID: 31112
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_4_Internal_Boolean_0;

			// Token: 0x04007989 RID: 31113
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_5_Internal_Boolean_Int32_0;

			// Token: 0x0400798A RID: 31114
			private static readonly IntPtr NativeMethodInfoPtr__UpdateFoodField_b__48_0_Internal_Int32_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400798B RID: 31115
			private static readonly IntPtr NativeMethodInfoPtr__UpdateFoodField_b__48_1_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400798C RID: 31116
			private static readonly IntPtr NativeMethodInfoPtr__UpdateFoodField_b__48_2_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400798D RID: 31117
			private static readonly IntPtr NativeMethodInfoPtr__UpdateBevField_b__49_0_Internal_Int32_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400798E RID: 31118
			private static readonly IntPtr NativeMethodInfoPtr__UpdateBevField_b__49_1_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400798F RID: 31119
			private static readonly IntPtr NativeMethodInfoPtr__UpdateBevField_b__49_2_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0;
		}

		// Token: 0x02000978 RID: 2424
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneStoragePannel+<>c__DisplayClass46_0")]
		public sealed class __c__DisplayClass46_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BC33 RID: 48179 RVA: 0x002F570C File Offset: 0x002F390C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_0()
			{
				Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "<>c__DisplayClass46_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass46_0>.NativeClassPtr);
				WorkSceneStoragePannel.__c__DisplayClass46_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass46_0>.NativeClassPtr, "amount");
				WorkSceneStoragePannel.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass46_0>.NativeClassPtr, "<>4__this");
				WorkSceneStoragePannel.__c__DisplayClass46_0.NativeFieldInfoPtr_objectBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass46_0>.NativeClassPtr, "objectBase");
				WorkSceneStoragePannel.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass46_0>.NativeClassPtr, 100674450);
				WorkSceneStoragePannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass46_0>.NativeClassPtr, 100674451);
				WorkSceneStoragePannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass46_0>.NativeClassPtr, 100674452);
				WorkSceneStoragePannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass46_0>.NativeClassPtr, 100674453);
			}

			// Token: 0x0600BC34 RID: 48180 RVA: 0x002F57C4 File Offset: 0x002F39C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass46_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC35 RID: 48181 RVA: 0x002F5800 File Offset: 0x002F3A00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC36 RID: 48182 RVA: 0x002F5844 File Offset: 0x002F3A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC37 RID: 48183 RVA: 0x002F5888 File Offset: 0x002F3A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135723, XrefRangeEnd = 135726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass46_0.NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC38 RID: 48184 RVA: 0x00065713 File Offset: 0x00063913
			public __c__DisplayClass46_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D84 RID: 15748
			// (get) Token: 0x0600BC39 RID: 48185 RVA: 0x002F58BC File Offset: 0x002F3ABC
			// (set) Token: 0x0600BC3A RID: 48186 RVA: 0x0006571C File Offset: 0x0006391C
			public unsafe string amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass46_0.NativeFieldInfoPtr_amount);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass46_0.NativeFieldInfoPtr_amount), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003D85 RID: 15749
			// (get) Token: 0x0600BC3B RID: 48187 RVA: 0x002F58E4 File Offset: 0x002F3AE4
			// (set) Token: 0x0600BC3C RID: 48188 RVA: 0x0006573B File Offset: 0x0006393B
			public unsafe WorkSceneStoragePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneStoragePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D86 RID: 15750
			// (get) Token: 0x0600BC3D RID: 48189 RVA: 0x002F5914 File Offset: 0x002F3B14
			// (set) Token: 0x0600BC3E RID: 48190 RVA: 0x0006575A File Offset: 0x0006395A
			public KeyValuePair<Sellable, int> objectBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass46_0.NativeFieldInfoPtr_objectBase);
					return new KeyValuePair<Sellable, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<Sellable, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass46_0.NativeFieldInfoPtr_objectBase), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<Sellable, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007990 RID: 31120
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04007991 RID: 31121
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007992 RID: 31122
			private static readonly IntPtr NativeFieldInfoPtr_objectBase;

			// Token: 0x04007993 RID: 31123
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007994 RID: 31124
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04007995 RID: 31125
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04007996 RID: 31126
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_0;
		}

		// Token: 0x02000979 RID: 2425
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneStoragePannel+<>c__DisplayClass47_0")]
		public sealed class __c__DisplayClass47_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BC3F RID: 48191 RVA: 0x002F5944 File Offset: 0x002F3B44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "<>c__DisplayClass47_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass47_0>.NativeClassPtr);
				WorkSceneStoragePannel.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass47_0>.NativeClassPtr, "<>4__this");
				WorkSceneStoragePannel.__c__DisplayClass47_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass47_0>.NativeClassPtr, "value");
				WorkSceneStoragePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass47_0>.NativeClassPtr, 100674454);
				WorkSceneStoragePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass47_0>.NativeClassPtr, 100674455);
				WorkSceneStoragePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__OnElementSelected_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass47_0>.NativeClassPtr, 100674456);
			}

			// Token: 0x0600BC40 RID: 48192 RVA: 0x002F59D4 File Offset: 0x002F3BD4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass47_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC41 RID: 48193 RVA: 0x002F5A10 File Offset: 0x002F3C10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135726, XrefRangeEnd = 135728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC42 RID: 48194 RVA: 0x002F5A44 File Offset: 0x002F3C44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135728, XrefRangeEnd = 135730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass47_0.NativeMethodInfoPtr__OnElementSelected_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC43 RID: 48195 RVA: 0x00065788 File Offset: 0x00063988
			public __c__DisplayClass47_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D87 RID: 15751
			// (get) Token: 0x0600BC44 RID: 48196 RVA: 0x002F5A78 File Offset: 0x002F3C78
			// (set) Token: 0x0600BC45 RID: 48197 RVA: 0x00065791 File Offset: 0x00063991
			public unsafe WorkSceneStoragePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneStoragePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass47_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D88 RID: 15752
			// (get) Token: 0x0600BC46 RID: 48198 RVA: 0x002F5AA8 File Offset: 0x002F3CA8
			// (set) Token: 0x0600BC47 RID: 48199 RVA: 0x000657B0 File Offset: 0x000639B0
			public KeyValuePair<Sellable, int> value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass47_0.NativeFieldInfoPtr_value);
					return new KeyValuePair<Sellable, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<Sellable, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass47_0.NativeFieldInfoPtr_value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<Sellable, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04007997 RID: 31127
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007998 RID: 31128
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04007999 RID: 31129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400799A RID: 31130
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_0;

			// Token: 0x0400799B RID: 31131
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__1_Internal_Void_0;
		}

		// Token: 0x0200097A RID: 2426
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneStoragePannel+<>c__DisplayClass52_0")]
		public sealed class __c__DisplayClass52_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BC48 RID: 48200 RVA: 0x002F5AD8 File Offset: 0x002F3CD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass52_0()
			{
				Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "<>c__DisplayClass52_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass52_0>.NativeClassPtr);
				WorkSceneStoragePannel.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass52_0>.NativeClassPtr, "<>4__this");
				WorkSceneStoragePannel.__c__DisplayClass52_0.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass52_0>.NativeClassPtr, "instance");
				WorkSceneStoragePannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass52_0>.NativeClassPtr, 100674457);
				WorkSceneStoragePannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ReturnTrayToStorage_b__0_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass52_0>.NativeClassPtr, 100674458);
				WorkSceneStoragePannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ReturnTrayToStorage_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass52_0>.NativeClassPtr, 100674459);
				WorkSceneStoragePannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ReturnTrayToStorage_b__2_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass52_0>.NativeClassPtr, 100674460);
			}

			// Token: 0x0600BC49 RID: 48201 RVA: 0x002F5B7C File Offset: 0x002F3D7C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass52_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass52_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC4A RID: 48202 RVA: 0x002F5BB8 File Offset: 0x002F3DB8
			[CallerCount(0)]
			public unsafe bool _ReturnTrayToStorage_b__0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ReturnTrayToStorage_b__0_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC4B RID: 48203 RVA: 0x002F5C08 File Offset: 0x002F3E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135730, XrefRangeEnd = 135733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ReturnTrayToStorage_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ReturnTrayToStorage_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC4C RID: 48204 RVA: 0x002F5C54 File Offset: 0x002F3E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135733, XrefRangeEnd = 135736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ReturnTrayToStorage_b__2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ReturnTrayToStorage_b__2_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC4D RID: 48205 RVA: 0x000657DE File Offset: 0x000639DE
			public __c__DisplayClass52_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D89 RID: 15753
			// (get) Token: 0x0600BC4E RID: 48206 RVA: 0x002F5CA0 File Offset: 0x002F3EA0
			// (set) Token: 0x0600BC4F RID: 48207 RVA: 0x000657E7 File Offset: 0x000639E7
			public unsafe WorkSceneStoragePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneStoragePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D8A RID: 15754
			// (get) Token: 0x0600BC50 RID: 48208 RVA: 0x002F5CD0 File Offset: 0x002F3ED0
			// (set) Token: 0x0600BC51 RID: 48209 RVA: 0x00065806 File Offset: 0x00063A06
			public unsafe IzakayaTray instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass52_0.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaTray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass52_0.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400799C RID: 31132
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400799D RID: 31133
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x0400799E RID: 31134
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400799F RID: 31135
			private static readonly IntPtr NativeMethodInfoPtr__ReturnTrayToStorage_b__0_Internal_Boolean_Sellable_0;

			// Token: 0x040079A0 RID: 31136
			private static readonly IntPtr NativeMethodInfoPtr__ReturnTrayToStorage_b__1_Internal_Boolean_Int32_0;

			// Token: 0x040079A1 RID: 31137
			private static readonly IntPtr NativeMethodInfoPtr__ReturnTrayToStorage_b__2_Internal_Boolean_Int32_0;
		}

		// Token: 0x0200097B RID: 2427
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneStoragePannel+<>c__DisplayClass55_0")]
		public sealed class __c__DisplayClass55_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BC52 RID: 48210 RVA: 0x002F5D00 File Offset: 0x002F3F00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneStoragePannel>.NativeClassPtr, "<>c__DisplayClass55_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass55_0>.NativeClassPtr);
				WorkSceneStoragePannel.__c__DisplayClass55_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass55_0>.NativeClassPtr, "<>4__this");
				WorkSceneStoragePannel.__c__DisplayClass55_0.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass55_0>.NativeClassPtr, "instance");
				WorkSceneStoragePannel.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass55_0>.NativeClassPtr, 100674461);
				WorkSceneStoragePannel.__c__DisplayClass55_0.NativeMethodInfoPtr__Extract_b__0_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass55_0>.NativeClassPtr, 100674462);
				WorkSceneStoragePannel.__c__DisplayClass55_0.NativeMethodInfoPtr__Extract_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass55_0>.NativeClassPtr, 100674463);
				WorkSceneStoragePannel.__c__DisplayClass55_0.NativeMethodInfoPtr__Extract_b__2_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass55_0>.NativeClassPtr, 100674464);
			}

			// Token: 0x0600BC53 RID: 48211 RVA: 0x002F5DA4 File Offset: 0x002F3FA4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneStoragePannel.__c__DisplayClass55_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC54 RID: 48212 RVA: 0x002F5DE0 File Offset: 0x002F3FE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135736, XrefRangeEnd = 135737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Extract_b__0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass55_0.NativeMethodInfoPtr__Extract_b__0_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC55 RID: 48213 RVA: 0x002F5E30 File Offset: 0x002F4030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135737, XrefRangeEnd = 135740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Extract_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass55_0.NativeMethodInfoPtr__Extract_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC56 RID: 48214 RVA: 0x002F5E7C File Offset: 0x002F407C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135740, XrefRangeEnd = 135743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Extract_b__2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneStoragePannel.__c__DisplayClass55_0.NativeMethodInfoPtr__Extract_b__2_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BC57 RID: 48215 RVA: 0x00065825 File Offset: 0x00063A25
			public __c__DisplayClass55_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D8B RID: 15755
			// (get) Token: 0x0600BC58 RID: 48216 RVA: 0x002F5EC8 File Offset: 0x002F40C8
			// (set) Token: 0x0600BC59 RID: 48217 RVA: 0x0006582E File Offset: 0x00063A2E
			public unsafe WorkSceneStoragePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass55_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneStoragePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass55_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D8C RID: 15756
			// (get) Token: 0x0600BC5A RID: 48218 RVA: 0x002F5EF8 File Offset: 0x002F40F8
			// (set) Token: 0x0600BC5B RID: 48219 RVA: 0x0006584D File Offset: 0x00063A4D
			public unsafe IzakayaTray instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass55_0.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaTray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneStoragePannel.__c__DisplayClass55_0.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040079A2 RID: 31138
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040079A3 RID: 31139
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x040079A4 RID: 31140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040079A5 RID: 31141
			private static readonly IntPtr NativeMethodInfoPtr__Extract_b__0_Internal_Boolean_Sellable_0;

			// Token: 0x040079A6 RID: 31142
			private static readonly IntPtr NativeMethodInfoPtr__Extract_b__1_Internal_Boolean_Int32_0;

			// Token: 0x040079A7 RID: 31143
			private static readonly IntPtr NativeMethodInfoPtr__Extract_b__2_Internal_Boolean_Int32_0;
		}
	}
}
