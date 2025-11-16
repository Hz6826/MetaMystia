using System;
using DayScene.Input;
using DEYU.Utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x02000453 RID: 1107
	public class AStarInputGeneratorComponent : CharacterControllerInputGeneratorComponent
	{
		// Token: 0x06007A4C RID: 31308 RVA: 0x00233F38 File Offset: 0x00232138
		// Note: this type is marked as 'beforefieldinit'.
		static AStarInputGeneratorComponent()
		{
			Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.CharacterUtility", "AStarInputGeneratorComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr);
			AStarInputGeneratorComponent.NativeFieldInfoPtr_s_ReferenceGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, "s_ReferenceGrid");
			AStarInputGeneratorComponent.NativeFieldInfoPtr_s_WaitForFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, "s_WaitForFixedUpdate");
			AStarInputGeneratorComponent.NativeFieldInfoPtr_m_LastGridPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, "m_LastGridPosition");
			AStarInputGeneratorComponent.NativeFieldInfoPtr_m_MoveCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, "m_MoveCoroutine");
			AStarInputGeneratorComponent.NativeFieldInfoPtr_m_WaitCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, "m_WaitCoroutine");
			AStarInputGeneratorComponent.NativeFieldInfoPtr__DoNotUseCollisionCounter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, "<DoNotUseCollisionCounter>k__BackingField");
			AStarInputGeneratorComponent.NativeFieldInfoPtr__OnFinish_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, "<OnFinish>k__BackingField");
			AStarInputGeneratorComponent.NativeFieldInfoPtr__OnExternalEndCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, "<OnExternalEndCallback>k__BackingField");
			AStarInputGeneratorComponent.NativeFieldInfoPtr__PathCache_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, "<PathCache>k__BackingField");
			AStarInputGeneratorComponent.NativeMethodInfoPtr_get_DoNotUseCollisionCounter_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687811);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_set_DoNotUseCollisionCounter_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687812);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_get_NotUseCollision_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687813);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_get_OnFinish_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687814);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_set_OnFinish_Private_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687815);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_get_OnExternalEndCallback_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687816);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_set_OnExternalEndCallback_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687817);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_get_PathCache_Public_get_List_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687818);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_Initialize_Public_Static_Void_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687819);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_GetGridPosition_Public_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687820);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_ComputeCharacterWorldPosition_Public_Static_Vector3_Vector3Int_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687821);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_GetWorldPosition_Public_Vector3_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687822);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_SetPath_Public_Void_Vector3Int_ScopedTempHashSetHandle_1_Vector2Int_Single_Action_CharacterRotation_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687823);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_SetPath_Public_Void_Vector3Int_ScopedTempHashSetHandle_1_Vector2Int_Single_Action_Int32_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687824);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_SetPathImpl_Private_IEnumerator_Vector3Int_ScopedTempHashSetHandle_1_Vector2Int_Single_Action_Int32_Nullable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687825);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_FinishPath_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687826);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_FollowPath_Private_IEnumerator_IList_1_Vector3Int_Nullable_1_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687827);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_MoveToTargetPosition_Private_IEnumerator_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687828);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_OnExternalStop_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687829);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_OnTimelinePositionUpdated_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687830);
			AStarInputGeneratorComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687831);
			AStarInputGeneratorComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, 100687832);
		}

		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x06007A4D RID: 31309 RVA: 0x002341D4 File Offset: 0x002323D4
		// (set) Token: 0x06007A4E RID: 31310 RVA: 0x00234210 File Offset: 0x00232410
		public unsafe int DoNotUseCollisionCounter
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 105723, RefRangeEnd = 105726, XrefRangeStart = 105723, XrefRangeEnd = 105726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_get_DoNotUseCollisionCounter_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_set_DoNotUseCollisionCounter_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x06007A4F RID: 31311 RVA: 0x00234250 File Offset: 0x00232450
		public unsafe bool NotUseCollision
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 294645, RefRangeEnd = 294647, XrefRangeStart = 294645, XrefRangeEnd = 294645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_get_NotUseCollision_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700297A RID: 10618
		// (get) Token: 0x06007A50 RID: 31312 RVA: 0x0023428C File Offset: 0x0023248C
		// (set) Token: 0x06007A51 RID: 31313 RVA: 0x002342CC File Offset: 0x002324CC
		public unsafe Action OnFinish
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73874, RefRangeEnd = 73875, XrefRangeStart = 73874, XrefRangeEnd = 73875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_get_OnFinish_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_set_OnFinish_Private_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700297B RID: 10619
		// (get) Token: 0x06007A52 RID: 31314 RVA: 0x00234310 File Offset: 0x00232510
		// (set) Token: 0x06007A53 RID: 31315 RVA: 0x00234350 File Offset: 0x00232550
		public unsafe Action OnExternalEndCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_get_OnExternalEndCallback_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43501, RefRangeEnd = 43502, XrefRangeStart = 43501, XrefRangeEnd = 43502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_set_OnExternalEndCallback_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x06007A54 RID: 31316 RVA: 0x00234394 File Offset: 0x00232594
		public unsafe List<Vector3Int> PathCache
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 54348, RefRangeEnd = 54388, XrefRangeStart = 54348, XrefRangeEnd = 54388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_get_PathCache_Public_get_List_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr3) : null;
			}
		}

		// Token: 0x06007A55 RID: 31317 RVA: 0x002343D4 File Offset: 0x002325D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294647, XrefRangeEnd = 294653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(Grid referenceGrid)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(referenceGrid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_Initialize_Public_Static_Void_Grid_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A56 RID: 31318 RVA: 0x0023440C File Offset: 0x0023260C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 294668, RefRangeEnd = 294673, XrefRangeStart = 294653, XrefRangeEnd = 294668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Int GetGridPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_GetGridPosition_Public_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x00234448 File Offset: 0x00232648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294688, RefRangeEnd = 294689, XrefRangeStart = 294673, XrefRangeEnd = 294688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ComputeCharacterWorldPosition(Vector3Int cellPosition, float extraYOffset)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cellPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraYOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_ComputeCharacterWorldPosition_Public_Static_Vector3_Vector3Int_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x00234494 File Offset: 0x00232694
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294707, RefRangeEnd = 294710, XrefRangeStart = 294689, XrefRangeEnd = 294707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetWorldPosition(Vector3Int cellPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cellPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_GetWorldPosition_Public_Vector3_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007A59 RID: 31321 RVA: 0x002344E0 File Offset: 0x002326E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 294730, RefRangeEnd = 294735, XrefRangeStart = 294710, XrefRangeEnd = 294730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPath(Vector3Int targetPt, UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int> colliderCollections, float delay, Action onFinish, DayScenePlayerInputGenerator.CharacterRotation rotationOnFinish, Nullable<Vector3> extraOnArrivalOffset = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPt;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(colliderCollections));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationOnFinish;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(extraOnArrivalOffset));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_SetPath_Public_Void_Vector3Int_ScopedTempHashSetHandle_1_Vector2Int_Single_Action_CharacterRotation_Nullable_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A5A RID: 31322 RVA: 0x0023457C File Offset: 0x0023277C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 294730, RefRangeEnd = 294735, XrefRangeStart = 294730, XrefRangeEnd = 294735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPath(Vector3Int targetPt, UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int> colliderCollections, float delay, Action onFinish, int rotationOnFinish, Nullable<Vector3> extraOnArrivalOffset = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPt;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(colliderCollections));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationOnFinish;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(extraOnArrivalOffset));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_SetPath_Public_Void_Vector3Int_ScopedTempHashSetHandle_1_Vector2Int_Single_Action_Int32_Nullable_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A5B RID: 31323 RVA: 0x00234618 File Offset: 0x00232818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294735, XrefRangeEnd = 294742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetPathImpl(Vector3Int targetPt, UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int> colliderCollections, float delay, Action onFinish, int rotationOnFinish, Nullable<Vector3> extraOnArrivalOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPt;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(colliderCollections));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onFinish);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationOnFinish;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(extraOnArrivalOffset));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_SetPathImpl_Private_IEnumerator_Vector3Int_ScopedTempHashSetHandle_1_Vector2Int_Single_Action_Int32_Nullable_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007A5C RID: 31324 RVA: 0x002346C4 File Offset: 0x002328C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294742, XrefRangeEnd = 294743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishPath(int rotationOnFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotationOnFinish;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_FinishPath_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A5D RID: 31325 RVA: 0x00234704 File Offset: 0x00232904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294743, XrefRangeEnd = 294749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FollowPath(IList<Vector3Int> path, Nullable<Vector3> extraOnArrivalOffset, int rotationOnFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(extraOnArrivalOffset));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationOnFinish;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_FollowPath_Private_IEnumerator_IList_1_Vector3Int_Nullable_1_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007A5E RID: 31326 RVA: 0x0023477C File Offset: 0x0023297C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294754, RefRangeEnd = 294755, XrefRangeStart = 294749, XrefRangeEnd = 294754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator MoveToTargetPosition(Vector3 targetWorldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetWorldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr_MoveToTargetPosition_Private_IEnumerator_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007A5F RID: 31327 RVA: 0x002347C8 File Offset: 0x002329C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294755, XrefRangeEnd = 294761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExternalStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AStarInputGeneratorComponent.NativeMethodInfoPtr_OnExternalStop_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A60 RID: 31328 RVA: 0x00234804 File Offset: 0x00232A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294761, XrefRangeEnd = 294768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTimelinePositionUpdated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AStarInputGeneratorComponent.NativeMethodInfoPtr_OnTimelinePositionUpdated_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x00234840 File Offset: 0x00232A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294768, XrefRangeEnd = 294776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AStarInputGeneratorComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A62 RID: 31330 RVA: 0x0023487C File Offset: 0x00232A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294776, XrefRangeEnd = 294785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AStarInputGeneratorComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x00042154 File Offset: 0x00040354
		public AStarInputGeneratorComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700296F RID: 10607
		// (get) Token: 0x06007A64 RID: 31332 RVA: 0x002348B8 File Offset: 0x00232AB8
		// (set) Token: 0x06007A65 RID: 31333 RVA: 0x0004215D File Offset: 0x0004035D
		public unsafe static Grid s_ReferenceGrid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AStarInputGeneratorComponent.NativeFieldInfoPtr_s_ReferenceGrid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AStarInputGeneratorComponent.NativeFieldInfoPtr_s_ReferenceGrid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002970 RID: 10608
		// (get) Token: 0x06007A66 RID: 31334 RVA: 0x002348E0 File Offset: 0x00232AE0
		// (set) Token: 0x06007A67 RID: 31335 RVA: 0x0004216F File Offset: 0x0004036F
		public unsafe static WaitForFixedUpdate s_WaitForFixedUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AStarInputGeneratorComponent.NativeFieldInfoPtr_s_WaitForFixedUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForFixedUpdate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AStarInputGeneratorComponent.NativeFieldInfoPtr_s_WaitForFixedUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002971 RID: 10609
		// (get) Token: 0x06007A68 RID: 31336 RVA: 0x00234908 File Offset: 0x00232B08
		// (set) Token: 0x06007A69 RID: 31337 RVA: 0x00042181 File Offset: 0x00040381
		public unsafe Vector3Int m_LastGridPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr_m_LastGridPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr_m_LastGridPosition)) = value;
			}
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x06007A6A RID: 31338 RVA: 0x00234930 File Offset: 0x00232B30
		// (set) Token: 0x06007A6B RID: 31339 RVA: 0x0004219C File Offset: 0x0004039C
		public unsafe Coroutine m_MoveCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr_m_MoveCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr_m_MoveCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x06007A6C RID: 31340 RVA: 0x00234960 File Offset: 0x00232B60
		// (set) Token: 0x06007A6D RID: 31341 RVA: 0x000421BB File Offset: 0x000403BB
		public unsafe Coroutine m_WaitCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr_m_WaitCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr_m_WaitCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x06007A6E RID: 31342 RVA: 0x00234990 File Offset: 0x00232B90
		// (set) Token: 0x06007A6F RID: 31343 RVA: 0x000421DA File Offset: 0x000403DA
		public unsafe int _DoNotUseCollisionCounter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr__DoNotUseCollisionCounter_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr__DoNotUseCollisionCounter_k__BackingField)) = value;
			}
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x06007A70 RID: 31344 RVA: 0x002349B8 File Offset: 0x00232BB8
		// (set) Token: 0x06007A71 RID: 31345 RVA: 0x000421F5 File Offset: 0x000403F5
		public unsafe Action _OnFinish_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr__OnFinish_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr__OnFinish_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x06007A72 RID: 31346 RVA: 0x002349E8 File Offset: 0x00232BE8
		// (set) Token: 0x06007A73 RID: 31347 RVA: 0x00042214 File Offset: 0x00040414
		public unsafe Action _OnExternalEndCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr__OnExternalEndCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr__OnExternalEndCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x06007A74 RID: 31348 RVA: 0x00234A18 File Offset: 0x00232C18
		// (set) Token: 0x06007A75 RID: 31349 RVA: 0x00042233 File Offset: 0x00040433
		public unsafe List<Vector3Int> _PathCache_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr__PathCache_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent.NativeFieldInfoPtr__PathCache_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400506F RID: 20591
		private static readonly IntPtr NativeFieldInfoPtr_s_ReferenceGrid;

		// Token: 0x04005070 RID: 20592
		private static readonly IntPtr NativeFieldInfoPtr_s_WaitForFixedUpdate;

		// Token: 0x04005071 RID: 20593
		private static readonly IntPtr NativeFieldInfoPtr_m_LastGridPosition;

		// Token: 0x04005072 RID: 20594
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveCoroutine;

		// Token: 0x04005073 RID: 20595
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitCoroutine;

		// Token: 0x04005074 RID: 20596
		private static readonly IntPtr NativeFieldInfoPtr__DoNotUseCollisionCounter_k__BackingField;

		// Token: 0x04005075 RID: 20597
		private static readonly IntPtr NativeFieldInfoPtr__OnFinish_k__BackingField;

		// Token: 0x04005076 RID: 20598
		private static readonly IntPtr NativeFieldInfoPtr__OnExternalEndCallback_k__BackingField;

		// Token: 0x04005077 RID: 20599
		private static readonly IntPtr NativeFieldInfoPtr__PathCache_k__BackingField;

		// Token: 0x04005078 RID: 20600
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotUseCollisionCounter_Public_get_Int32_0;

		// Token: 0x04005079 RID: 20601
		private static readonly IntPtr NativeMethodInfoPtr_set_DoNotUseCollisionCounter_Public_set_Void_Int32_0;

		// Token: 0x0400507A RID: 20602
		private static readonly IntPtr NativeMethodInfoPtr_get_NotUseCollision_Public_get_Boolean_0;

		// Token: 0x0400507B RID: 20603
		private static readonly IntPtr NativeMethodInfoPtr_get_OnFinish_Public_get_Action_0;

		// Token: 0x0400507C RID: 20604
		private static readonly IntPtr NativeMethodInfoPtr_set_OnFinish_Private_set_Void_Action_0;

		// Token: 0x0400507D RID: 20605
		private static readonly IntPtr NativeMethodInfoPtr_get_OnExternalEndCallback_Public_get_Action_0;

		// Token: 0x0400507E RID: 20606
		private static readonly IntPtr NativeMethodInfoPtr_set_OnExternalEndCallback_Public_set_Void_Action_0;

		// Token: 0x0400507F RID: 20607
		private static readonly IntPtr NativeMethodInfoPtr_get_PathCache_Public_get_List_1_Vector3Int_0;

		// Token: 0x04005080 RID: 20608
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_Grid_0;

		// Token: 0x04005081 RID: 20609
		private static readonly IntPtr NativeMethodInfoPtr_GetGridPosition_Public_Vector3Int_0;

		// Token: 0x04005082 RID: 20610
		private static readonly IntPtr NativeMethodInfoPtr_ComputeCharacterWorldPosition_Public_Static_Vector3_Vector3Int_Single_0;

		// Token: 0x04005083 RID: 20611
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldPosition_Public_Vector3_Vector3Int_0;

		// Token: 0x04005084 RID: 20612
		private static readonly IntPtr NativeMethodInfoPtr_SetPath_Public_Void_Vector3Int_ScopedTempHashSetHandle_1_Vector2Int_Single_Action_CharacterRotation_Nullable_1_Vector3_0;

		// Token: 0x04005085 RID: 20613
		private static readonly IntPtr NativeMethodInfoPtr_SetPath_Public_Void_Vector3Int_ScopedTempHashSetHandle_1_Vector2Int_Single_Action_Int32_Nullable_1_Vector3_0;

		// Token: 0x04005086 RID: 20614
		private static readonly IntPtr NativeMethodInfoPtr_SetPathImpl_Private_IEnumerator_Vector3Int_ScopedTempHashSetHandle_1_Vector2Int_Single_Action_Int32_Nullable_1_Vector3_0;

		// Token: 0x04005087 RID: 20615
		private static readonly IntPtr NativeMethodInfoPtr_FinishPath_Private_Void_Int32_0;

		// Token: 0x04005088 RID: 20616
		private static readonly IntPtr NativeMethodInfoPtr_FollowPath_Private_IEnumerator_IList_1_Vector3Int_Nullable_1_Vector3_Int32_0;

		// Token: 0x04005089 RID: 20617
		private static readonly IntPtr NativeMethodInfoPtr_MoveToTargetPosition_Private_IEnumerator_Vector3_0;

		// Token: 0x0400508A RID: 20618
		private static readonly IntPtr NativeMethodInfoPtr_OnExternalStop_Protected_Virtual_Void_0;

		// Token: 0x0400508B RID: 20619
		private static readonly IntPtr NativeMethodInfoPtr_OnTimelinePositionUpdated_Public_Virtual_Void_0;

		// Token: 0x0400508C RID: 20620
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400508D RID: 20621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F90 RID: 3984
		[ObfuscatedName("Common.CharacterUtility.AStarInputGeneratorComponent+<SetPathImpl>d__28")]
		public sealed class _SetPathImpl_d__28 : Il2CppSystem.Object
		{
			// Token: 0x060113C4 RID: 70596 RVA: 0x003F8890 File Offset: 0x003F6A90
			// Note: this type is marked as 'beforefieldinit'.
			static _SetPathImpl_d__28()
			{
				Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, "<SetPathImpl>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr);
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, "<>1__state");
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, "<>2__current");
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, "delay");
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, "<>4__this");
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_targetPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, "targetPt");
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_colliderCollections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, "colliderCollections");
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_onFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, "onFinish");
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_extraOnArrivalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, "extraOnArrivalOffset");
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_rotationOnFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, "rotationOnFinish");
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, 100687834);
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, 100687835);
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, 100687836);
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, 100687837);
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, 100687838);
				AStarInputGeneratorComponent._SetPathImpl_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr, 100687839);
			}

			// Token: 0x060113C5 RID: 70597 RVA: 0x003F89E8 File Offset: 0x003F6BE8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetPathImpl_d__28(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AStarInputGeneratorComponent._SetPathImpl_d__28>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060113C6 RID: 70598 RVA: 0x003F8A30 File Offset: 0x003F6C30
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060113C7 RID: 70599 RVA: 0x003F8A64 File Offset: 0x003F6C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294529, XrefRangeEnd = 294570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700599B RID: 22939
			// (get) Token: 0x060113C8 RID: 70600 RVA: 0x003F8AA0 File Offset: 0x003F6CA0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060113C9 RID: 70601 RVA: 0x003F8AE0 File Offset: 0x003F6CE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294570, XrefRangeEnd = 294576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700599C RID: 22940
			// (get) Token: 0x060113CA RID: 70602 RVA: 0x003F8B14 File Offset: 0x003F6D14
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060113CB RID: 70603 RVA: 0x00095D39 File Offset: 0x00093F39
			public _SetPathImpl_d__28(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005992 RID: 22930
			// (get) Token: 0x060113CC RID: 70604 RVA: 0x003F8B54 File Offset: 0x003F6D54
			// (set) Token: 0x060113CD RID: 70605 RVA: 0x00095D42 File Offset: 0x00093F42
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005993 RID: 22931
			// (get) Token: 0x060113CE RID: 70606 RVA: 0x003F8B7C File Offset: 0x003F6D7C
			// (set) Token: 0x060113CF RID: 70607 RVA: 0x00095D5D File Offset: 0x00093F5D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005994 RID: 22932
			// (get) Token: 0x060113D0 RID: 70608 RVA: 0x003F8BAC File Offset: 0x003F6DAC
			// (set) Token: 0x060113D1 RID: 70609 RVA: 0x00095D7C File Offset: 0x00093F7C
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17005995 RID: 22933
			// (get) Token: 0x060113D2 RID: 70610 RVA: 0x003F8BD4 File Offset: 0x003F6DD4
			// (set) Token: 0x060113D3 RID: 70611 RVA: 0x00095D97 File Offset: 0x00093F97
			public unsafe AStarInputGeneratorComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005996 RID: 22934
			// (get) Token: 0x060113D4 RID: 70612 RVA: 0x003F8C04 File Offset: 0x003F6E04
			// (set) Token: 0x060113D5 RID: 70613 RVA: 0x00095DB6 File Offset: 0x00093FB6
			public unsafe Vector3Int targetPt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_targetPt);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_targetPt)) = value;
				}
			}

			// Token: 0x17005997 RID: 22935
			// (get) Token: 0x060113D6 RID: 70614 RVA: 0x003F8C2C File Offset: 0x003F6E2C
			// (set) Token: 0x060113D7 RID: 70615 RVA: 0x00095DD1 File Offset: 0x00093FD1
			public UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int> colliderCollections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_colliderCollections);
					return new UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_colliderCollections), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005998 RID: 22936
			// (get) Token: 0x060113D8 RID: 70616 RVA: 0x003F8C5C File Offset: 0x003F6E5C
			// (set) Token: 0x060113D9 RID: 70617 RVA: 0x00095DFF File Offset: 0x00093FFF
			public unsafe Action onFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_onFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_onFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005999 RID: 22937
			// (get) Token: 0x060113DA RID: 70618 RVA: 0x003F8C8C File Offset: 0x003F6E8C
			// (set) Token: 0x060113DB RID: 70619 RVA: 0x00095E1E File Offset: 0x0009401E
			public Nullable<Vector3> extraOnArrivalOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_extraOnArrivalOffset);
					return new Nullable<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_extraOnArrivalOffset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700599A RID: 22938
			// (get) Token: 0x060113DC RID: 70620 RVA: 0x003F8CBC File Offset: 0x003F6EBC
			// (set) Token: 0x060113DD RID: 70621 RVA: 0x00095E4C File Offset: 0x0009404C
			public unsafe int rotationOnFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_rotationOnFinish);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._SetPathImpl_d__28.NativeFieldInfoPtr_rotationOnFinish)) = value;
				}
			}

			// Token: 0x0400AE52 RID: 44626
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AE53 RID: 44627
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400AE54 RID: 44628
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x0400AE55 RID: 44629
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AE56 RID: 44630
			private static readonly IntPtr NativeFieldInfoPtr_targetPt;

			// Token: 0x0400AE57 RID: 44631
			private static readonly IntPtr NativeFieldInfoPtr_colliderCollections;

			// Token: 0x0400AE58 RID: 44632
			private static readonly IntPtr NativeFieldInfoPtr_onFinish;

			// Token: 0x0400AE59 RID: 44633
			private static readonly IntPtr NativeFieldInfoPtr_extraOnArrivalOffset;

			// Token: 0x0400AE5A RID: 44634
			private static readonly IntPtr NativeFieldInfoPtr_rotationOnFinish;

			// Token: 0x0400AE5B RID: 44635
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400AE5C RID: 44636
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE5D RID: 44637
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400AE5E RID: 44638
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400AE5F RID: 44639
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE60 RID: 44640
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000F91 RID: 3985
		[ObfuscatedName("Common.CharacterUtility.AStarInputGeneratorComponent+<FollowPath>d__30")]
		public sealed class _FollowPath_d__30 : Il2CppSystem.Object
		{
			// Token: 0x060113DE RID: 70622 RVA: 0x003F8CE4 File Offset: 0x003F6EE4
			// Note: this type is marked as 'beforefieldinit'.
			static _FollowPath_d__30()
			{
				Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, "<FollowPath>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr);
				AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, "<>1__state");
				AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, "<>2__current");
				AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, "<>4__this");
				AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, "path");
				AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr_extraOnArrivalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, "extraOnArrivalOffset");
				AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr_rotationOnFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, "rotationOnFinish");
				AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, "<>7__wrap1");
				AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr__gridPoint_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, "<gridPoint>5__3");
				AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, 100687840);
				AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, 100687841);
				AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, 100687842);
				AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, 100687843);
				AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, 100687844);
				AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, 100687845);
				AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr, 100687846);
			}

			// Token: 0x060113DF RID: 70623 RVA: 0x003F8E3C File Offset: 0x003F703C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FollowPath_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AStarInputGeneratorComponent._FollowPath_d__30>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060113E0 RID: 70624 RVA: 0x003F8E84 File Offset: 0x003F7084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294576, XrefRangeEnd = 294581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060113E1 RID: 70625 RVA: 0x003F8EB8 File Offset: 0x003F70B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294581, XrefRangeEnd = 294629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060113E2 RID: 70626 RVA: 0x003F8EF4 File Offset: 0x003F70F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294629, XrefRangeEnd = 294632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170059A5 RID: 22949
			// (get) Token: 0x060113E3 RID: 70627 RVA: 0x003F8F28 File Offset: 0x003F7128
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060113E4 RID: 70628 RVA: 0x003F8F68 File Offset: 0x003F7168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294632, XrefRangeEnd = 294638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170059A6 RID: 22950
			// (get) Token: 0x060113E5 RID: 70629 RVA: 0x003F8F9C File Offset: 0x003F719C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._FollowPath_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060113E6 RID: 70630 RVA: 0x00095E67 File Offset: 0x00094067
			public _FollowPath_d__30(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700599D RID: 22941
			// (get) Token: 0x060113E7 RID: 70631 RVA: 0x003F8FDC File Offset: 0x003F71DC
			// (set) Token: 0x060113E8 RID: 70632 RVA: 0x00095E70 File Offset: 0x00094070
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700599E RID: 22942
			// (get) Token: 0x060113E9 RID: 70633 RVA: 0x003F9004 File Offset: 0x003F7204
			// (set) Token: 0x060113EA RID: 70634 RVA: 0x00095E8B File Offset: 0x0009408B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700599F RID: 22943
			// (get) Token: 0x060113EB RID: 70635 RVA: 0x003F9034 File Offset: 0x003F7234
			// (set) Token: 0x060113EC RID: 70636 RVA: 0x00095EAA File Offset: 0x000940AA
			public unsafe AStarInputGeneratorComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059A0 RID: 22944
			// (get) Token: 0x060113ED RID: 70637 RVA: 0x003F9064 File Offset: 0x003F7264
			// (set) Token: 0x060113EE RID: 70638 RVA: 0x00095EC9 File Offset: 0x000940C9
			public unsafe IList<Vector3Int> path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr_path);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Vector3Int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr_path), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059A1 RID: 22945
			// (get) Token: 0x060113EF RID: 70639 RVA: 0x003F9094 File Offset: 0x003F7294
			// (set) Token: 0x060113F0 RID: 70640 RVA: 0x00095EE8 File Offset: 0x000940E8
			public Nullable<Vector3> extraOnArrivalOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr_extraOnArrivalOffset);
					return new Nullable<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr_extraOnArrivalOffset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170059A2 RID: 22946
			// (get) Token: 0x060113F1 RID: 70641 RVA: 0x003F90C4 File Offset: 0x003F72C4
			// (set) Token: 0x060113F2 RID: 70642 RVA: 0x00095F16 File Offset: 0x00094116
			public unsafe int rotationOnFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr_rotationOnFinish);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr_rotationOnFinish)) = value;
				}
			}

			// Token: 0x170059A3 RID: 22947
			// (get) Token: 0x060113F3 RID: 70643 RVA: 0x003F90EC File Offset: 0x003F72EC
			// (set) Token: 0x060113F4 RID: 70644 RVA: 0x00095F31 File Offset: 0x00094131
			public unsafe IEnumerator<Vector3Int> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Vector3Int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059A4 RID: 22948
			// (get) Token: 0x060113F5 RID: 70645 RVA: 0x003F911C File Offset: 0x003F731C
			// (set) Token: 0x060113F6 RID: 70646 RVA: 0x00095F50 File Offset: 0x00094150
			public unsafe Vector3Int _gridPoint_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr__gridPoint_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._FollowPath_d__30.NativeFieldInfoPtr__gridPoint_5__3)) = value;
				}
			}

			// Token: 0x0400AE61 RID: 44641
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AE62 RID: 44642
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400AE63 RID: 44643
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AE64 RID: 44644
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x0400AE65 RID: 44645
			private static readonly IntPtr NativeFieldInfoPtr_extraOnArrivalOffset;

			// Token: 0x0400AE66 RID: 44646
			private static readonly IntPtr NativeFieldInfoPtr_rotationOnFinish;

			// Token: 0x0400AE67 RID: 44647
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400AE68 RID: 44648
			private static readonly IntPtr NativeFieldInfoPtr__gridPoint_5__3;

			// Token: 0x0400AE69 RID: 44649
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400AE6A RID: 44650
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE6B RID: 44651
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400AE6C RID: 44652
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400AE6D RID: 44653
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400AE6E RID: 44654
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE6F RID: 44655
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000F92 RID: 3986
		[ObfuscatedName("Common.CharacterUtility.AStarInputGeneratorComponent+<MoveToTargetPosition>d__31")]
		public sealed class _MoveToTargetPosition_d__31 : Il2CppSystem.Object
		{
			// Token: 0x060113F7 RID: 70647 RVA: 0x003F9144 File Offset: 0x003F7344
			// Note: this type is marked as 'beforefieldinit'.
			static _MoveToTargetPosition_d__31()
			{
				Il2CppClassPointerStore<AStarInputGeneratorComponent._MoveToTargetPosition_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AStarInputGeneratorComponent>.NativeClassPtr, "<MoveToTargetPosition>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AStarInputGeneratorComponent._MoveToTargetPosition_d__31>.NativeClassPtr);
				AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._MoveToTargetPosition_d__31>.NativeClassPtr, "<>1__state");
				AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._MoveToTargetPosition_d__31>.NativeClassPtr, "<>2__current");
				AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeFieldInfoPtr_targetWorldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._MoveToTargetPosition_d__31>.NativeClassPtr, "targetWorldPosition");
				AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AStarInputGeneratorComponent._MoveToTargetPosition_d__31>.NativeClassPtr, "<>4__this");
				AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._MoveToTargetPosition_d__31>.NativeClassPtr, 100687847);
				AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._MoveToTargetPosition_d__31>.NativeClassPtr, 100687848);
				AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._MoveToTargetPosition_d__31>.NativeClassPtr, 100687849);
				AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._MoveToTargetPosition_d__31>.NativeClassPtr, 100687850);
				AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._MoveToTargetPosition_d__31>.NativeClassPtr, 100687851);
				AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AStarInputGeneratorComponent._MoveToTargetPosition_d__31>.NativeClassPtr, 100687852);
			}

			// Token: 0x060113F8 RID: 70648 RVA: 0x003F9238 File Offset: 0x003F7438
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MoveToTargetPosition_d__31(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AStarInputGeneratorComponent._MoveToTargetPosition_d__31>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060113F9 RID: 70649 RVA: 0x003F9280 File Offset: 0x003F7480
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060113FA RID: 70650 RVA: 0x003F92B4 File Offset: 0x003F74B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294638, XrefRangeEnd = 294639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170059AB RID: 22955
			// (get) Token: 0x060113FB RID: 70651 RVA: 0x003F92F0 File Offset: 0x003F74F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060113FC RID: 70652 RVA: 0x003F9330 File Offset: 0x003F7530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294639, XrefRangeEnd = 294645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170059AC RID: 22956
			// (get) Token: 0x060113FD RID: 70653 RVA: 0x003F9364 File Offset: 0x003F7564
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060113FE RID: 70654 RVA: 0x00095F6B File Offset: 0x0009416B
			public _MoveToTargetPosition_d__31(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170059A7 RID: 22951
			// (get) Token: 0x060113FF RID: 70655 RVA: 0x003F93A4 File Offset: 0x003F75A4
			// (set) Token: 0x06011400 RID: 70656 RVA: 0x00095F74 File Offset: 0x00094174
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170059A8 RID: 22952
			// (get) Token: 0x06011401 RID: 70657 RVA: 0x003F93CC File Offset: 0x003F75CC
			// (set) Token: 0x06011402 RID: 70658 RVA: 0x00095F8F File Offset: 0x0009418F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059A9 RID: 22953
			// (get) Token: 0x06011403 RID: 70659 RVA: 0x003F93FC File Offset: 0x003F75FC
			// (set) Token: 0x06011404 RID: 70660 RVA: 0x00095FAE File Offset: 0x000941AE
			public unsafe Vector3 targetWorldPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeFieldInfoPtr_targetWorldPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeFieldInfoPtr_targetWorldPosition)) = value;
				}
			}

			// Token: 0x170059AA RID: 22954
			// (get) Token: 0x06011405 RID: 70661 RVA: 0x003F9424 File Offset: 0x003F7624
			// (set) Token: 0x06011406 RID: 70662 RVA: 0x00095FC9 File Offset: 0x000941C9
			public unsafe AStarInputGeneratorComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AStarInputGeneratorComponent._MoveToTargetPosition_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AE70 RID: 44656
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AE71 RID: 44657
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400AE72 RID: 44658
			private static readonly IntPtr NativeFieldInfoPtr_targetWorldPosition;

			// Token: 0x0400AE73 RID: 44659
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AE74 RID: 44660
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400AE75 RID: 44661
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE76 RID: 44662
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400AE77 RID: 44663
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400AE78 RID: 44664
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE79 RID: 44665
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
