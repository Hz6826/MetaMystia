using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002D7 RID: 727
	public class IndexProfile : ScriptableObject
	{
		// Token: 0x0600598F RID: 22927 RVA: 0x001CB210 File Offset: 0x001C9410
		// Note: this type is marked as 'beforefieldinit'.
		static IndexProfile()
		{
			Il2CppClassPointerStore<IndexProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "IndexProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexProfile>.NativeClassPtr);
			IndexProfile.NativeFieldInfoPtr_indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexProfile>.NativeClassPtr, "indexes");
			IndexProfile.NativeFieldInfoPtr_previewName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexProfile>.NativeClassPtr, "previewName");
			IndexProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexProfile>.NativeClassPtr, 100681350);
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x001CB27C File Offset: 0x001C947C
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x00030557 File Offset: 0x0002E757
		public IndexProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x06005992 RID: 22930 RVA: 0x001CB2B8 File Offset: 0x001C94B8
		// (set) Token: 0x06005993 RID: 22931 RVA: 0x00030560 File Offset: 0x0002E760
		public unsafe Il2CppStructArray<int> indexes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexProfile.NativeFieldInfoPtr_indexes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexProfile.NativeFieldInfoPtr_indexes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x06005994 RID: 22932 RVA: 0x001CB2E8 File Offset: 0x001C94E8
		// (set) Token: 0x06005995 RID: 22933 RVA: 0x0003057F File Offset: 0x0002E77F
		public unsafe string previewName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexProfile.NativeFieldInfoPtr_previewName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexProfile.NativeFieldInfoPtr_previewName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003BC7 RID: 15303
		private static readonly IntPtr NativeFieldInfoPtr_indexes;

		// Token: 0x04003BC8 RID: 15304
		private static readonly IntPtr NativeFieldInfoPtr_previewName;

		// Token: 0x04003BC9 RID: 15305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
