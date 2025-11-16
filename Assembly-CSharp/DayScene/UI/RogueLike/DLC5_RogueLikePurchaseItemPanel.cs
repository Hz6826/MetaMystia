using System;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000119 RID: 281
	public class DLC5_RogueLikePurchaseItemPanel : UISubPanel<DLC5_RogueLikePurchasePanel>
	{
		// Token: 0x06001FA5 RID: 8101 RVA: 0x00107774 File Offset: 0x00105974
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikePurchaseItemPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikePurchaseItemPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr);
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_InStoreGroup");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_InCartGroup");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr__InspectingProductType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "<InspectingProductType>k__BackingField");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr__PanelOpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "<PanelOpenContext>k__BackingField");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_ActiveDescriber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_ActiveDescriber");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_InStoreLayoutGroup");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartLayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_InCartLayoutGroup");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_ElementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_ElementPrefab");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_DescriberPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_DescriberPrefab");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_DescriberCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_DescriberCanvasGroup");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_InStoreColumns");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreRows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_InStoreRows");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_InCartColumns");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartRows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_InCartRows");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStorageNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_InStorageNum");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_PriceNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_PriceNum");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_PriceSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_PriceSymbol");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_HasOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_HasOwned");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_ActionExecutionScheduler");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_InStoreProducts");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_InCartProducts");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_CalculatedPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_CalculatedPrice");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_ShouldRunBuyAllFunctionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_ShouldRunBuyAllFunctionOffset");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_Source");
			DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_SelectAllCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "m_SelectAllCall");
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_get_InspectingProductType_Public_get_InspectingProductType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668849);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_set_InspectingProductType_Public_set_Void_InspectingProductType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668850);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_get_PanelOpenContext_Public_get_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668851);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_set_PanelOpenContext_Public_set_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668852);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_get_CalculatedPrice_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668853);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_set_CalculatedPrice_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668854);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668855);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668856);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnSelectAllPressed_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668857);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnSelectAllReleased_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668858);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_SelectAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668859);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_BuyAll_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668860);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_GetProductPriceAfterDiscount_Protected_Virtual_New_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668861);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_Buy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668862);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_GetFinalFund_Protected_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668863);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_AfterPanelOpen_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668864);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_AfterBuy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668865);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_AfterAddToCart_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668866);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_AfterRemoveFromCart_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668867);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnInStoreItemSubmit_Private_Void_ProductReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668868);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnInStoreItemSubmitAll_Private_Void_ProductReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668869);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_UpdateBuyButtonInteractable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668870);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_get_CheckCouldNotBuy_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668871);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnInCartItemSubmit_Private_Void_ProductReference_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668872);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_MoveSelectedCore_Private_Static_Void_ProductReference_IStaticGridScrollListUILogicalGroup_List_1_ValueTuple_2_ProductReference_Int32_IStaticGridScrollListUILogicalGroup_List_1_ValueTuple_2_ProductReference_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668873);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_Move_Private_Static_Void_IList_1_ValueTuple_2_ProductReference_Int32_List_1_ValueTuple_2_ProductReference_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668874);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_Create_Private_StaticVerticalGridScrollListUILogicalGroupT_3_ValueTuple_2_ProductReference_Int32_UIElementCluster_UIButtonSimple_GridLayoutGroup_GameObject_Func_1_OpenContext_Func_1_IDescriber_Int32_Int32_IReadOnlyList_1_ValueTuple_2_ProductReference_Int32_Action_1_ProductReference_Action_1_ProductReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668875);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668876);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_UpdateNullIndicator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668877);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668878);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668879);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668880);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668881);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_0_Private_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668882);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_1_Private_IDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668883);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_2_Private_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668884);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_3_Private_IDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668885);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_4_Private_Void_ProductReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668886);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_5_Private_Void_ProductReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668887);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnSelectAllPressed_b__37_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668888);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__BuyAll_b__40_2_Private_Int32_ValueTuple_2_ProductReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668889);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnInStoreItemSubmit_b__48_0_Private_Int32_ValueTuple_2_ProductReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668890);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnInStoreItemSubmitAll_b__49_0_Private_Int32_ValueTuple_2_ProductReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668891);
			DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnInCartItemSubmit_b__53_0_Private_Int32_ValueTuple_2_ProductReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, 100668892);
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x00107D08 File Offset: 0x00105F08
		// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x00107D44 File Offset: 0x00105F44
		public unsafe InspectingProductType InspectingProductType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_get_InspectingProductType_Public_get_InspectingProductType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_set_InspectingProductType_Public_set_Void_InspectingProductType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x00107D84 File Offset: 0x00105F84
		// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x00107DC4 File Offset: 0x00105FC4
		public unsafe DLC5_RogueLikePurchasePanel.OpenContext PanelOpenContext
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_get_PanelOpenContext_Public_get_OpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.OpenContext>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77664, XrefRangeEnd = 77665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_set_PanelOpenContext_Public_set_Void_OpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06001FAA RID: 8106 RVA: 0x00107E08 File Offset: 0x00106008
		// (set) Token: 0x06001FAB RID: 8107 RVA: 0x00107E44 File Offset: 0x00106044
		public unsafe int CalculatedPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_get_CalculatedPrice_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77665, XrefRangeEnd = 77668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_set_CalculatedPrice_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x00107E84 File Offset: 0x00106084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77668, XrefRangeEnd = 77669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x00107ECC File Offset: 0x001060CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77669, XrefRangeEnd = 77751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x00107F08 File Offset: 0x00106108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77751, XrefRangeEnd = 77784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelectAllPressed(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnSelectAllPressed_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x00107F50 File Offset: 0x00106150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77784, XrefRangeEnd = 77786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelectAllReleased(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnSelectAllReleased_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x00107F98 File Offset: 0x00106198
		[CallerCount(0)]
		public unsafe void SelectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_SelectAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x00107FCC File Offset: 0x001061CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77786, XrefRangeEnd = 77859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuyAll(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_BuyAll_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x00108014 File Offset: 0x00106214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77859, XrefRangeEnd = 77861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetProductPriceAfterDiscount(Product product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_GetProductPriceAfterDiscount_Protected_Virtual_New_Int32_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x00108074 File Offset: 0x00106274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77861, XrefRangeEnd = 77977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Buy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_Buy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x001080A8 File Offset: 0x001062A8
		[CallerCount(0)]
		public unsafe virtual int GetFinalFund(int currentFund)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentFund;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_GetFinalFund_Protected_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FB5 RID: 8117 RVA: 0x001080FC File Offset: 0x001062FC
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AfterPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_AfterPanelOpen_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x00108138 File Offset: 0x00106338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77977, XrefRangeEnd = 77991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AfterBuy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_AfterBuy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x00108174 File Offset: 0x00106374
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AfterAddToCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_AfterAddToCart_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x001081B0 File Offset: 0x001063B0
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AfterRemoveFromCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_AfterRemoveFromCart_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x001081EC File Offset: 0x001063EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77991, XrefRangeEnd = 78006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInStoreItemSubmit(ProductReference productReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productReference);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnInStoreItemSubmit_Private_Void_ProductReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x00108230 File Offset: 0x00106430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78006, XrefRangeEnd = 78019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInStoreItemSubmitAll(ProductReference productReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productReference);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnInStoreItemSubmitAll_Private_Void_ProductReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x00108274 File Offset: 0x00106474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78019, XrefRangeEnd = 78027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateBuyButtonInteractable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_UpdateBuyButtonInteractable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x001082B0 File Offset: 0x001064B0
		public unsafe bool CheckCouldNotBuy
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 78029, RefRangeEnd = 78032, XrefRangeStart = 78027, XrefRangeEnd = 78029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_get_CheckCouldNotBuy_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FBD RID: 8125 RVA: 0x001082EC File Offset: 0x001064EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78045, RefRangeEnd = 78047, XrefRangeStart = 78032, XrefRangeEnd = 78045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInCartItemSubmit(ProductReference productReference, bool all)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productReference);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref all;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnInCartItemSubmit_Private_Void_ProductReference_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x0010833C File Offset: 0x0010653C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 78079, RefRangeEnd = 78082, XrefRangeStart = 78047, XrefRangeEnd = 78079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveSelectedCore(ProductReference productReference, IStaticGridScrollListUILogicalGroup moveFromControl, List<ValueTuple<ProductReference, int>> moveFrom, IStaticGridScrollListUILogicalGroup moveToControl, List<ValueTuple<ProductReference, int>> moveTo, bool moveAll)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productReference);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moveFromControl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moveFrom);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moveToControl);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moveTo);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_MoveSelectedCore_Private_Static_Void_ProductReference_IStaticGridScrollListUILogicalGroup_List_1_ValueTuple_2_ProductReference_Int32_IStaticGridScrollListUILogicalGroup_List_1_ValueTuple_2_ProductReference_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x001083CC File Offset: 0x001065CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 78118, RefRangeEnd = 78121, XrefRangeStart = 78082, XrefRangeEnd = 78118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Move(IList<ValueTuple<ProductReference, int>> moveFrom, List<ValueTuple<ProductReference, int>> moveTo, bool moveAll, int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(moveFrom);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moveTo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveAll;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_Move_Private_Static_Void_IList_1_ValueTuple_2_ProductReference_Int32_List_1_ValueTuple_2_ProductReference_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00108430 File Offset: 0x00106630
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78164, RefRangeEnd = 78166, XrefRangeStart = 78121, XrefRangeEnd = 78164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<ProductReference, int>, UIElementCluster, UIButtonSimple> Create(GridLayoutGroup layoutGroup, GameObject elementPrefab, Func<DLC5_RogueLikePurchasePanel.OpenContext> getPanelOpenContextCallback, Func<IDescriber> getActiveDescriberCallback, int columns, int rows, IReadOnlyList<ValueTuple<ProductReference, int>> products, Action<ProductReference> onSubmit, Action<ProductReference> onSubmitAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(layoutGroup);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementPrefab);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getPanelOpenContextCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getActiveDescriberCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref columns;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rows;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSubmit);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSubmitAll);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_Create_Private_StaticVerticalGridScrollListUILogicalGroupT_3_ValueTuple_2_ProductReference_Int32_UIElementCluster_UIButtonSimple_GridLayoutGroup_GameObject_Func_1_OpenContext_Func_1_IDescriber_Int32_Int32_IReadOnlyList_1_ValueTuple_2_ProductReference_Int32_Action_1_ProductReference_Action_1_ProductReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<ProductReference, int>, UIElementCluster, UIButtonSimple>>(intPtr3) : null;
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00108510 File Offset: 0x00106710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78166, XrefRangeEnd = 78243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x0010854C File Offset: 0x0010674C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78252, RefRangeEnd = 78254, XrefRangeStart = 78243, XrefRangeEnd = 78252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNullIndicator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_UpdateNullIndicator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x00108580 File Offset: 0x00106780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78254, XrefRangeEnd = 78265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x001085BC File Offset: 0x001067BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x001085F8 File Offset: 0x001067F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78287, RefRangeEnd = 78289, XrefRangeStart = 78265, XrefRangeEnd = 78287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x00108634 File Offset: 0x00106834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78305, RefRangeEnd = 78307, XrefRangeStart = 78289, XrefRangeEnd = 78305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikePurchaseItemPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x00108670 File Offset: 0x00106870
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikePurchasePanel.OpenContext _OnPanelInitialize_b__36_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_0_Private_OpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.OpenContext>(intPtr3) : null;
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x001086B0 File Offset: 0x001068B0
		[CallerCount(0)]
		public unsafe IDescriber _OnPanelInitialize_b__36_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_1_Private_IDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDescriber>(intPtr3) : null;
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x001086F0 File Offset: 0x001068F0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikePurchasePanel.OpenContext _OnPanelInitialize_b__36_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_2_Private_OpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.OpenContext>(intPtr3) : null;
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x00108730 File Offset: 0x00106930
		[CallerCount(0)]
		public unsafe IDescriber _OnPanelInitialize_b__36_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_3_Private_IDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDescriber>(intPtr3) : null;
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x00108770 File Offset: 0x00106970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78307, XrefRangeEnd = 78308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_4(ProductReference productReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productReference);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_4_Private_Void_ProductReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x001087B4 File Offset: 0x001069B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78308, XrefRangeEnd = 78309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__36_5(ProductReference productReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productReference);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnPanelInitialize_b__36_5_Private_Void_ProductReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x001087F8 File Offset: 0x001069F8
		[CallerCount(0)]
		public unsafe void _OnSelectAllPressed_b__37_0(bool _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnSelectAllPressed_b__37_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00108838 File Offset: 0x00106A38
		[CallerCount(0)]
		public unsafe int _BuyAll_b__40_2(ValueTuple<ProductReference, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__BuyAll_b__40_2_Private_Int32_ValueTuple_2_ProductReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x0010888C File Offset: 0x00106A8C
		[CallerCount(0)]
		public unsafe int _OnInStoreItemSubmit_b__48_0(ValueTuple<ProductReference, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnInStoreItemSubmit_b__48_0_Private_Int32_ValueTuple_2_ProductReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x001088E0 File Offset: 0x00106AE0
		[CallerCount(0)]
		public unsafe int _OnInStoreItemSubmitAll_b__49_0(ValueTuple<ProductReference, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnInStoreItemSubmitAll_b__49_0_Private_Int32_ValueTuple_2_ProductReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00108934 File Offset: 0x00106B34
		[CallerCount(0)]
		public unsafe int _OnInCartItemSubmit_b__53_0(ValueTuple<ProductReference, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.NativeMethodInfoPtr__OnInCartItemSubmit_b__53_0_Private_Int32_ValueTuple_2_ProductReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x00013482 File Offset: 0x00011682
		public DLC5_RogueLikePurchaseItemPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x00108988 File Offset: 0x00106B88
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x0001348B File Offset: 0x0001168B
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<ProductReference, int>, UIElementCluster, UIButtonSimple> m_InStoreGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<ProductReference, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x001089B8 File Offset: 0x00106BB8
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x000134AA File Offset: 0x000116AA
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<ProductReference, int>, UIElementCluster, UIButtonSimple> m_InCartGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<ProductReference, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x001089E8 File Offset: 0x00106BE8
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x000134C9 File Offset: 0x000116C9
		public unsafe InspectingProductType _InspectingProductType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr__InspectingProductType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr__InspectingProductType_k__BackingField)) = value;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x00108A10 File Offset: 0x00106C10
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x000134E4 File Offset: 0x000116E4
		public unsafe DLC5_RogueLikePurchasePanel.OpenContext _PanelOpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr__PanelOpenContext_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.OpenContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr__PanelOpenContext_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00108A40 File Offset: 0x00106C40
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x00013503 File Offset: 0x00011703
		public unsafe IDescriber m_ActiveDescriber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_ActiveDescriber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_ActiveDescriber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x00108A70 File Offset: 0x00106C70
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x00013522 File Offset: 0x00011722
		public unsafe GridLayoutGroup m_InStoreLayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreLayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x00108AA0 File Offset: 0x00106CA0
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x00013541 File Offset: 0x00011741
		public unsafe GridLayoutGroup m_InCartLayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartLayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartLayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x00108AD0 File Offset: 0x00106CD0
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x00013560 File Offset: 0x00011760
		public unsafe GameObject m_ElementPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_ElementPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_ElementPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x00108B00 File Offset: 0x00106D00
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x0001357F File Offset: 0x0001177F
		public unsafe MonoBehaviour m_DescriberPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_DescriberPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_DescriberPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x00108B30 File Offset: 0x00106D30
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x0001359E File Offset: 0x0001179E
		public unsafe CanvasGroup m_DescriberCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_DescriberCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_DescriberCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x00108B60 File Offset: 0x00106D60
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x000135BD File Offset: 0x000117BD
		public unsafe int m_InStoreColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreColumns);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreColumns)) = value;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x00108B88 File Offset: 0x00106D88
		// (set) Token: 0x06001FEA RID: 8170 RVA: 0x000135D8 File Offset: 0x000117D8
		public unsafe int m_InStoreRows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreRows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreRows)) = value;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x00108BB0 File Offset: 0x00106DB0
		// (set) Token: 0x06001FEC RID: 8172 RVA: 0x000135F3 File Offset: 0x000117F3
		public unsafe int m_InCartColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartColumns);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartColumns)) = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x00108BD8 File Offset: 0x00106DD8
		// (set) Token: 0x06001FEE RID: 8174 RVA: 0x0001360E File Offset: 0x0001180E
		public unsafe int m_InCartRows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartRows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartRows)) = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x00108C00 File Offset: 0x00106E00
		// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x00013629 File Offset: 0x00011829
		public unsafe TextMeshProUGUI m_InStorageNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStorageNum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStorageNum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x00108C30 File Offset: 0x00106E30
		// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x00013648 File Offset: 0x00011848
		public unsafe TextMeshProUGUI m_PriceNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_PriceNum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_PriceNum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x00108C60 File Offset: 0x00106E60
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x00013667 File Offset: 0x00011867
		public unsafe TextMeshProUGUI m_PriceSymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_PriceSymbol);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_PriceSymbol), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x00108C90 File Offset: 0x00106E90
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x00013686 File Offset: 0x00011886
		public unsafe TextMeshProUGUI m_HasOwned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_HasOwned);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_HasOwned), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x00108CC0 File Offset: 0x00106EC0
		// (set) Token: 0x06001FF8 RID: 8184 RVA: 0x000136A5 File Offset: 0x000118A5
		public unsafe ActionExecutionScheduler m_ActionExecutionScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x00108CF0 File Offset: 0x00106EF0
		// (set) Token: 0x06001FFA RID: 8186 RVA: 0x000136C4 File Offset: 0x000118C4
		public unsafe List<ValueTuple<ProductReference, int>> m_InStoreProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<ProductReference, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InStoreProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x00108D20 File Offset: 0x00106F20
		// (set) Token: 0x06001FFC RID: 8188 RVA: 0x000136E3 File Offset: 0x000118E3
		public unsafe List<ValueTuple<ProductReference, int>> m_InCartProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<ProductReference, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_InCartProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x00108D50 File Offset: 0x00106F50
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x00013702 File Offset: 0x00011902
		public unsafe int m_CalculatedPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_CalculatedPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_CalculatedPrice)) = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x00108D78 File Offset: 0x00106F78
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x0001371D File Offset: 0x0001191D
		public unsafe float m_ShouldRunBuyAllFunctionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_ShouldRunBuyAllFunctionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_ShouldRunBuyAllFunctionOffset)) = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x00108DA0 File Offset: 0x00106FA0
		// (set) Token: 0x06002002 RID: 8194 RVA: 0x00013738 File Offset: 0x00011938
		public unsafe CancellationTokenSource m_Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_Source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x00108DD0 File Offset: 0x00106FD0
		// (set) Token: 0x06002004 RID: 8196 RVA: 0x00013757 File Offset: 0x00011957
		public unsafe Action m_SelectAllCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_SelectAllCall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.NativeFieldInfoPtr_m_SelectAllCall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeFieldInfoPtr_m_InStoreGroup;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeFieldInfoPtr_m_InCartGroup;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeFieldInfoPtr__InspectingProductType_k__BackingField;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeFieldInfoPtr__PanelOpenContext_k__BackingField;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveDescriber;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeFieldInfoPtr_m_InStoreLayoutGroup;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeFieldInfoPtr_m_InCartLayoutGroup;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementPrefab;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberPrefab;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberCanvasGroup;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeFieldInfoPtr_m_InStoreColumns;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeFieldInfoPtr_m_InStoreRows;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeFieldInfoPtr_m_InCartColumns;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeFieldInfoPtr_m_InCartRows;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeFieldInfoPtr_m_InStorageNum;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeFieldInfoPtr_m_PriceNum;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeFieldInfoPtr_m_PriceSymbol;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeFieldInfoPtr_m_HasOwned;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionExecutionScheduler;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeFieldInfoPtr_m_InStoreProducts;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeFieldInfoPtr_m_InCartProducts;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeFieldInfoPtr_m_CalculatedPrice;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldRunBuyAllFunctionOffset;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeFieldInfoPtr_m_Source;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectAllCall;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeMethodInfoPtr_get_InspectingProductType_Public_get_InspectingProductType_0;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeMethodInfoPtr_set_InspectingProductType_Public_set_Void_InspectingProductType_0;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeMethodInfoPtr_get_PanelOpenContext_Public_get_OpenContext_0;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeMethodInfoPtr_set_PanelOpenContext_Public_set_Void_OpenContext_0;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeMethodInfoPtr_get_CalculatedPrice_Protected_get_Int32_0;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeMethodInfoPtr_set_CalculatedPrice_Private_set_Void_Int32_0;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectAllPressed_Private_Void_CallbackContext_0;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectAllReleased_Private_Void_CallbackContext_0;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr_SelectAll_Private_Void_0;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeMethodInfoPtr_BuyAll_Private_Void_CallbackContext_0;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeMethodInfoPtr_GetProductPriceAfterDiscount_Protected_Virtual_New_Int32_Product_0;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_Buy_Private_Void_0;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalFund_Protected_Virtual_New_Int32_Int32_0;

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeMethodInfoPtr_AfterPanelOpen_Protected_Virtual_New_Void_0;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeMethodInfoPtr_AfterBuy_Protected_Virtual_New_Void_0;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeMethodInfoPtr_AfterAddToCart_Protected_Virtual_New_Void_0;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeMethodInfoPtr_AfterRemoveFromCart_Protected_Virtual_New_Void_0;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeMethodInfoPtr_OnInStoreItemSubmit_Private_Void_ProductReference_0;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeMethodInfoPtr_OnInStoreItemSubmitAll_Private_Void_ProductReference_0;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBuyButtonInteractable_Protected_Virtual_New_Void_0;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckCouldNotBuy_Private_get_Boolean_0;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeMethodInfoPtr_OnInCartItemSubmit_Private_Void_ProductReference_Boolean_0;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeMethodInfoPtr_MoveSelectedCore_Private_Static_Void_ProductReference_IStaticGridScrollListUILogicalGroup_List_1_ValueTuple_2_ProductReference_Int32_IStaticGridScrollListUILogicalGroup_List_1_ValueTuple_2_ProductReference_Int32_Boolean_0;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Static_Void_IList_1_ValueTuple_2_ProductReference_Int32_List_1_ValueTuple_2_ProductReference_Int32_Boolean_Int32_0;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_StaticVerticalGridScrollListUILogicalGroupT_3_ValueTuple_2_ProductReference_Int32_UIElementCluster_UIButtonSimple_GridLayoutGroup_GameObject_Func_1_OpenContext_Func_1_IDescriber_Int32_Int32_IReadOnlyList_1_ValueTuple_2_ProductReference_Int32_Action_1_ProductReference_Action_1_ProductReference_0;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNullIndicator_Private_Void_0;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_0_Private_OpenContext_0;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_1_Private_IDescriber_0;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_2_Private_OpenContext_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_3_Private_IDescriber_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_4_Private_Void_ProductReference_0;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__36_5_Private_Void_ProductReference_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr__OnSelectAllPressed_b__37_0_Private_Void_Boolean_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr__BuyAll_b__40_2_Private_Int32_ValueTuple_2_ProductReference_Int32_0;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr__OnInStoreItemSubmit_b__48_0_Private_Int32_ValueTuple_2_ProductReference_Int32_0;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr__OnInStoreItemSubmitAll_b__49_0_Private_Int32_ValueTuple_2_ProductReference_Int32_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr__OnInCartItemSubmit_b__53_0_Private_Int32_ValueTuple_2_ProductReference_Int32_0;

		// Token: 0x02000704 RID: 1796
		public class IRogueLikePurchaseDataSource : Il2CppObjectBase
		{
			// Token: 0x06009C0E RID: 39950 RVA: 0x002967F0 File Offset: 0x002949F0
			// Note: this type is marked as 'beforefieldinit'.
			static IRogueLikePurchaseDataSource()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "IRogueLikePurchaseDataSource");
				DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource.NativeMethodInfoPtr_get_Fund_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource>.NativeClassPtr, 100668893);
				DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource.NativeMethodInfoPtr_set_Fund_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource>.NativeClassPtr, 100668894);
				DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource.NativeMethodInfoPtr_get_AllProducts_Public_Abstract_Virtual_New_get_IList_1_ProductReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource>.NativeClassPtr, 100668895);
				DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource.NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_Abstract_Virtual_New_get_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource>.NativeClassPtr, 100668896);
			}

			// Token: 0x170033BF RID: 13247
			// (get) Token: 0x06009C0F RID: 39951 RVA: 0x00296864 File Offset: 0x00294A64
			// (set) Token: 0x06009C10 RID: 39952 RVA: 0x002968AC File Offset: 0x00294AAC
			public unsafe virtual int Fund
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource.NativeMethodInfoPtr_get_Fund_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource.NativeMethodInfoPtr_set_Fund_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170033C0 RID: 13248
			// (get) Token: 0x06009C11 RID: 39953 RVA: 0x002968F8 File Offset: 0x00294AF8
			public unsafe virtual IList<ProductReference> AllProducts
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource.NativeMethodInfoPtr_get_AllProducts_Public_Abstract_Virtual_New_get_IList_1_ProductReference_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ProductReference>>(intPtr3) : null;
				}
			}

			// Token: 0x170033C1 RID: 13249
			// (get) Token: 0x06009C12 RID: 39954 RVA: 0x00296944 File Offset: 0x00294B44
			public unsafe virtual RogueLikeRunTimeData RogueLikeRunTimeData
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource.NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_Abstract_Virtual_New_get_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr3) : null;
				}
			}

			// Token: 0x06009C13 RID: 39955 RVA: 0x00054661 File Offset: 0x00052861
			public IRogueLikePurchaseDataSource(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400656D RID: 25965
			private static readonly IntPtr NativeMethodInfoPtr_get_Fund_Public_Abstract_Virtual_New_get_Int32_0;

			// Token: 0x0400656E RID: 25966
			private static readonly IntPtr NativeMethodInfoPtr_set_Fund_Public_Abstract_Virtual_New_set_Void_Int32_0;

			// Token: 0x0400656F RID: 25967
			private static readonly IntPtr NativeMethodInfoPtr_get_AllProducts_Public_Abstract_Virtual_New_get_IList_1_ProductReference_0;

			// Token: 0x04006570 RID: 25968
			private static readonly IntPtr NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_Abstract_Virtual_New_get_RogueLikeRunTimeData_0;
		}

		// Token: 0x02000705 RID: 1797
		public class ProductReferenceCountPairEqualityComparer : Il2CppSystem.Object
		{
			// Token: 0x06009C14 RID: 39956 RVA: 0x00296990 File Offset: 0x00294B90
			// Note: this type is marked as 'beforefieldinit'.
			static ProductReferenceCountPairEqualityComparer()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.ProductReferenceCountPairEqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "ProductReferenceCountPairEqualityComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.ProductReferenceCountPairEqualityComparer>.NativeClassPtr);
				DLC5_RogueLikePurchaseItemPanel.ProductReferenceCountPairEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_2_ProductReference_Int32_ValueTuple_2_ProductReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.ProductReferenceCountPairEqualityComparer>.NativeClassPtr, 100668897);
				DLC5_RogueLikePurchaseItemPanel.ProductReferenceCountPairEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ValueTuple_2_ProductReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.ProductReferenceCountPairEqualityComparer>.NativeClassPtr, 100668898);
				DLC5_RogueLikePurchaseItemPanel.ProductReferenceCountPairEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.ProductReferenceCountPairEqualityComparer>.NativeClassPtr, 100668899);
			}

			// Token: 0x06009C15 RID: 39957 RVA: 0x002969F8 File Offset: 0x00294BF8
			[CallerCount(0)]
			public unsafe virtual bool Equals(ValueTuple<ProductReference, int> x, ValueTuple<ProductReference, int> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.ProductReferenceCountPairEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_2_ProductReference_Int32_ValueTuple_2_ProductReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C16 RID: 39958 RVA: 0x00296A64 File Offset: 0x00294C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77589, XrefRangeEnd = 77590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int GetHashCode(ValueTuple<ProductReference, int> obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.ProductReferenceCountPairEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ValueTuple_2_ProductReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C17 RID: 39959 RVA: 0x00296AB8 File Offset: 0x00294CB8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProductReferenceCountPairEqualityComparer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.ProductReferenceCountPairEqualityComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.ProductReferenceCountPairEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C18 RID: 39960 RVA: 0x0005466A File Offset: 0x0005286A
			public ProductReferenceCountPairEqualityComparer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04006571 RID: 25969
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_2_ProductReference_Int32_ValueTuple_2_ProductReference_Int32_0;

			// Token: 0x04006572 RID: 25970
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ValueTuple_2_ProductReference_Int32_0;

			// Token: 0x04006573 RID: 25971
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000706 RID: 1798
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchaseItemPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009C19 RID: 39961 RVA: 0x00296AF4 File Offset: 0x00294CF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c>.NativeClassPtr);
				DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c>.NativeClassPtr, "<>9__40_0");
				DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9__40_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c>.NativeClassPtr, "<>9__40_1");
				DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9__42_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c>.NativeClassPtr, "<>9__42_1");
				DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9__42_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c>.NativeClassPtr, "<>9__42_2");
				DLC5_RogueLikePurchaseItemPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c>.NativeClassPtr, 100668901);
				DLC5_RogueLikePurchaseItemPanel.__c.NativeMethodInfoPtr__BuyAll_b__40_0_Internal_Boolean_ValueTuple_2_ProductReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c>.NativeClassPtr, 100668902);
				DLC5_RogueLikePurchaseItemPanel.__c.NativeMethodInfoPtr__BuyAll_b__40_1_Internal_Boolean_ValueTuple_2_ProductReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c>.NativeClassPtr, 100668903);
				DLC5_RogueLikePurchaseItemPanel.__c.NativeMethodInfoPtr__Buy_b__42_1_Internal_ValueTuple_2_ProductReference_Int32_ProductReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c>.NativeClassPtr, 100668904);
				DLC5_RogueLikePurchaseItemPanel.__c.NativeMethodInfoPtr__Buy_b__42_2_Internal_Boolean_ProductReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c>.NativeClassPtr, 100668905);
			}

			// Token: 0x06009C1A RID: 39962 RVA: 0x00296BE8 File Offset: 0x00294DE8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C1B RID: 39963 RVA: 0x00296C24 File Offset: 0x00294E24
			[CallerCount(0)]
			public unsafe bool _BuyAll_b__40_0(ValueTuple<ProductReference, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c.NativeMethodInfoPtr__BuyAll_b__40_0_Internal_Boolean_ValueTuple_2_ProductReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C1C RID: 39964 RVA: 0x00296C78 File Offset: 0x00294E78
			[CallerCount(0)]
			public unsafe bool _BuyAll_b__40_1(ValueTuple<ProductReference, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c.NativeMethodInfoPtr__BuyAll_b__40_1_Internal_Boolean_ValueTuple_2_ProductReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C1D RID: 39965 RVA: 0x00296CCC File Offset: 0x00294ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77590, XrefRangeEnd = 77593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<ProductReference, int> _Buy_b__42_1(ProductReference x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c.NativeMethodInfoPtr__Buy_b__42_1_Internal_ValueTuple_2_ProductReference_Int32_ProductReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<ProductReference, int>(pointer);
			}

			// Token: 0x06009C1E RID: 39966 RVA: 0x00296D14 File Offset: 0x00294F14
			[CallerCount(0)]
			public unsafe bool _Buy_b__42_2(ProductReference x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c.NativeMethodInfoPtr__Buy_b__42_2_Internal_Boolean_ProductReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C1F RID: 39967 RVA: 0x00054673 File Offset: 0x00052873
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033C2 RID: 13250
			// (get) Token: 0x06009C20 RID: 39968 RVA: 0x00296D64 File Offset: 0x00294F64
			// (set) Token: 0x06009C21 RID: 39969 RVA: 0x0005467C File Offset: 0x0005287C
			public unsafe static DLC5_RogueLikePurchaseItemPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseItemPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033C3 RID: 13251
			// (get) Token: 0x06009C22 RID: 39970 RVA: 0x00296D8C File Offset: 0x00294F8C
			// (set) Token: 0x06009C23 RID: 39971 RVA: 0x0005468E File Offset: 0x0005288E
			public unsafe static Func<ValueTuple<ProductReference, int>, bool> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<ProductReference, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033C4 RID: 13252
			// (get) Token: 0x06009C24 RID: 39972 RVA: 0x00296DB4 File Offset: 0x00294FB4
			// (set) Token: 0x06009C25 RID: 39973 RVA: 0x000546A0 File Offset: 0x000528A0
			public unsafe static Func<ValueTuple<ProductReference, int>, bool> __9__40_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9__40_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<ProductReference, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9__40_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033C5 RID: 13253
			// (get) Token: 0x06009C26 RID: 39974 RVA: 0x00296DDC File Offset: 0x00294FDC
			// (set) Token: 0x06009C27 RID: 39975 RVA: 0x000546B2 File Offset: 0x000528B2
			public unsafe static Func<ProductReference, ValueTuple<ProductReference, int>> __9__42_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9__42_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductReference, ValueTuple<ProductReference, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9__42_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033C6 RID: 13254
			// (get) Token: 0x06009C28 RID: 39976 RVA: 0x00296E04 File Offset: 0x00295004
			// (set) Token: 0x06009C29 RID: 39977 RVA: 0x000546C4 File Offset: 0x000528C4
			public unsafe static Func<ProductReference, bool> __9__42_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9__42_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductReference, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchaseItemPanel.__c.NativeFieldInfoPtr___9__42_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006574 RID: 25972
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006575 RID: 25973
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x04006576 RID: 25974
			private static readonly IntPtr NativeFieldInfoPtr___9__40_1;

			// Token: 0x04006577 RID: 25975
			private static readonly IntPtr NativeFieldInfoPtr___9__42_1;

			// Token: 0x04006578 RID: 25976
			private static readonly IntPtr NativeFieldInfoPtr___9__42_2;

			// Token: 0x04006579 RID: 25977
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400657A RID: 25978
			private static readonly IntPtr NativeMethodInfoPtr__BuyAll_b__40_0_Internal_Boolean_ValueTuple_2_ProductReference_Int32_0;

			// Token: 0x0400657B RID: 25979
			private static readonly IntPtr NativeMethodInfoPtr__BuyAll_b__40_1_Internal_Boolean_ValueTuple_2_ProductReference_Int32_0;

			// Token: 0x0400657C RID: 25980
			private static readonly IntPtr NativeMethodInfoPtr__Buy_b__42_1_Internal_ValueTuple_2_ProductReference_Int32_ProductReference_0;

			// Token: 0x0400657D RID: 25981
			private static readonly IntPtr NativeMethodInfoPtr__Buy_b__42_2_Internal_Boolean_ProductReference_0;
		}

		// Token: 0x02000707 RID: 1799
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchaseItemPanel+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
		{
			// Token: 0x06009C2A RID: 39978 RVA: 0x00296E2C File Offset: 0x0029502C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass42_0>.NativeClassPtr);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass42_0.NativeFieldInfoPtr_panelOpenContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass42_0>.NativeClassPtr, "panelOpenContext");
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass42_0>.NativeClassPtr, 100668906);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass42_0.NativeMethodInfoPtr__Buy_b__0_Internal_ValueTuple_2_ITextProvider_1_LanguageBase_Int32_ValueTuple_2_ProductReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass42_0>.NativeClassPtr, 100668907);
			}

			// Token: 0x06009C2B RID: 39979 RVA: 0x00296E94 File Offset: 0x00295094
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C2C RID: 39980 RVA: 0x00296ED0 File Offset: 0x002950D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77593, XrefRangeEnd = 77596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<ITextProvider<LanguageBase>, int> _Buy_b__0(ValueTuple<ProductReference, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass42_0.NativeMethodInfoPtr__Buy_b__0_Internal_ValueTuple_2_ITextProvider_1_LanguageBase_Int32_ValueTuple_2_ProductReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<ITextProvider<LanguageBase>, int>(pointer);
			}

			// Token: 0x06009C2D RID: 39981 RVA: 0x000546D6 File Offset: 0x000528D6
			public __c__DisplayClass42_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033C7 RID: 13255
			// (get) Token: 0x06009C2E RID: 39982 RVA: 0x00296F20 File Offset: 0x00295120
			// (set) Token: 0x06009C2F RID: 39983 RVA: 0x000546DF File Offset: 0x000528DF
			public unsafe DLC5_RogueLikePurchasePanel.OpenContext panelOpenContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass42_0.NativeFieldInfoPtr_panelOpenContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.OpenContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass42_0.NativeFieldInfoPtr_panelOpenContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400657E RID: 25982
			private static readonly IntPtr NativeFieldInfoPtr_panelOpenContext;

			// Token: 0x0400657F RID: 25983
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006580 RID: 25984
			private static readonly IntPtr NativeMethodInfoPtr__Buy_b__0_Internal_ValueTuple_2_ITextProvider_1_LanguageBase_Int32_ValueTuple_2_ProductReference_Int32_0;
		}

		// Token: 0x02000708 RID: 1800
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchaseItemPanel+<>c__DisplayClass54_0")]
		public sealed class __c__DisplayClass54_0 : Il2CppSystem.Object
		{
			// Token: 0x06009C30 RID: 39984 RVA: 0x00296F50 File Offset: 0x00295150
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass54_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "<>c__DisplayClass54_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass54_0>.NativeClassPtr);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass54_0.NativeFieldInfoPtr_productReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass54_0>.NativeClassPtr, "productReference");
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass54_0>.NativeClassPtr, 100668908);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass54_0.NativeMethodInfoPtr__MoveSelectedCore_b__0_Internal_Boolean_ValueTuple_2_ProductReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass54_0>.NativeClassPtr, 100668909);
			}

			// Token: 0x06009C31 RID: 39985 RVA: 0x00296FB8 File Offset: 0x002951B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass54_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C32 RID: 39986 RVA: 0x00296FF4 File Offset: 0x002951F4
			[CallerCount(0)]
			public unsafe bool _MoveSelectedCore_b__0(ValueTuple<ProductReference, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass54_0.NativeMethodInfoPtr__MoveSelectedCore_b__0_Internal_Boolean_ValueTuple_2_ProductReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C33 RID: 39987 RVA: 0x000546FE File Offset: 0x000528FE
			public __c__DisplayClass54_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033C8 RID: 13256
			// (get) Token: 0x06009C34 RID: 39988 RVA: 0x00297048 File Offset: 0x00295248
			// (set) Token: 0x06009C35 RID: 39989 RVA: 0x00054707 File Offset: 0x00052907
			public unsafe ProductReference productReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass54_0.NativeFieldInfoPtr_productReference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass54_0.NativeFieldInfoPtr_productReference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006581 RID: 25985
			private static readonly IntPtr NativeFieldInfoPtr_productReference;

			// Token: 0x04006582 RID: 25986
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006583 RID: 25987
			private static readonly IntPtr NativeMethodInfoPtr__MoveSelectedCore_b__0_Internal_Boolean_ValueTuple_2_ProductReference_Int32_0;
		}

		// Token: 0x02000709 RID: 1801
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchaseItemPanel+<>c__DisplayClass55_0")]
		public sealed class __c__DisplayClass55_0 : Il2CppSystem.Object
		{
			// Token: 0x06009C36 RID: 39990 RVA: 0x00297078 File Offset: 0x00295278
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "<>c__DisplayClass55_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass55_0>.NativeClassPtr);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass55_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass55_0>.NativeClassPtr, "product");
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass55_0>.NativeClassPtr, 100668910);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass55_0.NativeMethodInfoPtr__Move_b__0_Internal_Boolean_ValueTuple_2_ProductReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass55_0>.NativeClassPtr, 100668911);
			}

			// Token: 0x06009C37 RID: 39991 RVA: 0x002970E0 File Offset: 0x002952E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass55_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C38 RID: 39992 RVA: 0x0029711C File Offset: 0x0029531C
			[CallerCount(0)]
			public unsafe bool _Move_b__0(ValueTuple<ProductReference, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass55_0.NativeMethodInfoPtr__Move_b__0_Internal_Boolean_ValueTuple_2_ProductReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C39 RID: 39993 RVA: 0x00054726 File Offset: 0x00052926
			public __c__DisplayClass55_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033C9 RID: 13257
			// (get) Token: 0x06009C3A RID: 39994 RVA: 0x00297170 File Offset: 0x00295370
			// (set) Token: 0x06009C3B RID: 39995 RVA: 0x0005472F File Offset: 0x0005292F
			public unsafe ProductReference product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass55_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass55_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006584 RID: 25988
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04006585 RID: 25989
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006586 RID: 25990
			private static readonly IntPtr NativeMethodInfoPtr__Move_b__0_Internal_Boolean_ValueTuple_2_ProductReference_Int32_0;
		}

		// Token: 0x0200070A RID: 1802
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchaseItemPanel+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
		{
			// Token: 0x06009C3C RID: 39996 RVA: 0x002971A0 File Offset: 0x002953A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0>.NativeClassPtr);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr_getPanelOpenContextCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0>.NativeClassPtr, "getPanelOpenContextCallback");
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr_getActiveDescriberCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0>.NativeClassPtr, "getActiveDescriberCallback");
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr_onSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0>.NativeClassPtr, "onSubmit");
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr_onSubmitAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0>.NativeClassPtr, "onSubmitAll");
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0>.NativeClassPtr, 100668912);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeMethodInfoPtr_Method_Internal_Void_ValueTuple_2_ProductReference_Int32_UIElementCluster_UIButtonSimple_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0>.NativeClassPtr, 100668913);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeMethodInfoPtr__Create_b__4_Internal_Void_ValueTuple_2_ProductReference_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0>.NativeClassPtr, 100668914);
			}

			// Token: 0x06009C3D RID: 39997 RVA: 0x0029726C File Offset: 0x0029546C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C3E RID: 39998 RVA: 0x002972A8 File Offset: 0x002954A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77596, XrefRangeEnd = 77648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_ValueTuple_2_ProductReference_Int32_UIElementCluster_UIButtonSimple_PDM_0(ValueTuple<ProductReference, int> productInfo, UIElementCluster _, UIButtonSimple uiButton)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(productInfo));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButton);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeMethodInfoPtr_Method_Internal_Void_ValueTuple_2_ProductReference_Int32_UIElementCluster_UIButtonSimple_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C3F RID: 39999 RVA: 0x00297314 File Offset: 0x00295514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77648, XrefRangeEnd = 77654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Create_b__4(ValueTuple<ProductReference, int> productInfo, UIElementCluster cluster, UIButtonSimple _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(productInfo));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeMethodInfoPtr__Create_b__4_Internal_Void_ValueTuple_2_ProductReference_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C40 RID: 40000 RVA: 0x0005474E File Offset: 0x0005294E
			public __c__DisplayClass56_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033CA RID: 13258
			// (get) Token: 0x06009C41 RID: 40001 RVA: 0x00297380 File Offset: 0x00295580
			// (set) Token: 0x06009C42 RID: 40002 RVA: 0x00054757 File Offset: 0x00052957
			public unsafe Func<DLC5_RogueLikePurchasePanel.OpenContext> getPanelOpenContextCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr_getPanelOpenContextCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikePurchasePanel.OpenContext>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr_getPanelOpenContextCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033CB RID: 13259
			// (get) Token: 0x06009C43 RID: 40003 RVA: 0x002973B0 File Offset: 0x002955B0
			// (set) Token: 0x06009C44 RID: 40004 RVA: 0x00054776 File Offset: 0x00052976
			public unsafe DLC5_RogueLikePurchaseItemPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseItemPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033CC RID: 13260
			// (get) Token: 0x06009C45 RID: 40005 RVA: 0x002973E0 File Offset: 0x002955E0
			// (set) Token: 0x06009C46 RID: 40006 RVA: 0x00054795 File Offset: 0x00052995
			public unsafe Func<IDescriber> getActiveDescriberCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr_getActiveDescriberCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IDescriber>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr_getActiveDescriberCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033CD RID: 13261
			// (get) Token: 0x06009C47 RID: 40007 RVA: 0x00297410 File Offset: 0x00295610
			// (set) Token: 0x06009C48 RID: 40008 RVA: 0x000547B4 File Offset: 0x000529B4
			public unsafe Action<ProductReference> onSubmit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr_onSubmit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductReference>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr_onSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033CE RID: 13262
			// (get) Token: 0x06009C49 RID: 40009 RVA: 0x00297440 File Offset: 0x00295640
			// (set) Token: 0x06009C4A RID: 40010 RVA: 0x000547D3 File Offset: 0x000529D3
			public unsafe Action<ProductReference> onSubmitAll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr_onSubmitAll);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductReference>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0.NativeFieldInfoPtr_onSubmitAll), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006587 RID: 25991
			private static readonly IntPtr NativeFieldInfoPtr_getPanelOpenContextCallback;

			// Token: 0x04006588 RID: 25992
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006589 RID: 25993
			private static readonly IntPtr NativeFieldInfoPtr_getActiveDescriberCallback;

			// Token: 0x0400658A RID: 25994
			private static readonly IntPtr NativeFieldInfoPtr_onSubmit;

			// Token: 0x0400658B RID: 25995
			private static readonly IntPtr NativeFieldInfoPtr_onSubmitAll;

			// Token: 0x0400658C RID: 25996
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400658D RID: 25997
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_ValueTuple_2_ProductReference_Int32_UIElementCluster_UIButtonSimple_PDM_0;

			// Token: 0x0400658E RID: 25998
			private static readonly IntPtr NativeMethodInfoPtr__Create_b__4_Internal_Void_ValueTuple_2_ProductReference_Int32_UIElementCluster_UIButtonSimple_0;
		}

		// Token: 0x0200070B RID: 1803
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchaseItemPanel+<>c__DisplayClass56_1")]
		public sealed class __c__DisplayClass56_1 : Il2CppSystem.Object
		{
			// Token: 0x06009C4B RID: 40011 RVA: 0x00297470 File Offset: 0x00295670
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "<>c__DisplayClass56_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1>.NativeClassPtr);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeFieldInfoPtr_panelOpenContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1>.NativeClassPtr, "panelOpenContext");
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1>.NativeClassPtr, "product");
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeFieldInfoPtr_field_Public___c__DisplayClass56_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1>.NativeClassPtr, 100668915);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeMethodInfoPtr__Create_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1>.NativeClassPtr, 100668916);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeMethodInfoPtr__Create_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1>.NativeClassPtr, 100668917);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeMethodInfoPtr__Create_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1>.NativeClassPtr, 100668918);
			}

			// Token: 0x06009C4C RID: 40012 RVA: 0x00297528 File Offset: 0x00295728
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C4D RID: 40013 RVA: 0x00297564 File Offset: 0x00295764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77654, XrefRangeEnd = 77655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Create_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeMethodInfoPtr__Create_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C4E RID: 40014 RVA: 0x00297598 File Offset: 0x00295798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77655, XrefRangeEnd = 77656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Create_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeMethodInfoPtr__Create_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C4F RID: 40015 RVA: 0x002975CC File Offset: 0x002957CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77656, XrefRangeEnd = 77657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Create_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeMethodInfoPtr__Create_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C50 RID: 40016 RVA: 0x000547F2 File Offset: 0x000529F2
			public __c__DisplayClass56_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033CF RID: 13263
			// (get) Token: 0x06009C51 RID: 40017 RVA: 0x00297600 File Offset: 0x00295800
			// (set) Token: 0x06009C52 RID: 40018 RVA: 0x000547FB File Offset: 0x000529FB
			public unsafe DLC5_RogueLikePurchasePanel.OpenContext panelOpenContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeFieldInfoPtr_panelOpenContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.OpenContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeFieldInfoPtr_panelOpenContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033D0 RID: 13264
			// (get) Token: 0x06009C53 RID: 40019 RVA: 0x00297630 File Offset: 0x00295830
			// (set) Token: 0x06009C54 RID: 40020 RVA: 0x0005481A File Offset: 0x00052A1A
			public unsafe ProductReference product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033D1 RID: 13265
			// (get) Token: 0x06009C55 RID: 40021 RVA: 0x00297660 File Offset: 0x00295860
			// (set) Token: 0x06009C56 RID: 40022 RVA: 0x00054839 File Offset: 0x00052A39
			public unsafe DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0 field_Public___c__DisplayClass56_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeFieldInfoPtr_field_Public___c__DisplayClass56_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass56_1.NativeFieldInfoPtr_field_Public___c__DisplayClass56_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400658F RID: 25999
			private static readonly IntPtr NativeFieldInfoPtr_panelOpenContext;

			// Token: 0x04006590 RID: 26000
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04006591 RID: 26001
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass56_0_0;

			// Token: 0x04006592 RID: 26002
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006593 RID: 26003
			private static readonly IntPtr NativeMethodInfoPtr__Create_b__1_Internal_Void_0;

			// Token: 0x04006594 RID: 26004
			private static readonly IntPtr NativeMethodInfoPtr__Create_b__2_Internal_Void_0;

			// Token: 0x04006595 RID: 26005
			private static readonly IntPtr NativeMethodInfoPtr__Create_b__3_Internal_Void_0;
		}

		// Token: 0x0200070C RID: 1804
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchaseItemPanel+<>c__DisplayClass58_0")]
		public sealed class __c__DisplayClass58_0 : Il2CppSystem.Object
		{
			// Token: 0x06009C57 RID: 40023 RVA: 0x00297690 File Offset: 0x00295890
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel>.NativeClassPtr, "<>c__DisplayClass58_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0>.NativeClassPtr);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0.NativeFieldInfoPtr_panelOpenContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0>.NativeClassPtr, "panelOpenContext");
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0>.NativeClassPtr, 100668919);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Boolean_ProductReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0>.NativeClassPtr, 100668920);
				DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_ValueTuple_2_ProductReference_Int32_ProductReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0>.NativeClassPtr, 100668921);
			}

			// Token: 0x06009C58 RID: 40024 RVA: 0x0029770C File Offset: 0x0029590C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C59 RID: 40025 RVA: 0x00297748 File Offset: 0x00295948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77657, XrefRangeEnd = 77661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__0(ProductReference product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Boolean_ProductReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C5A RID: 40026 RVA: 0x00297798 File Offset: 0x00295998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77661, XrefRangeEnd = 77664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<ProductReference, int> _OnPanelOpen_b__1(ProductReference x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_ValueTuple_2_ProductReference_Int32_ProductReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<ProductReference, int>(pointer);
			}

			// Token: 0x06009C5B RID: 40027 RVA: 0x00054858 File Offset: 0x00052A58
			public __c__DisplayClass58_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033D2 RID: 13266
			// (get) Token: 0x06009C5C RID: 40028 RVA: 0x002977E0 File Offset: 0x002959E0
			// (set) Token: 0x06009C5D RID: 40029 RVA: 0x00054861 File Offset: 0x00052A61
			public unsafe DLC5_RogueLikePurchasePanel.OpenContext panelOpenContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0.NativeFieldInfoPtr_panelOpenContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.OpenContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchaseItemPanel.__c__DisplayClass58_0.NativeFieldInfoPtr_panelOpenContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006596 RID: 26006
			private static readonly IntPtr NativeFieldInfoPtr_panelOpenContext;

			// Token: 0x04006597 RID: 26007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006598 RID: 26008
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Boolean_ProductReference_0;

			// Token: 0x04006599 RID: 26009
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_ValueTuple_2_ProductReference_Int32_ProductReference_0;
		}
	}
}
