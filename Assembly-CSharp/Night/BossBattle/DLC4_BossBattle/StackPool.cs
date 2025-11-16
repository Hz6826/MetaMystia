using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Pool;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020000A0 RID: 160
	public static class StackPool<T> : Object
	{
		// Token: 0x060010A1 RID: 4257 RVA: 0x000D6D20 File Offset: 0x000D4F20
		// Note: this type is marked as 'beforefieldinit'.
		static StackPool()
		{
			Il2CppClassPointerStore<StackPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "StackPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackPool<T>>.NativeClassPtr);
			StackPool<T>.NativeFieldInfoPtr_s_StackPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackPool<T>>.NativeClassPtr, "s_StackPool");
			StackPool<T>.NativeMethodInfoPtr_Get_Public_Static_Stack_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackPool<T>>.NativeClassPtr, 100666225);
			StackPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_Stack_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackPool<T>>.NativeClassPtr, 100666226);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x000D6DC8 File Offset: 0x000D4FC8
		[CallerCount(102)]
		[CachedScanResults(RefRangeStart = 49366, RefRangeEnd = 49468, XrefRangeStart = 49358, XrefRangeEnd = 49366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stack<T> Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackPool<T>.NativeMethodInfoPtr_Get_Public_Static_Stack_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stack<T>>(intPtr3) : null;
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x000D6DFC File Offset: 0x000D4FFC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 49506, RefRangeEnd = 49516, XrefRangeStart = 49468, XrefRangeEnd = 49506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(Stack<T> toRelease)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackPool<T>.NativeMethodInfoPtr_Release_Public_Static_Void_Stack_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0000A8D0 File Offset: 0x00008AD0
		public StackPool(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x000D6E34 File Offset: 0x000D5034
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x0000A8D9 File Offset: 0x00008AD9
		public unsafe static ObjectPool<Stack<T>> s_StackPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StackPool<T>.NativeFieldInfoPtr_s_StackPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<Stack<T>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackPool<T>.NativeFieldInfoPtr_s_StackPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeFieldInfoPtr_s_StackPool;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Stack_1_T_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_Stack_1_T_0;

		// Token: 0x02000593 RID: 1427
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.StackPool`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06008ACA RID: 35530 RVA: 0x00264D08 File Offset: 0x00262F08
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StackPool<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StackPool<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackPool<T>.__c>.NativeClassPtr);
				StackPool<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackPool<T>.__c>.NativeClassPtr, "<>9");
				StackPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackPool<T>.__c>.NativeClassPtr, 100666229);
				StackPool<T>.__c.NativeMethodInfoPtr___cctor_b__3_0_Internal_Stack_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackPool<T>.__c>.NativeClassPtr, 100666230);
				StackPool<T>.__c.NativeMethodInfoPtr___cctor_b__3_1_Internal_Void_Stack_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackPool<T>.__c>.NativeClassPtr, 100666231);
			}

			// Token: 0x06008ACB RID: 35531 RVA: 0x00264DC0 File Offset: 0x00262FC0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackPool<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackPool<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008ACC RID: 35532 RVA: 0x00264DFC File Offset: 0x00262FFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49355, XrefRangeEnd = 49357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Stack<T> __cctor_b__3_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackPool<T>.__c.NativeMethodInfoPtr___cctor_b__3_0_Internal_Stack_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stack<T>>(intPtr3) : null;
			}

			// Token: 0x06008ACD RID: 35533 RVA: 0x00264E3C File Offset: 0x0026303C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49357, XrefRangeEnd = 49358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__3_1(Stack<T> l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackPool<T>.__c.NativeMethodInfoPtr___cctor_b__3_1_Internal_Void_Stack_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008ACE RID: 35534 RVA: 0x0004A95B File Offset: 0x00048B5B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E7E RID: 11902
			// (get) Token: 0x06008ACF RID: 35535 RVA: 0x00264E80 File Offset: 0x00263080
			// (set) Token: 0x06008AD0 RID: 35536 RVA: 0x0004A964 File Offset: 0x00048B64
			public unsafe static StackPool<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StackPool<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StackPool<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StackPool<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005AE8 RID: 23272
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005AE9 RID: 23273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005AEA RID: 23274
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__3_0_Internal_Stack_1_T_0;

			// Token: 0x04005AEB RID: 23275
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__3_1_Internal_Void_Stack_1_T_0;
		}
	}
}
