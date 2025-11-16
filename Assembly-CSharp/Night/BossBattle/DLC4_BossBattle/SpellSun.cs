using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200008E RID: 142
	[Serializable]
	public class SpellSun : PatchouliSpellBase
	{
		// Token: 0x06000DBE RID: 3518 RVA: 0x00009323 File Offset: 0x00007523
		// Note: this type is marked as 'beforefieldinit'.
		static SpellSun()
		{
			Il2CppClassPointerStore<SpellSun>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "SpellSun");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellSun>.NativeClassPtr);
			SpellSun.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSun>.NativeClassPtr, 100665576);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x000CC17C File Offset: 0x000CA37C
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpellSun() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellSun>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpellSun.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0000935C File Offset: 0x0000755C
		public SpellSun(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
