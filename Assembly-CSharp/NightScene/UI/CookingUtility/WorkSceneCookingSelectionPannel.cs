using System;
using Common.UI;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace NightScene.UI.CookingUtility
{
	// Token: 0x020001D6 RID: 470
	public class WorkSceneCookingSelectionPannel : UIPanelExtern
	{
		// Token: 0x06003AE8 RID: 15080 RVA: 0x00167538 File Offset: 0x00165738
		// Note: this type is marked as 'beforefieldinit'.
		static WorkSceneCookingSelectionPannel()
		{
			Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.CookingUtility", "WorkSceneCookingSelectionPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr);
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "m_Scheduler");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_cookerVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "cookerVisual");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_cookerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "cookerName");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_describerPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "describerPanel");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_sellableDescriber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "sellableDescriber");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_objectStackParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "objectStackParent");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_objectParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "objectParent");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "scroller");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_scrollerForRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "scrollerForRecipe");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_scrollerForOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "scrollerForOutput");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_wholeIngField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "wholeIngField");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_ingredientField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "ingredientField");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_recipeField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "recipeField");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_selectedField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "selectedField");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_outputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "outputField");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_outputElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "outputElement");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_noTransparentColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "noTransparentColor");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_highLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "highLightColor");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_potOpenSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "potOpenSFX");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_grillOpenSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "grillOpenSFX");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_panOpenSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "panOpenSFX");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_streamerOpenSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "streamerOpenSFX");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_cuttingboardOpenSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "cuttingboardOpenSFX");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Ingredient_MeatInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "m_Ingredient_MeatInstances");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Ingredient_OtherInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "m_Ingredient_OtherInstances");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Ingredient_SeaFoodInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "m_Ingredient_SeaFoodInstances");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Ingredient_VeggiesInsatance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "m_Ingredient_VeggiesInsatance");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_OutputInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "m_OutputInstances");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_RecipeInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "m_RecipeInstances");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_SelectedInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "m_SelectedInstances");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_selectedIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "selectedIngredients");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "_comparer");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_ExtraCostIng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "ExtraCostIng");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_hasImported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "hasImported");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_importedRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "importedRecipe");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_ingAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "ingAlpha");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_IsFreeCook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "IsFreeCook");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_IsQuickCook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "IsQuickCook");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_isSelectingOutputArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "isSelectingOutputArea");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_StaticIngredientsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "m_StaticIngredientsGroup");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_StaticOutputGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "m_StaticOutputGroup");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_StaticRecipeGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "m_StaticRecipeGroup");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_StaticSelectedIngredientsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "m_StaticSelectedIngredientsGroup");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_outputFieldCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "outputFieldCanvasGroup");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_recipeAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "recipeAlpha");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_recipeFieldCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "recipeFieldCanvasGroup");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_selectedFieldCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "selectedFieldCanvasGroup");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "<OpenContext>k__BackingField");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr__CloseContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "<CloseContext>k__BackingField");
			WorkSceneCookingSelectionPannel.NativeFieldInfoPtr__QTEMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "<QTEMultiplier>k__BackingField");
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_PannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674240);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674241);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_get_CloseContext_Public_get_PannelCloseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674242);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_set_CloseContext_Private_set_Void_PannelCloseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674243);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_get_QTEMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674244);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_set_QTEMultiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674245);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_get_CookerParent_Private_get_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674246);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_get_CheckHasIngredients_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674247);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674248);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674249);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_CheckRecipeIsNotLocked_Private_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674250);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674251);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674252);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_UpdateRecipeField_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674253);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_UpdateIngField_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674254);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_UpdateSelectedField_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674255);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_UpdateOutputField_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674256);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_CheckPinned_Private_Static_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674257);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnIngElementEnabled_Private_Void_KeyValuePair_2_Ingredient_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674258);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnIngElementSelected_Private_Void_KeyValuePair_2_Ingredient_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674259);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnRecipeElementEnabled_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674260);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnRecipeElementSelected_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674261);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnSelectedIngredientsSelected_Private_Void_Ingredient_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674262);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnOutputSelected_Private_Void_MatchedCookCombo_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674263);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_UpdateAllVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674264);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_MatchingSelected_Private_Void_List_1_MatchedCookCombo_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674265);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_TryReturnSelectedIngredients_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674266);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674267);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674268);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674269);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674270);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__65_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674271);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__65_3_Private_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674272);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__65_5_Private_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674273);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__65_7_Private_Void_MatchedCookCombo_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674274);
			WorkSceneCookingSelectionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__65_8_Private_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, 100674275);
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06003AE9 RID: 15081 RVA: 0x00167C20 File Offset: 0x00165E20
		// (set) Token: 0x06003AEA RID: 15082 RVA: 0x00167C58 File Offset: 0x00165E58
		public unsafe Nullable<WorkSceneCookingSelectionPannel.PannelOpenContext> OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_PannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<WorkSceneCookingSelectionPannel.PannelOpenContext>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133920, XrefRangeEnd = 133921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06003AEB RID: 15083 RVA: 0x00167CA0 File Offset: 0x00165EA0
		// (set) Token: 0x06003AEC RID: 15084 RVA: 0x00167CDC File Offset: 0x00165EDC
		public unsafe WorkSceneCookingSelectionPannel.PannelCloseType CloseContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_get_CloseContext_Public_get_PannelCloseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_set_CloseContext_Private_set_Void_PannelCloseType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06003AED RID: 15085 RVA: 0x00167D1C File Offset: 0x00165F1C
		// (set) Token: 0x06003AEE RID: 15086 RVA: 0x00167D58 File Offset: 0x00165F58
		public unsafe float QTEMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_get_QTEMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_set_QTEMultiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06003AEF RID: 15087 RVA: 0x00167D98 File Offset: 0x00165F98
		public unsafe CookController CookerParent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 133924, RefRangeEnd = 133925, XrefRangeStart = 133921, XrefRangeEnd = 133924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_get_CookerParent_Private_get_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr3) : null;
			}
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x00167DD8 File Offset: 0x00165FD8
		public unsafe bool CheckHasIngredients
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133925, XrefRangeEnd = 133926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_get_CheckHasIngredients_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x00167E14 File Offset: 0x00166014
		[CallerCount(0)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x00167E50 File Offset: 0x00166050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133926, XrefRangeEnd = 134135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AF3 RID: 15091 RVA: 0x00167E8C File Offset: 0x0016608C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134135, XrefRangeEnd = 134142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckRecipeIsNotLocked(Recipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_CheckRecipeIsNotLocked_Private_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x00167EDC File Offset: 0x001660DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134142, XrefRangeEnd = 134234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x00167F18 File Offset: 0x00166118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134234, XrefRangeEnd = 134253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x00167F54 File Offset: 0x00166154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134301, RefRangeEnd = 134302, XrefRangeStart = 134253, XrefRangeEnd = 134301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRecipeField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_UpdateRecipeField_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x00167F88 File Offset: 0x00166188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134302, XrefRangeEnd = 134306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIngField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_UpdateIngField_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x00167FBC File Offset: 0x001661BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134306, XrefRangeEnd = 134330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelectedField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_UpdateSelectedField_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x00167FF0 File Offset: 0x001661F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134358, RefRangeEnd = 134359, XrefRangeStart = 134330, XrefRangeEnd = 134358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOutputField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_UpdateOutputField_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x00168024 File Offset: 0x00166224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134359, XrefRangeEnd = 134375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckPinned(Ingredient ingredient)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredient);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_CheckPinned_Private_Static_Boolean_Ingredient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x00168068 File Offset: 0x00166268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134375, XrefRangeEnd = 134429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnIngElementEnabled(KeyValuePair<Ingredient, int> objectBase, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(objectBase));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnIngElementEnabled_Private_Void_KeyValuePair_2_Ingredient_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x001680D4 File Offset: 0x001662D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134429, XrefRangeEnd = 134458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnIngElementSelected(KeyValuePair<Ingredient, int> value, UIElementCluster uiElementCluster, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnIngElementSelected_Private_Void_KeyValuePair_2_Ingredient_Int32_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x00168140 File Offset: 0x00166340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134458, XrefRangeEnd = 134514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRecipeElementEnabled(Recipe recipe, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnRecipeElementEnabled_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x001681A8 File Offset: 0x001663A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134514, XrefRangeEnd = 134537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRecipeElementSelected(Recipe recipe, UIElementCluster uiElementCluster, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnRecipeElementSelected_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x00168210 File Offset: 0x00166410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134537, XrefRangeEnd = 134560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelectedIngredientsSelected(Ingredient ingredient, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredient);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnSelectedIngredientsSelected_Private_Void_Ingredient_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x00168278 File Offset: 0x00166478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134560, XrefRangeEnd = 134599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOutputSelected(WorkSceneCookingSelectionPannel.MatchedCookCombo solved, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(solved);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnOutputSelected_Private_Void_MatchedCookCombo_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x001682E0 File Offset: 0x001664E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 134647, RefRangeEnd = 134651, XrefRangeStart = 134599, XrefRangeEnd = 134647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAllVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_UpdateAllVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x00168314 File Offset: 0x00166514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134751, RefRangeEnd = 134752, XrefRangeStart = 134651, XrefRangeEnd = 134751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MatchingSelected(List<WorkSceneCookingSelectionPannel.MatchedCookCombo> matchedCookCombos, out bool haveUnObtainedCombo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchedCookCombos);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &haveUnObtainedCombo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_MatchingSelected_Private_Void_List_1_MatchedCookCombo_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x00168364 File Offset: 0x00166564
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134775, RefRangeEnd = 134777, XrefRangeStart = 134752, XrefRangeEnd = 134775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryReturnSelectedIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_TryReturnSelectedIngredients_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00168398 File Offset: 0x00166598
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x001683D4 File Offset: 0x001665D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134777, XrefRangeEnd = 134829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x00168410 File Offset: 0x00166610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134829, XrefRangeEnd = 134881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSceneCookingSelectionPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x0016844C File Offset: 0x0016664C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Common_UI_IExternalPanel_CloseExternPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x00168480 File Offset: 0x00166680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134881, XrefRangeEnd = 134918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__65_0(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__65_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x001684C8 File Offset: 0x001666C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134918, XrefRangeEnd = 134924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__65_3(int column, MoveDirection overrideMove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref column;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideMove;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__65_3_Private_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x00168514 File Offset: 0x00166714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134924, XrefRangeEnd = 134931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__65_5(int column, MoveDirection overrideMove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref column;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideMove;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__65_5_Private_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x00168560 File Offset: 0x00166760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134931, XrefRangeEnd = 135042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__65_7(WorkSceneCookingSelectionPannel.MatchedCookCombo solved, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(solved);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__65_7_Private_Void_MatchedCookCombo_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x001685C8 File Offset: 0x001667C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135042, XrefRangeEnd = 135048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__65_8(int column, MoveDirection overrideMove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref column;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideMove;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.NativeMethodInfoPtr__OnPanelInitialize_b__65_8_Private_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x00020FBE File Offset: 0x0001F1BE
		public WorkSceneCookingSelectionPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x06003B0E RID: 15118 RVA: 0x00168614 File Offset: 0x00166814
		// (set) Token: 0x06003B0F RID: 15119 RVA: 0x00020FC7 File Offset: 0x0001F1C7
		public unsafe ActionExecutionScheduler m_Scheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Scheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Scheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x06003B10 RID: 15120 RVA: 0x00168644 File Offset: 0x00166844
		// (set) Token: 0x06003B11 RID: 15121 RVA: 0x00020FE6 File Offset: 0x0001F1E6
		public unsafe Image cookerVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_cookerVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_cookerVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06003B12 RID: 15122 RVA: 0x00168674 File Offset: 0x00166874
		// (set) Token: 0x06003B13 RID: 15123 RVA: 0x00021005 File Offset: 0x0001F205
		public unsafe TextMeshProUGUI cookerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_cookerName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_cookerName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06003B14 RID: 15124 RVA: 0x001686A4 File Offset: 0x001668A4
		// (set) Token: 0x06003B15 RID: 15125 RVA: 0x00021024 File Offset: 0x0001F224
		public unsafe CanvasGroup describerPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_describerPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_describerPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06003B16 RID: 15126 RVA: 0x001686D4 File Offset: 0x001668D4
		// (set) Token: 0x06003B17 RID: 15127 RVA: 0x00021043 File Offset: 0x0001F243
		public unsafe SellableDescriber sellableDescriber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_sellableDescriber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_sellableDescriber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06003B18 RID: 15128 RVA: 0x00168704 File Offset: 0x00166904
		// (set) Token: 0x06003B19 RID: 15129 RVA: 0x00021062 File Offset: 0x0001F262
		public unsafe GameObject objectStackParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_objectStackParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_objectStackParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06003B1A RID: 15130 RVA: 0x00168734 File Offset: 0x00166934
		// (set) Token: 0x06003B1B RID: 15131 RVA: 0x00021081 File Offset: 0x0001F281
		public unsafe GameObject objectParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_objectParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_objectParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x06003B1C RID: 15132 RVA: 0x00168764 File Offset: 0x00166964
		// (set) Token: 0x06003B1D RID: 15133 RVA: 0x000210A0 File Offset: 0x0001F2A0
		public unsafe AdpProgressIndicatorComponent scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06003B1E RID: 15134 RVA: 0x00168794 File Offset: 0x00166994
		// (set) Token: 0x06003B1F RID: 15135 RVA: 0x000210BF File Offset: 0x0001F2BF
		public unsafe AdpProgressIndicatorComponent scrollerForRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_scrollerForRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_scrollerForRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06003B20 RID: 15136 RVA: 0x001687C4 File Offset: 0x001669C4
		// (set) Token: 0x06003B21 RID: 15137 RVA: 0x000210DE File Offset: 0x0001F2DE
		public unsafe AdpProgressIndicatorComponent scrollerForOutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_scrollerForOutput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_scrollerForOutput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06003B22 RID: 15138 RVA: 0x001687F4 File Offset: 0x001669F4
		// (set) Token: 0x06003B23 RID: 15139 RVA: 0x000210FD File Offset: 0x0001F2FD
		public unsafe CanvasGroup wholeIngField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_wholeIngField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_wholeIngField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x00168824 File Offset: 0x00166A24
		// (set) Token: 0x06003B25 RID: 15141 RVA: 0x0002111C File Offset: 0x0001F31C
		public unsafe GridLayoutGroup ingredientField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_ingredientField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_ingredientField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06003B26 RID: 15142 RVA: 0x00168854 File Offset: 0x00166A54
		// (set) Token: 0x06003B27 RID: 15143 RVA: 0x0002113B File Offset: 0x0001F33B
		public unsafe GridLayoutGroup recipeField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_recipeField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_recipeField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x06003B28 RID: 15144 RVA: 0x00168884 File Offset: 0x00166A84
		// (set) Token: 0x06003B29 RID: 15145 RVA: 0x0002115A File Offset: 0x0001F35A
		public unsafe GridLayoutGroup selectedField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_selectedField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_selectedField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x06003B2A RID: 15146 RVA: 0x001688B4 File Offset: 0x00166AB4
		// (set) Token: 0x06003B2B RID: 15147 RVA: 0x00021179 File Offset: 0x0001F379
		public unsafe GridLayoutGroup outputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_outputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_outputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x06003B2C RID: 15148 RVA: 0x001688E4 File Offset: 0x00166AE4
		// (set) Token: 0x06003B2D RID: 15149 RVA: 0x00021198 File Offset: 0x0001F398
		public unsafe GameObject outputElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_outputElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_outputElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x06003B2E RID: 15150 RVA: 0x00168914 File Offset: 0x00166B14
		// (set) Token: 0x06003B2F RID: 15151 RVA: 0x000211B7 File Offset: 0x0001F3B7
		public unsafe Color noTransparentColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_noTransparentColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_noTransparentColor)) = value;
			}
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x06003B30 RID: 15152 RVA: 0x0016893C File Offset: 0x00166B3C
		// (set) Token: 0x06003B31 RID: 15153 RVA: 0x000211D2 File Offset: 0x0001F3D2
		public unsafe Color highLightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_highLightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_highLightColor)) = value;
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06003B32 RID: 15154 RVA: 0x00168964 File Offset: 0x00166B64
		// (set) Token: 0x06003B33 RID: 15155 RVA: 0x000211ED File Offset: 0x0001F3ED
		public unsafe AudioClip potOpenSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_potOpenSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_potOpenSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x06003B34 RID: 15156 RVA: 0x00168994 File Offset: 0x00166B94
		// (set) Token: 0x06003B35 RID: 15157 RVA: 0x0002120C File Offset: 0x0001F40C
		public unsafe AudioClip grillOpenSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_grillOpenSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_grillOpenSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x06003B36 RID: 15158 RVA: 0x001689C4 File Offset: 0x00166BC4
		// (set) Token: 0x06003B37 RID: 15159 RVA: 0x0002122B File Offset: 0x0001F42B
		public unsafe AudioClip panOpenSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_panOpenSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_panOpenSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x06003B38 RID: 15160 RVA: 0x001689F4 File Offset: 0x00166BF4
		// (set) Token: 0x06003B39 RID: 15161 RVA: 0x0002124A File Offset: 0x0001F44A
		public unsafe AudioClip streamerOpenSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_streamerOpenSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_streamerOpenSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x06003B3A RID: 15162 RVA: 0x00168A24 File Offset: 0x00166C24
		// (set) Token: 0x06003B3B RID: 15163 RVA: 0x00021269 File Offset: 0x0001F469
		public unsafe AudioClip cuttingboardOpenSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_cuttingboardOpenSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_cuttingboardOpenSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x00168A54 File Offset: 0x00166C54
		// (set) Token: 0x06003B3D RID: 15165 RVA: 0x00021288 File Offset: 0x0001F488
		public unsafe List<KeyValuePair<Ingredient, int>> m_Ingredient_MeatInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Ingredient_MeatInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Ingredient, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Ingredient_MeatInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06003B3E RID: 15166 RVA: 0x00168A84 File Offset: 0x00166C84
		// (set) Token: 0x06003B3F RID: 15167 RVA: 0x000212A7 File Offset: 0x0001F4A7
		public unsafe List<KeyValuePair<Ingredient, int>> m_Ingredient_OtherInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Ingredient_OtherInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Ingredient, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Ingredient_OtherInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06003B40 RID: 15168 RVA: 0x00168AB4 File Offset: 0x00166CB4
		// (set) Token: 0x06003B41 RID: 15169 RVA: 0x000212C6 File Offset: 0x0001F4C6
		public unsafe List<KeyValuePair<Ingredient, int>> m_Ingredient_SeaFoodInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Ingredient_SeaFoodInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Ingredient, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Ingredient_SeaFoodInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06003B42 RID: 15170 RVA: 0x00168AE4 File Offset: 0x00166CE4
		// (set) Token: 0x06003B43 RID: 15171 RVA: 0x000212E5 File Offset: 0x0001F4E5
		public unsafe List<KeyValuePair<Ingredient, int>> m_Ingredient_VeggiesInsatance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Ingredient_VeggiesInsatance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Ingredient, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_Ingredient_VeggiesInsatance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06003B44 RID: 15172 RVA: 0x00168B14 File Offset: 0x00166D14
		// (set) Token: 0x06003B45 RID: 15173 RVA: 0x00021304 File Offset: 0x0001F504
		public unsafe List<WorkSceneCookingSelectionPannel.MatchedCookCombo> m_OutputInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_OutputInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorkSceneCookingSelectionPannel.MatchedCookCombo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_OutputInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06003B46 RID: 15174 RVA: 0x00168B44 File Offset: 0x00166D44
		// (set) Token: 0x06003B47 RID: 15175 RVA: 0x00021323 File Offset: 0x0001F523
		public unsafe List<Recipe> m_RecipeInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_RecipeInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_RecipeInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x00168B74 File Offset: 0x00166D74
		// (set) Token: 0x06003B49 RID: 15177 RVA: 0x00021342 File Offset: 0x0001F542
		public unsafe List<Ingredient> m_SelectedInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_SelectedInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Ingredient>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_SelectedInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06003B4A RID: 15178 RVA: 0x00168BA4 File Offset: 0x00166DA4
		// (set) Token: 0x06003B4B RID: 15179 RVA: 0x00021361 File Offset: 0x0001F561
		public unsafe List<int> selectedIngredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_selectedIngredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_selectedIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06003B4C RID: 15180 RVA: 0x00168BD4 File Offset: 0x00166DD4
		// (set) Token: 0x06003B4D RID: 15181 RVA: 0x00021380 File Offset: 0x0001F580
		public unsafe Comparer<bool> _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparer<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x06003B4E RID: 15182 RVA: 0x00168C04 File Offset: 0x00166E04
		// (set) Token: 0x06003B4F RID: 15183 RVA: 0x0002139F File Offset: 0x0001F59F
		public unsafe int ExtraCostIng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_ExtraCostIng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_ExtraCostIng)) = value;
			}
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x06003B50 RID: 15184 RVA: 0x00168C2C File Offset: 0x00166E2C
		// (set) Token: 0x06003B51 RID: 15185 RVA: 0x000213BA File Offset: 0x0001F5BA
		public unsafe bool hasImported
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_hasImported);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_hasImported)) = value;
			}
		}

		// Token: 0x17001465 RID: 5221
		// (get) Token: 0x06003B52 RID: 15186 RVA: 0x00168C54 File Offset: 0x00166E54
		// (set) Token: 0x06003B53 RID: 15187 RVA: 0x000213D5 File Offset: 0x0001F5D5
		public unsafe Recipe importedRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_importedRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_importedRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06003B54 RID: 15188 RVA: 0x00168C84 File Offset: 0x00166E84
		// (set) Token: 0x06003B55 RID: 15189 RVA: 0x000213F4 File Offset: 0x0001F5F4
		public unsafe float ingAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_ingAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_ingAlpha)) = value;
			}
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x06003B56 RID: 15190 RVA: 0x00168CAC File Offset: 0x00166EAC
		// (set) Token: 0x06003B57 RID: 15191 RVA: 0x0002140F File Offset: 0x0001F60F
		public unsafe bool IsFreeCook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_IsFreeCook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_IsFreeCook)) = value;
			}
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x06003B58 RID: 15192 RVA: 0x00168CD4 File Offset: 0x00166ED4
		// (set) Token: 0x06003B59 RID: 15193 RVA: 0x0002142A File Offset: 0x0001F62A
		public unsafe bool IsQuickCook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_IsQuickCook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_IsQuickCook)) = value;
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x06003B5A RID: 15194 RVA: 0x00168CFC File Offset: 0x00166EFC
		// (set) Token: 0x06003B5B RID: 15195 RVA: 0x00021445 File Offset: 0x0001F645
		public unsafe bool isSelectingOutputArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_isSelectingOutputArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_isSelectingOutputArea)) = value;
			}
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06003B5C RID: 15196 RVA: 0x00168D24 File Offset: 0x00166F24
		// (set) Token: 0x06003B5D RID: 15197 RVA: 0x00021460 File Offset: 0x0001F660
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Ingredient, int>, UIElementCluster, UIButtonSimple> m_StaticIngredientsGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_StaticIngredientsGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Ingredient, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_StaticIngredientsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06003B5E RID: 15198 RVA: 0x00168D54 File Offset: 0x00166F54
		// (set) Token: 0x06003B5F RID: 15199 RVA: 0x0002147F File Offset: 0x0001F67F
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<WorkSceneCookingSelectionPannel.MatchedCookCombo, UIElementCluster, UIButtonSimple> m_StaticOutputGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_StaticOutputGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<WorkSceneCookingSelectionPannel.MatchedCookCombo, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_StaticOutputGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x06003B60 RID: 15200 RVA: 0x00168D84 File Offset: 0x00166F84
		// (set) Token: 0x06003B61 RID: 15201 RVA: 0x0002149E File Offset: 0x0001F69E
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple> m_StaticRecipeGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_StaticRecipeGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_StaticRecipeGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06003B62 RID: 15202 RVA: 0x00168DB4 File Offset: 0x00166FB4
		// (set) Token: 0x06003B63 RID: 15203 RVA: 0x000214BD File Offset: 0x0001F6BD
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Ingredient, UIElementCluster, UIButtonSimple> m_StaticSelectedIngredientsGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_StaticSelectedIngredientsGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Ingredient, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_m_StaticSelectedIngredientsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x06003B64 RID: 15204 RVA: 0x00168DE4 File Offset: 0x00166FE4
		// (set) Token: 0x06003B65 RID: 15205 RVA: 0x000214DC File Offset: 0x0001F6DC
		public unsafe CanvasGroup outputFieldCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_outputFieldCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_outputFieldCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x06003B66 RID: 15206 RVA: 0x00168E14 File Offset: 0x00167014
		// (set) Token: 0x06003B67 RID: 15207 RVA: 0x000214FB File Offset: 0x0001F6FB
		public unsafe float recipeAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_recipeAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_recipeAlpha)) = value;
			}
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x06003B68 RID: 15208 RVA: 0x00168E3C File Offset: 0x0016703C
		// (set) Token: 0x06003B69 RID: 15209 RVA: 0x00021516 File Offset: 0x0001F716
		public unsafe CanvasGroup recipeFieldCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_recipeFieldCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_recipeFieldCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06003B6A RID: 15210 RVA: 0x00168E6C File Offset: 0x0016706C
		// (set) Token: 0x06003B6B RID: 15211 RVA: 0x00021535 File Offset: 0x0001F735
		public unsafe CanvasGroup selectedFieldCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_selectedFieldCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr_selectedFieldCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06003B6C RID: 15212 RVA: 0x00168E9C File Offset: 0x0016709C
		// (set) Token: 0x06003B6D RID: 15213 RVA: 0x00021554 File Offset: 0x0001F754
		public Nullable<WorkSceneCookingSelectionPannel.PannelOpenContext> _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new Nullable<WorkSceneCookingSelectionPannel.PannelOpenContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<WorkSceneCookingSelectionPannel.PannelOpenContext>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<WorkSceneCookingSelectionPannel.PannelOpenContext>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06003B6E RID: 15214 RVA: 0x00168ECC File Offset: 0x001670CC
		// (set) Token: 0x06003B6F RID: 15215 RVA: 0x00021582 File Offset: 0x0001F782
		public unsafe WorkSceneCookingSelectionPannel.PannelCloseType _CloseContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr__CloseContext_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr__CloseContext_k__BackingField)) = value;
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06003B70 RID: 15216 RVA: 0x00168EF4 File Offset: 0x001670F4
		// (set) Token: 0x06003B71 RID: 15217 RVA: 0x0002159D File Offset: 0x0001F79D
		public unsafe float _QTEMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr__QTEMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.NativeFieldInfoPtr__QTEMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x0400279B RID: 10139
		private static readonly IntPtr NativeFieldInfoPtr_m_Scheduler;

		// Token: 0x0400279C RID: 10140
		private static readonly IntPtr NativeFieldInfoPtr_cookerVisual;

		// Token: 0x0400279D RID: 10141
		private static readonly IntPtr NativeFieldInfoPtr_cookerName;

		// Token: 0x0400279E RID: 10142
		private static readonly IntPtr NativeFieldInfoPtr_describerPanel;

		// Token: 0x0400279F RID: 10143
		private static readonly IntPtr NativeFieldInfoPtr_sellableDescriber;

		// Token: 0x040027A0 RID: 10144
		private static readonly IntPtr NativeFieldInfoPtr_objectStackParent;

		// Token: 0x040027A1 RID: 10145
		private static readonly IntPtr NativeFieldInfoPtr_objectParent;

		// Token: 0x040027A2 RID: 10146
		private static readonly IntPtr NativeFieldInfoPtr_scroller;

		// Token: 0x040027A3 RID: 10147
		private static readonly IntPtr NativeFieldInfoPtr_scrollerForRecipe;

		// Token: 0x040027A4 RID: 10148
		private static readonly IntPtr NativeFieldInfoPtr_scrollerForOutput;

		// Token: 0x040027A5 RID: 10149
		private static readonly IntPtr NativeFieldInfoPtr_wholeIngField;

		// Token: 0x040027A6 RID: 10150
		private static readonly IntPtr NativeFieldInfoPtr_ingredientField;

		// Token: 0x040027A7 RID: 10151
		private static readonly IntPtr NativeFieldInfoPtr_recipeField;

		// Token: 0x040027A8 RID: 10152
		private static readonly IntPtr NativeFieldInfoPtr_selectedField;

		// Token: 0x040027A9 RID: 10153
		private static readonly IntPtr NativeFieldInfoPtr_outputField;

		// Token: 0x040027AA RID: 10154
		private static readonly IntPtr NativeFieldInfoPtr_outputElement;

		// Token: 0x040027AB RID: 10155
		private static readonly IntPtr NativeFieldInfoPtr_noTransparentColor;

		// Token: 0x040027AC RID: 10156
		private static readonly IntPtr NativeFieldInfoPtr_highLightColor;

		// Token: 0x040027AD RID: 10157
		private static readonly IntPtr NativeFieldInfoPtr_potOpenSFX;

		// Token: 0x040027AE RID: 10158
		private static readonly IntPtr NativeFieldInfoPtr_grillOpenSFX;

		// Token: 0x040027AF RID: 10159
		private static readonly IntPtr NativeFieldInfoPtr_panOpenSFX;

		// Token: 0x040027B0 RID: 10160
		private static readonly IntPtr NativeFieldInfoPtr_streamerOpenSFX;

		// Token: 0x040027B1 RID: 10161
		private static readonly IntPtr NativeFieldInfoPtr_cuttingboardOpenSFX;

		// Token: 0x040027B2 RID: 10162
		private static readonly IntPtr NativeFieldInfoPtr_m_Ingredient_MeatInstances;

		// Token: 0x040027B3 RID: 10163
		private static readonly IntPtr NativeFieldInfoPtr_m_Ingredient_OtherInstances;

		// Token: 0x040027B4 RID: 10164
		private static readonly IntPtr NativeFieldInfoPtr_m_Ingredient_SeaFoodInstances;

		// Token: 0x040027B5 RID: 10165
		private static readonly IntPtr NativeFieldInfoPtr_m_Ingredient_VeggiesInsatance;

		// Token: 0x040027B6 RID: 10166
		private static readonly IntPtr NativeFieldInfoPtr_m_OutputInstances;

		// Token: 0x040027B7 RID: 10167
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeInstances;

		// Token: 0x040027B8 RID: 10168
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedInstances;

		// Token: 0x040027B9 RID: 10169
		private static readonly IntPtr NativeFieldInfoPtr_selectedIngredients;

		// Token: 0x040027BA RID: 10170
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x040027BB RID: 10171
		private static readonly IntPtr NativeFieldInfoPtr_ExtraCostIng;

		// Token: 0x040027BC RID: 10172
		private static readonly IntPtr NativeFieldInfoPtr_hasImported;

		// Token: 0x040027BD RID: 10173
		private static readonly IntPtr NativeFieldInfoPtr_importedRecipe;

		// Token: 0x040027BE RID: 10174
		private static readonly IntPtr NativeFieldInfoPtr_ingAlpha;

		// Token: 0x040027BF RID: 10175
		private static readonly IntPtr NativeFieldInfoPtr_IsFreeCook;

		// Token: 0x040027C0 RID: 10176
		private static readonly IntPtr NativeFieldInfoPtr_IsQuickCook;

		// Token: 0x040027C1 RID: 10177
		private static readonly IntPtr NativeFieldInfoPtr_isSelectingOutputArea;

		// Token: 0x040027C2 RID: 10178
		private static readonly IntPtr NativeFieldInfoPtr_m_StaticIngredientsGroup;

		// Token: 0x040027C3 RID: 10179
		private static readonly IntPtr NativeFieldInfoPtr_m_StaticOutputGroup;

		// Token: 0x040027C4 RID: 10180
		private static readonly IntPtr NativeFieldInfoPtr_m_StaticRecipeGroup;

		// Token: 0x040027C5 RID: 10181
		private static readonly IntPtr NativeFieldInfoPtr_m_StaticSelectedIngredientsGroup;

		// Token: 0x040027C6 RID: 10182
		private static readonly IntPtr NativeFieldInfoPtr_outputFieldCanvasGroup;

		// Token: 0x040027C7 RID: 10183
		private static readonly IntPtr NativeFieldInfoPtr_recipeAlpha;

		// Token: 0x040027C8 RID: 10184
		private static readonly IntPtr NativeFieldInfoPtr_recipeFieldCanvasGroup;

		// Token: 0x040027C9 RID: 10185
		private static readonly IntPtr NativeFieldInfoPtr_selectedFieldCanvasGroup;

		// Token: 0x040027CA RID: 10186
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x040027CB RID: 10187
		private static readonly IntPtr NativeFieldInfoPtr__CloseContext_k__BackingField;

		// Token: 0x040027CC RID: 10188
		private static readonly IntPtr NativeFieldInfoPtr__QTEMultiplier_k__BackingField;

		// Token: 0x040027CD RID: 10189
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_PannelOpenContext_0;

		// Token: 0x040027CE RID: 10190
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0;

		// Token: 0x040027CF RID: 10191
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseContext_Public_get_PannelCloseType_0;

		// Token: 0x040027D0 RID: 10192
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseContext_Private_set_Void_PannelCloseType_0;

		// Token: 0x040027D1 RID: 10193
		private static readonly IntPtr NativeMethodInfoPtr_get_QTEMultiplier_Public_get_Single_0;

		// Token: 0x040027D2 RID: 10194
		private static readonly IntPtr NativeMethodInfoPtr_set_QTEMultiplier_Private_set_Void_Single_0;

		// Token: 0x040027D3 RID: 10195
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerParent_Private_get_CookController_0;

		// Token: 0x040027D4 RID: 10196
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckHasIngredients_Private_get_Boolean_0;

		// Token: 0x040027D5 RID: 10197
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x040027D6 RID: 10198
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040027D7 RID: 10199
		private static readonly IntPtr NativeMethodInfoPtr_CheckRecipeIsNotLocked_Private_Boolean_Recipe_0;

		// Token: 0x040027D8 RID: 10200
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040027D9 RID: 10201
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040027DA RID: 10202
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRecipeField_Private_Void_0;

		// Token: 0x040027DB RID: 10203
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIngField_Private_Void_0;

		// Token: 0x040027DC RID: 10204
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectedField_Private_Void_0;

		// Token: 0x040027DD RID: 10205
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOutputField_Private_Void_0;

		// Token: 0x040027DE RID: 10206
		private static readonly IntPtr NativeMethodInfoPtr_CheckPinned_Private_Static_Boolean_Ingredient_0;

		// Token: 0x040027DF RID: 10207
		private static readonly IntPtr NativeMethodInfoPtr_OnIngElementEnabled_Private_Void_KeyValuePair_2_Ingredient_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040027E0 RID: 10208
		private static readonly IntPtr NativeMethodInfoPtr_OnIngElementSelected_Private_Void_KeyValuePair_2_Ingredient_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040027E1 RID: 10209
		private static readonly IntPtr NativeMethodInfoPtr_OnRecipeElementEnabled_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040027E2 RID: 10210
		private static readonly IntPtr NativeMethodInfoPtr_OnRecipeElementSelected_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040027E3 RID: 10211
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectedIngredientsSelected_Private_Void_Ingredient_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040027E4 RID: 10212
		private static readonly IntPtr NativeMethodInfoPtr_OnOutputSelected_Private_Void_MatchedCookCombo_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040027E5 RID: 10213
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAllVisual_Private_Void_0;

		// Token: 0x040027E6 RID: 10214
		private static readonly IntPtr NativeMethodInfoPtr_MatchingSelected_Private_Void_List_1_MatchedCookCombo_byref_Boolean_0;

		// Token: 0x040027E7 RID: 10215
		private static readonly IntPtr NativeMethodInfoPtr_TryReturnSelectedIngredients_Private_Void_0;

		// Token: 0x040027E8 RID: 10216
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x040027E9 RID: 10217
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040027EA RID: 10218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040027EB RID: 10219
		private static readonly IntPtr NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0;

		// Token: 0x040027EC RID: 10220
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_0_Private_Void_CallbackContext_0;

		// Token: 0x040027ED RID: 10221
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_3_Private_Void_Int32_MoveDirection_0;

		// Token: 0x040027EE RID: 10222
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_5_Private_Void_Int32_MoveDirection_0;

		// Token: 0x040027EF RID: 10223
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_7_Private_Void_MatchedCookCombo_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040027F0 RID: 10224
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_8_Private_Void_Int32_MoveDirection_0;

		// Token: 0x02000961 RID: 2401
		public enum PannelCloseType
		{
			// Token: 0x040078D0 RID: 30928
			DoNothing,
			// Token: 0x040078D1 RID: 30929
			RequireGotoQTEPanel
		}

		// Token: 0x02000962 RID: 2402
		public sealed class PannelOpenContext : ValueType
		{
			// Token: 0x0600BAFC RID: 47868 RVA: 0x002F1B3C File Offset: 0x002EFD3C
			// Note: this type is marked as 'beforefieldinit'.
			static PannelOpenContext()
			{
				Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.PannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "PannelOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.PannelOpenContext>.NativeClassPtr);
				WorkSceneCookingSelectionPannel.PannelOpenContext.NativeFieldInfoPtr_CookController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.PannelOpenContext>.NativeClassPtr, "CookController");
				WorkSceneCookingSelectionPannel.PannelOpenContext.NativeFieldInfoPtr_IngredientAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.PannelOpenContext>.NativeClassPtr, "IngredientAlpha");
				WorkSceneCookingSelectionPannel.PannelOpenContext.NativeFieldInfoPtr_RecipeAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.PannelOpenContext>.NativeClassPtr, "RecipeAlpha");
				WorkSceneCookingSelectionPannel.PannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_CookController_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.PannelOpenContext>.NativeClassPtr, 100674276);
			}

			// Token: 0x0600BAFD RID: 47869 RVA: 0x002F1BB8 File Offset: 0x002EFDB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 133592, RefRangeEnd = 133593, XrefRangeStart = 133591, XrefRangeEnd = 133592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PannelOpenContext(CookController cookController, float ingredientAlpha, float recipeAlpha) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.PannelOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookController);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientAlpha;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeAlpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.PannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_CookController_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAFE RID: 47870 RVA: 0x00064E0A File Offset: 0x0006300A
			public PannelOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BAFF RID: 47871 RVA: 0x00064E13 File Offset: 0x00063013
			public PannelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.PannelOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x17003D30 RID: 15664
			// (get) Token: 0x0600BB00 RID: 47872 RVA: 0x002F1C24 File Offset: 0x002EFE24
			// (set) Token: 0x0600BB01 RID: 47873 RVA: 0x00064E25 File Offset: 0x00063025
			public unsafe CookController CookController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.PannelOpenContext.NativeFieldInfoPtr_CookController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.PannelOpenContext.NativeFieldInfoPtr_CookController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D31 RID: 15665
			// (get) Token: 0x0600BB02 RID: 47874 RVA: 0x002F1C54 File Offset: 0x002EFE54
			// (set) Token: 0x0600BB03 RID: 47875 RVA: 0x00064E44 File Offset: 0x00063044
			public unsafe float IngredientAlpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.PannelOpenContext.NativeFieldInfoPtr_IngredientAlpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.PannelOpenContext.NativeFieldInfoPtr_IngredientAlpha)) = value;
				}
			}

			// Token: 0x17003D32 RID: 15666
			// (get) Token: 0x0600BB04 RID: 47876 RVA: 0x002F1C7C File Offset: 0x002EFE7C
			// (set) Token: 0x0600BB05 RID: 47877 RVA: 0x00064E5F File Offset: 0x0006305F
			public unsafe float RecipeAlpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.PannelOpenContext.NativeFieldInfoPtr_RecipeAlpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.PannelOpenContext.NativeFieldInfoPtr_RecipeAlpha)) = value;
				}
			}

			// Token: 0x040078D2 RID: 30930
			private static readonly IntPtr NativeFieldInfoPtr_CookController;

			// Token: 0x040078D3 RID: 30931
			private static readonly IntPtr NativeFieldInfoPtr_IngredientAlpha;

			// Token: 0x040078D4 RID: 30932
			private static readonly IntPtr NativeFieldInfoPtr_RecipeAlpha;

			// Token: 0x040078D5 RID: 30933
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CookController_Single_Single_0;
		}

		// Token: 0x02000963 RID: 2403
		public class MatchedCookCombo : Il2CppSystem.Object
		{
			// Token: 0x0600BB06 RID: 47878 RVA: 0x002F1CA4 File Offset: 0x002EFEA4
			// Note: this type is marked as 'beforefieldinit'.
			static MatchedCookCombo()
			{
				Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.MatchedCookCombo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "MatchedCookCombo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.MatchedCookCombo>.NativeClassPtr);
				WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeFieldInfoPtr__Recipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.MatchedCookCombo>.NativeClassPtr, "<Recipe>k__BackingField");
				WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeFieldInfoPtr__Modifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.MatchedCookCombo>.NativeClassPtr, "<Modifiers>k__BackingField");
				WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeMethodInfoPtr__ctor_Public_Void_Recipe_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.MatchedCookCombo>.NativeClassPtr, 100674277);
				WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeMethodInfoPtr_get_Recipe_Public_get_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.MatchedCookCombo>.NativeClassPtr, 100674278);
				WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeMethodInfoPtr_get_Modifiers_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.MatchedCookCombo>.NativeClassPtr, 100674279);
				WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeMethodInfoPtr_GetResult_Public_Sellable_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.MatchedCookCombo>.NativeClassPtr, 100674280);
			}

			// Token: 0x0600BB07 RID: 47879 RVA: 0x002F1D48 File Offset: 0x002EFF48
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 61, RefRangeEnd = 130, XrefRangeStart = 61, XrefRangeEnd = 130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MatchedCookCombo(Recipe recipe, Il2CppStructArray<int> modifiers) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.MatchedCookCombo>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeMethodInfoPtr__ctor_Public_Void_Recipe_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D35 RID: 15669
			// (get) Token: 0x0600BB08 RID: 47880 RVA: 0x002F1DA8 File Offset: 0x002EFFA8
			public unsafe Recipe Recipe
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeMethodInfoPtr_get_Recipe_Public_get_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
				}
			}

			// Token: 0x17003D36 RID: 15670
			// (get) Token: 0x0600BB09 RID: 47881 RVA: 0x002F1DE8 File Offset: 0x002EFFE8
			public unsafe Il2CppStructArray<int> Modifiers
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeMethodInfoPtr_get_Modifiers_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
			}

			// Token: 0x0600BB0A RID: 47882 RVA: 0x002F1E28 File Offset: 0x002F0028
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 133619, RefRangeEnd = 133623, XrefRangeStart = 133593, XrefRangeEnd = 133619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable GetResult(Cooker cooker)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeMethodInfoPtr_GetResult_Public_Sellable_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0600BB0B RID: 47883 RVA: 0x00064E7A File Offset: 0x0006307A
			public MatchedCookCombo(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D33 RID: 15667
			// (get) Token: 0x0600BB0C RID: 47884 RVA: 0x002F1E78 File Offset: 0x002F0078
			// (set) Token: 0x0600BB0D RID: 47885 RVA: 0x00064E83 File Offset: 0x00063083
			public unsafe Recipe _Recipe_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeFieldInfoPtr__Recipe_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeFieldInfoPtr__Recipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D34 RID: 15668
			// (get) Token: 0x0600BB0E RID: 47886 RVA: 0x002F1EA8 File Offset: 0x002F00A8
			// (set) Token: 0x0600BB0F RID: 47887 RVA: 0x00064EA2 File Offset: 0x000630A2
			public unsafe Il2CppStructArray<int> _Modifiers_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeFieldInfoPtr__Modifiers_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.MatchedCookCombo.NativeFieldInfoPtr__Modifiers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040078D6 RID: 30934
			private static readonly IntPtr NativeFieldInfoPtr__Recipe_k__BackingField;

			// Token: 0x040078D7 RID: 30935
			private static readonly IntPtr NativeFieldInfoPtr__Modifiers_k__BackingField;

			// Token: 0x040078D8 RID: 30936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Recipe_Il2CppStructArray_1_Int32_0;

			// Token: 0x040078D9 RID: 30937
			private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_Recipe_0;

			// Token: 0x040078DA RID: 30938
			private static readonly IntPtr NativeMethodInfoPtr_get_Modifiers_Public_get_Il2CppStructArray_1_Int32_0;

			// Token: 0x040078DB RID: 30939
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Sellable_Cooker_0;
		}

		// Token: 0x02000964 RID: 2404
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneCookingSelectionPannel+<>c__DisplayClass65_0")]
		public sealed class __c__DisplayClass65_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BB10 RID: 47888 RVA: 0x002F1ED8 File Offset: 0x002F00D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_0()
			{
				Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "<>c__DisplayClass65_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_0>.NativeClassPtr);
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_0.NativeFieldInfoPtr_ingredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_0>.NativeClassPtr, "ingredient");
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_0>.NativeClassPtr, 100674281);
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_0.NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_0>.NativeClassPtr, 100674282);
			}

			// Token: 0x0600BB11 RID: 47889 RVA: 0x002F1F40 File Offset: 0x002F0140
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB12 RID: 47890 RVA: 0x002F1F7C File Offset: 0x002F017C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133623, XrefRangeEnd = 133626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass65_0.NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB13 RID: 47891 RVA: 0x00064EC1 File Offset: 0x000630C1
			public __c__DisplayClass65_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D37 RID: 15671
			// (get) Token: 0x0600BB14 RID: 47892 RVA: 0x002F1FC0 File Offset: 0x002F01C0
			// (set) Token: 0x0600BB15 RID: 47893 RVA: 0x00064ECA File Offset: 0x000630CA
			public unsafe Ingredient ingredient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_0.NativeFieldInfoPtr_ingredient);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_0.NativeFieldInfoPtr_ingredient), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040078DC RID: 30940
			private static readonly IntPtr NativeFieldInfoPtr_ingredient;

			// Token: 0x040078DD RID: 30941
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040078DE RID: 30942
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_Image_0;
		}

		// Token: 0x02000965 RID: 2405
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneCookingSelectionPannel+<>c__DisplayClass65_1")]
		public sealed class __c__DisplayClass65_1 : Il2CppSystem.Object
		{
			// Token: 0x0600BB16 RID: 47894 RVA: 0x002F1FF0 File Offset: 0x002F01F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_1()
			{
				Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "<>c__DisplayClass65_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr);
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr, "result");
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr, "output");
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr_hasModify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr, "hasModify");
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr, "<>4__this");
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr___9__17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr, "<>9__17");
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr___9__18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr, "<>9__18");
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr, 100674283);
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeMethodInfoPtr__OnPanelInitialize_b__14_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr, 100674284);
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeMethodInfoPtr__OnPanelInitialize_b__15_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr, 100674285);
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeMethodInfoPtr__OnPanelInitialize_b__17_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr, 100674286);
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeMethodInfoPtr__OnPanelInitialize_b__18_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr, 100674287);
				WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeMethodInfoPtr__OnPanelInitialize_b__16_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr, 100674288);
			}

			// Token: 0x0600BB17 RID: 47895 RVA: 0x002F210C File Offset: 0x002F030C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass65_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB18 RID: 47896 RVA: 0x002F2148 File Offset: 0x002F0348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133626, XrefRangeEnd = 133628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__14(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeMethodInfoPtr__OnPanelInitialize_b__14_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB19 RID: 47897 RVA: 0x002F218C File Offset: 0x002F038C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133628, XrefRangeEnd = 133653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__15(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeMethodInfoPtr__OnPanelInitialize_b__15_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB1A RID: 47898 RVA: 0x002F21D0 File Offset: 0x002F03D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133653, XrefRangeEnd = 133657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__17(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeMethodInfoPtr__OnPanelInitialize_b__17_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB1B RID: 47899 RVA: 0x002F2214 File Offset: 0x002F0414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133657, XrefRangeEnd = 133658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__18(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeMethodInfoPtr__OnPanelInitialize_b__18_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB1C RID: 47900 RVA: 0x002F2258 File Offset: 0x002F0458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__16(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeMethodInfoPtr__OnPanelInitialize_b__16_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB1D RID: 47901 RVA: 0x00064EE9 File Offset: 0x000630E9
			public __c__DisplayClass65_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D38 RID: 15672
			// (get) Token: 0x0600BB1E RID: 47902 RVA: 0x002F229C File Offset: 0x002F049C
			// (set) Token: 0x0600BB1F RID: 47903 RVA: 0x00064EF2 File Offset: 0x000630F2
			public unsafe bool result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr_result);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr_result)) = value;
				}
			}

			// Token: 0x17003D39 RID: 15673
			// (get) Token: 0x0600BB20 RID: 47904 RVA: 0x002F22C4 File Offset: 0x002F04C4
			// (set) Token: 0x0600BB21 RID: 47905 RVA: 0x00064F0D File Offset: 0x0006310D
			public unsafe Sellable output
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr_output);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D3A RID: 15674
			// (get) Token: 0x0600BB22 RID: 47906 RVA: 0x002F22F4 File Offset: 0x002F04F4
			// (set) Token: 0x0600BB23 RID: 47907 RVA: 0x00064F2C File Offset: 0x0006312C
			public unsafe bool hasModify
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr_hasModify);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr_hasModify)) = value;
				}
			}

			// Token: 0x17003D3B RID: 15675
			// (get) Token: 0x0600BB24 RID: 47908 RVA: 0x002F231C File Offset: 0x002F051C
			// (set) Token: 0x0600BB25 RID: 47909 RVA: 0x00064F47 File Offset: 0x00063147
			public unsafe WorkSceneCookingSelectionPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneCookingSelectionPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D3C RID: 15676
			// (get) Token: 0x0600BB26 RID: 47910 RVA: 0x002F234C File Offset: 0x002F054C
			// (set) Token: 0x0600BB27 RID: 47911 RVA: 0x00064F66 File Offset: 0x00063166
			public unsafe Action<Image> __9__17
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr___9__17);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr___9__17), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D3D RID: 15677
			// (get) Token: 0x0600BB28 RID: 47912 RVA: 0x002F237C File Offset: 0x002F057C
			// (set) Token: 0x0600BB29 RID: 47913 RVA: 0x00064F85 File Offset: 0x00063185
			public unsafe Action<Image> __9__18
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr___9__18);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass65_1.NativeFieldInfoPtr___9__18), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040078DF RID: 30943
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x040078E0 RID: 30944
			private static readonly IntPtr NativeFieldInfoPtr_output;

			// Token: 0x040078E1 RID: 30945
			private static readonly IntPtr NativeFieldInfoPtr_hasModify;

			// Token: 0x040078E2 RID: 30946
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040078E3 RID: 30947
			private static readonly IntPtr NativeFieldInfoPtr___9__17;

			// Token: 0x040078E4 RID: 30948
			private static readonly IntPtr NativeFieldInfoPtr___9__18;

			// Token: 0x040078E5 RID: 30949
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040078E6 RID: 30950
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__14_Internal_Void_Image_0;

			// Token: 0x040078E7 RID: 30951
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_Internal_Void_UIElementCluster_0;

			// Token: 0x040078E8 RID: 30952
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_Internal_Void_Image_0;

			// Token: 0x040078E9 RID: 30953
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__18_Internal_Void_Image_0;

			// Token: 0x040078EA RID: 30954
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__16_Internal_Void_Image_0;
		}

		// Token: 0x02000966 RID: 2406
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneCookingSelectionPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600BB2A RID: 47914 RVA: 0x002F23AC File Offset: 0x002F05AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr);
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__65_1");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__65_2");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__65_4");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__65_13");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__65_9");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__65_10");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__65_19");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__65_11");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__65_12");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__71_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__71_0");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__77_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__77_2");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__79_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__79_2");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__79_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__79_3");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__81_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__81_2");
				WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__82_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, "<>9__82_0");
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674290);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_1_Internal_Boolean_MatchedCookCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674291);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_2_Internal_Boolean_MatchedCookCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674292);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_4_Internal_Void_Ingredient_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674293);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_13_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674294);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_9_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674295);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674296);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_11_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674297);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_19_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674298);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_12_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674299);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__UpdateSelectedField_b__71_0_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674300);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnRecipeElementSelected_b__77_2_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674301);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnOutputSelected_b__79_2_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674302);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnOutputSelected_b__79_3_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674303);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__MatchingSelected_b__81_2_Internal_Int32_MatchedCookCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674304);
				WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__TryReturnSelectedIngredients_b__82_0_Internal_IEnumerable_1_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr, 100674305);
			}

			// Token: 0x0600BB2B RID: 47915 RVA: 0x002F2658 File Offset: 0x002F0858
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB2C RID: 47916 RVA: 0x002F2694 File Offset: 0x002F0894
			[CallerCount(0)]
			public unsafe bool _OnPanelInitialize_b__65_1(WorkSceneCookingSelectionPannel.MatchedCookCombo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_1_Internal_Boolean_MatchedCookCombo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BB2D RID: 47917 RVA: 0x002F26E4 File Offset: 0x002F08E4
			[CallerCount(0)]
			public unsafe bool _OnPanelInitialize_b__65_2(WorkSceneCookingSelectionPannel.MatchedCookCombo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_2_Internal_Boolean_MatchedCookCombo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BB2E RID: 47918 RVA: 0x002F2734 File Offset: 0x002F0934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133658, XrefRangeEnd = 133671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__65_4(Ingredient ingredient, UIElementCluster cluster, UIButtonSimple _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredient);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_4_Internal_Void_Ingredient_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB2F RID: 47919 RVA: 0x002F279C File Offset: 0x002F099C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__65_13(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_13_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB30 RID: 47920 RVA: 0x002F27E0 File Offset: 0x002F09E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__65_9(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_9_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB31 RID: 47921 RVA: 0x002F2824 File Offset: 0x002F0A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__65_10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB32 RID: 47922 RVA: 0x002F2868 File Offset: 0x002F0A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133671, XrefRangeEnd = 133690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__65_11(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_11_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB33 RID: 47923 RVA: 0x002F28AC File Offset: 0x002F0AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__65_19(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_19_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB34 RID: 47924 RVA: 0x002F28F0 File Offset: 0x002F0AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__65_12(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__65_12_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB35 RID: 47925 RVA: 0x002F2934 File Offset: 0x002F0B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _UpdateSelectedField_b__71_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__UpdateSelectedField_b__71_0_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600BB36 RID: 47926 RVA: 0x002F2980 File Offset: 0x002F0B80
			[CallerCount(0)]
			public unsafe IEnumerable<int> _OnRecipeElementSelected_b__77_2(Il2CppStructArray<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnRecipeElementSelected_b__77_2_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600BB37 RID: 47927 RVA: 0x002F29D0 File Offset: 0x002F0BD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133690, XrefRangeEnd = 133691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnOutputSelected_b__79_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnOutputSelected_b__79_2_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BB38 RID: 47928 RVA: 0x002F2A1C File Offset: 0x002F0C1C
			[CallerCount(0)]
			public unsafe IEnumerable<int> _OnOutputSelected_b__79_3(IEnumerable<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__OnOutputSelected_b__79_3_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600BB39 RID: 47929 RVA: 0x002F2A6C File Offset: 0x002F0C6C
			[CallerCount(0)]
			public unsafe int _MatchingSelected_b__81_2(WorkSceneCookingSelectionPannel.MatchedCookCombo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__MatchingSelected_b__81_2_Internal_Int32_MatchedCookCombo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BB3A RID: 47930 RVA: 0x002F2ABC File Offset: 0x002F0CBC
			[CallerCount(0)]
			public unsafe IEnumerable<int> _TryReturnSelectedIngredients_b__82_0(List<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c.NativeMethodInfoPtr__TryReturnSelectedIngredients_b__82_0_Internal_IEnumerable_1_Int32_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600BB3B RID: 47931 RVA: 0x00064FA4 File Offset: 0x000631A4
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D3E RID: 15678
			// (get) Token: 0x0600BB3C RID: 47932 RVA: 0x002F2B0C File Offset: 0x002F0D0C
			// (set) Token: 0x0600BB3D RID: 47933 RVA: 0x00064FAD File Offset: 0x000631AD
			public unsafe static WorkSceneCookingSelectionPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneCookingSelectionPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D3F RID: 15679
			// (get) Token: 0x0600BB3E RID: 47934 RVA: 0x002F2B34 File Offset: 0x002F0D34
			// (set) Token: 0x0600BB3F RID: 47935 RVA: 0x00064FBF File Offset: 0x000631BF
			public unsafe static Func<WorkSceneCookingSelectionPannel.MatchedCookCombo, bool> __9__65_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WorkSceneCookingSelectionPannel.MatchedCookCombo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D40 RID: 15680
			// (get) Token: 0x0600BB40 RID: 47936 RVA: 0x002F2B5C File Offset: 0x002F0D5C
			// (set) Token: 0x0600BB41 RID: 47937 RVA: 0x00064FD1 File Offset: 0x000631D1
			public unsafe static Predicate<WorkSceneCookingSelectionPannel.MatchedCookCombo> __9__65_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<WorkSceneCookingSelectionPannel.MatchedCookCombo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D41 RID: 15681
			// (get) Token: 0x0600BB42 RID: 47938 RVA: 0x002F2B84 File Offset: 0x002F0D84
			// (set) Token: 0x0600BB43 RID: 47939 RVA: 0x00064FE3 File Offset: 0x000631E3
			public unsafe static Action<Ingredient, UIElementCluster, UIButtonSimple> __9__65_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Ingredient, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D42 RID: 15682
			// (get) Token: 0x0600BB44 RID: 47940 RVA: 0x002F2BAC File Offset: 0x002F0DAC
			// (set) Token: 0x0600BB45 RID: 47941 RVA: 0x00064FF5 File Offset: 0x000631F5
			public unsafe static Action<Image> __9__65_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D43 RID: 15683
			// (get) Token: 0x0600BB46 RID: 47942 RVA: 0x002F2BD4 File Offset: 0x002F0DD4
			// (set) Token: 0x0600BB47 RID: 47943 RVA: 0x00065007 File Offset: 0x00063207
			public unsafe static Action<Image> __9__65_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D44 RID: 15684
			// (get) Token: 0x0600BB48 RID: 47944 RVA: 0x002F2BFC File Offset: 0x002F0DFC
			// (set) Token: 0x0600BB49 RID: 47945 RVA: 0x00065019 File Offset: 0x00063219
			public unsafe static Action<Image> __9__65_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D45 RID: 15685
			// (get) Token: 0x0600BB4A RID: 47946 RVA: 0x002F2C24 File Offset: 0x002F0E24
			// (set) Token: 0x0600BB4B RID: 47947 RVA: 0x0006502B File Offset: 0x0006322B
			public unsafe static Action<Image> __9__65_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D46 RID: 15686
			// (get) Token: 0x0600BB4C RID: 47948 RVA: 0x002F2C4C File Offset: 0x002F0E4C
			// (set) Token: 0x0600BB4D RID: 47949 RVA: 0x0006503D File Offset: 0x0006323D
			public unsafe static Action<UIElementCluster> __9__65_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D47 RID: 15687
			// (get) Token: 0x0600BB4E RID: 47950 RVA: 0x002F2C74 File Offset: 0x002F0E74
			// (set) Token: 0x0600BB4F RID: 47951 RVA: 0x0006504F File Offset: 0x0006324F
			public unsafe static Action<Image> __9__65_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__65_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D48 RID: 15688
			// (get) Token: 0x0600BB50 RID: 47952 RVA: 0x002F2C9C File Offset: 0x002F0E9C
			// (set) Token: 0x0600BB51 RID: 47953 RVA: 0x00065061 File Offset: 0x00063261
			public unsafe static Func<int, Ingredient> __9__71_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__71_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__71_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D49 RID: 15689
			// (get) Token: 0x0600BB52 RID: 47954 RVA: 0x002F2CC4 File Offset: 0x002F0EC4
			// (set) Token: 0x0600BB53 RID: 47955 RVA: 0x00065073 File Offset: 0x00063273
			public unsafe static Func<Il2CppStructArray<int>, IEnumerable<int>> __9__77_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__77_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStructArray<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__77_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D4A RID: 15690
			// (get) Token: 0x0600BB54 RID: 47956 RVA: 0x002F2CEC File Offset: 0x002F0EEC
			// (set) Token: 0x0600BB55 RID: 47957 RVA: 0x00065085 File Offset: 0x00063285
			public unsafe static Func<int, bool> __9__79_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__79_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__79_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D4B RID: 15691
			// (get) Token: 0x0600BB56 RID: 47958 RVA: 0x002F2D14 File Offset: 0x002F0F14
			// (set) Token: 0x0600BB57 RID: 47959 RVA: 0x00065097 File Offset: 0x00063297
			public unsafe static Func<IEnumerable<int>, IEnumerable<int>> __9__79_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__79_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__79_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D4C RID: 15692
			// (get) Token: 0x0600BB58 RID: 47960 RVA: 0x002F2D3C File Offset: 0x002F0F3C
			// (set) Token: 0x0600BB59 RID: 47961 RVA: 0x000650A9 File Offset: 0x000632A9
			public unsafe static Func<WorkSceneCookingSelectionPannel.MatchedCookCombo, int> __9__81_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__81_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WorkSceneCookingSelectionPannel.MatchedCookCombo, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__81_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D4D RID: 15693
			// (get) Token: 0x0600BB5A RID: 47962 RVA: 0x002F2D64 File Offset: 0x002F0F64
			// (set) Token: 0x0600BB5B RID: 47963 RVA: 0x000650BB File Offset: 0x000632BB
			public unsafe static Func<List<int>, IEnumerable<int>> __9__82_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__82_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneCookingSelectionPannel.__c.NativeFieldInfoPtr___9__82_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040078EB RID: 30955
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040078EC RID: 30956
			private static readonly IntPtr NativeFieldInfoPtr___9__65_1;

			// Token: 0x040078ED RID: 30957
			private static readonly IntPtr NativeFieldInfoPtr___9__65_2;

			// Token: 0x040078EE RID: 30958
			private static readonly IntPtr NativeFieldInfoPtr___9__65_4;

			// Token: 0x040078EF RID: 30959
			private static readonly IntPtr NativeFieldInfoPtr___9__65_13;

			// Token: 0x040078F0 RID: 30960
			private static readonly IntPtr NativeFieldInfoPtr___9__65_9;

			// Token: 0x040078F1 RID: 30961
			private static readonly IntPtr NativeFieldInfoPtr___9__65_10;

			// Token: 0x040078F2 RID: 30962
			private static readonly IntPtr NativeFieldInfoPtr___9__65_19;

			// Token: 0x040078F3 RID: 30963
			private static readonly IntPtr NativeFieldInfoPtr___9__65_11;

			// Token: 0x040078F4 RID: 30964
			private static readonly IntPtr NativeFieldInfoPtr___9__65_12;

			// Token: 0x040078F5 RID: 30965
			private static readonly IntPtr NativeFieldInfoPtr___9__71_0;

			// Token: 0x040078F6 RID: 30966
			private static readonly IntPtr NativeFieldInfoPtr___9__77_2;

			// Token: 0x040078F7 RID: 30967
			private static readonly IntPtr NativeFieldInfoPtr___9__79_2;

			// Token: 0x040078F8 RID: 30968
			private static readonly IntPtr NativeFieldInfoPtr___9__79_3;

			// Token: 0x040078F9 RID: 30969
			private static readonly IntPtr NativeFieldInfoPtr___9__81_2;

			// Token: 0x040078FA RID: 30970
			private static readonly IntPtr NativeFieldInfoPtr___9__82_0;

			// Token: 0x040078FB RID: 30971
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040078FC RID: 30972
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_1_Internal_Boolean_MatchedCookCombo_0;

			// Token: 0x040078FD RID: 30973
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_2_Internal_Boolean_MatchedCookCombo_0;

			// Token: 0x040078FE RID: 30974
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_4_Internal_Void_Ingredient_UIElementCluster_UIButtonSimple_0;

			// Token: 0x040078FF RID: 30975
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_13_Internal_Void_Image_0;

			// Token: 0x04007900 RID: 30976
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_9_Internal_Void_Image_0;

			// Token: 0x04007901 RID: 30977
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_10_Internal_Void_Image_0;

			// Token: 0x04007902 RID: 30978
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_11_Internal_Void_UIElementCluster_0;

			// Token: 0x04007903 RID: 30979
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_19_Internal_Void_Image_0;

			// Token: 0x04007904 RID: 30980
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__65_12_Internal_Void_Image_0;

			// Token: 0x04007905 RID: 30981
			private static readonly IntPtr NativeMethodInfoPtr__UpdateSelectedField_b__71_0_Internal_Ingredient_Int32_0;

			// Token: 0x04007906 RID: 30982
			private static readonly IntPtr NativeMethodInfoPtr__OnRecipeElementSelected_b__77_2_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0;

			// Token: 0x04007907 RID: 30983
			private static readonly IntPtr NativeMethodInfoPtr__OnOutputSelected_b__79_2_Internal_Boolean_Int32_0;

			// Token: 0x04007908 RID: 30984
			private static readonly IntPtr NativeMethodInfoPtr__OnOutputSelected_b__79_3_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0;

			// Token: 0x04007909 RID: 30985
			private static readonly IntPtr NativeMethodInfoPtr__MatchingSelected_b__81_2_Internal_Int32_MatchedCookCombo_0;

			// Token: 0x0400790A RID: 30986
			private static readonly IntPtr NativeMethodInfoPtr__TryReturnSelectedIngredients_b__82_0_Internal_IEnumerable_1_Int32_List_1_Int32_0;
		}

		// Token: 0x02000967 RID: 2407
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneCookingSelectionPannel+<>c__DisplayClass74_0")]
		public sealed class __c__DisplayClass74_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BB5C RID: 47964 RVA: 0x002F2D8C File Offset: 0x002F0F8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_0()
			{
				Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass74_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "<>c__DisplayClass74_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass74_0>.NativeClassPtr);
				WorkSceneCookingSelectionPannel.__c__DisplayClass74_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass74_0>.NativeClassPtr, "amount");
				WorkSceneCookingSelectionPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass74_0>.NativeClassPtr, 100674306);
				WorkSceneCookingSelectionPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__OnIngElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass74_0>.NativeClassPtr, 100674307);
				WorkSceneCookingSelectionPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__OnIngElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass74_0>.NativeClassPtr, 100674308);
			}

			// Token: 0x0600BB5D RID: 47965 RVA: 0x002F2E08 File Offset: 0x002F1008
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass74_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB5E RID: 47966 RVA: 0x002F2E44 File Offset: 0x002F1044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnIngElementEnabled_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__OnIngElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB5F RID: 47967 RVA: 0x002F2E88 File Offset: 0x002F1088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnIngElementEnabled_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__OnIngElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB60 RID: 47968 RVA: 0x000650CD File Offset: 0x000632CD
			public __c__DisplayClass74_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D4E RID: 15694
			// (get) Token: 0x0600BB61 RID: 47969 RVA: 0x002F2ECC File Offset: 0x002F10CC
			// (set) Token: 0x0600BB62 RID: 47970 RVA: 0x000650D6 File Offset: 0x000632D6
			public unsafe string amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass74_0.NativeFieldInfoPtr_amount);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass74_0.NativeFieldInfoPtr_amount), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400790B RID: 30987
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x0400790C RID: 30988
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400790D RID: 30989
			private static readonly IntPtr NativeMethodInfoPtr__OnIngElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400790E RID: 30990
			private static readonly IntPtr NativeMethodInfoPtr__OnIngElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000968 RID: 2408
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneCookingSelectionPannel+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BB63 RID: 47971 RVA: 0x002F2EF4 File Offset: 0x002F10F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass75_0>.NativeClassPtr);
				WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass75_0>.NativeClassPtr, "<>4__this");
				WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass75_0>.NativeClassPtr, "value");
				WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeFieldInfoPtr_currentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass75_0>.NativeClassPtr, "currentId");
				WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass75_0>.NativeClassPtr, 100674309);
				WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeMethodInfoPtr__OnIngElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass75_0>.NativeClassPtr, 100674310);
				WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeMethodInfoPtr__OnIngElementSelected_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass75_0>.NativeClassPtr, 100674311);
			}

			// Token: 0x0600BB64 RID: 47972 RVA: 0x002F2F98 File Offset: 0x002F1198
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB65 RID: 47973 RVA: 0x002F2FD4 File Offset: 0x002F11D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133691, XrefRangeEnd = 133699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnIngElementSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeMethodInfoPtr__OnIngElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB66 RID: 47974 RVA: 0x002F3008 File Offset: 0x002F1208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133699, XrefRangeEnd = 133717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnIngElementSelected_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeMethodInfoPtr__OnIngElementSelected_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB67 RID: 47975 RVA: 0x000650F5 File Offset: 0x000632F5
			public __c__DisplayClass75_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D4F RID: 15695
			// (get) Token: 0x0600BB68 RID: 47976 RVA: 0x002F303C File Offset: 0x002F123C
			// (set) Token: 0x0600BB69 RID: 47977 RVA: 0x000650FE File Offset: 0x000632FE
			public unsafe WorkSceneCookingSelectionPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneCookingSelectionPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D50 RID: 15696
			// (get) Token: 0x0600BB6A RID: 47978 RVA: 0x002F306C File Offset: 0x002F126C
			// (set) Token: 0x0600BB6B RID: 47979 RVA: 0x0006511D File Offset: 0x0006331D
			public KeyValuePair<Ingredient, int> value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeFieldInfoPtr_value);
					return new KeyValuePair<Ingredient, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<Ingredient, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeFieldInfoPtr_value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<Ingredient, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003D51 RID: 15697
			// (get) Token: 0x0600BB6C RID: 47980 RVA: 0x002F309C File Offset: 0x002F129C
			// (set) Token: 0x0600BB6D RID: 47981 RVA: 0x0006514B File Offset: 0x0006334B
			public unsafe int currentId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeFieldInfoPtr_currentId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass75_0.NativeFieldInfoPtr_currentId)) = value;
				}
			}

			// Token: 0x0400790F RID: 30991
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007910 RID: 30992
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04007911 RID: 30993
			private static readonly IntPtr NativeFieldInfoPtr_currentId;

			// Token: 0x04007912 RID: 30994
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007913 RID: 30995
			private static readonly IntPtr NativeMethodInfoPtr__OnIngElementSelected_b__0_Internal_Void_0;

			// Token: 0x04007914 RID: 30996
			private static readonly IntPtr NativeMethodInfoPtr__OnIngElementSelected_b__1_Internal_Void_0;
		}

		// Token: 0x02000969 RID: 2409
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneCookingSelectionPannel+<>c__DisplayClass76_0")]
		public sealed class __c__DisplayClass76_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BB6E RID: 47982 RVA: 0x002F30C4 File Offset: 0x002F12C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass76_0()
			{
				Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass76_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "<>c__DisplayClass76_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass76_0>.NativeClassPtr);
				WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass76_0>.NativeClassPtr, "result");
				WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass76_0>.NativeClassPtr, "amount");
				WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass76_0>.NativeClassPtr, 100674312);
				WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeMethodInfoPtr__OnRecipeElementEnabled_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass76_0>.NativeClassPtr, 100674313);
				WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeMethodInfoPtr__OnRecipeElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass76_0>.NativeClassPtr, 100674314);
				WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeMethodInfoPtr__OnRecipeElementEnabled_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass76_0>.NativeClassPtr, 100674315);
			}

			// Token: 0x0600BB6F RID: 47983 RVA: 0x002F3168 File Offset: 0x002F1368
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass76_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass76_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB70 RID: 47984 RVA: 0x002F31A4 File Offset: 0x002F13A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnRecipeElementEnabled_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeMethodInfoPtr__OnRecipeElementEnabled_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB71 RID: 47985 RVA: 0x002F31E8 File Offset: 0x002F13E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnRecipeElementEnabled_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeMethodInfoPtr__OnRecipeElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB72 RID: 47986 RVA: 0x002F322C File Offset: 0x002F142C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnRecipeElementEnabled_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeMethodInfoPtr__OnRecipeElementEnabled_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB73 RID: 47987 RVA: 0x00065166 File Offset: 0x00063366
			public __c__DisplayClass76_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D52 RID: 15698
			// (get) Token: 0x0600BB74 RID: 47988 RVA: 0x002F3270 File Offset: 0x002F1470
			// (set) Token: 0x0600BB75 RID: 47989 RVA: 0x0006516F File Offset: 0x0006336F
			public unsafe bool result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeFieldInfoPtr_result);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeFieldInfoPtr_result)) = value;
				}
			}

			// Token: 0x17003D53 RID: 15699
			// (get) Token: 0x0600BB76 RID: 47990 RVA: 0x002F3298 File Offset: 0x002F1498
			// (set) Token: 0x0600BB77 RID: 47991 RVA: 0x0006518A File Offset: 0x0006338A
			public unsafe string amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeFieldInfoPtr_amount);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass76_0.NativeFieldInfoPtr_amount), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04007915 RID: 30997
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x04007916 RID: 30998
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04007917 RID: 30999
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007918 RID: 31000
			private static readonly IntPtr NativeMethodInfoPtr__OnRecipeElementEnabled_b__0_Internal_Void_Image_0;

			// Token: 0x04007919 RID: 31001
			private static readonly IntPtr NativeMethodInfoPtr__OnRecipeElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400791A RID: 31002
			private static readonly IntPtr NativeMethodInfoPtr__OnRecipeElementEnabled_b__2_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x0200096A RID: 2410
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneCookingSelectionPannel+<>c__DisplayClass77_0")]
		public sealed class __c__DisplayClass77_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BB78 RID: 47992 RVA: 0x002F32C0 File Offset: 0x002F14C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass77_0()
			{
				Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass77_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "<>c__DisplayClass77_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass77_0>.NativeClassPtr);
				WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass77_0>.NativeClassPtr, "<>4__this");
				WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass77_0>.NativeClassPtr, "recipe");
				WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass77_0>.NativeClassPtr, "<>9__3");
				WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass77_0>.NativeClassPtr, "<>9__4");
				WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass77_0>.NativeClassPtr, 100674316);
				WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeMethodInfoPtr__OnRecipeElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass77_0>.NativeClassPtr, 100674317);
				WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeMethodInfoPtr__OnRecipeElementSelected_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass77_0>.NativeClassPtr, 100674318);
				WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeMethodInfoPtr__OnRecipeElementSelected_b__3_Internal_Boolean_MatchedCookCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass77_0>.NativeClassPtr, 100674319);
				WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeMethodInfoPtr__OnRecipeElementSelected_b__4_Internal_Boolean_MatchedCookCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass77_0>.NativeClassPtr, 100674320);
			}

			// Token: 0x0600BB79 RID: 47993 RVA: 0x002F33A0 File Offset: 0x002F15A0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass77_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass77_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB7A RID: 47994 RVA: 0x002F33DC File Offset: 0x002F15DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133717, XrefRangeEnd = 133725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnRecipeElementSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeMethodInfoPtr__OnRecipeElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB7B RID: 47995 RVA: 0x002F3410 File Offset: 0x002F1610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133725, XrefRangeEnd = 133770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnRecipeElementSelected_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeMethodInfoPtr__OnRecipeElementSelected_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB7C RID: 47996 RVA: 0x002F3444 File Offset: 0x002F1644
			[CallerCount(0)]
			public unsafe bool _OnRecipeElementSelected_b__3(WorkSceneCookingSelectionPannel.MatchedCookCombo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeMethodInfoPtr__OnRecipeElementSelected_b__3_Internal_Boolean_MatchedCookCombo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BB7D RID: 47997 RVA: 0x002F3494 File Offset: 0x002F1694
			[CallerCount(0)]
			public unsafe bool _OnRecipeElementSelected_b__4(WorkSceneCookingSelectionPannel.MatchedCookCombo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeMethodInfoPtr__OnRecipeElementSelected_b__4_Internal_Boolean_MatchedCookCombo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BB7E RID: 47998 RVA: 0x000651A9 File Offset: 0x000633A9
			public __c__DisplayClass77_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D54 RID: 15700
			// (get) Token: 0x0600BB7F RID: 47999 RVA: 0x002F34E4 File Offset: 0x002F16E4
			// (set) Token: 0x0600BB80 RID: 48000 RVA: 0x000651B2 File Offset: 0x000633B2
			public unsafe WorkSceneCookingSelectionPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneCookingSelectionPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D55 RID: 15701
			// (get) Token: 0x0600BB81 RID: 48001 RVA: 0x002F3514 File Offset: 0x002F1714
			// (set) Token: 0x0600BB82 RID: 48002 RVA: 0x000651D1 File Offset: 0x000633D1
			public unsafe Recipe recipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeFieldInfoPtr_recipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D56 RID: 15702
			// (get) Token: 0x0600BB83 RID: 48003 RVA: 0x002F3544 File Offset: 0x002F1744
			// (set) Token: 0x0600BB84 RID: 48004 RVA: 0x000651F0 File Offset: 0x000633F0
			public unsafe Func<WorkSceneCookingSelectionPannel.MatchedCookCombo, bool> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WorkSceneCookingSelectionPannel.MatchedCookCombo, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D57 RID: 15703
			// (get) Token: 0x0600BB85 RID: 48005 RVA: 0x002F3574 File Offset: 0x002F1774
			// (set) Token: 0x0600BB86 RID: 48006 RVA: 0x0006520F File Offset: 0x0006340F
			public unsafe Predicate<WorkSceneCookingSelectionPannel.MatchedCookCombo> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<WorkSceneCookingSelectionPannel.MatchedCookCombo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass77_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400791B RID: 31003
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400791C RID: 31004
			private static readonly IntPtr NativeFieldInfoPtr_recipe;

			// Token: 0x0400791D RID: 31005
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x0400791E RID: 31006
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x0400791F RID: 31007
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007920 RID: 31008
			private static readonly IntPtr NativeMethodInfoPtr__OnRecipeElementSelected_b__0_Internal_Void_0;

			// Token: 0x04007921 RID: 31009
			private static readonly IntPtr NativeMethodInfoPtr__OnRecipeElementSelected_b__1_Internal_Void_0;

			// Token: 0x04007922 RID: 31010
			private static readonly IntPtr NativeMethodInfoPtr__OnRecipeElementSelected_b__3_Internal_Boolean_MatchedCookCombo_0;

			// Token: 0x04007923 RID: 31011
			private static readonly IntPtr NativeMethodInfoPtr__OnRecipeElementSelected_b__4_Internal_Boolean_MatchedCookCombo_0;
		}

		// Token: 0x0200096B RID: 2411
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneCookingSelectionPannel+<>c__DisplayClass78_0")]
		public sealed class __c__DisplayClass78_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BB87 RID: 48007 RVA: 0x002F35A4 File Offset: 0x002F17A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_0()
			{
				Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "<>c__DisplayClass78_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass78_0>.NativeClassPtr);
				WorkSceneCookingSelectionPannel.__c__DisplayClass78_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass78_0>.NativeClassPtr, "<>4__this");
				WorkSceneCookingSelectionPannel.__c__DisplayClass78_0.NativeFieldInfoPtr_ingredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass78_0>.NativeClassPtr, "ingredient");
				WorkSceneCookingSelectionPannel.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass78_0>.NativeClassPtr, 100674321);
				WorkSceneCookingSelectionPannel.__c__DisplayClass78_0.NativeMethodInfoPtr__OnSelectedIngredientsSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass78_0>.NativeClassPtr, 100674322);
				WorkSceneCookingSelectionPannel.__c__DisplayClass78_0.NativeMethodInfoPtr__OnSelectedIngredientsSelected_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass78_0>.NativeClassPtr, 100674323);
			}

			// Token: 0x0600BB88 RID: 48008 RVA: 0x002F3634 File Offset: 0x002F1834
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass78_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB89 RID: 48009 RVA: 0x002F3670 File Offset: 0x002F1870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133770, XrefRangeEnd = 133777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnSelectedIngredientsSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass78_0.NativeMethodInfoPtr__OnSelectedIngredientsSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB8A RID: 48010 RVA: 0x002F36A4 File Offset: 0x002F18A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133777, XrefRangeEnd = 133793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnSelectedIngredientsSelected_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass78_0.NativeMethodInfoPtr__OnSelectedIngredientsSelected_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB8B RID: 48011 RVA: 0x0006522E File Offset: 0x0006342E
			public __c__DisplayClass78_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D58 RID: 15704
			// (get) Token: 0x0600BB8C RID: 48012 RVA: 0x002F36D8 File Offset: 0x002F18D8
			// (set) Token: 0x0600BB8D RID: 48013 RVA: 0x00065237 File Offset: 0x00063437
			public unsafe WorkSceneCookingSelectionPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass78_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneCookingSelectionPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass78_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D59 RID: 15705
			// (get) Token: 0x0600BB8E RID: 48014 RVA: 0x002F3708 File Offset: 0x002F1908
			// (set) Token: 0x0600BB8F RID: 48015 RVA: 0x00065256 File Offset: 0x00063456
			public unsafe Ingredient ingredient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass78_0.NativeFieldInfoPtr_ingredient);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass78_0.NativeFieldInfoPtr_ingredient), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007924 RID: 31012
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007925 RID: 31013
			private static readonly IntPtr NativeFieldInfoPtr_ingredient;

			// Token: 0x04007926 RID: 31014
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007927 RID: 31015
			private static readonly IntPtr NativeMethodInfoPtr__OnSelectedIngredientsSelected_b__0_Internal_Void_0;

			// Token: 0x04007928 RID: 31016
			private static readonly IntPtr NativeMethodInfoPtr__OnSelectedIngredientsSelected_b__1_Internal_Void_0;
		}

		// Token: 0x0200096C RID: 2412
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneCookingSelectionPannel+<>c__DisplayClass79_0")]
		public sealed class __c__DisplayClass79_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BB90 RID: 48016 RVA: 0x002F3738 File Offset: 0x002F1938
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass79_0()
			{
				Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass79_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "<>c__DisplayClass79_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass79_0>.NativeClassPtr);
				WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass79_0>.NativeClassPtr, "<>4__this");
				WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass79_0>.NativeClassPtr, "output");
				WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeFieldInfoPtr_solved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass79_0>.NativeClassPtr, "solved");
				WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass79_0>.NativeClassPtr, 100674324);
				WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeMethodInfoPtr__OnOutputSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass79_0>.NativeClassPtr, 100674325);
				WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass79_0>.NativeClassPtr, 100674326);
			}

			// Token: 0x0600BB91 RID: 48017 RVA: 0x002F37DC File Offset: 0x002F19DC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass79_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass79_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB92 RID: 48018 RVA: 0x002F3818 File Offset: 0x002F1A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133793, XrefRangeEnd = 133803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnOutputSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeMethodInfoPtr__OnOutputSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB93 RID: 48019 RVA: 0x002F384C File Offset: 0x002F1A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133803, XrefRangeEnd = 133915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB94 RID: 48020 RVA: 0x00065275 File Offset: 0x00063475
			public __c__DisplayClass79_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D5A RID: 15706
			// (get) Token: 0x0600BB95 RID: 48021 RVA: 0x002F3880 File Offset: 0x002F1A80
			// (set) Token: 0x0600BB96 RID: 48022 RVA: 0x0006527E File Offset: 0x0006347E
			public unsafe WorkSceneCookingSelectionPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneCookingSelectionPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D5B RID: 15707
			// (get) Token: 0x0600BB97 RID: 48023 RVA: 0x002F38B0 File Offset: 0x002F1AB0
			// (set) Token: 0x0600BB98 RID: 48024 RVA: 0x0006529D File Offset: 0x0006349D
			public unsafe Sellable output
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeFieldInfoPtr_output);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeFieldInfoPtr_output), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D5C RID: 15708
			// (get) Token: 0x0600BB99 RID: 48025 RVA: 0x002F38E0 File Offset: 0x002F1AE0
			// (set) Token: 0x0600BB9A RID: 48026 RVA: 0x000652BC File Offset: 0x000634BC
			public unsafe WorkSceneCookingSelectionPannel.MatchedCookCombo solved
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeFieldInfoPtr_solved);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneCookingSelectionPannel.MatchedCookCombo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass79_0.NativeFieldInfoPtr_solved), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007929 RID: 31017
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400792A RID: 31018
			private static readonly IntPtr NativeFieldInfoPtr_output;

			// Token: 0x0400792B RID: 31019
			private static readonly IntPtr NativeFieldInfoPtr_solved;

			// Token: 0x0400792C RID: 31020
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400792D RID: 31021
			private static readonly IntPtr NativeMethodInfoPtr__OnOutputSelected_b__0_Internal_Void_0;

			// Token: 0x0400792E RID: 31022
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x0200096D RID: 2413
		[ObfuscatedName("NightScene.UI.CookingUtility.WorkSceneCookingSelectionPannel+<>c__DisplayClass81_0")]
		public sealed class __c__DisplayClass81_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BB9B RID: 48027 RVA: 0x002F3910 File Offset: 0x002F1B10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass81_0()
			{
				Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass81_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel>.NativeClassPtr, "<>c__DisplayClass81_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass81_0>.NativeClassPtr);
				WorkSceneCookingSelectionPannel.__c__DisplayClass81_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass81_0>.NativeClassPtr, "<>4__this");
				WorkSceneCookingSelectionPannel.__c__DisplayClass81_0.NativeFieldInfoPtr_imported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass81_0>.NativeClassPtr, "imported");
				WorkSceneCookingSelectionPannel.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass81_0>.NativeClassPtr, 100674327);
				WorkSceneCookingSelectionPannel.__c__DisplayClass81_0.NativeMethodInfoPtr__MatchingSelected_b__0_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass81_0>.NativeClassPtr, 100674328);
				WorkSceneCookingSelectionPannel.__c__DisplayClass81_0.NativeMethodInfoPtr__MatchingSelected_b__1_Internal_Boolean_MatchedCookCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass81_0>.NativeClassPtr, 100674329);
			}

			// Token: 0x0600BB9C RID: 48028 RVA: 0x002F39A0 File Offset: 0x002F1BA0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass81_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneCookingSelectionPannel.__c__DisplayClass81_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BB9D RID: 48029 RVA: 0x002F39DC File Offset: 0x002F1BDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133915, XrefRangeEnd = 133920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MatchingSelected_b__0(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass81_0.NativeMethodInfoPtr__MatchingSelected_b__0_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BB9E RID: 48030 RVA: 0x002F3A2C File Offset: 0x002F1C2C
			[CallerCount(0)]
			public unsafe bool _MatchingSelected_b__1(WorkSceneCookingSelectionPannel.MatchedCookCombo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneCookingSelectionPannel.__c__DisplayClass81_0.NativeMethodInfoPtr__MatchingSelected_b__1_Internal_Boolean_MatchedCookCombo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BB9F RID: 48031 RVA: 0x000652DB File Offset: 0x000634DB
			public __c__DisplayClass81_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D5D RID: 15709
			// (get) Token: 0x0600BBA0 RID: 48032 RVA: 0x002F3A7C File Offset: 0x002F1C7C
			// (set) Token: 0x0600BBA1 RID: 48033 RVA: 0x000652E4 File Offset: 0x000634E4
			public unsafe WorkSceneCookingSelectionPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass81_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneCookingSelectionPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass81_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D5E RID: 15710
			// (get) Token: 0x0600BBA2 RID: 48034 RVA: 0x002F3AAC File Offset: 0x002F1CAC
			// (set) Token: 0x0600BBA3 RID: 48035 RVA: 0x00065303 File Offset: 0x00063503
			public unsafe Recipe imported
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass81_0.NativeFieldInfoPtr_imported);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneCookingSelectionPannel.__c__DisplayClass81_0.NativeFieldInfoPtr_imported), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400792F RID: 31023
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007930 RID: 31024
			private static readonly IntPtr NativeFieldInfoPtr_imported;

			// Token: 0x04007931 RID: 31025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007932 RID: 31026
			private static readonly IntPtr NativeMethodInfoPtr__MatchingSelected_b__0_Internal_Boolean_Recipe_0;

			// Token: 0x04007933 RID: 31027
			private static readonly IntPtr NativeMethodInfoPtr__MatchingSelected_b__1_Internal_Boolean_MatchedCookCombo_0;
		}
	}
}
