using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Common.UI.Filter
{
	// Token: 0x020003B5 RID: 949
	public class FilterConfigFactory<TOrderingType> : Object
	{
		// Token: 0x0600715C RID: 29020 RVA: 0x0021857C File Offset: 0x0021677C
		// Note: this type is marked as 'beforefieldinit'.
		static FilterConfigFactory()
		{
			Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "FilterConfigFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrderingType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr);
			FilterConfigFactory<TOrderingType>.NativeFieldInfoPtr__SelectionPriorityWeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, "<SelectionPriorityWeight>k__BackingField");
			FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, 100686418);
			FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_ShouldEnable_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, 100686419);
			FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, 100686420);
			FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, 100686421);
			FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_get_FilterType_Public_Abstract_Virtual_New_get_FilterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, 100686422);
			FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_get_FactoryName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, 100686423);
			FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_Common_UI_Filter_IFilterConfigFactory_GetSelections_Private_Virtual_Final_New_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, 100686424);
			FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_Common_UI_Filter_IFilterConfigFactory_CreateFilterConfig_Private_Virtual_Final_New_IFilterConfig_IReadOnlyList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, 100686425);
			FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_Common_UI_Filter_IFilterConfigFactory_GetSelectionText_Private_Virtual_Final_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, 100686426);
			FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, 100686427);
			FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_GetSelections_Protected_Abstract_Virtual_New_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, 100686428);
			FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Abstract_Virtual_New_BaseFilterConfig_IReadOnlyList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, 100686429);
			FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_GetSelectionText_Protected_Abstract_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr, 100686430);
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x00218700 File Offset: 0x00216900
		[CallerCount(94)]
		[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterConfigFactory(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigFactory<TOrderingType>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectionPriorityWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x00218748 File Offset: 0x00216948
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_ShouldEnable_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170026D8 RID: 9944
		// (get) Token: 0x0600715F RID: 29023 RVA: 0x00218790 File Offset: 0x00216990
		public unsafe virtual uint ColumnCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026D9 RID: 9945
		// (get) Token: 0x06007160 RID: 29024 RVA: 0x002187D8 File Offset: 0x002169D8
		public unsafe virtual uint SelectionPriorityWeight
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Virtual_Final_New_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026DA RID: 9946
		// (get) Token: 0x06007161 RID: 29025 RVA: 0x00218814 File Offset: 0x00216A14
		public unsafe virtual FilterType FilterType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_get_FilterType_Public_Abstract_Virtual_New_get_FilterType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026DB RID: 9947
		// (get) Token: 0x06007162 RID: 29026 RVA: 0x0021885C File Offset: 0x00216A5C
		public unsafe virtual string FactoryName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_get_FactoryName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x002188A0 File Offset: 0x00216AA0
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Object> Common_UI_Filter_IFilterConfigFactory_GetSelections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_Common_UI_Filter_IFilterConfigFactory_GetSelections_Private_Virtual_Final_New_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x06007164 RID: 29028 RVA: 0x002188E0 File Offset: 0x00216AE0
		[CallerCount(67)]
		[CachedScanResults(RefRangeStart = 282135, RefRangeEnd = 282202, XrefRangeStart = 282135, XrefRangeEnd = 282135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IFilterConfig Common_UI_Filter_IFilterConfigFactory_CreateFilterConfig(IReadOnlyList<Object> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_Common_UI_Filter_IFilterConfigFactory_CreateFilterConfig_Private_Virtual_Final_New_IFilterConfig_IReadOnlyList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFilterConfig>(intPtr3) : null;
		}

		// Token: 0x06007165 RID: 29029 RVA: 0x00218930 File Offset: 0x00216B30
		[CallerCount(0)]
		public unsafe virtual string Common_UI_Filter_IFilterConfigFactory_GetSelectionText(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_Common_UI_Filter_IFilterConfigFactory_GetSelectionText_Private_Virtual_Final_New_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007166 RID: 29030 RVA: 0x00218978 File Offset: 0x00216B78
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnWillFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_OnWillFilter_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007167 RID: 29031 RVA: 0x002189B4 File Offset: 0x00216BB4
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Object> GetSelections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_GetSelections_Protected_Abstract_Virtual_New_IEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x06007168 RID: 29032 RVA: 0x00218A00 File Offset: 0x00216C00
		[CallerCount(0)]
		public unsafe virtual BaseFilterConfig CreateFilterConfig(IReadOnlyList<Object> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_CreateFilterConfig_Protected_Abstract_Virtual_New_BaseFilterConfig_IReadOnlyList_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseFilterConfig>(intPtr3) : null;
		}

		// Token: 0x06007169 RID: 29033 RVA: 0x00218A5C File Offset: 0x00216C5C
		[CallerCount(0)]
		public unsafe virtual string GetSelectionText(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterConfigFactory<TOrderingType>.NativeMethodInfoPtr_GetSelectionText_Protected_Abstract_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600716A RID: 29034 RVA: 0x0003D753 File Offset: 0x0003B953
		public FilterConfigFactory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026D7 RID: 9943
		// (get) Token: 0x0600716B RID: 29035 RVA: 0x00218AB0 File Offset: 0x00216CB0
		// (set) Token: 0x0600716C RID: 29036 RVA: 0x0003D75C File Offset: 0x0003B95C
		public unsafe uint _SelectionPriorityWeight_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigFactory<TOrderingType>.NativeFieldInfoPtr__SelectionPriorityWeight_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigFactory<TOrderingType>.NativeFieldInfoPtr__SelectionPriorityWeight_k__BackingField)) = value;
			}
		}

		// Token: 0x04004B15 RID: 19221
		private static readonly IntPtr NativeFieldInfoPtr__SelectionPriorityWeight_k__BackingField;

		// Token: 0x04004B16 RID: 19222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;

		// Token: 0x04004B17 RID: 19223
		private static readonly IntPtr NativeMethodInfoPtr_ShouldEnable_Public_Virtual_New_Boolean_0;

		// Token: 0x04004B18 RID: 19224
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnCount_Public_Virtual_New_get_UInt32_0;

		// Token: 0x04004B19 RID: 19225
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Virtual_Final_New_get_UInt32_0;

		// Token: 0x04004B1A RID: 19226
		private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Abstract_Virtual_New_get_FilterType_0;

		// Token: 0x04004B1B RID: 19227
		private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04004B1C RID: 19228
		private static readonly IntPtr NativeMethodInfoPtr_Common_UI_Filter_IFilterConfigFactory_GetSelections_Private_Virtual_Final_New_IEnumerable_1_Object_0;

		// Token: 0x04004B1D RID: 19229
		private static readonly IntPtr NativeMethodInfoPtr_Common_UI_Filter_IFilterConfigFactory_CreateFilterConfig_Private_Virtual_Final_New_IFilterConfig_IReadOnlyList_1_Object_0;

		// Token: 0x04004B1E RID: 19230
		private static readonly IntPtr NativeMethodInfoPtr_Common_UI_Filter_IFilterConfigFactory_GetSelectionText_Private_Virtual_Final_New_String_Object_0;

		// Token: 0x04004B1F RID: 19231
		private static readonly IntPtr NativeMethodInfoPtr_OnWillFilter_Public_Virtual_New_Void_0;

		// Token: 0x04004B20 RID: 19232
		private static readonly IntPtr NativeMethodInfoPtr_GetSelections_Protected_Abstract_Virtual_New_IEnumerable_1_Object_0;

		// Token: 0x04004B21 RID: 19233
		private static readonly IntPtr NativeMethodInfoPtr_CreateFilterConfig_Protected_Abstract_Virtual_New_BaseFilterConfig_IReadOnlyList_1_Object_0;

		// Token: 0x04004B22 RID: 19234
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionText_Protected_Abstract_Virtual_New_String_Object_0;
	}
}
