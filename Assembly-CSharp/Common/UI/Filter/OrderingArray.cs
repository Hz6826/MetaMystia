using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Common.UI.Filter
{
	// Token: 0x020003B2 RID: 946
	public static class OrderingArray : Object
	{
		// Token: 0x06007149 RID: 29001 RVA: 0x00218078 File Offset: 0x00216278
		// Note: this type is marked as 'beforefieldinit'.
		static OrderingArray()
		{
			Il2CppClassPointerStore<OrderingArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.Filter", "OrderingArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderingArray>.NativeClassPtr);
			OrderingArray.NativeFieldInfoPtr_Orders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingArray>.NativeClassPtr, "Orders");
			OrderingArray.NativeFieldInfoPtr_InvertedOrders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingArray>.NativeClassPtr, "InvertedOrders");
		}

		// Token: 0x0600714A RID: 29002 RVA: 0x0003D714 File Offset: 0x0003B914
		public OrderingArray(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026D3 RID: 9939
		// (get) Token: 0x0600714B RID: 29003 RVA: 0x002180D0 File Offset: 0x002162D0
		// (set) Token: 0x0600714C RID: 29004 RVA: 0x0003D71D File Offset: 0x0003B91D
		public unsafe static IReadOnlyList<Order> Orders
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OrderingArray.NativeFieldInfoPtr_Orders, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Order>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrderingArray.NativeFieldInfoPtr_Orders, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026D4 RID: 9940
		// (get) Token: 0x0600714D RID: 29005 RVA: 0x002180F8 File Offset: 0x002162F8
		// (set) Token: 0x0600714E RID: 29006 RVA: 0x0003D72F File Offset: 0x0003B92F
		public unsafe static IReadOnlyList<Order> InvertedOrders
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OrderingArray.NativeFieldInfoPtr_InvertedOrders, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Order>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrderingArray.NativeFieldInfoPtr_InvertedOrders, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B0A RID: 19210
		private static readonly IntPtr NativeFieldInfoPtr_Orders;

		// Token: 0x04004B0B RID: 19211
		private static readonly IntPtr NativeFieldInfoPtr_InvertedOrders;
	}
}
