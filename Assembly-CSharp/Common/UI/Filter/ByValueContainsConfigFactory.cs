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
	// Token: 0x020003A8 RID: 936
	public class ByValueContainsConfigFactory<TFocusing, TOrdering> : FilterContainsConfigFactoryTyped<TOrdering, TFocusing>
	{
		// Token: 0x06007104 RID: 28932 RVA: 0x00216864 File Offset: 0x00214A64
		// Note: this type is marked as 'beforefieldinit'.
		static ByValueContainsConfigFactory()
		{
			Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "ByValueContainsConfigFactory`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFocusing>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrdering>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>>.NativeClassPtr);
			ByValueContainsConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686334);
			ByValueContainsConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_get_ContainsRule_Protected_Abstract_Virtual_New_get_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686335);
			ByValueContainsConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_GetByTypeText_Protected_Abstract_Virtual_New_String_Rule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686336);
			ByValueContainsConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_GetFocusing_Protected_Abstract_Virtual_New_IEnumerable_1_TFocusing_TOrdering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686337);
			ByValueContainsConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_WhereFilterConfig_1_TOrdering_IEnumerable_1_TFocusing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686338);
			ByValueContainsConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686339);
		}

		// Token: 0x170026C4 RID: 9924
		// (get) Token: 0x06007105 RID: 28933 RVA: 0x0021695C File Offset: 0x00214B5C
		public unsafe override string FactoryName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueContainsConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170026C5 RID: 9925
		// (get) Token: 0x06007106 RID: 28934 RVA: 0x00216994 File Offset: 0x00214B94
		public unsafe virtual Rule ContainsRule
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByValueContainsConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_get_ContainsRule_Protected_Abstract_Virtual_New_get_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x002169DC File Offset: 0x00214BDC
		[CallerCount(0)]
		public unsafe virtual string GetByTypeText(Rule rule)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rule;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByValueContainsConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_GetByTypeText_Protected_Abstract_Virtual_New_String_Rule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007108 RID: 28936 RVA: 0x00216A2C File Offset: 0x00214C2C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<TFocusing> GetFocusing(TOrdering ordering)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByValueContainsConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_GetFocusing_Protected_Abstract_Virtual_New_IEnumerable_1_TFocusing_TOrdering_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<TFocusing>>(intPtr4) : null;
		}

		// Token: 0x06007109 RID: 28937 RVA: 0x00216AC0 File Offset: 0x00214CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281927, XrefRangeEnd = 281929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WhereFilterConfig<TOrdering> CreateFilterConfig(IEnumerable<TFocusing> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByValueContainsConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_WhereFilterConfig_1_TOrdering_IEnumerable_1_TFocusing_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WhereFilterConfig<TOrdering>>(intPtr3) : null;
		}

		// Token: 0x0600710A RID: 28938 RVA: 0x00216B1C File Offset: 0x00214D1C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 281929, RefRangeEnd = 281940, XrefRangeStart = 281929, XrefRangeEnd = 281929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByValueContainsConfigFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectionPriorityWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueContainsConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600710B RID: 28939 RVA: 0x0003D689 File Offset: 0x0003B889
		public ByValueContainsConfigFactory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004AD6 RID: 19158
		private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Virtual_Final_get_String_0;

		// Token: 0x04004AD7 RID: 19159
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsRule_Protected_Abstract_Virtual_New_get_Rule_0;

		// Token: 0x04004AD8 RID: 19160
		private static readonly IntPtr NativeMethodInfoPtr_GetByTypeText_Protected_Abstract_Virtual_New_String_Rule_0;

		// Token: 0x04004AD9 RID: 19161
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Abstract_Virtual_New_IEnumerable_1_TFocusing_TOrdering_0;

		// Token: 0x04004ADA RID: 19162
		private static readonly IntPtr NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_WhereFilterConfig_1_TOrdering_IEnumerable_1_TFocusing_0;

		// Token: 0x04004ADB RID: 19163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;

		// Token: 0x02000F00 RID: 3840
		public class ByValueContainsConfig : WhereFilterConfig<TOrdering>
		{
			// Token: 0x06010DE7 RID: 69095 RVA: 0x003E5E98 File Offset: 0x003E4098
			// Note: this type is marked as 'beforefieldinit'.
			static ByValueContainsConfig()
			{
				Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, "ByValueContainsConfig"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFocusing>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrdering>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig>.NativeClassPtr);
				ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig.NativeFieldInfoPtr_m_Focusing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig>.NativeClassPtr, "m_Focusing");
				ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig.NativeMethodInfoPtr__ctor_Public_Void_IFilterConfigFactory_IEnumerable_1_TFocusing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig>.NativeClassPtr, 100686340);
				ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig.NativeMethodInfoPtr_get_TypedFactory_Private_get_ByValueContainsConfigFactory_2_TFocusing_TOrdering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig>.NativeClassPtr, 100686341);
				ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig.NativeMethodInfoPtr_get_SelectedElements_Public_Virtual_Final_get_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig>.NativeClassPtr, 100686342);
				ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig.NativeMethodInfoPtr_OnWhere_Protected_Virtual_Boolean_TOrdering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig>.NativeClassPtr, 100686343);
			}

			// Token: 0x06010DE8 RID: 69096 RVA: 0x003E5F74 File Offset: 0x003E4174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281913, XrefRangeEnd = 281923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ByValueContainsConfig(IFilterConfigFactory factory, IEnumerable<TFocusing> focusing) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(focusing);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig.NativeMethodInfoPtr__ctor_Public_Void_IFilterConfigFactory_IEnumerable_1_TFocusing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170057D4 RID: 22484
			// (get) Token: 0x06010DE9 RID: 69097 RVA: 0x003E5FD4 File Offset: 0x003E41D4
			public unsafe ByValueContainsConfigFactory<TFocusing, TOrdering> TypedFactory
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281923, XrefRangeEnd = 281924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig.NativeMethodInfoPtr_get_TypedFactory_Private_get_ByValueContainsConfigFactory_2_TFocusing_TOrdering_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ByValueContainsConfigFactory<TFocusing, TOrdering>>(intPtr3) : null;
				}
			}

			// Token: 0x170057D5 RID: 22485
			// (get) Token: 0x06010DEA RID: 69098 RVA: 0x003E6014 File Offset: 0x003E4214
			public unsafe override IEnumerable<Object> SelectedElements
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281924, XrefRangeEnd = 281927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig.NativeMethodInfoPtr_get_SelectedElements_Public_Virtual_Final_get_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
				}
			}

			// Token: 0x06010DEB RID: 69099 RVA: 0x003E6054 File Offset: 0x003E4254
			[CallerCount(0)]
			public unsafe override bool OnWhere(TOrdering value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TOrdering).IsValueType)
				{
					TOrdering tordering = value;
					intPtr = ((tordering is string) ? IL2CPP.ManagedStringToIl2Cpp(tordering as string) : IL2CPP.Il2CppObjectBaseToPtr(tordering as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig.NativeMethodInfoPtr_OnWhere_Protected_Virtual_Boolean_TOrdering_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06010DEC RID: 69100 RVA: 0x00092F88 File Offset: 0x00091188
			public ByValueContainsConfig(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057D3 RID: 22483
			// (get) Token: 0x06010DED RID: 69101 RVA: 0x003E60E4 File Offset: 0x003E42E4
			// (set) Token: 0x06010DEE RID: 69102 RVA: 0x00092F91 File Offset: 0x00091191
			public unsafe HashSet<TFocusing> m_Focusing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig.NativeFieldInfoPtr_m_Focusing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<TFocusing>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByValueContainsConfigFactory<TFocusing, TOrdering>.ByValueContainsConfig.NativeFieldInfoPtr_m_Focusing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AAAA RID: 43690
			private static readonly IntPtr NativeFieldInfoPtr_m_Focusing;

			// Token: 0x0400AAAB RID: 43691
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFilterConfigFactory_IEnumerable_1_TFocusing_0;

			// Token: 0x0400AAAC RID: 43692
			private static readonly IntPtr NativeMethodInfoPtr_get_TypedFactory_Private_get_ByValueContainsConfigFactory_2_TFocusing_TOrdering_0;

			// Token: 0x0400AAAD RID: 43693
			private static readonly IntPtr NativeMethodInfoPtr_get_SelectedElements_Public_Virtual_Final_get_IEnumerable_1_Object_0;

			// Token: 0x0400AAAE RID: 43694
			private static readonly IntPtr NativeMethodInfoPtr_OnWhere_Protected_Virtual_Boolean_TOrdering_0;
		}
	}
}
