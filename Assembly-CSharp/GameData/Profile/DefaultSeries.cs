using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace GameData.Profile
{
	// Token: 0x02000300 RID: 768
	public class DefaultSeries : CookerAssetBase
	{
		// Token: 0x06005CA1 RID: 23713 RVA: 0x00032906 File Offset: 0x00030B06
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultSeries()
		{
			Il2CppClassPointerStore<DefaultSeries>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DefaultSeries");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultSeries>.NativeClassPtr);
			DefaultSeries.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSeries>.NativeClassPtr, 100682434);
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x001D2BDC File Offset: 0x001D0DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultSeries() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultSeries>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultSeries.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x0003293F File Offset: 0x00030B3F
		public DefaultSeries(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003D5E RID: 15710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
