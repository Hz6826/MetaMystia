using System;
using System.Runtime.InteropServices;
using DayScene.Input;
using DEYU.Singletons;
using DEYU.UniversalUISystem;
using DEYU.Utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace NightScene.Tiles
{
	// Token: 0x020001B1 RID: 433
	public class TileManager : MonoSingleton<TileManager>
	{
		// Token: 0x06003435 RID: 13365 RVA: 0x00151CA8 File Offset: 0x0014FEA8
		// Note: this type is marked as 'beforefieldinit'.
		static TileManager()
		{
			Il2CppClassPointerStore<TileManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.Tiles", "TileManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileManager>.NativeClassPtr);
			TileManager.NativeFieldInfoPtr_onSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "onSelection");
			TileManager.NativeFieldInfoPtr_stencilPainterParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "stencilPainterParent");
			TileManager.NativeFieldInfoPtr_stencilPainterField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "stencilPainterField");
			TileManager.NativeFieldInfoPtr_activePainter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "activePainter");
			TileManager.NativeFieldInfoPtr_allGuestTables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "allGuestTables");
			TileManager.NativeFieldInfoPtr_idlePainter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "idlePainter");
			TileManager.NativeFieldInfoPtr_interactablesCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "interactablesCenter");
			TileManager.NativeFieldInfoPtr_interactablesHighlightedVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "interactablesHighlightedVisual");
			TileManager.NativeFieldInfoPtr_AllAvailableAreas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "AllAvailableAreas");
			TileManager.NativeFieldInfoPtr_allColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "allColliders");
			TileManager.NativeFieldInfoPtr_rayBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "rayBorder");
			TileManager.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "interactable");
			TileManager.NativeFieldInfoPtr_collidable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "collidable");
			TileManager.NativeFieldInfoPtr_inOutDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "inOutDoor");
			TileManager.NativeFieldInfoPtr_rayCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "rayCollider");
			TileManager.NativeFieldInfoPtr_lastPainterBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "lastPainterBuffer");
			TileManager.NativeFieldInfoPtr_tileTypeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "tileTypeBuffer");
			TileManager.NativeFieldInfoPtr__LayoutGrid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<LayoutGrid>k__BackingField");
			TileManager.NativeFieldInfoPtr__ThrowDeliverExclusion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<ThrowDeliverExclusion>k__BackingField");
			TileManager.NativeFieldInfoPtr__CookerDesks_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<CookerDesks>k__BackingField");
			TileManager.NativeFieldInfoPtr__FoodStorage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<FoodStorage>k__BackingField");
			TileManager.NativeFieldInfoPtr__BeverageStorage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<BeverageStorage>k__BackingField");
			TileManager.NativeFieldInfoPtr__FoodStorageBoss_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<FoodStorageBoss>k__BackingField");
			TileManager.NativeFieldInfoPtr__BeverageStorageBoss_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<BeverageStorageBoss>k__BackingField");
			TileManager.NativeFieldInfoPtr__GuestSpawnA_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<GuestSpawnA>k__BackingField");
			TileManager.NativeFieldInfoPtr__GuestSpawnB_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<GuestSpawnB>k__BackingField");
			TileManager.NativeFieldInfoPtr__PlayerSpawn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<PlayerSpawn>k__BackingField");
			TileManager.NativeFieldInfoPtr__PasserBorder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<PasserBorder>k__BackingField");
			TileManager.NativeFieldInfoPtr__AIdle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<AIdle>k__BackingField");
			TileManager.NativeFieldInfoPtr__WaitSeats_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<WaitSeats>k__BackingField");
			TileManager.NativeFieldInfoPtr__GuestTables_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<GuestTables>k__BackingField");
			TileManager.NativeMethodInfoPtr_get_LayoutGrid_Public_get_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673284);
			TileManager.NativeMethodInfoPtr_set_LayoutGrid_Private_set_Void_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673285);
			TileManager.NativeMethodInfoPtr_get_ThrowDeliverExclusion_Public_get_ICollection_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673286);
			TileManager.NativeMethodInfoPtr_get_CookerDesks_Public_get_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673287);
			TileManager.NativeMethodInfoPtr_set_CookerDesks_Private_set_Void_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673288);
			TileManager.NativeMethodInfoPtr_get_FoodStorage_Public_get_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673289);
			TileManager.NativeMethodInfoPtr_set_FoodStorage_Private_set_Void_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673290);
			TileManager.NativeMethodInfoPtr_get_BeverageStorage_Public_get_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673291);
			TileManager.NativeMethodInfoPtr_set_BeverageStorage_Private_set_Void_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673292);
			TileManager.NativeMethodInfoPtr_get_FoodStorageBoss_Public_get_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673293);
			TileManager.NativeMethodInfoPtr_set_FoodStorageBoss_Private_set_Void_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673294);
			TileManager.NativeMethodInfoPtr_get_BeverageStorageBoss_Public_get_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673295);
			TileManager.NativeMethodInfoPtr_set_BeverageStorageBoss_Private_set_Void_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673296);
			TileManager.NativeMethodInfoPtr_get_GuestSpawnA_Public_get_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673297);
			TileManager.NativeMethodInfoPtr_set_GuestSpawnA_Private_set_Void_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673298);
			TileManager.NativeMethodInfoPtr_get_GuestSpawnB_Public_get_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673299);
			TileManager.NativeMethodInfoPtr_set_GuestSpawnB_Private_set_Void_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673300);
			TileManager.NativeMethodInfoPtr_get_PlayerSpawn_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673301);
			TileManager.NativeMethodInfoPtr_set_PlayerSpawn_Private_set_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673302);
			TileManager.NativeMethodInfoPtr_get_PasserBorder_Public_get_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673303);
			TileManager.NativeMethodInfoPtr_set_PasserBorder_Private_set_Void_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673304);
			TileManager.NativeMethodInfoPtr_get_AIdle_Public_get_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673305);
			TileManager.NativeMethodInfoPtr_set_AIdle_Private_set_Void_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673306);
			TileManager.NativeMethodInfoPtr_get_Rabbit_Public_get_IEnumerable_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673307);
			TileManager.NativeMethodInfoPtr_get_WaitSeats_Public_get_Il2CppReferenceArray_1_ValueTuple_2_Vector3Int_CharacterRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673308);
			TileManager.NativeMethodInfoPtr_set_WaitSeats_Private_set_Void_Il2CppReferenceArray_1_ValueTuple_2_Vector3Int_CharacterRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673309);
			TileManager.NativeMethodInfoPtr_get_GuestTables_Public_get_Dictionary_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673310);
			TileManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673311);
			TileManager.NativeMethodInfoPtr_GetInteractablesCenter_Public_Vector3_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673312);
			TileManager.NativeMethodInfoPtr_GetCustomerDesk_Public_InteractableTile_Int32_byref_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673313);
			TileManager.NativeMethodInfoPtr_GetCellCenterWorld_Public_Vector3_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673314);
			TileManager.NativeMethodInfoPtr_GetCollider_Public_ScopedTempHashSetHandle_1_Vector2Int_Vector3Int_IReadOnlyList_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673315);
			TileManager.NativeMethodInfoPtr_GetCollider_Public_ScopedTempHashSetHandle_1_Vector2Int_IReadOnlyList_1_Vector3Int_IReadOnlyList_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673316);
			TileManager.NativeMethodInfoPtr_AddToColliders_Private_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673317);
			TileManager.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673318);
			TileManager.NativeMethodInfoPtr_UpdateInputAvailability_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673319);
			TileManager.NativeMethodInfoPtr_UpdateCurser_Public_Void_Nullable_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673320);
			TileManager.NativeMethodInfoPtr_ShowPainter_Private_Void_Vector3_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673321);
			TileManager.NativeMethodInfoPtr_HidePainter_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673322);
			TileManager.NativeMethodInfoPtr_RemapPosition_Public_Vector3Int_Vector3Int_byref_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673323);
			TileManager.NativeMethodInfoPtr_GetInteractableType_Public_TileType_Vector3Int_byref_InteractableTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673324);
			TileManager.NativeMethodInfoPtr_GetDirection_Private_Static_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673325);
			TileManager.NativeMethodInfoPtr_FindDirection_Public_Static_Int32_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673326);
			TileManager.NativeMethodInfoPtr_GetGuestSeats_Private_Il2CppStructArray_1_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673327);
			TileManager.NativeMethodInfoPtr_GetGuestDesk_Private_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673328);
			TileManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673329);
			TileManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673330);
			TileManager.NativeMethodInfoPtr_Method_Internal_Static_Vector3_IEnumerable_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager>.NativeClassPtr, 100673331);
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x00152304 File Offset: 0x00150504
		// (set) Token: 0x06003437 RID: 13367 RVA: 0x00152344 File Offset: 0x00150544
		public unsafe Grid LayoutGrid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22275, RefRangeEnd = 22276, XrefRangeStart = 22275, XrefRangeEnd = 22276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_LayoutGrid_Public_get_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124077, XrefRangeEnd = 124078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_set_LayoutGrid_Private_set_Void_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x00152388 File Offset: 0x00150588
		public unsafe ICollection<int> ThrowDeliverExclusion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_ThrowDeliverExclusion_Public_get_ICollection_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06003439 RID: 13369 RVA: 0x001523C8 File Offset: 0x001505C8
		// (set) Token: 0x0600343A RID: 13370 RVA: 0x00152408 File Offset: 0x00150608
		public unsafe Il2CppStructArray<Vector3Int> CookerDesks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_CookerDesks_Public_get_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_set_CookerDesks_Private_set_Void_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x0600343B RID: 13371 RVA: 0x0015244C File Offset: 0x0015064C
		// (set) Token: 0x0600343C RID: 13372 RVA: 0x0015248C File Offset: 0x0015068C
		public unsafe Il2CppStructArray<Vector3Int> FoodStorage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_FoodStorage_Public_get_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_set_FoodStorage_Private_set_Void_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x0600343D RID: 13373 RVA: 0x001524D0 File Offset: 0x001506D0
		// (set) Token: 0x0600343E RID: 13374 RVA: 0x00152510 File Offset: 0x00150710
		public unsafe Il2CppStructArray<Vector3Int> BeverageStorage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_BeverageStorage_Public_get_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_set_BeverageStorage_Private_set_Void_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x0600343F RID: 13375 RVA: 0x00152554 File Offset: 0x00150754
		// (set) Token: 0x06003440 RID: 13376 RVA: 0x00152594 File Offset: 0x00150794
		public unsafe Il2CppStructArray<Vector3Int> FoodStorageBoss
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_FoodStorageBoss_Public_get_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_set_FoodStorageBoss_Private_set_Void_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x06003441 RID: 13377 RVA: 0x001525D8 File Offset: 0x001507D8
		// (set) Token: 0x06003442 RID: 13378 RVA: 0x00152618 File Offset: 0x00150818
		public unsafe Il2CppStructArray<Vector3Int> BeverageStorageBoss
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_BeverageStorageBoss_Public_get_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_set_BeverageStorageBoss_Private_set_Void_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x0015265C File Offset: 0x0015085C
		// (set) Token: 0x06003444 RID: 13380 RVA: 0x0015269C File Offset: 0x0015089C
		public unsafe Il2CppStructArray<Vector3Int> GuestSpawnA
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 40645, RefRangeEnd = 40646, XrefRangeStart = 40645, XrefRangeEnd = 40646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_GuestSpawnA_Public_get_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_set_GuestSpawnA_Private_set_Void_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x06003445 RID: 13381 RVA: 0x001526E0 File Offset: 0x001508E0
		// (set) Token: 0x06003446 RID: 13382 RVA: 0x00152720 File Offset: 0x00150920
		public unsafe Il2CppStructArray<Vector3Int> GuestSpawnB
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_GuestSpawnB_Public_get_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_set_GuestSpawnB_Private_set_Void_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x06003447 RID: 13383 RVA: 0x00152764 File Offset: 0x00150964
		// (set) Token: 0x06003448 RID: 13384 RVA: 0x001527A0 File Offset: 0x001509A0
		public unsafe Vector3Int PlayerSpawn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_PlayerSpawn_Public_get_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_set_PlayerSpawn_Private_set_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x06003449 RID: 13385 RVA: 0x001527E0 File Offset: 0x001509E0
		// (set) Token: 0x0600344A RID: 13386 RVA: 0x00152820 File Offset: 0x00150A20
		public unsafe Il2CppStructArray<Vector3Int> PasserBorder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_PasserBorder_Public_get_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_set_PasserBorder_Private_set_Void_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x00152864 File Offset: 0x00150A64
		// (set) Token: 0x0600344C RID: 13388 RVA: 0x001528A4 File Offset: 0x00150AA4
		public unsafe Il2CppStructArray<Vector3Int> AIdle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_AIdle_Public_get_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_set_AIdle_Private_set_Void_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x001528E8 File Offset: 0x00150AE8
		public unsafe IEnumerable<Vector2Int> Rabbit
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 124081, RefRangeEnd = 124085, XrefRangeStart = 124078, XrefRangeEnd = 124081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_Rabbit_Public_get_IEnumerable_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector2Int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x0600344E RID: 13390 RVA: 0x00152928 File Offset: 0x00150B28
		// (set) Token: 0x0600344F RID: 13391 RVA: 0x00152968 File Offset: 0x00150B68
		public unsafe Il2CppReferenceArray<ValueTuple<Vector3Int, DayScenePlayerInputGenerator.CharacterRotation>> WaitSeats
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_WaitSeats_Public_get_Il2CppReferenceArray_1_ValueTuple_2_Vector3Int_CharacterRotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<Vector3Int, DayScenePlayerInputGenerator.CharacterRotation>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_set_WaitSeats_Private_set_Void_Il2CppReferenceArray_1_ValueTuple_2_Vector3Int_CharacterRotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x06003450 RID: 13392 RVA: 0x001529AC File Offset: 0x00150BAC
		public unsafe Dictionary<int, TileManager.GuestTableData> GuestTables
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_get_GuestTables_Public_get_Dictionary_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TileManager.GuestTableData>>(intPtr3) : null;
			}
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x001529EC File Offset: 0x00150BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124085, XrefRangeEnd = 124096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00152A20 File Offset: 0x00150C20
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 124099, RefRangeEnd = 124107, XrefRangeStart = 124096, XrefRangeEnd = 124099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetInteractablesCenter(InteractableTile.TileType tileType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tileType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_GetInteractablesCenter_Public_Vector3_TileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00152A6C File Offset: 0x00150C6C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 124112, RefRangeEnd = 124117, XrefRangeStart = 124107, XrefRangeEnd = 124112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractableTile GetCustomerDesk(int deskCode, out Vector3Int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_GetCustomerDesk_Public_InteractableTile_Int32_byref_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteractableTile>(intPtr3) : null;
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00152AC8 File Offset: 0x00150CC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124118, RefRangeEnd = 124120, XrefRangeStart = 124117, XrefRangeEnd = 124118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetCellCenterWorld(Vector3Int cellPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cellPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_GetCellCenterWorld_Public_Vector3_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x00152B14 File Offset: 0x00150D14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 124148, RefRangeEnd = 124151, XrefRangeStart = 124120, XrefRangeEnd = 124148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int> GetCollider(Vector3Int colliderExclusion, IReadOnlyList<Vector3Int> appendColliderExclusion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colliderExclusion;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appendColliderExclusion);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_GetCollider_Public_ScopedTempHashSetHandle_1_Vector2Int_Vector3Int_IReadOnlyList_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int>(pointer);
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x00152B6C File Offset: 0x00150D6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124193, RefRangeEnd = 124195, XrefRangeStart = 124151, XrefRangeEnd = 124193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int> GetCollider(IReadOnlyList<Vector3Int> colliderExclusion, IReadOnlyList<Vector3Int> appendColliderExclusion = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colliderExclusion);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appendColliderExclusion);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_GetCollider_Public_ScopedTempHashSetHandle_1_Vector2Int_IReadOnlyList_1_Vector3Int_IReadOnlyList_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int>(pointer);
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00152BC8 File Offset: 0x00150DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124195, XrefRangeEnd = 124200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToColliders(Vector3Int collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref collider;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_AddToColliders_Private_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00152C08 File Offset: 0x00150E08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124672, RefRangeEnd = 124673, XrefRangeStart = 124200, XrefRangeEnd = 124672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x00152C3C File Offset: 0x00150E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124673, XrefRangeEnd = 124674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputAvailability(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_UpdateInputAvailability_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x00152C7C File Offset: 0x00150E7C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 124771, RefRangeEnd = 124777, XrefRangeStart = 124674, XrefRangeEnd = 124771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurser(Nullable<Vector3Int> requestedPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(requestedPosition));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_UpdateCurser_Public_Void_Nullable_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x00152CC4 File Offset: 0x00150EC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124818, RefRangeEnd = 124819, XrefRangeStart = 124777, XrefRangeEnd = 124818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowPainter(Vector3 coordinate, Sprite visual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref coordinate;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_ShowPainter_Private_Void_Vector3_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x00152D14 File Offset: 0x00150F14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124845, RefRangeEnd = 124846, XrefRangeStart = 124819, XrefRangeEnd = 124845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HidePainter(Vector3 coordinate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref coordinate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_HidePainter_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x00152D54 File Offset: 0x00150F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124860, RefRangeEnd = 124861, XrefRangeStart = 124846, XrefRangeEnd = 124860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Int RemapPosition(Vector3Int position, out InteractableTile.TileType clickType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &clickType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_RemapPosition_Public_Vector3Int_Vector3Int_byref_TileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x00152DAC File Offset: 0x00150FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124869, RefRangeEnd = 124870, XrefRangeStart = 124861, XrefRangeEnd = 124869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractableTile.TileType GetInteractableType(Vector3Int position, out InteractableTile atPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_GetInteractableType_Public_TileType_Vector3Int_byref_InteractableTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			atPos = ((intPtr4 == 0) ? null : new InteractableTile(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x00152E18 File Offset: 0x00151018
		[CallerCount(0)]
		public unsafe static Vector3Int GetDirection(int direction)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_GetDirection_Private_Static_Vector3Int_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x00152E58 File Offset: 0x00151058
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 124885, RefRangeEnd = 124892, XrefRangeStart = 124870, XrefRangeEnd = 124885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindDirection(Vector3 self, Vector3 towards)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref towards;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_FindDirection_Public_Static_Int32_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x00152EA4 File Offset: 0x001510A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124923, RefRangeEnd = 124924, XrefRangeStart = 124892, XrefRangeEnd = 124923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Vector3Int> GetGuestSeats(Vector3Int deskCord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_GetGuestSeats_Private_Il2CppStructArray_1_Vector3Int_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr3) : null;
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x00152EF0 File Offset: 0x001510F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 124941, RefRangeEnd = 124943, XrefRangeStart = 124924, XrefRangeEnd = 124941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Int GetGuestDesk(Vector3Int seatCord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref seatCord;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_GetGuestDesk_Private_Vector3Int_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00152F3C File Offset: 0x0015113C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124943, XrefRangeEnd = 124982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TileManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x00152F78 File Offset: 0x00151178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124982, XrefRangeEnd = 125052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00152FB4 File Offset: 0x001511B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 125090, RefRangeEnd = 125095, XrefRangeStart = 125052, XrefRangeEnd = 125090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Method_Internal_Static_Vector3_IEnumerable_1_Vector3Int_0(IEnumerable<Vector3Int> locations)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(locations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.NativeMethodInfoPtr_Method_Internal_Static_Vector3_IEnumerable_1_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x0001D0BB File Offset: 0x0001B2BB
		public TileManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x06003467 RID: 13415 RVA: 0x00152FF8 File Offset: 0x001511F8
		// (set) Token: 0x06003468 RID: 13416 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
		public unsafe UIElementCluster onSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_onSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_onSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06003469 RID: 13417 RVA: 0x00153028 File Offset: 0x00151228
		// (set) Token: 0x0600346A RID: 13418 RVA: 0x0001D0E3 File Offset: 0x0001B2E3
		public unsafe GameObject stencilPainterParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_stencilPainterParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_stencilPainterParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x0600346B RID: 13419 RVA: 0x00153058 File Offset: 0x00151258
		// (set) Token: 0x0600346C RID: 13420 RVA: 0x0001D102 File Offset: 0x0001B302
		public unsafe Transform stencilPainterField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_stencilPainterField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_stencilPainterField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x0600346D RID: 13421 RVA: 0x00153088 File Offset: 0x00151288
		// (set) Token: 0x0600346E RID: 13422 RVA: 0x0001D121 File Offset: 0x0001B321
		public unsafe Dictionary<Vector3, StencilPainterController> activePainter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_activePainter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector3, StencilPainterController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_activePainter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x0600346F RID: 13423 RVA: 0x001530B8 File Offset: 0x001512B8
		// (set) Token: 0x06003470 RID: 13424 RVA: 0x0001D140 File Offset: 0x0001B340
		public unsafe Dictionary<int, ValueTuple<InteractableTile, Vector3Int>> allGuestTables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_allGuestTables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<InteractableTile, Vector3Int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_allGuestTables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x06003471 RID: 13425 RVA: 0x001530E8 File Offset: 0x001512E8
		// (set) Token: 0x06003472 RID: 13426 RVA: 0x0001D15F File Offset: 0x0001B35F
		public unsafe Queue<StencilPainterController> idlePainter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_idlePainter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<StencilPainterController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_idlePainter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x06003473 RID: 13427 RVA: 0x00153118 File Offset: 0x00151318
		// (set) Token: 0x06003474 RID: 13428 RVA: 0x0001D17E File Offset: 0x0001B37E
		public unsafe Dictionary<InteractableTile.TileType, Vector3> interactablesCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_interactablesCenter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<InteractableTile.TileType, Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_interactablesCenter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x00153148 File Offset: 0x00151348
		// (set) Token: 0x06003476 RID: 13430 RVA: 0x0001D19D File Offset: 0x0001B39D
		public unsafe Dictionary<Sprite, Sprite> interactablesHighlightedVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_interactablesHighlightedVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Sprite, Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_interactablesHighlightedVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x00153178 File Offset: 0x00151378
		// (set) Token: 0x06003478 RID: 13432 RVA: 0x0001D1BC File Offset: 0x0001B3BC
		public unsafe HashSet<Vector2Int> AllAvailableAreas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_AllAvailableAreas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_AllAvailableAreas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x06003479 RID: 13433 RVA: 0x001531A8 File Offset: 0x001513A8
		// (set) Token: 0x0600347A RID: 13434 RVA: 0x0001D1DB File Offset: 0x0001B3DB
		public unsafe HashSet<Vector2Int> allColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_allColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_allColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x0600347B RID: 13435 RVA: 0x001531D8 File Offset: 0x001513D8
		// (set) Token: 0x0600347C RID: 13436 RVA: 0x0001D1FA File Offset: 0x0001B3FA
		public unsafe HashSet<Vector2Int> rayBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_rayBorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_rayBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x0600347D RID: 13437 RVA: 0x00153208 File Offset: 0x00151408
		// (set) Token: 0x0600347E RID: 13438 RVA: 0x0001D219 File Offset: 0x0001B419
		public unsafe Tilemap interactable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_interactable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_interactable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x0600347F RID: 13439 RVA: 0x00153238 File Offset: 0x00151438
		// (set) Token: 0x06003480 RID: 13440 RVA: 0x0001D238 File Offset: 0x0001B438
		public unsafe Tilemap collidable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_collidable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_collidable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x06003481 RID: 13441 RVA: 0x00153268 File Offset: 0x00151468
		// (set) Token: 0x06003482 RID: 13442 RVA: 0x0001D257 File Offset: 0x0001B457
		public unsafe Tilemap inOutDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_inOutDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_inOutDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x06003483 RID: 13443 RVA: 0x00153298 File Offset: 0x00151498
		// (set) Token: 0x06003484 RID: 13444 RVA: 0x0001D276 File Offset: 0x0001B476
		public unsafe Tilemap rayCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_rayCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_rayCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x06003485 RID: 13445 RVA: 0x001532C8 File Offset: 0x001514C8
		// (set) Token: 0x06003486 RID: 13446 RVA: 0x0001D295 File Offset: 0x0001B495
		public unsafe Vector3 lastPainterBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_lastPainterBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_lastPainterBuffer)) = value;
			}
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x06003487 RID: 13447 RVA: 0x001532F0 File Offset: 0x001514F0
		// (set) Token: 0x06003488 RID: 13448 RVA: 0x0001D2B0 File Offset: 0x0001B4B0
		public unsafe InteractableTile.TileType tileTypeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_tileTypeBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr_tileTypeBuffer)) = value;
			}
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x06003489 RID: 13449 RVA: 0x00153318 File Offset: 0x00151518
		// (set) Token: 0x0600348A RID: 13450 RVA: 0x0001D2CB File Offset: 0x0001B4CB
		public unsafe Grid _LayoutGrid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__LayoutGrid_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__LayoutGrid_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x0600348B RID: 13451 RVA: 0x00153348 File Offset: 0x00151548
		// (set) Token: 0x0600348C RID: 13452 RVA: 0x0001D2EA File Offset: 0x0001B4EA
		public unsafe ICollection<int> _ThrowDeliverExclusion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__ThrowDeliverExclusion_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICollection<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__ThrowDeliverExclusion_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x0600348D RID: 13453 RVA: 0x00153378 File Offset: 0x00151578
		// (set) Token: 0x0600348E RID: 13454 RVA: 0x0001D309 File Offset: 0x0001B509
		public unsafe Il2CppStructArray<Vector3Int> _CookerDesks_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__CookerDesks_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__CookerDesks_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x0600348F RID: 13455 RVA: 0x001533A8 File Offset: 0x001515A8
		// (set) Token: 0x06003490 RID: 13456 RVA: 0x0001D328 File Offset: 0x0001B528
		public unsafe Il2CppStructArray<Vector3Int> _FoodStorage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__FoodStorage_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__FoodStorage_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06003491 RID: 13457 RVA: 0x001533D8 File Offset: 0x001515D8
		// (set) Token: 0x06003492 RID: 13458 RVA: 0x0001D347 File Offset: 0x0001B547
		public unsafe Il2CppStructArray<Vector3Int> _BeverageStorage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__BeverageStorage_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__BeverageStorage_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06003493 RID: 13459 RVA: 0x00153408 File Offset: 0x00151608
		// (set) Token: 0x06003494 RID: 13460 RVA: 0x0001D366 File Offset: 0x0001B566
		public unsafe Il2CppStructArray<Vector3Int> _FoodStorageBoss_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__FoodStorageBoss_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__FoodStorageBoss_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x06003495 RID: 13461 RVA: 0x00153438 File Offset: 0x00151638
		// (set) Token: 0x06003496 RID: 13462 RVA: 0x0001D385 File Offset: 0x0001B585
		public unsafe Il2CppStructArray<Vector3Int> _BeverageStorageBoss_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__BeverageStorageBoss_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__BeverageStorageBoss_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x06003497 RID: 13463 RVA: 0x00153468 File Offset: 0x00151668
		// (set) Token: 0x06003498 RID: 13464 RVA: 0x0001D3A4 File Offset: 0x0001B5A4
		public unsafe Il2CppStructArray<Vector3Int> _GuestSpawnA_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__GuestSpawnA_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__GuestSpawnA_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x06003499 RID: 13465 RVA: 0x00153498 File Offset: 0x00151698
		// (set) Token: 0x0600349A RID: 13466 RVA: 0x0001D3C3 File Offset: 0x0001B5C3
		public unsafe Il2CppStructArray<Vector3Int> _GuestSpawnB_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__GuestSpawnB_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__GuestSpawnB_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x0600349B RID: 13467 RVA: 0x001534C8 File Offset: 0x001516C8
		// (set) Token: 0x0600349C RID: 13468 RVA: 0x0001D3E2 File Offset: 0x0001B5E2
		public unsafe Vector3Int _PlayerSpawn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__PlayerSpawn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__PlayerSpawn_k__BackingField)) = value;
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x0600349D RID: 13469 RVA: 0x001534F0 File Offset: 0x001516F0
		// (set) Token: 0x0600349E RID: 13470 RVA: 0x0001D3FD File Offset: 0x0001B5FD
		public unsafe Il2CppStructArray<Vector3Int> _PasserBorder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__PasserBorder_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__PasserBorder_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x0600349F RID: 13471 RVA: 0x00153520 File Offset: 0x00151720
		// (set) Token: 0x060034A0 RID: 13472 RVA: 0x0001D41C File Offset: 0x0001B61C
		public unsafe Il2CppStructArray<Vector3Int> _AIdle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__AIdle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__AIdle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x060034A1 RID: 13473 RVA: 0x00153550 File Offset: 0x00151750
		// (set) Token: 0x060034A2 RID: 13474 RVA: 0x0001D43B File Offset: 0x0001B63B
		public unsafe Il2CppReferenceArray<ValueTuple<Vector3Int, DayScenePlayerInputGenerator.CharacterRotation>> _WaitSeats_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__WaitSeats_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<Vector3Int, DayScenePlayerInputGenerator.CharacterRotation>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__WaitSeats_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x060034A3 RID: 13475 RVA: 0x00153580 File Offset: 0x00151780
		// (set) Token: 0x060034A4 RID: 13476 RVA: 0x0001D45A File Offset: 0x0001B65A
		public unsafe Dictionary<int, TileManager.GuestTableData> _GuestTables_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__GuestTables_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TileManager.GuestTableData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.NativeFieldInfoPtr__GuestTables_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400233C RID: 9020
		private static readonly IntPtr NativeFieldInfoPtr_onSelection;

		// Token: 0x0400233D RID: 9021
		private static readonly IntPtr NativeFieldInfoPtr_stencilPainterParent;

		// Token: 0x0400233E RID: 9022
		private static readonly IntPtr NativeFieldInfoPtr_stencilPainterField;

		// Token: 0x0400233F RID: 9023
		private static readonly IntPtr NativeFieldInfoPtr_activePainter;

		// Token: 0x04002340 RID: 9024
		private static readonly IntPtr NativeFieldInfoPtr_allGuestTables;

		// Token: 0x04002341 RID: 9025
		private static readonly IntPtr NativeFieldInfoPtr_idlePainter;

		// Token: 0x04002342 RID: 9026
		private static readonly IntPtr NativeFieldInfoPtr_interactablesCenter;

		// Token: 0x04002343 RID: 9027
		private static readonly IntPtr NativeFieldInfoPtr_interactablesHighlightedVisual;

		// Token: 0x04002344 RID: 9028
		private static readonly IntPtr NativeFieldInfoPtr_AllAvailableAreas;

		// Token: 0x04002345 RID: 9029
		private static readonly IntPtr NativeFieldInfoPtr_allColliders;

		// Token: 0x04002346 RID: 9030
		private static readonly IntPtr NativeFieldInfoPtr_rayBorder;

		// Token: 0x04002347 RID: 9031
		private static readonly IntPtr NativeFieldInfoPtr_interactable;

		// Token: 0x04002348 RID: 9032
		private static readonly IntPtr NativeFieldInfoPtr_collidable;

		// Token: 0x04002349 RID: 9033
		private static readonly IntPtr NativeFieldInfoPtr_inOutDoor;

		// Token: 0x0400234A RID: 9034
		private static readonly IntPtr NativeFieldInfoPtr_rayCollider;

		// Token: 0x0400234B RID: 9035
		private static readonly IntPtr NativeFieldInfoPtr_lastPainterBuffer;

		// Token: 0x0400234C RID: 9036
		private static readonly IntPtr NativeFieldInfoPtr_tileTypeBuffer;

		// Token: 0x0400234D RID: 9037
		private static readonly IntPtr NativeFieldInfoPtr__LayoutGrid_k__BackingField;

		// Token: 0x0400234E RID: 9038
		private static readonly IntPtr NativeFieldInfoPtr__ThrowDeliverExclusion_k__BackingField;

		// Token: 0x0400234F RID: 9039
		private static readonly IntPtr NativeFieldInfoPtr__CookerDesks_k__BackingField;

		// Token: 0x04002350 RID: 9040
		private static readonly IntPtr NativeFieldInfoPtr__FoodStorage_k__BackingField;

		// Token: 0x04002351 RID: 9041
		private static readonly IntPtr NativeFieldInfoPtr__BeverageStorage_k__BackingField;

		// Token: 0x04002352 RID: 9042
		private static readonly IntPtr NativeFieldInfoPtr__FoodStorageBoss_k__BackingField;

		// Token: 0x04002353 RID: 9043
		private static readonly IntPtr NativeFieldInfoPtr__BeverageStorageBoss_k__BackingField;

		// Token: 0x04002354 RID: 9044
		private static readonly IntPtr NativeFieldInfoPtr__GuestSpawnA_k__BackingField;

		// Token: 0x04002355 RID: 9045
		private static readonly IntPtr NativeFieldInfoPtr__GuestSpawnB_k__BackingField;

		// Token: 0x04002356 RID: 9046
		private static readonly IntPtr NativeFieldInfoPtr__PlayerSpawn_k__BackingField;

		// Token: 0x04002357 RID: 9047
		private static readonly IntPtr NativeFieldInfoPtr__PasserBorder_k__BackingField;

		// Token: 0x04002358 RID: 9048
		private static readonly IntPtr NativeFieldInfoPtr__AIdle_k__BackingField;

		// Token: 0x04002359 RID: 9049
		private static readonly IntPtr NativeFieldInfoPtr__WaitSeats_k__BackingField;

		// Token: 0x0400235A RID: 9050
		private static readonly IntPtr NativeFieldInfoPtr__GuestTables_k__BackingField;

		// Token: 0x0400235B RID: 9051
		private static readonly IntPtr NativeMethodInfoPtr_get_LayoutGrid_Public_get_Grid_0;

		// Token: 0x0400235C RID: 9052
		private static readonly IntPtr NativeMethodInfoPtr_set_LayoutGrid_Private_set_Void_Grid_0;

		// Token: 0x0400235D RID: 9053
		private static readonly IntPtr NativeMethodInfoPtr_get_ThrowDeliverExclusion_Public_get_ICollection_1_Int32_0;

		// Token: 0x0400235E RID: 9054
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerDesks_Public_get_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x0400235F RID: 9055
		private static readonly IntPtr NativeMethodInfoPtr_set_CookerDesks_Private_set_Void_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x04002360 RID: 9056
		private static readonly IntPtr NativeMethodInfoPtr_get_FoodStorage_Public_get_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x04002361 RID: 9057
		private static readonly IntPtr NativeMethodInfoPtr_set_FoodStorage_Private_set_Void_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x04002362 RID: 9058
		private static readonly IntPtr NativeMethodInfoPtr_get_BeverageStorage_Public_get_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x04002363 RID: 9059
		private static readonly IntPtr NativeMethodInfoPtr_set_BeverageStorage_Private_set_Void_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x04002364 RID: 9060
		private static readonly IntPtr NativeMethodInfoPtr_get_FoodStorageBoss_Public_get_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x04002365 RID: 9061
		private static readonly IntPtr NativeMethodInfoPtr_set_FoodStorageBoss_Private_set_Void_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x04002366 RID: 9062
		private static readonly IntPtr NativeMethodInfoPtr_get_BeverageStorageBoss_Public_get_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x04002367 RID: 9063
		private static readonly IntPtr NativeMethodInfoPtr_set_BeverageStorageBoss_Private_set_Void_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x04002368 RID: 9064
		private static readonly IntPtr NativeMethodInfoPtr_get_GuestSpawnA_Public_get_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x04002369 RID: 9065
		private static readonly IntPtr NativeMethodInfoPtr_set_GuestSpawnA_Private_set_Void_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x0400236A RID: 9066
		private static readonly IntPtr NativeMethodInfoPtr_get_GuestSpawnB_Public_get_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x0400236B RID: 9067
		private static readonly IntPtr NativeMethodInfoPtr_set_GuestSpawnB_Private_set_Void_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x0400236C RID: 9068
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerSpawn_Public_get_Vector3Int_0;

		// Token: 0x0400236D RID: 9069
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerSpawn_Private_set_Void_Vector3Int_0;

		// Token: 0x0400236E RID: 9070
		private static readonly IntPtr NativeMethodInfoPtr_get_PasserBorder_Public_get_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x0400236F RID: 9071
		private static readonly IntPtr NativeMethodInfoPtr_set_PasserBorder_Private_set_Void_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x04002370 RID: 9072
		private static readonly IntPtr NativeMethodInfoPtr_get_AIdle_Public_get_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x04002371 RID: 9073
		private static readonly IntPtr NativeMethodInfoPtr_set_AIdle_Private_set_Void_Il2CppStructArray_1_Vector3Int_0;

		// Token: 0x04002372 RID: 9074
		private static readonly IntPtr NativeMethodInfoPtr_get_Rabbit_Public_get_IEnumerable_1_Vector2Int_0;

		// Token: 0x04002373 RID: 9075
		private static readonly IntPtr NativeMethodInfoPtr_get_WaitSeats_Public_get_Il2CppReferenceArray_1_ValueTuple_2_Vector3Int_CharacterRotation_0;

		// Token: 0x04002374 RID: 9076
		private static readonly IntPtr NativeMethodInfoPtr_set_WaitSeats_Private_set_Void_Il2CppReferenceArray_1_ValueTuple_2_Vector3Int_CharacterRotation_0;

		// Token: 0x04002375 RID: 9077
		private static readonly IntPtr NativeMethodInfoPtr_get_GuestTables_Public_get_Dictionary_2_Int32_GuestTableData_0;

		// Token: 0x04002376 RID: 9078
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002377 RID: 9079
		private static readonly IntPtr NativeMethodInfoPtr_GetInteractablesCenter_Public_Vector3_TileType_0;

		// Token: 0x04002378 RID: 9080
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomerDesk_Public_InteractableTile_Int32_byref_Vector3Int_0;

		// Token: 0x04002379 RID: 9081
		private static readonly IntPtr NativeMethodInfoPtr_GetCellCenterWorld_Public_Vector3_Vector3Int_0;

		// Token: 0x0400237A RID: 9082
		private static readonly IntPtr NativeMethodInfoPtr_GetCollider_Public_ScopedTempHashSetHandle_1_Vector2Int_Vector3Int_IReadOnlyList_1_Vector3Int_0;

		// Token: 0x0400237B RID: 9083
		private static readonly IntPtr NativeMethodInfoPtr_GetCollider_Public_ScopedTempHashSetHandle_1_Vector2Int_IReadOnlyList_1_Vector3Int_IReadOnlyList_1_Vector3Int_0;

		// Token: 0x0400237C RID: 9084
		private static readonly IntPtr NativeMethodInfoPtr_AddToColliders_Private_Void_Vector3Int_0;

		// Token: 0x0400237D RID: 9085
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x0400237E RID: 9086
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputAvailability_Private_Void_Boolean_0;

		// Token: 0x0400237F RID: 9087
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurser_Public_Void_Nullable_1_Vector3Int_0;

		// Token: 0x04002380 RID: 9088
		private static readonly IntPtr NativeMethodInfoPtr_ShowPainter_Private_Void_Vector3_Sprite_0;

		// Token: 0x04002381 RID: 9089
		private static readonly IntPtr NativeMethodInfoPtr_HidePainter_Private_Void_Vector3_0;

		// Token: 0x04002382 RID: 9090
		private static readonly IntPtr NativeMethodInfoPtr_RemapPosition_Public_Vector3Int_Vector3Int_byref_TileType_0;

		// Token: 0x04002383 RID: 9091
		private static readonly IntPtr NativeMethodInfoPtr_GetInteractableType_Public_TileType_Vector3Int_byref_InteractableTile_0;

		// Token: 0x04002384 RID: 9092
		private static readonly IntPtr NativeMethodInfoPtr_GetDirection_Private_Static_Vector3Int_Int32_0;

		// Token: 0x04002385 RID: 9093
		private static readonly IntPtr NativeMethodInfoPtr_FindDirection_Public_Static_Int32_Vector3_Vector3_0;

		// Token: 0x04002386 RID: 9094
		private static readonly IntPtr NativeMethodInfoPtr_GetGuestSeats_Private_Il2CppStructArray_1_Vector3Int_Vector3Int_0;

		// Token: 0x04002387 RID: 9095
		private static readonly IntPtr NativeMethodInfoPtr_GetGuestDesk_Private_Vector3Int_Vector3Int_0;

		// Token: 0x04002388 RID: 9096
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002389 RID: 9097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400238A RID: 9098
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector3_IEnumerable_1_Vector3Int_0;

		// Token: 0x020008FC RID: 2300
		[StructLayout(2)]
		public struct CheckPoint
		{
			// Token: 0x0600B663 RID: 46691 RVA: 0x002E4BEC File Offset: 0x002E2DEC
			// Note: this type is marked as 'beforefieldinit'.
			static CheckPoint()
			{
				Il2CppClassPointerStore<TileManager.CheckPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "CheckPoint");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileManager.CheckPoint>.NativeClassPtr);
				TileManager.CheckPoint.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.CheckPoint>.NativeClassPtr, "startPoint");
				TileManager.CheckPoint.NativeFieldInfoPtr_ignoreDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.CheckPoint>.NativeClassPtr, "ignoreDirection");
				TileManager.CheckPoint.NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.CheckPoint>.NativeClassPtr, 100673332);
			}

			// Token: 0x0600B664 RID: 46692 RVA: 0x002E4C54 File Offset: 0x002E2E54
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 123980, RefRangeEnd = 123984, XrefRangeStart = 123980, XrefRangeEnd = 123980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CheckPoint(Vector2Int startPoint, int ignoreDirection)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref startPoint;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreDirection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.CheckPoint.NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B665 RID: 46693 RVA: 0x00062503 File Offset: 0x00060703
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileManager.CheckPoint>.NativeClassPtr, ref this));
			}

			// Token: 0x04007622 RID: 30242
			private static readonly IntPtr NativeFieldInfoPtr_startPoint;

			// Token: 0x04007623 RID: 30243
			private static readonly IntPtr NativeFieldInfoPtr_ignoreDirection;

			// Token: 0x04007624 RID: 30244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2Int_Int32_0;

			// Token: 0x04007625 RID: 30245
			[FieldOffset(0)]
			public Vector2Int startPoint;

			// Token: 0x04007626 RID: 30246
			[FieldOffset(8)]
			public int ignoreDirection;
		}

		// Token: 0x020008FD RID: 2301
		public sealed class GuestTableData : ValueType
		{
			// Token: 0x0600B666 RID: 46694 RVA: 0x002E4C94 File Offset: 0x002E2E94
			// Note: this type is marked as 'beforefieldinit'.
			static GuestTableData()
			{
				Il2CppClassPointerStore<TileManager.GuestTableData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "GuestTableData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileManager.GuestTableData>.NativeClassPtr);
				TileManager.GuestTableData.NativeFieldInfoPtr_tablePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.GuestTableData>.NativeClassPtr, "tablePosition");
				TileManager.GuestTableData.NativeFieldInfoPtr_seatPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.GuestTableData>.NativeClassPtr, "seatPositions");
				TileManager.GuestTableData.NativeFieldInfoPtr_tableDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.GuestTableData>.NativeClassPtr, "tableDisplayer");
				TileManager.GuestTableData.NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Il2CppStructArray_1_Vector3Int_GuestTableDisplayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.GuestTableData>.NativeClassPtr, 100673333);
			}

			// Token: 0x0600B667 RID: 46695 RVA: 0x002E4D10 File Offset: 0x002E2F10
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 123986, RefRangeEnd = 123987, XrefRangeStart = 123984, XrefRangeEnd = 123986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestTableData(Vector3Int tablePosition, Il2CppStructArray<Vector3Int> seatPosition, GuestTableDisplayer tableDisplayer) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileManager.GuestTableData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref tablePosition;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(seatPosition);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tableDisplayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.GuestTableData.NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Il2CppStructArray_1_Vector3Int_GuestTableDisplayer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B668 RID: 46696 RVA: 0x00062515 File Offset: 0x00060715
			public GuestTableData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B669 RID: 46697 RVA: 0x0006251E File Offset: 0x0006071E
			public GuestTableData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileManager.GuestTableData>.NativeClassPtr))
			{
			}

			// Token: 0x17003BD4 RID: 15316
			// (get) Token: 0x0600B66A RID: 46698 RVA: 0x002E4D80 File Offset: 0x002E2F80
			// (set) Token: 0x0600B66B RID: 46699 RVA: 0x00062530 File Offset: 0x00060730
			public unsafe Vector3Int tablePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.GuestTableData.NativeFieldInfoPtr_tablePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.GuestTableData.NativeFieldInfoPtr_tablePosition)) = value;
				}
			}

			// Token: 0x17003BD5 RID: 15317
			// (get) Token: 0x0600B66C RID: 46700 RVA: 0x002E4DA8 File Offset: 0x002E2FA8
			// (set) Token: 0x0600B66D RID: 46701 RVA: 0x0006254B File Offset: 0x0006074B
			public unsafe Il2CppStructArray<Vector3Int> seatPositions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.GuestTableData.NativeFieldInfoPtr_seatPositions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.GuestTableData.NativeFieldInfoPtr_seatPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BD6 RID: 15318
			// (get) Token: 0x0600B66E RID: 46702 RVA: 0x002E4DD8 File Offset: 0x002E2FD8
			// (set) Token: 0x0600B66F RID: 46703 RVA: 0x0006256A File Offset: 0x0006076A
			public unsafe GuestTableDisplayer tableDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.GuestTableData.NativeFieldInfoPtr_tableDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestTableDisplayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.GuestTableData.NativeFieldInfoPtr_tableDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007627 RID: 30247
			private static readonly IntPtr NativeFieldInfoPtr_tablePosition;

			// Token: 0x04007628 RID: 30248
			private static readonly IntPtr NativeFieldInfoPtr_seatPositions;

			// Token: 0x04007629 RID: 30249
			private static readonly IntPtr NativeFieldInfoPtr_tableDisplayer;

			// Token: 0x0400762A RID: 30250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Il2CppStructArray_1_Vector3Int_GuestTableDisplayer_0;
		}

		// Token: 0x020008FE RID: 2302
		[ObfuscatedName("NightScene.Tiles.TileManager+<>c__DisplayClass80_0")]
		public sealed class __c__DisplayClass80_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B670 RID: 46704 RVA: 0x002E4E08 File Offset: 0x002E3008
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass80_0()
			{
				Il2CppClassPointerStore<TileManager.__c__DisplayClass80_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<>c__DisplayClass80_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_0>.NativeClassPtr);
				TileManager.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_0>.NativeClassPtr, "<>4__this");
				TileManager.__c__DisplayClass80_0.NativeFieldInfoPtr_directions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_0>.NativeClassPtr, "directions");
				TileManager.__c__DisplayClass80_0.NativeFieldInfoPtr_needToCheckPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_0>.NativeClassPtr, "needToCheckPoint");
				TileManager.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_0>.NativeClassPtr, 100673334);
				TileManager.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_Void_byref___c__DisplayClass80_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_0>.NativeClassPtr, 100673335);
				TileManager.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_Void_byref___c__DisplayClass80_1_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_0>.NativeClassPtr, 100673336);
				TileManager.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_Il2CppStructArray_1_Vector3Int_Tuple_2_Vector3Int_Vector3Int_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_0>.NativeClassPtr, 100673337);
				TileManager.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_ValueTuple_2_Vector3Int_CharacterRotation_Vector3Int_Vector3Int_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_0>.NativeClassPtr, 100673338);
				TileManager.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_Void_CheckPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_0>.NativeClassPtr, 100673339);
			}

			// Token: 0x0600B671 RID: 46705 RVA: 0x002E4EE8 File Offset: 0x002E30E8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass80_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B672 RID: 46706 RVA: 0x002E4F24 File Offset: 0x002E3124
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 124002, RefRangeEnd = 124004, XrefRangeStart = 123987, XrefRangeEnd = 124002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_byref___c__DisplayClass80_2_0(ref TileManager.__c__DisplayClass80_2 A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_Void_byref___c__DisplayClass80_2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B673 RID: 46707 RVA: 0x002E4F68 File Offset: 0x002E3168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124004, XrefRangeEnd = 124005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_byref___c__DisplayClass80_1_PDM_0(ref TileManager.__c__DisplayClass80_1 A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_Void_byref___c__DisplayClass80_1_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B674 RID: 46708 RVA: 0x002E4FA8 File Offset: 0x002E31A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124005, XrefRangeEnd = 124030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<Vector3Int> Method_Internal_Il2CppStructArray_1_Vector3Int_Tuple_2_Vector3Int_Vector3Int_PDM_0(Tuple<Vector3Int, Vector3Int> pairs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pairs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_Il2CppStructArray_1_Vector3Int_Tuple_2_Vector3Int_Vector3Int_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3Int>>(intPtr3) : null;
			}

			// Token: 0x0600B675 RID: 46709 RVA: 0x002E4FF8 File Offset: 0x002E31F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124030, XrefRangeEnd = 124053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<Vector3Int, DayScenePlayerInputGenerator.CharacterRotation> Method_Internal_ValueTuple_2_Vector3Int_CharacterRotation_Vector3Int_Vector3Int_PDM_0(Vector3Int current, Vector3Int next)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref current;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref next;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TileManager.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_ValueTuple_2_Vector3Int_CharacterRotation_Vector3Int_Vector3Int_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<Vector3Int, DayScenePlayerInputGenerator.CharacterRotation>(pointer);
			}

			// Token: 0x0600B676 RID: 46710 RVA: 0x002E504C File Offset: 0x002E324C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124069, RefRangeEnd = 124070, XrefRangeStart = 124053, XrefRangeEnd = 124069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_CheckPoint_0(TileManager.CheckPoint checkPoint)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref checkPoint;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c__DisplayClass80_0.NativeMethodInfoPtr_Method_Internal_Void_CheckPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B677 RID: 46711 RVA: 0x00062589 File Offset: 0x00060789
			public __c__DisplayClass80_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BD7 RID: 15319
			// (get) Token: 0x0600B678 RID: 46712 RVA: 0x002E508C File Offset: 0x002E328C
			// (set) Token: 0x0600B679 RID: 46713 RVA: 0x00062592 File Offset: 0x00060792
			public unsafe TileManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BD8 RID: 15320
			// (get) Token: 0x0600B67A RID: 46714 RVA: 0x002E50BC File Offset: 0x002E32BC
			// (set) Token: 0x0600B67B RID: 46715 RVA: 0x000625B1 File Offset: 0x000607B1
			public unsafe Il2CppStructArray<Vector2Int> directions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass80_0.NativeFieldInfoPtr_directions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass80_0.NativeFieldInfoPtr_directions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BD9 RID: 15321
			// (get) Token: 0x0600B67C RID: 46716 RVA: 0x002E50EC File Offset: 0x002E32EC
			// (set) Token: 0x0600B67D RID: 46717 RVA: 0x000625D0 File Offset: 0x000607D0
			public unsafe HashSet<TileManager.CheckPoint> needToCheckPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass80_0.NativeFieldInfoPtr_needToCheckPoint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<TileManager.CheckPoint>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass80_0.NativeFieldInfoPtr_needToCheckPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400762B RID: 30251
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400762C RID: 30252
			private static readonly IntPtr NativeFieldInfoPtr_directions;

			// Token: 0x0400762D RID: 30253
			private static readonly IntPtr NativeFieldInfoPtr_needToCheckPoint;

			// Token: 0x0400762E RID: 30254
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400762F RID: 30255
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref___c__DisplayClass80_2_0;

			// Token: 0x04007630 RID: 30256
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_byref___c__DisplayClass80_1_PDM_0;

			// Token: 0x04007631 RID: 30257
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Il2CppStructArray_1_Vector3Int_Tuple_2_Vector3Int_Vector3Int_PDM_0;

			// Token: 0x04007632 RID: 30258
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_ValueTuple_2_Vector3Int_CharacterRotation_Vector3Int_Vector3Int_PDM_0;

			// Token: 0x04007633 RID: 30259
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_CheckPoint_0;
		}

		// Token: 0x020008FF RID: 2303
		[ObfuscatedName("NightScene.Tiles.TileManager+<>c__DisplayClass80_1")]
		[StructLayout(2)]
		public struct __c__DisplayClass80_1
		{
			// Token: 0x0600B67E RID: 46718 RVA: 0x000625EF File Offset: 0x000607EF
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass80_1()
			{
				Il2CppClassPointerStore<TileManager.__c__DisplayClass80_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<>c__DisplayClass80_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_1>.NativeClassPtr);
				TileManager.__c__DisplayClass80_1.NativeFieldInfoPtr_gridPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_1>.NativeClassPtr, "gridPosition");
			}

			// Token: 0x0600B67F RID: 46719 RVA: 0x00062623 File Offset: 0x00060823
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_1>.NativeClassPtr, ref this));
			}

			// Token: 0x04007634 RID: 30260
			private static readonly IntPtr NativeFieldInfoPtr_gridPosition;

			// Token: 0x04007635 RID: 30261
			[FieldOffset(0)]
			public Vector3Int gridPosition;
		}

		// Token: 0x02000900 RID: 2304
		[ObfuscatedName("NightScene.Tiles.TileManager+<>c__DisplayClass80_2")]
		public sealed class __c__DisplayClass80_2 : ValueType
		{
			// Token: 0x0600B680 RID: 46720 RVA: 0x00062635 File Offset: 0x00060835
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass80_2()
			{
				Il2CppClassPointerStore<TileManager.__c__DisplayClass80_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<>c__DisplayClass80_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_2>.NativeClassPtr);
				TileManager.__c__DisplayClass80_2.NativeFieldInfoPtr_targetTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_2>.NativeClassPtr, "targetTile");
			}

			// Token: 0x0600B681 RID: 46721 RVA: 0x00062669 File Offset: 0x00060869
			public __c__DisplayClass80_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B682 RID: 46722 RVA: 0x00062672 File Offset: 0x00060872
			public __c__DisplayClass80_2() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileManager.__c__DisplayClass80_2>.NativeClassPtr))
			{
			}

			// Token: 0x17003BDA RID: 15322
			// (get) Token: 0x0600B683 RID: 46723 RVA: 0x002E511C File Offset: 0x002E331C
			// (set) Token: 0x0600B684 RID: 46724 RVA: 0x00062684 File Offset: 0x00060884
			public unsafe InteractableTile targetTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass80_2.NativeFieldInfoPtr_targetTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass80_2.NativeFieldInfoPtr_targetTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007636 RID: 30262
			private static readonly IntPtr NativeFieldInfoPtr_targetTile;
		}

		// Token: 0x02000901 RID: 2305
		[ObfuscatedName("NightScene.Tiles.TileManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600B685 RID: 46725 RVA: 0x002E514C File Offset: 0x002E334C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr);
				TileManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr, "<>9");
				TileManager.__c.NativeFieldInfoPtr___9__80_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr, "<>9__80_9");
				TileManager.__c.NativeFieldInfoPtr___9__80_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr, "<>9__80_10");
				TileManager.__c.NativeFieldInfoPtr___9__80_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr, "<>9__80_2");
				TileManager.__c.NativeFieldInfoPtr___9__80_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr, "<>9__80_3");
				TileManager.__c.NativeFieldInfoPtr___9__80_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr, "<>9__80_4");
				TileManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr, 100673341);
				TileManager.__c.NativeMethodInfoPtr__Initialize_b__80_9_Internal_Vector3_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr, 100673342);
				TileManager.__c.NativeMethodInfoPtr__Initialize_b__80_10_Internal_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr, 100673343);
				TileManager.__c.NativeMethodInfoPtr__Initialize_b__80_2_Internal_Byte_KeyValuePair_2_Byte_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr, 100673344);
				TileManager.__c.NativeMethodInfoPtr__Initialize_b__80_3_Internal_Vector3Int_KeyValuePair_2_Byte_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr, 100673345);
				TileManager.__c.NativeMethodInfoPtr__Initialize_b__80_4_Internal_IEnumerable_1_Vector3Int_Il2CppStructArray_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr, 100673346);
			}

			// Token: 0x0600B686 RID: 46726 RVA: 0x002E5268 File Offset: 0x002E3468
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B687 RID: 46727 RVA: 0x002E52A4 File Offset: 0x002E34A4
			[CallerCount(0)]
			public unsafe Vector3 _Initialize_b__80_9(Vector3Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c.NativeMethodInfoPtr__Initialize_b__80_9_Internal_Vector3_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B688 RID: 46728 RVA: 0x002E52F0 File Offset: 0x002E34F0
			[CallerCount(0)]
			public unsafe Vector3 _Initialize_b__80_10(Vector3 a, Vector3 b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c.NativeMethodInfoPtr__Initialize_b__80_10_Internal_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B689 RID: 46729 RVA: 0x002E5348 File Offset: 0x002E3548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124070, XrefRangeEnd = 124071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe byte _Initialize_b__80_2(KeyValuePair<byte, Vector3Int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c.NativeMethodInfoPtr__Initialize_b__80_2_Internal_Byte_KeyValuePair_2_Byte_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B68A RID: 46730 RVA: 0x002E539C File Offset: 0x002E359C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124071, XrefRangeEnd = 124072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3Int _Initialize_b__80_3(KeyValuePair<byte, Vector3Int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c.NativeMethodInfoPtr__Initialize_b__80_3_Internal_Vector3Int_KeyValuePair_2_Byte_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B68B RID: 46731 RVA: 0x002E53F0 File Offset: 0x002E35F0
			[CallerCount(0)]
			public unsafe IEnumerable<Vector3Int> _Initialize_b__80_4(Il2CppStructArray<Vector3Int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c.NativeMethodInfoPtr__Initialize_b__80_4_Internal_IEnumerable_1_Vector3Int_Il2CppStructArray_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3Int>>(intPtr3) : null;
			}

			// Token: 0x0600B68C RID: 46732 RVA: 0x000626A3 File Offset: 0x000608A3
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BDB RID: 15323
			// (get) Token: 0x0600B68D RID: 46733 RVA: 0x002E5440 File Offset: 0x002E3640
			// (set) Token: 0x0600B68E RID: 46734 RVA: 0x000626AC File Offset: 0x000608AC
			public unsafe static TileManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TileManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TileManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BDC RID: 15324
			// (get) Token: 0x0600B68F RID: 46735 RVA: 0x002E5468 File Offset: 0x002E3668
			// (set) Token: 0x0600B690 RID: 46736 RVA: 0x000626BE File Offset: 0x000608BE
			public unsafe static Func<Vector3Int, Vector3> __9__80_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TileManager.__c.NativeFieldInfoPtr___9__80_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Int, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TileManager.__c.NativeFieldInfoPtr___9__80_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BDD RID: 15325
			// (get) Token: 0x0600B691 RID: 46737 RVA: 0x002E5490 File Offset: 0x002E3690
			// (set) Token: 0x0600B692 RID: 46738 RVA: 0x000626D0 File Offset: 0x000608D0
			public unsafe static Func<Vector3, Vector3, Vector3> __9__80_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TileManager.__c.NativeFieldInfoPtr___9__80_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, Vector3, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TileManager.__c.NativeFieldInfoPtr___9__80_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BDE RID: 15326
			// (get) Token: 0x0600B693 RID: 46739 RVA: 0x002E54B8 File Offset: 0x002E36B8
			// (set) Token: 0x0600B694 RID: 46740 RVA: 0x000626E2 File Offset: 0x000608E2
			public unsafe static Func<KeyValuePair<byte, Vector3Int>, byte> __9__80_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TileManager.__c.NativeFieldInfoPtr___9__80_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<byte, Vector3Int>, byte>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TileManager.__c.NativeFieldInfoPtr___9__80_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BDF RID: 15327
			// (get) Token: 0x0600B695 RID: 46741 RVA: 0x002E54E0 File Offset: 0x002E36E0
			// (set) Token: 0x0600B696 RID: 46742 RVA: 0x000626F4 File Offset: 0x000608F4
			public unsafe static Func<KeyValuePair<byte, Vector3Int>, Vector3Int> __9__80_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TileManager.__c.NativeFieldInfoPtr___9__80_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<byte, Vector3Int>, Vector3Int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TileManager.__c.NativeFieldInfoPtr___9__80_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BE0 RID: 15328
			// (get) Token: 0x0600B697 RID: 46743 RVA: 0x002E5508 File Offset: 0x002E3708
			// (set) Token: 0x0600B698 RID: 46744 RVA: 0x00062706 File Offset: 0x00060906
			public unsafe static Func<Il2CppStructArray<Vector3Int>, IEnumerable<Vector3Int>> __9__80_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TileManager.__c.NativeFieldInfoPtr___9__80_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStructArray<Vector3Int>, IEnumerable<Vector3Int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TileManager.__c.NativeFieldInfoPtr___9__80_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007637 RID: 30263
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007638 RID: 30264
			private static readonly IntPtr NativeFieldInfoPtr___9__80_9;

			// Token: 0x04007639 RID: 30265
			private static readonly IntPtr NativeFieldInfoPtr___9__80_10;

			// Token: 0x0400763A RID: 30266
			private static readonly IntPtr NativeFieldInfoPtr___9__80_2;

			// Token: 0x0400763B RID: 30267
			private static readonly IntPtr NativeFieldInfoPtr___9__80_3;

			// Token: 0x0400763C RID: 30268
			private static readonly IntPtr NativeFieldInfoPtr___9__80_4;

			// Token: 0x0400763D RID: 30269
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400763E RID: 30270
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__80_9_Internal_Vector3_Vector3Int_0;

			// Token: 0x0400763F RID: 30271
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__80_10_Internal_Vector3_Vector3_Vector3_0;

			// Token: 0x04007640 RID: 30272
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__80_2_Internal_Byte_KeyValuePair_2_Byte_Vector3Int_0;

			// Token: 0x04007641 RID: 30273
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__80_3_Internal_Vector3Int_KeyValuePair_2_Byte_Vector3Int_0;

			// Token: 0x04007642 RID: 30274
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__80_4_Internal_IEnumerable_1_Vector3Int_Il2CppStructArray_1_Vector3Int_0;
		}

		// Token: 0x02000902 RID: 2306
		[ObfuscatedName("NightScene.Tiles.TileManager+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B699 RID: 46745 RVA: 0x002E5530 File Offset: 0x002E3730
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<TileManager.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileManager.__c__DisplayClass83_0>.NativeClassPtr);
				TileManager.__c__DisplayClass83_0.NativeFieldInfoPtr_remaped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c__DisplayClass83_0>.NativeClassPtr, "remaped");
				TileManager.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c__DisplayClass83_0>.NativeClassPtr, 100673347);
				TileManager.__c__DisplayClass83_0.NativeMethodInfoPtr__UpdateCurser_b__1_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c__DisplayClass83_0>.NativeClassPtr, 100673348);
			}

			// Token: 0x0600B69A RID: 46746 RVA: 0x002E5598 File Offset: 0x002E3798
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileManager.__c__DisplayClass83_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B69B RID: 46747 RVA: 0x002E55D4 File Offset: 0x002E37D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124072, XrefRangeEnd = 124073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateCurser_b__1(KeyValuePair<int, TileManager.GuestTableData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c__DisplayClass83_0.NativeMethodInfoPtr__UpdateCurser_b__1_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B69C RID: 46748 RVA: 0x00062718 File Offset: 0x00060918
			public __c__DisplayClass83_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BE1 RID: 15329
			// (get) Token: 0x0600B69D RID: 46749 RVA: 0x002E5628 File Offset: 0x002E3828
			// (set) Token: 0x0600B69E RID: 46750 RVA: 0x00062721 File Offset: 0x00060921
			public unsafe Vector3Int remaped
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass83_0.NativeFieldInfoPtr_remaped);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass83_0.NativeFieldInfoPtr_remaped)) = value;
				}
			}

			// Token: 0x04007643 RID: 30275
			private static readonly IntPtr NativeFieldInfoPtr_remaped;

			// Token: 0x04007644 RID: 30276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007645 RID: 30277
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurser_b__1_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0;
		}

		// Token: 0x02000903 RID: 2307
		[ObfuscatedName("NightScene.Tiles.TileManager+<>c__DisplayClass83_1")]
		public sealed class __c__DisplayClass83_1 : Il2CppSystem.Object
		{
			// Token: 0x0600B69F RID: 46751 RVA: 0x002E5650 File Offset: 0x002E3850
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_1()
			{
				Il2CppClassPointerStore<TileManager.__c__DisplayClass83_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<>c__DisplayClass83_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileManager.__c__DisplayClass83_1>.NativeClassPtr);
				TileManager.__c__DisplayClass83_1.NativeFieldInfoPtr_tileSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c__DisplayClass83_1>.NativeClassPtr, "tileSprite");
				TileManager.__c__DisplayClass83_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c__DisplayClass83_1>.NativeClassPtr, 100673349);
				TileManager.__c__DisplayClass83_1.NativeMethodInfoPtr__UpdateCurser_b__0_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c__DisplayClass83_1>.NativeClassPtr, 100673350);
			}

			// Token: 0x0600B6A0 RID: 46752 RVA: 0x002E56B8 File Offset: 0x002E38B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileManager.__c__DisplayClass83_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c__DisplayClass83_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6A1 RID: 46753 RVA: 0x002E56F4 File Offset: 0x002E38F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCurser_b__0(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c__DisplayClass83_1.NativeMethodInfoPtr__UpdateCurser_b__0_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6A2 RID: 46754 RVA: 0x0006273C File Offset: 0x0006093C
			public __c__DisplayClass83_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BE2 RID: 15330
			// (get) Token: 0x0600B6A3 RID: 46755 RVA: 0x002E5738 File Offset: 0x002E3938
			// (set) Token: 0x0600B6A4 RID: 46756 RVA: 0x00062745 File Offset: 0x00060945
			public unsafe Sprite tileSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass83_1.NativeFieldInfoPtr_tileSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass83_1.NativeFieldInfoPtr_tileSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007646 RID: 30278
			private static readonly IntPtr NativeFieldInfoPtr_tileSprite;

			// Token: 0x04007647 RID: 30279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007648 RID: 30280
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurser_b__0_Internal_Void_SpriteRenderer_0;
		}

		// Token: 0x02000904 RID: 2308
		[ObfuscatedName("NightScene.Tiles.TileManager+<>c__DisplayClass85_0")]
		public sealed class __c__DisplayClass85_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B6A5 RID: 46757 RVA: 0x002E5768 File Offset: 0x002E3968
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass85_0()
			{
				Il2CppClassPointerStore<TileManager.__c__DisplayClass85_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileManager>.NativeClassPtr, "<>c__DisplayClass85_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileManager.__c__DisplayClass85_0>.NativeClassPtr);
				TileManager.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c__DisplayClass85_0>.NativeClassPtr, "<>4__this");
				TileManager.__c__DisplayClass85_0.NativeFieldInfoPtr_painter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileManager.__c__DisplayClass85_0>.NativeClassPtr, "painter");
				TileManager.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c__DisplayClass85_0>.NativeClassPtr, 100673351);
				TileManager.__c__DisplayClass85_0.NativeMethodInfoPtr__HidePainter_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileManager.__c__DisplayClass85_0>.NativeClassPtr, 100673352);
			}

			// Token: 0x0600B6A6 RID: 46758 RVA: 0x002E57E4 File Offset: 0x002E39E4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass85_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileManager.__c__DisplayClass85_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6A7 RID: 46759 RVA: 0x002E5820 File Offset: 0x002E3A20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124073, XrefRangeEnd = 124077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _HidePainter_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileManager.__c__DisplayClass85_0.NativeMethodInfoPtr__HidePainter_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6A8 RID: 46760 RVA: 0x00062764 File Offset: 0x00060964
			public __c__DisplayClass85_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BE3 RID: 15331
			// (get) Token: 0x0600B6A9 RID: 46761 RVA: 0x002E5854 File Offset: 0x002E3A54
			// (set) Token: 0x0600B6AA RID: 46762 RVA: 0x0006276D File Offset: 0x0006096D
			public unsafe TileManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass85_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BE4 RID: 15332
			// (get) Token: 0x0600B6AB RID: 46763 RVA: 0x002E5884 File Offset: 0x002E3A84
			// (set) Token: 0x0600B6AC RID: 46764 RVA: 0x0006278C File Offset: 0x0006098C
			public unsafe StencilPainterController painter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass85_0.NativeFieldInfoPtr_painter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StencilPainterController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileManager.__c__DisplayClass85_0.NativeFieldInfoPtr_painter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007649 RID: 30281
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400764A RID: 30282
			private static readonly IntPtr NativeFieldInfoPtr_painter;

			// Token: 0x0400764B RID: 30283
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400764C RID: 30284
			private static readonly IntPtr NativeMethodInfoPtr__HidePainter_b__0_Internal_Void_0;
		}
	}
}
