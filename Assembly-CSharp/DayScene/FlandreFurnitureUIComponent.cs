using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace DayScene
{
	// Token: 0x020000B4 RID: 180
	public class FlandreFurnitureUIComponent : MonoBehaviour
	{
		// Token: 0x06001369 RID: 4969 RVA: 0x000DFB58 File Offset: 0x000DDD58
		// Note: this type is marked as 'beforefieldinit'.
		static FlandreFurnitureUIComponent()
		{
			Il2CppClassPointerStore<FlandreFurnitureUIComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene", "FlandreFurnitureUIComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlandreFurnitureUIComponent>.NativeClassPtr);
			FlandreFurnitureUIComponent.NativeFieldInfoPtr_furnitureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreFurnitureUIComponent>.NativeClassPtr, "furnitureId");
			FlandreFurnitureUIComponent.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreFurnitureUIComponent>.NativeClassPtr, "button");
			FlandreFurnitureUIComponent.NativeFieldInfoPtr_m_PriceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreFurnitureUIComponent>.NativeClassPtr, "m_PriceText");
			FlandreFurnitureUIComponent.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlandreFurnitureUIComponent>.NativeClassPtr, "price");
			FlandreFurnitureUIComponent.NativeMethodInfoPtr_get_Price_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureUIComponent>.NativeClassPtr, 100666655);
			FlandreFurnitureUIComponent.NativeMethodInfoPtr_set_Price_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureUIComponent>.NativeClassPtr, 100666656);
			FlandreFurnitureUIComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureUIComponent>.NativeClassPtr, 100666657);
			FlandreFurnitureUIComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureUIComponent>.NativeClassPtr, 100666658);
			FlandreFurnitureUIComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlandreFurnitureUIComponent>.NativeClassPtr, 100666659);
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x000DFC3C File Offset: 0x000DDE3C
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x000DFC78 File Offset: 0x000DDE78
		public unsafe int Price
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53318, RefRangeEnd = 53319, XrefRangeStart = 53318, XrefRangeEnd = 53318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreFurnitureUIComponent.NativeMethodInfoPtr_get_Price_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53320, RefRangeEnd = 53321, XrefRangeStart = 53319, XrefRangeEnd = 53320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreFurnitureUIComponent.NativeMethodInfoPtr_set_Price_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x000DFCB8 File Offset: 0x000DDEB8
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreFurnitureUIComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x000DFCEC File Offset: 0x000DDEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53321, XrefRangeEnd = 53323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlandreFurnitureUIComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x000DFD28 File Offset: 0x000DDF28
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlandreFurnitureUIComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlandreFurnitureUIComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlandreFurnitureUIComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0000C3C9 File Offset: 0x0000A5C9
		public FlandreFurnitureUIComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x000DFD64 File Offset: 0x000DDF64
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x0000C3D2 File Offset: 0x0000A5D2
		public unsafe int furnitureId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureUIComponent.NativeFieldInfoPtr_furnitureId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureUIComponent.NativeFieldInfoPtr_furnitureId)) = value;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x000DFD8C File Offset: 0x000DDF8C
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x0000C3ED File Offset: 0x0000A5ED
		public unsafe UIButtonSimple button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureUIComponent.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureUIComponent.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x000DFDBC File Offset: 0x000DDFBC
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x0000C40C File Offset: 0x0000A60C
		public unsafe TextMeshProUGUI m_PriceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureUIComponent.NativeFieldInfoPtr_m_PriceText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureUIComponent.NativeFieldInfoPtr_m_PriceText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x000DFDEC File Offset: 0x000DDFEC
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x0000C42B File Offset: 0x0000A62B
		public unsafe int price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureUIComponent.NativeFieldInfoPtr_price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlandreFurnitureUIComponent.NativeFieldInfoPtr_price)) = value;
			}
		}

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeFieldInfoPtr_furnitureId;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeFieldInfoPtr_m_PriceText;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeFieldInfoPtr_price;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Int32_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_set_Price_Public_set_Void_Int32_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
