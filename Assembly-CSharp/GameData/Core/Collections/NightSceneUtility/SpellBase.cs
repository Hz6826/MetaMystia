using System;
using Cinemachine;
using Common.CharacterUtility;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.Tiles;
using NightScene.UI.EventUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x0200024F RID: 591
	public class SpellBase : ScriptableObject
	{
		// Token: 0x060049C4 RID: 18884 RVA: 0x0019EB40 File Offset: 0x0019CD40
		// Note: this type is marked as 'beforefieldinit'.
		static SpellBase()
		{
			Il2CppClassPointerStore<SpellBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "SpellBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase>.NativeClassPtr);
			SpellBase.NativeFieldInfoPtr_DEFAULT_POSITIVE_SPELL_LANG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "DEFAULT_POSITIVE_SPELL_LANG");
			SpellBase.NativeFieldInfoPtr_DEFAULT_NEGATIVE_SPELL_LANG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "DEFAULT_NEGATIVE_SPELL_LANG");
			SpellBase.NativeMethodInfoPtr_get_ShouldProtectedByShield_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677972);
			SpellBase.NativeMethodInfoPtr_get_Manager_Protected_get_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677973);
			SpellBase.NativeMethodInfoPtr_get_ExtraBuffTime_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677974);
			SpellBase.NativeMethodInfoPtr_get_VirtualCamera_Private_get_CinemachineVirtualCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677975);
			SpellBase.NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677976);
			SpellBase.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677977);
			SpellBase.NativeMethodInfoPtr_FinalBuffTime_Protected_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677978);
			SpellBase.NativeMethodInfoPtr_RegisterTimedBuff_Protected_Boolean_BuffType_Single_Action_1_Int32_BuffRegisterType_Int32_Action_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677979);
			SpellBase.NativeMethodInfoPtr_ExecuteDelayed_Protected_Static_Void_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677980);
			SpellBase.NativeMethodInfoPtr_ExecuteDelayedForOneFrame_Protected_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677981);
			SpellBase.NativeMethodInfoPtr_CallSpellDeclaration_Protected_IEnumerator_SpecialGuest_LanguageBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677982);
			SpellBase.NativeMethodInfoPtr_SetCameraShake_Protected_IEnumerator_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677983);
			SpellBase.NativeMethodInfoPtr_SetCameraShake_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677984);
			SpellBase.NativeMethodInfoPtr_PlayAudio_Protected_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677985);
			SpellBase.NativeMethodInfoPtr_PlayAudioDelayed_Protected_Void_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677986);
			SpellBase.NativeMethodInfoPtr_PlayAudioDelayed_Protected_Void_DelayAudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677987);
			SpellBase.NativeMethodInfoPtr_PlayAudioLooped_Protected_Void_Object_LoopedBGMPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677988);
			SpellBase.NativeMethodInfoPtr_get_HasPositiveSpell_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677989);
			SpellBase.NativeMethodInfoPtr_SchedulePositiveBuffExecution_Public_Void_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677990);
			SpellBase.NativeMethodInfoPtr_ExecutePositiveBuffAsync_Public_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677991);
			SpellBase.NativeMethodInfoPtr_PreprocessPositiveBuff_Private_Boolean_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677992);
			SpellBase.NativeMethodInfoPtr_ExecutePositiveBuff_Private_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677993);
			SpellBase.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Abstract_Virtual_New_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677994);
			SpellBase.NativeMethodInfoPtr_get_HasNegativeSpell_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677995);
			SpellBase.NativeMethodInfoPtr_TryDefendNegativeSpell_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677996);
			SpellBase.NativeMethodInfoPtr_PreprocessNegativeBuff_Private_Boolean_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677997);
			SpellBase.NativeMethodInfoPtr_ScheduleNegativeBuffExecution_Public_Void_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677998);
			SpellBase.NativeMethodInfoPtr_ExecuteNegativeBuffAsync_Public_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100677999);
			SpellBase.NativeMethodInfoPtr_ExecuteNegativeBuff_Private_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678000);
			SpellBase.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Abstract_Virtual_New_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678001);
			SpellBase.NativeMethodInfoPtr_get_HasLeaveSpell_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678002);
			SpellBase.NativeMethodInfoPtr_ScheduleOnLeaveBuffExecution_Public_Void_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678003);
			SpellBase.NativeMethodInfoPtr_ExecuteOnLeaveBuffAsync_Public_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678004);
			SpellBase.NativeMethodInfoPtr_PreprocessOnLeaveBuff_Private_Boolean_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678005);
			SpellBase.NativeMethodInfoPtr_ExecuteOnLeaveBuff_Private_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678006);
			SpellBase.NativeMethodInfoPtr_OnLeaveBuffExecute_Protected_Virtual_New_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678007);
			SpellBase.NativeMethodInfoPtr_InstantiateTimedC_Protected_IEnumerator_GameObject_Action_1_GameObject_Single_EffectLayerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678008);
			SpellBase.NativeMethodInfoPtr_InstantiateTimedC_Protected_IEnumerator_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678009);
			SpellBase.NativeMethodInfoPtr_InstantiateTimedC_Protected_IEnumerator_GameObject_Vector3_Action_1_GameObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678010);
			SpellBase.NativeMethodInfoPtr_InstantiateTimedC_Protected_IEnumerator_GameObject_Transform_Action_1_GameObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678011);
			SpellBase.NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Single_EffectLayerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678012);
			SpellBase.NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Action_1_GameObject_Single_EffectLayerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678013);
			SpellBase.NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678014);
			SpellBase.NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Vector3_Action_1_GameObject_Single_EffectLayerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678015);
			SpellBase.NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Transform_Action_1_GameObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678016);
			SpellBase.NativeMethodInfoPtr_GetSpellEffectParentTransform_Private_Transform_EffectLayerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678017);
			SpellBase.NativeMethodInfoPtr_LerpPosition_Protected_IEnumerator_Transform_Func_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678018);
			SpellBase.NativeMethodInfoPtr_LerpParabolic_Protected_IEnumerator_Transform_Func_1_Vector3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678019);
			SpellBase.NativeMethodInfoPtr_LerpBezier_Protected_IEnumerator_Transform_Func_1_Vector3_Func_1_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678020);
			SpellBase.NativeMethodInfoPtr_LerpBezierCubic_Protected_IEnumerator_Transform_Func_1_Vector3_Func_1_Vector3_Func_1_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678021);
			SpellBase.NativeMethodInfoPtr_Homing_Protected_IEnumerator_Transform_Func_1_Vector3_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678022);
			SpellBase.NativeMethodInfoPtr_Homing_Protected_IEnumerator_Transform_Func_1_Vector3_Func_1_Single_Func_1_Single_Func_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678023);
			SpellBase.NativeMethodInfoPtr_StopRotation_Protected_Void_byref_SpellExecutionContext_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678024);
			SpellBase.NativeMethodInfoPtr_SetRotation_Protected_Void_byref_SpellExecutionContext_Transform_String_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678025);
			SpellBase.NativeMethodInfoPtr_GetPlayerPosition_Public_Static_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678026);
			SpellBase.NativeMethodInfoPtr_GetAllGuestsPosition_Protected_IEnumerable_1_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678027);
			SpellBase.NativeMethodInfoPtr_GetFoodStoragePosition_Protected_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678028);
			SpellBase.NativeMethodInfoPtr_GetBeverageStoragePosition_Protected_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678029);
			SpellBase.NativeMethodInfoPtr_GetPlayerSpawnPosition_Protected_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678030);
			SpellBase.NativeMethodInfoPtr_GetPlayerTransform_Public_Static_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678031);
			SpellBase.NativeMethodInfoPtr_GetUIEffectTransformFront_Protected_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678032);
			SpellBase.NativeMethodInfoPtr_GetUIEffectTransformTop_Protected_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678033);
			SpellBase.NativeMethodInfoPtr_GetUIEffectTransformMiddle_Protected_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678034);
			SpellBase.NativeMethodInfoPtr_GetUIEffectTransformBack_Protected_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678035);
			SpellBase.NativeMethodInfoPtr_GetBuffModule_Protected_BuffModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678036);
			SpellBase.NativeMethodInfoPtr_GetGuestBuffMarkModule_Protected_GuestBuffMarkModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678037);
			SpellBase.NativeMethodInfoPtr_GetWorldToScreenPoint_Protected_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678038);
			SpellBase.NativeMethodInfoPtr_GetGuestTable_Public_Static_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678039);
			SpellBase.NativeMethodInfoPtr_GetAllSeatedGuestGroups_Protected_IEnumerable_1_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678040);
			SpellBase.NativeMethodInfoPtr_GetAllActiveGuestGroups_Protected_IEnumerable_1_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678041);
			SpellBase.NativeMethodInfoPtr_GetCookerTable_Protected_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678042);
			SpellBase.NativeMethodInfoPtr_GetCookerController_Protected_CookController_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678043);
			SpellBase.NativeMethodInfoPtr_GetAllCookerTables_Protected_IEnumerable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678044);
			SpellBase.NativeMethodInfoPtr_GetAllTables_Protected_IEnumerable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678045);
			SpellBase.NativeMethodInfoPtr_GetAllTablesData_Protected_Dictionary_2_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678046);
			SpellBase.NativeMethodInfoPtr_GetAllTablesExceptOne_Protected_IEnumerable_1_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678047);
			SpellBase.NativeMethodInfoPtr_GetAllTablesDataExceptOne_Protected_Dictionary_2_Int32_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678048);
			SpellBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, 100678049);
		}

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x060049C5 RID: 18885 RVA: 0x0019F1B0 File Offset: 0x0019D3B0
		public unsafe virtual bool ShouldProtectedByShield
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellBase.NativeMethodInfoPtr_get_ShouldProtectedByShield_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x060049C6 RID: 18886 RVA: 0x0019F1F8 File Offset: 0x0019D3F8
		public unsafe EventManager Manager
		{
			[CallerCount(300)]
			[CachedScanResults(RefRangeStart = 192322, RefRangeEnd = 192622, XrefRangeStart = 192319, XrefRangeEnd = 192322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_get_Manager_Protected_get_EventManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr3) : null;
			}
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x060049C7 RID: 18887 RVA: 0x0019F238 File Offset: 0x0019D438
		public unsafe float ExtraBuffTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192622, XrefRangeEnd = 192627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_get_ExtraBuffTime_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x060049C8 RID: 18888 RVA: 0x0019F274 File Offset: 0x0019D474
		public unsafe CinemachineVirtualCamera VirtualCamera
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192627, XrefRangeEnd = 192630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_get_VirtualCamera_Private_get_CinemachineVirtualCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CinemachineVirtualCamera>(intPtr3) : null;
			}
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x0019F2B4 File Offset: 0x0019D4B4
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldCallSpellDeclarationAuto(bool isPositive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isPositive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellBase.NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x0019F308 File Offset: 0x0019D508
		[CallerCount(0)]
		public unsafe virtual string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellBase.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x0019F34C File Offset: 0x0019D54C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192640, RefRangeEnd = 192642, XrefRangeStart = 192630, XrefRangeEnd = 192640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FinalBuffTime(float oldTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_FinalBuffTime_Protected_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x0019F398 File Offset: 0x0019D598
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 192647, RefRangeEnd = 192684, XrefRangeStart = 192642, XrefRangeEnd = 192647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RegisterTimedBuff(EventManager.BuffType buffType, float duration, Action<int> defaultRegisterBuffAction, EventManager.BuffRegisterType buffRegisterType = EventManager.BuffRegisterType.Additive, int extraDuration = -1, Action<int> haveBuffRegisterBuffAction = null, bool isPositive = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buffType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultRegisterBuffAction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffRegisterType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraDuration;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(haveBuffRegisterBuffAction);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPositive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_RegisterTimedBuff_Protected_Boolean_BuffType_Single_Action_1_Int32_BuffRegisterType_Int32_Action_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049CD RID: 18893 RVA: 0x0019F440 File Offset: 0x0019D640
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192699, RefRangeEnd = 192701, XrefRangeStart = 192684, XrefRangeEnd = 192699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteDelayed(float delay, Action onDelayEndCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onDelayEndCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_ExecuteDelayed_Protected_Static_Void_Single_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049CE RID: 18894 RVA: 0x0019F484 File Offset: 0x0019D684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192716, RefRangeEnd = 192717, XrefRangeStart = 192701, XrefRangeEnd = 192716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteDelayedForOneFrame(Action onDelayEndCallback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onDelayEndCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_ExecuteDelayedForOneFrame_Protected_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x0019F4BC File Offset: 0x0019D6BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 192724, RefRangeEnd = 192729, XrefRangeStart = 192717, XrefRangeEnd = 192724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CallSpellDeclaration(SpecialGuest guestData, LanguageBase text, bool isPositiveSpellCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPositiveSpellCard;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_CallSpellDeclaration_Protected_IEnumerator_SpecialGuest_LanguageBase_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x0019F52C File Offset: 0x0019D72C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 192733, RefRangeEnd = 192751, XrefRangeStart = 192729, XrefRangeEnd = 192733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetCameraShake(float amplitude, float duration, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amplitude;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_SetCameraShake_Protected_IEnumerator_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x0019F594 File Offset: 0x0019D794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192755, RefRangeEnd = 192757, XrefRangeStart = 192751, XrefRangeEnd = 192755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCameraShake(float amplitude)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amplitude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_SetCameraShake_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D2 RID: 18898 RVA: 0x0019F5D4 File Offset: 0x0019D7D4
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 192762, RefRangeEnd = 192812, XrefRangeStart = 192757, XrefRangeEnd = 192762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAudio(AudioClip audioClip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioClip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_PlayAudio_Protected_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D3 RID: 18899 RVA: 0x0019F618 File Offset: 0x0019D818
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 192827, RefRangeEnd = 192840, XrefRangeStart = 192812, XrefRangeEnd = 192827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAudioDelayed(AudioClip audioClip, float offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioClip);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_PlayAudioDelayed_Protected_Void_AudioClip_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D4 RID: 18900 RVA: 0x0019F668 File Offset: 0x0019D868
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 192855, RefRangeEnd = 192892, XrefRangeStart = 192840, XrefRangeEnd = 192855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAudioDelayed(SpellBase.DelayAudioClip delayAudioClip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(delayAudioClip));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_PlayAudioDelayed_Protected_Void_DelayAudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D5 RID: 18901 RVA: 0x0019F6B0 File Offset: 0x0019D8B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 192897, RefRangeEnd = 192903, XrefRangeStart = 192892, XrefRangeEnd = 192897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayAudioLooped(UnityEngine.Object identifier, LoopedBGMPackage loopedBGMPackage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(identifier);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loopedBGMPackage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_PlayAudioLooped_Protected_Void_Object_LoopedBGMPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x060049D6 RID: 18902 RVA: 0x0019F704 File Offset: 0x0019D904
		public unsafe virtual bool HasPositiveSpell
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellBase.NativeMethodInfoPtr_get_HasPositiveSpell_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049D7 RID: 18903 RVA: 0x0019F74C File Offset: 0x0019D94C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192932, RefRangeEnd = 192933, XrefRangeStart = 192903, XrefRangeEnd = 192932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SchedulePositiveBuffExecution(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_SchedulePositiveBuffExecution_Public_Void_SpellExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x0019F790 File Offset: 0x0019D990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192933, XrefRangeEnd = 192939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExecutePositiveBuffAsync(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_ExecutePositiveBuffAsync_Public_IEnumerator_SpellExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x0019F7E0 File Offset: 0x0019D9E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192950, RefRangeEnd = 192952, XrefRangeStart = 192939, XrefRangeEnd = 192950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PreprocessPositiveBuff(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_PreprocessPositiveBuff_Private_Boolean_SpellExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x0019F830 File Offset: 0x0019DA30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192958, RefRangeEnd = 192960, XrefRangeStart = 192952, XrefRangeEnd = 192958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExecutePositiveBuff(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_ExecutePositiveBuff_Private_IEnumerator_SpellExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x0019F880 File Offset: 0x0019DA80
		[CallerCount(0)]
		public unsafe virtual IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellBase.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Abstract_Virtual_New_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x060049DC RID: 18908 RVA: 0x0019F8DC File Offset: 0x0019DADC
		public unsafe virtual bool HasNegativeSpell
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellBase.NativeMethodInfoPtr_get_HasNegativeSpell_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x0019F924 File Offset: 0x0019DB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192960, XrefRangeEnd = 192977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryDefendNegativeSpell()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_TryDefendNegativeSpell_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x0019F960 File Offset: 0x0019DB60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192988, RefRangeEnd = 192990, XrefRangeStart = 192977, XrefRangeEnd = 192988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PreprocessNegativeBuff(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_PreprocessNegativeBuff_Private_Boolean_SpellExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x0019F9B0 File Offset: 0x0019DBB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193018, RefRangeEnd = 193019, XrefRangeStart = 192990, XrefRangeEnd = 193018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleNegativeBuffExecution(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_ScheduleNegativeBuffExecution_Public_Void_SpellExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x0019F9F4 File Offset: 0x0019DBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193019, XrefRangeEnd = 193025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExecuteNegativeBuffAsync(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_ExecuteNegativeBuffAsync_Public_IEnumerator_SpellExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x0019FA44 File Offset: 0x0019DC44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193031, RefRangeEnd = 193033, XrefRangeStart = 193025, XrefRangeEnd = 193031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExecuteNegativeBuff(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_ExecuteNegativeBuff_Private_IEnumerator_SpellExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x0019FA94 File Offset: 0x0019DC94
		[CallerCount(0)]
		public unsafe virtual IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellBase.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Abstract_Virtual_New_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x060049E3 RID: 18915 RVA: 0x0019FAF0 File Offset: 0x0019DCF0
		public unsafe virtual bool HasLeaveSpell
		{
			[CallerCount(299)]
			[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellBase.NativeMethodInfoPtr_get_HasLeaveSpell_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x0019FB38 File Offset: 0x0019DD38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193046, RefRangeEnd = 193047, XrefRangeStart = 193033, XrefRangeEnd = 193046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleOnLeaveBuffExecution(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_ScheduleOnLeaveBuffExecution_Public_Void_SpellExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x0019FB7C File Offset: 0x0019DD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193047, XrefRangeEnd = 193053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExecuteOnLeaveBuffAsync(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_ExecuteOnLeaveBuffAsync_Public_IEnumerator_SpellExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x0019FBCC File Offset: 0x0019DDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193053, XrefRangeEnd = 193056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PreprocessOnLeaveBuff(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_PreprocessOnLeaveBuff_Private_Boolean_SpellExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049E7 RID: 18919 RVA: 0x0019FC1C File Offset: 0x0019DE1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193062, RefRangeEnd = 193063, XrefRangeStart = 193056, XrefRangeEnd = 193062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExecuteOnLeaveBuff(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_ExecuteOnLeaveBuff_Private_IEnumerator_SpellExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x0019FC6C File Offset: 0x0019DE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193063, XrefRangeEnd = 193067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator OnLeaveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpellBase.NativeMethodInfoPtr_OnLeaveBuffExecute_Protected_Virtual_New_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049E9 RID: 18921 RVA: 0x0019FCC8 File Offset: 0x0019DEC8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 193074, RefRangeEnd = 193083, XrefRangeStart = 193067, XrefRangeEnd = 193074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InstantiateTimedC(GameObject parent, Action<GameObject> objectProcessingCallback, float duration, EffectLayerInfo effectLayerInfo = EffectLayerInfo.World)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectProcessingCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref effectLayerInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_InstantiateTimedC_Protected_IEnumerator_GameObject_Action_1_GameObject_Single_EffectLayerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049EA RID: 18922 RVA: 0x0019FD48 File Offset: 0x0019DF48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193088, RefRangeEnd = 193089, XrefRangeStart = 193083, XrefRangeEnd = 193088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InstantiateTimedC(GameObject parent, Vector3 position, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_InstantiateTimedC_Protected_IEnumerator_GameObject_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049EB RID: 18923 RVA: 0x0019FDB4 File Offset: 0x0019DFB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193095, RefRangeEnd = 193098, XrefRangeStart = 193089, XrefRangeEnd = 193095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InstantiateTimedC(GameObject parent, Vector3 position, Action<GameObject> objectProcessingCallback, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectProcessingCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_InstantiateTimedC_Protected_IEnumerator_GameObject_Vector3_Action_1_GameObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x0019FE34 File Offset: 0x0019E034
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 193105, RefRangeEnd = 193109, XrefRangeStart = 193098, XrefRangeEnd = 193105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator InstantiateTimedC(GameObject parent, Transform transform, Action<GameObject> objectProcessingCallback, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectProcessingCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_InstantiateTimedC_Protected_IEnumerator_GameObject_Transform_Action_1_GameObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x0019FEB8 File Offset: 0x0019E0B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 193117, RefRangeEnd = 193124, XrefRangeStart = 193109, XrefRangeEnd = 193117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject InstantiateTimedN(GameObject parent, float duration, EffectLayerInfo effectLayerInfo = EffectLayerInfo.World)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref effectLayerInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Single_EffectLayerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060049EE RID: 18926 RVA: 0x0019FF24 File Offset: 0x0019E124
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 193134, RefRangeEnd = 193155, XrefRangeStart = 193124, XrefRangeEnd = 193134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject InstantiateTimedN(GameObject parent, Action<GameObject> objectProcessingCallback, float duration, EffectLayerInfo effectLayerInfo = EffectLayerInfo.World)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectProcessingCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref effectLayerInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Action_1_GameObject_Single_EffectLayerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x0019FFA4 File Offset: 0x0019E1A4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 193164, RefRangeEnd = 193191, XrefRangeStart = 193155, XrefRangeEnd = 193164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject InstantiateTimedN(GameObject parent, Vector3 position, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x001A0010 File Offset: 0x0019E210
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 193203, RefRangeEnd = 193213, XrefRangeStart = 193191, XrefRangeEnd = 193203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject InstantiateTimedN(GameObject parent, Vector3 position, Action<GameObject> objectProcessingCallback, float duration, EffectLayerInfo effectLayerInfo = EffectLayerInfo.World)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectProcessingCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref effectLayerInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Vector3_Action_1_GameObject_Single_EffectLayerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x001A009C File Offset: 0x0019E29C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 193222, RefRangeEnd = 193227, XrefRangeStart = 193213, XrefRangeEnd = 193222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject InstantiateTimedN(GameObject parent, Transform transform, Action<GameObject> objectProcessingCallback, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectProcessingCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Transform_Action_1_GameObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x001A0120 File Offset: 0x0019E320
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 193227, RefRangeEnd = 193232, XrefRangeStart = 193227, XrefRangeEnd = 193227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetSpellEffectParentTransform(EffectLayerInfo effectLayerInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref effectLayerInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetSpellEffectParentTransform_Private_Transform_EffectLayerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x001A016C File Offset: 0x0019E36C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 193239, RefRangeEnd = 193256, XrefRangeStart = 193232, XrefRangeEnd = 193239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpPosition(Transform source, Func<Vector3> targetPosition, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetPosition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_LerpPosition_Protected_IEnumerator_Transform_Func_1_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x001A01DC File Offset: 0x0019E3DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193263, RefRangeEnd = 193264, XrefRangeStart = 193256, XrefRangeEnd = 193263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpParabolic(Transform source, Func<Vector3> targetPosition, float launchHeight, float launchSpeed, bool forceRotate = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetPosition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref launchHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref launchSpeed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceRotate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_LerpParabolic_Protected_IEnumerator_Transform_Func_1_Vector3_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x001A0268 File Offset: 0x0019E468
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193272, RefRangeEnd = 193275, XrefRangeStart = 193264, XrefRangeEnd = 193272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpBezier(Transform source, Func<Vector3> controlPosition, Func<Vector3> targetPosition, float duration, bool forceRotate = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controlPosition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetPosition);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceRotate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_LerpBezier_Protected_IEnumerator_Transform_Func_1_Vector3_Func_1_Vector3_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x001A02F8 File Offset: 0x0019E4F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193284, RefRangeEnd = 193287, XrefRangeStart = 193275, XrefRangeEnd = 193284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpBezierCubic(Transform source, Func<Vector3> control1Position, Func<Vector3> control2Position, Func<Vector3> targetPosition, float duration, bool forceRotate = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(control1Position);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(control2Position);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetPosition);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceRotate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_LerpBezierCubic_Protected_IEnumerator_Transform_Func_1_Vector3_Func_1_Vector3_Func_1_Vector3_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x001A039C File Offset: 0x0019E59C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193294, RefRangeEnd = 193295, XrefRangeStart = 193287, XrefRangeEnd = 193294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Homing(Transform source, Func<Vector3> targetPosition, float speed, float miniumAnglarSpeed, float maxinumAngularSpeed, float distanceOffset = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetPosition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref miniumAnglarSpeed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxinumAngularSpeed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_Homing_Protected_IEnumerator_Transform_Func_1_Vector3_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x001A0438 File Offset: 0x0019E638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193305, RefRangeEnd = 193306, XrefRangeStart = 193295, XrefRangeEnd = 193305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Homing(Transform source, Func<Vector3> targetPosition, Func<float> speed, Func<float> miniumAnglarSpeed, Func<float> maxinumAngularSpeed, float distanceOffset = 0.5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetPosition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(speed);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(miniumAnglarSpeed);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(maxinumAngularSpeed);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_Homing_Protected_IEnumerator_Transform_Func_1_Vector3_Func_1_Single_Func_1_Single_Func_1_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x001A04E0 File Offset: 0x0019E6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193321, RefRangeEnd = 193322, XrefRangeStart = 193306, XrefRangeEnd = 193321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopRotation(ref SpellExecutionContext spellExecutionContext, Transform source, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_StopRotation_Protected_Void_byref_SpellExecutionContext_Transform_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			spellExecutionContext = ((intPtr4 == 0) ? null : new SpellExecutionContext(intPtr4));
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x001A055C File Offset: 0x0019E75C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193341, RefRangeEnd = 193342, XrefRangeStart = 193322, XrefRangeEnd = 193341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRotation(ref SpellExecutionContext spellExecutionContext, Transform source, string label, float speed, Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_SetRotation_Protected_Void_byref_SpellExecutionContext_Transform_String_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			spellExecutionContext = ((intPtr4 == 0) ? null : new SpellExecutionContext(intPtr4));
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x001A05F4 File Offset: 0x0019E7F4
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 193350, RefRangeEnd = 193374, XrefRangeStart = 193342, XrefRangeEnd = 193350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetPlayerPosition(bool center = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetPlayerPosition_Public_Static_Vector3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x001A0634 File Offset: 0x0019E834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193392, RefRangeEnd = 193394, XrefRangeStart = 193374, XrefRangeEnd = 193392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Vector3> GetAllGuestsPosition(bool center = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetAllGuestsPosition_Protected_IEnumerable_1_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x001A0680 File Offset: 0x0019E880
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 193398, RefRangeEnd = 193408, XrefRangeStart = 193394, XrefRangeEnd = 193398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetFoodStoragePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetFoodStoragePosition_Protected_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x001A06BC File Offset: 0x0019E8BC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 193412, RefRangeEnd = 193420, XrefRangeStart = 193408, XrefRangeEnd = 193412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetBeverageStoragePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetBeverageStoragePosition_Protected_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x001A06F8 File Offset: 0x0019E8F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193424, RefRangeEnd = 193425, XrefRangeStart = 193420, XrefRangeEnd = 193424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlayerSpawnPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetPlayerSpawnPosition_Protected_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x001A0734 File Offset: 0x0019E934
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 193430, RefRangeEnd = 193442, XrefRangeStart = 193425, XrefRangeEnd = 193430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform GetPlayerTransform()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetPlayerTransform_Public_Static_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x001A0768 File Offset: 0x0019E968
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193445, RefRangeEnd = 193448, XrefRangeStart = 193442, XrefRangeEnd = 193445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetUIEffectTransformFront()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetUIEffectTransformFront_Protected_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x001A07A8 File Offset: 0x0019E9A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193451, RefRangeEnd = 193452, XrefRangeStart = 193448, XrefRangeEnd = 193451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetUIEffectTransformTop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetUIEffectTransformTop_Protected_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x001A07E8 File Offset: 0x0019E9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193452, XrefRangeEnd = 193455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetUIEffectTransformMiddle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetUIEffectTransformMiddle_Protected_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x001A0828 File Offset: 0x0019EA28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 193458, RefRangeEnd = 193462, XrefRangeStart = 193455, XrefRangeEnd = 193458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetUIEffectTransformBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetUIEffectTransformBack_Protected_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x001A0868 File Offset: 0x0019EA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193462, XrefRangeEnd = 193465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuffModule GetBuffModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetBuffModule_Protected_BuffModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuffModule>(intPtr3) : null;
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x001A08A8 File Offset: 0x0019EAA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 193468, RefRangeEnd = 193473, XrefRangeStart = 193465, XrefRangeEnd = 193468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestBuffMarkModule GetGuestBuffMarkModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetGuestBuffMarkModule_Protected_GuestBuffMarkModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestBuffMarkModule>(intPtr3) : null;
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x001A08E8 File Offset: 0x0019EAE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193475, RefRangeEnd = 193478, XrefRangeStart = 193473, XrefRangeEnd = 193475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetWorldToScreenPoint(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetWorldToScreenPoint_Protected_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x001A0934 File Offset: 0x0019EB34
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 193484, RefRangeEnd = 193494, XrefRangeStart = 193478, XrefRangeEnd = 193484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetGuestTable(int deskCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetGuestTable_Public_Static_Vector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x001A0974 File Offset: 0x0019EB74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193499, RefRangeEnd = 193501, XrefRangeStart = 193494, XrefRangeEnd = 193499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<GuestGroupController> GetAllSeatedGuestGroups()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetAllSeatedGuestGroups_Protected_IEnumerable_1_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<GuestGroupController>>(intPtr3) : null;
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x001A09B4 File Offset: 0x0019EBB4
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 193506, RefRangeEnd = 193540, XrefRangeStart = 193501, XrefRangeEnd = 193506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<GuestGroupController> GetAllActiveGuestGroups()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetAllActiveGuestGroups_Protected_IEnumerable_1_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<GuestGroupController>>(intPtr3) : null;
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x001A09F4 File Offset: 0x0019EBF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193543, RefRangeEnd = 193544, XrefRangeStart = 193540, XrefRangeEnd = 193543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetCookerTable(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetCookerTable_Protected_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x001A0A40 File Offset: 0x0019EC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193544, XrefRangeEnd = 193551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookController GetCookerController(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetCookerController_Protected_CookController_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr3) : null;
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x001A0A8C File Offset: 0x0019EC8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193590, RefRangeEnd = 193593, XrefRangeStart = 193551, XrefRangeEnd = 193590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Vector3> GetAllCookerTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetAllCookerTables_Protected_IEnumerable_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06004A0E RID: 18958 RVA: 0x001A0ACC File Offset: 0x0019ECCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193593, XrefRangeEnd = 193615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Vector3> GetAllTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetAllTables_Protected_IEnumerable_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06004A0F RID: 18959 RVA: 0x001A0B0C File Offset: 0x0019ED0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193615, XrefRangeEnd = 193651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<int, Vector3> GetAllTablesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetAllTablesData_Protected_Dictionary_2_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Vector3>>(intPtr3) : null;
		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x001A0B4C File Offset: 0x0019ED4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193651, XrefRangeEnd = 193686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Vector3> GetAllTablesExceptOne(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetAllTablesExceptOne_Protected_IEnumerable_1_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x001A0B98 File Offset: 0x0019ED98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193686, XrefRangeEnd = 193735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<int, Vector3> GetAllTablesDataExceptOne(int deskCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deskCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr_GetAllTablesDataExceptOne_Protected_Dictionary_2_Int32_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Vector3>>(intPtr3) : null;
		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x001A0BE4 File Offset: 0x0019EDE4
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpellBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x00025D87 File Offset: 0x00023F87
		public SpellBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x06004A14 RID: 18964 RVA: 0x001A0C20 File Offset: 0x0019EE20
		// (set) Token: 0x06004A15 RID: 18965 RVA: 0x00025D90 File Offset: 0x00023F90
		public unsafe static int DEFAULT_POSITIVE_SPELL_LANG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SpellBase.NativeFieldInfoPtr_DEFAULT_POSITIVE_SPELL_LANG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpellBase.NativeFieldInfoPtr_DEFAULT_POSITIVE_SPELL_LANG, (void*)(&value));
			}
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x06004A16 RID: 18966 RVA: 0x001A0C3C File Offset: 0x0019EE3C
		// (set) Token: 0x06004A17 RID: 18967 RVA: 0x00025D9E File Offset: 0x00023F9E
		public unsafe static int DEFAULT_NEGATIVE_SPELL_LANG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SpellBase.NativeFieldInfoPtr_DEFAULT_NEGATIVE_SPELL_LANG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpellBase.NativeFieldInfoPtr_DEFAULT_NEGATIVE_SPELL_LANG, (void*)(&value));
			}
		}

		// Token: 0x040032B7 RID: 12983
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_POSITIVE_SPELL_LANG;

		// Token: 0x040032B8 RID: 12984
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_NEGATIVE_SPELL_LANG;

		// Token: 0x040032B9 RID: 12985
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldProtectedByShield_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x040032BA RID: 12986
		private static readonly IntPtr NativeMethodInfoPtr_get_Manager_Protected_get_EventManager_0;

		// Token: 0x040032BB RID: 12987
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraBuffTime_Protected_get_Single_0;

		// Token: 0x040032BC RID: 12988
		private static readonly IntPtr NativeMethodInfoPtr_get_VirtualCamera_Private_get_CinemachineVirtualCamera_0;

		// Token: 0x040032BD RID: 12989
		private static readonly IntPtr NativeMethodInfoPtr_ShouldCallSpellDeclarationAuto_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x040032BE RID: 12990
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x040032BF RID: 12991
		private static readonly IntPtr NativeMethodInfoPtr_FinalBuffTime_Protected_Int32_Single_0;

		// Token: 0x040032C0 RID: 12992
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTimedBuff_Protected_Boolean_BuffType_Single_Action_1_Int32_BuffRegisterType_Int32_Action_1_Int32_Boolean_0;

		// Token: 0x040032C1 RID: 12993
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDelayed_Protected_Static_Void_Single_Action_0;

		// Token: 0x040032C2 RID: 12994
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDelayedForOneFrame_Protected_Static_Void_Action_0;

		// Token: 0x040032C3 RID: 12995
		private static readonly IntPtr NativeMethodInfoPtr_CallSpellDeclaration_Protected_IEnumerator_SpecialGuest_LanguageBase_Boolean_0;

		// Token: 0x040032C4 RID: 12996
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraShake_Protected_IEnumerator_Single_Single_Single_0;

		// Token: 0x040032C5 RID: 12997
		private static readonly IntPtr NativeMethodInfoPtr_SetCameraShake_Protected_Void_Single_0;

		// Token: 0x040032C6 RID: 12998
		private static readonly IntPtr NativeMethodInfoPtr_PlayAudio_Protected_Void_AudioClip_0;

		// Token: 0x040032C7 RID: 12999
		private static readonly IntPtr NativeMethodInfoPtr_PlayAudioDelayed_Protected_Void_AudioClip_Single_0;

		// Token: 0x040032C8 RID: 13000
		private static readonly IntPtr NativeMethodInfoPtr_PlayAudioDelayed_Protected_Void_DelayAudioClip_0;

		// Token: 0x040032C9 RID: 13001
		private static readonly IntPtr NativeMethodInfoPtr_PlayAudioLooped_Protected_Void_Object_LoopedBGMPackage_0;

		// Token: 0x040032CA RID: 13002
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPositiveSpell_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040032CB RID: 13003
		private static readonly IntPtr NativeMethodInfoPtr_SchedulePositiveBuffExecution_Public_Void_SpellExecutionContext_0;

		// Token: 0x040032CC RID: 13004
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePositiveBuffAsync_Public_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040032CD RID: 13005
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessPositiveBuff_Private_Boolean_SpellExecutionContext_0;

		// Token: 0x040032CE RID: 13006
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePositiveBuff_Private_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040032CF RID: 13007
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Abstract_Virtual_New_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040032D0 RID: 13008
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNegativeSpell_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040032D1 RID: 13009
		private static readonly IntPtr NativeMethodInfoPtr_TryDefendNegativeSpell_Protected_Boolean_0;

		// Token: 0x040032D2 RID: 13010
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessNegativeBuff_Private_Boolean_SpellExecutionContext_0;

		// Token: 0x040032D3 RID: 13011
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleNegativeBuffExecution_Public_Void_SpellExecutionContext_0;

		// Token: 0x040032D4 RID: 13012
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteNegativeBuffAsync_Public_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040032D5 RID: 13013
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteNegativeBuff_Private_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040032D6 RID: 13014
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Abstract_Virtual_New_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040032D7 RID: 13015
		private static readonly IntPtr NativeMethodInfoPtr_get_HasLeaveSpell_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040032D8 RID: 13016
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOnLeaveBuffExecution_Public_Void_SpellExecutionContext_0;

		// Token: 0x040032D9 RID: 13017
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteOnLeaveBuffAsync_Public_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040032DA RID: 13018
		private static readonly IntPtr NativeMethodInfoPtr_PreprocessOnLeaveBuff_Private_Boolean_SpellExecutionContext_0;

		// Token: 0x040032DB RID: 13019
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteOnLeaveBuff_Private_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040032DC RID: 13020
		private static readonly IntPtr NativeMethodInfoPtr_OnLeaveBuffExecute_Protected_Virtual_New_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040032DD RID: 13021
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateTimedC_Protected_IEnumerator_GameObject_Action_1_GameObject_Single_EffectLayerInfo_0;

		// Token: 0x040032DE RID: 13022
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateTimedC_Protected_IEnumerator_GameObject_Vector3_Single_0;

		// Token: 0x040032DF RID: 13023
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateTimedC_Protected_IEnumerator_GameObject_Vector3_Action_1_GameObject_Single_0;

		// Token: 0x040032E0 RID: 13024
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateTimedC_Protected_IEnumerator_GameObject_Transform_Action_1_GameObject_Single_0;

		// Token: 0x040032E1 RID: 13025
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Single_EffectLayerInfo_0;

		// Token: 0x040032E2 RID: 13026
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Action_1_GameObject_Single_EffectLayerInfo_0;

		// Token: 0x040032E3 RID: 13027
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Vector3_Single_0;

		// Token: 0x040032E4 RID: 13028
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Vector3_Action_1_GameObject_Single_EffectLayerInfo_0;

		// Token: 0x040032E5 RID: 13029
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateTimedN_Protected_GameObject_GameObject_Transform_Action_1_GameObject_Single_0;

		// Token: 0x040032E6 RID: 13030
		private static readonly IntPtr NativeMethodInfoPtr_GetSpellEffectParentTransform_Private_Transform_EffectLayerInfo_0;

		// Token: 0x040032E7 RID: 13031
		private static readonly IntPtr NativeMethodInfoPtr_LerpPosition_Protected_IEnumerator_Transform_Func_1_Vector3_Single_0;

		// Token: 0x040032E8 RID: 13032
		private static readonly IntPtr NativeMethodInfoPtr_LerpParabolic_Protected_IEnumerator_Transform_Func_1_Vector3_Single_Single_Boolean_0;

		// Token: 0x040032E9 RID: 13033
		private static readonly IntPtr NativeMethodInfoPtr_LerpBezier_Protected_IEnumerator_Transform_Func_1_Vector3_Func_1_Vector3_Single_Boolean_0;

		// Token: 0x040032EA RID: 13034
		private static readonly IntPtr NativeMethodInfoPtr_LerpBezierCubic_Protected_IEnumerator_Transform_Func_1_Vector3_Func_1_Vector3_Func_1_Vector3_Single_Boolean_0;

		// Token: 0x040032EB RID: 13035
		private static readonly IntPtr NativeMethodInfoPtr_Homing_Protected_IEnumerator_Transform_Func_1_Vector3_Single_Single_Single_Single_0;

		// Token: 0x040032EC RID: 13036
		private static readonly IntPtr NativeMethodInfoPtr_Homing_Protected_IEnumerator_Transform_Func_1_Vector3_Func_1_Single_Func_1_Single_Func_1_Single_Single_0;

		// Token: 0x040032ED RID: 13037
		private static readonly IntPtr NativeMethodInfoPtr_StopRotation_Protected_Void_byref_SpellExecutionContext_Transform_String_0;

		// Token: 0x040032EE RID: 13038
		private static readonly IntPtr NativeMethodInfoPtr_SetRotation_Protected_Void_byref_SpellExecutionContext_Transform_String_Single_Vector3_0;

		// Token: 0x040032EF RID: 13039
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerPosition_Public_Static_Vector3_Boolean_0;

		// Token: 0x040032F0 RID: 13040
		private static readonly IntPtr NativeMethodInfoPtr_GetAllGuestsPosition_Protected_IEnumerable_1_Vector3_Boolean_0;

		// Token: 0x040032F1 RID: 13041
		private static readonly IntPtr NativeMethodInfoPtr_GetFoodStoragePosition_Protected_Vector3_0;

		// Token: 0x040032F2 RID: 13042
		private static readonly IntPtr NativeMethodInfoPtr_GetBeverageStoragePosition_Protected_Vector3_0;

		// Token: 0x040032F3 RID: 13043
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerSpawnPosition_Protected_Vector3_0;

		// Token: 0x040032F4 RID: 13044
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerTransform_Public_Static_Transform_0;

		// Token: 0x040032F5 RID: 13045
		private static readonly IntPtr NativeMethodInfoPtr_GetUIEffectTransformFront_Protected_Transform_0;

		// Token: 0x040032F6 RID: 13046
		private static readonly IntPtr NativeMethodInfoPtr_GetUIEffectTransformTop_Protected_Transform_0;

		// Token: 0x040032F7 RID: 13047
		private static readonly IntPtr NativeMethodInfoPtr_GetUIEffectTransformMiddle_Protected_Transform_0;

		// Token: 0x040032F8 RID: 13048
		private static readonly IntPtr NativeMethodInfoPtr_GetUIEffectTransformBack_Protected_Transform_0;

		// Token: 0x040032F9 RID: 13049
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffModule_Protected_BuffModule_0;

		// Token: 0x040032FA RID: 13050
		private static readonly IntPtr NativeMethodInfoPtr_GetGuestBuffMarkModule_Protected_GuestBuffMarkModule_0;

		// Token: 0x040032FB RID: 13051
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldToScreenPoint_Protected_Vector3_Vector3_0;

		// Token: 0x040032FC RID: 13052
		private static readonly IntPtr NativeMethodInfoPtr_GetGuestTable_Public_Static_Vector3_Int32_0;

		// Token: 0x040032FD RID: 13053
		private static readonly IntPtr NativeMethodInfoPtr_GetAllSeatedGuestGroups_Protected_IEnumerable_1_GuestGroupController_0;

		// Token: 0x040032FE RID: 13054
		private static readonly IntPtr NativeMethodInfoPtr_GetAllActiveGuestGroups_Protected_IEnumerable_1_GuestGroupController_0;

		// Token: 0x040032FF RID: 13055
		private static readonly IntPtr NativeMethodInfoPtr_GetCookerTable_Protected_Vector3_Int32_0;

		// Token: 0x04003300 RID: 13056
		private static readonly IntPtr NativeMethodInfoPtr_GetCookerController_Protected_CookController_Int32_0;

		// Token: 0x04003301 RID: 13057
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCookerTables_Protected_IEnumerable_1_Vector3_0;

		// Token: 0x04003302 RID: 13058
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTables_Protected_IEnumerable_1_Vector3_0;

		// Token: 0x04003303 RID: 13059
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTablesData_Protected_Dictionary_2_Int32_Vector3_0;

		// Token: 0x04003304 RID: 13060
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTablesExceptOne_Protected_IEnumerable_1_Vector3_Int32_0;

		// Token: 0x04003305 RID: 13061
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTablesDataExceptOne_Protected_Dictionary_2_Int32_Vector3_Int32_0;

		// Token: 0x04003306 RID: 13062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000ACF RID: 2767
		[Serializable]
		public sealed class DelayAudioClip : ValueType
		{
			// Token: 0x0600CE81 RID: 52865 RVA: 0x0032DDF8 File Offset: 0x0032BFF8
			// Note: this type is marked as 'beforefieldinit'.
			static DelayAudioClip()
			{
				Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "DelayAudioClip");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr);
				SpellBase.DelayAudioClip.NativeFieldInfoPtr_audioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, "audioClip");
				SpellBase.DelayAudioClip.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, "delay");
			}

			// Token: 0x0600CE82 RID: 52866 RVA: 0x0006E871 File Offset: 0x0006CA71
			public DelayAudioClip(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CE83 RID: 52867 RVA: 0x0006E87A File Offset: 0x0006CA7A
			public DelayAudioClip() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr))
			{
			}

			// Token: 0x1700431C RID: 17180
			// (get) Token: 0x0600CE84 RID: 52868 RVA: 0x0032DE4C File Offset: 0x0032C04C
			// (set) Token: 0x0600CE85 RID: 52869 RVA: 0x0006E88C File Offset: 0x0006CA8C
			public unsafe AudioClip audioClip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.DelayAudioClip.NativeFieldInfoPtr_audioClip);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.DelayAudioClip.NativeFieldInfoPtr_audioClip), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700431D RID: 17181
			// (get) Token: 0x0600CE86 RID: 52870 RVA: 0x0032DE7C File Offset: 0x0032C07C
			// (set) Token: 0x0600CE87 RID: 52871 RVA: 0x0006E8AB File Offset: 0x0006CAAB
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.DelayAudioClip.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.DelayAudioClip.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x040084E3 RID: 34019
			private static readonly IntPtr NativeFieldInfoPtr_audioClip;

			// Token: 0x040084E4 RID: 34020
			private static readonly IntPtr NativeFieldInfoPtr_delay;
		}

		// Token: 0x02000AD0 RID: 2768
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE88 RID: 52872 RVA: 0x0032DEA4 File Offset: 0x0032C0A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0>.NativeClassPtr);
				SpellBase.__c__DisplayClass14_0.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0>.NativeClassPtr, "delay");
				SpellBase.__c__DisplayClass14_0.NativeFieldInfoPtr_onDelayEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0>.NativeClassPtr, "onDelayEndCallback");
				SpellBase.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0>.NativeClassPtr, 100678050);
				SpellBase.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0>.NativeClassPtr, 100678051);
			}

			// Token: 0x0600CE89 RID: 52873 RVA: 0x0032DF20 File Offset: 0x0032C120
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE8A RID: 52874 RVA: 0x0032DF5C File Offset: 0x0032C15C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191914, XrefRangeEnd = 191919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CE8B RID: 52875 RVA: 0x0006E8C6 File Offset: 0x0006CAC6
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700431E RID: 17182
			// (get) Token: 0x0600CE8C RID: 52876 RVA: 0x0032DF9C File Offset: 0x0032C19C
			// (set) Token: 0x0600CE8D RID: 52877 RVA: 0x0006E8CF File Offset: 0x0006CACF
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass14_0.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass14_0.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x1700431F RID: 17183
			// (get) Token: 0x0600CE8E RID: 52878 RVA: 0x0032DFC4 File Offset: 0x0032C1C4
			// (set) Token: 0x0600CE8F RID: 52879 RVA: 0x0006E8EA File Offset: 0x0006CAEA
			public unsafe Action onDelayEndCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass14_0.NativeFieldInfoPtr_onDelayEndCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass14_0.NativeFieldInfoPtr_onDelayEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084E5 RID: 34021
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x040084E6 RID: 34022
			private static readonly IntPtr NativeFieldInfoPtr_onDelayEndCallback;

			// Token: 0x040084E7 RID: 34023
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084E8 RID: 34024
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02001019 RID: 4121
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass14_0+<<ExecuteDelayed>g__OnDelay|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011A1E RID: 72222 RVA: 0x0040AFD8 File Offset: 0x004091D8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0>.NativeClassPtr, "<<ExecuteDelayed>g__OnDelay|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678052);
					SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678053);
					SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678054);
					SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678055);
					SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678056);
					SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678057);
				}

				// Token: 0x06011A1F RID: 72223 RVA: 0x0040B0B8 File Offset: 0x004092B8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A20 RID: 72224 RVA: 0x0040B100 File Offset: 0x00409300
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A21 RID: 72225 RVA: 0x0040B134 File Offset: 0x00409334
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191903, XrefRangeEnd = 191908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005BB4 RID: 23476
				// (get) Token: 0x06011A22 RID: 72226 RVA: 0x0040B170 File Offset: 0x00409370
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A23 RID: 72227 RVA: 0x0040B1B0 File Offset: 0x004093B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191908, XrefRangeEnd = 191914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005BB5 RID: 23477
				// (get) Token: 0x06011A24 RID: 72228 RVA: 0x0040B1E4 File Offset: 0x004093E4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A25 RID: 72229 RVA: 0x00099483 File Offset: 0x00097683
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BB1 RID: 23473
				// (get) Token: 0x06011A26 RID: 72230 RVA: 0x0040B224 File Offset: 0x00409424
				// (set) Token: 0x06011A27 RID: 72231 RVA: 0x0009948C File Offset: 0x0009768C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005BB2 RID: 23474
				// (get) Token: 0x06011A28 RID: 72232 RVA: 0x0040B24C File Offset: 0x0040944C
				// (set) Token: 0x06011A29 RID: 72233 RVA: 0x000994A7 File Offset: 0x000976A7
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BB3 RID: 23475
				// (get) Token: 0x06011A2A RID: 72234 RVA: 0x0040B27C File Offset: 0x0040947C
				// (set) Token: 0x06011A2B RID: 72235 RVA: 0x000994C6 File Offset: 0x000976C6
				public unsafe SpellBase.__c__DisplayClass14_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase.__c__DisplayClass14_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B242 RID: 45634
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B243 RID: 45635
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B244 RID: 45636
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B245 RID: 45637
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B246 RID: 45638
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B247 RID: 45639
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B248 RID: 45640
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B249 RID: 45641
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B24A RID: 45642
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AD1 RID: 2769
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE90 RID: 52880 RVA: 0x0032DFF4 File Offset: 0x0032C1F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0>.NativeClassPtr);
				SpellBase.__c__DisplayClass15_0.NativeFieldInfoPtr_onDelayEndCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0>.NativeClassPtr, "onDelayEndCallback");
				SpellBase.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0>.NativeClassPtr, 100678058);
				SpellBase.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0>.NativeClassPtr, 100678059);
			}

			// Token: 0x0600CE91 RID: 52881 RVA: 0x0032E05C File Offset: 0x0032C25C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE92 RID: 52882 RVA: 0x0032E098 File Offset: 0x0032C298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191926, XrefRangeEnd = 191931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CE93 RID: 52883 RVA: 0x0006E909 File Offset: 0x0006CB09
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004320 RID: 17184
			// (get) Token: 0x0600CE94 RID: 52884 RVA: 0x0032E0D8 File Offset: 0x0032C2D8
			// (set) Token: 0x0600CE95 RID: 52885 RVA: 0x0006E912 File Offset: 0x0006CB12
			public unsafe Action onDelayEndCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass15_0.NativeFieldInfoPtr_onDelayEndCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass15_0.NativeFieldInfoPtr_onDelayEndCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084E9 RID: 34025
			private static readonly IntPtr NativeFieldInfoPtr_onDelayEndCallback;

			// Token: 0x040084EA RID: 34026
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084EB RID: 34027
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200101A RID: 4122
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass15_0+<<ExecuteDelayedForOneFrame>g__OnDelay|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011A2C RID: 72236 RVA: 0x0040B2AC File Offset: 0x004094AC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0>.NativeClassPtr, "<<ExecuteDelayedForOneFrame>g__OnDelay|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678060);
					SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678061);
					SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678062);
					SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678063);
					SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678064);
					SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678065);
				}

				// Token: 0x06011A2D RID: 72237 RVA: 0x0040B38C File Offset: 0x0040958C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A2E RID: 72238 RVA: 0x0040B3D4 File Offset: 0x004095D4
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A2F RID: 72239 RVA: 0x0040B408 File Offset: 0x00409608
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191919, XrefRangeEnd = 191920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005BB9 RID: 23481
				// (get) Token: 0x06011A30 RID: 72240 RVA: 0x0040B444 File Offset: 0x00409644
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A31 RID: 72241 RVA: 0x0040B484 File Offset: 0x00409684
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191920, XrefRangeEnd = 191926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005BBA RID: 23482
				// (get) Token: 0x06011A32 RID: 72242 RVA: 0x0040B4B8 File Offset: 0x004096B8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A33 RID: 72243 RVA: 0x000994E5 File Offset: 0x000976E5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BB6 RID: 23478
				// (get) Token: 0x06011A34 RID: 72244 RVA: 0x0040B4F8 File Offset: 0x004096F8
				// (set) Token: 0x06011A35 RID: 72245 RVA: 0x000994EE File Offset: 0x000976EE
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005BB7 RID: 23479
				// (get) Token: 0x06011A36 RID: 72246 RVA: 0x0040B520 File Offset: 0x00409720
				// (set) Token: 0x06011A37 RID: 72247 RVA: 0x00099509 File Offset: 0x00097709
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BB8 RID: 23480
				// (get) Token: 0x06011A38 RID: 72248 RVA: 0x0040B550 File Offset: 0x00409750
				// (set) Token: 0x06011A39 RID: 72249 RVA: 0x00099528 File Offset: 0x00097728
				public unsafe SpellBase.__c__DisplayClass15_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase.__c__DisplayClass15_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B24B RID: 45643
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B24C RID: 45644
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B24D RID: 45645
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B24E RID: 45646
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B24F RID: 45647
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B250 RID: 45648
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B251 RID: 45649
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B252 RID: 45650
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B253 RID: 45651
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AD2 RID: 2770
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<CallSpellDeclaration>d__16")]
		public sealed class _CallSpellDeclaration_d__16 : Il2CppSystem.Object
		{
			// Token: 0x0600CE96 RID: 52886 RVA: 0x0032E108 File Offset: 0x0032C308
			// Note: this type is marked as 'beforefieldinit'.
			static _CallSpellDeclaration_d__16()
			{
				Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<CallSpellDeclaration>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr);
				SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr, "<>1__state");
				SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr, "<>2__current");
				SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr, "<>4__this");
				SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr_guestData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr, "guestData");
				SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr, "text");
				SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr_isPositiveSpellCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr, "isPositiveSpellCard");
				SpellBase._CallSpellDeclaration_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr, 100678066);
				SpellBase._CallSpellDeclaration_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr, 100678067);
				SpellBase._CallSpellDeclaration_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr, 100678068);
				SpellBase._CallSpellDeclaration_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr, 100678069);
				SpellBase._CallSpellDeclaration_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr, 100678070);
				SpellBase._CallSpellDeclaration_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr, 100678071);
			}

			// Token: 0x0600CE97 RID: 52887 RVA: 0x0032E224 File Offset: 0x0032C424
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CallSpellDeclaration_d__16(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._CallSpellDeclaration_d__16>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._CallSpellDeclaration_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE98 RID: 52888 RVA: 0x0032E26C File Offset: 0x0032C46C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._CallSpellDeclaration_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE99 RID: 52889 RVA: 0x0032E2A0 File Offset: 0x0032C4A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191931, XrefRangeEnd = 191936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._CallSpellDeclaration_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004327 RID: 17191
			// (get) Token: 0x0600CE9A RID: 52890 RVA: 0x0032E2DC File Offset: 0x0032C4DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._CallSpellDeclaration_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CE9B RID: 52891 RVA: 0x0032E31C File Offset: 0x0032C51C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191936, XrefRangeEnd = 191942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._CallSpellDeclaration_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004328 RID: 17192
			// (get) Token: 0x0600CE9C RID: 52892 RVA: 0x0032E350 File Offset: 0x0032C550
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._CallSpellDeclaration_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CE9D RID: 52893 RVA: 0x0006E931 File Offset: 0x0006CB31
			public _CallSpellDeclaration_d__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004321 RID: 17185
			// (get) Token: 0x0600CE9E RID: 52894 RVA: 0x0032E390 File Offset: 0x0032C590
			// (set) Token: 0x0600CE9F RID: 52895 RVA: 0x0006E93A File Offset: 0x0006CB3A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004322 RID: 17186
			// (get) Token: 0x0600CEA0 RID: 52896 RVA: 0x0032E3B8 File Offset: 0x0032C5B8
			// (set) Token: 0x0600CEA1 RID: 52897 RVA: 0x0006E955 File Offset: 0x0006CB55
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004323 RID: 17187
			// (get) Token: 0x0600CEA2 RID: 52898 RVA: 0x0032E3E8 File Offset: 0x0032C5E8
			// (set) Token: 0x0600CEA3 RID: 52899 RVA: 0x0006E974 File Offset: 0x0006CB74
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004324 RID: 17188
			// (get) Token: 0x0600CEA4 RID: 52900 RVA: 0x0032E418 File Offset: 0x0032C618
			// (set) Token: 0x0600CEA5 RID: 52901 RVA: 0x0006E993 File Offset: 0x0006CB93
			public unsafe SpecialGuest guestData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr_guestData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr_guestData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004325 RID: 17189
			// (get) Token: 0x0600CEA6 RID: 52902 RVA: 0x0032E448 File Offset: 0x0032C648
			// (set) Token: 0x0600CEA7 RID: 52903 RVA: 0x0006E9B2 File Offset: 0x0006CBB2
			public unsafe LanguageBase text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr_text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004326 RID: 17190
			// (get) Token: 0x0600CEA8 RID: 52904 RVA: 0x0032E478 File Offset: 0x0032C678
			// (set) Token: 0x0600CEA9 RID: 52905 RVA: 0x0006E9D1 File Offset: 0x0006CBD1
			public unsafe bool isPositiveSpellCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr_isPositiveSpellCard);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._CallSpellDeclaration_d__16.NativeFieldInfoPtr_isPositiveSpellCard)) = value;
				}
			}

			// Token: 0x040084EC RID: 34028
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040084ED RID: 34029
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040084EE RID: 34030
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040084EF RID: 34031
			private static readonly IntPtr NativeFieldInfoPtr_guestData;

			// Token: 0x040084F0 RID: 34032
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x040084F1 RID: 34033
			private static readonly IntPtr NativeFieldInfoPtr_isPositiveSpellCard;

			// Token: 0x040084F2 RID: 34034
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040084F3 RID: 34035
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084F4 RID: 34036
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040084F5 RID: 34037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040084F6 RID: 34038
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084F7 RID: 34039
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AD3 RID: 2771
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<SetCameraShake>d__17")]
		public sealed class _SetCameraShake_d__17 : Il2CppSystem.Object
		{
			// Token: 0x0600CEAA RID: 52906 RVA: 0x0032E4A0 File Offset: 0x0032C6A0
			// Note: this type is marked as 'beforefieldinit'.
			static _SetCameraShake_d__17()
			{
				Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<SetCameraShake>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr);
				SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr, "<>1__state");
				SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr, "<>2__current");
				SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr, "amplitude");
				SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr, "duration");
				SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr, "fadeTime");
				SpellBase._SetCameraShake_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr, 100678072);
				SpellBase._SetCameraShake_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr, 100678073);
				SpellBase._SetCameraShake_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr, 100678074);
				SpellBase._SetCameraShake_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr, 100678075);
				SpellBase._SetCameraShake_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr, 100678076);
				SpellBase._SetCameraShake_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr, 100678077);
			}

			// Token: 0x0600CEAB RID: 52907 RVA: 0x0032E5A8 File Offset: 0x0032C7A8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetCameraShake_d__17(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._SetCameraShake_d__17>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._SetCameraShake_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEAC RID: 52908 RVA: 0x0032E5F0 File Offset: 0x0032C7F0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._SetCameraShake_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEAD RID: 52909 RVA: 0x0032E624 File Offset: 0x0032C824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191942, XrefRangeEnd = 191951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._SetCameraShake_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700432E RID: 17198
			// (get) Token: 0x0600CEAE RID: 52910 RVA: 0x0032E660 File Offset: 0x0032C860
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._SetCameraShake_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CEAF RID: 52911 RVA: 0x0032E6A0 File Offset: 0x0032C8A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191951, XrefRangeEnd = 191957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._SetCameraShake_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700432F RID: 17199
			// (get) Token: 0x0600CEB0 RID: 52912 RVA: 0x0032E6D4 File Offset: 0x0032C8D4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._SetCameraShake_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CEB1 RID: 52913 RVA: 0x0006E9EC File Offset: 0x0006CBEC
			public _SetCameraShake_d__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004329 RID: 17193
			// (get) Token: 0x0600CEB2 RID: 52914 RVA: 0x0032E714 File Offset: 0x0032C914
			// (set) Token: 0x0600CEB3 RID: 52915 RVA: 0x0006E9F5 File Offset: 0x0006CBF5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700432A RID: 17194
			// (get) Token: 0x0600CEB4 RID: 52916 RVA: 0x0032E73C File Offset: 0x0032C93C
			// (set) Token: 0x0600CEB5 RID: 52917 RVA: 0x0006EA10 File Offset: 0x0006CC10
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700432B RID: 17195
			// (get) Token: 0x0600CEB6 RID: 52918 RVA: 0x0032E76C File Offset: 0x0032C96C
			// (set) Token: 0x0600CEB7 RID: 52919 RVA: 0x0006EA2F File Offset: 0x0006CC2F
			public unsafe float amplitude
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr_amplitude);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr_amplitude)) = value;
				}
			}

			// Token: 0x1700432C RID: 17196
			// (get) Token: 0x0600CEB8 RID: 52920 RVA: 0x0032E794 File Offset: 0x0032C994
			// (set) Token: 0x0600CEB9 RID: 52921 RVA: 0x0006EA4A File Offset: 0x0006CC4A
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x1700432D RID: 17197
			// (get) Token: 0x0600CEBA RID: 52922 RVA: 0x0032E7BC File Offset: 0x0032C9BC
			// (set) Token: 0x0600CEBB RID: 52923 RVA: 0x0006EA65 File Offset: 0x0006CC65
			public unsafe float fadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._SetCameraShake_d__17.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x040084F8 RID: 34040
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040084F9 RID: 34041
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040084FA RID: 34042
			private static readonly IntPtr NativeFieldInfoPtr_amplitude;

			// Token: 0x040084FB RID: 34043
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x040084FC RID: 34044
			private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x040084FD RID: 34045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040084FE RID: 34046
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084FF RID: 34047
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008500 RID: 34048
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008501 RID: 34049
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008502 RID: 34050
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AD4 RID: 2772
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CEBC RID: 52924 RVA: 0x0032E7E4 File Offset: 0x0032C9E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0>.NativeClassPtr);
				SpellBase.__c__DisplayClass20_0.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0>.NativeClassPtr, "offset");
				SpellBase.__c__DisplayClass20_0.NativeFieldInfoPtr_thisAudioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0>.NativeClassPtr, "thisAudioClip");
				SpellBase.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0>.NativeClassPtr, 100678078);
				SpellBase.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0>.NativeClassPtr, 100678079);
			}

			// Token: 0x0600CEBD RID: 52925 RVA: 0x0032E860 File Offset: 0x0032CA60
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEBE RID: 52926 RVA: 0x0032E89C File Offset: 0x0032CA9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191969, XrefRangeEnd = 191974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CEBF RID: 52927 RVA: 0x0006EA80 File Offset: 0x0006CC80
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004330 RID: 17200
			// (get) Token: 0x0600CEC0 RID: 52928 RVA: 0x0032E8DC File Offset: 0x0032CADC
			// (set) Token: 0x0600CEC1 RID: 52929 RVA: 0x0006EA89 File Offset: 0x0006CC89
			public unsafe float offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass20_0.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass20_0.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x17004331 RID: 17201
			// (get) Token: 0x0600CEC2 RID: 52930 RVA: 0x0032E904 File Offset: 0x0032CB04
			// (set) Token: 0x0600CEC3 RID: 52931 RVA: 0x0006EAA4 File Offset: 0x0006CCA4
			public unsafe AudioClip thisAudioClip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass20_0.NativeFieldInfoPtr_thisAudioClip);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass20_0.NativeFieldInfoPtr_thisAudioClip), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008503 RID: 34051
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x04008504 RID: 34052
			private static readonly IntPtr NativeFieldInfoPtr_thisAudioClip;

			// Token: 0x04008505 RID: 34053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008506 RID: 34054
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200101B RID: 4123
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass20_0+<<PlayAudioDelayed>g__Delay|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011A3A RID: 72250 RVA: 0x0040B580 File Offset: 0x00409780
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0>.NativeClassPtr, "<<PlayAudioDelayed>g__Delay|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678080);
					SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678081);
					SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678082);
					SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678083);
					SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678084);
					SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678085);
				}

				// Token: 0x06011A3B RID: 72251 RVA: 0x0040B660 File Offset: 0x00409860
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A3C RID: 72252 RVA: 0x0040B6A8 File Offset: 0x004098A8
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A3D RID: 72253 RVA: 0x0040B6DC File Offset: 0x004098DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191957, XrefRangeEnd = 191963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005BBE RID: 23486
				// (get) Token: 0x06011A3E RID: 72254 RVA: 0x0040B718 File Offset: 0x00409918
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A3F RID: 72255 RVA: 0x0040B758 File Offset: 0x00409958
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191963, XrefRangeEnd = 191969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005BBF RID: 23487
				// (get) Token: 0x06011A40 RID: 72256 RVA: 0x0040B78C File Offset: 0x0040998C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A41 RID: 72257 RVA: 0x00099547 File Offset: 0x00097747
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BBB RID: 23483
				// (get) Token: 0x06011A42 RID: 72258 RVA: 0x0040B7CC File Offset: 0x004099CC
				// (set) Token: 0x06011A43 RID: 72259 RVA: 0x00099550 File Offset: 0x00097750
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005BBC RID: 23484
				// (get) Token: 0x06011A44 RID: 72260 RVA: 0x0040B7F4 File Offset: 0x004099F4
				// (set) Token: 0x06011A45 RID: 72261 RVA: 0x0009956B File Offset: 0x0009776B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BBD RID: 23485
				// (get) Token: 0x06011A46 RID: 72262 RVA: 0x0040B824 File Offset: 0x00409A24
				// (set) Token: 0x06011A47 RID: 72263 RVA: 0x0009958A File Offset: 0x0009778A
				public unsafe SpellBase.__c__DisplayClass20_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase.__c__DisplayClass20_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B254 RID: 45652
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B255 RID: 45653
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B256 RID: 45654
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B257 RID: 45655
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B258 RID: 45656
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B259 RID: 45657
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B25A RID: 45658
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B25B RID: 45659
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B25C RID: 45660
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AD5 RID: 2773
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CEC4 RID: 52932 RVA: 0x0032E934 File Offset: 0x0032CB34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0>.NativeClassPtr);
				SpellBase.__c__DisplayClass26_0.NativeFieldInfoPtr_currentContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0>.NativeClassPtr, "currentContext");
				SpellBase.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				SpellBase.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0>.NativeClassPtr, 100678086);
				SpellBase.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0>.NativeClassPtr, 100678087);
			}

			// Token: 0x0600CEC5 RID: 52933 RVA: 0x0032E9B0 File Offset: 0x0032CBB0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEC6 RID: 52934 RVA: 0x0032E9EC File Offset: 0x0032CBEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191986, XrefRangeEnd = 191992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Action_PDM_0(Action onFinishCallback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CEC7 RID: 52935 RVA: 0x0006EAC3 File Offset: 0x0006CCC3
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004332 RID: 17202
			// (get) Token: 0x0600CEC8 RID: 52936 RVA: 0x0032EA3C File Offset: 0x0032CC3C
			// (set) Token: 0x0600CEC9 RID: 52937 RVA: 0x0006EACC File Offset: 0x0006CCCC
			public unsafe SpellExecutionContext currentContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass26_0.NativeFieldInfoPtr_currentContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass26_0.NativeFieldInfoPtr_currentContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004333 RID: 17203
			// (get) Token: 0x0600CECA RID: 52938 RVA: 0x0032EA6C File Offset: 0x0032CC6C
			// (set) Token: 0x0600CECB RID: 52939 RVA: 0x0006EAEB File Offset: 0x0006CCEB
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008507 RID: 34055
			private static readonly IntPtr NativeFieldInfoPtr_currentContext;

			// Token: 0x04008508 RID: 34056
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008509 RID: 34057
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400850A RID: 34058
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Action_PDM_0;

			// Token: 0x0200101C RID: 4124
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass26_0+<<SchedulePositiveBuffExecution>g__OnCurrentBuffExecute|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011A48 RID: 72264 RVA: 0x0040B854 File Offset: 0x00409A54
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique()
				{
					Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0>.NativeClassPtr, "<<SchedulePositiveBuffExecution>g__OnCurrentBuffExecute|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr);
					SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, "<>1__state");
					SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, "<>2__current");
					SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, "<>4__this");
					SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, "onFinishCallback");
					SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678088);
					SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678089);
					SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678090);
					SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678091);
					SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678092);
					SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678093);
				}

				// Token: 0x06011A49 RID: 72265 RVA: 0x0040B948 File Offset: 0x00409B48
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A4A RID: 72266 RVA: 0x0040B990 File Offset: 0x00409B90
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A4B RID: 72267 RVA: 0x0040B9C4 File Offset: 0x00409BC4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191974, XrefRangeEnd = 191980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005BC4 RID: 23492
				// (get) Token: 0x06011A4C RID: 72268 RVA: 0x0040BA00 File Offset: 0x00409C00
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A4D RID: 72269 RVA: 0x0040BA40 File Offset: 0x00409C40
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191980, XrefRangeEnd = 191986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005BC5 RID: 23493
				// (get) Token: 0x06011A4E RID: 72270 RVA: 0x0040BA74 File Offset: 0x00409C74
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A4F RID: 72271 RVA: 0x000995A9 File Offset: 0x000977A9
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BC0 RID: 23488
				// (get) Token: 0x06011A50 RID: 72272 RVA: 0x0040BAB4 File Offset: 0x00409CB4
				// (set) Token: 0x06011A51 RID: 72273 RVA: 0x000995B2 File Offset: 0x000977B2
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005BC1 RID: 23489
				// (get) Token: 0x06011A52 RID: 72274 RVA: 0x0040BADC File Offset: 0x00409CDC
				// (set) Token: 0x06011A53 RID: 72275 RVA: 0x000995CD File Offset: 0x000977CD
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BC2 RID: 23490
				// (get) Token: 0x06011A54 RID: 72276 RVA: 0x0040BB0C File Offset: 0x00409D0C
				// (set) Token: 0x06011A55 RID: 72277 RVA: 0x000995EC File Offset: 0x000977EC
				public unsafe SpellBase.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BC3 RID: 23491
				// (get) Token: 0x06011A56 RID: 72278 RVA: 0x0040BB3C File Offset: 0x00409D3C
				// (set) Token: 0x06011A57 RID: 72279 RVA: 0x0009960B File Offset: 0x0009780B
				public unsafe Action onFinishCallback
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr_onFinishCallback);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B25D RID: 45661
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B25E RID: 45662
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B25F RID: 45663
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B260 RID: 45664
				private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

				// Token: 0x0400B261 RID: 45665
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B262 RID: 45666
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B263 RID: 45667
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B264 RID: 45668
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B265 RID: 45669
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B266 RID: 45670
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AD6 RID: 2774
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<ExecutePositiveBuffAsync>d__27")]
		public sealed class _ExecutePositiveBuffAsync_d__27 : Il2CppSystem.Object
		{
			// Token: 0x0600CECC RID: 52940 RVA: 0x0032EA9C File Offset: 0x0032CC9C
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecutePositiveBuffAsync_d__27()
			{
				Il2CppClassPointerStore<SpellBase._ExecutePositiveBuffAsync_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<ExecutePositiveBuffAsync>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuffAsync_d__27>.NativeClassPtr);
				SpellBase._ExecutePositiveBuffAsync_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuffAsync_d__27>.NativeClassPtr, "<>1__state");
				SpellBase._ExecutePositiveBuffAsync_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuffAsync_d__27>.NativeClassPtr, "<>2__current");
				SpellBase._ExecutePositiveBuffAsync_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuffAsync_d__27>.NativeClassPtr, "<>4__this");
				SpellBase._ExecutePositiveBuffAsync_d__27.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuffAsync_d__27>.NativeClassPtr, "spellExecutionContext");
				SpellBase._ExecutePositiveBuffAsync_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuffAsync_d__27>.NativeClassPtr, 100678094);
				SpellBase._ExecutePositiveBuffAsync_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuffAsync_d__27>.NativeClassPtr, 100678095);
				SpellBase._ExecutePositiveBuffAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuffAsync_d__27>.NativeClassPtr, 100678096);
				SpellBase._ExecutePositiveBuffAsync_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuffAsync_d__27>.NativeClassPtr, 100678097);
				SpellBase._ExecutePositiveBuffAsync_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuffAsync_d__27>.NativeClassPtr, 100678098);
				SpellBase._ExecutePositiveBuffAsync_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuffAsync_d__27>.NativeClassPtr, 100678099);
			}

			// Token: 0x0600CECD RID: 52941 RVA: 0x0032EB90 File Offset: 0x0032CD90
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecutePositiveBuffAsync_d__27(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuffAsync_d__27>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecutePositiveBuffAsync_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CECE RID: 52942 RVA: 0x0032EBD8 File Offset: 0x0032CDD8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecutePositiveBuffAsync_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CECF RID: 52943 RVA: 0x0032EC0C File Offset: 0x0032CE0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191992, XrefRangeEnd = 192005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecutePositiveBuffAsync_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004338 RID: 17208
			// (get) Token: 0x0600CED0 RID: 52944 RVA: 0x0032EC48 File Offset: 0x0032CE48
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecutePositiveBuffAsync_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CED1 RID: 52945 RVA: 0x0032EC88 File Offset: 0x0032CE88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192005, XrefRangeEnd = 192011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecutePositiveBuffAsync_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004339 RID: 17209
			// (get) Token: 0x0600CED2 RID: 52946 RVA: 0x0032ECBC File Offset: 0x0032CEBC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecutePositiveBuffAsync_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CED3 RID: 52947 RVA: 0x0006EB0A File Offset: 0x0006CD0A
			public _ExecutePositiveBuffAsync_d__27(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004334 RID: 17204
			// (get) Token: 0x0600CED4 RID: 52948 RVA: 0x0032ECFC File Offset: 0x0032CEFC
			// (set) Token: 0x0600CED5 RID: 52949 RVA: 0x0006EB13 File Offset: 0x0006CD13
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuffAsync_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuffAsync_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004335 RID: 17205
			// (get) Token: 0x0600CED6 RID: 52950 RVA: 0x0032ED24 File Offset: 0x0032CF24
			// (set) Token: 0x0600CED7 RID: 52951 RVA: 0x0006EB2E File Offset: 0x0006CD2E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuffAsync_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuffAsync_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004336 RID: 17206
			// (get) Token: 0x0600CED8 RID: 52952 RVA: 0x0032ED54 File Offset: 0x0032CF54
			// (set) Token: 0x0600CED9 RID: 52953 RVA: 0x0006EB4D File Offset: 0x0006CD4D
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuffAsync_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuffAsync_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004337 RID: 17207
			// (get) Token: 0x0600CEDA RID: 52954 RVA: 0x0032ED84 File Offset: 0x0032CF84
			// (set) Token: 0x0600CEDB RID: 52955 RVA: 0x0006EB6C File Offset: 0x0006CD6C
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuffAsync_d__27.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuffAsync_d__27.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400850B RID: 34059
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400850C RID: 34060
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400850D RID: 34061
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400850E RID: 34062
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x0400850F RID: 34063
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008510 RID: 34064
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008511 RID: 34065
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008512 RID: 34066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008513 RID: 34067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008514 RID: 34068
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AD7 RID: 2775
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<ExecutePositiveBuff>d__29")]
		public sealed class _ExecutePositiveBuff_d__29 : Il2CppSystem.Object
		{
			// Token: 0x0600CEDC RID: 52956 RVA: 0x0032EDB4 File Offset: 0x0032CFB4
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecutePositiveBuff_d__29()
			{
				Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<ExecutePositiveBuff>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr);
				SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr, "<>1__state");
				SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr, "<>2__current");
				SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr, "spellExecutionContext");
				SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr, "<>4__this");
				SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr__currentContext_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr, "<currentContext>5__2");
				SpellBase._ExecutePositiveBuff_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr, 100678100);
				SpellBase._ExecutePositiveBuff_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr, 100678101);
				SpellBase._ExecutePositiveBuff_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr, 100678102);
				SpellBase._ExecutePositiveBuff_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr, 100678103);
				SpellBase._ExecutePositiveBuff_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr, 100678104);
				SpellBase._ExecutePositiveBuff_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr, 100678105);
			}

			// Token: 0x0600CEDD RID: 52957 RVA: 0x0032EEBC File Offset: 0x0032D0BC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecutePositiveBuff_d__29(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._ExecutePositiveBuff_d__29>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecutePositiveBuff_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEDE RID: 52958 RVA: 0x0032EF04 File Offset: 0x0032D104
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecutePositiveBuff_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEDF RID: 52959 RVA: 0x0032EF38 File Offset: 0x0032D138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192011, XrefRangeEnd = 192021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecutePositiveBuff_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700433F RID: 17215
			// (get) Token: 0x0600CEE0 RID: 52960 RVA: 0x0032EF74 File Offset: 0x0032D174
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecutePositiveBuff_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CEE1 RID: 52961 RVA: 0x0032EFB4 File Offset: 0x0032D1B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192021, XrefRangeEnd = 192027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecutePositiveBuff_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004340 RID: 17216
			// (get) Token: 0x0600CEE2 RID: 52962 RVA: 0x0032EFE8 File Offset: 0x0032D1E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecutePositiveBuff_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CEE3 RID: 52963 RVA: 0x0006EB8B File Offset: 0x0006CD8B
			public _ExecutePositiveBuff_d__29(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700433A RID: 17210
			// (get) Token: 0x0600CEE4 RID: 52964 RVA: 0x0032F028 File Offset: 0x0032D228
			// (set) Token: 0x0600CEE5 RID: 52965 RVA: 0x0006EB94 File Offset: 0x0006CD94
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700433B RID: 17211
			// (get) Token: 0x0600CEE6 RID: 52966 RVA: 0x0032F050 File Offset: 0x0032D250
			// (set) Token: 0x0600CEE7 RID: 52967 RVA: 0x0006EBAF File Offset: 0x0006CDAF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700433C RID: 17212
			// (get) Token: 0x0600CEE8 RID: 52968 RVA: 0x0032F080 File Offset: 0x0032D280
			// (set) Token: 0x0600CEE9 RID: 52969 RVA: 0x0006EBCE File Offset: 0x0006CDCE
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700433D RID: 17213
			// (get) Token: 0x0600CEEA RID: 52970 RVA: 0x0032F0B0 File Offset: 0x0032D2B0
			// (set) Token: 0x0600CEEB RID: 52971 RVA: 0x0006EBED File Offset: 0x0006CDED
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700433E RID: 17214
			// (get) Token: 0x0600CEEC RID: 52972 RVA: 0x0032F0E0 File Offset: 0x0032D2E0
			// (set) Token: 0x0600CEED RID: 52973 RVA: 0x0006EC0C File Offset: 0x0006CE0C
			public unsafe SpellExecutionContext _currentContext_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr__currentContext_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecutePositiveBuff_d__29.NativeFieldInfoPtr__currentContext_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008515 RID: 34069
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008516 RID: 34070
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008517 RID: 34071
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008518 RID: 34072
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008519 RID: 34073
			private static readonly IntPtr NativeFieldInfoPtr__currentContext_5__2;

			// Token: 0x0400851A RID: 34074
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400851B RID: 34075
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400851C RID: 34076
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400851D RID: 34077
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400851E RID: 34078
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400851F RID: 34079
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AD8 RID: 2776
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CEEE RID: 52974 RVA: 0x0032F110 File Offset: 0x0032D310
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0>.NativeClassPtr);
				SpellBase.__c__DisplayClass35_0.NativeFieldInfoPtr_currentContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0>.NativeClassPtr, "currentContext");
				SpellBase.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				SpellBase.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0>.NativeClassPtr, 100678106);
				SpellBase.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0>.NativeClassPtr, 100678107);
			}

			// Token: 0x0600CEEF RID: 52975 RVA: 0x0032F18C File Offset: 0x0032D38C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEF0 RID: 52976 RVA: 0x0032F1C8 File Offset: 0x0032D3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192039, XrefRangeEnd = 192045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Action_PDM_0(Action onFinishCallback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CEF1 RID: 52977 RVA: 0x0006EC2B File Offset: 0x0006CE2B
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004341 RID: 17217
			// (get) Token: 0x0600CEF2 RID: 52978 RVA: 0x0032F218 File Offset: 0x0032D418
			// (set) Token: 0x0600CEF3 RID: 52979 RVA: 0x0006EC34 File Offset: 0x0006CE34
			public unsafe SpellExecutionContext currentContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass35_0.NativeFieldInfoPtr_currentContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass35_0.NativeFieldInfoPtr_currentContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004342 RID: 17218
			// (get) Token: 0x0600CEF4 RID: 52980 RVA: 0x0032F248 File Offset: 0x0032D448
			// (set) Token: 0x0600CEF5 RID: 52981 RVA: 0x0006EC53 File Offset: 0x0006CE53
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008520 RID: 34080
			private static readonly IntPtr NativeFieldInfoPtr_currentContext;

			// Token: 0x04008521 RID: 34081
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008522 RID: 34082
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008523 RID: 34083
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Action_PDM_0;

			// Token: 0x0200101D RID: 4125
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass35_0+<<ScheduleNegativeBuffExecution>g__OnCurrentBuffExecute|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011A58 RID: 72280 RVA: 0x0040BB6C File Offset: 0x00409D6C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique()
				{
					Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0>.NativeClassPtr, "<<ScheduleNegativeBuffExecution>g__OnCurrentBuffExecute|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr);
					SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, "<>1__state");
					SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, "<>2__current");
					SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, "<>4__this");
					SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, "onFinishCallback");
					SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678108);
					SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678109);
					SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678110);
					SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678111);
					SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678112);
					SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678113);
				}

				// Token: 0x06011A59 RID: 72281 RVA: 0x0040BC60 File Offset: 0x00409E60
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A5A RID: 72282 RVA: 0x0040BCA8 File Offset: 0x00409EA8
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A5B RID: 72283 RVA: 0x0040BCDC File Offset: 0x00409EDC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192027, XrefRangeEnd = 192033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005BCA RID: 23498
				// (get) Token: 0x06011A5C RID: 72284 RVA: 0x0040BD18 File Offset: 0x00409F18
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A5D RID: 72285 RVA: 0x0040BD58 File Offset: 0x00409F58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192033, XrefRangeEnd = 192039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005BCB RID: 23499
				// (get) Token: 0x06011A5E RID: 72286 RVA: 0x0040BD8C File Offset: 0x00409F8C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A5F RID: 72287 RVA: 0x0009962A File Offset: 0x0009782A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BC6 RID: 23494
				// (get) Token: 0x06011A60 RID: 72288 RVA: 0x0040BDCC File Offset: 0x00409FCC
				// (set) Token: 0x06011A61 RID: 72289 RVA: 0x00099633 File Offset: 0x00097833
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005BC7 RID: 23495
				// (get) Token: 0x06011A62 RID: 72290 RVA: 0x0040BDF4 File Offset: 0x00409FF4
				// (set) Token: 0x06011A63 RID: 72291 RVA: 0x0009964E File Offset: 0x0009784E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BC8 RID: 23496
				// (get) Token: 0x06011A64 RID: 72292 RVA: 0x0040BE24 File Offset: 0x0040A024
				// (set) Token: 0x06011A65 RID: 72293 RVA: 0x0009966D File Offset: 0x0009786D
				public unsafe SpellBase.__c__DisplayClass35_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase.__c__DisplayClass35_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BC9 RID: 23497
				// (get) Token: 0x06011A66 RID: 72294 RVA: 0x0040BE54 File Offset: 0x0040A054
				// (set) Token: 0x06011A67 RID: 72295 RVA: 0x0009968C File Offset: 0x0009788C
				public unsafe Action onFinishCallback
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr_onFinishCallback);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B267 RID: 45671
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B268 RID: 45672
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B269 RID: 45673
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B26A RID: 45674
				private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

				// Token: 0x0400B26B RID: 45675
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B26C RID: 45676
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B26D RID: 45677
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B26E RID: 45678
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B26F RID: 45679
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B270 RID: 45680
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AD9 RID: 2777
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<ExecuteNegativeBuffAsync>d__36")]
		public sealed class _ExecuteNegativeBuffAsync_d__36 : Il2CppSystem.Object
		{
			// Token: 0x0600CEF6 RID: 52982 RVA: 0x0032F278 File Offset: 0x0032D478
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteNegativeBuffAsync_d__36()
			{
				Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuffAsync_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<ExecuteNegativeBuffAsync>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuffAsync_d__36>.NativeClassPtr);
				SpellBase._ExecuteNegativeBuffAsync_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuffAsync_d__36>.NativeClassPtr, "<>1__state");
				SpellBase._ExecuteNegativeBuffAsync_d__36.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuffAsync_d__36>.NativeClassPtr, "<>2__current");
				SpellBase._ExecuteNegativeBuffAsync_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuffAsync_d__36>.NativeClassPtr, "<>4__this");
				SpellBase._ExecuteNegativeBuffAsync_d__36.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuffAsync_d__36>.NativeClassPtr, "spellExecutionContext");
				SpellBase._ExecuteNegativeBuffAsync_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuffAsync_d__36>.NativeClassPtr, 100678114);
				SpellBase._ExecuteNegativeBuffAsync_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuffAsync_d__36>.NativeClassPtr, 100678115);
				SpellBase._ExecuteNegativeBuffAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuffAsync_d__36>.NativeClassPtr, 100678116);
				SpellBase._ExecuteNegativeBuffAsync_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuffAsync_d__36>.NativeClassPtr, 100678117);
				SpellBase._ExecuteNegativeBuffAsync_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuffAsync_d__36>.NativeClassPtr, 100678118);
				SpellBase._ExecuteNegativeBuffAsync_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuffAsync_d__36>.NativeClassPtr, 100678119);
			}

			// Token: 0x0600CEF7 RID: 52983 RVA: 0x0032F36C File Offset: 0x0032D56C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteNegativeBuffAsync_d__36(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuffAsync_d__36>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEF8 RID: 52984 RVA: 0x0032F3B4 File Offset: 0x0032D5B4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEF9 RID: 52985 RVA: 0x0032F3E8 File Offset: 0x0032D5E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192045, XrefRangeEnd = 192058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004347 RID: 17223
			// (get) Token: 0x0600CEFA RID: 52986 RVA: 0x0032F424 File Offset: 0x0032D624
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CEFB RID: 52987 RVA: 0x0032F464 File Offset: 0x0032D664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192058, XrefRangeEnd = 192064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004348 RID: 17224
			// (get) Token: 0x0600CEFC RID: 52988 RVA: 0x0032F498 File Offset: 0x0032D698
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CEFD RID: 52989 RVA: 0x0006EC72 File Offset: 0x0006CE72
			public _ExecuteNegativeBuffAsync_d__36(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004343 RID: 17219
			// (get) Token: 0x0600CEFE RID: 52990 RVA: 0x0032F4D8 File Offset: 0x0032D6D8
			// (set) Token: 0x0600CEFF RID: 52991 RVA: 0x0006EC7B File Offset: 0x0006CE7B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004344 RID: 17220
			// (get) Token: 0x0600CF00 RID: 52992 RVA: 0x0032F500 File Offset: 0x0032D700
			// (set) Token: 0x0600CF01 RID: 52993 RVA: 0x0006EC96 File Offset: 0x0006CE96
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004345 RID: 17221
			// (get) Token: 0x0600CF02 RID: 52994 RVA: 0x0032F530 File Offset: 0x0032D730
			// (set) Token: 0x0600CF03 RID: 52995 RVA: 0x0006ECB5 File Offset: 0x0006CEB5
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004346 RID: 17222
			// (get) Token: 0x0600CF04 RID: 52996 RVA: 0x0032F560 File Offset: 0x0032D760
			// (set) Token: 0x0600CF05 RID: 52997 RVA: 0x0006ECD4 File Offset: 0x0006CED4
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuffAsync_d__36.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008524 RID: 34084
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008525 RID: 34085
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008526 RID: 34086
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008527 RID: 34087
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008528 RID: 34088
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008529 RID: 34089
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400852A RID: 34090
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400852B RID: 34091
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400852C RID: 34092
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400852D RID: 34093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000ADA RID: 2778
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<ExecuteNegativeBuff>d__37")]
		public sealed class _ExecuteNegativeBuff_d__37 : Il2CppSystem.Object
		{
			// Token: 0x0600CF06 RID: 52998 RVA: 0x0032F590 File Offset: 0x0032D790
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteNegativeBuff_d__37()
			{
				Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<ExecuteNegativeBuff>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr);
				SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr, "<>1__state");
				SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr, "<>2__current");
				SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr, "spellExecutionContext");
				SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr, "<>4__this");
				SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr__currentContext_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr, "<currentContext>5__2");
				SpellBase._ExecuteNegativeBuff_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr, 100678120);
				SpellBase._ExecuteNegativeBuff_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr, 100678121);
				SpellBase._ExecuteNegativeBuff_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr, 100678122);
				SpellBase._ExecuteNegativeBuff_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr, 100678123);
				SpellBase._ExecuteNegativeBuff_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr, 100678124);
				SpellBase._ExecuteNegativeBuff_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr, 100678125);
			}

			// Token: 0x0600CF07 RID: 52999 RVA: 0x0032F698 File Offset: 0x0032D898
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteNegativeBuff_d__37(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._ExecuteNegativeBuff_d__37>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteNegativeBuff_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF08 RID: 53000 RVA: 0x0032F6E0 File Offset: 0x0032D8E0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteNegativeBuff_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF09 RID: 53001 RVA: 0x0032F714 File Offset: 0x0032D914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192064, XrefRangeEnd = 192072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteNegativeBuff_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700434E RID: 17230
			// (get) Token: 0x0600CF0A RID: 53002 RVA: 0x0032F750 File Offset: 0x0032D950
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteNegativeBuff_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF0B RID: 53003 RVA: 0x0032F790 File Offset: 0x0032D990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192072, XrefRangeEnd = 192078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteNegativeBuff_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700434F RID: 17231
			// (get) Token: 0x0600CF0C RID: 53004 RVA: 0x0032F7C4 File Offset: 0x0032D9C4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteNegativeBuff_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF0D RID: 53005 RVA: 0x0006ECF3 File Offset: 0x0006CEF3
			public _ExecuteNegativeBuff_d__37(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004349 RID: 17225
			// (get) Token: 0x0600CF0E RID: 53006 RVA: 0x0032F804 File Offset: 0x0032DA04
			// (set) Token: 0x0600CF0F RID: 53007 RVA: 0x0006ECFC File Offset: 0x0006CEFC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700434A RID: 17226
			// (get) Token: 0x0600CF10 RID: 53008 RVA: 0x0032F82C File Offset: 0x0032DA2C
			// (set) Token: 0x0600CF11 RID: 53009 RVA: 0x0006ED17 File Offset: 0x0006CF17
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700434B RID: 17227
			// (get) Token: 0x0600CF12 RID: 53010 RVA: 0x0032F85C File Offset: 0x0032DA5C
			// (set) Token: 0x0600CF13 RID: 53011 RVA: 0x0006ED36 File Offset: 0x0006CF36
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700434C RID: 17228
			// (get) Token: 0x0600CF14 RID: 53012 RVA: 0x0032F88C File Offset: 0x0032DA8C
			// (set) Token: 0x0600CF15 RID: 53013 RVA: 0x0006ED55 File Offset: 0x0006CF55
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700434D RID: 17229
			// (get) Token: 0x0600CF16 RID: 53014 RVA: 0x0032F8BC File Offset: 0x0032DABC
			// (set) Token: 0x0600CF17 RID: 53015 RVA: 0x0006ED74 File Offset: 0x0006CF74
			public unsafe SpellExecutionContext _currentContext_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr__currentContext_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteNegativeBuff_d__37.NativeFieldInfoPtr__currentContext_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400852E RID: 34094
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400852F RID: 34095
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008530 RID: 34096
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008531 RID: 34097
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008532 RID: 34098
			private static readonly IntPtr NativeFieldInfoPtr__currentContext_5__2;

			// Token: 0x04008533 RID: 34099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008534 RID: 34100
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008535 RID: 34101
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008536 RID: 34102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008537 RID: 34103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008538 RID: 34104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000ADB RID: 2779
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF18 RID: 53016 RVA: 0x0032F8EC File Offset: 0x0032DAEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0>.NativeClassPtr);
				SpellBase.__c__DisplayClass41_0.NativeFieldInfoPtr_currentContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0>.NativeClassPtr, "currentContext");
				SpellBase.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				SpellBase.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0>.NativeClassPtr, 100678126);
				SpellBase.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0>.NativeClassPtr, 100678127);
			}

			// Token: 0x0600CF19 RID: 53017 RVA: 0x0032F968 File Offset: 0x0032DB68
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF1A RID: 53018 RVA: 0x0032F9A4 File Offset: 0x0032DBA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192090, XrefRangeEnd = 192096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Action_PDM_0(Action onFinishCallback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onFinishCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CF1B RID: 53019 RVA: 0x0006ED93 File Offset: 0x0006CF93
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004350 RID: 17232
			// (get) Token: 0x0600CF1C RID: 53020 RVA: 0x0032F9F4 File Offset: 0x0032DBF4
			// (set) Token: 0x0600CF1D RID: 53021 RVA: 0x0006ED9C File Offset: 0x0006CF9C
			public unsafe SpellExecutionContext currentContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass41_0.NativeFieldInfoPtr_currentContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass41_0.NativeFieldInfoPtr_currentContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004351 RID: 17233
			// (get) Token: 0x0600CF1E RID: 53022 RVA: 0x0032FA24 File Offset: 0x0032DC24
			// (set) Token: 0x0600CF1F RID: 53023 RVA: 0x0006EDBB File Offset: 0x0006CFBB
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008539 RID: 34105
			private static readonly IntPtr NativeFieldInfoPtr_currentContext;

			// Token: 0x0400853A RID: 34106
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400853B RID: 34107
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400853C RID: 34108
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Action_PDM_0;

			// Token: 0x0200101E RID: 4126
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass41_0+<<ScheduleOnLeaveBuffExecution>g__OnCurrentBuffExecute|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011A68 RID: 72296 RVA: 0x0040BE84 File Offset: 0x0040A084
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique()
				{
					Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0>.NativeClassPtr, "<<ScheduleOnLeaveBuffExecution>g__OnCurrentBuffExecute|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr);
					SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, "<>1__state");
					SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, "<>2__current");
					SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, "<>4__this");
					SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr_onFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, "onFinishCallback");
					SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678128);
					SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678129);
					SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678130);
					SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678131);
					SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678132);
					SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr, 100678133);
				}

				// Token: 0x06011A69 RID: 72297 RVA: 0x0040BF78 File Offset: 0x0040A178
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A6A RID: 72298 RVA: 0x0040BFC0 File Offset: 0x0040A1C0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A6B RID: 72299 RVA: 0x0040BFF4 File Offset: 0x0040A1F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192078, XrefRangeEnd = 192084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005BD0 RID: 23504
				// (get) Token: 0x06011A6C RID: 72300 RVA: 0x0040C030 File Offset: 0x0040A230
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A6D RID: 72301 RVA: 0x0040C070 File Offset: 0x0040A270
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192084, XrefRangeEnd = 192090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005BD1 RID: 23505
				// (get) Token: 0x06011A6E RID: 72302 RVA: 0x0040C0A4 File Offset: 0x0040A2A4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A6F RID: 72303 RVA: 0x000996AB File Offset: 0x000978AB
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BCC RID: 23500
				// (get) Token: 0x06011A70 RID: 72304 RVA: 0x0040C0E4 File Offset: 0x0040A2E4
				// (set) Token: 0x06011A71 RID: 72305 RVA: 0x000996B4 File Offset: 0x000978B4
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005BCD RID: 23501
				// (get) Token: 0x06011A72 RID: 72306 RVA: 0x0040C10C File Offset: 0x0040A30C
				// (set) Token: 0x06011A73 RID: 72307 RVA: 0x000996CF File Offset: 0x000978CF
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BCE RID: 23502
				// (get) Token: 0x06011A74 RID: 72308 RVA: 0x0040C13C File Offset: 0x0040A33C
				// (set) Token: 0x06011A75 RID: 72309 RVA: 0x000996EE File Offset: 0x000978EE
				public unsafe SpellBase.__c__DisplayClass41_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase.__c__DisplayClass41_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BCF RID: 23503
				// (get) Token: 0x06011A76 RID: 72310 RVA: 0x0040C16C File Offset: 0x0040A36C
				// (set) Token: 0x06011A77 RID: 72311 RVA: 0x0009970D File Offset: 0x0009790D
				public unsafe Action onFinishCallback
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr_onFinishCallback);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAconObObUnique.NativeFieldInfoPtr_onFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B271 RID: 45681
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B272 RID: 45682
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B273 RID: 45683
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B274 RID: 45684
				private static readonly IntPtr NativeFieldInfoPtr_onFinishCallback;

				// Token: 0x0400B275 RID: 45685
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B276 RID: 45686
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B277 RID: 45687
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B278 RID: 45688
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B279 RID: 45689
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B27A RID: 45690
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000ADC RID: 2780
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<ExecuteOnLeaveBuffAsync>d__42")]
		public sealed class _ExecuteOnLeaveBuffAsync_d__42 : Il2CppSystem.Object
		{
			// Token: 0x0600CF20 RID: 53024 RVA: 0x0032FA54 File Offset: 0x0032DC54
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteOnLeaveBuffAsync_d__42()
			{
				Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuffAsync_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<ExecuteOnLeaveBuffAsync>d__42");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuffAsync_d__42>.NativeClassPtr);
				SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuffAsync_d__42>.NativeClassPtr, "<>1__state");
				SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuffAsync_d__42>.NativeClassPtr, "<>2__current");
				SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuffAsync_d__42>.NativeClassPtr, "<>4__this");
				SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuffAsync_d__42>.NativeClassPtr, "spellExecutionContext");
				SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuffAsync_d__42>.NativeClassPtr, 100678134);
				SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuffAsync_d__42>.NativeClassPtr, 100678135);
				SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuffAsync_d__42>.NativeClassPtr, 100678136);
				SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuffAsync_d__42>.NativeClassPtr, 100678137);
				SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuffAsync_d__42>.NativeClassPtr, 100678138);
				SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuffAsync_d__42>.NativeClassPtr, 100678139);
			}

			// Token: 0x0600CF21 RID: 53025 RVA: 0x0032FB48 File Offset: 0x0032DD48
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteOnLeaveBuffAsync_d__42(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuffAsync_d__42>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF22 RID: 53026 RVA: 0x0032FB90 File Offset: 0x0032DD90
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF23 RID: 53027 RVA: 0x0032FBC4 File Offset: 0x0032DDC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192096, XrefRangeEnd = 192103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004356 RID: 17238
			// (get) Token: 0x0600CF24 RID: 53028 RVA: 0x0032FC00 File Offset: 0x0032DE00
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF25 RID: 53029 RVA: 0x0032FC40 File Offset: 0x0032DE40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192103, XrefRangeEnd = 192109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004357 RID: 17239
			// (get) Token: 0x0600CF26 RID: 53030 RVA: 0x0032FC74 File Offset: 0x0032DE74
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF27 RID: 53031 RVA: 0x0006EDDA File Offset: 0x0006CFDA
			public _ExecuteOnLeaveBuffAsync_d__42(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004352 RID: 17234
			// (get) Token: 0x0600CF28 RID: 53032 RVA: 0x0032FCB4 File Offset: 0x0032DEB4
			// (set) Token: 0x0600CF29 RID: 53033 RVA: 0x0006EDE3 File Offset: 0x0006CFE3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004353 RID: 17235
			// (get) Token: 0x0600CF2A RID: 53034 RVA: 0x0032FCDC File Offset: 0x0032DEDC
			// (set) Token: 0x0600CF2B RID: 53035 RVA: 0x0006EDFE File Offset: 0x0006CFFE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004354 RID: 17236
			// (get) Token: 0x0600CF2C RID: 53036 RVA: 0x0032FD0C File Offset: 0x0032DF0C
			// (set) Token: 0x0600CF2D RID: 53037 RVA: 0x0006EE1D File Offset: 0x0006D01D
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004355 RID: 17237
			// (get) Token: 0x0600CF2E RID: 53038 RVA: 0x0032FD3C File Offset: 0x0032DF3C
			// (set) Token: 0x0600CF2F RID: 53039 RVA: 0x0006EE3C File Offset: 0x0006D03C
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuffAsync_d__42.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400853D RID: 34109
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400853E RID: 34110
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400853F RID: 34111
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008540 RID: 34112
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008541 RID: 34113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008542 RID: 34114
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008543 RID: 34115
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008544 RID: 34116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008545 RID: 34117
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008546 RID: 34118
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000ADD RID: 2781
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<ExecuteOnLeaveBuff>d__44")]
		public sealed class _ExecuteOnLeaveBuff_d__44 : Il2CppSystem.Object
		{
			// Token: 0x0600CF30 RID: 53040 RVA: 0x0032FD6C File Offset: 0x0032DF6C
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteOnLeaveBuff_d__44()
			{
				Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<ExecuteOnLeaveBuff>d__44");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr);
				SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr, "<>1__state");
				SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr, "<>2__current");
				SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr, "spellExecutionContext");
				SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr, "<>4__this");
				SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr__currentContext_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr, "<currentContext>5__2");
				SpellBase._ExecuteOnLeaveBuff_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr, 100678140);
				SpellBase._ExecuteOnLeaveBuff_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr, 100678141);
				SpellBase._ExecuteOnLeaveBuff_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr, 100678142);
				SpellBase._ExecuteOnLeaveBuff_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr, 100678143);
				SpellBase._ExecuteOnLeaveBuff_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr, 100678144);
				SpellBase._ExecuteOnLeaveBuff_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr, 100678145);
			}

			// Token: 0x0600CF31 RID: 53041 RVA: 0x0032FE74 File Offset: 0x0032E074
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteOnLeaveBuff_d__44(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._ExecuteOnLeaveBuff_d__44>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteOnLeaveBuff_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF32 RID: 53042 RVA: 0x0032FEBC File Offset: 0x0032E0BC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteOnLeaveBuff_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF33 RID: 53043 RVA: 0x0032FEF0 File Offset: 0x0032E0F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192109, XrefRangeEnd = 192113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteOnLeaveBuff_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700435D RID: 17245
			// (get) Token: 0x0600CF34 RID: 53044 RVA: 0x0032FF2C File Offset: 0x0032E12C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteOnLeaveBuff_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF35 RID: 53045 RVA: 0x0032FF6C File Offset: 0x0032E16C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192113, XrefRangeEnd = 192119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteOnLeaveBuff_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700435E RID: 17246
			// (get) Token: 0x0600CF36 RID: 53046 RVA: 0x0032FFA0 File Offset: 0x0032E1A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._ExecuteOnLeaveBuff_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF37 RID: 53047 RVA: 0x0006EE5B File Offset: 0x0006D05B
			public _ExecuteOnLeaveBuff_d__44(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004358 RID: 17240
			// (get) Token: 0x0600CF38 RID: 53048 RVA: 0x0032FFE0 File Offset: 0x0032E1E0
			// (set) Token: 0x0600CF39 RID: 53049 RVA: 0x0006EE64 File Offset: 0x0006D064
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004359 RID: 17241
			// (get) Token: 0x0600CF3A RID: 53050 RVA: 0x00330008 File Offset: 0x0032E208
			// (set) Token: 0x0600CF3B RID: 53051 RVA: 0x0006EE7F File Offset: 0x0006D07F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435A RID: 17242
			// (get) Token: 0x0600CF3C RID: 53052 RVA: 0x00330038 File Offset: 0x0032E238
			// (set) Token: 0x0600CF3D RID: 53053 RVA: 0x0006EE9E File Offset: 0x0006D09E
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435B RID: 17243
			// (get) Token: 0x0600CF3E RID: 53054 RVA: 0x00330068 File Offset: 0x0032E268
			// (set) Token: 0x0600CF3F RID: 53055 RVA: 0x0006EEBD File Offset: 0x0006D0BD
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435C RID: 17244
			// (get) Token: 0x0600CF40 RID: 53056 RVA: 0x00330098 File Offset: 0x0032E298
			// (set) Token: 0x0600CF41 RID: 53057 RVA: 0x0006EEDC File Offset: 0x0006D0DC
			public unsafe SpellExecutionContext _currentContext_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr__currentContext_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._ExecuteOnLeaveBuff_d__44.NativeFieldInfoPtr__currentContext_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008547 RID: 34119
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008548 RID: 34120
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008549 RID: 34121
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x0400854A RID: 34122
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400854B RID: 34123
			private static readonly IntPtr NativeFieldInfoPtr__currentContext_5__2;

			// Token: 0x0400854C RID: 34124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400854D RID: 34125
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400854E RID: 34126
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400854F RID: 34127
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008550 RID: 34128
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008551 RID: 34129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000ADE RID: 2782
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<OnLeaveBuffExecute>d__45")]
		public sealed class _OnLeaveBuffExecute_d__45 : Il2CppSystem.Object
		{
			// Token: 0x0600CF42 RID: 53058 RVA: 0x003300C8 File Offset: 0x0032E2C8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnLeaveBuffExecute_d__45()
			{
				Il2CppClassPointerStore<SpellBase._OnLeaveBuffExecute_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<OnLeaveBuffExecute>d__45");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._OnLeaveBuffExecute_d__45>.NativeClassPtr);
				SpellBase._OnLeaveBuffExecute_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._OnLeaveBuffExecute_d__45>.NativeClassPtr, "<>1__state");
				SpellBase._OnLeaveBuffExecute_d__45.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._OnLeaveBuffExecute_d__45>.NativeClassPtr, "<>2__current");
				SpellBase._OnLeaveBuffExecute_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._OnLeaveBuffExecute_d__45>.NativeClassPtr, 100678146);
				SpellBase._OnLeaveBuffExecute_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._OnLeaveBuffExecute_d__45>.NativeClassPtr, 100678147);
				SpellBase._OnLeaveBuffExecute_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._OnLeaveBuffExecute_d__45>.NativeClassPtr, 100678148);
				SpellBase._OnLeaveBuffExecute_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._OnLeaveBuffExecute_d__45>.NativeClassPtr, 100678149);
				SpellBase._OnLeaveBuffExecute_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._OnLeaveBuffExecute_d__45>.NativeClassPtr, 100678150);
				SpellBase._OnLeaveBuffExecute_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._OnLeaveBuffExecute_d__45>.NativeClassPtr, 100678151);
			}

			// Token: 0x0600CF43 RID: 53059 RVA: 0x00330194 File Offset: 0x0032E394
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnLeaveBuffExecute_d__45(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._OnLeaveBuffExecute_d__45>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._OnLeaveBuffExecute_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF44 RID: 53060 RVA: 0x003301DC File Offset: 0x0032E3DC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._OnLeaveBuffExecute_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF45 RID: 53061 RVA: 0x00330210 File Offset: 0x0032E410
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._OnLeaveBuffExecute_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004361 RID: 17249
			// (get) Token: 0x0600CF46 RID: 53062 RVA: 0x0033024C File Offset: 0x0032E44C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._OnLeaveBuffExecute_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF47 RID: 53063 RVA: 0x0033028C File Offset: 0x0032E48C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192119, XrefRangeEnd = 192125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._OnLeaveBuffExecute_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004362 RID: 17250
			// (get) Token: 0x0600CF48 RID: 53064 RVA: 0x003302C0 File Offset: 0x0032E4C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._OnLeaveBuffExecute_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF49 RID: 53065 RVA: 0x0006EEFB File Offset: 0x0006D0FB
			public _OnLeaveBuffExecute_d__45(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700435F RID: 17247
			// (get) Token: 0x0600CF4A RID: 53066 RVA: 0x00330300 File Offset: 0x0032E500
			// (set) Token: 0x0600CF4B RID: 53067 RVA: 0x0006EF04 File Offset: 0x0006D104
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._OnLeaveBuffExecute_d__45.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._OnLeaveBuffExecute_d__45.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004360 RID: 17248
			// (get) Token: 0x0600CF4C RID: 53068 RVA: 0x00330328 File Offset: 0x0032E528
			// (set) Token: 0x0600CF4D RID: 53069 RVA: 0x0006EF1F File Offset: 0x0006D11F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._OnLeaveBuffExecute_d__45.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._OnLeaveBuffExecute_d__45.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008552 RID: 34130
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008553 RID: 34131
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008554 RID: 34132
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008555 RID: 34133
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008556 RID: 34134
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008557 RID: 34135
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008558 RID: 34136
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008559 RID: 34137
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000ADF RID: 2783
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<InstantiateTimedC>d__46")]
		public sealed class _InstantiateTimedC_d__46 : Il2CppSystem.Object
		{
			// Token: 0x0600CF4E RID: 53070 RVA: 0x00330358 File Offset: 0x0032E558
			// Note: this type is marked as 'beforefieldinit'.
			static _InstantiateTimedC_d__46()
			{
				Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<InstantiateTimedC>d__46");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr);
				SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, "<>1__state");
				SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, "<>2__current");
				SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, "parent");
				SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, "<>4__this");
				SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr_effectLayerInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, "effectLayerInfo");
				SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr_objectProcessingCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, "objectProcessingCallback");
				SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, "duration");
				SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr__instance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, "<instance>5__2");
				SpellBase._InstantiateTimedC_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, 100678152);
				SpellBase._InstantiateTimedC_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, 100678153);
				SpellBase._InstantiateTimedC_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, 100678154);
				SpellBase._InstantiateTimedC_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, 100678155);
				SpellBase._InstantiateTimedC_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, 100678156);
				SpellBase._InstantiateTimedC_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr, 100678157);
			}

			// Token: 0x0600CF4F RID: 53071 RVA: 0x0033049C File Offset: 0x0032E69C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InstantiateTimedC_d__46(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__46>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF50 RID: 53072 RVA: 0x003304E4 File Offset: 0x0032E6E4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF51 RID: 53073 RVA: 0x00330518 File Offset: 0x0032E718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192125, XrefRangeEnd = 192138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700436B RID: 17259
			// (get) Token: 0x0600CF52 RID: 53074 RVA: 0x00330554 File Offset: 0x0032E754
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF53 RID: 53075 RVA: 0x00330594 File Offset: 0x0032E794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192138, XrefRangeEnd = 192144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700436C RID: 17260
			// (get) Token: 0x0600CF54 RID: 53076 RVA: 0x003305C8 File Offset: 0x0032E7C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF55 RID: 53077 RVA: 0x0006EF3E File Offset: 0x0006D13E
			public _InstantiateTimedC_d__46(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004363 RID: 17251
			// (get) Token: 0x0600CF56 RID: 53078 RVA: 0x00330608 File Offset: 0x0032E808
			// (set) Token: 0x0600CF57 RID: 53079 RVA: 0x0006EF47 File Offset: 0x0006D147
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004364 RID: 17252
			// (get) Token: 0x0600CF58 RID: 53080 RVA: 0x00330630 File Offset: 0x0032E830
			// (set) Token: 0x0600CF59 RID: 53081 RVA: 0x0006EF62 File Offset: 0x0006D162
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004365 RID: 17253
			// (get) Token: 0x0600CF5A RID: 53082 RVA: 0x00330660 File Offset: 0x0032E860
			// (set) Token: 0x0600CF5B RID: 53083 RVA: 0x0006EF81 File Offset: 0x0006D181
			public unsafe GameObject parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004366 RID: 17254
			// (get) Token: 0x0600CF5C RID: 53084 RVA: 0x00330690 File Offset: 0x0032E890
			// (set) Token: 0x0600CF5D RID: 53085 RVA: 0x0006EFA0 File Offset: 0x0006D1A0
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004367 RID: 17255
			// (get) Token: 0x0600CF5E RID: 53086 RVA: 0x003306C0 File Offset: 0x0032E8C0
			// (set) Token: 0x0600CF5F RID: 53087 RVA: 0x0006EFBF File Offset: 0x0006D1BF
			public unsafe EffectLayerInfo effectLayerInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr_effectLayerInfo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr_effectLayerInfo)) = value;
				}
			}

			// Token: 0x17004368 RID: 17256
			// (get) Token: 0x0600CF60 RID: 53088 RVA: 0x003306E8 File Offset: 0x0032E8E8
			// (set) Token: 0x0600CF61 RID: 53089 RVA: 0x0006EFDA File Offset: 0x0006D1DA
			public unsafe Action<GameObject> objectProcessingCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr_objectProcessingCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr_objectProcessingCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004369 RID: 17257
			// (get) Token: 0x0600CF62 RID: 53090 RVA: 0x00330718 File Offset: 0x0032E918
			// (set) Token: 0x0600CF63 RID: 53091 RVA: 0x0006EFF9 File Offset: 0x0006D1F9
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x1700436A RID: 17258
			// (get) Token: 0x0600CF64 RID: 53092 RVA: 0x00330740 File Offset: 0x0032E940
			// (set) Token: 0x0600CF65 RID: 53093 RVA: 0x0006F014 File Offset: 0x0006D214
			public unsafe GameObject _instance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr__instance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__46.NativeFieldInfoPtr__instance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400855A RID: 34138
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400855B RID: 34139
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400855C RID: 34140
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x0400855D RID: 34141
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400855E RID: 34142
			private static readonly IntPtr NativeFieldInfoPtr_effectLayerInfo;

			// Token: 0x0400855F RID: 34143
			private static readonly IntPtr NativeFieldInfoPtr_objectProcessingCallback;

			// Token: 0x04008560 RID: 34144
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04008561 RID: 34145
			private static readonly IntPtr NativeFieldInfoPtr__instance_5__2;

			// Token: 0x04008562 RID: 34146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008563 RID: 34147
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008564 RID: 34148
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008565 RID: 34149
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008566 RID: 34150
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008567 RID: 34151
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE0 RID: 2784
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<InstantiateTimedC>d__47")]
		public sealed class _InstantiateTimedC_d__47 : Il2CppSystem.Object
		{
			// Token: 0x0600CF66 RID: 53094 RVA: 0x00330770 File Offset: 0x0032E970
			// Note: this type is marked as 'beforefieldinit'.
			static _InstantiateTimedC_d__47()
			{
				Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<InstantiateTimedC>d__47");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr);
				SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr, "<>1__state");
				SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr, "<>2__current");
				SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr, "parent");
				SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr, "position");
				SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr, "duration");
				SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr__instance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr, "<instance>5__2");
				SpellBase._InstantiateTimedC_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr, 100678158);
				SpellBase._InstantiateTimedC_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr, 100678159);
				SpellBase._InstantiateTimedC_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr, 100678160);
				SpellBase._InstantiateTimedC_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr, 100678161);
				SpellBase._InstantiateTimedC_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr, 100678162);
				SpellBase._InstantiateTimedC_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr, 100678163);
			}

			// Token: 0x0600CF67 RID: 53095 RVA: 0x0033088C File Offset: 0x0032EA8C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InstantiateTimedC_d__47(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__47>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__47.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF68 RID: 53096 RVA: 0x003308D4 File Offset: 0x0032EAD4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__47.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF69 RID: 53097 RVA: 0x00330908 File Offset: 0x0032EB08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192144, XrefRangeEnd = 192158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__47.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004373 RID: 17267
			// (get) Token: 0x0600CF6A RID: 53098 RVA: 0x00330944 File Offset: 0x0032EB44
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__47.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF6B RID: 53099 RVA: 0x00330984 File Offset: 0x0032EB84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192158, XrefRangeEnd = 192164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004374 RID: 17268
			// (get) Token: 0x0600CF6C RID: 53100 RVA: 0x003309B8 File Offset: 0x0032EBB8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__47.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF6D RID: 53101 RVA: 0x0006F033 File Offset: 0x0006D233
			public _InstantiateTimedC_d__47(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700436D RID: 17261
			// (get) Token: 0x0600CF6E RID: 53102 RVA: 0x003309F8 File Offset: 0x0032EBF8
			// (set) Token: 0x0600CF6F RID: 53103 RVA: 0x0006F03C File Offset: 0x0006D23C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700436E RID: 17262
			// (get) Token: 0x0600CF70 RID: 53104 RVA: 0x00330A20 File Offset: 0x0032EC20
			// (set) Token: 0x0600CF71 RID: 53105 RVA: 0x0006F057 File Offset: 0x0006D257
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700436F RID: 17263
			// (get) Token: 0x0600CF72 RID: 53106 RVA: 0x00330A50 File Offset: 0x0032EC50
			// (set) Token: 0x0600CF73 RID: 53107 RVA: 0x0006F076 File Offset: 0x0006D276
			public unsafe GameObject parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004370 RID: 17264
			// (get) Token: 0x0600CF74 RID: 53108 RVA: 0x00330A80 File Offset: 0x0032EC80
			// (set) Token: 0x0600CF75 RID: 53109 RVA: 0x0006F095 File Offset: 0x0006D295
			public unsafe Vector3 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x17004371 RID: 17265
			// (get) Token: 0x0600CF76 RID: 53110 RVA: 0x00330AA8 File Offset: 0x0032ECA8
			// (set) Token: 0x0600CF77 RID: 53111 RVA: 0x0006F0B0 File Offset: 0x0006D2B0
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004372 RID: 17266
			// (get) Token: 0x0600CF78 RID: 53112 RVA: 0x00330AD0 File Offset: 0x0032ECD0
			// (set) Token: 0x0600CF79 RID: 53113 RVA: 0x0006F0CB File Offset: 0x0006D2CB
			public unsafe GameObject _instance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr__instance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__47.NativeFieldInfoPtr__instance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008568 RID: 34152
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008569 RID: 34153
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400856A RID: 34154
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x0400856B RID: 34155
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x0400856C RID: 34156
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400856D RID: 34157
			private static readonly IntPtr NativeFieldInfoPtr__instance_5__2;

			// Token: 0x0400856E RID: 34158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400856F RID: 34159
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008570 RID: 34160
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008571 RID: 34161
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008572 RID: 34162
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008573 RID: 34163
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE1 RID: 2785
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<InstantiateTimedC>d__48")]
		public sealed class _InstantiateTimedC_d__48 : Il2CppSystem.Object
		{
			// Token: 0x0600CF7A RID: 53114 RVA: 0x00330B00 File Offset: 0x0032ED00
			// Note: this type is marked as 'beforefieldinit'.
			static _InstantiateTimedC_d__48()
			{
				Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<InstantiateTimedC>d__48");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr);
				SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr, "<>1__state");
				SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr, "<>2__current");
				SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr, "parent");
				SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr, "position");
				SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr_objectProcessingCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr, "objectProcessingCallback");
				SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr, "duration");
				SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr__instance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr, "<instance>5__2");
				SpellBase._InstantiateTimedC_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr, 100678164);
				SpellBase._InstantiateTimedC_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr, 100678165);
				SpellBase._InstantiateTimedC_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr, 100678166);
				SpellBase._InstantiateTimedC_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr, 100678167);
				SpellBase._InstantiateTimedC_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr, 100678168);
				SpellBase._InstantiateTimedC_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr, 100678169);
			}

			// Token: 0x0600CF7B RID: 53115 RVA: 0x00330C30 File Offset: 0x0032EE30
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InstantiateTimedC_d__48(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__48>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF7C RID: 53116 RVA: 0x00330C78 File Offset: 0x0032EE78
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF7D RID: 53117 RVA: 0x00330CAC File Offset: 0x0032EEAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192164, XrefRangeEnd = 192178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700437C RID: 17276
			// (get) Token: 0x0600CF7E RID: 53118 RVA: 0x00330CE8 File Offset: 0x0032EEE8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF7F RID: 53119 RVA: 0x00330D28 File Offset: 0x0032EF28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192178, XrefRangeEnd = 192184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700437D RID: 17277
			// (get) Token: 0x0600CF80 RID: 53120 RVA: 0x00330D5C File Offset: 0x0032EF5C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF81 RID: 53121 RVA: 0x0006F0EA File Offset: 0x0006D2EA
			public _InstantiateTimedC_d__48(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004375 RID: 17269
			// (get) Token: 0x0600CF82 RID: 53122 RVA: 0x00330D9C File Offset: 0x0032EF9C
			// (set) Token: 0x0600CF83 RID: 53123 RVA: 0x0006F0F3 File Offset: 0x0006D2F3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004376 RID: 17270
			// (get) Token: 0x0600CF84 RID: 53124 RVA: 0x00330DC4 File Offset: 0x0032EFC4
			// (set) Token: 0x0600CF85 RID: 53125 RVA: 0x0006F10E File Offset: 0x0006D30E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004377 RID: 17271
			// (get) Token: 0x0600CF86 RID: 53126 RVA: 0x00330DF4 File Offset: 0x0032EFF4
			// (set) Token: 0x0600CF87 RID: 53127 RVA: 0x0006F12D File Offset: 0x0006D32D
			public unsafe GameObject parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004378 RID: 17272
			// (get) Token: 0x0600CF88 RID: 53128 RVA: 0x00330E24 File Offset: 0x0032F024
			// (set) Token: 0x0600CF89 RID: 53129 RVA: 0x0006F14C File Offset: 0x0006D34C
			public unsafe Vector3 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x17004379 RID: 17273
			// (get) Token: 0x0600CF8A RID: 53130 RVA: 0x00330E4C File Offset: 0x0032F04C
			// (set) Token: 0x0600CF8B RID: 53131 RVA: 0x0006F167 File Offset: 0x0006D367
			public unsafe Action<GameObject> objectProcessingCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr_objectProcessingCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr_objectProcessingCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700437A RID: 17274
			// (get) Token: 0x0600CF8C RID: 53132 RVA: 0x00330E7C File Offset: 0x0032F07C
			// (set) Token: 0x0600CF8D RID: 53133 RVA: 0x0006F186 File Offset: 0x0006D386
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x1700437B RID: 17275
			// (get) Token: 0x0600CF8E RID: 53134 RVA: 0x00330EA4 File Offset: 0x0032F0A4
			// (set) Token: 0x0600CF8F RID: 53135 RVA: 0x0006F1A1 File Offset: 0x0006D3A1
			public unsafe GameObject _instance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr__instance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__48.NativeFieldInfoPtr__instance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008574 RID: 34164
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008575 RID: 34165
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008576 RID: 34166
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x04008577 RID: 34167
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04008578 RID: 34168
			private static readonly IntPtr NativeFieldInfoPtr_objectProcessingCallback;

			// Token: 0x04008579 RID: 34169
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400857A RID: 34170
			private static readonly IntPtr NativeFieldInfoPtr__instance_5__2;

			// Token: 0x0400857B RID: 34171
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400857C RID: 34172
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400857D RID: 34173
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400857E RID: 34174
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400857F RID: 34175
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008580 RID: 34176
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE2 RID: 2786
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<InstantiateTimedC>d__49")]
		public sealed class _InstantiateTimedC_d__49 : Il2CppSystem.Object
		{
			// Token: 0x0600CF90 RID: 53136 RVA: 0x00330ED4 File Offset: 0x0032F0D4
			// Note: this type is marked as 'beforefieldinit'.
			static _InstantiateTimedC_d__49()
			{
				Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<InstantiateTimedC>d__49");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr);
				SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr, "<>1__state");
				SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr, "<>2__current");
				SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr, "parent");
				SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr, "transform");
				SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr_objectProcessingCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr, "objectProcessingCallback");
				SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr, "duration");
				SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr__instance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr, "<instance>5__2");
				SpellBase._InstantiateTimedC_d__49.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr, 100678170);
				SpellBase._InstantiateTimedC_d__49.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr, 100678171);
				SpellBase._InstantiateTimedC_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr, 100678172);
				SpellBase._InstantiateTimedC_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr, 100678173);
				SpellBase._InstantiateTimedC_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr, 100678174);
				SpellBase._InstantiateTimedC_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr, 100678175);
			}

			// Token: 0x0600CF91 RID: 53137 RVA: 0x00331004 File Offset: 0x0032F204
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InstantiateTimedC_d__49(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._InstantiateTimedC_d__49>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__49.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF92 RID: 53138 RVA: 0x0033104C File Offset: 0x0032F24C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__49.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF93 RID: 53139 RVA: 0x00331080 File Offset: 0x0032F280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192184, XrefRangeEnd = 192196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004385 RID: 17285
			// (get) Token: 0x0600CF94 RID: 53140 RVA: 0x003310BC File Offset: 0x0032F2BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF95 RID: 53141 RVA: 0x003310FC File Offset: 0x0032F2FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192196, XrefRangeEnd = 192202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004386 RID: 17286
			// (get) Token: 0x0600CF96 RID: 53142 RVA: 0x00331130 File Offset: 0x0032F330
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._InstantiateTimedC_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CF97 RID: 53143 RVA: 0x0006F1C0 File Offset: 0x0006D3C0
			public _InstantiateTimedC_d__49(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700437E RID: 17278
			// (get) Token: 0x0600CF98 RID: 53144 RVA: 0x00331170 File Offset: 0x0032F370
			// (set) Token: 0x0600CF99 RID: 53145 RVA: 0x0006F1C9 File Offset: 0x0006D3C9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700437F RID: 17279
			// (get) Token: 0x0600CF9A RID: 53146 RVA: 0x00331198 File Offset: 0x0032F398
			// (set) Token: 0x0600CF9B RID: 53147 RVA: 0x0006F1E4 File Offset: 0x0006D3E4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004380 RID: 17280
			// (get) Token: 0x0600CF9C RID: 53148 RVA: 0x003311C8 File Offset: 0x0032F3C8
			// (set) Token: 0x0600CF9D RID: 53149 RVA: 0x0006F203 File Offset: 0x0006D403
			public unsafe GameObject parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004381 RID: 17281
			// (get) Token: 0x0600CF9E RID: 53150 RVA: 0x003311F8 File Offset: 0x0032F3F8
			// (set) Token: 0x0600CF9F RID: 53151 RVA: 0x0006F222 File Offset: 0x0006D422
			public unsafe Transform transform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr_transform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004382 RID: 17282
			// (get) Token: 0x0600CFA0 RID: 53152 RVA: 0x00331228 File Offset: 0x0032F428
			// (set) Token: 0x0600CFA1 RID: 53153 RVA: 0x0006F241 File Offset: 0x0006D441
			public unsafe Action<GameObject> objectProcessingCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr_objectProcessingCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr_objectProcessingCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004383 RID: 17283
			// (get) Token: 0x0600CFA2 RID: 53154 RVA: 0x00331258 File Offset: 0x0032F458
			// (set) Token: 0x0600CFA3 RID: 53155 RVA: 0x0006F260 File Offset: 0x0006D460
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004384 RID: 17284
			// (get) Token: 0x0600CFA4 RID: 53156 RVA: 0x00331280 File Offset: 0x0032F480
			// (set) Token: 0x0600CFA5 RID: 53157 RVA: 0x0006F27B File Offset: 0x0006D47B
			public unsafe GameObject _instance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr__instance_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._InstantiateTimedC_d__49.NativeFieldInfoPtr__instance_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008581 RID: 34177
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008582 RID: 34178
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008583 RID: 34179
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x04008584 RID: 34180
			private static readonly IntPtr NativeFieldInfoPtr_transform;

			// Token: 0x04008585 RID: 34181
			private static readonly IntPtr NativeFieldInfoPtr_objectProcessingCallback;

			// Token: 0x04008586 RID: 34182
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04008587 RID: 34183
			private static readonly IntPtr NativeFieldInfoPtr__instance_5__2;

			// Token: 0x04008588 RID: 34184
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008589 RID: 34185
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400858A RID: 34186
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400858B RID: 34187
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400858C RID: 34188
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400858D RID: 34189
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE3 RID: 2787
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<LerpPosition>d__56")]
		public sealed class _LerpPosition_d__56 : Il2CppSystem.Object
		{
			// Token: 0x0600CFA6 RID: 53158 RVA: 0x003312B0 File Offset: 0x0032F4B0
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpPosition_d__56()
			{
				Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<LerpPosition>d__56");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr);
				SpellBase._LerpPosition_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr, "<>1__state");
				SpellBase._LerpPosition_d__56.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr, "<>2__current");
				SpellBase._LerpPosition_d__56.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr, "<>4__this");
				SpellBase._LerpPosition_d__56.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr, "source");
				SpellBase._LerpPosition_d__56.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr, "targetPosition");
				SpellBase._LerpPosition_d__56.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr, "duration");
				SpellBase._LerpPosition_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr, 100678176);
				SpellBase._LerpPosition_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr, 100678177);
				SpellBase._LerpPosition_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr, 100678178);
				SpellBase._LerpPosition_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr, 100678179);
				SpellBase._LerpPosition_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr, 100678180);
				SpellBase._LerpPosition_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr, 100678181);
			}

			// Token: 0x0600CFA7 RID: 53159 RVA: 0x003313CC File Offset: 0x0032F5CC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpPosition_d__56(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._LerpPosition_d__56>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpPosition_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFA8 RID: 53160 RVA: 0x00331414 File Offset: 0x0032F614
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpPosition_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFA9 RID: 53161 RVA: 0x00331448 File Offset: 0x0032F648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192202, XrefRangeEnd = 192207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpPosition_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700438D RID: 17293
			// (get) Token: 0x0600CFAA RID: 53162 RVA: 0x00331484 File Offset: 0x0032F684
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpPosition_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CFAB RID: 53163 RVA: 0x003314C4 File Offset: 0x0032F6C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192207, XrefRangeEnd = 192213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpPosition_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700438E RID: 17294
			// (get) Token: 0x0600CFAC RID: 53164 RVA: 0x003314F8 File Offset: 0x0032F6F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpPosition_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CFAD RID: 53165 RVA: 0x0006F29A File Offset: 0x0006D49A
			public _LerpPosition_d__56(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004387 RID: 17287
			// (get) Token: 0x0600CFAE RID: 53166 RVA: 0x00331538 File Offset: 0x0032F738
			// (set) Token: 0x0600CFAF RID: 53167 RVA: 0x0006F2A3 File Offset: 0x0006D4A3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpPosition_d__56.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpPosition_d__56.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004388 RID: 17288
			// (get) Token: 0x0600CFB0 RID: 53168 RVA: 0x00331560 File Offset: 0x0032F760
			// (set) Token: 0x0600CFB1 RID: 53169 RVA: 0x0006F2BE File Offset: 0x0006D4BE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpPosition_d__56.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpPosition_d__56.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004389 RID: 17289
			// (get) Token: 0x0600CFB2 RID: 53170 RVA: 0x00331590 File Offset: 0x0032F790
			// (set) Token: 0x0600CFB3 RID: 53171 RVA: 0x0006F2DD File Offset: 0x0006D4DD
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpPosition_d__56.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpPosition_d__56.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700438A RID: 17290
			// (get) Token: 0x0600CFB4 RID: 53172 RVA: 0x003315C0 File Offset: 0x0032F7C0
			// (set) Token: 0x0600CFB5 RID: 53173 RVA: 0x0006F2FC File Offset: 0x0006D4FC
			public unsafe Transform source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpPosition_d__56.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpPosition_d__56.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700438B RID: 17291
			// (get) Token: 0x0600CFB6 RID: 53174 RVA: 0x003315F0 File Offset: 0x0032F7F0
			// (set) Token: 0x0600CFB7 RID: 53175 RVA: 0x0006F31B File Offset: 0x0006D51B
			public unsafe Func<Vector3> targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpPosition_d__56.NativeFieldInfoPtr_targetPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpPosition_d__56.NativeFieldInfoPtr_targetPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700438C RID: 17292
			// (get) Token: 0x0600CFB8 RID: 53176 RVA: 0x00331620 File Offset: 0x0032F820
			// (set) Token: 0x0600CFB9 RID: 53177 RVA: 0x0006F33A File Offset: 0x0006D53A
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpPosition_d__56.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpPosition_d__56.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x0400858E RID: 34190
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400858F RID: 34191
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008590 RID: 34192
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008591 RID: 34193
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04008592 RID: 34194
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x04008593 RID: 34195
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04008594 RID: 34196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008595 RID: 34197
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008596 RID: 34198
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008597 RID: 34199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008598 RID: 34200
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008599 RID: 34201
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE4 RID: 2788
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<LerpParabolic>d__57")]
		public sealed class _LerpParabolic_d__57 : Il2CppSystem.Object
		{
			// Token: 0x0600CFBA RID: 53178 RVA: 0x00331648 File Offset: 0x0032F848
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpParabolic_d__57()
			{
				Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<LerpParabolic>d__57");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr);
				SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, "<>1__state");
				SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, "<>2__current");
				SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, "<>4__this");
				SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, "source");
				SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, "targetPosition");
				SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_launchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, "launchHeight");
				SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_launchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, "launchSpeed");
				SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_forceRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, "forceRotate");
				SpellBase._LerpParabolic_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, 100678182);
				SpellBase._LerpParabolic_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, 100678183);
				SpellBase._LerpParabolic_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, 100678184);
				SpellBase._LerpParabolic_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, 100678185);
				SpellBase._LerpParabolic_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, 100678186);
				SpellBase._LerpParabolic_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr, 100678187);
			}

			// Token: 0x0600CFBB RID: 53179 RVA: 0x0033178C File Offset: 0x0032F98C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpParabolic_d__57(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._LerpParabolic_d__57>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpParabolic_d__57.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFBC RID: 53180 RVA: 0x003317D4 File Offset: 0x0032F9D4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpParabolic_d__57.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFBD RID: 53181 RVA: 0x00331808 File Offset: 0x0032FA08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192213, XrefRangeEnd = 192218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpParabolic_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004397 RID: 17303
			// (get) Token: 0x0600CFBE RID: 53182 RVA: 0x00331844 File Offset: 0x0032FA44
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpParabolic_d__57.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CFBF RID: 53183 RVA: 0x00331884 File Offset: 0x0032FA84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192218, XrefRangeEnd = 192224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpParabolic_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004398 RID: 17304
			// (get) Token: 0x0600CFC0 RID: 53184 RVA: 0x003318B8 File Offset: 0x0032FAB8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpParabolic_d__57.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CFC1 RID: 53185 RVA: 0x0006F355 File Offset: 0x0006D555
			public _LerpParabolic_d__57(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700438F RID: 17295
			// (get) Token: 0x0600CFC2 RID: 53186 RVA: 0x003318F8 File Offset: 0x0032FAF8
			// (set) Token: 0x0600CFC3 RID: 53187 RVA: 0x0006F35E File Offset: 0x0006D55E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004390 RID: 17296
			// (get) Token: 0x0600CFC4 RID: 53188 RVA: 0x00331920 File Offset: 0x0032FB20
			// (set) Token: 0x0600CFC5 RID: 53189 RVA: 0x0006F379 File Offset: 0x0006D579
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004391 RID: 17297
			// (get) Token: 0x0600CFC6 RID: 53190 RVA: 0x00331950 File Offset: 0x0032FB50
			// (set) Token: 0x0600CFC7 RID: 53191 RVA: 0x0006F398 File Offset: 0x0006D598
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004392 RID: 17298
			// (get) Token: 0x0600CFC8 RID: 53192 RVA: 0x00331980 File Offset: 0x0032FB80
			// (set) Token: 0x0600CFC9 RID: 53193 RVA: 0x0006F3B7 File Offset: 0x0006D5B7
			public unsafe Transform source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004393 RID: 17299
			// (get) Token: 0x0600CFCA RID: 53194 RVA: 0x003319B0 File Offset: 0x0032FBB0
			// (set) Token: 0x0600CFCB RID: 53195 RVA: 0x0006F3D6 File Offset: 0x0006D5D6
			public unsafe Func<Vector3> targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_targetPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_targetPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004394 RID: 17300
			// (get) Token: 0x0600CFCC RID: 53196 RVA: 0x003319E0 File Offset: 0x0032FBE0
			// (set) Token: 0x0600CFCD RID: 53197 RVA: 0x0006F3F5 File Offset: 0x0006D5F5
			public unsafe float launchHeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_launchHeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_launchHeight)) = value;
				}
			}

			// Token: 0x17004395 RID: 17301
			// (get) Token: 0x0600CFCE RID: 53198 RVA: 0x00331A08 File Offset: 0x0032FC08
			// (set) Token: 0x0600CFCF RID: 53199 RVA: 0x0006F410 File Offset: 0x0006D610
			public unsafe float launchSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_launchSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_launchSpeed)) = value;
				}
			}

			// Token: 0x17004396 RID: 17302
			// (get) Token: 0x0600CFD0 RID: 53200 RVA: 0x00331A30 File Offset: 0x0032FC30
			// (set) Token: 0x0600CFD1 RID: 53201 RVA: 0x0006F42B File Offset: 0x0006D62B
			public unsafe bool forceRotate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_forceRotate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpParabolic_d__57.NativeFieldInfoPtr_forceRotate)) = value;
				}
			}

			// Token: 0x0400859A RID: 34202
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400859B RID: 34203
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400859C RID: 34204
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400859D RID: 34205
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x0400859E RID: 34206
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x0400859F RID: 34207
			private static readonly IntPtr NativeFieldInfoPtr_launchHeight;

			// Token: 0x040085A0 RID: 34208
			private static readonly IntPtr NativeFieldInfoPtr_launchSpeed;

			// Token: 0x040085A1 RID: 34209
			private static readonly IntPtr NativeFieldInfoPtr_forceRotate;

			// Token: 0x040085A2 RID: 34210
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040085A3 RID: 34211
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040085A4 RID: 34212
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040085A5 RID: 34213
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040085A6 RID: 34214
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040085A7 RID: 34215
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE5 RID: 2789
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<LerpBezier>d__58")]
		public sealed class _LerpBezier_d__58 : Il2CppSystem.Object
		{
			// Token: 0x0600CFD2 RID: 53202 RVA: 0x00331A58 File Offset: 0x0032FC58
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpBezier_d__58()
			{
				Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<LerpBezier>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr);
				SpellBase._LerpBezier_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, "<>1__state");
				SpellBase._LerpBezier_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, "<>2__current");
				SpellBase._LerpBezier_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, "<>4__this");
				SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, "source");
				SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_controlPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, "controlPosition");
				SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, "targetPosition");
				SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, "duration");
				SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_forceRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, "forceRotate");
				SpellBase._LerpBezier_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, 100678188);
				SpellBase._LerpBezier_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, 100678189);
				SpellBase._LerpBezier_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, 100678190);
				SpellBase._LerpBezier_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, 100678191);
				SpellBase._LerpBezier_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, 100678192);
				SpellBase._LerpBezier_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr, 100678193);
			}

			// Token: 0x0600CFD3 RID: 53203 RVA: 0x00331B9C File Offset: 0x0032FD9C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpBezier_d__58(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._LerpBezier_d__58>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpBezier_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFD4 RID: 53204 RVA: 0x00331BE4 File Offset: 0x0032FDE4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpBezier_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFD5 RID: 53205 RVA: 0x00331C18 File Offset: 0x0032FE18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192224, XrefRangeEnd = 192229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpBezier_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043A1 RID: 17313
			// (get) Token: 0x0600CFD6 RID: 53206 RVA: 0x00331C54 File Offset: 0x0032FE54
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpBezier_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CFD7 RID: 53207 RVA: 0x00331C94 File Offset: 0x0032FE94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192229, XrefRangeEnd = 192235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpBezier_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043A2 RID: 17314
			// (get) Token: 0x0600CFD8 RID: 53208 RVA: 0x00331CC8 File Offset: 0x0032FEC8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpBezier_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CFD9 RID: 53209 RVA: 0x0006F446 File Offset: 0x0006D646
			public _LerpBezier_d__58(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004399 RID: 17305
			// (get) Token: 0x0600CFDA RID: 53210 RVA: 0x00331D08 File Offset: 0x0032FF08
			// (set) Token: 0x0600CFDB RID: 53211 RVA: 0x0006F44F File Offset: 0x0006D64F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700439A RID: 17306
			// (get) Token: 0x0600CFDC RID: 53212 RVA: 0x00331D30 File Offset: 0x0032FF30
			// (set) Token: 0x0600CFDD RID: 53213 RVA: 0x0006F46A File Offset: 0x0006D66A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700439B RID: 17307
			// (get) Token: 0x0600CFDE RID: 53214 RVA: 0x00331D60 File Offset: 0x0032FF60
			// (set) Token: 0x0600CFDF RID: 53215 RVA: 0x0006F489 File Offset: 0x0006D689
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700439C RID: 17308
			// (get) Token: 0x0600CFE0 RID: 53216 RVA: 0x00331D90 File Offset: 0x0032FF90
			// (set) Token: 0x0600CFE1 RID: 53217 RVA: 0x0006F4A8 File Offset: 0x0006D6A8
			public unsafe Transform source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700439D RID: 17309
			// (get) Token: 0x0600CFE2 RID: 53218 RVA: 0x00331DC0 File Offset: 0x0032FFC0
			// (set) Token: 0x0600CFE3 RID: 53219 RVA: 0x0006F4C7 File Offset: 0x0006D6C7
			public unsafe Func<Vector3> controlPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_controlPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_controlPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700439E RID: 17310
			// (get) Token: 0x0600CFE4 RID: 53220 RVA: 0x00331DF0 File Offset: 0x0032FFF0
			// (set) Token: 0x0600CFE5 RID: 53221 RVA: 0x0006F4E6 File Offset: 0x0006D6E6
			public unsafe Func<Vector3> targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_targetPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_targetPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700439F RID: 17311
			// (get) Token: 0x0600CFE6 RID: 53222 RVA: 0x00331E20 File Offset: 0x00330020
			// (set) Token: 0x0600CFE7 RID: 53223 RVA: 0x0006F505 File Offset: 0x0006D705
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170043A0 RID: 17312
			// (get) Token: 0x0600CFE8 RID: 53224 RVA: 0x00331E48 File Offset: 0x00330048
			// (set) Token: 0x0600CFE9 RID: 53225 RVA: 0x0006F520 File Offset: 0x0006D720
			public unsafe bool forceRotate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_forceRotate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezier_d__58.NativeFieldInfoPtr_forceRotate)) = value;
				}
			}

			// Token: 0x040085A8 RID: 34216
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040085A9 RID: 34217
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040085AA RID: 34218
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040085AB RID: 34219
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040085AC RID: 34220
			private static readonly IntPtr NativeFieldInfoPtr_controlPosition;

			// Token: 0x040085AD RID: 34221
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x040085AE RID: 34222
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x040085AF RID: 34223
			private static readonly IntPtr NativeFieldInfoPtr_forceRotate;

			// Token: 0x040085B0 RID: 34224
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040085B1 RID: 34225
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040085B2 RID: 34226
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040085B3 RID: 34227
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040085B4 RID: 34228
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040085B5 RID: 34229
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE6 RID: 2790
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<LerpBezierCubic>d__59")]
		public sealed class _LerpBezierCubic_d__59 : Il2CppSystem.Object
		{
			// Token: 0x0600CFEA RID: 53226 RVA: 0x00331E70 File Offset: 0x00330070
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpBezierCubic_d__59()
			{
				Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<LerpBezierCubic>d__59");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr);
				SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, "<>1__state");
				SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, "<>2__current");
				SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, "<>4__this");
				SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, "source");
				SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_control1Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, "control1Position");
				SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_control2Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, "control2Position");
				SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, "targetPosition");
				SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, "duration");
				SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_forceRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, "forceRotate");
				SpellBase._LerpBezierCubic_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, 100678194);
				SpellBase._LerpBezierCubic_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, 100678195);
				SpellBase._LerpBezierCubic_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, 100678196);
				SpellBase._LerpBezierCubic_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, 100678197);
				SpellBase._LerpBezierCubic_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, 100678198);
				SpellBase._LerpBezierCubic_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr, 100678199);
			}

			// Token: 0x0600CFEB RID: 53227 RVA: 0x00331FC8 File Offset: 0x003301C8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpBezierCubic_d__59(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._LerpBezierCubic_d__59>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpBezierCubic_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFEC RID: 53228 RVA: 0x00332010 File Offset: 0x00330210
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpBezierCubic_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFED RID: 53229 RVA: 0x00332044 File Offset: 0x00330244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192235, XrefRangeEnd = 192240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpBezierCubic_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043AC RID: 17324
			// (get) Token: 0x0600CFEE RID: 53230 RVA: 0x00332080 File Offset: 0x00330280
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpBezierCubic_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CFEF RID: 53231 RVA: 0x003320C0 File Offset: 0x003302C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192240, XrefRangeEnd = 192246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpBezierCubic_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043AD RID: 17325
			// (get) Token: 0x0600CFF0 RID: 53232 RVA: 0x003320F4 File Offset: 0x003302F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._LerpBezierCubic_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CFF1 RID: 53233 RVA: 0x0006F53B File Offset: 0x0006D73B
			public _LerpBezierCubic_d__59(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043A3 RID: 17315
			// (get) Token: 0x0600CFF2 RID: 53234 RVA: 0x00332134 File Offset: 0x00330334
			// (set) Token: 0x0600CFF3 RID: 53235 RVA: 0x0006F544 File Offset: 0x0006D744
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043A4 RID: 17316
			// (get) Token: 0x0600CFF4 RID: 53236 RVA: 0x0033215C File Offset: 0x0033035C
			// (set) Token: 0x0600CFF5 RID: 53237 RVA: 0x0006F55F File Offset: 0x0006D75F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A5 RID: 17317
			// (get) Token: 0x0600CFF6 RID: 53238 RVA: 0x0033218C File Offset: 0x0033038C
			// (set) Token: 0x0600CFF7 RID: 53239 RVA: 0x0006F57E File Offset: 0x0006D77E
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A6 RID: 17318
			// (get) Token: 0x0600CFF8 RID: 53240 RVA: 0x003321BC File Offset: 0x003303BC
			// (set) Token: 0x0600CFF9 RID: 53241 RVA: 0x0006F59D File Offset: 0x0006D79D
			public unsafe Transform source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A7 RID: 17319
			// (get) Token: 0x0600CFFA RID: 53242 RVA: 0x003321EC File Offset: 0x003303EC
			// (set) Token: 0x0600CFFB RID: 53243 RVA: 0x0006F5BC File Offset: 0x0006D7BC
			public unsafe Func<Vector3> control1Position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_control1Position);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_control1Position), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A8 RID: 17320
			// (get) Token: 0x0600CFFC RID: 53244 RVA: 0x0033221C File Offset: 0x0033041C
			// (set) Token: 0x0600CFFD RID: 53245 RVA: 0x0006F5DB File Offset: 0x0006D7DB
			public unsafe Func<Vector3> control2Position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_control2Position);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_control2Position), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A9 RID: 17321
			// (get) Token: 0x0600CFFE RID: 53246 RVA: 0x0033224C File Offset: 0x0033044C
			// (set) Token: 0x0600CFFF RID: 53247 RVA: 0x0006F5FA File Offset: 0x0006D7FA
			public unsafe Func<Vector3> targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_targetPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_targetPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043AA RID: 17322
			// (get) Token: 0x0600D000 RID: 53248 RVA: 0x0033227C File Offset: 0x0033047C
			// (set) Token: 0x0600D001 RID: 53249 RVA: 0x0006F619 File Offset: 0x0006D819
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170043AB RID: 17323
			// (get) Token: 0x0600D002 RID: 53250 RVA: 0x003322A4 File Offset: 0x003304A4
			// (set) Token: 0x0600D003 RID: 53251 RVA: 0x0006F634 File Offset: 0x0006D834
			public unsafe bool forceRotate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_forceRotate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._LerpBezierCubic_d__59.NativeFieldInfoPtr_forceRotate)) = value;
				}
			}

			// Token: 0x040085B6 RID: 34230
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040085B7 RID: 34231
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040085B8 RID: 34232
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040085B9 RID: 34233
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040085BA RID: 34234
			private static readonly IntPtr NativeFieldInfoPtr_control1Position;

			// Token: 0x040085BB RID: 34235
			private static readonly IntPtr NativeFieldInfoPtr_control2Position;

			// Token: 0x040085BC RID: 34236
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x040085BD RID: 34237
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x040085BE RID: 34238
			private static readonly IntPtr NativeFieldInfoPtr_forceRotate;

			// Token: 0x040085BF RID: 34239
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040085C0 RID: 34240
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040085C1 RID: 34241
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040085C2 RID: 34242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040085C3 RID: 34243
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040085C4 RID: 34244
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE7 RID: 2791
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<Homing>d__60")]
		public sealed class _Homing_d__60 : Il2CppSystem.Object
		{
			// Token: 0x0600D004 RID: 53252 RVA: 0x003322CC File Offset: 0x003304CC
			// Note: this type is marked as 'beforefieldinit'.
			static _Homing_d__60()
			{
				Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<Homing>d__60");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr);
				SpellBase._Homing_d__60.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, "<>1__state");
				SpellBase._Homing_d__60.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, "<>2__current");
				SpellBase._Homing_d__60.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, "<>4__this");
				SpellBase._Homing_d__60.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, "source");
				SpellBase._Homing_d__60.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, "targetPosition");
				SpellBase._Homing_d__60.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, "speed");
				SpellBase._Homing_d__60.NativeFieldInfoPtr_miniumAnglarSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, "miniumAnglarSpeed");
				SpellBase._Homing_d__60.NativeFieldInfoPtr_maxinumAngularSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, "maxinumAngularSpeed");
				SpellBase._Homing_d__60.NativeFieldInfoPtr_distanceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, "distanceOffset");
				SpellBase._Homing_d__60.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, 100678200);
				SpellBase._Homing_d__60.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, 100678201);
				SpellBase._Homing_d__60.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, 100678202);
				SpellBase._Homing_d__60.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, 100678203);
				SpellBase._Homing_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, 100678204);
				SpellBase._Homing_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr, 100678205);
			}

			// Token: 0x0600D005 RID: 53253 RVA: 0x00332424 File Offset: 0x00330624
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Homing_d__60(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._Homing_d__60>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._Homing_d__60.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D006 RID: 53254 RVA: 0x0033246C File Offset: 0x0033066C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._Homing_d__60.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D007 RID: 53255 RVA: 0x003324A0 File Offset: 0x003306A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192246, XrefRangeEnd = 192251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._Homing_d__60.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043B7 RID: 17335
			// (get) Token: 0x0600D008 RID: 53256 RVA: 0x003324DC File Offset: 0x003306DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._Homing_d__60.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D009 RID: 53257 RVA: 0x0033251C File Offset: 0x0033071C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192251, XrefRangeEnd = 192257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._Homing_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043B8 RID: 17336
			// (get) Token: 0x0600D00A RID: 53258 RVA: 0x00332550 File Offset: 0x00330750
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._Homing_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D00B RID: 53259 RVA: 0x0006F64F File Offset: 0x0006D84F
			public _Homing_d__60(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043AE RID: 17326
			// (get) Token: 0x0600D00C RID: 53260 RVA: 0x00332590 File Offset: 0x00330790
			// (set) Token: 0x0600D00D RID: 53261 RVA: 0x0006F658 File Offset: 0x0006D858
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043AF RID: 17327
			// (get) Token: 0x0600D00E RID: 53262 RVA: 0x003325B8 File Offset: 0x003307B8
			// (set) Token: 0x0600D00F RID: 53263 RVA: 0x0006F673 File Offset: 0x0006D873
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B0 RID: 17328
			// (get) Token: 0x0600D010 RID: 53264 RVA: 0x003325E8 File Offset: 0x003307E8
			// (set) Token: 0x0600D011 RID: 53265 RVA: 0x0006F692 File Offset: 0x0006D892
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B1 RID: 17329
			// (get) Token: 0x0600D012 RID: 53266 RVA: 0x00332618 File Offset: 0x00330818
			// (set) Token: 0x0600D013 RID: 53267 RVA: 0x0006F6B1 File Offset: 0x0006D8B1
			public unsafe Transform source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B2 RID: 17330
			// (get) Token: 0x0600D014 RID: 53268 RVA: 0x00332648 File Offset: 0x00330848
			// (set) Token: 0x0600D015 RID: 53269 RVA: 0x0006F6D0 File Offset: 0x0006D8D0
			public unsafe Func<Vector3> targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr_targetPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr_targetPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B3 RID: 17331
			// (get) Token: 0x0600D016 RID: 53270 RVA: 0x00332678 File Offset: 0x00330878
			// (set) Token: 0x0600D017 RID: 53271 RVA: 0x0006F6EF File Offset: 0x0006D8EF
			public unsafe float speed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr_speed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr_speed)) = value;
				}
			}

			// Token: 0x170043B4 RID: 17332
			// (get) Token: 0x0600D018 RID: 53272 RVA: 0x003326A0 File Offset: 0x003308A0
			// (set) Token: 0x0600D019 RID: 53273 RVA: 0x0006F70A File Offset: 0x0006D90A
			public unsafe float miniumAnglarSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr_miniumAnglarSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr_miniumAnglarSpeed)) = value;
				}
			}

			// Token: 0x170043B5 RID: 17333
			// (get) Token: 0x0600D01A RID: 53274 RVA: 0x003326C8 File Offset: 0x003308C8
			// (set) Token: 0x0600D01B RID: 53275 RVA: 0x0006F725 File Offset: 0x0006D925
			public unsafe float maxinumAngularSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr_maxinumAngularSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr_maxinumAngularSpeed)) = value;
				}
			}

			// Token: 0x170043B6 RID: 17334
			// (get) Token: 0x0600D01C RID: 53276 RVA: 0x003326F0 File Offset: 0x003308F0
			// (set) Token: 0x0600D01D RID: 53277 RVA: 0x0006F740 File Offset: 0x0006D940
			public unsafe float distanceOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr_distanceOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__60.NativeFieldInfoPtr_distanceOffset)) = value;
				}
			}

			// Token: 0x040085C5 RID: 34245
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040085C6 RID: 34246
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040085C7 RID: 34247
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040085C8 RID: 34248
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040085C9 RID: 34249
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x040085CA RID: 34250
			private static readonly IntPtr NativeFieldInfoPtr_speed;

			// Token: 0x040085CB RID: 34251
			private static readonly IntPtr NativeFieldInfoPtr_miniumAnglarSpeed;

			// Token: 0x040085CC RID: 34252
			private static readonly IntPtr NativeFieldInfoPtr_maxinumAngularSpeed;

			// Token: 0x040085CD RID: 34253
			private static readonly IntPtr NativeFieldInfoPtr_distanceOffset;

			// Token: 0x040085CE RID: 34254
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040085CF RID: 34255
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040085D0 RID: 34256
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040085D1 RID: 34257
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040085D2 RID: 34258
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040085D3 RID: 34259
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE8 RID: 2792
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<Homing>d__61")]
		public sealed class _Homing_d__61 : Il2CppSystem.Object
		{
			// Token: 0x0600D01E RID: 53278 RVA: 0x00332718 File Offset: 0x00330918
			// Note: this type is marked as 'beforefieldinit'.
			static _Homing_d__61()
			{
				Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<Homing>d__61");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr);
				SpellBase._Homing_d__61.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, "<>1__state");
				SpellBase._Homing_d__61.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, "<>2__current");
				SpellBase._Homing_d__61.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, "<>4__this");
				SpellBase._Homing_d__61.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, "source");
				SpellBase._Homing_d__61.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, "targetPosition");
				SpellBase._Homing_d__61.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, "speed");
				SpellBase._Homing_d__61.NativeFieldInfoPtr_miniumAnglarSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, "miniumAnglarSpeed");
				SpellBase._Homing_d__61.NativeFieldInfoPtr_maxinumAngularSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, "maxinumAngularSpeed");
				SpellBase._Homing_d__61.NativeFieldInfoPtr_distanceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, "distanceOffset");
				SpellBase._Homing_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, 100678206);
				SpellBase._Homing_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, 100678207);
				SpellBase._Homing_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, 100678208);
				SpellBase._Homing_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, 100678209);
				SpellBase._Homing_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, 100678210);
				SpellBase._Homing_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr, 100678211);
			}

			// Token: 0x0600D01F RID: 53279 RVA: 0x00332870 File Offset: 0x00330A70
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Homing_d__61(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase._Homing_d__61>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._Homing_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D020 RID: 53280 RVA: 0x003328B8 File Offset: 0x00330AB8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._Homing_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D021 RID: 53281 RVA: 0x003328EC File Offset: 0x00330AEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192257, XrefRangeEnd = 192262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._Homing_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043C2 RID: 17346
			// (get) Token: 0x0600D022 RID: 53282 RVA: 0x00332928 File Offset: 0x00330B28
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._Homing_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D023 RID: 53283 RVA: 0x00332968 File Offset: 0x00330B68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192262, XrefRangeEnd = 192268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._Homing_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043C3 RID: 17347
			// (get) Token: 0x0600D024 RID: 53284 RVA: 0x0033299C File Offset: 0x00330B9C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase._Homing_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D025 RID: 53285 RVA: 0x0006F75B File Offset: 0x0006D95B
			public _Homing_d__61(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B9 RID: 17337
			// (get) Token: 0x0600D026 RID: 53286 RVA: 0x003329DC File Offset: 0x00330BDC
			// (set) Token: 0x0600D027 RID: 53287 RVA: 0x0006F764 File Offset: 0x0006D964
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043BA RID: 17338
			// (get) Token: 0x0600D028 RID: 53288 RVA: 0x00332A04 File Offset: 0x00330C04
			// (set) Token: 0x0600D029 RID: 53289 RVA: 0x0006F77F File Offset: 0x0006D97F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043BB RID: 17339
			// (get) Token: 0x0600D02A RID: 53290 RVA: 0x00332A34 File Offset: 0x00330C34
			// (set) Token: 0x0600D02B RID: 53291 RVA: 0x0006F79E File Offset: 0x0006D99E
			public unsafe SpellBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043BC RID: 17340
			// (get) Token: 0x0600D02C RID: 53292 RVA: 0x00332A64 File Offset: 0x00330C64
			// (set) Token: 0x0600D02D RID: 53293 RVA: 0x0006F7BD File Offset: 0x0006D9BD
			public unsafe Transform source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043BD RID: 17341
			// (get) Token: 0x0600D02E RID: 53294 RVA: 0x00332A94 File Offset: 0x00330C94
			// (set) Token: 0x0600D02F RID: 53295 RVA: 0x0006F7DC File Offset: 0x0006D9DC
			public unsafe Func<Vector3> targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr_targetPosition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr_targetPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043BE RID: 17342
			// (get) Token: 0x0600D030 RID: 53296 RVA: 0x00332AC4 File Offset: 0x00330CC4
			// (set) Token: 0x0600D031 RID: 53297 RVA: 0x0006F7FB File Offset: 0x0006D9FB
			public unsafe Func<float> speed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr_speed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr_speed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043BF RID: 17343
			// (get) Token: 0x0600D032 RID: 53298 RVA: 0x00332AF4 File Offset: 0x00330CF4
			// (set) Token: 0x0600D033 RID: 53299 RVA: 0x0006F81A File Offset: 0x0006DA1A
			public unsafe Func<float> miniumAnglarSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr_miniumAnglarSpeed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr_miniumAnglarSpeed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C0 RID: 17344
			// (get) Token: 0x0600D034 RID: 53300 RVA: 0x00332B24 File Offset: 0x00330D24
			// (set) Token: 0x0600D035 RID: 53301 RVA: 0x0006F839 File Offset: 0x0006DA39
			public unsafe Func<float> maxinumAngularSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr_maxinumAngularSpeed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr_maxinumAngularSpeed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C1 RID: 17345
			// (get) Token: 0x0600D036 RID: 53302 RVA: 0x00332B54 File Offset: 0x00330D54
			// (set) Token: 0x0600D037 RID: 53303 RVA: 0x0006F858 File Offset: 0x0006DA58
			public unsafe float distanceOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr_distanceOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase._Homing_d__61.NativeFieldInfoPtr_distanceOffset)) = value;
				}
			}

			// Token: 0x040085D4 RID: 34260
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040085D5 RID: 34261
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040085D6 RID: 34262
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040085D7 RID: 34263
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040085D8 RID: 34264
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x040085D9 RID: 34265
			private static readonly IntPtr NativeFieldInfoPtr_speed;

			// Token: 0x040085DA RID: 34266
			private static readonly IntPtr NativeFieldInfoPtr_miniumAnglarSpeed;

			// Token: 0x040085DB RID: 34267
			private static readonly IntPtr NativeFieldInfoPtr_maxinumAngularSpeed;

			// Token: 0x040085DC RID: 34268
			private static readonly IntPtr NativeFieldInfoPtr_distanceOffset;

			// Token: 0x040085DD RID: 34269
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040085DE RID: 34270
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040085DF RID: 34271
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040085E0 RID: 34272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040085E1 RID: 34273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040085E2 RID: 34274
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AE9 RID: 2793
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass63_0")]
		public sealed class __c__DisplayClass63_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D038 RID: 53304 RVA: 0x00332B7C File Offset: 0x00330D7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0>.NativeClassPtr);
				SpellBase.__c__DisplayClass63_0.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0>.NativeClassPtr, "source");
				SpellBase.__c__DisplayClass63_0.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0>.NativeClassPtr, "speed");
				SpellBase.__c__DisplayClass63_0.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0>.NativeClassPtr, "point");
				SpellBase.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0>.NativeClassPtr, 100678212);
				SpellBase.__c__DisplayClass63_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0>.NativeClassPtr, 100678213);
			}

			// Token: 0x0600D039 RID: 53305 RVA: 0x00332C0C File Offset: 0x00330E0C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D03A RID: 53306 RVA: 0x00332C48 File Offset: 0x00330E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192286, XrefRangeEnd = 192291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass63_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D03B RID: 53307 RVA: 0x0006F873 File Offset: 0x0006DA73
			public __c__DisplayClass63_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C4 RID: 17348
			// (get) Token: 0x0600D03C RID: 53308 RVA: 0x00332C88 File Offset: 0x00330E88
			// (set) Token: 0x0600D03D RID: 53309 RVA: 0x0006F87C File Offset: 0x0006DA7C
			public unsafe Transform source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C5 RID: 17349
			// (get) Token: 0x0600D03E RID: 53310 RVA: 0x00332CB8 File Offset: 0x00330EB8
			// (set) Token: 0x0600D03F RID: 53311 RVA: 0x0006F89B File Offset: 0x0006DA9B
			public unsafe float speed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.NativeFieldInfoPtr_speed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.NativeFieldInfoPtr_speed)) = value;
				}
			}

			// Token: 0x170043C6 RID: 17350
			// (get) Token: 0x0600D040 RID: 53312 RVA: 0x00332CE0 File Offset: 0x00330EE0
			// (set) Token: 0x0600D041 RID: 53313 RVA: 0x0006F8B6 File Offset: 0x0006DAB6
			public unsafe Vector3 point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.NativeFieldInfoPtr_point);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.NativeFieldInfoPtr_point)) = value;
				}
			}

			// Token: 0x040085E3 RID: 34275
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040085E4 RID: 34276
			private static readonly IntPtr NativeFieldInfoPtr_speed;

			// Token: 0x040085E5 RID: 34277
			private static readonly IntPtr NativeFieldInfoPtr_point;

			// Token: 0x040085E6 RID: 34278
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085E7 RID: 34279
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200101F RID: 4127
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass63_0+<<SetRotation>g__OnRotation|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011A78 RID: 72312 RVA: 0x0040C19C File Offset: 0x0040A39C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique()
				{
					Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0>.NativeClassPtr, "<<SetRotation>g__OnRotation|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr);
					SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr, "<>1__state");
					SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr, "<>2__current");
					SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr, "<>4__this");
					SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr__src_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr, "<src>5__2");
					SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr__spd_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr, "<spd>5__3");
					SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr, 100678214);
					SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr, 100678215);
					SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr, 100678216);
					SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr, 100678217);
					SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr, 100678218);
					SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr, 100678219);
				}

				// Token: 0x06011A79 RID: 72313 RVA: 0x0040C2A4 File Offset: 0x0040A4A4
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A7A RID: 72314 RVA: 0x0040C2EC File Offset: 0x0040A4EC
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A7B RID: 72315 RVA: 0x0040C320 File Offset: 0x0040A520
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192268, XrefRangeEnd = 192280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005BD7 RID: 23511
				// (get) Token: 0x06011A7C RID: 72316 RVA: 0x0040C35C File Offset: 0x0040A55C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A7D RID: 72317 RVA: 0x0040C39C File Offset: 0x0040A59C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192280, XrefRangeEnd = 192286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005BD8 RID: 23512
				// (get) Token: 0x06011A7E RID: 72318 RVA: 0x0040C3D0 File Offset: 0x0040A5D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A7F RID: 72319 RVA: 0x0009972C File Offset: 0x0009792C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BD2 RID: 23506
				// (get) Token: 0x06011A80 RID: 72320 RVA: 0x0040C410 File Offset: 0x0040A610
				// (set) Token: 0x06011A81 RID: 72321 RVA: 0x00099735 File Offset: 0x00097935
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005BD3 RID: 23507
				// (get) Token: 0x06011A82 RID: 72322 RVA: 0x0040C438 File Offset: 0x0040A638
				// (set) Token: 0x06011A83 RID: 72323 RVA: 0x00099750 File Offset: 0x00097950
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BD4 RID: 23508
				// (get) Token: 0x06011A84 RID: 72324 RVA: 0x0040C468 File Offset: 0x0040A668
				// (set) Token: 0x06011A85 RID: 72325 RVA: 0x0009976F File Offset: 0x0009796F
				public unsafe SpellBase.__c__DisplayClass63_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase.__c__DisplayClass63_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BD5 RID: 23509
				// (get) Token: 0x06011A86 RID: 72326 RVA: 0x0040C498 File Offset: 0x0040A698
				// (set) Token: 0x06011A87 RID: 72327 RVA: 0x0009978E File Offset: 0x0009798E
				public unsafe Transform _src_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr__src_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr__src_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BD6 RID: 23510
				// (get) Token: 0x06011A88 RID: 72328 RVA: 0x0040C4C8 File Offset: 0x0040A6C8
				// (set) Token: 0x06011A89 RID: 72329 RVA: 0x000997AD File Offset: 0x000979AD
				public unsafe float _spd_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr__spd_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass63_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrSiObObUnique.NativeFieldInfoPtr__spd_5__3)) = value;
					}
				}

				// Token: 0x0400B27B RID: 45691
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B27C RID: 45692
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B27D RID: 45693
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B27E RID: 45694
				private static readonly IntPtr NativeFieldInfoPtr__src_5__2;

				// Token: 0x0400B27F RID: 45695
				private static readonly IntPtr NativeFieldInfoPtr__spd_5__3;

				// Token: 0x0400B280 RID: 45696
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B281 RID: 45697
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B282 RID: 45698
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B283 RID: 45699
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B284 RID: 45700
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B285 RID: 45701
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AEA RID: 2794
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass65_0")]
		public sealed class __c__DisplayClass65_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D042 RID: 53314 RVA: 0x00332D08 File Offset: 0x00330F08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_0()
			{
				Il2CppClassPointerStore<SpellBase.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<>c__DisplayClass65_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass65_0>.NativeClassPtr);
				SpellBase.__c__DisplayClass65_0.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass65_0>.NativeClassPtr, "center");
				SpellBase.__c__DisplayClass65_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass65_0>.NativeClassPtr, "<>9__1");
				SpellBase.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass65_0>.NativeClassPtr, 100678220);
				SpellBase.__c__DisplayClass65_0.NativeMethodInfoPtr__GetAllGuestsPosition_b__0_Internal_IEnumerable_1_Vector3_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass65_0>.NativeClassPtr, 100678221);
				SpellBase.__c__DisplayClass65_0.NativeMethodInfoPtr__GetAllGuestsPosition_b__1_Internal_Vector3_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass65_0>.NativeClassPtr, 100678222);
			}

			// Token: 0x0600D043 RID: 53315 RVA: 0x00332D98 File Offset: 0x00330F98
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass65_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D044 RID: 53316 RVA: 0x00332DD4 File Offset: 0x00330FD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192291, XrefRangeEnd = 192302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Vector3> _GetAllGuestsPosition_b__0(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass65_0.NativeMethodInfoPtr__GetAllGuestsPosition_b__0_Internal_IEnumerable_1_Vector3_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
			}

			// Token: 0x0600D045 RID: 53317 RVA: 0x00332E24 File Offset: 0x00331024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192302, XrefRangeEnd = 192307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _GetAllGuestsPosition_b__1(AStarInputGeneratorComponent y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass65_0.NativeMethodInfoPtr__GetAllGuestsPosition_b__1_Internal_Vector3_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D046 RID: 53318 RVA: 0x0006F8D1 File Offset: 0x0006DAD1
			public __c__DisplayClass65_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C7 RID: 17351
			// (get) Token: 0x0600D047 RID: 53319 RVA: 0x00332E74 File Offset: 0x00331074
			// (set) Token: 0x0600D048 RID: 53320 RVA: 0x0006F8DA File Offset: 0x0006DADA
			public unsafe bool center
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass65_0.NativeFieldInfoPtr_center);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass65_0.NativeFieldInfoPtr_center)) = value;
				}
			}

			// Token: 0x170043C8 RID: 17352
			// (get) Token: 0x0600D049 RID: 53321 RVA: 0x00332E9C File Offset: 0x0033109C
			// (set) Token: 0x0600D04A RID: 53322 RVA: 0x0006F8F5 File Offset: 0x0006DAF5
			public unsafe Func<AStarInputGeneratorComponent, Vector3> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass65_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AStarInputGeneratorComponent, Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass65_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085E8 RID: 34280
			private static readonly IntPtr NativeFieldInfoPtr_center;

			// Token: 0x040085E9 RID: 34281
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040085EA RID: 34282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085EB RID: 34283
			private static readonly IntPtr NativeMethodInfoPtr__GetAllGuestsPosition_b__0_Internal_IEnumerable_1_Vector3_GuestGroupController_0;

			// Token: 0x040085EC RID: 34284
			private static readonly IntPtr NativeMethodInfoPtr__GetAllGuestsPosition_b__1_Internal_Vector3_AStarInputGeneratorComponent_0;
		}

		// Token: 0x02000AEB RID: 2795
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D04B RID: 53323 RVA: 0x00332ECC File Offset: 0x003310CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr);
				SpellBase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, "<>9");
				SpellBase.__c.NativeFieldInfoPtr___9__82_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, "<>9__82_0");
				SpellBase.__c.NativeFieldInfoPtr___9__82_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, "<>9__82_1");
				SpellBase.__c.NativeFieldInfoPtr___9__83_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, "<>9__83_0");
				SpellBase.__c.NativeFieldInfoPtr___9__84_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, "<>9__84_0");
				SpellBase.__c.NativeFieldInfoPtr___9__84_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, "<>9__84_1");
				SpellBase.__c.NativeFieldInfoPtr___9__85_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, "<>9__85_1");
				SpellBase.__c.NativeFieldInfoPtr___9__86_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, "<>9__86_1");
				SpellBase.__c.NativeFieldInfoPtr___9__86_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, "<>9__86_2");
				SpellBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, 100678224);
				SpellBase.__c.NativeMethodInfoPtr__GetAllCookerTables_b__82_0_Internal_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, 100678225);
				SpellBase.__c.NativeMethodInfoPtr__GetAllCookerTables_b__82_1_Internal_Vector3_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, 100678226);
				SpellBase.__c.NativeMethodInfoPtr__GetAllTables_b__83_0_Internal_Vector3_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, 100678227);
				SpellBase.__c.NativeMethodInfoPtr__GetAllTablesData_b__84_0_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, 100678228);
				SpellBase.__c.NativeMethodInfoPtr__GetAllTablesData_b__84_1_Internal_Vector3_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, 100678229);
				SpellBase.__c.NativeMethodInfoPtr__GetAllTablesExceptOne_b__85_1_Internal_Vector3_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, 100678230);
				SpellBase.__c.NativeMethodInfoPtr__GetAllTablesDataExceptOne_b__86_1_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, 100678231);
				SpellBase.__c.NativeMethodInfoPtr__GetAllTablesDataExceptOne_b__86_2_Internal_Vector3_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr, 100678232);
			}

			// Token: 0x0600D04C RID: 53324 RVA: 0x00333060 File Offset: 0x00331260
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D04D RID: 53325 RVA: 0x0033309C File Offset: 0x0033129C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192307, XrefRangeEnd = 192311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllCookerTables_b__82_0(Vector3Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c.NativeMethodInfoPtr__GetAllCookerTables_b__82_0_Internal_Boolean_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D04E RID: 53326 RVA: 0x003330E8 File Offset: 0x003312E8
			[CallerCount(0)]
			public unsafe Vector3 _GetAllCookerTables_b__82_1(Vector3Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c.NativeMethodInfoPtr__GetAllCookerTables_b__82_1_Internal_Vector3_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D04F RID: 53327 RVA: 0x00333134 File Offset: 0x00331334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192311, XrefRangeEnd = 192312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _GetAllTables_b__83_0(KeyValuePair<int, TileManager.GuestTableData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c.NativeMethodInfoPtr__GetAllTables_b__83_0_Internal_Vector3_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D050 RID: 53328 RVA: 0x00333188 File Offset: 0x00331388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192312, XrefRangeEnd = 192313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAllTablesData_b__84_0(KeyValuePair<int, TileManager.GuestTableData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c.NativeMethodInfoPtr__GetAllTablesData_b__84_0_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D051 RID: 53329 RVA: 0x003331DC File Offset: 0x003313DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192313, XrefRangeEnd = 192314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _GetAllTablesData_b__84_1(KeyValuePair<int, TileManager.GuestTableData> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c.NativeMethodInfoPtr__GetAllTablesData_b__84_1_Internal_Vector3_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D052 RID: 53330 RVA: 0x00333230 File Offset: 0x00331430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192314, XrefRangeEnd = 192315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _GetAllTablesExceptOne_b__85_1(KeyValuePair<int, TileManager.GuestTableData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c.NativeMethodInfoPtr__GetAllTablesExceptOne_b__85_1_Internal_Vector3_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D053 RID: 53331 RVA: 0x00333284 File Offset: 0x00331484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192315, XrefRangeEnd = 192316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAllTablesDataExceptOne_b__86_1(KeyValuePair<int, TileManager.GuestTableData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c.NativeMethodInfoPtr__GetAllTablesDataExceptOne_b__86_1_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D054 RID: 53332 RVA: 0x003332D8 File Offset: 0x003314D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192316, XrefRangeEnd = 192317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _GetAllTablesDataExceptOne_b__86_2(KeyValuePair<int, TileManager.GuestTableData> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c.NativeMethodInfoPtr__GetAllTablesDataExceptOne_b__86_2_Internal_Vector3_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D055 RID: 53333 RVA: 0x0006F914 File Offset: 0x0006DB14
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C9 RID: 17353
			// (get) Token: 0x0600D056 RID: 53334 RVA: 0x0033332C File Offset: 0x0033152C
			// (set) Token: 0x0600D057 RID: 53335 RVA: 0x0006F91D File Offset: 0x0006DB1D
			public unsafe static SpellBase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpellBase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellBase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpellBase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043CA RID: 17354
			// (get) Token: 0x0600D058 RID: 53336 RVA: 0x00333354 File Offset: 0x00331554
			// (set) Token: 0x0600D059 RID: 53337 RVA: 0x0006F92F File Offset: 0x0006DB2F
			public unsafe static Func<Vector3Int, bool> __9__82_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpellBase.__c.NativeFieldInfoPtr___9__82_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpellBase.__c.NativeFieldInfoPtr___9__82_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043CB RID: 17355
			// (get) Token: 0x0600D05A RID: 53338 RVA: 0x0033337C File Offset: 0x0033157C
			// (set) Token: 0x0600D05B RID: 53339 RVA: 0x0006F941 File Offset: 0x0006DB41
			public unsafe static Func<Vector3Int, Vector3> __9__82_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpellBase.__c.NativeFieldInfoPtr___9__82_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Int, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpellBase.__c.NativeFieldInfoPtr___9__82_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043CC RID: 17356
			// (get) Token: 0x0600D05C RID: 53340 RVA: 0x003333A4 File Offset: 0x003315A4
			// (set) Token: 0x0600D05D RID: 53341 RVA: 0x0006F953 File Offset: 0x0006DB53
			public unsafe static Func<KeyValuePair<int, TileManager.GuestTableData>, Vector3> __9__83_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpellBase.__c.NativeFieldInfoPtr___9__83_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, TileManager.GuestTableData>, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpellBase.__c.NativeFieldInfoPtr___9__83_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043CD RID: 17357
			// (get) Token: 0x0600D05E RID: 53342 RVA: 0x003333CC File Offset: 0x003315CC
			// (set) Token: 0x0600D05F RID: 53343 RVA: 0x0006F965 File Offset: 0x0006DB65
			public unsafe static Func<KeyValuePair<int, TileManager.GuestTableData>, int> __9__84_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpellBase.__c.NativeFieldInfoPtr___9__84_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, TileManager.GuestTableData>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpellBase.__c.NativeFieldInfoPtr___9__84_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043CE RID: 17358
			// (get) Token: 0x0600D060 RID: 53344 RVA: 0x003333F4 File Offset: 0x003315F4
			// (set) Token: 0x0600D061 RID: 53345 RVA: 0x0006F977 File Offset: 0x0006DB77
			public unsafe static Func<KeyValuePair<int, TileManager.GuestTableData>, Vector3> __9__84_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpellBase.__c.NativeFieldInfoPtr___9__84_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, TileManager.GuestTableData>, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpellBase.__c.NativeFieldInfoPtr___9__84_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043CF RID: 17359
			// (get) Token: 0x0600D062 RID: 53346 RVA: 0x0033341C File Offset: 0x0033161C
			// (set) Token: 0x0600D063 RID: 53347 RVA: 0x0006F989 File Offset: 0x0006DB89
			public unsafe static Func<KeyValuePair<int, TileManager.GuestTableData>, Vector3> __9__85_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpellBase.__c.NativeFieldInfoPtr___9__85_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, TileManager.GuestTableData>, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpellBase.__c.NativeFieldInfoPtr___9__85_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D0 RID: 17360
			// (get) Token: 0x0600D064 RID: 53348 RVA: 0x00333444 File Offset: 0x00331644
			// (set) Token: 0x0600D065 RID: 53349 RVA: 0x0006F99B File Offset: 0x0006DB9B
			public unsafe static Func<KeyValuePair<int, TileManager.GuestTableData>, int> __9__86_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpellBase.__c.NativeFieldInfoPtr___9__86_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, TileManager.GuestTableData>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpellBase.__c.NativeFieldInfoPtr___9__86_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043D1 RID: 17361
			// (get) Token: 0x0600D066 RID: 53350 RVA: 0x0033346C File Offset: 0x0033166C
			// (set) Token: 0x0600D067 RID: 53351 RVA: 0x0006F9AD File Offset: 0x0006DBAD
			public unsafe static Func<KeyValuePair<int, TileManager.GuestTableData>, Vector3> __9__86_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SpellBase.__c.NativeFieldInfoPtr___9__86_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, TileManager.GuestTableData>, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SpellBase.__c.NativeFieldInfoPtr___9__86_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040085ED RID: 34285
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040085EE RID: 34286
			private static readonly IntPtr NativeFieldInfoPtr___9__82_0;

			// Token: 0x040085EF RID: 34287
			private static readonly IntPtr NativeFieldInfoPtr___9__82_1;

			// Token: 0x040085F0 RID: 34288
			private static readonly IntPtr NativeFieldInfoPtr___9__83_0;

			// Token: 0x040085F1 RID: 34289
			private static readonly IntPtr NativeFieldInfoPtr___9__84_0;

			// Token: 0x040085F2 RID: 34290
			private static readonly IntPtr NativeFieldInfoPtr___9__84_1;

			// Token: 0x040085F3 RID: 34291
			private static readonly IntPtr NativeFieldInfoPtr___9__85_1;

			// Token: 0x040085F4 RID: 34292
			private static readonly IntPtr NativeFieldInfoPtr___9__86_1;

			// Token: 0x040085F5 RID: 34293
			private static readonly IntPtr NativeFieldInfoPtr___9__86_2;

			// Token: 0x040085F6 RID: 34294
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040085F7 RID: 34295
			private static readonly IntPtr NativeMethodInfoPtr__GetAllCookerTables_b__82_0_Internal_Boolean_Vector3Int_0;

			// Token: 0x040085F8 RID: 34296
			private static readonly IntPtr NativeMethodInfoPtr__GetAllCookerTables_b__82_1_Internal_Vector3_Vector3Int_0;

			// Token: 0x040085F9 RID: 34297
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTables_b__83_0_Internal_Vector3_KeyValuePair_2_Int32_GuestTableData_0;

			// Token: 0x040085FA RID: 34298
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTablesData_b__84_0_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0;

			// Token: 0x040085FB RID: 34299
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTablesData_b__84_1_Internal_Vector3_KeyValuePair_2_Int32_GuestTableData_0;

			// Token: 0x040085FC RID: 34300
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTablesExceptOne_b__85_1_Internal_Vector3_KeyValuePair_2_Int32_GuestTableData_0;

			// Token: 0x040085FD RID: 34301
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTablesDataExceptOne_b__86_1_Internal_Int32_KeyValuePair_2_Int32_GuestTableData_0;

			// Token: 0x040085FE RID: 34302
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTablesDataExceptOne_b__86_2_Internal_Vector3_KeyValuePair_2_Int32_GuestTableData_0;
		}

		// Token: 0x02000AEC RID: 2796
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass85_0")]
		public sealed class __c__DisplayClass85_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D068 RID: 53352 RVA: 0x00333494 File Offset: 0x00331694
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass85_0()
			{
				Il2CppClassPointerStore<SpellBase.__c__DisplayClass85_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<>c__DisplayClass85_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass85_0>.NativeClassPtr);
				SpellBase.__c__DisplayClass85_0.NativeFieldInfoPtr_deskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass85_0>.NativeClassPtr, "deskCode");
				SpellBase.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass85_0>.NativeClassPtr, 100678233);
				SpellBase.__c__DisplayClass85_0.NativeMethodInfoPtr__GetAllTablesExceptOne_b__0_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass85_0>.NativeClassPtr, 100678234);
			}

			// Token: 0x0600D069 RID: 53353 RVA: 0x003334FC File Offset: 0x003316FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass85_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass85_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D06A RID: 53354 RVA: 0x00333538 File Offset: 0x00331738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192317, XrefRangeEnd = 192318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllTablesExceptOne_b__0(KeyValuePair<int, TileManager.GuestTableData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass85_0.NativeMethodInfoPtr__GetAllTablesExceptOne_b__0_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D06B RID: 53355 RVA: 0x0006F9BF File Offset: 0x0006DBBF
			public __c__DisplayClass85_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D2 RID: 17362
			// (get) Token: 0x0600D06C RID: 53356 RVA: 0x0033358C File Offset: 0x0033178C
			// (set) Token: 0x0600D06D RID: 53357 RVA: 0x0006F9C8 File Offset: 0x0006DBC8
			public unsafe int deskCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass85_0.NativeFieldInfoPtr_deskCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass85_0.NativeFieldInfoPtr_deskCode)) = value;
				}
			}

			// Token: 0x040085FF RID: 34303
			private static readonly IntPtr NativeFieldInfoPtr_deskCode;

			// Token: 0x04008600 RID: 34304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008601 RID: 34305
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTablesExceptOne_b__0_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0;
		}

		// Token: 0x02000AED RID: 2797
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SpellBase+<>c__DisplayClass86_0")]
		public sealed class __c__DisplayClass86_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D06E RID: 53358 RVA: 0x003335B4 File Offset: 0x003317B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass86_0()
			{
				Il2CppClassPointerStore<SpellBase.__c__DisplayClass86_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellBase>.NativeClassPtr, "<>c__DisplayClass86_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellBase.__c__DisplayClass86_0>.NativeClassPtr);
				SpellBase.__c__DisplayClass86_0.NativeFieldInfoPtr_deskCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellBase.__c__DisplayClass86_0>.NativeClassPtr, "deskCode");
				SpellBase.__c__DisplayClass86_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass86_0>.NativeClassPtr, 100678235);
				SpellBase.__c__DisplayClass86_0.NativeMethodInfoPtr__GetAllTablesDataExceptOne_b__0_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellBase.__c__DisplayClass86_0>.NativeClassPtr, 100678236);
			}

			// Token: 0x0600D06F RID: 53359 RVA: 0x0033361C File Offset: 0x0033181C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass86_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellBase.__c__DisplayClass86_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass86_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D070 RID: 53360 RVA: 0x00333658 File Offset: 0x00331858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192318, XrefRangeEnd = 192319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllTablesDataExceptOne_b__0(KeyValuePair<int, TileManager.GuestTableData> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellBase.__c__DisplayClass86_0.NativeMethodInfoPtr__GetAllTablesDataExceptOne_b__0_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D071 RID: 53361 RVA: 0x0006F9E3 File Offset: 0x0006DBE3
			public __c__DisplayClass86_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043D3 RID: 17363
			// (get) Token: 0x0600D072 RID: 53362 RVA: 0x003336AC File Offset: 0x003318AC
			// (set) Token: 0x0600D073 RID: 53363 RVA: 0x0006F9EC File Offset: 0x0006DBEC
			public unsafe int deskCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass86_0.NativeFieldInfoPtr_deskCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpellBase.__c__DisplayClass86_0.NativeFieldInfoPtr_deskCode)) = value;
				}
			}

			// Token: 0x04008602 RID: 34306
			private static readonly IntPtr NativeFieldInfoPtr_deskCode;

			// Token: 0x04008603 RID: 34307
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008604 RID: 34308
			private static readonly IntPtr NativeMethodInfoPtr__GetAllTablesDataExceptOne_b__0_Internal_Boolean_KeyValuePair_2_Int32_GuestTableData_0;
		}
	}
}
