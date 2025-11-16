using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000E0 RID: 224
	[Serializable]
	public class RarityDataMappingForInstantHit : RarityDataMapping
	{
		// Token: 0x06001A91 RID: 6801 RVA: 0x000F6CE8 File Offset: 0x000F4EE8
		// Note: this type is marked as 'beforefieldinit'.
		static RarityDataMappingForInstantHit()
		{
			Il2CppClassPointerStore<RarityDataMappingForInstantHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RarityDataMappingForInstantHit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RarityDataMappingForInstantHit>.NativeClassPtr);
			RarityDataMappingForInstantHit.NativeFieldInfoPtr_giveIng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RarityDataMappingForInstantHit>.NativeClassPtr, "giveIng");
			RarityDataMappingForInstantHit.NativeFieldInfoPtr_giveBev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RarityDataMappingForInstantHit>.NativeClassPtr, "giveBev");
			RarityDataMappingForInstantHit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RarityDataMappingForInstantHit>.NativeClassPtr, 100668048);
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x000F6D54 File Offset: 0x000F4F54
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RarityDataMappingForInstantHit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RarityDataMappingForInstantHit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RarityDataMappingForInstantHit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00010700 File Offset: 0x0000E900
		public RarityDataMappingForInstantHit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x000F6D90 File Offset: 0x000F4F90
		// (set) Token: 0x06001A95 RID: 6805 RVA: 0x00010709 File Offset: 0x0000E909
		public unsafe int giveIng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RarityDataMappingForInstantHit.NativeFieldInfoPtr_giveIng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RarityDataMappingForInstantHit.NativeFieldInfoPtr_giveIng)) = value;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x000F6DB8 File Offset: 0x000F4FB8
		// (set) Token: 0x06001A97 RID: 6807 RVA: 0x00010724 File Offset: 0x0000E924
		public unsafe int giveBev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RarityDataMappingForInstantHit.NativeFieldInfoPtr_giveBev);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RarityDataMappingForInstantHit.NativeFieldInfoPtr_giveBev)) = value;
			}
		}

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeFieldInfoPtr_giveIng;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeFieldInfoPtr_giveBev;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
