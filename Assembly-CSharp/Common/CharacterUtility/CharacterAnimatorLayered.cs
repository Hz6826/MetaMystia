using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x02000452 RID: 1106
	public class CharacterAnimatorLayered : CharacterAnimator
	{
		// Token: 0x06007A3B RID: 31291 RVA: 0x00233AB4 File Offset: 0x00231CB4
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterAnimatorLayered()
		{
			Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.CharacterUtility", "CharacterAnimatorLayered");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr);
			CharacterAnimatorLayered.NativeFieldInfoPtr_baseRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr, "baseRenderer");
			CharacterAnimatorLayered.NativeFieldInfoPtr_hairRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr, "hairRenderer");
			CharacterAnimatorLayered.NativeFieldInfoPtr_dressRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr, "dressRenderer");
			CharacterAnimatorLayered.NativeFieldInfoPtr_backRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr, "backRenderer");
			CharacterAnimatorLayered.NativeMethodInfoPtr_get_characterSpriteSet_Private_get_CharacterSpriteSetFull_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr, 100687804);
			CharacterAnimatorLayered.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetFull_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_Il2CppReferenceArray_1_AudioClip_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr, 100687805);
			CharacterAnimatorLayered.NativeMethodInfoPtr_AnimatorSetStep_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr, 100687806);
			CharacterAnimatorLayered.NativeMethodInfoPtr_AnimatorSetOrientation_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr, 100687807);
			CharacterAnimatorLayered.NativeMethodInfoPtr_SetSprite_Protected_Virtual_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr, 100687808);
			CharacterAnimatorLayered.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr, 100687809);
			CharacterAnimatorLayered.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr, 100687810);
		}

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x06007A3C RID: 31292 RVA: 0x00233BC0 File Offset: 0x00231DC0
		public new unsafe CharacterSpriteSetFull characterSpriteSet
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294500, XrefRangeEnd = 294502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimatorLayered.NativeMethodInfoPtr_get_characterSpriteSet_Private_get_CharacterSpriteSetFull_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetFull>(intPtr3) : null;
			}
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x00233C00 File Offset: 0x00231E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294502, XrefRangeEnd = 294507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(CharacterSpriteSetFull characterSpriteSet, SpriteRenderer pfxRenderer, SpriteRenderer baseRenderer, SpriteRenderer faceRenderer, SpriteRenderer hairRenderer, SpriteRenderer dressRenderer, SpriteRenderer backRenderer, SpriteRenderer aoRenderer, Il2CppReferenceArray<AudioClip> stepSFX, Transform backTrimPartent, Transform frontTrimParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterSpriteSet);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pfxRenderer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseRenderer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(faceRenderer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hairRenderer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dressRenderer);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(backRenderer);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aoRenderer);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stepSFX);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(backTrimPartent);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frontTrimParent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimatorLayered.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetFull_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_Il2CppReferenceArray_1_AudioClip_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x00233D04 File Offset: 0x00231F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294507, XrefRangeEnd = 294514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AnimatorSetStep(int step)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterAnimatorLayered.NativeMethodInfoPtr_AnimatorSetStep_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A3F RID: 31295 RVA: 0x00233D50 File Offset: 0x00231F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294514, XrefRangeEnd = 294524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AnimatorSetOrientation(int orientation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orientation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterAnimatorLayered.NativeMethodInfoPtr_AnimatorSetOrientation_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A40 RID: 31296 RVA: 0x00233D9C File Offset: 0x00231F9C
		[CallerCount(0)]
		public unsafe override bool SetSprite(int spriteCode, int faceCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spriteCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterAnimatorLayered.NativeMethodInfoPtr_SetSprite_Protected_Virtual_Boolean_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x00233E00 File Offset: 0x00232000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294524, XrefRangeEnd = 294529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterAnimatorLayered.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x00233E3C File Offset: 0x0023203C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterAnimatorLayered() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAnimatorLayered>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterAnimatorLayered.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A43 RID: 31299 RVA: 0x000420CF File Offset: 0x000402CF
		public CharacterAnimatorLayered(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700296A RID: 10602
		// (get) Token: 0x06007A44 RID: 31300 RVA: 0x00233E78 File Offset: 0x00232078
		// (set) Token: 0x06007A45 RID: 31301 RVA: 0x000420D8 File Offset: 0x000402D8
		public unsafe SpriteRenderer baseRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimatorLayered.NativeFieldInfoPtr_baseRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimatorLayered.NativeFieldInfoPtr_baseRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700296B RID: 10603
		// (get) Token: 0x06007A46 RID: 31302 RVA: 0x00233EA8 File Offset: 0x002320A8
		// (set) Token: 0x06007A47 RID: 31303 RVA: 0x000420F7 File Offset: 0x000402F7
		public unsafe SpriteRenderer hairRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimatorLayered.NativeFieldInfoPtr_hairRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimatorLayered.NativeFieldInfoPtr_hairRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700296C RID: 10604
		// (get) Token: 0x06007A48 RID: 31304 RVA: 0x00233ED8 File Offset: 0x002320D8
		// (set) Token: 0x06007A49 RID: 31305 RVA: 0x00042116 File Offset: 0x00040316
		public unsafe SpriteRenderer dressRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimatorLayered.NativeFieldInfoPtr_dressRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimatorLayered.NativeFieldInfoPtr_dressRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x06007A4A RID: 31306 RVA: 0x00233F08 File Offset: 0x00232108
		// (set) Token: 0x06007A4B RID: 31307 RVA: 0x00042135 File Offset: 0x00040335
		public unsafe SpriteRenderer backRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimatorLayered.NativeFieldInfoPtr_backRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterAnimatorLayered.NativeFieldInfoPtr_backRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005064 RID: 20580
		private static readonly IntPtr NativeFieldInfoPtr_baseRenderer;

		// Token: 0x04005065 RID: 20581
		private static readonly IntPtr NativeFieldInfoPtr_hairRenderer;

		// Token: 0x04005066 RID: 20582
		private static readonly IntPtr NativeFieldInfoPtr_dressRenderer;

		// Token: 0x04005067 RID: 20583
		private static readonly IntPtr NativeFieldInfoPtr_backRenderer;

		// Token: 0x04005068 RID: 20584
		private static readonly IntPtr NativeMethodInfoPtr_get_characterSpriteSet_Private_get_CharacterSpriteSetFull_0;

		// Token: 0x04005069 RID: 20585
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetFull_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_Il2CppReferenceArray_1_AudioClip_Transform_Transform_0;

		// Token: 0x0400506A RID: 20586
		private static readonly IntPtr NativeMethodInfoPtr_AnimatorSetStep_Public_Virtual_Void_Int32_0;

		// Token: 0x0400506B RID: 20587
		private static readonly IntPtr NativeMethodInfoPtr_AnimatorSetOrientation_Protected_Virtual_Void_Int32_0;

		// Token: 0x0400506C RID: 20588
		private static readonly IntPtr NativeMethodInfoPtr_SetSprite_Protected_Virtual_Boolean_Int32_Int32_0;

		// Token: 0x0400506D RID: 20589
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400506E RID: 20590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
