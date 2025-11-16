using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002EC RID: 748
	public class SellableProfile : ScriptableObject
	{
		// Token: 0x06005A3A RID: 23098 RVA: 0x001CCD80 File Offset: 0x001CAF80
		// Note: this type is marked as 'beforefieldinit'.
		static SellableProfile()
		{
			Il2CppClassPointerStore<SellableProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "SellableProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SellableProfile>.NativeClassPtr);
			SellableProfile.NativeFieldInfoPtr_sellables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableProfile>.NativeClassPtr, "sellables");
			SellableProfile.NativeFieldInfoPtr_tagProfileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableProfile>.NativeClassPtr, "tagProfileName");
			SellableProfile.NativeFieldInfoPtr_langFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SellableProfile>.NativeClassPtr, "langFileName");
			SellableProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SellableProfile>.NativeClassPtr, 100681426);
		}

		// Token: 0x06005A3B RID: 23099 RVA: 0x001CCE00 File Offset: 0x001CB000
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SellableProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SellableProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SellableProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A3C RID: 23100 RVA: 0x00030BE8 File Offset: 0x0002EDE8
		public SellableProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x06005A3D RID: 23101 RVA: 0x001CCE3C File Offset: 0x001CB03C
		// (set) Token: 0x06005A3E RID: 23102 RVA: 0x00030BF1 File Offset: 0x0002EDF1
		public unsafe Il2CppReferenceArray<Sellable> sellables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableProfile.NativeFieldInfoPtr_sellables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableProfile.NativeFieldInfoPtr_sellables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x06005A3F RID: 23103 RVA: 0x001CCE6C File Offset: 0x001CB06C
		// (set) Token: 0x06005A40 RID: 23104 RVA: 0x00030C10 File Offset: 0x0002EE10
		public unsafe string tagProfileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableProfile.NativeFieldInfoPtr_tagProfileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableProfile.NativeFieldInfoPtr_tagProfileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x06005A41 RID: 23105 RVA: 0x001CCE94 File Offset: 0x001CB094
		// (set) Token: 0x06005A42 RID: 23106 RVA: 0x00030C2F File Offset: 0x0002EE2F
		public unsafe string langFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableProfile.NativeFieldInfoPtr_langFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SellableProfile.NativeFieldInfoPtr_langFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003C18 RID: 15384
		private static readonly IntPtr NativeFieldInfoPtr_sellables;

		// Token: 0x04003C19 RID: 15385
		private static readonly IntPtr NativeFieldInfoPtr_tagProfileName;

		// Token: 0x04003C1A RID: 15386
		private static readonly IntPtr NativeFieldInfoPtr_langFileName;

		// Token: 0x04003C1B RID: 15387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
