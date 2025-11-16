using System;
using System.Runtime.InteropServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000AB RID: 171
	public class DLC4_ChallengeCardSelectorPanel : UIPanelParamExternOpen<IChallengeCardSelectorPanelDB>
	{
		// Token: 0x06001254 RID: 4692 RVA: 0x000DC0A4 File Offset: 0x000DA2A4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_ChallengeCardSelectorPanel()
		{
			Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_ChallengeCardSelectorPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr);
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_s_Focus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "s_Focus");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_CardField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_CardField");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_CardPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_CardPrefab");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_NormalBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_NormalBG");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_SpecialBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_SpecialBG");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_NormalOutline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_NormalOutline");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_InvalidOutline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_InvalidOutline");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_NormalTextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_NormalTextColor");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_SpecialTextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_SpecialTextColor");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_Describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_Describer");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_DescriberRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_DescriberRectTransform");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_GameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_GameObjects");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_LogicalGroupT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_LogicalGroupT");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_WorldCornerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_WorldCornerBuffer");
			DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_CurrentDescriberStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "m_CurrentDescriberStatus");
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_IChallengeCardSelectorPanelDB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666487);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666488);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_GetTopLeftWorldCorner_Private_Vector3_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666489);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_RefreshElements_Private_Void_EnterGroupType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666490);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_InitializeCanUse_Private_Void_UIButtonSimple_UIElementCluster_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666491);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_InitializeInShopLoading_Private_Void_UIButtonSimple_UIElementCluster_byref_GuestGuardMapping_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666492);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_InitializeInShopCanBuy_Private_Void_UIButtonSimple_UIElementCluster_GuestGuardMapping_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666493);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_InitializeInShopOnField_Private_Void_UIButtonSimple_UIElementCluster_byref_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666494);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_InitializeInShopOnFieldLoading_Private_Void_UIButtonSimple_UIElementCluster_byref_GuestGuardMapping_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666495);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_DescribeGuest_Private_Void_RectTransform_byref_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666496);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_SetBGUI_Private_Void_UIElementCluster_byref_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666497);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_InitializeUIElements_Private_Static_Void_UIElementCluster_GuestGuardMapping_Boolean_Boolean_Single_Boolean_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666498);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_SetPriceUI_Private_Static_Void_UIElementCluster_byref_GuestGuardMapping_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666499);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_SetProgressUI_Private_Static_Void_UIElementCluster_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666500);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_SetCheckUI_Private_Static_Void_UIElementCluster_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666501);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_SetOutlineUI_Private_Static_Void_UIElementCluster_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666502);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666503);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666504);
			DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr__OnPanelInitialize_b__16_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, 100666506);
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x000DC37C File Offset: 0x000DA57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51537, XrefRangeEnd = 51541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(IChallengeCardSelectorPanelDB openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(openParam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_IChallengeCardSelectorPanelDB_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000DC3CC File Offset: 0x000DA5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51541, XrefRangeEnd = 51555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000DC408 File Offset: 0x000DA608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51555, XrefRangeEnd = 51556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTopLeftWorldCorner(RectTransform rectTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_GetTopLeftWorldCorner_Private_Vector3_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x000DC458 File Offset: 0x000DA658
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 51597, RefRangeEnd = 51599, XrefRangeStart = 51556, XrefRangeEnd = 51597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshElements(GroupedUILogicalGroup.EnterGroupType enterGroupType, bool resetAnimator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enterGroupType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetAnimator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_RefreshElements_Private_Void_EnterGroupType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x000DC4A4 File Offset: 0x000DA6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51599, XrefRangeEnd = 51617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeCanUse(UIButtonSimple uiButton, UIElementCluster uiElementCluster, GuestGuardMapping mapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiButton);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_InitializeCanUse_Private_Void_UIButtonSimple_UIElementCluster_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000DC510 File Offset: 0x000DA710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51617, XrefRangeEnd = 51623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeInShopLoading(UIButtonSimple uiButton, UIElementCluster uiElementCluster, [In] ref GuestGuardMapping mapping, bool isNoMoneySkin, float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiButton);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNoMoneySkin;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_InitializeInShopLoading_Private_Void_UIButtonSimple_UIElementCluster_byref_GuestGuardMapping_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x000DC594 File Offset: 0x000DA794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51623, XrefRangeEnd = 51640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeInShopCanBuy(UIButtonSimple uiButton, UIElementCluster uiElementCluster, GuestGuardMapping mapping, bool isNoMoneySkin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiButton);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNoMoneySkin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_InitializeInShopCanBuy_Private_Void_UIButtonSimple_UIElementCluster_GuestGuardMapping_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x000DC610 File Offset: 0x000DA810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51640, XrefRangeEnd = 51646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeInShopOnField(UIButtonSimple uiButton, UIElementCluster uiElementCluster, [In] ref GuestGuardMapping mapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiButton);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_InitializeInShopOnField_Private_Void_UIButtonSimple_UIElementCluster_byref_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000DC678 File Offset: 0x000DA878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51646, XrefRangeEnd = 51652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeInShopOnFieldLoading(UIButtonSimple uiButton, UIElementCluster uiElementCluster, [In] ref GuestGuardMapping mapping, float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiButton);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_InitializeInShopOnFieldLoading_Private_Void_UIButtonSimple_UIElementCluster_byref_GuestGuardMapping_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x000DC6F0 File Offset: 0x000DA8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51652, XrefRangeEnd = 51671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DescribeGuest(RectTransform rectTransform, [In] ref GuestGuardMapping mapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_DescribeGuest_Private_Void_RectTransform_byref_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x000DC748 File Offset: 0x000DA948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51671, XrefRangeEnd = 51679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBGUI(UIElementCluster uiElementCluster, [In] ref GuestGuardMapping mapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_SetBGUI_Private_Void_UIElementCluster_byref_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000DC7A0 File Offset: 0x000DA9A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 51706, RefRangeEnd = 51713, XrefRangeStart = 51679, XrefRangeEnd = 51706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeUIElements(UIElementCluster uiElementCluster, GuestGuardMapping mapping, bool showPrice, bool isNoMoneySkin, float progress, bool enableCurtain, bool enableCheckMark, Sprite outline)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showPrice;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNoMoneySkin;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableCurtain;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableCheckMark;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outline);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_InitializeUIElements_Private_Static_Void_UIElementCluster_GuestGuardMapping_Boolean_Boolean_Single_Boolean_Boolean_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000DC848 File Offset: 0x000DAA48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51743, RefRangeEnd = 51744, XrefRangeStart = 51713, XrefRangeEnd = 51743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPriceUI(UIElementCluster uiElementCluster, [In] ref GuestGuardMapping mapping, bool enable, bool isNoMoneySkin)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(mapping);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enable;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNoMoneySkin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_SetPriceUI_Private_Static_Void_UIElementCluster_byref_GuestGuardMapping_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x000DC8B0 File Offset: 0x000DAAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51744, XrefRangeEnd = 51756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetProgressUI(UIElementCluster uiElementCluster, float progress, bool enableCurtain)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableCurtain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_SetProgressUI_Private_Static_Void_UIElementCluster_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x000DC904 File Offset: 0x000DAB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51756, XrefRangeEnd = 51763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCheckUI(UIElementCluster uiElementCluster, bool enable)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_SetCheckUI_Private_Static_Void_UIElementCluster_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x000DC948 File Offset: 0x000DAB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51763, XrefRangeEnd = 51770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetOutlineUI(UIElementCluster uiElementCluster, Sprite outline)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outline);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_SetOutlineUI_Private_Static_Void_UIElementCluster_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x000DC990 File Offset: 0x000DAB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51770, XrefRangeEnd = 51782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000DC9CC File Offset: 0x000DABCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51782, XrefRangeEnd = 51804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_ChallengeCardSelectorPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000DCA08 File Offset: 0x000DAC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51804, XrefRangeEnd = 51812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__16_0(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.NativeMethodInfoPtr__OnPanelInitialize_b__16_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x0000BAFE File Offset: 0x00009CFE
		public DLC4_ChallengeCardSelectorPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x000DCA50 File Offset: 0x000DAC50
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x0000BB07 File Offset: 0x00009D07
		public unsafe static int s_Focus
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_s_Focus, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_s_Focus, (void*)(&value));
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x000DCA6C File Offset: 0x000DAC6C
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x0000BB15 File Offset: 0x00009D15
		public unsafe RectTransform m_CardField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_CardField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_CardField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x000DCA9C File Offset: 0x000DAC9C
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x0000BB34 File Offset: 0x00009D34
		public unsafe UIElementCluster m_CardPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_CardPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_CardPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x000DCACC File Offset: 0x000DACCC
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x0000BB53 File Offset: 0x00009D53
		public unsafe Sprite m_NormalBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_NormalBG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_NormalBG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x000DCAFC File Offset: 0x000DACFC
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x0000BB72 File Offset: 0x00009D72
		public unsafe Sprite m_SpecialBG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_SpecialBG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_SpecialBG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x000DCB2C File Offset: 0x000DAD2C
		// (set) Token: 0x06001274 RID: 4724 RVA: 0x0000BB91 File Offset: 0x00009D91
		public unsafe Sprite m_NormalOutline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_NormalOutline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_NormalOutline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x000DCB5C File Offset: 0x000DAD5C
		// (set) Token: 0x06001276 RID: 4726 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		public unsafe Sprite m_InvalidOutline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_InvalidOutline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_InvalidOutline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x000DCB8C File Offset: 0x000DAD8C
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x0000BBCF File Offset: 0x00009DCF
		public unsafe Color32 m_NormalTextColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_NormalTextColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_NormalTextColor)) = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x000DCBB4 File Offset: 0x000DADB4
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x0000BBEA File Offset: 0x00009DEA
		public unsafe Color32 m_SpecialTextColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_SpecialTextColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_SpecialTextColor)) = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x000DCBDC File Offset: 0x000DADDC
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x0000BC05 File Offset: 0x00009E05
		public unsafe DLC4_ChallengeCardSelectorPanel_Describer m_Describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_Describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_ChallengeCardSelectorPanel_Describer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_Describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x000DCC0C File Offset: 0x000DAE0C
		// (set) Token: 0x0600127E RID: 4734 RVA: 0x0000BC24 File Offset: 0x00009E24
		public unsafe RectTransform m_DescriberRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_DescriberRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_DescriberRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x000DCC3C File Offset: 0x000DAE3C
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x0000BC43 File Offset: 0x00009E43
		public unsafe List<GameObject> m_GameObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_GameObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_GameObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000DCC6C File Offset: 0x000DAE6C
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x0000BC62 File Offset: 0x00009E62
		public unsafe UILogicalGroupT<GuestGuardMapping> m_LogicalGroupT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_LogicalGroupT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<GuestGuardMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_LogicalGroupT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x000DCC9C File Offset: 0x000DAE9C
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x0000BC81 File Offset: 0x00009E81
		public unsafe Il2CppStructArray<Vector3> m_WorldCornerBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_WorldCornerBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_WorldCornerBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x000DCCCC File Offset: 0x000DAECC
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		public unsafe bool m_CurrentDescriberStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_CurrentDescriberStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.NativeFieldInfoPtr_m_CurrentDescriberStatus)) = value;
			}
		}

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeFieldInfoPtr_s_Focus;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeFieldInfoPtr_m_CardField;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeFieldInfoPtr_m_CardPrefab;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalBG;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialBG;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalOutline;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeFieldInfoPtr_m_InvalidOutline;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalTextColor;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialTextColor;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeFieldInfoPtr_m_Describer;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberRectTransform;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeFieldInfoPtr_m_GameObjects;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeFieldInfoPtr_m_LogicalGroupT;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldCornerBuffer;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentDescriberStatus;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_IChallengeCardSelectorPanelDB_0;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_GetTopLeftWorldCorner_Private_Vector3_RectTransform_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_RefreshElements_Private_Void_EnterGroupType_Boolean_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_InitializeCanUse_Private_Void_UIButtonSimple_UIElementCluster_GuestGuardMapping_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInShopLoading_Private_Void_UIButtonSimple_UIElementCluster_byref_GuestGuardMapping_Boolean_Single_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInShopCanBuy_Private_Void_UIButtonSimple_UIElementCluster_GuestGuardMapping_Boolean_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInShopOnField_Private_Void_UIButtonSimple_UIElementCluster_byref_GuestGuardMapping_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInShopOnFieldLoading_Private_Void_UIButtonSimple_UIElementCluster_byref_GuestGuardMapping_Single_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_DescribeGuest_Private_Void_RectTransform_byref_GuestGuardMapping_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_SetBGUI_Private_Void_UIElementCluster_byref_GuestGuardMapping_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUIElements_Private_Static_Void_UIElementCluster_GuestGuardMapping_Boolean_Boolean_Single_Boolean_Boolean_Sprite_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_SetPriceUI_Private_Static_Void_UIElementCluster_byref_GuestGuardMapping_Boolean_Boolean_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_SetProgressUI_Private_Static_Void_UIElementCluster_Single_Boolean_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_SetCheckUI_Private_Static_Void_UIElementCluster_Boolean_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_SetOutlineUI_Private_Static_Void_UIElementCluster_Sprite_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__16_0_Private_Void_CallbackContext_0;

		// Token: 0x020005B8 RID: 1464
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_ChallengeCardSelectorPanel+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x06008C6F RID: 35951 RVA: 0x002697C0 File Offset: 0x002679C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0>.NativeClassPtr);
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0.NativeFieldInfoPtr_resetAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0>.NativeClassPtr, "resetAnimator");
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0>.NativeClassPtr, 100666507);
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0.NativeMethodInfoPtr__RefreshElements_b__0_Internal_Void_UIElementCluster_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0>.NativeClassPtr, 100666508);
			}

			// Token: 0x06008C70 RID: 35952 RVA: 0x0026983C File Offset: 0x00267A3C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C71 RID: 35953 RVA: 0x00269878 File Offset: 0x00267A78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51399, XrefRangeEnd = 51489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshElements_b__0(UIElementCluster ui, GuestGuardMapping data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0.NativeMethodInfoPtr__RefreshElements_b__0_Internal_Void_UIElementCluster_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C72 RID: 35954 RVA: 0x0004B7DD File Offset: 0x000499DD
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F03 RID: 12035
			// (get) Token: 0x06008C73 RID: 35955 RVA: 0x002698D4 File Offset: 0x00267AD4
			// (set) Token: 0x06008C74 RID: 35956 RVA: 0x0004B7E6 File Offset: 0x000499E6
			public unsafe DLC4_ChallengeCardSelectorPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_ChallengeCardSelectorPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F04 RID: 12036
			// (get) Token: 0x06008C75 RID: 35957 RVA: 0x00269904 File Offset: 0x00267B04
			// (set) Token: 0x06008C76 RID: 35958 RVA: 0x0004B805 File Offset: 0x00049A05
			public unsafe bool resetAnimator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0.NativeFieldInfoPtr_resetAnimator);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0.NativeFieldInfoPtr_resetAnimator)) = value;
				}
			}

			// Token: 0x04005BE2 RID: 23522
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005BE3 RID: 23523
			private static readonly IntPtr NativeFieldInfoPtr_resetAnimator;

			// Token: 0x04005BE4 RID: 23524
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005BE5 RID: 23525
			private static readonly IntPtr NativeMethodInfoPtr__RefreshElements_b__0_Internal_Void_UIElementCluster_GuestGuardMapping_0;
		}

		// Token: 0x020005B9 RID: 1465
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_ChallengeCardSelectorPanel+<>c__DisplayClass18_1")]
		public sealed class __c__DisplayClass18_1 : Il2CppSystem.Object
		{
			// Token: 0x06008C77 RID: 35959 RVA: 0x0026992C File Offset: 0x00267B2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_1()
			{
				Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "<>c__DisplayClass18_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1>.NativeClassPtr);
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeFieldInfoPtr_ui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1>.NativeClassPtr, "ui");
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1>.NativeClassPtr, "data");
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1>.NativeClassPtr, "animator");
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1>.NativeClassPtr, 100666509);
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeMethodInfoPtr__RefreshElements_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1>.NativeClassPtr, 100666510);
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeMethodInfoPtr__RefreshElements_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1>.NativeClassPtr, 100666511);
			}

			// Token: 0x06008C78 RID: 35960 RVA: 0x002699E4 File Offset: 0x00267BE4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C79 RID: 35961 RVA: 0x00269A20 File Offset: 0x00267C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51489, XrefRangeEnd = 51517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshElements_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeMethodInfoPtr__RefreshElements_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C7A RID: 35962 RVA: 0x00269A54 File Offset: 0x00267C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51517, XrefRangeEnd = 51523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshElements_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeMethodInfoPtr__RefreshElements_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C7B RID: 35963 RVA: 0x0004B820 File Offset: 0x00049A20
			public __c__DisplayClass18_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F05 RID: 12037
			// (get) Token: 0x06008C7C RID: 35964 RVA: 0x00269A88 File Offset: 0x00267C88
			// (set) Token: 0x06008C7D RID: 35965 RVA: 0x0004B829 File Offset: 0x00049A29
			public unsafe UIElementCluster ui
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeFieldInfoPtr_ui);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeFieldInfoPtr_ui), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F06 RID: 12038
			// (get) Token: 0x06008C7E RID: 35966 RVA: 0x00269AB8 File Offset: 0x00267CB8
			// (set) Token: 0x06008C7F RID: 35967 RVA: 0x0004B848 File Offset: 0x00049A48
			public GuestGuardMapping data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeFieldInfoPtr_data);
					return new GuestGuardMapping(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F07 RID: 12039
			// (get) Token: 0x06008C80 RID: 35968 RVA: 0x00269AE8 File Offset: 0x00267CE8
			// (set) Token: 0x06008C81 RID: 35969 RVA: 0x0004B876 File Offset: 0x00049A76
			public unsafe Animator animator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeFieldInfoPtr_animator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F08 RID: 12040
			// (get) Token: 0x06008C82 RID: 35970 RVA: 0x00269B18 File Offset: 0x00267D18
			// (set) Token: 0x06008C83 RID: 35971 RVA: 0x0004B895 File Offset: 0x00049A95
			public unsafe DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0 field_Public___c__DisplayClass18_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass18_1.NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005BE6 RID: 23526
			private static readonly IntPtr NativeFieldInfoPtr_ui;

			// Token: 0x04005BE7 RID: 23527
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04005BE8 RID: 23528
			private static readonly IntPtr NativeFieldInfoPtr_animator;

			// Token: 0x04005BE9 RID: 23529
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass18_0_0;

			// Token: 0x04005BEA RID: 23530
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005BEB RID: 23531
			private static readonly IntPtr NativeMethodInfoPtr__RefreshElements_b__1_Internal_Void_0;

			// Token: 0x04005BEC RID: 23532
			private static readonly IntPtr NativeMethodInfoPtr__RefreshElements_b__2_Internal_Void_0;
		}

		// Token: 0x020005BA RID: 1466
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_ChallengeCardSelectorPanel+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x06008C84 RID: 35972 RVA: 0x00269B48 File Offset: 0x00267D48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0>.NativeClassPtr);
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0.NativeFieldInfoPtr_mapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0>.NativeClassPtr, "mapping");
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0>.NativeClassPtr, 100666512);
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0.NativeMethodInfoPtr__InitializeCanUse_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0>.NativeClassPtr, 100666513);
			}

			// Token: 0x06008C85 RID: 35973 RVA: 0x00269BC4 File Offset: 0x00267DC4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C86 RID: 35974 RVA: 0x00269C00 File Offset: 0x00267E00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51523, XrefRangeEnd = 51531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeCanUse_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0.NativeMethodInfoPtr__InitializeCanUse_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C87 RID: 35975 RVA: 0x0004B8B4 File Offset: 0x00049AB4
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F09 RID: 12041
			// (get) Token: 0x06008C88 RID: 35976 RVA: 0x00269C34 File Offset: 0x00267E34
			// (set) Token: 0x06008C89 RID: 35977 RVA: 0x0004B8BD File Offset: 0x00049ABD
			public unsafe DLC4_ChallengeCardSelectorPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_ChallengeCardSelectorPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F0A RID: 12042
			// (get) Token: 0x06008C8A RID: 35978 RVA: 0x00269C64 File Offset: 0x00267E64
			// (set) Token: 0x06008C8B RID: 35979 RVA: 0x0004B8DC File Offset: 0x00049ADC
			public GuestGuardMapping mapping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0.NativeFieldInfoPtr_mapping);
					return new GuestGuardMapping(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass19_0.NativeFieldInfoPtr_mapping), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005BED RID: 23533
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005BEE RID: 23534
			private static readonly IntPtr NativeFieldInfoPtr_mapping;

			// Token: 0x04005BEF RID: 23535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005BF0 RID: 23536
			private static readonly IntPtr NativeMethodInfoPtr__InitializeCanUse_b__0_Internal_Void_0;
		}

		// Token: 0x020005BB RID: 1467
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_ChallengeCardSelectorPanel+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x06008C8C RID: 35980 RVA: 0x00269C94 File Offset: 0x00267E94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0>.NativeClassPtr);
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0.NativeFieldInfoPtr_mapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0>.NativeClassPtr, "mapping");
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0>.NativeClassPtr, 100666514);
				DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeInShopCanBuy_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0>.NativeClassPtr, 100666515);
			}

			// Token: 0x06008C8D RID: 35981 RVA: 0x00269D10 File Offset: 0x00267F10
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C8E RID: 35982 RVA: 0x00269D4C File Offset: 0x00267F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51531, XrefRangeEnd = 51537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeInShopCanBuy_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0.NativeMethodInfoPtr__InitializeInShopCanBuy_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C8F RID: 35983 RVA: 0x0004B90A File Offset: 0x00049B0A
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F0B RID: 12043
			// (get) Token: 0x06008C90 RID: 35984 RVA: 0x00269D80 File Offset: 0x00267F80
			// (set) Token: 0x06008C91 RID: 35985 RVA: 0x0004B913 File Offset: 0x00049B13
			public unsafe DLC4_ChallengeCardSelectorPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_ChallengeCardSelectorPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F0C RID: 12044
			// (get) Token: 0x06008C92 RID: 35986 RVA: 0x00269DB0 File Offset: 0x00267FB0
			// (set) Token: 0x06008C93 RID: 35987 RVA: 0x0004B932 File Offset: 0x00049B32
			public GuestGuardMapping mapping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0.NativeFieldInfoPtr_mapping);
					return new GuestGuardMapping(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_ChallengeCardSelectorPanel.__c__DisplayClass21_0.NativeFieldInfoPtr_mapping), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005BF1 RID: 23537
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005BF2 RID: 23538
			private static readonly IntPtr NativeFieldInfoPtr_mapping;

			// Token: 0x04005BF3 RID: 23539
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005BF4 RID: 23540
			private static readonly IntPtr NativeMethodInfoPtr__InitializeInShopCanBuy_b__0_Internal_Void_0;
		}
	}
}
