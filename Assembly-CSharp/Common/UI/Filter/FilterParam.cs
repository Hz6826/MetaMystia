using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Common.UI.Filter
{
	// Token: 0x020003B8 RID: 952
	public sealed class FilterParam : ValueType
	{
		// Token: 0x06007178 RID: 29048 RVA: 0x00218E50 File Offset: 0x00217050
		// Note: this type is marked as 'beforefieldinit'.
		static FilterParam()
		{
			Il2CppClassPointerStore<FilterParam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "FilterParam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterParam>.NativeClassPtr);
			FilterParam.NativeFieldInfoPtr_FilterConfigFactories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterParam>.NativeClassPtr, "FilterConfigFactories");
			FilterParam.NativeFieldInfoPtr_CurrentFilterConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterParam>.NativeClassPtr, "CurrentFilterConfig");
			FilterParam.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_IFilterConfigFactory_List_1_IFilterConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterParam>.NativeClassPtr, 100686440);
		}

		// Token: 0x06007179 RID: 29049 RVA: 0x00218EBC File Offset: 0x002170BC
		[CallerCount(272)]
		[CachedScanResults(RefRangeStart = 17829, RefRangeEnd = 18101, XrefRangeStart = 17829, XrefRangeEnd = 18101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterParam(IReadOnlyList<IFilterConfigFactory> filterConfigFactories, List<IFilterConfig> currentFilterConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterParam>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterConfigFactories);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentFilterConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterParam.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_IFilterConfigFactory_List_1_IFilterConfig_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600717A RID: 29050 RVA: 0x0003D780 File Offset: 0x0003B980
		public FilterParam(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600717B RID: 29051 RVA: 0x0003D789 File Offset: 0x0003B989
		public FilterParam() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterParam>.NativeClassPtr))
		{
		}

		// Token: 0x170026E0 RID: 9952
		// (get) Token: 0x0600717C RID: 29052 RVA: 0x00218F20 File Offset: 0x00217120
		// (set) Token: 0x0600717D RID: 29053 RVA: 0x0003D79B File Offset: 0x0003B99B
		public unsafe IReadOnlyList<IFilterConfigFactory> FilterConfigFactories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterParam.NativeFieldInfoPtr_FilterConfigFactories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<IFilterConfigFactory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterParam.NativeFieldInfoPtr_FilterConfigFactories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026E1 RID: 9953
		// (get) Token: 0x0600717E RID: 29054 RVA: 0x00218F50 File Offset: 0x00217150
		// (set) Token: 0x0600717F RID: 29055 RVA: 0x0003D7BA File Offset: 0x0003B9BA
		public unsafe List<IFilterConfig> CurrentFilterConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterParam.NativeFieldInfoPtr_CurrentFilterConfig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterParam.NativeFieldInfoPtr_CurrentFilterConfig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B2F RID: 19247
		private static readonly IntPtr NativeFieldInfoPtr_FilterConfigFactories;

		// Token: 0x04004B30 RID: 19248
		private static readonly IntPtr NativeFieldInfoPtr_CurrentFilterConfig;

		// Token: 0x04004B31 RID: 19249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_IFilterConfigFactory_List_1_IFilterConfig_0;
	}
}
