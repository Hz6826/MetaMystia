using System;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using NightScene.UI.CookingUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002FF RID: 767
	public class CookerAssetBase : ScriptableObject
	{
		// Token: 0x06005C85 RID: 23685 RVA: 0x001D2348 File Offset: 0x001D0548
		// Note: this type is marked as 'beforefieldinit'.
		static CookerAssetBase()
		{
			Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "CookerAssetBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr);
			CookerAssetBase.NativeFieldInfoPtr_cookTimeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, "cookTimeMultiplier");
			CookerAssetBase.NativeFieldInfoPtr_additiveNextOrderProb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, "additiveNextOrderProb");
			CookerAssetBase.NativeFieldInfoPtr_canNotOpenByPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, "canNotOpenByPartner");
			CookerAssetBase.NativeFieldInfoPtr_cookTimeMultiplierCanUseByPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, "cookTimeMultiplierCanUseByPartner");
			CookerAssetBase.NativeMethodInfoPtr_get_IncludesGeneralData_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682416);
			CookerAssetBase.NativeMethodInfoPtr_OnGetNormalGuests_Public_Virtual_New_IEnumerable_1_IEnumerable_1_NormalGuest_IEnumerable_1_IEnumerable_1_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682417);
			CookerAssetBase.NativeMethodInfoPtr_OnGetCookerOutput_Public_Virtual_New_IEnumerable_1_MatchedCookCombo_IEnumerable_1_MatchedCookCombo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682418);
			CookerAssetBase.NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_New_Single_CookController_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682419);
			CookerAssetBase.NativeMethodInfoPtr_ExtraAdditiveNextOrderProb_Public_Virtual_New_Single_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682420);
			CookerAssetBase.NativeMethodInfoPtr_OnStartCook_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682421);
			CookerAssetBase.NativeMethodInfoPtr_OnFinishCook_Public_Virtual_New_Sellable_Sellable_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682422);
			CookerAssetBase.NativeMethodInfoPtr_OnEvaluate_Public_Virtual_New_Int32_Int32_GuestGroupController_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682423);
			CookerAssetBase.NativeMethodInfoPtr_GetText_Public_ObjectLanguageBase_ObjectLanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682424);
			CookerAssetBase.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682425);
			CookerAssetBase.NativeMethodInfoPtr_ShouldShowThisCookerBG_Public_Virtual_New_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682426);
			CookerAssetBase.NativeMethodInfoPtr_OnPlayerFinishExtract_Public_Virtual_New_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682427);
			CookerAssetBase.NativeMethodInfoPtr_WhenPlayerTryExtractWithFullTray_Public_Virtual_New_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682428);
			CookerAssetBase.NativeMethodInfoPtr_get_ExtraAvailableCookerType_Public_Virtual_New_get_Il2CppStructArray_1_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682429);
			CookerAssetBase.NativeMethodInfoPtr_get_OverrideTypeName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682430);
			CookerAssetBase.NativeMethodInfoPtr_OverrideStartSFX_Public_Virtual_New_AudioClip_CookerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682431);
			CookerAssetBase.NativeMethodInfoPtr_OnCookerWorkTimeUpdate_Public_Virtual_New_Void_CookController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682432);
			CookerAssetBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr, 100682433);
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x06005C86 RID: 23686 RVA: 0x001D2530 File Offset: 0x001D0730
		public unsafe virtual bool IncludesGeneralData
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_get_IncludesGeneralData_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005C87 RID: 23687 RVA: 0x001D2578 File Offset: 0x001D0778
		[CallerCount(0)]
		public unsafe virtual IEnumerable<IEnumerable<NormalGuest>> OnGetNormalGuests(IEnumerable<IEnumerable<NormalGuest>> preFillteredGuests)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preFillteredGuests);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_OnGetNormalGuests_Public_Virtual_New_IEnumerable_1_IEnumerable_1_NormalGuest_IEnumerable_1_IEnumerable_1_NormalGuest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<NormalGuest>>>(intPtr3) : null;
		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x001D25D4 File Offset: 0x001D07D4
		[CallerCount(0)]
		public unsafe virtual IEnumerable<WorkSceneCookingSelectionPannel.MatchedCookCombo> OnGetCookerOutput(IEnumerable<WorkSceneCookingSelectionPannel.MatchedCookCombo> preFillteredRecipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preFillteredRecipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_OnGetCookerOutput_Public_Virtual_New_IEnumerable_1_MatchedCookCombo_IEnumerable_1_MatchedCookCombo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WorkSceneCookingSelectionPannel.MatchedCookCombo>>(intPtr3) : null;
		}

		// Token: 0x06005C89 RID: 23689 RVA: 0x001D2630 File Offset: 0x001D0830
		[CallerCount(0)]
		public unsafe virtual float ExtraCookTimeMultiplier(CookController targetCooker, Sellable food)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetCooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_New_Single_CookController_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C8A RID: 23690 RVA: 0x001D269C File Offset: 0x001D089C
		[CallerCount(0)]
		public unsafe virtual float ExtraAdditiveNextOrderProb(Sellable food)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(food);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_ExtraAdditiveNextOrderProb_Public_Virtual_New_Single_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C8B RID: 23691 RVA: 0x001D26F4 File Offset: 0x001D08F4
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStartCook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_OnStartCook_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C8C RID: 23692 RVA: 0x001D2730 File Offset: 0x001D0930
		[CallerCount(0)]
		public unsafe virtual Sellable OnFinishCook(Sellable finishedFood, float qteScore, bool couldReturnIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(finishedFood);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qteScore;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref couldReturnIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_OnFinishCook_Public_Virtual_New_Sellable_Sellable_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x06005C8D RID: 23693 RVA: 0x001D27A8 File Offset: 0x001D09A8
		[CallerCount(0)]
		public unsafe virtual int OnEvaluate(int evaluationResult, GuestGroupController guestGroupController, Sellable serveFood)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref evaluationResult;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serveFood);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_OnEvaluate_Public_Virtual_New_Int32_Int32_GuestGroupController_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C8E RID: 23694 RVA: 0x001D2820 File Offset: 0x001D0A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232432, RefRangeEnd = 232433, XrefRangeStart = 232392, XrefRangeEnd = 232432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectLanguageBase GetText(ObjectLanguageBase baseLanguageData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseLanguageData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookerAssetBase.NativeMethodInfoPtr_GetText_Public_ObjectLanguageBase_ObjectLanguageBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x06005C8F RID: 23695 RVA: 0x001D2870 File Offset: 0x001D0A70
		[CallerCount(0)]
		public unsafe virtual string ProcessBaseDescriptionCallback(string baseDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x001D28C4 File Offset: 0x001D0AC4
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldShowThisCookerBG(Sellable outputFood)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputFood);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_ShouldShowThisCookerBG_Public_Virtual_New_Boolean_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x001D291C File Offset: 0x001D0B1C
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPlayerFinishExtract(CookController targetCooker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetCooker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_OnPlayerFinishExtract_Public_Virtual_New_Void_CookController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x001D296C File Offset: 0x001D0B6C
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WhenPlayerTryExtractWithFullTray(CookController targetCooker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetCooker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_WhenPlayerTryExtractWithFullTray_Public_Virtual_New_Void_CookController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x06005C93 RID: 23699 RVA: 0x001D29BC File Offset: 0x001D0BBC
		public unsafe virtual Il2CppStructArray<Cooker.CookerType> ExtraAvailableCookerType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232433, XrefRangeEnd = 232436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_get_ExtraAvailableCookerType_Public_Virtual_New_get_Il2CppStructArray_1_CookerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Cooker.CookerType>>(intPtr3) : null;
			}
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x06005C94 RID: 23700 RVA: 0x001D2A08 File Offset: 0x001D0C08
		public unsafe virtual string OverrideTypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232436, XrefRangeEnd = 232438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_get_OverrideTypeName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x001D2A4C File Offset: 0x001D0C4C
		[CallerCount(84)]
		[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AudioClip OverrideStartSFX(Cooker.CookerType cookerType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cookerType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_OverrideStartSFX_Public_Virtual_New_AudioClip_CookerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x001D2AA4 File Offset: 0x001D0CA4
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCookerWorkTimeUpdate(CookController targetCooker, float oldWorkTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetCooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldWorkTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookerAssetBase.NativeMethodInfoPtr_OnCookerWorkTimeUpdate_Public_Virtual_New_Void_CookController_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x001D2B00 File Offset: 0x001D0D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookerAssetBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookerAssetBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookerAssetBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x00032891 File Offset: 0x00030A91
		public CookerAssetBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x06005C99 RID: 23705 RVA: 0x001D2B3C File Offset: 0x001D0D3C
		// (set) Token: 0x06005C9A RID: 23706 RVA: 0x0003289A File Offset: 0x00030A9A
		public unsafe float cookTimeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerAssetBase.NativeFieldInfoPtr_cookTimeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerAssetBase.NativeFieldInfoPtr_cookTimeMultiplier)) = value;
			}
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x06005C9B RID: 23707 RVA: 0x001D2B64 File Offset: 0x001D0D64
		// (set) Token: 0x06005C9C RID: 23708 RVA: 0x000328B5 File Offset: 0x00030AB5
		public unsafe float additiveNextOrderProb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerAssetBase.NativeFieldInfoPtr_additiveNextOrderProb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerAssetBase.NativeFieldInfoPtr_additiveNextOrderProb)) = value;
			}
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x06005C9D RID: 23709 RVA: 0x001D2B8C File Offset: 0x001D0D8C
		// (set) Token: 0x06005C9E RID: 23710 RVA: 0x000328D0 File Offset: 0x00030AD0
		public unsafe bool canNotOpenByPartner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerAssetBase.NativeFieldInfoPtr_canNotOpenByPartner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerAssetBase.NativeFieldInfoPtr_canNotOpenByPartner)) = value;
			}
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x06005C9F RID: 23711 RVA: 0x001D2BB4 File Offset: 0x001D0DB4
		// (set) Token: 0x06005CA0 RID: 23712 RVA: 0x000328EB File Offset: 0x00030AEB
		public unsafe bool cookTimeMultiplierCanUseByPartner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerAssetBase.NativeFieldInfoPtr_cookTimeMultiplierCanUseByPartner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerAssetBase.NativeFieldInfoPtr_cookTimeMultiplierCanUseByPartner)) = value;
			}
		}

		// Token: 0x04003D48 RID: 15688
		private static readonly IntPtr NativeFieldInfoPtr_cookTimeMultiplier;

		// Token: 0x04003D49 RID: 15689
		private static readonly IntPtr NativeFieldInfoPtr_additiveNextOrderProb;

		// Token: 0x04003D4A RID: 15690
		private static readonly IntPtr NativeFieldInfoPtr_canNotOpenByPartner;

		// Token: 0x04003D4B RID: 15691
		private static readonly IntPtr NativeFieldInfoPtr_cookTimeMultiplierCanUseByPartner;

		// Token: 0x04003D4C RID: 15692
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludesGeneralData_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04003D4D RID: 15693
		private static readonly IntPtr NativeMethodInfoPtr_OnGetNormalGuests_Public_Virtual_New_IEnumerable_1_IEnumerable_1_NormalGuest_IEnumerable_1_IEnumerable_1_NormalGuest_0;

		// Token: 0x04003D4E RID: 15694
		private static readonly IntPtr NativeMethodInfoPtr_OnGetCookerOutput_Public_Virtual_New_IEnumerable_1_MatchedCookCombo_IEnumerable_1_MatchedCookCombo_0;

		// Token: 0x04003D4F RID: 15695
		private static readonly IntPtr NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_New_Single_CookController_Sellable_0;

		// Token: 0x04003D50 RID: 15696
		private static readonly IntPtr NativeMethodInfoPtr_ExtraAdditiveNextOrderProb_Public_Virtual_New_Single_Sellable_0;

		// Token: 0x04003D51 RID: 15697
		private static readonly IntPtr NativeMethodInfoPtr_OnStartCook_Public_Virtual_New_Void_0;

		// Token: 0x04003D52 RID: 15698
		private static readonly IntPtr NativeMethodInfoPtr_OnFinishCook_Public_Virtual_New_Sellable_Sellable_Single_Boolean_0;

		// Token: 0x04003D53 RID: 15699
		private static readonly IntPtr NativeMethodInfoPtr_OnEvaluate_Public_Virtual_New_Int32_Int32_GuestGroupController_Sellable_0;

		// Token: 0x04003D54 RID: 15700
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_ObjectLanguageBase_ObjectLanguageBase_0;

		// Token: 0x04003D55 RID: 15701
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_New_String_String_0;

		// Token: 0x04003D56 RID: 15702
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowThisCookerBG_Public_Virtual_New_Boolean_Sellable_0;

		// Token: 0x04003D57 RID: 15703
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerFinishExtract_Public_Virtual_New_Void_CookController_0;

		// Token: 0x04003D58 RID: 15704
		private static readonly IntPtr NativeMethodInfoPtr_WhenPlayerTryExtractWithFullTray_Public_Virtual_New_Void_CookController_0;

		// Token: 0x04003D59 RID: 15705
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtraAvailableCookerType_Public_Virtual_New_get_Il2CppStructArray_1_CookerType_0;

		// Token: 0x04003D5A RID: 15706
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideTypeName_Public_Virtual_New_get_String_0;

		// Token: 0x04003D5B RID: 15707
		private static readonly IntPtr NativeMethodInfoPtr_OverrideStartSFX_Public_Virtual_New_AudioClip_CookerType_0;

		// Token: 0x04003D5C RID: 15708
		private static readonly IntPtr NativeMethodInfoPtr_OnCookerWorkTimeUpdate_Public_Virtual_New_Void_CookController_Single_0;

		// Token: 0x04003D5D RID: 15709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
