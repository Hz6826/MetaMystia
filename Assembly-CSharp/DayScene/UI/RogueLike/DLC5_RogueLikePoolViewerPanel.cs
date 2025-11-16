using System;
using Common.UI;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.UGUIExtensions;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000118 RID: 280
	public class DLC5_RogueLikePoolViewerPanel : UIPanelParamOpen<ValueTuple<RogueLikeRunTimeData, DLC5_RogueLikePoolViewerPanel.PoolViewerType>>
	{
		// Token: 0x06001EFB RID: 7931 RVA: 0x00105B44 File Offset: 0x00103D44
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikePoolViewerPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikePoolViewerPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr);
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ObjectStackParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_ObjectStackParent");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ViewerGridContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_ViewerGridContent");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeViewerGridContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BadgeViewerGridContent");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardViewerGridContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardViewerGridContent");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_Describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_Describer");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_ActionExecutionScheduler");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_GetProductScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_GetProductScroller");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BadgeScroller");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardScroller");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CollectRateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CollectRateText");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DisplayCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_DisplayCount");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_StartLoopCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_StartLoopCount");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ProductGridCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_ProductGridCanvas");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardGridCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardGridCanvas");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BadgeCanvas");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CollectRateCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CollectRateCanvas");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_RecipeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_RecipeButton");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BevButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BevButton");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardButton");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_AchievementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_AchievementButton");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_RefreshWaveText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_RefreshWaveText");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentEliteCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CurrentEliteCanvas");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentEliteDesRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CurrentEliteDesRect");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentEliteTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CurrentEliteTitle");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentEliteDes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CurrentEliteDes");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardElement");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BuffElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BuffElement");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BuffElementRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BuffElementRectTransform");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardPropertyCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardPropertyCanvasGroup");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardPropertyForeverCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardPropertyForeverCanvasGroup");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardPropertyRemainingCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardPropertyRemainingCanvasGroup");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DangerousBGForForever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_DangerousBGForForever");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DangerousBGForRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_DangerousBGForRemaining");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DangerousTip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_DangerousTip");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardTitleTextForForever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardTitleTextForForever");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardTitleTextForRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardTitleTextForRemaining");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDescriptionUpTextForForever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardDescriptionUpTextForForever");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDescriptionUpTextForRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardDescriptionUpTextForRemaining");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDescriptionDownText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardDescriptionDownText");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDescriptionExtraText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardDescriptionExtraText");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardNumText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardNumText");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_RemainingCardTitleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_RemainingCardTitleColor");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ForeverCardTitleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_ForeverCardTitleColor");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DangerousCardTitleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_DangerousCardTitleColor");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardSelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardSelectedColor");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDeSelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardDeSelectedColor");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_SelectedCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_SelectedCanvasGroup");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardTypeOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardTypeOrder");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BadgeElement");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BadgeImage");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeDescriberCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BadgeDescriberCanvasGroup");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BadgeNameText");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BadgeDescriptionText");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeCollectRateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BadgeCollectRateText");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_shadowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "shadowColor");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_GetProductsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_GetProductsList");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_GetBadgeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_GetBadgeList");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentPoolViewerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CurrentPoolViewerType");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_AllToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_AllToggles");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_REFRESH_WAVE_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "REFRESH_WAVE_TITLE");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_REFRESH_WAVE_INITIAL_TITLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "REFRESH_WAVE_INITIAL_TITLE");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_RecipeComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_RecipeComparer");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BevComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BevComparer");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_GetProductsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_GetProductsGroup");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardLogicalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CardLogicalGroup");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_AchievementGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_AchievementGroup");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DescriberCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_DescriberCanvas");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentCardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_CurrentCardType");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BanOtherPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BanOtherPanel");
			DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BuffInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "m_BuffInstances");
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_get_RunTimeData_Private_get_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668756);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668757);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_2_RogueLikeRunTimeData_PoolViewerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668758);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_UpdateCardElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668759);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_UpdateCurrentViewer_Private_Void_PoolViewerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668760);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_UpdateEliteChallengeBorder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668761);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_InitCard_Private_Void_RogueLikeCardInstancePair_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668762);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_OnCardBtnSelected_Private_Void_RogueLikeCardInstancePair_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668763);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_DescribeCardAlbum_Private_Void_RogueLikeCardInstancePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668764);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_Fade_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668765);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_Blink_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668766);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668767);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668768);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668769);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668770);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668771);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668772);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668773);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_6_Private_Void_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668774);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_7_Private_Void_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668775);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_8_Private_Void_RogueLikeAchievementType_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668776);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_9_Private_Void_RogueLikeAchievementType_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668777);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_ValueTuple_2_String_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668778);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__UpdateCurrentViewer_b__77_1_Private_Boolean_RogueLikeCardInstancePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668779);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__Fade_b__83_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668780);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__Blink_b__84_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668781);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__Blink_b__84_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668782);
			DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__Blink_b__84_2_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, 100668783);
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x0010631C File Offset: 0x0010451C
		public unsafe RogueLikeRunTimeData RunTimeData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 76475, RefRangeEnd = 76478, XrefRangeStart = 76474, XrefRangeEnd = 76475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_get_RunTimeData_Private_get_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr3) : null;
			}
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x0010635C File Offset: 0x0010455C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76478, XrefRangeEnd = 76628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00106398 File Offset: 0x00104598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76628, XrefRangeEnd = 76754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(ValueTuple<RogueLikeRunTimeData, DLC5_RogueLikePoolViewerPanel.PoolViewerType> openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_2_RogueLikeRunTimeData_PoolViewerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x001063EC File Offset: 0x001045EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76936, RefRangeEnd = 76937, XrefRangeStart = 76754, XrefRangeEnd = 76936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCardElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_UpdateCardElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00106420 File Offset: 0x00104620
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 77013, RefRangeEnd = 77019, XrefRangeStart = 76937, XrefRangeEnd = 77013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentViewer(DLC5_RogueLikePoolViewerPanel.PoolViewerType targetViewer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetViewer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_UpdateCurrentViewer_Private_Void_PoolViewerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00106460 File Offset: 0x00104660
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77034, RefRangeEnd = 77035, XrefRangeStart = 77019, XrefRangeEnd = 77034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEliteChallengeBorder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_UpdateEliteChallengeBorder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00106494 File Offset: 0x00104694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77035, XrefRangeEnd = 77138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitCard(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair card, UIElementCluster cluster, UIButtonSimple uIButton)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uIButton);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_InitCard_Private_Void_RogueLikeCardInstancePair_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x001064FC File Offset: 0x001046FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77138, XrefRangeEnd = 77193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCardBtnSelected(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair card, UIElementCluster cluster, UIButtonSimple uIButton)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uIButton);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_OnCardBtnSelected_Private_Void_RogueLikeCardInstancePair_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00106564 File Offset: 0x00104764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77254, RefRangeEnd = 77255, XrefRangeStart = 77193, XrefRangeEnd = 77254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DescribeCardAlbum(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair cardPair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardPair);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_DescribeCardAlbum_Private_Void_RogueLikeCardInstancePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x001065A8 File Offset: 0x001047A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77255, XrefRangeEnd = 77262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_Fade_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x001065DC File Offset: 0x001047DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77262, XrefRangeEnd = 77275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_Blink_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00106610 File Offset: 0x00104810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77275, XrefRangeEnd = 77337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x0010664C File Offset: 0x0010484C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77337, XrefRangeEnd = 77369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikePoolViewerPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x00106688 File Offset: 0x00104888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77369, XrefRangeEnd = 77376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__74_0(InputAction.CallbackContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x001066D0 File Offset: 0x001048D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77376, XrefRangeEnd = 77377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__74_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00106704 File Offset: 0x00104904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77377, XrefRangeEnd = 77378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__74_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x00106738 File Offset: 0x00104938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77378, XrefRangeEnd = 77379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__74_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x0010676C File Offset: 0x0010496C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77379, XrefRangeEnd = 77380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__74_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x001067A0 File Offset: 0x001049A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77380, XrefRangeEnd = 77464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__74_6(int productId, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref productId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_6_Private_Void_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00106804 File Offset: 0x00104A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77464, XrefRangeEnd = 77484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__74_7(int productId, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref productId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_7_Private_Void_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x00106868 File Offset: 0x00104A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77484, XrefRangeEnd = 77525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__74_8(DLC5_RogueLikeDataProfile.RogueLikeAchievementType achievementType, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref achievementType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_8_Private_Void_RogueLikeAchievementType_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x001068CC File Offset: 0x00104ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77525, XrefRangeEnd = 77540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__74_9(DLC5_RogueLikeDataProfile.RogueLikeAchievementType achievementType, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref achievementType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__OnPanelInitialize_b__74_9_Private_Void_RogueLikeAchievementType_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00106930 File Offset: 0x00104B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77540, XrefRangeEnd = 77579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_UIElementCluster_ValueTuple_2_String_String_PDM_0(UIElementCluster cluster, ValueTuple<string, string> buffDescription)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffDescription));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_ValueTuple_2_String_String_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00106980 File Offset: 0x00104B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77579, XrefRangeEnd = 77580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdateCurrentViewer_b__77_1(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__UpdateCurrentViewer_b__77_1_Private_Boolean_RogueLikeCardInstancePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x001069D0 File Offset: 0x00104BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77580, XrefRangeEnd = 77582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Fade_b__83_0(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__Fade_b__83_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00106A10 File Offset: 0x00104C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Blink_b__84_0(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__Blink_b__84_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00106A50 File Offset: 0x00104C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77582, XrefRangeEnd = 77589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Blink_b__84_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__Blink_b__84_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00106A84 File Offset: 0x00104C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Blink_b__84_2(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.NativeMethodInfoPtr__Blink_b__84_2_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00012C32 File Offset: 0x00010E32
		public DLC5_RogueLikePoolViewerPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001F19 RID: 7961 RVA: 0x00106AC4 File Offset: 0x00104CC4
		// (set) Token: 0x06001F1A RID: 7962 RVA: 0x00012C3B File Offset: 0x00010E3B
		public unsafe GameObject m_ObjectStackParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ObjectStackParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ObjectStackParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x00106AF4 File Offset: 0x00104CF4
		// (set) Token: 0x06001F1C RID: 7964 RVA: 0x00012C5A File Offset: 0x00010E5A
		public unsafe GridLayoutGroup m_ViewerGridContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ViewerGridContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ViewerGridContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x00106B24 File Offset: 0x00104D24
		// (set) Token: 0x06001F1E RID: 7966 RVA: 0x00012C79 File Offset: 0x00010E79
		public unsafe GridLayoutGroup m_BadgeViewerGridContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeViewerGridContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeViewerGridContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001F1F RID: 7967 RVA: 0x00106B54 File Offset: 0x00104D54
		// (set) Token: 0x06001F20 RID: 7968 RVA: 0x00012C98 File Offset: 0x00010E98
		public unsafe AdpVerticalLayoutGroup m_CardViewerGridContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardViewerGridContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpVerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardViewerGridContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x00106B84 File Offset: 0x00104D84
		// (set) Token: 0x06001F22 RID: 7970 RVA: 0x00012CB7 File Offset: 0x00010EB7
		public unsafe SellableDescriber m_Describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_Describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_Describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001F23 RID: 7971 RVA: 0x00106BB4 File Offset: 0x00104DB4
		// (set) Token: 0x06001F24 RID: 7972 RVA: 0x00012CD6 File Offset: 0x00010ED6
		public unsafe ActionExecutionScheduler m_ActionExecutionScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ActionExecutionScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x00106BE4 File Offset: 0x00104DE4
		// (set) Token: 0x06001F26 RID: 7974 RVA: 0x00012CF5 File Offset: 0x00010EF5
		public unsafe AdpProgressIndicatorComponent m_GetProductScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_GetProductScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_GetProductScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x00106C14 File Offset: 0x00104E14
		// (set) Token: 0x06001F28 RID: 7976 RVA: 0x00012D14 File Offset: 0x00010F14
		public unsafe AdpProgressIndicatorComponent m_BadgeScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x00106C44 File Offset: 0x00104E44
		// (set) Token: 0x06001F2A RID: 7978 RVA: 0x00012D33 File Offset: 0x00010F33
		public unsafe AdpProgressIndicatorComponent m_CardScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x00106C74 File Offset: 0x00104E74
		// (set) Token: 0x06001F2C RID: 7980 RVA: 0x00012D52 File Offset: 0x00010F52
		public unsafe TextMeshProUGUI m_CollectRateText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CollectRateText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CollectRateText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001F2D RID: 7981 RVA: 0x00106CA4 File Offset: 0x00104EA4
		// (set) Token: 0x06001F2E RID: 7982 RVA: 0x00012D71 File Offset: 0x00010F71
		public unsafe int m_DisplayCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DisplayCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DisplayCount)) = value;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001F2F RID: 7983 RVA: 0x00106CCC File Offset: 0x00104ECC
		// (set) Token: 0x06001F30 RID: 7984 RVA: 0x00012D8C File Offset: 0x00010F8C
		public unsafe int m_StartLoopCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_StartLoopCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_StartLoopCount)) = value;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x00106CF4 File Offset: 0x00104EF4
		// (set) Token: 0x06001F32 RID: 7986 RVA: 0x00012DA7 File Offset: 0x00010FA7
		public unsafe CanvasGroup m_ProductGridCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ProductGridCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ProductGridCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x00106D24 File Offset: 0x00104F24
		// (set) Token: 0x06001F34 RID: 7988 RVA: 0x00012DC6 File Offset: 0x00010FC6
		public unsafe CanvasGroup m_CardGridCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardGridCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardGridCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x00106D54 File Offset: 0x00104F54
		// (set) Token: 0x06001F36 RID: 7990 RVA: 0x00012DE5 File Offset: 0x00010FE5
		public unsafe CanvasGroup m_BadgeCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06001F37 RID: 7991 RVA: 0x00106D84 File Offset: 0x00104F84
		// (set) Token: 0x06001F38 RID: 7992 RVA: 0x00012E04 File Offset: 0x00011004
		public unsafe CanvasGroup m_CollectRateCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CollectRateCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CollectRateCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001F39 RID: 7993 RVA: 0x00106DB4 File Offset: 0x00104FB4
		// (set) Token: 0x06001F3A RID: 7994 RVA: 0x00012E23 File Offset: 0x00011023
		public unsafe UIButtonToggle m_RecipeButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_RecipeButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_RecipeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001F3B RID: 7995 RVA: 0x00106DE4 File Offset: 0x00104FE4
		// (set) Token: 0x06001F3C RID: 7996 RVA: 0x00012E42 File Offset: 0x00011042
		public unsafe UIButtonToggle m_BevButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BevButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BevButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001F3D RID: 7997 RVA: 0x00106E14 File Offset: 0x00105014
		// (set) Token: 0x06001F3E RID: 7998 RVA: 0x00012E61 File Offset: 0x00011061
		public unsafe UIButtonToggle m_CardButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001F3F RID: 7999 RVA: 0x00106E44 File Offset: 0x00105044
		// (set) Token: 0x06001F40 RID: 8000 RVA: 0x00012E80 File Offset: 0x00011080
		public unsafe UIButtonToggle m_AchievementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_AchievementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_AchievementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001F41 RID: 8001 RVA: 0x00106E74 File Offset: 0x00105074
		// (set) Token: 0x06001F42 RID: 8002 RVA: 0x00012E9F File Offset: 0x0001109F
		public unsafe TextMeshProUGUI m_RefreshWaveText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_RefreshWaveText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_RefreshWaveText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001F43 RID: 8003 RVA: 0x00106EA4 File Offset: 0x001050A4
		// (set) Token: 0x06001F44 RID: 8004 RVA: 0x00012EBE File Offset: 0x000110BE
		public unsafe CanvasGroup m_CurrentEliteCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentEliteCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentEliteCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001F45 RID: 8005 RVA: 0x00106ED4 File Offset: 0x001050D4
		// (set) Token: 0x06001F46 RID: 8006 RVA: 0x00012EDD File Offset: 0x000110DD
		public unsafe RectTransform m_CurrentEliteDesRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentEliteDesRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentEliteDesRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x00106F04 File Offset: 0x00105104
		// (set) Token: 0x06001F48 RID: 8008 RVA: 0x00012EFC File Offset: 0x000110FC
		public unsafe TextMeshProUGUI m_CurrentEliteTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentEliteTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentEliteTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x00106F34 File Offset: 0x00105134
		// (set) Token: 0x06001F4A RID: 8010 RVA: 0x00012F1B File Offset: 0x0001111B
		public unsafe TextMeshProUGUI m_CurrentEliteDes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentEliteDes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentEliteDes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x00106F64 File Offset: 0x00105164
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x00012F3A File Offset: 0x0001113A
		public unsafe GameObject m_CardElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x00106F94 File Offset: 0x00105194
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00012F59 File Offset: 0x00011159
		public unsafe GameObject m_BuffElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BuffElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BuffElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x00106FC4 File Offset: 0x001051C4
		// (set) Token: 0x06001F50 RID: 8016 RVA: 0x00012F78 File Offset: 0x00011178
		public unsafe RectTransform m_BuffElementRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BuffElementRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BuffElementRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x00106FF4 File Offset: 0x001051F4
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x00012F97 File Offset: 0x00011197
		public unsafe CanvasGroup m_CardPropertyCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardPropertyCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardPropertyCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x00107024 File Offset: 0x00105224
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x00012FB6 File Offset: 0x000111B6
		public unsafe CanvasGroup m_CardPropertyForeverCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardPropertyForeverCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardPropertyForeverCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x00107054 File Offset: 0x00105254
		// (set) Token: 0x06001F56 RID: 8022 RVA: 0x00012FD5 File Offset: 0x000111D5
		public unsafe CanvasGroup m_CardPropertyRemainingCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardPropertyRemainingCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardPropertyRemainingCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00107084 File Offset: 0x00105284
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00012FF4 File Offset: 0x000111F4
		public unsafe Image m_DangerousBGForForever
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DangerousBGForForever);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DangerousBGForForever), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x001070B4 File Offset: 0x001052B4
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x00013013 File Offset: 0x00011213
		public unsafe Image m_DangerousBGForRemaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DangerousBGForRemaining);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DangerousBGForRemaining), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x001070E4 File Offset: 0x001052E4
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x00013032 File Offset: 0x00011232
		public unsafe CanvasGroup m_DangerousTip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DangerousTip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DangerousTip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x00107114 File Offset: 0x00105314
		// (set) Token: 0x06001F5E RID: 8030 RVA: 0x00013051 File Offset: 0x00011251
		public unsafe TextMeshProUGUI m_CardTitleTextForForever
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardTitleTextForForever);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardTitleTextForForever), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x00107144 File Offset: 0x00105344
		// (set) Token: 0x06001F60 RID: 8032 RVA: 0x00013070 File Offset: 0x00011270
		public unsafe TextMeshProUGUI m_CardTitleTextForRemaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardTitleTextForRemaining);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardTitleTextForRemaining), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x00107174 File Offset: 0x00105374
		// (set) Token: 0x06001F62 RID: 8034 RVA: 0x0001308F File Offset: 0x0001128F
		public unsafe TextMeshProUGUI m_CardDescriptionUpTextForForever
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDescriptionUpTextForForever);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDescriptionUpTextForForever), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x001071A4 File Offset: 0x001053A4
		// (set) Token: 0x06001F64 RID: 8036 RVA: 0x000130AE File Offset: 0x000112AE
		public unsafe TextMeshProUGUI m_CardDescriptionUpTextForRemaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDescriptionUpTextForRemaining);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDescriptionUpTextForRemaining), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001F65 RID: 8037 RVA: 0x001071D4 File Offset: 0x001053D4
		// (set) Token: 0x06001F66 RID: 8038 RVA: 0x000130CD File Offset: 0x000112CD
		public unsafe TextMeshProUGUI m_CardDescriptionDownText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDescriptionDownText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDescriptionDownText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001F67 RID: 8039 RVA: 0x00107204 File Offset: 0x00105404
		// (set) Token: 0x06001F68 RID: 8040 RVA: 0x000130EC File Offset: 0x000112EC
		public unsafe TextMeshProUGUI m_CardDescriptionExtraText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDescriptionExtraText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDescriptionExtraText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001F69 RID: 8041 RVA: 0x00107234 File Offset: 0x00105434
		// (set) Token: 0x06001F6A RID: 8042 RVA: 0x0001310B File Offset: 0x0001130B
		public unsafe TextMeshProUGUI m_CardNumText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardNumText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardNumText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x00107264 File Offset: 0x00105464
		// (set) Token: 0x06001F6C RID: 8044 RVA: 0x0001312A File Offset: 0x0001132A
		public unsafe Color m_RemainingCardTitleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_RemainingCardTitleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_RemainingCardTitleColor)) = value;
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x0010728C File Offset: 0x0010548C
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x00013145 File Offset: 0x00011345
		public unsafe Color m_ForeverCardTitleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ForeverCardTitleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_ForeverCardTitleColor)) = value;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x001072B4 File Offset: 0x001054B4
		// (set) Token: 0x06001F70 RID: 8048 RVA: 0x00013160 File Offset: 0x00011360
		public unsafe Color m_DangerousCardTitleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DangerousCardTitleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DangerousCardTitleColor)) = value;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x001072DC File Offset: 0x001054DC
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x0001317B File Offset: 0x0001137B
		public unsafe Color m_CardSelectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardSelectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardSelectedColor)) = value;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x00107304 File Offset: 0x00105504
		// (set) Token: 0x06001F74 RID: 8052 RVA: 0x00013196 File Offset: 0x00011396
		public unsafe Color m_CardDeSelectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDeSelectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardDeSelectedColor)) = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x0010732C File Offset: 0x0010552C
		// (set) Token: 0x06001F76 RID: 8054 RVA: 0x000131B1 File Offset: 0x000113B1
		public unsafe CanvasGroup m_SelectedCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_SelectedCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_SelectedCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x0010735C File Offset: 0x0010555C
		// (set) Token: 0x06001F78 RID: 8056 RVA: 0x000131D0 File Offset: 0x000113D0
		public unsafe List<RogueLikeCardBase.CardType> m_CardTypeOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardTypeOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RogueLikeCardBase.CardType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardTypeOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x0010738C File Offset: 0x0010558C
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x000131EF File Offset: 0x000113EF
		public unsafe GameObject m_BadgeElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x001073BC File Offset: 0x001055BC
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x0001320E File Offset: 0x0001140E
		public unsafe Image m_BadgeImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x001073EC File Offset: 0x001055EC
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x0001322D File Offset: 0x0001142D
		public unsafe CanvasGroup m_BadgeDescriberCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeDescriberCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeDescriberCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x0010741C File Offset: 0x0010561C
		// (set) Token: 0x06001F80 RID: 8064 RVA: 0x0001324C File Offset: 0x0001144C
		public unsafe TextMeshProUGUI m_BadgeNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x0010744C File Offset: 0x0010564C
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x0001326B File Offset: 0x0001146B
		public unsafe TextMeshProUGUI m_BadgeDescriptionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeDescriptionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeDescriptionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x0010747C File Offset: 0x0010567C
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x0001328A File Offset: 0x0001148A
		public unsafe TextMeshProUGUI m_BadgeCollectRateText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeCollectRateText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BadgeCollectRateText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x001074AC File Offset: 0x001056AC
		// (set) Token: 0x06001F86 RID: 8070 RVA: 0x000132A9 File Offset: 0x000114A9
		public unsafe Color shadowColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_shadowColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_shadowColor)) = value;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001F87 RID: 8071 RVA: 0x001074D4 File Offset: 0x001056D4
		// (set) Token: 0x06001F88 RID: 8072 RVA: 0x000132C4 File Offset: 0x000114C4
		public unsafe List<int> m_GetProductsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_GetProductsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_GetProductsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x00107504 File Offset: 0x00105704
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x000132E3 File Offset: 0x000114E3
		public unsafe List<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> m_GetBadgeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_GetBadgeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DLC5_RogueLikeDataProfile.RogueLikeAchievementType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_GetBadgeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x00107534 File Offset: 0x00105734
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x00013302 File Offset: 0x00011502
		public unsafe DLC5_RogueLikePoolViewerPanel.PoolViewerType m_CurrentPoolViewerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentPoolViewerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentPoolViewerType)) = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x0010755C File Offset: 0x0010575C
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x0001331D File Offset: 0x0001151D
		public unsafe Il2CppReferenceArray<UIButtonToggle> m_AllToggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_AllToggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIButtonToggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_AllToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x0010758C File Offset: 0x0010578C
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x0001333C File Offset: 0x0001153C
		public unsafe static string REFRESH_WAVE_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_REFRESH_WAVE_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_REFRESH_WAVE_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x001075AC File Offset: 0x001057AC
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x0001334E File Offset: 0x0001154E
		public unsafe static string REFRESH_WAVE_INITIAL_TITLE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_REFRESH_WAVE_INITIAL_TITLE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_REFRESH_WAVE_INITIAL_TITLE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x001075CC File Offset: 0x001057CC
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x00013360 File Offset: 0x00011560
		public unsafe DLC5_RogueLikePoolViewerPanel.IdComparer m_RecipeComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_RecipeComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel.IdComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_RecipeComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x001075FC File Offset: 0x001057FC
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x0001337F File Offset: 0x0001157F
		public unsafe DLC5_RogueLikePoolViewerPanel.IdComparer m_BevComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BevComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel.IdComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BevComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x0010762C File Offset: 0x0010582C
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x0001339E File Offset: 0x0001159E
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<int, UIElementCluster, UIButtonSimple> m_GetProductsGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_GetProductsGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<int, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_GetProductsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x0010765C File Offset: 0x0010585C
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x000133BD File Offset: 0x000115BD
		public unsafe StaticVirtualScrollListUILogicalGroupT<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair, UIElementCluster, UIButtonSimple> m_CardLogicalGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardLogicalGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVirtualScrollListUILogicalGroupT<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CardLogicalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x0010768C File Offset: 0x0010588C
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x000133DC File Offset: 0x000115DC
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, UIElementCluster, UIButtonSimple> m_AchievementGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_AchievementGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_AchievementGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x001076BC File Offset: 0x001058BC
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x000133FB File Offset: 0x000115FB
		public unsafe CanvasGroup m_DescriberCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DescriberCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_DescriberCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x001076EC File Offset: 0x001058EC
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0001341A File Offset: 0x0001161A
		public Nullable<RogueLikeCardBase.CardType> m_CurrentCardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentCardType);
				return new Nullable<RogueLikeCardBase.CardType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<RogueLikeCardBase.CardType>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_CurrentCardType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<RogueLikeCardBase.CardType>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0010771C File Offset: 0x0010591C
		// (set) Token: 0x06001FA2 RID: 8098 RVA: 0x00013448 File Offset: 0x00011648
		public unsafe bool m_BanOtherPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BanOtherPanel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BanOtherPanel)) = value;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x00107744 File Offset: 0x00105944
		// (set) Token: 0x06001FA4 RID: 8100 RVA: 0x00013463 File Offset: 0x00011663
		public unsafe List<GameObject> m_BuffInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BuffInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.NativeFieldInfoPtr_m_BuffInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectStackParent;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewerGridContent;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeViewerGridContent;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeFieldInfoPtr_m_CardViewerGridContent;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeFieldInfoPtr_m_Describer;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionExecutionScheduler;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeFieldInfoPtr_m_GetProductScroller;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeScroller;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeFieldInfoPtr_m_CardScroller;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectRateText;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayCount;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeFieldInfoPtr_m_StartLoopCount;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeFieldInfoPtr_m_ProductGridCanvas;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeFieldInfoPtr_m_CardGridCanvas;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeCanvas;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectRateCanvas;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeButton;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeFieldInfoPtr_m_BevButton;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeFieldInfoPtr_m_CardButton;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeFieldInfoPtr_m_AchievementButton;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshWaveText;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentEliteCanvas;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentEliteDesRect;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentEliteTitle;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentEliteDes;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeFieldInfoPtr_m_CardElement;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeFieldInfoPtr_m_BuffElement;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeFieldInfoPtr_m_BuffElementRectTransform;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeFieldInfoPtr_m_CardPropertyCanvasGroup;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeFieldInfoPtr_m_CardPropertyForeverCanvasGroup;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeFieldInfoPtr_m_CardPropertyRemainingCanvasGroup;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeFieldInfoPtr_m_DangerousBGForForever;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeFieldInfoPtr_m_DangerousBGForRemaining;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeFieldInfoPtr_m_DangerousTip;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeFieldInfoPtr_m_CardTitleTextForForever;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeFieldInfoPtr_m_CardTitleTextForRemaining;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeFieldInfoPtr_m_CardDescriptionUpTextForForever;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeFieldInfoPtr_m_CardDescriptionUpTextForRemaining;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeFieldInfoPtr_m_CardDescriptionDownText;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeFieldInfoPtr_m_CardDescriptionExtraText;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeFieldInfoPtr_m_CardNumText;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeFieldInfoPtr_m_RemainingCardTitleColor;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeFieldInfoPtr_m_ForeverCardTitleColor;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeFieldInfoPtr_m_DangerousCardTitleColor;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeFieldInfoPtr_m_CardSelectedColor;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeFieldInfoPtr_m_CardDeSelectedColor;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedCanvasGroup;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeFieldInfoPtr_m_CardTypeOrder;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeElement;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeImage;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeDescriberCanvasGroup;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeNameText;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeDescriptionText;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeFieldInfoPtr_m_BadgeCollectRateText;

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeFieldInfoPtr_shadowColor;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeFieldInfoPtr_m_GetProductsList;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeFieldInfoPtr_m_GetBadgeList;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPoolViewerType;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeFieldInfoPtr_m_AllToggles;

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeFieldInfoPtr_REFRESH_WAVE_TITLE;

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeFieldInfoPtr_REFRESH_WAVE_INITIAL_TITLE;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeComparer;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeFieldInfoPtr_m_BevComparer;

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeFieldInfoPtr_m_GetProductsGroup;

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeFieldInfoPtr_m_CardLogicalGroup;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeFieldInfoPtr_m_AchievementGroup;

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberCanvas;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCardType;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeFieldInfoPtr_m_BanOtherPanel;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeFieldInfoPtr_m_BuffInstances;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeMethodInfoPtr_get_RunTimeData_Private_get_RogueLikeRunTimeData_0;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_2_RogueLikeRunTimeData_PoolViewerType_0;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCardElement_Private_Void_0;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentViewer_Private_Void_PoolViewerType_0;

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEliteChallengeBorder_Private_Void_0;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeMethodInfoPtr_InitCard_Private_Void_RogueLikeCardInstancePair_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeMethodInfoPtr_OnCardBtnSelected_Private_Void_RogueLikeCardInstancePair_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeMethodInfoPtr_DescribeCardAlbum_Private_Void_RogueLikeCardInstancePair_0;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeMethodInfoPtr_Fade_Private_Void_0;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeMethodInfoPtr_Blink_Private_Void_0;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__74_0_Private_Void_CallbackContext_0;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__74_2_Private_Void_0;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__74_3_Private_Void_0;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__74_4_Private_Void_0;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__74_5_Private_Void_0;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__74_6_Private_Void_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__74_7_Private_Void_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__74_8_Private_Void_RogueLikeAchievementType_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__74_9_Private_Void_RogueLikeAchievementType_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_ValueTuple_2_String_String_PDM_0;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentViewer_b__77_1_Private_Boolean_RogueLikeCardInstancePair_0;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeMethodInfoPtr__Fade_b__83_0_Private_Void_Single_0;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeMethodInfoPtr__Blink_b__84_0_Private_Void_Single_0;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeMethodInfoPtr__Blink_b__84_1_Private_Void_0;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeMethodInfoPtr__Blink_b__84_2_Private_Void_Single_0;

		// Token: 0x020006F8 RID: 1784
		public enum PoolViewerType
		{
			// Token: 0x040064FE RID: 25854
			Recipe,
			// Token: 0x040064FF RID: 25855
			Bev,
			// Token: 0x04006500 RID: 25856
			Card,
			// Token: 0x04006501 RID: 25857
			Achievement
		}

		// Token: 0x020006F9 RID: 1785
		public class RogueLikeCardInstancePair : Il2CppSystem.Object
		{
			// Token: 0x06009B5E RID: 39774 RVA: 0x00294540 File Offset: 0x00292740
			// Note: this type is marked as 'beforefieldinit'.
			static RogueLikeCardInstancePair()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "RogueLikeCardInstancePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair>.NativeClassPtr);
				DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeFieldInfoPtr_CardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair>.NativeClassPtr, "CardType");
				DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeFieldInfoPtr_PersistentCardInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair>.NativeClassPtr, "PersistentCardInstances");
				DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeMethodInfoPtr__ctor_Public_Void_CardType_Il2CppReferenceArray_1_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair>.NativeClassPtr, 100668784);
				DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeMethodInfoPtr_GetActiveCardNum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair>.NativeClassPtr, 100668785);
				DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeMethodInfoPtr_GetAlbumDescription_Public_String_String_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair>.NativeClassPtr, 100668786);
				DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeMethodInfoPtr_GetTargetIndexCardDescription_Public_String_String_RogueLikeRunTimeData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair>.NativeClassPtr, 100668787);
			}

			// Token: 0x06009B5F RID: 39775 RVA: 0x002945E4 File Offset: 0x002927E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76270, RefRangeEnd = 76271, XrefRangeStart = 76268, XrefRangeEnd = 76270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RogueLikeCardInstancePair(RogueLikeCardBase.CardType cardType, Il2CppReferenceArray<KeyValuePair<RogueLikePersistentCardInstance, int>> persistentCardInstances) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref cardType;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(persistentCardInstances);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeMethodInfoPtr__ctor_Public_Void_CardType_Il2CppReferenceArray_1_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B60 RID: 39776 RVA: 0x00294640 File Offset: 0x00292840
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76307, RefRangeEnd = 76309, XrefRangeStart = 76271, XrefRangeEnd = 76307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetActiveCardNum()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeMethodInfoPtr_GetActiveCardNum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009B61 RID: 39777 RVA: 0x0029467C File Offset: 0x0029287C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76313, RefRangeEnd = 76314, XrefRangeStart = 76309, XrefRangeEnd = 76313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetAlbumDescription(string oldDescription, RogueLikeRunTimeData runTimeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeMethodInfoPtr_GetAlbumDescription_Public_String_String_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009B62 RID: 39778 RVA: 0x002946D8 File Offset: 0x002928D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76314, XrefRangeEnd = 76319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetTargetIndexCardDescription(string oldDescription, RogueLikeRunTimeData runTimeData, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeMethodInfoPtr_GetTargetIndexCardDescription_Public_String_String_RogueLikeRunTimeData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009B63 RID: 39779 RVA: 0x00054121 File Offset: 0x00052321
			public RogueLikeCardInstancePair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700338C RID: 13196
			// (get) Token: 0x06009B64 RID: 39780 RVA: 0x00294740 File Offset: 0x00292940
			// (set) Token: 0x06009B65 RID: 39781 RVA: 0x0005412A File Offset: 0x0005232A
			public unsafe RogueLikeCardBase.CardType CardType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeFieldInfoPtr_CardType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeFieldInfoPtr_CardType)) = value;
				}
			}

			// Token: 0x1700338D RID: 13197
			// (get) Token: 0x06009B66 RID: 39782 RVA: 0x00294768 File Offset: 0x00292968
			// (set) Token: 0x06009B67 RID: 39783 RVA: 0x00054145 File Offset: 0x00052345
			public unsafe Il2CppReferenceArray<KeyValuePair<RogueLikePersistentCardInstance, int>> PersistentCardInstances
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeFieldInfoPtr_PersistentCardInstances);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<RogueLikePersistentCardInstance, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.NativeFieldInfoPtr_PersistentCardInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006502 RID: 25858
			private static readonly IntPtr NativeFieldInfoPtr_CardType;

			// Token: 0x04006503 RID: 25859
			private static readonly IntPtr NativeFieldInfoPtr_PersistentCardInstances;

			// Token: 0x04006504 RID: 25860
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CardType_Il2CppReferenceArray_1_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;

			// Token: 0x04006505 RID: 25861
			private static readonly IntPtr NativeMethodInfoPtr_GetActiveCardNum_Public_Int32_0;

			// Token: 0x04006506 RID: 25862
			private static readonly IntPtr NativeMethodInfoPtr_GetAlbumDescription_Public_String_String_RogueLikeRunTimeData_0;

			// Token: 0x04006507 RID: 25863
			private static readonly IntPtr NativeMethodInfoPtr_GetTargetIndexCardDescription_Public_String_String_RogueLikeRunTimeData_Int32_0;

			// Token: 0x02000FCB RID: 4043
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePoolViewerPanel+RogueLikeCardInstancePair+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x0601163B RID: 71227 RVA: 0x003FF724 File Offset: 0x003FD924
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c>.NativeClassPtr);
					DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c>.NativeClassPtr, "<>9");
					DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c>.NativeClassPtr, "<>9__3_0");
					DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c>.NativeClassPtr, "<>9__3_1");
					DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c>.NativeClassPtr, 100668789);
					DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeMethodInfoPtr__GetActiveCardNum_b__3_0_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c>.NativeClassPtr, 100668790);
					DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeMethodInfoPtr__GetActiveCardNum_b__3_1_Internal_Int32_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c>.NativeClassPtr, 100668791);
				}

				// Token: 0x0601163C RID: 71228 RVA: 0x003FF7C8 File Offset: 0x003FD9C8
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601163D RID: 71229 RVA: 0x003FF804 File Offset: 0x003FDA04
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76266, XrefRangeEnd = 76267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _GetActiveCardNum_b__3_0(KeyValuePair<RogueLikePersistentCardInstance, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeMethodInfoPtr__GetActiveCardNum_b__3_0_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0601163E RID: 71230 RVA: 0x003FF858 File Offset: 0x003FDA58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76267, XrefRangeEnd = 76268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _GetActiveCardNum_b__3_1(KeyValuePair<RogueLikePersistentCardInstance, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeMethodInfoPtr__GetActiveCardNum_b__3_1_Internal_Int32_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0601163F RID: 71231 RVA: 0x000974FD File Offset: 0x000956FD
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A67 RID: 23143
				// (get) Token: 0x06011640 RID: 71232 RVA: 0x003FF8AC File Offset: 0x003FDAAC
				// (set) Token: 0x06011641 RID: 71233 RVA: 0x00097506 File Offset: 0x00095706
				public unsafe static DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A68 RID: 23144
				// (get) Token: 0x06011642 RID: 71234 RVA: 0x003FF8D4 File Offset: 0x003FDAD4
				// (set) Token: 0x06011643 RID: 71235 RVA: 0x00097518 File Offset: 0x00095718
				public unsafe static Func<KeyValuePair<RogueLikePersistentCardInstance, int>, bool> __9__3_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<RogueLikePersistentCardInstance, int>, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A69 RID: 23145
				// (get) Token: 0x06011644 RID: 71236 RVA: 0x003FF8FC File Offset: 0x003FDAFC
				// (set) Token: 0x06011645 RID: 71237 RVA: 0x0009752A File Offset: 0x0009572A
				public unsafe static Func<KeyValuePair<RogueLikePersistentCardInstance, int>, int> __9__3_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<RogueLikePersistentCardInstance, int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AFBC RID: 44988
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400AFBD RID: 44989
				private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

				// Token: 0x0400AFBE RID: 44990
				private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

				// Token: 0x0400AFBF RID: 44991
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AFC0 RID: 44992
				private static readonly IntPtr NativeMethodInfoPtr__GetActiveCardNum_b__3_0_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;

				// Token: 0x0400AFC1 RID: 44993
				private static readonly IntPtr NativeMethodInfoPtr__GetActiveCardNum_b__3_1_Internal_Int32_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;
			}
		}

		// Token: 0x020006FA RID: 1786
		public class IdComparer : Il2CppSystem.Object
		{
			// Token: 0x06009B68 RID: 39784 RVA: 0x00294798 File Offset: 0x00292998
			// Note: this type is marked as 'beforefieldinit'.
			static IdComparer()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "IdComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr);
				DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_remainedProductPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr, "remainedProductPool");
				DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_obtainedProductPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr, "obtainedProductPool");
				DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_initialProductPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr, "initialProductPool");
				DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_allProductPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr, "allProductPool");
				DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_elementRefreshWaveIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr, "elementRefreshWaveIndex");
				DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr_get_RemainedProductPool_Public_get_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr, 100668792);
				DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr_get_ObtainedProductPool_Public_get_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr, 100668793);
				DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr_get_InitialProductPool_Public_get_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr, 100668794);
				DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr_get_AllProductPool_Public_get_HashSet_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr, 100668795);
				DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_Int32_HashSet_1_Int32_HashSet_1_Int32_HashSet_1_Int32_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr, 100668796);
				DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr_GetCollectRate_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr, 100668797);
				DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr, 100668798);
			}

			// Token: 0x17003393 RID: 13203
			// (get) Token: 0x06009B69 RID: 39785 RVA: 0x002948B4 File Offset: 0x00292AB4
			public unsafe HashSet<int> RemainedProductPool
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr_get_RemainedProductPool_Public_get_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17003394 RID: 13204
			// (get) Token: 0x06009B6A RID: 39786 RVA: 0x002948F4 File Offset: 0x00292AF4
			public unsafe HashSet<int> ObtainedProductPool
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr_get_ObtainedProductPool_Public_get_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17003395 RID: 13205
			// (get) Token: 0x06009B6B RID: 39787 RVA: 0x00294934 File Offset: 0x00292B34
			public unsafe HashSet<int> InitialProductPool
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr_get_InitialProductPool_Public_get_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr3) : null;
				}
			}

			// Token: 0x17003396 RID: 13206
			// (get) Token: 0x06009B6C RID: 39788 RVA: 0x00294974 File Offset: 0x00292B74
			public unsafe HashSet<int> AllProductPool
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr_get_AllProductPool_Public_get_HashSet_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr3) : null;
				}
			}

			// Token: 0x06009B6D RID: 39789 RVA: 0x002949B4 File Offset: 0x00292BB4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 76325, RefRangeEnd = 76327, XrefRangeStart = 76319, XrefRangeEnd = 76325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IdComparer(HashSet<int> remainedProductPool, HashSet<int> obtainedProductPool, HashSet<int> initialProductPool, HashSet<int> allProductPool, Dictionary<int, int> elementRefreshWaveIndex) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.IdComparer>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(remainedProductPool);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obtainedProductPool);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initialProductPool);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allProductPool);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementRefreshWaveIndex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_Int32_HashSet_1_Int32_HashSet_1_Int32_HashSet_1_Int32_Dictionary_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B6E RID: 39790 RVA: 0x00294A4C File Offset: 0x00292C4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76327, XrefRangeEnd = 76328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float GetCollectRate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr_GetCollectRate_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009B6F RID: 39791 RVA: 0x00294A88 File Offset: 0x00292C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76328, XrefRangeEnd = 76359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(int x, int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009B70 RID: 39792 RVA: 0x00054164 File Offset: 0x00052364
			public IdComparer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700338E RID: 13198
			// (get) Token: 0x06009B71 RID: 39793 RVA: 0x00294AE0 File Offset: 0x00292CE0
			// (set) Token: 0x06009B72 RID: 39794 RVA: 0x0005416D File Offset: 0x0005236D
			public unsafe HashSet<int> remainedProductPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_remainedProductPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_remainedProductPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700338F RID: 13199
			// (get) Token: 0x06009B73 RID: 39795 RVA: 0x00294B10 File Offset: 0x00292D10
			// (set) Token: 0x06009B74 RID: 39796 RVA: 0x0005418C File Offset: 0x0005238C
			public unsafe HashSet<int> obtainedProductPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_obtainedProductPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_obtainedProductPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003390 RID: 13200
			// (get) Token: 0x06009B75 RID: 39797 RVA: 0x00294B40 File Offset: 0x00292D40
			// (set) Token: 0x06009B76 RID: 39798 RVA: 0x000541AB File Offset: 0x000523AB
			public unsafe HashSet<int> initialProductPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_initialProductPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_initialProductPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003391 RID: 13201
			// (get) Token: 0x06009B77 RID: 39799 RVA: 0x00294B70 File Offset: 0x00292D70
			// (set) Token: 0x06009B78 RID: 39800 RVA: 0x000541CA File Offset: 0x000523CA
			public unsafe HashSet<int> allProductPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_allProductPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_allProductPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003392 RID: 13202
			// (get) Token: 0x06009B79 RID: 39801 RVA: 0x00294BA0 File Offset: 0x00292DA0
			// (set) Token: 0x06009B7A RID: 39802 RVA: 0x000541E9 File Offset: 0x000523E9
			public unsafe Dictionary<int, int> elementRefreshWaveIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_elementRefreshWaveIndex);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.IdComparer.NativeFieldInfoPtr_elementRefreshWaveIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006508 RID: 25864
			private static readonly IntPtr NativeFieldInfoPtr_remainedProductPool;

			// Token: 0x04006509 RID: 25865
			private static readonly IntPtr NativeFieldInfoPtr_obtainedProductPool;

			// Token: 0x0400650A RID: 25866
			private static readonly IntPtr NativeFieldInfoPtr_initialProductPool;

			// Token: 0x0400650B RID: 25867
			private static readonly IntPtr NativeFieldInfoPtr_allProductPool;

			// Token: 0x0400650C RID: 25868
			private static readonly IntPtr NativeFieldInfoPtr_elementRefreshWaveIndex;

			// Token: 0x0400650D RID: 25869
			private static readonly IntPtr NativeMethodInfoPtr_get_RemainedProductPool_Public_get_HashSet_1_Int32_0;

			// Token: 0x0400650E RID: 25870
			private static readonly IntPtr NativeMethodInfoPtr_get_ObtainedProductPool_Public_get_HashSet_1_Int32_0;

			// Token: 0x0400650F RID: 25871
			private static readonly IntPtr NativeMethodInfoPtr_get_InitialProductPool_Public_get_HashSet_1_Int32_0;

			// Token: 0x04006510 RID: 25872
			private static readonly IntPtr NativeMethodInfoPtr_get_AllProductPool_Public_get_HashSet_1_Int32_0;

			// Token: 0x04006511 RID: 25873
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_Int32_HashSet_1_Int32_HashSet_1_Int32_HashSet_1_Int32_Dictionary_2_Int32_Int32_0;

			// Token: 0x04006512 RID: 25874
			private static readonly IntPtr NativeMethodInfoPtr_GetCollectRate_Public_Single_0;

			// Token: 0x04006513 RID: 25875
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Int32_Int32_0;
		}

		// Token: 0x020006FB RID: 1787
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePoolViewerPanel+<>c__DisplayClass74_0")]
		public sealed class __c__DisplayClass74_0 : Il2CppSystem.Object
		{
			// Token: 0x06009B7B RID: 39803 RVA: 0x00294BD0 File Offset: 0x00292DD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "<>c__DisplayClass74_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0>.NativeClassPtr);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0>.NativeClassPtr, "visual");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr_productId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0>.NativeClassPtr, "productId");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr_hasInPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0>.NativeClassPtr, "hasInPool");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr_obtained = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0>.NativeClassPtr, "obtained");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0>.NativeClassPtr, 100668799);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0>.NativeClassPtr, 100668800);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0>.NativeClassPtr, 100668801);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0>.NativeClassPtr, 100668802);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPanelInitialize_b__15_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0>.NativeClassPtr, 100668803);
			}

			// Token: 0x06009B7C RID: 39804 RVA: 0x00294CC4 File Offset: 0x00292EC4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B7D RID: 39805 RVA: 0x00294D00 File Offset: 0x00292F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76359, XrefRangeEnd = 76361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B7E RID: 39806 RVA: 0x00294D44 File Offset: 0x00292F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76361, XrefRangeEnd = 76363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__12(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B7F RID: 39807 RVA: 0x00294D88 File Offset: 0x00292F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76363, XrefRangeEnd = 76373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__13(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B80 RID: 39808 RVA: 0x00294DCC File Offset: 0x00292FCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76373, XrefRangeEnd = 76375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__15(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeMethodInfoPtr__OnPanelInitialize_b__15_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B81 RID: 39809 RVA: 0x00054208 File Offset: 0x00052408
			public __c__DisplayClass74_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003397 RID: 13207
			// (get) Token: 0x06009B82 RID: 39810 RVA: 0x00294E10 File Offset: 0x00293010
			// (set) Token: 0x06009B83 RID: 39811 RVA: 0x00054211 File Offset: 0x00052411
			public unsafe Sprite visual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr_visual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003398 RID: 13208
			// (get) Token: 0x06009B84 RID: 39812 RVA: 0x00294E40 File Offset: 0x00293040
			// (set) Token: 0x06009B85 RID: 39813 RVA: 0x00054230 File Offset: 0x00052430
			public unsafe int productId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr_productId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr_productId)) = value;
				}
			}

			// Token: 0x17003399 RID: 13209
			// (get) Token: 0x06009B86 RID: 39814 RVA: 0x00294E68 File Offset: 0x00293068
			// (set) Token: 0x06009B87 RID: 39815 RVA: 0x0005424B File Offset: 0x0005244B
			public unsafe bool hasInPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr_hasInPool);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr_hasInPool)) = value;
				}
			}

			// Token: 0x1700339A RID: 13210
			// (get) Token: 0x06009B88 RID: 39816 RVA: 0x00294E90 File Offset: 0x00293090
			// (set) Token: 0x06009B89 RID: 39817 RVA: 0x00054266 File Offset: 0x00052466
			public unsafe bool obtained
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr_obtained);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr_obtained)) = value;
				}
			}

			// Token: 0x1700339B RID: 13211
			// (get) Token: 0x06009B8A RID: 39818 RVA: 0x00294EB8 File Offset: 0x002930B8
			// (set) Token: 0x06009B8B RID: 39819 RVA: 0x00054281 File Offset: 0x00052481
			public unsafe DLC5_RogueLikePoolViewerPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006514 RID: 25876
			private static readonly IntPtr NativeFieldInfoPtr_visual;

			// Token: 0x04006515 RID: 25877
			private static readonly IntPtr NativeFieldInfoPtr_productId;

			// Token: 0x04006516 RID: 25878
			private static readonly IntPtr NativeFieldInfoPtr_hasInPool;

			// Token: 0x04006517 RID: 25879
			private static readonly IntPtr NativeFieldInfoPtr_obtained;

			// Token: 0x04006518 RID: 25880
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006519 RID: 25881
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400651A RID: 25882
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_Image_0;

			// Token: 0x0400651B RID: 25883
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_Void_Image_0;

			// Token: 0x0400651C RID: 25884
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Void_Image_0;

			// Token: 0x0400651D RID: 25885
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_Internal_Void_Image_0;
		}

		// Token: 0x020006FC RID: 1788
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePoolViewerPanel+<>c__DisplayClass74_1")]
		public sealed class __c__DisplayClass74_1 : Il2CppSystem.Object
		{
			// Token: 0x06009B8C RID: 39820 RVA: 0x00294EE8 File Offset: 0x002930E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "<>c__DisplayClass74_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1>.NativeClassPtr);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1.NativeFieldInfoPtr_productId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1>.NativeClassPtr, "productId");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1>.NativeClassPtr, 100668804);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1.NativeMethodInfoPtr__OnPanelInitialize_b__16_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1>.NativeClassPtr, 100668805);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1.NativeMethodInfoPtr__OnPanelInitialize_b__17_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1>.NativeClassPtr, 100668806);
			}

			// Token: 0x06009B8D RID: 39821 RVA: 0x00294F78 File Offset: 0x00293178
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B8E RID: 39822 RVA: 0x00294FB4 File Offset: 0x002931B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76375, XrefRangeEnd = 76394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__16()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1.NativeMethodInfoPtr__OnPanelInitialize_b__16_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B8F RID: 39823 RVA: 0x00294FE8 File Offset: 0x002931E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76394, XrefRangeEnd = 76414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__17()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1.NativeMethodInfoPtr__OnPanelInitialize_b__17_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B90 RID: 39824 RVA: 0x000542A0 File Offset: 0x000524A0
			public __c__DisplayClass74_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700339C RID: 13212
			// (get) Token: 0x06009B91 RID: 39825 RVA: 0x0029501C File Offset: 0x0029321C
			// (set) Token: 0x06009B92 RID: 39826 RVA: 0x000542A9 File Offset: 0x000524A9
			public unsafe int productId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1.NativeFieldInfoPtr_productId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1.NativeFieldInfoPtr_productId)) = value;
				}
			}

			// Token: 0x1700339D RID: 13213
			// (get) Token: 0x06009B93 RID: 39827 RVA: 0x00295044 File Offset: 0x00293244
			// (set) Token: 0x06009B94 RID: 39828 RVA: 0x000542C4 File Offset: 0x000524C4
			public unsafe DLC5_RogueLikePoolViewerPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400651E RID: 25886
			private static readonly IntPtr NativeFieldInfoPtr_productId;

			// Token: 0x0400651F RID: 25887
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006520 RID: 25888
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006521 RID: 25889
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__16_Internal_Void_0;

			// Token: 0x04006522 RID: 25890
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_Internal_Void_0;
		}

		// Token: 0x020006FD RID: 1789
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePoolViewerPanel+<>c__DisplayClass74_2")]
		public sealed class __c__DisplayClass74_2 : Il2CppSystem.Object
		{
			// Token: 0x06009B95 RID: 39829 RVA: 0x00295074 File Offset: 0x00293274
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_2()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "<>c__DisplayClass74_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2>.NativeClassPtr);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2>.NativeClassPtr, "sprite");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeFieldInfoPtr_getBadge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2>.NativeClassPtr, "getBadge");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2>.NativeClassPtr, 100668807);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeMethodInfoPtr__OnPanelInitialize_b__18_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2>.NativeClassPtr, 100668808);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeMethodInfoPtr__OnPanelInitialize_b__19_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2>.NativeClassPtr, 100668809);
			}

			// Token: 0x06009B96 RID: 39830 RVA: 0x00295118 File Offset: 0x00293318
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B97 RID: 39831 RVA: 0x00295154 File Offset: 0x00293354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76414, XrefRangeEnd = 76416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__18(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeMethodInfoPtr__OnPanelInitialize_b__18_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B98 RID: 39832 RVA: 0x00295198 File Offset: 0x00293398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__19(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeMethodInfoPtr__OnPanelInitialize_b__19_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B99 RID: 39833 RVA: 0x000542E3 File Offset: 0x000524E3
			public __c__DisplayClass74_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700339E RID: 13214
			// (get) Token: 0x06009B9A RID: 39834 RVA: 0x002951DC File Offset: 0x002933DC
			// (set) Token: 0x06009B9B RID: 39835 RVA: 0x000542EC File Offset: 0x000524EC
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700339F RID: 13215
			// (get) Token: 0x06009B9C RID: 39836 RVA: 0x0029520C File Offset: 0x0029340C
			// (set) Token: 0x06009B9D RID: 39837 RVA: 0x0005430B File Offset: 0x0005250B
			public unsafe bool getBadge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeFieldInfoPtr_getBadge);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeFieldInfoPtr_getBadge)) = value;
				}
			}

			// Token: 0x170033A0 RID: 13216
			// (get) Token: 0x06009B9E RID: 39838 RVA: 0x00295234 File Offset: 0x00293434
			// (set) Token: 0x06009B9F RID: 39839 RVA: 0x00054326 File Offset: 0x00052526
			public unsafe DLC5_RogueLikePoolViewerPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006523 RID: 25891
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x04006524 RID: 25892
			private static readonly IntPtr NativeFieldInfoPtr_getBadge;

			// Token: 0x04006525 RID: 25893
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006526 RID: 25894
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006527 RID: 25895
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__18_Internal_Void_Image_0;

			// Token: 0x04006528 RID: 25896
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__19_Internal_Void_Image_0;
		}

		// Token: 0x020006FE RID: 1790
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePoolViewerPanel+<>c__DisplayClass74_3")]
		public sealed class __c__DisplayClass74_3 : Il2CppSystem.Object
		{
			// Token: 0x06009BA0 RID: 39840 RVA: 0x00295264 File Offset: 0x00293464
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_3()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "<>c__DisplayClass74_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3>.NativeClassPtr);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3.NativeFieldInfoPtr_achievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3>.NativeClassPtr, "achievement");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3>.NativeClassPtr, 100668810);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPanelInitialize_b__21_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3>.NativeClassPtr, 100668811);
			}

			// Token: 0x06009BA1 RID: 39841 RVA: 0x002952E0 File Offset: 0x002934E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BA2 RID: 39842 RVA: 0x0029531C File Offset: 0x0029351C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76416, XrefRangeEnd = 76424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__21()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3.NativeMethodInfoPtr__OnPanelInitialize_b__21_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BA3 RID: 39843 RVA: 0x00054345 File Offset: 0x00052545
			public __c__DisplayClass74_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033A1 RID: 13217
			// (get) Token: 0x06009BA4 RID: 39844 RVA: 0x00295350 File Offset: 0x00293550
			// (set) Token: 0x06009BA5 RID: 39845 RVA: 0x0005434E File Offset: 0x0005254E
			public DLC5_RogueLikeDataProfile.RogueLikeAchievement achievement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3.NativeFieldInfoPtr_achievement);
					return new DLC5_RogueLikeDataProfile.RogueLikeAchievement(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeAchievement>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3.NativeFieldInfoPtr_achievement), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.RogueLikeAchievement>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170033A2 RID: 13218
			// (get) Token: 0x06009BA6 RID: 39846 RVA: 0x00295380 File Offset: 0x00293580
			// (set) Token: 0x06009BA7 RID: 39847 RVA: 0x0005437C File Offset: 0x0005257C
			public unsafe DLC5_RogueLikePoolViewerPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass74_3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006529 RID: 25897
			private static readonly IntPtr NativeFieldInfoPtr_achievement;

			// Token: 0x0400652A RID: 25898
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400652B RID: 25899
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400652C RID: 25900
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__21_Internal_Void_0;
		}

		// Token: 0x020006FF RID: 1791
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePoolViewerPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009BA8 RID: 39848 RVA: 0x002953B0 File Offset: 0x002935B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr);
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__74_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__74_1");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__74_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__74_11");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__74_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__74_14");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__74_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__74_20");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__75_0");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__75_1");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__75_2");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__75_3");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__75_4");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__75_5");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__76_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__76_3");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__76_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__76_4");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__77_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__77_0");
				DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__79_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, "<>9__79_0");
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668813);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__74_1_Internal_Void_UIButtonToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668814);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__74_11_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668815);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__74_14_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668816);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__74_20_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668817);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__75_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668818);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__75_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668819);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__75_2_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668820);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__75_3_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668821);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__75_4_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668822);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__75_5_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668823);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__UpdateCardElement_b__76_3_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668824);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__UpdateCardElement_b__76_4_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668825);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__UpdateCurrentViewer_b__77_0_Internal_Boolean_RogueLikeCardInstancePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668826);
				DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__InitCard_b__79_0_Internal_Int32_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr, 100668827);
			}

			// Token: 0x06009BA9 RID: 39849 RVA: 0x00295634 File Offset: 0x00293834
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BAA RID: 39850 RVA: 0x00295670 File Offset: 0x00293870
			[CallerCount(0)]
			public unsafe void _OnPanelInitialize_b__74_1(UIButtonToggle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__74_1_Internal_Void_UIButtonToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BAB RID: 39851 RVA: 0x002956B4 File Offset: 0x002938B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__74_11(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__74_11_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BAC RID: 39852 RVA: 0x002956F8 File Offset: 0x002938F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__74_14(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__74_14_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BAD RID: 39853 RVA: 0x0029573C File Offset: 0x0029393C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__74_20(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__74_20_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BAE RID: 39854 RVA: 0x00295780 File Offset: 0x00293980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76424, XrefRangeEnd = 76425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__75_0(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__75_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009BAF RID: 39855 RVA: 0x002957D4 File Offset: 0x002939D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76425, XrefRangeEnd = 76426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpen_b__75_1(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__75_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009BB0 RID: 39856 RVA: 0x00295828 File Offset: 0x00293A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76426, XrefRangeEnd = 76427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpen_b__75_2(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__75_2_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009BB1 RID: 39857 RVA: 0x0029587C File Offset: 0x00293A7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76427, XrefRangeEnd = 76428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__75_3(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__75_3_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009BB2 RID: 39858 RVA: 0x002958D0 File Offset: 0x00293AD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76428, XrefRangeEnd = 76429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpen_b__75_4(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__75_4_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009BB3 RID: 39859 RVA: 0x00295924 File Offset: 0x00293B24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76429, XrefRangeEnd = 76430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpen_b__75_5(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__75_5_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009BB4 RID: 39860 RVA: 0x00295978 File Offset: 0x00293B78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76430, XrefRangeEnd = 76434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCardElement_b__76_3(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__UpdateCardElement_b__76_3_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BB5 RID: 39861 RVA: 0x002959BC File Offset: 0x00293BBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76434, XrefRangeEnd = 76438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCardElement_b__76_4(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__UpdateCardElement_b__76_4_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BB6 RID: 39862 RVA: 0x00295A00 File Offset: 0x00293C00
			[CallerCount(0)]
			public unsafe bool _UpdateCurrentViewer_b__77_0(DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__UpdateCurrentViewer_b__77_0_Internal_Boolean_RogueLikeCardInstancePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009BB7 RID: 39863 RVA: 0x00295A50 File Offset: 0x00293C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76438, XrefRangeEnd = 76439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _InitCard_b__79_0(KeyValuePair<RogueLikePersistentCardInstance, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c.NativeMethodInfoPtr__InitCard_b__79_0_Internal_Int32_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009BB8 RID: 39864 RVA: 0x0005439B File Offset: 0x0005259B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033A3 RID: 13219
			// (get) Token: 0x06009BB9 RID: 39865 RVA: 0x00295AA4 File Offset: 0x00293CA4
			// (set) Token: 0x06009BBA RID: 39866 RVA: 0x000543A4 File Offset: 0x000525A4
			public unsafe static DLC5_RogueLikePoolViewerPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033A4 RID: 13220
			// (get) Token: 0x06009BBB RID: 39867 RVA: 0x00295ACC File Offset: 0x00293CCC
			// (set) Token: 0x06009BBC RID: 39868 RVA: 0x000543B6 File Offset: 0x000525B6
			public unsafe static Action<UIButtonToggle> __9__74_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__74_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIButtonToggle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__74_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033A5 RID: 13221
			// (get) Token: 0x06009BBD RID: 39869 RVA: 0x00295AF4 File Offset: 0x00293CF4
			// (set) Token: 0x06009BBE RID: 39870 RVA: 0x000543C8 File Offset: 0x000525C8
			public unsafe static Action<Image> __9__74_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__74_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__74_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033A6 RID: 13222
			// (get) Token: 0x06009BBF RID: 39871 RVA: 0x00295B1C File Offset: 0x00293D1C
			// (set) Token: 0x06009BC0 RID: 39872 RVA: 0x000543DA File Offset: 0x000525DA
			public unsafe static Action<Image> __9__74_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__74_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__74_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033A7 RID: 13223
			// (get) Token: 0x06009BC1 RID: 39873 RVA: 0x00295B44 File Offset: 0x00293D44
			// (set) Token: 0x06009BC2 RID: 39874 RVA: 0x000543EC File Offset: 0x000525EC
			public unsafe static Action<Image> __9__74_20
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__74_20, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__74_20, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033A8 RID: 13224
			// (get) Token: 0x06009BC3 RID: 39875 RVA: 0x00295B6C File Offset: 0x00293D6C
			// (set) Token: 0x06009BC4 RID: 39876 RVA: 0x000543FE File Offset: 0x000525FE
			public unsafe static Func<KeyValuePair<int, int>, bool> __9__75_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033A9 RID: 13225
			// (get) Token: 0x06009BC5 RID: 39877 RVA: 0x00295B94 File Offset: 0x00293D94
			// (set) Token: 0x06009BC6 RID: 39878 RVA: 0x00054410 File Offset: 0x00052610
			public unsafe static Func<KeyValuePair<int, int>, int> __9__75_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033AA RID: 13226
			// (get) Token: 0x06009BC7 RID: 39879 RVA: 0x00295BBC File Offset: 0x00293DBC
			// (set) Token: 0x06009BC8 RID: 39880 RVA: 0x00054422 File Offset: 0x00052622
			public unsafe static Func<KeyValuePair<int, int>, int> __9__75_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033AB RID: 13227
			// (get) Token: 0x06009BC9 RID: 39881 RVA: 0x00295BE4 File Offset: 0x00293DE4
			// (set) Token: 0x06009BCA RID: 39882 RVA: 0x00054434 File Offset: 0x00052634
			public unsafe static Func<KeyValuePair<int, int>, bool> __9__75_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033AC RID: 13228
			// (get) Token: 0x06009BCB RID: 39883 RVA: 0x00295C0C File Offset: 0x00293E0C
			// (set) Token: 0x06009BCC RID: 39884 RVA: 0x00054446 File Offset: 0x00052646
			public unsafe static Func<KeyValuePair<int, int>, int> __9__75_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033AD RID: 13229
			// (get) Token: 0x06009BCD RID: 39885 RVA: 0x00295C34 File Offset: 0x00293E34
			// (set) Token: 0x06009BCE RID: 39886 RVA: 0x00054458 File Offset: 0x00052658
			public unsafe static Func<KeyValuePair<int, int>, int> __9__75_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__75_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033AE RID: 13230
			// (get) Token: 0x06009BCF RID: 39887 RVA: 0x00295C5C File Offset: 0x00293E5C
			// (set) Token: 0x06009BD0 RID: 39888 RVA: 0x0005446A File Offset: 0x0005266A
			public unsafe static Action<RectTransform> __9__76_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__76_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RectTransform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__76_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033AF RID: 13231
			// (get) Token: 0x06009BD1 RID: 39889 RVA: 0x00295C84 File Offset: 0x00293E84
			// (set) Token: 0x06009BD2 RID: 39890 RVA: 0x0005447C File Offset: 0x0005267C
			public unsafe static Action<RectTransform> __9__76_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__76_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RectTransform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__76_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033B0 RID: 13232
			// (get) Token: 0x06009BD3 RID: 39891 RVA: 0x00295CAC File Offset: 0x00293EAC
			// (set) Token: 0x06009BD4 RID: 39892 RVA: 0x0005448E File Offset: 0x0005268E
			public unsafe static Predicate<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair> __9__77_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__77_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__77_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033B1 RID: 13233
			// (get) Token: 0x06009BD5 RID: 39893 RVA: 0x00295CD4 File Offset: 0x00293ED4
			// (set) Token: 0x06009BD6 RID: 39894 RVA: 0x000544A0 File Offset: 0x000526A0
			public unsafe static Func<KeyValuePair<RogueLikePersistentCardInstance, int>, int> __9__79_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__79_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<RogueLikePersistentCardInstance, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikePoolViewerPanel.__c.NativeFieldInfoPtr___9__79_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400652D RID: 25901
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400652E RID: 25902
			private static readonly IntPtr NativeFieldInfoPtr___9__74_1;

			// Token: 0x0400652F RID: 25903
			private static readonly IntPtr NativeFieldInfoPtr___9__74_11;

			// Token: 0x04006530 RID: 25904
			private static readonly IntPtr NativeFieldInfoPtr___9__74_14;

			// Token: 0x04006531 RID: 25905
			private static readonly IntPtr NativeFieldInfoPtr___9__74_20;

			// Token: 0x04006532 RID: 25906
			private static readonly IntPtr NativeFieldInfoPtr___9__75_0;

			// Token: 0x04006533 RID: 25907
			private static readonly IntPtr NativeFieldInfoPtr___9__75_1;

			// Token: 0x04006534 RID: 25908
			private static readonly IntPtr NativeFieldInfoPtr___9__75_2;

			// Token: 0x04006535 RID: 25909
			private static readonly IntPtr NativeFieldInfoPtr___9__75_3;

			// Token: 0x04006536 RID: 25910
			private static readonly IntPtr NativeFieldInfoPtr___9__75_4;

			// Token: 0x04006537 RID: 25911
			private static readonly IntPtr NativeFieldInfoPtr___9__75_5;

			// Token: 0x04006538 RID: 25912
			private static readonly IntPtr NativeFieldInfoPtr___9__76_3;

			// Token: 0x04006539 RID: 25913
			private static readonly IntPtr NativeFieldInfoPtr___9__76_4;

			// Token: 0x0400653A RID: 25914
			private static readonly IntPtr NativeFieldInfoPtr___9__77_0;

			// Token: 0x0400653B RID: 25915
			private static readonly IntPtr NativeFieldInfoPtr___9__79_0;

			// Token: 0x0400653C RID: 25916
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400653D RID: 25917
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__74_1_Internal_Void_UIButtonToggle_0;

			// Token: 0x0400653E RID: 25918
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__74_11_Internal_Void_Image_0;

			// Token: 0x0400653F RID: 25919
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__74_14_Internal_Void_Image_0;

			// Token: 0x04006540 RID: 25920
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__74_20_Internal_Void_Image_0;

			// Token: 0x04006541 RID: 25921
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__75_0_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006542 RID: 25922
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__75_1_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006543 RID: 25923
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__75_2_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006544 RID: 25924
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__75_3_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006545 RID: 25925
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__75_4_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006546 RID: 25926
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__75_5_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04006547 RID: 25927
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCardElement_b__76_3_Internal_Void_RectTransform_0;

			// Token: 0x04006548 RID: 25928
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCardElement_b__76_4_Internal_Void_RectTransform_0;

			// Token: 0x04006549 RID: 25929
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentViewer_b__77_0_Internal_Boolean_RogueLikeCardInstancePair_0;

			// Token: 0x0400654A RID: 25930
			private static readonly IntPtr NativeMethodInfoPtr__InitCard_b__79_0_Internal_Int32_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;
		}

		// Token: 0x02000700 RID: 1792
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePoolViewerPanel+<>c__DisplayClass76_0")]
		public sealed class __c__DisplayClass76_0 : Il2CppSystem.Object
		{
			// Token: 0x06009BD7 RID: 39895 RVA: 0x00295CFC File Offset: 0x00293EFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass76_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "<>c__DisplayClass76_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_0>.NativeClassPtr);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_0.NativeFieldInfoPtr_cardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_0>.NativeClassPtr, "cardType");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_0>.NativeClassPtr, 100668828);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__UpdateCardElement_b__1_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_0>.NativeClassPtr, 100668829);
			}

			// Token: 0x06009BD8 RID: 39896 RVA: 0x00295D64 File Offset: 0x00293F64
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass76_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BD9 RID: 39897 RVA: 0x00295DA0 File Offset: 0x00293FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76439, XrefRangeEnd = 76440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateCardElement_b__1(KeyValuePair<RogueLikePersistentCardInstance, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__UpdateCardElement_b__1_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009BDA RID: 39898 RVA: 0x000544B2 File Offset: 0x000526B2
			public __c__DisplayClass76_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033B2 RID: 13234
			// (get) Token: 0x06009BDB RID: 39899 RVA: 0x00295DF4 File Offset: 0x00293FF4
			// (set) Token: 0x06009BDC RID: 39900 RVA: 0x000544BB File Offset: 0x000526BB
			public unsafe RogueLikeCardBase.CardType cardType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_0.NativeFieldInfoPtr_cardType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_0.NativeFieldInfoPtr_cardType)) = value;
				}
			}

			// Token: 0x0400654B RID: 25931
			private static readonly IntPtr NativeFieldInfoPtr_cardType;

			// Token: 0x0400654C RID: 25932
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400654D RID: 25933
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCardElement_b__1_Internal_Boolean_KeyValuePair_2_RogueLikePersistentCardInstance_Int32_0;
		}

		// Token: 0x02000701 RID: 1793
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePoolViewerPanel+<>c__DisplayClass76_1")]
		public sealed class __c__DisplayClass76_1 : Il2CppSystem.Object
		{
			// Token: 0x06009BDD RID: 39901 RVA: 0x00295E1C File Offset: 0x0029401C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass76_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "<>c__DisplayClass76_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1>.NativeClassPtr);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1>.NativeClassPtr, "description");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1>.NativeClassPtr, "value");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1>.NativeClassPtr, 100668830);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1.NativeMethodInfoPtr__UpdateCardElement_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1>.NativeClassPtr, 100668831);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1.NativeMethodInfoPtr__UpdateCardElement_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1>.NativeClassPtr, 100668832);
			}

			// Token: 0x06009BDE RID: 39902 RVA: 0x00295EAC File Offset: 0x002940AC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass76_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BDF RID: 39903 RVA: 0x00295EE8 File Offset: 0x002940E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCardElement_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1.NativeMethodInfoPtr__UpdateCardElement_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BE0 RID: 39904 RVA: 0x00295F2C File Offset: 0x0029412C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCardElement_b__5(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1.NativeMethodInfoPtr__UpdateCardElement_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BE1 RID: 39905 RVA: 0x000544D6 File Offset: 0x000526D6
			public __c__DisplayClass76_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033B3 RID: 13235
			// (get) Token: 0x06009BE2 RID: 39906 RVA: 0x00295F70 File Offset: 0x00294170
			// (set) Token: 0x06009BE3 RID: 39907 RVA: 0x000544DF File Offset: 0x000526DF
			public unsafe string description
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1.NativeFieldInfoPtr_description);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170033B4 RID: 13236
			// (get) Token: 0x06009BE4 RID: 39908 RVA: 0x00295F98 File Offset: 0x00294198
			// (set) Token: 0x06009BE5 RID: 39909 RVA: 0x000544FE File Offset: 0x000526FE
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass76_1.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400654E RID: 25934
			private static readonly IntPtr NativeFieldInfoPtr_description;

			// Token: 0x0400654F RID: 25935
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04006550 RID: 25936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006551 RID: 25937
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCardElement_b__2_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006552 RID: 25938
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCardElement_b__5_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000702 RID: 1794
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePoolViewerPanel+<>c__DisplayClass79_0")]
		public sealed class __c__DisplayClass79_0 : Il2CppSystem.Object
		{
			// Token: 0x06009BE6 RID: 39910 RVA: 0x00295FC0 File Offset: 0x002941C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass79_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "<>c__DisplayClass79_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr_unlockedDangerousCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, "unlockedDangerousCard");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr_lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, "lang");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr_cardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, "cardNum");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr_valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, "valid");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, "<>9__7");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, "<>9__8");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr___9__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, "<>9__9");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, 100668833);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, 100668834);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, 100668835);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, 100668836);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, 100668837);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, 100668838);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, 100668839);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__7_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, 100668840);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__8_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, 100668841);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__9_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr, 100668842);
			}

			// Token: 0x06009BE7 RID: 39911 RVA: 0x00296154 File Offset: 0x00294354
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass79_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BE8 RID: 39912 RVA: 0x00296190 File Offset: 0x00294390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76440, XrefRangeEnd = 76445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitCard_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BE9 RID: 39913 RVA: 0x002961D4 File Offset: 0x002943D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76445, XrefRangeEnd = 76446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitCard_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BEA RID: 39914 RVA: 0x00296218 File Offset: 0x00294418
			[CallerCount(0)]
			public unsafe void _InitCard_b__3(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BEB RID: 39915 RVA: 0x0029625C File Offset: 0x0029445C
			[CallerCount(0)]
			public unsafe void _InitCard_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BEC RID: 39916 RVA: 0x002962A0 File Offset: 0x002944A0
			[CallerCount(0)]
			public unsafe void _InitCard_b__5(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BED RID: 39917 RVA: 0x002962E4 File Offset: 0x002944E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76446, XrefRangeEnd = 76469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitCard_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BEE RID: 39918 RVA: 0x00296318 File Offset: 0x00294518
			[CallerCount(0)]
			public unsafe void _InitCard_b__7(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__7_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BEF RID: 39919 RVA: 0x0029635C File Offset: 0x0029455C
			[CallerCount(0)]
			public unsafe void _InitCard_b__8(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__8_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BF0 RID: 39920 RVA: 0x002963A0 File Offset: 0x002945A0
			[CallerCount(0)]
			public unsafe void _InitCard_b__9(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeMethodInfoPtr__InitCard_b__9_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009BF1 RID: 39921 RVA: 0x0005451D File Offset: 0x0005271D
			public __c__DisplayClass79_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033B5 RID: 13237
			// (get) Token: 0x06009BF2 RID: 39922 RVA: 0x002963E4 File Offset: 0x002945E4
			// (set) Token: 0x06009BF3 RID: 39923 RVA: 0x00054526 File Offset: 0x00052726
			public unsafe bool unlockedDangerousCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr_unlockedDangerousCard);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr_unlockedDangerousCard)) = value;
				}
			}

			// Token: 0x170033B6 RID: 13238
			// (get) Token: 0x06009BF4 RID: 39924 RVA: 0x0029640C File Offset: 0x0029460C
			// (set) Token: 0x06009BF5 RID: 39925 RVA: 0x00054541 File Offset: 0x00052741
			public unsafe Il2CppStringArray lang
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr_lang);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr_lang), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033B7 RID: 13239
			// (get) Token: 0x06009BF6 RID: 39926 RVA: 0x0029643C File Offset: 0x0029463C
			// (set) Token: 0x06009BF7 RID: 39927 RVA: 0x00054560 File Offset: 0x00052760
			public unsafe string cardNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr_cardNum);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr_cardNum), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170033B8 RID: 13240
			// (get) Token: 0x06009BF8 RID: 39928 RVA: 0x00296464 File Offset: 0x00294664
			// (set) Token: 0x06009BF9 RID: 39929 RVA: 0x0005457F File Offset: 0x0005277F
			public unsafe DLC5_RogueLikePoolViewerPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033B9 RID: 13241
			// (get) Token: 0x06009BFA RID: 39930 RVA: 0x00296494 File Offset: 0x00294694
			// (set) Token: 0x06009BFB RID: 39931 RVA: 0x0005459E File Offset: 0x0005279E
			public unsafe UIElementCluster valid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr_valid);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr_valid), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033BA RID: 13242
			// (get) Token: 0x06009BFC RID: 39932 RVA: 0x002964C4 File Offset: 0x002946C4
			// (set) Token: 0x06009BFD RID: 39933 RVA: 0x000545BD File Offset: 0x000527BD
			public unsafe Action<TextMeshProUGUI> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033BB RID: 13243
			// (get) Token: 0x06009BFE RID: 39934 RVA: 0x002964F4 File Offset: 0x002946F4
			// (set) Token: 0x06009BFF RID: 39935 RVA: 0x000545DC File Offset: 0x000527DC
			public unsafe Action<TextMeshProUGUI> __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033BC RID: 13244
			// (get) Token: 0x06009C00 RID: 39936 RVA: 0x00296524 File Offset: 0x00294724
			// (set) Token: 0x06009C01 RID: 39937 RVA: 0x000545FB File Offset: 0x000527FB
			public unsafe Action<TextMeshProUGUI> __9__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr___9__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass79_0.NativeFieldInfoPtr___9__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006553 RID: 25939
			private static readonly IntPtr NativeFieldInfoPtr_unlockedDangerousCard;

			// Token: 0x04006554 RID: 25940
			private static readonly IntPtr NativeFieldInfoPtr_lang;

			// Token: 0x04006555 RID: 25941
			private static readonly IntPtr NativeFieldInfoPtr_cardNum;

			// Token: 0x04006556 RID: 25942
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006557 RID: 25943
			private static readonly IntPtr NativeFieldInfoPtr_valid;

			// Token: 0x04006558 RID: 25944
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x04006559 RID: 25945
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x0400655A RID: 25946
			private static readonly IntPtr NativeFieldInfoPtr___9__9;

			// Token: 0x0400655B RID: 25947
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400655C RID: 25948
			private static readonly IntPtr NativeMethodInfoPtr__InitCard_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400655D RID: 25949
			private static readonly IntPtr NativeMethodInfoPtr__InitCard_b__2_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400655E RID: 25950
			private static readonly IntPtr NativeMethodInfoPtr__InitCard_b__3_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400655F RID: 25951
			private static readonly IntPtr NativeMethodInfoPtr__InitCard_b__4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006560 RID: 25952
			private static readonly IntPtr NativeMethodInfoPtr__InitCard_b__5_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006561 RID: 25953
			private static readonly IntPtr NativeMethodInfoPtr__InitCard_b__6_Internal_Void_0;

			// Token: 0x04006562 RID: 25954
			private static readonly IntPtr NativeMethodInfoPtr__InitCard_b__7_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006563 RID: 25955
			private static readonly IntPtr NativeMethodInfoPtr__InitCard_b__8_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006564 RID: 25956
			private static readonly IntPtr NativeMethodInfoPtr__InitCard_b__9_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000703 RID: 1795
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikePoolViewerPanel+<>c__DisplayClass80_0")]
		public sealed class __c__DisplayClass80_0 : Il2CppSystem.Object
		{
			// Token: 0x06009C02 RID: 39938 RVA: 0x00296554 File Offset: 0x00294754
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass80_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel>.NativeClassPtr, "<>c__DisplayClass80_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0>.NativeClassPtr);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0>.NativeClassPtr, "card");
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0>.NativeClassPtr, 100668843);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeMethodInfoPtr__OnCardBtnSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0>.NativeClassPtr, 100668844);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeMethodInfoPtr__OnCardBtnSelected_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0>.NativeClassPtr, 100668845);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeMethodInfoPtr__OnCardBtnSelected_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0>.NativeClassPtr, 100668846);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeMethodInfoPtr__OnCardBtnSelected_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0>.NativeClassPtr, 100668847);
				DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeMethodInfoPtr__OnCardBtnSelected_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0>.NativeClassPtr, 100668848);
			}

			// Token: 0x06009C03 RID: 39939 RVA: 0x00296620 File Offset: 0x00294820
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass80_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C04 RID: 39940 RVA: 0x0029665C File Offset: 0x0029485C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76469, XrefRangeEnd = 76471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCardBtnSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeMethodInfoPtr__OnCardBtnSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C05 RID: 39941 RVA: 0x00296690 File Offset: 0x00294890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76471, XrefRangeEnd = 76474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCardBtnSelected_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeMethodInfoPtr__OnCardBtnSelected_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C06 RID: 39942 RVA: 0x002966C4 File Offset: 0x002948C4
			[CallerCount(0)]
			public unsafe void _OnCardBtnSelected_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeMethodInfoPtr__OnCardBtnSelected_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C07 RID: 39943 RVA: 0x00296708 File Offset: 0x00294908
			[CallerCount(0)]
			public unsafe void _OnCardBtnSelected_b__3(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeMethodInfoPtr__OnCardBtnSelected_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C08 RID: 39944 RVA: 0x0029674C File Offset: 0x0029494C
			[CallerCount(0)]
			public unsafe void _OnCardBtnSelected_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeMethodInfoPtr__OnCardBtnSelected_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009C09 RID: 39945 RVA: 0x0005461A File Offset: 0x0005281A
			public __c__DisplayClass80_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033BD RID: 13245
			// (get) Token: 0x06009C0A RID: 39946 RVA: 0x00296790 File Offset: 0x00294990
			// (set) Token: 0x06009C0B RID: 39947 RVA: 0x00054623 File Offset: 0x00052823
			public unsafe DLC5_RogueLikePoolViewerPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033BE RID: 13246
			// (get) Token: 0x06009C0C RID: 39948 RVA: 0x002967C0 File Offset: 0x002949C0
			// (set) Token: 0x06009C0D RID: 39949 RVA: 0x00054642 File Offset: 0x00052842
			public unsafe DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair card
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeFieldInfoPtr_card);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePoolViewerPanel.RogueLikeCardInstancePair>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikePoolViewerPanel.__c__DisplayClass80_0.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006565 RID: 25957
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006566 RID: 25958
			private static readonly IntPtr NativeFieldInfoPtr_card;

			// Token: 0x04006567 RID: 25959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006568 RID: 25960
			private static readonly IntPtr NativeMethodInfoPtr__OnCardBtnSelected_b__0_Internal_Void_0;

			// Token: 0x04006569 RID: 25961
			private static readonly IntPtr NativeMethodInfoPtr__OnCardBtnSelected_b__1_Internal_Void_0;

			// Token: 0x0400656A RID: 25962
			private static readonly IntPtr NativeMethodInfoPtr__OnCardBtnSelected_b__2_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400656B RID: 25963
			private static readonly IntPtr NativeMethodInfoPtr__OnCardBtnSelected_b__3_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400656C RID: 25964
			private static readonly IntPtr NativeMethodInfoPtr__OnCardBtnSelected_b__4_Internal_Void_TextMeshProUGUI_0;
		}
	}
}
