using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000A9 RID: 169
	public class DLC4_BossBattleShopPanel : UIPanelExtern
	{
		// Token: 0x0600120E RID: 4622 RVA: 0x000DB1E8 File Offset: 0x000D93E8
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BossBattleShopPanel()
		{
			Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BossBattleShopPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr);
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_WholeFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_WholeFund");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_RemainingFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_RemainingFund");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ManualText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_ManualText");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_HPText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_HPText");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_CoolDownText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_CoolDownText");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_PCostText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_PCostText");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ConfirmBuy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_ConfirmBuy");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ItemStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_ItemStack");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_CartStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_CartStack");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ContainerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_ContainerParent");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_CartContainerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_CartContainerParent");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_DescribeCharacterCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_DescribeCharacterCluster");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ParentCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_ParentCanvasGroup");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_Offset");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_Rotation");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_AllCartInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_AllCartInstances");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_AllLetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_AllLetters");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_isHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "isHide");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_LetterGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "m_LetterGroup");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "<OpenContext>k__BackingField");
			DLC4_BossBattleShopPanel.NativeFieldInfoPtr__SelectedGuard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "<SelectedGuard>k__BackingField");
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_get_OpenContext_Private_get_DLC4BossBattleShopContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666447);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_DLC4BossBattleShopContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666448);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_get_SelectedGuard_Public_get_List_1_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666449);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_set_SelectedGuard_Private_set_Void_List_1_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666450);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666451);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_Buy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666452);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_Hide_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666453);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666454);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_GuestGuardMapping_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666455);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_OnElementSelected_Private_Void_GuestGuardMapping_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666456);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_DrawItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666457);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_ProcessCartElements_Private_Void_UIElementCluster_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666458);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666459);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666460);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666461);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr__OnPanelOpen_b__30_1_Private_Boolean_KeyValuePair_2_Int32_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666462);
			DLC4_BossBattleShopPanel.NativeMethodInfoPtr__ProcessCartElements_b__34_0_Private_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, 100666463);
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x000DB510 File Offset: 0x000D9710
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x000DB548 File Offset: 0x000D9748
		public unsafe DLC4_BossBattleShopPanel.DLC4BossBattleShopContext OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.NativeMethodInfoPtr_get_OpenContext_Private_get_DLC4BossBattleShopContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC4_BossBattleShopPanel.DLC4BossBattleShopContext(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51038, XrefRangeEnd = 51039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_DLC4BossBattleShopContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x000DB590 File Offset: 0x000D9790
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x000DB5D0 File Offset: 0x000D97D0
		public unsafe List<GuestGuardMapping> SelectedGuard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.NativeMethodInfoPtr_get_SelectedGuard_Public_get_List_1_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GuestGuardMapping>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.NativeMethodInfoPtr_set_SelectedGuard_Private_set_Void_List_1_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x000DB614 File Offset: 0x000D9814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51039, XrefRangeEnd = 51066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BossBattleShopPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x000DB650 File Offset: 0x000D9850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51066, XrefRangeEnd = 51067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Buy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.NativeMethodInfoPtr_Buy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x000DB684 File Offset: 0x000D9884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51067, XrefRangeEnd = 51069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.NativeMethodInfoPtr_Hide_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x000DB6CC File Offset: 0x000D98CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51069, XrefRangeEnd = 51179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BossBattleShopPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x000DB708 File Offset: 0x000D9908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51179, XrefRangeEnd = 51246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementEnabled(GuestGuardMapping guard, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(guard));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_GuestGuardMapping_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x000DB774 File Offset: 0x000D9974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51246, XrefRangeEnd = 51263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementSelected(GuestGuardMapping guard, UIElementCluster cluster, UIButtonSimple uiButtonSimple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(guard));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.NativeMethodInfoPtr_OnElementSelected_Private_Void_GuestGuardMapping_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x000DB7E0 File Offset: 0x000D99E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 51329, RefRangeEnd = 51331, XrefRangeStart = 51263, XrefRangeEnd = 51329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DrawItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.NativeMethodInfoPtr_DrawItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x000DB814 File Offset: 0x000D9A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51331, XrefRangeEnd = 51344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCartElements(UIElementCluster uiElement, GuestGuardMapping guard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElement);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(guard));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.NativeMethodInfoPtr_ProcessCartElements_Private_Void_UIElementCluster_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x000DB870 File Offset: 0x000D9A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51344, XrefRangeEnd = 51353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BossBattleShopPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x000DB8AC File Offset: 0x000D9AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51353, XrefRangeEnd = 51375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BossBattleShopPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x000DB8E8 File Offset: 0x000D9AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51375, XrefRangeEnd = 51391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BossBattleShopPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x000DB924 File Offset: 0x000D9B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51391, XrefRangeEnd = 51395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPanelOpen_b__30_1(KeyValuePair<int, GuestGuardMapping> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.NativeMethodInfoPtr__OnPanelOpen_b__30_1_Private_Boolean_KeyValuePair_2_Int32_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x000DB978 File Offset: 0x000D9B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51395, XrefRangeEnd = 51399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ProcessCartElements_b__34_0(RectTransform x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.NativeMethodInfoPtr__ProcessCartElements_b__34_0_Private_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0000B85E File Offset: 0x00009A5E
		public DLC4_BossBattleShopPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x000DB9BC File Offset: 0x000D9BBC
		// (set) Token: 0x06001222 RID: 4642 RVA: 0x0000B867 File Offset: 0x00009A67
		public unsafe TextMeshProUGUI m_WholeFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_WholeFund);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_WholeFund), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x000DB9EC File Offset: 0x000D9BEC
		// (set) Token: 0x06001224 RID: 4644 RVA: 0x0000B886 File Offset: 0x00009A86
		public unsafe TextMeshProUGUI m_RemainingFund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_RemainingFund);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_RemainingFund), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x000DBA1C File Offset: 0x000D9C1C
		// (set) Token: 0x06001226 RID: 4646 RVA: 0x0000B8A5 File Offset: 0x00009AA5
		public unsafe TextMeshProUGUI m_ManualText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ManualText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ManualText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x000DBA4C File Offset: 0x000D9C4C
		// (set) Token: 0x06001228 RID: 4648 RVA: 0x0000B8C4 File Offset: 0x00009AC4
		public unsafe TextMeshProUGUI m_HPText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_HPText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_HPText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x000DBA7C File Offset: 0x000D9C7C
		// (set) Token: 0x0600122A RID: 4650 RVA: 0x0000B8E3 File Offset: 0x00009AE3
		public unsafe TextMeshProUGUI m_CoolDownText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_CoolDownText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_CoolDownText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x000DBAAC File Offset: 0x000D9CAC
		// (set) Token: 0x0600122C RID: 4652 RVA: 0x0000B902 File Offset: 0x00009B02
		public unsafe TextMeshProUGUI m_PCostText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_PCostText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_PCostText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x000DBADC File Offset: 0x000D9CDC
		// (set) Token: 0x0600122E RID: 4654 RVA: 0x0000B921 File Offset: 0x00009B21
		public unsafe UIButtonSimple m_ConfirmBuy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ConfirmBuy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ConfirmBuy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x000DBB0C File Offset: 0x000D9D0C
		// (set) Token: 0x06001230 RID: 4656 RVA: 0x0000B940 File Offset: 0x00009B40
		public unsafe GameObject m_ItemStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ItemStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ItemStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x000DBB3C File Offset: 0x000D9D3C
		// (set) Token: 0x06001232 RID: 4658 RVA: 0x0000B95F File Offset: 0x00009B5F
		public unsafe GameObject m_CartStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_CartStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_CartStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x000DBB6C File Offset: 0x000D9D6C
		// (set) Token: 0x06001234 RID: 4660 RVA: 0x0000B97E File Offset: 0x00009B7E
		public unsafe GridLayoutGroup m_ContainerParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ContainerParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ContainerParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x000DBB9C File Offset: 0x000D9D9C
		// (set) Token: 0x06001236 RID: 4662 RVA: 0x0000B99D File Offset: 0x00009B9D
		public unsafe RectTransform m_CartContainerParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_CartContainerParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_CartContainerParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x000DBBCC File Offset: 0x000D9DCC
		// (set) Token: 0x06001238 RID: 4664 RVA: 0x0000B9BC File Offset: 0x00009BBC
		public unsafe UIElementCluster m_DescribeCharacterCluster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_DescribeCharacterCluster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_DescribeCharacterCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x000DBBFC File Offset: 0x000D9DFC
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x0000B9DB File Offset: 0x00009BDB
		public unsafe CanvasGroup m_ParentCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ParentCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_ParentCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x000DBC2C File Offset: 0x000D9E2C
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x0000B9FA File Offset: 0x00009BFA
		public unsafe int m_Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_Offset)) = value;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x000DBC54 File Offset: 0x000D9E54
		// (set) Token: 0x0600123E RID: 4670 RVA: 0x0000BA15 File Offset: 0x00009C15
		public unsafe float m_Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_Rotation)) = value;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x000DBC7C File Offset: 0x000D9E7C
		// (set) Token: 0x06001240 RID: 4672 RVA: 0x0000BA30 File Offset: 0x00009C30
		public unsafe List<GameObject> m_AllCartInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_AllCartInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_AllCartInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x000DBCAC File Offset: 0x000D9EAC
		// (set) Token: 0x06001242 RID: 4674 RVA: 0x0000BA4F File Offset: 0x00009C4F
		public unsafe List<GuestGuardMapping> m_AllLetters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_AllLetters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GuestGuardMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_AllLetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x000DBCDC File Offset: 0x000D9EDC
		// (set) Token: 0x06001244 RID: 4676 RVA: 0x0000BA6E File Offset: 0x00009C6E
		public unsafe bool isHide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_isHide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_isHide)) = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x000DBD04 File Offset: 0x000D9F04
		// (set) Token: 0x06001246 RID: 4678 RVA: 0x0000BA89 File Offset: 0x00009C89
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<GuestGuardMapping, UIElementCluster, UIButtonSimple> m_LetterGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_LetterGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<GuestGuardMapping, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr_m_LetterGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x000DBD34 File Offset: 0x000D9F34
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		public DLC4_BossBattleShopPanel.DLC4BossBattleShopContext _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new DLC4_BossBattleShopPanel.DLC4BossBattleShopContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x000DBD64 File Offset: 0x000D9F64
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x0000BAD6 File Offset: 0x00009CD6
		public unsafe List<GuestGuardMapping> _SelectedGuard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr__SelectedGuard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GuestGuardMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.NativeFieldInfoPtr__SelectedGuard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeFund;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeFieldInfoPtr_m_RemainingFund;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeFieldInfoPtr_m_ManualText;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeFieldInfoPtr_m_HPText;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeFieldInfoPtr_m_CoolDownText;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeFieldInfoPtr_m_PCostText;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeFieldInfoPtr_m_ConfirmBuy;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemStack;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeFieldInfoPtr_m_CartStack;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeFieldInfoPtr_m_ContainerParent;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeFieldInfoPtr_m_CartContainerParent;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeFieldInfoPtr_m_DescribeCharacterCluster;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentCanvasGroup;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeFieldInfoPtr_m_AllCartInstances;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeFieldInfoPtr_m_AllLetters;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeFieldInfoPtr_isHide;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeFieldInfoPtr_m_LetterGroup;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeFieldInfoPtr__SelectedGuard_k__BackingField;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_DLC4BossBattleShopContext_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_DLC4BossBattleShopContext_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedGuard_Public_get_List_1_GuestGuardMapping_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedGuard_Private_set_Void_List_1_GuestGuardMapping_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_Buy_Private_Void_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Private_Void_CallbackContext_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_OnElementEnabled_Private_Void_GuestGuardMapping_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_OnElementSelected_Private_Void_GuestGuardMapping_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_DrawItems_Private_Void_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCartElements_Private_Void_UIElementCluster_GuestGuardMapping_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__30_1_Private_Boolean_KeyValuePair_2_Int32_GuestGuardMapping_0;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr__ProcessCartElements_b__34_0_Private_Void_RectTransform_0;

		// Token: 0x020005B5 RID: 1461
		public sealed class DLC4BossBattleShopContext : ValueType
		{
			// Token: 0x06008C31 RID: 35889 RVA: 0x00268C90 File Offset: 0x00266E90
			// Note: this type is marked as 'beforefieldinit'.
			static DLC4BossBattleShopContext()
			{
				Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "DLC4BossBattleShopContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr);
				DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_AllMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr, "AllMappings");
				DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_RemainCoolDownSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr, "RemainCoolDownSecond");
				DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_RemainingPPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr, "RemainingPPoint");
				DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_EnableIdledHeroGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr, "EnableIdledHeroGuests");
				DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_HoldingLetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr, "HoldingLetters");
				DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_OnBuyGuards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr, "OnBuyGuards");
				DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_GuestGuardMapping_Dictionary_2_Int32_Single_Int32_HashSet_1_Int32_HashSet_1_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr, 100666464);
				DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeMethodInfoPtr_CleanAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr, 100666465);
			}

			// Token: 0x06008C32 RID: 35890 RVA: 0x00268D5C File Offset: 0x00266F5C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 51000, RefRangeEnd = 51001, XrefRangeStart = 50995, XrefRangeEnd = 51000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DLC4BossBattleShopContext(Dictionary<int, GuestGuardMapping> allMappings, Dictionary<int, float> remainCoolDownSecond, int remainingPPoint, HashSet<int> enableIdledHeroGuests, HashSet<int> holdingLetters, Action onBuyGuards) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(allMappings);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remainCoolDownSecond);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remainingPPoint;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enableIdledHeroGuests);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(holdingLetters);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuyGuards);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_GuestGuardMapping_Dictionary_2_Int32_Single_Int32_HashSet_1_Int32_HashSet_1_Int32_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C33 RID: 35891 RVA: 0x00268E08 File Offset: 0x00267008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51001, XrefRangeEnd = 51002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CleanAction()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeMethodInfoPtr_CleanAction_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C34 RID: 35892 RVA: 0x0004B597 File Offset: 0x00049797
			public DLC4BossBattleShopContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008C35 RID: 35893 RVA: 0x0004B5A0 File Offset: 0x000497A0
			public DLC4BossBattleShopContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.DLC4BossBattleShopContext>.NativeClassPtr))
			{
			}

			// Token: 0x17002EEF RID: 12015
			// (get) Token: 0x06008C36 RID: 35894 RVA: 0x00268E40 File Offset: 0x00267040
			// (set) Token: 0x06008C37 RID: 35895 RVA: 0x0004B5B2 File Offset: 0x000497B2
			public unsafe Dictionary<int, GuestGuardMapping> AllMappings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_AllMappings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GuestGuardMapping>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_AllMappings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EF0 RID: 12016
			// (get) Token: 0x06008C38 RID: 35896 RVA: 0x00268E70 File Offset: 0x00267070
			// (set) Token: 0x06008C39 RID: 35897 RVA: 0x0004B5D1 File Offset: 0x000497D1
			public unsafe Dictionary<int, float> RemainCoolDownSecond
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_RemainCoolDownSecond);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_RemainCoolDownSecond), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EF1 RID: 12017
			// (get) Token: 0x06008C3A RID: 35898 RVA: 0x00268EA0 File Offset: 0x002670A0
			// (set) Token: 0x06008C3B RID: 35899 RVA: 0x0004B5F0 File Offset: 0x000497F0
			public unsafe int RemainingPPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_RemainingPPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_RemainingPPoint)) = value;
				}
			}

			// Token: 0x17002EF2 RID: 12018
			// (get) Token: 0x06008C3C RID: 35900 RVA: 0x00268EC8 File Offset: 0x002670C8
			// (set) Token: 0x06008C3D RID: 35901 RVA: 0x0004B60B File Offset: 0x0004980B
			public unsafe HashSet<int> EnableIdledHeroGuests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_EnableIdledHeroGuests);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_EnableIdledHeroGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EF3 RID: 12019
			// (get) Token: 0x06008C3E RID: 35902 RVA: 0x00268EF8 File Offset: 0x002670F8
			// (set) Token: 0x06008C3F RID: 35903 RVA: 0x0004B62A File Offset: 0x0004982A
			public unsafe HashSet<int> HoldingLetters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_HoldingLetters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_HoldingLetters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EF4 RID: 12020
			// (get) Token: 0x06008C40 RID: 35904 RVA: 0x00268F28 File Offset: 0x00267128
			// (set) Token: 0x06008C41 RID: 35905 RVA: 0x0004B649 File Offset: 0x00049849
			public unsafe Action OnBuyGuards
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_OnBuyGuards);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.DLC4BossBattleShopContext.NativeFieldInfoPtr_OnBuyGuards), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005BBF RID: 23487
			private static readonly IntPtr NativeFieldInfoPtr_AllMappings;

			// Token: 0x04005BC0 RID: 23488
			private static readonly IntPtr NativeFieldInfoPtr_RemainCoolDownSecond;

			// Token: 0x04005BC1 RID: 23489
			private static readonly IntPtr NativeFieldInfoPtr_RemainingPPoint;

			// Token: 0x04005BC2 RID: 23490
			private static readonly IntPtr NativeFieldInfoPtr_EnableIdledHeroGuests;

			// Token: 0x04005BC3 RID: 23491
			private static readonly IntPtr NativeFieldInfoPtr_HoldingLetters;

			// Token: 0x04005BC4 RID: 23492
			private static readonly IntPtr NativeFieldInfoPtr_OnBuyGuards;

			// Token: 0x04005BC5 RID: 23493
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_GuestGuardMapping_Dictionary_2_Int32_Single_Int32_HashSet_1_Int32_HashSet_1_Int32_Action_0;

			// Token: 0x04005BC6 RID: 23494
			private static readonly IntPtr NativeMethodInfoPtr_CleanAction_Public_Void_0;
		}

		// Token: 0x020005B6 RID: 1462
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_BossBattleShopPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008C42 RID: 35906 RVA: 0x00268F58 File Offset: 0x00267158
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr);
				DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr, "<>9");
				DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr, "<>9__30_0");
				DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__30_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr, "<>9__30_2");
				DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__30_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr, "<>9__30_3");
				DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr, "<>9__33_0");
				DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr, "<>9__33_1");
				DLC4_BossBattleShopPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr, 100666467);
				DLC4_BossBattleShopPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__30_0_Internal_Boolean_KeyValuePair_2_Int32_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr, 100666468);
				DLC4_BossBattleShopPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__30_2_Internal_Boolean_KeyValuePair_2_Int32_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr, 100666469);
				DLC4_BossBattleShopPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__30_3_Internal_GuestGuardMapping_KeyValuePair_2_Int32_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr, 100666470);
				DLC4_BossBattleShopPanel.__c.NativeMethodInfoPtr__DrawItems_b__33_0_Internal_Int32_GuestGuardMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr, 100666471);
				DLC4_BossBattleShopPanel.__c.NativeMethodInfoPtr__DrawItems_b__33_1_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr, 100666472);
			}

			// Token: 0x06008C43 RID: 35907 RVA: 0x00269074 File Offset: 0x00267274
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C44 RID: 35908 RVA: 0x002690B0 File Offset: 0x002672B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51002, XrefRangeEnd = 51003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__30_0(KeyValuePair<int, GuestGuardMapping> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__30_0_Internal_Boolean_KeyValuePair_2_Int32_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008C45 RID: 35909 RVA: 0x00269104 File Offset: 0x00267304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51003, XrefRangeEnd = 51004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__30_2(KeyValuePair<int, GuestGuardMapping> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__30_2_Internal_Boolean_KeyValuePair_2_Int32_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008C46 RID: 35910 RVA: 0x00269158 File Offset: 0x00267358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51004, XrefRangeEnd = 51005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestGuardMapping _OnPanelOpen_b__30_3(KeyValuePair<int, GuestGuardMapping> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__30_3_Internal_GuestGuardMapping_KeyValuePair_2_Int32_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new GuestGuardMapping(pointer);
			}

			// Token: 0x06008C47 RID: 35911 RVA: 0x002691A8 File Offset: 0x002673A8
			[CallerCount(0)]
			public unsafe int _DrawItems_b__33_0(GuestGuardMapping x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.__c.NativeMethodInfoPtr__DrawItems_b__33_0_Internal_Int32_GuestGuardMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008C48 RID: 35912 RVA: 0x002691FC File Offset: 0x002673FC
			[CallerCount(0)]
			public unsafe int _DrawItems_b__33_1(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.__c.NativeMethodInfoPtr__DrawItems_b__33_1_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008C49 RID: 35913 RVA: 0x0004B668 File Offset: 0x00049868
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002EF5 RID: 12021
			// (get) Token: 0x06008C4A RID: 35914 RVA: 0x00269254 File Offset: 0x00267454
			// (set) Token: 0x06008C4B RID: 35915 RVA: 0x0004B671 File Offset: 0x00049871
			public unsafe static DLC4_BossBattleShopPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BossBattleShopPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EF6 RID: 12022
			// (get) Token: 0x06008C4C RID: 35916 RVA: 0x0026927C File Offset: 0x0026747C
			// (set) Token: 0x06008C4D RID: 35917 RVA: 0x0004B683 File Offset: 0x00049883
			public unsafe static Func<KeyValuePair<int, GuestGuardMapping>, bool> __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, GuestGuardMapping>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EF7 RID: 12023
			// (get) Token: 0x06008C4E RID: 35918 RVA: 0x002692A4 File Offset: 0x002674A4
			// (set) Token: 0x06008C4F RID: 35919 RVA: 0x0004B695 File Offset: 0x00049895
			public unsafe static Func<KeyValuePair<int, GuestGuardMapping>, bool> __9__30_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__30_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, GuestGuardMapping>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__30_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EF8 RID: 12024
			// (get) Token: 0x06008C50 RID: 35920 RVA: 0x002692CC File Offset: 0x002674CC
			// (set) Token: 0x06008C51 RID: 35921 RVA: 0x0004B6A7 File Offset: 0x000498A7
			public unsafe static Func<KeyValuePair<int, GuestGuardMapping>, GuestGuardMapping> __9__30_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__30_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, GuestGuardMapping>, GuestGuardMapping>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__30_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EF9 RID: 12025
			// (get) Token: 0x06008C52 RID: 35922 RVA: 0x002692F4 File Offset: 0x002674F4
			// (set) Token: 0x06008C53 RID: 35923 RVA: 0x0004B6B9 File Offset: 0x000498B9
			public unsafe static Func<GuestGuardMapping, int> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGuardMapping, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EFA RID: 12026
			// (get) Token: 0x06008C54 RID: 35924 RVA: 0x0026931C File Offset: 0x0026751C
			// (set) Token: 0x06008C55 RID: 35925 RVA: 0x0004B6CB File Offset: 0x000498CB
			public unsafe static Func<int, int, int> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_BossBattleShopPanel.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005BC7 RID: 23495
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005BC8 RID: 23496
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x04005BC9 RID: 23497
			private static readonly IntPtr NativeFieldInfoPtr___9__30_2;

			// Token: 0x04005BCA RID: 23498
			private static readonly IntPtr NativeFieldInfoPtr___9__30_3;

			// Token: 0x04005BCB RID: 23499
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x04005BCC RID: 23500
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x04005BCD RID: 23501
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005BCE RID: 23502
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__30_0_Internal_Boolean_KeyValuePair_2_Int32_GuestGuardMapping_0;

			// Token: 0x04005BCF RID: 23503
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__30_2_Internal_Boolean_KeyValuePair_2_Int32_GuestGuardMapping_0;

			// Token: 0x04005BD0 RID: 23504
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__30_3_Internal_GuestGuardMapping_KeyValuePair_2_Int32_GuestGuardMapping_0;

			// Token: 0x04005BD1 RID: 23505
			private static readonly IntPtr NativeMethodInfoPtr__DrawItems_b__33_0_Internal_Int32_GuestGuardMapping_0;

			// Token: 0x04005BD2 RID: 23506
			private static readonly IntPtr NativeMethodInfoPtr__DrawItems_b__33_1_Internal_Int32_Int32_Int32_0;
		}

		// Token: 0x020005B7 RID: 1463
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_BossBattleShopPanel+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x06008C56 RID: 35926 RVA: 0x00269344 File Offset: 0x00267544
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_BossBattleShopPanel>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr);
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_hasSeated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, "hasSeated");
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_canChoose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, "canChoose");
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_remainingCoolDownPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, "remainingCoolDownPercentage");
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_hasSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, "hasSelected");
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_thisGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, "thisGuard");
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_thisCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, "thisCluster");
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, "<>9__5");
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, 100666473);
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, 100666474);
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, 100666475);
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, 100666476);
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementEnabled_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, 100666477);
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementEnabled_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, 100666478);
				DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementEnabled_b__5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr, 100666479);
			}

			// Token: 0x06008C57 RID: 35927 RVA: 0x0026949C File Offset: 0x0026769C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BossBattleShopPanel.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C58 RID: 35928 RVA: 0x002694D8 File Offset: 0x002676D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C59 RID: 35929 RVA: 0x0026951C File Offset: 0x0026771C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51005, XrefRangeEnd = 51007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C5A RID: 35930 RVA: 0x00269560 File Offset: 0x00267760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51007, XrefRangeEnd = 51009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C5B RID: 35931 RVA: 0x002695A4 File Offset: 0x002677A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51009, XrefRangeEnd = 51011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementEnabled_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C5C RID: 35932 RVA: 0x002695E8 File Offset: 0x002677E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51011, XrefRangeEnd = 51033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementEnabled_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C5D RID: 35933 RVA: 0x0026961C File Offset: 0x0026781C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51033, XrefRangeEnd = 51038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__5(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeMethodInfoPtr__OnElementEnabled_b__5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C5E RID: 35934 RVA: 0x0004B6DD File Offset: 0x000498DD
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002EFB RID: 12027
			// (get) Token: 0x06008C5F RID: 35935 RVA: 0x00269660 File Offset: 0x00267860
			// (set) Token: 0x06008C60 RID: 35936 RVA: 0x0004B6E6 File Offset: 0x000498E6
			public unsafe bool hasSeated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_hasSeated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_hasSeated)) = value;
				}
			}

			// Token: 0x17002EFC RID: 12028
			// (get) Token: 0x06008C61 RID: 35937 RVA: 0x00269688 File Offset: 0x00267888
			// (set) Token: 0x06008C62 RID: 35938 RVA: 0x0004B701 File Offset: 0x00049901
			public unsafe bool canChoose
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_canChoose);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_canChoose)) = value;
				}
			}

			// Token: 0x17002EFD RID: 12029
			// (get) Token: 0x06008C63 RID: 35939 RVA: 0x002696B0 File Offset: 0x002678B0
			// (set) Token: 0x06008C64 RID: 35940 RVA: 0x0004B71C File Offset: 0x0004991C
			public unsafe float remainingCoolDownPercentage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_remainingCoolDownPercentage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_remainingCoolDownPercentage)) = value;
				}
			}

			// Token: 0x17002EFE RID: 12030
			// (get) Token: 0x06008C65 RID: 35941 RVA: 0x002696D8 File Offset: 0x002678D8
			// (set) Token: 0x06008C66 RID: 35942 RVA: 0x0004B737 File Offset: 0x00049937
			public unsafe bool hasSelected
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_hasSelected);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_hasSelected)) = value;
				}
			}

			// Token: 0x17002EFF RID: 12031
			// (get) Token: 0x06008C67 RID: 35943 RVA: 0x00269700 File Offset: 0x00267900
			// (set) Token: 0x06008C68 RID: 35944 RVA: 0x0004B752 File Offset: 0x00049952
			public unsafe DLC4_BossBattleShopPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BossBattleShopPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F00 RID: 12032
			// (get) Token: 0x06008C69 RID: 35945 RVA: 0x00269730 File Offset: 0x00267930
			// (set) Token: 0x06008C6A RID: 35946 RVA: 0x0004B771 File Offset: 0x00049971
			public GuestGuardMapping thisGuard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_thisGuard);
					return new GuestGuardMapping(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_thisGuard), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GuestGuardMapping>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F01 RID: 12033
			// (get) Token: 0x06008C6B RID: 35947 RVA: 0x00269760 File Offset: 0x00267960
			// (set) Token: 0x06008C6C RID: 35948 RVA: 0x0004B79F File Offset: 0x0004999F
			public unsafe UIElementCluster thisCluster
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_thisCluster);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr_thisCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F02 RID: 12034
			// (get) Token: 0x06008C6D RID: 35949 RVA: 0x00269790 File Offset: 0x00267990
			// (set) Token: 0x06008C6E RID: 35950 RVA: 0x0004B7BE File Offset: 0x000499BE
			public unsafe Action<Image> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattleShopPanel.__c__DisplayClass31_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005BD3 RID: 23507
			private static readonly IntPtr NativeFieldInfoPtr_hasSeated;

			// Token: 0x04005BD4 RID: 23508
			private static readonly IntPtr NativeFieldInfoPtr_canChoose;

			// Token: 0x04005BD5 RID: 23509
			private static readonly IntPtr NativeFieldInfoPtr_remainingCoolDownPercentage;

			// Token: 0x04005BD6 RID: 23510
			private static readonly IntPtr NativeFieldInfoPtr_hasSelected;

			// Token: 0x04005BD7 RID: 23511
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005BD8 RID: 23512
			private static readonly IntPtr NativeFieldInfoPtr_thisGuard;

			// Token: 0x04005BD9 RID: 23513
			private static readonly IntPtr NativeFieldInfoPtr_thisCluster;

			// Token: 0x04005BDA RID: 23514
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x04005BDB RID: 23515
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005BDC RID: 23516
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_Image_0;

			// Token: 0x04005BDD RID: 23517
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_Image_0;

			// Token: 0x04005BDE RID: 23518
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_Image_0;

			// Token: 0x04005BDF RID: 23519
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__3_Internal_Void_Image_0;

			// Token: 0x04005BE0 RID: 23520
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__4_Internal_Void_0;

			// Token: 0x04005BE1 RID: 23521
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__5_Internal_Void_Image_0;
		}
	}
}
