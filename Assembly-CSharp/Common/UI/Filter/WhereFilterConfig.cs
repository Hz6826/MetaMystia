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
	// Token: 0x020003AF RID: 943
	public class WhereFilterConfig<T> : BaseFilterConfig
	{
		// Token: 0x06007134 RID: 28980 RVA: 0x002178DC File Offset: 0x00215ADC
		// Note: this type is marked as 'beforefieldinit'.
		static WhereFilterConfig()
		{
			Il2CppClassPointerStore<WhereFilterConfig<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "WhereFilterConfig`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WhereFilterConfig<T>>.NativeClassPtr);
			WhereFilterConfig<T>.NativeMethodInfoPtr__ctor_Protected_Void_IFilterConfigFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhereFilterConfig<T>>.NativeClassPtr, 100686393);
			WhereFilterConfig<T>.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhereFilterConfig<T>>.NativeClassPtr, 100686394);
			WhereFilterConfig<T>.NativeMethodInfoPtr_OnWhere_Protected_Abstract_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhereFilterConfig<T>>.NativeClassPtr, 100686395);
			WhereFilterConfig<T>.NativeMethodInfoPtr_InternalWhereSelector_Private_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhereFilterConfig<T>>.NativeClassPtr, 100686396);
			WhereFilterConfig<T>.NativeMethodInfoPtr_DoWhere_Public_Virtual_Final_IEnumerable_1_Object_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WhereFilterConfig<T>>.NativeClassPtr, 100686397);
		}

		// Token: 0x06007135 RID: 28981 RVA: 0x002179AC File Offset: 0x00215BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282036, XrefRangeEnd = 282042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WhereFilterConfig(IFilterConfigFactory factory) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WhereFilterConfig<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhereFilterConfig<T>.NativeMethodInfoPtr__ctor_Protected_Void_IFilterConfigFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170026D0 RID: 9936
		// (get) Token: 0x06007136 RID: 28982 RVA: 0x002179F8 File Offset: 0x00215BF8
		public unsafe override IFilterConfig.Type FilterType
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhereFilterConfig<T>.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x00217A34 File Offset: 0x00215C34
		[CallerCount(0)]
		public unsafe virtual bool OnWhere(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WhereFilterConfig<T>.NativeMethodInfoPtr_OnWhere_Protected_Abstract_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x00217AC4 File Offset: 0x00215CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282042, XrefRangeEnd = 282046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalWhereSelector(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhereFilterConfig<T>.NativeMethodInfoPtr_InternalWhereSelector_Private_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007139 RID: 28985 RVA: 0x00217B14 File Offset: 0x00215D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282046, XrefRangeEnd = 282054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Object> DoWhere(IEnumerable<Object> objectsToFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectsToFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WhereFilterConfig<T>.NativeMethodInfoPtr_DoWhere_Public_Virtual_Final_IEnumerable_1_Object_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x0600713A RID: 28986 RVA: 0x0003D6F9 File Offset: 0x0003B8F9
		public WhereFilterConfig(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004AFB RID: 19195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IFilterConfigFactory_0;

		// Token: 0x04004AFC RID: 19196
		private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_Type_0;

		// Token: 0x04004AFD RID: 19197
		private static readonly IntPtr NativeMethodInfoPtr_OnWhere_Protected_Abstract_Virtual_New_Boolean_T_0;

		// Token: 0x04004AFE RID: 19198
		private static readonly IntPtr NativeMethodInfoPtr_InternalWhereSelector_Private_Boolean_Object_0;

		// Token: 0x04004AFF RID: 19199
		private static readonly IntPtr NativeMethodInfoPtr_DoWhere_Public_Virtual_Final_IEnumerable_1_Object_IEnumerable_1_Object_0;
	}
}
