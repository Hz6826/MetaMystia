using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200010B RID: 267
	[Serializable]
	public class RarityDataMappingForMultiplier : RarityDataMapping
	{
		// Token: 0x06001D33 RID: 7475 RVA: 0x001006E4 File Offset: 0x000FE8E4
		// Note: this type is marked as 'beforefieldinit'.
		static RarityDataMappingForMultiplier()
		{
			Il2CppClassPointerStore<RarityDataMappingForMultiplier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RarityDataMappingForMultiplier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RarityDataMappingForMultiplier>.NativeClassPtr);
			RarityDataMappingForMultiplier.NativeFieldInfoPtr_Multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RarityDataMappingForMultiplier>.NativeClassPtr, "Multiplier");
			RarityDataMappingForMultiplier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RarityDataMappingForMultiplier>.NativeClassPtr, 100668546);
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0010073C File Offset: 0x000FE93C
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RarityDataMappingForMultiplier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RarityDataMappingForMultiplier>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RarityDataMappingForMultiplier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x00011A63 File Offset: 0x0000FC63
		public RarityDataMappingForMultiplier(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x00100778 File Offset: 0x000FE978
		// (set) Token: 0x06001D37 RID: 7479 RVA: 0x00011A6C File Offset: 0x0000FC6C
		public unsafe float Multiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RarityDataMappingForMultiplier.NativeFieldInfoPtr_Multiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RarityDataMappingForMultiplier.NativeFieldInfoPtr_Multiplier)) = value;
			}
		}

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeFieldInfoPtr_Multiplier;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
