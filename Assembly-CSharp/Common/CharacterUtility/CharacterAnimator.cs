using System;
using DEYU.Utils;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace Common.CharacterUtility
{
	// Token: 0x02000450 RID: 1104
	public class CharacterAnimator : LayerSortingController
	{
		// Token: 0x060079E3 RID: 31203 RVA: 0x002328FC File Offset: 0x00230AFC
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterAnimator()
		{
			Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.CharacterUtility", "CharacterAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr);
			CharacterAnimator.NativeFieldInfoPtr_BACK_TRIM_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "BACK_TRIM_INDEX");
			CharacterAnimator.NativeFieldInfoPtr_FRONT_TRIM_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "FRONT_TRIM_INDEX");
			CharacterAnimator.NativeFieldInfoPtr_shouldHaveStepSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "shouldHaveStepSFX");
			CharacterAnimator.NativeFieldInfoPtr_animationSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "animationSpeedMultiplier");
			CharacterAnimator.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "animator");
			CharacterAnimator.NativeFieldInfoPtr_backTrimPartent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "backTrimPartent");
			CharacterAnimator.NativeFieldInfoPtr_backTrimSortingGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "backTrimSortingGroup");
			CharacterAnimator.NativeFieldInfoPtr_characterSpriteSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "characterSpriteSet");
			CharacterAnimator.NativeFieldInfoPtr_face = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "face");
			CharacterAnimator.NativeFieldInfoPtr_faceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "faceId");
			CharacterAnimator.NativeFieldInfoPtr_faceRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "faceRenderer");
			CharacterAnimator.NativeFieldInfoPtr_frontTrimParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "frontTrimParent");
			CharacterAnimator.NativeFieldInfoPtr_frontTrimSortingGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "frontTrimSortingGroup");
			CharacterAnimator.NativeFieldInfoPtr_hinaRotateCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "hinaRotateCoroutine");
			CharacterAnimator.NativeFieldInfoPtr_isHina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "isHina");
			CharacterAnimator.NativeFieldInfoPtr_lastFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "lastFace");
			CharacterAnimator.NativeFieldInfoPtr_lastSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "lastSprite");
			CharacterAnimator.NativeFieldInfoPtr_onPFXUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "onPFXUpdate");
			CharacterAnimator.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "orientation");
			CharacterAnimator.NativeFieldInfoPtr_pfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "pfx");
			CharacterAnimator.NativeFieldInfoPtr_pfxEnumrator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "pfxEnumrator");
			CharacterAnimator.NativeFieldInfoPtr_pfxRender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "pfxRender");
			CharacterAnimator.NativeFieldInfoPtr_removableTrimBackLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "removableTrimBackLayer");
			CharacterAnimator.NativeFieldInfoPtr_removableTrimFrontLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "removableTrimFrontLayer");
			CharacterAnimator.NativeFieldInfoPtr_rotatePerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "rotatePerTime");
			CharacterAnimator.NativeFieldInfoPtr_step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "step");
			CharacterAnimator.NativeFieldInfoPtr_stepSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "stepSFX");
			CharacterAnimator.NativeMethodInfoPtr_set_Speed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687764);
			CharacterAnimator.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687765);
			CharacterAnimator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687766);
			CharacterAnimator.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_SpriteRenderer_SpriteRenderer_SpriteRenderer_Il2CppReferenceArray_1_AudioClip_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687767);
			CharacterAnimator.NativeMethodInfoPtr_SetOrientation_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687768);
			CharacterAnimator.NativeMethodInfoPtr_HinaSpecialMove_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687769);
			CharacterAnimator.NativeMethodInfoPtr_GetOrientation_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687770);
			CharacterAnimator.NativeMethodInfoPtr_SetMoving_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687771);
			CharacterAnimator.NativeMethodInfoPtr_SetFace_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687772);
			CharacterAnimator.NativeMethodInfoPtr_SetFaceExtern_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687773);
			CharacterAnimator.NativeMethodInfoPtr_SetTimedPFX_Public_Void_Il2CppReferenceArray_1_Sprite_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687774);
			CharacterAnimator.NativeMethodInfoPtr_SetPFX_Public_Void_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687775);
			CharacterAnimator.NativeMethodInfoPtr_ReleasePFX_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687776);
			CharacterAnimator.NativeMethodInfoPtr_AnimatorUpdatePFX_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687777);
			CharacterAnimator.NativeMethodInfoPtr_OnPFXUpdating_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687778);
			CharacterAnimator.NativeMethodInfoPtr_AnimatorSetStep_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687779);
			CharacterAnimator.NativeMethodInfoPtr_AnimatorSetOrientation_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687780);
			CharacterAnimator.NativeMethodInfoPtr_UpdateVisual_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687781);
			CharacterAnimator.NativeMethodInfoPtr_UpdateVisualExtern_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687782);
			CharacterAnimator.NativeMethodInfoPtr_SetSprite_Protected_Virtual_New_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687783);
			CharacterAnimator.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687784);
			CharacterAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, 100687785);
		}

		// Token: 0x17002967 RID: 10599
		// (set) Token: 0x060079E4 RID: 31204 RVA: 0x00232D00 File Offset: 0x00230F00
		public unsafe float Speed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294327, XrefRangeEnd = 294329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_set_Speed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002968 RID: 10600
		// (set) Token: 0x060079E5 RID: 31205 RVA: 0x00232D40 File Offset: 0x00230F40
		public unsafe string sortingLayerName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294329, XrefRangeEnd = 294331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060079E6 RID: 31206 RVA: 0x00232D84 File Offset: 0x00230F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294331, XrefRangeEnd = 294332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079E7 RID: 31207 RVA: 0x00232DB8 File Offset: 0x00230FB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294365, RefRangeEnd = 294368, XrefRangeStart = 294332, XrefRangeEnd = 294365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(CharacterSpriteSetCompact characterSpriteSet, SpriteRenderer pfxRender, SpriteRenderer faceRenderer, SpriteRenderer aoRenderer, Il2CppReferenceArray<AudioClip> stepSFX, Transform backTrimPartent, Transform frontTrimParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterSpriteSet);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pfxRender);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(faceRenderer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aoRenderer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stepSFX);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(backTrimPartent);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frontTrimParent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_SpriteRenderer_SpriteRenderer_SpriteRenderer_Il2CppReferenceArray_1_AudioClip_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x00232E6C File Offset: 0x0023106C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 294371, RefRangeEnd = 294375, XrefRangeStart = 294368, XrefRangeEnd = 294371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOrientation(int orientation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_SetOrientation_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x00232EAC File Offset: 0x002310AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294375, XrefRangeEnd = 294380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator HinaSpecialMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_HinaSpecialMove_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060079EA RID: 31210 RVA: 0x00232EEC File Offset: 0x002310EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294384, RefRangeEnd = 294386, XrefRangeStart = 294380, XrefRangeEnd = 294384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetOrientation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_GetOrientation_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x00232F28 File Offset: 0x00231128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294395, RefRangeEnd = 294397, XrefRangeStart = 294386, XrefRangeEnd = 294395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMoving(bool isMoving)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isMoving;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_SetMoving_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x00232F68 File Offset: 0x00231168
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 294404, RefRangeEnd = 294414, XrefRangeStart = 294397, XrefRangeEnd = 294404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFace(int face)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref face;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_SetFace_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079ED RID: 31213 RVA: 0x00232FA8 File Offset: 0x002311A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294414, XrefRangeEnd = 294416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceExtern(int face)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref face;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_SetFaceExtern_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x00232FE8 File Offset: 0x002311E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294416, XrefRangeEnd = 294426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimedPFX(Il2CppReferenceArray<Sprite> pfx, float length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pfx);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_SetTimedPFX_Public_Void_Il2CppReferenceArray_1_Sprite_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079EF RID: 31215 RVA: 0x00233038 File Offset: 0x00231238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294426, XrefRangeEnd = 294432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPFX(Il2CppReferenceArray<Sprite> pfx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pfx);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_SetPFX_Public_Void_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x0023307C File Offset: 0x0023127C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294432, XrefRangeEnd = 294436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleasePFX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_ReleasePFX_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079F1 RID: 31217 RVA: 0x002330B0 File Offset: 0x002312B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294436, XrefRangeEnd = 294439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AnimatorUpdatePFX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_AnimatorUpdatePFX_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x002330E4 File Offset: 0x002312E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294439, XrefRangeEnd = 294444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator OnPFXUpdating(float length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_OnPFXUpdating_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x00233130 File Offset: 0x00231330
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294452, RefRangeEnd = 294454, XrefRangeStart = 294444, XrefRangeEnd = 294452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AnimatorSetStep(int step)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterAnimator.NativeMethodInfoPtr_AnimatorSetStep_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079F4 RID: 31220 RVA: 0x0023317C File Offset: 0x0023137C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294464, RefRangeEnd = 294466, XrefRangeStart = 294454, XrefRangeEnd = 294464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AnimatorSetOrientation(int orientation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterAnimator.NativeMethodInfoPtr_AnimatorSetOrientation_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079F5 RID: 31221 RVA: 0x002331C8 File Offset: 0x002313C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294466, XrefRangeEnd = 294467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_UpdateVisual_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079F6 RID: 31222 RVA: 0x002331FC File Offset: 0x002313FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294467, XrefRangeEnd = 294468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisualExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr_UpdateVisualExtern_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079F7 RID: 31223 RVA: 0x00233230 File Offset: 0x00231430
		[CallerCount(0)]
		public unsafe virtual bool SetSprite(int spriteCode, int faceCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spriteCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterAnimator.NativeMethodInfoPtr_SetSprite_Protected_Virtual_New_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060079F8 RID: 31224 RVA: 0x00233294 File Offset: 0x00231494
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294483, RefRangeEnd = 294485, XrefRangeStart = 294468, XrefRangeEnd = 294483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterAnimator.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x002332D0 File Offset: 0x002314D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294485, XrefRangeEnd = 294486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x00041DAF File Offset: 0x0003FFAF
		public CharacterAnimator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700294C RID: 10572
		// (get) Token: 0x060079FB RID: 31227 RVA: 0x0023330C File Offset: 0x0023150C
		// (set) Token: 0x060079FC RID: 31228 RVA: 0x00041DB8 File Offset: 0x0003FFB8
		public unsafe static int BACK_TRIM_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CharacterAnimator.NativeFieldInfoPtr_BACK_TRIM_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterAnimator.NativeFieldInfoPtr_BACK_TRIM_INDEX, (void*)(&value));
			}
		}

		// Token: 0x1700294D RID: 10573
		// (get) Token: 0x060079FD RID: 31229 RVA: 0x00233328 File Offset: 0x00231528
		// (set) Token: 0x060079FE RID: 31230 RVA: 0x00041DC6 File Offset: 0x0003FFC6
		public unsafe static int FRONT_TRIM_INDEX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CharacterAnimator.NativeFieldInfoPtr_FRONT_TRIM_INDEX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterAnimator.NativeFieldInfoPtr_FRONT_TRIM_INDEX, (void*)(&value));
			}
		}

		// Token: 0x1700294E RID: 10574
		// (get) Token: 0x060079FF RID: 31231 RVA: 0x00233344 File Offset: 0x00231544
		// (set) Token: 0x06007A00 RID: 31232 RVA: 0x00041DD4 File Offset: 0x0003FFD4
		public unsafe bool shouldHaveStepSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_shouldHaveStepSFX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_shouldHaveStepSFX)) = value;
			}
		}

		// Token: 0x1700294F RID: 10575
		// (get) Token: 0x06007A01 RID: 31233 RVA: 0x0023336C File Offset: 0x0023156C
		// (set) Token: 0x06007A02 RID: 31234 RVA: 0x00041DEF File Offset: 0x0003FFEF
		public unsafe float animationSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_animationSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_animationSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002950 RID: 10576
		// (get) Token: 0x06007A03 RID: 31235 RVA: 0x00233394 File Offset: 0x00231594
		// (set) Token: 0x06007A04 RID: 31236 RVA: 0x00041E0A File Offset: 0x0004000A
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002951 RID: 10577
		// (get) Token: 0x06007A05 RID: 31237 RVA: 0x002333C4 File Offset: 0x002315C4
		// (set) Token: 0x06007A06 RID: 31238 RVA: 0x00041E29 File Offset: 0x00040029
		public unsafe Transform backTrimPartent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_backTrimPartent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_backTrimPartent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002952 RID: 10578
		// (get) Token: 0x06007A07 RID: 31239 RVA: 0x002333F4 File Offset: 0x002315F4
		// (set) Token: 0x06007A08 RID: 31240 RVA: 0x00041E48 File Offset: 0x00040048
		public unsafe SortingGroup backTrimSortingGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_backTrimSortingGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortingGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_backTrimSortingGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002953 RID: 10579
		// (get) Token: 0x06007A09 RID: 31241 RVA: 0x00233424 File Offset: 0x00231624
		// (set) Token: 0x06007A0A RID: 31242 RVA: 0x00041E67 File Offset: 0x00040067
		public unsafe CharacterSpriteSetCompact characterSpriteSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_characterSpriteSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_characterSpriteSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002954 RID: 10580
		// (get) Token: 0x06007A0B RID: 31243 RVA: 0x00233454 File Offset: 0x00231654
		// (set) Token: 0x06007A0C RID: 31244 RVA: 0x00041E86 File Offset: 0x00040086
		public unsafe int face
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_face);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_face)) = value;
			}
		}

		// Token: 0x17002955 RID: 10581
		// (get) Token: 0x06007A0D RID: 31245 RVA: 0x0023347C File Offset: 0x0023167C
		// (set) Token: 0x06007A0E RID: 31246 RVA: 0x00041EA1 File Offset: 0x000400A1
		public unsafe int faceId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_faceId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_faceId)) = value;
			}
		}

		// Token: 0x17002956 RID: 10582
		// (get) Token: 0x06007A0F RID: 31247 RVA: 0x002334A4 File Offset: 0x002316A4
		// (set) Token: 0x06007A10 RID: 31248 RVA: 0x00041EBC File Offset: 0x000400BC
		public unsafe SpriteRenderer faceRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_faceRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_faceRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002957 RID: 10583
		// (get) Token: 0x06007A11 RID: 31249 RVA: 0x002334D4 File Offset: 0x002316D4
		// (set) Token: 0x06007A12 RID: 31250 RVA: 0x00041EDB File Offset: 0x000400DB
		public unsafe Transform frontTrimParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_frontTrimParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_frontTrimParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002958 RID: 10584
		// (get) Token: 0x06007A13 RID: 31251 RVA: 0x00233504 File Offset: 0x00231704
		// (set) Token: 0x06007A14 RID: 31252 RVA: 0x00041EFA File Offset: 0x000400FA
		public unsafe SortingGroup frontTrimSortingGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_frontTrimSortingGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortingGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_frontTrimSortingGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002959 RID: 10585
		// (get) Token: 0x06007A15 RID: 31253 RVA: 0x00233534 File Offset: 0x00231734
		// (set) Token: 0x06007A16 RID: 31254 RVA: 0x00041F19 File Offset: 0x00040119
		public unsafe Coroutine hinaRotateCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_hinaRotateCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_hinaRotateCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700295A RID: 10586
		// (get) Token: 0x06007A17 RID: 31255 RVA: 0x00233564 File Offset: 0x00231764
		// (set) Token: 0x06007A18 RID: 31256 RVA: 0x00041F38 File Offset: 0x00040138
		public unsafe bool isHina
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_isHina);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_isHina)) = value;
			}
		}

		// Token: 0x1700295B RID: 10587
		// (get) Token: 0x06007A19 RID: 31257 RVA: 0x0023358C File Offset: 0x0023178C
		// (set) Token: 0x06007A1A RID: 31258 RVA: 0x00041F53 File Offset: 0x00040153
		public unsafe int lastFace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_lastFace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_lastFace)) = value;
			}
		}

		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x06007A1B RID: 31259 RVA: 0x002335B4 File Offset: 0x002317B4
		// (set) Token: 0x06007A1C RID: 31260 RVA: 0x00041F6E File Offset: 0x0004016E
		public unsafe int lastSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_lastSprite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_lastSprite)) = value;
			}
		}

		// Token: 0x1700295D RID: 10589
		// (get) Token: 0x06007A1D RID: 31261 RVA: 0x002335DC File Offset: 0x002317DC
		// (set) Token: 0x06007A1E RID: 31262 RVA: 0x00041F89 File Offset: 0x00040189
		public unsafe Coroutine onPFXUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_onPFXUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_onPFXUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x06007A1F RID: 31263 RVA: 0x0023360C File Offset: 0x0023180C
		// (set) Token: 0x06007A20 RID: 31264 RVA: 0x00041FA8 File Offset: 0x000401A8
		public unsafe int orientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_orientation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_orientation)) = value;
			}
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x06007A21 RID: 31265 RVA: 0x00233634 File Offset: 0x00231834
		// (set) Token: 0x06007A22 RID: 31266 RVA: 0x00041FC3 File Offset: 0x000401C3
		public unsafe Il2CppReferenceArray<Sprite> pfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_pfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_pfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x06007A23 RID: 31267 RVA: 0x00233664 File Offset: 0x00231864
		// (set) Token: 0x06007A24 RID: 31268 RVA: 0x00041FE2 File Offset: 0x000401E2
		public unsafe int pfxEnumrator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_pfxEnumrator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_pfxEnumrator)) = value;
			}
		}

		// Token: 0x17002961 RID: 10593
		// (get) Token: 0x06007A25 RID: 31269 RVA: 0x0023368C File Offset: 0x0023188C
		// (set) Token: 0x06007A26 RID: 31270 RVA: 0x00041FFD File Offset: 0x000401FD
		public unsafe SpriteRenderer pfxRender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_pfxRender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_pfxRender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002962 RID: 10594
		// (get) Token: 0x06007A27 RID: 31271 RVA: 0x002336BC File Offset: 0x002318BC
		// (set) Token: 0x06007A28 RID: 31272 RVA: 0x0004201C File Offset: 0x0004021C
		public unsafe int removableTrimBackLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_removableTrimBackLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_removableTrimBackLayer)) = value;
			}
		}

		// Token: 0x17002963 RID: 10595
		// (get) Token: 0x06007A29 RID: 31273 RVA: 0x002336E4 File Offset: 0x002318E4
		// (set) Token: 0x06007A2A RID: 31274 RVA: 0x00042037 File Offset: 0x00040237
		public unsafe int removableTrimFrontLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_removableTrimFrontLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_removableTrimFrontLayer)) = value;
			}
		}

		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x06007A2B RID: 31275 RVA: 0x0023370C File Offset: 0x0023190C
		// (set) Token: 0x06007A2C RID: 31276 RVA: 0x00042052 File Offset: 0x00040252
		public unsafe float rotatePerTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_rotatePerTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_rotatePerTime)) = value;
			}
		}

		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x06007A2D RID: 31277 RVA: 0x00233734 File Offset: 0x00231934
		// (set) Token: 0x06007A2E RID: 31278 RVA: 0x0004206D File Offset: 0x0004026D
		public unsafe int step
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_step);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_step)) = value;
			}
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x06007A2F RID: 31279 RVA: 0x0023375C File Offset: 0x0023195C
		// (set) Token: 0x06007A30 RID: 31280 RVA: 0x00042088 File Offset: 0x00040288
		public unsafe Il2CppReferenceArray<AudioClip> stepSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_stepSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator.NativeFieldInfoPtr_stepSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400502C RID: 20524
		private static readonly IntPtr NativeFieldInfoPtr_BACK_TRIM_INDEX;

		// Token: 0x0400502D RID: 20525
		private static readonly IntPtr NativeFieldInfoPtr_FRONT_TRIM_INDEX;

		// Token: 0x0400502E RID: 20526
		private static readonly IntPtr NativeFieldInfoPtr_shouldHaveStepSFX;

		// Token: 0x0400502F RID: 20527
		private static readonly IntPtr NativeFieldInfoPtr_animationSpeedMultiplier;

		// Token: 0x04005030 RID: 20528
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04005031 RID: 20529
		private static readonly IntPtr NativeFieldInfoPtr_backTrimPartent;

		// Token: 0x04005032 RID: 20530
		private static readonly IntPtr NativeFieldInfoPtr_backTrimSortingGroup;

		// Token: 0x04005033 RID: 20531
		private static readonly IntPtr NativeFieldInfoPtr_characterSpriteSet;

		// Token: 0x04005034 RID: 20532
		private static readonly IntPtr NativeFieldInfoPtr_face;

		// Token: 0x04005035 RID: 20533
		private static readonly IntPtr NativeFieldInfoPtr_faceId;

		// Token: 0x04005036 RID: 20534
		private static readonly IntPtr NativeFieldInfoPtr_faceRenderer;

		// Token: 0x04005037 RID: 20535
		private static readonly IntPtr NativeFieldInfoPtr_frontTrimParent;

		// Token: 0x04005038 RID: 20536
		private static readonly IntPtr NativeFieldInfoPtr_frontTrimSortingGroup;

		// Token: 0x04005039 RID: 20537
		private static readonly IntPtr NativeFieldInfoPtr_hinaRotateCoroutine;

		// Token: 0x0400503A RID: 20538
		private static readonly IntPtr NativeFieldInfoPtr_isHina;

		// Token: 0x0400503B RID: 20539
		private static readonly IntPtr NativeFieldInfoPtr_lastFace;

		// Token: 0x0400503C RID: 20540
		private static readonly IntPtr NativeFieldInfoPtr_lastSprite;

		// Token: 0x0400503D RID: 20541
		private static readonly IntPtr NativeFieldInfoPtr_onPFXUpdate;

		// Token: 0x0400503E RID: 20542
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x0400503F RID: 20543
		private static readonly IntPtr NativeFieldInfoPtr_pfx;

		// Token: 0x04005040 RID: 20544
		private static readonly IntPtr NativeFieldInfoPtr_pfxEnumrator;

		// Token: 0x04005041 RID: 20545
		private static readonly IntPtr NativeFieldInfoPtr_pfxRender;

		// Token: 0x04005042 RID: 20546
		private static readonly IntPtr NativeFieldInfoPtr_removableTrimBackLayer;

		// Token: 0x04005043 RID: 20547
		private static readonly IntPtr NativeFieldInfoPtr_removableTrimFrontLayer;

		// Token: 0x04005044 RID: 20548
		private static readonly IntPtr NativeFieldInfoPtr_rotatePerTime;

		// Token: 0x04005045 RID: 20549
		private static readonly IntPtr NativeFieldInfoPtr_step;

		// Token: 0x04005046 RID: 20550
		private static readonly IntPtr NativeFieldInfoPtr_stepSFX;

		// Token: 0x04005047 RID: 20551
		private static readonly IntPtr NativeMethodInfoPtr_set_Speed_Public_set_Void_Single_0;

		// Token: 0x04005048 RID: 20552
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0;

		// Token: 0x04005049 RID: 20553
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400504A RID: 20554
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_SpriteRenderer_SpriteRenderer_SpriteRenderer_Il2CppReferenceArray_1_AudioClip_Transform_Transform_0;

		// Token: 0x0400504B RID: 20555
		private static readonly IntPtr NativeMethodInfoPtr_SetOrientation_Public_Void_Int32_0;

		// Token: 0x0400504C RID: 20556
		private static readonly IntPtr NativeMethodInfoPtr_HinaSpecialMove_Private_IEnumerator_0;

		// Token: 0x0400504D RID: 20557
		private static readonly IntPtr NativeMethodInfoPtr_GetOrientation_Public_Int32_0;

		// Token: 0x0400504E RID: 20558
		private static readonly IntPtr NativeMethodInfoPtr_SetMoving_Public_Void_Boolean_0;

		// Token: 0x0400504F RID: 20559
		private static readonly IntPtr NativeMethodInfoPtr_SetFace_Private_Void_Int32_0;

		// Token: 0x04005050 RID: 20560
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceExtern_Public_Void_Int32_0;

		// Token: 0x04005051 RID: 20561
		private static readonly IntPtr NativeMethodInfoPtr_SetTimedPFX_Public_Void_Il2CppReferenceArray_1_Sprite_Single_0;

		// Token: 0x04005052 RID: 20562
		private static readonly IntPtr NativeMethodInfoPtr_SetPFX_Public_Void_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04005053 RID: 20563
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePFX_Public_Void_0;

		// Token: 0x04005054 RID: 20564
		private static readonly IntPtr NativeMethodInfoPtr_AnimatorUpdatePFX_Public_Void_0;

		// Token: 0x04005055 RID: 20565
		private static readonly IntPtr NativeMethodInfoPtr_OnPFXUpdating_Private_IEnumerator_Single_0;

		// Token: 0x04005056 RID: 20566
		private static readonly IntPtr NativeMethodInfoPtr_AnimatorSetStep_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04005057 RID: 20567
		private static readonly IntPtr NativeMethodInfoPtr_AnimatorSetOrientation_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04005058 RID: 20568
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Private_Void_0;

		// Token: 0x04005059 RID: 20569
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisualExtern_Public_Void_0;

		// Token: 0x0400505A RID: 20570
		private static readonly IntPtr NativeMethodInfoPtr_SetSprite_Protected_Virtual_New_Boolean_Int32_Int32_0;

		// Token: 0x0400505B RID: 20571
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400505C RID: 20572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F8D RID: 3981
		public enum AnimatorType
		{
			// Token: 0x0400AE3B RID: 44603
			Layered,
			// Token: 0x0400AE3C RID: 44604
			Compact
		}

		// Token: 0x02000F8E RID: 3982
		[ObfuscatedName("Common.CharacterUtility.CharacterAnimator+<HinaSpecialMove>d__35")]
		public sealed class _HinaSpecialMove_d__35 : Il2CppSystem.Object
		{
			// Token: 0x060113A2 RID: 70562 RVA: 0x003F822C File Offset: 0x003F642C
			// Note: this type is marked as 'beforefieldinit'.
			static _HinaSpecialMove_d__35()
			{
				Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "<HinaSpecialMove>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr);
				CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr, "<>1__state");
				CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr, "<>2__current");
				CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr, "<>4__this");
				CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr__rotate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr, "<rotate>5__2");
				CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr__wait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr, "<wait>5__3");
				CharacterAnimator._HinaSpecialMove_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr, 100687786);
				CharacterAnimator._HinaSpecialMove_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr, 100687787);
				CharacterAnimator._HinaSpecialMove_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr, 100687788);
				CharacterAnimator._HinaSpecialMove_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr, 100687789);
				CharacterAnimator._HinaSpecialMove_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr, 100687790);
				CharacterAnimator._HinaSpecialMove_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr, 100687791);
			}

			// Token: 0x060113A3 RID: 70563 RVA: 0x003F8334 File Offset: 0x003F6534
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HinaSpecialMove_d__35(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAnimator._HinaSpecialMove_d__35>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator._HinaSpecialMove_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060113A4 RID: 70564 RVA: 0x003F837C File Offset: 0x003F657C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator._HinaSpecialMove_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060113A5 RID: 70565 RVA: 0x003F83B0 File Offset: 0x003F65B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294292, XrefRangeEnd = 294306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator._HinaSpecialMove_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700598A RID: 22922
			// (get) Token: 0x060113A6 RID: 70566 RVA: 0x003F83EC File Offset: 0x003F65EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator._HinaSpecialMove_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060113A7 RID: 70567 RVA: 0x003F842C File Offset: 0x003F662C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294306, XrefRangeEnd = 294312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator._HinaSpecialMove_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700598B RID: 22923
			// (get) Token: 0x060113A8 RID: 70568 RVA: 0x003F8460 File Offset: 0x003F6660
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator._HinaSpecialMove_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060113A9 RID: 70569 RVA: 0x00095C20 File Offset: 0x00093E20
			public _HinaSpecialMove_d__35(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005985 RID: 22917
			// (get) Token: 0x060113AA RID: 70570 RVA: 0x003F84A0 File Offset: 0x003F66A0
			// (set) Token: 0x060113AB RID: 70571 RVA: 0x00095C29 File Offset: 0x00093E29
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005986 RID: 22918
			// (get) Token: 0x060113AC RID: 70572 RVA: 0x003F84C8 File Offset: 0x003F66C8
			// (set) Token: 0x060113AD RID: 70573 RVA: 0x00095C44 File Offset: 0x00093E44
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005987 RID: 22919
			// (get) Token: 0x060113AE RID: 70574 RVA: 0x003F84F8 File Offset: 0x003F66F8
			// (set) Token: 0x060113AF RID: 70575 RVA: 0x00095C63 File Offset: 0x00093E63
			public unsafe CharacterAnimator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005988 RID: 22920
			// (get) Token: 0x060113B0 RID: 70576 RVA: 0x003F8528 File Offset: 0x003F6728
			// (set) Token: 0x060113B1 RID: 70577 RVA: 0x00095C82 File Offset: 0x00093E82
			public unsafe int _rotate_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr__rotate_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr__rotate_5__2)) = value;
				}
			}

			// Token: 0x17005989 RID: 22921
			// (get) Token: 0x060113B2 RID: 70578 RVA: 0x003F8550 File Offset: 0x003F6750
			// (set) Token: 0x060113B3 RID: 70579 RVA: 0x00095C9D File Offset: 0x00093E9D
			public unsafe WaitForSeconds _wait_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr__wait_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._HinaSpecialMove_d__35.NativeFieldInfoPtr__wait_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AE3D RID: 44605
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AE3E RID: 44606
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400AE3F RID: 44607
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AE40 RID: 44608
			private static readonly IntPtr NativeFieldInfoPtr__rotate_5__2;

			// Token: 0x0400AE41 RID: 44609
			private static readonly IntPtr NativeFieldInfoPtr__wait_5__3;

			// Token: 0x0400AE42 RID: 44610
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400AE43 RID: 44611
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE44 RID: 44612
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400AE45 RID: 44613
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400AE46 RID: 44614
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE47 RID: 44615
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000F8F RID: 3983
		[ObfuscatedName("Common.CharacterUtility.CharacterAnimator+<OnPFXUpdating>d__44")]
		public sealed class _OnPFXUpdating_d__44 : Il2CppSystem.Object
		{
			// Token: 0x060113B4 RID: 70580 RVA: 0x003F8580 File Offset: 0x003F6780
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPFXUpdating_d__44()
			{
				Il2CppClassPointerStore<CharacterAnimator._OnPFXUpdating_d__44>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAnimator>.NativeClassPtr, "<OnPFXUpdating>d__44");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAnimator._OnPFXUpdating_d__44>.NativeClassPtr);
				CharacterAnimator._OnPFXUpdating_d__44.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator._OnPFXUpdating_d__44>.NativeClassPtr, "<>1__state");
				CharacterAnimator._OnPFXUpdating_d__44.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator._OnPFXUpdating_d__44>.NativeClassPtr, "<>2__current");
				CharacterAnimator._OnPFXUpdating_d__44.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator._OnPFXUpdating_d__44>.NativeClassPtr, "<>4__this");
				CharacterAnimator._OnPFXUpdating_d__44.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimator._OnPFXUpdating_d__44>.NativeClassPtr, "length");
				CharacterAnimator._OnPFXUpdating_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator._OnPFXUpdating_d__44>.NativeClassPtr, 100687792);
				CharacterAnimator._OnPFXUpdating_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator._OnPFXUpdating_d__44>.NativeClassPtr, 100687793);
				CharacterAnimator._OnPFXUpdating_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator._OnPFXUpdating_d__44>.NativeClassPtr, 100687794);
				CharacterAnimator._OnPFXUpdating_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator._OnPFXUpdating_d__44>.NativeClassPtr, 100687795);
				CharacterAnimator._OnPFXUpdating_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator._OnPFXUpdating_d__44>.NativeClassPtr, 100687796);
				CharacterAnimator._OnPFXUpdating_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimator._OnPFXUpdating_d__44>.NativeClassPtr, 100687797);
			}

			// Token: 0x060113B5 RID: 70581 RVA: 0x003F8674 File Offset: 0x003F6874
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPFXUpdating_d__44(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAnimator._OnPFXUpdating_d__44>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator._OnPFXUpdating_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060113B6 RID: 70582 RVA: 0x003F86BC File Offset: 0x003F68BC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator._OnPFXUpdating_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060113B7 RID: 70583 RVA: 0x003F86F0 File Offset: 0x003F68F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294312, XrefRangeEnd = 294321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator._OnPFXUpdating_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005990 RID: 22928
			// (get) Token: 0x060113B8 RID: 70584 RVA: 0x003F872C File Offset: 0x003F692C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator._OnPFXUpdating_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060113B9 RID: 70585 RVA: 0x003F876C File Offset: 0x003F696C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294321, XrefRangeEnd = 294327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator._OnPFXUpdating_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005991 RID: 22929
			// (get) Token: 0x060113BA RID: 70586 RVA: 0x003F87A0 File Offset: 0x003F69A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimator._OnPFXUpdating_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060113BB RID: 70587 RVA: 0x00095CBC File Offset: 0x00093EBC
			public _OnPFXUpdating_d__44(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700598C RID: 22924
			// (get) Token: 0x060113BC RID: 70588 RVA: 0x003F87E0 File Offset: 0x003F69E0
			// (set) Token: 0x060113BD RID: 70589 RVA: 0x00095CC5 File Offset: 0x00093EC5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._OnPFXUpdating_d__44.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._OnPFXUpdating_d__44.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700598D RID: 22925
			// (get) Token: 0x060113BE RID: 70590 RVA: 0x003F8808 File Offset: 0x003F6A08
			// (set) Token: 0x060113BF RID: 70591 RVA: 0x00095CE0 File Offset: 0x00093EE0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._OnPFXUpdating_d__44.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._OnPFXUpdating_d__44.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700598E RID: 22926
			// (get) Token: 0x060113C0 RID: 70592 RVA: 0x003F8838 File Offset: 0x003F6A38
			// (set) Token: 0x060113C1 RID: 70593 RVA: 0x00095CFF File Offset: 0x00093EFF
			public unsafe CharacterAnimator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._OnPFXUpdating_d__44.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._OnPFXUpdating_d__44.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700598F RID: 22927
			// (get) Token: 0x060113C2 RID: 70594 RVA: 0x003F8868 File Offset: 0x003F6A68
			// (set) Token: 0x060113C3 RID: 70595 RVA: 0x00095D1E File Offset: 0x00093F1E
			public unsafe float length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._OnPFXUpdating_d__44.NativeFieldInfoPtr_length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimator._OnPFXUpdating_d__44.NativeFieldInfoPtr_length)) = value;
				}
			}

			// Token: 0x0400AE48 RID: 44616
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AE49 RID: 44617
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400AE4A RID: 44618
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AE4B RID: 44619
			private static readonly IntPtr NativeFieldInfoPtr_length;

			// Token: 0x0400AE4C RID: 44620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400AE4D RID: 44621
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE4E RID: 44622
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400AE4F RID: 44623
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400AE50 RID: 44624
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE51 RID: 44625
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
