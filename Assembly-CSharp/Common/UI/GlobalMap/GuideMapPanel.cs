using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.GlobalMap
{
	// Token: 0x020003D6 RID: 982
	public class GuideMapPanel<TOpenContext, TCloseContext> : UIPanelParam<TOpenContext, TCloseContext>
	{
		// Token: 0x0600752D RID: 29997 RVA: 0x00224F3C File Offset: 0x0022313C
		// Note: this type is marked as 'beforefieldinit'.
		static GuideMapPanel()
		{
			Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.GlobalMap", "GuideMapPanel`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOpenContext>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCloseContext>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_GuideMapController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_GuideMapController");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Min_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Min_Normal");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Max_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Max_Normal");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Center_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Center_Normal");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Min_Shrink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Min_Shrink");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Max_Shrink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Max_Shrink");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Center_Shrink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Center_Shrink");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Min_Expand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Min_Expand");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Max_Expand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Max_Expand");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Center_Expand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Center_Expand");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Duration");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_DragDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_DragDuration");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_HighLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_HighLight");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Background");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_NormalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_NormalSize");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_ShrinkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_ShrinkSize");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_ExpandSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_ExpandSize");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_GuideMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_GuideMap");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_SelectedSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_SelectedSpot");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_FocusingSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_FocusingSpot");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_CurrentVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_CurrentVelocity");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_GuideMapDragPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_GuideMapDragPosition");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_GuideMapStartDragOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_GuideMapStartDragOffset");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr__IsFolded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "<IsFolded>k__BackingField");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Min_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Min_Current");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Max_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Max_Current");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Center_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "m_Center_Current");
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_get_GuideMapRectTransform_Protected_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687356);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_get_IsFolded_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687357);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_set_IsFolded_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687358);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687359);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnPointerDown_Private_Void_InputButton_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687360);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnPointerDrag_Private_Void_InputButton_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687361);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_ToggleFolding_Protected_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687362);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_UpdateFolding_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687363);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_ToggleBackground_Protected_Void_BackgroundFoldingMode_TOpenContext_TCloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687364);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Final_Void_TOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687365);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Final_Void_TCloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687366);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687367);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687368);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapPanelPreOpen_Protected_Virtual_New_Void_TOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687369);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapPanelPostOpen_Protected_Virtual_New_Void_TOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687370);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapPanelEndOpen_Protected_Virtual_New_Void_TOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687371);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_PostInitializeGuideMapSpot_Protected_Virtual_New_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687372);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_New_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687373);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_GetSpotShouldShowPath_Protected_Virtual_New_Boolean_IGuideMapSpot_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687374);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_IsFirstToSelectSpot_Protected_Virtual_New_Nullable_1_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687375);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_New_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687376);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_IsGuideMapSpotCanBeSelected_Protected_Virtual_New_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687377);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapSpotSubmit_Protected_Virtual_New_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687378);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapClose_Protected_Virtual_New_Void_TCloseContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687379);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnSecondarySwitchUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687380);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_GetTravelCount_Protected_Int32_IGuideMapSpot_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687381);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_GetSpotList_Protected_IReadOnlyList_1_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687382);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_GetNeighbourDistance_Protected_IReadOnlyDictionary_2_GuideMapSpot_Int32_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687383);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_UpdateSelectionSpots_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687384);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_FocusToGuideMapSpot_Private_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687385);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687386);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_UpdateInternal_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687387);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_FocusToDrag_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687388);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_FocusToSpot_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687389);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_ClampPosition_Private_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687390);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687391);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687392);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr__OnPanelInitialize_b__33_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687393);
			GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr__ToggleBackground_b__38_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, 100687394);
		}

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x0600752E RID: 29998 RVA: 0x002254E4 File Offset: 0x002236E4
		public unsafe RectTransform GuideMapRectTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_get_GuideMapRectTransform_Protected_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x1700282B RID: 10283
		// (get) Token: 0x0600752F RID: 29999 RVA: 0x00225524 File Offset: 0x00223724
		// (set) Token: 0x06007530 RID: 30000 RVA: 0x00225560 File Offset: 0x00223760
		public unsafe bool IsFolded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_get_IsFolded_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_set_IsFolded_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007531 RID: 30001 RVA: 0x002255A0 File Offset: 0x002237A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291291, XrefRangeEnd = 291355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x002255D4 File Offset: 0x002237D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291355, XrefRangeEnd = 291357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerDown(PointerEventData.InputButton inputButton, Vector2 pressPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputButton;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pressPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnPointerDown_Private_Void_InputButton_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x00225620 File Offset: 0x00223820
		[CallerCount(0)]
		public unsafe void OnPointerDrag(PointerEventData.InputButton inputButton, Vector2 pressPosition, Vector2 currentPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputButton;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pressPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnPointerDrag_Private_Void_InputButton_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007534 RID: 30004 RVA: 0x0022567C File Offset: 0x0022387C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291357, XrefRangeEnd = 291365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleFolding(Nullable<bool> newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newValue));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_ToggleFolding_Protected_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007535 RID: 30005 RVA: 0x002256C4 File Offset: 0x002238C4
		[CallerCount(0)]
		public unsafe void UpdateFolding(bool isFolded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isFolded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_UpdateFolding_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007536 RID: 30006 RVA: 0x00225704 File Offset: 0x00223904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291365, XrefRangeEnd = 291383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleBackground(GuideMapPanel<TOpenContext, TCloseContext>.BackgroundFoldingMode backgroundFoldingMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref backgroundFoldingMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_ToggleBackground_Protected_Void_BackgroundFoldingMode_TOpenContext_TCloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007537 RID: 30007 RVA: 0x00225744 File Offset: 0x00223944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291383, XrefRangeEnd = 291467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(TOpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TOpenContext).IsValueType)
			{
				TOpenContext topenContext = openContext;
				intPtr = ((topenContext is string) ? IL2CPP.ManagedStringToIl2Cpp(topenContext as string) : IL2CPP.Il2CppObjectBaseToPtr(topenContext as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref openContext;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Final_Void_TOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06007538 RID: 30008 RVA: 0x002257BC File Offset: 0x002239BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291467, XrefRangeEnd = 291494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose(TCloseContext closeContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TCloseContext).IsValueType)
			{
				TCloseContext tcloseContext = closeContext;
				intPtr = ((tcloseContext is string) ? IL2CPP.ManagedStringToIl2Cpp(tcloseContext as string) : IL2CPP.Il2CppObjectBaseToPtr(tcloseContext as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref closeContext;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Final_Void_TCloseContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06007539 RID: 30009 RVA: 0x00225834 File Offset: 0x00223A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291494, XrefRangeEnd = 291560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x00225868 File Offset: 0x00223A68
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnGuideMapInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x002258A4 File Offset: 0x00223AA4
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnGuideMapPanelPreOpen(TOpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TOpenContext).IsValueType)
			{
				TOpenContext topenContext = openContext;
				intPtr = ((topenContext is string) ? IL2CPP.ManagedStringToIl2Cpp(topenContext as string) : IL2CPP.Il2CppObjectBaseToPtr(topenContext as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref openContext;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapPanelPreOpen_Protected_Virtual_New_Void_TOpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600753C RID: 30012 RVA: 0x00225928 File Offset: 0x00223B28
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnGuideMapPanelPostOpen(TOpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TOpenContext).IsValueType)
			{
				TOpenContext topenContext = openContext;
				intPtr = ((topenContext is string) ? IL2CPP.ManagedStringToIl2Cpp(topenContext as string) : IL2CPP.Il2CppObjectBaseToPtr(topenContext as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref openContext;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapPanelPostOpen_Protected_Virtual_New_Void_TOpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600753D RID: 30013 RVA: 0x002259AC File Offset: 0x00223BAC
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnGuideMapPanelEndOpen(TOpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TOpenContext).IsValueType)
			{
				TOpenContext topenContext = openContext;
				intPtr = ((topenContext is string) ? IL2CPP.ManagedStringToIl2Cpp(topenContext as string) : IL2CPP.Il2CppObjectBaseToPtr(topenContext as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref openContext;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapPanelEndOpen_Protected_Virtual_New_Void_TOpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600753E RID: 30014 RVA: 0x00225A30 File Offset: 0x00223C30
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostInitializeGuideMapSpot(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_PostInitializeGuideMapSpot_Protected_Virtual_New_Void_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753F RID: 30015 RVA: 0x00225A80 File Offset: 0x00223C80
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetSpotOpenStatus(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_New_Boolean_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007540 RID: 30016 RVA: 0x00225AD8 File Offset: 0x00223CD8
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetSpotShouldShowPath(IGuideMapSpot guideMapSpot1, IGuideMapSpot guideMapSpot2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot1);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_GetSpotShouldShowPath_Protected_Virtual_New_Boolean_IGuideMapSpot_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007541 RID: 30017 RVA: 0x00225B44 File Offset: 0x00223D44
		[CallerCount(84)]
		[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<bool> IsFirstToSelectSpot(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_IsFirstToSelectSpot_Protected_Virtual_New_Nullable_1_Boolean_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Nullable<bool>(pointer);
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x00225B98 File Offset: 0x00223D98
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnGuideMapSpotSelected(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_New_Void_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007543 RID: 30019 RVA: 0x00225BE8 File Offset: 0x00223DE8
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsGuideMapSpotCanBeSelected(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_IsGuideMapSpotCanBeSelected_Protected_Virtual_New_Boolean_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007544 RID: 30020 RVA: 0x00225C40 File Offset: 0x00223E40
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnGuideMapSpotSubmit(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapSpotSubmit_Protected_Virtual_New_Void_IGuideMapSpot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007545 RID: 30021 RVA: 0x00225C90 File Offset: 0x00223E90
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnGuideMapClose(TCloseContext closeContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TCloseContext).IsValueType)
			{
				TCloseContext tcloseContext = closeContext;
				intPtr = ((tcloseContext is string) ? IL2CPP.ManagedStringToIl2Cpp(tcloseContext as string) : IL2CPP.Il2CppObjectBaseToPtr(tcloseContext as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref closeContext;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnGuideMapClose_Protected_Virtual_New_Void_TCloseContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06007546 RID: 30022 RVA: 0x00225D14 File Offset: 0x00223F14
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSecondarySwitchUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_OnSecondarySwitchUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007547 RID: 30023 RVA: 0x00225D50 File Offset: 0x00223F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291560, XrefRangeEnd = 291570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTravelCount(IGuideMapSpot from, IGuideMapSpot to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_GetTravelCount_Protected_Int32_IGuideMapSpot_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007548 RID: 30024 RVA: 0x00225DB0 File Offset: 0x00223FB0
		[CallerCount(0)]
		public unsafe IReadOnlyList<IGuideMapSpot> GetSpotList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_GetSpotList_Protected_IReadOnlyList_1_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<IGuideMapSpot>>(intPtr3) : null;
		}

		// Token: 0x06007549 RID: 30025 RVA: 0x00225DF0 File Offset: 0x00223FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291570, XrefRangeEnd = 291572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IReadOnlyDictionary<GuideMapSpot, int> GetNeighbourDistance(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_GetNeighbourDistance_Protected_IReadOnlyDictionary_2_GuideMapSpot_Int32_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<GuideMapSpot, int>>(intPtr3) : null;
		}

		// Token: 0x0600754A RID: 30026 RVA: 0x00225E40 File Offset: 0x00224040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291572, XrefRangeEnd = 291602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelectionSpots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_UpdateSelectionSpots_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600754B RID: 30027 RVA: 0x00225E74 File Offset: 0x00224074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291602, XrefRangeEnd = 291612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FocusToGuideMapSpot(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_FocusToGuideMapSpot_Private_Void_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600754C RID: 30028 RVA: 0x00225EB8 File Offset: 0x002240B8
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600754D RID: 30029 RVA: 0x00225EEC File Offset: 0x002240EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291612, XrefRangeEnd = 291632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInternal(bool immediateSnap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref immediateSnap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_UpdateInternal_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600754E RID: 30030 RVA: 0x00225F2C File Offset: 0x0022412C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291632, XrefRangeEnd = 291637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FocusToDrag(bool immediateSnap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref immediateSnap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_FocusToDrag_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x00225F6C File Offset: 0x0022416C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291637, XrefRangeEnd = 291644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FocusToSpot(bool immediateSnap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref immediateSnap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_FocusToSpot_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x00225FAC File Offset: 0x002241AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291644, XrefRangeEnd = 291646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 ClampPosition(Vector2 targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_ClampPosition_Private_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007551 RID: 30033 RVA: 0x00225FF8 File Offset: 0x002241F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291646, XrefRangeEnd = 291666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007552 RID: 30034 RVA: 0x00226034 File Offset: 0x00224234
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 291666, RefRangeEnd = 291670, XrefRangeStart = 291666, XrefRangeEnd = 291666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuideMapPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007553 RID: 30035 RVA: 0x00226070 File Offset: 0x00224270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291670, XrefRangeEnd = 291673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__33_0(InputAction.CallbackContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr__OnPanelInitialize_b__33_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007554 RID: 30036 RVA: 0x002260B8 File Offset: 0x002242B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291673, XrefRangeEnd = 291698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ToggleBackground_b__38_0(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.NativeMethodInfoPtr__ToggleBackground_b__38_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x0003F68A File Offset: 0x0003D88A
		public GuideMapPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700280F RID: 10255
		// (get) Token: 0x06007556 RID: 30038 RVA: 0x002260F8 File Offset: 0x002242F8
		// (set) Token: 0x06007557 RID: 30039 RVA: 0x0003F693 File Offset: 0x0003D893
		public unsafe GuideMapController m_GuideMapController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_GuideMapController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuideMapController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_GuideMapController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002810 RID: 10256
		// (get) Token: 0x06007558 RID: 30040 RVA: 0x00226128 File Offset: 0x00224328
		// (set) Token: 0x06007559 RID: 30041 RVA: 0x0003F6B2 File Offset: 0x0003D8B2
		public unsafe RectTransform m_Min_Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Min_Normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Min_Normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002811 RID: 10257
		// (get) Token: 0x0600755A RID: 30042 RVA: 0x00226158 File Offset: 0x00224358
		// (set) Token: 0x0600755B RID: 30043 RVA: 0x0003F6D1 File Offset: 0x0003D8D1
		public unsafe RectTransform m_Max_Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Max_Normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Max_Normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002812 RID: 10258
		// (get) Token: 0x0600755C RID: 30044 RVA: 0x00226188 File Offset: 0x00224388
		// (set) Token: 0x0600755D RID: 30045 RVA: 0x0003F6F0 File Offset: 0x0003D8F0
		public unsafe RectTransform m_Center_Normal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Center_Normal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Center_Normal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x0600755E RID: 30046 RVA: 0x002261B8 File Offset: 0x002243B8
		// (set) Token: 0x0600755F RID: 30047 RVA: 0x0003F70F File Offset: 0x0003D90F
		public unsafe RectTransform m_Min_Shrink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Min_Shrink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Min_Shrink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x06007560 RID: 30048 RVA: 0x002261E8 File Offset: 0x002243E8
		// (set) Token: 0x06007561 RID: 30049 RVA: 0x0003F72E File Offset: 0x0003D92E
		public unsafe RectTransform m_Max_Shrink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Max_Shrink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Max_Shrink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x06007562 RID: 30050 RVA: 0x00226218 File Offset: 0x00224418
		// (set) Token: 0x06007563 RID: 30051 RVA: 0x0003F74D File Offset: 0x0003D94D
		public unsafe RectTransform m_Center_Shrink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Center_Shrink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Center_Shrink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x06007564 RID: 30052 RVA: 0x00226248 File Offset: 0x00224448
		// (set) Token: 0x06007565 RID: 30053 RVA: 0x0003F76C File Offset: 0x0003D96C
		public unsafe RectTransform m_Min_Expand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Min_Expand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Min_Expand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002817 RID: 10263
		// (get) Token: 0x06007566 RID: 30054 RVA: 0x00226278 File Offset: 0x00224478
		// (set) Token: 0x06007567 RID: 30055 RVA: 0x0003F78B File Offset: 0x0003D98B
		public unsafe RectTransform m_Max_Expand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Max_Expand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Max_Expand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002818 RID: 10264
		// (get) Token: 0x06007568 RID: 30056 RVA: 0x002262A8 File Offset: 0x002244A8
		// (set) Token: 0x06007569 RID: 30057 RVA: 0x0003F7AA File Offset: 0x0003D9AA
		public unsafe RectTransform m_Center_Expand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Center_Expand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Center_Expand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002819 RID: 10265
		// (get) Token: 0x0600756A RID: 30058 RVA: 0x002262D8 File Offset: 0x002244D8
		// (set) Token: 0x0600756B RID: 30059 RVA: 0x0003F7C9 File Offset: 0x0003D9C9
		public unsafe float m_Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Duration)) = value;
			}
		}

		// Token: 0x1700281A RID: 10266
		// (get) Token: 0x0600756C RID: 30060 RVA: 0x00226300 File Offset: 0x00224500
		// (set) Token: 0x0600756D RID: 30061 RVA: 0x0003F7E4 File Offset: 0x0003D9E4
		public unsafe float m_DragDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_DragDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_DragDuration)) = value;
			}
		}

		// Token: 0x1700281B RID: 10267
		// (get) Token: 0x0600756E RID: 30062 RVA: 0x00226328 File Offset: 0x00224528
		// (set) Token: 0x0600756F RID: 30063 RVA: 0x0003F7FF File Offset: 0x0003D9FF
		public unsafe Image m_HighLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_HighLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_HighLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700281C RID: 10268
		// (get) Token: 0x06007570 RID: 30064 RVA: 0x00226358 File Offset: 0x00224558
		// (set) Token: 0x06007571 RID: 30065 RVA: 0x0003F81E File Offset: 0x0003DA1E
		public unsafe Image m_Background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x06007572 RID: 30066 RVA: 0x00226388 File Offset: 0x00224588
		// (set) Token: 0x06007573 RID: 30067 RVA: 0x0003F83D File Offset: 0x0003DA3D
		public unsafe float m_NormalSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_NormalSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_NormalSize)) = value;
			}
		}

		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x06007574 RID: 30068 RVA: 0x002263B0 File Offset: 0x002245B0
		// (set) Token: 0x06007575 RID: 30069 RVA: 0x0003F858 File Offset: 0x0003DA58
		public unsafe float m_ShrinkSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_ShrinkSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_ShrinkSize)) = value;
			}
		}

		// Token: 0x1700281F RID: 10271
		// (get) Token: 0x06007576 RID: 30070 RVA: 0x002263D8 File Offset: 0x002245D8
		// (set) Token: 0x06007577 RID: 30071 RVA: 0x0003F873 File Offset: 0x0003DA73
		public unsafe float m_ExpandSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_ExpandSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_ExpandSize)) = value;
			}
		}

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x06007578 RID: 30072 RVA: 0x00226400 File Offset: 0x00224600
		// (set) Token: 0x06007579 RID: 30073 RVA: 0x0003F88E File Offset: 0x0003DA8E
		public unsafe RectTransform m_GuideMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_GuideMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_GuideMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x0600757A RID: 30074 RVA: 0x00226430 File Offset: 0x00224630
		// (set) Token: 0x0600757B RID: 30075 RVA: 0x0003F8AD File Offset: 0x0003DAAD
		public unsafe RectTransform m_SelectedSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_SelectedSpot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_SelectedSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x0600757C RID: 30076 RVA: 0x00226460 File Offset: 0x00224660
		// (set) Token: 0x0600757D RID: 30077 RVA: 0x0003F8CC File Offset: 0x0003DACC
		public unsafe RectTransform m_FocusingSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_FocusingSpot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_FocusingSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x0600757E RID: 30078 RVA: 0x00226490 File Offset: 0x00224690
		// (set) Token: 0x0600757F RID: 30079 RVA: 0x0003F8EB File Offset: 0x0003DAEB
		public unsafe Vector2 m_CurrentVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_CurrentVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_CurrentVelocity)) = value;
			}
		}

		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x06007580 RID: 30080 RVA: 0x002264B8 File Offset: 0x002246B8
		// (set) Token: 0x06007581 RID: 30081 RVA: 0x0003F906 File Offset: 0x0003DB06
		public unsafe Vector2 m_GuideMapDragPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_GuideMapDragPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_GuideMapDragPosition)) = value;
			}
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x06007582 RID: 30082 RVA: 0x002264E0 File Offset: 0x002246E0
		// (set) Token: 0x06007583 RID: 30083 RVA: 0x0003F921 File Offset: 0x0003DB21
		public unsafe Vector2 m_GuideMapStartDragOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_GuideMapStartDragOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_GuideMapStartDragOffset)) = value;
			}
		}

		// Token: 0x17002826 RID: 10278
		// (get) Token: 0x06007584 RID: 30084 RVA: 0x00226508 File Offset: 0x00224708
		// (set) Token: 0x06007585 RID: 30085 RVA: 0x0003F93C File Offset: 0x0003DB3C
		public unsafe bool _IsFolded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr__IsFolded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr__IsFolded_k__BackingField)) = value;
			}
		}

		// Token: 0x17002827 RID: 10279
		// (get) Token: 0x06007586 RID: 30086 RVA: 0x00226530 File Offset: 0x00224730
		// (set) Token: 0x06007587 RID: 30087 RVA: 0x0003F957 File Offset: 0x0003DB57
		public unsafe RectTransform m_Min_Current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Min_Current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Min_Current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002828 RID: 10280
		// (get) Token: 0x06007588 RID: 30088 RVA: 0x00226560 File Offset: 0x00224760
		// (set) Token: 0x06007589 RID: 30089 RVA: 0x0003F976 File Offset: 0x0003DB76
		public unsafe RectTransform m_Max_Current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Max_Current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Max_Current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002829 RID: 10281
		// (get) Token: 0x0600758A RID: 30090 RVA: 0x00226590 File Offset: 0x00224790
		// (set) Token: 0x0600758B RID: 30091 RVA: 0x0003F995 File Offset: 0x0003DB95
		public unsafe RectTransform m_Center_Current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Center_Current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.NativeFieldInfoPtr_m_Center_Current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004DA2 RID: 19874
		private static readonly IntPtr NativeFieldInfoPtr_m_GuideMapController;

		// Token: 0x04004DA3 RID: 19875
		private static readonly IntPtr NativeFieldInfoPtr_m_Min_Normal;

		// Token: 0x04004DA4 RID: 19876
		private static readonly IntPtr NativeFieldInfoPtr_m_Max_Normal;

		// Token: 0x04004DA5 RID: 19877
		private static readonly IntPtr NativeFieldInfoPtr_m_Center_Normal;

		// Token: 0x04004DA6 RID: 19878
		private static readonly IntPtr NativeFieldInfoPtr_m_Min_Shrink;

		// Token: 0x04004DA7 RID: 19879
		private static readonly IntPtr NativeFieldInfoPtr_m_Max_Shrink;

		// Token: 0x04004DA8 RID: 19880
		private static readonly IntPtr NativeFieldInfoPtr_m_Center_Shrink;

		// Token: 0x04004DA9 RID: 19881
		private static readonly IntPtr NativeFieldInfoPtr_m_Min_Expand;

		// Token: 0x04004DAA RID: 19882
		private static readonly IntPtr NativeFieldInfoPtr_m_Max_Expand;

		// Token: 0x04004DAB RID: 19883
		private static readonly IntPtr NativeFieldInfoPtr_m_Center_Expand;

		// Token: 0x04004DAC RID: 19884
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;

		// Token: 0x04004DAD RID: 19885
		private static readonly IntPtr NativeFieldInfoPtr_m_DragDuration;

		// Token: 0x04004DAE RID: 19886
		private static readonly IntPtr NativeFieldInfoPtr_m_HighLight;

		// Token: 0x04004DAF RID: 19887
		private static readonly IntPtr NativeFieldInfoPtr_m_Background;

		// Token: 0x04004DB0 RID: 19888
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalSize;

		// Token: 0x04004DB1 RID: 19889
		private static readonly IntPtr NativeFieldInfoPtr_m_ShrinkSize;

		// Token: 0x04004DB2 RID: 19890
		private static readonly IntPtr NativeFieldInfoPtr_m_ExpandSize;

		// Token: 0x04004DB3 RID: 19891
		private static readonly IntPtr NativeFieldInfoPtr_m_GuideMap;

		// Token: 0x04004DB4 RID: 19892
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedSpot;

		// Token: 0x04004DB5 RID: 19893
		private static readonly IntPtr NativeFieldInfoPtr_m_FocusingSpot;

		// Token: 0x04004DB6 RID: 19894
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentVelocity;

		// Token: 0x04004DB7 RID: 19895
		private static readonly IntPtr NativeFieldInfoPtr_m_GuideMapDragPosition;

		// Token: 0x04004DB8 RID: 19896
		private static readonly IntPtr NativeFieldInfoPtr_m_GuideMapStartDragOffset;

		// Token: 0x04004DB9 RID: 19897
		private static readonly IntPtr NativeFieldInfoPtr__IsFolded_k__BackingField;

		// Token: 0x04004DBA RID: 19898
		private static readonly IntPtr NativeFieldInfoPtr_m_Min_Current;

		// Token: 0x04004DBB RID: 19899
		private static readonly IntPtr NativeFieldInfoPtr_m_Max_Current;

		// Token: 0x04004DBC RID: 19900
		private static readonly IntPtr NativeFieldInfoPtr_m_Center_Current;

		// Token: 0x04004DBD RID: 19901
		private static readonly IntPtr NativeMethodInfoPtr_get_GuideMapRectTransform_Protected_get_RectTransform_0;

		// Token: 0x04004DBE RID: 19902
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFolded_Protected_get_Boolean_0;

		// Token: 0x04004DBF RID: 19903
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFolded_Private_set_Void_Boolean_0;

		// Token: 0x04004DC0 RID: 19904
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Final_Void_0;

		// Token: 0x04004DC1 RID: 19905
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Private_Void_InputButton_Vector2_0;

		// Token: 0x04004DC2 RID: 19906
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDrag_Private_Void_InputButton_Vector2_Vector2_0;

		// Token: 0x04004DC3 RID: 19907
		private static readonly IntPtr NativeMethodInfoPtr_ToggleFolding_Protected_Void_Nullable_1_Boolean_0;

		// Token: 0x04004DC4 RID: 19908
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFolding_Private_Void_Boolean_0;

		// Token: 0x04004DC5 RID: 19909
		private static readonly IntPtr NativeMethodInfoPtr_ToggleBackground_Protected_Void_BackgroundFoldingMode_TOpenContext_TCloseContext_0;

		// Token: 0x04004DC6 RID: 19910
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Final_Void_TOpenContext_0;

		// Token: 0x04004DC7 RID: 19911
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Final_Void_TCloseContext_0;

		// Token: 0x04004DC8 RID: 19912
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Final_Void_0;

		// Token: 0x04004DC9 RID: 19913
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_New_Void_0;

		// Token: 0x04004DCA RID: 19914
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapPanelPreOpen_Protected_Virtual_New_Void_TOpenContext_0;

		// Token: 0x04004DCB RID: 19915
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapPanelPostOpen_Protected_Virtual_New_Void_TOpenContext_0;

		// Token: 0x04004DCC RID: 19916
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapPanelEndOpen_Protected_Virtual_New_Void_TOpenContext_0;

		// Token: 0x04004DCD RID: 19917
		private static readonly IntPtr NativeMethodInfoPtr_PostInitializeGuideMapSpot_Protected_Virtual_New_Void_IGuideMapSpot_0;

		// Token: 0x04004DCE RID: 19918
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_New_Boolean_IGuideMapSpot_0;

		// Token: 0x04004DCF RID: 19919
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotShouldShowPath_Protected_Virtual_New_Boolean_IGuideMapSpot_IGuideMapSpot_0;

		// Token: 0x04004DD0 RID: 19920
		private static readonly IntPtr NativeMethodInfoPtr_IsFirstToSelectSpot_Protected_Virtual_New_Nullable_1_Boolean_IGuideMapSpot_0;

		// Token: 0x04004DD1 RID: 19921
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_New_Void_IGuideMapSpot_0;

		// Token: 0x04004DD2 RID: 19922
		private static readonly IntPtr NativeMethodInfoPtr_IsGuideMapSpotCanBeSelected_Protected_Virtual_New_Boolean_IGuideMapSpot_0;

		// Token: 0x04004DD3 RID: 19923
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapSpotSubmit_Protected_Virtual_New_Void_IGuideMapSpot_0;

		// Token: 0x04004DD4 RID: 19924
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapClose_Protected_Virtual_New_Void_TCloseContext_0;

		// Token: 0x04004DD5 RID: 19925
		private static readonly IntPtr NativeMethodInfoPtr_OnSecondarySwitchUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004DD6 RID: 19926
		private static readonly IntPtr NativeMethodInfoPtr_GetTravelCount_Protected_Int32_IGuideMapSpot_IGuideMapSpot_0;

		// Token: 0x04004DD7 RID: 19927
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotList_Protected_IReadOnlyList_1_IGuideMapSpot_0;

		// Token: 0x04004DD8 RID: 19928
		private static readonly IntPtr NativeMethodInfoPtr_GetNeighbourDistance_Protected_IReadOnlyDictionary_2_GuideMapSpot_Int32_IGuideMapSpot_0;

		// Token: 0x04004DD9 RID: 19929
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionSpots_Public_Void_0;

		// Token: 0x04004DDA RID: 19930
		private static readonly IntPtr NativeMethodInfoPtr_FocusToGuideMapSpot_Private_Void_IGuideMapSpot_0;

		// Token: 0x04004DDB RID: 19931
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004DDC RID: 19932
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInternal_Private_Void_Boolean_0;

		// Token: 0x04004DDD RID: 19933
		private static readonly IntPtr NativeMethodInfoPtr_FocusToDrag_Protected_Void_Boolean_0;

		// Token: 0x04004DDE RID: 19934
		private static readonly IntPtr NativeMethodInfoPtr_FocusToSpot_Protected_Void_Boolean_0;

		// Token: 0x04004DDF RID: 19935
		private static readonly IntPtr NativeMethodInfoPtr_ClampPosition_Private_Vector2_Vector2_0;

		// Token: 0x04004DE0 RID: 19936
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004DE1 RID: 19937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04004DE2 RID: 19938
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__33_0_Private_Void_CallbackContext_0;

		// Token: 0x04004DE3 RID: 19939
		private static readonly IntPtr NativeMethodInfoPtr__ToggleBackground_b__38_0_Private_Void_Single_0;

		// Token: 0x02000F75 RID: 3957
		public enum BackgroundFoldingMode
		{
			// Token: 0x0400ADC1 RID: 44481
			Normal,
			// Token: 0x0400ADC2 RID: 44482
			Expand,
			// Token: 0x0400ADC3 RID: 44483
			Shrink
		}

		// Token: 0x02000F76 RID: 3958
		[ObfuscatedName("Common.UI.GlobalMap.GuideMapPanel`2+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x060112E6 RID: 70374 RVA: 0x003F616C File Offset: 0x003F436C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "<>c__DisplayClass33_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOpenContext>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCloseContext>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0>.NativeClassPtr);
				GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0.NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0>.NativeClassPtr, "self");
				GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
				GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0>.NativeClassPtr, 100687395);
				GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0>.NativeClassPtr, 100687396);
				GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0>.NativeClassPtr, 100687397);
			}

			// Token: 0x060112E7 RID: 70375 RVA: 0x003F6248 File Offset: 0x003F4448
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112E8 RID: 70376 RVA: 0x003F6284 File Offset: 0x003F4484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291229, XrefRangeEnd = 291230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112E9 RID: 70377 RVA: 0x003F62B8 File Offset: 0x003F44B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291230, XrefRangeEnd = 291231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112EA RID: 70378 RVA: 0x0009560C File Offset: 0x0009380C
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700594C RID: 22860
			// (get) Token: 0x060112EB RID: 70379 RVA: 0x003F62EC File Offset: 0x003F44EC
			// (set) Token: 0x060112EC RID: 70380 RVA: 0x00095615 File Offset: 0x00093815
			public unsafe IGuideMapSpot self
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0.NativeFieldInfoPtr_self);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGuideMapSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0.NativeFieldInfoPtr_self), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700594D RID: 22861
			// (get) Token: 0x060112ED RID: 70381 RVA: 0x003F631C File Offset: 0x003F451C
			// (set) Token: 0x060112EE RID: 70382 RVA: 0x00095634 File Offset: 0x00093834
			public unsafe GuideMapPanel<TOpenContext, TCloseContext> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuideMapPanel<TOpenContext, TCloseContext>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuideMapPanel<TOpenContext, TCloseContext>.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ADC4 RID: 44484
			private static readonly IntPtr NativeFieldInfoPtr_self;

			// Token: 0x0400ADC5 RID: 44485
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400ADC6 RID: 44486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ADC7 RID: 44487
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_0;

			// Token: 0x0400ADC8 RID: 44488
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_0;
		}

		// Token: 0x02000F77 RID: 3959
		[ObfuscatedName("Common.UI.GlobalMap.GuideMapPanel`2+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060112EF RID: 70383 RVA: 0x003F634C File Offset: 0x003F454C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOpenContext>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCloseContext>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c>.NativeClassPtr);
				GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c>.NativeClassPtr, "<>9");
				GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c>.NativeClassPtr, "<>9__39_0");
				GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeFieldInfoPtr___9__39_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c>.NativeClassPtr, "<>9__39_1");
				GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeFieldInfoPtr___9__39_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c>.NativeClassPtr, "<>9__39_2");
				GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c>.NativeClassPtr, 100687399);
				GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeMethodInfoPtr__OnPanelOpen_b__39_0_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c>.NativeClassPtr, 100687400);
				GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeMethodInfoPtr__OnPanelOpen_b__39_1_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c>.NativeClassPtr, 100687401);
				GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeMethodInfoPtr__OnPanelOpen_b__39_2_Internal_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c>.NativeClassPtr, 100687402);
			}

			// Token: 0x060112F0 RID: 70384 RVA: 0x003F6464 File Offset: 0x003F4664
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuideMapPanel<TOpenContext, TCloseContext>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112F1 RID: 70385 RVA: 0x003F64A0 File Offset: 0x003F46A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291231, XrefRangeEnd = 291259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__39_0(InputAction.CallbackContext _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeMethodInfoPtr__OnPanelOpen_b__39_0_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112F2 RID: 70386 RVA: 0x003F64E8 File Offset: 0x003F46E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291259, XrefRangeEnd = 291279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__39_1(InputAction.CallbackContext _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeMethodInfoPtr__OnPanelOpen_b__39_1_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060112F3 RID: 70387 RVA: 0x003F6530 File Offset: 0x003F4730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291279, XrefRangeEnd = 291291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__39_2(IGuideMapSpot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeMethodInfoPtr__OnPanelOpen_b__39_2_Internal_Boolean_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060112F4 RID: 70388 RVA: 0x00095653 File Offset: 0x00093853
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700594E RID: 22862
			// (get) Token: 0x060112F5 RID: 70389 RVA: 0x003F6580 File Offset: 0x003F4780
			// (set) Token: 0x060112F6 RID: 70390 RVA: 0x0009565C File Offset: 0x0009385C
			public unsafe static GuideMapPanel<TOpenContext, TCloseContext>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuideMapPanel<TOpenContext, TCloseContext>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700594F RID: 22863
			// (get) Token: 0x060112F7 RID: 70391 RVA: 0x003F65A8 File Offset: 0x003F47A8
			// (set) Token: 0x060112F8 RID: 70392 RVA: 0x0009566E File Offset: 0x0009386E
			public unsafe static Action<InputAction.CallbackContext> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005950 RID: 22864
			// (get) Token: 0x060112F9 RID: 70393 RVA: 0x003F65D0 File Offset: 0x003F47D0
			// (set) Token: 0x060112FA RID: 70394 RVA: 0x00095680 File Offset: 0x00093880
			public unsafe static Action<InputAction.CallbackContext> __9__39_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeFieldInfoPtr___9__39_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeFieldInfoPtr___9__39_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005951 RID: 22865
			// (get) Token: 0x060112FB RID: 70395 RVA: 0x003F65F8 File Offset: 0x003F47F8
			// (set) Token: 0x060112FC RID: 70396 RVA: 0x00095692 File Offset: 0x00093892
			public unsafe static Func<IGuideMapSpot, bool> __9__39_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeFieldInfoPtr___9__39_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGuideMapSpot, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GuideMapPanel<TOpenContext, TCloseContext>.__c.NativeFieldInfoPtr___9__39_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ADC9 RID: 44489
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400ADCA RID: 44490
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x0400ADCB RID: 44491
			private static readonly IntPtr NativeFieldInfoPtr___9__39_1;

			// Token: 0x0400ADCC RID: 44492
			private static readonly IntPtr NativeFieldInfoPtr___9__39_2;

			// Token: 0x0400ADCD RID: 44493
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ADCE RID: 44494
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__39_0_Internal_Void_CallbackContext_0;

			// Token: 0x0400ADCF RID: 44495
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__39_1_Internal_Void_CallbackContext_0;

			// Token: 0x0400ADD0 RID: 44496
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__39_2_Internal_Boolean_IGuideMapSpot_0;
		}
	}
}
