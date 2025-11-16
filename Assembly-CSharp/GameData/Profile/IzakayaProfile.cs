using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002DA RID: 730
	public class IzakayaProfile : ScriptableObject
	{
		// Token: 0x060059A8 RID: 22952 RVA: 0x001CB5A8 File Offset: 0x001C97A8
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaProfile()
		{
			Il2CppClassPointerStore<IzakayaProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "IzakayaProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaProfile>.NativeClassPtr);
			IzakayaProfile.NativeFieldInfoPtr_izakayas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaProfile>.NativeClassPtr, "izakayas");
			IzakayaProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaProfile>.NativeClassPtr, 100681353);
		}

		// Token: 0x060059A9 RID: 22953 RVA: 0x001CB600 File Offset: 0x001C9800
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059AA RID: 22954 RVA: 0x00030697 File Offset: 0x0002E897
		public IzakayaProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x060059AB RID: 22955 RVA: 0x001CB63C File Offset: 0x001C983C
		// (set) Token: 0x060059AC RID: 22956 RVA: 0x000306A0 File Offset: 0x0002E8A0
		public unsafe Il2CppReferenceArray<Izakaya> izakayas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaProfile.NativeFieldInfoPtr_izakayas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Izakaya>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaProfile.NativeFieldInfoPtr_izakayas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BD2 RID: 15314
		private static readonly IntPtr NativeFieldInfoPtr_izakayas;

		// Token: 0x04003BD3 RID: 15315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
