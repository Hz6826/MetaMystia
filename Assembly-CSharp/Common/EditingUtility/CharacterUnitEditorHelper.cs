using System;
using DEYU.Utils;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Common.EditingUtility
{
	// Token: 0x0200044F RID: 1103
	public class CharacterUnitEditorHelper : LayerSortingController
	{
		// Token: 0x060079D1 RID: 31185 RVA: 0x00232580 File Offset: 0x00230780
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterUnitEditorHelper()
		{
			Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.EditingUtility", "CharacterUnitEditorHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr);
			CharacterUnitEditorHelper.NativeFieldInfoPtr_m_CachedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr, "m_CachedSprite");
			CharacterUnitEditorHelper.NativeFieldInfoPtr_m_Compact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr, "m_Compact");
			CharacterUnitEditorHelper.NativeFieldInfoPtr_m_Full = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr, "m_Full");
			CharacterUnitEditorHelper.NativeFieldInfoPtr_m_SelectedRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr, "m_SelectedRotation");
			CharacterUnitEditorHelper.NativeFieldInfoPtr_m_SelectedFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr, "m_SelectedFace");
			CharacterUnitEditorHelper.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr, 100687758);
			CharacterUnitEditorHelper.NativeMethodInfoPtr_AssignCompact_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr, 100687759);
			CharacterUnitEditorHelper.NativeMethodInfoPtr_GetSpriteCode_Private_ValueTuple_2_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr, 100687760);
			CharacterUnitEditorHelper.NativeMethodInfoPtr_AssignFull_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr, 100687761);
			CharacterUnitEditorHelper.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr, 100687762);
			CharacterUnitEditorHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr, 100687763);
		}

		// Token: 0x060079D2 RID: 31186 RVA: 0x0023268C File Offset: 0x0023088C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294236, XrefRangeEnd = 294245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterUnitEditorHelper.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079D3 RID: 31187 RVA: 0x002326C0 File Offset: 0x002308C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294264, RefRangeEnd = 294265, XrefRangeStart = 294245, XrefRangeEnd = 294264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignCompact(int rotation, int face)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterUnitEditorHelper.NativeMethodInfoPtr_AssignCompact_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x0023270C File Offset: 0x0023090C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294268, RefRangeEnd = 294270, XrefRangeStart = 294265, XrefRangeEnd = 294268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, int> GetSpriteCode(int orientation, int faceId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orientation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceId;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CharacterUnitEditorHelper.NativeMethodInfoPtr_GetSpriteCode_Private_ValueTuple_2_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<int, int>(pointer);
		}

		// Token: 0x060079D5 RID: 31189 RVA: 0x00232760 File Offset: 0x00230960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294288, RefRangeEnd = 294289, XrefRangeStart = 294270, XrefRangeEnd = 294288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignFull(int rotation, int face)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref face;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterUnitEditorHelper.NativeMethodInfoPtr_AssignFull_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079D6 RID: 31190 RVA: 0x002327AC File Offset: 0x002309AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294289, XrefRangeEnd = 294292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterUnitEditorHelper.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079D7 RID: 31191 RVA: 0x002327E8 File Offset: 0x002309E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterUnitEditorHelper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterUnitEditorHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterUnitEditorHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060079D8 RID: 31192 RVA: 0x00041D20 File Offset: 0x0003FF20
		public CharacterUnitEditorHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x060079D9 RID: 31193 RVA: 0x00232824 File Offset: 0x00230A24
		// (set) Token: 0x060079DA RID: 31194 RVA: 0x00041D29 File Offset: 0x0003FF29
		public unsafe static Il2CppReferenceArray<Sprite> m_CachedSprite
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharacterUnitEditorHelper.NativeFieldInfoPtr_m_CachedSprite, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterUnitEditorHelper.NativeFieldInfoPtr_m_CachedSprite, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x060079DB RID: 31195 RVA: 0x0023284C File Offset: 0x00230A4C
		// (set) Token: 0x060079DC RID: 31196 RVA: 0x00041D3B File Offset: 0x0003FF3B
		public unsafe CharacterSpriteSetCompact m_Compact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterUnitEditorHelper.NativeFieldInfoPtr_m_Compact);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterUnitEditorHelper.NativeFieldInfoPtr_m_Compact), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x060079DD RID: 31197 RVA: 0x0023287C File Offset: 0x00230A7C
		// (set) Token: 0x060079DE RID: 31198 RVA: 0x00041D5A File Offset: 0x0003FF5A
		public unsafe CharacterSpriteSetFull m_Full
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterUnitEditorHelper.NativeFieldInfoPtr_m_Full);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetFull>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterUnitEditorHelper.NativeFieldInfoPtr_m_Full), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700294A RID: 10570
		// (get) Token: 0x060079DF RID: 31199 RVA: 0x002328AC File Offset: 0x00230AAC
		// (set) Token: 0x060079E0 RID: 31200 RVA: 0x00041D79 File Offset: 0x0003FF79
		public unsafe int m_SelectedRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterUnitEditorHelper.NativeFieldInfoPtr_m_SelectedRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterUnitEditorHelper.NativeFieldInfoPtr_m_SelectedRotation)) = value;
			}
		}

		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x060079E1 RID: 31201 RVA: 0x002328D4 File Offset: 0x00230AD4
		// (set) Token: 0x060079E2 RID: 31202 RVA: 0x00041D94 File Offset: 0x0003FF94
		public unsafe int m_SelectedFace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterUnitEditorHelper.NativeFieldInfoPtr_m_SelectedFace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterUnitEditorHelper.NativeFieldInfoPtr_m_SelectedFace)) = value;
			}
		}

		// Token: 0x04005021 RID: 20513
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedSprite;

		// Token: 0x04005022 RID: 20514
		private static readonly IntPtr NativeFieldInfoPtr_m_Compact;

		// Token: 0x04005023 RID: 20515
		private static readonly IntPtr NativeFieldInfoPtr_m_Full;

		// Token: 0x04005024 RID: 20516
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedRotation;

		// Token: 0x04005025 RID: 20517
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedFace;

		// Token: 0x04005026 RID: 20518
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005027 RID: 20519
		private static readonly IntPtr NativeMethodInfoPtr_AssignCompact_Public_Void_Int32_Int32_0;

		// Token: 0x04005028 RID: 20520
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteCode_Private_ValueTuple_2_Int32_Int32_Int32_Int32_0;

		// Token: 0x04005029 RID: 20521
		private static readonly IntPtr NativeMethodInfoPtr_AssignFull_Public_Void_Int32_Int32_0;

		// Token: 0x0400502A RID: 20522
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400502B RID: 20523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
