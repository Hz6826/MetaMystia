using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020000C4 RID: 196
	public class DaySceneIzakayaSelectorPartnerSubPannel : UIPanelParamOpen<DaySceneIzakayaSelectorPartnerSubPannel.OpenContext>
	{
		// Token: 0x0600161C RID: 5660 RVA: 0x000E8A18 File Offset: 0x000E6C18
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneIzakayaSelectorPartnerSubPannel()
		{
			Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneIzakayaSelectorPartnerSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_partnerElementParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "partnerElementParent");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectablePartnerField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "selectablePartnerField");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "selectedCharacterName");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "selectedCharacterDescription");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "selectedCharacterProperties");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "selectedCharacterMain");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterEyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "selectedCharacterEyes");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterTrimBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "selectedCharacterTrimBack");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterTrimFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "selectedCharacterTrimFront");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_clear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "clear");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_partnerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "partnerSlots");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterJobButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "selectedCharacterJobButtons");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_partnerFieldScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "partnerFieldScroller");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_allPartnerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "allPartnerInstance");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_currentSlotSelectionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "currentSlotSelectionIndex");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_colorBGCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "colorBGCollection");
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_get_PartnerData_Private_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667242);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_get_MaxPartnerSlots_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667243);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_get_SelectedCharacterData_Private_get_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667244);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_set_SelectedCharacterData_Private_set_Void_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667245);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_get_partnerSelection_Private_get_IList_1_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667246);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667247);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_PartnerUITabSwitchHandler_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667248);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_UISetSlot_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667249);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_UISetJob_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667250);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667251);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_OnPartnerUIMove_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667252);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_OnPartnerUIScroll_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667253);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_OnPartnerUIMoveInternal_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667254);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_CorrectTargetId_Private_Void_PartnerType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667255);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_UpdatePartnerUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667256);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667257);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667258);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_Method_Internal_Static_PartnerType_PartnerType_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667259);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_Method_Internal_Static_PartnerType_PartnerType_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667260);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_Method_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667261);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_7_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667262);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_9_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667263);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_Method_Private_Int32_Int32_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667264);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_13_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667265);
			DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_15_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, 100667266);
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x000E8D7C File Offset: 0x000E6F7C
		public unsafe IEnumerable<int> PartnerData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62285, XrefRangeEnd = 62286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_get_PartnerData_Private_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x0600161E RID: 5662 RVA: 0x000E8DBC File Offset: 0x000E6FBC
		public unsafe int MaxPartnerSlots
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 62294, RefRangeEnd = 62296, XrefRangeStart = 62286, XrefRangeEnd = 62294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_get_MaxPartnerSlots_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x000E8DF8 File Offset: 0x000E6FF8
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x000E8E30 File Offset: 0x000E7030
		public unsafe ValueTuple<int, PartnerBase.PartnerType> SelectedCharacterData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62301, RefRangeEnd = 62302, XrefRangeStart = 62296, XrefRangeEnd = 62301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_get_SelectedCharacterData_Private_get_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<int, PartnerBase.PartnerType>(pointer);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 62308, RefRangeEnd = 62312, XrefRangeStart = 62302, XrefRangeEnd = 62308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_set_SelectedCharacterData_Private_set_Void_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x000E8E78 File Offset: 0x000E7078
		public unsafe IList<ValueTuple<int, PartnerBase.PartnerType>> partnerSelection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62312, XrefRangeEnd = 62313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_get_partnerSelection_Private_get_IList_1_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ValueTuple<int, PartnerBase.PartnerType>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x000E8EB8 File Offset: 0x000E70B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62313, XrefRangeEnd = 62376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x000E8EF4 File Offset: 0x000E70F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62376, XrefRangeEnd = 62390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PartnerUITabSwitchHandler(InputAction.CallbackContext switchAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(switchAction));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_PartnerUITabSwitchHandler_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x000E8F3C File Offset: 0x000E713C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62390, XrefRangeEnd = 62391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UISetSlot(int slotIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slotIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_UISetSlot_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x000E8F7C File Offset: 0x000E717C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62391, XrefRangeEnd = 62401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UISetJob(int jobData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref jobData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_UISetJob_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x000E8FBC File Offset: 0x000E71BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62401, XrefRangeEnd = 62402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DaySceneIzakayaSelectorPartnerSubPannel.OpenContext openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x000E9010 File Offset: 0x000E7210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62402, XrefRangeEnd = 62407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPartnerUIMove(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_OnPartnerUIMove_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x000E9058 File Offset: 0x000E7258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62407, XrefRangeEnd = 62413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPartnerUIScroll(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_OnPartnerUIScroll_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x000E90A0 File Offset: 0x000E72A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62480, RefRangeEnd = 62482, XrefRangeStart = 62413, XrefRangeEnd = 62480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPartnerUIMoveInternal(MoveDirection moveDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moveDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_OnPartnerUIMoveInternal_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x000E90E0 File Offset: 0x000E72E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 62508, RefRangeEnd = 62511, XrefRangeStart = 62482, XrefRangeEnd = 62508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CorrectTargetId(PartnerBase.PartnerType targetJob, ref int targetId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetJob;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &targetId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_CorrectTargetId_Private_Void_PartnerType_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x000E912C File Offset: 0x000E732C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 62847, RefRangeEnd = 62855, XrefRangeStart = 62511, XrefRangeEnd = 62847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePartnerUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_UpdatePartnerUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x000E9160 File Offset: 0x000E7360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62855, XrefRangeEnd = 62873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x000E919C File Offset: 0x000E739C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62873, XrefRangeEnd = 62910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneIzakayaSelectorPartnerSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000E91D8 File Offset: 0x000E73D8
		[CallerCount(0)]
		public unsafe static PartnerBase.PartnerType Method_Internal_Static_PartnerType_PartnerType_PDM_0(PartnerBase.PartnerType currentJob)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentJob;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_Method_Internal_Static_PartnerType_PartnerType_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x000E9218 File Offset: 0x000E7418
		[CallerCount(0)]
		public unsafe static PartnerBase.PartnerType Method_Internal_Static_PartnerType_PartnerType_PDM_1(PartnerBase.PartnerType currentJob)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentJob;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_Method_Internal_Static_PartnerType_PartnerType_PDM_1, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x000E9258 File Offset: 0x000E7458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62969, RefRangeEnd = 62970, XrefRangeStart = 62910, XrefRangeEnd = 62969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Method_Private_Int32_Int32_0(int currentPartner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentPartner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_Method_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x000E92A4 File Offset: 0x000E74A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62970, XrefRangeEnd = 62985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPartnerUIMoveInternal_b__33_7(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_7_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x000E92F0 File Offset: 0x000E74F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62985, XrefRangeEnd = 63000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPartnerUIMoveInternal_b__33_9(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_9_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x000E933C File Offset: 0x000E753C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63059, RefRangeEnd = 63060, XrefRangeStart = 63000, XrefRangeEnd = 63059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Method_Private_Int32_Int32_1(int currentPartner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentPartner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr_Method_Private_Int32_Int32_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x000E9388 File Offset: 0x000E7588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63060, XrefRangeEnd = 63075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPartnerUIMoveInternal_b__33_13(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_13_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x000E93D4 File Offset: 0x000E75D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63075, XrefRangeEnd = 63090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPartnerUIMoveInternal_b__33_15(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_15_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0000DCA0 File Offset: 0x0000BEA0
		public DaySceneIzakayaSelectorPartnerSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x000E9420 File Offset: 0x000E7620
		// (set) Token: 0x06001638 RID: 5688 RVA: 0x0000DCA9 File Offset: 0x0000BEA9
		public unsafe GameObject partnerElementParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_partnerElementParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_partnerElementParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x000E9450 File Offset: 0x000E7650
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		public unsafe RectTransform selectablePartnerField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectablePartnerField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectablePartnerField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x000E9480 File Offset: 0x000E7680
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x0000DCE7 File Offset: 0x0000BEE7
		public unsafe TextMeshProUGUI selectedCharacterName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x000E94B0 File Offset: 0x000E76B0
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x0000DD06 File Offset: 0x0000BF06
		public unsafe TextMeshProUGUI selectedCharacterDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x000E94E0 File Offset: 0x000E76E0
		// (set) Token: 0x06001640 RID: 5696 RVA: 0x0000DD25 File Offset: 0x0000BF25
		public unsafe TextMeshProUGUI selectedCharacterProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001641 RID: 5697 RVA: 0x000E9510 File Offset: 0x000E7710
		// (set) Token: 0x06001642 RID: 5698 RVA: 0x0000DD44 File Offset: 0x0000BF44
		public unsafe Image selectedCharacterMain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterMain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterMain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x000E9540 File Offset: 0x000E7740
		// (set) Token: 0x06001644 RID: 5700 RVA: 0x0000DD63 File Offset: 0x0000BF63
		public unsafe Image selectedCharacterEyes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterEyes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterEyes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x000E9570 File Offset: 0x000E7770
		// (set) Token: 0x06001646 RID: 5702 RVA: 0x0000DD82 File Offset: 0x0000BF82
		public unsafe Image selectedCharacterTrimBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterTrimBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterTrimBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x000E95A0 File Offset: 0x000E77A0
		// (set) Token: 0x06001648 RID: 5704 RVA: 0x0000DDA1 File Offset: 0x0000BFA1
		public unsafe Image selectedCharacterTrimFront
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterTrimFront);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterTrimFront), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x000E95D0 File Offset: 0x000E77D0
		// (set) Token: 0x0600164A RID: 5706 RVA: 0x0000DDC0 File Offset: 0x0000BFC0
		public unsafe Sprite clear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_clear);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_clear), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x000E9600 File Offset: 0x000E7800
		// (set) Token: 0x0600164C RID: 5708 RVA: 0x0000DDDF File Offset: 0x0000BFDF
		public unsafe Il2CppReferenceArray<UIElementCluster> partnerSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_partnerSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIElementCluster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_partnerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x000E9630 File Offset: 0x000E7830
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x0000DDFE File Offset: 0x0000BFFE
		public unsafe Il2CppReferenceArray<UIElementCluster> selectedCharacterJobButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterJobButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIElementCluster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_selectedCharacterJobButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x000E9660 File Offset: 0x000E7860
		// (set) Token: 0x06001650 RID: 5712 RVA: 0x0000DE1D File Offset: 0x0000C01D
		public unsafe AdpScrollListFixedComponent partnerFieldScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_partnerFieldScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpScrollListFixedComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_partnerFieldScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x000E9690 File Offset: 0x000E7890
		// (set) Token: 0x06001652 RID: 5714 RVA: 0x0000DE3C File Offset: 0x0000C03C
		public unsafe List<GameObject> allPartnerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_allPartnerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_allPartnerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x000E96C0 File Offset: 0x000E78C0
		// (set) Token: 0x06001654 RID: 5716 RVA: 0x0000DE5B File Offset: 0x0000C05B
		public unsafe int currentSlotSelectionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_currentSlotSelectionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_currentSlotSelectionIndex)) = value;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x000E96E8 File Offset: 0x000E78E8
		// (set) Token: 0x06001656 RID: 5718 RVA: 0x0000DE76 File Offset: 0x0000C076
		public unsafe Il2CppStringArray colorBGCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_colorBGCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.NativeFieldInfoPtr_colorBGCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeFieldInfoPtr_partnerElementParent;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeFieldInfoPtr_selectablePartnerField;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeFieldInfoPtr_selectedCharacterName;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeFieldInfoPtr_selectedCharacterDescription;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeFieldInfoPtr_selectedCharacterProperties;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeFieldInfoPtr_selectedCharacterMain;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeFieldInfoPtr_selectedCharacterEyes;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeFieldInfoPtr_selectedCharacterTrimBack;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeFieldInfoPtr_selectedCharacterTrimFront;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeFieldInfoPtr_clear;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeFieldInfoPtr_partnerSlots;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeFieldInfoPtr_selectedCharacterJobButtons;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeFieldInfoPtr_partnerFieldScroller;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeFieldInfoPtr_allPartnerInstance;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeFieldInfoPtr_currentSlotSelectionIndex;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeFieldInfoPtr_colorBGCollection;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerData_Private_get_IEnumerable_1_Int32_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxPartnerSlots_Private_get_Int32_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedCharacterData_Private_get_ValueTuple_2_Int32_PartnerType_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedCharacterData_Private_set_Void_ValueTuple_2_Int32_PartnerType_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr_get_partnerSelection_Private_get_IList_1_ValueTuple_2_Int32_PartnerType_0;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr_PartnerUITabSwitchHandler_Private_Void_CallbackContext_0;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeMethodInfoPtr_UISetSlot_Public_Void_Int32_0;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr_UISetJob_Public_Void_Int32_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerUIMove_Private_Void_CallbackContext_0;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerUIScroll_Private_Void_CallbackContext_0;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerUIMoveInternal_Private_Void_MoveDirection_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_CorrectTargetId_Private_Void_PartnerType_byref_Int32_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePartnerUI_Private_Void_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_PartnerType_PartnerType_PDM_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_PartnerType_PartnerType_PDM_1;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Int32_Int32_0;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_7_Private_Boolean_Int32_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_9_Private_Boolean_Int32_0;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Int32_Int32_1;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_13_Private_Boolean_Int32_0;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_15_Private_Boolean_Int32_0;

		// Token: 0x0200063A RID: 1594
		public sealed class OpenContext : ValueType
		{
			// Token: 0x060092A6 RID: 37542 RVA: 0x0027ABE8 File Offset: 0x00278DE8
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.OpenContext>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.OpenContext.NativeFieldInfoPtr_PartnerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.OpenContext>.NativeClassPtr, "PartnerData");
				DaySceneIzakayaSelectorPartnerSubPannel.OpenContext.NativeFieldInfoPtr_PartnerSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.OpenContext>.NativeClassPtr, "PartnerSelection");
				DaySceneIzakayaSelectorPartnerSubPannel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Int32_IList_1_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.OpenContext>.NativeClassPtr, 100667267);
			}

			// Token: 0x060092A7 RID: 37543 RVA: 0x0027AC50 File Offset: 0x00278E50
			[CallerCount(272)]
			[CachedScanResults(RefRangeStart = 17829, RefRangeEnd = 18101, XrefRangeStart = 17829, XrefRangeEnd = 18101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(IEnumerable<int> partnerData, IList<ValueTuple<int, PartnerBase.PartnerType>> partnerSelection) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerSelection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Int32_IList_1_ValueTuple_2_Int32_PartnerType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092A8 RID: 37544 RVA: 0x0004F66E File Offset: 0x0004D86E
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060092A9 RID: 37545 RVA: 0x0004F677 File Offset: 0x0004D877
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x170030DA RID: 12506
			// (get) Token: 0x060092AA RID: 37546 RVA: 0x0027ACB4 File Offset: 0x00278EB4
			// (set) Token: 0x060092AB RID: 37547 RVA: 0x0004F689 File Offset: 0x0004D889
			public unsafe IEnumerable<int> PartnerData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.OpenContext.NativeFieldInfoPtr_PartnerData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.OpenContext.NativeFieldInfoPtr_PartnerData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030DB RID: 12507
			// (get) Token: 0x060092AC RID: 37548 RVA: 0x0027ACE4 File Offset: 0x00278EE4
			// (set) Token: 0x060092AD RID: 37549 RVA: 0x0004F6A8 File Offset: 0x0004D8A8
			public unsafe IList<ValueTuple<int, PartnerBase.PartnerType>> PartnerSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.OpenContext.NativeFieldInfoPtr_PartnerSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ValueTuple<int, PartnerBase.PartnerType>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.OpenContext.NativeFieldInfoPtr_PartnerSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F37 RID: 24375
			private static readonly IntPtr NativeFieldInfoPtr_PartnerData;

			// Token: 0x04005F38 RID: 24376
			private static readonly IntPtr NativeFieldInfoPtr_PartnerSelection;

			// Token: 0x04005F39 RID: 24377
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_Int32_IList_1_ValueTuple_2_Int32_PartnerType_0;
		}

		// Token: 0x0200063B RID: 1595
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x060092AE RID: 37550 RVA: 0x0027AD14 File Offset: 0x00278F14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_currentI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0>.NativeClassPtr, "currentI");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0>.NativeClassPtr, 100667268);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnPanelInitialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0>.NativeClassPtr, 100667269);
			}

			// Token: 0x060092AF RID: 37551 RVA: 0x0027AD90 File Offset: 0x00278F90
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092B0 RID: 37552 RVA: 0x0027ADCC File Offset: 0x00278FCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62077, XrefRangeEnd = 62079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__OnPanelInitialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092B1 RID: 37553 RVA: 0x0004F6C7 File Offset: 0x0004D8C7
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030DC RID: 12508
			// (get) Token: 0x060092B2 RID: 37554 RVA: 0x0027AE00 File Offset: 0x00279000
			// (set) Token: 0x060092B3 RID: 37555 RVA: 0x0004F6D0 File Offset: 0x0004D8D0
			public unsafe int currentI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_currentI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_currentI)) = value;
				}
			}

			// Token: 0x170030DD RID: 12509
			// (get) Token: 0x060092B4 RID: 37556 RVA: 0x0027AE28 File Offset: 0x00279028
			// (set) Token: 0x060092B5 RID: 37557 RVA: 0x0004F6EB File Offset: 0x0004D8EB
			public unsafe DaySceneIzakayaSelectorPartnerSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneIzakayaSelectorPartnerSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F3A RID: 24378
			private static readonly IntPtr NativeFieldInfoPtr_currentI;

			// Token: 0x04005F3B RID: 24379
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005F3C RID: 24380
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F3D RID: 24381
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__0_Internal_Void_0;
		}

		// Token: 0x0200063C RID: 1596
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass26_1")]
		public sealed class __c__DisplayClass26_1 : Il2CppSystem.Object
		{
			// Token: 0x060092B6 RID: 37558 RVA: 0x0027AE58 File Offset: 0x00279058
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_1()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass26_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1.NativeFieldInfoPtr_currentI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1>.NativeClassPtr, "currentI");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1>.NativeClassPtr, "<>4__this");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1>.NativeClassPtr, 100667270);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1>.NativeClassPtr, 100667271);
			}

			// Token: 0x060092B7 RID: 37559 RVA: 0x0027AED4 File Offset: 0x002790D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092B8 RID: 37560 RVA: 0x0027AF10 File Offset: 0x00279110
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62079, XrefRangeEnd = 62089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092B9 RID: 37561 RVA: 0x0004F70A File Offset: 0x0004D90A
			public __c__DisplayClass26_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030DE RID: 12510
			// (get) Token: 0x060092BA RID: 37562 RVA: 0x0027AF44 File Offset: 0x00279144
			// (set) Token: 0x060092BB RID: 37563 RVA: 0x0004F713 File Offset: 0x0004D913
			public unsafe int currentI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1.NativeFieldInfoPtr_currentI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1.NativeFieldInfoPtr_currentI)) = value;
				}
			}

			// Token: 0x170030DF RID: 12511
			// (get) Token: 0x060092BC RID: 37564 RVA: 0x0027AF6C File Offset: 0x0027916C
			// (set) Token: 0x060092BD RID: 37565 RVA: 0x0004F72E File Offset: 0x0004D92E
			public unsafe DaySceneIzakayaSelectorPartnerSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneIzakayaSelectorPartnerSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass26_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F3E RID: 24382
			private static readonly IntPtr NativeFieldInfoPtr_currentI;

			// Token: 0x04005F3F RID: 24383
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005F40 RID: 24384
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F41 RID: 24385
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_0;
		}

		// Token: 0x0200063D RID: 1597
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x060092BE RID: 37566 RVA: 0x0027AF9C File Offset: 0x0027919C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0.NativeFieldInfoPtr_currentPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0>.NativeClassPtr, "currentPartner");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0>.NativeClassPtr, 100667272);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__6_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0>.NativeClassPtr, 100667273);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__8_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0>.NativeClassPtr, 100667274);
			}

			// Token: 0x060092BF RID: 37567 RVA: 0x0027B018 File Offset: 0x00279218
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092C0 RID: 37568 RVA: 0x0027B054 File Offset: 0x00279254
			[CallerCount(0)]
			public unsafe bool _OnPartnerUIMoveInternal_b__6(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__6_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060092C1 RID: 37569 RVA: 0x0027B0A0 File Offset: 0x002792A0
			[CallerCount(0)]
			public unsafe bool _OnPartnerUIMoveInternal_b__8(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__8_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060092C2 RID: 37570 RVA: 0x0004F74D File Offset: 0x0004D94D
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030E0 RID: 12512
			// (get) Token: 0x060092C3 RID: 37571 RVA: 0x0027B0EC File Offset: 0x002792EC
			// (set) Token: 0x060092C4 RID: 37572 RVA: 0x0004F756 File Offset: 0x0004D956
			public unsafe int currentPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0.NativeFieldInfoPtr_currentPartner);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_0.NativeFieldInfoPtr_currentPartner)) = value;
				}
			}

			// Token: 0x04005F42 RID: 24386
			private static readonly IntPtr NativeFieldInfoPtr_currentPartner;

			// Token: 0x04005F43 RID: 24387
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F44 RID: 24388
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__6_Internal_Boolean_Int32_0;

			// Token: 0x04005F45 RID: 24389
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__8_Internal_Boolean_Int32_0;
		}

		// Token: 0x0200063E RID: 1598
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass33_1")]
		public sealed class __c__DisplayClass33_1 : Il2CppSystem.Object
		{
			// Token: 0x060092C5 RID: 37573 RVA: 0x0027B114 File Offset: 0x00279314
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_1()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass33_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_1>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_1>.NativeClassPtr, "x");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_1>.NativeClassPtr, 100667275);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_1.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__10_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_1>.NativeClassPtr, 100667276);
			}

			// Token: 0x060092C6 RID: 37574 RVA: 0x0027B17C File Offset: 0x0027937C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092C7 RID: 37575 RVA: 0x0027B1B8 File Offset: 0x002793B8
			[CallerCount(0)]
			public unsafe bool _OnPartnerUIMoveInternal_b__10(ValueTuple<int, PartnerBase.PartnerType> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_1.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__10_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060092C8 RID: 37576 RVA: 0x0004F771 File Offset: 0x0004D971
			public __c__DisplayClass33_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030E1 RID: 12513
			// (get) Token: 0x060092C9 RID: 37577 RVA: 0x0027B20C File Offset: 0x0027940C
			// (set) Token: 0x060092CA RID: 37578 RVA: 0x0004F77A File Offset: 0x0004D97A
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_1.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_1.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x04005F46 RID: 24390
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04005F47 RID: 24391
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F48 RID: 24392
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__10_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0;
		}

		// Token: 0x0200063F RID: 1599
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass33_2")]
		public sealed class __c__DisplayClass33_2 : Il2CppSystem.Object
		{
			// Token: 0x060092CB RID: 37579 RVA: 0x0027B234 File Offset: 0x00279434
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_2()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass33_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_2>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_2>.NativeClassPtr, "x");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_2>.NativeClassPtr, 100667277);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_2.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__11_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_2>.NativeClassPtr, 100667278);
			}

			// Token: 0x060092CC RID: 37580 RVA: 0x0027B29C File Offset: 0x0027949C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092CD RID: 37581 RVA: 0x0027B2D8 File Offset: 0x002794D8
			[CallerCount(0)]
			public unsafe bool _OnPartnerUIMoveInternal_b__11(ValueTuple<int, PartnerBase.PartnerType> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_2.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__11_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060092CE RID: 37582 RVA: 0x0004F795 File Offset: 0x0004D995
			public __c__DisplayClass33_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030E2 RID: 12514
			// (get) Token: 0x060092CF RID: 37583 RVA: 0x0027B32C File Offset: 0x0027952C
			// (set) Token: 0x060092D0 RID: 37584 RVA: 0x0004F79E File Offset: 0x0004D99E
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_2.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_2.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x04005F49 RID: 24393
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04005F4A RID: 24394
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F4B RID: 24395
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__11_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0;
		}

		// Token: 0x02000640 RID: 1600
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass33_3")]
		public sealed class __c__DisplayClass33_3 : Il2CppSystem.Object
		{
			// Token: 0x060092D1 RID: 37585 RVA: 0x0027B354 File Offset: 0x00279554
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_3()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass33_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3.NativeFieldInfoPtr_currentPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3>.NativeClassPtr, "currentPartner");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3>.NativeClassPtr, 100667279);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__12_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3>.NativeClassPtr, 100667280);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__14_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3>.NativeClassPtr, 100667281);
			}

			// Token: 0x060092D2 RID: 37586 RVA: 0x0027B3D0 File Offset: 0x002795D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092D3 RID: 37587 RVA: 0x0027B40C File Offset: 0x0027960C
			[CallerCount(0)]
			public unsafe bool _OnPartnerUIMoveInternal_b__12(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__12_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060092D4 RID: 37588 RVA: 0x0027B458 File Offset: 0x00279658
			[CallerCount(0)]
			public unsafe bool _OnPartnerUIMoveInternal_b__14(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__14_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060092D5 RID: 37589 RVA: 0x0004F7B9 File Offset: 0x0004D9B9
			public __c__DisplayClass33_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030E3 RID: 12515
			// (get) Token: 0x060092D6 RID: 37590 RVA: 0x0027B4A4 File Offset: 0x002796A4
			// (set) Token: 0x060092D7 RID: 37591 RVA: 0x0004F7C2 File Offset: 0x0004D9C2
			public unsafe int currentPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3.NativeFieldInfoPtr_currentPartner);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_3.NativeFieldInfoPtr_currentPartner)) = value;
				}
			}

			// Token: 0x04005F4C RID: 24396
			private static readonly IntPtr NativeFieldInfoPtr_currentPartner;

			// Token: 0x04005F4D RID: 24397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F4E RID: 24398
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__12_Internal_Boolean_Int32_0;

			// Token: 0x04005F4F RID: 24399
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__14_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000641 RID: 1601
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass33_4")]
		public sealed class __c__DisplayClass33_4 : Il2CppSystem.Object
		{
			// Token: 0x060092D8 RID: 37592 RVA: 0x0027B4CC File Offset: 0x002796CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_4()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass33_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_4>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_4>.NativeClassPtr, "x");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_4>.NativeClassPtr, 100667282);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_4.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__16_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_4>.NativeClassPtr, 100667283);
			}

			// Token: 0x060092D9 RID: 37593 RVA: 0x0027B534 File Offset: 0x00279734
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092DA RID: 37594 RVA: 0x0027B570 File Offset: 0x00279770
			[CallerCount(0)]
			public unsafe bool _OnPartnerUIMoveInternal_b__16(ValueTuple<int, PartnerBase.PartnerType> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_4.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__16_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060092DB RID: 37595 RVA: 0x0004F7DD File Offset: 0x0004D9DD
			public __c__DisplayClass33_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030E4 RID: 12516
			// (get) Token: 0x060092DC RID: 37596 RVA: 0x0027B5C4 File Offset: 0x002797C4
			// (set) Token: 0x060092DD RID: 37597 RVA: 0x0004F7E6 File Offset: 0x0004D9E6
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_4.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_4.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x04005F50 RID: 24400
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04005F51 RID: 24401
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F52 RID: 24402
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__16_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0;
		}

		// Token: 0x02000642 RID: 1602
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass33_5")]
		public sealed class __c__DisplayClass33_5 : Il2CppSystem.Object
		{
			// Token: 0x060092DE RID: 37598 RVA: 0x0027B5EC File Offset: 0x002797EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_5()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass33_5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_5>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_5.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_5>.NativeClassPtr, "x");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_5>.NativeClassPtr, 100667284);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_5.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__17_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_5>.NativeClassPtr, 100667285);
			}

			// Token: 0x060092DF RID: 37599 RVA: 0x0027B654 File Offset: 0x00279854
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_5>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092E0 RID: 37600 RVA: 0x0027B690 File Offset: 0x00279890
			[CallerCount(0)]
			public unsafe bool _OnPartnerUIMoveInternal_b__17(ValueTuple<int, PartnerBase.PartnerType> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_5.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__17_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060092E1 RID: 37601 RVA: 0x0004F801 File Offset: 0x0004DA01
			public __c__DisplayClass33_5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030E5 RID: 12517
			// (get) Token: 0x060092E2 RID: 37602 RVA: 0x0027B6E4 File Offset: 0x002798E4
			// (set) Token: 0x060092E3 RID: 37603 RVA: 0x0004F80A File Offset: 0x0004DA0A
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_5.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass33_5.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x04005F53 RID: 24403
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04005F54 RID: 24404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F55 RID: 24405
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__17_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0;
		}

		// Token: 0x02000643 RID: 1603
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060092E4 RID: 37604 RVA: 0x0027B70C File Offset: 0x0027990C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, "<>9");
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__33_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, "<>9__33_4");
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__33_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, "<>9__33_5");
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, "<>9__34_0");
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, "<>9__35_9");
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, "<>9__35_8");
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, "<>9__35_17");
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, "<>9__35_18");
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, "<>9__35_1");
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, "<>9__35_21");
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, "<>9__35_2");
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, "<>9__35_3");
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, "<>9__35_5");
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, 100667287);
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_4_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, 100667288);
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_5_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, 100667289);
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__CorrectTargetId_b__34_0_Internal_Int32_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, 100667290);
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_9_Internal_Void_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, 100667291);
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_8_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, 100667292);
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_17_Internal_Void_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, 100667293);
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_18_Internal_Void_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, 100667294);
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, 100667295);
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_2_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, 100667296);
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_21_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, 100667297);
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, 100667298);
				DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_5_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr, 100667299);
			}

			// Token: 0x060092E5 RID: 37605 RVA: 0x0027B940 File Offset: 0x00279B40
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092E6 RID: 37606 RVA: 0x0027B97C File Offset: 0x00279B7C
			[CallerCount(0)]
			public unsafe bool _OnPartnerUIMoveInternal_b__33_4(ValueTuple<int, PartnerBase.PartnerType> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_4_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060092E7 RID: 37607 RVA: 0x0027B9D0 File Offset: 0x00279BD0
			[CallerCount(0)]
			public unsafe bool _OnPartnerUIMoveInternal_b__33_5(ValueTuple<int, PartnerBase.PartnerType> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_5_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060092E8 RID: 37608 RVA: 0x0027BA24 File Offset: 0x00279C24
			[CallerCount(0)]
			public unsafe int _CorrectTargetId_b__34_0(ValueTuple<int, PartnerBase.PartnerType> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__CorrectTargetId_b__34_0_Internal_Int32_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060092E9 RID: 37609 RVA: 0x0027BA78 File Offset: 0x00279C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62089, XrefRangeEnd = 62093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__35_9(UIButtonSimple y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_9_Internal_Void_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092EA RID: 37610 RVA: 0x0027BABC File Offset: 0x00279CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62093, XrefRangeEnd = 62097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__35_8(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_8_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092EB RID: 37611 RVA: 0x0027BB00 File Offset: 0x00279D00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62097, XrefRangeEnd = 62101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__35_17(UIButtonSimple x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_17_Internal_Void_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092EC RID: 37612 RVA: 0x0027BB44 File Offset: 0x00279D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62101, XrefRangeEnd = 62105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__35_18(UIButtonSimple x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_18_Internal_Void_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092ED RID: 37613 RVA: 0x0027BB88 File Offset: 0x00279D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62105, XrefRangeEnd = 62107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__35_1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092EE RID: 37614 RVA: 0x0027BBCC File Offset: 0x00279DCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62107, XrefRangeEnd = 62126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__35_2(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_2_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092EF RID: 37615 RVA: 0x0027BC10 File Offset: 0x00279E10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__35_21(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_21_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092F0 RID: 37616 RVA: 0x0027BC54 File Offset: 0x00279E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__35_3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092F1 RID: 37617 RVA: 0x0027BC98 File Offset: 0x00279E98
			[CallerCount(0)]
			public unsafe bool _UpdatePartnerUI_b__35_5(ValueTuple<int, PartnerBase.PartnerType> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeMethodInfoPtr__UpdatePartnerUI_b__35_5_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060092F2 RID: 37618 RVA: 0x0004F825 File Offset: 0x0004DA25
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030E6 RID: 12518
			// (get) Token: 0x060092F3 RID: 37619 RVA: 0x0027BCEC File Offset: 0x00279EEC
			// (set) Token: 0x060092F4 RID: 37620 RVA: 0x0004F82E File Offset: 0x0004DA2E
			public unsafe static DaySceneIzakayaSelectorPartnerSubPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneIzakayaSelectorPartnerSubPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030E7 RID: 12519
			// (get) Token: 0x060092F5 RID: 37621 RVA: 0x0027BD14 File Offset: 0x00279F14
			// (set) Token: 0x060092F6 RID: 37622 RVA: 0x0004F840 File Offset: 0x0004DA40
			public unsafe static Func<ValueTuple<int, PartnerBase.PartnerType>, bool> __9__33_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__33_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, PartnerBase.PartnerType>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__33_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030E8 RID: 12520
			// (get) Token: 0x060092F7 RID: 37623 RVA: 0x0027BD3C File Offset: 0x00279F3C
			// (set) Token: 0x060092F8 RID: 37624 RVA: 0x0004F852 File Offset: 0x0004DA52
			public unsafe static Func<ValueTuple<int, PartnerBase.PartnerType>, bool> __9__33_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__33_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, PartnerBase.PartnerType>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__33_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030E9 RID: 12521
			// (get) Token: 0x060092F9 RID: 37625 RVA: 0x0027BD64 File Offset: 0x00279F64
			// (set) Token: 0x060092FA RID: 37626 RVA: 0x0004F864 File Offset: 0x0004DA64
			public unsafe static Func<ValueTuple<int, PartnerBase.PartnerType>, int> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, PartnerBase.PartnerType>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030EA RID: 12522
			// (get) Token: 0x060092FB RID: 37627 RVA: 0x0027BD8C File Offset: 0x00279F8C
			// (set) Token: 0x060092FC RID: 37628 RVA: 0x0004F876 File Offset: 0x0004DA76
			public unsafe static Action<UIButtonSimple> __9__35_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030EB RID: 12523
			// (get) Token: 0x060092FD RID: 37629 RVA: 0x0027BDB4 File Offset: 0x00279FB4
			// (set) Token: 0x060092FE RID: 37630 RVA: 0x0004F888 File Offset: 0x0004DA88
			public unsafe static Action<UIElementCluster> __9__35_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030EC RID: 12524
			// (get) Token: 0x060092FF RID: 37631 RVA: 0x0027BDDC File Offset: 0x00279FDC
			// (set) Token: 0x06009300 RID: 37632 RVA: 0x0004F89A File Offset: 0x0004DA9A
			public unsafe static Action<UIButtonSimple> __9__35_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030ED RID: 12525
			// (get) Token: 0x06009301 RID: 37633 RVA: 0x0027BE04 File Offset: 0x0027A004
			// (set) Token: 0x06009302 RID: 37634 RVA: 0x0004F8AC File Offset: 0x0004DAAC
			public unsafe static Action<UIButtonSimple> __9__35_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIButtonSimple>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030EE RID: 12526
			// (get) Token: 0x06009303 RID: 37635 RVA: 0x0027BE2C File Offset: 0x0027A02C
			// (set) Token: 0x06009304 RID: 37636 RVA: 0x0004F8BE File Offset: 0x0004DABE
			public unsafe static Action<Image> __9__35_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030EF RID: 12527
			// (get) Token: 0x06009305 RID: 37637 RVA: 0x0027BE54 File Offset: 0x0027A054
			// (set) Token: 0x06009306 RID: 37638 RVA: 0x0004F8D0 File Offset: 0x0004DAD0
			public unsafe static Action<Image> __9__35_21
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_21, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_21, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030F0 RID: 12528
			// (get) Token: 0x06009307 RID: 37639 RVA: 0x0027BE7C File Offset: 0x0027A07C
			// (set) Token: 0x06009308 RID: 37640 RVA: 0x0004F8E2 File Offset: 0x0004DAE2
			public unsafe static Action<UIElementCluster> __9__35_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030F1 RID: 12529
			// (get) Token: 0x06009309 RID: 37641 RVA: 0x0027BEA4 File Offset: 0x0027A0A4
			// (set) Token: 0x0600930A RID: 37642 RVA: 0x0004F8F4 File Offset: 0x0004DAF4
			public unsafe static Action<Image> __9__35_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030F2 RID: 12530
			// (get) Token: 0x0600930B RID: 37643 RVA: 0x0027BECC File Offset: 0x0027A0CC
			// (set) Token: 0x0600930C RID: 37644 RVA: 0x0004F906 File Offset: 0x0004DB06
			public unsafe static Func<ValueTuple<int, PartnerBase.PartnerType>, bool> __9__35_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, PartnerBase.PartnerType>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPartnerSubPannel.__c.NativeFieldInfoPtr___9__35_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F56 RID: 24406
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005F57 RID: 24407
			private static readonly IntPtr NativeFieldInfoPtr___9__33_4;

			// Token: 0x04005F58 RID: 24408
			private static readonly IntPtr NativeFieldInfoPtr___9__33_5;

			// Token: 0x04005F59 RID: 24409
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x04005F5A RID: 24410
			private static readonly IntPtr NativeFieldInfoPtr___9__35_9;

			// Token: 0x04005F5B RID: 24411
			private static readonly IntPtr NativeFieldInfoPtr___9__35_8;

			// Token: 0x04005F5C RID: 24412
			private static readonly IntPtr NativeFieldInfoPtr___9__35_17;

			// Token: 0x04005F5D RID: 24413
			private static readonly IntPtr NativeFieldInfoPtr___9__35_18;

			// Token: 0x04005F5E RID: 24414
			private static readonly IntPtr NativeFieldInfoPtr___9__35_1;

			// Token: 0x04005F5F RID: 24415
			private static readonly IntPtr NativeFieldInfoPtr___9__35_21;

			// Token: 0x04005F60 RID: 24416
			private static readonly IntPtr NativeFieldInfoPtr___9__35_2;

			// Token: 0x04005F61 RID: 24417
			private static readonly IntPtr NativeFieldInfoPtr___9__35_3;

			// Token: 0x04005F62 RID: 24418
			private static readonly IntPtr NativeFieldInfoPtr___9__35_5;

			// Token: 0x04005F63 RID: 24419
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F64 RID: 24420
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_4_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0;

			// Token: 0x04005F65 RID: 24421
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerUIMoveInternal_b__33_5_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0;

			// Token: 0x04005F66 RID: 24422
			private static readonly IntPtr NativeMethodInfoPtr__CorrectTargetId_b__34_0_Internal_Int32_ValueTuple_2_Int32_PartnerType_0;

			// Token: 0x04005F67 RID: 24423
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__35_9_Internal_Void_UIButtonSimple_0;

			// Token: 0x04005F68 RID: 24424
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__35_8_Internal_Void_UIElementCluster_0;

			// Token: 0x04005F69 RID: 24425
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__35_17_Internal_Void_UIButtonSimple_0;

			// Token: 0x04005F6A RID: 24426
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__35_18_Internal_Void_UIButtonSimple_0;

			// Token: 0x04005F6B RID: 24427
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__35_1_Internal_Void_Image_0;

			// Token: 0x04005F6C RID: 24428
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__35_2_Internal_Void_UIElementCluster_0;

			// Token: 0x04005F6D RID: 24429
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__35_21_Internal_Void_Image_0;

			// Token: 0x04005F6E RID: 24430
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__35_3_Internal_Void_Image_0;

			// Token: 0x04005F6F RID: 24431
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__35_5_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0;
		}

		// Token: 0x02000644 RID: 1604
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600930D RID: 37645 RVA: 0x0027BEF4 File Offset: 0x0027A0F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0.NativeFieldInfoPtr_autoFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0>.NativeClassPtr, "autoFocus");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0>.NativeClassPtr, 100667300);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_ValueTuple_3_Int32_PartnerType_Action_1_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0>.NativeClassPtr, 100667301);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0>.NativeClassPtr, 100667302);
			}

			// Token: 0x0600930E RID: 37646 RVA: 0x0027BF84 File Offset: 0x0027A184
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600930F RID: 37647 RVA: 0x0027BFC0 File Offset: 0x0027A1C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62202, RefRangeEnd = 62203, XrefRangeStart = 62126, XrefRangeEnd = 62202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UIElementCluster_ValueTuple_3_Int32_PartnerType_Action_1_UIButtonSimple_0(UIElementCluster uiElement, ValueTuple<int, PartnerBase.PartnerType, Action<UIButtonSimple>> selectedData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElement);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(selectedData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_ValueTuple_3_Int32_PartnerType_Action_1_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009310 RID: 37648 RVA: 0x0027C01C File Offset: 0x0027A21C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62203, XrefRangeEnd = 62211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_PDM_0(bool enabled)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009311 RID: 37649 RVA: 0x0004F918 File Offset: 0x0004DB18
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030F3 RID: 12531
			// (get) Token: 0x06009312 RID: 37650 RVA: 0x0027C05C File Offset: 0x0027A25C
			// (set) Token: 0x06009313 RID: 37651 RVA: 0x0004F921 File Offset: 0x0004DB21
			public unsafe DaySceneIzakayaSelectorPartnerSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneIzakayaSelectorPartnerSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030F4 RID: 12532
			// (get) Token: 0x06009314 RID: 37652 RVA: 0x0027C08C File Offset: 0x0027A28C
			// (set) Token: 0x06009315 RID: 37653 RVA: 0x0004F940 File Offset: 0x0004DB40
			public unsafe bool autoFocus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0.NativeFieldInfoPtr_autoFocus);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0.NativeFieldInfoPtr_autoFocus)) = value;
				}
			}

			// Token: 0x04005F70 RID: 24432
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005F71 RID: 24433
			private static readonly IntPtr NativeFieldInfoPtr_autoFocus;

			// Token: 0x04005F72 RID: 24434
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F73 RID: 24435
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_ValueTuple_3_Int32_PartnerType_Action_1_UIButtonSimple_0;

			// Token: 0x04005F74 RID: 24436
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;
		}

		// Token: 0x02000645 RID: 1605
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass35_1")]
		public sealed class __c__DisplayClass35_1 : Il2CppSystem.Object
		{
			// Token: 0x06009316 RID: 37654 RVA: 0x0027C0B4 File Offset: 0x0027A2B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_1()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass35_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1>.NativeClassPtr, "i");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1>.NativeClassPtr, "CS$<>8__locals1");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1>.NativeClassPtr, 100667303);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1.NativeMethodInfoPtr__UpdatePartnerUI_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1>.NativeClassPtr, 100667304);
			}

			// Token: 0x06009317 RID: 37655 RVA: 0x0027C130 File Offset: 0x0027A330
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009318 RID: 37656 RVA: 0x0027C16C File Offset: 0x0027A36C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62211, XrefRangeEnd = 62213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1.NativeMethodInfoPtr__UpdatePartnerUI_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009319 RID: 37657 RVA: 0x0004F95B File Offset: 0x0004DB5B
			public __c__DisplayClass35_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030F5 RID: 12533
			// (get) Token: 0x0600931A RID: 37658 RVA: 0x0027C1B0 File Offset: 0x0027A3B0
			// (set) Token: 0x0600931B RID: 37659 RVA: 0x0004F964 File Offset: 0x0004DB64
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x170030F6 RID: 12534
			// (get) Token: 0x0600931C RID: 37660 RVA: 0x0027C1D8 File Offset: 0x0027A3D8
			// (set) Token: 0x0600931D RID: 37661 RVA: 0x0004F97F File Offset: 0x0004DB7F
			public unsafe DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0 field_Public___c__DisplayClass35_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F75 RID: 24437
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04005F76 RID: 24438
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_0;

			// Token: 0x04005F77 RID: 24439
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F78 RID: 24440
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__6_Internal_Void_Image_0;
		}

		// Token: 0x02000646 RID: 1606
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass35_2")]
		public sealed class __c__DisplayClass35_2 : Il2CppSystem.Object
		{
			// Token: 0x0600931E RID: 37662 RVA: 0x0027C208 File Offset: 0x0027A408
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_2()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass35_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2.NativeFieldInfoPtr_CharacterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2>.NativeClassPtr, "CharacterId");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2.NativeFieldInfoPtr_CharacterJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2>.NativeClassPtr, "CharacterJob");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2.NativeFieldInfoPtr_field_Public___c__DisplayClass35_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2>.NativeClassPtr, "CS$<>8__locals2");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2>.NativeClassPtr, 100667305);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2.NativeMethodInfoPtr__UpdatePartnerUI_b__7_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2>.NativeClassPtr, 100667306);
			}

			// Token: 0x0600931F RID: 37663 RVA: 0x0027C298 File Offset: 0x0027A498
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009320 RID: 37664 RVA: 0x0027C2D4 File Offset: 0x0027A4D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62213, XrefRangeEnd = 62232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__7(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2.NativeMethodInfoPtr__UpdatePartnerUI_b__7_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009321 RID: 37665 RVA: 0x0004F99E File Offset: 0x0004DB9E
			public __c__DisplayClass35_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030F7 RID: 12535
			// (get) Token: 0x06009322 RID: 37666 RVA: 0x0027C318 File Offset: 0x0027A518
			// (set) Token: 0x06009323 RID: 37667 RVA: 0x0004F9A7 File Offset: 0x0004DBA7
			public unsafe int CharacterId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2.NativeFieldInfoPtr_CharacterId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2.NativeFieldInfoPtr_CharacterId)) = value;
				}
			}

			// Token: 0x170030F8 RID: 12536
			// (get) Token: 0x06009324 RID: 37668 RVA: 0x0027C340 File Offset: 0x0027A540
			// (set) Token: 0x06009325 RID: 37669 RVA: 0x0004F9C2 File Offset: 0x0004DBC2
			public unsafe PartnerBase.PartnerType CharacterJob
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2.NativeFieldInfoPtr_CharacterJob);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2.NativeFieldInfoPtr_CharacterJob)) = value;
				}
			}

			// Token: 0x170030F9 RID: 12537
			// (get) Token: 0x06009326 RID: 37670 RVA: 0x0027C368 File Offset: 0x0027A568
			// (set) Token: 0x06009327 RID: 37671 RVA: 0x0004F9DD File Offset: 0x0004DBDD
			public unsafe DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1 field_Public___c__DisplayClass35_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2.NativeFieldInfoPtr_field_Public___c__DisplayClass35_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_2.NativeFieldInfoPtr_field_Public___c__DisplayClass35_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F79 RID: 24441
			private static readonly IntPtr NativeFieldInfoPtr_CharacterId;

			// Token: 0x04005F7A RID: 24442
			private static readonly IntPtr NativeFieldInfoPtr_CharacterJob;

			// Token: 0x04005F7B RID: 24443
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass35_1_0;

			// Token: 0x04005F7C RID: 24444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F7D RID: 24445
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__7_Internal_Void_UIElementCluster_0;
		}

		// Token: 0x02000647 RID: 1607
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass35_3")]
		public sealed class __c__DisplayClass35_3 : Il2CppSystem.Object
		{
			// Token: 0x06009328 RID: 37672 RVA: 0x0027C398 File Offset: 0x0027A598
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_3()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass35_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_characterVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, "characterVisual");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_selectedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, "selectedData");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, "rectTransform");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_enabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, "enabledColor");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, "CS$<>8__locals3");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr___9__14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, "<>9__14");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr___9__15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, "<>9__15");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, 100667307);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__UpdatePartnerUI_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, 100667308);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__UpdatePartnerUI_b__11_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, 100667309);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__UpdatePartnerUI_b__12_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, 100667310);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__UpdatePartnerUI_b__14_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, 100667311);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__UpdatePartnerUI_b__13_Internal_Void_Il2CppReferenceArray_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, 100667312);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__UpdatePartnerUI_b__15_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr, 100667313);
			}

			// Token: 0x06009329 RID: 37673 RVA: 0x0027C4DC File Offset: 0x0027A6DC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600932A RID: 37674 RVA: 0x0027C518 File Offset: 0x0027A718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__UpdatePartnerUI_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600932B RID: 37675 RVA: 0x0027C55C File Offset: 0x0027A75C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__11(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__UpdatePartnerUI_b__11_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600932C RID: 37676 RVA: 0x0027C5A0 File Offset: 0x0027A7A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62232, XrefRangeEnd = 62249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__12(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__UpdatePartnerUI_b__12_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600932D RID: 37677 RVA: 0x0027C5E4 File Offset: 0x0027A7E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62249, XrefRangeEnd = 62251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__14()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__UpdatePartnerUI_b__14_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600932E RID: 37678 RVA: 0x0027C618 File Offset: 0x0027A818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62251, XrefRangeEnd = 62262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__13(Il2CppReferenceArray<Image> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__UpdatePartnerUI_b__13_Internal_Void_Il2CppReferenceArray_1_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600932F RID: 37679 RVA: 0x0027C65C File Offset: 0x0027A85C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62262, XrefRangeEnd = 62266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__15(Image z)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(z);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeMethodInfoPtr__UpdatePartnerUI_b__15_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009330 RID: 37680 RVA: 0x0004F9FC File Offset: 0x0004DBFC
			public __c__DisplayClass35_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030FA RID: 12538
			// (get) Token: 0x06009331 RID: 37681 RVA: 0x0027C6A0 File Offset: 0x0027A8A0
			// (set) Token: 0x06009332 RID: 37682 RVA: 0x0004FA05 File Offset: 0x0004DC05
			public unsafe CharacterSpriteSetCompact characterVisual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_characterVisual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_characterVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030FB RID: 12539
			// (get) Token: 0x06009333 RID: 37683 RVA: 0x0027C6D0 File Offset: 0x0027A8D0
			// (set) Token: 0x06009334 RID: 37684 RVA: 0x0004FA24 File Offset: 0x0004DC24
			public ValueTuple<int, PartnerBase.PartnerType, Action<UIButtonSimple>> selectedData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_selectedData);
					return new ValueTuple<int, PartnerBase.PartnerType, Action<UIButtonSimple>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<int, PartnerBase.PartnerType, Action<UIButtonSimple>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_selectedData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<int, PartnerBase.PartnerType, Action<UIButtonSimple>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170030FC RID: 12540
			// (get) Token: 0x06009335 RID: 37685 RVA: 0x0027C700 File Offset: 0x0027A900
			// (set) Token: 0x06009336 RID: 37686 RVA: 0x0004FA52 File Offset: 0x0004DC52
			public unsafe RectTransform rectTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_rectTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030FD RID: 12541
			// (get) Token: 0x06009337 RID: 37687 RVA: 0x0027C730 File Offset: 0x0027A930
			// (set) Token: 0x06009338 RID: 37688 RVA: 0x0004FA71 File Offset: 0x0004DC71
			public unsafe string enabledColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_enabledColor);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_enabledColor), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170030FE RID: 12542
			// (get) Token: 0x06009339 RID: 37689 RVA: 0x0027C758 File Offset: 0x0027A958
			// (set) Token: 0x0600933A RID: 37690 RVA: 0x0004FA90 File Offset: 0x0004DC90
			public unsafe DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0 field_Public___c__DisplayClass35_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030FF RID: 12543
			// (get) Token: 0x0600933B RID: 37691 RVA: 0x0027C788 File Offset: 0x0027A988
			// (set) Token: 0x0600933C RID: 37692 RVA: 0x0004FAAF File Offset: 0x0004DCAF
			public unsafe Action __9__14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr___9__14);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr___9__14), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003100 RID: 12544
			// (get) Token: 0x0600933D RID: 37693 RVA: 0x0027C7B8 File Offset: 0x0027A9B8
			// (set) Token: 0x0600933E RID: 37694 RVA: 0x0004FACE File Offset: 0x0004DCCE
			public unsafe Action<Image> __9__15
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr___9__15);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_3.NativeFieldInfoPtr___9__15), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F7E RID: 24446
			private static readonly IntPtr NativeFieldInfoPtr_characterVisual;

			// Token: 0x04005F7F RID: 24447
			private static readonly IntPtr NativeFieldInfoPtr_selectedData;

			// Token: 0x04005F80 RID: 24448
			private static readonly IntPtr NativeFieldInfoPtr_rectTransform;

			// Token: 0x04005F81 RID: 24449
			private static readonly IntPtr NativeFieldInfoPtr_enabledColor;

			// Token: 0x04005F82 RID: 24450
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_0;

			// Token: 0x04005F83 RID: 24451
			private static readonly IntPtr NativeFieldInfoPtr___9__14;

			// Token: 0x04005F84 RID: 24452
			private static readonly IntPtr NativeFieldInfoPtr___9__15;

			// Token: 0x04005F85 RID: 24453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F86 RID: 24454
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__10_Internal_Void_Image_0;

			// Token: 0x04005F87 RID: 24455
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__11_Internal_Void_Image_0;

			// Token: 0x04005F88 RID: 24456
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__12_Internal_Void_Image_0;

			// Token: 0x04005F89 RID: 24457
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__14_Internal_Void_0;

			// Token: 0x04005F8A RID: 24458
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__13_Internal_Void_Il2CppReferenceArray_1_Image_0;

			// Token: 0x04005F8B RID: 24459
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__15_Internal_Void_Image_0;
		}

		// Token: 0x02000648 RID: 1608
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass35_4")]
		public sealed class __c__DisplayClass35_4 : Il2CppSystem.Object
		{
			// Token: 0x0600933F RID: 37695 RVA: 0x0027C7E8 File Offset: 0x0027A9E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_4()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass35_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4>.NativeClassPtr, "item");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4>.NativeClassPtr, "CS$<>8__locals4");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4>.NativeClassPtr, 100667314);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4.NativeMethodInfoPtr__UpdatePartnerUI_b__16_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4>.NativeClassPtr, 100667315);
			}

			// Token: 0x06009340 RID: 37696 RVA: 0x0027C864 File Offset: 0x0027AA64
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009341 RID: 37697 RVA: 0x0027C8A0 File Offset: 0x0027AAA0
			[CallerCount(0)]
			public unsafe bool _UpdatePartnerUI_b__16(ValueTuple<int, PartnerBase.PartnerType> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4.NativeMethodInfoPtr__UpdatePartnerUI_b__16_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009342 RID: 37698 RVA: 0x0004FAED File Offset: 0x0004DCED
			public __c__DisplayClass35_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003101 RID: 12545
			// (get) Token: 0x06009343 RID: 37699 RVA: 0x0027C8F4 File Offset: 0x0027AAF4
			// (set) Token: 0x06009344 RID: 37700 RVA: 0x0004FAF6 File Offset: 0x0004DCF6
			public unsafe int item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4.NativeFieldInfoPtr_item);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4.NativeFieldInfoPtr_item)) = value;
				}
			}

			// Token: 0x17003102 RID: 12546
			// (get) Token: 0x06009345 RID: 37701 RVA: 0x0027C91C File Offset: 0x0027AB1C
			// (set) Token: 0x06009346 RID: 37702 RVA: 0x0004FB11 File Offset: 0x0004DD11
			public unsafe DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0 field_Public___c__DisplayClass35_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F8C RID: 24460
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04005F8D RID: 24461
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_0;

			// Token: 0x04005F8E RID: 24462
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F8F RID: 24463
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__16_Internal_Boolean_ValueTuple_2_Int32_PartnerType_0;
		}

		// Token: 0x02000649 RID: 1609
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPartnerSubPannel+<>c__DisplayClass35_5")]
		public sealed class __c__DisplayClass35_5 : Il2CppSystem.Object
		{
			// Token: 0x06009347 RID: 37703 RVA: 0x0027C94C File Offset: 0x0027AB4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_5()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel>.NativeClassPtr, "<>c__DisplayClass35_5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5>.NativeClassPtr);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5.NativeFieldInfoPtr_currentItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5>.NativeClassPtr, "currentItem");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5.NativeFieldInfoPtr_field_Public___c__DisplayClass35_4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5>.NativeClassPtr, "CS$<>8__locals5");
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5>.NativeClassPtr, 100667316);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5.NativeMethodInfoPtr__UpdatePartnerUI_b__19_Internal_Void_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5>.NativeClassPtr, 100667317);
				DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5>.NativeClassPtr, 100667318);
			}

			// Token: 0x06009348 RID: 37704 RVA: 0x0027C9DC File Offset: 0x0027ABDC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009349 RID: 37705 RVA: 0x0027CA18 File Offset: 0x0027AC18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62266, XrefRangeEnd = 62278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerUI_b__19(UIButtonSimple x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5.NativeMethodInfoPtr__UpdatePartnerUI_b__19_Internal_Void_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600934A RID: 37706 RVA: 0x0027CA5C File Offset: 0x0027AC5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62278, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600934B RID: 37707 RVA: 0x0004FB30 File Offset: 0x0004DD30
			public __c__DisplayClass35_5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003103 RID: 12547
			// (get) Token: 0x0600934C RID: 37708 RVA: 0x0027CA90 File Offset: 0x0027AC90
			// (set) Token: 0x0600934D RID: 37709 RVA: 0x0004FB39 File Offset: 0x0004DD39
			public unsafe int currentItem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5.NativeFieldInfoPtr_currentItem);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5.NativeFieldInfoPtr_currentItem)) = value;
				}
			}

			// Token: 0x17003104 RID: 12548
			// (get) Token: 0x0600934E RID: 37710 RVA: 0x0027CAB8 File Offset: 0x0027ACB8
			// (set) Token: 0x0600934F RID: 37711 RVA: 0x0004FB54 File Offset: 0x0004DD54
			public unsafe DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4 field_Public___c__DisplayClass35_4_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5.NativeFieldInfoPtr_field_Public___c__DisplayClass35_4_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_4>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPartnerSubPannel.__c__DisplayClass35_5.NativeFieldInfoPtr_field_Public___c__DisplayClass35_4_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F90 RID: 24464
			private static readonly IntPtr NativeFieldInfoPtr_currentItem;

			// Token: 0x04005F91 RID: 24465
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass35_4_0;

			// Token: 0x04005F92 RID: 24466
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F93 RID: 24467
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerUI_b__19_Internal_Void_UIButtonSimple_0;

			// Token: 0x04005F94 RID: 24468
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
