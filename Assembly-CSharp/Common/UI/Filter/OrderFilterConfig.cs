using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;

namespace Common.UI.Filter
{
	// Token: 0x020003AE RID: 942
	public class OrderFilterConfig<TOrderingElement, TFocusingElement> : BaseFilterConfig
	{
		// Token: 0x06007129 RID: 28969 RVA: 0x00217538 File Offset: 0x00215738
		// Note: this type is marked as 'beforefieldinit'.
		static OrderFilterConfig()
		{
			Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "OrderFilterConfig`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrderingElement>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFocusingElement>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>>.NativeClassPtr);
			OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeFieldInfoPtr_m_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>>.NativeClassPtr, "m_Order");
			OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr__ctor_Protected_Void_IFilterConfigFactory_Order_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>>.NativeClassPtr, 100686378);
			OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>>.NativeClassPtr, 100686379);
			OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr_get_SelectedElements_Public_Virtual_get_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>>.NativeClassPtr, 100686380);
			OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr_DoFilter_Public_Virtual_Final_IOrderedEnumerable_1_Object_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>>.NativeClassPtr, 100686381);
			OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr_DoFilter_Public_Virtual_Final_IOrderedEnumerable_1_Object_IOrderedEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>>.NativeClassPtr, 100686382);
			OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr_InternalValueSelector_Private_TFocusingElement_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>>.NativeClassPtr, 100686383);
			OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr_GetFocusingElement_Protected_Abstract_Virtual_New_TFocusingElement_TOrderingElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>>.NativeClassPtr, 100686384);
		}

		// Token: 0x0600712A RID: 28970 RVA: 0x00217658 File Offset: 0x00215858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282016, XrefRangeEnd = 282017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrderFilterConfig(IFilterConfigFactory factory, Order order) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref order;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr__ctor_Protected_Void_IFilterConfigFactory_Order_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170026CE RID: 9934
		// (get) Token: 0x0600712B RID: 28971 RVA: 0x002176B4 File Offset: 0x002158B4
		public unsafe override IFilterConfig.Type FilterType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026CF RID: 9935
		// (get) Token: 0x0600712C RID: 28972 RVA: 0x002176F0 File Offset: 0x002158F0
		public unsafe override IEnumerable<Object> SelectedElements
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282017, XrefRangeEnd = 282020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr_get_SelectedElements_Public_Virtual_get_IEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600712D RID: 28973 RVA: 0x0021773C File Offset: 0x0021593C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282020, XrefRangeEnd = 282026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IOrderedEnumerable<Object> DoFilter(IEnumerable<Object> objectsToFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectsToFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr_DoFilter_Public_Virtual_Final_IOrderedEnumerable_1_Object_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x0600712E RID: 28974 RVA: 0x0021778C File Offset: 0x0021598C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282026, XrefRangeEnd = 282032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IOrderedEnumerable<Object> DoFilter(IOrderedEnumerable<Object> objectsToFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectsToFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr_DoFilter_Public_Virtual_Final_IOrderedEnumerable_1_Object_IOrderedEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<Object>>(intPtr3) : null;
		}

		// Token: 0x0600712F RID: 28975 RVA: 0x002177DC File Offset: 0x002159DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282032, XrefRangeEnd = 282036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TFocusingElement InternalValueSelector(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr_InternalValueSelector_Private_TFocusingElement_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TFocusingElement>(intPtr, false, true);
		}

		// Token: 0x06007130 RID: 28976 RVA: 0x00217828 File Offset: 0x00215A28
		[CallerCount(0)]
		public unsafe virtual TFocusingElement GetFocusingElement(TOrderingElement orderingElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TOrderingElement).IsValueType)
			{
				TOrderingElement torderingElement = orderingElement;
				intPtr = ((torderingElement is string) ? IL2CPP.ManagedStringToIl2Cpp(torderingElement as string) : IL2CPP.Il2CppObjectBaseToPtr(torderingElement as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref orderingElement;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeMethodInfoPtr_GetFocusingElement_Protected_Abstract_Virtual_New_TFocusingElement_TOrderingElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TFocusingElement>(intPtr2, false, true);
		}

		// Token: 0x06007131 RID: 28977 RVA: 0x0003D6D5 File Offset: 0x0003B8D5
		public OrderFilterConfig(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026CD RID: 9933
		// (get) Token: 0x06007132 RID: 28978 RVA: 0x002178B4 File Offset: 0x00215AB4
		// (set) Token: 0x06007133 RID: 28979 RVA: 0x0003D6DE File Offset: 0x0003B8DE
		public unsafe Order m_Order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeFieldInfoPtr_m_Order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderFilterConfig<TOrderingElement, TFocusingElement>.NativeFieldInfoPtr_m_Order)) = value;
			}
		}

		// Token: 0x04004AF3 RID: 19187
		private static readonly IntPtr NativeFieldInfoPtr_m_Order;

		// Token: 0x04004AF4 RID: 19188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IFilterConfigFactory_Order_0;

		// Token: 0x04004AF5 RID: 19189
		private static readonly IntPtr NativeMethodInfoPtr_get_FilterType_Public_Virtual_Final_get_Type_0;

		// Token: 0x04004AF6 RID: 19190
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedElements_Public_Virtual_get_IEnumerable_1_Object_0;

		// Token: 0x04004AF7 RID: 19191
		private static readonly IntPtr NativeMethodInfoPtr_DoFilter_Public_Virtual_Final_IOrderedEnumerable_1_Object_IEnumerable_1_Object_0;

		// Token: 0x04004AF8 RID: 19192
		private static readonly IntPtr NativeMethodInfoPtr_DoFilter_Public_Virtual_Final_IOrderedEnumerable_1_Object_IOrderedEnumerable_1_Object_0;

		// Token: 0x04004AF9 RID: 19193
		private static readonly IntPtr NativeMethodInfoPtr_InternalValueSelector_Private_TFocusingElement_Object_0;

		// Token: 0x04004AFA RID: 19194
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusingElement_Protected_Abstract_Virtual_New_TFocusingElement_TOrderingElement_0;

		// Token: 0x02000F04 RID: 3844
		[ObfuscatedName("Common.UI.Filter.OrderFilterConfig`2+<get_SelectedElements>d__5")]
		public sealed class _get_SelectedElements_d__5 : Object
		{
			// Token: 0x06010DFC RID: 69116 RVA: 0x003E664C File Offset: 0x003E484C
			// Note: this type is marked as 'beforefieldinit'.
			static _get_SelectedElements_d__5()
			{
				Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>>.NativeClassPtr, "<get_SelectedElements>d__5"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOrderingElement>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFocusingElement>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr);
				OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr, "<>1__state");
				OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr, "<>2__current");
				OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr, "<>l__initialThreadId");
				OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr, "<>4__this");
				OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr, 100686385);
				OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr, 100686386);
				OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr, 100686387);
				OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr, 100686388);
				OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr, 100686389);
				OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr, 100686390);
				OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr, 100686391);
				OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr, 100686392);
			}

			// Token: 0x06010DFD RID: 69117 RVA: 0x003E67B4 File Offset: 0x003E49B4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 39842, RefRangeEnd = 39844, XrefRangeStart = 39842, XrefRangeEnd = 39844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_SelectedElements_d__5(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DFE RID: 69118 RVA: 0x003E67FC File Offset: 0x003E49FC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010DFF RID: 69119 RVA: 0x003E6830 File Offset: 0x003E4A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282003, XrefRangeEnd = 282007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170057DE RID: 22494
			// (get) Token: 0x06010E00 RID: 69120 RVA: 0x003E686C File Offset: 0x003E4A6C
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06010E01 RID: 69121 RVA: 0x003E68AC File Offset: 0x003E4AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282007, XrefRangeEnd = 282013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170057DF RID: 22495
			// (get) Token: 0x06010E02 RID: 69122 RVA: 0x003E68E0 File Offset: 0x003E4AE0
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06010E03 RID: 69123 RVA: 0x003E6920 File Offset: 0x003E4B20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282013, XrefRangeEnd = 282014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Object> System_Collections_Generic_IEnumerable_System_Object__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Object>>(intPtr3) : null;
			}

			// Token: 0x06010E04 RID: 69124 RVA: 0x003E6960 File Offset: 0x003E4B60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282014, XrefRangeEnd = 282016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06010E05 RID: 69125 RVA: 0x00092FC2 File Offset: 0x000911C2
			public _get_SelectedElements_d__5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170057DA RID: 22490
			// (get) Token: 0x06010E06 RID: 69126 RVA: 0x003E69A0 File Offset: 0x003E4BA0
			// (set) Token: 0x06010E07 RID: 69127 RVA: 0x00092FCB File Offset: 0x000911CB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170057DB RID: 22491
			// (get) Token: 0x06010E08 RID: 69128 RVA: 0x003E69C8 File Offset: 0x003E4BC8
			// (set) Token: 0x06010E09 RID: 69129 RVA: 0x00092FE6 File Offset: 0x000911E6
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170057DC RID: 22492
			// (get) Token: 0x06010E0A RID: 69130 RVA: 0x003E69F8 File Offset: 0x003E4BF8
			// (set) Token: 0x06010E0B RID: 69131 RVA: 0x00093005 File Offset: 0x00091205
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170057DD RID: 22493
			// (get) Token: 0x06010E0C RID: 69132 RVA: 0x003E6A20 File Offset: 0x003E4C20
			// (set) Token: 0x06010E0D RID: 69133 RVA: 0x00093020 File Offset: 0x00091220
			public unsafe OrderFilterConfig<TOrderingElement, TFocusingElement> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrderFilterConfig<TOrderingElement, TFocusingElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderFilterConfig<TOrderingElement, TFocusingElement>._get_SelectedElements_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AABA RID: 43706
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AABB RID: 43707
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400AABC RID: 43708
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400AABD RID: 43709
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AABE RID: 43710
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400AABF RID: 43711
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AAC0 RID: 43712
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400AAC1 RID: 43713
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400AAC2 RID: 43714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AAC3 RID: 43715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400AAC4 RID: 43716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0;

			// Token: 0x0400AAC5 RID: 43717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
