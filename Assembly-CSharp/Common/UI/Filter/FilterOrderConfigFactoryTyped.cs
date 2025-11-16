using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Common.UI.Filter
{
	// Token: 0x020003B3 RID: 947
	public class FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType> : FilterConfigFactoryTypedBase<TOrderingType, Order>
	{
		// Token: 0x0600714F RID: 29007 RVA: 0x00218120 File Offset: 0x00216320
		// Note: this type is marked as 'beforefieldinit'.
		static FilterOrderConfigFactoryTyped()
		{
			Il2CppClassPointerStore<FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "FilterOrderConfigFactoryTyped`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrderingType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFocusingType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>>.NativeClassPtr);
			FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>.NativeMethodInfoPtr_get_InvertSelection_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>>.NativeClassPtr, 100686409);
			FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>>.NativeClassPtr, 100686410);
			FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_Final_IEnumerable_1_Order_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>>.NativeClassPtr, 100686411);
			FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Abstract_Virtual_New_OrderFilterConfig_2_TOrderingType_TFocusingType_Order_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>>.NativeClassPtr, 100686412);
			FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_Final_BaseFilterConfig_IReadOnlyList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>>.NativeClassPtr, 100686413);
			FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>>.NativeClassPtr, 100686414);
		}

		// Token: 0x170026D5 RID: 9941
		// (get) Token: 0x06007150 RID: 29008 RVA: 0x00218218 File Offset: 0x00216418
		public unsafe virtual bool InvertSelection
		{
			[CallerCount(299)]
			[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>.NativeMethodInfoPtr_get_InvertSelection_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026D6 RID: 9942
		// (get) Token: 0x06007151 RID: 29009 RVA: 0x00218260 File Offset: 0x00216460
		public unsafe override FilterType FilterType
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007152 RID: 29010 RVA: 0x0021829C File Offset: 0x0021649C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282095, XrefRangeEnd = 282099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Order> GetSelectionsTyped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_Final_IEnumerable_1_Order_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Order>>(intPtr3) : null;
		}

		// Token: 0x06007153 RID: 29011 RVA: 0x002182DC File Offset: 0x002164DC
		[CallerCount(0)]
		public unsafe virtual OrderFilterConfig<TOrderingType, TFocusingType> CreateFilterConfig(Order value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Abstract_Virtual_New_OrderFilterConfig_2_TOrderingType_TFocusingType_Order_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OrderFilterConfig<TOrderingType, TFocusingType>>(intPtr3) : null;
		}

		// Token: 0x06007154 RID: 29012 RVA: 0x00218334 File Offset: 0x00216534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282099, XrefRangeEnd = 282119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BaseFilterConfig CreateFilterConfig(IReadOnlyList<Object> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_Final_BaseFilterConfig_IReadOnlyList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseFilterConfig>(intPtr3) : null;
		}

		// Token: 0x06007155 RID: 29013 RVA: 0x00218384 File Offset: 0x00216584
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 282077, RefRangeEnd = 282095, XrefRangeStart = 282077, XrefRangeEnd = 282095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterOrderConfigFactoryTyped(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectionPriorityWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterOrderConfigFactoryTyped<TOrderingType, TFocusingType>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007156 RID: 29014 RVA: 0x0003D741 File Offset: 0x0003B941
		public FilterOrderConfigFactoryTyped(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004B0C RID: 19212
		private static readonly IntPtr NativeMethodInfoPtr_get_InvertSelection_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04004B0D RID: 19213
		private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_FilterType_0;

		// Token: 0x04004B0E RID: 19214
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionsTyped_Protected_Virtual_Final_IEnumerable_1_Order_0;

		// Token: 0x04004B0F RID: 19215
		private static readonly IntPtr NativeMethodInfoPtr_CreateFilterConfig_Protected_Abstract_Virtual_New_OrderFilterConfig_2_TOrderingType_TFocusingType_Order_0;

		// Token: 0x04004B10 RID: 19216
		private static readonly IntPtr NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_Final_BaseFilterConfig_IReadOnlyList_1_Object_0;

		// Token: 0x04004B11 RID: 19217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;
	}
}
