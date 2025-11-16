using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.Core.UILogicalGroup;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading;
using Plugins.DEYU;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000384 RID: 900
	public class DailyRecipePrinterNew : MonoBehaviour
	{
		// Token: 0x06006AC4 RID: 27332 RVA: 0x002028A8 File Offset: 0x00200AA8
		// Note: this type is marked as 'beforefieldinit'.
		static DailyRecipePrinterNew()
		{
			Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "DailyRecipePrinterNew");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr);
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_Scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_Scheduler");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_RecipeGrid");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_BeverageGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_BeverageGrid");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_RecipeParent");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_BeverageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_BeverageParent");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_RecipeScroller");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_BeverageScroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_BeverageScroller");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_DescriberPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_DescriberPanel");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_Describer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_Describer");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_Check = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_Check");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_Cross");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_CheckColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_CheckColor");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_CrossColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_CrossColor");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_LockColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_LockColor");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeNamePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_RecipeNamePrefix");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_BeverageList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_BeverageList");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_RecipeList");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_RegisteredCookerTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_RegisteredCookerTypes");
			DailyRecipePrinterNew.NativeFieldInfoPtr_m_GetTokenCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "m_GetTokenCallback");
			DailyRecipePrinterNew.NativeFieldInfoPtr__RegisteredRecipeGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "<RegisteredRecipeGroup>k__BackingField");
			DailyRecipePrinterNew.NativeFieldInfoPtr__RegisteredBeverageGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "<RegisteredBeverageGroup>k__BackingField");
			DailyRecipePrinterNew.NativeFieldInfoPtr_RecipeSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "RecipeSelected");
			DailyRecipePrinterNew.NativeFieldInfoPtr_BeverageSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "BeverageSelected");
			DailyRecipePrinterNew.NativeFieldInfoPtr_OnDescribeRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "OnDescribeRecipe");
			DailyRecipePrinterNew.NativeFieldInfoPtr_OnRecipeCustomLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "OnRecipeCustomLoop");
			DailyRecipePrinterNew.NativeFieldInfoPtr_OnBeverageCustomLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "OnBeverageCustomLoop");
			DailyRecipePrinterNew.NativeFieldInfoPtr_OnRegisteredRecipeUpDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "OnRegisteredRecipeUpDown");
			DailyRecipePrinterNew.NativeFieldInfoPtr_OnRegisteredBeverageUpDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "OnRegisteredBeverageUpDown");
			DailyRecipePrinterNew.NativeMethodInfoPtr_get_RegisteredRecipeGroup_Public_get_StaticHorizontalGridScrollListUILogicalGroupT_3_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685371);
			DailyRecipePrinterNew.NativeMethodInfoPtr_set_RegisteredRecipeGroup_Private_set_Void_StaticHorizontalGridScrollListUILogicalGroupT_3_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685372);
			DailyRecipePrinterNew.NativeMethodInfoPtr_get_RegisteredBeverageGroup_Public_get_StaticHorizontalGridScrollListUILogicalGroupT_3_Sellable_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685373);
			DailyRecipePrinterNew.NativeMethodInfoPtr_set_RegisteredBeverageGroup_Private_set_Void_StaticHorizontalGridScrollListUILogicalGroupT_3_Sellable_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685374);
			DailyRecipePrinterNew.NativeMethodInfoPtr_get_RegisteredRecipeList_Public_get_IReadOnlyList_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685375);
			DailyRecipePrinterNew.NativeMethodInfoPtr_get_RegisteredBeverageList_Public_get_IReadOnlyList_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685376);
			DailyRecipePrinterNew.NativeMethodInfoPtr_get_Describer_Public_get_SellableDescriber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685377);
			DailyRecipePrinterNew.NativeMethodInfoPtr_get_Scheduler_Public_get_ActionExecutionScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685378);
			DailyRecipePrinterNew.NativeMethodInfoPtr_add_RecipeSelected_Public_add_Void_Action_3_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685379);
			DailyRecipePrinterNew.NativeMethodInfoPtr_remove_RecipeSelected_Public_rem_Void_Action_3_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685380);
			DailyRecipePrinterNew.NativeMethodInfoPtr_add_BeverageSelected_Public_add_Void_Action_3_Sellable_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685381);
			DailyRecipePrinterNew.NativeMethodInfoPtr_remove_BeverageSelected_Public_rem_Void_Action_3_Sellable_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685382);
			DailyRecipePrinterNew.NativeMethodInfoPtr_add_OnDescribeRecipe_Public_add_Void_Action_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685383);
			DailyRecipePrinterNew.NativeMethodInfoPtr_remove_OnDescribeRecipe_Public_rem_Void_Action_1_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685384);
			DailyRecipePrinterNew.NativeMethodInfoPtr_add_OnRecipeCustomLoop_Public_add_Void_Action_2_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685385);
			DailyRecipePrinterNew.NativeMethodInfoPtr_remove_OnRecipeCustomLoop_Public_rem_Void_Action_2_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685386);
			DailyRecipePrinterNew.NativeMethodInfoPtr_add_OnBeverageCustomLoop_Public_add_Void_Action_2_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685387);
			DailyRecipePrinterNew.NativeMethodInfoPtr_remove_OnBeverageCustomLoop_Public_rem_Void_Action_2_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685388);
			DailyRecipePrinterNew.NativeMethodInfoPtr_add_OnRegisteredRecipeUpDown_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685389);
			DailyRecipePrinterNew.NativeMethodInfoPtr_remove_OnRegisteredRecipeUpDown_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685390);
			DailyRecipePrinterNew.NativeMethodInfoPtr_add_OnRegisteredBeverageUpDown_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685391);
			DailyRecipePrinterNew.NativeMethodInfoPtr_remove_OnRegisteredBeverageUpDown_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685392);
			DailyRecipePrinterNew.NativeMethodInfoPtr_Init_Public_Void_Boolean_Func_1_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685393);
			DailyRecipePrinterNew.NativeMethodInfoPtr_OnRecipeCustomLoopCalled_Private_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685394);
			DailyRecipePrinterNew.NativeMethodInfoPtr_OnBeverageCustomLoopCalled_Private_Void_Int32_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685395);
			DailyRecipePrinterNew.NativeMethodInfoPtr_OnFoodEnabled_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685396);
			DailyRecipePrinterNew.NativeMethodInfoPtr_InitValidRecipe_Private_Void_Recipe_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685397);
			DailyRecipePrinterNew.NativeMethodInfoPtr_OnBeverageEnabled_Private_Void_Sellable_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685398);
			DailyRecipePrinterNew.NativeMethodInfoPtr_InitValidBeverage_Private_Static_Void_Sellable_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685399);
			DailyRecipePrinterNew.NativeMethodInfoPtr_OnElementEnabledShared_Private_Void_TValue_UIElementCluster_Action_2_TValue_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685400);
			DailyRecipePrinterNew.NativeMethodInfoPtr_OnFoodSelected_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685401);
			DailyRecipePrinterNew.NativeMethodInfoPtr_OnBeverageSelected_Private_Void_Sellable_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685402);
			DailyRecipePrinterNew.NativeMethodInfoPtr_UpdateDaily_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685403);
			DailyRecipePrinterNew.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685404);
			DailyRecipePrinterNew.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685405);
			DailyRecipePrinterNew.NativeMethodInfoPtr__UpdateDaily_b__66_1_Private_Void_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685406);
			DailyRecipePrinterNew.NativeMethodInfoPtr_Method_Internal_Static_Void_List_1_T_IEnumerable_1_T_Int32_IStaticGridScrollListUILogicalGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, 100685407);
		}

		// Token: 0x170024A5 RID: 9381
		// (get) Token: 0x06006AC5 RID: 27333 RVA: 0x00202DEC File Offset: 0x00200FEC
		// (set) Token: 0x06006AC6 RID: 27334 RVA: 0x00202E2C File Offset: 0x0020102C
		public unsafe StaticHorizontalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple> RegisteredRecipeGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_get_RegisteredRecipeGroup_Public_get_StaticHorizontalGridScrollListUILogicalGroupT_3_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StaticHorizontalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_set_RegisteredRecipeGroup_Private_set_Void_StaticHorizontalGridScrollListUILogicalGroupT_3_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x06006AC7 RID: 27335 RVA: 0x00202E70 File Offset: 0x00201070
		// (set) Token: 0x06006AC8 RID: 27336 RVA: 0x00202EB0 File Offset: 0x002010B0
		public unsafe StaticHorizontalGridScrollListUILogicalGroupT<Sellable, UIElementCluster, UIButtonSimple> RegisteredBeverageGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_get_RegisteredBeverageGroup_Public_get_StaticHorizontalGridScrollListUILogicalGroupT_3_Sellable_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StaticHorizontalGridScrollListUILogicalGroupT<Sellable, UIElementCluster, UIButtonSimple>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_set_RegisteredBeverageGroup_Private_set_Void_StaticHorizontalGridScrollListUILogicalGroupT_3_Sellable_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x06006AC9 RID: 27337 RVA: 0x00202EF4 File Offset: 0x002010F4
		public unsafe IReadOnlyList<Recipe> RegisteredRecipeList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_get_RegisteredRecipeList_Public_get_IReadOnlyList_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Recipe>>(intPtr3) : null;
			}
		}

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x06006ACA RID: 27338 RVA: 0x00202F34 File Offset: 0x00201134
		public unsafe IReadOnlyList<Sellable> RegisteredBeverageList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_get_RegisteredBeverageList_Public_get_IReadOnlyList_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Sellable>>(intPtr3) : null;
			}
		}

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x06006ACB RID: 27339 RVA: 0x00202F74 File Offset: 0x00201174
		public unsafe SellableDescriber Describer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_get_Describer_Public_get_SellableDescriber_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr3) : null;
			}
		}

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x06006ACC RID: 27340 RVA: 0x00202FB4 File Offset: 0x002011B4
		public unsafe ActionExecutionScheduler Scheduler
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_get_Scheduler_Public_get_ActionExecutionScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x06006ACD RID: 27341 RVA: 0x00202FF4 File Offset: 0x002011F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271283, XrefRangeEnd = 271288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_RecipeSelected(Action<Recipe, UIElementCluster, UIButtonSimple> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_add_RecipeSelected_Public_add_Void_Action_3_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x00203038 File Offset: 0x00201238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271288, XrefRangeEnd = 271293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_RecipeSelected(Action<Recipe, UIElementCluster, UIButtonSimple> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_remove_RecipeSelected_Public_rem_Void_Action_3_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x0020307C File Offset: 0x0020127C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271298, RefRangeEnd = 271299, XrefRangeStart = 271293, XrefRangeEnd = 271298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_BeverageSelected(Action<Sellable, UIElementCluster, UIButtonSimple> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_add_BeverageSelected_Public_add_Void_Action_3_Sellable_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x002030C0 File Offset: 0x002012C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271299, XrefRangeEnd = 271304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_BeverageSelected(Action<Sellable, UIElementCluster, UIButtonSimple> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_remove_BeverageSelected_Public_rem_Void_Action_3_Sellable_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD1 RID: 27345 RVA: 0x00203104 File Offset: 0x00201304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271309, RefRangeEnd = 271310, XrefRangeStart = 271304, XrefRangeEnd = 271309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnDescribeRecipe(Action<Recipe> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_add_OnDescribeRecipe_Public_add_Void_Action_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD2 RID: 27346 RVA: 0x00203148 File Offset: 0x00201348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271310, XrefRangeEnd = 271315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnDescribeRecipe(Action<Recipe> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_remove_OnDescribeRecipe_Public_rem_Void_Action_1_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x0020318C File Offset: 0x0020138C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271315, XrefRangeEnd = 271320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRecipeCustomLoop(Action<int, MoveDirection> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_add_OnRecipeCustomLoop_Public_add_Void_Action_2_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x002031D0 File Offset: 0x002013D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271320, XrefRangeEnd = 271325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRecipeCustomLoop(Action<int, MoveDirection> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_remove_OnRecipeCustomLoop_Public_rem_Void_Action_2_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x00203214 File Offset: 0x00201414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271330, RefRangeEnd = 271331, XrefRangeStart = 271325, XrefRangeEnd = 271330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnBeverageCustomLoop(Action<int, MoveDirection> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_add_OnBeverageCustomLoop_Public_add_Void_Action_2_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD6 RID: 27350 RVA: 0x00203258 File Offset: 0x00201458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271331, XrefRangeEnd = 271336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnBeverageCustomLoop(Action<int, MoveDirection> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_remove_OnBeverageCustomLoop_Public_rem_Void_Action_2_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD7 RID: 27351 RVA: 0x0020329C File Offset: 0x0020149C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271336, XrefRangeEnd = 271340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRegisteredRecipeUpDown(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_add_OnRegisteredRecipeUpDown_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x002032E0 File Offset: 0x002014E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271340, XrefRangeEnd = 271344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRegisteredRecipeUpDown(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_remove_OnRegisteredRecipeUpDown_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x00203324 File Offset: 0x00201524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271348, RefRangeEnd = 271349, XrefRangeStart = 271344, XrefRangeEnd = 271348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRegisteredBeverageUpDown(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_add_OnRegisteredBeverageUpDown_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x00203368 File Offset: 0x00201568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271349, XrefRangeEnd = 271353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRegisteredBeverageUpDown(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_remove_OnRegisteredBeverageUpDown_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x002033AC File Offset: 0x002015AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271475, RefRangeEnd = 271477, XrefRangeStart = 271353, XrefRangeEnd = 271475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(bool noVerticalMovement, Func<CancellationToken> getTokenCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref noVerticalMovement;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getTokenCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_Init_Public_Void_Boolean_Func_1_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x002033FC File Offset: 0x002015FC
		[CallerCount(0)]
		public unsafe void OnRecipeCustomLoopCalled(int index, MoveDirection moveDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_OnRecipeCustomLoopCalled_Private_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x00203448 File Offset: 0x00201648
		[CallerCount(0)]
		public unsafe void OnBeverageCustomLoopCalled(int index, MoveDirection moveDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_OnBeverageCustomLoopCalled_Private_Void_Int32_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ADE RID: 27358 RVA: 0x00203494 File Offset: 0x00201694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271477, XrefRangeEnd = 271487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFoodEnabled(Recipe recipe, UIElementCluster ui, UIButtonSimple visual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_OnFoodEnabled_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006ADF RID: 27359 RVA: 0x002034FC File Offset: 0x002016FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271487, XrefRangeEnd = 271547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitValidRecipe(Recipe recipe, UIElementCluster ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_InitValidRecipe_Private_Void_Recipe_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE0 RID: 27360 RVA: 0x00203550 File Offset: 0x00201750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271547, XrefRangeEnd = 271557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeverageEnabled(Sellable beverage, UIElementCluster ui, UIButtonSimple visual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beverage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_OnBeverageEnabled_Private_Void_Sellable_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE1 RID: 27361 RVA: 0x002035B8 File Offset: 0x002017B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271557, XrefRangeEnd = 271581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitValidBeverage(Sellable beverage, UIElementCluster ui)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beverage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_InitValidBeverage_Private_Static_Void_Sellable_UIElementCluster_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE2 RID: 27362 RVA: 0x00203600 File Offset: 0x00201800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271600, RefRangeEnd = 271602, XrefRangeStart = 271581, XrefRangeEnd = 271600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementEnabledShared<TValue>(TValue value, UIElementCluster ui, Action<TValue, UIElementCluster> initValidCallback) where TValue : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initValidCallback);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.MethodInfoStoreGeneric_OnElementEnabledShared_Private_Void_TValue_UIElementCluster_Action_2_TValue_UIElementCluster_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06006AE3 RID: 27363 RVA: 0x0020369C File Offset: 0x0020189C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271602, XrefRangeEnd = 271615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFoodSelected(Recipe recipe, UIElementCluster ui, UIButtonSimple visual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_OnFoodSelected_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE4 RID: 27364 RVA: 0x00203704 File Offset: 0x00201904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271615, XrefRangeEnd = 271628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeverageSelected(Sellable beverage, UIElementCluster ui, UIButtonSimple visual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beverage);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ui);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_OnBeverageSelected_Private_Void_Sellable_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE5 RID: 27365 RVA: 0x0020376C File Offset: 0x0020196C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271671, RefRangeEnd = 271673, XrefRangeStart = 271628, XrefRangeEnd = 271671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDaily()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr_UpdateDaily_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE6 RID: 27366 RVA: 0x002037A0 File Offset: 0x002019A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271673, XrefRangeEnd = 271704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyRecipePrinterNew.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x002037DC File Offset: 0x002019DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271704, XrefRangeEnd = 271727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyRecipePrinterNew() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x00203818 File Offset: 0x00201A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271727, XrefRangeEnd = 271731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateDaily_b__66_1(Cooker.CookerType x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.NativeMethodInfoPtr__UpdateDaily_b__66_1_Private_Void_CookerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x00203858 File Offset: 0x00201A58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271735, RefRangeEnd = 271737, XrefRangeStart = 271731, XrefRangeEnd = 271735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_List_1_T_IEnumerable_1_T_Int32_IStaticGridScrollListUILogicalGroup_0<T>(List<T> value, IEnumerable<T> srcList, int emptyCount, IStaticGridScrollListUILogicalGroup group) where T : class
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(srcList);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref emptyCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.MethodInfoStoreGeneric_Method_Internal_Static_Void_List_1_T_IEnumerable_1_T_Int32_IStaticGridScrollListUILogicalGroup_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x00039C94 File Offset: 0x00037E94
		public DailyRecipePrinterNew(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x06006AEB RID: 27371 RVA: 0x002038C0 File Offset: 0x00201AC0
		// (set) Token: 0x06006AEC RID: 27372 RVA: 0x00039C9D File Offset: 0x00037E9D
		public unsafe ActionExecutionScheduler m_Scheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_Scheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionExecutionScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_Scheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x06006AED RID: 27373 RVA: 0x002038F0 File Offset: 0x00201AF0
		// (set) Token: 0x06006AEE RID: 27374 RVA: 0x00039CBC File Offset: 0x00037EBC
		public unsafe GridLayoutGroup m_RecipeGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x06006AEF RID: 27375 RVA: 0x00203920 File Offset: 0x00201B20
		// (set) Token: 0x06006AF0 RID: 27376 RVA: 0x00039CDB File Offset: 0x00037EDB
		public unsafe GridLayoutGroup m_BeverageGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_BeverageGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_BeverageGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x06006AF1 RID: 27377 RVA: 0x00203950 File Offset: 0x00201B50
		// (set) Token: 0x06006AF2 RID: 27378 RVA: 0x00039CFA File Offset: 0x00037EFA
		public unsafe GameObject m_RecipeParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x06006AF3 RID: 27379 RVA: 0x00203980 File Offset: 0x00201B80
		// (set) Token: 0x06006AF4 RID: 27380 RVA: 0x00039D19 File Offset: 0x00037F19
		public unsafe GameObject m_BeverageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_BeverageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_BeverageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x06006AF5 RID: 27381 RVA: 0x002039B0 File Offset: 0x00201BB0
		// (set) Token: 0x06006AF6 RID: 27382 RVA: 0x00039D38 File Offset: 0x00037F38
		public unsafe AdpProgressIndicatorComponent m_RecipeScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x06006AF7 RID: 27383 RVA: 0x002039E0 File Offset: 0x00201BE0
		// (set) Token: 0x06006AF8 RID: 27384 RVA: 0x00039D57 File Offset: 0x00037F57
		public unsafe AdpProgressIndicatorComponent m_BeverageScroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_BeverageScroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_BeverageScroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x06006AF9 RID: 27385 RVA: 0x00203A10 File Offset: 0x00201C10
		// (set) Token: 0x06006AFA RID: 27386 RVA: 0x00039D76 File Offset: 0x00037F76
		public unsafe CanvasGroup m_DescriberPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_DescriberPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_DescriberPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x06006AFB RID: 27387 RVA: 0x00203A40 File Offset: 0x00201C40
		// (set) Token: 0x06006AFC RID: 27388 RVA: 0x00039D95 File Offset: 0x00037F95
		public unsafe SellableDescriber m_Describer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_Describer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_Describer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x06006AFD RID: 27389 RVA: 0x00203A70 File Offset: 0x00201C70
		// (set) Token: 0x06006AFE RID: 27390 RVA: 0x00039DB4 File Offset: 0x00037FB4
		public unsafe Sprite m_Check
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_Check);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_Check), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x06006AFF RID: 27391 RVA: 0x00203AA0 File Offset: 0x00201CA0
		// (set) Token: 0x06006B00 RID: 27392 RVA: 0x00039DD3 File Offset: 0x00037FD3
		public unsafe Sprite m_Cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_Cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_Cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x06006B01 RID: 27393 RVA: 0x00203AD0 File Offset: 0x00201CD0
		// (set) Token: 0x06006B02 RID: 27394 RVA: 0x00039DF2 File Offset: 0x00037FF2
		public unsafe Color m_CheckColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_CheckColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_CheckColor)) = value;
			}
		}

		// Token: 0x17002495 RID: 9365
		// (get) Token: 0x06006B03 RID: 27395 RVA: 0x00203AF8 File Offset: 0x00201CF8
		// (set) Token: 0x06006B04 RID: 27396 RVA: 0x00039E0D File Offset: 0x0003800D
		public unsafe Color m_CrossColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_CrossColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_CrossColor)) = value;
			}
		}

		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x06006B05 RID: 27397 RVA: 0x00203B20 File Offset: 0x00201D20
		// (set) Token: 0x06006B06 RID: 27398 RVA: 0x00039E28 File Offset: 0x00038028
		public unsafe Color m_LockColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_LockColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_LockColor)) = value;
			}
		}

		// Token: 0x17002497 RID: 9367
		// (get) Token: 0x06006B07 RID: 27399 RVA: 0x00203B48 File Offset: 0x00201D48
		// (set) Token: 0x06006B08 RID: 27400 RVA: 0x00039E43 File Offset: 0x00038043
		public unsafe MultiLanguageTextMesh.MultiLanguageString m_RecipeNamePrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeNamePrefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeNamePrefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002498 RID: 9368
		// (get) Token: 0x06006B09 RID: 27401 RVA: 0x00203B78 File Offset: 0x00201D78
		// (set) Token: 0x06006B0A RID: 27402 RVA: 0x00039E62 File Offset: 0x00038062
		public unsafe List<Sellable> m_BeverageList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_BeverageList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_BeverageList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002499 RID: 9369
		// (get) Token: 0x06006B0B RID: 27403 RVA: 0x00203BA8 File Offset: 0x00201DA8
		// (set) Token: 0x06006B0C RID: 27404 RVA: 0x00039E81 File Offset: 0x00038081
		public unsafe List<Recipe> m_RecipeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_RecipeList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x06006B0D RID: 27405 RVA: 0x00203BD8 File Offset: 0x00201DD8
		// (set) Token: 0x06006B0E RID: 27406 RVA: 0x00039EA0 File Offset: 0x000380A0
		public unsafe HashSet<Cooker.CookerType> m_RegisteredCookerTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_RegisteredCookerTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Cooker.CookerType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_RegisteredCookerTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x06006B0F RID: 27407 RVA: 0x00203C08 File Offset: 0x00201E08
		// (set) Token: 0x06006B10 RID: 27408 RVA: 0x00039EBF File Offset: 0x000380BF
		public unsafe Func<CancellationToken> m_GetTokenCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_GetTokenCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CancellationToken>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_m_GetTokenCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x06006B11 RID: 27409 RVA: 0x00203C38 File Offset: 0x00201E38
		// (set) Token: 0x06006B12 RID: 27410 RVA: 0x00039EDE File Offset: 0x000380DE
		public unsafe StaticHorizontalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple> _RegisteredRecipeGroup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr__RegisteredRecipeGroup_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticHorizontalGridScrollListUILogicalGroupT<Recipe, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr__RegisteredRecipeGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x06006B13 RID: 27411 RVA: 0x00203C68 File Offset: 0x00201E68
		// (set) Token: 0x06006B14 RID: 27412 RVA: 0x00039EFD File Offset: 0x000380FD
		public unsafe StaticHorizontalGridScrollListUILogicalGroupT<Sellable, UIElementCluster, UIButtonSimple> _RegisteredBeverageGroup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr__RegisteredBeverageGroup_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticHorizontalGridScrollListUILogicalGroupT<Sellable, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr__RegisteredBeverageGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x06006B15 RID: 27413 RVA: 0x00203C98 File Offset: 0x00201E98
		// (set) Token: 0x06006B16 RID: 27414 RVA: 0x00039F1C File Offset: 0x0003811C
		public unsafe Action<Recipe, UIElementCluster, UIButtonSimple> RecipeSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_RecipeSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Recipe, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_RecipeSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x06006B17 RID: 27415 RVA: 0x00203CC8 File Offset: 0x00201EC8
		// (set) Token: 0x06006B18 RID: 27416 RVA: 0x00039F3B File Offset: 0x0003813B
		public unsafe Action<Sellable, UIElementCluster, UIButtonSimple> BeverageSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_BeverageSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sellable, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_BeverageSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x06006B19 RID: 27417 RVA: 0x00203CF8 File Offset: 0x00201EF8
		// (set) Token: 0x06006B1A RID: 27418 RVA: 0x00039F5A File Offset: 0x0003815A
		public unsafe Action<Recipe> OnDescribeRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_OnDescribeRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_OnDescribeRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x06006B1B RID: 27419 RVA: 0x00203D28 File Offset: 0x00201F28
		// (set) Token: 0x06006B1C RID: 27420 RVA: 0x00039F79 File Offset: 0x00038179
		public unsafe Action<int, MoveDirection> OnRecipeCustomLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_OnRecipeCustomLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, MoveDirection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_OnRecipeCustomLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x06006B1D RID: 27421 RVA: 0x00203D58 File Offset: 0x00201F58
		// (set) Token: 0x06006B1E RID: 27422 RVA: 0x00039F98 File Offset: 0x00038198
		public unsafe Action<int, MoveDirection> OnBeverageCustomLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_OnBeverageCustomLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, MoveDirection>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_OnBeverageCustomLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A3 RID: 9379
		// (get) Token: 0x06006B1F RID: 27423 RVA: 0x00203D88 File Offset: 0x00201F88
		// (set) Token: 0x06006B20 RID: 27424 RVA: 0x00039FB7 File Offset: 0x000381B7
		public unsafe Action OnRegisteredRecipeUpDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_OnRegisteredRecipeUpDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_OnRegisteredRecipeUpDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A4 RID: 9380
		// (get) Token: 0x06006B21 RID: 27425 RVA: 0x00203DB8 File Offset: 0x00201FB8
		// (set) Token: 0x06006B22 RID: 27426 RVA: 0x00039FD6 File Offset: 0x000381D6
		public unsafe Action OnRegisteredBeverageUpDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_OnRegisteredBeverageUpDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.NativeFieldInfoPtr_OnRegisteredBeverageUpDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040046C3 RID: 18115
		private static readonly IntPtr NativeFieldInfoPtr_m_Scheduler;

		// Token: 0x040046C4 RID: 18116
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeGrid;

		// Token: 0x040046C5 RID: 18117
		private static readonly IntPtr NativeFieldInfoPtr_m_BeverageGrid;

		// Token: 0x040046C6 RID: 18118
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeParent;

		// Token: 0x040046C7 RID: 18119
		private static readonly IntPtr NativeFieldInfoPtr_m_BeverageParent;

		// Token: 0x040046C8 RID: 18120
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeScroller;

		// Token: 0x040046C9 RID: 18121
		private static readonly IntPtr NativeFieldInfoPtr_m_BeverageScroller;

		// Token: 0x040046CA RID: 18122
		private static readonly IntPtr NativeFieldInfoPtr_m_DescriberPanel;

		// Token: 0x040046CB RID: 18123
		private static readonly IntPtr NativeFieldInfoPtr_m_Describer;

		// Token: 0x040046CC RID: 18124
		private static readonly IntPtr NativeFieldInfoPtr_m_Check;

		// Token: 0x040046CD RID: 18125
		private static readonly IntPtr NativeFieldInfoPtr_m_Cross;

		// Token: 0x040046CE RID: 18126
		private static readonly IntPtr NativeFieldInfoPtr_m_CheckColor;

		// Token: 0x040046CF RID: 18127
		private static readonly IntPtr NativeFieldInfoPtr_m_CrossColor;

		// Token: 0x040046D0 RID: 18128
		private static readonly IntPtr NativeFieldInfoPtr_m_LockColor;

		// Token: 0x040046D1 RID: 18129
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeNamePrefix;

		// Token: 0x040046D2 RID: 18130
		private static readonly IntPtr NativeFieldInfoPtr_m_BeverageList;

		// Token: 0x040046D3 RID: 18131
		private static readonly IntPtr NativeFieldInfoPtr_m_RecipeList;

		// Token: 0x040046D4 RID: 18132
		private static readonly IntPtr NativeFieldInfoPtr_m_RegisteredCookerTypes;

		// Token: 0x040046D5 RID: 18133
		private static readonly IntPtr NativeFieldInfoPtr_m_GetTokenCallback;

		// Token: 0x040046D6 RID: 18134
		private static readonly IntPtr NativeFieldInfoPtr__RegisteredRecipeGroup_k__BackingField;

		// Token: 0x040046D7 RID: 18135
		private static readonly IntPtr NativeFieldInfoPtr__RegisteredBeverageGroup_k__BackingField;

		// Token: 0x040046D8 RID: 18136
		private static readonly IntPtr NativeFieldInfoPtr_RecipeSelected;

		// Token: 0x040046D9 RID: 18137
		private static readonly IntPtr NativeFieldInfoPtr_BeverageSelected;

		// Token: 0x040046DA RID: 18138
		private static readonly IntPtr NativeFieldInfoPtr_OnDescribeRecipe;

		// Token: 0x040046DB RID: 18139
		private static readonly IntPtr NativeFieldInfoPtr_OnRecipeCustomLoop;

		// Token: 0x040046DC RID: 18140
		private static readonly IntPtr NativeFieldInfoPtr_OnBeverageCustomLoop;

		// Token: 0x040046DD RID: 18141
		private static readonly IntPtr NativeFieldInfoPtr_OnRegisteredRecipeUpDown;

		// Token: 0x040046DE RID: 18142
		private static readonly IntPtr NativeFieldInfoPtr_OnRegisteredBeverageUpDown;

		// Token: 0x040046DF RID: 18143
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisteredRecipeGroup_Public_get_StaticHorizontalGridScrollListUILogicalGroupT_3_Recipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040046E0 RID: 18144
		private static readonly IntPtr NativeMethodInfoPtr_set_RegisteredRecipeGroup_Private_set_Void_StaticHorizontalGridScrollListUILogicalGroupT_3_Recipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040046E1 RID: 18145
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisteredBeverageGroup_Public_get_StaticHorizontalGridScrollListUILogicalGroupT_3_Sellable_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040046E2 RID: 18146
		private static readonly IntPtr NativeMethodInfoPtr_set_RegisteredBeverageGroup_Private_set_Void_StaticHorizontalGridScrollListUILogicalGroupT_3_Sellable_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040046E3 RID: 18147
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisteredRecipeList_Public_get_IReadOnlyList_1_Recipe_0;

		// Token: 0x040046E4 RID: 18148
		private static readonly IntPtr NativeMethodInfoPtr_get_RegisteredBeverageList_Public_get_IReadOnlyList_1_Sellable_0;

		// Token: 0x040046E5 RID: 18149
		private static readonly IntPtr NativeMethodInfoPtr_get_Describer_Public_get_SellableDescriber_0;

		// Token: 0x040046E6 RID: 18150
		private static readonly IntPtr NativeMethodInfoPtr_get_Scheduler_Public_get_ActionExecutionScheduler_0;

		// Token: 0x040046E7 RID: 18151
		private static readonly IntPtr NativeMethodInfoPtr_add_RecipeSelected_Public_add_Void_Action_3_Recipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040046E8 RID: 18152
		private static readonly IntPtr NativeMethodInfoPtr_remove_RecipeSelected_Public_rem_Void_Action_3_Recipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040046E9 RID: 18153
		private static readonly IntPtr NativeMethodInfoPtr_add_BeverageSelected_Public_add_Void_Action_3_Sellable_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040046EA RID: 18154
		private static readonly IntPtr NativeMethodInfoPtr_remove_BeverageSelected_Public_rem_Void_Action_3_Sellable_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040046EB RID: 18155
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDescribeRecipe_Public_add_Void_Action_1_Recipe_0;

		// Token: 0x040046EC RID: 18156
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDescribeRecipe_Public_rem_Void_Action_1_Recipe_0;

		// Token: 0x040046ED RID: 18157
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRecipeCustomLoop_Public_add_Void_Action_2_Int32_MoveDirection_0;

		// Token: 0x040046EE RID: 18158
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRecipeCustomLoop_Public_rem_Void_Action_2_Int32_MoveDirection_0;

		// Token: 0x040046EF RID: 18159
		private static readonly IntPtr NativeMethodInfoPtr_add_OnBeverageCustomLoop_Public_add_Void_Action_2_Int32_MoveDirection_0;

		// Token: 0x040046F0 RID: 18160
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnBeverageCustomLoop_Public_rem_Void_Action_2_Int32_MoveDirection_0;

		// Token: 0x040046F1 RID: 18161
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRegisteredRecipeUpDown_Public_add_Void_Action_0;

		// Token: 0x040046F2 RID: 18162
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRegisteredRecipeUpDown_Public_rem_Void_Action_0;

		// Token: 0x040046F3 RID: 18163
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRegisteredBeverageUpDown_Public_add_Void_Action_0;

		// Token: 0x040046F4 RID: 18164
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRegisteredBeverageUpDown_Public_rem_Void_Action_0;

		// Token: 0x040046F5 RID: 18165
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Boolean_Func_1_CancellationToken_0;

		// Token: 0x040046F6 RID: 18166
		private static readonly IntPtr NativeMethodInfoPtr_OnRecipeCustomLoopCalled_Private_Void_Int32_MoveDirection_0;

		// Token: 0x040046F7 RID: 18167
		private static readonly IntPtr NativeMethodInfoPtr_OnBeverageCustomLoopCalled_Private_Void_Int32_MoveDirection_0;

		// Token: 0x040046F8 RID: 18168
		private static readonly IntPtr NativeMethodInfoPtr_OnFoodEnabled_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040046F9 RID: 18169
		private static readonly IntPtr NativeMethodInfoPtr_InitValidRecipe_Private_Void_Recipe_UIElementCluster_0;

		// Token: 0x040046FA RID: 18170
		private static readonly IntPtr NativeMethodInfoPtr_OnBeverageEnabled_Private_Void_Sellable_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040046FB RID: 18171
		private static readonly IntPtr NativeMethodInfoPtr_InitValidBeverage_Private_Static_Void_Sellable_UIElementCluster_0;

		// Token: 0x040046FC RID: 18172
		private static readonly IntPtr NativeMethodInfoPtr_OnElementEnabledShared_Private_Void_TValue_UIElementCluster_Action_2_TValue_UIElementCluster_0;

		// Token: 0x040046FD RID: 18173
		private static readonly IntPtr NativeMethodInfoPtr_OnFoodSelected_Private_Void_Recipe_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040046FE RID: 18174
		private static readonly IntPtr NativeMethodInfoPtr_OnBeverageSelected_Private_Void_Sellable_UIElementCluster_UIButtonSimple_0;

		// Token: 0x040046FF RID: 18175
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDaily_Public_Void_0;

		// Token: 0x04004700 RID: 18176
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04004701 RID: 18177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004702 RID: 18178
		private static readonly IntPtr NativeMethodInfoPtr__UpdateDaily_b__66_1_Private_Void_CookerType_0;

		// Token: 0x04004703 RID: 18179
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_List_1_T_IEnumerable_1_T_Int32_IStaticGridScrollListUILogicalGroup_0;

		// Token: 0x02000E9C RID: 3740
		[ObfuscatedName("Common.UI.DailyRecipePrinterNew+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
		{
			// Token: 0x060108E8 RID: 67816 RVA: 0x003D64DC File Offset: 0x003D46DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass56_0>.NativeClassPtr);
				DailyRecipePrinterNew.__c__DisplayClass56_0.NativeFieldInfoPtr_noVerticalMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass56_0>.NativeClassPtr, "noVerticalMovement");
				DailyRecipePrinterNew.__c__DisplayClass56_0.NativeFieldInfoPtr_isProcessingRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass56_0>.NativeClassPtr, "isProcessingRecipe");
				DailyRecipePrinterNew.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass56_0>.NativeClassPtr, "<>4__this");
				DailyRecipePrinterNew.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass56_0>.NativeClassPtr, 100685408);
				DailyRecipePrinterNew.__c__DisplayClass56_0.NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_BorderElementType_Int32_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass56_0>.NativeClassPtr, 100685409);
				DailyRecipePrinterNew.__c__DisplayClass56_0.NativeMethodInfoPtr__Init_b__1_Internal_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass56_0>.NativeClassPtr, 100685410);
				DailyRecipePrinterNew.__c__DisplayClass56_0.NativeMethodInfoPtr__Init_b__2_Internal_Void_MoveDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass56_0>.NativeClassPtr, 100685411);
			}

			// Token: 0x060108E9 RID: 67817 RVA: 0x003D6594 File Offset: 0x003D4794
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108EA RID: 67818 RVA: 0x003D65D0 File Offset: 0x003D47D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271186, XrefRangeEnd = 271199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UIButtonSimple_BorderElementType_Int32_Int32_PDM_0(UIButtonSimple uiBtn, AdpUISystemUtils.BorderElementType borderElementType, int columnIndex, int rowIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiBtn);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref borderElementType;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref columnIndex;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rowIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass56_0.NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_BorderElementType_Int32_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108EB RID: 67819 RVA: 0x003D663C File Offset: 0x003D483C
			[CallerCount(0)]
			public unsafe void _Init_b__1(MoveDirection direction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass56_0.NativeMethodInfoPtr__Init_b__1_Internal_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108EC RID: 67820 RVA: 0x003D667C File Offset: 0x003D487C
			[CallerCount(0)]
			public unsafe void _Init_b__2(MoveDirection direction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass56_0.NativeMethodInfoPtr__Init_b__2_Internal_Void_MoveDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108ED RID: 67821 RVA: 0x000908B8 File Offset: 0x0008EAB8
			public __c__DisplayClass56_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005667 RID: 22119
			// (get) Token: 0x060108EE RID: 67822 RVA: 0x003D66BC File Offset: 0x003D48BC
			// (set) Token: 0x060108EF RID: 67823 RVA: 0x000908C1 File Offset: 0x0008EAC1
			public unsafe bool noVerticalMovement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass56_0.NativeFieldInfoPtr_noVerticalMovement);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass56_0.NativeFieldInfoPtr_noVerticalMovement)) = value;
				}
			}

			// Token: 0x17005668 RID: 22120
			// (get) Token: 0x060108F0 RID: 67824 RVA: 0x003D66E4 File Offset: 0x003D48E4
			// (set) Token: 0x060108F1 RID: 67825 RVA: 0x000908DC File Offset: 0x0008EADC
			public unsafe bool isProcessingRecipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass56_0.NativeFieldInfoPtr_isProcessingRecipe);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass56_0.NativeFieldInfoPtr_isProcessingRecipe)) = value;
				}
			}

			// Token: 0x17005669 RID: 22121
			// (get) Token: 0x060108F2 RID: 67826 RVA: 0x003D670C File Offset: 0x003D490C
			// (set) Token: 0x060108F3 RID: 67827 RVA: 0x000908F7 File Offset: 0x0008EAF7
			public unsafe DailyRecipePrinterNew __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyRecipePrinterNew>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass56_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A78E RID: 42894
			private static readonly IntPtr NativeFieldInfoPtr_noVerticalMovement;

			// Token: 0x0400A78F RID: 42895
			private static readonly IntPtr NativeFieldInfoPtr_isProcessingRecipe;

			// Token: 0x0400A790 RID: 42896
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A791 RID: 42897
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A792 RID: 42898
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UIButtonSimple_BorderElementType_Int32_Int32_PDM_0;

			// Token: 0x0400A793 RID: 42899
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__1_Internal_Void_MoveDirection_0;

			// Token: 0x0400A794 RID: 42900
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__2_Internal_Void_MoveDirection_0;
		}

		// Token: 0x02000E9D RID: 3741
		[ObfuscatedName("Common.UI.DailyRecipePrinterNew+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x060108F4 RID: 67828 RVA: 0x003D673C File Offset: 0x003D493C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DailyRecipePrinterNew.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyRecipePrinterNew.__c>.NativeClassPtr);
				DailyRecipePrinterNew.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c>.NativeClassPtr, "<>9");
				DailyRecipePrinterNew.__c.NativeFieldInfoPtr___9__56_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c>.NativeClassPtr, "<>9__56_3");
				DailyRecipePrinterNew.__c.NativeFieldInfoPtr___9__56_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c>.NativeClassPtr, "<>9__56_4");
				DailyRecipePrinterNew.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c>.NativeClassPtr, 100685413);
				DailyRecipePrinterNew.__c.NativeMethodInfoPtr__Init_b__56_3_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c>.NativeClassPtr, 100685414);
				DailyRecipePrinterNew.__c.NativeMethodInfoPtr__Init_b__56_4_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c>.NativeClassPtr, 100685415);
			}

			// Token: 0x060108F5 RID: 67829 RVA: 0x003D67E0 File Offset: 0x003D49E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyRecipePrinterNew.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060108F6 RID: 67830 RVA: 0x003D681C File Offset: 0x003D4A1C
			[CallerCount(0)]
			public unsafe bool _Init_b__56_3(Recipe recipe)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c.NativeMethodInfoPtr__Init_b__56_3_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060108F7 RID: 67831 RVA: 0x003D686C File Offset: 0x003D4A6C
			[CallerCount(0)]
			public unsafe bool _Init_b__56_4(Sellable beverage)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beverage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c.NativeMethodInfoPtr__Init_b__56_4_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060108F8 RID: 67832 RVA: 0x00090916 File Offset: 0x0008EB16
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700566A RID: 22122
			// (get) Token: 0x060108F9 RID: 67833 RVA: 0x003D68BC File Offset: 0x003D4ABC
			// (set) Token: 0x060108FA RID: 67834 RVA: 0x0009091F File Offset: 0x0008EB1F
			public unsafe static DailyRecipePrinterNew.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DailyRecipePrinterNew.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyRecipePrinterNew.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DailyRecipePrinterNew.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700566B RID: 22123
			// (get) Token: 0x060108FB RID: 67835 RVA: 0x003D68E4 File Offset: 0x003D4AE4
			// (set) Token: 0x060108FC RID: 67836 RVA: 0x00090931 File Offset: 0x0008EB31
			public unsafe static Func<Recipe, bool> __9__56_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DailyRecipePrinterNew.__c.NativeFieldInfoPtr___9__56_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DailyRecipePrinterNew.__c.NativeFieldInfoPtr___9__56_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700566C RID: 22124
			// (get) Token: 0x060108FD RID: 67837 RVA: 0x003D690C File Offset: 0x003D4B0C
			// (set) Token: 0x060108FE RID: 67838 RVA: 0x00090943 File Offset: 0x0008EB43
			public unsafe static Func<Sellable, bool> __9__56_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DailyRecipePrinterNew.__c.NativeFieldInfoPtr___9__56_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DailyRecipePrinterNew.__c.NativeFieldInfoPtr___9__56_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A795 RID: 42901
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A796 RID: 42902
			private static readonly IntPtr NativeFieldInfoPtr___9__56_3;

			// Token: 0x0400A797 RID: 42903
			private static readonly IntPtr NativeFieldInfoPtr___9__56_4;

			// Token: 0x0400A798 RID: 42904
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A799 RID: 42905
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__56_3_Internal_Boolean_Recipe_0;

			// Token: 0x0400A79A RID: 42906
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__56_4_Internal_Boolean_Sellable_0;
		}

		// Token: 0x02000E9E RID: 3742
		[ObfuscatedName("Common.UI.DailyRecipePrinterNew+<>c__DisplayClass60_0")]
		public sealed class __c__DisplayClass60_0 : Il2CppSystem.Object
		{
			// Token: 0x060108FF RID: 67839 RVA: 0x003D6934 File Offset: 0x003D4B34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass60_0()
			{
				Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "<>c__DisplayClass60_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass60_0>.NativeClassPtr);
				DailyRecipePrinterNew.__c__DisplayClass60_0.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass60_0>.NativeClassPtr, "recipe");
				DailyRecipePrinterNew.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass60_0>.NativeClassPtr, "<>4__this");
				DailyRecipePrinterNew.__c__DisplayClass60_0.NativeFieldInfoPtr_isLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass60_0>.NativeClassPtr, "isLocked");
				DailyRecipePrinterNew.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass60_0>.NativeClassPtr, 100685416);
				DailyRecipePrinterNew.__c__DisplayClass60_0.NativeMethodInfoPtr__InitValidRecipe_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass60_0>.NativeClassPtr, 100685417);
				DailyRecipePrinterNew.__c__DisplayClass60_0.NativeMethodInfoPtr__InitValidRecipe_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass60_0>.NativeClassPtr, 100685418);
				DailyRecipePrinterNew.__c__DisplayClass60_0.NativeMethodInfoPtr__InitValidRecipe_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass60_0>.NativeClassPtr, 100685419);
				DailyRecipePrinterNew.__c__DisplayClass60_0.NativeMethodInfoPtr__InitValidRecipe_b__3_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass60_0>.NativeClassPtr, 100685420);
			}

			// Token: 0x06010900 RID: 67840 RVA: 0x003D6A00 File Offset: 0x003D4C00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass60_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass60_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010901 RID: 67841 RVA: 0x003D6A3C File Offset: 0x003D4C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitValidRecipe_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass60_0.NativeMethodInfoPtr__InitValidRecipe_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010902 RID: 67842 RVA: 0x003D6A80 File Offset: 0x003D4C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271199, XrefRangeEnd = 271205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitValidRecipe_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass60_0.NativeMethodInfoPtr__InitValidRecipe_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010903 RID: 67843 RVA: 0x003D6AC4 File Offset: 0x003D4CC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitValidRecipe_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass60_0.NativeMethodInfoPtr__InitValidRecipe_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010904 RID: 67844 RVA: 0x003D6B08 File Offset: 0x003D4D08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitValidRecipe_b__3(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass60_0.NativeMethodInfoPtr__InitValidRecipe_b__3_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010905 RID: 67845 RVA: 0x00090955 File Offset: 0x0008EB55
			public __c__DisplayClass60_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700566D RID: 22125
			// (get) Token: 0x06010906 RID: 67846 RVA: 0x003D6B4C File Offset: 0x003D4D4C
			// (set) Token: 0x06010907 RID: 67847 RVA: 0x0009095E File Offset: 0x0008EB5E
			public unsafe Recipe recipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass60_0.NativeFieldInfoPtr_recipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass60_0.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700566E RID: 22126
			// (get) Token: 0x06010908 RID: 67848 RVA: 0x003D6B7C File Offset: 0x003D4D7C
			// (set) Token: 0x06010909 RID: 67849 RVA: 0x0009097D File Offset: 0x0008EB7D
			public unsafe DailyRecipePrinterNew __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyRecipePrinterNew>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700566F RID: 22127
			// (get) Token: 0x0601090A RID: 67850 RVA: 0x003D6BAC File Offset: 0x003D4DAC
			// (set) Token: 0x0601090B RID: 67851 RVA: 0x0009099C File Offset: 0x0008EB9C
			public unsafe bool isLocked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass60_0.NativeFieldInfoPtr_isLocked);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass60_0.NativeFieldInfoPtr_isLocked)) = value;
				}
			}

			// Token: 0x0400A79B RID: 42907
			private static readonly IntPtr NativeFieldInfoPtr_recipe;

			// Token: 0x0400A79C RID: 42908
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A79D RID: 42909
			private static readonly IntPtr NativeFieldInfoPtr_isLocked;

			// Token: 0x0400A79E RID: 42910
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A79F RID: 42911
			private static readonly IntPtr NativeMethodInfoPtr__InitValidRecipe_b__0_Internal_Void_Image_0;

			// Token: 0x0400A7A0 RID: 42912
			private static readonly IntPtr NativeMethodInfoPtr__InitValidRecipe_b__1_Internal_Void_Image_0;

			// Token: 0x0400A7A1 RID: 42913
			private static readonly IntPtr NativeMethodInfoPtr__InitValidRecipe_b__2_Internal_Void_Image_0;

			// Token: 0x0400A7A2 RID: 42914
			private static readonly IntPtr NativeMethodInfoPtr__InitValidRecipe_b__3_Internal_Void_RectTransform_0;
		}

		// Token: 0x02000E9F RID: 3743
		[ObfuscatedName("Common.UI.DailyRecipePrinterNew+<>c__DisplayClass62_0")]
		public sealed class __c__DisplayClass62_0 : Il2CppSystem.Object
		{
			// Token: 0x0601090C RID: 67852 RVA: 0x003D6BD4 File Offset: 0x003D4DD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_0()
			{
				Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "<>c__DisplayClass62_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass62_0>.NativeClassPtr);
				DailyRecipePrinterNew.__c__DisplayClass62_0.NativeFieldInfoPtr_beverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass62_0>.NativeClassPtr, "beverage");
				DailyRecipePrinterNew.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass62_0>.NativeClassPtr, 100685421);
				DailyRecipePrinterNew.__c__DisplayClass62_0.NativeMethodInfoPtr__InitValidBeverage_b__0_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass62_0>.NativeClassPtr, 100685422);
			}

			// Token: 0x0601090D RID: 67853 RVA: 0x003D6C3C File Offset: 0x003D4E3C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass62_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601090E RID: 67854 RVA: 0x003D6C78 File Offset: 0x003D4E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InitValidBeverage_b__0(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass62_0.NativeMethodInfoPtr__InitValidBeverage_b__0_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601090F RID: 67855 RVA: 0x000909B7 File Offset: 0x0008EBB7
			public __c__DisplayClass62_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005670 RID: 22128
			// (get) Token: 0x06010910 RID: 67856 RVA: 0x003D6CBC File Offset: 0x003D4EBC
			// (set) Token: 0x06010911 RID: 67857 RVA: 0x000909C0 File Offset: 0x0008EBC0
			public unsafe Sellable beverage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass62_0.NativeFieldInfoPtr_beverage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass62_0.NativeFieldInfoPtr_beverage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7A3 RID: 42915
			private static readonly IntPtr NativeFieldInfoPtr_beverage;

			// Token: 0x0400A7A4 RID: 42916
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7A5 RID: 42917
			private static readonly IntPtr NativeMethodInfoPtr__InitValidBeverage_b__0_Internal_Void_RectTransform_0;
		}

		// Token: 0x02000EA0 RID: 3744
		[ObfuscatedName("Common.UI.DailyRecipePrinterNew+<>c__DisplayClass64_0")]
		public sealed class __c__DisplayClass64_0 : Il2CppSystem.Object
		{
			// Token: 0x06010912 RID: 67858 RVA: 0x003D6CEC File Offset: 0x003D4EEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass64_0()
			{
				Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass64_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "<>c__DisplayClass64_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass64_0>.NativeClassPtr);
				DailyRecipePrinterNew.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass64_0>.NativeClassPtr, "<>4__this");
				DailyRecipePrinterNew.__c__DisplayClass64_0.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass64_0>.NativeClassPtr, "recipe");
				DailyRecipePrinterNew.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass64_0>.NativeClassPtr, 100685423);
				DailyRecipePrinterNew.__c__DisplayClass64_0.NativeMethodInfoPtr__OnFoodSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass64_0>.NativeClassPtr, 100685424);
			}

			// Token: 0x06010913 RID: 67859 RVA: 0x003D6D68 File Offset: 0x003D4F68
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass64_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass64_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass64_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010914 RID: 67860 RVA: 0x003D6DA4 File Offset: 0x003D4FA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271205, XrefRangeEnd = 271208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnFoodSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass64_0.NativeMethodInfoPtr__OnFoodSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010915 RID: 67861 RVA: 0x000909DF File Offset: 0x0008EBDF
			public __c__DisplayClass64_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005671 RID: 22129
			// (get) Token: 0x06010916 RID: 67862 RVA: 0x003D6DD8 File Offset: 0x003D4FD8
			// (set) Token: 0x06010917 RID: 67863 RVA: 0x000909E8 File Offset: 0x0008EBE8
			public unsafe DailyRecipePrinterNew __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyRecipePrinterNew>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass64_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005672 RID: 22130
			// (get) Token: 0x06010918 RID: 67864 RVA: 0x003D6E08 File Offset: 0x003D5008
			// (set) Token: 0x06010919 RID: 67865 RVA: 0x00090A07 File Offset: 0x0008EC07
			public unsafe Recipe recipe
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass64_0.NativeFieldInfoPtr_recipe);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass64_0.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7A6 RID: 42918
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7A7 RID: 42919
			private static readonly IntPtr NativeFieldInfoPtr_recipe;

			// Token: 0x0400A7A8 RID: 42920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7A9 RID: 42921
			private static readonly IntPtr NativeMethodInfoPtr__OnFoodSelected_b__0_Internal_Void_0;
		}

		// Token: 0x02000EA1 RID: 3745
		[ObfuscatedName("Common.UI.DailyRecipePrinterNew+<>c__DisplayClass65_0")]
		public sealed class __c__DisplayClass65_0 : Il2CppSystem.Object
		{
			// Token: 0x0601091A RID: 67866 RVA: 0x003D6E38 File Offset: 0x003D5038
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_0()
			{
				Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr, "<>c__DisplayClass65_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass65_0>.NativeClassPtr);
				DailyRecipePrinterNew.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass65_0>.NativeClassPtr, "<>4__this");
				DailyRecipePrinterNew.__c__DisplayClass65_0.NativeFieldInfoPtr_beverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass65_0>.NativeClassPtr, "beverage");
				DailyRecipePrinterNew.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass65_0>.NativeClassPtr, 100685425);
				DailyRecipePrinterNew.__c__DisplayClass65_0.NativeMethodInfoPtr__OnBeverageSelected_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass65_0>.NativeClassPtr, 100685426);
			}

			// Token: 0x0601091B RID: 67867 RVA: 0x003D6EB4 File Offset: 0x003D50B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyRecipePrinterNew.__c__DisplayClass65_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601091C RID: 67868 RVA: 0x003D6EF0 File Offset: 0x003D50F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271208, XrefRangeEnd = 271283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBeverageSelected_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyRecipePrinterNew.__c__DisplayClass65_0.NativeMethodInfoPtr__OnBeverageSelected_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601091D RID: 67869 RVA: 0x00090A26 File Offset: 0x0008EC26
			public __c__DisplayClass65_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005673 RID: 22131
			// (get) Token: 0x0601091E RID: 67870 RVA: 0x003D6F24 File Offset: 0x003D5124
			// (set) Token: 0x0601091F RID: 67871 RVA: 0x00090A2F File Offset: 0x0008EC2F
			public unsafe DailyRecipePrinterNew __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyRecipePrinterNew>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005674 RID: 22132
			// (get) Token: 0x06010920 RID: 67872 RVA: 0x003D6F54 File Offset: 0x003D5154
			// (set) Token: 0x06010921 RID: 67873 RVA: 0x00090A4E File Offset: 0x0008EC4E
			public unsafe Sellable beverage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass65_0.NativeFieldInfoPtr_beverage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyRecipePrinterNew.__c__DisplayClass65_0.NativeFieldInfoPtr_beverage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7AA RID: 42922
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7AB RID: 42923
			private static readonly IntPtr NativeFieldInfoPtr_beverage;

			// Token: 0x0400A7AC RID: 42924
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7AD RID: 42925
			private static readonly IntPtr NativeMethodInfoPtr__OnBeverageSelected_b__0_Internal_Void_0;
		}

		// Token: 0x02000EA2 RID: 3746
		private sealed class MethodInfoStoreGeneric_OnElementEnabledShared_Private_Void_TValue_UIElementCluster_Action_2_TValue_UIElementCluster_0<TValue>
		{
			// Token: 0x0400A7AE RID: 42926
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DailyRecipePrinterNew.NativeMethodInfoPtr_OnElementEnabledShared_Private_Void_TValue_UIElementCluster_Action_2_TValue_UIElementCluster_0, Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000EA3 RID: 3747
		private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Void_List_1_T_IEnumerable_1_T_Int32_IStaticGridScrollListUILogicalGroup_0<T>
		{
			// Token: 0x0400A7AF RID: 42927
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DailyRecipePrinterNew.NativeMethodInfoPtr_Method_Internal_Static_Void_List_1_T_IEnumerable_1_T_Int32_IStaticGridScrollListUILogicalGroup_0, Il2CppClassPointerStore<DailyRecipePrinterNew>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
