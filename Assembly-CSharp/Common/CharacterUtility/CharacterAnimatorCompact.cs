using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x02000451 RID: 1105
	public class CharacterAnimatorCompact : CharacterAnimator
	{
		// Token: 0x06007A31 RID: 31281 RVA: 0x0023378C File Offset: 0x0023198C
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterAnimatorCompact()
		{
			Il2CppClassPointerStore<CharacterAnimatorCompact>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.CharacterUtility", "CharacterAnimatorCompact");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAnimatorCompact>.NativeClassPtr);
			CharacterAnimatorCompact.NativeFieldInfoPtr_mainRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimatorCompact>.NativeClassPtr, "mainRenderer");
			CharacterAnimatorCompact.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_Il2CppReferenceArray_1_AudioClip_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimatorCompact>.NativeClassPtr, 100687798);
			CharacterAnimatorCompact.NativeMethodInfoPtr_AnimatorSetStep_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimatorCompact>.NativeClassPtr, 100687799);
			CharacterAnimatorCompact.NativeMethodInfoPtr_AnimatorSetOrientation_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimatorCompact>.NativeClassPtr, 100687800);
			CharacterAnimatorCompact.NativeMethodInfoPtr_SetSprite_Protected_Virtual_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimatorCompact>.NativeClassPtr, 100687801);
			CharacterAnimatorCompact.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimatorCompact>.NativeClassPtr, 100687802);
			CharacterAnimatorCompact.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimatorCompact>.NativeClassPtr, 100687803);
		}

		// Token: 0x06007A32 RID: 31282 RVA: 0x00233848 File Offset: 0x00231A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294486, XrefRangeEnd = 294488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(CharacterSpriteSetCompact characterSprites, SpriteRenderer pfxRenderer, SpriteRenderer mainRenderer, SpriteRenderer faceRenderer, SpriteRenderer aoRenderer, Il2CppReferenceArray<AudioClip> stepSFX, Transform backTrimPartent, Transform frontTrimParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterSprites);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pfxRenderer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mainRenderer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(faceRenderer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aoRenderer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stepSFX);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(backTrimPartent);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frontTrimParent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimatorCompact.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_Il2CppReferenceArray_1_AudioClip_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x00233910 File Offset: 0x00231B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294488, XrefRangeEnd = 294493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AnimatorSetStep(int step)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterAnimatorCompact.NativeMethodInfoPtr_AnimatorSetStep_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x0023395C File Offset: 0x00231B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294493, XrefRangeEnd = 294498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AnimatorSetOrientation(int orientation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterAnimatorCompact.NativeMethodInfoPtr_AnimatorSetOrientation_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x002339A8 File Offset: 0x00231BA8
		[CallerCount(0)]
		public unsafe override bool SetSprite(int spriteCode, int faceCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spriteCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterAnimatorCompact.NativeMethodInfoPtr_SetSprite_Protected_Virtual_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x00233A0C File Offset: 0x00231C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294498, XrefRangeEnd = 294500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterAnimatorCompact.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x00233A48 File Offset: 0x00231C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterAnimatorCompact() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAnimatorCompact>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimatorCompact.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x000420A7 File Offset: 0x000402A7
		public CharacterAnimatorCompact(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x06007A39 RID: 31289 RVA: 0x00233A84 File Offset: 0x00231C84
		// (set) Token: 0x06007A3A RID: 31290 RVA: 0x000420B0 File Offset: 0x000402B0
		public unsafe SpriteRenderer mainRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimatorCompact.NativeFieldInfoPtr_mainRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimatorCompact.NativeFieldInfoPtr_mainRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400505D RID: 20573
		private static readonly IntPtr NativeFieldInfoPtr_mainRenderer;

		// Token: 0x0400505E RID: 20574
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_Il2CppReferenceArray_1_AudioClip_Transform_Transform_0;

		// Token: 0x0400505F RID: 20575
		private static readonly IntPtr NativeMethodInfoPtr_AnimatorSetStep_Public_Virtual_Void_Int32_0;

		// Token: 0x04005060 RID: 20576
		private static readonly IntPtr NativeMethodInfoPtr_AnimatorSetOrientation_Protected_Virtual_Void_Int32_0;

		// Token: 0x04005061 RID: 20577
		private static readonly IntPtr NativeMethodInfoPtr_SetSprite_Protected_Virtual_Boolean_Int32_Int32_0;

		// Token: 0x04005062 RID: 20578
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04005063 RID: 20579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
