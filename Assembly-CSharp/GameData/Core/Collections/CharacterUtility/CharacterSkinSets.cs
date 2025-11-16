using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Core.Collections.CharacterUtility
{
	// Token: 0x020002BC RID: 700
	public class CharacterSkinSets : ScriptableObject
	{
		// Token: 0x060056FE RID: 22270 RVA: 0x001C38A8 File Offset: 0x001C1AA8
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterSkinSets()
		{
			Il2CppClassPointerStore<CharacterSkinSets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.CharacterUtility", "CharacterSkinSets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSkinSets>.NativeClassPtr);
			CharacterSkinSets.NativeFieldInfoPtr_defaultSkin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSkinSets>.NativeClassPtr, "defaultSkin");
			CharacterSkinSets.NativeFieldInfoPtr_explicits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSkinSets>.NativeClassPtr, "explicits");
			CharacterSkinSets.NativeFieldInfoPtr_dlcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSkinSets>.NativeClassPtr, "dlcs");
			CharacterSkinSets.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_Il2CppReferenceArray_1_CharacterSpriteSetCompact_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSkinSets>.NativeClassPtr, 100681002);
			CharacterSkinSets.NativeMethodInfoPtr_GetPixel_Public_CharacterSpriteSetCompact_SkinSelectionInfo_Boolean_Nullable_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSkinSets>.NativeClassPtr, 100681003);
			CharacterSkinSets.NativeMethodInfoPtr_GetDefaultPixel_Public_CharacterSpriteSetCompact_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSkinSets>.NativeClassPtr, 100681004);
			CharacterSkinSets.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSkinSets>.NativeClassPtr, 100681005);
		}

		// Token: 0x060056FF RID: 22271 RVA: 0x001C3964 File Offset: 0x001C1B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216004, XrefRangeEnd = 216007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(CharacterSpriteSetCompact defaultSkin, Il2CppReferenceArray<CharacterSpriteSetCompact> explicits, Il2CppReferenceArray<CharacterSpriteSetCompact> dlcs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultSkin);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(explicits);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dlcs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSkinSets.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_Il2CppReferenceArray_1_CharacterSpriteSetCompact_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005700 RID: 22272 RVA: 0x001C39CC File Offset: 0x001C1BCC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 216012, RefRangeEnd = 216020, XrefRangeStart = 216007, XrefRangeEnd = 216012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterSpriteSetCompact GetPixel(CharacterSkinSets.SkinSelectionInfo selectionInfo, bool isCompact, Nullable<int> overrideIndex, bool useDefaultSkin = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectionInfo;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCompact;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(overrideIndex));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDefaultSkin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSkinSets.NativeMethodInfoPtr_GetPixel_Public_CharacterSpriteSetCompact_SkinSelectionInfo_Boolean_Nullable_1_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
		}

		// Token: 0x06005701 RID: 22273 RVA: 0x001C3A4C File Offset: 0x001C1C4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216031, RefRangeEnd = 216032, XrefRangeStart = 216020, XrefRangeEnd = 216031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterSpriteSetCompact GetDefaultPixel(bool isCompact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isCompact;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSkinSets.NativeMethodInfoPtr_GetDefaultPixel_Public_CharacterSpriteSetCompact_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
		}

		// Token: 0x06005702 RID: 22274 RVA: 0x001C3A98 File Offset: 0x001C1C98
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterSkinSets() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSkinSets>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSkinSets.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005703 RID: 22275 RVA: 0x0002ED7D File Offset: 0x0002CF7D
		public CharacterSkinSets(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x06005704 RID: 22276 RVA: 0x001C3AD4 File Offset: 0x001C1CD4
		// (set) Token: 0x06005705 RID: 22277 RVA: 0x0002ED86 File Offset: 0x0002CF86
		public unsafe CharacterSpriteSetCompact defaultSkin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSkinSets.NativeFieldInfoPtr_defaultSkin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSkinSets.NativeFieldInfoPtr_defaultSkin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x06005706 RID: 22278 RVA: 0x001C3B04 File Offset: 0x001C1D04
		// (set) Token: 0x06005707 RID: 22279 RVA: 0x0002EDA5 File Offset: 0x0002CFA5
		public unsafe Il2CppReferenceArray<CharacterSpriteSetCompact> explicits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSkinSets.NativeFieldInfoPtr_explicits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterSpriteSetCompact>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSkinSets.NativeFieldInfoPtr_explicits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x06005708 RID: 22280 RVA: 0x001C3B34 File Offset: 0x001C1D34
		// (set) Token: 0x06005709 RID: 22281 RVA: 0x0002EDC4 File Offset: 0x0002CFC4
		public unsafe Il2CppReferenceArray<CharacterSpriteSetCompact> dlcs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSkinSets.NativeFieldInfoPtr_dlcs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterSpriteSetCompact>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterSkinSets.NativeFieldInfoPtr_dlcs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003A3D RID: 14909
		private static readonly IntPtr NativeFieldInfoPtr_defaultSkin;

		// Token: 0x04003A3E RID: 14910
		private static readonly IntPtr NativeFieldInfoPtr_explicits;

		// Token: 0x04003A3F RID: 14911
		private static readonly IntPtr NativeFieldInfoPtr_dlcs;

		// Token: 0x04003A40 RID: 14912
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_Il2CppReferenceArray_1_CharacterSpriteSetCompact_Il2CppReferenceArray_1_CharacterSpriteSetCompact_0;

		// Token: 0x04003A41 RID: 14913
		private static readonly IntPtr NativeMethodInfoPtr_GetPixel_Public_CharacterSpriteSetCompact_SkinSelectionInfo_Boolean_Nullable_1_Int32_Boolean_0;

		// Token: 0x04003A42 RID: 14914
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultPixel_Public_CharacterSpriteSetCompact_Boolean_0;

		// Token: 0x04003A43 RID: 14915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C81 RID: 3201
		[Serializable]
		public enum SelectedType
		{
			// Token: 0x040092E7 RID: 37607
			Default,
			// Token: 0x040092E8 RID: 37608
			Explicit,
			// Token: 0x040092E9 RID: 37609
			DLC
		}

		// Token: 0x02000C82 RID: 3202
		[Serializable]
		[StructLayout(2)]
		public struct SkinSelectionInfo
		{
			// Token: 0x0600E60F RID: 58895 RVA: 0x00373714 File Offset: 0x00371914
			// Note: this type is marked as 'beforefieldinit'.
			static SkinSelectionInfo()
			{
				Il2CppClassPointerStore<CharacterSkinSets.SkinSelectionInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterSkinSets>.NativeClassPtr, "SkinSelectionInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSkinSets.SkinSelectionInfo>.NativeClassPtr);
				CharacterSkinSets.SkinSelectionInfo.NativeFieldInfoPtr_selectedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSkinSets.SkinSelectionInfo>.NativeClassPtr, "selectedType");
				CharacterSkinSets.SkinSelectionInfo.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSkinSets.SkinSelectionInfo>.NativeClassPtr, "index");
				CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr__ctor_Public_Void_SelectedType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSkinSets.SkinSelectionInfo>.NativeClassPtr, 100681006);
				CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_get_Default_Public_Static_get_SkinSelectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSkinSets.SkinSelectionInfo>.NativeClassPtr, 100681007);
				CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SkinSelectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSkinSets.SkinSelectionInfo>.NativeClassPtr, 100681008);
				CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSkinSets.SkinSelectionInfo>.NativeClassPtr, 100681009);
				CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSkinSets.SkinSelectionInfo>.NativeClassPtr, 100681010);
				CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSkinSets.SkinSelectionInfo>.NativeClassPtr, 100681011);
				CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SkinSelectionInfo_SkinSelectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSkinSets.SkinSelectionInfo>.NativeClassPtr, 100681012);
				CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SkinSelectionInfo_SkinSelectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSkinSets.SkinSelectionInfo>.NativeClassPtr, 100681013);
			}

			// Token: 0x0600E610 RID: 58896 RVA: 0x00373808 File Offset: 0x00371A08
			[CallerCount(104)]
			[CachedScanResults(RefRangeStart = 395, RefRangeEnd = 499, XrefRangeStart = 395, XrefRangeEnd = 499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SkinSelectionInfo(CharacterSkinSets.SelectedType selectedType, int index)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref selectedType;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr__ctor_Public_Void_SelectedType_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004A98 RID: 19096
			// (get) Token: 0x0600E611 RID: 58897 RVA: 0x00373848 File Offset: 0x00371A48
			public unsafe static CharacterSkinSets.SkinSelectionInfo Default
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 215976, RefRangeEnd = 215990, XrefRangeStart = 215976, XrefRangeEnd = 215976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_get_Default_Public_Static_get_SkinSelectionInfo_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600E612 RID: 58898 RVA: 0x00373878 File Offset: 0x00371A78
			[CallerCount(0)]
			public unsafe bool Equals(CharacterSkinSets.SkinSelectionInfo other)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SkinSelectionInfo_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E613 RID: 58899 RVA: 0x003738B8 File Offset: 0x00371AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215990, XrefRangeEnd = 215999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E614 RID: 58900 RVA: 0x003738E4 File Offset: 0x00371AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215999, XrefRangeEnd = 216002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Il2CppSystem.Object obj)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E615 RID: 58901 RVA: 0x00373928 File Offset: 0x00371B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216002, XrefRangeEnd = 216004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E616 RID: 58902 RVA: 0x00373958 File Offset: 0x00371B58
			[CallerCount(0)]
			public unsafe static bool operator ==(CharacterSkinSets.SkinSelectionInfo left, CharacterSkinSets.SkinSelectionInfo right)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref left;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SkinSelectionInfo_SkinSelectionInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E617 RID: 58903 RVA: 0x003739A4 File Offset: 0x00371BA4
			[CallerCount(0)]
			public unsafe static bool operator !=(CharacterSkinSets.SkinSelectionInfo left, CharacterSkinSets.SkinSelectionInfo right)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref left;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSkinSets.SkinSelectionInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SkinSelectionInfo_SkinSelectionInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E618 RID: 58904 RVA: 0x0007AD94 File Offset: 0x00078F94
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterSkinSets.SkinSelectionInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x040092EA RID: 37610
			private static readonly IntPtr NativeFieldInfoPtr_selectedType;

			// Token: 0x040092EB RID: 37611
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040092EC RID: 37612
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SelectedType_Int32_0;

			// Token: 0x040092ED RID: 37613
			private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_SkinSelectionInfo_0;

			// Token: 0x040092EE RID: 37614
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SkinSelectionInfo_0;

			// Token: 0x040092EF RID: 37615
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x040092F0 RID: 37616
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x040092F1 RID: 37617
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040092F2 RID: 37618
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SkinSelectionInfo_SkinSelectionInfo_0;

			// Token: 0x040092F3 RID: 37619
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SkinSelectionInfo_SkinSelectionInfo_0;

			// Token: 0x040092F4 RID: 37620
			[FieldOffset(0)]
			public CharacterSkinSets.SelectedType selectedType;

			// Token: 0x040092F5 RID: 37621
			[FieldOffset(4)]
			public int index;
		}
	}
}
