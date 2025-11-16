using System;
using Cinemachine;
using Common.CharacterUtility;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.Input;
using DEYU.AssetHandleUtility;
using DEYU.Singletons;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

namespace Common
{
	// Token: 0x02000338 RID: 824
	public class SceneDirector : MonoSingletonPersistant<SceneDirector>
	{
		// Token: 0x0600620C RID: 25100 RVA: 0x001E5860 File Offset: 0x001E3A60
		// Note: this type is marked as 'beforefieldinit'.
		static SceneDirector()
		{
			Il2CppClassPointerStore<SceneDirector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common", "SceneDirector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr);
			SceneDirector.NativeFieldInfoPtr_OnEventPlayStatusUpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "OnEventPlayStatusUpdateCallback");
			SceneDirector.NativeFieldInfoPtr_s_WaitForFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "s_WaitForFixedUpdate");
			SceneDirector.NativeFieldInfoPtr_playableDirector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "playableDirector");
			SceneDirector.NativeFieldInfoPtr_spritesDefaultMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "spritesDefaultMaterial");
			SceneDirector.NativeFieldInfoPtr_spritesTransparentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "spritesTransparentMaterial");
			SceneDirector.NativeFieldInfoPtr_cachedOverrideScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "cachedOverrideScene");
			SceneDirector.NativeFieldInfoPtr_characterCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "characterCollection");
			SceneDirector.NativeFieldInfoPtr_m_SceneGC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "m_SceneGC");
			SceneDirector.NativeFieldInfoPtr_overlayCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "overlayCollection");
			SceneDirector.NativeFieldInfoPtr_unmanagedOverlayCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "unmanagedOverlayCollection");
			SceneDirector.NativeFieldInfoPtr_workingCoroutines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "workingCoroutines");
			SceneDirector.NativeFieldInfoPtr_unmanagedWorkingCoroutines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "unmanagedWorkingCoroutines");
			SceneDirector.NativeFieldInfoPtr_cinemachineVirtualCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "cinemachineVirtualCamera");
			SceneDirector.NativeFieldInfoPtr_cinemachinHardLockToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "cinemachinHardLockToTarget");
			SceneDirector.NativeFieldInfoPtr_currentActiveScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "currentActiveScene");
			SceneDirector.NativeFieldInfoPtr_sceneTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "sceneTracker");
			SceneDirector.NativeFieldInfoPtr__IsInEvent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<IsInEvent>k__BackingField");
			SceneDirector.NativeMethodInfoPtr_get_IsInEvent_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683849);
			SceneDirector.NativeMethodInfoPtr_set_IsInEvent_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683850);
			SceneDirector.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683851);
			SceneDirector.NativeMethodInfoPtr_GotoStaffScene_Public_Static_Void_StaffScenePlayBackIndicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683852);
			SceneDirector.NativeMethodInfoPtr_GotoStaffSceneAsync_Private_Static_UniTaskVoid_StaffScenePlayBackIndicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683853);
			SceneDirector.NativeMethodInfoPtr_DisposeMissionEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683854);
			SceneDirector.NativeMethodInfoPtr_ToggleEventState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683855);
			SceneDirector.NativeMethodInfoPtr_ExecuteEvent_Public_Void_Event_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683856);
			SceneDirector.NativeMethodInfoPtr_ExecuteEventImplAsync_Private_UniTask_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683857);
			SceneDirector.NativeMethodInfoPtr_ExecuteEventCoreAsync_Private_UniTask_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683858);
			SceneDirector.NativeMethodInfoPtr_PlayTimelineAsync_Private_UniTask_PlayableAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683859);
			SceneDirector.NativeMethodInfoPtr_EnableNoteAndStorageUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683860);
			SceneDirector.NativeMethodInfoPtr_DisableNoteAndStorageUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683861);
			SceneDirector.NativeMethodInfoPtr_RestorePlayerInput_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683862);
			SceneDirector.NativeMethodInfoPtr_DisablePlayerInput_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683863);
			SceneDirector.NativeMethodInfoPtr_SetMainScene_Public_Void_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683864);
			SceneDirector.NativeMethodInfoPtr_Initialize_Public_Void_CinemachineVirtualCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683865);
			SceneDirector.NativeMethodInfoPtr_SetPlayerCharacter_Public_Void_CharacterControllerUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683866);
			SceneDirector.NativeMethodInfoPtr_SwitchScene_Public_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683867);
			SceneDirector.NativeMethodInfoPtr_CleanCharacters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683868);
			SceneDirector.NativeMethodInfoPtr_UpdateCachedScenes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683869);
			SceneDirector.NativeMethodInfoPtr_CleanScenes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683870);
			SceneDirector.NativeMethodInfoPtr_SetCameraWorld_Public_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683871);
			SceneDirector.NativeMethodInfoPtr_SetFollowCameraWorld_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683872);
			SceneDirector.NativeMethodInfoPtr_ResetCameraWorld_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683873);
			SceneDirector.NativeMethodInfoPtr_SpawnCharacter_Public_Void_Identity_Int32_Vector2_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683874);
			SceneDirector.NativeMethodInfoPtr_SpawnCharacterByPosition_Public_Void_Identity_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683875);
			SceneDirector.NativeMethodInfoPtr_GiveItem_Public_Void_Il2CppReferenceArray_1_Product_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683876);
			SceneDirector.NativeMethodInfoPtr_RemoveItem_Public_Void_Il2CppReferenceArray_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683877);
			SceneDirector.NativeMethodInfoPtr_StopCharacterMovingProcess_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683878);
			SceneDirector.NativeMethodInfoPtr_StopAllMovingProcess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683879);
			SceneDirector.NativeMethodInfoPtr_StopAllUnmanagedMovingProcess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683880);
			SceneDirector.NativeMethodInfoPtr_MoveObject_Public_Void_String_Il2CppStructArray_1_Vector2_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683881);
			SceneDirector.NativeMethodInfoPtr_SetObjectFollowTarget_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683882);
			SceneDirector.NativeMethodInfoPtr_FollowTargetCoroutine_Private_IEnumerator_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683883);
			SceneDirector.NativeMethodInfoPtr_MoveCamera_Public_Void_Vector2_Il2CppStructArray_1_Vector2_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683884);
			SceneDirector.NativeMethodInfoPtr_RotateAroundCamera_Public_Void_Vector2_Vector2_Single_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683885);
			SceneDirector.NativeMethodInfoPtr_StartWorkCoroutine_Private_Void_String_Func_1_IEnumerator_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683886);
			SceneDirector.NativeMethodInfoPtr_MoveTo_Private_IEnumerator_Transform_Il2CppStructArray_1_Vector2_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683887);
			SceneDirector.NativeMethodInfoPtr_RotateAround_Private_IEnumerator_Transform_Vector2_Single_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683888);
			SceneDirector.NativeMethodInfoPtr_MoveCharacterAsync_Public_UniTask_String_Il2CppStructArray_1_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683889);
			SceneDirector.NativeMethodInfoPtr_MoveCharacter_Public_Void_String_Il2CppStructArray_1_Vector2_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683890);
			SceneDirector.NativeMethodInfoPtr_MoveCharacterNoAnimation_Public_Void_String_Il2CppStructArray_1_Vector2_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683891);
			SceneDirector.NativeMethodInfoPtr_CharacterJump_Public_Void_String_Single_Single_Single_Int32_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683892);
			SceneDirector.NativeMethodInfoPtr_CharacterJumpCoroutine_Public_IEnumerator_Transform_Single_Single_Single_Int32_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683893);
			SceneDirector.NativeMethodInfoPtr_CharacterRotationZ_Public_Void_String_Single_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683894);
			SceneDirector.NativeMethodInfoPtr_CharacterContinuousRotationZCoroutine_Private_IEnumerator_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683895);
			SceneDirector.NativeMethodInfoPtr_CharacterShake_Public_Void_String_Vector2_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683896);
			SceneDirector.NativeMethodInfoPtr_CharacterShakeUnmanaged_Public_Void_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683897);
			SceneDirector.NativeMethodInfoPtr_CharacterShakeCoroutine_Private_IEnumerator_Transform_Vector3_Vector2_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683898);
			SceneDirector.NativeMethodInfoPtr_CharacterShakeCoroutineExtern_Public_IEnumerator_Transform_Vector3_Vector2_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683899);
			SceneDirector.NativeMethodInfoPtr_SetCharacterVisualActive_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683900);
			SceneDirector.NativeMethodInfoPtr_RotateCharacter_Public_Void_String_CharacterRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683901);
			SceneDirector.NativeMethodInfoPtr_SetCharacterFace_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683902);
			SceneDirector.NativeMethodInfoPtr_RemoveCharacter_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683903);
			SceneDirector.NativeMethodInfoPtr_SetWorldOverlay_Public_Void_GameObject_String_String_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683904);
			SceneDirector.NativeMethodInfoPtr_SetWorldOverlay_Public_Void_GameObject_Vector2_String_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683905);
			SceneDirector.NativeMethodInfoPtr_TriggerWorldOverlayAnimation_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683906);
			SceneDirector.NativeMethodInfoPtr_RemoveWorldOverlay_Public_Void_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683907);
			SceneDirector.NativeMethodInfoPtr_OpenLockedPannel_Public_Void_GameObject_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683908);
			SceneDirector.NativeMethodInfoPtr_OpenLogicBranchUISelectionPanel_Public_Void_GameObject_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683909);
			SceneDirector.NativeMethodInfoPtr_Delay_Public_Void_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683910);
			SceneDirector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683911);
			SceneDirector.NativeMethodInfoPtr__CleanCharacters_b__39_1_Private_Void_KeyValuePair_2_String_CharacterControllerUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, 100683913);
		}

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x0600620D RID: 25101 RVA: 0x001E5EE4 File Offset: 0x001E40E4
		// (set) Token: 0x0600620E RID: 25102 RVA: 0x001E5F14 File Offset: 0x001E4114
		public unsafe static bool IsInEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253773, XrefRangeEnd = 253777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_get_IsInEvent_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253777, XrefRangeEnd = 253781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_set_IsInEvent_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x001E5F48 File Offset: 0x001E4148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253781, XrefRangeEnd = 253795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneDirector.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006210 RID: 25104 RVA: 0x001E5F84 File Offset: 0x001E4184
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 253803, RefRangeEnd = 253807, XrefRangeStart = 253795, XrefRangeEnd = 253803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoStaffScene(SceneDirector.StaffScenePlayBackIndicator playBackIndicator)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playBackIndicator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_GotoStaffScene_Public_Static_Void_StaffScenePlayBackIndicator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006211 RID: 25105 RVA: 0x001E5FB8 File Offset: 0x001E41B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253807, XrefRangeEnd = 253811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTaskVoid GotoStaffSceneAsync(SceneDirector.StaffScenePlayBackIndicator playBackIndicator)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playBackIndicator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_GotoStaffSceneAsync_Private_Static_UniTaskVoid_StaffScenePlayBackIndicator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006212 RID: 25106 RVA: 0x001E5FF8 File Offset: 0x001E41F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 253889, RefRangeEnd = 253893, XrefRangeStart = 253811, XrefRangeEnd = 253889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeMissionEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_DisposeMissionEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006213 RID: 25107 RVA: 0x001E602C File Offset: 0x001E422C
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 253913, RefRangeEnd = 253945, XrefRangeStart = 253893, XrefRangeEnd = 253913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleEventState(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_ToggleEventState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006214 RID: 25108 RVA: 0x001E606C File Offset: 0x001E426C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 253960, RefRangeEnd = 253973, XrefRangeStart = 253945, XrefRangeEnd = 253960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteEvent(SchedulerNode.Event eventData, Action onFinishCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(eventData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_ExecuteEvent_Public_Void_Event_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006215 RID: 25109 RVA: 0x001E60C8 File Offset: 0x001E42C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253973, XrefRangeEnd = 253980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask ExecuteEventImplAsync(SchedulerNode.Event eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(eventData));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_ExecuteEventImplAsync_Private_UniTask_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06006216 RID: 25110 RVA: 0x001E6118 File Offset: 0x001E4318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253980, XrefRangeEnd = 253987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask ExecuteEventCoreAsync(SchedulerNode.Event eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(eventData));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_ExecuteEventCoreAsync_Private_UniTask_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x001E6168 File Offset: 0x001E4368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253987, XrefRangeEnd = 253994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask PlayTimelineAsync(PlayableAsset playableAsset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playableAsset);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_PlayTimelineAsync_Private_UniTask_PlayableAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x001E61B0 File Offset: 0x001E43B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254004, RefRangeEnd = 254005, XrefRangeStart = 253994, XrefRangeEnd = 254004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableNoteAndStorageUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_EnableNoteAndStorageUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006219 RID: 25113 RVA: 0x001E61E4 File Offset: 0x001E43E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254015, RefRangeEnd = 254016, XrefRangeStart = 254005, XrefRangeEnd = 254015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableNoteAndStorageUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_DisableNoteAndStorageUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621A RID: 25114 RVA: 0x001E6218 File Offset: 0x001E4418
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 254020, RefRangeEnd = 254026, XrefRangeStart = 254016, XrefRangeEnd = 254020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestorePlayerInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_RestorePlayerInput_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621B RID: 25115 RVA: 0x001E624C File Offset: 0x001E444C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254030, RefRangeEnd = 254034, XrefRangeStart = 254026, XrefRangeEnd = 254030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisablePlayerInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_DisablePlayerInput_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621C RID: 25116 RVA: 0x001E6280 File Offset: 0x001E4480
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254044, RefRangeEnd = 254046, XrefRangeStart = 254034, XrefRangeEnd = 254044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMainScene(string mainSceneKey, GameObject mainScene)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainSceneKey);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mainScene);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_SetMainScene_Public_Void_String_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x001E62D4 File Offset: 0x001E44D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254056, RefRangeEnd = 254059, XrefRangeStart = 254046, XrefRangeEnd = 254056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(CinemachineVirtualCamera cinemachineVirtualCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cinemachineVirtualCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_Initialize_Public_Void_CinemachineVirtualCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x001E6318 File Offset: 0x001E4518
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254073, RefRangeEnd = 254076, XrefRangeStart = 254059, XrefRangeEnd = 254073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerCharacter(CharacterControllerUnit character)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_SetPlayerCharacter_Public_Void_CharacterControllerUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x001E635C File Offset: 0x001E455C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254096, RefRangeEnd = 254097, XrefRangeStart = 254076, XrefRangeEnd = 254096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchScene(GameObject targetScene, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetScene);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_SwitchScene_Public_Void_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x001E63B0 File Offset: 0x001E45B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254125, RefRangeEnd = 254126, XrefRangeStart = 254097, XrefRangeEnd = 254125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanCharacters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_CleanCharacters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x001E63E4 File Offset: 0x001E45E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254157, RefRangeEnd = 254158, XrefRangeStart = 254126, XrefRangeEnd = 254157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCachedScenes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_UpdateCachedScenes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x001E6418 File Offset: 0x001E4618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254182, RefRangeEnd = 254183, XrefRangeStart = 254158, XrefRangeEnd = 254182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanScenes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_CleanScenes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006223 RID: 25123 RVA: 0x001E644C File Offset: 0x001E464C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254185, RefRangeEnd = 254186, XrefRangeStart = 254183, XrefRangeEnd = 254185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraWorld(Vector2 position, float damping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_SetCameraWorld_Public_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x001E6498 File Offset: 0x001E4698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254191, RefRangeEnd = 254192, XrefRangeStart = 254186, XrefRangeEnd = 254191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFollowCameraWorld(string characterLabel, float damping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_SetFollowCameraWorld_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006225 RID: 25125 RVA: 0x001E64E8 File Offset: 0x001E46E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254199, RefRangeEnd = 254200, XrefRangeStart = 254192, XrefRangeEnd = 254199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCameraWorld()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_ResetCameraWorld_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006226 RID: 25126 RVA: 0x001E651C File Offset: 0x001E471C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 254251, RefRangeEnd = 254256, XrefRangeStart = 254200, XrefRangeEnd = 254251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnCharacter(SceneDirector.Identity characterType, int characterId, Vector2 startPosition, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref characterType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_SpawnCharacter_Public_Void_Identity_Int32_Vector2_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006227 RID: 25127 RVA: 0x001E658C File Offset: 0x001E478C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254256, XrefRangeEnd = 254262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnCharacterByPosition(SceneDirector.Identity characterType, int characterId, string characterLabel, string referencePositionCharacterLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref characterType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(referencePositionCharacterLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_SpawnCharacterByPosition_Public_Void_Identity_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006228 RID: 25128 RVA: 0x001E6600 File Offset: 0x001E4800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254276, RefRangeEnd = 254277, XrefRangeStart = 254262, XrefRangeEnd = 254276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GiveItem(Il2CppReferenceArray<Product> items, bool suppressCallbacks = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suppressCallbacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_GiveItem_Public_Void_Il2CppReferenceArray_1_Product_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x001E6650 File Offset: 0x001E4850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254287, RefRangeEnd = 254288, XrefRangeStart = 254277, XrefRangeEnd = 254287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(Il2CppReferenceArray<Product> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_RemoveItem_Public_Void_Il2CppReferenceArray_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600622A RID: 25130 RVA: 0x001E6694 File Offset: 0x001E4894
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 254294, RefRangeEnd = 254300, XrefRangeStart = 254288, XrefRangeEnd = 254294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCharacterMovingProcess(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_StopCharacterMovingProcess_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x001E66D8 File Offset: 0x001E48D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254325, RefRangeEnd = 254326, XrefRangeStart = 254300, XrefRangeEnd = 254325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllMovingProcess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_StopAllMovingProcess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600622C RID: 25132 RVA: 0x001E670C File Offset: 0x001E490C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254326, XrefRangeEnd = 254351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllUnmanagedMovingProcess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_StopAllUnmanagedMovingProcess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x001E6740 File Offset: 0x001E4940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254380, RefRangeEnd = 254381, XrefRangeStart = 254351, XrefRangeEnd = 254380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveObject(string label, Il2CppStructArray<Vector2> wayPoints, float speedMultiplier, Action onFinishCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wayPoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speedMultiplier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_MoveObject_Public_Void_String_Il2CppStructArray_1_Vector2_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600622E RID: 25134 RVA: 0x001E67B8 File Offset: 0x001E49B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254399, RefRangeEnd = 254400, XrefRangeStart = 254381, XrefRangeEnd = 254399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectFollowTarget(string label, string targetLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_SetObjectFollowTarget_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600622F RID: 25135 RVA: 0x001E680C File Offset: 0x001E4A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254400, XrefRangeEnd = 254406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FollowTargetCoroutine(Transform self, Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_FollowTargetCoroutine_Private_IEnumerator_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006230 RID: 25136 RVA: 0x001E6870 File Offset: 0x001E4A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254437, RefRangeEnd = 254438, XrefRangeStart = 254406, XrefRangeEnd = 254437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveCamera(Vector2 startPoint, Il2CppStructArray<Vector2> wayPoints, float speedMultiplier, Action onFinishCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wayPoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speedMultiplier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_MoveCamera_Public_Void_Vector2_Il2CppStructArray_1_Vector2_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006231 RID: 25137 RVA: 0x001E68E4 File Offset: 0x001E4AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254468, RefRangeEnd = 254469, XrefRangeStart = 254438, XrefRangeEnd = 254468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAroundCamera(Vector2 startPoint, Vector2 pivot, float angle, float speedMultiplier, Action onFinishCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speedMultiplier;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_RotateAroundCamera_Public_Void_Vector2_Vector2_Single_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006232 RID: 25138 RVA: 0x001E6960 File Offset: 0x001E4B60
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 254489, RefRangeEnd = 254497, XrefRangeStart = 254469, XrefRangeEnd = 254489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartWorkCoroutine(string label, Func<IEnumerator> executeCoroutine, Action onFinishCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(executeCoroutine);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_StartWorkCoroutine_Private_Void_String_Func_1_IEnumerator_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006233 RID: 25139 RVA: 0x001E69C8 File Offset: 0x001E4BC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254504, RefRangeEnd = 254507, XrefRangeStart = 254497, XrefRangeEnd = 254504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MoveTo(Transform entityTransform, Il2CppStructArray<Vector2> wayPoints, float speedMultiplier, Action onFinishCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityTransform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wayPoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speedMultiplier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_MoveTo_Private_IEnumerator_Transform_Il2CppStructArray_1_Vector2_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006234 RID: 25140 RVA: 0x001E6A4C File Offset: 0x001E4C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254507, XrefRangeEnd = 254513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RotateAround(Transform entityTransform, Vector2 pivot, float angle, float speedMultiplier, Action onFinishCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityTransform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speedMultiplier;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_RotateAround_Private_IEnumerator_Transform_Vector2_Single_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006235 RID: 25141 RVA: 0x001E6ADC File Offset: 0x001E4CDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254527, RefRangeEnd = 254528, XrefRangeStart = 254513, XrefRangeEnd = 254527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask MoveCharacterAsync(string label, Il2CppStructArray<Vector2> wayPoints, float speedMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wayPoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speedMultiplier;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_MoveCharacterAsync_Public_UniTask_String_Il2CppStructArray_1_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06006236 RID: 25142 RVA: 0x001E6B44 File Offset: 0x001E4D44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254562, RefRangeEnd = 254564, XrefRangeStart = 254528, XrefRangeEnd = 254562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveCharacter(string label, Il2CppStructArray<Vector2> wayPoints, float speedMultiplier, Action onFinishCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wayPoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speedMultiplier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_MoveCharacter_Public_Void_String_Il2CppStructArray_1_Vector2_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006237 RID: 25143 RVA: 0x001E6BBC File Offset: 0x001E4DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254564, XrefRangeEnd = 254593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveCharacterNoAnimation(string label, Il2CppStructArray<Vector2> wayPoints, float speedMultiplier, Action onFinished = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wayPoints);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speedMultiplier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinished);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_MoveCharacterNoAnimation_Public_Void_String_Il2CppStructArray_1_Vector2_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006238 RID: 25144 RVA: 0x001E6C34 File Offset: 0x001E4E34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254621, RefRangeEnd = 254622, XrefRangeStart = 254593, XrefRangeEnd = 254621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CharacterJump(string label, float startPoint, float jumpHeight, float gravity, int jumpCount = 1, float jumpInterval = 0.1f, Action onFinished = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gravity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpInterval;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinished);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_CharacterJump_Public_Void_String_Single_Single_Single_Int32_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006239 RID: 25145 RVA: 0x001E6CD0 File Offset: 0x001E4ED0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254628, RefRangeEnd = 254631, XrefRangeStart = 254622, XrefRangeEnd = 254628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CharacterJumpCoroutine(Transform transform, float startPoint, float jumpHeight, float gravity, int jumpCount = 1, float jumpInterval = 0.1f, Action onFinished = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gravity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpInterval;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinished);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_CharacterJumpCoroutine_Public_IEnumerator_Transform_Single_Single_Single_Int32_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600623A RID: 25146 RVA: 0x001E6D7C File Offset: 0x001E4F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254661, RefRangeEnd = 254662, XrefRangeStart = 254631, XrefRangeEnd = 254661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CharacterRotationZ(string label, float targetValue, bool isContinuous, Action onFinished = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isContinuous;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinished);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_CharacterRotationZ_Public_Void_String_Single_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600623B RID: 25147 RVA: 0x001E6DF0 File Offset: 0x001E4FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254662, XrefRangeEnd = 254667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CharacterContinuousRotationZCoroutine(Transform transform, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_CharacterContinuousRotationZCoroutine_Private_IEnumerator_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600623C RID: 25148 RVA: 0x001E6E50 File Offset: 0x001E5050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254700, RefRangeEnd = 254701, XrefRangeStart = 254667, XrefRangeEnd = 254700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CharacterShake(string label, Vector2 amplitude, float duration, Action onFinished = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amplitude;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinished);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_CharacterShake_Public_Void_String_Vector2_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600623D RID: 25149 RVA: 0x001E6EC4 File Offset: 0x001E50C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254736, RefRangeEnd = 254737, XrefRangeStart = 254701, XrefRangeEnd = 254736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CharacterShakeUnmanaged(string label, Vector2 amplitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amplitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_CharacterShakeUnmanaged_Public_Void_String_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600623E RID: 25150 RVA: 0x001E6F14 File Offset: 0x001E5114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254737, XrefRangeEnd = 254743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CharacterShakeCoroutine(Transform transform, Vector3 oldPosition, Vector2 amplitude, float duration, Action onFinished = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amplitude;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinished);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_CharacterShakeCoroutine_Private_IEnumerator_Transform_Vector3_Vector2_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600623F RID: 25151 RVA: 0x001E6FA4 File Offset: 0x001E51A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254749, RefRangeEnd = 254751, XrefRangeStart = 254743, XrefRangeEnd = 254749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CharacterShakeCoroutineExtern(Transform transform, Vector3 oldPosition, Vector2 amplitude, float duration, Action onFinished = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amplitude;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinished);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_CharacterShakeCoroutineExtern_Public_IEnumerator_Transform_Vector3_Vector2_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006240 RID: 25152 RVA: 0x001E7034 File Offset: 0x001E5234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254764, RefRangeEnd = 254765, XrefRangeStart = 254751, XrefRangeEnd = 254764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCharacterVisualActive(string label, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_SetCharacterVisualActive_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006241 RID: 25153 RVA: 0x001E7084 File Offset: 0x001E5284
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254769, RefRangeEnd = 254773, XrefRangeStart = 254765, XrefRangeEnd = 254769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateCharacter(string label, DayScenePlayerInputGenerator.CharacterRotation targetRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_RotateCharacter_Public_Void_String_CharacterRotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006242 RID: 25154 RVA: 0x001E70D4 File Offset: 0x001E52D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254777, RefRangeEnd = 254778, XrefRangeStart = 254773, XrefRangeEnd = 254777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCharacterFace(string label, int faceId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_SetCharacterFace_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006243 RID: 25155 RVA: 0x001E7124 File Offset: 0x001E5324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254789, RefRangeEnd = 254790, XrefRangeStart = 254778, XrefRangeEnd = 254789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCharacter(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_RemoveCharacter_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006244 RID: 25156 RVA: 0x001E7168 File Offset: 0x001E5368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254790, XrefRangeEnd = 254796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWorldOverlay(GameObject overlayGameObject, string characterLabel, string label, float transitionDuration, bool uiMode, bool tutorialMode, bool needToInstantiate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(overlayGameObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transitionDuration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uiMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tutorialMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needToInstantiate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_SetWorldOverlay_Public_Void_GameObject_String_String_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006245 RID: 25157 RVA: 0x001E7208 File Offset: 0x001E5408
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254837, RefRangeEnd = 254841, XrefRangeStart = 254796, XrefRangeEnd = 254837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWorldOverlay(GameObject overlayGameObject, Vector2 worldPosition, string label, float transitionDuration, bool uiMode, bool tutorialMode, bool needToInstantiate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(overlayGameObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transitionDuration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uiMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tutorialMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needToInstantiate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_SetWorldOverlay_Public_Void_GameObject_Vector2_String_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006246 RID: 25158 RVA: 0x001E72A4 File Offset: 0x001E54A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254848, RefRangeEnd = 254849, XrefRangeStart = 254841, XrefRangeEnd = 254848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerWorldOverlayAnimation(string label, string trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trigger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_TriggerWorldOverlayAnimation_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x001E72F8 File Offset: 0x001E54F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254889, RefRangeEnd = 254892, XrefRangeStart = 254849, XrefRangeEnd = 254889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveWorldOverlay(string label, float duration, bool needDestroy = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needDestroy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_RemoveWorldOverlay_Public_Void_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006248 RID: 25160 RVA: 0x001E7358 File Offset: 0x001E5558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254904, RefRangeEnd = 254905, XrefRangeStart = 254892, XrefRangeEnd = 254904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenLockedPannel(GameObject pannelObject, Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pannelObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_OpenLockedPannel_Public_Void_GameObject_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006249 RID: 25161 RVA: 0x001E73AC File Offset: 0x001E55AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254928, RefRangeEnd = 254929, XrefRangeStart = 254905, XrefRangeEnd = 254928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenLogicBranchUISelectionPanel(GameObject panelObject, Action<bool> onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(panelObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_OpenLogicBranchUISelectionPanel_Public_Void_GameObject_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600624A RID: 25162 RVA: 0x001E7400 File Offset: 0x001E5600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254941, RefRangeEnd = 254942, XrefRangeStart = 254929, XrefRangeEnd = 254941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delay(float seconds, Action onFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seconds;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr_Delay_Public_Void_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600624B RID: 25163 RVA: 0x001E7450 File Offset: 0x001E5650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254942, XrefRangeEnd = 254989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneDirector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600624C RID: 25164 RVA: 0x001E748C File Offset: 0x001E568C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254989, XrefRangeEnd = 255002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CleanCharacters_b__39_1(KeyValuePair<string, CharacterControllerUnit> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.NativeMethodInfoPtr__CleanCharacters_b__39_1_Private_Void_KeyValuePair_2_String_CharacterControllerUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600624D RID: 25165 RVA: 0x00035154 File Offset: 0x00033354
		public SceneDirector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x0600624E RID: 25166 RVA: 0x001E74D4 File Offset: 0x001E56D4
		// (set) Token: 0x0600624F RID: 25167 RVA: 0x0003515D File Offset: 0x0003335D
		public unsafe static Action<bool> OnEventPlayStatusUpdateCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneDirector.NativeFieldInfoPtr_OnEventPlayStatusUpdateCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneDirector.NativeFieldInfoPtr_OnEventPlayStatusUpdateCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x06006250 RID: 25168 RVA: 0x001E74FC File Offset: 0x001E56FC
		// (set) Token: 0x06006251 RID: 25169 RVA: 0x0003516F File Offset: 0x0003336F
		public unsafe static WaitForFixedUpdate s_WaitForFixedUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneDirector.NativeFieldInfoPtr_s_WaitForFixedUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForFixedUpdate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneDirector.NativeFieldInfoPtr_s_WaitForFixedUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x06006252 RID: 25170 RVA: 0x001E7524 File Offset: 0x001E5724
		// (set) Token: 0x06006253 RID: 25171 RVA: 0x00035181 File Offset: 0x00033381
		public unsafe PlayableDirector playableDirector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_playableDirector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableDirector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_playableDirector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x06006254 RID: 25172 RVA: 0x001E7554 File Offset: 0x001E5754
		// (set) Token: 0x06006255 RID: 25173 RVA: 0x000351A0 File Offset: 0x000333A0
		public unsafe Material spritesDefaultMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_spritesDefaultMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_spritesDefaultMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x06006256 RID: 25174 RVA: 0x001E7584 File Offset: 0x001E5784
		// (set) Token: 0x06006257 RID: 25175 RVA: 0x000351BF File Offset: 0x000333BF
		public unsafe Material spritesTransparentMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_spritesTransparentMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_spritesTransparentMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x06006258 RID: 25176 RVA: 0x001E75B4 File Offset: 0x001E57B4
		// (set) Token: 0x06006259 RID: 25177 RVA: 0x000351DE File Offset: 0x000333DE
		public unsafe Dictionary<string, GameObject> cachedOverrideScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_cachedOverrideScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_cachedOverrideScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x0600625A RID: 25178 RVA: 0x001E75E4 File Offset: 0x001E57E4
		// (set) Token: 0x0600625B RID: 25179 RVA: 0x000351FD File Offset: 0x000333FD
		public unsafe Dictionary<string, CharacterControllerUnit> characterCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_characterCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CharacterControllerUnit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_characterCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x0600625C RID: 25180 RVA: 0x001E7614 File Offset: 0x001E5814
		// (set) Token: 0x0600625D RID: 25181 RVA: 0x0003521C File Offset: 0x0003341C
		public unsafe Stack<string> m_SceneGC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_m_SceneGC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_m_SceneGC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x0600625E RID: 25182 RVA: 0x001E7644 File Offset: 0x001E5844
		// (set) Token: 0x0600625F RID: 25183 RVA: 0x0003523B File Offset: 0x0003343B
		public unsafe Dictionary<string, GameObject> overlayCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_overlayCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_overlayCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x06006260 RID: 25184 RVA: 0x001E7674 File Offset: 0x001E5874
		// (set) Token: 0x06006261 RID: 25185 RVA: 0x0003525A File Offset: 0x0003345A
		public unsafe Dictionary<string, GameObject> unmanagedOverlayCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_unmanagedOverlayCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_unmanagedOverlayCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x06006262 RID: 25186 RVA: 0x001E76A4 File Offset: 0x001E58A4
		// (set) Token: 0x06006263 RID: 25187 RVA: 0x00035279 File Offset: 0x00033479
		public unsafe Dictionary<string, Action> workingCoroutines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_workingCoroutines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_workingCoroutines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x06006264 RID: 25188 RVA: 0x001E76D4 File Offset: 0x001E58D4
		// (set) Token: 0x06006265 RID: 25189 RVA: 0x00035298 File Offset: 0x00033498
		public unsafe Dictionary<string, Action> unmanagedWorkingCoroutines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_unmanagedWorkingCoroutines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Action>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_unmanagedWorkingCoroutines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x06006266 RID: 25190 RVA: 0x001E7704 File Offset: 0x001E5904
		// (set) Token: 0x06006267 RID: 25191 RVA: 0x000352B7 File Offset: 0x000334B7
		public unsafe CinemachineVirtualCamera cinemachineVirtualCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_cinemachineVirtualCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CinemachineVirtualCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_cinemachineVirtualCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x06006268 RID: 25192 RVA: 0x001E7734 File Offset: 0x001E5934
		// (set) Token: 0x06006269 RID: 25193 RVA: 0x000352D6 File Offset: 0x000334D6
		public unsafe CinemachineHardLockToTarget cinemachinHardLockToTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_cinemachinHardLockToTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CinemachineHardLockToTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_cinemachinHardLockToTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x0600626A RID: 25194 RVA: 0x001E7764 File Offset: 0x001E5964
		// (set) Token: 0x0600626B RID: 25195 RVA: 0x000352F5 File Offset: 0x000334F5
		public KeyValuePair<string, GameObject> currentActiveScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_currentActiveScene);
				return new KeyValuePair<string, GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, GameObject>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_currentActiveScene), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, GameObject>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x0600626C RID: 25196 RVA: 0x001E7794 File Offset: 0x001E5994
		// (set) Token: 0x0600626D RID: 25197 RVA: 0x00035323 File Offset: 0x00033523
		public unsafe Transform sceneTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_sceneTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.NativeFieldInfoPtr_sceneTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x0600626E RID: 25198 RVA: 0x001E77C4 File Offset: 0x001E59C4
		// (set) Token: 0x0600626F RID: 25199 RVA: 0x00035342 File Offset: 0x00033542
		public unsafe static bool _IsInEvent_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SceneDirector.NativeFieldInfoPtr__IsInEvent_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneDirector.NativeFieldInfoPtr__IsInEvent_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x040040F1 RID: 16625
		private static readonly IntPtr NativeFieldInfoPtr_OnEventPlayStatusUpdateCallback;

		// Token: 0x040040F2 RID: 16626
		private static readonly IntPtr NativeFieldInfoPtr_s_WaitForFixedUpdate;

		// Token: 0x040040F3 RID: 16627
		private static readonly IntPtr NativeFieldInfoPtr_playableDirector;

		// Token: 0x040040F4 RID: 16628
		private static readonly IntPtr NativeFieldInfoPtr_spritesDefaultMaterial;

		// Token: 0x040040F5 RID: 16629
		private static readonly IntPtr NativeFieldInfoPtr_spritesTransparentMaterial;

		// Token: 0x040040F6 RID: 16630
		private static readonly IntPtr NativeFieldInfoPtr_cachedOverrideScene;

		// Token: 0x040040F7 RID: 16631
		private static readonly IntPtr NativeFieldInfoPtr_characterCollection;

		// Token: 0x040040F8 RID: 16632
		private static readonly IntPtr NativeFieldInfoPtr_m_SceneGC;

		// Token: 0x040040F9 RID: 16633
		private static readonly IntPtr NativeFieldInfoPtr_overlayCollection;

		// Token: 0x040040FA RID: 16634
		private static readonly IntPtr NativeFieldInfoPtr_unmanagedOverlayCollection;

		// Token: 0x040040FB RID: 16635
		private static readonly IntPtr NativeFieldInfoPtr_workingCoroutines;

		// Token: 0x040040FC RID: 16636
		private static readonly IntPtr NativeFieldInfoPtr_unmanagedWorkingCoroutines;

		// Token: 0x040040FD RID: 16637
		private static readonly IntPtr NativeFieldInfoPtr_cinemachineVirtualCamera;

		// Token: 0x040040FE RID: 16638
		private static readonly IntPtr NativeFieldInfoPtr_cinemachinHardLockToTarget;

		// Token: 0x040040FF RID: 16639
		private static readonly IntPtr NativeFieldInfoPtr_currentActiveScene;

		// Token: 0x04004100 RID: 16640
		private static readonly IntPtr NativeFieldInfoPtr_sceneTracker;

		// Token: 0x04004101 RID: 16641
		private static readonly IntPtr NativeFieldInfoPtr__IsInEvent_k__BackingField;

		// Token: 0x04004102 RID: 16642
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInEvent_Public_Static_get_Boolean_0;

		// Token: 0x04004103 RID: 16643
		private static readonly IntPtr NativeMethodInfoPtr_set_IsInEvent_Private_Static_set_Void_Boolean_0;

		// Token: 0x04004104 RID: 16644
		private static readonly IntPtr NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0;

		// Token: 0x04004105 RID: 16645
		private static readonly IntPtr NativeMethodInfoPtr_GotoStaffScene_Public_Static_Void_StaffScenePlayBackIndicator_0;

		// Token: 0x04004106 RID: 16646
		private static readonly IntPtr NativeMethodInfoPtr_GotoStaffSceneAsync_Private_Static_UniTaskVoid_StaffScenePlayBackIndicator_0;

		// Token: 0x04004107 RID: 16647
		private static readonly IntPtr NativeMethodInfoPtr_DisposeMissionEvents_Public_Void_0;

		// Token: 0x04004108 RID: 16648
		private static readonly IntPtr NativeMethodInfoPtr_ToggleEventState_Public_Void_Boolean_0;

		// Token: 0x04004109 RID: 16649
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteEvent_Public_Void_Event_Action_0;

		// Token: 0x0400410A RID: 16650
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteEventImplAsync_Private_UniTask_Event_0;

		// Token: 0x0400410B RID: 16651
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteEventCoreAsync_Private_UniTask_Event_0;

		// Token: 0x0400410C RID: 16652
		private static readonly IntPtr NativeMethodInfoPtr_PlayTimelineAsync_Private_UniTask_PlayableAsset_0;

		// Token: 0x0400410D RID: 16653
		private static readonly IntPtr NativeMethodInfoPtr_EnableNoteAndStorageUI_Public_Void_0;

		// Token: 0x0400410E RID: 16654
		private static readonly IntPtr NativeMethodInfoPtr_DisableNoteAndStorageUI_Public_Void_0;

		// Token: 0x0400410F RID: 16655
		private static readonly IntPtr NativeMethodInfoPtr_RestorePlayerInput_Public_Void_0;

		// Token: 0x04004110 RID: 16656
		private static readonly IntPtr NativeMethodInfoPtr_DisablePlayerInput_Public_Void_0;

		// Token: 0x04004111 RID: 16657
		private static readonly IntPtr NativeMethodInfoPtr_SetMainScene_Public_Void_String_GameObject_0;

		// Token: 0x04004112 RID: 16658
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_CinemachineVirtualCamera_0;

		// Token: 0x04004113 RID: 16659
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerCharacter_Public_Void_CharacterControllerUnit_0;

		// Token: 0x04004114 RID: 16660
		private static readonly IntPtr NativeMethodInfoPtr_SwitchScene_Public_Void_GameObject_String_0;

		// Token: 0x04004115 RID: 16661
		private static readonly IntPtr NativeMethodInfoPtr_CleanCharacters_Public_Void_0;

		// Token: 0x04004116 RID: 16662
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCachedScenes_Public_Void_0;

		// Token: 0x04004117 RID: 16663
		private static readonly IntPtr NativeMethodInfoPtr_CleanScenes_Public_Void_0;

		// Token: 0x04004118 RID: 16664
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraWorld_Public_Void_Vector2_Single_0;

		// Token: 0x04004119 RID: 16665
		private static readonly IntPtr NativeMethodInfoPtr_SetFollowCameraWorld_Public_Void_String_Single_0;

		// Token: 0x0400411A RID: 16666
		private static readonly IntPtr NativeMethodInfoPtr_ResetCameraWorld_Public_Void_0;

		// Token: 0x0400411B RID: 16667
		private static readonly IntPtr NativeMethodInfoPtr_SpawnCharacter_Public_Void_Identity_Int32_Vector2_String_0;

		// Token: 0x0400411C RID: 16668
		private static readonly IntPtr NativeMethodInfoPtr_SpawnCharacterByPosition_Public_Void_Identity_Int32_String_String_0;

		// Token: 0x0400411D RID: 16669
		private static readonly IntPtr NativeMethodInfoPtr_GiveItem_Public_Void_Il2CppReferenceArray_1_Product_Boolean_0;

		// Token: 0x0400411E RID: 16670
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_Il2CppReferenceArray_1_Product_0;

		// Token: 0x0400411F RID: 16671
		private static readonly IntPtr NativeMethodInfoPtr_StopCharacterMovingProcess_Public_Void_String_0;

		// Token: 0x04004120 RID: 16672
		private static readonly IntPtr NativeMethodInfoPtr_StopAllMovingProcess_Public_Void_0;

		// Token: 0x04004121 RID: 16673
		private static readonly IntPtr NativeMethodInfoPtr_StopAllUnmanagedMovingProcess_Public_Void_0;

		// Token: 0x04004122 RID: 16674
		private static readonly IntPtr NativeMethodInfoPtr_MoveObject_Public_Void_String_Il2CppStructArray_1_Vector2_Single_Action_0;

		// Token: 0x04004123 RID: 16675
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectFollowTarget_Public_Void_String_String_0;

		// Token: 0x04004124 RID: 16676
		private static readonly IntPtr NativeMethodInfoPtr_FollowTargetCoroutine_Private_IEnumerator_Transform_Transform_0;

		// Token: 0x04004125 RID: 16677
		private static readonly IntPtr NativeMethodInfoPtr_MoveCamera_Public_Void_Vector2_Il2CppStructArray_1_Vector2_Single_Action_0;

		// Token: 0x04004126 RID: 16678
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundCamera_Public_Void_Vector2_Vector2_Single_Single_Action_0;

		// Token: 0x04004127 RID: 16679
		private static readonly IntPtr NativeMethodInfoPtr_StartWorkCoroutine_Private_Void_String_Func_1_IEnumerator_Action_0;

		// Token: 0x04004128 RID: 16680
		private static readonly IntPtr NativeMethodInfoPtr_MoveTo_Private_IEnumerator_Transform_Il2CppStructArray_1_Vector2_Single_Action_0;

		// Token: 0x04004129 RID: 16681
		private static readonly IntPtr NativeMethodInfoPtr_RotateAround_Private_IEnumerator_Transform_Vector2_Single_Single_Action_0;

		// Token: 0x0400412A RID: 16682
		private static readonly IntPtr NativeMethodInfoPtr_MoveCharacterAsync_Public_UniTask_String_Il2CppStructArray_1_Vector2_Single_0;

		// Token: 0x0400412B RID: 16683
		private static readonly IntPtr NativeMethodInfoPtr_MoveCharacter_Public_Void_String_Il2CppStructArray_1_Vector2_Single_Action_0;

		// Token: 0x0400412C RID: 16684
		private static readonly IntPtr NativeMethodInfoPtr_MoveCharacterNoAnimation_Public_Void_String_Il2CppStructArray_1_Vector2_Single_Action_0;

		// Token: 0x0400412D RID: 16685
		private static readonly IntPtr NativeMethodInfoPtr_CharacterJump_Public_Void_String_Single_Single_Single_Int32_Single_Action_0;

		// Token: 0x0400412E RID: 16686
		private static readonly IntPtr NativeMethodInfoPtr_CharacterJumpCoroutine_Public_IEnumerator_Transform_Single_Single_Single_Int32_Single_Action_0;

		// Token: 0x0400412F RID: 16687
		private static readonly IntPtr NativeMethodInfoPtr_CharacterRotationZ_Public_Void_String_Single_Boolean_Action_0;

		// Token: 0x04004130 RID: 16688
		private static readonly IntPtr NativeMethodInfoPtr_CharacterContinuousRotationZCoroutine_Private_IEnumerator_Transform_Single_0;

		// Token: 0x04004131 RID: 16689
		private static readonly IntPtr NativeMethodInfoPtr_CharacterShake_Public_Void_String_Vector2_Single_Action_0;

		// Token: 0x04004132 RID: 16690
		private static readonly IntPtr NativeMethodInfoPtr_CharacterShakeUnmanaged_Public_Void_String_Vector2_0;

		// Token: 0x04004133 RID: 16691
		private static readonly IntPtr NativeMethodInfoPtr_CharacterShakeCoroutine_Private_IEnumerator_Transform_Vector3_Vector2_Single_Action_0;

		// Token: 0x04004134 RID: 16692
		private static readonly IntPtr NativeMethodInfoPtr_CharacterShakeCoroutineExtern_Public_IEnumerator_Transform_Vector3_Vector2_Single_Action_0;

		// Token: 0x04004135 RID: 16693
		private static readonly IntPtr NativeMethodInfoPtr_SetCharacterVisualActive_Public_Void_String_Boolean_0;

		// Token: 0x04004136 RID: 16694
		private static readonly IntPtr NativeMethodInfoPtr_RotateCharacter_Public_Void_String_CharacterRotation_0;

		// Token: 0x04004137 RID: 16695
		private static readonly IntPtr NativeMethodInfoPtr_SetCharacterFace_Public_Void_String_Int32_0;

		// Token: 0x04004138 RID: 16696
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCharacter_Public_Void_String_0;

		// Token: 0x04004139 RID: 16697
		private static readonly IntPtr NativeMethodInfoPtr_SetWorldOverlay_Public_Void_GameObject_String_String_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x0400413A RID: 16698
		private static readonly IntPtr NativeMethodInfoPtr_SetWorldOverlay_Public_Void_GameObject_Vector2_String_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x0400413B RID: 16699
		private static readonly IntPtr NativeMethodInfoPtr_TriggerWorldOverlayAnimation_Public_Void_String_String_0;

		// Token: 0x0400413C RID: 16700
		private static readonly IntPtr NativeMethodInfoPtr_RemoveWorldOverlay_Public_Void_String_Single_Boolean_0;

		// Token: 0x0400413D RID: 16701
		private static readonly IntPtr NativeMethodInfoPtr_OpenLockedPannel_Public_Void_GameObject_Action_0;

		// Token: 0x0400413E RID: 16702
		private static readonly IntPtr NativeMethodInfoPtr_OpenLogicBranchUISelectionPanel_Public_Void_GameObject_Action_1_Boolean_0;

		// Token: 0x0400413F RID: 16703
		private static readonly IntPtr NativeMethodInfoPtr_Delay_Public_Void_Single_Action_0;

		// Token: 0x04004140 RID: 16704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004141 RID: 16705
		private static readonly IntPtr NativeMethodInfoPtr__CleanCharacters_b__39_1_Private_Void_KeyValuePair_2_String_CharacterControllerUnit_0;

		// Token: 0x02000DD0 RID: 3536
		public enum Identity
		{
			// Token: 0x0400A243 RID: 41539
			Special,
			// Token: 0x0400A244 RID: 41540
			Normal
		}

		// Token: 0x02000DD1 RID: 3537
		public enum StaffScenePlayBackIndicator
		{
			// Token: 0x0400A246 RID: 41542
			Core_Normal,
			// Token: 0x0400A247 RID: 41543
			Core_True,
			// Token: 0x0400A248 RID: 41544
			DLC1,
			// Token: 0x0400A249 RID: 41545
			DLC2,
			// Token: 0x0400A24A RID: 41546
			DLC3,
			// Token: 0x0400A24B RID: 41547
			DLC4,
			// Token: 0x0400A24C RID: 41548
			DLC5
		}

		// Token: 0x02000DD2 RID: 3538
		public class RuntimeHandle<T> : Il2CppSystem.Object where T : UnityEngine.Object
		{
			// Token: 0x0600FF85 RID: 65413 RVA: 0x003BC7A4 File Offset: 0x003BA9A4
			// Note: this type is marked as 'beforefieldinit'.
			static RuntimeHandle()
			{
				Il2CppClassPointerStore<SceneDirector.RuntimeHandle<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "RuntimeHandle`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.RuntimeHandle<T>>.NativeClassPtr);
				SceneDirector.RuntimeHandle<T>.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.RuntimeHandle<T>>.NativeClassPtr, "<Asset>k__BackingField");
				SceneDirector.RuntimeHandle<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.RuntimeHandle<T>>.NativeClassPtr, 100683914);
				SceneDirector.RuntimeHandle<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.RuntimeHandle<T>>.NativeClassPtr, 100683915);
				SceneDirector.RuntimeHandle<T>.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.RuntimeHandle<T>>.NativeClassPtr, 100683916);
				SceneDirector.RuntimeHandle<T>.NativeMethodInfoPtr_get_IsPersistentAsset_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.RuntimeHandle<T>>.NativeClassPtr, 100683917);
			}

			// Token: 0x0600FF86 RID: 65414 RVA: 0x003BC870 File Offset: 0x003BAA70
			[CallerCount(109)]
			[CachedScanResults(RefRangeStart = 60056, RefRangeEnd = 60165, XrefRangeStart = 60056, XrefRangeEnd = 60165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RuntimeHandle(T asset) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.RuntimeHandle<T>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = asset;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref asset;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SceneDirector.RuntimeHandle<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x0600FF87 RID: 65415 RVA: 0x003BC8F4 File Offset: 0x003BAAF4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.RuntimeHandle<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700536D RID: 21357
			// (get) Token: 0x0600FF88 RID: 65416 RVA: 0x003BC928 File Offset: 0x003BAB28
			public unsafe virtual T Asset
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.RuntimeHandle<T>.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x1700536E RID: 21358
			// (get) Token: 0x0600FF89 RID: 65417 RVA: 0x003BC964 File Offset: 0x003BAB64
			public unsafe virtual bool IsPersistentAsset
			{
				[CallerCount(19)]
				[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.RuntimeHandle<T>.NativeMethodInfoPtr_get_IsPersistentAsset_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600FF8A RID: 65418 RVA: 0x0008AAD3 File Offset: 0x00088CD3
			public RuntimeHandle(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700536C RID: 21356
			// (get) Token: 0x0600FF8B RID: 65419 RVA: 0x003BC9A0 File Offset: 0x003BABA0
			// (set) Token: 0x0600FF8C RID: 65420 RVA: 0x003BC9C8 File Offset: 0x003BABC8
			public unsafe T _Asset_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.RuntimeHandle<T>.NativeFieldInfoPtr__Asset_k__BackingField);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.RuntimeHandle<T>.NativeFieldInfoPtr__Asset_k__BackingField);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x0400A24D RID: 41549
			private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

			// Token: 0x0400A24E RID: 41550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

			// Token: 0x0400A24F RID: 41551
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400A250 RID: 41552
			private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_T_0;

			// Token: 0x0400A251 RID: 41553
			private static readonly IntPtr NativeMethodInfoPtr_get_IsPersistentAsset_Public_Virtual_Final_New_get_Boolean_0;
		}

		// Token: 0x02000DD3 RID: 3539
		[ObfuscatedName("Common.SceneDirector+<GotoStaffSceneAsync>d__24")]
		public sealed class _GotoStaffSceneAsync_d__24 : ValueType
		{
			// Token: 0x0600FF8D RID: 65421 RVA: 0x003BCA70 File Offset: 0x003BAC70
			// Note: this type is marked as 'beforefieldinit'.
			static _GotoStaffSceneAsync_d__24()
			{
				Il2CppClassPointerStore<SceneDirector._GotoStaffSceneAsync_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<GotoStaffSceneAsync>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector._GotoStaffSceneAsync_d__24>.NativeClassPtr);
				SceneDirector._GotoStaffSceneAsync_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._GotoStaffSceneAsync_d__24>.NativeClassPtr, "<>1__state");
				SceneDirector._GotoStaffSceneAsync_d__24.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._GotoStaffSceneAsync_d__24>.NativeClassPtr, "<>t__builder");
				SceneDirector._GotoStaffSceneAsync_d__24.NativeFieldInfoPtr_playBackIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._GotoStaffSceneAsync_d__24>.NativeClassPtr, "playBackIndicator");
				SceneDirector._GotoStaffSceneAsync_d__24.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._GotoStaffSceneAsync_d__24>.NativeClassPtr, "<>u__1");
				SceneDirector._GotoStaffSceneAsync_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._GotoStaffSceneAsync_d__24>.NativeClassPtr, 100683918);
				SceneDirector._GotoStaffSceneAsync_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._GotoStaffSceneAsync_d__24>.NativeClassPtr, 100683919);
			}

			// Token: 0x0600FF8E RID: 65422 RVA: 0x003BCB14 File Offset: 0x003BAD14
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 253215, RefRangeEnd = 253217, XrefRangeStart = 253187, XrefRangeEnd = 253215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._GotoStaffSceneAsync_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FF8F RID: 65423 RVA: 0x003BCB4C File Offset: 0x003BAD4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._GotoStaffSceneAsync_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FF90 RID: 65424 RVA: 0x0008AADC File Offset: 0x00088CDC
			public _GotoStaffSceneAsync_d__24(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600FF91 RID: 65425 RVA: 0x0008AAE5 File Offset: 0x00088CE5
			public _GotoStaffSceneAsync_d__24() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector._GotoStaffSceneAsync_d__24>.NativeClassPtr))
			{
			}

			// Token: 0x1700536F RID: 21359
			// (get) Token: 0x0600FF92 RID: 65426 RVA: 0x003BCB94 File Offset: 0x003BAD94
			// (set) Token: 0x0600FF93 RID: 65427 RVA: 0x0008AAF7 File Offset: 0x00088CF7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._GotoStaffSceneAsync_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._GotoStaffSceneAsync_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005370 RID: 21360
			// (get) Token: 0x0600FF94 RID: 65428 RVA: 0x003BCBBC File Offset: 0x003BADBC
			// (set) Token: 0x0600FF95 RID: 65429 RVA: 0x0008AB12 File Offset: 0x00088D12
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._GotoStaffSceneAsync_d__24.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._GotoStaffSceneAsync_d__24.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005371 RID: 21361
			// (get) Token: 0x0600FF96 RID: 65430 RVA: 0x003BCBEC File Offset: 0x003BADEC
			// (set) Token: 0x0600FF97 RID: 65431 RVA: 0x0008AB40 File Offset: 0x00088D40
			public unsafe SceneDirector.StaffScenePlayBackIndicator playBackIndicator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._GotoStaffSceneAsync_d__24.NativeFieldInfoPtr_playBackIndicator);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._GotoStaffSceneAsync_d__24.NativeFieldInfoPtr_playBackIndicator)) = value;
				}
			}

			// Token: 0x17005372 RID: 21362
			// (get) Token: 0x0600FF98 RID: 65432 RVA: 0x003BCC14 File Offset: 0x003BAE14
			// (set) Token: 0x0600FF99 RID: 65433 RVA: 0x0008AB5B File Offset: 0x00088D5B
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._GotoStaffSceneAsync_d__24.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._GotoStaffSceneAsync_d__24.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A252 RID: 41554
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A253 RID: 41555
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A254 RID: 41556
			private static readonly IntPtr NativeFieldInfoPtr_playBackIndicator;

			// Token: 0x0400A255 RID: 41557
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A256 RID: 41558
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A257 RID: 41559
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000DD4 RID: 3540
		[ObfuscatedName("Common.SceneDirector+<ExecuteEventImplAsync>d__28")]
		public sealed class _ExecuteEventImplAsync_d__28 : ValueType
		{
			// Token: 0x0600FF9A RID: 65434 RVA: 0x003BCC44 File Offset: 0x003BAE44
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteEventImplAsync_d__28()
			{
				Il2CppClassPointerStore<SceneDirector._ExecuteEventImplAsync_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<ExecuteEventImplAsync>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector._ExecuteEventImplAsync_d__28>.NativeClassPtr);
				SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventImplAsync_d__28>.NativeClassPtr, "<>1__state");
				SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventImplAsync_d__28>.NativeClassPtr, "<>t__builder");
				SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventImplAsync_d__28>.NativeClassPtr, "<>4__this");
				SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventImplAsync_d__28>.NativeClassPtr, "eventData");
				SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventImplAsync_d__28>.NativeClassPtr, "<>u__1");
				SceneDirector._ExecuteEventImplAsync_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._ExecuteEventImplAsync_d__28>.NativeClassPtr, 100683920);
				SceneDirector._ExecuteEventImplAsync_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._ExecuteEventImplAsync_d__28>.NativeClassPtr, 100683921);
			}

			// Token: 0x0600FF9B RID: 65435 RVA: 0x003BCCFC File Offset: 0x003BAEFC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 253266, RefRangeEnd = 253269, XrefRangeStart = 253217, XrefRangeEnd = 253266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._ExecuteEventImplAsync_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FF9C RID: 65436 RVA: 0x003BCD34 File Offset: 0x003BAF34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._ExecuteEventImplAsync_d__28.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FF9D RID: 65437 RVA: 0x0008AB89 File Offset: 0x00088D89
			public _ExecuteEventImplAsync_d__28(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600FF9E RID: 65438 RVA: 0x0008AB92 File Offset: 0x00088D92
			public _ExecuteEventImplAsync_d__28() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector._ExecuteEventImplAsync_d__28>.NativeClassPtr))
			{
			}

			// Token: 0x17005373 RID: 21363
			// (get) Token: 0x0600FF9F RID: 65439 RVA: 0x003BCD7C File Offset: 0x003BAF7C
			// (set) Token: 0x0600FFA0 RID: 65440 RVA: 0x0008ABA4 File Offset: 0x00088DA4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005374 RID: 21364
			// (get) Token: 0x0600FFA1 RID: 65441 RVA: 0x003BCDA4 File Offset: 0x003BAFA4
			// (set) Token: 0x0600FFA2 RID: 65442 RVA: 0x0008ABBF File Offset: 0x00088DBF
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005375 RID: 21365
			// (get) Token: 0x0600FFA3 RID: 65443 RVA: 0x003BCDD4 File Offset: 0x003BAFD4
			// (set) Token: 0x0600FFA4 RID: 65444 RVA: 0x0008ABED File Offset: 0x00088DED
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005376 RID: 21366
			// (get) Token: 0x0600FFA5 RID: 65445 RVA: 0x003BCE04 File Offset: 0x003BB004
			// (set) Token: 0x0600FFA6 RID: 65446 RVA: 0x0008AC0C File Offset: 0x00088E0C
			public SchedulerNode.Event eventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr_eventData);
					return new SchedulerNode.Event(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr_eventData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005377 RID: 21367
			// (get) Token: 0x0600FFA7 RID: 65447 RVA: 0x003BCE34 File Offset: 0x003BB034
			// (set) Token: 0x0600FFA8 RID: 65448 RVA: 0x0008AC3A File Offset: 0x00088E3A
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventImplAsync_d__28.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A258 RID: 41560
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A259 RID: 41561
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A25A RID: 41562
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A25B RID: 41563
			private static readonly IntPtr NativeFieldInfoPtr_eventData;

			// Token: 0x0400A25C RID: 41564
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A25D RID: 41565
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A25E RID: 41566
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000DD5 RID: 3541
		[ObfuscatedName("Common.SceneDirector+<ExecuteEventCoreAsync>d__29")]
		public sealed class _ExecuteEventCoreAsync_d__29 : ValueType
		{
			// Token: 0x0600FFA9 RID: 65449 RVA: 0x003BCE64 File Offset: 0x003BB064
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteEventCoreAsync_d__29()
			{
				Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<ExecuteEventCoreAsync>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr);
				SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr, "<>1__state");
				SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr, "<>t__builder");
				SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr, "eventData");
				SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr, "<>4__this");
				SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr__loadedTimeline_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr, "<loadedTimeline>5__2");
				SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr__loadedDialogPackage_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr, "<loadedDialogPackage>5__3");
				SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr, "<>u__1");
				SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr, "<>u__2");
				SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr, "<>u__3");
				SceneDirector._ExecuteEventCoreAsync_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr, 100683922);
				SceneDirector._ExecuteEventCoreAsync_d__29.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr, 100683923);
			}

			// Token: 0x0600FFAA RID: 65450 RVA: 0x003BCF6C File Offset: 0x003BB16C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 253469, RefRangeEnd = 253472, XrefRangeStart = 253269, XrefRangeEnd = 253469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._ExecuteEventCoreAsync_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFAB RID: 65451 RVA: 0x003BCFA4 File Offset: 0x003BB1A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._ExecuteEventCoreAsync_d__29.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFAC RID: 65452 RVA: 0x0008AC68 File Offset: 0x00088E68
			public _ExecuteEventCoreAsync_d__29(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600FFAD RID: 65453 RVA: 0x0008AC71 File Offset: 0x00088E71
			public _ExecuteEventCoreAsync_d__29() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector._ExecuteEventCoreAsync_d__29>.NativeClassPtr))
			{
			}

			// Token: 0x17005378 RID: 21368
			// (get) Token: 0x0600FFAE RID: 65454 RVA: 0x003BCFEC File Offset: 0x003BB1EC
			// (set) Token: 0x0600FFAF RID: 65455 RVA: 0x0008AC83 File Offset: 0x00088E83
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005379 RID: 21369
			// (get) Token: 0x0600FFB0 RID: 65456 RVA: 0x003BD014 File Offset: 0x003BB214
			// (set) Token: 0x0600FFB1 RID: 65457 RVA: 0x0008AC9E File Offset: 0x00088E9E
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700537A RID: 21370
			// (get) Token: 0x0600FFB2 RID: 65458 RVA: 0x003BD044 File Offset: 0x003BB244
			// (set) Token: 0x0600FFB3 RID: 65459 RVA: 0x0008ACCC File Offset: 0x00088ECC
			public SchedulerNode.Event eventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr_eventData);
					return new SchedulerNode.Event(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr_eventData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700537B RID: 21371
			// (get) Token: 0x0600FFB4 RID: 65460 RVA: 0x003BD074 File Offset: 0x003BB274
			// (set) Token: 0x0600FFB5 RID: 65461 RVA: 0x0008ACFA File Offset: 0x00088EFA
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700537C RID: 21372
			// (get) Token: 0x0600FFB6 RID: 65462 RVA: 0x003BD0A4 File Offset: 0x003BB2A4
			// (set) Token: 0x0600FFB7 RID: 65463 RVA: 0x0008AD19 File Offset: 0x00088F19
			public unsafe IAssetHandle<PlayableAsset> _loadedTimeline_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr__loadedTimeline_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<PlayableAsset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr__loadedTimeline_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700537D RID: 21373
			// (get) Token: 0x0600FFB8 RID: 65464 RVA: 0x003BD0D4 File Offset: 0x003BB2D4
			// (set) Token: 0x0600FFB9 RID: 65465 RVA: 0x0008AD38 File Offset: 0x00088F38
			public unsafe IAssetHandle<DialogPackage> _loadedDialogPackage_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr__loadedDialogPackage_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<DialogPackage>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr__loadedDialogPackage_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700537E RID: 21374
			// (get) Token: 0x0600FFBA RID: 65466 RVA: 0x003BD104 File Offset: 0x003BB304
			// (set) Token: 0x0600FFBB RID: 65467 RVA: 0x0008AD57 File Offset: 0x00088F57
			public UniTask<IAssetHandle<PlayableAsset>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___u__1);
					return new UniTask<IAssetHandle<PlayableAsset>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<PlayableAsset>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<PlayableAsset>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700537F RID: 21375
			// (get) Token: 0x0600FFBC RID: 65468 RVA: 0x003BD134 File Offset: 0x003BB334
			// (set) Token: 0x0600FFBD RID: 65469 RVA: 0x0008AD85 File Offset: 0x00088F85
			public UniTask.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___u__2);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005380 RID: 21376
			// (get) Token: 0x0600FFBE RID: 65470 RVA: 0x003BD164 File Offset: 0x003BB364
			// (set) Token: 0x0600FFBF RID: 65471 RVA: 0x0008ADB3 File Offset: 0x00088FB3
			public UniTask<IAssetHandle<DialogPackage>>.Awaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___u__3);
					return new UniTask<IAssetHandle<DialogPackage>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<DialogPackage>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._ExecuteEventCoreAsync_d__29.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<DialogPackage>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A25F RID: 41567
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A260 RID: 41568
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A261 RID: 41569
			private static readonly IntPtr NativeFieldInfoPtr_eventData;

			// Token: 0x0400A262 RID: 41570
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A263 RID: 41571
			private static readonly IntPtr NativeFieldInfoPtr__loadedTimeline_5__2;

			// Token: 0x0400A264 RID: 41572
			private static readonly IntPtr NativeFieldInfoPtr__loadedDialogPackage_5__3;

			// Token: 0x0400A265 RID: 41573
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A266 RID: 41574
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400A267 RID: 41575
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x0400A268 RID: 41576
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A269 RID: 41577
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000DD6 RID: 3542
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FFC0 RID: 65472 RVA: 0x003BD194 File Offset: 0x003BB394
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass30_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass30_0.NativeFieldInfoPtr_hasPlayFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass30_0>.NativeClassPtr, "hasPlayFinished");
				SceneDirector.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass30_0>.NativeClassPtr, 100683924);
				SceneDirector.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass30_0>.NativeClassPtr, 100683925);
				SceneDirector.__c__DisplayClass30_0.NativeMethodInfoPtr__PlayTimelineAsync_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass30_0>.NativeClassPtr, 100683926);
			}

			// Token: 0x0600FFC1 RID: 65473 RVA: 0x003BD210 File Offset: 0x003BB410
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFC2 RID: 65474 RVA: 0x003BD24C File Offset: 0x003BB44C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PlayableDirector_0(PlayableDirector _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFC3 RID: 65475 RVA: 0x003BD290 File Offset: 0x003BB490
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayTimelineAsync_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass30_0.NativeMethodInfoPtr__PlayTimelineAsync_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FFC4 RID: 65476 RVA: 0x0008ADE1 File Offset: 0x00088FE1
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005381 RID: 21377
			// (get) Token: 0x0600FFC5 RID: 65477 RVA: 0x003BD2CC File Offset: 0x003BB4CC
			// (set) Token: 0x0600FFC6 RID: 65478 RVA: 0x0008ADEA File Offset: 0x00088FEA
			public unsafe bool hasPlayFinished
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass30_0.NativeFieldInfoPtr_hasPlayFinished);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass30_0.NativeFieldInfoPtr_hasPlayFinished)) = value;
				}
			}

			// Token: 0x0400A26A RID: 41578
			private static readonly IntPtr NativeFieldInfoPtr_hasPlayFinished;

			// Token: 0x0400A26B RID: 41579
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A26C RID: 41580
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PlayableDirector_0;

			// Token: 0x0400A26D RID: 41581
			private static readonly IntPtr NativeMethodInfoPtr__PlayTimelineAsync_b__1_Internal_Boolean_0;
		}

		// Token: 0x02000DD7 RID: 3543
		[ObfuscatedName("Common.SceneDirector+<PlayTimelineAsync>d__30")]
		public sealed class _PlayTimelineAsync_d__30 : ValueType
		{
			// Token: 0x0600FFC7 RID: 65479 RVA: 0x003BD2F4 File Offset: 0x003BB4F4
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayTimelineAsync_d__30()
			{
				Il2CppClassPointerStore<SceneDirector._PlayTimelineAsync_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<PlayTimelineAsync>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector._PlayTimelineAsync_d__30>.NativeClassPtr);
				SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._PlayTimelineAsync_d__30>.NativeClassPtr, "<>1__state");
				SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._PlayTimelineAsync_d__30>.NativeClassPtr, "<>t__builder");
				SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._PlayTimelineAsync_d__30>.NativeClassPtr, "<>4__this");
				SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr_playableAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._PlayTimelineAsync_d__30>.NativeClassPtr, "playableAsset");
				SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._PlayTimelineAsync_d__30>.NativeClassPtr, "<>8__1");
				SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._PlayTimelineAsync_d__30>.NativeClassPtr, "<>u__1");
				SceneDirector._PlayTimelineAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._PlayTimelineAsync_d__30>.NativeClassPtr, 100683927);
				SceneDirector._PlayTimelineAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._PlayTimelineAsync_d__30>.NativeClassPtr, 100683928);
			}

			// Token: 0x0600FFC8 RID: 65480 RVA: 0x003BD3C0 File Offset: 0x003BB5C0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 253490, RefRangeEnd = 253493, XrefRangeStart = 253472, XrefRangeEnd = 253490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._PlayTimelineAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFC9 RID: 65481 RVA: 0x003BD3F8 File Offset: 0x003BB5F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._PlayTimelineAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFCA RID: 65482 RVA: 0x0008AE05 File Offset: 0x00089005
			public _PlayTimelineAsync_d__30(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600FFCB RID: 65483 RVA: 0x0008AE0E File Offset: 0x0008900E
			public _PlayTimelineAsync_d__30() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector._PlayTimelineAsync_d__30>.NativeClassPtr))
			{
			}

			// Token: 0x17005382 RID: 21378
			// (get) Token: 0x0600FFCC RID: 65484 RVA: 0x003BD440 File Offset: 0x003BB640
			// (set) Token: 0x0600FFCD RID: 65485 RVA: 0x0008AE20 File Offset: 0x00089020
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005383 RID: 21379
			// (get) Token: 0x0600FFCE RID: 65486 RVA: 0x003BD468 File Offset: 0x003BB668
			// (set) Token: 0x0600FFCF RID: 65487 RVA: 0x0008AE3B File Offset: 0x0008903B
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005384 RID: 21380
			// (get) Token: 0x0600FFD0 RID: 65488 RVA: 0x003BD498 File Offset: 0x003BB698
			// (set) Token: 0x0600FFD1 RID: 65489 RVA: 0x0008AE69 File Offset: 0x00089069
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005385 RID: 21381
			// (get) Token: 0x0600FFD2 RID: 65490 RVA: 0x003BD4C8 File Offset: 0x003BB6C8
			// (set) Token: 0x0600FFD3 RID: 65491 RVA: 0x0008AE88 File Offset: 0x00089088
			public unsafe PlayableAsset playableAsset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr_playableAsset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr_playableAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005386 RID: 21382
			// (get) Token: 0x0600FFD4 RID: 65492 RVA: 0x003BD4F8 File Offset: 0x003BB6F8
			// (set) Token: 0x0600FFD5 RID: 65493 RVA: 0x0008AEA7 File Offset: 0x000890A7
			public unsafe SceneDirector.__c__DisplayClass30_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector.__c__DisplayClass30_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005387 RID: 21383
			// (get) Token: 0x0600FFD6 RID: 65494 RVA: 0x003BD528 File Offset: 0x003BB728
			// (set) Token: 0x0600FFD7 RID: 65495 RVA: 0x0008AEC6 File Offset: 0x000890C6
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._PlayTimelineAsync_d__30.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400A26E RID: 41582
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A26F RID: 41583
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400A270 RID: 41584
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A271 RID: 41585
			private static readonly IntPtr NativeFieldInfoPtr_playableAsset;

			// Token: 0x0400A272 RID: 41586
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400A273 RID: 41587
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400A274 RID: 41588
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A275 RID: 41589
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000DD8 RID: 3544
		[ObfuscatedName("Common.SceneDirector+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600FFD8 RID: 65496 RVA: 0x003BD558 File Offset: 0x003BB758
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SceneDirector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c>.NativeClassPtr);
				SceneDirector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c>.NativeClassPtr, "<>9");
				SceneDirector.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c>.NativeClassPtr, "<>9__39_0");
				SceneDirector.__c.NativeFieldInfoPtr___9__50_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c>.NativeClassPtr, "<>9__50_0");
				SceneDirector.__c.NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c>.NativeClassPtr, "<>9__51_0");
				SceneDirector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c>.NativeClassPtr, 100683930);
				SceneDirector.__c.NativeMethodInfoPtr__CleanCharacters_b__39_0_Internal_Boolean_KeyValuePair_2_String_CharacterControllerUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c>.NativeClassPtr, 100683931);
				SceneDirector.__c.NativeMethodInfoPtr__StopAllMovingProcess_b__50_0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c>.NativeClassPtr, 100683932);
				SceneDirector.__c.NativeMethodInfoPtr__StopAllUnmanagedMovingProcess_b__51_0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c>.NativeClassPtr, 100683933);
			}

			// Token: 0x0600FFD9 RID: 65497 RVA: 0x003BD624 File Offset: 0x003BB824
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFDA RID: 65498 RVA: 0x003BD660 File Offset: 0x003BB860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253493, XrefRangeEnd = 253497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CleanCharacters_b__39_0(KeyValuePair<string, CharacterControllerUnit> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c.NativeMethodInfoPtr__CleanCharacters_b__39_0_Internal_Boolean_KeyValuePair_2_String_CharacterControllerUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FFDB RID: 65499 RVA: 0x003BD6B4 File Offset: 0x003BB8B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StopAllMovingProcess_b__50_0(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c.NativeMethodInfoPtr__StopAllMovingProcess_b__50_0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFDC RID: 65500 RVA: 0x003BD6F8 File Offset: 0x003BB8F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StopAllUnmanagedMovingProcess_b__51_0(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c.NativeMethodInfoPtr__StopAllUnmanagedMovingProcess_b__51_0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFDD RID: 65501 RVA: 0x0008AEF4 File Offset: 0x000890F4
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005388 RID: 21384
			// (get) Token: 0x0600FFDE RID: 65502 RVA: 0x003BD73C File Offset: 0x003BB93C
			// (set) Token: 0x0600FFDF RID: 65503 RVA: 0x0008AEFD File Offset: 0x000890FD
			public unsafe static SceneDirector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneDirector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneDirector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005389 RID: 21385
			// (get) Token: 0x0600FFE0 RID: 65504 RVA: 0x003BD764 File Offset: 0x003BB964
			// (set) Token: 0x0600FFE1 RID: 65505 RVA: 0x0008AF0F File Offset: 0x0008910F
			public unsafe static Func<KeyValuePair<string, CharacterControllerUnit>, bool> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneDirector.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, CharacterControllerUnit>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneDirector.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700538A RID: 21386
			// (get) Token: 0x0600FFE2 RID: 65506 RVA: 0x003BD78C File Offset: 0x003BB98C
			// (set) Token: 0x0600FFE3 RID: 65507 RVA: 0x0008AF21 File Offset: 0x00089121
			public unsafe static Action<Action> __9__50_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneDirector.__c.NativeFieldInfoPtr___9__50_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneDirector.__c.NativeFieldInfoPtr___9__50_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700538B RID: 21387
			// (get) Token: 0x0600FFE4 RID: 65508 RVA: 0x003BD7B4 File Offset: 0x003BB9B4
			// (set) Token: 0x0600FFE5 RID: 65509 RVA: 0x0008AF33 File Offset: 0x00089133
			public unsafe static Action<Action> __9__51_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneDirector.__c.NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneDirector.__c.NativeFieldInfoPtr___9__51_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A276 RID: 41590
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A277 RID: 41591
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x0400A278 RID: 41592
			private static readonly IntPtr NativeFieldInfoPtr___9__50_0;

			// Token: 0x0400A279 RID: 41593
			private static readonly IntPtr NativeFieldInfoPtr___9__51_0;

			// Token: 0x0400A27A RID: 41594
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A27B RID: 41595
			private static readonly IntPtr NativeMethodInfoPtr__CleanCharacters_b__39_0_Internal_Boolean_KeyValuePair_2_String_CharacterControllerUnit_0;

			// Token: 0x0400A27C RID: 41596
			private static readonly IntPtr NativeMethodInfoPtr__StopAllMovingProcess_b__50_0_Internal_Void_Action_0;

			// Token: 0x0400A27D RID: 41597
			private static readonly IntPtr NativeMethodInfoPtr__StopAllUnmanagedMovingProcess_b__51_0_Internal_Void_Action_0;
		}

		// Token: 0x02000DD9 RID: 3545
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass47_0")]
		public sealed class __c__DisplayClass47_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FFE6 RID: 65510 RVA: 0x003BD7DC File Offset: 0x003BB9DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass47_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass47_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass47_0.NativeFieldInfoPtr_suppressCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass47_0>.NativeClassPtr, "suppressCallbacks");
				SceneDirector.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass47_0>.NativeClassPtr, 100683934);
				SceneDirector.__c__DisplayClass47_0.NativeMethodInfoPtr__GiveItem_b__0_Internal_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass47_0>.NativeClassPtr, 100683935);
			}

			// Token: 0x0600FFE7 RID: 65511 RVA: 0x003BD844 File Offset: 0x003BBA44
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass47_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFE8 RID: 65512 RVA: 0x003BD880 File Offset: 0x003BBA80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253497, XrefRangeEnd = 253498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GiveItem_b__0(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass47_0.NativeMethodInfoPtr__GiveItem_b__0_Internal_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFE9 RID: 65513 RVA: 0x0008AF45 File Offset: 0x00089145
			public __c__DisplayClass47_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700538C RID: 21388
			// (get) Token: 0x0600FFEA RID: 65514 RVA: 0x003BD8C8 File Offset: 0x003BBAC8
			// (set) Token: 0x0600FFEB RID: 65515 RVA: 0x0008AF4E File Offset: 0x0008914E
			public unsafe bool suppressCallbacks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass47_0.NativeFieldInfoPtr_suppressCallbacks);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass47_0.NativeFieldInfoPtr_suppressCallbacks)) = value;
				}
			}

			// Token: 0x0400A27E RID: 41598
			private static readonly IntPtr NativeFieldInfoPtr_suppressCallbacks;

			// Token: 0x0400A27F RID: 41599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A280 RID: 41600
			private static readonly IntPtr NativeMethodInfoPtr__GiveItem_b__0_Internal_Void_Product_0;
		}

		// Token: 0x02000DDA RID: 3546
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass52_0")]
		public sealed class __c__DisplayClass52_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FFEC RID: 65516 RVA: 0x003BD8F0 File Offset: 0x003BBAF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass52_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass52_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass52_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass52_0>.NativeClassPtr, "<>4__this");
				SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass52_0>.NativeClassPtr, "label");
				SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass52_0>.NativeClassPtr, "entity");
				SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_wayPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass52_0>.NativeClassPtr, "wayPoints");
				SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass52_0>.NativeClassPtr, "speedMultiplier");
				SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass52_0>.NativeClassPtr, "onFinishCallback");
				SceneDirector.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass52_0>.NativeClassPtr, 100683936);
				SceneDirector.__c__DisplayClass52_0.NativeMethodInfoPtr__MoveObject_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass52_0>.NativeClassPtr, 100683937);
				SceneDirector.__c__DisplayClass52_0.NativeMethodInfoPtr__MoveObject_b__1_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass52_0>.NativeClassPtr, 100683938);
			}

			// Token: 0x0600FFED RID: 65517 RVA: 0x003BD9D0 File Offset: 0x003BBBD0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass52_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass52_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFEE RID: 65518 RVA: 0x003BDA0C File Offset: 0x003BBC0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253498, XrefRangeEnd = 253502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MoveObject_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass52_0.NativeMethodInfoPtr__MoveObject_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFEF RID: 65519 RVA: 0x003BDA40 File Offset: 0x003BBC40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253502, XrefRangeEnd = 253504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _MoveObject_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass52_0.NativeMethodInfoPtr__MoveObject_b__1_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600FFF0 RID: 65520 RVA: 0x0008AF69 File Offset: 0x00089169
			public __c__DisplayClass52_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700538D RID: 21389
			// (get) Token: 0x0600FFF1 RID: 65521 RVA: 0x003BDA80 File Offset: 0x003BBC80
			// (set) Token: 0x0600FFF2 RID: 65522 RVA: 0x0008AF72 File Offset: 0x00089172
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700538E RID: 21390
			// (get) Token: 0x0600FFF3 RID: 65523 RVA: 0x003BDAB0 File Offset: 0x003BBCB0
			// (set) Token: 0x0600FFF4 RID: 65524 RVA: 0x0008AF91 File Offset: 0x00089191
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700538F RID: 21391
			// (get) Token: 0x0600FFF5 RID: 65525 RVA: 0x003BDAD8 File Offset: 0x003BBCD8
			// (set) Token: 0x0600FFF6 RID: 65526 RVA: 0x0008AFB0 File Offset: 0x000891B0
			public unsafe GameObject entity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_entity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005390 RID: 21392
			// (get) Token: 0x0600FFF7 RID: 65527 RVA: 0x003BDB08 File Offset: 0x003BBD08
			// (set) Token: 0x0600FFF8 RID: 65528 RVA: 0x0008AFCF File Offset: 0x000891CF
			public unsafe Il2CppStructArray<Vector2> wayPoints
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_wayPoints);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_wayPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005391 RID: 21393
			// (get) Token: 0x0600FFF9 RID: 65529 RVA: 0x003BDB38 File Offset: 0x003BBD38
			// (set) Token: 0x0600FFFA RID: 65530 RVA: 0x0008AFEE File Offset: 0x000891EE
			public unsafe float speedMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_speedMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_speedMultiplier)) = value;
				}
			}

			// Token: 0x17005392 RID: 21394
			// (get) Token: 0x0600FFFB RID: 65531 RVA: 0x003BDB60 File Offset: 0x003BBD60
			// (set) Token: 0x0600FFFC RID: 65532 RVA: 0x0008B009 File Offset: 0x00089209
			public unsafe Action onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass52_0.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A281 RID: 41601
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A282 RID: 41602
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x0400A283 RID: 41603
			private static readonly IntPtr NativeFieldInfoPtr_entity;

			// Token: 0x0400A284 RID: 41604
			private static readonly IntPtr NativeFieldInfoPtr_wayPoints;

			// Token: 0x0400A285 RID: 41605
			private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

			// Token: 0x0400A286 RID: 41606
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A287 RID: 41607
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A288 RID: 41608
			private static readonly IntPtr NativeMethodInfoPtr__MoveObject_b__0_Internal_Void_0;

			// Token: 0x0400A289 RID: 41609
			private static readonly IntPtr NativeMethodInfoPtr__MoveObject_b__1_Internal_IEnumerator_0;
		}

		// Token: 0x02000DDB RID: 3547
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FFFD RID: 65533 RVA: 0x003BDB90 File Offset: 0x003BBD90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass53_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass53_0>.NativeClassPtr, "<>4__this");
				SceneDirector.__c__DisplayClass53_0.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass53_0>.NativeClassPtr, "entity");
				SceneDirector.__c__DisplayClass53_0.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass53_0>.NativeClassPtr, "character");
				SceneDirector.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass53_0>.NativeClassPtr, 100683939);
				SceneDirector.__c__DisplayClass53_0.NativeMethodInfoPtr__SetObjectFollowTarget_b__0_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass53_0>.NativeClassPtr, 100683940);
			}

			// Token: 0x0600FFFE RID: 65534 RVA: 0x003BDC20 File Offset: 0x003BBE20
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FFFF RID: 65535 RVA: 0x003BDC5C File Offset: 0x003BBE5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253504, XrefRangeEnd = 253512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _SetObjectFollowTarget_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass53_0.NativeMethodInfoPtr__SetObjectFollowTarget_b__0_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06010000 RID: 65536 RVA: 0x0008B028 File Offset: 0x00089228
			public __c__DisplayClass53_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005393 RID: 21395
			// (get) Token: 0x06010001 RID: 65537 RVA: 0x003BDC9C File Offset: 0x003BBE9C
			// (set) Token: 0x06010002 RID: 65538 RVA: 0x0008B031 File Offset: 0x00089231
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005394 RID: 21396
			// (get) Token: 0x06010003 RID: 65539 RVA: 0x003BDCCC File Offset: 0x003BBECC
			// (set) Token: 0x06010004 RID: 65540 RVA: 0x0008B050 File Offset: 0x00089250
			public unsafe GameObject entity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass53_0.NativeFieldInfoPtr_entity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass53_0.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005395 RID: 21397
			// (get) Token: 0x06010005 RID: 65541 RVA: 0x003BDCFC File Offset: 0x003BBEFC
			// (set) Token: 0x06010006 RID: 65542 RVA: 0x0008B06F File Offset: 0x0008926F
			public unsafe CharacterControllerUnit character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass53_0.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass53_0.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A28A RID: 41610
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A28B RID: 41611
			private static readonly IntPtr NativeFieldInfoPtr_entity;

			// Token: 0x0400A28C RID: 41612
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x0400A28D RID: 41613
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A28E RID: 41614
			private static readonly IntPtr NativeMethodInfoPtr__SetObjectFollowTarget_b__0_Internal_IEnumerator_0;
		}

		// Token: 0x02000DDC RID: 3548
		[ObfuscatedName("Common.SceneDirector+<FollowTargetCoroutine>d__54")]
		public sealed class _FollowTargetCoroutine_d__54 : Il2CppSystem.Object
		{
			// Token: 0x06010007 RID: 65543 RVA: 0x003BDD2C File Offset: 0x003BBF2C
			// Note: this type is marked as 'beforefieldinit'.
			static _FollowTargetCoroutine_d__54()
			{
				Il2CppClassPointerStore<SceneDirector._FollowTargetCoroutine_d__54>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<FollowTargetCoroutine>d__54");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector._FollowTargetCoroutine_d__54>.NativeClassPtr);
				SceneDirector._FollowTargetCoroutine_d__54.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._FollowTargetCoroutine_d__54>.NativeClassPtr, "<>1__state");
				SceneDirector._FollowTargetCoroutine_d__54.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._FollowTargetCoroutine_d__54>.NativeClassPtr, "<>2__current");
				SceneDirector._FollowTargetCoroutine_d__54.NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._FollowTargetCoroutine_d__54>.NativeClassPtr, "self");
				SceneDirector._FollowTargetCoroutine_d__54.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._FollowTargetCoroutine_d__54>.NativeClassPtr, "target");
				SceneDirector._FollowTargetCoroutine_d__54.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._FollowTargetCoroutine_d__54>.NativeClassPtr, 100683941);
				SceneDirector._FollowTargetCoroutine_d__54.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._FollowTargetCoroutine_d__54>.NativeClassPtr, 100683942);
				SceneDirector._FollowTargetCoroutine_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._FollowTargetCoroutine_d__54>.NativeClassPtr, 100683943);
				SceneDirector._FollowTargetCoroutine_d__54.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._FollowTargetCoroutine_d__54>.NativeClassPtr, 100683944);
				SceneDirector._FollowTargetCoroutine_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._FollowTargetCoroutine_d__54>.NativeClassPtr, 100683945);
				SceneDirector._FollowTargetCoroutine_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._FollowTargetCoroutine_d__54>.NativeClassPtr, 100683946);
			}

			// Token: 0x06010008 RID: 65544 RVA: 0x003BDE20 File Offset: 0x003BC020
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FollowTargetCoroutine_d__54(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector._FollowTargetCoroutine_d__54>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._FollowTargetCoroutine_d__54.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010009 RID: 65545 RVA: 0x003BDE68 File Offset: 0x003BC068
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._FollowTargetCoroutine_d__54.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601000A RID: 65546 RVA: 0x003BDE9C File Offset: 0x003BC09C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253512, XrefRangeEnd = 253522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._FollowTargetCoroutine_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700539A RID: 21402
			// (get) Token: 0x0601000B RID: 65547 RVA: 0x003BDED8 File Offset: 0x003BC0D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._FollowTargetCoroutine_d__54.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0601000C RID: 65548 RVA: 0x003BDF18 File Offset: 0x003BC118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253522, XrefRangeEnd = 253528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._FollowTargetCoroutine_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700539B RID: 21403
			// (get) Token: 0x0601000D RID: 65549 RVA: 0x003BDF4C File Offset: 0x003BC14C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._FollowTargetCoroutine_d__54.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0601000E RID: 65550 RVA: 0x0008B08E File Offset: 0x0008928E
			public _FollowTargetCoroutine_d__54(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005396 RID: 21398
			// (get) Token: 0x0601000F RID: 65551 RVA: 0x003BDF8C File Offset: 0x003BC18C
			// (set) Token: 0x06010010 RID: 65552 RVA: 0x0008B097 File Offset: 0x00089297
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._FollowTargetCoroutine_d__54.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._FollowTargetCoroutine_d__54.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005397 RID: 21399
			// (get) Token: 0x06010011 RID: 65553 RVA: 0x003BDFB4 File Offset: 0x003BC1B4
			// (set) Token: 0x06010012 RID: 65554 RVA: 0x0008B0B2 File Offset: 0x000892B2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._FollowTargetCoroutine_d__54.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._FollowTargetCoroutine_d__54.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005398 RID: 21400
			// (get) Token: 0x06010013 RID: 65555 RVA: 0x003BDFE4 File Offset: 0x003BC1E4
			// (set) Token: 0x06010014 RID: 65556 RVA: 0x0008B0D1 File Offset: 0x000892D1
			public unsafe Transform self
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._FollowTargetCoroutine_d__54.NativeFieldInfoPtr_self);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._FollowTargetCoroutine_d__54.NativeFieldInfoPtr_self), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005399 RID: 21401
			// (get) Token: 0x06010015 RID: 65557 RVA: 0x003BE014 File Offset: 0x003BC214
			// (set) Token: 0x06010016 RID: 65558 RVA: 0x0008B0F0 File Offset: 0x000892F0
			public unsafe Transform target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._FollowTargetCoroutine_d__54.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._FollowTargetCoroutine_d__54.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A28F RID: 41615
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A290 RID: 41616
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A291 RID: 41617
			private static readonly IntPtr NativeFieldInfoPtr_self;

			// Token: 0x0400A292 RID: 41618
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400A293 RID: 41619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A294 RID: 41620
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A295 RID: 41621
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A296 RID: 41622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A297 RID: 41623
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A298 RID: 41624
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000DDD RID: 3549
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass55_0")]
		public sealed class __c__DisplayClass55_0 : Il2CppSystem.Object
		{
			// Token: 0x06010017 RID: 65559 RVA: 0x003BE044 File Offset: 0x003BC244
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass55_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass55_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass55_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass55_0>.NativeClassPtr, "<>4__this");
				SceneDirector.__c__DisplayClass55_0.NativeFieldInfoPtr_wayPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass55_0>.NativeClassPtr, "wayPoints");
				SceneDirector.__c__DisplayClass55_0.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass55_0>.NativeClassPtr, "speedMultiplier");
				SceneDirector.__c__DisplayClass55_0.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass55_0>.NativeClassPtr, "onFinishCallback");
				SceneDirector.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass55_0>.NativeClassPtr, 100683947);
				SceneDirector.__c__DisplayClass55_0.NativeMethodInfoPtr__MoveCamera_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass55_0>.NativeClassPtr, 100683948);
				SceneDirector.__c__DisplayClass55_0.NativeMethodInfoPtr__MoveCamera_b__1_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass55_0>.NativeClassPtr, 100683949);
			}

			// Token: 0x06010018 RID: 65560 RVA: 0x003BE0FC File Offset: 0x003BC2FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass55_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010019 RID: 65561 RVA: 0x003BE138 File Offset: 0x003BC338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253528, XrefRangeEnd = 253534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MoveCamera_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass55_0.NativeMethodInfoPtr__MoveCamera_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601001A RID: 65562 RVA: 0x003BE16C File Offset: 0x003BC36C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253534, XrefRangeEnd = 253536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _MoveCamera_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass55_0.NativeMethodInfoPtr__MoveCamera_b__1_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0601001B RID: 65563 RVA: 0x0008B10F File Offset: 0x0008930F
			public __c__DisplayClass55_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700539C RID: 21404
			// (get) Token: 0x0601001C RID: 65564 RVA: 0x003BE1AC File Offset: 0x003BC3AC
			// (set) Token: 0x0601001D RID: 65565 RVA: 0x0008B118 File Offset: 0x00089318
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass55_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass55_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700539D RID: 21405
			// (get) Token: 0x0601001E RID: 65566 RVA: 0x003BE1DC File Offset: 0x003BC3DC
			// (set) Token: 0x0601001F RID: 65567 RVA: 0x0008B137 File Offset: 0x00089337
			public unsafe Il2CppStructArray<Vector2> wayPoints
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass55_0.NativeFieldInfoPtr_wayPoints);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass55_0.NativeFieldInfoPtr_wayPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700539E RID: 21406
			// (get) Token: 0x06010020 RID: 65568 RVA: 0x003BE20C File Offset: 0x003BC40C
			// (set) Token: 0x06010021 RID: 65569 RVA: 0x0008B156 File Offset: 0x00089356
			public unsafe float speedMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass55_0.NativeFieldInfoPtr_speedMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass55_0.NativeFieldInfoPtr_speedMultiplier)) = value;
				}
			}

			// Token: 0x1700539F RID: 21407
			// (get) Token: 0x06010022 RID: 65570 RVA: 0x003BE234 File Offset: 0x003BC434
			// (set) Token: 0x06010023 RID: 65571 RVA: 0x0008B171 File Offset: 0x00089371
			public unsafe Action onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass55_0.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass55_0.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A299 RID: 41625
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A29A RID: 41626
			private static readonly IntPtr NativeFieldInfoPtr_wayPoints;

			// Token: 0x0400A29B RID: 41627
			private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

			// Token: 0x0400A29C RID: 41628
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A29D RID: 41629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A29E RID: 41630
			private static readonly IntPtr NativeMethodInfoPtr__MoveCamera_b__0_Internal_Void_0;

			// Token: 0x0400A29F RID: 41631
			private static readonly IntPtr NativeMethodInfoPtr__MoveCamera_b__1_Internal_IEnumerator_0;
		}

		// Token: 0x02000DDE RID: 3550
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
		{
			// Token: 0x06010024 RID: 65572 RVA: 0x003BE264 File Offset: 0x003BC464
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass56_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass56_0>.NativeClassPtr, "<>4__this");
				SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass56_0>.NativeClassPtr, "pivot");
				SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass56_0>.NativeClassPtr, "angle");
				SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass56_0>.NativeClassPtr, "speedMultiplier");
				SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass56_0>.NativeClassPtr, "onFinishCallback");
				SceneDirector.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass56_0>.NativeClassPtr, 100683950);
				SceneDirector.__c__DisplayClass56_0.NativeMethodInfoPtr__RotateAroundCamera_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass56_0>.NativeClassPtr, 100683951);
				SceneDirector.__c__DisplayClass56_0.NativeMethodInfoPtr__RotateAroundCamera_b__1_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass56_0>.NativeClassPtr, 100683952);
			}

			// Token: 0x06010025 RID: 65573 RVA: 0x003BE330 File Offset: 0x003BC530
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010026 RID: 65574 RVA: 0x003BE36C File Offset: 0x003BC56C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253536, XrefRangeEnd = 253542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RotateAroundCamera_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass56_0.NativeMethodInfoPtr__RotateAroundCamera_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010027 RID: 65575 RVA: 0x003BE3A0 File Offset: 0x003BC5A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253542, XrefRangeEnd = 253549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _RotateAroundCamera_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass56_0.NativeMethodInfoPtr__RotateAroundCamera_b__1_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06010028 RID: 65576 RVA: 0x0008B190 File Offset: 0x00089390
			public __c__DisplayClass56_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053A0 RID: 21408
			// (get) Token: 0x06010029 RID: 65577 RVA: 0x003BE3E0 File Offset: 0x003BC5E0
			// (set) Token: 0x0601002A RID: 65578 RVA: 0x0008B199 File Offset: 0x00089399
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053A1 RID: 21409
			// (get) Token: 0x0601002B RID: 65579 RVA: 0x003BE410 File Offset: 0x003BC610
			// (set) Token: 0x0601002C RID: 65580 RVA: 0x0008B1B8 File Offset: 0x000893B8
			public unsafe Vector2 pivot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr_pivot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr_pivot)) = value;
				}
			}

			// Token: 0x170053A2 RID: 21410
			// (get) Token: 0x0601002D RID: 65581 RVA: 0x003BE438 File Offset: 0x003BC638
			// (set) Token: 0x0601002E RID: 65582 RVA: 0x0008B1D3 File Offset: 0x000893D3
			public unsafe float angle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr_angle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr_angle)) = value;
				}
			}

			// Token: 0x170053A3 RID: 21411
			// (get) Token: 0x0601002F RID: 65583 RVA: 0x003BE460 File Offset: 0x003BC660
			// (set) Token: 0x06010030 RID: 65584 RVA: 0x0008B1EE File Offset: 0x000893EE
			public unsafe float speedMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr_speedMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr_speedMultiplier)) = value;
				}
			}

			// Token: 0x170053A4 RID: 21412
			// (get) Token: 0x06010031 RID: 65585 RVA: 0x003BE488 File Offset: 0x003BC688
			// (set) Token: 0x06010032 RID: 65586 RVA: 0x0008B209 File Offset: 0x00089409
			public unsafe Action onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass56_0.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A2A0 RID: 41632
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A2A1 RID: 41633
			private static readonly IntPtr NativeFieldInfoPtr_pivot;

			// Token: 0x0400A2A2 RID: 41634
			private static readonly IntPtr NativeFieldInfoPtr_angle;

			// Token: 0x0400A2A3 RID: 41635
			private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

			// Token: 0x0400A2A4 RID: 41636
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A2A5 RID: 41637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A2A6 RID: 41638
			private static readonly IntPtr NativeMethodInfoPtr__RotateAroundCamera_b__0_Internal_Void_0;

			// Token: 0x0400A2A7 RID: 41639
			private static readonly IntPtr NativeMethodInfoPtr__RotateAroundCamera_b__1_Internal_IEnumerator_0;
		}

		// Token: 0x02000DDF RID: 3551
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : Il2CppSystem.Object
		{
			// Token: 0x06010033 RID: 65587 RVA: 0x003BE4B8 File Offset: 0x003BC6B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass57_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass57_0.NativeFieldInfoPtr_workCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass57_0>.NativeClassPtr, "workCoroutine");
				SceneDirector.__c__DisplayClass57_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass57_0>.NativeClassPtr, "<>4__this");
				SceneDirector.__c__DisplayClass57_0.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass57_0>.NativeClassPtr, "onFinishCallback");
				SceneDirector.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass57_0>.NativeClassPtr, 100683953);
				SceneDirector.__c__DisplayClass57_0.NativeMethodInfoPtr__StartWorkCoroutine_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass57_0>.NativeClassPtr, 100683954);
			}

			// Token: 0x06010034 RID: 65588 RVA: 0x003BE548 File Offset: 0x003BC748
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass57_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010035 RID: 65589 RVA: 0x003BE584 File Offset: 0x003BC784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253549, XrefRangeEnd = 253550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartWorkCoroutine_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass57_0.NativeMethodInfoPtr__StartWorkCoroutine_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010036 RID: 65590 RVA: 0x0008B228 File Offset: 0x00089428
			public __c__DisplayClass57_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053A5 RID: 21413
			// (get) Token: 0x06010037 RID: 65591 RVA: 0x003BE5B8 File Offset: 0x003BC7B8
			// (set) Token: 0x06010038 RID: 65592 RVA: 0x0008B231 File Offset: 0x00089431
			public unsafe Coroutine workCoroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass57_0.NativeFieldInfoPtr_workCoroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass57_0.NativeFieldInfoPtr_workCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053A6 RID: 21414
			// (get) Token: 0x06010039 RID: 65593 RVA: 0x003BE5E8 File Offset: 0x003BC7E8
			// (set) Token: 0x0601003A RID: 65594 RVA: 0x0008B250 File Offset: 0x00089450
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass57_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass57_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053A7 RID: 21415
			// (get) Token: 0x0601003B RID: 65595 RVA: 0x003BE618 File Offset: 0x003BC818
			// (set) Token: 0x0601003C RID: 65596 RVA: 0x0008B26F File Offset: 0x0008946F
			public unsafe Action onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass57_0.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass57_0.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A2A8 RID: 41640
			private static readonly IntPtr NativeFieldInfoPtr_workCoroutine;

			// Token: 0x0400A2A9 RID: 41641
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A2AA RID: 41642
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A2AB RID: 41643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A2AC RID: 41644
			private static readonly IntPtr NativeMethodInfoPtr__StartWorkCoroutine_b__0_Internal_Void_0;
		}

		// Token: 0x02000DE0 RID: 3552
		[ObfuscatedName("Common.SceneDirector+<MoveTo>d__58")]
		public sealed class _MoveTo_d__58 : Il2CppSystem.Object
		{
			// Token: 0x0601003D RID: 65597 RVA: 0x003BE648 File Offset: 0x003BC848
			// Note: this type is marked as 'beforefieldinit'.
			static _MoveTo_d__58()
			{
				Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<MoveTo>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr);
				SceneDirector._MoveTo_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, "<>1__state");
				SceneDirector._MoveTo_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, "<>2__current");
				SceneDirector._MoveTo_d__58.NativeFieldInfoPtr_wayPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, "wayPoints");
				SceneDirector._MoveTo_d__58.NativeFieldInfoPtr_entityTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, "entityTransform");
				SceneDirector._MoveTo_d__58.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, "speedMultiplier");
				SceneDirector._MoveTo_d__58.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, "onFinishCallback");
				SceneDirector._MoveTo_d__58.NativeFieldInfoPtr__index_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, "<index>5__2");
				SceneDirector._MoveTo_d__58.NativeFieldInfoPtr__targetPosition_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, "<targetPosition>5__3");
				SceneDirector._MoveTo_d__58.NativeFieldInfoPtr__moveDirection_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, "<moveDirection>5__4");
				SceneDirector._MoveTo_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, 100683955);
				SceneDirector._MoveTo_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, 100683956);
				SceneDirector._MoveTo_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, 100683957);
				SceneDirector._MoveTo_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, 100683958);
				SceneDirector._MoveTo_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, 100683959);
				SceneDirector._MoveTo_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr, 100683960);
			}

			// Token: 0x0601003E RID: 65598 RVA: 0x003BE7A0 File Offset: 0x003BC9A0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MoveTo_d__58(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector._MoveTo_d__58>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._MoveTo_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601003F RID: 65599 RVA: 0x003BE7E8 File Offset: 0x003BC9E8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._MoveTo_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010040 RID: 65600 RVA: 0x003BE81C File Offset: 0x003BCA1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253550, XrefRangeEnd = 253564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._MoveTo_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170053B1 RID: 21425
			// (get) Token: 0x06010041 RID: 65601 RVA: 0x003BE858 File Offset: 0x003BCA58
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._MoveTo_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06010042 RID: 65602 RVA: 0x003BE898 File Offset: 0x003BCA98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253564, XrefRangeEnd = 253570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._MoveTo_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170053B2 RID: 21426
			// (get) Token: 0x06010043 RID: 65603 RVA: 0x003BE8CC File Offset: 0x003BCACC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._MoveTo_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06010044 RID: 65604 RVA: 0x0008B28E File Offset: 0x0008948E
			public _MoveTo_d__58(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053A8 RID: 21416
			// (get) Token: 0x06010045 RID: 65605 RVA: 0x003BE90C File Offset: 0x003BCB0C
			// (set) Token: 0x06010046 RID: 65606 RVA: 0x0008B297 File Offset: 0x00089497
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170053A9 RID: 21417
			// (get) Token: 0x06010047 RID: 65607 RVA: 0x003BE934 File Offset: 0x003BCB34
			// (set) Token: 0x06010048 RID: 65608 RVA: 0x0008B2B2 File Offset: 0x000894B2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053AA RID: 21418
			// (get) Token: 0x06010049 RID: 65609 RVA: 0x003BE964 File Offset: 0x003BCB64
			// (set) Token: 0x0601004A RID: 65610 RVA: 0x0008B2D1 File Offset: 0x000894D1
			public unsafe Il2CppStructArray<Vector2> wayPoints
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr_wayPoints);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr_wayPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053AB RID: 21419
			// (get) Token: 0x0601004B RID: 65611 RVA: 0x003BE994 File Offset: 0x003BCB94
			// (set) Token: 0x0601004C RID: 65612 RVA: 0x0008B2F0 File Offset: 0x000894F0
			public unsafe Transform entityTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr_entityTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr_entityTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053AC RID: 21420
			// (get) Token: 0x0601004D RID: 65613 RVA: 0x003BE9C4 File Offset: 0x003BCBC4
			// (set) Token: 0x0601004E RID: 65614 RVA: 0x0008B30F File Offset: 0x0008950F
			public unsafe float speedMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr_speedMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr_speedMultiplier)) = value;
				}
			}

			// Token: 0x170053AD RID: 21421
			// (get) Token: 0x0601004F RID: 65615 RVA: 0x003BE9EC File Offset: 0x003BCBEC
			// (set) Token: 0x06010050 RID: 65616 RVA: 0x0008B32A File Offset: 0x0008952A
			public unsafe Action onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053AE RID: 21422
			// (get) Token: 0x06010051 RID: 65617 RVA: 0x003BEA1C File Offset: 0x003BCC1C
			// (set) Token: 0x06010052 RID: 65618 RVA: 0x0008B349 File Offset: 0x00089549
			public unsafe int _index_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr__index_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr__index_5__2)) = value;
				}
			}

			// Token: 0x170053AF RID: 21423
			// (get) Token: 0x06010053 RID: 65619 RVA: 0x003BEA44 File Offset: 0x003BCC44
			// (set) Token: 0x06010054 RID: 65620 RVA: 0x0008B364 File Offset: 0x00089564
			public unsafe Vector2 _targetPosition_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr__targetPosition_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr__targetPosition_5__3)) = value;
				}
			}

			// Token: 0x170053B0 RID: 21424
			// (get) Token: 0x06010055 RID: 65621 RVA: 0x003BEA6C File Offset: 0x003BCC6C
			// (set) Token: 0x06010056 RID: 65622 RVA: 0x0008B37F File Offset: 0x0008957F
			public unsafe Vector2 _moveDirection_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr__moveDirection_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._MoveTo_d__58.NativeFieldInfoPtr__moveDirection_5__4)) = value;
				}
			}

			// Token: 0x0400A2AD RID: 41645
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A2AE RID: 41646
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A2AF RID: 41647
			private static readonly IntPtr NativeFieldInfoPtr_wayPoints;

			// Token: 0x0400A2B0 RID: 41648
			private static readonly IntPtr NativeFieldInfoPtr_entityTransform;

			// Token: 0x0400A2B1 RID: 41649
			private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

			// Token: 0x0400A2B2 RID: 41650
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A2B3 RID: 41651
			private static readonly IntPtr NativeFieldInfoPtr__index_5__2;

			// Token: 0x0400A2B4 RID: 41652
			private static readonly IntPtr NativeFieldInfoPtr__targetPosition_5__3;

			// Token: 0x0400A2B5 RID: 41653
			private static readonly IntPtr NativeFieldInfoPtr__moveDirection_5__4;

			// Token: 0x0400A2B6 RID: 41654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A2B7 RID: 41655
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A2B8 RID: 41656
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A2B9 RID: 41657
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A2BA RID: 41658
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A2BB RID: 41659
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000DE1 RID: 3553
		[ObfuscatedName("Common.SceneDirector+<RotateAround>d__59")]
		public sealed class _RotateAround_d__59 : Il2CppSystem.Object
		{
			// Token: 0x06010057 RID: 65623 RVA: 0x003BEA94 File Offset: 0x003BCC94
			// Note: this type is marked as 'beforefieldinit'.
			static _RotateAround_d__59()
			{
				Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<RotateAround>d__59");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr);
				SceneDirector._RotateAround_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, "<>1__state");
				SceneDirector._RotateAround_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, "<>2__current");
				SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, "speedMultiplier");
				SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_entityTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, "entityTransform");
				SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, "pivot");
				SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, "angle");
				SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, "onFinishCallback");
				SceneDirector._RotateAround_d__59.NativeFieldInfoPtr__currentAngle_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, "<currentAngle>5__2");
				SceneDirector._RotateAround_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, 100683961);
				SceneDirector._RotateAround_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, 100683962);
				SceneDirector._RotateAround_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, 100683963);
				SceneDirector._RotateAround_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, 100683964);
				SceneDirector._RotateAround_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, 100683965);
				SceneDirector._RotateAround_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr, 100683966);
			}

			// Token: 0x06010058 RID: 65624 RVA: 0x003BEBD8 File Offset: 0x003BCDD8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RotateAround_d__59(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector._RotateAround_d__59>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._RotateAround_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010059 RID: 65625 RVA: 0x003BEC20 File Offset: 0x003BCE20
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._RotateAround_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601005A RID: 65626 RVA: 0x003BEC54 File Offset: 0x003BCE54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253570, XrefRangeEnd = 253576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._RotateAround_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170053BB RID: 21435
			// (get) Token: 0x0601005B RID: 65627 RVA: 0x003BEC90 File Offset: 0x003BCE90
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._RotateAround_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0601005C RID: 65628 RVA: 0x003BECD0 File Offset: 0x003BCED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253576, XrefRangeEnd = 253582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._RotateAround_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170053BC RID: 21436
			// (get) Token: 0x0601005D RID: 65629 RVA: 0x003BED04 File Offset: 0x003BCF04
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._RotateAround_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0601005E RID: 65630 RVA: 0x0008B39A File Offset: 0x0008959A
			public _RotateAround_d__59(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053B3 RID: 21427
			// (get) Token: 0x0601005F RID: 65631 RVA: 0x003BED44 File Offset: 0x003BCF44
			// (set) Token: 0x06010060 RID: 65632 RVA: 0x0008B3A3 File Offset: 0x000895A3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170053B4 RID: 21428
			// (get) Token: 0x06010061 RID: 65633 RVA: 0x003BED6C File Offset: 0x003BCF6C
			// (set) Token: 0x06010062 RID: 65634 RVA: 0x0008B3BE File Offset: 0x000895BE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053B5 RID: 21429
			// (get) Token: 0x06010063 RID: 65635 RVA: 0x003BED9C File Offset: 0x003BCF9C
			// (set) Token: 0x06010064 RID: 65636 RVA: 0x0008B3DD File Offset: 0x000895DD
			public unsafe float speedMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_speedMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_speedMultiplier)) = value;
				}
			}

			// Token: 0x170053B6 RID: 21430
			// (get) Token: 0x06010065 RID: 65637 RVA: 0x003BEDC4 File Offset: 0x003BCFC4
			// (set) Token: 0x06010066 RID: 65638 RVA: 0x0008B3F8 File Offset: 0x000895F8
			public unsafe Transform entityTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_entityTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_entityTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053B7 RID: 21431
			// (get) Token: 0x06010067 RID: 65639 RVA: 0x003BEDF4 File Offset: 0x003BCFF4
			// (set) Token: 0x06010068 RID: 65640 RVA: 0x0008B417 File Offset: 0x00089617
			public unsafe Vector2 pivot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_pivot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_pivot)) = value;
				}
			}

			// Token: 0x170053B8 RID: 21432
			// (get) Token: 0x06010069 RID: 65641 RVA: 0x003BEE1C File Offset: 0x003BD01C
			// (set) Token: 0x0601006A RID: 65642 RVA: 0x0008B432 File Offset: 0x00089632
			public unsafe float angle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_angle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_angle)) = value;
				}
			}

			// Token: 0x170053B9 RID: 21433
			// (get) Token: 0x0601006B RID: 65643 RVA: 0x003BEE44 File Offset: 0x003BD044
			// (set) Token: 0x0601006C RID: 65644 RVA: 0x0008B44D File Offset: 0x0008964D
			public unsafe Action onFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_onFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053BA RID: 21434
			// (get) Token: 0x0601006D RID: 65645 RVA: 0x003BEE74 File Offset: 0x003BD074
			// (set) Token: 0x0601006E RID: 65646 RVA: 0x0008B46C File Offset: 0x0008966C
			public unsafe float _currentAngle_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr__currentAngle_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._RotateAround_d__59.NativeFieldInfoPtr__currentAngle_5__2)) = value;
				}
			}

			// Token: 0x0400A2BC RID: 41660
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A2BD RID: 41661
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A2BE RID: 41662
			private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

			// Token: 0x0400A2BF RID: 41663
			private static readonly IntPtr NativeFieldInfoPtr_entityTransform;

			// Token: 0x0400A2C0 RID: 41664
			private static readonly IntPtr NativeFieldInfoPtr_pivot;

			// Token: 0x0400A2C1 RID: 41665
			private static readonly IntPtr NativeFieldInfoPtr_angle;

			// Token: 0x0400A2C2 RID: 41666
			private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

			// Token: 0x0400A2C3 RID: 41667
			private static readonly IntPtr NativeFieldInfoPtr__currentAngle_5__2;

			// Token: 0x0400A2C4 RID: 41668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A2C5 RID: 41669
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A2C6 RID: 41670
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A2C7 RID: 41671
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A2C8 RID: 41672
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A2C9 RID: 41673
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000DE2 RID: 3554
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass60_0")]
		public sealed class __c__DisplayClass60_0 : Il2CppSystem.Object
		{
			// Token: 0x0601006F RID: 65647 RVA: 0x003BEE9C File Offset: 0x003BD09C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass60_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass60_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass60_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass60_0>.NativeClassPtr, "<>4__this");
				SceneDirector.__c__DisplayClass60_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass60_0>.NativeClassPtr, "label");
				SceneDirector.__c__DisplayClass60_0.NativeFieldInfoPtr_wayPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass60_0>.NativeClassPtr, "wayPoints");
				SceneDirector.__c__DisplayClass60_0.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass60_0>.NativeClassPtr, "speedMultiplier");
				SceneDirector.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass60_0>.NativeClassPtr, 100683967);
				SceneDirector.__c__DisplayClass60_0.NativeMethodInfoPtr__MoveCharacterAsync_b__0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass60_0>.NativeClassPtr, 100683968);
			}

			// Token: 0x06010070 RID: 65648 RVA: 0x003BEF40 File Offset: 0x003BD140
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass60_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass60_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010071 RID: 65649 RVA: 0x003BEF7C File Offset: 0x003BD17C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253582, XrefRangeEnd = 253583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MoveCharacterAsync_b__0(Action call)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass60_0.NativeMethodInfoPtr__MoveCharacterAsync_b__0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010072 RID: 65650 RVA: 0x0008B487 File Offset: 0x00089687
			public __c__DisplayClass60_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053BD RID: 21437
			// (get) Token: 0x06010073 RID: 65651 RVA: 0x003BEFC0 File Offset: 0x003BD1C0
			// (set) Token: 0x06010074 RID: 65652 RVA: 0x0008B490 File Offset: 0x00089690
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053BE RID: 21438
			// (get) Token: 0x06010075 RID: 65653 RVA: 0x003BEFF0 File Offset: 0x003BD1F0
			// (set) Token: 0x06010076 RID: 65654 RVA: 0x0008B4AF File Offset: 0x000896AF
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass60_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass60_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170053BF RID: 21439
			// (get) Token: 0x06010077 RID: 65655 RVA: 0x003BF018 File Offset: 0x003BD218
			// (set) Token: 0x06010078 RID: 65656 RVA: 0x0008B4CE File Offset: 0x000896CE
			public unsafe Il2CppStructArray<Vector2> wayPoints
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass60_0.NativeFieldInfoPtr_wayPoints);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass60_0.NativeFieldInfoPtr_wayPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053C0 RID: 21440
			// (get) Token: 0x06010079 RID: 65657 RVA: 0x003BF048 File Offset: 0x003BD248
			// (set) Token: 0x0601007A RID: 65658 RVA: 0x0008B4ED File Offset: 0x000896ED
			public unsafe float speedMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass60_0.NativeFieldInfoPtr_speedMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass60_0.NativeFieldInfoPtr_speedMultiplier)) = value;
				}
			}

			// Token: 0x0400A2CA RID: 41674
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A2CB RID: 41675
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x0400A2CC RID: 41676
			private static readonly IntPtr NativeFieldInfoPtr_wayPoints;

			// Token: 0x0400A2CD RID: 41677
			private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

			// Token: 0x0400A2CE RID: 41678
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A2CF RID: 41679
			private static readonly IntPtr NativeMethodInfoPtr__MoveCharacterAsync_b__0_Internal_Void_Action_0;
		}

		// Token: 0x02000DE3 RID: 3555
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass61_0")]
		public sealed class __c__DisplayClass61_0 : Il2CppSystem.Object
		{
			// Token: 0x0601007B RID: 65659 RVA: 0x003BF070 File Offset: 0x003BD270
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass61_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr, "character");
				SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr, "speedMultiplier");
				SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_wayPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr, "wayPoints");
				SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_cachedMoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr, "cachedMoveSpeedMultiplier");
				SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr, "<>4__this");
				SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr, "label");
				SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_thisOnFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr, "thisOnFinishCallback");
				SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_thisWorkingCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr, "thisWorkingCoroutine");
				SceneDirector.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr, 100683969);
				SceneDirector.__c__DisplayClass61_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr, 100683970);
				SceneDirector.__c__DisplayClass61_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr, 100683971);
				SceneDirector.__c__DisplayClass61_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr, 100683972);
			}

			// Token: 0x0601007C RID: 65660 RVA: 0x003BF18C File Offset: 0x003BD38C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601007D RID: 65661 RVA: 0x003BF1C8 File Offset: 0x003BD3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253620, XrefRangeEnd = 253625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass61_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0601007E RID: 65662 RVA: 0x003BF208 File Offset: 0x003BD408
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 253632, RefRangeEnd = 253633, XrefRangeStart = 253625, XrefRangeEnd = 253632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass61_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601007F RID: 65663 RVA: 0x003BF23C File Offset: 0x003BD43C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253633, XrefRangeEnd = 253636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass61_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010080 RID: 65664 RVA: 0x0008B508 File Offset: 0x00089708
			public __c__DisplayClass61_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053C1 RID: 21441
			// (get) Token: 0x06010081 RID: 65665 RVA: 0x003BF270 File Offset: 0x003BD470
			// (set) Token: 0x06010082 RID: 65666 RVA: 0x0008B511 File Offset: 0x00089711
			public unsafe CharacterControllerUnit character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053C2 RID: 21442
			// (get) Token: 0x06010083 RID: 65667 RVA: 0x003BF2A0 File Offset: 0x003BD4A0
			// (set) Token: 0x06010084 RID: 65668 RVA: 0x0008B530 File Offset: 0x00089730
			public unsafe float speedMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_speedMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_speedMultiplier)) = value;
				}
			}

			// Token: 0x170053C3 RID: 21443
			// (get) Token: 0x06010085 RID: 65669 RVA: 0x003BF2C8 File Offset: 0x003BD4C8
			// (set) Token: 0x06010086 RID: 65670 RVA: 0x0008B54B File Offset: 0x0008974B
			public unsafe Il2CppStructArray<Vector2> wayPoints
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_wayPoints);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_wayPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053C4 RID: 21444
			// (get) Token: 0x06010087 RID: 65671 RVA: 0x003BF2F8 File Offset: 0x003BD4F8
			// (set) Token: 0x06010088 RID: 65672 RVA: 0x0008B56A File Offset: 0x0008976A
			public unsafe float cachedMoveSpeedMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_cachedMoveSpeedMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_cachedMoveSpeedMultiplier)) = value;
				}
			}

			// Token: 0x170053C5 RID: 21445
			// (get) Token: 0x06010089 RID: 65673 RVA: 0x003BF320 File Offset: 0x003BD520
			// (set) Token: 0x0601008A RID: 65674 RVA: 0x0008B585 File Offset: 0x00089785
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053C6 RID: 21446
			// (get) Token: 0x0601008B RID: 65675 RVA: 0x003BF350 File Offset: 0x003BD550
			// (set) Token: 0x0601008C RID: 65676 RVA: 0x0008B5A4 File Offset: 0x000897A4
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170053C7 RID: 21447
			// (get) Token: 0x0601008D RID: 65677 RVA: 0x003BF378 File Offset: 0x003BD578
			// (set) Token: 0x0601008E RID: 65678 RVA: 0x0008B5C3 File Offset: 0x000897C3
			public unsafe Action thisOnFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_thisOnFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_thisOnFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053C8 RID: 21448
			// (get) Token: 0x0601008F RID: 65679 RVA: 0x003BF3A8 File Offset: 0x003BD5A8
			// (set) Token: 0x06010090 RID: 65680 RVA: 0x0008B5E2 File Offset: 0x000897E2
			public unsafe Coroutine thisWorkingCoroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_thisWorkingCoroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.NativeFieldInfoPtr_thisWorkingCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A2D0 RID: 41680
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x0400A2D1 RID: 41681
			private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

			// Token: 0x0400A2D2 RID: 41682
			private static readonly IntPtr NativeFieldInfoPtr_wayPoints;

			// Token: 0x0400A2D3 RID: 41683
			private static readonly IntPtr NativeFieldInfoPtr_cachedMoveSpeedMultiplier;

			// Token: 0x0400A2D4 RID: 41684
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A2D5 RID: 41685
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x0400A2D6 RID: 41686
			private static readonly IntPtr NativeFieldInfoPtr_thisOnFinishCallback;

			// Token: 0x0400A2D7 RID: 41687
			private static readonly IntPtr NativeFieldInfoPtr_thisWorkingCoroutine;

			// Token: 0x0400A2D8 RID: 41688
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A2D9 RID: 41689
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0400A2DA RID: 41690
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400A2DB RID: 41691
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;

			// Token: 0x020010A8 RID: 4264
			[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass61_0+<<MoveCharacter>g__MovingLoop|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06012240 RID: 74304 RVA: 0x00423634 File Offset: 0x00421834
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique()
				{
					Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0>.NativeClassPtr, "<<MoveCharacter>g__MovingLoop|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr);
					SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr, "<>1__state");
					SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr, "<>2__current");
					SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr, "<>4__this");
					SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr, "<>7__wrap1");
					SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr, "<>7__wrap2");
					SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr__endPosition_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr, "<endPosition>5__4");
					SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr, 100683973);
					SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr, 100683974);
					SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr, 100683975);
					SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr, 100683976);
					SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr, 100683977);
					SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr, 100683978);
				}

				// Token: 0x06012241 RID: 74305 RVA: 0x00423750 File Offset: 0x00421950
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012242 RID: 74306 RVA: 0x00423798 File Offset: 0x00421998
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012243 RID: 74307 RVA: 0x004237CC File Offset: 0x004219CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253583, XrefRangeEnd = 253614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005EC3 RID: 24259
				// (get) Token: 0x06012244 RID: 74308 RVA: 0x00423808 File Offset: 0x00421A08
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012245 RID: 74309 RVA: 0x00423848 File Offset: 0x00421A48
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253614, XrefRangeEnd = 253620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005EC4 RID: 24260
				// (get) Token: 0x06012246 RID: 74310 RVA: 0x0042387C File Offset: 0x00421A7C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012247 RID: 74311 RVA: 0x0009D99D File Offset: 0x0009BB9D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005EBD RID: 24253
				// (get) Token: 0x06012248 RID: 74312 RVA: 0x004238BC File Offset: 0x00421ABC
				// (set) Token: 0x06012249 RID: 74313 RVA: 0x0009D9A6 File Offset: 0x0009BBA6
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005EBE RID: 24254
				// (get) Token: 0x0601224A RID: 74314 RVA: 0x004238E4 File Offset: 0x00421AE4
				// (set) Token: 0x0601224B RID: 74315 RVA: 0x0009D9C1 File Offset: 0x0009BBC1
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EBF RID: 24255
				// (get) Token: 0x0601224C RID: 74316 RVA: 0x00423914 File Offset: 0x00421B14
				// (set) Token: 0x0601224D RID: 74317 RVA: 0x0009D9E0 File Offset: 0x0009BBE0
				public unsafe SceneDirector.__c__DisplayClass61_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector.__c__DisplayClass61_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EC0 RID: 24256
				// (get) Token: 0x0601224E RID: 74318 RVA: 0x00423944 File Offset: 0x00421B44
				// (set) Token: 0x0601224F RID: 74319 RVA: 0x0009D9FF File Offset: 0x0009BBFF
				public unsafe Il2CppStructArray<Vector2> __7__wrap1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___7__wrap1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EC1 RID: 24257
				// (get) Token: 0x06012250 RID: 74320 RVA: 0x00423974 File Offset: 0x00421B74
				// (set) Token: 0x06012251 RID: 74321 RVA: 0x0009DA1E File Offset: 0x0009BC1E
				public unsafe int __7__wrap2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___7__wrap2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr___7__wrap2)) = value;
					}
				}

				// Token: 0x17005EC2 RID: 24258
				// (get) Token: 0x06012252 RID: 74322 RVA: 0x0042399C File Offset: 0x00421B9C
				// (set) Token: 0x06012253 RID: 74323 RVA: 0x0009DA39 File Offset: 0x0009BC39
				public unsafe Vector2 _endPosition_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr__endPosition_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass61_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInVeObObUnique.NativeFieldInfoPtr__endPosition_5__4)) = value;
					}
				}

				// Token: 0x0400B7DA RID: 47066
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B7DB RID: 47067
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B7DC RID: 47068
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B7DD RID: 47069
				private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

				// Token: 0x0400B7DE RID: 47070
				private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

				// Token: 0x0400B7DF RID: 47071
				private static readonly IntPtr NativeFieldInfoPtr__endPosition_5__4;

				// Token: 0x0400B7E0 RID: 47072
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B7E1 RID: 47073
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B7E2 RID: 47074
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B7E3 RID: 47075
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B7E4 RID: 47076
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B7E5 RID: 47077
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000DE4 RID: 3556
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass62_0")]
		public sealed class __c__DisplayClass62_0 : Il2CppSystem.Object
		{
			// Token: 0x06010091 RID: 65681 RVA: 0x003BF3D8 File Offset: 0x003BD5D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass62_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass62_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass62_0>.NativeClassPtr, "<>4__this");
				SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass62_0>.NativeClassPtr, "label");
				SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass62_0>.NativeClassPtr, "character");
				SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_wayPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass62_0>.NativeClassPtr, "wayPoints");
				SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass62_0>.NativeClassPtr, "speedMultiplier");
				SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_onFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass62_0>.NativeClassPtr, "onFinished");
				SceneDirector.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass62_0>.NativeClassPtr, 100683979);
				SceneDirector.__c__DisplayClass62_0.NativeMethodInfoPtr__MoveCharacterNoAnimation_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass62_0>.NativeClassPtr, 100683980);
				SceneDirector.__c__DisplayClass62_0.NativeMethodInfoPtr__MoveCharacterNoAnimation_b__1_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass62_0>.NativeClassPtr, 100683981);
			}

			// Token: 0x06010092 RID: 65682 RVA: 0x003BF4B8 File Offset: 0x003BD6B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass62_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010093 RID: 65683 RVA: 0x003BF4F4 File Offset: 0x003BD6F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253636, XrefRangeEnd = 253640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MoveCharacterNoAnimation_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass62_0.NativeMethodInfoPtr__MoveCharacterNoAnimation_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010094 RID: 65684 RVA: 0x003BF528 File Offset: 0x003BD728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253640, XrefRangeEnd = 253642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _MoveCharacterNoAnimation_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass62_0.NativeMethodInfoPtr__MoveCharacterNoAnimation_b__1_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06010095 RID: 65685 RVA: 0x0008B601 File Offset: 0x00089801
			public __c__DisplayClass62_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053C9 RID: 21449
			// (get) Token: 0x06010096 RID: 65686 RVA: 0x003BF568 File Offset: 0x003BD768
			// (set) Token: 0x06010097 RID: 65687 RVA: 0x0008B60A File Offset: 0x0008980A
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053CA RID: 21450
			// (get) Token: 0x06010098 RID: 65688 RVA: 0x003BF598 File Offset: 0x003BD798
			// (set) Token: 0x06010099 RID: 65689 RVA: 0x0008B629 File Offset: 0x00089829
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170053CB RID: 21451
			// (get) Token: 0x0601009A RID: 65690 RVA: 0x003BF5C0 File Offset: 0x003BD7C0
			// (set) Token: 0x0601009B RID: 65691 RVA: 0x0008B648 File Offset: 0x00089848
			public unsafe CharacterControllerUnit character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053CC RID: 21452
			// (get) Token: 0x0601009C RID: 65692 RVA: 0x003BF5F0 File Offset: 0x003BD7F0
			// (set) Token: 0x0601009D RID: 65693 RVA: 0x0008B667 File Offset: 0x00089867
			public unsafe Il2CppStructArray<Vector2> wayPoints
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_wayPoints);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_wayPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053CD RID: 21453
			// (get) Token: 0x0601009E RID: 65694 RVA: 0x003BF620 File Offset: 0x003BD820
			// (set) Token: 0x0601009F RID: 65695 RVA: 0x0008B686 File Offset: 0x00089886
			public unsafe float speedMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_speedMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_speedMultiplier)) = value;
				}
			}

			// Token: 0x170053CE RID: 21454
			// (get) Token: 0x060100A0 RID: 65696 RVA: 0x003BF648 File Offset: 0x003BD848
			// (set) Token: 0x060100A1 RID: 65697 RVA: 0x0008B6A1 File Offset: 0x000898A1
			public unsafe Action onFinished
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_onFinished);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass62_0.NativeFieldInfoPtr_onFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A2DC RID: 41692
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A2DD RID: 41693
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x0400A2DE RID: 41694
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x0400A2DF RID: 41695
			private static readonly IntPtr NativeFieldInfoPtr_wayPoints;

			// Token: 0x0400A2E0 RID: 41696
			private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

			// Token: 0x0400A2E1 RID: 41697
			private static readonly IntPtr NativeFieldInfoPtr_onFinished;

			// Token: 0x0400A2E2 RID: 41698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A2E3 RID: 41699
			private static readonly IntPtr NativeMethodInfoPtr__MoveCharacterNoAnimation_b__0_Internal_Void_0;

			// Token: 0x0400A2E4 RID: 41700
			private static readonly IntPtr NativeMethodInfoPtr__MoveCharacterNoAnimation_b__1_Internal_IEnumerator_0;
		}

		// Token: 0x02000DE5 RID: 3557
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass63_0")]
		public sealed class __c__DisplayClass63_0 : Il2CppSystem.Object
		{
			// Token: 0x060100A2 RID: 65698 RVA: 0x003BF678 File Offset: 0x003BD878
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr, "character");
				SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr, "startPoint");
				SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr, "<>4__this");
				SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr, "label");
				SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_jumpHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr, "jumpHeight");
				SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr, "gravity");
				SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_jumpCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr, "jumpCount");
				SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_jumpInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr, "jumpInterval");
				SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_onFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr, "onFinished");
				SceneDirector.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr, 100683982);
				SceneDirector.__c__DisplayClass63_0.NativeMethodInfoPtr__CharacterJump_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr, 100683983);
				SceneDirector.__c__DisplayClass63_0.NativeMethodInfoPtr__CharacterJump_b__1_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr, 100683984);
			}

			// Token: 0x060100A3 RID: 65699 RVA: 0x003BF794 File Offset: 0x003BD994
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass63_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060100A4 RID: 65700 RVA: 0x003BF7D0 File Offset: 0x003BD9D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253642, XrefRangeEnd = 253654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CharacterJump_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass63_0.NativeMethodInfoPtr__CharacterJump_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060100A5 RID: 65701 RVA: 0x003BF804 File Offset: 0x003BDA04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253654, XrefRangeEnd = 253661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _CharacterJump_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass63_0.NativeMethodInfoPtr__CharacterJump_b__1_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060100A6 RID: 65702 RVA: 0x0008B6C0 File Offset: 0x000898C0
			public __c__DisplayClass63_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053CF RID: 21455
			// (get) Token: 0x060100A7 RID: 65703 RVA: 0x003BF844 File Offset: 0x003BDA44
			// (set) Token: 0x060100A8 RID: 65704 RVA: 0x0008B6C9 File Offset: 0x000898C9
			public unsafe CharacterControllerUnit character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053D0 RID: 21456
			// (get) Token: 0x060100A9 RID: 65705 RVA: 0x003BF874 File Offset: 0x003BDA74
			// (set) Token: 0x060100AA RID: 65706 RVA: 0x0008B6E8 File Offset: 0x000898E8
			public unsafe float startPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_startPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_startPoint)) = value;
				}
			}

			// Token: 0x170053D1 RID: 21457
			// (get) Token: 0x060100AB RID: 65707 RVA: 0x003BF89C File Offset: 0x003BDA9C
			// (set) Token: 0x060100AC RID: 65708 RVA: 0x0008B703 File Offset: 0x00089903
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053D2 RID: 21458
			// (get) Token: 0x060100AD RID: 65709 RVA: 0x003BF8CC File Offset: 0x003BDACC
			// (set) Token: 0x060100AE RID: 65710 RVA: 0x0008B722 File Offset: 0x00089922
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170053D3 RID: 21459
			// (get) Token: 0x060100AF RID: 65711 RVA: 0x003BF8F4 File Offset: 0x003BDAF4
			// (set) Token: 0x060100B0 RID: 65712 RVA: 0x0008B741 File Offset: 0x00089941
			public unsafe float jumpHeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_jumpHeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_jumpHeight)) = value;
				}
			}

			// Token: 0x170053D4 RID: 21460
			// (get) Token: 0x060100B1 RID: 65713 RVA: 0x003BF91C File Offset: 0x003BDB1C
			// (set) Token: 0x060100B2 RID: 65714 RVA: 0x0008B75C File Offset: 0x0008995C
			public unsafe float gravity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_gravity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_gravity)) = value;
				}
			}

			// Token: 0x170053D5 RID: 21461
			// (get) Token: 0x060100B3 RID: 65715 RVA: 0x003BF944 File Offset: 0x003BDB44
			// (set) Token: 0x060100B4 RID: 65716 RVA: 0x0008B777 File Offset: 0x00089977
			public unsafe int jumpCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_jumpCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_jumpCount)) = value;
				}
			}

			// Token: 0x170053D6 RID: 21462
			// (get) Token: 0x060100B5 RID: 65717 RVA: 0x003BF96C File Offset: 0x003BDB6C
			// (set) Token: 0x060100B6 RID: 65718 RVA: 0x0008B792 File Offset: 0x00089992
			public unsafe float jumpInterval
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_jumpInterval);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_jumpInterval)) = value;
				}
			}

			// Token: 0x170053D7 RID: 21463
			// (get) Token: 0x060100B7 RID: 65719 RVA: 0x003BF994 File Offset: 0x003BDB94
			// (set) Token: 0x060100B8 RID: 65720 RVA: 0x0008B7AD File Offset: 0x000899AD
			public unsafe Action onFinished
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_onFinished);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass63_0.NativeFieldInfoPtr_onFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A2E5 RID: 41701
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x0400A2E6 RID: 41702
			private static readonly IntPtr NativeFieldInfoPtr_startPoint;

			// Token: 0x0400A2E7 RID: 41703
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A2E8 RID: 41704
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x0400A2E9 RID: 41705
			private static readonly IntPtr NativeFieldInfoPtr_jumpHeight;

			// Token: 0x0400A2EA RID: 41706
			private static readonly IntPtr NativeFieldInfoPtr_gravity;

			// Token: 0x0400A2EB RID: 41707
			private static readonly IntPtr NativeFieldInfoPtr_jumpCount;

			// Token: 0x0400A2EC RID: 41708
			private static readonly IntPtr NativeFieldInfoPtr_jumpInterval;

			// Token: 0x0400A2ED RID: 41709
			private static readonly IntPtr NativeFieldInfoPtr_onFinished;

			// Token: 0x0400A2EE RID: 41710
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A2EF RID: 41711
			private static readonly IntPtr NativeMethodInfoPtr__CharacterJump_b__0_Internal_Void_0;

			// Token: 0x0400A2F0 RID: 41712
			private static readonly IntPtr NativeMethodInfoPtr__CharacterJump_b__1_Internal_IEnumerator_0;
		}

		// Token: 0x02000DE6 RID: 3558
		[ObfuscatedName("Common.SceneDirector+<CharacterJumpCoroutine>d__64")]
		public sealed class _CharacterJumpCoroutine_d__64 : Il2CppSystem.Object
		{
			// Token: 0x060100B9 RID: 65721 RVA: 0x003BF9C4 File Offset: 0x003BDBC4
			// Note: this type is marked as 'beforefieldinit'.
			static _CharacterJumpCoroutine_d__64()
			{
				Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<CharacterJumpCoroutine>d__64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr);
				SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, "<>1__state");
				SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, "<>2__current");
				SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, "transform");
				SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_jumpInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, "jumpInterval");
				SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, "gravity");
				SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_jumpHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, "jumpHeight");
				SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, "startPoint");
				SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_jumpCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, "jumpCount");
				SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_onFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, "onFinished");
				SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr__velocity_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, "<velocity>5__2");
				SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr__wait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, "<wait>5__3");
				SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr__index_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, "<index>5__4");
				SceneDirector._CharacterJumpCoroutine_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, 100683985);
				SceneDirector._CharacterJumpCoroutine_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, 100683986);
				SceneDirector._CharacterJumpCoroutine_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, 100683987);
				SceneDirector._CharacterJumpCoroutine_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, 100683988);
				SceneDirector._CharacterJumpCoroutine_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, 100683989);
				SceneDirector._CharacterJumpCoroutine_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr, 100683990);
			}

			// Token: 0x060100BA RID: 65722 RVA: 0x003BFB58 File Offset: 0x003BDD58
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CharacterJumpCoroutine_d__64(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector._CharacterJumpCoroutine_d__64>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterJumpCoroutine_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060100BB RID: 65723 RVA: 0x003BFBA0 File Offset: 0x003BDDA0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterJumpCoroutine_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060100BC RID: 65724 RVA: 0x003BFBD4 File Offset: 0x003BDDD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253661, XrefRangeEnd = 253665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterJumpCoroutine_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170053E4 RID: 21476
			// (get) Token: 0x060100BD RID: 65725 RVA: 0x003BFC10 File Offset: 0x003BDE10
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterJumpCoroutine_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060100BE RID: 65726 RVA: 0x003BFC50 File Offset: 0x003BDE50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253665, XrefRangeEnd = 253671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterJumpCoroutine_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170053E5 RID: 21477
			// (get) Token: 0x060100BF RID: 65727 RVA: 0x003BFC84 File Offset: 0x003BDE84
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterJumpCoroutine_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060100C0 RID: 65728 RVA: 0x0008B7CC File Offset: 0x000899CC
			public _CharacterJumpCoroutine_d__64(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053D8 RID: 21464
			// (get) Token: 0x060100C1 RID: 65729 RVA: 0x003BFCC4 File Offset: 0x003BDEC4
			// (set) Token: 0x060100C2 RID: 65730 RVA: 0x0008B7D5 File Offset: 0x000899D5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170053D9 RID: 21465
			// (get) Token: 0x060100C3 RID: 65731 RVA: 0x003BFCEC File Offset: 0x003BDEEC
			// (set) Token: 0x060100C4 RID: 65732 RVA: 0x0008B7F0 File Offset: 0x000899F0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053DA RID: 21466
			// (get) Token: 0x060100C5 RID: 65733 RVA: 0x003BFD1C File Offset: 0x003BDF1C
			// (set) Token: 0x060100C6 RID: 65734 RVA: 0x0008B80F File Offset: 0x00089A0F
			public unsafe Transform transform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_transform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053DB RID: 21467
			// (get) Token: 0x060100C7 RID: 65735 RVA: 0x003BFD4C File Offset: 0x003BDF4C
			// (set) Token: 0x060100C8 RID: 65736 RVA: 0x0008B82E File Offset: 0x00089A2E
			public unsafe float jumpInterval
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_jumpInterval);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_jumpInterval)) = value;
				}
			}

			// Token: 0x170053DC RID: 21468
			// (get) Token: 0x060100C9 RID: 65737 RVA: 0x003BFD74 File Offset: 0x003BDF74
			// (set) Token: 0x060100CA RID: 65738 RVA: 0x0008B849 File Offset: 0x00089A49
			public unsafe float gravity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_gravity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_gravity)) = value;
				}
			}

			// Token: 0x170053DD RID: 21469
			// (get) Token: 0x060100CB RID: 65739 RVA: 0x003BFD9C File Offset: 0x003BDF9C
			// (set) Token: 0x060100CC RID: 65740 RVA: 0x0008B864 File Offset: 0x00089A64
			public unsafe float jumpHeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_jumpHeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_jumpHeight)) = value;
				}
			}

			// Token: 0x170053DE RID: 21470
			// (get) Token: 0x060100CD RID: 65741 RVA: 0x003BFDC4 File Offset: 0x003BDFC4
			// (set) Token: 0x060100CE RID: 65742 RVA: 0x0008B87F File Offset: 0x00089A7F
			public unsafe float startPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_startPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_startPoint)) = value;
				}
			}

			// Token: 0x170053DF RID: 21471
			// (get) Token: 0x060100CF RID: 65743 RVA: 0x003BFDEC File Offset: 0x003BDFEC
			// (set) Token: 0x060100D0 RID: 65744 RVA: 0x0008B89A File Offset: 0x00089A9A
			public unsafe int jumpCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_jumpCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_jumpCount)) = value;
				}
			}

			// Token: 0x170053E0 RID: 21472
			// (get) Token: 0x060100D1 RID: 65745 RVA: 0x003BFE14 File Offset: 0x003BE014
			// (set) Token: 0x060100D2 RID: 65746 RVA: 0x0008B8B5 File Offset: 0x00089AB5
			public unsafe Action onFinished
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_onFinished);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr_onFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053E1 RID: 21473
			// (get) Token: 0x060100D3 RID: 65747 RVA: 0x003BFE44 File Offset: 0x003BE044
			// (set) Token: 0x060100D4 RID: 65748 RVA: 0x0008B8D4 File Offset: 0x00089AD4
			public unsafe Vector3 _velocity_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr__velocity_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr__velocity_5__2)) = value;
				}
			}

			// Token: 0x170053E2 RID: 21474
			// (get) Token: 0x060100D5 RID: 65749 RVA: 0x003BFE6C File Offset: 0x003BE06C
			// (set) Token: 0x060100D6 RID: 65750 RVA: 0x0008B8EF File Offset: 0x00089AEF
			public unsafe WaitForSeconds _wait_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr__wait_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr__wait_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053E3 RID: 21475
			// (get) Token: 0x060100D7 RID: 65751 RVA: 0x003BFE9C File Offset: 0x003BE09C
			// (set) Token: 0x060100D8 RID: 65752 RVA: 0x0008B90E File Offset: 0x00089B0E
			public unsafe int _index_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr__index_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterJumpCoroutine_d__64.NativeFieldInfoPtr__index_5__4)) = value;
				}
			}

			// Token: 0x0400A2F1 RID: 41713
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A2F2 RID: 41714
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A2F3 RID: 41715
			private static readonly IntPtr NativeFieldInfoPtr_transform;

			// Token: 0x0400A2F4 RID: 41716
			private static readonly IntPtr NativeFieldInfoPtr_jumpInterval;

			// Token: 0x0400A2F5 RID: 41717
			private static readonly IntPtr NativeFieldInfoPtr_gravity;

			// Token: 0x0400A2F6 RID: 41718
			private static readonly IntPtr NativeFieldInfoPtr_jumpHeight;

			// Token: 0x0400A2F7 RID: 41719
			private static readonly IntPtr NativeFieldInfoPtr_startPoint;

			// Token: 0x0400A2F8 RID: 41720
			private static readonly IntPtr NativeFieldInfoPtr_jumpCount;

			// Token: 0x0400A2F9 RID: 41721
			private static readonly IntPtr NativeFieldInfoPtr_onFinished;

			// Token: 0x0400A2FA RID: 41722
			private static readonly IntPtr NativeFieldInfoPtr__velocity_5__2;

			// Token: 0x0400A2FB RID: 41723
			private static readonly IntPtr NativeFieldInfoPtr__wait_5__3;

			// Token: 0x0400A2FC RID: 41724
			private static readonly IntPtr NativeFieldInfoPtr__index_5__4;

			// Token: 0x0400A2FD RID: 41725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A2FE RID: 41726
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A2FF RID: 41727
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A300 RID: 41728
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A301 RID: 41729
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A302 RID: 41730
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000DE7 RID: 3559
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass65_0")]
		public sealed class __c__DisplayClass65_0 : Il2CppSystem.Object
		{
			// Token: 0x060100D9 RID: 65753 RVA: 0x003BFEC4 File Offset: 0x003BE0C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass65_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass65_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass65_0>.NativeClassPtr, "<>4__this");
				SceneDirector.__c__DisplayClass65_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass65_0>.NativeClassPtr, "key");
				SceneDirector.__c__DisplayClass65_0.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass65_0>.NativeClassPtr, "character");
				SceneDirector.__c__DisplayClass65_0.NativeFieldInfoPtr_targetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass65_0>.NativeClassPtr, "targetValue");
				SceneDirector.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass65_0>.NativeClassPtr, 100683991);
				SceneDirector.__c__DisplayClass65_0.NativeMethodInfoPtr__CharacterRotationZ_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass65_0>.NativeClassPtr, 100683992);
				SceneDirector.__c__DisplayClass65_0.NativeMethodInfoPtr__CharacterRotationZ_b__1_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass65_0>.NativeClassPtr, 100683993);
			}

			// Token: 0x060100DA RID: 65754 RVA: 0x003BFF7C File Offset: 0x003BE17C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass65_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060100DB RID: 65755 RVA: 0x003BFFB8 File Offset: 0x003BE1B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253671, XrefRangeEnd = 253675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CharacterRotationZ_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass65_0.NativeMethodInfoPtr__CharacterRotationZ_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060100DC RID: 65756 RVA: 0x003BFFEC File Offset: 0x003BE1EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253675, XrefRangeEnd = 253681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _CharacterRotationZ_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass65_0.NativeMethodInfoPtr__CharacterRotationZ_b__1_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060100DD RID: 65757 RVA: 0x0008B929 File Offset: 0x00089B29
			public __c__DisplayClass65_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053E6 RID: 21478
			// (get) Token: 0x060100DE RID: 65758 RVA: 0x003C002C File Offset: 0x003BE22C
			// (set) Token: 0x060100DF RID: 65759 RVA: 0x0008B932 File Offset: 0x00089B32
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053E7 RID: 21479
			// (get) Token: 0x060100E0 RID: 65760 RVA: 0x003C005C File Offset: 0x003BE25C
			// (set) Token: 0x060100E1 RID: 65761 RVA: 0x0008B951 File Offset: 0x00089B51
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass65_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass65_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170053E8 RID: 21480
			// (get) Token: 0x060100E2 RID: 65762 RVA: 0x003C0084 File Offset: 0x003BE284
			// (set) Token: 0x060100E3 RID: 65763 RVA: 0x0008B970 File Offset: 0x00089B70
			public unsafe CharacterControllerUnit character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass65_0.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass65_0.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053E9 RID: 21481
			// (get) Token: 0x060100E4 RID: 65764 RVA: 0x003C00B4 File Offset: 0x003BE2B4
			// (set) Token: 0x060100E5 RID: 65765 RVA: 0x0008B98F File Offset: 0x00089B8F
			public unsafe float targetValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass65_0.NativeFieldInfoPtr_targetValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass65_0.NativeFieldInfoPtr_targetValue)) = value;
				}
			}

			// Token: 0x0400A303 RID: 41731
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A304 RID: 41732
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400A305 RID: 41733
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x0400A306 RID: 41734
			private static readonly IntPtr NativeFieldInfoPtr_targetValue;

			// Token: 0x0400A307 RID: 41735
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A308 RID: 41736
			private static readonly IntPtr NativeMethodInfoPtr__CharacterRotationZ_b__0_Internal_Void_0;

			// Token: 0x0400A309 RID: 41737
			private static readonly IntPtr NativeMethodInfoPtr__CharacterRotationZ_b__1_Internal_IEnumerator_0;
		}

		// Token: 0x02000DE8 RID: 3560
		[ObfuscatedName("Common.SceneDirector+<CharacterContinuousRotationZCoroutine>d__66")]
		public sealed class _CharacterContinuousRotationZCoroutine_d__66 : Il2CppSystem.Object
		{
			// Token: 0x060100E6 RID: 65766 RVA: 0x003C00DC File Offset: 0x003BE2DC
			// Note: this type is marked as 'beforefieldinit'.
			static _CharacterContinuousRotationZCoroutine_d__66()
			{
				Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<CharacterContinuousRotationZCoroutine>d__66");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr);
				SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr, "<>1__state");
				SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr, "<>2__current");
				SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr, "transform");
				SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr, "value");
				SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr__quaternion_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr, "<quaternion>5__2");
				SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr, 100683994);
				SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr, 100683995);
				SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr, 100683996);
				SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr, 100683997);
				SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr, 100683998);
				SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr, 100683999);
			}

			// Token: 0x060100E7 RID: 65767 RVA: 0x003C01E4 File Offset: 0x003BE3E4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CharacterContinuousRotationZCoroutine_d__66(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector._CharacterContinuousRotationZCoroutine_d__66>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060100E8 RID: 65768 RVA: 0x003C022C File Offset: 0x003BE42C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060100E9 RID: 65769 RVA: 0x003C0260 File Offset: 0x003BE460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253681, XrefRangeEnd = 253689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170053EF RID: 21487
			// (get) Token: 0x060100EA RID: 65770 RVA: 0x003C029C File Offset: 0x003BE49C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060100EB RID: 65771 RVA: 0x003C02DC File Offset: 0x003BE4DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253689, XrefRangeEnd = 253695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170053F0 RID: 21488
			// (get) Token: 0x060100EC RID: 65772 RVA: 0x003C0310 File Offset: 0x003BE510
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060100ED RID: 65773 RVA: 0x0008B9AA File Offset: 0x00089BAA
			public _CharacterContinuousRotationZCoroutine_d__66(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053EA RID: 21482
			// (get) Token: 0x060100EE RID: 65774 RVA: 0x003C0350 File Offset: 0x003BE550
			// (set) Token: 0x060100EF RID: 65775 RVA: 0x0008B9B3 File Offset: 0x00089BB3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170053EB RID: 21483
			// (get) Token: 0x060100F0 RID: 65776 RVA: 0x003C0378 File Offset: 0x003BE578
			// (set) Token: 0x060100F1 RID: 65777 RVA: 0x0008B9CE File Offset: 0x00089BCE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053EC RID: 21484
			// (get) Token: 0x060100F2 RID: 65778 RVA: 0x003C03A8 File Offset: 0x003BE5A8
			// (set) Token: 0x060100F3 RID: 65779 RVA: 0x0008B9ED File Offset: 0x00089BED
			public unsafe Transform transform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr_transform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053ED RID: 21485
			// (get) Token: 0x060100F4 RID: 65780 RVA: 0x003C03D8 File Offset: 0x003BE5D8
			// (set) Token: 0x060100F5 RID: 65781 RVA: 0x0008BA0C File Offset: 0x00089C0C
			public unsafe float value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x170053EE RID: 21486
			// (get) Token: 0x060100F6 RID: 65782 RVA: 0x003C0400 File Offset: 0x003BE600
			// (set) Token: 0x060100F7 RID: 65783 RVA: 0x0008BA27 File Offset: 0x00089C27
			public unsafe Quaternion _quaternion_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr__quaternion_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterContinuousRotationZCoroutine_d__66.NativeFieldInfoPtr__quaternion_5__2)) = value;
				}
			}

			// Token: 0x0400A30A RID: 41738
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A30B RID: 41739
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A30C RID: 41740
			private static readonly IntPtr NativeFieldInfoPtr_transform;

			// Token: 0x0400A30D RID: 41741
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400A30E RID: 41742
			private static readonly IntPtr NativeFieldInfoPtr__quaternion_5__2;

			// Token: 0x0400A30F RID: 41743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A310 RID: 41744
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A311 RID: 41745
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A312 RID: 41746
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A313 RID: 41747
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A314 RID: 41748
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000DE9 RID: 3561
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : Il2CppSystem.Object
		{
			// Token: 0x060100F8 RID: 65784 RVA: 0x003C0428 File Offset: 0x003BE628
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass67_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass67_0>.NativeClassPtr, "character");
				SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_oldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass67_0>.NativeClassPtr, "oldPosition");
				SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass67_0>.NativeClassPtr, "<>4__this");
				SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass67_0>.NativeClassPtr, "label");
				SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass67_0>.NativeClassPtr, "amplitude");
				SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass67_0>.NativeClassPtr, "duration");
				SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_onFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass67_0>.NativeClassPtr, "onFinished");
				SceneDirector.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass67_0>.NativeClassPtr, 100684000);
				SceneDirector.__c__DisplayClass67_0.NativeMethodInfoPtr__CharacterShake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass67_0>.NativeClassPtr, 100684001);
				SceneDirector.__c__DisplayClass67_0.NativeMethodInfoPtr__CharacterShake_b__1_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass67_0>.NativeClassPtr, 100684002);
			}

			// Token: 0x060100F9 RID: 65785 RVA: 0x003C051C File Offset: 0x003BE71C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass67_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060100FA RID: 65786 RVA: 0x003C0558 File Offset: 0x003BE758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253695, XrefRangeEnd = 253705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CharacterShake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass67_0.NativeMethodInfoPtr__CharacterShake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060100FB RID: 65787 RVA: 0x003C058C File Offset: 0x003BE78C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253705, XrefRangeEnd = 253712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _CharacterShake_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass67_0.NativeMethodInfoPtr__CharacterShake_b__1_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060100FC RID: 65788 RVA: 0x0008BA42 File Offset: 0x00089C42
			public __c__DisplayClass67_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053F1 RID: 21489
			// (get) Token: 0x060100FD RID: 65789 RVA: 0x003C05CC File Offset: 0x003BE7CC
			// (set) Token: 0x060100FE RID: 65790 RVA: 0x0008BA4B File Offset: 0x00089C4B
			public unsafe CharacterControllerUnit character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053F2 RID: 21490
			// (get) Token: 0x060100FF RID: 65791 RVA: 0x003C05FC File Offset: 0x003BE7FC
			// (set) Token: 0x06010100 RID: 65792 RVA: 0x0008BA6A File Offset: 0x00089C6A
			public unsafe Vector3 oldPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_oldPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_oldPosition)) = value;
				}
			}

			// Token: 0x170053F3 RID: 21491
			// (get) Token: 0x06010101 RID: 65793 RVA: 0x003C0624 File Offset: 0x003BE824
			// (set) Token: 0x06010102 RID: 65794 RVA: 0x0008BA85 File Offset: 0x00089C85
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053F4 RID: 21492
			// (get) Token: 0x06010103 RID: 65795 RVA: 0x003C0654 File Offset: 0x003BE854
			// (set) Token: 0x06010104 RID: 65796 RVA: 0x0008BAA4 File Offset: 0x00089CA4
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170053F5 RID: 21493
			// (get) Token: 0x06010105 RID: 65797 RVA: 0x003C067C File Offset: 0x003BE87C
			// (set) Token: 0x06010106 RID: 65798 RVA: 0x0008BAC3 File Offset: 0x00089CC3
			public unsafe Vector2 amplitude
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_amplitude);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_amplitude)) = value;
				}
			}

			// Token: 0x170053F6 RID: 21494
			// (get) Token: 0x06010107 RID: 65799 RVA: 0x003C06A4 File Offset: 0x003BE8A4
			// (set) Token: 0x06010108 RID: 65800 RVA: 0x0008BADE File Offset: 0x00089CDE
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170053F7 RID: 21495
			// (get) Token: 0x06010109 RID: 65801 RVA: 0x003C06CC File Offset: 0x003BE8CC
			// (set) Token: 0x0601010A RID: 65802 RVA: 0x0008BAF9 File Offset: 0x00089CF9
			public unsafe Action onFinished
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_onFinished);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass67_0.NativeFieldInfoPtr_onFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A315 RID: 41749
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x0400A316 RID: 41750
			private static readonly IntPtr NativeFieldInfoPtr_oldPosition;

			// Token: 0x0400A317 RID: 41751
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A318 RID: 41752
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x0400A319 RID: 41753
			private static readonly IntPtr NativeFieldInfoPtr_amplitude;

			// Token: 0x0400A31A RID: 41754
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400A31B RID: 41755
			private static readonly IntPtr NativeFieldInfoPtr_onFinished;

			// Token: 0x0400A31C RID: 41756
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A31D RID: 41757
			private static readonly IntPtr NativeMethodInfoPtr__CharacterShake_b__0_Internal_Void_0;

			// Token: 0x0400A31E RID: 41758
			private static readonly IntPtr NativeMethodInfoPtr__CharacterShake_b__1_Internal_IEnumerator_0;
		}

		// Token: 0x02000DEA RID: 3562
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass68_0")]
		public sealed class __c__DisplayClass68_0 : Il2CppSystem.Object
		{
			// Token: 0x0601010B RID: 65803 RVA: 0x003C06FC File Offset: 0x003BE8FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass68_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass68_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass68_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr_workCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass68_0>.NativeClassPtr, "workCoroutine");
				SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass68_0>.NativeClassPtr, "<>4__this");
				SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass68_0>.NativeClassPtr, "character");
				SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr_oldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass68_0>.NativeClassPtr, "oldPosition");
				SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr_coroutineKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass68_0>.NativeClassPtr, "coroutineKey");
				SceneDirector.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass68_0>.NativeClassPtr, 100684003);
				SceneDirector.__c__DisplayClass68_0.NativeMethodInfoPtr__CharacterShakeUnmanaged_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass68_0>.NativeClassPtr, 100684004);
			}

			// Token: 0x0601010C RID: 65804 RVA: 0x003C07B4 File Offset: 0x003BE9B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass68_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass68_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601010D RID: 65805 RVA: 0x003C07F0 File Offset: 0x003BE9F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253712, XrefRangeEnd = 253723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CharacterShakeUnmanaged_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass68_0.NativeMethodInfoPtr__CharacterShakeUnmanaged_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601010E RID: 65806 RVA: 0x0008BB18 File Offset: 0x00089D18
			public __c__DisplayClass68_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053F8 RID: 21496
			// (get) Token: 0x0601010F RID: 65807 RVA: 0x003C0824 File Offset: 0x003BEA24
			// (set) Token: 0x06010110 RID: 65808 RVA: 0x0008BB21 File Offset: 0x00089D21
			public unsafe Coroutine workCoroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr_workCoroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr_workCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053F9 RID: 21497
			// (get) Token: 0x06010111 RID: 65809 RVA: 0x003C0854 File Offset: 0x003BEA54
			// (set) Token: 0x06010112 RID: 65810 RVA: 0x0008BB40 File Offset: 0x00089D40
			public unsafe SceneDirector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053FA RID: 21498
			// (get) Token: 0x06010113 RID: 65811 RVA: 0x003C0884 File Offset: 0x003BEA84
			// (set) Token: 0x06010114 RID: 65812 RVA: 0x0008BB5F File Offset: 0x00089D5F
			public unsafe CharacterControllerUnit character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053FB RID: 21499
			// (get) Token: 0x06010115 RID: 65813 RVA: 0x003C08B4 File Offset: 0x003BEAB4
			// (set) Token: 0x06010116 RID: 65814 RVA: 0x0008BB7E File Offset: 0x00089D7E
			public unsafe Vector3 oldPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr_oldPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr_oldPosition)) = value;
				}
			}

			// Token: 0x170053FC RID: 21500
			// (get) Token: 0x06010117 RID: 65815 RVA: 0x003C08DC File Offset: 0x003BEADC
			// (set) Token: 0x06010118 RID: 65816 RVA: 0x0008BB99 File Offset: 0x00089D99
			public unsafe string coroutineKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr_coroutineKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass68_0.NativeFieldInfoPtr_coroutineKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A31F RID: 41759
			private static readonly IntPtr NativeFieldInfoPtr_workCoroutine;

			// Token: 0x0400A320 RID: 41760
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A321 RID: 41761
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x0400A322 RID: 41762
			private static readonly IntPtr NativeFieldInfoPtr_oldPosition;

			// Token: 0x0400A323 RID: 41763
			private static readonly IntPtr NativeFieldInfoPtr_coroutineKey;

			// Token: 0x0400A324 RID: 41764
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A325 RID: 41765
			private static readonly IntPtr NativeMethodInfoPtr__CharacterShakeUnmanaged_b__0_Internal_Void_0;
		}

		// Token: 0x02000DEB RID: 3563
		[ObfuscatedName("Common.SceneDirector+<CharacterShakeCoroutine>d__69")]
		public sealed class _CharacterShakeCoroutine_d__69 : Il2CppSystem.Object
		{
			// Token: 0x06010119 RID: 65817 RVA: 0x003C0904 File Offset: 0x003BEB04
			// Note: this type is marked as 'beforefieldinit'.
			static _CharacterShakeCoroutine_d__69()
			{
				Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<CharacterShakeCoroutine>d__69");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr);
				SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, "<>1__state");
				SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, "<>2__current");
				SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, "duration");
				SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, "transform");
				SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_oldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, "oldPosition");
				SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, "amplitude");
				SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_onFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, "onFinished");
				SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr__isUnlimited_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, "<isUnlimited>5__2");
				SceneDirector._CharacterShakeCoroutine_d__69.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, 100684005);
				SceneDirector._CharacterShakeCoroutine_d__69.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, 100684006);
				SceneDirector._CharacterShakeCoroutine_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, 100684007);
				SceneDirector._CharacterShakeCoroutine_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, 100684008);
				SceneDirector._CharacterShakeCoroutine_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, 100684009);
				SceneDirector._CharacterShakeCoroutine_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr, 100684010);
			}

			// Token: 0x0601011A RID: 65818 RVA: 0x003C0A48 File Offset: 0x003BEC48
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CharacterShakeCoroutine_d__69(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector._CharacterShakeCoroutine_d__69>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterShakeCoroutine_d__69.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601011B RID: 65819 RVA: 0x003C0A90 File Offset: 0x003BEC90
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterShakeCoroutine_d__69.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601011C RID: 65820 RVA: 0x003C0AC4 File Offset: 0x003BECC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253723, XrefRangeEnd = 253743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterShakeCoroutine_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005405 RID: 21509
			// (get) Token: 0x0601011D RID: 65821 RVA: 0x003C0B00 File Offset: 0x003BED00
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterShakeCoroutine_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0601011E RID: 65822 RVA: 0x003C0B40 File Offset: 0x003BED40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253743, XrefRangeEnd = 253749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterShakeCoroutine_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005406 RID: 21510
			// (get) Token: 0x0601011F RID: 65823 RVA: 0x003C0B74 File Offset: 0x003BED74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector._CharacterShakeCoroutine_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06010120 RID: 65824 RVA: 0x0008BBB8 File Offset: 0x00089DB8
			public _CharacterShakeCoroutine_d__69(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170053FD RID: 21501
			// (get) Token: 0x06010121 RID: 65825 RVA: 0x003C0BB4 File Offset: 0x003BEDB4
			// (set) Token: 0x06010122 RID: 65826 RVA: 0x0008BBC1 File Offset: 0x00089DC1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170053FE RID: 21502
			// (get) Token: 0x06010123 RID: 65827 RVA: 0x003C0BDC File Offset: 0x003BEDDC
			// (set) Token: 0x06010124 RID: 65828 RVA: 0x0008BBDC File Offset: 0x00089DDC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170053FF RID: 21503
			// (get) Token: 0x06010125 RID: 65829 RVA: 0x003C0C0C File Offset: 0x003BEE0C
			// (set) Token: 0x06010126 RID: 65830 RVA: 0x0008BBFB File Offset: 0x00089DFB
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17005400 RID: 21504
			// (get) Token: 0x06010127 RID: 65831 RVA: 0x003C0C34 File Offset: 0x003BEE34
			// (set) Token: 0x06010128 RID: 65832 RVA: 0x0008BC16 File Offset: 0x00089E16
			public unsafe Transform transform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_transform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005401 RID: 21505
			// (get) Token: 0x06010129 RID: 65833 RVA: 0x003C0C64 File Offset: 0x003BEE64
			// (set) Token: 0x0601012A RID: 65834 RVA: 0x0008BC35 File Offset: 0x00089E35
			public unsafe Vector3 oldPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_oldPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_oldPosition)) = value;
				}
			}

			// Token: 0x17005402 RID: 21506
			// (get) Token: 0x0601012B RID: 65835 RVA: 0x003C0C8C File Offset: 0x003BEE8C
			// (set) Token: 0x0601012C RID: 65836 RVA: 0x0008BC50 File Offset: 0x00089E50
			public unsafe Vector2 amplitude
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_amplitude);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_amplitude)) = value;
				}
			}

			// Token: 0x17005403 RID: 21507
			// (get) Token: 0x0601012D RID: 65837 RVA: 0x003C0CB4 File Offset: 0x003BEEB4
			// (set) Token: 0x0601012E RID: 65838 RVA: 0x0008BC6B File Offset: 0x00089E6B
			public unsafe Action onFinished
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_onFinished);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr_onFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005404 RID: 21508
			// (get) Token: 0x0601012F RID: 65839 RVA: 0x003C0CE4 File Offset: 0x003BEEE4
			// (set) Token: 0x06010130 RID: 65840 RVA: 0x0008BC8A File Offset: 0x00089E8A
			public unsafe bool _isUnlimited_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr__isUnlimited_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector._CharacterShakeCoroutine_d__69.NativeFieldInfoPtr__isUnlimited_5__2)) = value;
				}
			}

			// Token: 0x0400A326 RID: 41766
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A327 RID: 41767
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A328 RID: 41768
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400A329 RID: 41769
			private static readonly IntPtr NativeFieldInfoPtr_transform;

			// Token: 0x0400A32A RID: 41770
			private static readonly IntPtr NativeFieldInfoPtr_oldPosition;

			// Token: 0x0400A32B RID: 41771
			private static readonly IntPtr NativeFieldInfoPtr_amplitude;

			// Token: 0x0400A32C RID: 41772
			private static readonly IntPtr NativeFieldInfoPtr_onFinished;

			// Token: 0x0400A32D RID: 41773
			private static readonly IntPtr NativeFieldInfoPtr__isUnlimited_5__2;

			// Token: 0x0400A32E RID: 41774
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A32F RID: 41775
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A330 RID: 41776
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A331 RID: 41777
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A332 RID: 41778
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A333 RID: 41779
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000DEC RID: 3564
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass78_0")]
		public sealed class __c__DisplayClass78_0 : Il2CppSystem.Object
		{
			// Token: 0x06010131 RID: 65841 RVA: 0x003C0D0C File Offset: 0x003BEF0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass78_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass78_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_needDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass78_0>.NativeClassPtr, "needDestroy");
				SceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass78_0>.NativeClassPtr, "instance");
				SceneDirector.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass78_0>.NativeClassPtr, 100684011);
				SceneDirector.__c__DisplayClass78_0.NativeMethodInfoPtr__RemoveWorldOverlay_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass78_0>.NativeClassPtr, 100684012);
				SceneDirector.__c__DisplayClass78_0.NativeMethodInfoPtr__RemoveWorldOverlay_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass78_0>.NativeClassPtr, 100684013);
			}

			// Token: 0x06010132 RID: 65842 RVA: 0x003C0D9C File Offset: 0x003BEF9C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass78_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010133 RID: 65843 RVA: 0x003C0DD8 File Offset: 0x003BEFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253749, XrefRangeEnd = 253753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RemoveWorldOverlay_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass78_0.NativeMethodInfoPtr__RemoveWorldOverlay_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010134 RID: 65844 RVA: 0x003C0E0C File Offset: 0x003BF00C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253753, XrefRangeEnd = 253757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RemoveWorldOverlay_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass78_0.NativeMethodInfoPtr__RemoveWorldOverlay_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010135 RID: 65845 RVA: 0x0008BCA5 File Offset: 0x00089EA5
			public __c__DisplayClass78_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005407 RID: 21511
			// (get) Token: 0x06010136 RID: 65846 RVA: 0x003C0E40 File Offset: 0x003BF040
			// (set) Token: 0x06010137 RID: 65847 RVA: 0x0008BCAE File Offset: 0x00089EAE
			public unsafe bool needDestroy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_needDestroy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_needDestroy)) = value;
				}
			}

			// Token: 0x17005408 RID: 21512
			// (get) Token: 0x06010138 RID: 65848 RVA: 0x003C0E68 File Offset: 0x003BF068
			// (set) Token: 0x06010139 RID: 65849 RVA: 0x0008BCC9 File Offset: 0x00089EC9
			public unsafe GameObject instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass78_0.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A334 RID: 41780
			private static readonly IntPtr NativeFieldInfoPtr_needDestroy;

			// Token: 0x0400A335 RID: 41781
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x0400A336 RID: 41782
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A337 RID: 41783
			private static readonly IntPtr NativeMethodInfoPtr__RemoveWorldOverlay_b__0_Internal_Void_0;

			// Token: 0x0400A338 RID: 41784
			private static readonly IntPtr NativeMethodInfoPtr__RemoveWorldOverlay_b__1_Internal_Void_0;
		}

		// Token: 0x02000DED RID: 3565
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass80_0")]
		public sealed class __c__DisplayClass80_0 : Il2CppSystem.Object
		{
			// Token: 0x0601013A RID: 65850 RVA: 0x003C0E98 File Offset: 0x003BF098
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass80_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass80_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass80_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass80_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass80_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass80_0>.NativeClassPtr, "onFinish");
				SceneDirector.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass80_0>.NativeClassPtr, 100684014);
				SceneDirector.__c__DisplayClass80_0.NativeMethodInfoPtr__OpenLogicBranchUISelectionPanel_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass80_0>.NativeClassPtr, 100684015);
			}

			// Token: 0x0601013B RID: 65851 RVA: 0x003C0F00 File Offset: 0x003BF100
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass80_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass80_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601013C RID: 65852 RVA: 0x003C0F3C File Offset: 0x003BF13C
			[CallerCount(0)]
			public unsafe void _OpenLogicBranchUISelectionPanel_b__0(bool x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass80_0.NativeMethodInfoPtr__OpenLogicBranchUISelectionPanel_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601013D RID: 65853 RVA: 0x0008BCE8 File Offset: 0x00089EE8
			public __c__DisplayClass80_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005409 RID: 21513
			// (get) Token: 0x0601013E RID: 65854 RVA: 0x003C0F7C File Offset: 0x003BF17C
			// (set) Token: 0x0601013F RID: 65855 RVA: 0x0008BCF1 File Offset: 0x00089EF1
			public unsafe Action<bool> onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass80_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass80_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A339 RID: 41785
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x0400A33A RID: 41786
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A33B RID: 41787
			private static readonly IntPtr NativeMethodInfoPtr__OpenLogicBranchUISelectionPanel_b__0_Internal_Void_Boolean_0;
		}

		// Token: 0x02000DEE RID: 3566
		[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass81_0")]
		public sealed class __c__DisplayClass81_0 : Il2CppSystem.Object
		{
			// Token: 0x06010140 RID: 65856 RVA: 0x003C0FAC File Offset: 0x003BF1AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass81_0()
			{
				Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector>.NativeClassPtr, "<>c__DisplayClass81_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0>.NativeClassPtr);
				SceneDirector.__c__DisplayClass81_0.NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0>.NativeClassPtr, "seconds");
				SceneDirector.__c__DisplayClass81_0.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0>.NativeClassPtr, "onFinish");
				SceneDirector.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0>.NativeClassPtr, 100684016);
				SceneDirector.__c__DisplayClass81_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0>.NativeClassPtr, 100684017);
			}

			// Token: 0x06010141 RID: 65857 RVA: 0x003C1028 File Offset: 0x003BF228
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass81_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010142 RID: 65858 RVA: 0x003C1064 File Offset: 0x003BF264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253768, XrefRangeEnd = 253773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass81_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06010143 RID: 65859 RVA: 0x0008BD10 File Offset: 0x00089F10
			public __c__DisplayClass81_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700540A RID: 21514
			// (get) Token: 0x06010144 RID: 65860 RVA: 0x003C10A4 File Offset: 0x003BF2A4
			// (set) Token: 0x06010145 RID: 65861 RVA: 0x0008BD19 File Offset: 0x00089F19
			public unsafe float seconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass81_0.NativeFieldInfoPtr_seconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass81_0.NativeFieldInfoPtr_seconds)) = value;
				}
			}

			// Token: 0x1700540B RID: 21515
			// (get) Token: 0x06010146 RID: 65862 RVA: 0x003C10CC File Offset: 0x003BF2CC
			// (set) Token: 0x06010147 RID: 65863 RVA: 0x0008BD34 File Offset: 0x00089F34
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass81_0.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass81_0.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A33C RID: 41788
			private static readonly IntPtr NativeFieldInfoPtr_seconds;

			// Token: 0x0400A33D RID: 41789
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x0400A33E RID: 41790
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A33F RID: 41791
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x020010A9 RID: 4265
			[ObfuscatedName("Common.SceneDirector+<>c__DisplayClass81_0+<<Delay>g__OnDelayLoop|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06012254 RID: 74324 RVA: 0x004239C4 File Offset: 0x00421BC4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0>.NativeClassPtr, "<<Delay>g__OnDelayLoop|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684018);
					SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684019);
					SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684020);
					SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684021);
					SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684022);
					SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100684023);
				}

				// Token: 0x06012255 RID: 74325 RVA: 0x00423AA4 File Offset: 0x00421CA4
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012256 RID: 74326 RVA: 0x00423AEC File Offset: 0x00421CEC
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012257 RID: 74327 RVA: 0x00423B20 File Offset: 0x00421D20
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253757, XrefRangeEnd = 253762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005EC8 RID: 24264
				// (get) Token: 0x06012258 RID: 74328 RVA: 0x00423B5C File Offset: 0x00421D5C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012259 RID: 74329 RVA: 0x00423B9C File Offset: 0x00421D9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253762, XrefRangeEnd = 253768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005EC9 RID: 24265
				// (get) Token: 0x0601225A RID: 74330 RVA: 0x00423BD0 File Offset: 0x00421DD0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601225B RID: 74331 RVA: 0x0009DA54 File Offset: 0x0009BC54
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005EC5 RID: 24261
				// (get) Token: 0x0601225C RID: 74332 RVA: 0x00423C10 File Offset: 0x00421E10
				// (set) Token: 0x0601225D RID: 74333 RVA: 0x0009DA5D File Offset: 0x0009BC5D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005EC6 RID: 24262
				// (get) Token: 0x0601225E RID: 74334 RVA: 0x00423C38 File Offset: 0x00421E38
				// (set) Token: 0x0601225F RID: 74335 RVA: 0x0009DA78 File Offset: 0x0009BC78
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EC7 RID: 24263
				// (get) Token: 0x06012260 RID: 74336 RVA: 0x00423C68 File Offset: 0x00421E68
				// (set) Token: 0x06012261 RID: 74337 RVA: 0x0009DA97 File Offset: 0x0009BC97
				public unsafe SceneDirector.__c__DisplayClass81_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneDirector.__c__DisplayClass81_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneDirector.__c__DisplayClass81_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B7E6 RID: 47078
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B7E7 RID: 47079
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B7E8 RID: 47080
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B7E9 RID: 47081
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B7EA RID: 47082
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B7EB RID: 47083
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B7EC RID: 47084
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B7ED RID: 47085
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B7EE RID: 47086
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
