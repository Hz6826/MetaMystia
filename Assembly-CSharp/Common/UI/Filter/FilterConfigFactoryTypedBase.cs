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
	// Token: 0x020003B0 RID: 944
	public class FilterConfigFactoryTypedBase<TOrderingType, TSelectionType> : FilterConfigFactory<TOrderingType>
	{
		// Token: 0x0600713B RID: 28987 RVA: 0x00217B64 File Offset: 0x00215D64
		// Note: this type is marked as 'beforefieldinit'.
		static FilterConfigFactoryTypedBase()
		{
			Il2CppClassPointerStore<FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "FilterConfigFactoryTypedBase`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrderingType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSelectionType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>>.NativeClassPtr);
			FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Abstract_Virtual_New_IEnumerable_1_TSelectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>>.NativeClassPtr, 100686398);
			FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Abstract_Virtual_New_String_TSelectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>>.NativeClassPtr, 100686399);
			FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>.NativeMethodInfoPtr_GetSelections_Protected_Virtual_Final_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>>.NativeClassPtr, 100686400);
			FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>.NativeMethodInfoPtr_GetSelectionText_Protected_Virtual_Final_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>>.NativeClassPtr, 100686401);
			FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>>.NativeClassPtr, 100686402);
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x00217C48 File Offset: 0x00215E48
		[CallerCount(0)]
		public unsafe virtual IEnumerable<TSelectionType> GetSelectionsTyped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>.NativeMethodInfoPtr_GetSelectionsTyped_Protected_Abstract_Virtual_New_IEnumerable_1_TSelectionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSelectionType>>(intPtr3) : null;
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x00217C94 File Offset: 0x00215E94
		[CallerCount(0)]
		public unsafe virtual string GetSelectionTextTyped(TSelectionType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TSelectionType).IsValueType)
			{
				TSelectionType tselectionType = value;
				intPtr = ((tselectionType is string) ? IL2CPP.ManagedStringToIl2Cpp(tselectionType as string) : IL2CPP.Il2CppObjectBaseToPtr(tselectionType as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>.NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Abstract_Virtual_New_String_TSelectionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600713E RID: 28990 RVA: 0x00217D20 File Offset: 0x00215F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282054, XrefRangeEnd = 282060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Object> GetSelections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>.NativeMethodInfoPtr_GetSelections_Protected_Virtual_Final_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x0600713F RID: 28991 RVA: 0x00217D60 File Offset: 0x00215F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282060, XrefRangeEnd = 282067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSelectionText(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>.NativeMethodInfoPtr_GetSelectionText_Protected_Virtual_Final_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x00217DA8 File Offset: 0x00215FA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282067, RefRangeEnd = 282069, XrefRangeStart = 282067, XrefRangeEnd = 282067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterConfigFactoryTypedBase(uint selectionPriorityWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectionPriorityWeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigFactoryTypedBase<TOrderingType, TSelectionType>.NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x0003D702 File Offset: 0x0003B902
		public FilterConfigFactoryTypedBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004B00 RID: 19200
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionsTyped_Protected_Abstract_Virtual_New_IEnumerable_1_TSelectionType_0;

		// Token: 0x04004B01 RID: 19201
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionTextTyped_Protected_Abstract_Virtual_New_String_TSelectionType_0;

		// Token: 0x04004B02 RID: 19202
		private static readonly IntPtr NativeMethodInfoPtr_GetSelections_Protected_Virtual_Final_IEnumerable_1_Object_0;

		// Token: 0x04004B03 RID: 19203
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionText_Protected_Virtual_Final_String_Object_0;

		// Token: 0x04004B04 RID: 19204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_UInt32_0;
	}
}
