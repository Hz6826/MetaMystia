using System;
using Common.UI;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Plugins.DEYU;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020000C8 RID: 200
	public class DaySceneShopPannel : UIPanel
	{
		// Token: 0x06001741 RID: 5953 RVA: 0x000EC40C File Offset: 0x000EA60C
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneShopPannel()
		{
			Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneShopPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr);
			DaySceneShopPannel.NativeFieldInfoPtr_customSpacingRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "customSpacingRect");
			DaySceneShopPannel.NativeFieldInfoPtr_m_ActionExecutionScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "m_ActionExecutionScheduler");
			DaySceneShopPannel.NativeFieldInfoPtr_shelfScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "shelfScroller");
			DaySceneShopPannel.NativeFieldInfoPtr_cartScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "cartScroller");
			DaySceneShopPannel.NativeFieldInfoPtr_shelfObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "shelfObject");
			DaySceneShopPannel.NativeFieldInfoPtr_cartObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "cartObject");
			DaySceneShopPannel.NativeFieldInfoPtr_cartVisualObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "cartVisualObject");
			DaySceneShopPannel.NativeFieldInfoPtr_cartVisualColumnObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "cartVisualColumnObject");
			DaySceneShopPannel.NativeFieldInfoPtr_describerSwitcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "describerSwitcher");
			DaySceneShopPannel.NativeFieldInfoPtr_shelfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "shelfField");
			DaySceneShopPannel.NativeFieldInfoPtr_cartField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "cartField");
			DaySceneShopPannel.NativeFieldInfoPtr_cartVisualField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "cartVisualField");
			DaySceneShopPannel.NativeFieldInfoPtr_describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "describer");
			DaySceneShopPannel.NativeFieldInfoPtr_describerPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "describerPanel");
			DaySceneShopPannel.NativeFieldInfoPtr_fund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "fund");
			DaySceneShopPannel.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "price");
			DaySceneShopPannel.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "left");
			DaySceneShopPannel.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "amount");
			DaySceneShopPannel.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "title");
			DaySceneShopPannel.NativeFieldInfoPtr_totalPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "totalPrice");
			DaySceneShopPannel.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "confirmButton");
			DaySceneShopPannel.NativeFieldInfoPtr_sufficientColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "sufficientColor");
			DaySceneShopPannel.NativeFieldInfoPtr_inSufficientColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "inSufficientColor");
			DaySceneShopPannel.NativeFieldInfoPtr_OnBuyAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "OnBuyAudio");
			DaySceneShopPannel.NativeFieldInfoPtr_allCartProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "allCartProductList");
			DaySceneShopPannel.NativeFieldInfoPtr_allInCartColumnInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "allInCartColumnInstances");
			DaySceneShopPannel.NativeFieldInfoPtr_allInCartInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "allInCartInstances");
			DaySceneShopPannel.NativeFieldInfoPtr_allProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "allProducts");
			DaySceneShopPannel.NativeFieldInfoPtr_allShelfProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "allShelfProductList");
			DaySceneShopPannel.NativeFieldInfoPtr_inCartProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "inCartProducts");
			DaySceneShopPannel.NativeFieldInfoPtr_buyAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "buyAll");
			DaySceneShopPannel.NativeFieldInfoPtr_buyAllEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "buyAllEnabled");
			DaySceneShopPannel.NativeFieldInfoPtr_isFundSufficient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "isFundSufficient");
			DaySceneShopPannel.NativeFieldInfoPtr_m_CartGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "m_CartGroup");
			DaySceneShopPannel.NativeFieldInfoPtr_m_SelectAllCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "m_SelectAllCoroutine");
			DaySceneShopPannel.NativeFieldInfoPtr_m_ShelfGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "m_ShelfGroup");
			DaySceneShopPannel.NativeFieldInfoPtr_m_ShouldRunBuyAllFucntionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "m_ShouldRunBuyAllFucntionOffset");
			DaySceneShopPannel.NativeFieldInfoPtr_selectAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "selectAll");
			DaySceneShopPannel.NativeFieldInfoPtr__MerchantData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "<MerchantData>k__BackingField");
			DaySceneShopPannel.NativeMethodInfoPtr_get_MerchantData_Private_get_TrackedMerchant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667501);
			DaySceneShopPannel.NativeMethodInfoPtr_set_MerchantData_Public_set_Void_TrackedMerchant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667502);
			DaySceneShopPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667503);
			DaySceneShopPannel.NativeMethodInfoPtr_OnSelectAllPressed_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667504);
			DaySceneShopPannel.NativeMethodInfoPtr_OnSelectAllReleased_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667505);
			DaySceneShopPannel.NativeMethodInfoPtr_SelectAllCoroutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667506);
			DaySceneShopPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667507);
			DaySceneShopPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667508);
			DaySceneShopPannel.NativeMethodInfoPtr_OnShelfElementEnabled_Private_Void_Product_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667509);
			DaySceneShopPannel.NativeMethodInfoPtr_OnShelfElementSelected_Private_Void_Product_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667510);
			DaySceneShopPannel.NativeMethodInfoPtr_OnCartElementEnabled_Private_Void_Product_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667511);
			DaySceneShopPannel.NativeMethodInfoPtr_OnCartElementSelected_Private_Void_Product_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667512);
			DaySceneShopPannel.NativeMethodInfoPtr_UpdateShelfAndCart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667513);
			DaySceneShopPannel.NativeMethodInfoPtr_BuyAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667514);
			DaySceneShopPannel.NativeMethodInfoPtr_CancelAllBuy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667515);
			DaySceneShopPannel.NativeMethodInfoPtr_OnSelectAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667516);
			DaySceneShopPannel.NativeMethodInfoPtr_OnBuyAll_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667517);
			DaySceneShopPannel.NativeMethodInfoPtr_ProcessPerCartVisualColum_Private_Void_RectTransform_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667518);
			DaySceneShopPannel.NativeMethodInfoPtr_PreferShelfReselection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667519);
			DaySceneShopPannel.NativeMethodInfoPtr_PreferCartReselection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667520);
			DaySceneShopPannel.NativeMethodInfoPtr_CalculateCurrentPrice_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667521);
			DaySceneShopPannel.NativeMethodInfoPtr_GetPrice_Public_Int32_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667522);
			DaySceneShopPannel.NativeMethodInfoPtr_Describe_Private_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667523);
			DaySceneShopPannel.NativeMethodInfoPtr_Buy_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667524);
			DaySceneShopPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667525);
			DaySceneShopPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667526);
			DaySceneShopPannel.NativeMethodInfoPtr__OnPanelOpen_b__46_0_Private_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667527);
			DaySceneShopPannel.NativeMethodInfoPtr__OnPanelOpen_b__46_1_Private_Void_BorderElementType_Int32_Int32_ValueTuple_3_Product_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667528);
			DaySceneShopPannel.NativeMethodInfoPtr__OnPanelOpen_b__46_2_Private_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667529);
			DaySceneShopPannel.NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_Product_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, 100667530);
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x000EC9A0 File Offset: 0x000EABA0
		// (set) Token: 0x06001743 RID: 5955 RVA: 0x000EC9E0 File Offset: 0x000EABE0
		public unsafe TrackedMerchant MerchantData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_get_MerchantData_Private_get_TrackedMerchant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65487, XrefRangeEnd = 65488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_set_MerchantData_Public_set_Void_TrackedMerchant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x000ECA24 File Offset: 0x000EAC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65488, XrefRangeEnd = 65533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneShopPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x000ECA60 File Offset: 0x000EAC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65533, XrefRangeEnd = 65542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelectAllPressed(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_OnSelectAllPressed_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x000ECAA8 File Offset: 0x000EACA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65542, XrefRangeEnd = 65544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSelectAllReleased(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_OnSelectAllReleased_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x000ECAF0 File Offset: 0x000EACF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65544, XrefRangeEnd = 65549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SelectAllCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_SelectAllCoroutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x000ECB30 File Offset: 0x000EAD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65549, XrefRangeEnd = 65656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneShopPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x000ECB6C File Offset: 0x000EAD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65656, XrefRangeEnd = 65671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneShopPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x000ECBA8 File Offset: 0x000EADA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65671, XrefRangeEnd = 65706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnShelfElementEnabled(Product productData, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(productData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_OnShelfElementEnabled_Private_Void_Product_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x000ECC14 File Offset: 0x000EAE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65706, XrefRangeEnd = 65739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnShelfElementSelected(Product productData, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(productData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_OnShelfElementSelected_Private_Void_Product_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x000ECC80 File Offset: 0x000EAE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65739, XrefRangeEnd = 65782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCartElementEnabled(Product productData, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(productData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_OnCartElementEnabled_Private_Void_Product_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x000ECCEC File Offset: 0x000EAEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65782, XrefRangeEnd = 65815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCartElementSelected(Product productData, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(productData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_OnCartElementSelected_Private_Void_Product_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x000ECD58 File Offset: 0x000EAF58
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 65906, RefRangeEnd = 65913, XrefRangeStart = 65815, XrefRangeEnd = 65906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShelfAndCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_UpdateShelfAndCart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x000ECD8C File Offset: 0x000EAF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65913, XrefRangeEnd = 65953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuyAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_BuyAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x000ECDC0 File Offset: 0x000EAFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65953, XrefRangeEnd = 65991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAllBuy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_CancelAllBuy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x000ECDF4 File Offset: 0x000EAFF4
		[CallerCount(0)]
		public unsafe void OnSelectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_OnSelectAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x000ECE28 File Offset: 0x000EB028
		[CallerCount(0)]
		public unsafe void OnBuyAll(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_OnBuyAll_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x000ECE70 File Offset: 0x000EB070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65991, XrefRangeEnd = 66022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPerCartVisualColum(RectTransform field, Product data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_ProcessPerCartVisualColum_Private_Void_RectTransform_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x000ECECC File Offset: 0x000EB0CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 66030, RefRangeEnd = 66033, XrefRangeStart = 66022, XrefRangeEnd = 66030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreferShelfReselection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_PreferShelfReselection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x000ECF00 File Offset: 0x000EB100
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 66041, RefRangeEnd = 66044, XrefRangeStart = 66033, XrefRangeEnd = 66041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreferCartReselection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_PreferCartReselection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x000ECF34 File Offset: 0x000EB134
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 66050, RefRangeEnd = 66055, XrefRangeStart = 66044, XrefRangeEnd = 66050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateCurrentPrice(int trueValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref trueValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_CalculateCurrentPrice_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000ECF80 File Offset: 0x000EB180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66055, XrefRangeEnd = 66058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPrice(Product productData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(productData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_GetPrice_Public_Int32_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x000ECFD4 File Offset: 0x000EB1D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66077, RefRangeEnd = 66079, XrefRangeStart = 66058, XrefRangeEnd = 66077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Describe(Product productData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(productData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_Describe_Private_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000ED01C File Offset: 0x000EB21C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66120, RefRangeEnd = 66121, XrefRangeStart = 66079, XrefRangeEnd = 66120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Buy(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_Buy_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x000ED05C File Offset: 0x000EB25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66121, XrefRangeEnd = 66166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneShopPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x000ED098 File Offset: 0x000EB298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66166, XrefRangeEnd = 66213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneShopPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x000ED0D4 File Offset: 0x000EB2D4
		[CallerCount(0)]
		public unsafe void _OnPanelOpen_b__46_0(int _, MoveDirection moveDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr__OnPanelOpen_b__46_0_Private_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x000ED120 File Offset: 0x000EB320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66213, XrefRangeEnd = 66228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__46_1(AdpUISystemUtils.BorderElementType borderType, int _, int _, ValueTuple<Product, UIElementCluster, UIButtonSimple> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref borderType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr__OnPanelOpen_b__46_1_Private_Void_BorderElementType_Int32_Int32_ValueTuple_3_Product_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x000ED194 File Offset: 0x000EB394
		[CallerCount(0)]
		public unsafe void _OnPanelOpen_b__46_2(MoveDirection dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr__OnPanelOpen_b__46_2_Private_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x000ED1D4 File Offset: 0x000EB3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66228, XrefRangeEnd = 66241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_UIElementCluster_Product_PDM_0(UIElementCluster uIElementCluster, Product inputData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uIElementCluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(inputData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_Product_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x0000E7CF File Offset: 0x0000C9CF
		public DaySceneShopPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x000ED224 File Offset: 0x000EB424
		// (set) Token: 0x06001762 RID: 5986 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		public unsafe RectTransform customSpacingRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_customSpacingRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_customSpacingRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x000ED254 File Offset: 0x000EB454
		// (set) Token: 0x06001764 RID: 5988 RVA: 0x0000E7F7 File Offset: 0x0000C9F7
		public unsafe ActionExecutionScheduler m_ActionExecutionScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_m_ActionExecutionScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_m_ActionExecutionScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x000ED284 File Offset: 0x000EB484
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x0000E816 File Offset: 0x0000CA16
		public unsafe AdpProgressIndicatorComponent shelfScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_shelfScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_shelfScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x000ED2B4 File Offset: 0x000EB4B4
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x0000E835 File Offset: 0x0000CA35
		public unsafe AdpProgressIndicatorComponent cartScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_cartScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_cartScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x000ED2E4 File Offset: 0x000EB4E4
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x0000E854 File Offset: 0x0000CA54
		public unsafe GameObject shelfObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_shelfObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_shelfObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x000ED314 File Offset: 0x000EB514
		// (set) Token: 0x0600176C RID: 5996 RVA: 0x0000E873 File Offset: 0x0000CA73
		public unsafe GameObject cartObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_cartObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_cartObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x000ED344 File Offset: 0x000EB544
		// (set) Token: 0x0600176E RID: 5998 RVA: 0x0000E892 File Offset: 0x0000CA92
		public unsafe GameObject cartVisualObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_cartVisualObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_cartVisualObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600176F RID: 5999 RVA: 0x000ED374 File Offset: 0x000EB574
		// (set) Token: 0x06001770 RID: 6000 RVA: 0x0000E8B1 File Offset: 0x0000CAB1
		public unsafe GameObject cartVisualColumnObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_cartVisualColumnObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_cartVisualColumnObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x000ED3A4 File Offset: 0x000EB5A4
		// (set) Token: 0x06001772 RID: 6002 RVA: 0x0000E8D0 File Offset: 0x0000CAD0
		public unsafe DescriberSwitcher describerSwitcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_describerSwitcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DescriberSwitcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_describerSwitcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x000ED3D4 File Offset: 0x000EB5D4
		// (set) Token: 0x06001774 RID: 6004 RVA: 0x0000E8EF File Offset: 0x0000CAEF
		public unsafe GridLayoutGroup shelfField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_shelfField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_shelfField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x000ED404 File Offset: 0x000EB604
		// (set) Token: 0x06001776 RID: 6006 RVA: 0x0000E90E File Offset: 0x0000CB0E
		public unsafe GridLayoutGroup cartField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_cartField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_cartField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x000ED434 File Offset: 0x000EB634
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x0000E92D File Offset: 0x0000CB2D
		public unsafe RectTransform cartVisualField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_cartVisualField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_cartVisualField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x000ED464 File Offset: 0x000EB664
		// (set) Token: 0x0600177A RID: 6010 RVA: 0x0000E94C File Offset: 0x0000CB4C
		public unsafe SellableDescriber describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x000ED494 File Offset: 0x000EB694
		// (set) Token: 0x0600177C RID: 6012 RVA: 0x0000E96B File Offset: 0x0000CB6B
		public unsafe CanvasGroup describerPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_describerPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_describerPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x000ED4C4 File Offset: 0x000EB6C4
		// (set) Token: 0x0600177E RID: 6014 RVA: 0x0000E98A File Offset: 0x0000CB8A
		public unsafe TextMeshProUGUI fund
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_fund);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_fund), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x000ED4F4 File Offset: 0x000EB6F4
		// (set) Token: 0x06001780 RID: 6016 RVA: 0x0000E9A9 File Offset: 0x0000CBA9
		public unsafe TextMeshProUGUI price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_price);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_price), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x000ED524 File Offset: 0x000EB724
		// (set) Token: 0x06001782 RID: 6018 RVA: 0x0000E9C8 File Offset: 0x0000CBC8
		public unsafe TextMeshProUGUI left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_left);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_left), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x000ED554 File Offset: 0x000EB754
		// (set) Token: 0x06001784 RID: 6020 RVA: 0x0000E9E7 File Offset: 0x0000CBE7
		public unsafe TextMeshProUGUI amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_amount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_amount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x000ED584 File Offset: 0x000EB784
		// (set) Token: 0x06001786 RID: 6022 RVA: 0x0000EA06 File Offset: 0x0000CC06
		public unsafe TextMeshProUGUI title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x000ED5B4 File Offset: 0x000EB7B4
		// (set) Token: 0x06001788 RID: 6024 RVA: 0x0000EA25 File Offset: 0x0000CC25
		public unsafe TextMeshProUGUI totalPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_totalPrice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_totalPrice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x000ED5E4 File Offset: 0x000EB7E4
		// (set) Token: 0x0600178A RID: 6026 RVA: 0x0000EA44 File Offset: 0x0000CC44
		public unsafe UIButtonSimple confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x000ED614 File Offset: 0x000EB814
		// (set) Token: 0x0600178C RID: 6028 RVA: 0x0000EA63 File Offset: 0x0000CC63
		public unsafe Color sufficientColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_sufficientColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_sufficientColor)) = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x000ED63C File Offset: 0x000EB83C
		// (set) Token: 0x0600178E RID: 6030 RVA: 0x0000EA7E File Offset: 0x0000CC7E
		public unsafe Color inSufficientColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_inSufficientColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_inSufficientColor)) = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x000ED664 File Offset: 0x000EB864
		// (set) Token: 0x06001790 RID: 6032 RVA: 0x0000EA99 File Offset: 0x0000CC99
		public unsafe AudioClip OnBuyAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_OnBuyAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_OnBuyAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x000ED694 File Offset: 0x000EB894
		// (set) Token: 0x06001792 RID: 6034 RVA: 0x0000EAB8 File Offset: 0x0000CCB8
		public unsafe List<Product> allCartProductList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_allCartProductList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_allCartProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x000ED6C4 File Offset: 0x000EB8C4
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x0000EAD7 File Offset: 0x0000CCD7
		public unsafe List<GameObject> allInCartColumnInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_allInCartColumnInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_allInCartColumnInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x000ED6F4 File Offset: 0x000EB8F4
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x0000EAF6 File Offset: 0x0000CCF6
		public unsafe Dictionary<int, List<GameObject>> allInCartInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_allInCartInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_allInCartInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x000ED724 File Offset: 0x000EB924
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x0000EB15 File Offset: 0x0000CD15
		public unsafe Dictionary<Product.ProductKey, Product> allProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_allProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Product.ProductKey, Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_allProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x000ED754 File Offset: 0x000EB954
		// (set) Token: 0x0600179A RID: 6042 RVA: 0x0000EB34 File Offset: 0x0000CD34
		public unsafe List<Product> allShelfProductList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_allShelfProductList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_allShelfProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x000ED784 File Offset: 0x000EB984
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x0000EB53 File Offset: 0x0000CD53
		public unsafe Dictionary<Product.ProductKey, Product> inCartProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_inCartProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Product.ProductKey, Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_inCartProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x000ED7B4 File Offset: 0x000EB9B4
		// (set) Token: 0x0600179E RID: 6046 RVA: 0x0000EB72 File Offset: 0x0000CD72
		public unsafe Action buyAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_buyAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_buyAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x000ED7E4 File Offset: 0x000EB9E4
		// (set) Token: 0x060017A0 RID: 6048 RVA: 0x0000EB91 File Offset: 0x0000CD91
		public unsafe bool buyAllEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_buyAllEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_buyAllEnabled)) = value;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x000ED80C File Offset: 0x000EBA0C
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x0000EBAC File Offset: 0x0000CDAC
		public unsafe bool isFundSufficient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_isFundSufficient);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_isFundSufficient)) = value;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x000ED834 File Offset: 0x000EBA34
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x0000EBC7 File Offset: 0x0000CDC7
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Product, UIElementCluster, UIButtonSimple> m_CartGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_m_CartGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Product, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_m_CartGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x000ED864 File Offset: 0x000EBA64
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x0000EBE6 File Offset: 0x0000CDE6
		public unsafe Coroutine m_SelectAllCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_m_SelectAllCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_m_SelectAllCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x000ED894 File Offset: 0x000EBA94
		// (set) Token: 0x060017A8 RID: 6056 RVA: 0x0000EC05 File Offset: 0x0000CE05
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<Product, UIElementCluster, UIButtonSimple> m_ShelfGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_m_ShelfGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<Product, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_m_ShelfGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x000ED8C4 File Offset: 0x000EBAC4
		// (set) Token: 0x060017AA RID: 6058 RVA: 0x0000EC24 File Offset: 0x0000CE24
		public unsafe float m_ShouldRunBuyAllFucntionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_m_ShouldRunBuyAllFucntionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_m_ShouldRunBuyAllFucntionOffset)) = value;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x000ED8EC File Offset: 0x000EBAEC
		// (set) Token: 0x060017AC RID: 6060 RVA: 0x0000EC3F File Offset: 0x0000CE3F
		public unsafe Action selectAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_selectAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr_selectAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x000ED91C File Offset: 0x000EBB1C
		// (set) Token: 0x060017AE RID: 6062 RVA: 0x0000EC5E File Offset: 0x0000CE5E
		public unsafe TrackedMerchant _MerchantData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr__MerchantData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedMerchant>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.NativeFieldInfoPtr__MerchantData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeFieldInfoPtr_customSpacingRect;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionExecutionScheduler;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeFieldInfoPtr_shelfScroller;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeFieldInfoPtr_cartScroller;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeFieldInfoPtr_shelfObject;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeFieldInfoPtr_cartObject;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeFieldInfoPtr_cartVisualObject;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeFieldInfoPtr_cartVisualColumnObject;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeFieldInfoPtr_describerSwitcher;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeFieldInfoPtr_shelfField;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeFieldInfoPtr_cartField;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeFieldInfoPtr_cartVisualField;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeFieldInfoPtr_describer;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeFieldInfoPtr_describerPanel;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeFieldInfoPtr_fund;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeFieldInfoPtr_price;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeFieldInfoPtr_amount;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeFieldInfoPtr_totalPrice;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeFieldInfoPtr_sufficientColor;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeFieldInfoPtr_inSufficientColor;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeFieldInfoPtr_OnBuyAudio;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeFieldInfoPtr_allCartProductList;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeFieldInfoPtr_allInCartColumnInstances;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeFieldInfoPtr_allInCartInstances;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeFieldInfoPtr_allProducts;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeFieldInfoPtr_allShelfProductList;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeFieldInfoPtr_inCartProducts;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeFieldInfoPtr_buyAll;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeFieldInfoPtr_buyAllEnabled;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeFieldInfoPtr_isFundSufficient;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeFieldInfoPtr_m_CartGroup;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectAllCoroutine;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeFieldInfoPtr_m_ShelfGroup;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldRunBuyAllFucntionOffset;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeFieldInfoPtr_selectAll;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeFieldInfoPtr__MerchantData_k__BackingField;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr_get_MerchantData_Private_get_TrackedMerchant_0;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeMethodInfoPtr_set_MerchantData_Public_set_Void_TrackedMerchant_0;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectAllPressed_Private_Void_CallbackContext_0;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectAllReleased_Private_Void_CallbackContext_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_SelectAllCoroutine_Private_IEnumerator_0;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_OnShelfElementEnabled_Private_Void_Product_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr_OnShelfElementSelected_Private_Void_Product_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeMethodInfoPtr_OnCartElementEnabled_Private_Void_Product_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_OnCartElementSelected_Private_Void_Product_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShelfAndCart_Private_Void_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_BuyAll_Private_Void_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_CancelAllBuy_Private_Void_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectAll_Private_Void_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr_OnBuyAll_Private_Void_CallbackContext_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPerCartVisualColum_Private_Void_RectTransform_Product_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_PreferShelfReselection_Private_Void_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr_PreferCartReselection_Private_Void_0;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr_CalculateCurrentPrice_Private_Int32_Int32_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_GetPrice_Public_Int32_Product_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Private_Void_Product_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_Buy_Private_Void_Int32_0;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__46_0_Private_Void_Int32_MoveDirection_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__46_1_Private_Void_BorderElementType_Int32_Int32_ValueTuple_3_Product_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__46_2_Private_Void_MoveDirection_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_UIElementCluster_Product_PDM_0;

		// Token: 0x0200065E RID: 1630
		[ObfuscatedName("DayScene.UI.DaySceneShopPannel+<SelectAllCoroutine>d__45")]
		public sealed class _SelectAllCoroutine_d__45 : Il2CppSystem.Object
		{
			// Token: 0x06009473 RID: 38003 RVA: 0x00280494 File Offset: 0x0027E694
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectAllCoroutine_d__45()
			{
				Il2CppClassPointerStore<DaySceneShopPannel._SelectAllCoroutine_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "<SelectAllCoroutine>d__45");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneShopPannel._SelectAllCoroutine_d__45>.NativeClassPtr);
				DaySceneShopPannel._SelectAllCoroutine_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel._SelectAllCoroutine_d__45>.NativeClassPtr, "<>1__state");
				DaySceneShopPannel._SelectAllCoroutine_d__45.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel._SelectAllCoroutine_d__45>.NativeClassPtr, "<>2__current");
				DaySceneShopPannel._SelectAllCoroutine_d__45.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel._SelectAllCoroutine_d__45>.NativeClassPtr, "<>4__this");
				DaySceneShopPannel._SelectAllCoroutine_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel._SelectAllCoroutine_d__45>.NativeClassPtr, 100667531);
				DaySceneShopPannel._SelectAllCoroutine_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel._SelectAllCoroutine_d__45>.NativeClassPtr, 100667532);
				DaySceneShopPannel._SelectAllCoroutine_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel._SelectAllCoroutine_d__45>.NativeClassPtr, 100667533);
				DaySceneShopPannel._SelectAllCoroutine_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel._SelectAllCoroutine_d__45>.NativeClassPtr, 100667534);
				DaySceneShopPannel._SelectAllCoroutine_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel._SelectAllCoroutine_d__45>.NativeClassPtr, 100667535);
				DaySceneShopPannel._SelectAllCoroutine_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel._SelectAllCoroutine_d__45>.NativeClassPtr, 100667536);
			}

			// Token: 0x06009474 RID: 38004 RVA: 0x00280574 File Offset: 0x0027E774
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectAllCoroutine_d__45(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneShopPannel._SelectAllCoroutine_d__45>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel._SelectAllCoroutine_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009475 RID: 38005 RVA: 0x002805BC File Offset: 0x0027E7BC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel._SelectAllCoroutine_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009476 RID: 38006 RVA: 0x002805F0 File Offset: 0x0027E7F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65299, XrefRangeEnd = 65304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel._SelectAllCoroutine_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700315D RID: 12637
			// (get) Token: 0x06009477 RID: 38007 RVA: 0x0028062C File Offset: 0x0027E82C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel._SelectAllCoroutine_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009478 RID: 38008 RVA: 0x0028066C File Offset: 0x0027E86C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65304, XrefRangeEnd = 65310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel._SelectAllCoroutine_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700315E RID: 12638
			// (get) Token: 0x06009479 RID: 38009 RVA: 0x002806A0 File Offset: 0x0027E8A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel._SelectAllCoroutine_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600947A RID: 38010 RVA: 0x00050433 File Offset: 0x0004E633
			public _SelectAllCoroutine_d__45(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700315A RID: 12634
			// (get) Token: 0x0600947B RID: 38011 RVA: 0x002806E0 File Offset: 0x0027E8E0
			// (set) Token: 0x0600947C RID: 38012 RVA: 0x0005043C File Offset: 0x0004E63C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel._SelectAllCoroutine_d__45.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel._SelectAllCoroutine_d__45.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700315B RID: 12635
			// (get) Token: 0x0600947D RID: 38013 RVA: 0x00280708 File Offset: 0x0027E908
			// (set) Token: 0x0600947E RID: 38014 RVA: 0x00050457 File Offset: 0x0004E657
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel._SelectAllCoroutine_d__45.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel._SelectAllCoroutine_d__45.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700315C RID: 12636
			// (get) Token: 0x0600947F RID: 38015 RVA: 0x00280738 File Offset: 0x0027E938
			// (set) Token: 0x06009480 RID: 38016 RVA: 0x00050476 File Offset: 0x0004E676
			public unsafe DaySceneShopPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel._SelectAllCoroutine_d__45.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel._SelectAllCoroutine_d__45.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006050 RID: 24656
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006051 RID: 24657
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006052 RID: 24658
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006053 RID: 24659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006054 RID: 24660
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006055 RID: 24661
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006056 RID: 24662
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006057 RID: 24663
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006058 RID: 24664
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200065F RID: 1631
		[ObfuscatedName("DayScene.UI.DaySceneShopPannel+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : Il2CppSystem.Object
		{
			// Token: 0x06009481 RID: 38017 RVA: 0x00280768 File Offset: 0x0027E968
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr);
				DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr, "price");
				DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr, "sprite");
				DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr, "amount");
				DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr, "<>9__2");
				DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr, "<>9__3");
				DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr, "<>9__4");
				DaySceneShopPannel.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr, 100667537);
				DaySceneShopPannel.__c__DisplayClass48_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr, 100667538);
				DaySceneShopPannel.__c__DisplayClass48_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__1_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr, 100667539);
				DaySceneShopPannel.__c__DisplayClass48_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr, 100667540);
				DaySceneShopPannel.__c__DisplayClass48_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__3_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr, 100667541);
				DaySceneShopPannel.__c__DisplayClass48_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr, 100667542);
			}

			// Token: 0x06009482 RID: 38018 RVA: 0x00280884 File Offset: 0x0027EA84
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass48_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009483 RID: 38019 RVA: 0x002808C0 File Offset: 0x0027EAC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShelfElementEnabled_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass48_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009484 RID: 38020 RVA: 0x00280904 File Offset: 0x0027EB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65310, XrefRangeEnd = 65334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShelfElementEnabled_b__1(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass48_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__1_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009485 RID: 38021 RVA: 0x00280948 File Offset: 0x0027EB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShelfElementEnabled_b__2(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass48_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009486 RID: 38022 RVA: 0x0028098C File Offset: 0x0027EB8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShelfElementEnabled_b__3(TextMeshProUGUI y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass48_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__3_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009487 RID: 38023 RVA: 0x002809D0 File Offset: 0x0027EBD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShelfElementEnabled_b__4(TextMeshProUGUI y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass48_0.NativeMethodInfoPtr__OnShelfElementEnabled_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009488 RID: 38024 RVA: 0x00050495 File Offset: 0x0004E695
			public __c__DisplayClass48_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700315F RID: 12639
			// (get) Token: 0x06009489 RID: 38025 RVA: 0x00280A14 File Offset: 0x0027EC14
			// (set) Token: 0x0600948A RID: 38026 RVA: 0x0005049E File Offset: 0x0004E69E
			public unsafe int price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr_price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr_price)) = value;
				}
			}

			// Token: 0x17003160 RID: 12640
			// (get) Token: 0x0600948B RID: 38027 RVA: 0x00280A3C File Offset: 0x0027EC3C
			// (set) Token: 0x0600948C RID: 38028 RVA: 0x000504B9 File Offset: 0x0004E6B9
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003161 RID: 12641
			// (get) Token: 0x0600948D RID: 38029 RVA: 0x00280A6C File Offset: 0x0027EC6C
			// (set) Token: 0x0600948E RID: 38030 RVA: 0x000504D8 File Offset: 0x0004E6D8
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x17003162 RID: 12642
			// (get) Token: 0x0600948F RID: 38031 RVA: 0x00280A94 File Offset: 0x0027EC94
			// (set) Token: 0x06009490 RID: 38032 RVA: 0x000504F3 File Offset: 0x0004E6F3
			public unsafe Action<Image> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003163 RID: 12643
			// (get) Token: 0x06009491 RID: 38033 RVA: 0x00280AC4 File Offset: 0x0027ECC4
			// (set) Token: 0x06009492 RID: 38034 RVA: 0x00050512 File Offset: 0x0004E712
			public unsafe Action<TextMeshProUGUI> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003164 RID: 12644
			// (get) Token: 0x06009493 RID: 38035 RVA: 0x00280AF4 File Offset: 0x0027ECF4
			// (set) Token: 0x06009494 RID: 38036 RVA: 0x00050531 File Offset: 0x0004E731
			public unsafe Action<TextMeshProUGUI> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass48_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006059 RID: 24665
			private static readonly IntPtr NativeFieldInfoPtr_price;

			// Token: 0x0400605A RID: 24666
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x0400605B RID: 24667
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x0400605C RID: 24668
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x0400605D RID: 24669
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x0400605E RID: 24670
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x0400605F RID: 24671
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006060 RID: 24672
			private static readonly IntPtr NativeMethodInfoPtr__OnShelfElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006061 RID: 24673
			private static readonly IntPtr NativeMethodInfoPtr__OnShelfElementEnabled_b__1_Internal_Void_UIElementCluster_0;

			// Token: 0x04006062 RID: 24674
			private static readonly IntPtr NativeMethodInfoPtr__OnShelfElementEnabled_b__2_Internal_Void_Image_0;

			// Token: 0x04006063 RID: 24675
			private static readonly IntPtr NativeMethodInfoPtr__OnShelfElementEnabled_b__3_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006064 RID: 24676
			private static readonly IntPtr NativeMethodInfoPtr__OnShelfElementEnabled_b__4_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000660 RID: 1632
		[ObfuscatedName("DayScene.UI.DaySceneShopPannel+<>c__DisplayClass49_0")]
		public sealed class __c__DisplayClass49_0 : Il2CppSystem.Object
		{
			// Token: 0x06009495 RID: 38037 RVA: 0x00280B24 File Offset: 0x0027ED24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass49_0()
			{
				Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "<>c__DisplayClass49_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass49_0>.NativeClassPtr);
				DaySceneShopPannel.__c__DisplayClass49_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass49_0>.NativeClassPtr, "<>4__this");
				DaySceneShopPannel.__c__DisplayClass49_0.NativeFieldInfoPtr_productData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass49_0>.NativeClassPtr, "productData");
				DaySceneShopPannel.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass49_0>.NativeClassPtr, 100667543);
				DaySceneShopPannel.__c__DisplayClass49_0.NativeMethodInfoPtr__OnShelfElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass49_0>.NativeClassPtr, 100667544);
				DaySceneShopPannel.__c__DisplayClass49_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass49_0>.NativeClassPtr, 100667545);
				DaySceneShopPannel.__c__DisplayClass49_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass49_0>.NativeClassPtr, 100667546);
			}

			// Token: 0x06009496 RID: 38038 RVA: 0x00280BC8 File Offset: 0x0027EDC8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass49_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass49_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009497 RID: 38039 RVA: 0x00280C04 File Offset: 0x0027EE04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65334, XrefRangeEnd = 65335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnShelfElementSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass49_0.NativeMethodInfoPtr__OnShelfElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009498 RID: 38040 RVA: 0x00280C38 File Offset: 0x0027EE38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65335, XrefRangeEnd = 65362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass49_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009499 RID: 38041 RVA: 0x00280C6C File Offset: 0x0027EE6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65362, XrefRangeEnd = 65389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass49_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600949A RID: 38042 RVA: 0x00050550 File Offset: 0x0004E750
			public __c__DisplayClass49_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003165 RID: 12645
			// (get) Token: 0x0600949B RID: 38043 RVA: 0x00280CA0 File Offset: 0x0027EEA0
			// (set) Token: 0x0600949C RID: 38044 RVA: 0x00050559 File Offset: 0x0004E759
			public unsafe DaySceneShopPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass49_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass49_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003166 RID: 12646
			// (get) Token: 0x0600949D RID: 38045 RVA: 0x00280CD0 File Offset: 0x0027EED0
			// (set) Token: 0x0600949E RID: 38046 RVA: 0x00050578 File Offset: 0x0004E778
			public Product productData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass49_0.NativeFieldInfoPtr_productData);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass49_0.NativeFieldInfoPtr_productData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006065 RID: 24677
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006066 RID: 24678
			private static readonly IntPtr NativeFieldInfoPtr_productData;

			// Token: 0x04006067 RID: 24679
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006068 RID: 24680
			private static readonly IntPtr NativeMethodInfoPtr__OnShelfElementSelected_b__0_Internal_Void_0;

			// Token: 0x04006069 RID: 24681
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400606A RID: 24682
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;
		}

		// Token: 0x02000661 RID: 1633
		[ObfuscatedName("DayScene.UI.DaySceneShopPannel+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
		{
			// Token: 0x0600949F RID: 38047 RVA: 0x00280D00 File Offset: 0x0027EF00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr);
				DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr, "price");
				DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr, "sprite");
				DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr, "amount");
				DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr, "<>9__3");
				DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr, "<>9__4");
				DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr, "<>9__5");
				DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr, 100667547);
				DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnCartElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr, 100667548);
				DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnCartElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr, 100667549);
				DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnCartElementEnabled_b__2_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr, 100667550);
				DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnCartElementEnabled_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr, 100667551);
				DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnCartElementEnabled_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr, 100667552);
				DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnCartElementEnabled_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr, 100667553);
			}

			// Token: 0x060094A0 RID: 38048 RVA: 0x00280E30 File Offset: 0x0027F030
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094A1 RID: 38049 RVA: 0x00280E6C File Offset: 0x0027F06C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementEnabled_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnCartElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094A2 RID: 38050 RVA: 0x00280EB0 File Offset: 0x0027F0B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementEnabled_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnCartElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094A3 RID: 38051 RVA: 0x00280EF4 File Offset: 0x0027F0F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65389, XrefRangeEnd = 65413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementEnabled_b__2(UIElementCluster x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnCartElementEnabled_b__2_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094A4 RID: 38052 RVA: 0x00280F38 File Offset: 0x0027F138
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementEnabled_b__3(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnCartElementEnabled_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094A5 RID: 38053 RVA: 0x00280F7C File Offset: 0x0027F17C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementEnabled_b__4(TextMeshProUGUI y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnCartElementEnabled_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094A6 RID: 38054 RVA: 0x00280FC0 File Offset: 0x0027F1C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementEnabled_b__5(TextMeshProUGUI y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass50_0.NativeMethodInfoPtr__OnCartElementEnabled_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094A7 RID: 38055 RVA: 0x000505A6 File Offset: 0x0004E7A6
			public __c__DisplayClass50_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003167 RID: 12647
			// (get) Token: 0x060094A8 RID: 38056 RVA: 0x00281004 File Offset: 0x0027F204
			// (set) Token: 0x060094A9 RID: 38057 RVA: 0x000505AF File Offset: 0x0004E7AF
			public unsafe int price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr_price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr_price)) = value;
				}
			}

			// Token: 0x17003168 RID: 12648
			// (get) Token: 0x060094AA RID: 38058 RVA: 0x0028102C File Offset: 0x0027F22C
			// (set) Token: 0x060094AB RID: 38059 RVA: 0x000505CA File Offset: 0x0004E7CA
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003169 RID: 12649
			// (get) Token: 0x060094AC RID: 38060 RVA: 0x0028105C File Offset: 0x0027F25C
			// (set) Token: 0x060094AD RID: 38061 RVA: 0x000505E9 File Offset: 0x0004E7E9
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x1700316A RID: 12650
			// (get) Token: 0x060094AE RID: 38062 RVA: 0x00281084 File Offset: 0x0027F284
			// (set) Token: 0x060094AF RID: 38063 RVA: 0x00050604 File Offset: 0x0004E804
			public unsafe Action<Image> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700316B RID: 12651
			// (get) Token: 0x060094B0 RID: 38064 RVA: 0x002810B4 File Offset: 0x0027F2B4
			// (set) Token: 0x060094B1 RID: 38065 RVA: 0x00050623 File Offset: 0x0004E823
			public unsafe Action<TextMeshProUGUI> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700316C RID: 12652
			// (get) Token: 0x060094B2 RID: 38066 RVA: 0x002810E4 File Offset: 0x0027F2E4
			// (set) Token: 0x060094B3 RID: 38067 RVA: 0x00050642 File Offset: 0x0004E842
			public unsafe Action<TextMeshProUGUI> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass50_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400606B RID: 24683
			private static readonly IntPtr NativeFieldInfoPtr_price;

			// Token: 0x0400606C RID: 24684
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x0400606D RID: 24685
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x0400606E RID: 24686
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x0400606F RID: 24687
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04006070 RID: 24688
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x04006071 RID: 24689
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006072 RID: 24690
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006073 RID: 24691
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006074 RID: 24692
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementEnabled_b__2_Internal_Void_UIElementCluster_0;

			// Token: 0x04006075 RID: 24693
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementEnabled_b__3_Internal_Void_Image_0;

			// Token: 0x04006076 RID: 24694
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementEnabled_b__4_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006077 RID: 24695
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementEnabled_b__5_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000662 RID: 1634
		[ObfuscatedName("DayScene.UI.DaySceneShopPannel+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x060094B4 RID: 38068 RVA: 0x00281114 File Offset: 0x0027F314
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass51_0>.NativeClassPtr);
				DaySceneShopPannel.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass51_0>.NativeClassPtr, "<>4__this");
				DaySceneShopPannel.__c__DisplayClass51_0.NativeFieldInfoPtr_productData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass51_0>.NativeClassPtr, "productData");
				DaySceneShopPannel.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass51_0>.NativeClassPtr, 100667554);
				DaySceneShopPannel.__c__DisplayClass51_0.NativeMethodInfoPtr__OnCartElementSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass51_0>.NativeClassPtr, 100667555);
				DaySceneShopPannel.__c__DisplayClass51_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass51_0>.NativeClassPtr, 100667556);
				DaySceneShopPannel.__c__DisplayClass51_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass51_0>.NativeClassPtr, 100667557);
			}

			// Token: 0x060094B5 RID: 38069 RVA: 0x002811B8 File Offset: 0x0027F3B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094B6 RID: 38070 RVA: 0x002811F4 File Offset: 0x0027F3F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnCartElementSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass51_0.NativeMethodInfoPtr__OnCartElementSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094B7 RID: 38071 RVA: 0x00281228 File Offset: 0x0027F428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65413, XrefRangeEnd = 65440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass51_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094B8 RID: 38072 RVA: 0x0028125C File Offset: 0x0027F45C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65440, XrefRangeEnd = 65467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass51_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094B9 RID: 38073 RVA: 0x00050661 File Offset: 0x0004E861
			public __c__DisplayClass51_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700316D RID: 12653
			// (get) Token: 0x060094BA RID: 38074 RVA: 0x00281290 File Offset: 0x0027F490
			// (set) Token: 0x060094BB RID: 38075 RVA: 0x0005066A File Offset: 0x0004E86A
			public unsafe DaySceneShopPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700316E RID: 12654
			// (get) Token: 0x060094BC RID: 38076 RVA: 0x002812C0 File Offset: 0x0027F4C0
			// (set) Token: 0x060094BD RID: 38077 RVA: 0x00050689 File Offset: 0x0004E889
			public Product productData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass51_0.NativeFieldInfoPtr_productData);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass51_0.NativeFieldInfoPtr_productData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006078 RID: 24696
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006079 RID: 24697
			private static readonly IntPtr NativeFieldInfoPtr_productData;

			// Token: 0x0400607A RID: 24698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400607B RID: 24699
			private static readonly IntPtr NativeMethodInfoPtr__OnCartElementSelected_b__0_Internal_Void_0;

			// Token: 0x0400607C RID: 24700
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400607D RID: 24701
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;
		}

		// Token: 0x02000663 RID: 1635
		[ObfuscatedName("DayScene.UI.DaySceneShopPannel+<>c__DisplayClass52_0")]
		public sealed class __c__DisplayClass52_0 : Il2CppSystem.Object
		{
			// Token: 0x060094BE RID: 38078 RVA: 0x002812F0 File Offset: 0x0027F4F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass52_0()
			{
				Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "<>c__DisplayClass52_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass52_0>.NativeClassPtr);
				DaySceneShopPannel.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass52_0>.NativeClassPtr, "<>4__this");
				DaySceneShopPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass52_0>.NativeClassPtr, "total");
				DaySceneShopPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass52_0>.NativeClassPtr, 100667558);
				DaySceneShopPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__UpdateShelfAndCart_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass52_0>.NativeClassPtr, 100667559);
			}

			// Token: 0x060094BF RID: 38079 RVA: 0x0028136C File Offset: 0x0027F56C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass52_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass52_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094C0 RID: 38080 RVA: 0x002813A8 File Offset: 0x0027F5A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65467, XrefRangeEnd = 65469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateShelfAndCart_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass52_0.NativeMethodInfoPtr__UpdateShelfAndCart_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094C1 RID: 38081 RVA: 0x000506B7 File Offset: 0x0004E8B7
			public __c__DisplayClass52_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700316F RID: 12655
			// (get) Token: 0x060094C2 RID: 38082 RVA: 0x002813DC File Offset: 0x0027F5DC
			// (set) Token: 0x060094C3 RID: 38083 RVA: 0x000506C0 File Offset: 0x0004E8C0
			public unsafe DaySceneShopPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass52_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003170 RID: 12656
			// (get) Token: 0x060094C4 RID: 38084 RVA: 0x0028140C File Offset: 0x0027F60C
			// (set) Token: 0x060094C5 RID: 38085 RVA: 0x000506DF File Offset: 0x0004E8DF
			public unsafe int total
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_total);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass52_0.NativeFieldInfoPtr_total)) = value;
				}
			}

			// Token: 0x0400607E RID: 24702
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400607F RID: 24703
			private static readonly IntPtr NativeFieldInfoPtr_total;

			// Token: 0x04006080 RID: 24704
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006081 RID: 24705
			private static readonly IntPtr NativeMethodInfoPtr__UpdateShelfAndCart_b__1_Internal_Void_0;
		}

		// Token: 0x02000664 RID: 1636
		[ObfuscatedName("DayScene.UI.DaySceneShopPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060094C6 RID: 38086 RVA: 0x00281434 File Offset: 0x0027F634
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneShopPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneShopPannel.__c>.NativeClassPtr);
				DaySceneShopPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c>.NativeClassPtr, "<>9");
				DaySceneShopPannel.__c.NativeFieldInfoPtr___9__52_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c>.NativeClassPtr, "<>9__52_0");
				DaySceneShopPannel.__c.NativeFieldInfoPtr___9__62_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c>.NativeClassPtr, "<>9__62_2");
				DaySceneShopPannel.__c.NativeFieldInfoPtr___9__63_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c>.NativeClassPtr, "<>9__63_0");
				DaySceneShopPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c>.NativeClassPtr, 100667561);
				DaySceneShopPannel.__c.NativeMethodInfoPtr__UpdateShelfAndCart_b__52_0_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c>.NativeClassPtr, 100667562);
				DaySceneShopPannel.__c.NativeMethodInfoPtr__Describe_b__62_2_Internal_KeyValuePair_2_Recipe_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c>.NativeClassPtr, 100667563);
				DaySceneShopPannel.__c.NativeMethodInfoPtr__Buy_b__63_0_Internal_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c>.NativeClassPtr, 100667564);
			}

			// Token: 0x060094C7 RID: 38087 RVA: 0x00281500 File Offset: 0x0027F700
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneShopPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094C8 RID: 38088 RVA: 0x0028153C File Offset: 0x0027F73C
			[CallerCount(0)]
			public unsafe int _UpdateShelfAndCart_b__52_0(int a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c.NativeMethodInfoPtr__UpdateShelfAndCart_b__52_0_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060094C9 RID: 38089 RVA: 0x00281594 File Offset: 0x0027F794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65469, XrefRangeEnd = 65473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyValuePair<Recipe, int> _Describe_b__62_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c.NativeMethodInfoPtr__Describe_b__62_2_Internal_KeyValuePair_2_Recipe_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new KeyValuePair<Recipe, int>(pointer);
			}

			// Token: 0x060094CA RID: 38090 RVA: 0x002815D8 File Offset: 0x0027F7D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Buy_b__63_0(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c.NativeMethodInfoPtr__Buy_b__63_0_Internal_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094CB RID: 38091 RVA: 0x000506FA File Offset: 0x0004E8FA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003171 RID: 12657
			// (get) Token: 0x060094CC RID: 38092 RVA: 0x00281620 File Offset: 0x0027F820
			// (set) Token: 0x060094CD RID: 38093 RVA: 0x00050703 File Offset: 0x0004E903
			public unsafe static DaySceneShopPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneShopPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneShopPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneShopPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003172 RID: 12658
			// (get) Token: 0x060094CE RID: 38094 RVA: 0x00281648 File Offset: 0x0027F848
			// (set) Token: 0x060094CF RID: 38095 RVA: 0x00050715 File Offset: 0x0004E915
			public unsafe static Func<int, int, int> __9__52_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneShopPannel.__c.NativeFieldInfoPtr___9__52_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneShopPannel.__c.NativeFieldInfoPtr___9__52_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003173 RID: 12659
			// (get) Token: 0x060094D0 RID: 38096 RVA: 0x00281670 File Offset: 0x0027F870
			// (set) Token: 0x060094D1 RID: 38097 RVA: 0x00050727 File Offset: 0x0004E927
			public unsafe static Func<int, KeyValuePair<Recipe, int>> __9__62_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneShopPannel.__c.NativeFieldInfoPtr___9__62_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, KeyValuePair<Recipe, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneShopPannel.__c.NativeFieldInfoPtr___9__62_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003174 RID: 12660
			// (get) Token: 0x060094D2 RID: 38098 RVA: 0x00281698 File Offset: 0x0027F898
			// (set) Token: 0x060094D3 RID: 38099 RVA: 0x00050739 File Offset: 0x0004E939
			public unsafe static Action<Product> __9__63_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneShopPannel.__c.NativeFieldInfoPtr___9__63_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Product>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneShopPannel.__c.NativeFieldInfoPtr___9__63_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006082 RID: 24706
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006083 RID: 24707
			private static readonly IntPtr NativeFieldInfoPtr___9__52_0;

			// Token: 0x04006084 RID: 24708
			private static readonly IntPtr NativeFieldInfoPtr___9__62_2;

			// Token: 0x04006085 RID: 24709
			private static readonly IntPtr NativeFieldInfoPtr___9__63_0;

			// Token: 0x04006086 RID: 24710
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006087 RID: 24711
			private static readonly IntPtr NativeMethodInfoPtr__UpdateShelfAndCart_b__52_0_Internal_Int32_Int32_Int32_0;

			// Token: 0x04006088 RID: 24712
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__62_2_Internal_KeyValuePair_2_Recipe_Int32_Int32_0;

			// Token: 0x04006089 RID: 24713
			private static readonly IntPtr NativeMethodInfoPtr__Buy_b__63_0_Internal_Void_Product_0;
		}

		// Token: 0x02000665 RID: 1637
		[ObfuscatedName("DayScene.UI.DaySceneShopPannel+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : Il2CppSystem.Object
		{
			// Token: 0x060094D4 RID: 38100 RVA: 0x002816C0 File Offset: 0x0027F8C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass57_0>.NativeClassPtr);
				DaySceneShopPannel.__c__DisplayClass57_0.NativeFieldInfoPtr_inputData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass57_0>.NativeClassPtr, "inputData");
				DaySceneShopPannel.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass57_0>.NativeClassPtr, 100667565);
				DaySceneShopPannel.__c__DisplayClass57_0.NativeMethodInfoPtr__ProcessPerCartVisualColum_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass57_0>.NativeClassPtr, 100667566);
			}

			// Token: 0x060094D5 RID: 38101 RVA: 0x00281728 File Offset: 0x0027F928
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass57_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094D6 RID: 38102 RVA: 0x00281764 File Offset: 0x0027F964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65473, XrefRangeEnd = 65483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessPerCartVisualColum_b__1(Image visual)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass57_0.NativeMethodInfoPtr__ProcessPerCartVisualColum_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094D7 RID: 38103 RVA: 0x0005074B File Offset: 0x0004E94B
			public __c__DisplayClass57_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003175 RID: 12661
			// (get) Token: 0x060094D8 RID: 38104 RVA: 0x002817A8 File Offset: 0x0027F9A8
			// (set) Token: 0x060094D9 RID: 38105 RVA: 0x00050754 File Offset: 0x0004E954
			public Product inputData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass57_0.NativeFieldInfoPtr_inputData);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass57_0.NativeFieldInfoPtr_inputData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400608A RID: 24714
			private static readonly IntPtr NativeFieldInfoPtr_inputData;

			// Token: 0x0400608B RID: 24715
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400608C RID: 24716
			private static readonly IntPtr NativeMethodInfoPtr__ProcessPerCartVisualColum_b__1_Internal_Void_Image_0;
		}

		// Token: 0x02000666 RID: 1638
		[ObfuscatedName("DayScene.UI.DaySceneShopPannel+<>c__DisplayClass62_0")]
		public sealed class __c__DisplayClass62_0 : Il2CppSystem.Object
		{
			// Token: 0x060094DA RID: 38106 RVA: 0x002817D8 File Offset: 0x0027F9D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_0()
			{
				Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneShopPannel>.NativeClassPtr, "<>c__DisplayClass62_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass62_0>.NativeClassPtr);
				DaySceneShopPannel.__c__DisplayClass62_0.NativeFieldInfoPtr_productData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass62_0>.NativeClassPtr, "productData");
				DaySceneShopPannel.__c__DisplayClass62_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass62_0>.NativeClassPtr, "<>4__this");
				DaySceneShopPannel.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass62_0>.NativeClassPtr, 100667567);
				DaySceneShopPannel.__c__DisplayClass62_0.NativeMethodInfoPtr_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass62_0>.NativeClassPtr, 100667568);
				DaySceneShopPannel.__c__DisplayClass62_0.NativeMethodInfoPtr__Describe_b__1_Internal_Boolean_KeyValuePair_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass62_0>.NativeClassPtr, 100667569);
			}

			// Token: 0x060094DB RID: 38107 RVA: 0x00281868 File Offset: 0x0027FA68
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass62_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094DC RID: 38108 RVA: 0x002818A4 File Offset: 0x0027FAA4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 65486, RefRangeEnd = 65487, XrefRangeStart = 65483, XrefRangeEnd = 65486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0<T>(IEnumerable<KeyValuePair<T, int>> objectCollection) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectCollection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass62_0.MethodInfoStoreGeneric_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060094DD RID: 38109 RVA: 0x002818E8 File Offset: 0x0027FAE8
			[CallerCount(0)]
			public unsafe bool _Describe_b__1<T>(KeyValuePair<T, int> x) where T : NonTradableObjectBase
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneShopPannel.__c__DisplayClass62_0.MethodInfoStoreGeneric__Describe_b__1_Internal_Boolean_KeyValuePair_2_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060094DE RID: 38110 RVA: 0x00050782 File Offset: 0x0004E982
			public __c__DisplayClass62_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003176 RID: 12662
			// (get) Token: 0x060094DF RID: 38111 RVA: 0x0028193C File Offset: 0x0027FB3C
			// (set) Token: 0x060094E0 RID: 38112 RVA: 0x0005078B File Offset: 0x0004E98B
			public Product productData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass62_0.NativeFieldInfoPtr_productData);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass62_0.NativeFieldInfoPtr_productData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003177 RID: 12663
			// (get) Token: 0x060094E1 RID: 38113 RVA: 0x0028196C File Offset: 0x0027FB6C
			// (set) Token: 0x060094E2 RID: 38114 RVA: 0x000507B9 File Offset: 0x0004E9B9
			public unsafe DaySceneShopPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass62_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneShopPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneShopPannel.__c__DisplayClass62_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400608D RID: 24717
			private static readonly IntPtr NativeFieldInfoPtr_productData;

			// Token: 0x0400608E RID: 24718
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400608F RID: 24719
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006090 RID: 24720
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0;

			// Token: 0x04006091 RID: 24721
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__1_Internal_Boolean_KeyValuePair_2_T_Int32_0;

			// Token: 0x02000FC3 RID: 4035
			private sealed class MethodInfoStoreGeneric_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0<T>
			{
				// Token: 0x0400AF8C RID: 44940
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DaySceneShopPannel.__c__DisplayClass62_0.NativeMethodInfoPtr_Method_Internal_Void_IEnumerable_1_KeyValuePair_2_T_Int32_0, Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass62_0>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}

			// Token: 0x02000FC4 RID: 4036
			private sealed class MethodInfoStoreGeneric__Describe_b__1_Internal_Boolean_KeyValuePair_2_T_Int32_0<T>
			{
				// Token: 0x0400AF8D RID: 44941
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DaySceneShopPannel.__c__DisplayClass62_0.NativeMethodInfoPtr__Describe_b__1_Internal_Boolean_KeyValuePair_2_T_Int32_0, Il2CppClassPointerStore<DaySceneShopPannel.__c__DisplayClass62_0>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}
		}
	}
}
