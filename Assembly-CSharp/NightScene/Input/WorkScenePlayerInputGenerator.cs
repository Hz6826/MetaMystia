using System;
using Common.CharacterUtility;
using DEYU.AdpUISystem.Managers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.UI;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

namespace NightScene.Input
{
	// Token: 0x020001A0 RID: 416
	public class WorkScenePlayerInputGenerator : CharacterControllerInputGeneratorComponent
	{
		// Token: 0x06002D6F RID: 11631 RVA: 0x00135A8C File Offset: 0x00133C8C
		// Note: this type is marked as 'beforefieldinit'.
		static WorkScenePlayerInputGenerator()
		{
			Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.Input", "WorkScenePlayerInputGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr);
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_m_RegisteredBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "m_RegisteredBinding");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_m_RegisteredPanelWiseBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "m_RegisteredPanelWiseBinding");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunEndsActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "stunEndsActions");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunOnlyOnTimeEndsActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "stunOnlyOnTimeEndsActions");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_faceDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "faceDirection");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_focusedTileCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "focusedTileCoordinate");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_internalAvailability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "internalAvailability");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_isCrazy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "isCrazy");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_isReversed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "isReversed");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_isStuned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "isStuned");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_lastFocusedTileCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "lastFocusedTileCoordinate");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_m_SustainedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "m_SustainedPanel");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_onStun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "onStun");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_onWillExecuteInteractAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "onWillExecuteInteractAction");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_onWillExecuteInteractActionProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "onWillExecuteInteractActionProcess");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_prohibitMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "prohibitMovement");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_referenceGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "referenceGrid");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "stunIncrement");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "stunMin");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "stunMultiplier");
			WorkScenePlayerInputGenerator.NativeFieldInfoPtr__StunSeconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "<StunSeconds>k__BackingField");
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_get_GridPosition_Private_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671272);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_get_IsStuned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671273);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_get_ProhibitMovement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671274);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_get_StunSeconds_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671275);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_set_StunSeconds_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671276);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671277);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_RegisterBinding_Private_Void_String_InputActionPhase_Action_1_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671278);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_RegisterPanelWiseBinding_Private_Void_String_InputActionPhase_Action_1_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671279);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Initialize_Public_Void_Tilemap_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671280);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_SetPlayerCharacterToDefaultSpawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671281);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_ReadInput_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671282);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Interact_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671283);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_CancelInput_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671284);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_UpdateInputAvaility_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671285);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671286);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_TryCancelExecution_Private_Void_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671287);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_UpdateCurrentFocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671288);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_RefreshCurrentFocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671289);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_ExecuteThrowDeliver_Public_IEnumerator_Sprite_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671290);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Reverse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671291);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_EndReverse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671292);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Crazy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671293);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_EndCrazy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671294);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Stun_Public_Void_Int32_Action_Action_1_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671295);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_EndStunExtern_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671296);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_OnStunLoop_Private_IEnumerator_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671297);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_OnStunEnds_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671298);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_OnExternalStop_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671299);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_ForbidMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671300);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_RecoverMovement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671301);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671302);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671303);
			WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, 100671304);
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x00135EF4 File Offset: 0x001340F4
		public unsafe Vector3Int GridPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102352, XrefRangeEnd = 102355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_get_GridPosition_Private_get_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x00135F30 File Offset: 0x00134130
		public unsafe bool IsStuned
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 102355, RefRangeEnd = 102356, XrefRangeStart = 102355, XrefRangeEnd = 102355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_get_IsStuned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06002D72 RID: 11634 RVA: 0x00135F6C File Offset: 0x0013416C
		public unsafe bool ProhibitMovement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_get_ProhibitMovement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06002D73 RID: 11635 RVA: 0x00135FA8 File Offset: 0x001341A8
		// (set) Token: 0x06002D74 RID: 11636 RVA: 0x00135FE4 File Offset: 0x001341E4
		public unsafe float StunSeconds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_get_StunSeconds_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_set_StunSeconds_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00136024 File Offset: 0x00134224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102356, XrefRangeEnd = 102357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x00136058 File Offset: 0x00134258
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 102370, RefRangeEnd = 102376, XrefRangeStart = 102357, XrefRangeEnd = 102370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterBinding(string bindingName, InputActionPhase phase, Action<InputAction.CallbackContext> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(bindingName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_RegisterBinding_Private_Void_String_InputActionPhase_Action_1_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x001360BC File Offset: 0x001342BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 102389, RefRangeEnd = 102393, XrefRangeStart = 102376, XrefRangeEnd = 102389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterPanelWiseBinding(string bindingName, InputActionPhase phase, Action<InputAction.CallbackContext> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(bindingName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_RegisterPanelWiseBinding_Private_Void_String_InputActionPhase_Action_1_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x00136120 File Offset: 0x00134320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102553, RefRangeEnd = 102554, XrefRangeStart = 102393, XrefRangeEnd = 102553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Tilemap heightMap, float stunIncrement, float stunMin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(heightMap);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stunIncrement;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stunMin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Initialize_Public_Void_Tilemap_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00136180 File Offset: 0x00134380
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102560, RefRangeEnd = 102561, XrefRangeStart = 102554, XrefRangeEnd = 102560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerCharacterToDefaultSpawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_SetPlayerCharacterToDefaultSpawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x001361B4 File Offset: 0x001343B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102561, XrefRangeEnd = 102594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadInput(InputAction.CallbackContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_ReadInput_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x001361FC File Offset: 0x001343FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102594, XrefRangeEnd = 102609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interact(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Interact_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x00136244 File Offset: 0x00134444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102609, XrefRangeEnd = 102624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelInput(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_CancelInput_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x0013628C File Offset: 0x0013448C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102624, XrefRangeEnd = 102628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputAvaility(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_UpdateInputAvaility_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x001362CC File Offset: 0x001344CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102628, XrefRangeEnd = 102667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x00136300 File Offset: 0x00134500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102667, XrefRangeEnd = 102682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryCancelExecution(AdpUIPanelManager.RequestedInputMode requestedInputMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestedInputMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_TryCancelExecution_Private_Void_RequestedInputMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x00136340 File Offset: 0x00134540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102808, RefRangeEnd = 102809, XrefRangeStart = 102682, XrefRangeEnd = 102808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_UpdateCurrentFocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00136374 File Offset: 0x00134574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102813, RefRangeEnd = 102814, XrefRangeStart = 102809, XrefRangeEnd = 102813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCurrentFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_RefreshCurrentFocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x001363A8 File Offset: 0x001345A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102820, RefRangeEnd = 102822, XrefRangeStart = 102814, XrefRangeEnd = 102820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExecuteThrowDeliver(Sprite sprite, Vector3 target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_ExecuteThrowDeliver_Public_IEnumerator_Sprite_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x00136408 File Offset: 0x00134608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102822, RefRangeEnd = 102824, XrefRangeStart = 102822, XrefRangeEnd = 102822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Reverse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x0013643C File Offset: 0x0013463C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102824, RefRangeEnd = 102826, XrefRangeStart = 102824, XrefRangeEnd = 102824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndReverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_EndReverse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00136470 File Offset: 0x00134670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102826, RefRangeEnd = 102827, XrefRangeStart = 102826, XrefRangeEnd = 102826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Crazy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Crazy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x001364A4 File Offset: 0x001346A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102827, RefRangeEnd = 102828, XrefRangeStart = 102827, XrefRangeEnd = 102827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndCrazy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_EndCrazy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x001364D8 File Offset: 0x001346D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102856, RefRangeEnd = 102858, XrefRangeStart = 102828, XrefRangeEnd = 102856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stun(int durationSec, Action actionEndCallBack, Action<float> actionUpdateCallBack, Action actionOnlyOnTimeEndCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref durationSec;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionEndCallBack);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionUpdateCallBack);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionOnlyOnTimeEndCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Stun_Public_Void_Int32_Action_Action_1_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00136550 File Offset: 0x00134750
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 102866, RefRangeEnd = 102870, XrefRangeStart = 102858, XrefRangeEnd = 102866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndStunExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_EndStunExtern_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00136584 File Offset: 0x00134784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102870, XrefRangeEnd = 102876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnStunLoop(Action<float> actionUpdateCallBack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionUpdateCallBack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_OnStunLoop_Private_IEnumerator_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x001365D4 File Offset: 0x001347D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102910, RefRangeEnd = 102912, XrefRangeStart = 102876, XrefRangeEnd = 102910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStunEnds(bool endDuetoTimeOut = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endDuetoTimeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_OnStunEnds_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x00136614 File Offset: 0x00134814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExternalStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkScenePlayerInputGenerator.NativeMethodInfoPtr_OnExternalStop_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x00136650 File Offset: 0x00134850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102913, RefRangeEnd = 102914, XrefRangeStart = 102912, XrefRangeEnd = 102913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForbidMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_ForbidMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x00136684 File Offset: 0x00134884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102914, RefRangeEnd = 102915, XrefRangeStart = 102914, XrefRangeEnd = 102914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecoverMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_RecoverMovement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x001366B8 File Offset: 0x001348B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102915, XrefRangeEnd = 102924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x001366F4 File Offset: 0x001348F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102924, XrefRangeEnd = 102950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkScenePlayerInputGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x00136730 File Offset: 0x00134930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102950, XrefRangeEnd = 102955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x0001A48C File Offset: 0x0001868C
		public WorkScenePlayerInputGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x00136770 File Offset: 0x00134970
		// (set) Token: 0x06002D93 RID: 11667 RVA: 0x0001A495 File Offset: 0x00018695
		public unsafe Stack<ValueTuple<string, InputActionPhase, Action<InputAction.CallbackContext>>> m_RegisteredBinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_m_RegisteredBinding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ValueTuple<string, InputActionPhase, Action<InputAction.CallbackContext>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_m_RegisteredBinding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x001367A0 File Offset: 0x001349A0
		// (set) Token: 0x06002D95 RID: 11669 RVA: 0x0001A4B4 File Offset: 0x000186B4
		public unsafe Stack<ValueTuple<string, InputActionPhase, Action<InputAction.CallbackContext>>> m_RegisteredPanelWiseBinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_m_RegisteredPanelWiseBinding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ValueTuple<string, InputActionPhase, Action<InputAction.CallbackContext>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_m_RegisteredPanelWiseBinding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x001367D0 File Offset: 0x001349D0
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x0001A4D3 File Offset: 0x000186D3
		public unsafe List<Action> stunEndsActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunEndsActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunEndsActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x00136800 File Offset: 0x00134A00
		// (set) Token: 0x06002D99 RID: 11673 RVA: 0x0001A4F2 File Offset: 0x000186F2
		public unsafe List<Action> stunOnlyOnTimeEndsActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunOnlyOnTimeEndsActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunOnlyOnTimeEndsActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x00136830 File Offset: 0x00134A30
		// (set) Token: 0x06002D9B RID: 11675 RVA: 0x0001A511 File Offset: 0x00018711
		public unsafe Vector3Int faceDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_faceDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_faceDirection)) = value;
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06002D9C RID: 11676 RVA: 0x00136858 File Offset: 0x00134A58
		// (set) Token: 0x06002D9D RID: 11677 RVA: 0x0001A52C File Offset: 0x0001872C
		public Nullable<Vector3Int> focusedTileCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_focusedTileCoordinate);
				return new Nullable<Vector3Int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector3Int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_focusedTileCoordinate), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector3Int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06002D9E RID: 11678 RVA: 0x00136888 File Offset: 0x00134A88
		// (set) Token: 0x06002D9F RID: 11679 RVA: 0x0001A55A File Offset: 0x0001875A
		public unsafe bool internalAvailability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_internalAvailability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_internalAvailability)) = value;
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x001368B0 File Offset: 0x00134AB0
		// (set) Token: 0x06002DA1 RID: 11681 RVA: 0x0001A575 File Offset: 0x00018775
		public unsafe bool isCrazy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_isCrazy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_isCrazy)) = value;
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x001368D8 File Offset: 0x00134AD8
		// (set) Token: 0x06002DA3 RID: 11683 RVA: 0x0001A590 File Offset: 0x00018790
		public unsafe bool isReversed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_isReversed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_isReversed)) = value;
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06002DA4 RID: 11684 RVA: 0x00136900 File Offset: 0x00134B00
		// (set) Token: 0x06002DA5 RID: 11685 RVA: 0x0001A5AB File Offset: 0x000187AB
		public unsafe int isStuned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_isStuned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_isStuned)) = value;
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06002DA6 RID: 11686 RVA: 0x00136928 File Offset: 0x00134B28
		// (set) Token: 0x06002DA7 RID: 11687 RVA: 0x0001A5C6 File Offset: 0x000187C6
		public Nullable<Vector3Int> lastFocusedTileCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_lastFocusedTileCoordinate);
				return new Nullable<Vector3Int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector3Int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_lastFocusedTileCoordinate), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector3Int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x00136958 File Offset: 0x00134B58
		// (set) Token: 0x06002DA9 RID: 11689 RVA: 0x0001A5F4 File Offset: 0x000187F4
		public unsafe WorkSceneSustainedPannel m_SustainedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_m_SustainedPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneSustainedPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_m_SustainedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x00136988 File Offset: 0x00134B88
		// (set) Token: 0x06002DAB RID: 11691 RVA: 0x0001A613 File Offset: 0x00018813
		public unsafe Coroutine onStun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_onStun);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_onStun), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06002DAC RID: 11692 RVA: 0x001369B8 File Offset: 0x00134BB8
		// (set) Token: 0x06002DAD RID: 11693 RVA: 0x0001A632 File Offset: 0x00018832
		public unsafe bool onWillExecuteInteractAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_onWillExecuteInteractAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_onWillExecuteInteractAction)) = value;
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06002DAE RID: 11694 RVA: 0x001369E0 File Offset: 0x00134BE0
		// (set) Token: 0x06002DAF RID: 11695 RVA: 0x0001A64D File Offset: 0x0001884D
		public unsafe Coroutine onWillExecuteInteractActionProcess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_onWillExecuteInteractActionProcess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_onWillExecuteInteractActionProcess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06002DB0 RID: 11696 RVA: 0x00136A10 File Offset: 0x00134C10
		// (set) Token: 0x06002DB1 RID: 11697 RVA: 0x0001A66C File Offset: 0x0001886C
		public unsafe int prohibitMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_prohibitMovement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_prohibitMovement)) = value;
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x00136A38 File Offset: 0x00134C38
		// (set) Token: 0x06002DB3 RID: 11699 RVA: 0x0001A687 File Offset: 0x00018887
		public unsafe Grid referenceGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_referenceGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_referenceGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x00136A68 File Offset: 0x00134C68
		// (set) Token: 0x06002DB5 RID: 11701 RVA: 0x0001A6A6 File Offset: 0x000188A6
		public unsafe float stunIncrement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunIncrement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunIncrement)) = value;
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06002DB6 RID: 11702 RVA: 0x00136A90 File Offset: 0x00134C90
		// (set) Token: 0x06002DB7 RID: 11703 RVA: 0x0001A6C1 File Offset: 0x000188C1
		public unsafe float stunMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunMin)) = value;
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06002DB8 RID: 11704 RVA: 0x00136AB8 File Offset: 0x00134CB8
		// (set) Token: 0x06002DB9 RID: 11705 RVA: 0x0001A6DC File Offset: 0x000188DC
		public unsafe float stunMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr_stunMultiplier)) = value;
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06002DBA RID: 11706 RVA: 0x00136AE0 File Offset: 0x00134CE0
		// (set) Token: 0x06002DBB RID: 11707 RVA: 0x0001A6F7 File Offset: 0x000188F7
		public unsafe float _StunSeconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr__StunSeconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.NativeFieldInfoPtr__StunSeconds_k__BackingField)) = value;
			}
		}

		// Token: 0x04001E26 RID: 7718
		private static readonly IntPtr NativeFieldInfoPtr_m_RegisteredBinding;

		// Token: 0x04001E27 RID: 7719
		private static readonly IntPtr NativeFieldInfoPtr_m_RegisteredPanelWiseBinding;

		// Token: 0x04001E28 RID: 7720
		private static readonly IntPtr NativeFieldInfoPtr_stunEndsActions;

		// Token: 0x04001E29 RID: 7721
		private static readonly IntPtr NativeFieldInfoPtr_stunOnlyOnTimeEndsActions;

		// Token: 0x04001E2A RID: 7722
		private static readonly IntPtr NativeFieldInfoPtr_faceDirection;

		// Token: 0x04001E2B RID: 7723
		private static readonly IntPtr NativeFieldInfoPtr_focusedTileCoordinate;

		// Token: 0x04001E2C RID: 7724
		private static readonly IntPtr NativeFieldInfoPtr_internalAvailability;

		// Token: 0x04001E2D RID: 7725
		private static readonly IntPtr NativeFieldInfoPtr_isCrazy;

		// Token: 0x04001E2E RID: 7726
		private static readonly IntPtr NativeFieldInfoPtr_isReversed;

		// Token: 0x04001E2F RID: 7727
		private static readonly IntPtr NativeFieldInfoPtr_isStuned;

		// Token: 0x04001E30 RID: 7728
		private static readonly IntPtr NativeFieldInfoPtr_lastFocusedTileCoordinate;

		// Token: 0x04001E31 RID: 7729
		private static readonly IntPtr NativeFieldInfoPtr_m_SustainedPanel;

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeFieldInfoPtr_onStun;

		// Token: 0x04001E33 RID: 7731
		private static readonly IntPtr NativeFieldInfoPtr_onWillExecuteInteractAction;

		// Token: 0x04001E34 RID: 7732
		private static readonly IntPtr NativeFieldInfoPtr_onWillExecuteInteractActionProcess;

		// Token: 0x04001E35 RID: 7733
		private static readonly IntPtr NativeFieldInfoPtr_prohibitMovement;

		// Token: 0x04001E36 RID: 7734
		private static readonly IntPtr NativeFieldInfoPtr_referenceGrid;

		// Token: 0x04001E37 RID: 7735
		private static readonly IntPtr NativeFieldInfoPtr_stunIncrement;

		// Token: 0x04001E38 RID: 7736
		private static readonly IntPtr NativeFieldInfoPtr_stunMin;

		// Token: 0x04001E39 RID: 7737
		private static readonly IntPtr NativeFieldInfoPtr_stunMultiplier;

		// Token: 0x04001E3A RID: 7738
		private static readonly IntPtr NativeFieldInfoPtr__StunSeconds_k__BackingField;

		// Token: 0x04001E3B RID: 7739
		private static readonly IntPtr NativeMethodInfoPtr_get_GridPosition_Private_get_Vector3Int_0;

		// Token: 0x04001E3C RID: 7740
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStuned_Public_get_Boolean_0;

		// Token: 0x04001E3D RID: 7741
		private static readonly IntPtr NativeMethodInfoPtr_get_ProhibitMovement_Public_get_Boolean_0;

		// Token: 0x04001E3E RID: 7742
		private static readonly IntPtr NativeMethodInfoPtr_get_StunSeconds_Public_get_Single_0;

		// Token: 0x04001E3F RID: 7743
		private static readonly IntPtr NativeMethodInfoPtr_set_StunSeconds_Private_set_Void_Single_0;

		// Token: 0x04001E40 RID: 7744
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04001E41 RID: 7745
		private static readonly IntPtr NativeMethodInfoPtr_RegisterBinding_Private_Void_String_InputActionPhase_Action_1_CallbackContext_0;

		// Token: 0x04001E42 RID: 7746
		private static readonly IntPtr NativeMethodInfoPtr_RegisterPanelWiseBinding_Private_Void_String_InputActionPhase_Action_1_CallbackContext_0;

		// Token: 0x04001E43 RID: 7747
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Tilemap_Single_Single_0;

		// Token: 0x04001E44 RID: 7748
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerCharacterToDefaultSpawn_Public_Void_0;

		// Token: 0x04001E45 RID: 7749
		private static readonly IntPtr NativeMethodInfoPtr_ReadInput_Private_Void_CallbackContext_0;

		// Token: 0x04001E46 RID: 7750
		private static readonly IntPtr NativeMethodInfoPtr_Interact_Private_Void_CallbackContext_0;

		// Token: 0x04001E47 RID: 7751
		private static readonly IntPtr NativeMethodInfoPtr_CancelInput_Private_Void_CallbackContext_0;

		// Token: 0x04001E48 RID: 7752
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputAvaility_Private_Void_Boolean_0;

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeMethodInfoPtr_TryCancelExecution_Private_Void_RequestedInputMode_0;

		// Token: 0x04001E4B RID: 7755
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentFocus_Public_Void_0;

		// Token: 0x04001E4C RID: 7756
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCurrentFocus_Public_Void_0;

		// Token: 0x04001E4D RID: 7757
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteThrowDeliver_Public_IEnumerator_Sprite_Vector3_0;

		// Token: 0x04001E4E RID: 7758
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Void_0;

		// Token: 0x04001E4F RID: 7759
		private static readonly IntPtr NativeMethodInfoPtr_EndReverse_Public_Void_0;

		// Token: 0x04001E50 RID: 7760
		private static readonly IntPtr NativeMethodInfoPtr_Crazy_Public_Void_0;

		// Token: 0x04001E51 RID: 7761
		private static readonly IntPtr NativeMethodInfoPtr_EndCrazy_Public_Void_0;

		// Token: 0x04001E52 RID: 7762
		private static readonly IntPtr NativeMethodInfoPtr_Stun_Public_Void_Int32_Action_Action_1_Single_Action_0;

		// Token: 0x04001E53 RID: 7763
		private static readonly IntPtr NativeMethodInfoPtr_EndStunExtern_Public_Void_0;

		// Token: 0x04001E54 RID: 7764
		private static readonly IntPtr NativeMethodInfoPtr_OnStunLoop_Private_IEnumerator_Action_1_Single_0;

		// Token: 0x04001E55 RID: 7765
		private static readonly IntPtr NativeMethodInfoPtr_OnStunEnds_Private_Void_Boolean_0;

		// Token: 0x04001E56 RID: 7766
		private static readonly IntPtr NativeMethodInfoPtr_OnExternalStop_Protected_Virtual_Void_0;

		// Token: 0x04001E57 RID: 7767
		private static readonly IntPtr NativeMethodInfoPtr_ForbidMovement_Public_Void_0;

		// Token: 0x04001E58 RID: 7768
		private static readonly IntPtr NativeMethodInfoPtr_RecoverMovement_Public_Void_0;

		// Token: 0x04001E59 RID: 7769
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001E5A RID: 7770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E5B RID: 7771
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000807 RID: 2055
		[ObfuscatedName("NightScene.Input.WorkScenePlayerInputGenerator+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600A8CF RID: 43215 RVA: 0x002BCF44 File Offset: 0x002BB144
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr);
				WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9");
				WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__33_0");
				WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__33_1");
				WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__33_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__33_2");
				WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__33_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__33_3");
				WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__35_0");
				WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__41_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__41_3");
				WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__41_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__41_4");
				WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, 100671306);
				WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__Initialize_b__33_0_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, 100671307);
				WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__Initialize_b__33_1_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, 100671308);
				WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__Initialize_b__33_2_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, 100671309);
				WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__Initialize_b__33_3_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, 100671310);
				WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__ReadInput_b__35_0_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, 100671311);
				WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCurrentFocus_b__41_3_Internal_Boolean_Tuple_2_Single_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, 100671312);
				WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCurrentFocus_b__41_4_Internal_Single_Tuple_2_Single_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr, 100671313);
			}

			// Token: 0x0600A8D0 RID: 43216 RVA: 0x002BD0B0 File Offset: 0x002BB2B0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8D1 RID: 43217 RVA: 0x002BD0EC File Offset: 0x002BB2EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102280, XrefRangeEnd = 102285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__33_0(InputAction.CallbackContext _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__Initialize_b__33_0_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8D2 RID: 43218 RVA: 0x002BD134 File Offset: 0x002BB334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102285, XrefRangeEnd = 102290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__33_1(InputAction.CallbackContext _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__Initialize_b__33_1_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8D3 RID: 43219 RVA: 0x002BD17C File Offset: 0x002BB37C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102290, XrefRangeEnd = 102295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__33_2(InputAction.CallbackContext _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__Initialize_b__33_2_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8D4 RID: 43220 RVA: 0x002BD1C4 File Offset: 0x002BB3C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102295, XrefRangeEnd = 102300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__33_3(InputAction.CallbackContext _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__Initialize_b__33_3_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8D5 RID: 43221 RVA: 0x002BD20C File Offset: 0x002BB40C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102300, XrefRangeEnd = 102304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ReadInput_b__35_0(float y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__ReadInput_b__35_0_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A8D6 RID: 43222 RVA: 0x002BD258 File Offset: 0x002BB458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102304, XrefRangeEnd = 102309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateCurrentFocus_b__41_3(Tuple<float, Vector3Int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCurrentFocus_b__41_3_Internal_Boolean_Tuple_2_Single_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A8D7 RID: 43223 RVA: 0x002BD2A8 File Offset: 0x002BB4A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102309, XrefRangeEnd = 102310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _UpdateCurrentFocus_b__41_4(Tuple<float, Vector3Int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCurrentFocus_b__41_4_Internal_Single_Tuple_2_Single_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A8D8 RID: 43224 RVA: 0x0005B265 File Offset: 0x00059465
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003778 RID: 14200
			// (get) Token: 0x0600A8D9 RID: 43225 RVA: 0x002BD2F8 File Offset: 0x002BB4F8
			// (set) Token: 0x0600A8DA RID: 43226 RVA: 0x0005B26E File Offset: 0x0005946E
			public unsafe static WorkScenePlayerInputGenerator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkScenePlayerInputGenerator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003779 RID: 14201
			// (get) Token: 0x0600A8DB RID: 43227 RVA: 0x002BD320 File Offset: 0x002BB520
			// (set) Token: 0x0600A8DC RID: 43228 RVA: 0x0005B280 File Offset: 0x00059480
			public unsafe static Action<InputAction.CallbackContext> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700377A RID: 14202
			// (get) Token: 0x0600A8DD RID: 43229 RVA: 0x002BD348 File Offset: 0x002BB548
			// (set) Token: 0x0600A8DE RID: 43230 RVA: 0x0005B292 File Offset: 0x00059492
			public unsafe static Action<InputAction.CallbackContext> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700377B RID: 14203
			// (get) Token: 0x0600A8DF RID: 43231 RVA: 0x002BD370 File Offset: 0x002BB570
			// (set) Token: 0x0600A8E0 RID: 43232 RVA: 0x0005B2A4 File Offset: 0x000594A4
			public unsafe static Action<InputAction.CallbackContext> __9__33_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__33_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__33_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700377C RID: 14204
			// (get) Token: 0x0600A8E1 RID: 43233 RVA: 0x002BD398 File Offset: 0x002BB598
			// (set) Token: 0x0600A8E2 RID: 43234 RVA: 0x0005B2B6 File Offset: 0x000594B6
			public unsafe static Action<InputAction.CallbackContext> __9__33_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__33_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__33_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700377D RID: 14205
			// (get) Token: 0x0600A8E3 RID: 43235 RVA: 0x002BD3C0 File Offset: 0x002BB5C0
			// (set) Token: 0x0600A8E4 RID: 43236 RVA: 0x0005B2C8 File Offset: 0x000594C8
			public unsafe static Func<float, float> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700377E RID: 14206
			// (get) Token: 0x0600A8E5 RID: 43237 RVA: 0x002BD3E8 File Offset: 0x002BB5E8
			// (set) Token: 0x0600A8E6 RID: 43238 RVA: 0x0005B2DA File Offset: 0x000594DA
			public unsafe static Func<Tuple<float, Vector3Int>, bool> __9__41_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__41_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<float, Vector3Int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__41_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700377F RID: 14207
			// (get) Token: 0x0600A8E7 RID: 43239 RVA: 0x002BD410 File Offset: 0x002BB610
			// (set) Token: 0x0600A8E8 RID: 43240 RVA: 0x0005B2EC File Offset: 0x000594EC
			public unsafe static Func<Tuple<float, Vector3Int>, float> __9__41_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__41_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<float, Vector3Int>, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__41_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D18 RID: 27928
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006D19 RID: 27929
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x04006D1A RID: 27930
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x04006D1B RID: 27931
			private static readonly IntPtr NativeFieldInfoPtr___9__33_2;

			// Token: 0x04006D1C RID: 27932
			private static readonly IntPtr NativeFieldInfoPtr___9__33_3;

			// Token: 0x04006D1D RID: 27933
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x04006D1E RID: 27934
			private static readonly IntPtr NativeFieldInfoPtr___9__41_3;

			// Token: 0x04006D1F RID: 27935
			private static readonly IntPtr NativeFieldInfoPtr___9__41_4;

			// Token: 0x04006D20 RID: 27936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006D21 RID: 27937
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__33_0_Internal_Void_CallbackContext_0;

			// Token: 0x04006D22 RID: 27938
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__33_1_Internal_Void_CallbackContext_0;

			// Token: 0x04006D23 RID: 27939
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__33_2_Internal_Void_CallbackContext_0;

			// Token: 0x04006D24 RID: 27940
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__33_3_Internal_Void_CallbackContext_0;

			// Token: 0x04006D25 RID: 27941
			private static readonly IntPtr NativeMethodInfoPtr__ReadInput_b__35_0_Internal_Single_Single_0;

			// Token: 0x04006D26 RID: 27942
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentFocus_b__41_3_Internal_Boolean_Tuple_2_Single_Vector3Int_0;

			// Token: 0x04006D27 RID: 27943
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentFocus_b__41_4_Internal_Single_Tuple_2_Single_Vector3Int_0;
		}

		// Token: 0x02000808 RID: 2056
		[ObfuscatedName("NightScene.Input.WorkScenePlayerInputGenerator+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A8E9 RID: 43241 RVA: 0x002BD438 File Offset: 0x002BB638
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c__DisplayClass41_0>.NativeClassPtr);
				WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeFieldInfoPtr_characterCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c__DisplayClass41_0>.NativeClassPtr, "characterCenter");
				WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c__DisplayClass41_0>.NativeClassPtr, 100671314);
				WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeMethodInfoPtr__UpdateCurrentFocus_b__0_Internal_Vector3_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c__DisplayClass41_0>.NativeClassPtr, 100671315);
				WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeMethodInfoPtr__UpdateCurrentFocus_b__1_Internal_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c__DisplayClass41_0>.NativeClassPtr, 100671316);
				WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeMethodInfoPtr__UpdateCurrentFocus_b__2_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c__DisplayClass41_0>.NativeClassPtr, 100671317);
			}

			// Token: 0x0600A8EA RID: 43242 RVA: 0x002BD4DC File Offset: 0x002BB6DC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8EB RID: 43243 RVA: 0x002BD518 File Offset: 0x002BB718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102310, XrefRangeEnd = 102311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _UpdateCurrentFocus_b__0(Vector3Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeMethodInfoPtr__UpdateCurrentFocus_b__0_Internal_Vector3_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A8EC RID: 43244 RVA: 0x002BD564 File Offset: 0x002BB764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102311, XrefRangeEnd = 102315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCurrentFocus_b__1(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeMethodInfoPtr__UpdateCurrentFocus_b__1_Internal_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8ED RID: 43245 RVA: 0x002BD5A4 File Offset: 0x002BB7A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102315, XrefRangeEnd = 102318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _UpdateCurrentFocus_b__2(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeMethodInfoPtr__UpdateCurrentFocus_b__2_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A8EE RID: 43246 RVA: 0x0005B2FE File Offset: 0x000594FE
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003780 RID: 14208
			// (get) Token: 0x0600A8EF RID: 43247 RVA: 0x002BD5F0 File Offset: 0x002BB7F0
			// (set) Token: 0x0600A8F0 RID: 43248 RVA: 0x0005B307 File Offset: 0x00059507
			public unsafe WorkScenePlayerInputGenerator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkScenePlayerInputGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003781 RID: 14209
			// (get) Token: 0x0600A8F1 RID: 43249 RVA: 0x002BD620 File Offset: 0x002BB820
			// (set) Token: 0x0600A8F2 RID: 43250 RVA: 0x0005B326 File Offset: 0x00059526
			public unsafe Vector3 characterCenter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeFieldInfoPtr_characterCenter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.__c__DisplayClass41_0.NativeFieldInfoPtr_characterCenter)) = value;
				}
			}

			// Token: 0x04006D28 RID: 27944
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006D29 RID: 27945
			private static readonly IntPtr NativeFieldInfoPtr_characterCenter;

			// Token: 0x04006D2A RID: 27946
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006D2B RID: 27947
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentFocus_b__0_Internal_Vector3_Vector3Int_0;

			// Token: 0x04006D2C RID: 27948
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentFocus_b__1_Internal_Void_Vector3_0;

			// Token: 0x04006D2D RID: 27949
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentFocus_b__2_Internal_Single_Vector3_0;
		}

		// Token: 0x02000809 RID: 2057
		[ObfuscatedName("NightScene.Input.WorkScenePlayerInputGenerator+<ExecuteThrowDeliver>d__43")]
		public sealed class _ExecuteThrowDeliver_d__43 : Il2CppSystem.Object
		{
			// Token: 0x0600A8F3 RID: 43251 RVA: 0x002BD648 File Offset: 0x002BB848
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteThrowDeliver_d__43()
			{
				Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "<ExecuteThrowDeliver>d__43");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr);
				WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr, "<>1__state");
				WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr, "<>2__current");
				WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr, "sprite");
				WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr, "target");
				WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr, "<>4__this");
				WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr, 100671318);
				WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr, 100671319);
				WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr, 100671320);
				WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr, 100671321);
				WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr, 100671322);
				WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr, 100671323);
			}

			// Token: 0x0600A8F4 RID: 43252 RVA: 0x002BD750 File Offset: 0x002BB950
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteThrowDeliver_d__43(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8F5 RID: 43253 RVA: 0x002BD798 File Offset: 0x002BB998
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A8F6 RID: 43254 RVA: 0x002BD7CC File Offset: 0x002BB9CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102318, XrefRangeEnd = 102325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003787 RID: 14215
			// (get) Token: 0x0600A8F7 RID: 43255 RVA: 0x002BD808 File Offset: 0x002BBA08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A8F8 RID: 43256 RVA: 0x002BD848 File Offset: 0x002BBA48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102325, XrefRangeEnd = 102331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003788 RID: 14216
			// (get) Token: 0x0600A8F9 RID: 43257 RVA: 0x002BD87C File Offset: 0x002BBA7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A8FA RID: 43258 RVA: 0x0005B341 File Offset: 0x00059541
			public _ExecuteThrowDeliver_d__43(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003782 RID: 14210
			// (get) Token: 0x0600A8FB RID: 43259 RVA: 0x002BD8BC File Offset: 0x002BBABC
			// (set) Token: 0x0600A8FC RID: 43260 RVA: 0x0005B34A File Offset: 0x0005954A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003783 RID: 14211
			// (get) Token: 0x0600A8FD RID: 43261 RVA: 0x002BD8E4 File Offset: 0x002BBAE4
			// (set) Token: 0x0600A8FE RID: 43262 RVA: 0x0005B365 File Offset: 0x00059565
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003784 RID: 14212
			// (get) Token: 0x0600A8FF RID: 43263 RVA: 0x002BD914 File Offset: 0x002BBB14
			// (set) Token: 0x0600A900 RID: 43264 RVA: 0x0005B384 File Offset: 0x00059584
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003785 RID: 14213
			// (get) Token: 0x0600A901 RID: 43265 RVA: 0x002BD944 File Offset: 0x002BBB44
			// (set) Token: 0x0600A902 RID: 43266 RVA: 0x0005B3A3 File Offset: 0x000595A3
			public unsafe Vector3 target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr_target);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr_target)) = value;
				}
			}

			// Token: 0x17003786 RID: 14214
			// (get) Token: 0x0600A903 RID: 43267 RVA: 0x002BD96C File Offset: 0x002BBB6C
			// (set) Token: 0x0600A904 RID: 43268 RVA: 0x0005B3BE File Offset: 0x000595BE
			public unsafe WorkScenePlayerInputGenerator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkScenePlayerInputGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._ExecuteThrowDeliver_d__43.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D2E RID: 27950
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006D2F RID: 27951
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006D30 RID: 27952
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x04006D31 RID: 27953
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04006D32 RID: 27954
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006D33 RID: 27955
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006D34 RID: 27956
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D35 RID: 27957
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006D36 RID: 27958
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006D37 RID: 27959
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D38 RID: 27960
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200080A RID: 2058
		[ObfuscatedName("NightScene.Input.WorkScenePlayerInputGenerator+<OnStunLoop>d__50")]
		public sealed class _OnStunLoop_d__50 : Il2CppSystem.Object
		{
			// Token: 0x0600A905 RID: 43269 RVA: 0x002BD99C File Offset: 0x002BBB9C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnStunLoop_d__50()
			{
				Il2CppClassPointerStore<WorkScenePlayerInputGenerator._OnStunLoop_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "<OnStunLoop>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._OnStunLoop_d__50>.NativeClassPtr);
				WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._OnStunLoop_d__50>.NativeClassPtr, "<>1__state");
				WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._OnStunLoop_d__50>.NativeClassPtr, "<>2__current");
				WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeFieldInfoPtr_actionUpdateCallBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._OnStunLoop_d__50>.NativeClassPtr, "actionUpdateCallBack");
				WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._OnStunLoop_d__50>.NativeClassPtr, "<>4__this");
				WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._OnStunLoop_d__50>.NativeClassPtr, 100671324);
				WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._OnStunLoop_d__50>.NativeClassPtr, 100671325);
				WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._OnStunLoop_d__50>.NativeClassPtr, 100671326);
				WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._OnStunLoop_d__50>.NativeClassPtr, 100671327);
				WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._OnStunLoop_d__50>.NativeClassPtr, 100671328);
				WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._OnStunLoop_d__50>.NativeClassPtr, 100671329);
			}

			// Token: 0x0600A906 RID: 43270 RVA: 0x002BDA90 File Offset: 0x002BBC90
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnStunLoop_d__50(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkScenePlayerInputGenerator._OnStunLoop_d__50>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A907 RID: 43271 RVA: 0x002BDAD8 File Offset: 0x002BBCD8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A908 RID: 43272 RVA: 0x002BDB0C File Offset: 0x002BBD0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102331, XrefRangeEnd = 102335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700378D RID: 14221
			// (get) Token: 0x0600A909 RID: 43273 RVA: 0x002BDB48 File Offset: 0x002BBD48
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A90A RID: 43274 RVA: 0x002BDB88 File Offset: 0x002BBD88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102335, XrefRangeEnd = 102341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700378E RID: 14222
			// (get) Token: 0x0600A90B RID: 43275 RVA: 0x002BDBBC File Offset: 0x002BBDBC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A90C RID: 43276 RVA: 0x0005B3DD File Offset: 0x000595DD
			public _OnStunLoop_d__50(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003789 RID: 14217
			// (get) Token: 0x0600A90D RID: 43277 RVA: 0x002BDBFC File Offset: 0x002BBDFC
			// (set) Token: 0x0600A90E RID: 43278 RVA: 0x0005B3E6 File Offset: 0x000595E6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700378A RID: 14218
			// (get) Token: 0x0600A90F RID: 43279 RVA: 0x002BDC24 File Offset: 0x002BBE24
			// (set) Token: 0x0600A910 RID: 43280 RVA: 0x0005B401 File Offset: 0x00059601
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700378B RID: 14219
			// (get) Token: 0x0600A911 RID: 43281 RVA: 0x002BDC54 File Offset: 0x002BBE54
			// (set) Token: 0x0600A912 RID: 43282 RVA: 0x0005B420 File Offset: 0x00059620
			public unsafe Action<float> actionUpdateCallBack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeFieldInfoPtr_actionUpdateCallBack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeFieldInfoPtr_actionUpdateCallBack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700378C RID: 14220
			// (get) Token: 0x0600A913 RID: 43283 RVA: 0x002BDC84 File Offset: 0x002BBE84
			// (set) Token: 0x0600A914 RID: 43284 RVA: 0x0005B43F File Offset: 0x0005963F
			public unsafe WorkScenePlayerInputGenerator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkScenePlayerInputGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator._OnStunLoop_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D39 RID: 27961
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006D3A RID: 27962
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006D3B RID: 27963
			private static readonly IntPtr NativeFieldInfoPtr_actionUpdateCallBack;

			// Token: 0x04006D3C RID: 27964
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006D3D RID: 27965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006D3E RID: 27966
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D3F RID: 27967
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006D40 RID: 27968
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006D41 RID: 27969
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D42 RID: 27970
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200080B RID: 2059
		[ObfuscatedName("NightScene.Input.WorkScenePlayerInputGenerator+<<Interact>g__ExecuteDelayed|36_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600A915 RID: 43285 RVA: 0x002BDCB4 File Offset: 0x002BBEB4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique()
			{
				Il2CppClassPointerStore<WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkScenePlayerInputGenerator>.NativeClassPtr, "<<Interact>g__ExecuteDelayed|36_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique>.NativeClassPtr);
				WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique>.NativeClassPtr, "<>1__state");
				WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique>.NativeClassPtr, "<>2__current");
				WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique>.NativeClassPtr, "<>4__this");
				WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique>.NativeClassPtr, 100671330);
				WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique>.NativeClassPtr, 100671331);
				WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique>.NativeClassPtr, 100671332);
				WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique>.NativeClassPtr, 100671333);
				WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique>.NativeClassPtr, 100671334);
				WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique>.NativeClassPtr, 100671335);
			}

			// Token: 0x0600A916 RID: 43286 RVA: 0x002BDD94 File Offset: 0x002BBF94
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A917 RID: 43287 RVA: 0x002BDDDC File Offset: 0x002BBFDC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A918 RID: 43288 RVA: 0x002BDE10 File Offset: 0x002BC010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102341, XrefRangeEnd = 102346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003792 RID: 14226
			// (get) Token: 0x0600A919 RID: 43289 RVA: 0x002BDE4C File Offset: 0x002BC04C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A91A RID: 43290 RVA: 0x002BDE8C File Offset: 0x002BC08C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102346, XrefRangeEnd = 102352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003793 RID: 14227
			// (get) Token: 0x0600A91B RID: 43291 RVA: 0x002BDEC0 File Offset: 0x002BC0C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A91C RID: 43292 RVA: 0x0005B45E File Offset: 0x0005965E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700378F RID: 14223
			// (get) Token: 0x0600A91D RID: 43293 RVA: 0x002BDF00 File Offset: 0x002BC100
			// (set) Token: 0x0600A91E RID: 43294 RVA: 0x0005B467 File Offset: 0x00059667
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003790 RID: 14224
			// (get) Token: 0x0600A91F RID: 43295 RVA: 0x002BDF28 File Offset: 0x002BC128
			// (set) Token: 0x0600A920 RID: 43296 RVA: 0x0005B482 File Offset: 0x00059682
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003791 RID: 14225
			// (get) Token: 0x0600A921 RID: 43297 RVA: 0x002BDF58 File Offset: 0x002BC158
			// (set) Token: 0x0600A922 RID: 43298 RVA: 0x0005B4A1 File Offset: 0x000596A1
			public unsafe WorkScenePlayerInputGenerator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkScenePlayerInputGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006D43 RID: 27971
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006D44 RID: 27972
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006D45 RID: 27973
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006D46 RID: 27974
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006D47 RID: 27975
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D48 RID: 27976
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006D49 RID: 27977
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006D4A RID: 27978
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006D4B RID: 27979
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
