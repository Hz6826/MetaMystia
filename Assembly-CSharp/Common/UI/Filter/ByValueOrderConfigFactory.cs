using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Common.UI.Filter
{
	// Token: 0x020003AA RID: 938
	public class ByValueOrderConfigFactory<TFocusing, TOrdering> : FilterOrderConfigFactoryTyped<TOrdering, TFocusing>
	{
		// Token: 0x06007111 RID: 28945 RVA: 0x00216D88 File Offset: 0x00214F88
		// Note: this type is marked as 'beforefieldinit'.
		static ByValueOrderConfigFactory()
		{
			Il2CppClassPointerStore<ByValueOrderConfigFactory<TFocusing, TOrdering>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "ByValueOrderConfigFactory`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFocusing>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrdering>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByValueOrderConfigFactory<TFocusing, TOrdering>>.NativeClassPtr);
			ByValueOrderConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_GetFocusing_Protected_Abstract_Virtual_New_TFocusing_TOrdering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueOrderConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686359);
			ByValueOrderConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_OrderFilterConfig_2_TOrdering_TFocusing_Order_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueOrderConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686360);
			ByValueOrderConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueOrderConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686361);
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x00216E44 File Offset: 0x00215044
		[CallerCount(0)]
		public unsafe virtual TFocusing GetFocusing(TOrdering ordering)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TOrdering).IsValueType)
			{
				TOrdering tordering = ordering;
				intPtr = ((tordering is string) ? IL2CPP.ManagedStringToIl2Cpp(tordering as string) : IL2CPP.Il2CppObjectBaseToPtr(tordering as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref ordering;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByValueOrderConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_GetFocusing_Protected_Abstract_Virtual_New_TFocusing_TOrdering_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TFocusing>(intPtr2, false, true);
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x00216ED0 File Offset: 0x002150D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281983, XrefRangeEnd = 281985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override OrderFilterConfig<TOrdering, TFocusing> CreateFilterConfig(Order value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByValueOrderConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_OrderFilterConfig_2_TOrdering_TFocusing_Order_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OrderFilterConfig<TOrdering, TFocusing>>(intPtr3) : null;
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x00216F28 File Offset: 0x00215128
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 281971, RefRangeEnd = 281982, XrefRangeStart = 281971, XrefRangeEnd = 281982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByValueOrderConfigFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByValueOrderConfigFactory<TFocusing, TOrdering>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectionPriorityWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueOrderConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007115 RID: 28949 RVA: 0x0003D69B File Offset: 0x0003B89B
		public ByValueOrderConfigFactory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004ADF RID: 19167
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Abstract_Virtual_New_TFocusing_TOrdering_0;

		// Token: 0x04004AE0 RID: 19168
		private static readonly IntPtr NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_OrderFilterConfig_2_TOrdering_TFocusing_Order_0;

		// Token: 0x04004AE1 RID: 19169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;

		// Token: 0x02000F02 RID: 3842
		public class ByValueOrderConfig : OrderFilterConfig<TOrdering, TFocusing>
		{
			// Token: 0x06010DF7 RID: 69111 RVA: 0x003E6470 File Offset: 0x003E4670
			// Note: this type is marked as 'beforefieldinit'.
			static ByValueOrderConfig()
			{
				Il2CppClassPointerStore<ByValueOrderConfigFactory<TFocusing, TOrdering>.ByValueOrderConfig>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ByValueOrderConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, "ByValueOrderConfig"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFocusing>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrdering>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByValueOrderConfigFactory<TFocusing, TOrdering>.ByValueOrderConfig>.NativeClassPtr);
				ByValueOrderConfigFactory<TFocusing, TOrdering>.ByValueOrderConfig.NativeMethodInfoPtr__ctor_Public_Void_IFilterConfigFactory_Order_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueOrderConfigFactory<TFocusing, TOrdering>.ByValueOrderConfig>.NativeClassPtr, 100686362);
				ByValueOrderConfigFactory<TFocusing, TOrdering>.ByValueOrderConfig.NativeMethodInfoPtr_get_TypedFactory_Private_get_ByValueOrderConfigFactory_2_TFocusing_TOrdering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueOrderConfigFactory<TFocusing, TOrdering>.ByValueOrderConfig>.NativeClassPtr, 100686363);
				ByValueOrderConfigFactory<TFocusing, TOrdering>.ByValueOrderConfig.NativeMethodInfoPtr_GetFocusingElement_Protected_Virtual_TFocusing_TOrdering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueOrderConfigFactory<TFocusing, TOrdering>.ByValueOrderConfig>.NativeClassPtr, 100686364);
			}

			// Token: 0x06010DF8 RID: 69112 RVA: 0x003E6524 File Offset: 0x003E4724
			[CallerCount(0)]
			public unsafe ByValueOrderConfig(IFilterConfigFactory factory, Order order) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByValueOrderConfigFactory<TFocusing, TOrdering>.ByValueOrderConfig>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueOrderConfigFactory<TFocusing, TOrdering>.ByValueOrderConfig.NativeMethodInfoPtr__ctor_Public_Void_IFilterConfigFactory_Order_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170057D9 RID: 22489
			// (get) Token: 0x06010DF9 RID: 69113 RVA: 0x003E6580 File Offset: 0x003E4780
			public unsafe ByValueOrderConfigFactory<TFocusing, TOrdering> TypedFactory
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueOrderConfigFactory<TFocusing, TOrdering>.ByValueOrderConfig.NativeMethodInfoPtr_get_TypedFactory_Private_get_ByValueOrderConfigFactory_2_TFocusing_TOrdering_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ByValueOrderConfigFactory<TFocusing, TOrdering>>(intPtr3) : null;
				}
			}

			// Token: 0x06010DFA RID: 69114 RVA: 0x003E65C0 File Offset: 0x003E47C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281982, XrefRangeEnd = 281983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override TFocusing GetFocusingElement(TOrdering src)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TOrdering).IsValueType)
				{
					TOrdering tordering = src;
					intPtr = ((tordering is string) ? IL2CPP.ManagedStringToIl2Cpp(tordering as string) : IL2CPP.Il2CppObjectBaseToPtr(tordering as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref src;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByValueOrderConfigFactory<TFocusing, TOrdering>.ByValueOrderConfig.NativeMethodInfoPtr_GetFocusingElement_Protected_Virtual_TFocusing_TOrdering_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TFocusing>(intPtr2, false, true);
			}

			// Token: 0x06010DFB RID: 69115 RVA: 0x00092FB9 File Offset: 0x000911B9
			public ByValueOrderConfig(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400AAB4 RID: 43700
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFilterConfigFactory_Order_0;

			// Token: 0x0400AAB5 RID: 43701
			private static readonly IntPtr NativeMethodInfoPtr_get_TypedFactory_Private_get_ByValueOrderConfigFactory_2_TFocusing_TOrdering_0;

			// Token: 0x0400AAB6 RID: 43702
			private static readonly IntPtr NativeMethodInfoPtr_GetFocusingElement_Protected_Virtual_TFocusing_TOrdering_0;
		}
	}
}
