using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200010A RID: 266
	[Serializable]
	public class RarityDataMappingForDuration : RarityDataMapping
	{
		// Token: 0x06001D2E RID: 7470 RVA: 0x00100628 File Offset: 0x000FE828
		// Note: this type is marked as 'beforefieldinit'.
		static RarityDataMappingForDuration()
		{
			Il2CppClassPointerStore<RarityDataMappingForDuration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RarityDataMappingForDuration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RarityDataMappingForDuration>.NativeClassPtr);
			RarityDataMappingForDuration.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RarityDataMappingForDuration>.NativeClassPtr, "Duration");
			RarityDataMappingForDuration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RarityDataMappingForDuration>.NativeClassPtr, 100668545);
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00100680 File Offset: 0x000FE880
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RarityDataMappingForDuration() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RarityDataMappingForDuration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RarityDataMappingForDuration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00011A3F File Offset: 0x0000FC3F
		public RarityDataMappingForDuration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x001006BC File Offset: 0x000FE8BC
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x00011A48 File Offset: 0x0000FC48
		public unsafe int Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RarityDataMappingForDuration.NativeFieldInfoPtr_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RarityDataMappingForDuration.NativeFieldInfoPtr_Duration)) = value;
			}
		}

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeFieldInfoPtr_Duration;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
