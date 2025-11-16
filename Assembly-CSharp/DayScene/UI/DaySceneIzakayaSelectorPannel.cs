using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020000C3 RID: 195
	public class DaySceneIzakayaSelectorPannel : UIPanel
	{
		// Token: 0x060015A3 RID: 5539 RVA: 0x000E73B8 File Offset: 0x000E55B8
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneIzakayaSelectorPannel()
		{
			Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneIzakayaSelectorPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr);
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "allSpots");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "highlight");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_switchAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "switchAudio");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_normalSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "normalSprite");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_selectdSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "selectdSprite");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_disabledSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "disabledSprite");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_gotoIzakayaButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "gotoIzakayaButton");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_noteBookBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "noteBookBtn");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_storageBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "storageBtn");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "izakayaSelections");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "izakayaName");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "description");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_cookingDeskAmount1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "cookingDeskAmount1");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_cookingDeskAmount2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "cookingDeskAmount2");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_guestTableAmount1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "guestTableAmount1");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_guestTableAmount2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "guestTableAmount2");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_characterParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "characterParent");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_characterField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "characterField");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_specialFieldParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "specialFieldParent");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_specialCharacterField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "specialCharacterField");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_multiPartnerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "multiPartnerParent");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_multiPartnerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "multiPartnerObject");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_singlePartnerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "singlePartnerObject");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_partnerField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "partnerField");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_lockedSelectionPointerParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "lockedSelectionPointerParent");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_lockedSelectionPointerField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "lockedSelectionPointerField");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_lockedSelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "lockedSelectionIndicator");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_gotoPartnerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "gotoPartnerButton");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "connections");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allLockedSelectionPointerInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "allLockedSelectionPointerInstances");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allNormalCharacterInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "allNormalCharacterInstances");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allPartnerInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "allPartnerInstances");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allSpecialCharacterInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "allSpecialCharacterInstances");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_colorBGCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "colorBGCollection");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_currentSelectedPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "currentSelectedPlace");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_deSelectHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "deSelectHandle");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_focusedMapIzakayas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "focusedMapIzakayas");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaLockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "izakayaLockType");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "izakayaMappings");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaSelectionVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "izakayaSelectionVisual");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr__partnerSelection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "<partnerSelection>k__BackingField");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr__selectedIzakayaIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "<selectedIzakayaIndex>k__BackingField");
			DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "<OpenContext>k__BackingField");
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_get_partnerSelection_Public_get_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667165);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_set_partnerSelection_Private_set_Void_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667166);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_get_PartnerData_Public_get_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667167);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_get_PartnerSelection_Public_get_IList_1_ValueTuple_2_Int32_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667168);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_get_selectedIzakayaIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667169);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_set_selectedIzakayaIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667170);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_set_CookingDeskAmount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667171);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_set_GuestTableAmount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667172);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_IzakayaConfigurePannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667173);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_IzakayaConfigurePannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667174);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667175);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OpenNotebook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667176);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OpenStorage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667177);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_TabSwitchHandler_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667178);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_SetupPartnerPannelInput_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667179);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667180);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_UpdatePartnerIndicator_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667181);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_GetEnableColor_Public_String_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667182);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667183);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OpenPartnerUI_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667184);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OpenPartnerUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667185);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_UpdateAllSpot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667186);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OnHighlight_Private_Void_List_1_Int32_IzakayaSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667187);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_UpdateCurrentIzakaya_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667188);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_Process_Private_Static_Void_UIElementCluster_ValueTuple_2_String_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667189);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_ConfirmChoiceStart_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667190);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_ConfirmChoiceEnd_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667191);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_ConfirmChoice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667192);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_LoadSelectionToIzakayaConfig_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667193);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667194);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667195);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_Method_Private_Void_UIElementCluster_ValueTuple_2_Int32_PartnerType_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667196);
			DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr__UpdateAllSpot_b__71_6_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, 100667197);
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x000E79D8 File Offset: 0x000E5BD8
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x000E7A18 File Offset: 0x000E5C18
		public unsafe Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>> partnerSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_get_partnerSelection_Public_get_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61112, XrefRangeEnd = 61113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_set_partnerSelection_Private_set_Void_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x000E7A5C File Offset: 0x000E5C5C
		public unsafe IEnumerable<int> PartnerData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_get_PartnerData_Public_get_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x000E7A9C File Offset: 0x000E5C9C
		public unsafe IList<ValueTuple<int, PartnerBase.PartnerType>> PartnerSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_get_PartnerSelection_Public_get_IList_1_ValueTuple_2_Int32_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ValueTuple<int, PartnerBase.PartnerType>>>(intPtr3) : null;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x000E7ADC File Offset: 0x000E5CDC
		// (set) Token: 0x060015A9 RID: 5545 RVA: 0x000E7B18 File Offset: 0x000E5D18
		public unsafe int selectedIzakayaIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_get_selectedIzakayaIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_set_selectedIzakayaIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000701 RID: 1793
		// (set) Token: 0x060015AA RID: 5546 RVA: 0x000E7B58 File Offset: 0x000E5D58
		public unsafe int CookingDeskAmount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61113, XrefRangeEnd = 61123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_set_CookingDeskAmount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000702 RID: 1794
		// (set) Token: 0x060015AB RID: 5547 RVA: 0x000E7B98 File Offset: 0x000E5D98
		public unsafe int GuestTableAmount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61123, XrefRangeEnd = 61133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_set_GuestTableAmount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x000E7BD8 File Offset: 0x000E5DD8
		// (set) Token: 0x060015AD RID: 5549 RVA: 0x000E7C10 File Offset: 0x000E5E10
		public unsafe DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_IzakayaConfigurePannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61133, XrefRangeEnd = 61134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_IzakayaConfigurePannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000E7C58 File Offset: 0x000E5E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61134, XrefRangeEnd = 61201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x000E7C94 File Offset: 0x000E5E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61201, XrefRangeEnd = 61208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenNotebook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OpenNotebook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x000E7CC8 File Offset: 0x000E5EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61208, XrefRangeEnd = 61215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenStorage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OpenStorage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000E7CFC File Offset: 0x000E5EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61215, XrefRangeEnd = 61227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TabSwitchHandler(InputAction.CallbackContext switchAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(switchAction));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_TabSwitchHandler_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000E7D44 File Offset: 0x000E5F44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 61237, RefRangeEnd = 61239, XrefRangeStart = 61227, XrefRangeEnd = 61237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupPartnerPannelInput(bool doReg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref doReg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_SetupPartnerPannelInput_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x000E7D84 File Offset: 0x000E5F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61239, XrefRangeEnd = 61343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000E7DC0 File Offset: 0x000E5FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61343, XrefRangeEnd = 61372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePartnerIndicator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_UpdatePartnerIndicator_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000E7DF4 File Offset: 0x000E5FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61372, XrefRangeEnd = 61374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEnableColor(PartnerBase.PartnerType jobType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref jobType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_GetEnableColor_Public_String_PartnerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000E7E38 File Offset: 0x000E6038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61374, XrefRangeEnd = 61383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x000E7E74 File Offset: 0x000E6074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61383, XrefRangeEnd = 61395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPartnerUI(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OpenPartnerUI_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x000E7EBC File Offset: 0x000E60BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPartnerUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OpenPartnerUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000E7EF0 File Offset: 0x000E60F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61564, RefRangeEnd = 61565, XrefRangeStart = 61395, XrefRangeEnd = 61564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAllSpot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_UpdateAllSpot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x000E7F24 File Offset: 0x000E6124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61620, RefRangeEnd = 61621, XrefRangeStart = 61565, XrefRangeEnd = 61620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHighlight(List<int> izakayaId, IzakayaSpot currentSelectedSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(izakayaId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentSelectedSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_OnHighlight_Private_Void_List_1_Int32_IzakayaSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x000E7F78 File Offset: 0x000E6178
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 61819, RefRangeEnd = 61822, XrefRangeStart = 61621, XrefRangeEnd = 61819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentIzakaya(int newIzakayaId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newIzakayaId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_UpdateCurrentIzakaya_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x000E7FB8 File Offset: 0x000E61B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61822, XrefRangeEnd = 61859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Process(UIElementCluster visual, ValueTuple<string, CharacterSpriteSetCompact> data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_Process_Private_Static_Void_UIElementCluster_ValueTuple_2_String_CharacterSpriteSetCompact_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x000E8008 File Offset: 0x000E6208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61859, XrefRangeEnd = 61863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmChoiceStart(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_ConfirmChoiceStart_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x000E8050 File Offset: 0x000E6250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61863, XrefRangeEnd = 61865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmChoiceEnd(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_ConfirmChoiceEnd_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x000E8098 File Offset: 0x000E6298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61865, XrefRangeEnd = 61893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmChoice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_ConfirmChoice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x000E80CC File Offset: 0x000E62CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61893, XrefRangeEnd = 61904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSelectionToIzakayaConfig()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_LoadSelectionToIzakayaConfig_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x000E8100 File Offset: 0x000E6300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61904, XrefRangeEnd = 61950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x000E813C File Offset: 0x000E633C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61950, XrefRangeEnd = 62000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneIzakayaSelectorPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x000E8178 File Offset: 0x000E6378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62000, XrefRangeEnd = 62069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_UIElementCluster_ValueTuple_2_Int32_PartnerType_PDM_0(UIElementCluster elementCluster, ValueTuple<int, PartnerBase.PartnerType> partnerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementCluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(partnerData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr_Method_Private_Void_UIElementCluster_ValueTuple_2_Int32_PartnerType_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x000E81D4 File Offset: 0x000E63D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62069, XrefRangeEnd = 62077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdateAllSpot_b__71_6(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.NativeMethodInfoPtr__UpdateAllSpot_b__71_6_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0000D75B File Offset: 0x0000B95B
		public DaySceneIzakayaSelectorPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x000E8220 File Offset: 0x000E6420
		// (set) Token: 0x060015C7 RID: 5575 RVA: 0x0000D764 File Offset: 0x0000B964
		public unsafe Il2CppReferenceArray<IzakayaSpot> allSpots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allSpots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IzakayaSpot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allSpots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x000E8250 File Offset: 0x000E6450
		// (set) Token: 0x060015C9 RID: 5577 RVA: 0x0000D783 File Offset: 0x0000B983
		public unsafe GameObject highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_highlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x000E8280 File Offset: 0x000E6480
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x0000D7A2 File Offset: 0x0000B9A2
		public unsafe AudioClip switchAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_switchAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_switchAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x000E82B0 File Offset: 0x000E64B0
		// (set) Token: 0x060015CD RID: 5581 RVA: 0x0000D7C1 File Offset: 0x0000B9C1
		public unsafe Sprite normalSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_normalSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_normalSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x000E82E0 File Offset: 0x000E64E0
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
		public unsafe Sprite selectdSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_selectdSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_selectdSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x000E8310 File Offset: 0x000E6510
		// (set) Token: 0x060015D1 RID: 5585 RVA: 0x0000D7FF File Offset: 0x0000B9FF
		public unsafe Sprite disabledSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_disabledSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_disabledSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x000E8340 File Offset: 0x000E6540
		// (set) Token: 0x060015D3 RID: 5587 RVA: 0x0000D81E File Offset: 0x0000BA1E
		public unsafe UIButtonHold gotoIzakayaButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_gotoIzakayaButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_gotoIzakayaButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x000E8370 File Offset: 0x000E6570
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x0000D83D File Offset: 0x0000BA3D
		public unsafe UIButtonSimple noteBookBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_noteBookBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_noteBookBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x000E83A0 File Offset: 0x000E65A0
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x0000D85C File Offset: 0x0000BA5C
		public unsafe UIButtonSimple storageBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_storageBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_storageBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x000E83D0 File Offset: 0x000E65D0
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x0000D87B File Offset: 0x0000BA7B
		public unsafe Il2CppReferenceArray<UIButtonSimple> izakayaSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x000E8400 File Offset: 0x000E6600
		// (set) Token: 0x060015DB RID: 5595 RVA: 0x0000D89A File Offset: 0x0000BA9A
		public unsafe TextMeshProUGUI izakayaName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x000E8430 File Offset: 0x000E6630
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x0000D8B9 File Offset: 0x0000BAB9
		public unsafe TextMeshProUGUI description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_description);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x000E8460 File Offset: 0x000E6660
		// (set) Token: 0x060015DF RID: 5599 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
		public unsafe TextMeshProUGUI cookingDeskAmount1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_cookingDeskAmount1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_cookingDeskAmount1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x000E8490 File Offset: 0x000E6690
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x0000D8F7 File Offset: 0x0000BAF7
		public unsafe TextMeshProUGUI cookingDeskAmount2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_cookingDeskAmount2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_cookingDeskAmount2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x000E84C0 File Offset: 0x000E66C0
		// (set) Token: 0x060015E3 RID: 5603 RVA: 0x0000D916 File Offset: 0x0000BB16
		public unsafe TextMeshProUGUI guestTableAmount1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_guestTableAmount1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_guestTableAmount1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x000E84F0 File Offset: 0x000E66F0
		// (set) Token: 0x060015E5 RID: 5605 RVA: 0x0000D935 File Offset: 0x0000BB35
		public unsafe TextMeshProUGUI guestTableAmount2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_guestTableAmount2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_guestTableAmount2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x000E8520 File Offset: 0x000E6720
		// (set) Token: 0x060015E7 RID: 5607 RVA: 0x0000D954 File Offset: 0x0000BB54
		public unsafe GameObject characterParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_characterParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_characterParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x000E8550 File Offset: 0x000E6750
		// (set) Token: 0x060015E9 RID: 5609 RVA: 0x0000D973 File Offset: 0x0000BB73
		public unsafe RectTransform characterField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_characterField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_characterField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060015EA RID: 5610 RVA: 0x000E8580 File Offset: 0x000E6780
		// (set) Token: 0x060015EB RID: 5611 RVA: 0x0000D992 File Offset: 0x0000BB92
		public unsafe GameObject specialFieldParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_specialFieldParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_specialFieldParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x000E85B0 File Offset: 0x000E67B0
		// (set) Token: 0x060015ED RID: 5613 RVA: 0x0000D9B1 File Offset: 0x0000BBB1
		public unsafe RectTransform specialCharacterField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_specialCharacterField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_specialCharacterField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x000E85E0 File Offset: 0x000E67E0
		// (set) Token: 0x060015EF RID: 5615 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
		public unsafe GameObject multiPartnerParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_multiPartnerParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_multiPartnerParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x000E8610 File Offset: 0x000E6810
		// (set) Token: 0x060015F1 RID: 5617 RVA: 0x0000D9EF File Offset: 0x0000BBEF
		public unsafe GameObject multiPartnerObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_multiPartnerObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_multiPartnerObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x000E8640 File Offset: 0x000E6840
		// (set) Token: 0x060015F3 RID: 5619 RVA: 0x0000DA0E File Offset: 0x0000BC0E
		public unsafe GameObject singlePartnerObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_singlePartnerObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_singlePartnerObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x000E8670 File Offset: 0x000E6870
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x0000DA2D File Offset: 0x0000BC2D
		public unsafe RectTransform partnerField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_partnerField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_partnerField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x000E86A0 File Offset: 0x000E68A0
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x0000DA4C File Offset: 0x0000BC4C
		public unsafe GameObject lockedSelectionPointerParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_lockedSelectionPointerParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_lockedSelectionPointerParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x000E86D0 File Offset: 0x000E68D0
		// (set) Token: 0x060015F9 RID: 5625 RVA: 0x0000DA6B File Offset: 0x0000BC6B
		public unsafe RectTransform lockedSelectionPointerField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_lockedSelectionPointerField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_lockedSelectionPointerField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x000E8700 File Offset: 0x000E6900
		// (set) Token: 0x060015FB RID: 5627 RVA: 0x0000DA8A File Offset: 0x0000BC8A
		public unsafe GameObject lockedSelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_lockedSelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_lockedSelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x000E8730 File Offset: 0x000E6930
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x0000DAA9 File Offset: 0x0000BCA9
		public unsafe UIButtonSimple gotoPartnerButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_gotoPartnerButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_gotoPartnerButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x000E8760 File Offset: 0x000E6960
		// (set) Token: 0x060015FF RID: 5631 RVA: 0x0000DAC8 File Offset: 0x0000BCC8
		public unsafe Il2CppReferenceArray<DaySceneIzakayaSelectorPannel.Connection> connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DaySceneIzakayaSelectorPannel.Connection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x000E8790 File Offset: 0x000E6990
		// (set) Token: 0x06001601 RID: 5633 RVA: 0x0000DAE7 File Offset: 0x0000BCE7
		public unsafe List<GameObject> allLockedSelectionPointerInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allLockedSelectionPointerInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allLockedSelectionPointerInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x000E87C0 File Offset: 0x000E69C0
		// (set) Token: 0x06001603 RID: 5635 RVA: 0x0000DB06 File Offset: 0x0000BD06
		public unsafe List<GameObject> allNormalCharacterInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allNormalCharacterInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allNormalCharacterInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x000E87F0 File Offset: 0x000E69F0
		// (set) Token: 0x06001605 RID: 5637 RVA: 0x0000DB25 File Offset: 0x0000BD25
		public unsafe List<GameObject> allPartnerInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allPartnerInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allPartnerInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x000E8820 File Offset: 0x000E6A20
		// (set) Token: 0x06001607 RID: 5639 RVA: 0x0000DB44 File Offset: 0x0000BD44
		public unsafe List<GameObject> allSpecialCharacterInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allSpecialCharacterInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_allSpecialCharacterInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x000E8850 File Offset: 0x000E6A50
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x0000DB63 File Offset: 0x0000BD63
		public unsafe Il2CppStringArray colorBGCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_colorBGCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_colorBGCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x000E8880 File Offset: 0x000E6A80
		// (set) Token: 0x0600160B RID: 5643 RVA: 0x0000DB82 File Offset: 0x0000BD82
		public unsafe string currentSelectedPlace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_currentSelectedPlace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_currentSelectedPlace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x000E88A8 File Offset: 0x000E6AA8
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x0000DBA1 File Offset: 0x0000BDA1
		public unsafe Action deSelectHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_deSelectHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_deSelectHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x000E88D8 File Offset: 0x000E6AD8
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		public unsafe List<int> focusedMapIzakayas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_focusedMapIzakayas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_focusedMapIzakayas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x000E8908 File Offset: 0x000E6B08
		// (set) Token: 0x06001611 RID: 5649 RVA: 0x0000DBDF File Offset: 0x0000BDDF
		public unsafe SchedulerNode.Trigger.IzakayaLockType izakayaLockType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaLockType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaLockType)) = value;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x000E8930 File Offset: 0x000E6B30
		// (set) Token: 0x06001613 RID: 5651 RVA: 0x0000DBFA File Offset: 0x0000BDFA
		public unsafe Dictionary<int, int> izakayaMappings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaMappings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaMappings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x000E8960 File Offset: 0x000E6B60
		// (set) Token: 0x06001615 RID: 5653 RVA: 0x0000DC19 File Offset: 0x0000BE19
		public unsafe Il2CppReferenceArray<Image> izakayaSelectionVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaSelectionVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr_izakayaSelectionVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x000E8990 File Offset: 0x000E6B90
		// (set) Token: 0x06001617 RID: 5655 RVA: 0x0000DC38 File Offset: 0x0000BE38
		public unsafe Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>> _partnerSelection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr__partnerSelection_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr__partnerSelection_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x000E89C0 File Offset: 0x000E6BC0
		// (set) Token: 0x06001619 RID: 5657 RVA: 0x0000DC57 File Offset: 0x0000BE57
		public unsafe int _selectedIzakayaIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr__selectedIzakayaIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr__selectedIzakayaIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x000E89E8 File Offset: 0x000E6BE8
		// (set) Token: 0x0600161B RID: 5659 RVA: 0x0000DC72 File Offset: 0x0000BE72
		public DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeFieldInfoPtr_allSpots;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeFieldInfoPtr_highlight;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeFieldInfoPtr_switchAudio;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeFieldInfoPtr_normalSprite;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeFieldInfoPtr_selectdSprite;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeFieldInfoPtr_disabledSprite;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeFieldInfoPtr_gotoIzakayaButton;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeFieldInfoPtr_noteBookBtn;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeFieldInfoPtr_storageBtn;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeFieldInfoPtr_izakayaSelections;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeFieldInfoPtr_izakayaName;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeFieldInfoPtr_cookingDeskAmount1;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeFieldInfoPtr_cookingDeskAmount2;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeFieldInfoPtr_guestTableAmount1;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeFieldInfoPtr_guestTableAmount2;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeFieldInfoPtr_characterParent;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeFieldInfoPtr_characterField;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeFieldInfoPtr_specialFieldParent;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeFieldInfoPtr_specialCharacterField;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeFieldInfoPtr_multiPartnerParent;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeFieldInfoPtr_multiPartnerObject;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeFieldInfoPtr_singlePartnerObject;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeFieldInfoPtr_partnerField;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeFieldInfoPtr_lockedSelectionPointerParent;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeFieldInfoPtr_lockedSelectionPointerField;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeFieldInfoPtr_lockedSelectionIndicator;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeFieldInfoPtr_gotoPartnerButton;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeFieldInfoPtr_allLockedSelectionPointerInstances;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeFieldInfoPtr_allNormalCharacterInstances;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeFieldInfoPtr_allPartnerInstances;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeFieldInfoPtr_allSpecialCharacterInstances;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeFieldInfoPtr_colorBGCollection;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeFieldInfoPtr_currentSelectedPlace;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeFieldInfoPtr_deSelectHandle;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeFieldInfoPtr_focusedMapIzakayas;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeFieldInfoPtr_izakayaLockType;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeFieldInfoPtr_izakayaMappings;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeFieldInfoPtr_izakayaSelectionVisual;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeFieldInfoPtr__partnerSelection_k__BackingField;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeFieldInfoPtr__selectedIzakayaIndex_k__BackingField;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_get_partnerSelection_Public_get_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_0;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr_set_partnerSelection_Private_set_Void_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerData_Public_get_IEnumerable_1_Int32_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerSelection_Public_get_IList_1_ValueTuple_2_Int32_PartnerType_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedIzakayaIndex_Public_get_Int32_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedIzakayaIndex_Private_set_Void_Int32_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_set_CookingDeskAmount_Private_set_Void_Int32_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_set_GuestTableAmount_Private_set_Void_Int32_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_IzakayaConfigurePannelOpenContext_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_IzakayaConfigurePannelOpenContext_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_OpenNotebook_Private_Void_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_OpenStorage_Private_Void_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_TabSwitchHandler_Private_Void_CallbackContext_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_SetupPartnerPannelInput_Private_Void_Boolean_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePartnerIndicator_Public_Void_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_GetEnableColor_Public_String_PartnerType_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_OpenPartnerUI_Private_Void_CallbackContext_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_OpenPartnerUI_Private_Void_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAllSpot_Private_Void_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_OnHighlight_Private_Void_List_1_Int32_IzakayaSpot_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentIzakaya_Private_Void_Int32_0;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_Process_Private_Static_Void_UIElementCluster_ValueTuple_2_String_CharacterSpriteSetCompact_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmChoiceStart_Private_Void_CallbackContext_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmChoiceEnd_Private_Void_CallbackContext_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmChoice_Private_Void_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_LoadSelectionToIzakayaConfig_Private_Void_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_UIElementCluster_ValueTuple_2_Int32_PartnerType_PDM_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr__UpdateAllSpot_b__71_6_Private_Boolean_Int32_0;

		// Token: 0x02000630 RID: 1584
		public sealed class IzakayaConfigurePannelOpenContext : ValueType
		{
			// Token: 0x0600921D RID: 37405 RVA: 0x00279204 File Offset: 0x00277404
			// Note: this type is marked as 'beforefieldinit'.
			static IzakayaConfigurePannelOpenContext()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "IzakayaConfigurePannelOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext>.NativeClassPtr);
				DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext.NativeFieldInfoPtr_LockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext>.NativeClassPtr, "LockType");
				DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext.NativeFieldInfoPtr_Mappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext>.NativeClassPtr, "Mappings");
				DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext.NativeFieldInfoPtr_PartnerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext>.NativeClassPtr, "PartnerData");
				DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IzakayaLockType_Il2CppStructArray_1_IzakayaMapping_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext>.NativeClassPtr, 100667198);
			}

			// Token: 0x0600921E RID: 37406 RVA: 0x00279280 File Offset: 0x00277480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61009, XrefRangeEnd = 61018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IzakayaConfigurePannelOpenContext(SchedulerNode.Trigger.IzakayaLockType lockType, Il2CppStructArray<SchedulerNode.Trigger.IzakayaMapping> mappings, IEnumerable<int> partnerData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref lockType;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mappings);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_IzakayaLockType_Il2CppStructArray_1_IzakayaMapping_IEnumerable_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600921F RID: 37407 RVA: 0x0004F25F File Offset: 0x0004D45F
			public IzakayaConfigurePannelOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009220 RID: 37408 RVA: 0x0004F268 File Offset: 0x0004D468
			public IzakayaConfigurePannelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x170030B6 RID: 12470
			// (get) Token: 0x06009221 RID: 37409 RVA: 0x002792F0 File Offset: 0x002774F0
			// (set) Token: 0x06009222 RID: 37410 RVA: 0x0004F27A File Offset: 0x0004D47A
			public unsafe SchedulerNode.Trigger.IzakayaLockType LockType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext.NativeFieldInfoPtr_LockType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext.NativeFieldInfoPtr_LockType)) = value;
				}
			}

			// Token: 0x170030B7 RID: 12471
			// (get) Token: 0x06009223 RID: 37411 RVA: 0x00279318 File Offset: 0x00277518
			// (set) Token: 0x06009224 RID: 37412 RVA: 0x0004F295 File Offset: 0x0004D495
			public unsafe Il2CppStructArray<SchedulerNode.Trigger.IzakayaMapping> Mappings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext.NativeFieldInfoPtr_Mappings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SchedulerNode.Trigger.IzakayaMapping>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext.NativeFieldInfoPtr_Mappings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030B8 RID: 12472
			// (get) Token: 0x06009225 RID: 37413 RVA: 0x00279348 File Offset: 0x00277548
			// (set) Token: 0x06009226 RID: 37414 RVA: 0x0004F2B4 File Offset: 0x0004D4B4
			public unsafe IEnumerable<int> PartnerData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext.NativeFieldInfoPtr_PartnerData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext.NativeFieldInfoPtr_PartnerData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005EE8 RID: 24296
			private static readonly IntPtr NativeFieldInfoPtr_LockType;

			// Token: 0x04005EE9 RID: 24297
			private static readonly IntPtr NativeFieldInfoPtr_Mappings;

			// Token: 0x04005EEA RID: 24298
			private static readonly IntPtr NativeFieldInfoPtr_PartnerData;

			// Token: 0x04005EEB RID: 24299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IzakayaLockType_Il2CppStructArray_1_IzakayaMapping_IEnumerable_1_Int32_0;
		}

		// Token: 0x02000631 RID: 1585
		[Serializable]
		public sealed class Connection : ValueType
		{
			// Token: 0x06009227 RID: 37415 RVA: 0x00279378 File Offset: 0x00277578
			// Note: this type is marked as 'beforefieldinit'.
			static Connection()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.Connection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "Connection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.Connection>.NativeClassPtr);
				DaySceneIzakayaSelectorPannel.Connection.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.Connection>.NativeClassPtr, "a");
				DaySceneIzakayaSelectorPannel.Connection.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.Connection>.NativeClassPtr, "b");
				DaySceneIzakayaSelectorPannel.Connection.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.Connection>.NativeClassPtr, "visual");
			}

			// Token: 0x06009228 RID: 37416 RVA: 0x0004F2D3 File Offset: 0x0004D4D3
			public Connection(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009229 RID: 37417 RVA: 0x0004F2DC File Offset: 0x0004D4DC
			public Connection() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.Connection>.NativeClassPtr))
			{
			}

			// Token: 0x170030B9 RID: 12473
			// (get) Token: 0x0600922A RID: 37418 RVA: 0x002793E0 File Offset: 0x002775E0
			// (set) Token: 0x0600922B RID: 37419 RVA: 0x0004F2EE File Offset: 0x0004D4EE
			public unsafe IzakayaSpot a
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.Connection.NativeFieldInfoPtr_a);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.Connection.NativeFieldInfoPtr_a), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030BA RID: 12474
			// (get) Token: 0x0600922C RID: 37420 RVA: 0x00279410 File Offset: 0x00277610
			// (set) Token: 0x0600922D RID: 37421 RVA: 0x0004F30D File Offset: 0x0004D50D
			public unsafe IzakayaSpot b
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.Connection.NativeFieldInfoPtr_b);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.Connection.NativeFieldInfoPtr_b), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030BB RID: 12475
			// (get) Token: 0x0600922E RID: 37422 RVA: 0x00279440 File Offset: 0x00277640
			// (set) Token: 0x0600922F RID: 37423 RVA: 0x0004F32C File Offset: 0x0004D52C
			public unsafe Image visual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.Connection.NativeFieldInfoPtr_visual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.Connection.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005EEC RID: 24300
			private static readonly IntPtr NativeFieldInfoPtr_a;

			// Token: 0x04005EED RID: 24301
			private static readonly IntPtr NativeFieldInfoPtr_b;

			// Token: 0x04005EEE RID: 24302
			private static readonly IntPtr NativeFieldInfoPtr_visual;
		}

		// Token: 0x02000632 RID: 1586
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009230 RID: 37424 RVA: 0x00279470 File Offset: 0x00277670
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr);
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__65_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__65_0");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__65_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__65_1");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__71_0");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__71_1");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__71_5");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__71_2");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__71_3");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__71_4");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__72_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__72_0");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__73_8");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__73_1");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__73_2");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__73_3");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__73_4");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__73_6");
				DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, "<>9__73_7");
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667200);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__65_0_Internal_Int32_IzakayaMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667201);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__65_1_Internal_Int32_IzakayaMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667202);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateAllSpot_b__71_0_Internal_Void_IzakayaSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667203);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateAllSpot_b__71_1_Internal_Image_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667204);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateAllSpot_b__71_5_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667205);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateAllSpot_b__71_2_Internal_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667206);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateAllSpot_b__71_3_Internal_Boolean_IzakayaSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667207);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateAllSpot_b__71_4_Internal_Boolean_IzakayaSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667208);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__OnHighlight_b__72_0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667209);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_1_Internal_IEnumerable_1_NormalGuest_NormalGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667210);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_8_Internal_IEnumerable_1_NormalGuest_IEnumerable_1_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667211);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_2_Internal_NormalGuest_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667212);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_3_Internal_Int32_IGrouping_2_NormalGuest_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667213);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_4_Internal_ValueTuple_2_String_CharacterSpriteSetCompact_IGrouping_2_NormalGuest_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667214);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_6_Internal_Boolean_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667215);
				DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_7_Internal_ValueTuple_2_String_CharacterSpriteSetCompact_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr, 100667216);
			}

			// Token: 0x06009231 RID: 37425 RVA: 0x00279744 File Offset: 0x00277944
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009232 RID: 37426 RVA: 0x00279780 File Offset: 0x00277980
			[CallerCount(0)]
			public unsafe int _OnPanelOpen_b__65_0(SchedulerNode.Trigger.IzakayaMapping x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__65_0_Internal_Int32_IzakayaMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009233 RID: 37427 RVA: 0x002797CC File Offset: 0x002779CC
			[CallerCount(0)]
			public unsafe int _OnPanelOpen_b__65_1(SchedulerNode.Trigger.IzakayaMapping x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__65_1_Internal_Int32_IzakayaMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009234 RID: 37428 RVA: 0x00279818 File Offset: 0x00277A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61018, XrefRangeEnd = 61020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateAllSpot_b__71_0(IzakayaSpot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateAllSpot_b__71_0_Internal_Void_IzakayaSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009235 RID: 37429 RVA: 0x0027985C File Offset: 0x00277A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61020, XrefRangeEnd = 61022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Image _UpdateAllSpot_b__71_1(UIButtonSimple x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateAllSpot_b__71_1_Internal_Image_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}

			// Token: 0x06009236 RID: 37430 RVA: 0x002798AC File Offset: 0x00277AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61022, XrefRangeEnd = 61023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateAllSpot_b__71_5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateAllSpot_b__71_5_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009237 RID: 37431 RVA: 0x002798F8 File Offset: 0x00277AF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61023, XrefRangeEnd = 61024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateAllSpot_b__71_2(Transform component, Vector3 value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateAllSpot_b__71_2_Internal_Void_Transform_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009238 RID: 37432 RVA: 0x00279948 File Offset: 0x00277B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61024, XrefRangeEnd = 61026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateAllSpot_b__71_3(IzakayaSpot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateAllSpot_b__71_3_Internal_Boolean_IzakayaSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009239 RID: 37433 RVA: 0x00279998 File Offset: 0x00277B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateAllSpot_b__71_4(IzakayaSpot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateAllSpot_b__71_4_Internal_Boolean_IzakayaSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600923A RID: 37434 RVA: 0x002799E8 File Offset: 0x00277BE8
			[CallerCount(0)]
			public unsafe bool _OnHighlight_b__72_0(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__OnHighlight_b__72_0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600923B RID: 37435 RVA: 0x00279A34 File Offset: 0x00277C34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61026, XrefRangeEnd = 61046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<NormalGuest> _UpdateCurrentIzakaya_b__73_1(Izakaya.NormalGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_1_Internal_IEnumerable_1_NormalGuest_NormalGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NormalGuest>>(intPtr3) : null;
			}

			// Token: 0x0600923C RID: 37436 RVA: 0x00279A84 File Offset: 0x00277C84
			[CallerCount(0)]
			public unsafe IEnumerable<NormalGuest> _UpdateCurrentIzakaya_b__73_8(IEnumerable<NormalGuest> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_8_Internal_IEnumerable_1_NormalGuest_IEnumerable_1_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NormalGuest>>(intPtr3) : null;
			}

			// Token: 0x0600923D RID: 37437 RVA: 0x00279AD4 File Offset: 0x00277CD4
			[CallerCount(0)]
			public unsafe NormalGuest _UpdateCurrentIzakaya_b__73_2(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_2_Internal_NormalGuest_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NormalGuest>(intPtr3) : null;
			}

			// Token: 0x0600923E RID: 37438 RVA: 0x00279B24 File Offset: 0x00277D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61046, XrefRangeEnd = 61049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _UpdateCurrentIzakaya_b__73_3(IGrouping<NormalGuest, NormalGuest> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_3_Internal_Int32_IGrouping_2_NormalGuest_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600923F RID: 37439 RVA: 0x00279B74 File Offset: 0x00277D74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61049, XrefRangeEnd = 61058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<string, CharacterSpriteSetCompact> _UpdateCurrentIzakaya_b__73_4(IGrouping<NormalGuest, NormalGuest> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_4_Internal_ValueTuple_2_String_CharacterSpriteSetCompact_IGrouping_2_NormalGuest_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<string, CharacterSpriteSetCompact>(pointer);
			}

			// Token: 0x06009240 RID: 37440 RVA: 0x00279BBC File Offset: 0x00277DBC
			[CallerCount(0)]
			public unsafe bool _UpdateCurrentIzakaya_b__73_6(Izakaya.SpecialGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_6_Internal_Boolean_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009241 RID: 37441 RVA: 0x00279C0C File Offset: 0x00277E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61058, XrefRangeEnd = 61067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<string, CharacterSpriteSetCompact> _UpdateCurrentIzakaya_b__73_7(Izakaya.SpecialGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_7_Internal_ValueTuple_2_String_CharacterSpriteSetCompact_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<string, CharacterSpriteSetCompact>(pointer);
			}

			// Token: 0x06009242 RID: 37442 RVA: 0x0004F34B File Offset: 0x0004D54B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030BC RID: 12476
			// (get) Token: 0x06009243 RID: 37443 RVA: 0x00279C54 File Offset: 0x00277E54
			// (set) Token: 0x06009244 RID: 37444 RVA: 0x0004F354 File Offset: 0x0004D554
			public unsafe static DaySceneIzakayaSelectorPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneIzakayaSelectorPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030BD RID: 12477
			// (get) Token: 0x06009245 RID: 37445 RVA: 0x00279C7C File Offset: 0x00277E7C
			// (set) Token: 0x06009246 RID: 37446 RVA: 0x0004F366 File Offset: 0x0004D566
			public unsafe static Func<SchedulerNode.Trigger.IzakayaMapping, int> __9__65_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__65_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SchedulerNode.Trigger.IzakayaMapping, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__65_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030BE RID: 12478
			// (get) Token: 0x06009247 RID: 37447 RVA: 0x00279CA4 File Offset: 0x00277EA4
			// (set) Token: 0x06009248 RID: 37448 RVA: 0x0004F378 File Offset: 0x0004D578
			public unsafe static Func<SchedulerNode.Trigger.IzakayaMapping, int> __9__65_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__65_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SchedulerNode.Trigger.IzakayaMapping, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__65_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030BF RID: 12479
			// (get) Token: 0x06009249 RID: 37449 RVA: 0x00279CCC File Offset: 0x00277ECC
			// (set) Token: 0x0600924A RID: 37450 RVA: 0x0004F38A File Offset: 0x0004D58A
			public unsafe static Action<IzakayaSpot> __9__71_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IzakayaSpot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030C0 RID: 12480
			// (get) Token: 0x0600924B RID: 37451 RVA: 0x00279CF4 File Offset: 0x00277EF4
			// (set) Token: 0x0600924C RID: 37452 RVA: 0x0004F39C File Offset: 0x0004D59C
			public unsafe static Func<UIButtonSimple, Image> __9__71_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UIButtonSimple, Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030C1 RID: 12481
			// (get) Token: 0x0600924D RID: 37453 RVA: 0x00279D1C File Offset: 0x00277F1C
			// (set) Token: 0x0600924E RID: 37454 RVA: 0x0004F3AE File Offset: 0x0004D5AE
			public unsafe static Func<int, bool> __9__71_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030C2 RID: 12482
			// (get) Token: 0x0600924F RID: 37455 RVA: 0x00279D44 File Offset: 0x00277F44
			// (set) Token: 0x06009250 RID: 37456 RVA: 0x0004F3C0 File Offset: 0x0004D5C0
			public unsafe static Action<Transform, Vector3> __9__71_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Transform, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030C3 RID: 12483
			// (get) Token: 0x06009251 RID: 37457 RVA: 0x00279D6C File Offset: 0x00277F6C
			// (set) Token: 0x06009252 RID: 37458 RVA: 0x0004F3D2 File Offset: 0x0004D5D2
			public unsafe static Func<IzakayaSpot, bool> __9__71_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IzakayaSpot, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030C4 RID: 12484
			// (get) Token: 0x06009253 RID: 37459 RVA: 0x00279D94 File Offset: 0x00277F94
			// (set) Token: 0x06009254 RID: 37460 RVA: 0x0004F3E4 File Offset: 0x0004D5E4
			public unsafe static Func<IzakayaSpot, bool> __9__71_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IzakayaSpot, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__71_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030C5 RID: 12485
			// (get) Token: 0x06009255 RID: 37461 RVA: 0x00279DBC File Offset: 0x00277FBC
			// (set) Token: 0x06009256 RID: 37462 RVA: 0x0004F3F6 File Offset: 0x0004D5F6
			public unsafe static Func<int, bool> __9__72_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__72_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__72_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030C6 RID: 12486
			// (get) Token: 0x06009257 RID: 37463 RVA: 0x00279DE4 File Offset: 0x00277FE4
			// (set) Token: 0x06009258 RID: 37464 RVA: 0x0004F408 File Offset: 0x0004D608
			public unsafe static Func<IEnumerable<NormalGuest>, IEnumerable<NormalGuest>> __9__73_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<NormalGuest>, IEnumerable<NormalGuest>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030C7 RID: 12487
			// (get) Token: 0x06009259 RID: 37465 RVA: 0x00279E0C File Offset: 0x0027800C
			// (set) Token: 0x0600925A RID: 37466 RVA: 0x0004F41A File Offset: 0x0004D61A
			public unsafe static Func<Izakaya.NormalGuestGroup, IEnumerable<NormalGuest>> __9__73_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.NormalGuestGroup, IEnumerable<NormalGuest>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030C8 RID: 12488
			// (get) Token: 0x0600925B RID: 37467 RVA: 0x00279E34 File Offset: 0x00278034
			// (set) Token: 0x0600925C RID: 37468 RVA: 0x0004F42C File Offset: 0x0004D62C
			public unsafe static Func<NormalGuest, NormalGuest> __9__73_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, NormalGuest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030C9 RID: 12489
			// (get) Token: 0x0600925D RID: 37469 RVA: 0x00279E5C File Offset: 0x0027805C
			// (set) Token: 0x0600925E RID: 37470 RVA: 0x0004F43E File Offset: 0x0004D63E
			public unsafe static Func<IGrouping<NormalGuest, NormalGuest>, int> __9__73_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<NormalGuest, NormalGuest>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030CA RID: 12490
			// (get) Token: 0x0600925F RID: 37471 RVA: 0x00279E84 File Offset: 0x00278084
			// (set) Token: 0x06009260 RID: 37472 RVA: 0x0004F450 File Offset: 0x0004D650
			public unsafe static Func<IGrouping<NormalGuest, NormalGuest>, ValueTuple<string, CharacterSpriteSetCompact>> __9__73_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<NormalGuest, NormalGuest>, ValueTuple<string, CharacterSpriteSetCompact>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030CB RID: 12491
			// (get) Token: 0x06009261 RID: 37473 RVA: 0x00279EAC File Offset: 0x002780AC
			// (set) Token: 0x06009262 RID: 37474 RVA: 0x0004F462 File Offset: 0x0004D662
			public unsafe static Func<Izakaya.SpecialGuestGroup, bool> __9__73_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.SpecialGuestGroup, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030CC RID: 12492
			// (get) Token: 0x06009263 RID: 37475 RVA: 0x00279ED4 File Offset: 0x002780D4
			// (set) Token: 0x06009264 RID: 37476 RVA: 0x0004F474 File Offset: 0x0004D674
			public unsafe static Func<Izakaya.SpecialGuestGroup, ValueTuple<string, CharacterSpriteSetCompact>> __9__73_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.SpecialGuestGroup, ValueTuple<string, CharacterSpriteSetCompact>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneIzakayaSelectorPannel.__c.NativeFieldInfoPtr___9__73_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005EEF RID: 24303
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005EF0 RID: 24304
			private static readonly IntPtr NativeFieldInfoPtr___9__65_0;

			// Token: 0x04005EF1 RID: 24305
			private static readonly IntPtr NativeFieldInfoPtr___9__65_1;

			// Token: 0x04005EF2 RID: 24306
			private static readonly IntPtr NativeFieldInfoPtr___9__71_0;

			// Token: 0x04005EF3 RID: 24307
			private static readonly IntPtr NativeFieldInfoPtr___9__71_1;

			// Token: 0x04005EF4 RID: 24308
			private static readonly IntPtr NativeFieldInfoPtr___9__71_5;

			// Token: 0x04005EF5 RID: 24309
			private static readonly IntPtr NativeFieldInfoPtr___9__71_2;

			// Token: 0x04005EF6 RID: 24310
			private static readonly IntPtr NativeFieldInfoPtr___9__71_3;

			// Token: 0x04005EF7 RID: 24311
			private static readonly IntPtr NativeFieldInfoPtr___9__71_4;

			// Token: 0x04005EF8 RID: 24312
			private static readonly IntPtr NativeFieldInfoPtr___9__72_0;

			// Token: 0x04005EF9 RID: 24313
			private static readonly IntPtr NativeFieldInfoPtr___9__73_8;

			// Token: 0x04005EFA RID: 24314
			private static readonly IntPtr NativeFieldInfoPtr___9__73_1;

			// Token: 0x04005EFB RID: 24315
			private static readonly IntPtr NativeFieldInfoPtr___9__73_2;

			// Token: 0x04005EFC RID: 24316
			private static readonly IntPtr NativeFieldInfoPtr___9__73_3;

			// Token: 0x04005EFD RID: 24317
			private static readonly IntPtr NativeFieldInfoPtr___9__73_4;

			// Token: 0x04005EFE RID: 24318
			private static readonly IntPtr NativeFieldInfoPtr___9__73_6;

			// Token: 0x04005EFF RID: 24319
			private static readonly IntPtr NativeFieldInfoPtr___9__73_7;

			// Token: 0x04005F00 RID: 24320
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F01 RID: 24321
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__65_0_Internal_Int32_IzakayaMapping_0;

			// Token: 0x04005F02 RID: 24322
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__65_1_Internal_Int32_IzakayaMapping_0;

			// Token: 0x04005F03 RID: 24323
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAllSpot_b__71_0_Internal_Void_IzakayaSpot_0;

			// Token: 0x04005F04 RID: 24324
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAllSpot_b__71_1_Internal_Image_UIButtonSimple_0;

			// Token: 0x04005F05 RID: 24325
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAllSpot_b__71_5_Internal_Boolean_Int32_0;

			// Token: 0x04005F06 RID: 24326
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAllSpot_b__71_2_Internal_Void_Transform_Vector3_0;

			// Token: 0x04005F07 RID: 24327
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAllSpot_b__71_3_Internal_Boolean_IzakayaSpot_0;

			// Token: 0x04005F08 RID: 24328
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAllSpot_b__71_4_Internal_Boolean_IzakayaSpot_0;

			// Token: 0x04005F09 RID: 24329
			private static readonly IntPtr NativeMethodInfoPtr__OnHighlight_b__72_0_Internal_Boolean_Int32_0;

			// Token: 0x04005F0A RID: 24330
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_1_Internal_IEnumerable_1_NormalGuest_NormalGuestGroup_0;

			// Token: 0x04005F0B RID: 24331
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_8_Internal_IEnumerable_1_NormalGuest_IEnumerable_1_NormalGuest_0;

			// Token: 0x04005F0C RID: 24332
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_2_Internal_NormalGuest_NormalGuest_0;

			// Token: 0x04005F0D RID: 24333
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_3_Internal_Int32_IGrouping_2_NormalGuest_NormalGuest_0;

			// Token: 0x04005F0E RID: 24334
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_4_Internal_ValueTuple_2_String_CharacterSpriteSetCompact_IGrouping_2_NormalGuest_NormalGuest_0;

			// Token: 0x04005F0F RID: 24335
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_6_Internal_Boolean_SpecialGuestGroup_0;

			// Token: 0x04005F10 RID: 24336
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentIzakaya_b__73_7_Internal_ValueTuple_2_String_CharacterSpriteSetCompact_SpecialGuestGroup_0;
		}

		// Token: 0x02000633 RID: 1587
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPannel+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : Il2CppSystem.Object
		{
			// Token: 0x06009265 RID: 37477 RVA: 0x00279EFC File Offset: 0x002780FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0>.NativeClassPtr);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0.NativeFieldInfoPtr_partnerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0>.NativeClassPtr, "partnerData");
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0>.NativeClassPtr, 100667217);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0.NativeMethodInfoPtr__UpdatePartnerIndicator_b__1_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0>.NativeClassPtr, 100667218);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0.NativeMethodInfoPtr__UpdatePartnerIndicator_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0>.NativeClassPtr, 100667219);
			}

			// Token: 0x06009266 RID: 37478 RVA: 0x00279F78 File Offset: 0x00278178
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009267 RID: 37479 RVA: 0x00279FB4 File Offset: 0x002781B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61067, XrefRangeEnd = 61071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerIndicator_b__1(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0.NativeMethodInfoPtr__UpdatePartnerIndicator_b__1_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009268 RID: 37480 RVA: 0x00279FF8 File Offset: 0x002781F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61071, XrefRangeEnd = 61074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerIndicator_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0.NativeMethodInfoPtr__UpdatePartnerIndicator_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009269 RID: 37481 RVA: 0x0004F486 File Offset: 0x0004D686
			public __c__DisplayClass66_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030CD RID: 12493
			// (get) Token: 0x0600926A RID: 37482 RVA: 0x0027A03C File Offset: 0x0027823C
			// (set) Token: 0x0600926B RID: 37483 RVA: 0x0004F48F File Offset: 0x0004D68F
			public ValueTuple<int, PartnerBase.PartnerType> partnerData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0.NativeFieldInfoPtr_partnerData);
					return new ValueTuple<int, PartnerBase.PartnerType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<int, PartnerBase.PartnerType>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_0.NativeFieldInfoPtr_partnerData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<int, PartnerBase.PartnerType>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005F11 RID: 24337
			private static readonly IntPtr NativeFieldInfoPtr_partnerData;

			// Token: 0x04005F12 RID: 24338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F13 RID: 24339
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerIndicator_b__1_Internal_Void_RectTransform_0;

			// Token: 0x04005F14 RID: 24340
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerIndicator_b__2_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000634 RID: 1588
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPannel+<>c__DisplayClass66_1")]
		public sealed class __c__DisplayClass66_1 : Il2CppSystem.Object
		{
			// Token: 0x0600926C RID: 37484 RVA: 0x0027A06C File Offset: 0x0027826C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_1()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "<>c__DisplayClass66_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1>.NativeClassPtr);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1>.NativeClassPtr, "visual");
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeFieldInfoPtr_enabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1>.NativeClassPtr, "enabledColor");
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1>.NativeClassPtr, "<>9__8");
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1>.NativeClassPtr, 100667220);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdatePartnerIndicator_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1>.NativeClassPtr, 100667221);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdatePartnerIndicator_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1>.NativeClassPtr, 100667222);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdatePartnerIndicator_b__5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1>.NativeClassPtr, 100667223);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdatePartnerIndicator_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1>.NativeClassPtr, 100667224);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdatePartnerIndicator_b__7_Internal_Void_Il2CppReferenceArray_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1>.NativeClassPtr, 100667225);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdatePartnerIndicator_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1>.NativeClassPtr, 100667226);
			}

			// Token: 0x0600926D RID: 37485 RVA: 0x0027A160 File Offset: 0x00278360
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600926E RID: 37486 RVA: 0x0027A19C File Offset: 0x0027839C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerIndicator_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdatePartnerIndicator_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600926F RID: 37487 RVA: 0x0027A1E0 File Offset: 0x002783E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerIndicator_b__4(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdatePartnerIndicator_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009270 RID: 37488 RVA: 0x0027A224 File Offset: 0x00278424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerIndicator_b__5(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdatePartnerIndicator_b__5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009271 RID: 37489 RVA: 0x0027A268 File Offset: 0x00278468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerIndicator_b__6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdatePartnerIndicator_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009272 RID: 37490 RVA: 0x0027A2AC File Offset: 0x002784AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61074, XrefRangeEnd = 61085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerIndicator_b__7(Il2CppReferenceArray<Image> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdatePartnerIndicator_b__7_Internal_Void_Il2CppReferenceArray_1_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009273 RID: 37491 RVA: 0x0027A2F0 File Offset: 0x002784F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61085, XrefRangeEnd = 61089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdatePartnerIndicator_b__8(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeMethodInfoPtr__UpdatePartnerIndicator_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009274 RID: 37492 RVA: 0x0004F4BD File Offset: 0x0004D6BD
			public __c__DisplayClass66_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030CE RID: 12494
			// (get) Token: 0x06009275 RID: 37493 RVA: 0x0027A334 File Offset: 0x00278534
			// (set) Token: 0x06009276 RID: 37494 RVA: 0x0004F4C6 File Offset: 0x0004D6C6
			public unsafe CharacterSpriteSetCompact visual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeFieldInfoPtr_visual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030CF RID: 12495
			// (get) Token: 0x06009277 RID: 37495 RVA: 0x0027A364 File Offset: 0x00278564
			// (set) Token: 0x06009278 RID: 37496 RVA: 0x0004F4E5 File Offset: 0x0004D6E5
			public unsafe string enabledColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeFieldInfoPtr_enabledColor);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeFieldInfoPtr_enabledColor), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170030D0 RID: 12496
			// (get) Token: 0x06009279 RID: 37497 RVA: 0x0027A38C File Offset: 0x0027858C
			// (set) Token: 0x0600927A RID: 37498 RVA: 0x0004F504 File Offset: 0x0004D704
			public unsafe Action<Image> __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass66_1.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F15 RID: 24341
			private static readonly IntPtr NativeFieldInfoPtr_visual;

			// Token: 0x04005F16 RID: 24342
			private static readonly IntPtr NativeFieldInfoPtr_enabledColor;

			// Token: 0x04005F17 RID: 24343
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x04005F18 RID: 24344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F19 RID: 24345
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerIndicator_b__3_Internal_Void_Image_0;

			// Token: 0x04005F1A RID: 24346
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerIndicator_b__4_Internal_Void_Image_0;

			// Token: 0x04005F1B RID: 24347
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerIndicator_b__5_Internal_Void_Image_0;

			// Token: 0x04005F1C RID: 24348
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerIndicator_b__6_Internal_Void_Image_0;

			// Token: 0x04005F1D RID: 24349
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerIndicator_b__7_Internal_Void_Il2CppReferenceArray_1_Image_0;

			// Token: 0x04005F1E RID: 24350
			private static readonly IntPtr NativeMethodInfoPtr__UpdatePartnerIndicator_b__8_Internal_Void_Image_0;
		}

		// Token: 0x02000635 RID: 1589
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPannel+<>c__DisplayClass71_0")]
		public sealed class __c__DisplayClass71_0 : Il2CppSystem.Object
		{
			// Token: 0x0600927B RID: 37499 RVA: 0x0027A3BC File Offset: 0x002785BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass71_0()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass71_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "<>c__DisplayClass71_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass71_0>.NativeClassPtr);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass71_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass71_0>.NativeClassPtr, "x");
				DaySceneIzakayaSelectorPannel.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass71_0>.NativeClassPtr, 100667227);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass71_0.NativeMethodInfoPtr__UpdateAllSpot_b__7_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass71_0>.NativeClassPtr, 100667228);
			}

			// Token: 0x0600927C RID: 37500 RVA: 0x0027A424 File Offset: 0x00278624
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass71_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass71_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600927D RID: 37501 RVA: 0x0027A460 File Offset: 0x00278660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61089, XrefRangeEnd = 61090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateAllSpot_b__7(KeyValuePair<int, int> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass71_0.NativeMethodInfoPtr__UpdateAllSpot_b__7_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600927E RID: 37502 RVA: 0x0004F523 File Offset: 0x0004D723
			public __c__DisplayClass71_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030D1 RID: 12497
			// (get) Token: 0x0600927F RID: 37503 RVA: 0x0027A4B4 File Offset: 0x002786B4
			// (set) Token: 0x06009280 RID: 37504 RVA: 0x0004F52C File Offset: 0x0004D72C
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass71_0.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass71_0.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x04005F1F RID: 24351
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04005F20 RID: 24352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F21 RID: 24353
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAllSpot_b__7_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;
		}

		// Token: 0x02000636 RID: 1590
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPannel+<>c__DisplayClass71_1")]
		public sealed class __c__DisplayClass71_1 : Il2CppSystem.Object
		{
			// Token: 0x06009281 RID: 37505 RVA: 0x0027A4DC File Offset: 0x002786DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass71_1()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "<>c__DisplayClass71_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1>.NativeClassPtr);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1.NativeFieldInfoPtr_currentSelectedSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1>.NativeClassPtr, "currentSelectedSpot");
				DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1>.NativeClassPtr, "<>4__this");
				DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1>.NativeClassPtr, 100667229);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1.NativeMethodInfoPtr__UpdateAllSpot_b__8_Internal_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1>.NativeClassPtr, 100667230);
			}

			// Token: 0x06009282 RID: 37506 RVA: 0x0027A558 File Offset: 0x00278758
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass71_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009283 RID: 37507 RVA: 0x0027A594 File Offset: 0x00278794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61090, XrefRangeEnd = 61092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateAllSpot_b__8(List<int> izakayaId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(izakayaId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1.NativeMethodInfoPtr__UpdateAllSpot_b__8_Internal_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009284 RID: 37508 RVA: 0x0004F547 File Offset: 0x0004D747
			public __c__DisplayClass71_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030D2 RID: 12498
			// (get) Token: 0x06009285 RID: 37509 RVA: 0x0027A5D8 File Offset: 0x002787D8
			// (set) Token: 0x06009286 RID: 37510 RVA: 0x0004F550 File Offset: 0x0004D750
			public unsafe IzakayaSpot currentSelectedSpot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1.NativeFieldInfoPtr_currentSelectedSpot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1.NativeFieldInfoPtr_currentSelectedSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030D3 RID: 12499
			// (get) Token: 0x06009287 RID: 37511 RVA: 0x0027A608 File Offset: 0x00278808
			// (set) Token: 0x06009288 RID: 37512 RVA: 0x0004F56F File Offset: 0x0004D76F
			public unsafe DaySceneIzakayaSelectorPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneIzakayaSelectorPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass71_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F22 RID: 24354
			private static readonly IntPtr NativeFieldInfoPtr_currentSelectedSpot;

			// Token: 0x04005F23 RID: 24355
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005F24 RID: 24356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F25 RID: 24357
			private static readonly IntPtr NativeMethodInfoPtr__UpdateAllSpot_b__8_Internal_Void_List_1_Int32_0;
		}

		// Token: 0x02000637 RID: 1591
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPannel+<>c__DisplayClass72_0")]
		public sealed class __c__DisplayClass72_0 : Il2CppSystem.Object
		{
			// Token: 0x06009289 RID: 37513 RVA: 0x0027A638 File Offset: 0x00278838
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass72_0()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "<>c__DisplayClass72_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0>.NativeClassPtr);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0>.NativeClassPtr, "id");
				DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0>.NativeClassPtr, "<>4__this");
				DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0>.NativeClassPtr, 100667231);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0.NativeMethodInfoPtr__OnHighlight_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0>.NativeClassPtr, 100667232);
			}

			// Token: 0x0600928A RID: 37514 RVA: 0x0027A6B4 File Offset: 0x002788B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass72_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600928B RID: 37515 RVA: 0x0027A6F0 File Offset: 0x002788F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61092, XrefRangeEnd = 61094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnHighlight_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0.NativeMethodInfoPtr__OnHighlight_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600928C RID: 37516 RVA: 0x0004F58E File Offset: 0x0004D78E
			public __c__DisplayClass72_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030D4 RID: 12500
			// (get) Token: 0x0600928D RID: 37517 RVA: 0x0027A724 File Offset: 0x00278924
			// (set) Token: 0x0600928E RID: 37518 RVA: 0x0004F597 File Offset: 0x0004D797
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x170030D5 RID: 12501
			// (get) Token: 0x0600928F RID: 37519 RVA: 0x0027A74C File Offset: 0x0027894C
			// (set) Token: 0x06009290 RID: 37520 RVA: 0x0004F5B2 File Offset: 0x0004D7B2
			public unsafe DaySceneIzakayaSelectorPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneIzakayaSelectorPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass72_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F26 RID: 24358
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04005F27 RID: 24359
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005F28 RID: 24360
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F29 RID: 24361
			private static readonly IntPtr NativeMethodInfoPtr__OnHighlight_b__1_Internal_Void_0;
		}

		// Token: 0x02000638 RID: 1592
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPannel+<>c__DisplayClass73_0")]
		public sealed class __c__DisplayClass73_0 : Il2CppSystem.Object
		{
			// Token: 0x06009291 RID: 37521 RVA: 0x0027A77C File Offset: 0x0027897C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass73_0()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "<>c__DisplayClass73_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0>.NativeClassPtr);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeFieldInfoPtr_selectedVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0>.NativeClassPtr, "selectedVisual");
				DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0>.NativeClassPtr, "<>4__this");
				DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeFieldInfoPtr_realIzakayaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0>.NativeClassPtr, "realIzakayaData");
				DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0>.NativeClassPtr, 100667233);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0>.NativeClassPtr, 100667234);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__5_Internal_Boolean_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0>.NativeClassPtr, 100667235);
			}

			// Token: 0x06009292 RID: 37522 RVA: 0x0027A820 File Offset: 0x00278A20
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass73_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009293 RID: 37523 RVA: 0x0027A85C File Offset: 0x00278A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61094, XrefRangeEnd = 61096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCurrentIzakaya_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009294 RID: 37524 RVA: 0x0027A890 File Offset: 0x00278A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61096, XrefRangeEnd = 61104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateCurrentIzakaya_b__5(Izakaya.SpecialGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeMethodInfoPtr__UpdateCurrentIzakaya_b__5_Internal_Boolean_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009295 RID: 37525 RVA: 0x0004F5D1 File Offset: 0x0004D7D1
			public __c__DisplayClass73_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030D6 RID: 12502
			// (get) Token: 0x06009296 RID: 37526 RVA: 0x0027A8E0 File Offset: 0x00278AE0
			// (set) Token: 0x06009297 RID: 37527 RVA: 0x0004F5DA File Offset: 0x0004D7DA
			public unsafe Image selectedVisual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeFieldInfoPtr_selectedVisual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeFieldInfoPtr_selectedVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030D7 RID: 12503
			// (get) Token: 0x06009298 RID: 37528 RVA: 0x0027A910 File Offset: 0x00278B10
			// (set) Token: 0x06009299 RID: 37529 RVA: 0x0004F5F9 File Offset: 0x0004D7F9
			public unsafe DaySceneIzakayaSelectorPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneIzakayaSelectorPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170030D8 RID: 12504
			// (get) Token: 0x0600929A RID: 37530 RVA: 0x0027A940 File Offset: 0x00278B40
			// (set) Token: 0x0600929B RID: 37531 RVA: 0x0004F618 File Offset: 0x0004D818
			public unsafe Izakaya realIzakayaData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeFieldInfoPtr_realIzakayaData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Izakaya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass73_0.NativeFieldInfoPtr_realIzakayaData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005F2A RID: 24362
			private static readonly IntPtr NativeFieldInfoPtr_selectedVisual;

			// Token: 0x04005F2B RID: 24363
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005F2C RID: 24364
			private static readonly IntPtr NativeFieldInfoPtr_realIzakayaData;

			// Token: 0x04005F2D RID: 24365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F2E RID: 24366
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentIzakaya_b__0_Internal_Void_0;

			// Token: 0x04005F2F RID: 24367
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentIzakaya_b__5_Internal_Boolean_SpecialGuestGroup_0;
		}

		// Token: 0x02000639 RID: 1593
		[ObfuscatedName("DayScene.UI.DaySceneIzakayaSelectorPannel+<>c__DisplayClass74_0")]
		public sealed class __c__DisplayClass74_0 : Il2CppSystem.Object
		{
			// Token: 0x0600929C RID: 37532 RVA: 0x0027A970 File Offset: 0x00278B70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_0()
			{
				Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel>.NativeClassPtr, "<>c__DisplayClass74_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0>.NativeClassPtr);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0>.NativeClassPtr, "data");
				DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0>.NativeClassPtr, 100667236);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__Process_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0>.NativeClassPtr, 100667237);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__Process_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0>.NativeClassPtr, 100667238);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__Process_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0>.NativeClassPtr, 100667239);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__Process_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0>.NativeClassPtr, 100667240);
				DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__Process_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0>.NativeClassPtr, 100667241);
			}

			// Token: 0x0600929D RID: 37533 RVA: 0x0027AA28 File Offset: 0x00278C28
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600929E RID: 37534 RVA: 0x0027AA64 File Offset: 0x00278C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61104, XrefRangeEnd = 61107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Process_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__Process_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600929F RID: 37535 RVA: 0x0027AAA8 File Offset: 0x00278CA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61107, XrefRangeEnd = 61110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Process_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__Process_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092A0 RID: 37536 RVA: 0x0027AAEC File Offset: 0x00278CEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61110, XrefRangeEnd = 61111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Process_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__Process_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092A1 RID: 37537 RVA: 0x0027AB30 File Offset: 0x00278D30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61111, XrefRangeEnd = 61112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Process_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__Process_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092A2 RID: 37538 RVA: 0x0027AB74 File Offset: 0x00278D74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Process_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeMethodInfoPtr__Process_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060092A3 RID: 37539 RVA: 0x0004F637 File Offset: 0x0004D837
			public __c__DisplayClass74_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170030D9 RID: 12505
			// (get) Token: 0x060092A4 RID: 37540 RVA: 0x0027ABB8 File Offset: 0x00278DB8
			// (set) Token: 0x060092A5 RID: 37541 RVA: 0x0004F640 File Offset: 0x0004D840
			public ValueTuple<string, CharacterSpriteSetCompact> data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeFieldInfoPtr_data);
					return new ValueTuple<string, CharacterSpriteSetCompact>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, CharacterSpriteSetCompact>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneIzakayaSelectorPannel.__c__DisplayClass74_0.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, CharacterSpriteSetCompact>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005F30 RID: 24368
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04005F31 RID: 24369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005F32 RID: 24370
			private static readonly IntPtr NativeMethodInfoPtr__Process_b__0_Internal_Void_Image_0;

			// Token: 0x04005F33 RID: 24371
			private static readonly IntPtr NativeMethodInfoPtr__Process_b__1_Internal_Void_Image_0;

			// Token: 0x04005F34 RID: 24372
			private static readonly IntPtr NativeMethodInfoPtr__Process_b__2_Internal_Void_Image_0;

			// Token: 0x04005F35 RID: 24373
			private static readonly IntPtr NativeMethodInfoPtr__Process_b__3_Internal_Void_Image_0;

			// Token: 0x04005F36 RID: 24374
			private static readonly IntPtr NativeMethodInfoPtr__Process_b__4_Internal_Void_TextMeshProUGUI_0;
		}
	}
}
