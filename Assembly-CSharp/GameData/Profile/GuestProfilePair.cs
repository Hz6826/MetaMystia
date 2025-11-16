using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002E6 RID: 742
	[Serializable]
	public class GuestProfilePair : Il2CppSystem.Object
	{
		// Token: 0x060059F6 RID: 23030 RVA: 0x001CC134 File Offset: 0x001CA334
		// Note: this type is marked as 'beforefieldinit'.
		static GuestProfilePair()
		{
			Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "GuestProfilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr);
			GuestProfilePair.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr, "id");
			GuestProfilePair.NativeFieldInfoPtr_bgColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr, "bgColor");
			GuestProfilePair.NativeFieldInfoPtr_textColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr, "textColor");
			GuestProfilePair.NativeFieldInfoPtr_characterPortrayal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr, "characterPortrayal");
			GuestProfilePair.NativeFieldInfoPtr_characterPixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr, "characterPixel");
			GuestProfilePair.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr, 100681394);
			GuestProfilePair.NativeMethodInfoPtr__ctor_Public_Void_Int32_Color_Color_CharacterProtrayalSet_CharacterSkinSets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr, 100681395);
			GuestProfilePair.NativeMethodInfoPtr_get_ID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr, 100681396);
			GuestProfilePair.NativeMethodInfoPtr_get_BgColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr, 100681397);
			GuestProfilePair.NativeMethodInfoPtr_get_TextColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr, 100681398);
			GuestProfilePair.NativeMethodInfoPtr_get_CharacterPortrayal_Public_get_CharacterProtrayalSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr, 100681399);
			GuestProfilePair.NativeMethodInfoPtr_get_CharacterPixel_Public_get_CharacterSkinSets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr, 100681400);
			GuestProfilePair.NativeMethodInfoPtr_CreateDefault_Public_Static_GuestProfilePair_CharacterProtrayalSet_CharacterSkinSets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr, 100681401);
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x001CC268 File Offset: 0x001CA468
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestProfilePair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestProfilePair.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059F8 RID: 23032 RVA: 0x001CC2A4 File Offset: 0x001CA4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219646, XrefRangeEnd = 219649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestProfilePair(int id, Color bgColor, Color textColor, CharacterProtrayalSet characterPortrayal, CharacterSkinSets characterPixel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestProfilePair>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bgColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterPortrayal);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(characterPixel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestProfilePair.NativeMethodInfoPtr__ctor_Public_Void_Int32_Color_Color_CharacterProtrayalSet_CharacterSkinSets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x060059F9 RID: 23033 RVA: 0x001CC330 File Offset: 0x001CA530
		public unsafe int ID
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestProfilePair.NativeMethodInfoPtr_get_ID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x060059FA RID: 23034 RVA: 0x001CC36C File Offset: 0x001CA56C
		public unsafe Color BgColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestProfilePair.NativeMethodInfoPtr_get_BgColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x060059FB RID: 23035 RVA: 0x001CC3A8 File Offset: 0x001CA5A8
		public unsafe Color TextColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestProfilePair.NativeMethodInfoPtr_get_TextColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x060059FC RID: 23036 RVA: 0x001CC3E4 File Offset: 0x001CA5E4
		public unsafe CharacterProtrayalSet CharacterPortrayal
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 219661, RefRangeEnd = 219671, XrefRangeStart = 219649, XrefRangeEnd = 219661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestProfilePair.NativeMethodInfoPtr_get_CharacterPortrayal_Public_get_CharacterProtrayalSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterProtrayalSet>(intPtr3) : null;
			}
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x060059FD RID: 23037 RVA: 0x001CC424 File Offset: 0x001CA624
		public unsafe CharacterSkinSets CharacterPixel
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 219683, RefRangeEnd = 219688, XrefRangeStart = 219671, XrefRangeEnd = 219683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestProfilePair.NativeMethodInfoPtr_get_CharacterPixel_Public_get_CharacterSkinSets_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSkinSets>(intPtr3) : null;
			}
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x001CC464 File Offset: 0x001CA664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219688, XrefRangeEnd = 219694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GuestProfilePair CreateDefault(CharacterProtrayalSet characterPortrayalSet, CharacterSkinSets skinSets)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterPortrayalSet);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skinSets);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestProfilePair.NativeMethodInfoPtr_CreateDefault_Public_Static_GuestProfilePair_CharacterProtrayalSet_CharacterSkinSets_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestProfilePair>(intPtr3) : null;
		}

		// Token: 0x060059FF RID: 23039 RVA: 0x00030975 File Offset: 0x0002EB75
		public GuestProfilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x06005A00 RID: 23040 RVA: 0x001CC4BC File Offset: 0x001CA6BC
		// (set) Token: 0x06005A01 RID: 23041 RVA: 0x0003097E File Offset: 0x0002EB7E
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestProfilePair.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestProfilePair.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x06005A02 RID: 23042 RVA: 0x001CC4E4 File Offset: 0x001CA6E4
		// (set) Token: 0x06005A03 RID: 23043 RVA: 0x00030999 File Offset: 0x0002EB99
		public unsafe Color bgColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestProfilePair.NativeFieldInfoPtr_bgColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestProfilePair.NativeFieldInfoPtr_bgColor)) = value;
			}
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x06005A04 RID: 23044 RVA: 0x001CC50C File Offset: 0x001CA70C
		// (set) Token: 0x06005A05 RID: 23045 RVA: 0x000309B4 File Offset: 0x0002EBB4
		public unsafe Color textColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestProfilePair.NativeFieldInfoPtr_textColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestProfilePair.NativeFieldInfoPtr_textColor)) = value;
			}
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x06005A06 RID: 23046 RVA: 0x001CC534 File Offset: 0x001CA734
		// (set) Token: 0x06005A07 RID: 23047 RVA: 0x000309CF File Offset: 0x0002EBCF
		public unsafe CharacterProtrayalSet characterPortrayal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestProfilePair.NativeFieldInfoPtr_characterPortrayal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterProtrayalSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestProfilePair.NativeFieldInfoPtr_characterPortrayal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x06005A08 RID: 23048 RVA: 0x001CC564 File Offset: 0x001CA764
		// (set) Token: 0x06005A09 RID: 23049 RVA: 0x000309EE File Offset: 0x0002EBEE
		public unsafe CharacterSkinSets characterPixel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestProfilePair.NativeFieldInfoPtr_characterPixel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSkinSets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestProfilePair.NativeFieldInfoPtr_characterPixel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BF3 RID: 15347
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04003BF4 RID: 15348
		private static readonly IntPtr NativeFieldInfoPtr_bgColor;

		// Token: 0x04003BF5 RID: 15349
		private static readonly IntPtr NativeFieldInfoPtr_textColor;

		// Token: 0x04003BF6 RID: 15350
		private static readonly IntPtr NativeFieldInfoPtr_characterPortrayal;

		// Token: 0x04003BF7 RID: 15351
		private static readonly IntPtr NativeFieldInfoPtr_characterPixel;

		// Token: 0x04003BF8 RID: 15352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04003BF9 RID: 15353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Color_Color_CharacterProtrayalSet_CharacterSkinSets_0;

		// Token: 0x04003BFA RID: 15354
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Public_get_Int32_0;

		// Token: 0x04003BFB RID: 15355
		private static readonly IntPtr NativeMethodInfoPtr_get_BgColor_Public_get_Color_0;

		// Token: 0x04003BFC RID: 15356
		private static readonly IntPtr NativeMethodInfoPtr_get_TextColor_Public_get_Color_0;

		// Token: 0x04003BFD RID: 15357
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterPortrayal_Public_get_CharacterProtrayalSet_0;

		// Token: 0x04003BFE RID: 15358
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterPixel_Public_get_CharacterSkinSets_0;

		// Token: 0x04003BFF RID: 15359
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefault_Public_Static_GuestProfilePair_CharacterProtrayalSet_CharacterSkinSets_0;
	}
}
