using System;
using GameData.Core.Collections.CharacterUtility;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x0200024A RID: 586
	[Serializable]
	public class GuestBase : Il2CppSystem.Object
	{
		// Token: 0x0600496A RID: 18794 RVA: 0x0019D60C File Offset: 0x0019B80C
		// Note: this type is marked as 'beforefieldinit'.
		static GuestBase()
		{
			Il2CppClassPointerStore<GuestBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "GuestBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestBase>.NativeClassPtr);
			GuestBase.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestBase>.NativeClassPtr, "id");
			GuestBase.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBase>.NativeClassPtr, 100677922);
			GuestBase.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBase>.NativeClassPtr, 100677923);
			GuestBase.NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBase>.NativeClassPtr, 100677924);
			GuestBase.NativeMethodInfoPtr_get_CharacterPortrayal_Public_Virtual_New_get_CharacterPortrayal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBase>.NativeClassPtr, 100677925);
			GuestBase.NativeMethodInfoPtr_get_CharacterPixel_Public_Virtual_New_get_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBase>.NativeClassPtr, 100677926);
			GuestBase.NativeMethodInfoPtr_get_Text_Public_Virtual_New_get_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBase>.NativeClassPtr, 100677927);
			GuestBase.NativeMethodInfoPtr_get_CharacterColorScheme_Public_get_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBase>.NativeClassPtr, 100677928);
			GuestBase.NativeMethodInfoPtr_get_LikeFoodTag_Public_Virtual_New_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBase>.NativeClassPtr, 100677929);
			GuestBase.NativeMethodInfoPtr_GetFundRange_Public_Virtual_New_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBase>.NativeClassPtr, 100677930);
			GuestBase.NativeMethodInfoPtr_GenerateFund_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBase>.NativeClassPtr, 100677931);
			GuestBase.NativeMethodInfoPtr_OnGetVisual_Protected_Virtual_New_GuestProfilePair_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestBase>.NativeClassPtr, 100677932);
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x0019D72C File Offset: 0x0019B92C
		[CallerCount(94)]
		[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestBase(int id) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestBase>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBase.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x0600496C RID: 18796 RVA: 0x0019D774 File Offset: 0x0019B974
		// (set) Token: 0x0600496D RID: 18797 RVA: 0x0019D7B0 File Offset: 0x0019B9B0
		public unsafe int Id
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBase.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 138385, RefRangeEnd = 138389, XrefRangeStart = 138385, XrefRangeEnd = 138389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBase.NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x0600496E RID: 18798 RVA: 0x0019D7F0 File Offset: 0x0019B9F0
		public unsafe virtual CharacterPortrayal CharacterPortrayal
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestBase.NativeMethodInfoPtr_get_CharacterPortrayal_Public_Virtual_New_get_CharacterPortrayal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterPortrayal>(intPtr3) : null;
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x0600496F RID: 18799 RVA: 0x0019D83C File Offset: 0x0019BA3C
		public unsafe virtual CharacterSpriteSetCompact CharacterPixel
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestBase.NativeMethodInfoPtr_get_CharacterPixel_Public_Virtual_New_get_CharacterSpriteSetCompact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x06004970 RID: 18800 RVA: 0x0019D888 File Offset: 0x0019BA88
		public unsafe virtual LanguageBase Text
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestBase.NativeMethodInfoPtr_get_Text_Public_Virtual_New_get_LanguageBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr3) : null;
			}
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06004971 RID: 18801 RVA: 0x0019D8D4 File Offset: 0x0019BAD4
		public unsafe Il2CppStructArray<Color> CharacterColorScheme
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 191612, RefRangeEnd = 191621, XrefRangeStart = 191609, XrefRangeEnd = 191612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBase.NativeMethodInfoPtr_get_CharacterColorScheme_Public_get_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06004972 RID: 18802 RVA: 0x0019D914 File Offset: 0x0019BB14
		public unsafe virtual Il2CppStructArray<int> LikeFoodTag
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestBase.NativeMethodInfoPtr_get_LikeFoodTag_Public_Virtual_New_get_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x0019D960 File Offset: 0x0019BB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191621, XrefRangeEnd = 191623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector2Int GetFundRange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestBase.NativeMethodInfoPtr_GetFundRange_Public_Virtual_New_Vector2Int_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x0019D9A8 File Offset: 0x0019BBA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 191637, RefRangeEnd = 191640, XrefRangeStart = 191623, XrefRangeEnd = 191637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GenerateFund()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestBase.NativeMethodInfoPtr_GenerateFund_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x0019D9E4 File Offset: 0x0019BBE4
		[CallerCount(84)]
		[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GuestProfilePair OnGetVisual(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestBase.NativeMethodInfoPtr_OnGetVisual_Protected_Virtual_New_GuestProfilePair_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestProfilePair>(intPtr3) : null;
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x00025B1B File Offset: 0x00023D1B
		public GuestBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06004977 RID: 18807 RVA: 0x0019DA3C File Offset: 0x0019BC3C
		// (set) Token: 0x06004978 RID: 18808 RVA: 0x00025B24 File Offset: 0x00023D24
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBase.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestBase.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x04003273 RID: 12915
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04003274 RID: 12916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003275 RID: 12917
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04003276 RID: 12918
		private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0;

		// Token: 0x04003277 RID: 12919
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterPortrayal_Public_Virtual_New_get_CharacterPortrayal_0;

		// Token: 0x04003278 RID: 12920
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterPixel_Public_Virtual_New_get_CharacterSpriteSetCompact_0;

		// Token: 0x04003279 RID: 12921
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_Virtual_New_get_LanguageBase_0;

		// Token: 0x0400327A RID: 12922
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterColorScheme_Public_get_Il2CppStructArray_1_Color_0;

		// Token: 0x0400327B RID: 12923
		private static readonly IntPtr NativeMethodInfoPtr_get_LikeFoodTag_Public_Virtual_New_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400327C RID: 12924
		private static readonly IntPtr NativeMethodInfoPtr_GetFundRange_Public_Virtual_New_Vector2Int_0;

		// Token: 0x0400327D RID: 12925
		private static readonly IntPtr NativeMethodInfoPtr_GenerateFund_Public_Int32_0;

		// Token: 0x0400327E RID: 12926
		private static readonly IntPtr NativeMethodInfoPtr_OnGetVisual_Protected_Virtual_New_GuestProfilePair_Int32_0;
	}
}
