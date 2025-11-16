using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002C3 RID: 707
	public class BadgeProfile : ScriptableObject
	{
		// Token: 0x06005834 RID: 22580 RVA: 0x001C7E54 File Offset: 0x001C6054
		// Note: this type is marked as 'beforefieldinit'.
		static BadgeProfile()
		{
			Il2CppClassPointerStore<BadgeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "BadgeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BadgeProfile>.NativeClassPtr);
			BadgeProfile.NativeFieldInfoPtr_badges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BadgeProfile>.NativeClassPtr, "badges");
			BadgeProfile.NativeFieldInfoPtr_previewName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BadgeProfile>.NativeClassPtr, "previewName");
			BadgeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BadgeProfile>.NativeClassPtr, 100681242);
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x001C7EC0 File Offset: 0x001C60C0
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BadgeProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BadgeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BadgeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x0002F44C File Offset: 0x0002D64C
		public BadgeProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x06005837 RID: 22583 RVA: 0x001C7EFC File Offset: 0x001C60FC
		// (set) Token: 0x06005838 RID: 22584 RVA: 0x0002F455 File Offset: 0x0002D655
		public unsafe Il2CppReferenceArray<Badge> badges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BadgeProfile.NativeFieldInfoPtr_badges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Badge>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BadgeProfile.NativeFieldInfoPtr_badges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x06005839 RID: 22585 RVA: 0x001C7F2C File Offset: 0x001C612C
		// (set) Token: 0x0600583A RID: 22586 RVA: 0x0002F474 File Offset: 0x0002D674
		public unsafe string previewName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BadgeProfile.NativeFieldInfoPtr_previewName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BadgeProfile.NativeFieldInfoPtr_previewName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003B1C RID: 15132
		private static readonly IntPtr NativeFieldInfoPtr_badges;

		// Token: 0x04003B1D RID: 15133
		private static readonly IntPtr NativeFieldInfoPtr_previewName;

		// Token: 0x04003B1E RID: 15134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
