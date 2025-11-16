using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.AddressableAssets;

namespace MusicGame.UI
{
	// Token: 0x02000020 RID: 32
	[Serializable]
	public sealed class CheerGuestSpawnMode : ValueType
	{
		// Token: 0x0600028F RID: 655 RVA: 0x000A72B4 File Offset: 0x000A54B4
		// Note: this type is marked as 'beforefieldinit'.
		static CheerGuestSpawnMode()
		{
			Il2CppClassPointerStore<CheerGuestSpawnMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "CheerGuestSpawnMode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheerGuestSpawnMode>.NativeClassPtr);
			CheerGuestSpawnMode.NativeFieldInfoPtr_corner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheerGuestSpawnMode>.NativeClassPtr, "corner");
			CheerGuestSpawnMode.NativeFieldInfoPtr_cheerGuestImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheerGuestSpawnMode>.NativeClassPtr, "cheerGuestImage");
			CheerGuestSpawnMode.NativeMethodInfoPtr_get_Corner_Public_get_CornerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheerGuestSpawnMode>.NativeClassPtr, 100663682);
			CheerGuestSpawnMode.NativeMethodInfoPtr_get_CheerGuestImage_Public_get_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheerGuestSpawnMode>.NativeClassPtr, 100663683);
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000290 RID: 656 RVA: 0x000A7334 File Offset: 0x000A5534
		public unsafe CheerGuestSpawnMode.CornerType Corner
		{
			[CallerCount(140)]
			[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheerGuestSpawnMode.NativeMethodInfoPtr_get_Corner_Public_get_CornerType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000291 RID: 657 RVA: 0x000A7378 File Offset: 0x000A5578
		public unsafe AssetReference CheerGuestImage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheerGuestSpawnMode.NativeMethodInfoPtr_get_CheerGuestImage_Public_get_AssetReference_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00003573 File Offset: 0x00001773
		public CheerGuestSpawnMode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000357C File Offset: 0x0000177C
		public CheerGuestSpawnMode() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheerGuestSpawnMode>.NativeClassPtr))
		{
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000A73BC File Offset: 0x000A55BC
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0000358E File Offset: 0x0000178E
		public unsafe CheerGuestSpawnMode.CornerType corner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheerGuestSpawnMode.NativeFieldInfoPtr_corner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheerGuestSpawnMode.NativeFieldInfoPtr_corner)) = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000296 RID: 662 RVA: 0x000A73E4 File Offset: 0x000A55E4
		// (set) Token: 0x06000297 RID: 663 RVA: 0x000035A9 File Offset: 0x000017A9
		public unsafe AssetReference cheerGuestImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheerGuestSpawnMode.NativeFieldInfoPtr_cheerGuestImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheerGuestSpawnMode.NativeFieldInfoPtr_cheerGuestImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_corner;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr_cheerGuestImage;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_get_Corner_Public_get_CornerType_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_get_CheerGuestImage_Public_get_AssetReference_0;

		// Token: 0x0200048F RID: 1167
		public enum CornerType
		{
			// Token: 0x040052A2 RID: 21154
			RightBottom,
			// Token: 0x040052A3 RID: 21155
			LeftBottom,
			// Token: 0x040052A4 RID: 21156
			LeftTop,
			// Token: 0x040052A5 RID: 21157
			RightTop
		}
	}
}
