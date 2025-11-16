using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Common.UI.Filter
{
	// Token: 0x020003B9 RID: 953
	public static class FilterHelper : Object
	{
		// Token: 0x06007180 RID: 29056 RVA: 0x00218F80 File Offset: 0x00217180
		// Note: this type is marked as 'beforefieldinit'.
		static FilterHelper()
		{
			Il2CppClassPointerStore<FilterHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "FilterHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterHelper>.NativeClassPtr);
			FilterHelper.NativeFieldInfoPtr_s_OrderQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterHelper>.NativeClassPtr, "s_OrderQueue");
			FilterHelper.NativeMethodInfoPtr_ExecuteFilterWithDelegation_Public_Static_IEnumerable_1_TSrcObject_IReadOnlyList_1_IFilterConfig_IEnumerable_1_TSrcObject_Func_2_TSrcObject_TOrderingObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterHelper>.NativeClassPtr, 100686441);
			FilterHelper.NativeMethodInfoPtr_ExecuteFilter_Public_Static_IEnumerable_1_T_IReadOnlyList_1_IFilterConfig_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterHelper>.NativeClassPtr, 100686442);
		}

		// Token: 0x06007181 RID: 29057 RVA: 0x00218FEC File Offset: 0x002171EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 282244, RefRangeEnd = 282251, XrefRangeStart = 282202, XrefRangeEnd = 282244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSrcObject> ExecuteFilterWithDelegation<TSrcObject, TOrderingObject>(this IReadOnlyList<IFilterConfig> configs, IEnumerable<TSrcObject> objects, Func<TSrcObject, TOrderingObject> conversionHandler)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversionHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterHelper.MethodInfoStoreGeneric_ExecuteFilterWithDelegation_Public_Static_IEnumerable_1_TSrcObject_IReadOnlyList_1_IFilterConfig_IEnumerable_1_TSrcObject_Func_2_TSrcObject_TOrderingObject_0<TSrcObject, TOrderingObject>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSrcObject>>(intPtr3) : null;
		}

		// Token: 0x06007182 RID: 29058 RVA: 0x00219054 File Offset: 0x00217254
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 282319, RefRangeEnd = 282326, XrefRangeStart = 282251, XrefRangeEnd = 282319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<T> ExecuteFilter<T>(this IReadOnlyList<IFilterConfig> configs, IEnumerable<T> objects)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterHelper.MethodInfoStoreGeneric_ExecuteFilter_Public_Static_IEnumerable_1_T_IReadOnlyList_1_IFilterConfig_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06007183 RID: 29059 RVA: 0x0003D7D9 File Offset: 0x0003B9D9
		public FilterHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026E2 RID: 9954
		// (get) Token: 0x06007184 RID: 29060 RVA: 0x002190AC File Offset: 0x002172AC
		// (set) Token: 0x06007185 RID: 29061 RVA: 0x0003D7E2 File Offset: 0x0003B9E2
		public unsafe static Queue<IFilterConfig> s_OrderQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterHelper.NativeFieldInfoPtr_s_OrderQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterHelper.NativeFieldInfoPtr_s_OrderQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B32 RID: 19250
		private static readonly IntPtr NativeFieldInfoPtr_s_OrderQueue;

		// Token: 0x04004B33 RID: 19251
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteFilterWithDelegation_Public_Static_IEnumerable_1_TSrcObject_IReadOnlyList_1_IFilterConfig_IEnumerable_1_TSrcObject_Func_2_TSrcObject_TOrderingObject_0;

		// Token: 0x04004B34 RID: 19252
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteFilter_Public_Static_IEnumerable_1_T_IReadOnlyList_1_IFilterConfig_IEnumerable_1_T_0;

		// Token: 0x02000F05 RID: 3845
		private sealed class MethodInfoStoreGeneric_ExecuteFilterWithDelegation_Public_Static_IEnumerable_1_TSrcObject_IReadOnlyList_1_IFilterConfig_IEnumerable_1_TSrcObject_Func_2_TSrcObject_TOrderingObject_0<TSrcObject, TOrderingObject>
		{
			// Token: 0x0400AAC6 RID: 43718
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FilterHelper.NativeMethodInfoPtr_ExecuteFilterWithDelegation_Public_Static_IEnumerable_1_TSrcObject_IReadOnlyList_1_IFilterConfig_IEnumerable_1_TSrcObject_Func_2_TSrcObject_TOrderingObject_0, Il2CppClassPointerStore<FilterHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSrcObject>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrderingObject>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000F06 RID: 3846
		private sealed class MethodInfoStoreGeneric_ExecuteFilter_Public_Static_IEnumerable_1_T_IReadOnlyList_1_IFilterConfig_IEnumerable_1_T_0<T>
		{
			// Token: 0x0400AAC7 RID: 43719
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FilterHelper.NativeMethodInfoPtr_ExecuteFilter_Public_Static_IEnumerable_1_T_IReadOnlyList_1_IFilterConfig_IEnumerable_1_T_0, Il2CppClassPointerStore<FilterHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
