using System;
using System.Runtime.InteropServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020000D1 RID: 209
	public class DLC4_FlandreHomeDecorationEditorPanel : UIPanel
	{
		// Token: 0x060018FB RID: 6395 RVA: 0x000F151C File Offset: 0x000EF71C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_FlandreHomeDecorationEditorPanel()
		{
			Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DLC4_FlandreHomeDecorationEditorPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr);
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_SPAWN_MARKET_LABEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "SPAWN_MARKET_LABEL");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_flandreHomeMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "flandreHomeMapLabel");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_StorageTabPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "m_StorageTabPanel");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_PutPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "m_PutPanel");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_StorageButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "m_StorageButton");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_SwitchButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "m_SwitchButton");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_DeleteAllButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "m_DeleteAllButton");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_furnitureElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "furnitureElement");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_furnitureButtonElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "furnitureButtonElement");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_switchText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "switchText");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_outlineArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "outlineArea");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_FurnitureVirtualButtonContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "m_FurnitureVirtualButtonContent");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_FurnitureContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "m_FurnitureContent");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_currentEditorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "currentEditorType");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_subPanelHasOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "subPanelHasOpened");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_EditorFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "m_EditorFurniture");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_allButtonInstances2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "allButtonInstances2");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_allVirtualInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "allVirtualInstances");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr__subPutPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "_subPutPanel");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_carpetFurnitureSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "carpetFurnitureSets");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_currentButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "currentButton");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_currentButtonPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "currentButtonPosition");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_furnitureContentCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "furnitureContentCanvas");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_furnitureVirtualButtonContentCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "furnitureVirtualButtonContentCanvas");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_groundFurnitureSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "groundFurnitureSets");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_hasAnyCarpet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "hasAnyCarpet");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_hasAnyGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "hasAnyGround");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_PlacedFurnitureGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "m_PlacedFurnitureGroup");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "mainCamera");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_oldClockAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "oldClockAlpha");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_oldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "oldPosition");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_outlineCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "outlineCanvas");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_placementRetrievalDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "placementRetrievalDictionary");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_selectableButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "selectableButtons");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_unselectableButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "unselectableButtons");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_wallFurnitureSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "wallFurnitureSets");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr__FlandreHomeMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "<FlandreHomeMap>k__BackingField");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr__LastStoragePageIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "<LastStoragePageIndex>k__BackingField");
			DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr__LastStoragePageAlbumType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "<LastStoragePageAlbumType>k__BackingField");
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_CurrentEditorType_Private_get_EditorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667715);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_set_CurrentEditorType_Private_set_Void_EditorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667716);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_EditorFurniture_Public_get_Nullable_1_EditorFurnitureProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667717);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_set_EditorFurniture_Private_set_Void_Nullable_1_EditorFurnitureProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667718);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_FlandreHomeMap_Public_get_FlandreHomeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667719);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_set_FlandreHomeMap_Private_set_Void_FlandreHomeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667720);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_LastStoragePageIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667721);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_set_LastStoragePageIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667722);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_LastStoragePageAlbumType_Public_get_AlbumType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667723);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_set_LastStoragePageAlbumType_Public_set_Void_AlbumType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667724);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_OutlineArea_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667725);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667726);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_CurrentActiveMap_Private_get_DaySceneMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667727);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667728);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ConfirmChoiceStart_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667729);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ConfirmChoiceEnd_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667730);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667731);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ReverseEditorType_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667732);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ReverseEditorTypeFunc_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667733);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_AutoSetEditorType_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667734);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_AddToDic_Private_Void_byref_FlandreHomeFurniture_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667735);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_RefreshPanel_Private_Void_RefreshType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667736);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_SetCurrentEditorTypeByPlacementType_Private_Void_Placement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667737);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_RefreshEditorType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667738);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_EnterNearestPoint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667739);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_HideCharacter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667740);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ResetCharacter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667741);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ProcessVirtualSelectedFurnitureElement_Private_Void_UIButtonSimple_KeyValuePair_2_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667742);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ProcessButtonFurnitureElement_Private_Void_UIButtonSimple_KeyValuePair_2_Vector2Int_EditorFurnitureProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667743);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_SetOutline_Public_Void_Sprite_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667744);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_SetOutlinePosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667745);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_OpenStorage_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667746);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_OpenStorageFunc_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667747);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_DeleteAllFurniture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667748);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_PutNewFurniture_Public_Void_FlandreHomeFurniture_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667749);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667750);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ResetFurnitureColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667751);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_WaitForFrameEndAndClosePanel_Public_IEnumerator_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667752);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667753);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667754);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr__OnPanelOpen_b__64_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667755);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr__RefreshPanel_b__69_0_Private_Boolean_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667756);
			DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr__OpenStorageFunc_b__80_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, 100667757);
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x000F1BB4 File Offset: 0x000EFDB4
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x000F1BF0 File Offset: 0x000EFDF0
		public unsafe DLC4_FlandreHomeDecorationEditorPanel.EditorType CurrentEditorType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_CurrentEditorType_Private_get_EditorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 67971, RefRangeEnd = 67981, XrefRangeStart = 67964, XrefRangeEnd = 67971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_set_CurrentEditorType_Private_set_Void_EditorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x000F1C30 File Offset: 0x000EFE30
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x000F1C68 File Offset: 0x000EFE68
		public unsafe Nullable<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty> EditorFurniture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_EditorFurniture_Public_get_Nullable_1_EditorFurnitureProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67981, XrefRangeEnd = 67982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_set_EditorFurniture_Private_set_Void_Nullable_1_EditorFurnitureProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x000F1CB0 File Offset: 0x000EFEB0
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x000F1CF0 File Offset: 0x000EFEF0
		public unsafe FlandreHomeMap FlandreHomeMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_FlandreHomeMap_Public_get_FlandreHomeMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FlandreHomeMap>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67982, XrefRangeEnd = 67983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_set_FlandreHomeMap_Private_set_Void_FlandreHomeMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x000F1D34 File Offset: 0x000EFF34
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x000F1D70 File Offset: 0x000EFF70
		public unsafe int LastStoragePageIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_LastStoragePageIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_set_LastStoragePageIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x000F1DB0 File Offset: 0x000EFFB0
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x000F1DEC File Offset: 0x000EFFEC
		public unsafe DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType LastStoragePageAlbumType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_LastStoragePageAlbumType_Public_get_AlbumType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_set_LastStoragePageAlbumType_Public_set_Void_AlbumType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x000F1E2C File Offset: 0x000F002C
		public unsafe Image OutlineArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_OutlineArea_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x000F1E6C File Offset: 0x000F006C
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x000F1EB4 File Offset: 0x000F00B4
		public unsafe DaySceneMap CurrentActiveMap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67983, XrefRangeEnd = 67986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_get_CurrentActiveMap_Private_get_DaySceneMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DaySceneMap>(intPtr3) : null;
			}
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x000F1EF4 File Offset: 0x000F00F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67986, XrefRangeEnd = 68069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x000F1F30 File Offset: 0x000F0130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68069, XrefRangeEnd = 68073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmChoiceStart(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ConfirmChoiceStart_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x000F1F78 File Offset: 0x000F0178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68073, XrefRangeEnd = 68075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmChoiceEnd(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ConfirmChoiceEnd_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x000F1FC0 File Offset: 0x000F01C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68075, XrefRangeEnd = 68152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x000F1FFC File Offset: 0x000F01FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68152, XrefRangeEnd = 68155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReverseEditorType(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ReverseEditorType_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x000F2044 File Offset: 0x000F0244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReverseEditorTypeFunc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ReverseEditorTypeFunc_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x000F2078 File Offset: 0x000F0278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68172, RefRangeEnd = 68173, XrefRangeStart = 68155, XrefRangeEnd = 68172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutoSetEditorType(bool forced)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forced;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_AutoSetEditorType_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x000F20B8 File Offset: 0x000F02B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68218, RefRangeEnd = 68220, XrefRangeStart = 68173, XrefRangeEnd = 68218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToDic([In] ref FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int placedPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref placedPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_AddToDic_Private_Void_byref_FlandreHomeFurniture_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x000F210C File Offset: 0x000F030C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 68320, RefRangeEnd = 68326, XrefRangeStart = 68220, XrefRangeEnd = 68320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPanel(DLC4_FlandreHomeDecorationEditorPanel.RefreshType refreshType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref refreshType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_RefreshPanel_Private_Void_RefreshType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x000F214C File Offset: 0x000F034C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68326, XrefRangeEnd = 68329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentEditorTypeByPlacementType(FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placementType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref placementType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_SetCurrentEditorTypeByPlacementType_Private_Void_Placement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x000F218C File Offset: 0x000F038C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68395, RefRangeEnd = 68397, XrefRangeStart = 68329, XrefRangeEnd = 68395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshEditorType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_RefreshEditorType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x000F21C0 File Offset: 0x000F03C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68397, XrefRangeEnd = 68427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterNearestPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_EnterNearestPoint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x000F21F4 File Offset: 0x000F03F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68427, XrefRangeEnd = 68442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideCharacter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_HideCharacter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x000F2228 File Offset: 0x000F0428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68442, XrefRangeEnd = 68468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCharacter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ResetCharacter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x000F225C File Offset: 0x000F045C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68468, XrefRangeEnd = 68493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVirtualSelectedFurnitureElement(UIButtonSimple button, KeyValuePair<Vector2Int, Vector2Int> buttonPointPair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buttonPointPair));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ProcessVirtualSelectedFurnitureElement_Private_Void_UIButtonSimple_KeyValuePair_2_Vector2Int_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x000F22B8 File Offset: 0x000F04B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68493, XrefRangeEnd = 68528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessButtonFurnitureElement(UIButtonSimple button, KeyValuePair<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty> buttonPointPair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(button);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buttonPointPair));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ProcessButtonFurnitureElement_Private_Void_UIButtonSimple_KeyValuePair_2_Vector2Int_EditorFurnitureProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x000F2314 File Offset: 0x000F0514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68538, RefRangeEnd = 68539, XrefRangeStart = 68528, XrefRangeEnd = 68538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOutline(Sprite previewImage, Vector2 thisPairPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(previewImage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref thisPairPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_SetOutline_Public_Void_Sprite_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x000F2364 File Offset: 0x000F0564
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68542, RefRangeEnd = 68544, XrefRangeStart = 68539, XrefRangeEnd = 68542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOutlinePosition(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_SetOutlinePosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x000F23A4 File Offset: 0x000F05A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68544, XrefRangeEnd = 68545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenStorage(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_OpenStorage_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x000F23EC File Offset: 0x000F05EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68567, RefRangeEnd = 68569, XrefRangeStart = 68545, XrefRangeEnd = 68567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenStorageFunc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_OpenStorageFunc_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000F2420 File Offset: 0x000F0620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68569, XrefRangeEnd = 68625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteAllFurniture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_DeleteAllFurniture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000F2454 File Offset: 0x000F0654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68654, RefRangeEnd = 68655, XrefRangeStart = 68625, XrefRangeEnd = 68654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PutNewFurniture(FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int startPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_PutNewFurniture_Public_Void_FlandreHomeFurniture_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x000F24AC File Offset: 0x000F06AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68655, XrefRangeEnd = 68689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x000F24E8 File Offset: 0x000F06E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68725, RefRangeEnd = 68727, XrefRangeStart = 68689, XrefRangeEnd = 68725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetFurnitureColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_ResetFurnitureColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x000F251C File Offset: 0x000F071C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68727, XrefRangeEnd = 68732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForFrameEndAndClosePanel(Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_WaitForFrameEndAndClosePanel_Public_IEnumerator_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000F256C File Offset: 0x000F076C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68732, XrefRangeEnd = 68765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x000F25A8 File Offset: 0x000F07A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68765, XrefRangeEnd = 68798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_FlandreHomeDecorationEditorPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x000F25E4 File Offset: 0x000F07E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68798, XrefRangeEnd = 68816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__64_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr__OnPanelOpen_b__64_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x000F2624 File Offset: 0x000F0824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68816, XrefRangeEnd = 68822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RefreshPanel_b__69_0(Vector2Int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr__RefreshPanel_b__69_0_Private_Boolean_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x000F2670 File Offset: 0x000F0870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68822, XrefRangeEnd = 68823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenStorageFunc_b__80_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.NativeMethodInfoPtr__OpenStorageFunc_b__80_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x0000F97D File Offset: 0x0000DB7D
		public DLC4_FlandreHomeDecorationEditorPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x000F26A4 File Offset: 0x000F08A4
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x0000F986 File Offset: 0x0000DB86
		public unsafe static string SPAWN_MARKET_LABEL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_SPAWN_MARKET_LABEL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_SPAWN_MARKET_LABEL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x000F26C4 File Offset: 0x000F08C4
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x0000F998 File Offset: 0x0000DB98
		public unsafe string flandreHomeMapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_flandreHomeMapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_flandreHomeMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x000F26EC File Offset: 0x000F08EC
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x0000F9B7 File Offset: 0x0000DBB7
		public unsafe DLC4_FlandreHomeDecorationStorageTabPanel m_StorageTabPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_StorageTabPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationStorageTabPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_StorageTabPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x000F271C File Offset: 0x000F091C
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x0000F9D6 File Offset: 0x0000DBD6
		public unsafe DLC4_FlandreHomeDecorationEditorSubPanel m_PutPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_PutPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_PutPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x000F274C File Offset: 0x000F094C
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x0000F9F5 File Offset: 0x0000DBF5
		public unsafe UIButtonSimple m_StorageButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_StorageButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_StorageButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x000F277C File Offset: 0x000F097C
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x0000FA14 File Offset: 0x0000DC14
		public unsafe UIButtonSimple m_SwitchButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_SwitchButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_SwitchButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x000F27AC File Offset: 0x000F09AC
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x0000FA33 File Offset: 0x0000DC33
		public unsafe UIButtonHold m_DeleteAllButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_DeleteAllButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_DeleteAllButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x000F27DC File Offset: 0x000F09DC
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0000FA52 File Offset: 0x0000DC52
		public unsafe GameObject furnitureElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_furnitureElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_furnitureElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x000F280C File Offset: 0x000F0A0C
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x0000FA71 File Offset: 0x0000DC71
		public unsafe GameObject furnitureButtonElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_furnitureButtonElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_furnitureButtonElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x000F283C File Offset: 0x000F0A3C
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x0000FA90 File Offset: 0x0000DC90
		public unsafe TextMeshProUGUI switchText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_switchText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_switchText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x000F286C File Offset: 0x000F0A6C
		// (set) Token: 0x0600193D RID: 6461 RVA: 0x0000FAAF File Offset: 0x0000DCAF
		public unsafe Image outlineArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_outlineArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_outlineArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x000F289C File Offset: 0x000F0A9C
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x0000FACE File Offset: 0x0000DCCE
		public unsafe RectTransform m_FurnitureVirtualButtonContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_FurnitureVirtualButtonContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_FurnitureVirtualButtonContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x000F28CC File Offset: 0x000F0ACC
		// (set) Token: 0x06001941 RID: 6465 RVA: 0x0000FAED File Offset: 0x0000DCED
		public unsafe RectTransform m_FurnitureContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_FurnitureContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_FurnitureContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x000F28FC File Offset: 0x000F0AFC
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x0000FB0C File Offset: 0x0000DD0C
		public unsafe DLC4_FlandreHomeDecorationEditorPanel.EditorType currentEditorType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_currentEditorType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_currentEditorType)) = value;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x000F2924 File Offset: 0x000F0B24
		// (set) Token: 0x06001945 RID: 6469 RVA: 0x0000FB27 File Offset: 0x0000DD27
		public unsafe bool subPanelHasOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_subPanelHasOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_subPanelHasOpened)) = value;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x000F294C File Offset: 0x000F0B4C
		// (set) Token: 0x06001947 RID: 6471 RVA: 0x0000FB42 File Offset: 0x0000DD42
		public Nullable<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty> m_EditorFurniture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_EditorFurniture);
				return new Nullable<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_EditorFurniture), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x000F297C File Offset: 0x000F0B7C
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x0000FB70 File Offset: 0x0000DD70
		public unsafe List<GameObject> allButtonInstances2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_allButtonInstances2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_allButtonInstances2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x000F29AC File Offset: 0x000F0BAC
		// (set) Token: 0x0600194B RID: 6475 RVA: 0x0000FB8F File Offset: 0x0000DD8F
		public unsafe List<GameObject> allVirtualInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_allVirtualInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_allVirtualInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x000F29DC File Offset: 0x000F0BDC
		// (set) Token: 0x0600194D RID: 6477 RVA: 0x0000FBAE File Offset: 0x0000DDAE
		public unsafe DLC4_FlandreHomeDecorationEditorSubPanel _subPutPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr__subPutPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr__subPutPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x000F2A0C File Offset: 0x000F0C0C
		// (set) Token: 0x0600194F RID: 6479 RVA: 0x0000FBCD File Offset: 0x0000DDCD
		public unsafe DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets carpetFurnitureSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_carpetFurnitureSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_carpetFurnitureSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x000F2A3C File Offset: 0x000F0C3C
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x0000FBEC File Offset: 0x0000DDEC
		public unsafe UIButtonSimple currentButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_currentButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_currentButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x000F2A6C File Offset: 0x000F0C6C
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x0000FC0B File Offset: 0x0000DE0B
		public unsafe Vector2Int currentButtonPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_currentButtonPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_currentButtonPosition)) = value;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x000F2A94 File Offset: 0x000F0C94
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x0000FC26 File Offset: 0x0000DE26
		public unsafe Canvas furnitureContentCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_furnitureContentCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_furnitureContentCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x000F2AC4 File Offset: 0x000F0CC4
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x0000FC45 File Offset: 0x0000DE45
		public unsafe Canvas furnitureVirtualButtonContentCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_furnitureVirtualButtonContentCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_furnitureVirtualButtonContentCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x000F2AF4 File Offset: 0x000F0CF4
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x0000FC64 File Offset: 0x0000DE64
		public unsafe DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets groundFurnitureSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_groundFurnitureSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_groundFurnitureSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x000F2B24 File Offset: 0x000F0D24
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x0000FC83 File Offset: 0x0000DE83
		public unsafe bool hasAnyCarpet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_hasAnyCarpet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_hasAnyCarpet)) = value;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x000F2B4C File Offset: 0x000F0D4C
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x0000FC9E File Offset: 0x0000DE9E
		public unsafe bool hasAnyGround
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_hasAnyGround);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_hasAnyGround)) = value;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x000F2B74 File Offset: 0x000F0D74
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x0000FCB9 File Offset: 0x0000DEB9
		public unsafe UILogicalGroupT<Vector2Int> m_PlacedFurnitureGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_PlacedFurnitureGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_m_PlacedFurnitureGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x000F2BA4 File Offset: 0x000F0DA4
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		public unsafe Camera mainCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_mainCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_mainCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x000F2BD4 File Offset: 0x000F0DD4
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x0000FCF7 File Offset: 0x0000DEF7
		public unsafe float oldClockAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_oldClockAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_oldClockAlpha)) = value;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x000F2BFC File Offset: 0x000F0DFC
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x0000FD12 File Offset: 0x0000DF12
		public unsafe TrackedNPC.OverridePosition oldPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_oldPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedNPC.OverridePosition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_oldPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x000F2C2C File Offset: 0x000F0E2C
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x0000FD31 File Offset: 0x0000DF31
		public unsafe Canvas outlineCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_outlineCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_outlineCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x000F2C5C File Offset: 0x000F0E5C
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x0000FD50 File Offset: 0x0000DF50
		public unsafe Dictionary<int, DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets> placementRetrievalDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_placementRetrievalDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_placementRetrievalDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x000F2C8C File Offset: 0x000F0E8C
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x0000FD6F File Offset: 0x0000DF6F
		public unsafe Dictionary<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty> selectableButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_selectableButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_selectableButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x000F2CBC File Offset: 0x000F0EBC
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x0000FD8E File Offset: 0x0000DF8E
		public unsafe Dictionary<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty> unselectableButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_unselectableButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_unselectableButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x000F2CEC File Offset: 0x000F0EEC
		// (set) Token: 0x0600196F RID: 6511 RVA: 0x0000FDAD File Offset: 0x0000DFAD
		public unsafe DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets wallFurnitureSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_wallFurnitureSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr_wallFurnitureSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x000F2D1C File Offset: 0x000F0F1C
		// (set) Token: 0x06001971 RID: 6513 RVA: 0x0000FDCC File Offset: 0x0000DFCC
		public unsafe FlandreHomeMap _FlandreHomeMap_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr__FlandreHomeMap_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlandreHomeMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr__FlandreHomeMap_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001972 RID: 6514 RVA: 0x000F2D4C File Offset: 0x000F0F4C
		// (set) Token: 0x06001973 RID: 6515 RVA: 0x0000FDEB File Offset: 0x0000DFEB
		public unsafe int _LastStoragePageIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr__LastStoragePageIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr__LastStoragePageIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x000F2D74 File Offset: 0x000F0F74
		// (set) Token: 0x06001975 RID: 6517 RVA: 0x0000FE06 File Offset: 0x0000E006
		public unsafe DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType _LastStoragePageAlbumType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr__LastStoragePageAlbumType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.NativeFieldInfoPtr__LastStoragePageAlbumType_k__BackingField)) = value;
			}
		}

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeFieldInfoPtr_SPAWN_MARKET_LABEL;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeFieldInfoPtr_flandreHomeMapLabel;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeFieldInfoPtr_m_StorageTabPanel;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeFieldInfoPtr_m_PutPanel;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeFieldInfoPtr_m_StorageButton;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeFieldInfoPtr_m_SwitchButton;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeFieldInfoPtr_m_DeleteAllButton;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeFieldInfoPtr_furnitureElement;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeFieldInfoPtr_furnitureButtonElement;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeFieldInfoPtr_switchText;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeFieldInfoPtr_outlineArea;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeFieldInfoPtr_m_FurnitureVirtualButtonContent;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeFieldInfoPtr_m_FurnitureContent;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeFieldInfoPtr_currentEditorType;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeFieldInfoPtr_subPanelHasOpened;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeFieldInfoPtr_m_EditorFurniture;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeFieldInfoPtr_allButtonInstances2;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeFieldInfoPtr_allVirtualInstances;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeFieldInfoPtr__subPutPanel;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeFieldInfoPtr_carpetFurnitureSets;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeFieldInfoPtr_currentButton;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeFieldInfoPtr_currentButtonPosition;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeFieldInfoPtr_furnitureContentCanvas;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeFieldInfoPtr_furnitureVirtualButtonContentCanvas;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeFieldInfoPtr_groundFurnitureSets;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeFieldInfoPtr_hasAnyCarpet;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeFieldInfoPtr_hasAnyGround;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeFieldInfoPtr_m_PlacedFurnitureGroup;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeFieldInfoPtr_mainCamera;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeFieldInfoPtr_oldClockAlpha;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeFieldInfoPtr_oldPosition;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeFieldInfoPtr_outlineCanvas;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeFieldInfoPtr_placementRetrievalDictionary;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeFieldInfoPtr_selectableButtons;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeFieldInfoPtr_unselectableButtons;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeFieldInfoPtr_wallFurnitureSets;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeFieldInfoPtr__FlandreHomeMap_k__BackingField;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeFieldInfoPtr__LastStoragePageIndex_k__BackingField;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeFieldInfoPtr__LastStoragePageAlbumType_k__BackingField;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEditorType_Private_get_EditorType_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEditorType_Private_set_Void_EditorType_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_get_EditorFurniture_Public_get_Nullable_1_EditorFurnitureProperty_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_set_EditorFurniture_Private_set_Void_Nullable_1_EditorFurnitureProperty_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_get_FlandreHomeMap_Public_get_FlandreHomeMap_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_set_FlandreHomeMap_Private_set_Void_FlandreHomeMap_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_get_LastStoragePageIndex_Public_get_Int32_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_set_LastStoragePageIndex_Public_set_Void_Int32_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_get_LastStoragePageAlbumType_Public_get_AlbumType_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_set_LastStoragePageAlbumType_Public_set_Void_AlbumType_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_get_OutlineArea_Public_get_Image_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentActiveMap_Private_get_DaySceneMap_0;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmChoiceStart_Private_Void_CallbackContext_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmChoiceEnd_Private_Void_CallbackContext_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_ReverseEditorType_Private_Void_CallbackContext_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_ReverseEditorTypeFunc_Private_Void_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_AutoSetEditorType_Private_Void_Boolean_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_AddToDic_Private_Void_byref_FlandreHomeFurniture_Vector2Int_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPanel_Private_Void_RefreshType_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentEditorTypeByPlacementType_Private_Void_Placement_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_RefreshEditorType_Private_Void_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_EnterNearestPoint_Private_Void_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_HideCharacter_Private_Void_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr_ResetCharacter_Private_Void_0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeMethodInfoPtr_ProcessVirtualSelectedFurnitureElement_Private_Void_UIButtonSimple_KeyValuePair_2_Vector2Int_Vector2Int_0;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeMethodInfoPtr_ProcessButtonFurnitureElement_Private_Void_UIButtonSimple_KeyValuePair_2_Vector2Int_EditorFurnitureProperty_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_SetOutline_Public_Void_Sprite_Vector2_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr_SetOutlinePosition_Public_Void_Vector2_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_OpenStorage_Private_Void_CallbackContext_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_OpenStorageFunc_Private_Void_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_DeleteAllFurniture_Private_Void_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_PutNewFurniture_Public_Void_FlandreHomeFurniture_Vector2Int_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_ResetFurnitureColor_Private_Void_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_WaitForFrameEndAndClosePanel_Public_IEnumerator_Action_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__64_0_Private_Void_Int32_0;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr__RefreshPanel_b__69_0_Private_Boolean_Vector2Int_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr__OpenStorageFunc_b__80_0_Private_Void_0;

		// Token: 0x0200067B RID: 1659
		public enum RefreshType
		{
			// Token: 0x0400610C RID: 24844
			OnOpen,
			// Token: 0x0400610D RID: 24845
			EditorCompleted,
			// Token: 0x0400610E RID: 24846
			EditorCanceled,
			// Token: 0x0400610F RID: 24847
			ClearAll,
			// Token: 0x04006110 RID: 24848
			SwitchEditorMode
		}

		// Token: 0x0200067C RID: 1660
		public class FlandreHomeFurniturePlacementSets : Il2CppSystem.Object
		{
			// Token: 0x060095A2 RID: 38306 RVA: 0x00283A5C File Offset: 0x00281C5C
			// Note: this type is marked as 'beforefieldinit'.
			static FlandreHomeFurniturePlacementSets()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "FlandreHomeFurniturePlacementSets");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>.NativeClassPtr);
				DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeFieldInfoPtr__PlacementType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>.NativeClassPtr, "<PlacementType>k__BackingField");
				DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeFieldInfoPtr__VirtualFurnitureDic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>.NativeClassPtr, "<VirtualFurnitureDic>k__BackingField");
				DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeFieldInfoPtr__ButtonFurnitureDic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>.NativeClassPtr, "<ButtonFurnitureDic>k__BackingField");
				DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeMethodInfoPtr__ctor_Public_Void_Placement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>.NativeClassPtr, 100667758);
				DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeMethodInfoPtr_get_PlacementType_Public_get_Placement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>.NativeClassPtr, 100667759);
				DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeMethodInfoPtr_get_VirtualFurnitureDic_Public_get_Dictionary_2_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>.NativeClassPtr, 100667760);
				DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeMethodInfoPtr_get_ButtonFurnitureDic_Public_get_Dictionary_2_Vector2Int_EditorFurnitureProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>.NativeClassPtr, 100667761);
				DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeMethodInfoPtr_get_AllFurnitureComponent_Public_get_IEnumerable_1_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>.NativeClassPtr, 100667762);
				DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeMethodInfoPtr_ClearAllDic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>.NativeClassPtr, 100667763);
			}

			// Token: 0x060095A3 RID: 38307 RVA: 0x00283B3C File Offset: 0x00281D3C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 67573, RefRangeEnd = 67576, XrefRangeStart = 67558, XrefRangeEnd = 67573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FlandreHomeFurniturePlacementSets(FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placementType) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref placementType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeMethodInfoPtr__ctor_Public_Void_Placement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170031B9 RID: 12729
			// (get) Token: 0x060095A4 RID: 38308 RVA: 0x00283B84 File Offset: 0x00281D84
			public unsafe FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement PlacementType
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeMethodInfoPtr_get_PlacementType_Public_get_Placement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170031BA RID: 12730
			// (get) Token: 0x060095A5 RID: 38309 RVA: 0x00283BC0 File Offset: 0x00281DC0
			public unsafe Dictionary<Vector2Int, Vector2Int> VirtualFurnitureDic
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeMethodInfoPtr_get_VirtualFurnitureDic_Public_get_Dictionary_2_Vector2Int_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector2Int, Vector2Int>>(intPtr3) : null;
				}
			}

			// Token: 0x170031BB RID: 12731
			// (get) Token: 0x060095A6 RID: 38310 RVA: 0x00283C00 File Offset: 0x00281E00
			public unsafe Dictionary<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty> ButtonFurnitureDic
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeMethodInfoPtr_get_ButtonFurnitureDic_Public_get_Dictionary_2_Vector2Int_EditorFurnitureProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>>(intPtr3) : null;
				}
			}

			// Token: 0x170031BC RID: 12732
			// (get) Token: 0x060095A7 RID: 38311 RVA: 0x00283C40 File Offset: 0x00281E40
			public unsafe IEnumerable<FlandreFurnitureComponent> AllFurnitureComponent
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 67600, RefRangeEnd = 67606, XrefRangeStart = 67578, XrefRangeEnd = 67600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeMethodInfoPtr_get_AllFurnitureComponent_Public_get_IEnumerable_1_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FlandreFurnitureComponent>>(intPtr3) : null;
				}
			}

			// Token: 0x060095A8 RID: 38312 RVA: 0x00283C80 File Offset: 0x00281E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67606, XrefRangeEnd = 67613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ClearAllDic()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeMethodInfoPtr_ClearAllDic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095A9 RID: 38313 RVA: 0x00050EEA File Offset: 0x0004F0EA
			public FlandreHomeFurniturePlacementSets(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031B6 RID: 12726
			// (get) Token: 0x060095AA RID: 38314 RVA: 0x00283CB4 File Offset: 0x00281EB4
			// (set) Token: 0x060095AB RID: 38315 RVA: 0x00050EF3 File Offset: 0x0004F0F3
			public unsafe FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement _PlacementType_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeFieldInfoPtr__PlacementType_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeFieldInfoPtr__PlacementType_k__BackingField)) = value;
				}
			}

			// Token: 0x170031B7 RID: 12727
			// (get) Token: 0x060095AC RID: 38316 RVA: 0x00283CDC File Offset: 0x00281EDC
			// (set) Token: 0x060095AD RID: 38317 RVA: 0x00050F0E File Offset: 0x0004F10E
			public unsafe Dictionary<Vector2Int, Vector2Int> _VirtualFurnitureDic_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeFieldInfoPtr__VirtualFurnitureDic_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector2Int, Vector2Int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeFieldInfoPtr__VirtualFurnitureDic_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031B8 RID: 12728
			// (get) Token: 0x060095AE RID: 38318 RVA: 0x00283D0C File Offset: 0x00281F0C
			// (set) Token: 0x060095AF RID: 38319 RVA: 0x00050F2D File Offset: 0x0004F12D
			public unsafe Dictionary<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty> _ButtonFurnitureDic_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeFieldInfoPtr__ButtonFurnitureDic_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.NativeFieldInfoPtr__ButtonFurnitureDic_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006111 RID: 24849
			private static readonly IntPtr NativeFieldInfoPtr__PlacementType_k__BackingField;

			// Token: 0x04006112 RID: 24850
			private static readonly IntPtr NativeFieldInfoPtr__VirtualFurnitureDic_k__BackingField;

			// Token: 0x04006113 RID: 24851
			private static readonly IntPtr NativeFieldInfoPtr__ButtonFurnitureDic_k__BackingField;

			// Token: 0x04006114 RID: 24852
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Placement_0;

			// Token: 0x04006115 RID: 24853
			private static readonly IntPtr NativeMethodInfoPtr_get_PlacementType_Public_get_Placement_0;

			// Token: 0x04006116 RID: 24854
			private static readonly IntPtr NativeMethodInfoPtr_get_VirtualFurnitureDic_Public_get_Dictionary_2_Vector2Int_Vector2Int_0;

			// Token: 0x04006117 RID: 24855
			private static readonly IntPtr NativeMethodInfoPtr_get_ButtonFurnitureDic_Public_get_Dictionary_2_Vector2Int_EditorFurnitureProperty_0;

			// Token: 0x04006118 RID: 24856
			private static readonly IntPtr NativeMethodInfoPtr_get_AllFurnitureComponent_Public_get_IEnumerable_1_FlandreFurnitureComponent_0;

			// Token: 0x04006119 RID: 24857
			private static readonly IntPtr NativeMethodInfoPtr_ClearAllDic_Public_Void_0;

			// Token: 0x02000FC5 RID: 4037
			[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationEditorPanel+FlandreHomeFurniturePlacementSets+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x060115F5 RID: 71157 RVA: 0x003FEA18 File Offset: 0x003FCC18
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c>.NativeClassPtr);
					DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c>.NativeClassPtr, "<>9");
					DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c>.NativeClassPtr, "<>9__11_0");
					DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c>.NativeClassPtr, 100667765);
					DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c.NativeMethodInfoPtr__get_AllFurnitureComponent_b__11_0_Internal_FlandreFurnitureComponent_EditorFurnitureProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c>.NativeClassPtr, 100667766);
				}

				// Token: 0x060115F6 RID: 71158 RVA: 0x003FEA94 File Offset: 0x003FCC94
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060115F7 RID: 71159 RVA: 0x003FEAD0 File Offset: 0x003FCCD0
				[CallerCount(0)]
				public unsafe FlandreFurnitureComponent _get_AllFurnitureComponent_b__11_0(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c.NativeMethodInfoPtr__get_AllFurnitureComponent_b__11_0_Internal_FlandreFurnitureComponent_EditorFurnitureProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<FlandreFurnitureComponent>(intPtr3) : null;
				}

				// Token: 0x060115F8 RID: 71160 RVA: 0x0009730C File Offset: 0x0009550C
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A4C RID: 23116
				// (get) Token: 0x060115F9 RID: 71161 RVA: 0x003FEB28 File Offset: 0x003FCD28
				// (set) Token: 0x060115FA RID: 71162 RVA: 0x00097315 File Offset: 0x00095515
				public unsafe static DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A4D RID: 23117
				// (get) Token: 0x060115FB RID: 71163 RVA: 0x003FEB50 File Offset: 0x003FCD50
				// (set) Token: 0x060115FC RID: 71164 RVA: 0x00097327 File Offset: 0x00095527
				public unsafe static Func<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty, FlandreFurnitureComponent> __9__11_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty, FlandreFurnitureComponent>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AF8E RID: 44942
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400AF8F RID: 44943
				private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

				// Token: 0x0400AF90 RID: 44944
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AF91 RID: 44945
				private static readonly IntPtr NativeMethodInfoPtr__get_AllFurnitureComponent_b__11_0_Internal_FlandreFurnitureComponent_EditorFurnitureProperty_0;
			}
		}

		// Token: 0x0200067D RID: 1661
		public sealed class EditorFurnitureProperty : ValueType
		{
			// Token: 0x060095B0 RID: 38320 RVA: 0x00283D3C File Offset: 0x00281F3C
			// Note: this type is marked as 'beforefieldinit'.
			static EditorFurnitureProperty()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "EditorFurnitureProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr);
				DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_Furniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr, "Furniture");
				DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_MemoryPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr, "MemoryPosition");
				DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_ButtonPositionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr, "ButtonPositionList");
				DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_TargetFurnitureInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr, "TargetFurnitureInstance");
				DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_CenterPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr, "CenterPoint");
				DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeMethodInfoPtr__ctor_Public_Void_FlandreHomeFurniture_Vector2Int_Il2CppStructArray_1_Vector2Int_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr, 100667767);
				DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr, 100667768);
			}

			// Token: 0x060095B1 RID: 38321 RVA: 0x00283DF4 File Offset: 0x00281FF4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67724, RefRangeEnd = 67726, XrefRangeStart = 67619, XrefRangeEnd = 67724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EditorFurnitureProperty(FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int memoryPosition, Il2CppStructArray<Vector2Int> buttonPositionList, FlandreFurnitureComponent targetFurnitureInstance) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref memoryPosition;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttonPositionList);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetFurnitureInstance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeMethodInfoPtr__ctor_Public_Void_FlandreHomeFurniture_Vector2Int_Il2CppStructArray_1_Vector2Int_FlandreFurnitureComponent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095B2 RID: 38322 RVA: 0x00283E7C File Offset: 0x0028207C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67726, XrefRangeEnd = 67727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060095B3 RID: 38323 RVA: 0x00050F4C File Offset: 0x0004F14C
			public EditorFurnitureProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060095B4 RID: 38324 RVA: 0x00050F55 File Offset: 0x0004F155
			public EditorFurnitureProperty() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr))
			{
			}

			// Token: 0x170031BD RID: 12733
			// (get) Token: 0x060095B5 RID: 38325 RVA: 0x00283EB8 File Offset: 0x002820B8
			// (set) Token: 0x060095B6 RID: 38326 RVA: 0x00050F67 File Offset: 0x0004F167
			public FlandreHomeFurnitureProfile.FlandreHomeFurniture Furniture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_Furniture);
					return new FlandreHomeFurnitureProfile.FlandreHomeFurniture(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_Furniture), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170031BE RID: 12734
			// (get) Token: 0x060095B7 RID: 38327 RVA: 0x00283EE8 File Offset: 0x002820E8
			// (set) Token: 0x060095B8 RID: 38328 RVA: 0x00050F95 File Offset: 0x0004F195
			public unsafe Vector2Int MemoryPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_MemoryPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_MemoryPosition)) = value;
				}
			}

			// Token: 0x170031BF RID: 12735
			// (get) Token: 0x060095B9 RID: 38329 RVA: 0x00283F10 File Offset: 0x00282110
			// (set) Token: 0x060095BA RID: 38330 RVA: 0x00050FB0 File Offset: 0x0004F1B0
			public unsafe Il2CppStructArray<Vector2Int> ButtonPositionList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_ButtonPositionList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_ButtonPositionList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031C0 RID: 12736
			// (get) Token: 0x060095BB RID: 38331 RVA: 0x00283F40 File Offset: 0x00282140
			// (set) Token: 0x060095BC RID: 38332 RVA: 0x00050FCF File Offset: 0x0004F1CF
			public unsafe FlandreFurnitureComponent TargetFurnitureInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_TargetFurnitureInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlandreFurnitureComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_TargetFurnitureInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031C1 RID: 12737
			// (get) Token: 0x060095BD RID: 38333 RVA: 0x00283F70 File Offset: 0x00282170
			// (set) Token: 0x060095BE RID: 38334 RVA: 0x00050FEE File Offset: 0x0004F1EE
			public unsafe Vector2Int CenterPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_CenterPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.NativeFieldInfoPtr_CenterPoint)) = value;
				}
			}

			// Token: 0x0400611A RID: 24858
			private static readonly IntPtr NativeFieldInfoPtr_Furniture;

			// Token: 0x0400611B RID: 24859
			private static readonly IntPtr NativeFieldInfoPtr_MemoryPosition;

			// Token: 0x0400611C RID: 24860
			private static readonly IntPtr NativeFieldInfoPtr_ButtonPositionList;

			// Token: 0x0400611D RID: 24861
			private static readonly IntPtr NativeFieldInfoPtr_TargetFurnitureInstance;

			// Token: 0x0400611E RID: 24862
			private static readonly IntPtr NativeFieldInfoPtr_CenterPoint;

			// Token: 0x0400611F RID: 24863
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FlandreHomeFurniture_Vector2Int_Il2CppStructArray_1_Vector2Int_FlandreFurnitureComponent_0;

			// Token: 0x04006120 RID: 24864
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x02000FC6 RID: 4038
			[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationEditorPanel+EditorFurnitureProperty+<>c__DisplayClass5_0")]
			public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
			{
				// Token: 0x060115FD RID: 71165 RVA: 0x003FEB78 File Offset: 0x003FCD78
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass5_0()
				{
					Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr, "<>c__DisplayClass5_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c__DisplayClass5_0>.NativeClassPtr);
					DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c__DisplayClass5_0.NativeFieldInfoPtr_oldPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c__DisplayClass5_0>.NativeClassPtr, "oldPoint");
					DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c__DisplayClass5_0>.NativeClassPtr, 100667769);
					DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c__DisplayClass5_0.NativeMethodInfoPtr___ctor_b__2_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c__DisplayClass5_0>.NativeClassPtr, 100667770);
				}

				// Token: 0x060115FE RID: 71166 RVA: 0x003FEBE0 File Offset: 0x003FCDE0
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c__DisplayClass5_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060115FF RID: 71167 RVA: 0x003FEC1C File Offset: 0x003FCE1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67613, XrefRangeEnd = 67619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int __ctor_b__2(Vector2Int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c__DisplayClass5_0.NativeMethodInfoPtr___ctor_b__2_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011600 RID: 71168 RVA: 0x00097339 File Offset: 0x00095539
				public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A4E RID: 23118
				// (get) Token: 0x06011601 RID: 71169 RVA: 0x003FEC68 File Offset: 0x003FCE68
				// (set) Token: 0x06011602 RID: 71170 RVA: 0x00097342 File Offset: 0x00095542
				public unsafe Vector2Int oldPoint
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c__DisplayClass5_0.NativeFieldInfoPtr_oldPoint);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c__DisplayClass5_0.NativeFieldInfoPtr_oldPoint)) = value;
					}
				}

				// Token: 0x0400AF92 RID: 44946
				private static readonly IntPtr NativeFieldInfoPtr_oldPoint;

				// Token: 0x0400AF93 RID: 44947
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AF94 RID: 44948
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__2_Internal_Int32_Vector2Int_0;
			}

			// Token: 0x02000FC7 RID: 4039
			[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationEditorPanel+EditorFurnitureProperty+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x06011603 RID: 71171 RVA: 0x003FEC90 File Offset: 0x003FCE90
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>.NativeClassPtr);
					DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>.NativeClassPtr, "<>9");
					DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>.NativeClassPtr, "<>9__5_0");
					DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>.NativeClassPtr, "<>9__5_1");
					DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9__5_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>.NativeClassPtr, "<>9__5_3");
					DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9__5_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>.NativeClassPtr, "<>9__5_4");
					DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>.NativeClassPtr, 100667772);
					DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>.NativeClassPtr, 100667773);
					DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeMethodInfoPtr___ctor_b__5_1_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>.NativeClassPtr, 100667774);
					DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeMethodInfoPtr___ctor_b__5_3_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>.NativeClassPtr, 100667775);
					DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeMethodInfoPtr___ctor_b__5_4_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>.NativeClassPtr, 100667776);
				}

				// Token: 0x06011604 RID: 71172 RVA: 0x003FED84 File Offset: 0x003FCF84
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011605 RID: 71173 RVA: 0x003FEDC0 File Offset: 0x003FCFC0
				[CallerCount(0)]
				public unsafe int __ctor_b__5_0(Vector2Int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011606 RID: 71174 RVA: 0x003FEE0C File Offset: 0x003FD00C
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 2790, RefRangeEnd = 2793, XrefRangeStart = 2790, XrefRangeEnd = 2793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int __ctor_b__5_1(Vector2Int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeMethodInfoPtr___ctor_b__5_1_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011607 RID: 71175 RVA: 0x003FEE58 File Offset: 0x003FD058
				[CallerCount(0)]
				public unsafe int __ctor_b__5_3(Vector2Int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeMethodInfoPtr___ctor_b__5_3_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011608 RID: 71176 RVA: 0x003FEEA4 File Offset: 0x003FD0A4
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 2790, RefRangeEnd = 2793, XrefRangeStart = 2790, XrefRangeEnd = 2793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int __ctor_b__5_4(Vector2Int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeMethodInfoPtr___ctor_b__5_4_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011609 RID: 71177 RVA: 0x0009735D File Offset: 0x0009555D
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005A4F RID: 23119
				// (get) Token: 0x0601160A RID: 71178 RVA: 0x003FEEF0 File Offset: 0x003FD0F0
				// (set) Token: 0x0601160B RID: 71179 RVA: 0x00097366 File Offset: 0x00095566
				public unsafe static DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A50 RID: 23120
				// (get) Token: 0x0601160C RID: 71180 RVA: 0x003FEF18 File Offset: 0x003FD118
				// (set) Token: 0x0601160D RID: 71181 RVA: 0x00097378 File Offset: 0x00095578
				public unsafe static Func<Vector2Int, int> __9__5_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A51 RID: 23121
				// (get) Token: 0x0601160E RID: 71182 RVA: 0x003FEF40 File Offset: 0x003FD140
				// (set) Token: 0x0601160F RID: 71183 RVA: 0x0009738A File Offset: 0x0009558A
				public unsafe static Func<Vector2Int, int> __9__5_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A52 RID: 23122
				// (get) Token: 0x06011610 RID: 71184 RVA: 0x003FEF68 File Offset: 0x003FD168
				// (set) Token: 0x06011611 RID: 71185 RVA: 0x0009739C File Offset: 0x0009559C
				public unsafe static Func<Vector2Int, int> __9__5_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9__5_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9__5_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005A53 RID: 23123
				// (get) Token: 0x06011612 RID: 71186 RVA: 0x003FEF90 File Offset: 0x003FD190
				// (set) Token: 0x06011613 RID: 71187 RVA: 0x000973AE File Offset: 0x000955AE
				public unsafe static Func<Vector2Int, int> __9__5_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9__5_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty.__c.NativeFieldInfoPtr___9__5_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AF95 RID: 44949
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400AF96 RID: 44950
				private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

				// Token: 0x0400AF97 RID: 44951
				private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

				// Token: 0x0400AF98 RID: 44952
				private static readonly IntPtr NativeFieldInfoPtr___9__5_3;

				// Token: 0x0400AF99 RID: 44953
				private static readonly IntPtr NativeFieldInfoPtr___9__5_4;

				// Token: 0x0400AF9A RID: 44954
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400AF9B RID: 44955
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_0_Internal_Int32_Vector2Int_0;

				// Token: 0x0400AF9C RID: 44956
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_1_Internal_Int32_Vector2Int_0;

				// Token: 0x0400AF9D RID: 44957
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_3_Internal_Int32_Vector2Int_0;

				// Token: 0x0400AF9E RID: 44958
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_4_Internal_Int32_Vector2Int_0;
			}
		}

		// Token: 0x0200067E RID: 1662
		public enum EditorType
		{
			// Token: 0x04006122 RID: 24866
			Carpet,
			// Token: 0x04006123 RID: 24867
			Ground
		}

		// Token: 0x0200067F RID: 1663
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationEditorPanel+<>c__DisplayClass64_0")]
		public sealed class __c__DisplayClass64_0 : Il2CppSystem.Object
		{
			// Token: 0x060095BF RID: 38335 RVA: 0x00283F98 File Offset: 0x00282198
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass64_0()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "<>c__DisplayClass64_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0>.NativeClassPtr);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0.NativeFieldInfoPtr_furniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0>.NativeClassPtr, "furniture");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0>.NativeClassPtr, "<>4__this");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0>.NativeClassPtr, 100667777);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0>.NativeClassPtr, 100667778);
			}

			// Token: 0x060095C0 RID: 38336 RVA: 0x00284014 File Offset: 0x00282214
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass64_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095C1 RID: 38337 RVA: 0x00284050 File Offset: 0x00282250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67727, XrefRangeEnd = 67729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__1(Vector2Int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095C2 RID: 38338 RVA: 0x00051009 File Offset: 0x0004F209
			public __c__DisplayClass64_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031C2 RID: 12738
			// (get) Token: 0x060095C3 RID: 38339 RVA: 0x00284090 File Offset: 0x00282290
			// (set) Token: 0x060095C4 RID: 38340 RVA: 0x00051012 File Offset: 0x0004F212
			public FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0.NativeFieldInfoPtr_furniture);
					return new FlandreHomeFurnitureProfile.FlandreHomeFurniture(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0.NativeFieldInfoPtr_furniture), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FlandreHomeFurnitureProfile.FlandreHomeFurniture>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170031C3 RID: 12739
			// (get) Token: 0x060095C5 RID: 38341 RVA: 0x002840C0 File Offset: 0x002822C0
			// (set) Token: 0x060095C6 RID: 38342 RVA: 0x00051040 File Offset: 0x0004F240
			public unsafe DLC4_FlandreHomeDecorationEditorPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006124 RID: 24868
			private static readonly IntPtr NativeFieldInfoPtr_furniture;

			// Token: 0x04006125 RID: 24869
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006126 RID: 24870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006127 RID: 24871
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_Vector2Int_0;
		}

		// Token: 0x02000680 RID: 1664
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationEditorPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060095C7 RID: 38343 RVA: 0x002840F0 File Offset: 0x002822F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr);
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, "<>9");
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__68_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, "<>9__68_0");
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__68_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, "<>9__68_1");
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__68_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, "<>9__68_2");
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__68_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, "<>9__68_3");
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__71_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, "<>9__71_0");
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__71_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, "<>9__71_1");
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__71_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, "<>9__71_2");
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__71_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, "<>9__71_3");
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__84_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, "<>9__84_0");
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__84_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, "<>9__84_1");
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, 100667780);
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__AddToDic_b__68_0_Internal_Vector2Int_KeyValuePair_2_Vector2Int_EditorFurnitureProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, 100667781);
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__AddToDic_b__68_1_Internal_String_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, 100667782);
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__AddToDic_b__68_2_Internal_Vector2Int_KeyValuePair_2_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, 100667783);
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__AddToDic_b__68_3_Internal_String_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, 100667784);
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__RefreshEditorType_b__71_0_Internal_Void_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, 100667785);
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__RefreshEditorType_b__71_1_Internal_Void_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, 100667786);
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__RefreshEditorType_b__71_2_Internal_Void_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, 100667787);
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__RefreshEditorType_b__71_3_Internal_Void_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, 100667788);
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__ResetFurnitureColor_b__84_0_Internal_Void_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, 100667789);
				DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__ResetFurnitureColor_b__84_1_Internal_Void_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr, 100667790);
			}

			// Token: 0x060095C8 RID: 38344 RVA: 0x002842D4 File Offset: 0x002824D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095C9 RID: 38345 RVA: 0x00284310 File Offset: 0x00282510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67729, XrefRangeEnd = 67730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2Int _AddToDic_b__68_0(KeyValuePair<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__AddToDic_b__68_0_Internal_Vector2Int_KeyValuePair_2_Vector2Int_EditorFurnitureProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060095CA RID: 38346 RVA: 0x00284364 File Offset: 0x00282564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67730, XrefRangeEnd = 67738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _AddToDic_b__68_1(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__AddToDic_b__68_1_Internal_String_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060095CB RID: 38347 RVA: 0x002843A8 File Offset: 0x002825A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67738, XrefRangeEnd = 67739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2Int _AddToDic_b__68_2(KeyValuePair<Vector2Int, Vector2Int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__AddToDic_b__68_2_Internal_Vector2Int_KeyValuePair_2_Vector2Int_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060095CC RID: 38348 RVA: 0x002843FC File Offset: 0x002825FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67739, XrefRangeEnd = 67747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _AddToDic_b__68_3(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__AddToDic_b__68_3_Internal_String_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060095CD RID: 38349 RVA: 0x00284440 File Offset: 0x00282640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67747, XrefRangeEnd = 67749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshEditorType_b__71_0(FlandreFurnitureComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__RefreshEditorType_b__71_0_Internal_Void_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095CE RID: 38350 RVA: 0x00284484 File Offset: 0x00282684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67749, XrefRangeEnd = 67751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshEditorType_b__71_1(FlandreFurnitureComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__RefreshEditorType_b__71_1_Internal_Void_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095CF RID: 38351 RVA: 0x002844C8 File Offset: 0x002826C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshEditorType_b__71_2(FlandreFurnitureComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__RefreshEditorType_b__71_2_Internal_Void_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095D0 RID: 38352 RVA: 0x0028450C File Offset: 0x0028270C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshEditorType_b__71_3(FlandreFurnitureComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__RefreshEditorType_b__71_3_Internal_Void_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095D1 RID: 38353 RVA: 0x00284550 File Offset: 0x00282750
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ResetFurnitureColor_b__84_0(FlandreFurnitureComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__ResetFurnitureColor_b__84_0_Internal_Void_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095D2 RID: 38354 RVA: 0x00284594 File Offset: 0x00282794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ResetFurnitureColor_b__84_1(FlandreFurnitureComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeMethodInfoPtr__ResetFurnitureColor_b__84_1_Internal_Void_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095D3 RID: 38355 RVA: 0x0005105F File Offset: 0x0004F25F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031C4 RID: 12740
			// (get) Token: 0x060095D4 RID: 38356 RVA: 0x002845D8 File Offset: 0x002827D8
			// (set) Token: 0x060095D5 RID: 38357 RVA: 0x00051068 File Offset: 0x0004F268
			public unsafe static DLC4_FlandreHomeDecorationEditorPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031C5 RID: 12741
			// (get) Token: 0x060095D6 RID: 38358 RVA: 0x00284600 File Offset: 0x00282800
			// (set) Token: 0x060095D7 RID: 38359 RVA: 0x0005107A File Offset: 0x0004F27A
			public unsafe static Func<KeyValuePair<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>, Vector2Int> __9__68_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__68_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>, Vector2Int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__68_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031C6 RID: 12742
			// (get) Token: 0x060095D8 RID: 38360 RVA: 0x00284628 File Offset: 0x00282828
			// (set) Token: 0x060095D9 RID: 38361 RVA: 0x0005108C File Offset: 0x0004F28C
			public unsafe static Func<Vector2Int, string> __9__68_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__68_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__68_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031C7 RID: 12743
			// (get) Token: 0x060095DA RID: 38362 RVA: 0x00284650 File Offset: 0x00282850
			// (set) Token: 0x060095DB RID: 38363 RVA: 0x0005109E File Offset: 0x0004F29E
			public unsafe static Func<KeyValuePair<Vector2Int, Vector2Int>, Vector2Int> __9__68_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__68_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Vector2Int, Vector2Int>, Vector2Int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__68_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031C8 RID: 12744
			// (get) Token: 0x060095DC RID: 38364 RVA: 0x00284678 File Offset: 0x00282878
			// (set) Token: 0x060095DD RID: 38365 RVA: 0x000510B0 File Offset: 0x0004F2B0
			public unsafe static Func<Vector2Int, string> __9__68_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__68_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__68_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031C9 RID: 12745
			// (get) Token: 0x060095DE RID: 38366 RVA: 0x002846A0 File Offset: 0x002828A0
			// (set) Token: 0x060095DF RID: 38367 RVA: 0x000510C2 File Offset: 0x0004F2C2
			public unsafe static Action<FlandreFurnitureComponent> __9__71_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__71_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FlandreFurnitureComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__71_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031CA RID: 12746
			// (get) Token: 0x060095E0 RID: 38368 RVA: 0x002846C8 File Offset: 0x002828C8
			// (set) Token: 0x060095E1 RID: 38369 RVA: 0x000510D4 File Offset: 0x0004F2D4
			public unsafe static Action<FlandreFurnitureComponent> __9__71_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__71_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FlandreFurnitureComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__71_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031CB RID: 12747
			// (get) Token: 0x060095E2 RID: 38370 RVA: 0x002846F0 File Offset: 0x002828F0
			// (set) Token: 0x060095E3 RID: 38371 RVA: 0x000510E6 File Offset: 0x0004F2E6
			public unsafe static Action<FlandreFurnitureComponent> __9__71_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__71_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FlandreFurnitureComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__71_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031CC RID: 12748
			// (get) Token: 0x060095E4 RID: 38372 RVA: 0x00284718 File Offset: 0x00282918
			// (set) Token: 0x060095E5 RID: 38373 RVA: 0x000510F8 File Offset: 0x0004F2F8
			public unsafe static Action<FlandreFurnitureComponent> __9__71_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__71_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FlandreFurnitureComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__71_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031CD RID: 12749
			// (get) Token: 0x060095E6 RID: 38374 RVA: 0x00284740 File Offset: 0x00282940
			// (set) Token: 0x060095E7 RID: 38375 RVA: 0x0005110A File Offset: 0x0004F30A
			public unsafe static Action<FlandreFurnitureComponent> __9__84_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__84_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FlandreFurnitureComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__84_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031CE RID: 12750
			// (get) Token: 0x060095E8 RID: 38376 RVA: 0x00284768 File Offset: 0x00282968
			// (set) Token: 0x060095E9 RID: 38377 RVA: 0x0005111C File Offset: 0x0004F31C
			public unsafe static Action<FlandreFurnitureComponent> __9__84_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__84_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FlandreFurnitureComponent>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorPanel.__c.NativeFieldInfoPtr___9__84_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006128 RID: 24872
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006129 RID: 24873
			private static readonly IntPtr NativeFieldInfoPtr___9__68_0;

			// Token: 0x0400612A RID: 24874
			private static readonly IntPtr NativeFieldInfoPtr___9__68_1;

			// Token: 0x0400612B RID: 24875
			private static readonly IntPtr NativeFieldInfoPtr___9__68_2;

			// Token: 0x0400612C RID: 24876
			private static readonly IntPtr NativeFieldInfoPtr___9__68_3;

			// Token: 0x0400612D RID: 24877
			private static readonly IntPtr NativeFieldInfoPtr___9__71_0;

			// Token: 0x0400612E RID: 24878
			private static readonly IntPtr NativeFieldInfoPtr___9__71_1;

			// Token: 0x0400612F RID: 24879
			private static readonly IntPtr NativeFieldInfoPtr___9__71_2;

			// Token: 0x04006130 RID: 24880
			private static readonly IntPtr NativeFieldInfoPtr___9__71_3;

			// Token: 0x04006131 RID: 24881
			private static readonly IntPtr NativeFieldInfoPtr___9__84_0;

			// Token: 0x04006132 RID: 24882
			private static readonly IntPtr NativeFieldInfoPtr___9__84_1;

			// Token: 0x04006133 RID: 24883
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006134 RID: 24884
			private static readonly IntPtr NativeMethodInfoPtr__AddToDic_b__68_0_Internal_Vector2Int_KeyValuePair_2_Vector2Int_EditorFurnitureProperty_0;

			// Token: 0x04006135 RID: 24885
			private static readonly IntPtr NativeMethodInfoPtr__AddToDic_b__68_1_Internal_String_Vector2Int_0;

			// Token: 0x04006136 RID: 24886
			private static readonly IntPtr NativeMethodInfoPtr__AddToDic_b__68_2_Internal_Vector2Int_KeyValuePair_2_Vector2Int_Vector2Int_0;

			// Token: 0x04006137 RID: 24887
			private static readonly IntPtr NativeMethodInfoPtr__AddToDic_b__68_3_Internal_String_Vector2Int_0;

			// Token: 0x04006138 RID: 24888
			private static readonly IntPtr NativeMethodInfoPtr__RefreshEditorType_b__71_0_Internal_Void_FlandreFurnitureComponent_0;

			// Token: 0x04006139 RID: 24889
			private static readonly IntPtr NativeMethodInfoPtr__RefreshEditorType_b__71_1_Internal_Void_FlandreFurnitureComponent_0;

			// Token: 0x0400613A RID: 24890
			private static readonly IntPtr NativeMethodInfoPtr__RefreshEditorType_b__71_2_Internal_Void_FlandreFurnitureComponent_0;

			// Token: 0x0400613B RID: 24891
			private static readonly IntPtr NativeMethodInfoPtr__RefreshEditorType_b__71_3_Internal_Void_FlandreFurnitureComponent_0;

			// Token: 0x0400613C RID: 24892
			private static readonly IntPtr NativeMethodInfoPtr__ResetFurnitureColor_b__84_0_Internal_Void_FlandreFurnitureComponent_0;

			// Token: 0x0400613D RID: 24893
			private static readonly IntPtr NativeMethodInfoPtr__ResetFurnitureColor_b__84_1_Internal_Void_FlandreFurnitureComponent_0;
		}

		// Token: 0x02000681 RID: 1665
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationEditorPanel+<>c__DisplayClass72_0")]
		public sealed class __c__DisplayClass72_0 : Il2CppSystem.Object
		{
			// Token: 0x060095EA RID: 38378 RVA: 0x00284790 File Offset: 0x00282990
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass72_0()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "<>c__DisplayClass72_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0>.NativeClassPtr);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0>.NativeClassPtr, "<>4__this");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0.NativeFieldInfoPtr_nearestPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0>.NativeClassPtr, "nearestPoint");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0>.NativeClassPtr, 100667791);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0.NativeMethodInfoPtr__EnterNearestPoint_b__0_Internal_Single_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0>.NativeClassPtr, 100667792);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0.NativeMethodInfoPtr__EnterNearestPoint_b__1_Internal_Boolean_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0>.NativeClassPtr, 100667793);
			}

			// Token: 0x060095EB RID: 38379 RVA: 0x00284820 File Offset: 0x00282A20
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass72_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095EC RID: 38380 RVA: 0x0028485C File Offset: 0x00282A5C
			[CallerCount(0)]
			public unsafe float _EnterNearestPoint_b__0(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0.NativeMethodInfoPtr__EnterNearestPoint_b__0_Internal_Single_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060095ED RID: 38381 RVA: 0x002848A8 File Offset: 0x00282AA8
			[CallerCount(0)]
			public unsafe bool _EnterNearestPoint_b__1(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0.NativeMethodInfoPtr__EnterNearestPoint_b__1_Internal_Boolean_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060095EE RID: 38382 RVA: 0x0005112E File Offset: 0x0004F32E
			public __c__DisplayClass72_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031CF RID: 12751
			// (get) Token: 0x060095EF RID: 38383 RVA: 0x002848F4 File Offset: 0x00282AF4
			// (set) Token: 0x060095F0 RID: 38384 RVA: 0x00051137 File Offset: 0x0004F337
			public unsafe DLC4_FlandreHomeDecorationEditorPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031D0 RID: 12752
			// (get) Token: 0x060095F1 RID: 38385 RVA: 0x00284924 File Offset: 0x00282B24
			// (set) Token: 0x060095F2 RID: 38386 RVA: 0x00051156 File Offset: 0x0004F356
			public unsafe Vector2Int nearestPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0.NativeFieldInfoPtr_nearestPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass72_0.NativeFieldInfoPtr_nearestPoint)) = value;
				}
			}

			// Token: 0x0400613E RID: 24894
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400613F RID: 24895
			private static readonly IntPtr NativeFieldInfoPtr_nearestPoint;

			// Token: 0x04006140 RID: 24896
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006141 RID: 24897
			private static readonly IntPtr NativeMethodInfoPtr__EnterNearestPoint_b__0_Internal_Single_Vector2Int_0;

			// Token: 0x04006142 RID: 24898
			private static readonly IntPtr NativeMethodInfoPtr__EnterNearestPoint_b__1_Internal_Boolean_Vector2Int_0;
		}

		// Token: 0x02000682 RID: 1666
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationEditorPanel+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x060095F3 RID: 38387 RVA: 0x0028494C File Offset: 0x00282B4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0>.NativeClassPtr);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0>.NativeClassPtr, "<>4__this");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeFieldInfoPtr_virtualButtonPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0>.NativeClassPtr, "virtualButtonPosition");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeFieldInfoPtr_realButtonPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0>.NativeClassPtr, "realButtonPosition");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0>.NativeClassPtr, "<>9__2");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0>.NativeClassPtr, 100667794);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeMethodInfoPtr__ProcessVirtualSelectedFurnitureElement_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0>.NativeClassPtr, 100667795);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeMethodInfoPtr__ProcessVirtualSelectedFurnitureElement_b__2_Internal_Boolean_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0>.NativeClassPtr, 100667796);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeMethodInfoPtr__ProcessVirtualSelectedFurnitureElement_b__1_Internal_Void_InputButton_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0>.NativeClassPtr, 100667797);
			}

			// Token: 0x060095F4 RID: 38388 RVA: 0x00284A18 File Offset: 0x00282C18
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095F5 RID: 38389 RVA: 0x00284A54 File Offset: 0x00282C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67751, XrefRangeEnd = 67779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessVirtualSelectedFurnitureElement_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeMethodInfoPtr__ProcessVirtualSelectedFurnitureElement_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095F6 RID: 38390 RVA: 0x00284A88 File Offset: 0x00282C88
			[CallerCount(0)]
			public unsafe bool _ProcessVirtualSelectedFurnitureElement_b__2(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeMethodInfoPtr__ProcessVirtualSelectedFurnitureElement_b__2_Internal_Boolean_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060095F7 RID: 38391 RVA: 0x00284AD4 File Offset: 0x00282CD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67779, XrefRangeEnd = 67784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessVirtualSelectedFurnitureElement_b__1(PointerEventData.InputButton _, Vector2 _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref _;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeMethodInfoPtr__ProcessVirtualSelectedFurnitureElement_b__1_Internal_Void_InputButton_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060095F8 RID: 38392 RVA: 0x00051171 File Offset: 0x0004F371
			public __c__DisplayClass75_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031D1 RID: 12753
			// (get) Token: 0x060095F9 RID: 38393 RVA: 0x00284B20 File Offset: 0x00282D20
			// (set) Token: 0x060095FA RID: 38394 RVA: 0x0005117A File Offset: 0x0004F37A
			public unsafe DLC4_FlandreHomeDecorationEditorPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031D2 RID: 12754
			// (get) Token: 0x060095FB RID: 38395 RVA: 0x00284B50 File Offset: 0x00282D50
			// (set) Token: 0x060095FC RID: 38396 RVA: 0x00051199 File Offset: 0x0004F399
			public unsafe Vector2Int virtualButtonPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeFieldInfoPtr_virtualButtonPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeFieldInfoPtr_virtualButtonPosition)) = value;
				}
			}

			// Token: 0x170031D3 RID: 12755
			// (get) Token: 0x060095FD RID: 38397 RVA: 0x00284B78 File Offset: 0x00282D78
			// (set) Token: 0x060095FE RID: 38398 RVA: 0x000511B4 File Offset: 0x0004F3B4
			public unsafe Vector2Int realButtonPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeFieldInfoPtr_realButtonPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeFieldInfoPtr_realButtonPosition)) = value;
				}
			}

			// Token: 0x170031D4 RID: 12756
			// (get) Token: 0x060095FF RID: 38399 RVA: 0x00284BA0 File Offset: 0x00282DA0
			// (set) Token: 0x06009600 RID: 38400 RVA: 0x000511CF File Offset: 0x0004F3CF
			public unsafe Predicate<Vector2Int> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Vector2Int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass75_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006143 RID: 24899
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006144 RID: 24900
			private static readonly IntPtr NativeFieldInfoPtr_virtualButtonPosition;

			// Token: 0x04006145 RID: 24901
			private static readonly IntPtr NativeFieldInfoPtr_realButtonPosition;

			// Token: 0x04006146 RID: 24902
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04006147 RID: 24903
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006148 RID: 24904
			private static readonly IntPtr NativeMethodInfoPtr__ProcessVirtualSelectedFurnitureElement_b__0_Internal_Void_0;

			// Token: 0x04006149 RID: 24905
			private static readonly IntPtr NativeMethodInfoPtr__ProcessVirtualSelectedFurnitureElement_b__2_Internal_Boolean_Vector2Int_0;

			// Token: 0x0400614A RID: 24906
			private static readonly IntPtr NativeMethodInfoPtr__ProcessVirtualSelectedFurnitureElement_b__1_Internal_Void_InputButton_Vector2_0;
		}

		// Token: 0x02000683 RID: 1667
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationEditorPanel+<>c__DisplayClass76_0")]
		public sealed class __c__DisplayClass76_0 : Il2CppSystem.Object
		{
			// Token: 0x06009601 RID: 38401 RVA: 0x00284BD0 File Offset: 0x00282DD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass76_0()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "<>c__DisplayClass76_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0>.NativeClassPtr);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0>.NativeClassPtr, "<>4__this");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr_thisPairPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0>.NativeClassPtr, "thisPairPosition");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr_furnitureProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0>.NativeClassPtr, "furnitureProperty");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr_thisButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0>.NativeClassPtr, "thisButton");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0>.NativeClassPtr, "<>9__3");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0>.NativeClassPtr, 100667798);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__ProcessButtonFurnitureElement_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0>.NativeClassPtr, 100667799);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__ProcessButtonFurnitureElement_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0>.NativeClassPtr, 100667800);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__ProcessButtonFurnitureElement_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0>.NativeClassPtr, 100667801);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__ProcessButtonFurnitureElement_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0>.NativeClassPtr, 100667802);
			}

			// Token: 0x06009602 RID: 38402 RVA: 0x00284CC4 File Offset: 0x00282EC4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass76_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009603 RID: 38403 RVA: 0x00284D00 File Offset: 0x00282F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67784, XrefRangeEnd = 67802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessButtonFurnitureElement_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__ProcessButtonFurnitureElement_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009604 RID: 38404 RVA: 0x00284D34 File Offset: 0x00282F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67802, XrefRangeEnd = 67819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessButtonFurnitureElement_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__ProcessButtonFurnitureElement_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009605 RID: 38405 RVA: 0x00284D68 File Offset: 0x00282F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67819, XrefRangeEnd = 67834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessButtonFurnitureElement_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__ProcessButtonFurnitureElement_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009606 RID: 38406 RVA: 0x00284D9C File Offset: 0x00282F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67834, XrefRangeEnd = 67835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessButtonFurnitureElement_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeMethodInfoPtr__ProcessButtonFurnitureElement_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009607 RID: 38407 RVA: 0x000511EE File Offset: 0x0004F3EE
			public __c__DisplayClass76_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031D5 RID: 12757
			// (get) Token: 0x06009608 RID: 38408 RVA: 0x00284DD0 File Offset: 0x00282FD0
			// (set) Token: 0x06009609 RID: 38409 RVA: 0x000511F7 File Offset: 0x0004F3F7
			public unsafe DLC4_FlandreHomeDecorationEditorPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031D6 RID: 12758
			// (get) Token: 0x0600960A RID: 38410 RVA: 0x00284E00 File Offset: 0x00283000
			// (set) Token: 0x0600960B RID: 38411 RVA: 0x00051216 File Offset: 0x0004F416
			public unsafe Vector2Int thisPairPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr_thisPairPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr_thisPairPosition)) = value;
				}
			}

			// Token: 0x170031D7 RID: 12759
			// (get) Token: 0x0600960C RID: 38412 RVA: 0x00284E28 File Offset: 0x00283028
			// (set) Token: 0x0600960D RID: 38413 RVA: 0x00051231 File Offset: 0x0004F431
			public DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty furnitureProperty
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr_furnitureProperty);
					return new DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr_furnitureProperty), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170031D8 RID: 12760
			// (get) Token: 0x0600960E RID: 38414 RVA: 0x00284E58 File Offset: 0x00283058
			// (set) Token: 0x0600960F RID: 38415 RVA: 0x0005125F File Offset: 0x0004F45F
			public unsafe UIButtonSimple thisButton
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr_thisButton);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr_thisButton), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031D9 RID: 12761
			// (get) Token: 0x06009610 RID: 38416 RVA: 0x00284E88 File Offset: 0x00283088
			// (set) Token: 0x06009611 RID: 38417 RVA: 0x0005127E File Offset: 0x0004F47E
			public unsafe Action __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass76_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400614B RID: 24907
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400614C RID: 24908
			private static readonly IntPtr NativeFieldInfoPtr_thisPairPosition;

			// Token: 0x0400614D RID: 24909
			private static readonly IntPtr NativeFieldInfoPtr_furnitureProperty;

			// Token: 0x0400614E RID: 24910
			private static readonly IntPtr NativeFieldInfoPtr_thisButton;

			// Token: 0x0400614F RID: 24911
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x04006150 RID: 24912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006151 RID: 24913
			private static readonly IntPtr NativeMethodInfoPtr__ProcessButtonFurnitureElement_b__0_Internal_Void_0;

			// Token: 0x04006152 RID: 24914
			private static readonly IntPtr NativeMethodInfoPtr__ProcessButtonFurnitureElement_b__1_Internal_Void_0;

			// Token: 0x04006153 RID: 24915
			private static readonly IntPtr NativeMethodInfoPtr__ProcessButtonFurnitureElement_b__2_Internal_Void_0;

			// Token: 0x04006154 RID: 24916
			private static readonly IntPtr NativeMethodInfoPtr__ProcessButtonFurnitureElement_b__3_Internal_Void_0;
		}

		// Token: 0x02000684 RID: 1668
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationEditorPanel+<>c__DisplayClass82_0")]
		public sealed class __c__DisplayClass82_0 : Il2CppSystem.Object
		{
			// Token: 0x06009612 RID: 38418 RVA: 0x00284EB8 File Offset: 0x002830B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass82_0()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "<>c__DisplayClass82_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0>.NativeClassPtr);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0>.NativeClassPtr, "<>4__this");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0.NativeFieldInfoPtr_newEditorFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0>.NativeClassPtr, "newEditorFurniture");
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0>.NativeClassPtr, 100667803);
				DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0.NativeMethodInfoPtr__PutNewFurniture_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0>.NativeClassPtr, 100667804);
			}

			// Token: 0x06009613 RID: 38419 RVA: 0x00284F34 File Offset: 0x00283134
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass82_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009614 RID: 38420 RVA: 0x00284F70 File Offset: 0x00283170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67835, XrefRangeEnd = 67957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PutNewFurniture_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0.NativeMethodInfoPtr__PutNewFurniture_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009615 RID: 38421 RVA: 0x0005129D File Offset: 0x0004F49D
			public __c__DisplayClass82_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031DA RID: 12762
			// (get) Token: 0x06009616 RID: 38422 RVA: 0x00284FA4 File Offset: 0x002831A4
			// (set) Token: 0x06009617 RID: 38423 RVA: 0x000512A6 File Offset: 0x0004F4A6
			public unsafe DLC4_FlandreHomeDecorationEditorPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031DB RID: 12763
			// (get) Token: 0x06009618 RID: 38424 RVA: 0x00284FD4 File Offset: 0x002831D4
			// (set) Token: 0x06009619 RID: 38425 RVA: 0x000512C5 File Offset: 0x0004F4C5
			public DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty newEditorFurniture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0.NativeFieldInfoPtr_newEditorFurniture);
					return new DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel.__c__DisplayClass82_0.NativeFieldInfoPtr_newEditorFurniture), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006155 RID: 24917
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006156 RID: 24918
			private static readonly IntPtr NativeFieldInfoPtr_newEditorFurniture;

			// Token: 0x04006157 RID: 24919
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006158 RID: 24920
			private static readonly IntPtr NativeMethodInfoPtr__PutNewFurniture_b__0_Internal_Void_0;
		}

		// Token: 0x02000685 RID: 1669
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationEditorPanel+<WaitForFrameEndAndClosePanel>d__85")]
		public sealed class _WaitForFrameEndAndClosePanel_d__85 : Il2CppSystem.Object
		{
			// Token: 0x0600961A RID: 38426 RVA: 0x00285004 File Offset: 0x00283204
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForFrameEndAndClosePanel_d__85()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel>.NativeClassPtr, "<WaitForFrameEndAndClosePanel>d__85");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85>.NativeClassPtr);
				DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85>.NativeClassPtr, "<>1__state");
				DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85>.NativeClassPtr, "<>2__current");
				DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85>.NativeClassPtr, "onFinish");
				DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85>.NativeClassPtr, 100667805);
				DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85>.NativeClassPtr, 100667806);
				DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85>.NativeClassPtr, 100667807);
				DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85>.NativeClassPtr, 100667808);
				DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85>.NativeClassPtr, 100667809);
				DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85>.NativeClassPtr, 100667810);
			}

			// Token: 0x0600961B RID: 38427 RVA: 0x002850E4 File Offset: 0x002832E4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForFrameEndAndClosePanel_d__85(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600961C RID: 38428 RVA: 0x0028512C File Offset: 0x0028332C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600961D RID: 38429 RVA: 0x00285160 File Offset: 0x00283360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67957, XrefRangeEnd = 67958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170031DF RID: 12767
			// (get) Token: 0x0600961E RID: 38430 RVA: 0x0028519C File Offset: 0x0028339C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600961F RID: 38431 RVA: 0x002851DC File Offset: 0x002833DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67958, XrefRangeEnd = 67964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170031E0 RID: 12768
			// (get) Token: 0x06009620 RID: 38432 RVA: 0x00285210 File Offset: 0x00283410
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009621 RID: 38433 RVA: 0x000512F3 File Offset: 0x0004F4F3
			public _WaitForFrameEndAndClosePanel_d__85(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031DC RID: 12764
			// (get) Token: 0x06009622 RID: 38434 RVA: 0x00285250 File Offset: 0x00283450
			// (set) Token: 0x06009623 RID: 38435 RVA: 0x000512FC File Offset: 0x0004F4FC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170031DD RID: 12765
			// (get) Token: 0x06009624 RID: 38436 RVA: 0x00285278 File Offset: 0x00283478
			// (set) Token: 0x06009625 RID: 38437 RVA: 0x00051317 File Offset: 0x0004F517
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031DE RID: 12766
			// (get) Token: 0x06009626 RID: 38438 RVA: 0x002852A8 File Offset: 0x002834A8
			// (set) Token: 0x06009627 RID: 38439 RVA: 0x00051336 File Offset: 0x0004F536
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorPanel._WaitForFrameEndAndClosePanel_d__85.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006159 RID: 24921
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400615A RID: 24922
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400615B RID: 24923
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x0400615C RID: 24924
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400615D RID: 24925
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400615E RID: 24926
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400615F RID: 24927
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006160 RID: 24928
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006161 RID: 24929
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
