using System;
using DEYU.Singletons;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.UI;
using UnityEngine;

namespace NightScene.CookingUtility
{
	// Token: 0x020001B3 RID: 435
	public class CookSystemManager : MonoSingleton<CookSystemManager>
	{
		// Token: 0x06003512 RID: 13586 RVA: 0x00154E68 File Offset: 0x00153068
		// Note: this type is marked as 'beforefieldinit'.
		static CookSystemManager()
		{
			Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.CookingUtility", "CookSystemManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr);
			CookSystemManager.NativeFieldInfoPtr_registeredSellables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, "registeredSellables");
			CookSystemManager.NativeFieldInfoPtr_cookingSelectionModuleAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, "cookingSelectionModuleAlpha");
			CookSystemManager.NativeFieldInfoPtr_storageModuleAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, "storageModuleAlpha");
			CookSystemManager.NativeFieldInfoPtr__AllCookers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, "<AllCookers>k__BackingField");
			CookSystemManager.NativeFieldInfoPtr__IsCookingSelectionPanelOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, "<IsCookingSelectionPanelOpen>k__BackingField");
			CookSystemManager.NativeFieldInfoPtr_OnQTENotFullScoreCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, "OnQTENotFullScoreCallback");
			CookSystemManager.NativeFieldInfoPtr_OnCookerStartCookCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, "OnCookerStartCookCallback");
			CookSystemManager.NativeFieldInfoPtr_OnResultCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, "OnResultCompleteCallback");
			CookSystemManager.NativeMethodInfoPtr_get_HudManager_Public_get_UIManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673422);
			CookSystemManager.NativeMethodInfoPtr_get_AllCookers_Private_get_Dictionary_2_Vector3Int_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673423);
			CookSystemManager.NativeMethodInfoPtr_set_AllCookers_Private_set_Void_Dictionary_2_Vector3Int_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673424);
			CookSystemManager.NativeMethodInfoPtr_get_AllCookerControllers_Public_get_IEnumerable_1_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673425);
			CookSystemManager.NativeMethodInfoPtr_SetCookingSelectionModuleAlpha_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673426);
			CookSystemManager.NativeMethodInfoPtr_SetStorageModuleAlpha_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673427);
			CookSystemManager.NativeMethodInfoPtr_get_IsCookingSelectionPanelOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673428);
			CookSystemManager.NativeMethodInfoPtr_set_IsCookingSelectionPanelOpen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673429);
			CookSystemManager.NativeMethodInfoPtr_add_OnQTENotFullScoreCallback_Public_add_Void_Action_1_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673430);
			CookSystemManager.NativeMethodInfoPtr_remove_OnQTENotFullScoreCallback_Public_rem_Void_Action_1_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673431);
			CookSystemManager.NativeMethodInfoPtr_add_OnCookerStartCookCallback_Public_add_Void_Action_2_Sellable_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673432);
			CookSystemManager.NativeMethodInfoPtr_remove_OnCookerStartCookCallback_Public_rem_Void_Action_2_Sellable_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673433);
			CookSystemManager.NativeMethodInfoPtr_CallCookerStartCallback_Public_Void_Sellable_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673434);
			CookSystemManager.NativeMethodInfoPtr_add_OnResultCompleteCallback_Public_add_Void_Action_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673435);
			CookSystemManager.NativeMethodInfoPtr_remove_OnResultCompleteCallback_Public_rem_Void_Action_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673436);
			CookSystemManager.NativeMethodInfoPtr_CallOnResultCompleteCallback_Public_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673437);
			CookSystemManager.NativeMethodInfoPtr_GetCooker_Public_Boolean_Sellable_byref_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673438);
			CookSystemManager.NativeMethodInfoPtr_RegisterCooker_Public_Void_Sellable_Cooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673439);
			CookSystemManager.NativeMethodInfoPtr_ReleaseCooker_Public_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673440);
			CookSystemManager.NativeMethodInfoPtr_GetRandomNormalGuestGroups_Public_IEnumerable_1_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673441);
			CookSystemManager.NativeMethodInfoPtr_Initialize_Public_Void_IReadOnlyList_1_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673442);
			CookSystemManager.NativeMethodInfoPtr_CouldCookerOpen_Public_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673443);
			CookSystemManager.NativeMethodInfoPtr_RefreshCookerStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673444);
			CookSystemManager.NativeMethodInfoPtr_CallTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673445);
			CookSystemManager.NativeMethodInfoPtr_CallStorage_Public_Void_SellableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673446);
			CookSystemManager.NativeMethodInfoPtr_GetCooker_Public_CookController_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673447);
			CookSystemManager.NativeMethodInfoPtr_DumpAllCookers_Public_IEnumerable_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673448);
			CookSystemManager.NativeMethodInfoPtr_CallCooker_Public_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673449);
			CookSystemManager.NativeMethodInfoPtr_RefreshCookingSelectionUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673450);
			CookSystemManager.NativeMethodInfoPtr_RefreshInventoryUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673451);
			CookSystemManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673452);
			CookSystemManager.NativeMethodInfoPtr_CallQTENotFullScore_Public_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673453);
			CookSystemManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673454);
			CookSystemManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673455);
			CookSystemManager.NativeMethodInfoPtr_Method_Private_Void_byref___c__DisplayClass39_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, 100673456);
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x06003513 RID: 13587 RVA: 0x001551F4 File Offset: 0x001533F4
		public unsafe UIManager HudManager
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125619, XrefRangeEnd = 125622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_get_HudManager_Public_get_UIManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr3) : null;
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x00155234 File Offset: 0x00153434
		// (set) Token: 0x06003515 RID: 13589 RVA: 0x00155274 File Offset: 0x00153474
		public unsafe Dictionary<Vector3Int, CookController> AllCookers
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 40377, RefRangeEnd = 40394, XrefRangeStart = 40377, XrefRangeEnd = 40394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_get_AllCookers_Private_get_Dictionary_2_Vector3Int_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, CookController>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_set_AllCookers_Private_set_Void_Dictionary_2_Vector3Int_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x001552B8 File Offset: 0x001534B8
		public unsafe IEnumerable<CookController> AllCookerControllers
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 125626, RefRangeEnd = 125633, XrefRangeStart = 125622, XrefRangeEnd = 125626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_get_AllCookerControllers_Public_get_IEnumerable_1_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<CookController>>(intPtr3) : null;
			}
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x001552F8 File Offset: 0x001534F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125633, RefRangeEnd = 125634, XrefRangeStart = 125633, XrefRangeEnd = 125633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCookingSelectionModuleAlpha(float ing, float recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ing;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_SetCookingSelectionModuleAlpha_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x00155344 File Offset: 0x00153544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125634, RefRangeEnd = 125635, XrefRangeStart = 125634, XrefRangeEnd = 125634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStorageModuleAlpha(float food, float bev)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref food;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bev;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_SetStorageModuleAlpha_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x06003519 RID: 13593 RVA: 0x00155390 File Offset: 0x00153590
		// (set) Token: 0x0600351A RID: 13594 RVA: 0x001553CC File Offset: 0x001535CC
		public unsafe bool IsCookingSelectionPanelOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_get_IsCookingSelectionPanelOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_set_IsCookingSelectionPanelOpen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x0015540C File Offset: 0x0015360C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125640, RefRangeEnd = 125641, XrefRangeStart = 125635, XrefRangeEnd = 125640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnQTENotFullScoreCallback(Action<CookController> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_add_OnQTENotFullScoreCallback_Public_add_Void_Action_1_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x00155450 File Offset: 0x00153650
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125646, RefRangeEnd = 125648, XrefRangeStart = 125641, XrefRangeEnd = 125646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnQTENotFullScoreCallback(Action<CookController> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_remove_OnQTENotFullScoreCallback_Public_rem_Void_Action_1_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x00155494 File Offset: 0x00153694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125653, RefRangeEnd = 125655, XrefRangeStart = 125648, XrefRangeEnd = 125653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnCookerStartCookCallback(Action<Sellable, Recipe> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_add_OnCookerStartCookCallback_Public_add_Void_Action_2_Sellable_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x001554D8 File Offset: 0x001536D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125660, RefRangeEnd = 125662, XrefRangeStart = 125655, XrefRangeEnd = 125660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnCookerStartCookCallback(Action<Sellable, Recipe> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_remove_OnCookerStartCookCallback_Public_rem_Void_Action_2_Sellable_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x0015551C File Offset: 0x0015371C
		[CallerCount(0)]
		public unsafe void CallCookerStartCallback(Sellable sellable, Recipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_CallCookerStartCallback_Public_Void_Sellable_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x00155570 File Offset: 0x00153770
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125667, RefRangeEnd = 125669, XrefRangeStart = 125662, XrefRangeEnd = 125667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnResultCompleteCallback(Action<Sellable> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_add_OnResultCompleteCallback_Public_add_Void_Action_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x001555B4 File Offset: 0x001537B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125674, RefRangeEnd = 125675, XrefRangeStart = 125669, XrefRangeEnd = 125674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnResultCompleteCallback(Action<Sellable> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_remove_OnResultCompleteCallback_Public_rem_Void_Action_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x001555F8 File Offset: 0x001537F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125675, RefRangeEnd = 125676, XrefRangeStart = 125675, XrefRangeEnd = 125675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallOnResultCompleteCallback(Sellable sellable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_CallOnResultCompleteCallback_Public_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x0015563C File Offset: 0x0015383C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 125680, RefRangeEnd = 125683, XrefRangeStart = 125676, XrefRangeEnd = 125680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCooker(Sellable sellable, out Cooker cookerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_GetCooker_Public_Boolean_Sellable_byref_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cookerData = ((intPtr4 == 0) ? null : new Cooker(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x001556AC File Offset: 0x001538AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125683, XrefRangeEnd = 125690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCooker(Sellable sellable, Cooker cookerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookerData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_RegisterCooker_Public_Void_Sellable_Cooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x00155700 File Offset: 0x00153900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125697, RefRangeEnd = 125698, XrefRangeStart = 125690, XrefRangeEnd = 125697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseCooker(Sellable sellable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_ReleaseCooker_Public_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x00155744 File Offset: 0x00153944
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 125743, RefRangeEnd = 125746, XrefRangeStart = 125698, XrefRangeEnd = 125743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<NormalGuest> GetRandomNormalGuestGroups()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_GetRandomNormalGuestGroups_Public_IEnumerable_1_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NormalGuest>>(intPtr3) : null;
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x00155784 File Offset: 0x00153984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125840, RefRangeEnd = 125842, XrefRangeStart = 125746, XrefRangeEnd = 125840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(IReadOnlyList<Vector3Int> cookerPositions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookerPositions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_Initialize_Public_Void_IReadOnlyList_1_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x001557C8 File Offset: 0x001539C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 125850, RefRangeEnd = 125853, XrefRangeStart = 125842, XrefRangeEnd = 125850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CouldCookerOpen(Vector3Int targetPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_CouldCookerOpen_Public_Boolean_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x00155814 File Offset: 0x00153A14
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 125909, RefRangeEnd = 125923, XrefRangeStart = 125853, XrefRangeEnd = 125909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCookerStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_RefreshCookerStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x00155848 File Offset: 0x00153A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125928, RefRangeEnd = 125929, XrefRangeStart = 125923, XrefRangeEnd = 125928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_CallTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x0015587C File Offset: 0x00153A7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125933, RefRangeEnd = 125935, XrefRangeStart = 125929, XrefRangeEnd = 125933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallStorage(Sellable.SellableType storageType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref storageType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_CallStorage_Public_Void_SellableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x001558BC File Offset: 0x00153ABC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 125938, RefRangeEnd = 125951, XrefRangeStart = 125935, XrefRangeEnd = 125938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookController GetCooker(Vector3Int cookerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cookerPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_GetCooker_Public_CookController_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr3) : null;
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x00155908 File Offset: 0x00153B08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125993, RefRangeEnd = 125995, XrefRangeStart = 125951, XrefRangeEnd = 125993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Sellable> DumpAllCookers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_DumpAllCookers_Public_IEnumerable_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sellable>>(intPtr3) : null;
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x00155948 File Offset: 0x00153B48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126009, RefRangeEnd = 126010, XrefRangeStart = 125995, XrefRangeEnd = 126009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallCooker(Vector3Int cookerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cookerPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_CallCooker_Public_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x00155988 File Offset: 0x00153B88
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCookingSelectionUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_RefreshCookingSelectionUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x001559BC File Offset: 0x00153BBC
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshInventoryUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_RefreshInventoryUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x001559F0 File Offset: 0x00153BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126010, XrefRangeEnd = 126013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookSystemManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x00155A2C File Offset: 0x00153C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126013, RefRangeEnd = 126014, XrefRangeStart = 126013, XrefRangeEnd = 126013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallQTENotFullScore(CookController cookController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_CallQTENotFullScore_Public_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x00155A70 File Offset: 0x00153C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126014, XrefRangeEnd = 126021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookSystemManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x00155AAC File Offset: 0x00153CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126021, XrefRangeEnd = 126032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookSystemManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x00155AE8 File Offset: 0x00153CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126032, XrefRangeEnd = 126043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_byref___c__DisplayClass39_0_PDM_0(ref CookSystemManager.__c__DisplayClass39_0 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.NativeMethodInfoPtr_Method_Private_Void_byref___c__DisplayClass39_0_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x0001D7B2 File Offset: 0x0001B9B2
		public CookSystemManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x06003537 RID: 13623 RVA: 0x00155B2C File Offset: 0x00153D2C
		// (set) Token: 0x06003538 RID: 13624 RVA: 0x0001D7BB File Offset: 0x0001B9BB
		public unsafe Dictionary<Guid, Cooker> registeredSellables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr_registeredSellables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Guid, Cooker>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr_registeredSellables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x06003539 RID: 13625 RVA: 0x00155B5C File Offset: 0x00153D5C
		// (set) Token: 0x0600353A RID: 13626 RVA: 0x0001D7DA File Offset: 0x0001B9DA
		public unsafe Vector2 cookingSelectionModuleAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr_cookingSelectionModuleAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr_cookingSelectionModuleAlpha)) = value;
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x0600353B RID: 13627 RVA: 0x00155B84 File Offset: 0x00153D84
		// (set) Token: 0x0600353C RID: 13628 RVA: 0x0001D7F5 File Offset: 0x0001B9F5
		public unsafe Vector2 storageModuleAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr_storageModuleAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr_storageModuleAlpha)) = value;
			}
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x0600353D RID: 13629 RVA: 0x00155BAC File Offset: 0x00153DAC
		// (set) Token: 0x0600353E RID: 13630 RVA: 0x0001D810 File Offset: 0x0001BA10
		public unsafe Dictionary<Vector3Int, CookController> _AllCookers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr__AllCookers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector3Int, CookController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr__AllCookers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x0600353F RID: 13631 RVA: 0x00155BDC File Offset: 0x00153DDC
		// (set) Token: 0x06003540 RID: 13632 RVA: 0x0001D82F File Offset: 0x0001BA2F
		public unsafe bool _IsCookingSelectionPanelOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr__IsCookingSelectionPanelOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr__IsCookingSelectionPanelOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06003541 RID: 13633 RVA: 0x00155C04 File Offset: 0x00153E04
		// (set) Token: 0x06003542 RID: 13634 RVA: 0x0001D84A File Offset: 0x0001BA4A
		public unsafe Action<CookController> OnQTENotFullScoreCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr_OnQTENotFullScoreCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CookController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr_OnQTENotFullScoreCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06003543 RID: 13635 RVA: 0x00155C34 File Offset: 0x00153E34
		// (set) Token: 0x06003544 RID: 13636 RVA: 0x0001D869 File Offset: 0x0001BA69
		public unsafe Action<Sellable, Recipe> OnCookerStartCookCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr_OnCookerStartCookCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sellable, Recipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr_OnCookerStartCookCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06003545 RID: 13637 RVA: 0x00155C64 File Offset: 0x00153E64
		// (set) Token: 0x06003546 RID: 13638 RVA: 0x0001D888 File Offset: 0x0001BA88
		public unsafe Action<Sellable> OnResultCompleteCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr_OnResultCompleteCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.NativeFieldInfoPtr_OnResultCompleteCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023DA RID: 9178
		private static readonly IntPtr NativeFieldInfoPtr_registeredSellables;

		// Token: 0x040023DB RID: 9179
		private static readonly IntPtr NativeFieldInfoPtr_cookingSelectionModuleAlpha;

		// Token: 0x040023DC RID: 9180
		private static readonly IntPtr NativeFieldInfoPtr_storageModuleAlpha;

		// Token: 0x040023DD RID: 9181
		private static readonly IntPtr NativeFieldInfoPtr__AllCookers_k__BackingField;

		// Token: 0x040023DE RID: 9182
		private static readonly IntPtr NativeFieldInfoPtr__IsCookingSelectionPanelOpen_k__BackingField;

		// Token: 0x040023DF RID: 9183
		private static readonly IntPtr NativeFieldInfoPtr_OnQTENotFullScoreCallback;

		// Token: 0x040023E0 RID: 9184
		private static readonly IntPtr NativeFieldInfoPtr_OnCookerStartCookCallback;

		// Token: 0x040023E1 RID: 9185
		private static readonly IntPtr NativeFieldInfoPtr_OnResultCompleteCallback;

		// Token: 0x040023E2 RID: 9186
		private static readonly IntPtr NativeMethodInfoPtr_get_HudManager_Public_get_UIManager_0;

		// Token: 0x040023E3 RID: 9187
		private static readonly IntPtr NativeMethodInfoPtr_get_AllCookers_Private_get_Dictionary_2_Vector3Int_CookController_0;

		// Token: 0x040023E4 RID: 9188
		private static readonly IntPtr NativeMethodInfoPtr_set_AllCookers_Private_set_Void_Dictionary_2_Vector3Int_CookController_0;

		// Token: 0x040023E5 RID: 9189
		private static readonly IntPtr NativeMethodInfoPtr_get_AllCookerControllers_Public_get_IEnumerable_1_CookController_0;

		// Token: 0x040023E6 RID: 9190
		private static readonly IntPtr NativeMethodInfoPtr_SetCookingSelectionModuleAlpha_Public_Void_Single_Single_0;

		// Token: 0x040023E7 RID: 9191
		private static readonly IntPtr NativeMethodInfoPtr_SetStorageModuleAlpha_Public_Void_Single_Single_0;

		// Token: 0x040023E8 RID: 9192
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCookingSelectionPanelOpen_Public_get_Boolean_0;

		// Token: 0x040023E9 RID: 9193
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCookingSelectionPanelOpen_Public_set_Void_Boolean_0;

		// Token: 0x040023EA RID: 9194
		private static readonly IntPtr NativeMethodInfoPtr_add_OnQTENotFullScoreCallback_Public_add_Void_Action_1_CookController_0;

		// Token: 0x040023EB RID: 9195
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnQTENotFullScoreCallback_Public_rem_Void_Action_1_CookController_0;

		// Token: 0x040023EC RID: 9196
		private static readonly IntPtr NativeMethodInfoPtr_add_OnCookerStartCookCallback_Public_add_Void_Action_2_Sellable_Recipe_0;

		// Token: 0x040023ED RID: 9197
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnCookerStartCookCallback_Public_rem_Void_Action_2_Sellable_Recipe_0;

		// Token: 0x040023EE RID: 9198
		private static readonly IntPtr NativeMethodInfoPtr_CallCookerStartCallback_Public_Void_Sellable_Recipe_0;

		// Token: 0x040023EF RID: 9199
		private static readonly IntPtr NativeMethodInfoPtr_add_OnResultCompleteCallback_Public_add_Void_Action_1_Sellable_0;

		// Token: 0x040023F0 RID: 9200
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnResultCompleteCallback_Public_rem_Void_Action_1_Sellable_0;

		// Token: 0x040023F1 RID: 9201
		private static readonly IntPtr NativeMethodInfoPtr_CallOnResultCompleteCallback_Public_Void_Sellable_0;

		// Token: 0x040023F2 RID: 9202
		private static readonly IntPtr NativeMethodInfoPtr_GetCooker_Public_Boolean_Sellable_byref_Cooker_0;

		// Token: 0x040023F3 RID: 9203
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCooker_Public_Void_Sellable_Cooker_0;

		// Token: 0x040023F4 RID: 9204
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCooker_Public_Void_Sellable_0;

		// Token: 0x040023F5 RID: 9205
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomNormalGuestGroups_Public_IEnumerable_1_NormalGuest_0;

		// Token: 0x040023F6 RID: 9206
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_IReadOnlyList_1_Vector3Int_0;

		// Token: 0x040023F7 RID: 9207
		private static readonly IntPtr NativeMethodInfoPtr_CouldCookerOpen_Public_Boolean_Vector3Int_0;

		// Token: 0x040023F8 RID: 9208
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCookerStatus_Public_Void_0;

		// Token: 0x040023F9 RID: 9209
		private static readonly IntPtr NativeMethodInfoPtr_CallTrash_Public_Void_0;

		// Token: 0x040023FA RID: 9210
		private static readonly IntPtr NativeMethodInfoPtr_CallStorage_Public_Void_SellableType_0;

		// Token: 0x040023FB RID: 9211
		private static readonly IntPtr NativeMethodInfoPtr_GetCooker_Public_CookController_Vector3Int_0;

		// Token: 0x040023FC RID: 9212
		private static readonly IntPtr NativeMethodInfoPtr_DumpAllCookers_Public_IEnumerable_1_Sellable_0;

		// Token: 0x040023FD RID: 9213
		private static readonly IntPtr NativeMethodInfoPtr_CallCooker_Public_Void_Vector3Int_0;

		// Token: 0x040023FE RID: 9214
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCookingSelectionUI_Public_Void_0;

		// Token: 0x040023FF RID: 9215
		private static readonly IntPtr NativeMethodInfoPtr_RefreshInventoryUI_Public_Void_0;

		// Token: 0x04002400 RID: 9216
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04002401 RID: 9217
		private static readonly IntPtr NativeMethodInfoPtr_CallQTENotFullScore_Public_Void_CookController_0;

		// Token: 0x04002402 RID: 9218
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002403 RID: 9219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002404 RID: 9220
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_byref___c__DisplayClass39_0_PDM_0;

		// Token: 0x0200090A RID: 2314
		[ObfuscatedName("NightScene.CookingUtility.CookSystemManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600B6E2 RID: 46818 RVA: 0x002E62A4 File Offset: 0x002E44A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr);
				CookSystemManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr, "<>9");
				CookSystemManager.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr, "<>9__31_0");
				CookSystemManager.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr, "<>9__32_0");
				CookSystemManager.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr, "<>9__34_0");
				CookSystemManager.__c.NativeFieldInfoPtr___9__38_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr, "<>9__38_1");
				CookSystemManager.__c.NativeFieldInfoPtr___9__39_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr, "<>9__39_1");
				CookSystemManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr, 100673458);
				CookSystemManager.__c.NativeMethodInfoPtr__GetRandomNormalGuestGroups_b__31_0_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr, 100673459);
				CookSystemManager.__c.NativeMethodInfoPtr__Initialize_b__32_0_Internal_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr, 100673460);
				CookSystemManager.__c.NativeMethodInfoPtr__RefreshCookerStatus_b__34_0_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr, 100673461);
				CookSystemManager.__c.NativeMethodInfoPtr__DumpAllCookers_b__38_1_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr, 100673462);
				CookSystemManager.__c.NativeMethodInfoPtr__CallCooker_b__39_1_Internal_Void_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr, 100673463);
			}

			// Token: 0x0600B6E3 RID: 46819 RVA: 0x002E63C0 File Offset: 0x002E45C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookSystemManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6E4 RID: 46820 RVA: 0x002E63FC File Offset: 0x002E45FC
			[CallerCount(0)]
			public unsafe bool _GetRandomNormalGuestGroups_b__31_0(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.__c.NativeMethodInfoPtr__GetRandomNormalGuestGroups_b__31_0_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B6E5 RID: 46821 RVA: 0x002E644C File Offset: 0x002E464C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125602, XrefRangeEnd = 125608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__32_0(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.__c.NativeMethodInfoPtr__Initialize_b__32_0_Internal_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6E6 RID: 46822 RVA: 0x002E6490 File Offset: 0x002E4690
			[CallerCount(0)]
			public unsafe bool _RefreshCookerStatus_b__34_0(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.__c.NativeMethodInfoPtr__RefreshCookerStatus_b__34_0_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B6E7 RID: 46823 RVA: 0x002E64E0 File Offset: 0x002E46E0
			[CallerCount(0)]
			public unsafe bool _DumpAllCookers_b__38_1(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.__c.NativeMethodInfoPtr__DumpAllCookers_b__38_1_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B6E8 RID: 46824 RVA: 0x002E6530 File Offset: 0x002E4730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125608, XrefRangeEnd = 125613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CallCooker_b__39_1(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.__c.NativeMethodInfoPtr__CallCooker_b__39_1_Internal_Void_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6E9 RID: 46825 RVA: 0x00062927 File Offset: 0x00060B27
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BF5 RID: 15349
			// (get) Token: 0x0600B6EA RID: 46826 RVA: 0x002E6574 File Offset: 0x002E4774
			// (set) Token: 0x0600B6EB RID: 46827 RVA: 0x00062930 File Offset: 0x00060B30
			public unsafe static CookSystemManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CookSystemManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookSystemManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CookSystemManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF6 RID: 15350
			// (get) Token: 0x0600B6EC RID: 46828 RVA: 0x002E659C File Offset: 0x002E479C
			// (set) Token: 0x0600B6ED RID: 46829 RVA: 0x00062942 File Offset: 0x00060B42
			public unsafe static Func<CookController, bool> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CookSystemManager.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CookController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CookSystemManager.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF7 RID: 15351
			// (get) Token: 0x0600B6EE RID: 46830 RVA: 0x002E65C4 File Offset: 0x002E47C4
			// (set) Token: 0x0600B6EF RID: 46831 RVA: 0x00062954 File Offset: 0x00060B54
			public unsafe static Action<CookController> __9__32_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CookSystemManager.__c.NativeFieldInfoPtr___9__32_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CookController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CookSystemManager.__c.NativeFieldInfoPtr___9__32_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF8 RID: 15352
			// (get) Token: 0x0600B6F0 RID: 46832 RVA: 0x002E65EC File Offset: 0x002E47EC
			// (set) Token: 0x0600B6F1 RID: 46833 RVA: 0x00062966 File Offset: 0x00060B66
			public unsafe static Func<CookController, bool> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CookSystemManager.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CookController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CookSystemManager.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BF9 RID: 15353
			// (get) Token: 0x0600B6F2 RID: 46834 RVA: 0x002E6614 File Offset: 0x002E4814
			// (set) Token: 0x0600B6F3 RID: 46835 RVA: 0x00062978 File Offset: 0x00060B78
			public unsafe static Func<Sellable, bool> __9__38_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CookSystemManager.__c.NativeFieldInfoPtr___9__38_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CookSystemManager.__c.NativeFieldInfoPtr___9__38_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BFA RID: 15354
			// (get) Token: 0x0600B6F4 RID: 46836 RVA: 0x002E663C File Offset: 0x002E483C
			// (set) Token: 0x0600B6F5 RID: 46837 RVA: 0x0006298A File Offset: 0x00060B8A
			public unsafe static Action<Sellable> __9__39_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CookSystemManager.__c.NativeFieldInfoPtr___9__39_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CookSystemManager.__c.NativeFieldInfoPtr___9__39_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007671 RID: 30321
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007672 RID: 30322
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x04007673 RID: 30323
			private static readonly IntPtr NativeFieldInfoPtr___9__32_0;

			// Token: 0x04007674 RID: 30324
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x04007675 RID: 30325
			private static readonly IntPtr NativeFieldInfoPtr___9__38_1;

			// Token: 0x04007676 RID: 30326
			private static readonly IntPtr NativeFieldInfoPtr___9__39_1;

			// Token: 0x04007677 RID: 30327
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007678 RID: 30328
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomNormalGuestGroups_b__31_0_Internal_Boolean_CookController_0;

			// Token: 0x04007679 RID: 30329
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__32_0_Internal_Void_CookController_0;

			// Token: 0x0400767A RID: 30330
			private static readonly IntPtr NativeMethodInfoPtr__RefreshCookerStatus_b__34_0_Internal_Boolean_CookController_0;

			// Token: 0x0400767B RID: 30331
			private static readonly IntPtr NativeMethodInfoPtr__DumpAllCookers_b__38_1_Internal_Boolean_Sellable_0;

			// Token: 0x0400767C RID: 30332
			private static readonly IntPtr NativeMethodInfoPtr__CallCooker_b__39_1_Internal_Void_Sellable_0;
		}

		// Token: 0x0200090B RID: 2315
		[ObfuscatedName("NightScene.CookingUtility.CookSystemManager+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
		{
			// Token: 0x0600B6F6 RID: 46838 RVA: 0x002E6664 File Offset: 0x002E4864
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<CookSystemManager.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookSystemManager.__c__DisplayClass38_0>.NativeClassPtr);
				CookSystemManager.__c__DisplayClass38_0.NativeFieldInfoPtr_allExtracted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager.__c__DisplayClass38_0>.NativeClassPtr, "allExtracted");
				CookSystemManager.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager.__c__DisplayClass38_0>.NativeClassPtr, 100673464);
				CookSystemManager.__c__DisplayClass38_0.NativeMethodInfoPtr__DumpAllCookers_b__0_Internal_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookSystemManager.__c__DisplayClass38_0>.NativeClassPtr, 100673465);
			}

			// Token: 0x0600B6F7 RID: 46839 RVA: 0x002E66CC File Offset: 0x002E48CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookSystemManager.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6F8 RID: 46840 RVA: 0x002E6708 File Offset: 0x002E4908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125613, XrefRangeEnd = 125619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DumpAllCookers_b__0(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookSystemManager.__c__DisplayClass38_0.NativeMethodInfoPtr__DumpAllCookers_b__0_Internal_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B6F9 RID: 46841 RVA: 0x0006299C File Offset: 0x00060B9C
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003BFB RID: 15355
			// (get) Token: 0x0600B6FA RID: 46842 RVA: 0x002E674C File Offset: 0x002E494C
			// (set) Token: 0x0600B6FB RID: 46843 RVA: 0x000629A5 File Offset: 0x00060BA5
			public unsafe List<Sellable> allExtracted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.__c__DisplayClass38_0.NativeFieldInfoPtr_allExtracted);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sellable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.__c__DisplayClass38_0.NativeFieldInfoPtr_allExtracted), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400767D RID: 30333
			private static readonly IntPtr NativeFieldInfoPtr_allExtracted;

			// Token: 0x0400767E RID: 30334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400767F RID: 30335
			private static readonly IntPtr NativeMethodInfoPtr__DumpAllCookers_b__0_Internal_Void_CookController_0;
		}

		// Token: 0x0200090C RID: 2316
		[ObfuscatedName("NightScene.CookingUtility.CookSystemManager+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : ValueType
		{
			// Token: 0x0600B6FC RID: 46844 RVA: 0x002E677C File Offset: 0x002E497C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<CookSystemManager.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookSystemManager>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookSystemManager.__c__DisplayClass39_0>.NativeClassPtr);
				CookSystemManager.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				CookSystemManager.__c__DisplayClass39_0.NativeFieldInfoPtr_cookerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager.__c__DisplayClass39_0>.NativeClassPtr, "cookerPosition");
				CookSystemManager.__c__DisplayClass39_0.NativeFieldInfoPtr_cook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookSystemManager.__c__DisplayClass39_0>.NativeClassPtr, "cook");
			}

			// Token: 0x0600B6FD RID: 46845 RVA: 0x000629C4 File Offset: 0x00060BC4
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B6FE RID: 46846 RVA: 0x000629CD File Offset: 0x00060BCD
			public __c__DisplayClass39_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookSystemManager.__c__DisplayClass39_0>.NativeClassPtr))
			{
			}

			// Token: 0x17003BFC RID: 15356
			// (get) Token: 0x0600B6FF RID: 46847 RVA: 0x002E67E4 File Offset: 0x002E49E4
			// (set) Token: 0x0600B700 RID: 46848 RVA: 0x000629DF File Offset: 0x00060BDF
			public unsafe CookSystemManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookSystemManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003BFD RID: 15357
			// (get) Token: 0x0600B701 RID: 46849 RVA: 0x002E6814 File Offset: 0x002E4A14
			// (set) Token: 0x0600B702 RID: 46850 RVA: 0x000629FE File Offset: 0x00060BFE
			public unsafe Vector3Int cookerPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.__c__DisplayClass39_0.NativeFieldInfoPtr_cookerPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.__c__DisplayClass39_0.NativeFieldInfoPtr_cookerPosition)) = value;
				}
			}

			// Token: 0x17003BFE RID: 15358
			// (get) Token: 0x0600B703 RID: 46851 RVA: 0x002E683C File Offset: 0x002E4A3C
			// (set) Token: 0x0600B704 RID: 46852 RVA: 0x00062A19 File Offset: 0x00060C19
			public unsafe CookController cook
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.__c__DisplayClass39_0.NativeFieldInfoPtr_cook);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookSystemManager.__c__DisplayClass39_0.NativeFieldInfoPtr_cook), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007680 RID: 30336
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007681 RID: 30337
			private static readonly IntPtr NativeFieldInfoPtr_cookerPosition;

			// Token: 0x04007682 RID: 30338
			private static readonly IntPtr NativeFieldInfoPtr_cook;
		}
	}
}
