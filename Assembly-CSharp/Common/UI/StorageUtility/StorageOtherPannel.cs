using System;
using Common.UI.Filter;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core;
using GameData.Core.Collections;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.StorageUtility
{
	// Token: 0x02000388 RID: 904
	public class StorageOtherPannel : UISubPanel<StorageMainPannel>
	{
		// Token: 0x06006B73 RID: 27507 RVA: 0x00204EA0 File Offset: 0x002030A0
		// Note: this type is marked as 'beforefieldinit'.
		static StorageOtherPannel()
		{
			Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.StorageUtility", "StorageOtherPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr);
			StorageOtherPannel.NativeFieldInfoPtr_Scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "Scroller");
			StorageOtherPannel.NativeFieldInfoPtr_IngredientObjectField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "IngredientObjectField");
			StorageOtherPannel.NativeFieldInfoPtr_IngredientTagField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "IngredientTagField");
			StorageOtherPannel.NativeFieldInfoPtr_FoodObjectField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "FoodObjectField");
			StorageOtherPannel.NativeFieldInfoPtr_BeverageObjectField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "BeverageObjectField");
			StorageOtherPannel.NativeFieldInfoPtr_KitchenwareObjectField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "KitchenwareObjectField");
			StorageOtherPannel.NativeFieldInfoPtr_ItemObjectField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "ItemObjectField");
			StorageOtherPannel.NativeFieldInfoPtr_filterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "filterButton");
			StorageOtherPannel.NativeFieldInfoPtr_ObjectStackParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "ObjectStackParent");
			StorageOtherPannel.NativeFieldInfoPtr_m_Beverages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_Beverages");
			StorageOtherPannel.NativeFieldInfoPtr_m_BeveragesFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_BeveragesFilter");
			StorageOtherPannel.NativeFieldInfoPtr_m_CookersFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_CookersFilter");
			StorageOtherPannel.NativeFieldInfoPtr_m_Foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_Foods");
			StorageOtherPannel.NativeFieldInfoPtr_m_FoodsFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_FoodsFilter");
			StorageOtherPannel.NativeFieldInfoPtr_m_IngredientMeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_IngredientMeat");
			StorageOtherPannel.NativeFieldInfoPtr_m_IngredientOther = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_IngredientOther");
			StorageOtherPannel.NativeFieldInfoPtr_m_IngredientSeaFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_IngredientSeaFood");
			StorageOtherPannel.NativeFieldInfoPtr_m_IngredientsFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_IngredientsFilter");
			StorageOtherPannel.NativeFieldInfoPtr_m_IngredientVeggie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_IngredientVeggie");
			StorageOtherPannel.NativeFieldInfoPtr_m_ItemFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_ItemFilter");
			StorageOtherPannel.NativeFieldInfoPtr_m_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_Items");
			StorageOtherPannel.NativeFieldInfoPtr_m_Kitchenwares = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_Kitchenwares");
			StorageOtherPannel.NativeFieldInfoPtr_m_OtherObjectInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_OtherObjectInstances");
			StorageOtherPannel.NativeFieldInfoPtr_currentSelectedGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "currentSelectedGroup");
			StorageOtherPannel.NativeFieldInfoPtr_describeObjectCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "describeObjectCallback");
			StorageOtherPannel.NativeFieldInfoPtr_enablePinning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "enablePinning");
			StorageOtherPannel.NativeFieldInfoPtr_getPinnedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "getPinnedCallback");
			StorageOtherPannel.NativeFieldInfoPtr_isDescriberHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "isDescriberHidden");
			StorageOtherPannel.NativeFieldInfoPtr_m_BeverageObjectFieldCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_BeverageObjectFieldCanvasGroup");
			StorageOtherPannel.NativeFieldInfoPtr_m_BeveragesGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_BeveragesGroup");
			StorageOtherPannel.NativeFieldInfoPtr_m_CurrentSetPinnedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_CurrentSetPinnedCallback");
			StorageOtherPannel.NativeFieldInfoPtr_m_FilterButtonCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_FilterButtonCanvasGroup");
			StorageOtherPannel.NativeFieldInfoPtr_m_FoodObjectFieldCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_FoodObjectFieldCanvasGroup");
			StorageOtherPannel.NativeFieldInfoPtr_m_FoodsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_FoodsGroup");
			StorageOtherPannel.NativeFieldInfoPtr_m_IngredientObjectFieldCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_IngredientObjectFieldCanvasGroup");
			StorageOtherPannel.NativeFieldInfoPtr_m_IngredientsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_IngredientsGroup");
			StorageOtherPannel.NativeFieldInfoPtr_m_ItemObjectFieldCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_ItemObjectFieldCanvasGroup");
			StorageOtherPannel.NativeFieldInfoPtr_m_ItemsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_ItemsGroup");
			StorageOtherPannel.NativeFieldInfoPtr_m_KitchenwareObjectFieldCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_KitchenwareObjectFieldCanvasGroup");
			StorageOtherPannel.NativeFieldInfoPtr_m_KitchenwaresGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "m_KitchenwaresGroup");
			StorageOtherPannel.NativeFieldInfoPtr_setPinnedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "setPinnedCallback");
			StorageOtherPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685480);
			StorageOtherPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685481);
			StorageOtherPannel.NativeMethodInfoPtr_ResetFilter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685482);
			StorageOtherPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685483);
			StorageOtherPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_KeyValuePair_2_T_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685484);
			StorageOtherPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_KeyValuePair_2_T_Int32_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685485);
			StorageOtherPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685486);
			StorageOtherPannel.NativeMethodInfoPtr_OnTertiarySwitchCalled_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685487);
			StorageOtherPannel.NativeMethodInfoPtr_SetParamValue_Private_Void_Boolean_Func_2_Int32_Boolean_Action_2_Int32_Boolean_Action_1_Object_IStaticGridScrollListUILogicalGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685488);
			StorageOtherPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685489);
			StorageOtherPannel.NativeMethodInfoPtr_OnTertiarySwitchPresed_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685490);
			StorageOtherPannel.NativeMethodInfoPtr_OpenFilterPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685491);
			StorageOtherPannel.NativeMethodInfoPtr_HideDescriber_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685492);
			StorageOtherPannel.NativeMethodInfoPtr_UpdateItemCollection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685493);
			StorageOtherPannel.NativeMethodInfoPtr_UpdateCookerCollection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685494);
			StorageOtherPannel.NativeMethodInfoPtr_UpdateBeverageCollection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685495);
			StorageOtherPannel.NativeMethodInfoPtr_UpdateFoodsCollection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685496);
			StorageOtherPannel.NativeMethodInfoPtr_UpdateIngredientCollection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685497);
			StorageOtherPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685498);
			StorageOtherPannel.NativeMethodInfoPtr_GetPinnedType_Private_DefaultProp_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685499);
			StorageOtherPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685500);
			StorageOtherPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685501);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685502);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_15_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685503);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_16_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685504);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_17_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685505);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685506);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685507);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_20_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685508);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_21_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685509);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685510);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685511);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_24_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685512);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_25_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685513);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685514);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_10_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685515);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_28_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685516);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_29_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685517);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_11_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685518);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_13_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685519);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_31_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685520);
			StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_14_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685521);
			StorageOtherPannel.NativeMethodInfoPtr__OpenFilterPanel_b__53_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685522);
			StorageOtherPannel.NativeMethodInfoPtr__OpenFilterPanel_b__53_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685523);
			StorageOtherPannel.NativeMethodInfoPtr__OpenFilterPanel_b__53_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685524);
			StorageOtherPannel.NativeMethodInfoPtr__OpenFilterPanel_b__53_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685525);
			StorageOtherPannel.NativeMethodInfoPtr__OpenFilterPanel_b__53_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685526);
			StorageOtherPannel.NativeMethodInfoPtr_Method_Internal_Static_Int32_Item_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685527);
			StorageOtherPannel.NativeMethodInfoPtr__UpdateCookerCollection_b__56_2_Private_Nullable_1_Boolean_KeyValuePair_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685528);
			StorageOtherPannel.NativeMethodInfoPtr__UpdateBeverageCollection_b__57_1_Private_Nullable_1_Boolean_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685529);
			StorageOtherPannel.NativeMethodInfoPtr__UpdateFoodsCollection_b__58_3_Private_Nullable_1_Boolean_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685530);
			StorageOtherPannel.NativeMethodInfoPtr__UpdateIngredientCollection_b__59_0_Private_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, 100685531);
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x06006B74 RID: 27508 RVA: 0x00205614 File Offset: 0x00203814
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageOtherPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x0020565C File Offset: 0x0020385C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272041, XrefRangeEnd = 272253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageOtherPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B76 RID: 27510 RVA: 0x00205698 File Offset: 0x00203898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272253, XrefRangeEnd = 272259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr_ResetFilter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B77 RID: 27511 RVA: 0x002056CC File Offset: 0x002038CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272259, XrefRangeEnd = 272271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageOtherPannel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B78 RID: 27512 RVA: 0x00205708 File Offset: 0x00203908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272271, XrefRangeEnd = 272304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementEnabled<T>(KeyValuePair<T, int> objectBase, UIElementCluster cluster, UIButtonSimple uiButtonSimple) where T : NonTradableObjectBase
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(objectBase));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.MethodInfoStoreGeneric_OnElementEnabled_Private_Void_KeyValuePair_2_T_Int32_UIElementCluster_UIButtonSimple_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x00205774 File Offset: 0x00203974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272304, XrefRangeEnd = 272316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementSelected<T>(KeyValuePair<T, int> value, UIElementCluster uiElementCluster, UIButtonSimple uiButtonSimple) where T : NonTradableObjectBase
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiButtonSimple);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.MethodInfoStoreGeneric_OnElementSelected_Private_Void_KeyValuePair_2_T_Int32_UIElementCluster_UIButtonSimple_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x002057E0 File Offset: 0x002039E0
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageOtherPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x00205828 File Offset: 0x00203A28
		[CallerCount(0)]
		public unsafe void OnTertiarySwitchCalled(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr_OnTertiarySwitchCalled_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x00205870 File Offset: 0x00203A70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 272324, RefRangeEnd = 272329, XrefRangeStart = 272316, XrefRangeEnd = 272324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParamValue(bool enablePinning, Func<int, bool> getPinnedCallback, Action<int, bool> setPinnedCallback, Action<Il2CppSystem.Object> describeObjectCallback, IStaticGridScrollListUILogicalGroup currentSelectedGroup, bool canFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enablePinning;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getPinnedCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setPinnedCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(describeObjectCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentSelectedGroup);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr_SetParamValue_Private_Void_Boolean_Func_2_Int32_Boolean_Action_2_Int32_Boolean_Action_1_Object_IStaticGridScrollListUILogicalGroup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B7D RID: 27517 RVA: 0x00205908 File Offset: 0x00203B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272329, XrefRangeEnd = 272469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageOtherPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B7E RID: 27518 RVA: 0x00205944 File Offset: 0x00203B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272469, XrefRangeEnd = 272473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTertiarySwitchPresed(InputAction.CallbackContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr_OnTertiarySwitchPresed_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B7F RID: 27519 RVA: 0x0020598C File Offset: 0x00203B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 272510, RefRangeEnd = 272511, XrefRangeStart = 272473, XrefRangeEnd = 272510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenFilterPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr_OpenFilterPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B80 RID: 27520 RVA: 0x002059C0 File Offset: 0x00203BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272511, XrefRangeEnd = 272514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideDescriber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr_HideDescriber_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B81 RID: 27521 RVA: 0x002059F4 File Offset: 0x00203BF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 272577, RefRangeEnd = 272579, XrefRangeStart = 272514, XrefRangeEnd = 272577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateItemCollection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr_UpdateItemCollection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B82 RID: 27522 RVA: 0x00205A28 File Offset: 0x00203C28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 272635, RefRangeEnd = 272638, XrefRangeStart = 272579, XrefRangeEnd = 272635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCookerCollection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr_UpdateCookerCollection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B83 RID: 27523 RVA: 0x00205A5C File Offset: 0x00203C5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 272680, RefRangeEnd = 272683, XrefRangeStart = 272638, XrefRangeEnd = 272680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBeverageCollection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr_UpdateBeverageCollection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B84 RID: 27524 RVA: 0x00205A90 File Offset: 0x00203C90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 272780, RefRangeEnd = 272783, XrefRangeStart = 272683, XrefRangeEnd = 272780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFoodsCollection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr_UpdateFoodsCollection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B85 RID: 27525 RVA: 0x00205AC4 File Offset: 0x00203CC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 272796, RefRangeEnd = 272799, XrefRangeStart = 272783, XrefRangeEnd = 272796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIngredientCollection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr_UpdateIngredientCollection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B86 RID: 27526 RVA: 0x00205AF8 File Offset: 0x00203CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272799, XrefRangeEnd = 272803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageOtherPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x00205B34 File Offset: 0x00203D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272803, XrefRangeEnd = 272806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSaveFile.DefaultProp GetPinnedType(Ingredient pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pair);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr_GetPinnedType_Private_DefaultProp_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x00205B84 File Offset: 0x00203D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272806, XrefRangeEnd = 272866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageOtherPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B89 RID: 27529 RVA: 0x00205BC0 File Offset: 0x00203DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272866, XrefRangeEnd = 272952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageOtherPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B8A RID: 27530 RVA: 0x00205BFC File Offset: 0x00203DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272952, XrefRangeEnd = 272973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x00205C30 File Offset: 0x00203E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272973, XrefRangeEnd = 272984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPanelOpen_b__51_15(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_15_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006B8C RID: 27532 RVA: 0x00205C7C File Offset: 0x00203E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272984, XrefRangeEnd = 273000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_16(int a, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_16_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x00205CC8 File Offset: 0x00203EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273000, XrefRangeEnd = 273016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_17(Il2CppSystem.Object x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_17_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x00205D0C File Offset: 0x00203F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273016, XrefRangeEnd = 273024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x00205D40 File Offset: 0x00203F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273024, XrefRangeEnd = 273054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x00205D74 File Offset: 0x00203F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273054, XrefRangeEnd = 273060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_20(int a, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_20_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B91 RID: 27537 RVA: 0x00205DC0 File Offset: 0x00203FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273060, XrefRangeEnd = 273076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_21(Il2CppSystem.Object x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_21_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B92 RID: 27538 RVA: 0x00205E04 File Offset: 0x00204004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273076, XrefRangeEnd = 273084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x00205E38 File Offset: 0x00204038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273084, XrefRangeEnd = 273114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x00205E6C File Offset: 0x0020406C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273114, XrefRangeEnd = 273119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_24(int a, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_24_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B95 RID: 27541 RVA: 0x00205EB8 File Offset: 0x002040B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273119, XrefRangeEnd = 273135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_25(Il2CppSystem.Object x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_25_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x00205EFC File Offset: 0x002040FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273135, XrefRangeEnd = 273143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x00205F30 File Offset: 0x00204130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273143, XrefRangeEnd = 273173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_10()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_10_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x00205F64 File Offset: 0x00204164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273173, XrefRangeEnd = 273178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_28(int a, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_28_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x00205FB0 File Offset: 0x002041B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273178, XrefRangeEnd = 273194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_29(Il2CppSystem.Object x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_29_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x00205FF4 File Offset: 0x002041F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273194, XrefRangeEnd = 273202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_11()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_11_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B9B RID: 27547 RVA: 0x00206028 File Offset: 0x00204228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273202, XrefRangeEnd = 273211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_13()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_13_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B9C RID: 27548 RVA: 0x0020605C File Offset: 0x0020425C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273211, XrefRangeEnd = 273227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_31(Il2CppSystem.Object x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_31_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B9D RID: 27549 RVA: 0x002060A0 File Offset: 0x002042A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273227, XrefRangeEnd = 273235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelOpen_b__51_14()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OnPanelOpen_b__51_14_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B9E RID: 27550 RVA: 0x002060D4 File Offset: 0x002042D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273235, XrefRangeEnd = 273240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenFilterPanel_b__53_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OpenFilterPanel_b__53_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x00206108 File Offset: 0x00204308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273240, XrefRangeEnd = 273245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenFilterPanel_b__53_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OpenFilterPanel_b__53_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA0 RID: 27552 RVA: 0x0020613C File Offset: 0x0020433C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273245, XrefRangeEnd = 273250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenFilterPanel_b__53_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OpenFilterPanel_b__53_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA1 RID: 27553 RVA: 0x00206170 File Offset: 0x00204370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273250, XrefRangeEnd = 273255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenFilterPanel_b__53_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OpenFilterPanel_b__53_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x002061A4 File Offset: 0x002043A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273255, XrefRangeEnd = 273260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenFilterPanel_b__53_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__OpenFilterPanel_b__53_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BA3 RID: 27555 RVA: 0x002061D8 File Offset: 0x002043D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273260, XrefRangeEnd = 273263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Method_Internal_Static_Int32_Item_PDM_0(Item item)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr_Method_Internal_Static_Int32_Item_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006BA4 RID: 27556 RVA: 0x0020621C File Offset: 0x0020441C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273263, XrefRangeEnd = 273267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<bool> _UpdateCookerCollection_b__56_2(KeyValuePair<Cooker, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__UpdateCookerCollection_b__56_2_Private_Nullable_1_Boolean_KeyValuePair_2_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Nullable<bool>(pointer);
		}

		// Token: 0x06006BA5 RID: 27557 RVA: 0x0020626C File Offset: 0x0020446C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273267, XrefRangeEnd = 273271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<bool> _UpdateBeverageCollection_b__57_1(KeyValuePair<Sellable, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__UpdateBeverageCollection_b__57_1_Private_Nullable_1_Boolean_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Nullable<bool>(pointer);
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x002062BC File Offset: 0x002044BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273271, XrefRangeEnd = 273275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<bool> _UpdateFoodsCollection_b__58_3(KeyValuePair<Sellable, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__UpdateFoodsCollection_b__58_3_Private_Nullable_1_Boolean_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Nullable<bool>(pointer);
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x0020630C File Offset: 0x0020450C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273275, XrefRangeEnd = 273297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<KeyValuePair<Ingredient, int>> _UpdateIngredientCollection_b__59_0(List<KeyValuePair<Ingredient, int>> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.NativeMethodInfoPtr__UpdateIngredientCollection_b__59_0_Private_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<Ingredient, int>>>(intPtr3) : null;
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x0003A2A6 File Offset: 0x000384A6
		public StorageOtherPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x06006BA9 RID: 27561 RVA: 0x0020635C File Offset: 0x0020455C
		// (set) Token: 0x06006BAA RID: 27562 RVA: 0x0003A2AF File Offset: 0x000384AF
		public unsafe AdpProgressIndicatorComponent Scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_Scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_Scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x06006BAB RID: 27563 RVA: 0x0020638C File Offset: 0x0020458C
		// (set) Token: 0x06006BAC RID: 27564 RVA: 0x0003A2CE File Offset: 0x000384CE
		public unsafe GridLayoutGroup IngredientObjectField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_IngredientObjectField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_IngredientObjectField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x06006BAD RID: 27565 RVA: 0x002063BC File Offset: 0x002045BC
		// (set) Token: 0x06006BAE RID: 27566 RVA: 0x0003A2ED File Offset: 0x000384ED
		public unsafe CanvasGroup IngredientTagField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_IngredientTagField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_IngredientTagField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x06006BAF RID: 27567 RVA: 0x002063EC File Offset: 0x002045EC
		// (set) Token: 0x06006BB0 RID: 27568 RVA: 0x0003A30C File Offset: 0x0003850C
		public unsafe GridLayoutGroup FoodObjectField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_FoodObjectField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_FoodObjectField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x06006BB1 RID: 27569 RVA: 0x0020641C File Offset: 0x0020461C
		// (set) Token: 0x06006BB2 RID: 27570 RVA: 0x0003A32B File Offset: 0x0003852B
		public unsafe GridLayoutGroup BeverageObjectField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_BeverageObjectField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_BeverageObjectField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x06006BB3 RID: 27571 RVA: 0x0020644C File Offset: 0x0020464C
		// (set) Token: 0x06006BB4 RID: 27572 RVA: 0x0003A34A File Offset: 0x0003854A
		public unsafe GridLayoutGroup KitchenwareObjectField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_KitchenwareObjectField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_KitchenwareObjectField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x06006BB5 RID: 27573 RVA: 0x0020647C File Offset: 0x0020467C
		// (set) Token: 0x06006BB6 RID: 27574 RVA: 0x0003A369 File Offset: 0x00038569
		public unsafe GridLayoutGroup ItemObjectField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_ItemObjectField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_ItemObjectField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x06006BB7 RID: 27575 RVA: 0x002064AC File Offset: 0x002046AC
		// (set) Token: 0x06006BB8 RID: 27576 RVA: 0x0003A388 File Offset: 0x00038588
		public unsafe UIButtonSimple filterButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_filterButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_filterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x06006BB9 RID: 27577 RVA: 0x002064DC File Offset: 0x002046DC
		// (set) Token: 0x06006BBA RID: 27578 RVA: 0x0003A3A7 File Offset: 0x000385A7
		public unsafe GameObject ObjectStackParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_ObjectStackParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_ObjectStackParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x06006BBB RID: 27579 RVA: 0x0020650C File Offset: 0x0020470C
		// (set) Token: 0x06006BBC RID: 27580 RVA: 0x0003A3C6 File Offset: 0x000385C6
		public unsafe List<KeyValuePair<Sellable, int>> m_Beverages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_Beverages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Sellable, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_Beverages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x06006BBD RID: 27581 RVA: 0x0020653C File Offset: 0x0020473C
		// (set) Token: 0x06006BBE RID: 27582 RVA: 0x0003A3E5 File Offset: 0x000385E5
		public unsafe List<IFilterConfig> m_BeveragesFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_BeveragesFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_BeveragesFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x06006BBF RID: 27583 RVA: 0x0020656C File Offset: 0x0020476C
		// (set) Token: 0x06006BC0 RID: 27584 RVA: 0x0003A404 File Offset: 0x00038604
		public unsafe List<IFilterConfig> m_CookersFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_CookersFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_CookersFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x06006BC1 RID: 27585 RVA: 0x0020659C File Offset: 0x0020479C
		// (set) Token: 0x06006BC2 RID: 27586 RVA: 0x0003A423 File Offset: 0x00038623
		public unsafe List<KeyValuePair<Sellable, int>> m_Foods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_Foods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Sellable, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_Foods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x06006BC3 RID: 27587 RVA: 0x002065CC File Offset: 0x002047CC
		// (set) Token: 0x06006BC4 RID: 27588 RVA: 0x0003A442 File Offset: 0x00038642
		public unsafe List<IFilterConfig> m_FoodsFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_FoodsFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_FoodsFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x06006BC5 RID: 27589 RVA: 0x002065FC File Offset: 0x002047FC
		// (set) Token: 0x06006BC6 RID: 27590 RVA: 0x0003A461 File Offset: 0x00038661
		public unsafe List<KeyValuePair<Ingredient, int>> m_IngredientMeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientMeat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Ingredient, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientMeat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D9 RID: 9433
		// (get) Token: 0x06006BC7 RID: 27591 RVA: 0x0020662C File Offset: 0x0020482C
		// (set) Token: 0x06006BC8 RID: 27592 RVA: 0x0003A480 File Offset: 0x00038680
		public unsafe List<KeyValuePair<Ingredient, int>> m_IngredientOther
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientOther);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Ingredient, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientOther), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DA RID: 9434
		// (get) Token: 0x06006BC9 RID: 27593 RVA: 0x0020665C File Offset: 0x0020485C
		// (set) Token: 0x06006BCA RID: 27594 RVA: 0x0003A49F File Offset: 0x0003869F
		public unsafe List<KeyValuePair<Ingredient, int>> m_IngredientSeaFood
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientSeaFood);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Ingredient, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientSeaFood), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DB RID: 9435
		// (get) Token: 0x06006BCB RID: 27595 RVA: 0x0020668C File Offset: 0x0020488C
		// (set) Token: 0x06006BCC RID: 27596 RVA: 0x0003A4BE File Offset: 0x000386BE
		public unsafe List<IFilterConfig> m_IngredientsFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientsFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientsFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DC RID: 9436
		// (get) Token: 0x06006BCD RID: 27597 RVA: 0x002066BC File Offset: 0x002048BC
		// (set) Token: 0x06006BCE RID: 27598 RVA: 0x0003A4DD File Offset: 0x000386DD
		public unsafe List<KeyValuePair<Ingredient, int>> m_IngredientVeggie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientVeggie);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Ingredient, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientVeggie), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x06006BCF RID: 27599 RVA: 0x002066EC File Offset: 0x002048EC
		// (set) Token: 0x06006BD0 RID: 27600 RVA: 0x0003A4FC File Offset: 0x000386FC
		public unsafe List<IFilterConfig> m_ItemFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_ItemFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFilterConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_ItemFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DE RID: 9438
		// (get) Token: 0x06006BD1 RID: 27601 RVA: 0x0020671C File Offset: 0x0020491C
		// (set) Token: 0x06006BD2 RID: 27602 RVA: 0x0003A51B File Offset: 0x0003871B
		public unsafe List<KeyValuePair<Item, int>> m_Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Item, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DF RID: 9439
		// (get) Token: 0x06006BD3 RID: 27603 RVA: 0x0020674C File Offset: 0x0020494C
		// (set) Token: 0x06006BD4 RID: 27604 RVA: 0x0003A53A File Offset: 0x0003873A
		public unsafe List<KeyValuePair<Cooker, int>> m_Kitchenwares
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_Kitchenwares);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Cooker, int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_Kitchenwares), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x06006BD5 RID: 27605 RVA: 0x0020677C File Offset: 0x0020497C
		// (set) Token: 0x06006BD6 RID: 27606 RVA: 0x0003A559 File Offset: 0x00038759
		public unsafe List<GameObject> m_OtherObjectInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_OtherObjectInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_OtherObjectInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x06006BD7 RID: 27607 RVA: 0x002067AC File Offset: 0x002049AC
		// (set) Token: 0x06006BD8 RID: 27608 RVA: 0x0003A578 File Offset: 0x00038778
		public unsafe IStaticGridScrollListUILogicalGroup currentSelectedGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_currentSelectedGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStaticGridScrollListUILogicalGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_currentSelectedGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x06006BD9 RID: 27609 RVA: 0x002067DC File Offset: 0x002049DC
		// (set) Token: 0x06006BDA RID: 27610 RVA: 0x0003A597 File Offset: 0x00038797
		public unsafe Action<Il2CppSystem.Object> describeObjectCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_describeObjectCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_describeObjectCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E3 RID: 9443
		// (get) Token: 0x06006BDB RID: 27611 RVA: 0x0020680C File Offset: 0x00204A0C
		// (set) Token: 0x06006BDC RID: 27612 RVA: 0x0003A5B6 File Offset: 0x000387B6
		public unsafe bool enablePinning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_enablePinning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_enablePinning)) = value;
			}
		}

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x06006BDD RID: 27613 RVA: 0x00206834 File Offset: 0x00204A34
		// (set) Token: 0x06006BDE RID: 27614 RVA: 0x0003A5D1 File Offset: 0x000387D1
		public unsafe Func<int, bool> getPinnedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_getPinnedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_getPinnedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x06006BDF RID: 27615 RVA: 0x00206864 File Offset: 0x00204A64
		// (set) Token: 0x06006BE0 RID: 27616 RVA: 0x0003A5F0 File Offset: 0x000387F0
		public unsafe bool isDescriberHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_isDescriberHidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_isDescriberHidden)) = value;
			}
		}

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x06006BE1 RID: 27617 RVA: 0x0020688C File Offset: 0x00204A8C
		// (set) Token: 0x06006BE2 RID: 27618 RVA: 0x0003A60B File Offset: 0x0003880B
		public unsafe CanvasGroup m_BeverageObjectFieldCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_BeverageObjectFieldCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_BeverageObjectFieldCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x06006BE3 RID: 27619 RVA: 0x002068BC File Offset: 0x00204ABC
		// (set) Token: 0x06006BE4 RID: 27620 RVA: 0x0003A62A File Offset: 0x0003882A
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> m_BeveragesGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_BeveragesGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_BeveragesGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x06006BE5 RID: 27621 RVA: 0x002068EC File Offset: 0x00204AEC
		// (set) Token: 0x06006BE6 RID: 27622 RVA: 0x0003A649 File Offset: 0x00038849
		public unsafe Action m_CurrentSetPinnedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_CurrentSetPinnedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_CurrentSetPinnedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x06006BE7 RID: 27623 RVA: 0x0020691C File Offset: 0x00204B1C
		// (set) Token: 0x06006BE8 RID: 27624 RVA: 0x0003A668 File Offset: 0x00038868
		public unsafe CanvasGroup m_FilterButtonCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_FilterButtonCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_FilterButtonCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x06006BE9 RID: 27625 RVA: 0x0020694C File Offset: 0x00204B4C
		// (set) Token: 0x06006BEA RID: 27626 RVA: 0x0003A687 File Offset: 0x00038887
		public unsafe CanvasGroup m_FoodObjectFieldCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_FoodObjectFieldCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_FoodObjectFieldCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x06006BEB RID: 27627 RVA: 0x0020697C File Offset: 0x00204B7C
		// (set) Token: 0x06006BEC RID: 27628 RVA: 0x0003A6A6 File Offset: 0x000388A6
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple> m_FoodsGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_FoodsGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Sellable, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_FoodsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x06006BED RID: 27629 RVA: 0x002069AC File Offset: 0x00204BAC
		// (set) Token: 0x06006BEE RID: 27630 RVA: 0x0003A6C5 File Offset: 0x000388C5
		public unsafe CanvasGroup m_IngredientObjectFieldCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientObjectFieldCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientObjectFieldCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x06006BEF RID: 27631 RVA: 0x002069DC File Offset: 0x00204BDC
		// (set) Token: 0x06006BF0 RID: 27632 RVA: 0x0003A6E4 File Offset: 0x000388E4
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Ingredient, int>, UIElementCluster, UIButtonSimple> m_IngredientsGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientsGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Ingredient, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_IngredientsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x06006BF1 RID: 27633 RVA: 0x00206A0C File Offset: 0x00204C0C
		// (set) Token: 0x06006BF2 RID: 27634 RVA: 0x0003A703 File Offset: 0x00038903
		public unsafe CanvasGroup m_ItemObjectFieldCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_ItemObjectFieldCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_ItemObjectFieldCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x06006BF3 RID: 27635 RVA: 0x00206A3C File Offset: 0x00204C3C
		// (set) Token: 0x06006BF4 RID: 27636 RVA: 0x0003A722 File Offset: 0x00038922
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Item, int>, UIElementCluster, UIButtonSimple> m_ItemsGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_ItemsGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Item, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_ItemsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x06006BF5 RID: 27637 RVA: 0x00206A6C File Offset: 0x00204C6C
		// (set) Token: 0x06006BF6 RID: 27638 RVA: 0x0003A741 File Offset: 0x00038941
		public unsafe CanvasGroup m_KitchenwareObjectFieldCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_KitchenwareObjectFieldCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_KitchenwareObjectFieldCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x06006BF7 RID: 27639 RVA: 0x00206A9C File Offset: 0x00204C9C
		// (set) Token: 0x06006BF8 RID: 27640 RVA: 0x0003A760 File Offset: 0x00038960
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Cooker, int>, UIElementCluster, UIButtonSimple> m_KitchenwaresGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_KitchenwaresGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<Cooker, int>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_m_KitchenwaresGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x06006BF9 RID: 27641 RVA: 0x00206ACC File Offset: 0x00204CCC
		// (set) Token: 0x06006BFA RID: 27642 RVA: 0x0003A77F File Offset: 0x0003897F
		public unsafe Action<int, bool> setPinnedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_setPinnedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.NativeFieldInfoPtr_setPinnedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004739 RID: 18233
		private static readonly IntPtr NativeFieldInfoPtr_Scroller;

		// Token: 0x0400473A RID: 18234
		private static readonly IntPtr NativeFieldInfoPtr_IngredientObjectField;

		// Token: 0x0400473B RID: 18235
		private static readonly IntPtr NativeFieldInfoPtr_IngredientTagField;

		// Token: 0x0400473C RID: 18236
		private static readonly IntPtr NativeFieldInfoPtr_FoodObjectField;

		// Token: 0x0400473D RID: 18237
		private static readonly IntPtr NativeFieldInfoPtr_BeverageObjectField;

		// Token: 0x0400473E RID: 18238
		private static readonly IntPtr NativeFieldInfoPtr_KitchenwareObjectField;

		// Token: 0x0400473F RID: 18239
		private static readonly IntPtr NativeFieldInfoPtr_ItemObjectField;

		// Token: 0x04004740 RID: 18240
		private static readonly IntPtr NativeFieldInfoPtr_filterButton;

		// Token: 0x04004741 RID: 18241
		private static readonly IntPtr NativeFieldInfoPtr_ObjectStackParent;

		// Token: 0x04004742 RID: 18242
		private static readonly IntPtr NativeFieldInfoPtr_m_Beverages;

		// Token: 0x04004743 RID: 18243
		private static readonly IntPtr NativeFieldInfoPtr_m_BeveragesFilter;

		// Token: 0x04004744 RID: 18244
		private static readonly IntPtr NativeFieldInfoPtr_m_CookersFilter;

		// Token: 0x04004745 RID: 18245
		private static readonly IntPtr NativeFieldInfoPtr_m_Foods;

		// Token: 0x04004746 RID: 18246
		private static readonly IntPtr NativeFieldInfoPtr_m_FoodsFilter;

		// Token: 0x04004747 RID: 18247
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientMeat;

		// Token: 0x04004748 RID: 18248
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientOther;

		// Token: 0x04004749 RID: 18249
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientSeaFood;

		// Token: 0x0400474A RID: 18250
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientsFilter;

		// Token: 0x0400474B RID: 18251
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientVeggie;

		// Token: 0x0400474C RID: 18252
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemFilter;

		// Token: 0x0400474D RID: 18253
		private static readonly IntPtr NativeFieldInfoPtr_m_Items;

		// Token: 0x0400474E RID: 18254
		private static readonly IntPtr NativeFieldInfoPtr_m_Kitchenwares;

		// Token: 0x0400474F RID: 18255
		private static readonly IntPtr NativeFieldInfoPtr_m_OtherObjectInstances;

		// Token: 0x04004750 RID: 18256
		private static readonly IntPtr NativeFieldInfoPtr_currentSelectedGroup;

		// Token: 0x04004751 RID: 18257
		private static readonly IntPtr NativeFieldInfoPtr_describeObjectCallback;

		// Token: 0x04004752 RID: 18258
		private static readonly IntPtr NativeFieldInfoPtr_enablePinning;

		// Token: 0x04004753 RID: 18259
		private static readonly IntPtr NativeFieldInfoPtr_getPinnedCallback;

		// Token: 0x04004754 RID: 18260
		private static readonly IntPtr NativeFieldInfoPtr_isDescriberHidden;

		// Token: 0x04004755 RID: 18261
		private static readonly IntPtr NativeFieldInfoPtr_m_BeverageObjectFieldCanvasGroup;

		// Token: 0x04004756 RID: 18262
		private static readonly IntPtr NativeFieldInfoPtr_m_BeveragesGroup;

		// Token: 0x04004757 RID: 18263
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSetPinnedCallback;

		// Token: 0x04004758 RID: 18264
		private static readonly IntPtr NativeFieldInfoPtr_m_FilterButtonCanvasGroup;

		// Token: 0x04004759 RID: 18265
		private static readonly IntPtr NativeFieldInfoPtr_m_FoodObjectFieldCanvasGroup;

		// Token: 0x0400475A RID: 18266
		private static readonly IntPtr NativeFieldInfoPtr_m_FoodsGroup;

		// Token: 0x0400475B RID: 18267
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientObjectFieldCanvasGroup;

		// Token: 0x0400475C RID: 18268
		private static readonly IntPtr NativeFieldInfoPtr_m_IngredientsGroup;

		// Token: 0x0400475D RID: 18269
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemObjectFieldCanvasGroup;

		// Token: 0x0400475E RID: 18270
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemsGroup;

		// Token: 0x0400475F RID: 18271
		private static readonly IntPtr NativeFieldInfoPtr_m_KitchenwareObjectFieldCanvasGroup;

		// Token: 0x04004760 RID: 18272
		private static readonly IntPtr NativeFieldInfoPtr_m_KitchenwaresGroup;

		// Token: 0x04004761 RID: 18273
		private static readonly IntPtr NativeFieldInfoPtr_setPinnedCallback;

		// Token: 0x04004762 RID: 18274
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004763 RID: 18275
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004764 RID: 18276
		private static readonly IntPtr NativeMethodInfoPtr_ResetFilter_Private_Void_0;

		// Token: 0x04004765 RID: 18277
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04004766 RID: 18278
		private static readonly IntPtr NativeMethodInfoPtr_OnElementEnabled_Private_Void_KeyValuePair_2_T_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004767 RID: 18279
		private static readonly IntPtr NativeMethodInfoPtr_OnElementSelected_Private_Void_KeyValuePair_2_T_Int32_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04004768 RID: 18280
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04004769 RID: 18281
		private static readonly IntPtr NativeMethodInfoPtr_OnTertiarySwitchCalled_Private_Void_CallbackContext_0;

		// Token: 0x0400476A RID: 18282
		private static readonly IntPtr NativeMethodInfoPtr_SetParamValue_Private_Void_Boolean_Func_2_Int32_Boolean_Action_2_Int32_Boolean_Action_1_Object_IStaticGridScrollListUILogicalGroup_Boolean_0;

		// Token: 0x0400476B RID: 18283
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400476C RID: 18284
		private static readonly IntPtr NativeMethodInfoPtr_OnTertiarySwitchPresed_Private_Void_CallbackContext_0;

		// Token: 0x0400476D RID: 18285
		private static readonly IntPtr NativeMethodInfoPtr_OpenFilterPanel_Private_Void_0;

		// Token: 0x0400476E RID: 18286
		private static readonly IntPtr NativeMethodInfoPtr_HideDescriber_Private_Void_0;

		// Token: 0x0400476F RID: 18287
		private static readonly IntPtr NativeMethodInfoPtr_UpdateItemCollection_Private_Void_0;

		// Token: 0x04004770 RID: 18288
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCookerCollection_Private_Void_0;

		// Token: 0x04004771 RID: 18289
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBeverageCollection_Private_Void_0;

		// Token: 0x04004772 RID: 18290
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFoodsCollection_Private_Void_0;

		// Token: 0x04004773 RID: 18291
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIngredientCollection_Private_Void_0;

		// Token: 0x04004774 RID: 18292
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004775 RID: 18293
		private static readonly IntPtr NativeMethodInfoPtr_GetPinnedType_Private_DefaultProp_Ingredient_0;

		// Token: 0x04004776 RID: 18294
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004777 RID: 18295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004778 RID: 18296
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_1_Private_Void_0;

		// Token: 0x04004779 RID: 18297
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_15_Private_Boolean_Int32_0;

		// Token: 0x0400477A RID: 18298
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_16_Private_Void_Int32_Boolean_0;

		// Token: 0x0400477B RID: 18299
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_17_Private_Void_Object_0;

		// Token: 0x0400477C RID: 18300
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_2_Private_Void_0;

		// Token: 0x0400477D RID: 18301
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_4_Private_Void_0;

		// Token: 0x0400477E RID: 18302
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_20_Private_Void_Int32_Boolean_0;

		// Token: 0x0400477F RID: 18303
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_21_Private_Void_Object_0;

		// Token: 0x04004780 RID: 18304
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_5_Private_Void_0;

		// Token: 0x04004781 RID: 18305
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_7_Private_Void_0;

		// Token: 0x04004782 RID: 18306
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_24_Private_Void_Int32_Boolean_0;

		// Token: 0x04004783 RID: 18307
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_25_Private_Void_Object_0;

		// Token: 0x04004784 RID: 18308
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_8_Private_Void_0;

		// Token: 0x04004785 RID: 18309
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_10_Private_Void_0;

		// Token: 0x04004786 RID: 18310
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_28_Private_Void_Int32_Boolean_0;

		// Token: 0x04004787 RID: 18311
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_29_Private_Void_Object_0;

		// Token: 0x04004788 RID: 18312
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_11_Private_Void_0;

		// Token: 0x04004789 RID: 18313
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_13_Private_Void_0;

		// Token: 0x0400478A RID: 18314
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_31_Private_Void_Object_0;

		// Token: 0x0400478B RID: 18315
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_14_Private_Void_0;

		// Token: 0x0400478C RID: 18316
		private static readonly IntPtr NativeMethodInfoPtr__OpenFilterPanel_b__53_0_Private_Void_0;

		// Token: 0x0400478D RID: 18317
		private static readonly IntPtr NativeMethodInfoPtr__OpenFilterPanel_b__53_1_Private_Void_0;

		// Token: 0x0400478E RID: 18318
		private static readonly IntPtr NativeMethodInfoPtr__OpenFilterPanel_b__53_2_Private_Void_0;

		// Token: 0x0400478F RID: 18319
		private static readonly IntPtr NativeMethodInfoPtr__OpenFilterPanel_b__53_3_Private_Void_0;

		// Token: 0x04004790 RID: 18320
		private static readonly IntPtr NativeMethodInfoPtr__OpenFilterPanel_b__53_4_Private_Void_0;

		// Token: 0x04004791 RID: 18321
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_Item_PDM_0;

		// Token: 0x04004792 RID: 18322
		private static readonly IntPtr NativeMethodInfoPtr__UpdateCookerCollection_b__56_2_Private_Nullable_1_Boolean_KeyValuePair_2_Cooker_Int32_0;

		// Token: 0x04004793 RID: 18323
		private static readonly IntPtr NativeMethodInfoPtr__UpdateBeverageCollection_b__57_1_Private_Nullable_1_Boolean_KeyValuePair_2_Sellable_Int32_0;

		// Token: 0x04004794 RID: 18324
		private static readonly IntPtr NativeMethodInfoPtr__UpdateFoodsCollection_b__58_3_Private_Nullable_1_Boolean_KeyValuePair_2_Sellable_Int32_0;

		// Token: 0x04004795 RID: 18325
		private static readonly IntPtr NativeMethodInfoPtr__UpdateIngredientCollection_b__59_0_Private_IEnumerable_1_KeyValuePair_2_Ingredient_Int32_List_1_KeyValuePair_2_Ingredient_Int32_0;

		// Token: 0x02000EA9 RID: 3753
		[ObfuscatedName("Common.UI.StorageUtility.StorageOtherPannel+<>c__DisplayClass46_0`1")]
		public sealed class __c__DisplayClass46_0<T> : Il2CppSystem.Object where T : NonTradableObjectBase
		{
			// Token: 0x06010951 RID: 67921 RVA: 0x003D7954 File Offset: 0x003D5B54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_0()
			{
				Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass46_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "<>c__DisplayClass46_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass46_0<T>>.NativeClassPtr);
				StorageOtherPannel.__c__DisplayClass46_0<T>.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass46_0<T>>.NativeClassPtr, "amount");
				StorageOtherPannel.__c__DisplayClass46_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass46_0<T>>.NativeClassPtr, 100685532);
				StorageOtherPannel.__c__DisplayClass46_0<T>.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass46_0<T>>.NativeClassPtr, 100685533);
				StorageOtherPannel.__c__DisplayClass46_0<T>.NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass46_0<T>>.NativeClassPtr, 100685534);
			}

			// Token: 0x06010952 RID: 67922 RVA: 0x003D7A0C File Offset: 0x003D5C0C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass46_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass46_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010953 RID: 67923 RVA: 0x003D7A48 File Offset: 0x003D5C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass46_0<T>.NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010954 RID: 67924 RVA: 0x003D7A8C File Offset: 0x003D5C8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass46_0<T>.NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010955 RID: 67925 RVA: 0x00090BA5 File Offset: 0x0008EDA5
			public __c__DisplayClass46_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005681 RID: 22145
			// (get) Token: 0x06010956 RID: 67926 RVA: 0x003D7AD0 File Offset: 0x003D5CD0
			// (set) Token: 0x06010957 RID: 67927 RVA: 0x00090BAE File Offset: 0x0008EDAE
			public unsafe string amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass46_0<T>.NativeFieldInfoPtr_amount);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass46_0<T>.NativeFieldInfoPtr_amount), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A7D2 RID: 42962
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x0400A7D3 RID: 42963
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7D4 RID: 42964
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400A7D5 RID: 42965
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__1_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000EAA RID: 3754
		[ObfuscatedName("Common.UI.StorageUtility.StorageOtherPannel+<>c__DisplayClass47_0`1")]
		public sealed class __c__DisplayClass47_0<T> : Il2CppSystem.Object where T : NonTradableObjectBase
		{
			// Token: 0x06010958 RID: 67928 RVA: 0x003D7AF8 File Offset: 0x003D5CF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass47_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "<>c__DisplayClass47_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass47_0<T>>.NativeClassPtr);
				StorageOtherPannel.__c__DisplayClass47_0<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass47_0<T>>.NativeClassPtr, "<>4__this");
				StorageOtherPannel.__c__DisplayClass47_0<T>.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass47_0<T>>.NativeClassPtr, "value");
				StorageOtherPannel.__c__DisplayClass47_0<T>.NativeFieldInfoPtr_isPinned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass47_0<T>>.NativeClassPtr, "isPinned");
				StorageOtherPannel.__c__DisplayClass47_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass47_0<T>>.NativeClassPtr, 100685535);
				StorageOtherPannel.__c__DisplayClass47_0<T>.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass47_0<T>>.NativeClassPtr, 100685536);
			}

			// Token: 0x06010959 RID: 67929 RVA: 0x003D7BC4 File Offset: 0x003D5DC4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass47_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass47_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601095A RID: 67930 RVA: 0x003D7C00 File Offset: 0x003D5E00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271965, XrefRangeEnd = 271969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass47_0<T>.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601095B RID: 67931 RVA: 0x00090BCD File Offset: 0x0008EDCD
			public __c__DisplayClass47_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005682 RID: 22146
			// (get) Token: 0x0601095C RID: 67932 RVA: 0x003D7C34 File Offset: 0x003D5E34
			// (set) Token: 0x0601095D RID: 67933 RVA: 0x00090BD6 File Offset: 0x0008EDD6
			public unsafe StorageOtherPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass47_0<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageOtherPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass47_0<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005683 RID: 22147
			// (get) Token: 0x0601095E RID: 67934 RVA: 0x003D7C64 File Offset: 0x003D5E64
			// (set) Token: 0x0601095F RID: 67935 RVA: 0x00090BF5 File Offset: 0x0008EDF5
			public KeyValuePair<T, int> value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass47_0<T>.NativeFieldInfoPtr_value);
					return new KeyValuePair<T, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<T, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass47_0<T>.NativeFieldInfoPtr_value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<T, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005684 RID: 22148
			// (get) Token: 0x06010960 RID: 67936 RVA: 0x003D7C94 File Offset: 0x003D5E94
			// (set) Token: 0x06010961 RID: 67937 RVA: 0x00090C23 File Offset: 0x0008EE23
			public unsafe bool isPinned
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass47_0<T>.NativeFieldInfoPtr_isPinned);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass47_0<T>.NativeFieldInfoPtr_isPinned)) = value;
				}
			}

			// Token: 0x0400A7D6 RID: 42966
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7D7 RID: 42967
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400A7D8 RID: 42968
			private static readonly IntPtr NativeFieldInfoPtr_isPinned;

			// Token: 0x0400A7D9 RID: 42969
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7DA RID: 42970
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000EAB RID: 3755
		[ObfuscatedName("Common.UI.StorageUtility.StorageOtherPannel+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x06010962 RID: 67938 RVA: 0x003D7CBC File Offset: 0x003D5EBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_0>.NativeClassPtr);
				StorageOtherPannel.__c__DisplayClass51_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_0>.NativeClassPtr, "x");
				StorageOtherPannel.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_0>.NativeClassPtr, "<>4__this");
				StorageOtherPannel.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_0>.NativeClassPtr, 100685537);
				StorageOtherPannel.__c__DisplayClass51_0.NativeMethodInfoPtr__OnPanelOpen_b__18_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_0>.NativeClassPtr, 100685538);
			}

			// Token: 0x06010963 RID: 67939 RVA: 0x003D7D38 File Offset: 0x003D5F38
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010964 RID: 67940 RVA: 0x003D7D74 File Offset: 0x003D5F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271969, XrefRangeEnd = 271975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__18()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass51_0.NativeMethodInfoPtr__OnPanelOpen_b__18_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010965 RID: 67941 RVA: 0x00090C3E File Offset: 0x0008EE3E
			public __c__DisplayClass51_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005685 RID: 22149
			// (get) Token: 0x06010966 RID: 67942 RVA: 0x003D7DA8 File Offset: 0x003D5FA8
			// (set) Token: 0x06010967 RID: 67943 RVA: 0x00090C47 File Offset: 0x0008EE47
			public unsafe Il2CppSystem.Object x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_0.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_0.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005686 RID: 22150
			// (get) Token: 0x06010968 RID: 67944 RVA: 0x003D7DD8 File Offset: 0x003D5FD8
			// (set) Token: 0x06010969 RID: 67945 RVA: 0x00090C66 File Offset: 0x0008EE66
			public unsafe StorageOtherPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageOtherPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7DB RID: 42971
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400A7DC RID: 42972
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7DD RID: 42973
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7DE RID: 42974
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__18_Internal_Void_0;
		}

		// Token: 0x02000EAC RID: 3756
		[ObfuscatedName("Common.UI.StorageUtility.StorageOtherPannel+<>c__DisplayClass51_1")]
		public sealed class __c__DisplayClass51_1 : Il2CppSystem.Object
		{
			// Token: 0x0601096A RID: 67946 RVA: 0x003D7E08 File Offset: 0x003D6008
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_1()
			{
				Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "<>c__DisplayClass51_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_1>.NativeClassPtr);
				StorageOtherPannel.__c__DisplayClass51_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_1>.NativeClassPtr, "x");
				StorageOtherPannel.__c__DisplayClass51_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_1>.NativeClassPtr, "<>4__this");
				StorageOtherPannel.__c__DisplayClass51_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_1>.NativeClassPtr, 100685539);
				StorageOtherPannel.__c__DisplayClass51_1.NativeMethodInfoPtr__OnPanelOpen_b__22_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_1>.NativeClassPtr, 100685540);
			}

			// Token: 0x0601096B RID: 67947 RVA: 0x003D7E84 File Offset: 0x003D6084
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass51_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601096C RID: 67948 RVA: 0x003D7EC0 File Offset: 0x003D60C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271975, XrefRangeEnd = 271981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__22()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass51_1.NativeMethodInfoPtr__OnPanelOpen_b__22_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601096D RID: 67949 RVA: 0x00090C85 File Offset: 0x0008EE85
			public __c__DisplayClass51_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005687 RID: 22151
			// (get) Token: 0x0601096E RID: 67950 RVA: 0x003D7EF4 File Offset: 0x003D60F4
			// (set) Token: 0x0601096F RID: 67951 RVA: 0x00090C8E File Offset: 0x0008EE8E
			public unsafe Il2CppSystem.Object x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_1.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_1.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005688 RID: 22152
			// (get) Token: 0x06010970 RID: 67952 RVA: 0x003D7F24 File Offset: 0x003D6124
			// (set) Token: 0x06010971 RID: 67953 RVA: 0x00090CAD File Offset: 0x0008EEAD
			public unsafe StorageOtherPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageOtherPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7DF RID: 42975
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400A7E0 RID: 42976
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7E1 RID: 42977
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7E2 RID: 42978
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__22_Internal_Void_0;
		}

		// Token: 0x02000EAD RID: 3757
		[ObfuscatedName("Common.UI.StorageUtility.StorageOtherPannel+<>c__DisplayClass51_2")]
		public sealed class __c__DisplayClass51_2 : Il2CppSystem.Object
		{
			// Token: 0x06010972 RID: 67954 RVA: 0x003D7F54 File Offset: 0x003D6154
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_2()
			{
				Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "<>c__DisplayClass51_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_2>.NativeClassPtr);
				StorageOtherPannel.__c__DisplayClass51_2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_2>.NativeClassPtr, "x");
				StorageOtherPannel.__c__DisplayClass51_2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_2>.NativeClassPtr, "<>4__this");
				StorageOtherPannel.__c__DisplayClass51_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_2>.NativeClassPtr, 100685541);
				StorageOtherPannel.__c__DisplayClass51_2.NativeMethodInfoPtr__OnPanelOpen_b__26_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_2>.NativeClassPtr, 100685542);
			}

			// Token: 0x06010973 RID: 67955 RVA: 0x003D7FD0 File Offset: 0x003D61D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass51_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010974 RID: 67956 RVA: 0x003D800C File Offset: 0x003D620C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271981, XrefRangeEnd = 271987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__26()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass51_2.NativeMethodInfoPtr__OnPanelOpen_b__26_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010975 RID: 67957 RVA: 0x00090CCC File Offset: 0x0008EECC
			public __c__DisplayClass51_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005689 RID: 22153
			// (get) Token: 0x06010976 RID: 67958 RVA: 0x003D8040 File Offset: 0x003D6240
			// (set) Token: 0x06010977 RID: 67959 RVA: 0x00090CD5 File Offset: 0x0008EED5
			public unsafe Il2CppSystem.Object x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_2.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_2.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700568A RID: 22154
			// (get) Token: 0x06010978 RID: 67960 RVA: 0x003D8070 File Offset: 0x003D6270
			// (set) Token: 0x06010979 RID: 67961 RVA: 0x00090CF4 File Offset: 0x0008EEF4
			public unsafe StorageOtherPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageOtherPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7E3 RID: 42979
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400A7E4 RID: 42980
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7E5 RID: 42981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7E6 RID: 42982
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__26_Internal_Void_0;
		}

		// Token: 0x02000EAE RID: 3758
		[ObfuscatedName("Common.UI.StorageUtility.StorageOtherPannel+<>c__DisplayClass51_3")]
		public sealed class __c__DisplayClass51_3 : Il2CppSystem.Object
		{
			// Token: 0x0601097A RID: 67962 RVA: 0x003D80A0 File Offset: 0x003D62A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_3()
			{
				Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "<>c__DisplayClass51_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_3>.NativeClassPtr);
				StorageOtherPannel.__c__DisplayClass51_3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_3>.NativeClassPtr, "x");
				StorageOtherPannel.__c__DisplayClass51_3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_3>.NativeClassPtr, "<>4__this");
				StorageOtherPannel.__c__DisplayClass51_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_3>.NativeClassPtr, 100685543);
				StorageOtherPannel.__c__DisplayClass51_3.NativeMethodInfoPtr__OnPanelOpen_b__30_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_3>.NativeClassPtr, 100685544);
			}

			// Token: 0x0601097B RID: 67963 RVA: 0x003D811C File Offset: 0x003D631C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass51_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601097C RID: 67964 RVA: 0x003D8158 File Offset: 0x003D6358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271987, XrefRangeEnd = 271994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__30()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass51_3.NativeMethodInfoPtr__OnPanelOpen_b__30_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601097D RID: 67965 RVA: 0x00090D13 File Offset: 0x0008EF13
			public __c__DisplayClass51_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700568B RID: 22155
			// (get) Token: 0x0601097E RID: 67966 RVA: 0x003D818C File Offset: 0x003D638C
			// (set) Token: 0x0601097F RID: 67967 RVA: 0x00090D1C File Offset: 0x0008EF1C
			public unsafe Il2CppSystem.Object x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_3.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_3.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700568C RID: 22156
			// (get) Token: 0x06010980 RID: 67968 RVA: 0x003D81BC File Offset: 0x003D63BC
			// (set) Token: 0x06010981 RID: 67969 RVA: 0x00090D3B File Offset: 0x0008EF3B
			public unsafe StorageOtherPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageOtherPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7E7 RID: 42983
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400A7E8 RID: 42984
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7E9 RID: 42985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7EA RID: 42986
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__30_Internal_Void_0;
		}

		// Token: 0x02000EAF RID: 3759
		[ObfuscatedName("Common.UI.StorageUtility.StorageOtherPannel+<>c__DisplayClass51_4")]
		public sealed class __c__DisplayClass51_4 : Il2CppSystem.Object
		{
			// Token: 0x06010982 RID: 67970 RVA: 0x003D81EC File Offset: 0x003D63EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_4()
			{
				Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "<>c__DisplayClass51_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_4>.NativeClassPtr);
				StorageOtherPannel.__c__DisplayClass51_4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_4>.NativeClassPtr, "x");
				StorageOtherPannel.__c__DisplayClass51_4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_4>.NativeClassPtr, "<>4__this");
				StorageOtherPannel.__c__DisplayClass51_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_4>.NativeClassPtr, 100685545);
				StorageOtherPannel.__c__DisplayClass51_4.NativeMethodInfoPtr__OnPanelOpen_b__32_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_4>.NativeClassPtr, 100685546);
			}

			// Token: 0x06010983 RID: 67971 RVA: 0x003D8268 File Offset: 0x003D6468
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageOtherPannel.__c__DisplayClass51_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass51_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010984 RID: 67972 RVA: 0x003D82A4 File Offset: 0x003D64A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271994, XrefRangeEnd = 272001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__32()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c__DisplayClass51_4.NativeMethodInfoPtr__OnPanelOpen_b__32_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010985 RID: 67973 RVA: 0x00090D5A File Offset: 0x0008EF5A
			public __c__DisplayClass51_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700568D RID: 22157
			// (get) Token: 0x06010986 RID: 67974 RVA: 0x003D82D8 File Offset: 0x003D64D8
			// (set) Token: 0x06010987 RID: 67975 RVA: 0x00090D63 File Offset: 0x0008EF63
			public unsafe Il2CppSystem.Object x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_4.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_4.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700568E RID: 22158
			// (get) Token: 0x06010988 RID: 67976 RVA: 0x003D8308 File Offset: 0x003D6508
			// (set) Token: 0x06010989 RID: 67977 RVA: 0x00090D82 File Offset: 0x0008EF82
			public unsafe StorageOtherPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageOtherPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageOtherPannel.__c__DisplayClass51_4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7EB RID: 42987
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x0400A7EC RID: 42988
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7ED RID: 42989
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7EE RID: 42990
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__32_Internal_Void_0;
		}

		// Token: 0x02000EB0 RID: 3760
		[ObfuscatedName("Common.UI.StorageUtility.StorageOtherPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0601098A RID: 67978 RVA: 0x003D8338 File Offset: 0x003D6538
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr);
				StorageOtherPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__51_0");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__51_3");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__51_19");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__51_6");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__51_23");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__51_9");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__51_27");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__51_12");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__55_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__55_0");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__55_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__55_1");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__55_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__55_2");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__56_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__56_0");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__56_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__56_1");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__57_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__57_0");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__58_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__58_0");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__58_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__58_1");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__58_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__58_2");
				StorageOtherPannel.__c.NativeFieldInfoPtr___9__59_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, "<>9__59_1");
				StorageOtherPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685548);
				StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685549);
				StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685550);
				StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_19_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685551);
				StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_6_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685552);
				StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_23_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685553);
				StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_9_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685554);
				StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_27_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685555);
				StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_12_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685556);
				StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateItemCollection_b__55_0_Internal_Int32_KeyValuePair_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685557);
				StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateItemCollection_b__55_1_Internal_Int32_KeyValuePair_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685558);
				StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateItemCollection_b__55_2_Internal_Item_KeyValuePair_2_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685559);
				StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateCookerCollection_b__56_0_Internal_Int32_KeyValuePair_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685560);
				StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateCookerCollection_b__56_1_Internal_Cooker_KeyValuePair_2_Cooker_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685561);
				StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateBeverageCollection_b__57_0_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685562);
				StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateFoodsCollection_b__58_0_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685563);
				StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateFoodsCollection_b__58_1_Internal_Sellable_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685564);
				StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateFoodsCollection_b__58_2_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685565);
				StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateIngredientCollection_b__59_1_Internal_Ingredient_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr, 100685566);
			}

			// Token: 0x0601098B RID: 67979 RVA: 0x003D865C File Offset: 0x003D685C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageOtherPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601098C RID: 67980 RVA: 0x003D8698 File Offset: 0x003D6898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272001, XrefRangeEnd = 272005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__51_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601098D RID: 67981 RVA: 0x003D86D4 File Offset: 0x003D68D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272005, XrefRangeEnd = 272010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__51_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601098E RID: 67982 RVA: 0x003D8710 File Offset: 0x003D6910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272010, XrefRangeEnd = 272012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__51_19(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_19_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0601098F RID: 67983 RVA: 0x003D875C File Offset: 0x003D695C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272012, XrefRangeEnd = 272016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__51_6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_6_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010990 RID: 67984 RVA: 0x003D8798 File Offset: 0x003D6998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272016, XrefRangeEnd = 272020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__51_23(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_23_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010991 RID: 67985 RVA: 0x003D87E4 File Offset: 0x003D69E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272020, XrefRangeEnd = 272024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__51_9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_9_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010992 RID: 67986 RVA: 0x003D8820 File Offset: 0x003D6A20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272024, XrefRangeEnd = 272028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__51_27(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_27_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010993 RID: 67987 RVA: 0x003D886C File Offset: 0x003D6A6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272028, XrefRangeEnd = 272029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__51_12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__51_12_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010994 RID: 67988 RVA: 0x003D88A8 File Offset: 0x003D6AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272029, XrefRangeEnd = 272033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _UpdateItemCollection_b__55_0(KeyValuePair<Item, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateItemCollection_b__55_0_Internal_Int32_KeyValuePair_2_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010995 RID: 67989 RVA: 0x003D88FC File Offset: 0x003D6AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272033, XrefRangeEnd = 272034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _UpdateItemCollection_b__55_1(KeyValuePair<Item, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateItemCollection_b__55_1_Internal_Int32_KeyValuePair_2_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010996 RID: 67990 RVA: 0x003D8950 File Offset: 0x003D6B50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272034, XrefRangeEnd = 272035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Item _UpdateItemCollection_b__55_2(KeyValuePair<Item, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateItemCollection_b__55_2_Internal_Item_KeyValuePair_2_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Item>(intPtr3) : null;
			}

			// Token: 0x06010997 RID: 67991 RVA: 0x003D89A8 File Offset: 0x003D6BA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272035, XrefRangeEnd = 272036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _UpdateCookerCollection_b__56_0(KeyValuePair<Cooker, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateCookerCollection_b__56_0_Internal_Int32_KeyValuePair_2_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010998 RID: 67992 RVA: 0x003D89FC File Offset: 0x003D6BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272036, XrefRangeEnd = 272037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Cooker _UpdateCookerCollection_b__56_1(KeyValuePair<Cooker, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateCookerCollection_b__56_1_Internal_Cooker_KeyValuePair_2_Cooker_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cooker>(intPtr3) : null;
			}

			// Token: 0x06010999 RID: 67993 RVA: 0x003D8A54 File Offset: 0x003D6C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272037, XrefRangeEnd = 272038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _UpdateBeverageCollection_b__57_0(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateBeverageCollection_b__57_0_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0601099A RID: 67994 RVA: 0x003D8AAC File Offset: 0x003D6CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272038, XrefRangeEnd = 272039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _UpdateFoodsCollection_b__58_0(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateFoodsCollection_b__58_0_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0601099B RID: 67995 RVA: 0x003D8B04 File Offset: 0x003D6D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _UpdateFoodsCollection_b__58_1(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateFoodsCollection_b__58_1_Internal_Sellable_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0601099C RID: 67996 RVA: 0x003D8B54 File Offset: 0x003D6D54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272039, XrefRangeEnd = 272040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _UpdateFoodsCollection_b__58_2(KeyValuePair<Sellable, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateFoodsCollection_b__58_2_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0601099D RID: 67997 RVA: 0x003D8BAC File Offset: 0x003D6DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272040, XrefRangeEnd = 272041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _UpdateIngredientCollection_b__59_1(KeyValuePair<Ingredient, int> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageOtherPannel.__c.NativeMethodInfoPtr__UpdateIngredientCollection_b__59_1_Internal_Ingredient_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0601099E RID: 67998 RVA: 0x00090DA1 File Offset: 0x0008EFA1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700568F RID: 22159
			// (get) Token: 0x0601099F RID: 67999 RVA: 0x003D8C04 File Offset: 0x003D6E04
			// (set) Token: 0x060109A0 RID: 68000 RVA: 0x00090DAA File Offset: 0x0008EFAA
			public unsafe static StorageOtherPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageOtherPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005690 RID: 22160
			// (get) Token: 0x060109A1 RID: 68001 RVA: 0x003D8C2C File Offset: 0x003D6E2C
			// (set) Token: 0x060109A2 RID: 68002 RVA: 0x00090DBC File Offset: 0x0008EFBC
			public unsafe static Func<bool> __9__51_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005691 RID: 22161
			// (get) Token: 0x060109A3 RID: 68003 RVA: 0x003D8C54 File Offset: 0x003D6E54
			// (set) Token: 0x060109A4 RID: 68004 RVA: 0x00090DCE File Offset: 0x0008EFCE
			public unsafe static Func<bool> __9__51_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005692 RID: 22162
			// (get) Token: 0x060109A5 RID: 68005 RVA: 0x003D8C7C File Offset: 0x003D6E7C
			// (set) Token: 0x060109A6 RID: 68006 RVA: 0x00090DE0 File Offset: 0x0008EFE0
			public unsafe static Func<int, bool> __9__51_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005693 RID: 22163
			// (get) Token: 0x060109A7 RID: 68007 RVA: 0x003D8CA4 File Offset: 0x003D6EA4
			// (set) Token: 0x060109A8 RID: 68008 RVA: 0x00090DF2 File Offset: 0x0008EFF2
			public unsafe static Func<bool> __9__51_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005694 RID: 22164
			// (get) Token: 0x060109A9 RID: 68009 RVA: 0x003D8CCC File Offset: 0x003D6ECC
			// (set) Token: 0x060109AA RID: 68010 RVA: 0x00090E04 File Offset: 0x0008F004
			public unsafe static Func<int, bool> __9__51_23
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_23, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_23, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005695 RID: 22165
			// (get) Token: 0x060109AB RID: 68011 RVA: 0x003D8CF4 File Offset: 0x003D6EF4
			// (set) Token: 0x060109AC RID: 68012 RVA: 0x00090E16 File Offset: 0x0008F016
			public unsafe static Func<bool> __9__51_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005696 RID: 22166
			// (get) Token: 0x060109AD RID: 68013 RVA: 0x003D8D1C File Offset: 0x003D6F1C
			// (set) Token: 0x060109AE RID: 68014 RVA: 0x00090E28 File Offset: 0x0008F028
			public unsafe static Func<int, bool> __9__51_27
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_27, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_27, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005697 RID: 22167
			// (get) Token: 0x060109AF RID: 68015 RVA: 0x003D8D44 File Offset: 0x003D6F44
			// (set) Token: 0x060109B0 RID: 68016 RVA: 0x00090E3A File Offset: 0x0008F03A
			public unsafe static Func<bool> __9__51_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__51_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005698 RID: 22168
			// (get) Token: 0x060109B1 RID: 68017 RVA: 0x003D8D6C File Offset: 0x003D6F6C
			// (set) Token: 0x060109B2 RID: 68018 RVA: 0x00090E4C File Offset: 0x0008F04C
			public unsafe static Func<KeyValuePair<Item, int>, int> __9__55_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__55_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Item, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__55_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005699 RID: 22169
			// (get) Token: 0x060109B3 RID: 68019 RVA: 0x003D8D94 File Offset: 0x003D6F94
			// (set) Token: 0x060109B4 RID: 68020 RVA: 0x00090E5E File Offset: 0x0008F05E
			public unsafe static Func<KeyValuePair<Item, int>, int> __9__55_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__55_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Item, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__55_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700569A RID: 22170
			// (get) Token: 0x060109B5 RID: 68021 RVA: 0x003D8DBC File Offset: 0x003D6FBC
			// (set) Token: 0x060109B6 RID: 68022 RVA: 0x00090E70 File Offset: 0x0008F070
			public unsafe static Func<KeyValuePair<Item, int>, Item> __9__55_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__55_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Item, int>, Item>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__55_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700569B RID: 22171
			// (get) Token: 0x060109B7 RID: 68023 RVA: 0x003D8DE4 File Offset: 0x003D6FE4
			// (set) Token: 0x060109B8 RID: 68024 RVA: 0x00090E82 File Offset: 0x0008F082
			public unsafe static Func<KeyValuePair<Cooker, int>, int> __9__56_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__56_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Cooker, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__56_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700569C RID: 22172
			// (get) Token: 0x060109B9 RID: 68025 RVA: 0x003D8E0C File Offset: 0x003D700C
			// (set) Token: 0x060109BA RID: 68026 RVA: 0x00090E94 File Offset: 0x0008F094
			public unsafe static Func<KeyValuePair<Cooker, int>, Cooker> __9__56_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__56_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Cooker, int>, Cooker>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__56_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700569D RID: 22173
			// (get) Token: 0x060109BB RID: 68027 RVA: 0x003D8E34 File Offset: 0x003D7034
			// (set) Token: 0x060109BC RID: 68028 RVA: 0x00090EA6 File Offset: 0x0008F0A6
			public unsafe static Func<KeyValuePair<Sellable, int>, Sellable> __9__57_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__57_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__57_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700569E RID: 22174
			// (get) Token: 0x060109BD RID: 68029 RVA: 0x003D8E5C File Offset: 0x003D705C
			// (set) Token: 0x060109BE RID: 68030 RVA: 0x00090EB8 File Offset: 0x0008F0B8
			public unsafe static Func<KeyValuePair<Sellable, int>, Sellable> __9__58_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__58_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__58_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700569F RID: 22175
			// (get) Token: 0x060109BF RID: 68031 RVA: 0x003D8E84 File Offset: 0x003D7084
			// (set) Token: 0x060109C0 RID: 68032 RVA: 0x00090ECA File Offset: 0x0008F0CA
			public unsafe static Func<Recipe, Sellable> __9__58_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__58_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__58_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056A0 RID: 22176
			// (get) Token: 0x060109C1 RID: 68033 RVA: 0x003D8EAC File Offset: 0x003D70AC
			// (set) Token: 0x060109C2 RID: 68034 RVA: 0x00090EDC File Offset: 0x0008F0DC
			public unsafe static Func<KeyValuePair<Sellable, int>, Sellable> __9__58_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__58_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Sellable, int>, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__58_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056A1 RID: 22177
			// (get) Token: 0x060109C3 RID: 68035 RVA: 0x003D8ED4 File Offset: 0x003D70D4
			// (set) Token: 0x060109C4 RID: 68036 RVA: 0x00090EEE File Offset: 0x0008F0EE
			public unsafe static Func<KeyValuePair<Ingredient, int>, Ingredient> __9__59_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__59_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StorageOtherPannel.__c.NativeFieldInfoPtr___9__59_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7EF RID: 42991
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A7F0 RID: 42992
			private static readonly IntPtr NativeFieldInfoPtr___9__51_0;

			// Token: 0x0400A7F1 RID: 42993
			private static readonly IntPtr NativeFieldInfoPtr___9__51_3;

			// Token: 0x0400A7F2 RID: 42994
			private static readonly IntPtr NativeFieldInfoPtr___9__51_19;

			// Token: 0x0400A7F3 RID: 42995
			private static readonly IntPtr NativeFieldInfoPtr___9__51_6;

			// Token: 0x0400A7F4 RID: 42996
			private static readonly IntPtr NativeFieldInfoPtr___9__51_23;

			// Token: 0x0400A7F5 RID: 42997
			private static readonly IntPtr NativeFieldInfoPtr___9__51_9;

			// Token: 0x0400A7F6 RID: 42998
			private static readonly IntPtr NativeFieldInfoPtr___9__51_27;

			// Token: 0x0400A7F7 RID: 42999
			private static readonly IntPtr NativeFieldInfoPtr___9__51_12;

			// Token: 0x0400A7F8 RID: 43000
			private static readonly IntPtr NativeFieldInfoPtr___9__55_0;

			// Token: 0x0400A7F9 RID: 43001
			private static readonly IntPtr NativeFieldInfoPtr___9__55_1;

			// Token: 0x0400A7FA RID: 43002
			private static readonly IntPtr NativeFieldInfoPtr___9__55_2;

			// Token: 0x0400A7FB RID: 43003
			private static readonly IntPtr NativeFieldInfoPtr___9__56_0;

			// Token: 0x0400A7FC RID: 43004
			private static readonly IntPtr NativeFieldInfoPtr___9__56_1;

			// Token: 0x0400A7FD RID: 43005
			private static readonly IntPtr NativeFieldInfoPtr___9__57_0;

			// Token: 0x0400A7FE RID: 43006
			private static readonly IntPtr NativeFieldInfoPtr___9__58_0;

			// Token: 0x0400A7FF RID: 43007
			private static readonly IntPtr NativeFieldInfoPtr___9__58_1;

			// Token: 0x0400A800 RID: 43008
			private static readonly IntPtr NativeFieldInfoPtr___9__58_2;

			// Token: 0x0400A801 RID: 43009
			private static readonly IntPtr NativeFieldInfoPtr___9__59_1;

			// Token: 0x0400A802 RID: 43010
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A803 RID: 43011
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_0_Internal_Boolean_0;

			// Token: 0x0400A804 RID: 43012
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_3_Internal_Boolean_0;

			// Token: 0x0400A805 RID: 43013
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_19_Internal_Boolean_Int32_0;

			// Token: 0x0400A806 RID: 43014
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_6_Internal_Boolean_0;

			// Token: 0x0400A807 RID: 43015
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_23_Internal_Boolean_Int32_0;

			// Token: 0x0400A808 RID: 43016
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_9_Internal_Boolean_0;

			// Token: 0x0400A809 RID: 43017
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_27_Internal_Boolean_Int32_0;

			// Token: 0x0400A80A RID: 43018
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__51_12_Internal_Boolean_0;

			// Token: 0x0400A80B RID: 43019
			private static readonly IntPtr NativeMethodInfoPtr__UpdateItemCollection_b__55_0_Internal_Int32_KeyValuePair_2_Item_Int32_0;

			// Token: 0x0400A80C RID: 43020
			private static readonly IntPtr NativeMethodInfoPtr__UpdateItemCollection_b__55_1_Internal_Int32_KeyValuePair_2_Item_Int32_0;

			// Token: 0x0400A80D RID: 43021
			private static readonly IntPtr NativeMethodInfoPtr__UpdateItemCollection_b__55_2_Internal_Item_KeyValuePair_2_Item_Int32_0;

			// Token: 0x0400A80E RID: 43022
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCookerCollection_b__56_0_Internal_Int32_KeyValuePair_2_Cooker_Int32_0;

			// Token: 0x0400A80F RID: 43023
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCookerCollection_b__56_1_Internal_Cooker_KeyValuePair_2_Cooker_Int32_0;

			// Token: 0x0400A810 RID: 43024
			private static readonly IntPtr NativeMethodInfoPtr__UpdateBeverageCollection_b__57_0_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A811 RID: 43025
			private static readonly IntPtr NativeMethodInfoPtr__UpdateFoodsCollection_b__58_0_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A812 RID: 43026
			private static readonly IntPtr NativeMethodInfoPtr__UpdateFoodsCollection_b__58_1_Internal_Sellable_Recipe_0;

			// Token: 0x0400A813 RID: 43027
			private static readonly IntPtr NativeMethodInfoPtr__UpdateFoodsCollection_b__58_2_Internal_Sellable_KeyValuePair_2_Sellable_Int32_0;

			// Token: 0x0400A814 RID: 43028
			private static readonly IntPtr NativeMethodInfoPtr__UpdateIngredientCollection_b__59_1_Internal_Ingredient_KeyValuePair_2_Ingredient_Int32_0;
		}

		// Token: 0x02000EB1 RID: 3761
		private sealed class MethodInfoStoreGeneric_OnElementEnabled_Private_Void_KeyValuePair_2_T_Int32_UIElementCluster_UIButtonSimple_0<T>
		{
			// Token: 0x0400A815 RID: 43029
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StorageOtherPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_KeyValuePair_2_T_Int32_UIElementCluster_UIButtonSimple_0, Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000EB2 RID: 3762
		private sealed class MethodInfoStoreGeneric_OnElementSelected_Private_Void_KeyValuePair_2_T_Int32_UIElementCluster_UIButtonSimple_0<T>
		{
			// Token: 0x0400A816 RID: 43030
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StorageOtherPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_KeyValuePair_2_T_Int32_UIElementCluster_UIButtonSimple_0, Il2CppClassPointerStore<StorageOtherPannel>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
