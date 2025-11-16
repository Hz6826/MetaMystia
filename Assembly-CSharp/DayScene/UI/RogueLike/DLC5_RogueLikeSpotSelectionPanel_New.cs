using System;
using Common.UI;
using Common.UI.GlobalMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using PrepNightScene.UI;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000125 RID: 293
	public class DLC5_RogueLikeSpotSelectionPanel_New : GuideMapPanel<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext, DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>
	{
		// Token: 0x06002198 RID: 8600 RVA: 0x0010DB2C File Offset: 0x0010BD2C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeSpotSelectionPanel_New()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeSpotSelectionPanel_New");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_GotoIzakayaBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_GotoIzakayaBtn");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_DataViewerBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_DataViewerBtn");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_Level1Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_Level1Toggle");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_Level2Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_Level2Toggle");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_Level3Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_Level3Toggle");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_GuideMapSpotExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_GuideMapSpotExtension");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_SelectedIzakayaDescriber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_SelectedIzakayaDescriber");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_MainPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_MainPanel");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_ExpandButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_ExpandButton");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_GotoShopButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_GotoShopButton");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_DetailPanel");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_PurchasePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_PurchasePanel");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_RemindPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_RemindPanel");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_GotoIzakayaButtonLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_GotoIzakayaButtonLayer");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_WholeCollectRateTitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_WholeCollectRateTitleText");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_MoveActionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_MoveActionText");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_ExtraMenuSubPanelForMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_ExtraMenuSubPanelForMap");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_MystiaIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_MystiaIcon");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_MystiaIconOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_MystiaIconOffset");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_EliteIntroductionPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_EliteIntroductionPanel");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_EliteTipPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_EliteTipPanel");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "instance");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_isNeighbour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "isNeighbour");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_doNotShowRemindMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "doNotShowRemindMessage");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_secondMenuIsOpend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "secondMenuIsOpend");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr__HasPurchasePanelInitialize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "<HasPurchasePanelInitialize>k__BackingField");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_SpotToExtensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_SpotToExtensions");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_CurrentSelectedIzakayaLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_CurrentSelectedIzakayaLevel");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_CurrentSelectedSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_CurrentSelectedSpot");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_CurrentNeighbours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_CurrentNeighbours");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_CurrentDlcAreaCollectRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "CurrentDlcAreaCollectRate");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_deletePanelWhenExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "deletePanelWhenExit");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_HasConfirmed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "m_HasConfirmed");
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_get_HasPurchasePanelInitialize_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669300);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_set_HasPurchasePanelInitialize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669301);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669302);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669303);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OnSecondarySwitchUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669304);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OpenDescriptionMenu_Private_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669305);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OnGuideMapPanelPreOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669306);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_UpdateNeighbourDistance_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669307);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_ClosePanelByExtraSub_Private_Void_CloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669308);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_TryClosePanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669309);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_WaitForClothesAndPartnerSetting_Private_UniTask_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669310);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OnGuideMapPanelEndOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669311);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_TryCheckElite_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669312);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OpenPurchasePanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669313);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_GetLevel_Private_UnlockedIzakayaInfo_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669314);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669315);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_GetSpotShouldShowPath_Protected_Virtual_Boolean_IGuideMapSpot_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669316);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OnGuideMapSpotSubmit_Protected_Virtual_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669317);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_IsGuideMapSpotCanBeSelected_Protected_Virtual_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669318);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669319);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_UpdateCurrentIzakaya_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669320);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_get_GetNeighbourSpots_Private_get_IEnumerable_1_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669321);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_TryChangeIzakayaLevel_Private_Boolean_byref_UnlockedIzakayaInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669322);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_TryChangeIzakayaLevel_Private_Boolean_byref_UnlockedIzakayaInfo_UnlockedIzakayaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669323);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_UpdateToggleStatus_Private_Void_UnlockedIzakayaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669324);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_IsFirstToSelectSpot_Protected_Virtual_Nullable_1_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669325);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_PostInitializeGuideMapSpot_Protected_Virtual_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669326);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669327);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669328);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669329);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_2_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669330);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669331);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669332);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669333);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669334);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669335);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_8_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669336);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_9_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669337);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_10_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669338);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__TryClosePanel_b__45_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669339);
			DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__get_GetNeighbourSpots_b__58_0_Private_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, 100669340);
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06002199 RID: 8601 RVA: 0x0010E124 File Offset: 0x0010C324
		// (set) Token: 0x0600219A RID: 8602 RVA: 0x0010E160 File Offset: 0x0010C360
		public unsafe bool HasPurchasePanelInitialize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_get_HasPurchasePanelInitialize_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_set_HasPurchasePanelInitialize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x0010E1A0 File Offset: 0x0010C3A0
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x0010E1E8 File Offset: 0x0010C3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82346, XrefRangeEnd = 82500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x0010E224 File Offset: 0x0010C424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82500, XrefRangeEnd = 82512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSecondarySwitchUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OnSecondarySwitchUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x0010E260 File Offset: 0x0010C460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82512, XrefRangeEnd = 82518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask OpenDescriptionMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OpenDescriptionMenu_Private_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x0010E298 File Offset: 0x0010C498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82518, XrefRangeEnd = 82524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapPanelPreOpen(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OnGuideMapPanelPreOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x0010E2EC File Offset: 0x0010C4EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82602, RefRangeEnd = 82603, XrefRangeStart = 82524, XrefRangeEnd = 82602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNeighbourDistance(string currentSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(currentSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_UpdateNeighbourDistance_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x0010E330 File Offset: 0x0010C530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82620, RefRangeEnd = 82621, XrefRangeStart = 82603, XrefRangeEnd = 82620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClosePanelByExtraSub(DLC5_RogueLikeExtraMenuSubPanel.CloseContext exitMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref exitMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_ClosePanelByExtraSub_Private_Void_CloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x0010E370 File Offset: 0x0010C570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82621, XrefRangeEnd = 82657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryClosePanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_TryClosePanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x0010E3A4 File Offset: 0x0010C5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82657, XrefRangeEnd = 82664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask WaitForClothesAndPartnerSetting(Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_WaitForClothesAndPartnerSetting_Private_UniTask_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x0010E3EC File Offset: 0x0010C5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82664, XrefRangeEnd = 82675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapPanelEndOpen(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OnGuideMapPanelEndOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x0010E440 File Offset: 0x0010C640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82698, RefRangeEnd = 82699, XrefRangeStart = 82675, XrefRangeEnd = 82698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryCheckElite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_TryCheckElite_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x0010E474 File Offset: 0x0010C674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82762, RefRangeEnd = 82764, XrefRangeStart = 82699, XrefRangeEnd = 82762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPurchasePanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OpenPurchasePanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x0010E4A8 File Offset: 0x0010C6A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82774, RefRangeEnd = 82775, XrefRangeStart = 82764, XrefRangeEnd = 82774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnlockedIzakayaInfo GetLevel(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_GetLevel_Private_UnlockedIzakayaInfo_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x0010E4F8 File Offset: 0x0010C6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82775, XrefRangeEnd = 82836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetSpotOpenStatus(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_Boolean_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x0010E550 File Offset: 0x0010C750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82836, XrefRangeEnd = 82839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetSpotShouldShowPath(IGuideMapSpot guideMapSpot1, IGuideMapSpot guideMapSpot2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot1);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_GetSpotShouldShowPath_Protected_Virtual_Boolean_IGuideMapSpot_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x0010E5BC File Offset: 0x0010C7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82839, XrefRangeEnd = 82860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapSpotSubmit(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OnGuideMapSpotSubmit_Protected_Virtual_Void_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0010E60C File Offset: 0x0010C80C
		[CallerCount(0)]
		public unsafe override bool IsGuideMapSpotCanBeSelected(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_IsGuideMapSpotCanBeSelected_Protected_Virtual_Boolean_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0010E664 File Offset: 0x0010C864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82860, XrefRangeEnd = 82929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapSpotSelected(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_Void_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x0010E6B4 File Offset: 0x0010C8B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 82969, RefRangeEnd = 82975, XrefRangeStart = 82929, XrefRangeEnd = 82969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentIzakaya()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_UpdateCurrentIzakaya_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x0010E6E8 File Offset: 0x0010C8E8
		public unsafe IEnumerable<IGuideMapSpot> GetNeighbourSpots
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82975, XrefRangeEnd = 82988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_get_GetNeighbourSpots_Private_get_IEnumerable_1_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IGuideMapSpot>>(intPtr3) : null;
			}
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x0010E728 File Offset: 0x0010C928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82988, XrefRangeEnd = 82989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryChangeIzakayaLevel(ref UnlockedIzakayaInfo izakayaLevel, bool add)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &izakayaLevel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref add;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_TryChangeIzakayaLevel_Private_Boolean_byref_UnlockedIzakayaInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x0010E780 File Offset: 0x0010C980
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 82995, RefRangeEnd = 82999, XrefRangeStart = 82989, XrefRangeEnd = 82995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryChangeIzakayaLevel(ref UnlockedIzakayaInfo izakayaLevel, UnlockedIzakayaInfo targetLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &izakayaLevel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_TryChangeIzakayaLevel_Private_Boolean_byref_UnlockedIzakayaInfo_UnlockedIzakayaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x0010E7D8 File Offset: 0x0010C9D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83003, RefRangeEnd = 83005, XrefRangeStart = 82999, XrefRangeEnd = 83003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateToggleStatus(UnlockedIzakayaInfo targetLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetLevel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_UpdateToggleStatus_Private_Void_UnlockedIzakayaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x0010E818 File Offset: 0x0010CA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83005, XrefRangeEnd = 83013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<bool> IsFirstToSelectSpot(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_IsFirstToSelectSpot_Protected_Virtual_Nullable_1_Boolean_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Nullable<bool>(pointer);
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x0010E86C File Offset: 0x0010CA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83013, XrefRangeEnd = 83030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostInitializeGuideMapSpot(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_PostInitializeGuideMapSpot_Protected_Virtual_Void_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x0010E8BC File Offset: 0x0010CABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83030, XrefRangeEnd = 83064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x0010E8F8 File Offset: 0x0010CAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83064, XrefRangeEnd = 83089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeSpotSelectionPanel_New() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x0010E934 File Offset: 0x0010CB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83089, XrefRangeEnd = 83102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__39_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x0010E968 File Offset: 0x0010CB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83102, XrefRangeEnd = 83104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__39_2(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_2_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x0010E9B0 File Offset: 0x0010CBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83104, XrefRangeEnd = 83106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__39_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x0010E9E4 File Offset: 0x0010CBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83106, XrefRangeEnd = 83109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__39_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x0010EA18 File Offset: 0x0010CC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83109, XrefRangeEnd = 83112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__39_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x0010EA4C File Offset: 0x0010CC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83112, XrefRangeEnd = 83115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__39_6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x0010EA80 File Offset: 0x0010CC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83115, XrefRangeEnd = 83123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__39_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0010EAB4 File Offset: 0x0010CCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83123, XrefRangeEnd = 83128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__39_8(InputAction.CallbackContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_8_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0010EAFC File Offset: 0x0010CCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83128, XrefRangeEnd = 83130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__39_9(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_9_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x0010EB44 File Offset: 0x0010CD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83130, XrefRangeEnd = 83137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__39_10(InputAction.CallbackContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_10_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x0010EB8C File Offset: 0x0010CD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83137, XrefRangeEnd = 83144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _TryClosePanel_b__45_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__TryClosePanel_b__45_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x0010EBC0 File Offset: 0x0010CDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83144, XrefRangeEnd = 83156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_GetNeighbourSpots_b__58_0(IGuideMapSpot x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.NativeMethodInfoPtr__get_GetNeighbourSpots_b__58_0_Private_Boolean_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x00014791 File Offset: 0x00012991
		public DLC5_RogueLikeSpotSelectionPanel_New(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x0010EC10 File Offset: 0x0010CE10
		// (set) Token: 0x060021C4 RID: 8644 RVA: 0x0001479A File Offset: 0x0001299A
		public unsafe UIButtonHold m_GotoIzakayaBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_GotoIzakayaBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_GotoIzakayaBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x0010EC40 File Offset: 0x0010CE40
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x000147B9 File Offset: 0x000129B9
		public unsafe UIButtonSimple m_DataViewerBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_DataViewerBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_DataViewerBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x0010EC70 File Offset: 0x0010CE70
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x000147D8 File Offset: 0x000129D8
		public unsafe UIButtonToggle m_Level1Toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_Level1Toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_Level1Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x0010ECA0 File Offset: 0x0010CEA0
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x000147F7 File Offset: 0x000129F7
		public unsafe UIButtonToggle m_Level2Toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_Level2Toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_Level2Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x0010ECD0 File Offset: 0x0010CED0
		// (set) Token: 0x060021CC RID: 8652 RVA: 0x00014816 File Offset: 0x00012A16
		public unsafe UIButtonToggle m_Level3Toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_Level3Toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_Level3Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x0010ED00 File Offset: 0x0010CF00
		// (set) Token: 0x060021CE RID: 8654 RVA: 0x00014835 File Offset: 0x00012A35
		public unsafe GuideMapSpotIzakayaExtension m_GuideMapSpotExtension
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_GuideMapSpotExtension);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuideMapSpotIzakayaExtension>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_GuideMapSpotExtension), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x0010ED30 File Offset: 0x0010CF30
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x00014854 File Offset: 0x00012A54
		public unsafe DLC5_RogueLikeMapDescriber m_SelectedIzakayaDescriber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_SelectedIzakayaDescriber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeMapDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_SelectedIzakayaDescriber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x0010ED60 File Offset: 0x0010CF60
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x00014873 File Offset: 0x00012A73
		public unsafe CanvasGroup m_MainPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_MainPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_MainPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x0010ED90 File Offset: 0x0010CF90
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x00014892 File Offset: 0x00012A92
		public unsafe UIButtonSimple m_ExpandButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_ExpandButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_ExpandButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x0010EDC0 File Offset: 0x0010CFC0
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x000148B1 File Offset: 0x00012AB1
		public unsafe UIButtonSimple m_GotoShopButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_GotoShopButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_GotoShopButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x0010EDF0 File Offset: 0x0010CFF0
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x000148D0 File Offset: 0x00012AD0
		public unsafe RogueLikeDetailPanel m_DetailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_DetailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeDetailPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x0010EE20 File Offset: 0x0010D020
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x000148EF File Offset: 0x00012AEF
		public unsafe DLC5_RogueLikePurchasePanel m_PurchasePanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_PurchasePanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_PurchasePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x0010EE50 File Offset: 0x0010D050
		// (set) Token: 0x060021DC RID: 8668 RVA: 0x0001490E File Offset: 0x00012B0E
		public unsafe RemindSubPanel m_RemindPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_RemindPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemindSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_RemindPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x0010EE80 File Offset: 0x0010D080
		// (set) Token: 0x060021DE RID: 8670 RVA: 0x0001492D File Offset: 0x00012B2D
		public unsafe CanvasGroup m_GotoIzakayaButtonLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_GotoIzakayaButtonLayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_GotoIzakayaButtonLayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x060021DF RID: 8671 RVA: 0x0010EEB0 File Offset: 0x0010D0B0
		// (set) Token: 0x060021E0 RID: 8672 RVA: 0x0001494C File Offset: 0x00012B4C
		public unsafe TextMeshProUGUI m_WholeCollectRateTitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_WholeCollectRateTitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_WholeCollectRateTitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x060021E1 RID: 8673 RVA: 0x0010EEE0 File Offset: 0x0010D0E0
		// (set) Token: 0x060021E2 RID: 8674 RVA: 0x0001496B File Offset: 0x00012B6B
		public unsafe TextMeshProUGUI m_MoveActionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_MoveActionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_MoveActionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x0010EF10 File Offset: 0x0010D110
		// (set) Token: 0x060021E4 RID: 8676 RVA: 0x0001498A File Offset: 0x00012B8A
		public unsafe DLC5_RogueLikeExtraMenuSubPanel m_ExtraMenuSubPanelForMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_ExtraMenuSubPanelForMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeExtraMenuSubPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_ExtraMenuSubPanelForMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x060021E5 RID: 8677 RVA: 0x0010EF40 File Offset: 0x0010D140
		// (set) Token: 0x060021E6 RID: 8678 RVA: 0x000149A9 File Offset: 0x00012BA9
		public unsafe Image m_MystiaIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_MystiaIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_MystiaIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x060021E7 RID: 8679 RVA: 0x0010EF70 File Offset: 0x0010D170
		// (set) Token: 0x060021E8 RID: 8680 RVA: 0x000149C8 File Offset: 0x00012BC8
		public unsafe Vector2 m_MystiaIconOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_MystiaIconOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_MystiaIconOffset)) = value;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060021E9 RID: 8681 RVA: 0x0010EF98 File Offset: 0x0010D198
		// (set) Token: 0x060021EA RID: 8682 RVA: 0x000149E3 File Offset: 0x00012BE3
		public unsafe DLC5_RogueLikeEliteIntroductionPanel m_EliteIntroductionPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_EliteIntroductionPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeEliteIntroductionPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_EliteIntroductionPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060021EB RID: 8683 RVA: 0x0010EFC8 File Offset: 0x0010D1C8
		// (set) Token: 0x060021EC RID: 8684 RVA: 0x00014A02 File Offset: 0x00012C02
		public unsafe DLC5_RogueLikeSpotSelectionPanelEliteTipPanel m_EliteTipPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_EliteTipPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanelEliteTipPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_EliteTipPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x0010EFF8 File Offset: 0x0010D1F8
		// (set) Token: 0x060021EE RID: 8686 RVA: 0x00014A21 File Offset: 0x00012C21
		public unsafe DLC5_RogueLikePurchasePanel instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_instance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikePurchasePanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060021EF RID: 8687 RVA: 0x0010F028 File Offset: 0x0010D228
		// (set) Token: 0x060021F0 RID: 8688 RVA: 0x00014A40 File Offset: 0x00012C40
		public unsafe bool isNeighbour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_isNeighbour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_isNeighbour)) = value;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x0010F050 File Offset: 0x0010D250
		// (set) Token: 0x060021F2 RID: 8690 RVA: 0x00014A5B File Offset: 0x00012C5B
		public unsafe bool doNotShowRemindMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_doNotShowRemindMessage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_doNotShowRemindMessage)) = value;
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x0010F078 File Offset: 0x0010D278
		// (set) Token: 0x060021F4 RID: 8692 RVA: 0x00014A76 File Offset: 0x00012C76
		public unsafe bool secondMenuIsOpend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_secondMenuIsOpend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_secondMenuIsOpend)) = value;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x0010F0A0 File Offset: 0x0010D2A0
		// (set) Token: 0x060021F6 RID: 8694 RVA: 0x00014A91 File Offset: 0x00012C91
		public unsafe bool _HasPurchasePanelInitialize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr__HasPurchasePanelInitialize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr__HasPurchasePanelInitialize_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x0010F0C8 File Offset: 0x0010D2C8
		// (set) Token: 0x060021F8 RID: 8696 RVA: 0x00014AAC File Offset: 0x00012CAC
		public unsafe Dictionary<IGuideMapSpot, DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData> m_SpotToExtensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_SpotToExtensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IGuideMapSpot, DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_SpotToExtensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x0010F0F8 File Offset: 0x0010D2F8
		// (set) Token: 0x060021FA RID: 8698 RVA: 0x00014ACB File Offset: 0x00012CCB
		public unsafe UnlockedIzakayaInfo m_CurrentSelectedIzakayaLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_CurrentSelectedIzakayaLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_CurrentSelectedIzakayaLevel)) = value;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x0010F120 File Offset: 0x0010D320
		// (set) Token: 0x060021FC RID: 8700 RVA: 0x00014AE6 File Offset: 0x00012CE6
		public unsafe IGuideMapSpot m_CurrentSelectedSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_CurrentSelectedSpot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGuideMapSpot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_CurrentSelectedSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x0010F150 File Offset: 0x0010D350
		// (set) Token: 0x060021FE RID: 8702 RVA: 0x00014B05 File Offset: 0x00012D05
		public unsafe HashSet<IGuideMapSpot> m_CurrentNeighbours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_CurrentNeighbours);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IGuideMapSpot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_CurrentNeighbours), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x0010F180 File Offset: 0x0010D380
		// (set) Token: 0x06002200 RID: 8704 RVA: 0x00014B24 File Offset: 0x00012D24
		public RogueLikeRunTimeData.DLCAreaCollectRate CurrentDlcAreaCollectRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_CurrentDlcAreaCollectRate);
				return new RogueLikeRunTimeData.DLCAreaCollectRate(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RogueLikeRunTimeData.DLCAreaCollectRate>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_CurrentDlcAreaCollectRate), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RogueLikeRunTimeData.DLCAreaCollectRate>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x0010F1B0 File Offset: 0x0010D3B0
		// (set) Token: 0x06002202 RID: 8706 RVA: 0x00014B52 File Offset: 0x00012D52
		public unsafe HashSet<UIPanelBaseImpl> deletePanelWhenExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_deletePanelWhenExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<UIPanelBaseImpl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_deletePanelWhenExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x0010F1E0 File Offset: 0x0010D3E0
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x00014B71 File Offset: 0x00012D71
		public unsafe bool m_HasConfirmed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_HasConfirmed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.NativeFieldInfoPtr_m_HasConfirmed)) = value;
			}
		}

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoIzakayaBtn;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeFieldInfoPtr_m_DataViewerBtn;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeFieldInfoPtr_m_Level1Toggle;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeFieldInfoPtr_m_Level2Toggle;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeFieldInfoPtr_m_Level3Toggle;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeFieldInfoPtr_m_GuideMapSpotExtension;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedIzakayaDescriber;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeFieldInfoPtr_m_MainPanel;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeFieldInfoPtr_m_ExpandButton;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoShopButton;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeFieldInfoPtr_m_DetailPanel;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeFieldInfoPtr_m_PurchasePanel;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeFieldInfoPtr_m_RemindPanel;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeFieldInfoPtr_m_GotoIzakayaButtonLayer;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeCollectRateTitleText;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveActionText;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeFieldInfoPtr_m_ExtraMenuSubPanelForMap;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeFieldInfoPtr_m_MystiaIcon;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeFieldInfoPtr_m_MystiaIconOffset;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeFieldInfoPtr_m_EliteIntroductionPanel;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeFieldInfoPtr_m_EliteTipPanel;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeFieldInfoPtr_isNeighbour;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeFieldInfoPtr_doNotShowRemindMessage;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeFieldInfoPtr_secondMenuIsOpend;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeFieldInfoPtr__HasPurchasePanelInitialize_k__BackingField;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeFieldInfoPtr_m_SpotToExtensions;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSelectedIzakayaLevel;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSelectedSpot;

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentNeighbours;

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeFieldInfoPtr_CurrentDlcAreaCollectRate;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeFieldInfoPtr_deletePanelWhenExit;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeFieldInfoPtr_m_HasConfirmed;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPurchasePanelInitialize_Private_get_Boolean_0;

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeMethodInfoPtr_set_HasPurchasePanelInitialize_Public_set_Void_Boolean_0;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400166F RID: 5743
		private static readonly IntPtr NativeMethodInfoPtr_OnSecondarySwitchUpdate_Protected_Virtual_Void_0;

		// Token: 0x04001670 RID: 5744
		private static readonly IntPtr NativeMethodInfoPtr_OpenDescriptionMenu_Private_UniTask_0;

		// Token: 0x04001671 RID: 5745
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapPanelPreOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNeighbourDistance_Private_Void_String_0;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeMethodInfoPtr_ClosePanelByExtraSub_Private_Void_CloseContext_0;

		// Token: 0x04001674 RID: 5748
		private static readonly IntPtr NativeMethodInfoPtr_TryClosePanel_Private_Void_0;

		// Token: 0x04001675 RID: 5749
		private static readonly IntPtr NativeMethodInfoPtr_WaitForClothesAndPartnerSetting_Private_UniTask_Action_0;

		// Token: 0x04001676 RID: 5750
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapPanelEndOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x04001677 RID: 5751
		private static readonly IntPtr NativeMethodInfoPtr_TryCheckElite_Private_Void_0;

		// Token: 0x04001678 RID: 5752
		private static readonly IntPtr NativeMethodInfoPtr_OpenPurchasePanel_Private_Void_0;

		// Token: 0x04001679 RID: 5753
		private static readonly IntPtr NativeMethodInfoPtr_GetLevel_Private_UnlockedIzakayaInfo_IGuideMapSpot_0;

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_Boolean_IGuideMapSpot_0;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotShouldShowPath_Protected_Virtual_Boolean_IGuideMapSpot_IGuideMapSpot_0;

		// Token: 0x0400167C RID: 5756
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapSpotSubmit_Protected_Virtual_Void_IGuideMapSpot_0;

		// Token: 0x0400167D RID: 5757
		private static readonly IntPtr NativeMethodInfoPtr_IsGuideMapSpotCanBeSelected_Protected_Virtual_Boolean_IGuideMapSpot_0;

		// Token: 0x0400167E RID: 5758
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_Void_IGuideMapSpot_0;

		// Token: 0x0400167F RID: 5759
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentIzakaya_Private_Void_0;

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeMethodInfoPtr_get_GetNeighbourSpots_Private_get_IEnumerable_1_IGuideMapSpot_0;

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeMethodInfoPtr_TryChangeIzakayaLevel_Private_Boolean_byref_UnlockedIzakayaInfo_Boolean_0;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeMethodInfoPtr_TryChangeIzakayaLevel_Private_Boolean_byref_UnlockedIzakayaInfo_UnlockedIzakayaInfo_0;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeMethodInfoPtr_UpdateToggleStatus_Private_Void_UnlockedIzakayaInfo_0;

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeMethodInfoPtr_IsFirstToSelectSpot_Protected_Virtual_Nullable_1_Boolean_IGuideMapSpot_0;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeMethodInfoPtr_PostInitializeGuideMapSpot_Protected_Virtual_Void_IGuideMapSpot_0;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__39_0_Private_Void_0;

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__39_2_Private_Void_CallbackContext_0;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__39_3_Private_Void_0;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__39_4_Private_Void_0;

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__39_5_Private_Void_0;

		// Token: 0x0400168D RID: 5773
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__39_6_Private_Void_0;

		// Token: 0x0400168E RID: 5774
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__39_7_Private_Void_0;

		// Token: 0x0400168F RID: 5775
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__39_8_Private_Void_CallbackContext_0;

		// Token: 0x04001690 RID: 5776
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__39_9_Private_Void_CallbackContext_0;

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__39_10_Private_Void_CallbackContext_0;

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeMethodInfoPtr__TryClosePanel_b__45_0_Private_Void_0;

		// Token: 0x04001693 RID: 5779
		private static readonly IntPtr NativeMethodInfoPtr__get_GetNeighbourSpots_b__58_0_Private_Boolean_IGuideMapSpot_0;

		// Token: 0x0200073C RID: 1852
		public sealed class OpenContext : ValueType
		{
			// Token: 0x06009E80 RID: 40576 RVA: 0x0029F1A4 File Offset: 0x0029D3A4
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_UnlockedIzakayaInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext>.NativeClassPtr, "UnlockedIzakayaInfos");
				DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_CurrentSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext>.NativeClassPtr, "CurrentSpot");
				DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_UnlockAllLevel2Spot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext>.NativeClassPtr, "UnlockAllLevel2Spot");
				DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_UnlockAllLevel3Spot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext>.NativeClassPtr, "UnlockAllLevel3Spot");
				DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_GetIzakayaHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext>.NativeClassPtr, "GetIzakayaHandler");
				DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext>.NativeClassPtr, "RogueLikeRunTimeData");
				DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_IsStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext>.NativeClassPtr, "IsStart");
				DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyDictionary_2_String_UnlockedIzakayaInfo_String_Boolean_Boolean_Func_3_String_UnlockedIzakayaInfo_ValueTuple_2_MapSetup_Izakaya_RogueLikeRunTimeData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext>.NativeClassPtr, 100669341);
			}

			// Token: 0x06009E81 RID: 40577 RVA: 0x0029F270 File Offset: 0x0029D470
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82108, RefRangeEnd = 82109, XrefRangeStart = 82104, XrefRangeEnd = 82108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(IReadOnlyDictionary<string, UnlockedIzakayaInfo> unlockedIzakayaInfos, string currentSpot, bool unlockAllLevel2Spot, bool unlockAllLevel3Spot, Func<string, UnlockedIzakayaInfo, ValueTuple<DLC5_RogueLikeDataProfile.MapSetup, Izakaya>> getIzakayaHandler, RogueLikeRunTimeData rogueLikeRunTimeData, bool isStart) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unlockedIzakayaInfos);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currentSpot);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlockAllLevel2Spot;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlockAllLevel3Spot;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getIzakayaHandler);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStart;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyDictionary_2_String_UnlockedIzakayaInfo_String_Boolean_Boolean_Func_3_String_UnlockedIzakayaInfo_ValueTuple_2_MapSetup_Izakaya_RogueLikeRunTimeData_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E82 RID: 40578 RVA: 0x000558C3 File Offset: 0x00053AC3
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009E83 RID: 40579 RVA: 0x000558CC File Offset: 0x00053ACC
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x1700345E RID: 13406
			// (get) Token: 0x06009E84 RID: 40580 RVA: 0x0029F324 File Offset: 0x0029D524
			// (set) Token: 0x06009E85 RID: 40581 RVA: 0x000558DE File Offset: 0x00053ADE
			public unsafe IReadOnlyDictionary<string, UnlockedIzakayaInfo> UnlockedIzakayaInfos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_UnlockedIzakayaInfos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, UnlockedIzakayaInfo>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_UnlockedIzakayaInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700345F RID: 13407
			// (get) Token: 0x06009E86 RID: 40582 RVA: 0x0029F354 File Offset: 0x0029D554
			// (set) Token: 0x06009E87 RID: 40583 RVA: 0x000558FD File Offset: 0x00053AFD
			public unsafe string CurrentSpot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_CurrentSpot);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_CurrentSpot), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003460 RID: 13408
			// (get) Token: 0x06009E88 RID: 40584 RVA: 0x0029F37C File Offset: 0x0029D57C
			// (set) Token: 0x06009E89 RID: 40585 RVA: 0x0005591C File Offset: 0x00053B1C
			public unsafe bool UnlockAllLevel2Spot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_UnlockAllLevel2Spot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_UnlockAllLevel2Spot)) = value;
				}
			}

			// Token: 0x17003461 RID: 13409
			// (get) Token: 0x06009E8A RID: 40586 RVA: 0x0029F3A4 File Offset: 0x0029D5A4
			// (set) Token: 0x06009E8B RID: 40587 RVA: 0x00055937 File Offset: 0x00053B37
			public unsafe bool UnlockAllLevel3Spot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_UnlockAllLevel3Spot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_UnlockAllLevel3Spot)) = value;
				}
			}

			// Token: 0x17003462 RID: 13410
			// (get) Token: 0x06009E8C RID: 40588 RVA: 0x0029F3CC File Offset: 0x0029D5CC
			// (set) Token: 0x06009E8D RID: 40589 RVA: 0x00055952 File Offset: 0x00053B52
			public unsafe Func<string, UnlockedIzakayaInfo, ValueTuple<DLC5_RogueLikeDataProfile.MapSetup, Izakaya>> GetIzakayaHandler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_GetIzakayaHandler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, UnlockedIzakayaInfo, ValueTuple<DLC5_RogueLikeDataProfile.MapSetup, Izakaya>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_GetIzakayaHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003463 RID: 13411
			// (get) Token: 0x06009E8E RID: 40590 RVA: 0x0029F3FC File Offset: 0x0029D5FC
			// (set) Token: 0x06009E8F RID: 40591 RVA: 0x00055971 File Offset: 0x00053B71
			public unsafe RogueLikeRunTimeData RogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003464 RID: 13412
			// (get) Token: 0x06009E90 RID: 40592 RVA: 0x0029F42C File Offset: 0x0029D62C
			// (set) Token: 0x06009E91 RID: 40593 RVA: 0x00055990 File Offset: 0x00053B90
			public unsafe bool IsStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_IsStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext.NativeFieldInfoPtr_IsStart)) = value;
				}
			}

			// Token: 0x040066DF RID: 26335
			private static readonly IntPtr NativeFieldInfoPtr_UnlockedIzakayaInfos;

			// Token: 0x040066E0 RID: 26336
			private static readonly IntPtr NativeFieldInfoPtr_CurrentSpot;

			// Token: 0x040066E1 RID: 26337
			private static readonly IntPtr NativeFieldInfoPtr_UnlockAllLevel2Spot;

			// Token: 0x040066E2 RID: 26338
			private static readonly IntPtr NativeFieldInfoPtr_UnlockAllLevel3Spot;

			// Token: 0x040066E3 RID: 26339
			private static readonly IntPtr NativeFieldInfoPtr_GetIzakayaHandler;

			// Token: 0x040066E4 RID: 26340
			private static readonly IntPtr NativeFieldInfoPtr_RogueLikeRunTimeData;

			// Token: 0x040066E5 RID: 26341
			private static readonly IntPtr NativeFieldInfoPtr_IsStart;

			// Token: 0x040066E6 RID: 26342
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyDictionary_2_String_UnlockedIzakayaInfo_String_Boolean_Boolean_Func_3_String_UnlockedIzakayaInfo_ValueTuple_2_MapSetup_Izakaya_RogueLikeRunTimeData_Boolean_0;
		}

		// Token: 0x0200073D RID: 1853
		public sealed class RogueMapCloseContext : ValueType
		{
			// Token: 0x06009E92 RID: 40594 RVA: 0x0029F454 File Offset: 0x0029D654
			// Note: this type is marked as 'beforefieldinit'.
			static RogueMapCloseContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "RogueMapCloseContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.NativeFieldInfoPtr_PanelExitMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.NativeClassPtr, "PanelExitMode");
				DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.NativeFieldInfoPtr_SpotName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.NativeClassPtr, "SpotName");
				DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.NativeFieldInfoPtr_SpotLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.NativeClassPtr, "SpotLevel");
				DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.NativeMethodInfoPtr__ctor_Public_Void_ExitMode_String_UnlockedIzakayaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.NativeClassPtr, 100669342);
			}

			// Token: 0x06009E93 RID: 40595 RVA: 0x0029F4D0 File Offset: 0x0029D6D0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82110, RefRangeEnd = 82111, XrefRangeStart = 82109, XrefRangeEnd = 82110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RogueMapCloseContext(DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.ExitMode panelExitMode, string spotName, UnlockedIzakayaInfo spotLevel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref panelExitMode;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spotName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spotLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.NativeMethodInfoPtr__ctor_Public_Void_ExitMode_String_UnlockedIzakayaInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E94 RID: 40596 RVA: 0x000559AB File Offset: 0x00053BAB
			public RogueMapCloseContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009E95 RID: 40597 RVA: 0x000559B4 File Offset: 0x00053BB4
			public RogueMapCloseContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>.NativeClassPtr))
			{
			}

			// Token: 0x17003465 RID: 13413
			// (get) Token: 0x06009E96 RID: 40598 RVA: 0x0029F53C File Offset: 0x0029D73C
			// (set) Token: 0x06009E97 RID: 40599 RVA: 0x000559C6 File Offset: 0x00053BC6
			public unsafe DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.ExitMode PanelExitMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.NativeFieldInfoPtr_PanelExitMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.NativeFieldInfoPtr_PanelExitMode)) = value;
				}
			}

			// Token: 0x17003466 RID: 13414
			// (get) Token: 0x06009E98 RID: 40600 RVA: 0x0029F564 File Offset: 0x0029D764
			// (set) Token: 0x06009E99 RID: 40601 RVA: 0x000559E1 File Offset: 0x00053BE1
			public unsafe string SpotName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.NativeFieldInfoPtr_SpotName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.NativeFieldInfoPtr_SpotName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003467 RID: 13415
			// (get) Token: 0x06009E9A RID: 40602 RVA: 0x0029F58C File Offset: 0x0029D78C
			// (set) Token: 0x06009E9B RID: 40603 RVA: 0x00055A00 File Offset: 0x00053C00
			public unsafe UnlockedIzakayaInfo SpotLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.NativeFieldInfoPtr_SpotLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.NativeFieldInfoPtr_SpotLevel)) = value;
				}
			}

			// Token: 0x040066E7 RID: 26343
			private static readonly IntPtr NativeFieldInfoPtr_PanelExitMode;

			// Token: 0x040066E8 RID: 26344
			private static readonly IntPtr NativeFieldInfoPtr_SpotName;

			// Token: 0x040066E9 RID: 26345
			private static readonly IntPtr NativeFieldInfoPtr_SpotLevel;

			// Token: 0x040066EA RID: 26346
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ExitMode_String_UnlockedIzakayaInfo_0;

			// Token: 0x02000FD9 RID: 4057
			public enum ExitMode
			{
				// Token: 0x0400B01C RID: 45084
				GotoWork,
				// Token: 0x0400B01D RID: 45085
				ExitRogue,
				// Token: 0x0400B01E RID: 45086
				BackToMenu
			}
		}

		// Token: 0x0200073E RID: 1854
		public class GuideMapSpotRuntimeData : Il2CppSystem.Object
		{
			// Token: 0x06009E9C RID: 40604 RVA: 0x0029F5B4 File Offset: 0x0029D7B4
			// Note: this type is marked as 'beforefieldinit'.
			static GuideMapSpotRuntimeData()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "GuideMapSpotRuntimeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Extension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, "Extension");
				DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr__IzakayaLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, "<IzakayaLevel>k__BackingField");
				DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level1IzakayaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, "Level1IzakayaId");
				DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level2IzakayaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, "Level2IzakayaId");
				DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level3IzakayaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, "Level3IzakayaId");
				DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeMethodInfoPtr_get_IzakayaLevel_Public_get_UnlockedIzakayaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, 100669343);
				DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeMethodInfoPtr_set_IzakayaLevel_Public_set_Void_UnlockedIzakayaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, 100669344);
				DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeMethodInfoPtr__ctor_Public_Void_GuideMapSpotIzakayaExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr, 100669345);
			}

			// Token: 0x1700346D RID: 13421
			// (get) Token: 0x06009E9D RID: 40605 RVA: 0x0029F680 File Offset: 0x0029D880
			// (set) Token: 0x06009E9E RID: 40606 RVA: 0x0029F6BC File Offset: 0x0029D8BC
			public unsafe UnlockedIzakayaInfo IzakayaLevel
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeMethodInfoPtr_get_IzakayaLevel_Public_get_UnlockedIzakayaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 82111, RefRangeEnd = 82113, XrefRangeStart = 82111, XrefRangeEnd = 82111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeMethodInfoPtr_set_IzakayaLevel_Public_set_Void_UnlockedIzakayaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06009E9F RID: 40607 RVA: 0x0029F6FC File Offset: 0x0029D8FC
			[CallerCount(109)]
			[CachedScanResults(RefRangeStart = 60056, RefRangeEnd = 60165, XrefRangeStart = 60056, XrefRangeEnd = 60165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuideMapSpotRuntimeData(GuideMapSpotIzakayaExtension extension) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeMethodInfoPtr__ctor_Public_Void_GuideMapSpotIzakayaExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EA0 RID: 40608 RVA: 0x00055A1B File Offset: 0x00053C1B
			public GuideMapSpotRuntimeData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003468 RID: 13416
			// (get) Token: 0x06009EA1 RID: 40609 RVA: 0x0029F748 File Offset: 0x0029D948
			// (set) Token: 0x06009EA2 RID: 40610 RVA: 0x00055A24 File Offset: 0x00053C24
			public unsafe GuideMapSpotIzakayaExtension Extension
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Extension);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuideMapSpotIzakayaExtension>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Extension), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003469 RID: 13417
			// (get) Token: 0x06009EA3 RID: 40611 RVA: 0x0029F778 File Offset: 0x0029D978
			// (set) Token: 0x06009EA4 RID: 40612 RVA: 0x00055A43 File Offset: 0x00053C43
			public unsafe UnlockedIzakayaInfo _IzakayaLevel_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr__IzakayaLevel_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr__IzakayaLevel_k__BackingField)) = value;
				}
			}

			// Token: 0x1700346A RID: 13418
			// (get) Token: 0x06009EA5 RID: 40613 RVA: 0x0029F7A0 File Offset: 0x0029D9A0
			// (set) Token: 0x06009EA6 RID: 40614 RVA: 0x00055A5E File Offset: 0x00053C5E
			public Nullable<int> Level1IzakayaId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level1IzakayaId);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level1IzakayaId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700346B RID: 13419
			// (get) Token: 0x06009EA7 RID: 40615 RVA: 0x0029F7D0 File Offset: 0x0029D9D0
			// (set) Token: 0x06009EA8 RID: 40616 RVA: 0x00055A8C File Offset: 0x00053C8C
			public Nullable<int> Level2IzakayaId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level2IzakayaId);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level2IzakayaId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700346C RID: 13420
			// (get) Token: 0x06009EA9 RID: 40617 RVA: 0x0029F800 File Offset: 0x0029DA00
			// (set) Token: 0x06009EAA RID: 40618 RVA: 0x00055ABA File Offset: 0x00053CBA
			public Nullable<int> Level3IzakayaId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level3IzakayaId);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData.NativeFieldInfoPtr_Level3IzakayaId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040066EB RID: 26347
			private static readonly IntPtr NativeFieldInfoPtr_Extension;

			// Token: 0x040066EC RID: 26348
			private static readonly IntPtr NativeFieldInfoPtr__IzakayaLevel_k__BackingField;

			// Token: 0x040066ED RID: 26349
			private static readonly IntPtr NativeFieldInfoPtr_Level1IzakayaId;

			// Token: 0x040066EE RID: 26350
			private static readonly IntPtr NativeFieldInfoPtr_Level2IzakayaId;

			// Token: 0x040066EF RID: 26351
			private static readonly IntPtr NativeFieldInfoPtr_Level3IzakayaId;

			// Token: 0x040066F0 RID: 26352
			private static readonly IntPtr NativeMethodInfoPtr_get_IzakayaLevel_Public_get_UnlockedIzakayaInfo_0;

			// Token: 0x040066F1 RID: 26353
			private static readonly IntPtr NativeMethodInfoPtr_set_IzakayaLevel_Public_set_Void_UnlockedIzakayaInfo_0;

			// Token: 0x040066F2 RID: 26354
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuideMapSpotIzakayaExtension_0;
		}

		// Token: 0x0200073F RID: 1855
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel_New+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x06009EAB RID: 40619 RVA: 0x0029F830 File Offset: 0x0029DA30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0.NativeFieldInfoPtr_guideMapSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0>.NativeClassPtr, "guideMapSpot");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0>.NativeClassPtr, 100669346);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0.NativeMethodInfoPtr__OnGuideMapInitialize_b__11_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0>.NativeClassPtr, 100669347);
			}

			// Token: 0x06009EAC RID: 40620 RVA: 0x0029F8AC File Offset: 0x0029DAAC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EAD RID: 40621 RVA: 0x0029F8E8 File Offset: 0x0029DAE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82113, XrefRangeEnd = 82136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnGuideMapInitialize_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0.NativeMethodInfoPtr__OnGuideMapInitialize_b__11_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EAE RID: 40622 RVA: 0x00055AE8 File Offset: 0x00053CE8
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700346E RID: 13422
			// (get) Token: 0x06009EAF RID: 40623 RVA: 0x0029F91C File Offset: 0x0029DB1C
			// (set) Token: 0x06009EB0 RID: 40624 RVA: 0x00055AF1 File Offset: 0x00053CF1
			public unsafe IGuideMapSpot guideMapSpot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0.NativeFieldInfoPtr_guideMapSpot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGuideMapSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0.NativeFieldInfoPtr_guideMapSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700346F RID: 13423
			// (get) Token: 0x06009EB1 RID: 40625 RVA: 0x0029F94C File Offset: 0x0029DB4C
			// (set) Token: 0x06009EB2 RID: 40626 RVA: 0x00055B10 File Offset: 0x00053D10
			public unsafe DLC5_RogueLikeSpotSelectionPanel_New __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel_New>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040066F3 RID: 26355
			private static readonly IntPtr NativeFieldInfoPtr_guideMapSpot;

			// Token: 0x040066F4 RID: 26356
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040066F5 RID: 26357
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040066F6 RID: 26358
			private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__11_Internal_Void_0;
		}

		// Token: 0x02000740 RID: 1856
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel_New+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009EB3 RID: 40627 RVA: 0x0029F97C File Offset: 0x0029DB7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__39_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, "<>9__39_12");
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__39_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, "<>9__39_1");
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, "<>9__41_0");
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__41_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, "<>9__41_1");
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__43_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, "<>9__43_2");
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__48_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, "<>9__48_2");
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__49_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, "<>9__49_1");
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, "<>9__51_0");
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__55_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, "<>9__55_0");
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__55_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, "<>9__55_1");
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, 100669349);
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_12_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, 100669350);
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_1_Internal_Void_UIButtonToggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, 100669351);
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OpenDescriptionMenu_b__41_0_Internal_String_KeyValuePair_2_String_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, 100669352);
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OpenDescriptionMenu_b__41_1_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, 100669353);
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__UpdateNeighbourDistance_b__43_2_Internal_GuideMapSpot_KeyValuePair_2_GuideMapSpot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, 100669354);
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__TryCheckElite_b__48_2_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, 100669355);
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OpenPurchasePanel_b__49_1_Internal_ProductReference_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, 100669356);
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__GetSpotOpenStatus_b__51_0_Internal_String_KeyValuePair_2_String_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, 100669357);
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OnGuideMapSpotSelected_b__55_0_Internal_String_KeyValuePair_2_String_EliteChallengeCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, 100669358);
				DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OnGuideMapSpotSelected_b__55_1_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr, 100669359);
			}

			// Token: 0x06009EB4 RID: 40628 RVA: 0x0029FB60 File Offset: 0x0029DD60
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EB5 RID: 40629 RVA: 0x0029FB9C File Offset: 0x0029DD9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82136, XrefRangeEnd = 82137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnGuideMapInitialize_b__39_12(CanvasGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_12_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EB6 RID: 40630 RVA: 0x0029FBE0 File Offset: 0x0029DDE0
			[CallerCount(0)]
			public unsafe void _OnGuideMapInitialize_b__39_1(UIButtonToggle toggle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OnGuideMapInitialize_b__39_1_Internal_Void_UIButtonToggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EB7 RID: 40631 RVA: 0x0029FC24 File Offset: 0x0029DE24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82137, XrefRangeEnd = 82138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OpenDescriptionMenu_b__41_0(KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OpenDescriptionMenu_b__41_0_Internal_String_KeyValuePair_2_String_EliteChallengeCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009EB8 RID: 40632 RVA: 0x0029FC74 File Offset: 0x0029DE74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82138, XrefRangeEnd = 82139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenDescriptionMenu_b__41_1(CanvasGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OpenDescriptionMenu_b__41_1_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EB9 RID: 40633 RVA: 0x0029FCB8 File Offset: 0x0029DEB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82139, XrefRangeEnd = 82140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuideMapSpot _UpdateNeighbourDistance_b__43_2(KeyValuePair<GuideMapSpot, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__UpdateNeighbourDistance_b__43_2_Internal_GuideMapSpot_KeyValuePair_2_GuideMapSpot_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuideMapSpot>(intPtr3) : null;
			}

			// Token: 0x06009EBA RID: 40634 RVA: 0x0029FD10 File Offset: 0x0029DF10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryCheckElite_b__48_2(CanvasGroup y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__TryCheckElite_b__48_2_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EBB RID: 40635 RVA: 0x0029FD54 File Offset: 0x0029DF54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82140, XrefRangeEnd = 82144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProductReference _OpenPurchasePanel_b__49_1(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OpenPurchasePanel_b__49_1_Internal_ProductReference_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductReference>(intPtr3) : null;
			}

			// Token: 0x06009EBC RID: 40636 RVA: 0x0029FDAC File Offset: 0x0029DFAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82144, XrefRangeEnd = 82145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetSpotOpenStatus_b__51_0(KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__GetSpotOpenStatus_b__51_0_Internal_String_KeyValuePair_2_String_EliteChallengeCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009EBD RID: 40637 RVA: 0x0029FDFC File Offset: 0x0029DFFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82145, XrefRangeEnd = 82146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnGuideMapSpotSelected_b__55_0(KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OnGuideMapSpotSelected_b__55_0_Internal_String_KeyValuePair_2_String_EliteChallengeCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009EBE RID: 40638 RVA: 0x0029FE4C File Offset: 0x0029E04C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnGuideMapSpotSelected_b__55_1(CanvasGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeMethodInfoPtr__OnGuideMapSpotSelected_b__55_1_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EBF RID: 40639 RVA: 0x00055B2F File Offset: 0x00053D2F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003470 RID: 13424
			// (get) Token: 0x06009EC0 RID: 40640 RVA: 0x0029FE90 File Offset: 0x0029E090
			// (set) Token: 0x06009EC1 RID: 40641 RVA: 0x00055B38 File Offset: 0x00053D38
			public unsafe static DLC5_RogueLikeSpotSelectionPanel_New.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel_New.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003471 RID: 13425
			// (get) Token: 0x06009EC2 RID: 40642 RVA: 0x0029FEB8 File Offset: 0x0029E0B8
			// (set) Token: 0x06009EC3 RID: 40643 RVA: 0x00055B4A File Offset: 0x00053D4A
			public unsafe static Action<CanvasGroup> __9__39_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__39_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__39_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003472 RID: 13426
			// (get) Token: 0x06009EC4 RID: 40644 RVA: 0x0029FEE0 File Offset: 0x0029E0E0
			// (set) Token: 0x06009EC5 RID: 40645 RVA: 0x00055B5C File Offset: 0x00053D5C
			public unsafe static Action<UIButtonToggle> __9__39_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__39_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIButtonToggle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__39_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003473 RID: 13427
			// (get) Token: 0x06009EC6 RID: 40646 RVA: 0x0029FF08 File Offset: 0x0029E108
			// (set) Token: 0x06009EC7 RID: 40647 RVA: 0x00055B6E File Offset: 0x00053D6E
			public unsafe static Func<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>, string> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003474 RID: 13428
			// (get) Token: 0x06009EC8 RID: 40648 RVA: 0x0029FF30 File Offset: 0x0029E130
			// (set) Token: 0x06009EC9 RID: 40649 RVA: 0x00055B80 File Offset: 0x00053D80
			public unsafe static Action<CanvasGroup> __9__41_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__41_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__41_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003475 RID: 13429
			// (get) Token: 0x06009ECA RID: 40650 RVA: 0x0029FF58 File Offset: 0x0029E158
			// (set) Token: 0x06009ECB RID: 40651 RVA: 0x00055B92 File Offset: 0x00053D92
			public unsafe static Func<KeyValuePair<GuideMapSpot, int>, GuideMapSpot> __9__43_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__43_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<GuideMapSpot, int>, GuideMapSpot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__43_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003476 RID: 13430
			// (get) Token: 0x06009ECC RID: 40652 RVA: 0x0029FF80 File Offset: 0x0029E180
			// (set) Token: 0x06009ECD RID: 40653 RVA: 0x00055BA4 File Offset: 0x00053DA4
			public unsafe static Action<CanvasGroup> __9__48_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__48_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__48_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003477 RID: 13431
			// (get) Token: 0x06009ECE RID: 40654 RVA: 0x0029FFA8 File Offset: 0x0029E1A8
			// (set) Token: 0x06009ECF RID: 40655 RVA: 0x00055BB6 File Offset: 0x00053DB6
			public unsafe static Func<Product, ProductReference> __9__49_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__49_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, ProductReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__49_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003478 RID: 13432
			// (get) Token: 0x06009ED0 RID: 40656 RVA: 0x0029FFD0 File Offset: 0x0029E1D0
			// (set) Token: 0x06009ED1 RID: 40657 RVA: 0x00055BC8 File Offset: 0x00053DC8
			public unsafe static Func<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>, string> __9__51_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__51_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003479 RID: 13433
			// (get) Token: 0x06009ED2 RID: 40658 RVA: 0x0029FFF8 File Offset: 0x0029E1F8
			// (set) Token: 0x06009ED3 RID: 40659 RVA: 0x00055BDA File Offset: 0x00053DDA
			public unsafe static Func<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>, string> __9__55_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__55_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__55_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700347A RID: 13434
			// (get) Token: 0x06009ED4 RID: 40660 RVA: 0x002A0020 File Offset: 0x0029E220
			// (set) Token: 0x06009ED5 RID: 40661 RVA: 0x00055BEC File Offset: 0x00053DEC
			public unsafe static Action<CanvasGroup> __9__55_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__55_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel_New.__c.NativeFieldInfoPtr___9__55_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040066F7 RID: 26359
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040066F8 RID: 26360
			private static readonly IntPtr NativeFieldInfoPtr___9__39_12;

			// Token: 0x040066F9 RID: 26361
			private static readonly IntPtr NativeFieldInfoPtr___9__39_1;

			// Token: 0x040066FA RID: 26362
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x040066FB RID: 26363
			private static readonly IntPtr NativeFieldInfoPtr___9__41_1;

			// Token: 0x040066FC RID: 26364
			private static readonly IntPtr NativeFieldInfoPtr___9__43_2;

			// Token: 0x040066FD RID: 26365
			private static readonly IntPtr NativeFieldInfoPtr___9__48_2;

			// Token: 0x040066FE RID: 26366
			private static readonly IntPtr NativeFieldInfoPtr___9__49_1;

			// Token: 0x040066FF RID: 26367
			private static readonly IntPtr NativeFieldInfoPtr___9__51_0;

			// Token: 0x04006700 RID: 26368
			private static readonly IntPtr NativeFieldInfoPtr___9__55_0;

			// Token: 0x04006701 RID: 26369
			private static readonly IntPtr NativeFieldInfoPtr___9__55_1;

			// Token: 0x04006702 RID: 26370
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006703 RID: 26371
			private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__39_12_Internal_Void_CanvasGroup_0;

			// Token: 0x04006704 RID: 26372
			private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__39_1_Internal_Void_UIButtonToggle_0;

			// Token: 0x04006705 RID: 26373
			private static readonly IntPtr NativeMethodInfoPtr__OpenDescriptionMenu_b__41_0_Internal_String_KeyValuePair_2_String_EliteChallengeCache_0;

			// Token: 0x04006706 RID: 26374
			private static readonly IntPtr NativeMethodInfoPtr__OpenDescriptionMenu_b__41_1_Internal_Void_CanvasGroup_0;

			// Token: 0x04006707 RID: 26375
			private static readonly IntPtr NativeMethodInfoPtr__UpdateNeighbourDistance_b__43_2_Internal_GuideMapSpot_KeyValuePair_2_GuideMapSpot_Int32_0;

			// Token: 0x04006708 RID: 26376
			private static readonly IntPtr NativeMethodInfoPtr__TryCheckElite_b__48_2_Internal_Void_CanvasGroup_0;

			// Token: 0x04006709 RID: 26377
			private static readonly IntPtr NativeMethodInfoPtr__OpenPurchasePanel_b__49_1_Internal_ProductReference_Product_0;

			// Token: 0x0400670A RID: 26378
			private static readonly IntPtr NativeMethodInfoPtr__GetSpotOpenStatus_b__51_0_Internal_String_KeyValuePair_2_String_EliteChallengeCache_0;

			// Token: 0x0400670B RID: 26379
			private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapSpotSelected_b__55_0_Internal_String_KeyValuePair_2_String_EliteChallengeCache_0;

			// Token: 0x0400670C RID: 26380
			private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapSpotSelected_b__55_1_Internal_Void_CanvasGroup_0;
		}

		// Token: 0x02000741 RID: 1857
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel_New+<OpenDescriptionMenu>d__41")]
		public sealed class _OpenDescriptionMenu_d__41 : ValueType
		{
			// Token: 0x06009ED6 RID: 40662 RVA: 0x002A0048 File Offset: 0x0029E248
			// Note: this type is marked as 'beforefieldinit'.
			static _OpenDescriptionMenu_d__41()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "<OpenDescriptionMenu>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41>.NativeClassPtr, "<>t__builder");
				DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41>.NativeClassPtr, "<>u__1");
				DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41>.NativeClassPtr, 100669360);
				DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41>.NativeClassPtr, 100669361);
			}

			// Token: 0x06009ED7 RID: 40663 RVA: 0x002A00EC File Offset: 0x0029E2EC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 82208, RefRangeEnd = 82212, XrefRangeStart = 82146, XrefRangeEnd = 82208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009ED8 RID: 40664 RVA: 0x002A0124 File Offset: 0x0029E324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009ED9 RID: 40665 RVA: 0x00055BFE File Offset: 0x00053DFE
			public _OpenDescriptionMenu_d__41(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009EDA RID: 40666 RVA: 0x00055C07 File Offset: 0x00053E07
			public _OpenDescriptionMenu_d__41() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41>.NativeClassPtr))
			{
			}

			// Token: 0x1700347B RID: 13435
			// (get) Token: 0x06009EDB RID: 40667 RVA: 0x002A016C File Offset: 0x0029E36C
			// (set) Token: 0x06009EDC RID: 40668 RVA: 0x00055C19 File Offset: 0x00053E19
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700347C RID: 13436
			// (get) Token: 0x06009EDD RID: 40669 RVA: 0x002A0194 File Offset: 0x0029E394
			// (set) Token: 0x06009EDE RID: 40670 RVA: 0x00055C34 File Offset: 0x00053E34
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700347D RID: 13437
			// (get) Token: 0x06009EDF RID: 40671 RVA: 0x002A01C4 File Offset: 0x0029E3C4
			// (set) Token: 0x06009EE0 RID: 40672 RVA: 0x00055C62 File Offset: 0x00053E62
			public unsafe DLC5_RogueLikeSpotSelectionPanel_New __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel_New>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700347E RID: 13438
			// (get) Token: 0x06009EE1 RID: 40673 RVA: 0x002A01F4 File Offset: 0x0029E3F4
			// (set) Token: 0x06009EE2 RID: 40674 RVA: 0x00055C81 File Offset: 0x00053E81
			public UniTask<RogueLikeDetailPanel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeFieldInfoPtr___u__1);
					return new UniTask<RogueLikeDetailPanel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<RogueLikeDetailPanel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._OpenDescriptionMenu_d__41.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<RogueLikeDetailPanel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400670D RID: 26381
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400670E RID: 26382
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400670F RID: 26383
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006710 RID: 26384
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006711 RID: 26385
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006712 RID: 26386
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000742 RID: 1858
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel_New+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x06009EE3 RID: 40675 RVA: 0x002A0224 File Offset: 0x0029E424
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0.NativeFieldInfoPtr_currentSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0>.NativeClassPtr, "currentSpot");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0>.NativeClassPtr, 100669362);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0.NativeMethodInfoPtr__UpdateNeighbourDistance_b__0_Internal_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0>.NativeClassPtr, 100669363);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0.NativeMethodInfoPtr__UpdateNeighbourDistance_b__1_Internal_Boolean_KeyValuePair_2_GuideMapSpot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0>.NativeClassPtr, 100669364);
			}

			// Token: 0x06009EE4 RID: 40676 RVA: 0x002A02B4 File Offset: 0x0029E4B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EE5 RID: 40677 RVA: 0x002A02F0 File Offset: 0x0029E4F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82212, XrefRangeEnd = 82217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateNeighbourDistance_b__0(IGuideMapSpot node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0.NativeMethodInfoPtr__UpdateNeighbourDistance_b__0_Internal_Boolean_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009EE6 RID: 40678 RVA: 0x002A0340 File Offset: 0x0029E540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82217, XrefRangeEnd = 82219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateNeighbourDistance_b__1(KeyValuePair<GuideMapSpot, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0.NativeMethodInfoPtr__UpdateNeighbourDistance_b__1_Internal_Boolean_KeyValuePair_2_GuideMapSpot_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009EE7 RID: 40679 RVA: 0x00055CAF File Offset: 0x00053EAF
			public __c__DisplayClass43_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700347F RID: 13439
			// (get) Token: 0x06009EE8 RID: 40680 RVA: 0x002A0394 File Offset: 0x0029E594
			// (set) Token: 0x06009EE9 RID: 40681 RVA: 0x00055CB8 File Offset: 0x00053EB8
			public unsafe string currentSpot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0.NativeFieldInfoPtr_currentSpot);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0.NativeFieldInfoPtr_currentSpot), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003480 RID: 13440
			// (get) Token: 0x06009EEA RID: 40682 RVA: 0x002A03BC File Offset: 0x0029E5BC
			// (set) Token: 0x06009EEB RID: 40683 RVA: 0x00055CD7 File Offset: 0x00053ED7
			public unsafe DLC5_RogueLikeSpotSelectionPanel_New __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel_New>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006713 RID: 26387
			private static readonly IntPtr NativeFieldInfoPtr_currentSpot;

			// Token: 0x04006714 RID: 26388
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006715 RID: 26389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006716 RID: 26390
			private static readonly IntPtr NativeMethodInfoPtr__UpdateNeighbourDistance_b__0_Internal_Boolean_IGuideMapSpot_0;

			// Token: 0x04006717 RID: 26391
			private static readonly IntPtr NativeMethodInfoPtr__UpdateNeighbourDistance_b__1_Internal_Boolean_KeyValuePair_2_GuideMapSpot_Int32_0;
		}

		// Token: 0x02000743 RID: 1859
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel_New+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
		{
			// Token: 0x06009EEC RID: 40684 RVA: 0x002A03EC File Offset: 0x0029E5EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0.NativeFieldInfoPtr_exitMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0>.NativeClassPtr, "exitMode");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0>.NativeClassPtr, 100669365);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0.NativeMethodInfoPtr__ClosePanelByExtraSub_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0>.NativeClassPtr, 100669366);
			}

			// Token: 0x06009EED RID: 40685 RVA: 0x002A0468 File Offset: 0x0029E668
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EEE RID: 40686 RVA: 0x002A04A4 File Offset: 0x0029E6A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82219, XrefRangeEnd = 82231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ClosePanelByExtraSub_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0.NativeMethodInfoPtr__ClosePanelByExtraSub_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EEF RID: 40687 RVA: 0x00055CF6 File Offset: 0x00053EF6
			public __c__DisplayClass44_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003481 RID: 13441
			// (get) Token: 0x06009EF0 RID: 40688 RVA: 0x002A04D8 File Offset: 0x0029E6D8
			// (set) Token: 0x06009EF1 RID: 40689 RVA: 0x00055CFF File Offset: 0x00053EFF
			public unsafe DLC5_RogueLikeExtraMenuSubPanel.CloseContext exitMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0.NativeFieldInfoPtr_exitMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0.NativeFieldInfoPtr_exitMode)) = value;
				}
			}

			// Token: 0x17003482 RID: 13442
			// (get) Token: 0x06009EF2 RID: 40690 RVA: 0x002A0500 File Offset: 0x0029E700
			// (set) Token: 0x06009EF3 RID: 40691 RVA: 0x00055D1A File Offset: 0x00053F1A
			public unsafe DLC5_RogueLikeSpotSelectionPanel_New __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel_New>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006718 RID: 26392
			private static readonly IntPtr NativeFieldInfoPtr_exitMode;

			// Token: 0x04006719 RID: 26393
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400671A RID: 26394
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400671B RID: 26395
			private static readonly IntPtr NativeMethodInfoPtr__ClosePanelByExtraSub_b__0_Internal_Void_0;
		}

		// Token: 0x02000744 RID: 1860
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel_New+<>c__DisplayClass45_0")]
		public sealed class __c__DisplayClass45_0 : Il2CppSystem.Object
		{
			// Token: 0x06009EF4 RID: 40692 RVA: 0x002A0530 File Offset: 0x0029E730
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "<>c__DisplayClass45_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0.NativeFieldInfoPtr_remindSubPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0>.NativeClassPtr, "remindSubPanel");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0>.NativeClassPtr, 100669367);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0.NativeMethodInfoPtr__TryClosePanel_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0>.NativeClassPtr, 100669368);
			}

			// Token: 0x06009EF5 RID: 40693 RVA: 0x002A05AC File Offset: 0x0029E7AC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EF6 RID: 40694 RVA: 0x002A05E8 File Offset: 0x0029E7E8
			[CallerCount(0)]
			public unsafe void _TryClosePanel_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0.NativeMethodInfoPtr__TryClosePanel_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EF7 RID: 40695 RVA: 0x00055D39 File Offset: 0x00053F39
			public __c__DisplayClass45_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003483 RID: 13443
			// (get) Token: 0x06009EF8 RID: 40696 RVA: 0x002A061C File Offset: 0x0029E81C
			// (set) Token: 0x06009EF9 RID: 40697 RVA: 0x00055D42 File Offset: 0x00053F42
			public unsafe RemindSubPanel remindSubPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0.NativeFieldInfoPtr_remindSubPanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemindSubPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0.NativeFieldInfoPtr_remindSubPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003484 RID: 13444
			// (get) Token: 0x06009EFA RID: 40698 RVA: 0x002A064C File Offset: 0x0029E84C
			// (set) Token: 0x06009EFB RID: 40699 RVA: 0x00055D61 File Offset: 0x00053F61
			public unsafe DLC5_RogueLikeSpotSelectionPanel_New __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel_New>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400671C RID: 26396
			private static readonly IntPtr NativeFieldInfoPtr_remindSubPanel;

			// Token: 0x0400671D RID: 26397
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400671E RID: 26398
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400671F RID: 26399
			private static readonly IntPtr NativeMethodInfoPtr__TryClosePanel_b__1_Internal_Void_0;
		}

		// Token: 0x02000745 RID: 1861
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel_New+<WaitForClothesAndPartnerSetting>d__46")]
		public sealed class _WaitForClothesAndPartnerSetting_d__46 : ValueType
		{
			// Token: 0x06009EFC RID: 40700 RVA: 0x002A067C File Offset: 0x0029E87C
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForClothesAndPartnerSetting_d__46()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "<WaitForClothesAndPartnerSetting>d__46");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46>.NativeClassPtr, "<>t__builder");
				DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46>.NativeClassPtr, "onFinish");
				DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr__partnerSelection_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46>.NativeClassPtr, "<partnerSelection>5__2");
				DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46>.NativeClassPtr, "<>u__1");
				DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46>.NativeClassPtr, 100669369);
				DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46>.NativeClassPtr, 100669370);
			}

			// Token: 0x06009EFD RID: 40701 RVA: 0x002A0748 File Offset: 0x0029E948
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 82300, RefRangeEnd = 82303, XrefRangeStart = 82231, XrefRangeEnd = 82300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EFE RID: 40702 RVA: 0x002A0780 File Offset: 0x0029E980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009EFF RID: 40703 RVA: 0x00055D80 File Offset: 0x00053F80
			public _WaitForClothesAndPartnerSetting_d__46(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009F00 RID: 40704 RVA: 0x00055D89 File Offset: 0x00053F89
			public _WaitForClothesAndPartnerSetting_d__46() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46>.NativeClassPtr))
			{
			}

			// Token: 0x17003485 RID: 13445
			// (get) Token: 0x06009F01 RID: 40705 RVA: 0x002A07C8 File Offset: 0x0029E9C8
			// (set) Token: 0x06009F02 RID: 40706 RVA: 0x00055D9B File Offset: 0x00053F9B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003486 RID: 13446
			// (get) Token: 0x06009F03 RID: 40707 RVA: 0x002A07F0 File Offset: 0x0029E9F0
			// (set) Token: 0x06009F04 RID: 40708 RVA: 0x00055DB6 File Offset: 0x00053FB6
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003487 RID: 13447
			// (get) Token: 0x06009F05 RID: 40709 RVA: 0x002A0820 File Offset: 0x0029EA20
			// (set) Token: 0x06009F06 RID: 40710 RVA: 0x00055DE4 File Offset: 0x00053FE4
			public unsafe DLC5_RogueLikeSpotSelectionPanel_New __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel_New>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003488 RID: 13448
			// (get) Token: 0x06009F07 RID: 40711 RVA: 0x002A0850 File Offset: 0x0029EA50
			// (set) Token: 0x06009F08 RID: 40712 RVA: 0x00055E03 File Offset: 0x00054003
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003489 RID: 13449
			// (get) Token: 0x06009F09 RID: 40713 RVA: 0x002A0880 File Offset: 0x0029EA80
			// (set) Token: 0x06009F0A RID: 40714 RVA: 0x00055E22 File Offset: 0x00054022
			public unsafe Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>> _partnerSelection_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr__partnerSelection_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr__partnerSelection_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700348A RID: 13450
			// (get) Token: 0x06009F0B RID: 40715 RVA: 0x002A08B0 File Offset: 0x0029EAB0
			// (set) Token: 0x06009F0C RID: 40716 RVA: 0x00055E41 File Offset: 0x00054041
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New._WaitForClothesAndPartnerSetting_d__46.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006720 RID: 26400
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006721 RID: 26401
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006722 RID: 26402
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006723 RID: 26403
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x04006724 RID: 26404
			private static readonly IntPtr NativeFieldInfoPtr__partnerSelection_5__2;

			// Token: 0x04006725 RID: 26405
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006726 RID: 26406
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006727 RID: 26407
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000746 RID: 1862
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel_New+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : Il2CppSystem.Object
		{
			// Token: 0x06009F0D RID: 40717 RVA: 0x002A08E0 File Offset: 0x0029EAE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeFieldInfoPtr_eliteSpotLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0>.NativeClassPtr, "eliteSpotLabel");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeFieldInfoPtr_targetSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0>.NativeClassPtr, "targetSpot");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0>.NativeClassPtr, 100669371);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeMethodInfoPtr__TryCheckElite_b__0_Internal_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0>.NativeClassPtr, 100669372);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeMethodInfoPtr__TryCheckElite_b__1_Internal_Void_DLC5_RogueLikeSpotSelectionPanelEliteTipPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0>.NativeClassPtr, 100669373);
			}

			// Token: 0x06009F0E RID: 40718 RVA: 0x002A0984 File Offset: 0x0029EB84
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F0F RID: 40719 RVA: 0x002A09C0 File Offset: 0x0029EBC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82303, XrefRangeEnd = 82308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryCheckElite_b__0(IGuideMapSpot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeMethodInfoPtr__TryCheckElite_b__0_Internal_Boolean_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009F10 RID: 40720 RVA: 0x002A0A10 File Offset: 0x0029EC10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82308, XrefRangeEnd = 82331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryCheckElite_b__1(DLC5_RogueLikeSpotSelectionPanelEliteTipPanel x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeMethodInfoPtr__TryCheckElite_b__1_Internal_Void_DLC5_RogueLikeSpotSelectionPanelEliteTipPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F11 RID: 40721 RVA: 0x00055E6F File Offset: 0x0005406F
			public __c__DisplayClass48_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700348B RID: 13451
			// (get) Token: 0x06009F12 RID: 40722 RVA: 0x002A0A54 File Offset: 0x0029EC54
			// (set) Token: 0x06009F13 RID: 40723 RVA: 0x00055E78 File Offset: 0x00054078
			public unsafe DLC5_RogueLikeSpotSelectionPanel_New __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel_New>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700348C RID: 13452
			// (get) Token: 0x06009F14 RID: 40724 RVA: 0x002A0A84 File Offset: 0x0029EC84
			// (set) Token: 0x06009F15 RID: 40725 RVA: 0x00055E97 File Offset: 0x00054097
			public unsafe string eliteSpotLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeFieldInfoPtr_eliteSpotLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeFieldInfoPtr_eliteSpotLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700348D RID: 13453
			// (get) Token: 0x06009F16 RID: 40726 RVA: 0x002A0AAC File Offset: 0x0029ECAC
			// (set) Token: 0x06009F17 RID: 40727 RVA: 0x00055EB6 File Offset: 0x000540B6
			public unsafe IGuideMapSpot targetSpot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeFieldInfoPtr_targetSpot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGuideMapSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass48_0.NativeFieldInfoPtr_targetSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006728 RID: 26408
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006729 RID: 26409
			private static readonly IntPtr NativeFieldInfoPtr_eliteSpotLabel;

			// Token: 0x0400672A RID: 26410
			private static readonly IntPtr NativeFieldInfoPtr_targetSpot;

			// Token: 0x0400672B RID: 26411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400672C RID: 26412
			private static readonly IntPtr NativeMethodInfoPtr__TryCheckElite_b__0_Internal_Boolean_IGuideMapSpot_0;

			// Token: 0x0400672D RID: 26413
			private static readonly IntPtr NativeMethodInfoPtr__TryCheckElite_b__1_Internal_Void_DLC5_RogueLikeSpotSelectionPanelEliteTipPanel_0;
		}

		// Token: 0x02000747 RID: 1863
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel_New+<>c__DisplayClass49_0")]
		public sealed class __c__DisplayClass49_0 : Il2CppSystem.Object
		{
			// Token: 0x06009F18 RID: 40728 RVA: 0x002A0ADC File Offset: 0x0029ECDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass49_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "<>c__DisplayClass49_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0>.NativeClassPtr, "handle");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0>.NativeClassPtr, 100669374);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0.NativeMethodInfoPtr__OpenPurchasePanel_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0>.NativeClassPtr, 100669375);
			}

			// Token: 0x06009F19 RID: 40729 RVA: 0x002A0B58 File Offset: 0x0029ED58
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass49_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F1A RID: 40730 RVA: 0x002A0B94 File Offset: 0x0029ED94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82331, XrefRangeEnd = 82337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenPurchasePanel_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0.NativeMethodInfoPtr__OpenPurchasePanel_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F1B RID: 40731 RVA: 0x00055ED5 File Offset: 0x000540D5
			public __c__DisplayClass49_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700348E RID: 13454
			// (get) Token: 0x06009F1C RID: 40732 RVA: 0x002A0BC8 File Offset: 0x0029EDC8
			// (set) Token: 0x06009F1D RID: 40733 RVA: 0x00055EDE File Offset: 0x000540DE
			public unsafe IDisposable handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0.NativeFieldInfoPtr_handle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700348F RID: 13455
			// (get) Token: 0x06009F1E RID: 40734 RVA: 0x002A0BF8 File Offset: 0x0029EDF8
			// (set) Token: 0x06009F1F RID: 40735 RVA: 0x00055EFD File Offset: 0x000540FD
			public unsafe DLC5_RogueLikeSpotSelectionPanel_New __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel_New>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass49_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400672E RID: 26414
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x0400672F RID: 26415
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006730 RID: 26416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006731 RID: 26417
			private static readonly IntPtr NativeMethodInfoPtr__OpenPurchasePanel_b__0_Internal_Void_0;
		}

		// Token: 0x02000748 RID: 1864
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel_New+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x06009F20 RID: 40736 RVA: 0x002A0C28 File Offset: 0x0029EE28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeFieldInfoPtr_guideMapSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0>.NativeClassPtr, "guideMapSpot");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeFieldInfoPtr_hasElite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0>.NativeClassPtr, "hasElite");
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0>.NativeClassPtr, 100669376);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeMethodInfoPtr__GetSpotOpenStatus_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0>.NativeClassPtr, 100669377);
				DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeMethodInfoPtr__GetSpotOpenStatus_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0>.NativeClassPtr, 100669378);
			}

			// Token: 0x06009F21 RID: 40737 RVA: 0x002A0CCC File Offset: 0x0029EECC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F22 RID: 40738 RVA: 0x002A0D08 File Offset: 0x0029EF08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82337, XrefRangeEnd = 82346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetSpotOpenStatus_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeMethodInfoPtr__GetSpotOpenStatus_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F23 RID: 40739 RVA: 0x002A0D4C File Offset: 0x0029EF4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetSpotOpenStatus_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeMethodInfoPtr__GetSpotOpenStatus_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F24 RID: 40740 RVA: 0x00055F1C File Offset: 0x0005411C
			public __c__DisplayClass51_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003490 RID: 13456
			// (get) Token: 0x06009F25 RID: 40741 RVA: 0x002A0D90 File Offset: 0x0029EF90
			// (set) Token: 0x06009F26 RID: 40742 RVA: 0x00055F25 File Offset: 0x00054125
			public unsafe DLC5_RogueLikeSpotSelectionPanel_New __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel_New>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003491 RID: 13457
			// (get) Token: 0x06009F27 RID: 40743 RVA: 0x002A0DC0 File Offset: 0x0029EFC0
			// (set) Token: 0x06009F28 RID: 40744 RVA: 0x00055F44 File Offset: 0x00054144
			public unsafe IGuideMapSpot guideMapSpot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeFieldInfoPtr_guideMapSpot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGuideMapSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeFieldInfoPtr_guideMapSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003492 RID: 13458
			// (get) Token: 0x06009F29 RID: 40745 RVA: 0x002A0DF0 File Offset: 0x0029EFF0
			// (set) Token: 0x06009F2A RID: 40746 RVA: 0x00055F63 File Offset: 0x00054163
			public unsafe bool hasElite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeFieldInfoPtr_hasElite);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel_New.__c__DisplayClass51_0.NativeFieldInfoPtr_hasElite)) = value;
				}
			}

			// Token: 0x04006732 RID: 26418
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006733 RID: 26419
			private static readonly IntPtr NativeFieldInfoPtr_guideMapSpot;

			// Token: 0x04006734 RID: 26420
			private static readonly IntPtr NativeFieldInfoPtr_hasElite;

			// Token: 0x04006735 RID: 26421
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006736 RID: 26422
			private static readonly IntPtr NativeMethodInfoPtr__GetSpotOpenStatus_b__1_Internal_Void_Image_0;

			// Token: 0x04006737 RID: 26423
			private static readonly IntPtr NativeMethodInfoPtr__GetSpotOpenStatus_b__2_Internal_Void_Image_0;
		}
	}
}
