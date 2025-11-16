using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000326 RID: 806
	public class PartnerInfoProfile : ScriptableObject
	{
		// Token: 0x06005F47 RID: 24391 RVA: 0x001DB92C File Offset: 0x001D9B2C
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoProfile()
		{
			Il2CppClassPointerStore<PartnerInfoProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoProfile>.NativeClassPtr);
			PartnerInfoProfile.NativeFieldInfoPtr_partnerInfoCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoProfile>.NativeClassPtr, "partnerInfoCollection");
			PartnerInfoProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoProfile>.NativeClassPtr, 100682866);
		}

		// Token: 0x06005F48 RID: 24392 RVA: 0x001DB984 File Offset: 0x001D9B84
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x00033E2E File Offset: 0x0003202E
		public PartnerInfoProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x06005F4A RID: 24394 RVA: 0x001DB9C0 File Offset: 0x001D9BC0
		// (set) Token: 0x06005F4B RID: 24395 RVA: 0x00033E37 File Offset: 0x00032037
		public unsafe Il2CppReferenceArray<PartnerInfoBase> partnerInfoCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoProfile.NativeFieldInfoPtr_partnerInfoCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PartnerInfoBase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoProfile.NativeFieldInfoPtr_partnerInfoCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003F06 RID: 16134
		private static readonly IntPtr NativeFieldInfoPtr_partnerInfoCollection;

		// Token: 0x04003F07 RID: 16135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
