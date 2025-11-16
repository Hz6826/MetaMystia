using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;

namespace Common.UI.Filter
{
	// Token: 0x020003AC RID: 940
	public class BaseFilterConfig : Object
	{
		// Token: 0x0600711E RID: 28958 RVA: 0x00217204 File Offset: 0x00215404
		// Note: this type is marked as 'beforefieldinit'.
		static BaseFilterConfig()
		{
			Il2CppClassPointerStore<BaseFilterConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "BaseFilterConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseFilterConfig>.NativeClassPtr);
			BaseFilterConfig.NativeFieldInfoPtr__Factory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseFilterConfig>.NativeClassPtr, "<Factory>k__BackingField");
			BaseFilterConfig.NativeMethodInfoPtr__ctor_Protected_Void_IFilterConfigFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseFilterConfig>.NativeClassPtr, 100686371);
			BaseFilterConfig.NativeMethodInfoPtr_get_SelectedElements_Public_Abstract_Virtual_New_get_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseFilterConfig>.NativeClassPtr, 100686372);
			BaseFilterConfig.NativeMethodInfoPtr_get_FilterType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseFilterConfig>.NativeClassPtr, 100686373);
			BaseFilterConfig.NativeMethodInfoPtr_get_Factory_Public_Virtual_Final_New_get_IFilterConfigFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseFilterConfig>.NativeClassPtr, 100686374);
			BaseFilterConfig.NativeMethodInfoPtr_DoFilter_Public_Virtual_New_IOrderedEnumerable_1_Object_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseFilterConfig>.NativeClassPtr, 100686375);
			BaseFilterConfig.NativeMethodInfoPtr_DoFilter_Public_Virtual_New_IOrderedEnumerable_1_Object_IOrderedEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseFilterConfig>.NativeClassPtr, 100686376);
			BaseFilterConfig.NativeMethodInfoPtr_DoWhere_Public_Virtual_New_IEnumerable_1_Object_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseFilterConfig>.NativeClassPtr, 100686377);
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x002172D4 File Offset: 0x002154D4
		[CallerCount(109)]
		[CachedScanResults(RefRangeStart = 60056, RefRangeEnd = 60165, XrefRangeStart = 60056, XrefRangeEnd = 60165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseFilterConfig(IFilterConfigFactory factory) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseFilterConfig>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseFilterConfig.NativeMethodInfoPtr__ctor_Protected_Void_IFilterConfigFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170026CA RID: 9930
		// (get) Token: 0x06007120 RID: 28960 RVA: 0x00217320 File Offset: 0x00215520
		public unsafe virtual IEnumerable<Object> SelectedElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseFilterConfig.NativeMethodInfoPtr_get_SelectedElements_Public_Abstract_Virtual_New_get_IEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x170026CB RID: 9931
		// (get) Token: 0x06007121 RID: 28961 RVA: 0x0021736C File Offset: 0x0021556C
		public unsafe virtual IFilterConfig.Type FilterType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseFilterConfig.NativeMethodInfoPtr_get_FilterType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026CC RID: 9932
		// (get) Token: 0x06007122 RID: 28962 RVA: 0x002173B4 File Offset: 0x002155B4
		public unsafe virtual IFilterConfigFactory Factory
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseFilterConfig.NativeMethodInfoPtr_get_Factory_Public_Virtual_Final_New_get_IFilterConfigFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFilterConfigFactory>(intPtr3) : null;
			}
		}

		// Token: 0x06007123 RID: 28963 RVA: 0x002173F4 File Offset: 0x002155F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281985, XrefRangeEnd = 281991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IOrderedEnumerable<Object> DoFilter(IEnumerable<Object> objectsToFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectsToFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseFilterConfig.NativeMethodInfoPtr_DoFilter_Public_Virtual_New_IOrderedEnumerable_1_Object_IEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x06007124 RID: 28964 RVA: 0x00217450 File Offset: 0x00215650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281991, XrefRangeEnd = 281997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IOrderedEnumerable<Object> DoFilter(IOrderedEnumerable<Object> objectsToFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectsToFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseFilterConfig.NativeMethodInfoPtr_DoFilter_Public_Virtual_New_IOrderedEnumerable_1_Object_IOrderedEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x06007125 RID: 28965 RVA: 0x002174AC File Offset: 0x002156AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281997, XrefRangeEnd = 282003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Object> DoWhere(IEnumerable<Object> objectsToFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectsToFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseFilterConfig.NativeMethodInfoPtr_DoWhere_Public_Virtual_New_IEnumerable_1_Object_IEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x0003D6AD File Offset: 0x0003B8AD
		public BaseFilterConfig(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026C9 RID: 9929
		// (get) Token: 0x06007127 RID: 28967 RVA: 0x00217508 File Offset: 0x00215708
		// (set) Token: 0x06007128 RID: 28968 RVA: 0x0003D6B6 File Offset: 0x0003B8B6
		public unsafe IFilterConfigFactory _Factory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseFilterConfig.NativeFieldInfoPtr__Factory_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFilterConfigFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseFilterConfig.NativeFieldInfoPtr__Factory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004AE8 RID: 19176
		private static readonly IntPtr NativeFieldInfoPtr__Factory_k__BackingField;

		// Token: 0x04004AE9 RID: 19177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IFilterConfigFactory_0;

		// Token: 0x04004AEA RID: 19178
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedElements_Public_Abstract_Virtual_New_get_IEnumerable_1_Object_0;

		// Token: 0x04004AEB RID: 19179
		private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04004AEC RID: 19180
		private static readonly IntPtr NativeMethodInfoPtr_get_Factory_Public_Virtual_Final_New_get_IFilterConfigFactory_0;

		// Token: 0x04004AED RID: 19181
		private static readonly IntPtr NativeMethodInfoPtr_DoFilter_Public_Virtual_New_IOrderedEnumerable_1_Object_IEnumerable_1_Object_0;

		// Token: 0x04004AEE RID: 19182
		private static readonly IntPtr NativeMethodInfoPtr_DoFilter_Public_Virtual_New_IOrderedEnumerable_1_Object_IOrderedEnumerable_1_Object_0;

		// Token: 0x04004AEF RID: 19183
		private static readonly IntPtr NativeMethodInfoPtr_DoWhere_Public_Virtual_New_IEnumerable_1_Object_IEnumerable_1_Object_0;
	}
}
