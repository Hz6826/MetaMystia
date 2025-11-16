using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000331 RID: 817
	public class PartnerCookBehaviour : PartnerBase
	{
		// Token: 0x0600607E RID: 24702 RVA: 0x001E037C File Offset: 0x001DE57C
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerCookBehaviour()
		{
			Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerCookBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr);
			PartnerCookBehaviour.NativeFieldInfoPtr_EXTRA_COOKER_MOVEMENT_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, "EXTRA_COOKER_MOVEMENT_OFFSET");
			PartnerCookBehaviour.NativeFieldInfoPtr_cookingCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, "cookingCoroutine");
			PartnerCookBehaviour.NativeFieldInfoPtr_selectedRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, "selectedRecipe");
			PartnerCookBehaviour.NativeFieldInfoPtr_shouldReturnIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, "shouldReturnIngredients");
			PartnerCookBehaviour.NativeFieldInfoPtr_whenIngredientsReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, "whenIngredientsReturn");
			PartnerCookBehaviour.NativeFieldInfoPtr__TargetCooker_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, "<TargetCooker>k__BackingField");
			PartnerCookBehaviour.NativeMethodInfoPtr_get_TargetCooker_Private_get_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683169);
			PartnerCookBehaviour.NativeMethodInfoPtr_set_TargetCooker_Private_set_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683170);
			PartnerCookBehaviour.NativeMethodInfoPtr_get_FocusingOrder_Private_get_NormalOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683171);
			PartnerCookBehaviour.NativeMethodInfoPtr_set_FocusingOrder_Private_set_Void_NormalOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683172);
			PartnerCookBehaviour.NativeMethodInfoPtr_TryAcceptOrder_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683173);
			PartnerCookBehaviour.NativeMethodInfoPtr_HasInventorySufficientForTargetFood_Private_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683174);
			PartnerCookBehaviour.NativeMethodInfoPtr_CheckIfNeedToCookForTargetOrder_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683175);
			PartnerCookBehaviour.NativeMethodInfoPtr_ResetStatus_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683176);
			PartnerCookBehaviour.NativeMethodInfoPtr_TryGetCooker_Private_GetCookerInfo_NormalOrder_byref_CookController_byref_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683177);
			PartnerCookBehaviour.NativeMethodInfoPtr_GetPartnerType_Public_Virtual_PartnerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683178);
			PartnerCookBehaviour.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683179);
			PartnerCookBehaviour.NativeMethodInfoPtr_OnPlayIdleState_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683180);
			PartnerCookBehaviour.NativeMethodInfoPtr_OnCookIdleReceiveSystemChange_Public_Boolean_OrderChangeContext_OrderBase_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683181);
			PartnerCookBehaviour.NativeMethodInfoPtr_PlayMoveToCookerState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683182);
			PartnerCookBehaviour.NativeMethodInfoPtr_OnMoveToCookerReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683183);
			PartnerCookBehaviour.NativeMethodInfoPtr_OnMoveToCookerStateInterrupt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683184);
			PartnerCookBehaviour.NativeMethodInfoPtr_PlayCookState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683185);
			PartnerCookBehaviour.NativeMethodInfoPtr_OnCookingReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683186);
			PartnerCookBehaviour.NativeMethodInfoPtr_OnCookingStateInterrupt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683187);
			PartnerCookBehaviour.NativeMethodInfoPtr_EmployeeCookingCoroutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683188);
			PartnerCookBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683189);
			PartnerCookBehaviour.NativeMethodInfoPtr__ResetStatus_b__15_0_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683191);
			PartnerCookBehaviour.NativeMethodInfoPtr__OnCookIdleReceiveSystemChange_b__20_0_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683192);
			PartnerCookBehaviour.NativeMethodInfoPtr__OnCookingReceiveSystemChange_b__25_0_Private_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, 100683193);
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x0600607F RID: 24703 RVA: 0x001E0604 File Offset: 0x001DE804
		// (set) Token: 0x06006080 RID: 24704 RVA: 0x001E0644 File Offset: 0x001DE844
		public unsafe CookController TargetCooker
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_get_TargetCooker_Private_get_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_set_TargetCooker_Private_set_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x06006081 RID: 24705 RVA: 0x001E0688 File Offset: 0x001DE888
		// (set) Token: 0x06006082 RID: 24706 RVA: 0x001E06C8 File Offset: 0x001DE8C8
		public unsafe GuestsManager.NormalOrder FocusingOrder
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 238462, RefRangeEnd = 238486, XrefRangeStart = 238461, XrefRangeEnd = 238462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_get_FocusingOrder_Private_get_NormalOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GuestsManager.NormalOrder>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_set_FocusingOrder_Private_set_Void_NormalOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006083 RID: 24707 RVA: 0x001E070C File Offset: 0x001DE90C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238512, RefRangeEnd = 238513, XrefRangeStart = 238486, XrefRangeEnd = 238512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAcceptOrder(GuestsManager.OrderBase targetOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_TryAcceptOrder_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x001E075C File Offset: 0x001DE95C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238540, RefRangeEnd = 238542, XrefRangeStart = 238513, XrefRangeEnd = 238540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasInventorySufficientForTargetFood(Recipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_HasInventorySufficientForTargetFood_Private_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x001E07AC File Offset: 0x001DE9AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 238711, RefRangeEnd = 238715, XrefRangeStart = 238542, XrefRangeEnd = 238711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckIfNeedToCookForTargetOrder(GuestsManager.OrderBase targetOrderBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetOrderBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_CheckIfNeedToCookForTargetOrder_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x001E07FC File Offset: 0x001DE9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238715, XrefRangeEnd = 238750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResetStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerCookBehaviour.NativeMethodInfoPtr_ResetStatus_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006087 RID: 24711 RVA: 0x001E0838 File Offset: 0x001DEA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238750, XrefRangeEnd = 238755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerManager.GetCookerInfo TryGetCooker(GuestsManager.NormalOrder focusingOrder, out CookController cookController, out Recipe targetRecipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusingOrder);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_TryGetCooker_Private_GetCookerInfo_NormalOrder_byref_CookController_byref_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			cookController = ((intPtr5 == 0) ? null : new CookController(intPtr5));
			IntPtr intPtr6 = intPtr2;
			targetRecipe = ((intPtr6 == 0) ? null : new Recipe(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x001E08CC File Offset: 0x001DEACC
		[CallerCount(299)]
		[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PartnerBase.PartnerType GetPartnerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerCookBehaviour.NativeMethodInfoPtr_GetPartnerType_Public_Virtual_PartnerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x001E0914 File Offset: 0x001DEB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerCookBehaviour.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x001E0950 File Offset: 0x001DEB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238755, XrefRangeEnd = 238763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayIdleState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerCookBehaviour.NativeMethodInfoPtr_OnPlayIdleState_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600608B RID: 24715 RVA: 0x001E098C File Offset: 0x001DEB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238763, XrefRangeEnd = 238779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnCookIdleReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, Il2CppSystem.Object additionalInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orderChangeContext;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalInformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_OnCookIdleReceiveSystemChange_Public_Boolean_OrderChangeContext_OrderBase_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600608C RID: 24716 RVA: 0x001E09FC File Offset: 0x001DEBFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238827, RefRangeEnd = 238828, XrefRangeStart = 238779, XrefRangeEnd = 238827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMoveToCookerState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_PlayMoveToCookerState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600608D RID: 24717 RVA: 0x001E0A30 File Offset: 0x001DEC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238828, XrefRangeEnd = 238866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnMoveToCookerReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, Il2CppSystem.Object additionalInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orderChangeContext;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalInformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_OnMoveToCookerReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600608E RID: 24718 RVA: 0x001E0AA0 File Offset: 0x001DECA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238866, XrefRangeEnd = 238883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMoveToCookerStateInterrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_OnMoveToCookerStateInterrupt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x001E0AD4 File Offset: 0x001DECD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238883, XrefRangeEnd = 238911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCookState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_PlayCookState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x001E0B08 File Offset: 0x001DED08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238911, XrefRangeEnd = 238994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnCookingReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, Il2CppSystem.Object additionalInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orderChangeContext;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetOrder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalInformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_OnCookingReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x001E0B78 File Offset: 0x001DED78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238994, XrefRangeEnd = 239026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCookingStateInterrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_OnCookingStateInterrupt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x001E0BAC File Offset: 0x001DEDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239026, XrefRangeEnd = 239031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator EmployeeCookingCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr_EmployeeCookingCoroutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x001E0BEC File Offset: 0x001DEDEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 239035, RefRangeEnd = 239039, XrefRangeStart = 239031, XrefRangeEnd = 239035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerCookBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x001E0C28 File Offset: 0x001DEE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239039, XrefRangeEnd = 239040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ResetStatus_b__15_0(GuestsManager.OrderBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr__ResetStatus_b__15_0_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006095 RID: 24725 RVA: 0x001E0C78 File Offset: 0x001DEE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnCookIdleReceiveSystemChange_b__20_0(GuestsManager.OrderBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr__OnCookIdleReceiveSystemChange_b__20_0_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x001E0CC8 File Offset: 0x001DEEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239040, XrefRangeEnd = 239046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnCookingReceiveSystemChange_b__25_0(GuestsManager.OrderBase x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.NativeMethodInfoPtr__OnCookingReceiveSystemChange_b__25_0_Private_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x0003462F File Offset: 0x0003282F
		public PartnerCookBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x06006098 RID: 24728 RVA: 0x001E0D18 File Offset: 0x001DEF18
		// (set) Token: 0x06006099 RID: 24729 RVA: 0x00034638 File Offset: 0x00032838
		public unsafe static Vector3 EXTRA_COOKER_MOVEMENT_OFFSET
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(PartnerCookBehaviour.NativeFieldInfoPtr_EXTRA_COOKER_MOVEMENT_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartnerCookBehaviour.NativeFieldInfoPtr_EXTRA_COOKER_MOVEMENT_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x0600609A RID: 24730 RVA: 0x001E0D34 File Offset: 0x001DEF34
		// (set) Token: 0x0600609B RID: 24731 RVA: 0x00034646 File Offset: 0x00032846
		public unsafe Coroutine cookingCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.NativeFieldInfoPtr_cookingCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.NativeFieldInfoPtr_cookingCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x0600609C RID: 24732 RVA: 0x001E0D64 File Offset: 0x001DEF64
		// (set) Token: 0x0600609D RID: 24733 RVA: 0x00034665 File Offset: 0x00032865
		public unsafe Recipe selectedRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.NativeFieldInfoPtr_selectedRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.NativeFieldInfoPtr_selectedRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x0600609E RID: 24734 RVA: 0x001E0D94 File Offset: 0x001DEF94
		// (set) Token: 0x0600609F RID: 24735 RVA: 0x00034684 File Offset: 0x00032884
		public unsafe bool shouldReturnIngredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.NativeFieldInfoPtr_shouldReturnIngredients);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.NativeFieldInfoPtr_shouldReturnIngredients)) = value;
			}
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x060060A0 RID: 24736 RVA: 0x001E0DBC File Offset: 0x001DEFBC
		// (set) Token: 0x060060A1 RID: 24737 RVA: 0x0003469F File Offset: 0x0003289F
		public unsafe Action whenIngredientsReturn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.NativeFieldInfoPtr_whenIngredientsReturn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.NativeFieldInfoPtr_whenIngredientsReturn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x060060A2 RID: 24738 RVA: 0x001E0DEC File Offset: 0x001DEFEC
		// (set) Token: 0x060060A3 RID: 24739 RVA: 0x000346BE File Offset: 0x000328BE
		public unsafe CookController _TargetCooker_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.NativeFieldInfoPtr__TargetCooker_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.NativeFieldInfoPtr__TargetCooker_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FE0 RID: 16352
		private static readonly IntPtr NativeFieldInfoPtr_EXTRA_COOKER_MOVEMENT_OFFSET;

		// Token: 0x04003FE1 RID: 16353
		private static readonly IntPtr NativeFieldInfoPtr_cookingCoroutine;

		// Token: 0x04003FE2 RID: 16354
		private static readonly IntPtr NativeFieldInfoPtr_selectedRecipe;

		// Token: 0x04003FE3 RID: 16355
		private static readonly IntPtr NativeFieldInfoPtr_shouldReturnIngredients;

		// Token: 0x04003FE4 RID: 16356
		private static readonly IntPtr NativeFieldInfoPtr_whenIngredientsReturn;

		// Token: 0x04003FE5 RID: 16357
		private static readonly IntPtr NativeFieldInfoPtr__TargetCooker_k__BackingField;

		// Token: 0x04003FE6 RID: 16358
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetCooker_Private_get_CookController_0;

		// Token: 0x04003FE7 RID: 16359
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetCooker_Private_set_Void_CookController_0;

		// Token: 0x04003FE8 RID: 16360
		private static readonly IntPtr NativeMethodInfoPtr_get_FocusingOrder_Private_get_NormalOrder_0;

		// Token: 0x04003FE9 RID: 16361
		private static readonly IntPtr NativeMethodInfoPtr_set_FocusingOrder_Private_set_Void_NormalOrder_0;

		// Token: 0x04003FEA RID: 16362
		private static readonly IntPtr NativeMethodInfoPtr_TryAcceptOrder_Private_Boolean_OrderBase_0;

		// Token: 0x04003FEB RID: 16363
		private static readonly IntPtr NativeMethodInfoPtr_HasInventorySufficientForTargetFood_Private_Boolean_Recipe_0;

		// Token: 0x04003FEC RID: 16364
		private static readonly IntPtr NativeMethodInfoPtr_CheckIfNeedToCookForTargetOrder_Private_Boolean_OrderBase_0;

		// Token: 0x04003FED RID: 16365
		private static readonly IntPtr NativeMethodInfoPtr_ResetStatus_Protected_Virtual_Void_0;

		// Token: 0x04003FEE RID: 16366
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCooker_Private_GetCookerInfo_NormalOrder_byref_CookController_byref_Recipe_0;

		// Token: 0x04003FEF RID: 16367
		private static readonly IntPtr NativeMethodInfoPtr_GetPartnerType_Public_Virtual_PartnerType_0;

		// Token: 0x04003FF0 RID: 16368
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0;

		// Token: 0x04003FF1 RID: 16369
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayIdleState_Protected_Virtual_Void_0;

		// Token: 0x04003FF2 RID: 16370
		private static readonly IntPtr NativeMethodInfoPtr_OnCookIdleReceiveSystemChange_Public_Boolean_OrderChangeContext_OrderBase_Object_0;

		// Token: 0x04003FF3 RID: 16371
		private static readonly IntPtr NativeMethodInfoPtr_PlayMoveToCookerState_Private_Void_0;

		// Token: 0x04003FF4 RID: 16372
		private static readonly IntPtr NativeMethodInfoPtr_OnMoveToCookerReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0;

		// Token: 0x04003FF5 RID: 16373
		private static readonly IntPtr NativeMethodInfoPtr_OnMoveToCookerStateInterrupt_Private_Void_0;

		// Token: 0x04003FF6 RID: 16374
		private static readonly IntPtr NativeMethodInfoPtr_PlayCookState_Private_Void_0;

		// Token: 0x04003FF7 RID: 16375
		private static readonly IntPtr NativeMethodInfoPtr_OnCookingReceiveSystemChange_Private_Boolean_OrderChangeContext_OrderBase_Object_0;

		// Token: 0x04003FF8 RID: 16376
		private static readonly IntPtr NativeMethodInfoPtr_OnCookingStateInterrupt_Private_Void_0;

		// Token: 0x04003FF9 RID: 16377
		private static readonly IntPtr NativeMethodInfoPtr_EmployeeCookingCoroutine_Private_IEnumerator_0;

		// Token: 0x04003FFA RID: 16378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003FFB RID: 16379
		private static readonly IntPtr NativeMethodInfoPtr__ResetStatus_b__15_0_Private_Boolean_OrderBase_0;

		// Token: 0x04003FFC RID: 16380
		private static readonly IntPtr NativeMethodInfoPtr__OnCookIdleReceiveSystemChange_b__20_0_Private_Boolean_OrderBase_0;

		// Token: 0x04003FFD RID: 16381
		private static readonly IntPtr NativeMethodInfoPtr__OnCookingReceiveSystemChange_b__25_0_Private_Boolean_OrderBase_0;

		// Token: 0x02000D7D RID: 3453
		[ObfuscatedName("GameData.Profile.PartnerCookBehaviour+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F663 RID: 63075 RVA: 0x003A25B8 File Offset: 0x003A07B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PartnerCookBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerCookBehaviour.__c>.NativeClassPtr);
				PartnerCookBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour.__c>.NativeClassPtr, "<>9");
				PartnerCookBehaviour.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour.__c>.NativeClassPtr, "<>9__13_0");
				PartnerCookBehaviour.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour.__c>.NativeClassPtr, "<>9__14_2");
				PartnerCookBehaviour.__c.NativeFieldInfoPtr___9__27_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour.__c>.NativeClassPtr, "<>9__27_4");
				PartnerCookBehaviour.__c.NativeFieldInfoPtr___9__27_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour.__c>.NativeClassPtr, "<>9__27_6");
				PartnerCookBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c>.NativeClassPtr, 100683195);
				PartnerCookBehaviour.__c.NativeMethodInfoPtr__HasInventorySufficientForTargetFood_b__13_0_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c>.NativeClassPtr, 100683196);
				PartnerCookBehaviour.__c.NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__14_2_Internal_Int32_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c>.NativeClassPtr, 100683197);
				PartnerCookBehaviour.__c.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__27_4_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c>.NativeClassPtr, 100683198);
				PartnerCookBehaviour.__c.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__27_6_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c>.NativeClassPtr, 100683199);
			}

			// Token: 0x0600F664 RID: 63076 RVA: 0x003A26AC File Offset: 0x003A08AC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerCookBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F665 RID: 63077 RVA: 0x003A26E8 File Offset: 0x003A08E8
			[CallerCount(0)]
			public unsafe IEnumerable<int> _HasInventorySufficientForTargetFood_b__13_0(Il2CppStructArray<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c.NativeMethodInfoPtr__HasInventorySufficientForTargetFood_b__13_0_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600F666 RID: 63078 RVA: 0x003A2738 File Offset: 0x003A0938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238217, XrefRangeEnd = 238218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CheckIfNeedToCookForTargetOrder_b__14_2(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c.NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__14_2_Internal_Int32_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F667 RID: 63079 RVA: 0x003A278C File Offset: 0x003A098C
			[CallerCount(0)]
			public unsafe IEnumerable<int> _EmployeeCookingCoroutine_b__27_4(Il2CppStructArray<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__27_4_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600F668 RID: 63080 RVA: 0x003A27DC File Offset: 0x003A09DC
			[CallerCount(0)]
			public unsafe IEnumerable<int> _EmployeeCookingCoroutine_b__27_6(Il2CppStructArray<int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__27_6_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600F669 RID: 63081 RVA: 0x0008453A File Offset: 0x0008273A
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005014 RID: 20500
			// (get) Token: 0x0600F66A RID: 63082 RVA: 0x003A282C File Offset: 0x003A0A2C
			// (set) Token: 0x0600F66B RID: 63083 RVA: 0x00084543 File Offset: 0x00082743
			public unsafe static PartnerCookBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerCookBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerCookBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerCookBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005015 RID: 20501
			// (get) Token: 0x0600F66C RID: 63084 RVA: 0x003A2854 File Offset: 0x003A0A54
			// (set) Token: 0x0600F66D RID: 63085 RVA: 0x00084555 File Offset: 0x00082755
			public unsafe static Func<Il2CppStructArray<int>, IEnumerable<int>> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerCookBehaviour.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStructArray<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerCookBehaviour.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005016 RID: 20502
			// (get) Token: 0x0600F66E RID: 63086 RVA: 0x003A287C File Offset: 0x003A0A7C
			// (set) Token: 0x0600F66F RID: 63087 RVA: 0x00084567 File Offset: 0x00082767
			public unsafe static Func<KeyValuePair<int, int>, int> __9__14_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerCookBehaviour.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerCookBehaviour.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005017 RID: 20503
			// (get) Token: 0x0600F670 RID: 63088 RVA: 0x003A28A4 File Offset: 0x003A0AA4
			// (set) Token: 0x0600F671 RID: 63089 RVA: 0x00084579 File Offset: 0x00082779
			public unsafe static Func<Il2CppStructArray<int>, IEnumerable<int>> __9__27_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerCookBehaviour.__c.NativeFieldInfoPtr___9__27_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStructArray<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerCookBehaviour.__c.NativeFieldInfoPtr___9__27_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005018 RID: 20504
			// (get) Token: 0x0600F672 RID: 63090 RVA: 0x003A28CC File Offset: 0x003A0ACC
			// (set) Token: 0x0600F673 RID: 63091 RVA: 0x0008458B File Offset: 0x0008278B
			public unsafe static Func<Il2CppStructArray<int>, IEnumerable<int>> __9__27_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerCookBehaviour.__c.NativeFieldInfoPtr___9__27_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStructArray<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerCookBehaviour.__c.NativeFieldInfoPtr___9__27_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CE9 RID: 40169
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009CEA RID: 40170
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04009CEB RID: 40171
			private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x04009CEC RID: 40172
			private static readonly IntPtr NativeFieldInfoPtr___9__27_4;

			// Token: 0x04009CED RID: 40173
			private static readonly IntPtr NativeFieldInfoPtr___9__27_6;

			// Token: 0x04009CEE RID: 40174
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CEF RID: 40175
			private static readonly IntPtr NativeMethodInfoPtr__HasInventorySufficientForTargetFood_b__13_0_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0;

			// Token: 0x04009CF0 RID: 40176
			private static readonly IntPtr NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__14_2_Internal_Int32_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04009CF1 RID: 40177
			private static readonly IntPtr NativeMethodInfoPtr__EmployeeCookingCoroutine_b__27_4_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0;

			// Token: 0x04009CF2 RID: 40178
			private static readonly IntPtr NativeMethodInfoPtr__EmployeeCookingCoroutine_b__27_6_Internal_IEnumerable_1_Int32_Il2CppStructArray_1_Int32_0;
		}

		// Token: 0x02000D7E RID: 3454
		[ObfuscatedName("GameData.Profile.PartnerCookBehaviour+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F674 RID: 63092 RVA: 0x003A28F4 File Offset: 0x003A0AF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass14_0>.NativeClassPtr);
				PartnerCookBehaviour.__c__DisplayClass14_0.NativeFieldInfoPtr_requestedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass14_0>.NativeClassPtr, "requestedData");
				PartnerCookBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass14_0>.NativeClassPtr, 100683200);
				PartnerCookBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__0_Internal_Boolean_OrderBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass14_0>.NativeClassPtr, 100683201);
				PartnerCookBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__1_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass14_0>.NativeClassPtr, 100683202);
				PartnerCookBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__3_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass14_0>.NativeClassPtr, 100683203);
				PartnerCookBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__4_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass14_0>.NativeClassPtr, 100683204);
				PartnerCookBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__5_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass14_0>.NativeClassPtr, 100683205);
			}

			// Token: 0x0600F675 RID: 63093 RVA: 0x003A29AC File Offset: 0x003A0BAC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F676 RID: 63094 RVA: 0x003A29E8 File Offset: 0x003A0BE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238218, XrefRangeEnd = 238221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckIfNeedToCookForTargetOrder_b__0(GuestsManager.OrderBase x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__0_Internal_Boolean_OrderBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F677 RID: 63095 RVA: 0x003A2A38 File Offset: 0x003A0C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238221, XrefRangeEnd = 238222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckIfNeedToCookForTargetOrder_b__1(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__1_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F678 RID: 63096 RVA: 0x003A2A8C File Offset: 0x003A0C8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238222, XrefRangeEnd = 238223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckIfNeedToCookForTargetOrder_b__3(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__3_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F679 RID: 63097 RVA: 0x003A2ADC File Offset: 0x003A0CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238223, XrefRangeEnd = 238224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckIfNeedToCookForTargetOrder_b__4(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__4_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F67A RID: 63098 RVA: 0x003A2B2C File Offset: 0x003A0D2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238224, XrefRangeEnd = 238225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckIfNeedToCookForTargetOrder_b__5(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c__DisplayClass14_0.NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__5_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F67B RID: 63099 RVA: 0x0008459D File Offset: 0x0008279D
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005019 RID: 20505
			// (get) Token: 0x0600F67C RID: 63100 RVA: 0x003A2B7C File Offset: 0x003A0D7C
			// (set) Token: 0x0600F67D RID: 63101 RVA: 0x000845A6 File Offset: 0x000827A6
			public unsafe int requestedData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.__c__DisplayClass14_0.NativeFieldInfoPtr_requestedData);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.__c__DisplayClass14_0.NativeFieldInfoPtr_requestedData)) = value;
				}
			}

			// Token: 0x04009CF3 RID: 40179
			private static readonly IntPtr NativeFieldInfoPtr_requestedData;

			// Token: 0x04009CF4 RID: 40180
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CF5 RID: 40181
			private static readonly IntPtr NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__0_Internal_Boolean_OrderBase_0;

			// Token: 0x04009CF6 RID: 40182
			private static readonly IntPtr NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__1_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x04009CF7 RID: 40183
			private static readonly IntPtr NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__3_Internal_Boolean_Sellable_0;

			// Token: 0x04009CF8 RID: 40184
			private static readonly IntPtr NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__4_Internal_Boolean_Sellable_0;

			// Token: 0x04009CF9 RID: 40185
			private static readonly IntPtr NativeMethodInfoPtr__CheckIfNeedToCookForTargetOrder_b__5_Internal_Boolean_CookController_0;
		}

		// Token: 0x02000D7F RID: 3455
		[ObfuscatedName("GameData.Profile.PartnerCookBehaviour+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F67E RID: 63102 RVA: 0x003A2BA4 File Offset: 0x003A0DA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_0>.NativeClassPtr);
				PartnerCookBehaviour.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				PartnerCookBehaviour.__c__DisplayClass27_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_0>.NativeClassPtr, "canContinue");
				PartnerCookBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_0>.NativeClassPtr, 100683206);
				PartnerCookBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_0>.NativeClassPtr, 100683207);
				PartnerCookBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_0>.NativeClassPtr, 100683208);
				PartnerCookBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_0>.NativeClassPtr, 100683209);
				PartnerCookBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_0>.NativeClassPtr, 100683210);
			}

			// Token: 0x0600F67F RID: 63103 RVA: 0x003A2C5C File Offset: 0x003A0E5C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F680 RID: 63104 RVA: 0x003A2C98 File Offset: 0x003A0E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238225, XrefRangeEnd = 238227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EmployeeCookingCoroutine_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F681 RID: 63105 RVA: 0x003A2CCC File Offset: 0x003A0ECC
			[CallerCount(0)]
			public unsafe void _EmployeeCookingCoroutine_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F682 RID: 63106 RVA: 0x003A2D00 File Offset: 0x003A0F00
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24573, RefRangeEnd = 24574, XrefRangeStart = 24573, XrefRangeEnd = 24574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EmployeeCookingCoroutine_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F683 RID: 63107 RVA: 0x003A2D3C File Offset: 0x003A0F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238227, XrefRangeEnd = 238234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EmployeeCookingCoroutine_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F684 RID: 63108 RVA: 0x000845C1 File Offset: 0x000827C1
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700501A RID: 20506
			// (get) Token: 0x0600F685 RID: 63109 RVA: 0x003A2D70 File Offset: 0x003A0F70
			// (set) Token: 0x0600F686 RID: 63110 RVA: 0x000845CA File Offset: 0x000827CA
			public unsafe PartnerCookBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerCookBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700501B RID: 20507
			// (get) Token: 0x0600F687 RID: 63111 RVA: 0x003A2DA0 File Offset: 0x003A0FA0
			// (set) Token: 0x0600F688 RID: 63112 RVA: 0x000845E9 File Offset: 0x000827E9
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.__c__DisplayClass27_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.__c__DisplayClass27_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x04009CFA RID: 40186
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009CFB RID: 40187
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x04009CFC RID: 40188
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CFD RID: 40189
			private static readonly IntPtr NativeMethodInfoPtr__EmployeeCookingCoroutine_b__0_Internal_Void_0;

			// Token: 0x04009CFE RID: 40190
			private static readonly IntPtr NativeMethodInfoPtr__EmployeeCookingCoroutine_b__1_Internal_Void_0;

			// Token: 0x04009CFF RID: 40191
			private static readonly IntPtr NativeMethodInfoPtr__EmployeeCookingCoroutine_b__2_Internal_Boolean_0;

			// Token: 0x04009D00 RID: 40192
			private static readonly IntPtr NativeMethodInfoPtr__EmployeeCookingCoroutine_b__3_Internal_Void_0;
		}

		// Token: 0x02000D80 RID: 3456
		[ObfuscatedName("GameData.Profile.PartnerCookBehaviour+<>c__DisplayClass27_1")]
		public sealed class __c__DisplayClass27_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F689 RID: 63113 RVA: 0x003A2DC8 File Offset: 0x003A0FC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_1()
			{
				Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, "<>c__DisplayClass27_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_1>.NativeClassPtr);
				PartnerCookBehaviour.__c__DisplayClass27_1.NativeFieldInfoPtr_extraCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_1>.NativeClassPtr, "extraCost");
				PartnerCookBehaviour.__c__DisplayClass27_1.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_1>.NativeClassPtr, "CS$<>8__locals1");
				PartnerCookBehaviour.__c__DisplayClass27_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_1>.NativeClassPtr, 100683211);
				PartnerCookBehaviour.__c__DisplayClass27_1.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_1>.NativeClassPtr, 100683212);
			}

			// Token: 0x0600F68A RID: 63114 RVA: 0x003A2E44 File Offset: 0x003A1044
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerCookBehaviour.__c__DisplayClass27_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c__DisplayClass27_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F68B RID: 63115 RVA: 0x003A2E80 File Offset: 0x003A1080
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238234, XrefRangeEnd = 238299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EmployeeCookingCoroutine_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour.__c__DisplayClass27_1.NativeMethodInfoPtr__EmployeeCookingCoroutine_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F68C RID: 63116 RVA: 0x00084604 File Offset: 0x00082804
			public __c__DisplayClass27_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700501C RID: 20508
			// (get) Token: 0x0600F68D RID: 63117 RVA: 0x003A2EB4 File Offset: 0x003A10B4
			// (set) Token: 0x0600F68E RID: 63118 RVA: 0x0008460D File Offset: 0x0008280D
			public unsafe int extraCost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.__c__DisplayClass27_1.NativeFieldInfoPtr_extraCost);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.__c__DisplayClass27_1.NativeFieldInfoPtr_extraCost)) = value;
				}
			}

			// Token: 0x1700501D RID: 20509
			// (get) Token: 0x0600F68F RID: 63119 RVA: 0x003A2EDC File Offset: 0x003A10DC
			// (set) Token: 0x0600F690 RID: 63120 RVA: 0x00084628 File Offset: 0x00082828
			public unsafe PartnerCookBehaviour.__c__DisplayClass27_0 field_Public___c__DisplayClass27_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.__c__DisplayClass27_1.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerCookBehaviour.__c__DisplayClass27_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour.__c__DisplayClass27_1.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D01 RID: 40193
			private static readonly IntPtr NativeFieldInfoPtr_extraCost;

			// Token: 0x04009D02 RID: 40194
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0;

			// Token: 0x04009D03 RID: 40195
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D04 RID: 40196
			private static readonly IntPtr NativeMethodInfoPtr__EmployeeCookingCoroutine_b__5_Internal_Void_0;
		}

		// Token: 0x02000D81 RID: 3457
		[ObfuscatedName("GameData.Profile.PartnerCookBehaviour+<EmployeeCookingCoroutine>d__27")]
		public sealed class _EmployeeCookingCoroutine_d__27 : Il2CppSystem.Object
		{
			// Token: 0x0600F691 RID: 63121 RVA: 0x003A2F0C File Offset: 0x003A110C
			// Note: this type is marked as 'beforefieldinit'.
			static _EmployeeCookingCoroutine_d__27()
			{
				Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerCookBehaviour>.NativeClassPtr, "<EmployeeCookingCoroutine>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr);
				PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr, "<>1__state");
				PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr, "<>2__current");
				PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr, "<>4__this");
				PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr, "<>8__1");
				PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr__result_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr, "<result>5__2");
				PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr, 100683213);
				PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr, 100683214);
				PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr, 100683215);
				PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr, 100683216);
				PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr, 100683217);
				PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr, 100683218);
			}

			// Token: 0x0600F692 RID: 63122 RVA: 0x003A3014 File Offset: 0x003A1214
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EmployeeCookingCoroutine_d__27(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerCookBehaviour._EmployeeCookingCoroutine_d__27>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F693 RID: 63123 RVA: 0x003A305C File Offset: 0x003A125C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F694 RID: 63124 RVA: 0x003A3090 File Offset: 0x003A1290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238299, XrefRangeEnd = 238455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005023 RID: 20515
			// (get) Token: 0x0600F695 RID: 63125 RVA: 0x003A30CC File Offset: 0x003A12CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F696 RID: 63126 RVA: 0x003A310C File Offset: 0x003A130C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238455, XrefRangeEnd = 238461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005024 RID: 20516
			// (get) Token: 0x0600F697 RID: 63127 RVA: 0x003A3140 File Offset: 0x003A1340
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F698 RID: 63128 RVA: 0x00084647 File Offset: 0x00082847
			public _EmployeeCookingCoroutine_d__27(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700501E RID: 20510
			// (get) Token: 0x0600F699 RID: 63129 RVA: 0x003A3180 File Offset: 0x003A1380
			// (set) Token: 0x0600F69A RID: 63130 RVA: 0x00084650 File Offset: 0x00082850
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700501F RID: 20511
			// (get) Token: 0x0600F69B RID: 63131 RVA: 0x003A31A8 File Offset: 0x003A13A8
			// (set) Token: 0x0600F69C RID: 63132 RVA: 0x0008466B File Offset: 0x0008286B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005020 RID: 20512
			// (get) Token: 0x0600F69D RID: 63133 RVA: 0x003A31D8 File Offset: 0x003A13D8
			// (set) Token: 0x0600F69E RID: 63134 RVA: 0x0008468A File Offset: 0x0008288A
			public unsafe PartnerCookBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerCookBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005021 RID: 20513
			// (get) Token: 0x0600F69F RID: 63135 RVA: 0x003A3208 File Offset: 0x003A1408
			// (set) Token: 0x0600F6A0 RID: 63136 RVA: 0x000846A9 File Offset: 0x000828A9
			public unsafe PartnerCookBehaviour.__c__DisplayClass27_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerCookBehaviour.__c__DisplayClass27_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005022 RID: 20514
			// (get) Token: 0x0600F6A1 RID: 63137 RVA: 0x003A3238 File Offset: 0x003A1438
			// (set) Token: 0x0600F6A2 RID: 63138 RVA: 0x000846C8 File Offset: 0x000828C8
			public unsafe Sellable _result_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr__result_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerCookBehaviour._EmployeeCookingCoroutine_d__27.NativeFieldInfoPtr__result_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D05 RID: 40197
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009D06 RID: 40198
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009D07 RID: 40199
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009D08 RID: 40200
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04009D09 RID: 40201
			private static readonly IntPtr NativeFieldInfoPtr__result_5__2;

			// Token: 0x04009D0A RID: 40202
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009D0B RID: 40203
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D0C RID: 40204
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009D0D RID: 40205
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009D0E RID: 40206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009D0F RID: 40207
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
