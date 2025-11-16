using System;
using Common.UI;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData;
using GameData.Core;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020000C5 RID: 197
	public class DaySceneKourindoShopPannel : UIPanel
	{
		// Token: 0x06001657 RID: 5719 RVA: 0x000E9718 File Offset: 0x000E7918
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneKourindoShopPannel()
		{
			Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneKourindoShopPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr);
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_NORMAL_PRODUCTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "NORMAL_PRODUCTS");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_COOKER_PRODUCTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "COOKER_PRODUCTS");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_OTHER_PRODUCTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "OTHER_PRODUCTS");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_COUPONS_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "COUPONS_ID");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_QIZHE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "QIZHE");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_customSpacingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "customSpacingRect");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_describerSwitcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "describerSwitcher");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_rinnosukeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "rinnosukeImage");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_talkingDialoge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "talkingDialoge");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_diffImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "diffImages");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_sellDialogeTXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "sellDialogeTXT");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_soldOutDialogeTXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "soldOutDialogeTXT");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_allSoldOutDialogeTXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "allSoldOutDialogeTXT");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_soldOutFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "soldOutFace");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_OnBuyAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "OnBuyAudio");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_shelfObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "shelfObject");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_cartObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "cartObject");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_shelfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "shelfField");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_cartField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "cartField");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_Tab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "Tab");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_TabBtns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "TabBtns");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "describer");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_describePannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "describePannel");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "price");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "left");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "amount");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "title");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_amountCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "amountCanvas");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "confirmButton");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_currencyPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "currencyPannel");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_describeCurrencyCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "describeCurrencyCanvasGroup");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_currencyElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "currencyElement");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_scrollerLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "scrollerLeft");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_scrollerRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "scrollerRight");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_sufficientColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "sufficientColor");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_inSufficientColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "inSufficientColor");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_allCartPanelCurrencyInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "allCartPanelCurrencyInstances");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_allCartProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "allCartProductList");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_allKourindouProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "allKourindouProducts");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_allShelfPanelCurrencyInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "allShelfPanelCurrencyInstances");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_allShelfProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "allShelfProductList");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_currencyDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "currencyDic");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "_comparer");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_buyAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "buyAll");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_describerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "describerCanvasGroup");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_dialogeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "dialogeText");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_soldOutText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "soldOutText");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_allSoldOutText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "allSoldOutText");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_Affordable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "m_Affordable");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_CartGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "m_CartGroup");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_SelectAllCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "m_SelectAllCoroutine");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_ShelfGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "m_ShelfGroup");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_ShouldRunBuyAllFucntionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "m_ShouldRunBuyAllFucntionOffset");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_selectAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "selectAll");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr_tabType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "tabType");
			DaySceneKourindoShopPannel.NativeFieldInfoPtr__MerchantData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<MerchantData>k__BackingField");
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_get_MerchantData_Private_get_TrackedMerchant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667319);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_set_MerchantData_Public_set_Void_TrackedMerchant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667320);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_get_DailyKourindouProducts_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667321);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_get_StaticCookerKourindouProducts_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667322);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_get_StaticOtherKourindouProducts_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667323);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_get_DailyKourindouProductsInCart_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667324);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_get_StaticKourindouProductsInCart_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667325);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667326);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnSelectAllPressed_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667327);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnSelectAllReleased_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667328);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_SelectAllCoroutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667329);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnSelectAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667330);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnBuyAll_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667331);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_TabSwitchHandler_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667332);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_GoToSpecific_Private_Void_KourindouMerchandiseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667333);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_UpdateShelfElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667334);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_UpdateCartElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667335);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_GoToPrevious_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667336);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_GoToNext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667337);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667338);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_ResetSelection_Private_Void_ReselectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667339);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnShelfElementEnabled_Private_Void_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667340);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnShelfElementSelected_Private_Void_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667341);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnCartElementEnabled_Private_Void_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667342);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnCartElementSelected_Private_Void_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667343);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_AddToCart_Private_Void_KourindouStaticMerchandiseKey_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667344);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_ReturnToShelf_Private_Void_KourindouStaticMerchandiseKey_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667345);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_BuyAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667346);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_ReturnAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667347);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_Pay_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667348);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_GetPrice_Private_Int32_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667349);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_GetCurrencyFund_Private_Int32_Currency_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667350);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667351);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_Describe_Private_Void_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667352);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667353);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667354);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr__OnPanelInitialize_b__69_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667355);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr__OnPanelInitialize_b__69_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667356);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr__OnPanelInitialize_b__69_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667357);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr__OnPanelOpen_b__81_1_Private_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667358);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr__OnPanelOpen_b__81_2_Private_Void_BorderElementType_Int32_Int32_ValueTuple_3_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667359);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr__OnPanelOpen_b__81_3_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667360);
			DaySceneKourindoShopPannel.NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_Currency_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, 100667361);
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x000E9F04 File Offset: 0x000E8104
		// (set) Token: 0x06001659 RID: 5721 RVA: 0x000E9F44 File Offset: 0x000E8144
		public unsafe TrackedMerchant MerchantData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_get_MerchantData_Private_get_TrackedMerchant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63427, XrefRangeEnd = 63428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_set_MerchantData_Public_set_Void_TrackedMerchant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x000E9F88 File Offset: 0x000E8188
		public unsafe IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> DailyKourindouProducts
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 63447, RefRangeEnd = 63449, XrefRangeStart = 63428, XrefRangeEnd = 63447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_get_DailyKourindouProducts_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>>(intPtr3) : null;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x000E9FC8 File Offset: 0x000E81C8
		public unsafe IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> StaticCookerKourindouProducts
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63449, XrefRangeEnd = 63468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_get_StaticCookerKourindouProducts_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>>(intPtr3) : null;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x000EA008 File Offset: 0x000E8208
		public unsafe IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> StaticOtherKourindouProducts
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63468, XrefRangeEnd = 63487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_get_StaticOtherKourindouProducts_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>>(intPtr3) : null;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x000EA048 File Offset: 0x000E8248
		public unsafe IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> DailyKourindouProductsInCart
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63487, XrefRangeEnd = 63506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_get_DailyKourindouProductsInCart_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>>(intPtr3) : null;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x000EA088 File Offset: 0x000E8288
		public unsafe IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> StaticKourindouProductsInCart
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63506, XrefRangeEnd = 63525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_get_StaticKourindouProductsInCart_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>>(intPtr3) : null;
			}
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x000EA0C8 File Offset: 0x000E82C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63525, XrefRangeEnd = 63682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x000EA104 File Offset: 0x000E8304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63682, XrefRangeEnd = 63691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelectAllPressed(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnSelectAllPressed_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000EA14C File Offset: 0x000E834C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63691, XrefRangeEnd = 63693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelectAllReleased(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnSelectAllReleased_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x000EA194 File Offset: 0x000E8394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63693, XrefRangeEnd = 63698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SelectAllCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_SelectAllCoroutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x000EA1D4 File Offset: 0x000E83D4
		[CallerCount(0)]
		public unsafe void OnSelectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnSelectAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000EA208 File Offset: 0x000E8408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63698, XrefRangeEnd = 63700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBuyAll(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnBuyAll_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x000EA250 File Offset: 0x000E8450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63700, XrefRangeEnd = 63705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TabSwitchHandler(InputAction.CallbackContext switchAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(switchAction));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_TabSwitchHandler_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x000EA298 File Offset: 0x000E8498
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 63709, RefRangeEnd = 63717, XrefRangeStart = 63705, XrefRangeEnd = 63709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToSpecific(DaySceneKourindoShopPannel.KourindouMerchandiseType kourindouMerchandiseType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref kourindouMerchandiseType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_GoToSpecific_Private_Void_KourindouMerchandiseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000EA2D8 File Offset: 0x000E84D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 63777, RefRangeEnd = 63783, XrefRangeStart = 63717, XrefRangeEnd = 63777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShelfElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_UpdateShelfElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x000EA30C File Offset: 0x000E850C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 63883, RefRangeEnd = 63888, XrefRangeStart = 63783, XrefRangeEnd = 63883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCartElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_UpdateCartElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x000EA340 File Offset: 0x000E8540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63888, XrefRangeEnd = 63891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToPrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_GoToPrevious_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000EA374 File Offset: 0x000E8574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63891, XrefRangeEnd = 63894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_GoToNext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000EA3A8 File Offset: 0x000E85A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63894, XrefRangeEnd = 64052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x000EA3E4 File Offset: 0x000E85E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 64065, RefRangeEnd = 64071, XrefRangeStart = 64052, XrefRangeEnd = 64065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetSelection(DaySceneKourindoShopPannel.ReselectType reselectType = DaySceneKourindoShopPannel.ReselectType.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref reselectType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_ResetSelection_Private_Void_ReselectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x000EA424 File Offset: 0x000E8624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64071, XrefRangeEnd = 64114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnShelfElementEnabled(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey shelfProductData, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(shelfProductData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnShelfElementEnabled_Private_Void_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x000EA490 File Offset: 0x000E8690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64114, XrefRangeEnd = 64141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnShelfElementSelected(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey shelfProductData, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(shelfProductData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnShelfElementSelected_Private_Void_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x000EA4FC File Offset: 0x000E86FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64141, XrefRangeEnd = 64190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCartElementEnabled(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey cartProductData, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cartProductData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnCartElementEnabled_Private_Void_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x000EA568 File Offset: 0x000E8768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64190, XrefRangeEnd = 64217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCartElementSelected(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey cartProductData, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cartProductData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnCartElementSelected_Private_Void_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x000EA5D4 File Offset: 0x000E87D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 64285, RefRangeEnd = 64288, XrefRangeStart = 64217, XrefRangeEnd = 64285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToCart(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey productData, bool shouldAddAll, bool immediatelyRefresh = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(productData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldAddAll;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediatelyRefresh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_AddToCart_Private_Void_KourindouStaticMerchandiseKey_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x000EA638 File Offset: 0x000E8838
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 64356, RefRangeEnd = 64359, XrefRangeStart = 64288, XrefRangeEnd = 64356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnToShelf(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey productData, bool shouldRemoveAll, bool immediatelyRefresh = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(productData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldRemoveAll;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediatelyRefresh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_ReturnToShelf_Private_Void_KourindouStaticMerchandiseKey_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x000EA69C File Offset: 0x000E889C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64359, XrefRangeEnd = 64406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuyAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_BuyAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x000EA6D0 File Offset: 0x000E88D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64406, XrefRangeEnd = 64440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_ReturnAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x000EA704 File Offset: 0x000E8904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64564, RefRangeEnd = 64565, XrefRangeStart = 64440, XrefRangeEnd = 64564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pay(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_Pay_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x000EA744 File Offset: 0x000E8944
		[CallerCount(0)]
		public unsafe int GetPrice(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey kourindouProductData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kourindouProductData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_GetPrice_Private_Int32_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x000EA798 File Offset: 0x000E8998
		[CallerCount(0)]
		public unsafe int GetCurrencyFund(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency currency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currency;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_GetCurrencyFund_Private_Int32_Currency_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x000EA7E4 File Offset: 0x000E89E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64565, XrefRangeEnd = 64575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneKourindoShopPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x000EA820 File Offset: 0x000E8A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64673, RefRangeEnd = 64675, XrefRangeStart = 64575, XrefRangeEnd = 64673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Describe(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey kourindoStaticMerchandise)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kourindoStaticMerchandise));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_Describe_Private_Void_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x000EA868 File Offset: 0x000E8A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64675, XrefRangeEnd = 64731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneKourindoShopPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x000EA8A4 File Offset: 0x000E8AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64731, XrefRangeEnd = 64769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneKourindoShopPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x000EA8E0 File Offset: 0x000E8AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64769, XrefRangeEnd = 64770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__69_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr__OnPanelInitialize_b__69_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x000EA914 File Offset: 0x000E8B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64770, XrefRangeEnd = 64771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__69_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr__OnPanelInitialize_b__69_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x000EA948 File Offset: 0x000E8B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64771, XrefRangeEnd = 64772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__69_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr__OnPanelInitialize_b__69_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x000EA97C File Offset: 0x000E8B7C
		[CallerCount(0)]
		public unsafe void _OnPanelOpen_b__81_1(int _, MoveDirection moveDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr__OnPanelOpen_b__81_1_Private_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x000EA9C8 File Offset: 0x000E8BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64772, XrefRangeEnd = 64783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__81_2(AdpUISystemUtils.BorderElementType borderType, int _, int _, ValueTuple<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, UIElementCluster, UIButtonSimple> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref borderType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr__OnPanelOpen_b__81_2_Private_Void_BorderElementType_Int32_Int32_ValueTuple_3_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x000EAA3C File Offset: 0x000E8C3C
		[CallerCount(0)]
		public unsafe void _OnPanelOpen_b__81_3(MoveDirection dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr__OnPanelOpen_b__81_3_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x000EAA7C File Offset: 0x000E8C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64783, XrefRangeEnd = 64834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_UIElementCluster_Currency_PDM_0(UIElementCluster cluster, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency currencyData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currencyData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_Currency_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0000DE95 File Offset: 0x0000C095
		public DaySceneKourindoShopPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x000EAAC0 File Offset: 0x000E8CC0
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x0000DE9E File Offset: 0x0000C09E
		public unsafe static int NORMAL_PRODUCTS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.NativeFieldInfoPtr_NORMAL_PRODUCTS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.NativeFieldInfoPtr_NORMAL_PRODUCTS, (void*)(&value));
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x000EAADC File Offset: 0x000E8CDC
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x0000DEAC File Offset: 0x0000C0AC
		public unsafe static int COOKER_PRODUCTS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.NativeFieldInfoPtr_COOKER_PRODUCTS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.NativeFieldInfoPtr_COOKER_PRODUCTS, (void*)(&value));
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x000EAAF8 File Offset: 0x000E8CF8
		// (set) Token: 0x06001689 RID: 5769 RVA: 0x0000DEBA File Offset: 0x0000C0BA
		public unsafe static int OTHER_PRODUCTS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.NativeFieldInfoPtr_OTHER_PRODUCTS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.NativeFieldInfoPtr_OTHER_PRODUCTS, (void*)(&value));
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x000EAB14 File Offset: 0x000E8D14
		// (set) Token: 0x0600168B RID: 5771 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
		public unsafe static int COUPONS_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.NativeFieldInfoPtr_COUPONS_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.NativeFieldInfoPtr_COUPONS_ID, (void*)(&value));
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x000EAB30 File Offset: 0x000E8D30
		// (set) Token: 0x0600168D RID: 5773 RVA: 0x0000DED6 File Offset: 0x0000C0D6
		public unsafe static string QIZHE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.NativeFieldInfoPtr_QIZHE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.NativeFieldInfoPtr_QIZHE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x000EAB50 File Offset: 0x000E8D50
		// (set) Token: 0x0600168F RID: 5775 RVA: 0x0000DEE8 File Offset: 0x0000C0E8
		public unsafe RectTransform customSpacingRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_customSpacingRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_customSpacingRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001690 RID: 5776 RVA: 0x000EAB80 File Offset: 0x000E8D80
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x0000DF07 File Offset: 0x0000C107
		public unsafe DescriberSwitcher describerSwitcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_describerSwitcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DescriberSwitcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_describerSwitcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x000EABB0 File Offset: 0x000E8DB0
		// (set) Token: 0x06001693 RID: 5779 RVA: 0x0000DF26 File Offset: 0x0000C126
		public unsafe Image rinnosukeImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_rinnosukeImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_rinnosukeImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x000EABE0 File Offset: 0x000E8DE0
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x0000DF45 File Offset: 0x0000C145
		public unsafe TextMeshProUGUI talkingDialoge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_talkingDialoge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_talkingDialoge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x000EAC10 File Offset: 0x000E8E10
		// (set) Token: 0x06001697 RID: 5783 RVA: 0x0000DF64 File Offset: 0x0000C164
		public unsafe Il2CppReferenceArray<Sprite> diffImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_diffImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_diffImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x000EAC40 File Offset: 0x000E8E40
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x0000DF83 File Offset: 0x0000C183
		public unsafe MultiLanguageTextMesh.MultiLanguageTextAsset sellDialogeTXT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_sellDialogeTXT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageTextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_sellDialogeTXT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x000EAC70 File Offset: 0x000E8E70
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x0000DFA2 File Offset: 0x0000C1A2
		public unsafe MultiLanguageTextMesh.MultiLanguageTextAsset soldOutDialogeTXT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_soldOutDialogeTXT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageTextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_soldOutDialogeTXT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x000EACA0 File Offset: 0x000E8EA0
		// (set) Token: 0x0600169D RID: 5789 RVA: 0x0000DFC1 File Offset: 0x0000C1C1
		public unsafe MultiLanguageTextMesh.MultiLanguageTextAsset allSoldOutDialogeTXT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allSoldOutDialogeTXT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageTextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allSoldOutDialogeTXT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x000EACD0 File Offset: 0x000E8ED0
		// (set) Token: 0x0600169F RID: 5791 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		public unsafe Sprite soldOutFace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_soldOutFace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_soldOutFace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x000EAD00 File Offset: 0x000E8F00
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x0000DFFF File Offset: 0x0000C1FF
		public unsafe AudioClip OnBuyAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_OnBuyAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_OnBuyAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x000EAD30 File Offset: 0x000E8F30
		// (set) Token: 0x060016A3 RID: 5795 RVA: 0x0000E01E File Offset: 0x0000C21E
		public unsafe GameObject shelfObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_shelfObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_shelfObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x000EAD60 File Offset: 0x000E8F60
		// (set) Token: 0x060016A5 RID: 5797 RVA: 0x0000E03D File Offset: 0x0000C23D
		public unsafe GameObject cartObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_cartObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_cartObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x000EAD90 File Offset: 0x000E8F90
		// (set) Token: 0x060016A7 RID: 5799 RVA: 0x0000E05C File Offset: 0x0000C25C
		public unsafe GridLayoutGroup shelfField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_shelfField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_shelfField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x000EADC0 File Offset: 0x000E8FC0
		// (set) Token: 0x060016A9 RID: 5801 RVA: 0x0000E07B File Offset: 0x0000C27B
		public unsafe GridLayoutGroup cartField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_cartField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_cartField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x000EADF0 File Offset: 0x000E8FF0
		// (set) Token: 0x060016AB RID: 5803 RVA: 0x0000E09A File Offset: 0x0000C29A
		public unsafe Il2CppReferenceArray<Image> Tab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_Tab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_Tab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x000EAE20 File Offset: 0x000E9020
		// (set) Token: 0x060016AD RID: 5805 RVA: 0x0000E0B9 File Offset: 0x0000C2B9
		public unsafe Il2CppReferenceArray<UIButtonSimple> TabBtns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_TabBtns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_TabBtns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x000EAE50 File Offset: 0x000E9050
		// (set) Token: 0x060016AF RID: 5807 RVA: 0x0000E0D8 File Offset: 0x0000C2D8
		public unsafe SellableDescriber describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x000EAE80 File Offset: 0x000E9080
		// (set) Token: 0x060016B1 RID: 5809 RVA: 0x0000E0F7 File Offset: 0x0000C2F7
		public unsafe LayoutGroup describePannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_describePannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_describePannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x000EAEB0 File Offset: 0x000E90B0
		// (set) Token: 0x060016B3 RID: 5811 RVA: 0x0000E116 File Offset: 0x0000C316
		public unsafe TextMeshProUGUI price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_price);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_price), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060016B4 RID: 5812 RVA: 0x000EAEE0 File Offset: 0x000E90E0
		// (set) Token: 0x060016B5 RID: 5813 RVA: 0x0000E135 File Offset: 0x0000C335
		public unsafe TextMeshProUGUI left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_left);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_left), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x000EAF10 File Offset: 0x000E9110
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x0000E154 File Offset: 0x0000C354
		public unsafe TextMeshProUGUI amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_amount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_amount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x000EAF40 File Offset: 0x000E9140
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x0000E173 File Offset: 0x0000C373
		public unsafe TextMeshProUGUI title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x000EAF70 File Offset: 0x000E9170
		// (set) Token: 0x060016BB RID: 5819 RVA: 0x0000E192 File Offset: 0x0000C392
		public unsafe CanvasGroup amountCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_amountCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_amountCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x000EAFA0 File Offset: 0x000E91A0
		// (set) Token: 0x060016BD RID: 5821 RVA: 0x0000E1B1 File Offset: 0x0000C3B1
		public unsafe UIButtonSimple confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x000EAFD0 File Offset: 0x000E91D0
		// (set) Token: 0x060016BF RID: 5823 RVA: 0x0000E1D0 File Offset: 0x0000C3D0
		public unsafe RectTransform currencyPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_currencyPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_currencyPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x000EB000 File Offset: 0x000E9200
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x0000E1EF File Offset: 0x0000C3EF
		public unsafe CanvasGroup describeCurrencyCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_describeCurrencyCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_describeCurrencyCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x000EB030 File Offset: 0x000E9230
		// (set) Token: 0x060016C3 RID: 5827 RVA: 0x0000E20E File Offset: 0x0000C40E
		public unsafe GameObject currencyElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_currencyElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_currencyElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x000EB060 File Offset: 0x000E9260
		// (set) Token: 0x060016C5 RID: 5829 RVA: 0x0000E22D File Offset: 0x0000C42D
		public unsafe AdpProgressIndicatorComponent scrollerLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_scrollerLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_scrollerLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x000EB090 File Offset: 0x000E9290
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x0000E24C File Offset: 0x0000C44C
		public unsafe AdpProgressIndicatorComponent scrollerRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_scrollerRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_scrollerRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x000EB0C0 File Offset: 0x000E92C0
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x0000E26B File Offset: 0x0000C46B
		public unsafe Color sufficientColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_sufficientColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_sufficientColor)) = value;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x000EB0E8 File Offset: 0x000E92E8
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x0000E286 File Offset: 0x0000C486
		public unsafe Color inSufficientColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_inSufficientColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_inSufficientColor)) = value;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x000EB110 File Offset: 0x000E9310
		// (set) Token: 0x060016CD RID: 5837 RVA: 0x0000E2A1 File Offset: 0x0000C4A1
		public unsafe List<GameObject> allCartPanelCurrencyInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allCartPanelCurrencyInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allCartPanelCurrencyInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x000EB140 File Offset: 0x000E9340
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x0000E2C0 File Offset: 0x0000C4C0
		public unsafe List<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> allCartProductList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allCartProductList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allCartProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x000EB170 File Offset: 0x000E9370
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x0000E2DF File Offset: 0x0000C4DF
		public unsafe List<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> allKourindouProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allKourindouProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allKourindouProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x000EB1A0 File Offset: 0x000E93A0
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x0000E2FE File Offset: 0x0000C4FE
		public unsafe List<GameObject> allShelfPanelCurrencyInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allShelfPanelCurrencyInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allShelfPanelCurrencyInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x000EB1D0 File Offset: 0x000E93D0
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x0000E31D File Offset: 0x0000C51D
		public unsafe List<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> allShelfProductList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allShelfProductList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allShelfProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x000EB200 File Offset: 0x000E9400
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x0000E33C File Offset: 0x0000C53C
		public unsafe Dictionary<KeyValuePair<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.CurrencyType, int>, int> currencyDic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_currencyDic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<KeyValuePair<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.CurrencyType, int>, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_currencyDic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x000EB230 File Offset: 0x000E9430
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x0000E35B File Offset: 0x0000C55B
		public unsafe DaySceneKourindoShopPannel.ProductKeyEqualityComparer _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneKourindoShopPannel.ProductKeyEqualityComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x000EB260 File Offset: 0x000E9460
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x0000E37A File Offset: 0x0000C57A
		public unsafe Action buyAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_buyAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_buyAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x000EB290 File Offset: 0x000E9490
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x0000E399 File Offset: 0x0000C599
		public unsafe CanvasGroup describerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_describerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_describerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x000EB2C0 File Offset: 0x000E94C0
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		public unsafe Il2CppStringArray dialogeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_dialogeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_dialogeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x000EB2F0 File Offset: 0x000E94F0
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x0000E3D7 File Offset: 0x0000C5D7
		public unsafe Il2CppStringArray soldOutText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_soldOutText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_soldOutText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x000EB320 File Offset: 0x000E9520
		// (set) Token: 0x060016E3 RID: 5859 RVA: 0x0000E3F6 File Offset: 0x0000C5F6
		public unsafe Il2CppStringArray allSoldOutText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allSoldOutText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_allSoldOutText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x000EB350 File Offset: 0x000E9550
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x0000E415 File Offset: 0x0000C615
		public unsafe bool m_Affordable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_Affordable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_Affordable)) = value;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x000EB378 File Offset: 0x000E9578
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x0000E430 File Offset: 0x0000C630
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, UIElementCluster, UIButtonSimple> m_CartGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_CartGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_CartGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x000EB3A8 File Offset: 0x000E95A8
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x0000E44F File Offset: 0x0000C64F
		public unsafe Coroutine m_SelectAllCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_SelectAllCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_SelectAllCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x000EB3D8 File Offset: 0x000E95D8
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x0000E46E File Offset: 0x0000C66E
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, UIElementCluster, UIButtonSimple> m_ShelfGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_ShelfGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_ShelfGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x000EB408 File Offset: 0x000E9608
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x0000E48D File Offset: 0x0000C68D
		public unsafe float m_ShouldRunBuyAllFucntionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_ShouldRunBuyAllFucntionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_m_ShouldRunBuyAllFucntionOffset)) = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x000EB430 File Offset: 0x000E9630
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		public unsafe Action selectAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_selectAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_selectAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x000EB460 File Offset: 0x000E9660
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x0000E4C7 File Offset: 0x0000C6C7
		public unsafe DaySceneKourindoShopPannel.KourindouMerchandiseType tabType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_tabType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr_tabType)) = value;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x000EB488 File Offset: 0x000E9688
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x0000E4E2 File Offset: 0x0000C6E2
		public unsafe TrackedMerchant _MerchantData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr__MerchantData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.NativeFieldInfoPtr__MerchantData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeFieldInfoPtr_NORMAL_PRODUCTS;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeFieldInfoPtr_COOKER_PRODUCTS;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeFieldInfoPtr_OTHER_PRODUCTS;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeFieldInfoPtr_COUPONS_ID;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeFieldInfoPtr_QIZHE;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeFieldInfoPtr_customSpacingRect;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeFieldInfoPtr_describerSwitcher;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeFieldInfoPtr_rinnosukeImage;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeFieldInfoPtr_talkingDialoge;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeFieldInfoPtr_diffImages;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeFieldInfoPtr_sellDialogeTXT;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeFieldInfoPtr_soldOutDialogeTXT;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeFieldInfoPtr_allSoldOutDialogeTXT;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeFieldInfoPtr_soldOutFace;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeFieldInfoPtr_OnBuyAudio;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeFieldInfoPtr_shelfObject;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeFieldInfoPtr_cartObject;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeFieldInfoPtr_shelfField;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeFieldInfoPtr_cartField;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeFieldInfoPtr_Tab;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeFieldInfoPtr_TabBtns;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeFieldInfoPtr_describer;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeFieldInfoPtr_describePannel;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeFieldInfoPtr_price;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeFieldInfoPtr_amount;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeFieldInfoPtr_amountCanvas;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeFieldInfoPtr_currencyPannel;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeFieldInfoPtr_describeCurrencyCanvasGroup;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeFieldInfoPtr_currencyElement;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeFieldInfoPtr_scrollerLeft;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeFieldInfoPtr_scrollerRight;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeFieldInfoPtr_sufficientColor;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeFieldInfoPtr_inSufficientColor;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeFieldInfoPtr_allCartPanelCurrencyInstances;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeFieldInfoPtr_allCartProductList;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeFieldInfoPtr_allKourindouProducts;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeFieldInfoPtr_allShelfPanelCurrencyInstances;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeFieldInfoPtr_allShelfProductList;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeFieldInfoPtr_currencyDic;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeFieldInfoPtr_buyAll;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeFieldInfoPtr_describerCanvasGroup;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeFieldInfoPtr_dialogeText;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeFieldInfoPtr_soldOutText;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeFieldInfoPtr_allSoldOutText;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeFieldInfoPtr_m_Affordable;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeFieldInfoPtr_m_CartGroup;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectAllCoroutine;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeFieldInfoPtr_m_ShelfGroup;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldRunBuyAllFucntionOffset;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeFieldInfoPtr_selectAll;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeFieldInfoPtr_tabType;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeFieldInfoPtr__MerchantData_k__BackingField;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeMethodInfoPtr_get_MerchantData_Private_get_TrackedMerchant_0;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeMethodInfoPtr_set_MerchantData_Public_set_Void_TrackedMerchant_0;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeMethodInfoPtr_get_DailyKourindouProducts_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticCookerKourindouProducts_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticOtherKourindouProducts_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeMethodInfoPtr_get_DailyKourindouProductsInCart_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticKourindouProductsInCart_Private_get_IEnumerable_1_KourindouStaticMerchandiseKey_0;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectAllPressed_Private_Void_CallbackContext_0;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectAllReleased_Private_Void_CallbackContext_0;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_SelectAllCoroutine_Private_IEnumerator_0;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectAll_Private_Void_0;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeMethodInfoPtr_OnBuyAll_Private_Void_CallbackContext_0;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeMethodInfoPtr_TabSwitchHandler_Private_Void_CallbackContext_0;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeMethodInfoPtr_GoToSpecific_Private_Void_KourindouMerchandiseType_0;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShelfElements_Private_Void_0;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCartElements_Private_Void_0;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeMethodInfoPtr_GoToPrevious_Private_Void_0;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeMethodInfoPtr_GoToNext_Private_Void_0;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr_ResetSelection_Private_Void_ReselectType_0;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeMethodInfoPtr_OnShelfElementEnabled_Private_Void_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeMethodInfoPtr_OnShelfElementSelected_Private_Void_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr_OnCartElementEnabled_Private_Void_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeMethodInfoPtr_OnCartElementSelected_Private_Void_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeMethodInfoPtr_AddToCart_Private_Void_KourindouStaticMerchandiseKey_Boolean_Boolean_0;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeMethodInfoPtr_ReturnToShelf_Private_Void_KourindouStaticMerchandiseKey_Boolean_Boolean_0;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_BuyAll_Private_Void_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_ReturnAll_Private_Void_0;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr_Pay_Private_Void_Int32_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_GetPrice_Private_Int32_KourindouStaticMerchandiseKey_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrencyFund_Private_Int32_Currency_0;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Private_Void_KourindouStaticMerchandiseKey_0;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__69_0_Private_Void_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__69_1_Private_Void_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__69_2_Private_Void_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__81_1_Private_Void_Int32_MoveDirection_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__81_2_Private_Void_BorderElementType_Int32_Int32_ValueTuple_3_KourindouStaticMerchandiseKey_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__81_3_Private_Void_MoveDirection_0;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_Currency_PDM_0;

		// Token: 0x0200064A RID: 1610
		public sealed class KourindouStaticMerchandiseKey : ValueType
		{
			// Token: 0x06009350 RID: 37712 RVA: 0x0027CAE8 File Offset: 0x0027ACE8
			// Note: this type is marked as 'beforefieldinit'.
			static KourindouStaticMerchandiseKey()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "KourindouStaticMerchandiseKey");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr);
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr_KourindouMerchandiseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, "KourindouMerchandiseType");
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr_ProductType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, "ProductType");
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, "Id");
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr_KourindouProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, "KourindouProduct");
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr__UnitFundPrice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, "<UnitFundPrice>k__BackingField");
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr__RemainingNum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, "<RemainingNum>k__BackingField");
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_UnitFundPrice_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, 100667362);
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_Label_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, 100667363);
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_ProductLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, 100667364);
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_ProductCurrency_Public_get_Il2CppStructArray_1_Currency_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, 100667365);
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_ProvideProduct_Public_get_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, 100667366);
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_RemainingNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, 100667367);
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_set_RemainingNum_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, 100667368);
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, 100667369);
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr__ctor_Public_Void_ProductType_Int32_KourindoStaticMerchandise_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, 100667370);
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr__ctor_Public_Void_KourindoStaticMerchandise_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, 100667371);
				DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_SetNewProduct_Public_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, 100667372);
			}

			// Token: 0x1700310B RID: 12555
			// (get) Token: 0x06009351 RID: 37713 RVA: 0x0027CC68 File Offset: 0x0027AE68
			public unsafe int UnitFundPrice
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_UnitFundPrice_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700310C RID: 12556
			// (get) Token: 0x06009352 RID: 37714 RVA: 0x0027CCAC File Offset: 0x0027AEAC
			public unsafe string Label
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_Label_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700310D RID: 12557
			// (get) Token: 0x06009353 RID: 37715 RVA: 0x0027CCE8 File Offset: 0x0027AEE8
			public unsafe string ProductLabel
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_ProductLabel_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700310E RID: 12558
			// (get) Token: 0x06009354 RID: 37716 RVA: 0x0027CD24 File Offset: 0x0027AF24
			public unsafe Il2CppStructArray<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency> ProductCurrency
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_ProductCurrency_Public_get_Il2CppStructArray_1_Currency_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency>>(intPtr3) : null;
				}
			}

			// Token: 0x1700310F RID: 12559
			// (get) Token: 0x06009355 RID: 37717 RVA: 0x0027CD68 File Offset: 0x0027AF68
			public unsafe Product ProvideProduct
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_ProvideProduct_Public_get_Product_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new Product(pointer);
				}
			}

			// Token: 0x17003110 RID: 12560
			// (get) Token: 0x06009356 RID: 37718 RVA: 0x0027CDA4 File Offset: 0x0027AFA4
			// (set) Token: 0x06009357 RID: 37719 RVA: 0x0027CDE8 File Offset: 0x0027AFE8
			public unsafe int RemainingNum
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_RemainingNum_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_set_RemainingNum_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17003111 RID: 12561
			// (get) Token: 0x06009358 RID: 37720 RVA: 0x0027CE2C File Offset: 0x0027B02C
			public unsafe bool IsAvailable
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06009359 RID: 37721 RVA: 0x0027CE70 File Offset: 0x0027B070
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63126, RefRangeEnd = 63127, XrefRangeStart = 63090, XrefRangeEnd = 63126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KourindouStaticMerchandiseKey(Product.ProductType productType, int id, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise kourindouProduct) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref productType;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kourindouProduct));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr__ctor_Public_Void_ProductType_Int32_KourindoStaticMerchandise_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600935A RID: 37722 RVA: 0x0027CEE4 File Offset: 0x0027B0E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63163, RefRangeEnd = 63164, XrefRangeStart = 63127, XrefRangeEnd = 63163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KourindouStaticMerchandiseKey(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise kourindouProduct) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kourindouProduct));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr__ctor_Public_Void_KourindoStaticMerchandise_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600935B RID: 37723 RVA: 0x0027CF3C File Offset: 0x0027B13C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63164, XrefRangeEnd = 63165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetNewProduct(Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeMethodInfoPtr_SetNewProduct_Public_Void_Product_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600935C RID: 37724 RVA: 0x0004FB73 File Offset: 0x0004DD73
			public KourindouStaticMerchandiseKey(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600935D RID: 37725 RVA: 0x0004FB7C File Offset: 0x0004DD7C
			public KourindouStaticMerchandiseKey() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr))
			{
			}

			// Token: 0x17003105 RID: 12549
			// (get) Token: 0x0600935E RID: 37726 RVA: 0x0027CF88 File Offset: 0x0027B188
			// (set) Token: 0x0600935F RID: 37727 RVA: 0x0004FB8E File Offset: 0x0004DD8E
			public unsafe DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.MerchandiseType KourindouMerchandiseType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr_KourindouMerchandiseType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr_KourindouMerchandiseType)) = value;
				}
			}

			// Token: 0x17003106 RID: 12550
			// (get) Token: 0x06009360 RID: 37728 RVA: 0x0027CFB0 File Offset: 0x0027B1B0
			// (set) Token: 0x06009361 RID: 37729 RVA: 0x0004FBA9 File Offset: 0x0004DDA9
			public unsafe Product.ProductType ProductType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr_ProductType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr_ProductType)) = value;
				}
			}

			// Token: 0x17003107 RID: 12551
			// (get) Token: 0x06009362 RID: 37730 RVA: 0x0027CFD8 File Offset: 0x0027B1D8
			// (set) Token: 0x06009363 RID: 37731 RVA: 0x0004FBC4 File Offset: 0x0004DDC4
			public unsafe int Id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr_Id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr_Id)) = value;
				}
			}

			// Token: 0x17003108 RID: 12552
			// (get) Token: 0x06009364 RID: 37732 RVA: 0x0027D000 File Offset: 0x0027B200
			// (set) Token: 0x06009365 RID: 37733 RVA: 0x0004FBDF File Offset: 0x0004DDDF
			public KourindoStaticMerchandiseProfile.KourindoStaticMerchandise KourindouProduct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr_KourindouProduct);
					return new KourindoStaticMerchandiseProfile.KourindoStaticMerchandise(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr_KourindouProduct), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003109 RID: 12553
			// (get) Token: 0x06009366 RID: 37734 RVA: 0x0027D030 File Offset: 0x0027B230
			// (set) Token: 0x06009367 RID: 37735 RVA: 0x0004FC0D File Offset: 0x0004DE0D
			public unsafe int _UnitFundPrice_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr__UnitFundPrice_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr__UnitFundPrice_k__BackingField)) = value;
				}
			}

			// Token: 0x1700310A RID: 12554
			// (get) Token: 0x06009368 RID: 37736 RVA: 0x0027D058 File Offset: 0x0027B258
			// (set) Token: 0x06009369 RID: 37737 RVA: 0x0004FC28 File Offset: 0x0004DE28
			public unsafe int _RemainingNum_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr__RemainingNum_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.NativeFieldInfoPtr__RemainingNum_k__BackingField)) = value;
				}
			}

			// Token: 0x04005F95 RID: 24469
			private static readonly IntPtr NativeFieldInfoPtr_KourindouMerchandiseType;

			// Token: 0x04005F96 RID: 24470
			private static readonly IntPtr NativeFieldInfoPtr_ProductType;

			// Token: 0x04005F97 RID: 24471
			private static readonly IntPtr NativeFieldInfoPtr_Id;

			// Token: 0x04005F98 RID: 24472
			private static readonly IntPtr NativeFieldInfoPtr_KourindouProduct;

			// Token: 0x04005F99 RID: 24473
			private static readonly IntPtr NativeFieldInfoPtr__UnitFundPrice_k__BackingField;

			// Token: 0x04005F9A RID: 24474
			private static readonly IntPtr NativeFieldInfoPtr__RemainingNum_k__BackingField;

			// Token: 0x04005F9B RID: 24475
			private static readonly IntPtr NativeMethodInfoPtr_get_UnitFundPrice_Public_get_Int32_0;

			// Token: 0x04005F9C RID: 24476
			private static readonly IntPtr NativeMethodInfoPtr_get_Label_Public_get_String_0;

			// Token: 0x04005F9D RID: 24477
			private static readonly IntPtr NativeMethodInfoPtr_get_ProductLabel_Public_get_String_0;

			// Token: 0x04005F9E RID: 24478
			private static readonly IntPtr NativeMethodInfoPtr_get_ProductCurrency_Public_get_Il2CppStructArray_1_Currency_0;

			// Token: 0x04005F9F RID: 24479
			private static readonly IntPtr NativeMethodInfoPtr_get_ProvideProduct_Public_get_Product_0;

			// Token: 0x04005FA0 RID: 24480
			private static readonly IntPtr NativeMethodInfoPtr_get_RemainingNum_Public_get_Int32_0;

			// Token: 0x04005FA1 RID: 24481
			private static readonly IntPtr NativeMethodInfoPtr_set_RemainingNum_Public_set_Void_Int32_0;

			// Token: 0x04005FA2 RID: 24482
			private static readonly IntPtr NativeMethodInfoPtr_get_IsAvailable_Public_get_Boolean_0;

			// Token: 0x04005FA3 RID: 24483
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProductType_Int32_KourindoStaticMerchandise_0;

			// Token: 0x04005FA4 RID: 24484
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_KourindoStaticMerchandise_0;

			// Token: 0x04005FA5 RID: 24485
			private static readonly IntPtr NativeMethodInfoPtr_SetNewProduct_Public_Void_Product_0;

			// Token: 0x02000FBF RID: 4031
			public enum MerchandiseType
			{
				// Token: 0x0400AF7E RID: 44926
				Static,
				// Token: 0x0400AF7F RID: 44927
				Daily
			}

			// Token: 0x02000FC0 RID: 4032
			[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+KourindouStaticMerchandiseKey+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x060115E0 RID: 71136 RVA: 0x003FE588 File Offset: 0x003FC788
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>.NativeClassPtr);
					DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>.NativeClassPtr, "<>9");
					DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>.NativeClassPtr, "<>9__22_0");
					DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>.NativeClassPtr, "<>9__22_1");
					DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>.NativeClassPtr, "<>9__23_0");
					DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>.NativeClassPtr, "<>9__23_1");
					DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>.NativeClassPtr, 100667374);
					DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeMethodInfoPtr___ctor_b__22_0_Internal_Int32_Currency_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>.NativeClassPtr, 100667375);
					DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeMethodInfoPtr___ctor_b__22_1_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>.NativeClassPtr, 100667376);
					DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeMethodInfoPtr___ctor_b__23_0_Internal_Int32_Currency_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>.NativeClassPtr, 100667377);
					DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeMethodInfoPtr___ctor_b__23_1_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>.NativeClassPtr, 100667378);
				}

				// Token: 0x060115E1 RID: 71137 RVA: 0x003FE67C File Offset: 0x003FC87C
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060115E2 RID: 71138 RVA: 0x003FE6B8 File Offset: 0x003FC8B8
				[CallerCount(0)]
				public unsafe int __ctor_b__22_0(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeMethodInfoPtr___ctor_b__22_0_Internal_Int32_Currency_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060115E3 RID: 71139 RVA: 0x003FE704 File Offset: 0x003FC904
				[CallerCount(0)]
				public unsafe int __ctor_b__22_1(int a, int b)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref a;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeMethodInfoPtr___ctor_b__22_1_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060115E4 RID: 71140 RVA: 0x003FE75C File Offset: 0x003FC95C
				[CallerCount(0)]
				public unsafe int __ctor_b__23_0(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeMethodInfoPtr___ctor_b__23_0_Internal_Int32_Currency_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060115E5 RID: 71141 RVA: 0x003FE7A8 File Offset: 0x003FC9A8
				[CallerCount(0)]
				public unsafe int __ctor_b__23_1(int a, int b)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref a;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeMethodInfoPtr___ctor_b__23_1_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060115E6 RID: 71142 RVA: 0x000972A9 File Offset: 0x000954A9
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A47 RID: 23111
				// (get) Token: 0x060115E7 RID: 71143 RVA: 0x003FE800 File Offset: 0x003FCA00
				// (set) Token: 0x060115E8 RID: 71144 RVA: 0x000972B2 File Offset: 0x000954B2
				public unsafe static DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A48 RID: 23112
				// (get) Token: 0x060115E9 RID: 71145 RVA: 0x003FE828 File Offset: 0x003FCA28
				// (set) Token: 0x060115EA RID: 71146 RVA: 0x000972C4 File Offset: 0x000954C4
				public unsafe static Func<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency, int> __9__22_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A49 RID: 23113
				// (get) Token: 0x060115EB RID: 71147 RVA: 0x003FE850 File Offset: 0x003FCA50
				// (set) Token: 0x060115EC RID: 71148 RVA: 0x000972D6 File Offset: 0x000954D6
				public unsafe static Func<int, int, int> __9__22_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9__22_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A4A RID: 23114
				// (get) Token: 0x060115ED RID: 71149 RVA: 0x003FE878 File Offset: 0x003FCA78
				// (set) Token: 0x060115EE RID: 71150 RVA: 0x000972E8 File Offset: 0x000954E8
				public unsafe static Func<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency, int> __9__23_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A4B RID: 23115
				// (get) Token: 0x060115EF RID: 71151 RVA: 0x003FE8A0 File Offset: 0x003FCAA0
				// (set) Token: 0x060115F0 RID: 71152 RVA: 0x000972FA File Offset: 0x000954FA
				public unsafe static Func<int, int, int> __9__23_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AF80 RID: 44928
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400AF81 RID: 44929
				private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

				// Token: 0x0400AF82 RID: 44930
				private static readonly IntPtr NativeFieldInfoPtr___9__22_1;

				// Token: 0x0400AF83 RID: 44931
				private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

				// Token: 0x0400AF84 RID: 44932
				private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

				// Token: 0x0400AF85 RID: 44933
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AF86 RID: 44934
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__22_0_Internal_Int32_Currency_0;

				// Token: 0x0400AF87 RID: 44935
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__22_1_Internal_Int32_Int32_Int32_0;

				// Token: 0x0400AF88 RID: 44936
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__23_0_Internal_Int32_Currency_0;

				// Token: 0x0400AF89 RID: 44937
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__23_1_Internal_Int32_Int32_Int32_0;
			}
		}

		// Token: 0x0200064B RID: 1611
		public class ProductKeyEqualityComparer : Il2CppSystem.Object
		{
			// Token: 0x0600936A RID: 37738 RVA: 0x0027D080 File Offset: 0x0027B280
			// Note: this type is marked as 'beforefieldinit'.
			static ProductKeyEqualityComparer()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.ProductKeyEqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "ProductKeyEqualityComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.ProductKeyEqualityComparer>.NativeClassPtr);
				DaySceneKourindoShopPannel.ProductKeyEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_KourindouStaticMerchandiseKey_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.ProductKeyEqualityComparer>.NativeClassPtr, 100667379);
				DaySceneKourindoShopPannel.ProductKeyEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.ProductKeyEqualityComparer>.NativeClassPtr, 100667380);
				DaySceneKourindoShopPannel.ProductKeyEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.ProductKeyEqualityComparer>.NativeClassPtr, 100667381);
			}

			// Token: 0x0600936B RID: 37739 RVA: 0x0027D0E8 File Offset: 0x0027B2E8
			[CallerCount(0)]
			public unsafe virtual bool Equals(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x, DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.ProductKeyEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_KourindouStaticMerchandiseKey_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600936C RID: 37740 RVA: 0x0027D154 File Offset: 0x0027B354
			[CallerCount(0)]
			public unsafe virtual int GetHashCode(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.ProductKeyEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600936D RID: 37741 RVA: 0x0027D1A8 File Offset: 0x0027B3A8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProductKeyEqualityComparer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.ProductKeyEqualityComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.ProductKeyEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600936E RID: 37742 RVA: 0x0004FC43 File Offset: 0x0004DE43
			public ProductKeyEqualityComparer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04005FA6 RID: 24486
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_KourindouStaticMerchandiseKey_KourindouStaticMerchandiseKey_0;

			// Token: 0x04005FA7 RID: 24487
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_KourindouStaticMerchandiseKey_0;

			// Token: 0x04005FA8 RID: 24488
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200064C RID: 1612
		public enum KourindouMerchandiseType
		{
			// Token: 0x04005FAA RID: 24490
			Daily,
			// Token: 0x04005FAB RID: 24491
			Cooker,
			// Token: 0x04005FAC RID: 24492
			Other,
			// Token: 0x04005FAD RID: 24493
			None
		}

		// Token: 0x0200064D RID: 1613
		public enum ReselectType
		{
			// Token: 0x04005FAF RID: 24495
			Default,
			// Token: 0x04005FB0 RID: 24496
			PreferShelf,
			// Token: 0x04005FB1 RID: 24497
			PreferCart
		}

		// Token: 0x0200064E RID: 1614
		[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600936F RID: 37743 RVA: 0x0027D1E4 File Offset: 0x0027B3E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr);
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__60_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__60_0");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__62_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__62_0");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__64_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__64_0");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__66_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__66_0");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__68_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__68_0");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__69_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__69_3");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__69_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__69_4");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__69_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__69_5");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__78_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__78_0");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__81_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__81_0");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__91_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__91_0");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__91_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__91_1");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__91_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__91_2");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__91_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__91_3");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__95_5");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__95_1");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__95_2");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__95_7");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__95_8");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__95_11");
				DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, "<>9__95_12");
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667383);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__get_DailyKourindouProducts_b__60_0_Internal_Boolean_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667384);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__get_StaticCookerKourindouProducts_b__62_0_Internal_Boolean_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667385);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__get_StaticOtherKourindouProducts_b__64_0_Internal_Boolean_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667386);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__get_DailyKourindouProductsInCart_b__66_0_Internal_Boolean_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667387);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__get_StaticKourindouProductsInCart_b__68_0_Internal_Boolean_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667388);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__69_3_Internal_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667389);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__69_4_Internal_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667390);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__69_5_Internal_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667391);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__UpdateCartElements_b__78_0_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667392);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__81_0_Internal_Boolean_KourindoStaticMerchandise_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667393);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Pay_b__91_0_Internal_Product_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667394);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Pay_b__91_1_Internal_Void_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667395);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Pay_b__91_2_Internal_Product_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667396);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Pay_b__91_3_Internal_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667397);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_5_Internal_KeyValuePair_2_Recipe_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667398);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_1_Internal_Boolean_Currency_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667399);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_2_Internal_Boolean_Currency_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667400);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_7_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667401);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_8_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667402);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_11_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667403);
				DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_12_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr, 100667404);
			}

			// Token: 0x06009370 RID: 37744 RVA: 0x0027D580 File Offset: 0x0027B780
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009371 RID: 37745 RVA: 0x0027D5BC File Offset: 0x0027B7BC
			[CallerCount(0)]
			public unsafe bool _get_DailyKourindouProducts_b__60_0(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__get_DailyKourindouProducts_b__60_0_Internal_Boolean_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009372 RID: 37746 RVA: 0x0027D610 File Offset: 0x0027B810
			[CallerCount(0)]
			public unsafe bool _get_StaticCookerKourindouProducts_b__62_0(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__get_StaticCookerKourindouProducts_b__62_0_Internal_Boolean_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009373 RID: 37747 RVA: 0x0027D664 File Offset: 0x0027B864
			[CallerCount(0)]
			public unsafe bool _get_StaticOtherKourindouProducts_b__64_0(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__get_StaticOtherKourindouProducts_b__64_0_Internal_Boolean_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009374 RID: 37748 RVA: 0x0027D6B8 File Offset: 0x0027B8B8
			[CallerCount(0)]
			public unsafe bool _get_DailyKourindouProductsInCart_b__66_0(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__get_DailyKourindouProductsInCart_b__66_0_Internal_Boolean_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009375 RID: 37749 RVA: 0x0027D70C File Offset: 0x0027B90C
			[CallerCount(0)]
			public unsafe bool _get_StaticKourindouProductsInCart_b__68_0(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__get_StaticKourindouProductsInCart_b__68_0_Internal_Boolean_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009376 RID: 37750 RVA: 0x0027D760 File Offset: 0x0027B960
			[CallerCount(0)]
			public unsafe string _OnPanelInitialize_b__69_3(Il2CppStringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__69_3_Internal_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009377 RID: 37751 RVA: 0x0027D7A8 File Offset: 0x0027B9A8
			[CallerCount(0)]
			public unsafe string _OnPanelInitialize_b__69_4(Il2CppStringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__69_4_Internal_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009378 RID: 37752 RVA: 0x0027D7F0 File Offset: 0x0027B9F0
			[CallerCount(0)]
			public unsafe string _OnPanelInitialize_b__69_5(Il2CppStringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__69_5_Internal_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009379 RID: 37753 RVA: 0x0027D838 File Offset: 0x0027BA38
			[CallerCount(0)]
			public unsafe int _UpdateCartElements_b__78_0(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__UpdateCartElements_b__78_0_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600937A RID: 37754 RVA: 0x0027D890 File Offset: 0x0027BA90
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__81_0(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__81_0_Internal_Boolean_KourindoStaticMerchandise_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600937B RID: 37755 RVA: 0x0027D8E4 File Offset: 0x0027BAE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63165, XrefRangeEnd = 63166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Product _Pay_b__91_0(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Pay_b__91_0_Internal_Product_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Product(pointer);
			}

			// Token: 0x0600937C RID: 37756 RVA: 0x0027D934 File Offset: 0x0027BB34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63166, XrefRangeEnd = 63167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Pay_b__91_1(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Pay_b__91_1_Internal_Void_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600937D RID: 37757 RVA: 0x0027D97C File Offset: 0x0027BB7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Product _Pay_b__91_2(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Pay_b__91_2_Internal_Product_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Product(pointer);
			}

			// Token: 0x0600937E RID: 37758 RVA: 0x0027D9CC File Offset: 0x0027BBCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63167, XrefRangeEnd = 63168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Pay_b__91_3(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Pay_b__91_3_Internal_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600937F RID: 37759 RVA: 0x0027DA14 File Offset: 0x0027BC14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63168, XrefRangeEnd = 63172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<Recipe, int> _Describe_b__95_5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_5_Internal_KeyValuePair_2_Recipe_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<Recipe, int>(pointer);
			}

			// Token: 0x06009380 RID: 37760 RVA: 0x0027DA58 File Offset: 0x0027BC58
			[CallerCount(0)]
			public unsafe bool _Describe_b__95_1(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_1_Internal_Boolean_Currency_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009381 RID: 37761 RVA: 0x0027DAA4 File Offset: 0x0027BCA4
			[CallerCount(0)]
			public unsafe bool _Describe_b__95_2(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_2_Internal_Boolean_Currency_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009382 RID: 37762 RVA: 0x0027DAF0 File Offset: 0x0027BCF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63172, XrefRangeEnd = 63175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__95_7(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_7_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009383 RID: 37763 RVA: 0x0027DB34 File Offset: 0x0027BD34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63175, XrefRangeEnd = 63178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__95_8(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_8_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009384 RID: 37764 RVA: 0x0027DB78 File Offset: 0x0027BD78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63178, XrefRangeEnd = 63181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__95_11(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_11_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009385 RID: 37765 RVA: 0x0027DBBC File Offset: 0x0027BDBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63181, XrefRangeEnd = 63184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__95_12(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c.NativeMethodInfoPtr__Describe_b__95_12_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009386 RID: 37766 RVA: 0x0004FC4C File Offset: 0x0004DE4C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003112 RID: 12562
			// (get) Token: 0x06009387 RID: 37767 RVA: 0x0027DC00 File Offset: 0x0027BE00
			// (set) Token: 0x06009388 RID: 37768 RVA: 0x0004FC55 File Offset: 0x0004DE55
			public unsafe static DaySceneKourindoShopPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneKourindoShopPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003113 RID: 12563
			// (get) Token: 0x06009389 RID: 37769 RVA: 0x0027DC28 File Offset: 0x0027BE28
			// (set) Token: 0x0600938A RID: 37770 RVA: 0x0004FC67 File Offset: 0x0004DE67
			public unsafe static Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, bool> __9__60_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__60_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__60_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003114 RID: 12564
			// (get) Token: 0x0600938B RID: 37771 RVA: 0x0027DC50 File Offset: 0x0027BE50
			// (set) Token: 0x0600938C RID: 37772 RVA: 0x0004FC79 File Offset: 0x0004DE79
			public unsafe static Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, bool> __9__62_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__62_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__62_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003115 RID: 12565
			// (get) Token: 0x0600938D RID: 37773 RVA: 0x0027DC78 File Offset: 0x0027BE78
			// (set) Token: 0x0600938E RID: 37774 RVA: 0x0004FC8B File Offset: 0x0004DE8B
			public unsafe static Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, bool> __9__64_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__64_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__64_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003116 RID: 12566
			// (get) Token: 0x0600938F RID: 37775 RVA: 0x0027DCA0 File Offset: 0x0027BEA0
			// (set) Token: 0x06009390 RID: 37776 RVA: 0x0004FC9D File Offset: 0x0004DE9D
			public unsafe static Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, bool> __9__66_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__66_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__66_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003117 RID: 12567
			// (get) Token: 0x06009391 RID: 37777 RVA: 0x0027DCC8 File Offset: 0x0027BEC8
			// (set) Token: 0x06009392 RID: 37778 RVA: 0x0004FCAF File Offset: 0x0004DEAF
			public unsafe static Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, bool> __9__68_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__68_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__68_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003118 RID: 12568
			// (get) Token: 0x06009393 RID: 37779 RVA: 0x0027DCF0 File Offset: 0x0027BEF0
			// (set) Token: 0x06009394 RID: 37780 RVA: 0x0004FCC1 File Offset: 0x0004DEC1
			public unsafe static Func<Il2CppStringArray, string> __9__69_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__69_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStringArray, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__69_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003119 RID: 12569
			// (get) Token: 0x06009395 RID: 37781 RVA: 0x0027DD18 File Offset: 0x0027BF18
			// (set) Token: 0x06009396 RID: 37782 RVA: 0x0004FCD3 File Offset: 0x0004DED3
			public unsafe static Func<Il2CppStringArray, string> __9__69_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__69_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStringArray, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__69_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700311A RID: 12570
			// (get) Token: 0x06009397 RID: 37783 RVA: 0x0027DD40 File Offset: 0x0027BF40
			// (set) Token: 0x06009398 RID: 37784 RVA: 0x0004FCE5 File Offset: 0x0004DEE5
			public unsafe static Func<Il2CppStringArray, string> __9__69_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__69_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStringArray, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__69_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700311B RID: 12571
			// (get) Token: 0x06009399 RID: 37785 RVA: 0x0027DD68 File Offset: 0x0027BF68
			// (set) Token: 0x0600939A RID: 37786 RVA: 0x0004FCF7 File Offset: 0x0004DEF7
			public unsafe static Func<int, int, int> __9__78_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__78_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__78_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700311C RID: 12572
			// (get) Token: 0x0600939B RID: 37787 RVA: 0x0027DD90 File Offset: 0x0027BF90
			// (set) Token: 0x0600939C RID: 37788 RVA: 0x0004FD09 File Offset: 0x0004DF09
			public unsafe static Func<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise, bool> __9__81_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__81_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__81_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700311D RID: 12573
			// (get) Token: 0x0600939D RID: 37789 RVA: 0x0027DDB8 File Offset: 0x0027BFB8
			// (set) Token: 0x0600939E RID: 37790 RVA: 0x0004FD1B File Offset: 0x0004DF1B
			public unsafe static Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, Product> __9__91_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__91_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, Product>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__91_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700311E RID: 12574
			// (get) Token: 0x0600939F RID: 37791 RVA: 0x0027DDE0 File Offset: 0x0027BFE0
			// (set) Token: 0x060093A0 RID: 37792 RVA: 0x0004FD2D File Offset: 0x0004DF2D
			public unsafe static Action<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> __9__91_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__91_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__91_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700311F RID: 12575
			// (get) Token: 0x060093A1 RID: 37793 RVA: 0x0027DE08 File Offset: 0x0027C008
			// (set) Token: 0x060093A2 RID: 37794 RVA: 0x0004FD3F File Offset: 0x0004DF3F
			public unsafe static Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, Product> __9__91_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__91_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, Product>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__91_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003120 RID: 12576
			// (get) Token: 0x060093A3 RID: 37795 RVA: 0x0027DE30 File Offset: 0x0027C030
			// (set) Token: 0x060093A4 RID: 37796 RVA: 0x0004FD51 File Offset: 0x0004DF51
			public unsafe static Action<Product> __9__91_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__91_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Product>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__91_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003121 RID: 12577
			// (get) Token: 0x060093A5 RID: 37797 RVA: 0x0027DE58 File Offset: 0x0027C058
			// (set) Token: 0x060093A6 RID: 37798 RVA: 0x0004FD63 File Offset: 0x0004DF63
			public unsafe static Func<int, KeyValuePair<Recipe, int>> __9__95_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, KeyValuePair<Recipe, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003122 RID: 12578
			// (get) Token: 0x060093A7 RID: 37799 RVA: 0x0027DE80 File Offset: 0x0027C080
			// (set) Token: 0x060093A8 RID: 37800 RVA: 0x0004FD75 File Offset: 0x0004DF75
			public unsafe static Func<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency, bool> __9__95_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003123 RID: 12579
			// (get) Token: 0x060093A9 RID: 37801 RVA: 0x0027DEA8 File Offset: 0x0027C0A8
			// (set) Token: 0x060093AA RID: 37802 RVA: 0x0004FD87 File Offset: 0x0004DF87
			public unsafe static Func<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency, bool> __9__95_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003124 RID: 12580
			// (get) Token: 0x060093AB RID: 37803 RVA: 0x0027DED0 File Offset: 0x0027C0D0
			// (set) Token: 0x060093AC RID: 37804 RVA: 0x0004FD99 File Offset: 0x0004DF99
			public unsafe static Action<TextMeshProUGUI> __9__95_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003125 RID: 12581
			// (get) Token: 0x060093AD RID: 37805 RVA: 0x0027DEF8 File Offset: 0x0027C0F8
			// (set) Token: 0x060093AE RID: 37806 RVA: 0x0004FDAB File Offset: 0x0004DFAB
			public unsafe static Action<TextMeshProUGUI> __9__95_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003126 RID: 12582
			// (get) Token: 0x060093AF RID: 37807 RVA: 0x0027DF20 File Offset: 0x0027C120
			// (set) Token: 0x060093B0 RID: 37808 RVA: 0x0004FDBD File Offset: 0x0004DFBD
			public unsafe static Action<TextMeshProUGUI> __9__95_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003127 RID: 12583
			// (get) Token: 0x060093B1 RID: 37809 RVA: 0x0027DF48 File Offset: 0x0027C148
			// (set) Token: 0x060093B2 RID: 37810 RVA: 0x0004FDCF File Offset: 0x0004DFCF
			public unsafe static Action<TextMeshProUGUI> __9__95_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneKourindoShopPannel.__c.NativeFieldInfoPtr___9__95_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005FB2 RID: 24498
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005FB3 RID: 24499
			private static readonly IntPtr NativeFieldInfoPtr___9__60_0;

			// Token: 0x04005FB4 RID: 24500
			private static readonly IntPtr NativeFieldInfoPtr___9__62_0;

			// Token: 0x04005FB5 RID: 24501
			private static readonly IntPtr NativeFieldInfoPtr___9__64_0;

			// Token: 0x04005FB6 RID: 24502
			private static readonly IntPtr NativeFieldInfoPtr___9__66_0;

			// Token: 0x04005FB7 RID: 24503
			private static readonly IntPtr NativeFieldInfoPtr___9__68_0;

			// Token: 0x04005FB8 RID: 24504
			private static readonly IntPtr NativeFieldInfoPtr___9__69_3;

			// Token: 0x04005FB9 RID: 24505
			private static readonly IntPtr NativeFieldInfoPtr___9__69_4;

			// Token: 0x04005FBA RID: 24506
			private static readonly IntPtr NativeFieldInfoPtr___9__69_5;

			// Token: 0x04005FBB RID: 24507
			private static readonly IntPtr NativeFieldInfoPtr___9__78_0;

			// Token: 0x04005FBC RID: 24508
			private static readonly IntPtr NativeFieldInfoPtr___9__81_0;

			// Token: 0x04005FBD RID: 24509
			private static readonly IntPtr NativeFieldInfoPtr___9__91_0;

			// Token: 0x04005FBE RID: 24510
			private static readonly IntPtr NativeFieldInfoPtr___9__91_1;

			// Token: 0x04005FBF RID: 24511
			private static readonly IntPtr NativeFieldInfoPtr___9__91_2;

			// Token: 0x04005FC0 RID: 24512
			private static readonly IntPtr NativeFieldInfoPtr___9__91_3;

			// Token: 0x04005FC1 RID: 24513
			private static readonly IntPtr NativeFieldInfoPtr___9__95_5;

			// Token: 0x04005FC2 RID: 24514
			private static readonly IntPtr NativeFieldInfoPtr___9__95_1;

			// Token: 0x04005FC3 RID: 24515
			private static readonly IntPtr NativeFieldInfoPtr___9__95_2;

			// Token: 0x04005FC4 RID: 24516
			private static readonly IntPtr NativeFieldInfoPtr___9__95_7;

			// Token: 0x04005FC5 RID: 24517
			private static readonly IntPtr NativeFieldInfoPtr___9__95_8;

			// Token: 0x04005FC6 RID: 24518
			private static readonly IntPtr NativeFieldInfoPtr___9__95_11;

			// Token: 0x04005FC7 RID: 24519
			private static readonly IntPtr NativeFieldInfoPtr___9__95_12;

			// Token: 0x04005FC8 RID: 24520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005FC9 RID: 24521
			private static readonly IntPtr NativeMethodInfoPtr__get_DailyKourindouProducts_b__60_0_Internal_Boolean_KourindouStaticMerchandiseKey_0;

			// Token: 0x04005FCA RID: 24522
			private static readonly IntPtr NativeMethodInfoPtr__get_StaticCookerKourindouProducts_b__62_0_Internal_Boolean_KourindouStaticMerchandiseKey_0;

			// Token: 0x04005FCB RID: 24523
			private static readonly IntPtr NativeMethodInfoPtr__get_StaticOtherKourindouProducts_b__64_0_Internal_Boolean_KourindouStaticMerchandiseKey_0;

			// Token: 0x04005FCC RID: 24524
			private static readonly IntPtr NativeMethodInfoPtr__get_DailyKourindouProductsInCart_b__66_0_Internal_Boolean_KourindouStaticMerchandiseKey_0;

			// Token: 0x04005FCD RID: 24525
			private static readonly IntPtr NativeMethodInfoPtr__get_StaticKourindouProductsInCart_b__68_0_Internal_Boolean_KourindouStaticMerchandiseKey_0;

			// Token: 0x04005FCE RID: 24526
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__69_3_Internal_String_Il2CppStringArray_0;

			// Token: 0x04005FCF RID: 24527
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__69_4_Internal_String_Il2CppStringArray_0;

			// Token: 0x04005FD0 RID: 24528
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__69_5_Internal_String_Il2CppStringArray_0;

			// Token: 0x04005FD1 RID: 24529
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCartElements_b__78_0_Internal_Int32_Int32_Int32_0;

			// Token: 0x04005FD2 RID: 24530
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__81_0_Internal_Boolean_KourindoStaticMerchandise_0;

			// Token: 0x04005FD3 RID: 24531
			private static readonly IntPtr NativeMethodInfoPtr__Pay_b__91_0_Internal_Product_KourindouStaticMerchandiseKey_0;

			// Token: 0x04005FD4 RID: 24532
			private static readonly IntPtr NativeMethodInfoPtr__Pay_b__91_1_Internal_Void_KourindouStaticMerchandiseKey_0;

			// Token: 0x04005FD5 RID: 24533
			private static readonly IntPtr NativeMethodInfoPtr__Pay_b__91_2_Internal_Product_KourindouStaticMerchandiseKey_0;

			// Token: 0x04005FD6 RID: 24534
			private static readonly IntPtr NativeMethodInfoPtr__Pay_b__91_3_Internal_Void_Product_0;

			// Token: 0x04005FD7 RID: 24535
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__95_5_Internal_KeyValuePair_2_Recipe_Int32_Int32_0;

			// Token: 0x04005FD8 RID: 24536
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__95_1_Internal_Boolean_Currency_0;

			// Token: 0x04005FD9 RID: 24537
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__95_2_Internal_Boolean_Currency_0;

			// Token: 0x04005FDA RID: 24538
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__95_7_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04005FDB RID: 24539
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__95_8_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04005FDC RID: 24540
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__95_11_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04005FDD RID: 24541
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__95_12_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x0200064F RID: 1615
		[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+<SelectAllCoroutine>d__72")]
		public sealed class _SelectAllCoroutine_d__72 : Il2CppSystem.Object
		{
			// Token: 0x060093B3 RID: 37811 RVA: 0x0027DF70 File Offset: 0x0027C170
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectAllCoroutine_d__72()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel._SelectAllCoroutine_d__72>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<SelectAllCoroutine>d__72");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel._SelectAllCoroutine_d__72>.NativeClassPtr);
				DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel._SelectAllCoroutine_d__72>.NativeClassPtr, "<>1__state");
				DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel._SelectAllCoroutine_d__72>.NativeClassPtr, "<>2__current");
				DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel._SelectAllCoroutine_d__72>.NativeClassPtr, "<>4__this");
				DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel._SelectAllCoroutine_d__72>.NativeClassPtr, 100667405);
				DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel._SelectAllCoroutine_d__72>.NativeClassPtr, 100667406);
				DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel._SelectAllCoroutine_d__72>.NativeClassPtr, 100667407);
				DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel._SelectAllCoroutine_d__72>.NativeClassPtr, 100667408);
				DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel._SelectAllCoroutine_d__72>.NativeClassPtr, 100667409);
				DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel._SelectAllCoroutine_d__72>.NativeClassPtr, 100667410);
			}

			// Token: 0x060093B4 RID: 37812 RVA: 0x0027E050 File Offset: 0x0027C250
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectAllCoroutine_d__72(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel._SelectAllCoroutine_d__72>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093B5 RID: 37813 RVA: 0x0027E098 File Offset: 0x0027C298
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093B6 RID: 37814 RVA: 0x0027E0CC File Offset: 0x0027C2CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63184, XrefRangeEnd = 63189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700312B RID: 12587
			// (get) Token: 0x060093B7 RID: 37815 RVA: 0x0027E108 File Offset: 0x0027C308
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060093B8 RID: 37816 RVA: 0x0027E148 File Offset: 0x0027C348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63189, XrefRangeEnd = 63195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700312C RID: 12588
			// (get) Token: 0x060093B9 RID: 37817 RVA: 0x0027E17C File Offset: 0x0027C37C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060093BA RID: 37818 RVA: 0x0004FDE1 File Offset: 0x0004DFE1
			public _SelectAllCoroutine_d__72(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003128 RID: 12584
			// (get) Token: 0x060093BB RID: 37819 RVA: 0x0027E1BC File Offset: 0x0027C3BC
			// (set) Token: 0x060093BC RID: 37820 RVA: 0x0004FDEA File Offset: 0x0004DFEA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003129 RID: 12585
			// (get) Token: 0x060093BD RID: 37821 RVA: 0x0027E1E4 File Offset: 0x0027C3E4
			// (set) Token: 0x060093BE RID: 37822 RVA: 0x0004FE05 File Offset: 0x0004E005
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700312A RID: 12586
			// (get) Token: 0x060093BF RID: 37823 RVA: 0x0027E214 File Offset: 0x0027C414
			// (set) Token: 0x060093C0 RID: 37824 RVA: 0x0004FE24 File Offset: 0x0004E024
			public unsafe DaySceneKourindoShopPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneKourindoShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel._SelectAllCoroutine_d__72.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005FDE RID: 24542
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005FDF RID: 24543
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005FE0 RID: 24544
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005FE1 RID: 24545
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005FE2 RID: 24546
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005FE3 RID: 24547
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005FE4 RID: 24548
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005FE5 RID: 24549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005FE6 RID: 24550
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000650 RID: 1616
		[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+<>c__DisplayClass78_0")]
		public sealed class __c__DisplayClass78_0 : Il2CppSystem.Object
		{
			// Token: 0x060093C1 RID: 37825 RVA: 0x0027E244 File Offset: 0x0027C444
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_0()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<>c__DisplayClass78_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_0>.NativeClassPtr);
				DaySceneKourindoShopPannel.__c__DisplayClass78_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_0>.NativeClassPtr, "<>4__this");
				DaySceneKourindoShopPannel.__c__DisplayClass78_0.NativeFieldInfoPtr_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_0>.NativeClassPtr, "total");
				DaySceneKourindoShopPannel.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_0>.NativeClassPtr, 100667411);
				DaySceneKourindoShopPannel.__c__DisplayClass78_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_KeyValuePair_2_KeyValuePair_2_CurrencyType_Int32_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_0>.NativeClassPtr, 100667412);
				DaySceneKourindoShopPannel.__c__DisplayClass78_0.NativeMethodInfoPtr__UpdateCartElements_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_0>.NativeClassPtr, 100667413);
			}

			// Token: 0x060093C2 RID: 37826 RVA: 0x0027E2D4 File Offset: 0x0027C4D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093C3 RID: 37827 RVA: 0x0027E310 File Offset: 0x0027C510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63195, XrefRangeEnd = 63238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UIElementCluster_KeyValuePair_2_KeyValuePair_2_CurrencyType_Int32_Int32_PDM_0(UIElementCluster cluster, KeyValuePair<KeyValuePair<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.CurrencyType, int>, int> currencyData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(currencyData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass78_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_KeyValuePair_2_KeyValuePair_2_CurrencyType_Int32_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093C4 RID: 37828 RVA: 0x0027E36C File Offset: 0x0027C56C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63238, XrefRangeEnd = 63240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCartElements_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass78_0.NativeMethodInfoPtr__UpdateCartElements_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093C5 RID: 37829 RVA: 0x0004FE43 File Offset: 0x0004E043
			public __c__DisplayClass78_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700312D RID: 12589
			// (get) Token: 0x060093C6 RID: 37830 RVA: 0x0027E3A0 File Offset: 0x0027C5A0
			// (set) Token: 0x060093C7 RID: 37831 RVA: 0x0004FE4C File Offset: 0x0004E04C
			public unsafe DaySceneKourindoShopPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass78_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneKourindoShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass78_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700312E RID: 12590
			// (get) Token: 0x060093C8 RID: 37832 RVA: 0x0027E3D0 File Offset: 0x0027C5D0
			// (set) Token: 0x060093C9 RID: 37833 RVA: 0x0004FE6B File Offset: 0x0004E06B
			public unsafe int total
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass78_0.NativeFieldInfoPtr_total);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass78_0.NativeFieldInfoPtr_total)) = value;
				}
			}

			// Token: 0x04005FE7 RID: 24551
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005FE8 RID: 24552
			private static readonly IntPtr NativeFieldInfoPtr_total;

			// Token: 0x04005FE9 RID: 24553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005FEA RID: 24554
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_KeyValuePair_2_KeyValuePair_2_CurrencyType_Int32_Int32_PDM_0;

			// Token: 0x04005FEB RID: 24555
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCartElements_b__2_Internal_Void_0;
		}

		// Token: 0x02000651 RID: 1617
		[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+<>c__DisplayClass78_1")]
		public sealed class __c__DisplayClass78_1 : Il2CppSystem.Object
		{
			// Token: 0x060093CA RID: 37834 RVA: 0x0027E3F8 File Offset: 0x0027C5F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_1()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<>c__DisplayClass78_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_1>.NativeClassPtr);
				DaySceneKourindoShopPannel.__c__DisplayClass78_1.NativeFieldInfoPtr_currencyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_1>.NativeClassPtr, "currencyData");
				DaySceneKourindoShopPannel.__c__DisplayClass78_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_1>.NativeClassPtr, 100667414);
				DaySceneKourindoShopPannel.__c__DisplayClass78_1.NativeMethodInfoPtr__UpdateCartElements_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_1>.NativeClassPtr, 100667415);
				DaySceneKourindoShopPannel.__c__DisplayClass78_1.NativeMethodInfoPtr__UpdateCartElements_b__6_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_1>.NativeClassPtr, 100667416);
				DaySceneKourindoShopPannel.__c__DisplayClass78_1.NativeMethodInfoPtr__UpdateCartElements_b__7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_1>.NativeClassPtr, 100667417);
				DaySceneKourindoShopPannel.__c__DisplayClass78_1.NativeMethodInfoPtr__UpdateCartElements_b__10_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_1>.NativeClassPtr, 100667418);
			}

			// Token: 0x060093CB RID: 37835 RVA: 0x0027E49C File Offset: 0x0027C69C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass78_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093CC RID: 37836 RVA: 0x0027E4D8 File Offset: 0x0027C6D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63240, XrefRangeEnd = 63246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCartElements_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass78_1.NativeMethodInfoPtr__UpdateCartElements_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093CD RID: 37837 RVA: 0x0027E51C File Offset: 0x0027C71C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63246, XrefRangeEnd = 63251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCartElements_b__6(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass78_1.NativeMethodInfoPtr__UpdateCartElements_b__6_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093CE RID: 37838 RVA: 0x0027E560 File Offset: 0x0027C760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63251, XrefRangeEnd = 63257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCartElements_b__7(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass78_1.NativeMethodInfoPtr__UpdateCartElements_b__7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093CF RID: 37839 RVA: 0x0027E5A4 File Offset: 0x0027C7A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63257, XrefRangeEnd = 63262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCartElements_b__10(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass78_1.NativeMethodInfoPtr__UpdateCartElements_b__10_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093D0 RID: 37840 RVA: 0x0004FE86 File Offset: 0x0004E086
			public __c__DisplayClass78_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700312F RID: 12591
			// (get) Token: 0x060093D1 RID: 37841 RVA: 0x0027E5E8 File Offset: 0x0027C7E8
			// (set) Token: 0x060093D2 RID: 37842 RVA: 0x0004FE8F File Offset: 0x0004E08F
			public KeyValuePair<KeyValuePair<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.CurrencyType, int>, int> currencyData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass78_1.NativeFieldInfoPtr_currencyData);
					return new KeyValuePair<KeyValuePair<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.CurrencyType, int>, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<KeyValuePair<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.CurrencyType, int>, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass78_1.NativeFieldInfoPtr_currencyData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<KeyValuePair<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.CurrencyType, int>, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005FEC RID: 24556
			private static readonly IntPtr NativeFieldInfoPtr_currencyData;

			// Token: 0x04005FED RID: 24557
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005FEE RID: 24558
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCartElements_b__3_Internal_Void_Image_0;

			// Token: 0x04005FEF RID: 24559
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCartElements_b__6_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04005FF0 RID: 24560
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCartElements_b__7_Internal_Void_Image_0;

			// Token: 0x04005FF1 RID: 24561
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCartElements_b__10_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000652 RID: 1618
		[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+<>c__DisplayClass78_2")]
		public sealed class __c__DisplayClass78_2 : Il2CppSystem.Object
		{
			// Token: 0x060093D3 RID: 37843 RVA: 0x0027E618 File Offset: 0x0027C818
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_2()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<>c__DisplayClass78_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_2>.NativeClassPtr);
				DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeFieldInfoPtr_itemCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_2>.NativeClassPtr, "itemCount");
				DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeFieldInfoPtr_cookerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_2>.NativeClassPtr, "cookerCount");
				DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_2>.NativeClassPtr, 100667419);
				DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeMethodInfoPtr__UpdateCartElements_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_2>.NativeClassPtr, 100667420);
				DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeMethodInfoPtr__UpdateCartElements_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_2>.NativeClassPtr, 100667421);
				DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeMethodInfoPtr__UpdateCartElements_b__8_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_2>.NativeClassPtr, 100667422);
				DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeMethodInfoPtr__UpdateCartElements_b__9_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_2>.NativeClassPtr, 100667423);
			}

			// Token: 0x060093D4 RID: 37844 RVA: 0x0027E6D0 File Offset: 0x0027C8D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass78_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093D5 RID: 37845 RVA: 0x0027E70C File Offset: 0x0027C90C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63262, XrefRangeEnd = 63264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCartElements_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeMethodInfoPtr__UpdateCartElements_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093D6 RID: 37846 RVA: 0x0027E750 File Offset: 0x0027C950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCartElements_b__5(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeMethodInfoPtr__UpdateCartElements_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093D7 RID: 37847 RVA: 0x0027E794 File Offset: 0x0027C994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63264, XrefRangeEnd = 63266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCartElements_b__8(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeMethodInfoPtr__UpdateCartElements_b__8_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093D8 RID: 37848 RVA: 0x0027E7D8 File Offset: 0x0027C9D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCartElements_b__9(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeMethodInfoPtr__UpdateCartElements_b__9_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093D9 RID: 37849 RVA: 0x0004FEBD File Offset: 0x0004E0BD
			public __c__DisplayClass78_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003130 RID: 12592
			// (get) Token: 0x060093DA RID: 37850 RVA: 0x0027E81C File Offset: 0x0027CA1C
			// (set) Token: 0x060093DB RID: 37851 RVA: 0x0004FEC6 File Offset: 0x0004E0C6
			public unsafe int itemCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeFieldInfoPtr_itemCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeFieldInfoPtr_itemCount)) = value;
				}
			}

			// Token: 0x17003131 RID: 12593
			// (get) Token: 0x060093DC RID: 37852 RVA: 0x0027E844 File Offset: 0x0027CA44
			// (set) Token: 0x060093DD RID: 37853 RVA: 0x0004FEE1 File Offset: 0x0004E0E1
			public unsafe int cookerCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeFieldInfoPtr_cookerCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass78_2.NativeFieldInfoPtr_cookerCount)) = value;
				}
			}

			// Token: 0x04005FF2 RID: 24562
			private static readonly IntPtr NativeFieldInfoPtr_itemCount;

			// Token: 0x04005FF3 RID: 24563
			private static readonly IntPtr NativeFieldInfoPtr_cookerCount;

			// Token: 0x04005FF4 RID: 24564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005FF5 RID: 24565
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCartElements_b__4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04005FF6 RID: 24566
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCartElements_b__5_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04005FF7 RID: 24567
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCartElements_b__8_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04005FF8 RID: 24568
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCartElements_b__9_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000653 RID: 1619
		[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : Il2CppSystem.Object
		{
			// Token: 0x060093DE RID: 37854 RVA: 0x0027E86C File Offset: 0x0027CA6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr);
				DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr_shelfProductData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr, "shelfProductData");
				DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr, "sprite");
				DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr_productAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr, "productAmount");
				DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr_bgSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr, "bgSprite");
				DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr, "<>9__2");
				DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr, "<>9__3");
				DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr, "<>9__4");
				DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr, 100667424);
				DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr, 100667425);
				DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__1_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr, 100667426);
				DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr, 100667427);
				DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr, 100667428);
				DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr, 100667429);
			}

			// Token: 0x060093DF RID: 37855 RVA: 0x0027E99C File Offset: 0x0027CB9C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass83_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093E0 RID: 37856 RVA: 0x0027E9D8 File Offset: 0x0027CBD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63266, XrefRangeEnd = 63267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShelfElementEnabled_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093E1 RID: 37857 RVA: 0x0027EA1C File Offset: 0x0027CC1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63267, XrefRangeEnd = 63292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShelfElementEnabled_b__1(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__1_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093E2 RID: 37858 RVA: 0x0027EA60 File Offset: 0x0027CC60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63292, XrefRangeEnd = 63294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShelfElementEnabled_b__2(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093E3 RID: 37859 RVA: 0x0027EAA4 File Offset: 0x0027CCA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63294, XrefRangeEnd = 63296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShelfElementEnabled_b__3(TextMeshProUGUI y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093E4 RID: 37860 RVA: 0x0027EAE8 File Offset: 0x0027CCE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShelfElementEnabled_b__4(TextMeshProUGUI y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093E5 RID: 37861 RVA: 0x0004FEFC File Offset: 0x0004E0FC
			public __c__DisplayClass83_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003132 RID: 12594
			// (get) Token: 0x060093E6 RID: 37862 RVA: 0x0027EB2C File Offset: 0x0027CD2C
			// (set) Token: 0x060093E7 RID: 37863 RVA: 0x0004FF05 File Offset: 0x0004E105
			public DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey shelfProductData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr_shelfProductData);
					return new DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr_shelfProductData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003133 RID: 12595
			// (get) Token: 0x060093E8 RID: 37864 RVA: 0x0027EB5C File Offset: 0x0027CD5C
			// (set) Token: 0x060093E9 RID: 37865 RVA: 0x0004FF33 File Offset: 0x0004E133
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003134 RID: 12596
			// (get) Token: 0x060093EA RID: 37866 RVA: 0x0027EB8C File Offset: 0x0027CD8C
			// (set) Token: 0x060093EB RID: 37867 RVA: 0x0004FF52 File Offset: 0x0004E152
			public unsafe int productAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr_productAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr_productAmount)) = value;
				}
			}

			// Token: 0x17003135 RID: 12597
			// (get) Token: 0x060093EC RID: 37868 RVA: 0x0027EBB4 File Offset: 0x0027CDB4
			// (set) Token: 0x060093ED RID: 37869 RVA: 0x0004FF6D File Offset: 0x0004E16D
			public unsafe Sprite bgSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr_bgSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr_bgSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003136 RID: 12598
			// (get) Token: 0x060093EE RID: 37870 RVA: 0x0027EBE4 File Offset: 0x0027CDE4
			// (set) Token: 0x060093EF RID: 37871 RVA: 0x0004FF8C File Offset: 0x0004E18C
			public unsafe Action<Image> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003137 RID: 12599
			// (get) Token: 0x060093F0 RID: 37872 RVA: 0x0027EC14 File Offset: 0x0027CE14
			// (set) Token: 0x060093F1 RID: 37873 RVA: 0x0004FFAB File Offset: 0x0004E1AB
			public unsafe Action<TextMeshProUGUI> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003138 RID: 12600
			// (get) Token: 0x060093F2 RID: 37874 RVA: 0x0027EC44 File Offset: 0x0027CE44
			// (set) Token: 0x060093F3 RID: 37875 RVA: 0x0004FFCA File Offset: 0x0004E1CA
			public unsafe Action<TextMeshProUGUI> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass83_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005FF9 RID: 24569
			private static readonly IntPtr NativeFieldInfoPtr_shelfProductData;

			// Token: 0x04005FFA RID: 24570
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x04005FFB RID: 24571
			private static readonly IntPtr NativeFieldInfoPtr_productAmount;

			// Token: 0x04005FFC RID: 24572
			private static readonly IntPtr NativeFieldInfoPtr_bgSprite;

			// Token: 0x04005FFD RID: 24573
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04005FFE RID: 24574
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x04005FFF RID: 24575
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04006000 RID: 24576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006001 RID: 24577
			private static readonly IntPtr NativeMethodInfoPtr__OnShelfElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006002 RID: 24578
			private static readonly IntPtr NativeMethodInfoPtr__OnShelfElementEnabled_b__1_Internal_Void_UIElementCluster_0;

			// Token: 0x04006003 RID: 24579
			private static readonly IntPtr NativeMethodInfoPtr__OnShelfElementEnabled_b__2_Internal_Void_Image_0;

			// Token: 0x04006004 RID: 24580
			private static readonly IntPtr NativeMethodInfoPtr__OnShelfElementEnabled_b__3_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006005 RID: 24581
			private static readonly IntPtr NativeMethodInfoPtr__OnShelfElementEnabled_b__4_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000654 RID: 1620
		[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+<>c__DisplayClass84_0")]
		public sealed class __c__DisplayClass84_0 : Il2CppSystem.Object
		{
			// Token: 0x060093F4 RID: 37876 RVA: 0x0027EC74 File Offset: 0x0027CE74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass84_0()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass84_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<>c__DisplayClass84_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass84_0>.NativeClassPtr);
				DaySceneKourindoShopPannel.__c__DisplayClass84_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass84_0>.NativeClassPtr, "<>4__this");
				DaySceneKourindoShopPannel.__c__DisplayClass84_0.NativeFieldInfoPtr_shelfProductData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass84_0>.NativeClassPtr, "shelfProductData");
				DaySceneKourindoShopPannel.__c__DisplayClass84_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass84_0>.NativeClassPtr, 100667430);
				DaySceneKourindoShopPannel.__c__DisplayClass84_0.NativeMethodInfoPtr__OnShelfElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass84_0>.NativeClassPtr, 100667431);
				DaySceneKourindoShopPannel.__c__DisplayClass84_0.NativeMethodInfoPtr__OnShelfElementSelected_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass84_0>.NativeClassPtr, 100667432);
			}

			// Token: 0x060093F5 RID: 37877 RVA: 0x0027ED04 File Offset: 0x0027CF04
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass84_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass84_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass84_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093F6 RID: 37878 RVA: 0x0027ED40 File Offset: 0x0027CF40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63296, XrefRangeEnd = 63297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShelfElementSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass84_0.NativeMethodInfoPtr__OnShelfElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093F7 RID: 37879 RVA: 0x0027ED74 File Offset: 0x0027CF74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63297, XrefRangeEnd = 63298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShelfElementSelected_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass84_0.NativeMethodInfoPtr__OnShelfElementSelected_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093F8 RID: 37880 RVA: 0x0004FFE9 File Offset: 0x0004E1E9
			public __c__DisplayClass84_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003139 RID: 12601
			// (get) Token: 0x060093F9 RID: 37881 RVA: 0x0027EDA8 File Offset: 0x0027CFA8
			// (set) Token: 0x060093FA RID: 37882 RVA: 0x0004FFF2 File Offset: 0x0004E1F2
			public unsafe DaySceneKourindoShopPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass84_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneKourindoShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass84_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700313A RID: 12602
			// (get) Token: 0x060093FB RID: 37883 RVA: 0x0027EDD8 File Offset: 0x0027CFD8
			// (set) Token: 0x060093FC RID: 37884 RVA: 0x00050011 File Offset: 0x0004E211
			public DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey shelfProductData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass84_0.NativeFieldInfoPtr_shelfProductData);
					return new DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass84_0.NativeFieldInfoPtr_shelfProductData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006006 RID: 24582
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006007 RID: 24583
			private static readonly IntPtr NativeFieldInfoPtr_shelfProductData;

			// Token: 0x04006008 RID: 24584
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006009 RID: 24585
			private static readonly IntPtr NativeMethodInfoPtr__OnShelfElementSelected_b__0_Internal_Void_0;

			// Token: 0x0400600A RID: 24586
			private static readonly IntPtr NativeMethodInfoPtr__OnShelfElementSelected_b__1_Internal_Void_0;
		}

		// Token: 0x02000655 RID: 1621
		[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+<>c__DisplayClass85_0")]
		public sealed class __c__DisplayClass85_0 : Il2CppSystem.Object
		{
			// Token: 0x060093FD RID: 37885 RVA: 0x0027EE08 File Offset: 0x0027D008
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass85_0()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<>c__DisplayClass85_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr);
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, "price");
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, "sprite");
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr_productAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, "productAmount");
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr_bgSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, "bgSprite");
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, "<>9__3");
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, "<>9__4");
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, "<>9__5");
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, 100667433);
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__OnCartElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, 100667434);
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__OnCartElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, 100667435);
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__OnCartElementEnabled_b__2_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, 100667436);
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__OnCartElementEnabled_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, 100667437);
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__OnCartElementEnabled_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, 100667438);
				DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__OnCartElementEnabled_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr, 100667439);
			}

			// Token: 0x060093FE RID: 37886 RVA: 0x0027EF4C File Offset: 0x0027D14C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass85_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass85_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060093FF RID: 37887 RVA: 0x0027EF88 File Offset: 0x0027D188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementEnabled_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__OnCartElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009400 RID: 37888 RVA: 0x0027EFCC File Offset: 0x0027D1CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementEnabled_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__OnCartElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009401 RID: 37889 RVA: 0x0027F010 File Offset: 0x0027D210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63298, XrefRangeEnd = 63323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementEnabled_b__2(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__OnCartElementEnabled_b__2_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009402 RID: 37890 RVA: 0x0027F054 File Offset: 0x0027D254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63323, XrefRangeEnd = 63325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementEnabled_b__3(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__OnCartElementEnabled_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009403 RID: 37891 RVA: 0x0027F098 File Offset: 0x0027D298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63325, XrefRangeEnd = 63327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementEnabled_b__4(TextMeshProUGUI y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__OnCartElementEnabled_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009404 RID: 37892 RVA: 0x0027F0DC File Offset: 0x0027D2DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementEnabled_b__5(TextMeshProUGUI y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeMethodInfoPtr__OnCartElementEnabled_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009405 RID: 37893 RVA: 0x0005003F File Offset: 0x0004E23F
			public __c__DisplayClass85_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700313B RID: 12603
			// (get) Token: 0x06009406 RID: 37894 RVA: 0x0027F120 File Offset: 0x0027D320
			// (set) Token: 0x06009407 RID: 37895 RVA: 0x00050048 File Offset: 0x0004E248
			public unsafe int price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr_price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr_price)) = value;
				}
			}

			// Token: 0x1700313C RID: 12604
			// (get) Token: 0x06009408 RID: 37896 RVA: 0x0027F148 File Offset: 0x0027D348
			// (set) Token: 0x06009409 RID: 37897 RVA: 0x00050063 File Offset: 0x0004E263
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700313D RID: 12605
			// (get) Token: 0x0600940A RID: 37898 RVA: 0x0027F178 File Offset: 0x0027D378
			// (set) Token: 0x0600940B RID: 37899 RVA: 0x00050082 File Offset: 0x0004E282
			public unsafe int productAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr_productAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr_productAmount)) = value;
				}
			}

			// Token: 0x1700313E RID: 12606
			// (get) Token: 0x0600940C RID: 37900 RVA: 0x0027F1A0 File Offset: 0x0027D3A0
			// (set) Token: 0x0600940D RID: 37901 RVA: 0x0005009D File Offset: 0x0004E29D
			public unsafe Sprite bgSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr_bgSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr_bgSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700313F RID: 12607
			// (get) Token: 0x0600940E RID: 37902 RVA: 0x0027F1D0 File Offset: 0x0027D3D0
			// (set) Token: 0x0600940F RID: 37903 RVA: 0x000500BC File Offset: 0x0004E2BC
			public unsafe Action<Image> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003140 RID: 12608
			// (get) Token: 0x06009410 RID: 37904 RVA: 0x0027F200 File Offset: 0x0027D400
			// (set) Token: 0x06009411 RID: 37905 RVA: 0x000500DB File Offset: 0x0004E2DB
			public unsafe Action<TextMeshProUGUI> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003141 RID: 12609
			// (get) Token: 0x06009412 RID: 37906 RVA: 0x0027F230 File Offset: 0x0027D430
			// (set) Token: 0x06009413 RID: 37907 RVA: 0x000500FA File Offset: 0x0004E2FA
			public unsafe Action<TextMeshProUGUI> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass85_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400600B RID: 24587
			private static readonly IntPtr NativeFieldInfoPtr_price;

			// Token: 0x0400600C RID: 24588
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x0400600D RID: 24589
			private static readonly IntPtr NativeFieldInfoPtr_productAmount;

			// Token: 0x0400600E RID: 24590
			private static readonly IntPtr NativeFieldInfoPtr_bgSprite;

			// Token: 0x0400600F RID: 24591
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x04006010 RID: 24592
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04006011 RID: 24593
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x04006012 RID: 24594
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006013 RID: 24595
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006014 RID: 24596
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006015 RID: 24597
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementEnabled_b__2_Internal_Void_UIElementCluster_0;

			// Token: 0x04006016 RID: 24598
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementEnabled_b__3_Internal_Void_Image_0;

			// Token: 0x04006017 RID: 24599
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementEnabled_b__4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006018 RID: 24600
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementEnabled_b__5_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000656 RID: 1622
		[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+<>c__DisplayClass86_0")]
		public sealed class __c__DisplayClass86_0 : Il2CppSystem.Object
		{
			// Token: 0x06009414 RID: 37908 RVA: 0x0027F260 File Offset: 0x0027D460
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass86_0()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass86_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<>c__DisplayClass86_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass86_0>.NativeClassPtr);
				DaySceneKourindoShopPannel.__c__DisplayClass86_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass86_0>.NativeClassPtr, "<>4__this");
				DaySceneKourindoShopPannel.__c__DisplayClass86_0.NativeFieldInfoPtr_cartProductData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass86_0>.NativeClassPtr, "cartProductData");
				DaySceneKourindoShopPannel.__c__DisplayClass86_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass86_0>.NativeClassPtr, 100667440);
				DaySceneKourindoShopPannel.__c__DisplayClass86_0.NativeMethodInfoPtr__OnCartElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass86_0>.NativeClassPtr, 100667441);
				DaySceneKourindoShopPannel.__c__DisplayClass86_0.NativeMethodInfoPtr__OnCartElementSelected_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass86_0>.NativeClassPtr, 100667442);
			}

			// Token: 0x06009415 RID: 37909 RVA: 0x0027F2F0 File Offset: 0x0027D4F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass86_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass86_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass86_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009416 RID: 37910 RVA: 0x0027F32C File Offset: 0x0027D52C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63327, XrefRangeEnd = 63328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass86_0.NativeMethodInfoPtr__OnCartElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009417 RID: 37911 RVA: 0x0027F360 File Offset: 0x0027D560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63328, XrefRangeEnd = 63329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementSelected_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass86_0.NativeMethodInfoPtr__OnCartElementSelected_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009418 RID: 37912 RVA: 0x00050119 File Offset: 0x0004E319
			public __c__DisplayClass86_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003142 RID: 12610
			// (get) Token: 0x06009419 RID: 37913 RVA: 0x0027F394 File Offset: 0x0027D594
			// (set) Token: 0x0600941A RID: 37914 RVA: 0x00050122 File Offset: 0x0004E322
			public unsafe DaySceneKourindoShopPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass86_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneKourindoShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass86_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003143 RID: 12611
			// (get) Token: 0x0600941B RID: 37915 RVA: 0x0027F3C4 File Offset: 0x0027D5C4
			// (set) Token: 0x0600941C RID: 37916 RVA: 0x00050141 File Offset: 0x0004E341
			public DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey cartProductData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass86_0.NativeFieldInfoPtr_cartProductData);
					return new DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass86_0.NativeFieldInfoPtr_cartProductData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006019 RID: 24601
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400601A RID: 24602
			private static readonly IntPtr NativeFieldInfoPtr_cartProductData;

			// Token: 0x0400601B RID: 24603
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400601C RID: 24604
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementSelected_b__0_Internal_Void_0;

			// Token: 0x0400601D RID: 24605
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementSelected_b__1_Internal_Void_0;
		}

		// Token: 0x02000657 RID: 1623
		[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+<>c__DisplayClass87_0")]
		public sealed class __c__DisplayClass87_0 : Il2CppSystem.Object
		{
			// Token: 0x0600941D RID: 37917 RVA: 0x0027F3F4 File Offset: 0x0027D5F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass87_0()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass87_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<>c__DisplayClass87_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass87_0>.NativeClassPtr);
				DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass87_0>.NativeClassPtr, "<>4__this");
				DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeFieldInfoPtr_thisProductData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass87_0>.NativeClassPtr, "thisProductData");
				DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass87_0>.NativeClassPtr, 100667443);
				DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeMethodInfoPtr__AddToCart_b__0_Internal_Boolean_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass87_0>.NativeClassPtr, 100667444);
				DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeMethodInfoPtr__AddToCart_b__2_Internal_Boolean_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass87_0>.NativeClassPtr, 100667445);
				DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeMethodInfoPtr__AddToCart_b__1_Internal_Boolean_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass87_0>.NativeClassPtr, 100667446);
				DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeMethodInfoPtr__AddToCart_b__3_Internal_Boolean_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass87_0>.NativeClassPtr, 100667447);
			}

			// Token: 0x0600941E RID: 37918 RVA: 0x0027F4AC File Offset: 0x0027D6AC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass87_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass87_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600941F RID: 37919 RVA: 0x0027F4E8 File Offset: 0x0027D6E8
			[CallerCount(0)]
			public unsafe bool _AddToCart_b__0(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeMethodInfoPtr__AddToCart_b__0_Internal_Boolean_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009420 RID: 37920 RVA: 0x0027F53C File Offset: 0x0027D73C
			[CallerCount(0)]
			public unsafe bool _AddToCart_b__2(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeMethodInfoPtr__AddToCart_b__2_Internal_Boolean_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009421 RID: 37921 RVA: 0x0027F590 File Offset: 0x0027D790
			[CallerCount(0)]
			public unsafe bool _AddToCart_b__1(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeMethodInfoPtr__AddToCart_b__1_Internal_Boolean_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009422 RID: 37922 RVA: 0x0027F5E4 File Offset: 0x0027D7E4
			[CallerCount(0)]
			public unsafe bool _AddToCart_b__3(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeMethodInfoPtr__AddToCart_b__3_Internal_Boolean_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009423 RID: 37923 RVA: 0x0005016F File Offset: 0x0004E36F
			public __c__DisplayClass87_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003144 RID: 12612
			// (get) Token: 0x06009424 RID: 37924 RVA: 0x0027F638 File Offset: 0x0027D838
			// (set) Token: 0x06009425 RID: 37925 RVA: 0x00050178 File Offset: 0x0004E378
			public unsafe DaySceneKourindoShopPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneKourindoShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003145 RID: 12613
			// (get) Token: 0x06009426 RID: 37926 RVA: 0x0027F668 File Offset: 0x0027D868
			// (set) Token: 0x06009427 RID: 37927 RVA: 0x00050197 File Offset: 0x0004E397
			public DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey thisProductData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeFieldInfoPtr_thisProductData);
					return new DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass87_0.NativeFieldInfoPtr_thisProductData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400601E RID: 24606
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400601F RID: 24607
			private static readonly IntPtr NativeFieldInfoPtr_thisProductData;

			// Token: 0x04006020 RID: 24608
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006021 RID: 24609
			private static readonly IntPtr NativeMethodInfoPtr__AddToCart_b__0_Internal_Boolean_KourindouStaticMerchandiseKey_0;

			// Token: 0x04006022 RID: 24610
			private static readonly IntPtr NativeMethodInfoPtr__AddToCart_b__2_Internal_Boolean_KourindouStaticMerchandiseKey_0;

			// Token: 0x04006023 RID: 24611
			private static readonly IntPtr NativeMethodInfoPtr__AddToCart_b__1_Internal_Boolean_KourindouStaticMerchandiseKey_0;

			// Token: 0x04006024 RID: 24612
			private static readonly IntPtr NativeMethodInfoPtr__AddToCart_b__3_Internal_Boolean_KourindouStaticMerchandiseKey_0;
		}

		// Token: 0x02000658 RID: 1624
		[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+<>c__DisplayClass88_0")]
		public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
		{
			// Token: 0x06009428 RID: 37928 RVA: 0x0027F698 File Offset: 0x0027D898
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass88_0()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<>c__DisplayClass88_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass88_0>.NativeClassPtr);
				DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass88_0>.NativeClassPtr, "<>4__this");
				DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeFieldInfoPtr_thisProductData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass88_0>.NativeClassPtr, "thisProductData");
				DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass88_0>.NativeClassPtr, 100667448);
				DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeMethodInfoPtr__ReturnToShelf_b__0_Internal_Boolean_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass88_0>.NativeClassPtr, 100667449);
				DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeMethodInfoPtr__ReturnToShelf_b__2_Internal_Boolean_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass88_0>.NativeClassPtr, 100667450);
				DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeMethodInfoPtr__ReturnToShelf_b__1_Internal_Boolean_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass88_0>.NativeClassPtr, 100667451);
				DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeMethodInfoPtr__ReturnToShelf_b__3_Internal_Boolean_KourindouStaticMerchandiseKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass88_0>.NativeClassPtr, 100667452);
			}

			// Token: 0x06009429 RID: 37929 RVA: 0x0027F750 File Offset: 0x0027D950
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass88_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass88_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600942A RID: 37930 RVA: 0x0027F78C File Offset: 0x0027D98C
			[CallerCount(0)]
			public unsafe bool _ReturnToShelf_b__0(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeMethodInfoPtr__ReturnToShelf_b__0_Internal_Boolean_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600942B RID: 37931 RVA: 0x0027F7E0 File Offset: 0x0027D9E0
			[CallerCount(0)]
			public unsafe bool _ReturnToShelf_b__2(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeMethodInfoPtr__ReturnToShelf_b__2_Internal_Boolean_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600942C RID: 37932 RVA: 0x0027F834 File Offset: 0x0027DA34
			[CallerCount(0)]
			public unsafe bool _ReturnToShelf_b__1(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeMethodInfoPtr__ReturnToShelf_b__1_Internal_Boolean_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600942D RID: 37933 RVA: 0x0027F888 File Offset: 0x0027DA88
			[CallerCount(0)]
			public unsafe bool _ReturnToShelf_b__3(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeMethodInfoPtr__ReturnToShelf_b__3_Internal_Boolean_KourindouStaticMerchandiseKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600942E RID: 37934 RVA: 0x000501C5 File Offset: 0x0004E3C5
			public __c__DisplayClass88_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003146 RID: 12614
			// (get) Token: 0x0600942F RID: 37935 RVA: 0x0027F8DC File Offset: 0x0027DADC
			// (set) Token: 0x06009430 RID: 37936 RVA: 0x000501CE File Offset: 0x0004E3CE
			public unsafe DaySceneKourindoShopPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneKourindoShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003147 RID: 12615
			// (get) Token: 0x06009431 RID: 37937 RVA: 0x0027F90C File Offset: 0x0027DB0C
			// (set) Token: 0x06009432 RID: 37938 RVA: 0x000501ED File Offset: 0x0004E3ED
			public DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey thisProductData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeFieldInfoPtr_thisProductData);
					return new DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass88_0.NativeFieldInfoPtr_thisProductData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006025 RID: 24613
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006026 RID: 24614
			private static readonly IntPtr NativeFieldInfoPtr_thisProductData;

			// Token: 0x04006027 RID: 24615
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006028 RID: 24616
			private static readonly IntPtr NativeMethodInfoPtr__ReturnToShelf_b__0_Internal_Boolean_KourindouStaticMerchandiseKey_0;

			// Token: 0x04006029 RID: 24617
			private static readonly IntPtr NativeMethodInfoPtr__ReturnToShelf_b__2_Internal_Boolean_KourindouStaticMerchandiseKey_0;

			// Token: 0x0400602A RID: 24618
			private static readonly IntPtr NativeMethodInfoPtr__ReturnToShelf_b__1_Internal_Boolean_KourindouStaticMerchandiseKey_0;

			// Token: 0x0400602B RID: 24619
			private static readonly IntPtr NativeMethodInfoPtr__ReturnToShelf_b__3_Internal_Boolean_KourindouStaticMerchandiseKey_0;
		}

		// Token: 0x02000659 RID: 1625
		[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+<>c__DisplayClass95_0")]
		public sealed class __c__DisplayClass95_0 : Il2CppSystem.Object
		{
			// Token: 0x06009433 RID: 37939 RVA: 0x0027F93C File Offset: 0x0027DB3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass95_0()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<>c__DisplayClass95_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_0>.NativeClassPtr);
				DaySceneKourindoShopPannel.__c__DisplayClass95_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_0>.NativeClassPtr, "id");
				DaySceneKourindoShopPannel.__c__DisplayClass95_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_0>.NativeClassPtr, "<>4__this");
				DaySceneKourindoShopPannel.__c__DisplayClass95_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_0>.NativeClassPtr, 100667453);
				DaySceneKourindoShopPannel.__c__DisplayClass95_0.NativeMethodInfoPtr_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_0>.NativeClassPtr, 100667454);
				DaySceneKourindoShopPannel.__c__DisplayClass95_0.NativeMethodInfoPtr__Describe_b__4_Internal_Boolean_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_0>.NativeClassPtr, 100667455);
			}

			// Token: 0x06009434 RID: 37940 RVA: 0x0027F9CC File Offset: 0x0027DBCC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass95_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass95_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009435 RID: 37941 RVA: 0x0027FA08 File Offset: 0x0027DC08
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63332, RefRangeEnd = 63333, XrefRangeStart = 63329, XrefRangeEnd = 63332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0<T>(IEnumerable<KeyValuePair<T, int>> objectCollection) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectCollection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass95_0.MethodInfoStoreGeneric_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009436 RID: 37942 RVA: 0x0027FA4C File Offset: 0x0027DC4C
			[CallerCount(0)]
			public unsafe bool _Describe_b__4<T>(KeyValuePair<T, int> x) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass95_0.MethodInfoStoreGeneric__Describe_b__4_Internal_Boolean_KeyValuePair_2_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009437 RID: 37943 RVA: 0x0005021B File Offset: 0x0004E41B
			public __c__DisplayClass95_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003148 RID: 12616
			// (get) Token: 0x06009438 RID: 37944 RVA: 0x0027FAA0 File Offset: 0x0027DCA0
			// (set) Token: 0x06009439 RID: 37945 RVA: 0x00050224 File Offset: 0x0004E424
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass95_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass95_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17003149 RID: 12617
			// (get) Token: 0x0600943A RID: 37946 RVA: 0x0027FAC8 File Offset: 0x0027DCC8
			// (set) Token: 0x0600943B RID: 37947 RVA: 0x0005023F File Offset: 0x0004E43F
			public unsafe DaySceneKourindoShopPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass95_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneKourindoShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass95_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400602C RID: 24620
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x0400602D RID: 24621
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400602E RID: 24622
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400602F RID: 24623
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0;

			// Token: 0x04006030 RID: 24624
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__4_Internal_Boolean_KeyValuePair_2_T_Int32_0;

			// Token: 0x02000FC1 RID: 4033
			private sealed class MethodInfoStoreGeneric_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0<T>
			{
				// Token: 0x0400AF8A RID: 44938
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DaySceneKourindoShopPannel.__c__DisplayClass95_0.NativeMethodInfoPtr_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0, Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_0>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}

			// Token: 0x02000FC2 RID: 4034
			private sealed class MethodInfoStoreGeneric__Describe_b__4_Internal_Boolean_KeyValuePair_2_T_Int32_0<T>
			{
				// Token: 0x0400AF8B RID: 44939
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DaySceneKourindoShopPannel.__c__DisplayClass95_0.NativeMethodInfoPtr__Describe_b__4_Internal_Boolean_KeyValuePair_2_T_Int32_0, Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_0>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}
		}

		// Token: 0x0200065A RID: 1626
		[ObfuscatedName("DayScene.UI.DaySceneKourindoShopPannel+<>c__DisplayClass95_1")]
		public sealed class __c__DisplayClass95_1 : Il2CppSystem.Object
		{
			// Token: 0x0600943C RID: 37948 RVA: 0x0027FAF8 File Offset: 0x0027DCF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass95_1()
			{
				Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneKourindoShopPannel>.NativeClassPtr, "<>c__DisplayClass95_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_1>.NativeClassPtr);
				DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeFieldInfoPtr_currencyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_1>.NativeClassPtr, "currencyId");
				DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeFieldInfoPtr_currencyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_1>.NativeClassPtr, "currencyData");
				DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_1>.NativeClassPtr, 100667456);
				DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeMethodInfoPtr__Describe_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_1>.NativeClassPtr, 100667457);
				DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeMethodInfoPtr__Describe_b__9_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_1>.NativeClassPtr, 100667458);
				DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeMethodInfoPtr__Describe_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_1>.NativeClassPtr, 100667459);
				DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeMethodInfoPtr__Describe_b__13_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_1>.NativeClassPtr, 100667460);
			}

			// Token: 0x0600943D RID: 37949 RVA: 0x0027FBB0 File Offset: 0x0027DDB0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass95_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneKourindoShopPannel.__c__DisplayClass95_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600943E RID: 37950 RVA: 0x0027FBEC File Offset: 0x0027DDEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63333, XrefRangeEnd = 63337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeMethodInfoPtr__Describe_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600943F RID: 37951 RVA: 0x0027FC30 File Offset: 0x0027DE30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63337, XrefRangeEnd = 63418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__9(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeMethodInfoPtr__Describe_b__9_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009440 RID: 37952 RVA: 0x0027FC74 File Offset: 0x0027DE74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63418, XrefRangeEnd = 63422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeMethodInfoPtr__Describe_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009441 RID: 37953 RVA: 0x0027FCB8 File Offset: 0x0027DEB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63422, XrefRangeEnd = 63427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__13(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeMethodInfoPtr__Describe_b__13_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009442 RID: 37954 RVA: 0x0005025E File Offset: 0x0004E45E
			public __c__DisplayClass95_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700314A RID: 12618
			// (get) Token: 0x06009443 RID: 37955 RVA: 0x0027FCFC File Offset: 0x0027DEFC
			// (set) Token: 0x06009444 RID: 37956 RVA: 0x00050267 File Offset: 0x0004E467
			public unsafe int currencyId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeFieldInfoPtr_currencyId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeFieldInfoPtr_currencyId)) = value;
				}
			}

			// Token: 0x1700314B RID: 12619
			// (get) Token: 0x06009445 RID: 37957 RVA: 0x0027FD24 File Offset: 0x0027DF24
			// (set) Token: 0x06009446 RID: 37958 RVA: 0x00050282 File Offset: 0x0004E482
			public unsafe KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency currencyData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeFieldInfoPtr_currencyData);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneKourindoShopPannel.__c__DisplayClass95_1.NativeFieldInfoPtr_currencyData)) = value;
				}
			}

			// Token: 0x04006031 RID: 24625
			private static readonly IntPtr NativeFieldInfoPtr_currencyId;

			// Token: 0x04006032 RID: 24626
			private static readonly IntPtr NativeFieldInfoPtr_currencyData;

			// Token: 0x04006033 RID: 24627
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006034 RID: 24628
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__6_Internal_Void_Image_0;

			// Token: 0x04006035 RID: 24629
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__9_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006036 RID: 24630
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__10_Internal_Void_Image_0;

			// Token: 0x04006037 RID: 24631
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__13_Internal_Void_TextMeshProUGUI_0;
		}
	}
}
