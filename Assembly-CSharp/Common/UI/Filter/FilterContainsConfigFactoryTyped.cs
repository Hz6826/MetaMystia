using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Common.UI.Filter
{
	// Token: 0x020003B4 RID: 948
	public class FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType> : FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>
	{
		// Token: 0x06007157 RID: 29015 RVA: 0x002183CC File Offset: 0x002165CC
		// Note: this type is marked as 'beforefieldinit'.
		static FilterContainsConfigFactoryTyped()
		{
			Il2CppClassPointerStore<FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "FilterContainsConfigFactoryTyped`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrderingType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSelectionType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr);
			FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Abstract_Virtual_New_WhereFilterConfig_1_TOrderingType_IEnumerable_1_TSelectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr, 100686415);
			FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_Final_BaseFilterConfig_IReadOnlyList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr, 100686416);
			FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr, 100686417);
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x00218488 File Offset: 0x00216688
		[CallerCount(0)]
		public unsafe virtual WhereFilterConfig<TOrderingType> CreateFilterConfig(IEnumerable<TSelectionType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Abstract_Virtual_New_WhereFilterConfig_1_TOrderingType_IEnumerable_1_TSelectionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WhereFilterConfig<TOrderingType>>(intPtr3) : null;
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x002184E4 File Offset: 0x002166E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282119, XrefRangeEnd = 282135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BaseFilterConfig CreateFilterConfig(IReadOnlyList<Object> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_Final_BaseFilterConfig_IReadOnlyList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseFilterConfig>(intPtr3) : null;
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x00218534 File Offset: 0x00216734
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 282077, RefRangeEnd = 282095, XrefRangeStart = 282077, XrefRangeEnd = 282095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterContainsConfigFactoryTyped(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectionPriorityWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterContainsConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x0003D74A File Offset: 0x0003B94A
		public FilterContainsConfigFactoryTyped(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004B12 RID: 19218
		private static readonly IntPtr NativeMethodInfoPtr_CreateFilterConfig_Protected_Abstract_Virtual_New_WhereFilterConfig_1_TOrderingType_IEnumerable_1_TSelectionType_0;

		// Token: 0x04004B13 RID: 19219
		private static readonly IntPtr NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_Final_BaseFilterConfig_IReadOnlyList_1_Object_0;

		// Token: 0x04004B14 RID: 19220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;
	}
}
