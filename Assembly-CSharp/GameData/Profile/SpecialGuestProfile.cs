using System;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002ED RID: 749
	public class SpecialGuestProfile : ScriptableObject
	{
		// Token: 0x06005A43 RID: 23107 RVA: 0x001CCEBC File Offset: 0x001CB0BC
		// Note: this type is marked as 'beforefieldinit'.
		static SpecialGuestProfile()
		{
			Il2CppClassPointerStore<SpecialGuestProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "SpecialGuestProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestProfile>.NativeClassPtr);
			SpecialGuestProfile.NativeFieldInfoPtr_specialGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestProfile>.NativeClassPtr, "specialGuests");
			SpecialGuestProfile.NativeFieldInfoPtr_mappedSpecialGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestProfile>.NativeClassPtr, "mappedSpecialGuests");
			SpecialGuestProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestProfile>.NativeClassPtr, 100681427);
		}

		// Token: 0x06005A44 RID: 23108 RVA: 0x001CCF28 File Offset: 0x001CB128
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialGuestProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x00030C4E File Offset: 0x0002EE4E
		public SpecialGuestProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x06005A46 RID: 23110 RVA: 0x001CCF64 File Offset: 0x001CB164
		// (set) Token: 0x06005A47 RID: 23111 RVA: 0x00030C57 File Offset: 0x0002EE57
		public unsafe Il2CppReferenceArray<SpecialGuest> specialGuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestProfile.NativeFieldInfoPtr_specialGuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestProfile.NativeFieldInfoPtr_specialGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x06005A48 RID: 23112 RVA: 0x001CCF94 File Offset: 0x001CB194
		// (set) Token: 0x06005A49 RID: 23113 RVA: 0x00030C76 File Offset: 0x0002EE76
		public unsafe Il2CppReferenceArray<MappedSpecialGuest> mappedSpecialGuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestProfile.NativeFieldInfoPtr_mappedSpecialGuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MappedSpecialGuest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestProfile.NativeFieldInfoPtr_mappedSpecialGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C1C RID: 15388
		private static readonly IntPtr NativeFieldInfoPtr_specialGuests;

		// Token: 0x04003C1D RID: 15389
		private static readonly IntPtr NativeFieldInfoPtr_mappedSpecialGuests;

		// Token: 0x04003C1E RID: 15390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
