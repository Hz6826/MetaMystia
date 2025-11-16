using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000109 RID: 265
	[Serializable]
	public class RarityDataMapping : Object
	{
		// Token: 0x06001D29 RID: 7465 RVA: 0x0010056C File Offset: 0x000FE76C
		// Note: this type is marked as 'beforefieldinit'.
		static RarityDataMapping()
		{
			Il2CppClassPointerStore<RarityDataMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RarityDataMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RarityDataMapping>.NativeClassPtr);
			RarityDataMapping.NativeFieldInfoPtr_Rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RarityDataMapping>.NativeClassPtr, "Rarity");
			RarityDataMapping.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RarityDataMapping>.NativeClassPtr, 100668544);
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x001005C4 File Offset: 0x000FE7C4
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RarityDataMapping() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RarityDataMapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RarityDataMapping.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x00011A1B File Offset: 0x0000FC1B
		public RarityDataMapping(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00100600 File Offset: 0x000FE800
		// (set) Token: 0x06001D2D RID: 7469 RVA: 0x00011A24 File Offset: 0x0000FC24
		public unsafe RogueLikeCardBase.Rarity Rarity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RarityDataMapping.NativeFieldInfoPtr_Rarity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RarityDataMapping.NativeFieldInfoPtr_Rarity)) = value;
			}
		}

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeFieldInfoPtr_Rarity;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
