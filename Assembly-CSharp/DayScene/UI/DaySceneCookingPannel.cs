using System;
using Common.UI;
using Common.UI.Filter;
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
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020000BE RID: 190
	public class DaySceneCookingPannel : UIPanel
	{
		// Token: 0x06001525 RID: 5413 RVA: 0x000E5B58 File Offset: 0x000E3D58
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneCookingPannel()
		{
			Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneCookingPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr);
			DaySceneCookingPannel.NativeFieldInfoPtr_customSpacingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "customSpacingRect");
			DaySceneCookingPannel.NativeFieldInfoPtr_objectElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "objectElement");
			DaySceneCookingPannel.NativeFieldInfoPtr_objectStackElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "objectStackElement");
			DaySceneCookingPannel.NativeFieldInfoPtr_m_AllRowsBackgrounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "m_AllRowsBackgrounds");
			DaySceneCookingPannel.NativeFieldInfoPtr_recipeField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "recipeField");
			DaySceneCookingPannel.NativeFieldInfoPtr_outputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "outputField");
			DaySceneCookingPannel.NativeFieldInfoPtr_sellableDescriber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "sellableDescriber");
			DaySceneCookingPannel.NativeFieldInfoPtr_onDisabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "onDisabledColor");
			DaySceneCookingPannel.NativeFieldInfoPtr_onSubmitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "onSubmitButton");
			DaySceneCookingPannel.NativeFieldInfoPtr_timeFieldVariations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "timeFieldVariations");
			DaySceneCookingPannel.NativeFieldInfoPtr_RecipeScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "RecipeScroller");
			DaySceneCookingPannel.NativeFieldInfoPtr_SelectedScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "SelectedScroller");
			DaySceneCookingPannel.NativeFieldInfoPtr_DescriberSwitcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "DescriberSwitcher");
			DaySceneCookingPannel.NativeFieldInfoPtr_m_RequiredIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "m_RequiredIngredients");
			DaySceneCookingPannel.NativeFieldInfoPtr_filterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "filterButton");
			DaySceneCookingPannel.NativeFieldInfoPtr_allRecipeInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "allRecipeInstances");
			DaySceneCookingPannel.NativeFieldInfoPtr_listVariationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "listVariationIndex");
			DaySceneCookingPannel.NativeFieldInfoPtr_m_FilterConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "m_FilterConfigs");
			DaySceneCookingPannel.NativeFieldInfoPtr_scheduledRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "scheduledRecipes");
			DaySceneCookingPannel.NativeFieldInfoPtr_willRemovedIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "willRemovedIngredients");
			DaySceneCookingPannel.NativeFieldInfoPtr_cookCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "cookCount");
			DaySceneCookingPannel.NativeFieldInfoPtr_currentCookActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "currentCookActions");
			DaySceneCookingPannel.NativeFieldInfoPtr_m_RecipeFieldGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "m_RecipeFieldGroup");
			DaySceneCookingPannel.NativeFieldInfoPtr_m_SelectedFieldGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "m_SelectedFieldGroup");
			DaySceneCookingPannel.NativeFieldInfoPtr_maxCookCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "maxCookCount");
			DaySceneCookingPannel.NativeFieldInfoPtr_variations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "variations");
			DaySceneCookingPannel.NativeFieldInfoPtr_describerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "describerCanvasGroup");
			DaySceneCookingPannel.NativeMethodInfoPtr_get_IsRegisteredUpToLimit_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667102);
			DaySceneCookingPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667103);
			DaySceneCookingPannel.NativeMethodInfoPtr_UpdateRecipeRequireIngredients_Private_Void_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667104);
			DaySceneCookingPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667105);
			DaySceneCookingPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667106);
			DaySceneCookingPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667107);
			DaySceneCookingPannel.NativeMethodInfoPtr_GetVisualAtIndex_Private_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667108);
			DaySceneCookingPannel.NativeMethodInfoPtr_GetTimeStampAtIndex_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667109);
			DaySceneCookingPannel.NativeMethodInfoPtr_UpdateElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667110);
			DaySceneCookingPannel.NativeMethodInfoPtr_OnTertiarySwitchPresed_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667111);
			DaySceneCookingPannel.NativeMethodInfoPtr_OpenFilterPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667112);
			DaySceneCookingPannel.NativeMethodInfoPtr_ConfirmChoiceStart_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667113);
			DaySceneCookingPannel.NativeMethodInfoPtr_ConfirmChoiceEnd_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667114);
			DaySceneCookingPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667115);
			DaySceneCookingPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667116);
			DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelInitialize_b__29_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667117);
			DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelInitialize_b__29_1_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667118);
			DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelInitialize_b__29_2_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667119);
			DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelOpen_b__32_1_Private_Void_ScheduledRecipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667120);
			DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelOpen_b__32_2_Private_Void_BorderElementType_Int32_Int32_Nullable_1_ValueTuple_3_ScheduledRecipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667121);
			DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelOpen_b__32_5_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667122);
			DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelOpen_b__32_8_Private_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667123);
			DaySceneCookingPannel.NativeMethodInfoPtr__OpenFilterPanel_b__38_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, 100667124);
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x000E5F70 File Offset: 0x000E4170
		public unsafe bool IsRegisteredUpToLimit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60262, XrefRangeEnd = 60263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr_get_IsRegisteredUpToLimit_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000E5FAC File Offset: 0x000E41AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60263, XrefRangeEnd = 60355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneCookingPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x000E5FE8 File Offset: 0x000E41E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60355, XrefRangeEnd = 60364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRecipeRequireIngredients(Recipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr_UpdateRecipeRequireIngredients_Private_Void_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x000E602C File Offset: 0x000E422C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60364, XrefRangeEnd = 60374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneCookingPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x000E6068 File Offset: 0x000E4268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60374, XrefRangeEnd = 60453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneCookingPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x000E60A4 File Offset: 0x000E42A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60453, XrefRangeEnd = 60468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneCookingPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x000E60E0 File Offset: 0x000E42E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60468, XrefRangeEnd = 60487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GetVisualAtIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr_GetVisualAtIndex_Private_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x000E612C File Offset: 0x000E432C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60487, XrefRangeEnd = 60502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTimeStampAtIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr_GetTimeStampAtIndex_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x000E6170 File Offset: 0x000E4370
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 60540, RefRangeEnd = 60544, XrefRangeStart = 60502, XrefRangeEnd = 60540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr_UpdateElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x000E61A4 File Offset: 0x000E43A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60544, XrefRangeEnd = 60577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTertiarySwitchPresed(InputAction.CallbackContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr_OnTertiarySwitchPresed_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000E61EC File Offset: 0x000E43EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60577, XrefRangeEnd = 60607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenFilterPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr_OpenFilterPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000E6220 File Offset: 0x000E4420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60607, XrefRangeEnd = 60611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmChoiceStart(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr_ConfirmChoiceStart_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x000E6268 File Offset: 0x000E4468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60611, XrefRangeEnd = 60613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmChoiceEnd(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr_ConfirmChoiceEnd_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x000E62B0 File Offset: 0x000E44B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60613, XrefRangeEnd = 60646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneCookingPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x000E62EC File Offset: 0x000E44EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60646, XrefRangeEnd = 60681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneCookingPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000E6328 File Offset: 0x000E4528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60681, XrefRangeEnd = 60706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__29_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelInitialize_b__29_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000E635C File Offset: 0x000E455C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60706, XrefRangeEnd = 60735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__29_1(Recipe recipe, UIElementCluster cluster, UIButtonSimple _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelInitialize_b__29_1_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000E63C4 File Offset: 0x000E45C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60735, XrefRangeEnd = 60763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__29_2(Recipe recipe, UIElementCluster _, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelInitialize_b__29_2_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x000E642C File Offset: 0x000E462C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60763, XrefRangeEnd = 60779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__32_1(DaySceneCookingPannel.ScheduledRecipe recipe, UIElementCluster _, UIButtonSimple btn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(btn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelOpen_b__32_1_Private_Void_ScheduledRecipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000E6494 File Offset: 0x000E4694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60779, XrefRangeEnd = 60811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__32_2(AdpUISystemUtils.BorderElementType _, int _, int row, Nullable<ValueTuple<DaySceneCookingPannel.ScheduledRecipe, UIElementCluster, UIButtonSimple>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref row;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelOpen_b__32_2_Private_Void_BorderElementType_Int32_Int32_Nullable_1_ValueTuple_3_ScheduledRecipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000E6508 File Offset: 0x000E4708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60811, XrefRangeEnd = 60816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__32_5(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelOpen_b__32_5_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x000E654C File Offset: 0x000E474C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__32_8(Image x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr__OnPanelOpen_b__32_8_Private_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x000E6590 File Offset: 0x000E4790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60816, XrefRangeEnd = 60821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenFilterPanel_b__38_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.NativeMethodInfoPtr__OpenFilterPanel_b__38_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0000D29A File Offset: 0x0000B49A
		public DaySceneCookingPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x000E65C4 File Offset: 0x000E47C4
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x0000D2A3 File Offset: 0x0000B4A3
		public unsafe RectTransform customSpacingRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_customSpacingRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_customSpacingRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x000E65F4 File Offset: 0x000E47F4
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x0000D2C2 File Offset: 0x0000B4C2
		public unsafe GameObject objectElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_objectElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_objectElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x000E6624 File Offset: 0x000E4824
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x0000D2E1 File Offset: 0x0000B4E1
		public unsafe GameObject objectStackElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_objectStackElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_objectStackElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x000E6654 File Offset: 0x000E4854
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x0000D300 File Offset: 0x0000B500
		public unsafe Il2CppReferenceArray<UIElementCluster> m_AllRowsBackgrounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_m_AllRowsBackgrounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIElementCluster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_m_AllRowsBackgrounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x000E6684 File Offset: 0x000E4884
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x0000D31F File Offset: 0x0000B51F
		public unsafe GridLayoutGroup recipeField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_recipeField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_recipeField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x000E66B4 File Offset: 0x000E48B4
		// (set) Token: 0x06001549 RID: 5449 RVA: 0x0000D33E File Offset: 0x0000B53E
		public unsafe GridLayoutGroup outputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_outputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_outputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x000E66E4 File Offset: 0x000E48E4
		// (set) Token: 0x0600154B RID: 5451 RVA: 0x0000D35D File Offset: 0x0000B55D
		public unsafe SellableDescriber sellableDescriber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_sellableDescriber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_sellableDescriber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x000E6714 File Offset: 0x000E4914
		// (set) Token: 0x0600154D RID: 5453 RVA: 0x0000D37C File Offset: 0x0000B57C
		public unsafe Color onDisabledColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_onDisabledColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_onDisabledColor)) = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x000E673C File Offset: 0x000E493C
		// (set) Token: 0x0600154F RID: 5455 RVA: 0x0000D397 File Offset: 0x0000B597
		public unsafe UIButtonHold onSubmitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_onSubmitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_onSubmitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x000E676C File Offset: 0x000E496C
		// (set) Token: 0x06001551 RID: 5457 RVA: 0x0000D3B6 File Offset: 0x0000B5B6
		public unsafe Il2CppReferenceArray<Sprite> timeFieldVariations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_timeFieldVariations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_timeFieldVariations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x000E679C File Offset: 0x000E499C
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x0000D3D5 File Offset: 0x0000B5D5
		public unsafe AdpProgressIndicatorComponent RecipeScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_RecipeScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_RecipeScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x000E67CC File Offset: 0x000E49CC
		// (set) Token: 0x06001555 RID: 5461 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
		public unsafe AdpProgressIndicatorComponent SelectedScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_SelectedScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_SelectedScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x000E67FC File Offset: 0x000E49FC
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x0000D413 File Offset: 0x0000B613
		public unsafe DescriberSwitcher DescriberSwitcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_DescriberSwitcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DescriberSwitcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_DescriberSwitcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x000E682C File Offset: 0x000E4A2C
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x0000D432 File Offset: 0x0000B632
		public unsafe Il2CppReferenceArray<Image> m_RequiredIngredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_m_RequiredIngredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_m_RequiredIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x000E685C File Offset: 0x000E4A5C
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x0000D451 File Offset: 0x0000B651
		public unsafe UIButtonSimple filterButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_filterButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_filterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x000E688C File Offset: 0x000E4A8C
		// (set) Token: 0x0600155D RID: 5469 RVA: 0x0000D470 File Offset: 0x0000B670
		public unsafe List<Recipe> allRecipeInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_allRecipeInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_allRecipeInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x000E68BC File Offset: 0x000E4ABC
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x0000D48F File Offset: 0x0000B68F
		public unsafe List<int> listVariationIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_listVariationIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_listVariationIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x000E68EC File Offset: 0x000E4AEC
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x0000D4AE File Offset: 0x0000B6AE
		public unsafe List<IFilterConfig> m_FilterConfigs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_m_FilterConfigs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_m_FilterConfigs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x000E691C File Offset: 0x000E4B1C
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x0000D4CD File Offset: 0x0000B6CD
		public unsafe List<DaySceneCookingPannel.ScheduledRecipe> scheduledRecipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_scheduledRecipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DaySceneCookingPannel.ScheduledRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_scheduledRecipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x000E694C File Offset: 0x000E4B4C
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x0000D4EC File Offset: 0x0000B6EC
		public unsafe List<int> willRemovedIngredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_willRemovedIngredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_willRemovedIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x000E697C File Offset: 0x000E4B7C
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x0000D50B File Offset: 0x0000B70B
		public unsafe int cookCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_cookCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_cookCount)) = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x000E69A4 File Offset: 0x000E4BA4
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x0000D526 File Offset: 0x0000B726
		public unsafe int currentCookActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_currentCookActions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_currentCookActions)) = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x000E69CC File Offset: 0x000E4BCC
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x0000D541 File Offset: 0x0000B741
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple> m_RecipeFieldGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_m_RecipeFieldGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_m_RecipeFieldGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x000E69FC File Offset: 0x000E4BFC
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x0000D560 File Offset: 0x0000B760
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<DaySceneCookingPannel.ScheduledRecipe, UIElementCluster, UIButtonSimple> m_SelectedFieldGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_m_SelectedFieldGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<DaySceneCookingPannel.ScheduledRecipe, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_m_SelectedFieldGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x000E6A2C File Offset: 0x000E4C2C
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x0000D57F File Offset: 0x0000B77F
		public unsafe int maxCookCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_maxCookCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_maxCookCount)) = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x000E6A54 File Offset: 0x000E4C54
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x0000D59A File Offset: 0x0000B79A
		public unsafe Il2CppStructArray<int> variations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_variations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_variations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x000E6A84 File Offset: 0x000E4C84
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x0000D5B9 File Offset: 0x0000B7B9
		public unsafe CanvasGroup describerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_describerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.NativeFieldInfoPtr_describerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeFieldInfoPtr_customSpacingRect;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeFieldInfoPtr_objectElement;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeFieldInfoPtr_objectStackElement;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeFieldInfoPtr_m_AllRowsBackgrounds;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeFieldInfoPtr_recipeField;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeFieldInfoPtr_outputField;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeFieldInfoPtr_sellableDescriber;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeFieldInfoPtr_onDisabledColor;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeFieldInfoPtr_onSubmitButton;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeFieldInfoPtr_timeFieldVariations;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeFieldInfoPtr_RecipeScroller;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeFieldInfoPtr_SelectedScroller;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeFieldInfoPtr_DescriberSwitcher;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeFieldInfoPtr_m_RequiredIngredients;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeFieldInfoPtr_filterButton;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeFieldInfoPtr_allRecipeInstances;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeFieldInfoPtr_listVariationIndex;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeFieldInfoPtr_m_FilterConfigs;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeFieldInfoPtr_scheduledRecipes;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeFieldInfoPtr_willRemovedIngredients;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeFieldInfoPtr_cookCount;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeFieldInfoPtr_currentCookActions;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeFieldGroup;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedFieldGroup;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeFieldInfoPtr_maxCookCount;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeFieldInfoPtr_variations;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeFieldInfoPtr_describerCanvasGroup;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRegisteredUpToLimit_Private_get_Boolean_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRecipeRequireIngredients_Private_Void_Recipe_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_GetVisualAtIndex_Private_Sprite_Int32_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeStampAtIndex_Private_String_Int32_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_UpdateElements_Private_Void_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_OnTertiarySwitchPresed_Private_Void_CallbackContext_0;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeMethodInfoPtr_OpenFilterPanel_Private_Void_0;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmChoiceStart_Private_Void_CallbackContext_0;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmChoiceEnd_Private_Void_CallbackContext_0;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__29_0_Private_Void_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__29_1_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__29_2_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__32_1_Private_Void_ScheduledRecipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__32_2_Private_Void_BorderElementType_Int32_Int32_Nullable_1_ValueTuple_3_ScheduledRecipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__32_5_Private_Void_Image_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__32_8_Private_Void_Image_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr__OpenFilterPanel_b__38_0_Private_Void_0;

		// Token: 0x02000626 RID: 1574
		public class ScheduledRecipe : Il2CppSystem.Object
		{
			// Token: 0x060091CB RID: 37323 RVA: 0x0027838C File Offset: 0x0027658C
			// Note: this type is marked as 'beforefieldinit'.
			static ScheduledRecipe()
			{
				Il2CppClassPointerStore<DaySceneCookingPannel.ScheduledRecipe>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "ScheduledRecipe");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCookingPannel.ScheduledRecipe>.NativeClassPtr);
				DaySceneCookingPannel.ScheduledRecipe.NativeFieldInfoPtr__Recipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.ScheduledRecipe>.NativeClassPtr, "<Recipe>k__BackingField");
				DaySceneCookingPannel.ScheduledRecipe.NativeMethodInfoPtr__ctor_Public_Void_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.ScheduledRecipe>.NativeClassPtr, 100667125);
				DaySceneCookingPannel.ScheduledRecipe.NativeMethodInfoPtr_get_Recipe_Public_get_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.ScheduledRecipe>.NativeClassPtr, 100667126);
			}

			// Token: 0x060091CC RID: 37324 RVA: 0x002783F4 File Offset: 0x002765F4
			[CallerCount(109)]
			[CachedScanResults(RefRangeStart = 60056, RefRangeEnd = 60165, XrefRangeStart = 60054, XrefRangeEnd = 60056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScheduledRecipe(Recipe recipe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCookingPannel.ScheduledRecipe>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.ScheduledRecipe.NativeMethodInfoPtr__ctor_Public_Void_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170030A2 RID: 12450
			// (get) Token: 0x060091CD RID: 37325 RVA: 0x00278440 File Offset: 0x00276640
			public unsafe Recipe Recipe
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.ScheduledRecipe.NativeMethodInfoPtr_get_Recipe_Public_get_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr3) : null;
				}
			}

			// Token: 0x060091CE RID: 37326 RVA: 0x0004EFA5 File Offset: 0x0004D1A5
			public ScheduledRecipe(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030A1 RID: 12449
			// (get) Token: 0x060091CF RID: 37327 RVA: 0x00278480 File Offset: 0x00276680
			// (set) Token: 0x060091D0 RID: 37328 RVA: 0x0004EFAE File Offset: 0x0004D1AE
			public unsafe Recipe _Recipe_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.ScheduledRecipe.NativeFieldInfoPtr__Recipe_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.ScheduledRecipe.NativeFieldInfoPtr__Recipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005EB9 RID: 24249
			private static readonly IntPtr NativeFieldInfoPtr__Recipe_k__BackingField;

			// Token: 0x04005EBA RID: 24250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Recipe_0;

			// Token: 0x04005EBB RID: 24251
			private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_Recipe_0;
		}

		// Token: 0x02000627 RID: 1575
		[ObfuscatedName("DayScene.UI.DaySceneCookingPannel+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x060091D1 RID: 37329 RVA: 0x002784B0 File Offset: 0x002766B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_0>.NativeClassPtr);
				DaySceneCookingPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_0>.NativeClassPtr, "recipe");
				DaySceneCookingPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_0>.NativeClassPtr, "amount");
				DaySceneCookingPannel.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
				DaySceneCookingPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_0>.NativeClassPtr, 100667127);
				DaySceneCookingPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_0>.NativeClassPtr, 100667128);
				DaySceneCookingPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_0>.NativeClassPtr, 100667129);
				DaySceneCookingPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_0>.NativeClassPtr, 100667130);
			}

			// Token: 0x060091D2 RID: 37330 RVA: 0x00278568 File Offset: 0x00276768
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091D3 RID: 37331 RVA: 0x002785A4 File Offset: 0x002767A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60165, XrefRangeEnd = 60170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__4(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091D4 RID: 37332 RVA: 0x002785E8 File Offset: 0x002767E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__5(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091D5 RID: 37333 RVA: 0x0027862C File Offset: 0x0027682C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__6(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c__DisplayClass29_0.NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091D6 RID: 37334 RVA: 0x0004EFCD File Offset: 0x0004D1CD
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030A3 RID: 12451
			// (get) Token: 0x060091D7 RID: 37335 RVA: 0x00278670 File Offset: 0x00276870
			// (set) Token: 0x060091D8 RID: 37336 RVA: 0x0004EFD6 File Offset: 0x0004D1D6
			public unsafe Recipe recipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_recipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030A4 RID: 12452
			// (get) Token: 0x060091D9 RID: 37337 RVA: 0x002786A0 File Offset: 0x002768A0
			// (set) Token: 0x060091DA RID: 37338 RVA: 0x0004EFF5 File Offset: 0x0004D1F5
			public unsafe string amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_amount);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass29_0.NativeFieldInfoPtr_amount), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170030A5 RID: 12453
			// (get) Token: 0x060091DB RID: 37339 RVA: 0x002786C8 File Offset: 0x002768C8
			// (set) Token: 0x060091DC RID: 37340 RVA: 0x0004F014 File Offset: 0x0004D214
			public unsafe DaySceneCookingPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneCookingPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005EBC RID: 24252
			private static readonly IntPtr NativeFieldInfoPtr_recipe;

			// Token: 0x04005EBD RID: 24253
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04005EBE RID: 24254
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005EBF RID: 24255
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005EC0 RID: 24256
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_Image_0;

			// Token: 0x04005EC1 RID: 24257
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04005EC2 RID: 24258
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000628 RID: 1576
		[ObfuscatedName("DayScene.UI.DaySceneCookingPannel+<>c__DisplayClass29_1")]
		public sealed class __c__DisplayClass29_1 : Il2CppSystem.Object
		{
			// Token: 0x060091DD RID: 37341 RVA: 0x002786F8 File Offset: 0x002768F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_1()
			{
				Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "<>c__DisplayClass29_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_1>.NativeClassPtr);
				DaySceneCookingPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_currentRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_1>.NativeClassPtr, "currentRecipe");
				DaySceneCookingPannel.__c__DisplayClass29_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_1>.NativeClassPtr, "<>4__this");
				DaySceneCookingPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_1>.NativeClassPtr, 100667131);
				DaySceneCookingPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__OnPanelInitialize_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_1>.NativeClassPtr, 100667132);
			}

			// Token: 0x060091DE RID: 37342 RVA: 0x00278774 File Offset: 0x00276974
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass29_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091DF RID: 37343 RVA: 0x002787B0 File Offset: 0x002769B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60170, XrefRangeEnd = 60190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c__DisplayClass29_1.NativeMethodInfoPtr__OnPanelInitialize_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091E0 RID: 37344 RVA: 0x0004F033 File Offset: 0x0004D233
			public __c__DisplayClass29_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030A6 RID: 12454
			// (get) Token: 0x060091E1 RID: 37345 RVA: 0x002787E4 File Offset: 0x002769E4
			// (set) Token: 0x060091E2 RID: 37346 RVA: 0x0004F03C File Offset: 0x0004D23C
			public unsafe Recipe currentRecipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_currentRecipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass29_1.NativeFieldInfoPtr_currentRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030A7 RID: 12455
			// (get) Token: 0x060091E3 RID: 37347 RVA: 0x00278814 File Offset: 0x00276A14
			// (set) Token: 0x060091E4 RID: 37348 RVA: 0x0004F05B File Offset: 0x0004D25B
			public unsafe DaySceneCookingPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass29_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneCookingPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass29_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005EC3 RID: 24259
			private static readonly IntPtr NativeFieldInfoPtr_currentRecipe;

			// Token: 0x04005EC4 RID: 24260
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005EC5 RID: 24261
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005EC6 RID: 24262
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__7_Internal_Void_0;
		}

		// Token: 0x02000629 RID: 1577
		[ObfuscatedName("DayScene.UI.DaySceneCookingPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060091E5 RID: 37349 RVA: 0x00278844 File Offset: 0x00276A44
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneCookingPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCookingPannel.__c>.NativeClassPtr);
				DaySceneCookingPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.__c>.NativeClassPtr, "<>9");
				DaySceneCookingPannel.__c.NativeFieldInfoPtr___9__29_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.__c>.NativeClassPtr, "<>9__29_3");
				DaySceneCookingPannel.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.__c>.NativeClassPtr, "<>9__32_0");
				DaySceneCookingPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c>.NativeClassPtr, 100667134);
				DaySceneCookingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__29_3_Internal_Int32_ScheduledRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c>.NativeClassPtr, 100667135);
				DaySceneCookingPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__32_0_Internal_Void_ScheduledRecipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c>.NativeClassPtr, 100667136);
			}

			// Token: 0x060091E6 RID: 37350 RVA: 0x002788E8 File Offset: 0x00276AE8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCookingPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091E7 RID: 37351 RVA: 0x00278924 File Offset: 0x00276B24
			[CallerCount(0)]
			public unsafe int _OnPanelInitialize_b__29_3(DaySceneCookingPannel.ScheduledRecipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__29_3_Internal_Int32_ScheduledRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060091E8 RID: 37352 RVA: 0x00278974 File Offset: 0x00276B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60190, XrefRangeEnd = 60203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__32_0(DaySceneCookingPannel.ScheduledRecipe recipe, UIElementCluster cluster, UIButtonSimple _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__32_0_Internal_Void_ScheduledRecipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091E9 RID: 37353 RVA: 0x0004F07A File Offset: 0x0004D27A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030A8 RID: 12456
			// (get) Token: 0x060091EA RID: 37354 RVA: 0x002789DC File Offset: 0x00276BDC
			// (set) Token: 0x060091EB RID: 37355 RVA: 0x0004F083 File Offset: 0x0004D283
			public unsafe static DaySceneCookingPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneCookingPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneCookingPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneCookingPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030A9 RID: 12457
			// (get) Token: 0x060091EC RID: 37356 RVA: 0x00278A04 File Offset: 0x00276C04
			// (set) Token: 0x060091ED RID: 37357 RVA: 0x0004F095 File Offset: 0x0004D295
			public unsafe static Func<DaySceneCookingPannel.ScheduledRecipe, int> __9__29_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneCookingPannel.__c.NativeFieldInfoPtr___9__29_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DaySceneCookingPannel.ScheduledRecipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneCookingPannel.__c.NativeFieldInfoPtr___9__29_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030AA RID: 12458
			// (get) Token: 0x060091EE RID: 37358 RVA: 0x00278A2C File Offset: 0x00276C2C
			// (set) Token: 0x060091EF RID: 37359 RVA: 0x0004F0A7 File Offset: 0x0004D2A7
			public unsafe static Action<DaySceneCookingPannel.ScheduledRecipe, UIElementCluster, UIButtonSimple> __9__32_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneCookingPannel.__c.NativeFieldInfoPtr___9__32_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DaySceneCookingPannel.ScheduledRecipe, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneCookingPannel.__c.NativeFieldInfoPtr___9__32_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005EC7 RID: 24263
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005EC8 RID: 24264
			private static readonly IntPtr NativeFieldInfoPtr___9__29_3;

			// Token: 0x04005EC9 RID: 24265
			private static readonly IntPtr NativeFieldInfoPtr___9__32_0;

			// Token: 0x04005ECA RID: 24266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005ECB RID: 24267
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__29_3_Internal_Int32_ScheduledRecipe_0;

			// Token: 0x04005ECC RID: 24268
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__32_0_Internal_Void_ScheduledRecipe_UIElementCluster_UIButtonSimple_0;
		}

		// Token: 0x0200062A RID: 1578
		[ObfuscatedName("DayScene.UI.DaySceneCookingPannel+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x060091F0 RID: 37360 RVA: 0x00278A54 File Offset: 0x00276C54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_0>.NativeClassPtr);
				DaySceneCookingPannel.__c__DisplayClass32_0.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_0>.NativeClassPtr, "recipe");
				DaySceneCookingPannel.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_0>.NativeClassPtr, 100667137);
				DaySceneCookingPannel.__c__DisplayClass32_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_0>.NativeClassPtr, 100667138);
			}

			// Token: 0x060091F1 RID: 37361 RVA: 0x00278ABC File Offset: 0x00276CBC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091F2 RID: 37362 RVA: 0x00278AF8 File Offset: 0x00276CF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60203, XrefRangeEnd = 60207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c__DisplayClass32_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091F3 RID: 37363 RVA: 0x0004F0B9 File Offset: 0x0004D2B9
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030AB RID: 12459
			// (get) Token: 0x060091F4 RID: 37364 RVA: 0x00278B3C File Offset: 0x00276D3C
			// (set) Token: 0x060091F5 RID: 37365 RVA: 0x0004F0C2 File Offset: 0x0004D2C2
			public unsafe DaySceneCookingPannel.ScheduledRecipe recipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass32_0.NativeFieldInfoPtr_recipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneCookingPannel.ScheduledRecipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass32_0.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005ECD RID: 24269
			private static readonly IntPtr NativeFieldInfoPtr_recipe;

			// Token: 0x04005ECE RID: 24270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005ECF RID: 24271
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_Image_0;
		}

		// Token: 0x0200062B RID: 1579
		[ObfuscatedName("DayScene.UI.DaySceneCookingPannel+<>c__DisplayClass32_1")]
		public sealed class __c__DisplayClass32_1 : Il2CppSystem.Object
		{
			// Token: 0x060091F6 RID: 37366 RVA: 0x00278B6C File Offset: 0x00276D6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_1()
			{
				Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "<>c__DisplayClass32_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_1>.NativeClassPtr);
				DaySceneCookingPannel.__c__DisplayClass32_1.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_1>.NativeClassPtr, "recipe");
				DaySceneCookingPannel.__c__DisplayClass32_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_1>.NativeClassPtr, "<>4__this");
				DaySceneCookingPannel.__c__DisplayClass32_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_1>.NativeClassPtr, 100667139);
				DaySceneCookingPannel.__c__DisplayClass32_1.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_1>.NativeClassPtr, 100667140);
			}

			// Token: 0x060091F7 RID: 37367 RVA: 0x00278BE8 File Offset: 0x00276DE8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c__DisplayClass32_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091F8 RID: 37368 RVA: 0x00278C24 File Offset: 0x00276E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60207, XrefRangeEnd = 60225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c__DisplayClass32_1.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091F9 RID: 37369 RVA: 0x0004F0E1 File Offset: 0x0004D2E1
			public __c__DisplayClass32_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030AC RID: 12460
			// (get) Token: 0x060091FA RID: 37370 RVA: 0x00278C58 File Offset: 0x00276E58
			// (set) Token: 0x060091FB RID: 37371 RVA: 0x0004F0EA File Offset: 0x0004D2EA
			public unsafe DaySceneCookingPannel.ScheduledRecipe recipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass32_1.NativeFieldInfoPtr_recipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneCookingPannel.ScheduledRecipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass32_1.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030AD RID: 12461
			// (get) Token: 0x060091FC RID: 37372 RVA: 0x00278C88 File Offset: 0x00276E88
			// (set) Token: 0x060091FD RID: 37373 RVA: 0x0004F109 File Offset: 0x0004D309
			public unsafe DaySceneCookingPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass32_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneCookingPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass32_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005ED0 RID: 24272
			private static readonly IntPtr NativeFieldInfoPtr_recipe;

			// Token: 0x04005ED1 RID: 24273
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005ED2 RID: 24274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005ED3 RID: 24275
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_0;
		}

		// Token: 0x0200062C RID: 1580
		[ObfuscatedName("DayScene.UI.DaySceneCookingPannel+<>c__DisplayClass32_2")]
		public sealed class __c__DisplayClass32_2 : Il2CppSystem.Object
		{
			// Token: 0x060091FE RID: 37374 RVA: 0x00278CB8 File Offset: 0x00276EB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_2()
			{
				Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneCookingPannel>.NativeClassPtr, "<>c__DisplayClass32_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_2>.NativeClassPtr);
				DaySceneCookingPannel.__c__DisplayClass32_2.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_2>.NativeClassPtr, "index");
				DaySceneCookingPannel.__c__DisplayClass32_2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_2>.NativeClassPtr, "<>4__this");
				DaySceneCookingPannel.__c__DisplayClass32_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_2>.NativeClassPtr, 100667141);
				DaySceneCookingPannel.__c__DisplayClass32_2.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_2>.NativeClassPtr, 100667142);
				DaySceneCookingPannel.__c__DisplayClass32_2.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_2>.NativeClassPtr, 100667143);
			}

			// Token: 0x060091FF RID: 37375 RVA: 0x00278D48 File Offset: 0x00276F48
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneCookingPannel.__c__DisplayClass32_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c__DisplayClass32_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009200 RID: 37376 RVA: 0x00278D84 File Offset: 0x00276F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60225, XrefRangeEnd = 60247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c__DisplayClass32_2.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009201 RID: 37377 RVA: 0x00278DC8 File Offset: 0x00276FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60247, XrefRangeEnd = 60262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__7(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneCookingPannel.__c__DisplayClass32_2.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009202 RID: 37378 RVA: 0x0004F128 File Offset: 0x0004D328
			public __c__DisplayClass32_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030AE RID: 12462
			// (get) Token: 0x06009203 RID: 37379 RVA: 0x00278E0C File Offset: 0x0027700C
			// (set) Token: 0x06009204 RID: 37380 RVA: 0x0004F131 File Offset: 0x0004D331
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass32_2.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass32_2.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170030AF RID: 12463
			// (get) Token: 0x06009205 RID: 37381 RVA: 0x00278E34 File Offset: 0x00277034
			// (set) Token: 0x06009206 RID: 37382 RVA: 0x0004F14C File Offset: 0x0004D34C
			public unsafe DaySceneCookingPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass32_2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneCookingPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneCookingPannel.__c__DisplayClass32_2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005ED4 RID: 24276
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04005ED5 RID: 24277
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005ED6 RID: 24278
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005ED7 RID: 24279
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_Image_0;

			// Token: 0x04005ED8 RID: 24280
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_TextMeshProUGUI_0;
		}
	}
}
