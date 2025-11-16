using System;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DayScene;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

// Token: 0x02000009 RID: 9
public class FlandreHomeMap : DaySceneMap
{
	// Token: 0x06000055 RID: 85 RVA: 0x0009FDB4 File Offset: 0x0009DFB4
	// Note: this type is marked as 'beforefieldinit'.
	static FlandreHomeMap()
	{
		Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlandreHomeMap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr);
		FlandreHomeMap.NativeFieldInfoPtr_FIRST_GOTO_SDM_BASEMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, "FIRST_GOTO_SDM_BASEMENT");
		FlandreHomeMap.NativeFieldInfoPtr_tilemap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, "tilemap");
		FlandreHomeMap.NativeFieldInfoPtr_furnitureTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, "furnitureTransform");
		FlandreHomeMap.NativeFieldInfoPtr_availableArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, "availableArea");
		FlandreHomeMap.NativeFieldInfoPtr_forbiddenArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, "forbiddenArea");
		FlandreHomeMap.NativeFieldInfoPtr_placedArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, "placedArea");
		FlandreHomeMap.NativeFieldInfoPtr_currentArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, "currentArea");
		FlandreHomeMap.NativeFieldInfoPtr_allSpawnedFurnitureObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, "allSpawnedFurnitureObjects");
		FlandreHomeMap.NativeFieldInfoPtr_availableGridPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, "availableGridPosition");
		FlandreHomeMap.NativeFieldInfoPtr_occupiedGridPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, "occupiedGridPosition");
		FlandreHomeMap.NativeFieldInfoPtr_allGridPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, "allGridPosition");
		FlandreHomeMap.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663332);
		FlandreHomeMap.NativeMethodInfoPtr_OnPostEnterSceneAsync_Public_Virtual_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663333);
		FlandreHomeMap.NativeMethodInfoPtr_RefreshStateArea_Public_Void_IEnumerable_1_Vector2Int_Int32_Placement_Il2CppStructArray_1_Vector2Int_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663334);
		FlandreHomeMap.NativeMethodInfoPtr_PrintColliderTiles_Private_Void_byref_FlandreHomeFurniture_Il2CppStructArray_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663335);
		FlandreHomeMap.NativeMethodInfoPtr_PrintColliderTiles_Public_Void_byref_FlandreHomeFurniture_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663336);
		FlandreHomeMap.NativeMethodInfoPtr_ClearTilemap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663337);
		FlandreHomeMap.NativeMethodInfoPtr_GetAllTargetPlacementGrids_Public_HashSet_1_Vector2Int_Placement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663338);
		FlandreHomeMap.NativeMethodInfoPtr_CheckFurnitureCanSetHere_Public_Boolean_FlandreHomeFurniture_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663339);
		FlandreHomeMap.NativeMethodInfoPtr_FindPositionToSet_Public_Boolean_byref_FlandreHomeFurniture_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663340);
		FlandreHomeMap.NativeMethodInfoPtr_InstantiateFurniture_Public_FlandreFurnitureComponent_byref_FlandreHomeFurniture_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663341);
		FlandreHomeMap.NativeMethodInfoPtr_GetTargetPositionObject_Public_Boolean_Placement_Vector2Int_byref_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663342);
		FlandreHomeMap.NativeMethodInfoPtr_GetAllSpawnedFurnitureInstance_Public_List_1_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663343);
		FlandreHomeMap.NativeMethodInfoPtr_DeleteFurniture_Public_Void_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663344);
		FlandreHomeMap.NativeMethodInfoPtr_SetOccupiedPosition_Public_Boolean_byref_FlandreHomeFurniture_Vector2Int_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663345);
		FlandreHomeMap.NativeMethodInfoPtr_RemoveOccupiedPosition_Public_Void_byref_FlandreHomeFurniture_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663346);
		FlandreHomeMap.NativeMethodInfoPtr_SetFurnitureData_Public_Void_EditorMode_byref_FlandreHomeFurniture_Nullable_1_Vector2Int_Nullable_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663347);
		FlandreHomeMap.NativeMethodInfoPtr_SetFurnitureData_Public_Void_EditorMode_Int32_Nullable_1_Vector2Int_Nullable_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663348);
		FlandreHomeMap.NativeMethodInfoPtr_GetFurnitureWorldPosition_Public_Il2CppStructArray_1_Vector2Int_FlandreHomeFurniture_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663349);
		FlandreHomeMap.NativeMethodInfoPtr_GetFurnitureWorldPositionNonAlloc_Public_Void_FlandreHomeFurniture_Vector2Int_Il2CppStructArray_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663350);
		FlandreHomeMap.NativeMethodInfoPtr_GetTargetPlacementAvailableGrids_Private_Il2CppStructArray_1_Vector2Int_Placement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663351);
		FlandreHomeMap.NativeMethodInfoPtr_LoadSavedFurnitures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663352);
		FlandreHomeMap.NativeMethodInfoPtr_InitGridPosition_Private_Void_Tilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663353);
		FlandreHomeMap.NativeMethodInfoPtr_SetPosition_Private_Void_Transform_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663354);
		FlandreHomeMap.NativeMethodInfoPtr_TrySpawnDefaultFurniture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663355);
		FlandreHomeMap.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663356);
		FlandreHomeMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, 100663357);
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000A00C8 File Offset: 0x0009E2C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2806, XrefRangeEnd = 2807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000057 RID: 87 RVA: 0x000A00FC File Offset: 0x0009E2FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2807, XrefRangeEnd = 2813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override UniTask OnPostEnterSceneAsync()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr;
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlandreHomeMap.NativeMethodInfoPtr_OnPostEnterSceneAsync_Public_Virtual_UniTask_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new UniTask(pointer);
	}

	// Token: 0x06000058 RID: 88 RVA: 0x000A0140 File Offset: 0x0009E340
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2865, RefRangeEnd = 2867, XrefRangeStart = 2813, XrefRangeEnd = 2865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshStateArea(IEnumerable<Vector2Int> pointsNeedToRefresh, int count, FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement furnitureType, Il2CppStructArray<Vector2Int> currentPositionBuffer, bool canPutDown = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointsNeedToRefresh);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref furnitureType;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentPositionBuffer);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canPutDown;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_RefreshStateArea_Public_Void_IEnumerable_1_Vector2Int_Int32_Placement_Il2CppStructArray_1_Vector2Int_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000A01C0 File Offset: 0x0009E3C0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2886, RefRangeEnd = 2887, XrefRangeStart = 2867, XrefRangeEnd = 2886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrintColliderTiles([In] ref FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Il2CppStructArray<Vector2Int> currentPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentPosition);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_PrintColliderTiles_Private_Void_byref_FlandreHomeFurniture_Il2CppStructArray_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000A0218 File Offset: 0x0009E418
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2887, XrefRangeEnd = 2889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrintColliderTiles([In] ref FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int currentPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentPosition;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_PrintColliderTiles_Public_Void_byref_FlandreHomeFurniture_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600005B RID: 91 RVA: 0x000A026C File Offset: 0x0009E46C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2891, RefRangeEnd = 2892, XrefRangeStart = 2889, XrefRangeEnd = 2891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearTilemap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_ClearTilemap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x000A02A0 File Offset: 0x0009E4A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2896, RefRangeEnd = 2897, XrefRangeStart = 2892, XrefRangeEnd = 2896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<Vector2Int> GetAllTargetPlacementGrids(FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref placement;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_GetAllTargetPlacementGrids_Public_HashSet_1_Vector2Int_Placement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<Vector2Int>>(intPtr3) : null;
	}

	// Token: 0x0600005D RID: 93 RVA: 0x000A02EC File Offset: 0x0009E4EC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2905, RefRangeEnd = 2907, XrefRangeStart = 2897, XrefRangeEnd = 2905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckFurnitureCanSetHere(FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture));
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_CheckFurnitureCanSetHere_Public_Boolean_FlandreHomeFurniture_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600005E RID: 94 RVA: 0x000A034C File Offset: 0x0009E54C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2966, RefRangeEnd = 2968, XrefRangeStart = 2907, XrefRangeEnd = 2966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FindPositionToSet([In] ref FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, out Vector2Int finalPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &finalPosition;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_FindPositionToSet_Public_Boolean_byref_FlandreHomeFurniture_byref_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600005F RID: 95 RVA: 0x000A03A8 File Offset: 0x0009E5A8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2979, RefRangeEnd = 2980, XrefRangeStart = 2968, XrefRangeEnd = 2979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FlandreFurnitureComponent InstantiateFurniture([In] ref FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_InstantiateFurniture_Public_FlandreFurnitureComponent_byref_FlandreHomeFurniture_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<FlandreFurnitureComponent>(intPtr3) : null;
	}

	// Token: 0x06000060 RID: 96 RVA: 0x000A0408 File Offset: 0x0009E608
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2985, RefRangeEnd = 2986, XrefRangeStart = 2980, XrefRangeEnd = 2985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetTargetPositionObject(FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placementType, Vector2Int position, out FlandreFurnitureComponent furnitureObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref placementType;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_GetTargetPositionObject_Public_Boolean_Placement_Vector2Int_byref_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		furnitureObject = ((intPtr4 == 0) ? null : new FlandreFurnitureComponent(intPtr4));
		return *IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	// Token: 0x06000061 RID: 97 RVA: 0x000A0484 File Offset: 0x0009E684
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3011, RefRangeEnd = 3012, XrefRangeStart = 2986, XrefRangeEnd = 3011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<FlandreFurnitureComponent> GetAllSpawnedFurnitureInstance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_GetAllSpawnedFurnitureInstance_Public_List_1_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FlandreFurnitureComponent>>(intPtr3) : null;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000A04C4 File Offset: 0x0009E6C4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3056, RefRangeEnd = 3059, XrefRangeStart = 3012, XrefRangeEnd = 3056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteFurniture(FlandreFurnitureComponent furnitureObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(furnitureObject);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_DeleteFurniture_Public_Void_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000063 RID: 99 RVA: 0x000A0508 File Offset: 0x0009E708
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3087, RefRangeEnd = 3090, XrefRangeStart = 3059, XrefRangeEnd = 3087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetOccupiedPosition([In] ref FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int position, FlandreFurnitureComponent furnitureObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(furnitureObject);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_SetOccupiedPosition_Public_Boolean_byref_FlandreHomeFurniture_Vector2Int_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000064 RID: 100 RVA: 0x000A0578 File Offset: 0x0009E778
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3114, RefRangeEnd = 3115, XrefRangeStart = 3090, XrefRangeEnd = 3114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOccupiedPosition([In] ref FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_RemoveOccupiedPosition_Public_Void_byref_FlandreHomeFurniture_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000065 RID: 101 RVA: 0x000A05CC File Offset: 0x0009E7CC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3119, RefRangeEnd = 3120, XrefRangeStart = 3115, XrefRangeEnd = 3119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFurnitureData(FlandreHomeMap.EditorMode editorMode, [In] ref FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Nullable<Vector2Int> oldPosition, Nullable<Vector2Int> newPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref editorMode;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(oldPosition));
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newPosition));
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_SetFurnitureData_Public_Void_EditorMode_byref_FlandreHomeFurniture_Nullable_1_Vector2Int_Nullable_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000066 RID: 102 RVA: 0x000A064C File Offset: 0x0009E84C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3124, RefRangeEnd = 3125, XrefRangeStart = 3120, XrefRangeEnd = 3124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFurnitureData(FlandreHomeMap.EditorMode editorMode, int furnitureId, Nullable<Vector2Int> oldPosition, Nullable<Vector2Int> newPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref editorMode;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref furnitureId;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(oldPosition));
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newPosition));
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_SetFurnitureData_Public_Void_EditorMode_Int32_Nullable_1_Vector2Int_Nullable_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000067 RID: 103 RVA: 0x000A06C8 File Offset: 0x0009E8C8
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 3129, RefRangeEnd = 3136, XrefRangeStart = 3125, XrefRangeEnd = 3129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Vector2Int> GetFurnitureWorldPosition(FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture));
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_GetFurnitureWorldPosition_Public_Il2CppStructArray_1_Vector2Int_FlandreHomeFurniture_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr3) : null;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x000A072C File Offset: 0x0009E92C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3137, RefRangeEnd = 3138, XrefRangeStart = 3136, XrefRangeEnd = 3137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetFurnitureWorldPositionNonAlloc(FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int position, Il2CppStructArray<Vector2Int> buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(furniture));
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_GetFurnitureWorldPositionNonAlloc_Public_Void_FlandreHomeFurniture_Vector2Int_Il2CppStructArray_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000069 RID: 105 RVA: 0x000A0794 File Offset: 0x0009E994
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3151, RefRangeEnd = 3153, XrefRangeStart = 3138, XrefRangeEnd = 3151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Vector2Int> GetTargetPlacementAvailableGrids(FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref placement;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_GetTargetPlacementAvailableGrids_Private_Il2CppStructArray_1_Vector2Int_Placement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr3) : null;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x000A07E0 File Offset: 0x0009E9E0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3199, RefRangeEnd = 3200, XrefRangeStart = 3153, XrefRangeEnd = 3199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadSavedFurnitures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_LoadSavedFurnitures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600006B RID: 107 RVA: 0x000A0814 File Offset: 0x0009EA14
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3358, RefRangeEnd = 3359, XrefRangeStart = 3200, XrefRangeEnd = 3358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitGridPosition(Tilemap tilemap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_InitGridPosition_Private_Void_Tilemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600006C RID: 108 RVA: 0x000A0858 File Offset: 0x0009EA58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3359, XrefRangeEnd = 3360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPosition(Transform transform, Vector2Int position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_SetPosition_Private_Void_Transform_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600006D RID: 109 RVA: 0x000A08A8 File Offset: 0x0009EAA8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3390, RefRangeEnd = 3391, XrefRangeStart = 3360, XrefRangeEnd = 3390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TrySpawnDefaultFurniture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr_TrySpawnDefaultFurniture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600006E RID: 110 RVA: 0x000A08DC File Offset: 0x0009EADC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3391, XrefRangeEnd = 3407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup_Generated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlandreHomeMap.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x000A0918 File Offset: 0x0009EB18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3407, XrefRangeEnd = 3431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FlandreHomeMap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002205 File Offset: 0x00000405
	public FlandreHomeMap(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000071 RID: 113 RVA: 0x000A0954 File Offset: 0x0009EB54
	// (set) Token: 0x06000072 RID: 114 RVA: 0x0000220E File Offset: 0x0000040E
	public unsafe static string FIRST_GOTO_SDM_BASEMENT
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FlandreHomeMap.NativeFieldInfoPtr_FIRST_GOTO_SDM_BASEMENT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FlandreHomeMap.NativeFieldInfoPtr_FIRST_GOTO_SDM_BASEMENT, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000073 RID: 115 RVA: 0x000A0974 File Offset: 0x0009EB74
	// (set) Token: 0x06000074 RID: 116 RVA: 0x00002220 File Offset: 0x00000420
	public unsafe Tilemap tilemap
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_tilemap);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_tilemap), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000075 RID: 117 RVA: 0x000A09A4 File Offset: 0x0009EBA4
	// (set) Token: 0x06000076 RID: 118 RVA: 0x0000223F File Offset: 0x0000043F
	public unsafe Transform furnitureTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_furnitureTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_furnitureTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000077 RID: 119 RVA: 0x000A09D4 File Offset: 0x0009EBD4
	// (set) Token: 0x06000078 RID: 120 RVA: 0x0000225E File Offset: 0x0000045E
	public unsafe Tile availableArea
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_availableArea);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_availableArea), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000079 RID: 121 RVA: 0x000A0A04 File Offset: 0x0009EC04
	// (set) Token: 0x0600007A RID: 122 RVA: 0x0000227D File Offset: 0x0000047D
	public unsafe Tile forbiddenArea
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_forbiddenArea);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_forbiddenArea), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600007B RID: 123 RVA: 0x000A0A34 File Offset: 0x0009EC34
	// (set) Token: 0x0600007C RID: 124 RVA: 0x0000229C File Offset: 0x0000049C
	public unsafe Tile placedArea
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_placedArea);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_placedArea), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x0600007D RID: 125 RVA: 0x000A0A64 File Offset: 0x0009EC64
	// (set) Token: 0x0600007E RID: 126 RVA: 0x000022BB File Offset: 0x000004BB
	public unsafe Tile currentArea
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_currentArea);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_currentArea), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x0600007F RID: 127 RVA: 0x000A0A94 File Offset: 0x0009EC94
	// (set) Token: 0x06000080 RID: 128 RVA: 0x000022DA File Offset: 0x000004DA
	public unsafe Dictionary<Vector2Int, Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, FlandreFurnitureComponent>> allSpawnedFurnitureObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_allSpawnedFurnitureObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector2Int, Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, FlandreFurnitureComponent>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_allSpawnedFurnitureObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000081 RID: 129 RVA: 0x000A0AC4 File Offset: 0x0009ECC4
	// (set) Token: 0x06000082 RID: 130 RVA: 0x000022F9 File Offset: 0x000004F9
	public unsafe Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, HashSet<Vector2Int>> availableGridPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_availableGridPosition);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, HashSet<Vector2Int>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_availableGridPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000083 RID: 131 RVA: 0x000A0AF4 File Offset: 0x0009ECF4
	// (set) Token: 0x06000084 RID: 132 RVA: 0x00002318 File Offset: 0x00000518
	public unsafe Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, HashSet<Vector2Int>> occupiedGridPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_occupiedGridPosition);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, HashSet<Vector2Int>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_occupiedGridPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000085 RID: 133 RVA: 0x000A0B24 File Offset: 0x0009ED24
	// (set) Token: 0x06000086 RID: 134 RVA: 0x00002337 File Offset: 0x00000537
	public unsafe Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, HashSet<Vector2Int>> allGridPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_allGridPosition);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, HashSet<Vector2Int>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.NativeFieldInfoPtr_allGridPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000033 RID: 51
	private static readonly IntPtr NativeFieldInfoPtr_FIRST_GOTO_SDM_BASEMENT;

	// Token: 0x04000034 RID: 52
	private static readonly IntPtr NativeFieldInfoPtr_tilemap;

	// Token: 0x04000035 RID: 53
	private static readonly IntPtr NativeFieldInfoPtr_furnitureTransform;

	// Token: 0x04000036 RID: 54
	private static readonly IntPtr NativeFieldInfoPtr_availableArea;

	// Token: 0x04000037 RID: 55
	private static readonly IntPtr NativeFieldInfoPtr_forbiddenArea;

	// Token: 0x04000038 RID: 56
	private static readonly IntPtr NativeFieldInfoPtr_placedArea;

	// Token: 0x04000039 RID: 57
	private static readonly IntPtr NativeFieldInfoPtr_currentArea;

	// Token: 0x0400003A RID: 58
	private static readonly IntPtr NativeFieldInfoPtr_allSpawnedFurnitureObjects;

	// Token: 0x0400003B RID: 59
	private static readonly IntPtr NativeFieldInfoPtr_availableGridPosition;

	// Token: 0x0400003C RID: 60
	private static readonly IntPtr NativeFieldInfoPtr_occupiedGridPosition;

	// Token: 0x0400003D RID: 61
	private static readonly IntPtr NativeFieldInfoPtr_allGridPosition;

	// Token: 0x0400003E RID: 62
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

	// Token: 0x0400003F RID: 63
	private static readonly IntPtr NativeMethodInfoPtr_OnPostEnterSceneAsync_Public_Virtual_UniTask_0;

	// Token: 0x04000040 RID: 64
	private static readonly IntPtr NativeMethodInfoPtr_RefreshStateArea_Public_Void_IEnumerable_1_Vector2Int_Int32_Placement_Il2CppStructArray_1_Vector2Int_Boolean_0;

	// Token: 0x04000041 RID: 65
	private static readonly IntPtr NativeMethodInfoPtr_PrintColliderTiles_Private_Void_byref_FlandreHomeFurniture_Il2CppStructArray_1_Vector2Int_0;

	// Token: 0x04000042 RID: 66
	private static readonly IntPtr NativeMethodInfoPtr_PrintColliderTiles_Public_Void_byref_FlandreHomeFurniture_Vector2Int_0;

	// Token: 0x04000043 RID: 67
	private static readonly IntPtr NativeMethodInfoPtr_ClearTilemap_Public_Void_0;

	// Token: 0x04000044 RID: 68
	private static readonly IntPtr NativeMethodInfoPtr_GetAllTargetPlacementGrids_Public_HashSet_1_Vector2Int_Placement_0;

	// Token: 0x04000045 RID: 69
	private static readonly IntPtr NativeMethodInfoPtr_CheckFurnitureCanSetHere_Public_Boolean_FlandreHomeFurniture_Vector2Int_0;

	// Token: 0x04000046 RID: 70
	private static readonly IntPtr NativeMethodInfoPtr_FindPositionToSet_Public_Boolean_byref_FlandreHomeFurniture_byref_Vector2Int_0;

	// Token: 0x04000047 RID: 71
	private static readonly IntPtr NativeMethodInfoPtr_InstantiateFurniture_Public_FlandreFurnitureComponent_byref_FlandreHomeFurniture_Vector2Int_0;

	// Token: 0x04000048 RID: 72
	private static readonly IntPtr NativeMethodInfoPtr_GetTargetPositionObject_Public_Boolean_Placement_Vector2Int_byref_FlandreFurnitureComponent_0;

	// Token: 0x04000049 RID: 73
	private static readonly IntPtr NativeMethodInfoPtr_GetAllSpawnedFurnitureInstance_Public_List_1_FlandreFurnitureComponent_0;

	// Token: 0x0400004A RID: 74
	private static readonly IntPtr NativeMethodInfoPtr_DeleteFurniture_Public_Void_FlandreFurnitureComponent_0;

	// Token: 0x0400004B RID: 75
	private static readonly IntPtr NativeMethodInfoPtr_SetOccupiedPosition_Public_Boolean_byref_FlandreHomeFurniture_Vector2Int_FlandreFurnitureComponent_0;

	// Token: 0x0400004C RID: 76
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOccupiedPosition_Public_Void_byref_FlandreHomeFurniture_Vector2Int_0;

	// Token: 0x0400004D RID: 77
	private static readonly IntPtr NativeMethodInfoPtr_SetFurnitureData_Public_Void_EditorMode_byref_FlandreHomeFurniture_Nullable_1_Vector2Int_Nullable_1_Vector2Int_0;

	// Token: 0x0400004E RID: 78
	private static readonly IntPtr NativeMethodInfoPtr_SetFurnitureData_Public_Void_EditorMode_Int32_Nullable_1_Vector2Int_Nullable_1_Vector2Int_0;

	// Token: 0x0400004F RID: 79
	private static readonly IntPtr NativeMethodInfoPtr_GetFurnitureWorldPosition_Public_Il2CppStructArray_1_Vector2Int_FlandreHomeFurniture_Vector2Int_0;

	// Token: 0x04000050 RID: 80
	private static readonly IntPtr NativeMethodInfoPtr_GetFurnitureWorldPositionNonAlloc_Public_Void_FlandreHomeFurniture_Vector2Int_Il2CppStructArray_1_Vector2Int_0;

	// Token: 0x04000051 RID: 81
	private static readonly IntPtr NativeMethodInfoPtr_GetTargetPlacementAvailableGrids_Private_Il2CppStructArray_1_Vector2Int_Placement_0;

	// Token: 0x04000052 RID: 82
	private static readonly IntPtr NativeMethodInfoPtr_LoadSavedFurnitures_Private_Void_0;

	// Token: 0x04000053 RID: 83
	private static readonly IntPtr NativeMethodInfoPtr_InitGridPosition_Private_Void_Tilemap_0;

	// Token: 0x04000054 RID: 84
	private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Private_Void_Transform_Vector2Int_0;

	// Token: 0x04000055 RID: 85
	private static readonly IntPtr NativeMethodInfoPtr_TrySpawnDefaultFurniture_Private_Void_0;

	// Token: 0x04000056 RID: 86
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

	// Token: 0x04000057 RID: 87
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000462 RID: 1122
	public enum EditorMode
	{
		// Token: 0x0400518B RID: 20875
		Move,
		// Token: 0x0400518C RID: 20876
		Delete,
		// Token: 0x0400518D RID: 20877
		Set
	}

	// Token: 0x02000463 RID: 1123
	[ObfuscatedName("FlandreHomeMap+<>c")]
	[Serializable]
	public new sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x06007BF2 RID: 31730 RVA: 0x002393E0 File Offset: 0x002375E0
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<FlandreHomeMap.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlandreHomeMap.__c>.NativeClassPtr);
			FlandreHomeMap.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap.__c>.NativeClassPtr, "<>9");
			FlandreHomeMap.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap.__c>.NativeClassPtr, "<>9__20_0");
			FlandreHomeMap.__c.NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap.__c>.NativeClassPtr, "<>9__20_1");
			FlandreHomeMap.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap.__c>.NativeClassPtr, "<>9__23_0");
			FlandreHomeMap.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap.__c>.NativeClassPtr, "<>9__24_0");
			FlandreHomeMap.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap.__c>.NativeClassPtr, 100663359);
			FlandreHomeMap.__c.NativeMethodInfoPtr__FindPositionToSet_b__20_0_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap.__c>.NativeClassPtr, 100663360);
			FlandreHomeMap.__c.NativeMethodInfoPtr__FindPositionToSet_b__20_1_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap.__c>.NativeClassPtr, 100663361);
			FlandreHomeMap.__c.NativeMethodInfoPtr__GetAllSpawnedFurnitureInstance_b__23_0_Internal_IEnumerable_1_FlandreFurnitureComponent_Dictionary_2_Placement_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap.__c>.NativeClassPtr, 100663362);
			FlandreHomeMap.__c.NativeMethodInfoPtr__DeleteFurniture_b__24_0_Internal_IEnumerable_1_FlandreFurnitureComponent_KeyValuePair_2_Vector2Int_Dictionary_2_Placement_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap.__c>.NativeClassPtr, 100663363);
		}

		// Token: 0x06007BF3 RID: 31731 RVA: 0x002394D4 File Offset: 0x002376D4
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreHomeMap.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BF4 RID: 31732 RVA: 0x00239510 File Offset: 0x00237710
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 2790, RefRangeEnd = 2793, XrefRangeStart = 2790, XrefRangeEnd = 2790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _FindPositionToSet_b__20_0(Vector2Int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.__c.NativeMethodInfoPtr__FindPositionToSet_b__20_0_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007BF5 RID: 31733 RVA: 0x0023955C File Offset: 0x0023775C
		[CallerCount(0)]
		public unsafe int _FindPositionToSet_b__20_1(Vector2Int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.__c.NativeMethodInfoPtr__FindPositionToSet_b__20_1_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007BF6 RID: 31734 RVA: 0x002395A8 File Offset: 0x002377A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2793, XrefRangeEnd = 2797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<FlandreFurnitureComponent> _GetAllSpawnedFurnitureInstance_b__23_0(Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, FlandreFurnitureComponent> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.__c.NativeMethodInfoPtr__GetAllSpawnedFurnitureInstance_b__23_0_Internal_IEnumerable_1_FlandreFurnitureComponent_Dictionary_2_Placement_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FlandreFurnitureComponent>>(intPtr3) : null;
		}

		// Token: 0x06007BF7 RID: 31735 RVA: 0x002395F8 File Offset: 0x002377F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2797, XrefRangeEnd = 2802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<FlandreFurnitureComponent> _DeleteFurniture_b__24_0(KeyValuePair<Vector2Int, Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, FlandreFurnitureComponent>> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.__c.NativeMethodInfoPtr__DeleteFurniture_b__24_0_Internal_IEnumerable_1_FlandreFurnitureComponent_KeyValuePair_2_Vector2Int_Dictionary_2_Placement_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<FlandreFurnitureComponent>>(intPtr3) : null;
		}

		// Token: 0x06007BF8 RID: 31736 RVA: 0x00042BAD File Offset: 0x00040DAD
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x06007BF9 RID: 31737 RVA: 0x00239650 File Offset: 0x00237850
		// (set) Token: 0x06007BFA RID: 31738 RVA: 0x00042BB6 File Offset: 0x00040DB6
		public unsafe static FlandreHomeMap.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FlandreHomeMap.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlandreHomeMap.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlandreHomeMap.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x06007BFB RID: 31739 RVA: 0x00239678 File Offset: 0x00237878
		// (set) Token: 0x06007BFC RID: 31740 RVA: 0x00042BC8 File Offset: 0x00040DC8
		public unsafe static Func<Vector2Int, int> __9__20_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FlandreHomeMap.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlandreHomeMap.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x06007BFD RID: 31741 RVA: 0x002396A0 File Offset: 0x002378A0
		// (set) Token: 0x06007BFE RID: 31742 RVA: 0x00042BDA File Offset: 0x00040DDA
		public unsafe static Func<Vector2Int, int> __9__20_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FlandreHomeMap.__c.NativeFieldInfoPtr___9__20_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlandreHomeMap.__c.NativeFieldInfoPtr___9__20_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x06007BFF RID: 31743 RVA: 0x002396C8 File Offset: 0x002378C8
		// (set) Token: 0x06007C00 RID: 31744 RVA: 0x00042BEC File Offset: 0x00040DEC
		public unsafe static Func<Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, FlandreFurnitureComponent>, IEnumerable<FlandreFurnitureComponent>> __9__23_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FlandreHomeMap.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, FlandreFurnitureComponent>, IEnumerable<FlandreFurnitureComponent>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlandreHomeMap.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x06007C01 RID: 31745 RVA: 0x002396F0 File Offset: 0x002378F0
		// (set) Token: 0x06007C02 RID: 31746 RVA: 0x00042BFE File Offset: 0x00040DFE
		public unsafe static Func<KeyValuePair<Vector2Int, Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, FlandreFurnitureComponent>>, IEnumerable<FlandreFurnitureComponent>> __9__24_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FlandreHomeMap.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Vector2Int, Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, FlandreFurnitureComponent>>, IEnumerable<FlandreFurnitureComponent>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlandreHomeMap.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400518E RID: 20878
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400518F RID: 20879
		private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

		// Token: 0x04005190 RID: 20880
		private static readonly IntPtr NativeFieldInfoPtr___9__20_1;

		// Token: 0x04005191 RID: 20881
		private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

		// Token: 0x04005192 RID: 20882
		private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

		// Token: 0x04005193 RID: 20883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005194 RID: 20884
		private static readonly IntPtr NativeMethodInfoPtr__FindPositionToSet_b__20_0_Internal_Int32_Vector2Int_0;

		// Token: 0x04005195 RID: 20885
		private static readonly IntPtr NativeMethodInfoPtr__FindPositionToSet_b__20_1_Internal_Int32_Vector2Int_0;

		// Token: 0x04005196 RID: 20886
		private static readonly IntPtr NativeMethodInfoPtr__GetAllSpawnedFurnitureInstance_b__23_0_Internal_IEnumerable_1_FlandreFurnitureComponent_Dictionary_2_Placement_FlandreFurnitureComponent_0;

		// Token: 0x04005197 RID: 20887
		private static readonly IntPtr NativeMethodInfoPtr__DeleteFurniture_b__24_0_Internal_IEnumerable_1_FlandreFurnitureComponent_KeyValuePair_2_Vector2Int_Dictionary_2_Placement_FlandreFurnitureComponent_0;
	}

	// Token: 0x02000464 RID: 1124
	[ObfuscatedName("FlandreHomeMap+<>c__DisplayClass24_0")]
	public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
	{
		// Token: 0x06007C03 RID: 31747 RVA: 0x00239718 File Offset: 0x00237918
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass24_0()
		{
			Il2CppClassPointerStore<FlandreHomeMap.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlandreHomeMap>.NativeClassPtr, "<>c__DisplayClass24_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlandreHomeMap.__c__DisplayClass24_0>.NativeClassPtr);
			FlandreHomeMap.__c__DisplayClass24_0.NativeFieldInfoPtr_furnitureObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreHomeMap.__c__DisplayClass24_0>.NativeClassPtr, "furnitureObject");
			FlandreHomeMap.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap.__c__DisplayClass24_0>.NativeClassPtr, 100663364);
			FlandreHomeMap.__c__DisplayClass24_0.NativeMethodInfoPtr__DeleteFurniture_b__1_Internal_Boolean_FlandreFurnitureComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreHomeMap.__c__DisplayClass24_0>.NativeClassPtr, 100663365);
		}

		// Token: 0x06007C04 RID: 31748 RVA: 0x00239780 File Offset: 0x00237980
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreHomeMap.__c__DisplayClass24_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C05 RID: 31749 RVA: 0x002397BC File Offset: 0x002379BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2802, XrefRangeEnd = 2806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _DeleteFurniture_b__1(FlandreFurnitureComponent x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreHomeMap.__c__DisplayClass24_0.NativeMethodInfoPtr__DeleteFurniture_b__1_Internal_Boolean_FlandreFurnitureComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007C06 RID: 31750 RVA: 0x00042C10 File Offset: 0x00040E10
		public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x06007C07 RID: 31751 RVA: 0x0023980C File Offset: 0x00237A0C
		// (set) Token: 0x06007C08 RID: 31752 RVA: 0x00042C19 File Offset: 0x00040E19
		public unsafe FlandreFurnitureComponent furnitureObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.__c__DisplayClass24_0.NativeFieldInfoPtr_furnitureObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlandreFurnitureComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreHomeMap.__c__DisplayClass24_0.NativeFieldInfoPtr_furnitureObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005198 RID: 20888
		private static readonly IntPtr NativeFieldInfoPtr_furnitureObject;

		// Token: 0x04005199 RID: 20889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400519A RID: 20890
		private static readonly IntPtr NativeMethodInfoPtr__DeleteFurniture_b__1_Internal_Boolean_FlandreFurnitureComponent_0;
	}
}
