using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Night.RogueLike;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000FD RID: 253
	public class DLC5_RogueLikeCardSelectorPanel : UIPanelParamOpen<DLC5_RogueLikeCardSelectorPanel.OpenContext>
	{
		// Token: 0x06001BAD RID: 7085 RVA: 0x000FB670 File Offset: 0x000F9870
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardSelectorPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardSelectorPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr);
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ParentCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_ParentCanvas");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ItemStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_ItemStack");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ContainerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_ContainerParent");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CardAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_CardAnimator");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_DescriberParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_DescriberParent");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RarityColorPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_RarityColorPairs");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CardTitleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_CardTitleColor");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CardDesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_CardDesColor");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardDesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_PersistentCardDesColor");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardForeverColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_PersistentCardForeverColor");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardForeverBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_PersistentCardForeverBack");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardForeverTitleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_PersistentCardForeverTitleColor");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardRemainingColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_PersistentCardRemainingColor");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardRemainingBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_PersistentCardRemainingBack");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardRemainingTitleColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_PersistentCardRemainingTitleColor");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_DataViewerBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_DataViewerBtn");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_DescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_DescriptionText");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ExtraText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_ExtraText");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RefreshText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_RefreshText");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_BaseDescriptionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_BaseDescriptionColor");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_DangerousDescriptionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_DangerousDescriptionColor");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_StartAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_StartAnim");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_GachaNumText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_GachaNumText");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_GachaMaxNumText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_GachaMaxNumText");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RefreshButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_RefreshButton");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ExtraMenuSubPanelForCardSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_ExtraMenuSubPanelForCardSelector");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_isHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "isHide");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_AllInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_AllInstances");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_Instance");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RarityColorDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_RarityColorDic");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CurrentButtonHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_CurrentButtonHold");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ContainerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_ContainerCanvasGroup");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RefreshCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_RefreshCallback");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_IsPreparing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_IsPreparing");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_IsDealing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_IsDealing");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr__MaxCardNumCanGacha_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "<MaxCardNumCanGacha>k__BackingField");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_IsSubPanelOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_IsSubPanelOpened");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_OnSubPanelClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_OnSubPanelClosed");
			DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CardLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "m_CardLists");
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_get_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668315);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_get_MaxCardNumCanGacha_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668316);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_set_MaxCardNumCanGacha_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668317);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668318);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668319);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_ConfirmChoiceStartForSubmit_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668320);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_ConfirmChoiceEndForSubmit_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668321);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_Refresh_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668322);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_Hide_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668323);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_RefreshCard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668324);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_DequeueAndUpdateCard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668325);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_UpdateCard_Private_Void_TriggerCardCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668326);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_UpdateRefreshPrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668327);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_GetRefreshPrice_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668328);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_TryNextGacha_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668329);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_PlayStartAnim_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668330);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_PlayDealAnimations_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668331);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_FinishSelect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668332);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_TryFindCurrentCursorFocus_Private_UIButtonBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668333);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668334);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668335);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_UpdateGachaNum_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668336);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668337);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668338);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr__OnPanelInitialize_b__46_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668339);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr__OnPanelInitialize_b__46_3_Private_Void_CloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668340);
			DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr__OnPanelInitialize_b__46_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, 100668341);
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x000FBBC8 File Offset: 0x000F9DC8
		public unsafe RogueLikeRunTimeData RogueLikeRunTimeData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73149, XrefRangeEnd = 73150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_get_RogueLikeRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr3) : null;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x000FBC08 File Offset: 0x000F9E08
		// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x000FBC44 File Offset: 0x000F9E44
		public unsafe int MaxCardNumCanGacha
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_get_MaxCardNumCanGacha_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_set_MaxCardNumCanGacha_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x000FBC84 File Offset: 0x000F9E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73150, XrefRangeEnd = 73262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x000FBCC0 File Offset: 0x000F9EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73262, XrefRangeEnd = 73272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_RogueLikeCardSelectorPanel.OpenContext openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x000FBD14 File Offset: 0x000F9F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73272, XrefRangeEnd = 73280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmChoiceStartForSubmit(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_ConfirmChoiceStartForSubmit_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x000FBD5C File Offset: 0x000F9F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73280, XrefRangeEnd = 73285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmChoiceEndForSubmit(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_ConfirmChoiceEndForSubmit_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x000FBDA4 File Offset: 0x000F9FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73285, XrefRangeEnd = 73289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_Refresh_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x000FBDEC File Offset: 0x000F9FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73289, XrefRangeEnd = 73295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_Hide_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x000FBE34 File Offset: 0x000FA034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73295, XrefRangeEnd = 73298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_RefreshCard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x000FBE68 File Offset: 0x000FA068
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 73317, RefRangeEnd = 73320, XrefRangeStart = 73298, XrefRangeEnd = 73317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DequeueAndUpdateCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_DequeueAndUpdateCard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x000FBE9C File Offset: 0x000FA09C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73355, RefRangeEnd = 73357, XrefRangeStart = 73320, XrefRangeEnd = 73355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCard(TriggerCardCondition thisCardList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref thisCardList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_UpdateCard_Private_Void_TriggerCardCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x000FBEDC File Offset: 0x000FA0DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73365, RefRangeEnd = 73367, XrefRangeStart = 73357, XrefRangeEnd = 73365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRefreshPrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_UpdateRefreshPrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x000FBF10 File Offset: 0x000FA110
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 73371, RefRangeEnd = 73374, XrefRangeStart = 73367, XrefRangeEnd = 73371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRefreshPrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_GetRefreshPrice_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x000FBF4C File Offset: 0x000FA14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73374, XrefRangeEnd = 73389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryNextGacha()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_TryNextGacha_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x000FBF80 File Offset: 0x000FA180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73389, XrefRangeEnd = 73394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PlayStartAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_PlayStartAnim_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x000FBFC0 File Offset: 0x000FA1C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 73399, RefRangeEnd = 73402, XrefRangeStart = 73394, XrefRangeEnd = 73399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PlayDealAnimations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_PlayDealAnimations_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000FC000 File Offset: 0x000FA200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73402, XrefRangeEnd = 73406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishSelect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_FinishSelect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000FC034 File Offset: 0x000FA234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73426, RefRangeEnd = 73428, XrefRangeStart = 73406, XrefRangeEnd = 73426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIButtonBase TryFindCurrentCursorFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_TryFindCurrentCursorFocus_Private_UIButtonBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIButtonBase>(intPtr3) : null;
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x000FC074 File Offset: 0x000FA274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73428, XrefRangeEnd = 73429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x000FC0B0 File Offset: 0x000FA2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73429, XrefRangeEnd = 73435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x000FC0EC File Offset: 0x000FA2EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73439, RefRangeEnd = 73441, XrefRangeStart = 73435, XrefRangeEnd = 73439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGachaNum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_UpdateGachaNum_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x000FC120 File Offset: 0x000FA320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73441, XrefRangeEnd = 73469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x000FC15C File Offset: 0x000FA35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73469, XrefRangeEnd = 73494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardSelectorPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x000FC198 File Offset: 0x000FA398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73494, XrefRangeEnd = 73508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr__OnPanelInitialize_b__46_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000FC1CC File Offset: 0x000FA3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73508, XrefRangeEnd = 73511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_3(DLC5_RogueLikeExtraMenuSubPanel.CloseContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr__OnPanelInitialize_b__46_3_Private_Void_CloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x000FC20C File Offset: 0x000FA40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73511, XrefRangeEnd = 73512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__46_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.NativeMethodInfoPtr__OnPanelInitialize_b__46_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00010D8F File Offset: 0x0000EF8F
		public DLC5_RogueLikeCardSelectorPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x000FC240 File Offset: 0x000FA440
		// (set) Token: 0x06001BCB RID: 7115 RVA: 0x00010D98 File Offset: 0x0000EF98
		public unsafe CanvasGroup m_ParentCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ParentCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ParentCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x000FC270 File Offset: 0x000FA470
		// (set) Token: 0x06001BCD RID: 7117 RVA: 0x00010DB7 File Offset: 0x0000EFB7
		public unsafe GameObject m_ItemStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ItemStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ItemStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x000FC2A0 File Offset: 0x000FA4A0
		// (set) Token: 0x06001BCF RID: 7119 RVA: 0x00010DD6 File Offset: 0x0000EFD6
		public unsafe RectTransform m_ContainerParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ContainerParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ContainerParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x000FC2D0 File Offset: 0x000FA4D0
		// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x00010DF5 File Offset: 0x0000EFF5
		public unsafe Animator m_CardAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CardAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CardAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x000FC300 File Offset: 0x000FA500
		// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x00010E14 File Offset: 0x0000F014
		public unsafe CanvasGroup m_DescriberParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_DescriberParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_DescriberParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x000FC330 File Offset: 0x000FA530
		// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x00010E33 File Offset: 0x0000F033
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeCardSelectorPanel.RarityColorPair> m_RarityColorPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RarityColorPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeCardSelectorPanel.RarityColorPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RarityColorPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x000FC360 File Offset: 0x000FA560
		// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x00010E52 File Offset: 0x0000F052
		public unsafe Color m_CardTitleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CardTitleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CardTitleColor)) = value;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x000FC388 File Offset: 0x000FA588
		// (set) Token: 0x06001BD9 RID: 7129 RVA: 0x00010E6D File Offset: 0x0000F06D
		public unsafe Color m_CardDesColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CardDesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CardDesColor)) = value;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x000FC3B0 File Offset: 0x000FA5B0
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x00010E88 File Offset: 0x0000F088
		public unsafe Color m_PersistentCardDesColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardDesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardDesColor)) = value;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x000FC3D8 File Offset: 0x000FA5D8
		// (set) Token: 0x06001BDD RID: 7133 RVA: 0x00010EA3 File Offset: 0x0000F0A3
		public unsafe Sprite m_PersistentCardForeverColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardForeverColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardForeverColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x000FC408 File Offset: 0x000FA608
		// (set) Token: 0x06001BDF RID: 7135 RVA: 0x00010EC2 File Offset: 0x0000F0C2
		public unsafe Sprite m_PersistentCardForeverBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardForeverBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardForeverBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x000FC438 File Offset: 0x000FA638
		// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x00010EE1 File Offset: 0x0000F0E1
		public unsafe Color m_PersistentCardForeverTitleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardForeverTitleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardForeverTitleColor)) = value;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x000FC460 File Offset: 0x000FA660
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x00010EFC File Offset: 0x0000F0FC
		public unsafe Sprite m_PersistentCardRemainingColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardRemainingColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardRemainingColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x000FC490 File Offset: 0x000FA690
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x00010F1B File Offset: 0x0000F11B
		public unsafe Sprite m_PersistentCardRemainingBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardRemainingBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardRemainingBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x000FC4C0 File Offset: 0x000FA6C0
		// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x00010F3A File Offset: 0x0000F13A
		public unsafe Color m_PersistentCardRemainingTitleColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardRemainingTitleColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_PersistentCardRemainingTitleColor)) = value;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x000FC4E8 File Offset: 0x000FA6E8
		// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x00010F55 File Offset: 0x0000F155
		public unsafe UIButtonSimple m_DataViewerBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_DataViewerBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_DataViewerBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x000FC518 File Offset: 0x000FA718
		// (set) Token: 0x06001BEB RID: 7147 RVA: 0x00010F74 File Offset: 0x0000F174
		public unsafe TextMeshProUGUI m_DescriptionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_DescriptionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_DescriptionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x000FC548 File Offset: 0x000FA748
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x00010F93 File Offset: 0x0000F193
		public unsafe TextMeshProUGUI m_ExtraText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ExtraText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ExtraText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x000FC578 File Offset: 0x000FA778
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x00010FB2 File Offset: 0x0000F1B2
		public unsafe TextMeshProUGUI m_RefreshText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RefreshText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RefreshText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x000FC5A8 File Offset: 0x000FA7A8
		// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x00010FD1 File Offset: 0x0000F1D1
		public unsafe Color m_BaseDescriptionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_BaseDescriptionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_BaseDescriptionColor)) = value;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x000FC5D0 File Offset: 0x000FA7D0
		// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x00010FEC File Offset: 0x0000F1EC
		public unsafe Color m_DangerousDescriptionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_DangerousDescriptionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_DangerousDescriptionColor)) = value;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x000FC5F8 File Offset: 0x000FA7F8
		// (set) Token: 0x06001BF5 RID: 7157 RVA: 0x00011007 File Offset: 0x0000F207
		public unsafe Animator m_StartAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_StartAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_StartAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x000FC628 File Offset: 0x000FA828
		// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x00011026 File Offset: 0x0000F226
		public unsafe TextMeshProUGUI m_GachaNumText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_GachaNumText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_GachaNumText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x000FC658 File Offset: 0x000FA858
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x00011045 File Offset: 0x0000F245
		public unsafe TextMeshProUGUI m_GachaMaxNumText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_GachaMaxNumText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_GachaMaxNumText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x000FC688 File Offset: 0x000FA888
		// (set) Token: 0x06001BFB RID: 7163 RVA: 0x00011064 File Offset: 0x0000F264
		public unsafe UIButtonSimple m_RefreshButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RefreshButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RefreshButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x000FC6B8 File Offset: 0x000FA8B8
		// (set) Token: 0x06001BFD RID: 7165 RVA: 0x00011083 File Offset: 0x0000F283
		public unsafe DLC5_RogueLikeExtraMenuSubPanel m_ExtraMenuSubPanelForCardSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ExtraMenuSubPanelForCardSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeExtraMenuSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ExtraMenuSubPanelForCardSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x000FC6E8 File Offset: 0x000FA8E8
		// (set) Token: 0x06001BFF RID: 7167 RVA: 0x000110A2 File Offset: 0x0000F2A2
		public unsafe bool isHide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_isHide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_isHide)) = value;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x000FC710 File Offset: 0x000FA910
		// (set) Token: 0x06001C01 RID: 7169 RVA: 0x000110BD File Offset: 0x0000F2BD
		public unsafe List<GameObject> m_AllInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_AllInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_AllInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x000FC740 File Offset: 0x000FA940
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x000110DC File Offset: 0x0000F2DC
		public unsafe List<UIButtonBase> m_Instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_Instance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIButtonBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_Instance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x000FC770 File Offset: 0x000FA970
		// (set) Token: 0x06001C05 RID: 7173 RVA: 0x000110FB File Offset: 0x0000F2FB
		public unsafe Dictionary<RogueLikeCardBase.Rarity, ValueTuple<Sprite, Sprite>> m_RarityColorDic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RarityColorDic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RogueLikeCardBase.Rarity, ValueTuple<Sprite, Sprite>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RarityColorDic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x000FC7A0 File Offset: 0x000FA9A0
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x0001111A File Offset: 0x0000F31A
		public unsafe UIButtonDoubleClickHold m_CurrentButtonHold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CurrentButtonHold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonDoubleClickHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CurrentButtonHold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000FC7D0 File Offset: 0x000FA9D0
		// (set) Token: 0x06001C09 RID: 7177 RVA: 0x00011139 File Offset: 0x0000F339
		public unsafe CanvasGroup m_ContainerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ContainerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_ContainerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x000FC800 File Offset: 0x000FAA00
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x00011158 File Offset: 0x0000F358
		public unsafe Action m_RefreshCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RefreshCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_RefreshCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x000FC830 File Offset: 0x000FAA30
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x00011177 File Offset: 0x0000F377
		public unsafe bool m_IsPreparing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_IsPreparing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_IsPreparing)) = value;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x000FC858 File Offset: 0x000FAA58
		// (set) Token: 0x06001C0F RID: 7183 RVA: 0x00011192 File Offset: 0x0000F392
		public unsafe bool m_IsDealing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_IsDealing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_IsDealing)) = value;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x000FC880 File Offset: 0x000FAA80
		// (set) Token: 0x06001C11 RID: 7185 RVA: 0x000111AD File Offset: 0x0000F3AD
		public unsafe int _MaxCardNumCanGacha_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr__MaxCardNumCanGacha_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr__MaxCardNumCanGacha_k__BackingField)) = value;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x000FC8A8 File Offset: 0x000FAAA8
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x000111C8 File Offset: 0x0000F3C8
		public unsafe bool m_IsSubPanelOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_IsSubPanelOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_IsSubPanelOpened)) = value;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x000FC8D0 File Offset: 0x000FAAD0
		// (set) Token: 0x06001C15 RID: 7189 RVA: 0x000111E3 File Offset: 0x0000F3E3
		public unsafe Action m_OnSubPanelClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_OnSubPanelClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_OnSubPanelClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001C16 RID: 7190 RVA: 0x000FC900 File Offset: 0x000FAB00
		// (set) Token: 0x06001C17 RID: 7191 RVA: 0x00011202 File Offset: 0x0000F402
		public unsafe List<RogueLikeCardInstance> m_CardLists
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CardLists);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RogueLikeCardInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.NativeFieldInfoPtr_m_CardLists), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentCanvas;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemStack;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeFieldInfoPtr_m_ContainerParent;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeFieldInfoPtr_m_CardAnimator;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberParent;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeFieldInfoPtr_m_RarityColorPairs;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeFieldInfoPtr_m_CardTitleColor;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeFieldInfoPtr_m_CardDesColor;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentCardDesColor;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentCardForeverColor;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentCardForeverBack;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentCardForeverTitleColor;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentCardRemainingColor;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentCardRemainingBack;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentCardRemainingTitleColor;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeFieldInfoPtr_m_DataViewerBtn;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriptionText;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtraText;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshText;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseDescriptionColor;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeFieldInfoPtr_m_DangerousDescriptionColor;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeFieldInfoPtr_m_StartAnim;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaNumText;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeFieldInfoPtr_m_GachaMaxNumText;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshButton;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtraMenuSubPanelForCardSelector;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeFieldInfoPtr_isHide;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeFieldInfoPtr_m_AllInstances;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeFieldInfoPtr_m_Instance;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeFieldInfoPtr_m_RarityColorDic;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentButtonHold;

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeFieldInfoPtr_m_ContainerCanvasGroup;

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshCallback;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeFieldInfoPtr_m_IsPreparing;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDealing;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeFieldInfoPtr__MaxCardNumCanGacha_k__BackingField;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeFieldInfoPtr_m_IsSubPanelOpened;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeFieldInfoPtr_m_OnSubPanelClosed;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeFieldInfoPtr_m_CardLists;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_get_RogueLikeRunTimeData_Public_get_RogueLikeRunTimeData_0;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCardNumCanGacha_Public_get_Int32_0;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxCardNumCanGacha_Public_set_Void_Int32_0;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmChoiceStartForSubmit_Private_Void_CallbackContext_0;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmChoiceEndForSubmit_Private_Void_CallbackContext_0;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_CallbackContext_0;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Private_Void_CallbackContext_0;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCard_Private_Void_0;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeMethodInfoPtr_DequeueAndUpdateCard_Private_Void_0;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCard_Private_Void_TriggerCardCondition_0;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRefreshPrice_Private_Void_0;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr_GetRefreshPrice_Private_Int32_0;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeMethodInfoPtr_TryNextGacha_Private_Void_0;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeMethodInfoPtr_PlayStartAnim_Private_IEnumerator_0;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr_PlayDealAnimations_Private_IEnumerator_0;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_FinishSelect_Private_Void_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr_TryFindCurrentCursorFocus_Private_UIButtonBase_0;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGachaNum_Public_Void_0;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_0_Private_Void_0;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_3_Private_Void_CloseContext_0;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_4_Private_Void_0;

		// Token: 0x020006C6 RID: 1734
		[Serializable]
		public sealed class RarityColorPair : ValueType
		{
			// Token: 0x0600996F RID: 39279 RVA: 0x0028EB3C File Offset: 0x0028CD3C
			// Note: this type is marked as 'beforefieldinit'.
			static RarityColorPair()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.RarityColorPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "RarityColorPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.RarityColorPair>.NativeClassPtr);
				DLC5_RogueLikeCardSelectorPanel.RarityColorPair.NativeFieldInfoPtr_Rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.RarityColorPair>.NativeClassPtr, "Rarity");
				DLC5_RogueLikeCardSelectorPanel.RarityColorPair.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.RarityColorPair>.NativeClassPtr, "Color");
				DLC5_RogueLikeCardSelectorPanel.RarityColorPair.NativeFieldInfoPtr_Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.RarityColorPair>.NativeClassPtr, "Back");
			}

			// Token: 0x06009970 RID: 39280 RVA: 0x00053007 File Offset: 0x00051207
			public RarityColorPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009971 RID: 39281 RVA: 0x00053010 File Offset: 0x00051210
			public RarityColorPair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.RarityColorPair>.NativeClassPtr))
			{
			}

			// Token: 0x170032EC RID: 13036
			// (get) Token: 0x06009972 RID: 39282 RVA: 0x0028EBA4 File Offset: 0x0028CDA4
			// (set) Token: 0x06009973 RID: 39283 RVA: 0x00053022 File Offset: 0x00051222
			public unsafe RogueLikeCardBase.Rarity Rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.RarityColorPair.NativeFieldInfoPtr_Rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.RarityColorPair.NativeFieldInfoPtr_Rarity)) = value;
				}
			}

			// Token: 0x170032ED RID: 13037
			// (get) Token: 0x06009974 RID: 39284 RVA: 0x0028EBCC File Offset: 0x0028CDCC
			// (set) Token: 0x06009975 RID: 39285 RVA: 0x0005303D File Offset: 0x0005123D
			public unsafe Sprite Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.RarityColorPair.NativeFieldInfoPtr_Color);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.RarityColorPair.NativeFieldInfoPtr_Color), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032EE RID: 13038
			// (get) Token: 0x06009976 RID: 39286 RVA: 0x0028EBFC File Offset: 0x0028CDFC
			// (set) Token: 0x06009977 RID: 39287 RVA: 0x0005305C File Offset: 0x0005125C
			public unsafe Sprite Back
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.RarityColorPair.NativeFieldInfoPtr_Back);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.RarityColorPair.NativeFieldInfoPtr_Back), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400634E RID: 25422
			private static readonly IntPtr NativeFieldInfoPtr_Rarity;

			// Token: 0x0400634F RID: 25423
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04006350 RID: 25424
			private static readonly IntPtr NativeFieldInfoPtr_Back;
		}

		// Token: 0x020006C7 RID: 1735
		public sealed class OpenContext : ValueType
		{
			// Token: 0x06009978 RID: 39288 RVA: 0x0028EC2C File Offset: 0x0028CE2C
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.OpenContext>.NativeClassPtr);
				DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_TriggerCardConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.OpenContext>.NativeClassPtr, "TriggerCardConditions");
				DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_GetCardListsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.OpenContext>.NativeClassPtr, "GetCardListsCallback");
				DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_AfterSelectCardCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.OpenContext>.NativeClassPtr, "AfterSelectCardCallback");
				DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.OpenContext>.NativeClassPtr, "RogueLikeRunTimeData");
				DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_RogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.OpenContext>.NativeClassPtr, "RogueLikeManager");
				DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_GetCardPropertyFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.OpenContext>.NativeClassPtr, "GetCardPropertyFunc");
				DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_AfterRefreshCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.OpenContext>.NativeClassPtr, "AfterRefreshCallback");
				DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_GetFundCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.OpenContext>.NativeClassPtr, "GetFundCallback");
				DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Queue_1_TriggerCardCondition_Func_2_TriggerCardCondition_List_1_RogueLikeCardInstance_Action_3_TriggerCardCondition_RogueLikeCardInstance_List_1_RogueLikeCardInstance_RogueLikeRunTimeData_RogueLikeManager_Func_2_CardType_RogueLikeCardBase_Action_1_Int32_Func_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.OpenContext>.NativeClassPtr, 100668342);
			}

			// Token: 0x06009979 RID: 39289 RVA: 0x0028ED0C File Offset: 0x0028CF0C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 72838, RefRangeEnd = 72841, XrefRangeStart = 72830, XrefRangeEnd = 72838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(Queue<TriggerCardCondition> triggerCardConditions, Func<TriggerCardCondition, List<RogueLikeCardInstance>> getCardListsCallback, Action<TriggerCardCondition, RogueLikeCardInstance, List<RogueLikeCardInstance>> afterSelectCardCallback, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikeManager rogueLikeManager, Func<RogueLikeCardBase.CardType, RogueLikeCardBase> getCardPropertyFunc, Action<int> afterRefreshCallback, Func<int> getFundCallback) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerCardConditions);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getCardListsCallback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterSelectCardCallback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getCardPropertyFunc);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterRefreshCallback);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getFundCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_Queue_1_TriggerCardCondition_Func_2_TriggerCardCondition_List_1_RogueLikeCardInstance_Action_3_TriggerCardCondition_RogueLikeCardInstance_List_1_RogueLikeCardInstance_RogueLikeRunTimeData_RogueLikeManager_Func_2_CardType_RogueLikeCardBase_Action_1_Int32_Func_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600997A RID: 39290 RVA: 0x0005307B File Offset: 0x0005127B
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600997B RID: 39291 RVA: 0x00053084 File Offset: 0x00051284
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x170032EF RID: 13039
			// (get) Token: 0x0600997C RID: 39292 RVA: 0x0028EDE0 File Offset: 0x0028CFE0
			// (set) Token: 0x0600997D RID: 39293 RVA: 0x00053096 File Offset: 0x00051296
			public unsafe Queue<TriggerCardCondition> TriggerCardConditions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_TriggerCardConditions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<TriggerCardCondition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_TriggerCardConditions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032F0 RID: 13040
			// (get) Token: 0x0600997E RID: 39294 RVA: 0x0028EE10 File Offset: 0x0028D010
			// (set) Token: 0x0600997F RID: 39295 RVA: 0x000530B5 File Offset: 0x000512B5
			public unsafe Func<TriggerCardCondition, List<RogueLikeCardInstance>> GetCardListsCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_GetCardListsCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TriggerCardCondition, List<RogueLikeCardInstance>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_GetCardListsCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032F1 RID: 13041
			// (get) Token: 0x06009980 RID: 39296 RVA: 0x0028EE40 File Offset: 0x0028D040
			// (set) Token: 0x06009981 RID: 39297 RVA: 0x000530D4 File Offset: 0x000512D4
			public unsafe Action<TriggerCardCondition, RogueLikeCardInstance, List<RogueLikeCardInstance>> AfterSelectCardCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_AfterSelectCardCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TriggerCardCondition, RogueLikeCardInstance, List<RogueLikeCardInstance>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_AfterSelectCardCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032F2 RID: 13042
			// (get) Token: 0x06009982 RID: 39298 RVA: 0x0028EE70 File Offset: 0x0028D070
			// (set) Token: 0x06009983 RID: 39299 RVA: 0x000530F3 File Offset: 0x000512F3
			public unsafe RogueLikeRunTimeData RogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032F3 RID: 13043
			// (get) Token: 0x06009984 RID: 39300 RVA: 0x0028EEA0 File Offset: 0x0028D0A0
			// (set) Token: 0x06009985 RID: 39301 RVA: 0x00053112 File Offset: 0x00051312
			public unsafe RogueLikeManager RogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_RogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_RogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032F4 RID: 13044
			// (get) Token: 0x06009986 RID: 39302 RVA: 0x0028EED0 File Offset: 0x0028D0D0
			// (set) Token: 0x06009987 RID: 39303 RVA: 0x00053131 File Offset: 0x00051331
			public unsafe Func<RogueLikeCardBase.CardType, RogueLikeCardBase> GetCardPropertyFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_GetCardPropertyFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RogueLikeCardBase.CardType, RogueLikeCardBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_GetCardPropertyFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032F5 RID: 13045
			// (get) Token: 0x06009988 RID: 39304 RVA: 0x0028EF00 File Offset: 0x0028D100
			// (set) Token: 0x06009989 RID: 39305 RVA: 0x00053150 File Offset: 0x00051350
			public unsafe Action<int> AfterRefreshCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_AfterRefreshCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_AfterRefreshCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032F6 RID: 13046
			// (get) Token: 0x0600998A RID: 39306 RVA: 0x0028EF30 File Offset: 0x0028D130
			// (set) Token: 0x0600998B RID: 39307 RVA: 0x0005316F File Offset: 0x0005136F
			public unsafe Func<int> GetFundCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_GetFundCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.OpenContext.NativeFieldInfoPtr_GetFundCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006351 RID: 25425
			private static readonly IntPtr NativeFieldInfoPtr_TriggerCardConditions;

			// Token: 0x04006352 RID: 25426
			private static readonly IntPtr NativeFieldInfoPtr_GetCardListsCallback;

			// Token: 0x04006353 RID: 25427
			private static readonly IntPtr NativeFieldInfoPtr_AfterSelectCardCallback;

			// Token: 0x04006354 RID: 25428
			private static readonly IntPtr NativeFieldInfoPtr_RogueLikeRunTimeData;

			// Token: 0x04006355 RID: 25429
			private static readonly IntPtr NativeFieldInfoPtr_RogueLikeManager;

			// Token: 0x04006356 RID: 25430
			private static readonly IntPtr NativeFieldInfoPtr_GetCardPropertyFunc;

			// Token: 0x04006357 RID: 25431
			private static readonly IntPtr NativeFieldInfoPtr_AfterRefreshCallback;

			// Token: 0x04006358 RID: 25432
			private static readonly IntPtr NativeFieldInfoPtr_GetFundCallback;

			// Token: 0x04006359 RID: 25433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Queue_1_TriggerCardCondition_Func_2_TriggerCardCondition_List_1_RogueLikeCardInstance_Action_3_TriggerCardCondition_RogueLikeCardInstance_List_1_RogueLikeCardInstance_RogueLikeRunTimeData_RogueLikeManager_Func_2_CardType_RogueLikeCardBase_Action_1_Int32_Func_1_Int32_0;
		}

		// Token: 0x020006C8 RID: 1736
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardSelectorPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600998C RID: 39308 RVA: 0x0028EF60 File Offset: 0x0028D160
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c>.NativeClassPtr);
				DLC5_RogueLikeCardSelectorPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeCardSelectorPanel.__c.NativeFieldInfoPtr___9__46_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c>.NativeClassPtr, "<>9__46_1");
				DLC5_RogueLikeCardSelectorPanel.__c.NativeFieldInfoPtr___9__46_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c>.NativeClassPtr, "<>9__46_2");
				DLC5_RogueLikeCardSelectorPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c>.NativeClassPtr, 100668344);
				DLC5_RogueLikeCardSelectorPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_1_Internal_Rarity_RarityColorPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c>.NativeClassPtr, 100668345);
				DLC5_RogueLikeCardSelectorPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_2_Internal_ValueTuple_2_Sprite_Sprite_RarityColorPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c>.NativeClassPtr, 100668346);
			}

			// Token: 0x0600998D RID: 39309 RVA: 0x0028F004 File Offset: 0x0028D204
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600998E RID: 39310 RVA: 0x0028F040 File Offset: 0x0028D240
			[CallerCount(0)]
			public unsafe RogueLikeCardBase.Rarity _OnPanelInitialize_b__46_1(DLC5_RogueLikeCardSelectorPanel.RarityColorPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_1_Internal_Rarity_RarityColorPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600998F RID: 39311 RVA: 0x0028F094 File Offset: 0x0028D294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72841, XrefRangeEnd = 72844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<Sprite, Sprite> _OnPanelInitialize_b__46_2(DLC5_RogueLikeCardSelectorPanel.RarityColorPair y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__46_2_Internal_ValueTuple_2_Sprite_Sprite_RarityColorPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<Sprite, Sprite>(pointer);
			}

			// Token: 0x06009990 RID: 39312 RVA: 0x0005318E File Offset: 0x0005138E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032F7 RID: 13047
			// (get) Token: 0x06009991 RID: 39313 RVA: 0x0028F0E4 File Offset: 0x0028D2E4
			// (set) Token: 0x06009992 RID: 39314 RVA: 0x00053197 File Offset: 0x00051397
			public unsafe static DLC5_RogueLikeCardSelectorPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardSelectorPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardSelectorPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032F8 RID: 13048
			// (get) Token: 0x06009993 RID: 39315 RVA: 0x0028F10C File Offset: 0x0028D30C
			// (set) Token: 0x06009994 RID: 39316 RVA: 0x000531A9 File Offset: 0x000513A9
			public unsafe static Func<DLC5_RogueLikeCardSelectorPanel.RarityColorPair, RogueLikeCardBase.Rarity> __9__46_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardSelectorPanel.__c.NativeFieldInfoPtr___9__46_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeCardSelectorPanel.RarityColorPair, RogueLikeCardBase.Rarity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardSelectorPanel.__c.NativeFieldInfoPtr___9__46_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032F9 RID: 13049
			// (get) Token: 0x06009995 RID: 39317 RVA: 0x0028F134 File Offset: 0x0028D334
			// (set) Token: 0x06009996 RID: 39318 RVA: 0x000531BB File Offset: 0x000513BB
			public unsafe static Func<DLC5_RogueLikeCardSelectorPanel.RarityColorPair, ValueTuple<Sprite, Sprite>> __9__46_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeCardSelectorPanel.__c.NativeFieldInfoPtr___9__46_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeCardSelectorPanel.RarityColorPair, ValueTuple<Sprite, Sprite>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeCardSelectorPanel.__c.NativeFieldInfoPtr___9__46_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400635A RID: 25434
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400635B RID: 25435
			private static readonly IntPtr NativeFieldInfoPtr___9__46_1;

			// Token: 0x0400635C RID: 25436
			private static readonly IntPtr NativeFieldInfoPtr___9__46_2;

			// Token: 0x0400635D RID: 25437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400635E RID: 25438
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_1_Internal_Rarity_RarityColorPair_0;

			// Token: 0x0400635F RID: 25439
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__46_2_Internal_ValueTuple_2_Sprite_Sprite_RarityColorPair_0;
		}

		// Token: 0x020006C9 RID: 1737
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardSelectorPanel+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Il2CppSystem.Object
		{
			// Token: 0x06009997 RID: 39319 RVA: 0x0028F15C File Offset: 0x0028D35C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0>.NativeClassPtr);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0.NativeFieldInfoPtr_thisCardList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0>.NativeClassPtr, "thisCardList");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0>.NativeClassPtr, 100668347);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0.NativeMethodInfoPtr__DequeueAndUpdateCard_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0>.NativeClassPtr, 100668348);
			}

			// Token: 0x06009998 RID: 39320 RVA: 0x0028F1D8 File Offset: 0x0028D3D8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009999 RID: 39321 RVA: 0x0028F214 File Offset: 0x0028D414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72844, XrefRangeEnd = 72850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DequeueAndUpdateCard_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0.NativeMethodInfoPtr__DequeueAndUpdateCard_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600999A RID: 39322 RVA: 0x000531CD File Offset: 0x000513CD
			public __c__DisplayClass53_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032FA RID: 13050
			// (get) Token: 0x0600999B RID: 39323 RVA: 0x0028F248 File Offset: 0x0028D448
			// (set) Token: 0x0600999C RID: 39324 RVA: 0x000531D6 File Offset: 0x000513D6
			public unsafe DLC5_RogueLikeCardSelectorPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032FB RID: 13051
			// (get) Token: 0x0600999D RID: 39325 RVA: 0x0028F278 File Offset: 0x0028D478
			// (set) Token: 0x0600999E RID: 39326 RVA: 0x000531F5 File Offset: 0x000513F5
			public unsafe TriggerCardCondition thisCardList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0.NativeFieldInfoPtr_thisCardList);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass53_0.NativeFieldInfoPtr_thisCardList)) = value;
				}
			}

			// Token: 0x04006360 RID: 25440
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006361 RID: 25441
			private static readonly IntPtr NativeFieldInfoPtr_thisCardList;

			// Token: 0x04006362 RID: 25442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006363 RID: 25443
			private static readonly IntPtr NativeMethodInfoPtr__DequeueAndUpdateCard_b__0_Internal_Void_0;
		}

		// Token: 0x020006CA RID: 1738
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardSelectorPanel+<>c__DisplayClass54_0")]
		public sealed class __c__DisplayClass54_0 : Il2CppSystem.Object
		{
			// Token: 0x0600999F RID: 39327 RVA: 0x0028F2A0 File Offset: 0x0028D4A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "<>c__DisplayClass54_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0>.NativeClassPtr);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeFieldInfoPtr_thisCardList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0>.NativeClassPtr, "thisCardList");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0>.NativeClassPtr, 100668349);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_RogueLikeCardInstance_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0>.NativeClassPtr, 100668350);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeMethodInfoPtr__UpdateCard_b__8_Internal_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0>.NativeClassPtr, 100668351);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeMethodInfoPtr__UpdateCard_b__9_Internal_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0>.NativeClassPtr, 100668352);
			}

			// Token: 0x060099A0 RID: 39328 RVA: 0x0028F344 File Offset: 0x0028D544
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099A1 RID: 39329 RVA: 0x0028F380 File Offset: 0x0028D580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72850, XrefRangeEnd = 72988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UIElementCluster_RogueLikeCardInstance_PDM_0(UIElementCluster uiElement, RogueLikeCardInstance card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElement);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_RogueLikeCardInstance_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099A2 RID: 39330 RVA: 0x0028F3D4 File Offset: 0x0028D5D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72988, XrefRangeEnd = 72992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCard_b__8(MoveDirection direction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeMethodInfoPtr__UpdateCard_b__8_Internal_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099A3 RID: 39331 RVA: 0x0028F414 File Offset: 0x0028D614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72992, XrefRangeEnd = 72995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCard_b__9(MoveDirection direction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeMethodInfoPtr__UpdateCard_b__9_Internal_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099A4 RID: 39332 RVA: 0x00053210 File Offset: 0x00051410
			public __c__DisplayClass54_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032FC RID: 13052
			// (get) Token: 0x060099A5 RID: 39333 RVA: 0x0028F454 File Offset: 0x0028D654
			// (set) Token: 0x060099A6 RID: 39334 RVA: 0x00053219 File Offset: 0x00051419
			public unsafe DLC5_RogueLikeCardSelectorPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032FD RID: 13053
			// (get) Token: 0x060099A7 RID: 39335 RVA: 0x0028F484 File Offset: 0x0028D684
			// (set) Token: 0x060099A8 RID: 39336 RVA: 0x00053238 File Offset: 0x00051438
			public unsafe TriggerCardCondition thisCardList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeFieldInfoPtr_thisCardList);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0.NativeFieldInfoPtr_thisCardList)) = value;
				}
			}

			// Token: 0x04006364 RID: 25444
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006365 RID: 25445
			private static readonly IntPtr NativeFieldInfoPtr_thisCardList;

			// Token: 0x04006366 RID: 25446
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006367 RID: 25447
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_RogueLikeCardInstance_PDM_0;

			// Token: 0x04006368 RID: 25448
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCard_b__8_Internal_Void_MoveDirection_0;

			// Token: 0x04006369 RID: 25449
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCard_b__9_Internal_Void_MoveDirection_0;
		}

		// Token: 0x020006CB RID: 1739
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardSelectorPanel+<>c__DisplayClass54_1")]
		public sealed class __c__DisplayClass54_1 : Il2CppSystem.Object
		{
			// Token: 0x060099A9 RID: 39337 RVA: 0x0028F4AC File Offset: 0x0028D6AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "<>c__DisplayClass54_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, "data");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_getCardForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, "getCardForm");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_isForeverCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, "isForeverCard");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, "title");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, "description");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, "card");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_extra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, "extra");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, "interactable");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, 100668353);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, 100668354);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, 100668355);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, 100668356);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, 100668357);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, 100668358);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__6_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, 100668359);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__7_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, 100668360);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__10_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, 100668361);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__11_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr, 100668362);
			}

			// Token: 0x060099AA RID: 39338 RVA: 0x0028F654 File Offset: 0x0028D854
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099AB RID: 39339 RVA: 0x0028F690 File Offset: 0x0028D890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72995, XrefRangeEnd = 72999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCard_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099AC RID: 39340 RVA: 0x0028F6D4 File Offset: 0x0028D8D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72999, XrefRangeEnd = 73001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCard_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099AD RID: 39341 RVA: 0x0028F718 File Offset: 0x0028D918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73001, XrefRangeEnd = 73007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCard_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099AE RID: 39342 RVA: 0x0028F75C File Offset: 0x0028D95C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73007, XrefRangeEnd = 73013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCard_b__4(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099AF RID: 39343 RVA: 0x0028F7A0 File Offset: 0x0028D9A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73013, XrefRangeEnd = 73015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCard_b__5(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099B0 RID: 39344 RVA: 0x0028F7E4 File Offset: 0x0028D9E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73015, XrefRangeEnd = 73041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCard_b__6(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__6_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099B1 RID: 39345 RVA: 0x0028F828 File Offset: 0x0028DA28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73041, XrefRangeEnd = 73043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCard_b__7(CanvasGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__7_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099B2 RID: 39346 RVA: 0x0028F86C File Offset: 0x0028DA6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73043, XrefRangeEnd = 73046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCard_b__10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__10_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099B3 RID: 39347 RVA: 0x0028F8A0 File Offset: 0x0028DAA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73046, XrefRangeEnd = 73062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCard_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeMethodInfoPtr__UpdateCard_b__11_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099B4 RID: 39348 RVA: 0x00053253 File Offset: 0x00051453
			public __c__DisplayClass54_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170032FE RID: 13054
			// (get) Token: 0x060099B5 RID: 39349 RVA: 0x0028F8D4 File Offset: 0x0028DAD4
			// (set) Token: 0x060099B6 RID: 39350 RVA: 0x0005325C File Offset: 0x0005145C
			public unsafe RogueLikeCardBase data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeCardBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170032FF RID: 13055
			// (get) Token: 0x060099B7 RID: 39351 RVA: 0x0028F904 File Offset: 0x0028DB04
			// (set) Token: 0x060099B8 RID: 39352 RVA: 0x0005327B File Offset: 0x0005147B
			public unsafe bool getCardForm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_getCardForm);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_getCardForm)) = value;
				}
			}

			// Token: 0x17003300 RID: 13056
			// (get) Token: 0x060099B9 RID: 39353 RVA: 0x0028F92C File Offset: 0x0028DB2C
			// (set) Token: 0x060099BA RID: 39354 RVA: 0x00053296 File Offset: 0x00051496
			public unsafe bool isForeverCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_isForeverCard);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_isForeverCard)) = value;
				}
			}

			// Token: 0x17003301 RID: 13057
			// (get) Token: 0x060099BB RID: 39355 RVA: 0x0028F954 File Offset: 0x0028DB54
			// (set) Token: 0x060099BC RID: 39356 RVA: 0x000532B1 File Offset: 0x000514B1
			public unsafe string title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003302 RID: 13058
			// (get) Token: 0x060099BD RID: 39357 RVA: 0x0028F97C File Offset: 0x0028DB7C
			// (set) Token: 0x060099BE RID: 39358 RVA: 0x000532D0 File Offset: 0x000514D0
			public unsafe string description
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_description);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003303 RID: 13059
			// (get) Token: 0x060099BF RID: 39359 RVA: 0x0028F9A4 File Offset: 0x0028DBA4
			// (set) Token: 0x060099C0 RID: 39360 RVA: 0x000532EF File Offset: 0x000514EF
			public unsafe RogueLikeCardInstance card
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_card);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeCardInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003304 RID: 13060
			// (get) Token: 0x060099C1 RID: 39361 RVA: 0x0028F9D4 File Offset: 0x0028DBD4
			// (set) Token: 0x060099C2 RID: 39362 RVA: 0x0005330E File Offset: 0x0005150E
			public unsafe string extra
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_extra);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_extra), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003305 RID: 13061
			// (get) Token: 0x060099C3 RID: 39363 RVA: 0x0028F9FC File Offset: 0x0028DBFC
			// (set) Token: 0x060099C4 RID: 39364 RVA: 0x0005332D File Offset: 0x0005152D
			public unsafe UIButtonDoubleClickHold interactable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_interactable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonDoubleClickHold>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_interactable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003306 RID: 13062
			// (get) Token: 0x060099C5 RID: 39365 RVA: 0x0028FA2C File Offset: 0x0028DC2C
			// (set) Token: 0x060099C6 RID: 39366 RVA: 0x0005334C File Offset: 0x0005154C
			public unsafe DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0 field_Public___c__DisplayClass54_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass54_1.NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400636A RID: 25450
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400636B RID: 25451
			private static readonly IntPtr NativeFieldInfoPtr_getCardForm;

			// Token: 0x0400636C RID: 25452
			private static readonly IntPtr NativeFieldInfoPtr_isForeverCard;

			// Token: 0x0400636D RID: 25453
			private static readonly IntPtr NativeFieldInfoPtr_title;

			// Token: 0x0400636E RID: 25454
			private static readonly IntPtr NativeFieldInfoPtr_description;

			// Token: 0x0400636F RID: 25455
			private static readonly IntPtr NativeFieldInfoPtr_card;

			// Token: 0x04006370 RID: 25456
			private static readonly IntPtr NativeFieldInfoPtr_extra;

			// Token: 0x04006371 RID: 25457
			private static readonly IntPtr NativeFieldInfoPtr_interactable;

			// Token: 0x04006372 RID: 25458
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass54_0_0;

			// Token: 0x04006373 RID: 25459
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006374 RID: 25460
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCard_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006375 RID: 25461
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCard_b__2_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006376 RID: 25462
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCard_b__3_Internal_Void_Image_0;

			// Token: 0x04006377 RID: 25463
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCard_b__4_Internal_Void_Image_0;

			// Token: 0x04006378 RID: 25464
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCard_b__5_Internal_Void_Image_0;

			// Token: 0x04006379 RID: 25465
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCard_b__6_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400637A RID: 25466
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCard_b__7_Internal_Void_CanvasGroup_0;

			// Token: 0x0400637B RID: 25467
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCard_b__10_Internal_Void_0;

			// Token: 0x0400637C RID: 25468
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCard_b__11_Internal_Void_0;
		}

		// Token: 0x020006CC RID: 1740
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardSelectorPanel+<PlayStartAnim>d__58")]
		public sealed class _PlayStartAnim_d__58 : Il2CppSystem.Object
		{
			// Token: 0x060099C7 RID: 39367 RVA: 0x0028FA5C File Offset: 0x0028DC5C
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayStartAnim_d__58()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "<PlayStartAnim>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58>.NativeClassPtr);
				DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58>.NativeClassPtr, 100668363);
				DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58>.NativeClassPtr, 100668364);
				DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58>.NativeClassPtr, 100668365);
				DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58>.NativeClassPtr, 100668366);
				DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58>.NativeClassPtr, 100668367);
				DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58>.NativeClassPtr, 100668368);
			}

			// Token: 0x060099C8 RID: 39368 RVA: 0x0028FB3C File Offset: 0x0028DD3C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayStartAnim_d__58(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099C9 RID: 39369 RVA: 0x0028FB84 File Offset: 0x0028DD84
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099CA RID: 39370 RVA: 0x0028FBB8 File Offset: 0x0028DDB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73062, XrefRangeEnd = 73066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700330A RID: 13066
			// (get) Token: 0x060099CB RID: 39371 RVA: 0x0028FBF4 File Offset: 0x0028DDF4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060099CC RID: 39372 RVA: 0x0028FC34 File Offset: 0x0028DE34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73066, XrefRangeEnd = 73072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700330B RID: 13067
			// (get) Token: 0x060099CD RID: 39373 RVA: 0x0028FC68 File Offset: 0x0028DE68
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060099CE RID: 39374 RVA: 0x0005336B File Offset: 0x0005156B
			public _PlayStartAnim_d__58(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003307 RID: 13063
			// (get) Token: 0x060099CF RID: 39375 RVA: 0x0028FCA8 File Offset: 0x0028DEA8
			// (set) Token: 0x060099D0 RID: 39376 RVA: 0x00053374 File Offset: 0x00051574
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003308 RID: 13064
			// (get) Token: 0x060099D1 RID: 39377 RVA: 0x0028FCD0 File Offset: 0x0028DED0
			// (set) Token: 0x060099D2 RID: 39378 RVA: 0x0005338F File Offset: 0x0005158F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003309 RID: 13065
			// (get) Token: 0x060099D3 RID: 39379 RVA: 0x0028FD00 File Offset: 0x0028DF00
			// (set) Token: 0x060099D4 RID: 39380 RVA: 0x000533AE File Offset: 0x000515AE
			public unsafe DLC5_RogueLikeCardSelectorPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayStartAnim_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400637D RID: 25469
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400637E RID: 25470
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400637F RID: 25471
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006380 RID: 25472
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006381 RID: 25473
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006382 RID: 25474
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006383 RID: 25475
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006384 RID: 25476
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006385 RID: 25477
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020006CD RID: 1741
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardSelectorPanel+<>c__DisplayClass59_0")]
		public sealed class __c__DisplayClass59_0 : Il2CppSystem.Object
		{
			// Token: 0x060099D5 RID: 39381 RVA: 0x0028FD30 File Offset: 0x0028DF30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass59_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "<>c__DisplayClass59_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0>.NativeClassPtr);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0>.NativeClassPtr, "count");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0>.NativeClassPtr, 100668369);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeMethodInfoPtr__PlayDealAnimations_b__0_Internal_Void_UIButtonBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0>.NativeClassPtr, 100668370);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Animator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0>.NativeClassPtr, 100668371);
				DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeMethodInfoPtr__PlayDealAnimations_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0>.NativeClassPtr, 100668372);
			}

			// Token: 0x060099D6 RID: 39382 RVA: 0x0028FDD4 File Offset: 0x0028DFD4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass59_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099D7 RID: 39383 RVA: 0x0028FE10 File Offset: 0x0028E010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73082, XrefRangeEnd = 73093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PlayDealAnimations_b__0(UIButtonBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeMethodInfoPtr__PlayDealAnimations_b__0_Internal_Void_UIButtonBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099D8 RID: 39384 RVA: 0x0028FE54 File Offset: 0x0028E054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73093, XrefRangeEnd = 73099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Animator_PDM_0(Animator animator)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Animator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060099D9 RID: 39385 RVA: 0x0028FEA4 File Offset: 0x0028E0A4
			[CallerCount(0)]
			public unsafe bool _PlayDealAnimations_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeMethodInfoPtr__PlayDealAnimations_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060099DA RID: 39386 RVA: 0x000533CD File Offset: 0x000515CD
			public __c__DisplayClass59_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700330C RID: 13068
			// (get) Token: 0x060099DB RID: 39387 RVA: 0x0028FEE0 File Offset: 0x0028E0E0
			// (set) Token: 0x060099DC RID: 39388 RVA: 0x000533D6 File Offset: 0x000515D6
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x1700330D RID: 13069
			// (get) Token: 0x060099DD RID: 39389 RVA: 0x0028FF08 File Offset: 0x0028E108
			// (set) Token: 0x060099DE RID: 39390 RVA: 0x000533F1 File Offset: 0x000515F1
			public unsafe DLC5_RogueLikeCardSelectorPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006386 RID: 25478
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04006387 RID: 25479
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006388 RID: 25480
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006389 RID: 25481
			private static readonly IntPtr NativeMethodInfoPtr__PlayDealAnimations_b__0_Internal_Void_UIButtonBase_0;

			// Token: 0x0400638A RID: 25482
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Animator_PDM_0;

			// Token: 0x0400638B RID: 25483
			private static readonly IntPtr NativeMethodInfoPtr__PlayDealAnimations_b__2_Internal_Boolean_0;

			// Token: 0x02000FC8 RID: 4040
			[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardSelectorPanel+<>c__DisplayClass59_0+<<PlayDealAnimations>g__PlayAnim|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011614 RID: 71188 RVA: 0x003FEFB8 File Offset: 0x003FD1B8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique()
				{
					Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0>.NativeClassPtr, "<<PlayDealAnimations>g__PlayAnim|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique>.NativeClassPtr);
					DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique>.NativeClassPtr, "<>1__state");
					DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique>.NativeClassPtr, "<>2__current");
					DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique>.NativeClassPtr, "animator");
					DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique>.NativeClassPtr, "<>4__this");
					DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique>.NativeClassPtr, 100668373);
					DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique>.NativeClassPtr, 100668374);
					DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique>.NativeClassPtr, 100668375);
					DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique>.NativeClassPtr, 100668376);
					DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique>.NativeClassPtr, 100668377);
					DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique>.NativeClassPtr, 100668378);
				}

				// Token: 0x06011615 RID: 71189 RVA: 0x003FF0AC File Offset: 0x003FD2AC
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011616 RID: 71190 RVA: 0x003FF0F4 File Offset: 0x003FD2F4
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011617 RID: 71191 RVA: 0x003FF128 File Offset: 0x003FD328
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73072, XrefRangeEnd = 73076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005A58 RID: 23128
				// (get) Token: 0x06011618 RID: 71192 RVA: 0x003FF164 File Offset: 0x003FD364
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011619 RID: 71193 RVA: 0x003FF1A4 File Offset: 0x003FD3A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73076, XrefRangeEnd = 73082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005A59 RID: 23129
				// (get) Token: 0x0601161A RID: 71194 RVA: 0x003FF1D8 File Offset: 0x003FD3D8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601161B RID: 71195 RVA: 0x000973C0 File Offset: 0x000955C0
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A54 RID: 23124
				// (get) Token: 0x0601161C RID: 71196 RVA: 0x003FF218 File Offset: 0x003FD418
				// (set) Token: 0x0601161D RID: 71197 RVA: 0x000973C9 File Offset: 0x000955C9
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005A55 RID: 23125
				// (get) Token: 0x0601161E RID: 71198 RVA: 0x003FF240 File Offset: 0x003FD440
				// (set) Token: 0x0601161F RID: 71199 RVA: 0x000973E4 File Offset: 0x000955E4
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A56 RID: 23126
				// (get) Token: 0x06011620 RID: 71200 RVA: 0x003FF270 File Offset: 0x003FD470
				// (set) Token: 0x06011621 RID: 71201 RVA: 0x00097403 File Offset: 0x00095603
				public unsafe Animator animator
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeFieldInfoPtr_animator);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A57 RID: 23127
				// (get) Token: 0x06011622 RID: 71202 RVA: 0x003FF2A0 File Offset: 0x003FD4A0
				// (set) Token: 0x06011623 RID: 71203 RVA: 0x00097422 File Offset: 0x00095622
				public unsafe DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAnanObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AF9F RID: 44959
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AFA0 RID: 44960
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AFA1 RID: 44961
				private static readonly IntPtr NativeFieldInfoPtr_animator;

				// Token: 0x0400AFA2 RID: 44962
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AFA3 RID: 44963
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AFA4 RID: 44964
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AFA5 RID: 44965
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AFA6 RID: 44966
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AFA7 RID: 44967
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AFA8 RID: 44968
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020006CE RID: 1742
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardSelectorPanel+<PlayDealAnimations>d__59")]
		public sealed class _PlayDealAnimations_d__59 : Il2CppSystem.Object
		{
			// Token: 0x060099DF RID: 39391 RVA: 0x0028FF38 File Offset: 0x0028E138
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayDealAnimations_d__59()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel>.NativeClassPtr, "<PlayDealAnimations>d__59");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59>.NativeClassPtr);
				DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59>.NativeClassPtr, "<>8__1");
				DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59>.NativeClassPtr, 100668379);
				DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59>.NativeClassPtr, 100668380);
				DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59>.NativeClassPtr, 100668381);
				DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59>.NativeClassPtr, 100668382);
				DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59>.NativeClassPtr, 100668383);
				DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59>.NativeClassPtr, 100668384);
			}

			// Token: 0x060099E0 RID: 39392 RVA: 0x0029002C File Offset: 0x0028E22C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayDealAnimations_d__59(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099E1 RID: 39393 RVA: 0x00290074 File Offset: 0x0028E274
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060099E2 RID: 39394 RVA: 0x002900A8 File Offset: 0x0028E2A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73099, XrefRangeEnd = 73143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003312 RID: 13074
			// (get) Token: 0x060099E3 RID: 39395 RVA: 0x002900E4 File Offset: 0x0028E2E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060099E4 RID: 39396 RVA: 0x00290124 File Offset: 0x0028E324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73143, XrefRangeEnd = 73149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003313 RID: 13075
			// (get) Token: 0x060099E5 RID: 39397 RVA: 0x00290158 File Offset: 0x0028E358
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060099E6 RID: 39398 RVA: 0x00053410 File Offset: 0x00051610
			public _PlayDealAnimations_d__59(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700330E RID: 13070
			// (get) Token: 0x060099E7 RID: 39399 RVA: 0x00290198 File Offset: 0x0028E398
			// (set) Token: 0x060099E8 RID: 39400 RVA: 0x00053419 File Offset: 0x00051619
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700330F RID: 13071
			// (get) Token: 0x060099E9 RID: 39401 RVA: 0x002901C0 File Offset: 0x0028E3C0
			// (set) Token: 0x060099EA RID: 39402 RVA: 0x00053434 File Offset: 0x00051634
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003310 RID: 13072
			// (get) Token: 0x060099EB RID: 39403 RVA: 0x002901F0 File Offset: 0x0028E3F0
			// (set) Token: 0x060099EC RID: 39404 RVA: 0x00053453 File Offset: 0x00051653
			public unsafe DLC5_RogueLikeCardSelectorPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003311 RID: 13073
			// (get) Token: 0x060099ED RID: 39405 RVA: 0x00290220 File Offset: 0x0028E420
			// (set) Token: 0x060099EE RID: 39406 RVA: 0x00053472 File Offset: 0x00051672
			public unsafe DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardSelectorPanel.__c__DisplayClass59_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardSelectorPanel._PlayDealAnimations_d__59.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400638C RID: 25484
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400638D RID: 25485
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400638E RID: 25486
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400638F RID: 25487
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04006390 RID: 25488
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006391 RID: 25489
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006392 RID: 25490
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006393 RID: 25491
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006394 RID: 25492
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006395 RID: 25493
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
