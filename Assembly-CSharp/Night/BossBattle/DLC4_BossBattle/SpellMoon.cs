using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200008F RID: 143
	[Serializable]
	public class SpellMoon : PatchouliSpellBase
	{
		// Token: 0x06000DC1 RID: 3521 RVA: 0x00009365 File Offset: 0x00007565
		// Note: this type is marked as 'beforefieldinit'.
		static SpellMoon()
		{
			Il2CppClassPointerStore<SpellMoon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "SpellMoon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellMoon>.NativeClassPtr);
			SpellMoon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellMoon>.NativeClassPtr, 100665577);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x000CC1B8 File Offset: 0x000CA3B8
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpellMoon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellMoon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellMoon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0000939E File Offset: 0x0000759E
		public SpellMoon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
