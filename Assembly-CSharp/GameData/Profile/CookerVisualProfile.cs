using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002CD RID: 717
	public class CookerVisualProfile : ScriptableObject
	{
		// Token: 0x06005885 RID: 22661 RVA: 0x001C8BD0 File Offset: 0x001C6DD0
		// Note: this type is marked as 'beforefieldinit'.
		static CookerVisualProfile()
		{
			Il2CppClassPointerStore<CookerVisualProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "CookerVisualProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookerVisualProfile>.NativeClassPtr);
			CookerVisualProfile.NativeFieldInfoPtr_tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookerVisualProfile>.NativeClassPtr, "tiles");
			CookerVisualProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerVisualProfile>.NativeClassPtr, 100681266);
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x001C8C28 File Offset: 0x001C6E28
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookerVisualProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookerVisualProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookerVisualProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005887 RID: 22663 RVA: 0x0002F744 File Offset: 0x0002D944
		public CookerVisualProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x06005888 RID: 22664 RVA: 0x001C8C64 File Offset: 0x001C6E64
		// (set) Token: 0x06005889 RID: 22665 RVA: 0x0002F74D File Offset: 0x0002D94D
		public unsafe Il2CppReferenceArray<VisualIdPair> tiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerVisualProfile.NativeFieldInfoPtr_tiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VisualIdPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerVisualProfile.NativeFieldInfoPtr_tiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B43 RID: 15171
		private static readonly IntPtr NativeFieldInfoPtr_tiles;

		// Token: 0x04003B44 RID: 15172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
