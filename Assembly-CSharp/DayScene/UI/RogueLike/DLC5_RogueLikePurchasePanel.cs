using System;
using System.Runtime.InteropServices;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using GameData.Core;
using GameData.Core.Collections;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading;
using NightScene;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200011D RID: 285
	public class DLC5_RogueLikePurchasePanel : MultiLayerUIPanel<DLC5_RogueLikePurchasePanel, InspectingProductType>
	{
		// Token: 0x0600200C RID: 8204 RVA: 0x00108F80 File Offset: 0x00107180
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikePurchasePanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikePurchasePanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr);
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__Merchandise_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<Merchandise>k__BackingField");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__RogueLikeRunTimeData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<RogueLikeRunTimeData>k__BackingField");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__ResultPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<ResultPanel>k__BackingField");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_Fund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_Fund");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoIngredientsToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_GotoIngredientsToggle");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoRecipeToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_GotoRecipeToggle");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoCookerToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_GotoCookerToggle");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoDecorationToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_GotoDecorationToggle");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoClothesToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_GotoClothesToggle");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoInviteToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_GotoInviteToggle");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoPartnerToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_GotoPartnerToggle");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoRecycleToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_GotoRecycleToggle");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_IngredientsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_IngredientsPanel");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_RecipePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_RecipePanel");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CookerPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_CookerPanel");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_DecorationPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_DecorationPanel");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_ClothesPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_ClothesPanel");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_InvitePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_InvitePanel");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PartnerPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_PartnerPanel");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_RecyclePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_RecyclePanel");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CurrentFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_CurrentFund");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_TotalCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_TotalCost");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_RemainingFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_RemainingFund");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_WaveText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_WaveText");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_WaveNeedFundText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_WaveNeedFundText");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_DisCountTip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_DisCountTip");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_KourindouCouponTip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_KourindouCouponTip");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CardTip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_CardTip");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PlusTip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_PlusTip");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CurrentDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_CurrentDiscount");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopLikeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_PopLikeText");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopLikeObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_PopLikeObject");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopHateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_PopHateText");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopHateObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_PopHateObject");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopNeutralText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_PopNeutralText");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopNeutralObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_PopNeutralObject");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopularRefreshText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_PopularRefreshText");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopularRefreshBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_PopularRefreshBtn");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_OpenSubSettingBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_OpenSubSettingBtn");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_ConfirmBuyBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_ConfirmBuyBtn");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__NullIndicator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<NullIndicator>k__BackingField");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_ShopTitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_ShopTitleText");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CartTitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_CartTitleText");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_ExtraMenuSubPanelForPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_ExtraMenuSubPanelForPurchase");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_FundSymbolMinus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_FundSymbolMinus");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_FundSymbolPlus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_FundSymbolPlus");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_COUPONS_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "COUPONS_ID");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__HasKourindouCoupon_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<HasKourindouCoupon>k__BackingField");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__CurrentDiscount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<CurrentDiscount>k__BackingField");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__FirstOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<FirstOpen>k__BackingField");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__ShopCloseContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<ShopCloseContext>k__BackingField");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__FundUpdateCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<FundUpdateCallback>k__BackingField");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CalculatePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_CalculatePrice");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__GetFinalPriceCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<GetFinalPriceCallback>k__BackingField");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_DISCOUNT_TEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "DISCOUNT_TEXT");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_HasPopular = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "m_HasPopular");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_selectedCardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "selectedCardType");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_isCardTypeExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "isCardTypeExpanded");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_selectedEliteChallengeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "selectedEliteChallengeType");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_isEliteChallengeTypeExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "isEliteChallengeTypeExpanded");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_selections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "selections");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_eliteChallengeTypeSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "eliteChallengeTypeSelections");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__MapPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<MapPanel>k__BackingField");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "difficulty");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_isdifficultyExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "isdifficultyExpanded");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_roundWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "roundWave");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "shouldOnGUIBuffConsoleShown");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_consoleDataIsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "consoleDataIsInitialized");
			DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_SOLD_INDICATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "SOLD_INDICATOR");
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_AllProducts_Public_Virtual_Final_New_get_IList_1_ProductReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668925);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_Merchandise_Public_get_List_1_ProductReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668926);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_OnMultilayerPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668927);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_Fund_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668928);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_Fund_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668929);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_Virtual_Final_New_get_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668930);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_RogueLikeRunTimeData_Public_set_Void_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668931);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_ResultPanel_Public_get_DLC5_RogueLikePoolResultPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668932);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_ResultPanel_Public_set_Void_DLC5_RogueLikePoolResultPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668933);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_NullIndicator_Public_get_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668934);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_NullIndicator_Private_set_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668935);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_HasKourindouCoupon_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668936);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_HasKourindouCoupon_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668937);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_CurrentDiscount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668938);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_CurrentDiscount_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668939);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_FirstOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668940);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_FirstOpen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668941);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_ShopCloseContext_Public_get_CloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668942);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_ShopCloseContext_Public_set_Void_CloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668943);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_FundUpdateCallback_Private_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668944);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_FundUpdateCallback_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668945);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_GetFinalPriceCallback_Public_get_Func_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668946);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_GetFinalPriceCallback_Public_set_Void_Func_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668947);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_ConfirmBuyBtn_Public_get_UIButtonHold_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668948);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_SetSymbol_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668949);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668950);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_InspectingProductType_UIButtonToggle_UISubPanel_1_DLC5_RogueLikePurchasePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668951);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_OnPostPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668952);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_DefaultOnItemEnabled_Private_Static_Void_T_UIElementCluster_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668953);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_DecorationOnItemEnabled_Private_Static_Void_T_UIElementCluster_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668954);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_RecipeOnItemEnabled_Private_Static_Void_Recipe_UIElementCluster_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668955);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_DefaultOnSpecialGuestEnabled_Private_Static_Void_SpecialGuest_UIElementCluster_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668956);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_OnPanelPreOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668957);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_OnPreOpenSubPanel_Protected_Virtual_Void_InspectingProductType_UISubPanel_1_DLC5_RogueLikePurchasePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668958);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_InspectingProductType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668959);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668960);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_AfterClose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668961);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_UpdateTotalPrice_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668962);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_RefreshPopularTag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668963);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_CheckCanPopular_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668964);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_RefreshPopularTagView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668965);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_UpdateShopTitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668966);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_UpdateCartTitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668967);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_MapPanel_Private_get_DLC5_RogueLikeSpotSelectionPanel_New_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668968);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_MapPanel_Public_set_Void_DLC5_RogueLikeSpotSelectionPanel_New_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668969);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_GetSelections_Private_get_Dictionary_2_CardType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668970);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_GetEliteChallengeTypeSelections_Private_get_Dictionary_2_EliteChallengeType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668971);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668972);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_StandardDeductProductAmount_Private_Static_Boolean_byref_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668973);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_ForceClearProductAmount_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668974);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_StandardGetProductAmount_Private_Static_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668975);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_AmountAsPriceDeductProductAmount_Private_Static_Boolean_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668976);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_AmountAsPriceGetProductAmount_Private_Static_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668977);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_AmountAsPriceGetProductPrice_Private_Static_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668978);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668979);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668980);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__96_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668981);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__96_4_Private_Void_CloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668982);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__96_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668983);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__96_1_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668984);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__96_2_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668985);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__96_3_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668986);
			DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__get_GetSelections_b__127_2_Private_String_KeyValuePair_2_CardType_RogueLikeCardPersistent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, 100668987);
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x00109A00 File Offset: 0x00107C00
		public unsafe virtual IList<ProductReference> AllProducts
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_AllProducts_Public_Virtual_Final_New_get_IList_1_ProductReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ProductReference>>(intPtr3) : null;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x00109A40 File Offset: 0x00107C40
		public unsafe List<ProductReference> Merchandise
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_Merchandise_Public_get_List_1_ProductReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductReference>>(intPtr3) : null;
			}
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x00109A80 File Offset: 0x00107C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79078, XrefRangeEnd = 79081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnMultilayerPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_OnMultilayerPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x00109ABC File Offset: 0x00107CBC
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x00109AF8 File Offset: 0x00107CF8
		public unsafe virtual int Fund
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_Fund_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 79085, RefRangeEnd = 79087, XrefRangeStart = 79081, XrefRangeEnd = 79085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_Fund_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x00109B38 File Offset: 0x00107D38
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x00109B78 File Offset: 0x00107D78
		public unsafe virtual RogueLikeRunTimeData RogueLikeRunTimeData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_Virtual_Final_New_get_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_RogueLikeRunTimeData_Public_set_Void_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x00109BBC File Offset: 0x00107DBC
		// (set) Token: 0x06002015 RID: 8213 RVA: 0x00109BFC File Offset: 0x00107DFC
		public unsafe DLC5_RogueLikePoolResultPanel ResultPanel
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_ResultPanel_Public_get_DLC5_RogueLikePoolResultPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolResultPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_ResultPanel_Public_set_Void_DLC5_RogueLikePoolResultPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x00109C40 File Offset: 0x00107E40
		// (set) Token: 0x06002017 RID: 8215 RVA: 0x00109C80 File Offset: 0x00107E80
		public unsafe CanvasGroup NullIndicator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_NullIndicator_Public_get_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79087, XrefRangeEnd = 79088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_NullIndicator_Private_set_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x00109CC4 File Offset: 0x00107EC4
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x00109D00 File Offset: 0x00107F00
		public unsafe bool HasKourindouCoupon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_HasKourindouCoupon_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_HasKourindouCoupon_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x00109D40 File Offset: 0x00107F40
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x00109D7C File Offset: 0x00107F7C
		public unsafe float CurrentDiscount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_CurrentDiscount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_CurrentDiscount_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x00109DBC File Offset: 0x00107FBC
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x00109DF8 File Offset: 0x00107FF8
		public unsafe bool FirstOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_FirstOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_FirstOpen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x00109E38 File Offset: 0x00108038
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x00109E74 File Offset: 0x00108074
		public unsafe DLC5_RogueLikeExtraMenuSubPanel.CloseContext ShopCloseContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_ShopCloseContext_Public_get_CloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_ShopCloseContext_Public_set_Void_CloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x00109EB4 File Offset: 0x001080B4
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x00109EF4 File Offset: 0x001080F4
		public unsafe Action FundUpdateCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_FundUpdateCallback_Private_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79088, XrefRangeEnd = 79089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_FundUpdateCallback_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x00109F38 File Offset: 0x00108138
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x00109F78 File Offset: 0x00108178
		public unsafe Func<int, int> GetFinalPriceCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_GetFinalPriceCallback_Public_get_Func_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_GetFinalPriceCallback_Public_set_Void_Func_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x00109FBC File Offset: 0x001081BC
		public unsafe UIButtonHold ConfirmBuyBtn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_ConfirmBuyBtn_Public_get_UIButtonHold_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr3) : null;
			}
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x00109FFC File Offset: 0x001081FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79089, XrefRangeEnd = 79092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSymbol(bool isMinus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isMinus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_SetSymbol_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0010A03C File Offset: 0x0010823C
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x0010A084 File Offset: 0x00108284
		public unsafe override IEnumerable<ValueTuple<InspectingProductType, UIButtonToggle, UISubPanel<DLC5_RogueLikePurchasePanel>>> GetData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79092, XrefRangeEnd = 79098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_InspectingProductType_UIButtonToggle_UISubPanel_1_DLC5_RogueLikePurchasePanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<InspectingProductType, UIButtonToggle, UISubPanel<DLC5_RogueLikePurchasePanel>>>>(intPtr3) : null;
			}
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x0010A0D0 File Offset: 0x001082D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79098, XrefRangeEnd = 79148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPostPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_OnPostPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x0010A10C File Offset: 0x0010830C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79148, XrefRangeEnd = 79176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DefaultOnItemEnabled<T>(T data, UIElementCluster uiElementCluster, int amount, bool check)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = data;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref data;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.MethodInfoStoreGeneric_DefaultOnItemEnabled_Private_Static_Void_T_UIElementCluster_Int32_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x0010A1A8 File Offset: 0x001083A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79196, RefRangeEnd = 79197, XrefRangeStart = 79176, XrefRangeEnd = 79196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DecorationOnItemEnabled<T>(T data, UIElementCluster uiElementCluster, bool owned, bool check)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = data;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref data;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref owned;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.MethodInfoStoreGeneric_DecorationOnItemEnabled_Private_Static_Void_T_UIElementCluster_Boolean_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x0010A244 File Offset: 0x00108444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79197, XrefRangeEnd = 79227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecipeOnItemEnabled(Recipe data, UIElementCluster uiElementCluster, bool check)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_RecipeOnItemEnabled_Private_Static_Void_Recipe_UIElementCluster_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x0010A29C File Offset: 0x0010849C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79353, RefRangeEnd = 79354, XrefRangeStart = 79227, XrefRangeEnd = 79353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DefaultOnSpecialGuestEnabled(SpecialGuest guestData, UIElementCluster cluster, int _, bool check)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_DefaultOnSpecialGuestEnabled_Private_Static_Void_SpecialGuest_UIElementCluster_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x0010A300 File Offset: 0x00108500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79354, XrefRangeEnd = 79418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelPreOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_OnPanelPreOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x0010A33C File Offset: 0x0010853C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79418, XrefRangeEnd = 79531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPreOpenSubPanel(InspectingProductType panelData, UISubPanel<DLC5_RogueLikePurchasePanel> panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref panelData;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_OnPreOpenSubPanel_Protected_Virtual_Void_InspectingProductType_UISubPanel_1_DLC5_RogueLikePurchasePanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x0010A398 File Offset: 0x00108598
		public unsafe override InspectingProductType DefaultPanelSelection
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_InspectingProductType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x0010A3E0 File Offset: 0x001085E0
		public unsafe override string SwitchKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79531, XrefRangeEnd = 79532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x0010A424 File Offset: 0x00108624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79532, RefRangeEnd = 79533, XrefRangeStart = 79532, XrefRangeEnd = 79532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AfterClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_AfterClose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x0010A458 File Offset: 0x00108658
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 79535, RefRangeEnd = 79543, XrefRangeStart = 79533, XrefRangeEnd = 79535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTotalPrice(int calculatePrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref calculatePrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_UpdateTotalPrice_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x0010A498 File Offset: 0x00108698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79543, XrefRangeEnd = 79548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPopularTag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_RefreshPopularTag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x0010A4CC File Offset: 0x001086CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79548, XrefRangeEnd = 79550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCanPopular()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_CheckCanPopular_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x0010A500 File Offset: 0x00108700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 79588, RefRangeEnd = 79590, XrefRangeStart = 79550, XrefRangeEnd = 79588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPopularTagView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_RefreshPopularTagView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x0010A534 File Offset: 0x00108734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79590, XrefRangeEnd = 79591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShopTitle(string targetTitle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(targetTitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_UpdateShopTitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x0010A578 File Offset: 0x00108778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79591, XrefRangeEnd = 79592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCartTitle(string targetTitle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(targetTitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_UpdateCartTitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x0010A5BC File Offset: 0x001087BC
		// (set) Token: 0x06002039 RID: 8249 RVA: 0x0010A5FC File Offset: 0x001087FC
		public unsafe DLC5_RogueLikeSpotSelectionPanel_New MapPanel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_MapPanel_Private_get_DLC5_RogueLikeSpotSelectionPanel_New_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel_New>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79592, XrefRangeEnd = 79593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_set_MapPanel_Public_set_Void_DLC5_RogueLikeSpotSelectionPanel_New_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x0010A640 File Offset: 0x00108840
		public unsafe Dictionary<RogueLikeCardBase.CardType, string> GetSelections
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 79635, RefRangeEnd = 79638, XrefRangeStart = 79593, XrefRangeEnd = 79635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_GetSelections_Private_get_Dictionary_2_CardType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<RogueLikeCardBase.CardType, string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x0010A680 File Offset: 0x00108880
		public unsafe Dictionary<RogueLikeRunTimeData.EliteChallengeType, string> GetEliteChallengeTypeSelections
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 79671, RefRangeEnd = 79675, XrefRangeStart = 79638, XrefRangeEnd = 79671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_get_GetEliteChallengeTypeSelections_Private_get_Dictionary_2_EliteChallengeType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<RogueLikeRunTimeData.EliteChallengeType, string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0010A6C0 File Offset: 0x001088C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79675, XrefRangeEnd = 80035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0010A6F4 File Offset: 0x001088F4
		[CallerCount(0)]
		public unsafe static bool StandardDeductProductAmount(ref Product product, int amount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_StandardDeductProductAmount_Private_Static_Boolean_byref_Product_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0010A744 File Offset: 0x00108944
		[CallerCount(299)]
		[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ForceClearProductAmount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_ForceClearProductAmount_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0010A774 File Offset: 0x00108974
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StandardGetProductAmount([In] ref Product product)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_StandardGetProductAmount_Private_Static_Int32_byref_Product_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0010A7B8 File Offset: 0x001089B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80039, RefRangeEnd = 80040, XrefRangeStart = 80035, XrefRangeEnd = 80039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AmountAsPriceDeductProductAmount(ref Product product)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_AmountAsPriceDeductProductAmount_Private_Static_Boolean_byref_Product_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x0010A7FC File Offset: 0x001089FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80040, RefRangeEnd = 80041, XrefRangeStart = 80040, XrefRangeEnd = 80040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AmountAsPriceGetProductAmount([In] ref Product product)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_AmountAsPriceGetProductAmount_Private_Static_Int32_byref_Product_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0010A840 File Offset: 0x00108A40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AmountAsPriceGetProductPrice([In] ref Product product)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_AmountAsPriceGetProductPrice_Private_Static_Int32_byref_Product_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x0010A884 File Offset: 0x00108A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80041, XrefRangeEnd = 80094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x0010A8C0 File Offset: 0x00108AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80094, XrefRangeEnd = 80105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikePurchasePanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x0010A8FC File Offset: 0x00108AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80105, XrefRangeEnd = 80112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPostPanelInitialize_b__96_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__96_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0010A930 File Offset: 0x00108B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80112, XrefRangeEnd = 80125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPostPanelInitialize_b__96_4(DLC5_RogueLikeExtraMenuSubPanel.CloseContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__96_4_Private_Void_CloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x0010A970 File Offset: 0x00108B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80125, XrefRangeEnd = 80130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPostPanelInitialize_b__96_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__96_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x0010A9A4 File Offset: 0x00108BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80130, XrefRangeEnd = 80131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPostPanelInitialize_b__96_1(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__96_1_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0010A9EC File Offset: 0x00108BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80131, XrefRangeEnd = 80135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPostPanelInitialize_b__96_2(InputAction.CallbackContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__96_2_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x0010AA34 File Offset: 0x00108C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80135, XrefRangeEnd = 80139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPostPanelInitialize_b__96_3(InputAction.CallbackContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__OnPostPanelInitialize_b__96_3_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0010AA7C File Offset: 0x00108C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80139, XrefRangeEnd = 80143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _get_GetSelections_b__127_2(KeyValuePair<RogueLikeCardBase.CardType, RogueLikeCardPersistent> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr__get_GetSelections_b__127_2_Private_String_KeyValuePair_2_CardType_RogueLikeCardPersistent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x000137AD File Offset: 0x000119AD
		public DLC5_RogueLikePurchasePanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x0010AACC File Offset: 0x00108CCC
		// (set) Token: 0x0600204E RID: 8270 RVA: 0x000137B6 File Offset: 0x000119B6
		public unsafe List<ProductReference> _Merchandise_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__Merchandise_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__Merchandise_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x0010AAFC File Offset: 0x00108CFC
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x000137D5 File Offset: 0x000119D5
		public unsafe RogueLikeRunTimeData _RogueLikeRunTimeData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__RogueLikeRunTimeData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__RogueLikeRunTimeData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x0010AB2C File Offset: 0x00108D2C
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x000137F4 File Offset: 0x000119F4
		public unsafe DLC5_RogueLikePoolResultPanel _ResultPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__ResultPanel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolResultPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__ResultPanel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x0010AB5C File Offset: 0x00108D5C
		// (set) Token: 0x06002054 RID: 8276 RVA: 0x00013813 File Offset: 0x00011A13
		public unsafe TextMeshProUGUI m_Fund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_Fund);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_Fund), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x0010AB8C File Offset: 0x00108D8C
		// (set) Token: 0x06002056 RID: 8278 RVA: 0x00013832 File Offset: 0x00011A32
		public unsafe UIButtonToggle m_GotoIngredientsToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoIngredientsToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoIngredientsToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x0010ABBC File Offset: 0x00108DBC
		// (set) Token: 0x06002058 RID: 8280 RVA: 0x00013851 File Offset: 0x00011A51
		public unsafe UIButtonToggle m_GotoRecipeToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoRecipeToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoRecipeToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x0010ABEC File Offset: 0x00108DEC
		// (set) Token: 0x0600205A RID: 8282 RVA: 0x00013870 File Offset: 0x00011A70
		public unsafe UIButtonToggle m_GotoCookerToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoCookerToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoCookerToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x0010AC1C File Offset: 0x00108E1C
		// (set) Token: 0x0600205C RID: 8284 RVA: 0x0001388F File Offset: 0x00011A8F
		public unsafe UIButtonToggle m_GotoDecorationToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoDecorationToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoDecorationToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x0010AC4C File Offset: 0x00108E4C
		// (set) Token: 0x0600205E RID: 8286 RVA: 0x000138AE File Offset: 0x00011AAE
		public unsafe UIButtonToggle m_GotoClothesToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoClothesToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoClothesToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x0010AC7C File Offset: 0x00108E7C
		// (set) Token: 0x06002060 RID: 8288 RVA: 0x000138CD File Offset: 0x00011ACD
		public unsafe UIButtonToggle m_GotoInviteToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoInviteToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoInviteToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x0010ACAC File Offset: 0x00108EAC
		// (set) Token: 0x06002062 RID: 8290 RVA: 0x000138EC File Offset: 0x00011AEC
		public unsafe UIButtonToggle m_GotoPartnerToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoPartnerToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoPartnerToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x0010ACDC File Offset: 0x00108EDC
		// (set) Token: 0x06002064 RID: 8292 RVA: 0x0001390B File Offset: 0x00011B0B
		public unsafe UIButtonToggle m_GotoRecycleToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoRecycleToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_GotoRecycleToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x0010AD0C File Offset: 0x00108F0C
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x0001392A File Offset: 0x00011B2A
		public unsafe DLC5_RogueLikePurchaseItemPanel m_IngredientsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_IngredientsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseItemPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_IngredientsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x0010AD3C File Offset: 0x00108F3C
		// (set) Token: 0x06002068 RID: 8296 RVA: 0x00013949 File Offset: 0x00011B49
		public unsafe DLC5_RogueLikePurchaseRecipePanel m_RecipePanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_RecipePanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseRecipePanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_RecipePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x0010AD6C File Offset: 0x00108F6C
		// (set) Token: 0x0600206A RID: 8298 RVA: 0x00013968 File Offset: 0x00011B68
		public unsafe DLC5_RogueLikePurchaseItemPanel m_CookerPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CookerPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseItemPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CookerPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x0010AD9C File Offset: 0x00108F9C
		// (set) Token: 0x0600206C RID: 8300 RVA: 0x00013987 File Offset: 0x00011B87
		public unsafe DLC5_RogueLikePurchaseItemPanel m_DecorationPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_DecorationPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseItemPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_DecorationPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x0010ADCC File Offset: 0x00108FCC
		// (set) Token: 0x0600206E RID: 8302 RVA: 0x000139A6 File Offset: 0x00011BA6
		public unsafe DLC5_RogueLikePurchaseItemPanel m_ClothesPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_ClothesPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseItemPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_ClothesPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x0010ADFC File Offset: 0x00108FFC
		// (set) Token: 0x06002070 RID: 8304 RVA: 0x000139C5 File Offset: 0x00011BC5
		public unsafe DLC5_RogueLikePurchaseItemPanel m_InvitePanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_InvitePanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseItemPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_InvitePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x0010AE2C File Offset: 0x0010902C
		// (set) Token: 0x06002072 RID: 8306 RVA: 0x000139E4 File Offset: 0x00011BE4
		public unsafe DLC5_RogueLikePurchaseItemPanel m_PartnerPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PartnerPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseItemPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PartnerPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x0010AE5C File Offset: 0x0010905C
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x00013A03 File Offset: 0x00011C03
		public unsafe DLC5_RogueLikePurchaseRecyclePanel m_RecyclePanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_RecyclePanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseRecyclePanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_RecyclePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x0010AE8C File Offset: 0x0010908C
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x00013A22 File Offset: 0x00011C22
		public unsafe int m_CurrentFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CurrentFund);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CurrentFund)) = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0010AEB4 File Offset: 0x001090B4
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x00013A3D File Offset: 0x00011C3D
		public unsafe TextMeshProUGUI m_TotalCost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_TotalCost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_TotalCost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x0010AEE4 File Offset: 0x001090E4
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x00013A5C File Offset: 0x00011C5C
		public unsafe TextMeshProUGUI m_RemainingFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_RemainingFund);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_RemainingFund), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x0010AF14 File Offset: 0x00109114
		// (set) Token: 0x0600207C RID: 8316 RVA: 0x00013A7B File Offset: 0x00011C7B
		public unsafe TextMeshProUGUI m_WaveText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_WaveText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_WaveText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x0010AF44 File Offset: 0x00109144
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x00013A9A File Offset: 0x00011C9A
		public unsafe TextMeshProUGUI m_WaveNeedFundText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_WaveNeedFundText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_WaveNeedFundText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x0010AF74 File Offset: 0x00109174
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x00013AB9 File Offset: 0x00011CB9
		public unsafe CanvasGroup m_DisCountTip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_DisCountTip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_DisCountTip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x0010AFA4 File Offset: 0x001091A4
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x00013AD8 File Offset: 0x00011CD8
		public unsafe GameObject m_KourindouCouponTip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_KourindouCouponTip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_KourindouCouponTip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x0010AFD4 File Offset: 0x001091D4
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x00013AF7 File Offset: 0x00011CF7
		public unsafe GameObject m_CardTip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CardTip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CardTip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x0010B004 File Offset: 0x00109204
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x00013B16 File Offset: 0x00011D16
		public unsafe GameObject m_PlusTip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PlusTip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PlusTip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x0010B034 File Offset: 0x00109234
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x00013B35 File Offset: 0x00011D35
		public unsafe TextMeshProUGUI m_CurrentDiscount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CurrentDiscount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CurrentDiscount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x0010B064 File Offset: 0x00109264
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x00013B54 File Offset: 0x00011D54
		public unsafe TextMeshProUGUI m_PopLikeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopLikeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopLikeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0010B094 File Offset: 0x00109294
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x00013B73 File Offset: 0x00011D73
		public unsafe GameObject m_PopLikeObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopLikeObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopLikeObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0010B0C4 File Offset: 0x001092C4
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x00013B92 File Offset: 0x00011D92
		public unsafe TextMeshProUGUI m_PopHateText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopHateText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopHateText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0010B0F4 File Offset: 0x001092F4
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x00013BB1 File Offset: 0x00011DB1
		public unsafe GameObject m_PopHateObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopHateObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopHateObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x0010B124 File Offset: 0x00109324
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x00013BD0 File Offset: 0x00011DD0
		public unsafe TextMeshProUGUI m_PopNeutralText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopNeutralText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopNeutralText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x0010B154 File Offset: 0x00109354
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x00013BEF File Offset: 0x00011DEF
		public unsafe GameObject m_PopNeutralObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopNeutralObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopNeutralObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x0010B184 File Offset: 0x00109384
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x00013C0E File Offset: 0x00011E0E
		public unsafe TextMeshProUGUI m_PopularRefreshText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopularRefreshText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopularRefreshText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x0010B1B4 File Offset: 0x001093B4
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x00013C2D File Offset: 0x00011E2D
		public unsafe UIButtonSimple m_PopularRefreshBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopularRefreshBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_PopularRefreshBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x0010B1E4 File Offset: 0x001093E4
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x00013C4C File Offset: 0x00011E4C
		public unsafe UIButtonSimple m_OpenSubSettingBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_OpenSubSettingBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_OpenSubSettingBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x0010B214 File Offset: 0x00109414
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x00013C6B File Offset: 0x00011E6B
		public unsafe UIButtonHold m_ConfirmBuyBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_ConfirmBuyBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_ConfirmBuyBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x0010B244 File Offset: 0x00109444
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x00013C8A File Offset: 0x00011E8A
		public unsafe CanvasGroup _NullIndicator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__NullIndicator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__NullIndicator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x0010B274 File Offset: 0x00109474
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x00013CA9 File Offset: 0x00011EA9
		public unsafe TextMeshProUGUI m_ShopTitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_ShopTitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_ShopTitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x0010B2A4 File Offset: 0x001094A4
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x00013CC8 File Offset: 0x00011EC8
		public unsafe TextMeshProUGUI m_CartTitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CartTitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CartTitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x0010B2D4 File Offset: 0x001094D4
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x00013CE7 File Offset: 0x00011EE7
		public unsafe DLC5_RogueLikeExtraMenuSubPanel m_ExtraMenuSubPanelForPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_ExtraMenuSubPanelForPurchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeExtraMenuSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_ExtraMenuSubPanelForPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0010B304 File Offset: 0x00109504
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x00013D06 File Offset: 0x00011F06
		public unsafe GameObject m_FundSymbolMinus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_FundSymbolMinus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_FundSymbolMinus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x0010B334 File Offset: 0x00109534
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x00013D25 File Offset: 0x00011F25
		public unsafe GameObject m_FundSymbolPlus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_FundSymbolPlus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_FundSymbolPlus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x0010B364 File Offset: 0x00109564
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x00013D44 File Offset: 0x00011F44
		public unsafe static int COUPONS_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_COUPONS_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_COUPONS_ID, (void*)(&value));
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x060020AB RID: 8363 RVA: 0x0010B380 File Offset: 0x00109580
		// (set) Token: 0x060020AC RID: 8364 RVA: 0x00013D52 File Offset: 0x00011F52
		public unsafe bool _HasKourindouCoupon_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__HasKourindouCoupon_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__HasKourindouCoupon_k__BackingField)) = value;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x060020AD RID: 8365 RVA: 0x0010B3A8 File Offset: 0x001095A8
		// (set) Token: 0x060020AE RID: 8366 RVA: 0x00013D6D File Offset: 0x00011F6D
		public unsafe float _CurrentDiscount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__CurrentDiscount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__CurrentDiscount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x060020AF RID: 8367 RVA: 0x0010B3D0 File Offset: 0x001095D0
		// (set) Token: 0x060020B0 RID: 8368 RVA: 0x00013D88 File Offset: 0x00011F88
		public unsafe bool _FirstOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__FirstOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__FirstOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x060020B1 RID: 8369 RVA: 0x0010B3F8 File Offset: 0x001095F8
		// (set) Token: 0x060020B2 RID: 8370 RVA: 0x00013DA3 File Offset: 0x00011FA3
		public unsafe DLC5_RogueLikeExtraMenuSubPanel.CloseContext _ShopCloseContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__ShopCloseContext_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__ShopCloseContext_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x0010B420 File Offset: 0x00109620
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x00013DBE File Offset: 0x00011FBE
		public unsafe Action _FundUpdateCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__FundUpdateCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__FundUpdateCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x0010B450 File Offset: 0x00109650
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x00013DDD File Offset: 0x00011FDD
		public unsafe int m_CalculatePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CalculatePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_CalculatePrice)) = value;
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x0010B478 File Offset: 0x00109678
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x00013DF8 File Offset: 0x00011FF8
		public unsafe Func<int, int> _GetFinalPriceCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__GetFinalPriceCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__GetFinalPriceCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x0010B4A8 File Offset: 0x001096A8
		// (set) Token: 0x060020BA RID: 8378 RVA: 0x00013E17 File Offset: 0x00012017
		public unsafe static string DISCOUNT_TEXT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_DISCOUNT_TEXT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_DISCOUNT_TEXT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x0010B4C8 File Offset: 0x001096C8
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x00013E29 File Offset: 0x00012029
		public unsafe bool m_HasPopular
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_HasPopular);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_m_HasPopular)) = value;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x0010B4F0 File Offset: 0x001096F0
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x00013E44 File Offset: 0x00012044
		public unsafe RogueLikeCardBase.CardType selectedCardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_selectedCardType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_selectedCardType)) = value;
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x0010B518 File Offset: 0x00109718
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x00013E5F File Offset: 0x0001205F
		public unsafe bool isCardTypeExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_isCardTypeExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_isCardTypeExpanded)) = value;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x0010B540 File Offset: 0x00109740
		// (set) Token: 0x060020C2 RID: 8386 RVA: 0x00013E7A File Offset: 0x0001207A
		public unsafe RogueLikeRunTimeData.EliteChallengeType selectedEliteChallengeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_selectedEliteChallengeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_selectedEliteChallengeType)) = value;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x0010B568 File Offset: 0x00109768
		// (set) Token: 0x060020C4 RID: 8388 RVA: 0x00013E95 File Offset: 0x00012095
		public unsafe bool isEliteChallengeTypeExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_isEliteChallengeTypeExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_isEliteChallengeTypeExpanded)) = value;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x0010B590 File Offset: 0x00109790
		// (set) Token: 0x060020C6 RID: 8390 RVA: 0x00013EB0 File Offset: 0x000120B0
		public unsafe Dictionary<RogueLikeCardBase.CardType, string> selections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_selections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RogueLikeCardBase.CardType, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_selections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x0010B5C0 File Offset: 0x001097C0
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x00013ECF File Offset: 0x000120CF
		public unsafe Dictionary<RogueLikeRunTimeData.EliteChallengeType, string> eliteChallengeTypeSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_eliteChallengeTypeSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RogueLikeRunTimeData.EliteChallengeType, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_eliteChallengeTypeSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x0010B5F0 File Offset: 0x001097F0
		// (set) Token: 0x060020CA RID: 8394 RVA: 0x00013EEE File Offset: 0x000120EE
		public unsafe DLC5_RogueLikeSpotSelectionPanel_New _MapPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__MapPanel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel_New>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr__MapPanel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x0010B620 File Offset: 0x00109820
		// (set) Token: 0x060020CC RID: 8396 RVA: 0x00013F0D File Offset: 0x0001210D
		public unsafe NightSceneDirector.Difficulty difficulty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_difficulty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_difficulty)) = value;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x0010B648 File Offset: 0x00109848
		// (set) Token: 0x060020CE RID: 8398 RVA: 0x00013F28 File Offset: 0x00012128
		public unsafe bool isdifficultyExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_isdifficultyExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_isdifficultyExpanded)) = value;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x0010B670 File Offset: 0x00109870
		// (set) Token: 0x060020D0 RID: 8400 RVA: 0x00013F43 File Offset: 0x00012143
		public unsafe int roundWave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_roundWave);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_roundWave)) = value;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x0010B698 File Offset: 0x00109898
		// (set) Token: 0x060020D2 RID: 8402 RVA: 0x00013F5E File Offset: 0x0001215E
		public unsafe bool shouldOnGUIBuffConsoleShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown)) = value;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x0010B6C0 File Offset: 0x001098C0
		// (set) Token: 0x060020D4 RID: 8404 RVA: 0x00013F79 File Offset: 0x00012179
		public unsafe bool consoleDataIsInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_consoleDataIsInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_consoleDataIsInitialized)) = value;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x0010B6E8 File Offset: 0x001098E8
		// (set) Token: 0x060020D6 RID: 8406 RVA: 0x00013F94 File Offset: 0x00012194
		public unsafe static string SOLD_INDICATOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_SOLD_INDICATOR, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.NativeFieldInfoPtr_SOLD_INDICATOR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeFieldInfoPtr__Merchandise_k__BackingField;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeFieldInfoPtr__RogueLikeRunTimeData_k__BackingField;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeFieldInfoPtr__ResultPanel_k__BackingField;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeFieldInfoPtr_m_Fund;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoIngredientsToggle;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoRecipeToggle;

		// Token: 0x04001554 RID: 5460
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoCookerToggle;

		// Token: 0x04001555 RID: 5461
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoDecorationToggle;

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoClothesToggle;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoInviteToggle;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoPartnerToggle;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoRecycleToggle;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientsPanel;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipePanel;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerPanel;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeFieldInfoPtr_m_DecorationPanel;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeFieldInfoPtr_m_ClothesPanel;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeFieldInfoPtr_m_InvitePanel;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeFieldInfoPtr_m_PartnerPanel;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeFieldInfoPtr_m_RecyclePanel;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFund;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeFieldInfoPtr_m_TotalCost;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeFieldInfoPtr_m_RemainingFund;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeFieldInfoPtr_m_WaveText;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeFieldInfoPtr_m_WaveNeedFundText;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeFieldInfoPtr_m_DisCountTip;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeFieldInfoPtr_m_KourindouCouponTip;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeFieldInfoPtr_m_CardTip;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeFieldInfoPtr_m_PlusTip;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentDiscount;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeFieldInfoPtr_m_PopLikeText;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeFieldInfoPtr_m_PopLikeObject;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeFieldInfoPtr_m_PopHateText;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeFieldInfoPtr_m_PopHateObject;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeFieldInfoPtr_m_PopNeutralText;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeFieldInfoPtr_m_PopNeutralObject;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeFieldInfoPtr_m_PopularRefreshText;

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeFieldInfoPtr_m_PopularRefreshBtn;

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeFieldInfoPtr_m_OpenSubSettingBtn;

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeFieldInfoPtr_m_ConfirmBuyBtn;

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeFieldInfoPtr__NullIndicator_k__BackingField;

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeFieldInfoPtr_m_ShopTitleText;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeFieldInfoPtr_m_CartTitleText;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtraMenuSubPanelForPurchase;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeFieldInfoPtr_m_FundSymbolMinus;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeFieldInfoPtr_m_FundSymbolPlus;

		// Token: 0x0400157C RID: 5500
		private static readonly IntPtr NativeFieldInfoPtr_COUPONS_ID;

		// Token: 0x0400157D RID: 5501
		private static readonly IntPtr NativeFieldInfoPtr__HasKourindouCoupon_k__BackingField;

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDiscount_k__BackingField;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeFieldInfoPtr__FirstOpen_k__BackingField;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeFieldInfoPtr__ShopCloseContext_k__BackingField;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeFieldInfoPtr__FundUpdateCallback_k__BackingField;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeFieldInfoPtr_m_CalculatePrice;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeFieldInfoPtr__GetFinalPriceCallback_k__BackingField;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeFieldInfoPtr_DISCOUNT_TEXT;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeFieldInfoPtr_m_HasPopular;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeFieldInfoPtr_selectedCardType;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeFieldInfoPtr_isCardTypeExpanded;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeFieldInfoPtr_selectedEliteChallengeType;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeFieldInfoPtr_isEliteChallengeTypeExpanded;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeFieldInfoPtr_selections;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeFieldInfoPtr_eliteChallengeTypeSelections;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeFieldInfoPtr__MapPanel_k__BackingField;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeFieldInfoPtr_difficulty;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeFieldInfoPtr_isdifficultyExpanded;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeFieldInfoPtr_roundWave;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeFieldInfoPtr_shouldOnGUIBuffConsoleShown;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeFieldInfoPtr_consoleDataIsInitialized;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeFieldInfoPtr_SOLD_INDICATOR;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeMethodInfoPtr_get_AllProducts_Public_Virtual_Final_New_get_IList_1_ProductReference_0;

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeMethodInfoPtr_get_Merchandise_Public_get_List_1_ProductReference_0;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeMethodInfoPtr_OnMultilayerPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeMethodInfoPtr_get_Fund_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr_set_Fund_Public_Virtual_Final_New_set_Void_Int32_0;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_Virtual_Final_New_get_RogueLikeRunTimeData_0;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeMethodInfoPtr_set_RogueLikeRunTimeData_Public_set_Void_RogueLikeRunTimeData_0;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeMethodInfoPtr_get_ResultPanel_Public_get_DLC5_RogueLikePoolResultPanel_0;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeMethodInfoPtr_set_ResultPanel_Public_set_Void_DLC5_RogueLikePoolResultPanel_0;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeMethodInfoPtr_get_NullIndicator_Public_get_CanvasGroup_0;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr_set_NullIndicator_Private_set_Void_CanvasGroup_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr_get_HasKourindouCoupon_Public_get_Boolean_0;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr_set_HasKourindouCoupon_Private_set_Void_Boolean_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDiscount_Public_get_Single_0;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDiscount_Private_set_Void_Single_0;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstOpen_Public_get_Boolean_0;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeMethodInfoPtr_set_FirstOpen_Public_set_Void_Boolean_0;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeMethodInfoPtr_get_ShopCloseContext_Public_get_CloseContext_0;

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeMethodInfoPtr_set_ShopCloseContext_Public_set_Void_CloseContext_0;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeMethodInfoPtr_get_FundUpdateCallback_Private_get_Action_0;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeMethodInfoPtr_set_FundUpdateCallback_Public_set_Void_Action_0;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeMethodInfoPtr_get_GetFinalPriceCallback_Public_get_Func_2_Int32_Int32_0;

		// Token: 0x040015A9 RID: 5545
		private static readonly IntPtr NativeMethodInfoPtr_set_GetFinalPriceCallback_Public_set_Void_Func_2_Int32_Int32_0;

		// Token: 0x040015AA RID: 5546
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfirmBuyBtn_Public_get_UIButtonHold_0;

		// Token: 0x040015AB RID: 5547
		private static readonly IntPtr NativeMethodInfoPtr_SetSymbol_Public_Void_Boolean_0;

		// Token: 0x040015AC RID: 5548
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x040015AD RID: 5549
		private static readonly IntPtr NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_InspectingProductType_UIButtonToggle_UISubPanel_1_DLC5_RogueLikePurchasePanel_0;

		// Token: 0x040015AE RID: 5550
		private static readonly IntPtr NativeMethodInfoPtr_OnPostPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040015AF RID: 5551
		private static readonly IntPtr NativeMethodInfoPtr_DefaultOnItemEnabled_Private_Static_Void_T_UIElementCluster_Int32_Boolean_0;

		// Token: 0x040015B0 RID: 5552
		private static readonly IntPtr NativeMethodInfoPtr_DecorationOnItemEnabled_Private_Static_Void_T_UIElementCluster_Boolean_Boolean_0;

		// Token: 0x040015B1 RID: 5553
		private static readonly IntPtr NativeMethodInfoPtr_RecipeOnItemEnabled_Private_Static_Void_Recipe_UIElementCluster_Boolean_0;

		// Token: 0x040015B2 RID: 5554
		private static readonly IntPtr NativeMethodInfoPtr_DefaultOnSpecialGuestEnabled_Private_Static_Void_SpecialGuest_UIElementCluster_Int32_Boolean_0;

		// Token: 0x040015B3 RID: 5555
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelPreOpen_Protected_Virtual_Void_0;

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeMethodInfoPtr_OnPreOpenSubPanel_Protected_Virtual_Void_InspectingProductType_UISubPanel_1_DLC5_RogueLikePurchasePanel_0;

		// Token: 0x040015B5 RID: 5557
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_InspectingProductType_0;

		// Token: 0x040015B6 RID: 5558
		private static readonly IntPtr NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0;

		// Token: 0x040015B7 RID: 5559
		private static readonly IntPtr NativeMethodInfoPtr_AfterClose_Public_Void_0;

		// Token: 0x040015B8 RID: 5560
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTotalPrice_Public_Void_Int32_0;

		// Token: 0x040015B9 RID: 5561
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPopularTag_Private_Void_0;

		// Token: 0x040015BA RID: 5562
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanPopular_Private_Void_0;

		// Token: 0x040015BB RID: 5563
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPopularTagView_Private_Void_0;

		// Token: 0x040015BC RID: 5564
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShopTitle_Public_Void_String_0;

		// Token: 0x040015BD RID: 5565
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCartTitle_Public_Void_String_0;

		// Token: 0x040015BE RID: 5566
		private static readonly IntPtr NativeMethodInfoPtr_get_MapPanel_Private_get_DLC5_RogueLikeSpotSelectionPanel_New_0;

		// Token: 0x040015BF RID: 5567
		private static readonly IntPtr NativeMethodInfoPtr_set_MapPanel_Public_set_Void_DLC5_RogueLikeSpotSelectionPanel_New_0;

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeMethodInfoPtr_get_GetSelections_Private_get_Dictionary_2_CardType_String_0;

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeMethodInfoPtr_get_GetEliteChallengeTypeSelections_Private_get_Dictionary_2_EliteChallengeType_String_0;

		// Token: 0x040015C2 RID: 5570
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x040015C3 RID: 5571
		private static readonly IntPtr NativeMethodInfoPtr_StandardDeductProductAmount_Private_Static_Boolean_byref_Product_Int32_0;

		// Token: 0x040015C4 RID: 5572
		private static readonly IntPtr NativeMethodInfoPtr_ForceClearProductAmount_Private_Static_Boolean_0;

		// Token: 0x040015C5 RID: 5573
		private static readonly IntPtr NativeMethodInfoPtr_StandardGetProductAmount_Private_Static_Int32_byref_Product_0;

		// Token: 0x040015C6 RID: 5574
		private static readonly IntPtr NativeMethodInfoPtr_AmountAsPriceDeductProductAmount_Private_Static_Boolean_byref_Product_0;

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeMethodInfoPtr_AmountAsPriceGetProductAmount_Private_Static_Int32_byref_Product_0;

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeMethodInfoPtr_AmountAsPriceGetProductPrice_Private_Static_Int32_byref_Product_0;

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeMethodInfoPtr__OnPostPanelInitialize_b__96_0_Private_Void_0;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeMethodInfoPtr__OnPostPanelInitialize_b__96_4_Private_Void_CloseContext_0;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeMethodInfoPtr__OnPostPanelInitialize_b__96_5_Private_Void_0;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeMethodInfoPtr__OnPostPanelInitialize_b__96_1_Private_Void_CallbackContext_0;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeMethodInfoPtr__OnPostPanelInitialize_b__96_2_Private_Void_CallbackContext_0;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeMethodInfoPtr__OnPostPanelInitialize_b__96_3_Private_Void_CallbackContext_0;

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeMethodInfoPtr__get_GetSelections_b__127_2_Private_String_KeyValuePair_2_CardType_RogueLikeCardPersistent_0;

		// Token: 0x0200070D RID: 1805
		public static class RogueLikePurchasePanelLanguageProvider : Il2CppSystem.Object
		{
			// Token: 0x06009C5E RID: 40030 RVA: 0x00297810 File Offset: 0x00295A10
			// Note: this type is marked as 'beforefieldinit'.
			static RogueLikePurchasePanelLanguageProvider()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "RogueLikePurchasePanelLanguageProvider");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_WaveText_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider>.NativeClassPtr, 100668988);
				DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_PopRefresh_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider>.NativeClassPtr, 100668989);
				DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_PopNeutral_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider>.NativeClassPtr, 100668990);
				DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_Acquired_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider>.NativeClassPtr, 100668991);
				DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_Kourindou_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider>.NativeClassPtr, 100668992);
				DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_Shop_Cart_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider>.NativeClassPtr, 100668993);
				DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_Describer_Inshelf_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider>.NativeClassPtr, 100668994);
				DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_Store_Recycle_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider>.NativeClassPtr, 100668995);
			}

			// Token: 0x170033D3 RID: 13267
			// (get) Token: 0x06009C5F RID: 40031 RVA: 0x002978DC File Offset: 0x00295ADC
			public unsafe static string WaveText
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 78316, RefRangeEnd = 78318, XrefRangeStart = 78313, XrefRangeEnd = 78316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_WaveText_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170033D4 RID: 13268
			// (get) Token: 0x06009C60 RID: 40032 RVA: 0x00297908 File Offset: 0x00295B08
			public unsafe static string PopRefresh
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78318, XrefRangeEnd = 78321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_PopRefresh_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170033D5 RID: 13269
			// (get) Token: 0x06009C61 RID: 40033 RVA: 0x00297934 File Offset: 0x00295B34
			public unsafe static string PopNeutral
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78321, XrefRangeEnd = 78324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_PopNeutral_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170033D6 RID: 13270
			// (get) Token: 0x06009C62 RID: 40034 RVA: 0x00297960 File Offset: 0x00295B60
			public unsafe static string Acquired
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78324, XrefRangeEnd = 78327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_Acquired_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170033D7 RID: 13271
			// (get) Token: 0x06009C63 RID: 40035 RVA: 0x0029798C File Offset: 0x00295B8C
			public unsafe static string Kourindou
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78327, XrefRangeEnd = 78330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_Kourindou_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170033D8 RID: 13272
			// (get) Token: 0x06009C64 RID: 40036 RVA: 0x002979B8 File Offset: 0x00295BB8
			public unsafe static string Shop_Cart
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78330, XrefRangeEnd = 78333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_Shop_Cart_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170033D9 RID: 13273
			// (get) Token: 0x06009C65 RID: 40037 RVA: 0x002979E4 File Offset: 0x00295BE4
			public unsafe static string Describer_Inshelf
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78333, XrefRangeEnd = 78336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_Describer_Inshelf_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170033DA RID: 13274
			// (get) Token: 0x06009C66 RID: 40038 RVA: 0x00297A10 File Offset: 0x00295C10
			public unsafe static string Store_Recycle
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78336, XrefRangeEnd = 78339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RogueLikePurchasePanelLanguageProvider.NativeMethodInfoPtr_get_Store_Recycle_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06009C67 RID: 40039 RVA: 0x00054880 File Offset: 0x00052A80
			public RogueLikePurchasePanelLanguageProvider(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400659A RID: 26010
			private static readonly IntPtr NativeMethodInfoPtr_get_WaveText_Public_Static_get_String_0;

			// Token: 0x0400659B RID: 26011
			private static readonly IntPtr NativeMethodInfoPtr_get_PopRefresh_Public_Static_get_String_0;

			// Token: 0x0400659C RID: 26012
			private static readonly IntPtr NativeMethodInfoPtr_get_PopNeutral_Public_Static_get_String_0;

			// Token: 0x0400659D RID: 26013
			private static readonly IntPtr NativeMethodInfoPtr_get_Acquired_Public_Static_get_String_0;

			// Token: 0x0400659E RID: 26014
			private static readonly IntPtr NativeMethodInfoPtr_get_Kourindou_Public_Static_get_String_0;

			// Token: 0x0400659F RID: 26015
			private static readonly IntPtr NativeMethodInfoPtr_get_Shop_Cart_Public_Static_get_String_0;

			// Token: 0x040065A0 RID: 26016
			private static readonly IntPtr NativeMethodInfoPtr_get_Describer_Inshelf_Public_Static_get_String_0;

			// Token: 0x040065A1 RID: 26017
			private static readonly IntPtr NativeMethodInfoPtr_get_Store_Recycle_Public_Static_get_String_0;
		}

		// Token: 0x0200070E RID: 1806
		public class TypedOpenContext<TDataType, TDescribingType, TDescriberType> : DLC5_RogueLikePurchasePanel.OpenContext where TDataType : class where TDescriberType : MonoBehaviour
		{
			// Token: 0x06009C68 RID: 40040 RVA: 0x00297A3C File Offset: 0x00295C3C
			// Note: this type is marked as 'beforefieldinit'.
			static TypedOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "TypedOpenContext`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDataType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDescribingType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDescriberType>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_PreviewObject_Protected_Abstract_Virtual_New_Void_TDataType_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr, 100668996);
				DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_MapProduct_Protected_Abstract_Virtual_New_TDataType_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr, 100668997);
				DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_OnBuy_Protected_Abstract_Virtual_New_Void_IEnumerable_1_ValueTuple_2_TDataType_Int32_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr, 100668998);
				DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_MapData_Protected_Abstract_Virtual_New_TDescribingType_TDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr, 100668999);
				DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr, 100669000);
				DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_DescribeObject_Public_Virtual_Void_ITextProvider_1_LanguageBase_IDescriber_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr, 100669001);
				DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_PreviewObject_Public_Virtual_Void_ITextProvider_1_LanguageBase_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr, 100669002);
				DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_ProductToObject_Public_Virtual_ITextProvider_1_LanguageBase_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr, 100669003);
				DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_Buy_Public_Virtual_Void_IEnumerable_1_ValueTuple_2_ITextProvider_1_LanguageBase_Int32_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr, 100669004);
				DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_Cast_Private_Static_IEnumerable_1_ValueTuple_2_TDataType_Int32_IEnumerable_1_ValueTuple_2_ITextProvider_1_LanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr, 100669005);
			}

			// Token: 0x06009C69 RID: 40041 RVA: 0x00297B90 File Offset: 0x00295D90
			[CallerCount(0)]
			public unsafe virtual void PreviewObject(TDataType data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TDataType).IsValueType)
				{
					TDataType tdataType = data;
					intPtr = ((tdataType is string) ? IL2CPP.ManagedStringToIl2Cpp(tdataType as string) : IL2CPP.Il2CppObjectBaseToPtr(tdataType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref data;
				}
				ptr2 = intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_PreviewObject_Protected_Abstract_Virtual_New_Void_TDataType_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x06009C6A RID: 40042 RVA: 0x00297C54 File Offset: 0x00295E54
			[CallerCount(0)]
			public unsafe virtual TDataType MapProduct([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_MapProduct_Protected_Abstract_Virtual_New_TDataType_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TDataType>(intPtr, false, true);
			}

			// Token: 0x06009C6B RID: 40043 RVA: 0x00297CAC File Offset: 0x00295EAC
			[CallerCount(0)]
			public unsafe virtual void OnBuy(IEnumerable<ValueTuple<TDataType, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boughtData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_OnBuy_Protected_Abstract_Virtual_New_Void_IEnumerable_1_ValueTuple_2_TDataType_Int32_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C6C RID: 40044 RVA: 0x00297D0C File Offset: 0x00295F0C
			[CallerCount(0)]
			public unsafe virtual TDescribingType MapData(TDataType dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TDataType).IsValueType)
				{
					TDataType tdataType = dataType;
					intPtr = ((tdataType is string) ? IL2CPP.ManagedStringToIl2Cpp(tdataType as string) : IL2CPP.Il2CppObjectBaseToPtr(tdataType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref dataType;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_MapData_Protected_Abstract_Virtual_New_TDescribingType_TDataType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TDescribingType>(intPtr2, false, true);
			}

			// Token: 0x06009C6D RID: 40045 RVA: 0x00297D98 File Offset: 0x00295F98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78380, XrefRangeEnd = 78385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypedOpenContext(SelectionMode selectionMode, Il2CppStructArray<Product.ProductType> productsTypeFilter, DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> selections, int maxBuy) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionMode;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productsTypeFilter);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataSource);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selections);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxBuy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C6E RID: 40046 RVA: 0x00297E24 File Offset: 0x00296024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78385, XrefRangeEnd = 78399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void DescribeObject(ITextProvider<LanguageBase> nonTradableObjectBase, IDescriber describer, CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nonTradableObjectBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_DescribeObject_Public_Virtual_Void_ITextProvider_1_LanguageBase_IDescriber_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C6F RID: 40047 RVA: 0x00297E9C File Offset: 0x0029609C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78399, XrefRangeEnd = 78403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void PreviewObject(ITextProvider<LanguageBase> nonTradableObjectBase, UIElementCluster uiElementCluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nonTradableObjectBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_PreviewObject_Public_Virtual_Void_ITextProvider_1_LanguageBase_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C70 RID: 40048 RVA: 0x00297F2C File Offset: 0x0029612C
			[CallerCount(0)]
			public unsafe override ITextProvider<LanguageBase> ProductToObject([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_ProductToObject_Public_Virtual_ITextProvider_1_LanguageBase_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITextProvider<LanguageBase>>(intPtr3) : null;
			}

			// Token: 0x06009C71 RID: 40049 RVA: 0x00297F88 File Offset: 0x00296188
			[CallerCount(0)]
			public unsafe override void Buy(IEnumerable<ValueTuple<ITextProvider<LanguageBase>, int>> data, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_Buy_Public_Virtual_Void_IEnumerable_1_ValueTuple_2_ITextProvider_1_LanguageBase_Int32_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C72 RID: 40050 RVA: 0x00297FE8 File Offset: 0x002961E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78403, XrefRangeEnd = 78409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IEnumerable<ValueTuple<TDataType, int>> Cast(IEnumerable<ValueTuple<ITextProvider<LanguageBase>, int>> collection)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_Cast_Private_Static_IEnumerable_1_ValueTuple_2_TDataType_Int32_IEnumerable_1_ValueTuple_2_ITextProvider_1_LanguageBase_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<TDataType, int>>>(intPtr3) : null;
			}

			// Token: 0x06009C73 RID: 40051 RVA: 0x00054889 File Offset: 0x00052A89
			public TypedOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040065A2 RID: 26018
			private static readonly IntPtr NativeMethodInfoPtr_PreviewObject_Protected_Abstract_Virtual_New_Void_TDataType_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0;

			// Token: 0x040065A3 RID: 26019
			private static readonly IntPtr NativeMethodInfoPtr_MapProduct_Protected_Abstract_Virtual_New_TDataType_byref_Product_0;

			// Token: 0x040065A4 RID: 26020
			private static readonly IntPtr NativeMethodInfoPtr_OnBuy_Protected_Abstract_Virtual_New_Void_IEnumerable_1_ValueTuple_2_TDataType_Int32_RogueLikeRunTimeData_0;

			// Token: 0x040065A5 RID: 26021
			private static readonly IntPtr NativeMethodInfoPtr_MapData_Protected_Abstract_Virtual_New_TDescribingType_TDataType_0;

			// Token: 0x040065A6 RID: 26022
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0;

			// Token: 0x040065A7 RID: 26023
			private static readonly IntPtr NativeMethodInfoPtr_DescribeObject_Public_Virtual_Void_ITextProvider_1_LanguageBase_IDescriber_CancellationToken_0;

			// Token: 0x040065A8 RID: 26024
			private static readonly IntPtr NativeMethodInfoPtr_PreviewObject_Public_Virtual_Void_ITextProvider_1_LanguageBase_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0;

			// Token: 0x040065A9 RID: 26025
			private static readonly IntPtr NativeMethodInfoPtr_ProductToObject_Public_Virtual_ITextProvider_1_LanguageBase_byref_Product_0;

			// Token: 0x040065AA RID: 26026
			private static readonly IntPtr NativeMethodInfoPtr_Buy_Public_Virtual_Void_IEnumerable_1_ValueTuple_2_ITextProvider_1_LanguageBase_Int32_RogueLikeRunTimeData_0;

			// Token: 0x040065AB RID: 26027
			private static readonly IntPtr NativeMethodInfoPtr_Cast_Private_Static_IEnumerable_1_ValueTuple_2_TDataType_Int32_IEnumerable_1_ValueTuple_2_ITextProvider_1_LanguageBase_Int32_0;

			// Token: 0x02000FCC RID: 4044
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+TypedOpenContext`3+<Cast>d__9")]
			public sealed class _Cast_d__9 : Il2CppSystem.Object
			{
				// Token: 0x06011646 RID: 71238 RVA: 0x003FF924 File Offset: 0x003FDB24
				// Note: this type is marked as 'beforefieldinit'.
				static _Cast_d__9()
				{
					Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr, "<Cast>d__9"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDataType>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDescribingType>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDescriberType>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr);
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, "<>1__state");
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, "<>2__current");
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, "<>l__initialThreadId");
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, "collection");
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___3__collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, "<>3__collection");
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, "<>7__wrap1");
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, 100669006);
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, 100669007);
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, 100669008);
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, 100669009);
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_TDataType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, 100669010);
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, 100669011);
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, 100669012);
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_TDataType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, 100669013);
					DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr, 100669014);
				}

				// Token: 0x06011647 RID: 71239 RVA: 0x003FFADC File Offset: 0x003FDCDC
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 78341, RefRangeEnd = 78342, XrefRangeStart = 78339, XrefRangeEnd = 78341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _Cast_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011648 RID: 71240 RVA: 0x003FFB24 File Offset: 0x003FDD24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78342, XrefRangeEnd = 78344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011649 RID: 71241 RVA: 0x003FFB58 File Offset: 0x003FDD58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78344, XrefRangeEnd = 78364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0601164A RID: 71242 RVA: 0x003FFB94 File Offset: 0x003FDD94
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78364, XrefRangeEnd = 78367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __m__Finally1()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005A70 RID: 23152
				// (get) Token: 0x0601164B RID: 71243 RVA: 0x003FFBC8 File Offset: 0x003FDDC8
				public unsafe ValueTuple<TDataType, int> prop_ValueTuple_2_TDataType_Int32_0
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr;
						IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_TDataType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
						Il2CppException.RaiseExceptionIfNecessary(intPtr);
						return new ValueTuple<TDataType, int>(pointer);
					}
				}

				// Token: 0x0601164C RID: 71244 RVA: 0x003FFC00 File Offset: 0x003FDE00
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78367, XrefRangeEnd = 78373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005A71 RID: 23153
				// (get) Token: 0x0601164D RID: 71245 RVA: 0x003FFC34 File Offset: 0x003FDE34
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78373, XrefRangeEnd = 78375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601164E RID: 71246 RVA: 0x003FFC74 File Offset: 0x003FDE74
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78375, XrefRangeEnd = 78380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<ValueTuple<TDataType, int>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_TDataType_Int32_0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_TDataType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<TDataType, int>>>(intPtr3) : null;
				}

				// Token: 0x0601164F RID: 71247 RVA: 0x003FFCB4 File Offset: 0x003FDEB4
				[CallerCount(0)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x06011650 RID: 71248 RVA: 0x0009753C File Offset: 0x0009573C
				public _Cast_d__9(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A6A RID: 23146
				// (get) Token: 0x06011651 RID: 71249 RVA: 0x003FFCF4 File Offset: 0x003FDEF4
				// (set) Token: 0x06011652 RID: 71250 RVA: 0x00097545 File Offset: 0x00095745
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005A6B RID: 23147
				// (get) Token: 0x06011653 RID: 71251 RVA: 0x003FFD1C File Offset: 0x003FDF1C
				// (set) Token: 0x06011654 RID: 71252 RVA: 0x00097560 File Offset: 0x00095760
				public ValueTuple<TDataType, int> __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___2__current);
						return new ValueTuple<TDataType, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<TDataType, int>>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<TDataType, int>>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005A6C RID: 23148
				// (get) Token: 0x06011655 RID: 71253 RVA: 0x003FFD4C File Offset: 0x003FDF4C
				// (set) Token: 0x06011656 RID: 71254 RVA: 0x0009758E File Offset: 0x0009578E
				public unsafe int __l__initialThreadId
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___l__initialThreadId);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
					}
				}

				// Token: 0x17005A6D RID: 23149
				// (get) Token: 0x06011657 RID: 71255 RVA: 0x003FFD74 File Offset: 0x003FDF74
				// (set) Token: 0x06011658 RID: 71256 RVA: 0x000975A9 File Offset: 0x000957A9
				public unsafe IEnumerable<ValueTuple<ITextProvider<LanguageBase>, int>> collection
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr_collection);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<ITextProvider<LanguageBase>, int>>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A6E RID: 23150
				// (get) Token: 0x06011659 RID: 71257 RVA: 0x003FFDA4 File Offset: 0x003FDFA4
				// (set) Token: 0x0601165A RID: 71258 RVA: 0x000975C8 File Offset: 0x000957C8
				public unsafe IEnumerable<ValueTuple<ITextProvider<LanguageBase>, int>> __3__collection
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___3__collection);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<ITextProvider<LanguageBase>, int>>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___3__collection), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A6F RID: 23151
				// (get) Token: 0x0601165B RID: 71259 RVA: 0x003FFDD4 File Offset: 0x003FDFD4
				// (set) Token: 0x0601165C RID: 71260 RVA: 0x000975E7 File Offset: 0x000957E7
				public unsafe IEnumerator<ValueTuple<ITextProvider<LanguageBase>, int>> __7__wrap1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___7__wrap1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<ITextProvider<LanguageBase>, int>>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType>._Cast_d__9.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AFC2 RID: 44994
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AFC3 RID: 44995
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AFC4 RID: 44996
				private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

				// Token: 0x0400AFC5 RID: 44997
				private static readonly IntPtr NativeFieldInfoPtr_collection;

				// Token: 0x0400AFC6 RID: 44998
				private static readonly IntPtr NativeFieldInfoPtr___3__collection;

				// Token: 0x0400AFC7 RID: 44999
				private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

				// Token: 0x0400AFC8 RID: 45000
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AFC9 RID: 45001
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AFCA RID: 45002
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AFCB RID: 45003
				private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

				// Token: 0x0400AFCC RID: 45004
				private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_TDataType_Int32_0;

				// Token: 0x0400AFCD RID: 45005
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AFCE RID: 45006
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AFCF RID: 45007
				private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_TDataType_Int32_0;

				// Token: 0x0400AFD0 RID: 45008
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
			}
		}

		// Token: 0x0200070F RID: 1807
		public class OpenContext : Il2CppSystem.Object
		{
			// Token: 0x06009C74 RID: 40052 RVA: 0x0029802C File Offset: 0x0029622C
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__SelectionMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, "<SelectionMode>k__BackingField");
				DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__Selections_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, "<Selections>k__BackingField");
				DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__MaxBuy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, "<MaxBuy>k__BackingField");
				DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__ProductsTypeFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, "<ProductsTypeFilter>k__BackingField");
				DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__DataSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, "<DataSource>k__BackingField");
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_get_SelectionMode_Public_get_SelectionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669015);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_get_Selections_Public_get_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669016);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_get_MaxBuy_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669017);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_get_ProductsTypeFilter_Public_get_HashSet_1_ProductType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669018);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_get_DataSource_Public_get_IRogueLikePurchaseDataSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669019);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669020);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_GetCurrentBuyCount_Public_Virtual_New_Int32_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669021);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_DescribeObject_Public_Abstract_Virtual_New_Void_ITextProvider_1_LanguageBase_IDescriber_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669022);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_PreviewObject_Public_Abstract_Virtual_New_Void_ITextProvider_1_LanguageBase_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669023);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_Buy_Public_Abstract_Virtual_New_Void_IEnumerable_1_ValueTuple_2_ITextProvider_1_LanguageBase_Int32_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669024);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_ProductToObject_Public_Abstract_Virtual_New_ITextProvider_1_LanguageBase_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669025);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Abstract_Virtual_New_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669026);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Abstract_Virtual_New_Boolean_byref_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669027);
				DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Abstract_Virtual_New_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr, 100669028);
			}

			// Token: 0x170033E0 RID: 13280
			// (get) Token: 0x06009C75 RID: 40053 RVA: 0x002981D4 File Offset: 0x002963D4
			public unsafe SelectionMode SelectionMode
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_get_SelectionMode_Public_get_SelectionMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170033E1 RID: 13281
			// (get) Token: 0x06009C76 RID: 40054 RVA: 0x00298210 File Offset: 0x00296410
			public unsafe IList<int> Selections
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_get_Selections_Public_get_IList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<int>>(intPtr3) : null;
				}
			}

			// Token: 0x170033E2 RID: 13282
			// (get) Token: 0x06009C77 RID: 40055 RVA: 0x00298250 File Offset: 0x00296450
			public unsafe int MaxBuy
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 39817, RefRangeEnd = 39820, XrefRangeStart = 39817, XrefRangeEnd = 39820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_get_MaxBuy_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170033E3 RID: 13283
			// (get) Token: 0x06009C78 RID: 40056 RVA: 0x0029828C File Offset: 0x0029648C
			public unsafe HashSet<Product.ProductType> ProductsTypeFilter
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_get_ProductsTypeFilter_Public_get_HashSet_1_ProductType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<Product.ProductType>>(intPtr3) : null;
				}
			}

			// Token: 0x170033E4 RID: 13284
			// (get) Token: 0x06009C79 RID: 40057 RVA: 0x002982CC File Offset: 0x002964CC
			public unsafe DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource DataSource
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_get_DataSource_Public_get_IRogueLikePurchaseDataSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource>(intPtr3) : null;
				}
			}

			// Token: 0x06009C7A RID: 40058 RVA: 0x0029830C File Offset: 0x0029650C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 78416, RefRangeEnd = 78417, XrefRangeStart = 78409, XrefRangeEnd = 78416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(SelectionMode selectionMode, Il2CppStructArray<Product.ProductType> productsTypeFilter, DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> selections, int maxBuy) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionMode;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productsTypeFilter);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataSource);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selections);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxBuy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C7B RID: 40059 RVA: 0x00298398 File Offset: 0x00296598
			[CallerCount(0)]
			public unsafe virtual int GetCurrentBuyCount(RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_GetCurrentBuyCount_Public_Virtual_New_Int32_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C7C RID: 40060 RVA: 0x002983F0 File Offset: 0x002965F0
			[CallerCount(0)]
			public unsafe virtual void DescribeObject(ITextProvider<LanguageBase> nonTradableObjectBase, IDescriber describer, CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nonTradableObjectBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_DescribeObject_Public_Abstract_Virtual_New_Void_ITextProvider_1_LanguageBase_IDescriber_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C7D RID: 40061 RVA: 0x00298468 File Offset: 0x00296668
			[CallerCount(0)]
			public unsafe virtual void PreviewObject(ITextProvider<LanguageBase> objectBase, UIElementCluster uiElementCluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_PreviewObject_Public_Abstract_Virtual_New_Void_ITextProvider_1_LanguageBase_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C7E RID: 40062 RVA: 0x002984F8 File Offset: 0x002966F8
			[CallerCount(0)]
			public unsafe virtual void Buy(IEnumerable<ValueTuple<ITextProvider<LanguageBase>, int>> data, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_Buy_Public_Abstract_Virtual_New_Void_IEnumerable_1_ValueTuple_2_ITextProvider_1_LanguageBase_Int32_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C7F RID: 40063 RVA: 0x00298558 File Offset: 0x00296758
			[CallerCount(0)]
			public unsafe virtual ITextProvider<LanguageBase> ProductToObject([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_ProductToObject_Public_Abstract_Virtual_New_ITextProvider_1_LanguageBase_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITextProvider<LanguageBase>>(intPtr3) : null;
			}

			// Token: 0x06009C80 RID: 40064 RVA: 0x002985B4 File Offset: 0x002967B4
			[CallerCount(0)]
			public unsafe virtual int GetProductPrice([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Abstract_Virtual_New_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C81 RID: 40065 RVA: 0x00298610 File Offset: 0x00296810
			[CallerCount(0)]
			public unsafe virtual bool DeductProductAmount(ref Product product, int amount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Abstract_Virtual_New_Boolean_byref_Product_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C82 RID: 40066 RVA: 0x00298678 File Offset: 0x00296878
			[CallerCount(0)]
			public unsafe virtual int GetProductAmount([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.OpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Abstract_Virtual_New_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C83 RID: 40067 RVA: 0x00054892 File Offset: 0x00052A92
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033DB RID: 13275
			// (get) Token: 0x06009C84 RID: 40068 RVA: 0x002986D4 File Offset: 0x002968D4
			// (set) Token: 0x06009C85 RID: 40069 RVA: 0x0005489B File Offset: 0x00052A9B
			public unsafe SelectionMode _SelectionMode_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__SelectionMode_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__SelectionMode_k__BackingField)) = value;
				}
			}

			// Token: 0x170033DC RID: 13276
			// (get) Token: 0x06009C86 RID: 40070 RVA: 0x002986FC File Offset: 0x002968FC
			// (set) Token: 0x06009C87 RID: 40071 RVA: 0x000548B6 File Offset: 0x00052AB6
			public unsafe IList<int> _Selections_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__Selections_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__Selections_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033DD RID: 13277
			// (get) Token: 0x06009C88 RID: 40072 RVA: 0x0029872C File Offset: 0x0029692C
			// (set) Token: 0x06009C89 RID: 40073 RVA: 0x000548D5 File Offset: 0x00052AD5
			public unsafe int _MaxBuy_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__MaxBuy_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__MaxBuy_k__BackingField)) = value;
				}
			}

			// Token: 0x170033DE RID: 13278
			// (get) Token: 0x06009C8A RID: 40074 RVA: 0x00298754 File Offset: 0x00296954
			// (set) Token: 0x06009C8B RID: 40075 RVA: 0x000548F0 File Offset: 0x00052AF0
			public unsafe HashSet<Product.ProductType> _ProductsTypeFilter_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__ProductsTypeFilter_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Product.ProductType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__ProductsTypeFilter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033DF RID: 13279
			// (get) Token: 0x06009C8C RID: 40076 RVA: 0x00298784 File Offset: 0x00296984
			// (set) Token: 0x06009C8D RID: 40077 RVA: 0x0005490F File Offset: 0x00052B0F
			public unsafe DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource _DataSource_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__DataSource_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.OpenContext.NativeFieldInfoPtr__DataSource_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040065AC RID: 26028
			private static readonly IntPtr NativeFieldInfoPtr__SelectionMode_k__BackingField;

			// Token: 0x040065AD RID: 26029
			private static readonly IntPtr NativeFieldInfoPtr__Selections_k__BackingField;

			// Token: 0x040065AE RID: 26030
			private static readonly IntPtr NativeFieldInfoPtr__MaxBuy_k__BackingField;

			// Token: 0x040065AF RID: 26031
			private static readonly IntPtr NativeFieldInfoPtr__ProductsTypeFilter_k__BackingField;

			// Token: 0x040065B0 RID: 26032
			private static readonly IntPtr NativeFieldInfoPtr__DataSource_k__BackingField;

			// Token: 0x040065B1 RID: 26033
			private static readonly IntPtr NativeMethodInfoPtr_get_SelectionMode_Public_get_SelectionMode_0;

			// Token: 0x040065B2 RID: 26034
			private static readonly IntPtr NativeMethodInfoPtr_get_Selections_Public_get_IList_1_Int32_0;

			// Token: 0x040065B3 RID: 26035
			private static readonly IntPtr NativeMethodInfoPtr_get_MaxBuy_Public_get_Int32_0;

			// Token: 0x040065B4 RID: 26036
			private static readonly IntPtr NativeMethodInfoPtr_get_ProductsTypeFilter_Public_get_HashSet_1_ProductType_0;

			// Token: 0x040065B5 RID: 26037
			private static readonly IntPtr NativeMethodInfoPtr_get_DataSource_Public_get_IRogueLikePurchaseDataSource_0;

			// Token: 0x040065B6 RID: 26038
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0;

			// Token: 0x040065B7 RID: 26039
			private static readonly IntPtr NativeMethodInfoPtr_GetCurrentBuyCount_Public_Virtual_New_Int32_RogueLikeRunTimeData_0;

			// Token: 0x040065B8 RID: 26040
			private static readonly IntPtr NativeMethodInfoPtr_DescribeObject_Public_Abstract_Virtual_New_Void_ITextProvider_1_LanguageBase_IDescriber_CancellationToken_0;

			// Token: 0x040065B9 RID: 26041
			private static readonly IntPtr NativeMethodInfoPtr_PreviewObject_Public_Abstract_Virtual_New_Void_ITextProvider_1_LanguageBase_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0;

			// Token: 0x040065BA RID: 26042
			private static readonly IntPtr NativeMethodInfoPtr_Buy_Public_Abstract_Virtual_New_Void_IEnumerable_1_ValueTuple_2_ITextProvider_1_LanguageBase_Int32_RogueLikeRunTimeData_0;

			// Token: 0x040065BB RID: 26043
			private static readonly IntPtr NativeMethodInfoPtr_ProductToObject_Public_Abstract_Virtual_New_ITextProvider_1_LanguageBase_byref_Product_0;

			// Token: 0x040065BC RID: 26044
			private static readonly IntPtr NativeMethodInfoPtr_GetProductPrice_Public_Abstract_Virtual_New_Int32_byref_Product_0;

			// Token: 0x040065BD RID: 26045
			private static readonly IntPtr NativeMethodInfoPtr_DeductProductAmount_Public_Abstract_Virtual_New_Boolean_byref_Product_Int32_0;

			// Token: 0x040065BE RID: 26046
			private static readonly IntPtr NativeMethodInfoPtr_GetProductAmount_Public_Abstract_Virtual_New_Int32_byref_Product_0;
		}

		// Token: 0x02000710 RID: 1808
		public class ItemTypeOpenContext<TDataType, TDescribingType, TDescriberType> : DLC5_RogueLikePurchasePanel.TypedOpenContext<TDataType, TDescribingType, TDescriberType> where TDataType : class where TDescriberType : MonoBehaviour
		{
			// Token: 0x06009C8E RID: 40078 RVA: 0x002987B4 File Offset: 0x002969B4
			// Note: this type is marked as 'beforefieldinit'.
			static ItemTypeOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "ItemTypeOpenContext`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDataType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDescribingType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDescriberType>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr, 100669029);
				DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_TDataType_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr, 100669030);
			}

			// Token: 0x06009C8F RID: 40079 RVA: 0x00298868 File Offset: 0x00296A68
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 78417, RefRangeEnd = 78431, XrefRangeStart = 78417, XrefRangeEnd = 78417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemTypeOpenContext(SelectionMode selectionMode, Il2CppStructArray<Product.ProductType> productsTypeFilter, DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> selections, int maxBuy) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<TDataType, TDescribingType, TDescriberType>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionMode;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productsTypeFilter);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataSource);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selections);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxBuy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C90 RID: 40080 RVA: 0x002988F4 File Offset: 0x00296AF4
			[CallerCount(0)]
			public unsafe override void PreviewObject(TDataType data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TDataType).IsValueType)
				{
					TDataType tdataType = data;
					intPtr = ((tdataType is string) ? IL2CPP.ManagedStringToIl2Cpp(tdataType as string) : IL2CPP.Il2CppObjectBaseToPtr(tdataType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref data;
				}
				ptr2 = intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<TDataType, TDescribingType, TDescriberType>.NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_TDataType_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x06009C91 RID: 40081 RVA: 0x0005492E File Offset: 0x00052B2E
			public ItemTypeOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040065BF RID: 26047
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0;

			// Token: 0x040065C0 RID: 26048
			private static readonly IntPtr NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_TDataType_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0;
		}

		// Token: 0x02000711 RID: 1809
		public class SpecialGuestTypeOpenContext<TDescriber> : DLC5_RogueLikePurchasePanel.TypedOpenContext<SpecialGuest, SpecialGuest, TDescriber> where TDescriber : MonoBehaviour
		{
			// Token: 0x06009C92 RID: 40082 RVA: 0x002989B8 File Offset: 0x00296BB8
			// Note: this type is marked as 'beforefieldinit'.
			static SpecialGuestTypeOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "SpecialGuestTypeOpenContext`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDescriber>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>>.NativeClassPtr, 100669031);
				DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Final_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>>.NativeClassPtr, 100669032);
				DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Final_Boolean_byref_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>>.NativeClassPtr, 100669033);
				DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Final_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>>.NativeClassPtr, 100669034);
				DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr_MapProduct_Protected_Virtual_Final_SpecialGuest_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>>.NativeClassPtr, 100669035);
				DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr_MapData_Protected_Virtual_SpecialGuest_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>>.NativeClassPtr, 100669036);
				DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_SpecialGuest_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>>.NativeClassPtr, 100669037);
			}

			// Token: 0x06009C93 RID: 40083 RVA: 0x00298AAC File Offset: 0x00296CAC
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 78417, RefRangeEnd = 78431, XrefRangeStart = 78417, XrefRangeEnd = 78431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialGuestTypeOpenContext(SelectionMode selectionMode, Il2CppStructArray<Product.ProductType> productsTypeFilter, DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> selections, int maxBuy) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionMode;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productsTypeFilter);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataSource);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selections);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxBuy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C94 RID: 40084 RVA: 0x00298B38 File Offset: 0x00296D38
			[CallerCount(0)]
			public unsafe override int GetProductPrice([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Final_Int32_byref_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C95 RID: 40085 RVA: 0x00298B88 File Offset: 0x00296D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78431, XrefRangeEnd = 78432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool DeductProductAmount(ref Product product, int amount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Final_Boolean_byref_Product_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C96 RID: 40086 RVA: 0x00298BE4 File Offset: 0x00296DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78432, XrefRangeEnd = 78433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetProductAmount([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Final_Int32_byref_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009C97 RID: 40087 RVA: 0x00298C34 File Offset: 0x00296E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78433, XrefRangeEnd = 78437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override SpecialGuest MapProduct([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr_MapProduct_Protected_Virtual_Final_SpecialGuest_byref_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
			}

			// Token: 0x06009C98 RID: 40088 RVA: 0x00298C88 File Offset: 0x00296E88
			[CallerCount(0)]
			public unsafe override SpecialGuest MapData(SpecialGuest dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr_MapData_Protected_Virtual_SpecialGuest_SpecialGuest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
			}

			// Token: 0x06009C99 RID: 40089 RVA: 0x00298CE4 File Offset: 0x00296EE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78437, XrefRangeEnd = 78438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void PreviewObject(SpecialGuest data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<TDescriber>.NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_SpecialGuest_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C9A RID: 40090 RVA: 0x00054937 File Offset: 0x00052B37
			public SpecialGuestTypeOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040065C1 RID: 26049
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0;

			// Token: 0x040065C2 RID: 26050
			private static readonly IntPtr NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Final_Int32_byref_Product_0;

			// Token: 0x040065C3 RID: 26051
			private static readonly IntPtr NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Final_Boolean_byref_Product_Int32_0;

			// Token: 0x040065C4 RID: 26052
			private static readonly IntPtr NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Final_Int32_byref_Product_0;

			// Token: 0x040065C5 RID: 26053
			private static readonly IntPtr NativeMethodInfoPtr_MapProduct_Protected_Virtual_Final_SpecialGuest_byref_Product_0;

			// Token: 0x040065C6 RID: 26054
			private static readonly IntPtr NativeMethodInfoPtr_MapData_Protected_Virtual_SpecialGuest_SpecialGuest_0;

			// Token: 0x040065C7 RID: 26055
			private static readonly IntPtr NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_SpecialGuest_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0;
		}

		// Token: 0x02000712 RID: 1810
		public class UnifiedItemTypeOpenContext<TDataType, TDescriberType> : DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<TDataType, TDataType, TDescriberType> where TDataType : class where TDescriberType : MonoBehaviour
		{
			// Token: 0x06009C9B RID: 40091 RVA: 0x00298D74 File Offset: 0x00296F74
			// Note: this type is marked as 'beforefieldinit'.
			static UnifiedItemTypeOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<TDataType, TDescriberType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "UnifiedItemTypeOpenContext`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDataType>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDescriberType>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<TDataType, TDescriberType>>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<TDataType, TDescriberType>.NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<TDataType, TDescriberType>>.NativeClassPtr, 100669038);
				DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<TDataType, TDescriberType>.NativeMethodInfoPtr_MapData_Protected_Virtual_Final_TDataType_TDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<TDataType, TDescriberType>>.NativeClassPtr, 100669039);
			}

			// Token: 0x06009C9C RID: 40092 RVA: 0x00298E14 File Offset: 0x00297014
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 78417, RefRangeEnd = 78431, XrefRangeStart = 78417, XrefRangeEnd = 78431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnifiedItemTypeOpenContext(SelectionMode selectionMode, Il2CppStructArray<Product.ProductType> productsTypeFilter, DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> selections, int maxBuy) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<TDataType, TDescriberType>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectionMode;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productsTypeFilter);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataSource);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selections);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxBuy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<TDataType, TDescriberType>.NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C9D RID: 40093 RVA: 0x00298EA0 File Offset: 0x002970A0
			[CallerCount(0)]
			public unsafe override TDataType MapData(TDataType dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TDataType).IsValueType)
				{
					TDataType tdataType = dataType;
					intPtr = ((tdataType is string) ? IL2CPP.ManagedStringToIl2Cpp(tdataType as string) : IL2CPP.Il2CppObjectBaseToPtr(tdataType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref dataType;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<TDataType, TDescriberType>.NativeMethodInfoPtr_MapData_Protected_Virtual_Final_TDataType_TDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TDataType>(intPtr2, false, true);
			}

			// Token: 0x06009C9E RID: 40094 RVA: 0x00054940 File Offset: 0x00052B40
			public UnifiedItemTypeOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040065C8 RID: 26056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SelectionMode_Il2CppStructArray_1_ProductType_IRogueLikePurchaseDataSource_IList_1_Int32_Int32_0;

			// Token: 0x040065C9 RID: 26057
			private static readonly IntPtr NativeMethodInfoPtr_MapData_Protected_Virtual_Final_TDataType_TDataType_0;
		}

		// Token: 0x02000713 RID: 1811
		public class IngredientAndBeverageOpenContext : DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<TradableObjectBase, SellableDescriber>
		{
			// Token: 0x06009C9F RID: 40095 RVA: 0x00298F20 File Offset: 0x00297120
			// Note: this type is marked as 'beforefieldinit'.
			static IngredientAndBeverageOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "IngredientAndBeverageOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext>.NativeClassPtr, 100669040);
				DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_TradableObjectBase_Int32_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext>.NativeClassPtr, 100669041);
				DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.NativeMethodInfoPtr_MapProduct_Protected_Virtual_TradableObjectBase_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext>.NativeClassPtr, 100669042);
				DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext>.NativeClassPtr, 100669043);
				DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext>.NativeClassPtr, 100669044);
				DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext>.NativeClassPtr, 100669045);
			}

			// Token: 0x06009CA0 RID: 40096 RVA: 0x00298FC4 File Offset: 0x002971C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78448, XrefRangeEnd = 78454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IngredientAndBeverageOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CA1 RID: 40097 RVA: 0x00299010 File Offset: 0x00297210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78454, XrefRangeEnd = 78525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnBuy(IEnumerable<ValueTuple<TradableObjectBase, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boughtData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_TradableObjectBase_Int32_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CA2 RID: 40098 RVA: 0x00299070 File Offset: 0x00297270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78525, XrefRangeEnd = 78527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override TradableObjectBase MapProduct([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.NativeMethodInfoPtr_MapProduct_Protected_Virtual_TradableObjectBase_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TradableObjectBase>(intPtr3) : null;
			}

			// Token: 0x06009CA3 RID: 40099 RVA: 0x002990CC File Offset: 0x002972CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78527, XrefRangeEnd = 78529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetProductPrice([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CA4 RID: 40100 RVA: 0x00299128 File Offset: 0x00297328
			[CallerCount(0)]
			public unsafe override bool DeductProductAmount(ref Product product, int amount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CA5 RID: 40101 RVA: 0x00299190 File Offset: 0x00297390
			[CallerCount(0)]
			public unsafe override int GetProductAmount([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CA6 RID: 40102 RVA: 0x00054949 File Offset: 0x00052B49
			public IngredientAndBeverageOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040065CA RID: 26058
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0;

			// Token: 0x040065CB RID: 26059
			private static readonly IntPtr NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_TradableObjectBase_Int32_RogueLikeRunTimeData_0;

			// Token: 0x040065CC RID: 26060
			private static readonly IntPtr NativeMethodInfoPtr_MapProduct_Protected_Virtual_TradableObjectBase_byref_Product_0;

			// Token: 0x040065CD RID: 26061
			private static readonly IntPtr NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0;

			// Token: 0x040065CE RID: 26062
			private static readonly IntPtr NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0;

			// Token: 0x040065CF RID: 26063
			private static readonly IntPtr NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0;

			// Token: 0x02000FCD RID: 4045
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+IngredientAndBeverageOpenContext+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x0601165D RID: 71261 RVA: 0x003FFE04 File Offset: 0x003FE004
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>.NativeClassPtr);
					DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>.NativeClassPtr, "<>9");
					DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>.NativeClassPtr, "<>9__1_0");
					DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>.NativeClassPtr, "<>9__1_1");
					DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9__1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>.NativeClassPtr, "<>9__1_2");
					DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9__1_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>.NativeClassPtr, "<>9__1_3");
					DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>.NativeClassPtr, 100669047);
					DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_0_Internal_Boolean_ValueTuple_2_TradableObjectBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>.NativeClassPtr, 100669048);
					DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_1_Internal_IEnumerable_1_Int32_ValueTuple_2_TradableObjectBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>.NativeClassPtr, 100669049);
					DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_2_Internal_Boolean_ValueTuple_2_TradableObjectBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>.NativeClassPtr, 100669050);
					DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_3_Internal_IEnumerable_1_Int32_ValueTuple_2_TradableObjectBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>.NativeClassPtr, 100669051);
				}

				// Token: 0x0601165E RID: 71262 RVA: 0x003FFEF8 File Offset: 0x003FE0F8
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601165F RID: 71263 RVA: 0x003FFF34 File Offset: 0x003FE134
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78438, XrefRangeEnd = 78439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _OnBuy_b__1_0(ValueTuple<TradableObjectBase, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_0_Internal_Boolean_ValueTuple_2_TradableObjectBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011660 RID: 71264 RVA: 0x003FFF88 File Offset: 0x003FE188
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78439, XrefRangeEnd = 78443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerable<int> _OnBuy_b__1_1(ValueTuple<TradableObjectBase, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_1_Internal_IEnumerable_1_Int32_ValueTuple_2_TradableObjectBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}

				// Token: 0x06011661 RID: 71265 RVA: 0x003FFFE0 File Offset: 0x003FE1E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78443, XrefRangeEnd = 78444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _OnBuy_b__1_2(ValueTuple<TradableObjectBase, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_2_Internal_Boolean_ValueTuple_2_TradableObjectBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011662 RID: 71266 RVA: 0x00400034 File Offset: 0x003FE234
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78444, XrefRangeEnd = 78448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerable<int> _OnBuy_b__1_3(ValueTuple<TradableObjectBase, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_3_Internal_IEnumerable_1_Int32_ValueTuple_2_TradableObjectBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}

				// Token: 0x06011663 RID: 71267 RVA: 0x00097606 File Offset: 0x00095806
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A72 RID: 23154
				// (get) Token: 0x06011664 RID: 71268 RVA: 0x0040008C File Offset: 0x003FE28C
				// (set) Token: 0x06011665 RID: 71269 RVA: 0x0009760F File Offset: 0x0009580F
				public unsafe static DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A73 RID: 23155
				// (get) Token: 0x06011666 RID: 71270 RVA: 0x004000B4 File Offset: 0x003FE2B4
				// (set) Token: 0x06011667 RID: 71271 RVA: 0x00097621 File Offset: 0x00095821
				public unsafe static Func<ValueTuple<TradableObjectBase, int>, bool> __9__1_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<TradableObjectBase, int>, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A74 RID: 23156
				// (get) Token: 0x06011668 RID: 71272 RVA: 0x004000DC File Offset: 0x003FE2DC
				// (set) Token: 0x06011669 RID: 71273 RVA: 0x00097633 File Offset: 0x00095833
				public unsafe static Func<ValueTuple<TradableObjectBase, int>, IEnumerable<int>> __9__1_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<TradableObjectBase, int>, IEnumerable<int>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A75 RID: 23157
				// (get) Token: 0x0601166A RID: 71274 RVA: 0x00400104 File Offset: 0x003FE304
				// (set) Token: 0x0601166B RID: 71275 RVA: 0x00097645 File Offset: 0x00095845
				public unsafe static Func<ValueTuple<TradableObjectBase, int>, bool> __9__1_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9__1_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<TradableObjectBase, int>, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9__1_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A76 RID: 23158
				// (get) Token: 0x0601166C RID: 71276 RVA: 0x0040012C File Offset: 0x003FE32C
				// (set) Token: 0x0601166D RID: 71277 RVA: 0x00097657 File Offset: 0x00095857
				public unsafe static Func<ValueTuple<TradableObjectBase, int>, IEnumerable<int>> __9__1_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9__1_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<TradableObjectBase, int>, IEnumerable<int>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.IngredientAndBeverageOpenContext.__c.NativeFieldInfoPtr___9__1_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AFD1 RID: 45009
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400AFD2 RID: 45010
				private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

				// Token: 0x0400AFD3 RID: 45011
				private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

				// Token: 0x0400AFD4 RID: 45012
				private static readonly IntPtr NativeFieldInfoPtr___9__1_2;

				// Token: 0x0400AFD5 RID: 45013
				private static readonly IntPtr NativeFieldInfoPtr___9__1_3;

				// Token: 0x0400AFD6 RID: 45014
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AFD7 RID: 45015
				private static readonly IntPtr NativeMethodInfoPtr__OnBuy_b__1_0_Internal_Boolean_ValueTuple_2_TradableObjectBase_Int32_0;

				// Token: 0x0400AFD8 RID: 45016
				private static readonly IntPtr NativeMethodInfoPtr__OnBuy_b__1_1_Internal_IEnumerable_1_Int32_ValueTuple_2_TradableObjectBase_Int32_0;

				// Token: 0x0400AFD9 RID: 45017
				private static readonly IntPtr NativeMethodInfoPtr__OnBuy_b__1_2_Internal_Boolean_ValueTuple_2_TradableObjectBase_Int32_0;

				// Token: 0x0400AFDA RID: 45018
				private static readonly IntPtr NativeMethodInfoPtr__OnBuy_b__1_3_Internal_IEnumerable_1_Int32_ValueTuple_2_TradableObjectBase_Int32_0;
			}
		}

		// Token: 0x02000714 RID: 1812
		public class RecipeOpenContext : DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<Recipe, DLC5_RogueLike_RecipeDescriber>
		{
			// Token: 0x06009CA7 RID: 40103 RVA: 0x002991EC File Offset: 0x002973EC
			// Note: this type is marked as 'beforefieldinit'.
			static RecipeOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "RecipeOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext>.NativeClassPtr, 100669052);
				DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_GetCurrentBuyCount_Public_Virtual_Int32_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext>.NativeClassPtr, 100669053);
				DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_Recipe_Int32_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext>.NativeClassPtr, 100669054);
				DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_MapProduct_Protected_Virtual_Recipe_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext>.NativeClassPtr, 100669055);
				DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext>.NativeClassPtr, 100669056);
				DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext>.NativeClassPtr, 100669057);
				DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext>.NativeClassPtr, 100669058);
				DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_Recipe_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext>.NativeClassPtr, 100669059);
			}

			// Token: 0x06009CA8 RID: 40104 RVA: 0x002992B8 File Offset: 0x002974B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78529, XrefRangeEnd = 78539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RecipeOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CA9 RID: 40105 RVA: 0x00299304 File Offset: 0x00297504
			[CallerCount(0)]
			public unsafe override int GetCurrentBuyCount(RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_GetCurrentBuyCount_Public_Virtual_Int32_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CAA RID: 40106 RVA: 0x0029935C File Offset: 0x0029755C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78539, XrefRangeEnd = 78588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnBuy(IEnumerable<ValueTuple<Recipe, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boughtData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_Recipe_Int32_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CAB RID: 40107 RVA: 0x002993BC File Offset: 0x002975BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78588, XrefRangeEnd = 78589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Recipe MapProduct([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_MapProduct_Protected_Virtual_Recipe_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
			}

			// Token: 0x06009CAC RID: 40108 RVA: 0x00299418 File Offset: 0x00297618
			[CallerCount(0)]
			public unsafe override int GetProductPrice([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CAD RID: 40109 RVA: 0x00299474 File Offset: 0x00297674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78589, XrefRangeEnd = 78593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool DeductProductAmount(ref Product product, int amount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CAE RID: 40110 RVA: 0x002994DC File Offset: 0x002976DC
			[CallerCount(0)]
			public unsafe override int GetProductAmount([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CAF RID: 40111 RVA: 0x00299538 File Offset: 0x00297738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78593, XrefRangeEnd = 78623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void PreviewObject(Recipe data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.RecipeOpenContext.NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_Recipe_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CB0 RID: 40112 RVA: 0x00054952 File Offset: 0x00052B52
			public RecipeOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040065D0 RID: 26064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0;

			// Token: 0x040065D1 RID: 26065
			private static readonly IntPtr NativeMethodInfoPtr_GetCurrentBuyCount_Public_Virtual_Int32_RogueLikeRunTimeData_0;

			// Token: 0x040065D2 RID: 26066
			private static readonly IntPtr NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_Recipe_Int32_RogueLikeRunTimeData_0;

			// Token: 0x040065D3 RID: 26067
			private static readonly IntPtr NativeMethodInfoPtr_MapProduct_Protected_Virtual_Recipe_byref_Product_0;

			// Token: 0x040065D4 RID: 26068
			private static readonly IntPtr NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0;

			// Token: 0x040065D5 RID: 26069
			private static readonly IntPtr NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0;

			// Token: 0x040065D6 RID: 26070
			private static readonly IntPtr NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0;

			// Token: 0x040065D7 RID: 26071
			private static readonly IntPtr NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_Recipe_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0;

			// Token: 0x02000FCE RID: 4046
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+RecipeOpenContext+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x0601166E RID: 71278 RVA: 0x00400154 File Offset: 0x003FE354
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c>.NativeClassPtr);
					DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c>.NativeClassPtr, "<>9");
					DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c>.NativeClassPtr, "<>9__2_0");
					DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c>.NativeClassPtr, 100669061);
					DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__2_0_Internal_Int32_ValueTuple_2_Recipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c>.NativeClassPtr, 100669062);
				}

				// Token: 0x0601166F RID: 71279 RVA: 0x004001D0 File Offset: 0x003FE3D0
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011670 RID: 71280 RVA: 0x0040020C File Offset: 0x003FE40C
				[CallerCount(0)]
				public unsafe int _OnBuy_b__2_0(ValueTuple<Recipe, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__2_0_Internal_Int32_ValueTuple_2_Recipe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011671 RID: 71281 RVA: 0x00097669 File Offset: 0x00095869
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A77 RID: 23159
				// (get) Token: 0x06011672 RID: 71282 RVA: 0x00400260 File Offset: 0x003FE460
				// (set) Token: 0x06011673 RID: 71283 RVA: 0x00097672 File Offset: 0x00095872
				public unsafe static DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A78 RID: 23160
				// (get) Token: 0x06011674 RID: 71284 RVA: 0x00400288 File Offset: 0x003FE488
				// (set) Token: 0x06011675 RID: 71285 RVA: 0x00097684 File Offset: 0x00095884
				public unsafe static Func<ValueTuple<Recipe, int>, int> __9__2_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<Recipe, int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.RecipeOpenContext.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AFDB RID: 45019
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400AFDC RID: 45020
				private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

				// Token: 0x0400AFDD RID: 45021
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AFDE RID: 45022
				private static readonly IntPtr NativeMethodInfoPtr__OnBuy_b__2_0_Internal_Int32_ValueTuple_2_Recipe_Int32_0;
			}
		}

		// Token: 0x02000715 RID: 1813
		public class CookerOpenContext : DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<Cooker, ObjectLanguageBase, ObjectLanguageBaseDescriber>
		{
			// Token: 0x06009CB1 RID: 40113 RVA: 0x002995C8 File Offset: 0x002977C8
			// Note: this type is marked as 'beforefieldinit'.
			static CookerOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "CookerOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr, 100669063);
				DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_Cooker_Int32_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr, 100669064);
				DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_DescribeObject_Public_Virtual_Void_ITextProvider_1_LanguageBase_IDescriber_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr, 100669065);
				DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_CookerOnItemEnabled_Private_Static_Void_Cooker_UIElementCluster_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr, 100669066);
				DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_Cooker_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr, 100669067);
				DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_MapData_Protected_Virtual_ObjectLanguageBase_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr, 100669068);
				DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_MapProduct_Protected_Virtual_Cooker_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr, 100669069);
				DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr, 100669070);
				DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr, 100669071);
				DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr, 100669072);
			}

			// Token: 0x06009CB2 RID: 40114 RVA: 0x002996BC File Offset: 0x002978BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78623, XrefRangeEnd = 78629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CookerOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CB3 RID: 40115 RVA: 0x00299708 File Offset: 0x00297908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78629, XrefRangeEnd = 78652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnBuy(IEnumerable<ValueTuple<Cooker, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boughtData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_Cooker_Int32_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CB4 RID: 40116 RVA: 0x00299768 File Offset: 0x00297968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78652, XrefRangeEnd = 78660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void DescribeObject(ITextProvider<LanguageBase> nonTradableObjectBase, IDescriber describer, CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nonTradableObjectBase);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describer);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_DescribeObject_Public_Virtual_Void_ITextProvider_1_LanguageBase_IDescriber_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CB5 RID: 40117 RVA: 0x002997E0 File Offset: 0x002979E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 78689, RefRangeEnd = 78690, XrefRangeStart = 78660, XrefRangeEnd = 78689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void CookerOnItemEnabled(Cooker data, UIElementCluster uiElementCluster, int amount, bool check)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_CookerOnItemEnabled_Private_Static_Void_Cooker_UIElementCluster_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CB6 RID: 40118 RVA: 0x00299844 File Offset: 0x00297A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78690, XrefRangeEnd = 78691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void PreviewObject(Cooker data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_Cooker_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CB7 RID: 40119 RVA: 0x002998D4 File Offset: 0x00297AD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78691, XrefRangeEnd = 78693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override ObjectLanguageBase MapData(Cooker dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_MapData_Protected_Virtual_ObjectLanguageBase_Cooker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
			}

			// Token: 0x06009CB8 RID: 40120 RVA: 0x00299930 File Offset: 0x00297B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78693, XrefRangeEnd = 78694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Cooker MapProduct([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_MapProduct_Protected_Virtual_Cooker_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cooker>(intPtr3) : null;
			}

			// Token: 0x06009CB9 RID: 40121 RVA: 0x0029998C File Offset: 0x00297B8C
			[CallerCount(0)]
			public unsafe override int GetProductPrice([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CBA RID: 40122 RVA: 0x002999E8 File Offset: 0x00297BE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool DeductProductAmount(ref Product product, int amount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CBB RID: 40123 RVA: 0x00299A50 File Offset: 0x00297C50
			[CallerCount(0)]
			public unsafe override int GetProductAmount([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.CookerOpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CBC RID: 40124 RVA: 0x0005495B File Offset: 0x00052B5B
			public CookerOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040065D8 RID: 26072
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0;

			// Token: 0x040065D9 RID: 26073
			private static readonly IntPtr NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_Cooker_Int32_RogueLikeRunTimeData_0;

			// Token: 0x040065DA RID: 26074
			private static readonly IntPtr NativeMethodInfoPtr_DescribeObject_Public_Virtual_Void_ITextProvider_1_LanguageBase_IDescriber_CancellationToken_0;

			// Token: 0x040065DB RID: 26075
			private static readonly IntPtr NativeMethodInfoPtr_CookerOnItemEnabled_Private_Static_Void_Cooker_UIElementCluster_Int32_Boolean_0;

			// Token: 0x040065DC RID: 26076
			private static readonly IntPtr NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_Cooker_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0;

			// Token: 0x040065DD RID: 26077
			private static readonly IntPtr NativeMethodInfoPtr_MapData_Protected_Virtual_ObjectLanguageBase_Cooker_0;

			// Token: 0x040065DE RID: 26078
			private static readonly IntPtr NativeMethodInfoPtr_MapProduct_Protected_Virtual_Cooker_byref_Product_0;

			// Token: 0x040065DF RID: 26079
			private static readonly IntPtr NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0;

			// Token: 0x040065E0 RID: 26080
			private static readonly IntPtr NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0;

			// Token: 0x040065E1 RID: 26081
			private static readonly IntPtr NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0;

			// Token: 0x02000FCF RID: 4047
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+CookerOpenContext+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x06011676 RID: 71286 RVA: 0x004002B0 File Offset: 0x003FE4B0
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c>.NativeClassPtr);
					DLC5_RogueLikePurchasePanel.CookerOpenContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c>.NativeClassPtr, "<>9");
					DLC5_RogueLikePurchasePanel.CookerOpenContext.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c>.NativeClassPtr, "<>9__1_0");
					DLC5_RogueLikePurchasePanel.CookerOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c>.NativeClassPtr, 100669074);
					DLC5_RogueLikePurchasePanel.CookerOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_0_Internal_Int32_ValueTuple_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c>.NativeClassPtr, 100669075);
				}

				// Token: 0x06011677 RID: 71287 RVA: 0x0040032C File Offset: 0x003FE52C
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.CookerOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011678 RID: 71288 RVA: 0x00400368 File Offset: 0x003FE568
				[CallerCount(0)]
				public unsafe int _OnBuy_b__1_0(ValueTuple<Cooker, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.CookerOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_0_Internal_Int32_ValueTuple_2_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011679 RID: 71289 RVA: 0x00097696 File Offset: 0x00095896
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A79 RID: 23161
				// (get) Token: 0x0601167A RID: 71290 RVA: 0x004003BC File Offset: 0x003FE5BC
				// (set) Token: 0x0601167B RID: 71291 RVA: 0x0009769F File Offset: 0x0009589F
				public unsafe static DLC5_RogueLikePurchasePanel.CookerOpenContext.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.CookerOpenContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.CookerOpenContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A7A RID: 23162
				// (get) Token: 0x0601167C RID: 71292 RVA: 0x004003E4 File Offset: 0x003FE5E4
				// (set) Token: 0x0601167D RID: 71293 RVA: 0x000976B1 File Offset: 0x000958B1
				public unsafe static Func<ValueTuple<Cooker, int>, int> __9__1_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.CookerOpenContext.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<Cooker, int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.CookerOpenContext.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AFDF RID: 45023
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400AFE0 RID: 45024
				private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

				// Token: 0x0400AFE1 RID: 45025
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AFE2 RID: 45026
				private static readonly IntPtr NativeMethodInfoPtr__OnBuy_b__1_0_Internal_Int32_ValueTuple_2_Cooker_Int32_0;
			}

			// Token: 0x02000FD0 RID: 4048
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+CookerOpenContext+<>c__DisplayClass3_0")]
			public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
			{
				// Token: 0x0601167E RID: 71294 RVA: 0x0040040C File Offset: 0x003FE60C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass3_0()
				{
					Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext>.NativeClassPtr, "<>c__DisplayClass3_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0>.NativeClassPtr);
					DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0>.NativeClassPtr, "amount");
					DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0>.NativeClassPtr, 100669076);
					DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0.NativeMethodInfoPtr__CookerOnItemEnabled_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0>.NativeClassPtr, 100669077);
					DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0.NativeMethodInfoPtr__CookerOnItemEnabled_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0>.NativeClassPtr, 100669078);
				}

				// Token: 0x0601167F RID: 71295 RVA: 0x00400488 File Offset: 0x003FE688
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011680 RID: 71296 RVA: 0x004004C4 File Offset: 0x003FE6C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CookerOnItemEnabled_b__0(TextMeshProUGUI x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0.NativeMethodInfoPtr__CookerOnItemEnabled_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011681 RID: 71297 RVA: 0x00400508 File Offset: 0x003FE708
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _CookerOnItemEnabled_b__1(TextMeshProUGUI x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0.NativeMethodInfoPtr__CookerOnItemEnabled_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011682 RID: 71298 RVA: 0x000976C3 File Offset: 0x000958C3
				public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A7B RID: 23163
				// (get) Token: 0x06011683 RID: 71299 RVA: 0x0040054C File Offset: 0x003FE74C
				// (set) Token: 0x06011684 RID: 71300 RVA: 0x000976CC File Offset: 0x000958CC
				public unsafe int amount
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0.NativeFieldInfoPtr_amount);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.CookerOpenContext.__c__DisplayClass3_0.NativeFieldInfoPtr_amount)) = value;
					}
				}

				// Token: 0x0400AFE3 RID: 45027
				private static readonly IntPtr NativeFieldInfoPtr_amount;

				// Token: 0x0400AFE4 RID: 45028
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AFE5 RID: 45029
				private static readonly IntPtr NativeMethodInfoPtr__CookerOnItemEnabled_b__0_Internal_Void_TextMeshProUGUI_0;

				// Token: 0x0400AFE6 RID: 45030
				private static readonly IntPtr NativeMethodInfoPtr__CookerOnItemEnabled_b__1_Internal_Void_TextMeshProUGUI_0;
			}
		}

		// Token: 0x02000716 RID: 1814
		public class DecorationOpenContext : DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<Decoration, DecorationDescriber>
		{
			// Token: 0x06009CBD RID: 40125 RVA: 0x00299AAC File Offset: 0x00297CAC
			// Note: this type is marked as 'beforefieldinit'.
			static DecorationOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "DecorationOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext>.NativeClassPtr, 100669079);
				DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_Decoration_Int32_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext>.NativeClassPtr, 100669080);
				DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr_MapProduct_Protected_Virtual_Decoration_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext>.NativeClassPtr, 100669081);
				DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext>.NativeClassPtr, 100669082);
				DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext>.NativeClassPtr, 100669083);
				DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext>.NativeClassPtr, 100669084);
				DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_Decoration_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext>.NativeClassPtr, 100669085);
			}

			// Token: 0x06009CBE RID: 40126 RVA: 0x00299B64 File Offset: 0x00297D64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78694, XrefRangeEnd = 78700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecorationOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> decorationSelections) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSource);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decorationSelections);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_IList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CBF RID: 40127 RVA: 0x00299BC4 File Offset: 0x00297DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78700, XrefRangeEnd = 78742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnBuy(IEnumerable<ValueTuple<Decoration, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boughtData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_Decoration_Int32_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CC0 RID: 40128 RVA: 0x00299C24 File Offset: 0x00297E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78742, XrefRangeEnd = 78743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Decoration MapProduct([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr_MapProduct_Protected_Virtual_Decoration_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Decoration>(intPtr3) : null;
			}

			// Token: 0x06009CC1 RID: 40129 RVA: 0x00299C80 File Offset: 0x00297E80
			[CallerCount(0)]
			public unsafe override int GetProductPrice([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CC2 RID: 40130 RVA: 0x00299CDC File Offset: 0x00297EDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool DeductProductAmount(ref Product product, int amount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CC3 RID: 40131 RVA: 0x00299D44 File Offset: 0x00297F44
			[CallerCount(0)]
			public unsafe override int GetProductAmount([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CC4 RID: 40132 RVA: 0x00299DA0 File Offset: 0x00297FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78743, XrefRangeEnd = 78746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void PreviewObject(Decoration data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.DecorationOpenContext.NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_Decoration_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CC5 RID: 40133 RVA: 0x00054964 File Offset: 0x00052B64
			public DecorationOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040065E2 RID: 26082
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_IList_1_Int32_0;

			// Token: 0x040065E3 RID: 26083
			private static readonly IntPtr NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_Decoration_Int32_RogueLikeRunTimeData_0;

			// Token: 0x040065E4 RID: 26084
			private static readonly IntPtr NativeMethodInfoPtr_MapProduct_Protected_Virtual_Decoration_byref_Product_0;

			// Token: 0x040065E5 RID: 26085
			private static readonly IntPtr NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0;

			// Token: 0x040065E6 RID: 26086
			private static readonly IntPtr NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0;

			// Token: 0x040065E7 RID: 26087
			private static readonly IntPtr NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0;

			// Token: 0x040065E8 RID: 26088
			private static readonly IntPtr NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_Decoration_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0;

			// Token: 0x02000FD1 RID: 4049
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+DecorationOpenContext+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x06011685 RID: 71301 RVA: 0x00400574 File Offset: 0x003FE774
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c>.NativeClassPtr);
					DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c>.NativeClassPtr, "<>9");
					DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c>.NativeClassPtr, "<>9__1_0");
					DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c>.NativeClassPtr, 100669087);
					DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_0_Internal_Int32_ValueTuple_2_Decoration_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c>.NativeClassPtr, 100669088);
				}

				// Token: 0x06011686 RID: 71302 RVA: 0x004005F0 File Offset: 0x003FE7F0
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011687 RID: 71303 RVA: 0x0040062C File Offset: 0x003FE82C
				[CallerCount(0)]
				public unsafe int _OnBuy_b__1_0(ValueTuple<Decoration, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_0_Internal_Int32_ValueTuple_2_Decoration_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011688 RID: 71304 RVA: 0x000976E7 File Offset: 0x000958E7
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A7C RID: 23164
				// (get) Token: 0x06011689 RID: 71305 RVA: 0x00400680 File Offset: 0x003FE880
				// (set) Token: 0x0601168A RID: 71306 RVA: 0x000976F0 File Offset: 0x000958F0
				public unsafe static DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A7D RID: 23165
				// (get) Token: 0x0601168B RID: 71307 RVA: 0x004006A8 File Offset: 0x003FE8A8
				// (set) Token: 0x0601168C RID: 71308 RVA: 0x00097702 File Offset: 0x00095902
				public unsafe static Func<ValueTuple<Decoration, int>, int> __9__1_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<Decoration, int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.DecorationOpenContext.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AFE7 RID: 45031
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400AFE8 RID: 45032
				private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

				// Token: 0x0400AFE9 RID: 45033
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AFEA RID: 45034
				private static readonly IntPtr NativeMethodInfoPtr__OnBuy_b__1_0_Internal_Int32_ValueTuple_2_Decoration_Int32_0;
			}
		}

		// Token: 0x02000717 RID: 1815
		public class ClothesOpenContext : DLC5_RogueLikePurchasePanel.UnifiedItemTypeOpenContext<Item, ClothesDescriber>
		{
			// Token: 0x06009CC6 RID: 40134 RVA: 0x00299E30 File Offset: 0x00298030
			// Note: this type is marked as 'beforefieldinit'.
			static ClothesOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "ClothesOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_IList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext>.NativeClassPtr, 100669089);
				DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext>.NativeClassPtr, 100669090);
				DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext>.NativeClassPtr, 100669091);
				DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext>.NativeClassPtr, 100669092);
				DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr_MapProduct_Protected_Virtual_Item_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext>.NativeClassPtr, 100669093);
				DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_Item_Int32_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext>.NativeClassPtr, 100669094);
				DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_Item_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext>.NativeClassPtr, 100669095);
			}

			// Token: 0x06009CC7 RID: 40135 RVA: 0x00299EE8 File Offset: 0x002980E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78771, XrefRangeEnd = 78777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ClothesOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource, IList<int> selections) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSource);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selections);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_IList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CC8 RID: 40136 RVA: 0x00299F48 File Offset: 0x00298148
			[CallerCount(0)]
			public unsafe override int GetProductPrice([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CC9 RID: 40137 RVA: 0x00299FA4 File Offset: 0x002981A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool DeductProductAmount(ref Product product, int amount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CCA RID: 40138 RVA: 0x0029A00C File Offset: 0x0029820C
			[CallerCount(0)]
			public unsafe override int GetProductAmount([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CCB RID: 40139 RVA: 0x0029A068 File Offset: 0x00298268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78777, XrefRangeEnd = 78778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Item MapProduct([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr_MapProduct_Protected_Virtual_Item_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Item>(intPtr3) : null;
			}

			// Token: 0x06009CCC RID: 40140 RVA: 0x0029A0C4 File Offset: 0x002982C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78778, XrefRangeEnd = 78798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnBuy(IEnumerable<ValueTuple<Item, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boughtData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_Item_Int32_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CCD RID: 40141 RVA: 0x0029A124 File Offset: 0x00298324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78798, XrefRangeEnd = 78876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void PreviewObject(Item data, UIElementCluster cluster, int amount, bool check, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref check;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.ClothesOpenContext.NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_Item_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CCE RID: 40142 RVA: 0x0005496D File Offset: 0x00052B6D
			public ClothesOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040065E9 RID: 26089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_IList_1_Int32_0;

			// Token: 0x040065EA RID: 26090
			private static readonly IntPtr NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0;

			// Token: 0x040065EB RID: 26091
			private static readonly IntPtr NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0;

			// Token: 0x040065EC RID: 26092
			private static readonly IntPtr NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0;

			// Token: 0x040065ED RID: 26093
			private static readonly IntPtr NativeMethodInfoPtr_MapProduct_Protected_Virtual_Item_byref_Product_0;

			// Token: 0x040065EE RID: 26094
			private static readonly IntPtr NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_Item_Int32_RogueLikeRunTimeData_0;

			// Token: 0x040065EF RID: 26095
			private static readonly IntPtr NativeMethodInfoPtr_PreviewObject_Protected_Virtual_Void_Item_UIElementCluster_Int32_Boolean_RogueLikeRunTimeData_0;

			// Token: 0x02000FD2 RID: 4050
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+ClothesOpenContext+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x0601168D RID: 71309 RVA: 0x004006D0 File Offset: 0x003FE8D0
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c>.NativeClassPtr);
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c>.NativeClassPtr, "<>9");
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c>.NativeClassPtr, "<>9__5_0");
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeFieldInfoPtr___9__6_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c>.NativeClassPtr, "<>9__6_5");
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c>.NativeClassPtr, 100669097);
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__5_0_Internal_Int32_ValueTuple_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c>.NativeClassPtr, 100669098);
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeMethodInfoPtr__PreviewObject_b__6_5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c>.NativeClassPtr, 100669099);
				}

				// Token: 0x0601168E RID: 71310 RVA: 0x00400774 File Offset: 0x003FE974
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601168F RID: 71311 RVA: 0x004007B0 File Offset: 0x003FE9B0
				[CallerCount(0)]
				public unsafe int _OnBuy_b__5_0(ValueTuple<Item, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__5_0_Internal_Int32_ValueTuple_2_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011690 RID: 71312 RVA: 0x00400804 File Offset: 0x003FEA04
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78746, XrefRangeEnd = 78753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _PreviewObject_b__6_5(Image x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeMethodInfoPtr__PreviewObject_b__6_5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011691 RID: 71313 RVA: 0x00097714 File Offset: 0x00095914
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A7E RID: 23166
				// (get) Token: 0x06011692 RID: 71314 RVA: 0x00400848 File Offset: 0x003FEA48
				// (set) Token: 0x06011693 RID: 71315 RVA: 0x0009771D File Offset: 0x0009591D
				public unsafe static DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A7F RID: 23167
				// (get) Token: 0x06011694 RID: 71316 RVA: 0x00400870 File Offset: 0x003FEA70
				// (set) Token: 0x06011695 RID: 71317 RVA: 0x0009772F File Offset: 0x0009592F
				public unsafe static Func<ValueTuple<Item, int>, int> __9__5_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<Item, int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A80 RID: 23168
				// (get) Token: 0x06011696 RID: 71318 RVA: 0x00400898 File Offset: 0x003FEA98
				// (set) Token: 0x06011697 RID: 71319 RVA: 0x00097741 File Offset: 0x00095941
				public unsafe static Action<Image> __9__6_5
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeFieldInfoPtr___9__6_5, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c.NativeFieldInfoPtr___9__6_5, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AFEB RID: 45035
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400AFEC RID: 45036
				private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

				// Token: 0x0400AFED RID: 45037
				private static readonly IntPtr NativeFieldInfoPtr___9__6_5;

				// Token: 0x0400AFEE RID: 45038
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AFEF RID: 45039
				private static readonly IntPtr NativeMethodInfoPtr__OnBuy_b__5_0_Internal_Int32_ValueTuple_2_Item_Int32_0;

				// Token: 0x0400AFF0 RID: 45040
				private static readonly IntPtr NativeMethodInfoPtr__PreviewObject_b__6_5_Internal_Void_Image_0;
			}

			// Token: 0x02000FD3 RID: 4051
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+ClothesOpenContext+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
			{
				// Token: 0x06011698 RID: 71320 RVA: 0x004008C0 File Offset: 0x003FEAC0
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext>.NativeClassPtr, "<>c__DisplayClass6_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0>.NativeClassPtr);
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeFieldInfoPtr_runTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0>.NativeClassPtr, "runTimeData");
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeFieldInfoPtr_currentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0>.NativeClassPtr, "currentId");
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeFieldInfoPtr_skinSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0>.NativeClassPtr, "skinSprite");
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0>.NativeClassPtr, 100669100);
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeMethodInfoPtr__PreviewObject_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0>.NativeClassPtr, 100669101);
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeMethodInfoPtr__PreviewObject_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0>.NativeClassPtr, 100669102);
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeMethodInfoPtr__PreviewObject_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0>.NativeClassPtr, 100669103);
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeMethodInfoPtr__PreviewObject_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0>.NativeClassPtr, 100669104);
					DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeMethodInfoPtr__PreviewObject_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0>.NativeClassPtr, 100669105);
				}

				// Token: 0x06011699 RID: 71321 RVA: 0x004009A0 File Offset: 0x003FEBA0
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601169A RID: 71322 RVA: 0x004009DC File Offset: 0x003FEBDC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78753, XrefRangeEnd = 78759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _PreviewObject_b__0(Image x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeMethodInfoPtr__PreviewObject_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601169B RID: 71323 RVA: 0x00400A20 File Offset: 0x003FEC20
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78759, XrefRangeEnd = 78762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _PreviewObject_b__1(Image x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeMethodInfoPtr__PreviewObject_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601169C RID: 71324 RVA: 0x00400A64 File Offset: 0x003FEC64
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78762, XrefRangeEnd = 78765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _PreviewObject_b__2(Image x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeMethodInfoPtr__PreviewObject_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601169D RID: 71325 RVA: 0x00400AA8 File Offset: 0x003FECA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78765, XrefRangeEnd = 78768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _PreviewObject_b__3(Image x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeMethodInfoPtr__PreviewObject_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601169E RID: 71326 RVA: 0x00400AEC File Offset: 0x003FECEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78768, XrefRangeEnd = 78771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _PreviewObject_b__4(Image x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeMethodInfoPtr__PreviewObject_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601169F RID: 71327 RVA: 0x00097753 File Offset: 0x00095953
				public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A81 RID: 23169
				// (get) Token: 0x060116A0 RID: 71328 RVA: 0x00400B30 File Offset: 0x003FED30
				// (set) Token: 0x060116A1 RID: 71329 RVA: 0x0009775C File Offset: 0x0009595C
				public unsafe RogueLikeRunTimeData runTimeData
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeFieldInfoPtr_runTimeData);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeFieldInfoPtr_runTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A82 RID: 23170
				// (get) Token: 0x060116A2 RID: 71330 RVA: 0x00400B60 File Offset: 0x003FED60
				// (set) Token: 0x060116A3 RID: 71331 RVA: 0x0009777B File Offset: 0x0009597B
				public unsafe int currentId
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeFieldInfoPtr_currentId);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeFieldInfoPtr_currentId)) = value;
					}
				}

				// Token: 0x17005A83 RID: 23171
				// (get) Token: 0x060116A4 RID: 71332 RVA: 0x00400B88 File Offset: 0x003FED88
				// (set) Token: 0x060116A5 RID: 71333 RVA: 0x00097796 File Offset: 0x00095996
				public unsafe CharacterSpriteSetCompact skinSprite
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeFieldInfoPtr_skinSprite);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.ClothesOpenContext.__c__DisplayClass6_0.NativeFieldInfoPtr_skinSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AFF1 RID: 45041
				private static readonly IntPtr NativeFieldInfoPtr_runTimeData;

				// Token: 0x0400AFF2 RID: 45042
				private static readonly IntPtr NativeFieldInfoPtr_currentId;

				// Token: 0x0400AFF3 RID: 45043
				private static readonly IntPtr NativeFieldInfoPtr_skinSprite;

				// Token: 0x0400AFF4 RID: 45044
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AFF5 RID: 45045
				private static readonly IntPtr NativeMethodInfoPtr__PreviewObject_b__0_Internal_Void_Image_0;

				// Token: 0x0400AFF6 RID: 45046
				private static readonly IntPtr NativeMethodInfoPtr__PreviewObject_b__1_Internal_Void_Image_0;

				// Token: 0x0400AFF7 RID: 45047
				private static readonly IntPtr NativeMethodInfoPtr__PreviewObject_b__2_Internal_Void_Image_0;

				// Token: 0x0400AFF8 RID: 45048
				private static readonly IntPtr NativeMethodInfoPtr__PreviewObject_b__3_Internal_Void_Image_0;

				// Token: 0x0400AFF9 RID: 45049
				private static readonly IntPtr NativeMethodInfoPtr__PreviewObject_b__4_Internal_Void_Image_0;
			}
		}

		// Token: 0x02000718 RID: 1816
		public class InviteOpenContext : DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<DLC5_RogueLike_InviteDescriber>
		{
			// Token: 0x06009CCF RID: 40143 RVA: 0x0029A1B4 File Offset: 0x002983B4
			// Note: this type is marked as 'beforefieldinit'.
			static InviteOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.InviteOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "InviteOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.InviteOpenContext>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.InviteOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.InviteOpenContext>.NativeClassPtr, 100669106);
				DLC5_RogueLikePurchasePanel.InviteOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_SpecialGuest_Int32_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.InviteOpenContext>.NativeClassPtr, 100669107);
			}

			// Token: 0x06009CD0 RID: 40144 RVA: 0x0029A208 File Offset: 0x00298408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78876, XrefRangeEnd = 78885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InviteOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.InviteOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.InviteOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CD1 RID: 40145 RVA: 0x0029A254 File Offset: 0x00298454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78885, XrefRangeEnd = 78906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnBuy(IEnumerable<ValueTuple<SpecialGuest, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boughtData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.InviteOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_SpecialGuest_Int32_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CD2 RID: 40146 RVA: 0x00054976 File Offset: 0x00052B76
			public InviteOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040065F0 RID: 26096
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0;

			// Token: 0x040065F1 RID: 26097
			private static readonly IntPtr NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_SpecialGuest_Int32_RogueLikeRunTimeData_0;
		}

		// Token: 0x02000719 RID: 1817
		public class PartnerOpenContext : DLC5_RogueLikePurchasePanel.SpecialGuestTypeOpenContext<DLC5_RogueLike_PartnerDescriber>
		{
			// Token: 0x06009CD3 RID: 40147 RVA: 0x0029A2B4 File Offset: 0x002984B4
			// Note: this type is marked as 'beforefieldinit'.
			static PartnerOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.PartnerOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "PartnerOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.PartnerOpenContext>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.PartnerOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.PartnerOpenContext>.NativeClassPtr, 100669108);
				DLC5_RogueLikePurchasePanel.PartnerOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_SpecialGuest_Int32_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.PartnerOpenContext>.NativeClassPtr, 100669109);
			}

			// Token: 0x06009CD4 RID: 40148 RVA: 0x0029A308 File Offset: 0x00298508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78906, XrefRangeEnd = 78915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PartnerOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.PartnerOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.PartnerOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CD5 RID: 40149 RVA: 0x0029A354 File Offset: 0x00298554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78915, XrefRangeEnd = 78936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnBuy(IEnumerable<ValueTuple<SpecialGuest, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boughtData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.PartnerOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_SpecialGuest_Int32_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CD6 RID: 40150 RVA: 0x0005497F File Offset: 0x00052B7F
			public PartnerOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040065F2 RID: 26098
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0;

			// Token: 0x040065F3 RID: 26099
			private static readonly IntPtr NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_SpecialGuest_Int32_RogueLikeRunTimeData_0;
		}

		// Token: 0x0200071A RID: 1818
		public class RecycledItemOpenContext : DLC5_RogueLikePurchasePanel.ItemTypeOpenContext<RecycleItemDescriber.RecycleItem, RecycleItemDescriber.RecycleItem, RecycleItemDescriber>
		{
			// Token: 0x06009CD7 RID: 40151 RVA: 0x0029A3B4 File Offset: 0x002985B4
			// Note: this type is marked as 'beforefieldinit'.
			static RecycledItemOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "RecycledItemOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr_MapProduct_Protected_Virtual_RecycleItem_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext>.NativeClassPtr, 100669110);
				DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_RecycleItem_Int32_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext>.NativeClassPtr, 100669111);
				DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr_MapData_Protected_Virtual_RecycleItem_RecycleItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext>.NativeClassPtr, 100669112);
				DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext>.NativeClassPtr, 100669113);
				DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext>.NativeClassPtr, 100669114);
				DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext>.NativeClassPtr, 100669115);
				DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext>.NativeClassPtr, 100669116);
			}

			// Token: 0x06009CD8 RID: 40152 RVA: 0x0029A46C File Offset: 0x0029866C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79004, XrefRangeEnd = 79008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override RecycleItemDescriber.RecycleItem MapProduct([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr_MapProduct_Protected_Virtual_RecycleItem_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RecycleItemDescriber.RecycleItem>(intPtr3) : null;
			}

			// Token: 0x06009CD9 RID: 40153 RVA: 0x0029A4C8 File Offset: 0x002986C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79008, XrefRangeEnd = 79028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnBuy(IEnumerable<ValueTuple<RecycleItemDescriber.RecycleItem, int>> boughtData, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(boughtData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_RecycleItem_Int32_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CDA RID: 40154 RVA: 0x0029A528 File Offset: 0x00298728
			[CallerCount(0)]
			public unsafe override RecycleItemDescriber.RecycleItem MapData(RecycleItemDescriber.RecycleItem dataType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr_MapData_Protected_Virtual_RecycleItem_RecycleItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RecycleItemDescriber.RecycleItem>(intPtr3) : null;
			}

			// Token: 0x06009CDB RID: 40155 RVA: 0x0029A584 File Offset: 0x00298784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79028, XrefRangeEnd = 79032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetProductPrice([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CDC RID: 40156 RVA: 0x0029A5E0 File Offset: 0x002987E0
			[CallerCount(0)]
			public unsafe override bool DeductProductAmount(ref Product product, int amount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CDD RID: 40157 RVA: 0x0029A648 File Offset: 0x00298848
			[CallerCount(0)]
			public unsafe override int GetProductAmount([In] ref Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009CDE RID: 40158 RVA: 0x0029A6A4 File Offset: 0x002988A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79032, XrefRangeEnd = 79038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RecycledItemOpenContext(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource dataSource) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CDF RID: 40159 RVA: 0x00054988 File Offset: 0x00052B88
			public RecycledItemOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040065F4 RID: 26100
			private static readonly IntPtr NativeMethodInfoPtr_MapProduct_Protected_Virtual_RecycleItem_byref_Product_0;

			// Token: 0x040065F5 RID: 26101
			private static readonly IntPtr NativeMethodInfoPtr_OnBuy_Protected_Virtual_Void_IEnumerable_1_ValueTuple_2_RecycleItem_Int32_RogueLikeRunTimeData_0;

			// Token: 0x040065F6 RID: 26102
			private static readonly IntPtr NativeMethodInfoPtr_MapData_Protected_Virtual_RecycleItem_RecycleItem_0;

			// Token: 0x040065F7 RID: 26103
			private static readonly IntPtr NativeMethodInfoPtr_GetProductPrice_Public_Virtual_Int32_byref_Product_0;

			// Token: 0x040065F8 RID: 26104
			private static readonly IntPtr NativeMethodInfoPtr_DeductProductAmount_Public_Virtual_Boolean_byref_Product_Int32_0;

			// Token: 0x040065F9 RID: 26105
			private static readonly IntPtr NativeMethodInfoPtr_GetProductAmount_Public_Virtual_Int32_byref_Product_0;

			// Token: 0x040065FA RID: 26106
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0;

			// Token: 0x02000FD4 RID: 4052
			public class RecycledDataSource : Il2CppSystem.Object
			{
				// Token: 0x060116A6 RID: 71334 RVA: 0x00400BB8 File Offset: 0x003FEDB8
				// Note: this type is marked as 'beforefieldinit'.
				static RecycledDataSource()
				{
					Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext>.NativeClassPtr, "RecycledDataSource");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource>.NativeClassPtr);
					DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.NativeFieldInfoPtr_DataSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource>.NativeClassPtr, "DataSource");
					DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.NativeMethodInfoPtr_get_Fund_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource>.NativeClassPtr, 100669117);
					DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.NativeMethodInfoPtr_set_Fund_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource>.NativeClassPtr, 100669118);
					DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_Virtual_Final_New_get_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource>.NativeClassPtr, 100669119);
					DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource>.NativeClassPtr, 100669120);
					DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.NativeMethodInfoPtr_get_AllProducts_Public_Virtual_Final_New_get_IList_1_ProductReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource>.NativeClassPtr, 100669121);
				}

				// Token: 0x17005A85 RID: 23173
				// (get) Token: 0x060116A7 RID: 71335 RVA: 0x00400C5C File Offset: 0x003FEE5C
				// (set) Token: 0x060116A8 RID: 71336 RVA: 0x00400C98 File Offset: 0x003FEE98
				public unsafe virtual int Fund
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78945, XrefRangeEnd = 78949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.NativeMethodInfoPtr_get_Fund_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78949, XrefRangeEnd = 78953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.NativeMethodInfoPtr_set_Fund_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x17005A86 RID: 23174
				// (get) Token: 0x060116A9 RID: 71337 RVA: 0x00400CD8 File Offset: 0x003FEED8
				public unsafe virtual RogueLikeRunTimeData RogueLikeRunTimeData
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78953, XrefRangeEnd = 78957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_Virtual_Final_New_get_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr3) : null;
					}
				}

				// Token: 0x060116AA RID: 71338 RVA: 0x00400D18 File Offset: 0x003FEF18
				[CallerCount(109)]
				[CachedScanResults(RefRangeStart = 60056, RefRangeEnd = 60165, XrefRangeStart = 60056, XrefRangeEnd = 60165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe RecycledDataSource(DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource baseData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005A87 RID: 23175
				// (get) Token: 0x060116AB RID: 71339 RVA: 0x00400D64 File Offset: 0x003FEF64
				public unsafe virtual IList<ProductReference> AllProducts
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78957, XrefRangeEnd = 78997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.NativeMethodInfoPtr_get_AllProducts_Public_Virtual_Final_New_get_IList_1_ProductReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ProductReference>>(intPtr3) : null;
					}
				}

				// Token: 0x060116AC RID: 71340 RVA: 0x000977B5 File Offset: 0x000959B5
				public RecycledDataSource(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A84 RID: 23172
				// (get) Token: 0x060116AD RID: 71341 RVA: 0x00400DA4 File Offset: 0x003FEFA4
				// (set) Token: 0x060116AE RID: 71342 RVA: 0x000977BE File Offset: 0x000959BE
				public unsafe DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource DataSource
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.NativeFieldInfoPtr_DataSource);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchaseItemPanel.IRogueLikePurchaseDataSource>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.NativeFieldInfoPtr_DataSource), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AFFA RID: 45050
				private static readonly IntPtr NativeFieldInfoPtr_DataSource;

				// Token: 0x0400AFFB RID: 45051
				private static readonly IntPtr NativeMethodInfoPtr_get_Fund_Public_Virtual_Final_New_get_Int32_0;

				// Token: 0x0400AFFC RID: 45052
				private static readonly IntPtr NativeMethodInfoPtr_set_Fund_Public_Virtual_Final_New_set_Void_Int32_0;

				// Token: 0x0400AFFD RID: 45053
				private static readonly IntPtr NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_Virtual_Final_New_get_RogueLikeRunTimeData_0;

				// Token: 0x0400AFFE RID: 45054
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IRogueLikePurchaseDataSource_0;

				// Token: 0x0400AFFF RID: 45055
				private static readonly IntPtr NativeMethodInfoPtr_get_AllProducts_Public_Virtual_Final_New_get_IList_1_ProductReference_0;

				// Token: 0x020010DF RID: 4319
				[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+RecycledItemOpenContext+RecycledDataSource+<>c")]
				[Serializable]
				public sealed class __c : Il2CppSystem.Object
				{
					// Token: 0x06012437 RID: 74807 RVA: 0x00429818 File Offset: 0x00427A18
					// Note: this type is marked as 'beforefieldinit'.
					static __c()
					{
						Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource>.NativeClassPtr, "<>c");
						IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c>.NativeClassPtr);
						DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c>.NativeClassPtr, "<>9");
						DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c>.NativeClassPtr, "<>9__8_0");
						DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c>.NativeClassPtr, "<>9__8_1");
						DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c>.NativeClassPtr, 100669123);
						DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeMethodInfoPtr__get_AllProducts_b__8_0_Internal_Boolean_KeyValuePair_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c>.NativeClassPtr, 100669124);
						DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeMethodInfoPtr__get_AllProducts_b__8_1_Internal_ProductReference_KeyValuePair_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c>.NativeClassPtr, 100669125);
					}

					// Token: 0x06012438 RID: 74808 RVA: 0x004298BC File Offset: 0x00427ABC
					[CallerCount(2138)]
					[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c>.NativeClassPtr))
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}

					// Token: 0x06012439 RID: 74809 RVA: 0x004298F8 File Offset: 0x00427AF8
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78936, XrefRangeEnd = 78937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe bool _get_AllProducts_b__8_0(KeyValuePair<Item, int> x)
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeMethodInfoPtr__get_AllProducts_b__8_0_Internal_Boolean_KeyValuePair_2_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}

					// Token: 0x0601243A RID: 74810 RVA: 0x0042994C File Offset: 0x00427B4C
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78937, XrefRangeEnd = 78945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					public unsafe ProductReference _get_AllProducts_b__8_1(KeyValuePair<Item, int> x)
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeMethodInfoPtr__get_AllProducts_b__8_1_Internal_ProductReference_KeyValuePair_2_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductReference>(intPtr3) : null;
					}

					// Token: 0x0601243B RID: 74811 RVA: 0x0009E5B5 File Offset: 0x0009C7B5
					public __c(IntPtr pointer) : base(pointer)
					{
					}

					// Token: 0x17005F84 RID: 24452
					// (get) Token: 0x0601243C RID: 74812 RVA: 0x004299A4 File Offset: 0x00427BA4
					// (set) Token: 0x0601243D RID: 74813 RVA: 0x0009E5BE File Offset: 0x0009C7BE
					public unsafe static DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c __9
					{
						get
						{
							IntPtr intPtr;
							IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
							IntPtr intPtr2 = intPtr;
							return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c>(intPtr2) : null;
						}
						set
						{
							IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
						}
					}

					// Token: 0x17005F85 RID: 24453
					// (get) Token: 0x0601243E RID: 74814 RVA: 0x004299CC File Offset: 0x00427BCC
					// (set) Token: 0x0601243F RID: 74815 RVA: 0x0009E5D0 File Offset: 0x0009C7D0
					public unsafe static Func<KeyValuePair<Item, int>, bool> __9__8_0
					{
						get
						{
							IntPtr intPtr;
							IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
							IntPtr intPtr2 = intPtr;
							return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Item, int>, bool>>(intPtr2) : null;
						}
						set
						{
							IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
						}
					}

					// Token: 0x17005F86 RID: 24454
					// (get) Token: 0x06012440 RID: 74816 RVA: 0x004299F4 File Offset: 0x00427BF4
					// (set) Token: 0x06012441 RID: 74817 RVA: 0x0009E5E2 File Offset: 0x0009C7E2
					public unsafe static Func<KeyValuePair<Item, int>, ProductReference> __9__8_1
					{
						get
						{
							IntPtr intPtr;
							IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
							IntPtr intPtr2 = intPtr;
							return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Item, int>, ProductReference>>(intPtr2) : null;
						}
						set
						{
							IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.RecycledDataSource.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
						}
					}

					// Token: 0x0400B927 RID: 47399
					private static readonly IntPtr NativeFieldInfoPtr___9;

					// Token: 0x0400B928 RID: 47400
					private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

					// Token: 0x0400B929 RID: 47401
					private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

					// Token: 0x0400B92A RID: 47402
					private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

					// Token: 0x0400B92B RID: 47403
					private static readonly IntPtr NativeMethodInfoPtr__get_AllProducts_b__8_0_Internal_Boolean_KeyValuePair_2_Item_Int32_0;

					// Token: 0x0400B92C RID: 47404
					private static readonly IntPtr NativeMethodInfoPtr__get_AllProducts_b__8_1_Internal_ProductReference_KeyValuePair_2_Item_Int32_0;
				}
			}

			// Token: 0x02000FD5 RID: 4053
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+RecycledItemOpenContext+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x060116AF RID: 71343 RVA: 0x00400DD4 File Offset: 0x003FEFD4
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c>.NativeClassPtr);
					DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c>.NativeClassPtr, "<>9");
					DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c>.NativeClassPtr, "<>9__1_0");
					DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c>.NativeClassPtr, 100669127);
					DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_0_Internal_IEnumerable_1_Int32_ValueTuple_2_RecycleItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c>.NativeClassPtr, 100669128);
				}

				// Token: 0x060116B0 RID: 71344 RVA: 0x00400E50 File Offset: 0x003FF050
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060116B1 RID: 71345 RVA: 0x00400E8C File Offset: 0x003FF08C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78997, XrefRangeEnd = 79004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerable<int> _OnBuy_b__1_0(ValueTuple<RecycleItemDescriber.RecycleItem, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c.NativeMethodInfoPtr__OnBuy_b__1_0_Internal_IEnumerable_1_Int32_ValueTuple_2_RecycleItem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}

				// Token: 0x060116B2 RID: 71346 RVA: 0x000977DD File Offset: 0x000959DD
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A88 RID: 23176
				// (get) Token: 0x060116B3 RID: 71347 RVA: 0x00400EE4 File Offset: 0x003FF0E4
				// (set) Token: 0x060116B4 RID: 71348 RVA: 0x000977E6 File Offset: 0x000959E6
				public unsafe static DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A89 RID: 23177
				// (get) Token: 0x060116B5 RID: 71349 RVA: 0x00400F0C File Offset: 0x003FF10C
				// (set) Token: 0x060116B6 RID: 71350 RVA: 0x000977F8 File Offset: 0x000959F8
				public unsafe static Func<ValueTuple<RecycleItemDescriber.RecycleItem, int>, IEnumerable<int>> __9__1_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<RecycleItemDescriber.RecycleItem, int>, IEnumerable<int>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.RecycledItemOpenContext.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B000 RID: 45056
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B001 RID: 45057
				private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

				// Token: 0x0400B002 RID: 45058
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B003 RID: 45059
				private static readonly IntPtr NativeMethodInfoPtr__OnBuy_b__1_0_Internal_IEnumerable_1_Int32_ValueTuple_2_RecycleItem_Int32_0;
			}
		}

		// Token: 0x0200071B RID: 1819
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+<get_GetData>d__95")]
		public sealed class _get_GetData_d__95 : Il2CppSystem.Object
		{
			// Token: 0x06009CE0 RID: 40160 RVA: 0x0029A6F0 File Offset: 0x002988F0
			// Note: this type is marked as 'beforefieldinit'.
			static _get_GetData_d__95()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<get_GetData>d__95");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr, "<>l__initialThreadId");
				DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr, 100669129);
				DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr, 100669130);
				DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr, 100669131);
				DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_InspectingProductType_UIButtonToggle_UISubPanel_1_DLC5_RogueLikePurchasePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr, 100669132);
				DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr, 100669133);
				DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr, 100669134);
				DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_InspectingProductType_UIButtonToggle_UISubPanel_1_DLC5_RogueLikePurchasePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr, 100669135);
				DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr, 100669136);
			}

			// Token: 0x06009CE1 RID: 40161 RVA: 0x0029A80C File Offset: 0x00298A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_GetData_d__95(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel._get_GetData_d__95>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CE2 RID: 40162 RVA: 0x0029A854 File Offset: 0x00298A54
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CE3 RID: 40163 RVA: 0x0029A888 File Offset: 0x00298A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79038, XrefRangeEnd = 79042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170033E9 RID: 13289
			// (get) Token: 0x06009CE4 RID: 40164 RVA: 0x0029A8C4 File Offset: 0x00298AC4
			public unsafe ValueTuple<InspectingProductType, UIButtonToggle, UISubPanel<DLC5_RogueLikePurchasePanel>> prop_ValueTuple_3_InspectingProductType_UIButtonToggle_UISubPanel_1_DLC5_RogueLikePurchasePanel_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_InspectingProductType_UIButtonToggle_UISubPanel_1_DLC5_RogueLikePurchasePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ValueTuple<InspectingProductType, UIButtonToggle, UISubPanel<DLC5_RogueLikePurchasePanel>>(pointer);
				}
			}

			// Token: 0x06009CE5 RID: 40165 RVA: 0x0029A8FC File Offset: 0x00298AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79042, XrefRangeEnd = 79048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170033EA RID: 13290
			// (get) Token: 0x06009CE6 RID: 40166 RVA: 0x0029A930 File Offset: 0x00298B30
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79048, XrefRangeEnd = 79051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009CE7 RID: 40167 RVA: 0x0029A970 File Offset: 0x00298B70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79051, XrefRangeEnd = 79053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<InspectingProductType, UIButtonToggle, UISubPanel<DLC5_RogueLikePurchasePanel>>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_InspectingProductType_UIButtonToggle_UISubPanel_1_DLC5_RogueLikePurchasePanel_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_InspectingProductType_UIButtonToggle_UISubPanel_1_DLC5_RogueLikePurchasePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<InspectingProductType, UIButtonToggle, UISubPanel<DLC5_RogueLikePurchasePanel>>>>(intPtr3) : null;
			}

			// Token: 0x06009CE8 RID: 40168 RVA: 0x0029A9B0 File Offset: 0x00298BB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06009CE9 RID: 40169 RVA: 0x00054991 File Offset: 0x00052B91
			public _get_GetData_d__95(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033E5 RID: 13285
			// (get) Token: 0x06009CEA RID: 40170 RVA: 0x0029A9F0 File Offset: 0x00298BF0
			// (set) Token: 0x06009CEB RID: 40171 RVA: 0x0005499A File Offset: 0x00052B9A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170033E6 RID: 13286
			// (get) Token: 0x06009CEC RID: 40172 RVA: 0x0029AA18 File Offset: 0x00298C18
			// (set) Token: 0x06009CED RID: 40173 RVA: 0x000549B5 File Offset: 0x00052BB5
			public ValueTuple<InspectingProductType, UIButtonToggle, UISubPanel<DLC5_RogueLikePurchasePanel>> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeFieldInfoPtr___2__current);
					return new ValueTuple<InspectingProductType, UIButtonToggle, UISubPanel<DLC5_RogueLikePurchasePanel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<InspectingProductType, UIButtonToggle, UISubPanel<DLC5_RogueLikePurchasePanel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<InspectingProductType, UIButtonToggle, UISubPanel<DLC5_RogueLikePurchasePanel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170033E7 RID: 13287
			// (get) Token: 0x06009CEE RID: 40174 RVA: 0x0029AA48 File Offset: 0x00298C48
			// (set) Token: 0x06009CEF RID: 40175 RVA: 0x000549E3 File Offset: 0x00052BE3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170033E8 RID: 13288
			// (get) Token: 0x06009CF0 RID: 40176 RVA: 0x0029AA70 File Offset: 0x00298C70
			// (set) Token: 0x06009CF1 RID: 40177 RVA: 0x000549FE File Offset: 0x00052BFE
			public unsafe DLC5_RogueLikePurchasePanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel._get_GetData_d__95.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040065FB RID: 26107
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040065FC RID: 26108
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040065FD RID: 26109
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040065FE RID: 26110
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040065FF RID: 26111
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006600 RID: 26112
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006601 RID: 26113
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006602 RID: 26114
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_InspectingProductType_UIButtonToggle_UISubPanel_1_DLC5_RogueLikePurchasePanel_0;

			// Token: 0x04006603 RID: 26115
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006604 RID: 26116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006605 RID: 26117
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_InspectingProductType_UIButtonToggle_UISubPanel_1_DLC5_RogueLikePurchasePanel_0;

			// Token: 0x04006606 RID: 26118
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200071C RID: 1820
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+<>c__DisplayClass97_0`1")]
		public sealed class __c__DisplayClass97_0<T> : Il2CppSystem.Object
		{
			// Token: 0x06009CF2 RID: 40178 RVA: 0x0029AAA0 File Offset: 0x00298CA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass97_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<>c__DisplayClass97_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>.NativeFieldInfoPtr_amountMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>>.NativeClassPtr, "amountMessage");
				DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>>.NativeClassPtr, 100669137);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>.NativeMethodInfoPtr__DefaultOnItemEnabled_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>>.NativeClassPtr, 100669138);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>.NativeMethodInfoPtr__DefaultOnItemEnabled_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>>.NativeClassPtr, 100669139);
			}

			// Token: 0x06009CF3 RID: 40179 RVA: 0x0029AB58 File Offset: 0x00298D58
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass97_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CF4 RID: 40180 RVA: 0x0029AB94 File Offset: 0x00298D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DefaultOnItemEnabled_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>.NativeMethodInfoPtr__DefaultOnItemEnabled_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CF5 RID: 40181 RVA: 0x0029ABD8 File Offset: 0x00298DD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DefaultOnItemEnabled_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>.NativeMethodInfoPtr__DefaultOnItemEnabled_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CF6 RID: 40182 RVA: 0x00054A1D File Offset: 0x00052C1D
			public __c__DisplayClass97_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033EB RID: 13291
			// (get) Token: 0x06009CF7 RID: 40183 RVA: 0x0029AC1C File Offset: 0x00298E1C
			// (set) Token: 0x06009CF8 RID: 40184 RVA: 0x00054A26 File Offset: 0x00052C26
			public unsafe string amountMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>.NativeFieldInfoPtr_amountMessage);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.__c__DisplayClass97_0<T>.NativeFieldInfoPtr_amountMessage), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04006607 RID: 26119
			private static readonly IntPtr NativeFieldInfoPtr_amountMessage;

			// Token: 0x04006608 RID: 26120
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006609 RID: 26121
			private static readonly IntPtr NativeMethodInfoPtr__DefaultOnItemEnabled_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400660A RID: 26122
			private static readonly IntPtr NativeMethodInfoPtr__DefaultOnItemEnabled_b__1_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x0200071D RID: 1821
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+<>c__DisplayClass98_0`1")]
		public sealed class __c__DisplayClass98_0<T> : Il2CppSystem.Object
		{
			// Token: 0x06009CF9 RID: 40185 RVA: 0x0029AC44 File Offset: 0x00298E44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass98_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass98_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<>c__DisplayClass98_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass98_0<T>>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass98_0<T>.NativeFieldInfoPtr_owned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass98_0<T>>.NativeClassPtr, "owned");
				DLC5_RogueLikePurchasePanel.__c__DisplayClass98_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass98_0<T>>.NativeClassPtr, 100669140);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass98_0<T>.NativeMethodInfoPtr__DecorationOnItemEnabled_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass98_0<T>>.NativeClassPtr, 100669141);
			}

			// Token: 0x06009CFA RID: 40186 RVA: 0x0029ACE8 File Offset: 0x00298EE8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass98_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass98_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass98_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CFB RID: 40187 RVA: 0x0029AD24 File Offset: 0x00298F24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DecorationOnItemEnabled_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass98_0<T>.NativeMethodInfoPtr__DecorationOnItemEnabled_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009CFC RID: 40188 RVA: 0x00054A45 File Offset: 0x00052C45
			public __c__DisplayClass98_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033EC RID: 13292
			// (get) Token: 0x06009CFD RID: 40189 RVA: 0x0029AD68 File Offset: 0x00298F68
			// (set) Token: 0x06009CFE RID: 40190 RVA: 0x00054A4E File Offset: 0x00052C4E
			public unsafe bool owned
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.__c__DisplayClass98_0<T>.NativeFieldInfoPtr_owned);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.__c__DisplayClass98_0<T>.NativeFieldInfoPtr_owned)) = value;
				}
			}

			// Token: 0x0400660B RID: 26123
			private static readonly IntPtr NativeFieldInfoPtr_owned;

			// Token: 0x0400660C RID: 26124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400660D RID: 26125
			private static readonly IntPtr NativeMethodInfoPtr__DecorationOnItemEnabled_b__0_Internal_Void_Image_0;
		}

		// Token: 0x0200071E RID: 1822
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+<>c__DisplayClass99_0")]
		public sealed class __c__DisplayClass99_0 : Il2CppSystem.Object
		{
			// Token: 0x06009CFF RID: 40191 RVA: 0x0029AD90 File Offset: 0x00298F90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass99_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<>c__DisplayClass99_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0.NativeFieldInfoPtr_amountMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0>.NativeClassPtr, "amountMessage");
				DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0>.NativeClassPtr, 100669142);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0.NativeMethodInfoPtr__RecipeOnItemEnabled_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0>.NativeClassPtr, 100669143);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0.NativeMethodInfoPtr__RecipeOnItemEnabled_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0>.NativeClassPtr, 100669144);
			}

			// Token: 0x06009D00 RID: 40192 RVA: 0x0029AE0C File Offset: 0x0029900C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass99_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D01 RID: 40193 RVA: 0x0029AE48 File Offset: 0x00299048
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RecipeOnItemEnabled_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0.NativeMethodInfoPtr__RecipeOnItemEnabled_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D02 RID: 40194 RVA: 0x0029AE8C File Offset: 0x0029908C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RecipeOnItemEnabled_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0.NativeMethodInfoPtr__RecipeOnItemEnabled_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D03 RID: 40195 RVA: 0x00054A69 File Offset: 0x00052C69
			public __c__DisplayClass99_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033ED RID: 13293
			// (get) Token: 0x06009D04 RID: 40196 RVA: 0x0029AED0 File Offset: 0x002990D0
			// (set) Token: 0x06009D05 RID: 40197 RVA: 0x00054A72 File Offset: 0x00052C72
			public unsafe string amountMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0.NativeFieldInfoPtr_amountMessage);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.__c__DisplayClass99_0.NativeFieldInfoPtr_amountMessage), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400660E RID: 26126
			private static readonly IntPtr NativeFieldInfoPtr_amountMessage;

			// Token: 0x0400660F RID: 26127
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006610 RID: 26128
			private static readonly IntPtr NativeMethodInfoPtr__RecipeOnItemEnabled_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006611 RID: 26129
			private static readonly IntPtr NativeMethodInfoPtr__RecipeOnItemEnabled_b__1_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x0200071F RID: 1823
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+<>c__DisplayClass100_0")]
		public sealed class __c__DisplayClass100_0 : Il2CppSystem.Object
		{
			// Token: 0x06009D06 RID: 40198 RVA: 0x0029AEF8 File Offset: 0x002990F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass100_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<>c__DisplayClass100_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeFieldInfoPtr_guestData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0>.NativeClassPtr, "guestData");
				DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeFieldInfoPtr_colorScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0>.NativeClassPtr, "colorScheme");
				DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeFieldInfoPtr_pixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0>.NativeClassPtr, "pixel");
				DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0>.NativeClassPtr, 100669145);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0>.NativeClassPtr, 100669146);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0>.NativeClassPtr, 100669147);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0>.NativeClassPtr, 100669148);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0>.NativeClassPtr, 100669149);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0>.NativeClassPtr, 100669150);
				DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__9_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0>.NativeClassPtr, 100669151);
			}

			// Token: 0x06009D07 RID: 40199 RVA: 0x0029AFEC File Offset: 0x002991EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass100_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D08 RID: 40200 RVA: 0x0029B028 File Offset: 0x00299228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79053, XrefRangeEnd = 79055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DefaultOnSpecialGuestEnabled_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D09 RID: 40201 RVA: 0x0029B06C File Offset: 0x0029926C
			[CallerCount(0)]
			public unsafe void _DefaultOnSpecialGuestEnabled_b__5(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D0A RID: 40202 RVA: 0x0029B0B0 File Offset: 0x002992B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79055, XrefRangeEnd = 79060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DefaultOnSpecialGuestEnabled_b__6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D0B RID: 40203 RVA: 0x0029B0F4 File Offset: 0x002992F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79060, XrefRangeEnd = 79065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DefaultOnSpecialGuestEnabled_b__7(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D0C RID: 40204 RVA: 0x0029B138 File Offset: 0x00299338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79065, XrefRangeEnd = 79068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DefaultOnSpecialGuestEnabled_b__8(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D0D RID: 40205 RVA: 0x0029B17C File Offset: 0x0029937C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79068, XrefRangeEnd = 79071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DefaultOnSpecialGuestEnabled_b__9(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__9_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D0E RID: 40206 RVA: 0x00054A91 File Offset: 0x00052C91
			public __c__DisplayClass100_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033EE RID: 13294
			// (get) Token: 0x06009D0F RID: 40207 RVA: 0x0029B1C0 File Offset: 0x002993C0
			// (set) Token: 0x06009D10 RID: 40208 RVA: 0x00054A9A File Offset: 0x00052C9A
			public unsafe SpecialGuest guestData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeFieldInfoPtr_guestData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeFieldInfoPtr_guestData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033EF RID: 13295
			// (get) Token: 0x06009D11 RID: 40209 RVA: 0x0029B1F0 File Offset: 0x002993F0
			// (set) Token: 0x06009D12 RID: 40210 RVA: 0x00054AB9 File Offset: 0x00052CB9
			public unsafe Il2CppStructArray<Color> colorScheme
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeFieldInfoPtr_colorScheme);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeFieldInfoPtr_colorScheme), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033F0 RID: 13296
			// (get) Token: 0x06009D13 RID: 40211 RVA: 0x0029B220 File Offset: 0x00299420
			// (set) Token: 0x06009D14 RID: 40212 RVA: 0x00054AD8 File Offset: 0x00052CD8
			public unsafe CharacterSpriteSetCompact pixel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeFieldInfoPtr_pixel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePurchasePanel.__c__DisplayClass100_0.NativeFieldInfoPtr_pixel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006612 RID: 26130
			private static readonly IntPtr NativeFieldInfoPtr_guestData;

			// Token: 0x04006613 RID: 26131
			private static readonly IntPtr NativeFieldInfoPtr_colorScheme;

			// Token: 0x04006614 RID: 26132
			private static readonly IntPtr NativeFieldInfoPtr_pixel;

			// Token: 0x04006615 RID: 26133
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006616 RID: 26134
			private static readonly IntPtr NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006617 RID: 26135
			private static readonly IntPtr NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__5_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006618 RID: 26136
			private static readonly IntPtr NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__6_Internal_Void_Image_0;

			// Token: 0x04006619 RID: 26137
			private static readonly IntPtr NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__7_Internal_Void_Image_0;

			// Token: 0x0400661A RID: 26138
			private static readonly IntPtr NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__8_Internal_Void_Image_0;

			// Token: 0x0400661B RID: 26139
			private static readonly IntPtr NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__9_Internal_Void_Image_0;
		}

		// Token: 0x02000720 RID: 1824
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePurchasePanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009D15 RID: 40213 RVA: 0x0029B250 File Offset: 0x00299450
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr);
				DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__100_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, "<>9__100_0");
				DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__100_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, "<>9__100_1");
				DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__100_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, "<>9__100_2");
				DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__100_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, "<>9__100_3");
				DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__101_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, "<>9__101_0");
				DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__127_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, "<>9__127_0");
				DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__127_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, "<>9__127_1");
				DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__129_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, "<>9__129_0");
				DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__129_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, "<>9__129_1");
				DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, 100669153);
				DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__100_0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, 100669154);
				DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__100_1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, 100669155);
				DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__100_2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, 100669156);
				DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__100_3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, 100669157);
				DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__OnPanelPreOpen_b__101_0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, 100669158);
				DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__get_GetSelections_b__127_0_Internal_Boolean_KeyValuePair_2_CardType_RogueLikeCardPersistent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, 100669159);
				DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__get_GetSelections_b__127_1_Internal_CardType_KeyValuePair_2_CardType_RogueLikeCardPersistent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, 100669160);
				DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__get_GetEliteChallengeTypeSelections_b__129_0_Internal_EliteChallengeType_KeyValuePair_2_EliteChallengeType_EliteChallengeBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, 100669161);
				DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__get_GetEliteChallengeTypeSelections_b__129_1_Internal_String_KeyValuePair_2_EliteChallengeType_EliteChallengeBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr, 100669162);
			}

			// Token: 0x06009D16 RID: 40214 RVA: 0x0029B40C File Offset: 0x0029960C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D17 RID: 40215 RVA: 0x0029B448 File Offset: 0x00299648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DefaultOnSpecialGuestEnabled_b__100_0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__100_0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D18 RID: 40216 RVA: 0x0029B48C File Offset: 0x0029968C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DefaultOnSpecialGuestEnabled_b__100_1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__100_1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D19 RID: 40217 RVA: 0x0029B4D0 File Offset: 0x002996D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DefaultOnSpecialGuestEnabled_b__100_2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__100_2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D1A RID: 40218 RVA: 0x0029B514 File Offset: 0x00299714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DefaultOnSpecialGuestEnabled_b__100_3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__100_3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009D1B RID: 40219 RVA: 0x0029B558 File Offset: 0x00299758
			[CallerCount(0)]
			public unsafe int _OnPanelPreOpen_b__101_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__OnPanelPreOpen_b__101_0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009D1C RID: 40220 RVA: 0x0029B5A4 File Offset: 0x002997A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79071, XrefRangeEnd = 79072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_GetSelections_b__127_0(KeyValuePair<RogueLikeCardBase.CardType, RogueLikeCardPersistent> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__get_GetSelections_b__127_0_Internal_Boolean_KeyValuePair_2_CardType_RogueLikeCardPersistent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009D1D RID: 40221 RVA: 0x0029B5F8 File Offset: 0x002997F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79072, XrefRangeEnd = 79073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RogueLikeCardBase.CardType _get_GetSelections_b__127_1(KeyValuePair<RogueLikeCardBase.CardType, RogueLikeCardPersistent> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__get_GetSelections_b__127_1_Internal_CardType_KeyValuePair_2_CardType_RogueLikeCardPersistent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009D1E RID: 40222 RVA: 0x0029B64C File Offset: 0x0029984C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79073, XrefRangeEnd = 79074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RogueLikeRunTimeData.EliteChallengeType _get_GetEliteChallengeTypeSelections_b__129_0(KeyValuePair<RogueLikeRunTimeData.EliteChallengeType, RogueLikeRunTimeData.EliteChallengeBase> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__get_GetEliteChallengeTypeSelections_b__129_0_Internal_EliteChallengeType_KeyValuePair_2_EliteChallengeType_EliteChallengeBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009D1F RID: 40223 RVA: 0x0029B6A0 File Offset: 0x002998A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79074, XrefRangeEnd = 79078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _get_GetEliteChallengeTypeSelections_b__129_1(KeyValuePair<RogueLikeRunTimeData.EliteChallengeType, RogueLikeRunTimeData.EliteChallengeBase> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePurchasePanel.__c.NativeMethodInfoPtr__get_GetEliteChallengeTypeSelections_b__129_1_Internal_String_KeyValuePair_2_EliteChallengeType_EliteChallengeBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009D20 RID: 40224 RVA: 0x00054AF7 File Offset: 0x00052CF7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033F1 RID: 13297
			// (get) Token: 0x06009D21 RID: 40225 RVA: 0x0029B6F0 File Offset: 0x002998F0
			// (set) Token: 0x06009D22 RID: 40226 RVA: 0x00054B00 File Offset: 0x00052D00
			public unsafe static DLC5_RogueLikePurchasePanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033F2 RID: 13298
			// (get) Token: 0x06009D23 RID: 40227 RVA: 0x0029B718 File Offset: 0x00299918
			// (set) Token: 0x06009D24 RID: 40228 RVA: 0x00054B12 File Offset: 0x00052D12
			public unsafe static Action<Image> __9__100_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__100_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__100_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033F3 RID: 13299
			// (get) Token: 0x06009D25 RID: 40229 RVA: 0x0029B740 File Offset: 0x00299940
			// (set) Token: 0x06009D26 RID: 40230 RVA: 0x00054B24 File Offset: 0x00052D24
			public unsafe static Action<Image> __9__100_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__100_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__100_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033F4 RID: 13300
			// (get) Token: 0x06009D27 RID: 40231 RVA: 0x0029B768 File Offset: 0x00299968
			// (set) Token: 0x06009D28 RID: 40232 RVA: 0x00054B36 File Offset: 0x00052D36
			public unsafe static Action<Image> __9__100_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__100_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__100_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033F5 RID: 13301
			// (get) Token: 0x06009D29 RID: 40233 RVA: 0x0029B790 File Offset: 0x00299990
			// (set) Token: 0x06009D2A RID: 40234 RVA: 0x00054B48 File Offset: 0x00052D48
			public unsafe static Action<Image> __9__100_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__100_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__100_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033F6 RID: 13302
			// (get) Token: 0x06009D2B RID: 40235 RVA: 0x0029B7B8 File Offset: 0x002999B8
			// (set) Token: 0x06009D2C RID: 40236 RVA: 0x00054B5A File Offset: 0x00052D5A
			public unsafe static Func<int, int> __9__101_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__101_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__101_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033F7 RID: 13303
			// (get) Token: 0x06009D2D RID: 40237 RVA: 0x0029B7E0 File Offset: 0x002999E0
			// (set) Token: 0x06009D2E RID: 40238 RVA: 0x00054B6C File Offset: 0x00052D6C
			public unsafe static Func<KeyValuePair<RogueLikeCardBase.CardType, RogueLikeCardPersistent>, bool> __9__127_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__127_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<RogueLikeCardBase.CardType, RogueLikeCardPersistent>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__127_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033F8 RID: 13304
			// (get) Token: 0x06009D2F RID: 40239 RVA: 0x0029B808 File Offset: 0x00299A08
			// (set) Token: 0x06009D30 RID: 40240 RVA: 0x00054B7E File Offset: 0x00052D7E
			public unsafe static Func<KeyValuePair<RogueLikeCardBase.CardType, RogueLikeCardPersistent>, RogueLikeCardBase.CardType> __9__127_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__127_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<RogueLikeCardBase.CardType, RogueLikeCardPersistent>, RogueLikeCardBase.CardType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__127_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033F9 RID: 13305
			// (get) Token: 0x06009D31 RID: 40241 RVA: 0x0029B830 File Offset: 0x00299A30
			// (set) Token: 0x06009D32 RID: 40242 RVA: 0x00054B90 File Offset: 0x00052D90
			public unsafe static Func<KeyValuePair<RogueLikeRunTimeData.EliteChallengeType, RogueLikeRunTimeData.EliteChallengeBase>, RogueLikeRunTimeData.EliteChallengeType> __9__129_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__129_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<RogueLikeRunTimeData.EliteChallengeType, RogueLikeRunTimeData.EliteChallengeBase>, RogueLikeRunTimeData.EliteChallengeType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__129_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033FA RID: 13306
			// (get) Token: 0x06009D33 RID: 40243 RVA: 0x0029B858 File Offset: 0x00299A58
			// (set) Token: 0x06009D34 RID: 40244 RVA: 0x00054BA2 File Offset: 0x00052DA2
			public unsafe static Func<KeyValuePair<RogueLikeRunTimeData.EliteChallengeType, RogueLikeRunTimeData.EliteChallengeBase>, string> __9__129_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__129_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<RogueLikeRunTimeData.EliteChallengeType, RogueLikeRunTimeData.EliteChallengeBase>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePurchasePanel.__c.NativeFieldInfoPtr___9__129_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400661C RID: 26140
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400661D RID: 26141
			private static readonly IntPtr NativeFieldInfoPtr___9__100_0;

			// Token: 0x0400661E RID: 26142
			private static readonly IntPtr NativeFieldInfoPtr___9__100_1;

			// Token: 0x0400661F RID: 26143
			private static readonly IntPtr NativeFieldInfoPtr___9__100_2;

			// Token: 0x04006620 RID: 26144
			private static readonly IntPtr NativeFieldInfoPtr___9__100_3;

			// Token: 0x04006621 RID: 26145
			private static readonly IntPtr NativeFieldInfoPtr___9__101_0;

			// Token: 0x04006622 RID: 26146
			private static readonly IntPtr NativeFieldInfoPtr___9__127_0;

			// Token: 0x04006623 RID: 26147
			private static readonly IntPtr NativeFieldInfoPtr___9__127_1;

			// Token: 0x04006624 RID: 26148
			private static readonly IntPtr NativeFieldInfoPtr___9__129_0;

			// Token: 0x04006625 RID: 26149
			private static readonly IntPtr NativeFieldInfoPtr___9__129_1;

			// Token: 0x04006626 RID: 26150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006627 RID: 26151
			private static readonly IntPtr NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__100_0_Internal_Void_Image_0;

			// Token: 0x04006628 RID: 26152
			private static readonly IntPtr NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__100_1_Internal_Void_Image_0;

			// Token: 0x04006629 RID: 26153
			private static readonly IntPtr NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__100_2_Internal_Void_Image_0;

			// Token: 0x0400662A RID: 26154
			private static readonly IntPtr NativeMethodInfoPtr__DefaultOnSpecialGuestEnabled_b__100_3_Internal_Void_Image_0;

			// Token: 0x0400662B RID: 26155
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelPreOpen_b__101_0_Internal_Int32_Int32_0;

			// Token: 0x0400662C RID: 26156
			private static readonly IntPtr NativeMethodInfoPtr__get_GetSelections_b__127_0_Internal_Boolean_KeyValuePair_2_CardType_RogueLikeCardPersistent_0;

			// Token: 0x0400662D RID: 26157
			private static readonly IntPtr NativeMethodInfoPtr__get_GetSelections_b__127_1_Internal_CardType_KeyValuePair_2_CardType_RogueLikeCardPersistent_0;

			// Token: 0x0400662E RID: 26158
			private static readonly IntPtr NativeMethodInfoPtr__get_GetEliteChallengeTypeSelections_b__129_0_Internal_EliteChallengeType_KeyValuePair_2_EliteChallengeType_EliteChallengeBase_0;

			// Token: 0x0400662F RID: 26159
			private static readonly IntPtr NativeMethodInfoPtr__get_GetEliteChallengeTypeSelections_b__129_1_Internal_String_KeyValuePair_2_EliteChallengeType_EliteChallengeBase_0;
		}

		// Token: 0x02000721 RID: 1825
		private sealed class MethodInfoStoreGeneric_DefaultOnItemEnabled_Private_Static_Void_T_UIElementCluster_Int32_Boolean_0<T>
		{
			// Token: 0x04006630 RID: 26160
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_DefaultOnItemEnabled_Private_Static_Void_T_UIElementCluster_Int32_Boolean_0, Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000722 RID: 1826
		private sealed class MethodInfoStoreGeneric_DecorationOnItemEnabled_Private_Static_Void_T_UIElementCluster_Boolean_Boolean_0<T>
		{
			// Token: 0x04006631 RID: 26161
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DLC5_RogueLikePurchasePanel.NativeMethodInfoPtr_DecorationOnItemEnabled_Private_Static_Void_T_UIElementCluster_Boolean_Boolean_0, Il2CppClassPointerStore<DLC5_RogueLikePurchasePanel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
