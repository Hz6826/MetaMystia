using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GameData.Core.Collections.CharacterUtility
{
	// Token: 0x020002BF RID: 703
	public class CharacterSpriteSetFull : CharacterSpriteSetCompact
	{
		// Token: 0x06005757 RID: 22359 RVA: 0x001C4E40 File Offset: 0x001C3040
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterSpriteSetFull()
		{
			Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.CharacterUtility", "CharacterSpriteSetFull");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr);
			CharacterSpriteSetFull.NativeFieldInfoPtr_hairSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr, "hairSprite");
			CharacterSpriteSetFull.NativeFieldInfoPtr_backSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr, "backSprite");
			CharacterSpriteSetFull.NativeFieldInfoPtr__CharacterBaseSprite_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr, "<CharacterBaseSprite>k__BackingField");
			CharacterSpriteSetFull.NativeMethodInfoPtr_get_HairSprite_Public_Virtual_get_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr, 100681052);
			CharacterSpriteSetFull.NativeMethodInfoPtr_get_BackSprite_Public_Virtual_get_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr, 100681053);
			CharacterSpriteSetFull.NativeMethodInfoPtr_get_CharacterBaseSprite_Private_Static_get_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr, 100681054);
			CharacterSpriteSetFull.NativeMethodInfoPtr_set_CharacterBaseSprite_Private_Static_set_Void_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr, 100681055);
			CharacterSpriteSetFull.NativeMethodInfoPtr_get_BaseSprite_Public_Static_get_IReadOnlyList_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr, 100681056);
			CharacterSpriteSetFull.NativeMethodInfoPtr_SetBase_Public_Static_Void_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr, 100681057);
			CharacterSpriteSetFull.NativeMethodInfoPtr_Initialize_Public_Void_Il2CppReferenceArray_1_Sprite_Boolean_Il2CppReferenceArray_1_Sprite_Il2CppReferenceArray_1_Sprite_Il2CppReferenceArray_1_Sprite_Boolean_Single_Single_Boolean_Single_Boolean_Single_Il2CppReferenceArray_1_RemovableTrimProperty_Il2CppReferenceArray_1_Sprite_Il2CppReferenceArray_1_Sprite_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr, 100681058);
			CharacterSpriteSetFull.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr, 100681059);
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x06005758 RID: 22360 RVA: 0x001C4F4C File Offset: 0x001C314C
		public unsafe override Il2CppReferenceArray<Sprite> HairSprite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterSpriteSetFull.NativeMethodInfoPtr_get_HairSprite_Public_Virtual_get_Il2CppReferenceArray_1_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x06005759 RID: 22361 RVA: 0x001C4F98 File Offset: 0x001C3198
		public unsafe override Il2CppReferenceArray<Sprite> BackSprite
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterSpriteSetFull.NativeMethodInfoPtr_get_BackSprite_Public_Virtual_get_Il2CppReferenceArray_1_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x0600575A RID: 22362 RVA: 0x001C4FE4 File Offset: 0x001C31E4
		// (set) Token: 0x0600575B RID: 22363 RVA: 0x001C5018 File Offset: 0x001C3218
		public unsafe static Il2CppReferenceArray<Sprite> CharacterBaseSprite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216182, XrefRangeEnd = 216184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetFull.NativeMethodInfoPtr_get_CharacterBaseSprite_Private_Static_get_Il2CppReferenceArray_1_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216184, XrefRangeEnd = 216188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetFull.NativeMethodInfoPtr_set_CharacterBaseSprite_Private_Static_set_Void_Il2CppReferenceArray_1_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x0600575C RID: 22364 RVA: 0x001C5050 File Offset: 0x001C3250
		public unsafe static IReadOnlyList<Sprite> BaseSprite
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 216190, RefRangeEnd = 216199, XrefRangeStart = 216188, XrefRangeEnd = 216190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetFull.NativeMethodInfoPtr_get_BaseSprite_Public_Static_get_IReadOnlyList_1_Sprite_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x0600575D RID: 22365 RVA: 0x001C5084 File Offset: 0x001C3284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216203, RefRangeEnd = 216204, XrefRangeStart = 216199, XrefRangeEnd = 216203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBase(Il2CppReferenceArray<Sprite> baseSprite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseSprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetFull.NativeMethodInfoPtr_SetBase_Public_Static_Void_Il2CppReferenceArray_1_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x001C50BC File Offset: 0x001C32BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216204, XrefRangeEnd = 216213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Il2CppReferenceArray<Sprite> mainSprite, bool doNotUseEyeSprite, Il2CppReferenceArray<Sprite> eyeSprite, Il2CppReferenceArray<Sprite> hairSprite, Il2CppReferenceArray<Sprite> backSprite, bool hasPrebakedShadow, float animSpeedMultiplier, float extraYOffset, bool isHina, float rotatePerTime, bool shouldHaveStepVFX, float moveSpeedMultiplier, Il2CppReferenceArray<CharacterSpriteSetCompact.RemovableTrimProperty> removableTrimCompact, Il2CppReferenceArray<Sprite> trimSpritesDisplayFront, Il2CppReferenceArray<Sprite> trimSpritesDisplayBack, float trimSpriteFrameSpeed, float trimBackSpriteFrameSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mainSprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doNotUseEyeSprite;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eyeSprite);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hairSprite);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(backSprite);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasPrebakedShadow;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animSpeedMultiplier;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraYOffset;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHina;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotatePerTime;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldHaveStepVFX;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeedMultiplier;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(removableTrimCompact);
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trimSpritesDisplayFront);
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trimSpritesDisplayBack);
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trimSpriteFrameSpeed;
			ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trimBackSpriteFrameSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetFull.NativeMethodInfoPtr_Initialize_Public_Void_Il2CppReferenceArray_1_Sprite_Boolean_Il2CppReferenceArray_1_Sprite_Il2CppReferenceArray_1_Sprite_Il2CppReferenceArray_1_Sprite_Boolean_Single_Single_Boolean_Single_Boolean_Single_Il2CppReferenceArray_1_RemovableTrimProperty_Il2CppReferenceArray_1_Sprite_Il2CppReferenceArray_1_Sprite_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600575F RID: 22367 RVA: 0x001C5204 File Offset: 0x001C3404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterSpriteSetFull() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSpriteSetFull>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetFull.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005760 RID: 22368 RVA: 0x0002F00A File Offset: 0x0002D20A
		public CharacterSpriteSetFull(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x06005761 RID: 22369 RVA: 0x001C5240 File Offset: 0x001C3440
		// (set) Token: 0x06005762 RID: 22370 RVA: 0x0002F013 File Offset: 0x0002D213
		public unsafe Il2CppReferenceArray<Sprite> hairSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetFull.NativeFieldInfoPtr_hairSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetFull.NativeFieldInfoPtr_hairSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x06005763 RID: 22371 RVA: 0x001C5270 File Offset: 0x001C3470
		// (set) Token: 0x06005764 RID: 22372 RVA: 0x0002F032 File Offset: 0x0002D232
		public unsafe Il2CppReferenceArray<Sprite> backSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetFull.NativeFieldInfoPtr_backSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSpriteSetFull.NativeFieldInfoPtr_backSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x06005765 RID: 22373 RVA: 0x001C52A0 File Offset: 0x001C34A0
		// (set) Token: 0x06005766 RID: 22374 RVA: 0x0002F051 File Offset: 0x0002D251
		public unsafe static Il2CppReferenceArray<Sprite> _CharacterBaseSprite_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharacterSpriteSetFull.NativeFieldInfoPtr__CharacterBaseSprite_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterSpriteSetFull.NativeFieldInfoPtr__CharacterBaseSprite_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A7A RID: 14970
		private static readonly IntPtr NativeFieldInfoPtr_hairSprite;

		// Token: 0x04003A7B RID: 14971
		private static readonly IntPtr NativeFieldInfoPtr_backSprite;

		// Token: 0x04003A7C RID: 14972
		private static readonly IntPtr NativeFieldInfoPtr__CharacterBaseSprite_k__BackingField;

		// Token: 0x04003A7D RID: 14973
		private static readonly IntPtr NativeMethodInfoPtr_get_HairSprite_Public_Virtual_get_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04003A7E RID: 14974
		private static readonly IntPtr NativeMethodInfoPtr_get_BackSprite_Public_Virtual_get_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04003A7F RID: 14975
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterBaseSprite_Private_Static_get_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04003A80 RID: 14976
		private static readonly IntPtr NativeMethodInfoPtr_set_CharacterBaseSprite_Private_Static_set_Void_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04003A81 RID: 14977
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseSprite_Public_Static_get_IReadOnlyList_1_Sprite_0;

		// Token: 0x04003A82 RID: 14978
		private static readonly IntPtr NativeMethodInfoPtr_SetBase_Public_Static_Void_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x04003A83 RID: 14979
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Il2CppReferenceArray_1_Sprite_Boolean_Il2CppReferenceArray_1_Sprite_Il2CppReferenceArray_1_Sprite_Il2CppReferenceArray_1_Sprite_Boolean_Single_Single_Boolean_Single_Boolean_Single_Il2CppReferenceArray_1_RemovableTrimProperty_Il2CppReferenceArray_1_Sprite_Il2CppReferenceArray_1_Sprite_Single_Single_0;

		// Token: 0x04003A84 RID: 14980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
