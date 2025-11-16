using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;

namespace Common.UI.Filter
{
	// Token: 0x020003AB RID: 939
	public class IFilterConfig : Il2CppObjectBase
	{
		// Token: 0x06007116 RID: 28950 RVA: 0x00216F70 File Offset: 0x00215170
		// Note: this type is marked as 'beforefieldinit'.
		static IFilterConfig()
		{
			Il2CppClassPointerStore<IFilterConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "IFilterConfig");
			IFilterConfig.NativeMethodInfoPtr_get_SelectedElements_Public_Abstract_Virtual_New_get_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfig>.NativeClassPtr, 100686365);
			IFilterConfig.NativeMethodInfoPtr_get_FilterType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfig>.NativeClassPtr, 100686366);
			IFilterConfig.NativeMethodInfoPtr_get_Factory_Public_Abstract_Virtual_New_get_IFilterConfigFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfig>.NativeClassPtr, 100686367);
			IFilterConfig.NativeMethodInfoPtr_DoFilter_Public_Abstract_Virtual_New_IOrderedEnumerable_1_Object_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfig>.NativeClassPtr, 100686368);
			IFilterConfig.NativeMethodInfoPtr_DoFilter_Public_Abstract_Virtual_New_IOrderedEnumerable_1_Object_IOrderedEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfig>.NativeClassPtr, 100686369);
			IFilterConfig.NativeMethodInfoPtr_DoWhere_Public_Abstract_Virtual_New_IEnumerable_1_Object_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFilterConfig>.NativeClassPtr, 100686370);
		}

		// Token: 0x170026C6 RID: 9926
		// (get) Token: 0x06007117 RID: 28951 RVA: 0x00217010 File Offset: 0x00215210
		public unsafe virtual IEnumerable<Object> SelectedElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfig.NativeMethodInfoPtr_get_SelectedElements_Public_Abstract_Virtual_New_get_IEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x170026C7 RID: 9927
		// (get) Token: 0x06007118 RID: 28952 RVA: 0x0021705C File Offset: 0x0021525C
		public unsafe virtual IFilterConfig.Type FilterType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfig.NativeMethodInfoPtr_get_FilterType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026C8 RID: 9928
		// (get) Token: 0x06007119 RID: 28953 RVA: 0x002170A4 File Offset: 0x002152A4
		public unsafe virtual IFilterConfigFactory Factory
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfig.NativeMethodInfoPtr_get_Factory_Public_Abstract_Virtual_New_get_IFilterConfigFactory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFilterConfigFactory>(intPtr3) : null;
			}
		}

		// Token: 0x0600711A RID: 28954 RVA: 0x002170F0 File Offset: 0x002152F0
		[CallerCount(0)]
		public unsafe virtual IOrderedEnumerable<Object> DoFilter(IEnumerable<Object> objectsToFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectsToFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfig.NativeMethodInfoPtr_DoFilter_Public_Abstract_Virtual_New_IOrderedEnumerable_1_Object_IEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x0600711B RID: 28955 RVA: 0x0021714C File Offset: 0x0021534C
		[CallerCount(0)]
		public unsafe virtual IOrderedEnumerable<Object> DoFilter(IOrderedEnumerable<Object> objectsToFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectsToFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfig.NativeMethodInfoPtr_DoFilter_Public_Abstract_Virtual_New_IOrderedEnumerable_1_Object_IOrderedEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x0600711C RID: 28956 RVA: 0x002171A8 File Offset: 0x002153A8
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Object> DoWhere(IEnumerable<Object> objectsToFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectsToFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFilterConfig.NativeMethodInfoPtr_DoWhere_Public_Abstract_Virtual_New_IEnumerable_1_Object_IEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x0600711D RID: 28957 RVA: 0x0003D6A4 File Offset: 0x0003B8A4
		public IFilterConfig(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004AE2 RID: 19170
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedElements_Public_Abstract_Virtual_New_get_IEnumerable_1_Object_0;

		// Token: 0x04004AE3 RID: 19171
		private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04004AE4 RID: 19172
		private static readonly IntPtr NativeMethodInfoPtr_get_Factory_Public_Abstract_Virtual_New_get_IFilterConfigFactory_0;

		// Token: 0x04004AE5 RID: 19173
		private static readonly IntPtr NativeMethodInfoPtr_DoFilter_Public_Abstract_Virtual_New_IOrderedEnumerable_1_Object_IEnumerable_1_Object_0;

		// Token: 0x04004AE6 RID: 19174
		private static readonly IntPtr NativeMethodInfoPtr_DoFilter_Public_Abstract_Virtual_New_IOrderedEnumerable_1_Object_IOrderedEnumerable_1_Object_0;

		// Token: 0x04004AE7 RID: 19175
		private static readonly IntPtr NativeMethodInfoPtr_DoWhere_Public_Abstract_Virtual_New_IEnumerable_1_Object_IEnumerable_1_Object_0;

		// Token: 0x02000F03 RID: 3843
		public enum Type
		{
			// Token: 0x0400AAB8 RID: 43704
			Where,
			// Token: 0x0400AAB9 RID: 43705
			Order
		}
	}
}
