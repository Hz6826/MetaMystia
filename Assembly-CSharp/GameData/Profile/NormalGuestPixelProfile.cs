using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002E1 RID: 737
	public class NormalGuestPixelProfile : ScriptableObject
	{
		// Token: 0x060059D6 RID: 22998 RVA: 0x001CBCA8 File Offset: 0x001C9EA8
		// Note: this type is marked as 'beforefieldinit'.
		static NormalGuestPixelProfile()
		{
			Il2CppClassPointerStore<NormalGuestPixelProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "NormalGuestPixelProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestPixelProfile>.NativeClassPtr);
			NormalGuestPixelProfile.NativeFieldInfoPtr_unifiedBGColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestPixelProfile>.NativeClassPtr, "unifiedBGColor");
			NormalGuestPixelProfile.NativeFieldInfoPtr_unifiedTextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestPixelProfile>.NativeClassPtr, "unifiedTextColor");
			NormalGuestPixelProfile.NativeFieldInfoPtr_normalGuestPixelPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestPixelProfile>.NativeClassPtr, "normalGuestPixelPairs");
			NormalGuestPixelProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestPixelProfile>.NativeClassPtr, 100681382);
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x001CBD28 File Offset: 0x001C9F28
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NormalGuestPixelProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestPixelProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestPixelProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059D8 RID: 23000 RVA: 0x0003084A File Offset: 0x0002EA4A
		public NormalGuestPixelProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x060059D9 RID: 23001 RVA: 0x001CBD64 File Offset: 0x001C9F64
		// (set) Token: 0x060059DA RID: 23002 RVA: 0x00030853 File Offset: 0x0002EA53
		public unsafe Color unifiedBGColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestPixelProfile.NativeFieldInfoPtr_unifiedBGColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestPixelProfile.NativeFieldInfoPtr_unifiedBGColor)) = value;
			}
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x060059DB RID: 23003 RVA: 0x001CBD8C File Offset: 0x001C9F8C
		// (set) Token: 0x060059DC RID: 23004 RVA: 0x0003086E File Offset: 0x0002EA6E
		public unsafe Color unifiedTextColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestPixelProfile.NativeFieldInfoPtr_unifiedTextColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestPixelProfile.NativeFieldInfoPtr_unifiedTextColor)) = value;
			}
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x060059DD RID: 23005 RVA: 0x001CBDB4 File Offset: 0x001C9FB4
		// (set) Token: 0x060059DE RID: 23006 RVA: 0x00030889 File Offset: 0x0002EA89
		public unsafe Il2CppReferenceArray<NormalGuestPixelPair> normalGuestPixelPairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestPixelProfile.NativeFieldInfoPtr_normalGuestPixelPairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NormalGuestPixelPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestPixelProfile.NativeFieldInfoPtr_normalGuestPixelPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BE6 RID: 15334
		private static readonly IntPtr NativeFieldInfoPtr_unifiedBGColor;

		// Token: 0x04003BE7 RID: 15335
		private static readonly IntPtr NativeFieldInfoPtr_unifiedTextColor;

		// Token: 0x04003BE8 RID: 15336
		private static readonly IntPtr NativeFieldInfoPtr_normalGuestPixelPairs;

		// Token: 0x04003BE9 RID: 15337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
