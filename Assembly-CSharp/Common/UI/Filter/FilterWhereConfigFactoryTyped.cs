using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Common.UI.Filter
{
	// Token: 0x020003B1 RID: 945
	public class FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType> : FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>
	{
		// Token: 0x06007142 RID: 28994 RVA: 0x00217DF0 File Offset: 0x00215FF0
		// Note: this type is marked as 'beforefieldinit'.
		static FilterWhereConfigFactoryTyped()
		{
			Il2CppClassPointerStore<FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "FilterWhereConfigFactoryTyped`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrderingType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSelectionType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr);
			FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr, 100686403);
			FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr, 100686404);
			FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Abstract_Virtual_New_WhereFilterConfig_1_TOrderingType_TSelectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr, 100686405);
			FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_Final_BaseFilterConfig_IReadOnlyList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr, 100686406);
			FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr, 100686407);
		}

		// Token: 0x170026D1 RID: 9937
		// (get) Token: 0x06007143 RID: 28995 RVA: 0x00217ED4 File Offset: 0x002160D4
		public unsafe override FilterType FilterType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026D2 RID: 9938
		// (get) Token: 0x06007144 RID: 28996 RVA: 0x00217F10 File Offset: 0x00216110
		public unsafe override uint ColumnCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007145 RID: 28997 RVA: 0x00217F4C File Offset: 0x0021614C
		[CallerCount(0)]
		public unsafe virtual WhereFilterConfig<TOrderingType> CreateFilterConfig(TSelectionType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TSelectionType).IsValueType)
			{
				TSelectionType tselectionType = value;
				intPtr = ((tselectionType is string) ? IL2CPP.ManagedStringToIl2Cpp(tselectionType as string) : IL2CPP.Il2CppObjectBaseToPtr(tselectionType as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Abstract_Virtual_New_WhereFilterConfig_1_TOrderingType_TSelectionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<WhereFilterConfig<TOrderingType>>(intPtr4) : null;
		}

		// Token: 0x06007146 RID: 28998 RVA: 0x00217FE0 File Offset: 0x002161E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282069, XrefRangeEnd = 282077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BaseFilterConfig CreateFilterConfig(IReadOnlyList<Object> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_Final_BaseFilterConfig_IReadOnlyList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseFilterConfig>(intPtr3) : null;
		}

		// Token: 0x06007147 RID: 28999 RVA: 0x00218030 File Offset: 0x00216230
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 282077, RefRangeEnd = 282095, XrefRangeStart = 282077, XrefRangeEnd = 282077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterWhereConfigFactoryTyped(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectionPriorityWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterWhereConfigFactoryTyped<TOrderingType, TSelectionType>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007148 RID: 29000 RVA: 0x0003D70B File Offset: 0x0003B90B
		public FilterWhereConfigFactoryTyped(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004B05 RID: 19205
		private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0;

		// Token: 0x04004B06 RID: 19206
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_Final_get_UInt32_0;

		// Token: 0x04004B07 RID: 19207
		private static readonly IntPtr NativeMethodInfoPtr_CreateFilterConfig_Protected_Abstract_Virtual_New_WhereFilterConfig_1_TOrderingType_TSelectionType_0;

		// Token: 0x04004B08 RID: 19208
		private static readonly IntPtr NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_Final_BaseFilterConfig_IReadOnlyList_1_Object_0;

		// Token: 0x04004B09 RID: 19209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;
	}
}
