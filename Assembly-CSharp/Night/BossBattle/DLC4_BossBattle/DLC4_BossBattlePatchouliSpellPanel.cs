using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.CoreLanguage;
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
	// Token: 0x020000A8 RID: 168
	public class DLC4_BossBattlePatchouliSpellPanel : UIPanelExtern
	{
		// Token: 0x060011DF RID: 4575 RVA: 0x000DA8D8 File Offset: 0x000D8AD8
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_BossBattlePatchouliSpellPanel()
		{
			Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DLC4_BossBattlePatchouliSpellPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr);
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_ItemStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "m_ItemStack");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_ContainerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "m_ContainerParent");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RemainingP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "m_RemainingP");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RemainingPanelRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "m_RemainingPanelRect");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_ParentCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "m_ParentCanvas");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RefreshButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "m_RefreshButton");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RefreshText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "m_RefreshText");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RefreshCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "m_RefreshCanvasGroup");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_coolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "coolDown");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_isHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "isHide");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_AllInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "m_AllInstances");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_UILogicalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "m_UILogicalGroup");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_remainingPPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "remainingPPoint");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "<OpenContext>k__BackingField");
			DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr__InitializeContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "<InitializeContext>k__BackingField");
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_get_OpenContext_Private_get_DLC4BossBattlePatchouliSpellContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666423);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_DLC4BossBattlePatchouliSpellContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666424);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_get_InitializeContext_Private_get_DLC4BossBattlePatchouliSpellInitializeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666425);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_set_InitializeContext_Public_set_Void_DLC4BossBattlePatchouliSpellInitializeContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666426);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666427);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_ShouldEnableSpellElement_Private_Boolean_PatchouliMagicSpellCardIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666428);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_Hide_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666429);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666430);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_Refresh_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666431);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_RefreshFunc_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666432);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_UpdateVisual_Private_Void_HashSet_1_PatchouliMagicSpellCardIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666433);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_ProcessElements_Private_Void_UIElementCluster_PatchouliMagicSpellCardIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666434);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666435);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666436);
			DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, 100666437);
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x000DAB60 File Offset: 0x000D8D60
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x000DAB98 File Offset: 0x000D8D98
		public unsafe DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_get_OpenContext_Private_get_DLC4BossBattlePatchouliSpellContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50784, XrefRangeEnd = 50785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_DLC4BossBattlePatchouliSpellContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x000DABE0 File Offset: 0x000D8DE0
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x000DAC18 File Offset: 0x000D8E18
		public unsafe DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext InitializeContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_get_InitializeContext_Private_get_DLC4BossBattlePatchouliSpellInitializeContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50785, XrefRangeEnd = 50786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_set_InitializeContext_Public_set_Void_DLC4BossBattlePatchouliSpellInitializeContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x000DAC60 File Offset: 0x000D8E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50786, XrefRangeEnd = 50828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x000DAC9C File Offset: 0x000D8E9C
		[CallerCount(0)]
		public unsafe bool ShouldEnableSpellElement(PatchouliMagicSpellCardIndex arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref arg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_ShouldEnableSpellElement_Private_Boolean_PatchouliMagicSpellCardIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x000DACE8 File Offset: 0x000D8EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50828, XrefRangeEnd = 50830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_Hide_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x000DAD30 File Offset: 0x000D8F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50830, XrefRangeEnd = 50838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x000DAD6C File Offset: 0x000D8F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50838, XrefRangeEnd = 50842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_Refresh_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x000DADB4 File Offset: 0x000D8FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50842, XrefRangeEnd = 50843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshFunc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_RefreshFunc_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x000DADE8 File Offset: 0x000D8FE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 50887, RefRangeEnd = 50890, XrefRangeStart = 50843, XrefRangeEnd = 50887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual(HashSet<PatchouliMagicSpellCardIndex> cards)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cards);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_UpdateVisual_Private_Void_HashSet_1_PatchouliMagicSpellCardIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000DAE2C File Offset: 0x000D902C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50890, XrefRangeEnd = 50966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessElements(UIElementCluster uiElement, PatchouliMagicSpellCardIndex card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElement);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref card;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_ProcessElements_Private_Void_UIElementCluster_PatchouliMagicSpellCardIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x000DAE7C File Offset: 0x000D907C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50966, XrefRangeEnd = 50975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x000DAEB8 File Offset: 0x000D90B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50975, XrefRangeEnd = 50986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x000DAEF4 File Offset: 0x000D90F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50986, XrefRangeEnd = 50995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_BossBattlePatchouliSpellPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0000B672 File Offset: 0x00009872
		public DLC4_BossBattlePatchouliSpellPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x000DAF30 File Offset: 0x000D9130
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x0000B67B File Offset: 0x0000987B
		public unsafe GameObject m_ItemStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_ItemStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_ItemStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x000DAF60 File Offset: 0x000D9160
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x0000B69A File Offset: 0x0000989A
		public unsafe RectTransform m_ContainerParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_ContainerParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_ContainerParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x000DAF90 File Offset: 0x000D9190
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0000B6B9 File Offset: 0x000098B9
		public unsafe TextMeshProUGUI m_RemainingP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RemainingP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RemainingP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x000DAFC0 File Offset: 0x000D91C0
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x0000B6D8 File Offset: 0x000098D8
		public unsafe RectTransform m_RemainingPanelRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RemainingPanelRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RemainingPanelRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x000DAFF0 File Offset: 0x000D91F0
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x0000B6F7 File Offset: 0x000098F7
		public unsafe CanvasGroup m_ParentCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_ParentCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_ParentCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x000DB020 File Offset: 0x000D9220
		// (set) Token: 0x060011FB RID: 4603 RVA: 0x0000B716 File Offset: 0x00009916
		public unsafe UIButtonSimple m_RefreshButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RefreshButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RefreshButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x000DB050 File Offset: 0x000D9250
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x0000B735 File Offset: 0x00009935
		public unsafe TextMeshProUGUI m_RefreshText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RefreshText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RefreshText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x000DB080 File Offset: 0x000D9280
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x0000B754 File Offset: 0x00009954
		public unsafe CanvasGroup m_RefreshCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RefreshCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_RefreshCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x000DB0B0 File Offset: 0x000D92B0
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x0000B773 File Offset: 0x00009973
		public unsafe float coolDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_coolDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_coolDown)) = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x000DB0D8 File Offset: 0x000D92D8
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x0000B78E File Offset: 0x0000998E
		public unsafe bool isHide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_isHide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_isHide)) = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x000DB100 File Offset: 0x000D9300
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x0000B7A9 File Offset: 0x000099A9
		public unsafe List<GameObject> m_AllInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_AllInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_AllInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x000DB130 File Offset: 0x000D9330
		// (set) Token: 0x06001207 RID: 4615 RVA: 0x0000B7C8 File Offset: 0x000099C8
		public unsafe UILogicalGroupT<PatchouliMagicSpellCardIndex> m_UILogicalGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_UILogicalGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<PatchouliMagicSpellCardIndex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_m_UILogicalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x000DB160 File Offset: 0x000D9360
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x0000B7E7 File Offset: 0x000099E7
		public unsafe int remainingPPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_remainingPPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr_remainingPPoint)) = value;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x000DB188 File Offset: 0x000D9388
		// (set) Token: 0x0600120B RID: 4619 RVA: 0x0000B802 File Offset: 0x00009A02
		public DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x000DB1B8 File Offset: 0x000D93B8
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x0000B830 File Offset: 0x00009A30
		public DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext _InitializeContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr__InitializeContext_k__BackingField);
				return new DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.NativeFieldInfoPtr__InitializeContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemStack;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeFieldInfoPtr_m_ContainerParent;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeFieldInfoPtr_m_RemainingP;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeFieldInfoPtr_m_RemainingPanelRect;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentCanvas;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshButton;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshText;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshCanvasGroup;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeFieldInfoPtr_coolDown;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeFieldInfoPtr_isHide;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeFieldInfoPtr_m_AllInstances;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeFieldInfoPtr_m_UILogicalGroup;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeFieldInfoPtr_remainingPPoint;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeFieldInfoPtr__InitializeContext_k__BackingField;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_DLC4BossBattlePatchouliSpellContext_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_DLC4BossBattlePatchouliSpellContext_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_get_InitializeContext_Private_get_DLC4BossBattlePatchouliSpellInitializeContext_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_set_InitializeContext_Public_set_Void_DLC4BossBattlePatchouliSpellInitializeContext_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_ShouldEnableSpellElement_Private_Boolean_PatchouliMagicSpellCardIndex_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Private_Void_CallbackContext_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_CallbackContext_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_RefreshFunc_Private_Void_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_HashSet_1_PatchouliMagicSpellCardIndex_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElements_Private_Void_UIElementCluster_PatchouliMagicSpellCardIndex_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005B2 RID: 1458
		public sealed class DLC4BossBattlePatchouliSpellContext : ValueType
		{
			// Token: 0x06008C04 RID: 35844 RVA: 0x002684E8 File Offset: 0x002666E8
			// Note: this type is marked as 'beforefieldinit'.
			static DLC4BossBattlePatchouliSpellContext()
			{
				Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "DLC4BossBattlePatchouliSpellContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext>.NativeClassPtr);
				DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext.NativeFieldInfoPtr_EnableIdledSpellCardsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext>.NativeClassPtr, "EnableIdledSpellCardsIndex");
				DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext.NativeFieldInfoPtr_RemainingCoolTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext>.NativeClassPtr, "RemainingCoolTime");
				DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext.NativeFieldInfoPtr_CanRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext>.NativeClassPtr, "CanRefresh");
				DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext.NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_PatchouliMagicSpellCardIndex_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext>.NativeClassPtr, 100666438);
			}

			// Token: 0x06008C05 RID: 35845 RVA: 0x00268564 File Offset: 0x00266764
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 50765, RefRangeEnd = 50766, XrefRangeStart = 50764, XrefRangeEnd = 50765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DLC4BossBattlePatchouliSpellContext(HashSet<PatchouliMagicSpellCardIndex> enableIdledSpellCardsIndex, float remainingCoolTime, bool canRefresh) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enableIdledSpellCardsIndex);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remainingCoolTime;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canRefresh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext.NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_PatchouliMagicSpellCardIndex_Single_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C06 RID: 35846 RVA: 0x0004B3BE File Offset: 0x000495BE
			public DLC4BossBattlePatchouliSpellContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008C07 RID: 35847 RVA: 0x0004B3C7 File Offset: 0x000495C7
			public DLC4BossBattlePatchouliSpellContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext>.NativeClassPtr))
			{
			}

			// Token: 0x17002EE1 RID: 12001
			// (get) Token: 0x06008C08 RID: 35848 RVA: 0x002685D0 File Offset: 0x002667D0
			// (set) Token: 0x06008C09 RID: 35849 RVA: 0x0004B3D9 File Offset: 0x000495D9
			public unsafe HashSet<PatchouliMagicSpellCardIndex> EnableIdledSpellCardsIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext.NativeFieldInfoPtr_EnableIdledSpellCardsIndex);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<PatchouliMagicSpellCardIndex>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext.NativeFieldInfoPtr_EnableIdledSpellCardsIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EE2 RID: 12002
			// (get) Token: 0x06008C0A RID: 35850 RVA: 0x00268600 File Offset: 0x00266800
			// (set) Token: 0x06008C0B RID: 35851 RVA: 0x0004B3F8 File Offset: 0x000495F8
			public unsafe float RemainingCoolTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext.NativeFieldInfoPtr_RemainingCoolTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext.NativeFieldInfoPtr_RemainingCoolTime)) = value;
				}
			}

			// Token: 0x17002EE3 RID: 12003
			// (get) Token: 0x06008C0C RID: 35852 RVA: 0x00268628 File Offset: 0x00266828
			// (set) Token: 0x06008C0D RID: 35853 RVA: 0x0004B413 File Offset: 0x00049613
			public unsafe bool CanRefresh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext.NativeFieldInfoPtr_CanRefresh);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellContext.NativeFieldInfoPtr_CanRefresh)) = value;
				}
			}

			// Token: 0x04005BA8 RID: 23464
			private static readonly IntPtr NativeFieldInfoPtr_EnableIdledSpellCardsIndex;

			// Token: 0x04005BA9 RID: 23465
			private static readonly IntPtr NativeFieldInfoPtr_RemainingCoolTime;

			// Token: 0x04005BAA RID: 23466
			private static readonly IntPtr NativeFieldInfoPtr_CanRefresh;

			// Token: 0x04005BAB RID: 23467
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_PatchouliMagicSpellCardIndex_Single_Boolean_0;
		}

		// Token: 0x020005B3 RID: 1459
		public sealed class DLC4BossBattlePatchouliSpellInitializeContext : ValueType
		{
			// Token: 0x06008C0E RID: 35854 RVA: 0x00268650 File Offset: 0x00266850
			// Note: this type is marked as 'beforefieldinit'.
			static DLC4BossBattlePatchouliSpellInitializeContext()
			{
				Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "DLC4BossBattlePatchouliSpellInitializeContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr);
				DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_GetSpellText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr, "GetSpellText");
				DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_CoolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr, "CoolDown");
				DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_Cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr, "Cost");
				DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_OnBuyCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr, "OnBuyCallback");
				DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_ReplaceDescriptionMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr, "ReplaceDescriptionMethod");
				DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_OnRefreshCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr, "OnRefreshCallback");
				DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_CurrentPPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr, "CurrentPPoint");
				DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeMethodInfoPtr__ctor_Public_Void_Func_2_PatchouliMagicSpellCardIndex_LanguageBase_Single_Int32_Action_2_Int32_PatchouliMagicSpellCardIndex_Func_3_PatchouliMagicSpellCardIndex_String_String_Func_1_HashSet_1_PatchouliMagicSpellCardIndex_Func_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr, 100666439);
			}

			// Token: 0x06008C0F RID: 35855 RVA: 0x0026871C File Offset: 0x0026691C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 50771, RefRangeEnd = 50772, XrefRangeStart = 50766, XrefRangeEnd = 50771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DLC4BossBattlePatchouliSpellInitializeContext(Func<PatchouliMagicSpellCardIndex, LanguageBase> getSpellText, float coolDown, int cost, Action<int, PatchouliMagicSpellCardIndex> onBuyCallback, Func<PatchouliMagicSpellCardIndex, string, string> replaceDescriptionMethod, Func<HashSet<PatchouliMagicSpellCardIndex>> onRefreshCallback, Func<int> currentPPoint) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(getSpellText);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coolDown;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cost;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBuyCallback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replaceDescriptionMethod);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRefreshCallback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentPPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeMethodInfoPtr__ctor_Public_Void_Func_2_PatchouliMagicSpellCardIndex_LanguageBase_Single_Int32_Action_2_Int32_PatchouliMagicSpellCardIndex_Func_3_PatchouliMagicSpellCardIndex_String_String_Func_1_HashSet_1_PatchouliMagicSpellCardIndex_Func_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C10 RID: 35856 RVA: 0x0004B42E File Offset: 0x0004962E
			public DLC4BossBattlePatchouliSpellInitializeContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008C11 RID: 35857 RVA: 0x0004B437 File Offset: 0x00049637
			public DLC4BossBattlePatchouliSpellInitializeContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext>.NativeClassPtr))
			{
			}

			// Token: 0x17002EE4 RID: 12004
			// (get) Token: 0x06008C12 RID: 35858 RVA: 0x002687D4 File Offset: 0x002669D4
			// (set) Token: 0x06008C13 RID: 35859 RVA: 0x0004B449 File Offset: 0x00049649
			public unsafe Func<PatchouliMagicSpellCardIndex, LanguageBase> GetSpellText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_GetSpellText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PatchouliMagicSpellCardIndex, LanguageBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_GetSpellText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EE5 RID: 12005
			// (get) Token: 0x06008C14 RID: 35860 RVA: 0x00268804 File Offset: 0x00266A04
			// (set) Token: 0x06008C15 RID: 35861 RVA: 0x0004B468 File Offset: 0x00049668
			public unsafe float CoolDown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_CoolDown);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_CoolDown)) = value;
				}
			}

			// Token: 0x17002EE6 RID: 12006
			// (get) Token: 0x06008C16 RID: 35862 RVA: 0x0026882C File Offset: 0x00266A2C
			// (set) Token: 0x06008C17 RID: 35863 RVA: 0x0004B483 File Offset: 0x00049683
			public unsafe int Cost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_Cost);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_Cost)) = value;
				}
			}

			// Token: 0x17002EE7 RID: 12007
			// (get) Token: 0x06008C18 RID: 35864 RVA: 0x00268854 File Offset: 0x00266A54
			// (set) Token: 0x06008C19 RID: 35865 RVA: 0x0004B49E File Offset: 0x0004969E
			public unsafe Action<int, PatchouliMagicSpellCardIndex> OnBuyCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_OnBuyCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, PatchouliMagicSpellCardIndex>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_OnBuyCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EE8 RID: 12008
			// (get) Token: 0x06008C1A RID: 35866 RVA: 0x00268884 File Offset: 0x00266A84
			// (set) Token: 0x06008C1B RID: 35867 RVA: 0x0004B4BD File Offset: 0x000496BD
			public unsafe Func<PatchouliMagicSpellCardIndex, string, string> ReplaceDescriptionMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_ReplaceDescriptionMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PatchouliMagicSpellCardIndex, string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_ReplaceDescriptionMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EE9 RID: 12009
			// (get) Token: 0x06008C1C RID: 35868 RVA: 0x002688B4 File Offset: 0x00266AB4
			// (set) Token: 0x06008C1D RID: 35869 RVA: 0x0004B4DC File Offset: 0x000496DC
			public unsafe Func<HashSet<PatchouliMagicSpellCardIndex>> OnRefreshCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_OnRefreshCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<HashSet<PatchouliMagicSpellCardIndex>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_OnRefreshCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EEA RID: 12010
			// (get) Token: 0x06008C1E RID: 35870 RVA: 0x002688E4 File Offset: 0x00266AE4
			// (set) Token: 0x06008C1F RID: 35871 RVA: 0x0004B4FB File Offset: 0x000496FB
			public unsafe Func<int> CurrentPPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_CurrentPPoint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.DLC4BossBattlePatchouliSpellInitializeContext.NativeFieldInfoPtr_CurrentPPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005BAC RID: 23468
			private static readonly IntPtr NativeFieldInfoPtr_GetSpellText;

			// Token: 0x04005BAD RID: 23469
			private static readonly IntPtr NativeFieldInfoPtr_CoolDown;

			// Token: 0x04005BAE RID: 23470
			private static readonly IntPtr NativeFieldInfoPtr_Cost;

			// Token: 0x04005BAF RID: 23471
			private static readonly IntPtr NativeFieldInfoPtr_OnBuyCallback;

			// Token: 0x04005BB0 RID: 23472
			private static readonly IntPtr NativeFieldInfoPtr_ReplaceDescriptionMethod;

			// Token: 0x04005BB1 RID: 23473
			private static readonly IntPtr NativeFieldInfoPtr_OnRefreshCallback;

			// Token: 0x04005BB2 RID: 23474
			private static readonly IntPtr NativeFieldInfoPtr_CurrentPPoint;

			// Token: 0x04005BB3 RID: 23475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_PatchouliMagicSpellCardIndex_LanguageBase_Single_Int32_Action_2_Int32_PatchouliMagicSpellCardIndex_Func_3_PatchouliMagicSpellCardIndex_String_String_Func_1_HashSet_1_PatchouliMagicSpellCardIndex_Func_1_Int32_0;
		}

		// Token: 0x020005B4 RID: 1460
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DLC4_BossBattlePatchouliSpellPanel+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x06008C20 RID: 35872 RVA: 0x00268914 File Offset: 0x00266B14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr);
				DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_couldNotChoose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr, "couldNotChoose");
				DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr, "interactable");
				DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_thisCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr, "thisCard");
				DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr, 100666440);
				DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ProcessElements_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr, 100666441);
				DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ProcessElements_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr, 100666442);
				DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ProcessElements_b__2_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr, 100666443);
				DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ProcessElements_b__3_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr, 100666444);
				DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ProcessElements_b__4_Internal_Void_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr, 100666445);
				DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ProcessElements_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr, 100666446);
			}

			// Token: 0x06008C21 RID: 35873 RVA: 0x00268A1C File Offset: 0x00266C1C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C22 RID: 35874 RVA: 0x00268A58 File Offset: 0x00266C58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50772, XrefRangeEnd = 50774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessElements_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ProcessElements_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C23 RID: 35875 RVA: 0x00268A9C File Offset: 0x00266C9C
			[CallerCount(0)]
			public unsafe void _ProcessElements_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ProcessElements_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C24 RID: 35876 RVA: 0x00268AE0 File Offset: 0x00266CE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50774, XrefRangeEnd = 50778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessElements_b__2(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ProcessElements_b__2_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C25 RID: 35877 RVA: 0x00268B24 File Offset: 0x00266D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50778, XrefRangeEnd = 50782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessElements_b__3(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ProcessElements_b__3_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C26 RID: 35878 RVA: 0x00268B68 File Offset: 0x00266D68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessElements_b__4(UIButtonSimple x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ProcessElements_b__4_Internal_Void_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C27 RID: 35879 RVA: 0x00268BAC File Offset: 0x00266DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50782, XrefRangeEnd = 50784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessElements_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeMethodInfoPtr__ProcessElements_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008C28 RID: 35880 RVA: 0x0004B51A File Offset: 0x0004971A
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002EEB RID: 12011
			// (get) Token: 0x06008C29 RID: 35881 RVA: 0x00268BE0 File Offset: 0x00266DE0
			// (set) Token: 0x06008C2A RID: 35882 RVA: 0x0004B523 File Offset: 0x00049723
			public unsafe DLC4_BossBattlePatchouliSpellPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_BossBattlePatchouliSpellPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EEC RID: 12012
			// (get) Token: 0x06008C2B RID: 35883 RVA: 0x00268C10 File Offset: 0x00266E10
			// (set) Token: 0x06008C2C RID: 35884 RVA: 0x0004B542 File Offset: 0x00049742
			public unsafe bool couldNotChoose
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_couldNotChoose);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_couldNotChoose)) = value;
				}
			}

			// Token: 0x17002EED RID: 12013
			// (get) Token: 0x06008C2D RID: 35885 RVA: 0x00268C38 File Offset: 0x00266E38
			// (set) Token: 0x06008C2E RID: 35886 RVA: 0x0004B55D File Offset: 0x0004975D
			public unsafe UIButtonSimple interactable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_interactable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_interactable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002EEE RID: 12014
			// (get) Token: 0x06008C2F RID: 35887 RVA: 0x00268C68 File Offset: 0x00266E68
			// (set) Token: 0x06008C30 RID: 35888 RVA: 0x0004B57C File Offset: 0x0004977C
			public unsafe PatchouliMagicSpellCardIndex thisCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_thisCard);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_BossBattlePatchouliSpellPanel.__c__DisplayClass28_0.NativeFieldInfoPtr_thisCard)) = value;
				}
			}

			// Token: 0x04005BB4 RID: 23476
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005BB5 RID: 23477
			private static readonly IntPtr NativeFieldInfoPtr_couldNotChoose;

			// Token: 0x04005BB6 RID: 23478
			private static readonly IntPtr NativeFieldInfoPtr_interactable;

			// Token: 0x04005BB7 RID: 23479
			private static readonly IntPtr NativeFieldInfoPtr_thisCard;

			// Token: 0x04005BB8 RID: 23480
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005BB9 RID: 23481
			private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__0_Internal_Void_Image_0;

			// Token: 0x04005BBA RID: 23482
			private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__1_Internal_Void_Image_0;

			// Token: 0x04005BBB RID: 23483
			private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__2_Internal_Void_RectTransform_0;

			// Token: 0x04005BBC RID: 23484
			private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__3_Internal_Void_RectTransform_0;

			// Token: 0x04005BBD RID: 23485
			private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__4_Internal_Void_UIButtonSimple_0;

			// Token: 0x04005BBE RID: 23486
			private static readonly IntPtr NativeMethodInfoPtr__ProcessElements_b__5_Internal_Void_0;
		}
	}
}
