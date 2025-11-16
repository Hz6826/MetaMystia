using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace GameData.Profile
{
	// Token: 0x02000309 RID: 777
	public class SuspiciousSeries : CookerAssetBase
	{
		// Token: 0x06005D05 RID: 23813 RVA: 0x00032C46 File Offset: 0x00030E46
		// Note: this type is marked as 'beforefieldinit'.
		static SuspiciousSeries()
		{
			Il2CppClassPointerStore<SuspiciousSeries>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "SuspiciousSeries");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SuspiciousSeries>.NativeClassPtr);
			SuspiciousSeries.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuspiciousSeries>.NativeClassPtr, 100682484);
		}

		// Token: 0x06005D06 RID: 23814 RVA: 0x001D3F8C File Offset: 0x001D218C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SuspiciousSeries() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SuspiciousSeries>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SuspiciousSeries.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D07 RID: 23815 RVA: 0x00032C7F File Offset: 0x00030E7F
		public SuspiciousSeries(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003D96 RID: 15766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
