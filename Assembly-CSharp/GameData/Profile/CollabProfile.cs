using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002C9 RID: 713
	public class CollabProfile : ScriptableObject
	{
		// Token: 0x06005869 RID: 22633 RVA: 0x001C87B8 File Offset: 0x001C69B8
		// Note: this type is marked as 'beforefieldinit'.
		static CollabProfile()
		{
			Il2CppClassPointerStore<CollabProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "CollabProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollabProfile>.NativeClassPtr);
			CollabProfile.NativeFieldInfoPtr_collabPackages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabProfile>.NativeClassPtr, "collabPackages");
			CollabProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabProfile>.NativeClassPtr, 100681262);
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x001C8810 File Offset: 0x001C6A10
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollabProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollabProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x0002F628 File Offset: 0x0002D828
		public CollabProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x0600586C RID: 22636 RVA: 0x001C884C File Offset: 0x001C6A4C
		// (set) Token: 0x0600586D RID: 22637 RVA: 0x0002F631 File Offset: 0x0002D831
		public unsafe Il2CppReferenceArray<CollabPackage> collabPackages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabProfile.NativeFieldInfoPtr_collabPackages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CollabPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabProfile.NativeFieldInfoPtr_collabPackages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B37 RID: 15159
		private static readonly IntPtr NativeFieldInfoPtr_collabPackages;

		// Token: 0x04003B38 RID: 15160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
