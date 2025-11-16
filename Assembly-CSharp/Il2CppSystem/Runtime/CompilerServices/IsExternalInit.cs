using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000019 RID: 25
	public class IsExternalInit : Object
	{
		// Token: 0x060001DD RID: 477 RVA: 0x00002F06 File Offset: 0x00001106
		// Note: this type is marked as 'beforefieldinit'.
		static IsExternalInit()
		{
			Il2CppClassPointerStore<IsExternalInit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "System.Runtime.CompilerServices", "IsExternalInit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsExternalInit>.NativeClassPtr);
			IsExternalInit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsExternalInit>.NativeClassPtr, 100663562);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000A5180 File Offset: 0x000A3380
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IsExternalInit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsExternalInit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsExternalInit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002F3F File Offset: 0x0000113F
		public IsExternalInit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
