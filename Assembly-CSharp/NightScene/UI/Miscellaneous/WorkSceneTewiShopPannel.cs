using System;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.Common.AchievementSystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.Miscellaneous
{
	// Token: 0x020001BB RID: 443
	public class WorkSceneTewiShopPannel : UIPanel
	{
		// Token: 0x060036C7 RID: 14023 RVA: 0x0015AE1C File Offset: 0x0015901C
		// Note: this type is marked as 'beforefieldinit'.
		static WorkSceneTewiShopPannel()
		{
			Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.Miscellaneous", "WorkSceneTewiShopPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr);
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_item1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "item1");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_item2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "item2");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_item3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "item3");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_image1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "image1");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_image2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "image2");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_image3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "image3");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "describer");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_describerSwitcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "describerSwitcher");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_indicator1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "indicator1");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_indicator2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "indicator2");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_indicator3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "indicator3");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_price1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "price1");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_price2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "price2");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_price3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "price3");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_count1A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "count1A");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_count2A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "count2A");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_count3A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "count3A");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_count1B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "count1B");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_count2B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "count2B");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_count3B = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "count3B");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_inStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "inStorage");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_buy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "buy");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "cancel");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_priceRemains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "priceRemains");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_priceTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "priceTotal");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_OnBuyAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "OnBuyAudio");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_cart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "cart");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr_priceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "priceMultiplier");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr__IsCheating_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "<IsCheating>k__BackingField");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr__HaveBought_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "<HaveBought>k__BackingField");
			WorkSceneTewiShopPannel.NativeFieldInfoPtr__OpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "<OpenContext>k__BackingField");
			WorkSceneTewiShopPannel.NativeMethodInfoPtr_get_Price_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673694);
			WorkSceneTewiShopPannel.NativeMethodInfoPtr_get_IsCheating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673695);
			WorkSceneTewiShopPannel.NativeMethodInfoPtr_set_IsCheating_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673696);
			WorkSceneTewiShopPannel.NativeMethodInfoPtr_get_HaveBought_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673697);
			WorkSceneTewiShopPannel.NativeMethodInfoPtr_set_HaveBought_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673698);
			WorkSceneTewiShopPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_PannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673699);
			WorkSceneTewiShopPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673700);
			WorkSceneTewiShopPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673701);
			WorkSceneTewiShopPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673702);
			WorkSceneTewiShopPannel.NativeMethodInfoPtr_GetPlayerFund_Private_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673703);
			WorkSceneTewiShopPannel.NativeMethodInfoPtr_DeductPlayerFund_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673704);
			WorkSceneTewiShopPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673705);
			WorkSceneTewiShopPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673706);
			WorkSceneTewiShopPannel.NativeMethodInfoPtr__get_Price_b__29_0_Private_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, 100673707);
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x060036C8 RID: 14024 RVA: 0x0015B1D0 File Offset: 0x001593D0
		public unsafe int Price
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 128523, RefRangeEnd = 128528, XrefRangeStart = 128495, XrefRangeEnd = 128523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.NativeMethodInfoPtr_get_Price_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x060036C9 RID: 14025 RVA: 0x0015B20C File Offset: 0x0015940C
		// (set) Token: 0x060036CA RID: 14026 RVA: 0x0015B248 File Offset: 0x00159448
		public unsafe bool IsCheating
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.NativeMethodInfoPtr_get_IsCheating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.NativeMethodInfoPtr_set_IsCheating_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x060036CB RID: 14027 RVA: 0x0015B288 File Offset: 0x00159488
		// (set) Token: 0x060036CC RID: 14028 RVA: 0x0015B2C4 File Offset: 0x001594C4
		public unsafe bool HaveBought
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.NativeMethodInfoPtr_get_HaveBought_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.NativeMethodInfoPtr_set_HaveBought_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x060036CD RID: 14029 RVA: 0x0015B304 File Offset: 0x00159504
		// (set) Token: 0x060036CE RID: 14030 RVA: 0x0015B33C File Offset: 0x0015953C
		public unsafe Nullable<WorkSceneTewiShopPannel.PannelOpenContext> OpenContext
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_PannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<WorkSceneTewiShopPannel.PannelOpenContext>(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128528, XrefRangeEnd = 128529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x0015B384 File Offset: 0x00159584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128529, XrefRangeEnd = 128540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneTewiShopPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x0015B3C0 File Offset: 0x001595C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128540, XrefRangeEnd = 128658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneTewiShopPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x0015B3FC File Offset: 0x001595FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 128664, RefRangeEnd = 128666, XrefRangeStart = 128658, XrefRangeEnd = 128664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetPlayerFund()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.NativeMethodInfoPtr_GetPlayerFund_Private_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x0015B438 File Offset: 0x00159638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128666, XrefRangeEnd = 128677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeductPlayerFund(int price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.NativeMethodInfoPtr_DeductPlayerFund_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x0015B478 File Offset: 0x00159678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128677, XrefRangeEnd = 128707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorkSceneTewiShopPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x0015B4B4 File Offset: 0x001596B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128707, XrefRangeEnd = 128716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkSceneTewiShopPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x0015B4F0 File Offset: 0x001596F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128716, XrefRangeEnd = 128717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _get_Price_b__29_0(Product x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.NativeMethodInfoPtr__get_Price_b__29_0_Private_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036D6 RID: 14038 RVA: 0x0001E646 File Offset: 0x0001C846
		public WorkSceneTewiShopPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x060036D7 RID: 14039 RVA: 0x0015B544 File Offset: 0x00159744
		// (set) Token: 0x060036D8 RID: 14040 RVA: 0x0001E64F File Offset: 0x0001C84F
		public unsafe UIButtonSimple item1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_item1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_item1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x060036D9 RID: 14041 RVA: 0x0015B574 File Offset: 0x00159774
		// (set) Token: 0x060036DA RID: 14042 RVA: 0x0001E66E File Offset: 0x0001C86E
		public unsafe UIButtonSimple item2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_item2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_item2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x060036DB RID: 14043 RVA: 0x0015B5A4 File Offset: 0x001597A4
		// (set) Token: 0x060036DC RID: 14044 RVA: 0x0001E68D File Offset: 0x0001C88D
		public unsafe UIButtonSimple item3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_item3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_item3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x060036DD RID: 14045 RVA: 0x0015B5D4 File Offset: 0x001597D4
		// (set) Token: 0x060036DE RID: 14046 RVA: 0x0001E6AC File Offset: 0x0001C8AC
		public unsafe Image image1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_image1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_image1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x060036DF RID: 14047 RVA: 0x0015B604 File Offset: 0x00159804
		// (set) Token: 0x060036E0 RID: 14048 RVA: 0x0001E6CB File Offset: 0x0001C8CB
		public unsafe Image image2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_image2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_image2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x060036E1 RID: 14049 RVA: 0x0015B634 File Offset: 0x00159834
		// (set) Token: 0x060036E2 RID: 14050 RVA: 0x0001E6EA File Offset: 0x0001C8EA
		public unsafe Image image3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_image3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_image3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x060036E3 RID: 14051 RVA: 0x0015B664 File Offset: 0x00159864
		// (set) Token: 0x060036E4 RID: 14052 RVA: 0x0001E709 File Offset: 0x0001C909
		public unsafe SellableDescriber describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x060036E5 RID: 14053 RVA: 0x0015B694 File Offset: 0x00159894
		// (set) Token: 0x060036E6 RID: 14054 RVA: 0x0001E728 File Offset: 0x0001C928
		public unsafe DescriberSwitcher describerSwitcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_describerSwitcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DescriberSwitcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_describerSwitcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x060036E7 RID: 14055 RVA: 0x0015B6C4 File Offset: 0x001598C4
		// (set) Token: 0x060036E8 RID: 14056 RVA: 0x0001E747 File Offset: 0x0001C947
		public unsafe GameObject indicator1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_indicator1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_indicator1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x060036E9 RID: 14057 RVA: 0x0015B6F4 File Offset: 0x001598F4
		// (set) Token: 0x060036EA RID: 14058 RVA: 0x0001E766 File Offset: 0x0001C966
		public unsafe GameObject indicator2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_indicator2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_indicator2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x060036EB RID: 14059 RVA: 0x0015B724 File Offset: 0x00159924
		// (set) Token: 0x060036EC RID: 14060 RVA: 0x0001E785 File Offset: 0x0001C985
		public unsafe GameObject indicator3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_indicator3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_indicator3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x060036ED RID: 14061 RVA: 0x0015B754 File Offset: 0x00159954
		// (set) Token: 0x060036EE RID: 14062 RVA: 0x0001E7A4 File Offset: 0x0001C9A4
		public unsafe TextMeshProUGUI price1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_price1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_price1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x060036EF RID: 14063 RVA: 0x0015B784 File Offset: 0x00159984
		// (set) Token: 0x060036F0 RID: 14064 RVA: 0x0001E7C3 File Offset: 0x0001C9C3
		public unsafe TextMeshProUGUI price2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_price2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_price2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x060036F1 RID: 14065 RVA: 0x0015B7B4 File Offset: 0x001599B4
		// (set) Token: 0x060036F2 RID: 14066 RVA: 0x0001E7E2 File Offset: 0x0001C9E2
		public unsafe TextMeshProUGUI price3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_price3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_price3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x060036F3 RID: 14067 RVA: 0x0015B7E4 File Offset: 0x001599E4
		// (set) Token: 0x060036F4 RID: 14068 RVA: 0x0001E801 File Offset: 0x0001CA01
		public unsafe TextMeshProUGUI count1A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_count1A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_count1A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x060036F5 RID: 14069 RVA: 0x0015B814 File Offset: 0x00159A14
		// (set) Token: 0x060036F6 RID: 14070 RVA: 0x0001E820 File Offset: 0x0001CA20
		public unsafe TextMeshProUGUI count2A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_count2A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_count2A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x060036F7 RID: 14071 RVA: 0x0015B844 File Offset: 0x00159A44
		// (set) Token: 0x060036F8 RID: 14072 RVA: 0x0001E83F File Offset: 0x0001CA3F
		public unsafe TextMeshProUGUI count3A
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_count3A);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_count3A), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x060036F9 RID: 14073 RVA: 0x0015B874 File Offset: 0x00159A74
		// (set) Token: 0x060036FA RID: 14074 RVA: 0x0001E85E File Offset: 0x0001CA5E
		public unsafe TextMeshProUGUI count1B
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_count1B);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_count1B), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x060036FB RID: 14075 RVA: 0x0015B8A4 File Offset: 0x00159AA4
		// (set) Token: 0x060036FC RID: 14076 RVA: 0x0001E87D File Offset: 0x0001CA7D
		public unsafe TextMeshProUGUI count2B
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_count2B);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_count2B), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x060036FD RID: 14077 RVA: 0x0015B8D4 File Offset: 0x00159AD4
		// (set) Token: 0x060036FE RID: 14078 RVA: 0x0001E89C File Offset: 0x0001CA9C
		public unsafe TextMeshProUGUI count3B
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_count3B);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_count3B), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x060036FF RID: 14079 RVA: 0x0015B904 File Offset: 0x00159B04
		// (set) Token: 0x06003700 RID: 14080 RVA: 0x0001E8BB File Offset: 0x0001CABB
		public unsafe TextMeshProUGUI inStorage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_inStorage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_inStorage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06003701 RID: 14081 RVA: 0x0015B934 File Offset: 0x00159B34
		// (set) Token: 0x06003702 RID: 14082 RVA: 0x0001E8DA File Offset: 0x0001CADA
		public unsafe UIButtonHold buy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_buy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_buy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06003703 RID: 14083 RVA: 0x0015B964 File Offset: 0x00159B64
		// (set) Token: 0x06003704 RID: 14084 RVA: 0x0001E8F9 File Offset: 0x0001CAF9
		public unsafe UIButtonHold cancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_cancel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_cancel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x0015B994 File Offset: 0x00159B94
		// (set) Token: 0x06003706 RID: 14086 RVA: 0x0001E918 File Offset: 0x0001CB18
		public unsafe TextMeshProUGUI priceRemains
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_priceRemains);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_priceRemains), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06003707 RID: 14087 RVA: 0x0015B9C4 File Offset: 0x00159BC4
		// (set) Token: 0x06003708 RID: 14088 RVA: 0x0001E937 File Offset: 0x0001CB37
		public unsafe TextMeshProUGUI priceTotal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_priceTotal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_priceTotal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06003709 RID: 14089 RVA: 0x0015B9F4 File Offset: 0x00159BF4
		// (set) Token: 0x0600370A RID: 14090 RVA: 0x0001E956 File Offset: 0x0001CB56
		public unsafe AudioClip OnBuyAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_OnBuyAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_OnBuyAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x0600370B RID: 14091 RVA: 0x0015BA24 File Offset: 0x00159C24
		// (set) Token: 0x0600370C RID: 14092 RVA: 0x0001E975 File Offset: 0x0001CB75
		public unsafe HashSet<Product> cart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_cart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_cart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x0600370D RID: 14093 RVA: 0x0015BA54 File Offset: 0x00159C54
		// (set) Token: 0x0600370E RID: 14094 RVA: 0x0001E994 File Offset: 0x0001CB94
		public unsafe int priceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_priceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr_priceMultiplier)) = value;
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x0600370F RID: 14095 RVA: 0x0015BA7C File Offset: 0x00159C7C
		// (set) Token: 0x06003710 RID: 14096 RVA: 0x0001E9AF File Offset: 0x0001CBAF
		public unsafe bool _IsCheating_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr__IsCheating_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr__IsCheating_k__BackingField)) = value;
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06003711 RID: 14097 RVA: 0x0015BAA4 File Offset: 0x00159CA4
		// (set) Token: 0x06003712 RID: 14098 RVA: 0x0001E9CA File Offset: 0x0001CBCA
		public unsafe bool _HaveBought_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr__HaveBought_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr__HaveBought_k__BackingField)) = value;
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06003713 RID: 14099 RVA: 0x0015BACC File Offset: 0x00159CCC
		// (set) Token: 0x06003714 RID: 14100 RVA: 0x0001E9E5 File Offset: 0x0001CBE5
		public Nullable<WorkSceneTewiShopPannel.PannelOpenContext> _OpenContext_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr__OpenContext_k__BackingField);
				return new Nullable<WorkSceneTewiShopPannel.PannelOpenContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<WorkSceneTewiShopPannel.PannelOpenContext>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.NativeFieldInfoPtr__OpenContext_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<WorkSceneTewiShopPannel.PannelOpenContext>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002507 RID: 9479
		private static readonly IntPtr NativeFieldInfoPtr_item1;

		// Token: 0x04002508 RID: 9480
		private static readonly IntPtr NativeFieldInfoPtr_item2;

		// Token: 0x04002509 RID: 9481
		private static readonly IntPtr NativeFieldInfoPtr_item3;

		// Token: 0x0400250A RID: 9482
		private static readonly IntPtr NativeFieldInfoPtr_image1;

		// Token: 0x0400250B RID: 9483
		private static readonly IntPtr NativeFieldInfoPtr_image2;

		// Token: 0x0400250C RID: 9484
		private static readonly IntPtr NativeFieldInfoPtr_image3;

		// Token: 0x0400250D RID: 9485
		private static readonly IntPtr NativeFieldInfoPtr_describer;

		// Token: 0x0400250E RID: 9486
		private static readonly IntPtr NativeFieldInfoPtr_describerSwitcher;

		// Token: 0x0400250F RID: 9487
		private static readonly IntPtr NativeFieldInfoPtr_indicator1;

		// Token: 0x04002510 RID: 9488
		private static readonly IntPtr NativeFieldInfoPtr_indicator2;

		// Token: 0x04002511 RID: 9489
		private static readonly IntPtr NativeFieldInfoPtr_indicator3;

		// Token: 0x04002512 RID: 9490
		private static readonly IntPtr NativeFieldInfoPtr_price1;

		// Token: 0x04002513 RID: 9491
		private static readonly IntPtr NativeFieldInfoPtr_price2;

		// Token: 0x04002514 RID: 9492
		private static readonly IntPtr NativeFieldInfoPtr_price3;

		// Token: 0x04002515 RID: 9493
		private static readonly IntPtr NativeFieldInfoPtr_count1A;

		// Token: 0x04002516 RID: 9494
		private static readonly IntPtr NativeFieldInfoPtr_count2A;

		// Token: 0x04002517 RID: 9495
		private static readonly IntPtr NativeFieldInfoPtr_count3A;

		// Token: 0x04002518 RID: 9496
		private static readonly IntPtr NativeFieldInfoPtr_count1B;

		// Token: 0x04002519 RID: 9497
		private static readonly IntPtr NativeFieldInfoPtr_count2B;

		// Token: 0x0400251A RID: 9498
		private static readonly IntPtr NativeFieldInfoPtr_count3B;

		// Token: 0x0400251B RID: 9499
		private static readonly IntPtr NativeFieldInfoPtr_inStorage;

		// Token: 0x0400251C RID: 9500
		private static readonly IntPtr NativeFieldInfoPtr_buy;

		// Token: 0x0400251D RID: 9501
		private static readonly IntPtr NativeFieldInfoPtr_cancel;

		// Token: 0x0400251E RID: 9502
		private static readonly IntPtr NativeFieldInfoPtr_priceRemains;

		// Token: 0x0400251F RID: 9503
		private static readonly IntPtr NativeFieldInfoPtr_priceTotal;

		// Token: 0x04002520 RID: 9504
		private static readonly IntPtr NativeFieldInfoPtr_OnBuyAudio;

		// Token: 0x04002521 RID: 9505
		private static readonly IntPtr NativeFieldInfoPtr_cart;

		// Token: 0x04002522 RID: 9506
		private static readonly IntPtr NativeFieldInfoPtr_priceMultiplier;

		// Token: 0x04002523 RID: 9507
		private static readonly IntPtr NativeFieldInfoPtr__IsCheating_k__BackingField;

		// Token: 0x04002524 RID: 9508
		private static readonly IntPtr NativeFieldInfoPtr__HaveBought_k__BackingField;

		// Token: 0x04002525 RID: 9509
		private static readonly IntPtr NativeFieldInfoPtr__OpenContext_k__BackingField;

		// Token: 0x04002526 RID: 9510
		private static readonly IntPtr NativeMethodInfoPtr_get_Price_Private_get_Int32_0;

		// Token: 0x04002527 RID: 9511
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCheating_Public_get_Boolean_0;

		// Token: 0x04002528 RID: 9512
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCheating_Private_set_Void_Boolean_0;

		// Token: 0x04002529 RID: 9513
		private static readonly IntPtr NativeMethodInfoPtr_get_HaveBought_Public_get_Boolean_0;

		// Token: 0x0400252A RID: 9514
		private static readonly IntPtr NativeMethodInfoPtr_set_HaveBought_Private_set_Void_Boolean_0;

		// Token: 0x0400252B RID: 9515
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenContext_Private_get_Nullable_1_PannelOpenContext_0;

		// Token: 0x0400252C RID: 9516
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenContext_Public_set_Void_Nullable_1_PannelOpenContext_0;

		// Token: 0x0400252D RID: 9517
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x0400252E RID: 9518
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400252F RID: 9519
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerFund_Private_Int64_0;

		// Token: 0x04002530 RID: 9520
		private static readonly IntPtr NativeMethodInfoPtr_DeductPlayerFund_Private_Void_Int32_0;

		// Token: 0x04002531 RID: 9521
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04002532 RID: 9522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002533 RID: 9523
		private static readonly IntPtr NativeMethodInfoPtr__get_Price_b__29_0_Private_Int32_Product_0;

		// Token: 0x0200092A RID: 2346
		public sealed class PannelOpenContext : ValueType
		{
			// Token: 0x0600B854 RID: 47188 RVA: 0x002E9F20 File Offset: 0x002E8120
			// Note: this type is marked as 'beforefieldinit'.
			static PannelOpenContext()
			{
				Il2CppClassPointerStore<WorkSceneTewiShopPannel.PannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "PannelOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneTewiShopPannel.PannelOpenContext>.NativeClassPtr);
				WorkSceneTewiShopPannel.PannelOpenContext.NativeFieldInfoPtr_Merchandices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel.PannelOpenContext>.NativeClassPtr, "Merchandices");
				WorkSceneTewiShopPannel.PannelOpenContext.NativeFieldInfoPtr_PriceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel.PannelOpenContext>.NativeClassPtr, "PriceMultiplier");
				WorkSceneTewiShopPannel.PannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.PannelOpenContext>.NativeClassPtr, 100673708);
			}

			// Token: 0x0600B855 RID: 47189 RVA: 0x002E9F88 File Offset: 0x002E8188
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 128366, RefRangeEnd = 128367, XrefRangeStart = 128365, XrefRangeEnd = 128366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PannelOpenContext(Il2CppReferenceArray<Product> merchandices, int priceMultiplier) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneTewiShopPannel.PannelOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(merchandices);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priceMultiplier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.PannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Product_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B856 RID: 47190 RVA: 0x0006378A File Offset: 0x0006198A
			public PannelOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B857 RID: 47191 RVA: 0x00063793 File Offset: 0x00061993
			public PannelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneTewiShopPannel.PannelOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x17003C66 RID: 15462
			// (get) Token: 0x0600B858 RID: 47192 RVA: 0x002E9FE8 File Offset: 0x002E81E8
			// (set) Token: 0x0600B859 RID: 47193 RVA: 0x000637A5 File Offset: 0x000619A5
			public unsafe Il2CppReferenceArray<Product> Merchandices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.PannelOpenContext.NativeFieldInfoPtr_Merchandices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.PannelOpenContext.NativeFieldInfoPtr_Merchandices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C67 RID: 15463
			// (get) Token: 0x0600B85A RID: 47194 RVA: 0x002EA018 File Offset: 0x002E8218
			// (set) Token: 0x0600B85B RID: 47195 RVA: 0x000637C4 File Offset: 0x000619C4
			public unsafe int PriceMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.PannelOpenContext.NativeFieldInfoPtr_PriceMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.PannelOpenContext.NativeFieldInfoPtr_PriceMultiplier)) = value;
				}
			}

			// Token: 0x04007731 RID: 30513
			private static readonly IntPtr NativeFieldInfoPtr_Merchandices;

			// Token: 0x04007732 RID: 30514
			private static readonly IntPtr NativeFieldInfoPtr_PriceMultiplier;

			// Token: 0x04007733 RID: 30515
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Product_Int32_0;
		}

		// Token: 0x0200092B RID: 2347
		[ObfuscatedName("NightScene.UI.Miscellaneous.WorkSceneTewiShopPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600B85C RID: 47196 RVA: 0x002EA040 File Offset: 0x002E8240
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr);
				WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr, "<>9");
				WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__29_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr, "<>9__29_1");
				WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr, "<>9__43_0");
				WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__43_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr, "<>9__43_12");
				WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__43_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr, "<>9__43_13");
				WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__43_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr, "<>9__43_14");
				WorkSceneTewiShopPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr, 100673710);
				WorkSceneTewiShopPannel.__c.NativeMethodInfoPtr__get_Price_b__29_1_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr, 100673711);
				WorkSceneTewiShopPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_0_Internal_Void_AchievementNotifyResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr, 100673712);
				WorkSceneTewiShopPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_12_Internal_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr, 100673713);
				WorkSceneTewiShopPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_13_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr, 100673714);
				WorkSceneTewiShopPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_14_Internal_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr, 100673715);
			}

			// Token: 0x0600B85D RID: 47197 RVA: 0x002EA15C File Offset: 0x002E835C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B85E RID: 47198 RVA: 0x002EA198 File Offset: 0x002E8398
			[CallerCount(0)]
			public unsafe int _get_Price_b__29_1(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c.NativeMethodInfoPtr__get_Price_b__29_1_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B85F RID: 47199 RVA: 0x002EA1F0 File Offset: 0x002E83F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128367, XrefRangeEnd = 128374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__43_0(AchievementNotifyResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_0_Internal_Void_AchievementNotifyResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B860 RID: 47200 RVA: 0x002EA234 File Offset: 0x002E8434
			[CallerCount(0)]
			public unsafe int _OnPanelOpen_b__43_12(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_12_Internal_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B861 RID: 47201 RVA: 0x002EA288 File Offset: 0x002E8488
			[CallerCount(0)]
			public unsafe bool _OnPanelOpen_b__43_13(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_13_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B862 RID: 47202 RVA: 0x002EA2DC File Offset: 0x002E84DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__43_14(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__43_14_Internal_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B863 RID: 47203 RVA: 0x000637DF File Offset: 0x000619DF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C68 RID: 15464
			// (get) Token: 0x0600B864 RID: 47204 RVA: 0x002EA324 File Offset: 0x002E8524
			// (set) Token: 0x0600B865 RID: 47205 RVA: 0x000637E8 File Offset: 0x000619E8
			public unsafe static WorkSceneTewiShopPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneTewiShopPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C69 RID: 15465
			// (get) Token: 0x0600B866 RID: 47206 RVA: 0x002EA34C File Offset: 0x002E854C
			// (set) Token: 0x0600B867 RID: 47207 RVA: 0x000637FA File Offset: 0x000619FA
			public unsafe static Func<int, int, int> __9__29_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__29_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__29_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C6A RID: 15466
			// (get) Token: 0x0600B868 RID: 47208 RVA: 0x002EA374 File Offset: 0x002E8574
			// (set) Token: 0x0600B869 RID: 47209 RVA: 0x0006380C File Offset: 0x00061A0C
			public unsafe static Action<AchievementNotifyResult> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AchievementNotifyResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C6B RID: 15467
			// (get) Token: 0x0600B86A RID: 47210 RVA: 0x002EA39C File Offset: 0x002E859C
			// (set) Token: 0x0600B86B RID: 47211 RVA: 0x0006381E File Offset: 0x00061A1E
			public unsafe static Func<Product, int> __9__43_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__43_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__43_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C6C RID: 15468
			// (get) Token: 0x0600B86C RID: 47212 RVA: 0x002EA3C4 File Offset: 0x002E85C4
			// (set) Token: 0x0600B86D RID: 47213 RVA: 0x00063830 File Offset: 0x00061A30
			public unsafe static Func<Product, bool> __9__43_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__43_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__43_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C6D RID: 15469
			// (get) Token: 0x0600B86E RID: 47214 RVA: 0x002EA3EC File Offset: 0x002E85EC
			// (set) Token: 0x0600B86F RID: 47215 RVA: 0x00063842 File Offset: 0x00061A42
			public unsafe static Action<Product> __9__43_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__43_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Product>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WorkSceneTewiShopPannel.__c.NativeFieldInfoPtr___9__43_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007734 RID: 30516
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007735 RID: 30517
			private static readonly IntPtr NativeFieldInfoPtr___9__29_1;

			// Token: 0x04007736 RID: 30518
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x04007737 RID: 30519
			private static readonly IntPtr NativeFieldInfoPtr___9__43_12;

			// Token: 0x04007738 RID: 30520
			private static readonly IntPtr NativeFieldInfoPtr___9__43_13;

			// Token: 0x04007739 RID: 30521
			private static readonly IntPtr NativeFieldInfoPtr___9__43_14;

			// Token: 0x0400773A RID: 30522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400773B RID: 30523
			private static readonly IntPtr NativeMethodInfoPtr__get_Price_b__29_1_Internal_Int32_Int32_Int32_0;

			// Token: 0x0400773C RID: 30524
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_0_Internal_Void_AchievementNotifyResult_0;

			// Token: 0x0400773D RID: 30525
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_12_Internal_Int32_Product_0;

			// Token: 0x0400773E RID: 30526
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_13_Internal_Boolean_Product_0;

			// Token: 0x0400773F RID: 30527
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__43_14_Internal_Void_Product_0;
		}

		// Token: 0x0200092C RID: 2348
		[ObfuscatedName("NightScene.UI.Miscellaneous.WorkSceneTewiShopPannel+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B870 RID: 47216 RVA: 0x002EA414 File Offset: 0x002E8614
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkSceneTewiShopPannel>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr);
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeFieldInfoPtr_merchandices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, "merchandices");
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, "<>4__this");
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, 100673716);
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, 100673717);
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, 100673718);
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, 100673719);
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, 100673720);
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, 100673721);
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, 100673722);
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, 100673723);
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Void_Product_Image_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, 100673724);
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, 100673725);
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, 100673726);
				WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__11_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr, 100673727);
			}

			// Token: 0x0600B871 RID: 47217 RVA: 0x002EA558 File Offset: 0x002E8758
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkSceneTewiShopPannel.__c__DisplayClass43_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B872 RID: 47218 RVA: 0x002EA594 File Offset: 0x002E8794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128374, XrefRangeEnd = 128375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B873 RID: 47219 RVA: 0x002EA5C8 File Offset: 0x002E87C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128375, XrefRangeEnd = 128376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B874 RID: 47220 RVA: 0x002EA5FC File Offset: 0x002E87FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128376, XrefRangeEnd = 128377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B875 RID: 47221 RVA: 0x002EA630 File Offset: 0x002E8830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128377, XrefRangeEnd = 128378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B876 RID: 47222 RVA: 0x002EA664 File Offset: 0x002E8864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128378, XrefRangeEnd = 128379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B877 RID: 47223 RVA: 0x002EA698 File Offset: 0x002E8898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128379, XrefRangeEnd = 128380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B878 RID: 47224 RVA: 0x002EA6CC File Offset: 0x002E88CC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 128384, RefRangeEnd = 128387, XrefRangeStart = 128380, XrefRangeEnd = 128384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Product_0(Product product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B879 RID: 47225 RVA: 0x002EA714 File Offset: 0x002E8914
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 128400, RefRangeEnd = 128403, XrefRangeStart = 128387, XrefRangeEnd = 128400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Product_Image_GameObject_0(Product product, Image image, GameObject indicator)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(product));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indicator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Void_Product_Image_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B87A RID: 47226 RVA: 0x002EA780 File Offset: 0x002E8980
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 128413, RefRangeEnd = 128415, XrefRangeStart = 128403, XrefRangeEnd = 128413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B87B RID: 47227 RVA: 0x002EA7B4 File Offset: 0x002E89B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128415, XrefRangeEnd = 128493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B87C RID: 47228 RVA: 0x002EA7E8 File Offset: 0x002E89E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128493, XrefRangeEnd = 128495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeMethodInfoPtr__OnPanelOpen_b__11_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B87D RID: 47229 RVA: 0x00063854 File Offset: 0x00061A54
			public __c__DisplayClass43_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C6E RID: 15470
			// (get) Token: 0x0600B87E RID: 47230 RVA: 0x002EA81C File Offset: 0x002E8A1C
			// (set) Token: 0x0600B87F RID: 47231 RVA: 0x0006385D File Offset: 0x00061A5D
			public unsafe Il2CppReferenceArray<Product> merchandices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeFieldInfoPtr_merchandices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeFieldInfoPtr_merchandices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003C6F RID: 15471
			// (get) Token: 0x0600B880 RID: 47232 RVA: 0x002EA84C File Offset: 0x002E8A4C
			// (set) Token: 0x0600B881 RID: 47233 RVA: 0x0006387C File Offset: 0x00061A7C
			public unsafe WorkSceneTewiShopPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkSceneTewiShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkSceneTewiShopPannel.__c__DisplayClass43_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007740 RID: 30528
			private static readonly IntPtr NativeFieldInfoPtr_merchandices;

			// Token: 0x04007741 RID: 30529
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007742 RID: 30530
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007743 RID: 30531
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_1;

			// Token: 0x04007744 RID: 30532
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Void_1;

			// Token: 0x04007745 RID: 30533
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_1;

			// Token: 0x04007746 RID: 30534
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_1;

			// Token: 0x04007747 RID: 30535
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_1;

			// Token: 0x04007748 RID: 30536
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_1;

			// Token: 0x04007749 RID: 30537
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Product_0;

			// Token: 0x0400774A RID: 30538
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Product_Image_GameObject_0;

			// Token: 0x0400774B RID: 30539
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x0400774C RID: 30540
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__10_Internal_Void_1;

			// Token: 0x0400774D RID: 30541
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__11_Internal_Void_1;
		}
	}
}
