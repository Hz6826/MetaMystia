using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Common.UI.Filter
{
	// Token: 0x020003B7 RID: 951
	public class IFilterConfigFactory : Il2CppObjectBase
	{
		// Token: 0x0600716D RID: 29037 RVA: 0x00218AD8 File Offset: 0x00216CD8
		// Note: this type is marked as 'beforefieldinit'.
		static IFilterConfigFactory()
		{
			Il2CppClassPointerStore<IFilterConfigFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "IFilterConfigFactory");
			IFilterConfigFactory.NativeMethodInfoPtr_get_FilterType_Public_Abstract_Virtual_New_get_FilterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfigFactory>.NativeClassPtr, 100686431);
			IFilterConfigFactory.NativeMethodInfoPtr_get_FactoryName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfigFactory>.NativeClassPtr, 100686432);
			IFilterConfigFactory.NativeMethodInfoPtr_ShouldEnable_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfigFactory>.NativeClassPtr, 100686433);
			IFilterConfigFactory.NativeMethodInfoPtr_get_ColumnCount_Public_Abstract_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfigFactory>.NativeClassPtr, 100686434);
			IFilterConfigFactory.NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Abstract_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfigFactory>.NativeClassPtr, 100686435);
			IFilterConfigFactory.NativeMethodInfoPtr_GetSelections_Public_Abstract_Virtual_New_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfigFactory>.NativeClassPtr, 100686436);
			IFilterConfigFactory.NativeMethodInfoPtr_CreateFilterConfig_Public_Abstract_Virtual_New_IFilterConfig_IReadOnlyList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfigFactory>.NativeClassPtr, 100686437);
			IFilterConfigFactory.NativeMethodInfoPtr_GetSelectionText_Public_Abstract_Virtual_New_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfigFactory>.NativeClassPtr, 100686438);
			IFilterConfigFactory.NativeMethodInfoPtr_OnWillFilter_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfigFactory>.NativeClassPtr, 100686439);
		}

		// Token: 0x170026DC RID: 9948
		// (get) Token: 0x0600716E RID: 29038 RVA: 0x00218BB4 File Offset: 0x00216DB4
		public unsafe virtual FilterType FilterType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfigFactory.NativeMethodInfoPtr_get_FilterType_Public_Abstract_Virtual_New_get_FilterType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026DD RID: 9949
		// (get) Token: 0x0600716F RID: 29039 RVA: 0x00218BFC File Offset: 0x00216DFC
		public unsafe virtual string FactoryName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfigFactory.NativeMethodInfoPtr_get_FactoryName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06007170 RID: 29040 RVA: 0x00218C40 File Offset: 0x00216E40
		[CallerCount(0)]
		public unsafe virtual bool ShouldEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfigFactory.NativeMethodInfoPtr_ShouldEnable_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170026DE RID: 9950
		// (get) Token: 0x06007171 RID: 29041 RVA: 0x00218C88 File Offset: 0x00216E88
		public unsafe virtual uint ColumnCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfigFactory.NativeMethodInfoPtr_get_ColumnCount_Public_Abstract_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026DF RID: 9951
		// (get) Token: 0x06007172 RID: 29042 RVA: 0x00218CD0 File Offset: 0x00216ED0
		public unsafe virtual uint SelectionPriorityWeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfigFactory.NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Abstract_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007173 RID: 29043 RVA: 0x00218D18 File Offset: 0x00216F18
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Object> GetSelections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfigFactory.NativeMethodInfoPtr_GetSelections_Public_Abstract_Virtual_New_IEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x06007174 RID: 29044 RVA: 0x00218D64 File Offset: 0x00216F64
		[CallerCount(0)]
		public unsafe virtual IFilterConfig CreateFilterConfig(IReadOnlyList<Object> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfigFactory.NativeMethodInfoPtr_CreateFilterConfig_Public_Abstract_Virtual_New_IFilterConfig_IReadOnlyList_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFilterConfig>(intPtr3) : null;
		}

		// Token: 0x06007175 RID: 29045 RVA: 0x00218DC0 File Offset: 0x00216FC0
		[CallerCount(0)]
		public unsafe virtual string GetSelectionText(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfigFactory.NativeMethodInfoPtr_GetSelectionText_Public_Abstract_Virtual_New_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007176 RID: 29046 RVA: 0x00218E14 File Offset: 0x00217014
		[CallerCount(0)]
		public unsafe virtual void OnWillFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfigFactory.NativeMethodInfoPtr_OnWillFilter_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007177 RID: 29047 RVA: 0x0003D777 File Offset: 0x0003B977
		public IFilterConfigFactory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004B26 RID: 19238
		private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Abstract_Virtual_New_get_FilterType_0;

		// Token: 0x04004B27 RID: 19239
		private static readonly IntPtr NativeMethodInfoPtr_get_FactoryName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04004B28 RID: 19240
		private static readonly IntPtr NativeMethodInfoPtr_ShouldEnable_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04004B29 RID: 19241
		private static readonly IntPtr NativeMethodInfoPtr_get_ColumnCount_Public_Abstract_Virtual_New_get_UInt32_0;

		// Token: 0x04004B2A RID: 19242
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionPriorityWeight_Public_Abstract_Virtual_New_get_UInt32_0;

		// Token: 0x04004B2B RID: 19243
		private static readonly IntPtr NativeMethodInfoPtr_GetSelections_Public_Abstract_Virtual_New_IEnumerable_1_Object_0;

		// Token: 0x04004B2C RID: 19244
		private static readonly IntPtr NativeMethodInfoPtr_CreateFilterConfig_Public_Abstract_Virtual_New_IFilterConfig_IReadOnlyList_1_Object_0;

		// Token: 0x04004B2D RID: 19245
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionText_Public_Abstract_Virtual_New_String_Object_0;

		// Token: 0x04004B2E RID: 19246
		private static readonly IntPtr NativeMethodInfoPtr_OnWillFilter_Public_Abstract_Virtual_New_Void_0;
	}
}
