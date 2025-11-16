using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200012D RID: 301
	public class IRogueLikeCustomizedDataProfile : Il2CppObjectBase
	{
		// Token: 0x06002301 RID: 8961 RVA: 0x0011246C File Offset: 0x0011066C
		// Note: this type is marked as 'beforefieldinit'.
		static IRogueLikeCustomizedDataProfile()
		{
			Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "IRogueLikeCustomizedDataProfile");
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_InitialProducts_Public_Abstract_Virtual_New_get_IReadOnlyList_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669479);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_InitialRecipePool_Public_Abstract_Virtual_New_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669480);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_InitialBevPool_Public_Abstract_Virtual_New_get_IReadOnlyList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669481);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BevLevelLinkToNum_Public_Abstract_Virtual_New_get_IReadOnlyList_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669482);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_RoundSetups_Public_Abstract_Virtual_New_get_IReadOnlyList_1_RogueLikeRoundSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669483);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_MapSetups_Public_Abstract_Virtual_New_get_IReadOnlyList_1_MapSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669484);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_CookerPriceSetups_Public_Abstract_Virtual_New_get_IReadOnlyList_1_CookerPriceSetup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669485);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaTriggerData_Public_Abstract_Virtual_New_get_IReadOnlyList_1_TriggerCardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669486);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaRewardPairData_Public_Abstract_Virtual_New_get_IReadOnlyList_1_RogueLikeCardRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669487);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_RoundDuration_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669488);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GlobalProductMultiplier_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669489);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level1RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669490);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level2RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669491);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level3RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669492);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level4RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669493);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level5RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669494);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_PartnerBasePrice_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669495);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_SpecialGuestPrice_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669496);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_EliteSpecialGuestPrice_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669497);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_ClothesPrice_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669498);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_DecorationPrice_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669499);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaNeedComboNum_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669500);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaNeedSpellNum_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669501);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaMaxCardNum_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669502);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BeginToSpawnDangerousCardRoundIndex_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669503);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_UnlockAllLevel2SpotRoundIndex_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669504);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_UnlockAllLevel3SpotRoundIndex_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669505);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_LuckyLeafExtraMultiplier_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669506);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_AyaNewsBeginRoundIndex_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669507);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_PriceToRefreshAyaNews_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669508);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_AkyuuWashiPrice_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669509);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_EllenCandyPrice_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669510);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_KourindouDiscount_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669511);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaRecipeInitialNum_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669512);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaBevInitialNum_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669513);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_SelectRecipeInitialNum_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669514);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BaseGachaNumWhenSettle_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669515);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BaseMoveAction_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669516);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BaseIngredientNumWhenGetRecipe_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669517);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_StartFund_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669518);
			IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_SpecialGuestVisitEverywhere_Public_Abstract_Virtual_New_get_IReadOnlyList_1_ConditionalSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRogueLikeCustomizedDataProfile>.NativeClassPtr, 100669519);
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x001127C8 File Offset: 0x001109C8
		public unsafe virtual IReadOnlyList<Product> InitialProducts
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_InitialProducts_Public_Abstract_Virtual_New_get_IReadOnlyList_1_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Product>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x00112814 File Offset: 0x00110A14
		public unsafe virtual IReadOnlyList<int> InitialRecipePool
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_InitialRecipePool_Public_Abstract_Virtual_New_get_IReadOnlyList_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x00112860 File Offset: 0x00110A60
		public unsafe virtual IReadOnlyList<int> InitialBevPool
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_InitialBevPool_Public_Abstract_Virtual_New_get_IReadOnlyList_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x001128AC File Offset: 0x00110AAC
		public unsafe virtual IReadOnlyList<Vector2Int> BevLevelLinkToNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BevLevelLinkToNum_Public_Abstract_Virtual_New_get_IReadOnlyList_1_Vector2Int_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Vector2Int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x001128F8 File Offset: 0x00110AF8
		public unsafe virtual IReadOnlyList<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup> RoundSetups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_RoundSetups_Public_Abstract_Virtual_New_get_IReadOnlyList_1_RogueLikeRoundSetup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x00112944 File Offset: 0x00110B44
		public unsafe virtual IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup> MapSetups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_MapSetups_Public_Abstract_Virtual_New_get_IReadOnlyList_1_MapSetup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x00112990 File Offset: 0x00110B90
		public unsafe virtual IReadOnlyList<DLC5_RogueLikeDataProfile.CookerPriceSetup> CookerPriceSetups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_CookerPriceSetups_Public_Abstract_Virtual_New_get_IReadOnlyList_1_CookerPriceSetup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.CookerPriceSetup>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x001129DC File Offset: 0x00110BDC
		public unsafe virtual IReadOnlyList<TriggerCardData> GachaTriggerData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaTriggerData_Public_Abstract_Virtual_New_get_IReadOnlyList_1_TriggerCardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<TriggerCardData>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x00112A28 File Offset: 0x00110C28
		public unsafe virtual IReadOnlyList<RogueLikeCardRewardPair> GachaRewardPairData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaRewardPairData_Public_Abstract_Virtual_New_get_IReadOnlyList_1_RogueLikeCardRewardPair_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<RogueLikeCardRewardPair>>(intPtr3) : null;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x00112A74 File Offset: 0x00110C74
		public unsafe virtual int RoundDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_RoundDuration_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x00112ABC File Offset: 0x00110CBC
		public unsafe virtual float GlobalProductMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GlobalProductMultiplier_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x00112B04 File Offset: 0x00110D04
		public unsafe virtual float Level1RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level1RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x00112B4C File Offset: 0x00110D4C
		public unsafe virtual float Level2RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level2RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x00112B94 File Offset: 0x00110D94
		public unsafe virtual float Level3RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level3RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002310 RID: 8976 RVA: 0x00112BDC File Offset: 0x00110DDC
		public unsafe virtual float Level4RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level4RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x00112C24 File Offset: 0x00110E24
		public unsafe virtual float Level5RecipePriceMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_Level5RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06002312 RID: 8978 RVA: 0x00112C6C File Offset: 0x00110E6C
		public unsafe virtual int PartnerBasePrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_PartnerBasePrice_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x00112CB4 File Offset: 0x00110EB4
		public unsafe virtual int SpecialGuestPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_SpecialGuestPrice_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x00112CFC File Offset: 0x00110EFC
		public unsafe virtual int EliteSpecialGuestPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_EliteSpecialGuestPrice_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x00112D44 File Offset: 0x00110F44
		public unsafe virtual int ClothesPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_ClothesPrice_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x00112D8C File Offset: 0x00110F8C
		public unsafe virtual int DecorationPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_DecorationPrice_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x00112DD4 File Offset: 0x00110FD4
		public unsafe virtual int GachaNeedComboNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaNeedComboNum_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x00112E1C File Offset: 0x0011101C
		public unsafe virtual int GachaNeedSpellNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaNeedSpellNum_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x00112E64 File Offset: 0x00111064
		public unsafe virtual int GachaMaxCardNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaMaxCardNum_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x00112EAC File Offset: 0x001110AC
		public unsafe virtual int BeginToSpawnDangerousCardRoundIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BeginToSpawnDangerousCardRoundIndex_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x00112EF4 File Offset: 0x001110F4
		public unsafe virtual int UnlockAllLevel2SpotRoundIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_UnlockAllLevel2SpotRoundIndex_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x00112F3C File Offset: 0x0011113C
		public unsafe virtual int UnlockAllLevel3SpotRoundIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_UnlockAllLevel3SpotRoundIndex_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x00112F84 File Offset: 0x00111184
		public unsafe virtual float LuckyLeafExtraMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_LuckyLeafExtraMultiplier_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x00112FCC File Offset: 0x001111CC
		public unsafe virtual int AyaNewsBeginRoundIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_AyaNewsBeginRoundIndex_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x00113014 File Offset: 0x00111214
		public unsafe virtual int PriceToRefreshAyaNews
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_PriceToRefreshAyaNews_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x0011305C File Offset: 0x0011125C
		public unsafe virtual int AkyuuWashiPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_AkyuuWashiPrice_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x001130A4 File Offset: 0x001112A4
		public unsafe virtual int EllenCandyPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_EllenCandyPrice_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x001130EC File Offset: 0x001112EC
		public unsafe virtual float KourindouDiscount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_KourindouDiscount_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x00113134 File Offset: 0x00111334
		public unsafe virtual int GachaRecipeInitialNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaRecipeInitialNum_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x0011317C File Offset: 0x0011137C
		public unsafe virtual int GachaBevInitialNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_GachaBevInitialNum_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x001131C4 File Offset: 0x001113C4
		public unsafe virtual int SelectRecipeInitialNum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_SelectRecipeInitialNum_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x0011320C File Offset: 0x0011140C
		public unsafe virtual int BaseGachaNumWhenSettle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BaseGachaNumWhenSettle_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x00113254 File Offset: 0x00111454
		public unsafe virtual int BaseMoveAction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BaseMoveAction_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x0011329C File Offset: 0x0011149C
		public unsafe virtual int BaseIngredientNumWhenGetRecipe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_BaseIngredientNumWhenGetRecipe_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x001132E4 File Offset: 0x001114E4
		public unsafe virtual int StartFund
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_StartFund_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x0011332C File Offset: 0x0011152C
		public unsafe virtual IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> SpecialGuestVisitEverywhere
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRogueLikeCustomizedDataProfile.NativeMethodInfoPtr_get_SpecialGuestVisitEverywhere_Public_Abstract_Virtual_New_get_IReadOnlyList_1_ConditionalSpecialGuest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest>>(intPtr3) : null;
			}
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x00015453 File Offset: 0x00013653
		public IRogueLikeCustomizedDataProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialProducts_Public_Abstract_Virtual_New_get_IReadOnlyList_1_Product_0;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialRecipePool_Public_Abstract_Virtual_New_get_IReadOnlyList_1_Int32_0;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeMethodInfoPtr_get_InitialBevPool_Public_Abstract_Virtual_New_get_IReadOnlyList_1_Int32_0;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeMethodInfoPtr_get_BevLevelLinkToNum_Public_Abstract_Virtual_New_get_IReadOnlyList_1_Vector2Int_0;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundSetups_Public_Abstract_Virtual_New_get_IReadOnlyList_1_RogueLikeRoundSetup_0;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeMethodInfoPtr_get_MapSetups_Public_Abstract_Virtual_New_get_IReadOnlyList_1_MapSetup_0;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeMethodInfoPtr_get_CookerPriceSetups_Public_Abstract_Virtual_New_get_IReadOnlyList_1_CookerPriceSetup_0;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaTriggerData_Public_Abstract_Virtual_New_get_IReadOnlyList_1_TriggerCardData_0;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaRewardPairData_Public_Abstract_Virtual_New_get_IReadOnlyList_1_RogueLikeCardRewardPair_0;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundDuration_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalProductMultiplier_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeMethodInfoPtr_get_Level1RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeMethodInfoPtr_get_Level2RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeMethodInfoPtr_get_Level3RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeMethodInfoPtr_get_Level4RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeMethodInfoPtr_get_Level5RecipePriceMultiplier_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr_get_PartnerBasePrice_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestPrice_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr_get_EliteSpecialGuestPrice_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_get_ClothesPrice_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeMethodInfoPtr_get_DecorationPrice_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaNeedComboNum_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaNeedSpellNum_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaMaxCardNum_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeMethodInfoPtr_get_BeginToSpawnDangerousCardRoundIndex_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockAllLevel2SpotRoundIndex_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockAllLevel3SpotRoundIndex_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_get_LuckyLeafExtraMultiplier_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_get_AyaNewsBeginRoundIndex_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_get_PriceToRefreshAyaNews_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_get_AkyuuWashiPrice_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_get_EllenCandyPrice_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr_get_KourindouDiscount_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaRecipeInitialNum_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_get_GachaBevInitialNum_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectRecipeInitialNum_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseGachaNumWhenSettle_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseMoveAction_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseIngredientNumWhenGetRecipe_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeMethodInfoPtr_get_StartFund_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestVisitEverywhere_Public_Abstract_Virtual_New_get_IReadOnlyList_1_ConditionalSpecialGuest_0;
	}
}
