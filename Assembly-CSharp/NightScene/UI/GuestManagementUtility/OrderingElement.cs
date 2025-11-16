using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene.GuestManagementUtility;
using NightScene.UI.HUDUtility;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.GuestManagementUtility
{
	// Token: 0x020001BC RID: 444
	public class OrderingElement : MonoBehaviour
	{
		// Token: 0x06003715 RID: 14101 RVA: 0x0015BAFC File Offset: 0x00159CFC
		// Note: this type is marked as 'beforefieldinit'.
		static OrderingElement()
		{
			Il2CppClassPointerStore<OrderingElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.GuestManagementUtility", "OrderingElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr);
			OrderingElement.NativeFieldInfoPtr_s_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "s_Property");
			OrderingElement.NativeFieldInfoPtr_ghostField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "ghostField");
			OrderingElement.NativeFieldInfoPtr_borderStyleImageForWaiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "borderStyleImageForWaiting");
			OrderingElement.NativeFieldInfoPtr_borderStyleImageForCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "borderStyleImageForCurrent");
			OrderingElement.NativeFieldInfoPtr_normalFoodFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "normalFoodFinished");
			OrderingElement.NativeFieldInfoPtr_normalBevFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "normalBevFinished");
			OrderingElement.NativeFieldInfoPtr_specFoodFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "specFoodFinished");
			OrderingElement.NativeFieldInfoPtr_specBevFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "specBevFinished");
			OrderingElement.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "animator");
			OrderingElement.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "text");
			OrderingElement.NativeFieldInfoPtr_layoutElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "layoutElement");
			OrderingElement.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "time");
			OrderingElement.NativeFieldInfoPtr_normalOrderElement_Food = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "normalOrderElement_Food");
			OrderingElement.NativeFieldInfoPtr_normalOrderElement_Bev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "normalOrderElement_Bev");
			OrderingElement.NativeFieldInfoPtr_specialOrderElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "specialOrderElement");
			OrderingElement.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "current");
			OrderingElement.NativeFieldInfoPtr_normalOrderElement_BevCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "normalOrderElement_BevCanvasGroup");
			OrderingElement.NativeFieldInfoPtr_normalOrderElement_FoodCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "normalOrderElement_FoodCanvasGroup");
			OrderingElement.NativeFieldInfoPtr_onSelfRemoveFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "onSelfRemoveFinish");
			OrderingElement.NativeFieldInfoPtr_onSetBevPartnerIndicatorCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "onSetBevPartnerIndicatorCallback");
			OrderingElement.NativeFieldInfoPtr_onSetFoodPartnerIndicatorCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "onSetFoodPartnerIndicatorCallback");
			OrderingElement.NativeFieldInfoPtr_shouldMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "shouldMove");
			OrderingElement.NativeFieldInfoPtr_specialOrderElementCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "specialOrderElementCanvasGroup");
			OrderingElement.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "velocity");
			OrderingElement.NativeFieldInfoPtr__ActiveOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, "<ActiveOrder>k__BackingField");
			OrderingElement.NativeMethodInfoPtr_get_ActiveOrder_Public_get_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673728);
			OrderingElement.NativeMethodInfoPtr_set_ActiveOrder_Public_set_Void_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673729);
			OrderingElement.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673730);
			OrderingElement.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673731);
			OrderingElement.NativeMethodInfoPtr_Initialize_Public_Void_OrderBase_Transform_Int32_Sprite_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673732);
			OrderingElement.NativeMethodInfoPtr_Out_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673733);
			OrderingElement.NativeMethodInfoPtr_DestroySelf_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673734);
			OrderingElement.NativeMethodInfoPtr_ChangeBorderStyle_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673735);
			OrderingElement.NativeMethodInfoPtr_SetPartnerHighlight_Public_Void_Sprite_SellableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673736);
			OrderingElement.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673737);
			OrderingElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673738);
			OrderingElement.NativeMethodInfoPtr__Initialize_b__30_0_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673740);
			OrderingElement.NativeMethodInfoPtr__Initialize_b__30_1_Private_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673741);
			OrderingElement.NativeMethodInfoPtr__Initialize_b__30_2_Private_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673742);
			OrderingElement.NativeMethodInfoPtr__Initialize_b__30_3_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr, 100673743);
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06003716 RID: 14102 RVA: 0x0015BE4C File Offset: 0x0015A04C
		// (set) Token: 0x06003717 RID: 14103 RVA: 0x0015BE8C File Offset: 0x0015A08C
		public unsafe GuestsManager.OrderBase ActiveOrder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 40645, RefRangeEnd = 40646, XrefRangeStart = 40645, XrefRangeEnd = 40646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr_get_ActiveOrder_Public_get_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr_set_ActiveOrder_Public_set_Void_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x0015BED0 File Offset: 0x0015A0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128717, XrefRangeEnd = 128733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x0015BF04 File Offset: 0x0015A104
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x0015BF38 File Offset: 0x0015A138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128817, RefRangeEnd = 128818, XrefRangeStart = 128733, XrefRangeEnd = 128817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(GuestsManager.OrderBase request, Transform ghostField, int deskCode, Sprite overridePic, Action onOutFinish)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ghostField);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deskCode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overridePic);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onOutFinish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr_Initialize_Public_Void_OrderBase_Transform_Int32_Sprite_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x0015BFC0 File Offset: 0x0015A1C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128824, RefRangeEnd = 128825, XrefRangeStart = 128818, XrefRangeEnd = 128824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Out()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr_Out_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x0015BFF4 File Offset: 0x0015A1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128825, XrefRangeEnd = 128830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroySelf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr_DestroySelf_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x0015C028 File Offset: 0x0015A228
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128837, RefRangeEnd = 128838, XrefRangeStart = 128830, XrefRangeEnd = 128837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeBorderStyle(bool current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr_ChangeBorderStyle_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x0015C068 File Offset: 0x0015A268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 128838, RefRangeEnd = 128840, XrefRangeStart = 128838, XrefRangeEnd = 128838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPartnerHighlight(Sprite visual, Sellable.SellableType sellableType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sellableType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr_SetPartnerHighlight_Public_Void_Sprite_SellableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x0015C0B8 File Offset: 0x0015A2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128840, XrefRangeEnd = 128860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrderingElement.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x0015C0F4 File Offset: 0x0015A2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128860, XrefRangeEnd = 128861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrderingElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderingElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x0015C130 File Offset: 0x0015A330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128861, XrefRangeEnd = 128870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__30_0(bool food, bool bev)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref food;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bev;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr__Initialize_b__30_0_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x0015C17C File Offset: 0x0015A37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128870, XrefRangeEnd = 128872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__30_1(Sprite x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr__Initialize_b__30_1_Private_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x0015C1C0 File Offset: 0x0015A3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128872, XrefRangeEnd = 128874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__30_2(Sprite x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr__Initialize_b__30_2_Private_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x0015C204 File Offset: 0x0015A404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128874, XrefRangeEnd = 128883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__30_3(bool food, bool bev)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref food;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bev;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderingElement.NativeMethodInfoPtr__Initialize_b__30_3_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x0001EA13 File Offset: 0x0001CC13
		public OrderingElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06003726 RID: 14118 RVA: 0x0015C250 File Offset: 0x0015A450
		// (set) Token: 0x06003727 RID: 14119 RVA: 0x0001EA1C File Offset: 0x0001CC1C
		public unsafe static int s_Property
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(OrderingElement.NativeFieldInfoPtr_s_Property, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrderingElement.NativeFieldInfoPtr_s_Property, (void*)(&value));
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06003728 RID: 14120 RVA: 0x0015C26C File Offset: 0x0015A46C
		// (set) Token: 0x06003729 RID: 14121 RVA: 0x0001EA2A File Offset: 0x0001CC2A
		public unsafe Transform ghostField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_ghostField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_ghostField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x0600372A RID: 14122 RVA: 0x0015C29C File Offset: 0x0015A49C
		// (set) Token: 0x0600372B RID: 14123 RVA: 0x0001EA49 File Offset: 0x0001CC49
		public unsafe Image borderStyleImageForWaiting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_borderStyleImageForWaiting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_borderStyleImageForWaiting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x0600372C RID: 14124 RVA: 0x0015C2CC File Offset: 0x0015A4CC
		// (set) Token: 0x0600372D RID: 14125 RVA: 0x0001EA68 File Offset: 0x0001CC68
		public unsafe Image borderStyleImageForCurrent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_borderStyleImageForCurrent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_borderStyleImageForCurrent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x0600372E RID: 14126 RVA: 0x0015C2FC File Offset: 0x0015A4FC
		// (set) Token: 0x0600372F RID: 14127 RVA: 0x0001EA87 File Offset: 0x0001CC87
		public unsafe Image normalFoodFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_normalFoodFinished);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_normalFoodFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06003730 RID: 14128 RVA: 0x0015C32C File Offset: 0x0015A52C
		// (set) Token: 0x06003731 RID: 14129 RVA: 0x0001EAA6 File Offset: 0x0001CCA6
		public unsafe Image normalBevFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_normalBevFinished);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_normalBevFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06003732 RID: 14130 RVA: 0x0015C35C File Offset: 0x0015A55C
		// (set) Token: 0x06003733 RID: 14131 RVA: 0x0001EAC5 File Offset: 0x0001CCC5
		public unsafe Image specFoodFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_specFoodFinished);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_specFoodFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06003734 RID: 14132 RVA: 0x0015C38C File Offset: 0x0015A58C
		// (set) Token: 0x06003735 RID: 14133 RVA: 0x0001EAE4 File Offset: 0x0001CCE4
		public unsafe Image specBevFinished
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_specBevFinished);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_specBevFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06003736 RID: 14134 RVA: 0x0015C3BC File Offset: 0x0015A5BC
		// (set) Token: 0x06003737 RID: 14135 RVA: 0x0001EB03 File Offset: 0x0001CD03
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06003738 RID: 14136 RVA: 0x0015C3EC File Offset: 0x0015A5EC
		// (set) Token: 0x06003739 RID: 14137 RVA: 0x0001EB22 File Offset: 0x0001CD22
		public unsafe TextMeshProUGUI text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x0600373A RID: 14138 RVA: 0x0015C41C File Offset: 0x0015A61C
		// (set) Token: 0x0600373B RID: 14139 RVA: 0x0001EB41 File Offset: 0x0001CD41
		public unsafe LayoutElement layoutElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_layoutElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_layoutElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x0600373C RID: 14140 RVA: 0x0015C44C File Offset: 0x0015A64C
		// (set) Token: 0x0600373D RID: 14141 RVA: 0x0001EB60 File Offset: 0x0001CD60
		public unsafe float time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x0600373E RID: 14142 RVA: 0x0015C474 File Offset: 0x0015A674
		// (set) Token: 0x0600373F RID: 14143 RVA: 0x0001EB7B File Offset: 0x0001CD7B
		public unsafe DisplayedOrderElement normalOrderElement_Food
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_normalOrderElement_Food);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayedOrderElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_normalOrderElement_Food), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06003740 RID: 14144 RVA: 0x0015C4A4 File Offset: 0x0015A6A4
		// (set) Token: 0x06003741 RID: 14145 RVA: 0x0001EB9A File Offset: 0x0001CD9A
		public unsafe DisplayedOrderElement normalOrderElement_Bev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_normalOrderElement_Bev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayedOrderElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_normalOrderElement_Bev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06003742 RID: 14146 RVA: 0x0015C4D4 File Offset: 0x0015A6D4
		// (set) Token: 0x06003743 RID: 14147 RVA: 0x0001EBB9 File Offset: 0x0001CDB9
		public unsafe DisplayedOrderElement specialOrderElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_specialOrderElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayedOrderElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_specialOrderElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06003744 RID: 14148 RVA: 0x0015C504 File Offset: 0x0015A704
		// (set) Token: 0x06003745 RID: 14149 RVA: 0x0001EBD8 File Offset: 0x0001CDD8
		public unsafe bool current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_current)) = value;
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06003746 RID: 14150 RVA: 0x0015C52C File Offset: 0x0015A72C
		// (set) Token: 0x06003747 RID: 14151 RVA: 0x0001EBF3 File Offset: 0x0001CDF3
		public unsafe CanvasGroup normalOrderElement_BevCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_normalOrderElement_BevCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_normalOrderElement_BevCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06003748 RID: 14152 RVA: 0x0015C55C File Offset: 0x0015A75C
		// (set) Token: 0x06003749 RID: 14153 RVA: 0x0001EC12 File Offset: 0x0001CE12
		public unsafe CanvasGroup normalOrderElement_FoodCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_normalOrderElement_FoodCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_normalOrderElement_FoodCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x0600374A RID: 14154 RVA: 0x0015C58C File Offset: 0x0015A78C
		// (set) Token: 0x0600374B RID: 14155 RVA: 0x0001EC31 File Offset: 0x0001CE31
		public unsafe Action onSelfRemoveFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_onSelfRemoveFinish);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_onSelfRemoveFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x0600374C RID: 14156 RVA: 0x0015C5BC File Offset: 0x0015A7BC
		// (set) Token: 0x0600374D RID: 14157 RVA: 0x0001EC50 File Offset: 0x0001CE50
		public unsafe Action<Sprite> onSetBevPartnerIndicatorCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_onSetBevPartnerIndicatorCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_onSetBevPartnerIndicatorCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x0015C5EC File Offset: 0x0015A7EC
		// (set) Token: 0x0600374F RID: 14159 RVA: 0x0001EC6F File Offset: 0x0001CE6F
		public unsafe Action<Sprite> onSetFoodPartnerIndicatorCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_onSetFoodPartnerIndicatorCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_onSetFoodPartnerIndicatorCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06003750 RID: 14160 RVA: 0x0015C61C File Offset: 0x0015A81C
		// (set) Token: 0x06003751 RID: 14161 RVA: 0x0001EC8E File Offset: 0x0001CE8E
		public unsafe bool shouldMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_shouldMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_shouldMove)) = value;
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x0015C644 File Offset: 0x0015A844
		// (set) Token: 0x06003753 RID: 14163 RVA: 0x0001ECA9 File Offset: 0x0001CEA9
		public unsafe CanvasGroup specialOrderElementCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_specialOrderElementCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_specialOrderElementCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06003754 RID: 14164 RVA: 0x0015C674 File Offset: 0x0015A874
		// (set) Token: 0x06003755 RID: 14165 RVA: 0x0001ECC8 File Offset: 0x0001CEC8
		public unsafe Vector3 velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr_velocity)) = value;
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06003756 RID: 14166 RVA: 0x0015C69C File Offset: 0x0015A89C
		// (set) Token: 0x06003757 RID: 14167 RVA: 0x0001ECE3 File Offset: 0x0001CEE3
		public unsafe GuestsManager.OrderBase _ActiveOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr__ActiveOrder_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderingElement.NativeFieldInfoPtr__ActiveOrder_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002534 RID: 9524
		private static readonly IntPtr NativeFieldInfoPtr_s_Property;

		// Token: 0x04002535 RID: 9525
		private static readonly IntPtr NativeFieldInfoPtr_ghostField;

		// Token: 0x04002536 RID: 9526
		private static readonly IntPtr NativeFieldInfoPtr_borderStyleImageForWaiting;

		// Token: 0x04002537 RID: 9527
		private static readonly IntPtr NativeFieldInfoPtr_borderStyleImageForCurrent;

		// Token: 0x04002538 RID: 9528
		private static readonly IntPtr NativeFieldInfoPtr_normalFoodFinished;

		// Token: 0x04002539 RID: 9529
		private static readonly IntPtr NativeFieldInfoPtr_normalBevFinished;

		// Token: 0x0400253A RID: 9530
		private static readonly IntPtr NativeFieldInfoPtr_specFoodFinished;

		// Token: 0x0400253B RID: 9531
		private static readonly IntPtr NativeFieldInfoPtr_specBevFinished;

		// Token: 0x0400253C RID: 9532
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x0400253D RID: 9533
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400253E RID: 9534
		private static readonly IntPtr NativeFieldInfoPtr_layoutElement;

		// Token: 0x0400253F RID: 9535
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04002540 RID: 9536
		private static readonly IntPtr NativeFieldInfoPtr_normalOrderElement_Food;

		// Token: 0x04002541 RID: 9537
		private static readonly IntPtr NativeFieldInfoPtr_normalOrderElement_Bev;

		// Token: 0x04002542 RID: 9538
		private static readonly IntPtr NativeFieldInfoPtr_specialOrderElement;

		// Token: 0x04002543 RID: 9539
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04002544 RID: 9540
		private static readonly IntPtr NativeFieldInfoPtr_normalOrderElement_BevCanvasGroup;

		// Token: 0x04002545 RID: 9541
		private static readonly IntPtr NativeFieldInfoPtr_normalOrderElement_FoodCanvasGroup;

		// Token: 0x04002546 RID: 9542
		private static readonly IntPtr NativeFieldInfoPtr_onSelfRemoveFinish;

		// Token: 0x04002547 RID: 9543
		private static readonly IntPtr NativeFieldInfoPtr_onSetBevPartnerIndicatorCallback;

		// Token: 0x04002548 RID: 9544
		private static readonly IntPtr NativeFieldInfoPtr_onSetFoodPartnerIndicatorCallback;

		// Token: 0x04002549 RID: 9545
		private static readonly IntPtr NativeFieldInfoPtr_shouldMove;

		// Token: 0x0400254A RID: 9546
		private static readonly IntPtr NativeFieldInfoPtr_specialOrderElementCanvasGroup;

		// Token: 0x0400254B RID: 9547
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x0400254C RID: 9548
		private static readonly IntPtr NativeFieldInfoPtr__ActiveOrder_k__BackingField;

		// Token: 0x0400254D RID: 9549
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveOrder_Public_get_OrderBase_0;

		// Token: 0x0400254E RID: 9550
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveOrder_Public_set_Void_OrderBase_0;

		// Token: 0x0400254F RID: 9551
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002550 RID: 9552
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002551 RID: 9553
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_OrderBase_Transform_Int32_Sprite_Action_0;

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeMethodInfoPtr_Out_Public_Void_0;

		// Token: 0x04002553 RID: 9555
		private static readonly IntPtr NativeMethodInfoPtr_DestroySelf_Public_Void_0;

		// Token: 0x04002554 RID: 9556
		private static readonly IntPtr NativeMethodInfoPtr_ChangeBorderStyle_Public_Void_Boolean_0;

		// Token: 0x04002555 RID: 9557
		private static readonly IntPtr NativeMethodInfoPtr_SetPartnerHighlight_Public_Void_Sprite_SellableType_0;

		// Token: 0x04002556 RID: 9558
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002557 RID: 9559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002558 RID: 9560
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__30_0_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002559 RID: 9561
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__30_1_Private_Void_Sprite_0;

		// Token: 0x0400255A RID: 9562
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__30_2_Private_Void_Sprite_0;

		// Token: 0x0400255B RID: 9563
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__30_3_Private_Void_Boolean_Boolean_0;
	}
}
