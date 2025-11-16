using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections.CharacterUtility
{
	// Token: 0x020002BE RID: 702
	public static class CharacterSpriteSetHelper : Il2CppSystem.Object
	{
		// Token: 0x0600574D RID: 22349 RVA: 0x001C49C0 File Offset: 0x001C2BC0
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterSpriteSetHelper()
		{
			Il2CppClassPointerStore<CharacterSpriteSetHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.CharacterUtility", "CharacterSpriteSetHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSpriteSetHelper>.NativeClassPtr);
			CharacterSpriteSetHelper.NativeMethodInfoPtr_Assign_Public_Static_Void_CharacterSpriteSetCompact_Image_Image_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetHelper>.NativeClassPtr, 100681044);
			CharacterSpriteSetHelper.NativeMethodInfoPtr_Assign_Public_Static_Void_CharacterSpriteSetFull_Image_Image_Image_Image_Image_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetHelper>.NativeClassPtr, 100681045);
			CharacterSpriteSetHelper.NativeMethodInfoPtr_AssignTrimFront_Public_Static_Void_CharacterSpriteSetCompact_Image_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetHelper>.NativeClassPtr, 100681046);
			CharacterSpriteSetHelper.NativeMethodInfoPtr_AssignTrimBack_Public_Static_Void_CharacterSpriteSetCompact_Image_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetHelper>.NativeClassPtr, 100681047);
			CharacterSpriteSetHelper.NativeMethodInfoPtr_Assign_Public_Static_Void_CharacterSpriteSetCompact_SpriteRenderer_SpriteRenderer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetHelper>.NativeClassPtr, 100681048);
			CharacterSpriteSetHelper.NativeMethodInfoPtr_Assign_Public_Static_Void_CharacterSpriteSetFull_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetHelper>.NativeClassPtr, 100681049);
			CharacterSpriteSetHelper.NativeMethodInfoPtr_AssignTrimFront_Public_Static_Void_CharacterSpriteSetCompact_SpriteRenderer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetHelper>.NativeClassPtr, 100681050);
			CharacterSpriteSetHelper.NativeMethodInfoPtr_AssignTrimBack_Public_Static_Void_CharacterSpriteSetCompact_SpriteRenderer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSpriteSetHelper>.NativeClassPtr, 100681051);
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x001C4A90 File Offset: 0x001C2C90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 216071, RefRangeEnd = 216075, XrefRangeStart = 216065, XrefRangeEnd = 216071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Assign(this CharacterSpriteSetCompact characterSpriteSet, Image mainImage, Image eyesImage, int mainIndex, int eyesIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterSpriteSet);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mainImage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eyesImage);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eyesIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetHelper.NativeMethodInfoPtr_Assign_Public_Static_Void_CharacterSpriteSetCompact_Image_Image_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x001C4B08 File Offset: 0x001C2D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216085, RefRangeEnd = 216086, XrefRangeStart = 216075, XrefRangeEnd = 216085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Assign(this CharacterSpriteSetFull characterSpriteSet, Image backImage, Image baseImage, Image dressImage, Image hairImage, Image eyesImage, int mainIndex, int eyesIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterSpriteSet);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(backImage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseImage);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dressImage);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hairImage);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eyesImage);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eyesIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetHelper.NativeMethodInfoPtr_Assign_Public_Static_Void_CharacterSpriteSetFull_Image_Image_Image_Image_Image_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005750 RID: 22352 RVA: 0x001C4BB8 File Offset: 0x001C2DB8
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 216093, RefRangeEnd = 216117, XrefRangeStart = 216086, XrefRangeEnd = 216093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignTrimFront(this CharacterSpriteSetCompact characterSpriteSet, Image trimFrontImage, int frontIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterSpriteSet);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trimFrontImage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frontIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetHelper.NativeMethodInfoPtr_AssignTrimFront_Public_Static_Void_CharacterSpriteSetCompact_Image_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x001C4C10 File Offset: 0x001C2E10
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 216124, RefRangeEnd = 216148, XrefRangeStart = 216117, XrefRangeEnd = 216124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignTrimBack(this CharacterSpriteSetCompact characterSpriteSet, Image trimBackImage, int backIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterSpriteSet);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trimBackImage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetHelper.NativeMethodInfoPtr_AssignTrimBack_Public_Static_Void_CharacterSpriteSetCompact_Image_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x001C4C68 File Offset: 0x001C2E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216148, XrefRangeEnd = 216154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Assign(this CharacterSpriteSetCompact characterSpriteSet, SpriteRenderer mainImage, SpriteRenderer eyesImage, int mainIndex, int eyesIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterSpriteSet);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mainImage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eyesImage);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eyesIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetHelper.NativeMethodInfoPtr_Assign_Public_Static_Void_CharacterSpriteSetCompact_SpriteRenderer_SpriteRenderer_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005753 RID: 22355 RVA: 0x001C4CE0 File Offset: 0x001C2EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216154, XrefRangeEnd = 216164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Assign(this CharacterSpriteSetFull characterSpriteSet, SpriteRenderer backImage, SpriteRenderer baseImage, SpriteRenderer dressImage, SpriteRenderer hairImage, SpriteRenderer eyesImage, int mainIndex, int eyesIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterSpriteSet);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(backImage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseImage);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dressImage);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hairImage);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eyesImage);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eyesIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetHelper.NativeMethodInfoPtr_Assign_Public_Static_Void_CharacterSpriteSetFull_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005754 RID: 22356 RVA: 0x001C4D90 File Offset: 0x001C2F90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216171, RefRangeEnd = 216173, XrefRangeStart = 216164, XrefRangeEnd = 216171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignTrimFront(this CharacterSpriteSetCompact characterSpriteSet, SpriteRenderer trimFrontImage, int frontIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterSpriteSet);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trimFrontImage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frontIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetHelper.NativeMethodInfoPtr_AssignTrimFront_Public_Static_Void_CharacterSpriteSetCompact_SpriteRenderer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005755 RID: 22357 RVA: 0x001C4DE8 File Offset: 0x001C2FE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216180, RefRangeEnd = 216182, XrefRangeStart = 216173, XrefRangeEnd = 216180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AssignTrimBack(this CharacterSpriteSetCompact characterSpriteSet, SpriteRenderer trimBackImage, int backIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterSpriteSet);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trimBackImage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSpriteSetHelper.NativeMethodInfoPtr_AssignTrimBack_Public_Static_Void_CharacterSpriteSetCompact_SpriteRenderer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x0002F001 File Offset: 0x0002D201
		public CharacterSpriteSetHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003A72 RID: 14962
		private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Static_Void_CharacterSpriteSetCompact_Image_Image_Int32_Int32_0;

		// Token: 0x04003A73 RID: 14963
		private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Static_Void_CharacterSpriteSetFull_Image_Image_Image_Image_Image_Int32_Int32_0;

		// Token: 0x04003A74 RID: 14964
		private static readonly IntPtr NativeMethodInfoPtr_AssignTrimFront_Public_Static_Void_CharacterSpriteSetCompact_Image_Int32_0;

		// Token: 0x04003A75 RID: 14965
		private static readonly IntPtr NativeMethodInfoPtr_AssignTrimBack_Public_Static_Void_CharacterSpriteSetCompact_Image_Int32_0;

		// Token: 0x04003A76 RID: 14966
		private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Static_Void_CharacterSpriteSetCompact_SpriteRenderer_SpriteRenderer_Int32_Int32_0;

		// Token: 0x04003A77 RID: 14967
		private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Static_Void_CharacterSpriteSetFull_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_SpriteRenderer_Int32_Int32_0;

		// Token: 0x04003A78 RID: 14968
		private static readonly IntPtr NativeMethodInfoPtr_AssignTrimFront_Public_Static_Void_CharacterSpriteSetCompact_SpriteRenderer_Int32_0;

		// Token: 0x04003A79 RID: 14969
		private static readonly IntPtr NativeMethodInfoPtr_AssignTrimBack_Public_Static_Void_CharacterSpriteSetCompact_SpriteRenderer_Int32_0;
	}
}
