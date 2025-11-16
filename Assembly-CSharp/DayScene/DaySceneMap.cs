using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.Interactables;
using DayScene.Interactables.Collections.ConditionComponents;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace DayScene
{
	// Token: 0x020000B2 RID: 178
	public class DaySceneMap : MonoBehaviour
	{
		// Token: 0x0600131F RID: 4895 RVA: 0x000DEC44 File Offset: 0x000DCE44
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneMap()
		{
			Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene", "DaySceneMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr);
			DaySceneMap.NativeFieldInfoPtr_allCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "allCharacters");
			DaySceneMap.NativeFieldInfoPtr_cameraDefaultPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "cameraDefaultPosition");
			DaySceneMap.NativeFieldInfoPtr_shouldCameraFollow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "shouldCameraFollow");
			DaySceneMap.NativeFieldInfoPtr_mapBGM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "mapBGM");
			DaySceneMap.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "height");
			DaySceneMap.NativeFieldInfoPtr_boundingShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "boundingShape");
			DaySceneMap.NativeFieldInfoPtr_spawnMarkerField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "spawnMarkerField");
			DaySceneMap.NativeFieldInfoPtr_collectableField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "collectableField");
			DaySceneMap.NativeFieldInfoPtr_doNotShowIconSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "doNotShowIconSprite");
			DaySceneMap.NativeFieldInfoPtr_hideClock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "hideClock");
			DaySceneMap.NativeFieldInfoPtr_allCollectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "allCollectables");
			DaySceneMap.NativeFieldInfoPtr_allSpawnMarkers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "allSpawnMarkers");
			DaySceneMap.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "initialized");
			DaySceneMap.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "mapLabel");
			DaySceneMap.NativeFieldInfoPtr__Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "_Handle");
			DaySceneMap.NativeFieldInfoPtr_OnEnterMapCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "OnEnterMapCallback");
			DaySceneMap.NativeMethodInfoPtr_get_AllSpawnMarkers_Private_get_Dictionary_2_String_SpawnMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666614);
			DaySceneMap.NativeMethodInfoPtr_set_AllSpawnMarkers_Private_set_Void_Dictionary_2_String_SpawnMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666615);
			DaySceneMap.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666616);
			DaySceneMap.NativeMethodInfoPtr_add_OnEnterMapCallback_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666617);
			DaySceneMap.NativeMethodInfoPtr_remove_OnEnterMapCallback_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666618);
			DaySceneMap.NativeMethodInfoPtr_TryGetCharacter_Public_Static_CharacterConditionComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666619);
			DaySceneMap.NativeMethodInfoPtr_GenerateSpawnMarkerData_Protected_Virtual_New_Dictionary_2_String_SpawnMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666620);
			DaySceneMap.NativeMethodInfoPtr_GetAllCollectableLabels_Public_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666621);
			DaySceneMap.NativeMethodInfoPtr_GetAllCollectables_Public_Il2CppReferenceArray_1_CollectableConditionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666622);
			DaySceneMap.NativeMethodInfoPtr_CheckIfContainsSpawnMarkers_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666623);
			DaySceneMap.NativeMethodInfoPtr_PreInitialize_Public_Void_String_IGameObjectAssetHandle_1_DaySceneMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666624);
			DaySceneMap.NativeMethodInfoPtr_RefreshNPCs_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666625);
			DaySceneMap.NativeMethodInfoPtr_SolveAndUpdateCharacterPosition_Public_Boolean_TrackedNPC_CharacterConditionComponent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666626);
			DaySceneMap.NativeMethodInfoPtr_SolveAndUpdateCharacterPositionInternal_Private_Void_Dictionary_2_String_TrackedNPC_TrackedNPC_CharacterConditionComponent_byref_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666627);
			DaySceneMap.NativeMethodInfoPtr_EnterSceneAsync_Public_UniTask_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666628);
			DaySceneMap.NativeMethodInfoPtr_OnPostEnterSceneAsync_Public_Virtual_New_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666629);
			DaySceneMap.NativeMethodInfoPtr_OnPostLeaveScene_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666630);
			DaySceneMap.NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666631);
			DaySceneMap.NativeMethodInfoPtr_GetSpawnMarker_Public_SpawnMarker_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666632);
			DaySceneMap.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666633);
			DaySceneMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, 100666634);
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x000DEF58 File Offset: 0x000DD158
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x000DEF98 File Offset: 0x000DD198
		public unsafe Dictionary<string, SpawnMarker> AllSpawnMarkers
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52943, XrefRangeEnd = 52944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_get_AllSpawnMarkers_Private_get_Dictionary_2_String_SpawnMarker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SpawnMarker>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52944, XrefRangeEnd = 52945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_set_AllSpawnMarkers_Private_set_Void_Dictionary_2_String_SpawnMarker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x000DEFDC File Offset: 0x000DD1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52945, XrefRangeEnd = 52948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x000DF010 File Offset: 0x000DD210
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 52961, RefRangeEnd = 52963, XrefRangeStart = 52948, XrefRangeEnd = 52961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnEnterMapCallback(Action<string> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_add_OnEnterMapCallback_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x000DF048 File Offset: 0x000DD248
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 52976, RefRangeEnd = 52979, XrefRangeStart = 52963, XrefRangeEnd = 52976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnEnterMapCallback(Action<string> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_remove_OnEnterMapCallback_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000DF080 File Offset: 0x000DD280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52986, RefRangeEnd = 52987, XrefRangeStart = 52979, XrefRangeEnd = 52986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CharacterConditionComponent TryGetCharacter(string characterId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_TryGetCharacter_Public_Static_CharacterConditionComponent_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterConditionComponent>(intPtr3) : null;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x000DF0C4 File Offset: 0x000DD2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52987, XrefRangeEnd = 53009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dictionary<string, SpawnMarker> GenerateSpawnMarkerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneMap.NativeMethodInfoPtr_GenerateSpawnMarkerData_Protected_Virtual_New_Dictionary_2_String_SpawnMarker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SpawnMarker>>(intPtr3) : null;
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x000DF110 File Offset: 0x000DD310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53009, XrefRangeEnd = 53029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<string> GetAllCollectableLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_GetAllCollectableLabels_Public_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x000DF150 File Offset: 0x000DD350
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 53038, RefRangeEnd = 53041, XrefRangeStart = 53029, XrefRangeEnd = 53038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<CollectableConditionComponent> GetAllCollectables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_GetAllCollectables_Public_Il2CppReferenceArray_1_CollectableConditionComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CollectableConditionComponent>>(intPtr3) : null;
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x000DF190 File Offset: 0x000DD390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53041, XrefRangeEnd = 53046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckIfContainsSpawnMarkers(string spawnMarker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(spawnMarker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_CheckIfContainsSpawnMarkers_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x000DF1E0 File Offset: 0x000DD3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53046, XrefRangeEnd = 53053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreInitialize(string mapLabel, IGameObjectAssetHandle<DaySceneMap> gameObjectAssetHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObjectAssetHandle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_PreInitialize_Public_Void_String_IGameObjectAssetHandle_1_DaySceneMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x000DF234 File Offset: 0x000DD434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53115, RefRangeEnd = 53116, XrefRangeStart = 53053, XrefRangeEnd = 53115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNPCs(bool rotateCharacter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotateCharacter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_RefreshNPCs_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x000DF274 File Offset: 0x000DD474
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 53121, RefRangeEnd = 53124, XrefRangeStart = 53116, XrefRangeEnd = 53121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SolveAndUpdateCharacterPosition(TrackedNPC npc, CharacterConditionComponent character, bool rotateCharacter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(character);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotateCharacter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_SolveAndUpdateCharacterPosition_Public_Boolean_TrackedNPC_CharacterConditionComponent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x000DF2E4 File Offset: 0x000DD4E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53189, RefRangeEnd = 53191, XrefRangeStart = 53124, XrefRangeEnd = 53189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SolveAndUpdateCharacterPositionInternal(Dictionary<string, TrackedNPC> npcs, TrackedNPC npc, CharacterConditionComponent character, out bool isNPCOnMap, bool changeRotation = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcs);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(character);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isNPCOnMap;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_SolveAndUpdateCharacterPositionInternal_Private_Void_Dictionary_2_String_TrackedNPC_TrackedNPC_CharacterConditionComponent_byref_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x000DF368 File Offset: 0x000DD568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53191, XrefRangeEnd = 53198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask EnterSceneAsync(string mapLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_EnterSceneAsync_Public_UniTask_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x000DF3B0 File Offset: 0x000DD5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53198, XrefRangeEnd = 53202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual UniTask OnPostEnterSceneAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneMap.NativeMethodInfoPtr_OnPostEnterSceneAsync_Public_Virtual_New_UniTask_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x000DF3F4 File Offset: 0x000DD5F4
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPostLeaveScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneMap.NativeMethodInfoPtr_OnPostLeaveScene_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x000DF430 File Offset: 0x000DD630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53210, RefRangeEnd = 53211, XrefRangeStart = 53202, XrefRangeEnd = 53210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_Dispose_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x000DF458 File Offset: 0x000DD658
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53216, RefRangeEnd = 53218, XrefRangeStart = 53211, XrefRangeEnd = 53216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpawnMarker GetSpawnMarker(string markerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(markerName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr_GetSpawnMarker_Public_SpawnMarker_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpawnMarker>(intPtr3) : null;
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x000DF4A8 File Offset: 0x000DD6A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53228, RefRangeEnd = 53230, XrefRangeStart = 53218, XrefRangeEnd = 53228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneMap.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x000DF4E4 File Offset: 0x000DD6E4
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneMap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0000C180 File Offset: 0x0000A380
		public DaySceneMap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x000DF520 File Offset: 0x000DD720
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x0000C189 File Offset: 0x0000A389
		public unsafe static Dictionary<string, CharacterConditionComponent> allCharacters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DaySceneMap.NativeFieldInfoPtr_allCharacters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, CharacterConditionComponent>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneMap.NativeFieldInfoPtr_allCharacters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x000DF548 File Offset: 0x000DD748
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x0000C19B File Offset: 0x0000A39B
		public unsafe Vector3 cameraDefaultPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_cameraDefaultPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_cameraDefaultPosition)) = value;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x000DF570 File Offset: 0x000DD770
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x0000C1B6 File Offset: 0x0000A3B6
		public unsafe bool shouldCameraFollow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_shouldCameraFollow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_shouldCameraFollow)) = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x000DF598 File Offset: 0x000DD798
		// (set) Token: 0x0600133D RID: 4925 RVA: 0x0000C1D1 File Offset: 0x0000A3D1
		public unsafe LoopedBGMPackage mapBGM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_mapBGM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_mapBGM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x000DF5C8 File Offset: 0x000DD7C8
		// (set) Token: 0x0600133F RID: 4927 RVA: 0x0000C1F0 File Offset: 0x0000A3F0
		public unsafe Tilemap height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_height);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_height), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x000DF5F8 File Offset: 0x000DD7F8
		// (set) Token: 0x06001341 RID: 4929 RVA: 0x0000C20F File Offset: 0x0000A40F
		public unsafe Collider2D boundingShape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_boundingShape);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_boundingShape), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x000DF628 File Offset: 0x000DD828
		// (set) Token: 0x06001343 RID: 4931 RVA: 0x0000C22E File Offset: 0x0000A42E
		public unsafe Transform spawnMarkerField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_spawnMarkerField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_spawnMarkerField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x000DF658 File Offset: 0x000DD858
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x0000C24D File Offset: 0x0000A44D
		public unsafe Transform collectableField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_collectableField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_collectableField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x000DF688 File Offset: 0x000DD888
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x0000C26C File Offset: 0x0000A46C
		public unsafe bool doNotShowIconSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_doNotShowIconSprite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_doNotShowIconSprite)) = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x000DF6B0 File Offset: 0x000DD8B0
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x0000C287 File Offset: 0x0000A487
		public unsafe bool hideClock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_hideClock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_hideClock)) = value;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x000DF6D8 File Offset: 0x000DD8D8
		// (set) Token: 0x0600134B RID: 4939 RVA: 0x0000C2A2 File Offset: 0x0000A4A2
		public unsafe Il2CppReferenceArray<CollectableConditionComponent> allCollectables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_allCollectables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CollectableConditionComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_allCollectables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x000DF708 File Offset: 0x000DD908
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x0000C2C1 File Offset: 0x0000A4C1
		public unsafe Dictionary<string, SpawnMarker> allSpawnMarkers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_allSpawnMarkers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SpawnMarker>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_allSpawnMarkers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x000DF738 File Offset: 0x000DD938
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x0000C2E0 File Offset: 0x0000A4E0
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x000DF760 File Offset: 0x000DD960
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x0000C2FB File Offset: 0x0000A4FB
		public unsafe string mapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_mapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x000DF788 File Offset: 0x000DD988
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x0000C31A File Offset: 0x0000A51A
		public unsafe IGameObjectAssetHandle<DaySceneMap> _Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr__Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<DaySceneMap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap.NativeFieldInfoPtr__Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x000DF7B8 File Offset: 0x000DD9B8
		// (set) Token: 0x06001355 RID: 4949 RVA: 0x0000C339 File Offset: 0x0000A539
		public unsafe static Action<string> OnEnterMapCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DaySceneMap.NativeFieldInfoPtr_OnEnterMapCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DaySceneMap.NativeFieldInfoPtr_OnEnterMapCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeFieldInfoPtr_allCharacters;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeFieldInfoPtr_cameraDefaultPosition;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeFieldInfoPtr_shouldCameraFollow;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeFieldInfoPtr_mapBGM;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeFieldInfoPtr_boundingShape;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeFieldInfoPtr_spawnMarkerField;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeFieldInfoPtr_collectableField;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeFieldInfoPtr_doNotShowIconSprite;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeFieldInfoPtr_hideClock;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeFieldInfoPtr_allCollectables;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeFieldInfoPtr_allSpawnMarkers;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeFieldInfoPtr__Handle;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeFieldInfoPtr_OnEnterMapCallback;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_get_AllSpawnMarkers_Private_get_Dictionary_2_String_SpawnMarker_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_set_AllSpawnMarkers_Private_set_Void_Dictionary_2_String_SpawnMarker_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_add_OnEnterMapCallback_Public_Static_add_Void_Action_1_String_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnEnterMapCallback_Public_Static_rem_Void_Action_1_String_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCharacter_Public_Static_CharacterConditionComponent_String_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSpawnMarkerData_Protected_Virtual_New_Dictionary_2_String_SpawnMarker_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCollectableLabels_Public_IEnumerable_1_String_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCollectables_Public_Il2CppReferenceArray_1_CollectableConditionComponent_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_CheckIfContainsSpawnMarkers_Public_Boolean_String_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_PreInitialize_Public_Void_String_IGameObjectAssetHandle_1_DaySceneMap_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNPCs_Public_Void_Boolean_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_SolveAndUpdateCharacterPosition_Public_Boolean_TrackedNPC_CharacterConditionComponent_Boolean_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_SolveAndUpdateCharacterPositionInternal_Private_Void_Dictionary_2_String_TrackedNPC_TrackedNPC_CharacterConditionComponent_byref_Boolean_Boolean_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr_EnterSceneAsync_Public_UniTask_String_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_OnPostEnterSceneAsync_Public_Virtual_New_UniTask_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_OnPostLeaveScene_Public_Virtual_New_Void_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_GetSpawnMarker_Public_SpawnMarker_String_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005CB RID: 1483
		[ObfuscatedName("DayScene.DaySceneMap+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008D1D RID: 36125 RVA: 0x0026B52C File Offset: 0x0026972C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneMap.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneMap.__c>.NativeClassPtr);
				DaySceneMap.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap.__c>.NativeClassPtr, "<>9");
				DaySceneMap.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap.__c>.NativeClassPtr, "<>9__23_0");
				DaySceneMap.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap.__c>.NativeClassPtr, "<>9__24_0");
				DaySceneMap.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap.__c>.NativeClassPtr, "<>9__30_0");
				DaySceneMap.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap.__c>.NativeClassPtr, 100666637);
				DaySceneMap.__c.NativeMethodInfoPtr__GenerateSpawnMarkerData_b__23_0_Internal_String_SpawnMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap.__c>.NativeClassPtr, 100666638);
				DaySceneMap.__c.NativeMethodInfoPtr__GetAllCollectableLabels_b__24_0_Internal_String_CollectableConditionComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap.__c>.NativeClassPtr, 100666639);
				DaySceneMap.__c.NativeMethodInfoPtr__SolveAndUpdateCharacterPositionInternal_b__30_0_Internal_String_KeyValuePair_2_String_TrackedNPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap.__c>.NativeClassPtr, 100666640);
			}

			// Token: 0x06008D1E RID: 36126 RVA: 0x0026B5F8 File Offset: 0x002697F8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneMap.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D1F RID: 36127 RVA: 0x0026B634 File Offset: 0x00269834
			[CallerCount(0)]
			public unsafe string _GenerateSpawnMarkerData_b__23_0(SpawnMarker x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.__c.NativeMethodInfoPtr__GenerateSpawnMarkerData_b__23_0_Internal_String_SpawnMarker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008D20 RID: 36128 RVA: 0x0026B67C File Offset: 0x0026987C
			[CallerCount(0)]
			public unsafe string _GetAllCollectableLabels_b__24_0(CollectableConditionComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.__c.NativeMethodInfoPtr__GetAllCollectableLabels_b__24_0_Internal_String_CollectableConditionComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008D21 RID: 36129 RVA: 0x0026B6C4 File Offset: 0x002698C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52924, XrefRangeEnd = 52932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _SolveAndUpdateCharacterPositionInternal_b__30_0(KeyValuePair<string, TrackedNPC> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap.__c.NativeMethodInfoPtr__SolveAndUpdateCharacterPositionInternal_b__30_0_Internal_String_KeyValuePair_2_String_TrackedNPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008D22 RID: 36130 RVA: 0x0004BDF6 File Offset: 0x00049FF6
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F2F RID: 12079
			// (get) Token: 0x06008D23 RID: 36131 RVA: 0x0026B714 File Offset: 0x00269914
			// (set) Token: 0x06008D24 RID: 36132 RVA: 0x0004BDFF File Offset: 0x00049FFF
			public unsafe static DaySceneMap.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneMap.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneMap.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneMap.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F30 RID: 12080
			// (get) Token: 0x06008D25 RID: 36133 RVA: 0x0026B73C File Offset: 0x0026993C
			// (set) Token: 0x06008D26 RID: 36134 RVA: 0x0004BE11 File Offset: 0x0004A011
			public unsafe static Func<SpawnMarker, string> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneMap.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpawnMarker, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneMap.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F31 RID: 12081
			// (get) Token: 0x06008D27 RID: 36135 RVA: 0x0026B764 File Offset: 0x00269964
			// (set) Token: 0x06008D28 RID: 36136 RVA: 0x0004BE23 File Offset: 0x0004A023
			public unsafe static Func<CollectableConditionComponent, string> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneMap.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CollectableConditionComponent, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneMap.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F32 RID: 12082
			// (get) Token: 0x06008D29 RID: 36137 RVA: 0x0026B78C File Offset: 0x0026998C
			// (set) Token: 0x06008D2A RID: 36138 RVA: 0x0004BE35 File Offset: 0x0004A035
			public unsafe static Func<KeyValuePair<string, TrackedNPC>, string> __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneMap.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, TrackedNPC>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneMap.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C40 RID: 23616
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005C41 RID: 23617
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04005C42 RID: 23618
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04005C43 RID: 23619
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x04005C44 RID: 23620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C45 RID: 23621
			private static readonly IntPtr NativeMethodInfoPtr__GenerateSpawnMarkerData_b__23_0_Internal_String_SpawnMarker_0;

			// Token: 0x04005C46 RID: 23622
			private static readonly IntPtr NativeMethodInfoPtr__GetAllCollectableLabels_b__24_0_Internal_String_CollectableConditionComponent_0;

			// Token: 0x04005C47 RID: 23623
			private static readonly IntPtr NativeMethodInfoPtr__SolveAndUpdateCharacterPositionInternal_b__30_0_Internal_String_KeyValuePair_2_String_TrackedNPC_0;
		}

		// Token: 0x020005CC RID: 1484
		[ObfuscatedName("DayScene.DaySceneMap+<EnterSceneAsync>d__31")]
		public sealed class _EnterSceneAsync_d__31 : ValueType
		{
			// Token: 0x06008D2B RID: 36139 RVA: 0x0026B7B4 File Offset: 0x002699B4
			// Note: this type is marked as 'beforefieldinit'.
			static _EnterSceneAsync_d__31()
			{
				Il2CppClassPointerStore<DaySceneMap._EnterSceneAsync_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneMap>.NativeClassPtr, "<EnterSceneAsync>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneMap._EnterSceneAsync_d__31>.NativeClassPtr);
				DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap._EnterSceneAsync_d__31>.NativeClassPtr, "<>1__state");
				DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap._EnterSceneAsync_d__31>.NativeClassPtr, "<>t__builder");
				DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap._EnterSceneAsync_d__31>.NativeClassPtr, "<>4__this");
				DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap._EnterSceneAsync_d__31>.NativeClassPtr, "mapLabel");
				DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMap._EnterSceneAsync_d__31>.NativeClassPtr, "<>u__1");
				DaySceneMap._EnterSceneAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap._EnterSceneAsync_d__31>.NativeClassPtr, 100666641);
				DaySceneMap._EnterSceneAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMap._EnterSceneAsync_d__31>.NativeClassPtr, 100666642);
			}

			// Token: 0x06008D2C RID: 36140 RVA: 0x0026B86C File Offset: 0x00269A6C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 52939, RefRangeEnd = 52943, XrefRangeStart = 52932, XrefRangeEnd = 52939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap._EnterSceneAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D2D RID: 36141 RVA: 0x0026B8A4 File Offset: 0x00269AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMap._EnterSceneAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D2E RID: 36142 RVA: 0x0004BE47 File Offset: 0x0004A047
			public _EnterSceneAsync_d__31(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008D2F RID: 36143 RVA: 0x0004BE50 File Offset: 0x0004A050
			public _EnterSceneAsync_d__31() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneMap._EnterSceneAsync_d__31>.NativeClassPtr))
			{
			}

			// Token: 0x17002F33 RID: 12083
			// (get) Token: 0x06008D30 RID: 36144 RVA: 0x0026B8EC File Offset: 0x00269AEC
			// (set) Token: 0x06008D31 RID: 36145 RVA: 0x0004BE62 File Offset: 0x0004A062
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002F34 RID: 12084
			// (get) Token: 0x06008D32 RID: 36146 RVA: 0x0026B914 File Offset: 0x00269B14
			// (set) Token: 0x06008D33 RID: 36147 RVA: 0x0004BE7D File Offset: 0x0004A07D
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F35 RID: 12085
			// (get) Token: 0x06008D34 RID: 36148 RVA: 0x0026B944 File Offset: 0x00269B44
			// (set) Token: 0x06008D35 RID: 36149 RVA: 0x0004BEAB File Offset: 0x0004A0AB
			public unsafe DaySceneMap __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F36 RID: 12086
			// (get) Token: 0x06008D36 RID: 36150 RVA: 0x0026B974 File Offset: 0x00269B74
			// (set) Token: 0x06008D37 RID: 36151 RVA: 0x0004BECA File Offset: 0x0004A0CA
			public unsafe string mapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr_mapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002F37 RID: 12087
			// (get) Token: 0x06008D38 RID: 36152 RVA: 0x0026B99C File Offset: 0x00269B9C
			// (set) Token: 0x06008D39 RID: 36153 RVA: 0x0004BEE9 File Offset: 0x0004A0E9
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMap._EnterSceneAsync_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005C48 RID: 23624
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005C49 RID: 23625
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005C4A RID: 23626
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005C4B RID: 23627
			private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

			// Token: 0x04005C4C RID: 23628
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005C4D RID: 23629
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005C4E RID: 23630
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
