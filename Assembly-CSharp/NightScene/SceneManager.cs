using System;
using Cinemachine;
using Common.CharacterUtility;
using DEYU.Singletons;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.Input;
using NightScene.Tiles;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace NightScene
{
	// Token: 0x0200019D RID: 413
	public class SceneManager : MonoSingleton<SceneManager>
	{
		// Token: 0x06002C8E RID: 11406 RVA: 0x00132544 File Offset: 0x00130744
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManager()
		{
			Il2CppClassPointerStore<SceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene", "SceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager>.NativeClassPtr);
			SceneManager.NativeFieldInfoPtr_NIGHT_WHOLE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "NIGHT_WHOLE_TIME");
			SceneManager.NativeFieldInfoPtr_TEWI_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "TEWI_ID");
			SceneManager.NativeFieldInfoPtr_TEWI_HOME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "TEWI_HOME");
			SceneManager.NativeFieldInfoPtr_TEWI_SPAWN_PRD_LABEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "TEWI_SPAWN_PRD_LABEL");
			SceneManager.NativeFieldInfoPtr_AYA_FAMOUS_IZAKAYA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "AYA_FAMOUS_IZAKAYA");
			SceneManager.NativeFieldInfoPtr_onIzakayaOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "onIzakayaOpen");
			SceneManager.NativeFieldInfoPtr_onIzakayaClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "onIzakayaClose");
			SceneManager.NativeFieldInfoPtr_virtualCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "virtualCamera");
			SceneManager.NativeFieldInfoPtr_canOpenTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "canOpenTrash");
			SceneManager.NativeFieldInfoPtr_bossBattleData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "bossBattleData");
			SceneManager.NativeFieldInfoPtr_ghostCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "ghostCharacter");
			SceneManager.NativeFieldInfoPtr_ghostCharacterEyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "ghostCharacterEyes");
			SceneManager.NativeFieldInfoPtr_OnEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "OnEnd");
			SceneManager.NativeFieldInfoPtr_tewiSpawnProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "tewiSpawnProbability");
			SceneManager.NativeFieldInfoPtr_famousIzakayaAddSpawnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "famousIzakayaAddSpawnRate");
			SceneManager.NativeFieldInfoPtr_famousIzakayaAddExtraFundRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "famousIzakayaAddExtraFundRate");
			SceneManager.NativeFieldInfoPtr_releaseQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "releaseQueue");
			SceneManager.NativeFieldInfoPtr_m_LoadedBossData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_LoadedBossData");
			SceneManager.NativeFieldInfoPtr__MustOpenTileType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<MustOpenTileType>k__BackingField");
			SceneManager.NativeFieldInfoPtr__MustOpenCookerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<MustOpenCookerType>k__BackingField");
			SceneManager.NativeFieldInfoPtr__CookerMustIncludeIngredientId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<CookerMustIncludeIngredientId>k__BackingField");
			SceneManager.NativeFieldInfoPtr__CookerMustSelecRecipetId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<CookerMustSelecRecipetId>k__BackingField");
			SceneManager.NativeFieldInfoPtr__BeverageStorageMustIncludeTagId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<BeverageStorageMustIncludeTagId>k__BackingField");
			SceneManager.NativeFieldInfoPtr__MustOpenGuestDeskCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<MustOpenGuestDeskCode>k__BackingField");
			SceneManager.NativeFieldInfoPtr__PlayerCharacter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<PlayerCharacter>k__BackingField");
			SceneManager.NativeFieldInfoPtr__IfTewiWillComeTonight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<IfTewiWillComeTonight>k__BackingField");
			SceneManager.NativeFieldInfoPtr__AdditiveBuff_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<AdditiveBuff>k__BackingField");
			SceneManager.NativeFieldInfoPtr_OnNightSceneDisposeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "OnNightSceneDisposeCallback");
			SceneManager.NativeMethodInfoPtr_get_MustOpenTileType_Public_get_Nullable_1_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671095);
			SceneManager.NativeMethodInfoPtr_set_MustOpenTileType_Public_set_Void_Nullable_1_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671096);
			SceneManager.NativeMethodInfoPtr_get_MustOpenCookerType_Public_get_Nullable_1_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671097);
			SceneManager.NativeMethodInfoPtr_set_MustOpenCookerType_Public_set_Void_Nullable_1_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671098);
			SceneManager.NativeMethodInfoPtr_get_CookerMustIncludeIngredientId_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671099);
			SceneManager.NativeMethodInfoPtr_set_CookerMustIncludeIngredientId_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671100);
			SceneManager.NativeMethodInfoPtr_get_CookerMustSelecRecipetId_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671101);
			SceneManager.NativeMethodInfoPtr_set_CookerMustSelecRecipetId_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671102);
			SceneManager.NativeMethodInfoPtr_get_BeverageStorageMustIncludeTagId_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671103);
			SceneManager.NativeMethodInfoPtr_set_BeverageStorageMustIncludeTagId_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671104);
			SceneManager.NativeMethodInfoPtr_get_MustOpenGuestDeskCode_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671105);
			SceneManager.NativeMethodInfoPtr_set_MustOpenGuestDeskCode_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671106);
			SceneManager.NativeMethodInfoPtr_get_PlayerCharacter_Public_get_WorkScenePlayerInputGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671107);
			SceneManager.NativeMethodInfoPtr_set_PlayerCharacter_Private_set_Void_WorkScenePlayerInputGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671108);
			SceneManager.NativeMethodInfoPtr_get_isCharacterStuned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671109);
			SceneManager.NativeMethodInfoPtr_get_IfTewiWillComeTonight_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671110);
			SceneManager.NativeMethodInfoPtr_set_IfTewiWillComeTonight_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671111);
			SceneManager.NativeMethodInfoPtr_get_AdditiveBuff_Public_Static_get_Queue_1_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671112);
			SceneManager.NativeMethodInfoPtr_add_OnNightSceneDisposeCallback_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671113);
			SceneManager.NativeMethodInfoPtr_remove_OnNightSceneDisposeCallback_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671114);
			SceneManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671115);
			SceneManager.NativeMethodInfoPtr_CheckIfBuffHasAdded_Public_Static_Boolean_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671116);
			SceneManager.NativeMethodInfoPtr_STDOnEventFinishCallback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671117);
			SceneManager.NativeMethodInfoPtr_GetPostProcessCharacterDataCallback_Private_Action_1_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671118);
			SceneManager.NativeMethodInfoPtr_InitializeAsGeneralWorkScene_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671119);
			SceneManager.NativeMethodInfoPtr_InitializeAsChallengeScene_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671120);
			SceneManager.NativeMethodInfoPtr_OnRequestedBossDataLoadFinishCallback_Private_Void_Action_BossData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671121);
			SceneManager.NativeMethodInfoPtr_GhostModeProcessCharacterCallback_Private_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671122);
			SceneManager.NativeMethodInfoPtr_InitializeAsKyoukoTutorialScene_Private_Void_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671123);
			SceneManager.NativeMethodInfoPtr_Dispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671124);
			SceneManager.NativeMethodInfoPtr_SetPlayerCharacterToDefaultSpawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671125);
			SceneManager.NativeMethodInfoPtr_ResetNightSetting_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671126);
			SceneManager.NativeMethodInfoPtr_HandleCharacterArrivalCallback_Public_Void_Vector3Int_Vector3Int_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671127);
			SceneManager.NativeMethodInfoPtr_ToResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671128);
			SceneManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671129);
			SceneManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671130);
			SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671131);
			SceneManager.NativeMethodInfoPtr_Method_Internal_Static_Void_byref___c__DisplayClass66_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671133);
			SceneManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100671134);
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x00132AB0 File Offset: 0x00130CB0
		// (set) Token: 0x06002C90 RID: 11408 RVA: 0x00132AE8 File Offset: 0x00130CE8
		public unsafe Nullable<InteractableTile.TileType> MustOpenTileType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_MustOpenTileType_Public_get_Nullable_1_TileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<InteractableTile.TileType>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_MustOpenTileType_Public_set_Void_Nullable_1_TileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06002C91 RID: 11409 RVA: 0x00132B30 File Offset: 0x00130D30
		// (set) Token: 0x06002C92 RID: 11410 RVA: 0x00132B68 File Offset: 0x00130D68
		public unsafe Nullable<Cooker.CookerType> MustOpenCookerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_MustOpenCookerType_Public_get_Nullable_1_CookerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<Cooker.CookerType>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_MustOpenCookerType_Public_set_Void_Nullable_1_CookerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x00132BB0 File Offset: 0x00130DB0
		// (set) Token: 0x06002C94 RID: 11412 RVA: 0x00132BE8 File Offset: 0x00130DE8
		public unsafe Nullable<int> CookerMustIncludeIngredientId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_CookerMustIncludeIngredientId_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<int>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_CookerMustIncludeIngredientId_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x00132C30 File Offset: 0x00130E30
		// (set) Token: 0x06002C96 RID: 11414 RVA: 0x00132C68 File Offset: 0x00130E68
		public unsafe Nullable<int> CookerMustSelecRecipetId
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_CookerMustSelecRecipetId_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<int>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_CookerMustSelecRecipetId_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x00132CB0 File Offset: 0x00130EB0
		// (set) Token: 0x06002C98 RID: 11416 RVA: 0x00132CE8 File Offset: 0x00130EE8
		public unsafe Nullable<int> BeverageStorageMustIncludeTagId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_BeverageStorageMustIncludeTagId_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<int>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_BeverageStorageMustIncludeTagId_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06002C99 RID: 11417 RVA: 0x00132D30 File Offset: 0x00130F30
		// (set) Token: 0x06002C9A RID: 11418 RVA: 0x00132D68 File Offset: 0x00130F68
		public unsafe Nullable<int> MustOpenGuestDeskCode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22275, RefRangeEnd = 22276, XrefRangeStart = 22275, XrefRangeEnd = 22276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_MustOpenGuestDeskCode_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<int>(pointer);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_MustOpenGuestDeskCode_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06002C9B RID: 11419 RVA: 0x00132DB0 File Offset: 0x00130FB0
		// (set) Token: 0x06002C9C RID: 11420 RVA: 0x00132DF0 File Offset: 0x00130FF0
		public unsafe WorkScenePlayerInputGenerator PlayerCharacter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_PlayerCharacter_Public_get_WorkScenePlayerInputGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorkScenePlayerInputGenerator>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_PlayerCharacter_Private_set_Void_WorkScenePlayerInputGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06002C9D RID: 11421 RVA: 0x00132E34 File Offset: 0x00131034
		public unsafe bool isCharacterStuned
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 99889, RefRangeEnd = 99894, XrefRangeStart = 99887, XrefRangeEnd = 99889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_isCharacterStuned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06002C9E RID: 11422 RVA: 0x00132E70 File Offset: 0x00131070
		// (set) Token: 0x06002C9F RID: 11423 RVA: 0x00132EA0 File Offset: 0x001310A0
		public unsafe static bool IfTewiWillComeTonight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99894, XrefRangeEnd = 99898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_IfTewiWillComeTonight_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99898, XrefRangeEnd = 99902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_set_IfTewiWillComeTonight_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06002CA0 RID: 11424 RVA: 0x00132ED4 File Offset: 0x001310D4
		public unsafe static Queue<Action<Action>> AdditiveBuff
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99902, XrefRangeEnd = 99906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_AdditiveBuff_Public_Static_get_Queue_1_Action_1_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Queue<Action<Action>>>(intPtr3) : null;
			}
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x00132F08 File Offset: 0x00131108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99917, RefRangeEnd = 99918, XrefRangeStart = 99906, XrefRangeEnd = 99917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnNightSceneDisposeCallback(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_add_OnNightSceneDisposeCallback_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x00132F40 File Offset: 0x00131140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99918, XrefRangeEnd = 99929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnNightSceneDisposeCallback(Action value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_remove_OnNightSceneDisposeCallback_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x00132F78 File Offset: 0x00131178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99929, XrefRangeEnd = 100216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x00132FAC File Offset: 0x001311AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100227, RefRangeEnd = 100229, XrefRangeStart = 100216, XrefRangeEnd = 100227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckIfBuffHasAdded(Action<Action> buff)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buff);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_CheckIfBuffHasAdded_Public_Static_Boolean_Action_1_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x00132FF0 File Offset: 0x001311F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100229, XrefRangeEnd = 100241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void STDOnEventFinishCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_STDOnEventFinishCallback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x00133024 File Offset: 0x00131224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100241, XrefRangeEnd = 100251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action<AStarInputGeneratorComponent> GetPostProcessCharacterDataCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetPostProcessCharacterDataCallback_Private_Action_1_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<AStarInputGeneratorComponent>>(intPtr3) : null;
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x00133064 File Offset: 0x00131264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100334, RefRangeEnd = 100335, XrefRangeStart = 100251, XrefRangeEnd = 100334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeAsGeneralWorkScene(Action onEventFinishCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onEventFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_InitializeAsGeneralWorkScene_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x001330A8 File Offset: 0x001312A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100364, RefRangeEnd = 100365, XrefRangeStart = 100335, XrefRangeEnd = 100364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeAsChallengeScene(Action onEventFinishCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onEventFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_InitializeAsChallengeScene_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x001330EC File Offset: 0x001312EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100404, RefRangeEnd = 100405, XrefRangeStart = 100365, XrefRangeEnd = 100404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRequestedBossDataLoadFinishCallback(Action onEventFinishCallback, BossData loadedBossData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onEventFinishCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadedBossData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_OnRequestedBossDataLoadFinishCallback_Private_Void_Action_BossData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x00133140 File Offset: 0x00131340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100405, XrefRangeEnd = 100409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GhostModeProcessCharacterCallback(AStarInputGeneratorComponent component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GhostModeProcessCharacterCallback_Private_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x00133184 File Offset: 0x00131384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100441, RefRangeEnd = 100442, XrefRangeStart = 100409, XrefRangeEnd = 100441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeAsKyoukoTutorialScene(Action onEventFinishCallback, Action onTimelineFinishCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onEventFinishCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onTimelineFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_InitializeAsKyoukoTutorialScene_Private_Void_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x001331D8 File Offset: 0x001313D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100442, XrefRangeEnd = 100497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Dispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x0013320C File Offset: 0x0013140C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100499, RefRangeEnd = 100500, XrefRangeStart = 100497, XrefRangeEnd = 100499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerCharacterToDefaultSpawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_SetPlayerCharacterToDefaultSpawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x00133240 File Offset: 0x00131440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100521, RefRangeEnd = 100523, XrefRangeStart = 100500, XrefRangeEnd = 100521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetNightSetting()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_ResetNightSetting_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x00133268 File Offset: 0x00131468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100523, XrefRangeEnd = 100596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleCharacterArrivalCallback(Vector3Int targetPos, Vector3Int characterPosition, out int rotateDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotateDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_HandleCharacterArrivalCallback_Public_Void_Vector3Int_Vector3Int_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x001332C4 File Offset: 0x001314C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100623, RefRangeEnd = 100624, XrefRangeStart = 100596, XrefRangeEnd = 100623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_ToResult_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x001332F8 File Offset: 0x001314F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100624, XrefRangeEnd = 100627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x00133334 File Offset: 0x00131534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100627, XrefRangeEnd = 100654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x00133370 File Offset: 0x00131570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100654, XrefRangeEnd = 100665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x001333AC File Offset: 0x001315AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100665, XrefRangeEnd = 100686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_byref___c__DisplayClass66_0_PDM_0(ref SceneManager.__c__DisplayClass66_0 A_0)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Method_Internal_Static_Void_byref___c__DisplayClass66_0_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x001333E4 File Offset: 0x001315E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100686, XrefRangeEnd = 100706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x00019E3F File Offset: 0x0001803F
		public SceneManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x0013340C File Offset: 0x0013160C
		// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x00019E48 File Offset: 0x00018048
		public unsafe static int NIGHT_WHOLE_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_NIGHT_WHOLE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_NIGHT_WHOLE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x00133428 File Offset: 0x00131628
		// (set) Token: 0x06002CBA RID: 11450 RVA: 0x00019E56 File Offset: 0x00018056
		public unsafe static int TEWI_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_TEWI_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_TEWI_ID, (void*)(&value));
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x00133444 File Offset: 0x00131644
		// (set) Token: 0x06002CBC RID: 11452 RVA: 0x00019E64 File Offset: 0x00018064
		public unsafe static string TEWI_HOME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_TEWI_HOME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_TEWI_HOME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06002CBD RID: 11453 RVA: 0x00133464 File Offset: 0x00131664
		// (set) Token: 0x06002CBE RID: 11454 RVA: 0x00019E76 File Offset: 0x00018076
		public unsafe static string TEWI_SPAWN_PRD_LABEL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_TEWI_SPAWN_PRD_LABEL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_TEWI_SPAWN_PRD_LABEL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x00133484 File Offset: 0x00131684
		// (set) Token: 0x06002CC0 RID: 11456 RVA: 0x00019E88 File Offset: 0x00018088
		public unsafe static string AYA_FAMOUS_IZAKAYA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_AYA_FAMOUS_IZAKAYA, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_AYA_FAMOUS_IZAKAYA, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x001334A4 File Offset: 0x001316A4
		// (set) Token: 0x06002CC2 RID: 11458 RVA: 0x00019E9A File Offset: 0x0001809A
		public unsafe AudioClip onIzakayaOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_onIzakayaOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_onIzakayaOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x001334D4 File Offset: 0x001316D4
		// (set) Token: 0x06002CC4 RID: 11460 RVA: 0x00019EB9 File Offset: 0x000180B9
		public unsafe AudioClip onIzakayaClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_onIzakayaClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_onIzakayaClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x00133504 File Offset: 0x00131704
		// (set) Token: 0x06002CC6 RID: 11462 RVA: 0x00019ED8 File Offset: 0x000180D8
		public unsafe CinemachineVirtualCamera virtualCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_virtualCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CinemachineVirtualCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_virtualCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x00133534 File Offset: 0x00131734
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x00019EF7 File Offset: 0x000180F7
		public unsafe bool canOpenTrash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_canOpenTrash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_canOpenTrash)) = value;
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x0013355C File Offset: 0x0013175C
		// (set) Token: 0x06002CCA RID: 11466 RVA: 0x00019F12 File Offset: 0x00018112
		public unsafe Il2CppReferenceArray<SceneManager.BossBattleData> bossBattleData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_bossBattleData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SceneManager.BossBattleData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_bossBattleData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x0013358C File Offset: 0x0013178C
		// (set) Token: 0x06002CCC RID: 11468 RVA: 0x00019F31 File Offset: 0x00018131
		public unsafe Material ghostCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_ghostCharacter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_ghostCharacter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06002CCD RID: 11469 RVA: 0x001335BC File Offset: 0x001317BC
		// (set) Token: 0x06002CCE RID: 11470 RVA: 0x00019F50 File Offset: 0x00018150
		public unsafe Material ghostCharacterEyes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_ghostCharacterEyes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_ghostCharacterEyes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06002CCF RID: 11471 RVA: 0x001335EC File Offset: 0x001317EC
		// (set) Token: 0x06002CD0 RID: 11472 RVA: 0x00019F6F File Offset: 0x0001816F
		public unsafe Action OnEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_OnEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_OnEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x0013361C File Offset: 0x0013181C
		// (set) Token: 0x06002CD2 RID: 11474 RVA: 0x00019F8E File Offset: 0x0001818E
		public unsafe float tewiSpawnProbability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_tewiSpawnProbability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_tewiSpawnProbability)) = value;
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x00133644 File Offset: 0x00131844
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x00019FA9 File Offset: 0x000181A9
		public unsafe float famousIzakayaAddSpawnRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_famousIzakayaAddSpawnRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_famousIzakayaAddSpawnRate)) = value;
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x0013366C File Offset: 0x0013186C
		// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x00019FC4 File Offset: 0x000181C4
		public unsafe float famousIzakayaAddExtraFundRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_famousIzakayaAddExtraFundRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_famousIzakayaAddExtraFundRate)) = value;
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06002CD7 RID: 11479 RVA: 0x00133694 File Offset: 0x00131894
		// (set) Token: 0x06002CD8 RID: 11480 RVA: 0x00019FDF File Offset: 0x000181DF
		public unsafe Queue<AssetReference> releaseQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_releaseQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<AssetReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_releaseQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x001336C4 File Offset: 0x001318C4
		// (set) Token: 0x06002CDA RID: 11482 RVA: 0x00019FFE File Offset: 0x000181FE
		public unsafe BossData m_LoadedBossData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_LoadedBossData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BossData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_LoadedBossData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x001336F4 File Offset: 0x001318F4
		// (set) Token: 0x06002CDC RID: 11484 RVA: 0x0001A01D File Offset: 0x0001821D
		public Nullable<InteractableTile.TileType> _MustOpenTileType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__MustOpenTileType_k__BackingField);
				return new Nullable<InteractableTile.TileType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<InteractableTile.TileType>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__MustOpenTileType_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<InteractableTile.TileType>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06002CDD RID: 11485 RVA: 0x00133724 File Offset: 0x00131924
		// (set) Token: 0x06002CDE RID: 11486 RVA: 0x0001A04B File Offset: 0x0001824B
		public Nullable<Cooker.CookerType> _MustOpenCookerType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__MustOpenCookerType_k__BackingField);
				return new Nullable<Cooker.CookerType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Cooker.CookerType>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__MustOpenCookerType_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Cooker.CookerType>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x00133754 File Offset: 0x00131954
		// (set) Token: 0x06002CE0 RID: 11488 RVA: 0x0001A079 File Offset: 0x00018279
		public Nullable<int> _CookerMustIncludeIngredientId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__CookerMustIncludeIngredientId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__CookerMustIncludeIngredientId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x00133784 File Offset: 0x00131984
		// (set) Token: 0x06002CE2 RID: 11490 RVA: 0x0001A0A7 File Offset: 0x000182A7
		public Nullable<int> _CookerMustSelecRecipetId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__CookerMustSelecRecipetId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__CookerMustSelecRecipetId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x001337B4 File Offset: 0x001319B4
		// (set) Token: 0x06002CE4 RID: 11492 RVA: 0x0001A0D5 File Offset: 0x000182D5
		public Nullable<int> _BeverageStorageMustIncludeTagId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__BeverageStorageMustIncludeTagId_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__BeverageStorageMustIncludeTagId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x001337E4 File Offset: 0x001319E4
		// (set) Token: 0x06002CE6 RID: 11494 RVA: 0x0001A103 File Offset: 0x00018303
		public Nullable<int> _MustOpenGuestDeskCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__MustOpenGuestDeskCode_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__MustOpenGuestDeskCode_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x00133814 File Offset: 0x00131A14
		// (set) Token: 0x06002CE8 RID: 11496 RVA: 0x0001A131 File Offset: 0x00018331
		public unsafe WorkScenePlayerInputGenerator _PlayerCharacter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__PlayerCharacter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkScenePlayerInputGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr__PlayerCharacter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x00133844 File Offset: 0x00131A44
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x0001A150 File Offset: 0x00018350
		public unsafe static bool _IfTewiWillComeTonight_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr__IfTewiWillComeTonight_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr__IfTewiWillComeTonight_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x00133860 File Offset: 0x00131A60
		// (set) Token: 0x06002CEC RID: 11500 RVA: 0x0001A15E File Offset: 0x0001835E
		public unsafe static Queue<Action<Action>> _AdditiveBuff_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr__AdditiveBuff_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Action<Action>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr__AdditiveBuff_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06002CED RID: 11501 RVA: 0x00133888 File Offset: 0x00131A88
		// (set) Token: 0x06002CEE RID: 11502 RVA: 0x0001A170 File Offset: 0x00018370
		public unsafe static Action OnNightSceneDisposeCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_OnNightSceneDisposeCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_OnNightSceneDisposeCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeFieldInfoPtr_NIGHT_WHOLE_TIME;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeFieldInfoPtr_TEWI_ID;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeFieldInfoPtr_TEWI_HOME;

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeFieldInfoPtr_TEWI_SPAWN_PRD_LABEL;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeFieldInfoPtr_AYA_FAMOUS_IZAKAYA;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeFieldInfoPtr_onIzakayaOpen;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeFieldInfoPtr_onIzakayaClose;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeFieldInfoPtr_virtualCamera;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeFieldInfoPtr_canOpenTrash;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeFieldInfoPtr_bossBattleData;

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeFieldInfoPtr_ghostCharacter;

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeFieldInfoPtr_ghostCharacterEyes;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeFieldInfoPtr_OnEnd;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeFieldInfoPtr_tewiSpawnProbability;

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeFieldInfoPtr_famousIzakayaAddSpawnRate;

		// Token: 0x04001D90 RID: 7568
		private static readonly IntPtr NativeFieldInfoPtr_famousIzakayaAddExtraFundRate;

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeFieldInfoPtr_releaseQueue;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedBossData;

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeFieldInfoPtr__MustOpenTileType_k__BackingField;

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeFieldInfoPtr__MustOpenCookerType_k__BackingField;

		// Token: 0x04001D95 RID: 7573
		private static readonly IntPtr NativeFieldInfoPtr__CookerMustIncludeIngredientId_k__BackingField;

		// Token: 0x04001D96 RID: 7574
		private static readonly IntPtr NativeFieldInfoPtr__CookerMustSelecRecipetId_k__BackingField;

		// Token: 0x04001D97 RID: 7575
		private static readonly IntPtr NativeFieldInfoPtr__BeverageStorageMustIncludeTagId_k__BackingField;

		// Token: 0x04001D98 RID: 7576
		private static readonly IntPtr NativeFieldInfoPtr__MustOpenGuestDeskCode_k__BackingField;

		// Token: 0x04001D99 RID: 7577
		private static readonly IntPtr NativeFieldInfoPtr__PlayerCharacter_k__BackingField;

		// Token: 0x04001D9A RID: 7578
		private static readonly IntPtr NativeFieldInfoPtr__IfTewiWillComeTonight_k__BackingField;

		// Token: 0x04001D9B RID: 7579
		private static readonly IntPtr NativeFieldInfoPtr__AdditiveBuff_k__BackingField;

		// Token: 0x04001D9C RID: 7580
		private static readonly IntPtr NativeFieldInfoPtr_OnNightSceneDisposeCallback;

		// Token: 0x04001D9D RID: 7581
		private static readonly IntPtr NativeMethodInfoPtr_get_MustOpenTileType_Public_get_Nullable_1_TileType_0;

		// Token: 0x04001D9E RID: 7582
		private static readonly IntPtr NativeMethodInfoPtr_set_MustOpenTileType_Public_set_Void_Nullable_1_TileType_0;

		// Token: 0x04001D9F RID: 7583
		private static readonly IntPtr NativeMethodInfoPtr_get_MustOpenCookerType_Public_get_Nullable_1_CookerType_0;

		// Token: 0x04001DA0 RID: 7584
		private static readonly IntPtr NativeMethodInfoPtr_set_MustOpenCookerType_Public_set_Void_Nullable_1_CookerType_0;

		// Token: 0x04001DA1 RID: 7585
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerMustIncludeIngredientId_Public_get_Nullable_1_Int32_0;

		// Token: 0x04001DA2 RID: 7586
		private static readonly IntPtr NativeMethodInfoPtr_set_CookerMustIncludeIngredientId_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04001DA3 RID: 7587
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerMustSelecRecipetId_Public_get_Nullable_1_Int32_0;

		// Token: 0x04001DA4 RID: 7588
		private static readonly IntPtr NativeMethodInfoPtr_set_CookerMustSelecRecipetId_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04001DA5 RID: 7589
		private static readonly IntPtr NativeMethodInfoPtr_get_BeverageStorageMustIncludeTagId_Public_get_Nullable_1_Int32_0;

		// Token: 0x04001DA6 RID: 7590
		private static readonly IntPtr NativeMethodInfoPtr_set_BeverageStorageMustIncludeTagId_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04001DA7 RID: 7591
		private static readonly IntPtr NativeMethodInfoPtr_get_MustOpenGuestDeskCode_Public_get_Nullable_1_Int32_0;

		// Token: 0x04001DA8 RID: 7592
		private static readonly IntPtr NativeMethodInfoPtr_set_MustOpenGuestDeskCode_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04001DA9 RID: 7593
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerCharacter_Public_get_WorkScenePlayerInputGenerator_0;

		// Token: 0x04001DAA RID: 7594
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerCharacter_Private_set_Void_WorkScenePlayerInputGenerator_0;

		// Token: 0x04001DAB RID: 7595
		private static readonly IntPtr NativeMethodInfoPtr_get_isCharacterStuned_Public_get_Boolean_0;

		// Token: 0x04001DAC RID: 7596
		private static readonly IntPtr NativeMethodInfoPtr_get_IfTewiWillComeTonight_Public_Static_get_Boolean_0;

		// Token: 0x04001DAD RID: 7597
		private static readonly IntPtr NativeMethodInfoPtr_set_IfTewiWillComeTonight_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveBuff_Public_Static_get_Queue_1_Action_1_Action_0;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeMethodInfoPtr_add_OnNightSceneDisposeCallback_Public_Static_add_Void_Action_0;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnNightSceneDisposeCallback_Public_Static_rem_Void_Action_0;

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeMethodInfoPtr_CheckIfBuffHasAdded_Public_Static_Boolean_Action_1_Action_0;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeMethodInfoPtr_STDOnEventFinishCallback_Private_Void_0;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeMethodInfoPtr_GetPostProcessCharacterDataCallback_Private_Action_1_AStarInputGeneratorComponent_0;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAsGeneralWorkScene_Private_Void_Action_0;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAsChallengeScene_Private_Void_Action_0;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeMethodInfoPtr_OnRequestedBossDataLoadFinishCallback_Private_Void_Action_BossData_0;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeMethodInfoPtr_GhostModeProcessCharacterCallback_Private_Void_AStarInputGeneratorComponent_0;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAsKyoukoTutorialScene_Private_Void_Action_Action_0;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_0;

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerCharacterToDefaultSpawn_Public_Void_0;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeMethodInfoPtr_ResetNightSetting_Public_Static_Void_0;

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeMethodInfoPtr_HandleCharacterArrivalCallback_Public_Void_Vector3Int_Vector3Int_byref_Int32_0;

		// Token: 0x04001DBE RID: 7614
		private static readonly IntPtr NativeMethodInfoPtr_ToResult_Public_Void_0;

		// Token: 0x04001DBF RID: 7615
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04001DC0 RID: 7616
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001DC1 RID: 7617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DC2 RID: 7618
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_byref___c__DisplayClass66_0_PDM_0;

		// Token: 0x04001DC3 RID: 7619
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0;

		// Token: 0x020007F5 RID: 2037
		[Serializable]
		public sealed class DataPair : ValueType
		{
			// Token: 0x0600A7F8 RID: 43000 RVA: 0x002BA810 File Offset: 0x002B8A10
			// Note: this type is marked as 'beforefieldinit'.
			static DataPair()
			{
				Il2CppClassPointerStore<SceneManager.DataPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "DataPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.DataPair>.NativeClassPtr);
				SceneManager.DataPair.NativeFieldInfoPtr_izakayaIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.DataPair>.NativeClassPtr, "izakayaIndexes");
				SceneManager.DataPair.NativeFieldInfoPtr_targetPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.DataPair>.NativeClassPtr, "targetPoint");
			}

			// Token: 0x0600A7F9 RID: 43001 RVA: 0x0005ABC9 File Offset: 0x00058DC9
			public DataPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A7FA RID: 43002 RVA: 0x0005ABD2 File Offset: 0x00058DD2
			public DataPair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.DataPair>.NativeClassPtr))
			{
			}

			// Token: 0x1700373B RID: 14139
			// (get) Token: 0x0600A7FB RID: 43003 RVA: 0x002BA864 File Offset: 0x002B8A64
			// (set) Token: 0x0600A7FC RID: 43004 RVA: 0x0005ABE4 File Offset: 0x00058DE4
			public unsafe Il2CppStructArray<int> izakayaIndexes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.DataPair.NativeFieldInfoPtr_izakayaIndexes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.DataPair.NativeFieldInfoPtr_izakayaIndexes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700373C RID: 14140
			// (get) Token: 0x0600A7FD RID: 43005 RVA: 0x002BA894 File Offset: 0x002B8A94
			// (set) Token: 0x0600A7FE RID: 43006 RVA: 0x0005AC03 File Offset: 0x00058E03
			public unsafe int targetPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.DataPair.NativeFieldInfoPtr_targetPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.DataPair.NativeFieldInfoPtr_targetPoint)) = value;
				}
			}

			// Token: 0x04006C8D RID: 27789
			private static readonly IntPtr NativeFieldInfoPtr_izakayaIndexes;

			// Token: 0x04006C8E RID: 27790
			private static readonly IntPtr NativeFieldInfoPtr_targetPoint;
		}

		// Token: 0x020007F6 RID: 2038
		[Serializable]
		public sealed class BossBattleData : ValueType
		{
			// Token: 0x0600A7FF RID: 43007 RVA: 0x002BA8BC File Offset: 0x002B8ABC
			// Note: this type is marked as 'beforefieldinit'.
			static BossBattleData()
			{
				Il2CppClassPointerStore<SceneManager.BossBattleData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "BossBattleData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.BossBattleData>.NativeClassPtr);
				SceneManager.BossBattleData.NativeFieldInfoPtr_challengeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.BossBattleData>.NativeClassPtr, "challengeType");
				SceneManager.BossBattleData.NativeFieldInfoPtr_bossDataAssetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.BossBattleData>.NativeClassPtr, "bossDataAssetReference");
			}

			// Token: 0x0600A800 RID: 43008 RVA: 0x0005AC1E File Offset: 0x00058E1E
			public BossBattleData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A801 RID: 43009 RVA: 0x0005AC27 File Offset: 0x00058E27
			public BossBattleData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.BossBattleData>.NativeClassPtr))
			{
			}

			// Token: 0x1700373D RID: 14141
			// (get) Token: 0x0600A802 RID: 43010 RVA: 0x002BA910 File Offset: 0x002B8B10
			// (set) Token: 0x0600A803 RID: 43011 RVA: 0x0005AC39 File Offset: 0x00058E39
			public unsafe NightSceneDirector.ChallengeType challengeType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.BossBattleData.NativeFieldInfoPtr_challengeType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.BossBattleData.NativeFieldInfoPtr_challengeType)) = value;
				}
			}

			// Token: 0x1700373E RID: 14142
			// (get) Token: 0x0600A804 RID: 43012 RVA: 0x002BA938 File Offset: 0x002B8B38
			// (set) Token: 0x0600A805 RID: 43013 RVA: 0x0005AC54 File Offset: 0x00058E54
			public unsafe AssetReference bossDataAssetReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.BossBattleData.NativeFieldInfoPtr_bossDataAssetReference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.BossBattleData.NativeFieldInfoPtr_bossDataAssetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C8F RID: 27791
			private static readonly IntPtr NativeFieldInfoPtr_challengeType;

			// Token: 0x04006C90 RID: 27792
			private static readonly IntPtr NativeFieldInfoPtr_bossDataAssetReference;
		}

		// Token: 0x020007F7 RID: 2039
		[ObfuscatedName("NightScene.SceneManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600A806 RID: 43014 RVA: 0x002BA968 File Offset: 0x002B8B68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr);
				SceneManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, "<>9");
				SceneManager.__c.NativeFieldInfoPtr___9__58_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, "<>9__58_0");
				SceneManager.__c.NativeFieldInfoPtr___9__62_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, "<>9__62_2");
				SceneManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, 100671136);
				SceneManager.__c.NativeMethodInfoPtr__Start_b__58_0_Internal_Sprite_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, 100671137);
				SceneManager.__c.NativeMethodInfoPtr__InitializeAsGeneralWorkScene_b__62_2_Internal_Boolean_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, 100671138);
			}

			// Token: 0x0600A807 RID: 43015 RVA: 0x002BAA0C File Offset: 0x002B8C0C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A808 RID: 43016 RVA: 0x002BAA48 File Offset: 0x002B8C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99733, XrefRangeEnd = 99738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _Start_b__58_0(Sellable sellable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c.NativeMethodInfoPtr__Start_b__58_0_Internal_Sprite_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x0600A809 RID: 43017 RVA: 0x002BAA98 File Offset: 0x002B8C98
			[CallerCount(0)]
			public unsafe bool _InitializeAsGeneralWorkScene_b__62_2(Decoration x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c.NativeMethodInfoPtr__InitializeAsGeneralWorkScene_b__62_2_Internal_Boolean_Decoration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A80A RID: 43018 RVA: 0x0005AC73 File Offset: 0x00058E73
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700373F RID: 14143
			// (get) Token: 0x0600A80B RID: 43019 RVA: 0x002BAAE8 File Offset: 0x002B8CE8
			// (set) Token: 0x0600A80C RID: 43020 RVA: 0x0005AC7C File Offset: 0x00058E7C
			public unsafe static SceneManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003740 RID: 14144
			// (get) Token: 0x0600A80D RID: 43021 RVA: 0x002BAB10 File Offset: 0x002B8D10
			// (set) Token: 0x0600A80E RID: 43022 RVA: 0x0005AC8E File Offset: 0x00058E8E
			public unsafe static Func<Sellable, Sprite> __9__58_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneManager.__c.NativeFieldInfoPtr___9__58_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneManager.__c.NativeFieldInfoPtr___9__58_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003741 RID: 14145
			// (get) Token: 0x0600A80F RID: 43023 RVA: 0x002BAB38 File Offset: 0x002B8D38
			// (set) Token: 0x0600A810 RID: 43024 RVA: 0x0005ACA0 File Offset: 0x00058EA0
			public unsafe static Func<Decoration, bool> __9__62_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneManager.__c.NativeFieldInfoPtr___9__62_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Decoration, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneManager.__c.NativeFieldInfoPtr___9__62_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C91 RID: 27793
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006C92 RID: 27794
			private static readonly IntPtr NativeFieldInfoPtr___9__58_0;

			// Token: 0x04006C93 RID: 27795
			private static readonly IntPtr NativeFieldInfoPtr___9__62_2;

			// Token: 0x04006C94 RID: 27796
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C95 RID: 27797
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__58_0_Internal_Sprite_Sellable_0;

			// Token: 0x04006C96 RID: 27798
			private static readonly IntPtr NativeMethodInfoPtr__InitializeAsGeneralWorkScene_b__62_2_Internal_Boolean_Decoration_0;
		}

		// Token: 0x020007F8 RID: 2040
		[ObfuscatedName("NightScene.SceneManager+<>c__DisplayClass62_0")]
		public sealed class __c__DisplayClass62_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A811 RID: 43025 RVA: 0x002BAB60 File Offset: 0x002B8D60
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass62_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass62_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass62_0.NativeFieldInfoPtr_onEventFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass62_0>.NativeClassPtr, "onEventFinishCallback");
				SceneManager.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass62_0>.NativeClassPtr, 100671139);
				SceneManager.__c__DisplayClass62_0.NativeMethodInfoPtr__InitializeAsGeneralWorkScene_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass62_0>.NativeClassPtr, 100671140);
				SceneManager.__c__DisplayClass62_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass62_0>.NativeClassPtr, 100671141);
			}

			// Token: 0x0600A812 RID: 43026 RVA: 0x002BABDC File Offset: 0x002B8DDC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass62_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A813 RID: 43027 RVA: 0x002BAC18 File Offset: 0x002B8E18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99738, XrefRangeEnd = 99795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeAsGeneralWorkScene_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass62_0.NativeMethodInfoPtr__InitializeAsGeneralWorkScene_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A814 RID: 43028 RVA: 0x002BAC4C File Offset: 0x002B8E4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99795, XrefRangeEnd = 99823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass62_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A815 RID: 43029 RVA: 0x0005ACB2 File Offset: 0x00058EB2
			public __c__DisplayClass62_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003742 RID: 14146
			// (get) Token: 0x0600A816 RID: 43030 RVA: 0x002BAC80 File Offset: 0x002B8E80
			// (set) Token: 0x0600A817 RID: 43031 RVA: 0x0005ACBB File Offset: 0x00058EBB
			public unsafe Action onEventFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass62_0.NativeFieldInfoPtr_onEventFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass62_0.NativeFieldInfoPtr_onEventFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C97 RID: 27799
			private static readonly IntPtr NativeFieldInfoPtr_onEventFinishCallback;

			// Token: 0x04006C98 RID: 27800
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C99 RID: 27801
			private static readonly IntPtr NativeMethodInfoPtr__InitializeAsGeneralWorkScene_b__0_Internal_Void_0;

			// Token: 0x04006C9A RID: 27802
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x020007F9 RID: 2041
		[ObfuscatedName("NightScene.SceneManager+<>c__DisplayClass63_0")]
		public sealed class __c__DisplayClass63_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A818 RID: 43032 RVA: 0x002BACB0 File Offset: 0x002B8EB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass63_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass63_0.NativeFieldInfoPtr_thisOnEventFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass63_0>.NativeClassPtr, "thisOnEventFinishCallback");
				SceneManager.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass63_0>.NativeClassPtr, "<>4__this");
				SceneManager.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass63_0>.NativeClassPtr, 100671142);
				SceneManager.__c__DisplayClass63_0.NativeMethodInfoPtr__InitializeAsChallengeScene_b__0_Internal_Void_AsyncOperationHandle_1_BossData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass63_0>.NativeClassPtr, 100671143);
			}

			// Token: 0x0600A819 RID: 43033 RVA: 0x002BAD2C File Offset: 0x002B8F2C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass63_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A81A RID: 43034 RVA: 0x002BAD68 File Offset: 0x002B8F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99823, XrefRangeEnd = 99827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitializeAsChallengeScene_b__0(AsyncOperationHandle<BossData> result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(result));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass63_0.NativeMethodInfoPtr__InitializeAsChallengeScene_b__0_Internal_Void_AsyncOperationHandle_1_BossData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A81B RID: 43035 RVA: 0x0005ACDA File Offset: 0x00058EDA
			public __c__DisplayClass63_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003743 RID: 14147
			// (get) Token: 0x0600A81C RID: 43036 RVA: 0x002BADB0 File Offset: 0x002B8FB0
			// (set) Token: 0x0600A81D RID: 43037 RVA: 0x0005ACE3 File Offset: 0x00058EE3
			public unsafe Action thisOnEventFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass63_0.NativeFieldInfoPtr_thisOnEventFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass63_0.NativeFieldInfoPtr_thisOnEventFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003744 RID: 14148
			// (get) Token: 0x0600A81E RID: 43038 RVA: 0x002BADE0 File Offset: 0x002B8FE0
			// (set) Token: 0x0600A81F RID: 43039 RVA: 0x0005AD02 File Offset: 0x00058F02
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass63_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C9B RID: 27803
			private static readonly IntPtr NativeFieldInfoPtr_thisOnEventFinishCallback;

			// Token: 0x04006C9C RID: 27804
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006C9D RID: 27805
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C9E RID: 27806
			private static readonly IntPtr NativeMethodInfoPtr__InitializeAsChallengeScene_b__0_Internal_Void_AsyncOperationHandle_1_BossData_0;
		}

		// Token: 0x020007FA RID: 2042
		[ObfuscatedName("NightScene.SceneManager+<>c__DisplayClass64_0")]
		public sealed class __c__DisplayClass64_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A820 RID: 43040 RVA: 0x002BAE10 File Offset: 0x002B9010
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass64_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass64_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass64_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass64_0>.NativeClassPtr, "<>4__this");
				SceneManager.__c__DisplayClass64_0.NativeFieldInfoPtr_thisOnEventFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass64_0>.NativeClassPtr, "thisOnEventFinishCallback");
				SceneManager.__c__DisplayClass64_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass64_0>.NativeClassPtr, "<>9__2");
				SceneManager.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass64_0>.NativeClassPtr, 100671144);
				SceneManager.__c__DisplayClass64_0.NativeMethodInfoPtr__OnRequestedBossDataLoadFinishCallback_b__0_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass64_0>.NativeClassPtr, 100671145);
				SceneManager.__c__DisplayClass64_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass64_0>.NativeClassPtr, 100671146);
				SceneManager.__c__DisplayClass64_0.NativeMethodInfoPtr__OnRequestedBossDataLoadFinishCallback_b__2_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass64_0>.NativeClassPtr, 100671147);
			}

			// Token: 0x0600A821 RID: 43041 RVA: 0x002BAEC8 File Offset: 0x002B90C8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass64_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass64_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A822 RID: 43042 RVA: 0x002BAF04 File Offset: 0x002B9104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99827, XrefRangeEnd = 99828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnRequestedBossDataLoadFinishCallback_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass64_0.NativeMethodInfoPtr__OnRequestedBossDataLoadFinishCallback_b__0_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A823 RID: 43043 RVA: 0x002BAF38 File Offset: 0x002B9138
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 99874, RefRangeEnd = 99875, XrefRangeStart = 99828, XrefRangeEnd = 99874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass64_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A824 RID: 43044 RVA: 0x002BAF6C File Offset: 0x002B916C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99875, XrefRangeEnd = 99883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnRequestedBossDataLoadFinishCallback_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass64_0.NativeMethodInfoPtr__OnRequestedBossDataLoadFinishCallback_b__2_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A825 RID: 43045 RVA: 0x0005AD21 File Offset: 0x00058F21
			public __c__DisplayClass64_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003745 RID: 14149
			// (get) Token: 0x0600A826 RID: 43046 RVA: 0x002BAFA0 File Offset: 0x002B91A0
			// (set) Token: 0x0600A827 RID: 43047 RVA: 0x0005AD2A File Offset: 0x00058F2A
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003746 RID: 14150
			// (get) Token: 0x0600A828 RID: 43048 RVA: 0x002BAFD0 File Offset: 0x002B91D0
			// (set) Token: 0x0600A829 RID: 43049 RVA: 0x0005AD49 File Offset: 0x00058F49
			public unsafe Action thisOnEventFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass64_0.NativeFieldInfoPtr_thisOnEventFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass64_0.NativeFieldInfoPtr_thisOnEventFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003747 RID: 14151
			// (get) Token: 0x0600A82A RID: 43050 RVA: 0x002BB000 File Offset: 0x002B9200
			// (set) Token: 0x0600A82B RID: 43051 RVA: 0x0005AD68 File Offset: 0x00058F68
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass64_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass64_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C9F RID: 27807
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006CA0 RID: 27808
			private static readonly IntPtr NativeFieldInfoPtr_thisOnEventFinishCallback;

			// Token: 0x04006CA1 RID: 27809
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04006CA2 RID: 27810
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006CA3 RID: 27811
			private static readonly IntPtr NativeMethodInfoPtr__OnRequestedBossDataLoadFinishCallback_b__0_Internal_Void_1;

			// Token: 0x04006CA4 RID: 27812
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04006CA5 RID: 27813
			private static readonly IntPtr NativeMethodInfoPtr__OnRequestedBossDataLoadFinishCallback_b__2_Internal_Void_1;
		}

		// Token: 0x020007FB RID: 2043
		[ObfuscatedName("NightScene.SceneManager+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : ValueType
		{
			// Token: 0x0600A82C RID: 43052 RVA: 0x002BB030 File Offset: 0x002B9230
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass66_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass66_0.NativeFieldInfoPtr_onEventFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass66_0>.NativeClassPtr, "onEventFinishCallback");
				SceneManager.__c__DisplayClass66_0.NativeFieldInfoPtr_onTimelineFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass66_0>.NativeClassPtr, "onTimelineFinishCallback");
			}

			// Token: 0x0600A82D RID: 43053 RVA: 0x0005AD87 File Offset: 0x00058F87
			public __c__DisplayClass66_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600A82E RID: 43054 RVA: 0x0005AD90 File Offset: 0x00058F90
			public __c__DisplayClass66_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass66_0>.NativeClassPtr))
			{
			}

			// Token: 0x17003748 RID: 14152
			// (get) Token: 0x0600A82F RID: 43055 RVA: 0x002BB084 File Offset: 0x002B9284
			// (set) Token: 0x0600A830 RID: 43056 RVA: 0x0005ADA2 File Offset: 0x00058FA2
			public unsafe Action onEventFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass66_0.NativeFieldInfoPtr_onEventFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass66_0.NativeFieldInfoPtr_onEventFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003749 RID: 14153
			// (get) Token: 0x0600A831 RID: 43057 RVA: 0x002BB0B4 File Offset: 0x002B92B4
			// (set) Token: 0x0600A832 RID: 43058 RVA: 0x0005ADC1 File Offset: 0x00058FC1
			public unsafe Action onTimelineFinishCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass66_0.NativeFieldInfoPtr_onTimelineFinishCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass66_0.NativeFieldInfoPtr_onTimelineFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006CA6 RID: 27814
			private static readonly IntPtr NativeFieldInfoPtr_onEventFinishCallback;

			// Token: 0x04006CA7 RID: 27815
			private static readonly IntPtr NativeFieldInfoPtr_onTimelineFinishCallback;
		}

		// Token: 0x020007FC RID: 2044
		[ObfuscatedName("NightScene.SceneManager+<>c__DisplayClass66_1")]
		public sealed class __c__DisplayClass66_1 : Il2CppSystem.Object
		{
			// Token: 0x0600A833 RID: 43059 RVA: 0x002BB0E4 File Offset: 0x002B92E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_1()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass66_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass66_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass66_1>.NativeClassPtr);
				SceneManager.__c__DisplayClass66_1.NativeFieldInfoPtr_foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass66_1>.NativeClassPtr, "foods");
				SceneManager.__c__DisplayClass66_1.NativeFieldInfoPtr_bevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass66_1>.NativeClassPtr, "bevs");
				SceneManager.__c__DisplayClass66_1.NativeFieldInfoPtr_ings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass66_1>.NativeClassPtr, "ings");
				SceneManager.__c__DisplayClass66_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass66_1>.NativeClassPtr, 100671148);
				SceneManager.__c__DisplayClass66_1.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass66_1>.NativeClassPtr, 100671149);
			}

			// Token: 0x0600A834 RID: 43060 RVA: 0x002BB174 File Offset: 0x002B9374
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass66_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass66_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A835 RID: 43061 RVA: 0x002BB1B0 File Offset: 0x002B93B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99883, XrefRangeEnd = 99885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass66_1.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A836 RID: 43062 RVA: 0x0005ADE0 File Offset: 0x00058FE0
			public __c__DisplayClass66_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700374A RID: 14154
			// (get) Token: 0x0600A837 RID: 43063 RVA: 0x002BB1E4 File Offset: 0x002B93E4
			// (set) Token: 0x0600A838 RID: 43064 RVA: 0x0005ADE9 File Offset: 0x00058FE9
			public unsafe IEnumerable<KeyValuePair<int, int>> foods
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass66_1.NativeFieldInfoPtr_foods);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass66_1.NativeFieldInfoPtr_foods), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700374B RID: 14155
			// (get) Token: 0x0600A839 RID: 43065 RVA: 0x002BB214 File Offset: 0x002B9414
			// (set) Token: 0x0600A83A RID: 43066 RVA: 0x0005AE08 File Offset: 0x00059008
			public unsafe IEnumerable<KeyValuePair<int, int>> bevs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass66_1.NativeFieldInfoPtr_bevs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass66_1.NativeFieldInfoPtr_bevs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700374C RID: 14156
			// (get) Token: 0x0600A83B RID: 43067 RVA: 0x002BB244 File Offset: 0x002B9444
			// (set) Token: 0x0600A83C RID: 43068 RVA: 0x0005AE27 File Offset: 0x00059027
			public unsafe IEnumerable<KeyValuePair<int, int>> ings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass66_1.NativeFieldInfoPtr_ings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass66_1.NativeFieldInfoPtr_ings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006CA8 RID: 27816
			private static readonly IntPtr NativeFieldInfoPtr_foods;

			// Token: 0x04006CA9 RID: 27817
			private static readonly IntPtr NativeFieldInfoPtr_bevs;

			// Token: 0x04006CAA RID: 27818
			private static readonly IntPtr NativeFieldInfoPtr_ings;

			// Token: 0x04006CAB RID: 27819
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006CAC RID: 27820
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;
		}

		// Token: 0x020007FD RID: 2045
		[ObfuscatedName("NightScene.SceneManager+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A83D RID: 43069 RVA: 0x002BB274 File Offset: 0x002B9474
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass70_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass70_0.NativeFieldInfoPtr_targetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass70_0>.NativeClassPtr, "targetPos");
				SceneManager.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass70_0>.NativeClassPtr, 100671150);
				SceneManager.__c__DisplayClass70_0.NativeMethodInfoPtr__HandleCharacterArrivalCallback_b__0_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass70_0>.NativeClassPtr, 100671151);
				SceneManager.__c__DisplayClass70_0.NativeMethodInfoPtr__HandleCharacterArrivalCallback_b__1_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass70_0>.NativeClassPtr, 100671152);
			}

			// Token: 0x0600A83E RID: 43070 RVA: 0x002BB2F0 File Offset: 0x002B94F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A83F RID: 43071 RVA: 0x002BB32C File Offset: 0x002B952C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99885, XrefRangeEnd = 99886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HandleCharacterArrivalCallback_b__0(KeyValuePair<int, TileManager.GuestTableData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass70_0.NativeMethodInfoPtr__HandleCharacterArrivalCallback_b__0_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A840 RID: 43072 RVA: 0x002BB380 File Offset: 0x002B9580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99886, XrefRangeEnd = 99887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HandleCharacterArrivalCallback_b__1(KeyValuePair<int, TileManager.GuestTableData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass70_0.NativeMethodInfoPtr__HandleCharacterArrivalCallback_b__1_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A841 RID: 43073 RVA: 0x0005AE46 File Offset: 0x00059046
			public __c__DisplayClass70_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700374D RID: 14157
			// (get) Token: 0x0600A842 RID: 43074 RVA: 0x002BB3D4 File Offset: 0x002B95D4
			// (set) Token: 0x0600A843 RID: 43075 RVA: 0x0005AE4F File Offset: 0x0005904F
			public unsafe Vector3Int targetPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass70_0.NativeFieldInfoPtr_targetPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass70_0.NativeFieldInfoPtr_targetPos)) = value;
				}
			}

			// Token: 0x04006CAD RID: 27821
			private static readonly IntPtr NativeFieldInfoPtr_targetPos;

			// Token: 0x04006CAE RID: 27822
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006CAF RID: 27823
			private static readonly IntPtr NativeMethodInfoPtr__HandleCharacterArrivalCallback_b__0_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0;

			// Token: 0x04006CB0 RID: 27824
			private static readonly IntPtr NativeMethodInfoPtr__HandleCharacterArrivalCallback_b__1_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0;
		}
	}
}
