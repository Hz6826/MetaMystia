using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace DayScene.UI
{
	// Token: 0x020000D2 RID: 210
	public class DLC4_FlandreHomeDecorationEditorSubPanel : UISubPanel<DLC4_FlandreHomeDecorationEditorPanel>
	{
		// Token: 0x06001976 RID: 6518 RVA: 0x000F2D9C File Offset: 0x000F0F9C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC4_FlandreHomeDecorationEditorSubPanel()
		{
			Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DLC4_FlandreHomeDecorationEditorSubPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_CurrentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "m_CurrentPosition");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_canSetHere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "canSetHere");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_DeleteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "m_DeleteButton");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "m_ConfirmButton");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_NewlyPlaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "NewlyPlaced");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_RefreshBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "m_RefreshBuffer");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_availableGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "availableGrid");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_dragCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "dragCoroutine");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_gridDownBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "gridDownBorder");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_gridLeftBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "gridLeftBorder");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_gridRightBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "gridRightBorder");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_gridUpBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "gridUpBorder");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_FurniturePositionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "m_FurniturePositionBuffer");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_spawnedFurniture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "spawnedFurniture");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr__EndPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "<EndPosition>k__BackingField");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr__ParentRefreshType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "<ParentRefreshType>k__BackingField");
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_get_EndPosition_Public_get_Nullable_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667811);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_set_EndPosition_Private_set_Void_Nullable_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667812);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_get_ParentRefreshType_Public_get_RefreshType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667813);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_set_ParentRefreshType_Private_set_Void_RefreshType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667814);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_get_SpawnedFurnitureTransform_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667815);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_get_OpenContext_Private_get_EditorFurnitureProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667816);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667817);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667818);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667819);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_RefreshFurniturePositionBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667820);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_MoveFurniture_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667821);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_CheckBorder_Private_Boolean_MoveDirection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667822);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_TryOverridePosition_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667823);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_TryOverridePositionFunc_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667824);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_OnDragEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667825);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_TryDrag_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667826);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_TryPutDown_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667827);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_TryPutDownFunc_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667828);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_Delete_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667829);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_DeleteFunc_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667830);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_WaitForFrameEndAndClosePanel_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667831);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_CheckCanMoveToTargetPosition_Private_Boolean_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667832);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_MoveToNewPlace_Private_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667833);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667834);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667835);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667836);
			DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr__CheckCanMoveToTargetPosition_b__42_0_Private_Boolean_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, 100667837);
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x000F3128 File Offset: 0x000F1328
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x000F3160 File Offset: 0x000F1360
		public unsafe Nullable<Vector2Int> EndPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_get_EndPosition_Public_get_Nullable_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<Vector2Int>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_set_EndPosition_Private_set_Void_Nullable_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x000F31A8 File Offset: 0x000F13A8
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x000F31E4 File Offset: 0x000F13E4
		public unsafe DLC4_FlandreHomeDecorationEditorPanel.RefreshType ParentRefreshType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_get_ParentRefreshType_Public_get_RefreshType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_set_ParentRefreshType_Private_set_Void_RefreshType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x000F3224 File Offset: 0x000F1424
		public unsafe Transform SpawnedFurnitureTransform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68831, XrefRangeEnd = 68833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_get_SpawnedFurnitureTransform_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x000F3264 File Offset: 0x000F1464
		public unsafe DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty OpenContext
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 68837, RefRangeEnd = 68853, XrefRangeStart = 68833, XrefRangeEnd = 68837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_get_OpenContext_Private_get_EditorFurnitureProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty(pointer);
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x000F329C File Offset: 0x000F149C
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x000F32E4 File Offset: 0x000F14E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68853, XrefRangeEnd = 68905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x000F3320 File Offset: 0x000F1520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68905, XrefRangeEnd = 68989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x000F335C File Offset: 0x000F155C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68992, RefRangeEnd = 68993, XrefRangeStart = 68989, XrefRangeEnd = 68992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshFurniturePositionBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_RefreshFurniturePositionBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x000F3390 File Offset: 0x000F1590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68993, XrefRangeEnd = 69012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveFurniture(InputAction.CallbackContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_MoveFurniture_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x000F33D8 File Offset: 0x000F15D8
		[CallerCount(0)]
		public unsafe bool CheckBorder(MoveDirection moveDirection, int multi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref moveDirection;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multi;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_CheckBorder_Private_Boolean_MoveDirection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x000F3430 File Offset: 0x000F1630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69012, XrefRangeEnd = 69013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryOverridePosition(InputAction.CallbackContext input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(input));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_TryOverridePosition_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x000F3478 File Offset: 0x000F1678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69035, RefRangeEnd = 69036, XrefRangeStart = 69013, XrefRangeEnd = 69035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryOverridePositionFunc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_TryOverridePositionFunc_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x000F34AC File Offset: 0x000F16AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69036, XrefRangeEnd = 69039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDragEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_OnDragEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x000F34E0 File Offset: 0x000F16E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69039, XrefRangeEnd = 69044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TryDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_TryDrag_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x000F3520 File Offset: 0x000F1720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69044, XrefRangeEnd = 69045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryPutDown(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_TryPutDown_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x000F3568 File Offset: 0x000F1768
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69055, RefRangeEnd = 69057, XrefRangeStart = 69045, XrefRangeEnd = 69055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryPutDownFunc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_TryPutDownFunc_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x000F359C File Offset: 0x000F179C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69057, XrefRangeEnd = 69064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_Delete_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x000F35E4 File Offset: 0x000F17E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteFunc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_DeleteFunc_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x000F3618 File Offset: 0x000F1818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69064, XrefRangeEnd = 69076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForFrameEndAndClosePanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_WaitForFrameEndAndClosePanel_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x000F3658 File Offset: 0x000F1858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69089, RefRangeEnd = 69091, XrefRangeStart = 69076, XrefRangeEnd = 69089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckCanMoveToTargetPosition(Vector2Int finalPointPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref finalPointPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_CheckCanMoveToTargetPosition_Private_Boolean_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x000F36A4 File Offset: 0x000F18A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69113, RefRangeEnd = 69115, XrefRangeStart = 69091, XrefRangeEnd = 69113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToNewPlace(Vector2Int newPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_MoveToNewPlace_Private_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x000F36E4 File Offset: 0x000F18E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69115, XrefRangeEnd = 69142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x000F3720 File Offset: 0x000F1920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69142, XrefRangeEnd = 69152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x000F375C File Offset: 0x000F195C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69152, XrefRangeEnd = 69163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC4_FlandreHomeDecorationEditorSubPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x000F3798 File Offset: 0x000F1998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69163, XrefRangeEnd = 69167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CheckCanMoveToTargetPosition_b__42_0(Vector2Int t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.NativeMethodInfoPtr__CheckCanMoveToTargetPosition_b__42_0_Private_Boolean_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x0000FE21 File Offset: 0x0000E021
		public DLC4_FlandreHomeDecorationEditorSubPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x000F37E4 File Offset: 0x000F19E4
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x0000FE2A File Offset: 0x0000E02A
		public unsafe Vector2Int m_CurrentPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_CurrentPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_CurrentPosition)) = value;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x000F380C File Offset: 0x000F1A0C
		// (set) Token: 0x06001996 RID: 6550 RVA: 0x0000FE45 File Offset: 0x0000E045
		public unsafe bool canSetHere
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_canSetHere);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_canSetHere)) = value;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x000F3834 File Offset: 0x000F1A34
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x0000FE60 File Offset: 0x0000E060
		public unsafe UIButtonSimple m_DeleteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_DeleteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_DeleteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x000F3864 File Offset: 0x000F1A64
		// (set) Token: 0x0600199A RID: 6554 RVA: 0x0000FE7F File Offset: 0x0000E07F
		public unsafe UIButtonSimple m_ConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_ConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x000F3894 File Offset: 0x000F1A94
		// (set) Token: 0x0600199C RID: 6556 RVA: 0x0000FE9E File Offset: 0x0000E09E
		public unsafe bool NewlyPlaced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_NewlyPlaced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_NewlyPlaced)) = value;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x000F38BC File Offset: 0x000F1ABC
		// (set) Token: 0x0600199E RID: 6558 RVA: 0x0000FEB9 File Offset: 0x0000E0B9
		public unsafe HashSet<Vector2Int> m_RefreshBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_RefreshBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_RefreshBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x000F38EC File Offset: 0x000F1AEC
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x0000FED8 File Offset: 0x0000E0D8
		public unsafe HashSet<Vector2Int> availableGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_availableGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_availableGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x000F391C File Offset: 0x000F1B1C
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x0000FEF7 File Offset: 0x0000E0F7
		public unsafe Coroutine dragCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_dragCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_dragCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x000F394C File Offset: 0x000F1B4C
		// (set) Token: 0x060019A4 RID: 6564 RVA: 0x0000FF16 File Offset: 0x0000E116
		public unsafe int gridDownBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_gridDownBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_gridDownBorder)) = value;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x000F3974 File Offset: 0x000F1B74
		// (set) Token: 0x060019A6 RID: 6566 RVA: 0x0000FF31 File Offset: 0x0000E131
		public unsafe int gridLeftBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_gridLeftBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_gridLeftBorder)) = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x000F399C File Offset: 0x000F1B9C
		// (set) Token: 0x060019A8 RID: 6568 RVA: 0x0000FF4C File Offset: 0x0000E14C
		public unsafe int gridRightBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_gridRightBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_gridRightBorder)) = value;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x000F39C4 File Offset: 0x000F1BC4
		// (set) Token: 0x060019AA RID: 6570 RVA: 0x0000FF67 File Offset: 0x0000E167
		public unsafe int gridUpBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_gridUpBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_gridUpBorder)) = value;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x000F39EC File Offset: 0x000F1BEC
		// (set) Token: 0x060019AC RID: 6572 RVA: 0x0000FF82 File Offset: 0x0000E182
		public unsafe Il2CppStructArray<Vector2Int> m_FurniturePositionBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_FurniturePositionBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_m_FurniturePositionBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x000F3A1C File Offset: 0x000F1C1C
		// (set) Token: 0x060019AE RID: 6574 RVA: 0x0000FFA1 File Offset: 0x0000E1A1
		public unsafe FlandreFurnitureComponent spawnedFurniture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_spawnedFurniture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlandreFurnitureComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr_spawnedFurniture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060019AF RID: 6575 RVA: 0x000F3A4C File Offset: 0x000F1C4C
		// (set) Token: 0x060019B0 RID: 6576 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		public Nullable<Vector2Int> _EndPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr__EndPosition_k__BackingField);
				return new Nullable<Vector2Int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector2Int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr__EndPosition_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector2Int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x000F3A7C File Offset: 0x000F1C7C
		// (set) Token: 0x060019B2 RID: 6578 RVA: 0x0000FFEE File Offset: 0x0000E1EE
		public unsafe DLC4_FlandreHomeDecorationEditorPanel.RefreshType _ParentRefreshType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr__ParentRefreshType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel.NativeFieldInfoPtr__ParentRefreshType_k__BackingField)) = value;
			}
		}

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPosition;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeFieldInfoPtr_canSetHere;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeFieldInfoPtr_m_DeleteButton;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeFieldInfoPtr_m_ConfirmButton;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeFieldInfoPtr_NewlyPlaced;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshBuffer;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeFieldInfoPtr_availableGrid;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeFieldInfoPtr_dragCoroutine;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeFieldInfoPtr_gridDownBorder;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeFieldInfoPtr_gridLeftBorder;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeFieldInfoPtr_gridRightBorder;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeFieldInfoPtr_gridUpBorder;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeFieldInfoPtr_m_FurniturePositionBuffer;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeFieldInfoPtr_spawnedFurniture;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeFieldInfoPtr__EndPosition_k__BackingField;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeFieldInfoPtr__ParentRefreshType_k__BackingField;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_get_EndPosition_Public_get_Nullable_1_Vector2Int_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_set_EndPosition_Private_set_Void_Nullable_1_Vector2Int_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentRefreshType_Public_get_RefreshType_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentRefreshType_Private_set_Void_RefreshType_0;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr_get_SpawnedFurnitureTransform_Private_get_Transform_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_EditorFurnitureProperty_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_RefreshFurniturePositionBuffer_Private_Void_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_MoveFurniture_Private_Void_CallbackContext_0;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_CheckBorder_Private_Boolean_MoveDirection_Int32_0;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeMethodInfoPtr_TryOverridePosition_Private_Void_CallbackContext_0;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr_TryOverridePositionFunc_Private_Void_0;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr_OnDragEnd_Private_Void_0;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_TryDrag_Private_IEnumerator_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_TryPutDown_Private_Void_CallbackContext_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_TryPutDownFunc_Private_Void_0;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Private_Void_CallbackContext_0;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFunc_Private_Void_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_WaitForFrameEndAndClosePanel_Private_IEnumerator_0;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanMoveToTargetPosition_Private_Boolean_Vector2Int_0;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNewPlace_Private_Void_Vector2Int_0;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeMethodInfoPtr__CheckCanMoveToTargetPosition_b__42_0_Private_Boolean_Vector2Int_0;

		// Token: 0x02000686 RID: 1670
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationEditorSubPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009628 RID: 38440 RVA: 0x002852D8 File Offset: 0x002834D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel.__c>.NativeClassPtr);
				DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel.__c>.NativeClassPtr, "<>9");
				DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel.__c>.NativeClassPtr, "<>9__29_0");
				DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9__29_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel.__c>.NativeClassPtr, "<>9__29_1");
				DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9__29_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel.__c>.NativeClassPtr, "<>9__29_2");
				DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9__29_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel.__c>.NativeClassPtr, "<>9__29_3");
				DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel.__c>.NativeClassPtr, 100667839);
				DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_0_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel.__c>.NativeClassPtr, 100667840);
				DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_1_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel.__c>.NativeClassPtr, 100667841);
				DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_2_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel.__c>.NativeClassPtr, 100667842);
				DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_3_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel.__c>.NativeClassPtr, 100667843);
			}

			// Token: 0x06009629 RID: 38441 RVA: 0x002853CC File Offset: 0x002835CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600962A RID: 38442 RVA: 0x00285408 File Offset: 0x00283608
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2790, RefRangeEnd = 2793, XrefRangeStart = 2790, XrefRangeEnd = 2793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpen_b__29_0(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_0_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600962B RID: 38443 RVA: 0x00285454 File Offset: 0x00283654
			[CallerCount(0)]
			public unsafe int _OnPanelOpen_b__29_1(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_1_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600962C RID: 38444 RVA: 0x002854A0 File Offset: 0x002836A0
			[CallerCount(0)]
			public unsafe int _OnPanelOpen_b__29_2(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_2_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600962D RID: 38445 RVA: 0x002854EC File Offset: 0x002836EC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2790, RefRangeEnd = 2793, XrefRangeStart = 2790, XrefRangeEnd = 2793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPanelOpen_b__29_3(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeMethodInfoPtr__OnPanelOpen_b__29_3_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600962E RID: 38446 RVA: 0x00051355 File Offset: 0x0004F555
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031E1 RID: 12769
			// (get) Token: 0x0600962F RID: 38447 RVA: 0x00285538 File Offset: 0x00283738
			// (set) Token: 0x06009630 RID: 38448 RVA: 0x0005135E File Offset: 0x0004F55E
			public unsafe static DLC4_FlandreHomeDecorationEditorSubPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorSubPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031E2 RID: 12770
			// (get) Token: 0x06009631 RID: 38449 RVA: 0x00285560 File Offset: 0x00283760
			// (set) Token: 0x06009632 RID: 38450 RVA: 0x00051370 File Offset: 0x0004F570
			public unsafe static Func<Vector2Int, int> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031E3 RID: 12771
			// (get) Token: 0x06009633 RID: 38451 RVA: 0x00285588 File Offset: 0x00283788
			// (set) Token: 0x06009634 RID: 38452 RVA: 0x00051382 File Offset: 0x0004F582
			public unsafe static Func<Vector2Int, int> __9__29_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9__29_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9__29_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031E4 RID: 12772
			// (get) Token: 0x06009635 RID: 38453 RVA: 0x002855B0 File Offset: 0x002837B0
			// (set) Token: 0x06009636 RID: 38454 RVA: 0x00051394 File Offset: 0x0004F594
			public unsafe static Func<Vector2Int, int> __9__29_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9__29_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9__29_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031E5 RID: 12773
			// (get) Token: 0x06009637 RID: 38455 RVA: 0x002855D8 File Offset: 0x002837D8
			// (set) Token: 0x06009638 RID: 38456 RVA: 0x000513A6 File Offset: 0x0004F5A6
			public unsafe static Func<Vector2Int, int> __9__29_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9__29_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC4_FlandreHomeDecorationEditorSubPanel.__c.NativeFieldInfoPtr___9__29_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006162 RID: 24930
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006163 RID: 24931
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x04006164 RID: 24932
			private static readonly IntPtr NativeFieldInfoPtr___9__29_1;

			// Token: 0x04006165 RID: 24933
			private static readonly IntPtr NativeFieldInfoPtr___9__29_2;

			// Token: 0x04006166 RID: 24934
			private static readonly IntPtr NativeFieldInfoPtr___9__29_3;

			// Token: 0x04006167 RID: 24935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006168 RID: 24936
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_0_Internal_Int32_Vector2Int_0;

			// Token: 0x04006169 RID: 24937
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_1_Internal_Int32_Vector2Int_0;

			// Token: 0x0400616A RID: 24938
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_2_Internal_Int32_Vector2Int_0;

			// Token: 0x0400616B RID: 24939
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__29_3_Internal_Int32_Vector2Int_0;
		}

		// Token: 0x02000687 RID: 1671
		[ObfuscatedName("DayScene.UI.DLC4_FlandreHomeDecorationEditorSubPanel+<TryDrag>d__36")]
		public sealed class _TryDrag_d__36 : Il2CppSystem.Object
		{
			// Token: 0x06009639 RID: 38457 RVA: 0x00285600 File Offset: 0x00283800
			// Note: this type is marked as 'beforefieldinit'.
			static _TryDrag_d__36()
			{
				Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel>.NativeClassPtr, "<TryDrag>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36>.NativeClassPtr);
				DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36>.NativeClassPtr, "<>1__state");
				DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36>.NativeClassPtr, "<>2__current");
				DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36>.NativeClassPtr, "<>4__this");
				DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeFieldInfoPtr__lastPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36>.NativeClassPtr, "<lastPosition>5__2");
				DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36>.NativeClassPtr, 100667844);
				DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36>.NativeClassPtr, 100667845);
				DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36>.NativeClassPtr, 100667846);
				DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36>.NativeClassPtr, 100667847);
				DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36>.NativeClassPtr, 100667848);
				DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36>.NativeClassPtr, 100667849);
			}

			// Token: 0x0600963A RID: 38458 RVA: 0x002856F4 File Offset: 0x002838F4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TryDrag_d__36(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600963B RID: 38459 RVA: 0x0028573C File Offset: 0x0028393C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600963C RID: 38460 RVA: 0x00285770 File Offset: 0x00283970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68823, XrefRangeEnd = 68825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170031EA RID: 12778
			// (get) Token: 0x0600963D RID: 38461 RVA: 0x002857AC File Offset: 0x002839AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600963E RID: 38462 RVA: 0x002857EC File Offset: 0x002839EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68825, XrefRangeEnd = 68831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170031EB RID: 12779
			// (get) Token: 0x0600963F RID: 38463 RVA: 0x00285820 File Offset: 0x00283A20
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009640 RID: 38464 RVA: 0x000513B8 File Offset: 0x0004F5B8
			public _TryDrag_d__36(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031E6 RID: 12774
			// (get) Token: 0x06009641 RID: 38465 RVA: 0x00285860 File Offset: 0x00283A60
			// (set) Token: 0x06009642 RID: 38466 RVA: 0x000513C1 File Offset: 0x0004F5C1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170031E7 RID: 12775
			// (get) Token: 0x06009643 RID: 38467 RVA: 0x00285888 File Offset: 0x00283A88
			// (set) Token: 0x06009644 RID: 38468 RVA: 0x000513DC File Offset: 0x0004F5DC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031E8 RID: 12776
			// (get) Token: 0x06009645 RID: 38469 RVA: 0x002858B8 File Offset: 0x00283AB8
			// (set) Token: 0x06009646 RID: 38470 RVA: 0x000513FB File Offset: 0x0004F5FB
			public unsafe DLC4_FlandreHomeDecorationEditorSubPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC4_FlandreHomeDecorationEditorSubPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031E9 RID: 12777
			// (get) Token: 0x06009647 RID: 38471 RVA: 0x002858E8 File Offset: 0x00283AE8
			// (set) Token: 0x06009648 RID: 38472 RVA: 0x0005141A File Offset: 0x0004F61A
			public unsafe Vector2Int _lastPosition_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeFieldInfoPtr__lastPosition_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC4_FlandreHomeDecorationEditorSubPanel._TryDrag_d__36.NativeFieldInfoPtr__lastPosition_5__2)) = value;
				}
			}

			// Token: 0x0400616C RID: 24940
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400616D RID: 24941
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400616E RID: 24942
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400616F RID: 24943
			private static readonly IntPtr NativeFieldInfoPtr__lastPosition_5__2;

			// Token: 0x04006170 RID: 24944
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006171 RID: 24945
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006172 RID: 24946
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006173 RID: 24947
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006174 RID: 24948
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006175 RID: 24949
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
