using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Common.UI.Filter
{
	// Token: 0x020003A9 RID: 937
	public class ByValueEqualityConfigFactory<TFocusing, TOrdering> : FilterWhereConfigFactoryTyped<TOrdering, TFocusing>
	{
		// Token: 0x0600710C RID: 28940 RVA: 0x00216B64 File Offset: 0x00214D64
		// Note: this type is marked as 'beforefieldinit'.
		static ByValueEqualityConfigFactory()
		{
			Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "ByValueEqualityConfigFactory`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFocusing>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrdering>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>>.NativeClassPtr);
			ByValueEqualityConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_GetFocusing_Protected_Abstract_Virtual_New_TFocusing_TOrdering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686344);
			ByValueEqualityConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_WhereFilterConfig_1_TOrdering_TFocusing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686345);
			ByValueEqualityConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, 100686346);
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x00216C20 File Offset: 0x00214E20
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByValueEqualityConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_GetFocusing_Protected_Abstract_Virtual_New_TFocusing_TOrdering_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TFocusing>(intPtr2, false, true);
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x00216CAC File Offset: 0x00214EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281969, XrefRangeEnd = 281971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WhereFilterConfig<TOrdering> CreateFilterConfig(TFocusing value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TFocusing).IsValueType)
			{
				TFocusing tfocusing = value;
				intPtr = ((tfocusing is string) ? IL2CPP.ManagedStringToIl2Cpp(tfocusing as string) : IL2CPP.Il2CppObjectBaseToPtr(tfocusing as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByValueEqualityConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_WhereFilterConfig_1_TOrdering_TFocusing_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<WhereFilterConfig<TOrdering>>(intPtr4) : null;
		}

		// Token: 0x0600710F RID: 28943 RVA: 0x00216D40 File Offset: 0x00214F40
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 281971, RefRangeEnd = 281982, XrefRangeStart = 281971, XrefRangeEnd = 281971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByValueEqualityConfigFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectionPriorityWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueEqualityConfigFactory<TFocusing, TOrdering>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007110 RID: 28944 RVA: 0x0003D692 File Offset: 0x0003B892
		public ByValueEqualityConfigFactory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004ADC RID: 19164
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusing_Protected_Abstract_Virtual_New_TFocusing_TOrdering_0;

		// Token: 0x04004ADD RID: 19165
		private static readonly IntPtr NativeMethodInfoPtr_CreateFilterConfig_Protected_Virtual_WhereFilterConfig_1_TOrdering_TFocusing_0;

		// Token: 0x04004ADE RID: 19166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;

		// Token: 0x02000F01 RID: 3841
		public class ByValueEqualityConfig : WhereFilterConfig<TOrdering>
		{
			// Token: 0x06010DEF RID: 69103 RVA: 0x003E6114 File Offset: 0x003E4314
			// Note: this type is marked as 'beforefieldinit'.
			static ByValueEqualityConfig()
			{
				Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>>.NativeClassPtr, "ByValueEqualityConfig"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFocusing>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrdering>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig>.NativeClassPtr);
				ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig.NativeFieldInfoPtr_m_Equals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig>.NativeClassPtr, "m_Equals");
				ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig.NativeMethodInfoPtr__ctor_Public_Void_IFilterConfigFactory_TFocusing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig>.NativeClassPtr, 100686347);
				ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig.NativeMethodInfoPtr_get_TypedFactory_Private_get_ByValueEqualityConfigFactory_2_TFocusing_TOrdering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig>.NativeClassPtr, 100686348);
				ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig.NativeMethodInfoPtr_get_SelectedElements_Public_Virtual_get_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig>.NativeClassPtr, 100686349);
				ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig.NativeMethodInfoPtr_OnWhere_Protected_Virtual_Boolean_TOrdering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig>.NativeClassPtr, 100686350);
			}

			// Token: 0x06010DF0 RID: 69104 RVA: 0x003E61F0 File Offset: 0x003E43F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281963, XrefRangeEnd = 281964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ByValueEqualityConfig(IFilterConfigFactory factory, TFocusing equals) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(TFocusing).IsValueType)
				{
					TFocusing tfocusing = equals;
					intPtr = ((tfocusing is string) ? IL2CPP.ManagedStringToIl2Cpp(tfocusing as string) : IL2CPP.Il2CppObjectBaseToPtr(tfocusing as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref equals;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig.NativeMethodInfoPtr__ctor_Public_Void_IFilterConfigFactory_TFocusing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x170057D7 RID: 22487
			// (get) Token: 0x06010DF1 RID: 69105 RVA: 0x003E6284 File Offset: 0x003E4484
			public unsafe ByValueEqualityConfigFactory<TFocusing, TOrdering> TypedFactory
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281964, XrefRangeEnd = 281965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig.NativeMethodInfoPtr_get_TypedFactory_Private_get_ByValueEqualityConfigFactory_2_TFocusing_TOrdering_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ByValueEqualityConfigFactory<TFocusing, TOrdering>>(intPtr3) : null;
				}
			}

			// Token: 0x170057D8 RID: 22488
			// (get) Token: 0x06010DF2 RID: 69106 RVA: 0x003E62C4 File Offset: 0x003E44C4
			public unsafe override IEnumerable<Object> SelectedElements
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281965, XrefRangeEnd = 281968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig.NativeMethodInfoPtr_get_SelectedElements_Public_Virtual_get_IEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
				}
			}

			// Token: 0x06010DF3 RID: 69107 RVA: 0x003E6310 File Offset: 0x003E4510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281968, XrefRangeEnd = 281969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig.NativeMethodInfoPtr_OnWhere_Protected_Virtual_Boolean_TOrdering_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06010DF4 RID: 69108 RVA: 0x00092FB0 File Offset: 0x000911B0
			public ByValueEqualityConfig(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057D6 RID: 22486
			// (get) Token: 0x06010DF5 RID: 69109 RVA: 0x003E63A0 File Offset: 0x003E45A0
			// (set) Token: 0x06010DF6 RID: 69110 RVA: 0x003E63C8 File Offset: 0x003E45C8
			public unsafe TFocusing m_Equals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig.NativeFieldInfoPtr_m_Equals);
					return IL2CPP.PointerToValueGeneric<TFocusing>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig.NativeFieldInfoPtr_m_Equals);
					Type typeFromHandle = typeof(TFocusing);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x0400AAAF RID: 43695
			private static readonly IntPtr NativeFieldInfoPtr_m_Equals;

			// Token: 0x0400AAB0 RID: 43696
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFilterConfigFactory_TFocusing_0;

			// Token: 0x0400AAB1 RID: 43697
			private static readonly IntPtr NativeMethodInfoPtr_get_TypedFactory_Private_get_ByValueEqualityConfigFactory_2_TFocusing_TOrdering_0;

			// Token: 0x0400AAB2 RID: 43698
			private static readonly IntPtr NativeMethodInfoPtr_get_SelectedElements_Public_Virtual_get_IEnumerable_1_Object_0;

			// Token: 0x0400AAB3 RID: 43699
			private static readonly IntPtr NativeMethodInfoPtr_OnWhere_Protected_Virtual_Boolean_TOrdering_0;

			// Token: 0x020010C0 RID: 4288
			[ObfuscatedName("Common.UI.Filter.ByValueEqualityConfigFactory`2+ByValueEqualityConfig+<get_SelectedElements>d__5")]
			public sealed class _get_SelectedElements_d__5 : Object
			{
				// Token: 0x06012331 RID: 74545 RVA: 0x004264DC File Offset: 0x004246DC
				// Note: this type is marked as 'beforefieldinit'.
				static _get_SelectedElements_d__5()
				{
					Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig>.NativeClassPtr, "<get_SelectedElements>d__5"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFocusing>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrdering>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr);
					ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr, "<>1__state");
					ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr, "<>2__current");
					ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr, "<>l__initialThreadId");
					ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr, "<>4__this");
					ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr, 100686351);
					ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr, 100686352);
					ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr, 100686353);
					ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr, 100686354);
					ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr, 100686355);
					ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr, 100686356);
					ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr, 100686357);
					ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr, 100686358);
				}

				// Token: 0x06012332 RID: 74546 RVA: 0x00426644 File Offset: 0x00424844
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 39842, RefRangeEnd = 39844, XrefRangeStart = 39842, XrefRangeEnd = 39844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _get_SelectedElements_d__5(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012333 RID: 74547 RVA: 0x0042668C File Offset: 0x0042488C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012334 RID: 74548 RVA: 0x004266C0 File Offset: 0x004248C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281940, XrefRangeEnd = 281941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005F32 RID: 24370
				// (get) Token: 0x06012335 RID: 74549 RVA: 0x004266FC File Offset: 0x004248FC
				public unsafe Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012336 RID: 74550 RVA: 0x0042673C File Offset: 0x0042493C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281941, XrefRangeEnd = 281959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005F33 RID: 24371
				// (get) Token: 0x06012337 RID: 74551 RVA: 0x00426770 File Offset: 0x00424970
				public unsafe Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012338 RID: 74552 RVA: 0x004267B0 File Offset: 0x004249B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281959, XrefRangeEnd = 281960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<Object> System_Collections_Generic_IEnumerable_System_Object__GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Object>>(intPtr3) : null;
				}

				// Token: 0x06012339 RID: 74553 RVA: 0x004267F0 File Offset: 0x004249F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281960, XrefRangeEnd = 281963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x0601233A RID: 74554 RVA: 0x0009DFFA File Offset: 0x0009C1FA
				public _get_SelectedElements_d__5(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F2E RID: 24366
				// (get) Token: 0x0601233B RID: 74555 RVA: 0x00426830 File Offset: 0x00424A30
				// (set) Token: 0x0601233C RID: 74556 RVA: 0x0009E003 File Offset: 0x0009C203
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005F2F RID: 24367
				// (get) Token: 0x0601233D RID: 74557 RVA: 0x00426858 File Offset: 0x00424A58
				// (set) Token: 0x0601233E RID: 74558 RVA: 0x0009E01E File Offset: 0x0009C21E
				public unsafe Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F30 RID: 24368
				// (get) Token: 0x0601233F RID: 74559 RVA: 0x00426888 File Offset: 0x00424A88
				// (set) Token: 0x06012340 RID: 74560 RVA: 0x0009E03D File Offset: 0x0009C23D
				public unsafe int __l__initialThreadId
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeFieldInfoPtr___l__initialThreadId);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
					}
				}

				// Token: 0x17005F31 RID: 24369
				// (get) Token: 0x06012341 RID: 74561 RVA: 0x004268B0 File Offset: 0x00424AB0
				// (set) Token: 0x06012342 RID: 74562 RVA: 0x0009E058 File Offset: 0x0009C258
				public unsafe ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByValueEqualityConfigFactory<TFocusing, TOrdering>.ByValueEqualityConfig._get_SelectedElements_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B879 RID: 47225
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B87A RID: 47226
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B87B RID: 47227
				private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

				// Token: 0x0400B87C RID: 47228
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B87D RID: 47229
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B87E RID: 47230
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B87F RID: 47231
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B880 RID: 47232
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B881 RID: 47233
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B882 RID: 47234
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B883 RID: 47235
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0;

				// Token: 0x0400B884 RID: 47236
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
			}
		}
	}
}
