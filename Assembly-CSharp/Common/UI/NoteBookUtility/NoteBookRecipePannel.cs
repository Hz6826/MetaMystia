using System;
using Common.UI.Filter;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x020003A2 RID: 930
	public class NoteBookRecipePannel : UISubPanel<NoteBookMainPannel>
	{
		// Token: 0x0600707B RID: 28795 RVA: 0x00214E98 File Offset: 0x00213098
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookRecipePannel()
		{
			Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookRecipePannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr);
			NoteBookRecipePannel.NativeFieldInfoPtr_ALL_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "ALL_TAG_ID");
			NoteBookRecipePannel.NativeFieldInfoPtr_POT_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "POT_TAG_ID");
			NoteBookRecipePannel.NativeFieldInfoPtr_GRILL_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "GRILL_TAG_ID");
			NoteBookRecipePannel.NativeFieldInfoPtr_FRYING_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "FRYING_TAG_ID");
			NoteBookRecipePannel.NativeFieldInfoPtr_STREAMER_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "STREAMER_TAG_ID");
			NoteBookRecipePannel.NativeFieldInfoPtr_CUTTINGBOARD_TAG_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "CUTTINGBOARD_TAG_ID");
			NoteBookRecipePannel.NativeFieldInfoPtr_FASTFORWARD_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "FASTFORWARD_COUNT");
			NoteBookRecipePannel.NativeFieldInfoPtr_STARTLOOP_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "STARTLOOP_COUNT");
			NoteBookRecipePannel.NativeFieldInfoPtr_m_ActionExecutionScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "m_ActionExecutionScheduler");
			NoteBookRecipePannel.NativeFieldInfoPtr_recipeDescriber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "recipeDescriber");
			NoteBookRecipePannel.NativeFieldInfoPtr_recipeObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "recipeObject");
			NoteBookRecipePannel.NativeFieldInfoPtr_recipeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "recipeList");
			NoteBookRecipePannel.NativeFieldInfoPtr_foodTagFillterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "foodTagFillterButton");
			NoteBookRecipePannel.NativeFieldInfoPtr_rightPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "rightPannel");
			NoteBookRecipePannel.NativeFieldInfoPtr_nullPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "nullPannel");
			NoteBookRecipePannel.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "selected");
			NoteBookRecipePannel.NativeFieldInfoPtr_progressIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "progressIndicator");
			NoteBookRecipePannel.NativeFieldInfoPtr_m_CurrencyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "m_CurrencyInfo");
			NoteBookRecipePannel.NativeFieldInfoPtr_m_FilterConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "m_FilterConfigs");
			NoteBookRecipePannel.NativeFieldInfoPtr_m_FilterRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "m_FilterRecipes");
			NoteBookRecipePannel.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "_comparer");
			NoteBookRecipePannel.NativeFieldInfoPtr_cookerTypeTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "cookerTypeTag");
			NoteBookRecipePannel.NativeFieldInfoPtr_m_RecipeLogicalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "m_RecipeLogicalGroup");
			NoteBookRecipePannel.NativeFieldInfoPtr__SelectedTagData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "<SelectedTagData>k__BackingField");
			NoteBookRecipePannel.NativeFieldInfoPtr__OwnedTagData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "<OwnedTagData>k__BackingField");
			NoteBookRecipePannel.NativeMethodInfoPtr_get_SelectedTagData_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686252);
			NoteBookRecipePannel.NativeMethodInfoPtr_get_OwnedTagData_Public_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686253);
			NoteBookRecipePannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686254);
			NoteBookRecipePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686255);
			NoteBookRecipePannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686256);
			NoteBookRecipePannel.NativeMethodInfoPtr_OnKeyboardMove_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686257);
			NoteBookRecipePannel.NativeMethodInfoPtr_FastForwardRecipeSelection_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686258);
			NoteBookRecipePannel.NativeMethodInfoPtr_OnRecipeBtnSelected_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686259);
			NoteBookRecipePannel.NativeMethodInfoPtr_InitRecipe_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686260);
			NoteBookRecipePannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686261);
			NoteBookRecipePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686262);
			NoteBookRecipePannel.NativeMethodInfoPtr_UpdateRecipeElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686263);
			NoteBookRecipePannel.NativeMethodInfoPtr_UpdateRightPanel_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686264);
			NoteBookRecipePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686265);
			NoteBookRecipePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686266);
			NoteBookRecipePannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686267);
			NoteBookRecipePannel.NativeMethodInfoPtr__OnPanelInitialize_b__31_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686268);
			NoteBookRecipePannel.NativeMethodInfoPtr__OnPanelInitialize_b__31_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, 100686269);
		}

		// Token: 0x170026AD RID: 9901
		// (get) Token: 0x0600707C RID: 28796 RVA: 0x00215224 File Offset: 0x00213424
		public unsafe List<int> SelectedTagData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.NativeMethodInfoPtr_get_SelectedTagData_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170026AE RID: 9902
		// (get) Token: 0x0600707D RID: 28797 RVA: 0x00215264 File Offset: 0x00213464
		public unsafe List<int> OwnedTagData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.NativeMethodInfoPtr_get_OwnedTagData_Public_get_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x0600707E RID: 28798 RVA: 0x002152A4 File Offset: 0x002134A4
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookRecipePannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600707F RID: 28799 RVA: 0x002152EC File Offset: 0x002134EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281035, XrefRangeEnd = 281119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookRecipePannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007080 RID: 28800 RVA: 0x00215328 File Offset: 0x00213528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281119, XrefRangeEnd = 281129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookRecipePannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007081 RID: 28801 RVA: 0x00215364 File Offset: 0x00213564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281129, XrefRangeEnd = 281135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKeyboardMove(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.NativeMethodInfoPtr_OnKeyboardMove_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007082 RID: 28802 RVA: 0x002153AC File Offset: 0x002135AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281173, RefRangeEnd = 281174, XrefRangeStart = 281135, XrefRangeEnd = 281173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FastForwardRecipeSelection(bool positive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref positive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.NativeMethodInfoPtr_FastForwardRecipeSelection_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007083 RID: 28803 RVA: 0x002153EC File Offset: 0x002135EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281174, XrefRangeEnd = 281214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRecipeBtnSelected(Recipe recipe, UIElementCluster cluster, UIButtonSimple uIButton)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uIButton);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.NativeMethodInfoPtr_OnRecipeBtnSelected_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007084 RID: 28804 RVA: 0x00215454 File Offset: 0x00213654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281214, XrefRangeEnd = 281274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitRecipe(Recipe recipe, UIElementCluster cluster, UIButtonSimple uIButton)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uIButton);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.NativeMethodInfoPtr_InitRecipe_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007085 RID: 28805 RVA: 0x002154BC File Offset: 0x002136BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281274, XrefRangeEnd = 281278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookRecipePannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007086 RID: 28806 RVA: 0x002154F8 File Offset: 0x002136F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281278, XrefRangeEnd = 281283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookRecipePannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007087 RID: 28807 RVA: 0x00215534 File Offset: 0x00213734
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281309, RefRangeEnd = 281311, XrefRangeStart = 281283, XrefRangeEnd = 281309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRecipeElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.NativeMethodInfoPtr_UpdateRecipeElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007088 RID: 28808 RVA: 0x00215568 File Offset: 0x00213768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRightPanel(bool showForRecipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref showForRecipe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.NativeMethodInfoPtr_UpdateRightPanel_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x002155A8 File Offset: 0x002137A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281311, XrefRangeEnd = 281371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookRecipePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x002155E4 File Offset: 0x002137E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281371, XrefRangeEnd = 281395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookRecipePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600708B RID: 28811 RVA: 0x00215620 File Offset: 0x00213820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281395, XrefRangeEnd = 281432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookRecipePannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600708C RID: 28812 RVA: 0x0021565C File Offset: 0x0021385C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281432, XrefRangeEnd = 281462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__31_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.NativeMethodInfoPtr__OnPanelInitialize_b__31_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x00215690 File Offset: 0x00213890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281462, XrefRangeEnd = 281472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__31_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.NativeMethodInfoPtr__OnPanelInitialize_b__31_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600708E RID: 28814 RVA: 0x0003D1AA File Offset: 0x0003B3AA
		public NoteBookRecipePannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002694 RID: 9876
		// (get) Token: 0x0600708F RID: 28815 RVA: 0x002156C4 File Offset: 0x002138C4
		// (set) Token: 0x06007090 RID: 28816 RVA: 0x0003D1B3 File Offset: 0x0003B3B3
		public unsafe static int ALL_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NoteBookRecipePannel.NativeFieldInfoPtr_ALL_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteBookRecipePannel.NativeFieldInfoPtr_ALL_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x17002695 RID: 9877
		// (get) Token: 0x06007091 RID: 28817 RVA: 0x002156E0 File Offset: 0x002138E0
		// (set) Token: 0x06007092 RID: 28818 RVA: 0x0003D1C1 File Offset: 0x0003B3C1
		public unsafe static int POT_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NoteBookRecipePannel.NativeFieldInfoPtr_POT_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteBookRecipePannel.NativeFieldInfoPtr_POT_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x17002696 RID: 9878
		// (get) Token: 0x06007093 RID: 28819 RVA: 0x002156FC File Offset: 0x002138FC
		// (set) Token: 0x06007094 RID: 28820 RVA: 0x0003D1CF File Offset: 0x0003B3CF
		public unsafe static int GRILL_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NoteBookRecipePannel.NativeFieldInfoPtr_GRILL_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteBookRecipePannel.NativeFieldInfoPtr_GRILL_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x06007095 RID: 28821 RVA: 0x00215718 File Offset: 0x00213918
		// (set) Token: 0x06007096 RID: 28822 RVA: 0x0003D1DD File Offset: 0x0003B3DD
		public unsafe static int FRYING_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NoteBookRecipePannel.NativeFieldInfoPtr_FRYING_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteBookRecipePannel.NativeFieldInfoPtr_FRYING_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x06007097 RID: 28823 RVA: 0x00215734 File Offset: 0x00213934
		// (set) Token: 0x06007098 RID: 28824 RVA: 0x0003D1EB File Offset: 0x0003B3EB
		public unsafe static int STREAMER_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NoteBookRecipePannel.NativeFieldInfoPtr_STREAMER_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteBookRecipePannel.NativeFieldInfoPtr_STREAMER_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x17002699 RID: 9881
		// (get) Token: 0x06007099 RID: 28825 RVA: 0x00215750 File Offset: 0x00213950
		// (set) Token: 0x0600709A RID: 28826 RVA: 0x0003D1F9 File Offset: 0x0003B3F9
		public unsafe static int CUTTINGBOARD_TAG_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NoteBookRecipePannel.NativeFieldInfoPtr_CUTTINGBOARD_TAG_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteBookRecipePannel.NativeFieldInfoPtr_CUTTINGBOARD_TAG_ID, (void*)(&value));
			}
		}

		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x0600709B RID: 28827 RVA: 0x0021576C File Offset: 0x0021396C
		// (set) Token: 0x0600709C RID: 28828 RVA: 0x0003D207 File Offset: 0x0003B407
		public unsafe static int FASTFORWARD_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NoteBookRecipePannel.NativeFieldInfoPtr_FASTFORWARD_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteBookRecipePannel.NativeFieldInfoPtr_FASTFORWARD_COUNT, (void*)(&value));
			}
		}

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x0600709D RID: 28829 RVA: 0x00215788 File Offset: 0x00213988
		// (set) Token: 0x0600709E RID: 28830 RVA: 0x0003D215 File Offset: 0x0003B415
		public unsafe static int STARTLOOP_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NoteBookRecipePannel.NativeFieldInfoPtr_STARTLOOP_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NoteBookRecipePannel.NativeFieldInfoPtr_STARTLOOP_COUNT, (void*)(&value));
			}
		}

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x0600709F RID: 28831 RVA: 0x002157A4 File Offset: 0x002139A4
		// (set) Token: 0x060070A0 RID: 28832 RVA: 0x0003D223 File Offset: 0x0003B423
		public unsafe ActionExecutionScheduler m_ActionExecutionScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_m_ActionExecutionScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_m_ActionExecutionScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x060070A1 RID: 28833 RVA: 0x002157D4 File Offset: 0x002139D4
		// (set) Token: 0x060070A2 RID: 28834 RVA: 0x0003D242 File Offset: 0x0003B442
		public unsafe RecipeDescriber recipeDescriber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_recipeDescriber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecipeDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_recipeDescriber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x060070A3 RID: 28835 RVA: 0x00215804 File Offset: 0x00213A04
		// (set) Token: 0x060070A4 RID: 28836 RVA: 0x0003D261 File Offset: 0x0003B461
		public unsafe GameObject recipeObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_recipeObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_recipeObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700269F RID: 9887
		// (get) Token: 0x060070A5 RID: 28837 RVA: 0x00215834 File Offset: 0x00213A34
		// (set) Token: 0x060070A6 RID: 28838 RVA: 0x0003D280 File Offset: 0x0003B480
		public unsafe VerticalLayoutGroup recipeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_recipeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_recipeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x060070A7 RID: 28839 RVA: 0x00215864 File Offset: 0x00213A64
		// (set) Token: 0x060070A8 RID: 28840 RVA: 0x0003D29F File Offset: 0x0003B49F
		public unsafe UIButtonSimple foodTagFillterButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_foodTagFillterButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_foodTagFillterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x060070A9 RID: 28841 RVA: 0x00215894 File Offset: 0x00213A94
		// (set) Token: 0x060070AA RID: 28842 RVA: 0x0003D2BE File Offset: 0x0003B4BE
		public unsafe CanvasGroup rightPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_rightPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_rightPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A2 RID: 9890
		// (get) Token: 0x060070AB RID: 28843 RVA: 0x002158C4 File Offset: 0x00213AC4
		// (set) Token: 0x060070AC RID: 28844 RVA: 0x0003D2DD File Offset: 0x0003B4DD
		public unsafe CanvasGroup nullPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_nullPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_nullPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A3 RID: 9891
		// (get) Token: 0x060070AD RID: 28845 RVA: 0x002158F4 File Offset: 0x00213AF4
		// (set) Token: 0x060070AE RID: 28846 RVA: 0x0003D2FC File Offset: 0x0003B4FC
		public unsafe CanvasGroup selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_selected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_selected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A4 RID: 9892
		// (get) Token: 0x060070AF RID: 28847 RVA: 0x00215924 File Offset: 0x00213B24
		// (set) Token: 0x060070B0 RID: 28848 RVA: 0x0003D31B File Offset: 0x0003B51B
		public unsafe AdpProgressIndicatorComponent progressIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_progressIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_progressIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A5 RID: 9893
		// (get) Token: 0x060070B1 RID: 28849 RVA: 0x00215954 File Offset: 0x00213B54
		// (set) Token: 0x060070B2 RID: 28850 RVA: 0x0003D33A File Offset: 0x0003B53A
		public unsafe NumberFormatInfo m_CurrencyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_m_CurrencyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_m_CurrencyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A6 RID: 9894
		// (get) Token: 0x060070B3 RID: 28851 RVA: 0x00215984 File Offset: 0x00213B84
		// (set) Token: 0x060070B4 RID: 28852 RVA: 0x0003D359 File Offset: 0x0003B559
		public unsafe List<IFilterConfig> m_FilterConfigs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_m_FilterConfigs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_m_FilterConfigs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A7 RID: 9895
		// (get) Token: 0x060070B5 RID: 28853 RVA: 0x002159B4 File Offset: 0x00213BB4
		// (set) Token: 0x060070B6 RID: 28854 RVA: 0x0003D378 File Offset: 0x0003B578
		public unsafe List<Recipe> m_FilterRecipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_m_FilterRecipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_m_FilterRecipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A8 RID: 9896
		// (get) Token: 0x060070B7 RID: 28855 RVA: 0x002159E4 File Offset: 0x00213BE4
		// (set) Token: 0x060070B8 RID: 28856 RVA: 0x0003D397 File Offset: 0x0003B597
		public unsafe Comparer<int> _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparer<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A9 RID: 9897
		// (get) Token: 0x060070B9 RID: 28857 RVA: 0x00215A14 File Offset: 0x00213C14
		// (set) Token: 0x060070BA RID: 28858 RVA: 0x0003D3B6 File Offset: 0x0003B5B6
		public unsafe Dictionary<int, Cooker.CookerType> cookerTypeTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_cookerTypeTag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Cooker.CookerType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_cookerTypeTag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026AA RID: 9898
		// (get) Token: 0x060070BB RID: 28859 RVA: 0x00215A44 File Offset: 0x00213C44
		// (set) Token: 0x060070BC RID: 28860 RVA: 0x0003D3D5 File Offset: 0x0003B5D5
		public unsafe StaticVirtualScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple> m_RecipeLogicalGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_m_RecipeLogicalGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVirtualScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr_m_RecipeLogicalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026AB RID: 9899
		// (get) Token: 0x060070BD RID: 28861 RVA: 0x00215A74 File Offset: 0x00213C74
		// (set) Token: 0x060070BE RID: 28862 RVA: 0x0003D3F4 File Offset: 0x0003B5F4
		public unsafe List<int> _SelectedTagData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr__SelectedTagData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr__SelectedTagData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026AC RID: 9900
		// (get) Token: 0x060070BF RID: 28863 RVA: 0x00215AA4 File Offset: 0x00213CA4
		// (set) Token: 0x060070C0 RID: 28864 RVA: 0x0003D413 File Offset: 0x0003B613
		public unsafe List<int> _OwnedTagData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr__OwnedTagData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.NativeFieldInfoPtr__OwnedTagData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A7F RID: 19071
		private static readonly IntPtr NativeFieldInfoPtr_ALL_TAG_ID;

		// Token: 0x04004A80 RID: 19072
		private static readonly IntPtr NativeFieldInfoPtr_POT_TAG_ID;

		// Token: 0x04004A81 RID: 19073
		private static readonly IntPtr NativeFieldInfoPtr_GRILL_TAG_ID;

		// Token: 0x04004A82 RID: 19074
		private static readonly IntPtr NativeFieldInfoPtr_FRYING_TAG_ID;

		// Token: 0x04004A83 RID: 19075
		private static readonly IntPtr NativeFieldInfoPtr_STREAMER_TAG_ID;

		// Token: 0x04004A84 RID: 19076
		private static readonly IntPtr NativeFieldInfoPtr_CUTTINGBOARD_TAG_ID;

		// Token: 0x04004A85 RID: 19077
		private static readonly IntPtr NativeFieldInfoPtr_FASTFORWARD_COUNT;

		// Token: 0x04004A86 RID: 19078
		private static readonly IntPtr NativeFieldInfoPtr_STARTLOOP_COUNT;

		// Token: 0x04004A87 RID: 19079
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionExecutionScheduler;

		// Token: 0x04004A88 RID: 19080
		private static readonly IntPtr NativeFieldInfoPtr_recipeDescriber;

		// Token: 0x04004A89 RID: 19081
		private static readonly IntPtr NativeFieldInfoPtr_recipeObject;

		// Token: 0x04004A8A RID: 19082
		private static readonly IntPtr NativeFieldInfoPtr_recipeList;

		// Token: 0x04004A8B RID: 19083
		private static readonly IntPtr NativeFieldInfoPtr_foodTagFillterButton;

		// Token: 0x04004A8C RID: 19084
		private static readonly IntPtr NativeFieldInfoPtr_rightPannel;

		// Token: 0x04004A8D RID: 19085
		private static readonly IntPtr NativeFieldInfoPtr_nullPannel;

		// Token: 0x04004A8E RID: 19086
		private static readonly IntPtr NativeFieldInfoPtr_selected;

		// Token: 0x04004A8F RID: 19087
		private static readonly IntPtr NativeFieldInfoPtr_progressIndicator;

		// Token: 0x04004A90 RID: 19088
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrencyInfo;

		// Token: 0x04004A91 RID: 19089
		private static readonly IntPtr NativeFieldInfoPtr_m_FilterConfigs;

		// Token: 0x04004A92 RID: 19090
		private static readonly IntPtr NativeFieldInfoPtr_m_FilterRecipes;

		// Token: 0x04004A93 RID: 19091
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x04004A94 RID: 19092
		private static readonly IntPtr NativeFieldInfoPtr_cookerTypeTag;

		// Token: 0x04004A95 RID: 19093
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeLogicalGroup;

		// Token: 0x04004A96 RID: 19094
		private static readonly IntPtr NativeFieldInfoPtr__SelectedTagData_k__BackingField;

		// Token: 0x04004A97 RID: 19095
		private static readonly IntPtr NativeFieldInfoPtr__OwnedTagData_k__BackingField;

		// Token: 0x04004A98 RID: 19096
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedTagData_Public_get_List_1_Int32_0;

		// Token: 0x04004A99 RID: 19097
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnedTagData_Public_get_List_1_Int32_0;

		// Token: 0x04004A9A RID: 19098
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004A9B RID: 19099
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004A9C RID: 19100
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04004A9D RID: 19101
		private static readonly IntPtr NativeMethodInfoPtr_OnKeyboardMove_Private_Void_CallbackContext_0;

		// Token: 0x04004A9E RID: 19102
		private static readonly IntPtr NativeMethodInfoPtr_FastForwardRecipeSelection_Private_Void_Boolean_0;

		// Token: 0x04004A9F RID: 19103
		private static readonly IntPtr NativeMethodInfoPtr_OnRecipeBtnSelected_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004AA0 RID: 19104
		private static readonly IntPtr NativeMethodInfoPtr_InitRecipe_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004AA1 RID: 19105
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x04004AA2 RID: 19106
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004AA3 RID: 19107
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRecipeElements_Private_Void_0;

		// Token: 0x04004AA4 RID: 19108
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRightPanel_Private_Void_Boolean_0;

		// Token: 0x04004AA5 RID: 19109
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004AA6 RID: 19110
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004AA7 RID: 19111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004AA8 RID: 19112
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__31_0_Private_Void_0;

		// Token: 0x04004AA9 RID: 19113
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__31_1_Private_Void_0;

		// Token: 0x02000EF5 RID: 3829
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookRecipePannel+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x06010D65 RID: 68965 RVA: 0x003E4670 File Offset: 0x003E2870
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass35_0>.NativeClassPtr);
				NoteBookRecipePannel.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				NoteBookRecipePannel.__c__DisplayClass35_0.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass35_0>.NativeClassPtr, "recipe");
				NoteBookRecipePannel.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass35_0>.NativeClassPtr, 100686270);
				NoteBookRecipePannel.__c__DisplayClass35_0.NativeMethodInfoPtr__OnRecipeBtnSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass35_0>.NativeClassPtr, 100686271);
				NoteBookRecipePannel.__c__DisplayClass35_0.NativeMethodInfoPtr__OnRecipeBtnSelected_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass35_0>.NativeClassPtr, 100686272);
				NoteBookRecipePannel.__c__DisplayClass35_0.NativeMethodInfoPtr__OnRecipeBtnSelected_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass35_0>.NativeClassPtr, 100686273);
				NoteBookRecipePannel.__c__DisplayClass35_0.NativeMethodInfoPtr__OnRecipeBtnSelected_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass35_0>.NativeClassPtr, 100686274);
				NoteBookRecipePannel.__c__DisplayClass35_0.NativeMethodInfoPtr__OnRecipeBtnSelected_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass35_0>.NativeClassPtr, 100686275);
			}

			// Token: 0x06010D66 RID: 68966 RVA: 0x003E473C File Offset: 0x003E293C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D67 RID: 68967 RVA: 0x003E4778 File Offset: 0x003E2978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280955, XrefRangeEnd = 280958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnRecipeBtnSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass35_0.NativeMethodInfoPtr__OnRecipeBtnSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D68 RID: 68968 RVA: 0x003E47AC File Offset: 0x003E29AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280958, XrefRangeEnd = 280962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnRecipeBtnSelected_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass35_0.NativeMethodInfoPtr__OnRecipeBtnSelected_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D69 RID: 68969 RVA: 0x003E47E0 File Offset: 0x003E29E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280962, XrefRangeEnd = 280963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnRecipeBtnSelected_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass35_0.NativeMethodInfoPtr__OnRecipeBtnSelected_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D6A RID: 68970 RVA: 0x003E4824 File Offset: 0x003E2A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280963, XrefRangeEnd = 280964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnRecipeBtnSelected_b__3(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass35_0.NativeMethodInfoPtr__OnRecipeBtnSelected_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D6B RID: 68971 RVA: 0x003E4868 File Offset: 0x003E2A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280964, XrefRangeEnd = 280965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnRecipeBtnSelected_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass35_0.NativeMethodInfoPtr__OnRecipeBtnSelected_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D6C RID: 68972 RVA: 0x00092B22 File Offset: 0x00090D22
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057B1 RID: 22449
			// (get) Token: 0x06010D6D RID: 68973 RVA: 0x003E48AC File Offset: 0x003E2AAC
			// (set) Token: 0x06010D6E RID: 68974 RVA: 0x00092B2B File Offset: 0x00090D2B
			public unsafe NoteBookRecipePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookRecipePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057B2 RID: 22450
			// (get) Token: 0x06010D6F RID: 68975 RVA: 0x003E48DC File Offset: 0x003E2ADC
			// (set) Token: 0x06010D70 RID: 68976 RVA: 0x00092B4A File Offset: 0x00090D4A
			public unsafe Recipe recipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass35_0.NativeFieldInfoPtr_recipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass35_0.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA61 RID: 43617
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AA62 RID: 43618
			private static readonly IntPtr NativeFieldInfoPtr_recipe;

			// Token: 0x0400AA63 RID: 43619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA64 RID: 43620
			private static readonly IntPtr NativeMethodInfoPtr__OnRecipeBtnSelected_b__0_Internal_Void_0;

			// Token: 0x0400AA65 RID: 43621
			private static readonly IntPtr NativeMethodInfoPtr__OnRecipeBtnSelected_b__1_Internal_Void_0;

			// Token: 0x0400AA66 RID: 43622
			private static readonly IntPtr NativeMethodInfoPtr__OnRecipeBtnSelected_b__2_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AA67 RID: 43623
			private static readonly IntPtr NativeMethodInfoPtr__OnRecipeBtnSelected_b__3_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AA68 RID: 43624
			private static readonly IntPtr NativeMethodInfoPtr__OnRecipeBtnSelected_b__4_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000EF6 RID: 3830
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookRecipePannel+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x06010D71 RID: 68977 RVA: 0x003E490C File Offset: 0x003E2B0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr);
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, "recipe");
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, "<>4__this");
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr_valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, "valid");
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, "<>9__6");
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, "<>9__7");
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, "<>9__8");
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, 100686276);
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, 100686277);
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, 100686278);
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, 100686279);
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, 100686280);
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, 100686281);
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, 100686282);
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__6_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, 100686283);
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__7_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, 100686284);
				NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__8_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr, 100686285);
			}

			// Token: 0x06010D72 RID: 68978 RVA: 0x003E4A78 File Offset: 0x003E2C78
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D73 RID: 68979 RVA: 0x003E4AB4 File Offset: 0x003E2CB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280965, XrefRangeEnd = 280969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitRecipe_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D74 RID: 68980 RVA: 0x003E4AF8 File Offset: 0x003E2CF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280969, XrefRangeEnd = 280972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitRecipe_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D75 RID: 68981 RVA: 0x003E4B3C File Offset: 0x003E2D3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280972, XrefRangeEnd = 280973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitRecipe_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D76 RID: 68982 RVA: 0x003E4B80 File Offset: 0x003E2D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280973, XrefRangeEnd = 280974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitRecipe_b__3(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D77 RID: 68983 RVA: 0x003E4BC4 File Offset: 0x003E2DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280974, XrefRangeEnd = 280975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitRecipe_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D78 RID: 68984 RVA: 0x003E4C08 File Offset: 0x003E2E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280975, XrefRangeEnd = 280998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitRecipe_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D79 RID: 68985 RVA: 0x003E4C3C File Offset: 0x003E2E3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280998, XrefRangeEnd = 280999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitRecipe_b__6(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__6_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D7A RID: 68986 RVA: 0x003E4C80 File Offset: 0x003E2E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280999, XrefRangeEnd = 281000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitRecipe_b__7(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__7_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D7B RID: 68987 RVA: 0x003E4CC4 File Offset: 0x003E2EC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281000, XrefRangeEnd = 281001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitRecipe_b__8(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass36_0.NativeMethodInfoPtr__InitRecipe_b__8_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D7C RID: 68988 RVA: 0x00092B69 File Offset: 0x00090D69
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057B3 RID: 22451
			// (get) Token: 0x06010D7D RID: 68989 RVA: 0x003E4D08 File Offset: 0x003E2F08
			// (set) Token: 0x06010D7E RID: 68990 RVA: 0x00092B72 File Offset: 0x00090D72
			public unsafe Recipe recipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr_recipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057B4 RID: 22452
			// (get) Token: 0x06010D7F RID: 68991 RVA: 0x003E4D38 File Offset: 0x003E2F38
			// (set) Token: 0x06010D80 RID: 68992 RVA: 0x00092B91 File Offset: 0x00090D91
			public unsafe NoteBookRecipePannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookRecipePannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057B5 RID: 22453
			// (get) Token: 0x06010D81 RID: 68993 RVA: 0x003E4D68 File Offset: 0x003E2F68
			// (set) Token: 0x06010D82 RID: 68994 RVA: 0x00092BB0 File Offset: 0x00090DB0
			public unsafe UIElementCluster valid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr_valid);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr_valid), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057B6 RID: 22454
			// (get) Token: 0x06010D83 RID: 68995 RVA: 0x003E4D98 File Offset: 0x003E2F98
			// (set) Token: 0x06010D84 RID: 68996 RVA: 0x00092BCF File Offset: 0x00090DCF
			public unsafe Action<TextMeshProUGUI> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057B7 RID: 22455
			// (get) Token: 0x06010D85 RID: 68997 RVA: 0x003E4DC8 File Offset: 0x003E2FC8
			// (set) Token: 0x06010D86 RID: 68998 RVA: 0x00092BEE File Offset: 0x00090DEE
			public unsafe Action<TextMeshProUGUI> __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057B8 RID: 22456
			// (get) Token: 0x06010D87 RID: 68999 RVA: 0x003E4DF8 File Offset: 0x003E2FF8
			// (set) Token: 0x06010D88 RID: 69000 RVA: 0x00092C0D File Offset: 0x00090E0D
			public unsafe Action<TextMeshProUGUI> __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass36_0.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA69 RID: 43625
			private static readonly IntPtr NativeFieldInfoPtr_recipe;

			// Token: 0x0400AA6A RID: 43626
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AA6B RID: 43627
			private static readonly IntPtr NativeFieldInfoPtr_valid;

			// Token: 0x0400AA6C RID: 43628
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x0400AA6D RID: 43629
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x0400AA6E RID: 43630
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x0400AA6F RID: 43631
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA70 RID: 43632
			private static readonly IntPtr NativeMethodInfoPtr__InitRecipe_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AA71 RID: 43633
			private static readonly IntPtr NativeMethodInfoPtr__InitRecipe_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AA72 RID: 43634
			private static readonly IntPtr NativeMethodInfoPtr__InitRecipe_b__2_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AA73 RID: 43635
			private static readonly IntPtr NativeMethodInfoPtr__InitRecipe_b__3_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AA74 RID: 43636
			private static readonly IntPtr NativeMethodInfoPtr__InitRecipe_b__4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AA75 RID: 43637
			private static readonly IntPtr NativeMethodInfoPtr__InitRecipe_b__5_Internal_Void_0;

			// Token: 0x0400AA76 RID: 43638
			private static readonly IntPtr NativeMethodInfoPtr__InitRecipe_b__6_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AA77 RID: 43639
			private static readonly IntPtr NativeMethodInfoPtr__InitRecipe_b__7_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400AA78 RID: 43640
			private static readonly IntPtr NativeMethodInfoPtr__InitRecipe_b__8_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000EF7 RID: 3831
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookRecipePannel+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x06010D89 RID: 69001 RVA: 0x003E4E28 File Offset: 0x003E3028
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass41_0>.NativeClassPtr);
				NoteBookRecipePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass41_0>.NativeClassPtr, "x");
				NoteBookRecipePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass41_0>.NativeClassPtr, 100686286);
				NoteBookRecipePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass41_0>.NativeClassPtr, 100686287);
			}

			// Token: 0x06010D8A RID: 69002 RVA: 0x003E4E90 File Offset: 0x003E3090
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookRecipePannel.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D8B RID: 69003 RVA: 0x003E4ECC File Offset: 0x003E30CC
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__3(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c__DisplayClass41_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D8C RID: 69004 RVA: 0x00092C2C File Offset: 0x00090E2C
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057B9 RID: 22457
			// (get) Token: 0x06010D8D RID: 69005 RVA: 0x003E4F18 File Offset: 0x003E3118
			// (set) Token: 0x06010D8E RID: 69006 RVA: 0x00092C35 File Offset: 0x00090E35
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookRecipePannel.__c__DisplayClass41_0.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x0400AA79 RID: 43641
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400AA7A RID: 43642
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA7B RID: 43643
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000EF8 RID: 3832
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookRecipePannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010D8F RID: 69007 RVA: 0x003E4F40 File Offset: 0x003E3140
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NoteBookRecipePannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookRecipePannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookRecipePannel.__c>.NativeClassPtr);
				NoteBookRecipePannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel.__c>.NativeClassPtr, "<>9");
				NoteBookRecipePannel.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel.__c>.NativeClassPtr, "<>9__41_0");
				NoteBookRecipePannel.__c.NativeFieldInfoPtr___9__41_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel.__c>.NativeClassPtr, "<>9__41_2");
				NoteBookRecipePannel.__c.NativeFieldInfoPtr___9__41_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookRecipePannel.__c>.NativeClassPtr, "<>9__41_1");
				NoteBookRecipePannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c>.NativeClassPtr, 100686289);
				NoteBookRecipePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__41_0_Internal_Int32_KeyValuePair_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c>.NativeClassPtr, 100686290);
				NoteBookRecipePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__41_1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c>.NativeClassPtr, 100686291);
				NoteBookRecipePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__41_2_Internal_IEnumerable_1_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookRecipePannel.__c>.NativeClassPtr, 100686292);
			}

			// Token: 0x06010D90 RID: 69008 RVA: 0x003E500C File Offset: 0x003E320C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookRecipePannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010D91 RID: 69009 RVA: 0x003E5048 File Offset: 0x003E3248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281001, XrefRangeEnd = 281002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpen_b__41_0(KeyValuePair<int, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__41_0_Internal_Int32_KeyValuePair_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D92 RID: 69010 RVA: 0x003E509C File Offset: 0x003E329C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281002, XrefRangeEnd = 281035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__41_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__41_1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010D93 RID: 69011 RVA: 0x003E50E8 File Offset: 0x003E32E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _OnPanelOpen_b__41_2(Recipe y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookRecipePannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__41_2_Internal_IEnumerable_1_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x06010D94 RID: 69012 RVA: 0x00092C50 File Offset: 0x00090E50
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057BA RID: 22458
			// (get) Token: 0x06010D95 RID: 69013 RVA: 0x003E5138 File Offset: 0x003E3338
			// (set) Token: 0x06010D96 RID: 69014 RVA: 0x00092C59 File Offset: 0x00090E59
			public unsafe static NoteBookRecipePannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookRecipePannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookRecipePannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookRecipePannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057BB RID: 22459
			// (get) Token: 0x06010D97 RID: 69015 RVA: 0x003E5160 File Offset: 0x003E3360
			// (set) Token: 0x06010D98 RID: 69016 RVA: 0x00092C6B File Offset: 0x00090E6B
			public unsafe static Func<KeyValuePair<int, string>, int> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookRecipePannel.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, string>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookRecipePannel.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057BC RID: 22460
			// (get) Token: 0x06010D99 RID: 69017 RVA: 0x003E5188 File Offset: 0x003E3388
			// (set) Token: 0x06010D9A RID: 69018 RVA: 0x00092C7D File Offset: 0x00090E7D
			public unsafe static Func<Recipe, IEnumerable<int>> __9__41_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookRecipePannel.__c.NativeFieldInfoPtr___9__41_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookRecipePannel.__c.NativeFieldInfoPtr___9__41_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057BD RID: 22461
			// (get) Token: 0x06010D9B RID: 69019 RVA: 0x003E51B0 File Offset: 0x003E33B0
			// (set) Token: 0x06010D9C RID: 69020 RVA: 0x00092C8F File Offset: 0x00090E8F
			public unsafe static Func<int, bool> __9__41_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NoteBookRecipePannel.__c.NativeFieldInfoPtr___9__41_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NoteBookRecipePannel.__c.NativeFieldInfoPtr___9__41_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA7C RID: 43644
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AA7D RID: 43645
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x0400AA7E RID: 43646
			private static readonly IntPtr NativeFieldInfoPtr___9__41_2;

			// Token: 0x0400AA7F RID: 43647
			private static readonly IntPtr NativeFieldInfoPtr___9__41_1;

			// Token: 0x0400AA80 RID: 43648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA81 RID: 43649
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__41_0_Internal_Int32_KeyValuePair_2_Int32_String_0;

			// Token: 0x0400AA82 RID: 43650
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__41_1_Internal_Boolean_Int32_0;

			// Token: 0x0400AA83 RID: 43651
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__41_2_Internal_IEnumerable_1_Int32_Recipe_0;
		}
	}
}
