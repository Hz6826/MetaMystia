using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Common.Utils
{
	// Token: 0x0200034F RID: 847
	public static class AOTLinker : Object
	{
		// Token: 0x0600645B RID: 25691 RVA: 0x000364D6 File Offset: 0x000346D6
		// Note: this type is marked as 'beforefieldinit'.
		static AOTLinker()
		{
			Il2CppClassPointerStore<AOTLinker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.Utils", "AOTLinker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AOTLinker>.NativeClassPtr);
			AOTLinker.NativeMethodInfoPtr_AOT_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AOTLinker>.NativeClassPtr, 100684296);
		}

		// Token: 0x0600645C RID: 25692 RVA: 0x001ED8A4 File Offset: 0x001EBAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257770, XrefRangeEnd = 258163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AOT()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AOTLinker.NativeMethodInfoPtr_AOT_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600645D RID: 25693 RVA: 0x0003650F File Offset: 0x0003470F
		public AOTLinker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004288 RID: 17032
		private static readonly IntPtr NativeMethodInfoPtr_AOT_Public_Static_Void_0;

		// Token: 0x02000E05 RID: 3589
		[ObfuscatedName("Common.Utils.AOTLinker+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060102E6 RID: 66278 RVA: 0x003C5B64 File Offset: 0x003C3D64
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AOTLinker.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AOTLinker>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AOTLinker.__c>.NativeClassPtr);
				AOTLinker.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AOTLinker.__c>.NativeClassPtr, "<>9");
				AOTLinker.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AOTLinker.__c>.NativeClassPtr, "<>9__0_0");
				AOTLinker.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AOTLinker.__c>.NativeClassPtr, "<>9__0_1");
				AOTLinker.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AOTLinker.__c>.NativeClassPtr, 100684298);
				AOTLinker.__c.NativeMethodInfoPtr__AOT_b__0_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AOTLinker.__c>.NativeClassPtr, 100684299);
				AOTLinker.__c.NativeMethodInfoPtr__AOT_b__0_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AOTLinker.__c>.NativeClassPtr, 100684300);
			}

			// Token: 0x060102E7 RID: 66279 RVA: 0x003C5C08 File Offset: 0x003C3E08
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AOTLinker.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AOTLinker.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060102E8 RID: 66280 RVA: 0x003C5C44 File Offset: 0x003C3E44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257764, XrefRangeEnd = 257767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AOT_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AOTLinker.__c.NativeMethodInfoPtr__AOT_b__0_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060102E9 RID: 66281 RVA: 0x003C5C78 File Offset: 0x003C3E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257767, XrefRangeEnd = 257770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AOT_b__0_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AOTLinker.__c.NativeMethodInfoPtr__AOT_b__0_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060102EA RID: 66282 RVA: 0x0008CD48 File Offset: 0x0008AF48
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700549C RID: 21660
			// (get) Token: 0x060102EB RID: 66283 RVA: 0x003C5CAC File Offset: 0x003C3EAC
			// (set) Token: 0x060102EC RID: 66284 RVA: 0x0008CD51 File Offset: 0x0008AF51
			public unsafe static AOTLinker.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AOTLinker.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AOTLinker.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AOTLinker.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700549D RID: 21661
			// (get) Token: 0x060102ED RID: 66285 RVA: 0x003C5CD4 File Offset: 0x003C3ED4
			// (set) Token: 0x060102EE RID: 66286 RVA: 0x0008CD63 File Offset: 0x0008AF63
			public unsafe static Action __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AOTLinker.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AOTLinker.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700549E RID: 21662
			// (get) Token: 0x060102EF RID: 66287 RVA: 0x003C5CFC File Offset: 0x003C3EFC
			// (set) Token: 0x060102F0 RID: 66288 RVA: 0x0008CD75 File Offset: 0x0008AF75
			public unsafe static Action __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AOTLinker.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AOTLinker.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A437 RID: 42039
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A438 RID: 42040
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x0400A439 RID: 42041
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x0400A43A RID: 42042
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A43B RID: 42043
			private static readonly IntPtr NativeMethodInfoPtr__AOT_b__0_0_Internal_Void_0;

			// Token: 0x0400A43C RID: 42044
			private static readonly IntPtr NativeMethodInfoPtr__AOT_b__0_1_Internal_Void_0;
		}
	}
}
