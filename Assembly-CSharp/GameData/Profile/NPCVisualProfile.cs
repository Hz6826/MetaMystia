using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002E5 RID: 741
	public class NPCVisualProfile : ScriptableObject
	{
		// Token: 0x060059F1 RID: 23025 RVA: 0x001CC070 File Offset: 0x001CA270
		// Note: this type is marked as 'beforefieldinit'.
		static NPCVisualProfile()
		{
			Il2CppClassPointerStore<NPCVisualProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "NPCVisualProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCVisualProfile>.NativeClassPtr);
			NPCVisualProfile.NativeFieldInfoPtr_characterPortrayals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCVisualProfile>.NativeClassPtr, "characterPortrayals");
			NPCVisualProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCVisualProfile>.NativeClassPtr, 100681393);
		}

		// Token: 0x060059F2 RID: 23026 RVA: 0x001CC0C8 File Offset: 0x001CA2C8
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCVisualProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCVisualProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCVisualProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059F3 RID: 23027 RVA: 0x0003094D File Offset: 0x0002EB4D
		public NPCVisualProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x060059F4 RID: 23028 RVA: 0x001CC104 File Offset: 0x001CA304
		// (set) Token: 0x060059F5 RID: 23029 RVA: 0x00030956 File Offset: 0x0002EB56
		public unsafe Il2CppReferenceArray<GuestProfilePair> characterPortrayals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCVisualProfile.NativeFieldInfoPtr_characterPortrayals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GuestProfilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCVisualProfile.NativeFieldInfoPtr_characterPortrayals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BF1 RID: 15345
		private static readonly IntPtr NativeFieldInfoPtr_characterPortrayals;

		// Token: 0x04003BF2 RID: 15346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
