using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002EE RID: 750
	public class SpriteProfile : ScriptableObject
	{
		// Token: 0x06005A4A RID: 23114 RVA: 0x001CCFC4 File Offset: 0x001CB1C4
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteProfile()
		{
			Il2CppClassPointerStore<SpriteProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "SpriteProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteProfile>.NativeClassPtr);
			SpriteProfile.NativeFieldInfoPtr_pictures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteProfile>.NativeClassPtr, "pictures");
			SpriteProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteProfile>.NativeClassPtr, 100681428);
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x001CD01C File Offset: 0x001CB21C
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x00030C95 File Offset: 0x0002EE95
		public SpriteProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x06005A4D RID: 23117 RVA: 0x001CD058 File Offset: 0x001CB258
		// (set) Token: 0x06005A4E RID: 23118 RVA: 0x00030C9E File Offset: 0x0002EE9E
		public unsafe Il2CppReferenceArray<Sprite> pictures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteProfile.NativeFieldInfoPtr_pictures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteProfile.NativeFieldInfoPtr_pictures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C1F RID: 15391
		private static readonly IntPtr NativeFieldInfoPtr_pictures;

		// Token: 0x04003C20 RID: 15392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
