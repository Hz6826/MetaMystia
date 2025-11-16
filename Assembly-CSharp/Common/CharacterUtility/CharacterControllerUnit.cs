using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x02000458 RID: 1112
	public class CharacterControllerUnit : MonoBehaviour
	{
		// Token: 0x06007AAC RID: 31404 RVA: 0x002357A0 File Offset: 0x002339A0
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterControllerUnit()
		{
			Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.CharacterUtility", "CharacterControllerUnit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr);
			CharacterControllerUnit.NativeFieldInfoPtr_BASE_MOVE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "BASE_MOVE_SPEED");
			CharacterControllerUnit.NativeFieldInfoPtr_SPRINT_SPEED_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "SPRINT_SPEED_MULTIPLIER");
			CharacterControllerUnit.NativeFieldInfoPtr_pfxRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "pfxRenderer");
			CharacterControllerUnit.NativeFieldInfoPtr_baseRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "baseRenderer");
			CharacterControllerUnit.NativeFieldInfoPtr_faceRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "faceRenderer");
			CharacterControllerUnit.NativeFieldInfoPtr_hairRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "hairRenderer");
			CharacterControllerUnit.NativeFieldInfoPtr_mainRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "mainRenderer");
			CharacterControllerUnit.NativeFieldInfoPtr_backRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "backRenderer");
			CharacterControllerUnit.NativeFieldInfoPtr_shadowRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "shadowRenderer");
			CharacterControllerUnit.NativeFieldInfoPtr_frontTrimParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "frontTrimParent");
			CharacterControllerUnit.NativeFieldInfoPtr_faceTrimParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "faceTrimParent");
			CharacterControllerUnit.NativeFieldInfoPtr_wingTrimParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "wingTrimParent");
			CharacterControllerUnit.NativeFieldInfoPtr_behindTrimParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "behindTrimParent");
			CharacterControllerUnit.NativeFieldInfoPtr_accompanyingTrimParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "accompanyingTrimParent");
			CharacterControllerUnit.NativeFieldInfoPtr_connectedToParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "connectedToParent");
			CharacterControllerUnit.NativeFieldInfoPtr_animationPlaySpeedLerpRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "animationPlaySpeedLerpRange");
			CharacterControllerUnit.NativeFieldInfoPtr_stepSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "stepSFX");
			CharacterControllerUnit.NativeFieldInfoPtr_accompanyingTrim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "accompanyingTrim");
			CharacterControllerUnit.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "animator");
			CharacterControllerUnit.NativeFieldInfoPtr_cachedRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "cachedRotation");
			CharacterControllerUnit.NativeFieldInfoPtr_cl2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "cl2d");
			CharacterControllerUnit.NativeFieldInfoPtr_extraMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "extraMoveSpeed");
			CharacterControllerUnit.NativeFieldInfoPtr_hasCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "hasCollider");
			CharacterControllerUnit.NativeFieldInfoPtr_inputDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "inputDirection");
			CharacterControllerUnit.NativeFieldInfoPtr_inputProcessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "inputProcessors");
			CharacterControllerUnit.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "isMoving");
			CharacterControllerUnit.NativeFieldInfoPtr_m_CurrentVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "m_CurrentVisual");
			CharacterControllerUnit.NativeFieldInfoPtr_rb2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "rb2d");
			CharacterControllerUnit.NativeFieldInfoPtr_scheduledRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "scheduledRotation");
			CharacterControllerUnit.NativeFieldInfoPtr_sprintMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "sprintMultiplier");
			CharacterControllerUnit.NativeFieldInfoPtr__ExtraYOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "<ExtraYOffset>k__BackingField");
			CharacterControllerUnit.NativeFieldInfoPtr__MoveSpeedMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "<MoveSpeedMultiplier>k__BackingField");
			CharacterControllerUnit.NativeMethodInfoPtr_get_AllSpriteRenderers_Public_get_Il2CppReferenceArray_1_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687890);
			CharacterControllerUnit.NativeMethodInfoPtr_get_CanDetachTrimNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687891);
			CharacterControllerUnit.NativeMethodInfoPtr_set_DoSprint_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687892);
			CharacterControllerUnit.NativeMethodInfoPtr_get_ExtraYOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687893);
			CharacterControllerUnit.NativeMethodInfoPtr_set_ExtraYOffset_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687894);
			CharacterControllerUnit.NativeMethodInfoPtr_set_OverrideLayerName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687895);
			CharacterControllerUnit.NativeMethodInfoPtr_get_CurrentMoveSpeed_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687896);
			CharacterControllerUnit.NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687897);
			CharacterControllerUnit.NativeMethodInfoPtr_set_MoveSpeedMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687898);
			CharacterControllerUnit.NativeMethodInfoPtr_get_CurrentRotation_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687899);
			CharacterControllerUnit.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687900);
			CharacterControllerUnit.NativeMethodInfoPtr_set_IsMoving_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687901);
			CharacterControllerUnit.NativeMethodInfoPtr_get_ShouldHaveStepSFX_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687902);
			CharacterControllerUnit.NativeMethodInfoPtr_set_ShouldHaveStepSFX_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687903);
			CharacterControllerUnit.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687904);
			CharacterControllerUnit.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687905);
			CharacterControllerUnit.NativeMethodInfoPtr_SetShadow_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687906);
			CharacterControllerUnit.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687907);
			CharacterControllerUnit.NativeMethodInfoPtr_GetInputProcessor_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687908);
			CharacterControllerUnit.NativeMethodInfoPtr_AddInputProcessor_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687909);
			CharacterControllerUnit.NativeMethodInfoPtr_TryUpdateCurrent_Private_Boolean_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687910);
			CharacterControllerUnit.NativeMethodInfoPtr_UpdateCharacterSprite_Public_Void_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687911);
			CharacterControllerUnit.NativeMethodInfoPtr_UpdateColliderStatus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687912);
			CharacterControllerUnit.NativeMethodInfoPtr_UpdateInputVelocity_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687913);
			CharacterControllerUnit.NativeMethodInfoPtr_SetRotation_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687914);
			CharacterControllerUnit.NativeMethodInfoPtr_SetFace_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687915);
			CharacterControllerUnit.NativeMethodInfoPtr_SetStepManual_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687916);
			CharacterControllerUnit.NativeMethodInfoPtr_SetExtraSpeed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687917);
			CharacterControllerUnit.NativeMethodInfoPtr_FixedUpdateMoving_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687918);
			CharacterControllerUnit.NativeMethodInfoPtr_GetTargetMovePosition_Public_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687919);
			CharacterControllerUnit.NativeMethodInfoPtr_UpdateVisualRepresentation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687920);
			CharacterControllerUnit.NativeMethodInfoPtr_SetAnimator_Private_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687921);
			CharacterControllerUnit.NativeMethodInfoPtr_TrySpawnAccompanyingTrim_Private_Void_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687922);
			CharacterControllerUnit.NativeMethodInfoPtr_SetTrimParent_Private_Void_TrimPosition_CharacterControllerUnit_CharacterControllerUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687923);
			CharacterControllerUnit.NativeMethodInfoPtr_TryGet_Private_Boolean_byref_CharacterControllerUnit_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687924);
			CharacterControllerUnit.NativeMethodInfoPtr_TryDetach_Public_Boolean_byref_CharacterControllerUnit_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687925);
			CharacterControllerUnit.NativeMethodInfoPtr_TryConnect_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687926);
			CharacterControllerUnit.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687927);
			CharacterControllerUnit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687928);
			CharacterControllerUnit.NativeMethodInfoPtr_Method_Internal_Static_Vector2Int_Vector2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, 100687929);
		}

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x06007AAD RID: 31405 RVA: 0x00235D70 File Offset: 0x00233F70
		public unsafe Il2CppReferenceArray<SpriteRenderer> AllSpriteRenderers
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 295048, RefRangeEnd = 295053, XrefRangeStart = 294968, XrefRangeEnd = 295048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_get_AllSpriteRenderers_Public_get_Il2CppReferenceArray_1_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteRenderer>>(intPtr3) : null;
			}
		}

		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x06007AAE RID: 31406 RVA: 0x00235DB0 File Offset: 0x00233FB0
		public unsafe int CanDetachTrimNum
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 295072, RefRangeEnd = 295075, XrefRangeStart = 295053, XrefRangeEnd = 295072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_get_CanDetachTrimNum_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170029AB RID: 10667
		// (set) Token: 0x06007AAF RID: 31407 RVA: 0x00235DEC File Offset: 0x00233FEC
		public unsafe bool DoSprint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295075, XrefRangeEnd = 295076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_set_DoSprint_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x06007AB0 RID: 31408 RVA: 0x00235E2C File Offset: 0x0023402C
		// (set) Token: 0x06007AB1 RID: 31409 RVA: 0x00235E68 File Offset: 0x00234068
		public unsafe float ExtraYOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_get_ExtraYOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_set_ExtraYOffset_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029AD RID: 10669
		// (set) Token: 0x06007AB2 RID: 31410 RVA: 0x00235EA8 File Offset: 0x002340A8
		public unsafe string OverrideLayerName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 295084, RefRangeEnd = 295087, XrefRangeStart = 295076, XrefRangeEnd = 295084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_set_OverrideLayerName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x06007AB3 RID: 31411 RVA: 0x00235EEC File Offset: 0x002340EC
		public unsafe float CurrentMoveSpeed
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 295092, RefRangeEnd = 295095, XrefRangeStart = 295087, XrefRangeEnd = 295092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_get_CurrentMoveSpeed_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x06007AB4 RID: 31412 RVA: 0x00235F28 File Offset: 0x00234128
		// (set) Token: 0x06007AB5 RID: 31413 RVA: 0x00235F64 File Offset: 0x00234164
		public unsafe float MoveSpeedMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_set_MoveSpeedMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x06007AB6 RID: 31414 RVA: 0x00235FA4 File Offset: 0x002341A4
		public unsafe int CurrentRotation
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 295098, RefRangeEnd = 295101, XrefRangeStart = 295095, XrefRangeEnd = 295098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_get_CurrentRotation_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x06007AB7 RID: 31415 RVA: 0x00235FE0 File Offset: 0x002341E0
		// (set) Token: 0x06007AB8 RID: 31416 RVA: 0x0023601C File Offset: 0x0023421C
		public unsafe bool IsMoving
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 295115, RefRangeEnd = 295125, XrefRangeStart = 295101, XrefRangeEnd = 295115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_set_IsMoving_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x06007AB9 RID: 31417 RVA: 0x0023605C File Offset: 0x0023425C
		// (set) Token: 0x06007ABA RID: 31418 RVA: 0x00236098 File Offset: 0x00234298
		public unsafe bool ShouldHaveStepSFX
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_get_ShouldHaveStepSFX_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 295125, RefRangeEnd = 295128, XrefRangeStart = 295125, XrefRangeEnd = 295125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_set_ShouldHaveStepSFX_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007ABB RID: 31419 RVA: 0x002360D8 File Offset: 0x002342D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295128, XrefRangeEnd = 295145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x0023610C File Offset: 0x0023430C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295145, XrefRangeEnd = 295147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ABD RID: 31421 RVA: 0x00236140 File Offset: 0x00234340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295147, XrefRangeEnd = 295149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShadow(bool shadowOpen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shadowOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_SetShadow_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ABE RID: 31422 RVA: 0x00236180 File Offset: 0x00234380
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 295172, RefRangeEnd = 295181, XrefRangeStart = 295149, XrefRangeEnd = 295172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(CharacterSpriteSetCompact compactOrFullvisual, float moveSpeedMultiplier, bool shouldTurnOnCollider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(compactOrFullvisual);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeedMultiplier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldTurnOnCollider;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ABF RID: 31423 RVA: 0x002361E0 File Offset: 0x002343E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295182, RefRangeEnd = 295183, XrefRangeStart = 295181, XrefRangeEnd = 295182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetInputProcessor<T>() where T : CharacterControllerUnitInputProcessorComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.MethodInfoStoreGeneric_GetInputProcessor_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06007AC0 RID: 31424 RVA: 0x0023621C File Offset: 0x0023441C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295188, RefRangeEnd = 295190, XrefRangeStart = 295183, XrefRangeEnd = 295188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T AddInputProcessor<T>() where T : CharacterControllerUnitInputProcessorComponent
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.MethodInfoStoreGeneric_AddInputProcessor_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06007AC1 RID: 31425 RVA: 0x00236258 File Offset: 0x00234458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295190, XrefRangeEnd = 295195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryUpdateCurrent(CharacterSpriteSetCompact visual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_TryUpdateCurrent_Private_Boolean_CharacterSpriteSetCompact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007AC2 RID: 31426 RVA: 0x002362A8 File Offset: 0x002344A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 295259, RefRangeEnd = 295264, XrefRangeStart = 295195, XrefRangeEnd = 295259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCharacterSprite(CharacterSpriteSetCompact compactOrFullVisual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(compactOrFullVisual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_UpdateCharacterSprite_Public_Void_CharacterSpriteSetCompact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AC3 RID: 31427 RVA: 0x002362EC File Offset: 0x002344EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295272, RefRangeEnd = 295274, XrefRangeStart = 295264, XrefRangeEnd = 295272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColliderStatus(bool shouldOpen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shouldOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_UpdateColliderStatus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x0023632C File Offset: 0x0023452C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295279, RefRangeEnd = 295282, XrefRangeStart = 295274, XrefRangeEnd = 295279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputVelocity(Vector2 inputDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_UpdateInputVelocity_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AC5 RID: 31429 RVA: 0x0023636C File Offset: 0x0023456C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 295288, RefRangeEnd = 295310, XrefRangeStart = 295282, XrefRangeEnd = 295288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRotation(int rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_SetRotation_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AC6 RID: 31430 RVA: 0x002363AC File Offset: 0x002345AC
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 295318, RefRangeEnd = 295341, XrefRangeStart = 295310, XrefRangeEnd = 295318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFace(int faceId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref faceId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_SetFace_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AC7 RID: 31431 RVA: 0x002363EC File Offset: 0x002345EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295342, RefRangeEnd = 295344, XrefRangeStart = 295341, XrefRangeEnd = 295342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStepManual(int step)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_SetStepManual_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AC8 RID: 31432 RVA: 0x0023642C File Offset: 0x0023462C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 295350, RefRangeEnd = 295356, XrefRangeStart = 295344, XrefRangeEnd = 295350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExtraSpeed(float extraSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref extraSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_SetExtraSpeed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AC9 RID: 31433 RVA: 0x0023646C File Offset: 0x0023466C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295356, XrefRangeEnd = 295362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdateMoving()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_FixedUpdateMoving_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ACA RID: 31434 RVA: 0x002364A0 File Offset: 0x002346A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295370, RefRangeEnd = 295373, XrefRangeStart = 295362, XrefRangeEnd = 295370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetTargetMovePosition(Vector3 inputDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_GetTargetMovePosition_Public_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007ACB RID: 31435 RVA: 0x002364EC File Offset: 0x002346EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295395, RefRangeEnd = 295396, XrefRangeStart = 295373, XrefRangeEnd = 295395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisualRepresentation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_UpdateVisualRepresentation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ACC RID: 31436 RVA: 0x00236520 File Offset: 0x00234720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295396, XrefRangeEnd = 295397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimator(sbyte currentRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_SetAnimator_Private_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ACD RID: 31437 RVA: 0x00236560 File Offset: 0x00234760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295477, RefRangeEnd = 295478, XrefRangeStart = 295397, XrefRangeEnd = 295477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrySpawnAccompanyingTrim(CharacterSpriteSetCompact visualCompact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visualCompact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_TrySpawnAccompanyingTrim_Private_Void_CharacterSpriteSetCompact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ACE RID: 31438 RVA: 0x002365A4 File Offset: 0x002347A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295478, XrefRangeEnd = 295490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrimParent(CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition index, CharacterControllerUnit newAccompanyingTrim, CharacterControllerUnit parentTrim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newAccompanyingTrim);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentTrim);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_SetTrimParent_Private_Void_TrimPosition_CharacterControllerUnit_CharacterControllerUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007ACF RID: 31439 RVA: 0x00236608 File Offset: 0x00234808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295490, XrefRangeEnd = 295498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGet(out CharacterControllerUnit detachControllerUnit, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_TryGet_Private_Boolean_byref_CharacterControllerUnit_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			detachControllerUnit = ((intPtr4 == 0) ? null : new CharacterControllerUnit(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06007AD0 RID: 31440 RVA: 0x00236674 File Offset: 0x00234874
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 295523, RefRangeEnd = 295527, XrefRangeStart = 295498, XrefRangeEnd = 295523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryDetach(out CharacterControllerUnit detachControllerUnit, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_TryDetach_Public_Boolean_byref_CharacterControllerUnit_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			detachControllerUnit = ((intPtr4 == 0) ? null : new CharacterControllerUnit(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06007AD1 RID: 31441 RVA: 0x002366E0 File Offset: 0x002348E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295597, RefRangeEnd = 295600, XrefRangeStart = 295527, XrefRangeEnd = 295597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryConnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_TryConnect_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007AD2 RID: 31442 RVA: 0x0023671C File Offset: 0x0023491C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295600, XrefRangeEnd = 295631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterControllerUnit.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AD3 RID: 31443 RVA: 0x00236758 File Offset: 0x00234958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295631, XrefRangeEnd = 295646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterControllerUnit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AD4 RID: 31444 RVA: 0x00236794 File Offset: 0x00234994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295646, XrefRangeEnd = 295647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2Int Method_Internal_Static_Vector2Int_Vector2_PDM_0(Vector2 value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.NativeMethodInfoPtr_Method_Internal_Static_Vector2Int_Vector2_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x00042306 File Offset: 0x00040506
		public CharacterControllerUnit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002989 RID: 10633
		// (get) Token: 0x06007AD6 RID: 31446 RVA: 0x002367D4 File Offset: 0x002349D4
		// (set) Token: 0x06007AD7 RID: 31447 RVA: 0x0004230F File Offset: 0x0004050F
		public unsafe static int BASE_MOVE_SPEED
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CharacterControllerUnit.NativeFieldInfoPtr_BASE_MOVE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterControllerUnit.NativeFieldInfoPtr_BASE_MOVE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x06007AD8 RID: 31448 RVA: 0x002367F0 File Offset: 0x002349F0
		// (set) Token: 0x06007AD9 RID: 31449 RVA: 0x0004231D File Offset: 0x0004051D
		public unsafe static float SPRINT_SPEED_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CharacterControllerUnit.NativeFieldInfoPtr_SPRINT_SPEED_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterControllerUnit.NativeFieldInfoPtr_SPRINT_SPEED_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x06007ADA RID: 31450 RVA: 0x0023680C File Offset: 0x00234A0C
		// (set) Token: 0x06007ADB RID: 31451 RVA: 0x0004232B File Offset: 0x0004052B
		public unsafe SpriteRenderer pfxRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_pfxRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_pfxRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x06007ADC RID: 31452 RVA: 0x0023683C File Offset: 0x00234A3C
		// (set) Token: 0x06007ADD RID: 31453 RVA: 0x0004234A File Offset: 0x0004054A
		public unsafe SpriteRenderer baseRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_baseRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_baseRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x06007ADE RID: 31454 RVA: 0x0023686C File Offset: 0x00234A6C
		// (set) Token: 0x06007ADF RID: 31455 RVA: 0x00042369 File Offset: 0x00040569
		public unsafe SpriteRenderer faceRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_faceRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_faceRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x06007AE0 RID: 31456 RVA: 0x0023689C File Offset: 0x00234A9C
		// (set) Token: 0x06007AE1 RID: 31457 RVA: 0x00042388 File Offset: 0x00040588
		public unsafe SpriteRenderer hairRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_hairRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_hairRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x06007AE2 RID: 31458 RVA: 0x002368CC File Offset: 0x00234ACC
		// (set) Token: 0x06007AE3 RID: 31459 RVA: 0x000423A7 File Offset: 0x000405A7
		public unsafe SpriteRenderer mainRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_mainRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_mainRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002990 RID: 10640
		// (get) Token: 0x06007AE4 RID: 31460 RVA: 0x002368FC File Offset: 0x00234AFC
		// (set) Token: 0x06007AE5 RID: 31461 RVA: 0x000423C6 File Offset: 0x000405C6
		public unsafe SpriteRenderer backRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_backRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_backRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002991 RID: 10641
		// (get) Token: 0x06007AE6 RID: 31462 RVA: 0x0023692C File Offset: 0x00234B2C
		// (set) Token: 0x06007AE7 RID: 31463 RVA: 0x000423E5 File Offset: 0x000405E5
		public unsafe SpriteRenderer shadowRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_shadowRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_shadowRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002992 RID: 10642
		// (get) Token: 0x06007AE8 RID: 31464 RVA: 0x0023695C File Offset: 0x00234B5C
		// (set) Token: 0x06007AE9 RID: 31465 RVA: 0x00042404 File Offset: 0x00040604
		public unsafe Transform frontTrimParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_frontTrimParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_frontTrimParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x06007AEA RID: 31466 RVA: 0x0023698C File Offset: 0x00234B8C
		// (set) Token: 0x06007AEB RID: 31467 RVA: 0x00042423 File Offset: 0x00040623
		public unsafe Transform faceTrimParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_faceTrimParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_faceTrimParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x06007AEC RID: 31468 RVA: 0x002369BC File Offset: 0x00234BBC
		// (set) Token: 0x06007AED RID: 31469 RVA: 0x00042442 File Offset: 0x00040642
		public unsafe Transform wingTrimParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_wingTrimParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_wingTrimParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x06007AEE RID: 31470 RVA: 0x002369EC File Offset: 0x00234BEC
		// (set) Token: 0x06007AEF RID: 31471 RVA: 0x00042461 File Offset: 0x00040661
		public unsafe Transform behindTrimParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_behindTrimParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_behindTrimParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x06007AF0 RID: 31472 RVA: 0x00236A1C File Offset: 0x00234C1C
		// (set) Token: 0x06007AF1 RID: 31473 RVA: 0x00042480 File Offset: 0x00040680
		public unsafe CharacterControllerUnit accompanyingTrimParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_accompanyingTrimParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_accompanyingTrimParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x06007AF2 RID: 31474 RVA: 0x00236A4C File Offset: 0x00234C4C
		// (set) Token: 0x06007AF3 RID: 31475 RVA: 0x0004249F File Offset: 0x0004069F
		public unsafe bool connectedToParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_connectedToParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_connectedToParent)) = value;
			}
		}

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x06007AF4 RID: 31476 RVA: 0x00236A74 File Offset: 0x00234C74
		// (set) Token: 0x06007AF5 RID: 31477 RVA: 0x000424BA File Offset: 0x000406BA
		public unsafe Vector2 animationPlaySpeedLerpRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_animationPlaySpeedLerpRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_animationPlaySpeedLerpRange)) = value;
			}
		}

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x06007AF6 RID: 31478 RVA: 0x00236A9C File Offset: 0x00234C9C
		// (set) Token: 0x06007AF7 RID: 31479 RVA: 0x000424D5 File Offset: 0x000406D5
		public unsafe Il2CppReferenceArray<AudioClip> stepSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_stepSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_stepSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x06007AF8 RID: 31480 RVA: 0x00236ACC File Offset: 0x00234CCC
		// (set) Token: 0x06007AF9 RID: 31481 RVA: 0x000424F4 File Offset: 0x000406F4
		public unsafe List<ValueTuple<CharacterControllerUnit, bool, CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition, bool>> accompanyingTrim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_accompanyingTrim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<CharacterControllerUnit, bool, CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition, bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_accompanyingTrim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x06007AFA RID: 31482 RVA: 0x00236AFC File Offset: 0x00234CFC
		// (set) Token: 0x06007AFB RID: 31483 RVA: 0x00042513 File Offset: 0x00040713
		public unsafe CharacterAnimator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x06007AFC RID: 31484 RVA: 0x00236B2C File Offset: 0x00234D2C
		// (set) Token: 0x06007AFD RID: 31485 RVA: 0x00042532 File Offset: 0x00040732
		public unsafe sbyte cachedRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_cachedRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_cachedRotation)) = value;
			}
		}

		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x06007AFE RID: 31486 RVA: 0x00236B54 File Offset: 0x00234D54
		// (set) Token: 0x06007AFF RID: 31487 RVA: 0x0004254D File Offset: 0x0004074D
		public unsafe PolygonCollider2D cl2d
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_cl2d);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_cl2d), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x06007B00 RID: 31488 RVA: 0x00236B84 File Offset: 0x00234D84
		// (set) Token: 0x06007B01 RID: 31489 RVA: 0x0004256C File Offset: 0x0004076C
		public unsafe float extraMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_extraMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_extraMoveSpeed)) = value;
			}
		}

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x06007B02 RID: 31490 RVA: 0x00236BAC File Offset: 0x00234DAC
		// (set) Token: 0x06007B03 RID: 31491 RVA: 0x00042587 File Offset: 0x00040787
		public unsafe bool hasCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_hasCollider);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_hasCollider)) = value;
			}
		}

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x06007B04 RID: 31492 RVA: 0x00236BD4 File Offset: 0x00234DD4
		// (set) Token: 0x06007B05 RID: 31493 RVA: 0x000425A2 File Offset: 0x000407A2
		public unsafe Vector3 inputDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_inputDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_inputDirection)) = value;
			}
		}

		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x06007B06 RID: 31494 RVA: 0x00236BFC File Offset: 0x00234DFC
		// (set) Token: 0x06007B07 RID: 31495 RVA: 0x000425BD File Offset: 0x000407BD
		public unsafe Il2CppReferenceArray<CharacterControllerUnitInputProcessorComponent> inputProcessors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_inputProcessors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterControllerUnitInputProcessorComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_inputProcessors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x06007B08 RID: 31496 RVA: 0x00236C2C File Offset: 0x00234E2C
		// (set) Token: 0x06007B09 RID: 31497 RVA: 0x000425DC File Offset: 0x000407DC
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x06007B0A RID: 31498 RVA: 0x00236C54 File Offset: 0x00234E54
		// (set) Token: 0x06007B0B RID: 31499 RVA: 0x000425F7 File Offset: 0x000407F7
		public unsafe CharacterSpriteSetCompact m_CurrentVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_m_CurrentVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_m_CurrentVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x06007B0C RID: 31500 RVA: 0x00236C84 File Offset: 0x00234E84
		// (set) Token: 0x06007B0D RID: 31501 RVA: 0x00042616 File Offset: 0x00040816
		public unsafe Rigidbody2D rb2d
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_rb2d);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_rb2d), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x06007B0E RID: 31502 RVA: 0x00236CB4 File Offset: 0x00234EB4
		// (set) Token: 0x06007B0F RID: 31503 RVA: 0x00042635 File Offset: 0x00040835
		public unsafe sbyte scheduledRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_scheduledRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_scheduledRotation)) = value;
			}
		}

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x06007B10 RID: 31504 RVA: 0x00236CDC File Offset: 0x00234EDC
		// (set) Token: 0x06007B11 RID: 31505 RVA: 0x00042650 File Offset: 0x00040850
		public unsafe float sprintMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_sprintMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr_sprintMultiplier)) = value;
			}
		}

		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x06007B12 RID: 31506 RVA: 0x00236D04 File Offset: 0x00234F04
		// (set) Token: 0x06007B13 RID: 31507 RVA: 0x0004266B File Offset: 0x0004086B
		public unsafe float _ExtraYOffset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr__ExtraYOffset_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr__ExtraYOffset_k__BackingField)) = value;
			}
		}

		// Token: 0x170029A8 RID: 10664
		// (get) Token: 0x06007B14 RID: 31508 RVA: 0x00236D2C File Offset: 0x00234F2C
		// (set) Token: 0x06007B15 RID: 31509 RVA: 0x00042686 File Offset: 0x00040886
		public unsafe float _MoveSpeedMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr__MoveSpeedMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerUnit.NativeFieldInfoPtr__MoveSpeedMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x040050B6 RID: 20662
		private static readonly IntPtr NativeFieldInfoPtr_BASE_MOVE_SPEED;

		// Token: 0x040050B7 RID: 20663
		private static readonly IntPtr NativeFieldInfoPtr_SPRINT_SPEED_MULTIPLIER;

		// Token: 0x040050B8 RID: 20664
		private static readonly IntPtr NativeFieldInfoPtr_pfxRenderer;

		// Token: 0x040050B9 RID: 20665
		private static readonly IntPtr NativeFieldInfoPtr_baseRenderer;

		// Token: 0x040050BA RID: 20666
		private static readonly IntPtr NativeFieldInfoPtr_faceRenderer;

		// Token: 0x040050BB RID: 20667
		private static readonly IntPtr NativeFieldInfoPtr_hairRenderer;

		// Token: 0x040050BC RID: 20668
		private static readonly IntPtr NativeFieldInfoPtr_mainRenderer;

		// Token: 0x040050BD RID: 20669
		private static readonly IntPtr NativeFieldInfoPtr_backRenderer;

		// Token: 0x040050BE RID: 20670
		private static readonly IntPtr NativeFieldInfoPtr_shadowRenderer;

		// Token: 0x040050BF RID: 20671
		private static readonly IntPtr NativeFieldInfoPtr_frontTrimParent;

		// Token: 0x040050C0 RID: 20672
		private static readonly IntPtr NativeFieldInfoPtr_faceTrimParent;

		// Token: 0x040050C1 RID: 20673
		private static readonly IntPtr NativeFieldInfoPtr_wingTrimParent;

		// Token: 0x040050C2 RID: 20674
		private static readonly IntPtr NativeFieldInfoPtr_behindTrimParent;

		// Token: 0x040050C3 RID: 20675
		private static readonly IntPtr NativeFieldInfoPtr_accompanyingTrimParent;

		// Token: 0x040050C4 RID: 20676
		private static readonly IntPtr NativeFieldInfoPtr_connectedToParent;

		// Token: 0x040050C5 RID: 20677
		private static readonly IntPtr NativeFieldInfoPtr_animationPlaySpeedLerpRange;

		// Token: 0x040050C6 RID: 20678
		private static readonly IntPtr NativeFieldInfoPtr_stepSFX;

		// Token: 0x040050C7 RID: 20679
		private static readonly IntPtr NativeFieldInfoPtr_accompanyingTrim;

		// Token: 0x040050C8 RID: 20680
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040050C9 RID: 20681
		private static readonly IntPtr NativeFieldInfoPtr_cachedRotation;

		// Token: 0x040050CA RID: 20682
		private static readonly IntPtr NativeFieldInfoPtr_cl2d;

		// Token: 0x040050CB RID: 20683
		private static readonly IntPtr NativeFieldInfoPtr_extraMoveSpeed;

		// Token: 0x040050CC RID: 20684
		private static readonly IntPtr NativeFieldInfoPtr_hasCollider;

		// Token: 0x040050CD RID: 20685
		private static readonly IntPtr NativeFieldInfoPtr_inputDirection;

		// Token: 0x040050CE RID: 20686
		private static readonly IntPtr NativeFieldInfoPtr_inputProcessors;

		// Token: 0x040050CF RID: 20687
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x040050D0 RID: 20688
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentVisual;

		// Token: 0x040050D1 RID: 20689
		private static readonly IntPtr NativeFieldInfoPtr_rb2d;

		// Token: 0x040050D2 RID: 20690
		private static readonly IntPtr NativeFieldInfoPtr_scheduledRotation;

		// Token: 0x040050D3 RID: 20691
		private static readonly IntPtr NativeFieldInfoPtr_sprintMultiplier;

		// Token: 0x040050D4 RID: 20692
		private static readonly IntPtr NativeFieldInfoPtr__ExtraYOffset_k__BackingField;

		// Token: 0x040050D5 RID: 20693
		private static readonly IntPtr NativeFieldInfoPtr__MoveSpeedMultiplier_k__BackingField;

		// Token: 0x040050D6 RID: 20694
		private static readonly IntPtr NativeMethodInfoPtr_get_AllSpriteRenderers_Public_get_Il2CppReferenceArray_1_SpriteRenderer_0;

		// Token: 0x040050D7 RID: 20695
		private static readonly IntPtr NativeMethodInfoPtr_get_CanDetachTrimNum_Public_get_Int32_0;

		// Token: 0x040050D8 RID: 20696
		private static readonly IntPtr NativeMethodInfoPtr_set_DoSprint_Public_set_Void_Boolean_0;

		// Token: 0x040050D9 RID: 20697
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraYOffset_Public_get_Single_0;

		// Token: 0x040050DA RID: 20698
		private static readonly IntPtr NativeMethodInfoPtr_set_ExtraYOffset_Private_set_Void_Single_0;

		// Token: 0x040050DB RID: 20699
		private static readonly IntPtr NativeMethodInfoPtr_set_OverrideLayerName_Public_set_Void_String_0;

		// Token: 0x040050DC RID: 20700
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentMoveSpeed_Private_get_Single_0;

		// Token: 0x040050DD RID: 20701
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveSpeedMultiplier_Public_get_Single_0;

		// Token: 0x040050DE RID: 20702
		private static readonly IntPtr NativeMethodInfoPtr_set_MoveSpeedMultiplier_Public_set_Void_Single_0;

		// Token: 0x040050DF RID: 20703
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentRotation_Public_get_Int32_0;

		// Token: 0x040050E0 RID: 20704
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0;

		// Token: 0x040050E1 RID: 20705
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMoving_Public_set_Void_Boolean_0;

		// Token: 0x040050E2 RID: 20706
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldHaveStepSFX_Public_get_Boolean_0;

		// Token: 0x040050E3 RID: 20707
		private static readonly IntPtr NativeMethodInfoPtr_set_ShouldHaveStepSFX_Public_set_Void_Boolean_0;

		// Token: 0x040050E4 RID: 20708
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040050E5 RID: 20709
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040050E6 RID: 20710
		private static readonly IntPtr NativeMethodInfoPtr_SetShadow_Public_Void_Boolean_0;

		// Token: 0x040050E7 RID: 20711
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_Single_Boolean_0;

		// Token: 0x040050E8 RID: 20712
		private static readonly IntPtr NativeMethodInfoPtr_GetInputProcessor_Public_T_0;

		// Token: 0x040050E9 RID: 20713
		private static readonly IntPtr NativeMethodInfoPtr_AddInputProcessor_Public_T_0;

		// Token: 0x040050EA RID: 20714
		private static readonly IntPtr NativeMethodInfoPtr_TryUpdateCurrent_Private_Boolean_CharacterSpriteSetCompact_0;

		// Token: 0x040050EB RID: 20715
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCharacterSprite_Public_Void_CharacterSpriteSetCompact_0;

		// Token: 0x040050EC RID: 20716
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColliderStatus_Public_Void_Boolean_0;

		// Token: 0x040050ED RID: 20717
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputVelocity_Public_Void_Vector2_0;

		// Token: 0x040050EE RID: 20718
		private static readonly IntPtr NativeMethodInfoPtr_SetRotation_Public_Void_Int32_0;

		// Token: 0x040050EF RID: 20719
		private static readonly IntPtr NativeMethodInfoPtr_SetFace_Public_Void_Int32_0;

		// Token: 0x040050F0 RID: 20720
		private static readonly IntPtr NativeMethodInfoPtr_SetStepManual_Public_Void_Int32_0;

		// Token: 0x040050F1 RID: 20721
		private static readonly IntPtr NativeMethodInfoPtr_SetExtraSpeed_Public_Void_Single_0;

		// Token: 0x040050F2 RID: 20722
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdateMoving_Private_Void_0;

		// Token: 0x040050F3 RID: 20723
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetMovePosition_Public_Vector2_Vector3_0;

		// Token: 0x040050F4 RID: 20724
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisualRepresentation_Private_Void_0;

		// Token: 0x040050F5 RID: 20725
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimator_Private_Void_SByte_0;

		// Token: 0x040050F6 RID: 20726
		private static readonly IntPtr NativeMethodInfoPtr_TrySpawnAccompanyingTrim_Private_Void_CharacterSpriteSetCompact_0;

		// Token: 0x040050F7 RID: 20727
		private static readonly IntPtr NativeMethodInfoPtr_SetTrimParent_Private_Void_TrimPosition_CharacterControllerUnit_CharacterControllerUnit_0;

		// Token: 0x040050F8 RID: 20728
		private static readonly IntPtr NativeMethodInfoPtr_TryGet_Private_Boolean_byref_CharacterControllerUnit_Int32_0;

		// Token: 0x040050F9 RID: 20729
		private static readonly IntPtr NativeMethodInfoPtr_TryDetach_Public_Boolean_byref_CharacterControllerUnit_Int32_0;

		// Token: 0x040050FA RID: 20730
		private static readonly IntPtr NativeMethodInfoPtr_TryConnect_Public_Boolean_0;

		// Token: 0x040050FB RID: 20731
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040050FC RID: 20732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040050FD RID: 20733
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector2Int_Vector2_PDM_0;

		// Token: 0x02000F94 RID: 3988
		[ObfuscatedName("Common.CharacterUtility.CharacterControllerUnit+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0601140F RID: 70671 RVA: 0x003F95B4 File Offset: 0x003F77B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr);
				CharacterControllerUnit.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr, "<>9");
				CharacterControllerUnit.__c.NativeFieldInfoPtr___9__31_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr, "<>9__31_1");
				CharacterControllerUnit.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr, "<>9__31_0");
				CharacterControllerUnit.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr, "<>9__33_0");
				CharacterControllerUnit.__c.NativeFieldInfoPtr___9__56_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr, "<>9__56_0");
				CharacterControllerUnit.__c.NativeFieldInfoPtr___9__74_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr, "<>9__74_0");
				CharacterControllerUnit.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr, 100687931);
				CharacterControllerUnit.__c.NativeMethodInfoPtr__get_AllSpriteRenderers_b__31_1_Internal_CharacterControllerUnit_ValueTuple_4_CharacterControllerUnit_Boolean_TrimPosition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr, 100687932);
				CharacterControllerUnit.__c.NativeMethodInfoPtr__get_AllSpriteRenderers_b__31_0_Internal_Boolean_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr, 100687933);
				CharacterControllerUnit.__c.NativeMethodInfoPtr__get_CanDetachTrimNum_b__33_0_Internal_Boolean_ValueTuple_4_CharacterControllerUnit_Boolean_TrimPosition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr, 100687934);
				CharacterControllerUnit.__c.NativeMethodInfoPtr__FixedUpdate_b__56_0_Internal_Boolean_CharacterControllerUnitInputProcessorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr, 100687935);
				CharacterControllerUnit.__c.NativeMethodInfoPtr__TrySpawnAccompanyingTrim_b__74_0_Internal_Void_ValueTuple_4_CharacterControllerUnit_Boolean_TrimPosition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr, 100687936);
			}

			// Token: 0x06011410 RID: 70672 RVA: 0x003F96D0 File Offset: 0x003F78D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterControllerUnit.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011411 RID: 70673 RVA: 0x003F970C File Offset: 0x003F790C
			[CallerCount(0)]
			public unsafe CharacterControllerUnit _get_AllSpriteRenderers_b__31_1(ValueTuple<CharacterControllerUnit, bool, CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition, bool> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.__c.NativeMethodInfoPtr__get_AllSpriteRenderers_b__31_1_Internal_CharacterControllerUnit_ValueTuple_4_CharacterControllerUnit_Boolean_TrimPosition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr3) : null;
			}

			// Token: 0x06011412 RID: 70674 RVA: 0x003F9764 File Offset: 0x003F7964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294958, XrefRangeEnd = 294962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_AllSpriteRenderers_b__31_0(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.__c.NativeMethodInfoPtr__get_AllSpriteRenderers_b__31_0_Internal_Boolean_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06011413 RID: 70675 RVA: 0x003F97B4 File Offset: 0x003F79B4
			[CallerCount(0)]
			public unsafe bool _get_CanDetachTrimNum_b__33_0(ValueTuple<CharacterControllerUnit, bool, CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition, bool> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.__c.NativeMethodInfoPtr__get_CanDetachTrimNum_b__33_0_Internal_Boolean_ValueTuple_4_CharacterControllerUnit_Boolean_TrimPosition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06011414 RID: 70676 RVA: 0x003F9808 File Offset: 0x003F7A08
			[CallerCount(0)]
			public unsafe bool _FixedUpdate_b__56_0(CharacterControllerUnitInputProcessorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.__c.NativeMethodInfoPtr__FixedUpdate_b__56_0_Internal_Boolean_CharacterControllerUnitInputProcessorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06011415 RID: 70677 RVA: 0x003F9858 File Offset: 0x003F7A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294962, XrefRangeEnd = 294968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TrySpawnAccompanyingTrim_b__74_0(ValueTuple<CharacterControllerUnit, bool, CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition, bool> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerUnit.__c.NativeMethodInfoPtr__TrySpawnAccompanyingTrim_b__74_0_Internal_Void_ValueTuple_4_CharacterControllerUnit_Boolean_TrimPosition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011416 RID: 70678 RVA: 0x00096015 File Offset: 0x00094215
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170059AF RID: 22959
			// (get) Token: 0x06011417 RID: 70679 RVA: 0x003F98A0 File Offset: 0x003F7AA0
			// (set) Token: 0x06011418 RID: 70680 RVA: 0x0009601E File Offset: 0x0009421E
			public unsafe static CharacterControllerUnit.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterControllerUnit.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterControllerUnit.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059B0 RID: 22960
			// (get) Token: 0x06011419 RID: 70681 RVA: 0x003F98C8 File Offset: 0x003F7AC8
			// (set) Token: 0x0601141A RID: 70682 RVA: 0x00096030 File Offset: 0x00094230
			public unsafe static Func<ValueTuple<CharacterControllerUnit, bool, CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition, bool>, CharacterControllerUnit> __9__31_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterControllerUnit.__c.NativeFieldInfoPtr___9__31_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<CharacterControllerUnit, bool, CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition, bool>, CharacterControllerUnit>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterControllerUnit.__c.NativeFieldInfoPtr___9__31_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059B1 RID: 22961
			// (get) Token: 0x0601141B RID: 70683 RVA: 0x003F98F0 File Offset: 0x003F7AF0
			// (set) Token: 0x0601141C RID: 70684 RVA: 0x00096042 File Offset: 0x00094242
			public unsafe static Func<SpriteRenderer, bool> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterControllerUnit.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpriteRenderer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterControllerUnit.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059B2 RID: 22962
			// (get) Token: 0x0601141D RID: 70685 RVA: 0x003F9918 File Offset: 0x003F7B18
			// (set) Token: 0x0601141E RID: 70686 RVA: 0x00096054 File Offset: 0x00094254
			public unsafe static Func<ValueTuple<CharacterControllerUnit, bool, CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition, bool>, bool> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterControllerUnit.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<CharacterControllerUnit, bool, CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition, bool>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterControllerUnit.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059B3 RID: 22963
			// (get) Token: 0x0601141F RID: 70687 RVA: 0x003F9940 File Offset: 0x003F7B40
			// (set) Token: 0x06011420 RID: 70688 RVA: 0x00096066 File Offset: 0x00094266
			public unsafe static Func<CharacterControllerUnitInputProcessorComponent, bool> __9__56_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterControllerUnit.__c.NativeFieldInfoPtr___9__56_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CharacterControllerUnitInputProcessorComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterControllerUnit.__c.NativeFieldInfoPtr___9__56_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059B4 RID: 22964
			// (get) Token: 0x06011421 RID: 70689 RVA: 0x003F9968 File Offset: 0x003F7B68
			// (set) Token: 0x06011422 RID: 70690 RVA: 0x00096078 File Offset: 0x00094278
			public unsafe static Action<ValueTuple<CharacterControllerUnit, bool, CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition, bool>> __9__74_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CharacterControllerUnit.__c.NativeFieldInfoPtr___9__74_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ValueTuple<CharacterControllerUnit, bool, CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition, bool>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CharacterControllerUnit.__c.NativeFieldInfoPtr___9__74_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AE7E RID: 44670
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AE7F RID: 44671
			private static readonly IntPtr NativeFieldInfoPtr___9__31_1;

			// Token: 0x0400AE80 RID: 44672
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x0400AE81 RID: 44673
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x0400AE82 RID: 44674
			private static readonly IntPtr NativeFieldInfoPtr___9__56_0;

			// Token: 0x0400AE83 RID: 44675
			private static readonly IntPtr NativeFieldInfoPtr___9__74_0;

			// Token: 0x0400AE84 RID: 44676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AE85 RID: 44677
			private static readonly IntPtr NativeMethodInfoPtr__get_AllSpriteRenderers_b__31_1_Internal_CharacterControllerUnit_ValueTuple_4_CharacterControllerUnit_Boolean_TrimPosition_Boolean_0;

			// Token: 0x0400AE86 RID: 44678
			private static readonly IntPtr NativeMethodInfoPtr__get_AllSpriteRenderers_b__31_0_Internal_Boolean_SpriteRenderer_0;

			// Token: 0x0400AE87 RID: 44679
			private static readonly IntPtr NativeMethodInfoPtr__get_CanDetachTrimNum_b__33_0_Internal_Boolean_ValueTuple_4_CharacterControllerUnit_Boolean_TrimPosition_Boolean_0;

			// Token: 0x0400AE88 RID: 44680
			private static readonly IntPtr NativeMethodInfoPtr__FixedUpdate_b__56_0_Internal_Boolean_CharacterControllerUnitInputProcessorComponent_0;

			// Token: 0x0400AE89 RID: 44681
			private static readonly IntPtr NativeMethodInfoPtr__TrySpawnAccompanyingTrim_b__74_0_Internal_Void_ValueTuple_4_CharacterControllerUnit_Boolean_TrimPosition_Boolean_0;
		}

		// Token: 0x02000F95 RID: 3989
		private sealed class MethodInfoStoreGeneric_GetInputProcessor_Public_T_0<T>
		{
			// Token: 0x0400AE8A RID: 44682
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CharacterControllerUnit.NativeMethodInfoPtr_GetInputProcessor_Public_T_0, Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000F96 RID: 3990
		private sealed class MethodInfoStoreGeneric_AddInputProcessor_Public_T_0<T>
		{
			// Token: 0x0400AE8B RID: 44683
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CharacterControllerUnit.NativeMethodInfoPtr_AddInputProcessor_Public_T_0, Il2CppClassPointerStore<CharacterControllerUnit>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
