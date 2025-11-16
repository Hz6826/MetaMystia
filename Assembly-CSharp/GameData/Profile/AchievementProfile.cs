using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002C2 RID: 706
	public class AchievementProfile : ScriptableObject
	{
		// Token: 0x0600582F RID: 22575 RVA: 0x001C7D90 File Offset: 0x001C5F90
		// Note: this type is marked as 'beforefieldinit'.
		static AchievementProfile()
		{
			Il2CppClassPointerStore<AchievementProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "AchievementProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementProfile>.NativeClassPtr);
			AchievementProfile.NativeFieldInfoPtr_Achievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementProfile>.NativeClassPtr, "Achievements");
			AchievementProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementProfile>.NativeClassPtr, 100681241);
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x001C7DE8 File Offset: 0x001C5FE8
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AchievementProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x0002F424 File Offset: 0x0002D624
		public AchievementProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x06005832 RID: 22578 RVA: 0x001C7E24 File Offset: 0x001C6024
		// (set) Token: 0x06005833 RID: 22579 RVA: 0x0002F42D File Offset: 0x0002D62D
		public unsafe Il2CppReferenceArray<AchievementData> Achievements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementProfile.NativeFieldInfoPtr_Achievements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AchievementData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AchievementProfile.NativeFieldInfoPtr_Achievements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B1A RID: 15130
		private static readonly IntPtr NativeFieldInfoPtr_Achievements;

		// Token: 0x04003B1B RID: 15131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
