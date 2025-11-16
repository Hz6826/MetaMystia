using System;
using Common.CharacterUtility;
using DayScene.Interactables;
using DayScene.UI;
using DEYU.AdpUISystem.Managers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DayScene.Input
{
	// Token: 0x0200015D RID: 349
	public class DayScenePlayerInputGenerator : CharacterControllerInputGeneratorComponent
	{
		// Token: 0x06002791 RID: 10129 RVA: 0x001222F0 File Offset: 0x001204F0
		// Note: this type is marked as 'beforefieldinit'.
		static DayScenePlayerInputGenerator()
		{
			Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Input", "DayScenePlayerInputGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr);
			DayScenePlayerInputGenerator.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, "moveSpeed");
			DayScenePlayerInputGenerator.NativeFieldInfoPtr_allInteractables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, "allInteractables");
			DayScenePlayerInputGenerator.NativeFieldInfoPtr_m_RegisteredBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, "m_RegisteredBinding");
			DayScenePlayerInputGenerator.NativeFieldInfoPtr_m_RegisteredPanelWiseBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, "m_RegisteredPanelWiseBinding");
			DayScenePlayerInputGenerator.NativeFieldInfoPtr_currentInteractAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, "currentInteractAction");
			DayScenePlayerInputGenerator.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, "initialized");
			DayScenePlayerInputGenerator.NativeFieldInfoPtr_internalAvailability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, "internalAvailability");
			DayScenePlayerInputGenerator.NativeFieldInfoPtr_m_SustainedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, "m_SustainedPanel");
			DayScenePlayerInputGenerator.NativeFieldInfoPtr_onWillExecuteInteractAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, "onWillExecuteInteractAction");
			DayScenePlayerInputGenerator.NativeFieldInfoPtr_onWillExecuteInteractActionProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, "onWillExecuteInteractActionProcess");
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670262);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_RegisterBinding_Private_Void_String_InputActionPhase_Action_1_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670263);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_RegisterPanelWiseBinding_Private_Void_String_InputActionPhase_Action_1_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670264);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_UpdateCharacter_Public_Void_DaySceneMap_SpawnMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670265);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_OnPanelWillOpenCallback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670266);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_OnMovePerformed_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670267);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_OnSprintCanceled_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670268);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_OnSprintPerformed_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670269);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_OnMoveCanceled_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670270);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_UpdateInputAvaility_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670271);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670272);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_TryCancelExecutionIfUI_Private_Void_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670273);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_TryInteract_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670274);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_RegisterInteractableEvent_Public_Void_InteractableArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670275);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_DeRegInteractableEvent_Public_Void_InteractableArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670276);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_UpdateUIBehaviour_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670277);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_UpdateCurrentFocusing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670278);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_OnExternalStop_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670279);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670280);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670281);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr__UpdateCharacter_b__14_4_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670282);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr__UpdateCharacter_b__14_5_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670283);
			DayScenePlayerInputGenerator.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, 100670284);
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x001225B4 File Offset: 0x001207B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90994, XrefRangeEnd = 90996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x001225E8 File Offset: 0x001207E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 91009, RefRangeEnd = 91015, XrefRangeStart = 90996, XrefRangeEnd = 91009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterBinding(string bindingName, InputActionPhase phase, Action<InputAction.CallbackContext> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(bindingName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_RegisterBinding_Private_Void_String_InputActionPhase_Action_1_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x0012264C File Offset: 0x0012084C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 91028, RefRangeEnd = 91034, XrefRangeStart = 91015, XrefRangeEnd = 91028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterPanelWiseBinding(string bindingName, InputActionPhase phase, Action<InputAction.CallbackContext> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(bindingName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_RegisterPanelWiseBinding_Private_Void_String_InputActionPhase_Action_1_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x001226B0 File Offset: 0x001208B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 91245, RefRangeEnd = 91248, XrefRangeStart = 91034, XrefRangeEnd = 91245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCharacter(DaySceneMap map, SpawnMarker spawnMarker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spawnMarker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_UpdateCharacter_Public_Void_DaySceneMap_SpawnMarker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x00122704 File Offset: 0x00120904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91248, XrefRangeEnd = 91249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelWillOpenCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_OnPanelWillOpenCallback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00122738 File Offset: 0x00120938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91249, XrefRangeEnd = 91276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMovePerformed(InputAction.CallbackContext x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_OnMovePerformed_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x00122780 File Offset: 0x00120980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSprintCanceled(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_OnSprintCanceled_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x001227C8 File Offset: 0x001209C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91276, XrefRangeEnd = 91284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSprintPerformed(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_OnSprintPerformed_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x00122810 File Offset: 0x00120A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91284, XrefRangeEnd = 91295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMoveCanceled(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_OnMoveCanceled_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x00122858 File Offset: 0x00120A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91295, XrefRangeEnd = 91307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputAvaility(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_UpdateInputAvaility_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x00122898 File Offset: 0x00120A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91372, RefRangeEnd = 91373, XrefRangeStart = 91307, XrefRangeEnd = 91372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x001228CC File Offset: 0x00120ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91373, XrefRangeEnd = 91384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryCancelExecutionIfUI(AdpUIPanelManager.RequestedInputMode requestedInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestedInput;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_TryCancelExecutionIfUI_Private_Void_RequestedInputMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x0012290C File Offset: 0x00120B0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91393, RefRangeEnd = 91395, XrefRangeStart = 91384, XrefRangeEnd = 91393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_TryInteract_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x00122940 File Offset: 0x00120B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91395, XrefRangeEnd = 91400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterInteractableEvent(InteractableArea entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_RegisterInteractableEvent_Public_Void_InteractableArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x00122984 File Offset: 0x00120B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91400, XrefRangeEnd = 91405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeRegInteractableEvent(InteractableArea entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_DeRegInteractableEvent_Public_Void_InteractableArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x001229C8 File Offset: 0x00120BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91405, XrefRangeEnd = 91406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUIBehaviour(bool _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_UpdateUIBehaviour_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x00122A08 File Offset: 0x00120C08
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 91501, RefRangeEnd = 91508, XrefRangeStart = 91406, XrefRangeEnd = 91501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentFocusing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_UpdateCurrentFocusing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00122A3C File Offset: 0x00120C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91508, XrefRangeEnd = 91511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExternalStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DayScenePlayerInputGenerator.NativeMethodInfoPtr_OnExternalStop_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00122A78 File Offset: 0x00120C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91511, XrefRangeEnd = 91517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DayScenePlayerInputGenerator.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00122AB4 File Offset: 0x00120CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91517, XrefRangeEnd = 91538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DayScenePlayerInputGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x00122AF0 File Offset: 0x00120CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91538, XrefRangeEnd = 91539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateCharacter_b__14_4(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr__UpdateCharacter_b__14_4_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00122B38 File Offset: 0x00120D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateCharacter_b__14_5(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr__UpdateCharacter_b__14_5_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x00122B80 File Offset: 0x00120D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91539, XrefRangeEnd = 91544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000175C1 File Offset: 0x000157C1
		public DayScenePlayerInputGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x060027AA RID: 10154 RVA: 0x00122BC0 File Offset: 0x00120DC0
		// (set) Token: 0x060027AB RID: 10155 RVA: 0x000175CA File Offset: 0x000157CA
		public unsafe float moveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_moveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_moveSpeed)) = value;
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x060027AC RID: 10156 RVA: 0x00122BE8 File Offset: 0x00120DE8
		// (set) Token: 0x060027AD RID: 10157 RVA: 0x000175E5 File Offset: 0x000157E5
		public unsafe List<InteractableArea> allInteractables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_allInteractables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InteractableArea>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_allInteractables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x00122C18 File Offset: 0x00120E18
		// (set) Token: 0x060027AF RID: 10159 RVA: 0x00017604 File Offset: 0x00015804
		public unsafe Stack<ValueTuple<string, InputActionPhase, Action<InputAction.CallbackContext>>> m_RegisteredBinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_m_RegisteredBinding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ValueTuple<string, InputActionPhase, Action<InputAction.CallbackContext>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_m_RegisteredBinding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x00122C48 File Offset: 0x00120E48
		// (set) Token: 0x060027B1 RID: 10161 RVA: 0x00017623 File Offset: 0x00015823
		public unsafe Stack<ValueTuple<string, InputActionPhase, Action<InputAction.CallbackContext>>> m_RegisteredPanelWiseBinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_m_RegisteredPanelWiseBinding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ValueTuple<string, InputActionPhase, Action<InputAction.CallbackContext>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_m_RegisteredPanelWiseBinding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x00122C78 File Offset: 0x00120E78
		// (set) Token: 0x060027B3 RID: 10163 RVA: 0x00017642 File Offset: 0x00015842
		public unsafe Action currentInteractAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_currentInteractAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_currentInteractAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x00122CA8 File Offset: 0x00120EA8
		// (set) Token: 0x060027B5 RID: 10165 RVA: 0x00017661 File Offset: 0x00015861
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x00122CD0 File Offset: 0x00120ED0
		// (set) Token: 0x060027B7 RID: 10167 RVA: 0x0001767C File Offset: 0x0001587C
		public unsafe bool internalAvailability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_internalAvailability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_internalAvailability)) = value;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x00122CF8 File Offset: 0x00120EF8
		// (set) Token: 0x060027B9 RID: 10169 RVA: 0x00017697 File Offset: 0x00015897
		public unsafe DaySceneSustainedPannel m_SustainedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_m_SustainedPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneSustainedPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_m_SustainedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x00122D28 File Offset: 0x00120F28
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x000176B6 File Offset: 0x000158B6
		public unsafe bool onWillExecuteInteractAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_onWillExecuteInteractAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_onWillExecuteInteractAction)) = value;
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x00122D50 File Offset: 0x00120F50
		// (set) Token: 0x060027BD RID: 10173 RVA: 0x000176D1 File Offset: 0x000158D1
		public unsafe Coroutine onWillExecuteInteractActionProcess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_onWillExecuteInteractActionProcess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.NativeFieldInfoPtr_onWillExecuteInteractActionProcess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeFieldInfoPtr_allInteractables;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeFieldInfoPtr_m_RegisteredBinding;

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeFieldInfoPtr_m_RegisteredPanelWiseBinding;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeFieldInfoPtr_currentInteractAction;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeFieldInfoPtr_internalAvailability;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeFieldInfoPtr_m_SustainedPanel;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeFieldInfoPtr_onWillExecuteInteractAction;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeFieldInfoPtr_onWillExecuteInteractActionProcess;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeMethodInfoPtr_RegisterBinding_Private_Void_String_InputActionPhase_Action_1_CallbackContext_0;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeMethodInfoPtr_RegisterPanelWiseBinding_Private_Void_String_InputActionPhase_Action_1_CallbackContext_0;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCharacter_Public_Void_DaySceneMap_SpawnMarker_0;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelWillOpenCallback_Private_Void_0;

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeMethodInfoPtr_OnMovePerformed_Private_Void_CallbackContext_0;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeMethodInfoPtr_OnSprintCanceled_Private_Void_CallbackContext_0;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeMethodInfoPtr_OnSprintPerformed_Private_Void_CallbackContext_0;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeMethodInfoPtr_OnMoveCanceled_Private_Void_CallbackContext_0;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputAvaility_Private_Void_Boolean_0;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeMethodInfoPtr_TryCancelExecutionIfUI_Private_Void_RequestedInputMode_0;

		// Token: 0x04001A4D RID: 6733
		private static readonly IntPtr NativeMethodInfoPtr_TryInteract_Private_Void_0;

		// Token: 0x04001A4E RID: 6734
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInteractableEvent_Public_Void_InteractableArea_0;

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeMethodInfoPtr_DeRegInteractableEvent_Public_Void_InteractableArea_0;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUIBehaviour_Private_Void_Boolean_0;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentFocusing_Private_Void_0;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeMethodInfoPtr_OnExternalStop_Protected_Virtual_Void_0;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeMethodInfoPtr__UpdateCharacter_b__14_4_Private_Void_CallbackContext_0;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeMethodInfoPtr__UpdateCharacter_b__14_5_Private_Void_CallbackContext_0;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000787 RID: 1927
		public enum CharacterRotation
		{
			// Token: 0x0400698B RID: 27019
			Down,
			// Token: 0x0400698C RID: 27020
			Left,
			// Token: 0x0400698D RID: 27021
			Up,
			// Token: 0x0400698E RID: 27022
			Right,
			// Token: 0x0400698F RID: 27023
			Null = -1
		}

		// Token: 0x02000788 RID: 1928
		[ObfuscatedName("DayScene.Input.DayScenePlayerInputGenerator+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600A307 RID: 41735 RVA: 0x002AC768 File Offset: 0x002AA968
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr);
				DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9");
				DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__14_0");
				DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__14_1");
				DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__14_2");
				DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__14_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__14_3");
				DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__16_0");
				DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__27_1");
				DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__27_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, "<>9__27_2");
				DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, 100670286);
				DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCharacter_b__14_0_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, 100670287);
				DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCharacter_b__14_1_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, 100670288);
				DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCharacter_b__14_2_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, 100670289);
				DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCharacter_b__14_3_Internal_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, 100670290);
				DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__OnMovePerformed_b__16_0_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, 100670291);
				DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCurrentFocusing_b__27_1_Internal_Boolean_InteractableArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, 100670292);
				DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCurrentFocusing_b__27_2_Internal_Boolean_InteractableArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr, 100670293);
			}

			// Token: 0x0600A308 RID: 41736 RVA: 0x002AC8D4 File Offset: 0x002AAAD4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A309 RID: 41737 RVA: 0x002AC910 File Offset: 0x002AAB10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90945, XrefRangeEnd = 90950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCharacter_b__14_0(InputAction.CallbackContext _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCharacter_b__14_0_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A30A RID: 41738 RVA: 0x002AC958 File Offset: 0x002AAB58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90950, XrefRangeEnd = 90955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCharacter_b__14_1(InputAction.CallbackContext _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCharacter_b__14_1_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A30B RID: 41739 RVA: 0x002AC9A0 File Offset: 0x002AABA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90955, XrefRangeEnd = 90960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCharacter_b__14_2(InputAction.CallbackContext _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCharacter_b__14_2_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A30C RID: 41740 RVA: 0x002AC9E8 File Offset: 0x002AABE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90960, XrefRangeEnd = 90965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCharacter_b__14_3(InputAction.CallbackContext _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCharacter_b__14_3_Internal_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A30D RID: 41741 RVA: 0x002ACA30 File Offset: 0x002AAC30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90965, XrefRangeEnd = 90969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _OnMovePerformed_b__16_0(float y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__OnMovePerformed_b__16_0_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A30E RID: 41742 RVA: 0x002ACA7C File Offset: 0x002AAC7C
			[CallerCount(0)]
			public unsafe bool _UpdateCurrentFocusing_b__27_1(InteractableArea x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCurrentFocusing_b__27_1_Internal_Boolean_InteractableArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A30F RID: 41743 RVA: 0x002ACACC File Offset: 0x002AACCC
			[CallerCount(0)]
			public unsafe bool _UpdateCurrentFocusing_b__27_2(InteractableArea x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.__c.NativeMethodInfoPtr__UpdateCurrentFocusing_b__27_2_Internal_Boolean_InteractableArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A310 RID: 41744 RVA: 0x00058184 File Offset: 0x00056384
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035CA RID: 13770
			// (get) Token: 0x0600A311 RID: 41745 RVA: 0x002ACB1C File Offset: 0x002AAD1C
			// (set) Token: 0x0600A312 RID: 41746 RVA: 0x0005818D File Offset: 0x0005638D
			public unsafe static DayScenePlayerInputGenerator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DayScenePlayerInputGenerator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035CB RID: 13771
			// (get) Token: 0x0600A313 RID: 41747 RVA: 0x002ACB44 File Offset: 0x002AAD44
			// (set) Token: 0x0600A314 RID: 41748 RVA: 0x0005819F File Offset: 0x0005639F
			public unsafe static Action<InputAction.CallbackContext> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035CC RID: 13772
			// (get) Token: 0x0600A315 RID: 41749 RVA: 0x002ACB6C File Offset: 0x002AAD6C
			// (set) Token: 0x0600A316 RID: 41750 RVA: 0x000581B1 File Offset: 0x000563B1
			public unsafe static Action<InputAction.CallbackContext> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035CD RID: 13773
			// (get) Token: 0x0600A317 RID: 41751 RVA: 0x002ACB94 File Offset: 0x002AAD94
			// (set) Token: 0x0600A318 RID: 41752 RVA: 0x000581C3 File Offset: 0x000563C3
			public unsafe static Action<InputAction.CallbackContext> __9__14_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035CE RID: 13774
			// (get) Token: 0x0600A319 RID: 41753 RVA: 0x002ACBBC File Offset: 0x002AADBC
			// (set) Token: 0x0600A31A RID: 41754 RVA: 0x000581D5 File Offset: 0x000563D5
			public unsafe static Action<InputAction.CallbackContext> __9__14_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__14_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputAction.CallbackContext>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__14_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035CF RID: 13775
			// (get) Token: 0x0600A31B RID: 41755 RVA: 0x002ACBE4 File Offset: 0x002AADE4
			// (set) Token: 0x0600A31C RID: 41756 RVA: 0x000581E7 File Offset: 0x000563E7
			public unsafe static Func<float, float> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035D0 RID: 13776
			// (get) Token: 0x0600A31D RID: 41757 RVA: 0x002ACC0C File Offset: 0x002AAE0C
			// (set) Token: 0x0600A31E RID: 41758 RVA: 0x000581F9 File Offset: 0x000563F9
			public unsafe static Func<InteractableArea, bool> __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InteractableArea, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035D1 RID: 13777
			// (get) Token: 0x0600A31F RID: 41759 RVA: 0x002ACC34 File Offset: 0x002AAE34
			// (set) Token: 0x0600A320 RID: 41760 RVA: 0x0005820B File Offset: 0x0005640B
			public unsafe static Func<InteractableArea, bool> __9__27_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__27_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<InteractableArea, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DayScenePlayerInputGenerator.__c.NativeFieldInfoPtr___9__27_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006990 RID: 27024
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006991 RID: 27025
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04006992 RID: 27026
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x04006993 RID: 27027
			private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x04006994 RID: 27028
			private static readonly IntPtr NativeFieldInfoPtr___9__14_3;

			// Token: 0x04006995 RID: 27029
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04006996 RID: 27030
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x04006997 RID: 27031
			private static readonly IntPtr NativeFieldInfoPtr___9__27_2;

			// Token: 0x04006998 RID: 27032
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006999 RID: 27033
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCharacter_b__14_0_Internal_Void_CallbackContext_0;

			// Token: 0x0400699A RID: 27034
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCharacter_b__14_1_Internal_Void_CallbackContext_0;

			// Token: 0x0400699B RID: 27035
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCharacter_b__14_2_Internal_Void_CallbackContext_0;

			// Token: 0x0400699C RID: 27036
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCharacter_b__14_3_Internal_Void_CallbackContext_0;

			// Token: 0x0400699D RID: 27037
			private static readonly IntPtr NativeMethodInfoPtr__OnMovePerformed_b__16_0_Internal_Single_Single_0;

			// Token: 0x0400699E RID: 27038
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentFocusing_b__27_1_Internal_Boolean_InteractableArea_0;

			// Token: 0x0400699F RID: 27039
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentFocusing_b__27_2_Internal_Boolean_InteractableArea_0;
		}

		// Token: 0x02000789 RID: 1929
		[ObfuscatedName("DayScene.Input.DayScenePlayerInputGenerator+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A321 RID: 41761 RVA: 0x002ACC5C File Offset: 0x002AAE5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c__DisplayClass27_0>.NativeClassPtr);
				DayScenePlayerInputGenerator.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				DayScenePlayerInputGenerator.__c__DisplayClass27_0.NativeFieldInfoPtr_selectedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c__DisplayClass27_0>.NativeClassPtr, "selectedEntity");
				DayScenePlayerInputGenerator.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c__DisplayClass27_0>.NativeClassPtr, 100670294);
				DayScenePlayerInputGenerator.__c__DisplayClass27_0.NativeMethodInfoPtr__UpdateCurrentFocusing_b__0_Internal_Single_InteractableArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c__DisplayClass27_0>.NativeClassPtr, 100670295);
				DayScenePlayerInputGenerator.__c__DisplayClass27_0.NativeMethodInfoPtr__UpdateCurrentFocusing_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c__DisplayClass27_0>.NativeClassPtr, 100670296);
			}

			// Token: 0x0600A322 RID: 41762 RVA: 0x002ACCEC File Offset: 0x002AAEEC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DayScenePlayerInputGenerator.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A323 RID: 41763 RVA: 0x002ACD28 File Offset: 0x002AAF28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90969, XrefRangeEnd = 90978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _UpdateCurrentFocusing_b__0(InteractableArea x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.__c__DisplayClass27_0.NativeMethodInfoPtr__UpdateCurrentFocusing_b__0_Internal_Single_InteractableArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A324 RID: 41764 RVA: 0x002ACD78 File Offset: 0x002AAF78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90978, XrefRangeEnd = 90987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCurrentFocusing_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.__c__DisplayClass27_0.NativeMethodInfoPtr__UpdateCurrentFocusing_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A325 RID: 41765 RVA: 0x0005821D File Offset: 0x0005641D
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035D2 RID: 13778
			// (get) Token: 0x0600A326 RID: 41766 RVA: 0x002ACDAC File Offset: 0x002AAFAC
			// (set) Token: 0x0600A327 RID: 41767 RVA: 0x00058226 File Offset: 0x00056426
			public unsafe DayScenePlayerInputGenerator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DayScenePlayerInputGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035D3 RID: 13779
			// (get) Token: 0x0600A328 RID: 41768 RVA: 0x002ACDDC File Offset: 0x002AAFDC
			// (set) Token: 0x0600A329 RID: 41769 RVA: 0x00058245 File Offset: 0x00056445
			public unsafe InteractableArea selectedEntity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.__c__DisplayClass27_0.NativeFieldInfoPtr_selectedEntity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableArea>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.__c__DisplayClass27_0.NativeFieldInfoPtr_selectedEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040069A0 RID: 27040
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040069A1 RID: 27041
			private static readonly IntPtr NativeFieldInfoPtr_selectedEntity;

			// Token: 0x040069A2 RID: 27042
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040069A3 RID: 27043
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentFocusing_b__0_Internal_Single_InteractableArea_0;

			// Token: 0x040069A4 RID: 27044
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentFocusing_b__3_Internal_Void_0;
		}

		// Token: 0x0200078A RID: 1930
		[ObfuscatedName("DayScene.Input.DayScenePlayerInputGenerator+<<TryInteract>g__ExecuteDelayed|23_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600A32A RID: 41770 RVA: 0x002ACE0C File Offset: 0x002AB00C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique()
			{
				Il2CppClassPointerStore<DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DayScenePlayerInputGenerator>.NativeClassPtr, "<<TryInteract>g__ExecuteDelayed|23_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique>.NativeClassPtr);
				DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique>.NativeClassPtr, "<>1__state");
				DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique>.NativeClassPtr, "<>2__current");
				DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique>.NativeClassPtr, "<>4__this");
				DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique>.NativeClassPtr, 100670297);
				DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique>.NativeClassPtr, 100670298);
				DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique>.NativeClassPtr, 100670299);
				DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique>.NativeClassPtr, 100670300);
				DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique>.NativeClassPtr, 100670301);
				DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique>.NativeClassPtr, 100670302);
			}

			// Token: 0x0600A32B RID: 41771 RVA: 0x002ACEEC File Offset: 0x002AB0EC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A32C RID: 41772 RVA: 0x002ACF34 File Offset: 0x002AB134
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A32D RID: 41773 RVA: 0x002ACF68 File Offset: 0x002AB168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90987, XrefRangeEnd = 90988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170035D7 RID: 13783
			// (get) Token: 0x0600A32E RID: 41774 RVA: 0x002ACFA4 File Offset: 0x002AB1A4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A32F RID: 41775 RVA: 0x002ACFE4 File Offset: 0x002AB1E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90988, XrefRangeEnd = 90994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170035D8 RID: 13784
			// (get) Token: 0x0600A330 RID: 41776 RVA: 0x002AD018 File Offset: 0x002AB218
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A331 RID: 41777 RVA: 0x00058264 File Offset: 0x00056464
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035D4 RID: 13780
			// (get) Token: 0x0600A332 RID: 41778 RVA: 0x002AD058 File Offset: 0x002AB258
			// (set) Token: 0x0600A333 RID: 41779 RVA: 0x0005826D File Offset: 0x0005646D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170035D5 RID: 13781
			// (get) Token: 0x0600A334 RID: 41780 RVA: 0x002AD080 File Offset: 0x002AB280
			// (set) Token: 0x0600A335 RID: 41781 RVA: 0x00058288 File Offset: 0x00056488
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035D6 RID: 13782
			// (get) Token: 0x0600A336 RID: 41782 RVA: 0x002AD0B0 File Offset: 0x002AB2B0
			// (set) Token: 0x0600A337 RID: 41783 RVA: 0x000582A7 File Offset: 0x000564A7
			public unsafe DayScenePlayerInputGenerator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DayScenePlayerInputGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DayScenePlayerInputGenerator.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040069A5 RID: 27045
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040069A6 RID: 27046
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040069A7 RID: 27047
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040069A8 RID: 27048
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040069A9 RID: 27049
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040069AA RID: 27050
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040069AB RID: 27051
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040069AC RID: 27052
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040069AD RID: 27053
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
