using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Common.UI.Filter
{
	// Token: 0x020003A7 RID: 935
	public static class StringBuilderShared : Object
	{
		// Token: 0x060070FF RID: 28927 RVA: 0x002167B0 File Offset: 0x002149B0
		// Note: this type is marked as 'beforefieldinit'.
		static StringBuilderShared()
		{
			Il2CppClassPointerStore<StringBuilderShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "StringBuilderShared");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringBuilderShared>.NativeClassPtr);
			StringBuilderShared.NativeFieldInfoPtr__StringBuilder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilderShared>.NativeClassPtr, "<StringBuilder>k__BackingField");
			StringBuilderShared.NativeMethodInfoPtr_get_StringBuilder_Internal_Static_get_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderShared>.NativeClassPtr, 100686332);
		}

		// Token: 0x170026C3 RID: 9923
		// (get) Token: 0x06007100 RID: 28928 RVA: 0x00216808 File Offset: 0x00214A08
		public unsafe static StringBuilder StringBuilder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281909, XrefRangeEnd = 281913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderShared.NativeMethodInfoPtr_get_StringBuilder_Internal_Static_get_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x0003D66E File Offset: 0x0003B86E
		public StringBuilderShared(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026C2 RID: 9922
		// (get) Token: 0x06007102 RID: 28930 RVA: 0x0021683C File Offset: 0x00214A3C
		// (set) Token: 0x06007103 RID: 28931 RVA: 0x0003D677 File Offset: 0x0003B877
		public unsafe static StringBuilder _StringBuilder_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringBuilderShared.NativeFieldInfoPtr__StringBuilder_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilderShared.NativeFieldInfoPtr__StringBuilder_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004AD4 RID: 19156
		private static readonly IntPtr NativeFieldInfoPtr__StringBuilder_k__BackingField;

		// Token: 0x04004AD5 RID: 19157
		private static readonly IntPtr NativeMethodInfoPtr_get_StringBuilder_Internal_Static_get_StringBuilder_0;
	}
}
