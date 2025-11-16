using System;
using System.Runtime.InteropServices;
using Common.UI;
using Common.UI.Filter;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.Core.UILogicalGroup;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core;
using GameData.Core.Collections;
using GameData.CoreLanguage;
using GameData.RunTime.Common;
using GameData.RunTime.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace PrepNightScene.UI
{
	// Token: 0x0200003D RID: 61
	public class IzakayaConfigPannel : UIPanelParamExternOpen<IPostExtraChecker>
	{
		// Token: 0x06000698 RID: 1688 RVA: 0x000B33FC File Offset: 0x000B15FC
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaConfigPannel()
		{
			Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "PrepNightScene.UI", "IzakayaConfigPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr);
			IzakayaConfigPannel.NativeFieldInfoPtr_LEVEL_1_RECOMMEND_NUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "LEVEL_1_RECOMMEND_NUM");
			IzakayaConfigPannel.NativeFieldInfoPtr_LEVEL_2_RECOMMEND_NUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "LEVEL_2_RECOMMEND_NUM");
			IzakayaConfigPannel.NativeFieldInfoPtr_LEVEL_3_RECOMMEND_NUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "LEVEL_3_RECOMMEND_NUM");
			IzakayaConfigPannel.NativeFieldInfoPtr_LINE_PADDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "LINE_PADDING");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_DailyRecipePrinter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_DailyRecipePrinter");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_DescriberSwitcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_DescriberSwitcher");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_ObjectStackParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_ObjectStackParent");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_RegisteredCookerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_RegisteredCookerParent");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageRecipeField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_InStorageRecipeField");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageBevField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_InStorageBevField");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageCookerField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_InStorageCookerField");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_RegisteredCookerField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_RegisteredCookerField");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_GotoWorkButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_GotoWorkButton");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_InStorageScroller");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_ItemBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_ItemBlocker");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_GotoWorkBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_GotoWorkBlocker");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_RecipeHighlighter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_RecipeHighlighter");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_BeverageHighlighter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_BeverageHighlighter");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_CookerHighlighter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_CookerHighlighter");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_Condition1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_Condition1");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_Condition2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_Condition2");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_Condition3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_Condition3");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_CondText1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_CondText1");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_CondText2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_CondText2");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_CondText3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_CondText3");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_NotFinishColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_NotFinishColor");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_FinishedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_FinishedColor");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_RequiredCooker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_RequiredCooker");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_RequiredCookerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_RequiredCookerCanvasGroup");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_RequiredIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_RequiredIngredients");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_WarningDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_WarningDialog");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_WarningContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_WarningContext");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_WarningContextStayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_WarningContextStayDuration");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_SubMenuBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_SubMenuBtn");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_SubPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_SubPanel");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_RemindSubPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_RemindSubPanel");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_BeveragesFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_BeveragesFilter");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_CookersFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_CookersFilter");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_FalseCookerRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_FalseCookerRecipe");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_LackBevergaes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_LackBevergaes");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_LackIngredientsRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_LackIngredientsRecipe");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_RecipeFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_RecipeFilter");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_WarningKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_WarningKey");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_BeverageGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_BeverageGroup");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_CookerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_CookerGroup");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_CurrentConfigType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_CurrentConfigType");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_CurrentGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_CurrentGroup");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageBevGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_InStorageBevGroup");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageCookerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_InStorageCookerGroup");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageRecipeGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_InStorageRecipeGroup");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_IzakayaConfigure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_IzakayaConfigure");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_RecipeGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_RecipeGroup");
			IzakayaConfigPannel.NativeFieldInfoPtr_showTipMessageTonight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "showTipMessageTonight");
			IzakayaConfigPannel.NativeFieldInfoPtr_m_TargetIzakayaConfigSubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "m_TargetIzakayaConfigSubPannel");
			IzakayaConfigPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664272);
			IzakayaConfigPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_IPostExtraChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664273);
			IzakayaConfigPannel.NativeMethodInfoPtr_LoadPreset_Public_Void_byref_HistoryIzakayaMenuSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664274);
			IzakayaConfigPannel.NativeMethodInfoPtr_LoadPresetInternal_Private_Static_Void_byref_HistoryIzakayaMenuSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664275);
			IzakayaConfigPannel.NativeMethodInfoPtr_GoToSpecific_Private_Void_CurrentConfigType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664276);
			IzakayaConfigPannel.NativeMethodInfoPtr_HighlightObject_Private_Static_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664277);
			IzakayaConfigPannel.NativeMethodInfoPtr_DeHighlightObject_Private_Static_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664278);
			IzakayaConfigPannel.NativeMethodInfoPtr_SolveDailyCompletion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664279);
			IzakayaConfigPannel.NativeMethodInfoPtr_GotoWork_Private_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664280);
			IzakayaConfigPannel.NativeMethodInfoPtr_OpenCurrentGroupFilter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664281);
			IzakayaConfigPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664282);
			IzakayaConfigPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664283);
			IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664284);
			IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664285);
			IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664286);
			IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_6_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664287);
			IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664288);
			IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_4_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664289);
			IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664290);
			IzakayaConfigPannel.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664291);
			IzakayaConfigPannel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664292);
			IzakayaConfigPannel.NativeMethodInfoPtr__OpenCurrentGroupFilter_b__63_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664293);
			IzakayaConfigPannel.NativeMethodInfoPtr__OpenCurrentGroupFilter_b__63_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664294);
			IzakayaConfigPannel.NativeMethodInfoPtr__OpenCurrentGroupFilter_b__63_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, 100664295);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x000B3A44 File Offset: 0x000B1C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28825, XrefRangeEnd = 29114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x000B3A80 File Offset: 0x000B1C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29114, XrefRangeEnd = 29149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(IPostExtraChecker extraChecker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(extraChecker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_IPostExtraChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000B3AD0 File Offset: 0x000B1CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29149, XrefRangeEnd = 29151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadPreset([In] ref PlayerSaveFile.HistoryIzakayaMenuSelection preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(preset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr_LoadPreset_Public_Void_byref_HistoryIzakayaMenuSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000B3B14 File Offset: 0x000B1D14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29234, RefRangeEnd = 29236, XrefRangeStart = 29151, XrefRangeEnd = 29234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadPresetInternal([In] ref PlayerSaveFile.HistoryIzakayaMenuSelection preset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(preset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr_LoadPresetInternal_Private_Static_Void_byref_HistoryIzakayaMenuSelection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000B3B4C File Offset: 0x000B1D4C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 29351, RefRangeEnd = 29358, XrefRangeStart = 29236, XrefRangeEnd = 29351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToSpecific(IzakayaConfigPannel.CurrentConfigType currentConfigType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentConfigType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr_GoToSpecific_Private_Void_CurrentConfigType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000B3B8C File Offset: 0x000B1D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29358, XrefRangeEnd = 29362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HighlightObject(CanvasGroup visual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr_HighlightObject_Private_Static_Void_CanvasGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000B3BC4 File Offset: 0x000B1DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29362, XrefRangeEnd = 29366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeHighlightObject(CanvasGroup visual)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr_DeHighlightObject_Private_Static_Void_CanvasGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000B3BFC File Offset: 0x000B1DFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 29546, RefRangeEnd = 29550, XrefRangeStart = 29366, XrefRangeEnd = 29546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SolveDailyCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr_SolveDailyCompletion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000B3C30 File Offset: 0x000B1E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29567, RefRangeEnd = 29568, XrefRangeStart = 29550, XrefRangeEnd = 29567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask GotoWork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr_GotoWork_Private_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000B3C68 File Offset: 0x000B1E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29602, RefRangeEnd = 29603, XrefRangeStart = 29568, XrefRangeEnd = 29602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenCurrentGroupFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr_OpenCurrentGroupFilter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x000B3C9C File Offset: 0x000B1E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29603, XrefRangeEnd = 29660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000B3CD8 File Offset: 0x000B1ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29660, XrefRangeEnd = 29707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaConfigPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x000B3D14 File Offset: 0x000B1F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29707, XrefRangeEnd = 29708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SolveDailyCompletion_b__61_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000B3D48 File Offset: 0x000B1F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29708, XrefRangeEnd = 29709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SolveDailyCompletion_b__61_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000B3D7C File Offset: 0x000B1F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29709, XrefRangeEnd = 29710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SolveDailyCompletion_b__61_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x000B3DB0 File Offset: 0x000B1FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29710, XrefRangeEnd = 29712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SolveDailyCompletion_b__61_6(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_6_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000B3DF0 File Offset: 0x000B1FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29712, XrefRangeEnd = 29714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SolveDailyCompletion_b__61_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000B3E24 File Offset: 0x000B2024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SolveDailyCompletion_b__61_4(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_4_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x000B3E64 File Offset: 0x000B2064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29714, XrefRangeEnd = 29756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SolveDailyCompletion_b__61_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr__SolveDailyCompletion_b__61_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000B3E98 File Offset: 0x000B2098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29756, XrefRangeEnd = 29764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x000B3ECC File Offset: 0x000B20CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29764, XrefRangeEnd = 29769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x000B3F0C File Offset: 0x000B210C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29769, XrefRangeEnd = 29777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenCurrentGroupFilter_b__63_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr__OpenCurrentGroupFilter_b__63_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x000B3F40 File Offset: 0x000B2140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29777, XrefRangeEnd = 29785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenCurrentGroupFilter_b__63_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr__OpenCurrentGroupFilter_b__63_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000B3F74 File Offset: 0x000B2174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29785, XrefRangeEnd = 29793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenCurrentGroupFilter_b__63_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.NativeMethodInfoPtr__OpenCurrentGroupFilter_b__63_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00005D9D File Offset: 0x00003F9D
		public IzakayaConfigPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x000B3FA8 File Offset: 0x000B21A8
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00005DA6 File Offset: 0x00003FA6
		public unsafe static int LEVEL_1_RECOMMEND_NUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.NativeFieldInfoPtr_LEVEL_1_RECOMMEND_NUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.NativeFieldInfoPtr_LEVEL_1_RECOMMEND_NUM, (void*)(&value));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x000B3FC4 File Offset: 0x000B21C4
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00005DB4 File Offset: 0x00003FB4
		public unsafe static int LEVEL_2_RECOMMEND_NUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.NativeFieldInfoPtr_LEVEL_2_RECOMMEND_NUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.NativeFieldInfoPtr_LEVEL_2_RECOMMEND_NUM, (void*)(&value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x000B3FE0 File Offset: 0x000B21E0
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x00005DC2 File Offset: 0x00003FC2
		public unsafe static int LEVEL_3_RECOMMEND_NUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.NativeFieldInfoPtr_LEVEL_3_RECOMMEND_NUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.NativeFieldInfoPtr_LEVEL_3_RECOMMEND_NUM, (void*)(&value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x000B3FFC File Offset: 0x000B21FC
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x00005DD0 File Offset: 0x00003FD0
		public unsafe static string LINE_PADDING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.NativeFieldInfoPtr_LINE_PADDING, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.NativeFieldInfoPtr_LINE_PADDING, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x000B401C File Offset: 0x000B221C
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x00005DE2 File Offset: 0x00003FE2
		public unsafe DailyRecipePrinterNew m_DailyRecipePrinter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_DailyRecipePrinter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyRecipePrinterNew>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_DailyRecipePrinter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x000B404C File Offset: 0x000B224C
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x00005E01 File Offset: 0x00004001
		public unsafe DescriberSwitcher m_DescriberSwitcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_DescriberSwitcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DescriberSwitcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_DescriberSwitcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x000B407C File Offset: 0x000B227C
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00005E20 File Offset: 0x00004020
		public unsafe GameObject m_ObjectStackParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_ObjectStackParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_ObjectStackParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x000B40AC File Offset: 0x000B22AC
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00005E3F File Offset: 0x0000403F
		public unsafe GameObject m_RegisteredCookerParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RegisteredCookerParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RegisteredCookerParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x000B40DC File Offset: 0x000B22DC
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x00005E5E File Offset: 0x0000405E
		public unsafe GridLayoutGroup m_InStorageRecipeField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageRecipeField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageRecipeField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x000B410C File Offset: 0x000B230C
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00005E7D File Offset: 0x0000407D
		public unsafe GridLayoutGroup m_InStorageBevField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageBevField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageBevField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x000B413C File Offset: 0x000B233C
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00005E9C File Offset: 0x0000409C
		public unsafe GridLayoutGroup m_InStorageCookerField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageCookerField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageCookerField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x000B416C File Offset: 0x000B236C
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00005EBB File Offset: 0x000040BB
		public unsafe GridLayoutGroup m_RegisteredCookerField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RegisteredCookerField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RegisteredCookerField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x000B419C File Offset: 0x000B239C
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x00005EDA File Offset: 0x000040DA
		public unsafe UIButtonHold m_GotoWorkButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_GotoWorkButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_GotoWorkButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x000B41CC File Offset: 0x000B23CC
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x00005EF9 File Offset: 0x000040F9
		public unsafe AdpProgressIndicatorComponent m_InStorageScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x000B41FC File Offset: 0x000B23FC
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x00005F18 File Offset: 0x00004118
		public unsafe CanvasGroup m_ItemBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_ItemBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_ItemBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x000B422C File Offset: 0x000B242C
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x00005F37 File Offset: 0x00004137
		public unsafe CanvasGroup m_GotoWorkBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_GotoWorkBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_GotoWorkBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x000B425C File Offset: 0x000B245C
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x00005F56 File Offset: 0x00004156
		public unsafe CanvasGroup m_RecipeHighlighter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RecipeHighlighter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RecipeHighlighter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x000B428C File Offset: 0x000B248C
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00005F75 File Offset: 0x00004175
		public unsafe CanvasGroup m_BeverageHighlighter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_BeverageHighlighter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_BeverageHighlighter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x000B42BC File Offset: 0x000B24BC
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00005F94 File Offset: 0x00004194
		public unsafe CanvasGroup m_CookerHighlighter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CookerHighlighter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CookerHighlighter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x000B42EC File Offset: 0x000B24EC
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00005FB3 File Offset: 0x000041B3
		public unsafe Image m_Condition1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_Condition1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_Condition1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x000B431C File Offset: 0x000B251C
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x00005FD2 File Offset: 0x000041D2
		public unsafe Image m_Condition2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_Condition2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_Condition2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x000B434C File Offset: 0x000B254C
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00005FF1 File Offset: 0x000041F1
		public unsafe Image m_Condition3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_Condition3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_Condition3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x000B437C File Offset: 0x000B257C
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00006010 File Offset: 0x00004210
		public unsafe TextMeshProUGUI m_CondText1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CondText1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CondText1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x000B43AC File Offset: 0x000B25AC
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x0000602F File Offset: 0x0000422F
		public unsafe TextMeshProUGUI m_CondText2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CondText2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CondText2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x000B43DC File Offset: 0x000B25DC
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x0000604E File Offset: 0x0000424E
		public unsafe TextMeshProUGUI m_CondText3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CondText3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CondText3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x000B440C File Offset: 0x000B260C
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x0000606D File Offset: 0x0000426D
		public unsafe Color32 m_NotFinishColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_NotFinishColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_NotFinishColor)) = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x000B4434 File Offset: 0x000B2634
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00006088 File Offset: 0x00004288
		public unsafe Color32 m_FinishedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_FinishedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_FinishedColor)) = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x000B445C File Offset: 0x000B265C
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x000060A3 File Offset: 0x000042A3
		public unsafe Image m_RequiredCooker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RequiredCooker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RequiredCooker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x000B448C File Offset: 0x000B268C
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x000060C2 File Offset: 0x000042C2
		public unsafe CanvasGroup m_RequiredCookerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RequiredCookerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RequiredCookerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x000B44BC File Offset: 0x000B26BC
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x000060E1 File Offset: 0x000042E1
		public unsafe Il2CppReferenceArray<Image> m_RequiredIngredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RequiredIngredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RequiredIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x000B44EC File Offset: 0x000B26EC
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00006100 File Offset: 0x00004300
		public unsafe CanvasGroup m_WarningDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_WarningDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_WarningDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x000B451C File Offset: 0x000B271C
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x0000611F File Offset: 0x0000431F
		public unsafe TextMeshProUGUI m_WarningContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_WarningContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_WarningContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x000B454C File Offset: 0x000B274C
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x0000613E File Offset: 0x0000433E
		public unsafe float m_WarningContextStayDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_WarningContextStayDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_WarningContextStayDuration)) = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x000B4574 File Offset: 0x000B2774
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x00006159 File Offset: 0x00004359
		public unsafe UIButtonSimple m_SubMenuBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_SubMenuBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_SubMenuBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x000B45A4 File Offset: 0x000B27A4
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x00006178 File Offset: 0x00004378
		public unsafe IzakayaConfigSubPannel m_SubPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_SubPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_SubPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x000B45D4 File Offset: 0x000B27D4
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x00006197 File Offset: 0x00004397
		public unsafe RemindSubPanel m_RemindSubPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RemindSubPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemindSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RemindSubPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x000B4604 File Offset: 0x000B2804
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x000061B6 File Offset: 0x000043B6
		public unsafe List<IFilterConfig> m_BeveragesFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_BeveragesFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_BeveragesFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x000B4634 File Offset: 0x000B2834
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x000061D5 File Offset: 0x000043D5
		public unsafe List<IFilterConfig> m_CookersFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CookersFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CookersFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x000B4664 File Offset: 0x000B2864
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x000061F4 File Offset: 0x000043F4
		public unsafe Dictionary<Cooker.CookerType, List<Recipe>> m_FalseCookerRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_FalseCookerRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Cooker.CookerType, List<Recipe>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_FalseCookerRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x000B4694 File Offset: 0x000B2894
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x00006213 File Offset: 0x00004413
		public unsafe List<Sellable> m_LackBevergaes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_LackBevergaes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_LackBevergaes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x000B46C4 File Offset: 0x000B28C4
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x00006232 File Offset: 0x00004432
		public unsafe List<Sellable> m_LackIngredientsRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_LackIngredientsRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_LackIngredientsRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x000B46F4 File Offset: 0x000B28F4
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00006251 File Offset: 0x00004451
		public unsafe List<IFilterConfig> m_RecipeFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RecipeFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RecipeFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x000B4724 File Offset: 0x000B2924
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00006270 File Offset: 0x00004470
		public unsafe List<ValueTuple<string, Action>> m_WarningKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_WarningKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, Action>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_WarningKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x000B4754 File Offset: 0x000B2954
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x0000628F File Offset: 0x0000448F
		public unsafe IzakayaConfigPannel.SellableGroup<Sellable> m_BeverageGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_BeverageGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.SellableGroup<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_BeverageGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x000B4784 File Offset: 0x000B2984
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x000062AE File Offset: 0x000044AE
		public unsafe IzakayaConfigPannel.CookerGroup m_CookerGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CookerGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.CookerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CookerGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x000B47B4 File Offset: 0x000B29B4
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x000062CD File Offset: 0x000044CD
		public unsafe IzakayaConfigPannel.CurrentConfigType m_CurrentConfigType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CurrentConfigType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CurrentConfigType)) = value;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x000B47DC File Offset: 0x000B29DC
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x000062E8 File Offset: 0x000044E8
		public unsafe IzakayaConfigPannel.IGroup m_CurrentGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CurrentGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.IGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_CurrentGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x000B480C File Offset: 0x000B2A0C
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00006307 File Offset: 0x00004507
		public unsafe CanvasGroup m_InStorageBevGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageBevGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageBevGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x000B483C File Offset: 0x000B2A3C
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x00006326 File Offset: 0x00004526
		public unsafe CanvasGroup m_InStorageCookerGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageCookerGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageCookerGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x000B486C File Offset: 0x000B2A6C
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00006345 File Offset: 0x00004545
		public unsafe CanvasGroup m_InStorageRecipeGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageRecipeGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_InStorageRecipeGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x000B489C File Offset: 0x000B2A9C
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00006364 File Offset: 0x00004564
		public unsafe IzakayaConfigure m_IzakayaConfigure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_IzakayaConfigure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigure>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_IzakayaConfigure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x000B48CC File Offset: 0x000B2ACC
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00006383 File Offset: 0x00004583
		public unsafe IzakayaConfigPannel.SellableGroup<Recipe> m_RecipeGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RecipeGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.SellableGroup<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_RecipeGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x000B48FC File Offset: 0x000B2AFC
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x000063A2 File Offset: 0x000045A2
		public unsafe bool showTipMessageTonight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_showTipMessageTonight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_showTipMessageTonight)) = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000B4924 File Offset: 0x000B2B24
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x000063BD File Offset: 0x000045BD
		public unsafe UISubPanel<IzakayaConfigPannel> m_TargetIzakayaConfigSubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_TargetIzakayaConfigSubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISubPanel<IzakayaConfigPannel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.NativeFieldInfoPtr_m_TargetIzakayaConfigSubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_LEVEL_1_RECOMMEND_NUM;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_LEVEL_2_RECOMMEND_NUM;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr_LEVEL_3_RECOMMEND_NUM;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeFieldInfoPtr_LINE_PADDING;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeFieldInfoPtr_m_DailyRecipePrinter;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberSwitcher;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectStackParent;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeFieldInfoPtr_m_RegisteredCookerParent;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr_m_InStorageRecipeField;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr_m_InStorageBevField;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_m_InStorageCookerField;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr_m_RegisteredCookerField;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoWorkButton;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeFieldInfoPtr_m_InStorageScroller;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemBlocker;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoWorkBlocker;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeHighlighter;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr_m_BeverageHighlighter;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerHighlighter;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr_m_Condition1;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_m_Condition2;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_m_Condition3;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr_m_CondText1;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr_m_CondText2;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr_m_CondText3;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeFieldInfoPtr_m_NotFinishColor;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr_m_FinishedColor;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeFieldInfoPtr_m_RequiredCooker;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr_m_RequiredCookerCanvasGroup;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr_m_RequiredIngredients;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_m_WarningDialog;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeFieldInfoPtr_m_WarningContext;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr_m_WarningContextStayDuration;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeFieldInfoPtr_m_SubMenuBtn;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeFieldInfoPtr_m_SubPanel;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeFieldInfoPtr_m_RemindSubPanel;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr_m_BeveragesFilter;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr_m_CookersFilter;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr_m_FalseCookerRecipe;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr_m_LackBevergaes;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeFieldInfoPtr_m_LackIngredientsRecipe;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeFilter;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeFieldInfoPtr_m_WarningKey;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeFieldInfoPtr_m_BeverageGroup;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerGroup;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentConfigType;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentGroup;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeFieldInfoPtr_m_InStorageBevGroup;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeFieldInfoPtr_m_InStorageCookerGroup;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeFieldInfoPtr_m_InStorageRecipeGroup;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr_m_IzakayaConfigure;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeGroup;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeFieldInfoPtr_showTipMessageTonight;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetIzakayaConfigSubPannel;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_IPostExtraChecker_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_LoadPreset_Public_Void_byref_HistoryIzakayaMenuSelection_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_LoadPresetInternal_Private_Static_Void_byref_HistoryIzakayaMenuSelection_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_GoToSpecific_Private_Void_CurrentConfigType_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_HighlightObject_Private_Static_Void_CanvasGroup_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_DeHighlightObject_Private_Static_Void_CanvasGroup_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_SolveDailyCompletion_Private_Void_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_GotoWork_Private_UniTask_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_OpenCurrentGroupFilter_Public_Void_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__61_1_Private_Void_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__61_2_Private_Void_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__61_3_Private_Void_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__61_6_Private_Void_Single_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__61_7_Private_Void_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__61_4_Private_Void_Single_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__61_5_Private_Void_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr__OpenCurrentGroupFilter_b__63_0_Private_Void_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr__OpenCurrentGroupFilter_b__63_1_Private_Void_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr__OpenCurrentGroupFilter_b__63_2_Private_Void_0;

		// Token: 0x020004DA RID: 1242
		public enum CurrentConfigType
		{
			// Token: 0x040054BE RID: 21694
			Recipe,
			// Token: 0x040054BF RID: 21695
			Beverage,
			// Token: 0x040054C0 RID: 21696
			Cooker
		}

		// Token: 0x020004DB RID: 1243
		public class IGroup : Il2CppObjectBase
		{
			// Token: 0x06008156 RID: 33110 RVA: 0x00045EA3 File Offset: 0x000440A3
			// Note: this type is marked as 'beforefieldinit'.
			static IGroup()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.IGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "IGroup");
				IzakayaConfigPannel.IGroup.NativeMethodInfoPtr_EnterGroup_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.IGroup>.NativeClassPtr, 100664296);
				IzakayaConfigPannel.IGroup.NativeMethodInfoPtr_ExitGroup_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.IGroup>.NativeClassPtr, 100664297);
			}

			// Token: 0x06008157 RID: 33111 RVA: 0x002484C8 File Offset: 0x002466C8
			[CallerCount(0)]
			public unsafe virtual void EnterGroup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.IGroup.NativeMethodInfoPtr_EnterGroup_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008158 RID: 33112 RVA: 0x00248504 File Offset: 0x00246704
			[CallerCount(0)]
			public unsafe virtual void ExitGroup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.IGroup.NativeMethodInfoPtr_ExitGroup_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008159 RID: 33113 RVA: 0x00045EE1 File Offset: 0x000440E1
			public IGroup(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x040054C1 RID: 21697
			private static readonly IntPtr NativeMethodInfoPtr_EnterGroup_Public_Abstract_Virtual_New_Void_0;

			// Token: 0x040054C2 RID: 21698
			private static readonly IntPtr NativeMethodInfoPtr_ExitGroup_Public_Abstract_Virtual_New_Void_0;
		}

		// Token: 0x020004DC RID: 1244
		public class GroupBase<TInStorageInfo, TRegisteredInfo> : Il2CppSystem.Object where TInStorageInfo : NonTradableObjectBase
		{
			// Token: 0x0600815A RID: 33114 RVA: 0x00248540 File Offset: 0x00246740
			// Note: this type is marked as 'beforefieldinit'.
			static GroupBase()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "GroupBase`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInStorageInfo>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRegisteredInfo>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_DeRegisterDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "m_DeRegisterDataCallback");
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_DescribeObjectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "m_DescribeObjectCallback");
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_DescribeRegisteredObjectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "m_DescribeRegisteredObjectCallback");
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_Filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "m_Filter");
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_GetCanAddMoreCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "m_GetCanAddMoreCallback");
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_GetPinnedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "m_GetPinnedCallback");
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_RegisterDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "m_RegisterDataCallback");
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_SolveDailyCompletionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "m_SolveDailyCompletionCallback");
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_ToggleInStorageBlockerCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "m_ToggleInStorageBlockerCallback");
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_GetAmountCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "GetAmountCallback");
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_InStorageGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "InStorageGroup");
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_RegisteredGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "RegisteredGroup");
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr__ctor_Protected_Void_Func_2_Int32_Boolean_Func_1_Boolean_Action_1_Boolean_Action_1_TRegisteredInfo_Action_1_TInStorageInfo_Action_1_TRegisteredInfo_Action_1_TRegisteredInfo_Action_List_1_IFilterConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664298);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_get_RegisteredElementCount_Protected_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664299);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_OnInStorageElementSelected_Protected_Void_TInStorageInfo_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664300);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_UpdateAndTrySelectInStorageGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664301);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_GetRegisterInfoKey_Protected_Abstract_Virtual_New_TRegisteredInfo_TInStorageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664302);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_OnRegisteredElementSelected_Protected_Void_TRegisteredInfo_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664303);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_UpdateAndTrySelectRegisteredGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664304);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_DescribeInStorageObjectCallback_Protected_Void_TInStorageInfo_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664305);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_UpdateGroupRaw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664306);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_UpdateGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664307);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_OnUpdateGroup_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664308);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_ExitGroup_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664309);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_EnterGroup_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664310);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_OnRegisteredCustomLoop_Protected_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664311);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_ProcessInStorageEdgeElementCallback_Protected_Void_UIButtonSimple_BorderElementType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664312);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_TryNavigateToInStorage_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664313);
				IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr__ProcessInStorageEdgeElementCallback_b__27_0_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, 100664314);
			}

			// Token: 0x0600815B RID: 33115 RVA: 0x002487FC File Offset: 0x002469FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27599, RefRangeEnd = 27600, XrefRangeStart = 27581, XrefRangeEnd = 27599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GroupBase(Func<int, bool> getPinnedCallback, Func<bool> getCanAddMoreCallback, Action<bool> toggleInStorageBlockerCallback, Action<TRegisteredInfo> registerDataCallback, Action<TInStorageInfo> describeObjectCallback, Action<TRegisteredInfo> describeRegisteredObjectCallback, Action<TRegisteredInfo> deRegisterDataCallback, Action solveDailyCompletionCallback, List<IFilterConfig> filter) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getPinnedCallback);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getCanAddMoreCallback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toggleInStorageBlockerCallback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(registerDataCallback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describeObjectCallback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describeRegisteredObjectCallback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deRegisterDataCallback);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(solveDailyCompletionCallback);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr__ctor_Protected_Void_Func_2_Int32_Boolean_Func_1_Boolean_Action_1_Boolean_Action_1_TRegisteredInfo_Action_1_TInStorageInfo_Action_1_TRegisteredInfo_Action_1_TRegisteredInfo_Action_List_1_IFilterConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002BAC RID: 11180
			// (get) Token: 0x0600815C RID: 33116 RVA: 0x002488E0 File Offset: 0x00246AE0
			public unsafe virtual int RegisteredElementCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_get_RegisteredElementCount_Protected_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600815D RID: 33117 RVA: 0x00248928 File Offset: 0x00246B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27600, XrefRangeEnd = 27637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnInStorageElementSelected(TInStorageInfo value, UIElementCluster cluster, UIButtonSimple btn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TInStorageInfo).IsValueType)
				{
					TInStorageInfo tinStorageInfo = value;
					intPtr = ((tinStorageInfo is string) ? IL2CPP.ManagedStringToIl2Cpp(tinStorageInfo as string) : IL2CPP.Il2CppObjectBaseToPtr(tinStorageInfo as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(btn);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_OnInStorageElementSelected_Protected_Void_TInStorageInfo_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x0600815E RID: 33118 RVA: 0x002489C4 File Offset: 0x00246BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27637, XrefRangeEnd = 27658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateAndTrySelectInStorageGroup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_UpdateAndTrySelectInStorageGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600815F RID: 33119 RVA: 0x002489F8 File Offset: 0x00246BF8
			[CallerCount(0)]
			public unsafe virtual TRegisteredInfo GetRegisterInfoKey(TInStorageInfo value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TInStorageInfo).IsValueType)
				{
					TInStorageInfo tinStorageInfo = value;
					intPtr = ((tinStorageInfo is string) ? IL2CPP.ManagedStringToIl2Cpp(tinStorageInfo as string) : IL2CPP.Il2CppObjectBaseToPtr(tinStorageInfo as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_GetRegisterInfoKey_Protected_Abstract_Virtual_New_TRegisteredInfo_TInStorageInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TRegisteredInfo>(intPtr2, false, true);
			}

			// Token: 0x06008160 RID: 33120 RVA: 0x00248A84 File Offset: 0x00246C84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27658, XrefRangeEnd = 27667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnRegisteredElementSelected(TRegisteredInfo tValue, UIElementCluster ui, UIButtonSimple btn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TRegisteredInfo).IsValueType)
				{
					TRegisteredInfo tregisteredInfo = tValue;
					intPtr = ((tregisteredInfo is string) ? IL2CPP.ManagedStringToIl2Cpp(tregisteredInfo as string) : IL2CPP.Il2CppObjectBaseToPtr(tregisteredInfo as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref tValue;
				}
				ptr2 = intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(btn);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_OnRegisteredElementSelected_Protected_Void_TRegisteredInfo_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x06008161 RID: 33121 RVA: 0x00248B20 File Offset: 0x00246D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27667, XrefRangeEnd = 27674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateAndTrySelectRegisteredGroup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_UpdateAndTrySelectRegisteredGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008162 RID: 33122 RVA: 0x00248B54 File Offset: 0x00246D54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27674, XrefRangeEnd = 27675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DescribeInStorageObjectCallback(TInStorageInfo value, UIElementCluster cluster, UIButtonSimple btn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TInStorageInfo).IsValueType)
				{
					TInStorageInfo tinStorageInfo = value;
					intPtr = ((tinStorageInfo is string) ? IL2CPP.ManagedStringToIl2Cpp(tinStorageInfo as string) : IL2CPP.Il2CppObjectBaseToPtr(tinStorageInfo as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(btn);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_DescribeInStorageObjectCallback_Protected_Void_TInStorageInfo_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x06008163 RID: 33123 RVA: 0x00248BF0 File Offset: 0x00246DF0
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 27675, RefRangeEnd = 27686, XrefRangeStart = 27675, XrefRangeEnd = 27675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateGroupRaw()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_UpdateGroupRaw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008164 RID: 33124 RVA: 0x00248C24 File Offset: 0x00246E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27686, XrefRangeEnd = 27705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateGroup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_UpdateGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008165 RID: 33125 RVA: 0x00248C58 File Offset: 0x00246E58
			[CallerCount(0)]
			public unsafe virtual void OnUpdateGroup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_OnUpdateGroup_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008166 RID: 33126 RVA: 0x00248C94 File Offset: 0x00246E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27705, XrefRangeEnd = 27709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void ExitGroup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_ExitGroup_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008167 RID: 33127 RVA: 0x00248CC8 File Offset: 0x00246EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27709, XrefRangeEnd = 27725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void EnterGroup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_EnterGroup_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008168 RID: 33128 RVA: 0x00248CFC File Offset: 0x00246EFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27725, XrefRangeEnd = 27731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnRegisteredCustomLoop(int rowIndex, MoveDirection moveDirection)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref rowIndex;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveDirection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_OnRegisteredCustomLoop_Protected_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008169 RID: 33129 RVA: 0x00248D48 File Offset: 0x00246F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27731, XrefRangeEnd = 27739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ProcessInStorageEdgeElementCallback(UIButtonSimple ui, AdpUISystemUtils.BorderElementType borderElementType, int columnIndex, int rowIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderElementType;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref columnIndex;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rowIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_ProcessInStorageEdgeElementCallback_Protected_Void_UIButtonSimple_BorderElementType_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600816A RID: 33130 RVA: 0x00248DB4 File Offset: 0x00246FB4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27744, RefRangeEnd = 27745, XrefRangeStart = 27739, XrefRangeEnd = 27744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void TryNavigateToInStorage()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr_TryNavigateToInStorage_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600816B RID: 33131 RVA: 0x00248DE8 File Offset: 0x00246FE8
			[CallerCount(0)]
			public unsafe void _ProcessInStorageEdgeElementCallback_b__27_0(MoveDirection direction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeMethodInfoPtr__ProcessInStorageEdgeElementCallback_b__27_0_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600816C RID: 33132 RVA: 0x00045EEA File Offset: 0x000440EA
			public GroupBase(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BA0 RID: 11168
			// (get) Token: 0x0600816D RID: 33133 RVA: 0x00248E28 File Offset: 0x00247028
			// (set) Token: 0x0600816E RID: 33134 RVA: 0x00045EF3 File Offset: 0x000440F3
			public unsafe Action<TRegisteredInfo> m_DeRegisterDataCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_DeRegisterDataCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TRegisteredInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_DeRegisterDataCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA1 RID: 11169
			// (get) Token: 0x0600816F RID: 33135 RVA: 0x00248E58 File Offset: 0x00247058
			// (set) Token: 0x06008170 RID: 33136 RVA: 0x00045F12 File Offset: 0x00044112
			public unsafe Action<TInStorageInfo> m_DescribeObjectCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_DescribeObjectCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TInStorageInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_DescribeObjectCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA2 RID: 11170
			// (get) Token: 0x06008171 RID: 33137 RVA: 0x00248E88 File Offset: 0x00247088
			// (set) Token: 0x06008172 RID: 33138 RVA: 0x00045F31 File Offset: 0x00044131
			public unsafe Action<TRegisteredInfo> m_DescribeRegisteredObjectCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_DescribeRegisteredObjectCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TRegisteredInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_DescribeRegisteredObjectCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA3 RID: 11171
			// (get) Token: 0x06008173 RID: 33139 RVA: 0x00248EB8 File Offset: 0x002470B8
			// (set) Token: 0x06008174 RID: 33140 RVA: 0x00045F50 File Offset: 0x00044150
			public unsafe List<IFilterConfig> m_Filter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_Filter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_Filter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA4 RID: 11172
			// (get) Token: 0x06008175 RID: 33141 RVA: 0x00248EE8 File Offset: 0x002470E8
			// (set) Token: 0x06008176 RID: 33142 RVA: 0x00045F6F File Offset: 0x0004416F
			public unsafe Func<bool> m_GetCanAddMoreCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_GetCanAddMoreCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_GetCanAddMoreCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA5 RID: 11173
			// (get) Token: 0x06008177 RID: 33143 RVA: 0x00248F18 File Offset: 0x00247118
			// (set) Token: 0x06008178 RID: 33144 RVA: 0x00045F8E File Offset: 0x0004418E
			public unsafe Func<int, bool> m_GetPinnedCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_GetPinnedCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_GetPinnedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA6 RID: 11174
			// (get) Token: 0x06008179 RID: 33145 RVA: 0x00248F48 File Offset: 0x00247148
			// (set) Token: 0x0600817A RID: 33146 RVA: 0x00045FAD File Offset: 0x000441AD
			public unsafe Action<TRegisteredInfo> m_RegisterDataCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_RegisterDataCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TRegisteredInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_RegisterDataCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA7 RID: 11175
			// (get) Token: 0x0600817B RID: 33147 RVA: 0x00248F78 File Offset: 0x00247178
			// (set) Token: 0x0600817C RID: 33148 RVA: 0x00045FCC File Offset: 0x000441CC
			public unsafe Action m_SolveDailyCompletionCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_SolveDailyCompletionCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_SolveDailyCompletionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA8 RID: 11176
			// (get) Token: 0x0600817D RID: 33149 RVA: 0x00248FA8 File Offset: 0x002471A8
			// (set) Token: 0x0600817E RID: 33150 RVA: 0x00045FEB File Offset: 0x000441EB
			public unsafe Action<bool> m_ToggleInStorageBlockerCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_ToggleInStorageBlockerCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_m_ToggleInStorageBlockerCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BA9 RID: 11177
			// (get) Token: 0x0600817F RID: 33151 RVA: 0x00248FD8 File Offset: 0x002471D8
			// (set) Token: 0x06008180 RID: 33152 RVA: 0x0004600A File Offset: 0x0004420A
			public unsafe Func<TInStorageInfo, int> GetAmountCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_GetAmountCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TInStorageInfo, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_GetAmountCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BAA RID: 11178
			// (get) Token: 0x06008181 RID: 33153 RVA: 0x00249008 File Offset: 0x00247208
			// (set) Token: 0x06008182 RID: 33154 RVA: 0x00046029 File Offset: 0x00044229
			public unsafe IStaticGridScrollListUILogicalGroupT<TInStorageInfo> InStorageGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_InStorageGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStaticGridScrollListUILogicalGroupT<TInStorageInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_InStorageGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BAB RID: 11179
			// (get) Token: 0x06008183 RID: 33155 RVA: 0x00249038 File Offset: 0x00247238
			// (set) Token: 0x06008184 RID: 33156 RVA: 0x00046048 File Offset: 0x00044248
			public unsafe StaticHorizontalGridScrollListUILogicalGroupT<TRegisteredInfo, UIElementCluster, UIButtonSimple> RegisteredGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_RegisteredGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticHorizontalGridScrollListUILogicalGroupT<TRegisteredInfo, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.NativeFieldInfoPtr_RegisteredGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040054C3 RID: 21699
			private static readonly IntPtr NativeFieldInfoPtr_m_DeRegisterDataCallback;

			// Token: 0x040054C4 RID: 21700
			private static readonly IntPtr NativeFieldInfoPtr_m_DescribeObjectCallback;

			// Token: 0x040054C5 RID: 21701
			private static readonly IntPtr NativeFieldInfoPtr_m_DescribeRegisteredObjectCallback;

			// Token: 0x040054C6 RID: 21702
			private static readonly IntPtr NativeFieldInfoPtr_m_Filter;

			// Token: 0x040054C7 RID: 21703
			private static readonly IntPtr NativeFieldInfoPtr_m_GetCanAddMoreCallback;

			// Token: 0x040054C8 RID: 21704
			private static readonly IntPtr NativeFieldInfoPtr_m_GetPinnedCallback;

			// Token: 0x040054C9 RID: 21705
			private static readonly IntPtr NativeFieldInfoPtr_m_RegisterDataCallback;

			// Token: 0x040054CA RID: 21706
			private static readonly IntPtr NativeFieldInfoPtr_m_SolveDailyCompletionCallback;

			// Token: 0x040054CB RID: 21707
			private static readonly IntPtr NativeFieldInfoPtr_m_ToggleInStorageBlockerCallback;

			// Token: 0x040054CC RID: 21708
			private static readonly IntPtr NativeFieldInfoPtr_GetAmountCallback;

			// Token: 0x040054CD RID: 21709
			private static readonly IntPtr NativeFieldInfoPtr_InStorageGroup;

			// Token: 0x040054CE RID: 21710
			private static readonly IntPtr NativeFieldInfoPtr_RegisteredGroup;

			// Token: 0x040054CF RID: 21711
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Func_2_Int32_Boolean_Func_1_Boolean_Action_1_Boolean_Action_1_TRegisteredInfo_Action_1_TInStorageInfo_Action_1_TRegisteredInfo_Action_1_TRegisteredInfo_Action_List_1_IFilterConfig_0;

			// Token: 0x040054D0 RID: 21712
			private static readonly IntPtr NativeMethodInfoPtr_get_RegisteredElementCount_Protected_Abstract_Virtual_New_get_Int32_0;

			// Token: 0x040054D1 RID: 21713
			private static readonly IntPtr NativeMethodInfoPtr_OnInStorageElementSelected_Protected_Void_TInStorageInfo_UIElementCluster_UIButtonSimple_0;

			// Token: 0x040054D2 RID: 21714
			private static readonly IntPtr NativeMethodInfoPtr_UpdateAndTrySelectInStorageGroup_Private_Void_0;

			// Token: 0x040054D3 RID: 21715
			private static readonly IntPtr NativeMethodInfoPtr_GetRegisterInfoKey_Protected_Abstract_Virtual_New_TRegisteredInfo_TInStorageInfo_0;

			// Token: 0x040054D4 RID: 21716
			private static readonly IntPtr NativeMethodInfoPtr_OnRegisteredElementSelected_Protected_Void_TRegisteredInfo_UIElementCluster_UIButtonSimple_0;

			// Token: 0x040054D5 RID: 21717
			private static readonly IntPtr NativeMethodInfoPtr_UpdateAndTrySelectRegisteredGroup_Private_Void_0;

			// Token: 0x040054D6 RID: 21718
			private static readonly IntPtr NativeMethodInfoPtr_DescribeInStorageObjectCallback_Protected_Void_TInStorageInfo_UIElementCluster_UIButtonSimple_0;

			// Token: 0x040054D7 RID: 21719
			private static readonly IntPtr NativeMethodInfoPtr_UpdateGroupRaw_Public_Void_0;

			// Token: 0x040054D8 RID: 21720
			private static readonly IntPtr NativeMethodInfoPtr_UpdateGroup_Private_Void_0;

			// Token: 0x040054D9 RID: 21721
			private static readonly IntPtr NativeMethodInfoPtr_OnUpdateGroup_Protected_Abstract_Virtual_New_Void_0;

			// Token: 0x040054DA RID: 21722
			private static readonly IntPtr NativeMethodInfoPtr_ExitGroup_Public_Virtual_Final_New_Void_0;

			// Token: 0x040054DB RID: 21723
			private static readonly IntPtr NativeMethodInfoPtr_EnterGroup_Public_Virtual_Final_New_Void_0;

			// Token: 0x040054DC RID: 21724
			private static readonly IntPtr NativeMethodInfoPtr_OnRegisteredCustomLoop_Protected_Void_Int32_MoveDirection_0;

			// Token: 0x040054DD RID: 21725
			private static readonly IntPtr NativeMethodInfoPtr_ProcessInStorageEdgeElementCallback_Protected_Void_UIButtonSimple_BorderElementType_Int32_Int32_0;

			// Token: 0x040054DE RID: 21726
			private static readonly IntPtr NativeMethodInfoPtr_TryNavigateToInStorage_Protected_Void_0;

			// Token: 0x040054DF RID: 21727
			private static readonly IntPtr NativeMethodInfoPtr__ProcessInStorageEdgeElementCallback_b__27_0_Private_Void_MoveDirection_0;

			// Token: 0x02000FAD RID: 4013
			[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+GroupBase`2+<>c__DisplayClass15_0")]
			public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
			{
				// Token: 0x060114E3 RID: 70883 RVA: 0x003FB79C File Offset: 0x003F999C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass15_0()
				{
					Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "<>c__DisplayClass15_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInStorageInfo>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRegisteredInfo>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0>.NativeClassPtr);
					IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0>.NativeClassPtr, "text");
					IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeFieldInfoPtr_amountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0>.NativeClassPtr, "amountText");
					IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
					IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0>.NativeClassPtr, "value");
					IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0>.NativeClassPtr, 100664315);
					IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeMethodInfoPtr__OnInStorageElementSelected_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0>.NativeClassPtr, 100664316);
					IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeMethodInfoPtr__OnInStorageElementSelected_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0>.NativeClassPtr, 100664317);
					IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeMethodInfoPtr__OnInStorageElementSelected_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0>.NativeClassPtr, 100664318);
					IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeMethodInfoPtr__OnInStorageElementSelected_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0>.NativeClassPtr, 100664319);
				}

				// Token: 0x060114E4 RID: 70884 RVA: 0x003FB8C8 File Offset: 0x003F9AC8
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114E5 RID: 70885 RVA: 0x003FB904 File Offset: 0x003F9B04
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27576, XrefRangeEnd = 27578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _OnInStorageElementSelected_b__0(Image x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeMethodInfoPtr__OnInStorageElementSelected_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114E6 RID: 70886 RVA: 0x003FB948 File Offset: 0x003F9B48
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _OnInStorageElementSelected_b__1(TextMeshProUGUI x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeMethodInfoPtr__OnInStorageElementSelected_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114E7 RID: 70887 RVA: 0x003FB98C File Offset: 0x003F9B8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _OnInStorageElementSelected_b__2(TextMeshProUGUI x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeMethodInfoPtr__OnInStorageElementSelected_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114E8 RID: 70888 RVA: 0x003FB9D0 File Offset: 0x003F9BD0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27578, XrefRangeEnd = 27579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _OnInStorageElementSelected_b__3()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeMethodInfoPtr__OnInStorageElementSelected_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114E9 RID: 70889 RVA: 0x000968CA File Offset: 0x00094ACA
				public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170059F6 RID: 23030
				// (get) Token: 0x060114EA RID: 70890 RVA: 0x003FBA04 File Offset: 0x003F9C04
				// (set) Token: 0x060114EB RID: 70891 RVA: 0x000968D3 File Offset: 0x00094AD3
				public unsafe ObjectLanguageBase text
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeFieldInfoPtr_text);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059F7 RID: 23031
				// (get) Token: 0x060114EC RID: 70892 RVA: 0x003FBA34 File Offset: 0x003F9C34
				// (set) Token: 0x060114ED RID: 70893 RVA: 0x000968F2 File Offset: 0x00094AF2
				public unsafe string amountText
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeFieldInfoPtr_amountText);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeFieldInfoPtr_amountText), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x170059F8 RID: 23032
				// (get) Token: 0x060114EE RID: 70894 RVA: 0x003FBA5C File Offset: 0x003F9C5C
				// (set) Token: 0x060114EF RID: 70895 RVA: 0x00096911 File Offset: 0x00094B11
				public unsafe IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo> __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059F9 RID: 23033
				// (get) Token: 0x060114F0 RID: 70896 RVA: 0x003FBA8C File Offset: 0x003F9C8C
				// (set) Token: 0x060114F1 RID: 70897 RVA: 0x003FBAB4 File Offset: 0x003F9CB4
				public unsafe TInStorageInfo value
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeFieldInfoPtr_value);
						return IL2CPP.PointerToValueGeneric<TInStorageInfo>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass15_0.NativeFieldInfoPtr_value);
						Type typeFromHandle = typeof(TInStorageInfo);
						if (!typeFromHandle.IsValueType)
						{
							if (!string.Equals(typeFromHandle.FullName, "System.String"))
							{
								IntPtr intPtr4;
								IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
								if (intPtr3 != 0)
								{
									intPtr4 = intPtr3;
									if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
									{
										IntPtr intPtr5 = intPtr3;
										cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
										return;
									}
								}
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
							}
							else
							{
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
							}
						}
						else
						{
							*intPtr2 = value;
						}
					}
				}

				// Token: 0x0400AEEE RID: 44782
				private static readonly IntPtr NativeFieldInfoPtr_text;

				// Token: 0x0400AEEF RID: 44783
				private static readonly IntPtr NativeFieldInfoPtr_amountText;

				// Token: 0x0400AEF0 RID: 44784
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AEF1 RID: 44785
				private static readonly IntPtr NativeFieldInfoPtr_value;

				// Token: 0x0400AEF2 RID: 44786
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AEF3 RID: 44787
				private static readonly IntPtr NativeMethodInfoPtr__OnInStorageElementSelected_b__0_Internal_Void_Image_0;

				// Token: 0x0400AEF4 RID: 44788
				private static readonly IntPtr NativeMethodInfoPtr__OnInStorageElementSelected_b__1_Internal_Void_TextMeshProUGUI_0;

				// Token: 0x0400AEF5 RID: 44789
				private static readonly IntPtr NativeMethodInfoPtr__OnInStorageElementSelected_b__2_Internal_Void_TextMeshProUGUI_0;

				// Token: 0x0400AEF6 RID: 44790
				private static readonly IntPtr NativeMethodInfoPtr__OnInStorageElementSelected_b__3_Internal_Void_0;
			}

			// Token: 0x02000FAE RID: 4014
			[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+GroupBase`2+<>c__DisplayClass18_0")]
			public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
			{
				// Token: 0x060114F2 RID: 70898 RVA: 0x003FBB5C File Offset: 0x003F9D5C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass18_0()
				{
					Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>.NativeClassPtr, "<>c__DisplayClass18_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInStorageInfo>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRegisteredInfo>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0>.NativeClassPtr);
					IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
					IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0.NativeFieldInfoPtr_tValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0>.NativeClassPtr, "tValue");
					IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0>.NativeClassPtr, 100664320);
					IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0.NativeMethodInfoPtr__OnRegisteredElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0>.NativeClassPtr, 100664321);
				}

				// Token: 0x060114F3 RID: 70899 RVA: 0x003FBC24 File Offset: 0x003F9E24
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114F4 RID: 70900 RVA: 0x003FBC60 File Offset: 0x003F9E60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27579, XrefRangeEnd = 27581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void _OnRegisteredElementSelected_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0.NativeMethodInfoPtr__OnRegisteredElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114F5 RID: 70901 RVA: 0x00096930 File Offset: 0x00094B30
				public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170059FA RID: 23034
				// (get) Token: 0x060114F6 RID: 70902 RVA: 0x003FBC94 File Offset: 0x003F9E94
				// (set) Token: 0x060114F7 RID: 70903 RVA: 0x00096939 File Offset: 0x00094B39
				public unsafe IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo> __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059FB RID: 23035
				// (get) Token: 0x060114F8 RID: 70904 RVA: 0x003FBCC4 File Offset: 0x003F9EC4
				// (set) Token: 0x060114F9 RID: 70905 RVA: 0x003FBCEC File Offset: 0x003F9EEC
				public unsafe TRegisteredInfo tValue
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0.NativeFieldInfoPtr_tValue);
						return IL2CPP.PointerToValueGeneric<TRegisteredInfo>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.GroupBase<TInStorageInfo, TRegisteredInfo>.__c__DisplayClass18_0.NativeFieldInfoPtr_tValue);
						Type typeFromHandle = typeof(TRegisteredInfo);
						if (!typeFromHandle.IsValueType)
						{
							if (!string.Equals(typeFromHandle.FullName, "System.String"))
							{
								IntPtr intPtr4;
								IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
								if (intPtr3 != 0)
								{
									intPtr4 = intPtr3;
									if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
									{
										IntPtr intPtr5 = intPtr3;
										cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
										return;
									}
								}
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
							}
							else
							{
								IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
							}
						}
						else
						{
							*intPtr2 = value;
						}
					}
				}

				// Token: 0x0400AEF7 RID: 44791
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AEF8 RID: 44792
				private static readonly IntPtr NativeFieldInfoPtr_tValue;

				// Token: 0x0400AEF9 RID: 44793
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AEFA RID: 44794
				private static readonly IntPtr NativeMethodInfoPtr__OnRegisteredElementSelected_b__0_Internal_Void_0;
			}
		}

		// Token: 0x020004DD RID: 1245
		public class CookerGroup : IzakayaConfigPannel.GroupBase<Cooker, KeyValuePair<int, Cooker>>
		{
			// Token: 0x06008185 RID: 33157 RVA: 0x00249068 File Offset: 0x00247268
			// Note: this type is marked as 'beforefieldinit'.
			static CookerGroup()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "CookerGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr);
				IzakayaConfigPannel.CookerGroup.NativeFieldInfoPtr_m_InStorageElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr, "m_InStorageElements");
				IzakayaConfigPannel.CookerGroup.NativeFieldInfoPtr_m_RegisteredElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr, "m_RegisteredElements");
				IzakayaConfigPannel.CookerGroup.NativeFieldInfoPtr_m_CookerAmountBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr, "m_CookerAmountBuffer");
				IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr__ctor_Public_Void_GridLayoutGroup_AdpProgressIndicatorComponent_GameObject_GridLayoutGroup_AdpProgressIndicatorComponent_GameObject_Func_2_Int32_Boolean_Func_1_Boolean_Action_1_Boolean_Action_1_KeyValuePair_2_Int32_Cooker_Action_1_KeyValuePair_2_Int32_Cooker_Action_1_Cooker_Action_1_KeyValuePair_2_Int32_Cooker_Action_List_1_IFilterConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr, 100664322);
				IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr_get_RegisteredElementCount_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr, 100664323);
				IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr_GetRegisterInfoKey_Protected_Virtual_KeyValuePair_2_Int32_Cooker_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr, 100664324);
				IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr_OnUpdateGroup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr, 100664325);
				IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr_GetUnAssignedCookers_Public_Static_IEnumerable_1_Cooker_byref_Dictionary_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr, 100664326);
				IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr___ctor_b__3_0_Private_Int32_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr, 100664327);
				IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr___ctor_b__3_2_Private_Void_UIButtonSimple_BorderElementType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr, 100664328);
				IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr___ctor_b__3_7_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr, 100664329);
			}

			// Token: 0x06008186 RID: 33158 RVA: 0x00249170 File Offset: 0x00247370
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 27924, RefRangeEnd = 27925, XrefRangeStart = 27812, XrefRangeEnd = 27924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CookerGroup(GridLayoutGroup inStorageLayout, AdpProgressIndicatorComponent inStorageScroller, GameObject objectStackedParent, GridLayoutGroup registeredLayout, AdpProgressIndicatorComponent registeredScroller, GameObject registeredParent, Func<int, bool> getPinnedCallback, Func<bool> getCanAddMoreCallback, Action<bool> toggleInStorageBlockerCallback, Action<KeyValuePair<int, Cooker>> registerDataCallback, Action<KeyValuePair<int, Cooker>> deRegisterDataCallback, Action<Cooker> describeObjectCallback, Action<KeyValuePair<int, Cooker>> describeRegisteredObjectCallback, Action solveDailyCompletionCallback, List<IFilterConfig> filter) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inStorageLayout);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inStorageScroller);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectStackedParent);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(registeredLayout);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(registeredScroller);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(registeredParent);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getPinnedCallback);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getCanAddMoreCallback);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toggleInStorageBlockerCallback);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(registerDataCallback);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deRegisterDataCallback);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describeObjectCallback);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describeRegisteredObjectCallback);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(solveDailyCompletionCallback);
				ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr__ctor_Public_Void_GridLayoutGroup_AdpProgressIndicatorComponent_GameObject_GridLayoutGroup_AdpProgressIndicatorComponent_GameObject_Func_2_Int32_Boolean_Func_1_Boolean_Action_1_Boolean_Action_1_KeyValuePair_2_Int32_Cooker_Action_1_KeyValuePair_2_Int32_Cooker_Action_1_Cooker_Action_1_KeyValuePair_2_Int32_Cooker_Action_List_1_IFilterConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002BB0 RID: 11184
			// (get) Token: 0x06008187 RID: 33159 RVA: 0x002492CC File Offset: 0x002474CC
			public unsafe override int RegisteredElementCount
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27925, XrefRangeEnd = 27926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr_get_RegisteredElementCount_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008188 RID: 33160 RVA: 0x00249314 File Offset: 0x00247514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27926, XrefRangeEnd = 27933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override KeyValuePair<int, Cooker> GetRegisterInfoKey(Cooker value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr_GetRegisterInfoKey_Protected_Virtual_KeyValuePair_2_Int32_Cooker_Cooker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<int, Cooker>(pointer);
			}

			// Token: 0x06008189 RID: 33161 RVA: 0x00249368 File Offset: 0x00247568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27933, XrefRangeEnd = 28029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnUpdateGroup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr_OnUpdateGroup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600818A RID: 33162 RVA: 0x002493A4 File Offset: 0x002475A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 28076, RefRangeEnd = 28077, XrefRangeStart = 28029, XrefRangeEnd = 28076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static IEnumerable<Cooker> GetUnAssignedCookers(ref Dictionary<Cooker, int> buffer)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr_GetUnAssignedCookers_Public_Static_IEnumerable_1_Cooker_byref_Dictionary_2_Cooker_Int32_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				buffer = ((intPtr4 == 0) ? null : new Dictionary<Cooker, int>(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IEnumerable<Cooker>>(intPtr5) : null;
			}

			// Token: 0x0600818B RID: 33163 RVA: 0x00249400 File Offset: 0x00247600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28077, XrefRangeEnd = 28080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int __ctor_b__3_0(Cooker value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr___ctor_b__3_0_Private_Int32_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600818C RID: 33164 RVA: 0x00249450 File Offset: 0x00247650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28080, XrefRangeEnd = 28093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__3_2(UIButtonSimple uiBtn, AdpUISystemUtils.BorderElementType _, int _, int _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiBtn);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr___ctor_b__3_2_Private_Void_UIButtonSimple_BorderElementType_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600818D RID: 33165 RVA: 0x002494BC File Offset: 0x002476BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28093, XrefRangeEnd = 28096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__3_7(MoveDirection direction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.NativeMethodInfoPtr___ctor_b__3_7_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600818E RID: 33166 RVA: 0x00046067 File Offset: 0x00044267
			public CookerGroup(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BAD RID: 11181
			// (get) Token: 0x0600818F RID: 33167 RVA: 0x002494FC File Offset: 0x002476FC
			// (set) Token: 0x06008190 RID: 33168 RVA: 0x00046070 File Offset: 0x00044270
			public unsafe List<Cooker> m_InStorageElements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.CookerGroup.NativeFieldInfoPtr_m_InStorageElements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Cooker>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.CookerGroup.NativeFieldInfoPtr_m_InStorageElements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BAE RID: 11182
			// (get) Token: 0x06008191 RID: 33169 RVA: 0x0024952C File Offset: 0x0024772C
			// (set) Token: 0x06008192 RID: 33170 RVA: 0x0004608F File Offset: 0x0004428F
			public unsafe List<KeyValuePair<int, Cooker>> m_RegisteredElements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.CookerGroup.NativeFieldInfoPtr_m_RegisteredElements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<int, Cooker>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.CookerGroup.NativeFieldInfoPtr_m_RegisteredElements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BAF RID: 11183
			// (get) Token: 0x06008193 RID: 33171 RVA: 0x0024955C File Offset: 0x0024775C
			// (set) Token: 0x06008194 RID: 33172 RVA: 0x000460AE File Offset: 0x000442AE
			public unsafe Dictionary<Cooker, int> m_CookerAmountBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.CookerGroup.NativeFieldInfoPtr_m_CookerAmountBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Cooker, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.CookerGroup.NativeFieldInfoPtr_m_CookerAmountBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040054E0 RID: 21728
			private static readonly IntPtr NativeFieldInfoPtr_m_InStorageElements;

			// Token: 0x040054E1 RID: 21729
			private static readonly IntPtr NativeFieldInfoPtr_m_RegisteredElements;

			// Token: 0x040054E2 RID: 21730
			private static readonly IntPtr NativeFieldInfoPtr_m_CookerAmountBuffer;

			// Token: 0x040054E3 RID: 21731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GridLayoutGroup_AdpProgressIndicatorComponent_GameObject_GridLayoutGroup_AdpProgressIndicatorComponent_GameObject_Func_2_Int32_Boolean_Func_1_Boolean_Action_1_Boolean_Action_1_KeyValuePair_2_Int32_Cooker_Action_1_KeyValuePair_2_Int32_Cooker_Action_1_Cooker_Action_1_KeyValuePair_2_Int32_Cooker_Action_List_1_IFilterConfig_0;

			// Token: 0x040054E4 RID: 21732
			private static readonly IntPtr NativeMethodInfoPtr_get_RegisteredElementCount_Protected_Virtual_get_Int32_0;

			// Token: 0x040054E5 RID: 21733
			private static readonly IntPtr NativeMethodInfoPtr_GetRegisterInfoKey_Protected_Virtual_KeyValuePair_2_Int32_Cooker_Cooker_0;

			// Token: 0x040054E6 RID: 21734
			private static readonly IntPtr NativeMethodInfoPtr_OnUpdateGroup_Protected_Virtual_Void_0;

			// Token: 0x040054E7 RID: 21735
			private static readonly IntPtr NativeMethodInfoPtr_GetUnAssignedCookers_Public_Static_IEnumerable_1_Cooker_byref_Dictionary_2_Cooker_Int32_0;

			// Token: 0x040054E8 RID: 21736
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__3_0_Private_Int32_Cooker_0;

			// Token: 0x040054E9 RID: 21737
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__3_2_Private_Void_UIButtonSimple_BorderElementType_Int32_Int32_0;

			// Token: 0x040054EA RID: 21738
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__3_7_Private_Void_MoveDirection_0;

			// Token: 0x02000FAF RID: 4015
			[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+CookerGroup+<>c__DisplayClass3_0")]
			public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
			{
				// Token: 0x060114FA RID: 70906 RVA: 0x003FBD94 File Offset: 0x003F9F94
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass3_0()
				{
					Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr, "<>c__DisplayClass3_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0>.NativeClassPtr);
					IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0.NativeFieldInfoPtr_cooker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0>.NativeClassPtr, "cooker");
					IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0>.NativeClassPtr, "index");
					IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0>.NativeClassPtr, 100664330);
					IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0.NativeMethodInfoPtr___ctor_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0>.NativeClassPtr, 100664331);
					IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0.NativeMethodInfoPtr___ctor_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0>.NativeClassPtr, 100664332);
				}

				// Token: 0x060114FB RID: 70907 RVA: 0x003FBE24 File Offset: 0x003FA024
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114FC RID: 70908 RVA: 0x003FBE60 File Offset: 0x003FA060
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27745, XrefRangeEnd = 27749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __ctor_b__4(Image visual)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0.NativeMethodInfoPtr___ctor_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114FD RID: 70909 RVA: 0x003FBEA4 File Offset: 0x003FA0A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27749, XrefRangeEnd = 27754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __ctor_b__6()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0.NativeMethodInfoPtr___ctor_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060114FE RID: 70910 RVA: 0x00096958 File Offset: 0x00094B58
				public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170059FC RID: 23036
				// (get) Token: 0x060114FF RID: 70911 RVA: 0x003FBED8 File Offset: 0x003FA0D8
				// (set) Token: 0x06011500 RID: 70912 RVA: 0x00096961 File Offset: 0x00094B61
				public unsafe Cooker cooker
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0.NativeFieldInfoPtr_cooker);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cooker>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0.NativeFieldInfoPtr_cooker), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059FD RID: 23037
				// (get) Token: 0x06011501 RID: 70913 RVA: 0x003FBF08 File Offset: 0x003FA108
				// (set) Token: 0x06011502 RID: 70914 RVA: 0x00096980 File Offset: 0x00094B80
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.CookerGroup.__c__DisplayClass3_0.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x0400AEFB RID: 44795
				private static readonly IntPtr NativeFieldInfoPtr_cooker;

				// Token: 0x0400AEFC RID: 44796
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x0400AEFD RID: 44797
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AEFE RID: 44798
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_Internal_Void_Image_0;

				// Token: 0x0400AEFF RID: 44799
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__6_Internal_Void_0;
			}

			// Token: 0x02000FB0 RID: 4016
			[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+CookerGroup+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x06011503 RID: 70915 RVA: 0x003FBF30 File Offset: 0x003FA130
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr);
					IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, "<>9");
					IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__3_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, "<>9__3_3");
					IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__3_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, "<>9__3_5");
					IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, "<>9__3_1");
					IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, "<>9__7_0");
					IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, "<>9__7_1");
					IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, "<>9__7_2");
					IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__7_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, "<>9__7_3");
					IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, "<>9__8_0");
					IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, 100664334);
					IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr___ctor_b__3_1_Internal_Void_KeyValuePair_2_Int32_Cooker_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, 100664335);
					IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr___ctor_b__3_3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, 100664336);
					IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr___ctor_b__3_5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, 100664337);
					IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr__OnUpdateGroup_b__7_0_Internal_Cooker_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, 100664338);
					IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr__OnUpdateGroup_b__7_1_Internal_Boolean_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, 100664339);
					IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr__OnUpdateGroup_b__7_2_Internal_Int32_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, 100664340);
					IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr__OnUpdateGroup_b__7_3_Internal_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, 100664341);
					IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr__GetUnAssignedCookers_b__8_0_Internal_Int32_KeyValuePair_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr, 100664342);
				}

				// Token: 0x06011504 RID: 70916 RVA: 0x003FC0C4 File Offset: 0x003FA2C4
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.CookerGroup.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011505 RID: 70917 RVA: 0x003FC100 File Offset: 0x003FA300
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27754, XrefRangeEnd = 27805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __ctor_b__3_1(KeyValuePair<int, Cooker> value, UIElementCluster cluster, UIButtonSimple ui)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr___ctor_b__3_1_Internal_Void_KeyValuePair_2_Int32_Cooker_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011506 RID: 70918 RVA: 0x003FC16C File Offset: 0x003FA36C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __ctor_b__3_3(Image x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr___ctor_b__3_3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011507 RID: 70919 RVA: 0x003FC1B0 File Offset: 0x003FA3B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __ctor_b__3_5(Image x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr___ctor_b__3_5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011508 RID: 70920 RVA: 0x003FC1F4 File Offset: 0x003FA3F4
				[CallerCount(0)]
				public unsafe Cooker _OnUpdateGroup_b__7_0(Cooker x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr__OnUpdateGroup_b__7_0_Internal_Cooker_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cooker>(intPtr3) : null;
				}

				// Token: 0x06011509 RID: 70921 RVA: 0x003FC244 File Offset: 0x003FA444
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27805, XrefRangeEnd = 27810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _OnUpdateGroup_b__7_1(Cooker x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr__OnUpdateGroup_b__7_1_Internal_Boolean_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0601150A RID: 70922 RVA: 0x003FC294 File Offset: 0x003FA494
				[CallerCount(0)]
				public unsafe int _OnUpdateGroup_b__7_2(Cooker x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr__OnUpdateGroup_b__7_2_Internal_Int32_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0601150B RID: 70923 RVA: 0x003FC2E4 File Offset: 0x003FA4E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27810, XrefRangeEnd = 27811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Cooker _OnUpdateGroup_b__7_3(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr__OnUpdateGroup_b__7_3_Internal_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cooker>(intPtr3) : null;
				}

				// Token: 0x0601150C RID: 70924 RVA: 0x003FC330 File Offset: 0x003FA530
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27811, XrefRangeEnd = 27812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int _GetUnAssignedCookers_b__8_0(KeyValuePair<Cooker, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.CookerGroup.__c.NativeMethodInfoPtr__GetUnAssignedCookers_b__8_0_Internal_Int32_KeyValuePair_2_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0601150D RID: 70925 RVA: 0x0009699B File Offset: 0x00094B9B
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170059FE RID: 23038
				// (get) Token: 0x0601150E RID: 70926 RVA: 0x003FC384 File Offset: 0x003FA584
				// (set) Token: 0x0601150F RID: 70927 RVA: 0x000969A4 File Offset: 0x00094BA4
				public unsafe static IzakayaConfigPannel.CookerGroup.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.CookerGroup.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170059FF RID: 23039
				// (get) Token: 0x06011510 RID: 70928 RVA: 0x003FC3AC File Offset: 0x003FA5AC
				// (set) Token: 0x06011511 RID: 70929 RVA: 0x000969B6 File Offset: 0x00094BB6
				public unsafe static Action<Image> __9__3_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__3_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__3_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A00 RID: 23040
				// (get) Token: 0x06011512 RID: 70930 RVA: 0x003FC3D4 File Offset: 0x003FA5D4
				// (set) Token: 0x06011513 RID: 70931 RVA: 0x000969C8 File Offset: 0x00094BC8
				public unsafe static Action<Image> __9__3_5
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__3_5, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__3_5, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A01 RID: 23041
				// (get) Token: 0x06011514 RID: 70932 RVA: 0x003FC3FC File Offset: 0x003FA5FC
				// (set) Token: 0x06011515 RID: 70933 RVA: 0x000969DA File Offset: 0x00094BDA
				public unsafe static Action<KeyValuePair<int, Cooker>, UIElementCluster, UIButtonSimple> __9__3_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<int, Cooker>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A02 RID: 23042
				// (get) Token: 0x06011516 RID: 70934 RVA: 0x003FC424 File Offset: 0x003FA624
				// (set) Token: 0x06011517 RID: 70935 RVA: 0x000969EC File Offset: 0x00094BEC
				public unsafe static Func<Cooker, Cooker> __9__7_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Cooker, Cooker>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A03 RID: 23043
				// (get) Token: 0x06011518 RID: 70936 RVA: 0x003FC44C File Offset: 0x003FA64C
				// (set) Token: 0x06011519 RID: 70937 RVA: 0x000969FE File Offset: 0x00094BFE
				public unsafe static Func<Cooker, bool> __9__7_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Cooker, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A04 RID: 23044
				// (get) Token: 0x0601151A RID: 70938 RVA: 0x003FC474 File Offset: 0x003FA674
				// (set) Token: 0x0601151B RID: 70939 RVA: 0x00096A10 File Offset: 0x00094C10
				public unsafe static Func<Cooker, int> __9__7_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Cooker, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A05 RID: 23045
				// (get) Token: 0x0601151C RID: 70940 RVA: 0x003FC49C File Offset: 0x003FA69C
				// (set) Token: 0x0601151D RID: 70941 RVA: 0x00096A22 File Offset: 0x00094C22
				public unsafe static Func<int, Cooker> __9__7_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__7_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Cooker>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__7_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A06 RID: 23046
				// (get) Token: 0x0601151E RID: 70942 RVA: 0x003FC4C4 File Offset: 0x003FA6C4
				// (set) Token: 0x0601151F RID: 70943 RVA: 0x00096A34 File Offset: 0x00094C34
				public unsafe static Func<KeyValuePair<Cooker, int>, int> __9__8_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Cooker, int>, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.CookerGroup.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AF00 RID: 44800
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400AF01 RID: 44801
				private static readonly IntPtr NativeFieldInfoPtr___9__3_3;

				// Token: 0x0400AF02 RID: 44802
				private static readonly IntPtr NativeFieldInfoPtr___9__3_5;

				// Token: 0x0400AF03 RID: 44803
				private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

				// Token: 0x0400AF04 RID: 44804
				private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

				// Token: 0x0400AF05 RID: 44805
				private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

				// Token: 0x0400AF06 RID: 44806
				private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

				// Token: 0x0400AF07 RID: 44807
				private static readonly IntPtr NativeFieldInfoPtr___9__7_3;

				// Token: 0x0400AF08 RID: 44808
				private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

				// Token: 0x0400AF09 RID: 44809
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AF0A RID: 44810
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__3_1_Internal_Void_KeyValuePair_2_Int32_Cooker_UIElementCluster_UIButtonSimple_0;

				// Token: 0x0400AF0B RID: 44811
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__3_3_Internal_Void_Image_0;

				// Token: 0x0400AF0C RID: 44812
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__3_5_Internal_Void_Image_0;

				// Token: 0x0400AF0D RID: 44813
				private static readonly IntPtr NativeMethodInfoPtr__OnUpdateGroup_b__7_0_Internal_Cooker_Cooker_0;

				// Token: 0x0400AF0E RID: 44814
				private static readonly IntPtr NativeMethodInfoPtr__OnUpdateGroup_b__7_1_Internal_Boolean_Cooker_0;

				// Token: 0x0400AF0F RID: 44815
				private static readonly IntPtr NativeMethodInfoPtr__OnUpdateGroup_b__7_2_Internal_Int32_Cooker_0;

				// Token: 0x0400AF10 RID: 44816
				private static readonly IntPtr NativeMethodInfoPtr__OnUpdateGroup_b__7_3_Internal_Cooker_Int32_0;

				// Token: 0x0400AF11 RID: 44817
				private static readonly IntPtr NativeMethodInfoPtr__GetUnAssignedCookers_b__8_0_Internal_Int32_KeyValuePair_2_Cooker_Int32_0;
			}
		}

		// Token: 0x020004DE RID: 1246
		public class SellableGroup<T> : IzakayaConfigPannel.GroupBase<T, T> where T : NonTradableObjectBase
		{
			// Token: 0x06008195 RID: 33173 RVA: 0x0024958C File Offset: 0x0024778C
			// Note: this type is marked as 'beforefieldinit'.
			static SellableGroup()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "SellableGroup`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>>.NativeClassPtr);
				IzakayaConfigPannel.SellableGroup<T>.NativeFieldInfoPtr_m_DailyRecipePrinter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>>.NativeClassPtr, "m_DailyRecipePrinter");
				IzakayaConfigPannel.SellableGroup<T>.NativeFieldInfoPtr_m_Elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>>.NativeClassPtr, "m_Elements");
				IzakayaConfigPannel.SellableGroup<T>.NativeFieldInfoPtr_m_GetInStorageObjectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>>.NativeClassPtr, "m_GetInStorageObjectCallback");
				IzakayaConfigPannel.SellableGroup<T>.NativeFieldInfoPtr_m_RegisteredElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>>.NativeClassPtr, "m_RegisteredElements");
				IzakayaConfigPannel.SellableGroup<T>.NativeMethodInfoPtr__ctor_Public_Void_GridLayoutGroup_GameObject_AdpProgressIndicatorComponent_Func_2_T_Int32_Func_2_Int32_Boolean_Action_1_NonTradableObjectBase_Action_1_NonTradableObjectBase_Action_1_T_Func_1_IEnumerable_1_T_Func_1_Boolean_DailyRecipePrinterNew_Boolean_Action_1_Boolean_Action_StaticHorizontalGridScrollListUILogicalGroupT_3_T_UIElementCluster_UIButtonSimple_List_1_IFilterConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>>.NativeClassPtr, 100664343);
				IzakayaConfigPannel.SellableGroup<T>.NativeMethodInfoPtr_get_RegisteredElementCount_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>>.NativeClassPtr, 100664344);
				IzakayaConfigPannel.SellableGroup<T>.NativeMethodInfoPtr_OnRegisteredElementSelectedBaseTyped_Private_Void_NonTradableObjectBase_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>>.NativeClassPtr, 100664345);
				IzakayaConfigPannel.SellableGroup<T>.NativeMethodInfoPtr_GetRegisterInfoKey_Protected_Virtual_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>>.NativeClassPtr, 100664346);
				IzakayaConfigPannel.SellableGroup<T>.NativeMethodInfoPtr_OnUpdateGroup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>>.NativeClassPtr, 100664347);
			}

			// Token: 0x06008196 RID: 33174 RVA: 0x002496A8 File Offset: 0x002478A8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 28141, RefRangeEnd = 28143, XrefRangeStart = 28096, XrefRangeEnd = 28141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SellableGroup(GridLayoutGroup inStorageLayout, GameObject objectStackedParent, AdpProgressIndicatorComponent scroller, Func<T, int> getAmountCallback, Func<int, bool> getPinnedCallback, Action<NonTradableObjectBase> registerDataCallback, Action<NonTradableObjectBase> deRegisterDataCallback, Action<T> describeObjectCallback, Func<IEnumerable<T>> getInStorageObjectCallback, Func<bool> canAddMoreCallback, DailyRecipePrinterNew dailyRecipePrinter, bool isRecipe, Action<bool> toggleInStorageBlockerCallback, Action solveDailyCompletionCallback, StaticHorizontalGridScrollListUILogicalGroupT<T, UIElementCluster, UIButtonSimple> registeredGroup, List<IFilterConfig> filter) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inStorageLayout);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectStackedParent);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scroller);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getAmountCallback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getPinnedCallback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(registerDataCallback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deRegisterDataCallback);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describeObjectCallback);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getInStorageObjectCallback);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(canAddMoreCallback);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dailyRecipePrinter);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRecipe;
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toggleInStorageBlockerCallback);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(solveDailyCompletionCallback);
				ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(registeredGroup);
				ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.SellableGroup<T>.NativeMethodInfoPtr__ctor_Public_Void_GridLayoutGroup_GameObject_AdpProgressIndicatorComponent_Func_2_T_Int32_Func_2_Int32_Boolean_Action_1_NonTradableObjectBase_Action_1_NonTradableObjectBase_Action_1_T_Func_1_IEnumerable_1_T_Func_1_Boolean_DailyRecipePrinterNew_Boolean_Action_1_Boolean_Action_StaticHorizontalGridScrollListUILogicalGroupT_3_T_UIElementCluster_UIButtonSimple_List_1_IFilterConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002BB5 RID: 11189
			// (get) Token: 0x06008197 RID: 33175 RVA: 0x00249814 File Offset: 0x00247A14
			public unsafe override int RegisteredElementCount
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28143, XrefRangeEnd = 28171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.SellableGroup<T>.NativeMethodInfoPtr_get_RegisteredElementCount_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008198 RID: 33176 RVA: 0x0024985C File Offset: 0x00247A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28171, XrefRangeEnd = 28176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnRegisteredElementSelectedBaseTyped(NonTradableObjectBase tValue, UIElementCluster ui, UIButtonSimple btn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tValue);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(btn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.SellableGroup<T>.NativeMethodInfoPtr_OnRegisteredElementSelectedBaseTyped_Private_Void_NonTradableObjectBase_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008199 RID: 33177 RVA: 0x002498C4 File Offset: 0x00247AC4
			[CallerCount(0)]
			public unsafe override T GetRegisterInfoKey(T value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.SellableGroup<T>.NativeMethodInfoPtr_GetRegisterInfoKey_Protected_Virtual_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}

			// Token: 0x0600819A RID: 33178 RVA: 0x00249950 File Offset: 0x00247B50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28176, XrefRangeEnd = 28195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnUpdateGroup()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IzakayaConfigPannel.SellableGroup<T>.NativeMethodInfoPtr_OnUpdateGroup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600819B RID: 33179 RVA: 0x000460CD File Offset: 0x000442CD
			public SellableGroup(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BB1 RID: 11185
			// (get) Token: 0x0600819C RID: 33180 RVA: 0x0024998C File Offset: 0x00247B8C
			// (set) Token: 0x0600819D RID: 33181 RVA: 0x000460D6 File Offset: 0x000442D6
			public unsafe DailyRecipePrinterNew m_DailyRecipePrinter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.SellableGroup<T>.NativeFieldInfoPtr_m_DailyRecipePrinter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyRecipePrinterNew>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.SellableGroup<T>.NativeFieldInfoPtr_m_DailyRecipePrinter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BB2 RID: 11186
			// (get) Token: 0x0600819E RID: 33182 RVA: 0x002499BC File Offset: 0x00247BBC
			// (set) Token: 0x0600819F RID: 33183 RVA: 0x000460F5 File Offset: 0x000442F5
			public unsafe List<T> m_Elements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.SellableGroup<T>.NativeFieldInfoPtr_m_Elements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.SellableGroup<T>.NativeFieldInfoPtr_m_Elements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BB3 RID: 11187
			// (get) Token: 0x060081A0 RID: 33184 RVA: 0x002499EC File Offset: 0x00247BEC
			// (set) Token: 0x060081A1 RID: 33185 RVA: 0x00046114 File Offset: 0x00044314
			public unsafe Func<IEnumerable<T>> m_GetInStorageObjectCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.SellableGroup<T>.NativeFieldInfoPtr_m_GetInStorageObjectCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<T>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.SellableGroup<T>.NativeFieldInfoPtr_m_GetInStorageObjectCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BB4 RID: 11188
			// (get) Token: 0x060081A2 RID: 33186 RVA: 0x00249A1C File Offset: 0x00247C1C
			// (set) Token: 0x060081A3 RID: 33187 RVA: 0x00046133 File Offset: 0x00044333
			public unsafe IReadOnlyList<NonTradableObjectBase> m_RegisteredElements
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.SellableGroup<T>.NativeFieldInfoPtr_m_RegisteredElements);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<NonTradableObjectBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.SellableGroup<T>.NativeFieldInfoPtr_m_RegisteredElements), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040054EB RID: 21739
			private static readonly IntPtr NativeFieldInfoPtr_m_DailyRecipePrinter;

			// Token: 0x040054EC RID: 21740
			private static readonly IntPtr NativeFieldInfoPtr_m_Elements;

			// Token: 0x040054ED RID: 21741
			private static readonly IntPtr NativeFieldInfoPtr_m_GetInStorageObjectCallback;

			// Token: 0x040054EE RID: 21742
			private static readonly IntPtr NativeFieldInfoPtr_m_RegisteredElements;

			// Token: 0x040054EF RID: 21743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GridLayoutGroup_GameObject_AdpProgressIndicatorComponent_Func_2_T_Int32_Func_2_Int32_Boolean_Action_1_NonTradableObjectBase_Action_1_NonTradableObjectBase_Action_1_T_Func_1_IEnumerable_1_T_Func_1_Boolean_DailyRecipePrinterNew_Boolean_Action_1_Boolean_Action_StaticHorizontalGridScrollListUILogicalGroupT_3_T_UIElementCluster_UIButtonSimple_List_1_IFilterConfig_0;

			// Token: 0x040054F0 RID: 21744
			private static readonly IntPtr NativeMethodInfoPtr_get_RegisteredElementCount_Protected_Virtual_get_Int32_0;

			// Token: 0x040054F1 RID: 21745
			private static readonly IntPtr NativeMethodInfoPtr_OnRegisteredElementSelectedBaseTyped_Private_Void_NonTradableObjectBase_UIElementCluster_UIButtonSimple_0;

			// Token: 0x040054F2 RID: 21746
			private static readonly IntPtr NativeMethodInfoPtr_GetRegisterInfoKey_Protected_Virtual_T_T_0;

			// Token: 0x040054F3 RID: 21747
			private static readonly IntPtr NativeMethodInfoPtr_OnUpdateGroup_Protected_Virtual_Void_0;

			// Token: 0x02000FB1 RID: 4017
			[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+SellableGroup`1+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x06011520 RID: 70944 RVA: 0x003FC4EC File Offset: 0x003FA6EC
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>.__c>.NativeClassPtr);
					IzakayaConfigPannel.SellableGroup<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>.__c>.NativeClassPtr, "<>9");
					IzakayaConfigPannel.SellableGroup<T>.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>.__c>.NativeClassPtr, "<>9__6_0");
					IzakayaConfigPannel.SellableGroup<T>.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>.__c>.NativeClassPtr, "<>9__9_0");
					IzakayaConfigPannel.SellableGroup<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>.__c>.NativeClassPtr, 100664349);
					IzakayaConfigPannel.SellableGroup<T>.__c.NativeMethodInfoPtr__get_RegisteredElementCount_b__6_0_Internal_Boolean_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>.__c>.NativeClassPtr, 100664350);
					IzakayaConfigPannel.SellableGroup<T>.__c.NativeMethodInfoPtr__OnUpdateGroup_b__9_0_Internal_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>.__c>.NativeClassPtr, 100664351);
				}

				// Token: 0x06011521 RID: 70945 RVA: 0x003FC5CC File Offset: 0x003FA7CC
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.SellableGroup<T>.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.SellableGroup<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011522 RID: 70946 RVA: 0x003FC608 File Offset: 0x003FA808
				[CallerCount(0)]
				public unsafe bool _get_RegisteredElementCount_b__6_0(NonTradableObjectBase x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.SellableGroup<T>.__c.NativeMethodInfoPtr__get_RegisteredElementCount_b__6_0_Internal_Boolean_NonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011523 RID: 70947 RVA: 0x003FC658 File Offset: 0x003FA858
				[CallerCount(0)]
				public unsafe T _OnUpdateGroup_b__9_0(T x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = x;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref x;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.SellableGroup<T>.__c.NativeMethodInfoPtr__OnUpdateGroup_b__9_0_Internal_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
				}

				// Token: 0x06011524 RID: 70948 RVA: 0x00096A46 File Offset: 0x00094C46
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A07 RID: 23047
				// (get) Token: 0x06011525 RID: 70949 RVA: 0x003FC6D8 File Offset: 0x003FA8D8
				// (set) Token: 0x06011526 RID: 70950 RVA: 0x00096A4F File Offset: 0x00094C4F
				public unsafe static IzakayaConfigPannel.SellableGroup<T>.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.SellableGroup<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.SellableGroup<T>.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.SellableGroup<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A08 RID: 23048
				// (get) Token: 0x06011527 RID: 70951 RVA: 0x003FC700 File Offset: 0x003FA900
				// (set) Token: 0x06011528 RID: 70952 RVA: 0x00096A61 File Offset: 0x00094C61
				public unsafe static Func<NonTradableObjectBase, bool> __9__6_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.SellableGroup<T>.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NonTradableObjectBase, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.SellableGroup<T>.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A09 RID: 23049
				// (get) Token: 0x06011529 RID: 70953 RVA: 0x003FC728 File Offset: 0x003FA928
				// (set) Token: 0x0601152A RID: 70954 RVA: 0x00096A73 File Offset: 0x00094C73
				public unsafe static Func<T, T> __9__9_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.SellableGroup<T>.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.SellableGroup<T>.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AF12 RID: 44818
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400AF13 RID: 44819
				private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

				// Token: 0x0400AF14 RID: 44820
				private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

				// Token: 0x0400AF15 RID: 44821
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AF16 RID: 44822
				private static readonly IntPtr NativeMethodInfoPtr__get_RegisteredElementCount_b__6_0_Internal_Boolean_NonTradableObjectBase_0;

				// Token: 0x0400AF17 RID: 44823
				private static readonly IntPtr NativeMethodInfoPtr__OnUpdateGroup_b__9_0_Internal_T_T_0;
			}
		}

		// Token: 0x020004DF RID: 1247
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+<>c__DisplayClass54_0")]
		public sealed class __c__DisplayClass54_0 : Il2CppSystem.Object
		{
			// Token: 0x060081A4 RID: 33188 RVA: 0x00249A4C File Offset: 0x00247C4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_0()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "<>c__DisplayClass54_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, "<>4__this");
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr_tempDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, "tempDictionary");
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr___9__28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, "<>9__28");
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr___9__34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, "<>9__34");
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr___9__38 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, "<>9__38");
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664352);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__0_Internal_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664353);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664354);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__28_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664355);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664356);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664357);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664358);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664359);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__29_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664360);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr_Method_Internal_Void_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664361);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__9_Internal_Void_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664362);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664363);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_Recipe_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664364);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_IEnumerable_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664365);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664366);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__14_Internal_Void_Recipe_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664367);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__17_Internal_Void_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664368);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__18_Internal_Void_NonTradableObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664369);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__19_Internal_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664370);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__20_Internal_IEnumerable_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664371);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__34_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664372);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__21_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664373);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__38_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664374);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__23_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664375);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__24_Internal_Void_KeyValuePair_2_Int32_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664376);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__25_Internal_Void_KeyValuePair_2_Int32_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664377);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__26_Internal_Void_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664378);
				IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__27_Internal_Void_KeyValuePair_2_Int32_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr, 100664379);
			}

			// Token: 0x060081A5 RID: 33189 RVA: 0x00249D0C File Offset: 0x00247F0C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081A6 RID: 33190 RVA: 0x00249D48 File Offset: 0x00247F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28195, XrefRangeEnd = 28197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CancellationToken _OnPanelInitialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__0_Internal_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new CancellationToken(pointer);
			}

			// Token: 0x060081A7 RID: 33191 RVA: 0x00249D80 File Offset: 0x00247F80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28197, XrefRangeEnd = 28213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081A8 RID: 33192 RVA: 0x00249DB4 File Offset: 0x00247FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28213, XrefRangeEnd = 28215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__28()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__28_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081A9 RID: 33193 RVA: 0x00249DE8 File Offset: 0x00247FE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28215, XrefRangeEnd = 28226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__2(InputAction.CallbackContext switchAction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(switchAction));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081AA RID: 33194 RVA: 0x00249E30 File Offset: 0x00248030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28226, XrefRangeEnd = 28230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__3(InputAction.CallbackContext switchAction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(switchAction));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081AB RID: 33195 RVA: 0x00249E78 File Offset: 0x00248078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28230, XrefRangeEnd = 28232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__4(InputAction.CallbackContext _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081AC RID: 33196 RVA: 0x00249EC0 File Offset: 0x002480C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28232, XrefRangeEnd = 28240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_PDM_0(bool active)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081AD RID: 33197 RVA: 0x00249F00 File Offset: 0x00248100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28240, XrefRangeEnd = 28242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__29(float alpha)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref alpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__29_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081AE RID: 33198 RVA: 0x00249F40 File Offset: 0x00248140
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 28251, RefRangeEnd = 28253, XrefRangeStart = 28242, XrefRangeEnd = 28251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Recipe_0(Recipe recipe)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr_Method_Internal_Void_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081AF RID: 33199 RVA: 0x00249F84 File Offset: 0x00248184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28253, XrefRangeEnd = 28255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__9(NonTradableObjectBase value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__9_Internal_Void_NonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081B0 RID: 33200 RVA: 0x00249FC8 File Offset: 0x002481C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28255, XrefRangeEnd = 28257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__10(NonTradableObjectBase value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_NonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081B1 RID: 33201 RVA: 0x0024A00C File Offset: 0x0024820C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28257, XrefRangeEnd = 28272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__11(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_Recipe_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081B2 RID: 33202 RVA: 0x0024A050 File Offset: 0x00248250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28272, XrefRangeEnd = 28312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Recipe> _OnPanelInitialize_b__12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_IEnumerable_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Recipe>>(intPtr3) : null;
			}

			// Token: 0x060081B3 RID: 33203 RVA: 0x0024A090 File Offset: 0x00248290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28312, XrefRangeEnd = 28315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__13()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081B4 RID: 33204 RVA: 0x0024A0CC File Offset: 0x002482CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28315, XrefRangeEnd = 28319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__14(Recipe recipe)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__14_Internal_Void_Recipe_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081B5 RID: 33205 RVA: 0x0024A110 File Offset: 0x00248310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28319, XrefRangeEnd = 28321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__17(NonTradableObjectBase value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__17_Internal_Void_NonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081B6 RID: 33206 RVA: 0x0024A154 File Offset: 0x00248354
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28321, XrefRangeEnd = 28323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__18(NonTradableObjectBase value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__18_Internal_Void_NonTradableObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081B7 RID: 33207 RVA: 0x0024A198 File Offset: 0x00248398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28323, XrefRangeEnd = 28338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__19(Sellable value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__19_Internal_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081B8 RID: 33208 RVA: 0x0024A1DC File Offset: 0x002483DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28338, XrefRangeEnd = 28401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Sellable> _OnPanelInitialize_b__20()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__20_Internal_IEnumerable_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sellable>>(intPtr3) : null;
			}

			// Token: 0x060081B9 RID: 33209 RVA: 0x0024A21C File Offset: 0x0024841C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28401, XrefRangeEnd = 28405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__34(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__34_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081BA RID: 33210 RVA: 0x0024A270 File Offset: 0x00248470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28405, XrefRangeEnd = 28409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__21()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__21_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081BB RID: 33211 RVA: 0x0024A2AC File Offset: 0x002484AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28409, XrefRangeEnd = 28413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__38(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__38_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081BC RID: 33212 RVA: 0x0024A300 File Offset: 0x00248500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28413, XrefRangeEnd = 28432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__23()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__23_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081BD RID: 33213 RVA: 0x0024A33C File Offset: 0x0024853C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28432, XrefRangeEnd = 28435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__24(KeyValuePair<int, Cooker> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__24_Internal_Void_KeyValuePair_2_Int32_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081BE RID: 33214 RVA: 0x0024A384 File Offset: 0x00248584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28435, XrefRangeEnd = 28438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__25(KeyValuePair<int, Cooker> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__25_Internal_Void_KeyValuePair_2_Int32_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081BF RID: 33215 RVA: 0x0024A3CC File Offset: 0x002485CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28438, XrefRangeEnd = 28453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__26(Cooker x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__26_Internal_Void_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081C0 RID: 33216 RVA: 0x0024A410 File Offset: 0x00248610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28453, XrefRangeEnd = 28468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__27(KeyValuePair<int, Cooker> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_0.NativeMethodInfoPtr__OnPanelInitialize_b__27_Internal_Void_KeyValuePair_2_Int32_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081C1 RID: 33217 RVA: 0x00046152 File Offset: 0x00044352
			public __c__DisplayClass54_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BB6 RID: 11190
			// (get) Token: 0x060081C2 RID: 33218 RVA: 0x0024A458 File Offset: 0x00248658
			// (set) Token: 0x060081C3 RID: 33219 RVA: 0x0004615B File Offset: 0x0004435B
			public unsafe IzakayaConfigPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BB7 RID: 11191
			// (get) Token: 0x060081C4 RID: 33220 RVA: 0x0024A488 File Offset: 0x00248688
			// (set) Token: 0x060081C5 RID: 33221 RVA: 0x0004617A File Offset: 0x0004437A
			public unsafe Dictionary<Cooker, int> tempDictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr_tempDictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Cooker, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr_tempDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BB8 RID: 11192
			// (get) Token: 0x060081C6 RID: 33222 RVA: 0x0024A4B8 File Offset: 0x002486B8
			// (set) Token: 0x060081C7 RID: 33223 RVA: 0x00046199 File Offset: 0x00044399
			public unsafe Action __9__28
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr___9__28);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr___9__28), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BB9 RID: 11193
			// (get) Token: 0x060081C8 RID: 33224 RVA: 0x0024A4E8 File Offset: 0x002486E8
			// (set) Token: 0x060081C9 RID: 33225 RVA: 0x000461B8 File Offset: 0x000443B8
			public unsafe Func<KeyValuePair<Sellable, int>, bool> __9__34
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr___9__34);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr___9__34), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BBA RID: 11194
			// (get) Token: 0x060081CA RID: 33226 RVA: 0x0024A518 File Offset: 0x00248718
			// (set) Token: 0x060081CB RID: 33227 RVA: 0x000461D7 File Offset: 0x000443D7
			public unsafe Func<KeyValuePair<Sellable, int>, bool> __9__38
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr___9__38);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_0.NativeFieldInfoPtr___9__38), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040054F4 RID: 21748
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040054F5 RID: 21749
			private static readonly IntPtr NativeFieldInfoPtr_tempDictionary;

			// Token: 0x040054F6 RID: 21750
			private static readonly IntPtr NativeFieldInfoPtr___9__28;

			// Token: 0x040054F7 RID: 21751
			private static readonly IntPtr NativeFieldInfoPtr___9__34;

			// Token: 0x040054F8 RID: 21752
			private static readonly IntPtr NativeFieldInfoPtr___9__38;

			// Token: 0x040054F9 RID: 21753
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040054FA RID: 21754
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__0_Internal_CancellationToken_0;

			// Token: 0x040054FB RID: 21755
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_0;

			// Token: 0x040054FC RID: 21756
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__28_Internal_Void_0;

			// Token: 0x040054FD RID: 21757
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_CallbackContext_0;

			// Token: 0x040054FE RID: 21758
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_CallbackContext_0;

			// Token: 0x040054FF RID: 21759
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_CallbackContext_0;

			// Token: 0x04005500 RID: 21760
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;

			// Token: 0x04005501 RID: 21761
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__29_Internal_Void_Single_0;

			// Token: 0x04005502 RID: 21762
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Recipe_0;

			// Token: 0x04005503 RID: 21763
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_Internal_Void_NonTradableObjectBase_0;

			// Token: 0x04005504 RID: 21764
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__10_Internal_Void_NonTradableObjectBase_0;

			// Token: 0x04005505 RID: 21765
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__11_Internal_Void_Recipe_1;

			// Token: 0x04005506 RID: 21766
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__12_Internal_IEnumerable_1_Recipe_0;

			// Token: 0x04005507 RID: 21767
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__13_Internal_Boolean_0;

			// Token: 0x04005508 RID: 21768
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__14_Internal_Void_Recipe_1;

			// Token: 0x04005509 RID: 21769
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__17_Internal_Void_NonTradableObjectBase_0;

			// Token: 0x0400550A RID: 21770
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__18_Internal_Void_NonTradableObjectBase_0;

			// Token: 0x0400550B RID: 21771
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__19_Internal_Void_Sellable_0;

			// Token: 0x0400550C RID: 21772
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__20_Internal_IEnumerable_1_Sellable_0;

			// Token: 0x0400550D RID: 21773
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__34_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400550E RID: 21774
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__21_Internal_Boolean_0;

			// Token: 0x0400550F RID: 21775
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__38_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x04005510 RID: 21776
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__23_Internal_Boolean_0;

			// Token: 0x04005511 RID: 21777
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__24_Internal_Void_KeyValuePair_2_Int32_Cooker_0;

			// Token: 0x04005512 RID: 21778
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__25_Internal_Void_KeyValuePair_2_Int32_Cooker_0;

			// Token: 0x04005513 RID: 21779
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__26_Internal_Void_Cooker_0;

			// Token: 0x04005514 RID: 21780
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__27_Internal_Void_KeyValuePair_2_Int32_Cooker_0;
		}

		// Token: 0x020004E0 RID: 1248
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+<>c__DisplayClass54_1")]
		public sealed class __c__DisplayClass54_1 : Il2CppSystem.Object
		{
			// Token: 0x060081CC RID: 33228 RVA: 0x0024A548 File Offset: 0x00248748
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_1()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "<>c__DisplayClass54_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_1>.NativeClassPtr);
				IzakayaConfigPannel.__c__DisplayClass54_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_1>.NativeClassPtr, "x");
				IzakayaConfigPannel.__c__DisplayClass54_1.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_1>.NativeClassPtr, "CS$<>8__locals1");
				IzakayaConfigPannel.__c__DisplayClass54_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_1>.NativeClassPtr, 100664380);
				IzakayaConfigPannel.__c__DisplayClass54_1.NativeMethodInfoPtr__OnPanelInitialize_b__30_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_1>.NativeClassPtr, 100664381);
			}

			// Token: 0x060081CD RID: 33229 RVA: 0x0024A5C4 File Offset: 0x002487C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081CE RID: 33230 RVA: 0x0024A600 File Offset: 0x00248800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28468, XrefRangeEnd = 28474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__30()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_1.NativeMethodInfoPtr__OnPanelInitialize_b__30_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081CF RID: 33231 RVA: 0x000461F6 File Offset: 0x000443F6
			public __c__DisplayClass54_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BBB RID: 11195
			// (get) Token: 0x060081D0 RID: 33232 RVA: 0x0024A634 File Offset: 0x00248834
			// (set) Token: 0x060081D1 RID: 33233 RVA: 0x000461FF File Offset: 0x000443FF
			public unsafe Recipe x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_1.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_1.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BBC RID: 11196
			// (get) Token: 0x060081D2 RID: 33234 RVA: 0x0024A664 File Offset: 0x00248864
			// (set) Token: 0x060081D3 RID: 33235 RVA: 0x0004621E File Offset: 0x0004441E
			public unsafe IzakayaConfigPannel.__c__DisplayClass54_0 field_Public___c__DisplayClass54_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_1.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.__c__DisplayClass54_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_1.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005515 RID: 21781
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04005516 RID: 21782
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0;

			// Token: 0x04005517 RID: 21783
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005518 RID: 21784
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__30_Internal_Void_0;
		}

		// Token: 0x020004E1 RID: 1249
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+<>c__DisplayClass54_2")]
		public sealed class __c__DisplayClass54_2 : Il2CppSystem.Object
		{
			// Token: 0x060081D4 RID: 33236 RVA: 0x0024A694 File Offset: 0x00248894
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_2()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "<>c__DisplayClass54_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_2>.NativeClassPtr);
				IzakayaConfigPannel.__c__DisplayClass54_2.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_2>.NativeClassPtr, "value");
				IzakayaConfigPannel.__c__DisplayClass54_2.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_2>.NativeClassPtr, "CS$<>8__locals2");
				IzakayaConfigPannel.__c__DisplayClass54_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_2>.NativeClassPtr, 100664382);
				IzakayaConfigPannel.__c__DisplayClass54_2.NativeMethodInfoPtr__OnPanelInitialize_b__33_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_2>.NativeClassPtr, 100664383);
			}

			// Token: 0x060081D5 RID: 33237 RVA: 0x0024A710 File Offset: 0x00248910
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081D6 RID: 33238 RVA: 0x0024A74C File Offset: 0x0024894C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28474, XrefRangeEnd = 28476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__33()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_2.NativeMethodInfoPtr__OnPanelInitialize_b__33_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081D7 RID: 33239 RVA: 0x0004623D File Offset: 0x0004443D
			public __c__DisplayClass54_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BBD RID: 11197
			// (get) Token: 0x060081D8 RID: 33240 RVA: 0x0024A780 File Offset: 0x00248980
			// (set) Token: 0x060081D9 RID: 33241 RVA: 0x00046246 File Offset: 0x00044446
			public unsafe Sellable value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_2.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_2.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BBE RID: 11198
			// (get) Token: 0x060081DA RID: 33242 RVA: 0x0024A7B0 File Offset: 0x002489B0
			// (set) Token: 0x060081DB RID: 33243 RVA: 0x00046265 File Offset: 0x00044465
			public unsafe IzakayaConfigPannel.__c__DisplayClass54_0 field_Public___c__DisplayClass54_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_2.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.__c__DisplayClass54_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_2.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005519 RID: 21785
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400551A RID: 21786
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0;

			// Token: 0x0400551B RID: 21787
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400551C RID: 21788
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__33_Internal_Void_0;
		}

		// Token: 0x020004E2 RID: 1250
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+<>c__DisplayClass54_3")]
		public sealed class __c__DisplayClass54_3 : Il2CppSystem.Object
		{
			// Token: 0x060081DC RID: 33244 RVA: 0x0024A7E0 File Offset: 0x002489E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_3()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "<>c__DisplayClass54_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_3>.NativeClassPtr);
				IzakayaConfigPannel.__c__DisplayClass54_3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_3>.NativeClassPtr, "x");
				IzakayaConfigPannel.__c__DisplayClass54_3.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_3>.NativeClassPtr, "CS$<>8__locals3");
				IzakayaConfigPannel.__c__DisplayClass54_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_3>.NativeClassPtr, 100664384);
				IzakayaConfigPannel.__c__DisplayClass54_3.NativeMethodInfoPtr__OnPanelInitialize_b__40_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_3>.NativeClassPtr, 100664385);
			}

			// Token: 0x060081DD RID: 33245 RVA: 0x0024A85C File Offset: 0x00248A5C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081DE RID: 33246 RVA: 0x0024A898 File Offset: 0x00248A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28476, XrefRangeEnd = 28480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__40()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_3.NativeMethodInfoPtr__OnPanelInitialize_b__40_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081DF RID: 33247 RVA: 0x00046284 File Offset: 0x00044484
			public __c__DisplayClass54_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BBF RID: 11199
			// (get) Token: 0x060081E0 RID: 33248 RVA: 0x0024A8CC File Offset: 0x00248ACC
			// (set) Token: 0x060081E1 RID: 33249 RVA: 0x0004628D File Offset: 0x0004448D
			public unsafe Cooker x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_3.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cooker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_3.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BC0 RID: 11200
			// (get) Token: 0x060081E2 RID: 33250 RVA: 0x0024A8FC File Offset: 0x00248AFC
			// (set) Token: 0x060081E3 RID: 33251 RVA: 0x000462AC File Offset: 0x000444AC
			public unsafe IzakayaConfigPannel.__c__DisplayClass54_0 field_Public___c__DisplayClass54_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_3.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.__c__DisplayClass54_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_3.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400551D RID: 21789
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400551E RID: 21790
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0;

			// Token: 0x0400551F RID: 21791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005520 RID: 21792
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__40_Internal_Void_0;
		}

		// Token: 0x020004E3 RID: 1251
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+<>c__DisplayClass54_4")]
		public sealed class __c__DisplayClass54_4 : Il2CppSystem.Object
		{
			// Token: 0x060081E4 RID: 33252 RVA: 0x0024A92C File Offset: 0x00248B2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_4()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "<>c__DisplayClass54_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_4>.NativeClassPtr);
				IzakayaConfigPannel.__c__DisplayClass54_4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_4>.NativeClassPtr, "x");
				IzakayaConfigPannel.__c__DisplayClass54_4.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_4>.NativeClassPtr, "CS$<>8__locals4");
				IzakayaConfigPannel.__c__DisplayClass54_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_4>.NativeClassPtr, 100664386);
				IzakayaConfigPannel.__c__DisplayClass54_4.NativeMethodInfoPtr__OnPanelInitialize_b__41_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_4>.NativeClassPtr, 100664387);
			}

			// Token: 0x060081E5 RID: 33253 RVA: 0x0024A9A8 File Offset: 0x00248BA8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass54_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081E6 RID: 33254 RVA: 0x0024A9E4 File Offset: 0x00248BE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28480, XrefRangeEnd = 28484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__41()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass54_4.NativeMethodInfoPtr__OnPanelInitialize_b__41_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081E7 RID: 33255 RVA: 0x000462CB File Offset: 0x000444CB
			public __c__DisplayClass54_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BC1 RID: 11201
			// (get) Token: 0x060081E8 RID: 33256 RVA: 0x0024AA18 File Offset: 0x00248C18
			// (set) Token: 0x060081E9 RID: 33257 RVA: 0x000462D4 File Offset: 0x000444D4
			public KeyValuePair<int, Cooker> x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_4.NativeFieldInfoPtr_x);
					return new KeyValuePair<int, Cooker>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<int, Cooker>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_4.NativeFieldInfoPtr_x), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<int, Cooker>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002BC2 RID: 11202
			// (get) Token: 0x060081EA RID: 33258 RVA: 0x0024AA48 File Offset: 0x00248C48
			// (set) Token: 0x060081EB RID: 33259 RVA: 0x00046302 File Offset: 0x00044502
			public unsafe IzakayaConfigPannel.__c__DisplayClass54_0 field_Public___c__DisplayClass54_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_4.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.__c__DisplayClass54_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass54_4.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005521 RID: 21793
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04005522 RID: 21794
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0;

			// Token: 0x04005523 RID: 21795
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005524 RID: 21796
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__41_Internal_Void_0;
		}

		// Token: 0x020004E4 RID: 1252
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060081EC RID: 33260 RVA: 0x0024AA78 File Offset: 0x00248C78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr);
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__54_7");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__54_8");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__54_31");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__54_32");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__54_15");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__54_16");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_35 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__54_35");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__54_36");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_37 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__54_37");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__54_22");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_39 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__54_39");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__57_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__57_4");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__57_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__57_3");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__61_0");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__61_13");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__61_10");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__61_11");
				IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, "<>9__61_15");
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664389);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_7_Internal_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664390);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_8_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664391);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_31_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664392);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_32_Internal_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664393);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_15_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664394);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_16_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664395);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_35_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664396);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_36_Internal_Int32_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664397);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_37_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664398);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_22_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664399);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_39_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664400);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__LoadPresetInternal_b__57_4_Internal_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664401);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__LoadPresetInternal_b__57_3_Internal_Int32_KeyValuePair_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664402);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__SolveDailyCompletion_b__61_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664403);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__SolveDailyCompletion_b__61_13_Internal_String_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664404);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__SolveDailyCompletion_b__61_10_Internal_String_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664405);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__SolveDailyCompletion_b__61_11_Internal_String_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664406);
				IzakayaConfigPannel.__c.NativeMethodInfoPtr__SolveDailyCompletion_b__61_15_Internal_String_ValueTuple_2_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr, 100664407);
			}

			// Token: 0x060081ED RID: 33261 RVA: 0x0024AD9C File Offset: 0x00248F9C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060081EE RID: 33262 RVA: 0x0024ADD8 File Offset: 0x00248FD8
			[CallerCount(0)]
			public unsafe int _OnPanelInitialize_b__54_7(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_7_Internal_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081EF RID: 33263 RVA: 0x0024AE28 File Offset: 0x00249028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28484, XrefRangeEnd = 28488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__54_8(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_8_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081F0 RID: 33264 RVA: 0x0024AE74 File Offset: 0x00249074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28488, XrefRangeEnd = 28493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__54_31(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_31_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081F1 RID: 33265 RVA: 0x0024AEC4 File Offset: 0x002490C4
			[CallerCount(0)]
			public unsafe int _OnPanelInitialize_b__54_32(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_32_Internal_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081F2 RID: 33266 RVA: 0x0024AF14 File Offset: 0x00249114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28493, XrefRangeEnd = 28495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelInitialize_b__54_15(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_15_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081F3 RID: 33267 RVA: 0x0024AF64 File Offset: 0x00249164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28495, XrefRangeEnd = 28499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__54_16(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_16_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081F4 RID: 33268 RVA: 0x0024AFB0 File Offset: 0x002491B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28499, XrefRangeEnd = 28505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__54_35(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_35_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081F5 RID: 33269 RVA: 0x0024B004 File Offset: 0x00249204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28505, XrefRangeEnd = 28506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelInitialize_b__54_36(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_36_Internal_Int32_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081F6 RID: 33270 RVA: 0x0024B058 File Offset: 0x00249258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28506, XrefRangeEnd = 28507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _OnPanelInitialize_b__54_37(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_37_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x060081F7 RID: 33271 RVA: 0x0024B0B0 File Offset: 0x002492B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28507, XrefRangeEnd = 28511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelInitialize_b__54_22(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_22_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081F8 RID: 33272 RVA: 0x0024B0FC File Offset: 0x002492FC
			[CallerCount(0)]
			public unsafe bool _OnPanelInitialize_b__54_39(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__54_39_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081F9 RID: 33273 RVA: 0x0024B148 File Offset: 0x00249348
			[CallerCount(0)]
			public unsafe int _LoadPresetInternal_b__57_4(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__LoadPresetInternal_b__57_4_Internal_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081FA RID: 33274 RVA: 0x0024B198 File Offset: 0x00249398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28511, XrefRangeEnd = 28512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _LoadPresetInternal_b__57_3(KeyValuePair<Cooker, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__LoadPresetInternal_b__57_3_Internal_Int32_KeyValuePair_2_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081FB RID: 33275 RVA: 0x0024B1EC File Offset: 0x002493EC
			[CallerCount(0)]
			public unsafe bool _SolveDailyCompletion_b__61_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__SolveDailyCompletion_b__61_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060081FC RID: 33276 RVA: 0x0024B238 File Offset: 0x00249438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28512, XrefRangeEnd = 28515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _SolveDailyCompletion_b__61_13(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__SolveDailyCompletion_b__61_13_Internal_String_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060081FD RID: 33277 RVA: 0x0024B280 File Offset: 0x00249480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _SolveDailyCompletion_b__61_10(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__SolveDailyCompletion_b__61_10_Internal_String_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060081FE RID: 33278 RVA: 0x0024B2C8 File Offset: 0x002494C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _SolveDailyCompletion_b__61_11(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__SolveDailyCompletion_b__61_11_Internal_String_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060081FF RID: 33279 RVA: 0x0024B310 File Offset: 0x00249510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28515, XrefRangeEnd = 28516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _SolveDailyCompletion_b__61_15(ValueTuple<string, Action> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c.NativeMethodInfoPtr__SolveDailyCompletion_b__61_15_Internal_String_ValueTuple_2_String_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008200 RID: 33280 RVA: 0x00046321 File Offset: 0x00044521
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BC3 RID: 11203
			// (get) Token: 0x06008201 RID: 33281 RVA: 0x0024B360 File Offset: 0x00249560
			// (set) Token: 0x06008202 RID: 33282 RVA: 0x0004632A File Offset: 0x0004452A
			public unsafe static IzakayaConfigPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BC4 RID: 11204
			// (get) Token: 0x06008203 RID: 33283 RVA: 0x0024B388 File Offset: 0x00249588
			// (set) Token: 0x06008204 RID: 33284 RVA: 0x0004633C File Offset: 0x0004453C
			public unsafe static Func<Recipe, int> __9__54_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BC5 RID: 11205
			// (get) Token: 0x06008205 RID: 33285 RVA: 0x0024B3B0 File Offset: 0x002495B0
			// (set) Token: 0x06008206 RID: 33286 RVA: 0x0004634E File Offset: 0x0004454E
			public unsafe static Func<int, bool> __9__54_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BC6 RID: 11206
			// (get) Token: 0x06008207 RID: 33287 RVA: 0x0024B3D8 File Offset: 0x002495D8
			// (set) Token: 0x06008208 RID: 33288 RVA: 0x00046360 File Offset: 0x00044560
			public unsafe static Func<Recipe, bool> __9__54_31
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_31, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_31, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BC7 RID: 11207
			// (get) Token: 0x06008209 RID: 33289 RVA: 0x0024B400 File Offset: 0x00249600
			// (set) Token: 0x0600820A RID: 33290 RVA: 0x00046372 File Offset: 0x00044572
			public unsafe static Func<Recipe, int> __9__54_32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BC8 RID: 11208
			// (get) Token: 0x0600820B RID: 33291 RVA: 0x0024B428 File Offset: 0x00249628
			// (set) Token: 0x0600820C RID: 33292 RVA: 0x00046384 File Offset: 0x00044584
			public unsafe static Func<Sellable, int> __9__54_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BC9 RID: 11209
			// (get) Token: 0x0600820D RID: 33293 RVA: 0x0024B450 File Offset: 0x00249650
			// (set) Token: 0x0600820E RID: 33294 RVA: 0x00046396 File Offset: 0x00044596
			public unsafe static Func<int, bool> __9__54_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BCA RID: 11210
			// (get) Token: 0x0600820F RID: 33295 RVA: 0x0024B478 File Offset: 0x00249678
			// (set) Token: 0x06008210 RID: 33296 RVA: 0x000463A8 File Offset: 0x000445A8
			public unsafe static Func<KeyValuePair<Sellable, int>, bool> __9__54_35
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_35, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_35, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BCB RID: 11211
			// (get) Token: 0x06008211 RID: 33297 RVA: 0x0024B4A0 File Offset: 0x002496A0
			// (set) Token: 0x06008212 RID: 33298 RVA: 0x000463BA File Offset: 0x000445BA
			public unsafe static Func<KeyValuePair<Sellable, int>, int> __9__54_36
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_36, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_36, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BCC RID: 11212
			// (get) Token: 0x06008213 RID: 33299 RVA: 0x0024B4C8 File Offset: 0x002496C8
			// (set) Token: 0x06008214 RID: 33300 RVA: 0x000463CC File Offset: 0x000445CC
			public unsafe static Func<KeyValuePair<Sellable, int>, Sellable> __9__54_37
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_37, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_37, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BCD RID: 11213
			// (get) Token: 0x06008215 RID: 33301 RVA: 0x0024B4F0 File Offset: 0x002496F0
			// (set) Token: 0x06008216 RID: 33302 RVA: 0x000463DE File Offset: 0x000445DE
			public unsafe static Func<int, bool> __9__54_22
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_22, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_22, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BCE RID: 11214
			// (get) Token: 0x06008217 RID: 33303 RVA: 0x0024B518 File Offset: 0x00249718
			// (set) Token: 0x06008218 RID: 33304 RVA: 0x000463F0 File Offset: 0x000445F0
			public unsafe static Func<int, bool> __9__54_39
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_39, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__54_39, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BCF RID: 11215
			// (get) Token: 0x06008219 RID: 33305 RVA: 0x0024B540 File Offset: 0x00249740
			// (set) Token: 0x0600821A RID: 33306 RVA: 0x00046402 File Offset: 0x00044602
			public unsafe static Func<Recipe, int> __9__57_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__57_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__57_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BD0 RID: 11216
			// (get) Token: 0x0600821B RID: 33307 RVA: 0x0024B568 File Offset: 0x00249768
			// (set) Token: 0x0600821C RID: 33308 RVA: 0x00046414 File Offset: 0x00044614
			public unsafe static Func<KeyValuePair<Cooker, int>, int> __9__57_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__57_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Cooker, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__57_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BD1 RID: 11217
			// (get) Token: 0x0600821D RID: 33309 RVA: 0x0024B590 File Offset: 0x00249790
			// (set) Token: 0x0600821E RID: 33310 RVA: 0x00046426 File Offset: 0x00044626
			public unsafe static Func<int, bool> __9__61_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BD2 RID: 11218
			// (get) Token: 0x0600821F RID: 33311 RVA: 0x0024B5B8 File Offset: 0x002497B8
			// (set) Token: 0x06008220 RID: 33312 RVA: 0x00046438 File Offset: 0x00044638
			public unsafe static Func<Recipe, string> __9__61_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BD3 RID: 11219
			// (get) Token: 0x06008221 RID: 33313 RVA: 0x0024B5E0 File Offset: 0x002497E0
			// (set) Token: 0x06008222 RID: 33314 RVA: 0x0004644A File Offset: 0x0004464A
			public unsafe static Func<Sellable, string> __9__61_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BD4 RID: 11220
			// (get) Token: 0x06008223 RID: 33315 RVA: 0x0024B608 File Offset: 0x00249808
			// (set) Token: 0x06008224 RID: 33316 RVA: 0x0004645C File Offset: 0x0004465C
			public unsafe static Func<Sellable, string> __9__61_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BD5 RID: 11221
			// (get) Token: 0x06008225 RID: 33317 RVA: 0x0024B630 File Offset: 0x00249830
			// (set) Token: 0x06008226 RID: 33318 RVA: 0x0004646E File Offset: 0x0004466E
			public unsafe static Func<ValueTuple<string, Action>, string> __9__61_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<string, Action>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaConfigPannel.__c.NativeFieldInfoPtr___9__61_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005525 RID: 21797
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005526 RID: 21798
			private static readonly IntPtr NativeFieldInfoPtr___9__54_7;

			// Token: 0x04005527 RID: 21799
			private static readonly IntPtr NativeFieldInfoPtr___9__54_8;

			// Token: 0x04005528 RID: 21800
			private static readonly IntPtr NativeFieldInfoPtr___9__54_31;

			// Token: 0x04005529 RID: 21801
			private static readonly IntPtr NativeFieldInfoPtr___9__54_32;

			// Token: 0x0400552A RID: 21802
			private static readonly IntPtr NativeFieldInfoPtr___9__54_15;

			// Token: 0x0400552B RID: 21803
			private static readonly IntPtr NativeFieldInfoPtr___9__54_16;

			// Token: 0x0400552C RID: 21804
			private static readonly IntPtr NativeFieldInfoPtr___9__54_35;

			// Token: 0x0400552D RID: 21805
			private static readonly IntPtr NativeFieldInfoPtr___9__54_36;

			// Token: 0x0400552E RID: 21806
			private static readonly IntPtr NativeFieldInfoPtr___9__54_37;

			// Token: 0x0400552F RID: 21807
			private static readonly IntPtr NativeFieldInfoPtr___9__54_22;

			// Token: 0x04005530 RID: 21808
			private static readonly IntPtr NativeFieldInfoPtr___9__54_39;

			// Token: 0x04005531 RID: 21809
			private static readonly IntPtr NativeFieldInfoPtr___9__57_4;

			// Token: 0x04005532 RID: 21810
			private static readonly IntPtr NativeFieldInfoPtr___9__57_3;

			// Token: 0x04005533 RID: 21811
			private static readonly IntPtr NativeFieldInfoPtr___9__61_0;

			// Token: 0x04005534 RID: 21812
			private static readonly IntPtr NativeFieldInfoPtr___9__61_13;

			// Token: 0x04005535 RID: 21813
			private static readonly IntPtr NativeFieldInfoPtr___9__61_10;

			// Token: 0x04005536 RID: 21814
			private static readonly IntPtr NativeFieldInfoPtr___9__61_11;

			// Token: 0x04005537 RID: 21815
			private static readonly IntPtr NativeFieldInfoPtr___9__61_15;

			// Token: 0x04005538 RID: 21816
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005539 RID: 21817
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__54_7_Internal_Int32_Recipe_0;

			// Token: 0x0400553A RID: 21818
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__54_8_Internal_Boolean_Int32_0;

			// Token: 0x0400553B RID: 21819
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__54_31_Internal_Boolean_Recipe_0;

			// Token: 0x0400553C RID: 21820
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__54_32_Internal_Int32_Recipe_0;

			// Token: 0x0400553D RID: 21821
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__54_15_Internal_Int32_Sellable_0;

			// Token: 0x0400553E RID: 21822
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__54_16_Internal_Boolean_Int32_0;

			// Token: 0x0400553F RID: 21823
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__54_35_Internal_Boolean_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x04005540 RID: 21824
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__54_36_Internal_Int32_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x04005541 RID: 21825
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__54_37_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x04005542 RID: 21826
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__54_22_Internal_Boolean_Int32_0;

			// Token: 0x04005543 RID: 21827
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__54_39_Internal_Boolean_Int32_0;

			// Token: 0x04005544 RID: 21828
			private static readonly IntPtr NativeMethodInfoPtr__LoadPresetInternal_b__57_4_Internal_Int32_Recipe_0;

			// Token: 0x04005545 RID: 21829
			private static readonly IntPtr NativeMethodInfoPtr__LoadPresetInternal_b__57_3_Internal_Int32_KeyValuePair_2_Cooker_Int32_0;

			// Token: 0x04005546 RID: 21830
			private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__61_0_Internal_Boolean_Int32_0;

			// Token: 0x04005547 RID: 21831
			private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__61_13_Internal_String_Recipe_0;

			// Token: 0x04005548 RID: 21832
			private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__61_10_Internal_String_Sellable_0;

			// Token: 0x04005549 RID: 21833
			private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__61_11_Internal_String_Sellable_0;

			// Token: 0x0400554A RID: 21834
			private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__61_15_Internal_String_ValueTuple_2_String_Action_0;
		}

		// Token: 0x020004E5 RID: 1253
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : Il2CppSystem.Object
		{
			// Token: 0x06008227 RID: 33319 RVA: 0x0024B658 File Offset: 0x00249858
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass57_0>.NativeClassPtr);
				IzakayaConfigPannel.__c__DisplayClass57_0.NativeFieldInfoPtr_izakayaConfigure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass57_0>.NativeClassPtr, "izakayaConfigure");
				IzakayaConfigPannel.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass57_0>.NativeClassPtr, 100664408);
				IzakayaConfigPannel.__c__DisplayClass57_0.NativeMethodInfoPtr__LoadPresetInternal_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass57_0>.NativeClassPtr, 100664409);
				IzakayaConfigPannel.__c__DisplayClass57_0.NativeMethodInfoPtr__LoadPresetInternal_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass57_0>.NativeClassPtr, 100664410);
				IzakayaConfigPannel.__c__DisplayClass57_0.NativeMethodInfoPtr__LoadPresetInternal_b__2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass57_0>.NativeClassPtr, 100664411);
			}

			// Token: 0x06008228 RID: 33320 RVA: 0x0024B6E8 File Offset: 0x002498E8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass57_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008229 RID: 33321 RVA: 0x0024B724 File Offset: 0x00249924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28516, XrefRangeEnd = 28537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadPresetInternal_b__0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass57_0.NativeMethodInfoPtr__LoadPresetInternal_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600822A RID: 33322 RVA: 0x0024B770 File Offset: 0x00249970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28537, XrefRangeEnd = 28539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LoadPresetInternal_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass57_0.NativeMethodInfoPtr__LoadPresetInternal_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600822B RID: 33323 RVA: 0x0024B7B0 File Offset: 0x002499B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28539, XrefRangeEnd = 28541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LoadPresetInternal_b__2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass57_0.NativeMethodInfoPtr__LoadPresetInternal_b__2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600822C RID: 33324 RVA: 0x00046480 File Offset: 0x00044680
			public __c__DisplayClass57_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BD6 RID: 11222
			// (get) Token: 0x0600822D RID: 33325 RVA: 0x0024B7F0 File Offset: 0x002499F0
			// (set) Token: 0x0600822E RID: 33326 RVA: 0x00046489 File Offset: 0x00044689
			public unsafe IzakayaConfigure izakayaConfigure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass57_0.NativeFieldInfoPtr_izakayaConfigure);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigure>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass57_0.NativeFieldInfoPtr_izakayaConfigure), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400554B RID: 21835
			private static readonly IntPtr NativeFieldInfoPtr_izakayaConfigure;

			// Token: 0x0400554C RID: 21836
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400554D RID: 21837
			private static readonly IntPtr NativeMethodInfoPtr__LoadPresetInternal_b__0_Internal_Boolean_Int32_0;

			// Token: 0x0400554E RID: 21838
			private static readonly IntPtr NativeMethodInfoPtr__LoadPresetInternal_b__1_Internal_Void_Int32_0;

			// Token: 0x0400554F RID: 21839
			private static readonly IntPtr NativeMethodInfoPtr__LoadPresetInternal_b__2_Internal_Void_Int32_0;
		}

		// Token: 0x020004E6 RID: 1254
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+<>c__DisplayClass58_0")]
		public sealed class __c__DisplayClass58_0 : Il2CppSystem.Object
		{
			// Token: 0x0600822F RID: 33327 RVA: 0x0024B820 File Offset: 0x00249A20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_0()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "<>c__DisplayClass58_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass58_0>.NativeClassPtr);
				IzakayaConfigPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass58_0>.NativeClassPtr, "item");
				IzakayaConfigPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass58_0>.NativeClassPtr, 100664412);
				IzakayaConfigPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__GoToSpecific_b__0_Internal_Boolean_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass58_0>.NativeClassPtr, 100664413);
			}

			// Token: 0x06008230 RID: 33328 RVA: 0x0024B888 File Offset: 0x00249A88
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass58_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008231 RID: 33329 RVA: 0x0024B8C4 File Offset: 0x00249AC4
			[CallerCount(0)]
			public unsafe bool _GoToSpecific_b__0(Cooker x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass58_0.NativeMethodInfoPtr__GoToSpecific_b__0_Internal_Boolean_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008232 RID: 33330 RVA: 0x000464A8 File Offset: 0x000446A8
			public __c__DisplayClass58_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BD7 RID: 11223
			// (get) Token: 0x06008233 RID: 33331 RVA: 0x0024B914 File Offset: 0x00249B14
			// (set) Token: 0x06008234 RID: 33332 RVA: 0x000464B1 File Offset: 0x000446B1
			public unsafe int item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_item);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass58_0.NativeFieldInfoPtr_item)) = value;
				}
			}

			// Token: 0x04005550 RID: 21840
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04005551 RID: 21841
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005552 RID: 21842
			private static readonly IntPtr NativeMethodInfoPtr__GoToSpecific_b__0_Internal_Boolean_Cooker_0;
		}

		// Token: 0x020004E7 RID: 1255
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+<>c__DisplayClass61_0")]
		public sealed class __c__DisplayClass61_0 : Il2CppSystem.Object
		{
			// Token: 0x06008235 RID: 33333 RVA: 0x0024B93C File Offset: 0x00249B3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_0()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "<>c__DisplayClass61_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_0>.NativeClassPtr);
				IzakayaConfigPannel.__c__DisplayClass61_0.NativeFieldInfoPtr_bringAllCorrectCooker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_0>.NativeClassPtr, "bringAllCorrectCooker");
				IzakayaConfigPannel.__c__DisplayClass61_0.NativeFieldInfoPtr_allRecipeNumEnough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_0>.NativeClassPtr, "allRecipeNumEnough");
				IzakayaConfigPannel.__c__DisplayClass61_0.NativeFieldInfoPtr_allBeverageNumEnough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_0>.NativeClassPtr, "allBeverageNumEnough");
				IzakayaConfigPannel.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_0>.NativeClassPtr, "<>4__this");
				IzakayaConfigPannel.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_0>.NativeClassPtr, 100664414);
				IzakayaConfigPannel.__c__DisplayClass61_0.NativeMethodInfoPtr__SolveDailyCompletion_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_0>.NativeClassPtr, 100664415);
			}

			// Token: 0x06008236 RID: 33334 RVA: 0x0024B9E0 File Offset: 0x00249BE0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008237 RID: 33335 RVA: 0x0024BA1C File Offset: 0x00249C1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28541, XrefRangeEnd = 28682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SolveDailyCompletion_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass61_0.NativeMethodInfoPtr__SolveDailyCompletion_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008238 RID: 33336 RVA: 0x000464CC File Offset: 0x000446CC
			public __c__DisplayClass61_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BD8 RID: 11224
			// (get) Token: 0x06008239 RID: 33337 RVA: 0x0024BA50 File Offset: 0x00249C50
			// (set) Token: 0x0600823A RID: 33338 RVA: 0x000464D5 File Offset: 0x000446D5
			public unsafe bool bringAllCorrectCooker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_0.NativeFieldInfoPtr_bringAllCorrectCooker);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_0.NativeFieldInfoPtr_bringAllCorrectCooker)) = value;
				}
			}

			// Token: 0x17002BD9 RID: 11225
			// (get) Token: 0x0600823B RID: 33339 RVA: 0x0024BA78 File Offset: 0x00249C78
			// (set) Token: 0x0600823C RID: 33340 RVA: 0x000464F0 File Offset: 0x000446F0
			public unsafe bool allRecipeNumEnough
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_0.NativeFieldInfoPtr_allRecipeNumEnough);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_0.NativeFieldInfoPtr_allRecipeNumEnough)) = value;
				}
			}

			// Token: 0x17002BDA RID: 11226
			// (get) Token: 0x0600823D RID: 33341 RVA: 0x0024BAA0 File Offset: 0x00249CA0
			// (set) Token: 0x0600823E RID: 33342 RVA: 0x0004650B File Offset: 0x0004470B
			public unsafe bool allBeverageNumEnough
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_0.NativeFieldInfoPtr_allBeverageNumEnough);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_0.NativeFieldInfoPtr_allBeverageNumEnough)) = value;
				}
			}

			// Token: 0x17002BDB RID: 11227
			// (get) Token: 0x0600823F RID: 33343 RVA: 0x0024BAC8 File Offset: 0x00249CC8
			// (set) Token: 0x06008240 RID: 33344 RVA: 0x00046526 File Offset: 0x00044726
			public unsafe IzakayaConfigPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005553 RID: 21843
			private static readonly IntPtr NativeFieldInfoPtr_bringAllCorrectCooker;

			// Token: 0x04005554 RID: 21844
			private static readonly IntPtr NativeFieldInfoPtr_allRecipeNumEnough;

			// Token: 0x04005555 RID: 21845
			private static readonly IntPtr NativeFieldInfoPtr_allBeverageNumEnough;

			// Token: 0x04005556 RID: 21846
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005557 RID: 21847
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005558 RID: 21848
			private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__8_Internal_Void_0;
		}

		// Token: 0x020004E8 RID: 1256
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+<>c__DisplayClass61_1")]
		public sealed class __c__DisplayClass61_1 : Il2CppSystem.Object
		{
			// Token: 0x06008241 RID: 33345 RVA: 0x0024BAF8 File Offset: 0x00249CF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_1()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "<>c__DisplayClass61_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_1>.NativeClassPtr);
				IzakayaConfigPannel.__c__DisplayClass61_1.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_1>.NativeClassPtr, "recipe");
				IzakayaConfigPannel.__c__DisplayClass61_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_1>.NativeClassPtr, 100664416);
				IzakayaConfigPannel.__c__DisplayClass61_1.NativeMethodInfoPtr__SolveDailyCompletion_b__9_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_1>.NativeClassPtr, 100664417);
			}

			// Token: 0x06008242 RID: 33346 RVA: 0x0024BB60 File Offset: 0x00249D60
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass61_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008243 RID: 33347 RVA: 0x0024BB9C File Offset: 0x00249D9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28682, XrefRangeEnd = 28687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SolveDailyCompletion_b__9(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass61_1.NativeMethodInfoPtr__SolveDailyCompletion_b__9_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008244 RID: 33348 RVA: 0x00046545 File Offset: 0x00044745
			public __c__DisplayClass61_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BDC RID: 11228
			// (get) Token: 0x06008245 RID: 33349 RVA: 0x0024BBE8 File Offset: 0x00249DE8
			// (set) Token: 0x06008246 RID: 33350 RVA: 0x0004654E File Offset: 0x0004474E
			public unsafe Recipe recipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_1.NativeFieldInfoPtr_recipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_1.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005559 RID: 21849
			private static readonly IntPtr NativeFieldInfoPtr_recipe;

			// Token: 0x0400555A RID: 21850
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400555B RID: 21851
			private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__9_Internal_Boolean_Int32_0;
		}

		// Token: 0x020004E9 RID: 1257
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+<>c__DisplayClass61_2")]
		public sealed class __c__DisplayClass61_2 : Il2CppSystem.Object
		{
			// Token: 0x06008247 RID: 33351 RVA: 0x0024BC18 File Offset: 0x00249E18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_2()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "<>c__DisplayClass61_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_2>.NativeClassPtr);
				IzakayaConfigPannel.__c__DisplayClass61_2.NativeFieldInfoPtr_closedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_2>.NativeClassPtr, "closedPanel");
				IzakayaConfigPannel.__c__DisplayClass61_2.NativeFieldInfoPtr_field_Public___c__DisplayClass61_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_2>.NativeClassPtr, "CS$<>8__locals1");
				IzakayaConfigPannel.__c__DisplayClass61_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_2>.NativeClassPtr, 100664418);
				IzakayaConfigPannel.__c__DisplayClass61_2.NativeMethodInfoPtr__SolveDailyCompletion_b__12_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_2>.NativeClassPtr, 100664419);
			}

			// Token: 0x06008248 RID: 33352 RVA: 0x0024BC94 File Offset: 0x00249E94
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.__c__DisplayClass61_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass61_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008249 RID: 33353 RVA: 0x0024BCD0 File Offset: 0x00249ED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28687, XrefRangeEnd = 28770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SolveDailyCompletion_b__12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.__c__DisplayClass61_2.NativeMethodInfoPtr__SolveDailyCompletion_b__12_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600824A RID: 33354 RVA: 0x0004656D File Offset: 0x0004476D
			public __c__DisplayClass61_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BDD RID: 11229
			// (get) Token: 0x0600824B RID: 33355 RVA: 0x0024BD04 File Offset: 0x00249F04
			// (set) Token: 0x0600824C RID: 33356 RVA: 0x00046576 File Offset: 0x00044776
			public unsafe RemindSubPanel closedPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_2.NativeFieldInfoPtr_closedPanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemindSubPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_2.NativeFieldInfoPtr_closedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BDE RID: 11230
			// (get) Token: 0x0600824D RID: 33357 RVA: 0x0024BD34 File Offset: 0x00249F34
			// (set) Token: 0x0600824E RID: 33358 RVA: 0x00046595 File Offset: 0x00044795
			public unsafe IzakayaConfigPannel.__c__DisplayClass61_0 field_Public___c__DisplayClass61_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_2.NativeFieldInfoPtr_field_Public___c__DisplayClass61_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel.__c__DisplayClass61_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.__c__DisplayClass61_2.NativeFieldInfoPtr_field_Public___c__DisplayClass61_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400555C RID: 21852
			private static readonly IntPtr NativeFieldInfoPtr_closedPanel;

			// Token: 0x0400555D RID: 21853
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass61_0_0;

			// Token: 0x0400555E RID: 21854
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400555F RID: 21855
			private static readonly IntPtr NativeMethodInfoPtr__SolveDailyCompletion_b__12_Internal_Void_0;
		}

		// Token: 0x020004EA RID: 1258
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+<GotoWork>d__62")]
		public sealed class _GotoWork_d__62 : ValueType
		{
			// Token: 0x0600824F RID: 33359 RVA: 0x0024BD64 File Offset: 0x00249F64
			// Note: this type is marked as 'beforefieldinit'.
			static _GotoWork_d__62()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel._GotoWork_d__62>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "<GotoWork>d__62");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel._GotoWork_d__62>.NativeClassPtr);
				IzakayaConfigPannel._GotoWork_d__62.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel._GotoWork_d__62>.NativeClassPtr, "<>1__state");
				IzakayaConfigPannel._GotoWork_d__62.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel._GotoWork_d__62>.NativeClassPtr, "<>t__builder");
				IzakayaConfigPannel._GotoWork_d__62.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel._GotoWork_d__62>.NativeClassPtr, "<>4__this");
				IzakayaConfigPannel._GotoWork_d__62.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel._GotoWork_d__62>.NativeClassPtr, "<>u__1");
				IzakayaConfigPannel._GotoWork_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel._GotoWork_d__62>.NativeClassPtr, 100664420);
				IzakayaConfigPannel._GotoWork_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel._GotoWork_d__62>.NativeClassPtr, 100664421);
			}

			// Token: 0x06008250 RID: 33360 RVA: 0x0024BE08 File Offset: 0x0024A008
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 28810, RefRangeEnd = 28813, XrefRangeStart = 28770, XrefRangeEnd = 28810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel._GotoWork_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008251 RID: 33361 RVA: 0x0024BE40 File Offset: 0x0024A040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel._GotoWork_d__62.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008252 RID: 33362 RVA: 0x000465B4 File Offset: 0x000447B4
			public _GotoWork_d__62(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008253 RID: 33363 RVA: 0x000465BD File Offset: 0x000447BD
			public _GotoWork_d__62() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel._GotoWork_d__62>.NativeClassPtr))
			{
			}

			// Token: 0x17002BDF RID: 11231
			// (get) Token: 0x06008254 RID: 33364 RVA: 0x0024BE88 File Offset: 0x0024A088
			// (set) Token: 0x06008255 RID: 33365 RVA: 0x000465CF File Offset: 0x000447CF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel._GotoWork_d__62.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel._GotoWork_d__62.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002BE0 RID: 11232
			// (get) Token: 0x06008256 RID: 33366 RVA: 0x0024BEB0 File Offset: 0x0024A0B0
			// (set) Token: 0x06008257 RID: 33367 RVA: 0x000465EA File Offset: 0x000447EA
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel._GotoWork_d__62.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel._GotoWork_d__62.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002BE1 RID: 11233
			// (get) Token: 0x06008258 RID: 33368 RVA: 0x0024BEE0 File Offset: 0x0024A0E0
			// (set) Token: 0x06008259 RID: 33369 RVA: 0x00046618 File Offset: 0x00044818
			public unsafe IzakayaConfigPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel._GotoWork_d__62.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel._GotoWork_d__62.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BE2 RID: 11234
			// (get) Token: 0x0600825A RID: 33370 RVA: 0x0024BF10 File Offset: 0x0024A110
			// (set) Token: 0x0600825B RID: 33371 RVA: 0x00046637 File Offset: 0x00044837
			public UniTask<bool>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel._GotoWork_d__62.NativeFieldInfoPtr___u__1);
					return new UniTask<bool>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel._GotoWork_d__62.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005560 RID: 21856
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005561 RID: 21857
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005562 RID: 21858
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005563 RID: 21859
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005564 RID: 21860
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005565 RID: 21861
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020004EB RID: 1259
		[ObfuscatedName("PrepNightScene.UI.IzakayaConfigPannel+<<SolveDailyCompletion>g__Execute|61_16>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600825C RID: 33372 RVA: 0x0024BF40 File Offset: 0x0024A140
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique()
			{
				Il2CppClassPointerStore<IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaConfigPannel>.NativeClassPtr, "<<SolveDailyCompletion>g__Execute|61_16>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique>.NativeClassPtr);
				IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique>.NativeClassPtr, "<>1__state");
				IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique>.NativeClassPtr, "<>2__current");
				IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique>.NativeClassPtr, "<>4__this");
				IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique>.NativeClassPtr, 100664422);
				IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique>.NativeClassPtr, 100664423);
				IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique>.NativeClassPtr, 100664424);
				IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique>.NativeClassPtr, 100664425);
				IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique>.NativeClassPtr, 100664426);
				IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique>.NativeClassPtr, 100664427);
			}

			// Token: 0x0600825D RID: 33373 RVA: 0x0024C020 File Offset: 0x0024A220
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600825E RID: 33374 RVA: 0x0024C068 File Offset: 0x0024A268
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600825F RID: 33375 RVA: 0x0024C09C File Offset: 0x0024A29C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28813, XrefRangeEnd = 28819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002BE6 RID: 11238
			// (get) Token: 0x06008260 RID: 33376 RVA: 0x0024C0D8 File Offset: 0x0024A2D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008261 RID: 33377 RVA: 0x0024C118 File Offset: 0x0024A318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28819, XrefRangeEnd = 28825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002BE7 RID: 11239
			// (get) Token: 0x06008262 RID: 33378 RVA: 0x0024C14C File Offset: 0x0024A34C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008263 RID: 33379 RVA: 0x00046665 File Offset: 0x00044865
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002BE3 RID: 11235
			// (get) Token: 0x06008264 RID: 33380 RVA: 0x0024C18C File Offset: 0x0024A38C
			// (set) Token: 0x06008265 RID: 33381 RVA: 0x0004666E File Offset: 0x0004486E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002BE4 RID: 11236
			// (get) Token: 0x06008266 RID: 33382 RVA: 0x0024C1B4 File Offset: 0x0024A3B4
			// (set) Token: 0x06008267 RID: 33383 RVA: 0x00046689 File Offset: 0x00044889
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002BE5 RID: 11237
			// (get) Token: 0x06008268 RID: 33384 RVA: 0x0024C1E4 File Offset: 0x0024A3E4
			// (set) Token: 0x06008269 RID: 33385 RVA: 0x000466A8 File Offset: 0x000448A8
			public unsafe IzakayaConfigPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaConfigPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaConfigPannel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObIzObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005566 RID: 21862
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005567 RID: 21863
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005568 RID: 21864
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005569 RID: 21865
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400556A RID: 21866
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400556B RID: 21867
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400556C RID: 21868
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400556D RID: 21869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400556E RID: 21870
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
