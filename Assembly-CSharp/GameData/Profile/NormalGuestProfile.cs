using System;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002E3 RID: 739
	public class NormalGuestProfile : ScriptableObject
	{
		// Token: 0x060059E6 RID: 23014 RVA: 0x001CBE94 File Offset: 0x001CA094
		// Note: this type is marked as 'beforefieldinit'.
		static NormalGuestProfile()
		{
			Il2CppClassPointerStore<NormalGuestProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "NormalGuestProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NormalGuestProfile>.NativeClassPtr);
			NormalGuestProfile.NativeFieldInfoPtr_normalGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalGuestProfile>.NativeClassPtr, "normalGuests");
			NormalGuestProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalGuestProfile>.NativeClassPtr, 100681383);
		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x001CBEEC File Offset: 0x001CA0EC
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NormalGuestProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NormalGuestProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalGuestProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x000308FD File Offset: 0x0002EAFD
		public NormalGuestProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x060059E9 RID: 23017 RVA: 0x001CBF28 File Offset: 0x001CA128
		// (set) Token: 0x060059EA RID: 23018 RVA: 0x00030906 File Offset: 0x0002EB06
		public unsafe Il2CppReferenceArray<NormalGuest> normalGuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestProfile.NativeFieldInfoPtr_normalGuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NormalGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NormalGuestProfile.NativeFieldInfoPtr_normalGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BEC RID: 15340
		private static readonly IntPtr NativeFieldInfoPtr_normalGuests;

		// Token: 0x04003BED RID: 15341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
